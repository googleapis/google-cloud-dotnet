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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gciv = Google.Cloud.Iam.V1;
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

namespace Google.Cloud.Dataproc.V1
{
    /// <summary>Settings for <see cref="SessionControllerClient"/> instances.</summary>
    public sealed partial class SessionControllerSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SessionControllerSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SessionControllerSettings"/>.</returns>
        public static SessionControllerSettings GetDefault() => new SessionControllerSettings();

        /// <summary>Constructs a new <see cref="SessionControllerSettings"/> object with default settings.</summary>
        public SessionControllerSettings()
        {
        }

        private SessionControllerSettings(SessionControllerSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateSessionSettings = existing.CreateSessionSettings;
            CreateSessionOperationsSettings = existing.CreateSessionOperationsSettings.Clone();
            GetSessionSettings = existing.GetSessionSettings;
            ListSessionsSettings = existing.ListSessionsSettings;
            TerminateSessionSettings = existing.TerminateSessionSettings;
            TerminateSessionOperationsSettings = existing.TerminateSessionOperationsSettings.Clone();
            DeleteSessionSettings = existing.DeleteSessionSettings;
            DeleteSessionOperationsSettings = existing.DeleteSessionOperationsSettings.Clone();
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(SessionControllerSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SessionControllerClient.CreateSession</c> and <c>SessionControllerClient.CreateSessionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSessionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SessionControllerClient.CreateSession</c> and
        /// <c>SessionControllerClient.CreateSessionAsync</c>.
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
        /// <c>SessionControllerClient.GetSession</c> and <c>SessionControllerClient.GetSessionAsync</c>.
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
        /// <c>SessionControllerClient.ListSessions</c> and <c>SessionControllerClient.ListSessionsAsync</c>.
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
        /// <c>SessionControllerClient.TerminateSession</c> and <c>SessionControllerClient.TerminateSessionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TerminateSessionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SessionControllerClient.TerminateSession</c> and
        /// <c>SessionControllerClient.TerminateSessionAsync</c>.
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
        public lro::OperationsSettings TerminateSessionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SessionControllerClient.DeleteSession</c> and <c>SessionControllerClient.DeleteSessionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSessionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SessionControllerClient.DeleteSession</c> and
        /// <c>SessionControllerClient.DeleteSessionAsync</c>.
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
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SessionControllerSettings"/> object.</returns>
        public SessionControllerSettings Clone() => new SessionControllerSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SessionControllerClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class SessionControllerClientBuilder : gaxgrpc::ClientBuilderBase<SessionControllerClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SessionControllerSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SessionControllerClientBuilder() : base(SessionControllerClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SessionControllerClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SessionControllerClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SessionControllerClient Build()
        {
            SessionControllerClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SessionControllerClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SessionControllerClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SessionControllerClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SessionControllerClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SessionControllerClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SessionControllerClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SessionControllerClient.ChannelPool;
    }

    /// <summary>SessionController client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The `SessionController` provides methods to manage interactive sessions.
    /// </remarks>
    public abstract partial class SessionControllerClient
    {
        /// <summary>
        /// The default endpoint for the SessionController service, which is a host of "dataproc.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dataproc.googleapis.com:443";

        /// <summary>The default SessionController scopes.</summary>
        /// <remarks>
        /// The default SessionController scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(SessionController.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SessionControllerClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SessionControllerClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SessionControllerClient"/>.</returns>
        public static stt::Task<SessionControllerClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SessionControllerClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SessionControllerClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SessionControllerClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SessionControllerClient"/>.</returns>
        public static SessionControllerClient Create() => new SessionControllerClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SessionControllerClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SessionControllerSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SessionControllerClient"/>.</returns>
        internal static SessionControllerClient Create(grpccore::CallInvoker callInvoker, SessionControllerSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SessionController.SessionControllerClient grpcClient = new SessionController.SessionControllerClient(callInvoker);
            return new SessionControllerClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC SessionController client</summary>
        public virtual SessionController.SessionControllerClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Create an interactive session asynchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Session, SessionOperationMetadata> CreateSession(CreateSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create an interactive session asynchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Session, SessionOperationMetadata>> CreateSessionAsync(CreateSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create an interactive session asynchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Session, SessionOperationMetadata>> CreateSessionAsync(CreateSessionRequest request, st::CancellationToken cancellationToken) =>
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
        public virtual lro::Operation<Session, SessionOperationMetadata> PollOnceCreateSession(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Session, SessionOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSessionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateSession</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Session, SessionOperationMetadata>> PollOnceCreateSessionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Session, SessionOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSessionOperationsClient, callSettings);

        /// <summary>
        /// Create an interactive session asynchronously.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this session will be created.
        /// </param>
        /// <param name="session">
        /// Required. The interactive session to create.
        /// </param>
        /// <param name="sessionId">
        /// Required. The ID to use for the session, which becomes the final component
        /// of the session's resource name.
        /// 
        /// This value must be 4-63 characters. Valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Session, SessionOperationMetadata> CreateSession(string parent, Session session, string sessionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSession(new CreateSessionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Session = gax::GaxPreconditions.CheckNotNull(session, nameof(session)),
                SessionId = gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)),
            }, callSettings);

        /// <summary>
        /// Create an interactive session asynchronously.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this session will be created.
        /// </param>
        /// <param name="session">
        /// Required. The interactive session to create.
        /// </param>
        /// <param name="sessionId">
        /// Required. The ID to use for the session, which becomes the final component
        /// of the session's resource name.
        /// 
        /// This value must be 4-63 characters. Valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Session, SessionOperationMetadata>> CreateSessionAsync(string parent, Session session, string sessionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSessionAsync(new CreateSessionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Session = gax::GaxPreconditions.CheckNotNull(session, nameof(session)),
                SessionId = gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)),
            }, callSettings);

        /// <summary>
        /// Create an interactive session asynchronously.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this session will be created.
        /// </param>
        /// <param name="session">
        /// Required. The interactive session to create.
        /// </param>
        /// <param name="sessionId">
        /// Required. The ID to use for the session, which becomes the final component
        /// of the session's resource name.
        /// 
        /// This value must be 4-63 characters. Valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Session, SessionOperationMetadata>> CreateSessionAsync(string parent, Session session, string sessionId, st::CancellationToken cancellationToken) =>
            CreateSessionAsync(parent, session, sessionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create an interactive session asynchronously.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this session will be created.
        /// </param>
        /// <param name="session">
        /// Required. The interactive session to create.
        /// </param>
        /// <param name="sessionId">
        /// Required. The ID to use for the session, which becomes the final component
        /// of the session's resource name.
        /// 
        /// This value must be 4-63 characters. Valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Session, SessionOperationMetadata> CreateSession(gagr::LocationName parent, Session session, string sessionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSession(new CreateSessionRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Session = gax::GaxPreconditions.CheckNotNull(session, nameof(session)),
                SessionId = gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)),
            }, callSettings);

        /// <summary>
        /// Create an interactive session asynchronously.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this session will be created.
        /// </param>
        /// <param name="session">
        /// Required. The interactive session to create.
        /// </param>
        /// <param name="sessionId">
        /// Required. The ID to use for the session, which becomes the final component
        /// of the session's resource name.
        /// 
        /// This value must be 4-63 characters. Valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Session, SessionOperationMetadata>> CreateSessionAsync(gagr::LocationName parent, Session session, string sessionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSessionAsync(new CreateSessionRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Session = gax::GaxPreconditions.CheckNotNull(session, nameof(session)),
                SessionId = gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)),
            }, callSettings);

        /// <summary>
        /// Create an interactive session asynchronously.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this session will be created.
        /// </param>
        /// <param name="session">
        /// Required. The interactive session to create.
        /// </param>
        /// <param name="sessionId">
        /// Required. The ID to use for the session, which becomes the final component
        /// of the session's resource name.
        /// 
        /// This value must be 4-63 characters. Valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Session, SessionOperationMetadata>> CreateSessionAsync(gagr::LocationName parent, Session session, string sessionId, st::CancellationToken cancellationToken) =>
            CreateSessionAsync(parent, session, sessionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the resource representation for an interactive session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Session GetSession(GetSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the resource representation for an interactive session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> GetSessionAsync(GetSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the resource representation for an interactive session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> GetSessionAsync(GetSessionRequest request, st::CancellationToken cancellationToken) =>
            GetSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the resource representation for an interactive session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Session GetSession(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSession(new GetSessionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the resource representation for an interactive session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> GetSessionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSessionAsync(new GetSessionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the resource representation for an interactive session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> GetSessionAsync(string name, st::CancellationToken cancellationToken) =>
            GetSessionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the resource representation for an interactive session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Session GetSession(SessionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSession(new GetSessionRequest
            {
                SessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the resource representation for an interactive session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> GetSessionAsync(SessionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSessionAsync(new GetSessionRequest
            {
                SessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the resource representation for an interactive session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> GetSessionAsync(SessionName name, st::CancellationToken cancellationToken) =>
            GetSessionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists interactive sessions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Session"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSessionsResponse, Session> ListSessions(ListSessionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists interactive sessions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Session"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSessionsResponse, Session> ListSessionsAsync(ListSessionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists interactive sessions.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of sessions.
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
        /// Lists interactive sessions.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of sessions.
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
        /// Lists interactive sessions.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of sessions.
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
        public virtual gax::PagedEnumerable<ListSessionsResponse, Session> ListSessions(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSessionsRequest request = new ListSessionsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Lists interactive sessions.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of sessions.
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
        public virtual gax::PagedAsyncEnumerable<ListSessionsResponse, Session> ListSessionsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSessionsRequest request = new ListSessionsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Terminates the interactive session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Session, SessionOperationMetadata> TerminateSession(TerminateSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Terminates the interactive session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Session, SessionOperationMetadata>> TerminateSessionAsync(TerminateSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Terminates the interactive session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Session, SessionOperationMetadata>> TerminateSessionAsync(TerminateSessionRequest request, st::CancellationToken cancellationToken) =>
            TerminateSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>TerminateSession</c>.</summary>
        public virtual lro::OperationsClient TerminateSessionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>TerminateSession</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Session, SessionOperationMetadata> PollOnceTerminateSession(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Session, SessionOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), TerminateSessionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>TerminateSession</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Session, SessionOperationMetadata>> PollOnceTerminateSessionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Session, SessionOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), TerminateSessionOperationsClient, callSettings);

        /// <summary>
        /// Terminates the interactive session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session resource to terminate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Session, SessionOperationMetadata> TerminateSession(string name, gaxgrpc::CallSettings callSettings = null) =>
            TerminateSession(new TerminateSessionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Terminates the interactive session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session resource to terminate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Session, SessionOperationMetadata>> TerminateSessionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            TerminateSessionAsync(new TerminateSessionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Terminates the interactive session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session resource to terminate.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Session, SessionOperationMetadata>> TerminateSessionAsync(string name, st::CancellationToken cancellationToken) =>
            TerminateSessionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Terminates the interactive session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session resource to terminate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Session, SessionOperationMetadata> TerminateSession(SessionName name, gaxgrpc::CallSettings callSettings = null) =>
            TerminateSession(new TerminateSessionRequest
            {
                SessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Terminates the interactive session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session resource to terminate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Session, SessionOperationMetadata>> TerminateSessionAsync(SessionName name, gaxgrpc::CallSettings callSettings = null) =>
            TerminateSessionAsync(new TerminateSessionRequest
            {
                SessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Terminates the interactive session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session resource to terminate.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Session, SessionOperationMetadata>> TerminateSessionAsync(SessionName name, st::CancellationToken cancellationToken) =>
            TerminateSessionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the interactive session resource. If the session is not in terminal
        /// state, it is terminated, and then deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Session, SessionOperationMetadata> DeleteSession(DeleteSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the interactive session resource. If the session is not in terminal
        /// state, it is terminated, and then deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Session, SessionOperationMetadata>> DeleteSessionAsync(DeleteSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the interactive session resource. If the session is not in terminal
        /// state, it is terminated, and then deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Session, SessionOperationMetadata>> DeleteSessionAsync(DeleteSessionRequest request, st::CancellationToken cancellationToken) =>
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
        public virtual lro::Operation<Session, SessionOperationMetadata> PollOnceDeleteSession(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Session, SessionOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteSessionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteSession</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Session, SessionOperationMetadata>> PollOnceDeleteSessionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Session, SessionOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteSessionOperationsClient, callSettings);

        /// <summary>
        /// Deletes the interactive session resource. If the session is not in terminal
        /// state, it is terminated, and then deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Session, SessionOperationMetadata> DeleteSession(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSession(new DeleteSessionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the interactive session resource. If the session is not in terminal
        /// state, it is terminated, and then deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Session, SessionOperationMetadata>> DeleteSessionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSessionAsync(new DeleteSessionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the interactive session resource. If the session is not in terminal
        /// state, it is terminated, and then deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Session, SessionOperationMetadata>> DeleteSessionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSessionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the interactive session resource. If the session is not in terminal
        /// state, it is terminated, and then deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Session, SessionOperationMetadata> DeleteSession(SessionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSession(new DeleteSessionRequest
            {
                SessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the interactive session resource. If the session is not in terminal
        /// state, it is terminated, and then deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Session, SessionOperationMetadata>> DeleteSessionAsync(SessionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSessionAsync(new DeleteSessionRequest
            {
                SessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the interactive session resource. If the session is not in terminal
        /// state, it is terminated, and then deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Session, SessionOperationMetadata>> DeleteSessionAsync(SessionName name, st::CancellationToken cancellationToken) =>
            DeleteSessionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>SessionController client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The `SessionController` provides methods to manage interactive sessions.
    /// </remarks>
    public sealed partial class SessionControllerClientImpl : SessionControllerClient
    {
        private readonly gaxgrpc::ApiCall<CreateSessionRequest, lro::Operation> _callCreateSession;

        private readonly gaxgrpc::ApiCall<GetSessionRequest, Session> _callGetSession;

        private readonly gaxgrpc::ApiCall<ListSessionsRequest, ListSessionsResponse> _callListSessions;

        private readonly gaxgrpc::ApiCall<TerminateSessionRequest, lro::Operation> _callTerminateSession;

        private readonly gaxgrpc::ApiCall<DeleteSessionRequest, lro::Operation> _callDeleteSession;

        /// <summary>
        /// Constructs a client wrapper for the SessionController service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SessionControllerSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SessionControllerClientImpl(SessionController.SessionControllerClient grpcClient, SessionControllerSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SessionControllerSettings effectiveSettings = settings ?? SessionControllerSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateSessionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateSessionOperationsSettings, logger);
            TerminateSessionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.TerminateSessionOperationsSettings, logger);
            DeleteSessionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteSessionOperationsSettings, logger);
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
            _callTerminateSession = clientHelper.BuildApiCall<TerminateSessionRequest, lro::Operation>("TerminateSession", grpcClient.TerminateSessionAsync, grpcClient.TerminateSession, effectiveSettings.TerminateSessionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callTerminateSession);
            Modify_TerminateSessionApiCall(ref _callTerminateSession);
            _callDeleteSession = clientHelper.BuildApiCall<DeleteSessionRequest, lro::Operation>("DeleteSession", grpcClient.DeleteSessionAsync, grpcClient.DeleteSession, effectiveSettings.DeleteSessionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSession);
            Modify_DeleteSessionApiCall(ref _callDeleteSession);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateSessionApiCall(ref gaxgrpc::ApiCall<CreateSessionRequest, lro::Operation> call);

        partial void Modify_GetSessionApiCall(ref gaxgrpc::ApiCall<GetSessionRequest, Session> call);

        partial void Modify_ListSessionsApiCall(ref gaxgrpc::ApiCall<ListSessionsRequest, ListSessionsResponse> call);

        partial void Modify_TerminateSessionApiCall(ref gaxgrpc::ApiCall<TerminateSessionRequest, lro::Operation> call);

        partial void Modify_DeleteSessionApiCall(ref gaxgrpc::ApiCall<DeleteSessionRequest, lro::Operation> call);

        partial void OnConstruction(SessionController.SessionControllerClient grpcClient, SessionControllerSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SessionController client</summary>
        public override SessionController.SessionControllerClient GrpcClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateSessionRequest(ref CreateSessionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSessionRequest(ref GetSessionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSessionsRequest(ref ListSessionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TerminateSessionRequest(ref TerminateSessionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSessionRequest(ref DeleteSessionRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateSession</c>.</summary>
        public override lro::OperationsClient CreateSessionOperationsClient { get; }

        /// <summary>
        /// Create an interactive session asynchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Session, SessionOperationMetadata> CreateSession(CreateSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSessionRequest(ref request, ref callSettings);
            return new lro::Operation<Session, SessionOperationMetadata>(_callCreateSession.Sync(request, callSettings), CreateSessionOperationsClient);
        }

        /// <summary>
        /// Create an interactive session asynchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Session, SessionOperationMetadata>> CreateSessionAsync(CreateSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSessionRequest(ref request, ref callSettings);
            return new lro::Operation<Session, SessionOperationMetadata>(await _callCreateSession.Async(request, callSettings).ConfigureAwait(false), CreateSessionOperationsClient);
        }

        /// <summary>
        /// Gets the resource representation for an interactive session.
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
        /// Gets the resource representation for an interactive session.
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
        /// Lists interactive sessions.
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
        /// Lists interactive sessions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Session"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSessionsResponse, Session> ListSessionsAsync(ListSessionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSessionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSessionsRequest, ListSessionsResponse, Session>(_callListSessions, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>TerminateSession</c>.</summary>
        public override lro::OperationsClient TerminateSessionOperationsClient { get; }

        /// <summary>
        /// Terminates the interactive session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Session, SessionOperationMetadata> TerminateSession(TerminateSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TerminateSessionRequest(ref request, ref callSettings);
            return new lro::Operation<Session, SessionOperationMetadata>(_callTerminateSession.Sync(request, callSettings), TerminateSessionOperationsClient);
        }

        /// <summary>
        /// Terminates the interactive session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Session, SessionOperationMetadata>> TerminateSessionAsync(TerminateSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TerminateSessionRequest(ref request, ref callSettings);
            return new lro::Operation<Session, SessionOperationMetadata>(await _callTerminateSession.Async(request, callSettings).ConfigureAwait(false), TerminateSessionOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteSession</c>.</summary>
        public override lro::OperationsClient DeleteSessionOperationsClient { get; }

        /// <summary>
        /// Deletes the interactive session resource. If the session is not in terminal
        /// state, it is terminated, and then deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Session, SessionOperationMetadata> DeleteSession(DeleteSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSessionRequest(ref request, ref callSettings);
            return new lro::Operation<Session, SessionOperationMetadata>(_callDeleteSession.Sync(request, callSettings), DeleteSessionOperationsClient);
        }

        /// <summary>
        /// Deletes the interactive session resource. If the session is not in terminal
        /// state, it is terminated, and then deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Session, SessionOperationMetadata>> DeleteSessionAsync(DeleteSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSessionRequest(ref request, ref callSettings);
            return new lro::Operation<Session, SessionOperationMetadata>(await _callDeleteSession.Async(request, callSettings).ConfigureAwait(false), DeleteSessionOperationsClient);
        }
    }

    public partial class ListSessionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSessionsResponse : gaxgrpc::IPageResponse<Session>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Session> GetEnumerator() => Sessions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class SessionController
    {
        public partial class SessionControllerClient
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

    public static partial class SessionController
    {
        public partial class SessionControllerClient
        {
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
