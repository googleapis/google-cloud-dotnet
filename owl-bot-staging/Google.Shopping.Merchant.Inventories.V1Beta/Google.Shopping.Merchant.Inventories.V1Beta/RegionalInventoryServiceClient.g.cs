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
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Shopping.Merchant.Inventories.V1Beta
{
    /// <summary>Settings for <see cref="RegionalInventoryServiceClient"/> instances.</summary>
    public sealed partial class RegionalInventoryServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="RegionalInventoryServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="RegionalInventoryServiceSettings"/>.</returns>
        public static RegionalInventoryServiceSettings GetDefault() => new RegionalInventoryServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="RegionalInventoryServiceSettings"/> object with default settings.
        /// </summary>
        public RegionalInventoryServiceSettings()
        {
        }

        private RegionalInventoryServiceSettings(RegionalInventoryServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListRegionalInventoriesSettings = existing.ListRegionalInventoriesSettings;
            InsertRegionalInventorySettings = existing.InsertRegionalInventorySettings;
            DeleteRegionalInventorySettings = existing.DeleteRegionalInventorySettings;
            OnCopy(existing);
        }

        partial void OnCopy(RegionalInventoryServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionalInventoryServiceClient.ListRegionalInventories</c> and
        /// <c>RegionalInventoryServiceClient.ListRegionalInventoriesAsync</c>.
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
        public gaxgrpc::CallSettings ListRegionalInventoriesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionalInventoryServiceClient.InsertRegionalInventory</c> and
        /// <c>RegionalInventoryServiceClient.InsertRegionalInventoryAsync</c>.
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
        public gaxgrpc::CallSettings InsertRegionalInventorySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionalInventoryServiceClient.DeleteRegionalInventory</c> and
        /// <c>RegionalInventoryServiceClient.DeleteRegionalInventoryAsync</c>.
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
        public gaxgrpc::CallSettings DeleteRegionalInventorySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="RegionalInventoryServiceSettings"/> object.</returns>
        public RegionalInventoryServiceSettings Clone() => new RegionalInventoryServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="RegionalInventoryServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class RegionalInventoryServiceClientBuilder : gaxgrpc::ClientBuilderBase<RegionalInventoryServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public RegionalInventoryServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public RegionalInventoryServiceClientBuilder() : base(RegionalInventoryServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref RegionalInventoryServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<RegionalInventoryServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override RegionalInventoryServiceClient Build()
        {
            RegionalInventoryServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<RegionalInventoryServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<RegionalInventoryServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private RegionalInventoryServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return RegionalInventoryServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<RegionalInventoryServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return RegionalInventoryServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => RegionalInventoryServiceClient.ChannelPool;
    }

    /// <summary>RegionalInventoryService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage regional inventory for products. There is also separate
    /// `regions` resource and API to manage regions definitions.
    /// </remarks>
    public abstract partial class RegionalInventoryServiceClient
    {
        /// <summary>
        /// The default endpoint for the RegionalInventoryService service, which is a host of
        /// "merchantapi.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "merchantapi.googleapis.com:443";

        /// <summary>The default RegionalInventoryService scopes.</summary>
        /// <remarks>
        /// The default RegionalInventoryService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(RegionalInventoryService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="RegionalInventoryServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="RegionalInventoryServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="RegionalInventoryServiceClient"/>.</returns>
        public static stt::Task<RegionalInventoryServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new RegionalInventoryServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="RegionalInventoryServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="RegionalInventoryServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="RegionalInventoryServiceClient"/>.</returns>
        public static RegionalInventoryServiceClient Create() => new RegionalInventoryServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="RegionalInventoryServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="RegionalInventoryServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="RegionalInventoryServiceClient"/>.</returns>
        internal static RegionalInventoryServiceClient Create(grpccore::CallInvoker callInvoker, RegionalInventoryServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            RegionalInventoryService.RegionalInventoryServiceClient grpcClient = new RegionalInventoryService.RegionalInventoryServiceClient(callInvoker);
            return new RegionalInventoryServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC RegionalInventoryService client</summary>
        public virtual RegionalInventoryService.RegionalInventoryServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the `RegionalInventory` resources for the given product in your
        /// merchant account. The response might contain fewer items than specified by
        /// `pageSize`.  If `pageToken` was returned in previous request, it can be
        /// used to obtain additional results.
        /// 
        /// `RegionalInventory` resources are listed per product for a given account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RegionalInventory"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRegionalInventoriesResponse, RegionalInventory> ListRegionalInventories(ListRegionalInventoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the `RegionalInventory` resources for the given product in your
        /// merchant account. The response might contain fewer items than specified by
        /// `pageSize`.  If `pageToken` was returned in previous request, it can be
        /// used to obtain additional results.
        /// 
        /// `RegionalInventory` resources are listed per product for a given account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RegionalInventory"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRegionalInventoriesResponse, RegionalInventory> ListRegionalInventoriesAsync(ListRegionalInventoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the `RegionalInventory` resources for the given product in your
        /// merchant account. The response might contain fewer items than specified by
        /// `pageSize`.  If `pageToken` was returned in previous request, it can be
        /// used to obtain additional results.
        /// 
        /// `RegionalInventory` resources are listed per product for a given account.
        /// </summary>
        /// <param name="parent">
        /// Required. The `name` of the parent product to list `RegionalInventory`
        /// resources for. Format: `accounts/{account}/products/{product}`
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
        /// <returns>A pageable sequence of <see cref="RegionalInventory"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRegionalInventoriesResponse, RegionalInventory> ListRegionalInventories(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRegionalInventoriesRequest request = new ListRegionalInventoriesRequest
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
            return ListRegionalInventories(request, callSettings);
        }

        /// <summary>
        /// Lists the `RegionalInventory` resources for the given product in your
        /// merchant account. The response might contain fewer items than specified by
        /// `pageSize`.  If `pageToken` was returned in previous request, it can be
        /// used to obtain additional results.
        /// 
        /// `RegionalInventory` resources are listed per product for a given account.
        /// </summary>
        /// <param name="parent">
        /// Required. The `name` of the parent product to list `RegionalInventory`
        /// resources for. Format: `accounts/{account}/products/{product}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="RegionalInventory"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRegionalInventoriesResponse, RegionalInventory> ListRegionalInventoriesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRegionalInventoriesRequest request = new ListRegionalInventoriesRequest
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
            return ListRegionalInventoriesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the `RegionalInventory` resources for the given product in your
        /// merchant account. The response might contain fewer items than specified by
        /// `pageSize`.  If `pageToken` was returned in previous request, it can be
        /// used to obtain additional results.
        /// 
        /// `RegionalInventory` resources are listed per product for a given account.
        /// </summary>
        /// <param name="parent">
        /// Required. The `name` of the parent product to list `RegionalInventory`
        /// resources for. Format: `accounts/{account}/products/{product}`
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
        /// <returns>A pageable sequence of <see cref="RegionalInventory"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRegionalInventoriesResponse, RegionalInventory> ListRegionalInventories(ProductName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRegionalInventoriesRequest request = new ListRegionalInventoriesRequest
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
            return ListRegionalInventories(request, callSettings);
        }

        /// <summary>
        /// Lists the `RegionalInventory` resources for the given product in your
        /// merchant account. The response might contain fewer items than specified by
        /// `pageSize`.  If `pageToken` was returned in previous request, it can be
        /// used to obtain additional results.
        /// 
        /// `RegionalInventory` resources are listed per product for a given account.
        /// </summary>
        /// <param name="parent">
        /// Required. The `name` of the parent product to list `RegionalInventory`
        /// resources for. Format: `accounts/{account}/products/{product}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="RegionalInventory"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRegionalInventoriesResponse, RegionalInventory> ListRegionalInventoriesAsync(ProductName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRegionalInventoriesRequest request = new ListRegionalInventoriesRequest
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
            return ListRegionalInventoriesAsync(request, callSettings);
        }

        /// <summary>
        /// Inserts a `RegionalInventory` to a given product in your
        /// merchant account.
        /// 
        /// Replaces the full `RegionalInventory` resource if an entry with the same
        /// [`region`][google.shopping.merchant.inventories.v1beta.RegionalInventory.region]
        /// already exists for the product.
        /// 
        /// It might take up to 30 minutes for the new or updated `RegionalInventory`
        /// resource to appear in products.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RegionalInventory InsertRegionalInventory(InsertRegionalInventoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Inserts a `RegionalInventory` to a given product in your
        /// merchant account.
        /// 
        /// Replaces the full `RegionalInventory` resource if an entry with the same
        /// [`region`][google.shopping.merchant.inventories.v1beta.RegionalInventory.region]
        /// already exists for the product.
        /// 
        /// It might take up to 30 minutes for the new or updated `RegionalInventory`
        /// resource to appear in products.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RegionalInventory> InsertRegionalInventoryAsync(InsertRegionalInventoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Inserts a `RegionalInventory` to a given product in your
        /// merchant account.
        /// 
        /// Replaces the full `RegionalInventory` resource if an entry with the same
        /// [`region`][google.shopping.merchant.inventories.v1beta.RegionalInventory.region]
        /// already exists for the product.
        /// 
        /// It might take up to 30 minutes for the new or updated `RegionalInventory`
        /// resource to appear in products.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RegionalInventory> InsertRegionalInventoryAsync(InsertRegionalInventoryRequest request, st::CancellationToken cancellationToken) =>
            InsertRegionalInventoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified `RegionalInventory` resource from the given product
        /// in your merchant account.  It might take up to an hour for the
        /// `RegionalInventory` to be deleted from the specific product.
        /// Once you have received a successful delete response, wait for that
        /// period before attempting a delete again.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteRegionalInventory(DeleteRegionalInventoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified `RegionalInventory` resource from the given product
        /// in your merchant account.  It might take up to an hour for the
        /// `RegionalInventory` to be deleted from the specific product.
        /// Once you have received a successful delete response, wait for that
        /// period before attempting a delete again.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRegionalInventoryAsync(DeleteRegionalInventoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified `RegionalInventory` resource from the given product
        /// in your merchant account.  It might take up to an hour for the
        /// `RegionalInventory` to be deleted from the specific product.
        /// Once you have received a successful delete response, wait for that
        /// period before attempting a delete again.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRegionalInventoryAsync(DeleteRegionalInventoryRequest request, st::CancellationToken cancellationToken) =>
            DeleteRegionalInventoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified `RegionalInventory` resource from the given product
        /// in your merchant account.  It might take up to an hour for the
        /// `RegionalInventory` to be deleted from the specific product.
        /// Once you have received a successful delete response, wait for that
        /// period before attempting a delete again.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `RegionalInventory` resource to delete.
        /// Format:
        /// `accounts/{account}/products/{product}/regionalInventories/{region}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteRegionalInventory(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRegionalInventory(new DeleteRegionalInventoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified `RegionalInventory` resource from the given product
        /// in your merchant account.  It might take up to an hour for the
        /// `RegionalInventory` to be deleted from the specific product.
        /// Once you have received a successful delete response, wait for that
        /// period before attempting a delete again.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `RegionalInventory` resource to delete.
        /// Format:
        /// `accounts/{account}/products/{product}/regionalInventories/{region}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRegionalInventoryAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRegionalInventoryAsync(new DeleteRegionalInventoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified `RegionalInventory` resource from the given product
        /// in your merchant account.  It might take up to an hour for the
        /// `RegionalInventory` to be deleted from the specific product.
        /// Once you have received a successful delete response, wait for that
        /// period before attempting a delete again.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `RegionalInventory` resource to delete.
        /// Format:
        /// `accounts/{account}/products/{product}/regionalInventories/{region}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRegionalInventoryAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteRegionalInventoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified `RegionalInventory` resource from the given product
        /// in your merchant account.  It might take up to an hour for the
        /// `RegionalInventory` to be deleted from the specific product.
        /// Once you have received a successful delete response, wait for that
        /// period before attempting a delete again.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `RegionalInventory` resource to delete.
        /// Format:
        /// `accounts/{account}/products/{product}/regionalInventories/{region}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteRegionalInventory(RegionalInventoryName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRegionalInventory(new DeleteRegionalInventoryRequest
            {
                RegionalInventoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified `RegionalInventory` resource from the given product
        /// in your merchant account.  It might take up to an hour for the
        /// `RegionalInventory` to be deleted from the specific product.
        /// Once you have received a successful delete response, wait for that
        /// period before attempting a delete again.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `RegionalInventory` resource to delete.
        /// Format:
        /// `accounts/{account}/products/{product}/regionalInventories/{region}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRegionalInventoryAsync(RegionalInventoryName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRegionalInventoryAsync(new DeleteRegionalInventoryRequest
            {
                RegionalInventoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified `RegionalInventory` resource from the given product
        /// in your merchant account.  It might take up to an hour for the
        /// `RegionalInventory` to be deleted from the specific product.
        /// Once you have received a successful delete response, wait for that
        /// period before attempting a delete again.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `RegionalInventory` resource to delete.
        /// Format:
        /// `accounts/{account}/products/{product}/regionalInventories/{region}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRegionalInventoryAsync(RegionalInventoryName name, st::CancellationToken cancellationToken) =>
            DeleteRegionalInventoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>RegionalInventoryService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage regional inventory for products. There is also separate
    /// `regions` resource and API to manage regions definitions.
    /// </remarks>
    public sealed partial class RegionalInventoryServiceClientImpl : RegionalInventoryServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListRegionalInventoriesRequest, ListRegionalInventoriesResponse> _callListRegionalInventories;

        private readonly gaxgrpc::ApiCall<InsertRegionalInventoryRequest, RegionalInventory> _callInsertRegionalInventory;

        private readonly gaxgrpc::ApiCall<DeleteRegionalInventoryRequest, wkt::Empty> _callDeleteRegionalInventory;

        /// <summary>
        /// Constructs a client wrapper for the RegionalInventoryService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="RegionalInventoryServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public RegionalInventoryServiceClientImpl(RegionalInventoryService.RegionalInventoryServiceClient grpcClient, RegionalInventoryServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            RegionalInventoryServiceSettings effectiveSettings = settings ?? RegionalInventoryServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callListRegionalInventories = clientHelper.BuildApiCall<ListRegionalInventoriesRequest, ListRegionalInventoriesResponse>("ListRegionalInventories", grpcClient.ListRegionalInventoriesAsync, grpcClient.ListRegionalInventories, effectiveSettings.ListRegionalInventoriesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRegionalInventories);
            Modify_ListRegionalInventoriesApiCall(ref _callListRegionalInventories);
            _callInsertRegionalInventory = clientHelper.BuildApiCall<InsertRegionalInventoryRequest, RegionalInventory>("InsertRegionalInventory", grpcClient.InsertRegionalInventoryAsync, grpcClient.InsertRegionalInventory, effectiveSettings.InsertRegionalInventorySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callInsertRegionalInventory);
            Modify_InsertRegionalInventoryApiCall(ref _callInsertRegionalInventory);
            _callDeleteRegionalInventory = clientHelper.BuildApiCall<DeleteRegionalInventoryRequest, wkt::Empty>("DeleteRegionalInventory", grpcClient.DeleteRegionalInventoryAsync, grpcClient.DeleteRegionalInventory, effectiveSettings.DeleteRegionalInventorySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteRegionalInventory);
            Modify_DeleteRegionalInventoryApiCall(ref _callDeleteRegionalInventory);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListRegionalInventoriesApiCall(ref gaxgrpc::ApiCall<ListRegionalInventoriesRequest, ListRegionalInventoriesResponse> call);

        partial void Modify_InsertRegionalInventoryApiCall(ref gaxgrpc::ApiCall<InsertRegionalInventoryRequest, RegionalInventory> call);

        partial void Modify_DeleteRegionalInventoryApiCall(ref gaxgrpc::ApiCall<DeleteRegionalInventoryRequest, wkt::Empty> call);

        partial void OnConstruction(RegionalInventoryService.RegionalInventoryServiceClient grpcClient, RegionalInventoryServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC RegionalInventoryService client</summary>
        public override RegionalInventoryService.RegionalInventoryServiceClient GrpcClient { get; }

        partial void Modify_ListRegionalInventoriesRequest(ref ListRegionalInventoriesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InsertRegionalInventoryRequest(ref InsertRegionalInventoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteRegionalInventoryRequest(ref DeleteRegionalInventoryRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists the `RegionalInventory` resources for the given product in your
        /// merchant account. The response might contain fewer items than specified by
        /// `pageSize`.  If `pageToken` was returned in previous request, it can be
        /// used to obtain additional results.
        /// 
        /// `RegionalInventory` resources are listed per product for a given account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RegionalInventory"/> resources.</returns>
        public override gax::PagedEnumerable<ListRegionalInventoriesResponse, RegionalInventory> ListRegionalInventories(ListRegionalInventoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRegionalInventoriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRegionalInventoriesRequest, ListRegionalInventoriesResponse, RegionalInventory>(_callListRegionalInventories, request, callSettings);
        }

        /// <summary>
        /// Lists the `RegionalInventory` resources for the given product in your
        /// merchant account. The response might contain fewer items than specified by
        /// `pageSize`.  If `pageToken` was returned in previous request, it can be
        /// used to obtain additional results.
        /// 
        /// `RegionalInventory` resources are listed per product for a given account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RegionalInventory"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRegionalInventoriesResponse, RegionalInventory> ListRegionalInventoriesAsync(ListRegionalInventoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRegionalInventoriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRegionalInventoriesRequest, ListRegionalInventoriesResponse, RegionalInventory>(_callListRegionalInventories, request, callSettings);
        }

        /// <summary>
        /// Inserts a `RegionalInventory` to a given product in your
        /// merchant account.
        /// 
        /// Replaces the full `RegionalInventory` resource if an entry with the same
        /// [`region`][google.shopping.merchant.inventories.v1beta.RegionalInventory.region]
        /// already exists for the product.
        /// 
        /// It might take up to 30 minutes for the new or updated `RegionalInventory`
        /// resource to appear in products.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RegionalInventory InsertRegionalInventory(InsertRegionalInventoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertRegionalInventoryRequest(ref request, ref callSettings);
            return _callInsertRegionalInventory.Sync(request, callSettings);
        }

        /// <summary>
        /// Inserts a `RegionalInventory` to a given product in your
        /// merchant account.
        /// 
        /// Replaces the full `RegionalInventory` resource if an entry with the same
        /// [`region`][google.shopping.merchant.inventories.v1beta.RegionalInventory.region]
        /// already exists for the product.
        /// 
        /// It might take up to 30 minutes for the new or updated `RegionalInventory`
        /// resource to appear in products.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RegionalInventory> InsertRegionalInventoryAsync(InsertRegionalInventoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertRegionalInventoryRequest(ref request, ref callSettings);
            return _callInsertRegionalInventory.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified `RegionalInventory` resource from the given product
        /// in your merchant account.  It might take up to an hour for the
        /// `RegionalInventory` to be deleted from the specific product.
        /// Once you have received a successful delete response, wait for that
        /// period before attempting a delete again.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteRegionalInventory(DeleteRegionalInventoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRegionalInventoryRequest(ref request, ref callSettings);
            _callDeleteRegionalInventory.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified `RegionalInventory` resource from the given product
        /// in your merchant account.  It might take up to an hour for the
        /// `RegionalInventory` to be deleted from the specific product.
        /// Once you have received a successful delete response, wait for that
        /// period before attempting a delete again.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteRegionalInventoryAsync(DeleteRegionalInventoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRegionalInventoryRequest(ref request, ref callSettings);
            return _callDeleteRegionalInventory.Async(request, callSettings);
        }
    }

    public partial class ListRegionalInventoriesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRegionalInventoriesResponse : gaxgrpc::IPageResponse<RegionalInventory>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<RegionalInventory> GetEnumerator() => RegionalInventories.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
