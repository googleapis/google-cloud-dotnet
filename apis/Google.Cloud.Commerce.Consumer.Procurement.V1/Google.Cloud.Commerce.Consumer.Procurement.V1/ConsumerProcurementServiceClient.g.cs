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
using lro = Google.LongRunning;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.Commerce.Consumer.Procurement.V1
{
    /// <summary>Settings for <see cref="ConsumerProcurementServiceClient"/> instances.</summary>
    public sealed partial class ConsumerProcurementServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ConsumerProcurementServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ConsumerProcurementServiceSettings"/>.</returns>
        public static ConsumerProcurementServiceSettings GetDefault() => new ConsumerProcurementServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ConsumerProcurementServiceSettings"/> object with default settings.
        /// </summary>
        public ConsumerProcurementServiceSettings()
        {
        }

        private ConsumerProcurementServiceSettings(ConsumerProcurementServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            PlaceOrderSettings = existing.PlaceOrderSettings;
            PlaceOrderOperationsSettings = existing.PlaceOrderOperationsSettings.Clone();
            GetOrderSettings = existing.GetOrderSettings;
            ListOrdersSettings = existing.ListOrdersSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ConsumerProcurementServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConsumerProcurementServiceClient.PlaceOrder</c> and <c>ConsumerProcurementServiceClient.PlaceOrderAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PlaceOrderSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ConsumerProcurementServiceClient.PlaceOrder</c> and
        /// <c>ConsumerProcurementServiceClient.PlaceOrderAsync</c>.
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
        public lro::OperationsSettings PlaceOrderOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConsumerProcurementServiceClient.GetOrder</c> and <c>ConsumerProcurementServiceClient.GetOrderAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetOrderSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConsumerProcurementServiceClient.ListOrders</c> and <c>ConsumerProcurementServiceClient.ListOrdersAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListOrdersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ConsumerProcurementServiceSettings"/> object.</returns>
        public ConsumerProcurementServiceSettings Clone() => new ConsumerProcurementServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ConsumerProcurementServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class ConsumerProcurementServiceClientBuilder : gaxgrpc::ClientBuilderBase<ConsumerProcurementServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ConsumerProcurementServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ConsumerProcurementServiceClientBuilder() : base(ConsumerProcurementServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ConsumerProcurementServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ConsumerProcurementServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ConsumerProcurementServiceClient Build()
        {
            ConsumerProcurementServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ConsumerProcurementServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ConsumerProcurementServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ConsumerProcurementServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ConsumerProcurementServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ConsumerProcurementServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ConsumerProcurementServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ConsumerProcurementServiceClient.ChannelPool;
    }

    /// <summary>ConsumerProcurementService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// ConsumerProcurementService allows customers to make purchases of products
    /// served by the Cloud Commerce platform.
    /// 
    /// 
    /// When purchases are made, the
    /// [ConsumerProcurementService][google.cloud.commerce.consumer.procurement.v1.ConsumerProcurementService]
    /// programs the appropriate backends, including both Google's own
    /// infrastructure, as well as third-party systems, and to enable billing setup
    /// for charging for the procured item.
    /// </remarks>
    public abstract partial class ConsumerProcurementServiceClient
    {
        /// <summary>
        /// The default endpoint for the ConsumerProcurementService service, which is a host of
        /// "cloudcommerceconsumerprocurement.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudcommerceconsumerprocurement.googleapis.com:443";

        /// <summary>The default ConsumerProcurementService scopes.</summary>
        /// <remarks>
        /// The default ConsumerProcurementService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ConsumerProcurementService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ConsumerProcurementServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ConsumerProcurementServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ConsumerProcurementServiceClient"/>.</returns>
        public static stt::Task<ConsumerProcurementServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ConsumerProcurementServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ConsumerProcurementServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ConsumerProcurementServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ConsumerProcurementServiceClient"/>.</returns>
        public static ConsumerProcurementServiceClient Create() => new ConsumerProcurementServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ConsumerProcurementServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ConsumerProcurementServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ConsumerProcurementServiceClient"/>.</returns>
        internal static ConsumerProcurementServiceClient Create(grpccore::CallInvoker callInvoker, ConsumerProcurementServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ConsumerProcurementService.ConsumerProcurementServiceClient grpcClient = new ConsumerProcurementService.ConsumerProcurementServiceClient(callInvoker);
            return new ConsumerProcurementServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ConsumerProcurementService client</summary>
        public virtual ConsumerProcurementService.ConsumerProcurementServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new [Order][google.cloud.commerce.consumer.procurement.v1.Order].
        /// 
        /// This API only supports GCP spend-based committed use
        /// discounts specified by GCP documentation.
        /// 
        /// The returned long-running operation is in-progress until the backend
        /// completes the creation of the resource. Once completed, the order is
        /// in
        /// [OrderState.ORDER_STATE_ACTIVE][google.cloud.commerce.consumer.procurement.v1.OrderState.ORDER_STATE_ACTIVE].
        /// In case of failure, the order resource will be removed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Order, PlaceOrderMetadata> PlaceOrder(PlaceOrderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new [Order][google.cloud.commerce.consumer.procurement.v1.Order].
        /// 
        /// This API only supports GCP spend-based committed use
        /// discounts specified by GCP documentation.
        /// 
        /// The returned long-running operation is in-progress until the backend
        /// completes the creation of the resource. Once completed, the order is
        /// in
        /// [OrderState.ORDER_STATE_ACTIVE][google.cloud.commerce.consumer.procurement.v1.OrderState.ORDER_STATE_ACTIVE].
        /// In case of failure, the order resource will be removed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Order, PlaceOrderMetadata>> PlaceOrderAsync(PlaceOrderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new [Order][google.cloud.commerce.consumer.procurement.v1.Order].
        /// 
        /// This API only supports GCP spend-based committed use
        /// discounts specified by GCP documentation.
        /// 
        /// The returned long-running operation is in-progress until the backend
        /// completes the creation of the resource. Once completed, the order is
        /// in
        /// [OrderState.ORDER_STATE_ACTIVE][google.cloud.commerce.consumer.procurement.v1.OrderState.ORDER_STATE_ACTIVE].
        /// In case of failure, the order resource will be removed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Order, PlaceOrderMetadata>> PlaceOrderAsync(PlaceOrderRequest request, st::CancellationToken cancellationToken) =>
            PlaceOrderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>PlaceOrder</c>.</summary>
        public virtual lro::OperationsClient PlaceOrderOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>PlaceOrder</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Order, PlaceOrderMetadata> PollOncePlaceOrder(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Order, PlaceOrderMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PlaceOrderOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>PlaceOrder</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Order, PlaceOrderMetadata>> PollOncePlaceOrderAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Order, PlaceOrderMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PlaceOrderOperationsClient, callSettings);

        /// <summary>
        /// Returns the requested
        /// [Order][google.cloud.commerce.consumer.procurement.v1.Order] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Order GetOrder(GetOrderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested
        /// [Order][google.cloud.commerce.consumer.procurement.v1.Order] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Order> GetOrderAsync(GetOrderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested
        /// [Order][google.cloud.commerce.consumer.procurement.v1.Order] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Order> GetOrderAsync(GetOrderRequest request, st::CancellationToken cancellationToken) =>
            GetOrderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested
        /// [Order][google.cloud.commerce.consumer.procurement.v1.Order] resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the order to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Order GetOrder(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrder(new GetOrderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested
        /// [Order][google.cloud.commerce.consumer.procurement.v1.Order] resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the order to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Order> GetOrderAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrderAsync(new GetOrderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested
        /// [Order][google.cloud.commerce.consumer.procurement.v1.Order] resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the order to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Order> GetOrderAsync(string name, st::CancellationToken cancellationToken) =>
            GetOrderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists [Order][google.cloud.commerce.consumer.procurement.v1.Order]
        /// resources that the user has access to, within the scope of the parent
        /// resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Order"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOrdersResponse, Order> ListOrders(ListOrdersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [Order][google.cloud.commerce.consumer.procurement.v1.Order]
        /// resources that the user has access to, within the scope of the parent
        /// resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Order"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOrdersResponse, Order> ListOrdersAsync(ListOrdersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [Order][google.cloud.commerce.consumer.procurement.v1.Order]
        /// resources that the user has access to, within the scope of the parent
        /// resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource to query for orders.
        /// This field has the form `billingAccounts/{billing-account-id}`.
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
        /// Lists [Order][google.cloud.commerce.consumer.procurement.v1.Order]
        /// resources that the user has access to, within the scope of the parent
        /// resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource to query for orders.
        /// This field has the form `billingAccounts/{billing-account-id}`.
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
    }

    /// <summary>ConsumerProcurementService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// ConsumerProcurementService allows customers to make purchases of products
    /// served by the Cloud Commerce platform.
    /// 
    /// 
    /// When purchases are made, the
    /// [ConsumerProcurementService][google.cloud.commerce.consumer.procurement.v1.ConsumerProcurementService]
    /// programs the appropriate backends, including both Google's own
    /// infrastructure, as well as third-party systems, and to enable billing setup
    /// for charging for the procured item.
    /// </remarks>
    public sealed partial class ConsumerProcurementServiceClientImpl : ConsumerProcurementServiceClient
    {
        private readonly gaxgrpc::ApiCall<PlaceOrderRequest, lro::Operation> _callPlaceOrder;

        private readonly gaxgrpc::ApiCall<GetOrderRequest, Order> _callGetOrder;

        private readonly gaxgrpc::ApiCall<ListOrdersRequest, ListOrdersResponse> _callListOrders;

        /// <summary>
        /// Constructs a client wrapper for the ConsumerProcurementService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="ConsumerProcurementServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ConsumerProcurementServiceClientImpl(ConsumerProcurementService.ConsumerProcurementServiceClient grpcClient, ConsumerProcurementServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ConsumerProcurementServiceSettings effectiveSettings = settings ?? ConsumerProcurementServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            PlaceOrderOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.PlaceOrderOperationsSettings, logger);
            _callPlaceOrder = clientHelper.BuildApiCall<PlaceOrderRequest, lro::Operation>("PlaceOrder", grpcClient.PlaceOrderAsync, grpcClient.PlaceOrder, effectiveSettings.PlaceOrderSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callPlaceOrder);
            Modify_PlaceOrderApiCall(ref _callPlaceOrder);
            _callGetOrder = clientHelper.BuildApiCall<GetOrderRequest, Order>("GetOrder", grpcClient.GetOrderAsync, grpcClient.GetOrder, effectiveSettings.GetOrderSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetOrder);
            Modify_GetOrderApiCall(ref _callGetOrder);
            _callListOrders = clientHelper.BuildApiCall<ListOrdersRequest, ListOrdersResponse>("ListOrders", grpcClient.ListOrdersAsync, grpcClient.ListOrders, effectiveSettings.ListOrdersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListOrders);
            Modify_ListOrdersApiCall(ref _callListOrders);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_PlaceOrderApiCall(ref gaxgrpc::ApiCall<PlaceOrderRequest, lro::Operation> call);

        partial void Modify_GetOrderApiCall(ref gaxgrpc::ApiCall<GetOrderRequest, Order> call);

        partial void Modify_ListOrdersApiCall(ref gaxgrpc::ApiCall<ListOrdersRequest, ListOrdersResponse> call);

        partial void OnConstruction(ConsumerProcurementService.ConsumerProcurementServiceClient grpcClient, ConsumerProcurementServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ConsumerProcurementService client</summary>
        public override ConsumerProcurementService.ConsumerProcurementServiceClient GrpcClient { get; }

        partial void Modify_PlaceOrderRequest(ref PlaceOrderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetOrderRequest(ref GetOrderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListOrdersRequest(ref ListOrdersRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>PlaceOrder</c>.</summary>
        public override lro::OperationsClient PlaceOrderOperationsClient { get; }

        /// <summary>
        /// Creates a new [Order][google.cloud.commerce.consumer.procurement.v1.Order].
        /// 
        /// This API only supports GCP spend-based committed use
        /// discounts specified by GCP documentation.
        /// 
        /// The returned long-running operation is in-progress until the backend
        /// completes the creation of the resource. Once completed, the order is
        /// in
        /// [OrderState.ORDER_STATE_ACTIVE][google.cloud.commerce.consumer.procurement.v1.OrderState.ORDER_STATE_ACTIVE].
        /// In case of failure, the order resource will be removed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Order, PlaceOrderMetadata> PlaceOrder(PlaceOrderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PlaceOrderRequest(ref request, ref callSettings);
            return new lro::Operation<Order, PlaceOrderMetadata>(_callPlaceOrder.Sync(request, callSettings), PlaceOrderOperationsClient);
        }

        /// <summary>
        /// Creates a new [Order][google.cloud.commerce.consumer.procurement.v1.Order].
        /// 
        /// This API only supports GCP spend-based committed use
        /// discounts specified by GCP documentation.
        /// 
        /// The returned long-running operation is in-progress until the backend
        /// completes the creation of the resource. Once completed, the order is
        /// in
        /// [OrderState.ORDER_STATE_ACTIVE][google.cloud.commerce.consumer.procurement.v1.OrderState.ORDER_STATE_ACTIVE].
        /// In case of failure, the order resource will be removed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Order, PlaceOrderMetadata>> PlaceOrderAsync(PlaceOrderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PlaceOrderRequest(ref request, ref callSettings);
            return new lro::Operation<Order, PlaceOrderMetadata>(await _callPlaceOrder.Async(request, callSettings).ConfigureAwait(false), PlaceOrderOperationsClient);
        }

        /// <summary>
        /// Returns the requested
        /// [Order][google.cloud.commerce.consumer.procurement.v1.Order] resource.
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
        /// Returns the requested
        /// [Order][google.cloud.commerce.consumer.procurement.v1.Order] resource.
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
        /// Lists [Order][google.cloud.commerce.consumer.procurement.v1.Order]
        /// resources that the user has access to, within the scope of the parent
        /// resource.
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
        /// Lists [Order][google.cloud.commerce.consumer.procurement.v1.Order]
        /// resources that the user has access to, within the scope of the parent
        /// resource.
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

    public static partial class ConsumerProcurementService
    {
        public partial class ConsumerProcurementServiceClient
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
