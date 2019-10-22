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

namespace Google.Cloud.AutoML.V1
{
    /// <summary>
    /// Settings for a <see cref="PredictionServiceClient"/>.
    /// </summary>
    public sealed partial class PredictionServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="PredictionServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="PredictionServiceSettings"/>.
        /// </returns>
        public static PredictionServiceSettings GetDefault() => new PredictionServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="PredictionServiceSettings"/> object with default settings.
        /// </summary>
        public PredictionServiceSettings() { }

        private PredictionServiceSettings(PredictionServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            PredictSettings = existing.PredictSettings;
            BatchPredictSettings = existing.BatchPredictSettings;
            BatchPredictOperationsSettings = existing.BatchPredictOperationsSettings?.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(PredictionServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="PredictionServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="PredictionServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="PredictionServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="PredictionServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="PredictionServiceClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="PredictionServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="PredictionServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="PredictionServiceClient"/> RPC methods is defined as:
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
        /// <c>PredictionServiceClient.Predict</c> and <c>PredictionServiceClient.PredictAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>PredictionServiceClient.Predict</c> and
        /// <c>PredictionServiceClient.PredictAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings PredictSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PredictionServiceClient.BatchPredict</c> and <c>PredictionServiceClient.BatchPredictAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>PredictionServiceClient.BatchPredict</c> and
        /// <c>PredictionServiceClient.BatchPredictAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings BatchPredictSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>PredictionServiceClient.BatchPredict</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 500 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 5000 milliseconds</description></item>
        /// <item><description>Total timeout: 86400000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings BatchPredictOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(
                gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(86400000L)),
                sys::TimeSpan.FromMilliseconds(500L),
                1.5,
                sys::TimeSpan.FromMilliseconds(5000L))
        };

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="PredictionServiceSettings"/> object.</returns>
        public PredictionServiceSettings Clone() => new PredictionServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PredictionServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class PredictionServiceClientBuilder : gaxgrpc::ClientBuilderBase<PredictionServiceClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public PredictionServiceSettings Settings { get; set; }

        /// <inheritdoc/>
        public override PredictionServiceClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PredictionServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<PredictionServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PredictionServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => PredictionServiceClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => PredictionServiceClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => PredictionServiceClient.ChannelPool;
    }

    /// <summary>
    /// PredictionService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class PredictionServiceClient
    {
        /// <summary>
        /// The default endpoint for the PredictionService service, which is a host of "automl.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("automl.googleapis.com", 443);

        /// <summary>
        /// The default PredictionService scopes.
        /// </summary>
        /// <remarks>
        /// The default PredictionService scopes are:
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
        /// Asynchronously creates a <see cref="PredictionServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.AutoML.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// PredictionServiceClient client = await PredictionServiceClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.AutoML.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     PredictionServiceClient.DefaultEndpoint.Host, PredictionServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// PredictionServiceClient client = PredictionServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="PredictionServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="PredictionServiceClient"/>.</returns>
        public static async stt::Task<PredictionServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, PredictionServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="PredictionServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.AutoML.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// PredictionServiceClient client = PredictionServiceClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.AutoML.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     PredictionServiceClient.DefaultEndpoint.Host, PredictionServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// PredictionServiceClient client = PredictionServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="PredictionServiceSettings"/>.</param>
        /// <returns>The created <see cref="PredictionServiceClient"/>.</returns>
        public static PredictionServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, PredictionServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="PredictionServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="PredictionServiceSettings"/>.</param>
        /// <returns>The created <see cref="PredictionServiceClient"/>.</returns>
        public static PredictionServiceClient Create(grpccore::Channel channel, PredictionServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="PredictionServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="PredictionServiceSettings"/>.</param>
        /// <returns>The created <see cref="PredictionServiceClient"/>.</returns>
        public static PredictionServiceClient Create(grpccore::CallInvoker callInvoker, PredictionServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            PredictionService.PredictionServiceClient grpcClient = new PredictionService.PredictionServiceClient(callInvoker);
            return new PredictionServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, PredictionServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, PredictionServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, PredictionServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, PredictionServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC PredictionService client.
        /// </summary>
        public virtual PredictionService.PredictionServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Perform an online prediction. The prediction result will be directly
        /// returned in the response.
        /// Available for following ML problems, and their expected request payloads:
        /// * Image Classification - Image in .JPEG, .GIF or .PNG format, image_bytes
        ///                          up to 30MB.
        /// * Image Object Detection - Image in .JPEG, .GIF or .PNG format, image_bytes
        ///                            up to 30MB.
        /// * Text Classification - TextSnippet, content up to 60,000 characters,
        ///                         UTF-8 encoded.
        /// * Text Extraction - TextSnippet, content up to 30,000 characters,
        ///                     UTF-8 NFC encoded.
        /// * Translation - TextSnippet, content up to 25,000 characters, UTF-8
        ///                 encoded.
        /// * Text Sentiment - TextSnippet, content up 500 characters, UTF-8
        ///                     encoded.
        /// </summary>
        /// <param name="name">
        /// Name of the model requested to serve the prediction.
        /// </param>
        /// <param name="payload">
        /// Required. Payload to perform a prediction on. The payload must match the
        /// problem type that the model was trained to solve.
        /// </param>
        /// <param name="params">
        /// Additional domain-specific parameters, any string must be up to 25000
        /// characters long.
        ///
        /// *  For Image Classification:
        ///
        ///    `score_threshold` - (float) A value from 0.0 to 1.0. When the model
        ///     makes predictions for an image, it will only produce results that have
        ///     at least this confidence score. The default is 0.5.
        ///
        ///  *  For Image Object Detection:
        ///    `score_threshold` - (float) When Model detects objects on the image,
        ///        it will only produce bounding boxes which have at least this
        ///        confidence score. Value in 0 to 1 range, default is 0.5.
        ///    `max_bounding_box_count` - (int64) No more than this number of bounding
        ///        boxes will be returned in the response. Default is 100, the
        ///        requested value may be limited by server.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<PredictResponse> PredictAsync(
            ModelName name,
            ExamplePayload payload,
            scg::IDictionary<string, string> @params,
            gaxgrpc::CallSettings callSettings = null) => PredictAsync(
                new PredictRequest
                {
                    ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    Payload = gax::GaxPreconditions.CheckNotNull(payload, nameof(payload)),
                    Params = { @params ?? gax::EmptyDictionary<string, string>.Instance }, // Optional
                },
                callSettings);

        /// <summary>
        /// Perform an online prediction. The prediction result will be directly
        /// returned in the response.
        /// Available for following ML problems, and their expected request payloads:
        /// * Image Classification - Image in .JPEG, .GIF or .PNG format, image_bytes
        ///                          up to 30MB.
        /// * Image Object Detection - Image in .JPEG, .GIF or .PNG format, image_bytes
        ///                            up to 30MB.
        /// * Text Classification - TextSnippet, content up to 60,000 characters,
        ///                         UTF-8 encoded.
        /// * Text Extraction - TextSnippet, content up to 30,000 characters,
        ///                     UTF-8 NFC encoded.
        /// * Translation - TextSnippet, content up to 25,000 characters, UTF-8
        ///                 encoded.
        /// * Text Sentiment - TextSnippet, content up 500 characters, UTF-8
        ///                     encoded.
        /// </summary>
        /// <param name="name">
        /// Name of the model requested to serve the prediction.
        /// </param>
        /// <param name="payload">
        /// Required. Payload to perform a prediction on. The payload must match the
        /// problem type that the model was trained to solve.
        /// </param>
        /// <param name="params">
        /// Additional domain-specific parameters, any string must be up to 25000
        /// characters long.
        ///
        /// *  For Image Classification:
        ///
        ///    `score_threshold` - (float) A value from 0.0 to 1.0. When the model
        ///     makes predictions for an image, it will only produce results that have
        ///     at least this confidence score. The default is 0.5.
        ///
        ///  *  For Image Object Detection:
        ///    `score_threshold` - (float) When Model detects objects on the image,
        ///        it will only produce bounding boxes which have at least this
        ///        confidence score. Value in 0 to 1 range, default is 0.5.
        ///    `max_bounding_box_count` - (int64) No more than this number of bounding
        ///        boxes will be returned in the response. Default is 100, the
        ///        requested value may be limited by server.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<PredictResponse> PredictAsync(
            ModelName name,
            ExamplePayload payload,
            scg::IDictionary<string, string> @params,
            st::CancellationToken cancellationToken) => PredictAsync(
                name,
                payload,
                @params,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Perform an online prediction. The prediction result will be directly
        /// returned in the response.
        /// Available for following ML problems, and their expected request payloads:
        /// * Image Classification - Image in .JPEG, .GIF or .PNG format, image_bytes
        ///                          up to 30MB.
        /// * Image Object Detection - Image in .JPEG, .GIF or .PNG format, image_bytes
        ///                            up to 30MB.
        /// * Text Classification - TextSnippet, content up to 60,000 characters,
        ///                         UTF-8 encoded.
        /// * Text Extraction - TextSnippet, content up to 30,000 characters,
        ///                     UTF-8 NFC encoded.
        /// * Translation - TextSnippet, content up to 25,000 characters, UTF-8
        ///                 encoded.
        /// * Text Sentiment - TextSnippet, content up 500 characters, UTF-8
        ///                     encoded.
        /// </summary>
        /// <param name="name">
        /// Name of the model requested to serve the prediction.
        /// </param>
        /// <param name="payload">
        /// Required. Payload to perform a prediction on. The payload must match the
        /// problem type that the model was trained to solve.
        /// </param>
        /// <param name="params">
        /// Additional domain-specific parameters, any string must be up to 25000
        /// characters long.
        ///
        /// *  For Image Classification:
        ///
        ///    `score_threshold` - (float) A value from 0.0 to 1.0. When the model
        ///     makes predictions for an image, it will only produce results that have
        ///     at least this confidence score. The default is 0.5.
        ///
        ///  *  For Image Object Detection:
        ///    `score_threshold` - (float) When Model detects objects on the image,
        ///        it will only produce bounding boxes which have at least this
        ///        confidence score. Value in 0 to 1 range, default is 0.5.
        ///    `max_bounding_box_count` - (int64) No more than this number of bounding
        ///        boxes will be returned in the response. Default is 100, the
        ///        requested value may be limited by server.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual PredictResponse Predict(
            ModelName name,
            ExamplePayload payload,
            scg::IDictionary<string, string> @params,
            gaxgrpc::CallSettings callSettings = null) => Predict(
                new PredictRequest
                {
                    ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    Payload = gax::GaxPreconditions.CheckNotNull(payload, nameof(payload)),
                    Params = { @params ?? gax::EmptyDictionary<string, string>.Instance }, // Optional
                },
                callSettings);

        /// <summary>
        /// Perform an online prediction. The prediction result will be directly
        /// returned in the response.
        /// Available for following ML problems, and their expected request payloads:
        /// * Image Classification - Image in .JPEG, .GIF or .PNG format, image_bytes
        ///                          up to 30MB.
        /// * Image Object Detection - Image in .JPEG, .GIF or .PNG format, image_bytes
        ///                            up to 30MB.
        /// * Text Classification - TextSnippet, content up to 60,000 characters,
        ///                         UTF-8 encoded.
        /// * Text Extraction - TextSnippet, content up to 30,000 characters,
        ///                     UTF-8 NFC encoded.
        /// * Translation - TextSnippet, content up to 25,000 characters, UTF-8
        ///                 encoded.
        /// * Text Sentiment - TextSnippet, content up 500 characters, UTF-8
        ///                     encoded.
        /// </summary>
        /// <param name="name">
        /// Name of the model requested to serve the prediction.
        /// </param>
        /// <param name="payload">
        /// Required. Payload to perform a prediction on. The payload must match the
        /// problem type that the model was trained to solve.
        /// </param>
        /// <param name="params">
        /// Additional domain-specific parameters, any string must be up to 25000
        /// characters long.
        ///
        /// *  For Image Classification:
        ///
        ///    `score_threshold` - (float) A value from 0.0 to 1.0. When the model
        ///     makes predictions for an image, it will only produce results that have
        ///     at least this confidence score. The default is 0.5.
        ///
        ///  *  For Image Object Detection:
        ///    `score_threshold` - (float) When Model detects objects on the image,
        ///        it will only produce bounding boxes which have at least this
        ///        confidence score. Value in 0 to 1 range, default is 0.5.
        ///    `max_bounding_box_count` - (int64) No more than this number of bounding
        ///        boxes will be returned in the response. Default is 100, the
        ///        requested value may be limited by server.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<PredictResponse> PredictAsync(
            string name,
            ExamplePayload payload,
            scg::IDictionary<string, string> @params,
            gaxgrpc::CallSettings callSettings = null) => PredictAsync(
                new PredictRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    Payload = gax::GaxPreconditions.CheckNotNull(payload, nameof(payload)),
                    Params = { @params ?? gax::EmptyDictionary<string, string>.Instance }, // Optional
                },
                callSettings);

        /// <summary>
        /// Perform an online prediction. The prediction result will be directly
        /// returned in the response.
        /// Available for following ML problems, and their expected request payloads:
        /// * Image Classification - Image in .JPEG, .GIF or .PNG format, image_bytes
        ///                          up to 30MB.
        /// * Image Object Detection - Image in .JPEG, .GIF or .PNG format, image_bytes
        ///                            up to 30MB.
        /// * Text Classification - TextSnippet, content up to 60,000 characters,
        ///                         UTF-8 encoded.
        /// * Text Extraction - TextSnippet, content up to 30,000 characters,
        ///                     UTF-8 NFC encoded.
        /// * Translation - TextSnippet, content up to 25,000 characters, UTF-8
        ///                 encoded.
        /// * Text Sentiment - TextSnippet, content up 500 characters, UTF-8
        ///                     encoded.
        /// </summary>
        /// <param name="name">
        /// Name of the model requested to serve the prediction.
        /// </param>
        /// <param name="payload">
        /// Required. Payload to perform a prediction on. The payload must match the
        /// problem type that the model was trained to solve.
        /// </param>
        /// <param name="params">
        /// Additional domain-specific parameters, any string must be up to 25000
        /// characters long.
        ///
        /// *  For Image Classification:
        ///
        ///    `score_threshold` - (float) A value from 0.0 to 1.0. When the model
        ///     makes predictions for an image, it will only produce results that have
        ///     at least this confidence score. The default is 0.5.
        ///
        ///  *  For Image Object Detection:
        ///    `score_threshold` - (float) When Model detects objects on the image,
        ///        it will only produce bounding boxes which have at least this
        ///        confidence score. Value in 0 to 1 range, default is 0.5.
        ///    `max_bounding_box_count` - (int64) No more than this number of bounding
        ///        boxes will be returned in the response. Default is 100, the
        ///        requested value may be limited by server.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<PredictResponse> PredictAsync(
            string name,
            ExamplePayload payload,
            scg::IDictionary<string, string> @params,
            st::CancellationToken cancellationToken) => PredictAsync(
                name,
                payload,
                @params,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Perform an online prediction. The prediction result will be directly
        /// returned in the response.
        /// Available for following ML problems, and their expected request payloads:
        /// * Image Classification - Image in .JPEG, .GIF or .PNG format, image_bytes
        ///                          up to 30MB.
        /// * Image Object Detection - Image in .JPEG, .GIF or .PNG format, image_bytes
        ///                            up to 30MB.
        /// * Text Classification - TextSnippet, content up to 60,000 characters,
        ///                         UTF-8 encoded.
        /// * Text Extraction - TextSnippet, content up to 30,000 characters,
        ///                     UTF-8 NFC encoded.
        /// * Translation - TextSnippet, content up to 25,000 characters, UTF-8
        ///                 encoded.
        /// * Text Sentiment - TextSnippet, content up 500 characters, UTF-8
        ///                     encoded.
        /// </summary>
        /// <param name="name">
        /// Name of the model requested to serve the prediction.
        /// </param>
        /// <param name="payload">
        /// Required. Payload to perform a prediction on. The payload must match the
        /// problem type that the model was trained to solve.
        /// </param>
        /// <param name="params">
        /// Additional domain-specific parameters, any string must be up to 25000
        /// characters long.
        ///
        /// *  For Image Classification:
        ///
        ///    `score_threshold` - (float) A value from 0.0 to 1.0. When the model
        ///     makes predictions for an image, it will only produce results that have
        ///     at least this confidence score. The default is 0.5.
        ///
        ///  *  For Image Object Detection:
        ///    `score_threshold` - (float) When Model detects objects on the image,
        ///        it will only produce bounding boxes which have at least this
        ///        confidence score. Value in 0 to 1 range, default is 0.5.
        ///    `max_bounding_box_count` - (int64) No more than this number of bounding
        ///        boxes will be returned in the response. Default is 100, the
        ///        requested value may be limited by server.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual PredictResponse Predict(
            string name,
            ExamplePayload payload,
            scg::IDictionary<string, string> @params,
            gaxgrpc::CallSettings callSettings = null) => Predict(
                new PredictRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    Payload = gax::GaxPreconditions.CheckNotNull(payload, nameof(payload)),
                    Params = { @params ?? gax::EmptyDictionary<string, string>.Instance }, // Optional
                },
                callSettings);

        /// <summary>
        /// Perform an online prediction. The prediction result will be directly
        /// returned in the response.
        /// Available for following ML problems, and their expected request payloads:
        /// * Image Classification - Image in .JPEG, .GIF or .PNG format, image_bytes
        ///                          up to 30MB.
        /// * Image Object Detection - Image in .JPEG, .GIF or .PNG format, image_bytes
        ///                            up to 30MB.
        /// * Text Classification - TextSnippet, content up to 60,000 characters,
        ///                         UTF-8 encoded.
        /// * Text Extraction - TextSnippet, content up to 30,000 characters,
        ///                     UTF-8 NFC encoded.
        /// * Translation - TextSnippet, content up to 25,000 characters, UTF-8
        ///                 encoded.
        /// * Text Sentiment - TextSnippet, content up 500 characters, UTF-8
        ///                     encoded.
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
        public virtual stt::Task<PredictResponse> PredictAsync(
            PredictRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Perform an online prediction. The prediction result will be directly
        /// returned in the response.
        /// Available for following ML problems, and their expected request payloads:
        /// * Image Classification - Image in .JPEG, .GIF or .PNG format, image_bytes
        ///                          up to 30MB.
        /// * Image Object Detection - Image in .JPEG, .GIF or .PNG format, image_bytes
        ///                            up to 30MB.
        /// * Text Classification - TextSnippet, content up to 60,000 characters,
        ///                         UTF-8 encoded.
        /// * Text Extraction - TextSnippet, content up to 30,000 characters,
        ///                     UTF-8 NFC encoded.
        /// * Translation - TextSnippet, content up to 25,000 characters, UTF-8
        ///                 encoded.
        /// * Text Sentiment - TextSnippet, content up 500 characters, UTF-8
        ///                     encoded.
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
        public virtual stt::Task<PredictResponse> PredictAsync(
            PredictRequest request,
            st::CancellationToken cancellationToken) => PredictAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Perform an online prediction. The prediction result will be directly
        /// returned in the response.
        /// Available for following ML problems, and their expected request payloads:
        /// * Image Classification - Image in .JPEG, .GIF or .PNG format, image_bytes
        ///                          up to 30MB.
        /// * Image Object Detection - Image in .JPEG, .GIF or .PNG format, image_bytes
        ///                            up to 30MB.
        /// * Text Classification - TextSnippet, content up to 60,000 characters,
        ///                         UTF-8 encoded.
        /// * Text Extraction - TextSnippet, content up to 30,000 characters,
        ///                     UTF-8 NFC encoded.
        /// * Translation - TextSnippet, content up to 25,000 characters, UTF-8
        ///                 encoded.
        /// * Text Sentiment - TextSnippet, content up 500 characters, UTF-8
        ///                     encoded.
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
        public virtual PredictResponse Predict(
            PredictRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Perform a batch prediction. Unlike the online
        /// [Predict][google.cloud.automl.v1.PredictionService.Predict], batch
        /// prediction result won't be immediately available in the response. Instead,
        /// a long running operation object is returned. User can poll the operation
        /// result via [GetOperation][google.longrunning.Operations.GetOperation]
        /// method. Once the operation is done,
        /// [BatchPredictResult][google.cloud.automl.v1.BatchPredictResult] is returned
        /// in the [response][google.longrunning.Operation.response] field. Available
        /// for following ML problems:
        /// * Image Classification
        /// * Image Object Detection
        /// * Text Extraction
        /// </summary>
        /// <param name="name">
        /// Name of the model requested to serve the batch prediction.
        /// </param>
        /// <param name="inputConfig">
        /// Required. The input configuration for batch prediction.
        /// </param>
        /// <param name="outputConfig">
        /// Required. The Configuration specifying where output predictions should
        /// be written.
        /// </param>
        /// <param name="params">
        /// Additional domain-specific parameters for the predictions, any string must
        /// be up to 25000 characters long.
        ///
        /// *  For Text Classification:
        ///
        ///    `score_threshold` - (float) A value from 0.0 to 1.0. When the model
        ///         makes predictions for a text snippet, it will only produce results
        ///         that have at least this confidence score. The default is 0.5.
        ///
        /// *  For Image Classification:
        ///
        ///    `score_threshold` - (float) A value from 0.0 to 1.0. When the model
        ///         makes predictions for an image, it will only produce results that
        ///         have at least this confidence score. The default is 0.5.
        ///
        /// *  For Image Object Detection:
        ///
        ///    `score_threshold` - (float) When Model detects objects on the image,
        ///        it will only produce bounding boxes which have at least this
        ///        confidence score. Value in 0 to 1 range, default is 0.5.
        ///    `max_bounding_box_count` - (int64) No more than this number of bounding
        ///        boxes will be produced per image. Default is 100, the
        ///        requested value may be limited by server.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<BatchPredictResult, OperationMetadata>> BatchPredictAsync(
            ModelName name,
            BatchPredictInputConfig inputConfig,
            BatchPredictOutputConfig outputConfig,
            scg::IDictionary<string, string> @params,
            gaxgrpc::CallSettings callSettings = null) => BatchPredictAsync(
                new BatchPredictRequest
                {
                    ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    InputConfig = gax::GaxPreconditions.CheckNotNull(inputConfig, nameof(inputConfig)),
                    OutputConfig = gax::GaxPreconditions.CheckNotNull(outputConfig, nameof(outputConfig)),
                    Params = { @params ?? gax::EmptyDictionary<string, string>.Instance }, // Optional
                },
                callSettings);

        /// <summary>
        /// Perform a batch prediction. Unlike the online
        /// [Predict][google.cloud.automl.v1.PredictionService.Predict], batch
        /// prediction result won't be immediately available in the response. Instead,
        /// a long running operation object is returned. User can poll the operation
        /// result via [GetOperation][google.longrunning.Operations.GetOperation]
        /// method. Once the operation is done,
        /// [BatchPredictResult][google.cloud.automl.v1.BatchPredictResult] is returned
        /// in the [response][google.longrunning.Operation.response] field. Available
        /// for following ML problems:
        /// * Image Classification
        /// * Image Object Detection
        /// * Text Extraction
        /// </summary>
        /// <param name="name">
        /// Name of the model requested to serve the batch prediction.
        /// </param>
        /// <param name="inputConfig">
        /// Required. The input configuration for batch prediction.
        /// </param>
        /// <param name="outputConfig">
        /// Required. The Configuration specifying where output predictions should
        /// be written.
        /// </param>
        /// <param name="params">
        /// Additional domain-specific parameters for the predictions, any string must
        /// be up to 25000 characters long.
        ///
        /// *  For Text Classification:
        ///
        ///    `score_threshold` - (float) A value from 0.0 to 1.0. When the model
        ///         makes predictions for a text snippet, it will only produce results
        ///         that have at least this confidence score. The default is 0.5.
        ///
        /// *  For Image Classification:
        ///
        ///    `score_threshold` - (float) A value from 0.0 to 1.0. When the model
        ///         makes predictions for an image, it will only produce results that
        ///         have at least this confidence score. The default is 0.5.
        ///
        /// *  For Image Object Detection:
        ///
        ///    `score_threshold` - (float) When Model detects objects on the image,
        ///        it will only produce bounding boxes which have at least this
        ///        confidence score. Value in 0 to 1 range, default is 0.5.
        ///    `max_bounding_box_count` - (int64) No more than this number of bounding
        ///        boxes will be produced per image. Default is 100, the
        ///        requested value may be limited by server.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<BatchPredictResult, OperationMetadata>> BatchPredictAsync(
            ModelName name,
            BatchPredictInputConfig inputConfig,
            BatchPredictOutputConfig outputConfig,
            scg::IDictionary<string, string> @params,
            st::CancellationToken cancellationToken) => BatchPredictAsync(
                name,
                inputConfig,
                outputConfig,
                @params,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Perform a batch prediction. Unlike the online
        /// [Predict][google.cloud.automl.v1.PredictionService.Predict], batch
        /// prediction result won't be immediately available in the response. Instead,
        /// a long running operation object is returned. User can poll the operation
        /// result via [GetOperation][google.longrunning.Operations.GetOperation]
        /// method. Once the operation is done,
        /// [BatchPredictResult][google.cloud.automl.v1.BatchPredictResult] is returned
        /// in the [response][google.longrunning.Operation.response] field. Available
        /// for following ML problems:
        /// * Image Classification
        /// * Image Object Detection
        /// * Text Extraction
        /// </summary>
        /// <param name="name">
        /// Name of the model requested to serve the batch prediction.
        /// </param>
        /// <param name="inputConfig">
        /// Required. The input configuration for batch prediction.
        /// </param>
        /// <param name="outputConfig">
        /// Required. The Configuration specifying where output predictions should
        /// be written.
        /// </param>
        /// <param name="params">
        /// Additional domain-specific parameters for the predictions, any string must
        /// be up to 25000 characters long.
        ///
        /// *  For Text Classification:
        ///
        ///    `score_threshold` - (float) A value from 0.0 to 1.0. When the model
        ///         makes predictions for a text snippet, it will only produce results
        ///         that have at least this confidence score. The default is 0.5.
        ///
        /// *  For Image Classification:
        ///
        ///    `score_threshold` - (float) A value from 0.0 to 1.0. When the model
        ///         makes predictions for an image, it will only produce results that
        ///         have at least this confidence score. The default is 0.5.
        ///
        /// *  For Image Object Detection:
        ///
        ///    `score_threshold` - (float) When Model detects objects on the image,
        ///        it will only produce bounding boxes which have at least this
        ///        confidence score. Value in 0 to 1 range, default is 0.5.
        ///    `max_bounding_box_count` - (int64) No more than this number of bounding
        ///        boxes will be produced per image. Default is 100, the
        ///        requested value may be limited by server.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<BatchPredictResult, OperationMetadata> BatchPredict(
            ModelName name,
            BatchPredictInputConfig inputConfig,
            BatchPredictOutputConfig outputConfig,
            scg::IDictionary<string, string> @params,
            gaxgrpc::CallSettings callSettings = null) => BatchPredict(
                new BatchPredictRequest
                {
                    ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    InputConfig = gax::GaxPreconditions.CheckNotNull(inputConfig, nameof(inputConfig)),
                    OutputConfig = gax::GaxPreconditions.CheckNotNull(outputConfig, nameof(outputConfig)),
                    Params = { @params ?? gax::EmptyDictionary<string, string>.Instance }, // Optional
                },
                callSettings);

        /// <summary>
        /// Perform a batch prediction. Unlike the online
        /// [Predict][google.cloud.automl.v1.PredictionService.Predict], batch
        /// prediction result won't be immediately available in the response. Instead,
        /// a long running operation object is returned. User can poll the operation
        /// result via [GetOperation][google.longrunning.Operations.GetOperation]
        /// method. Once the operation is done,
        /// [BatchPredictResult][google.cloud.automl.v1.BatchPredictResult] is returned
        /// in the [response][google.longrunning.Operation.response] field. Available
        /// for following ML problems:
        /// * Image Classification
        /// * Image Object Detection
        /// * Text Extraction
        /// </summary>
        /// <param name="name">
        /// Name of the model requested to serve the batch prediction.
        /// </param>
        /// <param name="inputConfig">
        /// Required. The input configuration for batch prediction.
        /// </param>
        /// <param name="outputConfig">
        /// Required. The Configuration specifying where output predictions should
        /// be written.
        /// </param>
        /// <param name="params">
        /// Additional domain-specific parameters for the predictions, any string must
        /// be up to 25000 characters long.
        ///
        /// *  For Text Classification:
        ///
        ///    `score_threshold` - (float) A value from 0.0 to 1.0. When the model
        ///         makes predictions for a text snippet, it will only produce results
        ///         that have at least this confidence score. The default is 0.5.
        ///
        /// *  For Image Classification:
        ///
        ///    `score_threshold` - (float) A value from 0.0 to 1.0. When the model
        ///         makes predictions for an image, it will only produce results that
        ///         have at least this confidence score. The default is 0.5.
        ///
        /// *  For Image Object Detection:
        ///
        ///    `score_threshold` - (float) When Model detects objects on the image,
        ///        it will only produce bounding boxes which have at least this
        ///        confidence score. Value in 0 to 1 range, default is 0.5.
        ///    `max_bounding_box_count` - (int64) No more than this number of bounding
        ///        boxes will be produced per image. Default is 100, the
        ///        requested value may be limited by server.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<BatchPredictResult, OperationMetadata>> BatchPredictAsync(
            string name,
            BatchPredictInputConfig inputConfig,
            BatchPredictOutputConfig outputConfig,
            scg::IDictionary<string, string> @params,
            gaxgrpc::CallSettings callSettings = null) => BatchPredictAsync(
                new BatchPredictRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    InputConfig = gax::GaxPreconditions.CheckNotNull(inputConfig, nameof(inputConfig)),
                    OutputConfig = gax::GaxPreconditions.CheckNotNull(outputConfig, nameof(outputConfig)),
                    Params = { @params ?? gax::EmptyDictionary<string, string>.Instance }, // Optional
                },
                callSettings);

        /// <summary>
        /// Perform a batch prediction. Unlike the online
        /// [Predict][google.cloud.automl.v1.PredictionService.Predict], batch
        /// prediction result won't be immediately available in the response. Instead,
        /// a long running operation object is returned. User can poll the operation
        /// result via [GetOperation][google.longrunning.Operations.GetOperation]
        /// method. Once the operation is done,
        /// [BatchPredictResult][google.cloud.automl.v1.BatchPredictResult] is returned
        /// in the [response][google.longrunning.Operation.response] field. Available
        /// for following ML problems:
        /// * Image Classification
        /// * Image Object Detection
        /// * Text Extraction
        /// </summary>
        /// <param name="name">
        /// Name of the model requested to serve the batch prediction.
        /// </param>
        /// <param name="inputConfig">
        /// Required. The input configuration for batch prediction.
        /// </param>
        /// <param name="outputConfig">
        /// Required. The Configuration specifying where output predictions should
        /// be written.
        /// </param>
        /// <param name="params">
        /// Additional domain-specific parameters for the predictions, any string must
        /// be up to 25000 characters long.
        ///
        /// *  For Text Classification:
        ///
        ///    `score_threshold` - (float) A value from 0.0 to 1.0. When the model
        ///         makes predictions for a text snippet, it will only produce results
        ///         that have at least this confidence score. The default is 0.5.
        ///
        /// *  For Image Classification:
        ///
        ///    `score_threshold` - (float) A value from 0.0 to 1.0. When the model
        ///         makes predictions for an image, it will only produce results that
        ///         have at least this confidence score. The default is 0.5.
        ///
        /// *  For Image Object Detection:
        ///
        ///    `score_threshold` - (float) When Model detects objects on the image,
        ///        it will only produce bounding boxes which have at least this
        ///        confidence score. Value in 0 to 1 range, default is 0.5.
        ///    `max_bounding_box_count` - (int64) No more than this number of bounding
        ///        boxes will be produced per image. Default is 100, the
        ///        requested value may be limited by server.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<BatchPredictResult, OperationMetadata>> BatchPredictAsync(
            string name,
            BatchPredictInputConfig inputConfig,
            BatchPredictOutputConfig outputConfig,
            scg::IDictionary<string, string> @params,
            st::CancellationToken cancellationToken) => BatchPredictAsync(
                name,
                inputConfig,
                outputConfig,
                @params,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Perform a batch prediction. Unlike the online
        /// [Predict][google.cloud.automl.v1.PredictionService.Predict], batch
        /// prediction result won't be immediately available in the response. Instead,
        /// a long running operation object is returned. User can poll the operation
        /// result via [GetOperation][google.longrunning.Operations.GetOperation]
        /// method. Once the operation is done,
        /// [BatchPredictResult][google.cloud.automl.v1.BatchPredictResult] is returned
        /// in the [response][google.longrunning.Operation.response] field. Available
        /// for following ML problems:
        /// * Image Classification
        /// * Image Object Detection
        /// * Text Extraction
        /// </summary>
        /// <param name="name">
        /// Name of the model requested to serve the batch prediction.
        /// </param>
        /// <param name="inputConfig">
        /// Required. The input configuration for batch prediction.
        /// </param>
        /// <param name="outputConfig">
        /// Required. The Configuration specifying where output predictions should
        /// be written.
        /// </param>
        /// <param name="params">
        /// Additional domain-specific parameters for the predictions, any string must
        /// be up to 25000 characters long.
        ///
        /// *  For Text Classification:
        ///
        ///    `score_threshold` - (float) A value from 0.0 to 1.0. When the model
        ///         makes predictions for a text snippet, it will only produce results
        ///         that have at least this confidence score. The default is 0.5.
        ///
        /// *  For Image Classification:
        ///
        ///    `score_threshold` - (float) A value from 0.0 to 1.0. When the model
        ///         makes predictions for an image, it will only produce results that
        ///         have at least this confidence score. The default is 0.5.
        ///
        /// *  For Image Object Detection:
        ///
        ///    `score_threshold` - (float) When Model detects objects on the image,
        ///        it will only produce bounding boxes which have at least this
        ///        confidence score. Value in 0 to 1 range, default is 0.5.
        ///    `max_bounding_box_count` - (int64) No more than this number of bounding
        ///        boxes will be produced per image. Default is 100, the
        ///        requested value may be limited by server.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<BatchPredictResult, OperationMetadata> BatchPredict(
            string name,
            BatchPredictInputConfig inputConfig,
            BatchPredictOutputConfig outputConfig,
            scg::IDictionary<string, string> @params,
            gaxgrpc::CallSettings callSettings = null) => BatchPredict(
                new BatchPredictRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    InputConfig = gax::GaxPreconditions.CheckNotNull(inputConfig, nameof(inputConfig)),
                    OutputConfig = gax::GaxPreconditions.CheckNotNull(outputConfig, nameof(outputConfig)),
                    Params = { @params ?? gax::EmptyDictionary<string, string>.Instance }, // Optional
                },
                callSettings);

        /// <summary>
        /// Perform a batch prediction. Unlike the online
        /// [Predict][google.cloud.automl.v1.PredictionService.Predict], batch
        /// prediction result won't be immediately available in the response. Instead,
        /// a long running operation object is returned. User can poll the operation
        /// result via [GetOperation][google.longrunning.Operations.GetOperation]
        /// method. Once the operation is done,
        /// [BatchPredictResult][google.cloud.automl.v1.BatchPredictResult] is returned
        /// in the [response][google.longrunning.Operation.response] field. Available
        /// for following ML problems:
        /// * Image Classification
        /// * Image Object Detection
        /// * Text Extraction
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
        public virtual stt::Task<lro::Operation<BatchPredictResult, OperationMetadata>> BatchPredictAsync(
            BatchPredictRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchPredictAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BatchPredictResult, OperationMetadata>> PollOnceBatchPredictAsync(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<BatchPredictResult, OperationMetadata>.PollOnceFromNameAsync(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                BatchPredictOperationsClient,
                callSettings);

        /// <summary>
        /// Perform a batch prediction. Unlike the online
        /// [Predict][google.cloud.automl.v1.PredictionService.Predict], batch
        /// prediction result won't be immediately available in the response. Instead,
        /// a long running operation object is returned. User can poll the operation
        /// result via [GetOperation][google.longrunning.Operations.GetOperation]
        /// method. Once the operation is done,
        /// [BatchPredictResult][google.cloud.automl.v1.BatchPredictResult] is returned
        /// in the [response][google.longrunning.Operation.response] field. Available
        /// for following ML problems:
        /// * Image Classification
        /// * Image Object Detection
        /// * Text Extraction
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
        public virtual lro::Operation<BatchPredictResult, OperationMetadata> BatchPredict(
            BatchPredictRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>BatchPredict</c>.
        /// </summary>
        public virtual lro::OperationsClient BatchPredictOperationsClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchPredict</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BatchPredictResult, OperationMetadata> PollOnceBatchPredict(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<BatchPredictResult, OperationMetadata>.PollOnceFromName(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                BatchPredictOperationsClient,
                callSettings);

    }

    /// <summary>
    /// PredictionService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class PredictionServiceClientImpl : PredictionServiceClient
    {
        private readonly gaxgrpc::ApiCall<PredictRequest, PredictResponse> _callPredict;
        private readonly gaxgrpc::ApiCall<BatchPredictRequest, lro::Operation> _callBatchPredict;

        /// <summary>
        /// Constructs a client wrapper for the PredictionService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="PredictionServiceSettings"/> used within this client </param>
        public PredictionServiceClientImpl(PredictionService.PredictionServiceClient grpcClient, PredictionServiceSettings settings)
        {
            GrpcClient = grpcClient;
            PredictionServiceSettings effectiveSettings = settings ?? PredictionServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            BatchPredictOperationsClient = new lro::OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.BatchPredictOperationsSettings);
            _callPredict = clientHelper.BuildApiCall<PredictRequest, PredictResponse>(
                GrpcClient.PredictAsync, GrpcClient.Predict, effectiveSettings.PredictSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callBatchPredict = clientHelper.BuildApiCall<BatchPredictRequest, lro::Operation>(
                GrpcClient.BatchPredictAsync, GrpcClient.BatchPredict, effectiveSettings.BatchPredictSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callPredict);
            Modify_PredictApiCall(ref _callPredict);
            Modify_ApiCall(ref _callBatchPredict);
            Modify_BatchPredictApiCall(ref _callBatchPredict);
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
        partial void Modify_PredictApiCall(ref gaxgrpc::ApiCall<PredictRequest, PredictResponse> call);
        partial void Modify_BatchPredictApiCall(ref gaxgrpc::ApiCall<BatchPredictRequest, lro::Operation> call);
        partial void OnConstruction(PredictionService.PredictionServiceClient grpcClient, PredictionServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC PredictionService client.
        /// </summary>
        public override PredictionService.PredictionServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_PredictRequest(ref PredictRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_BatchPredictRequest(ref BatchPredictRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Perform an online prediction. The prediction result will be directly
        /// returned in the response.
        /// Available for following ML problems, and their expected request payloads:
        /// * Image Classification - Image in .JPEG, .GIF or .PNG format, image_bytes
        ///                          up to 30MB.
        /// * Image Object Detection - Image in .JPEG, .GIF or .PNG format, image_bytes
        ///                            up to 30MB.
        /// * Text Classification - TextSnippet, content up to 60,000 characters,
        ///                         UTF-8 encoded.
        /// * Text Extraction - TextSnippet, content up to 30,000 characters,
        ///                     UTF-8 NFC encoded.
        /// * Translation - TextSnippet, content up to 25,000 characters, UTF-8
        ///                 encoded.
        /// * Text Sentiment - TextSnippet, content up 500 characters, UTF-8
        ///                     encoded.
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
        public override stt::Task<PredictResponse> PredictAsync(
            PredictRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PredictRequest(ref request, ref callSettings);
            return _callPredict.Async(request, callSettings);
        }

        /// <summary>
        /// Perform an online prediction. The prediction result will be directly
        /// returned in the response.
        /// Available for following ML problems, and their expected request payloads:
        /// * Image Classification - Image in .JPEG, .GIF or .PNG format, image_bytes
        ///                          up to 30MB.
        /// * Image Object Detection - Image in .JPEG, .GIF or .PNG format, image_bytes
        ///                            up to 30MB.
        /// * Text Classification - TextSnippet, content up to 60,000 characters,
        ///                         UTF-8 encoded.
        /// * Text Extraction - TextSnippet, content up to 30,000 characters,
        ///                     UTF-8 NFC encoded.
        /// * Translation - TextSnippet, content up to 25,000 characters, UTF-8
        ///                 encoded.
        /// * Text Sentiment - TextSnippet, content up 500 characters, UTF-8
        ///                     encoded.
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
        public override PredictResponse Predict(
            PredictRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PredictRequest(ref request, ref callSettings);
            return _callPredict.Sync(request, callSettings);
        }

        /// <summary>
        /// Perform a batch prediction. Unlike the online
        /// [Predict][google.cloud.automl.v1.PredictionService.Predict], batch
        /// prediction result won't be immediately available in the response. Instead,
        /// a long running operation object is returned. User can poll the operation
        /// result via [GetOperation][google.longrunning.Operations.GetOperation]
        /// method. Once the operation is done,
        /// [BatchPredictResult][google.cloud.automl.v1.BatchPredictResult] is returned
        /// in the [response][google.longrunning.Operation.response] field. Available
        /// for following ML problems:
        /// * Image Classification
        /// * Image Object Detection
        /// * Text Extraction
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
        public override async stt::Task<lro::Operation<BatchPredictResult, OperationMetadata>> BatchPredictAsync(
            BatchPredictRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchPredictRequest(ref request, ref callSettings);
            return new lro::Operation<BatchPredictResult, OperationMetadata>(
                await _callBatchPredict.Async(request, callSettings).ConfigureAwait(false), BatchPredictOperationsClient);
        }

        /// <summary>
        /// Perform a batch prediction. Unlike the online
        /// [Predict][google.cloud.automl.v1.PredictionService.Predict], batch
        /// prediction result won't be immediately available in the response. Instead,
        /// a long running operation object is returned. User can poll the operation
        /// result via [GetOperation][google.longrunning.Operations.GetOperation]
        /// method. Once the operation is done,
        /// [BatchPredictResult][google.cloud.automl.v1.BatchPredictResult] is returned
        /// in the [response][google.longrunning.Operation.response] field. Available
        /// for following ML problems:
        /// * Image Classification
        /// * Image Object Detection
        /// * Text Extraction
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
        public override lro::Operation<BatchPredictResult, OperationMetadata> BatchPredict(
            BatchPredictRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchPredictRequest(ref request, ref callSettings);
            return new lro::Operation<BatchPredictResult, OperationMetadata>(
                _callBatchPredict.Sync(request, callSettings), BatchPredictOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>BatchPredict</c>.
        /// </summary>
        public override lro::OperationsClient BatchPredictOperationsClient { get; }

    }

    // Partial classes to enable page-streaming

    // Partial Grpc class to enable LRO client creation
    public static partial class PredictionService
    {
        public partial class PredictionServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() => new lro::Operations.OperationsClient(CallInvoker);
        }
    }


}
