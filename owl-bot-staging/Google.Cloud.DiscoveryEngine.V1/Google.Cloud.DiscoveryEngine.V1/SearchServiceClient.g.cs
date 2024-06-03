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
using gcl = Google.Cloud.Location;
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

namespace Google.Cloud.DiscoveryEngine.V1
{
    /// <summary>Settings for <see cref="SearchServiceClient"/> instances.</summary>
    public sealed partial class SearchServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SearchServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SearchServiceSettings"/>.</returns>
        public static SearchServiceSettings GetDefault() => new SearchServiceSettings();

        /// <summary>Constructs a new <see cref="SearchServiceSettings"/> object with default settings.</summary>
        public SearchServiceSettings()
        {
        }

        private SearchServiceSettings(SearchServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            SearchSettings = existing.SearchSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SearchServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>SearchServiceClient.Search</c>
        ///  and <c>SearchServiceClient.SearchAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SearchServiceSettings"/> object.</returns>
        public SearchServiceSettings Clone() => new SearchServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SearchServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class SearchServiceClientBuilder : gaxgrpc::ClientBuilderBase<SearchServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SearchServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SearchServiceClientBuilder() : base(SearchServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SearchServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SearchServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SearchServiceClient Build()
        {
            SearchServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SearchServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SearchServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SearchServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SearchServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SearchServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SearchServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SearchServiceClient.ChannelPool;
    }

    /// <summary>SearchService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for search.
    /// </remarks>
    public abstract partial class SearchServiceClient
    {
        /// <summary>
        /// The default endpoint for the SearchService service, which is a host of "discoveryengine.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "discoveryengine.googleapis.com:443";

        /// <summary>The default SearchService scopes.</summary>
        /// <remarks>
        /// The default SearchService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(SearchService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SearchServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SearchServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SearchServiceClient"/>.</returns>
        public static stt::Task<SearchServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SearchServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SearchServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SearchServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SearchServiceClient"/>.</returns>
        public static SearchServiceClient Create() => new SearchServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SearchServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SearchServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SearchServiceClient"/>.</returns>
        internal static SearchServiceClient Create(grpccore::CallInvoker callInvoker, SearchServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SearchService.SearchServiceClient grpcClient = new SearchService.SearchServiceClient(callInvoker);
            return new SearchServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC SearchService client</summary>
        public virtual SearchService.SearchServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Performs a search.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SearchResponse.Types.SearchResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchResponse, SearchResponse.Types.SearchResult> Search(SearchRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Performs a search.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="SearchResponse.Types.SearchResult"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<SearchResponse, SearchResponse.Types.SearchResult> SearchAsync(SearchRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();
    }

    /// <summary>SearchService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for search.
    /// </remarks>
    public sealed partial class SearchServiceClientImpl : SearchServiceClient
    {
        private readonly gaxgrpc::ApiCall<SearchRequest, SearchResponse> _callSearch;

        /// <summary>
        /// Constructs a client wrapper for the SearchService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SearchServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SearchServiceClientImpl(SearchService.SearchServiceClient grpcClient, SearchServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SearchServiceSettings effectiveSettings = settings ?? SearchServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callSearch = clientHelper.BuildApiCall<SearchRequest, SearchResponse>("Search", grpcClient.SearchAsync, grpcClient.Search, effectiveSettings.SearchSettings).WithGoogleRequestParam("serving_config", request => request.ServingConfig);
            Modify_ApiCall(ref _callSearch);
            Modify_SearchApiCall(ref _callSearch);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_SearchApiCall(ref gaxgrpc::ApiCall<SearchRequest, SearchResponse> call);

        partial void OnConstruction(SearchService.SearchServiceClient grpcClient, SearchServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SearchService client</summary>
        public override SearchService.SearchServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_SearchRequest(ref SearchRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Performs a search.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SearchResponse.Types.SearchResult"/> resources.</returns>
        public override gax::PagedEnumerable<SearchResponse, SearchResponse.Types.SearchResult> Search(SearchRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchRequest, SearchResponse, SearchResponse.Types.SearchResult>(_callSearch, request, callSettings);
        }

        /// <summary>
        /// Performs a search.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="SearchResponse.Types.SearchResult"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<SearchResponse, SearchResponse.Types.SearchResult> SearchAsync(SearchRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchRequest, SearchResponse, SearchResponse.Types.SearchResult>(_callSearch, request, callSettings);
        }
    }

    public partial class SearchRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchResponse : gaxgrpc::IPageResponse<SearchResponse.Types.SearchResult>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Types.SearchResult> GetEnumerator() => Results.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class SearchService
    {
        public partial class SearchServiceClient
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
        }
    }
}
