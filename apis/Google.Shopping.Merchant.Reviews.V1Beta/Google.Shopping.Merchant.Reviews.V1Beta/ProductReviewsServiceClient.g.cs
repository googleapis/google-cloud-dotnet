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

namespace Google.Shopping.Merchant.Reviews.V1Beta
{
    /// <summary>Settings for <see cref="ProductReviewsServiceClient"/> instances.</summary>
    public sealed partial class ProductReviewsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ProductReviewsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ProductReviewsServiceSettings"/>.</returns>
        public static ProductReviewsServiceSettings GetDefault() => new ProductReviewsServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ProductReviewsServiceSettings"/> object with default settings.
        /// </summary>
        public ProductReviewsServiceSettings()
        {
        }

        private ProductReviewsServiceSettings(ProductReviewsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetProductReviewSettings = existing.GetProductReviewSettings;
            ListProductReviewsSettings = existing.ListProductReviewsSettings;
            InsertProductReviewSettings = existing.InsertProductReviewSettings;
            DeleteProductReviewSettings = existing.DeleteProductReviewSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ProductReviewsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductReviewsServiceClient.GetProductReview</c> and <c>ProductReviewsServiceClient.GetProductReviewAsync</c>
        /// .
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
        public gaxgrpc::CallSettings GetProductReviewSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductReviewsServiceClient.ListProductReviews</c> and
        /// <c>ProductReviewsServiceClient.ListProductReviewsAsync</c>.
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
        public gaxgrpc::CallSettings ListProductReviewsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductReviewsServiceClient.InsertProductReview</c> and
        /// <c>ProductReviewsServiceClient.InsertProductReviewAsync</c>.
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
        public gaxgrpc::CallSettings InsertProductReviewSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductReviewsServiceClient.DeleteProductReview</c> and
        /// <c>ProductReviewsServiceClient.DeleteProductReviewAsync</c>.
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
        public gaxgrpc::CallSettings DeleteProductReviewSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ProductReviewsServiceSettings"/> object.</returns>
        public ProductReviewsServiceSettings Clone() => new ProductReviewsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ProductReviewsServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class ProductReviewsServiceClientBuilder : gaxgrpc::ClientBuilderBase<ProductReviewsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ProductReviewsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ProductReviewsServiceClientBuilder() : base(ProductReviewsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ProductReviewsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ProductReviewsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ProductReviewsServiceClient Build()
        {
            ProductReviewsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ProductReviewsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ProductReviewsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ProductReviewsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ProductReviewsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ProductReviewsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ProductReviewsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ProductReviewsServiceClient.ChannelPool;
    }

    /// <summary>ProductReviewsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage product reviews.
    /// </remarks>
    public abstract partial class ProductReviewsServiceClient
    {
        /// <summary>
        /// The default endpoint for the ProductReviewsService service, which is a host of "merchantapi.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "merchantapi.googleapis.com:443";

        /// <summary>The default ProductReviewsService scopes.</summary>
        /// <remarks>
        /// The default ProductReviewsService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ProductReviewsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ProductReviewsServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ProductReviewsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ProductReviewsServiceClient"/>.</returns>
        public static stt::Task<ProductReviewsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ProductReviewsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ProductReviewsServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ProductReviewsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ProductReviewsServiceClient"/>.</returns>
        public static ProductReviewsServiceClient Create() => new ProductReviewsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ProductReviewsServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ProductReviewsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ProductReviewsServiceClient"/>.</returns>
        internal static ProductReviewsServiceClient Create(grpccore::CallInvoker callInvoker, ProductReviewsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ProductReviewsService.ProductReviewsServiceClient grpcClient = new ProductReviewsService.ProductReviewsServiceClient(callInvoker);
            return new ProductReviewsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ProductReviewsService client</summary>
        public virtual ProductReviewsService.ProductReviewsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a product review.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProductReview GetProductReview(GetProductReviewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a product review.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProductReview> GetProductReviewAsync(GetProductReviewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a product review.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProductReview> GetProductReviewAsync(GetProductReviewRequest request, st::CancellationToken cancellationToken) =>
            GetProductReviewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a product review.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the merchant review.
        /// Format: accounts/{account}/productReviews/{productReview}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProductReview GetProductReview(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProductReview(new GetProductReviewRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a product review.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the merchant review.
        /// Format: accounts/{account}/productReviews/{productReview}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProductReview> GetProductReviewAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProductReviewAsync(new GetProductReviewRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a product review.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the merchant review.
        /// Format: accounts/{account}/productReviews/{productReview}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProductReview> GetProductReviewAsync(string name, st::CancellationToken cancellationToken) =>
            GetProductReviewAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a product review.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the merchant review.
        /// Format: accounts/{account}/productReviews/{productReview}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProductReview GetProductReview(ProductReviewName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProductReview(new GetProductReviewRequest
            {
                ProductReviewName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a product review.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the merchant review.
        /// Format: accounts/{account}/productReviews/{productReview}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProductReview> GetProductReviewAsync(ProductReviewName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProductReviewAsync(new GetProductReviewRequest
            {
                ProductReviewName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a product review.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the merchant review.
        /// Format: accounts/{account}/productReviews/{productReview}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProductReview> GetProductReviewAsync(ProductReviewName name, st::CancellationToken cancellationToken) =>
            GetProductReviewAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists product reviews.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ProductReview"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProductReviewsResponse, ProductReview> ListProductReviews(ListProductReviewsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists product reviews.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ProductReview"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProductReviewsResponse, ProductReview> ListProductReviewsAsync(ListProductReviewsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists product reviews.
        /// </summary>
        /// <param name="parent">
        /// Required. The account to list product reviews for.
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
        /// <returns>A pageable sequence of <see cref="ProductReview"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProductReviewsResponse, ProductReview> ListProductReviews(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProductReviewsRequest request = new ListProductReviewsRequest
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
            return ListProductReviews(request, callSettings);
        }

        /// <summary>
        /// Lists product reviews.
        /// </summary>
        /// <param name="parent">
        /// Required. The account to list product reviews for.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ProductReview"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProductReviewsResponse, ProductReview> ListProductReviewsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProductReviewsRequest request = new ListProductReviewsRequest
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
            return ListProductReviewsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists product reviews.
        /// </summary>
        /// <param name="parent">
        /// Required. The account to list product reviews for.
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
        /// <returns>A pageable sequence of <see cref="ProductReview"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProductReviewsResponse, ProductReview> ListProductReviews(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProductReviewsRequest request = new ListProductReviewsRequest
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
            return ListProductReviews(request, callSettings);
        }

        /// <summary>
        /// Lists product reviews.
        /// </summary>
        /// <param name="parent">
        /// Required. The account to list product reviews for.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ProductReview"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProductReviewsResponse, ProductReview> ListProductReviewsAsync(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProductReviewsRequest request = new ListProductReviewsRequest
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
            return ListProductReviewsAsync(request, callSettings);
        }

        /// <summary>
        /// Inserts a product review.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProductReview InsertProductReview(InsertProductReviewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Inserts a product review.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProductReview> InsertProductReviewAsync(InsertProductReviewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Inserts a product review.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProductReview> InsertProductReviewAsync(InsertProductReviewRequest request, st::CancellationToken cancellationToken) =>
            InsertProductReviewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a product review.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteProductReview(DeleteProductReviewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a product review.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteProductReviewAsync(DeleteProductReviewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a product review.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteProductReviewAsync(DeleteProductReviewRequest request, st::CancellationToken cancellationToken) =>
            DeleteProductReviewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a product review.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the Product review.
        /// Format: accounts/{account}/productReviews/{productReview}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteProductReview(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProductReview(new DeleteProductReviewRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a product review.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the Product review.
        /// Format: accounts/{account}/productReviews/{productReview}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteProductReviewAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProductReviewAsync(new DeleteProductReviewRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a product review.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the Product review.
        /// Format: accounts/{account}/productReviews/{productReview}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteProductReviewAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteProductReviewAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a product review.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the Product review.
        /// Format: accounts/{account}/productReviews/{productReview}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteProductReview(ProductReviewName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProductReview(new DeleteProductReviewRequest
            {
                ProductReviewName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a product review.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the Product review.
        /// Format: accounts/{account}/productReviews/{productReview}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteProductReviewAsync(ProductReviewName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProductReviewAsync(new DeleteProductReviewRequest
            {
                ProductReviewName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a product review.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the Product review.
        /// Format: accounts/{account}/productReviews/{productReview}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteProductReviewAsync(ProductReviewName name, st::CancellationToken cancellationToken) =>
            DeleteProductReviewAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ProductReviewsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage product reviews.
    /// </remarks>
    public sealed partial class ProductReviewsServiceClientImpl : ProductReviewsServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetProductReviewRequest, ProductReview> _callGetProductReview;

        private readonly gaxgrpc::ApiCall<ListProductReviewsRequest, ListProductReviewsResponse> _callListProductReviews;

        private readonly gaxgrpc::ApiCall<InsertProductReviewRequest, ProductReview> _callInsertProductReview;

        private readonly gaxgrpc::ApiCall<DeleteProductReviewRequest, wkt::Empty> _callDeleteProductReview;

        /// <summary>
        /// Constructs a client wrapper for the ProductReviewsService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ProductReviewsServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ProductReviewsServiceClientImpl(ProductReviewsService.ProductReviewsServiceClient grpcClient, ProductReviewsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ProductReviewsServiceSettings effectiveSettings = settings ?? ProductReviewsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetProductReview = clientHelper.BuildApiCall<GetProductReviewRequest, ProductReview>("GetProductReview", grpcClient.GetProductReviewAsync, grpcClient.GetProductReview, effectiveSettings.GetProductReviewSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetProductReview);
            Modify_GetProductReviewApiCall(ref _callGetProductReview);
            _callListProductReviews = clientHelper.BuildApiCall<ListProductReviewsRequest, ListProductReviewsResponse>("ListProductReviews", grpcClient.ListProductReviewsAsync, grpcClient.ListProductReviews, effectiveSettings.ListProductReviewsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListProductReviews);
            Modify_ListProductReviewsApiCall(ref _callListProductReviews);
            _callInsertProductReview = clientHelper.BuildApiCall<InsertProductReviewRequest, ProductReview>("InsertProductReview", grpcClient.InsertProductReviewAsync, grpcClient.InsertProductReview, effectiveSettings.InsertProductReviewSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callInsertProductReview);
            Modify_InsertProductReviewApiCall(ref _callInsertProductReview);
            _callDeleteProductReview = clientHelper.BuildApiCall<DeleteProductReviewRequest, wkt::Empty>("DeleteProductReview", grpcClient.DeleteProductReviewAsync, grpcClient.DeleteProductReview, effectiveSettings.DeleteProductReviewSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteProductReview);
            Modify_DeleteProductReviewApiCall(ref _callDeleteProductReview);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetProductReviewApiCall(ref gaxgrpc::ApiCall<GetProductReviewRequest, ProductReview> call);

        partial void Modify_ListProductReviewsApiCall(ref gaxgrpc::ApiCall<ListProductReviewsRequest, ListProductReviewsResponse> call);

        partial void Modify_InsertProductReviewApiCall(ref gaxgrpc::ApiCall<InsertProductReviewRequest, ProductReview> call);

        partial void Modify_DeleteProductReviewApiCall(ref gaxgrpc::ApiCall<DeleteProductReviewRequest, wkt::Empty> call);

        partial void OnConstruction(ProductReviewsService.ProductReviewsServiceClient grpcClient, ProductReviewsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ProductReviewsService client</summary>
        public override ProductReviewsService.ProductReviewsServiceClient GrpcClient { get; }

        partial void Modify_GetProductReviewRequest(ref GetProductReviewRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListProductReviewsRequest(ref ListProductReviewsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InsertProductReviewRequest(ref InsertProductReviewRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteProductReviewRequest(ref DeleteProductReviewRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets a product review.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ProductReview GetProductReview(GetProductReviewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProductReviewRequest(ref request, ref callSettings);
            return _callGetProductReview.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a product review.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ProductReview> GetProductReviewAsync(GetProductReviewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProductReviewRequest(ref request, ref callSettings);
            return _callGetProductReview.Async(request, callSettings);
        }

        /// <summary>
        /// Lists product reviews.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ProductReview"/> resources.</returns>
        public override gax::PagedEnumerable<ListProductReviewsResponse, ProductReview> ListProductReviews(ListProductReviewsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProductReviewsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListProductReviewsRequest, ListProductReviewsResponse, ProductReview>(_callListProductReviews, request, callSettings);
        }

        /// <summary>
        /// Lists product reviews.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ProductReview"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListProductReviewsResponse, ProductReview> ListProductReviewsAsync(ListProductReviewsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProductReviewsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListProductReviewsRequest, ListProductReviewsResponse, ProductReview>(_callListProductReviews, request, callSettings);
        }

        /// <summary>
        /// Inserts a product review.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ProductReview InsertProductReview(InsertProductReviewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertProductReviewRequest(ref request, ref callSettings);
            return _callInsertProductReview.Sync(request, callSettings);
        }

        /// <summary>
        /// Inserts a product review.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ProductReview> InsertProductReviewAsync(InsertProductReviewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertProductReviewRequest(ref request, ref callSettings);
            return _callInsertProductReview.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a product review.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteProductReview(DeleteProductReviewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteProductReviewRequest(ref request, ref callSettings);
            _callDeleteProductReview.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a product review.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteProductReviewAsync(DeleteProductReviewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteProductReviewRequest(ref request, ref callSettings);
            return _callDeleteProductReview.Async(request, callSettings);
        }
    }

    public partial class ListProductReviewsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListProductReviewsResponse : gaxgrpc::IPageResponse<ProductReview>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ProductReview> GetEnumerator() => ProductReviews.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
