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
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Ads.DataManager.V1
{
    /// <summary>Settings for <see cref="IngestionServiceClient"/> instances.</summary>
    public sealed partial class IngestionServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="IngestionServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="IngestionServiceSettings"/>.</returns>
        public static IngestionServiceSettings GetDefault() => new IngestionServiceSettings();

        /// <summary>Constructs a new <see cref="IngestionServiceSettings"/> object with default settings.</summary>
        public IngestionServiceSettings()
        {
        }

        private IngestionServiceSettings(IngestionServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            IngestAudienceMembersSettings = existing.IngestAudienceMembersSettings;
            RemoveAudienceMembersSettings = existing.RemoveAudienceMembersSettings;
            IngestEventsSettings = existing.IngestEventsSettings;
            RetrieveRequestStatusSettings = existing.RetrieveRequestStatusSettings;
            OnCopy(existing);
        }

        partial void OnCopy(IngestionServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IngestionServiceClient.IngestAudienceMembers</c> and <c>IngestionServiceClient.IngestAudienceMembersAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings IngestAudienceMembersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IngestionServiceClient.RemoveAudienceMembers</c> and <c>IngestionServiceClient.RemoveAudienceMembersAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RemoveAudienceMembersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IngestionServiceClient.IngestEvents</c> and <c>IngestionServiceClient.IngestEventsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings IngestEventsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IngestionServiceClient.RetrieveRequestStatus</c> and <c>IngestionServiceClient.RetrieveRequestStatusAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RetrieveRequestStatusSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="IngestionServiceSettings"/> object.</returns>
        public IngestionServiceSettings Clone() => new IngestionServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="IngestionServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class IngestionServiceClientBuilder : gaxgrpc::ClientBuilderBase<IngestionServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public IngestionServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public IngestionServiceClientBuilder() : base(IngestionServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref IngestionServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<IngestionServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override IngestionServiceClient Build()
        {
            IngestionServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<IngestionServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<IngestionServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private IngestionServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return IngestionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<IngestionServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return IngestionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => IngestionServiceClient.ChannelPool;
    }

    /// <summary>IngestionService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for sending audience data to supported destinations.
    /// </remarks>
    public abstract partial class IngestionServiceClient
    {
        /// <summary>
        /// The default endpoint for the IngestionService service, which is a host of "datamanager.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "datamanager.googleapis.com:443";

        /// <summary>The default IngestionService scopes.</summary>
        /// <remarks>
        /// The default IngestionService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/datamanager</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/datamanager",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(IngestionService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="IngestionServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="IngestionServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="IngestionServiceClient"/>.</returns>
        public static stt::Task<IngestionServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new IngestionServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="IngestionServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="IngestionServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="IngestionServiceClient"/>.</returns>
        public static IngestionServiceClient Create() => new IngestionServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="IngestionServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="IngestionServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="IngestionServiceClient"/>.</returns>
        internal static IngestionServiceClient Create(grpccore::CallInvoker callInvoker, IngestionServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            IngestionService.IngestionServiceClient grpcClient = new IngestionService.IngestionServiceClient(callInvoker);
            return new IngestionServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC IngestionService client</summary>
        public virtual IngestionService.IngestionServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Uploads a list of
        /// [AudienceMember][google.ads.datamanager.v1.AudienceMember] resources to the
        /// provided [Destination][google.ads.datamanager.v1.Destination].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IngestAudienceMembersResponse IngestAudienceMembers(IngestAudienceMembersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Uploads a list of
        /// [AudienceMember][google.ads.datamanager.v1.AudienceMember] resources to the
        /// provided [Destination][google.ads.datamanager.v1.Destination].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IngestAudienceMembersResponse> IngestAudienceMembersAsync(IngestAudienceMembersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Uploads a list of
        /// [AudienceMember][google.ads.datamanager.v1.AudienceMember] resources to the
        /// provided [Destination][google.ads.datamanager.v1.Destination].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IngestAudienceMembersResponse> IngestAudienceMembersAsync(IngestAudienceMembersRequest request, st::CancellationToken cancellationToken) =>
            IngestAudienceMembersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes a list of
        /// [AudienceMember][google.ads.datamanager.v1.AudienceMember] resources from
        /// the provided [Destination][google.ads.datamanager.v1.Destination].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RemoveAudienceMembersResponse RemoveAudienceMembers(RemoveAudienceMembersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes a list of
        /// [AudienceMember][google.ads.datamanager.v1.AudienceMember] resources from
        /// the provided [Destination][google.ads.datamanager.v1.Destination].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveAudienceMembersResponse> RemoveAudienceMembersAsync(RemoveAudienceMembersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes a list of
        /// [AudienceMember][google.ads.datamanager.v1.AudienceMember] resources from
        /// the provided [Destination][google.ads.datamanager.v1.Destination].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveAudienceMembersResponse> RemoveAudienceMembersAsync(RemoveAudienceMembersRequest request, st::CancellationToken cancellationToken) =>
            RemoveAudienceMembersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Uploads a list of
        /// [Event][google.ads.datamanager.v1.Event] resources from
        /// the provided [Destination][google.ads.datamanager.v1.Destination].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IngestEventsResponse IngestEvents(IngestEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Uploads a list of
        /// [Event][google.ads.datamanager.v1.Event] resources from
        /// the provided [Destination][google.ads.datamanager.v1.Destination].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IngestEventsResponse> IngestEventsAsync(IngestEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Uploads a list of
        /// [Event][google.ads.datamanager.v1.Event] resources from
        /// the provided [Destination][google.ads.datamanager.v1.Destination].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IngestEventsResponse> IngestEventsAsync(IngestEventsRequest request, st::CancellationToken cancellationToken) =>
            IngestEventsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the status of a request given request id.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RetrieveRequestStatusResponse RetrieveRequestStatus(RetrieveRequestStatusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the status of a request given request id.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetrieveRequestStatusResponse> RetrieveRequestStatusAsync(RetrieveRequestStatusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the status of a request given request id.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetrieveRequestStatusResponse> RetrieveRequestStatusAsync(RetrieveRequestStatusRequest request, st::CancellationToken cancellationToken) =>
            RetrieveRequestStatusAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>IngestionService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for sending audience data to supported destinations.
    /// </remarks>
    public sealed partial class IngestionServiceClientImpl : IngestionServiceClient
    {
        private readonly gaxgrpc::ApiCall<IngestAudienceMembersRequest, IngestAudienceMembersResponse> _callIngestAudienceMembers;

        private readonly gaxgrpc::ApiCall<RemoveAudienceMembersRequest, RemoveAudienceMembersResponse> _callRemoveAudienceMembers;

        private readonly gaxgrpc::ApiCall<IngestEventsRequest, IngestEventsResponse> _callIngestEvents;

        private readonly gaxgrpc::ApiCall<RetrieveRequestStatusRequest, RetrieveRequestStatusResponse> _callRetrieveRequestStatus;

        /// <summary>
        /// Constructs a client wrapper for the IngestionService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="IngestionServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public IngestionServiceClientImpl(IngestionService.IngestionServiceClient grpcClient, IngestionServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            IngestionServiceSettings effectiveSettings = settings ?? IngestionServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callIngestAudienceMembers = clientHelper.BuildApiCall<IngestAudienceMembersRequest, IngestAudienceMembersResponse>("IngestAudienceMembers", grpcClient.IngestAudienceMembersAsync, grpcClient.IngestAudienceMembers, effectiveSettings.IngestAudienceMembersSettings);
            Modify_ApiCall(ref _callIngestAudienceMembers);
            Modify_IngestAudienceMembersApiCall(ref _callIngestAudienceMembers);
            _callRemoveAudienceMembers = clientHelper.BuildApiCall<RemoveAudienceMembersRequest, RemoveAudienceMembersResponse>("RemoveAudienceMembers", grpcClient.RemoveAudienceMembersAsync, grpcClient.RemoveAudienceMembers, effectiveSettings.RemoveAudienceMembersSettings);
            Modify_ApiCall(ref _callRemoveAudienceMembers);
            Modify_RemoveAudienceMembersApiCall(ref _callRemoveAudienceMembers);
            _callIngestEvents = clientHelper.BuildApiCall<IngestEventsRequest, IngestEventsResponse>("IngestEvents", grpcClient.IngestEventsAsync, grpcClient.IngestEvents, effectiveSettings.IngestEventsSettings);
            Modify_ApiCall(ref _callIngestEvents);
            Modify_IngestEventsApiCall(ref _callIngestEvents);
            _callRetrieveRequestStatus = clientHelper.BuildApiCall<RetrieveRequestStatusRequest, RetrieveRequestStatusResponse>("RetrieveRequestStatus", grpcClient.RetrieveRequestStatusAsync, grpcClient.RetrieveRequestStatus, effectiveSettings.RetrieveRequestStatusSettings);
            Modify_ApiCall(ref _callRetrieveRequestStatus);
            Modify_RetrieveRequestStatusApiCall(ref _callRetrieveRequestStatus);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_IngestAudienceMembersApiCall(ref gaxgrpc::ApiCall<IngestAudienceMembersRequest, IngestAudienceMembersResponse> call);

        partial void Modify_RemoveAudienceMembersApiCall(ref gaxgrpc::ApiCall<RemoveAudienceMembersRequest, RemoveAudienceMembersResponse> call);

        partial void Modify_IngestEventsApiCall(ref gaxgrpc::ApiCall<IngestEventsRequest, IngestEventsResponse> call);

        partial void Modify_RetrieveRequestStatusApiCall(ref gaxgrpc::ApiCall<RetrieveRequestStatusRequest, RetrieveRequestStatusResponse> call);

        partial void OnConstruction(IngestionService.IngestionServiceClient grpcClient, IngestionServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC IngestionService client</summary>
        public override IngestionService.IngestionServiceClient GrpcClient { get; }

        partial void Modify_IngestAudienceMembersRequest(ref IngestAudienceMembersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RemoveAudienceMembersRequest(ref RemoveAudienceMembersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_IngestEventsRequest(ref IngestEventsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RetrieveRequestStatusRequest(ref RetrieveRequestStatusRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Uploads a list of
        /// [AudienceMember][google.ads.datamanager.v1.AudienceMember] resources to the
        /// provided [Destination][google.ads.datamanager.v1.Destination].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override IngestAudienceMembersResponse IngestAudienceMembers(IngestAudienceMembersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_IngestAudienceMembersRequest(ref request, ref callSettings);
            return _callIngestAudienceMembers.Sync(request, callSettings);
        }

        /// <summary>
        /// Uploads a list of
        /// [AudienceMember][google.ads.datamanager.v1.AudienceMember] resources to the
        /// provided [Destination][google.ads.datamanager.v1.Destination].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<IngestAudienceMembersResponse> IngestAudienceMembersAsync(IngestAudienceMembersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_IngestAudienceMembersRequest(ref request, ref callSettings);
            return _callIngestAudienceMembers.Async(request, callSettings);
        }

        /// <summary>
        /// Removes a list of
        /// [AudienceMember][google.ads.datamanager.v1.AudienceMember] resources from
        /// the provided [Destination][google.ads.datamanager.v1.Destination].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RemoveAudienceMembersResponse RemoveAudienceMembers(RemoveAudienceMembersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveAudienceMembersRequest(ref request, ref callSettings);
            return _callRemoveAudienceMembers.Sync(request, callSettings);
        }

        /// <summary>
        /// Removes a list of
        /// [AudienceMember][google.ads.datamanager.v1.AudienceMember] resources from
        /// the provided [Destination][google.ads.datamanager.v1.Destination].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RemoveAudienceMembersResponse> RemoveAudienceMembersAsync(RemoveAudienceMembersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveAudienceMembersRequest(ref request, ref callSettings);
            return _callRemoveAudienceMembers.Async(request, callSettings);
        }

        /// <summary>
        /// Uploads a list of
        /// [Event][google.ads.datamanager.v1.Event] resources from
        /// the provided [Destination][google.ads.datamanager.v1.Destination].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override IngestEventsResponse IngestEvents(IngestEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_IngestEventsRequest(ref request, ref callSettings);
            return _callIngestEvents.Sync(request, callSettings);
        }

        /// <summary>
        /// Uploads a list of
        /// [Event][google.ads.datamanager.v1.Event] resources from
        /// the provided [Destination][google.ads.datamanager.v1.Destination].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<IngestEventsResponse> IngestEventsAsync(IngestEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_IngestEventsRequest(ref request, ref callSettings);
            return _callIngestEvents.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the status of a request given request id.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RetrieveRequestStatusResponse RetrieveRequestStatus(RetrieveRequestStatusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RetrieveRequestStatusRequest(ref request, ref callSettings);
            return _callRetrieveRequestStatus.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the status of a request given request id.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RetrieveRequestStatusResponse> RetrieveRequestStatusAsync(RetrieveRequestStatusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RetrieveRequestStatusRequest(ref request, ref callSettings);
            return _callRetrieveRequestStatus.Async(request, callSettings);
        }
    }
}
