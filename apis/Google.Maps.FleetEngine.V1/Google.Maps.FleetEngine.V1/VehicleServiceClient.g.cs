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
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Maps.FleetEngine.V1
{
    /// <summary>Settings for <see cref="VehicleServiceClient"/> instances.</summary>
    public sealed partial class VehicleServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="VehicleServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="VehicleServiceSettings"/>.</returns>
        public static VehicleServiceSettings GetDefault() => new VehicleServiceSettings();

        /// <summary>Constructs a new <see cref="VehicleServiceSettings"/> object with default settings.</summary>
        public VehicleServiceSettings()
        {
        }

        private VehicleServiceSettings(VehicleServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateVehicleSettings = existing.CreateVehicleSettings;
            GetVehicleSettings = existing.GetVehicleSettings;
            DeleteVehicleSettings = existing.DeleteVehicleSettings;
            UpdateVehicleSettings = existing.UpdateVehicleSettings;
            UpdateVehicleAttributesSettings = existing.UpdateVehicleAttributesSettings;
            ListVehiclesSettings = existing.ListVehiclesSettings;
            SearchVehiclesSettings = existing.SearchVehiclesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(VehicleServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VehicleServiceClient.CreateVehicle</c> and <c>VehicleServiceClient.CreateVehicleAsync</c>.
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
        /// <item><description>Timeout: 15 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateVehicleSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(15000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VehicleServiceClient.GetVehicle</c> and <c>VehicleServiceClient.GetVehicleAsync</c>.
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
        /// <item><description>Timeout: 15 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetVehicleSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(15000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VehicleServiceClient.DeleteVehicle</c> and <c>VehicleServiceClient.DeleteVehicleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteVehicleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VehicleServiceClient.UpdateVehicle</c> and <c>VehicleServiceClient.UpdateVehicleAsync</c>.
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
        /// <item><description>Timeout: 15 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateVehicleSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(15000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VehicleServiceClient.UpdateVehicleAttributes</c> and <c>VehicleServiceClient.UpdateVehicleAttributesAsync</c>
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
        /// <item><description>Timeout: 15 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateVehicleAttributesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(15000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VehicleServiceClient.ListVehicles</c> and <c>VehicleServiceClient.ListVehiclesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListVehiclesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VehicleServiceClient.SearchVehicles</c> and <c>VehicleServiceClient.SearchVehiclesAsync</c>.
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
        /// <item><description>Timeout: 15 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchVehiclesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(15000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="VehicleServiceSettings"/> object.</returns>
        public VehicleServiceSettings Clone() => new VehicleServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="VehicleServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class VehicleServiceClientBuilder : gaxgrpc::ClientBuilderBase<VehicleServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public VehicleServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public VehicleServiceClientBuilder() : base(VehicleServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref VehicleServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<VehicleServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override VehicleServiceClient Build()
        {
            VehicleServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<VehicleServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<VehicleServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private VehicleServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return VehicleServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<VehicleServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return VehicleServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => VehicleServiceClient.ChannelPool;
    }

    /// <summary>VehicleService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Vehicle management service.
    /// </remarks>
    public abstract partial class VehicleServiceClient
    {
        /// <summary>
        /// The default endpoint for the VehicleService service, which is a host of "fleetengine.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "fleetengine.googleapis.com:443";

        /// <summary>The default VehicleService scopes.</summary>
        /// <remarks>
        /// The default VehicleService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(VehicleService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="VehicleServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="VehicleServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="VehicleServiceClient"/>.</returns>
        public static stt::Task<VehicleServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new VehicleServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="VehicleServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="VehicleServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="VehicleServiceClient"/>.</returns>
        public static VehicleServiceClient Create() => new VehicleServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="VehicleServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="VehicleServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="VehicleServiceClient"/>.</returns>
        internal static VehicleServiceClient Create(grpccore::CallInvoker callInvoker, VehicleServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            VehicleService.VehicleServiceClient grpcClient = new VehicleService.VehicleServiceClient(callInvoker);
            return new VehicleServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC VehicleService client</summary>
        public virtual VehicleService.VehicleServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Instantiates a new vehicle associated with an on-demand rideshare or
        /// deliveries provider. Each `Vehicle` must have a unique vehicle ID.
        /// 
        /// The following `Vehicle` fields are required when creating a `Vehicle`:
        /// 
        /// * `vehicleState`
        /// * `supportedTripTypes`
        /// * `maximumCapacity`
        /// * `vehicleType`
        /// 
        /// The following `Vehicle` fields are ignored when creating a `Vehicle`:
        /// 
        /// * `name`
        /// * `currentTrips`
        /// * `availableCapacity`
        /// * `current_route_segment`
        /// * `current_route_segment_end_point`
        /// * `current_route_segment_version`
        /// * `current_route_segment_traffic`
        /// * `route`
        /// * `waypoints`
        /// * `waypoints_version`
        /// * `remaining_distance_meters`
        /// * `remaining_time_seconds`
        /// * `eta_to_next_waypoint`
        /// * `navigation_status`
        /// 
        /// All other fields are optional and used if provided.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Vehicle CreateVehicle(CreateVehicleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Instantiates a new vehicle associated with an on-demand rideshare or
        /// deliveries provider. Each `Vehicle` must have a unique vehicle ID.
        /// 
        /// The following `Vehicle` fields are required when creating a `Vehicle`:
        /// 
        /// * `vehicleState`
        /// * `supportedTripTypes`
        /// * `maximumCapacity`
        /// * `vehicleType`
        /// 
        /// The following `Vehicle` fields are ignored when creating a `Vehicle`:
        /// 
        /// * `name`
        /// * `currentTrips`
        /// * `availableCapacity`
        /// * `current_route_segment`
        /// * `current_route_segment_end_point`
        /// * `current_route_segment_version`
        /// * `current_route_segment_traffic`
        /// * `route`
        /// * `waypoints`
        /// * `waypoints_version`
        /// * `remaining_distance_meters`
        /// * `remaining_time_seconds`
        /// * `eta_to_next_waypoint`
        /// * `navigation_status`
        /// 
        /// All other fields are optional and used if provided.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Vehicle> CreateVehicleAsync(CreateVehicleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Instantiates a new vehicle associated with an on-demand rideshare or
        /// deliveries provider. Each `Vehicle` must have a unique vehicle ID.
        /// 
        /// The following `Vehicle` fields are required when creating a `Vehicle`:
        /// 
        /// * `vehicleState`
        /// * `supportedTripTypes`
        /// * `maximumCapacity`
        /// * `vehicleType`
        /// 
        /// The following `Vehicle` fields are ignored when creating a `Vehicle`:
        /// 
        /// * `name`
        /// * `currentTrips`
        /// * `availableCapacity`
        /// * `current_route_segment`
        /// * `current_route_segment_end_point`
        /// * `current_route_segment_version`
        /// * `current_route_segment_traffic`
        /// * `route`
        /// * `waypoints`
        /// * `waypoints_version`
        /// * `remaining_distance_meters`
        /// * `remaining_time_seconds`
        /// * `eta_to_next_waypoint`
        /// * `navigation_status`
        /// 
        /// All other fields are optional and used if provided.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Vehicle> CreateVehicleAsync(CreateVehicleRequest request, st::CancellationToken cancellationToken) =>
            CreateVehicleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a vehicle from the Fleet Engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Vehicle GetVehicle(GetVehicleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a vehicle from the Fleet Engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Vehicle> GetVehicleAsync(GetVehicleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a vehicle from the Fleet Engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Vehicle> GetVehicleAsync(GetVehicleRequest request, st::CancellationToken cancellationToken) =>
            GetVehicleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Vehicle from the Fleet Engine.
        /// 
        /// Returns FAILED_PRECONDITION if the Vehicle has active Trips.
        /// assigned to it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteVehicle(DeleteVehicleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Vehicle from the Fleet Engine.
        /// 
        /// Returns FAILED_PRECONDITION if the Vehicle has active Trips.
        /// assigned to it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteVehicleAsync(DeleteVehicleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Vehicle from the Fleet Engine.
        /// 
        /// Returns FAILED_PRECONDITION if the Vehicle has active Trips.
        /// assigned to it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteVehicleAsync(DeleteVehicleRequest request, st::CancellationToken cancellationToken) =>
            DeleteVehicleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Vehicle from the Fleet Engine.
        /// 
        /// Returns FAILED_PRECONDITION if the Vehicle has active Trips.
        /// assigned to it.
        /// </summary>
        /// <param name="name">
        /// Required. Must be in the format
        /// `providers/{provider}/vehicles/{vehicle}`.
        /// The {provider} must be the Project ID (for example, `sample-cloud-project`)
        /// of the Google Cloud Project of which the service account making
        /// this call is a member.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteVehicle(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteVehicle(new DeleteVehicleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Vehicle from the Fleet Engine.
        /// 
        /// Returns FAILED_PRECONDITION if the Vehicle has active Trips.
        /// assigned to it.
        /// </summary>
        /// <param name="name">
        /// Required. Must be in the format
        /// `providers/{provider}/vehicles/{vehicle}`.
        /// The {provider} must be the Project ID (for example, `sample-cloud-project`)
        /// of the Google Cloud Project of which the service account making
        /// this call is a member.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteVehicleAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteVehicleAsync(new DeleteVehicleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Vehicle from the Fleet Engine.
        /// 
        /// Returns FAILED_PRECONDITION if the Vehicle has active Trips.
        /// assigned to it.
        /// </summary>
        /// <param name="name">
        /// Required. Must be in the format
        /// `providers/{provider}/vehicles/{vehicle}`.
        /// The {provider} must be the Project ID (for example, `sample-cloud-project`)
        /// of the Google Cloud Project of which the service account making
        /// this call is a member.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteVehicleAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteVehicleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Vehicle from the Fleet Engine.
        /// 
        /// Returns FAILED_PRECONDITION if the Vehicle has active Trips.
        /// assigned to it.
        /// </summary>
        /// <param name="name">
        /// Required. Must be in the format
        /// `providers/{provider}/vehicles/{vehicle}`.
        /// The {provider} must be the Project ID (for example, `sample-cloud-project`)
        /// of the Google Cloud Project of which the service account making
        /// this call is a member.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteVehicle(VehicleName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteVehicle(new DeleteVehicleRequest
            {
                VehicleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Vehicle from the Fleet Engine.
        /// 
        /// Returns FAILED_PRECONDITION if the Vehicle has active Trips.
        /// assigned to it.
        /// </summary>
        /// <param name="name">
        /// Required. Must be in the format
        /// `providers/{provider}/vehicles/{vehicle}`.
        /// The {provider} must be the Project ID (for example, `sample-cloud-project`)
        /// of the Google Cloud Project of which the service account making
        /// this call is a member.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteVehicleAsync(VehicleName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteVehicleAsync(new DeleteVehicleRequest
            {
                VehicleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Vehicle from the Fleet Engine.
        /// 
        /// Returns FAILED_PRECONDITION if the Vehicle has active Trips.
        /// assigned to it.
        /// </summary>
        /// <param name="name">
        /// Required. Must be in the format
        /// `providers/{provider}/vehicles/{vehicle}`.
        /// The {provider} must be the Project ID (for example, `sample-cloud-project`)
        /// of the Google Cloud Project of which the service account making
        /// this call is a member.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteVehicleAsync(VehicleName name, st::CancellationToken cancellationToken) =>
            DeleteVehicleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Writes updated vehicle data to the Fleet Engine.
        /// 
        /// When updating a `Vehicle`, the following fields cannot be updated since
        /// they are managed by the server:
        /// 
        /// * `currentTrips`
        /// * `availableCapacity`
        /// * `current_route_segment_version`
        /// * `waypoints_version`
        /// 
        /// The vehicle `name` also cannot be updated.
        /// 
        /// If the `attributes` field is updated, **all** the vehicle's attributes are
        /// replaced with the attributes provided in the request. If you want to update
        /// only some attributes, see the `UpdateVehicleAttributes` method. Likewise,
        /// the `waypoints` field can be updated, but must contain all the waypoints
        /// currently on the vehicle, and no other waypoints.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Vehicle UpdateVehicle(UpdateVehicleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Writes updated vehicle data to the Fleet Engine.
        /// 
        /// When updating a `Vehicle`, the following fields cannot be updated since
        /// they are managed by the server:
        /// 
        /// * `currentTrips`
        /// * `availableCapacity`
        /// * `current_route_segment_version`
        /// * `waypoints_version`
        /// 
        /// The vehicle `name` also cannot be updated.
        /// 
        /// If the `attributes` field is updated, **all** the vehicle's attributes are
        /// replaced with the attributes provided in the request. If you want to update
        /// only some attributes, see the `UpdateVehicleAttributes` method. Likewise,
        /// the `waypoints` field can be updated, but must contain all the waypoints
        /// currently on the vehicle, and no other waypoints.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Vehicle> UpdateVehicleAsync(UpdateVehicleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Writes updated vehicle data to the Fleet Engine.
        /// 
        /// When updating a `Vehicle`, the following fields cannot be updated since
        /// they are managed by the server:
        /// 
        /// * `currentTrips`
        /// * `availableCapacity`
        /// * `current_route_segment_version`
        /// * `waypoints_version`
        /// 
        /// The vehicle `name` also cannot be updated.
        /// 
        /// If the `attributes` field is updated, **all** the vehicle's attributes are
        /// replaced with the attributes provided in the request. If you want to update
        /// only some attributes, see the `UpdateVehicleAttributes` method. Likewise,
        /// the `waypoints` field can be updated, but must contain all the waypoints
        /// currently on the vehicle, and no other waypoints.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Vehicle> UpdateVehicleAsync(UpdateVehicleRequest request, st::CancellationToken cancellationToken) =>
            UpdateVehicleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Partially updates a vehicle's attributes.
        /// Only the attributes mentioned in the request will be updated, other
        /// attributes will NOT be altered. Note: this is different in `UpdateVehicle`,
        /// where the whole `attributes` field will be replaced by the one in
        /// `UpdateVehicleRequest`, attributes not in the request would be removed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UpdateVehicleAttributesResponse UpdateVehicleAttributes(UpdateVehicleAttributesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Partially updates a vehicle's attributes.
        /// Only the attributes mentioned in the request will be updated, other
        /// attributes will NOT be altered. Note: this is different in `UpdateVehicle`,
        /// where the whole `attributes` field will be replaced by the one in
        /// `UpdateVehicleRequest`, attributes not in the request would be removed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UpdateVehicleAttributesResponse> UpdateVehicleAttributesAsync(UpdateVehicleAttributesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Partially updates a vehicle's attributes.
        /// Only the attributes mentioned in the request will be updated, other
        /// attributes will NOT be altered. Note: this is different in `UpdateVehicle`,
        /// where the whole `attributes` field will be replaced by the one in
        /// `UpdateVehicleRequest`, attributes not in the request would be removed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UpdateVehicleAttributesResponse> UpdateVehicleAttributesAsync(UpdateVehicleAttributesRequest request, st::CancellationToken cancellationToken) =>
            UpdateVehicleAttributesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a paginated list of vehicles associated with
        /// a provider that match the request options.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Vehicle"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVehiclesResponse, Vehicle> ListVehicles(ListVehiclesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a paginated list of vehicles associated with
        /// a provider that match the request options.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Vehicle"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVehiclesResponse, Vehicle> ListVehiclesAsync(ListVehiclesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of vehicles that match the request options.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SearchVehiclesResponse SearchVehicles(SearchVehiclesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of vehicles that match the request options.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchVehiclesResponse> SearchVehiclesAsync(SearchVehiclesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of vehicles that match the request options.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchVehiclesResponse> SearchVehiclesAsync(SearchVehiclesRequest request, st::CancellationToken cancellationToken) =>
            SearchVehiclesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>VehicleService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Vehicle management service.
    /// </remarks>
    public sealed partial class VehicleServiceClientImpl : VehicleServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateVehicleRequest, Vehicle> _callCreateVehicle;

        private readonly gaxgrpc::ApiCall<GetVehicleRequest, Vehicle> _callGetVehicle;

        private readonly gaxgrpc::ApiCall<DeleteVehicleRequest, wkt::Empty> _callDeleteVehicle;

        private readonly gaxgrpc::ApiCall<UpdateVehicleRequest, Vehicle> _callUpdateVehicle;

        private readonly gaxgrpc::ApiCall<UpdateVehicleAttributesRequest, UpdateVehicleAttributesResponse> _callUpdateVehicleAttributes;

        private readonly gaxgrpc::ApiCall<ListVehiclesRequest, ListVehiclesResponse> _callListVehicles;

        private readonly gaxgrpc::ApiCall<SearchVehiclesRequest, SearchVehiclesResponse> _callSearchVehicles;

        /// <summary>
        /// Constructs a client wrapper for the VehicleService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="VehicleServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public VehicleServiceClientImpl(VehicleService.VehicleServiceClient grpcClient, VehicleServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            VehicleServiceSettings effectiveSettings = settings ?? VehicleServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callCreateVehicle = clientHelper.BuildApiCall<CreateVehicleRequest, Vehicle>("CreateVehicle", grpcClient.CreateVehicleAsync, grpcClient.CreateVehicle, effectiveSettings.CreateVehicleSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<CreateVehicleRequest>().WithExtractedParameter("provider_id", "^(providers/[^/]+)/?$", request => request.Parent));
            Modify_ApiCall(ref _callCreateVehicle);
            Modify_CreateVehicleApiCall(ref _callCreateVehicle);
            _callGetVehicle = clientHelper.BuildApiCall<GetVehicleRequest, Vehicle>("GetVehicle", grpcClient.GetVehicleAsync, grpcClient.GetVehicle, effectiveSettings.GetVehicleSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<GetVehicleRequest>().WithExtractedParameter("provider_id", "^(providers/[^/]+)/?$", request => request.Name));
            Modify_ApiCall(ref _callGetVehicle);
            Modify_GetVehicleApiCall(ref _callGetVehicle);
            _callDeleteVehicle = clientHelper.BuildApiCall<DeleteVehicleRequest, wkt::Empty>("DeleteVehicle", grpcClient.DeleteVehicleAsync, grpcClient.DeleteVehicle, effectiveSettings.DeleteVehicleSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<DeleteVehicleRequest>().WithExtractedParameter("provider_id", "^(providers/[^/]+)/?$", request => request.Name));
            Modify_ApiCall(ref _callDeleteVehicle);
            Modify_DeleteVehicleApiCall(ref _callDeleteVehicle);
            _callUpdateVehicle = clientHelper.BuildApiCall<UpdateVehicleRequest, Vehicle>("UpdateVehicle", grpcClient.UpdateVehicleAsync, grpcClient.UpdateVehicle, effectiveSettings.UpdateVehicleSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<UpdateVehicleRequest>().WithExtractedParameter("provider_id", "^(providers/[^/]+)/?$", request => request.Name));
            Modify_ApiCall(ref _callUpdateVehicle);
            Modify_UpdateVehicleApiCall(ref _callUpdateVehicle);
            _callUpdateVehicleAttributes = clientHelper.BuildApiCall<UpdateVehicleAttributesRequest, UpdateVehicleAttributesResponse>("UpdateVehicleAttributes", grpcClient.UpdateVehicleAttributesAsync, grpcClient.UpdateVehicleAttributes, effectiveSettings.UpdateVehicleAttributesSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<UpdateVehicleAttributesRequest>().WithExtractedParameter("provider_id", "^(providers/[^/]+)/?$", request => request.Name));
            Modify_ApiCall(ref _callUpdateVehicleAttributes);
            Modify_UpdateVehicleAttributesApiCall(ref _callUpdateVehicleAttributes);
            _callListVehicles = clientHelper.BuildApiCall<ListVehiclesRequest, ListVehiclesResponse>("ListVehicles", grpcClient.ListVehiclesAsync, grpcClient.ListVehicles, effectiveSettings.ListVehiclesSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<ListVehiclesRequest>().WithExtractedParameter("provider_id", "^(providers/[^/]+)/?$", request => request.Parent));
            Modify_ApiCall(ref _callListVehicles);
            Modify_ListVehiclesApiCall(ref _callListVehicles);
            _callSearchVehicles = clientHelper.BuildApiCall<SearchVehiclesRequest, SearchVehiclesResponse>("SearchVehicles", grpcClient.SearchVehiclesAsync, grpcClient.SearchVehicles, effectiveSettings.SearchVehiclesSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<SearchVehiclesRequest>().WithExtractedParameter("provider_id", "^(providers/[^/]+)/?$", request => request.Parent));
            Modify_ApiCall(ref _callSearchVehicles);
            Modify_SearchVehiclesApiCall(ref _callSearchVehicles);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateVehicleApiCall(ref gaxgrpc::ApiCall<CreateVehicleRequest, Vehicle> call);

        partial void Modify_GetVehicleApiCall(ref gaxgrpc::ApiCall<GetVehicleRequest, Vehicle> call);

        partial void Modify_DeleteVehicleApiCall(ref gaxgrpc::ApiCall<DeleteVehicleRequest, wkt::Empty> call);

        partial void Modify_UpdateVehicleApiCall(ref gaxgrpc::ApiCall<UpdateVehicleRequest, Vehicle> call);

        partial void Modify_UpdateVehicleAttributesApiCall(ref gaxgrpc::ApiCall<UpdateVehicleAttributesRequest, UpdateVehicleAttributesResponse> call);

        partial void Modify_ListVehiclesApiCall(ref gaxgrpc::ApiCall<ListVehiclesRequest, ListVehiclesResponse> call);

        partial void Modify_SearchVehiclesApiCall(ref gaxgrpc::ApiCall<SearchVehiclesRequest, SearchVehiclesResponse> call);

        partial void OnConstruction(VehicleService.VehicleServiceClient grpcClient, VehicleServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC VehicleService client</summary>
        public override VehicleService.VehicleServiceClient GrpcClient { get; }

        partial void Modify_CreateVehicleRequest(ref CreateVehicleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetVehicleRequest(ref GetVehicleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteVehicleRequest(ref DeleteVehicleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateVehicleRequest(ref UpdateVehicleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateVehicleAttributesRequest(ref UpdateVehicleAttributesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListVehiclesRequest(ref ListVehiclesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchVehiclesRequest(ref SearchVehiclesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Instantiates a new vehicle associated with an on-demand rideshare or
        /// deliveries provider. Each `Vehicle` must have a unique vehicle ID.
        /// 
        /// The following `Vehicle` fields are required when creating a `Vehicle`:
        /// 
        /// * `vehicleState`
        /// * `supportedTripTypes`
        /// * `maximumCapacity`
        /// * `vehicleType`
        /// 
        /// The following `Vehicle` fields are ignored when creating a `Vehicle`:
        /// 
        /// * `name`
        /// * `currentTrips`
        /// * `availableCapacity`
        /// * `current_route_segment`
        /// * `current_route_segment_end_point`
        /// * `current_route_segment_version`
        /// * `current_route_segment_traffic`
        /// * `route`
        /// * `waypoints`
        /// * `waypoints_version`
        /// * `remaining_distance_meters`
        /// * `remaining_time_seconds`
        /// * `eta_to_next_waypoint`
        /// * `navigation_status`
        /// 
        /// All other fields are optional and used if provided.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Vehicle CreateVehicle(CreateVehicleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateVehicleRequest(ref request, ref callSettings);
            return _callCreateVehicle.Sync(request, callSettings);
        }

        /// <summary>
        /// Instantiates a new vehicle associated with an on-demand rideshare or
        /// deliveries provider. Each `Vehicle` must have a unique vehicle ID.
        /// 
        /// The following `Vehicle` fields are required when creating a `Vehicle`:
        /// 
        /// * `vehicleState`
        /// * `supportedTripTypes`
        /// * `maximumCapacity`
        /// * `vehicleType`
        /// 
        /// The following `Vehicle` fields are ignored when creating a `Vehicle`:
        /// 
        /// * `name`
        /// * `currentTrips`
        /// * `availableCapacity`
        /// * `current_route_segment`
        /// * `current_route_segment_end_point`
        /// * `current_route_segment_version`
        /// * `current_route_segment_traffic`
        /// * `route`
        /// * `waypoints`
        /// * `waypoints_version`
        /// * `remaining_distance_meters`
        /// * `remaining_time_seconds`
        /// * `eta_to_next_waypoint`
        /// * `navigation_status`
        /// 
        /// All other fields are optional and used if provided.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Vehicle> CreateVehicleAsync(CreateVehicleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateVehicleRequest(ref request, ref callSettings);
            return _callCreateVehicle.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a vehicle from the Fleet Engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Vehicle GetVehicle(GetVehicleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVehicleRequest(ref request, ref callSettings);
            return _callGetVehicle.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a vehicle from the Fleet Engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Vehicle> GetVehicleAsync(GetVehicleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVehicleRequest(ref request, ref callSettings);
            return _callGetVehicle.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a Vehicle from the Fleet Engine.
        /// 
        /// Returns FAILED_PRECONDITION if the Vehicle has active Trips.
        /// assigned to it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteVehicle(DeleteVehicleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteVehicleRequest(ref request, ref callSettings);
            _callDeleteVehicle.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a Vehicle from the Fleet Engine.
        /// 
        /// Returns FAILED_PRECONDITION if the Vehicle has active Trips.
        /// assigned to it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteVehicleAsync(DeleteVehicleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteVehicleRequest(ref request, ref callSettings);
            return _callDeleteVehicle.Async(request, callSettings);
        }

        /// <summary>
        /// Writes updated vehicle data to the Fleet Engine.
        /// 
        /// When updating a `Vehicle`, the following fields cannot be updated since
        /// they are managed by the server:
        /// 
        /// * `currentTrips`
        /// * `availableCapacity`
        /// * `current_route_segment_version`
        /// * `waypoints_version`
        /// 
        /// The vehicle `name` also cannot be updated.
        /// 
        /// If the `attributes` field is updated, **all** the vehicle's attributes are
        /// replaced with the attributes provided in the request. If you want to update
        /// only some attributes, see the `UpdateVehicleAttributes` method. Likewise,
        /// the `waypoints` field can be updated, but must contain all the waypoints
        /// currently on the vehicle, and no other waypoints.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Vehicle UpdateVehicle(UpdateVehicleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateVehicleRequest(ref request, ref callSettings);
            return _callUpdateVehicle.Sync(request, callSettings);
        }

        /// <summary>
        /// Writes updated vehicle data to the Fleet Engine.
        /// 
        /// When updating a `Vehicle`, the following fields cannot be updated since
        /// they are managed by the server:
        /// 
        /// * `currentTrips`
        /// * `availableCapacity`
        /// * `current_route_segment_version`
        /// * `waypoints_version`
        /// 
        /// The vehicle `name` also cannot be updated.
        /// 
        /// If the `attributes` field is updated, **all** the vehicle's attributes are
        /// replaced with the attributes provided in the request. If you want to update
        /// only some attributes, see the `UpdateVehicleAttributes` method. Likewise,
        /// the `waypoints` field can be updated, but must contain all the waypoints
        /// currently on the vehicle, and no other waypoints.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Vehicle> UpdateVehicleAsync(UpdateVehicleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateVehicleRequest(ref request, ref callSettings);
            return _callUpdateVehicle.Async(request, callSettings);
        }

        /// <summary>
        /// Partially updates a vehicle's attributes.
        /// Only the attributes mentioned in the request will be updated, other
        /// attributes will NOT be altered. Note: this is different in `UpdateVehicle`,
        /// where the whole `attributes` field will be replaced by the one in
        /// `UpdateVehicleRequest`, attributes not in the request would be removed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UpdateVehicleAttributesResponse UpdateVehicleAttributes(UpdateVehicleAttributesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateVehicleAttributesRequest(ref request, ref callSettings);
            return _callUpdateVehicleAttributes.Sync(request, callSettings);
        }

        /// <summary>
        /// Partially updates a vehicle's attributes.
        /// Only the attributes mentioned in the request will be updated, other
        /// attributes will NOT be altered. Note: this is different in `UpdateVehicle`,
        /// where the whole `attributes` field will be replaced by the one in
        /// `UpdateVehicleRequest`, attributes not in the request would be removed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UpdateVehicleAttributesResponse> UpdateVehicleAttributesAsync(UpdateVehicleAttributesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateVehicleAttributesRequest(ref request, ref callSettings);
            return _callUpdateVehicleAttributes.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a paginated list of vehicles associated with
        /// a provider that match the request options.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Vehicle"/> resources.</returns>
        public override gax::PagedEnumerable<ListVehiclesResponse, Vehicle> ListVehicles(ListVehiclesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVehiclesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListVehiclesRequest, ListVehiclesResponse, Vehicle>(_callListVehicles, request, callSettings);
        }

        /// <summary>
        /// Returns a paginated list of vehicles associated with
        /// a provider that match the request options.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Vehicle"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListVehiclesResponse, Vehicle> ListVehiclesAsync(ListVehiclesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVehiclesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListVehiclesRequest, ListVehiclesResponse, Vehicle>(_callListVehicles, request, callSettings);
        }

        /// <summary>
        /// Returns a list of vehicles that match the request options.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SearchVehiclesResponse SearchVehicles(SearchVehiclesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchVehiclesRequest(ref request, ref callSettings);
            return _callSearchVehicles.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a list of vehicles that match the request options.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SearchVehiclesResponse> SearchVehiclesAsync(SearchVehiclesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchVehiclesRequest(ref request, ref callSettings);
            return _callSearchVehicles.Async(request, callSettings);
        }
    }

    public partial class ListVehiclesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListVehiclesResponse : gaxgrpc::IPageResponse<Vehicle>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Vehicle> GetEnumerator() => Vehicles.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
