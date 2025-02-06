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
    /// <summary>Settings for <see cref="EnvironmentsClient"/> instances.</summary>
    public sealed partial class EnvironmentsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="EnvironmentsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="EnvironmentsSettings"/>.</returns>
        public static EnvironmentsSettings GetDefault() => new EnvironmentsSettings();

        /// <summary>Constructs a new <see cref="EnvironmentsSettings"/> object with default settings.</summary>
        public EnvironmentsSettings()
        {
        }

        private EnvironmentsSettings(EnvironmentsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListEnvironmentsSettings = existing.ListEnvironmentsSettings;
            GetEnvironmentSettings = existing.GetEnvironmentSettings;
            CreateEnvironmentSettings = existing.CreateEnvironmentSettings;
            CreateEnvironmentOperationsSettings = existing.CreateEnvironmentOperationsSettings.Clone();
            UpdateEnvironmentSettings = existing.UpdateEnvironmentSettings;
            UpdateEnvironmentOperationsSettings = existing.UpdateEnvironmentOperationsSettings.Clone();
            DeleteEnvironmentSettings = existing.DeleteEnvironmentSettings;
            LookupEnvironmentHistorySettings = existing.LookupEnvironmentHistorySettings;
            RunContinuousTestSettings = existing.RunContinuousTestSettings;
            RunContinuousTestOperationsSettings = existing.RunContinuousTestOperationsSettings.Clone();
            ListContinuousTestResultsSettings = existing.ListContinuousTestResultsSettings;
            DeployFlowSettings = existing.DeployFlowSettings;
            DeployFlowOperationsSettings = existing.DeployFlowOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(EnvironmentsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnvironmentsClient.ListEnvironments</c> and <c>EnvironmentsClient.ListEnvironmentsAsync</c>.
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
        public gaxgrpc::CallSettings ListEnvironmentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnvironmentsClient.GetEnvironment</c> and <c>EnvironmentsClient.GetEnvironmentAsync</c>.
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
        public gaxgrpc::CallSettings GetEnvironmentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnvironmentsClient.CreateEnvironment</c> and <c>EnvironmentsClient.CreateEnvironmentAsync</c>.
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
        public gaxgrpc::CallSettings CreateEnvironmentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EnvironmentsClient.CreateEnvironment</c> and
        /// <c>EnvironmentsClient.CreateEnvironmentAsync</c>.
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
        public lro::OperationsSettings CreateEnvironmentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnvironmentsClient.UpdateEnvironment</c> and <c>EnvironmentsClient.UpdateEnvironmentAsync</c>.
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
        public gaxgrpc::CallSettings UpdateEnvironmentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EnvironmentsClient.UpdateEnvironment</c> and
        /// <c>EnvironmentsClient.UpdateEnvironmentAsync</c>.
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
        public lro::OperationsSettings UpdateEnvironmentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnvironmentsClient.DeleteEnvironment</c> and <c>EnvironmentsClient.DeleteEnvironmentAsync</c>.
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
        public gaxgrpc::CallSettings DeleteEnvironmentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnvironmentsClient.LookupEnvironmentHistory</c> and <c>EnvironmentsClient.LookupEnvironmentHistoryAsync</c>
        /// .
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
        public gaxgrpc::CallSettings LookupEnvironmentHistorySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnvironmentsClient.RunContinuousTest</c> and <c>EnvironmentsClient.RunContinuousTestAsync</c>.
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
        public gaxgrpc::CallSettings RunContinuousTestSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EnvironmentsClient.RunContinuousTest</c> and
        /// <c>EnvironmentsClient.RunContinuousTestAsync</c>.
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
        public lro::OperationsSettings RunContinuousTestOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnvironmentsClient.ListContinuousTestResults</c> and <c>EnvironmentsClient.ListContinuousTestResultsAsync</c>
        /// .
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
        public gaxgrpc::CallSettings ListContinuousTestResultsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnvironmentsClient.DeployFlow</c> and <c>EnvironmentsClient.DeployFlowAsync</c>.
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
        public gaxgrpc::CallSettings DeployFlowSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EnvironmentsClient.DeployFlow</c> and
        /// <c>EnvironmentsClient.DeployFlowAsync</c>.
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
        public lro::OperationsSettings DeployFlowOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="EnvironmentsSettings"/> object.</returns>
        public EnvironmentsSettings Clone() => new EnvironmentsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="EnvironmentsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class EnvironmentsClientBuilder : gaxgrpc::ClientBuilderBase<EnvironmentsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public EnvironmentsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public EnvironmentsClientBuilder() : base(EnvironmentsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref EnvironmentsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<EnvironmentsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override EnvironmentsClient Build()
        {
            EnvironmentsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<EnvironmentsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<EnvironmentsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private EnvironmentsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return EnvironmentsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<EnvironmentsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return EnvironmentsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => EnvironmentsClient.ChannelPool;
    }

    /// <summary>Environments client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing
    /// [Environments][google.cloud.dialogflow.cx.v3.Environment].
    /// </remarks>
    public abstract partial class EnvironmentsClient
    {
        /// <summary>
        /// The default endpoint for the Environments service, which is a host of "dialogflow.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dialogflow.googleapis.com:443";

        /// <summary>The default Environments scopes.</summary>
        /// <remarks>
        /// The default Environments scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Environments.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="EnvironmentsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="EnvironmentsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="EnvironmentsClient"/>.</returns>
        public static stt::Task<EnvironmentsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new EnvironmentsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="EnvironmentsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="EnvironmentsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="EnvironmentsClient"/>.</returns>
        public static EnvironmentsClient Create() => new EnvironmentsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="EnvironmentsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="EnvironmentsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="EnvironmentsClient"/>.</returns>
        internal static EnvironmentsClient Create(grpccore::CallInvoker callInvoker, EnvironmentsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Environments.EnvironmentsClient grpcClient = new Environments.EnvironmentsClient(callInvoker);
            return new EnvironmentsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Environments client</summary>
        public virtual Environments.EnvironmentsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all environments in the specified
        /// [Agent][google.cloud.dialogflow.cx.v3.Agent].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Environment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEnvironmentsResponse, Environment> ListEnvironments(ListEnvironmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all environments in the specified
        /// [Agent][google.cloud.dialogflow.cx.v3.Agent].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Environment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEnvironmentsResponse, Environment> ListEnvironmentsAsync(ListEnvironmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all environments in the specified
        /// [Agent][google.cloud.dialogflow.cx.v3.Agent].
        /// </summary>
        /// <param name="parent">
        /// Required. The [Agent][google.cloud.dialogflow.cx.v3.Agent] to list all
        /// environments for. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="Environment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEnvironmentsResponse, Environment> ListEnvironments(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEnvironmentsRequest request = new ListEnvironmentsRequest
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
            return ListEnvironments(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all environments in the specified
        /// [Agent][google.cloud.dialogflow.cx.v3.Agent].
        /// </summary>
        /// <param name="parent">
        /// Required. The [Agent][google.cloud.dialogflow.cx.v3.Agent] to list all
        /// environments for. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Environment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEnvironmentsResponse, Environment> ListEnvironmentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEnvironmentsRequest request = new ListEnvironmentsRequest
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
            return ListEnvironmentsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all environments in the specified
        /// [Agent][google.cloud.dialogflow.cx.v3.Agent].
        /// </summary>
        /// <param name="parent">
        /// Required. The [Agent][google.cloud.dialogflow.cx.v3.Agent] to list all
        /// environments for. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="Environment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEnvironmentsResponse, Environment> ListEnvironments(AgentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEnvironmentsRequest request = new ListEnvironmentsRequest
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
            return ListEnvironments(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all environments in the specified
        /// [Agent][google.cloud.dialogflow.cx.v3.Agent].
        /// </summary>
        /// <param name="parent">
        /// Required. The [Agent][google.cloud.dialogflow.cx.v3.Agent] to list all
        /// environments for. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Environment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEnvironmentsResponse, Environment> ListEnvironmentsAsync(AgentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEnvironmentsRequest request = new ListEnvironmentsRequest
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
            return ListEnvironmentsAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Environment GetEnvironment(GetEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Environment> GetEnvironmentAsync(GetEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Environment> GetEnvironmentAsync(GetEnvironmentRequest request, st::CancellationToken cancellationToken) =>
            GetEnvironmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment]. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Environment GetEnvironment(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEnvironment(new GetEnvironmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment]. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Environment> GetEnvironmentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEnvironmentAsync(new GetEnvironmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment]. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Environment> GetEnvironmentAsync(string name, st::CancellationToken cancellationToken) =>
            GetEnvironmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment]. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Environment GetEnvironment(EnvironmentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEnvironment(new GetEnvironmentRequest
            {
                EnvironmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment]. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Environment> GetEnvironmentAsync(EnvironmentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEnvironmentAsync(new GetEnvironmentRequest
            {
                EnvironmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment]. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Environment> GetEnvironmentAsync(EnvironmentName name, st::CancellationToken cancellationToken) =>
            GetEnvironmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an [Environment][google.cloud.dialogflow.cx.v3.Environment] in the
        /// specified [Agent][google.cloud.dialogflow.cx.v3.Agent].
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: [Environment][google.cloud.dialogflow.cx.v3.Environment]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Environment, wkt::Struct> CreateEnvironment(CreateEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an [Environment][google.cloud.dialogflow.cx.v3.Environment] in the
        /// specified [Agent][google.cloud.dialogflow.cx.v3.Agent].
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: [Environment][google.cloud.dialogflow.cx.v3.Environment]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Environment, wkt::Struct>> CreateEnvironmentAsync(CreateEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an [Environment][google.cloud.dialogflow.cx.v3.Environment] in the
        /// specified [Agent][google.cloud.dialogflow.cx.v3.Agent].
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: [Environment][google.cloud.dialogflow.cx.v3.Environment]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Environment, wkt::Struct>> CreateEnvironmentAsync(CreateEnvironmentRequest request, st::CancellationToken cancellationToken) =>
            CreateEnvironmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateEnvironment</c>.</summary>
        public virtual lro::OperationsClient CreateEnvironmentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateEnvironment</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Environment, wkt::Struct> PollOnceCreateEnvironment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Environment, wkt::Struct>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateEnvironmentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateEnvironment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Environment, wkt::Struct>> PollOnceCreateEnvironmentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Environment, wkt::Struct>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateEnvironmentOperationsClient, callSettings);

        /// <summary>
        /// Creates an [Environment][google.cloud.dialogflow.cx.v3.Environment] in the
        /// specified [Agent][google.cloud.dialogflow.cx.v3.Agent].
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: [Environment][google.cloud.dialogflow.cx.v3.Environment]
        /// </summary>
        /// <param name="parent">
        /// Required. The [Agent][google.cloud.dialogflow.cx.v3.Agent] to create an
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment] for. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
        /// </param>
        /// <param name="environment">
        /// Required. The environment to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Environment, wkt::Struct> CreateEnvironment(string parent, Environment environment, gaxgrpc::CallSettings callSettings = null) =>
            CreateEnvironment(new CreateEnvironmentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Environment = gax::GaxPreconditions.CheckNotNull(environment, nameof(environment)),
            }, callSettings);

        /// <summary>
        /// Creates an [Environment][google.cloud.dialogflow.cx.v3.Environment] in the
        /// specified [Agent][google.cloud.dialogflow.cx.v3.Agent].
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: [Environment][google.cloud.dialogflow.cx.v3.Environment]
        /// </summary>
        /// <param name="parent">
        /// Required. The [Agent][google.cloud.dialogflow.cx.v3.Agent] to create an
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment] for. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
        /// </param>
        /// <param name="environment">
        /// Required. The environment to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Environment, wkt::Struct>> CreateEnvironmentAsync(string parent, Environment environment, gaxgrpc::CallSettings callSettings = null) =>
            CreateEnvironmentAsync(new CreateEnvironmentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Environment = gax::GaxPreconditions.CheckNotNull(environment, nameof(environment)),
            }, callSettings);

        /// <summary>
        /// Creates an [Environment][google.cloud.dialogflow.cx.v3.Environment] in the
        /// specified [Agent][google.cloud.dialogflow.cx.v3.Agent].
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: [Environment][google.cloud.dialogflow.cx.v3.Environment]
        /// </summary>
        /// <param name="parent">
        /// Required. The [Agent][google.cloud.dialogflow.cx.v3.Agent] to create an
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment] for. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
        /// </param>
        /// <param name="environment">
        /// Required. The environment to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Environment, wkt::Struct>> CreateEnvironmentAsync(string parent, Environment environment, st::CancellationToken cancellationToken) =>
            CreateEnvironmentAsync(parent, environment, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an [Environment][google.cloud.dialogflow.cx.v3.Environment] in the
        /// specified [Agent][google.cloud.dialogflow.cx.v3.Agent].
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: [Environment][google.cloud.dialogflow.cx.v3.Environment]
        /// </summary>
        /// <param name="parent">
        /// Required. The [Agent][google.cloud.dialogflow.cx.v3.Agent] to create an
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment] for. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
        /// </param>
        /// <param name="environment">
        /// Required. The environment to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Environment, wkt::Struct> CreateEnvironment(AgentName parent, Environment environment, gaxgrpc::CallSettings callSettings = null) =>
            CreateEnvironment(new CreateEnvironmentRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Environment = gax::GaxPreconditions.CheckNotNull(environment, nameof(environment)),
            }, callSettings);

        /// <summary>
        /// Creates an [Environment][google.cloud.dialogflow.cx.v3.Environment] in the
        /// specified [Agent][google.cloud.dialogflow.cx.v3.Agent].
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: [Environment][google.cloud.dialogflow.cx.v3.Environment]
        /// </summary>
        /// <param name="parent">
        /// Required. The [Agent][google.cloud.dialogflow.cx.v3.Agent] to create an
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment] for. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
        /// </param>
        /// <param name="environment">
        /// Required. The environment to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Environment, wkt::Struct>> CreateEnvironmentAsync(AgentName parent, Environment environment, gaxgrpc::CallSettings callSettings = null) =>
            CreateEnvironmentAsync(new CreateEnvironmentRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Environment = gax::GaxPreconditions.CheckNotNull(environment, nameof(environment)),
            }, callSettings);

        /// <summary>
        /// Creates an [Environment][google.cloud.dialogflow.cx.v3.Environment] in the
        /// specified [Agent][google.cloud.dialogflow.cx.v3.Agent].
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: [Environment][google.cloud.dialogflow.cx.v3.Environment]
        /// </summary>
        /// <param name="parent">
        /// Required. The [Agent][google.cloud.dialogflow.cx.v3.Agent] to create an
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment] for. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
        /// </param>
        /// <param name="environment">
        /// Required. The environment to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Environment, wkt::Struct>> CreateEnvironmentAsync(AgentName parent, Environment environment, st::CancellationToken cancellationToken) =>
            CreateEnvironmentAsync(parent, environment, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: [Environment][google.cloud.dialogflow.cx.v3.Environment]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Environment, wkt::Struct> UpdateEnvironment(UpdateEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: [Environment][google.cloud.dialogflow.cx.v3.Environment]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Environment, wkt::Struct>> UpdateEnvironmentAsync(UpdateEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: [Environment][google.cloud.dialogflow.cx.v3.Environment]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Environment, wkt::Struct>> UpdateEnvironmentAsync(UpdateEnvironmentRequest request, st::CancellationToken cancellationToken) =>
            UpdateEnvironmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateEnvironment</c>.</summary>
        public virtual lro::OperationsClient UpdateEnvironmentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateEnvironment</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Environment, wkt::Struct> PollOnceUpdateEnvironment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Environment, wkt::Struct>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateEnvironmentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateEnvironment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Environment, wkt::Struct>> PollOnceUpdateEnvironmentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Environment, wkt::Struct>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateEnvironmentOperationsClient, callSettings);

        /// <summary>
        /// Updates the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: [Environment][google.cloud.dialogflow.cx.v3.Environment]
        /// </summary>
        /// <param name="environment">
        /// Required. The environment to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The mask to control which fields get updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Environment, wkt::Struct> UpdateEnvironment(Environment environment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEnvironment(new UpdateEnvironmentRequest
            {
                Environment = gax::GaxPreconditions.CheckNotNull(environment, nameof(environment)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: [Environment][google.cloud.dialogflow.cx.v3.Environment]
        /// </summary>
        /// <param name="environment">
        /// Required. The environment to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The mask to control which fields get updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Environment, wkt::Struct>> UpdateEnvironmentAsync(Environment environment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEnvironmentAsync(new UpdateEnvironmentRequest
            {
                Environment = gax::GaxPreconditions.CheckNotNull(environment, nameof(environment)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: [Environment][google.cloud.dialogflow.cx.v3.Environment]
        /// </summary>
        /// <param name="environment">
        /// Required. The environment to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The mask to control which fields get updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Environment, wkt::Struct>> UpdateEnvironmentAsync(Environment environment, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateEnvironmentAsync(environment, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteEnvironment(DeleteEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEnvironmentAsync(DeleteEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEnvironmentAsync(DeleteEnvironmentRequest request, st::CancellationToken cancellationToken) =>
            DeleteEnvironmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment] to delete. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteEnvironment(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEnvironment(new DeleteEnvironmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment] to delete. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEnvironmentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEnvironmentAsync(new DeleteEnvironmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment] to delete. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEnvironmentAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteEnvironmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment] to delete. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteEnvironment(EnvironmentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEnvironment(new DeleteEnvironmentRequest
            {
                EnvironmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment] to delete. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEnvironmentAsync(EnvironmentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEnvironmentAsync(new DeleteEnvironmentRequest
            {
                EnvironmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment] to delete. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEnvironmentAsync(EnvironmentName name, st::CancellationToken cancellationToken) =>
            DeleteEnvironmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Looks up the history of the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Environment"/> resources.</returns>
        public virtual gax::PagedEnumerable<LookupEnvironmentHistoryResponse, Environment> LookupEnvironmentHistory(LookupEnvironmentHistoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Looks up the history of the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Environment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<LookupEnvironmentHistoryResponse, Environment> LookupEnvironmentHistoryAsync(LookupEnvironmentHistoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Looks up the history of the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the environment to look up the history for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="Environment"/> resources.</returns>
        public virtual gax::PagedEnumerable<LookupEnvironmentHistoryResponse, Environment> LookupEnvironmentHistory(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            LookupEnvironmentHistoryRequest request = new LookupEnvironmentHistoryRequest
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
            return LookupEnvironmentHistory(request, callSettings);
        }

        /// <summary>
        /// Looks up the history of the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the environment to look up the history for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Environment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<LookupEnvironmentHistoryResponse, Environment> LookupEnvironmentHistoryAsync(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            LookupEnvironmentHistoryRequest request = new LookupEnvironmentHistoryRequest
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
            return LookupEnvironmentHistoryAsync(request, callSettings);
        }

        /// <summary>
        /// Looks up the history of the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the environment to look up the history for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="Environment"/> resources.</returns>
        public virtual gax::PagedEnumerable<LookupEnvironmentHistoryResponse, Environment> LookupEnvironmentHistory(EnvironmentName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            LookupEnvironmentHistoryRequest request = new LookupEnvironmentHistoryRequest
            {
                EnvironmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return LookupEnvironmentHistory(request, callSettings);
        }

        /// <summary>
        /// Looks up the history of the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the environment to look up the history for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Environment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<LookupEnvironmentHistoryResponse, Environment> LookupEnvironmentHistoryAsync(EnvironmentName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            LookupEnvironmentHistoryRequest request = new LookupEnvironmentHistoryRequest
            {
                EnvironmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return LookupEnvironmentHistoryAsync(request, callSettings);
        }

        /// <summary>
        /// Kicks off a continuous test under the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [RunContinuousTestMetadata][google.cloud.dialogflow.cx.v3.RunContinuousTestMetadata]
        /// - `response`:
        /// [RunContinuousTestResponse][google.cloud.dialogflow.cx.v3.RunContinuousTestResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RunContinuousTestResponse, RunContinuousTestMetadata> RunContinuousTest(RunContinuousTestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Kicks off a continuous test under the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [RunContinuousTestMetadata][google.cloud.dialogflow.cx.v3.RunContinuousTestMetadata]
        /// - `response`:
        /// [RunContinuousTestResponse][google.cloud.dialogflow.cx.v3.RunContinuousTestResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RunContinuousTestResponse, RunContinuousTestMetadata>> RunContinuousTestAsync(RunContinuousTestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Kicks off a continuous test under the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [RunContinuousTestMetadata][google.cloud.dialogflow.cx.v3.RunContinuousTestMetadata]
        /// - `response`:
        /// [RunContinuousTestResponse][google.cloud.dialogflow.cx.v3.RunContinuousTestResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RunContinuousTestResponse, RunContinuousTestMetadata>> RunContinuousTestAsync(RunContinuousTestRequest request, st::CancellationToken cancellationToken) =>
            RunContinuousTestAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RunContinuousTest</c>.</summary>
        public virtual lro::OperationsClient RunContinuousTestOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RunContinuousTest</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<RunContinuousTestResponse, RunContinuousTestMetadata> PollOnceRunContinuousTest(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RunContinuousTestResponse, RunContinuousTestMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RunContinuousTestOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RunContinuousTest</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<RunContinuousTestResponse, RunContinuousTestMetadata>> PollOnceRunContinuousTestAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RunContinuousTestResponse, RunContinuousTestMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RunContinuousTestOperationsClient, callSettings);

        /// <summary>
        /// Fetches a list of continuous test results for a given environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ContinuousTestResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListContinuousTestResultsResponse, ContinuousTestResult> ListContinuousTestResults(ListContinuousTestResultsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches a list of continuous test results for a given environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ContinuousTestResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListContinuousTestResultsResponse, ContinuousTestResult> ListContinuousTestResultsAsync(ListContinuousTestResultsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches a list of continuous test results for a given environment.
        /// </summary>
        /// <param name="parent">
        /// Required. The environment to list results for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="ContinuousTestResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListContinuousTestResultsResponse, ContinuousTestResult> ListContinuousTestResults(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListContinuousTestResultsRequest request = new ListContinuousTestResultsRequest
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
            return ListContinuousTestResults(request, callSettings);
        }

        /// <summary>
        /// Fetches a list of continuous test results for a given environment.
        /// </summary>
        /// <param name="parent">
        /// Required. The environment to list results for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ContinuousTestResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListContinuousTestResultsResponse, ContinuousTestResult> ListContinuousTestResultsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListContinuousTestResultsRequest request = new ListContinuousTestResultsRequest
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
            return ListContinuousTestResultsAsync(request, callSettings);
        }

        /// <summary>
        /// Fetches a list of continuous test results for a given environment.
        /// </summary>
        /// <param name="parent">
        /// Required. The environment to list results for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="ContinuousTestResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListContinuousTestResultsResponse, ContinuousTestResult> ListContinuousTestResults(EnvironmentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListContinuousTestResultsRequest request = new ListContinuousTestResultsRequest
            {
                ParentAsEnvironmentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListContinuousTestResults(request, callSettings);
        }

        /// <summary>
        /// Fetches a list of continuous test results for a given environment.
        /// </summary>
        /// <param name="parent">
        /// Required. The environment to list results for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ContinuousTestResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListContinuousTestResultsResponse, ContinuousTestResult> ListContinuousTestResultsAsync(EnvironmentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListContinuousTestResultsRequest request = new ListContinuousTestResultsRequest
            {
                ParentAsEnvironmentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListContinuousTestResultsAsync(request, callSettings);
        }

        /// <summary>
        /// Deploys a flow to the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [DeployFlowMetadata][google.cloud.dialogflow.cx.v3.DeployFlowMetadata]
        /// - `response`:
        /// [DeployFlowResponse][google.cloud.dialogflow.cx.v3.DeployFlowResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeployFlowResponse, DeployFlowMetadata> DeployFlow(DeployFlowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deploys a flow to the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [DeployFlowMetadata][google.cloud.dialogflow.cx.v3.DeployFlowMetadata]
        /// - `response`:
        /// [DeployFlowResponse][google.cloud.dialogflow.cx.v3.DeployFlowResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployFlowResponse, DeployFlowMetadata>> DeployFlowAsync(DeployFlowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deploys a flow to the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [DeployFlowMetadata][google.cloud.dialogflow.cx.v3.DeployFlowMetadata]
        /// - `response`:
        /// [DeployFlowResponse][google.cloud.dialogflow.cx.v3.DeployFlowResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployFlowResponse, DeployFlowMetadata>> DeployFlowAsync(DeployFlowRequest request, st::CancellationToken cancellationToken) =>
            DeployFlowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeployFlow</c>.</summary>
        public virtual lro::OperationsClient DeployFlowOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeployFlow</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DeployFlowResponse, DeployFlowMetadata> PollOnceDeployFlow(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DeployFlowResponse, DeployFlowMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeployFlowOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeployFlow</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DeployFlowResponse, DeployFlowMetadata>> PollOnceDeployFlowAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DeployFlowResponse, DeployFlowMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeployFlowOperationsClient, callSettings);
    }

    /// <summary>Environments client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing
    /// [Environments][google.cloud.dialogflow.cx.v3.Environment].
    /// </remarks>
    public sealed partial class EnvironmentsClientImpl : EnvironmentsClient
    {
        private readonly gaxgrpc::ApiCall<ListEnvironmentsRequest, ListEnvironmentsResponse> _callListEnvironments;

        private readonly gaxgrpc::ApiCall<GetEnvironmentRequest, Environment> _callGetEnvironment;

        private readonly gaxgrpc::ApiCall<CreateEnvironmentRequest, lro::Operation> _callCreateEnvironment;

        private readonly gaxgrpc::ApiCall<UpdateEnvironmentRequest, lro::Operation> _callUpdateEnvironment;

        private readonly gaxgrpc::ApiCall<DeleteEnvironmentRequest, wkt::Empty> _callDeleteEnvironment;

        private readonly gaxgrpc::ApiCall<LookupEnvironmentHistoryRequest, LookupEnvironmentHistoryResponse> _callLookupEnvironmentHistory;

        private readonly gaxgrpc::ApiCall<RunContinuousTestRequest, lro::Operation> _callRunContinuousTest;

        private readonly gaxgrpc::ApiCall<ListContinuousTestResultsRequest, ListContinuousTestResultsResponse> _callListContinuousTestResults;

        private readonly gaxgrpc::ApiCall<DeployFlowRequest, lro::Operation> _callDeployFlow;

        /// <summary>
        /// Constructs a client wrapper for the Environments service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="EnvironmentsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public EnvironmentsClientImpl(Environments.EnvironmentsClient grpcClient, EnvironmentsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            EnvironmentsSettings effectiveSettings = settings ?? EnvironmentsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateEnvironmentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateEnvironmentOperationsSettings, logger);
            UpdateEnvironmentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateEnvironmentOperationsSettings, logger);
            RunContinuousTestOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RunContinuousTestOperationsSettings, logger);
            DeployFlowOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeployFlowOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListEnvironments = clientHelper.BuildApiCall<ListEnvironmentsRequest, ListEnvironmentsResponse>("ListEnvironments", grpcClient.ListEnvironmentsAsync, grpcClient.ListEnvironments, effectiveSettings.ListEnvironmentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEnvironments);
            Modify_ListEnvironmentsApiCall(ref _callListEnvironments);
            _callGetEnvironment = clientHelper.BuildApiCall<GetEnvironmentRequest, Environment>("GetEnvironment", grpcClient.GetEnvironmentAsync, grpcClient.GetEnvironment, effectiveSettings.GetEnvironmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEnvironment);
            Modify_GetEnvironmentApiCall(ref _callGetEnvironment);
            _callCreateEnvironment = clientHelper.BuildApiCall<CreateEnvironmentRequest, lro::Operation>("CreateEnvironment", grpcClient.CreateEnvironmentAsync, grpcClient.CreateEnvironment, effectiveSettings.CreateEnvironmentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateEnvironment);
            Modify_CreateEnvironmentApiCall(ref _callCreateEnvironment);
            _callUpdateEnvironment = clientHelper.BuildApiCall<UpdateEnvironmentRequest, lro::Operation>("UpdateEnvironment", grpcClient.UpdateEnvironmentAsync, grpcClient.UpdateEnvironment, effectiveSettings.UpdateEnvironmentSettings).WithGoogleRequestParam("environment.name", request => request.Environment?.Name);
            Modify_ApiCall(ref _callUpdateEnvironment);
            Modify_UpdateEnvironmentApiCall(ref _callUpdateEnvironment);
            _callDeleteEnvironment = clientHelper.BuildApiCall<DeleteEnvironmentRequest, wkt::Empty>("DeleteEnvironment", grpcClient.DeleteEnvironmentAsync, grpcClient.DeleteEnvironment, effectiveSettings.DeleteEnvironmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteEnvironment);
            Modify_DeleteEnvironmentApiCall(ref _callDeleteEnvironment);
            _callLookupEnvironmentHistory = clientHelper.BuildApiCall<LookupEnvironmentHistoryRequest, LookupEnvironmentHistoryResponse>("LookupEnvironmentHistory", grpcClient.LookupEnvironmentHistoryAsync, grpcClient.LookupEnvironmentHistory, effectiveSettings.LookupEnvironmentHistorySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callLookupEnvironmentHistory);
            Modify_LookupEnvironmentHistoryApiCall(ref _callLookupEnvironmentHistory);
            _callRunContinuousTest = clientHelper.BuildApiCall<RunContinuousTestRequest, lro::Operation>("RunContinuousTest", grpcClient.RunContinuousTestAsync, grpcClient.RunContinuousTest, effectiveSettings.RunContinuousTestSettings).WithGoogleRequestParam("environment", request => request.Environment);
            Modify_ApiCall(ref _callRunContinuousTest);
            Modify_RunContinuousTestApiCall(ref _callRunContinuousTest);
            _callListContinuousTestResults = clientHelper.BuildApiCall<ListContinuousTestResultsRequest, ListContinuousTestResultsResponse>("ListContinuousTestResults", grpcClient.ListContinuousTestResultsAsync, grpcClient.ListContinuousTestResults, effectiveSettings.ListContinuousTestResultsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListContinuousTestResults);
            Modify_ListContinuousTestResultsApiCall(ref _callListContinuousTestResults);
            _callDeployFlow = clientHelper.BuildApiCall<DeployFlowRequest, lro::Operation>("DeployFlow", grpcClient.DeployFlowAsync, grpcClient.DeployFlow, effectiveSettings.DeployFlowSettings).WithGoogleRequestParam("environment", request => request.Environment);
            Modify_ApiCall(ref _callDeployFlow);
            Modify_DeployFlowApiCall(ref _callDeployFlow);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListEnvironmentsApiCall(ref gaxgrpc::ApiCall<ListEnvironmentsRequest, ListEnvironmentsResponse> call);

        partial void Modify_GetEnvironmentApiCall(ref gaxgrpc::ApiCall<GetEnvironmentRequest, Environment> call);

        partial void Modify_CreateEnvironmentApiCall(ref gaxgrpc::ApiCall<CreateEnvironmentRequest, lro::Operation> call);

        partial void Modify_UpdateEnvironmentApiCall(ref gaxgrpc::ApiCall<UpdateEnvironmentRequest, lro::Operation> call);

        partial void Modify_DeleteEnvironmentApiCall(ref gaxgrpc::ApiCall<DeleteEnvironmentRequest, wkt::Empty> call);

        partial void Modify_LookupEnvironmentHistoryApiCall(ref gaxgrpc::ApiCall<LookupEnvironmentHistoryRequest, LookupEnvironmentHistoryResponse> call);

        partial void Modify_RunContinuousTestApiCall(ref gaxgrpc::ApiCall<RunContinuousTestRequest, lro::Operation> call);

        partial void Modify_ListContinuousTestResultsApiCall(ref gaxgrpc::ApiCall<ListContinuousTestResultsRequest, ListContinuousTestResultsResponse> call);

        partial void Modify_DeployFlowApiCall(ref gaxgrpc::ApiCall<DeployFlowRequest, lro::Operation> call);

        partial void OnConstruction(Environments.EnvironmentsClient grpcClient, EnvironmentsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Environments client</summary>
        public override Environments.EnvironmentsClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListEnvironmentsRequest(ref ListEnvironmentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEnvironmentRequest(ref GetEnvironmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateEnvironmentRequest(ref CreateEnvironmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateEnvironmentRequest(ref UpdateEnvironmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteEnvironmentRequest(ref DeleteEnvironmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_LookupEnvironmentHistoryRequest(ref LookupEnvironmentHistoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RunContinuousTestRequest(ref RunContinuousTestRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListContinuousTestResultsRequest(ref ListContinuousTestResultsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeployFlowRequest(ref DeployFlowRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the list of all environments in the specified
        /// [Agent][google.cloud.dialogflow.cx.v3.Agent].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Environment"/> resources.</returns>
        public override gax::PagedEnumerable<ListEnvironmentsResponse, Environment> ListEnvironments(ListEnvironmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEnvironmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEnvironmentsRequest, ListEnvironmentsResponse, Environment>(_callListEnvironments, request, callSettings);
        }

        /// <summary>
        /// Returns the list of all environments in the specified
        /// [Agent][google.cloud.dialogflow.cx.v3.Agent].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Environment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEnvironmentsResponse, Environment> ListEnvironmentsAsync(ListEnvironmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEnvironmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEnvironmentsRequest, ListEnvironmentsResponse, Environment>(_callListEnvironments, request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Environment GetEnvironment(GetEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEnvironmentRequest(ref request, ref callSettings);
            return _callGetEnvironment.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Environment> GetEnvironmentAsync(GetEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEnvironmentRequest(ref request, ref callSettings);
            return _callGetEnvironment.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateEnvironment</c>.</summary>
        public override lro::OperationsClient CreateEnvironmentOperationsClient { get; }

        /// <summary>
        /// Creates an [Environment][google.cloud.dialogflow.cx.v3.Environment] in the
        /// specified [Agent][google.cloud.dialogflow.cx.v3.Agent].
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: [Environment][google.cloud.dialogflow.cx.v3.Environment]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Environment, wkt::Struct> CreateEnvironment(CreateEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEnvironmentRequest(ref request, ref callSettings);
            return new lro::Operation<Environment, wkt::Struct>(_callCreateEnvironment.Sync(request, callSettings), CreateEnvironmentOperationsClient);
        }

        /// <summary>
        /// Creates an [Environment][google.cloud.dialogflow.cx.v3.Environment] in the
        /// specified [Agent][google.cloud.dialogflow.cx.v3.Agent].
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: [Environment][google.cloud.dialogflow.cx.v3.Environment]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Environment, wkt::Struct>> CreateEnvironmentAsync(CreateEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEnvironmentRequest(ref request, ref callSettings);
            return new lro::Operation<Environment, wkt::Struct>(await _callCreateEnvironment.Async(request, callSettings).ConfigureAwait(false), CreateEnvironmentOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateEnvironment</c>.</summary>
        public override lro::OperationsClient UpdateEnvironmentOperationsClient { get; }

        /// <summary>
        /// Updates the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: [Environment][google.cloud.dialogflow.cx.v3.Environment]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Environment, wkt::Struct> UpdateEnvironment(UpdateEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEnvironmentRequest(ref request, ref callSettings);
            return new lro::Operation<Environment, wkt::Struct>(_callUpdateEnvironment.Sync(request, callSettings), UpdateEnvironmentOperationsClient);
        }

        /// <summary>
        /// Updates the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: [Environment][google.cloud.dialogflow.cx.v3.Environment]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Environment, wkt::Struct>> UpdateEnvironmentAsync(UpdateEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEnvironmentRequest(ref request, ref callSettings);
            return new lro::Operation<Environment, wkt::Struct>(await _callUpdateEnvironment.Async(request, callSettings).ConfigureAwait(false), UpdateEnvironmentOperationsClient);
        }

        /// <summary>
        /// Deletes the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteEnvironment(DeleteEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEnvironmentRequest(ref request, ref callSettings);
            _callDeleteEnvironment.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteEnvironmentAsync(DeleteEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEnvironmentRequest(ref request, ref callSettings);
            return _callDeleteEnvironment.Async(request, callSettings);
        }

        /// <summary>
        /// Looks up the history of the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Environment"/> resources.</returns>
        public override gax::PagedEnumerable<LookupEnvironmentHistoryResponse, Environment> LookupEnvironmentHistory(LookupEnvironmentHistoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LookupEnvironmentHistoryRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<LookupEnvironmentHistoryRequest, LookupEnvironmentHistoryResponse, Environment>(_callLookupEnvironmentHistory, request, callSettings);
        }

        /// <summary>
        /// Looks up the history of the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Environment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<LookupEnvironmentHistoryResponse, Environment> LookupEnvironmentHistoryAsync(LookupEnvironmentHistoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LookupEnvironmentHistoryRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<LookupEnvironmentHistoryRequest, LookupEnvironmentHistoryResponse, Environment>(_callLookupEnvironmentHistory, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>RunContinuousTest</c>.</summary>
        public override lro::OperationsClient RunContinuousTestOperationsClient { get; }

        /// <summary>
        /// Kicks off a continuous test under the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [RunContinuousTestMetadata][google.cloud.dialogflow.cx.v3.RunContinuousTestMetadata]
        /// - `response`:
        /// [RunContinuousTestResponse][google.cloud.dialogflow.cx.v3.RunContinuousTestResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<RunContinuousTestResponse, RunContinuousTestMetadata> RunContinuousTest(RunContinuousTestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunContinuousTestRequest(ref request, ref callSettings);
            return new lro::Operation<RunContinuousTestResponse, RunContinuousTestMetadata>(_callRunContinuousTest.Sync(request, callSettings), RunContinuousTestOperationsClient);
        }

        /// <summary>
        /// Kicks off a continuous test under the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [RunContinuousTestMetadata][google.cloud.dialogflow.cx.v3.RunContinuousTestMetadata]
        /// - `response`:
        /// [RunContinuousTestResponse][google.cloud.dialogflow.cx.v3.RunContinuousTestResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<RunContinuousTestResponse, RunContinuousTestMetadata>> RunContinuousTestAsync(RunContinuousTestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunContinuousTestRequest(ref request, ref callSettings);
            return new lro::Operation<RunContinuousTestResponse, RunContinuousTestMetadata>(await _callRunContinuousTest.Async(request, callSettings).ConfigureAwait(false), RunContinuousTestOperationsClient);
        }

        /// <summary>
        /// Fetches a list of continuous test results for a given environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ContinuousTestResult"/> resources.</returns>
        public override gax::PagedEnumerable<ListContinuousTestResultsResponse, ContinuousTestResult> ListContinuousTestResults(ListContinuousTestResultsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListContinuousTestResultsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListContinuousTestResultsRequest, ListContinuousTestResultsResponse, ContinuousTestResult>(_callListContinuousTestResults, request, callSettings);
        }

        /// <summary>
        /// Fetches a list of continuous test results for a given environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ContinuousTestResult"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListContinuousTestResultsResponse, ContinuousTestResult> ListContinuousTestResultsAsync(ListContinuousTestResultsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListContinuousTestResultsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListContinuousTestResultsRequest, ListContinuousTestResultsResponse, ContinuousTestResult>(_callListContinuousTestResults, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeployFlow</c>.</summary>
        public override lro::OperationsClient DeployFlowOperationsClient { get; }

        /// <summary>
        /// Deploys a flow to the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [DeployFlowMetadata][google.cloud.dialogflow.cx.v3.DeployFlowMetadata]
        /// - `response`:
        /// [DeployFlowResponse][google.cloud.dialogflow.cx.v3.DeployFlowResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DeployFlowResponse, DeployFlowMetadata> DeployFlow(DeployFlowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeployFlowRequest(ref request, ref callSettings);
            return new lro::Operation<DeployFlowResponse, DeployFlowMetadata>(_callDeployFlow.Sync(request, callSettings), DeployFlowOperationsClient);
        }

        /// <summary>
        /// Deploys a flow to the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [DeployFlowMetadata][google.cloud.dialogflow.cx.v3.DeployFlowMetadata]
        /// - `response`:
        /// [DeployFlowResponse][google.cloud.dialogflow.cx.v3.DeployFlowResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DeployFlowResponse, DeployFlowMetadata>> DeployFlowAsync(DeployFlowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeployFlowRequest(ref request, ref callSettings);
            return new lro::Operation<DeployFlowResponse, DeployFlowMetadata>(await _callDeployFlow.Async(request, callSettings).ConfigureAwait(false), DeployFlowOperationsClient);
        }
    }

    public partial class ListEnvironmentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class LookupEnvironmentHistoryRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListContinuousTestResultsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEnvironmentsResponse : gaxgrpc::IPageResponse<Environment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Environment> GetEnumerator() => Environments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class LookupEnvironmentHistoryResponse : gaxgrpc::IPageResponse<Environment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Environment> GetEnumerator() => Environments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListContinuousTestResultsResponse : gaxgrpc::IPageResponse<ContinuousTestResult>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ContinuousTestResult> GetEnumerator() => ContinuousTestResults.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Environments
    {
        public partial class EnvironmentsClient
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

    public static partial class Environments
    {
        public partial class EnvironmentsClient
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
