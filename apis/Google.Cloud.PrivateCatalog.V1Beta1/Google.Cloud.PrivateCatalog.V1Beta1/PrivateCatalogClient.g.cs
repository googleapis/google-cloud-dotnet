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

namespace Google.Cloud.PrivateCatalog.V1Beta1
{
    /// <summary>Settings for <see cref="PrivateCatalogClient"/> instances.</summary>
    public sealed partial class PrivateCatalogSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="PrivateCatalogSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="PrivateCatalogSettings"/>.</returns>
        public static PrivateCatalogSettings GetDefault() => new PrivateCatalogSettings();

        /// <summary>Constructs a new <see cref="PrivateCatalogSettings"/> object with default settings.</summary>
        public PrivateCatalogSettings()
        {
        }

        private PrivateCatalogSettings(PrivateCatalogSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            SearchCatalogsSettings = existing.SearchCatalogsSettings;
            SearchProductsSettings = existing.SearchProductsSettings;
            SearchVersionsSettings = existing.SearchVersionsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(PrivateCatalogSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PrivateCatalogClient.SearchCatalogs</c> and <c>PrivateCatalogClient.SearchCatalogsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchCatalogsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PrivateCatalogClient.SearchProducts</c> and <c>PrivateCatalogClient.SearchProductsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchProductsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PrivateCatalogClient.SearchVersions</c> and <c>PrivateCatalogClient.SearchVersionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchVersionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="PrivateCatalogSettings"/> object.</returns>
        public PrivateCatalogSettings Clone() => new PrivateCatalogSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PrivateCatalogClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class PrivateCatalogClientBuilder : gaxgrpc::ClientBuilderBase<PrivateCatalogClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public PrivateCatalogSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public PrivateCatalogClientBuilder() : base(PrivateCatalogClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref PrivateCatalogClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<PrivateCatalogClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override PrivateCatalogClient Build()
        {
            PrivateCatalogClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<PrivateCatalogClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<PrivateCatalogClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private PrivateCatalogClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PrivateCatalogClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<PrivateCatalogClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PrivateCatalogClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => PrivateCatalogClient.ChannelPool;
    }

    /// <summary>PrivateCatalog client wrapper, for convenient use.</summary>
    /// <remarks>
    /// `PrivateCatalog` allows catalog consumers to retrieve `Catalog`, `Product`
    /// and `Version` resources under a target resource context.
    /// 
    /// `Catalog` is computed based on the [Association][]s linked to the target
    /// resource and its ancestors. Each association's
    /// [google.cloud.privatecatalogproducer.v1beta.Catalog][] is transformed into a
    /// `Catalog`. If multiple associations have the same parent
    /// [google.cloud.privatecatalogproducer.v1beta.Catalog][], they are
    /// de-duplicated into one `Catalog`. Users must have
    /// `cloudprivatecatalog.catalogTargets.get` IAM permission on the resource
    /// context in order to access catalogs. `Catalog` contains the resource name and
    /// a subset of data of the original
    /// [google.cloud.privatecatalogproducer.v1beta.Catalog][].
    /// 
    /// `Product` is child resource of the catalog. A `Product` contains the resource
    /// name and a subset of the data of the original
    /// [google.cloud.privatecatalogproducer.v1beta.Product][].
    /// 
    /// `Version` is child resource of the product. A `Version` contains the resource
    /// name and a subset of the data of the original
    /// [google.cloud.privatecatalogproducer.v1beta.Version][].
    /// </remarks>
    public abstract partial class PrivateCatalogClient
    {
        /// <summary>
        /// The default endpoint for the PrivateCatalog service, which is a host of "cloudprivatecatalog.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudprivatecatalog.googleapis.com:443";

        /// <summary>The default PrivateCatalog scopes.</summary>
        /// <remarks>
        /// The default PrivateCatalog scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(PrivateCatalog.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="PrivateCatalogClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="PrivateCatalogClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="PrivateCatalogClient"/>.</returns>
        public static stt::Task<PrivateCatalogClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new PrivateCatalogClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="PrivateCatalogClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="PrivateCatalogClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="PrivateCatalogClient"/>.</returns>
        public static PrivateCatalogClient Create() => new PrivateCatalogClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="PrivateCatalogClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="PrivateCatalogSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="PrivateCatalogClient"/>.</returns>
        internal static PrivateCatalogClient Create(grpccore::CallInvoker callInvoker, PrivateCatalogSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            PrivateCatalog.PrivateCatalogClient grpcClient = new PrivateCatalog.PrivateCatalogClient(callInvoker);
            return new PrivateCatalogClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC PrivateCatalog client</summary>
        public virtual PrivateCatalog.PrivateCatalogClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Search [Catalog][google.cloud.privatecatalog.v1beta1.Catalog] resources that consumers have access to, within the
        /// scope of the consumer cloud resource hierarchy context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Catalog"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchCatalogsResponse, Catalog> SearchCatalogs(SearchCatalogsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Search [Catalog][google.cloud.privatecatalog.v1beta1.Catalog] resources that consumers have access to, within the
        /// scope of the consumer cloud resource hierarchy context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Catalog"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchCatalogsResponse, Catalog> SearchCatalogsAsync(SearchCatalogsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Search [Product][google.cloud.privatecatalog.v1beta1.Product] resources that consumers have access to, within the
        /// scope of the consumer cloud resource hierarchy context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Product"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchProductsResponse, Product> SearchProducts(SearchProductsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Search [Product][google.cloud.privatecatalog.v1beta1.Product] resources that consumers have access to, within the
        /// scope of the consumer cloud resource hierarchy context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Product"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchProductsResponse, Product> SearchProductsAsync(SearchProductsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Search [Version][google.cloud.privatecatalog.v1beta1.Version] resources that consumers have access to, within the
        /// scope of the consumer cloud resource hierarchy context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Version"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchVersionsResponse, Version> SearchVersions(SearchVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Search [Version][google.cloud.privatecatalog.v1beta1.Version] resources that consumers have access to, within the
        /// scope of the consumer cloud resource hierarchy context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Version"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchVersionsResponse, Version> SearchVersionsAsync(SearchVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();
    }

    /// <summary>PrivateCatalog client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// `PrivateCatalog` allows catalog consumers to retrieve `Catalog`, `Product`
    /// and `Version` resources under a target resource context.
    /// 
    /// `Catalog` is computed based on the [Association][]s linked to the target
    /// resource and its ancestors. Each association's
    /// [google.cloud.privatecatalogproducer.v1beta.Catalog][] is transformed into a
    /// `Catalog`. If multiple associations have the same parent
    /// [google.cloud.privatecatalogproducer.v1beta.Catalog][], they are
    /// de-duplicated into one `Catalog`. Users must have
    /// `cloudprivatecatalog.catalogTargets.get` IAM permission on the resource
    /// context in order to access catalogs. `Catalog` contains the resource name and
    /// a subset of data of the original
    /// [google.cloud.privatecatalogproducer.v1beta.Catalog][].
    /// 
    /// `Product` is child resource of the catalog. A `Product` contains the resource
    /// name and a subset of the data of the original
    /// [google.cloud.privatecatalogproducer.v1beta.Product][].
    /// 
    /// `Version` is child resource of the product. A `Version` contains the resource
    /// name and a subset of the data of the original
    /// [google.cloud.privatecatalogproducer.v1beta.Version][].
    /// </remarks>
    public sealed partial class PrivateCatalogClientImpl : PrivateCatalogClient
    {
        private readonly gaxgrpc::ApiCall<SearchCatalogsRequest, SearchCatalogsResponse> _callSearchCatalogs;

        private readonly gaxgrpc::ApiCall<SearchProductsRequest, SearchProductsResponse> _callSearchProducts;

        private readonly gaxgrpc::ApiCall<SearchVersionsRequest, SearchVersionsResponse> _callSearchVersions;

        /// <summary>
        /// Constructs a client wrapper for the PrivateCatalog service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="PrivateCatalogSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public PrivateCatalogClientImpl(PrivateCatalog.PrivateCatalogClient grpcClient, PrivateCatalogSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            PrivateCatalogSettings effectiveSettings = settings ?? PrivateCatalogSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callSearchCatalogs = clientHelper.BuildApiCall<SearchCatalogsRequest, SearchCatalogsResponse>("SearchCatalogs", grpcClient.SearchCatalogsAsync, grpcClient.SearchCatalogs, effectiveSettings.SearchCatalogsSettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSearchCatalogs);
            Modify_SearchCatalogsApiCall(ref _callSearchCatalogs);
            _callSearchProducts = clientHelper.BuildApiCall<SearchProductsRequest, SearchProductsResponse>("SearchProducts", grpcClient.SearchProductsAsync, grpcClient.SearchProducts, effectiveSettings.SearchProductsSettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSearchProducts);
            Modify_SearchProductsApiCall(ref _callSearchProducts);
            _callSearchVersions = clientHelper.BuildApiCall<SearchVersionsRequest, SearchVersionsResponse>("SearchVersions", grpcClient.SearchVersionsAsync, grpcClient.SearchVersions, effectiveSettings.SearchVersionsSettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSearchVersions);
            Modify_SearchVersionsApiCall(ref _callSearchVersions);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_SearchCatalogsApiCall(ref gaxgrpc::ApiCall<SearchCatalogsRequest, SearchCatalogsResponse> call);

        partial void Modify_SearchProductsApiCall(ref gaxgrpc::ApiCall<SearchProductsRequest, SearchProductsResponse> call);

        partial void Modify_SearchVersionsApiCall(ref gaxgrpc::ApiCall<SearchVersionsRequest, SearchVersionsResponse> call);

        partial void OnConstruction(PrivateCatalog.PrivateCatalogClient grpcClient, PrivateCatalogSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC PrivateCatalog client</summary>
        public override PrivateCatalog.PrivateCatalogClient GrpcClient { get; }

        partial void Modify_SearchCatalogsRequest(ref SearchCatalogsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchProductsRequest(ref SearchProductsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchVersionsRequest(ref SearchVersionsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Search [Catalog][google.cloud.privatecatalog.v1beta1.Catalog] resources that consumers have access to, within the
        /// scope of the consumer cloud resource hierarchy context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Catalog"/> resources.</returns>
        public override gax::PagedEnumerable<SearchCatalogsResponse, Catalog> SearchCatalogs(SearchCatalogsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchCatalogsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchCatalogsRequest, SearchCatalogsResponse, Catalog>(_callSearchCatalogs, request, callSettings);
        }

        /// <summary>
        /// Search [Catalog][google.cloud.privatecatalog.v1beta1.Catalog] resources that consumers have access to, within the
        /// scope of the consumer cloud resource hierarchy context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Catalog"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchCatalogsResponse, Catalog> SearchCatalogsAsync(SearchCatalogsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchCatalogsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchCatalogsRequest, SearchCatalogsResponse, Catalog>(_callSearchCatalogs, request, callSettings);
        }

        /// <summary>
        /// Search [Product][google.cloud.privatecatalog.v1beta1.Product] resources that consumers have access to, within the
        /// scope of the consumer cloud resource hierarchy context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Product"/> resources.</returns>
        public override gax::PagedEnumerable<SearchProductsResponse, Product> SearchProducts(SearchProductsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchProductsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchProductsRequest, SearchProductsResponse, Product>(_callSearchProducts, request, callSettings);
        }

        /// <summary>
        /// Search [Product][google.cloud.privatecatalog.v1beta1.Product] resources that consumers have access to, within the
        /// scope of the consumer cloud resource hierarchy context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Product"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchProductsResponse, Product> SearchProductsAsync(SearchProductsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchProductsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchProductsRequest, SearchProductsResponse, Product>(_callSearchProducts, request, callSettings);
        }

        /// <summary>
        /// Search [Version][google.cloud.privatecatalog.v1beta1.Version] resources that consumers have access to, within the
        /// scope of the consumer cloud resource hierarchy context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Version"/> resources.</returns>
        public override gax::PagedEnumerable<SearchVersionsResponse, Version> SearchVersions(SearchVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchVersionsRequest, SearchVersionsResponse, Version>(_callSearchVersions, request, callSettings);
        }

        /// <summary>
        /// Search [Version][google.cloud.privatecatalog.v1beta1.Version] resources that consumers have access to, within the
        /// scope of the consumer cloud resource hierarchy context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Version"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchVersionsResponse, Version> SearchVersionsAsync(SearchVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchVersionsRequest, SearchVersionsResponse, Version>(_callSearchVersions, request, callSettings);
        }
    }

    public partial class SearchCatalogsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchProductsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchVersionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchCatalogsResponse : gaxgrpc::IPageResponse<Catalog>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Catalog> GetEnumerator() => Catalogs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class SearchProductsResponse : gaxgrpc::IPageResponse<Product>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Product> GetEnumerator() => Products.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class SearchVersionsResponse : gaxgrpc::IPageResponse<Version>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Version> GetEnumerator() => Versions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
