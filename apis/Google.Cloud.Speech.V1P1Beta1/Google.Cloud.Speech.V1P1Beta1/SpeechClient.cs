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
using pb = Google.Protobuf;
using pbwkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Speech.V1P1Beta1
{
    /// <summary>
    /// Settings for a <see cref="SpeechClient"/>.
    /// </summary>
    public sealed partial class SpeechSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="SpeechSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="SpeechSettings"/>.
        /// </returns>
        public static SpeechSettings GetDefault() => new SpeechSettings();

        /// <summary>
        /// Constructs a new <see cref="SpeechSettings"/> object with default settings.
        /// </summary>
        public SpeechSettings() { }

        private SpeechSettings(SpeechSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            RecognizeSettings = existing.RecognizeSettings;
            LongRunningRecognizeSettings = existing.LongRunningRecognizeSettings;
            LongRunningRecognizeOperationsSettings = existing.LongRunningRecognizeOperationsSettings?.Clone();
            StreamingRecognizeSettings = existing.StreamingRecognizeSettings;
            StreamingRecognizeStreamingSettings = existing.StreamingRecognizeStreamingSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SpeechSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="SpeechClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="SpeechClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="SpeechClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="SpeechClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="SpeechClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="SpeechClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="SpeechClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="SpeechClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 1000000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 1000000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(1000000),
            maxDelay: sys::TimeSpan.FromMilliseconds(1000000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpeechClient.Recognize</c> and <c>SpeechClient.RecognizeAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SpeechClient.Recognize</c> and
        /// <c>SpeechClient.RecognizeAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 1000000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 1000000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 5000000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings RecognizeSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpeechClient.LongRunningRecognize</c> and <c>SpeechClient.LongRunningRecognizeAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SpeechClient.LongRunningRecognize</c> and
        /// <c>SpeechClient.LongRunningRecognizeAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 1000000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 1000000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 5000000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings LongRunningRecognizeSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>SpeechClient.LongRunningRecognize</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45000 milliseconds</description></item>
        /// <item><description>Total timeout: 86400000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings LongRunningRecognizeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(
                gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(86400000L)),
                sys::TimeSpan.FromMilliseconds(20000L),
                1.5,
                sys::TimeSpan.FromMilliseconds(45000L))
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for calls to <c>SpeechClient.StreamingRecognize</c>.
        /// </summary>
        /// <remarks>
        /// Default RPC expiration is 5000000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings StreamingRecognizeSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromTimeout(sys::TimeSpan.FromMilliseconds(5000000)));

        /// <summary>
        /// <see cref="gaxgrpc::BidirectionalStreamingSettings"/> for calls to
        /// <c>SpeechClient.StreamingRecognize</c>.
        /// </summary>
        /// <remarks>
        /// The default local send queue size is 100.
        /// </remarks>
        public gaxgrpc::BidirectionalStreamingSettings StreamingRecognizeStreamingSettings { get; set; } =
            new gaxgrpc::BidirectionalStreamingSettings(100);

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="SpeechSettings"/> object.</returns>
        public SpeechSettings Clone() => new SpeechSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SpeechClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class SpeechClientBuilder : gaxgrpc::ClientBuilderBase<SpeechClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public SpeechSettings Settings { get; set; }

        /// <inheritdoc/>
        public override SpeechClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SpeechClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<SpeechClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SpeechClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => SpeechClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => SpeechClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => SpeechClient.ChannelPool;
    }

    /// <summary>
    /// Speech client wrapper, for convenient use.
    /// </summary>
    public abstract partial class SpeechClient
    {
        /// <summary>
        /// The default endpoint for the Speech service, which is a host of "speech.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("speech.googleapis.com", 443);

        /// <summary>
        /// The default Speech scopes.
        /// </summary>
        /// <remarks>
        /// The default Speech scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="SpeechClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Speech.V1P1Beta1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// SpeechClient client = await SpeechClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Speech.V1P1Beta1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     SpeechClient.DefaultEndpoint.Host, SpeechClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// SpeechClient client = SpeechClient.Create(channel);
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
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="SpeechClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Speech.V1P1Beta1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// SpeechClient client = SpeechClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Speech.V1P1Beta1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     SpeechClient.DefaultEndpoint.Host, SpeechClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// SpeechClient client = SpeechClient.Create(channel);
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
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
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
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="SpeechSettings"/>.</param>
        /// <returns>The created <see cref="SpeechClient"/>.</returns>
        public static SpeechClient Create(grpccore::CallInvoker callInvoker, SpeechSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Speech.SpeechClient grpcClient = new Speech.SpeechClient(callInvoker);
            return new SpeechClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, SpeechSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, SpeechSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, SpeechSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, SpeechSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC Speech client.
        /// </summary>
        public virtual Speech.SpeechClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Performs synchronous speech recognition: receive results after all audio
        /// has been sent and processed.
        /// </summary>
        /// <param name="config">
        /// *Required* Provides information to the recognizer that specifies how to
        /// process the request.
        /// </param>
        /// <param name="audio">
        /// *Required* The audio data to be recognized.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<RecognizeResponse> RecognizeAsync(
            RecognitionConfig config,
            RecognitionAudio audio,
            gaxgrpc::CallSettings callSettings = null) => RecognizeAsync(
                new RecognizeRequest
                {
                    Config = gax::GaxPreconditions.CheckNotNull(config, nameof(config)),
                    Audio = gax::GaxPreconditions.CheckNotNull(audio, nameof(audio)),
                },
                callSettings);

        /// <summary>
        /// Performs synchronous speech recognition: receive results after all audio
        /// has been sent and processed.
        /// </summary>
        /// <param name="config">
        /// *Required* Provides information to the recognizer that specifies how to
        /// process the request.
        /// </param>
        /// <param name="audio">
        /// *Required* The audio data to be recognized.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<RecognizeResponse> RecognizeAsync(
            RecognitionConfig config,
            RecognitionAudio audio,
            st::CancellationToken cancellationToken) => RecognizeAsync(
                config,
                audio,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Performs synchronous speech recognition: receive results after all audio
        /// has been sent and processed.
        /// </summary>
        /// <param name="config">
        /// *Required* Provides information to the recognizer that specifies how to
        /// process the request.
        /// </param>
        /// <param name="audio">
        /// *Required* The audio data to be recognized.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual RecognizeResponse Recognize(
            RecognitionConfig config,
            RecognitionAudio audio,
            gaxgrpc::CallSettings callSettings = null) => Recognize(
                new RecognizeRequest
                {
                    Config = gax::GaxPreconditions.CheckNotNull(config, nameof(config)),
                    Audio = gax::GaxPreconditions.CheckNotNull(audio, nameof(audio)),
                },
                callSettings);

        /// <summary>
        /// Performs synchronous speech recognition: receive results after all audio
        /// has been sent and processed.
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
        public virtual stt::Task<RecognizeResponse> RecognizeAsync(
            RecognizeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Performs synchronous speech recognition: receive results after all audio
        /// has been sent and processed.
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
        public virtual stt::Task<RecognizeResponse> RecognizeAsync(
            RecognizeRequest request,
            st::CancellationToken cancellationToken) => RecognizeAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Performs synchronous speech recognition: receive results after all audio
        /// has been sent and processed.
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
        public virtual RecognizeResponse Recognize(
            RecognizeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Performs asynchronous speech recognition: receive results via the
        /// google.longrunning.Operations interface. Returns either an
        /// `Operation.error` or an `Operation.response` which contains
        /// a `LongRunningRecognizeResponse` message.
        /// </summary>
        /// <param name="config">
        /// *Required* Provides information to the recognizer that specifies how to
        /// process the request.
        /// </param>
        /// <param name="audio">
        /// *Required* The audio data to be recognized.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<LongRunningRecognizeResponse, LongRunningRecognizeMetadata>> LongRunningRecognizeAsync(
            RecognitionConfig config,
            RecognitionAudio audio,
            gaxgrpc::CallSettings callSettings = null) => LongRunningRecognizeAsync(
                new LongRunningRecognizeRequest
                {
                    Config = gax::GaxPreconditions.CheckNotNull(config, nameof(config)),
                    Audio = gax::GaxPreconditions.CheckNotNull(audio, nameof(audio)),
                },
                callSettings);

        /// <summary>
        /// Performs asynchronous speech recognition: receive results via the
        /// google.longrunning.Operations interface. Returns either an
        /// `Operation.error` or an `Operation.response` which contains
        /// a `LongRunningRecognizeResponse` message.
        /// </summary>
        /// <param name="config">
        /// *Required* Provides information to the recognizer that specifies how to
        /// process the request.
        /// </param>
        /// <param name="audio">
        /// *Required* The audio data to be recognized.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<LongRunningRecognizeResponse, LongRunningRecognizeMetadata>> LongRunningRecognizeAsync(
            RecognitionConfig config,
            RecognitionAudio audio,
            st::CancellationToken cancellationToken) => LongRunningRecognizeAsync(
                config,
                audio,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Performs asynchronous speech recognition: receive results via the
        /// google.longrunning.Operations interface. Returns either an
        /// `Operation.error` or an `Operation.response` which contains
        /// a `LongRunningRecognizeResponse` message.
        /// </summary>
        /// <param name="config">
        /// *Required* Provides information to the recognizer that specifies how to
        /// process the request.
        /// </param>
        /// <param name="audio">
        /// *Required* The audio data to be recognized.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<LongRunningRecognizeResponse, LongRunningRecognizeMetadata> LongRunningRecognize(
            RecognitionConfig config,
            RecognitionAudio audio,
            gaxgrpc::CallSettings callSettings = null) => LongRunningRecognize(
                new LongRunningRecognizeRequest
                {
                    Config = gax::GaxPreconditions.CheckNotNull(config, nameof(config)),
                    Audio = gax::GaxPreconditions.CheckNotNull(audio, nameof(audio)),
                },
                callSettings);

        /// <summary>
        /// Performs asynchronous speech recognition: receive results via the
        /// google.longrunning.Operations interface. Returns either an
        /// `Operation.error` or an `Operation.response` which contains
        /// a `LongRunningRecognizeResponse` message.
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
        public virtual stt::Task<lro::Operation<LongRunningRecognizeResponse, LongRunningRecognizeMetadata>> LongRunningRecognizeAsync(
            LongRunningRecognizeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>LongRunningRecognizeAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<LongRunningRecognizeResponse, LongRunningRecognizeMetadata>> PollOnceLongRunningRecognizeAsync(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<LongRunningRecognizeResponse, LongRunningRecognizeMetadata>.PollOnceFromNameAsync(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                LongRunningRecognizeOperationsClient,
                callSettings);

        /// <summary>
        /// Performs asynchronous speech recognition: receive results via the
        /// google.longrunning.Operations interface. Returns either an
        /// `Operation.error` or an `Operation.response` which contains
        /// a `LongRunningRecognizeResponse` message.
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
        public virtual lro::Operation<LongRunningRecognizeResponse, LongRunningRecognizeMetadata> LongRunningRecognize(
            LongRunningRecognizeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>LongRunningRecognize</c>.
        /// </summary>
        public virtual lro::OperationsClient LongRunningRecognizeOperationsClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>LongRunningRecognize</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<LongRunningRecognizeResponse, LongRunningRecognizeMetadata> PollOnceLongRunningRecognize(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<LongRunningRecognizeResponse, LongRunningRecognizeMetadata>.PollOnceFromName(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                LongRunningRecognizeOperationsClient,
                callSettings);

        /// <summary>
        /// Performs bidirectional streaming speech recognition: receive results while
        /// sending audio. This method is only available via the gRPC API (not REST).
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
        public virtual StreamingRecognizeStream StreamingRecognize(
            gaxgrpc::CallSettings callSettings = null,
            gaxgrpc::BidirectionalStreamingSettings streamingSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Bidirectional streaming methods for <c>StreamingRecognize</c>.
        /// </summary>
        public abstract partial class StreamingRecognizeStream : gaxgrpc::BidirectionalStreamingBase<StreamingRecognizeRequest, StreamingRecognizeResponse>
        {
        }

    }

    /// <summary>
    /// Speech client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class SpeechClientImpl : SpeechClient
    {
        private readonly gaxgrpc::ApiCall<RecognizeRequest, RecognizeResponse> _callRecognize;
        private readonly gaxgrpc::ApiCall<LongRunningRecognizeRequest, lro::Operation> _callLongRunningRecognize;
        private readonly gaxgrpc::ApiBidirectionalStreamingCall<StreamingRecognizeRequest, StreamingRecognizeResponse> _callStreamingRecognize;

        /// <summary>
        /// Constructs a client wrapper for the Speech service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SpeechSettings"/> used within this client </param>
        public SpeechClientImpl(Speech.SpeechClient grpcClient, SpeechSettings settings)
        {
            GrpcClient = grpcClient;
            SpeechSettings effectiveSettings = settings ?? SpeechSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            LongRunningRecognizeOperationsClient = new lro::OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.LongRunningRecognizeOperationsSettings);
            _callRecognize = clientHelper.BuildApiCall<RecognizeRequest, RecognizeResponse>(
                GrpcClient.RecognizeAsync, GrpcClient.Recognize, effectiveSettings.RecognizeSettings);
            _callLongRunningRecognize = clientHelper.BuildApiCall<LongRunningRecognizeRequest, lro::Operation>(
                GrpcClient.LongRunningRecognizeAsync, GrpcClient.LongRunningRecognize, effectiveSettings.LongRunningRecognizeSettings);
            _callStreamingRecognize = clientHelper.BuildApiCall<StreamingRecognizeRequest, StreamingRecognizeResponse>(
                GrpcClient.StreamingRecognize, effectiveSettings.StreamingRecognizeSettings, effectiveSettings.StreamingRecognizeStreamingSettings);
            Modify_ApiCall(ref _callRecognize);
            Modify_RecognizeApiCall(ref _callRecognize);
            Modify_ApiCall(ref _callLongRunningRecognize);
            Modify_LongRunningRecognizeApiCall(ref _callLongRunningRecognize);
            Modify_ApiCall(ref _callStreamingRecognize);
            Modify_StreamingRecognizeApiCall(ref _callStreamingRecognize);
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
        partial void Modify_RecognizeApiCall(ref gaxgrpc::ApiCall<RecognizeRequest, RecognizeResponse> call);
        partial void Modify_LongRunningRecognizeApiCall(ref gaxgrpc::ApiCall<LongRunningRecognizeRequest, lro::Operation> call);
        partial void Modify_StreamingRecognizeApiCall(ref gaxgrpc::ApiBidirectionalStreamingCall<StreamingRecognizeRequest, StreamingRecognizeResponse> call);
        partial void OnConstruction(Speech.SpeechClient grpcClient, SpeechSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC Speech client.
        /// </summary>
        public override Speech.SpeechClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_RecognizeRequest(ref RecognizeRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_LongRunningRecognizeRequest(ref LongRunningRecognizeRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_StreamingRecognizeRequestCallSettings(ref gaxgrpc::CallSettings settings);
        partial void Modify_StreamingRecognizeRequestRequest(ref StreamingRecognizeRequest request);

        /// <summary>
        /// Performs synchronous speech recognition: receive results after all audio
        /// has been sent and processed.
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
        public override stt::Task<RecognizeResponse> RecognizeAsync(
            RecognizeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RecognizeRequest(ref request, ref callSettings);
            return _callRecognize.Async(request, callSettings);
        }

        /// <summary>
        /// Performs synchronous speech recognition: receive results after all audio
        /// has been sent and processed.
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
        public override RecognizeResponse Recognize(
            RecognizeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RecognizeRequest(ref request, ref callSettings);
            return _callRecognize.Sync(request, callSettings);
        }

        /// <summary>
        /// Performs asynchronous speech recognition: receive results via the
        /// google.longrunning.Operations interface. Returns either an
        /// `Operation.error` or an `Operation.response` which contains
        /// a `LongRunningRecognizeResponse` message.
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
        public override async stt::Task<lro::Operation<LongRunningRecognizeResponse, LongRunningRecognizeMetadata>> LongRunningRecognizeAsync(
            LongRunningRecognizeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LongRunningRecognizeRequest(ref request, ref callSettings);
            return new lro::Operation<LongRunningRecognizeResponse, LongRunningRecognizeMetadata>(
                await _callLongRunningRecognize.Async(request, callSettings).ConfigureAwait(false), LongRunningRecognizeOperationsClient);
        }

        /// <summary>
        /// Performs asynchronous speech recognition: receive results via the
        /// google.longrunning.Operations interface. Returns either an
        /// `Operation.error` or an `Operation.response` which contains
        /// a `LongRunningRecognizeResponse` message.
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
        public override lro::Operation<LongRunningRecognizeResponse, LongRunningRecognizeMetadata> LongRunningRecognize(
            LongRunningRecognizeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LongRunningRecognizeRequest(ref request, ref callSettings);
            return new lro::Operation<LongRunningRecognizeResponse, LongRunningRecognizeMetadata>(
                _callLongRunningRecognize.Sync(request, callSettings), LongRunningRecognizeOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>LongRunningRecognize</c>.
        /// </summary>
        public override lro::OperationsClient LongRunningRecognizeOperationsClient { get; }

        /// <summary>
        /// Performs bidirectional streaming speech recognition: receive results while
        /// sending audio. This method is only available via the gRPC API (not REST).
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
        public override StreamingRecognizeStream StreamingRecognize(
            gaxgrpc::CallSettings callSettings = null,
            gaxgrpc::BidirectionalStreamingSettings streamingSettings = null)
        {
            Modify_StreamingRecognizeRequestCallSettings(ref callSettings);
            gaxgrpc::BidirectionalStreamingSettings effectiveStreamingSettings =
                streamingSettings ?? _callStreamingRecognize.StreamingSettings;
            grpccore::AsyncDuplexStreamingCall<StreamingRecognizeRequest, StreamingRecognizeResponse> call =
                _callStreamingRecognize.Call(callSettings);
            gaxgrpc::BufferedClientStreamWriter<StreamingRecognizeRequest> writeBuffer =
                new gaxgrpc::BufferedClientStreamWriter<StreamingRecognizeRequest>(
                    call.RequestStream, effectiveStreamingSettings.BufferedClientWriterCapacity);
            return new StreamingRecognizeStreamImpl(this, call, writeBuffer);
        }

        internal sealed partial class StreamingRecognizeStreamImpl : StreamingRecognizeStream
        {
            /// <summary>
            /// Construct the bidirectional streaming method for <c>StreamingRecognize</c>.
            /// </summary>
            /// <param name="service">The service containing this streaming method.</param>
            /// <param name="call">The underlying gRPC duplex streaming call.</param>
            /// <param name="writeBuffer">The <see cref="gaxgrpc::BufferedClientStreamWriter{StreamingRecognizeRequest}"/>
            /// instance associated with this streaming call.</param>
            public StreamingRecognizeStreamImpl(
                SpeechClientImpl service,
                grpccore::AsyncDuplexStreamingCall<StreamingRecognizeRequest, StreamingRecognizeResponse> call,
                gaxgrpc::BufferedClientStreamWriter<StreamingRecognizeRequest> writeBuffer)
            {
                _service = service;
                GrpcCall = call;
                _writeBuffer = writeBuffer;
            }

            private SpeechClientImpl _service;
            private gaxgrpc::BufferedClientStreamWriter<StreamingRecognizeRequest> _writeBuffer;

            private StreamingRecognizeRequest ModifyRequest(StreamingRecognizeRequest request)
            {
                _service.Modify_StreamingRecognizeRequestRequest(ref request);
                return request;
            }

            /// <inheritdoc/>
            public override grpccore::AsyncDuplexStreamingCall<StreamingRecognizeRequest, StreamingRecognizeResponse> GrpcCall { get; }

            /// <inheritdoc/>
            public override stt::Task TryWriteAsync(StreamingRecognizeRequest message) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message));

            /// <inheritdoc/>
            public override stt::Task WriteAsync(StreamingRecognizeRequest message) =>
                _writeBuffer.WriteAsync(ModifyRequest(message));

            /// <inheritdoc/>
            public override stt::Task TryWriteAsync(StreamingRecognizeRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message), options);

            /// <inheritdoc/>
            public override stt::Task WriteAsync(StreamingRecognizeRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.WriteAsync(ModifyRequest(message), options);

            /// <inheritdoc/>
            public override stt::Task TryWriteCompleteAsync() =>
                _writeBuffer.TryWriteCompleteAsync();

            /// <inheritdoc/>
            public override stt::Task WriteCompleteAsync() =>
                _writeBuffer.WriteCompleteAsync();

            /// <inheritdoc/>
            public override scg::IAsyncEnumerator<StreamingRecognizeResponse> ResponseStream =>
                GrpcCall.ResponseStream;
        }

    }

    // Partial classes to enable page-streaming

    // Partial Grpc class to enable LRO client creation
    public static partial class Speech
    {
        public partial class SpeechClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() => new lro::Operations.OperationsClient(CallInvoker);
        }
    }


}
