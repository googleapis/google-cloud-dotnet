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

namespace Google.Ads.AdManager.V1
{
    /// <summary>Settings for <see cref="AdBreakServiceClient"/> instances.</summary>
    public sealed partial class AdBreakServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AdBreakServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AdBreakServiceSettings"/>.</returns>
        public static AdBreakServiceSettings GetDefault() => new AdBreakServiceSettings();

        /// <summary>Constructs a new <see cref="AdBreakServiceSettings"/> object with default settings.</summary>
        public AdBreakServiceSettings()
        {
        }

        private AdBreakServiceSettings(AdBreakServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetAdBreakSettings = existing.GetAdBreakSettings;
            ListAdBreaksSettings = existing.ListAdBreaksSettings;
            CreateAdBreakSettings = existing.CreateAdBreakSettings;
            UpdateAdBreakSettings = existing.UpdateAdBreakSettings;
            DeleteAdBreakSettings = existing.DeleteAdBreakSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AdBreakServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdBreakServiceClient.GetAdBreak</c> and <c>AdBreakServiceClient.GetAdBreakAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAdBreakSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdBreakServiceClient.ListAdBreaks</c> and <c>AdBreakServiceClient.ListAdBreaksAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAdBreaksSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdBreakServiceClient.CreateAdBreak</c> and <c>AdBreakServiceClient.CreateAdBreakAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAdBreakSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdBreakServiceClient.UpdateAdBreak</c> and <c>AdBreakServiceClient.UpdateAdBreakAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAdBreakSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdBreakServiceClient.DeleteAdBreak</c> and <c>AdBreakServiceClient.DeleteAdBreakAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAdBreakSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AdBreakServiceSettings"/> object.</returns>
        public AdBreakServiceSettings Clone() => new AdBreakServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AdBreakServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class AdBreakServiceClientBuilder : gaxgrpc::ClientBuilderBase<AdBreakServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AdBreakServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AdBreakServiceClientBuilder() : base(AdBreakServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AdBreakServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AdBreakServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AdBreakServiceClient Build()
        {
            AdBreakServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AdBreakServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AdBreakServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AdBreakServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AdBreakServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AdBreakServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AdBreakServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AdBreakServiceClient.ChannelPool;
    }

    /// <summary>AdBreakService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `AdBreak` objects.
    /// </remarks>
    public abstract partial class AdBreakServiceClient
    {
        /// <summary>
        /// The default endpoint for the AdBreakService service, which is a host of "admanager.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default AdBreakService scopes.</summary>
        /// <remarks>
        /// The default AdBreakService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/admanager</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admanager",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AdBreakService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AdBreakServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AdBreakServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AdBreakServiceClient"/>.</returns>
        public static stt::Task<AdBreakServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AdBreakServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AdBreakServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AdBreakServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AdBreakServiceClient"/>.</returns>
        public static AdBreakServiceClient Create() => new AdBreakServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AdBreakServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AdBreakServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AdBreakServiceClient"/>.</returns>
        internal static AdBreakServiceClient Create(grpccore::CallInvoker callInvoker, AdBreakServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AdBreakService.AdBreakServiceClient grpcClient = new AdBreakService.AdBreakServiceClient(callInvoker);
            return new AdBreakServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AdBreakService client</summary>
        public virtual AdBreakService.AdBreakServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve an `AdBreak` object.
        /// 
        /// Query an ad break by its resource name or custom asset key. Check the
        /// resource's `breakState` field to determine its state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AdBreak GetAdBreak(GetAdBreakRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve an `AdBreak` object.
        /// 
        /// Query an ad break by its resource name or custom asset key. Check the
        /// resource's `breakState` field to determine its state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdBreak> GetAdBreakAsync(GetAdBreakRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve an `AdBreak` object.
        /// 
        /// Query an ad break by its resource name or custom asset key. Check the
        /// resource's `breakState` field to determine its state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdBreak> GetAdBreakAsync(GetAdBreakRequest request, st::CancellationToken cancellationToken) =>
            GetAdBreakAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve an `AdBreak` object.
        /// 
        /// Query an ad break by its resource name or custom asset key. Check the
        /// resource's `breakState` field to determine its state.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AdBreak using the asset key or custom
        /// asset key.
        /// 
        /// Format:
        /// `networks/{network_code}/liveStreamEventsByAssetKey/{asset_key}/adBreaks/{ad_break_id}`
        /// `networks/{network_code}/liveStreamEventsByCustomAssetKey/{custom_asset_key}/adBreaks/{ad_break_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AdBreak GetAdBreak(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAdBreak(new GetAdBreakRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve an `AdBreak` object.
        /// 
        /// Query an ad break by its resource name or custom asset key. Check the
        /// resource's `breakState` field to determine its state.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AdBreak using the asset key or custom
        /// asset key.
        /// 
        /// Format:
        /// `networks/{network_code}/liveStreamEventsByAssetKey/{asset_key}/adBreaks/{ad_break_id}`
        /// `networks/{network_code}/liveStreamEventsByCustomAssetKey/{custom_asset_key}/adBreaks/{ad_break_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdBreak> GetAdBreakAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAdBreakAsync(new GetAdBreakRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve an `AdBreak` object.
        /// 
        /// Query an ad break by its resource name or custom asset key. Check the
        /// resource's `breakState` field to determine its state.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AdBreak using the asset key or custom
        /// asset key.
        /// 
        /// Format:
        /// `networks/{network_code}/liveStreamEventsByAssetKey/{asset_key}/adBreaks/{ad_break_id}`
        /// `networks/{network_code}/liveStreamEventsByCustomAssetKey/{custom_asset_key}/adBreaks/{ad_break_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdBreak> GetAdBreakAsync(string name, st::CancellationToken cancellationToken) =>
            GetAdBreakAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve an `AdBreak` object.
        /// 
        /// Query an ad break by its resource name or custom asset key. Check the
        /// resource's `breakState` field to determine its state.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AdBreak using the asset key or custom
        /// asset key.
        /// 
        /// Format:
        /// `networks/{network_code}/liveStreamEventsByAssetKey/{asset_key}/adBreaks/{ad_break_id}`
        /// `networks/{network_code}/liveStreamEventsByCustomAssetKey/{custom_asset_key}/adBreaks/{ad_break_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AdBreak GetAdBreak(AdBreakName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAdBreak(new GetAdBreakRequest
            {
                AdBreakName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve an `AdBreak` object.
        /// 
        /// Query an ad break by its resource name or custom asset key. Check the
        /// resource's `breakState` field to determine its state.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AdBreak using the asset key or custom
        /// asset key.
        /// 
        /// Format:
        /// `networks/{network_code}/liveStreamEventsByAssetKey/{asset_key}/adBreaks/{ad_break_id}`
        /// `networks/{network_code}/liveStreamEventsByCustomAssetKey/{custom_asset_key}/adBreaks/{ad_break_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdBreak> GetAdBreakAsync(AdBreakName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAdBreakAsync(new GetAdBreakRequest
            {
                AdBreakName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve an `AdBreak` object.
        /// 
        /// Query an ad break by its resource name or custom asset key. Check the
        /// resource's `breakState` field to determine its state.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AdBreak using the asset key or custom
        /// asset key.
        /// 
        /// Format:
        /// `networks/{network_code}/liveStreamEventsByAssetKey/{asset_key}/adBreaks/{ad_break_id}`
        /// `networks/{network_code}/liveStreamEventsByCustomAssetKey/{custom_asset_key}/adBreaks/{ad_break_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdBreak> GetAdBreakAsync(AdBreakName name, st::CancellationToken cancellationToken) =>
            GetAdBreakAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a list of `AdBreak` objects.
        /// 
        /// By default, when no `orderBy` query parameter is specified, ad breaks are
        /// ordered reverse chronologically. However, ad breaks with a 'breakState' of
        /// 'SCHEDULED' or 'DECISIONED' are prioritized and appear first.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AdBreak"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAdBreaksResponse, AdBreak> ListAdBreaks(ListAdBreaksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `AdBreak` objects.
        /// 
        /// By default, when no `orderBy` query parameter is specified, ad breaks are
        /// ordered reverse chronologically. However, ad breaks with a 'breakState' of
        /// 'SCHEDULED' or 'DECISIONED' are prioritized and appear first.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AdBreak"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAdBreaksResponse, AdBreak> ListAdBreaksAsync(ListAdBreaksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `AdBreak` objects.
        /// 
        /// By default, when no `orderBy` query parameter is specified, ad breaks are
        /// ordered reverse chronologically. However, ad breaks with a 'breakState' of
        /// 'SCHEDULED' or 'DECISIONED' are prioritized and appear first.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of AdBreaks.
        /// 
        /// Formats:
        /// `networks/{network_code}/liveStreamEventsByAssetKey/{asset_key}`
        /// `networks/{network_code}/liveStreamEventsByCustomAssetKey/{custom_asset_key}`
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
        /// <returns>A pageable sequence of <see cref="AdBreak"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAdBreaksResponse, AdBreak> ListAdBreaks(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAdBreaksRequest request = new ListAdBreaksRequest
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
            return ListAdBreaks(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `AdBreak` objects.
        /// 
        /// By default, when no `orderBy` query parameter is specified, ad breaks are
        /// ordered reverse chronologically. However, ad breaks with a 'breakState' of
        /// 'SCHEDULED' or 'DECISIONED' are prioritized and appear first.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of AdBreaks.
        /// 
        /// Formats:
        /// `networks/{network_code}/liveStreamEventsByAssetKey/{asset_key}`
        /// `networks/{network_code}/liveStreamEventsByCustomAssetKey/{custom_asset_key}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="AdBreak"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAdBreaksResponse, AdBreak> ListAdBreaksAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAdBreaksRequest request = new ListAdBreaksRequest
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
            return ListAdBreaksAsync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `AdBreak` objects.
        /// 
        /// By default, when no `orderBy` query parameter is specified, ad breaks are
        /// ordered reverse chronologically. However, ad breaks with a 'breakState' of
        /// 'SCHEDULED' or 'DECISIONED' are prioritized and appear first.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of AdBreaks.
        /// 
        /// Formats:
        /// `networks/{network_code}/liveStreamEventsByAssetKey/{asset_key}`
        /// `networks/{network_code}/liveStreamEventsByCustomAssetKey/{custom_asset_key}`
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
        /// <returns>A pageable sequence of <see cref="AdBreak"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAdBreaksResponse, AdBreak> ListAdBreaks(LiveStreamEventName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAdBreaksRequest request = new ListAdBreaksRequest
            {
                ParentAsLiveStreamEventName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAdBreaks(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `AdBreak` objects.
        /// 
        /// By default, when no `orderBy` query parameter is specified, ad breaks are
        /// ordered reverse chronologically. However, ad breaks with a 'breakState' of
        /// 'SCHEDULED' or 'DECISIONED' are prioritized and appear first.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of AdBreaks.
        /// 
        /// Formats:
        /// `networks/{network_code}/liveStreamEventsByAssetKey/{asset_key}`
        /// `networks/{network_code}/liveStreamEventsByCustomAssetKey/{custom_asset_key}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="AdBreak"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAdBreaksResponse, AdBreak> ListAdBreaksAsync(LiveStreamEventName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAdBreaksRequest request = new ListAdBreaksRequest
            {
                ParentAsLiveStreamEventName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAdBreaksAsync(request, callSettings);
        }

        /// <summary>
        /// API to create an `AdBreak` object.
        /// 
        /// Informs DAI of an upcoming ad break for a live stream event, with an
        /// optional expected start time. DAI will begin decisioning ads for the break
        /// shortly before the expected start time, if provided. Each live stream
        /// event can only have one incomplete ad break at any given time. The next ad
        /// break can be scheduled after the previous ad break has started serving,
        /// indicated by its state being
        /// [`COMPLETE`][google.ads.admanager.v1.AdBreakStateEnum.AdBreakState.COMPLETE],
        /// or it has been deleted.
        /// 
        /// This method cannot be used if the `LiveStreamEvent` has
        /// [prefetching ad breaks
        /// enabled](https://developers.google.com/ad-manager/api/reference/latest/LiveStreamEventService.LiveStreamEvent#prefetchenabled)
        /// or the event is not active. If a `LiveStreamEvent` is deactivated after
        /// creating an ad break and before the ad break is complete, the ad break
        /// is discarded.
        /// 
        /// An ad break's state is complete when the following occurs:
        /// - Full service DAI: after a matching ad break shows in the
        /// `LiveStreamEvent` manifest only when the ad break has started decisioning.
        /// - Pod Serving: after the ad break is requested using the ad break ID or
        /// break sequence.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AdBreak CreateAdBreak(CreateAdBreakRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to create an `AdBreak` object.
        /// 
        /// Informs DAI of an upcoming ad break for a live stream event, with an
        /// optional expected start time. DAI will begin decisioning ads for the break
        /// shortly before the expected start time, if provided. Each live stream
        /// event can only have one incomplete ad break at any given time. The next ad
        /// break can be scheduled after the previous ad break has started serving,
        /// indicated by its state being
        /// [`COMPLETE`][google.ads.admanager.v1.AdBreakStateEnum.AdBreakState.COMPLETE],
        /// or it has been deleted.
        /// 
        /// This method cannot be used if the `LiveStreamEvent` has
        /// [prefetching ad breaks
        /// enabled](https://developers.google.com/ad-manager/api/reference/latest/LiveStreamEventService.LiveStreamEvent#prefetchenabled)
        /// or the event is not active. If a `LiveStreamEvent` is deactivated after
        /// creating an ad break and before the ad break is complete, the ad break
        /// is discarded.
        /// 
        /// An ad break's state is complete when the following occurs:
        /// - Full service DAI: after a matching ad break shows in the
        /// `LiveStreamEvent` manifest only when the ad break has started decisioning.
        /// - Pod Serving: after the ad break is requested using the ad break ID or
        /// break sequence.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdBreak> CreateAdBreakAsync(CreateAdBreakRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to create an `AdBreak` object.
        /// 
        /// Informs DAI of an upcoming ad break for a live stream event, with an
        /// optional expected start time. DAI will begin decisioning ads for the break
        /// shortly before the expected start time, if provided. Each live stream
        /// event can only have one incomplete ad break at any given time. The next ad
        /// break can be scheduled after the previous ad break has started serving,
        /// indicated by its state being
        /// [`COMPLETE`][google.ads.admanager.v1.AdBreakStateEnum.AdBreakState.COMPLETE],
        /// or it has been deleted.
        /// 
        /// This method cannot be used if the `LiveStreamEvent` has
        /// [prefetching ad breaks
        /// enabled](https://developers.google.com/ad-manager/api/reference/latest/LiveStreamEventService.LiveStreamEvent#prefetchenabled)
        /// or the event is not active. If a `LiveStreamEvent` is deactivated after
        /// creating an ad break and before the ad break is complete, the ad break
        /// is discarded.
        /// 
        /// An ad break's state is complete when the following occurs:
        /// - Full service DAI: after a matching ad break shows in the
        /// `LiveStreamEvent` manifest only when the ad break has started decisioning.
        /// - Pod Serving: after the ad break is requested using the ad break ID or
        /// break sequence.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdBreak> CreateAdBreakAsync(CreateAdBreakRequest request, st::CancellationToken cancellationToken) =>
            CreateAdBreakAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to create an `AdBreak` object.
        /// 
        /// Informs DAI of an upcoming ad break for a live stream event, with an
        /// optional expected start time. DAI will begin decisioning ads for the break
        /// shortly before the expected start time, if provided. Each live stream
        /// event can only have one incomplete ad break at any given time. The next ad
        /// break can be scheduled after the previous ad break has started serving,
        /// indicated by its state being
        /// [`COMPLETE`][google.ads.admanager.v1.AdBreakStateEnum.AdBreakState.COMPLETE],
        /// or it has been deleted.
        /// 
        /// This method cannot be used if the `LiveStreamEvent` has
        /// [prefetching ad breaks
        /// enabled](https://developers.google.com/ad-manager/api/reference/latest/LiveStreamEventService.LiveStreamEvent#prefetchenabled)
        /// or the event is not active. If a `LiveStreamEvent` is deactivated after
        /// creating an ad break and before the ad break is complete, the ad break
        /// is discarded.
        /// 
        /// An ad break's state is complete when the following occurs:
        /// - Full service DAI: after a matching ad break shows in the
        /// `LiveStreamEvent` manifest only when the ad break has started decisioning.
        /// - Pod Serving: after the ad break is requested using the ad break ID or
        /// break sequence.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `AdBreak` will be created
        /// identified by an asset key or custom asset key.
        /// 
        /// Formats:
        /// `networks/{network_code}/liveStreamEventsByAssetKey/{asset_key}`
        /// `networks/{network_code}/liveStreamEventsByCustomAssetKey/{custom_asset_key}`
        /// </param>
        /// <param name="adBreak">
        /// Required. The `AdBreak` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AdBreak CreateAdBreak(string parent, AdBreak adBreak, gaxgrpc::CallSettings callSettings = null) =>
            CreateAdBreak(new CreateAdBreakRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AdBreak = gax::GaxPreconditions.CheckNotNull(adBreak, nameof(adBreak)),
            }, callSettings);

        /// <summary>
        /// API to create an `AdBreak` object.
        /// 
        /// Informs DAI of an upcoming ad break for a live stream event, with an
        /// optional expected start time. DAI will begin decisioning ads for the break
        /// shortly before the expected start time, if provided. Each live stream
        /// event can only have one incomplete ad break at any given time. The next ad
        /// break can be scheduled after the previous ad break has started serving,
        /// indicated by its state being
        /// [`COMPLETE`][google.ads.admanager.v1.AdBreakStateEnum.AdBreakState.COMPLETE],
        /// or it has been deleted.
        /// 
        /// This method cannot be used if the `LiveStreamEvent` has
        /// [prefetching ad breaks
        /// enabled](https://developers.google.com/ad-manager/api/reference/latest/LiveStreamEventService.LiveStreamEvent#prefetchenabled)
        /// or the event is not active. If a `LiveStreamEvent` is deactivated after
        /// creating an ad break and before the ad break is complete, the ad break
        /// is discarded.
        /// 
        /// An ad break's state is complete when the following occurs:
        /// - Full service DAI: after a matching ad break shows in the
        /// `LiveStreamEvent` manifest only when the ad break has started decisioning.
        /// - Pod Serving: after the ad break is requested using the ad break ID or
        /// break sequence.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `AdBreak` will be created
        /// identified by an asset key or custom asset key.
        /// 
        /// Formats:
        /// `networks/{network_code}/liveStreamEventsByAssetKey/{asset_key}`
        /// `networks/{network_code}/liveStreamEventsByCustomAssetKey/{custom_asset_key}`
        /// </param>
        /// <param name="adBreak">
        /// Required. The `AdBreak` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdBreak> CreateAdBreakAsync(string parent, AdBreak adBreak, gaxgrpc::CallSettings callSettings = null) =>
            CreateAdBreakAsync(new CreateAdBreakRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AdBreak = gax::GaxPreconditions.CheckNotNull(adBreak, nameof(adBreak)),
            }, callSettings);

        /// <summary>
        /// API to create an `AdBreak` object.
        /// 
        /// Informs DAI of an upcoming ad break for a live stream event, with an
        /// optional expected start time. DAI will begin decisioning ads for the break
        /// shortly before the expected start time, if provided. Each live stream
        /// event can only have one incomplete ad break at any given time. The next ad
        /// break can be scheduled after the previous ad break has started serving,
        /// indicated by its state being
        /// [`COMPLETE`][google.ads.admanager.v1.AdBreakStateEnum.AdBreakState.COMPLETE],
        /// or it has been deleted.
        /// 
        /// This method cannot be used if the `LiveStreamEvent` has
        /// [prefetching ad breaks
        /// enabled](https://developers.google.com/ad-manager/api/reference/latest/LiveStreamEventService.LiveStreamEvent#prefetchenabled)
        /// or the event is not active. If a `LiveStreamEvent` is deactivated after
        /// creating an ad break and before the ad break is complete, the ad break
        /// is discarded.
        /// 
        /// An ad break's state is complete when the following occurs:
        /// - Full service DAI: after a matching ad break shows in the
        /// `LiveStreamEvent` manifest only when the ad break has started decisioning.
        /// - Pod Serving: after the ad break is requested using the ad break ID or
        /// break sequence.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `AdBreak` will be created
        /// identified by an asset key or custom asset key.
        /// 
        /// Formats:
        /// `networks/{network_code}/liveStreamEventsByAssetKey/{asset_key}`
        /// `networks/{network_code}/liveStreamEventsByCustomAssetKey/{custom_asset_key}`
        /// </param>
        /// <param name="adBreak">
        /// Required. The `AdBreak` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdBreak> CreateAdBreakAsync(string parent, AdBreak adBreak, st::CancellationToken cancellationToken) =>
            CreateAdBreakAsync(parent, adBreak, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to create an `AdBreak` object.
        /// 
        /// Informs DAI of an upcoming ad break for a live stream event, with an
        /// optional expected start time. DAI will begin decisioning ads for the break
        /// shortly before the expected start time, if provided. Each live stream
        /// event can only have one incomplete ad break at any given time. The next ad
        /// break can be scheduled after the previous ad break has started serving,
        /// indicated by its state being
        /// [`COMPLETE`][google.ads.admanager.v1.AdBreakStateEnum.AdBreakState.COMPLETE],
        /// or it has been deleted.
        /// 
        /// This method cannot be used if the `LiveStreamEvent` has
        /// [prefetching ad breaks
        /// enabled](https://developers.google.com/ad-manager/api/reference/latest/LiveStreamEventService.LiveStreamEvent#prefetchenabled)
        /// or the event is not active. If a `LiveStreamEvent` is deactivated after
        /// creating an ad break and before the ad break is complete, the ad break
        /// is discarded.
        /// 
        /// An ad break's state is complete when the following occurs:
        /// - Full service DAI: after a matching ad break shows in the
        /// `LiveStreamEvent` manifest only when the ad break has started decisioning.
        /// - Pod Serving: after the ad break is requested using the ad break ID or
        /// break sequence.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `AdBreak` will be created
        /// identified by an asset key or custom asset key.
        /// 
        /// Formats:
        /// `networks/{network_code}/liveStreamEventsByAssetKey/{asset_key}`
        /// `networks/{network_code}/liveStreamEventsByCustomAssetKey/{custom_asset_key}`
        /// </param>
        /// <param name="adBreak">
        /// Required. The `AdBreak` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AdBreak CreateAdBreak(LiveStreamEventName parent, AdBreak adBreak, gaxgrpc::CallSettings callSettings = null) =>
            CreateAdBreak(new CreateAdBreakRequest
            {
                ParentAsLiveStreamEventName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AdBreak = gax::GaxPreconditions.CheckNotNull(adBreak, nameof(adBreak)),
            }, callSettings);

        /// <summary>
        /// API to create an `AdBreak` object.
        /// 
        /// Informs DAI of an upcoming ad break for a live stream event, with an
        /// optional expected start time. DAI will begin decisioning ads for the break
        /// shortly before the expected start time, if provided. Each live stream
        /// event can only have one incomplete ad break at any given time. The next ad
        /// break can be scheduled after the previous ad break has started serving,
        /// indicated by its state being
        /// [`COMPLETE`][google.ads.admanager.v1.AdBreakStateEnum.AdBreakState.COMPLETE],
        /// or it has been deleted.
        /// 
        /// This method cannot be used if the `LiveStreamEvent` has
        /// [prefetching ad breaks
        /// enabled](https://developers.google.com/ad-manager/api/reference/latest/LiveStreamEventService.LiveStreamEvent#prefetchenabled)
        /// or the event is not active. If a `LiveStreamEvent` is deactivated after
        /// creating an ad break and before the ad break is complete, the ad break
        /// is discarded.
        /// 
        /// An ad break's state is complete when the following occurs:
        /// - Full service DAI: after a matching ad break shows in the
        /// `LiveStreamEvent` manifest only when the ad break has started decisioning.
        /// - Pod Serving: after the ad break is requested using the ad break ID or
        /// break sequence.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `AdBreak` will be created
        /// identified by an asset key or custom asset key.
        /// 
        /// Formats:
        /// `networks/{network_code}/liveStreamEventsByAssetKey/{asset_key}`
        /// `networks/{network_code}/liveStreamEventsByCustomAssetKey/{custom_asset_key}`
        /// </param>
        /// <param name="adBreak">
        /// Required. The `AdBreak` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdBreak> CreateAdBreakAsync(LiveStreamEventName parent, AdBreak adBreak, gaxgrpc::CallSettings callSettings = null) =>
            CreateAdBreakAsync(new CreateAdBreakRequest
            {
                ParentAsLiveStreamEventName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AdBreak = gax::GaxPreconditions.CheckNotNull(adBreak, nameof(adBreak)),
            }, callSettings);

        /// <summary>
        /// API to create an `AdBreak` object.
        /// 
        /// Informs DAI of an upcoming ad break for a live stream event, with an
        /// optional expected start time. DAI will begin decisioning ads for the break
        /// shortly before the expected start time, if provided. Each live stream
        /// event can only have one incomplete ad break at any given time. The next ad
        /// break can be scheduled after the previous ad break has started serving,
        /// indicated by its state being
        /// [`COMPLETE`][google.ads.admanager.v1.AdBreakStateEnum.AdBreakState.COMPLETE],
        /// or it has been deleted.
        /// 
        /// This method cannot be used if the `LiveStreamEvent` has
        /// [prefetching ad breaks
        /// enabled](https://developers.google.com/ad-manager/api/reference/latest/LiveStreamEventService.LiveStreamEvent#prefetchenabled)
        /// or the event is not active. If a `LiveStreamEvent` is deactivated after
        /// creating an ad break and before the ad break is complete, the ad break
        /// is discarded.
        /// 
        /// An ad break's state is complete when the following occurs:
        /// - Full service DAI: after a matching ad break shows in the
        /// `LiveStreamEvent` manifest only when the ad break has started decisioning.
        /// - Pod Serving: after the ad break is requested using the ad break ID or
        /// break sequence.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `AdBreak` will be created
        /// identified by an asset key or custom asset key.
        /// 
        /// Formats:
        /// `networks/{network_code}/liveStreamEventsByAssetKey/{asset_key}`
        /// `networks/{network_code}/liveStreamEventsByCustomAssetKey/{custom_asset_key}`
        /// </param>
        /// <param name="adBreak">
        /// Required. The `AdBreak` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdBreak> CreateAdBreakAsync(LiveStreamEventName parent, AdBreak adBreak, st::CancellationToken cancellationToken) =>
            CreateAdBreakAsync(parent, adBreak, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to update an `AdBreak` object.
        /// 
        /// Modify an ad break when its state is
        /// [`SCHEDULED`][google.ads.admanager.v1.AdBreakStateEnum.AdBreakState.SCHEDULED].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AdBreak UpdateAdBreak(UpdateAdBreakRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to update an `AdBreak` object.
        /// 
        /// Modify an ad break when its state is
        /// [`SCHEDULED`][google.ads.admanager.v1.AdBreakStateEnum.AdBreakState.SCHEDULED].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdBreak> UpdateAdBreakAsync(UpdateAdBreakRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to update an `AdBreak` object.
        /// 
        /// Modify an ad break when its state is
        /// [`SCHEDULED`][google.ads.admanager.v1.AdBreakStateEnum.AdBreakState.SCHEDULED].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdBreak> UpdateAdBreakAsync(UpdateAdBreakRequest request, st::CancellationToken cancellationToken) =>
            UpdateAdBreakAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to update an `AdBreak` object.
        /// 
        /// Modify an ad break when its state is
        /// [`SCHEDULED`][google.ads.admanager.v1.AdBreakStateEnum.AdBreakState.SCHEDULED].
        /// </summary>
        /// <param name="adBreak">
        /// Required. The `AdBreak` to update.
        /// 
        /// The `AdBreak`'s `name` is used to identify the `AdBreak` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AdBreak UpdateAdBreak(AdBreak adBreak, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAdBreak(new UpdateAdBreakRequest
            {
                AdBreak = gax::GaxPreconditions.CheckNotNull(adBreak, nameof(adBreak)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// API to update an `AdBreak` object.
        /// 
        /// Modify an ad break when its state is
        /// [`SCHEDULED`][google.ads.admanager.v1.AdBreakStateEnum.AdBreakState.SCHEDULED].
        /// </summary>
        /// <param name="adBreak">
        /// Required. The `AdBreak` to update.
        /// 
        /// The `AdBreak`'s `name` is used to identify the `AdBreak` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdBreak> UpdateAdBreakAsync(AdBreak adBreak, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAdBreakAsync(new UpdateAdBreakRequest
            {
                AdBreak = gax::GaxPreconditions.CheckNotNull(adBreak, nameof(adBreak)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// API to update an `AdBreak` object.
        /// 
        /// Modify an ad break when its state is
        /// [`SCHEDULED`][google.ads.admanager.v1.AdBreakStateEnum.AdBreakState.SCHEDULED].
        /// </summary>
        /// <param name="adBreak">
        /// Required. The `AdBreak` to update.
        /// 
        /// The `AdBreak`'s `name` is used to identify the `AdBreak` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdBreak> UpdateAdBreakAsync(AdBreak adBreak, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAdBreakAsync(adBreak, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to delete an `AdBreak` object.
        /// 
        /// Deletes and cancels an incomplete ad break, mitigating the need to wait
        /// for the current break to serve before recreating an ad break. You can
        /// delete an ad break that has not started serving or seen in manifests,
        /// indicated by its state being
        /// [`SCHEDULED`][google.ads.admanager.v1.AdBreakStateEnum.AdBreakState.SCHEDULED]
        /// or
        /// [`DECISIONED`][google.ads.admanager.v1.AdBreakStateEnum.AdBreakState.DECISIONED].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAdBreak(DeleteAdBreakRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to delete an `AdBreak` object.
        /// 
        /// Deletes and cancels an incomplete ad break, mitigating the need to wait
        /// for the current break to serve before recreating an ad break. You can
        /// delete an ad break that has not started serving or seen in manifests,
        /// indicated by its state being
        /// [`SCHEDULED`][google.ads.admanager.v1.AdBreakStateEnum.AdBreakState.SCHEDULED]
        /// or
        /// [`DECISIONED`][google.ads.admanager.v1.AdBreakStateEnum.AdBreakState.DECISIONED].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAdBreakAsync(DeleteAdBreakRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to delete an `AdBreak` object.
        /// 
        /// Deletes and cancels an incomplete ad break, mitigating the need to wait
        /// for the current break to serve before recreating an ad break. You can
        /// delete an ad break that has not started serving or seen in manifests,
        /// indicated by its state being
        /// [`SCHEDULED`][google.ads.admanager.v1.AdBreakStateEnum.AdBreakState.SCHEDULED]
        /// or
        /// [`DECISIONED`][google.ads.admanager.v1.AdBreakStateEnum.AdBreakState.DECISIONED].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAdBreakAsync(DeleteAdBreakRequest request, st::CancellationToken cancellationToken) =>
            DeleteAdBreakAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to delete an `AdBreak` object.
        /// 
        /// Deletes and cancels an incomplete ad break, mitigating the need to wait
        /// for the current break to serve before recreating an ad break. You can
        /// delete an ad break that has not started serving or seen in manifests,
        /// indicated by its state being
        /// [`SCHEDULED`][google.ads.admanager.v1.AdBreakStateEnum.AdBreakState.SCHEDULED]
        /// or
        /// [`DECISIONED`][google.ads.admanager.v1.AdBreakStateEnum.AdBreakState.DECISIONED].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ad break to delete.
        /// 
        /// Format:
        /// `networks/{network_code}/liveStreamEventsByAssetKey/{asset_key}/adBreaks/{ad_break}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAdBreak(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAdBreak(new DeleteAdBreakRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to delete an `AdBreak` object.
        /// 
        /// Deletes and cancels an incomplete ad break, mitigating the need to wait
        /// for the current break to serve before recreating an ad break. You can
        /// delete an ad break that has not started serving or seen in manifests,
        /// indicated by its state being
        /// [`SCHEDULED`][google.ads.admanager.v1.AdBreakStateEnum.AdBreakState.SCHEDULED]
        /// or
        /// [`DECISIONED`][google.ads.admanager.v1.AdBreakStateEnum.AdBreakState.DECISIONED].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ad break to delete.
        /// 
        /// Format:
        /// `networks/{network_code}/liveStreamEventsByAssetKey/{asset_key}/adBreaks/{ad_break}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAdBreakAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAdBreakAsync(new DeleteAdBreakRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to delete an `AdBreak` object.
        /// 
        /// Deletes and cancels an incomplete ad break, mitigating the need to wait
        /// for the current break to serve before recreating an ad break. You can
        /// delete an ad break that has not started serving or seen in manifests,
        /// indicated by its state being
        /// [`SCHEDULED`][google.ads.admanager.v1.AdBreakStateEnum.AdBreakState.SCHEDULED]
        /// or
        /// [`DECISIONED`][google.ads.admanager.v1.AdBreakStateEnum.AdBreakState.DECISIONED].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ad break to delete.
        /// 
        /// Format:
        /// `networks/{network_code}/liveStreamEventsByAssetKey/{asset_key}/adBreaks/{ad_break}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAdBreakAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAdBreakAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to delete an `AdBreak` object.
        /// 
        /// Deletes and cancels an incomplete ad break, mitigating the need to wait
        /// for the current break to serve before recreating an ad break. You can
        /// delete an ad break that has not started serving or seen in manifests,
        /// indicated by its state being
        /// [`SCHEDULED`][google.ads.admanager.v1.AdBreakStateEnum.AdBreakState.SCHEDULED]
        /// or
        /// [`DECISIONED`][google.ads.admanager.v1.AdBreakStateEnum.AdBreakState.DECISIONED].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ad break to delete.
        /// 
        /// Format:
        /// `networks/{network_code}/liveStreamEventsByAssetKey/{asset_key}/adBreaks/{ad_break}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAdBreak(AdBreakName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAdBreak(new DeleteAdBreakRequest
            {
                AdBreakName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to delete an `AdBreak` object.
        /// 
        /// Deletes and cancels an incomplete ad break, mitigating the need to wait
        /// for the current break to serve before recreating an ad break. You can
        /// delete an ad break that has not started serving or seen in manifests,
        /// indicated by its state being
        /// [`SCHEDULED`][google.ads.admanager.v1.AdBreakStateEnum.AdBreakState.SCHEDULED]
        /// or
        /// [`DECISIONED`][google.ads.admanager.v1.AdBreakStateEnum.AdBreakState.DECISIONED].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ad break to delete.
        /// 
        /// Format:
        /// `networks/{network_code}/liveStreamEventsByAssetKey/{asset_key}/adBreaks/{ad_break}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAdBreakAsync(AdBreakName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAdBreakAsync(new DeleteAdBreakRequest
            {
                AdBreakName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to delete an `AdBreak` object.
        /// 
        /// Deletes and cancels an incomplete ad break, mitigating the need to wait
        /// for the current break to serve before recreating an ad break. You can
        /// delete an ad break that has not started serving or seen in manifests,
        /// indicated by its state being
        /// [`SCHEDULED`][google.ads.admanager.v1.AdBreakStateEnum.AdBreakState.SCHEDULED]
        /// or
        /// [`DECISIONED`][google.ads.admanager.v1.AdBreakStateEnum.AdBreakState.DECISIONED].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ad break to delete.
        /// 
        /// Format:
        /// `networks/{network_code}/liveStreamEventsByAssetKey/{asset_key}/adBreaks/{ad_break}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAdBreakAsync(AdBreakName name, st::CancellationToken cancellationToken) =>
            DeleteAdBreakAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AdBreakService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `AdBreak` objects.
    /// </remarks>
    public sealed partial class AdBreakServiceClientImpl : AdBreakServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetAdBreakRequest, AdBreak> _callGetAdBreak;

        private readonly gaxgrpc::ApiCall<ListAdBreaksRequest, ListAdBreaksResponse> _callListAdBreaks;

        private readonly gaxgrpc::ApiCall<CreateAdBreakRequest, AdBreak> _callCreateAdBreak;

        private readonly gaxgrpc::ApiCall<UpdateAdBreakRequest, AdBreak> _callUpdateAdBreak;

        private readonly gaxgrpc::ApiCall<DeleteAdBreakRequest, wkt::Empty> _callDeleteAdBreak;

        /// <summary>
        /// Constructs a client wrapper for the AdBreakService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AdBreakServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AdBreakServiceClientImpl(AdBreakService.AdBreakServiceClient grpcClient, AdBreakServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AdBreakServiceSettings effectiveSettings = settings ?? AdBreakServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetAdBreak = clientHelper.BuildApiCall<GetAdBreakRequest, AdBreak>("GetAdBreak", grpcClient.GetAdBreakAsync, grpcClient.GetAdBreak, effectiveSettings.GetAdBreakSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAdBreak);
            Modify_GetAdBreakApiCall(ref _callGetAdBreak);
            _callListAdBreaks = clientHelper.BuildApiCall<ListAdBreaksRequest, ListAdBreaksResponse>("ListAdBreaks", grpcClient.ListAdBreaksAsync, grpcClient.ListAdBreaks, effectiveSettings.ListAdBreaksSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAdBreaks);
            Modify_ListAdBreaksApiCall(ref _callListAdBreaks);
            _callCreateAdBreak = clientHelper.BuildApiCall<CreateAdBreakRequest, AdBreak>("CreateAdBreak", grpcClient.CreateAdBreakAsync, grpcClient.CreateAdBreak, effectiveSettings.CreateAdBreakSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAdBreak);
            Modify_CreateAdBreakApiCall(ref _callCreateAdBreak);
            _callUpdateAdBreak = clientHelper.BuildApiCall<UpdateAdBreakRequest, AdBreak>("UpdateAdBreak", grpcClient.UpdateAdBreakAsync, grpcClient.UpdateAdBreak, effectiveSettings.UpdateAdBreakSettings).WithGoogleRequestParam("ad_break.name", request => request.AdBreak?.Name);
            Modify_ApiCall(ref _callUpdateAdBreak);
            Modify_UpdateAdBreakApiCall(ref _callUpdateAdBreak);
            _callDeleteAdBreak = clientHelper.BuildApiCall<DeleteAdBreakRequest, wkt::Empty>("DeleteAdBreak", grpcClient.DeleteAdBreakAsync, grpcClient.DeleteAdBreak, effectiveSettings.DeleteAdBreakSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAdBreak);
            Modify_DeleteAdBreakApiCall(ref _callDeleteAdBreak);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetAdBreakApiCall(ref gaxgrpc::ApiCall<GetAdBreakRequest, AdBreak> call);

        partial void Modify_ListAdBreaksApiCall(ref gaxgrpc::ApiCall<ListAdBreaksRequest, ListAdBreaksResponse> call);

        partial void Modify_CreateAdBreakApiCall(ref gaxgrpc::ApiCall<CreateAdBreakRequest, AdBreak> call);

        partial void Modify_UpdateAdBreakApiCall(ref gaxgrpc::ApiCall<UpdateAdBreakRequest, AdBreak> call);

        partial void Modify_DeleteAdBreakApiCall(ref gaxgrpc::ApiCall<DeleteAdBreakRequest, wkt::Empty> call);

        partial void OnConstruction(AdBreakService.AdBreakServiceClient grpcClient, AdBreakServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AdBreakService client</summary>
        public override AdBreakService.AdBreakServiceClient GrpcClient { get; }

        partial void Modify_GetAdBreakRequest(ref GetAdBreakRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAdBreaksRequest(ref ListAdBreaksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAdBreakRequest(ref CreateAdBreakRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAdBreakRequest(ref UpdateAdBreakRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAdBreakRequest(ref DeleteAdBreakRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// API to retrieve an `AdBreak` object.
        /// 
        /// Query an ad break by its resource name or custom asset key. Check the
        /// resource's `breakState` field to determine its state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AdBreak GetAdBreak(GetAdBreakRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAdBreakRequest(ref request, ref callSettings);
            return _callGetAdBreak.Sync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve an `AdBreak` object.
        /// 
        /// Query an ad break by its resource name or custom asset key. Check the
        /// resource's `breakState` field to determine its state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AdBreak> GetAdBreakAsync(GetAdBreakRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAdBreakRequest(ref request, ref callSettings);
            return _callGetAdBreak.Async(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `AdBreak` objects.
        /// 
        /// By default, when no `orderBy` query parameter is specified, ad breaks are
        /// ordered reverse chronologically. However, ad breaks with a 'breakState' of
        /// 'SCHEDULED' or 'DECISIONED' are prioritized and appear first.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AdBreak"/> resources.</returns>
        public override gax::PagedEnumerable<ListAdBreaksResponse, AdBreak> ListAdBreaks(ListAdBreaksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAdBreaksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAdBreaksRequest, ListAdBreaksResponse, AdBreak>(_callListAdBreaks, request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `AdBreak` objects.
        /// 
        /// By default, when no `orderBy` query parameter is specified, ad breaks are
        /// ordered reverse chronologically. However, ad breaks with a 'breakState' of
        /// 'SCHEDULED' or 'DECISIONED' are prioritized and appear first.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AdBreak"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAdBreaksResponse, AdBreak> ListAdBreaksAsync(ListAdBreaksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAdBreaksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAdBreaksRequest, ListAdBreaksResponse, AdBreak>(_callListAdBreaks, request, callSettings);
        }

        /// <summary>
        /// API to create an `AdBreak` object.
        /// 
        /// Informs DAI of an upcoming ad break for a live stream event, with an
        /// optional expected start time. DAI will begin decisioning ads for the break
        /// shortly before the expected start time, if provided. Each live stream
        /// event can only have one incomplete ad break at any given time. The next ad
        /// break can be scheduled after the previous ad break has started serving,
        /// indicated by its state being
        /// [`COMPLETE`][google.ads.admanager.v1.AdBreakStateEnum.AdBreakState.COMPLETE],
        /// or it has been deleted.
        /// 
        /// This method cannot be used if the `LiveStreamEvent` has
        /// [prefetching ad breaks
        /// enabled](https://developers.google.com/ad-manager/api/reference/latest/LiveStreamEventService.LiveStreamEvent#prefetchenabled)
        /// or the event is not active. If a `LiveStreamEvent` is deactivated after
        /// creating an ad break and before the ad break is complete, the ad break
        /// is discarded.
        /// 
        /// An ad break's state is complete when the following occurs:
        /// - Full service DAI: after a matching ad break shows in the
        /// `LiveStreamEvent` manifest only when the ad break has started decisioning.
        /// - Pod Serving: after the ad break is requested using the ad break ID or
        /// break sequence.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AdBreak CreateAdBreak(CreateAdBreakRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAdBreakRequest(ref request, ref callSettings);
            return _callCreateAdBreak.Sync(request, callSettings);
        }

        /// <summary>
        /// API to create an `AdBreak` object.
        /// 
        /// Informs DAI of an upcoming ad break for a live stream event, with an
        /// optional expected start time. DAI will begin decisioning ads for the break
        /// shortly before the expected start time, if provided. Each live stream
        /// event can only have one incomplete ad break at any given time. The next ad
        /// break can be scheduled after the previous ad break has started serving,
        /// indicated by its state being
        /// [`COMPLETE`][google.ads.admanager.v1.AdBreakStateEnum.AdBreakState.COMPLETE],
        /// or it has been deleted.
        /// 
        /// This method cannot be used if the `LiveStreamEvent` has
        /// [prefetching ad breaks
        /// enabled](https://developers.google.com/ad-manager/api/reference/latest/LiveStreamEventService.LiveStreamEvent#prefetchenabled)
        /// or the event is not active. If a `LiveStreamEvent` is deactivated after
        /// creating an ad break and before the ad break is complete, the ad break
        /// is discarded.
        /// 
        /// An ad break's state is complete when the following occurs:
        /// - Full service DAI: after a matching ad break shows in the
        /// `LiveStreamEvent` manifest only when the ad break has started decisioning.
        /// - Pod Serving: after the ad break is requested using the ad break ID or
        /// break sequence.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AdBreak> CreateAdBreakAsync(CreateAdBreakRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAdBreakRequest(ref request, ref callSettings);
            return _callCreateAdBreak.Async(request, callSettings);
        }

        /// <summary>
        /// API to update an `AdBreak` object.
        /// 
        /// Modify an ad break when its state is
        /// [`SCHEDULED`][google.ads.admanager.v1.AdBreakStateEnum.AdBreakState.SCHEDULED].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AdBreak UpdateAdBreak(UpdateAdBreakRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAdBreakRequest(ref request, ref callSettings);
            return _callUpdateAdBreak.Sync(request, callSettings);
        }

        /// <summary>
        /// API to update an `AdBreak` object.
        /// 
        /// Modify an ad break when its state is
        /// [`SCHEDULED`][google.ads.admanager.v1.AdBreakStateEnum.AdBreakState.SCHEDULED].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AdBreak> UpdateAdBreakAsync(UpdateAdBreakRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAdBreakRequest(ref request, ref callSettings);
            return _callUpdateAdBreak.Async(request, callSettings);
        }

        /// <summary>
        /// API to delete an `AdBreak` object.
        /// 
        /// Deletes and cancels an incomplete ad break, mitigating the need to wait
        /// for the current break to serve before recreating an ad break. You can
        /// delete an ad break that has not started serving or seen in manifests,
        /// indicated by its state being
        /// [`SCHEDULED`][google.ads.admanager.v1.AdBreakStateEnum.AdBreakState.SCHEDULED]
        /// or
        /// [`DECISIONED`][google.ads.admanager.v1.AdBreakStateEnum.AdBreakState.DECISIONED].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteAdBreak(DeleteAdBreakRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAdBreakRequest(ref request, ref callSettings);
            _callDeleteAdBreak.Sync(request, callSettings);
        }

        /// <summary>
        /// API to delete an `AdBreak` object.
        /// 
        /// Deletes and cancels an incomplete ad break, mitigating the need to wait
        /// for the current break to serve before recreating an ad break. You can
        /// delete an ad break that has not started serving or seen in manifests,
        /// indicated by its state being
        /// [`SCHEDULED`][google.ads.admanager.v1.AdBreakStateEnum.AdBreakState.SCHEDULED]
        /// or
        /// [`DECISIONED`][google.ads.admanager.v1.AdBreakStateEnum.AdBreakState.DECISIONED].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteAdBreakAsync(DeleteAdBreakRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAdBreakRequest(ref request, ref callSettings);
            return _callDeleteAdBreak.Async(request, callSettings);
        }
    }

    public partial class ListAdBreaksRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAdBreaksResponse : gaxgrpc::IPageResponse<AdBreak>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AdBreak> GetEnumerator() => AdBreaks.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
