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
using wkt = Google.Protobuf.WellKnownTypes;

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
            CreateLineItemSettings = existing.CreateLineItemSettings;
            BatchCreateLineItemsSettings = existing.BatchCreateLineItemsSettings;
            UpdateLineItemSettings = existing.UpdateLineItemSettings;
            BatchUpdateLineItemsSettings = existing.BatchUpdateLineItemsSettings;
            BatchActivateLineItemsSettings = existing.BatchActivateLineItemsSettings;
            BatchPauseLineItemsSettings = existing.BatchPauseLineItemsSettings;
            BatchResumeLineItemsSettings = existing.BatchResumeLineItemsSettings;
            BatchResumeAndOverbookLineItemsSettings = existing.BatchResumeAndOverbookLineItemsSettings;
            BatchDeleteLineItemsSettings = existing.BatchDeleteLineItemsSettings;
            BatchReserveLineItemsSettings = existing.BatchReserveLineItemsSettings;
            BatchReserveAndOverbookLineItemsSettings = existing.BatchReserveAndOverbookLineItemsSettings;
            BatchReleaseLineItemsSettings = existing.BatchReleaseLineItemsSettings;
            BatchArchiveLineItemsSettings = existing.BatchArchiveLineItemsSettings;
            BatchUnarchiveLineItemsSettings = existing.BatchUnarchiveLineItemsSettings;
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

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LineItemServiceClient.CreateLineItem</c> and <c>LineItemServiceClient.CreateLineItemAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateLineItemSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LineItemServiceClient.BatchCreateLineItems</c> and <c>LineItemServiceClient.BatchCreateLineItemsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchCreateLineItemsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LineItemServiceClient.UpdateLineItem</c> and <c>LineItemServiceClient.UpdateLineItemAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateLineItemSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LineItemServiceClient.BatchUpdateLineItems</c> and <c>LineItemServiceClient.BatchUpdateLineItemsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchUpdateLineItemsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LineItemServiceClient.BatchActivateLineItems</c> and <c>LineItemServiceClient.BatchActivateLineItemsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchActivateLineItemsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LineItemServiceClient.BatchPauseLineItems</c> and <c>LineItemServiceClient.BatchPauseLineItemsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchPauseLineItemsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LineItemServiceClient.BatchResumeLineItems</c> and <c>LineItemServiceClient.BatchResumeLineItemsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchResumeLineItemsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LineItemServiceClient.BatchResumeAndOverbookLineItems</c> and
        /// <c>LineItemServiceClient.BatchResumeAndOverbookLineItemsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchResumeAndOverbookLineItemsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LineItemServiceClient.BatchDeleteLineItems</c> and <c>LineItemServiceClient.BatchDeleteLineItemsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchDeleteLineItemsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LineItemServiceClient.BatchReserveLineItems</c> and <c>LineItemServiceClient.BatchReserveLineItemsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchReserveLineItemsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LineItemServiceClient.BatchReserveAndOverbookLineItems</c> and
        /// <c>LineItemServiceClient.BatchReserveAndOverbookLineItemsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchReserveAndOverbookLineItemsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LineItemServiceClient.BatchReleaseLineItems</c> and <c>LineItemServiceClient.BatchReleaseLineItemsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchReleaseLineItemsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LineItemServiceClient.BatchArchiveLineItems</c> and <c>LineItemServiceClient.BatchArchiveLineItemsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchArchiveLineItemsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LineItemServiceClient.BatchUnarchiveLineItems</c> and
        /// <c>LineItemServiceClient.BatchUnarchiveLineItemsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchUnarchiveLineItemsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

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
        /// <item><description>https://www.googleapis.com/auth/admanager.readonly</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admanager",
            "https://www.googleapis.com/auth/admanager.readonly",
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
        /// Retrieves a `LineItem` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LineItem GetLineItem(GetLineItemRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `LineItem` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineItem> GetLineItemAsync(GetLineItemRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `LineItem` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineItem> GetLineItemAsync(GetLineItemRequest request, st::CancellationToken cancellationToken) =>
            GetLineItemAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `LineItem` object.
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
        /// Retrieves a `LineItem` object.
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
        /// Retrieves a `LineItem` object.
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
        /// Retrieves a `LineItem` object.
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
        /// Retrieves a `LineItem` object.
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
        /// Retrieves a `LineItem` object.
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
        /// Lists `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LineItem"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLineItemsResponse, LineItem> ListLineItems(ListLineItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LineItem"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLineItemsResponse, LineItem> ListLineItemsAsync(ListLineItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `LineItem` objects.
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
        /// Lists `LineItem` objects.
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
        /// Lists `LineItem` objects.
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
        /// Lists `LineItem` objects.
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

        /// <summary>
        /// Creates a `LineItem` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LineItem CreateLineItem(CreateLineItemRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `LineItem` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineItem> CreateLineItemAsync(CreateLineItemRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `LineItem` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineItem> CreateLineItemAsync(CreateLineItemRequest request, st::CancellationToken cancellationToken) =>
            CreateLineItemAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `LineItem` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `LineItem` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="lineItem">
        /// Required. The `LineItem` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LineItem CreateLineItem(string parent, LineItem lineItem, gaxgrpc::CallSettings callSettings = null) =>
            CreateLineItem(new CreateLineItemRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                LineItem = gax::GaxPreconditions.CheckNotNull(lineItem, nameof(lineItem)),
            }, callSettings);

        /// <summary>
        /// Creates a `LineItem` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `LineItem` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="lineItem">
        /// Required. The `LineItem` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineItem> CreateLineItemAsync(string parent, LineItem lineItem, gaxgrpc::CallSettings callSettings = null) =>
            CreateLineItemAsync(new CreateLineItemRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                LineItem = gax::GaxPreconditions.CheckNotNull(lineItem, nameof(lineItem)),
            }, callSettings);

        /// <summary>
        /// Creates a `LineItem` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `LineItem` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="lineItem">
        /// Required. The `LineItem` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineItem> CreateLineItemAsync(string parent, LineItem lineItem, st::CancellationToken cancellationToken) =>
            CreateLineItemAsync(parent, lineItem, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `LineItem` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `LineItem` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="lineItem">
        /// Required. The `LineItem` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LineItem CreateLineItem(NetworkName parent, LineItem lineItem, gaxgrpc::CallSettings callSettings = null) =>
            CreateLineItem(new CreateLineItemRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LineItem = gax::GaxPreconditions.CheckNotNull(lineItem, nameof(lineItem)),
            }, callSettings);

        /// <summary>
        /// Creates a `LineItem` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `LineItem` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="lineItem">
        /// Required. The `LineItem` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineItem> CreateLineItemAsync(NetworkName parent, LineItem lineItem, gaxgrpc::CallSettings callSettings = null) =>
            CreateLineItemAsync(new CreateLineItemRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LineItem = gax::GaxPreconditions.CheckNotNull(lineItem, nameof(lineItem)),
            }, callSettings);

        /// <summary>
        /// Creates a `LineItem` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `LineItem` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="lineItem">
        /// Required. The `LineItem` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineItem> CreateLineItemAsync(NetworkName parent, LineItem lineItem, st::CancellationToken cancellationToken) =>
            CreateLineItemAsync(parent, lineItem, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateLineItemsResponse BatchCreateLineItems(BatchCreateLineItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateLineItemsResponse> BatchCreateLineItemsAsync(BatchCreateLineItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateLineItemsResponse> BatchCreateLineItemsAsync(BatchCreateLineItemsRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateLineItemsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateLineItemRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `LineItem` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateLineItemsResponse BatchCreateLineItems(string parent, scg::IEnumerable<CreateLineItemRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateLineItems(new BatchCreateLineItemsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateLineItemRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `LineItem` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateLineItemsResponse> BatchCreateLineItemsAsync(string parent, scg::IEnumerable<CreateLineItemRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateLineItemsAsync(new BatchCreateLineItemsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateLineItemRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `LineItem` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateLineItemsResponse> BatchCreateLineItemsAsync(string parent, scg::IEnumerable<CreateLineItemRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateLineItemsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateLineItemRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `LineItem` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateLineItemsResponse BatchCreateLineItems(NetworkName parent, scg::IEnumerable<CreateLineItemRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateLineItems(new BatchCreateLineItemsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateLineItemRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `LineItem` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateLineItemsResponse> BatchCreateLineItemsAsync(NetworkName parent, scg::IEnumerable<CreateLineItemRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateLineItemsAsync(new BatchCreateLineItemsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateLineItemRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `LineItem` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateLineItemsResponse> BatchCreateLineItemsAsync(NetworkName parent, scg::IEnumerable<CreateLineItemRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateLineItemsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `LineItem` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LineItem UpdateLineItem(UpdateLineItemRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `LineItem` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineItem> UpdateLineItemAsync(UpdateLineItemRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `LineItem` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineItem> UpdateLineItemAsync(UpdateLineItemRequest request, st::CancellationToken cancellationToken) =>
            UpdateLineItemAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `LineItem` object.
        /// </summary>
        /// <param name="lineItem">
        /// Required. The `LineItem` to update.
        /// 
        /// The `LineItem`'s `name` is used to identify the `LineItem` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LineItem UpdateLineItem(LineItem lineItem, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateLineItem(new UpdateLineItemRequest
            {
                LineItem = gax::GaxPreconditions.CheckNotNull(lineItem, nameof(lineItem)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a `LineItem` object.
        /// </summary>
        /// <param name="lineItem">
        /// Required. The `LineItem` to update.
        /// 
        /// The `LineItem`'s `name` is used to identify the `LineItem` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineItem> UpdateLineItemAsync(LineItem lineItem, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateLineItemAsync(new UpdateLineItemRequest
            {
                LineItem = gax::GaxPreconditions.CheckNotNull(lineItem, nameof(lineItem)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a `LineItem` object.
        /// </summary>
        /// <param name="lineItem">
        /// Required. The `LineItem` to update.
        /// 
        /// The `LineItem`'s `name` is used to identify the `LineItem` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineItem> UpdateLineItemAsync(LineItem lineItem, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateLineItemAsync(lineItem, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateLineItemsResponse BatchUpdateLineItems(BatchUpdateLineItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch updates `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateLineItemsResponse> BatchUpdateLineItemsAsync(BatchUpdateLineItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch updates `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateLineItemsResponse> BatchUpdateLineItemsAsync(BatchUpdateLineItemsRequest request, st::CancellationToken cancellationToken) =>
            BatchUpdateLineItemsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent segment of the `line_item.name` in each `UpdateLineItemRequest`
        /// must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The `LineItem` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateLineItemsResponse BatchUpdateLineItems(string parent, scg::IEnumerable<UpdateLineItemRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateLineItems(new BatchUpdateLineItemsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent segment of the `line_item.name` in each `UpdateLineItemRequest`
        /// must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The `LineItem` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateLineItemsResponse> BatchUpdateLineItemsAsync(string parent, scg::IEnumerable<UpdateLineItemRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateLineItemsAsync(new BatchUpdateLineItemsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent segment of the `line_item.name` in each `UpdateLineItemRequest`
        /// must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The `LineItem` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateLineItemsResponse> BatchUpdateLineItemsAsync(string parent, scg::IEnumerable<UpdateLineItemRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateLineItemsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent segment of the `line_item.name` in each `UpdateLineItemRequest`
        /// must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The `LineItem` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateLineItemsResponse BatchUpdateLineItems(NetworkName parent, scg::IEnumerable<UpdateLineItemRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateLineItems(new BatchUpdateLineItemsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent segment of the `line_item.name` in each `UpdateLineItemRequest`
        /// must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The `LineItem` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateLineItemsResponse> BatchUpdateLineItemsAsync(NetworkName parent, scg::IEnumerable<UpdateLineItemRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateLineItemsAsync(new BatchUpdateLineItemsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent segment of the `line_item.name` in each `UpdateLineItemRequest`
        /// must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The `LineItem` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateLineItemsResponse> BatchUpdateLineItemsAsync(NetworkName parent, scg::IEnumerable<UpdateLineItemRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateLineItemsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch activates `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateLineItemsResponse BatchActivateLineItems(BatchActivateLineItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch activates `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateLineItemsResponse> BatchActivateLineItemsAsync(BatchActivateLineItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch activates `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateLineItemsResponse> BatchActivateLineItemsAsync(BatchActivateLineItemsRequest request, st::CancellationToken cancellationToken) =>
            BatchActivateLineItemsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch activates `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to activate.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateLineItemsResponse BatchActivateLineItems(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateLineItems(new BatchActivateLineItemsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch activates `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to activate.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateLineItemsResponse> BatchActivateLineItemsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateLineItemsAsync(new BatchActivateLineItemsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch activates `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to activate.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateLineItemsResponse> BatchActivateLineItemsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchActivateLineItemsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch activates `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to activate.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateLineItemsResponse BatchActivateLineItems(NetworkName parent, scg::IEnumerable<LineItemName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateLineItems(new BatchActivateLineItemsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LineItemNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch activates `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to activate.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateLineItemsResponse> BatchActivateLineItemsAsync(NetworkName parent, scg::IEnumerable<LineItemName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateLineItemsAsync(new BatchActivateLineItemsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LineItemNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch activates `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to activate.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateLineItemsResponse> BatchActivateLineItemsAsync(NetworkName parent, scg::IEnumerable<LineItemName> names, st::CancellationToken cancellationToken) =>
            BatchActivateLineItemsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch pauses `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchPauseLineItemsResponse BatchPauseLineItems(BatchPauseLineItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch pauses `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPauseLineItemsResponse> BatchPauseLineItemsAsync(BatchPauseLineItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch pauses `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPauseLineItemsResponse> BatchPauseLineItemsAsync(BatchPauseLineItemsRequest request, st::CancellationToken cancellationToken) =>
            BatchPauseLineItemsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch pauses `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to pause.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchPauseLineItemsResponse BatchPauseLineItems(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchPauseLineItems(new BatchPauseLineItemsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch pauses `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to pause.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPauseLineItemsResponse> BatchPauseLineItemsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchPauseLineItemsAsync(new BatchPauseLineItemsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch pauses `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to pause.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPauseLineItemsResponse> BatchPauseLineItemsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchPauseLineItemsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch pauses `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to pause.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchPauseLineItemsResponse BatchPauseLineItems(NetworkName parent, scg::IEnumerable<LineItemName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchPauseLineItems(new BatchPauseLineItemsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LineItemNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch pauses `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to pause.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPauseLineItemsResponse> BatchPauseLineItemsAsync(NetworkName parent, scg::IEnumerable<LineItemName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchPauseLineItemsAsync(new BatchPauseLineItemsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LineItemNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch pauses `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to pause.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPauseLineItemsResponse> BatchPauseLineItemsAsync(NetworkName parent, scg::IEnumerable<LineItemName> names, st::CancellationToken cancellationToken) =>
            BatchPauseLineItemsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch resumes `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchResumeLineItemsResponse BatchResumeLineItems(BatchResumeLineItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch resumes `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchResumeLineItemsResponse> BatchResumeLineItemsAsync(BatchResumeLineItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch resumes `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchResumeLineItemsResponse> BatchResumeLineItemsAsync(BatchResumeLineItemsRequest request, st::CancellationToken cancellationToken) =>
            BatchResumeLineItemsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch resumes `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to resume.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchResumeLineItemsResponse BatchResumeLineItems(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchResumeLineItems(new BatchResumeLineItemsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch resumes `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to resume.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchResumeLineItemsResponse> BatchResumeLineItemsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchResumeLineItemsAsync(new BatchResumeLineItemsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch resumes `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to resume.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchResumeLineItemsResponse> BatchResumeLineItemsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchResumeLineItemsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch resumes `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to resume.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchResumeLineItemsResponse BatchResumeLineItems(NetworkName parent, scg::IEnumerable<LineItemName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchResumeLineItems(new BatchResumeLineItemsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LineItemNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch resumes `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to resume.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchResumeLineItemsResponse> BatchResumeLineItemsAsync(NetworkName parent, scg::IEnumerable<LineItemName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchResumeLineItemsAsync(new BatchResumeLineItemsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LineItemNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch resumes `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to resume.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchResumeLineItemsResponse> BatchResumeLineItemsAsync(NetworkName parent, scg::IEnumerable<LineItemName> names, st::CancellationToken cancellationToken) =>
            BatchResumeLineItemsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch resumes and overbooks `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchResumeAndOverbookLineItemsResponse BatchResumeAndOverbookLineItems(BatchResumeAndOverbookLineItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch resumes and overbooks `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchResumeAndOverbookLineItemsResponse> BatchResumeAndOverbookLineItemsAsync(BatchResumeAndOverbookLineItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch resumes and overbooks `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchResumeAndOverbookLineItemsResponse> BatchResumeAndOverbookLineItemsAsync(BatchResumeAndOverbookLineItemsRequest request, st::CancellationToken cancellationToken) =>
            BatchResumeAndOverbookLineItemsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch resumes and overbooks `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to resume and overbook.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchResumeAndOverbookLineItemsResponse BatchResumeAndOverbookLineItems(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchResumeAndOverbookLineItems(new BatchResumeAndOverbookLineItemsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch resumes and overbooks `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to resume and overbook.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchResumeAndOverbookLineItemsResponse> BatchResumeAndOverbookLineItemsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchResumeAndOverbookLineItemsAsync(new BatchResumeAndOverbookLineItemsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch resumes and overbooks `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to resume and overbook.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchResumeAndOverbookLineItemsResponse> BatchResumeAndOverbookLineItemsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchResumeAndOverbookLineItemsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch resumes and overbooks `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to resume and overbook.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchResumeAndOverbookLineItemsResponse BatchResumeAndOverbookLineItems(NetworkName parent, scg::IEnumerable<LineItemName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchResumeAndOverbookLineItems(new BatchResumeAndOverbookLineItemsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LineItemNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch resumes and overbooks `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to resume and overbook.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchResumeAndOverbookLineItemsResponse> BatchResumeAndOverbookLineItemsAsync(NetworkName parent, scg::IEnumerable<LineItemName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchResumeAndOverbookLineItemsAsync(new BatchResumeAndOverbookLineItemsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LineItemNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch resumes and overbooks `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to resume and overbook.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchResumeAndOverbookLineItemsResponse> BatchResumeAndOverbookLineItemsAsync(NetworkName parent, scg::IEnumerable<LineItemName> names, st::CancellationToken cancellationToken) =>
            BatchResumeAndOverbookLineItemsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch deletes `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void BatchDeleteLineItems(BatchDeleteLineItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch deletes `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteLineItemsAsync(BatchDeleteLineItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch deletes `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteLineItemsAsync(BatchDeleteLineItemsRequest request, st::CancellationToken cancellationToken) =>
            BatchDeleteLineItemsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch deletes `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to delete.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void BatchDeleteLineItems(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteLineItems(new BatchDeleteLineItemsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch deletes `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to delete.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteLineItemsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteLineItemsAsync(new BatchDeleteLineItemsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch deletes `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to delete.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteLineItemsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchDeleteLineItemsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch deletes `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to delete.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void BatchDeleteLineItems(NetworkName parent, scg::IEnumerable<LineItemName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteLineItems(new BatchDeleteLineItemsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LineItemNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch deletes `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to delete.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteLineItemsAsync(NetworkName parent, scg::IEnumerable<LineItemName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteLineItemsAsync(new BatchDeleteLineItemsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LineItemNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch deletes `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to delete.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteLineItemsAsync(NetworkName parent, scg::IEnumerable<LineItemName> names, st::CancellationToken cancellationToken) =>
            BatchDeleteLineItemsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch reserves `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchReserveLineItemsResponse BatchReserveLineItems(BatchReserveLineItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch reserves `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchReserveLineItemsResponse> BatchReserveLineItemsAsync(BatchReserveLineItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch reserves `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchReserveLineItemsResponse> BatchReserveLineItemsAsync(BatchReserveLineItemsRequest request, st::CancellationToken cancellationToken) =>
            BatchReserveLineItemsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch reserves `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to reserve.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchReserveLineItemsResponse BatchReserveLineItems(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchReserveLineItems(new BatchReserveLineItemsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch reserves `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to reserve.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchReserveLineItemsResponse> BatchReserveLineItemsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchReserveLineItemsAsync(new BatchReserveLineItemsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch reserves `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to reserve.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchReserveLineItemsResponse> BatchReserveLineItemsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchReserveLineItemsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch reserves `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to reserve.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchReserveLineItemsResponse BatchReserveLineItems(NetworkName parent, scg::IEnumerable<LineItemName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchReserveLineItems(new BatchReserveLineItemsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LineItemNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch reserves `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to reserve.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchReserveLineItemsResponse> BatchReserveLineItemsAsync(NetworkName parent, scg::IEnumerable<LineItemName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchReserveLineItemsAsync(new BatchReserveLineItemsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LineItemNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch reserves `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to reserve.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchReserveLineItemsResponse> BatchReserveLineItemsAsync(NetworkName parent, scg::IEnumerable<LineItemName> names, st::CancellationToken cancellationToken) =>
            BatchReserveLineItemsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch reserves and overbooks `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchReserveAndOverbookLineItemsResponse BatchReserveAndOverbookLineItems(BatchReserveAndOverbookLineItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch reserves and overbooks `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchReserveAndOverbookLineItemsResponse> BatchReserveAndOverbookLineItemsAsync(BatchReserveAndOverbookLineItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch reserves and overbooks `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchReserveAndOverbookLineItemsResponse> BatchReserveAndOverbookLineItemsAsync(BatchReserveAndOverbookLineItemsRequest request, st::CancellationToken cancellationToken) =>
            BatchReserveAndOverbookLineItemsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch reserves and overbooks `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to reserve and overbook.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchReserveAndOverbookLineItemsResponse BatchReserveAndOverbookLineItems(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchReserveAndOverbookLineItems(new BatchReserveAndOverbookLineItemsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch reserves and overbooks `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to reserve and overbook.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchReserveAndOverbookLineItemsResponse> BatchReserveAndOverbookLineItemsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchReserveAndOverbookLineItemsAsync(new BatchReserveAndOverbookLineItemsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch reserves and overbooks `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to reserve and overbook.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchReserveAndOverbookLineItemsResponse> BatchReserveAndOverbookLineItemsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchReserveAndOverbookLineItemsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch reserves and overbooks `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to reserve and overbook.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchReserveAndOverbookLineItemsResponse BatchReserveAndOverbookLineItems(NetworkName parent, scg::IEnumerable<LineItemName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchReserveAndOverbookLineItems(new BatchReserveAndOverbookLineItemsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LineItemNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch reserves and overbooks `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to reserve and overbook.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchReserveAndOverbookLineItemsResponse> BatchReserveAndOverbookLineItemsAsync(NetworkName parent, scg::IEnumerable<LineItemName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchReserveAndOverbookLineItemsAsync(new BatchReserveAndOverbookLineItemsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LineItemNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch reserves and overbooks `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to reserve and overbook.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchReserveAndOverbookLineItemsResponse> BatchReserveAndOverbookLineItemsAsync(NetworkName parent, scg::IEnumerable<LineItemName> names, st::CancellationToken cancellationToken) =>
            BatchReserveAndOverbookLineItemsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch releases `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchReleaseLineItemsResponse BatchReleaseLineItems(BatchReleaseLineItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch releases `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchReleaseLineItemsResponse> BatchReleaseLineItemsAsync(BatchReleaseLineItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch releases `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchReleaseLineItemsResponse> BatchReleaseLineItemsAsync(BatchReleaseLineItemsRequest request, st::CancellationToken cancellationToken) =>
            BatchReleaseLineItemsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch releases `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to release.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchReleaseLineItemsResponse BatchReleaseLineItems(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchReleaseLineItems(new BatchReleaseLineItemsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch releases `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to release.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchReleaseLineItemsResponse> BatchReleaseLineItemsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchReleaseLineItemsAsync(new BatchReleaseLineItemsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch releases `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to release.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchReleaseLineItemsResponse> BatchReleaseLineItemsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchReleaseLineItemsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch releases `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to release.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchReleaseLineItemsResponse BatchReleaseLineItems(NetworkName parent, scg::IEnumerable<LineItemName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchReleaseLineItems(new BatchReleaseLineItemsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LineItemNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch releases `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to release.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchReleaseLineItemsResponse> BatchReleaseLineItemsAsync(NetworkName parent, scg::IEnumerable<LineItemName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchReleaseLineItemsAsync(new BatchReleaseLineItemsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LineItemNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch releases `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to release.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchReleaseLineItemsResponse> BatchReleaseLineItemsAsync(NetworkName parent, scg::IEnumerable<LineItemName> names, st::CancellationToken cancellationToken) =>
            BatchReleaseLineItemsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch archives `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchArchiveLineItemsResponse BatchArchiveLineItems(BatchArchiveLineItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch archives `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveLineItemsResponse> BatchArchiveLineItemsAsync(BatchArchiveLineItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch archives `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveLineItemsResponse> BatchArchiveLineItemsAsync(BatchArchiveLineItemsRequest request, st::CancellationToken cancellationToken) =>
            BatchArchiveLineItemsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch archives `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to archive.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchArchiveLineItemsResponse BatchArchiveLineItems(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchArchiveLineItems(new BatchArchiveLineItemsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch archives `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to archive.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveLineItemsResponse> BatchArchiveLineItemsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchArchiveLineItemsAsync(new BatchArchiveLineItemsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch archives `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to archive.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveLineItemsResponse> BatchArchiveLineItemsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchArchiveLineItemsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch archives `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to archive.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchArchiveLineItemsResponse BatchArchiveLineItems(NetworkName parent, scg::IEnumerable<LineItemName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchArchiveLineItems(new BatchArchiveLineItemsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LineItemNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch archives `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to archive.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveLineItemsResponse> BatchArchiveLineItemsAsync(NetworkName parent, scg::IEnumerable<LineItemName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchArchiveLineItemsAsync(new BatchArchiveLineItemsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LineItemNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch archives `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be updated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to archive.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveLineItemsResponse> BatchArchiveLineItemsAsync(NetworkName parent, scg::IEnumerable<LineItemName> names, st::CancellationToken cancellationToken) =>
            BatchArchiveLineItemsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch unarchives `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUnarchiveLineItemsResponse BatchUnarchiveLineItems(BatchUnarchiveLineItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch unarchives `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUnarchiveLineItemsResponse> BatchUnarchiveLineItemsAsync(BatchUnarchiveLineItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch unarchives `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUnarchiveLineItemsResponse> BatchUnarchiveLineItemsAsync(BatchUnarchiveLineItemsRequest request, st::CancellationToken cancellationToken) =>
            BatchUnarchiveLineItemsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch unarchives `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be unarchived.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to extract.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUnarchiveLineItemsResponse BatchUnarchiveLineItems(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchUnarchiveLineItems(new BatchUnarchiveLineItemsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch unarchives `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be unarchived.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to extract.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUnarchiveLineItemsResponse> BatchUnarchiveLineItemsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchUnarchiveLineItemsAsync(new BatchUnarchiveLineItemsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch unarchives `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be unarchived.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to extract.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUnarchiveLineItemsResponse> BatchUnarchiveLineItemsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchUnarchiveLineItemsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch unarchives `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be unarchived.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to extract.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUnarchiveLineItemsResponse BatchUnarchiveLineItems(NetworkName parent, scg::IEnumerable<LineItemName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchUnarchiveLineItems(new BatchUnarchiveLineItemsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LineItemNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch unarchives `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be unarchived.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to extract.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUnarchiveLineItemsResponse> BatchUnarchiveLineItemsAsync(NetworkName parent, scg::IEnumerable<LineItemName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchUnarchiveLineItemsAsync(new BatchUnarchiveLineItemsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LineItemNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch unarchives `LineItem` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItems` will be unarchived.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItem` objects to extract.
        /// Format: `networks/{network_code}/lineItems/{line_item}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUnarchiveLineItemsResponse> BatchUnarchiveLineItemsAsync(NetworkName parent, scg::IEnumerable<LineItemName> names, st::CancellationToken cancellationToken) =>
            BatchUnarchiveLineItemsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>LineItemService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `LineItem` objects.
    /// </remarks>
    public sealed partial class LineItemServiceClientImpl : LineItemServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetLineItemRequest, LineItem> _callGetLineItem;

        private readonly gaxgrpc::ApiCall<ListLineItemsRequest, ListLineItemsResponse> _callListLineItems;

        private readonly gaxgrpc::ApiCall<CreateLineItemRequest, LineItem> _callCreateLineItem;

        private readonly gaxgrpc::ApiCall<BatchCreateLineItemsRequest, BatchCreateLineItemsResponse> _callBatchCreateLineItems;

        private readonly gaxgrpc::ApiCall<UpdateLineItemRequest, LineItem> _callUpdateLineItem;

        private readonly gaxgrpc::ApiCall<BatchUpdateLineItemsRequest, BatchUpdateLineItemsResponse> _callBatchUpdateLineItems;

        private readonly gaxgrpc::ApiCall<BatchActivateLineItemsRequest, BatchActivateLineItemsResponse> _callBatchActivateLineItems;

        private readonly gaxgrpc::ApiCall<BatchPauseLineItemsRequest, BatchPauseLineItemsResponse> _callBatchPauseLineItems;

        private readonly gaxgrpc::ApiCall<BatchResumeLineItemsRequest, BatchResumeLineItemsResponse> _callBatchResumeLineItems;

        private readonly gaxgrpc::ApiCall<BatchResumeAndOverbookLineItemsRequest, BatchResumeAndOverbookLineItemsResponse> _callBatchResumeAndOverbookLineItems;

        private readonly gaxgrpc::ApiCall<BatchDeleteLineItemsRequest, wkt::Empty> _callBatchDeleteLineItems;

        private readonly gaxgrpc::ApiCall<BatchReserveLineItemsRequest, BatchReserveLineItemsResponse> _callBatchReserveLineItems;

        private readonly gaxgrpc::ApiCall<BatchReserveAndOverbookLineItemsRequest, BatchReserveAndOverbookLineItemsResponse> _callBatchReserveAndOverbookLineItems;

        private readonly gaxgrpc::ApiCall<BatchReleaseLineItemsRequest, BatchReleaseLineItemsResponse> _callBatchReleaseLineItems;

        private readonly gaxgrpc::ApiCall<BatchArchiveLineItemsRequest, BatchArchiveLineItemsResponse> _callBatchArchiveLineItems;

        private readonly gaxgrpc::ApiCall<BatchUnarchiveLineItemsRequest, BatchUnarchiveLineItemsResponse> _callBatchUnarchiveLineItems;

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
            _callCreateLineItem = clientHelper.BuildApiCall<CreateLineItemRequest, LineItem>("CreateLineItem", grpcClient.CreateLineItemAsync, grpcClient.CreateLineItem, effectiveSettings.CreateLineItemSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateLineItem);
            Modify_CreateLineItemApiCall(ref _callCreateLineItem);
            _callBatchCreateLineItems = clientHelper.BuildApiCall<BatchCreateLineItemsRequest, BatchCreateLineItemsResponse>("BatchCreateLineItems", grpcClient.BatchCreateLineItemsAsync, grpcClient.BatchCreateLineItems, effectiveSettings.BatchCreateLineItemsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCreateLineItems);
            Modify_BatchCreateLineItemsApiCall(ref _callBatchCreateLineItems);
            _callUpdateLineItem = clientHelper.BuildApiCall<UpdateLineItemRequest, LineItem>("UpdateLineItem", grpcClient.UpdateLineItemAsync, grpcClient.UpdateLineItem, effectiveSettings.UpdateLineItemSettings).WithGoogleRequestParam("line_item.name", request => request.LineItem?.Name);
            Modify_ApiCall(ref _callUpdateLineItem);
            Modify_UpdateLineItemApiCall(ref _callUpdateLineItem);
            _callBatchUpdateLineItems = clientHelper.BuildApiCall<BatchUpdateLineItemsRequest, BatchUpdateLineItemsResponse>("BatchUpdateLineItems", grpcClient.BatchUpdateLineItemsAsync, grpcClient.BatchUpdateLineItems, effectiveSettings.BatchUpdateLineItemsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchUpdateLineItems);
            Modify_BatchUpdateLineItemsApiCall(ref _callBatchUpdateLineItems);
            _callBatchActivateLineItems = clientHelper.BuildApiCall<BatchActivateLineItemsRequest, BatchActivateLineItemsResponse>("BatchActivateLineItems", grpcClient.BatchActivateLineItemsAsync, grpcClient.BatchActivateLineItems, effectiveSettings.BatchActivateLineItemsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchActivateLineItems);
            Modify_BatchActivateLineItemsApiCall(ref _callBatchActivateLineItems);
            _callBatchPauseLineItems = clientHelper.BuildApiCall<BatchPauseLineItemsRequest, BatchPauseLineItemsResponse>("BatchPauseLineItems", grpcClient.BatchPauseLineItemsAsync, grpcClient.BatchPauseLineItems, effectiveSettings.BatchPauseLineItemsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchPauseLineItems);
            Modify_BatchPauseLineItemsApiCall(ref _callBatchPauseLineItems);
            _callBatchResumeLineItems = clientHelper.BuildApiCall<BatchResumeLineItemsRequest, BatchResumeLineItemsResponse>("BatchResumeLineItems", grpcClient.BatchResumeLineItemsAsync, grpcClient.BatchResumeLineItems, effectiveSettings.BatchResumeLineItemsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchResumeLineItems);
            Modify_BatchResumeLineItemsApiCall(ref _callBatchResumeLineItems);
            _callBatchResumeAndOverbookLineItems = clientHelper.BuildApiCall<BatchResumeAndOverbookLineItemsRequest, BatchResumeAndOverbookLineItemsResponse>("BatchResumeAndOverbookLineItems", grpcClient.BatchResumeAndOverbookLineItemsAsync, grpcClient.BatchResumeAndOverbookLineItems, effectiveSettings.BatchResumeAndOverbookLineItemsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchResumeAndOverbookLineItems);
            Modify_BatchResumeAndOverbookLineItemsApiCall(ref _callBatchResumeAndOverbookLineItems);
            _callBatchDeleteLineItems = clientHelper.BuildApiCall<BatchDeleteLineItemsRequest, wkt::Empty>("BatchDeleteLineItems", grpcClient.BatchDeleteLineItemsAsync, grpcClient.BatchDeleteLineItems, effectiveSettings.BatchDeleteLineItemsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchDeleteLineItems);
            Modify_BatchDeleteLineItemsApiCall(ref _callBatchDeleteLineItems);
            _callBatchReserveLineItems = clientHelper.BuildApiCall<BatchReserveLineItemsRequest, BatchReserveLineItemsResponse>("BatchReserveLineItems", grpcClient.BatchReserveLineItemsAsync, grpcClient.BatchReserveLineItems, effectiveSettings.BatchReserveLineItemsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchReserveLineItems);
            Modify_BatchReserveLineItemsApiCall(ref _callBatchReserveLineItems);
            _callBatchReserveAndOverbookLineItems = clientHelper.BuildApiCall<BatchReserveAndOverbookLineItemsRequest, BatchReserveAndOverbookLineItemsResponse>("BatchReserveAndOverbookLineItems", grpcClient.BatchReserveAndOverbookLineItemsAsync, grpcClient.BatchReserveAndOverbookLineItems, effectiveSettings.BatchReserveAndOverbookLineItemsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchReserveAndOverbookLineItems);
            Modify_BatchReserveAndOverbookLineItemsApiCall(ref _callBatchReserveAndOverbookLineItems);
            _callBatchReleaseLineItems = clientHelper.BuildApiCall<BatchReleaseLineItemsRequest, BatchReleaseLineItemsResponse>("BatchReleaseLineItems", grpcClient.BatchReleaseLineItemsAsync, grpcClient.BatchReleaseLineItems, effectiveSettings.BatchReleaseLineItemsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchReleaseLineItems);
            Modify_BatchReleaseLineItemsApiCall(ref _callBatchReleaseLineItems);
            _callBatchArchiveLineItems = clientHelper.BuildApiCall<BatchArchiveLineItemsRequest, BatchArchiveLineItemsResponse>("BatchArchiveLineItems", grpcClient.BatchArchiveLineItemsAsync, grpcClient.BatchArchiveLineItems, effectiveSettings.BatchArchiveLineItemsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchArchiveLineItems);
            Modify_BatchArchiveLineItemsApiCall(ref _callBatchArchiveLineItems);
            _callBatchUnarchiveLineItems = clientHelper.BuildApiCall<BatchUnarchiveLineItemsRequest, BatchUnarchiveLineItemsResponse>("BatchUnarchiveLineItems", grpcClient.BatchUnarchiveLineItemsAsync, grpcClient.BatchUnarchiveLineItems, effectiveSettings.BatchUnarchiveLineItemsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchUnarchiveLineItems);
            Modify_BatchUnarchiveLineItemsApiCall(ref _callBatchUnarchiveLineItems);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetLineItemApiCall(ref gaxgrpc::ApiCall<GetLineItemRequest, LineItem> call);

        partial void Modify_ListLineItemsApiCall(ref gaxgrpc::ApiCall<ListLineItemsRequest, ListLineItemsResponse> call);

        partial void Modify_CreateLineItemApiCall(ref gaxgrpc::ApiCall<CreateLineItemRequest, LineItem> call);

        partial void Modify_BatchCreateLineItemsApiCall(ref gaxgrpc::ApiCall<BatchCreateLineItemsRequest, BatchCreateLineItemsResponse> call);

        partial void Modify_UpdateLineItemApiCall(ref gaxgrpc::ApiCall<UpdateLineItemRequest, LineItem> call);

        partial void Modify_BatchUpdateLineItemsApiCall(ref gaxgrpc::ApiCall<BatchUpdateLineItemsRequest, BatchUpdateLineItemsResponse> call);

        partial void Modify_BatchActivateLineItemsApiCall(ref gaxgrpc::ApiCall<BatchActivateLineItemsRequest, BatchActivateLineItemsResponse> call);

        partial void Modify_BatchPauseLineItemsApiCall(ref gaxgrpc::ApiCall<BatchPauseLineItemsRequest, BatchPauseLineItemsResponse> call);

        partial void Modify_BatchResumeLineItemsApiCall(ref gaxgrpc::ApiCall<BatchResumeLineItemsRequest, BatchResumeLineItemsResponse> call);

        partial void Modify_BatchResumeAndOverbookLineItemsApiCall(ref gaxgrpc::ApiCall<BatchResumeAndOverbookLineItemsRequest, BatchResumeAndOverbookLineItemsResponse> call);

        partial void Modify_BatchDeleteLineItemsApiCall(ref gaxgrpc::ApiCall<BatchDeleteLineItemsRequest, wkt::Empty> call);

        partial void Modify_BatchReserveLineItemsApiCall(ref gaxgrpc::ApiCall<BatchReserveLineItemsRequest, BatchReserveLineItemsResponse> call);

        partial void Modify_BatchReserveAndOverbookLineItemsApiCall(ref gaxgrpc::ApiCall<BatchReserveAndOverbookLineItemsRequest, BatchReserveAndOverbookLineItemsResponse> call);

        partial void Modify_BatchReleaseLineItemsApiCall(ref gaxgrpc::ApiCall<BatchReleaseLineItemsRequest, BatchReleaseLineItemsResponse> call);

        partial void Modify_BatchArchiveLineItemsApiCall(ref gaxgrpc::ApiCall<BatchArchiveLineItemsRequest, BatchArchiveLineItemsResponse> call);

        partial void Modify_BatchUnarchiveLineItemsApiCall(ref gaxgrpc::ApiCall<BatchUnarchiveLineItemsRequest, BatchUnarchiveLineItemsResponse> call);

        partial void OnConstruction(LineItemService.LineItemServiceClient grpcClient, LineItemServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC LineItemService client</summary>
        public override LineItemService.LineItemServiceClient GrpcClient { get; }

        partial void Modify_GetLineItemRequest(ref GetLineItemRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListLineItemsRequest(ref ListLineItemsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateLineItemRequest(ref CreateLineItemRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateLineItemsRequest(ref BatchCreateLineItemsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateLineItemRequest(ref UpdateLineItemRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUpdateLineItemsRequest(ref BatchUpdateLineItemsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchActivateLineItemsRequest(ref BatchActivateLineItemsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchPauseLineItemsRequest(ref BatchPauseLineItemsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchResumeLineItemsRequest(ref BatchResumeLineItemsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchResumeAndOverbookLineItemsRequest(ref BatchResumeAndOverbookLineItemsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchDeleteLineItemsRequest(ref BatchDeleteLineItemsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchReserveLineItemsRequest(ref BatchReserveLineItemsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchReserveAndOverbookLineItemsRequest(ref BatchReserveAndOverbookLineItemsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchReleaseLineItemsRequest(ref BatchReleaseLineItemsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchArchiveLineItemsRequest(ref BatchArchiveLineItemsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUnarchiveLineItemsRequest(ref BatchUnarchiveLineItemsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves a `LineItem` object.
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
        /// Retrieves a `LineItem` object.
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
        /// Lists `LineItem` objects.
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
        /// Lists `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LineItem"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListLineItemsResponse, LineItem> ListLineItemsAsync(ListLineItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLineItemsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListLineItemsRequest, ListLineItemsResponse, LineItem>(_callListLineItems, request, callSettings);
        }

        /// <summary>
        /// Creates a `LineItem` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LineItem CreateLineItem(CreateLineItemRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateLineItemRequest(ref request, ref callSettings);
            return _callCreateLineItem.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a `LineItem` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LineItem> CreateLineItemAsync(CreateLineItemRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateLineItemRequest(ref request, ref callSettings);
            return _callCreateLineItem.Async(request, callSettings);
        }

        /// <summary>
        /// Creates `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchCreateLineItemsResponse BatchCreateLineItems(BatchCreateLineItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateLineItemsRequest(ref request, ref callSettings);
            return _callBatchCreateLineItems.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchCreateLineItemsResponse> BatchCreateLineItemsAsync(BatchCreateLineItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateLineItemsRequest(ref request, ref callSettings);
            return _callBatchCreateLineItems.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a `LineItem` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LineItem UpdateLineItem(UpdateLineItemRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateLineItemRequest(ref request, ref callSettings);
            return _callUpdateLineItem.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a `LineItem` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LineItem> UpdateLineItemAsync(UpdateLineItemRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateLineItemRequest(ref request, ref callSettings);
            return _callUpdateLineItem.Async(request, callSettings);
        }

        /// <summary>
        /// Batch updates `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchUpdateLineItemsResponse BatchUpdateLineItems(BatchUpdateLineItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateLineItemsRequest(ref request, ref callSettings);
            return _callBatchUpdateLineItems.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch updates `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchUpdateLineItemsResponse> BatchUpdateLineItemsAsync(BatchUpdateLineItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateLineItemsRequest(ref request, ref callSettings);
            return _callBatchUpdateLineItems.Async(request, callSettings);
        }

        /// <summary>
        /// Batch activates `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchActivateLineItemsResponse BatchActivateLineItems(BatchActivateLineItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchActivateLineItemsRequest(ref request, ref callSettings);
            return _callBatchActivateLineItems.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch activates `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchActivateLineItemsResponse> BatchActivateLineItemsAsync(BatchActivateLineItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchActivateLineItemsRequest(ref request, ref callSettings);
            return _callBatchActivateLineItems.Async(request, callSettings);
        }

        /// <summary>
        /// Batch pauses `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchPauseLineItemsResponse BatchPauseLineItems(BatchPauseLineItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchPauseLineItemsRequest(ref request, ref callSettings);
            return _callBatchPauseLineItems.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch pauses `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchPauseLineItemsResponse> BatchPauseLineItemsAsync(BatchPauseLineItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchPauseLineItemsRequest(ref request, ref callSettings);
            return _callBatchPauseLineItems.Async(request, callSettings);
        }

        /// <summary>
        /// Batch resumes `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchResumeLineItemsResponse BatchResumeLineItems(BatchResumeLineItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchResumeLineItemsRequest(ref request, ref callSettings);
            return _callBatchResumeLineItems.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch resumes `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchResumeLineItemsResponse> BatchResumeLineItemsAsync(BatchResumeLineItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchResumeLineItemsRequest(ref request, ref callSettings);
            return _callBatchResumeLineItems.Async(request, callSettings);
        }

        /// <summary>
        /// Batch resumes and overbooks `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchResumeAndOverbookLineItemsResponse BatchResumeAndOverbookLineItems(BatchResumeAndOverbookLineItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchResumeAndOverbookLineItemsRequest(ref request, ref callSettings);
            return _callBatchResumeAndOverbookLineItems.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch resumes and overbooks `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchResumeAndOverbookLineItemsResponse> BatchResumeAndOverbookLineItemsAsync(BatchResumeAndOverbookLineItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchResumeAndOverbookLineItemsRequest(ref request, ref callSettings);
            return _callBatchResumeAndOverbookLineItems.Async(request, callSettings);
        }

        /// <summary>
        /// Batch deletes `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void BatchDeleteLineItems(BatchDeleteLineItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeleteLineItemsRequest(ref request, ref callSettings);
            _callBatchDeleteLineItems.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch deletes `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task BatchDeleteLineItemsAsync(BatchDeleteLineItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeleteLineItemsRequest(ref request, ref callSettings);
            return _callBatchDeleteLineItems.Async(request, callSettings);
        }

        /// <summary>
        /// Batch reserves `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchReserveLineItemsResponse BatchReserveLineItems(BatchReserveLineItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchReserveLineItemsRequest(ref request, ref callSettings);
            return _callBatchReserveLineItems.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch reserves `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchReserveLineItemsResponse> BatchReserveLineItemsAsync(BatchReserveLineItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchReserveLineItemsRequest(ref request, ref callSettings);
            return _callBatchReserveLineItems.Async(request, callSettings);
        }

        /// <summary>
        /// Batch reserves and overbooks `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchReserveAndOverbookLineItemsResponse BatchReserveAndOverbookLineItems(BatchReserveAndOverbookLineItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchReserveAndOverbookLineItemsRequest(ref request, ref callSettings);
            return _callBatchReserveAndOverbookLineItems.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch reserves and overbooks `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchReserveAndOverbookLineItemsResponse> BatchReserveAndOverbookLineItemsAsync(BatchReserveAndOverbookLineItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchReserveAndOverbookLineItemsRequest(ref request, ref callSettings);
            return _callBatchReserveAndOverbookLineItems.Async(request, callSettings);
        }

        /// <summary>
        /// Batch releases `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchReleaseLineItemsResponse BatchReleaseLineItems(BatchReleaseLineItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchReleaseLineItemsRequest(ref request, ref callSettings);
            return _callBatchReleaseLineItems.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch releases `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchReleaseLineItemsResponse> BatchReleaseLineItemsAsync(BatchReleaseLineItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchReleaseLineItemsRequest(ref request, ref callSettings);
            return _callBatchReleaseLineItems.Async(request, callSettings);
        }

        /// <summary>
        /// Batch archives `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchArchiveLineItemsResponse BatchArchiveLineItems(BatchArchiveLineItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchArchiveLineItemsRequest(ref request, ref callSettings);
            return _callBatchArchiveLineItems.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch archives `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchArchiveLineItemsResponse> BatchArchiveLineItemsAsync(BatchArchiveLineItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchArchiveLineItemsRequest(ref request, ref callSettings);
            return _callBatchArchiveLineItems.Async(request, callSettings);
        }

        /// <summary>
        /// Batch unarchives `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchUnarchiveLineItemsResponse BatchUnarchiveLineItems(BatchUnarchiveLineItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUnarchiveLineItemsRequest(ref request, ref callSettings);
            return _callBatchUnarchiveLineItems.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch unarchives `LineItem` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchUnarchiveLineItemsResponse> BatchUnarchiveLineItemsAsync(BatchUnarchiveLineItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUnarchiveLineItemsRequest(ref request, ref callSettings);
            return _callBatchUnarchiveLineItems.Async(request, callSettings);
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
