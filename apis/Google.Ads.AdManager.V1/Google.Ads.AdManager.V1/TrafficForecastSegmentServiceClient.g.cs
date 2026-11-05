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
    /// <summary>Settings for <see cref="TrafficForecastSegmentServiceClient"/> instances.</summary>
    public sealed partial class TrafficForecastSegmentServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="TrafficForecastSegmentServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="TrafficForecastSegmentServiceSettings"/>.</returns>
        public static TrafficForecastSegmentServiceSettings GetDefault() => new TrafficForecastSegmentServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="TrafficForecastSegmentServiceSettings"/> object with default settings.
        /// </summary>
        public TrafficForecastSegmentServiceSettings()
        {
        }

        private TrafficForecastSegmentServiceSettings(TrafficForecastSegmentServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetTrafficForecastSegmentSettings = existing.GetTrafficForecastSegmentSettings;
            ListTrafficForecastSegmentsSettings = existing.ListTrafficForecastSegmentsSettings;
            CreateTrafficForecastSegmentSettings = existing.CreateTrafficForecastSegmentSettings;
            BatchCreateTrafficForecastSegmentsSettings = existing.BatchCreateTrafficForecastSegmentsSettings;
            UpdateTrafficForecastSegmentSettings = existing.UpdateTrafficForecastSegmentSettings;
            BatchUpdateTrafficForecastSegmentsSettings = existing.BatchUpdateTrafficForecastSegmentsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(TrafficForecastSegmentServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TrafficForecastSegmentServiceClient.GetTrafficForecastSegment</c> and
        /// <c>TrafficForecastSegmentServiceClient.GetTrafficForecastSegmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTrafficForecastSegmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TrafficForecastSegmentServiceClient.ListTrafficForecastSegments</c> and
        /// <c>TrafficForecastSegmentServiceClient.ListTrafficForecastSegmentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTrafficForecastSegmentsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TrafficForecastSegmentServiceClient.CreateTrafficForecastSegment</c> and
        /// <c>TrafficForecastSegmentServiceClient.CreateTrafficForecastSegmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTrafficForecastSegmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TrafficForecastSegmentServiceClient.BatchCreateTrafficForecastSegments</c> and
        /// <c>TrafficForecastSegmentServiceClient.BatchCreateTrafficForecastSegmentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchCreateTrafficForecastSegmentsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TrafficForecastSegmentServiceClient.UpdateTrafficForecastSegment</c> and
        /// <c>TrafficForecastSegmentServiceClient.UpdateTrafficForecastSegmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateTrafficForecastSegmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TrafficForecastSegmentServiceClient.BatchUpdateTrafficForecastSegments</c> and
        /// <c>TrafficForecastSegmentServiceClient.BatchUpdateTrafficForecastSegmentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchUpdateTrafficForecastSegmentsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="TrafficForecastSegmentServiceSettings"/> object.</returns>
        public TrafficForecastSegmentServiceSettings Clone() => new TrafficForecastSegmentServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="TrafficForecastSegmentServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class TrafficForecastSegmentServiceClientBuilder : gaxgrpc::ClientBuilderBase<TrafficForecastSegmentServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public TrafficForecastSegmentServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public TrafficForecastSegmentServiceClientBuilder() : base(TrafficForecastSegmentServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref TrafficForecastSegmentServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<TrafficForecastSegmentServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override TrafficForecastSegmentServiceClient Build()
        {
            TrafficForecastSegmentServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<TrafficForecastSegmentServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<TrafficForecastSegmentServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private TrafficForecastSegmentServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return TrafficForecastSegmentServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<TrafficForecastSegmentServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return TrafficForecastSegmentServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => TrafficForecastSegmentServiceClient.ChannelPool;
    }

    /// <summary>TrafficForecastSegmentService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `TrafficForecastSegment` objects.
    /// </remarks>
    public abstract partial class TrafficForecastSegmentServiceClient
    {
        /// <summary>
        /// The default endpoint for the TrafficForecastSegmentService service, which is a host of
        /// "admanager.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default TrafficForecastSegmentService scopes.</summary>
        /// <remarks>
        /// The default TrafficForecastSegmentService scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(TrafficForecastSegmentService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="TrafficForecastSegmentServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="TrafficForecastSegmentServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="TrafficForecastSegmentServiceClient"/>.</returns>
        public static stt::Task<TrafficForecastSegmentServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new TrafficForecastSegmentServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="TrafficForecastSegmentServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="TrafficForecastSegmentServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="TrafficForecastSegmentServiceClient"/>.</returns>
        public static TrafficForecastSegmentServiceClient Create() =>
            new TrafficForecastSegmentServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="TrafficForecastSegmentServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="TrafficForecastSegmentServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="TrafficForecastSegmentServiceClient"/>.</returns>
        internal static TrafficForecastSegmentServiceClient Create(grpccore::CallInvoker callInvoker, TrafficForecastSegmentServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            TrafficForecastSegmentService.TrafficForecastSegmentServiceClient grpcClient = new TrafficForecastSegmentService.TrafficForecastSegmentServiceClient(callInvoker);
            return new TrafficForecastSegmentServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC TrafficForecastSegmentService client</summary>
        public virtual TrafficForecastSegmentService.TrafficForecastSegmentServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `TrafficForecastSegment` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TrafficForecastSegment GetTrafficForecastSegment(GetTrafficForecastSegmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `TrafficForecastSegment` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TrafficForecastSegment> GetTrafficForecastSegmentAsync(GetTrafficForecastSegmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `TrafficForecastSegment` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TrafficForecastSegment> GetTrafficForecastSegmentAsync(GetTrafficForecastSegmentRequest request, st::CancellationToken cancellationToken) =>
            GetTrafficForecastSegmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `TrafficForecastSegment` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the TrafficForecastSegment.
        /// Format:
        /// `networks/{network_code}/trafficForecastSegments/{trafficForecastSegmentId}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TrafficForecastSegment GetTrafficForecastSegment(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTrafficForecastSegment(new GetTrafficForecastSegmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `TrafficForecastSegment` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the TrafficForecastSegment.
        /// Format:
        /// `networks/{network_code}/trafficForecastSegments/{trafficForecastSegmentId}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TrafficForecastSegment> GetTrafficForecastSegmentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTrafficForecastSegmentAsync(new GetTrafficForecastSegmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `TrafficForecastSegment` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the TrafficForecastSegment.
        /// Format:
        /// `networks/{network_code}/trafficForecastSegments/{trafficForecastSegmentId}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TrafficForecastSegment> GetTrafficForecastSegmentAsync(string name, st::CancellationToken cancellationToken) =>
            GetTrafficForecastSegmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `TrafficForecastSegment` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the TrafficForecastSegment.
        /// Format:
        /// `networks/{network_code}/trafficForecastSegments/{trafficForecastSegmentId}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TrafficForecastSegment GetTrafficForecastSegment(TrafficForecastSegmentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTrafficForecastSegment(new GetTrafficForecastSegmentRequest
            {
                TrafficForecastSegmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `TrafficForecastSegment` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the TrafficForecastSegment.
        /// Format:
        /// `networks/{network_code}/trafficForecastSegments/{trafficForecastSegmentId}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TrafficForecastSegment> GetTrafficForecastSegmentAsync(TrafficForecastSegmentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTrafficForecastSegmentAsync(new GetTrafficForecastSegmentRequest
            {
                TrafficForecastSegmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `TrafficForecastSegment` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the TrafficForecastSegment.
        /// Format:
        /// `networks/{network_code}/trafficForecastSegments/{trafficForecastSegmentId}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TrafficForecastSegment> GetTrafficForecastSegmentAsync(TrafficForecastSegmentName name, st::CancellationToken cancellationToken) =>
            GetTrafficForecastSegmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists `TrafficForecastSegment` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TrafficForecastSegment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTrafficForecastSegmentsResponse, TrafficForecastSegment> ListTrafficForecastSegments(ListTrafficForecastSegmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `TrafficForecastSegment` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TrafficForecastSegment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTrafficForecastSegmentsResponse, TrafficForecastSegment> ListTrafficForecastSegmentsAsync(ListTrafficForecastSegmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `TrafficForecastSegment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of
        /// TrafficForecastSegments. Format: `networks/{network_code}`
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
        /// <returns>A pageable sequence of <see cref="TrafficForecastSegment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTrafficForecastSegmentsResponse, TrafficForecastSegment> ListTrafficForecastSegments(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTrafficForecastSegmentsRequest request = new ListTrafficForecastSegmentsRequest
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
            return ListTrafficForecastSegments(request, callSettings);
        }

        /// <summary>
        /// Lists `TrafficForecastSegment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of
        /// TrafficForecastSegments. Format: `networks/{network_code}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="TrafficForecastSegment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTrafficForecastSegmentsResponse, TrafficForecastSegment> ListTrafficForecastSegmentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTrafficForecastSegmentsRequest request = new ListTrafficForecastSegmentsRequest
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
            return ListTrafficForecastSegmentsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists `TrafficForecastSegment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of
        /// TrafficForecastSegments. Format: `networks/{network_code}`
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
        /// <returns>A pageable sequence of <see cref="TrafficForecastSegment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTrafficForecastSegmentsResponse, TrafficForecastSegment> ListTrafficForecastSegments(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTrafficForecastSegmentsRequest request = new ListTrafficForecastSegmentsRequest
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
            return ListTrafficForecastSegments(request, callSettings);
        }

        /// <summary>
        /// Lists `TrafficForecastSegment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of
        /// TrafficForecastSegments. Format: `networks/{network_code}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="TrafficForecastSegment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTrafficForecastSegmentsResponse, TrafficForecastSegment> ListTrafficForecastSegmentsAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTrafficForecastSegmentsRequest request = new ListTrafficForecastSegmentsRequest
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
            return ListTrafficForecastSegmentsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a `TrafficForecastSegment` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TrafficForecastSegment CreateTrafficForecastSegment(CreateTrafficForecastSegmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `TrafficForecastSegment` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TrafficForecastSegment> CreateTrafficForecastSegmentAsync(CreateTrafficForecastSegmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `TrafficForecastSegment` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TrafficForecastSegment> CreateTrafficForecastSegmentAsync(CreateTrafficForecastSegmentRequest request, st::CancellationToken cancellationToken) =>
            CreateTrafficForecastSegmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `TrafficForecastSegment` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `TrafficForecastSegment` will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="trafficForecastSegment">
        /// Required. The `TrafficForecastSegment` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TrafficForecastSegment CreateTrafficForecastSegment(string parent, TrafficForecastSegment trafficForecastSegment, gaxgrpc::CallSettings callSettings = null) =>
            CreateTrafficForecastSegment(new CreateTrafficForecastSegmentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TrafficForecastSegment = gax::GaxPreconditions.CheckNotNull(trafficForecastSegment, nameof(trafficForecastSegment)),
            }, callSettings);

        /// <summary>
        /// Creates a `TrafficForecastSegment` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `TrafficForecastSegment` will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="trafficForecastSegment">
        /// Required. The `TrafficForecastSegment` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TrafficForecastSegment> CreateTrafficForecastSegmentAsync(string parent, TrafficForecastSegment trafficForecastSegment, gaxgrpc::CallSettings callSettings = null) =>
            CreateTrafficForecastSegmentAsync(new CreateTrafficForecastSegmentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TrafficForecastSegment = gax::GaxPreconditions.CheckNotNull(trafficForecastSegment, nameof(trafficForecastSegment)),
            }, callSettings);

        /// <summary>
        /// Creates a `TrafficForecastSegment` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `TrafficForecastSegment` will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="trafficForecastSegment">
        /// Required. The `TrafficForecastSegment` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TrafficForecastSegment> CreateTrafficForecastSegmentAsync(string parent, TrafficForecastSegment trafficForecastSegment, st::CancellationToken cancellationToken) =>
            CreateTrafficForecastSegmentAsync(parent, trafficForecastSegment, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `TrafficForecastSegment` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `TrafficForecastSegment` will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="trafficForecastSegment">
        /// Required. The `TrafficForecastSegment` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TrafficForecastSegment CreateTrafficForecastSegment(NetworkName parent, TrafficForecastSegment trafficForecastSegment, gaxgrpc::CallSettings callSettings = null) =>
            CreateTrafficForecastSegment(new CreateTrafficForecastSegmentRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TrafficForecastSegment = gax::GaxPreconditions.CheckNotNull(trafficForecastSegment, nameof(trafficForecastSegment)),
            }, callSettings);

        /// <summary>
        /// Creates a `TrafficForecastSegment` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `TrafficForecastSegment` will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="trafficForecastSegment">
        /// Required. The `TrafficForecastSegment` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TrafficForecastSegment> CreateTrafficForecastSegmentAsync(NetworkName parent, TrafficForecastSegment trafficForecastSegment, gaxgrpc::CallSettings callSettings = null) =>
            CreateTrafficForecastSegmentAsync(new CreateTrafficForecastSegmentRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TrafficForecastSegment = gax::GaxPreconditions.CheckNotNull(trafficForecastSegment, nameof(trafficForecastSegment)),
            }, callSettings);

        /// <summary>
        /// Creates a `TrafficForecastSegment` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `TrafficForecastSegment` will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="trafficForecastSegment">
        /// Required. The `TrafficForecastSegment` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TrafficForecastSegment> CreateTrafficForecastSegmentAsync(NetworkName parent, TrafficForecastSegment trafficForecastSegment, st::CancellationToken cancellationToken) =>
            CreateTrafficForecastSegmentAsync(parent, trafficForecastSegment, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates `TrafficForecastSegment` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateTrafficForecastSegmentsResponse BatchCreateTrafficForecastSegments(BatchCreateTrafficForecastSegmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates `TrafficForecastSegment` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateTrafficForecastSegmentsResponse> BatchCreateTrafficForecastSegmentsAsync(BatchCreateTrafficForecastSegmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates `TrafficForecastSegment` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateTrafficForecastSegmentsResponse> BatchCreateTrafficForecastSegmentsAsync(BatchCreateTrafficForecastSegmentsRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateTrafficForecastSegmentsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates `TrafficForecastSegment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `TrafficForecastSegments` will be
        /// created. Format: `networks/{network_code}` The parent field in the
        /// CreateTrafficForecastSegmentRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The `TrafficForecastSegment` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateTrafficForecastSegmentsResponse BatchCreateTrafficForecastSegments(string parent, scg::IEnumerable<CreateTrafficForecastSegmentRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateTrafficForecastSegments(new BatchCreateTrafficForecastSegmentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates `TrafficForecastSegment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `TrafficForecastSegments` will be
        /// created. Format: `networks/{network_code}` The parent field in the
        /// CreateTrafficForecastSegmentRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The `TrafficForecastSegment` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateTrafficForecastSegmentsResponse> BatchCreateTrafficForecastSegmentsAsync(string parent, scg::IEnumerable<CreateTrafficForecastSegmentRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateTrafficForecastSegmentsAsync(new BatchCreateTrafficForecastSegmentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates `TrafficForecastSegment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `TrafficForecastSegments` will be
        /// created. Format: `networks/{network_code}` The parent field in the
        /// CreateTrafficForecastSegmentRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The `TrafficForecastSegment` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateTrafficForecastSegmentsResponse> BatchCreateTrafficForecastSegmentsAsync(string parent, scg::IEnumerable<CreateTrafficForecastSegmentRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateTrafficForecastSegmentsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates `TrafficForecastSegment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `TrafficForecastSegments` will be
        /// created. Format: `networks/{network_code}` The parent field in the
        /// CreateTrafficForecastSegmentRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The `TrafficForecastSegment` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateTrafficForecastSegmentsResponse BatchCreateTrafficForecastSegments(NetworkName parent, scg::IEnumerable<CreateTrafficForecastSegmentRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateTrafficForecastSegments(new BatchCreateTrafficForecastSegmentsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates `TrafficForecastSegment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `TrafficForecastSegments` will be
        /// created. Format: `networks/{network_code}` The parent field in the
        /// CreateTrafficForecastSegmentRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The `TrafficForecastSegment` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateTrafficForecastSegmentsResponse> BatchCreateTrafficForecastSegmentsAsync(NetworkName parent, scg::IEnumerable<CreateTrafficForecastSegmentRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateTrafficForecastSegmentsAsync(new BatchCreateTrafficForecastSegmentsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates `TrafficForecastSegment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `TrafficForecastSegments` will be
        /// created. Format: `networks/{network_code}` The parent field in the
        /// CreateTrafficForecastSegmentRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The `TrafficForecastSegment` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateTrafficForecastSegmentsResponse> BatchCreateTrafficForecastSegmentsAsync(NetworkName parent, scg::IEnumerable<CreateTrafficForecastSegmentRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateTrafficForecastSegmentsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `TrafficForecastSegment` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TrafficForecastSegment UpdateTrafficForecastSegment(UpdateTrafficForecastSegmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `TrafficForecastSegment` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TrafficForecastSegment> UpdateTrafficForecastSegmentAsync(UpdateTrafficForecastSegmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `TrafficForecastSegment` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TrafficForecastSegment> UpdateTrafficForecastSegmentAsync(UpdateTrafficForecastSegmentRequest request, st::CancellationToken cancellationToken) =>
            UpdateTrafficForecastSegmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `TrafficForecastSegment` object.
        /// </summary>
        /// <param name="trafficForecastSegment">
        /// Required. The `TrafficForecastSegment` to update.
        /// 
        /// The `TrafficForecastSegment`'s `name` is used to identify the
        /// `TrafficForecastSegment` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TrafficForecastSegment UpdateTrafficForecastSegment(TrafficForecastSegment trafficForecastSegment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTrafficForecastSegment(new UpdateTrafficForecastSegmentRequest
            {
                TrafficForecastSegment = gax::GaxPreconditions.CheckNotNull(trafficForecastSegment, nameof(trafficForecastSegment)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a `TrafficForecastSegment` object.
        /// </summary>
        /// <param name="trafficForecastSegment">
        /// Required. The `TrafficForecastSegment` to update.
        /// 
        /// The `TrafficForecastSegment`'s `name` is used to identify the
        /// `TrafficForecastSegment` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TrafficForecastSegment> UpdateTrafficForecastSegmentAsync(TrafficForecastSegment trafficForecastSegment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTrafficForecastSegmentAsync(new UpdateTrafficForecastSegmentRequest
            {
                TrafficForecastSegment = gax::GaxPreconditions.CheckNotNull(trafficForecastSegment, nameof(trafficForecastSegment)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a `TrafficForecastSegment` object.
        /// </summary>
        /// <param name="trafficForecastSegment">
        /// Required. The `TrafficForecastSegment` to update.
        /// 
        /// The `TrafficForecastSegment`'s `name` is used to identify the
        /// `TrafficForecastSegment` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TrafficForecastSegment> UpdateTrafficForecastSegmentAsync(TrafficForecastSegment trafficForecastSegment, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateTrafficForecastSegmentAsync(trafficForecastSegment, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `TrafficForecastSegment` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateTrafficForecastSegmentsResponse BatchUpdateTrafficForecastSegments(BatchUpdateTrafficForecastSegmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch updates `TrafficForecastSegment` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateTrafficForecastSegmentsResponse> BatchUpdateTrafficForecastSegmentsAsync(BatchUpdateTrafficForecastSegmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch updates `TrafficForecastSegment` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateTrafficForecastSegmentsResponse> BatchUpdateTrafficForecastSegmentsAsync(BatchUpdateTrafficForecastSegmentsRequest request, st::CancellationToken cancellationToken) =>
            BatchUpdateTrafficForecastSegmentsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `TrafficForecastSegment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `TrafficForecastSegments` will be
        /// updated. Format: `networks/{network_code}` The parent field in the
        /// UpdateTrafficForecastSegmentRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The `TrafficForecastSegment` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateTrafficForecastSegmentsResponse BatchUpdateTrafficForecastSegments(string parent, scg::IEnumerable<UpdateTrafficForecastSegmentRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateTrafficForecastSegments(new BatchUpdateTrafficForecastSegmentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `TrafficForecastSegment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `TrafficForecastSegments` will be
        /// updated. Format: `networks/{network_code}` The parent field in the
        /// UpdateTrafficForecastSegmentRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The `TrafficForecastSegment` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateTrafficForecastSegmentsResponse> BatchUpdateTrafficForecastSegmentsAsync(string parent, scg::IEnumerable<UpdateTrafficForecastSegmentRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateTrafficForecastSegmentsAsync(new BatchUpdateTrafficForecastSegmentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `TrafficForecastSegment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `TrafficForecastSegments` will be
        /// updated. Format: `networks/{network_code}` The parent field in the
        /// UpdateTrafficForecastSegmentRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The `TrafficForecastSegment` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateTrafficForecastSegmentsResponse> BatchUpdateTrafficForecastSegmentsAsync(string parent, scg::IEnumerable<UpdateTrafficForecastSegmentRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateTrafficForecastSegmentsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `TrafficForecastSegment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `TrafficForecastSegments` will be
        /// updated. Format: `networks/{network_code}` The parent field in the
        /// UpdateTrafficForecastSegmentRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The `TrafficForecastSegment` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateTrafficForecastSegmentsResponse BatchUpdateTrafficForecastSegments(NetworkName parent, scg::IEnumerable<UpdateTrafficForecastSegmentRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateTrafficForecastSegments(new BatchUpdateTrafficForecastSegmentsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `TrafficForecastSegment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `TrafficForecastSegments` will be
        /// updated. Format: `networks/{network_code}` The parent field in the
        /// UpdateTrafficForecastSegmentRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The `TrafficForecastSegment` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateTrafficForecastSegmentsResponse> BatchUpdateTrafficForecastSegmentsAsync(NetworkName parent, scg::IEnumerable<UpdateTrafficForecastSegmentRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateTrafficForecastSegmentsAsync(new BatchUpdateTrafficForecastSegmentsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `TrafficForecastSegment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `TrafficForecastSegments` will be
        /// updated. Format: `networks/{network_code}` The parent field in the
        /// UpdateTrafficForecastSegmentRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The `TrafficForecastSegment` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateTrafficForecastSegmentsResponse> BatchUpdateTrafficForecastSegmentsAsync(NetworkName parent, scg::IEnumerable<UpdateTrafficForecastSegmentRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateTrafficForecastSegmentsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>TrafficForecastSegmentService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `TrafficForecastSegment` objects.
    /// </remarks>
    public sealed partial class TrafficForecastSegmentServiceClientImpl : TrafficForecastSegmentServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetTrafficForecastSegmentRequest, TrafficForecastSegment> _callGetTrafficForecastSegment;

        private readonly gaxgrpc::ApiCall<ListTrafficForecastSegmentsRequest, ListTrafficForecastSegmentsResponse> _callListTrafficForecastSegments;

        private readonly gaxgrpc::ApiCall<CreateTrafficForecastSegmentRequest, TrafficForecastSegment> _callCreateTrafficForecastSegment;

        private readonly gaxgrpc::ApiCall<BatchCreateTrafficForecastSegmentsRequest, BatchCreateTrafficForecastSegmentsResponse> _callBatchCreateTrafficForecastSegments;

        private readonly gaxgrpc::ApiCall<UpdateTrafficForecastSegmentRequest, TrafficForecastSegment> _callUpdateTrafficForecastSegment;

        private readonly gaxgrpc::ApiCall<BatchUpdateTrafficForecastSegmentsRequest, BatchUpdateTrafficForecastSegmentsResponse> _callBatchUpdateTrafficForecastSegments;

        /// <summary>
        /// Constructs a client wrapper for the TrafficForecastSegmentService service, with the specified gRPC client
        /// and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="TrafficForecastSegmentServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public TrafficForecastSegmentServiceClientImpl(TrafficForecastSegmentService.TrafficForecastSegmentServiceClient grpcClient, TrafficForecastSegmentServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            TrafficForecastSegmentServiceSettings effectiveSettings = settings ?? TrafficForecastSegmentServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetTrafficForecastSegment = clientHelper.BuildApiCall<GetTrafficForecastSegmentRequest, TrafficForecastSegment>("GetTrafficForecastSegment", grpcClient.GetTrafficForecastSegmentAsync, grpcClient.GetTrafficForecastSegment, effectiveSettings.GetTrafficForecastSegmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTrafficForecastSegment);
            Modify_GetTrafficForecastSegmentApiCall(ref _callGetTrafficForecastSegment);
            _callListTrafficForecastSegments = clientHelper.BuildApiCall<ListTrafficForecastSegmentsRequest, ListTrafficForecastSegmentsResponse>("ListTrafficForecastSegments", grpcClient.ListTrafficForecastSegmentsAsync, grpcClient.ListTrafficForecastSegments, effectiveSettings.ListTrafficForecastSegmentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTrafficForecastSegments);
            Modify_ListTrafficForecastSegmentsApiCall(ref _callListTrafficForecastSegments);
            _callCreateTrafficForecastSegment = clientHelper.BuildApiCall<CreateTrafficForecastSegmentRequest, TrafficForecastSegment>("CreateTrafficForecastSegment", grpcClient.CreateTrafficForecastSegmentAsync, grpcClient.CreateTrafficForecastSegment, effectiveSettings.CreateTrafficForecastSegmentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateTrafficForecastSegment);
            Modify_CreateTrafficForecastSegmentApiCall(ref _callCreateTrafficForecastSegment);
            _callBatchCreateTrafficForecastSegments = clientHelper.BuildApiCall<BatchCreateTrafficForecastSegmentsRequest, BatchCreateTrafficForecastSegmentsResponse>("BatchCreateTrafficForecastSegments", grpcClient.BatchCreateTrafficForecastSegmentsAsync, grpcClient.BatchCreateTrafficForecastSegments, effectiveSettings.BatchCreateTrafficForecastSegmentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCreateTrafficForecastSegments);
            Modify_BatchCreateTrafficForecastSegmentsApiCall(ref _callBatchCreateTrafficForecastSegments);
            _callUpdateTrafficForecastSegment = clientHelper.BuildApiCall<UpdateTrafficForecastSegmentRequest, TrafficForecastSegment>("UpdateTrafficForecastSegment", grpcClient.UpdateTrafficForecastSegmentAsync, grpcClient.UpdateTrafficForecastSegment, effectiveSettings.UpdateTrafficForecastSegmentSettings).WithGoogleRequestParam("traffic_forecast_segment.name", request => request.TrafficForecastSegment?.Name);
            Modify_ApiCall(ref _callUpdateTrafficForecastSegment);
            Modify_UpdateTrafficForecastSegmentApiCall(ref _callUpdateTrafficForecastSegment);
            _callBatchUpdateTrafficForecastSegments = clientHelper.BuildApiCall<BatchUpdateTrafficForecastSegmentsRequest, BatchUpdateTrafficForecastSegmentsResponse>("BatchUpdateTrafficForecastSegments", grpcClient.BatchUpdateTrafficForecastSegmentsAsync, grpcClient.BatchUpdateTrafficForecastSegments, effectiveSettings.BatchUpdateTrafficForecastSegmentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchUpdateTrafficForecastSegments);
            Modify_BatchUpdateTrafficForecastSegmentsApiCall(ref _callBatchUpdateTrafficForecastSegments);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetTrafficForecastSegmentApiCall(ref gaxgrpc::ApiCall<GetTrafficForecastSegmentRequest, TrafficForecastSegment> call);

        partial void Modify_ListTrafficForecastSegmentsApiCall(ref gaxgrpc::ApiCall<ListTrafficForecastSegmentsRequest, ListTrafficForecastSegmentsResponse> call);

        partial void Modify_CreateTrafficForecastSegmentApiCall(ref gaxgrpc::ApiCall<CreateTrafficForecastSegmentRequest, TrafficForecastSegment> call);

        partial void Modify_BatchCreateTrafficForecastSegmentsApiCall(ref gaxgrpc::ApiCall<BatchCreateTrafficForecastSegmentsRequest, BatchCreateTrafficForecastSegmentsResponse> call);

        partial void Modify_UpdateTrafficForecastSegmentApiCall(ref gaxgrpc::ApiCall<UpdateTrafficForecastSegmentRequest, TrafficForecastSegment> call);

        partial void Modify_BatchUpdateTrafficForecastSegmentsApiCall(ref gaxgrpc::ApiCall<BatchUpdateTrafficForecastSegmentsRequest, BatchUpdateTrafficForecastSegmentsResponse> call);

        partial void OnConstruction(TrafficForecastSegmentService.TrafficForecastSegmentServiceClient grpcClient, TrafficForecastSegmentServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC TrafficForecastSegmentService client</summary>
        public override TrafficForecastSegmentService.TrafficForecastSegmentServiceClient GrpcClient { get; }

        partial void Modify_GetTrafficForecastSegmentRequest(ref GetTrafficForecastSegmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTrafficForecastSegmentsRequest(ref ListTrafficForecastSegmentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateTrafficForecastSegmentRequest(ref CreateTrafficForecastSegmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateTrafficForecastSegmentsRequest(ref BatchCreateTrafficForecastSegmentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateTrafficForecastSegmentRequest(ref UpdateTrafficForecastSegmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUpdateTrafficForecastSegmentsRequest(ref BatchUpdateTrafficForecastSegmentsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves a `TrafficForecastSegment` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TrafficForecastSegment GetTrafficForecastSegment(GetTrafficForecastSegmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTrafficForecastSegmentRequest(ref request, ref callSettings);
            return _callGetTrafficForecastSegment.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a `TrafficForecastSegment` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TrafficForecastSegment> GetTrafficForecastSegmentAsync(GetTrafficForecastSegmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTrafficForecastSegmentRequest(ref request, ref callSettings);
            return _callGetTrafficForecastSegment.Async(request, callSettings);
        }

        /// <summary>
        /// Lists `TrafficForecastSegment` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TrafficForecastSegment"/> resources.</returns>
        public override gax::PagedEnumerable<ListTrafficForecastSegmentsResponse, TrafficForecastSegment> ListTrafficForecastSegments(ListTrafficForecastSegmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTrafficForecastSegmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTrafficForecastSegmentsRequest, ListTrafficForecastSegmentsResponse, TrafficForecastSegment>(_callListTrafficForecastSegments, request, callSettings);
        }

        /// <summary>
        /// Lists `TrafficForecastSegment` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TrafficForecastSegment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTrafficForecastSegmentsResponse, TrafficForecastSegment> ListTrafficForecastSegmentsAsync(ListTrafficForecastSegmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTrafficForecastSegmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTrafficForecastSegmentsRequest, ListTrafficForecastSegmentsResponse, TrafficForecastSegment>(_callListTrafficForecastSegments, request, callSettings);
        }

        /// <summary>
        /// Creates a `TrafficForecastSegment` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TrafficForecastSegment CreateTrafficForecastSegment(CreateTrafficForecastSegmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTrafficForecastSegmentRequest(ref request, ref callSettings);
            return _callCreateTrafficForecastSegment.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a `TrafficForecastSegment` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TrafficForecastSegment> CreateTrafficForecastSegmentAsync(CreateTrafficForecastSegmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTrafficForecastSegmentRequest(ref request, ref callSettings);
            return _callCreateTrafficForecastSegment.Async(request, callSettings);
        }

        /// <summary>
        /// Creates `TrafficForecastSegment` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchCreateTrafficForecastSegmentsResponse BatchCreateTrafficForecastSegments(BatchCreateTrafficForecastSegmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateTrafficForecastSegmentsRequest(ref request, ref callSettings);
            return _callBatchCreateTrafficForecastSegments.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates `TrafficForecastSegment` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchCreateTrafficForecastSegmentsResponse> BatchCreateTrafficForecastSegmentsAsync(BatchCreateTrafficForecastSegmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateTrafficForecastSegmentsRequest(ref request, ref callSettings);
            return _callBatchCreateTrafficForecastSegments.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a `TrafficForecastSegment` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TrafficForecastSegment UpdateTrafficForecastSegment(UpdateTrafficForecastSegmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTrafficForecastSegmentRequest(ref request, ref callSettings);
            return _callUpdateTrafficForecastSegment.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a `TrafficForecastSegment` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TrafficForecastSegment> UpdateTrafficForecastSegmentAsync(UpdateTrafficForecastSegmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTrafficForecastSegmentRequest(ref request, ref callSettings);
            return _callUpdateTrafficForecastSegment.Async(request, callSettings);
        }

        /// <summary>
        /// Batch updates `TrafficForecastSegment` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchUpdateTrafficForecastSegmentsResponse BatchUpdateTrafficForecastSegments(BatchUpdateTrafficForecastSegmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateTrafficForecastSegmentsRequest(ref request, ref callSettings);
            return _callBatchUpdateTrafficForecastSegments.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch updates `TrafficForecastSegment` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchUpdateTrafficForecastSegmentsResponse> BatchUpdateTrafficForecastSegmentsAsync(BatchUpdateTrafficForecastSegmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateTrafficForecastSegmentsRequest(ref request, ref callSettings);
            return _callBatchUpdateTrafficForecastSegments.Async(request, callSettings);
        }
    }

    public partial class ListTrafficForecastSegmentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTrafficForecastSegmentsResponse : gaxgrpc::IPageResponse<TrafficForecastSegment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<TrafficForecastSegment> GetEnumerator() => TrafficForecastSegments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
