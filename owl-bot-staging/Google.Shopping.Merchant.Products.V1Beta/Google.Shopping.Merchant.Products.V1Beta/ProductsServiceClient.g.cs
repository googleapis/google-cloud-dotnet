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

namespace Google.Shopping.Merchant.Products.V1Beta
{
    /// <summary>Settings for <see cref="ProductsServiceClient"/> instances.</summary>
    public sealed partial class ProductsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ProductsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ProductsServiceSettings"/>.</returns>
        public static ProductsServiceSettings GetDefault() => new ProductsServiceSettings();

        /// <summary>Constructs a new <see cref="ProductsServiceSettings"/> object with default settings.</summary>
        public ProductsServiceSettings()
        {
        }

        private ProductsServiceSettings(ProductsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetProductSettings = existing.GetProductSettings;
            ListProductsSettings = existing.ListProductsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ProductsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductsServiceClient.GetProduct</c> and <c>ProductsServiceClient.GetProductAsync</c>.
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
        public gaxgrpc::CallSettings GetProductSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductsServiceClient.ListProducts</c> and <c>ProductsServiceClient.ListProductsAsync</c>.
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
        public gaxgrpc::CallSettings ListProductsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ProductsServiceSettings"/> object.</returns>
        public ProductsServiceSettings Clone() => new ProductsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ProductsServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class ProductsServiceClientBuilder : gaxgrpc::ClientBuilderBase<ProductsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ProductsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ProductsServiceClientBuilder() : base(ProductsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ProductsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ProductsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ProductsServiceClient Build()
        {
            ProductsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ProductsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ProductsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ProductsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ProductsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ProductsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ProductsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ProductsServiceClient.ChannelPool;
    }

    /// <summary>ProductsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to use Product resource.
    /// This service works for products with online channel only.
    /// </remarks>
    public abstract partial class ProductsServiceClient
    {
        /// <summary>
        /// The default endpoint for the ProductsService service, which is a host of "merchantapi.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "merchantapi.googleapis.com:443";

        /// <summary>The default ProductsService scopes.</summary>
        /// <remarks>
        /// The default ProductsService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ProductsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ProductsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ProductsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ProductsServiceClient"/>.</returns>
        public static stt::Task<ProductsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ProductsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ProductsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ProductsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ProductsServiceClient"/>.</returns>
        public static ProductsServiceClient Create() => new ProductsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ProductsServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ProductsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ProductsServiceClient"/>.</returns>
        internal static ProductsServiceClient Create(grpccore::CallInvoker callInvoker, ProductsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ProductsService.ProductsServiceClient grpcClient = new ProductsService.ProductsServiceClient(callInvoker);
            return new ProductsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ProductsService client</summary>
        public virtual ProductsService.ProductsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the processed product from your Merchant Center account.
        /// 
        /// After inserting, updating, or deleting a product input, it may take several
        /// minutes before the updated final product can be retrieved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Product GetProduct(GetProductRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the processed product from your Merchant Center account.
        /// 
        /// After inserting, updating, or deleting a product input, it may take several
        /// minutes before the updated final product can be retrieved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> GetProductAsync(GetProductRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the processed product from your Merchant Center account.
        /// 
        /// After inserting, updating, or deleting a product input, it may take several
        /// minutes before the updated final product can be retrieved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> GetProductAsync(GetProductRequest request, st::CancellationToken cancellationToken) =>
            GetProductAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the processed product from your Merchant Center account.
        /// 
        /// After inserting, updating, or deleting a product input, it may take several
        /// minutes before the updated final product can be retrieved.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the product to retrieve.
        /// Format: `accounts/{account}/products/{product}`
        /// where the last section `product` consists of 4 parts:
        /// channel~content_language~feed_label~offer_id
        /// example for product name is
        /// "accounts/123/products/online~en~US~sku123"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Product GetProduct(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProduct(new GetProductRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the processed product from your Merchant Center account.
        /// 
        /// After inserting, updating, or deleting a product input, it may take several
        /// minutes before the updated final product can be retrieved.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the product to retrieve.
        /// Format: `accounts/{account}/products/{product}`
        /// where the last section `product` consists of 4 parts:
        /// channel~content_language~feed_label~offer_id
        /// example for product name is
        /// "accounts/123/products/online~en~US~sku123"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> GetProductAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProductAsync(new GetProductRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the processed product from your Merchant Center account.
        /// 
        /// After inserting, updating, or deleting a product input, it may take several
        /// minutes before the updated final product can be retrieved.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the product to retrieve.
        /// Format: `accounts/{account}/products/{product}`
        /// where the last section `product` consists of 4 parts:
        /// channel~content_language~feed_label~offer_id
        /// example for product name is
        /// "accounts/123/products/online~en~US~sku123"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> GetProductAsync(string name, st::CancellationToken cancellationToken) =>
            GetProductAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the processed product from your Merchant Center account.
        /// 
        /// After inserting, updating, or deleting a product input, it may take several
        /// minutes before the updated final product can be retrieved.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the product to retrieve.
        /// Format: `accounts/{account}/products/{product}`
        /// where the last section `product` consists of 4 parts:
        /// channel~content_language~feed_label~offer_id
        /// example for product name is
        /// "accounts/123/products/online~en~US~sku123"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Product GetProduct(ProductName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProduct(new GetProductRequest
            {
                ProductName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the processed product from your Merchant Center account.
        /// 
        /// After inserting, updating, or deleting a product input, it may take several
        /// minutes before the updated final product can be retrieved.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the product to retrieve.
        /// Format: `accounts/{account}/products/{product}`
        /// where the last section `product` consists of 4 parts:
        /// channel~content_language~feed_label~offer_id
        /// example for product name is
        /// "accounts/123/products/online~en~US~sku123"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> GetProductAsync(ProductName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProductAsync(new GetProductRequest
            {
                ProductName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the processed product from your Merchant Center account.
        /// 
        /// After inserting, updating, or deleting a product input, it may take several
        /// minutes before the updated final product can be retrieved.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the product to retrieve.
        /// Format: `accounts/{account}/products/{product}`
        /// where the last section `product` consists of 4 parts:
        /// channel~content_language~feed_label~offer_id
        /// example for product name is
        /// "accounts/123/products/online~en~US~sku123"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> GetProductAsync(ProductName name, st::CancellationToken cancellationToken) =>
            GetProductAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the processed products in your Merchant Center account. The response
        /// might contain fewer items than specified by pageSize. Rely on pageToken to
        /// determine if there are more items to be requested.
        /// 
        /// After inserting, updating, or deleting a product input, it may take several
        /// minutes before the updated processed product can be retrieved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Product"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProductsResponse, Product> ListProducts(ListProductsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the processed products in your Merchant Center account. The response
        /// might contain fewer items than specified by pageSize. Rely on pageToken to
        /// determine if there are more items to be requested.
        /// 
        /// After inserting, updating, or deleting a product input, it may take several
        /// minutes before the updated processed product can be retrieved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Product"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProductsResponse, Product> ListProductsAsync(ListProductsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the processed products in your Merchant Center account. The response
        /// might contain fewer items than specified by pageSize. Rely on pageToken to
        /// determine if there are more items to be requested.
        /// 
        /// After inserting, updating, or deleting a product input, it may take several
        /// minutes before the updated processed product can be retrieved.
        /// </summary>
        /// <param name="parent">
        /// Required. The account to list processed products for.
        /// Format: accounts/{account}
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
        /// <returns>A pageable sequence of <see cref="Product"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProductsResponse, Product> ListProducts(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProductsRequest request = new ListProductsRequest
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
            return ListProducts(request, callSettings);
        }

        /// <summary>
        /// Lists the processed products in your Merchant Center account. The response
        /// might contain fewer items than specified by pageSize. Rely on pageToken to
        /// determine if there are more items to be requested.
        /// 
        /// After inserting, updating, or deleting a product input, it may take several
        /// minutes before the updated processed product can be retrieved.
        /// </summary>
        /// <param name="parent">
        /// Required. The account to list processed products for.
        /// Format: accounts/{account}
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
        /// <returns>A pageable asynchronous sequence of <see cref="Product"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProductsResponse, Product> ListProductsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProductsRequest request = new ListProductsRequest
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
            return ListProductsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the processed products in your Merchant Center account. The response
        /// might contain fewer items than specified by pageSize. Rely on pageToken to
        /// determine if there are more items to be requested.
        /// 
        /// After inserting, updating, or deleting a product input, it may take several
        /// minutes before the updated processed product can be retrieved.
        /// </summary>
        /// <param name="parent">
        /// Required. The account to list processed products for.
        /// Format: accounts/{account}
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
        /// <returns>A pageable sequence of <see cref="Product"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProductsResponse, Product> ListProducts(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProductsRequest request = new ListProductsRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListProducts(request, callSettings);
        }

        /// <summary>
        /// Lists the processed products in your Merchant Center account. The response
        /// might contain fewer items than specified by pageSize. Rely on pageToken to
        /// determine if there are more items to be requested.
        /// 
        /// After inserting, updating, or deleting a product input, it may take several
        /// minutes before the updated processed product can be retrieved.
        /// </summary>
        /// <param name="parent">
        /// Required. The account to list processed products for.
        /// Format: accounts/{account}
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
        /// <returns>A pageable asynchronous sequence of <see cref="Product"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProductsResponse, Product> ListProductsAsync(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProductsRequest request = new ListProductsRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListProductsAsync(request, callSettings);
        }
    }

    /// <summary>ProductsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to use Product resource.
    /// This service works for products with online channel only.
    /// </remarks>
    public sealed partial class ProductsServiceClientImpl : ProductsServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetProductRequest, Product> _callGetProduct;

        private readonly gaxgrpc::ApiCall<ListProductsRequest, ListProductsResponse> _callListProducts;

        /// <summary>
        /// Constructs a client wrapper for the ProductsService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ProductsServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ProductsServiceClientImpl(ProductsService.ProductsServiceClient grpcClient, ProductsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ProductsServiceSettings effectiveSettings = settings ?? ProductsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetProduct = clientHelper.BuildApiCall<GetProductRequest, Product>("GetProduct", grpcClient.GetProductAsync, grpcClient.GetProduct, effectiveSettings.GetProductSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetProduct);
            Modify_GetProductApiCall(ref _callGetProduct);
            _callListProducts = clientHelper.BuildApiCall<ListProductsRequest, ListProductsResponse>("ListProducts", grpcClient.ListProductsAsync, grpcClient.ListProducts, effectiveSettings.ListProductsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListProducts);
            Modify_ListProductsApiCall(ref _callListProducts);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetProductApiCall(ref gaxgrpc::ApiCall<GetProductRequest, Product> call);

        partial void Modify_ListProductsApiCall(ref gaxgrpc::ApiCall<ListProductsRequest, ListProductsResponse> call);

        partial void OnConstruction(ProductsService.ProductsServiceClient grpcClient, ProductsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ProductsService client</summary>
        public override ProductsService.ProductsServiceClient GrpcClient { get; }

        partial void Modify_GetProductRequest(ref GetProductRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListProductsRequest(ref ListProductsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves the processed product from your Merchant Center account.
        /// 
        /// After inserting, updating, or deleting a product input, it may take several
        /// minutes before the updated final product can be retrieved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Product GetProduct(GetProductRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProductRequest(ref request, ref callSettings);
            return _callGetProduct.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the processed product from your Merchant Center account.
        /// 
        /// After inserting, updating, or deleting a product input, it may take several
        /// minutes before the updated final product can be retrieved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Product> GetProductAsync(GetProductRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProductRequest(ref request, ref callSettings);
            return _callGetProduct.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the processed products in your Merchant Center account. The response
        /// might contain fewer items than specified by pageSize. Rely on pageToken to
        /// determine if there are more items to be requested.
        /// 
        /// After inserting, updating, or deleting a product input, it may take several
        /// minutes before the updated processed product can be retrieved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Product"/> resources.</returns>
        public override gax::PagedEnumerable<ListProductsResponse, Product> ListProducts(ListProductsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProductsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListProductsRequest, ListProductsResponse, Product>(_callListProducts, request, callSettings);
        }

        /// <summary>
        /// Lists the processed products in your Merchant Center account. The response
        /// might contain fewer items than specified by pageSize. Rely on pageToken to
        /// determine if there are more items to be requested.
        /// 
        /// After inserting, updating, or deleting a product input, it may take several
        /// minutes before the updated processed product can be retrieved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Product"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListProductsResponse, Product> ListProductsAsync(ListProductsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProductsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListProductsRequest, ListProductsResponse, Product>(_callListProducts, request, callSettings);
        }
    }

    public partial class ListProductsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListProductsResponse : gaxgrpc::IPageResponse<Product>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Product> GetEnumerator() => Products.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
