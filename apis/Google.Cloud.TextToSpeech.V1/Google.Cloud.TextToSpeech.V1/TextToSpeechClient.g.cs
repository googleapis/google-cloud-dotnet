// Copyright 2021 Google LLC
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
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.TextToSpeech.V1
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
        public TextToSpeechClientBuilder()
        {
            UseJwtAccessWithScopes = TextToSpeechClient.UseJwtAccessWithScopes;
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
            return TextToSpeechClient.Create(callInvoker, Settings);
        }

        private async stt::Task<TextToSpeechClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return TextToSpeechClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => TextToSpeechClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => TextToSpeechClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => TextToSpeechClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
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

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes, UseJwtAccessWithScopes);

        internal static bool UseJwtAccessWithScopes
        {
            get
            {
                bool useJwtAccessWithScopes = true;
                MaybeUseJwtAccessWithScopes(ref useJwtAccessWithScopes);
                return useJwtAccessWithScopes;
            }
        }

        static partial void MaybeUseJwtAccessWithScopes(ref bool useJwtAccessWithScopes);

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
        /// <returns>The created <see cref="TextToSpeechClient"/>.</returns>
        internal static TextToSpeechClient Create(grpccore::CallInvoker callInvoker, TextToSpeechSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            TextToSpeech.TextToSpeechClient grpcClient = new TextToSpeech.TextToSpeechClient(callInvoker);
            return new TextToSpeechClientImpl(grpcClient, settings);
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
        /// [BCP-47](https://www.rfc-editor.org/rfc/bcp/bcp47.txt) language tag. If
        /// specified, the ListVoices call will only return voices that can be used to
        /// synthesize this language_code. E.g. when specifying `"en-NZ"`, you will get
        /// supported `"en-\*"` voices; when specifying `"no"`, you will get supported
        /// `"no-\*"` (Norwegian) and `"nb-\*"` (Norwegian Bokmal) voices; specifying
        /// `"zh"` will also get supported `"cmn-\*"` voices; specifying `"zh-hk"` will
        /// also get supported `"yue-\*"` voices.
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
        /// [BCP-47](https://www.rfc-editor.org/rfc/bcp/bcp47.txt) language tag. If
        /// specified, the ListVoices call will only return voices that can be used to
        /// synthesize this language_code. E.g. when specifying `"en-NZ"`, you will get
        /// supported `"en-\*"` voices; when specifying `"no"`, you will get supported
        /// `"no-\*"` (Norwegian) and `"nb-\*"` (Norwegian Bokmal) voices; specifying
        /// `"zh"` will also get supported `"cmn-\*"` voices; specifying `"zh-hk"` will
        /// also get supported `"yue-\*"` voices.
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
        /// [BCP-47](https://www.rfc-editor.org/rfc/bcp/bcp47.txt) language tag. If
        /// specified, the ListVoices call will only return voices that can be used to
        /// synthesize this language_code. E.g. when specifying `"en-NZ"`, you will get
        /// supported `"en-\*"` voices; when specifying `"no"`, you will get supported
        /// `"no-\*"` (Norwegian) and `"nb-\*"` (Norwegian Bokmal) voices; specifying
        /// `"zh"` will also get supported `"cmn-\*"` voices; specifying `"zh-hk"` will
        /// also get supported `"yue-\*"` voices.
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
    }

    /// <summary>TextToSpeech client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service that implements Google Cloud Text-to-Speech API.
    /// </remarks>
    public sealed partial class TextToSpeechClientImpl : TextToSpeechClient
    {
        private readonly gaxgrpc::ApiCall<ListVoicesRequest, ListVoicesResponse> _callListVoices;

        private readonly gaxgrpc::ApiCall<SynthesizeSpeechRequest, SynthesizeSpeechResponse> _callSynthesizeSpeech;

        /// <summary>
        /// Constructs a client wrapper for the TextToSpeech service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="TextToSpeechSettings"/> used within this client.</param>
        public TextToSpeechClientImpl(TextToSpeech.TextToSpeechClient grpcClient, TextToSpeechSettings settings)
        {
            GrpcClient = grpcClient;
            TextToSpeechSettings effectiveSettings = settings ?? TextToSpeechSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callListVoices = clientHelper.BuildApiCall<ListVoicesRequest, ListVoicesResponse>(grpcClient.ListVoicesAsync, grpcClient.ListVoices, effectiveSettings.ListVoicesSettings);
            Modify_ApiCall(ref _callListVoices);
            Modify_ListVoicesApiCall(ref _callListVoices);
            _callSynthesizeSpeech = clientHelper.BuildApiCall<SynthesizeSpeechRequest, SynthesizeSpeechResponse>(grpcClient.SynthesizeSpeechAsync, grpcClient.SynthesizeSpeech, effectiveSettings.SynthesizeSpeechSettings);
            Modify_ApiCall(ref _callSynthesizeSpeech);
            Modify_SynthesizeSpeechApiCall(ref _callSynthesizeSpeech);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListVoicesApiCall(ref gaxgrpc::ApiCall<ListVoicesRequest, ListVoicesResponse> call);

        partial void Modify_SynthesizeSpeechApiCall(ref gaxgrpc::ApiCall<SynthesizeSpeechRequest, SynthesizeSpeechResponse> call);

        partial void OnConstruction(TextToSpeech.TextToSpeechClient grpcClient, TextToSpeechSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC TextToSpeech client</summary>
        public override TextToSpeech.TextToSpeechClient GrpcClient { get; }

        partial void Modify_ListVoicesRequest(ref ListVoicesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SynthesizeSpeechRequest(ref SynthesizeSpeechRequest request, ref gaxgrpc::CallSettings settings);

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
    }
}
