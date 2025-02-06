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
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Maps.Routing.V2
{
    /// <summary>Settings for <see cref="RoutesClient"/> instances.</summary>
    public sealed partial class RoutesSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="RoutesSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="RoutesSettings"/>.</returns>
        public static RoutesSettings GetDefault() => new RoutesSettings();

        /// <summary>Constructs a new <see cref="RoutesSettings"/> object with default settings.</summary>
        public RoutesSettings()
        {
        }

        private RoutesSettings(RoutesSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ComputeRoutesSettings = existing.ComputeRoutesSettings;
            ComputeRouteMatrixSettings = existing.ComputeRouteMatrixSettings;
            OnCopy(existing);
        }

        partial void OnCopy(RoutesSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>RoutesClient.ComputeRoutes</c>
        ///  and <c>RoutesClient.ComputeRoutesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ComputeRoutesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RoutesClient.ComputeRouteMatrix</c> and <c>RoutesClient.ComputeRouteMatrixAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ComputeRouteMatrixSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="RoutesSettings"/> object.</returns>
        public RoutesSettings Clone() => new RoutesSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="RoutesClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class RoutesClientBuilder : gaxgrpc::ClientBuilderBase<RoutesClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public RoutesSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public RoutesClientBuilder() : base(RoutesClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref RoutesClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<RoutesClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override RoutesClient Build()
        {
            RoutesClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<RoutesClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<RoutesClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private RoutesClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return RoutesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<RoutesClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return RoutesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => RoutesClient.ChannelPool;
    }

    /// <summary>Routes client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The Routes API.
    /// </remarks>
    public abstract partial class RoutesClient
    {
        /// <summary>
        /// The default endpoint for the Routes service, which is a host of "routes.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "routes.googleapis.com:443";

        /// <summary>The default Routes scopes.</summary>
        /// <remarks>The default Routes scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Routes.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="RoutesClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="RoutesClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="RoutesClient"/>.</returns>
        public static stt::Task<RoutesClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new RoutesClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="RoutesClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="RoutesClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="RoutesClient"/>.</returns>
        public static RoutesClient Create() => new RoutesClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="RoutesClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="RoutesSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="RoutesClient"/>.</returns>
        internal static RoutesClient Create(grpccore::CallInvoker callInvoker, RoutesSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Routes.RoutesClient grpcClient = new Routes.RoutesClient(callInvoker);
            return new RoutesClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Routes client</summary>
        public virtual Routes.RoutesClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the primary route along with optional alternate routes, given a set
        /// of terminal and intermediate waypoints.
        /// 
        /// **NOTE:** This method requires that you specify a response field mask in
        /// the input. You can provide the response field mask by using URL parameter
        /// `$fields` or `fields`, or by using an HTTP/gRPC header `X-Goog-FieldMask`
        /// (see the [available URL parameters and
        /// headers](https://cloud.google.com/apis/docs/system-parameters)). The value
        /// is a comma separated list of field paths. See detailed documentation about
        /// [how to construct the field
        /// paths](https://github.com/protocolbuffers/protobuf/blob/master/src/google/protobuf/field_mask.proto).
        /// 
        /// For example, in this method:
        /// 
        /// * Field mask of all available fields (for manual inspection):
        /// `X-Goog-FieldMask: *`
        /// * Field mask of Route-level duration, distance, and polyline (an example
        /// production setup):
        /// `X-Goog-FieldMask:
        /// routes.duration,routes.distanceMeters,routes.polyline.encodedPolyline`
        /// 
        /// Google discourage the use of the wildcard (`*`) response field mask, or
        /// specifying the field mask at the top level (`routes`), because:
        /// 
        /// * Selecting only the fields that you need helps our server save computation
        /// cycles, allowing us to return the result to you with a lower latency.
        /// * Selecting only the fields that you need
        /// in your production job ensures stable latency performance. We might add
        /// more response fields in the future, and those new fields might require
        /// extra computation time. If you select all fields, or if you select all
        /// fields at the top level, then you might experience performance degradation
        /// because any new field we add will be automatically included in the
        /// response.
        /// * Selecting only the fields that you need results in a smaller response
        /// size, and thus higher network throughput.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ComputeRoutesResponse ComputeRoutes(ComputeRoutesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the primary route along with optional alternate routes, given a set
        /// of terminal and intermediate waypoints.
        /// 
        /// **NOTE:** This method requires that you specify a response field mask in
        /// the input. You can provide the response field mask by using URL parameter
        /// `$fields` or `fields`, or by using an HTTP/gRPC header `X-Goog-FieldMask`
        /// (see the [available URL parameters and
        /// headers](https://cloud.google.com/apis/docs/system-parameters)). The value
        /// is a comma separated list of field paths. See detailed documentation about
        /// [how to construct the field
        /// paths](https://github.com/protocolbuffers/protobuf/blob/master/src/google/protobuf/field_mask.proto).
        /// 
        /// For example, in this method:
        /// 
        /// * Field mask of all available fields (for manual inspection):
        /// `X-Goog-FieldMask: *`
        /// * Field mask of Route-level duration, distance, and polyline (an example
        /// production setup):
        /// `X-Goog-FieldMask:
        /// routes.duration,routes.distanceMeters,routes.polyline.encodedPolyline`
        /// 
        /// Google discourage the use of the wildcard (`*`) response field mask, or
        /// specifying the field mask at the top level (`routes`), because:
        /// 
        /// * Selecting only the fields that you need helps our server save computation
        /// cycles, allowing us to return the result to you with a lower latency.
        /// * Selecting only the fields that you need
        /// in your production job ensures stable latency performance. We might add
        /// more response fields in the future, and those new fields might require
        /// extra computation time. If you select all fields, or if you select all
        /// fields at the top level, then you might experience performance degradation
        /// because any new field we add will be automatically included in the
        /// response.
        /// * Selecting only the fields that you need results in a smaller response
        /// size, and thus higher network throughput.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComputeRoutesResponse> ComputeRoutesAsync(ComputeRoutesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the primary route along with optional alternate routes, given a set
        /// of terminal and intermediate waypoints.
        /// 
        /// **NOTE:** This method requires that you specify a response field mask in
        /// the input. You can provide the response field mask by using URL parameter
        /// `$fields` or `fields`, or by using an HTTP/gRPC header `X-Goog-FieldMask`
        /// (see the [available URL parameters and
        /// headers](https://cloud.google.com/apis/docs/system-parameters)). The value
        /// is a comma separated list of field paths. See detailed documentation about
        /// [how to construct the field
        /// paths](https://github.com/protocolbuffers/protobuf/blob/master/src/google/protobuf/field_mask.proto).
        /// 
        /// For example, in this method:
        /// 
        /// * Field mask of all available fields (for manual inspection):
        /// `X-Goog-FieldMask: *`
        /// * Field mask of Route-level duration, distance, and polyline (an example
        /// production setup):
        /// `X-Goog-FieldMask:
        /// routes.duration,routes.distanceMeters,routes.polyline.encodedPolyline`
        /// 
        /// Google discourage the use of the wildcard (`*`) response field mask, or
        /// specifying the field mask at the top level (`routes`), because:
        /// 
        /// * Selecting only the fields that you need helps our server save computation
        /// cycles, allowing us to return the result to you with a lower latency.
        /// * Selecting only the fields that you need
        /// in your production job ensures stable latency performance. We might add
        /// more response fields in the future, and those new fields might require
        /// extra computation time. If you select all fields, or if you select all
        /// fields at the top level, then you might experience performance degradation
        /// because any new field we add will be automatically included in the
        /// response.
        /// * Selecting only the fields that you need results in a smaller response
        /// size, and thus higher network throughput.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComputeRoutesResponse> ComputeRoutesAsync(ComputeRoutesRequest request, st::CancellationToken cancellationToken) =>
            ComputeRoutesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Server streaming methods for
        /// <see cref="ComputeRouteMatrix(ComputeRouteMatrixRequest,gaxgrpc::CallSettings)"/>.
        /// </summary>
        public abstract partial class ComputeRouteMatrixStream : gaxgrpc::ServerStreamingBase<RouteMatrixElement>
        {
        }

        /// <summary>
        /// Takes in a list of origins and destinations and returns a stream containing
        /// route information for each combination of origin and destination.
        /// 
        /// **NOTE:** This method requires that you specify a response field mask in
        /// the input. You can provide the response field mask by using the URL
        /// parameter `$fields` or `fields`, or by using the HTTP/gRPC header
        /// `X-Goog-FieldMask` (see the [available URL parameters and
        /// headers](https://cloud.google.com/apis/docs/system-parameters)).
        /// The value is a comma separated list of field paths. See this detailed
        /// documentation about [how to construct the field
        /// paths](https://github.com/protocolbuffers/protobuf/blob/master/src/google/protobuf/field_mask.proto).
        /// 
        /// For example, in this method:
        /// 
        /// * Field mask of all available fields (for manual inspection):
        /// `X-Goog-FieldMask: *`
        /// * Field mask of route durations, distances, element status, condition, and
        /// element indices (an example production setup):
        /// `X-Goog-FieldMask:
        /// originIndex,destinationIndex,status,condition,distanceMeters,duration`
        /// 
        /// It is critical that you include `status` in your field mask as otherwise
        /// all messages will appear to be OK. Google discourages the use of the
        /// wildcard (`*`) response field mask, because:
        /// 
        /// * Selecting only the fields that you need helps our server save computation
        /// cycles, allowing us to return the result to you with a lower latency.
        /// * Selecting only the fields that you need in your production job ensures
        /// stable latency performance. We might add more response fields in the
        /// future, and those new fields might require extra computation time. If you
        /// select all fields, or if you select all fields at the top level, then you
        /// might experience performance degradation because any new field we add will
        /// be automatically included in the response.
        /// * Selecting only the fields that you need results in a smaller response
        /// size, and thus higher network throughput.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ComputeRouteMatrixStream ComputeRouteMatrix(ComputeRouteMatrixRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();
    }

    /// <summary>Routes client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The Routes API.
    /// </remarks>
    public sealed partial class RoutesClientImpl : RoutesClient
    {
        private readonly gaxgrpc::ApiCall<ComputeRoutesRequest, ComputeRoutesResponse> _callComputeRoutes;

        private readonly gaxgrpc::ApiServerStreamingCall<ComputeRouteMatrixRequest, RouteMatrixElement> _callComputeRouteMatrix;

        /// <summary>
        /// Constructs a client wrapper for the Routes service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="RoutesSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public RoutesClientImpl(Routes.RoutesClient grpcClient, RoutesSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            RoutesSettings effectiveSettings = settings ?? RoutesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callComputeRoutes = clientHelper.BuildApiCall<ComputeRoutesRequest, ComputeRoutesResponse>("ComputeRoutes", grpcClient.ComputeRoutesAsync, grpcClient.ComputeRoutes, effectiveSettings.ComputeRoutesSettings);
            Modify_ApiCall(ref _callComputeRoutes);
            Modify_ComputeRoutesApiCall(ref _callComputeRoutes);
            _callComputeRouteMatrix = clientHelper.BuildApiCall<ComputeRouteMatrixRequest, RouteMatrixElement>("ComputeRouteMatrix", grpcClient.ComputeRouteMatrix, effectiveSettings.ComputeRouteMatrixSettings);
            Modify_ApiCall(ref _callComputeRouteMatrix);
            Modify_ComputeRouteMatrixApiCall(ref _callComputeRouteMatrix);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiServerStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ComputeRoutesApiCall(ref gaxgrpc::ApiCall<ComputeRoutesRequest, ComputeRoutesResponse> call);

        partial void Modify_ComputeRouteMatrixApiCall(ref gaxgrpc::ApiServerStreamingCall<ComputeRouteMatrixRequest, RouteMatrixElement> call);

        partial void OnConstruction(Routes.RoutesClient grpcClient, RoutesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Routes client</summary>
        public override Routes.RoutesClient GrpcClient { get; }

        partial void Modify_ComputeRoutesRequest(ref ComputeRoutesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ComputeRouteMatrixRequest(ref ComputeRouteMatrixRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the primary route along with optional alternate routes, given a set
        /// of terminal and intermediate waypoints.
        /// 
        /// **NOTE:** This method requires that you specify a response field mask in
        /// the input. You can provide the response field mask by using URL parameter
        /// `$fields` or `fields`, or by using an HTTP/gRPC header `X-Goog-FieldMask`
        /// (see the [available URL parameters and
        /// headers](https://cloud.google.com/apis/docs/system-parameters)). The value
        /// is a comma separated list of field paths. See detailed documentation about
        /// [how to construct the field
        /// paths](https://github.com/protocolbuffers/protobuf/blob/master/src/google/protobuf/field_mask.proto).
        /// 
        /// For example, in this method:
        /// 
        /// * Field mask of all available fields (for manual inspection):
        /// `X-Goog-FieldMask: *`
        /// * Field mask of Route-level duration, distance, and polyline (an example
        /// production setup):
        /// `X-Goog-FieldMask:
        /// routes.duration,routes.distanceMeters,routes.polyline.encodedPolyline`
        /// 
        /// Google discourage the use of the wildcard (`*`) response field mask, or
        /// specifying the field mask at the top level (`routes`), because:
        /// 
        /// * Selecting only the fields that you need helps our server save computation
        /// cycles, allowing us to return the result to you with a lower latency.
        /// * Selecting only the fields that you need
        /// in your production job ensures stable latency performance. We might add
        /// more response fields in the future, and those new fields might require
        /// extra computation time. If you select all fields, or if you select all
        /// fields at the top level, then you might experience performance degradation
        /// because any new field we add will be automatically included in the
        /// response.
        /// * Selecting only the fields that you need results in a smaller response
        /// size, and thus higher network throughput.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ComputeRoutesResponse ComputeRoutes(ComputeRoutesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ComputeRoutesRequest(ref request, ref callSettings);
            return _callComputeRoutes.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the primary route along with optional alternate routes, given a set
        /// of terminal and intermediate waypoints.
        /// 
        /// **NOTE:** This method requires that you specify a response field mask in
        /// the input. You can provide the response field mask by using URL parameter
        /// `$fields` or `fields`, or by using an HTTP/gRPC header `X-Goog-FieldMask`
        /// (see the [available URL parameters and
        /// headers](https://cloud.google.com/apis/docs/system-parameters)). The value
        /// is a comma separated list of field paths. See detailed documentation about
        /// [how to construct the field
        /// paths](https://github.com/protocolbuffers/protobuf/blob/master/src/google/protobuf/field_mask.proto).
        /// 
        /// For example, in this method:
        /// 
        /// * Field mask of all available fields (for manual inspection):
        /// `X-Goog-FieldMask: *`
        /// * Field mask of Route-level duration, distance, and polyline (an example
        /// production setup):
        /// `X-Goog-FieldMask:
        /// routes.duration,routes.distanceMeters,routes.polyline.encodedPolyline`
        /// 
        /// Google discourage the use of the wildcard (`*`) response field mask, or
        /// specifying the field mask at the top level (`routes`), because:
        /// 
        /// * Selecting only the fields that you need helps our server save computation
        /// cycles, allowing us to return the result to you with a lower latency.
        /// * Selecting only the fields that you need
        /// in your production job ensures stable latency performance. We might add
        /// more response fields in the future, and those new fields might require
        /// extra computation time. If you select all fields, or if you select all
        /// fields at the top level, then you might experience performance degradation
        /// because any new field we add will be automatically included in the
        /// response.
        /// * Selecting only the fields that you need results in a smaller response
        /// size, and thus higher network throughput.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ComputeRoutesResponse> ComputeRoutesAsync(ComputeRoutesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ComputeRoutesRequest(ref request, ref callSettings);
            return _callComputeRoutes.Async(request, callSettings);
        }

        internal sealed partial class ComputeRouteMatrixStreamImpl : ComputeRouteMatrixStream
        {
            /// <summary>Construct the server streaming method for <c>ComputeRouteMatrix</c>.</summary>
            /// <param name="call">The underlying gRPC server streaming call.</param>
            public ComputeRouteMatrixStreamImpl(grpccore::AsyncServerStreamingCall<RouteMatrixElement> call) => GrpcCall = call;

            public override grpccore::AsyncServerStreamingCall<RouteMatrixElement> GrpcCall { get; }
        }

        /// <summary>
        /// Takes in a list of origins and destinations and returns a stream containing
        /// route information for each combination of origin and destination.
        /// 
        /// **NOTE:** This method requires that you specify a response field mask in
        /// the input. You can provide the response field mask by using the URL
        /// parameter `$fields` or `fields`, or by using the HTTP/gRPC header
        /// `X-Goog-FieldMask` (see the [available URL parameters and
        /// headers](https://cloud.google.com/apis/docs/system-parameters)).
        /// The value is a comma separated list of field paths. See this detailed
        /// documentation about [how to construct the field
        /// paths](https://github.com/protocolbuffers/protobuf/blob/master/src/google/protobuf/field_mask.proto).
        /// 
        /// For example, in this method:
        /// 
        /// * Field mask of all available fields (for manual inspection):
        /// `X-Goog-FieldMask: *`
        /// * Field mask of route durations, distances, element status, condition, and
        /// element indices (an example production setup):
        /// `X-Goog-FieldMask:
        /// originIndex,destinationIndex,status,condition,distanceMeters,duration`
        /// 
        /// It is critical that you include `status` in your field mask as otherwise
        /// all messages will appear to be OK. Google discourages the use of the
        /// wildcard (`*`) response field mask, because:
        /// 
        /// * Selecting only the fields that you need helps our server save computation
        /// cycles, allowing us to return the result to you with a lower latency.
        /// * Selecting only the fields that you need in your production job ensures
        /// stable latency performance. We might add more response fields in the
        /// future, and those new fields might require extra computation time. If you
        /// select all fields, or if you select all fields at the top level, then you
        /// might experience performance degradation because any new field we add will
        /// be automatically included in the response.
        /// * Selecting only the fields that you need results in a smaller response
        /// size, and thus higher network throughput.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public override RoutesClient.ComputeRouteMatrixStream ComputeRouteMatrix(ComputeRouteMatrixRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ComputeRouteMatrixRequest(ref request, ref callSettings);
            return new ComputeRouteMatrixStreamImpl(_callComputeRouteMatrix.Call(request, callSettings));
        }
    }
}
