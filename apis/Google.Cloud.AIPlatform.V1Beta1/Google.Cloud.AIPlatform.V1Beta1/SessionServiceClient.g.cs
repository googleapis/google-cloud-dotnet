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
using gciv = Google.Cloud.Iam.V1;
using gcl = Google.Cloud.Location;
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
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.AIPlatform.V1Beta1
{
    /// <summary>Settings for <see cref="SessionServiceClient"/> instances.</summary>
    public sealed partial class SessionServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SessionServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SessionServiceSettings"/>.</returns>
        public static SessionServiceSettings GetDefault() => new SessionServiceSettings();

        /// <summary>Constructs a new <see cref="SessionServiceSettings"/> object with default settings.</summary>
        public SessionServiceSettings()
        {
        }

        private SessionServiceSettings(SessionServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateSessionSettings = existing.CreateSessionSettings;
            CreateSessionOperationsSettings = existing.CreateSessionOperationsSettings.Clone();
            GetSessionSettings = existing.GetSessionSettings;
            ListSessionsSettings = existing.ListSessionsSettings;
            UpdateSessionSettings = existing.UpdateSessionSettings;
            DeleteSessionSettings = existing.DeleteSessionSettings;
            DeleteSessionOperationsSettings = existing.DeleteSessionOperationsSettings.Clone();
            ListEventsSettings = existing.ListEventsSettings;
            AppendEventSettings = existing.AppendEventSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(SessionServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SessionServiceClient.CreateSession</c> and <c>SessionServiceClient.CreateSessionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSessionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SessionServiceClient.CreateSession</c> and
        /// <c>SessionServiceClient.CreateSessionAsync</c>.
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
        public lro::OperationsSettings CreateSessionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SessionServiceClient.GetSession</c> and <c>SessionServiceClient.GetSessionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSessionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SessionServiceClient.ListSessions</c> and <c>SessionServiceClient.ListSessionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSessionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SessionServiceClient.UpdateSession</c> and <c>SessionServiceClient.UpdateSessionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSessionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SessionServiceClient.DeleteSession</c> and <c>SessionServiceClient.DeleteSessionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSessionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SessionServiceClient.DeleteSession</c> and
        /// <c>SessionServiceClient.DeleteSessionAsync</c>.
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
        public lro::OperationsSettings DeleteSessionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SessionServiceClient.ListEvents</c> and <c>SessionServiceClient.ListEventsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEventsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SessionServiceClient.AppendEvent</c> and <c>SessionServiceClient.AppendEventAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AppendEventSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SessionServiceSettings"/> object.</returns>
        public SessionServiceSettings Clone() => new SessionServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SessionServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class SessionServiceClientBuilder : gaxgrpc::ClientBuilderBase<SessionServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SessionServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SessionServiceClientBuilder() : base(SessionServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SessionServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SessionServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SessionServiceClient Build()
        {
            SessionServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SessionServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SessionServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SessionServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SessionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SessionServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SessionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SessionServiceClient.ChannelPool;
    }

    /// <summary>SessionService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The service that manages Vertex Session related resources.
    /// </remarks>
    public abstract partial class SessionServiceClient
    {
        /// <summary>
        /// The default endpoint for the SessionService service, which is a host of "aiplatform.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "aiplatform.googleapis.com:443";

        /// <summary>The default SessionService scopes.</summary>
        /// <remarks>
        /// The default SessionService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(SessionService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SessionServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SessionServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SessionServiceClient"/>.</returns>
        public static stt::Task<SessionServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SessionServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SessionServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SessionServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SessionServiceClient"/>.</returns>
        public static SessionServiceClient Create() => new SessionServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SessionServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SessionServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SessionServiceClient"/>.</returns>
        internal static SessionServiceClient Create(grpccore::CallInvoker callInvoker, SessionServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SessionService.SessionServiceClient grpcClient = new SessionService.SessionServiceClient(callInvoker);
            return new SessionServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC SessionService client</summary>
        public virtual SessionService.SessionServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new [Session][google.cloud.aiplatform.v1beta1.Session].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Session, CreateSessionOperationMetadata> CreateSession(CreateSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new [Session][google.cloud.aiplatform.v1beta1.Session].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Session, CreateSessionOperationMetadata>> CreateSessionAsync(CreateSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new [Session][google.cloud.aiplatform.v1beta1.Session].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Session, CreateSessionOperationMetadata>> CreateSessionAsync(CreateSessionRequest request, st::CancellationToken cancellationToken) =>
            CreateSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateSession</c>.</summary>
        public virtual lro::OperationsClient CreateSessionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateSession</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Session, CreateSessionOperationMetadata> PollOnceCreateSession(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Session, CreateSessionOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSessionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateSession</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Session, CreateSessionOperationMetadata>> PollOnceCreateSessionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Session, CreateSessionOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSessionOperationsClient, callSettings);

        /// <summary>
        /// Creates a new [Session][google.cloud.aiplatform.v1beta1.Session].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to create the session in.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}`
        /// </param>
        /// <param name="session">
        /// Required. The session to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Session, CreateSessionOperationMetadata> CreateSession(string parent, Session session, gaxgrpc::CallSettings callSettings = null) =>
            CreateSession(new CreateSessionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Session = gax::GaxPreconditions.CheckNotNull(session, nameof(session)),
            }, callSettings);

        /// <summary>
        /// Creates a new [Session][google.cloud.aiplatform.v1beta1.Session].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to create the session in.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}`
        /// </param>
        /// <param name="session">
        /// Required. The session to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Session, CreateSessionOperationMetadata>> CreateSessionAsync(string parent, Session session, gaxgrpc::CallSettings callSettings = null) =>
            CreateSessionAsync(new CreateSessionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Session = gax::GaxPreconditions.CheckNotNull(session, nameof(session)),
            }, callSettings);

        /// <summary>
        /// Creates a new [Session][google.cloud.aiplatform.v1beta1.Session].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to create the session in.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}`
        /// </param>
        /// <param name="session">
        /// Required. The session to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Session, CreateSessionOperationMetadata>> CreateSessionAsync(string parent, Session session, st::CancellationToken cancellationToken) =>
            CreateSessionAsync(parent, session, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new [Session][google.cloud.aiplatform.v1beta1.Session].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to create the session in.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}`
        /// </param>
        /// <param name="session">
        /// Required. The session to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Session, CreateSessionOperationMetadata> CreateSession(ReasoningEngineName parent, Session session, gaxgrpc::CallSettings callSettings = null) =>
            CreateSession(new CreateSessionRequest
            {
                ParentAsReasoningEngineName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Session = gax::GaxPreconditions.CheckNotNull(session, nameof(session)),
            }, callSettings);

        /// <summary>
        /// Creates a new [Session][google.cloud.aiplatform.v1beta1.Session].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to create the session in.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}`
        /// </param>
        /// <param name="session">
        /// Required. The session to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Session, CreateSessionOperationMetadata>> CreateSessionAsync(ReasoningEngineName parent, Session session, gaxgrpc::CallSettings callSettings = null) =>
            CreateSessionAsync(new CreateSessionRequest
            {
                ParentAsReasoningEngineName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Session = gax::GaxPreconditions.CheckNotNull(session, nameof(session)),
            }, callSettings);

        /// <summary>
        /// Creates a new [Session][google.cloud.aiplatform.v1beta1.Session].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to create the session in.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}`
        /// </param>
        /// <param name="session">
        /// Required. The session to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Session, CreateSessionOperationMetadata>> CreateSessionAsync(ReasoningEngineName parent, Session session, st::CancellationToken cancellationToken) =>
            CreateSessionAsync(parent, session, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of the specific
        /// [Session][google.cloud.aiplatform.v1beta1.Session].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Session GetSession(GetSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of the specific
        /// [Session][google.cloud.aiplatform.v1beta1.Session].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> GetSessionAsync(GetSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of the specific
        /// [Session][google.cloud.aiplatform.v1beta1.Session].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> GetSessionAsync(GetSessionRequest request, st::CancellationToken cancellationToken) =>
            GetSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of the specific
        /// [Session][google.cloud.aiplatform.v1beta1.Session].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the session.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/sessions/{session}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Session GetSession(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSession(new GetSessionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specific
        /// [Session][google.cloud.aiplatform.v1beta1.Session].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the session.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/sessions/{session}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> GetSessionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSessionAsync(new GetSessionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specific
        /// [Session][google.cloud.aiplatform.v1beta1.Session].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the session.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/sessions/{session}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> GetSessionAsync(string name, st::CancellationToken cancellationToken) =>
            GetSessionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of the specific
        /// [Session][google.cloud.aiplatform.v1beta1.Session].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the session.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/sessions/{session}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Session GetSession(SessionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSession(new GetSessionRequest
            {
                SessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specific
        /// [Session][google.cloud.aiplatform.v1beta1.Session].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the session.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/sessions/{session}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> GetSessionAsync(SessionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSessionAsync(new GetSessionRequest
            {
                SessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specific
        /// [Session][google.cloud.aiplatform.v1beta1.Session].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the session.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/sessions/{session}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> GetSessionAsync(SessionName name, st::CancellationToken cancellationToken) =>
            GetSessionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists [Sessions][google.cloud.aiplatform.v1beta1.Session] in a given
        /// reasoning engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Session"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSessionsResponse, Session> ListSessions(ListSessionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [Sessions][google.cloud.aiplatform.v1beta1.Session] in a given
        /// reasoning engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Session"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSessionsResponse, Session> ListSessionsAsync(ListSessionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [Sessions][google.cloud.aiplatform.v1beta1.Session] in a given
        /// reasoning engine.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to list sessions from.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}`
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
        /// <returns>A pageable sequence of <see cref="Session"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSessionsResponse, Session> ListSessions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSessionsRequest request = new ListSessionsRequest
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
            return ListSessions(request, callSettings);
        }

        /// <summary>
        /// Lists [Sessions][google.cloud.aiplatform.v1beta1.Session] in a given
        /// reasoning engine.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to list sessions from.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Session"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSessionsResponse, Session> ListSessionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSessionsRequest request = new ListSessionsRequest
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
            return ListSessionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists [Sessions][google.cloud.aiplatform.v1beta1.Session] in a given
        /// reasoning engine.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to list sessions from.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}`
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
        /// <returns>A pageable sequence of <see cref="Session"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSessionsResponse, Session> ListSessions(ReasoningEngineName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSessionsRequest request = new ListSessionsRequest
            {
                ParentAsReasoningEngineName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSessions(request, callSettings);
        }

        /// <summary>
        /// Lists [Sessions][google.cloud.aiplatform.v1beta1.Session] in a given
        /// reasoning engine.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location to list sessions from.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Session"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSessionsResponse, Session> ListSessionsAsync(ReasoningEngineName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSessionsRequest request = new ListSessionsRequest
            {
                ParentAsReasoningEngineName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSessionsAsync(request, callSettings);
        }

        /// <summary>
        /// Updates the specific [Session][google.cloud.aiplatform.v1beta1.Session].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Session UpdateSession(UpdateSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specific [Session][google.cloud.aiplatform.v1beta1.Session].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> UpdateSessionAsync(UpdateSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specific [Session][google.cloud.aiplatform.v1beta1.Session].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> UpdateSessionAsync(UpdateSessionRequest request, st::CancellationToken cancellationToken) =>
            UpdateSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specific [Session][google.cloud.aiplatform.v1beta1.Session].
        /// </summary>
        /// <param name="session">
        /// Required. The session to update.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/sessions/{session}`
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to control which fields get updated. If the
        /// mask is not present, all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Session UpdateSession(Session session, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSession(new UpdateSessionRequest
            {
                Session = gax::GaxPreconditions.CheckNotNull(session, nameof(session)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specific [Session][google.cloud.aiplatform.v1beta1.Session].
        /// </summary>
        /// <param name="session">
        /// Required. The session to update.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/sessions/{session}`
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to control which fields get updated. If the
        /// mask is not present, all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> UpdateSessionAsync(Session session, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSessionAsync(new UpdateSessionRequest
            {
                Session = gax::GaxPreconditions.CheckNotNull(session, nameof(session)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specific [Session][google.cloud.aiplatform.v1beta1.Session].
        /// </summary>
        /// <param name="session">
        /// Required. The session to update.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/sessions/{session}`
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to control which fields get updated. If the
        /// mask is not present, all fields will be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> UpdateSessionAsync(Session session, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSessionAsync(session, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes details of the specific
        /// [Session][google.cloud.aiplatform.v1beta1.Session].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteSession(DeleteSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes details of the specific
        /// [Session][google.cloud.aiplatform.v1beta1.Session].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteSessionAsync(DeleteSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes details of the specific
        /// [Session][google.cloud.aiplatform.v1beta1.Session].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteSessionAsync(DeleteSessionRequest request, st::CancellationToken cancellationToken) =>
            DeleteSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteSession</c>.</summary>
        public virtual lro::OperationsClient DeleteSessionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteSession</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> PollOnceDeleteSession(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteSessionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteSession</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> PollOnceDeleteSessionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteSessionOperationsClient, callSettings);

        /// <summary>
        /// Deletes details of the specific
        /// [Session][google.cloud.aiplatform.v1beta1.Session].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the session.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/sessions/{session}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteSession(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSession(new DeleteSessionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes details of the specific
        /// [Session][google.cloud.aiplatform.v1beta1.Session].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the session.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/sessions/{session}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteSessionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSessionAsync(new DeleteSessionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes details of the specific
        /// [Session][google.cloud.aiplatform.v1beta1.Session].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the session.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/sessions/{session}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteSessionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSessionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes details of the specific
        /// [Session][google.cloud.aiplatform.v1beta1.Session].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the session.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/sessions/{session}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteSession(SessionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSession(new DeleteSessionRequest
            {
                SessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes details of the specific
        /// [Session][google.cloud.aiplatform.v1beta1.Session].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the session.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/sessions/{session}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteSessionAsync(SessionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSessionAsync(new DeleteSessionRequest
            {
                SessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes details of the specific
        /// [Session][google.cloud.aiplatform.v1beta1.Session].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the session.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/sessions/{session}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteSessionAsync(SessionName name, st::CancellationToken cancellationToken) =>
            DeleteSessionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists [Events][google.cloud.aiplatform.v1beta1.Event] in a given session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SessionEvent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEventsResponse, SessionEvent> ListEvents(ListEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [Events][google.cloud.aiplatform.v1beta1.Event] in a given session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SessionEvent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEventsResponse, SessionEvent> ListEventsAsync(ListEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [Events][google.cloud.aiplatform.v1beta1.Event] in a given session.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the session to list events from.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/sessions/{session}`
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
        /// <returns>A pageable sequence of <see cref="SessionEvent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEventsResponse, SessionEvent> ListEvents(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEventsRequest request = new ListEventsRequest
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
            return ListEvents(request, callSettings);
        }

        /// <summary>
        /// Lists [Events][google.cloud.aiplatform.v1beta1.Event] in a given session.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the session to list events from.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/sessions/{session}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="SessionEvent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEventsResponse, SessionEvent> ListEventsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEventsRequest request = new ListEventsRequest
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
            return ListEventsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists [Events][google.cloud.aiplatform.v1beta1.Event] in a given session.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the session to list events from.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/sessions/{session}`
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
        /// <returns>A pageable sequence of <see cref="SessionEvent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEventsResponse, SessionEvent> ListEvents(SessionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEventsRequest request = new ListEventsRequest
            {
                ParentAsSessionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEvents(request, callSettings);
        }

        /// <summary>
        /// Lists [Events][google.cloud.aiplatform.v1beta1.Event] in a given session.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the session to list events from.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/sessions/{session}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="SessionEvent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEventsResponse, SessionEvent> ListEventsAsync(SessionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEventsRequest request = new ListEventsRequest
            {
                ParentAsSessionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEventsAsync(request, callSettings);
        }

        /// <summary>
        /// Appends an event to a given session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AppendEventResponse AppendEvent(AppendEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Appends an event to a given session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppendEventResponse> AppendEventAsync(AppendEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Appends an event to a given session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppendEventResponse> AppendEventAsync(AppendEventRequest request, st::CancellationToken cancellationToken) =>
            AppendEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Appends an event to a given session.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the session to append event to.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/sessions/{session}`
        /// </param>
        /// <param name="event">
        /// Required. The event to append to the session.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AppendEventResponse AppendEvent(string name, SessionEvent @event, gaxgrpc::CallSettings callSettings = null) =>
            AppendEvent(new AppendEventRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Event = gax::GaxPreconditions.CheckNotNull(@event, nameof(@event)),
            }, callSettings);

        /// <summary>
        /// Appends an event to a given session.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the session to append event to.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/sessions/{session}`
        /// </param>
        /// <param name="event">
        /// Required. The event to append to the session.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppendEventResponse> AppendEventAsync(string name, SessionEvent @event, gaxgrpc::CallSettings callSettings = null) =>
            AppendEventAsync(new AppendEventRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Event = gax::GaxPreconditions.CheckNotNull(@event, nameof(@event)),
            }, callSettings);

        /// <summary>
        /// Appends an event to a given session.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the session to append event to.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/sessions/{session}`
        /// </param>
        /// <param name="event">
        /// Required. The event to append to the session.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppendEventResponse> AppendEventAsync(string name, SessionEvent @event, st::CancellationToken cancellationToken) =>
            AppendEventAsync(name, @event, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Appends an event to a given session.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the session to append event to.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/sessions/{session}`
        /// </param>
        /// <param name="event">
        /// Required. The event to append to the session.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AppendEventResponse AppendEvent(SessionName name, SessionEvent @event, gaxgrpc::CallSettings callSettings = null) =>
            AppendEvent(new AppendEventRequest
            {
                SessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Event = gax::GaxPreconditions.CheckNotNull(@event, nameof(@event)),
            }, callSettings);

        /// <summary>
        /// Appends an event to a given session.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the session to append event to.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/sessions/{session}`
        /// </param>
        /// <param name="event">
        /// Required. The event to append to the session.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppendEventResponse> AppendEventAsync(SessionName name, SessionEvent @event, gaxgrpc::CallSettings callSettings = null) =>
            AppendEventAsync(new AppendEventRequest
            {
                SessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Event = gax::GaxPreconditions.CheckNotNull(@event, nameof(@event)),
            }, callSettings);

        /// <summary>
        /// Appends an event to a given session.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the session to append event to.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/sessions/{session}`
        /// </param>
        /// <param name="event">
        /// Required. The event to append to the session.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppendEventResponse> AppendEventAsync(SessionName name, SessionEvent @event, st::CancellationToken cancellationToken) =>
            AppendEventAsync(name, @event, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>SessionService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The service that manages Vertex Session related resources.
    /// </remarks>
    public sealed partial class SessionServiceClientImpl : SessionServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateSessionRequest, lro::Operation> _callCreateSession;

        private readonly gaxgrpc::ApiCall<GetSessionRequest, Session> _callGetSession;

        private readonly gaxgrpc::ApiCall<ListSessionsRequest, ListSessionsResponse> _callListSessions;

        private readonly gaxgrpc::ApiCall<UpdateSessionRequest, Session> _callUpdateSession;

        private readonly gaxgrpc::ApiCall<DeleteSessionRequest, lro::Operation> _callDeleteSession;

        private readonly gaxgrpc::ApiCall<ListEventsRequest, ListEventsResponse> _callListEvents;

        private readonly gaxgrpc::ApiCall<AppendEventRequest, AppendEventResponse> _callAppendEvent;

        /// <summary>
        /// Constructs a client wrapper for the SessionService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SessionServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SessionServiceClientImpl(SessionService.SessionServiceClient grpcClient, SessionServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SessionServiceSettings effectiveSettings = settings ?? SessionServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateSessionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateSessionOperationsSettings, logger);
            DeleteSessionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteSessionOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreateSession = clientHelper.BuildApiCall<CreateSessionRequest, lro::Operation>("CreateSession", grpcClient.CreateSessionAsync, grpcClient.CreateSession, effectiveSettings.CreateSessionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSession);
            Modify_CreateSessionApiCall(ref _callCreateSession);
            _callGetSession = clientHelper.BuildApiCall<GetSessionRequest, Session>("GetSession", grpcClient.GetSessionAsync, grpcClient.GetSession, effectiveSettings.GetSessionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSession);
            Modify_GetSessionApiCall(ref _callGetSession);
            _callListSessions = clientHelper.BuildApiCall<ListSessionsRequest, ListSessionsResponse>("ListSessions", grpcClient.ListSessionsAsync, grpcClient.ListSessions, effectiveSettings.ListSessionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSessions);
            Modify_ListSessionsApiCall(ref _callListSessions);
            _callUpdateSession = clientHelper.BuildApiCall<UpdateSessionRequest, Session>("UpdateSession", grpcClient.UpdateSessionAsync, grpcClient.UpdateSession, effectiveSettings.UpdateSessionSettings).WithGoogleRequestParam("session.name", request => request.Session?.Name);
            Modify_ApiCall(ref _callUpdateSession);
            Modify_UpdateSessionApiCall(ref _callUpdateSession);
            _callDeleteSession = clientHelper.BuildApiCall<DeleteSessionRequest, lro::Operation>("DeleteSession", grpcClient.DeleteSessionAsync, grpcClient.DeleteSession, effectiveSettings.DeleteSessionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSession);
            Modify_DeleteSessionApiCall(ref _callDeleteSession);
            _callListEvents = clientHelper.BuildApiCall<ListEventsRequest, ListEventsResponse>("ListEvents", grpcClient.ListEventsAsync, grpcClient.ListEvents, effectiveSettings.ListEventsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEvents);
            Modify_ListEventsApiCall(ref _callListEvents);
            _callAppendEvent = clientHelper.BuildApiCall<AppendEventRequest, AppendEventResponse>("AppendEvent", grpcClient.AppendEventAsync, grpcClient.AppendEvent, effectiveSettings.AppendEventSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callAppendEvent);
            Modify_AppendEventApiCall(ref _callAppendEvent);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateSessionApiCall(ref gaxgrpc::ApiCall<CreateSessionRequest, lro::Operation> call);

        partial void Modify_GetSessionApiCall(ref gaxgrpc::ApiCall<GetSessionRequest, Session> call);

        partial void Modify_ListSessionsApiCall(ref gaxgrpc::ApiCall<ListSessionsRequest, ListSessionsResponse> call);

        partial void Modify_UpdateSessionApiCall(ref gaxgrpc::ApiCall<UpdateSessionRequest, Session> call);

        partial void Modify_DeleteSessionApiCall(ref gaxgrpc::ApiCall<DeleteSessionRequest, lro::Operation> call);

        partial void Modify_ListEventsApiCall(ref gaxgrpc::ApiCall<ListEventsRequest, ListEventsResponse> call);

        partial void Modify_AppendEventApiCall(ref gaxgrpc::ApiCall<AppendEventRequest, AppendEventResponse> call);

        partial void OnConstruction(SessionService.SessionServiceClient grpcClient, SessionServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SessionService client</summary>
        public override SessionService.SessionServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateSessionRequest(ref CreateSessionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSessionRequest(ref GetSessionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSessionsRequest(ref ListSessionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSessionRequest(ref UpdateSessionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSessionRequest(ref DeleteSessionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListEventsRequest(ref ListEventsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AppendEventRequest(ref AppendEventRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateSession</c>.</summary>
        public override lro::OperationsClient CreateSessionOperationsClient { get; }

        /// <summary>
        /// Creates a new [Session][google.cloud.aiplatform.v1beta1.Session].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Session, CreateSessionOperationMetadata> CreateSession(CreateSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSessionRequest(ref request, ref callSettings);
            return new lro::Operation<Session, CreateSessionOperationMetadata>(_callCreateSession.Sync(request, callSettings), CreateSessionOperationsClient);
        }

        /// <summary>
        /// Creates a new [Session][google.cloud.aiplatform.v1beta1.Session].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Session, CreateSessionOperationMetadata>> CreateSessionAsync(CreateSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSessionRequest(ref request, ref callSettings);
            return new lro::Operation<Session, CreateSessionOperationMetadata>(await _callCreateSession.Async(request, callSettings).ConfigureAwait(false), CreateSessionOperationsClient);
        }

        /// <summary>
        /// Gets details of the specific
        /// [Session][google.cloud.aiplatform.v1beta1.Session].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Session GetSession(GetSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSessionRequest(ref request, ref callSettings);
            return _callGetSession.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of the specific
        /// [Session][google.cloud.aiplatform.v1beta1.Session].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Session> GetSessionAsync(GetSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSessionRequest(ref request, ref callSettings);
            return _callGetSession.Async(request, callSettings);
        }

        /// <summary>
        /// Lists [Sessions][google.cloud.aiplatform.v1beta1.Session] in a given
        /// reasoning engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Session"/> resources.</returns>
        public override gax::PagedEnumerable<ListSessionsResponse, Session> ListSessions(ListSessionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSessionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSessionsRequest, ListSessionsResponse, Session>(_callListSessions, request, callSettings);
        }

        /// <summary>
        /// Lists [Sessions][google.cloud.aiplatform.v1beta1.Session] in a given
        /// reasoning engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Session"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSessionsResponse, Session> ListSessionsAsync(ListSessionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSessionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSessionsRequest, ListSessionsResponse, Session>(_callListSessions, request, callSettings);
        }

        /// <summary>
        /// Updates the specific [Session][google.cloud.aiplatform.v1beta1.Session].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Session UpdateSession(UpdateSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSessionRequest(ref request, ref callSettings);
            return _callUpdateSession.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specific [Session][google.cloud.aiplatform.v1beta1.Session].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Session> UpdateSessionAsync(UpdateSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSessionRequest(ref request, ref callSettings);
            return _callUpdateSession.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteSession</c>.</summary>
        public override lro::OperationsClient DeleteSessionOperationsClient { get; }

        /// <summary>
        /// Deletes details of the specific
        /// [Session][google.cloud.aiplatform.v1beta1.Session].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteSession(DeleteSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSessionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(_callDeleteSession.Sync(request, callSettings), DeleteSessionOperationsClient);
        }

        /// <summary>
        /// Deletes details of the specific
        /// [Session][google.cloud.aiplatform.v1beta1.Session].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteSessionAsync(DeleteSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSessionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(await _callDeleteSession.Async(request, callSettings).ConfigureAwait(false), DeleteSessionOperationsClient);
        }

        /// <summary>
        /// Lists [Events][google.cloud.aiplatform.v1beta1.Event] in a given session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SessionEvent"/> resources.</returns>
        public override gax::PagedEnumerable<ListEventsResponse, SessionEvent> ListEvents(ListEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEventsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEventsRequest, ListEventsResponse, SessionEvent>(_callListEvents, request, callSettings);
        }

        /// <summary>
        /// Lists [Events][google.cloud.aiplatform.v1beta1.Event] in a given session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SessionEvent"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEventsResponse, SessionEvent> ListEventsAsync(ListEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEventsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEventsRequest, ListEventsResponse, SessionEvent>(_callListEvents, request, callSettings);
        }

        /// <summary>
        /// Appends an event to a given session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AppendEventResponse AppendEvent(AppendEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AppendEventRequest(ref request, ref callSettings);
            return _callAppendEvent.Sync(request, callSettings);
        }

        /// <summary>
        /// Appends an event to a given session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AppendEventResponse> AppendEventAsync(AppendEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AppendEventRequest(ref request, ref callSettings);
            return _callAppendEvent.Async(request, callSettings);
        }
    }

    public partial class ListSessionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEventsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSessionsResponse : gaxgrpc::IPageResponse<Session>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Session> GetEnumerator() => Sessions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListEventsResponse : gaxgrpc::IPageResponse<SessionEvent>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<SessionEvent> GetEnumerator() => SessionEvents.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class SessionService
    {
        public partial class SessionServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() =>
                new lro::Operations.OperationsClient(CallInvoker);
        }
    }

    public static partial class SessionService
    {
        public partial class SessionServiceClient
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
