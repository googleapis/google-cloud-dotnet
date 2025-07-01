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

namespace Google.Cloud.Compute.V1
{
    /// <summary>Settings for <see cref="ReservationSubBlocksClient"/> instances.</summary>
    public sealed partial class ReservationSubBlocksSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ReservationSubBlocksSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ReservationSubBlocksSettings"/>.</returns>
        public static ReservationSubBlocksSettings GetDefault() => new ReservationSubBlocksSettings();

        /// <summary>Constructs a new <see cref="ReservationSubBlocksSettings"/> object with default settings.</summary>
        public ReservationSubBlocksSettings()
        {
        }

        private ReservationSubBlocksSettings(ReservationSubBlocksSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetSettings = existing.GetSettings;
            ListSettings = existing.ListSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ReservationSubBlocksSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReservationSubBlocksClient.Get</c> and <c>ReservationSubBlocksClient.GetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReservationSubBlocksClient.List</c> and <c>ReservationSubBlocksClient.ListAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ReservationSubBlocksSettings"/> object.</returns>
        public ReservationSubBlocksSettings Clone() => new ReservationSubBlocksSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ReservationSubBlocksClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class ReservationSubBlocksClientBuilder : gaxgrpc::ClientBuilderBase<ReservationSubBlocksClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ReservationSubBlocksSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ReservationSubBlocksClientBuilder() : base(ReservationSubBlocksClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ReservationSubBlocksClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ReservationSubBlocksClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ReservationSubBlocksClient Build()
        {
            ReservationSubBlocksClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ReservationSubBlocksClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ReservationSubBlocksClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ReservationSubBlocksClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ReservationSubBlocksClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ReservationSubBlocksClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ReservationSubBlocksClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ReservationSubBlocksClient.ChannelPool;
    }

    /// <summary>ReservationSubBlocks client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The ReservationSubBlocks API.
    /// </remarks>
    public abstract partial class ReservationSubBlocksClient
    {
        /// <summary>
        /// The default endpoint for the ReservationSubBlocks service, which is a host of "compute.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default ReservationSubBlocks scopes.</summary>
        /// <remarks>
        /// The default ReservationSubBlocks scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/compute.readonly</description></item>
        /// <item><description>https://www.googleapis.com/auth/compute</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/compute.readonly",
            "https://www.googleapis.com/auth/compute",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ReservationSubBlocks.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ReservationSubBlocksClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ReservationSubBlocksClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ReservationSubBlocksClient"/>.</returns>
        public static stt::Task<ReservationSubBlocksClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ReservationSubBlocksClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ReservationSubBlocksClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="ReservationSubBlocksClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ReservationSubBlocksClient"/>.</returns>
        public static ReservationSubBlocksClient Create() => new ReservationSubBlocksClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ReservationSubBlocksClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ReservationSubBlocksSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ReservationSubBlocksClient"/>.</returns>
        internal static ReservationSubBlocksClient Create(grpccore::CallInvoker callInvoker, ReservationSubBlocksSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ReservationSubBlocks.ReservationSubBlocksClient grpcClient = new ReservationSubBlocks.ReservationSubBlocksClient(callInvoker);
            return new ReservationSubBlocksClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ReservationSubBlocks client</summary>
        public virtual ReservationSubBlocks.ReservationSubBlocksClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves information about the specified reservation subBlock.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReservationSubBlocksGetResponse Get(GetReservationSubBlockRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves information about the specified reservation subBlock.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReservationSubBlocksGetResponse> GetAsync(GetReservationSubBlockRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves information about the specified reservation subBlock.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReservationSubBlocksGetResponse> GetAsync(GetReservationSubBlockRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves information about the specified reservation subBlock.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// Name of the zone for this request. Zone name should conform to RFC1035.
        /// </param>
        /// <param name="parentName">
        /// The name of the parent reservation and parent block. In the format of reservations/{reservation_name}/reservationBlocks/{reservation_block_name}
        /// </param>
        /// <param name="reservationSubBlock">
        /// The name of the reservation subBlock. Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReservationSubBlocksGetResponse Get(string project, string zone, string parentName, string reservationSubBlock, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetReservationSubBlockRequest
            {
                ParentName = gax::GaxPreconditions.CheckNotNullOrEmpty(parentName, nameof(parentName)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                ReservationSubBlock = gax::GaxPreconditions.CheckNotNullOrEmpty(reservationSubBlock, nameof(reservationSubBlock)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Retrieves information about the specified reservation subBlock.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// Name of the zone for this request. Zone name should conform to RFC1035.
        /// </param>
        /// <param name="parentName">
        /// The name of the parent reservation and parent block. In the format of reservations/{reservation_name}/reservationBlocks/{reservation_block_name}
        /// </param>
        /// <param name="reservationSubBlock">
        /// The name of the reservation subBlock. Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReservationSubBlocksGetResponse> GetAsync(string project, string zone, string parentName, string reservationSubBlock, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetReservationSubBlockRequest
            {
                ParentName = gax::GaxPreconditions.CheckNotNullOrEmpty(parentName, nameof(parentName)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                ReservationSubBlock = gax::GaxPreconditions.CheckNotNullOrEmpty(reservationSubBlock, nameof(reservationSubBlock)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Retrieves information about the specified reservation subBlock.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// Name of the zone for this request. Zone name should conform to RFC1035.
        /// </param>
        /// <param name="parentName">
        /// The name of the parent reservation and parent block. In the format of reservations/{reservation_name}/reservationBlocks/{reservation_block_name}
        /// </param>
        /// <param name="reservationSubBlock">
        /// The name of the reservation subBlock. Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReservationSubBlocksGetResponse> GetAsync(string project, string zone, string parentName, string reservationSubBlock, st::CancellationToken cancellationToken) =>
            GetAsync(project, zone, parentName, reservationSubBlock, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a list of reservation subBlocks under a single reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ReservationSubBlock"/> resources.</returns>
        public virtual gax::PagedEnumerable<ReservationSubBlocksListResponse, ReservationSubBlock> List(ListReservationSubBlocksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of reservation subBlocks under a single reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ReservationSubBlock"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ReservationSubBlocksListResponse, ReservationSubBlock> ListAsync(ListReservationSubBlocksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of reservation subBlocks under a single reservation.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// Name of the zone for this request. Zone name should conform to RFC1035.
        /// </param>
        /// <param name="parentName">
        /// The name of the parent reservation and parent block. In the format of reservations/{reservation_name}/reservationBlocks/{reservation_block_name}
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
        /// <returns>A pageable sequence of <see cref="ReservationSubBlock"/> resources.</returns>
        public virtual gax::PagedEnumerable<ReservationSubBlocksListResponse, ReservationSubBlock> List(string project, string zone, string parentName, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReservationSubBlocksRequest request = new ListReservationSubBlocksRequest
            {
                ParentName = gax::GaxPreconditions.CheckNotNullOrEmpty(parentName, nameof(parentName)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return List(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of reservation subBlocks under a single reservation.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// Name of the zone for this request. Zone name should conform to RFC1035.
        /// </param>
        /// <param name="parentName">
        /// The name of the parent reservation and parent block. In the format of reservations/{reservation_name}/reservationBlocks/{reservation_block_name}
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
        /// <returns>A pageable asynchronous sequence of <see cref="ReservationSubBlock"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ReservationSubBlocksListResponse, ReservationSubBlock> ListAsync(string project, string zone, string parentName, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReservationSubBlocksRequest request = new ListReservationSubBlocksRequest
            {
                ParentName = gax::GaxPreconditions.CheckNotNullOrEmpty(parentName, nameof(parentName)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAsync(request, callSettings);
        }
    }

    /// <summary>ReservationSubBlocks client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The ReservationSubBlocks API.
    /// </remarks>
    public sealed partial class ReservationSubBlocksClientImpl : ReservationSubBlocksClient
    {
        private readonly gaxgrpc::ApiCall<GetReservationSubBlockRequest, ReservationSubBlocksGetResponse> _callGet;

        private readonly gaxgrpc::ApiCall<ListReservationSubBlocksRequest, ReservationSubBlocksListResponse> _callList;

        /// <summary>
        /// Constructs a client wrapper for the ReservationSubBlocks service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ReservationSubBlocksSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ReservationSubBlocksClientImpl(ReservationSubBlocks.ReservationSubBlocksClient grpcClient, ReservationSubBlocksSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ReservationSubBlocksSettings effectiveSettings = settings ?? ReservationSubBlocksSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGet = clientHelper.BuildApiCall<GetReservationSubBlockRequest, ReservationSubBlocksGetResponse>("Get", grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("parent_name", request => request.ParentName).WithGoogleRequestParam("reservation_sub_block", request => request.ReservationSubBlock);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callList = clientHelper.BuildApiCall<ListReservationSubBlocksRequest, ReservationSubBlocksListResponse>("List", grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("parent_name", request => request.ParentName);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetReservationSubBlockRequest, ReservationSubBlocksGetResponse> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListReservationSubBlocksRequest, ReservationSubBlocksListResponse> call);

        partial void OnConstruction(ReservationSubBlocks.ReservationSubBlocksClient grpcClient, ReservationSubBlocksSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ReservationSubBlocks client</summary>
        public override ReservationSubBlocks.ReservationSubBlocksClient GrpcClient { get; }

        partial void Modify_GetReservationSubBlockRequest(ref GetReservationSubBlockRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListReservationSubBlocksRequest(ref ListReservationSubBlocksRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves information about the specified reservation subBlock.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReservationSubBlocksGetResponse Get(GetReservationSubBlockRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReservationSubBlockRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves information about the specified reservation subBlock.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReservationSubBlocksGetResponse> GetAsync(GetReservationSubBlockRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReservationSubBlockRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of reservation subBlocks under a single reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ReservationSubBlock"/> resources.</returns>
        public override gax::PagedEnumerable<ReservationSubBlocksListResponse, ReservationSubBlock> List(ListReservationSubBlocksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReservationSubBlocksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListReservationSubBlocksRequest, ReservationSubBlocksListResponse, ReservationSubBlock>(_callList, request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of reservation subBlocks under a single reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ReservationSubBlock"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ReservationSubBlocksListResponse, ReservationSubBlock> ListAsync(ListReservationSubBlocksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReservationSubBlocksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListReservationSubBlocksRequest, ReservationSubBlocksListResponse, ReservationSubBlock>(_callList, request, callSettings);
        }
    }

    public partial class ListReservationSubBlocksRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class ReservationSubBlocksListResponse : gaxgrpc::IPageResponse<ReservationSubBlock>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ReservationSubBlock> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
