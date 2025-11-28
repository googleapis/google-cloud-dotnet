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

namespace Google.Cloud.TextToSpeech.V1Beta1
{
    /// <summary>Settings for <see cref="TextToSpeechClient"/> instances.</summary>
    public sealed partial class TextToSpeechSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="TextToSpeechSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="TextToSpeechSettings"/>.</returns>
        public static TextToSpeechSettings GetDefault() => new TextToSpeechSettings();

        /// <summary>Constructs a new <see cref="TextToSpeechSettings"/> object with default settings.</summary>
        public TextToSpeechSettings()
        {
        }

        private TextToSpeechSettings(TextToSpeechSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListVoicesSettings = existing.ListVoicesSettings;
            SynthesizeSpeechSettings = existing.SynthesizeSpeechSettings;
            StreamingSynthesizeSettings = existing.StreamingSynthesizeSettings;
            StreamingSynthesizeStreamingSettings = existing.StreamingSynthesizeStreamingSettings;
            OnCopy(existing);
        }

        partial void OnCopy(TextToSpeechSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TextToSpeechClient.ListVoices</c> and <c>TextToSpeechClient.ListVoicesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListVoicesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TextToSpeechClient.SynthesizeSpeech</c> and <c>TextToSpeechClient.SynthesizeSpeechAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SynthesizeSpeechSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TextToSpeechClient.StreamingSynthesize</c> and <c>TextToSpeechClient.StreamingSynthesizeAsync</c>.
        /// </summary>
        /// <remarks>Timeout: 300 seconds.</remarks>
        public gaxgrpc::CallSettings StreamingSynthesizeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// <see cref="gaxgrpc::BidirectionalStreamingSettings"/> for calls to <c>TextToSpeechClient.StreamingSynthesize</c>
        ///  and <c>TextToSpeechClient.StreamingSynthesizeAsync</c>.
        /// </summary>
        /// <remarks>The default local send queue size is 100.</remarks>
        public gaxgrpc::BidirectionalStreamingSettings StreamingSynthesizeStreamingSettings { get; set; } = new gaxgrpc::BidirectionalStreamingSettings(100);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="TextToSpeechSettings"/> object.</returns>
        public TextToSpeechSettings Clone() => new TextToSpeechSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="TextToSpeechClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class TextToSpeechClientBuilder : gaxgrpc::ClientBuilderBase<TextToSpeechClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public TextToSpeechSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public TextToSpeechClientBuilder() : base(TextToSpeechClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref TextToSpeechClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<TextToSpeechClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override TextToSpeechClient Build()
        {
            TextToSpeechClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<TextToSpeechClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<TextToSpeechClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private TextToSpeechClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return TextToSpeechClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<TextToSpeechClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return TextToSpeechClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => TextToSpeechClient.ChannelPool;
    }

    /// <summary>TextToSpeech client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service that implements Google Cloud Text-to-Speech API.
    /// </remarks>
    public abstract partial class TextToSpeechClient
    {
        /// <summary>
        /// The default endpoint for the TextToSpeech service, which is a host of "texttospeech.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "texttospeech.googleapis.com:443";

        /// <summary>The default TextToSpeech scopes.</summary>
        /// <remarks>
        /// The default TextToSpeech scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(TextToSpeech.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="TextToSpeechClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TextToSpeechClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="TextToSpeechClient"/>.</returns>
        public static stt::Task<TextToSpeechClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new TextToSpeechClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="TextToSpeechClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TextToSpeechClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="TextToSpeechClient"/>.</returns>
        public static TextToSpeechClient Create() => new TextToSpeechClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="TextToSpeechClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="TextToSpeechSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="TextToSpeechClient"/>.</returns>
        internal static TextToSpeechClient Create(grpccore::CallInvoker callInvoker, TextToSpeechSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            TextToSpeech.TextToSpeechClient grpcClient = new TextToSpeech.TextToSpeechClient(callInvoker);
            return new TextToSpeechClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC TextToSpeech client</summary>
        public virtual TextToSpeech.TextToSpeechClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of Voice supported for synthesis.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListVoicesResponse ListVoices(ListVoicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of Voice supported for synthesis.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListVoicesResponse> ListVoicesAsync(ListVoicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of Voice supported for synthesis.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListVoicesResponse> ListVoicesAsync(ListVoicesRequest request, st::CancellationToken cancellationToken) =>
            ListVoicesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a list of Voice supported for synthesis.
        /// </summary>
        /// <param name="languageCode">
        /// Optional. Recommended.
        /// [BCP-47](https://www.rfc-editor.org/rfc/bcp/bcp47.txt) language tag.
        /// If not specified, the API will return all supported voices.
        /// If specified, the ListVoices call will only return voices that can be used
        /// to synthesize this language_code. For example, if you specify `"en-NZ"`,
        /// all `"en-NZ"` voices will be returned. If you specify `"no"`, both
        /// `"no-\*"` (Norwegian) and `"nb-\*"` (Norwegian Bokmal) voices will be
        /// returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListVoicesResponse ListVoices(string languageCode, gaxgrpc::CallSettings callSettings = null) =>
            ListVoices(new ListVoicesRequest
            {
                LanguageCode = languageCode ?? "",
            }, callSettings);

        /// <summary>
        /// Returns a list of Voice supported for synthesis.
        /// </summary>
        /// <param name="languageCode">
        /// Optional. Recommended.
        /// [BCP-47](https://www.rfc-editor.org/rfc/bcp/bcp47.txt) language tag.
        /// If not specified, the API will return all supported voices.
        /// If specified, the ListVoices call will only return voices that can be used
        /// to synthesize this language_code. For example, if you specify `"en-NZ"`,
        /// all `"en-NZ"` voices will be returned. If you specify `"no"`, both
        /// `"no-\*"` (Norwegian) and `"nb-\*"` (Norwegian Bokmal) voices will be
        /// returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListVoicesResponse> ListVoicesAsync(string languageCode, gaxgrpc::CallSettings callSettings = null) =>
            ListVoicesAsync(new ListVoicesRequest
            {
                LanguageCode = languageCode ?? "",
            }, callSettings);

        /// <summary>
        /// Returns a list of Voice supported for synthesis.
        /// </summary>
        /// <param name="languageCode">
        /// Optional. Recommended.
        /// [BCP-47](https://www.rfc-editor.org/rfc/bcp/bcp47.txt) language tag.
        /// If not specified, the API will return all supported voices.
        /// If specified, the ListVoices call will only return voices that can be used
        /// to synthesize this language_code. For example, if you specify `"en-NZ"`,
        /// all `"en-NZ"` voices will be returned. If you specify `"no"`, both
        /// `"no-\*"` (Norwegian) and `"nb-\*"` (Norwegian Bokmal) voices will be
        /// returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListVoicesResponse> ListVoicesAsync(string languageCode, st::CancellationToken cancellationToken) =>
            ListVoicesAsync(languageCode, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Synthesizes speech synchronously: receive results after all text input
        /// has been processed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SynthesizeSpeechResponse SynthesizeSpeech(SynthesizeSpeechRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Synthesizes speech synchronously: receive results after all text input
        /// has been processed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SynthesizeSpeechResponse> SynthesizeSpeechAsync(SynthesizeSpeechRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Synthesizes speech synchronously: receive results after all text input
        /// has been processed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SynthesizeSpeechResponse> SynthesizeSpeechAsync(SynthesizeSpeechRequest request, st::CancellationToken cancellationToken) =>
            SynthesizeSpeechAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Synthesizes speech synchronously: receive results after all text input
        /// has been processed.
        /// </summary>
        /// <param name="input">
        /// Required. The Synthesizer requires either plain text or SSML as input.
        /// </param>
        /// <param name="voice">
        /// Required. The desired voice of the synthesized audio.
        /// </param>
        /// <param name="audioConfig">
        /// Required. The configuration of the synthesized audio.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SynthesizeSpeechResponse SynthesizeSpeech(SynthesisInput input, VoiceSelectionParams voice, AudioConfig audioConfig, gaxgrpc::CallSettings callSettings = null) =>
            SynthesizeSpeech(new SynthesizeSpeechRequest
            {
                Input = gax::GaxPreconditions.CheckNotNull(input, nameof(input)),
                Voice = gax::GaxPreconditions.CheckNotNull(voice, nameof(voice)),
                AudioConfig = gax::GaxPreconditions.CheckNotNull(audioConfig, nameof(audioConfig)),
            }, callSettings);

        /// <summary>
        /// Synthesizes speech synchronously: receive results after all text input
        /// has been processed.
        /// </summary>
        /// <param name="input">
        /// Required. The Synthesizer requires either plain text or SSML as input.
        /// </param>
        /// <param name="voice">
        /// Required. The desired voice of the synthesized audio.
        /// </param>
        /// <param name="audioConfig">
        /// Required. The configuration of the synthesized audio.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SynthesizeSpeechResponse> SynthesizeSpeechAsync(SynthesisInput input, VoiceSelectionParams voice, AudioConfig audioConfig, gaxgrpc::CallSettings callSettings = null) =>
            SynthesizeSpeechAsync(new SynthesizeSpeechRequest
            {
                Input = gax::GaxPreconditions.CheckNotNull(input, nameof(input)),
                Voice = gax::GaxPreconditions.CheckNotNull(voice, nameof(voice)),
                AudioConfig = gax::GaxPreconditions.CheckNotNull(audioConfig, nameof(audioConfig)),
            }, callSettings);

        /// <summary>
        /// Synthesizes speech synchronously: receive results after all text input
        /// has been processed.
        /// </summary>
        /// <param name="input">
        /// Required. The Synthesizer requires either plain text or SSML as input.
        /// </param>
        /// <param name="voice">
        /// Required. The desired voice of the synthesized audio.
        /// </param>
        /// <param name="audioConfig">
        /// Required. The configuration of the synthesized audio.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SynthesizeSpeechResponse> SynthesizeSpeechAsync(SynthesisInput input, VoiceSelectionParams voice, AudioConfig audioConfig, st::CancellationToken cancellationToken) =>
            SynthesizeSpeechAsync(input, voice, audioConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Bidirectional streaming methods for
        /// <see cref="StreamingSynthesize(gaxgrpc::CallSettings,gaxgrpc::BidirectionalStreamingSettings)"/>.
        /// </summary>
        public abstract partial class StreamingSynthesizeStream : gaxgrpc::BidirectionalStreamingBase<StreamingSynthesizeRequest, StreamingSynthesizeResponse>
        {
        }

        /// <summary>
        /// Performs bidirectional streaming speech synthesis: receives audio while
        /// sending text.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public virtual StreamingSynthesizeStream StreamingSynthesize(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null) =>
            throw new sys::NotImplementedException();
    }

    /// <summary>TextToSpeech client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service that implements Google Cloud Text-to-Speech API.
    /// </remarks>
    public sealed partial class TextToSpeechClientImpl : TextToSpeechClient
    {
        private readonly gaxgrpc::ApiCall<ListVoicesRequest, ListVoicesResponse> _callListVoices;

        private readonly gaxgrpc::ApiCall<SynthesizeSpeechRequest, SynthesizeSpeechResponse> _callSynthesizeSpeech;

        private readonly gaxgrpc::ApiBidirectionalStreamingCall<StreamingSynthesizeRequest, StreamingSynthesizeResponse> _callStreamingSynthesize;

        /// <summary>
        /// Constructs a client wrapper for the TextToSpeech service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="TextToSpeechSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public TextToSpeechClientImpl(TextToSpeech.TextToSpeechClient grpcClient, TextToSpeechSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            TextToSpeechSettings effectiveSettings = settings ?? TextToSpeechSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callListVoices = clientHelper.BuildApiCall<ListVoicesRequest, ListVoicesResponse>("ListVoices", grpcClient.ListVoicesAsync, grpcClient.ListVoices, effectiveSettings.ListVoicesSettings);
            Modify_ApiCall(ref _callListVoices);
            Modify_ListVoicesApiCall(ref _callListVoices);
            _callSynthesizeSpeech = clientHelper.BuildApiCall<SynthesizeSpeechRequest, SynthesizeSpeechResponse>("SynthesizeSpeech", grpcClient.SynthesizeSpeechAsync, grpcClient.SynthesizeSpeech, effectiveSettings.SynthesizeSpeechSettings);
            Modify_ApiCall(ref _callSynthesizeSpeech);
            Modify_SynthesizeSpeechApiCall(ref _callSynthesizeSpeech);
            _callStreamingSynthesize = clientHelper.BuildApiCall<StreamingSynthesizeRequest, StreamingSynthesizeResponse>("StreamingSynthesize", grpcClient.StreamingSynthesize, effectiveSettings.StreamingSynthesizeSettings, effectiveSettings.StreamingSynthesizeStreamingSettings);
            Modify_ApiCall(ref _callStreamingSynthesize);
            Modify_StreamingSynthesizeApiCall(ref _callStreamingSynthesize);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiBidirectionalStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListVoicesApiCall(ref gaxgrpc::ApiCall<ListVoicesRequest, ListVoicesResponse> call);

        partial void Modify_SynthesizeSpeechApiCall(ref gaxgrpc::ApiCall<SynthesizeSpeechRequest, SynthesizeSpeechResponse> call);

        partial void Modify_StreamingSynthesizeApiCall(ref gaxgrpc::ApiBidirectionalStreamingCall<StreamingSynthesizeRequest, StreamingSynthesizeResponse> call);

        partial void OnConstruction(TextToSpeech.TextToSpeechClient grpcClient, TextToSpeechSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC TextToSpeech client</summary>
        public override TextToSpeech.TextToSpeechClient GrpcClient { get; }

        partial void Modify_ListVoicesRequest(ref ListVoicesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SynthesizeSpeechRequest(ref SynthesizeSpeechRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StreamingSynthesizeRequestCallSettings(ref gaxgrpc::CallSettings settings);

        partial void Modify_StreamingSynthesizeRequestRequest(ref StreamingSynthesizeRequest request);

        /// <summary>
        /// Returns a list of Voice supported for synthesis.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListVoicesResponse ListVoices(ListVoicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVoicesRequest(ref request, ref callSettings);
            return _callListVoices.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a list of Voice supported for synthesis.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListVoicesResponse> ListVoicesAsync(ListVoicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVoicesRequest(ref request, ref callSettings);
            return _callListVoices.Async(request, callSettings);
        }

        /// <summary>
        /// Synthesizes speech synchronously: receive results after all text input
        /// has been processed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SynthesizeSpeechResponse SynthesizeSpeech(SynthesizeSpeechRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SynthesizeSpeechRequest(ref request, ref callSettings);
            return _callSynthesizeSpeech.Sync(request, callSettings);
        }

        /// <summary>
        /// Synthesizes speech synchronously: receive results after all text input
        /// has been processed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SynthesizeSpeechResponse> SynthesizeSpeechAsync(SynthesizeSpeechRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SynthesizeSpeechRequest(ref request, ref callSettings);
            return _callSynthesizeSpeech.Async(request, callSettings);
        }

        internal sealed partial class StreamingSynthesizeStreamImpl : StreamingSynthesizeStream
        {
            /// <summary>Construct the bidirectional streaming method for <c>StreamingSynthesize</c>.</summary>
            /// <param name="service">The service containing this streaming method.</param>
            /// <param name="call">The underlying gRPC duplex streaming call.</param>
            /// <param name="writeBuffer">
            /// The <see cref="gaxgrpc::BufferedClientStreamWriter{StreamingSynthesizeRequest}"/> instance associated
            /// with this streaming call.
            /// </param>
            public StreamingSynthesizeStreamImpl(TextToSpeechClientImpl service, grpccore::AsyncDuplexStreamingCall<StreamingSynthesizeRequest, StreamingSynthesizeResponse> call, gaxgrpc::BufferedClientStreamWriter<StreamingSynthesizeRequest> writeBuffer)
            {
                _service = service;
                GrpcCall = call;
                _writeBuffer = writeBuffer;
            }

            private TextToSpeechClientImpl _service;

            private gaxgrpc::BufferedClientStreamWriter<StreamingSynthesizeRequest> _writeBuffer;

            public override grpccore::AsyncDuplexStreamingCall<StreamingSynthesizeRequest, StreamingSynthesizeResponse> GrpcCall { get; }

            private StreamingSynthesizeRequest ModifyRequest(StreamingSynthesizeRequest request)
            {
                _service.Modify_StreamingSynthesizeRequestRequest(ref request);
                return request;
            }

            public override stt::Task TryWriteAsync(StreamingSynthesizeRequest message) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message));

            public override stt::Task WriteAsync(StreamingSynthesizeRequest message) =>
                _writeBuffer.WriteAsync(ModifyRequest(message));

            public override stt::Task TryWriteAsync(StreamingSynthesizeRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message), options);

            public override stt::Task WriteAsync(StreamingSynthesizeRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.WriteAsync(ModifyRequest(message), options);

            public override stt::Task TryWriteCompleteAsync() => _writeBuffer.TryWriteCompleteAsync();

            public override stt::Task WriteCompleteAsync() => _writeBuffer.WriteCompleteAsync();
        }

        /// <summary>
        /// Performs bidirectional streaming speech synthesis: receives audio while
        /// sending text.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public override TextToSpeechClient.StreamingSynthesizeStream StreamingSynthesize(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null)
        {
            Modify_StreamingSynthesizeRequestCallSettings(ref callSettings);
            gaxgrpc::BidirectionalStreamingSettings effectiveStreamingSettings = streamingSettings ?? _callStreamingSynthesize.StreamingSettings;
            grpccore::AsyncDuplexStreamingCall<StreamingSynthesizeRequest, StreamingSynthesizeResponse> call = _callStreamingSynthesize.Call(callSettings);
            gaxgrpc::BufferedClientStreamWriter<StreamingSynthesizeRequest> writeBuffer = new gaxgrpc::BufferedClientStreamWriter<StreamingSynthesizeRequest>(call.RequestStream, effectiveStreamingSettings.BufferedClientWriterCapacity);
            return new StreamingSynthesizeStreamImpl(this, call, writeBuffer);
        }
    }
}
