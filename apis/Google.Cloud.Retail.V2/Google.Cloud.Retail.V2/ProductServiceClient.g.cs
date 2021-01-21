// Copyright 2021 Google LLC
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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Retail.V2
{
    /// <summary>Settings for <see cref="ProductServiceClient"/> instances.</summary>
    public sealed partial class ProductServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ProductServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ProductServiceSettings"/>.</returns>
        public static ProductServiceSettings GetDefault() => new ProductServiceSettings();

        /// <summary>Constructs a new <see cref="ProductServiceSettings"/> object with default settings.</summary>
        public ProductServiceSettings()
        {
        }

        private ProductServiceSettings(ProductServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateProductSettings = existing.CreateProductSettings;
            GetProductSettings = existing.GetProductSettings;
            UpdateProductSettings = existing.UpdateProductSettings;
            DeleteProductSettings = existing.DeleteProductSettings;
            ImportProductsSettings = existing.ImportProductsSettings;
            ImportProductsOperationsSettings = existing.ImportProductsOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(ProductServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductServiceClient.CreateProduct</c> and <c>ProductServiceClient.CreateProductAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateProductSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductServiceClient.GetProduct</c> and <c>ProductServiceClient.GetProductAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetProductSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductServiceClient.UpdateProduct</c> and <c>ProductServiceClient.UpdateProductAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateProductSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductServiceClient.DeleteProduct</c> and <c>ProductServiceClient.DeleteProductAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteProductSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductServiceClient.ImportProducts</c> and <c>ProductServiceClient.ImportProductsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ImportProductsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ProductServiceClient.ImportProducts</c> and
        /// <c>ProductServiceClient.ImportProductsAsync</c>.
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
        public lro::OperationsSettings ImportProductsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ProductServiceSettings"/> object.</returns>
        public ProductServiceSettings Clone() => new ProductServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ProductServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class ProductServiceClientBuilder : gaxgrpc::ClientBuilderBase<ProductServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ProductServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref ProductServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ProductServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ProductServiceClient Build()
        {
            ProductServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ProductServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ProductServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ProductServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ProductServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<ProductServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ProductServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => ProductServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => ProductServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ProductServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>ProductService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for ingesting [Product][google.cloud.retail.v2.Product] information
    /// of the customer's website.
    /// </remarks>
    public abstract partial class ProductServiceClient
    {
        /// <summary>
        /// The default endpoint for the ProductService service, which is a host of "retail.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "retail.googleapis.com:443";

        /// <summary>The default ProductService scopes.</summary>
        /// <remarks>
        /// The default ProductService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="ProductServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ProductServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ProductServiceClient"/>.</returns>
        public static stt::Task<ProductServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ProductServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ProductServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ProductServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ProductServiceClient"/>.</returns>
        public static ProductServiceClient Create() => new ProductServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ProductServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ProductServiceSettings"/>.</param>
        /// <returns>The created <see cref="ProductServiceClient"/>.</returns>
        internal static ProductServiceClient Create(grpccore::CallInvoker callInvoker, ProductServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ProductService.ProductServiceClient grpcClient = new ProductService.ProductServiceClient(callInvoker);
            return new ProductServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC ProductService client</summary>
        public virtual ProductService.ProductServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Product CreateProduct(CreateProductRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> CreateProductAsync(CreateProductRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> CreateProductAsync(CreateProductRequest request, st::CancellationToken cancellationToken) =>
            CreateProductAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent catalog resource name, such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch`.
        /// </param>
        /// <param name="product">
        /// Required. The [Product][google.cloud.retail.v2.Product] to create.
        /// </param>
        /// <param name="productId">
        /// Required. The ID to use for the [Product][google.cloud.retail.v2.Product],
        /// which will become the final component of the
        /// [Product.name][google.cloud.retail.v2.Product.name].
        /// 
        /// If the caller does not have permission to create the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// This field must be unique among all
        /// [Product][google.cloud.retail.v2.Product]s with the same
        /// [parent][google.cloud.retail.v2.CreateProductRequest.parent]. Otherwise, an
        /// ALREADY_EXISTS error is returned.
        /// 
        /// This field must be a UTF-8 encoded string with a length limit of 128
        /// characters. Otherwise, an INVALID_ARGUMENT error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Product CreateProduct(string parent, Product product, string productId, gaxgrpc::CallSettings callSettings = null) =>
            CreateProduct(new CreateProductRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Product = gax::GaxPreconditions.CheckNotNull(product, nameof(product)),
                ProductId = gax::GaxPreconditions.CheckNotNullOrEmpty(productId, nameof(productId)),
            }, callSettings);

        /// <summary>
        /// Creates a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent catalog resource name, such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch`.
        /// </param>
        /// <param name="product">
        /// Required. The [Product][google.cloud.retail.v2.Product] to create.
        /// </param>
        /// <param name="productId">
        /// Required. The ID to use for the [Product][google.cloud.retail.v2.Product],
        /// which will become the final component of the
        /// [Product.name][google.cloud.retail.v2.Product.name].
        /// 
        /// If the caller does not have permission to create the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// This field must be unique among all
        /// [Product][google.cloud.retail.v2.Product]s with the same
        /// [parent][google.cloud.retail.v2.CreateProductRequest.parent]. Otherwise, an
        /// ALREADY_EXISTS error is returned.
        /// 
        /// This field must be a UTF-8 encoded string with a length limit of 128
        /// characters. Otherwise, an INVALID_ARGUMENT error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> CreateProductAsync(string parent, Product product, string productId, gaxgrpc::CallSettings callSettings = null) =>
            CreateProductAsync(new CreateProductRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Product = gax::GaxPreconditions.CheckNotNull(product, nameof(product)),
                ProductId = gax::GaxPreconditions.CheckNotNullOrEmpty(productId, nameof(productId)),
            }, callSettings);

        /// <summary>
        /// Creates a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent catalog resource name, such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch`.
        /// </param>
        /// <param name="product">
        /// Required. The [Product][google.cloud.retail.v2.Product] to create.
        /// </param>
        /// <param name="productId">
        /// Required. The ID to use for the [Product][google.cloud.retail.v2.Product],
        /// which will become the final component of the
        /// [Product.name][google.cloud.retail.v2.Product.name].
        /// 
        /// If the caller does not have permission to create the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// This field must be unique among all
        /// [Product][google.cloud.retail.v2.Product]s with the same
        /// [parent][google.cloud.retail.v2.CreateProductRequest.parent]. Otherwise, an
        /// ALREADY_EXISTS error is returned.
        /// 
        /// This field must be a UTF-8 encoded string with a length limit of 128
        /// characters. Otherwise, an INVALID_ARGUMENT error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> CreateProductAsync(string parent, Product product, string productId, st::CancellationToken cancellationToken) =>
            CreateProductAsync(parent, product, productId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent catalog resource name, such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch`.
        /// </param>
        /// <param name="product">
        /// Required. The [Product][google.cloud.retail.v2.Product] to create.
        /// </param>
        /// <param name="productId">
        /// Required. The ID to use for the [Product][google.cloud.retail.v2.Product],
        /// which will become the final component of the
        /// [Product.name][google.cloud.retail.v2.Product.name].
        /// 
        /// If the caller does not have permission to create the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// This field must be unique among all
        /// [Product][google.cloud.retail.v2.Product]s with the same
        /// [parent][google.cloud.retail.v2.CreateProductRequest.parent]. Otherwise, an
        /// ALREADY_EXISTS error is returned.
        /// 
        /// This field must be a UTF-8 encoded string with a length limit of 128
        /// characters. Otherwise, an INVALID_ARGUMENT error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Product CreateProduct(BranchName parent, Product product, string productId, gaxgrpc::CallSettings callSettings = null) =>
            CreateProduct(new CreateProductRequest
            {
                ParentAsBranchName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Product = gax::GaxPreconditions.CheckNotNull(product, nameof(product)),
                ProductId = gax::GaxPreconditions.CheckNotNullOrEmpty(productId, nameof(productId)),
            }, callSettings);

        /// <summary>
        /// Creates a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent catalog resource name, such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch`.
        /// </param>
        /// <param name="product">
        /// Required. The [Product][google.cloud.retail.v2.Product] to create.
        /// </param>
        /// <param name="productId">
        /// Required. The ID to use for the [Product][google.cloud.retail.v2.Product],
        /// which will become the final component of the
        /// [Product.name][google.cloud.retail.v2.Product.name].
        /// 
        /// If the caller does not have permission to create the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// This field must be unique among all
        /// [Product][google.cloud.retail.v2.Product]s with the same
        /// [parent][google.cloud.retail.v2.CreateProductRequest.parent]. Otherwise, an
        /// ALREADY_EXISTS error is returned.
        /// 
        /// This field must be a UTF-8 encoded string with a length limit of 128
        /// characters. Otherwise, an INVALID_ARGUMENT error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> CreateProductAsync(BranchName parent, Product product, string productId, gaxgrpc::CallSettings callSettings = null) =>
            CreateProductAsync(new CreateProductRequest
            {
                ParentAsBranchName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Product = gax::GaxPreconditions.CheckNotNull(product, nameof(product)),
                ProductId = gax::GaxPreconditions.CheckNotNullOrEmpty(productId, nameof(productId)),
            }, callSettings);

        /// <summary>
        /// Creates a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent catalog resource name, such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch`.
        /// </param>
        /// <param name="product">
        /// Required. The [Product][google.cloud.retail.v2.Product] to create.
        /// </param>
        /// <param name="productId">
        /// Required. The ID to use for the [Product][google.cloud.retail.v2.Product],
        /// which will become the final component of the
        /// [Product.name][google.cloud.retail.v2.Product.name].
        /// 
        /// If the caller does not have permission to create the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// This field must be unique among all
        /// [Product][google.cloud.retail.v2.Product]s with the same
        /// [parent][google.cloud.retail.v2.CreateProductRequest.parent]. Otherwise, an
        /// ALREADY_EXISTS error is returned.
        /// 
        /// This field must be a UTF-8 encoded string with a length limit of 128
        /// characters. Otherwise, an INVALID_ARGUMENT error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> CreateProductAsync(BranchName parent, Product product, string productId, st::CancellationToken cancellationToken) =>
            CreateProductAsync(parent, product, productId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Product GetProduct(GetProductRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> GetProductAsync(GetProductRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> GetProductAsync(GetProductRequest request, st::CancellationToken cancellationToken) =>
            GetProductAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to access the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the requested [Product][google.cloud.retail.v2.Product] does not exist,
        /// a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Product GetProduct(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProduct(new GetProductRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to access the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the requested [Product][google.cloud.retail.v2.Product] does not exist,
        /// a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> GetProductAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProductAsync(new GetProductRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to access the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the requested [Product][google.cloud.retail.v2.Product] does not exist,
        /// a NOT_FOUND error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> GetProductAsync(string name, st::CancellationToken cancellationToken) =>
            GetProductAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to access the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the requested [Product][google.cloud.retail.v2.Product] does not exist,
        /// a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Product GetProduct(ProductName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProduct(new GetProductRequest
            {
                ProductName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to access the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the requested [Product][google.cloud.retail.v2.Product] does not exist,
        /// a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> GetProductAsync(ProductName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProductAsync(new GetProductRequest
            {
                ProductName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to access the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the requested [Product][google.cloud.retail.v2.Product] does not exist,
        /// a NOT_FOUND error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> GetProductAsync(ProductName name, st::CancellationToken cancellationToken) =>
            GetProductAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Product UpdateProduct(UpdateProductRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> UpdateProductAsync(UpdateProductRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> UpdateProductAsync(UpdateProductRequest request, st::CancellationToken cancellationToken) =>
            UpdateProductAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="product">
        /// Required. The product to update/create.
        /// 
        /// If the caller does not have permission to update the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [Product][google.cloud.retail.v2.Product] to update does not exist,
        /// a NOT_FOUND error is returned.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided
        /// [Product][google.cloud.retail.v2.Product] to update. The immutable and
        /// output only fields are NOT supported. If not set, all supported fields (the
        /// fields that are neither immutable nor output only) are updated.
        /// 
        /// If an unsupported or unknown field is provided, an INVALID_ARGUMENT error
        /// is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Product UpdateProduct(Product product, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateProduct(new UpdateProductRequest
            {
                Product = gax::GaxPreconditions.CheckNotNull(product, nameof(product)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="product">
        /// Required. The product to update/create.
        /// 
        /// If the caller does not have permission to update the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [Product][google.cloud.retail.v2.Product] to update does not exist,
        /// a NOT_FOUND error is returned.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided
        /// [Product][google.cloud.retail.v2.Product] to update. The immutable and
        /// output only fields are NOT supported. If not set, all supported fields (the
        /// fields that are neither immutable nor output only) are updated.
        /// 
        /// If an unsupported or unknown field is provided, an INVALID_ARGUMENT error
        /// is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> UpdateProductAsync(Product product, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateProductAsync(new UpdateProductRequest
            {
                Product = gax::GaxPreconditions.CheckNotNull(product, nameof(product)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="product">
        /// Required. The product to update/create.
        /// 
        /// If the caller does not have permission to update the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [Product][google.cloud.retail.v2.Product] to update does not exist,
        /// a NOT_FOUND error is returned.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided
        /// [Product][google.cloud.retail.v2.Product] to update. The immutable and
        /// output only fields are NOT supported. If not set, all supported fields (the
        /// fields that are neither immutable nor output only) are updated.
        /// 
        /// If an unsupported or unknown field is provided, an INVALID_ARGUMENT error
        /// is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> UpdateProductAsync(Product product, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateProductAsync(product, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteProduct(DeleteProductRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteProductAsync(DeleteProductRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteProductAsync(DeleteProductRequest request, st::CancellationToken cancellationToken) =>
            DeleteProductAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to delete the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [Product][google.cloud.retail.v2.Product] to delete does not exist,
        /// a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteProduct(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProduct(new DeleteProductRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to delete the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [Product][google.cloud.retail.v2.Product] to delete does not exist,
        /// a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteProductAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProductAsync(new DeleteProductRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to delete the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [Product][google.cloud.retail.v2.Product] to delete does not exist,
        /// a NOT_FOUND error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteProductAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteProductAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to delete the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [Product][google.cloud.retail.v2.Product] to delete does not exist,
        /// a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteProduct(ProductName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProduct(new DeleteProductRequest
            {
                ProductName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to delete the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [Product][google.cloud.retail.v2.Product] to delete does not exist,
        /// a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteProductAsync(ProductName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProductAsync(new DeleteProductRequest
            {
                ProductName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to delete the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [Product][google.cloud.retail.v2.Product] to delete does not exist,
        /// a NOT_FOUND error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteProductAsync(ProductName name, st::CancellationToken cancellationToken) =>
            DeleteProductAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Bulk import of multiple [Product][google.cloud.retail.v2.Product]s.
        /// 
        /// Request processing may be synchronous. No partial updating is supported.
        /// Non-existing items are created.
        /// 
        /// Note that it is possible for a subset of the
        /// [Product][google.cloud.retail.v2.Product]s to be successfully updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportProductsResponse, ImportMetadata> ImportProducts(ImportProductsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Bulk import of multiple [Product][google.cloud.retail.v2.Product]s.
        /// 
        /// Request processing may be synchronous. No partial updating is supported.
        /// Non-existing items are created.
        /// 
        /// Note that it is possible for a subset of the
        /// [Product][google.cloud.retail.v2.Product]s to be successfully updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportProductsResponse, ImportMetadata>> ImportProductsAsync(ImportProductsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Bulk import of multiple [Product][google.cloud.retail.v2.Product]s.
        /// 
        /// Request processing may be synchronous. No partial updating is supported.
        /// Non-existing items are created.
        /// 
        /// Note that it is possible for a subset of the
        /// [Product][google.cloud.retail.v2.Product]s to be successfully updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportProductsResponse, ImportMetadata>> ImportProductsAsync(ImportProductsRequest request, st::CancellationToken cancellationToken) =>
            ImportProductsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ImportProducts</c>.</summary>
        public virtual lro::OperationsClient ImportProductsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ImportProducts</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ImportProductsResponse, ImportMetadata> PollOnceImportProducts(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportProductsResponse, ImportMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportProductsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ImportProducts</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ImportProductsResponse, ImportMetadata>> PollOnceImportProductsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportProductsResponse, ImportMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportProductsOperationsClient, callSettings);
    }

    /// <summary>ProductService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for ingesting [Product][google.cloud.retail.v2.Product] information
    /// of the customer's website.
    /// </remarks>
    public sealed partial class ProductServiceClientImpl : ProductServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateProductRequest, Product> _callCreateProduct;

        private readonly gaxgrpc::ApiCall<GetProductRequest, Product> _callGetProduct;

        private readonly gaxgrpc::ApiCall<UpdateProductRequest, Product> _callUpdateProduct;

        private readonly gaxgrpc::ApiCall<DeleteProductRequest, wkt::Empty> _callDeleteProduct;

        private readonly gaxgrpc::ApiCall<ImportProductsRequest, lro::Operation> _callImportProducts;

        /// <summary>
        /// Constructs a client wrapper for the ProductService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ProductServiceSettings"/> used within this client.</param>
        public ProductServiceClientImpl(ProductService.ProductServiceClient grpcClient, ProductServiceSettings settings)
        {
            GrpcClient = grpcClient;
            ProductServiceSettings effectiveSettings = settings ?? ProductServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            ImportProductsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ImportProductsOperationsSettings);
            _callCreateProduct = clientHelper.BuildApiCall<CreateProductRequest, Product>(grpcClient.CreateProductAsync, grpcClient.CreateProduct, effectiveSettings.CreateProductSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateProduct);
            Modify_CreateProductApiCall(ref _callCreateProduct);
            _callGetProduct = clientHelper.BuildApiCall<GetProductRequest, Product>(grpcClient.GetProductAsync, grpcClient.GetProduct, effectiveSettings.GetProductSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetProduct);
            Modify_GetProductApiCall(ref _callGetProduct);
            _callUpdateProduct = clientHelper.BuildApiCall<UpdateProductRequest, Product>(grpcClient.UpdateProductAsync, grpcClient.UpdateProduct, effectiveSettings.UpdateProductSettings).WithGoogleRequestParam("product.name", request => request.Product?.Name);
            Modify_ApiCall(ref _callUpdateProduct);
            Modify_UpdateProductApiCall(ref _callUpdateProduct);
            _callDeleteProduct = clientHelper.BuildApiCall<DeleteProductRequest, wkt::Empty>(grpcClient.DeleteProductAsync, grpcClient.DeleteProduct, effectiveSettings.DeleteProductSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteProduct);
            Modify_DeleteProductApiCall(ref _callDeleteProduct);
            _callImportProducts = clientHelper.BuildApiCall<ImportProductsRequest, lro::Operation>(grpcClient.ImportProductsAsync, grpcClient.ImportProducts, effectiveSettings.ImportProductsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callImportProducts);
            Modify_ImportProductsApiCall(ref _callImportProducts);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateProductApiCall(ref gaxgrpc::ApiCall<CreateProductRequest, Product> call);

        partial void Modify_GetProductApiCall(ref gaxgrpc::ApiCall<GetProductRequest, Product> call);

        partial void Modify_UpdateProductApiCall(ref gaxgrpc::ApiCall<UpdateProductRequest, Product> call);

        partial void Modify_DeleteProductApiCall(ref gaxgrpc::ApiCall<DeleteProductRequest, wkt::Empty> call);

        partial void Modify_ImportProductsApiCall(ref gaxgrpc::ApiCall<ImportProductsRequest, lro::Operation> call);

        partial void OnConstruction(ProductService.ProductServiceClient grpcClient, ProductServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ProductService client</summary>
        public override ProductService.ProductServiceClient GrpcClient { get; }

        partial void Modify_CreateProductRequest(ref CreateProductRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetProductRequest(ref GetProductRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateProductRequest(ref UpdateProductRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteProductRequest(ref DeleteProductRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportProductsRequest(ref ImportProductsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Product CreateProduct(CreateProductRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateProductRequest(ref request, ref callSettings);
            return _callCreateProduct.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Product> CreateProductAsync(CreateProductRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateProductRequest(ref request, ref callSettings);
            return _callCreateProduct.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a [Product][google.cloud.retail.v2.Product].
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
        /// Gets a [Product][google.cloud.retail.v2.Product].
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
        /// Updates a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Product UpdateProduct(UpdateProductRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateProductRequest(ref request, ref callSettings);
            return _callUpdateProduct.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Product> UpdateProductAsync(UpdateProductRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateProductRequest(ref request, ref callSettings);
            return _callUpdateProduct.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteProduct(DeleteProductRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteProductRequest(ref request, ref callSettings);
            _callDeleteProduct.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteProductAsync(DeleteProductRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteProductRequest(ref request, ref callSettings);
            return _callDeleteProduct.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>ImportProducts</c>.</summary>
        public override lro::OperationsClient ImportProductsOperationsClient { get; }

        /// <summary>
        /// Bulk import of multiple [Product][google.cloud.retail.v2.Product]s.
        /// 
        /// Request processing may be synchronous. No partial updating is supported.
        /// Non-existing items are created.
        /// 
        /// Note that it is possible for a subset of the
        /// [Product][google.cloud.retail.v2.Product]s to be successfully updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ImportProductsResponse, ImportMetadata> ImportProducts(ImportProductsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportProductsRequest(ref request, ref callSettings);
            return new lro::Operation<ImportProductsResponse, ImportMetadata>(_callImportProducts.Sync(request, callSettings), ImportProductsOperationsClient);
        }

        /// <summary>
        /// Bulk import of multiple [Product][google.cloud.retail.v2.Product]s.
        /// 
        /// Request processing may be synchronous. No partial updating is supported.
        /// Non-existing items are created.
        /// 
        /// Note that it is possible for a subset of the
        /// [Product][google.cloud.retail.v2.Product]s to be successfully updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ImportProductsResponse, ImportMetadata>> ImportProductsAsync(ImportProductsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportProductsRequest(ref request, ref callSettings);
            return new lro::Operation<ImportProductsResponse, ImportMetadata>(await _callImportProducts.Async(request, callSettings).ConfigureAwait(false), ImportProductsOperationsClient);
        }
    }

    public static partial class ProductService
    {
        public partial class ProductServiceClient
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
