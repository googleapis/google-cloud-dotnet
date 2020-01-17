// Copyright 2020 Google LLC
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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Talent.V4Beta1
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
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateClientEventSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

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

        /// <inheritdoc/>
        public override EventServiceClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return EventServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc/>
        public override async stt::Task<EventServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return EventServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc/>
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => EventServiceClient.DefaultEndpoint;

        /// <inheritdoc/>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => EventServiceClient.DefaultScopes;

        /// <inheritdoc/>
        protected override gaxgrpc::ChannelPool GetChannelPool() => EventServiceClient.ChannelPool;
    }

    /// <summary>EventService client wrapper, for convenient use.</summary>
    public abstract partial class EventServiceClient
    {
        /// <summary>
        /// The default endpoint for the EventService service, which is a host of "jobs.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("jobs.googleapis.com", 443);

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

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="EventServiceClient"/>, applying defaults for all unspecified settings, 
        /// and creating a channel connecting to the given endpoint with application default credentials where 
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ImageAnnotatorClient client = await ImageAnnotatorClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ImageAnnotatorClient.DefaultEndpoint.Host, ImageAnnotatorClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ImageAnnotatorClient client = ImageAnnotatorClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="EventServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="EventServiceClient"/>.</returns>
        public static async stt::Task<EventServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, EventServiceSettings settings = null)
        {
            grpccore::Channel channel = await ChannelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="EventServiceClient"/>, applying defaults for all unspecified settings, 
        /// and creating a channel connecting to the given endpoint with application default credentials where 
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ImageAnnotatorClient client = ImageAnnotatorClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ImageAnnotatorClient.DefaultEndpoint.Host, ImageAnnotatorClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ImageAnnotatorClient client = ImageAnnotatorClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="EventServiceSettings"/>.</param>
        /// <returns>The created <see cref="EventServiceClient"/>.</returns>
        public static EventServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, EventServiceSettings settings = null)
        {
            grpccore::Channel channel = ChannelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="EventServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="EventServiceSettings"/>.</param>
        /// <returns>The created <see cref="EventServiceClient"/>.</returns>
        public static EventServiceClient Create(grpccore::Channel channel, EventServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="EventServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="EventServiceSettings"/>.</param>
        /// <returns>The created <see cref="EventServiceClient"/>.</returns>
        public static EventServiceClient Create(grpccore::CallInvoker callInvoker, EventServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            EventService.EventServiceClient grpcClient = new EventService.EventServiceClient(callInvoker);
            return new EventServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by
        /// <see cref="Create(grpccore::CallInvoker,EventServiceSettings)"/> and
        /// <see cref="CreateAsync(gaxgrpc::ServiceEndpoint,EventServiceSettings)"/>. Channels which weren't
        /// automatically created are not affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create(grpccore::CallInvoker,EventServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint,EventServiceSettings)"/> will create new channels, which
        /// could in turn be shut down by another call to this method.
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
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created, for example, "projects/foo".
        /// </param>
        /// <param name="clientEvent">
        /// Required. Events issued when end user interacts with customer's application that
        /// uses Cloud Talent Solution.
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
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created, for example, "projects/foo".
        /// </param>
        /// <param name="clientEvent">
        /// Required. Events issued when end user interacts with customer's application that
        /// uses Cloud Talent Solution.
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
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created, for example, "projects/foo".
        /// </param>
        /// <param name="clientEvent">
        /// Required. Events issued when end user interacts with customer's application that
        /// uses Cloud Talent Solution.
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
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created, for example, "projects/foo".
        /// </param>
        /// <param name="clientEvent">
        /// Required. Events issued when end user interacts with customer's application that
        /// uses Cloud Talent Solution.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ClientEvent CreateClientEvent(TenantOrProjectName parent, ClientEvent clientEvent, gaxgrpc::CallSettings callSettings = null) =>
            CreateClientEvent(new CreateClientEventRequest
            {
                ParentAsTenantOrProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created, for example, "projects/foo".
        /// </param>
        /// <param name="clientEvent">
        /// Required. Events issued when end user interacts with customer's application that
        /// uses Cloud Talent Solution.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ClientEvent> CreateClientEventAsync(TenantOrProjectName parent, ClientEvent clientEvent, gaxgrpc::CallSettings callSettings = null) =>
            CreateClientEventAsync(new CreateClientEventRequest
            {
                ParentAsTenantOrProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created, for example, "projects/foo".
        /// </param>
        /// <param name="clientEvent">
        /// Required. Events issued when end user interacts with customer's application that
        /// uses Cloud Talent Solution.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ClientEvent> CreateClientEventAsync(TenantOrProjectName parent, ClientEvent clientEvent, st::CancellationToken cancellationToken) =>
            CreateClientEventAsync(parent, clientEvent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>EventService client wrapper implementation, for convenient use.</summary>
    public sealed partial class EventServiceClientImpl : EventServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateClientEventRequest, ClientEvent> _callCreateClientEvent;

        /// <summary>
        /// Constructs a client wrapper for the EventService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="EventServiceSettings"/> used within this client.</param>
        public EventServiceClientImpl(EventService.EventServiceClient grpcClient, EventServiceSettings settings)
        {
            GrpcClient = grpcClient;
            EventServiceSettings effectiveSettings = settings ?? EventServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callCreateClientEvent = clientHelper.BuildApiCall<CreateClientEventRequest, ClientEvent>(grpcClient.CreateClientEventAsync, grpcClient.CreateClientEvent, effectiveSettings.CreateClientEventSettings).WithGoogleRequestParam("parent", request => request.Parent);
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
