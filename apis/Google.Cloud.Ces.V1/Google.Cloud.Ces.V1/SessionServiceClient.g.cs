// Copyright 2026 Google LLC
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

namespace Google.Cloud.Ces.V1
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
            RunSessionSettings = existing.RunSessionSettings;
            BidiRunSessionSettings = existing.BidiRunSessionSettings;
            BidiRunSessionStreamingSettings = existing.BidiRunSessionStreamingSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SessionServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SessionServiceClient.RunSession</c> and <c>SessionServiceClient.RunSessionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>No status codes are retried.</description></item>
        /// <item><description>Timeout: 220 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RunSessionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(220000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes()));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SessionServiceClient.BidiRunSession</c> and <c>SessionServiceClient.BidiRunSessionAsync</c>.
        /// </summary>
        /// <remarks>Timeout: 3600 seconds.</remarks>
        public gaxgrpc::CallSettings BidiRunSessionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)));

        /// <summary>
        /// <see cref="gaxgrpc::BidirectionalStreamingSettings"/> for calls to <c>SessionServiceClient.BidiRunSession</c>
        ///  and <c>SessionServiceClient.BidiRunSessionAsync</c>.
        /// </summary>
        /// <remarks>The default local send queue size is 100.</remarks>
        public gaxgrpc::BidirectionalStreamingSettings BidiRunSessionStreamingSettings { get; set; } = new gaxgrpc::BidirectionalStreamingSettings(100);

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
    /// Session service provides APIs for interacting with CES agents.
    /// </remarks>
    public abstract partial class SessionServiceClient
    {
        /// <summary>
        /// The default endpoint for the SessionService service, which is a host of "ces.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "ces.googleapis.com:443";

        /// <summary>The default SessionService scopes.</summary>
        /// <remarks>
        /// The default SessionService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/ces</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/ces",
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
        /// Initiates a single turn interaction with the CES agent within a
        /// session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RunSessionResponse RunSession(RunSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Initiates a single turn interaction with the CES agent within a
        /// session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunSessionResponse> RunSessionAsync(RunSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Initiates a single turn interaction with the CES agent within a
        /// session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunSessionResponse> RunSessionAsync(RunSessionRequest request, st::CancellationToken cancellationToken) =>
            RunSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Bidirectional streaming methods for
        /// <see cref="BidiRunSession(gaxgrpc::CallSettings,gaxgrpc::BidirectionalStreamingSettings)"/>.
        /// </summary>
        public abstract partial class BidiRunSessionStream : gaxgrpc::BidirectionalStreamingBase<BidiSessionClientMessage, BidiSessionServerMessage>
        {
        }

        /// <summary>
        /// Establishes a bidirectional streaming connection with the CES agent.
        /// The agent processes continuous multimodal inputs (e.g., text, audio) and
        /// generates real-time multimodal output streams.
        /// 
        /// --- Client Request Stream ---
        /// The client streams requests in the following order:
        /// 
        /// 1.  Initialization:
        /// The first message must contain
        /// [SessionConfig][google.cloud.ces.v1.BidiSessionClientMessage.config].
        /// For audio sessions, this should also include
        /// [InputAudioConfig][google.cloud.ces.v1.SessionConfig.input_audio_config]
        /// and
        /// [OutputAudioConfig][google.cloud.ces.v1.SessionConfig.output_audio_config]
        /// to define audio processing and synthesis parameters.
        /// 
        /// 2.  Interaction:
        /// Subsequent messages stream
        /// [SessionInput][google.cloud.ces.v1.BidiSessionClientMessage.realtime_input]
        /// containing real-time user input data.
        /// 
        /// 3.  Termination:
        /// The client should half-close the stream when there is no more user
        /// input. It should also half-close upon receiving
        /// [EndSession][google.cloud.ces.v1.BidiSessionServerMessage.end_session]
        /// or [GoAway][google.cloud.ces.v1.BidiSessionServerMessage.go_away] from
        /// the agent.
        /// 
        /// --- Server Response Stream ---
        /// For each interaction turn, the agent streams messages in the following
        /// sequence:
        /// 
        /// 1.  Speech Recognition (First N messages):
        /// Contains
        /// [RecognitionResult][google.cloud.ces.v1.BidiSessionServerMessage.recognition_result]
        /// representing the concatenated user speech segments captured so far.
        /// This is only populated for audio sessions.
        /// 
        /// 2.  Response (Next M messages):
        /// Contains
        /// [SessionOutput][google.cloud.ces.v1.BidiSessionServerMessage.session_output]
        /// delivering the agent's response in various modalities (e.g., text,
        /// audio).
        /// 
        /// 3.  Turn Completion (Final message of the turn):
        /// Contains
        /// [SessionOutput][google.cloud.ces.v1.BidiSessionServerMessage.session_output]
        /// with [turn_completed][google.cloud.ces.v1.SessionOutput.turn_completed]
        /// set to true. This signals the end of the current turn and includes
        /// [DiagnosticInfo][google.cloud.ces.v1.SessionOutput.diagnostic_info]
        /// with execution details.
        /// 
        /// --- Audio Best Practices ---
        /// 1.  Streaming:
        /// Stream [audio data][google.cloud.ces.v1.SessionInput.audio]
        /// **CONTINUOUSLY**, even during silence. Recommended chunk size: 40-120ms
        /// (balances latency vs. efficiency).
        /// 
        /// 2.  Playback &amp; Interruption:
        /// Play [audio responses][google.cloud.ces.v1.SessionOutput.audio] upon
        /// receipt. Stop playback immediately if an
        /// [InterruptionSignal][google.cloud.ces.v1.BidiSessionServerMessage.interruption_signal]
        /// is received (e.g., user barge-in or new agent response).
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public virtual BidiRunSessionStream BidiRunSession(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null) =>
            throw new sys::NotImplementedException();
    }

    /// <summary>SessionService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Session service provides APIs for interacting with CES agents.
    /// </remarks>
    public sealed partial class SessionServiceClientImpl : SessionServiceClient
    {
        private readonly gaxgrpc::ApiCall<RunSessionRequest, RunSessionResponse> _callRunSession;

        private readonly gaxgrpc::ApiBidirectionalStreamingCall<BidiSessionClientMessage, BidiSessionServerMessage> _callBidiRunSession;

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
            _callRunSession = clientHelper.BuildApiCall<RunSessionRequest, RunSessionResponse>("RunSession", grpcClient.RunSessionAsync, grpcClient.RunSession, effectiveSettings.RunSessionSettings).WithGoogleRequestParam("config.session", request => request.Config?.Session);
            Modify_ApiCall(ref _callRunSession);
            Modify_RunSessionApiCall(ref _callRunSession);
            _callBidiRunSession = clientHelper.BuildApiCall<BidiSessionClientMessage, BidiSessionServerMessage>("BidiRunSession", grpcClient.BidiRunSession, effectiveSettings.BidiRunSessionSettings, effectiveSettings.BidiRunSessionStreamingSettings);
            Modify_ApiCall(ref _callBidiRunSession);
            Modify_BidiRunSessionApiCall(ref _callBidiRunSession);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiBidirectionalStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_RunSessionApiCall(ref gaxgrpc::ApiCall<RunSessionRequest, RunSessionResponse> call);

        partial void Modify_BidiRunSessionApiCall(ref gaxgrpc::ApiBidirectionalStreamingCall<BidiSessionClientMessage, BidiSessionServerMessage> call);

        partial void OnConstruction(SessionService.SessionServiceClient grpcClient, SessionServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SessionService client</summary>
        public override SessionService.SessionServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_RunSessionRequest(ref RunSessionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BidiSessionClientMessageCallSettings(ref gaxgrpc::CallSettings settings);

        partial void Modify_BidiSessionClientMessageRequest(ref BidiSessionClientMessage request);

        /// <summary>
        /// Initiates a single turn interaction with the CES agent within a
        /// session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RunSessionResponse RunSession(RunSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunSessionRequest(ref request, ref callSettings);
            return _callRunSession.Sync(request, callSettings);
        }

        /// <summary>
        /// Initiates a single turn interaction with the CES agent within a
        /// session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RunSessionResponse> RunSessionAsync(RunSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunSessionRequest(ref request, ref callSettings);
            return _callRunSession.Async(request, callSettings);
        }

        internal sealed partial class BidiRunSessionStreamImpl : BidiRunSessionStream
        {
            /// <summary>Construct the bidirectional streaming method for <c>BidiRunSession</c>.</summary>
            /// <param name="service">The service containing this streaming method.</param>
            /// <param name="call">The underlying gRPC duplex streaming call.</param>
            /// <param name="writeBuffer">
            /// The <see cref="gaxgrpc::BufferedClientStreamWriter{BidiSessionClientMessage}"/> instance associated with
            /// this streaming call.
            /// </param>
            public BidiRunSessionStreamImpl(SessionServiceClientImpl service, grpccore::AsyncDuplexStreamingCall<BidiSessionClientMessage, BidiSessionServerMessage> call, gaxgrpc::BufferedClientStreamWriter<BidiSessionClientMessage> writeBuffer)
            {
                _service = service;
                GrpcCall = call;
                _writeBuffer = writeBuffer;
            }

            private SessionServiceClientImpl _service;

            private gaxgrpc::BufferedClientStreamWriter<BidiSessionClientMessage> _writeBuffer;

            public override grpccore::AsyncDuplexStreamingCall<BidiSessionClientMessage, BidiSessionServerMessage> GrpcCall { get; }

            private BidiSessionClientMessage ModifyRequest(BidiSessionClientMessage request)
            {
                _service.Modify_BidiSessionClientMessageRequest(ref request);
                return request;
            }

            public override stt::Task TryWriteAsync(BidiSessionClientMessage message) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message));

            public override stt::Task WriteAsync(BidiSessionClientMessage message) =>
                _writeBuffer.WriteAsync(ModifyRequest(message));

            public override stt::Task TryWriteAsync(BidiSessionClientMessage message, grpccore::WriteOptions options) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message), options);

            public override stt::Task WriteAsync(BidiSessionClientMessage message, grpccore::WriteOptions options) =>
                _writeBuffer.WriteAsync(ModifyRequest(message), options);

            public override stt::Task TryWriteCompleteAsync() => _writeBuffer.TryWriteCompleteAsync();

            public override stt::Task WriteCompleteAsync() => _writeBuffer.WriteCompleteAsync();
        }

        /// <summary>
        /// Establishes a bidirectional streaming connection with the CES agent.
        /// The agent processes continuous multimodal inputs (e.g., text, audio) and
        /// generates real-time multimodal output streams.
        /// 
        /// --- Client Request Stream ---
        /// The client streams requests in the following order:
        /// 
        /// 1.  Initialization:
        /// The first message must contain
        /// [SessionConfig][google.cloud.ces.v1.BidiSessionClientMessage.config].
        /// For audio sessions, this should also include
        /// [InputAudioConfig][google.cloud.ces.v1.SessionConfig.input_audio_config]
        /// and
        /// [OutputAudioConfig][google.cloud.ces.v1.SessionConfig.output_audio_config]
        /// to define audio processing and synthesis parameters.
        /// 
        /// 2.  Interaction:
        /// Subsequent messages stream
        /// [SessionInput][google.cloud.ces.v1.BidiSessionClientMessage.realtime_input]
        /// containing real-time user input data.
        /// 
        /// 3.  Termination:
        /// The client should half-close the stream when there is no more user
        /// input. It should also half-close upon receiving
        /// [EndSession][google.cloud.ces.v1.BidiSessionServerMessage.end_session]
        /// or [GoAway][google.cloud.ces.v1.BidiSessionServerMessage.go_away] from
        /// the agent.
        /// 
        /// --- Server Response Stream ---
        /// For each interaction turn, the agent streams messages in the following
        /// sequence:
        /// 
        /// 1.  Speech Recognition (First N messages):
        /// Contains
        /// [RecognitionResult][google.cloud.ces.v1.BidiSessionServerMessage.recognition_result]
        /// representing the concatenated user speech segments captured so far.
        /// This is only populated for audio sessions.
        /// 
        /// 2.  Response (Next M messages):
        /// Contains
        /// [SessionOutput][google.cloud.ces.v1.BidiSessionServerMessage.session_output]
        /// delivering the agent's response in various modalities (e.g., text,
        /// audio).
        /// 
        /// 3.  Turn Completion (Final message of the turn):
        /// Contains
        /// [SessionOutput][google.cloud.ces.v1.BidiSessionServerMessage.session_output]
        /// with [turn_completed][google.cloud.ces.v1.SessionOutput.turn_completed]
        /// set to true. This signals the end of the current turn and includes
        /// [DiagnosticInfo][google.cloud.ces.v1.SessionOutput.diagnostic_info]
        /// with execution details.
        /// 
        /// --- Audio Best Practices ---
        /// 1.  Streaming:
        /// Stream [audio data][google.cloud.ces.v1.SessionInput.audio]
        /// **CONTINUOUSLY**, even during silence. Recommended chunk size: 40-120ms
        /// (balances latency vs. efficiency).
        /// 
        /// 2.  Playback &amp; Interruption:
        /// Play [audio responses][google.cloud.ces.v1.SessionOutput.audio] upon
        /// receipt. Stop playback immediately if an
        /// [InterruptionSignal][google.cloud.ces.v1.BidiSessionServerMessage.interruption_signal]
        /// is received (e.g., user barge-in or new agent response).
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public override SessionServiceClient.BidiRunSessionStream BidiRunSession(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null)
        {
            Modify_BidiSessionClientMessageCallSettings(ref callSettings);
            gaxgrpc::BidirectionalStreamingSettings effectiveStreamingSettings = streamingSettings ?? _callBidiRunSession.StreamingSettings;
            grpccore::AsyncDuplexStreamingCall<BidiSessionClientMessage, BidiSessionServerMessage> call = _callBidiRunSession.Call(callSettings);
            gaxgrpc::BufferedClientStreamWriter<BidiSessionClientMessage> writeBuffer = new gaxgrpc::BufferedClientStreamWriter<BidiSessionClientMessage>(call.RequestStream, effectiveStreamingSettings.BufferedClientWriterCapacity);
            return new BidiRunSessionStreamImpl(this, call, writeBuffer);
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
        }
    }
}
