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

namespace Google.Ads.AdManager.V1
{
    /// <summary>Settings for <see cref="LineItemServiceClient"/> instances.</summary>
    public sealed partial class LineItemServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="LineItemServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="LineItemServiceSettings"/>.</returns>
        public static LineItemServiceSettings GetDefault() => new LineItemServiceSettings();

        /// <summary>Constructs a new <see cref="LineItemServiceSettings"/> object with default settings.</summary>
        public LineItemServiceSettings()
        {
        }

        private LineItemServiceSettings(LineItemServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetLineItemSettings = existing.GetLineItemSettings;
            ListLineItemsSettings = existing.ListLineItemsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(LineItemServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LineItemServiceClient.GetLineItem</c> and <c>LineItemServiceClient.GetLineItemAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetLineItemSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LineItemServiceClient.ListLineItems</c> and <c>LineItemServiceClient.ListLineItemsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListLineItemsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="LineItemServiceSettings"/> object.</returns>
        public LineItemServiceSettings Clone() => new LineItemServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="LineItemServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class LineItemServiceClientBuilder : gaxgrpc::ClientBuilderBase<LineItemServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public LineItemServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public LineItemServiceClientBuilder() : base(LineItemServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref LineItemServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<LineItemServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override LineItemServiceClient Build()
        {
            LineItemServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<LineItemServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<LineItemServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private LineItemServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return LineItemServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<LineItemServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return LineItemServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => LineItemServiceClient.ChannelPool;
    }

    /// <summary>LineItemService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `LineItem` objects.
    /// </remarks>
    public abstract partial class LineItemServiceClient
    {
        /// <summary>
        /// The default endpoint for the LineItemService service, which is a host of "admanager.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default LineItemService scopes.</summary>
        /// <remarks>
        /// The default LineItemService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/admanager</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admanager",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(LineItemService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="LineItemServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="LineItemServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="LineItemServiceClient"/>.</returns>
        public static stt::Task<LineItemServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new LineItemServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="LineItemServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="LineItemServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="LineItemServiceClient"/>.</returns>
        public static LineItemServiceClient Create() => new LineItemServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="LineItemServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="LineItemServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="LineItemServiceClient"/>.</returns>
        internal static LineItemServiceClient Create(grpccore::CallInvoker callInvoker, LineItemServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            LineItemService.LineItemServiceClient grpcClient = new LineItemService.LineItemServiceClient(callInvoker);
            return new LineItemServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC LineItemService client</summary>
        public virtual LineItemService.LineItemServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `LineItem` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LineItem GetLineItem(GetLineItemRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `LineItem` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineItem> GetLineItemAsync(GetLineItemRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `LineItem` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineItem> GetLineItemAsync(GetLineItemRequest request, st::CancellationToken cancellationToken) =>
            GetLineItemAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `LineItem` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the LineItem.
        /// Format: `networks/{network_code}/lineItems/{line_item_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LineItem GetLineItem(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetLineItem(new GetLineItemRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `LineItem` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the LineItem.
        /// Format: `networks/{network_code}/lineItems/{line_item_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineItem> GetLineItemAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetLineItemAsync(new GetLineItemRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `LineItem` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the LineItem.
        /// Format: `networks/{network_code}/lineItems/{line_item_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineItem> GetLineItemAsync(string name, st::CancellationToken cancellationToken) =>
            GetLineItemAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `LineItem` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the LineItem.
        /// Format: `networks/{network_code}/lineItems/{line_item_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LineItem GetLineItem(LineItemName name, gaxgrpc::CallSettings callSettings = null) =>
            GetLineItem(new GetLineItemRequest
            {
                LineItemName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `LineItem` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the LineItem.
        /// Format: `networks/{network_code}/lineItems/{line_item_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineItem> GetLineItemAsync(LineItemName name, gaxgrpc::CallSettings callSettings = null) =>
            GetLineItemAsync(new GetLineItemRequest
            {
                LineItemName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `LineItem` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the LineItem.
        /// Format: `networks/{network_code}/lineItems/{line_item_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineItem> GetLineItemAsync(LineItemName name, st::CancellationToken cancellationToken) =>
            GetLineItemAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a list of `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LineItem"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLineItemsResponse, LineItem> ListLineItems(ListLineItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LineItem"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLineItemsResponse, LineItem> ListLineItemsAsync(ListLineItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of LineItems.
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
        /// <returns>A pageable sequence of <see cref="LineItem"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLineItemsResponse, LineItem> ListLineItems(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLineItemsRequest request = new ListLineItemsRequest
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
            return ListLineItems(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of LineItems.
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
        /// <returns>A pageable asynchronous sequence of <see cref="LineItem"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLineItemsResponse, LineItem> ListLineItemsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLineItemsRequest request = new ListLineItemsRequest
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
            return ListLineItemsAsync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of LineItems.
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
        /// <returns>A pageable sequence of <see cref="LineItem"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLineItemsResponse, LineItem> ListLineItems(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLineItemsRequest request = new ListLineItemsRequest
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
            return ListLineItems(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of LineItems.
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
        /// <returns>A pageable asynchronous sequence of <see cref="LineItem"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLineItemsResponse, LineItem> ListLineItemsAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLineItemsRequest request = new ListLineItemsRequest
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
            return ListLineItemsAsync(request, callSettings);
        }
    }

    /// <summary>LineItemService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `LineItem` objects.
    /// </remarks>
    public sealed partial class LineItemServiceClientImpl : LineItemServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetLineItemRequest, LineItem> _callGetLineItem;

        private readonly gaxgrpc::ApiCall<ListLineItemsRequest, ListLineItemsResponse> _callListLineItems;

        /// <summary>
        /// Constructs a client wrapper for the LineItemService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="LineItemServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public LineItemServiceClientImpl(LineItemService.LineItemServiceClient grpcClient, LineItemServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            LineItemServiceSettings effectiveSettings = settings ?? LineItemServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetLineItem = clientHelper.BuildApiCall<GetLineItemRequest, LineItem>("GetLineItem", grpcClient.GetLineItemAsync, grpcClient.GetLineItem, effectiveSettings.GetLineItemSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetLineItem);
            Modify_GetLineItemApiCall(ref _callGetLineItem);
            _callListLineItems = clientHelper.BuildApiCall<ListLineItemsRequest, ListLineItemsResponse>("ListLineItems", grpcClient.ListLineItemsAsync, grpcClient.ListLineItems, effectiveSettings.ListLineItemsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListLineItems);
            Modify_ListLineItemsApiCall(ref _callListLineItems);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetLineItemApiCall(ref gaxgrpc::ApiCall<GetLineItemRequest, LineItem> call);

        partial void Modify_ListLineItemsApiCall(ref gaxgrpc::ApiCall<ListLineItemsRequest, ListLineItemsResponse> call);

        partial void OnConstruction(LineItemService.LineItemServiceClient grpcClient, LineItemServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC LineItemService client</summary>
        public override LineItemService.LineItemServiceClient GrpcClient { get; }

        partial void Modify_GetLineItemRequest(ref GetLineItemRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListLineItemsRequest(ref ListLineItemsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// API to retrieve a `LineItem` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LineItem GetLineItem(GetLineItemRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLineItemRequest(ref request, ref callSettings);
            return _callGetLineItem.Sync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a `LineItem` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LineItem> GetLineItemAsync(GetLineItemRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLineItemRequest(ref request, ref callSettings);
            return _callGetLineItem.Async(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LineItem"/> resources.</returns>
        public override gax::PagedEnumerable<ListLineItemsResponse, LineItem> ListLineItems(ListLineItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLineItemsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListLineItemsRequest, ListLineItemsResponse, LineItem>(_callListLineItems, request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LineItem"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListLineItemsResponse, LineItem> ListLineItemsAsync(ListLineItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLineItemsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListLineItemsRequest, ListLineItemsResponse, LineItem>(_callListLineItems, request, callSettings);
        }
    }

    public partial class ListLineItemsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListLineItemsResponse : gaxgrpc::IPageResponse<LineItem>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<LineItem> GetEnumerator() => LineItems.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
