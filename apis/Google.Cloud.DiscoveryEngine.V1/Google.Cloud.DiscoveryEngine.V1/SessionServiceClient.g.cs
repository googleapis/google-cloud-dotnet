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
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.DiscoveryEngine.V1
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
            DeleteSessionSettings = existing.DeleteSessionSettings;
            UpdateSessionSettings = existing.UpdateSessionSettings;
            GetSessionSettings = existing.GetSessionSettings;
            ListSessionsSettings = existing.ListSessionsSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SessionServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SessionServiceClient.CreateSession</c> and <c>SessionServiceClient.CreateSessionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSessionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SessionServiceClient.DeleteSession</c> and <c>SessionServiceClient.DeleteSessionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSessionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SessionServiceClient.UpdateSession</c> and <c>SessionServiceClient.UpdateSessionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSessionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SessionServiceClient.GetSession</c> and <c>SessionServiceClient.GetSessionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSessionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SessionServiceClient.ListSessions</c> and <c>SessionServiceClient.ListSessionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSessionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

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
    /// Service for managing Sessions and Session-related resources.
    /// </remarks>
    public abstract partial class SessionServiceClient
    {
        /// <summary>
        /// The default endpoint for the SessionService service, which is a host of "discoveryengine.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "discoveryengine.googleapis.com:443";

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

        /// <summary>
        /// Creates a Session.
        /// 
        /// If the [Session][google.cloud.discoveryengine.v1.Session] to create already
        /// exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Session CreateSession(CreateSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Session.
        /// 
        /// If the [Session][google.cloud.discoveryengine.v1.Session] to create already
        /// exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> CreateSessionAsync(CreateSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Session.
        /// 
        /// If the [Session][google.cloud.discoveryengine.v1.Session] to create already
        /// exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> CreateSessionAsync(CreateSessionRequest request, st::CancellationToken cancellationToken) =>
            CreateSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Session.
        /// 
        /// If the [Session][google.cloud.discoveryengine.v1.Session] to create already
        /// exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="parent">
        /// Required. Full resource name of parent data store. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}`
        /// </param>
        /// <param name="session">
        /// Required. The session to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Session CreateSession(string parent, Session session, gaxgrpc::CallSettings callSettings = null) =>
            CreateSession(new CreateSessionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Session = gax::GaxPreconditions.CheckNotNull(session, nameof(session)),
            }, callSettings);

        /// <summary>
        /// Creates a Session.
        /// 
        /// If the [Session][google.cloud.discoveryengine.v1.Session] to create already
        /// exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="parent">
        /// Required. Full resource name of parent data store. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}`
        /// </param>
        /// <param name="session">
        /// Required. The session to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> CreateSessionAsync(string parent, Session session, gaxgrpc::CallSettings callSettings = null) =>
            CreateSessionAsync(new CreateSessionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Session = gax::GaxPreconditions.CheckNotNull(session, nameof(session)),
            }, callSettings);

        /// <summary>
        /// Creates a Session.
        /// 
        /// If the [Session][google.cloud.discoveryengine.v1.Session] to create already
        /// exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="parent">
        /// Required. Full resource name of parent data store. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}`
        /// </param>
        /// <param name="session">
        /// Required. The session to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> CreateSessionAsync(string parent, Session session, st::CancellationToken cancellationToken) =>
            CreateSessionAsync(parent, session, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Session.
        /// 
        /// If the [Session][google.cloud.discoveryengine.v1.Session] to create already
        /// exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="parent">
        /// Required. Full resource name of parent data store. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}`
        /// </param>
        /// <param name="session">
        /// Required. The session to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Session CreateSession(DataStoreName parent, Session session, gaxgrpc::CallSettings callSettings = null) =>
            CreateSession(new CreateSessionRequest
            {
                ParentAsDataStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Session = gax::GaxPreconditions.CheckNotNull(session, nameof(session)),
            }, callSettings);

        /// <summary>
        /// Creates a Session.
        /// 
        /// If the [Session][google.cloud.discoveryengine.v1.Session] to create already
        /// exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="parent">
        /// Required. Full resource name of parent data store. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}`
        /// </param>
        /// <param name="session">
        /// Required. The session to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> CreateSessionAsync(DataStoreName parent, Session session, gaxgrpc::CallSettings callSettings = null) =>
            CreateSessionAsync(new CreateSessionRequest
            {
                ParentAsDataStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Session = gax::GaxPreconditions.CheckNotNull(session, nameof(session)),
            }, callSettings);

        /// <summary>
        /// Creates a Session.
        /// 
        /// If the [Session][google.cloud.discoveryengine.v1.Session] to create already
        /// exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="parent">
        /// Required. Full resource name of parent data store. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}`
        /// </param>
        /// <param name="session">
        /// Required. The session to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> CreateSessionAsync(DataStoreName parent, Session session, st::CancellationToken cancellationToken) =>
            CreateSessionAsync(parent, session, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Session.
        /// 
        /// If the [Session][google.cloud.discoveryengine.v1.Session] to delete does
        /// not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSession(DeleteSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Session.
        /// 
        /// If the [Session][google.cloud.discoveryengine.v1.Session] to delete does
        /// not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSessionAsync(DeleteSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Session.
        /// 
        /// If the [Session][google.cloud.discoveryengine.v1.Session] to delete does
        /// not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSessionAsync(DeleteSessionRequest request, st::CancellationToken cancellationToken) =>
            DeleteSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Session.
        /// 
        /// If the [Session][google.cloud.discoveryengine.v1.Session] to delete does
        /// not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Session to delete. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/sessions/{session_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSession(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSession(new DeleteSessionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Session.
        /// 
        /// If the [Session][google.cloud.discoveryengine.v1.Session] to delete does
        /// not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Session to delete. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/sessions/{session_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSessionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSessionAsync(new DeleteSessionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Session.
        /// 
        /// If the [Session][google.cloud.discoveryengine.v1.Session] to delete does
        /// not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Session to delete. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/sessions/{session_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSessionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSessionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Session.
        /// 
        /// If the [Session][google.cloud.discoveryengine.v1.Session] to delete does
        /// not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Session to delete. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/sessions/{session_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSession(SessionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSession(new DeleteSessionRequest
            {
                SessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Session.
        /// 
        /// If the [Session][google.cloud.discoveryengine.v1.Session] to delete does
        /// not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Session to delete. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/sessions/{session_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSessionAsync(SessionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSessionAsync(new DeleteSessionRequest
            {
                SessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Session.
        /// 
        /// If the [Session][google.cloud.discoveryengine.v1.Session] to delete does
        /// not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Session to delete. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/sessions/{session_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSessionAsync(SessionName name, st::CancellationToken cancellationToken) =>
            DeleteSessionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a Session.
        /// 
        /// [Session][google.cloud.discoveryengine.v1.Session] action type cannot be
        /// changed. If the [Session][google.cloud.discoveryengine.v1.Session] to
        /// update does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Session UpdateSession(UpdateSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a Session.
        /// 
        /// [Session][google.cloud.discoveryengine.v1.Session] action type cannot be
        /// changed. If the [Session][google.cloud.discoveryengine.v1.Session] to
        /// update does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> UpdateSessionAsync(UpdateSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a Session.
        /// 
        /// [Session][google.cloud.discoveryengine.v1.Session] action type cannot be
        /// changed. If the [Session][google.cloud.discoveryengine.v1.Session] to
        /// update does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> UpdateSessionAsync(UpdateSessionRequest request, st::CancellationToken cancellationToken) =>
            UpdateSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a Session.
        /// 
        /// [Session][google.cloud.discoveryengine.v1.Session] action type cannot be
        /// changed. If the [Session][google.cloud.discoveryengine.v1.Session] to
        /// update does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="session">
        /// Required. The Session to update.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided
        /// [Session][google.cloud.discoveryengine.v1.Session] to update. The following
        /// are NOT supported:
        /// 
        /// * [Session.name][google.cloud.discoveryengine.v1.Session.name]
        /// 
        /// If not set or empty, all supported fields are updated.
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
        /// Updates a Session.
        /// 
        /// [Session][google.cloud.discoveryengine.v1.Session] action type cannot be
        /// changed. If the [Session][google.cloud.discoveryengine.v1.Session] to
        /// update does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="session">
        /// Required. The Session to update.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided
        /// [Session][google.cloud.discoveryengine.v1.Session] to update. The following
        /// are NOT supported:
        /// 
        /// * [Session.name][google.cloud.discoveryengine.v1.Session.name]
        /// 
        /// If not set or empty, all supported fields are updated.
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
        /// Updates a Session.
        /// 
        /// [Session][google.cloud.discoveryengine.v1.Session] action type cannot be
        /// changed. If the [Session][google.cloud.discoveryengine.v1.Session] to
        /// update does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="session">
        /// Required. The Session to update.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided
        /// [Session][google.cloud.discoveryengine.v1.Session] to update. The following
        /// are NOT supported:
        /// 
        /// * [Session.name][google.cloud.discoveryengine.v1.Session.name]
        /// 
        /// If not set or empty, all supported fields are updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> UpdateSessionAsync(Session session, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSessionAsync(session, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Session GetSession(GetSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a Session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> GetSessionAsync(GetSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a Session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> GetSessionAsync(GetSessionRequest request, st::CancellationToken cancellationToken) =>
            GetSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Session.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Session to get. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/sessions/{session_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Session GetSession(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSession(new GetSessionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Session.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Session to get. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/sessions/{session_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> GetSessionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSessionAsync(new GetSessionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Session.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Session to get. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/sessions/{session_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> GetSessionAsync(string name, st::CancellationToken cancellationToken) =>
            GetSessionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Session.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Session to get. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/sessions/{session_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Session GetSession(SessionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSession(new GetSessionRequest
            {
                SessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Session.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Session to get. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/sessions/{session_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> GetSessionAsync(SessionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSessionAsync(new GetSessionRequest
            {
                SessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Session.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Session to get. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/sessions/{session_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> GetSessionAsync(SessionName name, st::CancellationToken cancellationToken) =>
            GetSessionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all Sessions by their parent
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Session"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSessionsResponse, Session> ListSessions(ListSessionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all Sessions by their parent
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Session"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSessionsResponse, Session> ListSessionsAsync(ListSessionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all Sessions by their parent
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore].
        /// </summary>
        /// <param name="parent">
        /// Required. The data store resource name. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}`
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
        /// Lists all Sessions by their parent
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore].
        /// </summary>
        /// <param name="parent">
        /// Required. The data store resource name. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}`
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
        /// Lists all Sessions by their parent
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore].
        /// </summary>
        /// <param name="parent">
        /// Required. The data store resource name. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}`
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
        public virtual gax::PagedEnumerable<ListSessionsResponse, Session> ListSessions(DataStoreName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSessionsRequest request = new ListSessionsRequest
            {
                ParentAsDataStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Lists all Sessions by their parent
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore].
        /// </summary>
        /// <param name="parent">
        /// Required. The data store resource name. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}`
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
        public virtual gax::PagedAsyncEnumerable<ListSessionsResponse, Session> ListSessionsAsync(DataStoreName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSessionsRequest request = new ListSessionsRequest
            {
                ParentAsDataStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
    }

    /// <summary>SessionService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing Sessions and Session-related resources.
    /// </remarks>
    public sealed partial class SessionServiceClientImpl : SessionServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateSessionRequest, Session> _callCreateSession;

        private readonly gaxgrpc::ApiCall<DeleteSessionRequest, wkt::Empty> _callDeleteSession;

        private readonly gaxgrpc::ApiCall<UpdateSessionRequest, Session> _callUpdateSession;

        private readonly gaxgrpc::ApiCall<GetSessionRequest, Session> _callGetSession;

        private readonly gaxgrpc::ApiCall<ListSessionsRequest, ListSessionsResponse> _callListSessions;

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
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCreateSession = clientHelper.BuildApiCall<CreateSessionRequest, Session>("CreateSession", grpcClient.CreateSessionAsync, grpcClient.CreateSession, effectiveSettings.CreateSessionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSession);
            Modify_CreateSessionApiCall(ref _callCreateSession);
            _callDeleteSession = clientHelper.BuildApiCall<DeleteSessionRequest, wkt::Empty>("DeleteSession", grpcClient.DeleteSessionAsync, grpcClient.DeleteSession, effectiveSettings.DeleteSessionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSession);
            Modify_DeleteSessionApiCall(ref _callDeleteSession);
            _callUpdateSession = clientHelper.BuildApiCall<UpdateSessionRequest, Session>("UpdateSession", grpcClient.UpdateSessionAsync, grpcClient.UpdateSession, effectiveSettings.UpdateSessionSettings).WithGoogleRequestParam("session.name", request => request.Session?.Name);
            Modify_ApiCall(ref _callUpdateSession);
            Modify_UpdateSessionApiCall(ref _callUpdateSession);
            _callGetSession = clientHelper.BuildApiCall<GetSessionRequest, Session>("GetSession", grpcClient.GetSessionAsync, grpcClient.GetSession, effectiveSettings.GetSessionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSession);
            Modify_GetSessionApiCall(ref _callGetSession);
            _callListSessions = clientHelper.BuildApiCall<ListSessionsRequest, ListSessionsResponse>("ListSessions", grpcClient.ListSessionsAsync, grpcClient.ListSessions, effectiveSettings.ListSessionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSessions);
            Modify_ListSessionsApiCall(ref _callListSessions);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateSessionApiCall(ref gaxgrpc::ApiCall<CreateSessionRequest, Session> call);

        partial void Modify_DeleteSessionApiCall(ref gaxgrpc::ApiCall<DeleteSessionRequest, wkt::Empty> call);

        partial void Modify_UpdateSessionApiCall(ref gaxgrpc::ApiCall<UpdateSessionRequest, Session> call);

        partial void Modify_GetSessionApiCall(ref gaxgrpc::ApiCall<GetSessionRequest, Session> call);

        partial void Modify_ListSessionsApiCall(ref gaxgrpc::ApiCall<ListSessionsRequest, ListSessionsResponse> call);

        partial void OnConstruction(SessionService.SessionServiceClient grpcClient, SessionServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SessionService client</summary>
        public override SessionService.SessionServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CreateSessionRequest(ref CreateSessionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSessionRequest(ref DeleteSessionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSessionRequest(ref UpdateSessionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSessionRequest(ref GetSessionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSessionsRequest(ref ListSessionsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a Session.
        /// 
        /// If the [Session][google.cloud.discoveryengine.v1.Session] to create already
        /// exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Session CreateSession(CreateSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSessionRequest(ref request, ref callSettings);
            return _callCreateSession.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a Session.
        /// 
        /// If the [Session][google.cloud.discoveryengine.v1.Session] to create already
        /// exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Session> CreateSessionAsync(CreateSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSessionRequest(ref request, ref callSettings);
            return _callCreateSession.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a Session.
        /// 
        /// If the [Session][google.cloud.discoveryengine.v1.Session] to delete does
        /// not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteSession(DeleteSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSessionRequest(ref request, ref callSettings);
            _callDeleteSession.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a Session.
        /// 
        /// If the [Session][google.cloud.discoveryengine.v1.Session] to delete does
        /// not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteSessionAsync(DeleteSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSessionRequest(ref request, ref callSettings);
            return _callDeleteSession.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a Session.
        /// 
        /// [Session][google.cloud.discoveryengine.v1.Session] action type cannot be
        /// changed. If the [Session][google.cloud.discoveryengine.v1.Session] to
        /// update does not exist, a NOT_FOUND error is returned.
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
        /// Updates a Session.
        /// 
        /// [Session][google.cloud.discoveryengine.v1.Session] action type cannot be
        /// changed. If the [Session][google.cloud.discoveryengine.v1.Session] to
        /// update does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Session> UpdateSessionAsync(UpdateSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSessionRequest(ref request, ref callSettings);
            return _callUpdateSession.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a Session.
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
        /// Gets a Session.
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
        /// Lists all Sessions by their parent
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore].
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
        /// Lists all Sessions by their parent
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Session"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSessionsResponse, Session> ListSessionsAsync(ListSessionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSessionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSessionsRequest, ListSessionsResponse, Session>(_callListSessions, request, callSettings);
        }
    }

    public partial class ListSessionsRequest : gaxgrpc::IPageRequest
    {
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
        }
    }
}
