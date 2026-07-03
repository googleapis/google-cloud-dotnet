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

namespace Google.Cloud.ProductRegistry.V1
{
    /// <summary>Settings for <see cref="CloudProductRegistryReadServiceClient"/> instances.</summary>
    public sealed partial class CloudProductRegistryReadServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CloudProductRegistryReadServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CloudProductRegistryReadServiceSettings"/>.</returns>
        public static CloudProductRegistryReadServiceSettings GetDefault() => new CloudProductRegistryReadServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CloudProductRegistryReadServiceSettings"/> object with default settings.
        /// </summary>
        public CloudProductRegistryReadServiceSettings()
        {
        }

        private CloudProductRegistryReadServiceSettings(CloudProductRegistryReadServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetProductSuiteSettings = existing.GetProductSuiteSettings;
            ListProductSuitesSettings = existing.ListProductSuitesSettings;
            GetLogicalProductSettings = existing.GetLogicalProductSettings;
            ListLogicalProductsSettings = existing.ListLogicalProductsSettings;
            GetLogicalProductVariantSettings = existing.GetLogicalProductVariantSettings;
            ListLogicalProductVariantsSettings = existing.ListLogicalProductVariantsSettings;
            LookupEntitySettings = existing.LookupEntitySettings;
            OnCopy(existing);
        }

