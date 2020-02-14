// Copyright 2020 Google LLC
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
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.AutoML.V1
{
    /// <summary>Settings for <see cref="PredictionServiceClient"/> instances.</summary>
    public sealed partial class PredictionServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="PredictionServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="PredictionServiceSettings"/>.</returns>
        public static PredictionServiceSettings GetDefault() => new PredictionServiceSettings();

        /// <summary>Constructs a new <see cref="PredictionServiceSettings"/> object with default settings.</summary>
        public PredictionServiceSettings()
        {
        }

        private PredictionServiceSettings(PredictionServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            PredictSettings = existing.PredictSettings;
            BatchPredictSettings = existing.BatchPredictSettings;
            BatchPredictOperationsSettings = existing.BatchPredictOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(PredictionServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PredictionServiceClient.Predict</c> and <c>PredictionServiceClient.PredictAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PredictSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PredictionServiceClient.BatchPredict</c> and <c>PredictionServiceClient.BatchPredictAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchPredictSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>PredictionServiceClient.BatchPredict</c> and
        /// <c>PredictionServiceClient.BatchPredictAsync</c>.
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
        public lro::OperationsSettings BatchPredictOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="PredictionServiceSettings"/> object.</returns>
        public PredictionServiceSettings Clone() => new PredictionServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PredictionServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class PredictionServiceClientBuilder : gaxgrpc::ClientBuilderBase<PredictionServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public PredictionServiceSettings Settings { get; set; }

        /// <inheritdoc/>
        public override PredictionServiceClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PredictionServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc/>
        public override async stt::Task<PredictionServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PredictionServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc/>
        protected override string GetDefaultEndpoint() => PredictionServiceClient.DefaultEndpoint;

        /// <inheritdoc/>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => PredictionServiceClient.DefaultScopes;

        /// <inheritdoc/>
        protected override gaxgrpc::ChannelPool GetChannelPool() => PredictionServiceClient.ChannelPool;

        /// <inheritdoc/>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>PredictionService client wrapper, for convenient use.</summary>
    public abstract partial class PredictionServiceClient
    {
        /// <summary>
        /// The default endpoint for the PredictionService service, which is a host of "automl.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "automl.googleapis.com:443";

        /// <summary>The default PredictionService scopes.</summary>
        /// <remarks>
        /// The default PredictionService scopes are:
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
        /// Asynchronously creates a <see cref="PredictionServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="PredictionServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="PredictionServiceClient"/>.</returns>
        public static stt::Task<PredictionServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new PredictionServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="PredictionServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="PredictionServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="PredictionServiceClient"/>.</returns>
        public static PredictionServiceClient Create() => new PredictionServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="PredictionServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="PredictionServiceSettings"/>.</param>
        /// <returns>The created <see cref="PredictionServiceClient"/>.</returns>
        internal static PredictionServiceClient Create(grpccore::CallInvoker callInvoker, PredictionServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            PredictionService.PredictionServiceClient grpcClient = new PredictionService.PredictionServiceClient(callInvoker);
            return new PredictionServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC PredictionService client</summary>
        public virtual PredictionService.PredictionServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Perform an online prediction. The prediction result will be directly
        /// returned in the response.
        /// Available for following ML problems, and their expected request payloads:
        /// * Image Classification - Image in .JPEG, .GIF or .PNG format, image_bytes
        /// up to 30MB.
        /// * Image Object Detection - Image in .JPEG, .GIF or .PNG format, image_bytes
        /// up to 30MB.
        /// * Text Classification - TextSnippet, content up to 60,000 characters,
        /// UTF-8 encoded.
        /// * Text Extraction - TextSnippet, content up to 30,000 characters,
        /// UTF-8 NFC encoded.
        /// * Translation - TextSnippet, content up to 25,000 characters, UTF-8
        /// encoded.
        /// * Text Sentiment - TextSnippet, content up 500 characters, UTF-8
        /// encoded.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PredictResponse Predict(PredictRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Perform an online prediction. The prediction result will be directly
        /// returned in the response.
        /// Available for following ML problems, and their expected request payloads:
        /// * Image Classification - Image in .JPEG, .GIF or .PNG format, image_bytes
        /// up to 30MB.
        /// * Image Object Detection - Image in .JPEG, .GIF or .PNG format, image_bytes
        /// up to 30MB.
        /// * Text Classification - TextSnippet, content up to 60,000 characters,
        /// UTF-8 encoded.
        /// * Text Extraction - TextSnippet, content up to 30,000 characters,
        /// UTF-8 NFC encoded.
        /// * Translation - TextSnippet, content up to 25,000 characters, UTF-8
        /// encoded.
        /// * Text Sentiment - TextSnippet, content up 500 characters, UTF-8
        /// encoded.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PredictResponse> PredictAsync(PredictRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Perform an online prediction. The prediction result will be directly
        /// returned in the response.
        /// Available for following ML problems, and their expected request payloads:
        /// * Image Classification - Image in .JPEG, .GIF or .PNG format, image_bytes
        /// up to 30MB.
        /// * Image Object Detection - Image in .JPEG, .GIF or .PNG format, image_bytes
        /// up to 30MB.
        /// * Text Classification - TextSnippet, content up to 60,000 characters,
        /// UTF-8 encoded.
        /// * Text Extraction - TextSnippet, content up to 30,000 characters,
        /// UTF-8 NFC encoded.
        /// * Translation - TextSnippet, content up to 25,000 characters, UTF-8
        /// encoded.
        /// * Text Sentiment - TextSnippet, content up 500 characters, UTF-8
        /// encoded.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PredictResponse> PredictAsync(PredictRequest request, st::CancellationToken cancellationToken) =>
            PredictAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchPredictResult, OperationMetadata> BatchPredict(BatchPredictRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

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
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchPredictResult, OperationMetadata>> BatchPredictAsync(BatchPredictRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

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
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchPredictResult, OperationMetadata>> BatchPredictAsync(BatchPredictRequest request, st::CancellationToken cancellationToken) =>
            BatchPredictAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>BatchPredict</c>.</summary>
        public virtual lro::OperationsClient BatchPredictOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchPredict</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BatchPredictResult, OperationMetadata> PollOnceBatchPredict(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchPredictResult, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchPredictOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchPredict</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BatchPredictResult, OperationMetadata>> PollOnceBatchPredictAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchPredictResult, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchPredictOperationsClient, callSettings);
    }

    /// <summary>PredictionService client wrapper implementation, for convenient use.</summary>
    public sealed partial class PredictionServiceClientImpl : PredictionServiceClient
    {
        private readonly gaxgrpc::ApiCall<PredictRequest, PredictResponse> _callPredict;

        private readonly gaxgrpc::ApiCall<BatchPredictRequest, lro::Operation> _callBatchPredict;

        /// <summary>
        /// Constructs a client wrapper for the PredictionService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="PredictionServiceSettings"/> used within this client.</param>
        public PredictionServiceClientImpl(PredictionService.PredictionServiceClient grpcClient, PredictionServiceSettings settings)
        {
            GrpcClient = grpcClient;
            PredictionServiceSettings effectiveSettings = settings ?? PredictionServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            BatchPredictOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.BatchPredictOperationsSettings);
            _callPredict = clientHelper.BuildApiCall<PredictRequest, PredictResponse>(grpcClient.PredictAsync, grpcClient.Predict, effectiveSettings.PredictSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callPredict);
            Modify_PredictApiCall(ref _callPredict);
            _callBatchPredict = clientHelper.BuildApiCall<BatchPredictRequest, lro::Operation>(grpcClient.BatchPredictAsync, grpcClient.BatchPredict, effectiveSettings.BatchPredictSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callBatchPredict);
            Modify_BatchPredictApiCall(ref _callBatchPredict);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_PredictApiCall(ref gaxgrpc::ApiCall<PredictRequest, PredictResponse> call);

        partial void Modify_BatchPredictApiCall(ref gaxgrpc::ApiCall<BatchPredictRequest, lro::Operation> call);

        partial void OnConstruction(PredictionService.PredictionServiceClient grpcClient, PredictionServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC PredictionService client</summary>
        public override PredictionService.PredictionServiceClient GrpcClient { get; }

        partial void Modify_PredictRequest(ref PredictRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchPredictRequest(ref BatchPredictRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Perform an online prediction. The prediction result will be directly
        /// returned in the response.
        /// Available for following ML problems, and their expected request payloads:
        /// * Image Classification - Image in .JPEG, .GIF or .PNG format, image_bytes
        /// up to 30MB.
        /// * Image Object Detection - Image in .JPEG, .GIF or .PNG format, image_bytes
        /// up to 30MB.
        /// * Text Classification - TextSnippet, content up to 60,000 characters,
        /// UTF-8 encoded.
        /// * Text Extraction - TextSnippet, content up to 30,000 characters,
        /// UTF-8 NFC encoded.
        /// * Translation - TextSnippet, content up to 25,000 characters, UTF-8
        /// encoded.
        /// * Text Sentiment - TextSnippet, content up 500 characters, UTF-8
        /// encoded.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PredictResponse Predict(PredictRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PredictRequest(ref request, ref callSettings);
            return _callPredict.Sync(request, callSettings);
        }

        /// <summary>
        /// Perform an online prediction. The prediction result will be directly
        /// returned in the response.
        /// Available for following ML problems, and their expected request payloads:
        /// * Image Classification - Image in .JPEG, .GIF or .PNG format, image_bytes
        /// up to 30MB.
        /// * Image Object Detection - Image in .JPEG, .GIF or .PNG format, image_bytes
        /// up to 30MB.
        /// * Text Classification - TextSnippet, content up to 60,000 characters,
        /// UTF-8 encoded.
        /// * Text Extraction - TextSnippet, content up to 30,000 characters,
        /// UTF-8 NFC encoded.
        /// * Translation - TextSnippet, content up to 25,000 characters, UTF-8
        /// encoded.
        /// * Text Sentiment - TextSnippet, content up 500 characters, UTF-8
        /// encoded.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PredictResponse> PredictAsync(PredictRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PredictRequest(ref request, ref callSettings);
            return _callPredict.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>BatchPredict</c>.</summary>
        public override lro::OperationsClient BatchPredictOperationsClient { get; }

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
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BatchPredictResult, OperationMetadata> BatchPredict(BatchPredictRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchPredictRequest(ref request, ref callSettings);
            return new lro::Operation<BatchPredictResult, OperationMetadata>(_callBatchPredict.Sync(request, callSettings), BatchPredictOperationsClient);
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
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BatchPredictResult, OperationMetadata>> BatchPredictAsync(BatchPredictRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchPredictRequest(ref request, ref callSettings);
            return new lro::Operation<BatchPredictResult, OperationMetadata>(await _callBatchPredict.Async(request, callSettings).ConfigureAwait(false), BatchPredictOperationsClient);
        }
    }

    public static partial class PredictionService
    {
        public partial class PredictionServiceClient
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
