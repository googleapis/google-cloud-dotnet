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
    /// <summary>Settings for <see cref="FlowsClient"/> instances.</summary>
    public sealed partial class FlowsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="FlowsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="FlowsSettings"/>.</returns>
        public static FlowsSettings GetDefault() => new FlowsSettings();

        /// <summary>Constructs a new <see cref="FlowsSettings"/> object with default settings.</summary>
        public FlowsSettings()
        {
        }

        private FlowsSettings(FlowsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateFlowSettings = existing.CreateFlowSettings;
            DeleteFlowSettings = existing.DeleteFlowSettings;
            ListFlowsSettings = existing.ListFlowsSettings;
            GetFlowSettings = existing.GetFlowSettings;
            UpdateFlowSettings = existing.UpdateFlowSettings;
            TrainFlowSettings = existing.TrainFlowSettings;
            TrainFlowOperationsSettings = existing.TrainFlowOperationsSettings.Clone();
            ValidateFlowSettings = existing.ValidateFlowSettings;
            GetFlowValidationResultSettings = existing.GetFlowValidationResultSettings;
            ImportFlowSettings = existing.ImportFlowSettings;
            ImportFlowOperationsSettings = existing.ImportFlowOperationsSettings.Clone();
            ExportFlowSettings = existing.ExportFlowSettings;
            ExportFlowOperationsSettings = existing.ExportFlowOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(FlowsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>FlowsClient.CreateFlow</c>
        /// and <c>FlowsClient.CreateFlowAsync</c>.
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
        public gaxgrpc::CallSettings CreateFlowSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>FlowsClient.DeleteFlow</c>
        /// and <c>FlowsClient.DeleteFlowAsync</c>.
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
        public gaxgrpc::CallSettings DeleteFlowSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>FlowsClient.ListFlows</c>
        /// and <c>FlowsClient.ListFlowsAsync</c>.
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
        public gaxgrpc::CallSettings ListFlowsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>FlowsClient.GetFlow</c> and
        /// <c>FlowsClient.GetFlowAsync</c>.
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
        public gaxgrpc::CallSettings GetFlowSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>FlowsClient.UpdateFlow</c>
        /// and <c>FlowsClient.UpdateFlowAsync</c>.
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
        public gaxgrpc::CallSettings UpdateFlowSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>FlowsClient.TrainFlow</c>
        /// and <c>FlowsClient.TrainFlowAsync</c>.
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
        public gaxgrpc::CallSettings TrainFlowSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>FlowsClient.TrainFlow</c> and <c>FlowsClient.TrainFlowAsync</c>
        /// .
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
        public lro::OperationsSettings TrainFlowOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>FlowsClient.ValidateFlow</c>
        ///  and <c>FlowsClient.ValidateFlowAsync</c>.
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
        public gaxgrpc::CallSettings ValidateFlowSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FlowsClient.GetFlowValidationResult</c> and <c>FlowsClient.GetFlowValidationResultAsync</c>.
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
        public gaxgrpc::CallSettings GetFlowValidationResultSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>FlowsClient.ImportFlow</c>
        /// and <c>FlowsClient.ImportFlowAsync</c>.
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
        public gaxgrpc::CallSettings ImportFlowSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>FlowsClient.ImportFlow</c> and
        /// <c>FlowsClient.ImportFlowAsync</c>.
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
        public lro::OperationsSettings ImportFlowOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>FlowsClient.ExportFlow</c>
        /// and <c>FlowsClient.ExportFlowAsync</c>.
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
        public gaxgrpc::CallSettings ExportFlowSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>FlowsClient.ExportFlow</c> and
        /// <c>FlowsClient.ExportFlowAsync</c>.
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
        public lro::OperationsSettings ExportFlowOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="FlowsSettings"/> object.</returns>
        public FlowsSettings Clone() => new FlowsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="FlowsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class FlowsClientBuilder : gaxgrpc::ClientBuilderBase<FlowsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public FlowsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public FlowsClientBuilder() : base(FlowsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref FlowsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<FlowsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override FlowsClient Build()
        {
            FlowsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<FlowsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<FlowsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private FlowsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return FlowsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<FlowsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return FlowsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => FlowsClient.ChannelPool;
    }

    /// <summary>Flows client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [Flows][google.cloud.dialogflow.cx.v3.Flow].
    /// </remarks>
    public abstract partial class FlowsClient
    {
        /// <summary>
        /// The default endpoint for the Flows service, which is a host of "dialogflow.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dialogflow.googleapis.com:443";

        /// <summary>The default Flows scopes.</summary>
        /// <remarks>
        /// The default Flows scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Flows.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="FlowsClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="FlowsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="FlowsClient"/>.</returns>
        public static stt::Task<FlowsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new FlowsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="FlowsClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="FlowsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="FlowsClient"/>.</returns>
        public static FlowsClient Create() => new FlowsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="FlowsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="FlowsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="FlowsClient"/>.</returns>
        internal static FlowsClient Create(grpccore::CallInvoker callInvoker, FlowsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Flows.FlowsClient grpcClient = new Flows.FlowsClient(callInvoker);
            return new FlowsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Flows client</summary>
        public virtual Flows.FlowsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a flow in the specified agent.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Flow CreateFlow(CreateFlowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a flow in the specified agent.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Flow> CreateFlowAsync(CreateFlowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a flow in the specified agent.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Flow> CreateFlowAsync(CreateFlowRequest request, st::CancellationToken cancellationToken) =>
            CreateFlowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a flow in the specified agent.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a flow for.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
        /// </param>
        /// <param name="flow">
        /// Required. The flow to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Flow CreateFlow(string parent, Flow flow, gaxgrpc::CallSettings callSettings = null) =>
            CreateFlow(new CreateFlowRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Flow = gax::GaxPreconditions.CheckNotNull(flow, nameof(flow)),
            }, callSettings);

        /// <summary>
        /// Creates a flow in the specified agent.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a flow for.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
        /// </param>
        /// <param name="flow">
        /// Required. The flow to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Flow> CreateFlowAsync(string parent, Flow flow, gaxgrpc::CallSettings callSettings = null) =>
            CreateFlowAsync(new CreateFlowRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Flow = gax::GaxPreconditions.CheckNotNull(flow, nameof(flow)),
            }, callSettings);

        /// <summary>
        /// Creates a flow in the specified agent.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a flow for.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
        /// </param>
        /// <param name="flow">
        /// Required. The flow to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Flow> CreateFlowAsync(string parent, Flow flow, st::CancellationToken cancellationToken) =>
            CreateFlowAsync(parent, flow, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a flow in the specified agent.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a flow for.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
        /// </param>
        /// <param name="flow">
        /// Required. The flow to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Flow CreateFlow(AgentName parent, Flow flow, gaxgrpc::CallSettings callSettings = null) =>
            CreateFlow(new CreateFlowRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Flow = gax::GaxPreconditions.CheckNotNull(flow, nameof(flow)),
            }, callSettings);

        /// <summary>
        /// Creates a flow in the specified agent.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a flow for.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
        /// </param>
        /// <param name="flow">
        /// Required. The flow to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Flow> CreateFlowAsync(AgentName parent, Flow flow, gaxgrpc::CallSettings callSettings = null) =>
            CreateFlowAsync(new CreateFlowRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Flow = gax::GaxPreconditions.CheckNotNull(flow, nameof(flow)),
            }, callSettings);

        /// <summary>
        /// Creates a flow in the specified agent.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a flow for.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
        /// </param>
        /// <param name="flow">
        /// Required. The flow to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Flow> CreateFlowAsync(AgentName parent, Flow flow, st::CancellationToken cancellationToken) =>
            CreateFlowAsync(parent, flow, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a specified flow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteFlow(DeleteFlowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a specified flow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFlowAsync(DeleteFlowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a specified flow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFlowAsync(DeleteFlowRequest request, st::CancellationToken cancellationToken) =>
            DeleteFlowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a specified flow.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the flow to delete.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteFlow(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFlow(new DeleteFlowRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specified flow.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the flow to delete.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFlowAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFlowAsync(new DeleteFlowRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specified flow.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the flow to delete.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFlowAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteFlowAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a specified flow.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the flow to delete.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteFlow(FlowName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFlow(new DeleteFlowRequest
            {
                FlowName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specified flow.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the flow to delete.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFlowAsync(FlowName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFlowAsync(new DeleteFlowRequest
            {
                FlowName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specified flow.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the flow to delete.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFlowAsync(FlowName name, st::CancellationToken cancellationToken) =>
            DeleteFlowAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the list of all flows in the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Flow"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFlowsResponse, Flow> ListFlows(ListFlowsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all flows in the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Flow"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFlowsResponse, Flow> ListFlowsAsync(ListFlowsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all flows in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent containing the flows.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="Flow"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFlowsResponse, Flow> ListFlows(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFlowsRequest request = new ListFlowsRequest
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
            return ListFlows(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all flows in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent containing the flows.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Flow"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFlowsResponse, Flow> ListFlowsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFlowsRequest request = new ListFlowsRequest
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
            return ListFlowsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all flows in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent containing the flows.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="Flow"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFlowsResponse, Flow> ListFlows(AgentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFlowsRequest request = new ListFlowsRequest
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
            return ListFlows(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all flows in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent containing the flows.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Flow"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFlowsResponse, Flow> ListFlowsAsync(AgentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFlowsRequest request = new ListFlowsRequest
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
            return ListFlowsAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified flow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Flow GetFlow(GetFlowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified flow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Flow> GetFlowAsync(GetFlowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified flow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Flow> GetFlowAsync(GetFlowRequest request, st::CancellationToken cancellationToken) =>
            GetFlowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified flow.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the flow to get.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Flow GetFlow(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFlow(new GetFlowRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified flow.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the flow to get.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Flow> GetFlowAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFlowAsync(new GetFlowRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified flow.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the flow to get.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Flow> GetFlowAsync(string name, st::CancellationToken cancellationToken) =>
            GetFlowAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified flow.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the flow to get.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Flow GetFlow(FlowName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFlow(new GetFlowRequest
            {
                FlowName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified flow.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the flow to get.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Flow> GetFlowAsync(FlowName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFlowAsync(new GetFlowRequest
            {
                FlowName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified flow.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the flow to get.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Flow> GetFlowAsync(FlowName name, st::CancellationToken cancellationToken) =>
            GetFlowAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified flow.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Flow UpdateFlow(UpdateFlowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified flow.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Flow> UpdateFlowAsync(UpdateFlowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified flow.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Flow> UpdateFlowAsync(UpdateFlowRequest request, st::CancellationToken cancellationToken) =>
            UpdateFlowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified flow.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="flow">
        /// Required. The flow to update.
        /// </param>
        /// <param name="updateMask">
        /// The mask to control which fields get updated. If the mask is not present,
        /// all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Flow UpdateFlow(Flow flow, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFlow(new UpdateFlowRequest
            {
                Flow = gax::GaxPreconditions.CheckNotNull(flow, nameof(flow)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified flow.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="flow">
        /// Required. The flow to update.
        /// </param>
        /// <param name="updateMask">
        /// The mask to control which fields get updated. If the mask is not present,
        /// all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Flow> UpdateFlowAsync(Flow flow, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFlowAsync(new UpdateFlowRequest
            {
                Flow = gax::GaxPreconditions.CheckNotNull(flow, nameof(flow)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified flow.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="flow">
        /// Required. The flow to update.
        /// </param>
        /// <param name="updateMask">
        /// The mask to control which fields get updated. If the mask is not present,
        /// all fields will be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Flow> UpdateFlowAsync(Flow flow, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateFlowAsync(flow, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Trains the specified flow. Note that only the flow in 'draft' environment
        /// is trained.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Struct> TrainFlow(TrainFlowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Trains the specified flow. Note that only the flow in 'draft' environment
        /// is trained.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> TrainFlowAsync(TrainFlowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Trains the specified flow. Note that only the flow in 'draft' environment
        /// is trained.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> TrainFlowAsync(TrainFlowRequest request, st::CancellationToken cancellationToken) =>
            TrainFlowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>TrainFlow</c>.</summary>
        public virtual lro::OperationsClient TrainFlowOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>TrainFlow</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Struct> PollOnceTrainFlow(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, wkt::Struct>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), TrainFlowOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>TrainFlow</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> PollOnceTrainFlowAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, wkt::Struct>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), TrainFlowOperationsClient, callSettings);

        /// <summary>
        /// Trains the specified flow. Note that only the flow in 'draft' environment
        /// is trained.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="name">
        /// Required. The flow to train.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Struct> TrainFlow(string name, gaxgrpc::CallSettings callSettings = null) =>
            TrainFlow(new TrainFlowRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Trains the specified flow. Note that only the flow in 'draft' environment
        /// is trained.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="name">
        /// Required. The flow to train.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> TrainFlowAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            TrainFlowAsync(new TrainFlowRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Trains the specified flow. Note that only the flow in 'draft' environment
        /// is trained.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="name">
        /// Required. The flow to train.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> TrainFlowAsync(string name, st::CancellationToken cancellationToken) =>
            TrainFlowAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Trains the specified flow. Note that only the flow in 'draft' environment
        /// is trained.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="name">
        /// Required. The flow to train.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Struct> TrainFlow(FlowName name, gaxgrpc::CallSettings callSettings = null) =>
            TrainFlow(new TrainFlowRequest
            {
                FlowName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Trains the specified flow. Note that only the flow in 'draft' environment
        /// is trained.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="name">
        /// Required. The flow to train.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> TrainFlowAsync(FlowName name, gaxgrpc::CallSettings callSettings = null) =>
            TrainFlowAsync(new TrainFlowRequest
            {
                FlowName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Trains the specified flow. Note that only the flow in 'draft' environment
        /// is trained.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="name">
        /// Required. The flow to train.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> TrainFlowAsync(FlowName name, st::CancellationToken cancellationToken) =>
            TrainFlowAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Validates the specified flow and creates or updates validation results.
        /// Please call this API after the training is completed to get the complete
        /// validation results.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FlowValidationResult ValidateFlow(ValidateFlowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Validates the specified flow and creates or updates validation results.
        /// Please call this API after the training is completed to get the complete
        /// validation results.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FlowValidationResult> ValidateFlowAsync(ValidateFlowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Validates the specified flow and creates or updates validation results.
        /// Please call this API after the training is completed to get the complete
        /// validation results.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FlowValidationResult> ValidateFlowAsync(ValidateFlowRequest request, st::CancellationToken cancellationToken) =>
            ValidateFlowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the latest flow validation result. Flow validation is performed
        /// when ValidateFlow is called.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FlowValidationResult GetFlowValidationResult(GetFlowValidationResultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the latest flow validation result. Flow validation is performed
        /// when ValidateFlow is called.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FlowValidationResult> GetFlowValidationResultAsync(GetFlowValidationResultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the latest flow validation result. Flow validation is performed
        /// when ValidateFlow is called.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FlowValidationResult> GetFlowValidationResultAsync(GetFlowValidationResultRequest request, st::CancellationToken cancellationToken) =>
            GetFlowValidationResultAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the latest flow validation result. Flow validation is performed
        /// when ValidateFlow is called.
        /// </summary>
        /// <param name="name">
        /// Required. The flow name.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;/validationResult`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FlowValidationResult GetFlowValidationResult(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFlowValidationResult(new GetFlowValidationResultRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the latest flow validation result. Flow validation is performed
        /// when ValidateFlow is called.
        /// </summary>
        /// <param name="name">
        /// Required. The flow name.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;/validationResult`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FlowValidationResult> GetFlowValidationResultAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFlowValidationResultAsync(new GetFlowValidationResultRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the latest flow validation result. Flow validation is performed
        /// when ValidateFlow is called.
        /// </summary>
        /// <param name="name">
        /// Required. The flow name.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;/validationResult`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FlowValidationResult> GetFlowValidationResultAsync(string name, st::CancellationToken cancellationToken) =>
            GetFlowValidationResultAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the latest flow validation result. Flow validation is performed
        /// when ValidateFlow is called.
        /// </summary>
        /// <param name="name">
        /// Required. The flow name.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;/validationResult`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FlowValidationResult GetFlowValidationResult(FlowValidationResultName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFlowValidationResult(new GetFlowValidationResultRequest
            {
                FlowValidationResultName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the latest flow validation result. Flow validation is performed
        /// when ValidateFlow is called.
        /// </summary>
        /// <param name="name">
        /// Required. The flow name.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;/validationResult`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FlowValidationResult> GetFlowValidationResultAsync(FlowValidationResultName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFlowValidationResultAsync(new GetFlowValidationResultRequest
            {
                FlowValidationResultName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the latest flow validation result. Flow validation is performed
        /// when ValidateFlow is called.
        /// </summary>
        /// <param name="name">
        /// Required. The flow name.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;/validationResult`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FlowValidationResult> GetFlowValidationResultAsync(FlowValidationResultName name, st::CancellationToken cancellationToken) =>
            GetFlowValidationResultAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports the specified flow to the specified agent from a binary file.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`:
        /// [ImportFlowResponse][google.cloud.dialogflow.cx.v3.ImportFlowResponse]
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportFlowResponse, wkt::Struct> ImportFlow(ImportFlowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports the specified flow to the specified agent from a binary file.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`:
        /// [ImportFlowResponse][google.cloud.dialogflow.cx.v3.ImportFlowResponse]
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportFlowResponse, wkt::Struct>> ImportFlowAsync(ImportFlowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports the specified flow to the specified agent from a binary file.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`:
        /// [ImportFlowResponse][google.cloud.dialogflow.cx.v3.ImportFlowResponse]
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportFlowResponse, wkt::Struct>> ImportFlowAsync(ImportFlowRequest request, st::CancellationToken cancellationToken) =>
            ImportFlowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ImportFlow</c>.</summary>
        public virtual lro::OperationsClient ImportFlowOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ImportFlow</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ImportFlowResponse, wkt::Struct> PollOnceImportFlow(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportFlowResponse, wkt::Struct>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportFlowOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ImportFlow</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ImportFlowResponse, wkt::Struct>> PollOnceImportFlowAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportFlowResponse, wkt::Struct>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportFlowOperationsClient, callSettings);

        /// <summary>
        /// Exports the specified flow to a binary file.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`:
        /// [ExportFlowResponse][google.cloud.dialogflow.cx.v3.ExportFlowResponse]
        /// 
        /// Note that resources (e.g. intents, entities, webhooks) that the flow
        /// references will also be exported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportFlowResponse, wkt::Struct> ExportFlow(ExportFlowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports the specified flow to a binary file.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`:
        /// [ExportFlowResponse][google.cloud.dialogflow.cx.v3.ExportFlowResponse]
        /// 
        /// Note that resources (e.g. intents, entities, webhooks) that the flow
        /// references will also be exported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportFlowResponse, wkt::Struct>> ExportFlowAsync(ExportFlowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports the specified flow to a binary file.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`:
        /// [ExportFlowResponse][google.cloud.dialogflow.cx.v3.ExportFlowResponse]
        /// 
        /// Note that resources (e.g. intents, entities, webhooks) that the flow
        /// references will also be exported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportFlowResponse, wkt::Struct>> ExportFlowAsync(ExportFlowRequest request, st::CancellationToken cancellationToken) =>
            ExportFlowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ExportFlow</c>.</summary>
        public virtual lro::OperationsClient ExportFlowOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ExportFlow</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ExportFlowResponse, wkt::Struct> PollOnceExportFlow(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportFlowResponse, wkt::Struct>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportFlowOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportFlow</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ExportFlowResponse, wkt::Struct>> PollOnceExportFlowAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportFlowResponse, wkt::Struct>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportFlowOperationsClient, callSettings);
    }

    /// <summary>Flows client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [Flows][google.cloud.dialogflow.cx.v3.Flow].
    /// </remarks>
    public sealed partial class FlowsClientImpl : FlowsClient
    {
        private readonly gaxgrpc::ApiCall<CreateFlowRequest, Flow> _callCreateFlow;

        private readonly gaxgrpc::ApiCall<DeleteFlowRequest, wkt::Empty> _callDeleteFlow;

        private readonly gaxgrpc::ApiCall<ListFlowsRequest, ListFlowsResponse> _callListFlows;

        private readonly gaxgrpc::ApiCall<GetFlowRequest, Flow> _callGetFlow;

        private readonly gaxgrpc::ApiCall<UpdateFlowRequest, Flow> _callUpdateFlow;

        private readonly gaxgrpc::ApiCall<TrainFlowRequest, lro::Operation> _callTrainFlow;

        private readonly gaxgrpc::ApiCall<ValidateFlowRequest, FlowValidationResult> _callValidateFlow;

        private readonly gaxgrpc::ApiCall<GetFlowValidationResultRequest, FlowValidationResult> _callGetFlowValidationResult;

        private readonly gaxgrpc::ApiCall<ImportFlowRequest, lro::Operation> _callImportFlow;

        private readonly gaxgrpc::ApiCall<ExportFlowRequest, lro::Operation> _callExportFlow;

        /// <summary>
        /// Constructs a client wrapper for the Flows service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="FlowsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public FlowsClientImpl(Flows.FlowsClient grpcClient, FlowsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            FlowsSettings effectiveSettings = settings ?? FlowsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            TrainFlowOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.TrainFlowOperationsSettings, logger);
            ImportFlowOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ImportFlowOperationsSettings, logger);
            ExportFlowOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ExportFlowOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCreateFlow = clientHelper.BuildApiCall<CreateFlowRequest, Flow>("CreateFlow", grpcClient.CreateFlowAsync, grpcClient.CreateFlow, effectiveSettings.CreateFlowSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateFlow);
            Modify_CreateFlowApiCall(ref _callCreateFlow);
            _callDeleteFlow = clientHelper.BuildApiCall<DeleteFlowRequest, wkt::Empty>("DeleteFlow", grpcClient.DeleteFlowAsync, grpcClient.DeleteFlow, effectiveSettings.DeleteFlowSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteFlow);
            Modify_DeleteFlowApiCall(ref _callDeleteFlow);
            _callListFlows = clientHelper.BuildApiCall<ListFlowsRequest, ListFlowsResponse>("ListFlows", grpcClient.ListFlowsAsync, grpcClient.ListFlows, effectiveSettings.ListFlowsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListFlows);
            Modify_ListFlowsApiCall(ref _callListFlows);
            _callGetFlow = clientHelper.BuildApiCall<GetFlowRequest, Flow>("GetFlow", grpcClient.GetFlowAsync, grpcClient.GetFlow, effectiveSettings.GetFlowSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetFlow);
            Modify_GetFlowApiCall(ref _callGetFlow);
            _callUpdateFlow = clientHelper.BuildApiCall<UpdateFlowRequest, Flow>("UpdateFlow", grpcClient.UpdateFlowAsync, grpcClient.UpdateFlow, effectiveSettings.UpdateFlowSettings).WithGoogleRequestParam("flow.name", request => request.Flow?.Name);
            Modify_ApiCall(ref _callUpdateFlow);
            Modify_UpdateFlowApiCall(ref _callUpdateFlow);
            _callTrainFlow = clientHelper.BuildApiCall<TrainFlowRequest, lro::Operation>("TrainFlow", grpcClient.TrainFlowAsync, grpcClient.TrainFlow, effectiveSettings.TrainFlowSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callTrainFlow);
            Modify_TrainFlowApiCall(ref _callTrainFlow);
            _callValidateFlow = clientHelper.BuildApiCall<ValidateFlowRequest, FlowValidationResult>("ValidateFlow", grpcClient.ValidateFlowAsync, grpcClient.ValidateFlow, effectiveSettings.ValidateFlowSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callValidateFlow);
            Modify_ValidateFlowApiCall(ref _callValidateFlow);
            _callGetFlowValidationResult = clientHelper.BuildApiCall<GetFlowValidationResultRequest, FlowValidationResult>("GetFlowValidationResult", grpcClient.GetFlowValidationResultAsync, grpcClient.GetFlowValidationResult, effectiveSettings.GetFlowValidationResultSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetFlowValidationResult);
            Modify_GetFlowValidationResultApiCall(ref _callGetFlowValidationResult);
            _callImportFlow = clientHelper.BuildApiCall<ImportFlowRequest, lro::Operation>("ImportFlow", grpcClient.ImportFlowAsync, grpcClient.ImportFlow, effectiveSettings.ImportFlowSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callImportFlow);
            Modify_ImportFlowApiCall(ref _callImportFlow);
            _callExportFlow = clientHelper.BuildApiCall<ExportFlowRequest, lro::Operation>("ExportFlow", grpcClient.ExportFlowAsync, grpcClient.ExportFlow, effectiveSettings.ExportFlowSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callExportFlow);
            Modify_ExportFlowApiCall(ref _callExportFlow);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateFlowApiCall(ref gaxgrpc::ApiCall<CreateFlowRequest, Flow> call);

        partial void Modify_DeleteFlowApiCall(ref gaxgrpc::ApiCall<DeleteFlowRequest, wkt::Empty> call);

        partial void Modify_ListFlowsApiCall(ref gaxgrpc::ApiCall<ListFlowsRequest, ListFlowsResponse> call);

        partial void Modify_GetFlowApiCall(ref gaxgrpc::ApiCall<GetFlowRequest, Flow> call);

        partial void Modify_UpdateFlowApiCall(ref gaxgrpc::ApiCall<UpdateFlowRequest, Flow> call);

        partial void Modify_TrainFlowApiCall(ref gaxgrpc::ApiCall<TrainFlowRequest, lro::Operation> call);

        partial void Modify_ValidateFlowApiCall(ref gaxgrpc::ApiCall<ValidateFlowRequest, FlowValidationResult> call);

        partial void Modify_GetFlowValidationResultApiCall(ref gaxgrpc::ApiCall<GetFlowValidationResultRequest, FlowValidationResult> call);

        partial void Modify_ImportFlowApiCall(ref gaxgrpc::ApiCall<ImportFlowRequest, lro::Operation> call);

        partial void Modify_ExportFlowApiCall(ref gaxgrpc::ApiCall<ExportFlowRequest, lro::Operation> call);

        partial void OnConstruction(Flows.FlowsClient grpcClient, FlowsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Flows client</summary>
        public override Flows.FlowsClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CreateFlowRequest(ref CreateFlowRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteFlowRequest(ref DeleteFlowRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListFlowsRequest(ref ListFlowsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetFlowRequest(ref GetFlowRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateFlowRequest(ref UpdateFlowRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TrainFlowRequest(ref TrainFlowRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ValidateFlowRequest(ref ValidateFlowRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetFlowValidationResultRequest(ref GetFlowValidationResultRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportFlowRequest(ref ImportFlowRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportFlowRequest(ref ExportFlowRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a flow in the specified agent.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Flow CreateFlow(CreateFlowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFlowRequest(ref request, ref callSettings);
            return _callCreateFlow.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a flow in the specified agent.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Flow> CreateFlowAsync(CreateFlowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFlowRequest(ref request, ref callSettings);
            return _callCreateFlow.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a specified flow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteFlow(DeleteFlowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFlowRequest(ref request, ref callSettings);
            _callDeleteFlow.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a specified flow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteFlowAsync(DeleteFlowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFlowRequest(ref request, ref callSettings);
            return _callDeleteFlow.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all flows in the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Flow"/> resources.</returns>
        public override gax::PagedEnumerable<ListFlowsResponse, Flow> ListFlows(ListFlowsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFlowsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListFlowsRequest, ListFlowsResponse, Flow>(_callListFlows, request, callSettings);
        }

        /// <summary>
        /// Returns the list of all flows in the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Flow"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListFlowsResponse, Flow> ListFlowsAsync(ListFlowsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFlowsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListFlowsRequest, ListFlowsResponse, Flow>(_callListFlows, request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified flow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Flow GetFlow(GetFlowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFlowRequest(ref request, ref callSettings);
            return _callGetFlow.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified flow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Flow> GetFlowAsync(GetFlowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFlowRequest(ref request, ref callSettings);
            return _callGetFlow.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the specified flow.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Flow UpdateFlow(UpdateFlowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFlowRequest(ref request, ref callSettings);
            return _callUpdateFlow.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified flow.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Flow> UpdateFlowAsync(UpdateFlowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFlowRequest(ref request, ref callSettings);
            return _callUpdateFlow.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>TrainFlow</c>.</summary>
        public override lro::OperationsClient TrainFlowOperationsClient { get; }

        /// <summary>
        /// Trains the specified flow. Note that only the flow in 'draft' environment
        /// is trained.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, wkt::Struct> TrainFlow(TrainFlowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TrainFlowRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, wkt::Struct>(_callTrainFlow.Sync(request, callSettings), TrainFlowOperationsClient);
        }

        /// <summary>
        /// Trains the specified flow. Note that only the flow in 'draft' environment
        /// is trained.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> TrainFlowAsync(TrainFlowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TrainFlowRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, wkt::Struct>(await _callTrainFlow.Async(request, callSettings).ConfigureAwait(false), TrainFlowOperationsClient);
        }

        /// <summary>
        /// Validates the specified flow and creates or updates validation results.
        /// Please call this API after the training is completed to get the complete
        /// validation results.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FlowValidationResult ValidateFlow(ValidateFlowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ValidateFlowRequest(ref request, ref callSettings);
            return _callValidateFlow.Sync(request, callSettings);
        }

        /// <summary>
        /// Validates the specified flow and creates or updates validation results.
        /// Please call this API after the training is completed to get the complete
        /// validation results.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FlowValidationResult> ValidateFlowAsync(ValidateFlowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ValidateFlowRequest(ref request, ref callSettings);
            return _callValidateFlow.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the latest flow validation result. Flow validation is performed
        /// when ValidateFlow is called.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FlowValidationResult GetFlowValidationResult(GetFlowValidationResultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFlowValidationResultRequest(ref request, ref callSettings);
            return _callGetFlowValidationResult.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the latest flow validation result. Flow validation is performed
        /// when ValidateFlow is called.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FlowValidationResult> GetFlowValidationResultAsync(GetFlowValidationResultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFlowValidationResultRequest(ref request, ref callSettings);
            return _callGetFlowValidationResult.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>ImportFlow</c>.</summary>
        public override lro::OperationsClient ImportFlowOperationsClient { get; }

        /// <summary>
        /// Imports the specified flow to the specified agent from a binary file.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`:
        /// [ImportFlowResponse][google.cloud.dialogflow.cx.v3.ImportFlowResponse]
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ImportFlowResponse, wkt::Struct> ImportFlow(ImportFlowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportFlowRequest(ref request, ref callSettings);
            return new lro::Operation<ImportFlowResponse, wkt::Struct>(_callImportFlow.Sync(request, callSettings), ImportFlowOperationsClient);
        }

        /// <summary>
        /// Imports the specified flow to the specified agent from a binary file.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`:
        /// [ImportFlowResponse][google.cloud.dialogflow.cx.v3.ImportFlowResponse]
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ImportFlowResponse, wkt::Struct>> ImportFlowAsync(ImportFlowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportFlowRequest(ref request, ref callSettings);
            return new lro::Operation<ImportFlowResponse, wkt::Struct>(await _callImportFlow.Async(request, callSettings).ConfigureAwait(false), ImportFlowOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ExportFlow</c>.</summary>
        public override lro::OperationsClient ExportFlowOperationsClient { get; }

        /// <summary>
        /// Exports the specified flow to a binary file.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`:
        /// [ExportFlowResponse][google.cloud.dialogflow.cx.v3.ExportFlowResponse]
        /// 
        /// Note that resources (e.g. intents, entities, webhooks) that the flow
        /// references will also be exported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ExportFlowResponse, wkt::Struct> ExportFlow(ExportFlowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportFlowRequest(ref request, ref callSettings);
            return new lro::Operation<ExportFlowResponse, wkt::Struct>(_callExportFlow.Sync(request, callSettings), ExportFlowOperationsClient);
        }

        /// <summary>
        /// Exports the specified flow to a binary file.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`:
        /// [ExportFlowResponse][google.cloud.dialogflow.cx.v3.ExportFlowResponse]
        /// 
        /// Note that resources (e.g. intents, entities, webhooks) that the flow
        /// references will also be exported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ExportFlowResponse, wkt::Struct>> ExportFlowAsync(ExportFlowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportFlowRequest(ref request, ref callSettings);
            return new lro::Operation<ExportFlowResponse, wkt::Struct>(await _callExportFlow.Async(request, callSettings).ConfigureAwait(false), ExportFlowOperationsClient);
        }
    }

    public partial class ListFlowsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListFlowsResponse : gaxgrpc::IPageResponse<Flow>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Flow> GetEnumerator() => Flows.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Flows
    {
        public partial class FlowsClient
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

    public static partial class Flows
    {
        public partial class FlowsClient
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
