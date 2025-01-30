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

namespace Google.Cloud.Dialogflow.V2Beta1
{
    /// <summary>Settings for <see cref="SessionsClient"/> instances.</summary>
    public sealed partial class SessionsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SessionsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SessionsSettings"/>.</returns>
        public static SessionsSettings GetDefault() => new SessionsSettings();

        /// <summary>Constructs a new <see cref="SessionsSettings"/> object with default settings.</summary>
        public SessionsSettings()
        {
        }

        private SessionsSettings(SessionsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            DetectIntentSettings = existing.DetectIntentSettings;
            StreamingDetectIntentSettings = existing.StreamingDetectIntentSettings;
            StreamingDetectIntentStreamingSettings = existing.StreamingDetectIntentStreamingSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SessionsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>SessionsClient.DetectIntent</c>
        ///  and <c>SessionsClient.DetectIntentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 220 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DetectIntentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(220000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SessionsClient.StreamingDetectIntent</c> and <c>SessionsClient.StreamingDetectIntentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 220 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StreamingDetectIntentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(220000)));

        /// <summary>
        /// <see cref="gaxgrpc::BidirectionalStreamingSettings"/> for calls to <c>SessionsClient.StreamingDetectIntent</c>
        ///  and <c>SessionsClient.StreamingDetectIntentAsync</c>.
        /// </summary>
        /// <remarks>The default local send queue size is 100.</remarks>
        public gaxgrpc::BidirectionalStreamingSettings StreamingDetectIntentStreamingSettings { get; set; } = new gaxgrpc::BidirectionalStreamingSettings(100);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SessionsSettings"/> object.</returns>
        public SessionsSettings Clone() => new SessionsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SessionsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class SessionsClientBuilder : gaxgrpc::ClientBuilderBase<SessionsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SessionsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SessionsClientBuilder() : base(SessionsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SessionsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SessionsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SessionsClient Build()
        {
            SessionsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SessionsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SessionsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SessionsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SessionsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SessionsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SessionsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SessionsClient.ChannelPool;
    }

    /// <summary>Sessions client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service used for session interactions.
    /// 
    /// For more information, see the [API interactions
    /// guide](https://cloud.google.com/dialogflow/docs/api-overview).
    /// </remarks>
    public abstract partial class SessionsClient
    {
        /// <summary>
        /// The default endpoint for the Sessions service, which is a host of "dialogflow.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dialogflow.googleapis.com:443";

        /// <summary>The default Sessions scopes.</summary>
        /// <remarks>
        /// The default Sessions scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/dialogflow</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/dialogflow",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Sessions.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SessionsClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="SessionsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SessionsClient"/>.</returns>
        public static stt::Task<SessionsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SessionsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SessionsClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="SessionsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SessionsClient"/>.</returns>
        public static SessionsClient Create() => new SessionsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SessionsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SessionsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SessionsClient"/>.</returns>
        internal static SessionsClient Create(grpccore::CallInvoker callInvoker, SessionsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Sessions.SessionsClient grpcClient = new Sessions.SessionsClient(callInvoker);
            return new SessionsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Sessions client</summary>
        public virtual Sessions.SessionsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Processes a natural language query and returns structured, actionable data
        /// as a result. This method is not idempotent, because it may cause contexts
        /// and session entity types to be updated, which in turn might affect
        /// results of future queries.
        /// 
        /// If you might use
        /// [Agent Assist](https://cloud.google.com/dialogflow/docs/#aa)
        /// or other CCAI products now or in the future, consider using
        /// [AnalyzeContent][google.cloud.dialogflow.v2beta1.Participants.AnalyzeContent]
        /// instead of `DetectIntent`. `AnalyzeContent` has additional
        /// functionality for Agent Assist and other CCAI products.
        /// 
        /// Note: Always use agent versions for production traffic.
        /// See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DetectIntentResponse DetectIntent(DetectIntentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Processes a natural language query and returns structured, actionable data
        /// as a result. This method is not idempotent, because it may cause contexts
        /// and session entity types to be updated, which in turn might affect
        /// results of future queries.
        /// 
        /// If you might use
        /// [Agent Assist](https://cloud.google.com/dialogflow/docs/#aa)
        /// or other CCAI products now or in the future, consider using
        /// [AnalyzeContent][google.cloud.dialogflow.v2beta1.Participants.AnalyzeContent]
        /// instead of `DetectIntent`. `AnalyzeContent` has additional
        /// functionality for Agent Assist and other CCAI products.
        /// 
        /// Note: Always use agent versions for production traffic.
        /// See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DetectIntentResponse> DetectIntentAsync(DetectIntentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Processes a natural language query and returns structured, actionable data
        /// as a result. This method is not idempotent, because it may cause contexts
        /// and session entity types to be updated, which in turn might affect
        /// results of future queries.
        /// 
        /// If you might use
        /// [Agent Assist](https://cloud.google.com/dialogflow/docs/#aa)
        /// or other CCAI products now or in the future, consider using
        /// [AnalyzeContent][google.cloud.dialogflow.v2beta1.Participants.AnalyzeContent]
        /// instead of `DetectIntent`. `AnalyzeContent` has additional
        /// functionality for Agent Assist and other CCAI products.
        /// 
        /// Note: Always use agent versions for production traffic.
        /// See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DetectIntentResponse> DetectIntentAsync(DetectIntentRequest request, st::CancellationToken cancellationToken) =>
            DetectIntentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Processes a natural language query and returns structured, actionable data
        /// as a result. This method is not idempotent, because it may cause contexts
        /// and session entity types to be updated, which in turn might affect
        /// results of future queries.
        /// 
        /// If you might use
        /// [Agent Assist](https://cloud.google.com/dialogflow/docs/#aa)
        /// or other CCAI products now or in the future, consider using
        /// [AnalyzeContent][google.cloud.dialogflow.v2beta1.Participants.AnalyzeContent]
        /// instead of `DetectIntent`. `AnalyzeContent` has additional
        /// functionality for Agent Assist and other CCAI products.
        /// 
        /// Note: Always use agent versions for production traffic.
        /// See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="session">
        /// Required. The name of the session this query is sent to. Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/sessions/&lt;Session
        /// ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User
        /// ID&gt;/sessions/&lt;Session ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User ID&gt;/sessions/&lt;Session
        /// ID&gt;`,
        /// 
        /// If `Location ID` is not specified we assume default 'us' location. If
        /// `Environment ID` is not specified, we assume default 'draft' environment
        /// (`Environment ID` might be referred to as environment name at some places).
        /// If `User ID` is not specified, we are using "-". It's up to the API caller
        /// to choose an appropriate `Session ID` and `User Id`. They can be a random
        /// number or some type of user and session identifiers (preferably hashed).
        /// The length of the `Session ID` and `User ID` must not exceed 36 characters.
        /// For more information, see the [API interactions
        /// guide](https://cloud.google.com/dialogflow/docs/api-overview).
        /// 
        /// Note: Always use agent versions for production traffic.
        /// See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </param>
        /// <param name="queryInput">
        /// Required. The input specification. It can be set to:
        /// 
        /// 1. an audio config which instructs the speech recognizer how to process
        /// the speech audio,
        /// 
        /// 2. a conversational query in the form of text, or
        /// 
        /// 3. an event that specifies which intent to trigger.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DetectIntentResponse DetectIntent(string session, QueryInput queryInput, gaxgrpc::CallSettings callSettings = null) =>
            DetectIntent(new DetectIntentRequest
            {
                Session = gax::GaxPreconditions.CheckNotNullOrEmpty(session, nameof(session)),
                QueryInput = gax::GaxPreconditions.CheckNotNull(queryInput, nameof(queryInput)),
            }, callSettings);

        /// <summary>
        /// Processes a natural language query and returns structured, actionable data
        /// as a result. This method is not idempotent, because it may cause contexts
        /// and session entity types to be updated, which in turn might affect
        /// results of future queries.
        /// 
        /// If you might use
        /// [Agent Assist](https://cloud.google.com/dialogflow/docs/#aa)
        /// or other CCAI products now or in the future, consider using
        /// [AnalyzeContent][google.cloud.dialogflow.v2beta1.Participants.AnalyzeContent]
        /// instead of `DetectIntent`. `AnalyzeContent` has additional
        /// functionality for Agent Assist and other CCAI products.
        /// 
        /// Note: Always use agent versions for production traffic.
        /// See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="session">
        /// Required. The name of the session this query is sent to. Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/sessions/&lt;Session
        /// ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User
        /// ID&gt;/sessions/&lt;Session ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User ID&gt;/sessions/&lt;Session
        /// ID&gt;`,
        /// 
        /// If `Location ID` is not specified we assume default 'us' location. If
        /// `Environment ID` is not specified, we assume default 'draft' environment
        /// (`Environment ID` might be referred to as environment name at some places).
        /// If `User ID` is not specified, we are using "-". It's up to the API caller
        /// to choose an appropriate `Session ID` and `User Id`. They can be a random
        /// number or some type of user and session identifiers (preferably hashed).
        /// The length of the `Session ID` and `User ID` must not exceed 36 characters.
        /// For more information, see the [API interactions
        /// guide](https://cloud.google.com/dialogflow/docs/api-overview).
        /// 
        /// Note: Always use agent versions for production traffic.
        /// See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </param>
        /// <param name="queryInput">
        /// Required. The input specification. It can be set to:
        /// 
        /// 1. an audio config which instructs the speech recognizer how to process
        /// the speech audio,
        /// 
        /// 2. a conversational query in the form of text, or
        /// 
        /// 3. an event that specifies which intent to trigger.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DetectIntentResponse> DetectIntentAsync(string session, QueryInput queryInput, gaxgrpc::CallSettings callSettings = null) =>
            DetectIntentAsync(new DetectIntentRequest
            {
                Session = gax::GaxPreconditions.CheckNotNullOrEmpty(session, nameof(session)),
                QueryInput = gax::GaxPreconditions.CheckNotNull(queryInput, nameof(queryInput)),
            }, callSettings);

        /// <summary>
        /// Processes a natural language query and returns structured, actionable data
        /// as a result. This method is not idempotent, because it may cause contexts
        /// and session entity types to be updated, which in turn might affect
        /// results of future queries.
        /// 
        /// If you might use
        /// [Agent Assist](https://cloud.google.com/dialogflow/docs/#aa)
        /// or other CCAI products now or in the future, consider using
        /// [AnalyzeContent][google.cloud.dialogflow.v2beta1.Participants.AnalyzeContent]
        /// instead of `DetectIntent`. `AnalyzeContent` has additional
        /// functionality for Agent Assist and other CCAI products.
        /// 
        /// Note: Always use agent versions for production traffic.
        /// See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="session">
        /// Required. The name of the session this query is sent to. Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/sessions/&lt;Session
        /// ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User
        /// ID&gt;/sessions/&lt;Session ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User ID&gt;/sessions/&lt;Session
        /// ID&gt;`,
        /// 
        /// If `Location ID` is not specified we assume default 'us' location. If
        /// `Environment ID` is not specified, we assume default 'draft' environment
        /// (`Environment ID` might be referred to as environment name at some places).
        /// If `User ID` is not specified, we are using "-". It's up to the API caller
        /// to choose an appropriate `Session ID` and `User Id`. They can be a random
        /// number or some type of user and session identifiers (preferably hashed).
        /// The length of the `Session ID` and `User ID` must not exceed 36 characters.
        /// For more information, see the [API interactions
        /// guide](https://cloud.google.com/dialogflow/docs/api-overview).
        /// 
        /// Note: Always use agent versions for production traffic.
        /// See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </param>
        /// <param name="queryInput">
        /// Required. The input specification. It can be set to:
        /// 
        /// 1. an audio config which instructs the speech recognizer how to process
        /// the speech audio,
        /// 
        /// 2. a conversational query in the form of text, or
        /// 
        /// 3. an event that specifies which intent to trigger.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DetectIntentResponse> DetectIntentAsync(string session, QueryInput queryInput, st::CancellationToken cancellationToken) =>
            DetectIntentAsync(session, queryInput, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Processes a natural language query and returns structured, actionable data
        /// as a result. This method is not idempotent, because it may cause contexts
        /// and session entity types to be updated, which in turn might affect
        /// results of future queries.
        /// 
        /// If you might use
        /// [Agent Assist](https://cloud.google.com/dialogflow/docs/#aa)
        /// or other CCAI products now or in the future, consider using
        /// [AnalyzeContent][google.cloud.dialogflow.v2beta1.Participants.AnalyzeContent]
        /// instead of `DetectIntent`. `AnalyzeContent` has additional
        /// functionality for Agent Assist and other CCAI products.
        /// 
        /// Note: Always use agent versions for production traffic.
        /// See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="session">
        /// Required. The name of the session this query is sent to. Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/sessions/&lt;Session
        /// ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User
        /// ID&gt;/sessions/&lt;Session ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User ID&gt;/sessions/&lt;Session
        /// ID&gt;`,
        /// 
        /// If `Location ID` is not specified we assume default 'us' location. If
        /// `Environment ID` is not specified, we assume default 'draft' environment
        /// (`Environment ID` might be referred to as environment name at some places).
        /// If `User ID` is not specified, we are using "-". It's up to the API caller
        /// to choose an appropriate `Session ID` and `User Id`. They can be a random
        /// number or some type of user and session identifiers (preferably hashed).
        /// The length of the `Session ID` and `User ID` must not exceed 36 characters.
        /// For more information, see the [API interactions
        /// guide](https://cloud.google.com/dialogflow/docs/api-overview).
        /// 
        /// Note: Always use agent versions for production traffic.
        /// See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </param>
        /// <param name="queryInput">
        /// Required. The input specification. It can be set to:
        /// 
        /// 1. an audio config which instructs the speech recognizer how to process
        /// the speech audio,
        /// 
        /// 2. a conversational query in the form of text, or
        /// 
        /// 3. an event that specifies which intent to trigger.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DetectIntentResponse DetectIntent(SessionName session, QueryInput queryInput, gaxgrpc::CallSettings callSettings = null) =>
            DetectIntent(new DetectIntentRequest
            {
                SessionAsSessionName = gax::GaxPreconditions.CheckNotNull(session, nameof(session)),
                QueryInput = gax::GaxPreconditions.CheckNotNull(queryInput, nameof(queryInput)),
            }, callSettings);

        /// <summary>
        /// Processes a natural language query and returns structured, actionable data
        /// as a result. This method is not idempotent, because it may cause contexts
        /// and session entity types to be updated, which in turn might affect
        /// results of future queries.
        /// 
        /// If you might use
        /// [Agent Assist](https://cloud.google.com/dialogflow/docs/#aa)
        /// or other CCAI products now or in the future, consider using
        /// [AnalyzeContent][google.cloud.dialogflow.v2beta1.Participants.AnalyzeContent]
        /// instead of `DetectIntent`. `AnalyzeContent` has additional
        /// functionality for Agent Assist and other CCAI products.
        /// 
        /// Note: Always use agent versions for production traffic.
        /// See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="session">
        /// Required. The name of the session this query is sent to. Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/sessions/&lt;Session
        /// ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User
        /// ID&gt;/sessions/&lt;Session ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User ID&gt;/sessions/&lt;Session
        /// ID&gt;`,
        /// 
        /// If `Location ID` is not specified we assume default 'us' location. If
        /// `Environment ID` is not specified, we assume default 'draft' environment
        /// (`Environment ID` might be referred to as environment name at some places).
        /// If `User ID` is not specified, we are using "-". It's up to the API caller
        /// to choose an appropriate `Session ID` and `User Id`. They can be a random
        /// number or some type of user and session identifiers (preferably hashed).
        /// The length of the `Session ID` and `User ID` must not exceed 36 characters.
        /// For more information, see the [API interactions
        /// guide](https://cloud.google.com/dialogflow/docs/api-overview).
        /// 
        /// Note: Always use agent versions for production traffic.
        /// See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </param>
        /// <param name="queryInput">
        /// Required. The input specification. It can be set to:
        /// 
        /// 1. an audio config which instructs the speech recognizer how to process
        /// the speech audio,
        /// 
        /// 2. a conversational query in the form of text, or
        /// 
        /// 3. an event that specifies which intent to trigger.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DetectIntentResponse> DetectIntentAsync(SessionName session, QueryInput queryInput, gaxgrpc::CallSettings callSettings = null) =>
            DetectIntentAsync(new DetectIntentRequest
            {
                SessionAsSessionName = gax::GaxPreconditions.CheckNotNull(session, nameof(session)),
                QueryInput = gax::GaxPreconditions.CheckNotNull(queryInput, nameof(queryInput)),
            }, callSettings);

        /// <summary>
        /// Processes a natural language query and returns structured, actionable data
        /// as a result. This method is not idempotent, because it may cause contexts
        /// and session entity types to be updated, which in turn might affect
        /// results of future queries.
        /// 
        /// If you might use
        /// [Agent Assist](https://cloud.google.com/dialogflow/docs/#aa)
        /// or other CCAI products now or in the future, consider using
        /// [AnalyzeContent][google.cloud.dialogflow.v2beta1.Participants.AnalyzeContent]
        /// instead of `DetectIntent`. `AnalyzeContent` has additional
        /// functionality for Agent Assist and other CCAI products.
        /// 
        /// Note: Always use agent versions for production traffic.
        /// See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="session">
        /// Required. The name of the session this query is sent to. Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/sessions/&lt;Session
        /// ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User
        /// ID&gt;/sessions/&lt;Session ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User ID&gt;/sessions/&lt;Session
        /// ID&gt;`,
        /// 
        /// If `Location ID` is not specified we assume default 'us' location. If
        /// `Environment ID` is not specified, we assume default 'draft' environment
        /// (`Environment ID` might be referred to as environment name at some places).
        /// If `User ID` is not specified, we are using "-". It's up to the API caller
        /// to choose an appropriate `Session ID` and `User Id`. They can be a random
        /// number or some type of user and session identifiers (preferably hashed).
        /// The length of the `Session ID` and `User ID` must not exceed 36 characters.
        /// For more information, see the [API interactions
        /// guide](https://cloud.google.com/dialogflow/docs/api-overview).
        /// 
        /// Note: Always use agent versions for production traffic.
        /// See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </param>
        /// <param name="queryInput">
        /// Required. The input specification. It can be set to:
        /// 
        /// 1. an audio config which instructs the speech recognizer how to process
        /// the speech audio,
        /// 
        /// 2. a conversational query in the form of text, or
        /// 
        /// 3. an event that specifies which intent to trigger.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DetectIntentResponse> DetectIntentAsync(SessionName session, QueryInput queryInput, st::CancellationToken cancellationToken) =>
            DetectIntentAsync(session, queryInput, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Bidirectional streaming methods for
        /// <see cref="StreamingDetectIntent(gaxgrpc::CallSettings,gaxgrpc::BidirectionalStreamingSettings)"/>.
        /// </summary>
        public abstract partial class StreamingDetectIntentStream : gaxgrpc::BidirectionalStreamingBase<StreamingDetectIntentRequest, StreamingDetectIntentResponse>
        {
        }

        /// <summary>
        /// Processes a natural language query in audio format in a streaming fashion
        /// and returns structured, actionable data as a result. This method is only
        /// available via the gRPC API (not REST).
        /// 
        /// If you might use
        /// [Agent Assist](https://cloud.google.com/dialogflow/docs/#aa)
        /// or other CCAI products now or in the future, consider using
        /// [StreamingAnalyzeContent][google.cloud.dialogflow.v2beta1.Participants.StreamingAnalyzeContent]
        /// instead of `StreamingDetectIntent`. `StreamingAnalyzeContent` has
        /// additional functionality for Agent Assist and other CCAI products.
        /// 
        /// Note: Always use agent versions for production traffic.
        /// See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public virtual StreamingDetectIntentStream StreamingDetectIntent(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null) =>
            throw new sys::NotImplementedException();
    }

    /// <summary>Sessions client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service used for session interactions.
    /// 
    /// For more information, see the [API interactions
    /// guide](https://cloud.google.com/dialogflow/docs/api-overview).
    /// </remarks>
    public sealed partial class SessionsClientImpl : SessionsClient
    {
        private readonly gaxgrpc::ApiCall<DetectIntentRequest, DetectIntentResponse> _callDetectIntent;

        private readonly gaxgrpc::ApiBidirectionalStreamingCall<StreamingDetectIntentRequest, StreamingDetectIntentResponse> _callStreamingDetectIntent;

        /// <summary>
        /// Constructs a client wrapper for the Sessions service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SessionsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SessionsClientImpl(Sessions.SessionsClient grpcClient, SessionsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SessionsSettings effectiveSettings = settings ?? SessionsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callDetectIntent = clientHelper.BuildApiCall<DetectIntentRequest, DetectIntentResponse>("DetectIntent", grpcClient.DetectIntentAsync, grpcClient.DetectIntent, effectiveSettings.DetectIntentSettings).WithGoogleRequestParam("session", request => request.Session);
            Modify_ApiCall(ref _callDetectIntent);
            Modify_DetectIntentApiCall(ref _callDetectIntent);
            _callStreamingDetectIntent = clientHelper.BuildApiCall<StreamingDetectIntentRequest, StreamingDetectIntentResponse>("StreamingDetectIntent", grpcClient.StreamingDetectIntent, effectiveSettings.StreamingDetectIntentSettings, effectiveSettings.StreamingDetectIntentStreamingSettings);
            Modify_ApiCall(ref _callStreamingDetectIntent);
            Modify_StreamingDetectIntentApiCall(ref _callStreamingDetectIntent);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiBidirectionalStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_DetectIntentApiCall(ref gaxgrpc::ApiCall<DetectIntentRequest, DetectIntentResponse> call);

        partial void Modify_StreamingDetectIntentApiCall(ref gaxgrpc::ApiBidirectionalStreamingCall<StreamingDetectIntentRequest, StreamingDetectIntentResponse> call);

        partial void OnConstruction(Sessions.SessionsClient grpcClient, SessionsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Sessions client</summary>
        public override Sessions.SessionsClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_DetectIntentRequest(ref DetectIntentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StreamingDetectIntentRequestCallSettings(ref gaxgrpc::CallSettings settings);

        partial void Modify_StreamingDetectIntentRequestRequest(ref StreamingDetectIntentRequest request);

        /// <summary>
        /// Processes a natural language query and returns structured, actionable data
        /// as a result. This method is not idempotent, because it may cause contexts
        /// and session entity types to be updated, which in turn might affect
        /// results of future queries.
        /// 
        /// If you might use
        /// [Agent Assist](https://cloud.google.com/dialogflow/docs/#aa)
        /// or other CCAI products now or in the future, consider using
        /// [AnalyzeContent][google.cloud.dialogflow.v2beta1.Participants.AnalyzeContent]
        /// instead of `DetectIntent`. `AnalyzeContent` has additional
        /// functionality for Agent Assist and other CCAI products.
        /// 
        /// Note: Always use agent versions for production traffic.
        /// See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DetectIntentResponse DetectIntent(DetectIntentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DetectIntentRequest(ref request, ref callSettings);
            return _callDetectIntent.Sync(request, callSettings);
        }

        /// <summary>
        /// Processes a natural language query and returns structured, actionable data
        /// as a result. This method is not idempotent, because it may cause contexts
        /// and session entity types to be updated, which in turn might affect
        /// results of future queries.
        /// 
        /// If you might use
        /// [Agent Assist](https://cloud.google.com/dialogflow/docs/#aa)
        /// or other CCAI products now or in the future, consider using
        /// [AnalyzeContent][google.cloud.dialogflow.v2beta1.Participants.AnalyzeContent]
        /// instead of `DetectIntent`. `AnalyzeContent` has additional
        /// functionality for Agent Assist and other CCAI products.
        /// 
        /// Note: Always use agent versions for production traffic.
        /// See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DetectIntentResponse> DetectIntentAsync(DetectIntentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DetectIntentRequest(ref request, ref callSettings);
            return _callDetectIntent.Async(request, callSettings);
        }

        internal sealed partial class StreamingDetectIntentStreamImpl : StreamingDetectIntentStream
        {
            /// <summary>Construct the bidirectional streaming method for <c>StreamingDetectIntent</c>.</summary>
            /// <param name="service">The service containing this streaming method.</param>
            /// <param name="call">The underlying gRPC duplex streaming call.</param>
            /// <param name="writeBuffer">
            /// The <see cref="gaxgrpc::BufferedClientStreamWriter{StreamingDetectIntentRequest}"/> instance associated
            /// with this streaming call.
            /// </param>
            public StreamingDetectIntentStreamImpl(SessionsClientImpl service, grpccore::AsyncDuplexStreamingCall<StreamingDetectIntentRequest, StreamingDetectIntentResponse> call, gaxgrpc::BufferedClientStreamWriter<StreamingDetectIntentRequest> writeBuffer)
            {
                _service = service;
                GrpcCall = call;
                _writeBuffer = writeBuffer;
            }

            private SessionsClientImpl _service;

            private gaxgrpc::BufferedClientStreamWriter<StreamingDetectIntentRequest> _writeBuffer;

            public override grpccore::AsyncDuplexStreamingCall<StreamingDetectIntentRequest, StreamingDetectIntentResponse> GrpcCall { get; }

            private StreamingDetectIntentRequest ModifyRequest(StreamingDetectIntentRequest request)
            {
                _service.Modify_StreamingDetectIntentRequestRequest(ref request);
                return request;
            }

            public override stt::Task TryWriteAsync(StreamingDetectIntentRequest message) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message));

            public override stt::Task WriteAsync(StreamingDetectIntentRequest message) =>
                _writeBuffer.WriteAsync(ModifyRequest(message));

            public override stt::Task TryWriteAsync(StreamingDetectIntentRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message), options);

            public override stt::Task WriteAsync(StreamingDetectIntentRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.WriteAsync(ModifyRequest(message), options);

            public override stt::Task TryWriteCompleteAsync() => _writeBuffer.TryWriteCompleteAsync();

            public override stt::Task WriteCompleteAsync() => _writeBuffer.WriteCompleteAsync();
        }

        /// <summary>
        /// Processes a natural language query in audio format in a streaming fashion
        /// and returns structured, actionable data as a result. This method is only
        /// available via the gRPC API (not REST).
        /// 
        /// If you might use
        /// [Agent Assist](https://cloud.google.com/dialogflow/docs/#aa)
        /// or other CCAI products now or in the future, consider using
        /// [StreamingAnalyzeContent][google.cloud.dialogflow.v2beta1.Participants.StreamingAnalyzeContent]
        /// instead of `StreamingDetectIntent`. `StreamingAnalyzeContent` has
        /// additional functionality for Agent Assist and other CCAI products.
        /// 
        /// Note: Always use agent versions for production traffic.
        /// See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public override SessionsClient.StreamingDetectIntentStream StreamingDetectIntent(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null)
        {
            Modify_StreamingDetectIntentRequestCallSettings(ref callSettings);
            gaxgrpc::BidirectionalStreamingSettings effectiveStreamingSettings = streamingSettings ?? _callStreamingDetectIntent.StreamingSettings;
            grpccore::AsyncDuplexStreamingCall<StreamingDetectIntentRequest, StreamingDetectIntentResponse> call = _callStreamingDetectIntent.Call(callSettings);
            gaxgrpc::BufferedClientStreamWriter<StreamingDetectIntentRequest> writeBuffer = new gaxgrpc::BufferedClientStreamWriter<StreamingDetectIntentRequest>(call.RequestStream, effectiveStreamingSettings.BufferedClientWriterCapacity);
            return new StreamingDetectIntentStreamImpl(this, call, writeBuffer);
        }
    }

    public static partial class Sessions
    {
        public partial class SessionsClient
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
