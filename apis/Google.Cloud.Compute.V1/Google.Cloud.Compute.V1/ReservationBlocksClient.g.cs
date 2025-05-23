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
using lro = Google.LongRunning;
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
    /// <summary>Settings for <see cref="ReservationBlocksClient"/> instances.</summary>
    public sealed partial class ReservationBlocksSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ReservationBlocksSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ReservationBlocksSettings"/>.</returns>
        public static ReservationBlocksSettings GetDefault() => new ReservationBlocksSettings();

        /// <summary>Constructs a new <see cref="ReservationBlocksSettings"/> object with default settings.</summary>
        public ReservationBlocksSettings()
        {
        }

        private ReservationBlocksSettings(ReservationBlocksSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetSettings = existing.GetSettings;
            ListSettings = existing.ListSettings;
            PerformMaintenanceSettings = existing.PerformMaintenanceSettings;
            PerformMaintenanceOperationsSettings = existing.PerformMaintenanceOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(ReservationBlocksSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ReservationBlocksClient.Get</c>
        ///  and <c>ReservationBlocksClient.GetAsync</c>.
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
        /// <c>ReservationBlocksClient.List</c> and <c>ReservationBlocksClient.ListAsync</c>.
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

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReservationBlocksClient.PerformMaintenance</c> and <c>ReservationBlocksClient.PerformMaintenanceAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PerformMaintenanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ReservationBlocksClient.PerformMaintenance</c> and
        /// <c>ReservationBlocksClient.PerformMaintenanceAsync</c>.
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
        public lro::OperationsSettings PerformMaintenanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ReservationBlocksSettings"/> object.</returns>
        public ReservationBlocksSettings Clone() => new ReservationBlocksSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ReservationBlocksClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class ReservationBlocksClientBuilder : gaxgrpc::ClientBuilderBase<ReservationBlocksClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ReservationBlocksSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ReservationBlocksClientBuilder() : base(ReservationBlocksClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ReservationBlocksClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ReservationBlocksClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ReservationBlocksClient Build()
        {
            ReservationBlocksClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ReservationBlocksClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ReservationBlocksClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ReservationBlocksClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ReservationBlocksClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ReservationBlocksClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ReservationBlocksClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ReservationBlocksClient.ChannelPool;
    }

    /// <summary>ReservationBlocks client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The ReservationBlocks API.
    /// </remarks>
    public abstract partial class ReservationBlocksClient
    {
        /// <summary>
        /// The default endpoint for the ReservationBlocks service, which is a host of "compute.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default ReservationBlocks scopes.</summary>
        /// <remarks>
        /// The default ReservationBlocks scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/compute</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/compute",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ReservationBlocks.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ReservationBlocksClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ReservationBlocksClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ReservationBlocksClient"/>.</returns>
        public static stt::Task<ReservationBlocksClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ReservationBlocksClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ReservationBlocksClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ReservationBlocksClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ReservationBlocksClient"/>.</returns>
        public static ReservationBlocksClient Create() => new ReservationBlocksClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ReservationBlocksClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ReservationBlocksSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ReservationBlocksClient"/>.</returns>
        internal static ReservationBlocksClient Create(grpccore::CallInvoker callInvoker, ReservationBlocksSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ReservationBlocks.ReservationBlocksClient grpcClient = new ReservationBlocks.ReservationBlocksClient(callInvoker);
            return new ReservationBlocksClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ReservationBlocks client</summary>
        public virtual ReservationBlocks.ReservationBlocksClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves information about the specified reservation block.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReservationBlocksGetResponse Get(GetReservationBlockRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves information about the specified reservation block.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReservationBlocksGetResponse> GetAsync(GetReservationBlockRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves information about the specified reservation block.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReservationBlocksGetResponse> GetAsync(GetReservationBlockRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves information about the specified reservation block.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// Name of the zone for this request. Zone name should conform to RFC1035.
        /// </param>
        /// <param name="reservation">
        /// The name of the reservation. Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="reservationBlock">
        /// The name of the reservation block. Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReservationBlocksGetResponse Get(string project, string zone, string reservation, string reservationBlock, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetReservationBlockRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Reservation = gax::GaxPreconditions.CheckNotNullOrEmpty(reservation, nameof(reservation)),
                ReservationBlock = gax::GaxPreconditions.CheckNotNullOrEmpty(reservationBlock, nameof(reservationBlock)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Retrieves information about the specified reservation block.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// Name of the zone for this request. Zone name should conform to RFC1035.
        /// </param>
        /// <param name="reservation">
        /// The name of the reservation. Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="reservationBlock">
        /// The name of the reservation block. Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReservationBlocksGetResponse> GetAsync(string project, string zone, string reservation, string reservationBlock, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetReservationBlockRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Reservation = gax::GaxPreconditions.CheckNotNullOrEmpty(reservation, nameof(reservation)),
                ReservationBlock = gax::GaxPreconditions.CheckNotNullOrEmpty(reservationBlock, nameof(reservationBlock)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Retrieves information about the specified reservation block.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// Name of the zone for this request. Zone name should conform to RFC1035.
        /// </param>
        /// <param name="reservation">
        /// The name of the reservation. Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="reservationBlock">
        /// The name of the reservation block. Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReservationBlocksGetResponse> GetAsync(string project, string zone, string reservation, string reservationBlock, st::CancellationToken cancellationToken) =>
            GetAsync(project, zone, reservation, reservationBlock, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a list of reservation blocks under a single reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ReservationBlock"/> resources.</returns>
        public virtual gax::PagedEnumerable<ReservationBlocksListResponse, ReservationBlock> List(ListReservationBlocksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of reservation blocks under a single reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ReservationBlock"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ReservationBlocksListResponse, ReservationBlock> ListAsync(ListReservationBlocksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of reservation blocks under a single reservation.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// Name of the zone for this request. Zone name should conform to RFC1035.
        /// </param>
        /// <param name="reservation">
        /// The name of the reservation. Name should conform to RFC1035 or be a resource ID.
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
        /// <returns>A pageable sequence of <see cref="ReservationBlock"/> resources.</returns>
        public virtual gax::PagedEnumerable<ReservationBlocksListResponse, ReservationBlock> List(string project, string zone, string reservation, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReservationBlocksRequest request = new ListReservationBlocksRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Reservation = gax::GaxPreconditions.CheckNotNullOrEmpty(reservation, nameof(reservation)),
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
        /// Retrieves a list of reservation blocks under a single reservation.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// Name of the zone for this request. Zone name should conform to RFC1035.
        /// </param>
        /// <param name="reservation">
        /// The name of the reservation. Name should conform to RFC1035 or be a resource ID.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ReservationBlock"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ReservationBlocksListResponse, ReservationBlock> ListAsync(string project, string zone, string reservation, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReservationBlocksRequest request = new ListReservationBlocksRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Reservation = gax::GaxPreconditions.CheckNotNullOrEmpty(reservation, nameof(reservation)),
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

        /// <summary>
        /// Allows customers to perform maintenance on a reservation block
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> PerformMaintenance(PerformMaintenanceReservationBlockRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Allows customers to perform maintenance on a reservation block
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PerformMaintenanceAsync(PerformMaintenanceReservationBlockRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Allows customers to perform maintenance on a reservation block
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PerformMaintenanceAsync(PerformMaintenanceReservationBlockRequest request, st::CancellationToken cancellationToken) =>
            PerformMaintenanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>PerformMaintenance</c>.</summary>
        public virtual lro::OperationsClient PerformMaintenanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>PerformMaintenance</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOncePerformMaintenance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PerformMaintenanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>PerformMaintenance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOncePerformMaintenanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PerformMaintenanceOperationsClient, callSettings);

        /// <summary>
        /// Allows customers to perform maintenance on a reservation block
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// Name of the zone for this request. Zone name should conform to RFC1035.
        /// </param>
        /// <param name="reservation">
        /// The name of the reservation. Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="reservationBlock">
        /// The name of the reservation block. Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="reservationsBlocksPerformMaintenanceRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> PerformMaintenance(string project, string zone, string reservation, string reservationBlock, ReservationsBlocksPerformMaintenanceRequest reservationsBlocksPerformMaintenanceRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            PerformMaintenance(new PerformMaintenanceReservationBlockRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Reservation = gax::GaxPreconditions.CheckNotNullOrEmpty(reservation, nameof(reservation)),
                ReservationBlock = gax::GaxPreconditions.CheckNotNullOrEmpty(reservationBlock, nameof(reservationBlock)),
                ReservationsBlocksPerformMaintenanceRequestResource = gax::GaxPreconditions.CheckNotNull(reservationsBlocksPerformMaintenanceRequestResource, nameof(reservationsBlocksPerformMaintenanceRequestResource)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Allows customers to perform maintenance on a reservation block
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// Name of the zone for this request. Zone name should conform to RFC1035.
        /// </param>
        /// <param name="reservation">
        /// The name of the reservation. Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="reservationBlock">
        /// The name of the reservation block. Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="reservationsBlocksPerformMaintenanceRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PerformMaintenanceAsync(string project, string zone, string reservation, string reservationBlock, ReservationsBlocksPerformMaintenanceRequest reservationsBlocksPerformMaintenanceRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            PerformMaintenanceAsync(new PerformMaintenanceReservationBlockRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Reservation = gax::GaxPreconditions.CheckNotNullOrEmpty(reservation, nameof(reservation)),
                ReservationBlock = gax::GaxPreconditions.CheckNotNullOrEmpty(reservationBlock, nameof(reservationBlock)),
                ReservationsBlocksPerformMaintenanceRequestResource = gax::GaxPreconditions.CheckNotNull(reservationsBlocksPerformMaintenanceRequestResource, nameof(reservationsBlocksPerformMaintenanceRequestResource)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Allows customers to perform maintenance on a reservation block
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// Name of the zone for this request. Zone name should conform to RFC1035.
        /// </param>
        /// <param name="reservation">
        /// The name of the reservation. Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="reservationBlock">
        /// The name of the reservation block. Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="reservationsBlocksPerformMaintenanceRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PerformMaintenanceAsync(string project, string zone, string reservation, string reservationBlock, ReservationsBlocksPerformMaintenanceRequest reservationsBlocksPerformMaintenanceRequestResource, st::CancellationToken cancellationToken) =>
            PerformMaintenanceAsync(project, zone, reservation, reservationBlock, reservationsBlocksPerformMaintenanceRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ReservationBlocks client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The ReservationBlocks API.
    /// </remarks>
    public sealed partial class ReservationBlocksClientImpl : ReservationBlocksClient
    {
        private readonly gaxgrpc::ApiCall<GetReservationBlockRequest, ReservationBlocksGetResponse> _callGet;

        private readonly gaxgrpc::ApiCall<ListReservationBlocksRequest, ReservationBlocksListResponse> _callList;

        private readonly gaxgrpc::ApiCall<PerformMaintenanceReservationBlockRequest, Operation> _callPerformMaintenance;

        /// <summary>
        /// Constructs a client wrapper for the ReservationBlocks service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ReservationBlocksSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ReservationBlocksClientImpl(ReservationBlocks.ReservationBlocksClient grpcClient, ReservationBlocksSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ReservationBlocksSettings effectiveSettings = settings ?? ReservationBlocksSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            PerformMaintenanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.PerformMaintenanceOperationsSettings, logger);
            _callGet = clientHelper.BuildApiCall<GetReservationBlockRequest, ReservationBlocksGetResponse>("Get", grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("reservation", request => request.Reservation).WithGoogleRequestParam("reservation_block", request => request.ReservationBlock);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callList = clientHelper.BuildApiCall<ListReservationBlocksRequest, ReservationBlocksListResponse>("List", grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("reservation", request => request.Reservation);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            _callPerformMaintenance = clientHelper.BuildApiCall<PerformMaintenanceReservationBlockRequest, Operation>("PerformMaintenance", grpcClient.PerformMaintenanceAsync, grpcClient.PerformMaintenance, effectiveSettings.PerformMaintenanceSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("reservation", request => request.Reservation).WithGoogleRequestParam("reservation_block", request => request.ReservationBlock);
            Modify_ApiCall(ref _callPerformMaintenance);
            Modify_PerformMaintenanceApiCall(ref _callPerformMaintenance);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetReservationBlockRequest, ReservationBlocksGetResponse> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListReservationBlocksRequest, ReservationBlocksListResponse> call);

        partial void Modify_PerformMaintenanceApiCall(ref gaxgrpc::ApiCall<PerformMaintenanceReservationBlockRequest, Operation> call);

        partial void OnConstruction(ReservationBlocks.ReservationBlocksClient grpcClient, ReservationBlocksSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ReservationBlocks client</summary>
        public override ReservationBlocks.ReservationBlocksClient GrpcClient { get; }

        partial void Modify_GetReservationBlockRequest(ref GetReservationBlockRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListReservationBlocksRequest(ref ListReservationBlocksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PerformMaintenanceReservationBlockRequest(ref PerformMaintenanceReservationBlockRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves information about the specified reservation block.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReservationBlocksGetResponse Get(GetReservationBlockRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReservationBlockRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves information about the specified reservation block.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReservationBlocksGetResponse> GetAsync(GetReservationBlockRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReservationBlockRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of reservation blocks under a single reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ReservationBlock"/> resources.</returns>
        public override gax::PagedEnumerable<ReservationBlocksListResponse, ReservationBlock> List(ListReservationBlocksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReservationBlocksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListReservationBlocksRequest, ReservationBlocksListResponse, ReservationBlock>(_callList, request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of reservation blocks under a single reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ReservationBlock"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ReservationBlocksListResponse, ReservationBlock> ListAsync(ListReservationBlocksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReservationBlocksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListReservationBlocksRequest, ReservationBlocksListResponse, ReservationBlock>(_callList, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>PerformMaintenance</c>.</summary>
        public override lro::OperationsClient PerformMaintenanceOperationsClient { get; }

        /// <summary>
        /// Allows customers to perform maintenance on a reservation block
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> PerformMaintenance(PerformMaintenanceReservationBlockRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PerformMaintenanceReservationBlockRequest(ref request, ref callSettings);
            Operation response = _callPerformMaintenance.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), PerformMaintenanceOperationsClient);
        }

        /// <summary>
        /// Allows customers to perform maintenance on a reservation block
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> PerformMaintenanceAsync(PerformMaintenanceReservationBlockRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PerformMaintenanceReservationBlockRequest(ref request, ref callSettings);
            Operation response = await _callPerformMaintenance.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), PerformMaintenanceOperationsClient);
        }
    }

    public partial class ListReservationBlocksRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class ReservationBlocksListResponse : gaxgrpc::IPageResponse<ReservationBlock>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ReservationBlock> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ReservationBlocks
    {
        public partial class ReservationBlocksClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client, delegating to ZoneOperations.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClientForZoneOperations() =>
                ZoneOperations.ZoneOperationsClient.CreateOperationsClient(CallInvoker);
        }
    }
}
