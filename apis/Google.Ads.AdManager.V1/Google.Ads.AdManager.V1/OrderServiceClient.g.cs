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

namespace Google.Ads.AdManager.V1
{
    /// <summary>Settings for <see cref="OrderServiceClient"/> instances.</summary>
    public sealed partial class OrderServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="OrderServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="OrderServiceSettings"/>.</returns>
        public static OrderServiceSettings GetDefault() => new OrderServiceSettings();

        /// <summary>Constructs a new <see cref="OrderServiceSettings"/> object with default settings.</summary>
        public OrderServiceSettings()
        {
        }

        private OrderServiceSettings(OrderServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetOrderSettings = existing.GetOrderSettings;
            ListOrdersSettings = existing.ListOrdersSettings;
            OnCopy(existing);
        }

        partial void OnCopy(OrderServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>OrderServiceClient.GetOrder</c>
        ///  and <c>OrderServiceClient.GetOrderAsync</c>.
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
        public gaxgrpc::CallSettings GetOrderSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrderServiceClient.ListOrders</c> and <c>OrderServiceClient.ListOrdersAsync</c>.
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
        public gaxgrpc::CallSettings ListOrdersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="OrderServiceSettings"/> object.</returns>
        public OrderServiceSettings Clone() => new OrderServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="OrderServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class OrderServiceClientBuilder : gaxgrpc::ClientBuilderBase<OrderServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public OrderServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public OrderServiceClientBuilder() : base(OrderServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref OrderServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<OrderServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override OrderServiceClient Build()
        {
            OrderServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<OrderServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<OrderServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private OrderServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return OrderServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<OrderServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return OrderServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => OrderServiceClient.ChannelPool;
    }

    /// <summary>OrderService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `Order` objects.
    /// </remarks>
    public abstract partial class OrderServiceClient
    {
        /// <summary>
        /// The default endpoint for the OrderService service, which is a host of "admanager.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default OrderService scopes.</summary>
        /// <remarks>The default OrderService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(OrderService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="OrderServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="OrderServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="OrderServiceClient"/>.</returns>
        public static stt::Task<OrderServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new OrderServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="OrderServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="OrderServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="OrderServiceClient"/>.</returns>
        public static OrderServiceClient Create() => new OrderServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="OrderServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="OrderServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="OrderServiceClient"/>.</returns>
        internal static OrderServiceClient Create(grpccore::CallInvoker callInvoker, OrderServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            OrderService.OrderServiceClient grpcClient = new OrderService.OrderServiceClient(callInvoker);
            return new OrderServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC OrderService client</summary>
        public virtual OrderService.OrderServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve an Order object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Order GetOrder(GetOrderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve an Order object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Order> GetOrderAsync(GetOrderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve an Order object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Order> GetOrderAsync(GetOrderRequest request, st::CancellationToken cancellationToken) =>
            GetOrderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve an Order object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Order.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Order GetOrder(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrder(new GetOrderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve an Order object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Order.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Order> GetOrderAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrderAsync(new GetOrderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve an Order object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Order.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Order> GetOrderAsync(string name, st::CancellationToken cancellationToken) =>
            GetOrderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve an Order object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Order.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Order GetOrder(OrderName name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrder(new GetOrderRequest
            {
                OrderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve an Order object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Order.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Order> GetOrderAsync(OrderName name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrderAsync(new GetOrderRequest
            {
                OrderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve an Order object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Order.
        /// Format: `networks/{network_code}/orders/{order_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Order> GetOrderAsync(OrderName name, st::CancellationToken cancellationToken) =>
            GetOrderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a list of `Order` objects.
        /// 
        /// Fields used for literal matching in filter string:
        /// * `order_id`
        /// * `display_name`
        /// * `external_order_id`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Order"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOrdersResponse, Order> ListOrders(ListOrdersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `Order` objects.
        /// 
        /// Fields used for literal matching in filter string:
        /// * `order_id`
        /// * `display_name`
        /// * `external_order_id`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Order"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOrdersResponse, Order> ListOrdersAsync(ListOrdersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `Order` objects.
        /// 
        /// Fields used for literal matching in filter string:
        /// * `order_id`
        /// * `display_name`
        /// * `external_order_id`
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
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
        /// <returns>A pageable sequence of <see cref="Order"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOrdersResponse, Order> ListOrders(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOrdersRequest request = new ListOrdersRequest
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
            return ListOrders(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Order` objects.
        /// 
        /// Fields used for literal matching in filter string:
        /// * `order_id`
        /// * `display_name`
        /// * `external_order_id`
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Order"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOrdersResponse, Order> ListOrdersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOrdersRequest request = new ListOrdersRequest
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
            return ListOrdersAsync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Order` objects.
        /// 
        /// Fields used for literal matching in filter string:
        /// * `order_id`
        /// * `display_name`
        /// * `external_order_id`
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
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
        /// <returns>A pageable sequence of <see cref="Order"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOrdersResponse, Order> ListOrders(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOrdersRequest request = new ListOrdersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListOrders(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Order` objects.
        /// 
        /// Fields used for literal matching in filter string:
        /// * `order_id`
        /// * `display_name`
        /// * `external_order_id`
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Orders.
        /// Format: `networks/{network_code}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Order"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOrdersResponse, Order> ListOrdersAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOrdersRequest request = new ListOrdersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListOrdersAsync(request, callSettings);
        }
    }

    /// <summary>OrderService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `Order` objects.
    /// </remarks>
    public sealed partial class OrderServiceClientImpl : OrderServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetOrderRequest, Order> _callGetOrder;

        private readonly gaxgrpc::ApiCall<ListOrdersRequest, ListOrdersResponse> _callListOrders;

        /// <summary>
        /// Constructs a client wrapper for the OrderService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="OrderServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public OrderServiceClientImpl(OrderService.OrderServiceClient grpcClient, OrderServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            OrderServiceSettings effectiveSettings = settings ?? OrderServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetOrder = clientHelper.BuildApiCall<GetOrderRequest, Order>("GetOrder", grpcClient.GetOrderAsync, grpcClient.GetOrder, effectiveSettings.GetOrderSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetOrder);
            Modify_GetOrderApiCall(ref _callGetOrder);
            _callListOrders = clientHelper.BuildApiCall<ListOrdersRequest, ListOrdersResponse>("ListOrders", grpcClient.ListOrdersAsync, grpcClient.ListOrders, effectiveSettings.ListOrdersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListOrders);
            Modify_ListOrdersApiCall(ref _callListOrders);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetOrderApiCall(ref gaxgrpc::ApiCall<GetOrderRequest, Order> call);

        partial void Modify_ListOrdersApiCall(ref gaxgrpc::ApiCall<ListOrdersRequest, ListOrdersResponse> call);

        partial void OnConstruction(OrderService.OrderServiceClient grpcClient, OrderServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC OrderService client</summary>
        public override OrderService.OrderServiceClient GrpcClient { get; }

        partial void Modify_GetOrderRequest(ref GetOrderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListOrdersRequest(ref ListOrdersRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// API to retrieve an Order object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Order GetOrder(GetOrderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOrderRequest(ref request, ref callSettings);
            return _callGetOrder.Sync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve an Order object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Order> GetOrderAsync(GetOrderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOrderRequest(ref request, ref callSettings);
            return _callGetOrder.Async(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Order` objects.
        /// 
        /// Fields used for literal matching in filter string:
        /// * `order_id`
        /// * `display_name`
        /// * `external_order_id`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Order"/> resources.</returns>
        public override gax::PagedEnumerable<ListOrdersResponse, Order> ListOrders(ListOrdersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOrdersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListOrdersRequest, ListOrdersResponse, Order>(_callListOrders, request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Order` objects.
        /// 
        /// Fields used for literal matching in filter string:
        /// * `order_id`
        /// * `display_name`
        /// * `external_order_id`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Order"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListOrdersResponse, Order> ListOrdersAsync(ListOrdersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOrdersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListOrdersRequest, ListOrdersResponse, Order>(_callListOrders, request, callSettings);
        }
    }

    public partial class ListOrdersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListOrdersResponse : gaxgrpc::IPageResponse<Order>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Order> GetEnumerator() => Orders.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
