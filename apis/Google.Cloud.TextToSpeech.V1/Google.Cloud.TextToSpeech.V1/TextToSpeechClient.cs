// Copyright 2018 Google LLC
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

namespace Google.Cloud.TextToSpeech.V1
{
    /// <summary>
    /// Settings for a <see cref="TextToSpeechClient"/>.
    /// </summary>
    public sealed partial class TextToSpeechSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="TextToSpeechSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="TextToSpeechSettings"/>.
        /// </returns>
        public static TextToSpeechSettings GetDefault() => new TextToSpeechSettings();

        /// <summary>
        /// Constructs a new <see cref="TextToSpeechSettings"/> object with default settings.
        /// </summary>
        public TextToSpeechSettings() { }

        private TextToSpeechSettings(TextToSpeechSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListVoicesSettings = existing.ListVoicesSettings;
            SynthesizeSpeechSettings = existing.SynthesizeSpeechSettings;
            OnCopy(existing);
        }

        partial void OnCopy(TextToSpeechSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="TextToSpeechClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="TextToSpeechClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="TextToSpeechClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="TextToSpeechClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="TextToSpeechClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="TextToSpeechClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="TextToSpeechClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="TextToSpeechClient"/> RPC methods is defined as:
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
        /// <c>TextToSpeechClient.ListVoices</c> and <c>TextToSpeechClient.ListVoicesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>TextToSpeechClient.ListVoices</c> and
        /// <c>TextToSpeechClient.ListVoicesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListVoicesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TextToSpeechClient.SynthesizeSpeech</c> and <c>TextToSpeechClient.SynthesizeSpeechAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>TextToSpeechClient.SynthesizeSpeech</c> and
        /// <c>TextToSpeechClient.SynthesizeSpeechAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings SynthesizeSpeechSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="TextToSpeechSettings"/> object.</returns>
        public TextToSpeechSettings Clone() => new TextToSpeechSettings(this);
    }

    /// <summary>
    /// TextToSpeech client wrapper, for convenient use.
    /// </summary>
    public abstract partial class TextToSpeechClient
    {
        /// <summary>
        /// The default endpoint for the TextToSpeech service, which is a host of "texttospeech.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("texttospeech.googleapis.com", 443);

