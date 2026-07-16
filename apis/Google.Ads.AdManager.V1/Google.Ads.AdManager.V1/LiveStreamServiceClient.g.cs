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
    /// <summary>Settings for <see cref="LiveStreamServiceClient"/> instances.</summary>
    public sealed partial class LiveStreamServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="LiveStreamServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="LiveStreamServiceSettings"/>.</returns>
        public static LiveStreamServiceSettings GetDefault() => new LiveStreamServiceSettings();

        /// <summary>Constructs a new <see cref="LiveStreamServiceSettings"/> object with default settings.</summary>
        public LiveStreamServiceSettings()
        {
        }

        private LiveStreamServiceSettings(LiveStreamServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetLiveStreamSettings = existing.GetLiveStreamSettings;
            ListLiveStreamsSettings = existing.ListLiveStreamsSettings;
            CreateLiveStreamSettings = existing.CreateLiveStreamSettings;
            BatchCreateLiveStreamsSettings = existing.BatchCreateLiveStreamsSettings;
            UpdateLiveStreamSettings = existing.UpdateLiveStreamSettings;
            BatchUpdateLiveStreamsSettings = existing.BatchUpdateLiveStreamsSettings;
            BatchActivateLiveStreamsSettings = existing.BatchActivateLiveStreamsSettings;
            BatchPauseLiveStreamsSettings = existing.BatchPauseLiveStreamsSettings;
            BatchArchiveLiveStreamsSettings = existing.BatchArchiveLiveStreamsSettings;
            BatchPauseAdsLiveStreamsSettings = existing.BatchPauseAdsLiveStreamsSettings;
            BatchRefreshMasterPlaylistsSettings = existing.BatchRefreshMasterPlaylistsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(LiveStreamServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LiveStreamServiceClient.GetLiveStream</c> and <c>LiveStreamServiceClient.GetLiveStreamAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetLiveStreamSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LiveStreamServiceClient.ListLiveStreams</c> and <c>LiveStreamServiceClient.ListLiveStreamsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListLiveStreamsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LiveStreamServiceClient.CreateLiveStream</c> and <c>LiveStreamServiceClient.CreateLiveStreamAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateLiveStreamSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LiveStreamServiceClient.BatchCreateLiveStreams</c> and
        /// <c>LiveStreamServiceClient.BatchCreateLiveStreamsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchCreateLiveStreamsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LiveStreamServiceClient.UpdateLiveStream</c> and <c>LiveStreamServiceClient.UpdateLiveStreamAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateLiveStreamSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LiveStreamServiceClient.BatchUpdateLiveStreams</c> and
        /// <c>LiveStreamServiceClient.BatchUpdateLiveStreamsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchUpdateLiveStreamsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LiveStreamServiceClient.BatchActivateLiveStreams</c> and
        /// <c>LiveStreamServiceClient.BatchActivateLiveStreamsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchActivateLiveStreamsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LiveStreamServiceClient.BatchPauseLiveStreams</c> and
        /// <c>LiveStreamServiceClient.BatchPauseLiveStreamsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchPauseLiveStreamsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LiveStreamServiceClient.BatchArchiveLiveStreams</c> and
        /// <c>LiveStreamServiceClient.BatchArchiveLiveStreamsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchArchiveLiveStreamsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LiveStreamServiceClient.BatchPauseAdsLiveStreams</c> and
        /// <c>LiveStreamServiceClient.BatchPauseAdsLiveStreamsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchPauseAdsLiveStreamsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LiveStreamServiceClient.BatchRefreshMasterPlaylists</c> and
        /// <c>LiveStreamServiceClient.BatchRefreshMasterPlaylistsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchRefreshMasterPlaylistsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="LiveStreamServiceSettings"/> object.</returns>
        public LiveStreamServiceSettings Clone() => new LiveStreamServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="LiveStreamServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class LiveStreamServiceClientBuilder : gaxgrpc::ClientBuilderBase<LiveStreamServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public LiveStreamServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public LiveStreamServiceClientBuilder() : base(LiveStreamServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref LiveStreamServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<LiveStreamServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override LiveStreamServiceClient Build()
        {
            LiveStreamServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<LiveStreamServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<LiveStreamServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private LiveStreamServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return LiveStreamServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<LiveStreamServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return LiveStreamServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => LiveStreamServiceClient.ChannelPool;
    }

    /// <summary>LiveStreamService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `LiveStream` objects.
    /// </remarks>
    public abstract partial class LiveStreamServiceClient
    {
        /// <summary>
        /// The default endpoint for the LiveStreamService service, which is a host of "admanager.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default LiveStreamService scopes.</summary>
        /// <remarks>
        /// The default LiveStreamService scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(LiveStreamService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="LiveStreamServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="LiveStreamServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="LiveStreamServiceClient"/>.</returns>
        public static stt::Task<LiveStreamServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new LiveStreamServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="LiveStreamServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="LiveStreamServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="LiveStreamServiceClient"/>.</returns>
        public static LiveStreamServiceClient Create() => new LiveStreamServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="LiveStreamServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="LiveStreamServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="LiveStreamServiceClient"/>.</returns>
        internal static LiveStreamServiceClient Create(grpccore::CallInvoker callInvoker, LiveStreamServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            LiveStreamService.LiveStreamServiceClient grpcClient = new LiveStreamService.LiveStreamServiceClient(callInvoker);
            return new LiveStreamServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC LiveStreamService client</summary>
        public virtual LiveStreamService.LiveStreamServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `LiveStream` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LiveStream GetLiveStream(GetLiveStreamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `LiveStream` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LiveStream> GetLiveStreamAsync(GetLiveStreamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `LiveStream` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LiveStream> GetLiveStreamAsync(GetLiveStreamRequest request, st::CancellationToken cancellationToken) =>
            GetLiveStreamAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `LiveStream` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the LiveStream.
        /// Format: `networks/{network_code}/liveStreams/{live_stream_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LiveStream GetLiveStream(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetLiveStream(new GetLiveStreamRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `LiveStream` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the LiveStream.
        /// Format: `networks/{network_code}/liveStreams/{live_stream_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LiveStream> GetLiveStreamAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetLiveStreamAsync(new GetLiveStreamRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `LiveStream` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the LiveStream.
        /// Format: `networks/{network_code}/liveStreams/{live_stream_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LiveStream> GetLiveStreamAsync(string name, st::CancellationToken cancellationToken) =>
            GetLiveStreamAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `LiveStream` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the LiveStream.
        /// Format: `networks/{network_code}/liveStreams/{live_stream_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LiveStream GetLiveStream(LiveStreamName name, gaxgrpc::CallSettings callSettings = null) =>
            GetLiveStream(new GetLiveStreamRequest
            {
                LiveStreamName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `LiveStream` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the LiveStream.
        /// Format: `networks/{network_code}/liveStreams/{live_stream_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LiveStream> GetLiveStreamAsync(LiveStreamName name, gaxgrpc::CallSettings callSettings = null) =>
            GetLiveStreamAsync(new GetLiveStreamRequest
            {
                LiveStreamName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `LiveStream` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the LiveStream.
        /// Format: `networks/{network_code}/liveStreams/{live_stream_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LiveStream> GetLiveStreamAsync(LiveStreamName name, st::CancellationToken cancellationToken) =>
            GetLiveStreamAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists `LiveStream` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LiveStream"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLiveStreamsResponse, LiveStream> ListLiveStreams(ListLiveStreamsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `LiveStream` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LiveStream"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLiveStreamsResponse, LiveStream> ListLiveStreamsAsync(ListLiveStreamsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of LiveStreams.
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
        /// <returns>A pageable sequence of <see cref="LiveStream"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLiveStreamsResponse, LiveStream> ListLiveStreams(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLiveStreamsRequest request = new ListLiveStreamsRequest
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
            return ListLiveStreams(request, callSettings);
        }

        /// <summary>
        /// Lists `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of LiveStreams.
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
        /// <returns>A pageable asynchronous sequence of <see cref="LiveStream"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLiveStreamsResponse, LiveStream> ListLiveStreamsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLiveStreamsRequest request = new ListLiveStreamsRequest
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
            return ListLiveStreamsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of LiveStreams.
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
        /// <returns>A pageable sequence of <see cref="LiveStream"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLiveStreamsResponse, LiveStream> ListLiveStreams(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLiveStreamsRequest request = new ListLiveStreamsRequest
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
            return ListLiveStreams(request, callSettings);
        }

        /// <summary>
        /// Lists `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of LiveStreams.
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
        /// <returns>A pageable asynchronous sequence of <see cref="LiveStream"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLiveStreamsResponse, LiveStream> ListLiveStreamsAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLiveStreamsRequest request = new ListLiveStreamsRequest
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
            return ListLiveStreamsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a `LiveStream` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LiveStream CreateLiveStream(CreateLiveStreamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `LiveStream` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LiveStream> CreateLiveStreamAsync(CreateLiveStreamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `LiveStream` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LiveStream> CreateLiveStreamAsync(CreateLiveStreamRequest request, st::CancellationToken cancellationToken) =>
            CreateLiveStreamAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `LiveStream` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `LiveStream` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="liveStream">
        /// Required. The `LiveStream` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LiveStream CreateLiveStream(string parent, LiveStream liveStream, gaxgrpc::CallSettings callSettings = null) =>
            CreateLiveStream(new CreateLiveStreamRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                LiveStream = gax::GaxPreconditions.CheckNotNull(liveStream, nameof(liveStream)),
            }, callSettings);

        /// <summary>
        /// Creates a `LiveStream` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `LiveStream` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="liveStream">
        /// Required. The `LiveStream` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LiveStream> CreateLiveStreamAsync(string parent, LiveStream liveStream, gaxgrpc::CallSettings callSettings = null) =>
            CreateLiveStreamAsync(new CreateLiveStreamRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                LiveStream = gax::GaxPreconditions.CheckNotNull(liveStream, nameof(liveStream)),
            }, callSettings);

        /// <summary>
        /// Creates a `LiveStream` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `LiveStream` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="liveStream">
        /// Required. The `LiveStream` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LiveStream> CreateLiveStreamAsync(string parent, LiveStream liveStream, st::CancellationToken cancellationToken) =>
            CreateLiveStreamAsync(parent, liveStream, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `LiveStream` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `LiveStream` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="liveStream">
        /// Required. The `LiveStream` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LiveStream CreateLiveStream(NetworkName parent, LiveStream liveStream, gaxgrpc::CallSettings callSettings = null) =>
            CreateLiveStream(new CreateLiveStreamRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LiveStream = gax::GaxPreconditions.CheckNotNull(liveStream, nameof(liveStream)),
            }, callSettings);

        /// <summary>
        /// Creates a `LiveStream` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `LiveStream` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="liveStream">
        /// Required. The `LiveStream` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LiveStream> CreateLiveStreamAsync(NetworkName parent, LiveStream liveStream, gaxgrpc::CallSettings callSettings = null) =>
            CreateLiveStreamAsync(new CreateLiveStreamRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LiveStream = gax::GaxPreconditions.CheckNotNull(liveStream, nameof(liveStream)),
            }, callSettings);

        /// <summary>
        /// Creates a `LiveStream` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `LiveStream` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="liveStream">
        /// Required. The `LiveStream` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LiveStream> CreateLiveStreamAsync(NetworkName parent, LiveStream liveStream, st::CancellationToken cancellationToken) =>
            CreateLiveStreamAsync(parent, liveStream, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch creates `LiveStream` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateLiveStreamsResponse BatchCreateLiveStreams(BatchCreateLiveStreamsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch creates `LiveStream` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateLiveStreamsResponse> BatchCreateLiveStreamsAsync(BatchCreateLiveStreamsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch creates `LiveStream` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateLiveStreamsResponse> BatchCreateLiveStreamsAsync(BatchCreateLiveStreamsRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateLiveStreamsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch creates `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LiveStreams` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateLiveStreamRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `LiveStream` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateLiveStreamsResponse BatchCreateLiveStreams(string parent, scg::IEnumerable<CreateLiveStreamRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateLiveStreams(new BatchCreateLiveStreamsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch creates `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LiveStreams` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateLiveStreamRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `LiveStream` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateLiveStreamsResponse> BatchCreateLiveStreamsAsync(string parent, scg::IEnumerable<CreateLiveStreamRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateLiveStreamsAsync(new BatchCreateLiveStreamsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch creates `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LiveStreams` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateLiveStreamRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `LiveStream` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateLiveStreamsResponse> BatchCreateLiveStreamsAsync(string parent, scg::IEnumerable<CreateLiveStreamRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateLiveStreamsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch creates `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LiveStreams` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateLiveStreamRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `LiveStream` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateLiveStreamsResponse BatchCreateLiveStreams(NetworkName parent, scg::IEnumerable<CreateLiveStreamRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateLiveStreams(new BatchCreateLiveStreamsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch creates `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LiveStreams` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateLiveStreamRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `LiveStream` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateLiveStreamsResponse> BatchCreateLiveStreamsAsync(NetworkName parent, scg::IEnumerable<CreateLiveStreamRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateLiveStreamsAsync(new BatchCreateLiveStreamsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch creates `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LiveStreams` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateLiveStreamRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `LiveStream` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateLiveStreamsResponse> BatchCreateLiveStreamsAsync(NetworkName parent, scg::IEnumerable<CreateLiveStreamRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateLiveStreamsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `LiveStream` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LiveStream UpdateLiveStream(UpdateLiveStreamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `LiveStream` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LiveStream> UpdateLiveStreamAsync(UpdateLiveStreamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `LiveStream` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LiveStream> UpdateLiveStreamAsync(UpdateLiveStreamRequest request, st::CancellationToken cancellationToken) =>
            UpdateLiveStreamAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `LiveStream` object.
        /// </summary>
        /// <param name="liveStream">
        /// Required. The `LiveStream` to update.
        /// 
        /// The `LiveStream`'s `name` is used to identify the `LiveStream` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LiveStream UpdateLiveStream(LiveStream liveStream, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateLiveStream(new UpdateLiveStreamRequest
            {
                LiveStream = gax::GaxPreconditions.CheckNotNull(liveStream, nameof(liveStream)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a `LiveStream` object.
        /// </summary>
        /// <param name="liveStream">
        /// Required. The `LiveStream` to update.
        /// 
        /// The `LiveStream`'s `name` is used to identify the `LiveStream` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LiveStream> UpdateLiveStreamAsync(LiveStream liveStream, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateLiveStreamAsync(new UpdateLiveStreamRequest
            {
                LiveStream = gax::GaxPreconditions.CheckNotNull(liveStream, nameof(liveStream)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a `LiveStream` object.
        /// </summary>
        /// <param name="liveStream">
        /// Required. The `LiveStream` to update.
        /// 
        /// The `LiveStream`'s `name` is used to identify the `LiveStream` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LiveStream> UpdateLiveStreamAsync(LiveStream liveStream, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateLiveStreamAsync(liveStream, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `LiveStream` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateLiveStreamsResponse BatchUpdateLiveStreams(BatchUpdateLiveStreamsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch updates `LiveStream` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateLiveStreamsResponse> BatchUpdateLiveStreamsAsync(BatchUpdateLiveStreamsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch updates `LiveStream` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateLiveStreamsResponse> BatchUpdateLiveStreamsAsync(BatchUpdateLiveStreamsRequest request, st::CancellationToken cancellationToken) =>
            BatchUpdateLiveStreamsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LiveStreams` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateLiveStreamRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `LiveStream` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateLiveStreamsResponse BatchUpdateLiveStreams(string parent, scg::IEnumerable<UpdateLiveStreamRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateLiveStreams(new BatchUpdateLiveStreamsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LiveStreams` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateLiveStreamRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `LiveStream` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateLiveStreamsResponse> BatchUpdateLiveStreamsAsync(string parent, scg::IEnumerable<UpdateLiveStreamRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateLiveStreamsAsync(new BatchUpdateLiveStreamsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LiveStreams` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateLiveStreamRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `LiveStream` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateLiveStreamsResponse> BatchUpdateLiveStreamsAsync(string parent, scg::IEnumerable<UpdateLiveStreamRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateLiveStreamsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LiveStreams` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateLiveStreamRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `LiveStream` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateLiveStreamsResponse BatchUpdateLiveStreams(NetworkName parent, scg::IEnumerable<UpdateLiveStreamRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateLiveStreams(new BatchUpdateLiveStreamsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LiveStreams` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateLiveStreamRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `LiveStream` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateLiveStreamsResponse> BatchUpdateLiveStreamsAsync(NetworkName parent, scg::IEnumerable<UpdateLiveStreamRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateLiveStreamsAsync(new BatchUpdateLiveStreamsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `LiveStreams` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateLiveStreamRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `LiveStream` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateLiveStreamsResponse> BatchUpdateLiveStreamsAsync(NetworkName parent, scg::IEnumerable<UpdateLiveStreamRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateLiveStreamsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch activates `LiveStream` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateLiveStreamsResponse BatchActivateLiveStreams(BatchActivateLiveStreamsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch activates `LiveStream` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateLiveStreamsResponse> BatchActivateLiveStreamsAsync(BatchActivateLiveStreamsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch activates `LiveStream` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateLiveStreamsResponse> BatchActivateLiveStreamsAsync(BatchActivateLiveStreamsRequest request, st::CancellationToken cancellationToken) =>
            BatchActivateLiveStreamsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch activates `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `LiveStream`s to activate.
        /// Format: `networks/{network_code}/liveStreams/{live_stream_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateLiveStreamsResponse BatchActivateLiveStreams(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateLiveStreams(new BatchActivateLiveStreamsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch activates `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `LiveStream`s to activate.
        /// Format: `networks/{network_code}/liveStreams/{live_stream_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateLiveStreamsResponse> BatchActivateLiveStreamsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateLiveStreamsAsync(new BatchActivateLiveStreamsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch activates `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `LiveStream`s to activate.
        /// Format: `networks/{network_code}/liveStreams/{live_stream_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateLiveStreamsResponse> BatchActivateLiveStreamsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchActivateLiveStreamsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch activates `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `LiveStream`s to activate.
        /// Format: `networks/{network_code}/liveStreams/{live_stream_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateLiveStreamsResponse BatchActivateLiveStreams(NetworkName parent, scg::IEnumerable<LiveStreamName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateLiveStreams(new BatchActivateLiveStreamsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LiveStreamNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch activates `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `LiveStream`s to activate.
        /// Format: `networks/{network_code}/liveStreams/{live_stream_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateLiveStreamsResponse> BatchActivateLiveStreamsAsync(NetworkName parent, scg::IEnumerable<LiveStreamName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateLiveStreamsAsync(new BatchActivateLiveStreamsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LiveStreamNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch activates `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `LiveStream`s to activate.
        /// Format: `networks/{network_code}/liveStreams/{live_stream_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateLiveStreamsResponse> BatchActivateLiveStreamsAsync(NetworkName parent, scg::IEnumerable<LiveStreamName> names, st::CancellationToken cancellationToken) =>
            BatchActivateLiveStreamsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch pauses `LiveStream` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchPauseLiveStreamsResponse BatchPauseLiveStreams(BatchPauseLiveStreamsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch pauses `LiveStream` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPauseLiveStreamsResponse> BatchPauseLiveStreamsAsync(BatchPauseLiveStreamsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch pauses `LiveStream` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPauseLiveStreamsResponse> BatchPauseLiveStreamsAsync(BatchPauseLiveStreamsRequest request, st::CancellationToken cancellationToken) =>
            BatchPauseLiveStreamsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch pauses `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `LiveStream`s to pause.
        /// Format: `networks/{network_code}/liveStreams/{live_stream_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchPauseLiveStreamsResponse BatchPauseLiveStreams(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchPauseLiveStreams(new BatchPauseLiveStreamsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch pauses `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `LiveStream`s to pause.
        /// Format: `networks/{network_code}/liveStreams/{live_stream_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPauseLiveStreamsResponse> BatchPauseLiveStreamsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchPauseLiveStreamsAsync(new BatchPauseLiveStreamsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch pauses `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `LiveStream`s to pause.
        /// Format: `networks/{network_code}/liveStreams/{live_stream_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPauseLiveStreamsResponse> BatchPauseLiveStreamsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchPauseLiveStreamsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch pauses `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `LiveStream`s to pause.
        /// Format: `networks/{network_code}/liveStreams/{live_stream_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchPauseLiveStreamsResponse BatchPauseLiveStreams(NetworkName parent, scg::IEnumerable<LiveStreamName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchPauseLiveStreams(new BatchPauseLiveStreamsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LiveStreamNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch pauses `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `LiveStream`s to pause.
        /// Format: `networks/{network_code}/liveStreams/{live_stream_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPauseLiveStreamsResponse> BatchPauseLiveStreamsAsync(NetworkName parent, scg::IEnumerable<LiveStreamName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchPauseLiveStreamsAsync(new BatchPauseLiveStreamsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LiveStreamNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch pauses `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `LiveStream`s to pause.
        /// Format: `networks/{network_code}/liveStreams/{live_stream_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPauseLiveStreamsResponse> BatchPauseLiveStreamsAsync(NetworkName parent, scg::IEnumerable<LiveStreamName> names, st::CancellationToken cancellationToken) =>
            BatchPauseLiveStreamsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch archives `LiveStream` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchArchiveLiveStreamsResponse BatchArchiveLiveStreams(BatchArchiveLiveStreamsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch archives `LiveStream` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveLiveStreamsResponse> BatchArchiveLiveStreamsAsync(BatchArchiveLiveStreamsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch archives `LiveStream` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveLiveStreamsResponse> BatchArchiveLiveStreamsAsync(BatchArchiveLiveStreamsRequest request, st::CancellationToken cancellationToken) =>
            BatchArchiveLiveStreamsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch archives `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `LiveStream`s to archive.
        /// Format: `networks/{network_code}/liveStreams/{live_stream_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchArchiveLiveStreamsResponse BatchArchiveLiveStreams(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchArchiveLiveStreams(new BatchArchiveLiveStreamsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch archives `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `LiveStream`s to archive.
        /// Format: `networks/{network_code}/liveStreams/{live_stream_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveLiveStreamsResponse> BatchArchiveLiveStreamsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchArchiveLiveStreamsAsync(new BatchArchiveLiveStreamsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch archives `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `LiveStream`s to archive.
        /// Format: `networks/{network_code}/liveStreams/{live_stream_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveLiveStreamsResponse> BatchArchiveLiveStreamsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchArchiveLiveStreamsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch archives `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `LiveStream`s to archive.
        /// Format: `networks/{network_code}/liveStreams/{live_stream_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchArchiveLiveStreamsResponse BatchArchiveLiveStreams(NetworkName parent, scg::IEnumerable<LiveStreamName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchArchiveLiveStreams(new BatchArchiveLiveStreamsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LiveStreamNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch archives `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `LiveStream`s to archive.
        /// Format: `networks/{network_code}/liveStreams/{live_stream_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveLiveStreamsResponse> BatchArchiveLiveStreamsAsync(NetworkName parent, scg::IEnumerable<LiveStreamName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchArchiveLiveStreamsAsync(new BatchArchiveLiveStreamsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LiveStreamNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch archives `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `LiveStream`s to archive.
        /// Format: `networks/{network_code}/liveStreams/{live_stream_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveLiveStreamsResponse> BatchArchiveLiveStreamsAsync(NetworkName parent, scg::IEnumerable<LiveStreamName> names, st::CancellationToken cancellationToken) =>
            BatchArchiveLiveStreamsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch pauses ads on `LiveStream` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchPauseAdsLiveStreamsResponse BatchPauseAdsLiveStreams(BatchPauseAdsLiveStreamsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch pauses ads on `LiveStream` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPauseAdsLiveStreamsResponse> BatchPauseAdsLiveStreamsAsync(BatchPauseAdsLiveStreamsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch pauses ads on `LiveStream` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPauseAdsLiveStreamsResponse> BatchPauseAdsLiveStreamsAsync(BatchPauseAdsLiveStreamsRequest request, st::CancellationToken cancellationToken) =>
            BatchPauseAdsLiveStreamsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch pauses ads on `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `LiveStream`s to pause ads on.
        /// Format: `networks/{network_code}/liveStreams/{live_stream_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchPauseAdsLiveStreamsResponse BatchPauseAdsLiveStreams(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchPauseAdsLiveStreams(new BatchPauseAdsLiveStreamsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch pauses ads on `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `LiveStream`s to pause ads on.
        /// Format: `networks/{network_code}/liveStreams/{live_stream_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPauseAdsLiveStreamsResponse> BatchPauseAdsLiveStreamsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchPauseAdsLiveStreamsAsync(new BatchPauseAdsLiveStreamsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch pauses ads on `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `LiveStream`s to pause ads on.
        /// Format: `networks/{network_code}/liveStreams/{live_stream_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPauseAdsLiveStreamsResponse> BatchPauseAdsLiveStreamsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchPauseAdsLiveStreamsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch pauses ads on `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `LiveStream`s to pause ads on.
        /// Format: `networks/{network_code}/liveStreams/{live_stream_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchPauseAdsLiveStreamsResponse BatchPauseAdsLiveStreams(NetworkName parent, scg::IEnumerable<LiveStreamName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchPauseAdsLiveStreams(new BatchPauseAdsLiveStreamsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LiveStreamNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch pauses ads on `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `LiveStream`s to pause ads on.
        /// Format: `networks/{network_code}/liveStreams/{live_stream_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPauseAdsLiveStreamsResponse> BatchPauseAdsLiveStreamsAsync(NetworkName parent, scg::IEnumerable<LiveStreamName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchPauseAdsLiveStreamsAsync(new BatchPauseAdsLiveStreamsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LiveStreamNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch pauses ads on `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `LiveStream`s to pause ads on.
        /// Format: `networks/{network_code}/liveStreams/{live_stream_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPauseAdsLiveStreamsResponse> BatchPauseAdsLiveStreamsAsync(NetworkName parent, scg::IEnumerable<LiveStreamName> names, st::CancellationToken cancellationToken) =>
            BatchPauseAdsLiveStreamsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch refreshes master playlists on `LiveStream` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchRefreshMasterPlaylistsResponse BatchRefreshMasterPlaylists(BatchRefreshMasterPlaylistsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch refreshes master playlists on `LiveStream` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRefreshMasterPlaylistsResponse> BatchRefreshMasterPlaylistsAsync(BatchRefreshMasterPlaylistsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch refreshes master playlists on `LiveStream` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRefreshMasterPlaylistsResponse> BatchRefreshMasterPlaylistsAsync(BatchRefreshMasterPlaylistsRequest request, st::CancellationToken cancellationToken) =>
            BatchRefreshMasterPlaylistsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch refreshes master playlists on `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `LiveStream`s to refresh master
        /// playlists on. Format:
        /// `networks/{network_code}/liveStreams/{live_stream_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchRefreshMasterPlaylistsResponse BatchRefreshMasterPlaylists(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchRefreshMasterPlaylists(new BatchRefreshMasterPlaylistsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch refreshes master playlists on `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `LiveStream`s to refresh master
        /// playlists on. Format:
        /// `networks/{network_code}/liveStreams/{live_stream_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRefreshMasterPlaylistsResponse> BatchRefreshMasterPlaylistsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchRefreshMasterPlaylistsAsync(new BatchRefreshMasterPlaylistsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch refreshes master playlists on `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `LiveStream`s to refresh master
        /// playlists on. Format:
        /// `networks/{network_code}/liveStreams/{live_stream_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRefreshMasterPlaylistsResponse> BatchRefreshMasterPlaylistsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchRefreshMasterPlaylistsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch refreshes master playlists on `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `LiveStream`s to refresh master
        /// playlists on. Format:
        /// `networks/{network_code}/liveStreams/{live_stream_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchRefreshMasterPlaylistsResponse BatchRefreshMasterPlaylists(NetworkName parent, scg::IEnumerable<LiveStreamName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchRefreshMasterPlaylists(new BatchRefreshMasterPlaylistsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LiveStreamNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch refreshes master playlists on `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `LiveStream`s to refresh master
        /// playlists on. Format:
        /// `networks/{network_code}/liveStreams/{live_stream_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRefreshMasterPlaylistsResponse> BatchRefreshMasterPlaylistsAsync(NetworkName parent, scg::IEnumerable<LiveStreamName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchRefreshMasterPlaylistsAsync(new BatchRefreshMasterPlaylistsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LiveStreamNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch refreshes master playlists on `LiveStream` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `LiveStream`s to refresh master
        /// playlists on. Format:
        /// `networks/{network_code}/liveStreams/{live_stream_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRefreshMasterPlaylistsResponse> BatchRefreshMasterPlaylistsAsync(NetworkName parent, scg::IEnumerable<LiveStreamName> names, st::CancellationToken cancellationToken) =>
            BatchRefreshMasterPlaylistsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>LiveStreamService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `LiveStream` objects.
    /// </remarks>
    public sealed partial class LiveStreamServiceClientImpl : LiveStreamServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetLiveStreamRequest, LiveStream> _callGetLiveStream;

        private readonly gaxgrpc::ApiCall<ListLiveStreamsRequest, ListLiveStreamsResponse> _callListLiveStreams;

        private readonly gaxgrpc::ApiCall<CreateLiveStreamRequest, LiveStream> _callCreateLiveStream;

        private readonly gaxgrpc::ApiCall<BatchCreateLiveStreamsRequest, BatchCreateLiveStreamsResponse> _callBatchCreateLiveStreams;

        private readonly gaxgrpc::ApiCall<UpdateLiveStreamRequest, LiveStream> _callUpdateLiveStream;

        private readonly gaxgrpc::ApiCall<BatchUpdateLiveStreamsRequest, BatchUpdateLiveStreamsResponse> _callBatchUpdateLiveStreams;

        private readonly gaxgrpc::ApiCall<BatchActivateLiveStreamsRequest, BatchActivateLiveStreamsResponse> _callBatchActivateLiveStreams;

        private readonly gaxgrpc::ApiCall<BatchPauseLiveStreamsRequest, BatchPauseLiveStreamsResponse> _callBatchPauseLiveStreams;

        private readonly gaxgrpc::ApiCall<BatchArchiveLiveStreamsRequest, BatchArchiveLiveStreamsResponse> _callBatchArchiveLiveStreams;

        private readonly gaxgrpc::ApiCall<BatchPauseAdsLiveStreamsRequest, BatchPauseAdsLiveStreamsResponse> _callBatchPauseAdsLiveStreams;

        private readonly gaxgrpc::ApiCall<BatchRefreshMasterPlaylistsRequest, BatchRefreshMasterPlaylistsResponse> _callBatchRefreshMasterPlaylists;

        /// <summary>
        /// Constructs a client wrapper for the LiveStreamService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="LiveStreamServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public LiveStreamServiceClientImpl(LiveStreamService.LiveStreamServiceClient grpcClient, LiveStreamServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            LiveStreamServiceSettings effectiveSettings = settings ?? LiveStreamServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetLiveStream = clientHelper.BuildApiCall<GetLiveStreamRequest, LiveStream>("GetLiveStream", grpcClient.GetLiveStreamAsync, grpcClient.GetLiveStream, effectiveSettings.GetLiveStreamSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetLiveStream);
            Modify_GetLiveStreamApiCall(ref _callGetLiveStream);
            _callListLiveStreams = clientHelper.BuildApiCall<ListLiveStreamsRequest, ListLiveStreamsResponse>("ListLiveStreams", grpcClient.ListLiveStreamsAsync, grpcClient.ListLiveStreams, effectiveSettings.ListLiveStreamsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListLiveStreams);
            Modify_ListLiveStreamsApiCall(ref _callListLiveStreams);
            _callCreateLiveStream = clientHelper.BuildApiCall<CreateLiveStreamRequest, LiveStream>("CreateLiveStream", grpcClient.CreateLiveStreamAsync, grpcClient.CreateLiveStream, effectiveSettings.CreateLiveStreamSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateLiveStream);
            Modify_CreateLiveStreamApiCall(ref _callCreateLiveStream);
            _callBatchCreateLiveStreams = clientHelper.BuildApiCall<BatchCreateLiveStreamsRequest, BatchCreateLiveStreamsResponse>("BatchCreateLiveStreams", grpcClient.BatchCreateLiveStreamsAsync, grpcClient.BatchCreateLiveStreams, effectiveSettings.BatchCreateLiveStreamsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCreateLiveStreams);
            Modify_BatchCreateLiveStreamsApiCall(ref _callBatchCreateLiveStreams);
            _callUpdateLiveStream = clientHelper.BuildApiCall<UpdateLiveStreamRequest, LiveStream>("UpdateLiveStream", grpcClient.UpdateLiveStreamAsync, grpcClient.UpdateLiveStream, effectiveSettings.UpdateLiveStreamSettings).WithGoogleRequestParam("live_stream.name", request => request.LiveStream?.Name);
            Modify_ApiCall(ref _callUpdateLiveStream);
            Modify_UpdateLiveStreamApiCall(ref _callUpdateLiveStream);
            _callBatchUpdateLiveStreams = clientHelper.BuildApiCall<BatchUpdateLiveStreamsRequest, BatchUpdateLiveStreamsResponse>("BatchUpdateLiveStreams", grpcClient.BatchUpdateLiveStreamsAsync, grpcClient.BatchUpdateLiveStreams, effectiveSettings.BatchUpdateLiveStreamsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchUpdateLiveStreams);
            Modify_BatchUpdateLiveStreamsApiCall(ref _callBatchUpdateLiveStreams);
            _callBatchActivateLiveStreams = clientHelper.BuildApiCall<BatchActivateLiveStreamsRequest, BatchActivateLiveStreamsResponse>("BatchActivateLiveStreams", grpcClient.BatchActivateLiveStreamsAsync, grpcClient.BatchActivateLiveStreams, effectiveSettings.BatchActivateLiveStreamsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchActivateLiveStreams);
            Modify_BatchActivateLiveStreamsApiCall(ref _callBatchActivateLiveStreams);
            _callBatchPauseLiveStreams = clientHelper.BuildApiCall<BatchPauseLiveStreamsRequest, BatchPauseLiveStreamsResponse>("BatchPauseLiveStreams", grpcClient.BatchPauseLiveStreamsAsync, grpcClient.BatchPauseLiveStreams, effectiveSettings.BatchPauseLiveStreamsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchPauseLiveStreams);
            Modify_BatchPauseLiveStreamsApiCall(ref _callBatchPauseLiveStreams);
            _callBatchArchiveLiveStreams = clientHelper.BuildApiCall<BatchArchiveLiveStreamsRequest, BatchArchiveLiveStreamsResponse>("BatchArchiveLiveStreams", grpcClient.BatchArchiveLiveStreamsAsync, grpcClient.BatchArchiveLiveStreams, effectiveSettings.BatchArchiveLiveStreamsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchArchiveLiveStreams);
            Modify_BatchArchiveLiveStreamsApiCall(ref _callBatchArchiveLiveStreams);
            _callBatchPauseAdsLiveStreams = clientHelper.BuildApiCall<BatchPauseAdsLiveStreamsRequest, BatchPauseAdsLiveStreamsResponse>("BatchPauseAdsLiveStreams", grpcClient.BatchPauseAdsLiveStreamsAsync, grpcClient.BatchPauseAdsLiveStreams, effectiveSettings.BatchPauseAdsLiveStreamsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchPauseAdsLiveStreams);
            Modify_BatchPauseAdsLiveStreamsApiCall(ref _callBatchPauseAdsLiveStreams);
            _callBatchRefreshMasterPlaylists = clientHelper.BuildApiCall<BatchRefreshMasterPlaylistsRequest, BatchRefreshMasterPlaylistsResponse>("BatchRefreshMasterPlaylists", grpcClient.BatchRefreshMasterPlaylistsAsync, grpcClient.BatchRefreshMasterPlaylists, effectiveSettings.BatchRefreshMasterPlaylistsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchRefreshMasterPlaylists);
            Modify_BatchRefreshMasterPlaylistsApiCall(ref _callBatchRefreshMasterPlaylists);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetLiveStreamApiCall(ref gaxgrpc::ApiCall<GetLiveStreamRequest, LiveStream> call);

        partial void Modify_ListLiveStreamsApiCall(ref gaxgrpc::ApiCall<ListLiveStreamsRequest, ListLiveStreamsResponse> call);

        partial void Modify_CreateLiveStreamApiCall(ref gaxgrpc::ApiCall<CreateLiveStreamRequest, LiveStream> call);

        partial void Modify_BatchCreateLiveStreamsApiCall(ref gaxgrpc::ApiCall<BatchCreateLiveStreamsRequest, BatchCreateLiveStreamsResponse> call);

        partial void Modify_UpdateLiveStreamApiCall(ref gaxgrpc::ApiCall<UpdateLiveStreamRequest, LiveStream> call);

        partial void Modify_BatchUpdateLiveStreamsApiCall(ref gaxgrpc::ApiCall<BatchUpdateLiveStreamsRequest, BatchUpdateLiveStreamsResponse> call);

        partial void Modify_BatchActivateLiveStreamsApiCall(ref gaxgrpc::ApiCall<BatchActivateLiveStreamsRequest, BatchActivateLiveStreamsResponse> call);

        partial void Modify_BatchPauseLiveStreamsApiCall(ref gaxgrpc::ApiCall<BatchPauseLiveStreamsRequest, BatchPauseLiveStreamsResponse> call);

        partial void Modify_BatchArchiveLiveStreamsApiCall(ref gaxgrpc::ApiCall<BatchArchiveLiveStreamsRequest, BatchArchiveLiveStreamsResponse> call);

        partial void Modify_BatchPauseAdsLiveStreamsApiCall(ref gaxgrpc::ApiCall<BatchPauseAdsLiveStreamsRequest, BatchPauseAdsLiveStreamsResponse> call);

        partial void Modify_BatchRefreshMasterPlaylistsApiCall(ref gaxgrpc::ApiCall<BatchRefreshMasterPlaylistsRequest, BatchRefreshMasterPlaylistsResponse> call);

        partial void OnConstruction(LiveStreamService.LiveStreamServiceClient grpcClient, LiveStreamServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC LiveStreamService client</summary>
        public override LiveStreamService.LiveStreamServiceClient GrpcClient { get; }

        partial void Modify_GetLiveStreamRequest(ref GetLiveStreamRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListLiveStreamsRequest(ref ListLiveStreamsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateLiveStreamRequest(ref CreateLiveStreamRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateLiveStreamsRequest(ref BatchCreateLiveStreamsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateLiveStreamRequest(ref UpdateLiveStreamRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUpdateLiveStreamsRequest(ref BatchUpdateLiveStreamsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchActivateLiveStreamsRequest(ref BatchActivateLiveStreamsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchPauseLiveStreamsRequest(ref BatchPauseLiveStreamsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchArchiveLiveStreamsRequest(ref BatchArchiveLiveStreamsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchPauseAdsLiveStreamsRequest(ref BatchPauseAdsLiveStreamsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchRefreshMasterPlaylistsRequest(ref BatchRefreshMasterPlaylistsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves a `LiveStream` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LiveStream GetLiveStream(GetLiveStreamRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLiveStreamRequest(ref request, ref callSettings);
            return _callGetLiveStream.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a `LiveStream` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LiveStream> GetLiveStreamAsync(GetLiveStreamRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLiveStreamRequest(ref request, ref callSettings);
            return _callGetLiveStream.Async(request, callSettings);
        }

        /// <summary>
        /// Lists `LiveStream` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LiveStream"/> resources.</returns>
        public override gax::PagedEnumerable<ListLiveStreamsResponse, LiveStream> ListLiveStreams(ListLiveStreamsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLiveStreamsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListLiveStreamsRequest, ListLiveStreamsResponse, LiveStream>(_callListLiveStreams, request, callSettings);
        }

        /// <summary>
        /// Lists `LiveStream` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LiveStream"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListLiveStreamsResponse, LiveStream> ListLiveStreamsAsync(ListLiveStreamsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLiveStreamsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListLiveStreamsRequest, ListLiveStreamsResponse, LiveStream>(_callListLiveStreams, request, callSettings);
        }

        /// <summary>
        /// Creates a `LiveStream` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LiveStream CreateLiveStream(CreateLiveStreamRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateLiveStreamRequest(ref request, ref callSettings);
            return _callCreateLiveStream.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a `LiveStream` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LiveStream> CreateLiveStreamAsync(CreateLiveStreamRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateLiveStreamRequest(ref request, ref callSettings);
            return _callCreateLiveStream.Async(request, callSettings);
        }

        /// <summary>
        /// Batch creates `LiveStream` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchCreateLiveStreamsResponse BatchCreateLiveStreams(BatchCreateLiveStreamsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateLiveStreamsRequest(ref request, ref callSettings);
            return _callBatchCreateLiveStreams.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch creates `LiveStream` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchCreateLiveStreamsResponse> BatchCreateLiveStreamsAsync(BatchCreateLiveStreamsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateLiveStreamsRequest(ref request, ref callSettings);
            return _callBatchCreateLiveStreams.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a `LiveStream` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LiveStream UpdateLiveStream(UpdateLiveStreamRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateLiveStreamRequest(ref request, ref callSettings);
            return _callUpdateLiveStream.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a `LiveStream` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LiveStream> UpdateLiveStreamAsync(UpdateLiveStreamRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateLiveStreamRequest(ref request, ref callSettings);
            return _callUpdateLiveStream.Async(request, callSettings);
        }

        /// <summary>
        /// Batch updates `LiveStream` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchUpdateLiveStreamsResponse BatchUpdateLiveStreams(BatchUpdateLiveStreamsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateLiveStreamsRequest(ref request, ref callSettings);
            return _callBatchUpdateLiveStreams.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch updates `LiveStream` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchUpdateLiveStreamsResponse> BatchUpdateLiveStreamsAsync(BatchUpdateLiveStreamsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateLiveStreamsRequest(ref request, ref callSettings);
            return _callBatchUpdateLiveStreams.Async(request, callSettings);
        }

        /// <summary>
        /// Batch activates `LiveStream` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchActivateLiveStreamsResponse BatchActivateLiveStreams(BatchActivateLiveStreamsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchActivateLiveStreamsRequest(ref request, ref callSettings);
            return _callBatchActivateLiveStreams.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch activates `LiveStream` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchActivateLiveStreamsResponse> BatchActivateLiveStreamsAsync(BatchActivateLiveStreamsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchActivateLiveStreamsRequest(ref request, ref callSettings);
            return _callBatchActivateLiveStreams.Async(request, callSettings);
        }

        /// <summary>
        /// Batch pauses `LiveStream` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchPauseLiveStreamsResponse BatchPauseLiveStreams(BatchPauseLiveStreamsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchPauseLiveStreamsRequest(ref request, ref callSettings);
            return _callBatchPauseLiveStreams.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch pauses `LiveStream` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchPauseLiveStreamsResponse> BatchPauseLiveStreamsAsync(BatchPauseLiveStreamsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchPauseLiveStreamsRequest(ref request, ref callSettings);
            return _callBatchPauseLiveStreams.Async(request, callSettings);
        }

        /// <summary>
        /// Batch archives `LiveStream` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchArchiveLiveStreamsResponse BatchArchiveLiveStreams(BatchArchiveLiveStreamsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchArchiveLiveStreamsRequest(ref request, ref callSettings);
            return _callBatchArchiveLiveStreams.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch archives `LiveStream` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchArchiveLiveStreamsResponse> BatchArchiveLiveStreamsAsync(BatchArchiveLiveStreamsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchArchiveLiveStreamsRequest(ref request, ref callSettings);
            return _callBatchArchiveLiveStreams.Async(request, callSettings);
        }

        /// <summary>
        /// Batch pauses ads on `LiveStream` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchPauseAdsLiveStreamsResponse BatchPauseAdsLiveStreams(BatchPauseAdsLiveStreamsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchPauseAdsLiveStreamsRequest(ref request, ref callSettings);
            return _callBatchPauseAdsLiveStreams.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch pauses ads on `LiveStream` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchPauseAdsLiveStreamsResponse> BatchPauseAdsLiveStreamsAsync(BatchPauseAdsLiveStreamsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchPauseAdsLiveStreamsRequest(ref request, ref callSettings);
            return _callBatchPauseAdsLiveStreams.Async(request, callSettings);
        }

        /// <summary>
        /// Batch refreshes master playlists on `LiveStream` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchRefreshMasterPlaylistsResponse BatchRefreshMasterPlaylists(BatchRefreshMasterPlaylistsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchRefreshMasterPlaylistsRequest(ref request, ref callSettings);
            return _callBatchRefreshMasterPlaylists.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch refreshes master playlists on `LiveStream` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchRefreshMasterPlaylistsResponse> BatchRefreshMasterPlaylistsAsync(BatchRefreshMasterPlaylistsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchRefreshMasterPlaylistsRequest(ref request, ref callSettings);
            return _callBatchRefreshMasterPlaylists.Async(request, callSettings);
        }
    }

    public partial class ListLiveStreamsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListLiveStreamsResponse : gaxgrpc::IPageResponse<LiveStream>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<LiveStream> GetEnumerator() => LiveStreams.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
