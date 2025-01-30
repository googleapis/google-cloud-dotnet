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

namespace Google.Cloud.Location
{
    /// <summary>Settings for <see cref="LocationsClient"/> instances.</summary>
    public sealed partial class LocationsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="LocationsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="LocationsSettings"/>.</returns>
        public static LocationsSettings GetDefault() => new LocationsSettings();

        /// <summary>Constructs a new <see cref="LocationsSettings"/> object with default settings.</summary>
        public LocationsSettings()
        {
        }

        private LocationsSettings(LocationsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListLocationsSettings = existing.ListLocationsSettings;
            GetLocationSettings = existing.GetLocationSettings;
            OnCopy(existing);
        }

        partial void OnCopy(LocationsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LocationsClient.ListLocations</c> and <c>LocationsClient.ListLocationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListLocationsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>LocationsClient.GetLocation</c>
        ///  and <c>LocationsClient.GetLocationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetLocationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="LocationsSettings"/> object.</returns>
        public LocationsSettings Clone() => new LocationsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="LocationsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class LocationsClientBuilder : gaxgrpc::ClientBuilderBase<LocationsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public LocationsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public LocationsClientBuilder() : base(LocationsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref LocationsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<LocationsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override LocationsClient Build()
        {
            LocationsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<LocationsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<LocationsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private LocationsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return LocationsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<LocationsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return LocationsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => LocationsClient.ChannelPool;
    }

    /// <summary>Locations client wrapper, for convenient use.</summary>
    /// <remarks>
    /// An abstract interface that provides location-related information for
    /// a service. Service-specific metadata is provided through the
    /// [Location.metadata][google.cloud.location.Location.metadata] field.
    /// </remarks>
    public abstract partial class LocationsClient
    {
        /// <summary>
        /// The default endpoint for the Locations service, which is a host of "cloud.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloud.googleapis.com:443";

        /// <summary>The default Locations scopes.</summary>
        /// <remarks>
        /// The default Locations scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Locations.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="LocationsClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="LocationsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="LocationsClient"/>.</returns>
        public static stt::Task<LocationsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new LocationsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="LocationsClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="LocationsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="LocationsClient"/>.</returns>
        public static LocationsClient Create() => new LocationsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="LocationsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="LocationsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="LocationsClient"/>.</returns>
        internal static LocationsClient Create(grpccore::CallInvoker callInvoker, LocationsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Locations.LocationsClient grpcClient = new Locations.LocationsClient(callInvoker);
            return new LocationsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Locations client</summary>
        public virtual Locations.LocationsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists information about the supported locations for this service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Location"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLocationsResponse, Location> ListLocations(ListLocationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists information about the supported locations for this service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Location"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLocationsResponse, Location> ListLocationsAsync(ListLocationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Location GetLocation(GetLocationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Location> GetLocationAsync(GetLocationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Location> GetLocationAsync(GetLocationRequest request, st::CancellationToken cancellationToken) =>
            GetLocationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Locations client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// An abstract interface that provides location-related information for
    /// a service. Service-specific metadata is provided through the
    /// [Location.metadata][google.cloud.location.Location.metadata] field.
    /// </remarks>
    public sealed partial class LocationsClientImpl : LocationsClient
    {
        private readonly gaxgrpc::ApiCall<ListLocationsRequest, ListLocationsResponse> _callListLocations;

        private readonly gaxgrpc::ApiCall<GetLocationRequest, Location> _callGetLocation;

        /// <summary>
        /// Constructs a client wrapper for the Locations service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="LocationsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public LocationsClientImpl(Locations.LocationsClient grpcClient, LocationsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            LocationsSettings effectiveSettings = settings ?? LocationsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callListLocations = clientHelper.BuildApiCall<ListLocationsRequest, ListLocationsResponse>("ListLocations", grpcClient.ListLocationsAsync, grpcClient.ListLocations, effectiveSettings.ListLocationsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callListLocations);
            Modify_ListLocationsApiCall(ref _callListLocations);
            _callGetLocation = clientHelper.BuildApiCall<GetLocationRequest, Location>("GetLocation", grpcClient.GetLocationAsync, grpcClient.GetLocation, effectiveSettings.GetLocationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetLocation);
            Modify_GetLocationApiCall(ref _callGetLocation);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListLocationsApiCall(ref gaxgrpc::ApiCall<ListLocationsRequest, ListLocationsResponse> call);

        partial void Modify_GetLocationApiCall(ref gaxgrpc::ApiCall<GetLocationRequest, Location> call);

        partial void OnConstruction(Locations.LocationsClient grpcClient, LocationsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Locations client</summary>
        public override Locations.LocationsClient GrpcClient { get; }

        partial void Modify_ListLocationsRequest(ref ListLocationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetLocationRequest(ref GetLocationRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists information about the supported locations for this service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Location"/> resources.</returns>
        public override gax::PagedEnumerable<ListLocationsResponse, Location> ListLocations(ListLocationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLocationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListLocationsRequest, ListLocationsResponse, Location>(_callListLocations, request, callSettings);
        }

        /// <summary>
        /// Lists information about the supported locations for this service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Location"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListLocationsResponse, Location> ListLocationsAsync(ListLocationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLocationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListLocationsRequest, ListLocationsResponse, Location>(_callListLocations, request, callSettings);
        }

        /// <summary>
        /// Gets information about a location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Location GetLocation(GetLocationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLocationRequest(ref request, ref callSettings);
            return _callGetLocation.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets information about a location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Location> GetLocationAsync(GetLocationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLocationRequest(ref request, ref callSettings);
            return _callGetLocation.Async(request, callSettings);
        }
    }

    public partial class ListLocationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListLocationsResponse : gaxgrpc::IPageResponse<Location>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Location> GetEnumerator() => Locations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
