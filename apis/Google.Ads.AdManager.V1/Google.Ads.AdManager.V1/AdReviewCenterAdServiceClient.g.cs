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
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Ads.AdManager.V1
{
    /// <summary>Settings for <see cref="AdReviewCenterAdServiceClient"/> instances.</summary>
    public sealed partial class AdReviewCenterAdServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AdReviewCenterAdServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AdReviewCenterAdServiceSettings"/>.</returns>
        public static AdReviewCenterAdServiceSettings GetDefault() => new AdReviewCenterAdServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="AdReviewCenterAdServiceSettings"/> object with default settings.
        /// </summary>
        public AdReviewCenterAdServiceSettings()
        {
        }

        private AdReviewCenterAdServiceSettings(AdReviewCenterAdServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            SearchAdReviewCenterAdsSettings = existing.SearchAdReviewCenterAdsSettings;
            BatchAllowAdReviewCenterAdsSettings = existing.BatchAllowAdReviewCenterAdsSettings;
            BatchAllowAdReviewCenterAdsOperationsSettings = existing.BatchAllowAdReviewCenterAdsOperationsSettings.Clone();
            BatchBlockAdReviewCenterAdsSettings = existing.BatchBlockAdReviewCenterAdsSettings;
            BatchBlockAdReviewCenterAdsOperationsSettings = existing.BatchBlockAdReviewCenterAdsOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(AdReviewCenterAdServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdReviewCenterAdServiceClient.SearchAdReviewCenterAds</c> and
        /// <c>AdReviewCenterAdServiceClient.SearchAdReviewCenterAdsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchAdReviewCenterAdsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdReviewCenterAdServiceClient.BatchAllowAdReviewCenterAds</c> and
        /// <c>AdReviewCenterAdServiceClient.BatchAllowAdReviewCenterAdsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchAllowAdReviewCenterAdsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>AdReviewCenterAdServiceClient.BatchAllowAdReviewCenterAds</c>
        ///  and <c>AdReviewCenterAdServiceClient.BatchAllowAdReviewCenterAdsAsync</c>.
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
        public lro::OperationsSettings BatchAllowAdReviewCenterAdsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdReviewCenterAdServiceClient.BatchBlockAdReviewCenterAds</c> and
        /// <c>AdReviewCenterAdServiceClient.BatchBlockAdReviewCenterAdsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchBlockAdReviewCenterAdsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>AdReviewCenterAdServiceClient.BatchBlockAdReviewCenterAds</c>
        ///  and <c>AdReviewCenterAdServiceClient.BatchBlockAdReviewCenterAdsAsync</c>.
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
        public lro::OperationsSettings BatchBlockAdReviewCenterAdsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AdReviewCenterAdServiceSettings"/> object.</returns>
        public AdReviewCenterAdServiceSettings Clone() => new AdReviewCenterAdServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AdReviewCenterAdServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class AdReviewCenterAdServiceClientBuilder : gaxgrpc::ClientBuilderBase<AdReviewCenterAdServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AdReviewCenterAdServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AdReviewCenterAdServiceClientBuilder() : base(AdReviewCenterAdServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AdReviewCenterAdServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AdReviewCenterAdServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AdReviewCenterAdServiceClient Build()
        {
            AdReviewCenterAdServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AdReviewCenterAdServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AdReviewCenterAdServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AdReviewCenterAdServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AdReviewCenterAdServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AdReviewCenterAdServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AdReviewCenterAdServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AdReviewCenterAdServiceClient.ChannelPool;
    }

    /// <summary>AdReviewCenterAdService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling AdReviewCenterAd objects.
    /// </remarks>
    public abstract partial class AdReviewCenterAdServiceClient
    {
        /// <summary>
        /// The default endpoint for the AdReviewCenterAdService service, which is a host of "admanager.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default AdReviewCenterAdService scopes.</summary>
        /// <remarks>
        /// The default AdReviewCenterAdService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/admanager</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admanager",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AdReviewCenterAdService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AdReviewCenterAdServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="AdReviewCenterAdServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AdReviewCenterAdServiceClient"/>.</returns>
        public static stt::Task<AdReviewCenterAdServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AdReviewCenterAdServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AdReviewCenterAdServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="AdReviewCenterAdServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AdReviewCenterAdServiceClient"/>.</returns>
        public static AdReviewCenterAdServiceClient Create() => new AdReviewCenterAdServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AdReviewCenterAdServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AdReviewCenterAdServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AdReviewCenterAdServiceClient"/>.</returns>
        internal static AdReviewCenterAdServiceClient Create(grpccore::CallInvoker callInvoker, AdReviewCenterAdServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AdReviewCenterAdService.AdReviewCenterAdServiceClient grpcClient = new AdReviewCenterAdService.AdReviewCenterAdServiceClient(callInvoker);
            return new AdReviewCenterAdServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AdReviewCenterAdService client</summary>
        public virtual AdReviewCenterAdService.AdReviewCenterAdServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// API to search for AdReviewCenterAds.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AdReviewCenterAd"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchAdReviewCenterAdsResponse, AdReviewCenterAd> SearchAdReviewCenterAds(SearchAdReviewCenterAdsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to search for AdReviewCenterAds.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AdReviewCenterAd"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchAdReviewCenterAdsResponse, AdReviewCenterAd> SearchAdReviewCenterAdsAsync(SearchAdReviewCenterAdsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to search for AdReviewCenterAds.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of AdReviewCenterAds.
        /// Format: networks/{network_code}/webProperties/{web_property_code}
        /// 
        /// Since a network can only have a single web property of each
        /// `ExchangeSyndicationProduct`, you can use the
        /// `ExchangeSyndicationProduct` as an alias for the web property code:
        /// 
        /// `networks/{network_code}/webProperties/display`
        /// 
        /// `networks/{network_code}/webProperties/videoAndAudio`
        /// 
        /// `networks/{network_code}/webProperties/mobileApp`
        /// 
        /// `networks/{network_code}/webProperties/games`
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
        /// <returns>A pageable sequence of <see cref="AdReviewCenterAd"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchAdReviewCenterAdsResponse, AdReviewCenterAd> SearchAdReviewCenterAds(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchAdReviewCenterAdsRequest request = new SearchAdReviewCenterAdsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchAdReviewCenterAds(request, callSettings);
        }

        /// <summary>
        /// API to search for AdReviewCenterAds.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of AdReviewCenterAds.
        /// Format: networks/{network_code}/webProperties/{web_property_code}
        /// 
        /// Since a network can only have a single web property of each
        /// `ExchangeSyndicationProduct`, you can use the
        /// `ExchangeSyndicationProduct` as an alias for the web property code:
        /// 
        /// `networks/{network_code}/webProperties/display`
        /// 
        /// `networks/{network_code}/webProperties/videoAndAudio`
        /// 
        /// `networks/{network_code}/webProperties/mobileApp`
        /// 
        /// `networks/{network_code}/webProperties/games`
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
        /// <returns>A pageable asynchronous sequence of <see cref="AdReviewCenterAd"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchAdReviewCenterAdsResponse, AdReviewCenterAd> SearchAdReviewCenterAdsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchAdReviewCenterAdsRequest request = new SearchAdReviewCenterAdsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchAdReviewCenterAdsAsync(request, callSettings);
        }

        /// <summary>
        /// API to search for AdReviewCenterAds.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of AdReviewCenterAds.
        /// Format: networks/{network_code}/webProperties/{web_property_code}
        /// 
        /// Since a network can only have a single web property of each
        /// `ExchangeSyndicationProduct`, you can use the
        /// `ExchangeSyndicationProduct` as an alias for the web property code:
        /// 
        /// `networks/{network_code}/webProperties/display`
        /// 
        /// `networks/{network_code}/webProperties/videoAndAudio`
        /// 
        /// `networks/{network_code}/webProperties/mobileApp`
        /// 
        /// `networks/{network_code}/webProperties/games`
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
        /// <returns>A pageable sequence of <see cref="AdReviewCenterAd"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchAdReviewCenterAdsResponse, AdReviewCenterAd> SearchAdReviewCenterAds(WebPropertyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchAdReviewCenterAdsRequest request = new SearchAdReviewCenterAdsRequest
            {
                ParentAsWebPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchAdReviewCenterAds(request, callSettings);
        }

        /// <summary>
        /// API to search for AdReviewCenterAds.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of AdReviewCenterAds.
        /// Format: networks/{network_code}/webProperties/{web_property_code}
        /// 
        /// Since a network can only have a single web property of each
        /// `ExchangeSyndicationProduct`, you can use the
        /// `ExchangeSyndicationProduct` as an alias for the web property code:
        /// 
        /// `networks/{network_code}/webProperties/display`
        /// 
        /// `networks/{network_code}/webProperties/videoAndAudio`
        /// 
        /// `networks/{network_code}/webProperties/mobileApp`
        /// 
        /// `networks/{network_code}/webProperties/games`
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
        /// <returns>A pageable asynchronous sequence of <see cref="AdReviewCenterAd"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchAdReviewCenterAdsResponse, AdReviewCenterAd> SearchAdReviewCenterAdsAsync(WebPropertyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchAdReviewCenterAdsRequest request = new SearchAdReviewCenterAdsRequest
            {
                ParentAsWebPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchAdReviewCenterAdsAsync(request, callSettings);
        }

        /// <summary>
        /// API to batch allow AdReviewCenterAds.
        /// This method supports partial success. Some operations may succeed while
        /// others fail. Callers should check the failedRequests field in the response
        /// to determine which operations failed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchAllowAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> BatchAllowAdReviewCenterAds(BatchAllowAdReviewCenterAdsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to batch allow AdReviewCenterAds.
        /// This method supports partial success. Some operations may succeed while
        /// others fail. Callers should check the failedRequests field in the response
        /// to determine which operations failed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchAllowAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata>> BatchAllowAdReviewCenterAdsAsync(BatchAllowAdReviewCenterAdsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to batch allow AdReviewCenterAds.
        /// This method supports partial success. Some operations may succeed while
        /// others fail. Callers should check the failedRequests field in the response
        /// to determine which operations failed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchAllowAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata>> BatchAllowAdReviewCenterAdsAsync(BatchAllowAdReviewCenterAdsRequest request, st::CancellationToken cancellationToken) =>
            BatchAllowAdReviewCenterAdsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>BatchAllowAdReviewCenterAds</c>.</summary>
        public virtual lro::OperationsClient BatchAllowAdReviewCenterAdsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchAllowAdReviewCenterAds</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BatchAllowAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> PollOnceBatchAllowAdReviewCenterAds(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchAllowAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchAllowAdReviewCenterAdsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchAllowAdReviewCenterAds</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BatchAllowAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata>> PollOnceBatchAllowAdReviewCenterAdsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchAllowAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchAllowAdReviewCenterAdsOperationsClient, callSettings);

        /// <summary>
        /// API to batch allow AdReviewCenterAds.
        /// This method supports partial success. Some operations may succeed while
        /// others fail. Callers should check the failedRequests field in the response
        /// to determine which operations failed.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of AdReviewCenterAds.
        /// Format: networks/{network_code}/webProperties/{web_property_code}
        /// 
        /// Since a network can only have a single web property of each
        /// `ExchangeSyndicationProduct`, you can use the
        /// `ExchangeSyndicationProduct` as an alias for the web property code:
        /// 
        /// `networks/{network_code}/webProperties/display`
        /// 
        /// `networks/{network_code}/webProperties/videoAndAudio`
        /// 
        /// `networks/{network_code}/webProperties/mobileApp`
        /// 
        /// `networks/{network_code}/webProperties/games`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchAllowAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> BatchAllowAdReviewCenterAds(string parent, gaxgrpc::CallSettings callSettings = null) =>
            BatchAllowAdReviewCenterAds(new BatchAllowAdReviewCenterAdsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// API to batch allow AdReviewCenterAds.
        /// This method supports partial success. Some operations may succeed while
        /// others fail. Callers should check the failedRequests field in the response
        /// to determine which operations failed.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of AdReviewCenterAds.
        /// Format: networks/{network_code}/webProperties/{web_property_code}
        /// 
        /// Since a network can only have a single web property of each
        /// `ExchangeSyndicationProduct`, you can use the
        /// `ExchangeSyndicationProduct` as an alias for the web property code:
        /// 
        /// `networks/{network_code}/webProperties/display`
        /// 
        /// `networks/{network_code}/webProperties/videoAndAudio`
        /// 
        /// `networks/{network_code}/webProperties/mobileApp`
        /// 
        /// `networks/{network_code}/webProperties/games`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchAllowAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata>> BatchAllowAdReviewCenterAdsAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            BatchAllowAdReviewCenterAdsAsync(new BatchAllowAdReviewCenterAdsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// API to batch allow AdReviewCenterAds.
        /// This method supports partial success. Some operations may succeed while
        /// others fail. Callers should check the failedRequests field in the response
        /// to determine which operations failed.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of AdReviewCenterAds.
        /// Format: networks/{network_code}/webProperties/{web_property_code}
        /// 
        /// Since a network can only have a single web property of each
        /// `ExchangeSyndicationProduct`, you can use the
        /// `ExchangeSyndicationProduct` as an alias for the web property code:
        /// 
        /// `networks/{network_code}/webProperties/display`
        /// 
        /// `networks/{network_code}/webProperties/videoAndAudio`
        /// 
        /// `networks/{network_code}/webProperties/mobileApp`
        /// 
        /// `networks/{network_code}/webProperties/games`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchAllowAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata>> BatchAllowAdReviewCenterAdsAsync(string parent, st::CancellationToken cancellationToken) =>
            BatchAllowAdReviewCenterAdsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch allow AdReviewCenterAds.
        /// This method supports partial success. Some operations may succeed while
        /// others fail. Callers should check the failedRequests field in the response
        /// to determine which operations failed.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of AdReviewCenterAds.
        /// Format: networks/{network_code}/webProperties/{web_property_code}
        /// 
        /// Since a network can only have a single web property of each
        /// `ExchangeSyndicationProduct`, you can use the
        /// `ExchangeSyndicationProduct` as an alias for the web property code:
        /// 
        /// `networks/{network_code}/webProperties/display`
        /// 
        /// `networks/{network_code}/webProperties/videoAndAudio`
        /// 
        /// `networks/{network_code}/webProperties/mobileApp`
        /// 
        /// `networks/{network_code}/webProperties/games`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchAllowAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> BatchAllowAdReviewCenterAds(WebPropertyName parent, gaxgrpc::CallSettings callSettings = null) =>
            BatchAllowAdReviewCenterAds(new BatchAllowAdReviewCenterAdsRequest
            {
                ParentAsWebPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// API to batch allow AdReviewCenterAds.
        /// This method supports partial success. Some operations may succeed while
        /// others fail. Callers should check the failedRequests field in the response
        /// to determine which operations failed.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of AdReviewCenterAds.
        /// Format: networks/{network_code}/webProperties/{web_property_code}
        /// 
        /// Since a network can only have a single web property of each
        /// `ExchangeSyndicationProduct`, you can use the
        /// `ExchangeSyndicationProduct` as an alias for the web property code:
        /// 
        /// `networks/{network_code}/webProperties/display`
        /// 
        /// `networks/{network_code}/webProperties/videoAndAudio`
        /// 
        /// `networks/{network_code}/webProperties/mobileApp`
        /// 
        /// `networks/{network_code}/webProperties/games`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchAllowAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata>> BatchAllowAdReviewCenterAdsAsync(WebPropertyName parent, gaxgrpc::CallSettings callSettings = null) =>
            BatchAllowAdReviewCenterAdsAsync(new BatchAllowAdReviewCenterAdsRequest
            {
                ParentAsWebPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// API to batch allow AdReviewCenterAds.
        /// This method supports partial success. Some operations may succeed while
        /// others fail. Callers should check the failedRequests field in the response
        /// to determine which operations failed.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of AdReviewCenterAds.
        /// Format: networks/{network_code}/webProperties/{web_property_code}
        /// 
        /// Since a network can only have a single web property of each
        /// `ExchangeSyndicationProduct`, you can use the
        /// `ExchangeSyndicationProduct` as an alias for the web property code:
        /// 
        /// `networks/{network_code}/webProperties/display`
        /// 
        /// `networks/{network_code}/webProperties/videoAndAudio`
        /// 
        /// `networks/{network_code}/webProperties/mobileApp`
        /// 
        /// `networks/{network_code}/webProperties/games`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchAllowAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata>> BatchAllowAdReviewCenterAdsAsync(WebPropertyName parent, st::CancellationToken cancellationToken) =>
            BatchAllowAdReviewCenterAdsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch block AdReviewCenterAds.
        /// This method supports partial success. Some operations may succeed while
        /// others fail. Callers should check the failedRequests field in the response
        /// to determine which operations failed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchBlockAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> BatchBlockAdReviewCenterAds(BatchBlockAdReviewCenterAdsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to batch block AdReviewCenterAds.
        /// This method supports partial success. Some operations may succeed while
        /// others fail. Callers should check the failedRequests field in the response
        /// to determine which operations failed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchBlockAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata>> BatchBlockAdReviewCenterAdsAsync(BatchBlockAdReviewCenterAdsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to batch block AdReviewCenterAds.
        /// This method supports partial success. Some operations may succeed while
        /// others fail. Callers should check the failedRequests field in the response
        /// to determine which operations failed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchBlockAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata>> BatchBlockAdReviewCenterAdsAsync(BatchBlockAdReviewCenterAdsRequest request, st::CancellationToken cancellationToken) =>
            BatchBlockAdReviewCenterAdsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>BatchBlockAdReviewCenterAds</c>.</summary>
        public virtual lro::OperationsClient BatchBlockAdReviewCenterAdsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchBlockAdReviewCenterAds</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BatchBlockAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> PollOnceBatchBlockAdReviewCenterAds(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchBlockAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchBlockAdReviewCenterAdsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchBlockAdReviewCenterAds</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BatchBlockAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata>> PollOnceBatchBlockAdReviewCenterAdsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchBlockAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchBlockAdReviewCenterAdsOperationsClient, callSettings);

        /// <summary>
        /// API to batch block AdReviewCenterAds.
        /// This method supports partial success. Some operations may succeed while
        /// others fail. Callers should check the failedRequests field in the response
        /// to determine which operations failed.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of AdReviewCenterAds.
        /// Format: networks/{network_code}/webProperties/{web_property_code}
        /// 
        /// Since a network can only have a single web property of each
        /// `ExchangeSyndicationProduct`, you can use the
        /// `ExchangeSyndicationProduct` as an alias for the web property code:
        /// 
        /// `networks/{network_code}/webProperties/display`
        /// 
        /// `networks/{network_code}/webProperties/videoAndAudio`
        /// 
        /// `networks/{network_code}/webProperties/mobileApp`
        /// 
        /// `networks/{network_code}/webProperties/games`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchBlockAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> BatchBlockAdReviewCenterAds(string parent, gaxgrpc::CallSettings callSettings = null) =>
            BatchBlockAdReviewCenterAds(new BatchBlockAdReviewCenterAdsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// API to batch block AdReviewCenterAds.
        /// This method supports partial success. Some operations may succeed while
        /// others fail. Callers should check the failedRequests field in the response
        /// to determine which operations failed.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of AdReviewCenterAds.
        /// Format: networks/{network_code}/webProperties/{web_property_code}
        /// 
        /// Since a network can only have a single web property of each
        /// `ExchangeSyndicationProduct`, you can use the
        /// `ExchangeSyndicationProduct` as an alias for the web property code:
        /// 
        /// `networks/{network_code}/webProperties/display`
        /// 
        /// `networks/{network_code}/webProperties/videoAndAudio`
        /// 
        /// `networks/{network_code}/webProperties/mobileApp`
        /// 
        /// `networks/{network_code}/webProperties/games`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchBlockAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata>> BatchBlockAdReviewCenterAdsAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            BatchBlockAdReviewCenterAdsAsync(new BatchBlockAdReviewCenterAdsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// API to batch block AdReviewCenterAds.
        /// This method supports partial success. Some operations may succeed while
        /// others fail. Callers should check the failedRequests field in the response
        /// to determine which operations failed.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of AdReviewCenterAds.
        /// Format: networks/{network_code}/webProperties/{web_property_code}
        /// 
        /// Since a network can only have a single web property of each
        /// `ExchangeSyndicationProduct`, you can use the
        /// `ExchangeSyndicationProduct` as an alias for the web property code:
        /// 
        /// `networks/{network_code}/webProperties/display`
        /// 
        /// `networks/{network_code}/webProperties/videoAndAudio`
        /// 
        /// `networks/{network_code}/webProperties/mobileApp`
        /// 
        /// `networks/{network_code}/webProperties/games`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchBlockAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata>> BatchBlockAdReviewCenterAdsAsync(string parent, st::CancellationToken cancellationToken) =>
            BatchBlockAdReviewCenterAdsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch block AdReviewCenterAds.
        /// This method supports partial success. Some operations may succeed while
        /// others fail. Callers should check the failedRequests field in the response
        /// to determine which operations failed.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of AdReviewCenterAds.
        /// Format: networks/{network_code}/webProperties/{web_property_code}
        /// 
        /// Since a network can only have a single web property of each
        /// `ExchangeSyndicationProduct`, you can use the
        /// `ExchangeSyndicationProduct` as an alias for the web property code:
        /// 
        /// `networks/{network_code}/webProperties/display`
        /// 
        /// `networks/{network_code}/webProperties/videoAndAudio`
        /// 
        /// `networks/{network_code}/webProperties/mobileApp`
        /// 
        /// `networks/{network_code}/webProperties/games`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchBlockAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> BatchBlockAdReviewCenterAds(WebPropertyName parent, gaxgrpc::CallSettings callSettings = null) =>
            BatchBlockAdReviewCenterAds(new BatchBlockAdReviewCenterAdsRequest
            {
                ParentAsWebPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// API to batch block AdReviewCenterAds.
        /// This method supports partial success. Some operations may succeed while
        /// others fail. Callers should check the failedRequests field in the response
        /// to determine which operations failed.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of AdReviewCenterAds.
        /// Format: networks/{network_code}/webProperties/{web_property_code}
        /// 
        /// Since a network can only have a single web property of each
        /// `ExchangeSyndicationProduct`, you can use the
        /// `ExchangeSyndicationProduct` as an alias for the web property code:
        /// 
        /// `networks/{network_code}/webProperties/display`
        /// 
        /// `networks/{network_code}/webProperties/videoAndAudio`
        /// 
        /// `networks/{network_code}/webProperties/mobileApp`
        /// 
        /// `networks/{network_code}/webProperties/games`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchBlockAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata>> BatchBlockAdReviewCenterAdsAsync(WebPropertyName parent, gaxgrpc::CallSettings callSettings = null) =>
            BatchBlockAdReviewCenterAdsAsync(new BatchBlockAdReviewCenterAdsRequest
            {
                ParentAsWebPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// API to batch block AdReviewCenterAds.
        /// This method supports partial success. Some operations may succeed while
        /// others fail. Callers should check the failedRequests field in the response
        /// to determine which operations failed.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of AdReviewCenterAds.
        /// Format: networks/{network_code}/webProperties/{web_property_code}
        /// 
        /// Since a network can only have a single web property of each
        /// `ExchangeSyndicationProduct`, you can use the
        /// `ExchangeSyndicationProduct` as an alias for the web property code:
        /// 
        /// `networks/{network_code}/webProperties/display`
        /// 
        /// `networks/{network_code}/webProperties/videoAndAudio`
        /// 
        /// `networks/{network_code}/webProperties/mobileApp`
        /// 
        /// `networks/{network_code}/webProperties/games`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchBlockAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata>> BatchBlockAdReviewCenterAdsAsync(WebPropertyName parent, st::CancellationToken cancellationToken) =>
            BatchBlockAdReviewCenterAdsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AdReviewCenterAdService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling AdReviewCenterAd objects.
    /// </remarks>
    public sealed partial class AdReviewCenterAdServiceClientImpl : AdReviewCenterAdServiceClient
    {
        private readonly gaxgrpc::ApiCall<SearchAdReviewCenterAdsRequest, SearchAdReviewCenterAdsResponse> _callSearchAdReviewCenterAds;

        private readonly gaxgrpc::ApiCall<BatchAllowAdReviewCenterAdsRequest, lro::Operation> _callBatchAllowAdReviewCenterAds;

        private readonly gaxgrpc::ApiCall<BatchBlockAdReviewCenterAdsRequest, lro::Operation> _callBatchBlockAdReviewCenterAds;

        /// <summary>
        /// Constructs a client wrapper for the AdReviewCenterAdService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="AdReviewCenterAdServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AdReviewCenterAdServiceClientImpl(AdReviewCenterAdService.AdReviewCenterAdServiceClient grpcClient, AdReviewCenterAdServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AdReviewCenterAdServiceSettings effectiveSettings = settings ?? AdReviewCenterAdServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            BatchAllowAdReviewCenterAdsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.BatchAllowAdReviewCenterAdsOperationsSettings, logger);
            BatchBlockAdReviewCenterAdsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.BatchBlockAdReviewCenterAdsOperationsSettings, logger);
            _callSearchAdReviewCenterAds = clientHelper.BuildApiCall<SearchAdReviewCenterAdsRequest, SearchAdReviewCenterAdsResponse>("SearchAdReviewCenterAds", grpcClient.SearchAdReviewCenterAdsAsync, grpcClient.SearchAdReviewCenterAds, effectiveSettings.SearchAdReviewCenterAdsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callSearchAdReviewCenterAds);
            Modify_SearchAdReviewCenterAdsApiCall(ref _callSearchAdReviewCenterAds);
            _callBatchAllowAdReviewCenterAds = clientHelper.BuildApiCall<BatchAllowAdReviewCenterAdsRequest, lro::Operation>("BatchAllowAdReviewCenterAds", grpcClient.BatchAllowAdReviewCenterAdsAsync, grpcClient.BatchAllowAdReviewCenterAds, effectiveSettings.BatchAllowAdReviewCenterAdsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchAllowAdReviewCenterAds);
            Modify_BatchAllowAdReviewCenterAdsApiCall(ref _callBatchAllowAdReviewCenterAds);
            _callBatchBlockAdReviewCenterAds = clientHelper.BuildApiCall<BatchBlockAdReviewCenterAdsRequest, lro::Operation>("BatchBlockAdReviewCenterAds", grpcClient.BatchBlockAdReviewCenterAdsAsync, grpcClient.BatchBlockAdReviewCenterAds, effectiveSettings.BatchBlockAdReviewCenterAdsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchBlockAdReviewCenterAds);
            Modify_BatchBlockAdReviewCenterAdsApiCall(ref _callBatchBlockAdReviewCenterAds);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_SearchAdReviewCenterAdsApiCall(ref gaxgrpc::ApiCall<SearchAdReviewCenterAdsRequest, SearchAdReviewCenterAdsResponse> call);

        partial void Modify_BatchAllowAdReviewCenterAdsApiCall(ref gaxgrpc::ApiCall<BatchAllowAdReviewCenterAdsRequest, lro::Operation> call);

        partial void Modify_BatchBlockAdReviewCenterAdsApiCall(ref gaxgrpc::ApiCall<BatchBlockAdReviewCenterAdsRequest, lro::Operation> call);

        partial void OnConstruction(AdReviewCenterAdService.AdReviewCenterAdServiceClient grpcClient, AdReviewCenterAdServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AdReviewCenterAdService client</summary>
        public override AdReviewCenterAdService.AdReviewCenterAdServiceClient GrpcClient { get; }

        partial void Modify_SearchAdReviewCenterAdsRequest(ref SearchAdReviewCenterAdsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchAllowAdReviewCenterAdsRequest(ref BatchAllowAdReviewCenterAdsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchBlockAdReviewCenterAdsRequest(ref BatchBlockAdReviewCenterAdsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// API to search for AdReviewCenterAds.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AdReviewCenterAd"/> resources.</returns>
        public override gax::PagedEnumerable<SearchAdReviewCenterAdsResponse, AdReviewCenterAd> SearchAdReviewCenterAds(SearchAdReviewCenterAdsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchAdReviewCenterAdsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchAdReviewCenterAdsRequest, SearchAdReviewCenterAdsResponse, AdReviewCenterAd>(_callSearchAdReviewCenterAds, request, callSettings);
        }

        /// <summary>
        /// API to search for AdReviewCenterAds.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AdReviewCenterAd"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchAdReviewCenterAdsResponse, AdReviewCenterAd> SearchAdReviewCenterAdsAsync(SearchAdReviewCenterAdsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchAdReviewCenterAdsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchAdReviewCenterAdsRequest, SearchAdReviewCenterAdsResponse, AdReviewCenterAd>(_callSearchAdReviewCenterAds, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>BatchAllowAdReviewCenterAds</c>.</summary>
        public override lro::OperationsClient BatchAllowAdReviewCenterAdsOperationsClient { get; }

        /// <summary>
        /// API to batch allow AdReviewCenterAds.
        /// This method supports partial success. Some operations may succeed while
        /// others fail. Callers should check the failedRequests field in the response
        /// to determine which operations failed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BatchAllowAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> BatchAllowAdReviewCenterAds(BatchAllowAdReviewCenterAdsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchAllowAdReviewCenterAdsRequest(ref request, ref callSettings);
            return new lro::Operation<BatchAllowAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata>(_callBatchAllowAdReviewCenterAds.Sync(request, callSettings), BatchAllowAdReviewCenterAdsOperationsClient);
        }

        /// <summary>
        /// API to batch allow AdReviewCenterAds.
        /// This method supports partial success. Some operations may succeed while
        /// others fail. Callers should check the failedRequests field in the response
        /// to determine which operations failed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BatchAllowAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata>> BatchAllowAdReviewCenterAdsAsync(BatchAllowAdReviewCenterAdsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchAllowAdReviewCenterAdsRequest(ref request, ref callSettings);
            return new lro::Operation<BatchAllowAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata>(await _callBatchAllowAdReviewCenterAds.Async(request, callSettings).ConfigureAwait(false), BatchAllowAdReviewCenterAdsOperationsClient);
        }

        /// <summary>The long-running operations client for <c>BatchBlockAdReviewCenterAds</c>.</summary>
        public override lro::OperationsClient BatchBlockAdReviewCenterAdsOperationsClient { get; }

        /// <summary>
        /// API to batch block AdReviewCenterAds.
        /// This method supports partial success. Some operations may succeed while
        /// others fail. Callers should check the failedRequests field in the response
        /// to determine which operations failed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BatchBlockAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> BatchBlockAdReviewCenterAds(BatchBlockAdReviewCenterAdsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchBlockAdReviewCenterAdsRequest(ref request, ref callSettings);
            return new lro::Operation<BatchBlockAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata>(_callBatchBlockAdReviewCenterAds.Sync(request, callSettings), BatchBlockAdReviewCenterAdsOperationsClient);
        }

        /// <summary>
        /// API to batch block AdReviewCenterAds.
        /// This method supports partial success. Some operations may succeed while
        /// others fail. Callers should check the failedRequests field in the response
        /// to determine which operations failed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BatchBlockAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata>> BatchBlockAdReviewCenterAdsAsync(BatchBlockAdReviewCenterAdsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchBlockAdReviewCenterAdsRequest(ref request, ref callSettings);
            return new lro::Operation<BatchBlockAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata>(await _callBatchBlockAdReviewCenterAds.Async(request, callSettings).ConfigureAwait(false), BatchBlockAdReviewCenterAdsOperationsClient);
        }
    }

    public partial class SearchAdReviewCenterAdsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchAdReviewCenterAdsResponse : gaxgrpc::IPageResponse<AdReviewCenterAd>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AdReviewCenterAd> GetEnumerator() => AdReviewCenterAds.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class AdReviewCenterAdService
    {
        public partial class AdReviewCenterAdServiceClient
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
