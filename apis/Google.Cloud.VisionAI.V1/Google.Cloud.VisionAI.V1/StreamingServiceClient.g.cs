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
using gciv = Google.Cloud.Iam.V1;
using gcl = Google.Cloud.Location;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.VisionAI.V1
{
    /// <summary>Settings for <see cref="StreamingServiceClient"/> instances.</summary>
    public sealed partial class StreamingServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="StreamingServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="StreamingServiceSettings"/>.</returns>
        public static StreamingServiceSettings GetDefault() => new StreamingServiceSettings();

        /// <summary>Constructs a new <see cref="StreamingServiceSettings"/> object with default settings.</summary>
        public StreamingServiceSettings()
        {
        }

        private StreamingServiceSettings(StreamingServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            SendPacketsSettings = existing.SendPacketsSettings;
            SendPacketsStreamingSettings = existing.SendPacketsStreamingSettings;
            ReceivePacketsSettings = existing.ReceivePacketsSettings;
            ReceivePacketsStreamingSettings = existing.ReceivePacketsStreamingSettings;
            ReceiveEventsSettings = existing.ReceiveEventsSettings;
            ReceiveEventsStreamingSettings = existing.ReceiveEventsStreamingSettings;
            AcquireLeaseSettings = existing.AcquireLeaseSettings;
            RenewLeaseSettings = existing.RenewLeaseSettings;
            ReleaseLeaseSettings = existing.ReleaseLeaseSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(StreamingServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StreamingServiceClient.SendPackets</c> and <c>StreamingServiceClient.SendPacketsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SendPacketsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::BidirectionalStreamingSettings"/> for calls to <c>StreamingServiceClient.SendPackets</c>
        /// and <c>StreamingServiceClient.SendPacketsAsync</c>.
        /// </summary>
        /// <remarks>The default local send queue size is 100.</remarks>
        public gaxgrpc::BidirectionalStreamingSettings SendPacketsStreamingSettings { get; set; } = new gaxgrpc::BidirectionalStreamingSettings(100);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StreamingServiceClient.ReceivePackets</c> and <c>StreamingServiceClient.ReceivePacketsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReceivePacketsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::BidirectionalStreamingSettings"/> for calls to <c>StreamingServiceClient.ReceivePackets</c>
        ///  and <c>StreamingServiceClient.ReceivePacketsAsync</c>.
        /// </summary>
        /// <remarks>The default local send queue size is 100.</remarks>
        public gaxgrpc::BidirectionalStreamingSettings ReceivePacketsStreamingSettings { get; set; } = new gaxgrpc::BidirectionalStreamingSettings(100);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StreamingServiceClient.ReceiveEvents</c> and <c>StreamingServiceClient.ReceiveEventsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReceiveEventsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::BidirectionalStreamingSettings"/> for calls to <c>StreamingServiceClient.ReceiveEvents</c>
        ///  and <c>StreamingServiceClient.ReceiveEventsAsync</c>.
        /// </summary>
        /// <remarks>The default local send queue size is 100.</remarks>
        public gaxgrpc::BidirectionalStreamingSettings ReceiveEventsStreamingSettings { get; set; } = new gaxgrpc::BidirectionalStreamingSettings(100);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StreamingServiceClient.AcquireLease</c> and <c>StreamingServiceClient.AcquireLeaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AcquireLeaseSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StreamingServiceClient.RenewLease</c> and <c>StreamingServiceClient.RenewLeaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RenewLeaseSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StreamingServiceClient.ReleaseLease</c> and <c>StreamingServiceClient.ReleaseLeaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReleaseLeaseSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="StreamingServiceSettings"/> object.</returns>
        public StreamingServiceSettings Clone() => new StreamingServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="StreamingServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class StreamingServiceClientBuilder : gaxgrpc::ClientBuilderBase<StreamingServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public StreamingServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public StreamingServiceClientBuilder() : base(StreamingServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref StreamingServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<StreamingServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override StreamingServiceClient Build()
        {
            StreamingServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<StreamingServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<StreamingServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private StreamingServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return StreamingServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<StreamingServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return StreamingServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => StreamingServiceClient.ChannelPool;
    }

    /// <summary>StreamingService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Streaming service for receiving and sending packets.
    /// </remarks>
    public abstract partial class StreamingServiceClient
    {
        /// <summary>
        /// The default endpoint for the StreamingService service, which is a host of "visionai.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "visionai.googleapis.com:443";

        /// <summary>The default StreamingService scopes.</summary>
        /// <remarks>
        /// The default StreamingService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(StreamingService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="StreamingServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="StreamingServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="StreamingServiceClient"/>.</returns>
        public static stt::Task<StreamingServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new StreamingServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="StreamingServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="StreamingServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="StreamingServiceClient"/>.</returns>
        public static StreamingServiceClient Create() => new StreamingServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="StreamingServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="StreamingServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="StreamingServiceClient"/>.</returns>
        internal static StreamingServiceClient Create(grpccore::CallInvoker callInvoker, StreamingServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            StreamingService.StreamingServiceClient grpcClient = new StreamingService.StreamingServiceClient(callInvoker);
            return new StreamingServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC StreamingService client</summary>
        public virtual StreamingService.StreamingServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Bidirectional streaming methods for
        /// <see cref="SendPackets(gaxgrpc::CallSettings,gaxgrpc::BidirectionalStreamingSettings)"/>.
        /// </summary>
        public abstract partial class SendPacketsStream : gaxgrpc::BidirectionalStreamingBase<SendPacketsRequest, SendPacketsResponse>
        {
        }

        /// <summary>
        /// Send packets to the series.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public virtual SendPacketsStream SendPackets(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Bidirectional streaming methods for
        /// <see cref="ReceivePackets(gaxgrpc::CallSettings,gaxgrpc::BidirectionalStreamingSettings)"/>.
        /// </summary>
        public abstract partial class ReceivePacketsStream : gaxgrpc::BidirectionalStreamingBase<ReceivePacketsRequest, ReceivePacketsResponse>
        {
        }

        /// <summary>
        /// Receive packets from the series.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public virtual ReceivePacketsStream ReceivePackets(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Bidirectional streaming methods for
        /// <see cref="ReceiveEvents(gaxgrpc::CallSettings,gaxgrpc::BidirectionalStreamingSettings)"/>.
        /// </summary>
        public abstract partial class ReceiveEventsStream : gaxgrpc::BidirectionalStreamingBase<ReceiveEventsRequest, ReceiveEventsResponse>
        {
        }

        /// <summary>
        /// Receive events given the stream name.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public virtual ReceiveEventsStream ReceiveEvents(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// AcquireLease acquires a lease.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Lease AcquireLease(AcquireLeaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// AcquireLease acquires a lease.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Lease> AcquireLeaseAsync(AcquireLeaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// AcquireLease acquires a lease.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Lease> AcquireLeaseAsync(AcquireLeaseRequest request, st::CancellationToken cancellationToken) =>
            AcquireLeaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// RenewLease renews a lease.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Lease RenewLease(RenewLeaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// RenewLease renews a lease.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Lease> RenewLeaseAsync(RenewLeaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// RenewLease renews a lease.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Lease> RenewLeaseAsync(RenewLeaseRequest request, st::CancellationToken cancellationToken) =>
            RenewLeaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// RleaseLease releases a lease.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReleaseLeaseResponse ReleaseLease(ReleaseLeaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// RleaseLease releases a lease.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReleaseLeaseResponse> ReleaseLeaseAsync(ReleaseLeaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// RleaseLease releases a lease.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReleaseLeaseResponse> ReleaseLeaseAsync(ReleaseLeaseRequest request, st::CancellationToken cancellationToken) =>
            ReleaseLeaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>StreamingService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Streaming service for receiving and sending packets.
    /// </remarks>
    public sealed partial class StreamingServiceClientImpl : StreamingServiceClient
    {
        private readonly gaxgrpc::ApiBidirectionalStreamingCall<SendPacketsRequest, SendPacketsResponse> _callSendPackets;

        private readonly gaxgrpc::ApiBidirectionalStreamingCall<ReceivePacketsRequest, ReceivePacketsResponse> _callReceivePackets;

        private readonly gaxgrpc::ApiBidirectionalStreamingCall<ReceiveEventsRequest, ReceiveEventsResponse> _callReceiveEvents;

        private readonly gaxgrpc::ApiCall<AcquireLeaseRequest, Lease> _callAcquireLease;

        private readonly gaxgrpc::ApiCall<RenewLeaseRequest, Lease> _callRenewLease;

        private readonly gaxgrpc::ApiCall<ReleaseLeaseRequest, ReleaseLeaseResponse> _callReleaseLease;

        /// <summary>
        /// Constructs a client wrapper for the StreamingService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="StreamingServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public StreamingServiceClientImpl(StreamingService.StreamingServiceClient grpcClient, StreamingServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            StreamingServiceSettings effectiveSettings = settings ?? StreamingServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callSendPackets = clientHelper.BuildApiCall<SendPacketsRequest, SendPacketsResponse>("SendPackets", grpcClient.SendPackets, effectiveSettings.SendPacketsSettings, effectiveSettings.SendPacketsStreamingSettings);
            Modify_ApiCall(ref _callSendPackets);
            Modify_SendPacketsApiCall(ref _callSendPackets);
            _callReceivePackets = clientHelper.BuildApiCall<ReceivePacketsRequest, ReceivePacketsResponse>("ReceivePackets", grpcClient.ReceivePackets, effectiveSettings.ReceivePacketsSettings, effectiveSettings.ReceivePacketsStreamingSettings);
            Modify_ApiCall(ref _callReceivePackets);
            Modify_ReceivePacketsApiCall(ref _callReceivePackets);
            _callReceiveEvents = clientHelper.BuildApiCall<ReceiveEventsRequest, ReceiveEventsResponse>("ReceiveEvents", grpcClient.ReceiveEvents, effectiveSettings.ReceiveEventsSettings, effectiveSettings.ReceiveEventsStreamingSettings);
            Modify_ApiCall(ref _callReceiveEvents);
            Modify_ReceiveEventsApiCall(ref _callReceiveEvents);
            _callAcquireLease = clientHelper.BuildApiCall<AcquireLeaseRequest, Lease>("AcquireLease", grpcClient.AcquireLeaseAsync, grpcClient.AcquireLease, effectiveSettings.AcquireLeaseSettings).WithGoogleRequestParam("series", request => request.Series);
            Modify_ApiCall(ref _callAcquireLease);
            Modify_AcquireLeaseApiCall(ref _callAcquireLease);
            _callRenewLease = clientHelper.BuildApiCall<RenewLeaseRequest, Lease>("RenewLease", grpcClient.RenewLeaseAsync, grpcClient.RenewLease, effectiveSettings.RenewLeaseSettings).WithGoogleRequestParam("series", request => request.Series);
            Modify_ApiCall(ref _callRenewLease);
            Modify_RenewLeaseApiCall(ref _callRenewLease);
            _callReleaseLease = clientHelper.BuildApiCall<ReleaseLeaseRequest, ReleaseLeaseResponse>("ReleaseLease", grpcClient.ReleaseLeaseAsync, grpcClient.ReleaseLease, effectiveSettings.ReleaseLeaseSettings).WithGoogleRequestParam("series", request => request.Series);
            Modify_ApiCall(ref _callReleaseLease);
            Modify_ReleaseLeaseApiCall(ref _callReleaseLease);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiBidirectionalStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_SendPacketsApiCall(ref gaxgrpc::ApiBidirectionalStreamingCall<SendPacketsRequest, SendPacketsResponse> call);

        partial void Modify_ReceivePacketsApiCall(ref gaxgrpc::ApiBidirectionalStreamingCall<ReceivePacketsRequest, ReceivePacketsResponse> call);

        partial void Modify_ReceiveEventsApiCall(ref gaxgrpc::ApiBidirectionalStreamingCall<ReceiveEventsRequest, ReceiveEventsResponse> call);

        partial void Modify_AcquireLeaseApiCall(ref gaxgrpc::ApiCall<AcquireLeaseRequest, Lease> call);

        partial void Modify_RenewLeaseApiCall(ref gaxgrpc::ApiCall<RenewLeaseRequest, Lease> call);

        partial void Modify_ReleaseLeaseApiCall(ref gaxgrpc::ApiCall<ReleaseLeaseRequest, ReleaseLeaseResponse> call);

        partial void OnConstruction(StreamingService.StreamingServiceClient grpcClient, StreamingServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC StreamingService client</summary>
        public override StreamingService.StreamingServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_SendPacketsRequestCallSettings(ref gaxgrpc::CallSettings settings);

        partial void Modify_SendPacketsRequestRequest(ref SendPacketsRequest request);

        partial void Modify_ReceivePacketsRequestCallSettings(ref gaxgrpc::CallSettings settings);

        partial void Modify_ReceivePacketsRequestRequest(ref ReceivePacketsRequest request);

        partial void Modify_ReceiveEventsRequestCallSettings(ref gaxgrpc::CallSettings settings);

        partial void Modify_ReceiveEventsRequestRequest(ref ReceiveEventsRequest request);

        partial void Modify_AcquireLeaseRequest(ref AcquireLeaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RenewLeaseRequest(ref RenewLeaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReleaseLeaseRequest(ref ReleaseLeaseRequest request, ref gaxgrpc::CallSettings settings);

        internal sealed partial class SendPacketsStreamImpl : SendPacketsStream
        {
            /// <summary>Construct the bidirectional streaming method for <c>SendPackets</c>.</summary>
            /// <param name="service">The service containing this streaming method.</param>
            /// <param name="call">The underlying gRPC duplex streaming call.</param>
            /// <param name="writeBuffer">
            /// The <see cref="gaxgrpc::BufferedClientStreamWriter{SendPacketsRequest}"/> instance associated with this
            /// streaming call.
            /// </param>
            public SendPacketsStreamImpl(StreamingServiceClientImpl service, grpccore::AsyncDuplexStreamingCall<SendPacketsRequest, SendPacketsResponse> call, gaxgrpc::BufferedClientStreamWriter<SendPacketsRequest> writeBuffer)
            {
                _service = service;
                GrpcCall = call;
                _writeBuffer = writeBuffer;
            }

            private StreamingServiceClientImpl _service;

            private gaxgrpc::BufferedClientStreamWriter<SendPacketsRequest> _writeBuffer;

            public override grpccore::AsyncDuplexStreamingCall<SendPacketsRequest, SendPacketsResponse> GrpcCall { get; }

            private SendPacketsRequest ModifyRequest(SendPacketsRequest request)
            {
                _service.Modify_SendPacketsRequestRequest(ref request);
                return request;
            }

            public override stt::Task TryWriteAsync(SendPacketsRequest message) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message));

            public override stt::Task WriteAsync(SendPacketsRequest message) =>
                _writeBuffer.WriteAsync(ModifyRequest(message));

            public override stt::Task TryWriteAsync(SendPacketsRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message), options);

            public override stt::Task WriteAsync(SendPacketsRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.WriteAsync(ModifyRequest(message), options);

            public override stt::Task TryWriteCompleteAsync() => _writeBuffer.TryWriteCompleteAsync();

            public override stt::Task WriteCompleteAsync() => _writeBuffer.WriteCompleteAsync();
        }

        /// <summary>
        /// Send packets to the series.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public override StreamingServiceClient.SendPacketsStream SendPackets(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null)
        {
            Modify_SendPacketsRequestCallSettings(ref callSettings);
            gaxgrpc::BidirectionalStreamingSettings effectiveStreamingSettings = streamingSettings ?? _callSendPackets.StreamingSettings;
            grpccore::AsyncDuplexStreamingCall<SendPacketsRequest, SendPacketsResponse> call = _callSendPackets.Call(callSettings);
            gaxgrpc::BufferedClientStreamWriter<SendPacketsRequest> writeBuffer = new gaxgrpc::BufferedClientStreamWriter<SendPacketsRequest>(call.RequestStream, effectiveStreamingSettings.BufferedClientWriterCapacity);
            return new SendPacketsStreamImpl(this, call, writeBuffer);
        }

        internal sealed partial class ReceivePacketsStreamImpl : ReceivePacketsStream
        {
            /// <summary>Construct the bidirectional streaming method for <c>ReceivePackets</c>.</summary>
            /// <param name="service">The service containing this streaming method.</param>
            /// <param name="call">The underlying gRPC duplex streaming call.</param>
            /// <param name="writeBuffer">
            /// The <see cref="gaxgrpc::BufferedClientStreamWriter{ReceivePacketsRequest}"/> instance associated with
            /// this streaming call.
            /// </param>
            public ReceivePacketsStreamImpl(StreamingServiceClientImpl service, grpccore::AsyncDuplexStreamingCall<ReceivePacketsRequest, ReceivePacketsResponse> call, gaxgrpc::BufferedClientStreamWriter<ReceivePacketsRequest> writeBuffer)
            {
                _service = service;
                GrpcCall = call;
                _writeBuffer = writeBuffer;
            }

            private StreamingServiceClientImpl _service;

            private gaxgrpc::BufferedClientStreamWriter<ReceivePacketsRequest> _writeBuffer;

            public override grpccore::AsyncDuplexStreamingCall<ReceivePacketsRequest, ReceivePacketsResponse> GrpcCall { get; }

            private ReceivePacketsRequest ModifyRequest(ReceivePacketsRequest request)
            {
                _service.Modify_ReceivePacketsRequestRequest(ref request);
                return request;
            }

            public override stt::Task TryWriteAsync(ReceivePacketsRequest message) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message));

            public override stt::Task WriteAsync(ReceivePacketsRequest message) =>
                _writeBuffer.WriteAsync(ModifyRequest(message));

            public override stt::Task TryWriteAsync(ReceivePacketsRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message), options);

            public override stt::Task WriteAsync(ReceivePacketsRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.WriteAsync(ModifyRequest(message), options);

            public override stt::Task TryWriteCompleteAsync() => _writeBuffer.TryWriteCompleteAsync();

            public override stt::Task WriteCompleteAsync() => _writeBuffer.WriteCompleteAsync();
        }

        /// <summary>
        /// Receive packets from the series.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public override StreamingServiceClient.ReceivePacketsStream ReceivePackets(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null)
        {
            Modify_ReceivePacketsRequestCallSettings(ref callSettings);
            gaxgrpc::BidirectionalStreamingSettings effectiveStreamingSettings = streamingSettings ?? _callReceivePackets.StreamingSettings;
            grpccore::AsyncDuplexStreamingCall<ReceivePacketsRequest, ReceivePacketsResponse> call = _callReceivePackets.Call(callSettings);
            gaxgrpc::BufferedClientStreamWriter<ReceivePacketsRequest> writeBuffer = new gaxgrpc::BufferedClientStreamWriter<ReceivePacketsRequest>(call.RequestStream, effectiveStreamingSettings.BufferedClientWriterCapacity);
            return new ReceivePacketsStreamImpl(this, call, writeBuffer);
        }

        internal sealed partial class ReceiveEventsStreamImpl : ReceiveEventsStream
        {
            /// <summary>Construct the bidirectional streaming method for <c>ReceiveEvents</c>.</summary>
            /// <param name="service">The service containing this streaming method.</param>
            /// <param name="call">The underlying gRPC duplex streaming call.</param>
            /// <param name="writeBuffer">
            /// The <see cref="gaxgrpc::BufferedClientStreamWriter{ReceiveEventsRequest}"/> instance associated with
            /// this streaming call.
            /// </param>
            public ReceiveEventsStreamImpl(StreamingServiceClientImpl service, grpccore::AsyncDuplexStreamingCall<ReceiveEventsRequest, ReceiveEventsResponse> call, gaxgrpc::BufferedClientStreamWriter<ReceiveEventsRequest> writeBuffer)
            {
                _service = service;
                GrpcCall = call;
                _writeBuffer = writeBuffer;
            }

            private StreamingServiceClientImpl _service;

            private gaxgrpc::BufferedClientStreamWriter<ReceiveEventsRequest> _writeBuffer;

            public override grpccore::AsyncDuplexStreamingCall<ReceiveEventsRequest, ReceiveEventsResponse> GrpcCall { get; }

            private ReceiveEventsRequest ModifyRequest(ReceiveEventsRequest request)
            {
                _service.Modify_ReceiveEventsRequestRequest(ref request);
                return request;
            }

            public override stt::Task TryWriteAsync(ReceiveEventsRequest message) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message));

            public override stt::Task WriteAsync(ReceiveEventsRequest message) =>
                _writeBuffer.WriteAsync(ModifyRequest(message));

            public override stt::Task TryWriteAsync(ReceiveEventsRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message), options);

            public override stt::Task WriteAsync(ReceiveEventsRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.WriteAsync(ModifyRequest(message), options);

            public override stt::Task TryWriteCompleteAsync() => _writeBuffer.TryWriteCompleteAsync();

            public override stt::Task WriteCompleteAsync() => _writeBuffer.WriteCompleteAsync();
        }

        /// <summary>
        /// Receive events given the stream name.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public override StreamingServiceClient.ReceiveEventsStream ReceiveEvents(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null)
        {
            Modify_ReceiveEventsRequestCallSettings(ref callSettings);
            gaxgrpc::BidirectionalStreamingSettings effectiveStreamingSettings = streamingSettings ?? _callReceiveEvents.StreamingSettings;
            grpccore::AsyncDuplexStreamingCall<ReceiveEventsRequest, ReceiveEventsResponse> call = _callReceiveEvents.Call(callSettings);
            gaxgrpc::BufferedClientStreamWriter<ReceiveEventsRequest> writeBuffer = new gaxgrpc::BufferedClientStreamWriter<ReceiveEventsRequest>(call.RequestStream, effectiveStreamingSettings.BufferedClientWriterCapacity);
            return new ReceiveEventsStreamImpl(this, call, writeBuffer);
        }

        /// <summary>
        /// AcquireLease acquires a lease.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Lease AcquireLease(AcquireLeaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AcquireLeaseRequest(ref request, ref callSettings);
            return _callAcquireLease.Sync(request, callSettings);
        }

        /// <summary>
        /// AcquireLease acquires a lease.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Lease> AcquireLeaseAsync(AcquireLeaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AcquireLeaseRequest(ref request, ref callSettings);
            return _callAcquireLease.Async(request, callSettings);
        }

        /// <summary>
        /// RenewLease renews a lease.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Lease RenewLease(RenewLeaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RenewLeaseRequest(ref request, ref callSettings);
            return _callRenewLease.Sync(request, callSettings);
        }

        /// <summary>
        /// RenewLease renews a lease.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Lease> RenewLeaseAsync(RenewLeaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RenewLeaseRequest(ref request, ref callSettings);
            return _callRenewLease.Async(request, callSettings);
        }

        /// <summary>
        /// RleaseLease releases a lease.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReleaseLeaseResponse ReleaseLease(ReleaseLeaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReleaseLeaseRequest(ref request, ref callSettings);
            return _callReleaseLease.Sync(request, callSettings);
        }

        /// <summary>
        /// RleaseLease releases a lease.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReleaseLeaseResponse> ReleaseLeaseAsync(ReleaseLeaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReleaseLeaseRequest(ref request, ref callSettings);
            return _callReleaseLease.Async(request, callSettings);
        }
    }

    public static partial class StreamingService
    {
        public partial class StreamingServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="gcl::Locations.LocationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gcl::Locations.LocationsClient"/> for the same target as this client.
            /// </returns>
            public virtual gcl::Locations.LocationsClient CreateLocationsClient() =>
                new gcl::Locations.LocationsClient(CallInvoker);

            /// <summary>
            /// Creates a new instance of <see cref="gciv::IAMPolicy.IAMPolicyClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gciv::IAMPolicy.IAMPolicyClient"/> for the same target as this client.
            /// </returns>
            public virtual gciv::IAMPolicy.IAMPolicyClient CreateIAMPolicyClient() =>
                new gciv::IAMPolicy.IAMPolicyClient(CallInvoker);
        }
    }
}
