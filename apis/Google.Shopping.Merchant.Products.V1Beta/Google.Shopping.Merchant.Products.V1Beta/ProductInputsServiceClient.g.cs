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
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Shopping.Merchant.Products.V1Beta
{
    /// <summary>Settings for <see cref="ProductInputsServiceClient"/> instances.</summary>
    public sealed partial class ProductInputsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ProductInputsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ProductInputsServiceSettings"/>.</returns>
        public static ProductInputsServiceSettings GetDefault() => new ProductInputsServiceSettings();

        /// <summary>Constructs a new <see cref="ProductInputsServiceSettings"/> object with default settings.</summary>
        public ProductInputsServiceSettings()
        {
        }

        private ProductInputsServiceSettings(ProductInputsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            InsertProductInputSettings = existing.InsertProductInputSettings;
            DeleteProductInputSettings = existing.DeleteProductInputSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ProductInputsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductInputsServiceClient.InsertProductInput</c> and
        /// <c>ProductInputsServiceClient.InsertProductInputAsync</c>.
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
        public gaxgrpc::CallSettings InsertProductInputSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductInputsServiceClient.DeleteProductInput</c> and
        /// <c>ProductInputsServiceClient.DeleteProductInputAsync</c>.
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
        public gaxgrpc::CallSettings DeleteProductInputSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ProductInputsServiceSettings"/> object.</returns>
        public ProductInputsServiceSettings Clone() => new ProductInputsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ProductInputsServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class ProductInputsServiceClientBuilder : gaxgrpc::ClientBuilderBase<ProductInputsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ProductInputsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ProductInputsServiceClientBuilder() : base(ProductInputsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ProductInputsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ProductInputsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ProductInputsServiceClient Build()
        {
            ProductInputsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ProductInputsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ProductInputsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ProductInputsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ProductInputsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ProductInputsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ProductInputsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ProductInputsServiceClient.ChannelPool;
    }

    /// <summary>ProductInputsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to use ProductInput resource.
    /// This service works for products with online channel only.
    /// </remarks>
    public abstract partial class ProductInputsServiceClient
    {
        /// <summary>
        /// The default endpoint for the ProductInputsService service, which is a host of "merchantapi.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "merchantapi.googleapis.com:443";

        /// <summary>The default ProductInputsService scopes.</summary>
        /// <remarks>
        /// The default ProductInputsService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ProductInputsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ProductInputsServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ProductInputsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ProductInputsServiceClient"/>.</returns>
        public static stt::Task<ProductInputsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ProductInputsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ProductInputsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="ProductInputsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ProductInputsServiceClient"/>.</returns>
        public static ProductInputsServiceClient Create() => new ProductInputsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ProductInputsServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ProductInputsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ProductInputsServiceClient"/>.</returns>
        internal static ProductInputsServiceClient Create(grpccore::CallInvoker callInvoker, ProductInputsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ProductInputsService.ProductInputsServiceClient grpcClient = new ProductInputsService.ProductInputsServiceClient(callInvoker);
            return new ProductInputsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ProductInputsService client</summary>
        public virtual ProductInputsService.ProductInputsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Uploads a product input to your Merchant Center account. If an input
        /// with the same contentLanguage, offerId, and dataSource already exists,
        /// this method replaces that entry.
        /// 
        /// After inserting, updating, or deleting a product input, it may take several
        /// minutes before the processed product can be retrieved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProductInput InsertProductInput(InsertProductInputRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Uploads a product input to your Merchant Center account. If an input
        /// with the same contentLanguage, offerId, and dataSource already exists,
        /// this method replaces that entry.
        /// 
        /// After inserting, updating, or deleting a product input, it may take several
        /// minutes before the processed product can be retrieved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProductInput> InsertProductInputAsync(InsertProductInputRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Uploads a product input to your Merchant Center account. If an input
        /// with the same contentLanguage, offerId, and dataSource already exists,
        /// this method replaces that entry.
        /// 
        /// After inserting, updating, or deleting a product input, it may take several
        /// minutes before the processed product can be retrieved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProductInput> InsertProductInputAsync(InsertProductInputRequest request, st::CancellationToken cancellationToken) =>
            InsertProductInputAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a product input from your Merchant Center account.
        /// 
        /// After inserting, updating, or deleting a product input, it may take several
        /// minutes before the processed product can be retrieved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteProductInput(DeleteProductInputRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a product input from your Merchant Center account.
        /// 
        /// After inserting, updating, or deleting a product input, it may take several
        /// minutes before the processed product can be retrieved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteProductInputAsync(DeleteProductInputRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a product input from your Merchant Center account.
        /// 
        /// After inserting, updating, or deleting a product input, it may take several
        /// minutes before the processed product can be retrieved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteProductInputAsync(DeleteProductInputRequest request, st::CancellationToken cancellationToken) =>
            DeleteProductInputAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a product input from your Merchant Center account.
        /// 
        /// After inserting, updating, or deleting a product input, it may take several
        /// minutes before the processed product can be retrieved.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the product input resource to delete.
        /// Format: accounts/{account}/productInputs/{product}
        /// where the last section `product` consists of 4 parts:
        /// channel~content_language~feed_label~offer_id
        /// example for product name is
        /// "accounts/123/productInputs/online~en~US~sku123"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteProductInput(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProductInput(new DeleteProductInputRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a product input from your Merchant Center account.
        /// 
        /// After inserting, updating, or deleting a product input, it may take several
        /// minutes before the processed product can be retrieved.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the product input resource to delete.
        /// Format: accounts/{account}/productInputs/{product}
        /// where the last section `product` consists of 4 parts:
        /// channel~content_language~feed_label~offer_id
        /// example for product name is
        /// "accounts/123/productInputs/online~en~US~sku123"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteProductInputAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProductInputAsync(new DeleteProductInputRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a product input from your Merchant Center account.
        /// 
        /// After inserting, updating, or deleting a product input, it may take several
        /// minutes before the processed product can be retrieved.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the product input resource to delete.
        /// Format: accounts/{account}/productInputs/{product}
        /// where the last section `product` consists of 4 parts:
        /// channel~content_language~feed_label~offer_id
        /// example for product name is
        /// "accounts/123/productInputs/online~en~US~sku123"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteProductInputAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteProductInputAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a product input from your Merchant Center account.
        /// 
        /// After inserting, updating, or deleting a product input, it may take several
        /// minutes before the processed product can be retrieved.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the product input resource to delete.
        /// Format: accounts/{account}/productInputs/{product}
        /// where the last section `product` consists of 4 parts:
        /// channel~content_language~feed_label~offer_id
        /// example for product name is
        /// "accounts/123/productInputs/online~en~US~sku123"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteProductInput(ProductInputName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProductInput(new DeleteProductInputRequest
            {
                ProductInputName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a product input from your Merchant Center account.
        /// 
        /// After inserting, updating, or deleting a product input, it may take several
        /// minutes before the processed product can be retrieved.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the product input resource to delete.
        /// Format: accounts/{account}/productInputs/{product}
        /// where the last section `product` consists of 4 parts:
        /// channel~content_language~feed_label~offer_id
        /// example for product name is
        /// "accounts/123/productInputs/online~en~US~sku123"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteProductInputAsync(ProductInputName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProductInputAsync(new DeleteProductInputRequest
            {
                ProductInputName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a product input from your Merchant Center account.
        /// 
        /// After inserting, updating, or deleting a product input, it may take several
        /// minutes before the processed product can be retrieved.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the product input resource to delete.
        /// Format: accounts/{account}/productInputs/{product}
        /// where the last section `product` consists of 4 parts:
        /// channel~content_language~feed_label~offer_id
        /// example for product name is
        /// "accounts/123/productInputs/online~en~US~sku123"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteProductInputAsync(ProductInputName name, st::CancellationToken cancellationToken) =>
            DeleteProductInputAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ProductInputsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to use ProductInput resource.
    /// This service works for products with online channel only.
    /// </remarks>
    public sealed partial class ProductInputsServiceClientImpl : ProductInputsServiceClient
    {
        private readonly gaxgrpc::ApiCall<InsertProductInputRequest, ProductInput> _callInsertProductInput;

        private readonly gaxgrpc::ApiCall<DeleteProductInputRequest, wkt::Empty> _callDeleteProductInput;

        /// <summary>
        /// Constructs a client wrapper for the ProductInputsService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ProductInputsServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ProductInputsServiceClientImpl(ProductInputsService.ProductInputsServiceClient grpcClient, ProductInputsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ProductInputsServiceSettings effectiveSettings = settings ?? ProductInputsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callInsertProductInput = clientHelper.BuildApiCall<InsertProductInputRequest, ProductInput>("InsertProductInput", grpcClient.InsertProductInputAsync, grpcClient.InsertProductInput, effectiveSettings.InsertProductInputSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callInsertProductInput);
            Modify_InsertProductInputApiCall(ref _callInsertProductInput);
            _callDeleteProductInput = clientHelper.BuildApiCall<DeleteProductInputRequest, wkt::Empty>("DeleteProductInput", grpcClient.DeleteProductInputAsync, grpcClient.DeleteProductInput, effectiveSettings.DeleteProductInputSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteProductInput);
            Modify_DeleteProductInputApiCall(ref _callDeleteProductInput);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_InsertProductInputApiCall(ref gaxgrpc::ApiCall<InsertProductInputRequest, ProductInput> call);

        partial void Modify_DeleteProductInputApiCall(ref gaxgrpc::ApiCall<DeleteProductInputRequest, wkt::Empty> call);

        partial void OnConstruction(ProductInputsService.ProductInputsServiceClient grpcClient, ProductInputsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ProductInputsService client</summary>
        public override ProductInputsService.ProductInputsServiceClient GrpcClient { get; }

        partial void Modify_InsertProductInputRequest(ref InsertProductInputRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteProductInputRequest(ref DeleteProductInputRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Uploads a product input to your Merchant Center account. If an input
        /// with the same contentLanguage, offerId, and dataSource already exists,
        /// this method replaces that entry.
        /// 
        /// After inserting, updating, or deleting a product input, it may take several
        /// minutes before the processed product can be retrieved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ProductInput InsertProductInput(InsertProductInputRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertProductInputRequest(ref request, ref callSettings);
            return _callInsertProductInput.Sync(request, callSettings);
        }

        /// <summary>
        /// Uploads a product input to your Merchant Center account. If an input
        /// with the same contentLanguage, offerId, and dataSource already exists,
        /// this method replaces that entry.
        /// 
        /// After inserting, updating, or deleting a product input, it may take several
        /// minutes before the processed product can be retrieved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ProductInput> InsertProductInputAsync(InsertProductInputRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertProductInputRequest(ref request, ref callSettings);
            return _callInsertProductInput.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a product input from your Merchant Center account.
        /// 
        /// After inserting, updating, or deleting a product input, it may take several
        /// minutes before the processed product can be retrieved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteProductInput(DeleteProductInputRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteProductInputRequest(ref request, ref callSettings);
            _callDeleteProductInput.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a product input from your Merchant Center account.
        /// 
        /// After inserting, updating, or deleting a product input, it may take several
        /// minutes before the processed product can be retrieved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteProductInputAsync(DeleteProductInputRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteProductInputRequest(ref request, ref callSettings);
            return _callDeleteProductInput.Async(request, callSettings);
        }
    }
}
