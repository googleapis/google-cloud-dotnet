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
    /// <summary>Settings for <see cref="LineItemCreativeAssociationServiceClient"/> instances.</summary>
    public sealed partial class LineItemCreativeAssociationServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="LineItemCreativeAssociationServiceSettings"/>.
        /// </summary>
        /// <returns>A new instance of the default <see cref="LineItemCreativeAssociationServiceSettings"/>.</returns>
        public static LineItemCreativeAssociationServiceSettings GetDefault() =>
            new LineItemCreativeAssociationServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="LineItemCreativeAssociationServiceSettings"/> object with default settings.
        /// </summary>
        public LineItemCreativeAssociationServiceSettings()
        {
        }

        private LineItemCreativeAssociationServiceSettings(LineItemCreativeAssociationServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetLineItemCreativeAssociationSettings = existing.GetLineItemCreativeAssociationSettings;
            ListLineItemCreativeAssociationsSettings = existing.ListLineItemCreativeAssociationsSettings;
            CreateLineItemCreativeAssociationSettings = existing.CreateLineItemCreativeAssociationSettings;
            BatchCreateLineItemCreativeAssociationsSettings = existing.BatchCreateLineItemCreativeAssociationsSettings;
            UpdateLineItemCreativeAssociationSettings = existing.UpdateLineItemCreativeAssociationSettings;
            BatchUpdateLineItemCreativeAssociationsSettings = existing.BatchUpdateLineItemCreativeAssociationsSettings;
            BatchActivateLineItemCreativeAssociationsSettings = existing.BatchActivateLineItemCreativeAssociationsSettings;
            BatchDeactivateLineItemCreativeAssociationsSettings = existing.BatchDeactivateLineItemCreativeAssociationsSettings;
            BatchDeleteLineItemCreativeAssociationsSettings = existing.BatchDeleteLineItemCreativeAssociationsSettings;
            PreviewLineItemCreativeAssociationSettings = existing.PreviewLineItemCreativeAssociationSettings;
            OnCopy(existing);
        }

        partial void OnCopy(LineItemCreativeAssociationServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LineItemCreativeAssociationServiceClient.GetLineItemCreativeAssociation</c> and
        /// <c>LineItemCreativeAssociationServiceClient.GetLineItemCreativeAssociationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetLineItemCreativeAssociationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LineItemCreativeAssociationServiceClient.ListLineItemCreativeAssociations</c> and
        /// <c>LineItemCreativeAssociationServiceClient.ListLineItemCreativeAssociationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListLineItemCreativeAssociationsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LineItemCreativeAssociationServiceClient.CreateLineItemCreativeAssociation</c> and
        /// <c>LineItemCreativeAssociationServiceClient.CreateLineItemCreativeAssociationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateLineItemCreativeAssociationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LineItemCreativeAssociationServiceClient.BatchCreateLineItemCreativeAssociations</c> and
        /// <c>LineItemCreativeAssociationServiceClient.BatchCreateLineItemCreativeAssociationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchCreateLineItemCreativeAssociationsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LineItemCreativeAssociationServiceClient.UpdateLineItemCreativeAssociation</c> and
        /// <c>LineItemCreativeAssociationServiceClient.UpdateLineItemCreativeAssociationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateLineItemCreativeAssociationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LineItemCreativeAssociationServiceClient.BatchUpdateLineItemCreativeAssociations</c> and
        /// <c>LineItemCreativeAssociationServiceClient.BatchUpdateLineItemCreativeAssociationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchUpdateLineItemCreativeAssociationsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LineItemCreativeAssociationServiceClient.BatchActivateLineItemCreativeAssociations</c> and
        /// <c>LineItemCreativeAssociationServiceClient.BatchActivateLineItemCreativeAssociationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchActivateLineItemCreativeAssociationsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LineItemCreativeAssociationServiceClient.BatchDeactivateLineItemCreativeAssociations</c> and
        /// <c>LineItemCreativeAssociationServiceClient.BatchDeactivateLineItemCreativeAssociationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchDeactivateLineItemCreativeAssociationsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LineItemCreativeAssociationServiceClient.BatchDeleteLineItemCreativeAssociations</c> and
        /// <c>LineItemCreativeAssociationServiceClient.BatchDeleteLineItemCreativeAssociationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchDeleteLineItemCreativeAssociationsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LineItemCreativeAssociationServiceClient.PreviewLineItemCreativeAssociation</c> and
        /// <c>LineItemCreativeAssociationServiceClient.PreviewLineItemCreativeAssociationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PreviewLineItemCreativeAssociationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="LineItemCreativeAssociationServiceSettings"/> object.</returns>
        public LineItemCreativeAssociationServiceSettings Clone() => new LineItemCreativeAssociationServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="LineItemCreativeAssociationServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class LineItemCreativeAssociationServiceClientBuilder : gaxgrpc::ClientBuilderBase<LineItemCreativeAssociationServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public LineItemCreativeAssociationServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public LineItemCreativeAssociationServiceClientBuilder() : base(LineItemCreativeAssociationServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref LineItemCreativeAssociationServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<LineItemCreativeAssociationServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override LineItemCreativeAssociationServiceClient Build()
        {
            LineItemCreativeAssociationServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<LineItemCreativeAssociationServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<LineItemCreativeAssociationServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private LineItemCreativeAssociationServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return LineItemCreativeAssociationServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<LineItemCreativeAssociationServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return LineItemCreativeAssociationServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => LineItemCreativeAssociationServiceClient.ChannelPool;
    }

    /// <summary>LineItemCreativeAssociationService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `LineItemCreativeAssociation` objects.
    /// </remarks>
    public abstract partial class LineItemCreativeAssociationServiceClient
    {
        /// <summary>
        /// The default endpoint for the LineItemCreativeAssociationService service, which is a host of
        /// "admanager.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default LineItemCreativeAssociationService scopes.</summary>
        /// <remarks>
        /// The default LineItemCreativeAssociationService scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(LineItemCreativeAssociationService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="LineItemCreativeAssociationServiceClient"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="LineItemCreativeAssociationServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="LineItemCreativeAssociationServiceClient"/>.</returns>
        public static stt::Task<LineItemCreativeAssociationServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new LineItemCreativeAssociationServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="LineItemCreativeAssociationServiceClient"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="LineItemCreativeAssociationServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="LineItemCreativeAssociationServiceClient"/>.</returns>
        public static LineItemCreativeAssociationServiceClient Create() =>
            new LineItemCreativeAssociationServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="LineItemCreativeAssociationServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="LineItemCreativeAssociationServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="LineItemCreativeAssociationServiceClient"/>.</returns>
        internal static LineItemCreativeAssociationServiceClient Create(grpccore::CallInvoker callInvoker, LineItemCreativeAssociationServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            LineItemCreativeAssociationService.LineItemCreativeAssociationServiceClient grpcClient = new LineItemCreativeAssociationService.LineItemCreativeAssociationServiceClient(callInvoker);
            return new LineItemCreativeAssociationServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC LineItemCreativeAssociationService client</summary>
        public virtual LineItemCreativeAssociationService.LineItemCreativeAssociationServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `LineItemCreativeAssociation` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LineItemCreativeAssociation GetLineItemCreativeAssociation(GetLineItemCreativeAssociationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `LineItemCreativeAssociation` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineItemCreativeAssociation> GetLineItemCreativeAssociationAsync(GetLineItemCreativeAssociationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `LineItemCreativeAssociation` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineItemCreativeAssociation> GetLineItemCreativeAssociationAsync(GetLineItemCreativeAssociationRequest request, st::CancellationToken cancellationToken) =>
            GetLineItemCreativeAssociationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `LineItemCreativeAssociation` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the LineItemCreativeAssociation.
        /// Format:
        /// `networks/{network_code}/lineItems/{line_item_id}/creatives/{creative_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LineItemCreativeAssociation GetLineItemCreativeAssociation(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetLineItemCreativeAssociation(new GetLineItemCreativeAssociationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `LineItemCreativeAssociation` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the LineItemCreativeAssociation.
        /// Format:
        /// `networks/{network_code}/lineItems/{line_item_id}/creatives/{creative_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineItemCreativeAssociation> GetLineItemCreativeAssociationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetLineItemCreativeAssociationAsync(new GetLineItemCreativeAssociationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `LineItemCreativeAssociation` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the LineItemCreativeAssociation.
        /// Format:
        /// `networks/{network_code}/lineItems/{line_item_id}/creatives/{creative_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineItemCreativeAssociation> GetLineItemCreativeAssociationAsync(string name, st::CancellationToken cancellationToken) =>
            GetLineItemCreativeAssociationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `LineItemCreativeAssociation` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the LineItemCreativeAssociation.
        /// Format:
        /// `networks/{network_code}/lineItems/{line_item_id}/creatives/{creative_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LineItemCreativeAssociation GetLineItemCreativeAssociation(LineItemCreativeAssociationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetLineItemCreativeAssociation(new GetLineItemCreativeAssociationRequest
            {
                LineItemCreativeAssociationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `LineItemCreativeAssociation` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the LineItemCreativeAssociation.
        /// Format:
        /// `networks/{network_code}/lineItems/{line_item_id}/creatives/{creative_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineItemCreativeAssociation> GetLineItemCreativeAssociationAsync(LineItemCreativeAssociationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetLineItemCreativeAssociationAsync(new GetLineItemCreativeAssociationRequest
            {
                LineItemCreativeAssociationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `LineItemCreativeAssociation` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the LineItemCreativeAssociation.
        /// Format:
        /// `networks/{network_code}/lineItems/{line_item_id}/creatives/{creative_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineItemCreativeAssociation> GetLineItemCreativeAssociationAsync(LineItemCreativeAssociationName name, st::CancellationToken cancellationToken) =>
            GetLineItemCreativeAssociationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LineItemCreativeAssociation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLineItemCreativeAssociationsResponse, LineItemCreativeAssociation> ListLineItemCreativeAssociations(ListLineItemCreativeAssociationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LineItemCreativeAssociation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLineItemCreativeAssociationsResponse, LineItemCreativeAssociation> ListLineItemCreativeAssociationsAsync(ListLineItemCreativeAssociationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of
        /// LineItemCreativeAssociations. This request supports using the "-" character
        /// as a wildcard for resources that span across multiple LineItem parents.
        /// Format: `networks/{network_code}/lineItems/{line_item_id}`
        /// Format: `networks/{network_code}/lineItems/-`
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
        /// <returns>A pageable sequence of <see cref="LineItemCreativeAssociation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLineItemCreativeAssociationsResponse, LineItemCreativeAssociation> ListLineItemCreativeAssociations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLineItemCreativeAssociationsRequest request = new ListLineItemCreativeAssociationsRequest
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
            return ListLineItemCreativeAssociations(request, callSettings);
        }

        /// <summary>
        /// Lists `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of
        /// LineItemCreativeAssociations. This request supports using the "-" character
        /// as a wildcard for resources that span across multiple LineItem parents.
        /// Format: `networks/{network_code}/lineItems/{line_item_id}`
        /// Format: `networks/{network_code}/lineItems/-`
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
        /// <returns>A pageable asynchronous sequence of <see cref="LineItemCreativeAssociation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLineItemCreativeAssociationsResponse, LineItemCreativeAssociation> ListLineItemCreativeAssociationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLineItemCreativeAssociationsRequest request = new ListLineItemCreativeAssociationsRequest
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
            return ListLineItemCreativeAssociationsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of
        /// LineItemCreativeAssociations. This request supports using the "-" character
        /// as a wildcard for resources that span across multiple LineItem parents.
        /// Format: `networks/{network_code}/lineItems/{line_item_id}`
        /// Format: `networks/{network_code}/lineItems/-`
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
        /// <returns>A pageable sequence of <see cref="LineItemCreativeAssociation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLineItemCreativeAssociationsResponse, LineItemCreativeAssociation> ListLineItemCreativeAssociations(LineItemName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLineItemCreativeAssociationsRequest request = new ListLineItemCreativeAssociationsRequest
            {
                ParentAsLineItemName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListLineItemCreativeAssociations(request, callSettings);
        }

        /// <summary>
        /// Lists `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of
        /// LineItemCreativeAssociations. This request supports using the "-" character
        /// as a wildcard for resources that span across multiple LineItem parents.
        /// Format: `networks/{network_code}/lineItems/{line_item_id}`
        /// Format: `networks/{network_code}/lineItems/-`
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
        /// <returns>A pageable asynchronous sequence of <see cref="LineItemCreativeAssociation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLineItemCreativeAssociationsResponse, LineItemCreativeAssociation> ListLineItemCreativeAssociationsAsync(LineItemName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLineItemCreativeAssociationsRequest request = new ListLineItemCreativeAssociationsRequest
            {
                ParentAsLineItemName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListLineItemCreativeAssociationsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a `LineItemCreativeAssociation` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LineItemCreativeAssociation CreateLineItemCreativeAssociation(CreateLineItemCreativeAssociationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `LineItemCreativeAssociation` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineItemCreativeAssociation> CreateLineItemCreativeAssociationAsync(CreateLineItemCreativeAssociationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `LineItemCreativeAssociation` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineItemCreativeAssociation> CreateLineItemCreativeAssociationAsync(CreateLineItemCreativeAssociationRequest request, st::CancellationToken cancellationToken) =>
            CreateLineItemCreativeAssociationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `LineItemCreativeAssociation` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `LineItemCreativeAssociation` will
        /// be created. Format: `networks/{network_code}/lineItems/{line_item_id}`
        /// </param>
        /// <param name="lineItemCreativeAssociation">
        /// Required. The `LineItemCreativeAssociation` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LineItemCreativeAssociation CreateLineItemCreativeAssociation(string parent, LineItemCreativeAssociation lineItemCreativeAssociation, gaxgrpc::CallSettings callSettings = null) =>
            CreateLineItemCreativeAssociation(new CreateLineItemCreativeAssociationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                LineItemCreativeAssociation = gax::GaxPreconditions.CheckNotNull(lineItemCreativeAssociation, nameof(lineItemCreativeAssociation)),
            }, callSettings);

        /// <summary>
        /// Creates a `LineItemCreativeAssociation` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `LineItemCreativeAssociation` will
        /// be created. Format: `networks/{network_code}/lineItems/{line_item_id}`
        /// </param>
        /// <param name="lineItemCreativeAssociation">
        /// Required. The `LineItemCreativeAssociation` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineItemCreativeAssociation> CreateLineItemCreativeAssociationAsync(string parent, LineItemCreativeAssociation lineItemCreativeAssociation, gaxgrpc::CallSettings callSettings = null) =>
            CreateLineItemCreativeAssociationAsync(new CreateLineItemCreativeAssociationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                LineItemCreativeAssociation = gax::GaxPreconditions.CheckNotNull(lineItemCreativeAssociation, nameof(lineItemCreativeAssociation)),
            }, callSettings);

        /// <summary>
        /// Creates a `LineItemCreativeAssociation` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `LineItemCreativeAssociation` will
        /// be created. Format: `networks/{network_code}/lineItems/{line_item_id}`
        /// </param>
        /// <param name="lineItemCreativeAssociation">
        /// Required. The `LineItemCreativeAssociation` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineItemCreativeAssociation> CreateLineItemCreativeAssociationAsync(string parent, LineItemCreativeAssociation lineItemCreativeAssociation, st::CancellationToken cancellationToken) =>
            CreateLineItemCreativeAssociationAsync(parent, lineItemCreativeAssociation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `LineItemCreativeAssociation` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `LineItemCreativeAssociation` will
        /// be created. Format: `networks/{network_code}/lineItems/{line_item_id}`
        /// </param>
        /// <param name="lineItemCreativeAssociation">
        /// Required. The `LineItemCreativeAssociation` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LineItemCreativeAssociation CreateLineItemCreativeAssociation(LineItemName parent, LineItemCreativeAssociation lineItemCreativeAssociation, gaxgrpc::CallSettings callSettings = null) =>
            CreateLineItemCreativeAssociation(new CreateLineItemCreativeAssociationRequest
            {
                ParentAsLineItemName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LineItemCreativeAssociation = gax::GaxPreconditions.CheckNotNull(lineItemCreativeAssociation, nameof(lineItemCreativeAssociation)),
            }, callSettings);

        /// <summary>
        /// Creates a `LineItemCreativeAssociation` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `LineItemCreativeAssociation` will
        /// be created. Format: `networks/{network_code}/lineItems/{line_item_id}`
        /// </param>
        /// <param name="lineItemCreativeAssociation">
        /// Required. The `LineItemCreativeAssociation` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineItemCreativeAssociation> CreateLineItemCreativeAssociationAsync(LineItemName parent, LineItemCreativeAssociation lineItemCreativeAssociation, gaxgrpc::CallSettings callSettings = null) =>
            CreateLineItemCreativeAssociationAsync(new CreateLineItemCreativeAssociationRequest
            {
                ParentAsLineItemName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LineItemCreativeAssociation = gax::GaxPreconditions.CheckNotNull(lineItemCreativeAssociation, nameof(lineItemCreativeAssociation)),
            }, callSettings);

        /// <summary>
        /// Creates a `LineItemCreativeAssociation` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `LineItemCreativeAssociation` will
        /// be created. Format: `networks/{network_code}/lineItems/{line_item_id}`
        /// </param>
        /// <param name="lineItemCreativeAssociation">
        /// Required. The `LineItemCreativeAssociation` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineItemCreativeAssociation> CreateLineItemCreativeAssociationAsync(LineItemName parent, LineItemCreativeAssociation lineItemCreativeAssociation, st::CancellationToken cancellationToken) =>
            CreateLineItemCreativeAssociationAsync(parent, lineItemCreativeAssociation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateLineItemCreativeAssociationsResponse BatchCreateLineItemCreativeAssociations(BatchCreateLineItemCreativeAssociationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateLineItemCreativeAssociationsResponse> BatchCreateLineItemCreativeAssociationsAsync(BatchCreateLineItemCreativeAssociationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateLineItemCreativeAssociationsResponse> BatchCreateLineItemCreativeAssociationsAsync(BatchCreateLineItemCreativeAssociationsRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateLineItemCreativeAssociationsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItemCreativeAssociations` will be
        /// created. This request supports using the "-" character as a wildcard for
        /// resources that span across multiple LineItem parents. Format:
        /// `networks/{network_code}/lineItems/{line_item_id}` Format:
        /// `networks/{network_code}/lineItems/-`
        /// </param>
        /// <param name="requests">
        /// Required. The `LineItemCreativeAssociation` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateLineItemCreativeAssociationsResponse BatchCreateLineItemCreativeAssociations(string parent, scg::IEnumerable<CreateLineItemCreativeAssociationRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateLineItemCreativeAssociations(new BatchCreateLineItemCreativeAssociationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItemCreativeAssociations` will be
        /// created. This request supports using the "-" character as a wildcard for
        /// resources that span across multiple LineItem parents. Format:
        /// `networks/{network_code}/lineItems/{line_item_id}` Format:
        /// `networks/{network_code}/lineItems/-`
        /// </param>
        /// <param name="requests">
        /// Required. The `LineItemCreativeAssociation` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateLineItemCreativeAssociationsResponse> BatchCreateLineItemCreativeAssociationsAsync(string parent, scg::IEnumerable<CreateLineItemCreativeAssociationRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateLineItemCreativeAssociationsAsync(new BatchCreateLineItemCreativeAssociationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItemCreativeAssociations` will be
        /// created. This request supports using the "-" character as a wildcard for
        /// resources that span across multiple LineItem parents. Format:
        /// `networks/{network_code}/lineItems/{line_item_id}` Format:
        /// `networks/{network_code}/lineItems/-`
        /// </param>
        /// <param name="requests">
        /// Required. The `LineItemCreativeAssociation` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateLineItemCreativeAssociationsResponse> BatchCreateLineItemCreativeAssociationsAsync(string parent, scg::IEnumerable<CreateLineItemCreativeAssociationRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateLineItemCreativeAssociationsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItemCreativeAssociations` will be
        /// created. This request supports using the "-" character as a wildcard for
        /// resources that span across multiple LineItem parents. Format:
        /// `networks/{network_code}/lineItems/{line_item_id}` Format:
        /// `networks/{network_code}/lineItems/-`
        /// </param>
        /// <param name="requests">
        /// Required. The `LineItemCreativeAssociation` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateLineItemCreativeAssociationsResponse BatchCreateLineItemCreativeAssociations(LineItemName parent, scg::IEnumerable<CreateLineItemCreativeAssociationRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateLineItemCreativeAssociations(new BatchCreateLineItemCreativeAssociationsRequest
            {
                ParentAsLineItemName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItemCreativeAssociations` will be
        /// created. This request supports using the "-" character as a wildcard for
        /// resources that span across multiple LineItem parents. Format:
        /// `networks/{network_code}/lineItems/{line_item_id}` Format:
        /// `networks/{network_code}/lineItems/-`
        /// </param>
        /// <param name="requests">
        /// Required. The `LineItemCreativeAssociation` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateLineItemCreativeAssociationsResponse> BatchCreateLineItemCreativeAssociationsAsync(LineItemName parent, scg::IEnumerable<CreateLineItemCreativeAssociationRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateLineItemCreativeAssociationsAsync(new BatchCreateLineItemCreativeAssociationsRequest
            {
                ParentAsLineItemName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItemCreativeAssociations` will be
        /// created. This request supports using the "-" character as a wildcard for
        /// resources that span across multiple LineItem parents. Format:
        /// `networks/{network_code}/lineItems/{line_item_id}` Format:
        /// `networks/{network_code}/lineItems/-`
        /// </param>
        /// <param name="requests">
        /// Required. The `LineItemCreativeAssociation` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateLineItemCreativeAssociationsResponse> BatchCreateLineItemCreativeAssociationsAsync(LineItemName parent, scg::IEnumerable<CreateLineItemCreativeAssociationRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateLineItemCreativeAssociationsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `LineItemCreativeAssociation` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LineItemCreativeAssociation UpdateLineItemCreativeAssociation(UpdateLineItemCreativeAssociationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `LineItemCreativeAssociation` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineItemCreativeAssociation> UpdateLineItemCreativeAssociationAsync(UpdateLineItemCreativeAssociationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `LineItemCreativeAssociation` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineItemCreativeAssociation> UpdateLineItemCreativeAssociationAsync(UpdateLineItemCreativeAssociationRequest request, st::CancellationToken cancellationToken) =>
            UpdateLineItemCreativeAssociationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `LineItemCreativeAssociation` object.
        /// </summary>
        /// <param name="lineItemCreativeAssociation">
        /// Required. The `LineItemCreativeAssociation` to update.
        /// Format:
        /// `networks/{network_code}/lineItems/{line_item_id}/creatives/{creative_id}`
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LineItemCreativeAssociation UpdateLineItemCreativeAssociation(LineItemCreativeAssociation lineItemCreativeAssociation, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateLineItemCreativeAssociation(new UpdateLineItemCreativeAssociationRequest
            {
                LineItemCreativeAssociation = gax::GaxPreconditions.CheckNotNull(lineItemCreativeAssociation, nameof(lineItemCreativeAssociation)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a `LineItemCreativeAssociation` object.
        /// </summary>
        /// <param name="lineItemCreativeAssociation">
        /// Required. The `LineItemCreativeAssociation` to update.
        /// Format:
        /// `networks/{network_code}/lineItems/{line_item_id}/creatives/{creative_id}`
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineItemCreativeAssociation> UpdateLineItemCreativeAssociationAsync(LineItemCreativeAssociation lineItemCreativeAssociation, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateLineItemCreativeAssociationAsync(new UpdateLineItemCreativeAssociationRequest
            {
                LineItemCreativeAssociation = gax::GaxPreconditions.CheckNotNull(lineItemCreativeAssociation, nameof(lineItemCreativeAssociation)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a `LineItemCreativeAssociation` object.
        /// </summary>
        /// <param name="lineItemCreativeAssociation">
        /// Required. The `LineItemCreativeAssociation` to update.
        /// Format:
        /// `networks/{network_code}/lineItems/{line_item_id}/creatives/{creative_id}`
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineItemCreativeAssociation> UpdateLineItemCreativeAssociationAsync(LineItemCreativeAssociation lineItemCreativeAssociation, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateLineItemCreativeAssociationAsync(lineItemCreativeAssociation, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateLineItemCreativeAssociationsResponse BatchUpdateLineItemCreativeAssociations(BatchUpdateLineItemCreativeAssociationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch updates `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateLineItemCreativeAssociationsResponse> BatchUpdateLineItemCreativeAssociationsAsync(BatchUpdateLineItemCreativeAssociationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch updates `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateLineItemCreativeAssociationsResponse> BatchUpdateLineItemCreativeAssociationsAsync(BatchUpdateLineItemCreativeAssociationsRequest request, st::CancellationToken cancellationToken) =>
            BatchUpdateLineItemCreativeAssociationsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItemCreativeAssociations` will be
        /// updated. This request supports using the "-" character as a wildcard for
        /// resources that span across multiple LineItem parents. Format:
        /// `networks/{network_code}/lineItems/{line_item_id}` Format:
        /// `networks/{network_code}/lineItems/-`
        /// </param>
        /// <param name="requests">
        /// Required. The `LineItemCreativeAssociation` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateLineItemCreativeAssociationsResponse BatchUpdateLineItemCreativeAssociations(string parent, scg::IEnumerable<UpdateLineItemCreativeAssociationRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateLineItemCreativeAssociations(new BatchUpdateLineItemCreativeAssociationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItemCreativeAssociations` will be
        /// updated. This request supports using the "-" character as a wildcard for
        /// resources that span across multiple LineItem parents. Format:
        /// `networks/{network_code}/lineItems/{line_item_id}` Format:
        /// `networks/{network_code}/lineItems/-`
        /// </param>
        /// <param name="requests">
        /// Required. The `LineItemCreativeAssociation` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateLineItemCreativeAssociationsResponse> BatchUpdateLineItemCreativeAssociationsAsync(string parent, scg::IEnumerable<UpdateLineItemCreativeAssociationRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateLineItemCreativeAssociationsAsync(new BatchUpdateLineItemCreativeAssociationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItemCreativeAssociations` will be
        /// updated. This request supports using the "-" character as a wildcard for
        /// resources that span across multiple LineItem parents. Format:
        /// `networks/{network_code}/lineItems/{line_item_id}` Format:
        /// `networks/{network_code}/lineItems/-`
        /// </param>
        /// <param name="requests">
        /// Required. The `LineItemCreativeAssociation` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateLineItemCreativeAssociationsResponse> BatchUpdateLineItemCreativeAssociationsAsync(string parent, scg::IEnumerable<UpdateLineItemCreativeAssociationRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateLineItemCreativeAssociationsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItemCreativeAssociations` will be
        /// updated. This request supports using the "-" character as a wildcard for
        /// resources that span across multiple LineItem parents. Format:
        /// `networks/{network_code}/lineItems/{line_item_id}` Format:
        /// `networks/{network_code}/lineItems/-`
        /// </param>
        /// <param name="requests">
        /// Required. The `LineItemCreativeAssociation` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateLineItemCreativeAssociationsResponse BatchUpdateLineItemCreativeAssociations(LineItemName parent, scg::IEnumerable<UpdateLineItemCreativeAssociationRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateLineItemCreativeAssociations(new BatchUpdateLineItemCreativeAssociationsRequest
            {
                ParentAsLineItemName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItemCreativeAssociations` will be
        /// updated. This request supports using the "-" character as a wildcard for
        /// resources that span across multiple LineItem parents. Format:
        /// `networks/{network_code}/lineItems/{line_item_id}` Format:
        /// `networks/{network_code}/lineItems/-`
        /// </param>
        /// <param name="requests">
        /// Required. The `LineItemCreativeAssociation` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateLineItemCreativeAssociationsResponse> BatchUpdateLineItemCreativeAssociationsAsync(LineItemName parent, scg::IEnumerable<UpdateLineItemCreativeAssociationRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateLineItemCreativeAssociationsAsync(new BatchUpdateLineItemCreativeAssociationsRequest
            {
                ParentAsLineItemName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItemCreativeAssociations` will be
        /// updated. This request supports using the "-" character as a wildcard for
        /// resources that span across multiple LineItem parents. Format:
        /// `networks/{network_code}/lineItems/{line_item_id}` Format:
        /// `networks/{network_code}/lineItems/-`
        /// </param>
        /// <param name="requests">
        /// Required. The `LineItemCreativeAssociation` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateLineItemCreativeAssociationsResponse> BatchUpdateLineItemCreativeAssociationsAsync(LineItemName parent, scg::IEnumerable<UpdateLineItemCreativeAssociationRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateLineItemCreativeAssociationsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Activate a list of `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateLineItemCreativeAssociationsResponse BatchActivateLineItemCreativeAssociations(BatchActivateLineItemCreativeAssociationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Activate a list of `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateLineItemCreativeAssociationsResponse> BatchActivateLineItemCreativeAssociationsAsync(BatchActivateLineItemCreativeAssociationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Activate a list of `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateLineItemCreativeAssociationsResponse> BatchActivateLineItemCreativeAssociationsAsync(BatchActivateLineItemCreativeAssociationsRequest request, st::CancellationToken cancellationToken) =>
            BatchActivateLineItemCreativeAssociationsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Activate a list of `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItemCreativeAssociations` will be
        /// activated. This request supports using the "-" character as a wildcard for
        /// resources that span across multiple LineItem parents. Format:
        /// `networks/{network_code}/lineItems/{line_item_id}` Format:
        /// `networks/{network_code}/lineItems/-`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItemCreativeAssociation` objects to
        /// activate. A maximum of 1000 objects can be activated in a batch. Format:
        /// `networks/{network_code}/lineItems/{line_item_id}/creatives/{creative_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateLineItemCreativeAssociationsResponse BatchActivateLineItemCreativeAssociations(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateLineItemCreativeAssociations(new BatchActivateLineItemCreativeAssociationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Activate a list of `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItemCreativeAssociations` will be
        /// activated. This request supports using the "-" character as a wildcard for
        /// resources that span across multiple LineItem parents. Format:
        /// `networks/{network_code}/lineItems/{line_item_id}` Format:
        /// `networks/{network_code}/lineItems/-`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItemCreativeAssociation` objects to
        /// activate. A maximum of 1000 objects can be activated in a batch. Format:
        /// `networks/{network_code}/lineItems/{line_item_id}/creatives/{creative_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateLineItemCreativeAssociationsResponse> BatchActivateLineItemCreativeAssociationsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateLineItemCreativeAssociationsAsync(new BatchActivateLineItemCreativeAssociationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Activate a list of `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItemCreativeAssociations` will be
        /// activated. This request supports using the "-" character as a wildcard for
        /// resources that span across multiple LineItem parents. Format:
        /// `networks/{network_code}/lineItems/{line_item_id}` Format:
        /// `networks/{network_code}/lineItems/-`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItemCreativeAssociation` objects to
        /// activate. A maximum of 1000 objects can be activated in a batch. Format:
        /// `networks/{network_code}/lineItems/{line_item_id}/creatives/{creative_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateLineItemCreativeAssociationsResponse> BatchActivateLineItemCreativeAssociationsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchActivateLineItemCreativeAssociationsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Activate a list of `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItemCreativeAssociations` will be
        /// activated. This request supports using the "-" character as a wildcard for
        /// resources that span across multiple LineItem parents. Format:
        /// `networks/{network_code}/lineItems/{line_item_id}` Format:
        /// `networks/{network_code}/lineItems/-`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItemCreativeAssociation` objects to
        /// activate. A maximum of 1000 objects can be activated in a batch. Format:
        /// `networks/{network_code}/lineItems/{line_item_id}/creatives/{creative_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateLineItemCreativeAssociationsResponse BatchActivateLineItemCreativeAssociations(LineItemName parent, scg::IEnumerable<LineItemCreativeAssociationName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateLineItemCreativeAssociations(new BatchActivateLineItemCreativeAssociationsRequest
            {
                ParentAsLineItemName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LineItemCreativeAssociationNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Activate a list of `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItemCreativeAssociations` will be
        /// activated. This request supports using the "-" character as a wildcard for
        /// resources that span across multiple LineItem parents. Format:
        /// `networks/{network_code}/lineItems/{line_item_id}` Format:
        /// `networks/{network_code}/lineItems/-`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItemCreativeAssociation` objects to
        /// activate. A maximum of 1000 objects can be activated in a batch. Format:
        /// `networks/{network_code}/lineItems/{line_item_id}/creatives/{creative_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateLineItemCreativeAssociationsResponse> BatchActivateLineItemCreativeAssociationsAsync(LineItemName parent, scg::IEnumerable<LineItemCreativeAssociationName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateLineItemCreativeAssociationsAsync(new BatchActivateLineItemCreativeAssociationsRequest
            {
                ParentAsLineItemName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LineItemCreativeAssociationNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Activate a list of `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItemCreativeAssociations` will be
        /// activated. This request supports using the "-" character as a wildcard for
        /// resources that span across multiple LineItem parents. Format:
        /// `networks/{network_code}/lineItems/{line_item_id}` Format:
        /// `networks/{network_code}/lineItems/-`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItemCreativeAssociation` objects to
        /// activate. A maximum of 1000 objects can be activated in a batch. Format:
        /// `networks/{network_code}/lineItems/{line_item_id}/creatives/{creative_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateLineItemCreativeAssociationsResponse> BatchActivateLineItemCreativeAssociationsAsync(LineItemName parent, scg::IEnumerable<LineItemCreativeAssociationName> names, st::CancellationToken cancellationToken) =>
            BatchActivateLineItemCreativeAssociationsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deactivates a list of `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateLineItemCreativeAssociationsResponse BatchDeactivateLineItemCreativeAssociations(BatchDeactivateLineItemCreativeAssociationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deactivates a list of `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateLineItemCreativeAssociationsResponse> BatchDeactivateLineItemCreativeAssociationsAsync(BatchDeactivateLineItemCreativeAssociationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deactivates a list of `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateLineItemCreativeAssociationsResponse> BatchDeactivateLineItemCreativeAssociationsAsync(BatchDeactivateLineItemCreativeAssociationsRequest request, st::CancellationToken cancellationToken) =>
            BatchDeactivateLineItemCreativeAssociationsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deactivates a list of `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItemCreativeAssociations` will be
        /// deactivated.
        /// This request supports using the "-" character as a wildcard for resources
        /// that span across multiple LineItem parents.
        /// Format: `networks/{network_code}/lineItems/{line_item_id}`
        /// Format: `networks/{network_code}/lineItems/-`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItemCreativeAssociation` objects to
        /// deactivate. A maximum of 1000 objects can be deactivated in a batch.
        /// Format:
        /// `networks/{network_code}/lineItems/{line_item_id}/creatives/{creative_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateLineItemCreativeAssociationsResponse BatchDeactivateLineItemCreativeAssociations(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateLineItemCreativeAssociations(new BatchDeactivateLineItemCreativeAssociationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItemCreativeAssociations` will be
        /// deactivated.
        /// This request supports using the "-" character as a wildcard for resources
        /// that span across multiple LineItem parents.
        /// Format: `networks/{network_code}/lineItems/{line_item_id}`
        /// Format: `networks/{network_code}/lineItems/-`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItemCreativeAssociation` objects to
        /// deactivate. A maximum of 1000 objects can be deactivated in a batch.
        /// Format:
        /// `networks/{network_code}/lineItems/{line_item_id}/creatives/{creative_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateLineItemCreativeAssociationsResponse> BatchDeactivateLineItemCreativeAssociationsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateLineItemCreativeAssociationsAsync(new BatchDeactivateLineItemCreativeAssociationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItemCreativeAssociations` will be
        /// deactivated.
        /// This request supports using the "-" character as a wildcard for resources
        /// that span across multiple LineItem parents.
        /// Format: `networks/{network_code}/lineItems/{line_item_id}`
        /// Format: `networks/{network_code}/lineItems/-`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItemCreativeAssociation` objects to
        /// deactivate. A maximum of 1000 objects can be deactivated in a batch.
        /// Format:
        /// `networks/{network_code}/lineItems/{line_item_id}/creatives/{creative_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateLineItemCreativeAssociationsResponse> BatchDeactivateLineItemCreativeAssociationsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchDeactivateLineItemCreativeAssociationsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deactivates a list of `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItemCreativeAssociations` will be
        /// deactivated.
        /// This request supports using the "-" character as a wildcard for resources
        /// that span across multiple LineItem parents.
        /// Format: `networks/{network_code}/lineItems/{line_item_id}`
        /// Format: `networks/{network_code}/lineItems/-`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItemCreativeAssociation` objects to
        /// deactivate. A maximum of 1000 objects can be deactivated in a batch.
        /// Format:
        /// `networks/{network_code}/lineItems/{line_item_id}/creatives/{creative_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateLineItemCreativeAssociationsResponse BatchDeactivateLineItemCreativeAssociations(LineItemName parent, scg::IEnumerable<LineItemCreativeAssociationName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateLineItemCreativeAssociations(new BatchDeactivateLineItemCreativeAssociationsRequest
            {
                ParentAsLineItemName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LineItemCreativeAssociationNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItemCreativeAssociations` will be
        /// deactivated.
        /// This request supports using the "-" character as a wildcard for resources
        /// that span across multiple LineItem parents.
        /// Format: `networks/{network_code}/lineItems/{line_item_id}`
        /// Format: `networks/{network_code}/lineItems/-`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItemCreativeAssociation` objects to
        /// deactivate. A maximum of 1000 objects can be deactivated in a batch.
        /// Format:
        /// `networks/{network_code}/lineItems/{line_item_id}/creatives/{creative_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateLineItemCreativeAssociationsResponse> BatchDeactivateLineItemCreativeAssociationsAsync(LineItemName parent, scg::IEnumerable<LineItemCreativeAssociationName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateLineItemCreativeAssociationsAsync(new BatchDeactivateLineItemCreativeAssociationsRequest
            {
                ParentAsLineItemName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LineItemCreativeAssociationNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItemCreativeAssociations` will be
        /// deactivated.
        /// This request supports using the "-" character as a wildcard for resources
        /// that span across multiple LineItem parents.
        /// Format: `networks/{network_code}/lineItems/{line_item_id}`
        /// Format: `networks/{network_code}/lineItems/-`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItemCreativeAssociation` objects to
        /// deactivate. A maximum of 1000 objects can be deactivated in a batch.
        /// Format:
        /// `networks/{network_code}/lineItems/{line_item_id}/creatives/{creative_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateLineItemCreativeAssociationsResponse> BatchDeactivateLineItemCreativeAssociationsAsync(LineItemName parent, scg::IEnumerable<LineItemCreativeAssociationName> names, st::CancellationToken cancellationToken) =>
            BatchDeactivateLineItemCreativeAssociationsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a list of `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void BatchDeleteLineItemCreativeAssociations(BatchDeleteLineItemCreativeAssociationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a list of `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteLineItemCreativeAssociationsAsync(BatchDeleteLineItemCreativeAssociationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a list of `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteLineItemCreativeAssociationsAsync(BatchDeleteLineItemCreativeAssociationsRequest request, st::CancellationToken cancellationToken) =>
            BatchDeleteLineItemCreativeAssociationsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a list of `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItemCreativeAssociations` will be
        /// deleted. This request supports using the "-" character as a wildcard for
        /// resources that span across multiple LineItem parents. Format:
        /// `networks/{network_code}/lineItems/{line_item_id}` Format:
        /// `networks/{network_code}/lineItems/-`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItemCreativeAssociation` objects to delete.
        /// A maximum of 1000 objects can be deleted in a batch.
        /// Format:
        /// `networks/{network_code}/lineItems/{line_item_id}/creatives/{creative_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void BatchDeleteLineItemCreativeAssociations(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteLineItemCreativeAssociations(new BatchDeleteLineItemCreativeAssociationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deletes a list of `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItemCreativeAssociations` will be
        /// deleted. This request supports using the "-" character as a wildcard for
        /// resources that span across multiple LineItem parents. Format:
        /// `networks/{network_code}/lineItems/{line_item_id}` Format:
        /// `networks/{network_code}/lineItems/-`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItemCreativeAssociation` objects to delete.
        /// A maximum of 1000 objects can be deleted in a batch.
        /// Format:
        /// `networks/{network_code}/lineItems/{line_item_id}/creatives/{creative_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteLineItemCreativeAssociationsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteLineItemCreativeAssociationsAsync(new BatchDeleteLineItemCreativeAssociationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deletes a list of `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItemCreativeAssociations` will be
        /// deleted. This request supports using the "-" character as a wildcard for
        /// resources that span across multiple LineItem parents. Format:
        /// `networks/{network_code}/lineItems/{line_item_id}` Format:
        /// `networks/{network_code}/lineItems/-`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItemCreativeAssociation` objects to delete.
        /// A maximum of 1000 objects can be deleted in a batch.
        /// Format:
        /// `networks/{network_code}/lineItems/{line_item_id}/creatives/{creative_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteLineItemCreativeAssociationsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchDeleteLineItemCreativeAssociationsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a list of `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItemCreativeAssociations` will be
        /// deleted. This request supports using the "-" character as a wildcard for
        /// resources that span across multiple LineItem parents. Format:
        /// `networks/{network_code}/lineItems/{line_item_id}` Format:
        /// `networks/{network_code}/lineItems/-`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItemCreativeAssociation` objects to delete.
        /// A maximum of 1000 objects can be deleted in a batch.
        /// Format:
        /// `networks/{network_code}/lineItems/{line_item_id}/creatives/{creative_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void BatchDeleteLineItemCreativeAssociations(LineItemName parent, scg::IEnumerable<LineItemCreativeAssociationName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteLineItemCreativeAssociations(new BatchDeleteLineItemCreativeAssociationsRequest
            {
                ParentAsLineItemName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LineItemCreativeAssociationNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deletes a list of `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItemCreativeAssociations` will be
        /// deleted. This request supports using the "-" character as a wildcard for
        /// resources that span across multiple LineItem parents. Format:
        /// `networks/{network_code}/lineItems/{line_item_id}` Format:
        /// `networks/{network_code}/lineItems/-`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItemCreativeAssociation` objects to delete.
        /// A maximum of 1000 objects can be deleted in a batch.
        /// Format:
        /// `networks/{network_code}/lineItems/{line_item_id}/creatives/{creative_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteLineItemCreativeAssociationsAsync(LineItemName parent, scg::IEnumerable<LineItemCreativeAssociationName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteLineItemCreativeAssociationsAsync(new BatchDeleteLineItemCreativeAssociationsRequest
            {
                ParentAsLineItemName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LineItemCreativeAssociationNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deletes a list of `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LineItemCreativeAssociations` will be
        /// deleted. This request supports using the "-" character as a wildcard for
        /// resources that span across multiple LineItem parents. Format:
        /// `networks/{network_code}/lineItems/{line_item_id}` Format:
        /// `networks/{network_code}/lineItems/-`
        /// </param>
        /// <param name="names">
        /// Required. The names of the `LineItemCreativeAssociation` objects to delete.
        /// A maximum of 1000 objects can be deleted in a batch.
        /// Format:
        /// `networks/{network_code}/lineItems/{line_item_id}/creatives/{creative_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteLineItemCreativeAssociationsAsync(LineItemName parent, scg::IEnumerable<LineItemCreativeAssociationName> names, st::CancellationToken cancellationToken) =>
            BatchDeleteLineItemCreativeAssociationsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetch previews for the
        /// [LineItemCreativeAssociation][google.ads.admanager.v1.LineItemCreativeAssociation].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PreviewLineItemCreativeAssociationResponse PreviewLineItemCreativeAssociation(PreviewLineItemCreativeAssociationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetch previews for the
        /// [LineItemCreativeAssociation][google.ads.admanager.v1.LineItemCreativeAssociation].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PreviewLineItemCreativeAssociationResponse> PreviewLineItemCreativeAssociationAsync(PreviewLineItemCreativeAssociationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetch previews for the
        /// [LineItemCreativeAssociation][google.ads.admanager.v1.LineItemCreativeAssociation].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PreviewLineItemCreativeAssociationResponse> PreviewLineItemCreativeAssociationAsync(PreviewLineItemCreativeAssociationRequest request, st::CancellationToken cancellationToken) =>
            PreviewLineItemCreativeAssociationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetch previews for the
        /// [LineItemCreativeAssociation][google.ads.admanager.v1.LineItemCreativeAssociation].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `LineItemCreativeAssociation` object to preview.
        /// Format:
        /// `networks/{network_code}/lineItems/{line_item_id}/creatives/{creative_id}`
        /// </param>
        /// <param name="siteUrl">
        /// Required. The URL of the site that the creative should be previewed in
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PreviewLineItemCreativeAssociationResponse PreviewLineItemCreativeAssociation(string name, string siteUrl, gaxgrpc::CallSettings callSettings = null) =>
            PreviewLineItemCreativeAssociation(new PreviewLineItemCreativeAssociationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                SiteUrl = gax::GaxPreconditions.CheckNotNullOrEmpty(siteUrl, nameof(siteUrl)),
            }, callSettings);

        /// <summary>
        /// Fetch previews for the
        /// [LineItemCreativeAssociation][google.ads.admanager.v1.LineItemCreativeAssociation].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `LineItemCreativeAssociation` object to preview.
        /// Format:
        /// `networks/{network_code}/lineItems/{line_item_id}/creatives/{creative_id}`
        /// </param>
        /// <param name="siteUrl">
        /// Required. The URL of the site that the creative should be previewed in
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PreviewLineItemCreativeAssociationResponse> PreviewLineItemCreativeAssociationAsync(string name, string siteUrl, gaxgrpc::CallSettings callSettings = null) =>
            PreviewLineItemCreativeAssociationAsync(new PreviewLineItemCreativeAssociationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                SiteUrl = gax::GaxPreconditions.CheckNotNullOrEmpty(siteUrl, nameof(siteUrl)),
            }, callSettings);

        /// <summary>
        /// Fetch previews for the
        /// [LineItemCreativeAssociation][google.ads.admanager.v1.LineItemCreativeAssociation].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `LineItemCreativeAssociation` object to preview.
        /// Format:
        /// `networks/{network_code}/lineItems/{line_item_id}/creatives/{creative_id}`
        /// </param>
        /// <param name="siteUrl">
        /// Required. The URL of the site that the creative should be previewed in
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PreviewLineItemCreativeAssociationResponse> PreviewLineItemCreativeAssociationAsync(string name, string siteUrl, st::CancellationToken cancellationToken) =>
            PreviewLineItemCreativeAssociationAsync(name, siteUrl, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetch previews for the
        /// [LineItemCreativeAssociation][google.ads.admanager.v1.LineItemCreativeAssociation].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `LineItemCreativeAssociation` object to preview.
        /// Format:
        /// `networks/{network_code}/lineItems/{line_item_id}/creatives/{creative_id}`
        /// </param>
        /// <param name="siteUrl">
        /// Required. The URL of the site that the creative should be previewed in
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PreviewLineItemCreativeAssociationResponse PreviewLineItemCreativeAssociation(LineItemCreativeAssociationName name, string siteUrl, gaxgrpc::CallSettings callSettings = null) =>
            PreviewLineItemCreativeAssociation(new PreviewLineItemCreativeAssociationRequest
            {
                LineItemCreativeAssociationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                SiteUrl = gax::GaxPreconditions.CheckNotNullOrEmpty(siteUrl, nameof(siteUrl)),
            }, callSettings);

        /// <summary>
        /// Fetch previews for the
        /// [LineItemCreativeAssociation][google.ads.admanager.v1.LineItemCreativeAssociation].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `LineItemCreativeAssociation` object to preview.
        /// Format:
        /// `networks/{network_code}/lineItems/{line_item_id}/creatives/{creative_id}`
        /// </param>
        /// <param name="siteUrl">
        /// Required. The URL of the site that the creative should be previewed in
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PreviewLineItemCreativeAssociationResponse> PreviewLineItemCreativeAssociationAsync(LineItemCreativeAssociationName name, string siteUrl, gaxgrpc::CallSettings callSettings = null) =>
            PreviewLineItemCreativeAssociationAsync(new PreviewLineItemCreativeAssociationRequest
            {
                LineItemCreativeAssociationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                SiteUrl = gax::GaxPreconditions.CheckNotNullOrEmpty(siteUrl, nameof(siteUrl)),
            }, callSettings);

        /// <summary>
        /// Fetch previews for the
        /// [LineItemCreativeAssociation][google.ads.admanager.v1.LineItemCreativeAssociation].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `LineItemCreativeAssociation` object to preview.
        /// Format:
        /// `networks/{network_code}/lineItems/{line_item_id}/creatives/{creative_id}`
        /// </param>
        /// <param name="siteUrl">
        /// Required. The URL of the site that the creative should be previewed in
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PreviewLineItemCreativeAssociationResponse> PreviewLineItemCreativeAssociationAsync(LineItemCreativeAssociationName name, string siteUrl, st::CancellationToken cancellationToken) =>
            PreviewLineItemCreativeAssociationAsync(name, siteUrl, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>LineItemCreativeAssociationService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `LineItemCreativeAssociation` objects.
    /// </remarks>
    public sealed partial class LineItemCreativeAssociationServiceClientImpl : LineItemCreativeAssociationServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetLineItemCreativeAssociationRequest, LineItemCreativeAssociation> _callGetLineItemCreativeAssociation;

        private readonly gaxgrpc::ApiCall<ListLineItemCreativeAssociationsRequest, ListLineItemCreativeAssociationsResponse> _callListLineItemCreativeAssociations;

        private readonly gaxgrpc::ApiCall<CreateLineItemCreativeAssociationRequest, LineItemCreativeAssociation> _callCreateLineItemCreativeAssociation;

        private readonly gaxgrpc::ApiCall<BatchCreateLineItemCreativeAssociationsRequest, BatchCreateLineItemCreativeAssociationsResponse> _callBatchCreateLineItemCreativeAssociations;

        private readonly gaxgrpc::ApiCall<UpdateLineItemCreativeAssociationRequest, LineItemCreativeAssociation> _callUpdateLineItemCreativeAssociation;

        private readonly gaxgrpc::ApiCall<BatchUpdateLineItemCreativeAssociationsRequest, BatchUpdateLineItemCreativeAssociationsResponse> _callBatchUpdateLineItemCreativeAssociations;

        private readonly gaxgrpc::ApiCall<BatchActivateLineItemCreativeAssociationsRequest, BatchActivateLineItemCreativeAssociationsResponse> _callBatchActivateLineItemCreativeAssociations;

        private readonly gaxgrpc::ApiCall<BatchDeactivateLineItemCreativeAssociationsRequest, BatchDeactivateLineItemCreativeAssociationsResponse> _callBatchDeactivateLineItemCreativeAssociations;

        private readonly gaxgrpc::ApiCall<BatchDeleteLineItemCreativeAssociationsRequest, wkt::Empty> _callBatchDeleteLineItemCreativeAssociations;

        private readonly gaxgrpc::ApiCall<PreviewLineItemCreativeAssociationRequest, PreviewLineItemCreativeAssociationResponse> _callPreviewLineItemCreativeAssociation;

        /// <summary>
        /// Constructs a client wrapper for the LineItemCreativeAssociationService service, with the specified gRPC
        /// client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="LineItemCreativeAssociationServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public LineItemCreativeAssociationServiceClientImpl(LineItemCreativeAssociationService.LineItemCreativeAssociationServiceClient grpcClient, LineItemCreativeAssociationServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            LineItemCreativeAssociationServiceSettings effectiveSettings = settings ?? LineItemCreativeAssociationServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetLineItemCreativeAssociation = clientHelper.BuildApiCall<GetLineItemCreativeAssociationRequest, LineItemCreativeAssociation>("GetLineItemCreativeAssociation", grpcClient.GetLineItemCreativeAssociationAsync, grpcClient.GetLineItemCreativeAssociation, effectiveSettings.GetLineItemCreativeAssociationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetLineItemCreativeAssociation);
            Modify_GetLineItemCreativeAssociationApiCall(ref _callGetLineItemCreativeAssociation);
            _callListLineItemCreativeAssociations = clientHelper.BuildApiCall<ListLineItemCreativeAssociationsRequest, ListLineItemCreativeAssociationsResponse>("ListLineItemCreativeAssociations", grpcClient.ListLineItemCreativeAssociationsAsync, grpcClient.ListLineItemCreativeAssociations, effectiveSettings.ListLineItemCreativeAssociationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListLineItemCreativeAssociations);
            Modify_ListLineItemCreativeAssociationsApiCall(ref _callListLineItemCreativeAssociations);
            _callCreateLineItemCreativeAssociation = clientHelper.BuildApiCall<CreateLineItemCreativeAssociationRequest, LineItemCreativeAssociation>("CreateLineItemCreativeAssociation", grpcClient.CreateLineItemCreativeAssociationAsync, grpcClient.CreateLineItemCreativeAssociation, effectiveSettings.CreateLineItemCreativeAssociationSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateLineItemCreativeAssociation);
            Modify_CreateLineItemCreativeAssociationApiCall(ref _callCreateLineItemCreativeAssociation);
            _callBatchCreateLineItemCreativeAssociations = clientHelper.BuildApiCall<BatchCreateLineItemCreativeAssociationsRequest, BatchCreateLineItemCreativeAssociationsResponse>("BatchCreateLineItemCreativeAssociations", grpcClient.BatchCreateLineItemCreativeAssociationsAsync, grpcClient.BatchCreateLineItemCreativeAssociations, effectiveSettings.BatchCreateLineItemCreativeAssociationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCreateLineItemCreativeAssociations);
            Modify_BatchCreateLineItemCreativeAssociationsApiCall(ref _callBatchCreateLineItemCreativeAssociations);
            _callUpdateLineItemCreativeAssociation = clientHelper.BuildApiCall<UpdateLineItemCreativeAssociationRequest, LineItemCreativeAssociation>("UpdateLineItemCreativeAssociation", grpcClient.UpdateLineItemCreativeAssociationAsync, grpcClient.UpdateLineItemCreativeAssociation, effectiveSettings.UpdateLineItemCreativeAssociationSettings).WithGoogleRequestParam("line_item_creative_association.name", request => request.LineItemCreativeAssociation?.Name);
            Modify_ApiCall(ref _callUpdateLineItemCreativeAssociation);
            Modify_UpdateLineItemCreativeAssociationApiCall(ref _callUpdateLineItemCreativeAssociation);
            _callBatchUpdateLineItemCreativeAssociations = clientHelper.BuildApiCall<BatchUpdateLineItemCreativeAssociationsRequest, BatchUpdateLineItemCreativeAssociationsResponse>("BatchUpdateLineItemCreativeAssociations", grpcClient.BatchUpdateLineItemCreativeAssociationsAsync, grpcClient.BatchUpdateLineItemCreativeAssociations, effectiveSettings.BatchUpdateLineItemCreativeAssociationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchUpdateLineItemCreativeAssociations);
            Modify_BatchUpdateLineItemCreativeAssociationsApiCall(ref _callBatchUpdateLineItemCreativeAssociations);
            _callBatchActivateLineItemCreativeAssociations = clientHelper.BuildApiCall<BatchActivateLineItemCreativeAssociationsRequest, BatchActivateLineItemCreativeAssociationsResponse>("BatchActivateLineItemCreativeAssociations", grpcClient.BatchActivateLineItemCreativeAssociationsAsync, grpcClient.BatchActivateLineItemCreativeAssociations, effectiveSettings.BatchActivateLineItemCreativeAssociationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchActivateLineItemCreativeAssociations);
            Modify_BatchActivateLineItemCreativeAssociationsApiCall(ref _callBatchActivateLineItemCreativeAssociations);
            _callBatchDeactivateLineItemCreativeAssociations = clientHelper.BuildApiCall<BatchDeactivateLineItemCreativeAssociationsRequest, BatchDeactivateLineItemCreativeAssociationsResponse>("BatchDeactivateLineItemCreativeAssociations", grpcClient.BatchDeactivateLineItemCreativeAssociationsAsync, grpcClient.BatchDeactivateLineItemCreativeAssociations, effectiveSettings.BatchDeactivateLineItemCreativeAssociationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchDeactivateLineItemCreativeAssociations);
            Modify_BatchDeactivateLineItemCreativeAssociationsApiCall(ref _callBatchDeactivateLineItemCreativeAssociations);
            _callBatchDeleteLineItemCreativeAssociations = clientHelper.BuildApiCall<BatchDeleteLineItemCreativeAssociationsRequest, wkt::Empty>("BatchDeleteLineItemCreativeAssociations", grpcClient.BatchDeleteLineItemCreativeAssociationsAsync, grpcClient.BatchDeleteLineItemCreativeAssociations, effectiveSettings.BatchDeleteLineItemCreativeAssociationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchDeleteLineItemCreativeAssociations);
            Modify_BatchDeleteLineItemCreativeAssociationsApiCall(ref _callBatchDeleteLineItemCreativeAssociations);
            _callPreviewLineItemCreativeAssociation = clientHelper.BuildApiCall<PreviewLineItemCreativeAssociationRequest, PreviewLineItemCreativeAssociationResponse>("PreviewLineItemCreativeAssociation", grpcClient.PreviewLineItemCreativeAssociationAsync, grpcClient.PreviewLineItemCreativeAssociation, effectiveSettings.PreviewLineItemCreativeAssociationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callPreviewLineItemCreativeAssociation);
            Modify_PreviewLineItemCreativeAssociationApiCall(ref _callPreviewLineItemCreativeAssociation);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetLineItemCreativeAssociationApiCall(ref gaxgrpc::ApiCall<GetLineItemCreativeAssociationRequest, LineItemCreativeAssociation> call);

        partial void Modify_ListLineItemCreativeAssociationsApiCall(ref gaxgrpc::ApiCall<ListLineItemCreativeAssociationsRequest, ListLineItemCreativeAssociationsResponse> call);

        partial void Modify_CreateLineItemCreativeAssociationApiCall(ref gaxgrpc::ApiCall<CreateLineItemCreativeAssociationRequest, LineItemCreativeAssociation> call);

        partial void Modify_BatchCreateLineItemCreativeAssociationsApiCall(ref gaxgrpc::ApiCall<BatchCreateLineItemCreativeAssociationsRequest, BatchCreateLineItemCreativeAssociationsResponse> call);

        partial void Modify_UpdateLineItemCreativeAssociationApiCall(ref gaxgrpc::ApiCall<UpdateLineItemCreativeAssociationRequest, LineItemCreativeAssociation> call);

        partial void Modify_BatchUpdateLineItemCreativeAssociationsApiCall(ref gaxgrpc::ApiCall<BatchUpdateLineItemCreativeAssociationsRequest, BatchUpdateLineItemCreativeAssociationsResponse> call);

        partial void Modify_BatchActivateLineItemCreativeAssociationsApiCall(ref gaxgrpc::ApiCall<BatchActivateLineItemCreativeAssociationsRequest, BatchActivateLineItemCreativeAssociationsResponse> call);

        partial void Modify_BatchDeactivateLineItemCreativeAssociationsApiCall(ref gaxgrpc::ApiCall<BatchDeactivateLineItemCreativeAssociationsRequest, BatchDeactivateLineItemCreativeAssociationsResponse> call);

        partial void Modify_BatchDeleteLineItemCreativeAssociationsApiCall(ref gaxgrpc::ApiCall<BatchDeleteLineItemCreativeAssociationsRequest, wkt::Empty> call);

        partial void Modify_PreviewLineItemCreativeAssociationApiCall(ref gaxgrpc::ApiCall<PreviewLineItemCreativeAssociationRequest, PreviewLineItemCreativeAssociationResponse> call);

        partial void OnConstruction(LineItemCreativeAssociationService.LineItemCreativeAssociationServiceClient grpcClient, LineItemCreativeAssociationServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC LineItemCreativeAssociationService client</summary>
        public override LineItemCreativeAssociationService.LineItemCreativeAssociationServiceClient GrpcClient { get; }

        partial void Modify_GetLineItemCreativeAssociationRequest(ref GetLineItemCreativeAssociationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListLineItemCreativeAssociationsRequest(ref ListLineItemCreativeAssociationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateLineItemCreativeAssociationRequest(ref CreateLineItemCreativeAssociationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateLineItemCreativeAssociationsRequest(ref BatchCreateLineItemCreativeAssociationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateLineItemCreativeAssociationRequest(ref UpdateLineItemCreativeAssociationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUpdateLineItemCreativeAssociationsRequest(ref BatchUpdateLineItemCreativeAssociationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchActivateLineItemCreativeAssociationsRequest(ref BatchActivateLineItemCreativeAssociationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchDeactivateLineItemCreativeAssociationsRequest(ref BatchDeactivateLineItemCreativeAssociationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchDeleteLineItemCreativeAssociationsRequest(ref BatchDeleteLineItemCreativeAssociationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PreviewLineItemCreativeAssociationRequest(ref PreviewLineItemCreativeAssociationRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves a `LineItemCreativeAssociation` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LineItemCreativeAssociation GetLineItemCreativeAssociation(GetLineItemCreativeAssociationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLineItemCreativeAssociationRequest(ref request, ref callSettings);
            return _callGetLineItemCreativeAssociation.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a `LineItemCreativeAssociation` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LineItemCreativeAssociation> GetLineItemCreativeAssociationAsync(GetLineItemCreativeAssociationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLineItemCreativeAssociationRequest(ref request, ref callSettings);
            return _callGetLineItemCreativeAssociation.Async(request, callSettings);
        }

        /// <summary>
        /// Lists `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LineItemCreativeAssociation"/> resources.</returns>
        public override gax::PagedEnumerable<ListLineItemCreativeAssociationsResponse, LineItemCreativeAssociation> ListLineItemCreativeAssociations(ListLineItemCreativeAssociationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLineItemCreativeAssociationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListLineItemCreativeAssociationsRequest, ListLineItemCreativeAssociationsResponse, LineItemCreativeAssociation>(_callListLineItemCreativeAssociations, request, callSettings);
        }

        /// <summary>
        /// Lists `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LineItemCreativeAssociation"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListLineItemCreativeAssociationsResponse, LineItemCreativeAssociation> ListLineItemCreativeAssociationsAsync(ListLineItemCreativeAssociationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLineItemCreativeAssociationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListLineItemCreativeAssociationsRequest, ListLineItemCreativeAssociationsResponse, LineItemCreativeAssociation>(_callListLineItemCreativeAssociations, request, callSettings);
        }

        /// <summary>
        /// Creates a `LineItemCreativeAssociation` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LineItemCreativeAssociation CreateLineItemCreativeAssociation(CreateLineItemCreativeAssociationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateLineItemCreativeAssociationRequest(ref request, ref callSettings);
            return _callCreateLineItemCreativeAssociation.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a `LineItemCreativeAssociation` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LineItemCreativeAssociation> CreateLineItemCreativeAssociationAsync(CreateLineItemCreativeAssociationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateLineItemCreativeAssociationRequest(ref request, ref callSettings);
            return _callCreateLineItemCreativeAssociation.Async(request, callSettings);
        }

        /// <summary>
        /// Creates `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchCreateLineItemCreativeAssociationsResponse BatchCreateLineItemCreativeAssociations(BatchCreateLineItemCreativeAssociationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateLineItemCreativeAssociationsRequest(ref request, ref callSettings);
            return _callBatchCreateLineItemCreativeAssociations.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchCreateLineItemCreativeAssociationsResponse> BatchCreateLineItemCreativeAssociationsAsync(BatchCreateLineItemCreativeAssociationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateLineItemCreativeAssociationsRequest(ref request, ref callSettings);
            return _callBatchCreateLineItemCreativeAssociations.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a `LineItemCreativeAssociation` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LineItemCreativeAssociation UpdateLineItemCreativeAssociation(UpdateLineItemCreativeAssociationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateLineItemCreativeAssociationRequest(ref request, ref callSettings);
            return _callUpdateLineItemCreativeAssociation.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a `LineItemCreativeAssociation` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LineItemCreativeAssociation> UpdateLineItemCreativeAssociationAsync(UpdateLineItemCreativeAssociationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateLineItemCreativeAssociationRequest(ref request, ref callSettings);
            return _callUpdateLineItemCreativeAssociation.Async(request, callSettings);
        }

        /// <summary>
        /// Batch updates `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchUpdateLineItemCreativeAssociationsResponse BatchUpdateLineItemCreativeAssociations(BatchUpdateLineItemCreativeAssociationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateLineItemCreativeAssociationsRequest(ref request, ref callSettings);
            return _callBatchUpdateLineItemCreativeAssociations.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch updates `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchUpdateLineItemCreativeAssociationsResponse> BatchUpdateLineItemCreativeAssociationsAsync(BatchUpdateLineItemCreativeAssociationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateLineItemCreativeAssociationsRequest(ref request, ref callSettings);
            return _callBatchUpdateLineItemCreativeAssociations.Async(request, callSettings);
        }

        /// <summary>
        /// Activate a list of `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchActivateLineItemCreativeAssociationsResponse BatchActivateLineItemCreativeAssociations(BatchActivateLineItemCreativeAssociationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchActivateLineItemCreativeAssociationsRequest(ref request, ref callSettings);
            return _callBatchActivateLineItemCreativeAssociations.Sync(request, callSettings);
        }

        /// <summary>
        /// Activate a list of `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchActivateLineItemCreativeAssociationsResponse> BatchActivateLineItemCreativeAssociationsAsync(BatchActivateLineItemCreativeAssociationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchActivateLineItemCreativeAssociationsRequest(ref request, ref callSettings);
            return _callBatchActivateLineItemCreativeAssociations.Async(request, callSettings);
        }

        /// <summary>
        /// Deactivates a list of `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchDeactivateLineItemCreativeAssociationsResponse BatchDeactivateLineItemCreativeAssociations(BatchDeactivateLineItemCreativeAssociationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeactivateLineItemCreativeAssociationsRequest(ref request, ref callSettings);
            return _callBatchDeactivateLineItemCreativeAssociations.Sync(request, callSettings);
        }

        /// <summary>
        /// Deactivates a list of `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchDeactivateLineItemCreativeAssociationsResponse> BatchDeactivateLineItemCreativeAssociationsAsync(BatchDeactivateLineItemCreativeAssociationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeactivateLineItemCreativeAssociationsRequest(ref request, ref callSettings);
            return _callBatchDeactivateLineItemCreativeAssociations.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a list of `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void BatchDeleteLineItemCreativeAssociations(BatchDeleteLineItemCreativeAssociationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeleteLineItemCreativeAssociationsRequest(ref request, ref callSettings);
            _callBatchDeleteLineItemCreativeAssociations.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a list of `LineItemCreativeAssociation` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task BatchDeleteLineItemCreativeAssociationsAsync(BatchDeleteLineItemCreativeAssociationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeleteLineItemCreativeAssociationsRequest(ref request, ref callSettings);
            return _callBatchDeleteLineItemCreativeAssociations.Async(request, callSettings);
        }

        /// <summary>
        /// Fetch previews for the
        /// [LineItemCreativeAssociation][google.ads.admanager.v1.LineItemCreativeAssociation].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PreviewLineItemCreativeAssociationResponse PreviewLineItemCreativeAssociation(PreviewLineItemCreativeAssociationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PreviewLineItemCreativeAssociationRequest(ref request, ref callSettings);
            return _callPreviewLineItemCreativeAssociation.Sync(request, callSettings);
        }

        /// <summary>
        /// Fetch previews for the
        /// [LineItemCreativeAssociation][google.ads.admanager.v1.LineItemCreativeAssociation].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PreviewLineItemCreativeAssociationResponse> PreviewLineItemCreativeAssociationAsync(PreviewLineItemCreativeAssociationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PreviewLineItemCreativeAssociationRequest(ref request, ref callSettings);
            return _callPreviewLineItemCreativeAssociation.Async(request, callSettings);
        }
    }

    public partial class ListLineItemCreativeAssociationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListLineItemCreativeAssociationsResponse : gaxgrpc::IPageResponse<LineItemCreativeAssociation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<LineItemCreativeAssociation> GetEnumerator() =>
            LineItemCreativeAssociations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
