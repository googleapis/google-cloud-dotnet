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

namespace Google.Cloud.VideoIntelligence.V1
{
    /// <summary>Settings for <see cref="VideoIntelligenceServiceClient"/> instances.</summary>
    public sealed partial class VideoIntelligenceServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="VideoIntelligenceServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="VideoIntelligenceServiceSettings"/>.</returns>
        public static VideoIntelligenceServiceSettings GetDefault() => new VideoIntelligenceServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="VideoIntelligenceServiceSettings"/> object with default settings.
        /// </summary>
        public VideoIntelligenceServiceSettings()
        {
        }

        private VideoIntelligenceServiceSettings(VideoIntelligenceServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            AnnotateVideoSettings = existing.AnnotateVideoSettings;
            AnnotateVideoOperationsSettings = existing.AnnotateVideoOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(VideoIntelligenceServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VideoIntelligenceServiceClient.AnnotateVideo</c> and <c>VideoIntelligenceServiceClient.AnnotateVideoAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2.5</description></item>
        /// <item><description>Retry maximum delay: 120000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AnnotateVideoSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(120000), backoffMultiplier: 2.5, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VideoIntelligenceServiceClient.AnnotateVideo</c> and
        /// <c>VideoIntelligenceServiceClient.AnnotateVideoAsync</c>.
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
        public lro::OperationsSettings AnnotateVideoOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="VideoIntelligenceServiceSettings"/> object.</returns>
        public VideoIntelligenceServiceSettings Clone() => new VideoIntelligenceServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="VideoIntelligenceServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class VideoIntelligenceServiceClientBuilder : gaxgrpc::ClientBuilderBase<VideoIntelligenceServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public VideoIntelligenceServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public VideoIntelligenceServiceClientBuilder() : base(VideoIntelligenceServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref VideoIntelligenceServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<VideoIntelligenceServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override VideoIntelligenceServiceClient Build()
        {
            VideoIntelligenceServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<VideoIntelligenceServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<VideoIntelligenceServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private VideoIntelligenceServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return VideoIntelligenceServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<VideoIntelligenceServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return VideoIntelligenceServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => VideoIntelligenceServiceClient.ChannelPool;
    }

    /// <summary>VideoIntelligenceService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service that implements the Video Intelligence API.
    /// </remarks>
    public abstract partial class VideoIntelligenceServiceClient
    {
        /// <summary>
        /// The default endpoint for the VideoIntelligenceService service, which is a host of
        /// "videointelligence.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "videointelligence.googleapis.com:443";

        /// <summary>The default VideoIntelligenceService scopes.</summary>
        /// <remarks>
        /// The default VideoIntelligenceService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(VideoIntelligenceService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="VideoIntelligenceServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="VideoIntelligenceServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="VideoIntelligenceServiceClient"/>.</returns>
        public static stt::Task<VideoIntelligenceServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new VideoIntelligenceServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="VideoIntelligenceServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="VideoIntelligenceServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="VideoIntelligenceServiceClient"/>.</returns>
        public static VideoIntelligenceServiceClient Create() => new VideoIntelligenceServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="VideoIntelligenceServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="VideoIntelligenceServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="VideoIntelligenceServiceClient"/>.</returns>
        internal static VideoIntelligenceServiceClient Create(grpccore::CallInvoker callInvoker, VideoIntelligenceServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            VideoIntelligenceService.VideoIntelligenceServiceClient grpcClient = new VideoIntelligenceService.VideoIntelligenceServiceClient(callInvoker);
            return new VideoIntelligenceServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC VideoIntelligenceService client</summary>
        public virtual VideoIntelligenceService.VideoIntelligenceServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Performs asynchronous video annotation. Progress and results can be
        /// retrieved through the `google.longrunning.Operations` interface.
        /// `Operation.metadata` contains `AnnotateVideoProgress` (progress).
        /// `Operation.response` contains `AnnotateVideoResponse` (results).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AnnotateVideoResponse, AnnotateVideoProgress> AnnotateVideo(AnnotateVideoRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Performs asynchronous video annotation. Progress and results can be
        /// retrieved through the `google.longrunning.Operations` interface.
        /// `Operation.metadata` contains `AnnotateVideoProgress` (progress).
        /// `Operation.response` contains `AnnotateVideoResponse` (results).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AnnotateVideoResponse, AnnotateVideoProgress>> AnnotateVideoAsync(AnnotateVideoRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Performs asynchronous video annotation. Progress and results can be
        /// retrieved through the `google.longrunning.Operations` interface.
        /// `Operation.metadata` contains `AnnotateVideoProgress` (progress).
        /// `Operation.response` contains `AnnotateVideoResponse` (results).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AnnotateVideoResponse, AnnotateVideoProgress>> AnnotateVideoAsync(AnnotateVideoRequest request, st::CancellationToken cancellationToken) =>
            AnnotateVideoAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>AnnotateVideo</c>.</summary>
        public virtual lro::OperationsClient AnnotateVideoOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>AnnotateVideo</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AnnotateVideoResponse, AnnotateVideoProgress> PollOnceAnnotateVideo(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AnnotateVideoResponse, AnnotateVideoProgress>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AnnotateVideoOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>AnnotateVideo</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AnnotateVideoResponse, AnnotateVideoProgress>> PollOnceAnnotateVideoAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AnnotateVideoResponse, AnnotateVideoProgress>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AnnotateVideoOperationsClient, callSettings);

        /// <summary>
        /// Performs asynchronous video annotation. Progress and results can be
        /// retrieved through the `google.longrunning.Operations` interface.
        /// `Operation.metadata` contains `AnnotateVideoProgress` (progress).
        /// `Operation.response` contains `AnnotateVideoResponse` (results).
        /// </summary>
        /// <param name="inputUri">
        /// Input video location. Currently, only
        /// [Cloud Storage](https://cloud.google.com/storage/) URIs are
        /// supported. URIs must be specified in the following format:
        /// `gs://bucket-id/object-id` (other URI formats return
        /// [google.rpc.Code.INVALID_ARGUMENT][google.rpc.Code.INVALID_ARGUMENT]). For
        /// more information, see [Request
        /// URIs](https://cloud.google.com/storage/docs/request-endpoints). To identify
        /// multiple videos, a video URI may include wildcards in the `object-id`.
        /// Supported wildcards: '*' to match 0 or more characters;
        /// '?' to match 1 character. If unset, the input video should be embedded
        /// in the request as `input_content`. If set, `input_content` must be unset.
        /// </param>
        /// <param name="features">
        /// Required. Requested video annotation features.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AnnotateVideoResponse, AnnotateVideoProgress> AnnotateVideo(string inputUri, scg::IEnumerable<Feature> features, gaxgrpc::CallSettings callSettings = null) =>
            AnnotateVideo(new AnnotateVideoRequest
            {
                InputUri = inputUri ?? "",
                Features =
                {
                    gax::GaxPreconditions.CheckNotNull(features, nameof(features)),
                },
            }, callSettings);

        /// <summary>
        /// Performs asynchronous video annotation. Progress and results can be
        /// retrieved through the `google.longrunning.Operations` interface.
        /// `Operation.metadata` contains `AnnotateVideoProgress` (progress).
        /// `Operation.response` contains `AnnotateVideoResponse` (results).
        /// </summary>
        /// <param name="inputUri">
        /// Input video location. Currently, only
        /// [Cloud Storage](https://cloud.google.com/storage/) URIs are
        /// supported. URIs must be specified in the following format:
        /// `gs://bucket-id/object-id` (other URI formats return
        /// [google.rpc.Code.INVALID_ARGUMENT][google.rpc.Code.INVALID_ARGUMENT]). For
        /// more information, see [Request
        /// URIs](https://cloud.google.com/storage/docs/request-endpoints). To identify
        /// multiple videos, a video URI may include wildcards in the `object-id`.
        /// Supported wildcards: '*' to match 0 or more characters;
        /// '?' to match 1 character. If unset, the input video should be embedded
        /// in the request as `input_content`. If set, `input_content` must be unset.
        /// </param>
        /// <param name="features">
        /// Required. Requested video annotation features.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AnnotateVideoResponse, AnnotateVideoProgress>> AnnotateVideoAsync(string inputUri, scg::IEnumerable<Feature> features, gaxgrpc::CallSettings callSettings = null) =>
            AnnotateVideoAsync(new AnnotateVideoRequest
            {
                InputUri = inputUri ?? "",
                Features =
                {
                    gax::GaxPreconditions.CheckNotNull(features, nameof(features)),
                },
            }, callSettings);

        /// <summary>
        /// Performs asynchronous video annotation. Progress and results can be
        /// retrieved through the `google.longrunning.Operations` interface.
        /// `Operation.metadata` contains `AnnotateVideoProgress` (progress).
        /// `Operation.response` contains `AnnotateVideoResponse` (results).
        /// </summary>
        /// <param name="inputUri">
        /// Input video location. Currently, only
        /// [Cloud Storage](https://cloud.google.com/storage/) URIs are
        /// supported. URIs must be specified in the following format:
        /// `gs://bucket-id/object-id` (other URI formats return
        /// [google.rpc.Code.INVALID_ARGUMENT][google.rpc.Code.INVALID_ARGUMENT]). For
        /// more information, see [Request
        /// URIs](https://cloud.google.com/storage/docs/request-endpoints). To identify
        /// multiple videos, a video URI may include wildcards in the `object-id`.
        /// Supported wildcards: '*' to match 0 or more characters;
        /// '?' to match 1 character. If unset, the input video should be embedded
        /// in the request as `input_content`. If set, `input_content` must be unset.
        /// </param>
        /// <param name="features">
        /// Required. Requested video annotation features.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AnnotateVideoResponse, AnnotateVideoProgress>> AnnotateVideoAsync(string inputUri, scg::IEnumerable<Feature> features, st::CancellationToken cancellationToken) =>
            AnnotateVideoAsync(inputUri, features, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>VideoIntelligenceService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service that implements the Video Intelligence API.
    /// </remarks>
    public sealed partial class VideoIntelligenceServiceClientImpl : VideoIntelligenceServiceClient
    {
        private readonly gaxgrpc::ApiCall<AnnotateVideoRequest, lro::Operation> _callAnnotateVideo;

        /// <summary>
        /// Constructs a client wrapper for the VideoIntelligenceService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="VideoIntelligenceServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public VideoIntelligenceServiceClientImpl(VideoIntelligenceService.VideoIntelligenceServiceClient grpcClient, VideoIntelligenceServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            VideoIntelligenceServiceSettings effectiveSettings = settings ?? VideoIntelligenceServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            AnnotateVideoOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.AnnotateVideoOperationsSettings, logger);
            _callAnnotateVideo = clientHelper.BuildApiCall<AnnotateVideoRequest, lro::Operation>("AnnotateVideo", grpcClient.AnnotateVideoAsync, grpcClient.AnnotateVideo, effectiveSettings.AnnotateVideoSettings);
            Modify_ApiCall(ref _callAnnotateVideo);
            Modify_AnnotateVideoApiCall(ref _callAnnotateVideo);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_AnnotateVideoApiCall(ref gaxgrpc::ApiCall<AnnotateVideoRequest, lro::Operation> call);

        partial void OnConstruction(VideoIntelligenceService.VideoIntelligenceServiceClient grpcClient, VideoIntelligenceServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC VideoIntelligenceService client</summary>
        public override VideoIntelligenceService.VideoIntelligenceServiceClient GrpcClient { get; }

        partial void Modify_AnnotateVideoRequest(ref AnnotateVideoRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>AnnotateVideo</c>.</summary>
        public override lro::OperationsClient AnnotateVideoOperationsClient { get; }

        /// <summary>
        /// Performs asynchronous video annotation. Progress and results can be
        /// retrieved through the `google.longrunning.Operations` interface.
        /// `Operation.metadata` contains `AnnotateVideoProgress` (progress).
        /// `Operation.response` contains `AnnotateVideoResponse` (results).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AnnotateVideoResponse, AnnotateVideoProgress> AnnotateVideo(AnnotateVideoRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AnnotateVideoRequest(ref request, ref callSettings);
            return new lro::Operation<AnnotateVideoResponse, AnnotateVideoProgress>(_callAnnotateVideo.Sync(request, callSettings), AnnotateVideoOperationsClient);
        }

        /// <summary>
        /// Performs asynchronous video annotation. Progress and results can be
        /// retrieved through the `google.longrunning.Operations` interface.
        /// `Operation.metadata` contains `AnnotateVideoProgress` (progress).
        /// `Operation.response` contains `AnnotateVideoResponse` (results).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AnnotateVideoResponse, AnnotateVideoProgress>> AnnotateVideoAsync(AnnotateVideoRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AnnotateVideoRequest(ref request, ref callSettings);
            return new lro::Operation<AnnotateVideoResponse, AnnotateVideoProgress>(await _callAnnotateVideo.Async(request, callSettings).ConfigureAwait(false), AnnotateVideoOperationsClient);
        }
    }

    public static partial class VideoIntelligenceService
    {
        public partial class VideoIntelligenceServiceClient
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
