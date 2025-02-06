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
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.Retail.V2
{
    /// <summary>Settings for <see cref="AnalyticsServiceClient"/> instances.</summary>
    public sealed partial class AnalyticsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AnalyticsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AnalyticsServiceSettings"/>.</returns>
        public static AnalyticsServiceSettings GetDefault() => new AnalyticsServiceSettings();

        /// <summary>Constructs a new <see cref="AnalyticsServiceSettings"/> object with default settings.</summary>
        public AnalyticsServiceSettings()
        {
        }

        private AnalyticsServiceSettings(AnalyticsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ExportAnalyticsMetricsSettings = existing.ExportAnalyticsMetricsSettings;
            ExportAnalyticsMetricsOperationsSettings = existing.ExportAnalyticsMetricsOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AnalyticsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AnalyticsServiceClient.ExportAnalyticsMetrics</c> and
        /// <c>AnalyticsServiceClient.ExportAnalyticsMetricsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExportAnalyticsMetricsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AnalyticsServiceClient.ExportAnalyticsMetrics</c> and
        /// <c>AnalyticsServiceClient.ExportAnalyticsMetricsAsync</c>.
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
        public lro::OperationsSettings ExportAnalyticsMetricsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AnalyticsServiceSettings"/> object.</returns>
        public AnalyticsServiceSettings Clone() => new AnalyticsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AnalyticsServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class AnalyticsServiceClientBuilder : gaxgrpc::ClientBuilderBase<AnalyticsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AnalyticsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AnalyticsServiceClientBuilder() : base(AnalyticsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AnalyticsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AnalyticsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AnalyticsServiceClient Build()
        {
            AnalyticsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AnalyticsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AnalyticsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AnalyticsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AnalyticsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AnalyticsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AnalyticsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AnalyticsServiceClient.ChannelPool;
    }

    /// <summary>AnalyticsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing &amp; accessing retail search business metric.
    /// Retail recommendation business metric is currently not available.
    /// </remarks>
    public abstract partial class AnalyticsServiceClient
    {
        /// <summary>
        /// The default endpoint for the AnalyticsService service, which is a host of "retail.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "retail.googleapis.com:443";

        /// <summary>The default AnalyticsService scopes.</summary>
        /// <remarks>
        /// The default AnalyticsService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AnalyticsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AnalyticsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AnalyticsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AnalyticsServiceClient"/>.</returns>
        public static stt::Task<AnalyticsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AnalyticsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AnalyticsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AnalyticsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AnalyticsServiceClient"/>.</returns>
        public static AnalyticsServiceClient Create() => new AnalyticsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AnalyticsServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AnalyticsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AnalyticsServiceClient"/>.</returns>
        internal static AnalyticsServiceClient Create(grpccore::CallInvoker callInvoker, AnalyticsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AnalyticsService.AnalyticsServiceClient grpcClient = new AnalyticsService.AnalyticsServiceClient(callInvoker);
            return new AnalyticsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AnalyticsService client</summary>
        public virtual AnalyticsService.AnalyticsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Exports analytics metrics.
        /// 
        /// `Operation.response` is of type `ExportAnalyticsMetricsResponse`.
        /// `Operation.metadata` is of type `ExportMetadata`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportAnalyticsMetricsResponse, ExportMetadata> ExportAnalyticsMetrics(ExportAnalyticsMetricsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports analytics metrics.
        /// 
        /// `Operation.response` is of type `ExportAnalyticsMetricsResponse`.
        /// `Operation.metadata` is of type `ExportMetadata`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportAnalyticsMetricsResponse, ExportMetadata>> ExportAnalyticsMetricsAsync(ExportAnalyticsMetricsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports analytics metrics.
        /// 
        /// `Operation.response` is of type `ExportAnalyticsMetricsResponse`.
        /// `Operation.metadata` is of type `ExportMetadata`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportAnalyticsMetricsResponse, ExportMetadata>> ExportAnalyticsMetricsAsync(ExportAnalyticsMetricsRequest request, st::CancellationToken cancellationToken) =>
            ExportAnalyticsMetricsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ExportAnalyticsMetrics</c>.</summary>
        public virtual lro::OperationsClient ExportAnalyticsMetricsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportAnalyticsMetrics</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ExportAnalyticsMetricsResponse, ExportMetadata> PollOnceExportAnalyticsMetrics(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportAnalyticsMetricsResponse, ExportMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportAnalyticsMetricsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportAnalyticsMetrics</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ExportAnalyticsMetricsResponse, ExportMetadata>> PollOnceExportAnalyticsMetricsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportAnalyticsMetricsResponse, ExportMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportAnalyticsMetricsOperationsClient, callSettings);
    }

    /// <summary>AnalyticsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing &amp; accessing retail search business metric.
    /// Retail recommendation business metric is currently not available.
    /// </remarks>
    public sealed partial class AnalyticsServiceClientImpl : AnalyticsServiceClient
    {
        private readonly gaxgrpc::ApiCall<ExportAnalyticsMetricsRequest, lro::Operation> _callExportAnalyticsMetrics;

        /// <summary>
        /// Constructs a client wrapper for the AnalyticsService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AnalyticsServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AnalyticsServiceClientImpl(AnalyticsService.AnalyticsServiceClient grpcClient, AnalyticsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AnalyticsServiceSettings effectiveSettings = settings ?? AnalyticsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            ExportAnalyticsMetricsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ExportAnalyticsMetricsOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callExportAnalyticsMetrics = clientHelper.BuildApiCall<ExportAnalyticsMetricsRequest, lro::Operation>("ExportAnalyticsMetrics", grpcClient.ExportAnalyticsMetricsAsync, grpcClient.ExportAnalyticsMetrics, effectiveSettings.ExportAnalyticsMetricsSettings).WithGoogleRequestParam("catalog", request => request.Catalog);
            Modify_ApiCall(ref _callExportAnalyticsMetrics);
            Modify_ExportAnalyticsMetricsApiCall(ref _callExportAnalyticsMetrics);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ExportAnalyticsMetricsApiCall(ref gaxgrpc::ApiCall<ExportAnalyticsMetricsRequest, lro::Operation> call);

        partial void OnConstruction(AnalyticsService.AnalyticsServiceClient grpcClient, AnalyticsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AnalyticsService client</summary>
        public override AnalyticsService.AnalyticsServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ExportAnalyticsMetricsRequest(ref ExportAnalyticsMetricsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>ExportAnalyticsMetrics</c>.</summary>
        public override lro::OperationsClient ExportAnalyticsMetricsOperationsClient { get; }

        /// <summary>
        /// Exports analytics metrics.
        /// 
        /// `Operation.response` is of type `ExportAnalyticsMetricsResponse`.
        /// `Operation.metadata` is of type `ExportMetadata`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ExportAnalyticsMetricsResponse, ExportMetadata> ExportAnalyticsMetrics(ExportAnalyticsMetricsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportAnalyticsMetricsRequest(ref request, ref callSettings);
            return new lro::Operation<ExportAnalyticsMetricsResponse, ExportMetadata>(_callExportAnalyticsMetrics.Sync(request, callSettings), ExportAnalyticsMetricsOperationsClient);
        }

        /// <summary>
        /// Exports analytics metrics.
        /// 
        /// `Operation.response` is of type `ExportAnalyticsMetricsResponse`.
        /// `Operation.metadata` is of type `ExportMetadata`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ExportAnalyticsMetricsResponse, ExportMetadata>> ExportAnalyticsMetricsAsync(ExportAnalyticsMetricsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportAnalyticsMetricsRequest(ref request, ref callSettings);
            return new lro::Operation<ExportAnalyticsMetricsResponse, ExportMetadata>(await _callExportAnalyticsMetrics.Async(request, callSettings).ConfigureAwait(false), ExportAnalyticsMetricsOperationsClient);
        }
    }

    public static partial class AnalyticsService
    {
        public partial class AnalyticsServiceClient
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

    public static partial class AnalyticsService
    {
        public partial class AnalyticsServiceClient
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
