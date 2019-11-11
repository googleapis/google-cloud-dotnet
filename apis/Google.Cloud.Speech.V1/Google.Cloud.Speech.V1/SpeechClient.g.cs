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
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Speech.V1
{
    /// <summary>Settings for <see cref="SpeechClient"/> instances.</summary>
    public sealed partial class SpeechSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SpeechSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SpeechSettings"/>.</returns>
        public static SpeechSettings GetDefault() => new SpeechSettings();

        /// <summary>Constructs a new <see cref="SpeechSettings"/> object with default settings.</summary>
        public SpeechSettings()
        {
        }

        private SpeechSettings(SpeechSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            RecognizeSettings = existing.RecognizeSettings;
            LongRunningRecognizeSettings = existing.LongRunningRecognizeSettings;
            LongRunningRecognizeOperationsSettings = existing.LongRunningRecognizeOperationsSettings.Clone();
            StreamingRecognizeSettings = existing.StreamingRecognizeSettings;
            StreamingRecognizeStreamingSettings = existing.StreamingRecognizeStreamingSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SpeechSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>SpeechClient.Recognize</c>
        /// and <c>SpeechClient.RecognizeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.29999995231628</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Initial timeout: 5000000 milliseconds.</description></item>
        /// <item><description>Timeout multiplier: 1</description></item>
        /// <item><description>Timeout maximum delay: 5000000 milliseconds.</description></item>
        /// <item><description>Total timeout: 5000 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RecognizeSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(retryBackoff: new gaxgrpc::BackoffSettings(delay: sys::TimeSpan.FromMilliseconds(100), maxDelay: sys::TimeSpan.FromMilliseconds(60000), delayMultiplier: 1.2999999523162842), timeoutBackoff: new gaxgrpc::BackoffSettings(delay: sys::TimeSpan.FromMilliseconds(5000000), maxDelay: sys::TimeSpan.FromMilliseconds(5000000), delayMultiplier: 1), totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000000)), retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded))));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpeechClient.LongRunningRecognize</c> and <c>SpeechClient.LongRunningRecognizeAsync</c>.
        /// </summary>
        /// <remarks>By default, retry will not be attempted.</remarks>
        public gaxgrpc::CallSettings LongRunningRecognizeSettings { get; set; }

        /// <summary>
        /// Long Running Operation settings for calls to <c>SpeechClient.LongRunningRecognize</c> and
        /// <c>SpeechClient.LongRunningRecognizeAsync</c>.
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
        public lro::OperationsSettings LongRunningRecognizeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpeechClient.StreamingRecognize</c> and <c>SpeechClient.StreamingRecognizeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.29999995231628</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Initial timeout: 5000000 milliseconds.</description></item>
        /// <item><description>Timeout multiplier: 1</description></item>
        /// <item><description>Timeout maximum delay: 5000000 milliseconds.</description></item>
        /// <item><description>Total timeout: 5000 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StreamingRecognizeSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(retryBackoff: new gaxgrpc::BackoffSettings(delay: sys::TimeSpan.FromMilliseconds(100), maxDelay: sys::TimeSpan.FromMilliseconds(60000), delayMultiplier: 1.2999999523162842), timeoutBackoff: new gaxgrpc::BackoffSettings(delay: sys::TimeSpan.FromMilliseconds(5000000), maxDelay: sys::TimeSpan.FromMilliseconds(5000000), delayMultiplier: 1), totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000000)), retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded))));

        /// <summary>
        /// <see cref="gaxgrpc::BidirectionalStreamingSettings"/> for calls to <c>SpeechClient.StreamingRecognize</c>
        /// and <c>SpeechClient.StreamingRecognizeAsync</c>.
        /// </summary>
        /// <remarks>The default local send queue size is 100.</remarks>
        public gaxgrpc::BidirectionalStreamingSettings StreamingRecognizeStreamingSettings { get; set; } = new gaxgrpc::BidirectionalStreamingSettings(100);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SpeechSettings"/> object.</returns>
        public SpeechSettings Clone() => new SpeechSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SpeechClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class SpeechClientBuilder : gaxgrpc::ClientBuilderBase<SpeechClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SpeechSettings Settings { get; set; }

        /// <inheritdoc/>
        public override SpeechClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SpeechClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc/>
        public override async stt::Task<SpeechClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SpeechClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc/>
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => SpeechClient.DefaultEndpoint;

        /// <inheritdoc/>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => SpeechClient.DefaultScopes;

        /// <inheritdoc/>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SpeechClient.ChannelPool;
    }

    /// <summary>Speech client wrapper, for convenient use.</summary>
    public abstract partial class SpeechClient
    {
        /// <summary>
        /// The default endpoint for the Speech service, which is a host of "speech.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("speech.googleapis.com", 443);

        /// <summary>The default Speech scopes.</summary>
        /// <remarks>
        /// The default Speech scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="SpeechClient"/>, applying defaults for all unspecified settings, and
        /// creating a channel connecting to the given endpoint with application default credentials where necessary.
        /// See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ImageAnnotatorClient client = await ImageAnnotatorClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ImageAnnotatorClient.DefaultEndpoint.Host, ImageAnnotatorClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ImageAnnotatorClient client = ImageAnnotatorClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="SpeechSettings"/>.</param>
        /// <returns>The task representing the created <see cref="SpeechClient"/>.</returns>
        public static async stt::Task<SpeechClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, SpeechSettings settings = null)
        {
            grpccore::Channel channel = await ChannelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="SpeechClient"/>, applying defaults for all unspecified settings, and
        /// creating a channel connecting to the given endpoint with application default credentials where necessary.
        /// See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ImageAnnotatorClient client = ImageAnnotatorClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ImageAnnotatorClient.DefaultEndpoint.Host, ImageAnnotatorClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ImageAnnotatorClient client = ImageAnnotatorClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="SpeechSettings"/>.</param>
        /// <returns>The created <see cref="SpeechClient"/>.</returns>
        public static SpeechClient Create(gaxgrpc::ServiceEndpoint endpoint = null, SpeechSettings settings = null)
        {
            grpccore::Channel channel = ChannelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="SpeechClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="SpeechSettings"/>.</param>
        /// <returns>The created <see cref="SpeechClient"/>.</returns>
        public static SpeechClient Create(grpccore::Channel channel, SpeechSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="SpeechClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SpeechSettings"/>.</param>
        /// <returns>The created <see cref="SpeechClient"/>.</returns>
        public static SpeechClient Create(grpccore::CallInvoker callInvoker, SpeechSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Speech.SpeechClient grpcClient = new Speech.SpeechClient(callInvoker);
            return new SpeechClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(grpccore::CallInvoker,SpeechSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint,SpeechSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create(grpccore::CallInvoker,SpeechSettings)"/> and
        /// <see cref="CreateAsync(gaxgrpc::ServiceEndpoint,SpeechSettings)"/> will create new channels, which could in
        /// turn be shut down by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC Speech client</summary>
        public virtual Speech.SpeechClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Performs synchronous speech recognition: receive results after all audio
        /// has been sent and processed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RecognizeResponse Recognize(RecognizeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Performs synchronous speech recognition: receive results after all audio
        /// has been sent and processed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RecognizeResponse> RecognizeAsync(RecognizeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Performs synchronous speech recognition: receive results after all audio
        /// has been sent and processed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RecognizeResponse> RecognizeAsync(RecognizeRequest request, st::CancellationToken cancellationToken) =>
            RecognizeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Performs synchronous speech recognition: receive results after all audio
        /// has been sent and processed.
        /// </summary>
        /// <param name="config">
        /// Required. Provides information to the recognizer that specifies how to
        /// process the request.
        /// </param>
        /// <param name="audio">
        /// Required. The audio data to be recognized.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RecognizeResponse Recognize(RecognitionConfig config, RecognitionAudio audio, gaxgrpc::CallSettings callSettings = null) =>
            Recognize(new RecognizeRequest
            {
                Config = gax::GaxPreconditions.CheckNotNull(config, nameof(config)),
                Audio = gax::GaxPreconditions.CheckNotNull(audio, nameof(audio)),
            }, callSettings);

        /// <summary>
        /// Performs synchronous speech recognition: receive results after all audio
        /// has been sent and processed.
        /// </summary>
        /// <param name="config">
        /// Required. Provides information to the recognizer that specifies how to
        /// process the request.
        /// </param>
        /// <param name="audio">
        /// Required. The audio data to be recognized.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RecognizeResponse> RecognizeAsync(RecognitionConfig config, RecognitionAudio audio, gaxgrpc::CallSettings callSettings = null) =>
            RecognizeAsync(new RecognizeRequest
            {
                Config = gax::GaxPreconditions.CheckNotNull(config, nameof(config)),
                Audio = gax::GaxPreconditions.CheckNotNull(audio, nameof(audio)),
            }, callSettings);

        /// <summary>
        /// Performs synchronous speech recognition: receive results after all audio
        /// has been sent and processed.
        /// </summary>
        /// <param name="config">
        /// Required. Provides information to the recognizer that specifies how to
        /// process the request.
        /// </param>
        /// <param name="audio">
        /// Required. The audio data to be recognized.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RecognizeResponse> RecognizeAsync(RecognitionConfig config, RecognitionAudio audio, st::CancellationToken cancellationToken) =>
            RecognizeAsync(config, audio, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Performs asynchronous speech recognition: receive results via the
        /// google.longrunning.Operations interface. Returns either an
        /// `Operation.error` or an `Operation.response` which contains
        /// a `LongRunningRecognizeResponse` message.
        /// For more information on asynchronous speech recognition, see the
        /// [how-to](https://cloud.google.com/speech-to-text/docs/async-recognize).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<LongRunningRecognizeResponse, LongRunningRecognizeMetadata> LongRunningRecognize(LongRunningRecognizeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Performs asynchronous speech recognition: receive results via the
        /// google.longrunning.Operations interface. Returns either an
        /// `Operation.error` or an `Operation.response` which contains
        /// a `LongRunningRecognizeResponse` message.
        /// For more information on asynchronous speech recognition, see the
        /// [how-to](https://cloud.google.com/speech-to-text/docs/async-recognize).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<LongRunningRecognizeResponse, LongRunningRecognizeMetadata>> LongRunningRecognizeAsync(LongRunningRecognizeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Performs asynchronous speech recognition: receive results via the
        /// google.longrunning.Operations interface. Returns either an
        /// `Operation.error` or an `Operation.response` which contains
        /// a `LongRunningRecognizeResponse` message.
        /// For more information on asynchronous speech recognition, see the
        /// [how-to](https://cloud.google.com/speech-to-text/docs/async-recognize).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<LongRunningRecognizeResponse, LongRunningRecognizeMetadata>> LongRunningRecognizeAsync(LongRunningRecognizeRequest request, st::CancellationToken cancellationToken) =>
            LongRunningRecognizeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>LongRunningRecognize</c>.</summary>
        public virtual lro::OperationsClient LongRunningRecognizeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>LongRunningRecognize</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<LongRunningRecognizeResponse, LongRunningRecognizeMetadata> PollOnceLongRunningRecognize(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<LongRunningRecognizeResponse, LongRunningRecognizeMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), LongRunningRecognizeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>LongRunningRecognize</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<LongRunningRecognizeResponse, LongRunningRecognizeMetadata>> PollOnceLongRunningRecognizeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<LongRunningRecognizeResponse, LongRunningRecognizeMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), LongRunningRecognizeOperationsClient, callSettings);

        /// <summary>
        /// Performs asynchronous speech recognition: receive results via the
        /// google.longrunning.Operations interface. Returns either an
        /// `Operation.error` or an `Operation.response` which contains
        /// a `LongRunningRecognizeResponse` message.
        /// For more information on asynchronous speech recognition, see the
        /// [how-to](https://cloud.google.com/speech-to-text/docs/async-recognize).
        /// </summary>
        /// <param name="config">
        /// Required. Provides information to the recognizer that specifies how to
        /// process the request.
        /// </param>
        /// <param name="audio">
        /// Required. The audio data to be recognized.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<LongRunningRecognizeResponse, LongRunningRecognizeMetadata> LongRunningRecognize(RecognitionConfig config, RecognitionAudio audio, gaxgrpc::CallSettings callSettings = null) =>
            LongRunningRecognize(new LongRunningRecognizeRequest
            {
                Config = gax::GaxPreconditions.CheckNotNull(config, nameof(config)),
                Audio = gax::GaxPreconditions.CheckNotNull(audio, nameof(audio)),
            }, callSettings);

        /// <summary>
        /// Performs asynchronous speech recognition: receive results via the
        /// google.longrunning.Operations interface. Returns either an
        /// `Operation.error` or an `Operation.response` which contains
        /// a `LongRunningRecognizeResponse` message.
        /// For more information on asynchronous speech recognition, see the
        /// [how-to](https://cloud.google.com/speech-to-text/docs/async-recognize).
        /// </summary>
        /// <param name="config">
        /// Required. Provides information to the recognizer that specifies how to
        /// process the request.
        /// </param>
        /// <param name="audio">
        /// Required. The audio data to be recognized.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<LongRunningRecognizeResponse, LongRunningRecognizeMetadata>> LongRunningRecognizeAsync(RecognitionConfig config, RecognitionAudio audio, gaxgrpc::CallSettings callSettings = null) =>
            LongRunningRecognizeAsync(new LongRunningRecognizeRequest
            {
                Config = gax::GaxPreconditions.CheckNotNull(config, nameof(config)),
                Audio = gax::GaxPreconditions.CheckNotNull(audio, nameof(audio)),
            }, callSettings);

        /// <summary>
        /// Performs asynchronous speech recognition: receive results via the
        /// google.longrunning.Operations interface. Returns either an
        /// `Operation.error` or an `Operation.response` which contains
        /// a `LongRunningRecognizeResponse` message.
        /// For more information on asynchronous speech recognition, see the
        /// [how-to](https://cloud.google.com/speech-to-text/docs/async-recognize).
        /// </summary>
        /// <param name="config">
        /// Required. Provides information to the recognizer that specifies how to
        /// process the request.
        /// </param>
        /// <param name="audio">
        /// Required. The audio data to be recognized.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<LongRunningRecognizeResponse, LongRunningRecognizeMetadata>> LongRunningRecognizeAsync(RecognitionConfig config, RecognitionAudio audio, st::CancellationToken cancellationToken) =>
            LongRunningRecognizeAsync(config, audio, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Bidirectional streaming methods for
        /// <see cref="StreamingRecognize(gaxgrpc::CallSettings,gaxgrpc::BidirectionalStreamingSettings)"/>.
        /// </summary>
        public abstract partial class StreamingRecognizeStream : gaxgrpc::BidirectionalStreamingBase<StreamingRecognizeRequest, StreamingRecognizeResponse>
        {
        }

        /// <summary>
        /// Performs bidirectional streaming speech recognition: receive results while
        /// sending audio. This method is only available via the gRPC API (not REST).
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public virtual StreamingRecognizeStream StreamingRecognize(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null) =>
            throw new sys::NotImplementedException();
    }

    /// <summary>Speech client wrapper implementation, for convenient use.</summary>
    public sealed partial class SpeechClientImpl : SpeechClient
    {
        private readonly gaxgrpc::ApiCall<RecognizeRequest, RecognizeResponse> _callRecognize;

        private readonly gaxgrpc::ApiCall<LongRunningRecognizeRequest, lro::Operation> _callLongRunningRecognize;

        private readonly gaxgrpc::ApiBidirectionalStreamingCall<StreamingRecognizeRequest, StreamingRecognizeResponse> _callStreamingRecognize;

        /// <summary>
        /// Constructs a client wrapper for the Speech service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SpeechSettings"/> used within this client.</param>
        public SpeechClientImpl(Speech.SpeechClient grpcClient, SpeechSettings settings)
        {
            GrpcClient = grpcClient;
            SpeechSettings effectiveSettings = settings ?? SpeechSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            LongRunningRecognizeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.LongRunningRecognizeOperationsSettings);
            _callRecognize = clientHelper.BuildApiCall<RecognizeRequest, RecognizeResponse>(grpcClient.RecognizeAsync, grpcClient.Recognize, effectiveSettings.RecognizeSettings);
            Modify_ApiCall(ref _callRecognize);
            Modify_RecognizeApiCall(ref _callRecognize);
            _callLongRunningRecognize = clientHelper.BuildApiCall<LongRunningRecognizeRequest, lro::Operation>(grpcClient.LongRunningRecognizeAsync, grpcClient.LongRunningRecognize, effectiveSettings.LongRunningRecognizeSettings);
            Modify_ApiCall(ref _callLongRunningRecognize);
            Modify_LongRunningRecognizeApiCall(ref _callLongRunningRecognize);
            _callStreamingRecognize = clientHelper.BuildApiCall<StreamingRecognizeRequest, StreamingRecognizeResponse>(grpcClient.StreamingRecognize, effectiveSettings.StreamingRecognizeSettings, effectiveSettings.StreamingRecognizeStreamingSettings);
            Modify_ApiCall(ref _callStreamingRecognize);
            Modify_StreamingRecognizeApiCall(ref _callStreamingRecognize);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiBidirectionalStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_RecognizeApiCall(ref gaxgrpc::ApiCall<RecognizeRequest, RecognizeResponse> call);

        partial void Modify_LongRunningRecognizeApiCall(ref gaxgrpc::ApiCall<LongRunningRecognizeRequest, lro::Operation> call);

        partial void Modify_StreamingRecognizeApiCall(ref gaxgrpc::ApiBidirectionalStreamingCall<StreamingRecognizeRequest, StreamingRecognizeResponse> call);

        partial void OnConstruction(Speech.SpeechClient grpcClient, SpeechSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Speech client</summary>
        public override Speech.SpeechClient GrpcClient { get; }

        partial void Modify_RecognizeRequest(ref RecognizeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_LongRunningRecognizeRequest(ref LongRunningRecognizeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StreamingRecognizeRequestCallSettings(ref gaxgrpc::CallSettings settings);

        partial void Modify_StreamingRecognizeRequestRequest(ref StreamingRecognizeRequest request);

        /// <summary>
        /// Performs synchronous speech recognition: receive results after all audio
        /// has been sent and processed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RecognizeResponse Recognize(RecognizeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RecognizeRequest(ref request, ref callSettings);
            return _callRecognize.Sync(request, callSettings);
        }

        /// <summary>
        /// Performs synchronous speech recognition: receive results after all audio
        /// has been sent and processed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RecognizeResponse> RecognizeAsync(RecognizeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RecognizeRequest(ref request, ref callSettings);
            return _callRecognize.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>LongRunningRecognize</c>.</summary>
        public override lro::OperationsClient LongRunningRecognizeOperationsClient { get; }

        /// <summary>
        /// Performs asynchronous speech recognition: receive results via the
        /// google.longrunning.Operations interface. Returns either an
        /// `Operation.error` or an `Operation.response` which contains
        /// a `LongRunningRecognizeResponse` message.
        /// For more information on asynchronous speech recognition, see the
        /// [how-to](https://cloud.google.com/speech-to-text/docs/async-recognize).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<LongRunningRecognizeResponse, LongRunningRecognizeMetadata> LongRunningRecognize(LongRunningRecognizeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LongRunningRecognizeRequest(ref request, ref callSettings);
            return new lro::Operation<LongRunningRecognizeResponse, LongRunningRecognizeMetadata>(_callLongRunningRecognize.Sync(request, callSettings), LongRunningRecognizeOperationsClient);
        }

        /// <summary>
        /// Performs asynchronous speech recognition: receive results via the
        /// google.longrunning.Operations interface. Returns either an
        /// `Operation.error` or an `Operation.response` which contains
        /// a `LongRunningRecognizeResponse` message.
        /// For more information on asynchronous speech recognition, see the
        /// [how-to](https://cloud.google.com/speech-to-text/docs/async-recognize).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<LongRunningRecognizeResponse, LongRunningRecognizeMetadata>> LongRunningRecognizeAsync(LongRunningRecognizeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LongRunningRecognizeRequest(ref request, ref callSettings);
            return new lro::Operation<LongRunningRecognizeResponse, LongRunningRecognizeMetadata>(await _callLongRunningRecognize.Async(request, callSettings).ConfigureAwait(false), LongRunningRecognizeOperationsClient);
        }

        internal sealed partial class StreamingRecognizeStreamImpl : StreamingRecognizeStream
        {
            /// <summary>Construct the bidirectional streaming method for <c>StreamingRecognize</c>.</summary>
            /// <param name="service">The service containing this streaming method.</param>
            /// <param name="call">The underlying gRPC duplex streaming call.</param>
            /// <param name="writeBuffer">
            /// The <see cref="gaxgrpc::BufferedClientStreamWriter{StreamingRecognizeRequest}"/> instance associated
            /// with this streaming call.
            /// </param>
            public StreamingRecognizeStreamImpl(SpeechClientImpl service, grpccore::AsyncDuplexStreamingCall<StreamingRecognizeRequest, StreamingRecognizeResponse> call, gaxgrpc::BufferedClientStreamWriter<StreamingRecognizeRequest> writeBuffer)
            {
                _service = service;
                GrpcCall = call;
                _writeBuffer = writeBuffer;
            }

            private SpeechClientImpl _service;

            private gaxgrpc::BufferedClientStreamWriter<StreamingRecognizeRequest> _writeBuffer;

            public override grpccore::AsyncDuplexStreamingCall<StreamingRecognizeRequest, StreamingRecognizeResponse> GrpcCall { get; }

            private StreamingRecognizeRequest ModifyRequest(StreamingRecognizeRequest request)
            {
                _service.Modify_StreamingRecognizeRequestRequest(ref request);
                return request;
            }

            public override stt::Task TryWriteAsync(StreamingRecognizeRequest message) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message));

            public override stt::Task WriteAsync(StreamingRecognizeRequest message) =>
                _writeBuffer.WriteAsync(ModifyRequest(message));

            public override stt::Task TryWriteAsync(StreamingRecognizeRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message), options);

            public override stt::Task WriteAsync(StreamingRecognizeRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.WriteAsync(ModifyRequest(message), options);

            public override stt::Task TryWriteCompleteAsync() => _writeBuffer.TryWriteCompleteAsync();

            public override stt::Task WriteCompleteAsync() => _writeBuffer.WriteCompleteAsync();
        }

        /// <summary>
        /// Performs bidirectional streaming speech recognition: receive results while
        /// sending audio. This method is only available via the gRPC API (not REST).
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public override SpeechClient.StreamingRecognizeStream StreamingRecognize(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null)
        {
            Modify_StreamingRecognizeRequestCallSettings(ref callSettings);
            gaxgrpc::BidirectionalStreamingSettings effectiveStreamingSettings = streamingSettings ?? _callStreamingRecognize.StreamingSettings;
            grpccore::AsyncDuplexStreamingCall<StreamingRecognizeRequest, StreamingRecognizeResponse> call = _callStreamingRecognize.Call(callSettings);
            gaxgrpc::BufferedClientStreamWriter<StreamingRecognizeRequest> writeBuffer = new gaxgrpc::BufferedClientStreamWriter<StreamingRecognizeRequest>(call.RequestStream, effectiveStreamingSettings.BufferedClientWriterCapacity);
            return new StreamingRecognizeStreamImpl(this, call, writeBuffer);
        }
    }

    public static partial class Speech
    {
        public partial class SpeechClient
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