        /// <summary>
        /// The default TextToSpeech scopes.
        /// </summary>
        /// <remarks>
        /// The default TextToSpeech scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="TextToSpeechClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.TextToSpeech.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// TextToSpeechClient client = await TextToSpeechClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.TextToSpeech.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     TextToSpeechClient.DefaultEndpoint.Host, TextToSpeechClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// TextToSpeechClient client = TextToSpeechClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="TextToSpeechSettings"/>.</param>
        /// <returns>The task representing the created <see cref="TextToSpeechClient"/>.</returns>
        public static async stt::Task<TextToSpeechClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, TextToSpeechSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="TextToSpeechClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.TextToSpeech.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// TextToSpeechClient client = TextToSpeechClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.TextToSpeech.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     TextToSpeechClient.DefaultEndpoint.Host, TextToSpeechClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// TextToSpeechClient client = TextToSpeechClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="TextToSpeechSettings"/>.</param>
        /// <returns>The created <see cref="TextToSpeechClient"/>.</returns>
        public static TextToSpeechClient Create(gaxgrpc::ServiceEndpoint endpoint = null, TextToSpeechSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="TextToSpeechClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="TextToSpeechSettings"/>.</param>
        /// <returns>The created <see cref="TextToSpeechClient"/>.</returns>
        public static TextToSpeechClient Create(grpccore::Channel channel, TextToSpeechSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="TextToSpeechClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="TextToSpeechSettings"/>.</param>
        /// <returns>The created <see cref="TextToSpeechClient"/>.</returns>
        public static TextToSpeechClient Create(grpccore::CallInvoker callInvoker, TextToSpeechSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            TextToSpeech.TextToSpeechClient grpcClient = new TextToSpeech.TextToSpeechClient(callInvoker);
            return new TextToSpeechClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, TextToSpeechSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, TextToSpeechSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, TextToSpeechSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, TextToSpeechSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC TextToSpeech client.
        /// </summary>
        public virtual TextToSpeech.TextToSpeechClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Returns a list of [Voice][google.cloud.texttospeech.v1.Voice]
        /// supported for synthesis.
        /// </summary>
        /// <param name="languageCode">
        /// Optional (but recommended)
        /// [BCP-47](https://www.rfc-editor.org/rfc/bcp/bcp47.txt) language tag. If
        /// specified, the ListVoices call will only return voices that can be used to
        /// synthesize this language_code. E.g. when specifying "en-NZ", you will get
        /// supported "en-*" voices; when specifying "no", you will get supported
        /// "no-*" (Norwegian) and "nb-*" (Norwegian Bokmal) voices; specifying "zh"
        /// will also get supported "cmn-*" voices; specifying "zh-hk" will also get
        /// supported "yue-*" voices.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ListVoicesResponse> ListVoicesAsync(
            string languageCode,
            gaxgrpc::CallSettings callSettings = null) => ListVoicesAsync(
                new ListVoicesRequest
                {
                    LanguageCode = languageCode ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Returns a list of [Voice][google.cloud.texttospeech.v1.Voice]
        /// supported for synthesis.
        /// </summary>
        /// <param name="languageCode">
        /// Optional (but recommended)
        /// [BCP-47](https://www.rfc-editor.org/rfc/bcp/bcp47.txt) language tag. If
        /// specified, the ListVoices call will only return voices that can be used to
        /// synthesize this language_code. E.g. when specifying "en-NZ", you will get
        /// supported "en-*" voices; when specifying "no", you will get supported
        /// "no-*" (Norwegian) and "nb-*" (Norwegian Bokmal) voices; specifying "zh"
        /// will also get supported "cmn-*" voices; specifying "zh-hk" will also get
        /// supported "yue-*" voices.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ListVoicesResponse> ListVoicesAsync(
            string languageCode,
            st::CancellationToken cancellationToken) => ListVoicesAsync(
                languageCode,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a list of [Voice][google.cloud.texttospeech.v1.Voice]
        /// supported for synthesis.
        /// </summary>
        /// <param name="languageCode">
        /// Optional (but recommended)
        /// [BCP-47](https://www.rfc-editor.org/rfc/bcp/bcp47.txt) language tag. If
        /// specified, the ListVoices call will only return voices that can be used to
        /// synthesize this language_code. E.g. when specifying "en-NZ", you will get
        /// supported "en-*" voices; when specifying "no", you will get supported
        /// "no-*" (Norwegian) and "nb-*" (Norwegian Bokmal) voices; specifying "zh"
        /// will also get supported "cmn-*" voices; specifying "zh-hk" will also get
        /// supported "yue-*" voices.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ListVoicesResponse ListVoices(
            string languageCode,
            gaxgrpc::CallSettings callSettings = null) => ListVoices(
                new ListVoicesRequest
                {
                    LanguageCode = languageCode ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Returns a list of [Voice][google.cloud.texttospeech.v1.Voice]
        /// supported for synthesis.
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
        public virtual stt::Task<ListVoicesResponse> ListVoicesAsync(
            ListVoicesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns a list of [Voice][google.cloud.texttospeech.v1.Voice]
        /// supported for synthesis.
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
        public virtual stt::Task<ListVoicesResponse> ListVoicesAsync(
            ListVoicesRequest request,
            st::CancellationToken cancellationToken) => ListVoicesAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a list of [Voice][google.cloud.texttospeech.v1.Voice]
        /// supported for synthesis.
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
        public virtual ListVoicesResponse ListVoices(
            ListVoicesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

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
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<SynthesizeSpeechResponse> SynthesizeSpeechAsync(
            SynthesisInput input,
            VoiceSelectionParams voice,
            AudioConfig audioConfig,
            gaxgrpc::CallSettings callSettings = null) => SynthesizeSpeechAsync(
                new SynthesizeSpeechRequest
                {
                    Input = gax::GaxPreconditions.CheckNotNull(input, nameof(input)),
                    Voice = gax::GaxPreconditions.CheckNotNull(voice, nameof(voice)),
                    AudioConfig = gax::GaxPreconditions.CheckNotNull(audioConfig, nameof(audioConfig)),
                },
                callSettings);

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
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<SynthesizeSpeechResponse> SynthesizeSpeechAsync(
            SynthesisInput input,
            VoiceSelectionParams voice,
            AudioConfig audioConfig,
            st::CancellationToken cancellationToken) => SynthesizeSpeechAsync(
                input,
                voice,
                audioConfig,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual SynthesizeSpeechResponse SynthesizeSpeech(
            SynthesisInput input,
            VoiceSelectionParams voice,
            AudioConfig audioConfig,
            gaxgrpc::CallSettings callSettings = null) => SynthesizeSpeech(
                new SynthesizeSpeechRequest
                {
                    Input = gax::GaxPreconditions.CheckNotNull(input, nameof(input)),
                    Voice = gax::GaxPreconditions.CheckNotNull(voice, nameof(voice)),
                    AudioConfig = gax::GaxPreconditions.CheckNotNull(audioConfig, nameof(audioConfig)),
                },
                callSettings);

        /// <summary>
        /// Synthesizes speech synchronously: receive results after all text input
        /// has been processed.
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
        public virtual stt::Task<SynthesizeSpeechResponse> SynthesizeSpeechAsync(
            SynthesizeSpeechRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Synthesizes speech synchronously: receive results after all text input
        /// has been processed.
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
        public virtual stt::Task<SynthesizeSpeechResponse> SynthesizeSpeechAsync(
            SynthesizeSpeechRequest request,
            st::CancellationToken cancellationToken) => SynthesizeSpeechAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Synthesizes speech synchronously: receive results after all text input
        /// has been processed.
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
        public virtual SynthesizeSpeechResponse SynthesizeSpeech(
            SynthesizeSpeechRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// TextToSpeech client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class TextToSpeechClientImpl : TextToSpeechClient
    {
        private readonly gaxgrpc::ApiCall<ListVoicesRequest, ListVoicesResponse> _callListVoices;
        private readonly gaxgrpc::ApiCall<SynthesizeSpeechRequest, SynthesizeSpeechResponse> _callSynthesizeSpeech;

        /// <summary>
        /// Constructs a client wrapper for the TextToSpeech service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="TextToSpeechSettings"/> used within this client </param>
        public TextToSpeechClientImpl(TextToSpeech.TextToSpeechClient grpcClient, TextToSpeechSettings settings)
        {
            GrpcClient = grpcClient;
            TextToSpeechSettings effectiveSettings = settings ?? TextToSpeechSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callListVoices = clientHelper.BuildApiCall<ListVoicesRequest, ListVoicesResponse>(
                GrpcClient.ListVoicesAsync, GrpcClient.ListVoices, effectiveSettings.ListVoicesSettings);
            _callSynthesizeSpeech = clientHelper.BuildApiCall<SynthesizeSpeechRequest, SynthesizeSpeechResponse>(
                GrpcClient.SynthesizeSpeechAsync, GrpcClient.SynthesizeSpeech, effectiveSettings.SynthesizeSpeechSettings);
            Modify_ApiCall(ref _callListVoices);
            Modify_ListVoicesApiCall(ref _callListVoices);
            Modify_ApiCall(ref _callSynthesizeSpeech);
            Modify_SynthesizeSpeechApiCall(ref _callSynthesizeSpeech);
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
        partial void Modify_ListVoicesApiCall(ref gaxgrpc::ApiCall<ListVoicesRequest, ListVoicesResponse> call);
        partial void Modify_SynthesizeSpeechApiCall(ref gaxgrpc::ApiCall<SynthesizeSpeechRequest, SynthesizeSpeechResponse> call);
        partial void OnConstruction(TextToSpeech.TextToSpeechClient grpcClient, TextToSpeechSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC TextToSpeech client.
        /// </summary>
        public override TextToSpeech.TextToSpeechClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_ListVoicesRequest(ref ListVoicesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_SynthesizeSpeechRequest(ref SynthesizeSpeechRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns a list of [Voice][google.cloud.texttospeech.v1.Voice]
        /// supported for synthesis.
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
        public override stt::Task<ListVoicesResponse> ListVoicesAsync(
            ListVoicesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVoicesRequest(ref request, ref callSettings);
            return _callListVoices.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a list of [Voice][google.cloud.texttospeech.v1.Voice]
        /// supported for synthesis.
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
        public override ListVoicesResponse ListVoices(
            ListVoicesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVoicesRequest(ref request, ref callSettings);
            return _callListVoices.Sync(request, callSettings);
        }

        /// <summary>
        /// Synthesizes speech synchronously: receive results after all text input
        /// has been processed.
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
        public override stt::Task<SynthesizeSpeechResponse> SynthesizeSpeechAsync(
            SynthesizeSpeechRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SynthesizeSpeechRequest(ref request, ref callSettings);
            return _callSynthesizeSpeech.Async(request, callSettings);
        }

        /// <summary>
        /// Synthesizes speech synchronously: receive results after all text input
        /// has been processed.
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
        public override SynthesizeSpeechResponse SynthesizeSpeech(
            SynthesizeSpeechRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SynthesizeSpeechRequest(ref request, ref callSettings);
            return _callSynthesizeSpeech.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}
