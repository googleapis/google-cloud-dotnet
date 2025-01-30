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
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.MediaTranslation.V1Beta1
{
    /// <summary>Settings for <see cref="SpeechTranslationServiceClient"/> instances.</summary>
    public sealed partial class SpeechTranslationServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SpeechTranslationServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SpeechTranslationServiceSettings"/>.</returns>
        public static SpeechTranslationServiceSettings GetDefault() => new SpeechTranslationServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="SpeechTranslationServiceSettings"/> object with default settings.
        /// </summary>
        public SpeechTranslationServiceSettings()
        {
        }

        private SpeechTranslationServiceSettings(SpeechTranslationServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            StreamingTranslateSpeechSettings = existing.StreamingTranslateSpeechSettings;
            StreamingTranslateSpeechStreamingSettings = existing.StreamingTranslateSpeechStreamingSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SpeechTranslationServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpeechTranslationServiceClient.StreamingTranslateSpeech</c> and
        /// <c>SpeechTranslationServiceClient.StreamingTranslateSpeechAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 400 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StreamingTranslateSpeechSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(400000)));

        /// <summary>
        /// <see cref="gaxgrpc::BidirectionalStreamingSettings"/> for calls to
        /// <c>SpeechTranslationServiceClient.StreamingTranslateSpeech</c> and
        /// <c>SpeechTranslationServiceClient.StreamingTranslateSpeechAsync</c>.
        /// </summary>
        /// <remarks>The default local send queue size is 100.</remarks>
        public gaxgrpc::BidirectionalStreamingSettings StreamingTranslateSpeechStreamingSettings { get; set; } = new gaxgrpc::BidirectionalStreamingSettings(100);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SpeechTranslationServiceSettings"/> object.</returns>
        public SpeechTranslationServiceSettings Clone() => new SpeechTranslationServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SpeechTranslationServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class SpeechTranslationServiceClientBuilder : gaxgrpc::ClientBuilderBase<SpeechTranslationServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SpeechTranslationServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SpeechTranslationServiceClientBuilder() : base(SpeechTranslationServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SpeechTranslationServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SpeechTranslationServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SpeechTranslationServiceClient Build()
        {
            SpeechTranslationServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SpeechTranslationServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SpeechTranslationServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SpeechTranslationServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SpeechTranslationServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SpeechTranslationServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SpeechTranslationServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SpeechTranslationServiceClient.ChannelPool;
    }

    /// <summary>SpeechTranslationService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides translation from/to media types.
    /// </remarks>
    public abstract partial class SpeechTranslationServiceClient
    {
        /// <summary>
        /// The default endpoint for the SpeechTranslationService service, which is a host of
        /// "mediatranslation.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "mediatranslation.googleapis.com:443";

        /// <summary>The default SpeechTranslationService scopes.</summary>
        /// <remarks>
        /// The default SpeechTranslationService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(SpeechTranslationService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SpeechTranslationServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="SpeechTranslationServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SpeechTranslationServiceClient"/>.</returns>
        public static stt::Task<SpeechTranslationServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SpeechTranslationServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SpeechTranslationServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="SpeechTranslationServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SpeechTranslationServiceClient"/>.</returns>
        public static SpeechTranslationServiceClient Create() => new SpeechTranslationServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SpeechTranslationServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SpeechTranslationServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SpeechTranslationServiceClient"/>.</returns>
        internal static SpeechTranslationServiceClient Create(grpccore::CallInvoker callInvoker, SpeechTranslationServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SpeechTranslationService.SpeechTranslationServiceClient grpcClient = new SpeechTranslationService.SpeechTranslationServiceClient(callInvoker);
            return new SpeechTranslationServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC SpeechTranslationService client</summary>
        public virtual SpeechTranslationService.SpeechTranslationServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Bidirectional streaming methods for
        /// <see cref="StreamingTranslateSpeech(gaxgrpc::CallSettings,gaxgrpc::BidirectionalStreamingSettings)"/>.
        /// </summary>
        public abstract partial class StreamingTranslateSpeechStream : gaxgrpc::BidirectionalStreamingBase<StreamingTranslateSpeechRequest, StreamingTranslateSpeechResponse>
        {
        }

        /// <summary>
        /// Performs bidirectional streaming speech translation: receive results while
        /// sending audio. This method is only available via the gRPC API (not REST).
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public virtual StreamingTranslateSpeechStream StreamingTranslateSpeech(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null) =>
            throw new sys::NotImplementedException();
    }

    /// <summary>SpeechTranslationService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides translation from/to media types.
    /// </remarks>
    public sealed partial class SpeechTranslationServiceClientImpl : SpeechTranslationServiceClient
    {
        private readonly gaxgrpc::ApiBidirectionalStreamingCall<StreamingTranslateSpeechRequest, StreamingTranslateSpeechResponse> _callStreamingTranslateSpeech;

        /// <summary>
        /// Constructs a client wrapper for the SpeechTranslationService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="SpeechTranslationServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SpeechTranslationServiceClientImpl(SpeechTranslationService.SpeechTranslationServiceClient grpcClient, SpeechTranslationServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SpeechTranslationServiceSettings effectiveSettings = settings ?? SpeechTranslationServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callStreamingTranslateSpeech = clientHelper.BuildApiCall<StreamingTranslateSpeechRequest, StreamingTranslateSpeechResponse>("StreamingTranslateSpeech", grpcClient.StreamingTranslateSpeech, effectiveSettings.StreamingTranslateSpeechSettings, effectiveSettings.StreamingTranslateSpeechStreamingSettings);
            Modify_ApiCall(ref _callStreamingTranslateSpeech);
            Modify_StreamingTranslateSpeechApiCall(ref _callStreamingTranslateSpeech);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiBidirectionalStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_StreamingTranslateSpeechApiCall(ref gaxgrpc::ApiBidirectionalStreamingCall<StreamingTranslateSpeechRequest, StreamingTranslateSpeechResponse> call);

        partial void OnConstruction(SpeechTranslationService.SpeechTranslationServiceClient grpcClient, SpeechTranslationServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SpeechTranslationService client</summary>
        public override SpeechTranslationService.SpeechTranslationServiceClient GrpcClient { get; }

        partial void Modify_StreamingTranslateSpeechRequestCallSettings(ref gaxgrpc::CallSettings settings);

        partial void Modify_StreamingTranslateSpeechRequestRequest(ref StreamingTranslateSpeechRequest request);

        internal sealed partial class StreamingTranslateSpeechStreamImpl : StreamingTranslateSpeechStream
        {
            /// <summary>Construct the bidirectional streaming method for <c>StreamingTranslateSpeech</c>.</summary>
            /// <param name="service">The service containing this streaming method.</param>
            /// <param name="call">The underlying gRPC duplex streaming call.</param>
            /// <param name="writeBuffer">
            /// The <see cref="gaxgrpc::BufferedClientStreamWriter{StreamingTranslateSpeechRequest}"/> instance
            /// associated with this streaming call.
            /// </param>
            public StreamingTranslateSpeechStreamImpl(SpeechTranslationServiceClientImpl service, grpccore::AsyncDuplexStreamingCall<StreamingTranslateSpeechRequest, StreamingTranslateSpeechResponse> call, gaxgrpc::BufferedClientStreamWriter<StreamingTranslateSpeechRequest> writeBuffer)
            {
                _service = service;
                GrpcCall = call;
                _writeBuffer = writeBuffer;
            }

            private SpeechTranslationServiceClientImpl _service;

            private gaxgrpc::BufferedClientStreamWriter<StreamingTranslateSpeechRequest> _writeBuffer;

            public override grpccore::AsyncDuplexStreamingCall<StreamingTranslateSpeechRequest, StreamingTranslateSpeechResponse> GrpcCall { get; }

            private StreamingTranslateSpeechRequest ModifyRequest(StreamingTranslateSpeechRequest request)
            {
                _service.Modify_StreamingTranslateSpeechRequestRequest(ref request);
                return request;
            }

            public override stt::Task TryWriteAsync(StreamingTranslateSpeechRequest message) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message));

            public override stt::Task WriteAsync(StreamingTranslateSpeechRequest message) =>
                _writeBuffer.WriteAsync(ModifyRequest(message));

            public override stt::Task TryWriteAsync(StreamingTranslateSpeechRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message), options);

            public override stt::Task WriteAsync(StreamingTranslateSpeechRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.WriteAsync(ModifyRequest(message), options);

            public override stt::Task TryWriteCompleteAsync() => _writeBuffer.TryWriteCompleteAsync();

            public override stt::Task WriteCompleteAsync() => _writeBuffer.WriteCompleteAsync();
        }

        /// <summary>
        /// Performs bidirectional streaming speech translation: receive results while
        /// sending audio. This method is only available via the gRPC API (not REST).
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public override SpeechTranslationServiceClient.StreamingTranslateSpeechStream StreamingTranslateSpeech(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null)
        {
            Modify_StreamingTranslateSpeechRequestCallSettings(ref callSettings);
            gaxgrpc::BidirectionalStreamingSettings effectiveStreamingSettings = streamingSettings ?? _callStreamingTranslateSpeech.StreamingSettings;
            grpccore::AsyncDuplexStreamingCall<StreamingTranslateSpeechRequest, StreamingTranslateSpeechResponse> call = _callStreamingTranslateSpeech.Call(callSettings);
            gaxgrpc::BufferedClientStreamWriter<StreamingTranslateSpeechRequest> writeBuffer = new gaxgrpc::BufferedClientStreamWriter<StreamingTranslateSpeechRequest>(call.RequestStream, effectiveStreamingSettings.BufferedClientWriterCapacity);
            return new StreamingTranslateSpeechStreamImpl(this, call, writeBuffer);
        }
    }
}
