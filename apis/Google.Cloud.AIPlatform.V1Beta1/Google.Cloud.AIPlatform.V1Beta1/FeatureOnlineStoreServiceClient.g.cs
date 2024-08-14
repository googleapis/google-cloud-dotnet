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
using gciv = Google.Cloud.Iam.V1;
using gcl = Google.Cloud.Location;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.AIPlatform.V1Beta1
{
    /// <summary>Settings for <see cref="FeatureOnlineStoreServiceClient"/> instances.</summary>
    public sealed partial class FeatureOnlineStoreServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="FeatureOnlineStoreServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="FeatureOnlineStoreServiceSettings"/>.</returns>
        public static FeatureOnlineStoreServiceSettings GetDefault() => new FeatureOnlineStoreServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="FeatureOnlineStoreServiceSettings"/> object with default settings.
        /// </summary>
        public FeatureOnlineStoreServiceSettings()
        {
        }

        private FeatureOnlineStoreServiceSettings(FeatureOnlineStoreServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            FetchFeatureValuesSettings = existing.FetchFeatureValuesSettings;
            StreamingFetchFeatureValuesSettings = existing.StreamingFetchFeatureValuesSettings;
            StreamingFetchFeatureValuesStreamingSettings = existing.StreamingFetchFeatureValuesStreamingSettings;
            SearchNearestEntitiesSettings = existing.SearchNearestEntitiesSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(FeatureOnlineStoreServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeatureOnlineStoreServiceClient.FetchFeatureValues</c> and
        /// <c>FeatureOnlineStoreServiceClient.FetchFeatureValuesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FetchFeatureValuesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeatureOnlineStoreServiceClient.StreamingFetchFeatureValues</c> and
        /// <c>FeatureOnlineStoreServiceClient.StreamingFetchFeatureValuesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StreamingFetchFeatureValuesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::BidirectionalStreamingSettings"/> for calls to
        /// <c>FeatureOnlineStoreServiceClient.StreamingFetchFeatureValues</c> and
        /// <c>FeatureOnlineStoreServiceClient.StreamingFetchFeatureValuesAsync</c>.
        /// </summary>
        /// <remarks>The default local send queue size is 100.</remarks>
        public gaxgrpc::BidirectionalStreamingSettings StreamingFetchFeatureValuesStreamingSettings { get; set; } = new gaxgrpc::BidirectionalStreamingSettings(100);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeatureOnlineStoreServiceClient.SearchNearestEntities</c> and
        /// <c>FeatureOnlineStoreServiceClient.SearchNearestEntitiesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchNearestEntitiesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="FeatureOnlineStoreServiceSettings"/> object.</returns>
        public FeatureOnlineStoreServiceSettings Clone() => new FeatureOnlineStoreServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="FeatureOnlineStoreServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class FeatureOnlineStoreServiceClientBuilder : gaxgrpc::ClientBuilderBase<FeatureOnlineStoreServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public FeatureOnlineStoreServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public FeatureOnlineStoreServiceClientBuilder() : base(FeatureOnlineStoreServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref FeatureOnlineStoreServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<FeatureOnlineStoreServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override FeatureOnlineStoreServiceClient Build()
        {
            FeatureOnlineStoreServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<FeatureOnlineStoreServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<FeatureOnlineStoreServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private FeatureOnlineStoreServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return FeatureOnlineStoreServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<FeatureOnlineStoreServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return FeatureOnlineStoreServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => FeatureOnlineStoreServiceClient.ChannelPool;
    }

    /// <summary>FeatureOnlineStoreService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service for fetching feature values from the online store.
    /// </remarks>
    public abstract partial class FeatureOnlineStoreServiceClient
    {
        /// <summary>
        /// The default endpoint for the FeatureOnlineStoreService service, which is a host of
        /// "aiplatform.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "aiplatform.googleapis.com:443";

        /// <summary>The default FeatureOnlineStoreService scopes.</summary>
        /// <remarks>
        /// The default FeatureOnlineStoreService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(FeatureOnlineStoreService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="FeatureOnlineStoreServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="FeatureOnlineStoreServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="FeatureOnlineStoreServiceClient"/>.</returns>
        public static stt::Task<FeatureOnlineStoreServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new FeatureOnlineStoreServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="FeatureOnlineStoreServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="FeatureOnlineStoreServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="FeatureOnlineStoreServiceClient"/>.</returns>
        public static FeatureOnlineStoreServiceClient Create() => new FeatureOnlineStoreServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="FeatureOnlineStoreServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="FeatureOnlineStoreServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="FeatureOnlineStoreServiceClient"/>.</returns>
        internal static FeatureOnlineStoreServiceClient Create(grpccore::CallInvoker callInvoker, FeatureOnlineStoreServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            FeatureOnlineStoreService.FeatureOnlineStoreServiceClient grpcClient = new FeatureOnlineStoreService.FeatureOnlineStoreServiceClient(callInvoker);
            return new FeatureOnlineStoreServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC FeatureOnlineStoreService client</summary>
        public virtual FeatureOnlineStoreService.FeatureOnlineStoreServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Fetch feature values under a FeatureView.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchFeatureValuesResponse FetchFeatureValues(FetchFeatureValuesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetch feature values under a FeatureView.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchFeatureValuesResponse> FetchFeatureValuesAsync(FetchFeatureValuesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetch feature values under a FeatureView.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchFeatureValuesResponse> FetchFeatureValuesAsync(FetchFeatureValuesRequest request, st::CancellationToken cancellationToken) =>
            FetchFeatureValuesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetch feature values under a FeatureView.
        /// </summary>
        /// <param name="featureView">
        /// Required. FeatureView resource format
        /// `projects/{project}/locations/{location}/featureOnlineStores/{featureOnlineStore}/featureViews/{featureView}`
        /// </param>
        /// <param name="dataKey">
        /// Optional. The request key to fetch feature values for.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchFeatureValuesResponse FetchFeatureValues(string featureView, FeatureViewDataKey dataKey, gaxgrpc::CallSettings callSettings = null) =>
            FetchFeatureValues(new FetchFeatureValuesRequest
            {
                FeatureView = gax::GaxPreconditions.CheckNotNullOrEmpty(featureView, nameof(featureView)),
                DataKey = dataKey,
            }, callSettings);

        /// <summary>
        /// Fetch feature values under a FeatureView.
        /// </summary>
        /// <param name="featureView">
        /// Required. FeatureView resource format
        /// `projects/{project}/locations/{location}/featureOnlineStores/{featureOnlineStore}/featureViews/{featureView}`
        /// </param>
        /// <param name="dataKey">
        /// Optional. The request key to fetch feature values for.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchFeatureValuesResponse> FetchFeatureValuesAsync(string featureView, FeatureViewDataKey dataKey, gaxgrpc::CallSettings callSettings = null) =>
            FetchFeatureValuesAsync(new FetchFeatureValuesRequest
            {
                FeatureView = gax::GaxPreconditions.CheckNotNullOrEmpty(featureView, nameof(featureView)),
                DataKey = dataKey,
            }, callSettings);

        /// <summary>
        /// Fetch feature values under a FeatureView.
        /// </summary>
        /// <param name="featureView">
        /// Required. FeatureView resource format
        /// `projects/{project}/locations/{location}/featureOnlineStores/{featureOnlineStore}/featureViews/{featureView}`
        /// </param>
        /// <param name="dataKey">
        /// Optional. The request key to fetch feature values for.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchFeatureValuesResponse> FetchFeatureValuesAsync(string featureView, FeatureViewDataKey dataKey, st::CancellationToken cancellationToken) =>
            FetchFeatureValuesAsync(featureView, dataKey, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetch feature values under a FeatureView.
        /// </summary>
        /// <param name="featureView">
        /// Required. FeatureView resource format
        /// `projects/{project}/locations/{location}/featureOnlineStores/{featureOnlineStore}/featureViews/{featureView}`
        /// </param>
        /// <param name="dataKey">
        /// Optional. The request key to fetch feature values for.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchFeatureValuesResponse FetchFeatureValues(FeatureViewName featureView, FeatureViewDataKey dataKey, gaxgrpc::CallSettings callSettings = null) =>
            FetchFeatureValues(new FetchFeatureValuesRequest
            {
                FeatureViewAsFeatureViewName = gax::GaxPreconditions.CheckNotNull(featureView, nameof(featureView)),
                DataKey = dataKey,
            }, callSettings);

        /// <summary>
        /// Fetch feature values under a FeatureView.
        /// </summary>
        /// <param name="featureView">
        /// Required. FeatureView resource format
        /// `projects/{project}/locations/{location}/featureOnlineStores/{featureOnlineStore}/featureViews/{featureView}`
        /// </param>
        /// <param name="dataKey">
        /// Optional. The request key to fetch feature values for.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchFeatureValuesResponse> FetchFeatureValuesAsync(FeatureViewName featureView, FeatureViewDataKey dataKey, gaxgrpc::CallSettings callSettings = null) =>
            FetchFeatureValuesAsync(new FetchFeatureValuesRequest
            {
                FeatureViewAsFeatureViewName = gax::GaxPreconditions.CheckNotNull(featureView, nameof(featureView)),
                DataKey = dataKey,
            }, callSettings);

        /// <summary>
        /// Fetch feature values under a FeatureView.
        /// </summary>
        /// <param name="featureView">
        /// Required. FeatureView resource format
        /// `projects/{project}/locations/{location}/featureOnlineStores/{featureOnlineStore}/featureViews/{featureView}`
        /// </param>
        /// <param name="dataKey">
        /// Optional. The request key to fetch feature values for.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchFeatureValuesResponse> FetchFeatureValuesAsync(FeatureViewName featureView, FeatureViewDataKey dataKey, st::CancellationToken cancellationToken) =>
            FetchFeatureValuesAsync(featureView, dataKey, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Bidirectional streaming methods for
        /// <see cref="StreamingFetchFeatureValues(gaxgrpc::CallSettings,gaxgrpc::BidirectionalStreamingSettings)"/>.
        /// </summary>
        public abstract partial class StreamingFetchFeatureValuesStream : gaxgrpc::BidirectionalStreamingBase<StreamingFetchFeatureValuesRequest, StreamingFetchFeatureValuesResponse>
        {
        }

        /// <summary>
        /// Bidirectional streaming RPC to fetch feature values under a FeatureView.
        /// Requests may not have a one-to-one mapping to responses and responses may
        /// be returned out-of-order to reduce latency.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public virtual StreamingFetchFeatureValuesStream StreamingFetchFeatureValues(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Search the nearest entities under a FeatureView.
        /// Search only works for indexable feature view; if a feature view isn't
        /// indexable, returns Invalid argument response.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SearchNearestEntitiesResponse SearchNearestEntities(SearchNearestEntitiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Search the nearest entities under a FeatureView.
        /// Search only works for indexable feature view; if a feature view isn't
        /// indexable, returns Invalid argument response.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchNearestEntitiesResponse> SearchNearestEntitiesAsync(SearchNearestEntitiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Search the nearest entities under a FeatureView.
        /// Search only works for indexable feature view; if a feature view isn't
        /// indexable, returns Invalid argument response.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchNearestEntitiesResponse> SearchNearestEntitiesAsync(SearchNearestEntitiesRequest request, st::CancellationToken cancellationToken) =>
            SearchNearestEntitiesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>FeatureOnlineStoreService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service for fetching feature values from the online store.
    /// </remarks>
    public sealed partial class FeatureOnlineStoreServiceClientImpl : FeatureOnlineStoreServiceClient
    {
        private readonly gaxgrpc::ApiCall<FetchFeatureValuesRequest, FetchFeatureValuesResponse> _callFetchFeatureValues;

        private readonly gaxgrpc::ApiBidirectionalStreamingCall<StreamingFetchFeatureValuesRequest, StreamingFetchFeatureValuesResponse> _callStreamingFetchFeatureValues;

        private readonly gaxgrpc::ApiCall<SearchNearestEntitiesRequest, SearchNearestEntitiesResponse> _callSearchNearestEntities;

        /// <summary>
        /// Constructs a client wrapper for the FeatureOnlineStoreService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="FeatureOnlineStoreServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public FeatureOnlineStoreServiceClientImpl(FeatureOnlineStoreService.FeatureOnlineStoreServiceClient grpcClient, FeatureOnlineStoreServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            FeatureOnlineStoreServiceSettings effectiveSettings = settings ?? FeatureOnlineStoreServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callFetchFeatureValues = clientHelper.BuildApiCall<FetchFeatureValuesRequest, FetchFeatureValuesResponse>("FetchFeatureValues", grpcClient.FetchFeatureValuesAsync, grpcClient.FetchFeatureValues, effectiveSettings.FetchFeatureValuesSettings).WithGoogleRequestParam("feature_view", request => request.FeatureView);
            Modify_ApiCall(ref _callFetchFeatureValues);
            Modify_FetchFeatureValuesApiCall(ref _callFetchFeatureValues);
            _callStreamingFetchFeatureValues = clientHelper.BuildApiCall<StreamingFetchFeatureValuesRequest, StreamingFetchFeatureValuesResponse>("StreamingFetchFeatureValues", grpcClient.StreamingFetchFeatureValues, effectiveSettings.StreamingFetchFeatureValuesSettings, effectiveSettings.StreamingFetchFeatureValuesStreamingSettings);
            Modify_ApiCall(ref _callStreamingFetchFeatureValues);
            Modify_StreamingFetchFeatureValuesApiCall(ref _callStreamingFetchFeatureValues);
            _callSearchNearestEntities = clientHelper.BuildApiCall<SearchNearestEntitiesRequest, SearchNearestEntitiesResponse>("SearchNearestEntities", grpcClient.SearchNearestEntitiesAsync, grpcClient.SearchNearestEntities, effectiveSettings.SearchNearestEntitiesSettings).WithGoogleRequestParam("feature_view", request => request.FeatureView);
            Modify_ApiCall(ref _callSearchNearestEntities);
            Modify_SearchNearestEntitiesApiCall(ref _callSearchNearestEntities);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiBidirectionalStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_FetchFeatureValuesApiCall(ref gaxgrpc::ApiCall<FetchFeatureValuesRequest, FetchFeatureValuesResponse> call);

        partial void Modify_StreamingFetchFeatureValuesApiCall(ref gaxgrpc::ApiBidirectionalStreamingCall<StreamingFetchFeatureValuesRequest, StreamingFetchFeatureValuesResponse> call);

        partial void Modify_SearchNearestEntitiesApiCall(ref gaxgrpc::ApiCall<SearchNearestEntitiesRequest, SearchNearestEntitiesResponse> call);

        partial void OnConstruction(FeatureOnlineStoreService.FeatureOnlineStoreServiceClient grpcClient, FeatureOnlineStoreServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC FeatureOnlineStoreService client</summary>
        public override FeatureOnlineStoreService.FeatureOnlineStoreServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_FetchFeatureValuesRequest(ref FetchFeatureValuesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StreamingFetchFeatureValuesRequestCallSettings(ref gaxgrpc::CallSettings settings);

        partial void Modify_StreamingFetchFeatureValuesRequestRequest(ref StreamingFetchFeatureValuesRequest request);

        partial void Modify_SearchNearestEntitiesRequest(ref SearchNearestEntitiesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Fetch feature values under a FeatureView.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FetchFeatureValuesResponse FetchFeatureValues(FetchFeatureValuesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchFeatureValuesRequest(ref request, ref callSettings);
            return _callFetchFeatureValues.Sync(request, callSettings);
        }

        /// <summary>
        /// Fetch feature values under a FeatureView.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FetchFeatureValuesResponse> FetchFeatureValuesAsync(FetchFeatureValuesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchFeatureValuesRequest(ref request, ref callSettings);
            return _callFetchFeatureValues.Async(request, callSettings);
        }

        internal sealed partial class StreamingFetchFeatureValuesStreamImpl : StreamingFetchFeatureValuesStream
        {
            /// <summary>Construct the bidirectional streaming method for <c>StreamingFetchFeatureValues</c>.</summary>
            /// <param name="service">The service containing this streaming method.</param>
            /// <param name="call">The underlying gRPC duplex streaming call.</param>
            /// <param name="writeBuffer">
            /// The <see cref="gaxgrpc::BufferedClientStreamWriter{StreamingFetchFeatureValuesRequest}"/> instance
            /// associated with this streaming call.
            /// </param>
            public StreamingFetchFeatureValuesStreamImpl(FeatureOnlineStoreServiceClientImpl service, grpccore::AsyncDuplexStreamingCall<StreamingFetchFeatureValuesRequest, StreamingFetchFeatureValuesResponse> call, gaxgrpc::BufferedClientStreamWriter<StreamingFetchFeatureValuesRequest> writeBuffer)
            {
                _service = service;
                GrpcCall = call;
                _writeBuffer = writeBuffer;
            }

            private FeatureOnlineStoreServiceClientImpl _service;

            private gaxgrpc::BufferedClientStreamWriter<StreamingFetchFeatureValuesRequest> _writeBuffer;

            public override grpccore::AsyncDuplexStreamingCall<StreamingFetchFeatureValuesRequest, StreamingFetchFeatureValuesResponse> GrpcCall { get; }

            private StreamingFetchFeatureValuesRequest ModifyRequest(StreamingFetchFeatureValuesRequest request)
            {
                _service.Modify_StreamingFetchFeatureValuesRequestRequest(ref request);
                return request;
            }

            public override stt::Task TryWriteAsync(StreamingFetchFeatureValuesRequest message) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message));

            public override stt::Task WriteAsync(StreamingFetchFeatureValuesRequest message) =>
                _writeBuffer.WriteAsync(ModifyRequest(message));

            public override stt::Task TryWriteAsync(StreamingFetchFeatureValuesRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message), options);

            public override stt::Task WriteAsync(StreamingFetchFeatureValuesRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.WriteAsync(ModifyRequest(message), options);

            public override stt::Task TryWriteCompleteAsync() => _writeBuffer.TryWriteCompleteAsync();

            public override stt::Task WriteCompleteAsync() => _writeBuffer.WriteCompleteAsync();
        }

        /// <summary>
        /// Bidirectional streaming RPC to fetch feature values under a FeatureView.
        /// Requests may not have a one-to-one mapping to responses and responses may
        /// be returned out-of-order to reduce latency.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public override FeatureOnlineStoreServiceClient.StreamingFetchFeatureValuesStream StreamingFetchFeatureValues(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null)
        {
            Modify_StreamingFetchFeatureValuesRequestCallSettings(ref callSettings);
            gaxgrpc::BidirectionalStreamingSettings effectiveStreamingSettings = streamingSettings ?? _callStreamingFetchFeatureValues.StreamingSettings;
            grpccore::AsyncDuplexStreamingCall<StreamingFetchFeatureValuesRequest, StreamingFetchFeatureValuesResponse> call = _callStreamingFetchFeatureValues.Call(callSettings);
            gaxgrpc::BufferedClientStreamWriter<StreamingFetchFeatureValuesRequest> writeBuffer = new gaxgrpc::BufferedClientStreamWriter<StreamingFetchFeatureValuesRequest>(call.RequestStream, effectiveStreamingSettings.BufferedClientWriterCapacity);
            return new StreamingFetchFeatureValuesStreamImpl(this, call, writeBuffer);
        }

        /// <summary>
        /// Search the nearest entities under a FeatureView.
        /// Search only works for indexable feature view; if a feature view isn't
        /// indexable, returns Invalid argument response.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SearchNearestEntitiesResponse SearchNearestEntities(SearchNearestEntitiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchNearestEntitiesRequest(ref request, ref callSettings);
            return _callSearchNearestEntities.Sync(request, callSettings);
        }

        /// <summary>
        /// Search the nearest entities under a FeatureView.
        /// Search only works for indexable feature view; if a feature view isn't
        /// indexable, returns Invalid argument response.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SearchNearestEntitiesResponse> SearchNearestEntitiesAsync(SearchNearestEntitiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchNearestEntitiesRequest(ref request, ref callSettings);
            return _callSearchNearestEntities.Async(request, callSettings);
        }
    }

    public static partial class FeatureOnlineStoreService
    {
        public partial class FeatureOnlineStoreServiceClient
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

            /// <summary>
            /// Creates a new instance of <see cref="gciv::IAMPolicy.IAMPolicyClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gciv::IAMPolicy.IAMPolicyClient"/> for the same target as this client.
            /// </returns>
            public virtual gciv::IAMPolicy.IAMPolicyClient CreateIAMPolicyClient() =>
                new gciv::IAMPolicy.IAMPolicyClient(CallInvoker);
        }
    }
}
