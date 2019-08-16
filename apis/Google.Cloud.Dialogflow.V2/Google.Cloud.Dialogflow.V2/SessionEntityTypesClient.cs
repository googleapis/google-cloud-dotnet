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

namespace Google.Cloud.Dialogflow.V2
{
    /// <summary>
    /// Settings for a <see cref="SessionEntityTypesClient"/>.
    /// </summary>
    public sealed partial class SessionEntityTypesSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="SessionEntityTypesSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="SessionEntityTypesSettings"/>.
        /// </returns>
        public static SessionEntityTypesSettings GetDefault() => new SessionEntityTypesSettings();

        /// <summary>
        /// Constructs a new <see cref="SessionEntityTypesSettings"/> object with default settings.
        /// </summary>
        public SessionEntityTypesSettings() { }

        private SessionEntityTypesSettings(SessionEntityTypesSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListSessionEntityTypesSettings = existing.ListSessionEntityTypesSettings;
            GetSessionEntityTypeSettings = existing.GetSessionEntityTypeSettings;
            CreateSessionEntityTypeSettings = existing.CreateSessionEntityTypeSettings;
            UpdateSessionEntityTypeSettings = existing.UpdateSessionEntityTypeSettings;
            DeleteSessionEntityTypeSettings = existing.DeleteSessionEntityTypeSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SessionEntityTypesSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="SessionEntityTypesClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="SessionEntityTypesClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="SessionEntityTypesClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="SessionEntityTypesClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="SessionEntityTypesClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="SessionEntityTypesClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="SessionEntityTypesClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="SessionEntityTypesClient"/> RPC methods is defined as:
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
        /// <c>SessionEntityTypesClient.ListSessionEntityTypes</c> and <c>SessionEntityTypesClient.ListSessionEntityTypesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SessionEntityTypesClient.ListSessionEntityTypes</c> and
        /// <c>SessionEntityTypesClient.ListSessionEntityTypesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ListSessionEntityTypesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SessionEntityTypesClient.GetSessionEntityType</c> and <c>SessionEntityTypesClient.GetSessionEntityTypeAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SessionEntityTypesClient.GetSessionEntityType</c> and
        /// <c>SessionEntityTypesClient.GetSessionEntityTypeAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetSessionEntityTypeSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SessionEntityTypesClient.CreateSessionEntityType</c> and <c>SessionEntityTypesClient.CreateSessionEntityTypeAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SessionEntityTypesClient.CreateSessionEntityType</c> and
        /// <c>SessionEntityTypesClient.CreateSessionEntityTypeAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateSessionEntityTypeSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SessionEntityTypesClient.UpdateSessionEntityType</c> and <c>SessionEntityTypesClient.UpdateSessionEntityTypeAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SessionEntityTypesClient.UpdateSessionEntityType</c> and
        /// <c>SessionEntityTypesClient.UpdateSessionEntityTypeAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings UpdateSessionEntityTypeSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SessionEntityTypesClient.DeleteSessionEntityType</c> and <c>SessionEntityTypesClient.DeleteSessionEntityTypeAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SessionEntityTypesClient.DeleteSessionEntityType</c> and
        /// <c>SessionEntityTypesClient.DeleteSessionEntityTypeAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSessionEntityTypeSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="SessionEntityTypesSettings"/> object.</returns>
        public SessionEntityTypesSettings Clone() => new SessionEntityTypesSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SessionEntityTypesClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class SessionEntityTypesClientBuilder : gaxgrpc::ClientBuilderBase<SessionEntityTypesClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public SessionEntityTypesSettings Settings { get; set; }

        /// <inheritdoc/>
        public override SessionEntityTypesClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SessionEntityTypesClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<SessionEntityTypesClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SessionEntityTypesClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => SessionEntityTypesClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => SessionEntityTypesClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => SessionEntityTypesClient.ChannelPool;
    }

