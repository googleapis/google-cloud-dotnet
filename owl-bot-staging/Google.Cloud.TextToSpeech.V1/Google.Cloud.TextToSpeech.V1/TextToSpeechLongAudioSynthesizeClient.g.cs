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
using lro = Google.LongRunning;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.TextToSpeech.V1
{
    /// <summary>Settings for <see cref="TextToSpeechLongAudioSynthesizeClient"/> instances.</summary>
    public sealed partial class TextToSpeechLongAudioSynthesizeSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="TextToSpeechLongAudioSynthesizeSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="TextToSpeechLongAudioSynthesizeSettings"/>.</returns>
        public static TextToSpeechLongAudioSynthesizeSettings GetDefault() => new TextToSpeechLongAudioSynthesizeSettings();

        /// <summary>
        /// Constructs a new <see cref="TextToSpeechLongAudioSynthesizeSettings"/> object with default settings.
        /// </summary>
        public TextToSpeechLongAudioSynthesizeSettings()
        {
        }

        private TextToSpeechLongAudioSynthesizeSettings(TextToSpeechLongAudioSynthesizeSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            SynthesizeLongAudioSettings = existing.SynthesizeLongAudioSettings;
            SynthesizeLongAudioOperationsSettings = existing.SynthesizeLongAudioOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(TextToSpeechLongAudioSynthesizeSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TextToSpeechLongAudioSynthesizeClient.SynthesizeLongAudio</c> and
        /// <c>TextToSpeechLongAudioSynthesizeClient.SynthesizeLongAudioAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5000 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SynthesizeLongAudioSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TextToSpeechLongAudioSynthesizeClient.SynthesizeLongAudio</c>
        ///  and <c>TextToSpeechLongAudioSynthesizeClient.SynthesizeLongAudioAsync</c>.
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
        public lro::OperationsSettings SynthesizeLongAudioOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="TextToSpeechLongAudioSynthesizeSettings"/> object.</returns>
        public TextToSpeechLongAudioSynthesizeSettings Clone() => new TextToSpeechLongAudioSynthesizeSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="TextToSpeechLongAudioSynthesizeClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class TextToSpeechLongAudioSynthesizeClientBuilder : gaxgrpc::ClientBuilderBase<TextToSpeechLongAudioSynthesizeClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public TextToSpeechLongAudioSynthesizeSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public TextToSpeechLongAudioSynthesizeClientBuilder() : base(TextToSpeechLongAudioSynthesizeClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref TextToSpeechLongAudioSynthesizeClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<TextToSpeechLongAudioSynthesizeClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override TextToSpeechLongAudioSynthesizeClient Build()
        {
            TextToSpeechLongAudioSynthesizeClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<TextToSpeechLongAudioSynthesizeClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<TextToSpeechLongAudioSynthesizeClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private TextToSpeechLongAudioSynthesizeClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return TextToSpeechLongAudioSynthesizeClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<TextToSpeechLongAudioSynthesizeClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return TextToSpeechLongAudioSynthesizeClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => TextToSpeechLongAudioSynthesizeClient.ChannelPool;
    }

    /// <summary>TextToSpeechLongAudioSynthesize client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service that implements Google Cloud Text-to-Speech API.
    /// </remarks>
    public abstract partial class TextToSpeechLongAudioSynthesizeClient
    {
        /// <summary>
        /// The default endpoint for the TextToSpeechLongAudioSynthesize service, which is a host of
        /// "texttospeech.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "texttospeech.googleapis.com:443";

        /// <summary>The default TextToSpeechLongAudioSynthesize scopes.</summary>
        /// <remarks>
        /// The default TextToSpeechLongAudioSynthesize scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(TextToSpeechLongAudioSynthesize.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="TextToSpeechLongAudioSynthesizeClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="TextToSpeechLongAudioSynthesizeClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="TextToSpeechLongAudioSynthesizeClient"/>.</returns>
        public static stt::Task<TextToSpeechLongAudioSynthesizeClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new TextToSpeechLongAudioSynthesizeClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="TextToSpeechLongAudioSynthesizeClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="TextToSpeechLongAudioSynthesizeClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="TextToSpeechLongAudioSynthesizeClient"/>.</returns>
        public static TextToSpeechLongAudioSynthesizeClient Create() =>
            new TextToSpeechLongAudioSynthesizeClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="TextToSpeechLongAudioSynthesizeClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="TextToSpeechLongAudioSynthesizeSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="TextToSpeechLongAudioSynthesizeClient"/>.</returns>
        internal static TextToSpeechLongAudioSynthesizeClient Create(grpccore::CallInvoker callInvoker, TextToSpeechLongAudioSynthesizeSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            TextToSpeechLongAudioSynthesize.TextToSpeechLongAudioSynthesizeClient grpcClient = new TextToSpeechLongAudioSynthesize.TextToSpeechLongAudioSynthesizeClient(callInvoker);
            return new TextToSpeechLongAudioSynthesizeClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC TextToSpeechLongAudioSynthesize client</summary>
        public virtual TextToSpeechLongAudioSynthesize.TextToSpeechLongAudioSynthesizeClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Synthesizes long form text asynchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SynthesizeLongAudioResponse, SynthesizeLongAudioMetadata> SynthesizeLongAudio(SynthesizeLongAudioRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Synthesizes long form text asynchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SynthesizeLongAudioResponse, SynthesizeLongAudioMetadata>> SynthesizeLongAudioAsync(SynthesizeLongAudioRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Synthesizes long form text asynchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SynthesizeLongAudioResponse, SynthesizeLongAudioMetadata>> SynthesizeLongAudioAsync(SynthesizeLongAudioRequest request, st::CancellationToken cancellationToken) =>
            SynthesizeLongAudioAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SynthesizeLongAudio</c>.</summary>
        public virtual lro::OperationsClient SynthesizeLongAudioOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SynthesizeLongAudio</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<SynthesizeLongAudioResponse, SynthesizeLongAudioMetadata> PollOnceSynthesizeLongAudio(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<SynthesizeLongAudioResponse, SynthesizeLongAudioMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SynthesizeLongAudioOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SynthesizeLongAudio</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<SynthesizeLongAudioResponse, SynthesizeLongAudioMetadata>> PollOnceSynthesizeLongAudioAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<SynthesizeLongAudioResponse, SynthesizeLongAudioMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SynthesizeLongAudioOperationsClient, callSettings);
    }

    /// <summary>TextToSpeechLongAudioSynthesize client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service that implements Google Cloud Text-to-Speech API.
    /// </remarks>
    public sealed partial class TextToSpeechLongAudioSynthesizeClientImpl : TextToSpeechLongAudioSynthesizeClient
    {
        private readonly gaxgrpc::ApiCall<SynthesizeLongAudioRequest, lro::Operation> _callSynthesizeLongAudio;

        /// <summary>
        /// Constructs a client wrapper for the TextToSpeechLongAudioSynthesize service, with the specified gRPC client
        /// and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="TextToSpeechLongAudioSynthesizeSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public TextToSpeechLongAudioSynthesizeClientImpl(TextToSpeechLongAudioSynthesize.TextToSpeechLongAudioSynthesizeClient grpcClient, TextToSpeechLongAudioSynthesizeSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            TextToSpeechLongAudioSynthesizeSettings effectiveSettings = settings ?? TextToSpeechLongAudioSynthesizeSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            SynthesizeLongAudioOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.SynthesizeLongAudioOperationsSettings, logger);
            _callSynthesizeLongAudio = clientHelper.BuildApiCall<SynthesizeLongAudioRequest, lro::Operation>("SynthesizeLongAudio", grpcClient.SynthesizeLongAudioAsync, grpcClient.SynthesizeLongAudio, effectiveSettings.SynthesizeLongAudioSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callSynthesizeLongAudio);
            Modify_SynthesizeLongAudioApiCall(ref _callSynthesizeLongAudio);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_SynthesizeLongAudioApiCall(ref gaxgrpc::ApiCall<SynthesizeLongAudioRequest, lro::Operation> call);

        partial void OnConstruction(TextToSpeechLongAudioSynthesize.TextToSpeechLongAudioSynthesizeClient grpcClient, TextToSpeechLongAudioSynthesizeSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC TextToSpeechLongAudioSynthesize client</summary>
        public override TextToSpeechLongAudioSynthesize.TextToSpeechLongAudioSynthesizeClient GrpcClient { get; }

        partial void Modify_SynthesizeLongAudioRequest(ref SynthesizeLongAudioRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>SynthesizeLongAudio</c>.</summary>
        public override lro::OperationsClient SynthesizeLongAudioOperationsClient { get; }

        /// <summary>
        /// Synthesizes long form text asynchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<SynthesizeLongAudioResponse, SynthesizeLongAudioMetadata> SynthesizeLongAudio(SynthesizeLongAudioRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SynthesizeLongAudioRequest(ref request, ref callSettings);
            return new lro::Operation<SynthesizeLongAudioResponse, SynthesizeLongAudioMetadata>(_callSynthesizeLongAudio.Sync(request, callSettings), SynthesizeLongAudioOperationsClient);
        }

        /// <summary>
        /// Synthesizes long form text asynchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<SynthesizeLongAudioResponse, SynthesizeLongAudioMetadata>> SynthesizeLongAudioAsync(SynthesizeLongAudioRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SynthesizeLongAudioRequest(ref request, ref callSettings);
            return new lro::Operation<SynthesizeLongAudioResponse, SynthesizeLongAudioMetadata>(await _callSynthesizeLongAudio.Async(request, callSettings).ConfigureAwait(false), SynthesizeLongAudioOperationsClient);
        }
    }

    public static partial class TextToSpeechLongAudioSynthesize
    {
        public partial class TextToSpeechLongAudioSynthesizeClient
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
}
