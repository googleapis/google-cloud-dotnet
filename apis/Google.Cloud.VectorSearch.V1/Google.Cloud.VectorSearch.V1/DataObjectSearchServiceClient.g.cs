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

namespace Google.Cloud.VectorSearch.V1
{
    /// <summary>Settings for <see cref="DataObjectSearchServiceClient"/> instances.</summary>
    public sealed partial class DataObjectSearchServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DataObjectSearchServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DataObjectSearchServiceSettings"/>.</returns>
        public static DataObjectSearchServiceSettings GetDefault() => new DataObjectSearchServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="DataObjectSearchServiceSettings"/> object with default settings.
        /// </summary>
        public DataObjectSearchServiceSettings()
        {
        }

        private DataObjectSearchServiceSettings(DataObjectSearchServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            SearchDataObjectsSettings = existing.SearchDataObjectsSettings;
            QueryDataObjectsSettings = existing.QueryDataObjectsSettings;
            AggregateDataObjectsSettings = existing.AggregateDataObjectsSettings;
            BatchSearchDataObjectsSettings = existing.BatchSearchDataObjectsSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DataObjectSearchServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataObjectSearchServiceClient.SearchDataObjects</c> and
        /// <c>DataObjectSearchServiceClient.SearchDataObjectsAsync</c>.
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
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchDataObjectsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataObjectSearchServiceClient.QueryDataObjects</c> and
        /// <c>DataObjectSearchServiceClient.QueryDataObjectsAsync</c>.
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
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings QueryDataObjectsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataObjectSearchServiceClient.AggregateDataObjects</c> and
        /// <c>DataObjectSearchServiceClient.AggregateDataObjectsAsync</c>.
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
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AggregateDataObjectsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataObjectSearchServiceClient.BatchSearchDataObjects</c> and
        /// <c>DataObjectSearchServiceClient.BatchSearchDataObjectsAsync</c>.
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
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchSearchDataObjectsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DataObjectSearchServiceSettings"/> object.</returns>
        public DataObjectSearchServiceSettings Clone() => new DataObjectSearchServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DataObjectSearchServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class DataObjectSearchServiceClientBuilder : gaxgrpc::ClientBuilderBase<DataObjectSearchServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DataObjectSearchServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DataObjectSearchServiceClientBuilder() : base(DataObjectSearchServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DataObjectSearchServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DataObjectSearchServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DataObjectSearchServiceClient Build()
        {
            DataObjectSearchServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DataObjectSearchServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DataObjectSearchServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DataObjectSearchServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DataObjectSearchServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DataObjectSearchServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DataObjectSearchServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DataObjectSearchServiceClient.ChannelPool;
    }

    /// <summary>DataObjectSearchService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for searching data objects.
    /// </remarks>
    public abstract partial class DataObjectSearchServiceClient
    {
        /// <summary>
        /// The default endpoint for the DataObjectSearchService service, which is a host of
        /// "vectorsearch.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "vectorsearch.googleapis.com:443";

        /// <summary>The default DataObjectSearchService scopes.</summary>
        /// <remarks>
        /// The default DataObjectSearchService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DataObjectSearchService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DataObjectSearchServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="DataObjectSearchServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DataObjectSearchServiceClient"/>.</returns>
        public static stt::Task<DataObjectSearchServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DataObjectSearchServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DataObjectSearchServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="DataObjectSearchServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DataObjectSearchServiceClient"/>.</returns>
        public static DataObjectSearchServiceClient Create() => new DataObjectSearchServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DataObjectSearchServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DataObjectSearchServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DataObjectSearchServiceClient"/>.</returns>
        internal static DataObjectSearchServiceClient Create(grpccore::CallInvoker callInvoker, DataObjectSearchServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DataObjectSearchService.DataObjectSearchServiceClient grpcClient = new DataObjectSearchService.DataObjectSearchServiceClient(callInvoker);
            return new DataObjectSearchServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DataObjectSearchService client</summary>
        public virtual DataObjectSearchService.DataObjectSearchServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Searches data objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SearchResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchDataObjectsResponse, SearchResult> SearchDataObjects(SearchDataObjectsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches data objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SearchResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchDataObjectsResponse, SearchResult> SearchDataObjectsAsync(SearchDataObjectsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Queries data objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataObject"/> resources.</returns>
        public virtual gax::PagedEnumerable<QueryDataObjectsResponse, DataObject> QueryDataObjects(QueryDataObjectsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Queries data objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataObject"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<QueryDataObjectsResponse, DataObject> QueryDataObjectsAsync(QueryDataObjectsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Aggregates data objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AggregateDataObjectsResponse AggregateDataObjects(AggregateDataObjectsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Aggregates data objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AggregateDataObjectsResponse> AggregateDataObjectsAsync(AggregateDataObjectsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Aggregates data objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AggregateDataObjectsResponse> AggregateDataObjectsAsync(AggregateDataObjectsRequest request, st::CancellationToken cancellationToken) =>
            AggregateDataObjectsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch searches data objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchSearchDataObjectsResponse BatchSearchDataObjects(BatchSearchDataObjectsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch searches data objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchSearchDataObjectsResponse> BatchSearchDataObjectsAsync(BatchSearchDataObjectsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch searches data objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchSearchDataObjectsResponse> BatchSearchDataObjectsAsync(BatchSearchDataObjectsRequest request, st::CancellationToken cancellationToken) =>
            BatchSearchDataObjectsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>DataObjectSearchService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for searching data objects.
    /// </remarks>
    public sealed partial class DataObjectSearchServiceClientImpl : DataObjectSearchServiceClient
    {
        private readonly gaxgrpc::ApiCall<SearchDataObjectsRequest, SearchDataObjectsResponse> _callSearchDataObjects;

        private readonly gaxgrpc::ApiCall<QueryDataObjectsRequest, QueryDataObjectsResponse> _callQueryDataObjects;

        private readonly gaxgrpc::ApiCall<AggregateDataObjectsRequest, AggregateDataObjectsResponse> _callAggregateDataObjects;

        private readonly gaxgrpc::ApiCall<BatchSearchDataObjectsRequest, BatchSearchDataObjectsResponse> _callBatchSearchDataObjects;

        /// <summary>
        /// Constructs a client wrapper for the DataObjectSearchService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="DataObjectSearchServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DataObjectSearchServiceClientImpl(DataObjectSearchService.DataObjectSearchServiceClient grpcClient, DataObjectSearchServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DataObjectSearchServiceSettings effectiveSettings = settings ?? DataObjectSearchServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callSearchDataObjects = clientHelper.BuildApiCall<SearchDataObjectsRequest, SearchDataObjectsResponse>("SearchDataObjects", grpcClient.SearchDataObjectsAsync, grpcClient.SearchDataObjects, effectiveSettings.SearchDataObjectsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callSearchDataObjects);
            Modify_SearchDataObjectsApiCall(ref _callSearchDataObjects);
            _callQueryDataObjects = clientHelper.BuildApiCall<QueryDataObjectsRequest, QueryDataObjectsResponse>("QueryDataObjects", grpcClient.QueryDataObjectsAsync, grpcClient.QueryDataObjects, effectiveSettings.QueryDataObjectsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callQueryDataObjects);
            Modify_QueryDataObjectsApiCall(ref _callQueryDataObjects);
            _callAggregateDataObjects = clientHelper.BuildApiCall<AggregateDataObjectsRequest, AggregateDataObjectsResponse>("AggregateDataObjects", grpcClient.AggregateDataObjectsAsync, grpcClient.AggregateDataObjects, effectiveSettings.AggregateDataObjectsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callAggregateDataObjects);
            Modify_AggregateDataObjectsApiCall(ref _callAggregateDataObjects);
            _callBatchSearchDataObjects = clientHelper.BuildApiCall<BatchSearchDataObjectsRequest, BatchSearchDataObjectsResponse>("BatchSearchDataObjects", grpcClient.BatchSearchDataObjectsAsync, grpcClient.BatchSearchDataObjects, effectiveSettings.BatchSearchDataObjectsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchSearchDataObjects);
            Modify_BatchSearchDataObjectsApiCall(ref _callBatchSearchDataObjects);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_SearchDataObjectsApiCall(ref gaxgrpc::ApiCall<SearchDataObjectsRequest, SearchDataObjectsResponse> call);

        partial void Modify_QueryDataObjectsApiCall(ref gaxgrpc::ApiCall<QueryDataObjectsRequest, QueryDataObjectsResponse> call);

        partial void Modify_AggregateDataObjectsApiCall(ref gaxgrpc::ApiCall<AggregateDataObjectsRequest, AggregateDataObjectsResponse> call);

        partial void Modify_BatchSearchDataObjectsApiCall(ref gaxgrpc::ApiCall<BatchSearchDataObjectsRequest, BatchSearchDataObjectsResponse> call);

        partial void OnConstruction(DataObjectSearchService.DataObjectSearchServiceClient grpcClient, DataObjectSearchServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DataObjectSearchService client</summary>
        public override DataObjectSearchService.DataObjectSearchServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_SearchDataObjectsRequest(ref SearchDataObjectsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_QueryDataObjectsRequest(ref QueryDataObjectsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AggregateDataObjectsRequest(ref AggregateDataObjectsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchSearchDataObjectsRequest(ref BatchSearchDataObjectsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Searches data objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SearchResult"/> resources.</returns>
        public override gax::PagedEnumerable<SearchDataObjectsResponse, SearchResult> SearchDataObjects(SearchDataObjectsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchDataObjectsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchDataObjectsRequest, SearchDataObjectsResponse, SearchResult>(_callSearchDataObjects, request, callSettings);
        }

        /// <summary>
        /// Searches data objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SearchResult"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchDataObjectsResponse, SearchResult> SearchDataObjectsAsync(SearchDataObjectsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchDataObjectsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchDataObjectsRequest, SearchDataObjectsResponse, SearchResult>(_callSearchDataObjects, request, callSettings);
        }

        /// <summary>
        /// Queries data objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataObject"/> resources.</returns>
        public override gax::PagedEnumerable<QueryDataObjectsResponse, DataObject> QueryDataObjects(QueryDataObjectsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryDataObjectsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<QueryDataObjectsRequest, QueryDataObjectsResponse, DataObject>(_callQueryDataObjects, request, callSettings);
        }

        /// <summary>
        /// Queries data objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataObject"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<QueryDataObjectsResponse, DataObject> QueryDataObjectsAsync(QueryDataObjectsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryDataObjectsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<QueryDataObjectsRequest, QueryDataObjectsResponse, DataObject>(_callQueryDataObjects, request, callSettings);
        }

        /// <summary>
        /// Aggregates data objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AggregateDataObjectsResponse AggregateDataObjects(AggregateDataObjectsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregateDataObjectsRequest(ref request, ref callSettings);
            return _callAggregateDataObjects.Sync(request, callSettings);
        }

        /// <summary>
        /// Aggregates data objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AggregateDataObjectsResponse> AggregateDataObjectsAsync(AggregateDataObjectsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregateDataObjectsRequest(ref request, ref callSettings);
            return _callAggregateDataObjects.Async(request, callSettings);
        }

        /// <summary>
        /// Batch searches data objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchSearchDataObjectsResponse BatchSearchDataObjects(BatchSearchDataObjectsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchSearchDataObjectsRequest(ref request, ref callSettings);
            return _callBatchSearchDataObjects.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch searches data objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchSearchDataObjectsResponse> BatchSearchDataObjectsAsync(BatchSearchDataObjectsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchSearchDataObjectsRequest(ref request, ref callSettings);
            return _callBatchSearchDataObjects.Async(request, callSettings);
        }
    }

    public partial class SearchDataObjectsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class QueryDataObjectsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchDataObjectsResponse : gaxgrpc::IPageResponse<SearchResult>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<SearchResult> GetEnumerator() => Results.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class QueryDataObjectsResponse : gaxgrpc::IPageResponse<DataObject>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DataObject> GetEnumerator() => DataObjects.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class DataObjectSearchService
    {
        public partial class DataObjectSearchServiceClient
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