    /// <summary>
    /// SessionEntityTypes client wrapper, for convenient use.
    /// </summary>
    public abstract partial class SessionEntityTypesClient
    {
        /// <summary>
        /// The default endpoint for the SessionEntityTypes service, which is a host of "dialogflow.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("dialogflow.googleapis.com", 443);

        /// <summary>
        /// The default SessionEntityTypes scopes.
        /// </summary>
        /// <remarks>
        /// The default SessionEntityTypes scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/dialogflow"</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/dialogflow",
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="SessionEntityTypesClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Dialogflow.V2;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// SessionEntityTypesClient client = await SessionEntityTypesClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Dialogflow.V2;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     SessionEntityTypesClient.DefaultEndpoint.Host, SessionEntityTypesClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// SessionEntityTypesClient client = SessionEntityTypesClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="SessionEntityTypesSettings"/>.</param>
        /// <returns>The task representing the created <see cref="SessionEntityTypesClient"/>.</returns>
        public static async stt::Task<SessionEntityTypesClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, SessionEntityTypesSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="SessionEntityTypesClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Dialogflow.V2;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// SessionEntityTypesClient client = SessionEntityTypesClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Dialogflow.V2;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     SessionEntityTypesClient.DefaultEndpoint.Host, SessionEntityTypesClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// SessionEntityTypesClient client = SessionEntityTypesClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="SessionEntityTypesSettings"/>.</param>
        /// <returns>The created <see cref="SessionEntityTypesClient"/>.</returns>
        public static SessionEntityTypesClient Create(gaxgrpc::ServiceEndpoint endpoint = null, SessionEntityTypesSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="SessionEntityTypesClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="SessionEntityTypesSettings"/>.</param>
        /// <returns>The created <see cref="SessionEntityTypesClient"/>.</returns>
        public static SessionEntityTypesClient Create(grpccore::Channel channel, SessionEntityTypesSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="SessionEntityTypesClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="SessionEntityTypesSettings"/>.</param>
        /// <returns>The created <see cref="SessionEntityTypesClient"/>.</returns>
        public static SessionEntityTypesClient Create(grpccore::CallInvoker callInvoker, SessionEntityTypesSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SessionEntityTypes.SessionEntityTypesClient grpcClient = new SessionEntityTypes.SessionEntityTypesClient(callInvoker);
            return new SessionEntityTypesClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, SessionEntityTypesSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, SessionEntityTypesSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, SessionEntityTypesSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, SessionEntityTypesSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC SessionEntityTypes client.
        /// </summary>
        public virtual SessionEntityTypes.SessionEntityTypesClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Returns the list of all session entity types in the specified session.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
        /// </summary>
        /// <param name="parent">
        /// Required. The session to list all session entity types from.
        /// Format: `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="SessionEntityType"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListSessionEntityTypesResponse, SessionEntityType> ListSessionEntityTypesAsync(
            SessionName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListSessionEntityTypesAsync(
                new ListSessionEntityTypesRequest
                {
                    ParentAsSessionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns the list of all session entity types in the specified session.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
        /// </summary>
        /// <param name="parent">
        /// Required. The session to list all session entity types from.
        /// Format: `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="SessionEntityType"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListSessionEntityTypesResponse, SessionEntityType> ListSessionEntityTypes(
            SessionName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListSessionEntityTypes(
                new ListSessionEntityTypesRequest
                {
                    ParentAsSessionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns the list of all session entity types in the specified session.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
        /// </summary>
        /// <param name="parent">
        /// Required. The session to list all session entity types from.
        /// Format: `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="SessionEntityType"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListSessionEntityTypesResponse, SessionEntityType> ListSessionEntityTypesAsync(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListSessionEntityTypesAsync(
                new ListSessionEntityTypesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns the list of all session entity types in the specified session.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
        /// </summary>
        /// <param name="parent">
        /// Required. The session to list all session entity types from.
        /// Format: `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="SessionEntityType"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListSessionEntityTypesResponse, SessionEntityType> ListSessionEntityTypes(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListSessionEntityTypes(
                new ListSessionEntityTypesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns the list of all session entity types in the specified session.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="SessionEntityType"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListSessionEntityTypesResponse, SessionEntityType> ListSessionEntityTypesAsync(
            ListSessionEntityTypesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the list of all session entity types in the specified session.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="SessionEntityType"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListSessionEntityTypesResponse, SessionEntityType> ListSessionEntityTypes(
            ListSessionEntityTypesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Retrieves the specified session entity type.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session entity type. Format:
        /// `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;/entityTypes/&lt;Entity Type
        /// Display Name&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<SessionEntityType> GetSessionEntityTypeAsync(
            SessionEntityTypeName name,
            gaxgrpc::CallSettings callSettings = null) => GetSessionEntityTypeAsync(
                new GetSessionEntityTypeRequest
                {
                    SessionEntityTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Retrieves the specified session entity type.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session entity type. Format:
        /// `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;/entityTypes/&lt;Entity Type
        /// Display Name&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<SessionEntityType> GetSessionEntityTypeAsync(
            SessionEntityTypeName name,
            st::CancellationToken cancellationToken) => GetSessionEntityTypeAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified session entity type.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session entity type. Format:
        /// `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;/entityTypes/&lt;Entity Type
        /// Display Name&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual SessionEntityType GetSessionEntityType(
            SessionEntityTypeName name,
            gaxgrpc::CallSettings callSettings = null) => GetSessionEntityType(
                new GetSessionEntityTypeRequest
                {
                    SessionEntityTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Retrieves the specified session entity type.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session entity type. Format:
        /// `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;/entityTypes/&lt;Entity Type
        /// Display Name&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<SessionEntityType> GetSessionEntityTypeAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetSessionEntityTypeAsync(
                new GetSessionEntityTypeRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Retrieves the specified session entity type.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session entity type. Format:
        /// `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;/entityTypes/&lt;Entity Type
        /// Display Name&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<SessionEntityType> GetSessionEntityTypeAsync(
            string name,
            st::CancellationToken cancellationToken) => GetSessionEntityTypeAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified session entity type.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session entity type. Format:
        /// `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;/entityTypes/&lt;Entity Type
        /// Display Name&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual SessionEntityType GetSessionEntityType(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetSessionEntityType(
                new GetSessionEntityTypeRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Retrieves the specified session entity type.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
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
        public virtual stt::Task<SessionEntityType> GetSessionEntityTypeAsync(
            GetSessionEntityTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Retrieves the specified session entity type.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
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
        public virtual stt::Task<SessionEntityType> GetSessionEntityTypeAsync(
            GetSessionEntityTypeRequest request,
            st::CancellationToken cancellationToken) => GetSessionEntityTypeAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified session entity type.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
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
        public virtual SessionEntityType GetSessionEntityType(
            GetSessionEntityTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a session entity type.
        ///
        /// If the specified session entity type already exists, overrides the session
        /// entity type.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
        /// </summary>
        /// <param name="parent">
        /// Required. The session to create a session entity type for.
        /// Format: `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;`.
        /// </param>
        /// <param name="sessionEntityType">
        /// Required. The session entity type to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<SessionEntityType> CreateSessionEntityTypeAsync(
            SessionName parent,
            SessionEntityType sessionEntityType,
            gaxgrpc::CallSettings callSettings = null) => CreateSessionEntityTypeAsync(
                new CreateSessionEntityTypeRequest
                {
                    ParentAsSessionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    SessionEntityType = gax::GaxPreconditions.CheckNotNull(sessionEntityType, nameof(sessionEntityType)),
                },
                callSettings);

        /// <summary>
        /// Creates a session entity type.
        ///
        /// If the specified session entity type already exists, overrides the session
        /// entity type.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
        /// </summary>
        /// <param name="parent">
        /// Required. The session to create a session entity type for.
        /// Format: `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;`.
        /// </param>
        /// <param name="sessionEntityType">
        /// Required. The session entity type to create.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<SessionEntityType> CreateSessionEntityTypeAsync(
            SessionName parent,
            SessionEntityType sessionEntityType,
            st::CancellationToken cancellationToken) => CreateSessionEntityTypeAsync(
                parent,
                sessionEntityType,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a session entity type.
        ///
        /// If the specified session entity type already exists, overrides the session
        /// entity type.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
        /// </summary>
        /// <param name="parent">
        /// Required. The session to create a session entity type for.
        /// Format: `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;`.
        /// </param>
        /// <param name="sessionEntityType">
        /// Required. The session entity type to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual SessionEntityType CreateSessionEntityType(
            SessionName parent,
            SessionEntityType sessionEntityType,
            gaxgrpc::CallSettings callSettings = null) => CreateSessionEntityType(
                new CreateSessionEntityTypeRequest
                {
                    ParentAsSessionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    SessionEntityType = gax::GaxPreconditions.CheckNotNull(sessionEntityType, nameof(sessionEntityType)),
                },
                callSettings);

        /// <summary>
        /// Creates a session entity type.
        ///
        /// If the specified session entity type already exists, overrides the session
        /// entity type.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
        /// </summary>
        /// <param name="parent">
        /// Required. The session to create a session entity type for.
        /// Format: `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;`.
        /// </param>
        /// <param name="sessionEntityType">
        /// Required. The session entity type to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<SessionEntityType> CreateSessionEntityTypeAsync(
            string parent,
            SessionEntityType sessionEntityType,
            gaxgrpc::CallSettings callSettings = null) => CreateSessionEntityTypeAsync(
                new CreateSessionEntityTypeRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    SessionEntityType = gax::GaxPreconditions.CheckNotNull(sessionEntityType, nameof(sessionEntityType)),
                },
                callSettings);

        /// <summary>
        /// Creates a session entity type.
        ///
        /// If the specified session entity type already exists, overrides the session
        /// entity type.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
        /// </summary>
        /// <param name="parent">
        /// Required. The session to create a session entity type for.
        /// Format: `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;`.
        /// </param>
        /// <param name="sessionEntityType">
        /// Required. The session entity type to create.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<SessionEntityType> CreateSessionEntityTypeAsync(
            string parent,
            SessionEntityType sessionEntityType,
            st::CancellationToken cancellationToken) => CreateSessionEntityTypeAsync(
                parent,
                sessionEntityType,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a session entity type.
        ///
        /// If the specified session entity type already exists, overrides the session
        /// entity type.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
        /// </summary>
        /// <param name="parent">
        /// Required. The session to create a session entity type for.
        /// Format: `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;`.
        /// </param>
        /// <param name="sessionEntityType">
        /// Required. The session entity type to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual SessionEntityType CreateSessionEntityType(
            string parent,
            SessionEntityType sessionEntityType,
            gaxgrpc::CallSettings callSettings = null) => CreateSessionEntityType(
                new CreateSessionEntityTypeRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    SessionEntityType = gax::GaxPreconditions.CheckNotNull(sessionEntityType, nameof(sessionEntityType)),
                },
                callSettings);

        /// <summary>
        /// Creates a session entity type.
        ///
        /// If the specified session entity type already exists, overrides the session
        /// entity type.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
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
        public virtual stt::Task<SessionEntityType> CreateSessionEntityTypeAsync(
            CreateSessionEntityTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a session entity type.
        ///
        /// If the specified session entity type already exists, overrides the session
        /// entity type.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
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
        public virtual stt::Task<SessionEntityType> CreateSessionEntityTypeAsync(
            CreateSessionEntityTypeRequest request,
            st::CancellationToken cancellationToken) => CreateSessionEntityTypeAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a session entity type.
        ///
        /// If the specified session entity type already exists, overrides the session
        /// entity type.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
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
        public virtual SessionEntityType CreateSessionEntityType(
            CreateSessionEntityTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates the specified session entity type.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
        /// </summary>
        /// <param name="sessionEntityType">
        /// Required. The entity type to update. Format:
        /// `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;/entityTypes/&lt;Entity Type
        /// Display Name&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<SessionEntityType> UpdateSessionEntityTypeAsync(
            SessionEntityType sessionEntityType,
            gaxgrpc::CallSettings callSettings = null) => UpdateSessionEntityTypeAsync(
                new UpdateSessionEntityTypeRequest
                {
                    SessionEntityType = gax::GaxPreconditions.CheckNotNull(sessionEntityType, nameof(sessionEntityType)),
                },
                callSettings);

        /// <summary>
        /// Updates the specified session entity type.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
        /// </summary>
        /// <param name="sessionEntityType">
        /// Required. The entity type to update. Format:
        /// `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;/entityTypes/&lt;Entity Type
        /// Display Name&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<SessionEntityType> UpdateSessionEntityTypeAsync(
            SessionEntityType sessionEntityType,
            st::CancellationToken cancellationToken) => UpdateSessionEntityTypeAsync(
                sessionEntityType,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified session entity type.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
        /// </summary>
        /// <param name="sessionEntityType">
        /// Required. The entity type to update. Format:
        /// `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;/entityTypes/&lt;Entity Type
        /// Display Name&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual SessionEntityType UpdateSessionEntityType(
            SessionEntityType sessionEntityType,
            gaxgrpc::CallSettings callSettings = null) => UpdateSessionEntityType(
                new UpdateSessionEntityTypeRequest
                {
                    SessionEntityType = gax::GaxPreconditions.CheckNotNull(sessionEntityType, nameof(sessionEntityType)),
                },
                callSettings);

        /// <summary>
        /// Updates the specified session entity type.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
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
        public virtual stt::Task<SessionEntityType> UpdateSessionEntityTypeAsync(
            UpdateSessionEntityTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates the specified session entity type.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
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
        public virtual stt::Task<SessionEntityType> UpdateSessionEntityTypeAsync(
            UpdateSessionEntityTypeRequest request,
            st::CancellationToken cancellationToken) => UpdateSessionEntityTypeAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified session entity type.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
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
        public virtual SessionEntityType UpdateSessionEntityType(
            UpdateSessionEntityTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes the specified session entity type.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type to delete. Format:
        /// `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;/entityTypes/&lt;Entity Type
        /// Display Name&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteSessionEntityTypeAsync(
            SessionEntityTypeName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteSessionEntityTypeAsync(
                new DeleteSessionEntityTypeRequest
                {
                    SessionEntityTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified session entity type.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type to delete. Format:
        /// `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;/entityTypes/&lt;Entity Type
        /// Display Name&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteSessionEntityTypeAsync(
            SessionEntityTypeName name,
            st::CancellationToken cancellationToken) => DeleteSessionEntityTypeAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified session entity type.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type to delete. Format:
        /// `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;/entityTypes/&lt;Entity Type
        /// Display Name&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteSessionEntityType(
            SessionEntityTypeName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteSessionEntityType(
                new DeleteSessionEntityTypeRequest
                {
                    SessionEntityTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified session entity type.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type to delete. Format:
        /// `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;/entityTypes/&lt;Entity Type
        /// Display Name&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteSessionEntityTypeAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteSessionEntityTypeAsync(
                new DeleteSessionEntityTypeRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified session entity type.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type to delete. Format:
        /// `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;/entityTypes/&lt;Entity Type
        /// Display Name&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteSessionEntityTypeAsync(
            string name,
            st::CancellationToken cancellationToken) => DeleteSessionEntityTypeAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified session entity type.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type to delete. Format:
        /// `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;/entityTypes/&lt;Entity Type
        /// Display Name&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteSessionEntityType(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteSessionEntityType(
                new DeleteSessionEntityTypeRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified session entity type.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteSessionEntityTypeAsync(
            DeleteSessionEntityTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes the specified session entity type.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteSessionEntityTypeAsync(
            DeleteSessionEntityTypeRequest request,
            st::CancellationToken cancellationToken) => DeleteSessionEntityTypeAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified session entity type.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteSessionEntityType(
            DeleteSessionEntityTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// SessionEntityTypes client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class SessionEntityTypesClientImpl : SessionEntityTypesClient
    {
        private readonly gaxgrpc::ApiCall<ListSessionEntityTypesRequest, ListSessionEntityTypesResponse> _callListSessionEntityTypes;
        private readonly gaxgrpc::ApiCall<GetSessionEntityTypeRequest, SessionEntityType> _callGetSessionEntityType;
        private readonly gaxgrpc::ApiCall<CreateSessionEntityTypeRequest, SessionEntityType> _callCreateSessionEntityType;
        private readonly gaxgrpc::ApiCall<UpdateSessionEntityTypeRequest, SessionEntityType> _callUpdateSessionEntityType;
        private readonly gaxgrpc::ApiCall<DeleteSessionEntityTypeRequest, pbwkt::Empty> _callDeleteSessionEntityType;

        /// <summary>
        /// Constructs a client wrapper for the SessionEntityTypes service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SessionEntityTypesSettings"/> used within this client </param>
        public SessionEntityTypesClientImpl(SessionEntityTypes.SessionEntityTypesClient grpcClient, SessionEntityTypesSettings settings)
        {
            GrpcClient = grpcClient;
            SessionEntityTypesSettings effectiveSettings = settings ?? SessionEntityTypesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callListSessionEntityTypes = clientHelper.BuildApiCall<ListSessionEntityTypesRequest, ListSessionEntityTypesResponse>(
                GrpcClient.ListSessionEntityTypesAsync, GrpcClient.ListSessionEntityTypes, effectiveSettings.ListSessionEntityTypesSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callGetSessionEntityType = clientHelper.BuildApiCall<GetSessionEntityTypeRequest, SessionEntityType>(
                GrpcClient.GetSessionEntityTypeAsync, GrpcClient.GetSessionEntityType, effectiveSettings.GetSessionEntityTypeSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callCreateSessionEntityType = clientHelper.BuildApiCall<CreateSessionEntityTypeRequest, SessionEntityType>(
                GrpcClient.CreateSessionEntityTypeAsync, GrpcClient.CreateSessionEntityType, effectiveSettings.CreateSessionEntityTypeSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callUpdateSessionEntityType = clientHelper.BuildApiCall<UpdateSessionEntityTypeRequest, SessionEntityType>(
                GrpcClient.UpdateSessionEntityTypeAsync, GrpcClient.UpdateSessionEntityType, effectiveSettings.UpdateSessionEntityTypeSettings)
                .WithGoogleRequestParam("session_entity_type.name", request => request.SessionEntityType?.Name);
            _callDeleteSessionEntityType = clientHelper.BuildApiCall<DeleteSessionEntityTypeRequest, pbwkt::Empty>(
                GrpcClient.DeleteSessionEntityTypeAsync, GrpcClient.DeleteSessionEntityType, effectiveSettings.DeleteSessionEntityTypeSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callListSessionEntityTypes);
            Modify_ListSessionEntityTypesApiCall(ref _callListSessionEntityTypes);
            Modify_ApiCall(ref _callGetSessionEntityType);
            Modify_GetSessionEntityTypeApiCall(ref _callGetSessionEntityType);
            Modify_ApiCall(ref _callCreateSessionEntityType);
            Modify_CreateSessionEntityTypeApiCall(ref _callCreateSessionEntityType);
            Modify_ApiCall(ref _callUpdateSessionEntityType);
            Modify_UpdateSessionEntityTypeApiCall(ref _callUpdateSessionEntityType);
            Modify_ApiCall(ref _callDeleteSessionEntityType);
            Modify_DeleteSessionEntityTypeApiCall(ref _callDeleteSessionEntityType);
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
        partial void Modify_ListSessionEntityTypesApiCall(ref gaxgrpc::ApiCall<ListSessionEntityTypesRequest, ListSessionEntityTypesResponse> call);
        partial void Modify_GetSessionEntityTypeApiCall(ref gaxgrpc::ApiCall<GetSessionEntityTypeRequest, SessionEntityType> call);
        partial void Modify_CreateSessionEntityTypeApiCall(ref gaxgrpc::ApiCall<CreateSessionEntityTypeRequest, SessionEntityType> call);
        partial void Modify_UpdateSessionEntityTypeApiCall(ref gaxgrpc::ApiCall<UpdateSessionEntityTypeRequest, SessionEntityType> call);
        partial void Modify_DeleteSessionEntityTypeApiCall(ref gaxgrpc::ApiCall<DeleteSessionEntityTypeRequest, pbwkt::Empty> call);
        partial void OnConstruction(SessionEntityTypes.SessionEntityTypesClient grpcClient, SessionEntityTypesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC SessionEntityTypes client.
        /// </summary>
        public override SessionEntityTypes.SessionEntityTypesClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_ListSessionEntityTypesRequest(ref ListSessionEntityTypesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetSessionEntityTypeRequest(ref GetSessionEntityTypeRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateSessionEntityTypeRequest(ref CreateSessionEntityTypeRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateSessionEntityTypeRequest(ref UpdateSessionEntityTypeRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteSessionEntityTypeRequest(ref DeleteSessionEntityTypeRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the list of all session entity types in the specified session.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="SessionEntityType"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListSessionEntityTypesResponse, SessionEntityType> ListSessionEntityTypesAsync(
            ListSessionEntityTypesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSessionEntityTypesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSessionEntityTypesRequest, ListSessionEntityTypesResponse, SessionEntityType>(_callListSessionEntityTypes, request, callSettings);
        }

        /// <summary>
        /// Returns the list of all session entity types in the specified session.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="SessionEntityType"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListSessionEntityTypesResponse, SessionEntityType> ListSessionEntityTypes(
            ListSessionEntityTypesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSessionEntityTypesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSessionEntityTypesRequest, ListSessionEntityTypesResponse, SessionEntityType>(_callListSessionEntityTypes, request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified session entity type.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
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
        public override stt::Task<SessionEntityType> GetSessionEntityTypeAsync(
            GetSessionEntityTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSessionEntityTypeRequest(ref request, ref callSettings);
            return _callGetSessionEntityType.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified session entity type.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
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
        public override SessionEntityType GetSessionEntityType(
            GetSessionEntityTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSessionEntityTypeRequest(ref request, ref callSettings);
            return _callGetSessionEntityType.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a session entity type.
        ///
        /// If the specified session entity type already exists, overrides the session
        /// entity type.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
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
        public override stt::Task<SessionEntityType> CreateSessionEntityTypeAsync(
            CreateSessionEntityTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSessionEntityTypeRequest(ref request, ref callSettings);
            return _callCreateSessionEntityType.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a session entity type.
        ///
        /// If the specified session entity type already exists, overrides the session
        /// entity type.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
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
        public override SessionEntityType CreateSessionEntityType(
            CreateSessionEntityTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSessionEntityTypeRequest(ref request, ref callSettings);
            return _callCreateSessionEntityType.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified session entity type.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
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
        public override stt::Task<SessionEntityType> UpdateSessionEntityTypeAsync(
            UpdateSessionEntityTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSessionEntityTypeRequest(ref request, ref callSettings);
            return _callUpdateSessionEntityType.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the specified session entity type.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
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
        public override SessionEntityType UpdateSessionEntityType(
            UpdateSessionEntityTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSessionEntityTypeRequest(ref request, ref callSettings);
            return _callUpdateSessionEntityType.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified session entity type.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public override stt::Task DeleteSessionEntityTypeAsync(
            DeleteSessionEntityTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSessionEntityTypeRequest(ref request, ref callSettings);
            return _callDeleteSessionEntityType.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified session entity type.
        ///
        /// This method doesn't work with Google Assistant integration.
        /// Contact Dialogflow support if you need to use session entities
        /// with Google Assistant integration.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteSessionEntityType(
            DeleteSessionEntityTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSessionEntityTypeRequest(ref request, ref callSettings);
            _callDeleteSessionEntityType.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListSessionEntityTypesRequest : gaxgrpc::IPageRequest { }
    public partial class ListSessionEntityTypesResponse : gaxgrpc::IPageResponse<SessionEntityType>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<SessionEntityType> GetEnumerator() => SessionEntityTypes.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
