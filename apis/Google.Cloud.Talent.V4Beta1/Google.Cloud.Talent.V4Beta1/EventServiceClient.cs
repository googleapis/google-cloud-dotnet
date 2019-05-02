// Copyright 2019 Google LLC
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
using pb = Google.Protobuf;
using pbwkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Talent.V4Beta1
{
    /// <summary>
    /// Settings for a <see cref="EventServiceClient"/>.
    /// </summary>
    public sealed partial class EventServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="EventServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="EventServiceSettings"/>.
        /// </returns>
        public static EventServiceSettings GetDefault() => new EventServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="EventServiceSettings"/> object with default settings.
        /// </summary>
        public EventServiceSettings() { }

        private EventServiceSettings(EventServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateClientEventSettings = existing.CreateClientEventSettings;
            OnCopy(existing);
        }

        partial void OnCopy(EventServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="EventServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="grpccore::StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> IdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="EventServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="EventServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="EventServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="EventServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(100),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="EventServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="EventServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="EventServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 20000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(20000),
            maxDelay: sys::TimeSpan.FromMilliseconds(20000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EventServiceClient.CreateClientEvent</c> and <c>EventServiceClient.CreateClientEventAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>EventServiceClient.CreateClientEvent</c> and
        /// <c>EventServiceClient.CreateClientEventAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings CreateClientEventSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="EventServiceSettings"/> object.</returns>
        public EventServiceSettings Clone() => new EventServiceSettings(this);
    }

    /// <summary>
    /// EventService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class EventServiceClient
    {
        /// <summary>
        /// The default endpoint for the EventService service, which is a host of "jobs.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("jobs.googleapis.com", 443);

        /// <summary>
        /// The default EventService scopes.
        /// </summary>
        /// <remarks>
        /// The default EventService scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/jobs"</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/jobs",
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="EventServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Talent.V4Beta1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// EventServiceClient client = await EventServiceClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Talent.V4Beta1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     EventServiceClient.DefaultEndpoint.Host, EventServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// EventServiceClient client = EventServiceClient.Create(channel);
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
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
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
        /// using Google.Cloud.Talent.V4Beta1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// EventServiceClient client = EventServiceClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Talent.V4Beta1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     EventServiceClient.DefaultEndpoint.Host, EventServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// EventServiceClient client = EventServiceClient.Create(channel);
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
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
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
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="EventServiceSettings"/>.</param>
        /// <returns>The created <see cref="EventServiceClient"/>.</returns>
        public static EventServiceClient Create(grpccore::CallInvoker callInvoker, EventServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            EventService.EventServiceClient grpcClient = new EventService.EventServiceClient(callInvoker);
            return new EventServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, EventServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, EventServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, EventServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, EventServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC EventService client.
        /// </summary>
        public virtual EventService.EventServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
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
        /// <param name="parent">
        /// Required.
        ///
        /// Resource name of the tenant under which the event is created.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/api-test-project/tenant/foo".
        ///
        /// Tenant id is optional and a default tenant is created if unspecified, for
        /// example, "projects/api-test-project".
        /// </param>
        /// <param name="clientEvent">
        /// Required.
        ///
        /// Events issued when end user interacts with customer's application that
        /// uses Cloud Talent Solution.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ClientEvent> CreateClientEventAsync(
            TenantOrProjectNameOneof parent,
            ClientEvent clientEvent,
            gaxgrpc::CallSettings callSettings = null) => CreateClientEventAsync(
                new CreateClientEventRequest
                {
                    ParentAsTenantOrProjectNameOneof = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    ClientEvent = gax::GaxPreconditions.CheckNotNull(clientEvent, nameof(clientEvent)),
                },
                callSettings);

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
        /// Required.
        ///
        /// Resource name of the tenant under which the event is created.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/api-test-project/tenant/foo".
        ///
        /// Tenant id is optional and a default tenant is created if unspecified, for
        /// example, "projects/api-test-project".
        /// </param>
        /// <param name="clientEvent">
        /// Required.
        ///
        /// Events issued when end user interacts with customer's application that
        /// uses Cloud Talent Solution.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ClientEvent> CreateClientEventAsync(
            TenantOrProjectNameOneof parent,
            ClientEvent clientEvent,
            st::CancellationToken cancellationToken) => CreateClientEventAsync(
                parent,
                clientEvent,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// Required.
        ///
        /// Resource name of the tenant under which the event is created.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/api-test-project/tenant/foo".
        ///
        /// Tenant id is optional and a default tenant is created if unspecified, for
        /// example, "projects/api-test-project".
        /// </param>
        /// <param name="clientEvent">
        /// Required.
        ///
        /// Events issued when end user interacts with customer's application that
        /// uses Cloud Talent Solution.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ClientEvent CreateClientEvent(
            TenantOrProjectNameOneof parent,
            ClientEvent clientEvent,
            gaxgrpc::CallSettings callSettings = null) => CreateClientEvent(
                new CreateClientEventRequest
                {
                    ParentAsTenantOrProjectNameOneof = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    ClientEvent = gax::GaxPreconditions.CheckNotNull(clientEvent, nameof(clientEvent)),
                },
                callSettings);

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
        /// Required.
        ///
        /// Resource name of the tenant under which the event is created.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/api-test-project/tenant/foo".
        ///
        /// Tenant id is optional and a default tenant is created if unspecified, for
        /// example, "projects/api-test-project".
        /// </param>
        /// <param name="clientEvent">
        /// Required.
        ///
        /// Events issued when end user interacts with customer's application that
        /// uses Cloud Talent Solution.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ClientEvent> CreateClientEventAsync(
            string parent,
            ClientEvent clientEvent,
            gaxgrpc::CallSettings callSettings = null) => CreateClientEventAsync(
                new CreateClientEventRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    ClientEvent = gax::GaxPreconditions.CheckNotNull(clientEvent, nameof(clientEvent)),
                },
                callSettings);

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
        /// Required.
        ///
        /// Resource name of the tenant under which the event is created.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/api-test-project/tenant/foo".
        ///
        /// Tenant id is optional and a default tenant is created if unspecified, for
        /// example, "projects/api-test-project".
        /// </param>
        /// <param name="clientEvent">
        /// Required.
        ///
        /// Events issued when end user interacts with customer's application that
        /// uses Cloud Talent Solution.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ClientEvent> CreateClientEventAsync(
            string parent,
            ClientEvent clientEvent,
            st::CancellationToken cancellationToken) => CreateClientEventAsync(
                parent,
                clientEvent,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// Required.
        ///
        /// Resource name of the tenant under which the event is created.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/api-test-project/tenant/foo".
        ///
        /// Tenant id is optional and a default tenant is created if unspecified, for
        /// example, "projects/api-test-project".
        /// </param>
        /// <param name="clientEvent">
        /// Required.
        ///
        /// Events issued when end user interacts with customer's application that
        /// uses Cloud Talent Solution.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ClientEvent CreateClientEvent(
            string parent,
            ClientEvent clientEvent,
            gaxgrpc::CallSettings callSettings = null) => CreateClientEvent(
                new CreateClientEventRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    ClientEvent = gax::GaxPreconditions.CheckNotNull(clientEvent, nameof(clientEvent)),
                },
                callSettings);

        /// <summary>
        /// Report events issued when end user interacts with customer's application
        /// that uses Cloud Talent Solution. You may inspect the created events in
        /// [self service
        /// tools](https://console.cloud.google.com/talent-solution/overview).
        /// [Learn
        /// more](https://cloud.google.com/talent-solution/docs/management-tools)
        /// about self service tools.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ClientEvent> CreateClientEventAsync(
            CreateClientEventRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ClientEvent> CreateClientEventAsync(
            CreateClientEventRequest request,
            st::CancellationToken cancellationToken) => CreateClientEventAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Report events issued when end user interacts with customer's application
        /// that uses Cloud Talent Solution. You may inspect the created events in
        /// [self service
        /// tools](https://console.cloud.google.com/talent-solution/overview).
        /// [Learn
        /// more](https://cloud.google.com/talent-solution/docs/management-tools)
        /// about self service tools.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ClientEvent CreateClientEvent(
            CreateClientEventRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// EventService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class EventServiceClientImpl : EventServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateClientEventRequest, ClientEvent> _callCreateClientEvent;

        /// <summary>
        /// Constructs a client wrapper for the EventService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="EventServiceSettings"/> used within this client </param>
        public EventServiceClientImpl(EventService.EventServiceClient grpcClient, EventServiceSettings settings)
        {
            GrpcClient = grpcClient;
            EventServiceSettings effectiveSettings = settings ?? EventServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callCreateClientEvent = clientHelper.BuildApiCall<CreateClientEventRequest, ClientEvent>(
                GrpcClient.CreateClientEventAsync, GrpcClient.CreateClientEvent, effectiveSettings.CreateClientEventSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            Modify_ApiCall(ref _callCreateClientEvent);
            Modify_CreateClientEventApiCall(ref _callCreateClientEvent);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        // Partial methods are named to (mostly) ensure there cannot be conflicts with RPC method names.

        // Partial methods called for every ApiCall on construction.
        // Allows modification of all the underlying ApiCall objects.
        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call)
            where TRequest : class, pb::IMessage<TRequest>
            where TResponse : class, pb::IMessage<TResponse>;

        // Partial methods called for each ApiCall on construction.
        // Allows per-RPC-method modification of the underlying ApiCall object.
        partial void Modify_CreateClientEventApiCall(ref gaxgrpc::ApiCall<CreateClientEventRequest, ClientEvent> call);
        partial void OnConstruction(EventService.EventServiceClient grpcClient, EventServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC EventService client.
        /// </summary>
        public override EventService.EventServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
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
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<ClientEvent> CreateClientEventAsync(
            CreateClientEventRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateClientEventRequest(ref request, ref callSettings);
            return _callCreateClientEvent.Async(request, callSettings);
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
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override ClientEvent CreateClientEvent(
            CreateClientEventRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateClientEventRequest(ref request, ref callSettings);
            return _callCreateClientEvent.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}
