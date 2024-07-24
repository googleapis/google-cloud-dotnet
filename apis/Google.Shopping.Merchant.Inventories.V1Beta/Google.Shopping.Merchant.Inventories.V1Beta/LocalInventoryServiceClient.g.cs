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

namespace Google.Shopping.Merchant.Inventories.V1Beta
{
    /// <summary>Settings for <see cref="LocalInventoryServiceClient"/> instances.</summary>
    public sealed partial class LocalInventoryServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="LocalInventoryServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="LocalInventoryServiceSettings"/>.</returns>
        public static LocalInventoryServiceSettings GetDefault() => new LocalInventoryServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="LocalInventoryServiceSettings"/> object with default settings.
        /// </summary>
        public LocalInventoryServiceSettings()
        {
        }

        private LocalInventoryServiceSettings(LocalInventoryServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListLocalInventoriesSettings = existing.ListLocalInventoriesSettings;
            InsertLocalInventorySettings = existing.InsertLocalInventorySettings;
            DeleteLocalInventorySettings = existing.DeleteLocalInventorySettings;
            OnCopy(existing);
        }

        partial void OnCopy(LocalInventoryServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LocalInventoryServiceClient.ListLocalInventories</c> and
        /// <c>LocalInventoryServiceClient.ListLocalInventoriesAsync</c>.
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
        public gaxgrpc::CallSettings ListLocalInventoriesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LocalInventoryServiceClient.InsertLocalInventory</c> and
        /// <c>LocalInventoryServiceClient.InsertLocalInventoryAsync</c>.
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
        public gaxgrpc::CallSettings InsertLocalInventorySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LocalInventoryServiceClient.DeleteLocalInventory</c> and
        /// <c>LocalInventoryServiceClient.DeleteLocalInventoryAsync</c>.
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
        public gaxgrpc::CallSettings DeleteLocalInventorySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="LocalInventoryServiceSettings"/> object.</returns>
        public LocalInventoryServiceSettings Clone() => new LocalInventoryServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="LocalInventoryServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class LocalInventoryServiceClientBuilder : gaxgrpc::ClientBuilderBase<LocalInventoryServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public LocalInventoryServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public LocalInventoryServiceClientBuilder() : base(LocalInventoryServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref LocalInventoryServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<LocalInventoryServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override LocalInventoryServiceClient Build()
        {
            LocalInventoryServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<LocalInventoryServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<LocalInventoryServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private LocalInventoryServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return LocalInventoryServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<LocalInventoryServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return LocalInventoryServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => LocalInventoryServiceClient.ChannelPool;
    }

    /// <summary>LocalInventoryService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage local inventory for products
    /// </remarks>
    public abstract partial class LocalInventoryServiceClient
    {
        /// <summary>
        /// The default endpoint for the LocalInventoryService service, which is a host of "merchantapi.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "merchantapi.googleapis.com:443";

        /// <summary>The default LocalInventoryService scopes.</summary>
        /// <remarks>
        /// The default LocalInventoryService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(LocalInventoryService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="LocalInventoryServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="LocalInventoryServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="LocalInventoryServiceClient"/>.</returns>
        public static stt::Task<LocalInventoryServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new LocalInventoryServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="LocalInventoryServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="LocalInventoryServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="LocalInventoryServiceClient"/>.</returns>
        public static LocalInventoryServiceClient Create() => new LocalInventoryServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="LocalInventoryServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="LocalInventoryServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="LocalInventoryServiceClient"/>.</returns>
        internal static LocalInventoryServiceClient Create(grpccore::CallInvoker callInvoker, LocalInventoryServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            LocalInventoryService.LocalInventoryServiceClient grpcClient = new LocalInventoryService.LocalInventoryServiceClient(callInvoker);
            return new LocalInventoryServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC LocalInventoryService client</summary>
        public virtual LocalInventoryService.LocalInventoryServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the `LocalInventory` resources for the given product in your merchant
        /// account. The response might contain fewer items than specified by
        /// `pageSize`. If `pageToken` was returned in previous request, it can be used
        /// to obtain additional results.
        /// 
        /// `LocalInventory` resources are listed per product for a given account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LocalInventory"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLocalInventoriesResponse, LocalInventory> ListLocalInventories(ListLocalInventoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the `LocalInventory` resources for the given product in your merchant
        /// account. The response might contain fewer items than specified by
        /// `pageSize`. If `pageToken` was returned in previous request, it can be used
        /// to obtain additional results.
        /// 
        /// `LocalInventory` resources are listed per product for a given account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LocalInventory"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLocalInventoriesResponse, LocalInventory> ListLocalInventoriesAsync(ListLocalInventoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the `LocalInventory` resources for the given product in your merchant
        /// account. The response might contain fewer items than specified by
        /// `pageSize`. If `pageToken` was returned in previous request, it can be used
        /// to obtain additional results.
        /// 
        /// `LocalInventory` resources are listed per product for a given account.
        /// </summary>
        /// <param name="parent">
        /// Required. The `name` of the parent product to list local inventories for.
        /// Format:
        /// `accounts/{account}/products/{product}`
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
        /// <returns>A pageable sequence of <see cref="LocalInventory"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLocalInventoriesResponse, LocalInventory> ListLocalInventories(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLocalInventoriesRequest request = new ListLocalInventoriesRequest
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
            return ListLocalInventories(request, callSettings);
        }

        /// <summary>
        /// Lists the `LocalInventory` resources for the given product in your merchant
        /// account. The response might contain fewer items than specified by
        /// `pageSize`. If `pageToken` was returned in previous request, it can be used
        /// to obtain additional results.
        /// 
        /// `LocalInventory` resources are listed per product for a given account.
        /// </summary>
        /// <param name="parent">
        /// Required. The `name` of the parent product to list local inventories for.
        /// Format:
        /// `accounts/{account}/products/{product}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="LocalInventory"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLocalInventoriesResponse, LocalInventory> ListLocalInventoriesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLocalInventoriesRequest request = new ListLocalInventoriesRequest
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
            return ListLocalInventoriesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the `LocalInventory` resources for the given product in your merchant
        /// account. The response might contain fewer items than specified by
        /// `pageSize`. If `pageToken` was returned in previous request, it can be used
        /// to obtain additional results.
        /// 
        /// `LocalInventory` resources are listed per product for a given account.
        /// </summary>
        /// <param name="parent">
        /// Required. The `name` of the parent product to list local inventories for.
        /// Format:
        /// `accounts/{account}/products/{product}`
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
        /// <returns>A pageable sequence of <see cref="LocalInventory"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLocalInventoriesResponse, LocalInventory> ListLocalInventories(ProductName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLocalInventoriesRequest request = new ListLocalInventoriesRequest
            {
                ParentAsProductName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListLocalInventories(request, callSettings);
        }

        /// <summary>
        /// Lists the `LocalInventory` resources for the given product in your merchant
        /// account. The response might contain fewer items than specified by
        /// `pageSize`. If `pageToken` was returned in previous request, it can be used
        /// to obtain additional results.
        /// 
        /// `LocalInventory` resources are listed per product for a given account.
        /// </summary>
        /// <param name="parent">
        /// Required. The `name` of the parent product to list local inventories for.
        /// Format:
        /// `accounts/{account}/products/{product}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="LocalInventory"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLocalInventoriesResponse, LocalInventory> ListLocalInventoriesAsync(ProductName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLocalInventoriesRequest request = new ListLocalInventoriesRequest
            {
                ParentAsProductName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListLocalInventoriesAsync(request, callSettings);
        }

        /// <summary>
        /// Inserts a `LocalInventory` resource to a product in your merchant
        /// account.
        /// 
        /// Replaces the full `LocalInventory` resource if an entry with the same
        /// [`storeCode`][google.shopping.merchant.inventories.v1beta.LocalInventory.store_code]
        /// already exists for the product.
        /// 
        /// It might take up to 30 minutes for the new or updated `LocalInventory`
        /// resource to appear in products.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LocalInventory InsertLocalInventory(InsertLocalInventoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Inserts a `LocalInventory` resource to a product in your merchant
        /// account.
        /// 
        /// Replaces the full `LocalInventory` resource if an entry with the same
        /// [`storeCode`][google.shopping.merchant.inventories.v1beta.LocalInventory.store_code]
        /// already exists for the product.
        /// 
        /// It might take up to 30 minutes for the new or updated `LocalInventory`
        /// resource to appear in products.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LocalInventory> InsertLocalInventoryAsync(InsertLocalInventoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Inserts a `LocalInventory` resource to a product in your merchant
        /// account.
        /// 
        /// Replaces the full `LocalInventory` resource if an entry with the same
        /// [`storeCode`][google.shopping.merchant.inventories.v1beta.LocalInventory.store_code]
        /// already exists for the product.
        /// 
        /// It might take up to 30 minutes for the new or updated `LocalInventory`
        /// resource to appear in products.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LocalInventory> InsertLocalInventoryAsync(InsertLocalInventoryRequest request, st::CancellationToken cancellationToken) =>
            InsertLocalInventoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified `LocalInventory` from the given product in your
        /// merchant account. It might take a up to an hour for the
        /// `LocalInventory` to be deleted from the specific product.
        /// Once you have received a successful delete response, wait for that
        /// period before attempting a delete again.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteLocalInventory(DeleteLocalInventoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified `LocalInventory` from the given product in your
        /// merchant account. It might take a up to an hour for the
        /// `LocalInventory` to be deleted from the specific product.
        /// Once you have received a successful delete response, wait for that
        /// period before attempting a delete again.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteLocalInventoryAsync(DeleteLocalInventoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified `LocalInventory` from the given product in your
        /// merchant account. It might take a up to an hour for the
        /// `LocalInventory` to be deleted from the specific product.
        /// Once you have received a successful delete response, wait for that
        /// period before attempting a delete again.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteLocalInventoryAsync(DeleteLocalInventoryRequest request, st::CancellationToken cancellationToken) =>
            DeleteLocalInventoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified `LocalInventory` from the given product in your
        /// merchant account. It might take a up to an hour for the
        /// `LocalInventory` to be deleted from the specific product.
        /// Once you have received a successful delete response, wait for that
        /// period before attempting a delete again.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the local inventory for the given product to delete.
        /// Format:
        /// `accounts/{account}/products/{product}/localInventories/{store_code}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteLocalInventory(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteLocalInventory(new DeleteLocalInventoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified `LocalInventory` from the given product in your
        /// merchant account. It might take a up to an hour for the
        /// `LocalInventory` to be deleted from the specific product.
        /// Once you have received a successful delete response, wait for that
        /// period before attempting a delete again.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the local inventory for the given product to delete.
        /// Format:
        /// `accounts/{account}/products/{product}/localInventories/{store_code}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteLocalInventoryAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteLocalInventoryAsync(new DeleteLocalInventoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified `LocalInventory` from the given product in your
        /// merchant account. It might take a up to an hour for the
        /// `LocalInventory` to be deleted from the specific product.
        /// Once you have received a successful delete response, wait for that
        /// period before attempting a delete again.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the local inventory for the given product to delete.
        /// Format:
        /// `accounts/{account}/products/{product}/localInventories/{store_code}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteLocalInventoryAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteLocalInventoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified `LocalInventory` from the given product in your
        /// merchant account. It might take a up to an hour for the
        /// `LocalInventory` to be deleted from the specific product.
        /// Once you have received a successful delete response, wait for that
        /// period before attempting a delete again.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the local inventory for the given product to delete.
        /// Format:
        /// `accounts/{account}/products/{product}/localInventories/{store_code}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteLocalInventory(LocalInventoryName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteLocalInventory(new DeleteLocalInventoryRequest
            {
                LocalInventoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified `LocalInventory` from the given product in your
        /// merchant account. It might take a up to an hour for the
        /// `LocalInventory` to be deleted from the specific product.
        /// Once you have received a successful delete response, wait for that
        /// period before attempting a delete again.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the local inventory for the given product to delete.
        /// Format:
        /// `accounts/{account}/products/{product}/localInventories/{store_code}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteLocalInventoryAsync(LocalInventoryName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteLocalInventoryAsync(new DeleteLocalInventoryRequest
            {
                LocalInventoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified `LocalInventory` from the given product in your
        /// merchant account. It might take a up to an hour for the
        /// `LocalInventory` to be deleted from the specific product.
        /// Once you have received a successful delete response, wait for that
        /// period before attempting a delete again.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the local inventory for the given product to delete.
        /// Format:
        /// `accounts/{account}/products/{product}/localInventories/{store_code}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteLocalInventoryAsync(LocalInventoryName name, st::CancellationToken cancellationToken) =>
            DeleteLocalInventoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>LocalInventoryService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage local inventory for products
    /// </remarks>
    public sealed partial class LocalInventoryServiceClientImpl : LocalInventoryServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListLocalInventoriesRequest, ListLocalInventoriesResponse> _callListLocalInventories;

        private readonly gaxgrpc::ApiCall<InsertLocalInventoryRequest, LocalInventory> _callInsertLocalInventory;

        private readonly gaxgrpc::ApiCall<DeleteLocalInventoryRequest, wkt::Empty> _callDeleteLocalInventory;

        /// <summary>
        /// Constructs a client wrapper for the LocalInventoryService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="LocalInventoryServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public LocalInventoryServiceClientImpl(LocalInventoryService.LocalInventoryServiceClient grpcClient, LocalInventoryServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            LocalInventoryServiceSettings effectiveSettings = settings ?? LocalInventoryServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callListLocalInventories = clientHelper.BuildApiCall<ListLocalInventoriesRequest, ListLocalInventoriesResponse>("ListLocalInventories", grpcClient.ListLocalInventoriesAsync, grpcClient.ListLocalInventories, effectiveSettings.ListLocalInventoriesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListLocalInventories);
            Modify_ListLocalInventoriesApiCall(ref _callListLocalInventories);
            _callInsertLocalInventory = clientHelper.BuildApiCall<InsertLocalInventoryRequest, LocalInventory>("InsertLocalInventory", grpcClient.InsertLocalInventoryAsync, grpcClient.InsertLocalInventory, effectiveSettings.InsertLocalInventorySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callInsertLocalInventory);
            Modify_InsertLocalInventoryApiCall(ref _callInsertLocalInventory);
            _callDeleteLocalInventory = clientHelper.BuildApiCall<DeleteLocalInventoryRequest, wkt::Empty>("DeleteLocalInventory", grpcClient.DeleteLocalInventoryAsync, grpcClient.DeleteLocalInventory, effectiveSettings.DeleteLocalInventorySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteLocalInventory);
            Modify_DeleteLocalInventoryApiCall(ref _callDeleteLocalInventory);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListLocalInventoriesApiCall(ref gaxgrpc::ApiCall<ListLocalInventoriesRequest, ListLocalInventoriesResponse> call);

        partial void Modify_InsertLocalInventoryApiCall(ref gaxgrpc::ApiCall<InsertLocalInventoryRequest, LocalInventory> call);

        partial void Modify_DeleteLocalInventoryApiCall(ref gaxgrpc::ApiCall<DeleteLocalInventoryRequest, wkt::Empty> call);

        partial void OnConstruction(LocalInventoryService.LocalInventoryServiceClient grpcClient, LocalInventoryServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC LocalInventoryService client</summary>
        public override LocalInventoryService.LocalInventoryServiceClient GrpcClient { get; }

        partial void Modify_ListLocalInventoriesRequest(ref ListLocalInventoriesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InsertLocalInventoryRequest(ref InsertLocalInventoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteLocalInventoryRequest(ref DeleteLocalInventoryRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists the `LocalInventory` resources for the given product in your merchant
        /// account. The response might contain fewer items than specified by
        /// `pageSize`. If `pageToken` was returned in previous request, it can be used
        /// to obtain additional results.
        /// 
        /// `LocalInventory` resources are listed per product for a given account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LocalInventory"/> resources.</returns>
        public override gax::PagedEnumerable<ListLocalInventoriesResponse, LocalInventory> ListLocalInventories(ListLocalInventoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLocalInventoriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListLocalInventoriesRequest, ListLocalInventoriesResponse, LocalInventory>(_callListLocalInventories, request, callSettings);
        }

        /// <summary>
        /// Lists the `LocalInventory` resources for the given product in your merchant
        /// account. The response might contain fewer items than specified by
        /// `pageSize`. If `pageToken` was returned in previous request, it can be used
        /// to obtain additional results.
        /// 
        /// `LocalInventory` resources are listed per product for a given account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LocalInventory"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListLocalInventoriesResponse, LocalInventory> ListLocalInventoriesAsync(ListLocalInventoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLocalInventoriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListLocalInventoriesRequest, ListLocalInventoriesResponse, LocalInventory>(_callListLocalInventories, request, callSettings);
        }

        /// <summary>
        /// Inserts a `LocalInventory` resource to a product in your merchant
        /// account.
        /// 
        /// Replaces the full `LocalInventory` resource if an entry with the same
        /// [`storeCode`][google.shopping.merchant.inventories.v1beta.LocalInventory.store_code]
        /// already exists for the product.
        /// 
        /// It might take up to 30 minutes for the new or updated `LocalInventory`
        /// resource to appear in products.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LocalInventory InsertLocalInventory(InsertLocalInventoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertLocalInventoryRequest(ref request, ref callSettings);
            return _callInsertLocalInventory.Sync(request, callSettings);
        }

        /// <summary>
        /// Inserts a `LocalInventory` resource to a product in your merchant
        /// account.
        /// 
        /// Replaces the full `LocalInventory` resource if an entry with the same
        /// [`storeCode`][google.shopping.merchant.inventories.v1beta.LocalInventory.store_code]
        /// already exists for the product.
        /// 
        /// It might take up to 30 minutes for the new or updated `LocalInventory`
        /// resource to appear in products.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LocalInventory> InsertLocalInventoryAsync(InsertLocalInventoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertLocalInventoryRequest(ref request, ref callSettings);
            return _callInsertLocalInventory.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified `LocalInventory` from the given product in your
        /// merchant account. It might take a up to an hour for the
        /// `LocalInventory` to be deleted from the specific product.
        /// Once you have received a successful delete response, wait for that
        /// period before attempting a delete again.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteLocalInventory(DeleteLocalInventoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteLocalInventoryRequest(ref request, ref callSettings);
            _callDeleteLocalInventory.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified `LocalInventory` from the given product in your
        /// merchant account. It might take a up to an hour for the
        /// `LocalInventory` to be deleted from the specific product.
        /// Once you have received a successful delete response, wait for that
        /// period before attempting a delete again.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteLocalInventoryAsync(DeleteLocalInventoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteLocalInventoryRequest(ref request, ref callSettings);
            return _callDeleteLocalInventory.Async(request, callSettings);
        }
    }

    public partial class ListLocalInventoriesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListLocalInventoriesResponse : gaxgrpc::IPageResponse<LocalInventory>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<LocalInventory> GetEnumerator() => LocalInventories.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
