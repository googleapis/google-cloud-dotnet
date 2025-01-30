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

namespace Google.Maps.RouteOptimization.V1
{
    /// <summary>Settings for <see cref="RouteOptimizationClient"/> instances.</summary>
    public sealed partial class RouteOptimizationSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="RouteOptimizationSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="RouteOptimizationSettings"/>.</returns>
        public static RouteOptimizationSettings GetDefault() => new RouteOptimizationSettings();

        /// <summary>Constructs a new <see cref="RouteOptimizationSettings"/> object with default settings.</summary>
        public RouteOptimizationSettings()
        {
        }

        private RouteOptimizationSettings(RouteOptimizationSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            OptimizeToursSettings = existing.OptimizeToursSettings;
            BatchOptimizeToursSettings = existing.BatchOptimizeToursSettings;
            BatchOptimizeToursOperationsSettings = existing.BatchOptimizeToursOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(RouteOptimizationSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RouteOptimizationClient.OptimizeTours</c> and <c>RouteOptimizationClient.OptimizeToursAsync</c>.
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
        /// <c>RouteOptimizationClient.BatchOptimizeTours</c> and <c>RouteOptimizationClient.BatchOptimizeToursAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchOptimizeToursSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>RouteOptimizationClient.BatchOptimizeTours</c> and
        /// <c>RouteOptimizationClient.BatchOptimizeToursAsync</c>.
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
        /// <returns>A deep clone of this <see cref="RouteOptimizationSettings"/> object.</returns>
        public RouteOptimizationSettings Clone() => new RouteOptimizationSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="RouteOptimizationClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class RouteOptimizationClientBuilder : gaxgrpc::ClientBuilderBase<RouteOptimizationClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public RouteOptimizationSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public RouteOptimizationClientBuilder() : base(RouteOptimizationClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref RouteOptimizationClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<RouteOptimizationClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override RouteOptimizationClient Build()
        {
            RouteOptimizationClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<RouteOptimizationClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<RouteOptimizationClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private RouteOptimizationClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return RouteOptimizationClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<RouteOptimizationClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return RouteOptimizationClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => RouteOptimizationClient.ChannelPool;
    }

    /// <summary>RouteOptimization client wrapper, for convenient use.</summary>
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
    public abstract partial class RouteOptimizationClient
    {
        /// <summary>
        /// The default endpoint for the RouteOptimization service, which is a host of
        /// "routeoptimization.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "routeoptimization.googleapis.com:443";

        /// <summary>The default RouteOptimization scopes.</summary>
        /// <remarks>
        /// The default RouteOptimization scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(RouteOptimization.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="RouteOptimizationClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="RouteOptimizationClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="RouteOptimizationClient"/>.</returns>
        public static stt::Task<RouteOptimizationClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new RouteOptimizationClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="RouteOptimizationClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="RouteOptimizationClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="RouteOptimizationClient"/>.</returns>
        public static RouteOptimizationClient Create() => new RouteOptimizationClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="RouteOptimizationClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="RouteOptimizationSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="RouteOptimizationClient"/>.</returns>
        internal static RouteOptimizationClient Create(grpccore::CallInvoker callInvoker, RouteOptimizationSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            RouteOptimization.RouteOptimizationClient grpcClient = new RouteOptimization.RouteOptimizationClient(callInvoker);
            return new RouteOptimizationClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC RouteOptimization client</summary>
        public virtual RouteOptimization.RouteOptimizationClient GrpcClient => throw new sys::NotImplementedException();

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
        /// messages) are read from and written to Cloud Storage in user-specified
        /// format. Like the `OptimizeTours` method, each `OptimizeToursRequest`
        /// contains a `ShipmentModel` and returns an `OptimizeToursResponse`
        /// containing `ShipmentRoute` fields, which are a set of routes to be
        /// performed by vehicles minimizing the overall cost.
        /// 
        /// The user can poll `operations.get` to check the status of the LRO:
        /// 
        /// If the LRO `done` field is false, then at least one request is still
        /// being processed. Other requests may have completed successfully and their
        /// results are available in Cloud Storage.
        /// 
        /// If the LRO's `done` field is true, then all requests have been processed.
        /// Any successfully processed requests will have their results available in
        /// Cloud Storage. Any requests that failed will not have their results
        /// available in Cloud Storage. If the LRO's `error` field is set, then it
        /// contains the error from one of the failed requests.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchOptimizeToursResponse, BatchOptimizeToursMetadata> BatchOptimizeTours(BatchOptimizeToursRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Optimizes vehicle tours for one or more `OptimizeToursRequest`
        /// messages as a batch.
        /// 
        /// This method is a Long Running Operation (LRO). The inputs for optimization
        /// (`OptimizeToursRequest` messages) and outputs (`OptimizeToursResponse`
        /// messages) are read from and written to Cloud Storage in user-specified
        /// format. Like the `OptimizeTours` method, each `OptimizeToursRequest`
        /// contains a `ShipmentModel` and returns an `OptimizeToursResponse`
        /// containing `ShipmentRoute` fields, which are a set of routes to be
        /// performed by vehicles minimizing the overall cost.
        /// 
        /// The user can poll `operations.get` to check the status of the LRO:
        /// 
        /// If the LRO `done` field is false, then at least one request is still
        /// being processed. Other requests may have completed successfully and their
        /// results are available in Cloud Storage.
        /// 
        /// If the LRO's `done` field is true, then all requests have been processed.
        /// Any successfully processed requests will have their results available in
        /// Cloud Storage. Any requests that failed will not have their results
        /// available in Cloud Storage. If the LRO's `error` field is set, then it
        /// contains the error from one of the failed requests.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchOptimizeToursResponse, BatchOptimizeToursMetadata>> BatchOptimizeToursAsync(BatchOptimizeToursRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Optimizes vehicle tours for one or more `OptimizeToursRequest`
        /// messages as a batch.
        /// 
        /// This method is a Long Running Operation (LRO). The inputs for optimization
        /// (`OptimizeToursRequest` messages) and outputs (`OptimizeToursResponse`
        /// messages) are read from and written to Cloud Storage in user-specified
        /// format. Like the `OptimizeTours` method, each `OptimizeToursRequest`
        /// contains a `ShipmentModel` and returns an `OptimizeToursResponse`
        /// containing `ShipmentRoute` fields, which are a set of routes to be
        /// performed by vehicles minimizing the overall cost.
        /// 
        /// The user can poll `operations.get` to check the status of the LRO:
        /// 
        /// If the LRO `done` field is false, then at least one request is still
        /// being processed. Other requests may have completed successfully and their
        /// results are available in Cloud Storage.
        /// 
        /// If the LRO's `done` field is true, then all requests have been processed.
        /// Any successfully processed requests will have their results available in
        /// Cloud Storage. Any requests that failed will not have their results
        /// available in Cloud Storage. If the LRO's `error` field is set, then it
        /// contains the error from one of the failed requests.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchOptimizeToursResponse, BatchOptimizeToursMetadata>> BatchOptimizeToursAsync(BatchOptimizeToursRequest request, st::CancellationToken cancellationToken) =>
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
        public virtual lro::Operation<BatchOptimizeToursResponse, BatchOptimizeToursMetadata> PollOnceBatchOptimizeTours(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchOptimizeToursResponse, BatchOptimizeToursMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchOptimizeToursOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchOptimizeTours</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BatchOptimizeToursResponse, BatchOptimizeToursMetadata>> PollOnceBatchOptimizeToursAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchOptimizeToursResponse, BatchOptimizeToursMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchOptimizeToursOperationsClient, callSettings);
    }

    /// <summary>RouteOptimization client wrapper implementation, for convenient use.</summary>
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
    public sealed partial class RouteOptimizationClientImpl : RouteOptimizationClient
    {
        private readonly gaxgrpc::ApiCall<OptimizeToursRequest, OptimizeToursResponse> _callOptimizeTours;

        private readonly gaxgrpc::ApiCall<BatchOptimizeToursRequest, lro::Operation> _callBatchOptimizeTours;

        /// <summary>
        /// Constructs a client wrapper for the RouteOptimization service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="RouteOptimizationSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public RouteOptimizationClientImpl(RouteOptimization.RouteOptimizationClient grpcClient, RouteOptimizationSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            RouteOptimizationSettings effectiveSettings = settings ?? RouteOptimizationSettings.GetDefault();
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

        partial void OnConstruction(RouteOptimization.RouteOptimizationClient grpcClient, RouteOptimizationSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC RouteOptimization client</summary>
        public override RouteOptimization.RouteOptimizationClient GrpcClient { get; }

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
        /// messages) are read from and written to Cloud Storage in user-specified
        /// format. Like the `OptimizeTours` method, each `OptimizeToursRequest`
        /// contains a `ShipmentModel` and returns an `OptimizeToursResponse`
        /// containing `ShipmentRoute` fields, which are a set of routes to be
        /// performed by vehicles minimizing the overall cost.
        /// 
        /// The user can poll `operations.get` to check the status of the LRO:
        /// 
        /// If the LRO `done` field is false, then at least one request is still
        /// being processed. Other requests may have completed successfully and their
        /// results are available in Cloud Storage.
        /// 
        /// If the LRO's `done` field is true, then all requests have been processed.
        /// Any successfully processed requests will have their results available in
        /// Cloud Storage. Any requests that failed will not have their results
        /// available in Cloud Storage. If the LRO's `error` field is set, then it
        /// contains the error from one of the failed requests.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BatchOptimizeToursResponse, BatchOptimizeToursMetadata> BatchOptimizeTours(BatchOptimizeToursRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchOptimizeToursRequest(ref request, ref callSettings);
            return new lro::Operation<BatchOptimizeToursResponse, BatchOptimizeToursMetadata>(_callBatchOptimizeTours.Sync(request, callSettings), BatchOptimizeToursOperationsClient);
        }

        /// <summary>
        /// Optimizes vehicle tours for one or more `OptimizeToursRequest`
        /// messages as a batch.
        /// 
        /// This method is a Long Running Operation (LRO). The inputs for optimization
        /// (`OptimizeToursRequest` messages) and outputs (`OptimizeToursResponse`
        /// messages) are read from and written to Cloud Storage in user-specified
        /// format. Like the `OptimizeTours` method, each `OptimizeToursRequest`
        /// contains a `ShipmentModel` and returns an `OptimizeToursResponse`
        /// containing `ShipmentRoute` fields, which are a set of routes to be
        /// performed by vehicles minimizing the overall cost.
        /// 
        /// The user can poll `operations.get` to check the status of the LRO:
        /// 
        /// If the LRO `done` field is false, then at least one request is still
        /// being processed. Other requests may have completed successfully and their
        /// results are available in Cloud Storage.
        /// 
        /// If the LRO's `done` field is true, then all requests have been processed.
        /// Any successfully processed requests will have their results available in
        /// Cloud Storage. Any requests that failed will not have their results
        /// available in Cloud Storage. If the LRO's `error` field is set, then it
        /// contains the error from one of the failed requests.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BatchOptimizeToursResponse, BatchOptimizeToursMetadata>> BatchOptimizeToursAsync(BatchOptimizeToursRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchOptimizeToursRequest(ref request, ref callSettings);
            return new lro::Operation<BatchOptimizeToursResponse, BatchOptimizeToursMetadata>(await _callBatchOptimizeTours.Async(request, callSettings).ConfigureAwait(false), BatchOptimizeToursOperationsClient);
        }
    }

    public static partial class RouteOptimization
    {
        public partial class RouteOptimizationClient
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
