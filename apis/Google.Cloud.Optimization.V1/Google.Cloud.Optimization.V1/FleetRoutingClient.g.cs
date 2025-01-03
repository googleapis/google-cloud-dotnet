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

namespace Google.Cloud.Optimization.V1
{
    /// <summary>Settings for <see cref="FleetRoutingClient"/> instances.</summary>
    public sealed partial class FleetRoutingSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="FleetRoutingSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="FleetRoutingSettings"/>.</returns>
        public static FleetRoutingSettings GetDefault() => new FleetRoutingSettings();

        /// <summary>Constructs a new <see cref="FleetRoutingSettings"/> object with default settings.</summary>
        public FleetRoutingSettings()
        {
        }

        private FleetRoutingSettings(FleetRoutingSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            OptimizeToursSettings = existing.OptimizeToursSettings;
            BatchOptimizeToursSettings = existing.BatchOptimizeToursSettings;
            BatchOptimizeToursOperationsSettings = existing.BatchOptimizeToursOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(FleetRoutingSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FleetRoutingClient.OptimizeTours</c> and <c>FleetRoutingClient.OptimizeToursAsync</c>.
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
        /// <item><description>Timeout: 3600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings OptimizeToursSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FleetRoutingClient.BatchOptimizeTours</c> and <c>FleetRoutingClient.BatchOptimizeToursAsync</c>.
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
        public gaxgrpc::CallSettings BatchOptimizeToursSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>FleetRoutingClient.BatchOptimizeTours</c> and
        /// <c>FleetRoutingClient.BatchOptimizeToursAsync</c>.
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
        public lro::OperationsSettings BatchOptimizeToursOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="FleetRoutingSettings"/> object.</returns>
        public FleetRoutingSettings Clone() => new FleetRoutingSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="FleetRoutingClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class FleetRoutingClientBuilder : gaxgrpc::ClientBuilderBase<FleetRoutingClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public FleetRoutingSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public FleetRoutingClientBuilder() : base(FleetRoutingClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref FleetRoutingClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<FleetRoutingClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override FleetRoutingClient Build()
        {
            FleetRoutingClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<FleetRoutingClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<FleetRoutingClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private FleetRoutingClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return FleetRoutingClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<FleetRoutingClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return FleetRoutingClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => FleetRoutingClient.ChannelPool;
    }

    /// <summary>FleetRouting client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service for optimizing vehicle tours.
    /// 
    /// Validity of certain types of fields:
    /// 
    /// * `google.protobuf.Timestamp`
    /// * Times are in Unix time: seconds since 1970-01-01T00:00:00+00:00.
    /// * seconds must be in [0, 253402300799],
    /// i.e. in [1970-01-01T00:00:00+00:00, 9999-12-31T23:59:59+00:00].
    /// * nanos must be unset or set to 0.
    /// * `google.protobuf.Duration`
    /// * seconds must be in [0, 253402300799],
    /// i.e. in [1970-01-01T00:00:00+00:00, 9999-12-31T23:59:59+00:00].
    /// * nanos must be unset or set to 0.
    /// * `google.type.LatLng`
    /// * latitude must be in [-90.0, 90.0].
    /// * longitude must be in [-180.0, 180.0].
    /// * at least one of latitude and longitude must be non-zero.
    /// </remarks>
    public abstract partial class FleetRoutingClient
    {
        /// <summary>
        /// The default endpoint for the FleetRouting service, which is a host of "cloudoptimization.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudoptimization.googleapis.com:443";

        /// <summary>The default FleetRouting scopes.</summary>
        /// <remarks>
        /// The default FleetRouting scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(FleetRouting.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="FleetRoutingClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="FleetRoutingClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="FleetRoutingClient"/>.</returns>
        public static stt::Task<FleetRoutingClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new FleetRoutingClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="FleetRoutingClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="FleetRoutingClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="FleetRoutingClient"/>.</returns>
        public static FleetRoutingClient Create() => new FleetRoutingClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="FleetRoutingClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="FleetRoutingSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="FleetRoutingClient"/>.</returns>
        internal static FleetRoutingClient Create(grpccore::CallInvoker callInvoker, FleetRoutingSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            FleetRouting.FleetRoutingClient grpcClient = new FleetRouting.FleetRoutingClient(callInvoker);
            return new FleetRoutingClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC FleetRouting client</summary>
        public virtual FleetRouting.FleetRoutingClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Sends an `OptimizeToursRequest` containing a `ShipmentModel` and returns an
        /// `OptimizeToursResponse` containing `ShipmentRoute`s, which are a set of
        /// routes to be performed by vehicles minimizing the overall cost.
        /// 
        /// A `ShipmentModel` model consists mainly of `Shipment`s that need to be
        /// carried out and `Vehicle`s that can be used to transport the `Shipment`s.
        /// The `ShipmentRoute`s assign `Shipment`s to `Vehicle`s. More specifically,
        /// they assign a series of `Visit`s to each vehicle, where a `Visit`
        /// corresponds to a `VisitRequest`, which is a pickup or delivery for a
        /// `Shipment`.
        /// 
        /// The goal is to provide an assignment of `ShipmentRoute`s to `Vehicle`s that
        /// minimizes the total cost where cost has many components defined in the
        /// `ShipmentModel`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual OptimizeToursResponse OptimizeTours(OptimizeToursRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sends an `OptimizeToursRequest` containing a `ShipmentModel` and returns an
        /// `OptimizeToursResponse` containing `ShipmentRoute`s, which are a set of
        /// routes to be performed by vehicles minimizing the overall cost.
        /// 
        /// A `ShipmentModel` model consists mainly of `Shipment`s that need to be
        /// carried out and `Vehicle`s that can be used to transport the `Shipment`s.
        /// The `ShipmentRoute`s assign `Shipment`s to `Vehicle`s. More specifically,
        /// they assign a series of `Visit`s to each vehicle, where a `Visit`
        /// corresponds to a `VisitRequest`, which is a pickup or delivery for a
        /// `Shipment`.
        /// 
        /// The goal is to provide an assignment of `ShipmentRoute`s to `Vehicle`s that
        /// minimizes the total cost where cost has many components defined in the
        /// `ShipmentModel`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OptimizeToursResponse> OptimizeToursAsync(OptimizeToursRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sends an `OptimizeToursRequest` containing a `ShipmentModel` and returns an
        /// `OptimizeToursResponse` containing `ShipmentRoute`s, which are a set of
        /// routes to be performed by vehicles minimizing the overall cost.
        /// 
        /// A `ShipmentModel` model consists mainly of `Shipment`s that need to be
        /// carried out and `Vehicle`s that can be used to transport the `Shipment`s.
        /// The `ShipmentRoute`s assign `Shipment`s to `Vehicle`s. More specifically,
        /// they assign a series of `Visit`s to each vehicle, where a `Visit`
        /// corresponds to a `VisitRequest`, which is a pickup or delivery for a
        /// `Shipment`.
        /// 
        /// The goal is to provide an assignment of `ShipmentRoute`s to `Vehicle`s that
        /// minimizes the total cost where cost has many components defined in the
        /// `ShipmentModel`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OptimizeToursResponse> OptimizeToursAsync(OptimizeToursRequest request, st::CancellationToken cancellationToken) =>
            OptimizeToursAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Optimizes vehicle tours for one or more `OptimizeToursRequest`
        /// messages as a batch.
        /// 
        /// This method is a Long Running Operation (LRO). The inputs for optimization
        /// (`OptimizeToursRequest` messages) and outputs (`OptimizeToursResponse`
        /// messages) are read/written from/to Cloud Storage in user-specified
        /// format. Like the `OptimizeTours` method, each `OptimizeToursRequest`
        /// contains a `ShipmentModel` and returns an `OptimizeToursResponse`
        /// containing `ShipmentRoute`s, which are a set of routes to be performed by
        /// vehicles minimizing the overall cost.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchOptimizeToursResponse, AsyncModelMetadata> BatchOptimizeTours(BatchOptimizeToursRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Optimizes vehicle tours for one or more `OptimizeToursRequest`
        /// messages as a batch.
        /// 
        /// This method is a Long Running Operation (LRO). The inputs for optimization
        /// (`OptimizeToursRequest` messages) and outputs (`OptimizeToursResponse`
        /// messages) are read/written from/to Cloud Storage in user-specified
        /// format. Like the `OptimizeTours` method, each `OptimizeToursRequest`
        /// contains a `ShipmentModel` and returns an `OptimizeToursResponse`
        /// containing `ShipmentRoute`s, which are a set of routes to be performed by
        /// vehicles minimizing the overall cost.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchOptimizeToursResponse, AsyncModelMetadata>> BatchOptimizeToursAsync(BatchOptimizeToursRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Optimizes vehicle tours for one or more `OptimizeToursRequest`
        /// messages as a batch.
        /// 
        /// This method is a Long Running Operation (LRO). The inputs for optimization
        /// (`OptimizeToursRequest` messages) and outputs (`OptimizeToursResponse`
        /// messages) are read/written from/to Cloud Storage in user-specified
        /// format. Like the `OptimizeTours` method, each `OptimizeToursRequest`
        /// contains a `ShipmentModel` and returns an `OptimizeToursResponse`
        /// containing `ShipmentRoute`s, which are a set of routes to be performed by
        /// vehicles minimizing the overall cost.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchOptimizeToursResponse, AsyncModelMetadata>> BatchOptimizeToursAsync(BatchOptimizeToursRequest request, st::CancellationToken cancellationToken) =>
            BatchOptimizeToursAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>BatchOptimizeTours</c>.</summary>
        public virtual lro::OperationsClient BatchOptimizeToursOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchOptimizeTours</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BatchOptimizeToursResponse, AsyncModelMetadata> PollOnceBatchOptimizeTours(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchOptimizeToursResponse, AsyncModelMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchOptimizeToursOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchOptimizeTours</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BatchOptimizeToursResponse, AsyncModelMetadata>> PollOnceBatchOptimizeToursAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchOptimizeToursResponse, AsyncModelMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchOptimizeToursOperationsClient, callSettings);
    }

    /// <summary>FleetRouting client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service for optimizing vehicle tours.
    /// 
    /// Validity of certain types of fields:
    /// 
    /// * `google.protobuf.Timestamp`
    /// * Times are in Unix time: seconds since 1970-01-01T00:00:00+00:00.
    /// * seconds must be in [0, 253402300799],
    /// i.e. in [1970-01-01T00:00:00+00:00, 9999-12-31T23:59:59+00:00].
    /// * nanos must be unset or set to 0.
    /// * `google.protobuf.Duration`
    /// * seconds must be in [0, 253402300799],
    /// i.e. in [1970-01-01T00:00:00+00:00, 9999-12-31T23:59:59+00:00].
    /// * nanos must be unset or set to 0.
    /// * `google.type.LatLng`
    /// * latitude must be in [-90.0, 90.0].
    /// * longitude must be in [-180.0, 180.0].
    /// * at least one of latitude and longitude must be non-zero.
    /// </remarks>
    public sealed partial class FleetRoutingClientImpl : FleetRoutingClient
    {
        private readonly gaxgrpc::ApiCall<OptimizeToursRequest, OptimizeToursResponse> _callOptimizeTours;

        private readonly gaxgrpc::ApiCall<BatchOptimizeToursRequest, lro::Operation> _callBatchOptimizeTours;

        /// <summary>
        /// Constructs a client wrapper for the FleetRouting service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="FleetRoutingSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public FleetRoutingClientImpl(FleetRouting.FleetRoutingClient grpcClient, FleetRoutingSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            FleetRoutingSettings effectiveSettings = settings ?? FleetRoutingSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            BatchOptimizeToursOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.BatchOptimizeToursOperationsSettings, logger);
            _callOptimizeTours = clientHelper.BuildApiCall<OptimizeToursRequest, OptimizeToursResponse>("OptimizeTours", grpcClient.OptimizeToursAsync, grpcClient.OptimizeTours, effectiveSettings.OptimizeToursSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callOptimizeTours);
            Modify_OptimizeToursApiCall(ref _callOptimizeTours);
            _callBatchOptimizeTours = clientHelper.BuildApiCall<BatchOptimizeToursRequest, lro::Operation>("BatchOptimizeTours", grpcClient.BatchOptimizeToursAsync, grpcClient.BatchOptimizeTours, effectiveSettings.BatchOptimizeToursSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchOptimizeTours);
            Modify_BatchOptimizeToursApiCall(ref _callBatchOptimizeTours);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_OptimizeToursApiCall(ref gaxgrpc::ApiCall<OptimizeToursRequest, OptimizeToursResponse> call);

        partial void Modify_BatchOptimizeToursApiCall(ref gaxgrpc::ApiCall<BatchOptimizeToursRequest, lro::Operation> call);

        partial void OnConstruction(FleetRouting.FleetRoutingClient grpcClient, FleetRoutingSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC FleetRouting client</summary>
        public override FleetRouting.FleetRoutingClient GrpcClient { get; }

        partial void Modify_OptimizeToursRequest(ref OptimizeToursRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchOptimizeToursRequest(ref BatchOptimizeToursRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Sends an `OptimizeToursRequest` containing a `ShipmentModel` and returns an
        /// `OptimizeToursResponse` containing `ShipmentRoute`s, which are a set of
        /// routes to be performed by vehicles minimizing the overall cost.
        /// 
        /// A `ShipmentModel` model consists mainly of `Shipment`s that need to be
        /// carried out and `Vehicle`s that can be used to transport the `Shipment`s.
        /// The `ShipmentRoute`s assign `Shipment`s to `Vehicle`s. More specifically,
        /// they assign a series of `Visit`s to each vehicle, where a `Visit`
        /// corresponds to a `VisitRequest`, which is a pickup or delivery for a
        /// `Shipment`.
        /// 
        /// The goal is to provide an assignment of `ShipmentRoute`s to `Vehicle`s that
        /// minimizes the total cost where cost has many components defined in the
        /// `ShipmentModel`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override OptimizeToursResponse OptimizeTours(OptimizeToursRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_OptimizeToursRequest(ref request, ref callSettings);
            return _callOptimizeTours.Sync(request, callSettings);
        }

        /// <summary>
        /// Sends an `OptimizeToursRequest` containing a `ShipmentModel` and returns an
        /// `OptimizeToursResponse` containing `ShipmentRoute`s, which are a set of
        /// routes to be performed by vehicles minimizing the overall cost.
        /// 
        /// A `ShipmentModel` model consists mainly of `Shipment`s that need to be
        /// carried out and `Vehicle`s that can be used to transport the `Shipment`s.
        /// The `ShipmentRoute`s assign `Shipment`s to `Vehicle`s. More specifically,
        /// they assign a series of `Visit`s to each vehicle, where a `Visit`
        /// corresponds to a `VisitRequest`, which is a pickup or delivery for a
        /// `Shipment`.
        /// 
        /// The goal is to provide an assignment of `ShipmentRoute`s to `Vehicle`s that
        /// minimizes the total cost where cost has many components defined in the
        /// `ShipmentModel`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<OptimizeToursResponse> OptimizeToursAsync(OptimizeToursRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_OptimizeToursRequest(ref request, ref callSettings);
            return _callOptimizeTours.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>BatchOptimizeTours</c>.</summary>
        public override lro::OperationsClient BatchOptimizeToursOperationsClient { get; }

        /// <summary>
        /// Optimizes vehicle tours for one or more `OptimizeToursRequest`
        /// messages as a batch.
        /// 
        /// This method is a Long Running Operation (LRO). The inputs for optimization
        /// (`OptimizeToursRequest` messages) and outputs (`OptimizeToursResponse`
        /// messages) are read/written from/to Cloud Storage in user-specified
        /// format. Like the `OptimizeTours` method, each `OptimizeToursRequest`
        /// contains a `ShipmentModel` and returns an `OptimizeToursResponse`
        /// containing `ShipmentRoute`s, which are a set of routes to be performed by
        /// vehicles minimizing the overall cost.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BatchOptimizeToursResponse, AsyncModelMetadata> BatchOptimizeTours(BatchOptimizeToursRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchOptimizeToursRequest(ref request, ref callSettings);
            return new lro::Operation<BatchOptimizeToursResponse, AsyncModelMetadata>(_callBatchOptimizeTours.Sync(request, callSettings), BatchOptimizeToursOperationsClient);
        }

        /// <summary>
        /// Optimizes vehicle tours for one or more `OptimizeToursRequest`
        /// messages as a batch.
        /// 
        /// This method is a Long Running Operation (LRO). The inputs for optimization
        /// (`OptimizeToursRequest` messages) and outputs (`OptimizeToursResponse`
        /// messages) are read/written from/to Cloud Storage in user-specified
        /// format. Like the `OptimizeTours` method, each `OptimizeToursRequest`
        /// contains a `ShipmentModel` and returns an `OptimizeToursResponse`
        /// containing `ShipmentRoute`s, which are a set of routes to be performed by
        /// vehicles minimizing the overall cost.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BatchOptimizeToursResponse, AsyncModelMetadata>> BatchOptimizeToursAsync(BatchOptimizeToursRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchOptimizeToursRequest(ref request, ref callSettings);
            return new lro::Operation<BatchOptimizeToursResponse, AsyncModelMetadata>(await _callBatchOptimizeTours.Async(request, callSettings).ConfigureAwait(false), BatchOptimizeToursOperationsClient);
        }
    }

    public static partial class FleetRouting
    {
        public partial class FleetRoutingClient
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
