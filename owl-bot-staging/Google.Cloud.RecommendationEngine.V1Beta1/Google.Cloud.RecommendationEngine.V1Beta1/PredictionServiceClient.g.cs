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

namespace Google.Cloud.RecommendationEngine.V1Beta1
{
    /// <summary>Settings for <see cref="PredictionServiceClient"/> instances.</summary>
    public sealed partial class PredictionServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="PredictionServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="PredictionServiceSettings"/>.</returns>
        public static PredictionServiceSettings GetDefault() => new PredictionServiceSettings();

        /// <summary>Constructs a new <see cref="PredictionServiceSettings"/> object with default settings.</summary>
        public PredictionServiceSettings()
        {
        }

        private PredictionServiceSettings(PredictionServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            PredictSettings = existing.PredictSettings;
            OnCopy(existing);
        }

        partial void OnCopy(PredictionServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PredictionServiceClient.Predict</c> and <c>PredictionServiceClient.PredictAsync</c>.
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
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PredictSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="PredictionServiceSettings"/> object.</returns>
        public PredictionServiceSettings Clone() => new PredictionServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PredictionServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class PredictionServiceClientBuilder : gaxgrpc::ClientBuilderBase<PredictionServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public PredictionServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public PredictionServiceClientBuilder() : base(PredictionServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref PredictionServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<PredictionServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override PredictionServiceClient Build()
        {
            PredictionServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<PredictionServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<PredictionServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private PredictionServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PredictionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<PredictionServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PredictionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => PredictionServiceClient.ChannelPool;
    }

    /// <summary>PredictionService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for making recommendation prediction.
    /// </remarks>
    public abstract partial class PredictionServiceClient
    {
        /// <summary>
        /// The default endpoint for the PredictionService service, which is a host of
        /// "recommendationengine.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "recommendationengine.googleapis.com:443";

        /// <summary>The default PredictionService scopes.</summary>
        /// <remarks>
        /// The default PredictionService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(PredictionService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="PredictionServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="PredictionServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="PredictionServiceClient"/>.</returns>
        public static stt::Task<PredictionServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new PredictionServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="PredictionServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="PredictionServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="PredictionServiceClient"/>.</returns>
        public static PredictionServiceClient Create() => new PredictionServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="PredictionServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="PredictionServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="PredictionServiceClient"/>.</returns>
        internal static PredictionServiceClient Create(grpccore::CallInvoker callInvoker, PredictionServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            PredictionService.PredictionServiceClient grpcClient = new PredictionService.PredictionServiceClient(callInvoker);
            return new PredictionServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC PredictionService client</summary>
        public virtual PredictionService.PredictionServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Makes a recommendation prediction. If using API Key based authentication,
        /// the API Key must be registered using the
        /// [PredictionApiKeyRegistry][google.cloud.recommendationengine.v1beta1.PredictionApiKeyRegistry]
        /// service. [Learn more](/recommendations-ai/docs/setting-up#register-key).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PredictResponse.Types.PredictionResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<PredictResponse, PredictResponse.Types.PredictionResult> Predict(PredictRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Makes a recommendation prediction. If using API Key based authentication,
        /// the API Key must be registered using the
        /// [PredictionApiKeyRegistry][google.cloud.recommendationengine.v1beta1.PredictionApiKeyRegistry]
        /// service. [Learn more](/recommendations-ai/docs/setting-up#register-key).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="PredictResponse.Types.PredictionResult"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<PredictResponse, PredictResponse.Types.PredictionResult> PredictAsync(PredictRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Makes a recommendation prediction. If using API Key based authentication,
        /// the API Key must be registered using the
        /// [PredictionApiKeyRegistry][google.cloud.recommendationengine.v1beta1.PredictionApiKeyRegistry]
        /// service. [Learn more](/recommendations-ai/docs/setting-up#register-key).
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of the format:
        /// `{name=projects/*/locations/global/catalogs/default_catalog/eventStores/default_event_store/placements/*}`
        /// The id of the recommendation engine placement. This id is used to identify
        /// the set of models that will be used to make the prediction.
        /// 
        /// We currently support three placements with the following IDs by default:
        /// 
        /// * `shopping_cart`: Predicts items frequently bought together with one or
        /// more catalog items in the same shopping session. Commonly displayed after
        /// `add-to-cart` events, on product detail pages, or on the shopping cart
        /// page.
        /// 
        /// * `home_page`: Predicts the next product that a user will most likely
        /// engage with or purchase based on the shopping or viewing history of the
        /// specified `userId` or `visitorId`. For example - Recommendations for you.
        /// 
        /// * `product_detail`: Predicts the next product that a user will most likely
        /// engage with or purchase. The prediction is based on the shopping or
        /// viewing history of the specified `userId` or `visitorId` and its
        /// relevance to a specified `CatalogItem`. Typically used on product detail
        /// pages. For example - More items like this.
        /// 
        /// * `recently_viewed_default`: Returns up to 75 items recently viewed by the
        /// specified `userId` or `visitorId`, most recent ones first. Returns
        /// nothing if neither of them has viewed any items yet. For example -
        /// Recently viewed.
        /// 
        /// The full list of available placements can be seen at
        /// https://console.cloud.google.com/recommendation/datafeeds/default_catalog/dashboard
        /// </param>
        /// <param name="userEvent">
        /// Required. Context about the user, what they are looking at and what action
        /// they took to trigger the predict request. Note that this user event detail
        /// won't be ingested to userEvent logs. Thus, a separate userEvent write
        /// request is required for event logging.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PredictResponse.Types.PredictionResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<PredictResponse, PredictResponse.Types.PredictionResult> Predict(string name, UserEvent userEvent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            PredictRequest request = new PredictRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                UserEvent = gax::GaxPreconditions.CheckNotNull(userEvent, nameof(userEvent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return Predict(request, callSettings);
        }

        /// <summary>
        /// Makes a recommendation prediction. If using API Key based authentication,
        /// the API Key must be registered using the
        /// [PredictionApiKeyRegistry][google.cloud.recommendationengine.v1beta1.PredictionApiKeyRegistry]
        /// service. [Learn more](/recommendations-ai/docs/setting-up#register-key).
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of the format:
        /// `{name=projects/*/locations/global/catalogs/default_catalog/eventStores/default_event_store/placements/*}`
        /// The id of the recommendation engine placement. This id is used to identify
        /// the set of models that will be used to make the prediction.
        /// 
        /// We currently support three placements with the following IDs by default:
        /// 
        /// * `shopping_cart`: Predicts items frequently bought together with one or
        /// more catalog items in the same shopping session. Commonly displayed after
        /// `add-to-cart` events, on product detail pages, or on the shopping cart
        /// page.
        /// 
        /// * `home_page`: Predicts the next product that a user will most likely
        /// engage with or purchase based on the shopping or viewing history of the
        /// specified `userId` or `visitorId`. For example - Recommendations for you.
        /// 
        /// * `product_detail`: Predicts the next product that a user will most likely
        /// engage with or purchase. The prediction is based on the shopping or
        /// viewing history of the specified `userId` or `visitorId` and its
        /// relevance to a specified `CatalogItem`. Typically used on product detail
        /// pages. For example - More items like this.
        /// 
        /// * `recently_viewed_default`: Returns up to 75 items recently viewed by the
        /// specified `userId` or `visitorId`, most recent ones first. Returns
        /// nothing if neither of them has viewed any items yet. For example -
        /// Recently viewed.
        /// 
        /// The full list of available placements can be seen at
        /// https://console.cloud.google.com/recommendation/datafeeds/default_catalog/dashboard
        /// </param>
        /// <param name="userEvent">
        /// Required. Context about the user, what they are looking at and what action
        /// they took to trigger the predict request. Note that this user event detail
        /// won't be ingested to userEvent logs. Thus, a separate userEvent write
        /// request is required for event logging.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="PredictResponse.Types.PredictionResult"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<PredictResponse, PredictResponse.Types.PredictionResult> PredictAsync(string name, UserEvent userEvent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            PredictRequest request = new PredictRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                UserEvent = gax::GaxPreconditions.CheckNotNull(userEvent, nameof(userEvent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return PredictAsync(request, callSettings);
        }

        /// <summary>
        /// Makes a recommendation prediction. If using API Key based authentication,
        /// the API Key must be registered using the
        /// [PredictionApiKeyRegistry][google.cloud.recommendationengine.v1beta1.PredictionApiKeyRegistry]
        /// service. [Learn more](/recommendations-ai/docs/setting-up#register-key).
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of the format:
        /// `{name=projects/*/locations/global/catalogs/default_catalog/eventStores/default_event_store/placements/*}`
        /// The id of the recommendation engine placement. This id is used to identify
        /// the set of models that will be used to make the prediction.
        /// 
        /// We currently support three placements with the following IDs by default:
        /// 
        /// * `shopping_cart`: Predicts items frequently bought together with one or
        /// more catalog items in the same shopping session. Commonly displayed after
        /// `add-to-cart` events, on product detail pages, or on the shopping cart
        /// page.
        /// 
        /// * `home_page`: Predicts the next product that a user will most likely
        /// engage with or purchase based on the shopping or viewing history of the
        /// specified `userId` or `visitorId`. For example - Recommendations for you.
        /// 
        /// * `product_detail`: Predicts the next product that a user will most likely
        /// engage with or purchase. The prediction is based on the shopping or
        /// viewing history of the specified `userId` or `visitorId` and its
        /// relevance to a specified `CatalogItem`. Typically used on product detail
        /// pages. For example - More items like this.
        /// 
        /// * `recently_viewed_default`: Returns up to 75 items recently viewed by the
        /// specified `userId` or `visitorId`, most recent ones first. Returns
        /// nothing if neither of them has viewed any items yet. For example -
        /// Recently viewed.
        /// 
        /// The full list of available placements can be seen at
        /// https://console.cloud.google.com/recommendation/datafeeds/default_catalog/dashboard
        /// </param>
        /// <param name="userEvent">
        /// Required. Context about the user, what they are looking at and what action
        /// they took to trigger the predict request. Note that this user event detail
        /// won't be ingested to userEvent logs. Thus, a separate userEvent write
        /// request is required for event logging.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PredictResponse.Types.PredictionResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<PredictResponse, PredictResponse.Types.PredictionResult> Predict(PlacementName name, UserEvent userEvent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            PredictRequest request = new PredictRequest
            {
                PlacementName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                UserEvent = gax::GaxPreconditions.CheckNotNull(userEvent, nameof(userEvent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return Predict(request, callSettings);
        }

        /// <summary>
        /// Makes a recommendation prediction. If using API Key based authentication,
        /// the API Key must be registered using the
        /// [PredictionApiKeyRegistry][google.cloud.recommendationengine.v1beta1.PredictionApiKeyRegistry]
        /// service. [Learn more](/recommendations-ai/docs/setting-up#register-key).
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of the format:
        /// `{name=projects/*/locations/global/catalogs/default_catalog/eventStores/default_event_store/placements/*}`
        /// The id of the recommendation engine placement. This id is used to identify
        /// the set of models that will be used to make the prediction.
        /// 
        /// We currently support three placements with the following IDs by default:
        /// 
        /// * `shopping_cart`: Predicts items frequently bought together with one or
        /// more catalog items in the same shopping session. Commonly displayed after
        /// `add-to-cart` events, on product detail pages, or on the shopping cart
        /// page.
        /// 
        /// * `home_page`: Predicts the next product that a user will most likely
        /// engage with or purchase based on the shopping or viewing history of the
        /// specified `userId` or `visitorId`. For example - Recommendations for you.
        /// 
        /// * `product_detail`: Predicts the next product that a user will most likely
        /// engage with or purchase. The prediction is based on the shopping or
        /// viewing history of the specified `userId` or `visitorId` and its
        /// relevance to a specified `CatalogItem`. Typically used on product detail
        /// pages. For example - More items like this.
        /// 
        /// * `recently_viewed_default`: Returns up to 75 items recently viewed by the
        /// specified `userId` or `visitorId`, most recent ones first. Returns
        /// nothing if neither of them has viewed any items yet. For example -
        /// Recently viewed.
        /// 
        /// The full list of available placements can be seen at
        /// https://console.cloud.google.com/recommendation/datafeeds/default_catalog/dashboard
        /// </param>
        /// <param name="userEvent">
        /// Required. Context about the user, what they are looking at and what action
        /// they took to trigger the predict request. Note that this user event detail
        /// won't be ingested to userEvent logs. Thus, a separate userEvent write
        /// request is required for event logging.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="PredictResponse.Types.PredictionResult"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<PredictResponse, PredictResponse.Types.PredictionResult> PredictAsync(PlacementName name, UserEvent userEvent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            PredictRequest request = new PredictRequest
            {
                PlacementName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                UserEvent = gax::GaxPreconditions.CheckNotNull(userEvent, nameof(userEvent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return PredictAsync(request, callSettings);
        }
    }

    /// <summary>PredictionService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for making recommendation prediction.
    /// </remarks>
    public sealed partial class PredictionServiceClientImpl : PredictionServiceClient
    {
        private readonly gaxgrpc::ApiCall<PredictRequest, PredictResponse> _callPredict;

        /// <summary>
        /// Constructs a client wrapper for the PredictionService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="PredictionServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public PredictionServiceClientImpl(PredictionService.PredictionServiceClient grpcClient, PredictionServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            PredictionServiceSettings effectiveSettings = settings ?? PredictionServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callPredict = clientHelper.BuildApiCall<PredictRequest, PredictResponse>("Predict", grpcClient.PredictAsync, grpcClient.Predict, effectiveSettings.PredictSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callPredict);
            Modify_PredictApiCall(ref _callPredict);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_PredictApiCall(ref gaxgrpc::ApiCall<PredictRequest, PredictResponse> call);

        partial void OnConstruction(PredictionService.PredictionServiceClient grpcClient, PredictionServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC PredictionService client</summary>
        public override PredictionService.PredictionServiceClient GrpcClient { get; }

        partial void Modify_PredictRequest(ref PredictRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Makes a recommendation prediction. If using API Key based authentication,
        /// the API Key must be registered using the
        /// [PredictionApiKeyRegistry][google.cloud.recommendationengine.v1beta1.PredictionApiKeyRegistry]
        /// service. [Learn more](/recommendations-ai/docs/setting-up#register-key).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PredictResponse.Types.PredictionResult"/> resources.</returns>
        public override gax::PagedEnumerable<PredictResponse, PredictResponse.Types.PredictionResult> Predict(PredictRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PredictRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<PredictRequest, PredictResponse, PredictResponse.Types.PredictionResult>(_callPredict, request, callSettings);
        }

        /// <summary>
        /// Makes a recommendation prediction. If using API Key based authentication,
        /// the API Key must be registered using the
        /// [PredictionApiKeyRegistry][google.cloud.recommendationengine.v1beta1.PredictionApiKeyRegistry]
        /// service. [Learn more](/recommendations-ai/docs/setting-up#register-key).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="PredictResponse.Types.PredictionResult"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<PredictResponse, PredictResponse.Types.PredictionResult> PredictAsync(PredictRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PredictRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<PredictRequest, PredictResponse, PredictResponse.Types.PredictionResult>(_callPredict, request, callSettings);
        }
    }

    public partial class PredictRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class PredictResponse : gaxgrpc::IPageResponse<PredictResponse.Types.PredictionResult>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Types.PredictionResult> GetEnumerator() => Results.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
