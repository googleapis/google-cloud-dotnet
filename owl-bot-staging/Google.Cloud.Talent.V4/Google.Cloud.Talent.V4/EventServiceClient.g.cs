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

namespace Google.Cloud.Talent.V4
{
    /// <summary>Settings for <see cref="EventServiceClient"/> instances.</summary>
    public sealed partial class EventServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="EventServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="EventServiceSettings"/>.</returns>
        public static EventServiceSettings GetDefault() => new EventServiceSettings();

        /// <summary>Constructs a new <see cref="EventServiceSettings"/> object with default settings.</summary>
        public EventServiceSettings()
        {
        }

        private EventServiceSettings(EventServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateClientEventSettings = existing.CreateClientEventSettings;
            OnCopy(existing);
        }

        partial void OnCopy(EventServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EventServiceClient.CreateClientEvent</c> and <c>EventServiceClient.CreateClientEventAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateClientEventSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="EventServiceSettings"/> object.</returns>
        public EventServiceSettings Clone() => new EventServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="EventServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class EventServiceClientBuilder : gaxgrpc::ClientBuilderBase<EventServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public EventServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public EventServiceClientBuilder() : base(EventServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref EventServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<EventServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override EventServiceClient Build()
        {
            EventServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<EventServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<EventServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private EventServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return EventServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<EventServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return EventServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => EventServiceClient.ChannelPool;
    }

    /// <summary>EventService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service handles client event report.
    /// </remarks>
    public abstract partial class EventServiceClient
    {
        /// <summary>
        /// The default endpoint for the EventService service, which is a host of "jobs.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "jobs.googleapis.com:443";

        /// <summary>The default EventService scopes.</summary>
        /// <remarks>
        /// The default EventService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/jobs</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/jobs",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(EventService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="EventServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="EventServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="EventServiceClient"/>.</returns>
        public static stt::Task<EventServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new EventServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="EventServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="EventServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="EventServiceClient"/>.</returns>
        public static EventServiceClient Create() => new EventServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="EventServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="EventServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="EventServiceClient"/>.</returns>
        internal static EventServiceClient Create(grpccore::CallInvoker callInvoker, EventServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            EventService.EventServiceClient grpcClient = new EventService.EventServiceClient(callInvoker);
            return new EventServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC EventService client</summary>
        public virtual EventService.EventServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Report events issued when end user interacts with customer's application
        /// that uses Cloud Talent Solution. You may inspect the created events in
        /// [self service
        /// tools](https://console.cloud.google.com/talent-solution/overview).
        /// [Learn
        /// more](https://cloud.google.com/talent-solution/docs/management-tools)
        /// about self service tools.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ClientEvent CreateClientEvent(CreateClientEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Report events issued when end user interacts with customer's application
        /// that uses Cloud Talent Solution. You may inspect the created events in
        /// [self service
        /// tools](https://console.cloud.google.com/talent-solution/overview).
        /// [Learn
        /// more](https://cloud.google.com/talent-solution/docs/management-tools)
        /// about self service tools.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ClientEvent> CreateClientEventAsync(CreateClientEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Report events issued when end user interacts with customer's application
        /// that uses Cloud Talent Solution. You may inspect the created events in
        /// [self service
        /// tools](https://console.cloud.google.com/talent-solution/overview).
        /// [Learn
        /// more](https://cloud.google.com/talent-solution/docs/management-tools)
        /// about self service tools.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ClientEvent> CreateClientEventAsync(CreateClientEventRequest request, st::CancellationToken cancellationToken) =>
            CreateClientEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Report events issued when end user interacts with customer's application
        /// that uses Cloud Talent Solution. You may inspect the created events in
        /// [self service
        /// tools](https://console.cloud.google.com/talent-solution/overview).
        /// [Learn
        /// more](https://cloud.google.com/talent-solution/docs/management-tools)
        /// about self service tools.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the tenant under which the event is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/foo/tenants/bar".
        /// </param>
        /// <param name="clientEvent">
        /// Required. Events issued when end user interacts with customer's application
        /// that uses Cloud Talent Solution.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ClientEvent CreateClientEvent(string parent, ClientEvent clientEvent, gaxgrpc::CallSettings callSettings = null) =>
            CreateClientEvent(new CreateClientEventRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ClientEvent = gax::GaxPreconditions.CheckNotNull(clientEvent, nameof(clientEvent)),
            }, callSettings);

        /// <summary>
        /// Report events issued when end user interacts with customer's application
        /// that uses Cloud Talent Solution. You may inspect the created events in
        /// [self service
        /// tools](https://console.cloud.google.com/talent-solution/overview).
        /// [Learn
        /// more](https://cloud.google.com/talent-solution/docs/management-tools)
        /// about self service tools.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the tenant under which the event is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/foo/tenants/bar".
        /// </param>
        /// <param name="clientEvent">
        /// Required. Events issued when end user interacts with customer's application
        /// that uses Cloud Talent Solution.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ClientEvent> CreateClientEventAsync(string parent, ClientEvent clientEvent, gaxgrpc::CallSettings callSettings = null) =>
            CreateClientEventAsync(new CreateClientEventRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ClientEvent = gax::GaxPreconditions.CheckNotNull(clientEvent, nameof(clientEvent)),
            }, callSettings);

        /// <summary>
        /// Report events issued when end user interacts with customer's application
        /// that uses Cloud Talent Solution. You may inspect the created events in
        /// [self service
        /// tools](https://console.cloud.google.com/talent-solution/overview).
        /// [Learn
        /// more](https://cloud.google.com/talent-solution/docs/management-tools)
        /// about self service tools.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the tenant under which the event is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/foo/tenants/bar".
        /// </param>
        /// <param name="clientEvent">
        /// Required. Events issued when end user interacts with customer's application
        /// that uses Cloud Talent Solution.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ClientEvent> CreateClientEventAsync(string parent, ClientEvent clientEvent, st::CancellationToken cancellationToken) =>
            CreateClientEventAsync(parent, clientEvent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Report events issued when end user interacts with customer's application
        /// that uses Cloud Talent Solution. You may inspect the created events in
        /// [self service
        /// tools](https://console.cloud.google.com/talent-solution/overview).
        /// [Learn
        /// more](https://cloud.google.com/talent-solution/docs/management-tools)
        /// about self service tools.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the tenant under which the event is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/foo/tenants/bar".
        /// </param>
        /// <param name="clientEvent">
        /// Required. Events issued when end user interacts with customer's application
        /// that uses Cloud Talent Solution.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ClientEvent CreateClientEvent(TenantName parent, ClientEvent clientEvent, gaxgrpc::CallSettings callSettings = null) =>
            CreateClientEvent(new CreateClientEventRequest
            {
                ParentAsTenantName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ClientEvent = gax::GaxPreconditions.CheckNotNull(clientEvent, nameof(clientEvent)),
            }, callSettings);

        /// <summary>
        /// Report events issued when end user interacts with customer's application
        /// that uses Cloud Talent Solution. You may inspect the created events in
        /// [self service
        /// tools](https://console.cloud.google.com/talent-solution/overview).
        /// [Learn
        /// more](https://cloud.google.com/talent-solution/docs/management-tools)
        /// about self service tools.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the tenant under which the event is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/foo/tenants/bar".
        /// </param>
        /// <param name="clientEvent">
        /// Required. Events issued when end user interacts with customer's application
        /// that uses Cloud Talent Solution.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ClientEvent> CreateClientEventAsync(TenantName parent, ClientEvent clientEvent, gaxgrpc::CallSettings callSettings = null) =>
            CreateClientEventAsync(new CreateClientEventRequest
            {
                ParentAsTenantName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ClientEvent = gax::GaxPreconditions.CheckNotNull(clientEvent, nameof(clientEvent)),
            }, callSettings);

        /// <summary>
        /// Report events issued when end user interacts with customer's application
        /// that uses Cloud Talent Solution. You may inspect the created events in
        /// [self service
        /// tools](https://console.cloud.google.com/talent-solution/overview).
        /// [Learn
        /// more](https://cloud.google.com/talent-solution/docs/management-tools)
        /// about self service tools.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the tenant under which the event is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/foo/tenants/bar".
        /// </param>
        /// <param name="clientEvent">
        /// Required. Events issued when end user interacts with customer's application
        /// that uses Cloud Talent Solution.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ClientEvent> CreateClientEventAsync(TenantName parent, ClientEvent clientEvent, st::CancellationToken cancellationToken) =>
            CreateClientEventAsync(parent, clientEvent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>EventService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service handles client event report.
    /// </remarks>
    public sealed partial class EventServiceClientImpl : EventServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateClientEventRequest, ClientEvent> _callCreateClientEvent;

        /// <summary>
        /// Constructs a client wrapper for the EventService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="EventServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public EventServiceClientImpl(EventService.EventServiceClient grpcClient, EventServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            EventServiceSettings effectiveSettings = settings ?? EventServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callCreateClientEvent = clientHelper.BuildApiCall<CreateClientEventRequest, ClientEvent>("CreateClientEvent", grpcClient.CreateClientEventAsync, grpcClient.CreateClientEvent, effectiveSettings.CreateClientEventSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateClientEvent);
            Modify_CreateClientEventApiCall(ref _callCreateClientEvent);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateClientEventApiCall(ref gaxgrpc::ApiCall<CreateClientEventRequest, ClientEvent> call);

        partial void OnConstruction(EventService.EventServiceClient grpcClient, EventServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC EventService client</summary>
        public override EventService.EventServiceClient GrpcClient { get; }

        partial void Modify_CreateClientEventRequest(ref CreateClientEventRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Report events issued when end user interacts with customer's application
        /// that uses Cloud Talent Solution. You may inspect the created events in
        /// [self service
        /// tools](https://console.cloud.google.com/talent-solution/overview).
        /// [Learn
        /// more](https://cloud.google.com/talent-solution/docs/management-tools)
        /// about self service tools.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ClientEvent CreateClientEvent(CreateClientEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateClientEventRequest(ref request, ref callSettings);
            return _callCreateClientEvent.Sync(request, callSettings);
        }

        /// <summary>
        /// Report events issued when end user interacts with customer's application
        /// that uses Cloud Talent Solution. You may inspect the created events in
        /// [self service
        /// tools](https://console.cloud.google.com/talent-solution/overview).
        /// [Learn
        /// more](https://cloud.google.com/talent-solution/docs/management-tools)
        /// about self service tools.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ClientEvent> CreateClientEventAsync(CreateClientEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateClientEventRequest(ref request, ref callSettings);
            return _callCreateClientEvent.Async(request, callSettings);
        }
    }
}
