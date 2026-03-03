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
    /// <summary>Settings for <see cref="ReservationSlotsClient"/> instances.</summary>
    public sealed partial class ReservationSlotsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ReservationSlotsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ReservationSlotsSettings"/>.</returns>
        public static ReservationSlotsSettings GetDefault() => new ReservationSlotsSettings();

        /// <summary>Constructs a new <see cref="ReservationSlotsSettings"/> object with default settings.</summary>
        public ReservationSlotsSettings()
        {
        }

        private ReservationSlotsSettings(ReservationSlotsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetSettings = existing.GetSettings;
            ListSettings = existing.ListSettings;
            UpdateSettings = existing.UpdateSettings;
            UpdateOperationsSettings = existing.UpdateOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(ReservationSlotsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ReservationSlotsClient.Get</c>
        ///  and <c>ReservationSlotsClient.GetAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ReservationSlotsClient.List</c>
        ///  and <c>ReservationSlotsClient.ListAsync</c>.
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
        /// <c>ReservationSlotsClient.Update</c> and <c>ReservationSlotsClient.UpdateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ReservationSlotsClient.Update</c> and
        /// <c>ReservationSlotsClient.UpdateAsync</c>.
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
        public lro::OperationsSettings UpdateOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ReservationSlotsSettings"/> object.</returns>
        public ReservationSlotsSettings Clone() => new ReservationSlotsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ReservationSlotsClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class ReservationSlotsClientBuilder : gaxgrpc::ClientBuilderBase<ReservationSlotsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ReservationSlotsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ReservationSlotsClientBuilder() : base(ReservationSlotsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ReservationSlotsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ReservationSlotsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ReservationSlotsClient Build()
        {
            ReservationSlotsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ReservationSlotsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ReservationSlotsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ReservationSlotsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ReservationSlotsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ReservationSlotsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ReservationSlotsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ReservationSlotsClient.ChannelPool;
    }

    /// <summary>ReservationSlots client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The ReservationSlots API.
    /// </remarks>
    public abstract partial class ReservationSlotsClient
    {
        /// <summary>
        /// The default endpoint for the ReservationSlots service, which is a host of "compute.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default ReservationSlots scopes.</summary>
        /// <remarks>
        /// The default ReservationSlots scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ReservationSlots.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ReservationSlotsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ReservationSlotsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ReservationSlotsClient"/>.</returns>
        public static stt::Task<ReservationSlotsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ReservationSlotsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ReservationSlotsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ReservationSlotsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ReservationSlotsClient"/>.</returns>
        public static ReservationSlotsClient Create() => new ReservationSlotsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ReservationSlotsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ReservationSlotsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ReservationSlotsClient"/>.</returns>
        internal static ReservationSlotsClient Create(grpccore::CallInvoker callInvoker, ReservationSlotsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ReservationSlots.ReservationSlotsClient grpcClient = new ReservationSlots.ReservationSlotsClient(callInvoker);
            return new ReservationSlotsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ReservationSlots client</summary>
        public virtual ReservationSlots.ReservationSlotsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves information about the specified reservation slot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReservationSlotsGetResponse Get(GetReservationSlotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves information about the specified reservation slot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReservationSlotsGetResponse> GetAsync(GetReservationSlotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves information about the specified reservation slot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReservationSlotsGetResponse> GetAsync(GetReservationSlotRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves information about the specified reservation slot.
        /// </summary>
        /// <param name="project">
        /// The project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request, formatted as RFC1035.
        /// </param>
        /// <param name="parentName">
        /// The name of the parent reservation and parent block, formatted as
        /// reservations/{reservation_name}/reservationBlocks/{reservation_block_name}/reservationSubBlocks/{reservation_sub_block_name}
        /// </param>
        /// <param name="reservationSlot">
        /// The name of the reservation slot, formatted as RFC1035 or a resource ID
        /// number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReservationSlotsGetResponse Get(string project, string zone, string parentName, string reservationSlot, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetReservationSlotRequest
            {
                ParentName = gax::GaxPreconditions.CheckNotNullOrEmpty(parentName, nameof(parentName)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                ReservationSlot = gax::GaxPreconditions.CheckNotNullOrEmpty(reservationSlot, nameof(reservationSlot)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Retrieves information about the specified reservation slot.
        /// </summary>
        /// <param name="project">
        /// The project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request, formatted as RFC1035.
        /// </param>
        /// <param name="parentName">
        /// The name of the parent reservation and parent block, formatted as
        /// reservations/{reservation_name}/reservationBlocks/{reservation_block_name}/reservationSubBlocks/{reservation_sub_block_name}
        /// </param>
        /// <param name="reservationSlot">
        /// The name of the reservation slot, formatted as RFC1035 or a resource ID
        /// number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReservationSlotsGetResponse> GetAsync(string project, string zone, string parentName, string reservationSlot, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetReservationSlotRequest
            {
                ParentName = gax::GaxPreconditions.CheckNotNullOrEmpty(parentName, nameof(parentName)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                ReservationSlot = gax::GaxPreconditions.CheckNotNullOrEmpty(reservationSlot, nameof(reservationSlot)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Retrieves information about the specified reservation slot.
        /// </summary>
        /// <param name="project">
        /// The project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request, formatted as RFC1035.
        /// </param>
        /// <param name="parentName">
        /// The name of the parent reservation and parent block, formatted as
        /// reservations/{reservation_name}/reservationBlocks/{reservation_block_name}/reservationSubBlocks/{reservation_sub_block_name}
        /// </param>
        /// <param name="reservationSlot">
        /// The name of the reservation slot, formatted as RFC1035 or a resource ID
        /// number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReservationSlotsGetResponse> GetAsync(string project, string zone, string parentName, string reservationSlot, st::CancellationToken cancellationToken) =>
            GetAsync(project, zone, parentName, reservationSlot, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a list of reservation slots under a single reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ReservationSlot"/> resources.</returns>
        public virtual gax::PagedEnumerable<ReservationSlotsListResponse, ReservationSlot> List(ListReservationSlotsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of reservation slots under a single reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ReservationSlot"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ReservationSlotsListResponse, ReservationSlot> ListAsync(ListReservationSlotsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of reservation slots under a single reservation.
        /// </summary>
        /// <param name="project">
        /// The project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request, formatted as RFC1035.
        /// </param>
        /// <param name="parentName">
        /// The name of the parent reservation and parent block, formatted as
        /// reservations/{reservation_name}/reservationBlocks/{reservation_block_name}/reservationSubBlocks/{reservation_sub_block_name}
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
        /// <returns>A pageable sequence of <see cref="ReservationSlot"/> resources.</returns>
        public virtual gax::PagedEnumerable<ReservationSlotsListResponse, ReservationSlot> List(string project, string zone, string parentName, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReservationSlotsRequest request = new ListReservationSlotsRequest
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
        /// Retrieves a list of reservation slots under a single reservation.
        /// </summary>
        /// <param name="project">
        /// The project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request, formatted as RFC1035.
        /// </param>
        /// <param name="parentName">
        /// The name of the parent reservation and parent block, formatted as
        /// reservations/{reservation_name}/reservationBlocks/{reservation_block_name}/reservationSubBlocks/{reservation_sub_block_name}
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
        /// <returns>A pageable asynchronous sequence of <see cref="ReservationSlot"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ReservationSlotsListResponse, ReservationSlot> ListAsync(string project, string zone, string parentName, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReservationSlotsRequest request = new ListReservationSlotsRequest
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

        /// <summary>
        /// Update a reservation slot in the specified sub-block.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Update(UpdateReservationSlotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a reservation slot in the specified sub-block.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateAsync(UpdateReservationSlotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a reservation slot in the specified sub-block.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateAsync(UpdateReservationSlotRequest request, st::CancellationToken cancellationToken) =>
            UpdateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>Update</c>.</summary>
        public virtual lro::OperationsClient UpdateOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Update</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceUpdate(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Update</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceUpdateAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateOperationsClient, callSettings);

        /// <summary>
        /// Update a reservation slot in the specified sub-block.
        /// </summary>
        /// <param name="project">
        /// The project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request, formatted as RFC1035.
        /// </param>
        /// <param name="parentName">
        /// The name of the sub-block resource.
        /// </param>
        /// <param name="reservationSlot">
        /// The name of the slot resource.
        /// </param>
        /// <param name="reservationSlotResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Update(string project, string zone, string parentName, string reservationSlot, ReservationSlot reservationSlotResource, gaxgrpc::CallSettings callSettings = null) =>
            Update(new UpdateReservationSlotRequest
            {
                ParentName = gax::GaxPreconditions.CheckNotNullOrEmpty(parentName, nameof(parentName)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                ReservationSlot = gax::GaxPreconditions.CheckNotNullOrEmpty(reservationSlot, nameof(reservationSlot)),
                ReservationSlotResource = gax::GaxPreconditions.CheckNotNull(reservationSlotResource, nameof(reservationSlotResource)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Update a reservation slot in the specified sub-block.
        /// </summary>
        /// <param name="project">
        /// The project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request, formatted as RFC1035.
        /// </param>
        /// <param name="parentName">
        /// The name of the sub-block resource.
        /// </param>
        /// <param name="reservationSlot">
        /// The name of the slot resource.
        /// </param>
        /// <param name="reservationSlotResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateAsync(string project, string zone, string parentName, string reservationSlot, ReservationSlot reservationSlotResource, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAsync(new UpdateReservationSlotRequest
            {
                ParentName = gax::GaxPreconditions.CheckNotNullOrEmpty(parentName, nameof(parentName)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                ReservationSlot = gax::GaxPreconditions.CheckNotNullOrEmpty(reservationSlot, nameof(reservationSlot)),
                ReservationSlotResource = gax::GaxPreconditions.CheckNotNull(reservationSlotResource, nameof(reservationSlotResource)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Update a reservation slot in the specified sub-block.
        /// </summary>
        /// <param name="project">
        /// The project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request, formatted as RFC1035.
        /// </param>
        /// <param name="parentName">
        /// The name of the sub-block resource.
        /// </param>
        /// <param name="reservationSlot">
        /// The name of the slot resource.
        /// </param>
        /// <param name="reservationSlotResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateAsync(string project, string zone, string parentName, string reservationSlot, ReservationSlot reservationSlotResource, st::CancellationToken cancellationToken) =>
            UpdateAsync(project, zone, parentName, reservationSlot, reservationSlotResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ReservationSlots client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The ReservationSlots API.
    /// </remarks>
    public sealed partial class ReservationSlotsClientImpl : ReservationSlotsClient
    {
        private readonly gaxgrpc::ApiCall<GetReservationSlotRequest, ReservationSlotsGetResponse> _callGet;

        private readonly gaxgrpc::ApiCall<ListReservationSlotsRequest, ReservationSlotsListResponse> _callList;

        private readonly gaxgrpc::ApiCall<UpdateReservationSlotRequest, Operation> _callUpdate;

        /// <summary>
        /// Constructs a client wrapper for the ReservationSlots service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ReservationSlotsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ReservationSlotsClientImpl(ReservationSlots.ReservationSlotsClient grpcClient, ReservationSlotsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ReservationSlotsSettings effectiveSettings = settings ?? ReservationSlotsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            UpdateOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.UpdateOperationsSettings, logger);
            _callGet = clientHelper.BuildApiCall<GetReservationSlotRequest, ReservationSlotsGetResponse>("Get", grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("parent_name", request => request.ParentName).WithGoogleRequestParam("reservation_slot", request => request.ReservationSlot);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callList = clientHelper.BuildApiCall<ListReservationSlotsRequest, ReservationSlotsListResponse>("List", grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("parent_name", request => request.ParentName);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            _callUpdate = clientHelper.BuildApiCall<UpdateReservationSlotRequest, Operation>("Update", grpcClient.UpdateAsync, grpcClient.Update, effectiveSettings.UpdateSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("parent_name", request => request.ParentName).WithGoogleRequestParam("reservation_slot", request => request.ReservationSlot);
            Modify_ApiCall(ref _callUpdate);
            Modify_UpdateApiCall(ref _callUpdate);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetReservationSlotRequest, ReservationSlotsGetResponse> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListReservationSlotsRequest, ReservationSlotsListResponse> call);

        partial void Modify_UpdateApiCall(ref gaxgrpc::ApiCall<UpdateReservationSlotRequest, Operation> call);

        partial void OnConstruction(ReservationSlots.ReservationSlotsClient grpcClient, ReservationSlotsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ReservationSlots client</summary>
        public override ReservationSlots.ReservationSlotsClient GrpcClient { get; }

        partial void Modify_GetReservationSlotRequest(ref GetReservationSlotRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListReservationSlotsRequest(ref ListReservationSlotsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateReservationSlotRequest(ref UpdateReservationSlotRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves information about the specified reservation slot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReservationSlotsGetResponse Get(GetReservationSlotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReservationSlotRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves information about the specified reservation slot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReservationSlotsGetResponse> GetAsync(GetReservationSlotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReservationSlotRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of reservation slots under a single reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ReservationSlot"/> resources.</returns>
        public override gax::PagedEnumerable<ReservationSlotsListResponse, ReservationSlot> List(ListReservationSlotsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReservationSlotsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListReservationSlotsRequest, ReservationSlotsListResponse, ReservationSlot>(_callList, request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of reservation slots under a single reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ReservationSlot"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ReservationSlotsListResponse, ReservationSlot> ListAsync(ListReservationSlotsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReservationSlotsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListReservationSlotsRequest, ReservationSlotsListResponse, ReservationSlot>(_callList, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>Update</c>.</summary>
        public override lro::OperationsClient UpdateOperationsClient { get; }

        /// <summary>
        /// Update a reservation slot in the specified sub-block.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Update(UpdateReservationSlotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateReservationSlotRequest(ref request, ref callSettings);
            Operation response = _callUpdate.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), UpdateOperationsClient);
        }

        /// <summary>
        /// Update a reservation slot in the specified sub-block.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> UpdateAsync(UpdateReservationSlotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateReservationSlotRequest(ref request, ref callSettings);
            Operation response = await _callUpdate.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), UpdateOperationsClient);
        }
    }

    public partial class ListReservationSlotsRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class ReservationSlotsListResponse : gaxgrpc::IPageResponse<ReservationSlot>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ReservationSlot> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ReservationSlots
    {
        public partial class ReservationSlotsClient
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
