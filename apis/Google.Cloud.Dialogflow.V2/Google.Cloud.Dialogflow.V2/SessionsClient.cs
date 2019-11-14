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
    /// Settings for a <see cref="SessionsClient"/>.
    /// </summary>
    public sealed partial class SessionsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="SessionsSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="SessionsSettings"/>.
        /// </returns>
        public static SessionsSettings GetDefault() => new SessionsSettings();

        /// <summary>
        /// Constructs a new <see cref="SessionsSettings"/> object with default settings.
        /// </summary>
        public SessionsSettings() { }

        private SessionsSettings(SessionsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            DetectIntentSettings = existing.DetectIntentSettings;
            StreamingDetectIntentSettings = existing.StreamingDetectIntentSettings;
            StreamingDetectIntentStreamingSettings = existing.StreamingDetectIntentStreamingSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SessionsSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="SessionsClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="SessionsClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="SessionsClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="SessionsClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="SessionsClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="SessionsClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="SessionsClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="SessionsClient"/> RPC methods is defined as:
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
        /// <c>SessionsClient.DetectIntent</c> and <c>SessionsClient.DetectIntentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SessionsClient.DetectIntent</c> and
        /// <c>SessionsClient.DetectIntentAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings DetectIntentSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for calls to <c>SessionsClient.StreamingDetectIntent</c>.
        /// </summary>
        /// <remarks>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings StreamingDetectIntentSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::BidirectionalStreamingSettings"/> for calls to
        /// <c>SessionsClient.StreamingDetectIntent</c>.
        /// </summary>
        /// <remarks>
        /// The default local send queue size is 100.
        /// </remarks>
        public gaxgrpc::BidirectionalStreamingSettings StreamingDetectIntentStreamingSettings { get; set; } =
            new gaxgrpc::BidirectionalStreamingSettings(100);

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="SessionsSettings"/> object.</returns>
        public SessionsSettings Clone() => new SessionsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SessionsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class SessionsClientBuilder : gaxgrpc::ClientBuilderBase<SessionsClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public SessionsSettings Settings { get; set; }

        /// <inheritdoc/>
        public override SessionsClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SessionsClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<SessionsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SessionsClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => SessionsClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => SessionsClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => SessionsClient.ChannelPool;
    }

    /// <summary>
    /// Sessions client wrapper, for convenient use.
    /// </summary>
    public abstract partial class SessionsClient
    {
        /// <summary>
        /// The default endpoint for the Sessions service, which is a host of "dialogflow.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("dialogflow.googleapis.com", 443);

        /// <summary>
        /// The default Sessions scopes.
        /// </summary>
        /// <remarks>
        /// The default Sessions scopes are:
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
        /// Asynchronously creates a <see cref="SessionsClient"/>, applying defaults for all unspecified settings,
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
        /// SessionsClient client = await SessionsClient.CreateAsync();
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
        ///     SessionsClient.DefaultEndpoint.Host, SessionsClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// SessionsClient client = SessionsClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="SessionsSettings"/>.</param>
        /// <returns>The task representing the created <see cref="SessionsClient"/>.</returns>
        public static async stt::Task<SessionsClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, SessionsSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="SessionsClient"/>, applying defaults for all unspecified settings,
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
        /// SessionsClient client = SessionsClient.Create();
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
        ///     SessionsClient.DefaultEndpoint.Host, SessionsClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// SessionsClient client = SessionsClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="SessionsSettings"/>.</param>
        /// <returns>The created <see cref="SessionsClient"/>.</returns>
        public static SessionsClient Create(gaxgrpc::ServiceEndpoint endpoint = null, SessionsSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="SessionsClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="SessionsSettings"/>.</param>
        /// <returns>The created <see cref="SessionsClient"/>.</returns>
        public static SessionsClient Create(grpccore::Channel channel, SessionsSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="SessionsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="SessionsSettings"/>.</param>
        /// <returns>The created <see cref="SessionsClient"/>.</returns>
        public static SessionsClient Create(grpccore::CallInvoker callInvoker, SessionsSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Sessions.SessionsClient grpcClient = new Sessions.SessionsClient(callInvoker);
            return new SessionsClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, SessionsSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, SessionsSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, SessionsSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, SessionsSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC Sessions client.
        /// </summary>
        public virtual Sessions.SessionsClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Processes a natural language query and returns structured, actionable data
        /// as a result. This method is not idempotent, because it may cause contexts
        /// and session entity types to be updated, which in turn might affect
        /// results of future queries.
        /// </summary>
        /// <param name="session">
        /// Required. The name of the session this query is sent to. Format:
        /// `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;`. It's up to the API
        /// caller to choose an appropriate session ID. It can be a random number or
        /// some type of user identifier (preferably hashed). The length of the session
        /// ID must not exceed 36 bytes.
        /// </param>
        /// <param name="queryInput">
        /// Required. The input specification. It can be set to:
        ///
        /// 1.  an audio config
        ///     which instructs the speech recognizer how to process the speech audio,
        ///
        /// 2.  a conversational query in the form of text, or
        ///
        /// 3.  an event that specifies which intent to trigger.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<DetectIntentResponse> DetectIntentAsync(
            SessionName session,
            QueryInput queryInput,
            gaxgrpc::CallSettings callSettings = null) => DetectIntentAsync(
                new DetectIntentRequest
                {
                    SessionAsSessionName = gax::GaxPreconditions.CheckNotNull(session, nameof(session)),
                    QueryInput = gax::GaxPreconditions.CheckNotNull(queryInput, nameof(queryInput)),
                },
                callSettings);

        /// <summary>
        /// Processes a natural language query and returns structured, actionable data
        /// as a result. This method is not idempotent, because it may cause contexts
        /// and session entity types to be updated, which in turn might affect
        /// results of future queries.
        /// </summary>
        /// <param name="session">
        /// Required. The name of the session this query is sent to. Format:
        /// `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;`. It's up to the API
        /// caller to choose an appropriate session ID. It can be a random number or
        /// some type of user identifier (preferably hashed). The length of the session
        /// ID must not exceed 36 bytes.
        /// </param>
        /// <param name="queryInput">
        /// Required. The input specification. It can be set to:
        ///
        /// 1.  an audio config
        ///     which instructs the speech recognizer how to process the speech audio,
        ///
        /// 2.  a conversational query in the form of text, or
        ///
        /// 3.  an event that specifies which intent to trigger.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<DetectIntentResponse> DetectIntentAsync(
            SessionName session,
            QueryInput queryInput,
            st::CancellationToken cancellationToken) => DetectIntentAsync(
                session,
                queryInput,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Processes a natural language query and returns structured, actionable data
        /// as a result. This method is not idempotent, because it may cause contexts
        /// and session entity types to be updated, which in turn might affect
        /// results of future queries.
        /// </summary>
        /// <param name="session">
        /// Required. The name of the session this query is sent to. Format:
        /// `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;`. It's up to the API
        /// caller to choose an appropriate session ID. It can be a random number or
        /// some type of user identifier (preferably hashed). The length of the session
        /// ID must not exceed 36 bytes.
        /// </param>
        /// <param name="queryInput">
        /// Required. The input specification. It can be set to:
        ///
        /// 1.  an audio config
        ///     which instructs the speech recognizer how to process the speech audio,
        ///
        /// 2.  a conversational query in the form of text, or
        ///
        /// 3.  an event that specifies which intent to trigger.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual DetectIntentResponse DetectIntent(
            SessionName session,
            QueryInput queryInput,
            gaxgrpc::CallSettings callSettings = null) => DetectIntent(
                new DetectIntentRequest
                {
                    SessionAsSessionName = gax::GaxPreconditions.CheckNotNull(session, nameof(session)),
                    QueryInput = gax::GaxPreconditions.CheckNotNull(queryInput, nameof(queryInput)),
                },
                callSettings);

        /// <summary>
        /// Processes a natural language query and returns structured, actionable data
        /// as a result. This method is not idempotent, because it may cause contexts
        /// and session entity types to be updated, which in turn might affect
        /// results of future queries.
        /// </summary>
        /// <param name="session">
        /// Required. The name of the session this query is sent to. Format:
        /// `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;`. It's up to the API
        /// caller to choose an appropriate session ID. It can be a random number or
        /// some type of user identifier (preferably hashed). The length of the session
        /// ID must not exceed 36 bytes.
        /// </param>
        /// <param name="queryInput">
        /// Required. The input specification. It can be set to:
        ///
        /// 1.  an audio config
        ///     which instructs the speech recognizer how to process the speech audio,
        ///
        /// 2.  a conversational query in the form of text, or
        ///
        /// 3.  an event that specifies which intent to trigger.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<DetectIntentResponse> DetectIntentAsync(
            string session,
            QueryInput queryInput,
            gaxgrpc::CallSettings callSettings = null) => DetectIntentAsync(
                new DetectIntentRequest
                {
                    Session = gax::GaxPreconditions.CheckNotNullOrEmpty(session, nameof(session)),
                    QueryInput = gax::GaxPreconditions.CheckNotNull(queryInput, nameof(queryInput)),
                },
                callSettings);

        /// <summary>
        /// Processes a natural language query and returns structured, actionable data
        /// as a result. This method is not idempotent, because it may cause contexts
        /// and session entity types to be updated, which in turn might affect
        /// results of future queries.
        /// </summary>
        /// <param name="session">
        /// Required. The name of the session this query is sent to. Format:
        /// `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;`. It's up to the API
        /// caller to choose an appropriate session ID. It can be a random number or
        /// some type of user identifier (preferably hashed). The length of the session
        /// ID must not exceed 36 bytes.
        /// </param>
        /// <param name="queryInput">
        /// Required. The input specification. It can be set to:
        ///
        /// 1.  an audio config
        ///     which instructs the speech recognizer how to process the speech audio,
        ///
        /// 2.  a conversational query in the form of text, or
        ///
        /// 3.  an event that specifies which intent to trigger.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<DetectIntentResponse> DetectIntentAsync(
            string session,
            QueryInput queryInput,
            st::CancellationToken cancellationToken) => DetectIntentAsync(
                session,
                queryInput,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Processes a natural language query and returns structured, actionable data
        /// as a result. This method is not idempotent, because it may cause contexts
        /// and session entity types to be updated, which in turn might affect
        /// results of future queries.
        /// </summary>
        /// <param name="session">
        /// Required. The name of the session this query is sent to. Format:
        /// `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;`. It's up to the API
        /// caller to choose an appropriate session ID. It can be a random number or
        /// some type of user identifier (preferably hashed). The length of the session
        /// ID must not exceed 36 bytes.
        /// </param>
        /// <param name="queryInput">
        /// Required. The input specification. It can be set to:
        ///
        /// 1.  an audio config
        ///     which instructs the speech recognizer how to process the speech audio,
        ///
        /// 2.  a conversational query in the form of text, or
        ///
        /// 3.  an event that specifies which intent to trigger.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual DetectIntentResponse DetectIntent(
            string session,
            QueryInput queryInput,
            gaxgrpc::CallSettings callSettings = null) => DetectIntent(
                new DetectIntentRequest
                {
                    Session = gax::GaxPreconditions.CheckNotNullOrEmpty(session, nameof(session)),
                    QueryInput = gax::GaxPreconditions.CheckNotNull(queryInput, nameof(queryInput)),
                },
                callSettings);

        /// <summary>
        /// Processes a natural language query and returns structured, actionable data
        /// as a result. This method is not idempotent, because it may cause contexts
        /// and session entity types to be updated, which in turn might affect
        /// results of future queries.
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
        public virtual stt::Task<DetectIntentResponse> DetectIntentAsync(
            DetectIntentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Processes a natural language query and returns structured, actionable data
        /// as a result. This method is not idempotent, because it may cause contexts
        /// and session entity types to be updated, which in turn might affect
        /// results of future queries.
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
        public virtual stt::Task<DetectIntentResponse> DetectIntentAsync(
            DetectIntentRequest request,
            st::CancellationToken cancellationToken) => DetectIntentAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Processes a natural language query and returns structured, actionable data
        /// as a result. This method is not idempotent, because it may cause contexts
        /// and session entity types to be updated, which in turn might affect
        /// results of future queries.
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
        public virtual DetectIntentResponse DetectIntent(
            DetectIntentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Processes a natural language query in audio format in a streaming fashion
        /// and returns structured, actionable data as a result. This method is only
        /// available via the gRPC API (not REST).
        /// </summary>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <param name="streamingSettings">
        /// If not null, applies streaming overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The client-server stream.
        /// </returns>
        public virtual StreamingDetectIntentStream StreamingDetectIntent(
            gaxgrpc::CallSettings callSettings = null,
            gaxgrpc::BidirectionalStreamingSettings streamingSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Bidirectional streaming methods for <c>StreamingDetectIntent</c>.
        /// </summary>
        public abstract partial class StreamingDetectIntentStream : gaxgrpc::BidirectionalStreamingBase<StreamingDetectIntentRequest, StreamingDetectIntentResponse>
        {
        }

    }

    /// <summary>
    /// Sessions client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class SessionsClientImpl : SessionsClient
    {
        private readonly gaxgrpc::ApiCall<DetectIntentRequest, DetectIntentResponse> _callDetectIntent;
        private readonly gaxgrpc::ApiBidirectionalStreamingCall<StreamingDetectIntentRequest, StreamingDetectIntentResponse> _callStreamingDetectIntent;

        /// <summary>
        /// Constructs a client wrapper for the Sessions service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SessionsSettings"/> used within this client </param>
        public SessionsClientImpl(Sessions.SessionsClient grpcClient, SessionsSettings settings)
        {
            GrpcClient = grpcClient;
            SessionsSettings effectiveSettings = settings ?? SessionsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callDetectIntent = clientHelper.BuildApiCall<DetectIntentRequest, DetectIntentResponse>(
                GrpcClient.DetectIntentAsync, GrpcClient.DetectIntent, effectiveSettings.DetectIntentSettings)
                .WithGoogleRequestParam("session", request => request.Session);
            _callStreamingDetectIntent = clientHelper.BuildApiCall<StreamingDetectIntentRequest, StreamingDetectIntentResponse>(
                GrpcClient.StreamingDetectIntent, effectiveSettings.StreamingDetectIntentSettings, effectiveSettings.StreamingDetectIntentStreamingSettings);
            Modify_ApiCall(ref _callDetectIntent);
            Modify_DetectIntentApiCall(ref _callDetectIntent);
            Modify_ApiCall(ref _callStreamingDetectIntent);
            Modify_StreamingDetectIntentApiCall(ref _callStreamingDetectIntent);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        // Partial methods are named to (mostly) ensure there cannot be conflicts with RPC method names.

        // Partial methods called for every ApiCall on construction.
        // Allows modification of all the underlying ApiCall objects.
        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call)
            where TRequest : class, pb::IMessage<TRequest>
            where TResponse : class, pb::IMessage<TResponse>;
        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiBidirectionalStreamingCall<TRequest, TResponse> call)
            where TRequest : class, pb::IMessage<TRequest>
            where TResponse : class, pb::IMessage<TResponse>;

        // Partial methods called for each ApiCall on construction.
        // Allows per-RPC-method modification of the underlying ApiCall object.
        partial void Modify_DetectIntentApiCall(ref gaxgrpc::ApiCall<DetectIntentRequest, DetectIntentResponse> call);
        partial void Modify_StreamingDetectIntentApiCall(ref gaxgrpc::ApiBidirectionalStreamingCall<StreamingDetectIntentRequest, StreamingDetectIntentResponse> call);
        partial void OnConstruction(Sessions.SessionsClient grpcClient, SessionsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC Sessions client.
        /// </summary>
        public override Sessions.SessionsClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_DetectIntentRequest(ref DetectIntentRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_StreamingDetectIntentRequestCallSettings(ref gaxgrpc::CallSettings settings);
        partial void Modify_StreamingDetectIntentRequestRequest(ref StreamingDetectIntentRequest request);

        /// <summary>
        /// Processes a natural language query and returns structured, actionable data
        /// as a result. This method is not idempotent, because it may cause contexts
        /// and session entity types to be updated, which in turn might affect
        /// results of future queries.
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
        public override stt::Task<DetectIntentResponse> DetectIntentAsync(
            DetectIntentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DetectIntentRequest(ref request, ref callSettings);
            return _callDetectIntent.Async(request, callSettings);
        }

        /// <summary>
        /// Processes a natural language query and returns structured, actionable data
        /// as a result. This method is not idempotent, because it may cause contexts
        /// and session entity types to be updated, which in turn might affect
        /// results of future queries.
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
        public override DetectIntentResponse DetectIntent(
            DetectIntentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DetectIntentRequest(ref request, ref callSettings);
            return _callDetectIntent.Sync(request, callSettings);
        }

        /// <summary>
        /// Processes a natural language query in audio format in a streaming fashion
        /// and returns structured, actionable data as a result. This method is only
        /// available via the gRPC API (not REST).
        /// </summary>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <param name="streamingSettings">
        /// If not null, applies streaming overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The client-server stream.
        /// </returns>
        public override StreamingDetectIntentStream StreamingDetectIntent(
            gaxgrpc::CallSettings callSettings = null,
            gaxgrpc::BidirectionalStreamingSettings streamingSettings = null)
        {
            Modify_StreamingDetectIntentRequestCallSettings(ref callSettings);
            gaxgrpc::BidirectionalStreamingSettings effectiveStreamingSettings =
                streamingSettings ?? _callStreamingDetectIntent.StreamingSettings;
            grpccore::AsyncDuplexStreamingCall<StreamingDetectIntentRequest, StreamingDetectIntentResponse> call =
                _callStreamingDetectIntent.Call(callSettings);
            gaxgrpc::BufferedClientStreamWriter<StreamingDetectIntentRequest> writeBuffer =
                new gaxgrpc::BufferedClientStreamWriter<StreamingDetectIntentRequest>(
                    call.RequestStream, effectiveStreamingSettings.BufferedClientWriterCapacity);
            return new StreamingDetectIntentStreamImpl(this, call, writeBuffer);
        }

        internal sealed partial class StreamingDetectIntentStreamImpl : StreamingDetectIntentStream
        {
            /// <summary>
            /// Construct the bidirectional streaming method for <c>StreamingDetectIntent</c>.
            /// </summary>
            /// <param name="service">The service containing this streaming method.</param>
            /// <param name="call">The underlying gRPC duplex streaming call.</param>
            /// <param name="writeBuffer">The <see cref="gaxgrpc::BufferedClientStreamWriter{StreamingDetectIntentRequest}"/>
            /// instance associated with this streaming call.</param>
            public StreamingDetectIntentStreamImpl(
                SessionsClientImpl service,
                grpccore::AsyncDuplexStreamingCall<StreamingDetectIntentRequest, StreamingDetectIntentResponse> call,
                gaxgrpc::BufferedClientStreamWriter<StreamingDetectIntentRequest> writeBuffer)
            {
                _service = service;
                GrpcCall = call;
                _writeBuffer = writeBuffer;
            }

            private SessionsClientImpl _service;
            private gaxgrpc::BufferedClientStreamWriter<StreamingDetectIntentRequest> _writeBuffer;

            private StreamingDetectIntentRequest ModifyRequest(StreamingDetectIntentRequest request)
            {
                _service.Modify_StreamingDetectIntentRequestRequest(ref request);
                return request;
            }

            /// <inheritdoc/>
            public override grpccore::AsyncDuplexStreamingCall<StreamingDetectIntentRequest, StreamingDetectIntentResponse> GrpcCall { get; }

            /// <inheritdoc/>
            public override stt::Task TryWriteAsync(StreamingDetectIntentRequest message) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message));

            /// <inheritdoc/>
            public override stt::Task WriteAsync(StreamingDetectIntentRequest message) =>
                _writeBuffer.WriteAsync(ModifyRequest(message));

            /// <inheritdoc/>
            public override stt::Task TryWriteAsync(StreamingDetectIntentRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message), options);

            /// <inheritdoc/>
            public override stt::Task WriteAsync(StreamingDetectIntentRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.WriteAsync(ModifyRequest(message), options);

            /// <inheritdoc/>
            public override stt::Task TryWriteCompleteAsync() =>
                _writeBuffer.TryWriteCompleteAsync();

            /// <inheritdoc/>
            public override stt::Task WriteCompleteAsync() =>
                _writeBuffer.WriteCompleteAsync();
        }

    }

    // Partial classes to enable page-streaming


}
