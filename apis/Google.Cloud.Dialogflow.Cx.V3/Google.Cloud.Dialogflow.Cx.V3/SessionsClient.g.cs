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

namespace Google.Cloud.Dialogflow.Cx.V3
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
            ServerStreamingDetectIntentSettings = existing.ServerStreamingDetectIntentSettings;
            StreamingDetectIntentSettings = existing.StreamingDetectIntentSettings;
            StreamingDetectIntentStreamingSettings = existing.StreamingDetectIntentStreamingSettings;
            MatchIntentSettings = existing.MatchIntentSettings;
            FulfillIntentSettings = existing.FulfillIntentSettings;
            SubmitAnswerFeedbackSettings = existing.SubmitAnswerFeedbackSettings;
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
        /// <c>SessionsClient.ServerStreamingDetectIntent</c> and <c>SessionsClient.ServerStreamingDetectIntentAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 220 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ServerStreamingDetectIntentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(220000)));

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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>SessionsClient.MatchIntent</c>
        ///  and <c>SessionsClient.MatchIntentAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MatchIntentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SessionsClient.FulfillIntent</c> and <c>SessionsClient.FulfillIntentAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FulfillIntentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SessionsClient.SubmitAnswerFeedback</c> and <c>SessionsClient.SubmitAnswerFeedbackAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SubmitAnswerFeedbackSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

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
    /// A session represents an interaction with a user. You retrieve user input
    /// and pass it to the
    /// [DetectIntent][google.cloud.dialogflow.cx.v3.Sessions.DetectIntent] method to
    /// determine user intent and respond.
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
        /// as a result. This method is not idempotent, because it may cause session
        /// entity types to be updated, which in turn might affect results of future
        /// queries.
        /// 
        /// Note: Always use agent versions for production traffic.
        /// See [Versions and
        /// environments](https://cloud.google.com/dialogflow/cx/docs/concept/version).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DetectIntentResponse DetectIntent(DetectIntentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Processes a natural language query and returns structured, actionable data
        /// as a result. This method is not idempotent, because it may cause session
        /// entity types to be updated, which in turn might affect results of future
        /// queries.
        /// 
        /// Note: Always use agent versions for production traffic.
        /// See [Versions and
        /// environments](https://cloud.google.com/dialogflow/cx/docs/concept/version).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DetectIntentResponse> DetectIntentAsync(DetectIntentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Processes a natural language query and returns structured, actionable data
        /// as a result. This method is not idempotent, because it may cause session
        /// entity types to be updated, which in turn might affect results of future
        /// queries.
        /// 
        /// Note: Always use agent versions for production traffic.
        /// See [Versions and
        /// environments](https://cloud.google.com/dialogflow/cx/docs/concept/version).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DetectIntentResponse> DetectIntentAsync(DetectIntentRequest request, st::CancellationToken cancellationToken) =>
            DetectIntentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Server streaming methods for
        /// <see cref="ServerStreamingDetectIntent(DetectIntentRequest,gaxgrpc::CallSettings)"/>.
        /// </summary>
        public abstract partial class ServerStreamingDetectIntentStream : gaxgrpc::ServerStreamingBase<DetectIntentResponse>
        {
        }

        /// <summary>
        /// Processes a natural language query and returns structured, actionable data
        /// as a result through server-side streaming. Server-side streaming allows
        /// Dialogflow to send [partial
        /// responses](https://cloud.google.com/dialogflow/cx/docs/concept/fulfillment#partial-response)
        /// earlier in a single request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ServerStreamingDetectIntentStream ServerStreamingDetectIntent(DetectIntentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

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
        /// Note: Always use agent versions for production traffic.
        /// See [Versions and
        /// environments](https://cloud.google.com/dialogflow/cx/docs/concept/version).
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public virtual StreamingDetectIntentStream StreamingDetectIntent(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns preliminary intent match results, doesn't change the session
        /// status.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MatchIntentResponse MatchIntent(MatchIntentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns preliminary intent match results, doesn't change the session
        /// status.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MatchIntentResponse> MatchIntentAsync(MatchIntentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns preliminary intent match results, doesn't change the session
        /// status.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MatchIntentResponse> MatchIntentAsync(MatchIntentRequest request, st::CancellationToken cancellationToken) =>
            MatchIntentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fulfills a matched intent returned by
        /// [MatchIntent][google.cloud.dialogflow.cx.v3.Sessions.MatchIntent]. Must be
        /// called after
        /// [MatchIntent][google.cloud.dialogflow.cx.v3.Sessions.MatchIntent], with
        /// input from
        /// [MatchIntentResponse][google.cloud.dialogflow.cx.v3.MatchIntentResponse].
        /// Otherwise, the behavior is undefined.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FulfillIntentResponse FulfillIntent(FulfillIntentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fulfills a matched intent returned by
        /// [MatchIntent][google.cloud.dialogflow.cx.v3.Sessions.MatchIntent]. Must be
        /// called after
        /// [MatchIntent][google.cloud.dialogflow.cx.v3.Sessions.MatchIntent], with
        /// input from
        /// [MatchIntentResponse][google.cloud.dialogflow.cx.v3.MatchIntentResponse].
        /// Otherwise, the behavior is undefined.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FulfillIntentResponse> FulfillIntentAsync(FulfillIntentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fulfills a matched intent returned by
        /// [MatchIntent][google.cloud.dialogflow.cx.v3.Sessions.MatchIntent]. Must be
        /// called after
        /// [MatchIntent][google.cloud.dialogflow.cx.v3.Sessions.MatchIntent], with
        /// input from
        /// [MatchIntentResponse][google.cloud.dialogflow.cx.v3.MatchIntentResponse].
        /// Otherwise, the behavior is undefined.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FulfillIntentResponse> FulfillIntentAsync(FulfillIntentRequest request, st::CancellationToken cancellationToken) =>
            FulfillIntentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the feedback received from the user for a single turn of the bot
        /// response.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnswerFeedback SubmitAnswerFeedback(SubmitAnswerFeedbackRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the feedback received from the user for a single turn of the bot
        /// response.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnswerFeedback> SubmitAnswerFeedbackAsync(SubmitAnswerFeedbackRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the feedback received from the user for a single turn of the bot
        /// response.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnswerFeedback> SubmitAnswerFeedbackAsync(SubmitAnswerFeedbackRequest request, st::CancellationToken cancellationToken) =>
            SubmitAnswerFeedbackAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Sessions client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A session represents an interaction with a user. You retrieve user input
    /// and pass it to the
    /// [DetectIntent][google.cloud.dialogflow.cx.v3.Sessions.DetectIntent] method to
    /// determine user intent and respond.
    /// </remarks>
    public sealed partial class SessionsClientImpl : SessionsClient
    {
        private readonly gaxgrpc::ApiCall<DetectIntentRequest, DetectIntentResponse> _callDetectIntent;

        private readonly gaxgrpc::ApiServerStreamingCall<DetectIntentRequest, DetectIntentResponse> _callServerStreamingDetectIntent;

        private readonly gaxgrpc::ApiBidirectionalStreamingCall<StreamingDetectIntentRequest, StreamingDetectIntentResponse> _callStreamingDetectIntent;

        private readonly gaxgrpc::ApiCall<MatchIntentRequest, MatchIntentResponse> _callMatchIntent;

        private readonly gaxgrpc::ApiCall<FulfillIntentRequest, FulfillIntentResponse> _callFulfillIntent;

        private readonly gaxgrpc::ApiCall<SubmitAnswerFeedbackRequest, AnswerFeedback> _callSubmitAnswerFeedback;

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
            _callServerStreamingDetectIntent = clientHelper.BuildApiCall<DetectIntentRequest, DetectIntentResponse>("ServerStreamingDetectIntent", grpcClient.ServerStreamingDetectIntent, effectiveSettings.ServerStreamingDetectIntentSettings).WithGoogleRequestParam("session", request => request.Session);
            Modify_ApiCall(ref _callServerStreamingDetectIntent);
            Modify_ServerStreamingDetectIntentApiCall(ref _callServerStreamingDetectIntent);
            _callStreamingDetectIntent = clientHelper.BuildApiCall<StreamingDetectIntentRequest, StreamingDetectIntentResponse>("StreamingDetectIntent", grpcClient.StreamingDetectIntent, effectiveSettings.StreamingDetectIntentSettings, effectiveSettings.StreamingDetectIntentStreamingSettings);
            Modify_ApiCall(ref _callStreamingDetectIntent);
            Modify_StreamingDetectIntentApiCall(ref _callStreamingDetectIntent);
            _callMatchIntent = clientHelper.BuildApiCall<MatchIntentRequest, MatchIntentResponse>("MatchIntent", grpcClient.MatchIntentAsync, grpcClient.MatchIntent, effectiveSettings.MatchIntentSettings).WithGoogleRequestParam("session", request => request.Session);
            Modify_ApiCall(ref _callMatchIntent);
            Modify_MatchIntentApiCall(ref _callMatchIntent);
            _callFulfillIntent = clientHelper.BuildApiCall<FulfillIntentRequest, FulfillIntentResponse>("FulfillIntent", grpcClient.FulfillIntentAsync, grpcClient.FulfillIntent, effectiveSettings.FulfillIntentSettings).WithGoogleRequestParam("match_intent_request.session", request => request.MatchIntentRequest?.Session);
            Modify_ApiCall(ref _callFulfillIntent);
            Modify_FulfillIntentApiCall(ref _callFulfillIntent);
            _callSubmitAnswerFeedback = clientHelper.BuildApiCall<SubmitAnswerFeedbackRequest, AnswerFeedback>("SubmitAnswerFeedback", grpcClient.SubmitAnswerFeedbackAsync, grpcClient.SubmitAnswerFeedback, effectiveSettings.SubmitAnswerFeedbackSettings).WithGoogleRequestParam("session", request => request.Session);
            Modify_ApiCall(ref _callSubmitAnswerFeedback);
            Modify_SubmitAnswerFeedbackApiCall(ref _callSubmitAnswerFeedback);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiBidirectionalStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiServerStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_DetectIntentApiCall(ref gaxgrpc::ApiCall<DetectIntentRequest, DetectIntentResponse> call);

        partial void Modify_ServerStreamingDetectIntentApiCall(ref gaxgrpc::ApiServerStreamingCall<DetectIntentRequest, DetectIntentResponse> call);

        partial void Modify_StreamingDetectIntentApiCall(ref gaxgrpc::ApiBidirectionalStreamingCall<StreamingDetectIntentRequest, StreamingDetectIntentResponse> call);

        partial void Modify_MatchIntentApiCall(ref gaxgrpc::ApiCall<MatchIntentRequest, MatchIntentResponse> call);

        partial void Modify_FulfillIntentApiCall(ref gaxgrpc::ApiCall<FulfillIntentRequest, FulfillIntentResponse> call);

        partial void Modify_SubmitAnswerFeedbackApiCall(ref gaxgrpc::ApiCall<SubmitAnswerFeedbackRequest, AnswerFeedback> call);

        partial void OnConstruction(Sessions.SessionsClient grpcClient, SessionsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Sessions client</summary>
        public override Sessions.SessionsClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_DetectIntentRequest(ref DetectIntentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StreamingDetectIntentRequestCallSettings(ref gaxgrpc::CallSettings settings);

        partial void Modify_StreamingDetectIntentRequestRequest(ref StreamingDetectIntentRequest request);

        partial void Modify_MatchIntentRequest(ref MatchIntentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FulfillIntentRequest(ref FulfillIntentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SubmitAnswerFeedbackRequest(ref SubmitAnswerFeedbackRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Processes a natural language query and returns structured, actionable data
        /// as a result. This method is not idempotent, because it may cause session
        /// entity types to be updated, which in turn might affect results of future
        /// queries.
        /// 
        /// Note: Always use agent versions for production traffic.
        /// See [Versions and
        /// environments](https://cloud.google.com/dialogflow/cx/docs/concept/version).
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
        /// as a result. This method is not idempotent, because it may cause session
        /// entity types to be updated, which in turn might affect results of future
        /// queries.
        /// 
        /// Note: Always use agent versions for production traffic.
        /// See [Versions and
        /// environments](https://cloud.google.com/dialogflow/cx/docs/concept/version).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DetectIntentResponse> DetectIntentAsync(DetectIntentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DetectIntentRequest(ref request, ref callSettings);
            return _callDetectIntent.Async(request, callSettings);
        }

        internal sealed partial class ServerStreamingDetectIntentStreamImpl : ServerStreamingDetectIntentStream
        {
            /// <summary>Construct the server streaming method for <c>ServerStreamingDetectIntent</c>.</summary>
            /// <param name="call">The underlying gRPC server streaming call.</param>
            public ServerStreamingDetectIntentStreamImpl(grpccore::AsyncServerStreamingCall<DetectIntentResponse> call) => GrpcCall = call;

            public override grpccore::AsyncServerStreamingCall<DetectIntentResponse> GrpcCall { get; }
        }

        /// <summary>
        /// Processes a natural language query and returns structured, actionable data
        /// as a result through server-side streaming. Server-side streaming allows
        /// Dialogflow to send [partial
        /// responses](https://cloud.google.com/dialogflow/cx/docs/concept/fulfillment#partial-response)
        /// earlier in a single request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public override SessionsClient.ServerStreamingDetectIntentStream ServerStreamingDetectIntent(DetectIntentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DetectIntentRequest(ref request, ref callSettings);
            return new ServerStreamingDetectIntentStreamImpl(_callServerStreamingDetectIntent.Call(request, callSettings));
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
        /// Note: Always use agent versions for production traffic.
        /// See [Versions and
        /// environments](https://cloud.google.com/dialogflow/cx/docs/concept/version).
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

        /// <summary>
        /// Returns preliminary intent match results, doesn't change the session
        /// status.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MatchIntentResponse MatchIntent(MatchIntentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MatchIntentRequest(ref request, ref callSettings);
            return _callMatchIntent.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns preliminary intent match results, doesn't change the session
        /// status.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MatchIntentResponse> MatchIntentAsync(MatchIntentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MatchIntentRequest(ref request, ref callSettings);
            return _callMatchIntent.Async(request, callSettings);
        }

        /// <summary>
        /// Fulfills a matched intent returned by
        /// [MatchIntent][google.cloud.dialogflow.cx.v3.Sessions.MatchIntent]. Must be
        /// called after
        /// [MatchIntent][google.cloud.dialogflow.cx.v3.Sessions.MatchIntent], with
        /// input from
        /// [MatchIntentResponse][google.cloud.dialogflow.cx.v3.MatchIntentResponse].
        /// Otherwise, the behavior is undefined.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FulfillIntentResponse FulfillIntent(FulfillIntentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FulfillIntentRequest(ref request, ref callSettings);
            return _callFulfillIntent.Sync(request, callSettings);
        }

        /// <summary>
        /// Fulfills a matched intent returned by
        /// [MatchIntent][google.cloud.dialogflow.cx.v3.Sessions.MatchIntent]. Must be
        /// called after
        /// [MatchIntent][google.cloud.dialogflow.cx.v3.Sessions.MatchIntent], with
        /// input from
        /// [MatchIntentResponse][google.cloud.dialogflow.cx.v3.MatchIntentResponse].
        /// Otherwise, the behavior is undefined.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FulfillIntentResponse> FulfillIntentAsync(FulfillIntentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FulfillIntentRequest(ref request, ref callSettings);
            return _callFulfillIntent.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the feedback received from the user for a single turn of the bot
        /// response.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AnswerFeedback SubmitAnswerFeedback(SubmitAnswerFeedbackRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SubmitAnswerFeedbackRequest(ref request, ref callSettings);
            return _callSubmitAnswerFeedback.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the feedback received from the user for a single turn of the bot
        /// response.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AnswerFeedback> SubmitAnswerFeedbackAsync(SubmitAnswerFeedbackRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SubmitAnswerFeedbackRequest(ref request, ref callSettings);
            return _callSubmitAnswerFeedback.Async(request, callSettings);
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