        partial void OnCopy(CloudProductRegistryReadServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudProductRegistryReadServiceClient.GetProductSuite</c> and
        /// <c>CloudProductRegistryReadServiceClient.GetProductSuiteAsync</c>.
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
        public gaxgrpc::CallSettings GetProductSuiteSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudProductRegistryReadServiceClient.ListProductSuites</c> and
        /// <c>CloudProductRegistryReadServiceClient.ListProductSuitesAsync</c>.
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
        public gaxgrpc::CallSettings ListProductSuitesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudProductRegistryReadServiceClient.GetLogicalProduct</c> and
        /// <c>CloudProductRegistryReadServiceClient.GetLogicalProductAsync</c>.
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
        public gaxgrpc::CallSettings GetLogicalProductSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudProductRegistryReadServiceClient.ListLogicalProducts</c> and
        /// <c>CloudProductRegistryReadServiceClient.ListLogicalProductsAsync</c>.
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
        public gaxgrpc::CallSettings ListLogicalProductsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudProductRegistryReadServiceClient.GetLogicalProductVariant</c> and
        /// <c>CloudProductRegistryReadServiceClient.GetLogicalProductVariantAsync</c>.
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
        public gaxgrpc::CallSettings GetLogicalProductVariantSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudProductRegistryReadServiceClient.ListLogicalProductVariants</c> and
        /// <c>CloudProductRegistryReadServiceClient.ListLogicalProductVariantsAsync</c>.
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
        public gaxgrpc::CallSettings ListLogicalProductVariantsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudProductRegistryReadServiceClient.LookupEntity</c> and
        /// <c>CloudProductRegistryReadServiceClient.LookupEntityAsync</c>.
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
        public gaxgrpc::CallSettings LookupEntitySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CloudProductRegistryReadServiceSettings"/> object.</returns>
        public CloudProductRegistryReadServiceSettings Clone() => new CloudProductRegistryReadServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CloudProductRegistryReadServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class CloudProductRegistryReadServiceClientBuilder : gaxgrpc::ClientBuilderBase<CloudProductRegistryReadServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CloudProductRegistryReadServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CloudProductRegistryReadServiceClientBuilder() : base(CloudProductRegistryReadServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CloudProductRegistryReadServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CloudProductRegistryReadServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CloudProductRegistryReadServiceClient Build()
        {
            CloudProductRegistryReadServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CloudProductRegistryReadServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CloudProductRegistryReadServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CloudProductRegistryReadServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CloudProductRegistryReadServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CloudProductRegistryReadServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CloudProductRegistryReadServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CloudProductRegistryReadServiceClient.ChannelPool;
    }

    /// <summary>CloudProductRegistryReadService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Cloud Product Registry Read Service provides capabilities to access all first
    /// and third party Google Cloud products.
    /// </remarks>
    public abstract partial class CloudProductRegistryReadServiceClient
    {
        /// <summary>
        /// The default endpoint for the CloudProductRegistryReadService service, which is a host of
        /// "cloudproductregistry.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudproductregistry.googleapis.com:443";

        /// <summary>The default CloudProductRegistryReadService scopes.</summary>
        /// <remarks>The default CloudProductRegistryReadService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CloudProductRegistryReadService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CloudProductRegistryReadServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CloudProductRegistryReadServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CloudProductRegistryReadServiceClient"/>.</returns>
        public static stt::Task<CloudProductRegistryReadServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CloudProductRegistryReadServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CloudProductRegistryReadServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CloudProductRegistryReadServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CloudProductRegistryReadServiceClient"/>.</returns>
        public static CloudProductRegistryReadServiceClient Create() =>
            new CloudProductRegistryReadServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CloudProductRegistryReadServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CloudProductRegistryReadServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CloudProductRegistryReadServiceClient"/>.</returns>
        internal static CloudProductRegistryReadServiceClient Create(grpccore::CallInvoker callInvoker, CloudProductRegistryReadServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CloudProductRegistryReadService.CloudProductRegistryReadServiceClient grpcClient = new CloudProductRegistryReadService.CloudProductRegistryReadServiceClient(callInvoker);
            return new CloudProductRegistryReadServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CloudProductRegistryReadService client</summary>
        public virtual CloudProductRegistryReadService.CloudProductRegistryReadServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Get details of a ProductSuite.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProductSuite GetProductSuite(GetProductSuiteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details of a ProductSuite.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProductSuite> GetProductSuiteAsync(GetProductSuiteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details of a ProductSuite.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProductSuite> GetProductSuiteAsync(GetProductSuiteRequest request, st::CancellationToken cancellationToken) =>
            GetProductSuiteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details of a ProductSuite.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ProductSuite to retrieve.
        /// Format: productSuites/{product_suite}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProductSuite GetProductSuite(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProductSuite(new GetProductSuiteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a ProductSuite.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ProductSuite to retrieve.
        /// Format: productSuites/{product_suite}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProductSuite> GetProductSuiteAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProductSuiteAsync(new GetProductSuiteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a ProductSuite.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ProductSuite to retrieve.
        /// Format: productSuites/{product_suite}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProductSuite> GetProductSuiteAsync(string name, st::CancellationToken cancellationToken) =>
            GetProductSuiteAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details of a ProductSuite.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ProductSuite to retrieve.
        /// Format: productSuites/{product_suite}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProductSuite GetProductSuite(ProductSuiteName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProductSuite(new GetProductSuiteRequest
            {
                ProductSuiteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a ProductSuite.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ProductSuite to retrieve.
        /// Format: productSuites/{product_suite}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProductSuite> GetProductSuiteAsync(ProductSuiteName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProductSuiteAsync(new GetProductSuiteRequest
            {
                ProductSuiteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a ProductSuite.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ProductSuite to retrieve.
        /// Format: productSuites/{product_suite}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProductSuite> GetProductSuiteAsync(ProductSuiteName name, st::CancellationToken cancellationToken) =>
            GetProductSuiteAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists ProductSuites.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ProductSuite"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProductSuitesResponse, ProductSuite> ListProductSuites(ListProductSuitesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ProductSuites.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ProductSuite"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProductSuitesResponse, ProductSuite> ListProductSuitesAsync(ListProductSuitesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a LogicalProduct.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogicalProduct GetLogicalProduct(GetLogicalProductRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a LogicalProduct.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogicalProduct> GetLogicalProductAsync(GetLogicalProductRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a LogicalProduct.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogicalProduct> GetLogicalProductAsync(GetLogicalProductRequest request, st::CancellationToken cancellationToken) =>
            GetLogicalProductAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a LogicalProduct.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the LogicalProduct to retrieve.
        /// Format: logicalProducts/{logical_product}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogicalProduct GetLogicalProduct(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetLogicalProduct(new GetLogicalProductRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a LogicalProduct.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the LogicalProduct to retrieve.
        /// Format: logicalProducts/{logical_product}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogicalProduct> GetLogicalProductAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetLogicalProductAsync(new GetLogicalProductRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a LogicalProduct.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the LogicalProduct to retrieve.
        /// Format: logicalProducts/{logical_product}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogicalProduct> GetLogicalProductAsync(string name, st::CancellationToken cancellationToken) =>
            GetLogicalProductAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a LogicalProduct.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the LogicalProduct to retrieve.
        /// Format: logicalProducts/{logical_product}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogicalProduct GetLogicalProduct(LogicalProductName name, gaxgrpc::CallSettings callSettings = null) =>
            GetLogicalProduct(new GetLogicalProductRequest
            {
                LogicalProductName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a LogicalProduct.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the LogicalProduct to retrieve.
        /// Format: logicalProducts/{logical_product}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogicalProduct> GetLogicalProductAsync(LogicalProductName name, gaxgrpc::CallSettings callSettings = null) =>
            GetLogicalProductAsync(new GetLogicalProductRequest
            {
                LogicalProductName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a LogicalProduct.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the LogicalProduct to retrieve.
        /// Format: logicalProducts/{logical_product}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogicalProduct> GetLogicalProductAsync(LogicalProductName name, st::CancellationToken cancellationToken) =>
            GetLogicalProductAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists LogicalProducts matching given criteria.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LogicalProduct"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLogicalProductsResponse, LogicalProduct> ListLogicalProducts(ListLogicalProductsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists LogicalProducts matching given criteria.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LogicalProduct"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLogicalProductsResponse, LogicalProduct> ListLogicalProductsAsync(ListLogicalProductsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details of a LogicalProductVariant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogicalProductVariant GetLogicalProductVariant(GetLogicalProductVariantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details of a LogicalProductVariant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogicalProductVariant> GetLogicalProductVariantAsync(GetLogicalProductVariantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details of a LogicalProductVariant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogicalProductVariant> GetLogicalProductVariantAsync(GetLogicalProductVariantRequest request, st::CancellationToken cancellationToken) =>
            GetLogicalProductVariantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details of a LogicalProductVariant.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the LogicalProductVariant to retrieve.
        /// Format: logicalProducts/{logical_product}/variants/{variant}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogicalProductVariant GetLogicalProductVariant(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetLogicalProductVariant(new GetLogicalProductVariantRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a LogicalProductVariant.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the LogicalProductVariant to retrieve.
        /// Format: logicalProducts/{logical_product}/variants/{variant}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogicalProductVariant> GetLogicalProductVariantAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetLogicalProductVariantAsync(new GetLogicalProductVariantRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a LogicalProductVariant.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the LogicalProductVariant to retrieve.
        /// Format: logicalProducts/{logical_product}/variants/{variant}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogicalProductVariant> GetLogicalProductVariantAsync(string name, st::CancellationToken cancellationToken) =>
            GetLogicalProductVariantAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details of a LogicalProductVariant.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the LogicalProductVariant to retrieve.
        /// Format: logicalProducts/{logical_product}/variants/{variant}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogicalProductVariant GetLogicalProductVariant(LogicalProductVariantName name, gaxgrpc::CallSettings callSettings = null) =>
            GetLogicalProductVariant(new GetLogicalProductVariantRequest
            {
                LogicalProductVariantName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a LogicalProductVariant.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the LogicalProductVariant to retrieve.
        /// Format: logicalProducts/{logical_product}/variants/{variant}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogicalProductVariant> GetLogicalProductVariantAsync(LogicalProductVariantName name, gaxgrpc::CallSettings callSettings = null) =>
            GetLogicalProductVariantAsync(new GetLogicalProductVariantRequest
            {
                LogicalProductVariantName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a LogicalProductVariant.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the LogicalProductVariant to retrieve.
        /// Format: logicalProducts/{logical_product}/variants/{variant}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogicalProductVariant> GetLogicalProductVariantAsync(LogicalProductVariantName name, st::CancellationToken cancellationToken) =>
            GetLogicalProductVariantAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists LogicalProductVariants matching given criteria.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LogicalProductVariant"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLogicalProductVariantsResponse, LogicalProductVariant> ListLogicalProductVariants(ListLogicalProductVariantsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists LogicalProductVariants matching given criteria.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LogicalProductVariant"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLogicalProductVariantsResponse, LogicalProductVariant> ListLogicalProductVariantsAsync(ListLogicalProductVariantsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists LogicalProductVariants matching given criteria.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent logical product id.
        /// Format: logicalProducts/{logical_product}
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
        /// <returns>A pageable sequence of <see cref="LogicalProductVariant"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLogicalProductVariantsResponse, LogicalProductVariant> ListLogicalProductVariants(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLogicalProductVariantsRequest request = new ListLogicalProductVariantsRequest
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
            return ListLogicalProductVariants(request, callSettings);
        }

        /// <summary>
        /// Lists LogicalProductVariants matching given criteria.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent logical product id.
        /// Format: logicalProducts/{logical_product}
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
        /// <returns>A pageable asynchronous sequence of <see cref="LogicalProductVariant"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLogicalProductVariantsResponse, LogicalProductVariant> ListLogicalProductVariantsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLogicalProductVariantsRequest request = new ListLogicalProductVariantsRequest
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
            return ListLogicalProductVariantsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists LogicalProductVariants matching given criteria.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent logical product id.
        /// Format: logicalProducts/{logical_product}
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
        /// <returns>A pageable sequence of <see cref="LogicalProductVariant"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLogicalProductVariantsResponse, LogicalProductVariant> ListLogicalProductVariants(LogicalProductName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLogicalProductVariantsRequest request = new ListLogicalProductVariantsRequest
            {
                ParentAsLogicalProductName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListLogicalProductVariants(request, callSettings);
        }

        /// <summary>
        /// Lists LogicalProductVariants matching given criteria.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent logical product id.
        /// Format: logicalProducts/{logical_product}
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
        /// <returns>A pageable asynchronous sequence of <see cref="LogicalProductVariant"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLogicalProductVariantsResponse, LogicalProductVariant> ListLogicalProductVariantsAsync(LogicalProductName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLogicalProductVariantsRequest request = new ListLogicalProductVariantsRequest
            {
                ParentAsLogicalProductName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListLogicalProductVariantsAsync(request, callSettings);
        }

        /// <summary>
        /// Look up entities.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LookupEntityResponse LookupEntity(LookupEntityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Look up entities.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LookupEntityResponse> LookupEntityAsync(LookupEntityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Look up entities.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LookupEntityResponse> LookupEntityAsync(LookupEntityRequest request, st::CancellationToken cancellationToken) =>
            LookupEntityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CloudProductRegistryReadService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Cloud Product Registry Read Service provides capabilities to access all first
    /// and third party Google Cloud products.
    /// </remarks>
    public sealed partial class CloudProductRegistryReadServiceClientImpl : CloudProductRegistryReadServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetProductSuiteRequest, ProductSuite> _callGetProductSuite;

        private readonly gaxgrpc::ApiCall<ListProductSuitesRequest, ListProductSuitesResponse> _callListProductSuites;

        private readonly gaxgrpc::ApiCall<GetLogicalProductRequest, LogicalProduct> _callGetLogicalProduct;

        private readonly gaxgrpc::ApiCall<ListLogicalProductsRequest, ListLogicalProductsResponse> _callListLogicalProducts;

        private readonly gaxgrpc::ApiCall<GetLogicalProductVariantRequest, LogicalProductVariant> _callGetLogicalProductVariant;

        private readonly gaxgrpc::ApiCall<ListLogicalProductVariantsRequest, ListLogicalProductVariantsResponse> _callListLogicalProductVariants;

        private readonly gaxgrpc::ApiCall<LookupEntityRequest, LookupEntityResponse> _callLookupEntity;

        /// <summary>
        /// Constructs a client wrapper for the CloudProductRegistryReadService service, with the specified gRPC client
        /// and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="CloudProductRegistryReadServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CloudProductRegistryReadServiceClientImpl(CloudProductRegistryReadService.CloudProductRegistryReadServiceClient grpcClient, CloudProductRegistryReadServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CloudProductRegistryReadServiceSettings effectiveSettings = settings ?? CloudProductRegistryReadServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetProductSuite = clientHelper.BuildApiCall<GetProductSuiteRequest, ProductSuite>("GetProductSuite", grpcClient.GetProductSuiteAsync, grpcClient.GetProductSuite, effectiveSettings.GetProductSuiteSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetProductSuite);
            Modify_GetProductSuiteApiCall(ref _callGetProductSuite);
            _callListProductSuites = clientHelper.BuildApiCall<ListProductSuitesRequest, ListProductSuitesResponse>("ListProductSuites", grpcClient.ListProductSuitesAsync, grpcClient.ListProductSuites, effectiveSettings.ListProductSuitesSettings);
            Modify_ApiCall(ref _callListProductSuites);
            Modify_ListProductSuitesApiCall(ref _callListProductSuites);
            _callGetLogicalProduct = clientHelper.BuildApiCall<GetLogicalProductRequest, LogicalProduct>("GetLogicalProduct", grpcClient.GetLogicalProductAsync, grpcClient.GetLogicalProduct, effectiveSettings.GetLogicalProductSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetLogicalProduct);
            Modify_GetLogicalProductApiCall(ref _callGetLogicalProduct);
            _callListLogicalProducts = clientHelper.BuildApiCall<ListLogicalProductsRequest, ListLogicalProductsResponse>("ListLogicalProducts", grpcClient.ListLogicalProductsAsync, grpcClient.ListLogicalProducts, effectiveSettings.ListLogicalProductsSettings);
            Modify_ApiCall(ref _callListLogicalProducts);
            Modify_ListLogicalProductsApiCall(ref _callListLogicalProducts);
            _callGetLogicalProductVariant = clientHelper.BuildApiCall<GetLogicalProductVariantRequest, LogicalProductVariant>("GetLogicalProductVariant", grpcClient.GetLogicalProductVariantAsync, grpcClient.GetLogicalProductVariant, effectiveSettings.GetLogicalProductVariantSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetLogicalProductVariant);
            Modify_GetLogicalProductVariantApiCall(ref _callGetLogicalProductVariant);
            _callListLogicalProductVariants = clientHelper.BuildApiCall<ListLogicalProductVariantsRequest, ListLogicalProductVariantsResponse>("ListLogicalProductVariants", grpcClient.ListLogicalProductVariantsAsync, grpcClient.ListLogicalProductVariants, effectiveSettings.ListLogicalProductVariantsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListLogicalProductVariants);
            Modify_ListLogicalProductVariantsApiCall(ref _callListLogicalProductVariants);
            _callLookupEntity = clientHelper.BuildApiCall<LookupEntityRequest, LookupEntityResponse>("LookupEntity", grpcClient.LookupEntityAsync, grpcClient.LookupEntity, effectiveSettings.LookupEntitySettings).WithGoogleRequestParam("lookup_uri", request => request.LookupUri);
            Modify_ApiCall(ref _callLookupEntity);
            Modify_LookupEntityApiCall(ref _callLookupEntity);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetProductSuiteApiCall(ref gaxgrpc::ApiCall<GetProductSuiteRequest, ProductSuite> call);

        partial void Modify_ListProductSuitesApiCall(ref gaxgrpc::ApiCall<ListProductSuitesRequest, ListProductSuitesResponse> call);

        partial void Modify_GetLogicalProductApiCall(ref gaxgrpc::ApiCall<GetLogicalProductRequest, LogicalProduct> call);

        partial void Modify_ListLogicalProductsApiCall(ref gaxgrpc::ApiCall<ListLogicalProductsRequest, ListLogicalProductsResponse> call);

        partial void Modify_GetLogicalProductVariantApiCall(ref gaxgrpc::ApiCall<GetLogicalProductVariantRequest, LogicalProductVariant> call);

        partial void Modify_ListLogicalProductVariantsApiCall(ref gaxgrpc::ApiCall<ListLogicalProductVariantsRequest, ListLogicalProductVariantsResponse> call);

        partial void Modify_LookupEntityApiCall(ref gaxgrpc::ApiCall<LookupEntityRequest, LookupEntityResponse> call);

        partial void OnConstruction(CloudProductRegistryReadService.CloudProductRegistryReadServiceClient grpcClient, CloudProductRegistryReadServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CloudProductRegistryReadService client</summary>
        public override CloudProductRegistryReadService.CloudProductRegistryReadServiceClient GrpcClient { get; }

        partial void Modify_GetProductSuiteRequest(ref GetProductSuiteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListProductSuitesRequest(ref ListProductSuitesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetLogicalProductRequest(ref GetLogicalProductRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListLogicalProductsRequest(ref ListLogicalProductsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetLogicalProductVariantRequest(ref GetLogicalProductVariantRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListLogicalProductVariantsRequest(ref ListLogicalProductVariantsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_LookupEntityRequest(ref LookupEntityRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Get details of a ProductSuite.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ProductSuite GetProductSuite(GetProductSuiteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProductSuiteRequest(ref request, ref callSettings);
            return _callGetProductSuite.Sync(request, callSettings);
        }

        /// <summary>
        /// Get details of a ProductSuite.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ProductSuite> GetProductSuiteAsync(GetProductSuiteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProductSuiteRequest(ref request, ref callSettings);
            return _callGetProductSuite.Async(request, callSettings);
        }

        /// <summary>
        /// Lists ProductSuites.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ProductSuite"/> resources.</returns>
        public override gax::PagedEnumerable<ListProductSuitesResponse, ProductSuite> ListProductSuites(ListProductSuitesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProductSuitesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListProductSuitesRequest, ListProductSuitesResponse, ProductSuite>(_callListProductSuites, request, callSettings);
        }

        /// <summary>
        /// Lists ProductSuites.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ProductSuite"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListProductSuitesResponse, ProductSuite> ListProductSuitesAsync(ListProductSuitesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProductSuitesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListProductSuitesRequest, ListProductSuitesResponse, ProductSuite>(_callListProductSuites, request, callSettings);
        }

        /// <summary>
        /// Gets details of a LogicalProduct.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LogicalProduct GetLogicalProduct(GetLogicalProductRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLogicalProductRequest(ref request, ref callSettings);
            return _callGetLogicalProduct.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a LogicalProduct.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LogicalProduct> GetLogicalProductAsync(GetLogicalProductRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLogicalProductRequest(ref request, ref callSettings);
            return _callGetLogicalProduct.Async(request, callSettings);
        }

        /// <summary>
        /// Lists LogicalProducts matching given criteria.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LogicalProduct"/> resources.</returns>
        public override gax::PagedEnumerable<ListLogicalProductsResponse, LogicalProduct> ListLogicalProducts(ListLogicalProductsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLogicalProductsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListLogicalProductsRequest, ListLogicalProductsResponse, LogicalProduct>(_callListLogicalProducts, request, callSettings);
        }

        /// <summary>
        /// Lists LogicalProducts matching given criteria.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LogicalProduct"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListLogicalProductsResponse, LogicalProduct> ListLogicalProductsAsync(ListLogicalProductsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLogicalProductsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListLogicalProductsRequest, ListLogicalProductsResponse, LogicalProduct>(_callListLogicalProducts, request, callSettings);
        }

        /// <summary>
        /// Get details of a LogicalProductVariant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LogicalProductVariant GetLogicalProductVariant(GetLogicalProductVariantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLogicalProductVariantRequest(ref request, ref callSettings);
            return _callGetLogicalProductVariant.Sync(request, callSettings);
        }

        /// <summary>
        /// Get details of a LogicalProductVariant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LogicalProductVariant> GetLogicalProductVariantAsync(GetLogicalProductVariantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLogicalProductVariantRequest(ref request, ref callSettings);
            return _callGetLogicalProductVariant.Async(request, callSettings);
        }

        /// <summary>
        /// Lists LogicalProductVariants matching given criteria.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LogicalProductVariant"/> resources.</returns>
        public override gax::PagedEnumerable<ListLogicalProductVariantsResponse, LogicalProductVariant> ListLogicalProductVariants(ListLogicalProductVariantsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLogicalProductVariantsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListLogicalProductVariantsRequest, ListLogicalProductVariantsResponse, LogicalProductVariant>(_callListLogicalProductVariants, request, callSettings);
        }

        /// <summary>
        /// Lists LogicalProductVariants matching given criteria.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LogicalProductVariant"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListLogicalProductVariantsResponse, LogicalProductVariant> ListLogicalProductVariantsAsync(ListLogicalProductVariantsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLogicalProductVariantsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListLogicalProductVariantsRequest, ListLogicalProductVariantsResponse, LogicalProductVariant>(_callListLogicalProductVariants, request, callSettings);
        }

        /// <summary>
        /// Look up entities.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LookupEntityResponse LookupEntity(LookupEntityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LookupEntityRequest(ref request, ref callSettings);
            return _callLookupEntity.Sync(request, callSettings);
        }

        /// <summary>
        /// Look up entities.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LookupEntityResponse> LookupEntityAsync(LookupEntityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LookupEntityRequest(ref request, ref callSettings);
            return _callLookupEntity.Async(request, callSettings);
        }
    }

    public partial class ListProductSuitesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListLogicalProductsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListLogicalProductVariantsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListProductSuitesResponse : gaxgrpc::IPageResponse<ProductSuite>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ProductSuite> GetEnumerator() => ProductSuites.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListLogicalProductsResponse : gaxgrpc::IPageResponse<LogicalProduct>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<LogicalProduct> GetEnumerator() => LogicalProducts.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListLogicalProductVariantsResponse : gaxgrpc::IPageResponse<LogicalProductVariant>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<LogicalProductVariant> GetEnumerator() => LogicalProductVariants.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
