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

namespace Google.Maps.Places.V1
{
    /// <summary>Settings for <see cref="PlacesClient"/> instances.</summary>
    public sealed partial class PlacesSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="PlacesSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="PlacesSettings"/>.</returns>
        public static PlacesSettings GetDefault() => new PlacesSettings();

        /// <summary>Constructs a new <see cref="PlacesSettings"/> object with default settings.</summary>
        public PlacesSettings()
        {
        }

        private PlacesSettings(PlacesSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            SearchNearbySettings = existing.SearchNearbySettings;
            SearchTextSettings = existing.SearchTextSettings;
            GetPhotoMediaSettings = existing.GetPhotoMediaSettings;
            GetPlaceSettings = existing.GetPlaceSettings;
            AutocompletePlacesSettings = existing.AutocompletePlacesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(PlacesSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>PlacesClient.SearchNearby</c>
        ///  and <c>PlacesClient.SearchNearbyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchNearbySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>PlacesClient.SearchText</c>
        /// and <c>PlacesClient.SearchTextAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchTextSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>PlacesClient.GetPhotoMedia</c>
        ///  and <c>PlacesClient.GetPhotoMediaAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetPhotoMediaSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>PlacesClient.GetPlace</c>
        /// and <c>PlacesClient.GetPlaceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetPlaceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PlacesClient.AutocompletePlaces</c> and <c>PlacesClient.AutocompletePlacesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AutocompletePlacesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="PlacesSettings"/> object.</returns>
        public PlacesSettings Clone() => new PlacesSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PlacesClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class PlacesClientBuilder : gaxgrpc::ClientBuilderBase<PlacesClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public PlacesSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public PlacesClientBuilder() : base(PlacesClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref PlacesClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<PlacesClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override PlacesClient Build()
        {
            PlacesClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<PlacesClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<PlacesClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private PlacesClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PlacesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<PlacesClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PlacesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => PlacesClient.ChannelPool;
    }

    /// <summary>Places client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service definition for the Places API.
    /// Note: every request (except for Autocomplete requests) requires a field mask
    /// set outside of the request proto (`all/*`, is not assumed). The field mask
    /// can be set via the HTTP header `X-Goog-FieldMask`. See:
    /// https://developers.google.com/maps/documentation/places/web-service/choose-fields
    /// </remarks>
    public abstract partial class PlacesClient
    {
        /// <summary>
        /// The default endpoint for the Places service, which is a host of "places.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "places.googleapis.com:443";

        /// <summary>The default Places scopes.</summary>
        /// <remarks>
        /// The default Places scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Places.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="PlacesClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="PlacesClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="PlacesClient"/>.</returns>
        public static stt::Task<PlacesClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new PlacesClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="PlacesClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="PlacesClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="PlacesClient"/>.</returns>
        public static PlacesClient Create() => new PlacesClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="PlacesClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="PlacesSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="PlacesClient"/>.</returns>
        internal static PlacesClient Create(grpccore::CallInvoker callInvoker, PlacesSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Places.PlacesClient grpcClient = new Places.PlacesClient(callInvoker);
            return new PlacesClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Places client</summary>
        public virtual Places.PlacesClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Search for places near locations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SearchNearbyResponse SearchNearby(SearchNearbyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Search for places near locations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchNearbyResponse> SearchNearbyAsync(SearchNearbyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Search for places near locations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchNearbyResponse> SearchNearbyAsync(SearchNearbyRequest request, st::CancellationToken cancellationToken) =>
            SearchNearbyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Text query based place search.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SearchTextResponse SearchText(SearchTextRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Text query based place search.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchTextResponse> SearchTextAsync(SearchTextRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Text query based place search.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchTextResponse> SearchTextAsync(SearchTextRequest request, st::CancellationToken cancellationToken) =>
            SearchTextAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a photo media with a photo reference string.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhotoMedia GetPhotoMedia(GetPhotoMediaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a photo media with a photo reference string.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhotoMedia> GetPhotoMediaAsync(GetPhotoMediaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a photo media with a photo reference string.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhotoMedia> GetPhotoMediaAsync(GetPhotoMediaRequest request, st::CancellationToken cancellationToken) =>
            GetPhotoMediaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a photo media with a photo reference string.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of a photo media in the format:
        /// `places/{place_id}/photos/{photo_reference}/media`.
        /// 
        /// The resource name of a photo as returned in a Place object's `photos.name`
        /// field comes with the format
        /// `places/{place_id}/photos/{photo_reference}`. You need to append `/media`
        /// at the end of the photo resource to get the photo media resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhotoMedia GetPhotoMedia(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPhotoMedia(new GetPhotoMediaRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a photo media with a photo reference string.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of a photo media in the format:
        /// `places/{place_id}/photos/{photo_reference}/media`.
        /// 
        /// The resource name of a photo as returned in a Place object's `photos.name`
        /// field comes with the format
        /// `places/{place_id}/photos/{photo_reference}`. You need to append `/media`
        /// at the end of the photo resource to get the photo media resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhotoMedia> GetPhotoMediaAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPhotoMediaAsync(new GetPhotoMediaRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a photo media with a photo reference string.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of a photo media in the format:
        /// `places/{place_id}/photos/{photo_reference}/media`.
        /// 
        /// The resource name of a photo as returned in a Place object's `photos.name`
        /// field comes with the format
        /// `places/{place_id}/photos/{photo_reference}`. You need to append `/media`
        /// at the end of the photo resource to get the photo media resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhotoMedia> GetPhotoMediaAsync(string name, st::CancellationToken cancellationToken) =>
            GetPhotoMediaAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a photo media with a photo reference string.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of a photo media in the format:
        /// `places/{place_id}/photos/{photo_reference}/media`.
        /// 
        /// The resource name of a photo as returned in a Place object's `photos.name`
        /// field comes with the format
        /// `places/{place_id}/photos/{photo_reference}`. You need to append `/media`
        /// at the end of the photo resource to get the photo media resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhotoMedia GetPhotoMedia(PhotoMediaName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPhotoMedia(new GetPhotoMediaRequest
            {
                PhotoMediaName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a photo media with a photo reference string.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of a photo media in the format:
        /// `places/{place_id}/photos/{photo_reference}/media`.
        /// 
        /// The resource name of a photo as returned in a Place object's `photos.name`
        /// field comes with the format
        /// `places/{place_id}/photos/{photo_reference}`. You need to append `/media`
        /// at the end of the photo resource to get the photo media resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhotoMedia> GetPhotoMediaAsync(PhotoMediaName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPhotoMediaAsync(new GetPhotoMediaRequest
            {
                PhotoMediaName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a photo media with a photo reference string.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of a photo media in the format:
        /// `places/{place_id}/photos/{photo_reference}/media`.
        /// 
        /// The resource name of a photo as returned in a Place object's `photos.name`
        /// field comes with the format
        /// `places/{place_id}/photos/{photo_reference}`. You need to append `/media`
        /// at the end of the photo resource to get the photo media resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhotoMedia> GetPhotoMediaAsync(PhotoMediaName name, st::CancellationToken cancellationToken) =>
            GetPhotoMediaAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the details of a place based on its resource name, which is a string
        /// in the `places/{place_id}` format.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Place GetPlace(GetPlaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get the details of a place based on its resource name, which is a string
        /// in the `places/{place_id}` format.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Place> GetPlaceAsync(GetPlaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get the details of a place based on its resource name, which is a string
        /// in the `places/{place_id}` format.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Place> GetPlaceAsync(GetPlaceRequest request, st::CancellationToken cancellationToken) =>
            GetPlaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the details of a place based on its resource name, which is a string
        /// in the `places/{place_id}` format.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of a place, in the `places/{place_id}` format.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Place GetPlace(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPlace(new GetPlaceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the details of a place based on its resource name, which is a string
        /// in the `places/{place_id}` format.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of a place, in the `places/{place_id}` format.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Place> GetPlaceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPlaceAsync(new GetPlaceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the details of a place based on its resource name, which is a string
        /// in the `places/{place_id}` format.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of a place, in the `places/{place_id}` format.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Place> GetPlaceAsync(string name, st::CancellationToken cancellationToken) =>
            GetPlaceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the details of a place based on its resource name, which is a string
        /// in the `places/{place_id}` format.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of a place, in the `places/{place_id}` format.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Place GetPlace(PlaceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPlace(new GetPlaceRequest
            {
                PlaceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the details of a place based on its resource name, which is a string
        /// in the `places/{place_id}` format.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of a place, in the `places/{place_id}` format.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Place> GetPlaceAsync(PlaceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPlaceAsync(new GetPlaceRequest
            {
                PlaceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the details of a place based on its resource name, which is a string
        /// in the `places/{place_id}` format.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of a place, in the `places/{place_id}` format.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Place> GetPlaceAsync(PlaceName name, st::CancellationToken cancellationToken) =>
            GetPlaceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns predictions for the given input.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AutocompletePlacesResponse AutocompletePlaces(AutocompletePlacesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns predictions for the given input.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutocompletePlacesResponse> AutocompletePlacesAsync(AutocompletePlacesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns predictions for the given input.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutocompletePlacesResponse> AutocompletePlacesAsync(AutocompletePlacesRequest request, st::CancellationToken cancellationToken) =>
            AutocompletePlacesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Places client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service definition for the Places API.
    /// Note: every request (except for Autocomplete requests) requires a field mask
    /// set outside of the request proto (`all/*`, is not assumed). The field mask
    /// can be set via the HTTP header `X-Goog-FieldMask`. See:
    /// https://developers.google.com/maps/documentation/places/web-service/choose-fields
    /// </remarks>
    public sealed partial class PlacesClientImpl : PlacesClient
    {
        private readonly gaxgrpc::ApiCall<SearchNearbyRequest, SearchNearbyResponse> _callSearchNearby;

        private readonly gaxgrpc::ApiCall<SearchTextRequest, SearchTextResponse> _callSearchText;

        private readonly gaxgrpc::ApiCall<GetPhotoMediaRequest, PhotoMedia> _callGetPhotoMedia;

        private readonly gaxgrpc::ApiCall<GetPlaceRequest, Place> _callGetPlace;

        private readonly gaxgrpc::ApiCall<AutocompletePlacesRequest, AutocompletePlacesResponse> _callAutocompletePlaces;

        /// <summary>
        /// Constructs a client wrapper for the Places service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="PlacesSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public PlacesClientImpl(Places.PlacesClient grpcClient, PlacesSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            PlacesSettings effectiveSettings = settings ?? PlacesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callSearchNearby = clientHelper.BuildApiCall<SearchNearbyRequest, SearchNearbyResponse>("SearchNearby", grpcClient.SearchNearbyAsync, grpcClient.SearchNearby, effectiveSettings.SearchNearbySettings);
            Modify_ApiCall(ref _callSearchNearby);
            Modify_SearchNearbyApiCall(ref _callSearchNearby);
            _callSearchText = clientHelper.BuildApiCall<SearchTextRequest, SearchTextResponse>("SearchText", grpcClient.SearchTextAsync, grpcClient.SearchText, effectiveSettings.SearchTextSettings);
            Modify_ApiCall(ref _callSearchText);
            Modify_SearchTextApiCall(ref _callSearchText);
            _callGetPhotoMedia = clientHelper.BuildApiCall<GetPhotoMediaRequest, PhotoMedia>("GetPhotoMedia", grpcClient.GetPhotoMediaAsync, grpcClient.GetPhotoMedia, effectiveSettings.GetPhotoMediaSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPhotoMedia);
            Modify_GetPhotoMediaApiCall(ref _callGetPhotoMedia);
            _callGetPlace = clientHelper.BuildApiCall<GetPlaceRequest, Place>("GetPlace", grpcClient.GetPlaceAsync, grpcClient.GetPlace, effectiveSettings.GetPlaceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPlace);
            Modify_GetPlaceApiCall(ref _callGetPlace);
            _callAutocompletePlaces = clientHelper.BuildApiCall<AutocompletePlacesRequest, AutocompletePlacesResponse>("AutocompletePlaces", grpcClient.AutocompletePlacesAsync, grpcClient.AutocompletePlaces, effectiveSettings.AutocompletePlacesSettings);
            Modify_ApiCall(ref _callAutocompletePlaces);
            Modify_AutocompletePlacesApiCall(ref _callAutocompletePlaces);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_SearchNearbyApiCall(ref gaxgrpc::ApiCall<SearchNearbyRequest, SearchNearbyResponse> call);

        partial void Modify_SearchTextApiCall(ref gaxgrpc::ApiCall<SearchTextRequest, SearchTextResponse> call);

        partial void Modify_GetPhotoMediaApiCall(ref gaxgrpc::ApiCall<GetPhotoMediaRequest, PhotoMedia> call);

        partial void Modify_GetPlaceApiCall(ref gaxgrpc::ApiCall<GetPlaceRequest, Place> call);

        partial void Modify_AutocompletePlacesApiCall(ref gaxgrpc::ApiCall<AutocompletePlacesRequest, AutocompletePlacesResponse> call);

        partial void OnConstruction(Places.PlacesClient grpcClient, PlacesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Places client</summary>
        public override Places.PlacesClient GrpcClient { get; }

        partial void Modify_SearchNearbyRequest(ref SearchNearbyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchTextRequest(ref SearchTextRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPhotoMediaRequest(ref GetPhotoMediaRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPlaceRequest(ref GetPlaceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AutocompletePlacesRequest(ref AutocompletePlacesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Search for places near locations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SearchNearbyResponse SearchNearby(SearchNearbyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchNearbyRequest(ref request, ref callSettings);
            return _callSearchNearby.Sync(request, callSettings);
        }

        /// <summary>
        /// Search for places near locations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SearchNearbyResponse> SearchNearbyAsync(SearchNearbyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchNearbyRequest(ref request, ref callSettings);
            return _callSearchNearby.Async(request, callSettings);
        }

        /// <summary>
        /// Text query based place search.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SearchTextResponse SearchText(SearchTextRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchTextRequest(ref request, ref callSettings);
            return _callSearchText.Sync(request, callSettings);
        }

        /// <summary>
        /// Text query based place search.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SearchTextResponse> SearchTextAsync(SearchTextRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchTextRequest(ref request, ref callSettings);
            return _callSearchText.Async(request, callSettings);
        }

        /// <summary>
        /// Get a photo media with a photo reference string.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PhotoMedia GetPhotoMedia(GetPhotoMediaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPhotoMediaRequest(ref request, ref callSettings);
            return _callGetPhotoMedia.Sync(request, callSettings);
        }

        /// <summary>
        /// Get a photo media with a photo reference string.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PhotoMedia> GetPhotoMediaAsync(GetPhotoMediaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPhotoMediaRequest(ref request, ref callSettings);
            return _callGetPhotoMedia.Async(request, callSettings);
        }

        /// <summary>
        /// Get the details of a place based on its resource name, which is a string
        /// in the `places/{place_id}` format.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Place GetPlace(GetPlaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPlaceRequest(ref request, ref callSettings);
            return _callGetPlace.Sync(request, callSettings);
        }

        /// <summary>
        /// Get the details of a place based on its resource name, which is a string
        /// in the `places/{place_id}` format.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Place> GetPlaceAsync(GetPlaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPlaceRequest(ref request, ref callSettings);
            return _callGetPlace.Async(request, callSettings);
        }

        /// <summary>
        /// Returns predictions for the given input.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AutocompletePlacesResponse AutocompletePlaces(AutocompletePlacesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AutocompletePlacesRequest(ref request, ref callSettings);
            return _callAutocompletePlaces.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns predictions for the given input.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AutocompletePlacesResponse> AutocompletePlacesAsync(AutocompletePlacesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AutocompletePlacesRequest(ref request, ref callSettings);
            return _callAutocompletePlaces.Async(request, callSettings);
        }
    }
}
