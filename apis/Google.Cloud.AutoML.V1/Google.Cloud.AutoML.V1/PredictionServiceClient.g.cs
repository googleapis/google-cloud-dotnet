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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PredictSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PredictionServiceClient.BatchPredict</c> and <c>PredictionServiceClient.BatchPredictAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchPredictSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

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

        /// <summary>Creates a new builder with default settings.</summary>
        public PredictionServiceClientBuilder() : base(PredictionServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref PredictionServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<PredictionServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override PredictionServiceClient Build()
        {
            PredictionServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<PredictionServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<PredictionServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private PredictionServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PredictionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<PredictionServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PredictionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => PredictionServiceClient.ChannelPool;
    }

    /// <summary>PredictionService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// AutoML Prediction API.
    /// 
    /// On any input that is documented to expect a string parameter in
    /// snake_case or dash-case, either of those cases is accepted.
    /// </remarks>
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

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(PredictionService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

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
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="PredictionServiceClient"/>.</returns>
        internal static PredictionServiceClient Create(grpccore::CallInvoker callInvoker, PredictionServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            PredictionService.PredictionServiceClient grpcClient = new PredictionService.PredictionServiceClient(callInvoker);
            return new PredictionServiceClientImpl(grpcClient, settings, logger);
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
        /// Perform an online prediction. The prediction result is directly
        /// returned in the response.
        /// Available for following ML scenarios, and their expected request payloads:
        /// 
        /// AutoML Vision Classification
        /// 
        /// * An image in .JPEG, .GIF or .PNG format, image_bytes up to 30MB.
        /// 
        /// AutoML Vision Object Detection
        /// 
        /// * An image in .JPEG, .GIF or .PNG format, image_bytes up to 30MB.
        /// 
        /// AutoML Natural Language Classification
        /// 
        /// * A TextSnippet up to 60,000 characters, UTF-8 encoded or a document in
        /// .PDF, .TIF or .TIFF format with size upto 2MB.
        /// 
        /// AutoML Natural Language Entity Extraction
        /// 
        /// * A TextSnippet up to 10,000 characters, UTF-8 NFC encoded or a document
        /// in .PDF, .TIF or .TIFF format with size upto 20MB.
        /// 
        /// AutoML Natural Language Sentiment Analysis
        /// 
        /// * A TextSnippet up to 60,000 characters, UTF-8 encoded or a document in
        /// .PDF, .TIF or .TIFF format with size upto 2MB.
        /// 
        /// AutoML Translation
        /// 
        /// * A TextSnippet up to 25,000 characters, UTF-8 encoded.
        /// 
        /// AutoML Tables
        /// 
        /// * A row with column values matching
        /// the columns of the model, up to 5MB. Not available for FORECASTING
        /// `prediction_type`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PredictResponse Predict(PredictRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Perform an online prediction. The prediction result is directly
        /// returned in the response.
        /// Available for following ML scenarios, and their expected request payloads:
        /// 
        /// AutoML Vision Classification
        /// 
        /// * An image in .JPEG, .GIF or .PNG format, image_bytes up to 30MB.
        /// 
        /// AutoML Vision Object Detection
        /// 
        /// * An image in .JPEG, .GIF or .PNG format, image_bytes up to 30MB.
        /// 
        /// AutoML Natural Language Classification
        /// 
        /// * A TextSnippet up to 60,000 characters, UTF-8 encoded or a document in
        /// .PDF, .TIF or .TIFF format with size upto 2MB.
        /// 
        /// AutoML Natural Language Entity Extraction
        /// 
        /// * A TextSnippet up to 10,000 characters, UTF-8 NFC encoded or a document
        /// in .PDF, .TIF or .TIFF format with size upto 20MB.
        /// 
        /// AutoML Natural Language Sentiment Analysis
        /// 
        /// * A TextSnippet up to 60,000 characters, UTF-8 encoded or a document in
        /// .PDF, .TIF or .TIFF format with size upto 2MB.
        /// 
        /// AutoML Translation
        /// 
        /// * A TextSnippet up to 25,000 characters, UTF-8 encoded.
        /// 
        /// AutoML Tables
        /// 
        /// * A row with column values matching
        /// the columns of the model, up to 5MB. Not available for FORECASTING
        /// `prediction_type`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PredictResponse> PredictAsync(PredictRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Perform an online prediction. The prediction result is directly
        /// returned in the response.
        /// Available for following ML scenarios, and their expected request payloads:
        /// 
        /// AutoML Vision Classification
        /// 
        /// * An image in .JPEG, .GIF or .PNG format, image_bytes up to 30MB.
        /// 
        /// AutoML Vision Object Detection
        /// 
        /// * An image in .JPEG, .GIF or .PNG format, image_bytes up to 30MB.
        /// 
        /// AutoML Natural Language Classification
        /// 
        /// * A TextSnippet up to 60,000 characters, UTF-8 encoded or a document in
        /// .PDF, .TIF or .TIFF format with size upto 2MB.
        /// 
        /// AutoML Natural Language Entity Extraction
        /// 
        /// * A TextSnippet up to 10,000 characters, UTF-8 NFC encoded or a document
        /// in .PDF, .TIF or .TIFF format with size upto 20MB.
        /// 
        /// AutoML Natural Language Sentiment Analysis
        /// 
        /// * A TextSnippet up to 60,000 characters, UTF-8 encoded or a document in
        /// .PDF, .TIF or .TIFF format with size upto 2MB.
        /// 
        /// AutoML Translation
        /// 
        /// * A TextSnippet up to 25,000 characters, UTF-8 encoded.
        /// 
        /// AutoML Tables
        /// 
        /// * A row with column values matching
        /// the columns of the model, up to 5MB. Not available for FORECASTING
        /// `prediction_type`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PredictResponse> PredictAsync(PredictRequest request, st::CancellationToken cancellationToken) =>
            PredictAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Perform an online prediction. The prediction result is directly
        /// returned in the response.
        /// Available for following ML scenarios, and their expected request payloads:
        /// 
        /// AutoML Vision Classification
        /// 
        /// * An image in .JPEG, .GIF or .PNG format, image_bytes up to 30MB.
        /// 
        /// AutoML Vision Object Detection
        /// 
        /// * An image in .JPEG, .GIF or .PNG format, image_bytes up to 30MB.
        /// 
        /// AutoML Natural Language Classification
        /// 
        /// * A TextSnippet up to 60,000 characters, UTF-8 encoded or a document in
        /// .PDF, .TIF or .TIFF format with size upto 2MB.
        /// 
        /// AutoML Natural Language Entity Extraction
        /// 
        /// * A TextSnippet up to 10,000 characters, UTF-8 NFC encoded or a document
        /// in .PDF, .TIF or .TIFF format with size upto 20MB.
        /// 
        /// AutoML Natural Language Sentiment Analysis
        /// 
        /// * A TextSnippet up to 60,000 characters, UTF-8 encoded or a document in
        /// .PDF, .TIF or .TIFF format with size upto 2MB.
        /// 
        /// AutoML Translation
        /// 
        /// * A TextSnippet up to 25,000 characters, UTF-8 encoded.
        /// 
        /// AutoML Tables
        /// 
        /// * A row with column values matching
        /// the columns of the model, up to 5MB. Not available for FORECASTING
        /// `prediction_type`.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the model requested to serve the prediction.
        /// </param>
        /// <param name="payload">
        /// Required. Payload to perform a prediction on. The payload must match the
        /// problem type that the model was trained to solve.
        /// </param>
        /// <param name="params">
        /// Additional domain-specific parameters, any string must be up to 25000
        /// characters long.
        /// 
        /// AutoML Vision Classification
        /// 
        /// `score_threshold`
        /// : (float) A value from 0.0 to 1.0. When the model
        /// makes predictions for an image, it will only produce results that have
        /// at least this confidence score. The default is 0.5.
        /// 
        /// AutoML Vision Object Detection
        /// 
        /// `score_threshold`
        /// : (float) When Model detects objects on the image,
        /// it will only produce bounding boxes which have at least this
        /// confidence score. Value in 0 to 1 range, default is 0.5.
        /// 
        /// `max_bounding_box_count`
        /// : (int64) The maximum number of bounding
        /// boxes returned. The default is 100. The
        /// number of returned bounding boxes might be limited by the server.
        /// 
        /// AutoML Tables
        /// 
        /// `feature_importance`
        /// : (boolean) Whether
        /// [feature_importance][google.cloud.automl.v1.TablesModelColumnInfo.feature_importance]
        /// is populated in the returned list of
        /// [TablesAnnotation][google.cloud.automl.v1.TablesAnnotation]
        /// objects. The default is false.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PredictResponse Predict(string name, ExamplePayload payload, scg::IDictionary<string, string> @params, gaxgrpc::CallSettings callSettings = null) =>
            Predict(new PredictRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Payload = gax::GaxPreconditions.CheckNotNull(payload, nameof(payload)),
                Params =
                {
                    @params ?? new scg::Dictionary<string, string>(),
                },
            }, callSettings);

        /// <summary>
        /// Perform an online prediction. The prediction result is directly
        /// returned in the response.
        /// Available for following ML scenarios, and their expected request payloads:
        /// 
        /// AutoML Vision Classification
        /// 
        /// * An image in .JPEG, .GIF or .PNG format, image_bytes up to 30MB.
        /// 
        /// AutoML Vision Object Detection
        /// 
        /// * An image in .JPEG, .GIF or .PNG format, image_bytes up to 30MB.
        /// 
        /// AutoML Natural Language Classification
        /// 
        /// * A TextSnippet up to 60,000 characters, UTF-8 encoded or a document in
        /// .PDF, .TIF or .TIFF format with size upto 2MB.
        /// 
        /// AutoML Natural Language Entity Extraction
        /// 
        /// * A TextSnippet up to 10,000 characters, UTF-8 NFC encoded or a document
        /// in .PDF, .TIF or .TIFF format with size upto 20MB.
        /// 
        /// AutoML Natural Language Sentiment Analysis
        /// 
        /// * A TextSnippet up to 60,000 characters, UTF-8 encoded or a document in
        /// .PDF, .TIF or .TIFF format with size upto 2MB.
        /// 
        /// AutoML Translation
        /// 
        /// * A TextSnippet up to 25,000 characters, UTF-8 encoded.
        /// 
        /// AutoML Tables
        /// 
        /// * A row with column values matching
        /// the columns of the model, up to 5MB. Not available for FORECASTING
        /// `prediction_type`.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the model requested to serve the prediction.
        /// </param>
        /// <param name="payload">
        /// Required. Payload to perform a prediction on. The payload must match the
        /// problem type that the model was trained to solve.
        /// </param>
        /// <param name="params">
        /// Additional domain-specific parameters, any string must be up to 25000
        /// characters long.
        /// 
        /// AutoML Vision Classification
        /// 
        /// `score_threshold`
        /// : (float) A value from 0.0 to 1.0. When the model
        /// makes predictions for an image, it will only produce results that have
        /// at least this confidence score. The default is 0.5.
        /// 
        /// AutoML Vision Object Detection
        /// 
        /// `score_threshold`
        /// : (float) When Model detects objects on the image,
        /// it will only produce bounding boxes which have at least this
        /// confidence score. Value in 0 to 1 range, default is 0.5.
        /// 
        /// `max_bounding_box_count`
        /// : (int64) The maximum number of bounding
        /// boxes returned. The default is 100. The
        /// number of returned bounding boxes might be limited by the server.
        /// 
        /// AutoML Tables
        /// 
        /// `feature_importance`
        /// : (boolean) Whether
        /// [feature_importance][google.cloud.automl.v1.TablesModelColumnInfo.feature_importance]
        /// is populated in the returned list of
        /// [TablesAnnotation][google.cloud.automl.v1.TablesAnnotation]
        /// objects. The default is false.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PredictResponse> PredictAsync(string name, ExamplePayload payload, scg::IDictionary<string, string> @params, gaxgrpc::CallSettings callSettings = null) =>
            PredictAsync(new PredictRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Payload = gax::GaxPreconditions.CheckNotNull(payload, nameof(payload)),
                Params =
                {
                    @params ?? new scg::Dictionary<string, string>(),
                },
            }, callSettings);

        /// <summary>
        /// Perform an online prediction. The prediction result is directly
        /// returned in the response.
        /// Available for following ML scenarios, and their expected request payloads:
        /// 
        /// AutoML Vision Classification
        /// 
        /// * An image in .JPEG, .GIF or .PNG format, image_bytes up to 30MB.
        /// 
        /// AutoML Vision Object Detection
        /// 
        /// * An image in .JPEG, .GIF or .PNG format, image_bytes up to 30MB.
        /// 
        /// AutoML Natural Language Classification
        /// 
        /// * A TextSnippet up to 60,000 characters, UTF-8 encoded or a document in
        /// .PDF, .TIF or .TIFF format with size upto 2MB.
        /// 
        /// AutoML Natural Language Entity Extraction
        /// 
        /// * A TextSnippet up to 10,000 characters, UTF-8 NFC encoded or a document
        /// in .PDF, .TIF or .TIFF format with size upto 20MB.
        /// 
        /// AutoML Natural Language Sentiment Analysis
        /// 
        /// * A TextSnippet up to 60,000 characters, UTF-8 encoded or a document in
        /// .PDF, .TIF or .TIFF format with size upto 2MB.
        /// 
        /// AutoML Translation
        /// 
        /// * A TextSnippet up to 25,000 characters, UTF-8 encoded.
        /// 
        /// AutoML Tables
        /// 
        /// * A row with column values matching
        /// the columns of the model, up to 5MB. Not available for FORECASTING
        /// `prediction_type`.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the model requested to serve the prediction.
        /// </param>
        /// <param name="payload">
        /// Required. Payload to perform a prediction on. The payload must match the
        /// problem type that the model was trained to solve.
        /// </param>
        /// <param name="params">
        /// Additional domain-specific parameters, any string must be up to 25000
        /// characters long.
        /// 
        /// AutoML Vision Classification
        /// 
        /// `score_threshold`
        /// : (float) A value from 0.0 to 1.0. When the model
        /// makes predictions for an image, it will only produce results that have
        /// at least this confidence score. The default is 0.5.
        /// 
        /// AutoML Vision Object Detection
        /// 
        /// `score_threshold`
        /// : (float) When Model detects objects on the image,
        /// it will only produce bounding boxes which have at least this
        /// confidence score. Value in 0 to 1 range, default is 0.5.
        /// 
        /// `max_bounding_box_count`
        /// : (int64) The maximum number of bounding
        /// boxes returned. The default is 100. The
        /// number of returned bounding boxes might be limited by the server.
        /// 
        /// AutoML Tables
        /// 
        /// `feature_importance`
        /// : (boolean) Whether
        /// [feature_importance][google.cloud.automl.v1.TablesModelColumnInfo.feature_importance]
        /// is populated in the returned list of
        /// [TablesAnnotation][google.cloud.automl.v1.TablesAnnotation]
        /// objects. The default is false.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PredictResponse> PredictAsync(string name, ExamplePayload payload, scg::IDictionary<string, string> @params, st::CancellationToken cancellationToken) =>
            PredictAsync(name, payload, @params, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Perform an online prediction. The prediction result is directly
        /// returned in the response.
        /// Available for following ML scenarios, and their expected request payloads:
        /// 
        /// AutoML Vision Classification
        /// 
        /// * An image in .JPEG, .GIF or .PNG format, image_bytes up to 30MB.
        /// 
        /// AutoML Vision Object Detection
        /// 
        /// * An image in .JPEG, .GIF or .PNG format, image_bytes up to 30MB.
        /// 
        /// AutoML Natural Language Classification
        /// 
        /// * A TextSnippet up to 60,000 characters, UTF-8 encoded or a document in
        /// .PDF, .TIF or .TIFF format with size upto 2MB.
        /// 
        /// AutoML Natural Language Entity Extraction
        /// 
        /// * A TextSnippet up to 10,000 characters, UTF-8 NFC encoded or a document
        /// in .PDF, .TIF or .TIFF format with size upto 20MB.
        /// 
        /// AutoML Natural Language Sentiment Analysis
        /// 
        /// * A TextSnippet up to 60,000 characters, UTF-8 encoded or a document in
        /// .PDF, .TIF or .TIFF format with size upto 2MB.
        /// 
        /// AutoML Translation
        /// 
        /// * A TextSnippet up to 25,000 characters, UTF-8 encoded.
        /// 
        /// AutoML Tables
        /// 
        /// * A row with column values matching
        /// the columns of the model, up to 5MB. Not available for FORECASTING
        /// `prediction_type`.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the model requested to serve the prediction.
        /// </param>
        /// <param name="payload">
        /// Required. Payload to perform a prediction on. The payload must match the
        /// problem type that the model was trained to solve.
        /// </param>
        /// <param name="params">
        /// Additional domain-specific parameters, any string must be up to 25000
        /// characters long.
        /// 
        /// AutoML Vision Classification
        /// 
        /// `score_threshold`
        /// : (float) A value from 0.0 to 1.0. When the model
        /// makes predictions for an image, it will only produce results that have
        /// at least this confidence score. The default is 0.5.
        /// 
        /// AutoML Vision Object Detection
        /// 
        /// `score_threshold`
        /// : (float) When Model detects objects on the image,
        /// it will only produce bounding boxes which have at least this
        /// confidence score. Value in 0 to 1 range, default is 0.5.
        /// 
        /// `max_bounding_box_count`
        /// : (int64) The maximum number of bounding
        /// boxes returned. The default is 100. The
        /// number of returned bounding boxes might be limited by the server.
        /// 
        /// AutoML Tables
        /// 
        /// `feature_importance`
        /// : (boolean) Whether
        /// [feature_importance][google.cloud.automl.v1.TablesModelColumnInfo.feature_importance]
        /// is populated in the returned list of
        /// [TablesAnnotation][google.cloud.automl.v1.TablesAnnotation]
        /// objects. The default is false.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PredictResponse Predict(ModelName name, ExamplePayload payload, scg::IDictionary<string, string> @params, gaxgrpc::CallSettings callSettings = null) =>
            Predict(new PredictRequest
            {
                ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Payload = gax::GaxPreconditions.CheckNotNull(payload, nameof(payload)),
                Params =
                {
                    @params ?? new scg::Dictionary<string, string>(),
                },
            }, callSettings);

        /// <summary>
        /// Perform an online prediction. The prediction result is directly
        /// returned in the response.
        /// Available for following ML scenarios, and their expected request payloads:
        /// 
        /// AutoML Vision Classification
        /// 
        /// * An image in .JPEG, .GIF or .PNG format, image_bytes up to 30MB.
        /// 
        /// AutoML Vision Object Detection
        /// 
        /// * An image in .JPEG, .GIF or .PNG format, image_bytes up to 30MB.
        /// 
        /// AutoML Natural Language Classification
        /// 
        /// * A TextSnippet up to 60,000 characters, UTF-8 encoded or a document in
        /// .PDF, .TIF or .TIFF format with size upto 2MB.
        /// 
        /// AutoML Natural Language Entity Extraction
        /// 
        /// * A TextSnippet up to 10,000 characters, UTF-8 NFC encoded or a document
        /// in .PDF, .TIF or .TIFF format with size upto 20MB.
        /// 
        /// AutoML Natural Language Sentiment Analysis
        /// 
        /// * A TextSnippet up to 60,000 characters, UTF-8 encoded or a document in
        /// .PDF, .TIF or .TIFF format with size upto 2MB.
        /// 
        /// AutoML Translation
        /// 
        /// * A TextSnippet up to 25,000 characters, UTF-8 encoded.
        /// 
        /// AutoML Tables
        /// 
        /// * A row with column values matching
        /// the columns of the model, up to 5MB. Not available for FORECASTING
        /// `prediction_type`.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the model requested to serve the prediction.
        /// </param>
        /// <param name="payload">
        /// Required. Payload to perform a prediction on. The payload must match the
        /// problem type that the model was trained to solve.
        /// </param>
        /// <param name="params">
        /// Additional domain-specific parameters, any string must be up to 25000
        /// characters long.
        /// 
        /// AutoML Vision Classification
        /// 
        /// `score_threshold`
        /// : (float) A value from 0.0 to 1.0. When the model
        /// makes predictions for an image, it will only produce results that have
        /// at least this confidence score. The default is 0.5.
        /// 
        /// AutoML Vision Object Detection
        /// 
        /// `score_threshold`
        /// : (float) When Model detects objects on the image,
        /// it will only produce bounding boxes which have at least this
        /// confidence score. Value in 0 to 1 range, default is 0.5.
        /// 
        /// `max_bounding_box_count`
        /// : (int64) The maximum number of bounding
        /// boxes returned. The default is 100. The
        /// number of returned bounding boxes might be limited by the server.
        /// 
        /// AutoML Tables
        /// 
        /// `feature_importance`
        /// : (boolean) Whether
        /// [feature_importance][google.cloud.automl.v1.TablesModelColumnInfo.feature_importance]
        /// is populated in the returned list of
        /// [TablesAnnotation][google.cloud.automl.v1.TablesAnnotation]
        /// objects. The default is false.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PredictResponse> PredictAsync(ModelName name, ExamplePayload payload, scg::IDictionary<string, string> @params, gaxgrpc::CallSettings callSettings = null) =>
            PredictAsync(new PredictRequest
            {
                ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Payload = gax::GaxPreconditions.CheckNotNull(payload, nameof(payload)),
                Params =
                {
                    @params ?? new scg::Dictionary<string, string>(),
                },
            }, callSettings);

        /// <summary>
        /// Perform an online prediction. The prediction result is directly
        /// returned in the response.
        /// Available for following ML scenarios, and their expected request payloads:
        /// 
        /// AutoML Vision Classification
        /// 
        /// * An image in .JPEG, .GIF or .PNG format, image_bytes up to 30MB.
        /// 
        /// AutoML Vision Object Detection
        /// 
        /// * An image in .JPEG, .GIF or .PNG format, image_bytes up to 30MB.
        /// 
        /// AutoML Natural Language Classification
        /// 
        /// * A TextSnippet up to 60,000 characters, UTF-8 encoded or a document in
        /// .PDF, .TIF or .TIFF format with size upto 2MB.
        /// 
        /// AutoML Natural Language Entity Extraction
        /// 
        /// * A TextSnippet up to 10,000 characters, UTF-8 NFC encoded or a document
        /// in .PDF, .TIF or .TIFF format with size upto 20MB.
        /// 
        /// AutoML Natural Language Sentiment Analysis
        /// 
        /// * A TextSnippet up to 60,000 characters, UTF-8 encoded or a document in
        /// .PDF, .TIF or .TIFF format with size upto 2MB.
        /// 
        /// AutoML Translation
        /// 
        /// * A TextSnippet up to 25,000 characters, UTF-8 encoded.
        /// 
        /// AutoML Tables
        /// 
        /// * A row with column values matching
        /// the columns of the model, up to 5MB. Not available for FORECASTING
        /// `prediction_type`.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the model requested to serve the prediction.
        /// </param>
        /// <param name="payload">
        /// Required. Payload to perform a prediction on. The payload must match the
        /// problem type that the model was trained to solve.
        /// </param>
        /// <param name="params">
        /// Additional domain-specific parameters, any string must be up to 25000
        /// characters long.
        /// 
        /// AutoML Vision Classification
        /// 
        /// `score_threshold`
        /// : (float) A value from 0.0 to 1.0. When the model
        /// makes predictions for an image, it will only produce results that have
        /// at least this confidence score. The default is 0.5.
        /// 
        /// AutoML Vision Object Detection
        /// 
        /// `score_threshold`
        /// : (float) When Model detects objects on the image,
        /// it will only produce bounding boxes which have at least this
        /// confidence score. Value in 0 to 1 range, default is 0.5.
        /// 
        /// `max_bounding_box_count`
        /// : (int64) The maximum number of bounding
        /// boxes returned. The default is 100. The
        /// number of returned bounding boxes might be limited by the server.
        /// 
        /// AutoML Tables
        /// 
        /// `feature_importance`
        /// : (boolean) Whether
        /// [feature_importance][google.cloud.automl.v1.TablesModelColumnInfo.feature_importance]
        /// is populated in the returned list of
        /// [TablesAnnotation][google.cloud.automl.v1.TablesAnnotation]
        /// objects. The default is false.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PredictResponse> PredictAsync(ModelName name, ExamplePayload payload, scg::IDictionary<string, string> @params, st::CancellationToken cancellationToken) =>
            PredictAsync(name, payload, @params, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Perform a batch prediction. Unlike the online [Predict][google.cloud.automl.v1.PredictionService.Predict], batch
        /// prediction result won't be immediately available in the response. Instead,
        /// a long running operation object is returned. User can poll the operation
        /// result via [GetOperation][google.longrunning.Operations.GetOperation]
        /// method. Once the operation is done, [BatchPredictResult][google.cloud.automl.v1.BatchPredictResult] is returned in
        /// the [response][google.longrunning.Operation.response] field.
        /// Available for following ML scenarios:
        /// 
        /// * AutoML Vision Classification
        /// * AutoML Vision Object Detection
        /// * AutoML Video Intelligence Classification
        /// * AutoML Video Intelligence Object Tracking * AutoML Natural Language Classification
        /// * AutoML Natural Language Entity Extraction
        /// * AutoML Natural Language Sentiment Analysis
        /// * AutoML Tables
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchPredictResult, OperationMetadata> BatchPredict(BatchPredictRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Perform a batch prediction. Unlike the online [Predict][google.cloud.automl.v1.PredictionService.Predict], batch
        /// prediction result won't be immediately available in the response. Instead,
        /// a long running operation object is returned. User can poll the operation
        /// result via [GetOperation][google.longrunning.Operations.GetOperation]
        /// method. Once the operation is done, [BatchPredictResult][google.cloud.automl.v1.BatchPredictResult] is returned in
        /// the [response][google.longrunning.Operation.response] field.
        /// Available for following ML scenarios:
        /// 
        /// * AutoML Vision Classification
        /// * AutoML Vision Object Detection
        /// * AutoML Video Intelligence Classification
        /// * AutoML Video Intelligence Object Tracking * AutoML Natural Language Classification
        /// * AutoML Natural Language Entity Extraction
        /// * AutoML Natural Language Sentiment Analysis
        /// * AutoML Tables
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchPredictResult, OperationMetadata>> BatchPredictAsync(BatchPredictRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Perform a batch prediction. Unlike the online [Predict][google.cloud.automl.v1.PredictionService.Predict], batch
        /// prediction result won't be immediately available in the response. Instead,
        /// a long running operation object is returned. User can poll the operation
        /// result via [GetOperation][google.longrunning.Operations.GetOperation]
        /// method. Once the operation is done, [BatchPredictResult][google.cloud.automl.v1.BatchPredictResult] is returned in
        /// the [response][google.longrunning.Operation.response] field.
        /// Available for following ML scenarios:
        /// 
        /// * AutoML Vision Classification
        /// * AutoML Vision Object Detection
        /// * AutoML Video Intelligence Classification
        /// * AutoML Video Intelligence Object Tracking * AutoML Natural Language Classification
        /// * AutoML Natural Language Entity Extraction
        /// * AutoML Natural Language Sentiment Analysis
        /// * AutoML Tables
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

        /// <summary>
        /// Perform a batch prediction. Unlike the online [Predict][google.cloud.automl.v1.PredictionService.Predict], batch
        /// prediction result won't be immediately available in the response. Instead,
        /// a long running operation object is returned. User can poll the operation
        /// result via [GetOperation][google.longrunning.Operations.GetOperation]
        /// method. Once the operation is done, [BatchPredictResult][google.cloud.automl.v1.BatchPredictResult] is returned in
        /// the [response][google.longrunning.Operation.response] field.
        /// Available for following ML scenarios:
        /// 
        /// * AutoML Vision Classification
        /// * AutoML Vision Object Detection
        /// * AutoML Video Intelligence Classification
        /// * AutoML Video Intelligence Object Tracking * AutoML Natural Language Classification
        /// * AutoML Natural Language Entity Extraction
        /// * AutoML Natural Language Sentiment Analysis
        /// * AutoML Tables
        /// </summary>
        /// <param name="name">
        /// Required. Name of the model requested to serve the batch prediction.
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
        /// AutoML Natural Language Classification
        /// 
        /// `score_threshold`
        /// : (float) A value from 0.0 to 1.0. When the model
        /// makes predictions for a text snippet, it will only produce results
        /// that have at least this confidence score. The default is 0.5.
        /// 
        /// 
        /// AutoML Vision Classification
        /// 
        /// `score_threshold`
        /// : (float) A value from 0.0 to 1.0. When the model
        /// makes predictions for an image, it will only produce results that
        /// have at least this confidence score. The default is 0.5.
        /// 
        /// AutoML Vision Object Detection
        /// 
        /// `score_threshold`
        /// : (float) When Model detects objects on the image,
        /// it will only produce bounding boxes which have at least this
        /// confidence score. Value in 0 to 1 range, default is 0.5.
        /// 
        /// `max_bounding_box_count`
        /// : (int64) The maximum number of bounding
        /// boxes returned per image. The default is 100, the
        /// number of bounding boxes returned might be limited by the server.
        /// AutoML Video Intelligence Classification
        /// 
        /// `score_threshold`
        /// : (float) A value from 0.0 to 1.0. When the model
        /// makes predictions for a video, it will only produce results that
        /// have at least this confidence score. The default is 0.5.
        /// 
        /// `segment_classification`
        /// : (boolean) Set to true to request
        /// segment-level classification. AutoML Video Intelligence returns
        /// labels and their confidence scores for the entire segment of the
        /// video that user specified in the request configuration.
        /// The default is true.
        /// 
        /// `shot_classification`
        /// : (boolean) Set to true to request shot-level
        /// classification. AutoML Video Intelligence determines the boundaries
        /// for each camera shot in the entire segment of the video that user
        /// specified in the request configuration. AutoML Video Intelligence
        /// then returns labels and their confidence scores for each detected
        /// shot, along with the start and end time of the shot.
        /// The default is false.
        /// 
        /// WARNING: Model evaluation is not done for this classification type,
        /// the quality of it depends on training data, but there are no metrics
        /// provided to describe that quality.
        /// 
        /// `1s_interval_classification`
        /// : (boolean) Set to true to request
        /// classification for a video at one-second intervals. AutoML Video
        /// Intelligence returns labels and their confidence scores for each
        /// second of the entire segment of the video that user specified in the
        /// request configuration. The default is false.
        /// 
        /// WARNING: Model evaluation is not done for this classification
        /// type, the quality of it depends on training data, but there are no
        /// metrics provided to describe that quality.
        /// 
        /// AutoML Video Intelligence Object Tracking
        /// 
        /// `score_threshold`
        /// : (float) When Model detects objects on video frames,
        /// it will only produce bounding boxes which have at least this
        /// confidence score. Value in 0 to 1 range, default is 0.5.
        /// 
        /// `max_bounding_box_count`
        /// : (int64) The maximum number of bounding
        /// boxes returned per image. The default is 100, the
        /// number of bounding boxes returned might be limited by the server.
        /// 
        /// `min_bounding_box_size`
        /// : (float) Only bounding boxes with shortest edge
        /// at least that long as a relative value of video frame size are
        /// returned. Value in 0 to 1 range. Default is 0.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchPredictResult, OperationMetadata> BatchPredict(string name, BatchPredictInputConfig inputConfig, BatchPredictOutputConfig outputConfig, scg::IDictionary<string, string> @params, gaxgrpc::CallSettings callSettings = null) =>
            BatchPredict(new BatchPredictRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                InputConfig = gax::GaxPreconditions.CheckNotNull(inputConfig, nameof(inputConfig)),
                OutputConfig = gax::GaxPreconditions.CheckNotNull(outputConfig, nameof(outputConfig)),
                Params =
                {
                    @params ?? new scg::Dictionary<string, string>(),
                },
            }, callSettings);

        /// <summary>
        /// Perform a batch prediction. Unlike the online [Predict][google.cloud.automl.v1.PredictionService.Predict], batch
        /// prediction result won't be immediately available in the response. Instead,
        /// a long running operation object is returned. User can poll the operation
        /// result via [GetOperation][google.longrunning.Operations.GetOperation]
        /// method. Once the operation is done, [BatchPredictResult][google.cloud.automl.v1.BatchPredictResult] is returned in
        /// the [response][google.longrunning.Operation.response] field.
        /// Available for following ML scenarios:
        /// 
        /// * AutoML Vision Classification
        /// * AutoML Vision Object Detection
        /// * AutoML Video Intelligence Classification
        /// * AutoML Video Intelligence Object Tracking * AutoML Natural Language Classification
        /// * AutoML Natural Language Entity Extraction
        /// * AutoML Natural Language Sentiment Analysis
        /// * AutoML Tables
        /// </summary>
        /// <param name="name">
        /// Required. Name of the model requested to serve the batch prediction.
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
        /// AutoML Natural Language Classification
        /// 
        /// `score_threshold`
        /// : (float) A value from 0.0 to 1.0. When the model
        /// makes predictions for a text snippet, it will only produce results
        /// that have at least this confidence score. The default is 0.5.
        /// 
        /// 
        /// AutoML Vision Classification
        /// 
        /// `score_threshold`
        /// : (float) A value from 0.0 to 1.0. When the model
        /// makes predictions for an image, it will only produce results that
        /// have at least this confidence score. The default is 0.5.
        /// 
        /// AutoML Vision Object Detection
        /// 
        /// `score_threshold`
        /// : (float) When Model detects objects on the image,
        /// it will only produce bounding boxes which have at least this
        /// confidence score. Value in 0 to 1 range, default is 0.5.
        /// 
        /// `max_bounding_box_count`
        /// : (int64) The maximum number of bounding
        /// boxes returned per image. The default is 100, the
        /// number of bounding boxes returned might be limited by the server.
        /// AutoML Video Intelligence Classification
        /// 
        /// `score_threshold`
        /// : (float) A value from 0.0 to 1.0. When the model
        /// makes predictions for a video, it will only produce results that
        /// have at least this confidence score. The default is 0.5.
        /// 
        /// `segment_classification`
        /// : (boolean) Set to true to request
        /// segment-level classification. AutoML Video Intelligence returns
        /// labels and their confidence scores for the entire segment of the
        /// video that user specified in the request configuration.
        /// The default is true.
        /// 
        /// `shot_classification`
        /// : (boolean) Set to true to request shot-level
        /// classification. AutoML Video Intelligence determines the boundaries
        /// for each camera shot in the entire segment of the video that user
        /// specified in the request configuration. AutoML Video Intelligence
        /// then returns labels and their confidence scores for each detected
        /// shot, along with the start and end time of the shot.
        /// The default is false.
        /// 
        /// WARNING: Model evaluation is not done for this classification type,
        /// the quality of it depends on training data, but there are no metrics
        /// provided to describe that quality.
        /// 
        /// `1s_interval_classification`
        /// : (boolean) Set to true to request
        /// classification for a video at one-second intervals. AutoML Video
        /// Intelligence returns labels and their confidence scores for each
        /// second of the entire segment of the video that user specified in the
        /// request configuration. The default is false.
        /// 
        /// WARNING: Model evaluation is not done for this classification
        /// type, the quality of it depends on training data, but there are no
        /// metrics provided to describe that quality.
        /// 
        /// AutoML Video Intelligence Object Tracking
        /// 
        /// `score_threshold`
        /// : (float) When Model detects objects on video frames,
        /// it will only produce bounding boxes which have at least this
        /// confidence score. Value in 0 to 1 range, default is 0.5.
        /// 
        /// `max_bounding_box_count`
        /// : (int64) The maximum number of bounding
        /// boxes returned per image. The default is 100, the
        /// number of bounding boxes returned might be limited by the server.
        /// 
        /// `min_bounding_box_size`
        /// : (float) Only bounding boxes with shortest edge
        /// at least that long as a relative value of video frame size are
        /// returned. Value in 0 to 1 range. Default is 0.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchPredictResult, OperationMetadata>> BatchPredictAsync(string name, BatchPredictInputConfig inputConfig, BatchPredictOutputConfig outputConfig, scg::IDictionary<string, string> @params, gaxgrpc::CallSettings callSettings = null) =>
            BatchPredictAsync(new BatchPredictRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                InputConfig = gax::GaxPreconditions.CheckNotNull(inputConfig, nameof(inputConfig)),
                OutputConfig = gax::GaxPreconditions.CheckNotNull(outputConfig, nameof(outputConfig)),
                Params =
                {
                    @params ?? new scg::Dictionary<string, string>(),
                },
            }, callSettings);

        /// <summary>
        /// Perform a batch prediction. Unlike the online [Predict][google.cloud.automl.v1.PredictionService.Predict], batch
        /// prediction result won't be immediately available in the response. Instead,
        /// a long running operation object is returned. User can poll the operation
        /// result via [GetOperation][google.longrunning.Operations.GetOperation]
        /// method. Once the operation is done, [BatchPredictResult][google.cloud.automl.v1.BatchPredictResult] is returned in
        /// the [response][google.longrunning.Operation.response] field.
        /// Available for following ML scenarios:
        /// 
        /// * AutoML Vision Classification
        /// * AutoML Vision Object Detection
        /// * AutoML Video Intelligence Classification
        /// * AutoML Video Intelligence Object Tracking * AutoML Natural Language Classification
        /// * AutoML Natural Language Entity Extraction
        /// * AutoML Natural Language Sentiment Analysis
        /// * AutoML Tables
        /// </summary>
        /// <param name="name">
        /// Required. Name of the model requested to serve the batch prediction.
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
        /// AutoML Natural Language Classification
        /// 
        /// `score_threshold`
        /// : (float) A value from 0.0 to 1.0. When the model
        /// makes predictions for a text snippet, it will only produce results
        /// that have at least this confidence score. The default is 0.5.
        /// 
        /// 
        /// AutoML Vision Classification
        /// 
        /// `score_threshold`
        /// : (float) A value from 0.0 to 1.0. When the model
        /// makes predictions for an image, it will only produce results that
        /// have at least this confidence score. The default is 0.5.
        /// 
        /// AutoML Vision Object Detection
        /// 
        /// `score_threshold`
        /// : (float) When Model detects objects on the image,
        /// it will only produce bounding boxes which have at least this
        /// confidence score. Value in 0 to 1 range, default is 0.5.
        /// 
        /// `max_bounding_box_count`
        /// : (int64) The maximum number of bounding
        /// boxes returned per image. The default is 100, the
        /// number of bounding boxes returned might be limited by the server.
        /// AutoML Video Intelligence Classification
        /// 
        /// `score_threshold`
        /// : (float) A value from 0.0 to 1.0. When the model
        /// makes predictions for a video, it will only produce results that
        /// have at least this confidence score. The default is 0.5.
        /// 
        /// `segment_classification`
        /// : (boolean) Set to true to request
        /// segment-level classification. AutoML Video Intelligence returns
        /// labels and their confidence scores for the entire segment of the
        /// video that user specified in the request configuration.
        /// The default is true.
        /// 
        /// `shot_classification`
        /// : (boolean) Set to true to request shot-level
        /// classification. AutoML Video Intelligence determines the boundaries
        /// for each camera shot in the entire segment of the video that user
        /// specified in the request configuration. AutoML Video Intelligence
        /// then returns labels and their confidence scores for each detected
        /// shot, along with the start and end time of the shot.
        /// The default is false.
        /// 
        /// WARNING: Model evaluation is not done for this classification type,
        /// the quality of it depends on training data, but there are no metrics
        /// provided to describe that quality.
        /// 
        /// `1s_interval_classification`
        /// : (boolean) Set to true to request
        /// classification for a video at one-second intervals. AutoML Video
        /// Intelligence returns labels and their confidence scores for each
        /// second of the entire segment of the video that user specified in the
        /// request configuration. The default is false.
        /// 
        /// WARNING: Model evaluation is not done for this classification
        /// type, the quality of it depends on training data, but there are no
        /// metrics provided to describe that quality.
        /// 
        /// AutoML Video Intelligence Object Tracking
        /// 
        /// `score_threshold`
        /// : (float) When Model detects objects on video frames,
        /// it will only produce bounding boxes which have at least this
        /// confidence score. Value in 0 to 1 range, default is 0.5.
        /// 
        /// `max_bounding_box_count`
        /// : (int64) The maximum number of bounding
        /// boxes returned per image. The default is 100, the
        /// number of bounding boxes returned might be limited by the server.
        /// 
        /// `min_bounding_box_size`
        /// : (float) Only bounding boxes with shortest edge
        /// at least that long as a relative value of video frame size are
        /// returned. Value in 0 to 1 range. Default is 0.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchPredictResult, OperationMetadata>> BatchPredictAsync(string name, BatchPredictInputConfig inputConfig, BatchPredictOutputConfig outputConfig, scg::IDictionary<string, string> @params, st::CancellationToken cancellationToken) =>
            BatchPredictAsync(name, inputConfig, outputConfig, @params, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Perform a batch prediction. Unlike the online [Predict][google.cloud.automl.v1.PredictionService.Predict], batch
        /// prediction result won't be immediately available in the response. Instead,
        /// a long running operation object is returned. User can poll the operation
        /// result via [GetOperation][google.longrunning.Operations.GetOperation]
        /// method. Once the operation is done, [BatchPredictResult][google.cloud.automl.v1.BatchPredictResult] is returned in
        /// the [response][google.longrunning.Operation.response] field.
        /// Available for following ML scenarios:
        /// 
        /// * AutoML Vision Classification
        /// * AutoML Vision Object Detection
        /// * AutoML Video Intelligence Classification
        /// * AutoML Video Intelligence Object Tracking * AutoML Natural Language Classification
        /// * AutoML Natural Language Entity Extraction
        /// * AutoML Natural Language Sentiment Analysis
        /// * AutoML Tables
        /// </summary>
        /// <param name="name">
        /// Required. Name of the model requested to serve the batch prediction.
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
        /// AutoML Natural Language Classification
        /// 
        /// `score_threshold`
        /// : (float) A value from 0.0 to 1.0. When the model
        /// makes predictions for a text snippet, it will only produce results
        /// that have at least this confidence score. The default is 0.5.
        /// 
        /// 
        /// AutoML Vision Classification
        /// 
        /// `score_threshold`
        /// : (float) A value from 0.0 to 1.0. When the model
        /// makes predictions for an image, it will only produce results that
        /// have at least this confidence score. The default is 0.5.
        /// 
        /// AutoML Vision Object Detection
        /// 
        /// `score_threshold`
        /// : (float) When Model detects objects on the image,
        /// it will only produce bounding boxes which have at least this
        /// confidence score. Value in 0 to 1 range, default is 0.5.
        /// 
        /// `max_bounding_box_count`
        /// : (int64) The maximum number of bounding
        /// boxes returned per image. The default is 100, the
        /// number of bounding boxes returned might be limited by the server.
        /// AutoML Video Intelligence Classification
        /// 
        /// `score_threshold`
        /// : (float) A value from 0.0 to 1.0. When the model
        /// makes predictions for a video, it will only produce results that
        /// have at least this confidence score. The default is 0.5.
        /// 
        /// `segment_classification`
        /// : (boolean) Set to true to request
        /// segment-level classification. AutoML Video Intelligence returns
        /// labels and their confidence scores for the entire segment of the
        /// video that user specified in the request configuration.
        /// The default is true.
        /// 
        /// `shot_classification`
        /// : (boolean) Set to true to request shot-level
        /// classification. AutoML Video Intelligence determines the boundaries
        /// for each camera shot in the entire segment of the video that user
        /// specified in the request configuration. AutoML Video Intelligence
        /// then returns labels and their confidence scores for each detected
        /// shot, along with the start and end time of the shot.
        /// The default is false.
        /// 
        /// WARNING: Model evaluation is not done for this classification type,
        /// the quality of it depends on training data, but there are no metrics
        /// provided to describe that quality.
        /// 
        /// `1s_interval_classification`
        /// : (boolean) Set to true to request
        /// classification for a video at one-second intervals. AutoML Video
        /// Intelligence returns labels and their confidence scores for each
        /// second of the entire segment of the video that user specified in the
        /// request configuration. The default is false.
        /// 
        /// WARNING: Model evaluation is not done for this classification
        /// type, the quality of it depends on training data, but there are no
        /// metrics provided to describe that quality.
        /// 
        /// AutoML Video Intelligence Object Tracking
        /// 
        /// `score_threshold`
        /// : (float) When Model detects objects on video frames,
        /// it will only produce bounding boxes which have at least this
        /// confidence score. Value in 0 to 1 range, default is 0.5.
        /// 
        /// `max_bounding_box_count`
        /// : (int64) The maximum number of bounding
        /// boxes returned per image. The default is 100, the
        /// number of bounding boxes returned might be limited by the server.
        /// 
        /// `min_bounding_box_size`
        /// : (float) Only bounding boxes with shortest edge
        /// at least that long as a relative value of video frame size are
        /// returned. Value in 0 to 1 range. Default is 0.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchPredictResult, OperationMetadata> BatchPredict(ModelName name, BatchPredictInputConfig inputConfig, BatchPredictOutputConfig outputConfig, scg::IDictionary<string, string> @params, gaxgrpc::CallSettings callSettings = null) =>
            BatchPredict(new BatchPredictRequest
            {
                ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                InputConfig = gax::GaxPreconditions.CheckNotNull(inputConfig, nameof(inputConfig)),
                OutputConfig = gax::GaxPreconditions.CheckNotNull(outputConfig, nameof(outputConfig)),
                Params =
                {
                    @params ?? new scg::Dictionary<string, string>(),
                },
            }, callSettings);

        /// <summary>
        /// Perform a batch prediction. Unlike the online [Predict][google.cloud.automl.v1.PredictionService.Predict], batch
        /// prediction result won't be immediately available in the response. Instead,
        /// a long running operation object is returned. User can poll the operation
        /// result via [GetOperation][google.longrunning.Operations.GetOperation]
        /// method. Once the operation is done, [BatchPredictResult][google.cloud.automl.v1.BatchPredictResult] is returned in
        /// the [response][google.longrunning.Operation.response] field.
        /// Available for following ML scenarios:
        /// 
        /// * AutoML Vision Classification
        /// * AutoML Vision Object Detection
        /// * AutoML Video Intelligence Classification
        /// * AutoML Video Intelligence Object Tracking * AutoML Natural Language Classification
        /// * AutoML Natural Language Entity Extraction
        /// * AutoML Natural Language Sentiment Analysis
        /// * AutoML Tables
        /// </summary>
        /// <param name="name">
        /// Required. Name of the model requested to serve the batch prediction.
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
        /// AutoML Natural Language Classification
        /// 
        /// `score_threshold`
        /// : (float) A value from 0.0 to 1.0. When the model
        /// makes predictions for a text snippet, it will only produce results
        /// that have at least this confidence score. The default is 0.5.
        /// 
        /// 
        /// AutoML Vision Classification
        /// 
        /// `score_threshold`
        /// : (float) A value from 0.0 to 1.0. When the model
        /// makes predictions for an image, it will only produce results that
        /// have at least this confidence score. The default is 0.5.
        /// 
        /// AutoML Vision Object Detection
        /// 
        /// `score_threshold`
        /// : (float) When Model detects objects on the image,
        /// it will only produce bounding boxes which have at least this
        /// confidence score. Value in 0 to 1 range, default is 0.5.
        /// 
        /// `max_bounding_box_count`
        /// : (int64) The maximum number of bounding
        /// boxes returned per image. The default is 100, the
        /// number of bounding boxes returned might be limited by the server.
        /// AutoML Video Intelligence Classification
        /// 
        /// `score_threshold`
        /// : (float) A value from 0.0 to 1.0. When the model
        /// makes predictions for a video, it will only produce results that
        /// have at least this confidence score. The default is 0.5.
        /// 
        /// `segment_classification`
        /// : (boolean) Set to true to request
        /// segment-level classification. AutoML Video Intelligence returns
        /// labels and their confidence scores for the entire segment of the
        /// video that user specified in the request configuration.
        /// The default is true.
        /// 
        /// `shot_classification`
        /// : (boolean) Set to true to request shot-level
        /// classification. AutoML Video Intelligence determines the boundaries
        /// for each camera shot in the entire segment of the video that user
        /// specified in the request configuration. AutoML Video Intelligence
        /// then returns labels and their confidence scores for each detected
        /// shot, along with the start and end time of the shot.
        /// The default is false.
        /// 
        /// WARNING: Model evaluation is not done for this classification type,
        /// the quality of it depends on training data, but there are no metrics
        /// provided to describe that quality.
        /// 
        /// `1s_interval_classification`
        /// : (boolean) Set to true to request
        /// classification for a video at one-second intervals. AutoML Video
        /// Intelligence returns labels and their confidence scores for each
        /// second of the entire segment of the video that user specified in the
        /// request configuration. The default is false.
        /// 
        /// WARNING: Model evaluation is not done for this classification
        /// type, the quality of it depends on training data, but there are no
        /// metrics provided to describe that quality.
        /// 
        /// AutoML Video Intelligence Object Tracking
        /// 
        /// `score_threshold`
        /// : (float) When Model detects objects on video frames,
        /// it will only produce bounding boxes which have at least this
        /// confidence score. Value in 0 to 1 range, default is 0.5.
        /// 
        /// `max_bounding_box_count`
        /// : (int64) The maximum number of bounding
        /// boxes returned per image. The default is 100, the
        /// number of bounding boxes returned might be limited by the server.
        /// 
        /// `min_bounding_box_size`
        /// : (float) Only bounding boxes with shortest edge
        /// at least that long as a relative value of video frame size are
        /// returned. Value in 0 to 1 range. Default is 0.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchPredictResult, OperationMetadata>> BatchPredictAsync(ModelName name, BatchPredictInputConfig inputConfig, BatchPredictOutputConfig outputConfig, scg::IDictionary<string, string> @params, gaxgrpc::CallSettings callSettings = null) =>
            BatchPredictAsync(new BatchPredictRequest
            {
                ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                InputConfig = gax::GaxPreconditions.CheckNotNull(inputConfig, nameof(inputConfig)),
                OutputConfig = gax::GaxPreconditions.CheckNotNull(outputConfig, nameof(outputConfig)),
                Params =
                {
                    @params ?? new scg::Dictionary<string, string>(),
                },
            }, callSettings);

        /// <summary>
        /// Perform a batch prediction. Unlike the online [Predict][google.cloud.automl.v1.PredictionService.Predict], batch
        /// prediction result won't be immediately available in the response. Instead,
        /// a long running operation object is returned. User can poll the operation
        /// result via [GetOperation][google.longrunning.Operations.GetOperation]
        /// method. Once the operation is done, [BatchPredictResult][google.cloud.automl.v1.BatchPredictResult] is returned in
        /// the [response][google.longrunning.Operation.response] field.
        /// Available for following ML scenarios:
        /// 
        /// * AutoML Vision Classification
        /// * AutoML Vision Object Detection
        /// * AutoML Video Intelligence Classification
        /// * AutoML Video Intelligence Object Tracking * AutoML Natural Language Classification
        /// * AutoML Natural Language Entity Extraction
        /// * AutoML Natural Language Sentiment Analysis
        /// * AutoML Tables
        /// </summary>
        /// <param name="name">
        /// Required. Name of the model requested to serve the batch prediction.
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
        /// AutoML Natural Language Classification
        /// 
        /// `score_threshold`
        /// : (float) A value from 0.0 to 1.0. When the model
        /// makes predictions for a text snippet, it will only produce results
        /// that have at least this confidence score. The default is 0.5.
        /// 
        /// 
        /// AutoML Vision Classification
        /// 
        /// `score_threshold`
        /// : (float) A value from 0.0 to 1.0. When the model
        /// makes predictions for an image, it will only produce results that
        /// have at least this confidence score. The default is 0.5.
        /// 
        /// AutoML Vision Object Detection
        /// 
        /// `score_threshold`
        /// : (float) When Model detects objects on the image,
        /// it will only produce bounding boxes which have at least this
        /// confidence score. Value in 0 to 1 range, default is 0.5.
        /// 
        /// `max_bounding_box_count`
        /// : (int64) The maximum number of bounding
        /// boxes returned per image. The default is 100, the
        /// number of bounding boxes returned might be limited by the server.
        /// AutoML Video Intelligence Classification
        /// 
        /// `score_threshold`
        /// : (float) A value from 0.0 to 1.0. When the model
        /// makes predictions for a video, it will only produce results that
        /// have at least this confidence score. The default is 0.5.
        /// 
        /// `segment_classification`
        /// : (boolean) Set to true to request
        /// segment-level classification. AutoML Video Intelligence returns
        /// labels and their confidence scores for the entire segment of the
        /// video that user specified in the request configuration.
        /// The default is true.
        /// 
        /// `shot_classification`
        /// : (boolean) Set to true to request shot-level
        /// classification. AutoML Video Intelligence determines the boundaries
        /// for each camera shot in the entire segment of the video that user
        /// specified in the request configuration. AutoML Video Intelligence
        /// then returns labels and their confidence scores for each detected
        /// shot, along with the start and end time of the shot.
        /// The default is false.
        /// 
        /// WARNING: Model evaluation is not done for this classification type,
        /// the quality of it depends on training data, but there are no metrics
        /// provided to describe that quality.
        /// 
        /// `1s_interval_classification`
        /// : (boolean) Set to true to request
        /// classification for a video at one-second intervals. AutoML Video
        /// Intelligence returns labels and their confidence scores for each
        /// second of the entire segment of the video that user specified in the
        /// request configuration. The default is false.
        /// 
        /// WARNING: Model evaluation is not done for this classification
        /// type, the quality of it depends on training data, but there are no
        /// metrics provided to describe that quality.
        /// 
        /// AutoML Video Intelligence Object Tracking
        /// 
        /// `score_threshold`
        /// : (float) When Model detects objects on video frames,
        /// it will only produce bounding boxes which have at least this
        /// confidence score. Value in 0 to 1 range, default is 0.5.
        /// 
        /// `max_bounding_box_count`
        /// : (int64) The maximum number of bounding
        /// boxes returned per image. The default is 100, the
        /// number of bounding boxes returned might be limited by the server.
        /// 
        /// `min_bounding_box_size`
        /// : (float) Only bounding boxes with shortest edge
        /// at least that long as a relative value of video frame size are
        /// returned. Value in 0 to 1 range. Default is 0.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchPredictResult, OperationMetadata>> BatchPredictAsync(ModelName name, BatchPredictInputConfig inputConfig, BatchPredictOutputConfig outputConfig, scg::IDictionary<string, string> @params, st::CancellationToken cancellationToken) =>
            BatchPredictAsync(name, inputConfig, outputConfig, @params, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>PredictionService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// AutoML Prediction API.
    /// 
    /// On any input that is documented to expect a string parameter in
    /// snake_case or dash-case, either of those cases is accepted.
    /// </remarks>
    public sealed partial class PredictionServiceClientImpl : PredictionServiceClient
    {
        private readonly gaxgrpc::ApiCall<PredictRequest, PredictResponse> _callPredict;

        private readonly gaxgrpc::ApiCall<BatchPredictRequest, lro::Operation> _callBatchPredict;

        /// <summary>
        /// Constructs a client wrapper for the PredictionService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="PredictionServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public PredictionServiceClientImpl(PredictionService.PredictionServiceClient grpcClient, PredictionServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            PredictionServiceSettings effectiveSettings = settings ?? PredictionServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            BatchPredictOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.BatchPredictOperationsSettings, logger);
            _callPredict = clientHelper.BuildApiCall<PredictRequest, PredictResponse>("Predict", grpcClient.PredictAsync, grpcClient.Predict, effectiveSettings.PredictSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callPredict);
            Modify_PredictApiCall(ref _callPredict);
            _callBatchPredict = clientHelper.BuildApiCall<BatchPredictRequest, lro::Operation>("BatchPredict", grpcClient.BatchPredictAsync, grpcClient.BatchPredict, effectiveSettings.BatchPredictSettings).WithGoogleRequestParam("name", request => request.Name);
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
        /// Perform an online prediction. The prediction result is directly
        /// returned in the response.
        /// Available for following ML scenarios, and their expected request payloads:
        /// 
        /// AutoML Vision Classification
        /// 
        /// * An image in .JPEG, .GIF or .PNG format, image_bytes up to 30MB.
        /// 
        /// AutoML Vision Object Detection
        /// 
        /// * An image in .JPEG, .GIF or .PNG format, image_bytes up to 30MB.
        /// 
        /// AutoML Natural Language Classification
        /// 
        /// * A TextSnippet up to 60,000 characters, UTF-8 encoded or a document in
        /// .PDF, .TIF or .TIFF format with size upto 2MB.
        /// 
        /// AutoML Natural Language Entity Extraction
        /// 
        /// * A TextSnippet up to 10,000 characters, UTF-8 NFC encoded or a document
        /// in .PDF, .TIF or .TIFF format with size upto 20MB.
        /// 
        /// AutoML Natural Language Sentiment Analysis
        /// 
        /// * A TextSnippet up to 60,000 characters, UTF-8 encoded or a document in
        /// .PDF, .TIF or .TIFF format with size upto 2MB.
        /// 
        /// AutoML Translation
        /// 
        /// * A TextSnippet up to 25,000 characters, UTF-8 encoded.
        /// 
        /// AutoML Tables
        /// 
        /// * A row with column values matching
        /// the columns of the model, up to 5MB. Not available for FORECASTING
        /// `prediction_type`.
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
        /// Perform an online prediction. The prediction result is directly
        /// returned in the response.
        /// Available for following ML scenarios, and their expected request payloads:
        /// 
        /// AutoML Vision Classification
        /// 
        /// * An image in .JPEG, .GIF or .PNG format, image_bytes up to 30MB.
        /// 
        /// AutoML Vision Object Detection
        /// 
        /// * An image in .JPEG, .GIF or .PNG format, image_bytes up to 30MB.
        /// 
        /// AutoML Natural Language Classification
        /// 
        /// * A TextSnippet up to 60,000 characters, UTF-8 encoded or a document in
        /// .PDF, .TIF or .TIFF format with size upto 2MB.
        /// 
        /// AutoML Natural Language Entity Extraction
        /// 
        /// * A TextSnippet up to 10,000 characters, UTF-8 NFC encoded or a document
        /// in .PDF, .TIF or .TIFF format with size upto 20MB.
        /// 
        /// AutoML Natural Language Sentiment Analysis
        /// 
        /// * A TextSnippet up to 60,000 characters, UTF-8 encoded or a document in
        /// .PDF, .TIF or .TIFF format with size upto 2MB.
        /// 
        /// AutoML Translation
        /// 
        /// * A TextSnippet up to 25,000 characters, UTF-8 encoded.
        /// 
        /// AutoML Tables
        /// 
        /// * A row with column values matching
        /// the columns of the model, up to 5MB. Not available for FORECASTING
        /// `prediction_type`.
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
        /// Perform a batch prediction. Unlike the online [Predict][google.cloud.automl.v1.PredictionService.Predict], batch
        /// prediction result won't be immediately available in the response. Instead,
        /// a long running operation object is returned. User can poll the operation
        /// result via [GetOperation][google.longrunning.Operations.GetOperation]
        /// method. Once the operation is done, [BatchPredictResult][google.cloud.automl.v1.BatchPredictResult] is returned in
        /// the [response][google.longrunning.Operation.response] field.
        /// Available for following ML scenarios:
        /// 
        /// * AutoML Vision Classification
        /// * AutoML Vision Object Detection
        /// * AutoML Video Intelligence Classification
        /// * AutoML Video Intelligence Object Tracking * AutoML Natural Language Classification
        /// * AutoML Natural Language Entity Extraction
        /// * AutoML Natural Language Sentiment Analysis
        /// * AutoML Tables
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
        /// Perform a batch prediction. Unlike the online [Predict][google.cloud.automl.v1.PredictionService.Predict], batch
        /// prediction result won't be immediately available in the response. Instead,
        /// a long running operation object is returned. User can poll the operation
        /// result via [GetOperation][google.longrunning.Operations.GetOperation]
        /// method. Once the operation is done, [BatchPredictResult][google.cloud.automl.v1.BatchPredictResult] is returned in
        /// the [response][google.longrunning.Operation.response] field.
        /// Available for following ML scenarios:
        /// 
        /// * AutoML Vision Classification
        /// * AutoML Vision Object Detection
        /// * AutoML Video Intelligence Classification
        /// * AutoML Video Intelligence Object Tracking * AutoML Natural Language Classification
        /// * AutoML Natural Language Entity Extraction
        /// * AutoML Natural Language Sentiment Analysis
        /// * AutoML Tables
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
