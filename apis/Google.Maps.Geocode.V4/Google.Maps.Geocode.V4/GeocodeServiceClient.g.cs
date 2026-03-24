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

namespace Google.Maps.Geocode.V4
{
    /// <summary>Settings for <see cref="GeocodeServiceClient"/> instances.</summary>
    public sealed partial class GeocodeServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="GeocodeServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="GeocodeServiceSettings"/>.</returns>
        public static GeocodeServiceSettings GetDefault() => new GeocodeServiceSettings();

        /// <summary>Constructs a new <see cref="GeocodeServiceSettings"/> object with default settings.</summary>
        public GeocodeServiceSettings()
        {
        }

        private GeocodeServiceSettings(GeocodeServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GeocodeAddressSettings = existing.GeocodeAddressSettings;
            GeocodeLocationSettings = existing.GeocodeLocationSettings;
            GeocodePlaceSettings = existing.GeocodePlaceSettings;
            OnCopy(existing);
        }

        partial void OnCopy(GeocodeServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GeocodeServiceClient.GeocodeAddress</c> and <c>GeocodeServiceClient.GeocodeAddressAsync</c>.
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
        public gaxgrpc::CallSettings GeocodeAddressSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GeocodeServiceClient.GeocodeLocation</c> and <c>GeocodeServiceClient.GeocodeLocationAsync</c>.
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
        public gaxgrpc::CallSettings GeocodeLocationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GeocodeServiceClient.GeocodePlace</c> and <c>GeocodeServiceClient.GeocodePlaceAsync</c>.
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
        public gaxgrpc::CallSettings GeocodePlaceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="GeocodeServiceSettings"/> object.</returns>
        public GeocodeServiceSettings Clone() => new GeocodeServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="GeocodeServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class GeocodeServiceClientBuilder : gaxgrpc::ClientBuilderBase<GeocodeServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public GeocodeServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public GeocodeServiceClientBuilder() : base(GeocodeServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref GeocodeServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<GeocodeServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override GeocodeServiceClient Build()
        {
            GeocodeServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<GeocodeServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<GeocodeServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private GeocodeServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return GeocodeServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<GeocodeServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return GeocodeServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => GeocodeServiceClient.ChannelPool;
    }

    /// <summary>GeocodeService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service for performing geocoding.
    /// </remarks>
    public abstract partial class GeocodeServiceClient
    {
        /// <summary>
        /// The default endpoint for the GeocodeService service, which is a host of "geocoding-backend.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "geocoding-backend.googleapis.com:443";

        /// <summary>The default GeocodeService scopes.</summary>
        /// <remarks>
        /// The default GeocodeService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/maps-platform.geocode</description></item>
        /// <item><description>https://www.googleapis.com/auth/maps-platform.geocode.address</description></item>
        /// <item><description>https://www.googleapis.com/auth/maps-platform.geocode.location</description></item>
        /// <item><description>https://www.googleapis.com/auth/maps-platform.geocode.place</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/maps-platform.geocode",
            "https://www.googleapis.com/auth/maps-platform.geocode.address",
            "https://www.googleapis.com/auth/maps-platform.geocode.location",
            "https://www.googleapis.com/auth/maps-platform.geocode.place",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(GeocodeService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="GeocodeServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="GeocodeServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="GeocodeServiceClient"/>.</returns>
        public static stt::Task<GeocodeServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new GeocodeServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="GeocodeServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="GeocodeServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="GeocodeServiceClient"/>.</returns>
        public static GeocodeServiceClient Create() => new GeocodeServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="GeocodeServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="GeocodeServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="GeocodeServiceClient"/>.</returns>
        internal static GeocodeServiceClient Create(grpccore::CallInvoker callInvoker, GeocodeServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            GeocodeService.GeocodeServiceClient grpcClient = new GeocodeService.GeocodeServiceClient(callInvoker);
            return new GeocodeServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC GeocodeService client</summary>
        public virtual GeocodeService.GeocodeServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// This method performs an address geocode, which maps an address to a
        /// LatLng. It also provides structured information about the address.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GeocodeAddressResponse GeocodeAddress(GeocodeAddressRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// This method performs an address geocode, which maps an address to a
        /// LatLng. It also provides structured information about the address.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GeocodeAddressResponse> GeocodeAddressAsync(GeocodeAddressRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// This method performs an address geocode, which maps an address to a
        /// LatLng. It also provides structured information about the address.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GeocodeAddressResponse> GeocodeAddressAsync(GeocodeAddressRequest request, st::CancellationToken cancellationToken) =>
            GeocodeAddressAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// This method performs a location geocode, which maps a LatLng to an
        /// address. It also provides structured information about the address.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GeocodeLocationResponse GeocodeLocation(GeocodeLocationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// This method performs a location geocode, which maps a LatLng to an
        /// address. It also provides structured information about the address.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GeocodeLocationResponse> GeocodeLocationAsync(GeocodeLocationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// This method performs a location geocode, which maps a LatLng to an
        /// address. It also provides structured information about the address.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GeocodeLocationResponse> GeocodeLocationAsync(GeocodeLocationRequest request, st::CancellationToken cancellationToken) =>
            GeocodeLocationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// This method performs a geocode lookup using a place ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GeocodeResult GeocodePlace(GeocodePlaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// This method performs a geocode lookup using a place ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GeocodeResult> GeocodePlaceAsync(GeocodePlaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// This method performs a geocode lookup using a place ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GeocodeResult> GeocodePlaceAsync(GeocodePlaceRequest request, st::CancellationToken cancellationToken) =>
            GeocodePlaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>GeocodeService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service for performing geocoding.
    /// </remarks>
    public sealed partial class GeocodeServiceClientImpl : GeocodeServiceClient
    {
        private readonly gaxgrpc::ApiCall<GeocodeAddressRequest, GeocodeAddressResponse> _callGeocodeAddress;

        private readonly gaxgrpc::ApiCall<GeocodeLocationRequest, GeocodeLocationResponse> _callGeocodeLocation;

        private readonly gaxgrpc::ApiCall<GeocodePlaceRequest, GeocodeResult> _callGeocodePlace;

        /// <summary>
        /// Constructs a client wrapper for the GeocodeService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="GeocodeServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public GeocodeServiceClientImpl(GeocodeService.GeocodeServiceClient grpcClient, GeocodeServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            GeocodeServiceSettings effectiveSettings = settings ?? GeocodeServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGeocodeAddress = clientHelper.BuildApiCall<GeocodeAddressRequest, GeocodeAddressResponse>("GeocodeAddress", grpcClient.GeocodeAddressAsync, grpcClient.GeocodeAddress, effectiveSettings.GeocodeAddressSettings);
            Modify_ApiCall(ref _callGeocodeAddress);
            Modify_GeocodeAddressApiCall(ref _callGeocodeAddress);
            _callGeocodeLocation = clientHelper.BuildApiCall<GeocodeLocationRequest, GeocodeLocationResponse>("GeocodeLocation", grpcClient.GeocodeLocationAsync, grpcClient.GeocodeLocation, effectiveSettings.GeocodeLocationSettings);
            Modify_ApiCall(ref _callGeocodeLocation);
            Modify_GeocodeLocationApiCall(ref _callGeocodeLocation);
            _callGeocodePlace = clientHelper.BuildApiCall<GeocodePlaceRequest, GeocodeResult>("GeocodePlace", grpcClient.GeocodePlaceAsync, grpcClient.GeocodePlace, effectiveSettings.GeocodePlaceSettings).WithGoogleRequestParam("place", request => request.Place);
            Modify_ApiCall(ref _callGeocodePlace);
            Modify_GeocodePlaceApiCall(ref _callGeocodePlace);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GeocodeAddressApiCall(ref gaxgrpc::ApiCall<GeocodeAddressRequest, GeocodeAddressResponse> call);

        partial void Modify_GeocodeLocationApiCall(ref gaxgrpc::ApiCall<GeocodeLocationRequest, GeocodeLocationResponse> call);

        partial void Modify_GeocodePlaceApiCall(ref gaxgrpc::ApiCall<GeocodePlaceRequest, GeocodeResult> call);

        partial void OnConstruction(GeocodeService.GeocodeServiceClient grpcClient, GeocodeServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC GeocodeService client</summary>
        public override GeocodeService.GeocodeServiceClient GrpcClient { get; }

        partial void Modify_GeocodeAddressRequest(ref GeocodeAddressRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GeocodeLocationRequest(ref GeocodeLocationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GeocodePlaceRequest(ref GeocodePlaceRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// This method performs an address geocode, which maps an address to a
        /// LatLng. It also provides structured information about the address.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GeocodeAddressResponse GeocodeAddress(GeocodeAddressRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GeocodeAddressRequest(ref request, ref callSettings);
            return _callGeocodeAddress.Sync(request, callSettings);
        }

        /// <summary>
        /// This method performs an address geocode, which maps an address to a
        /// LatLng. It also provides structured information about the address.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GeocodeAddressResponse> GeocodeAddressAsync(GeocodeAddressRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GeocodeAddressRequest(ref request, ref callSettings);
            return _callGeocodeAddress.Async(request, callSettings);
        }

        /// <summary>
        /// This method performs a location geocode, which maps a LatLng to an
        /// address. It also provides structured information about the address.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GeocodeLocationResponse GeocodeLocation(GeocodeLocationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GeocodeLocationRequest(ref request, ref callSettings);
            return _callGeocodeLocation.Sync(request, callSettings);
        }

        /// <summary>
        /// This method performs a location geocode, which maps a LatLng to an
        /// address. It also provides structured information about the address.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GeocodeLocationResponse> GeocodeLocationAsync(GeocodeLocationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GeocodeLocationRequest(ref request, ref callSettings);
            return _callGeocodeLocation.Async(request, callSettings);
        }

        /// <summary>
        /// This method performs a geocode lookup using a place ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GeocodeResult GeocodePlace(GeocodePlaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GeocodePlaceRequest(ref request, ref callSettings);
            return _callGeocodePlace.Sync(request, callSettings);
        }

        /// <summary>
        /// This method performs a geocode lookup using a place ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GeocodeResult> GeocodePlaceAsync(GeocodePlaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GeocodePlaceRequest(ref request, ref callSettings);
            return _callGeocodePlace.Async(request, callSettings);
        }
    }
}
