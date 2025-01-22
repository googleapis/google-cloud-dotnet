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
    /// <summary>Settings for <see cref="TripServiceClient"/> instances.</summary>
    public sealed partial class TripServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="TripServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="TripServiceSettings"/>.</returns>
        public static TripServiceSettings GetDefault() => new TripServiceSettings();

        /// <summary>Constructs a new <see cref="TripServiceSettings"/> object with default settings.</summary>
        public TripServiceSettings()
        {
        }

        private TripServiceSettings(TripServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateTripSettings = existing.CreateTripSettings;
            GetTripSettings = existing.GetTripSettings;
            ReportBillableTripSettings = existing.ReportBillableTripSettings;
            SearchTripsSettings = existing.SearchTripsSettings;
            UpdateTripSettings = existing.UpdateTripSettings;
            OnCopy(existing);
        }

        partial void OnCopy(TripServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TripServiceClient.CreateTrip</c> and <c>TripServiceClient.CreateTripAsync</c>.
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
        public gaxgrpc::CallSettings CreateTripSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(15000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>TripServiceClient.GetTrip</c>
        ///  and <c>TripServiceClient.GetTripAsync</c>.
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
        public gaxgrpc::CallSettings GetTripSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(15000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TripServiceClient.ReportBillableTrip</c> and <c>TripServiceClient.ReportBillableTripAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReportBillableTripSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TripServiceClient.SearchTrips</c> and <c>TripServiceClient.SearchTripsAsync</c>.
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
        public gaxgrpc::CallSettings SearchTripsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(15000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TripServiceClient.UpdateTrip</c> and <c>TripServiceClient.UpdateTripAsync</c>.
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
        public gaxgrpc::CallSettings UpdateTripSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(15000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="TripServiceSettings"/> object.</returns>
        public TripServiceSettings Clone() => new TripServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="TripServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class TripServiceClientBuilder : gaxgrpc::ClientBuilderBase<TripServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public TripServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public TripServiceClientBuilder() : base(TripServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref TripServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<TripServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override TripServiceClient Build()
        {
            TripServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<TripServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<TripServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private TripServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return TripServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<TripServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return TripServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => TripServiceClient.ChannelPool;
    }

    /// <summary>TripService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Trip management service.
    /// </remarks>
    public abstract partial class TripServiceClient
    {
        /// <summary>
        /// The default endpoint for the TripService service, which is a host of "fleetengine.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "fleetengine.googleapis.com:443";

        /// <summary>The default TripService scopes.</summary>
        /// <remarks>
        /// The default TripService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(TripService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="TripServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TripServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="TripServiceClient"/>.</returns>
        public static stt::Task<TripServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new TripServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="TripServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TripServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="TripServiceClient"/>.</returns>
        public static TripServiceClient Create() => new TripServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="TripServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="TripServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="TripServiceClient"/>.</returns>
        internal static TripServiceClient Create(grpccore::CallInvoker callInvoker, TripServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            TripService.TripServiceClient grpcClient = new TripService.TripServiceClient(callInvoker);
            return new TripServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC TripService client</summary>
        public virtual TripService.TripServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a trip in the Fleet Engine and returns the new trip.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Trip CreateTrip(CreateTripRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a trip in the Fleet Engine and returns the new trip.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Trip> CreateTripAsync(CreateTripRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a trip in the Fleet Engine and returns the new trip.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Trip> CreateTripAsync(CreateTripRequest request, st::CancellationToken cancellationToken) =>
            CreateTripAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get information about a single trip.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Trip GetTrip(GetTripRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get information about a single trip.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Trip> GetTripAsync(GetTripRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get information about a single trip.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Trip> GetTripAsync(GetTripRequest request, st::CancellationToken cancellationToken) =>
            GetTripAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Report billable trip usage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void ReportBillableTrip(ReportBillableTripRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Report billable trip usage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task ReportBillableTripAsync(ReportBillableTripRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Report billable trip usage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task ReportBillableTripAsync(ReportBillableTripRequest request, st::CancellationToken cancellationToken) =>
            ReportBillableTripAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get all the trips for a specific vehicle.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Trip"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchTripsResponse, Trip> SearchTrips(SearchTripsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get all the trips for a specific vehicle.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Trip"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchTripsResponse, Trip> SearchTripsAsync(SearchTripsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates trip data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Trip UpdateTrip(UpdateTripRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates trip data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Trip> UpdateTripAsync(UpdateTripRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates trip data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Trip> UpdateTripAsync(UpdateTripRequest request, st::CancellationToken cancellationToken) =>
            UpdateTripAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>TripService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Trip management service.
    /// </remarks>
    public sealed partial class TripServiceClientImpl : TripServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateTripRequest, Trip> _callCreateTrip;

        private readonly gaxgrpc::ApiCall<GetTripRequest, Trip> _callGetTrip;

        private readonly gaxgrpc::ApiCall<ReportBillableTripRequest, wkt::Empty> _callReportBillableTrip;

        private readonly gaxgrpc::ApiCall<SearchTripsRequest, SearchTripsResponse> _callSearchTrips;

        private readonly gaxgrpc::ApiCall<UpdateTripRequest, Trip> _callUpdateTrip;

        /// <summary>
        /// Constructs a client wrapper for the TripService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="TripServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public TripServiceClientImpl(TripService.TripServiceClient grpcClient, TripServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            TripServiceSettings effectiveSettings = settings ?? TripServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callCreateTrip = clientHelper.BuildApiCall<CreateTripRequest, Trip>("CreateTrip", grpcClient.CreateTripAsync, grpcClient.CreateTrip, effectiveSettings.CreateTripSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<CreateTripRequest>().WithExtractedParameter("provider_id", "^(providers/[^/]+)/?$", request => request.Parent));
            Modify_ApiCall(ref _callCreateTrip);
            Modify_CreateTripApiCall(ref _callCreateTrip);
            _callGetTrip = clientHelper.BuildApiCall<GetTripRequest, Trip>("GetTrip", grpcClient.GetTripAsync, grpcClient.GetTrip, effectiveSettings.GetTripSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<GetTripRequest>().WithExtractedParameter("provider_id", "^(providers/[^/]+)/?$", request => request.Name));
            Modify_ApiCall(ref _callGetTrip);
            Modify_GetTripApiCall(ref _callGetTrip);
            _callReportBillableTrip = clientHelper.BuildApiCall<ReportBillableTripRequest, wkt::Empty>("ReportBillableTrip", grpcClient.ReportBillableTripAsync, grpcClient.ReportBillableTrip, effectiveSettings.ReportBillableTripSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<ReportBillableTripRequest>().WithExtractedParameter("provider_id", "^(providers/[^/]+)/?$", request => request.Name));
            Modify_ApiCall(ref _callReportBillableTrip);
            Modify_ReportBillableTripApiCall(ref _callReportBillableTrip);
            _callSearchTrips = clientHelper.BuildApiCall<SearchTripsRequest, SearchTripsResponse>("SearchTrips", grpcClient.SearchTripsAsync, grpcClient.SearchTrips, effectiveSettings.SearchTripsSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<SearchTripsRequest>().WithExtractedParameter("provider_id", "^(providers/[^/]+)/?$", request => request.Parent));
            Modify_ApiCall(ref _callSearchTrips);
            Modify_SearchTripsApiCall(ref _callSearchTrips);
            _callUpdateTrip = clientHelper.BuildApiCall<UpdateTripRequest, Trip>("UpdateTrip", grpcClient.UpdateTripAsync, grpcClient.UpdateTrip, effectiveSettings.UpdateTripSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<UpdateTripRequest>().WithExtractedParameter("provider_id", "^(providers/[^/]+)/?$", request => request.Name));
            Modify_ApiCall(ref _callUpdateTrip);
            Modify_UpdateTripApiCall(ref _callUpdateTrip);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateTripApiCall(ref gaxgrpc::ApiCall<CreateTripRequest, Trip> call);

        partial void Modify_GetTripApiCall(ref gaxgrpc::ApiCall<GetTripRequest, Trip> call);

        partial void Modify_ReportBillableTripApiCall(ref gaxgrpc::ApiCall<ReportBillableTripRequest, wkt::Empty> call);

        partial void Modify_SearchTripsApiCall(ref gaxgrpc::ApiCall<SearchTripsRequest, SearchTripsResponse> call);

        partial void Modify_UpdateTripApiCall(ref gaxgrpc::ApiCall<UpdateTripRequest, Trip> call);

        partial void OnConstruction(TripService.TripServiceClient grpcClient, TripServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC TripService client</summary>
        public override TripService.TripServiceClient GrpcClient { get; }

        partial void Modify_CreateTripRequest(ref CreateTripRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTripRequest(ref GetTripRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReportBillableTripRequest(ref ReportBillableTripRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchTripsRequest(ref SearchTripsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateTripRequest(ref UpdateTripRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a trip in the Fleet Engine and returns the new trip.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Trip CreateTrip(CreateTripRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTripRequest(ref request, ref callSettings);
            return _callCreateTrip.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a trip in the Fleet Engine and returns the new trip.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Trip> CreateTripAsync(CreateTripRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTripRequest(ref request, ref callSettings);
            return _callCreateTrip.Async(request, callSettings);
        }

        /// <summary>
        /// Get information about a single trip.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Trip GetTrip(GetTripRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTripRequest(ref request, ref callSettings);
            return _callGetTrip.Sync(request, callSettings);
        }

        /// <summary>
        /// Get information about a single trip.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Trip> GetTripAsync(GetTripRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTripRequest(ref request, ref callSettings);
            return _callGetTrip.Async(request, callSettings);
        }

        /// <summary>
        /// Report billable trip usage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void ReportBillableTrip(ReportBillableTripRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReportBillableTripRequest(ref request, ref callSettings);
            _callReportBillableTrip.Sync(request, callSettings);
        }

        /// <summary>
        /// Report billable trip usage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task ReportBillableTripAsync(ReportBillableTripRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReportBillableTripRequest(ref request, ref callSettings);
            return _callReportBillableTrip.Async(request, callSettings);
        }

        /// <summary>
        /// Get all the trips for a specific vehicle.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Trip"/> resources.</returns>
        public override gax::PagedEnumerable<SearchTripsResponse, Trip> SearchTrips(SearchTripsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchTripsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchTripsRequest, SearchTripsResponse, Trip>(_callSearchTrips, request, callSettings);
        }

        /// <summary>
        /// Get all the trips for a specific vehicle.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Trip"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchTripsResponse, Trip> SearchTripsAsync(SearchTripsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchTripsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchTripsRequest, SearchTripsResponse, Trip>(_callSearchTrips, request, callSettings);
        }

        /// <summary>
        /// Updates trip data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Trip UpdateTrip(UpdateTripRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTripRequest(ref request, ref callSettings);
            return _callUpdateTrip.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates trip data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Trip> UpdateTripAsync(UpdateTripRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTripRequest(ref request, ref callSettings);
            return _callUpdateTrip.Async(request, callSettings);
        }
    }

    public partial class SearchTripsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchTripsResponse : gaxgrpc::IPageResponse<Trip>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Trip> GetEnumerator() => Trips.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
