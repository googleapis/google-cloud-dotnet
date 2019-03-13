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

namespace Google.Cloud.Vision.V1
{
    /// <summary>Settings for a <see cref="ImageAnnotatorClient"/>.</summary>
    public sealed partial class ImageAnnotatorSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ImageAnnotatorSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ImageAnnotatorSettings"/>.</returns>
        public static ImageAnnotatorSettings GetDefault() => new ImageAnnotatorSettings();

        /// <summary>Constructs a new <see cref="ImageAnnotatorSettings"/> object with default settings.</summary>
        public ImageAnnotatorSettings()
        {
        }

        private ImageAnnotatorSettings(ImageAnnotatorSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            BatchAnnotateImagesSettings = existing.BatchAnnotateImagesSettings;
            AsyncBatchAnnotateFilesSettings = existing.AsyncBatchAnnotateFilesSettings;
            AsyncBatchAnnotateFilesOperationsSettings = existing.AsyncBatchAnnotateFilesOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(ImageAnnotatorSettings existing);

        private static readonly gaxgrpc::CallSettings _defaultNonIdempotentCallSettings = gaxgrpc::CallSettings.FromCallTiming(gaxgrpc::CallTiming.FromTimeout(sys::TimeSpan.FromSeconds(20)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ImageAnnotatorClient.BatchAnnotateImages</c> and <c>ImageAnnotatorClient.BatchAnnotateImagesAsync</c>.
        /// </summary>
        /// <remarks>By default, retry will not be attempted.</remarks>
        public gaxgrpc::CallSettings BatchAnnotateImagesSettings { get; set; } = _defaultNonIdempotentCallSettings;

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ImageAnnotatorClient.AsyncBatchAnnotateFiles</c> and <c>ImageAnnotatorClient.AsyncBatchAnnotateFilesAsync</c>
        /// .
        /// </summary>
        /// <remarks>By default, retry will not be attempted.</remarks>
        public gaxgrpc::CallSettings AsyncBatchAnnotateFilesSettings { get; set; } = _defaultNonIdempotentCallSettings;

        /// <summary>
        /// Long Running Operation settings for calls to <c>ImageAnnotatorClient.AsyncBatchAnnotateFiles</c> and
        /// <c>ImageAnnotatorClient.AsyncBatchAnnotateFilesAsync</c>.
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
        public lro::OperationsSettings AsyncBatchAnnotateFilesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ImageAnnotatorSettings"/> object.</returns>
        public ImageAnnotatorSettings Clone() => new ImageAnnotatorSettings(this);
    }

    /// <summary>ImageAnnotator client wrapper, for convenient use.</summary>
    public abstract partial class ImageAnnotatorClient
    {
        /// <summary>
        /// The default endpoint for the ImageAnnotator service, which is a host of "vision.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("vision.googleapis.com", 443);

        /// <summary>The default ImageAnnotator scopes.</summary>
        /// <remarks>
        /// The default ImageAnnotator scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-vision</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-vision",
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="ImageAnnotatorClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where 
        /// necessary. See the example for how to use custom credentials.
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
        /// <param name="settings">Optional <see cref="ImageAnnotatorSettings"/>.</param>
        /// <returns>The task representing the created <see cref="ImageAnnotatorClient"/>.</returns>
        public static async stt::Task<ImageAnnotatorClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, ImageAnnotatorSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="ImageAnnotatorClient"/>, applying defaults for all unspecified settings, 
        /// and creating a channel connecting to the given endpoint with application default credentials where 
        /// necessary. See the example for how to use custom credentials.
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
        /// <param name="settings">Optional <see cref="ImageAnnotatorSettings"/>.</param>
        /// <returns>The created <see cref="ImageAnnotatorClient"/>.</returns>
        public static ImageAnnotatorClient Create(gaxgrpc::ServiceEndpoint endpoint = null, ImageAnnotatorSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="ImageAnnotatorClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="ImageAnnotatorSettings"/>.</param>
        /// <returns>The created <see cref="ImageAnnotatorClient"/>.</returns>
        public static ImageAnnotatorClient Create(grpccore::Channel channel, ImageAnnotatorSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="ImageAnnotatorClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ImageAnnotatorSettings"/>.</param>
        /// <returns>The created <see cref="ImageAnnotatorClient"/>.</returns>
        public static ImageAnnotatorClient Create(grpccore::CallInvoker callInvoker, ImageAnnotatorSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ImageAnnotator.ImageAnnotatorClient grpcClient = new ImageAnnotator.ImageAnnotatorClient(callInvoker);
            return new ImageAnnotatorClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by
        /// <see cref="Create(grpccore::CallInvoker,ImageAnnotatorSettings)"/> and
        /// <see cref="CreateAsync(gaxgrpc::ServiceEndpoint,ImageAnnotatorSettings)"/>. Channels which weren't
        /// automatically created are not affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to
        /// <see cref="Create(grpccore::CallInvoker,ImageAnnotatorSettings)"/> and
        /// <see cref="CreateAsync(gaxgrpc::ServiceEndpoint,ImageAnnotatorSettings)"/> will create new channels, which
        /// could in turn be shut down by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC ImageAnnotator client</summary>
        public virtual ImageAnnotator.ImageAnnotatorClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Run image detection and annotation for a batch of images.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchAnnotateImagesResponse BatchAnnotateImages(BatchAnnotateImagesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Run image detection and annotation for a batch of images.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchAnnotateImagesResponse> BatchAnnotateImagesAsync(BatchAnnotateImagesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Run image detection and annotation for a batch of images.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchAnnotateImagesResponse> BatchAnnotateImagesAsync(BatchAnnotateImagesRequest request, st::CancellationToken cancellationToken) =>
            BatchAnnotateImagesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Run image detection and annotation for a batch of images.
        /// </summary>
        /// <param name="requests">
        /// Individual image annotation requests for this batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchAnnotateImagesResponse BatchAnnotateImages(scg::IEnumerable<AnnotateImageRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchAnnotateImages(new BatchAnnotateImagesRequest
            {
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Run image detection and annotation for a batch of images.
        /// </summary>
        /// <param name="requests">
        /// Individual image annotation requests for this batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchAnnotateImagesResponse> BatchAnnotateImagesAsync(scg::IEnumerable<AnnotateImageRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchAnnotateImagesAsync(new BatchAnnotateImagesRequest
            {
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Run image detection and annotation for a batch of images.
        /// </summary>
        /// <param name="requests">
        /// Individual image annotation requests for this batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchAnnotateImagesResponse> BatchAnnotateImagesAsync(scg::IEnumerable<AnnotateImageRequest> requests, st::CancellationToken cancellationToken) =>
            BatchAnnotateImagesAsync(requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Run asynchronous image detection and annotation for a list of generic
        /// files, such as PDF files, which may contain multiple pages and multiple
        /// images per page. Progress and results can be retrieved through the
        /// `google.longrunning.Operations` interface.
        /// `Operation.metadata` contains `OperationMetadata` (metadata).
        /// `Operation.response` contains `AsyncBatchAnnotateFilesResponse` (results).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AsyncBatchAnnotateFilesResponse, OperationMetadata> AsyncBatchAnnotateFiles(AsyncBatchAnnotateFilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Run asynchronous image detection and annotation for a list of generic
        /// files, such as PDF files, which may contain multiple pages and multiple
        /// images per page. Progress and results can be retrieved through the
        /// `google.longrunning.Operations` interface.
        /// `Operation.metadata` contains `OperationMetadata` (metadata).
        /// `Operation.response` contains `AsyncBatchAnnotateFilesResponse` (results).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AsyncBatchAnnotateFilesResponse, OperationMetadata>> AsyncBatchAnnotateFilesAsync(AsyncBatchAnnotateFilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Run asynchronous image detection and annotation for a list of generic
        /// files, such as PDF files, which may contain multiple pages and multiple
        /// images per page. Progress and results can be retrieved through the
        /// `google.longrunning.Operations` interface.
        /// `Operation.metadata` contains `OperationMetadata` (metadata).
        /// `Operation.response` contains `AsyncBatchAnnotateFilesResponse` (results).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AsyncBatchAnnotateFilesResponse, OperationMetadata>> AsyncBatchAnnotateFilesAsync(AsyncBatchAnnotateFilesRequest request, st::CancellationToken cancellationToken) =>
            AsyncBatchAnnotateFilesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>AsyncBatchAnnotateFiles</c>.</summary>
        public virtual lro::OperationsClient AsyncBatchAnnotateFilesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>AsyncBatchAnnotateFiles</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AsyncBatchAnnotateFilesResponse, OperationMetadata> PollOnceAsyncBatchAnnotateFiles(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AsyncBatchAnnotateFilesResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AsyncBatchAnnotateFilesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>AsyncBatchAnnotateFiles</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AsyncBatchAnnotateFilesResponse, OperationMetadata>> PollOnceAsyncBatchAnnotateFilesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AsyncBatchAnnotateFilesResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AsyncBatchAnnotateFilesOperationsClient, callSettings);

        /// <summary>
        /// Run asynchronous image detection and annotation for a list of generic
        /// files, such as PDF files, which may contain multiple pages and multiple
        /// images per page. Progress and results can be retrieved through the
        /// `google.longrunning.Operations` interface.
        /// `Operation.metadata` contains `OperationMetadata` (metadata).
        /// `Operation.response` contains `AsyncBatchAnnotateFilesResponse` (results).
        /// </summary>
        /// <param name="requests">
        /// Individual async file annotation requests for this batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AsyncBatchAnnotateFilesResponse, OperationMetadata> AsyncBatchAnnotateFiles(scg::IEnumerable<AsyncAnnotateFileRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            AsyncBatchAnnotateFiles(new AsyncBatchAnnotateFilesRequest
            {
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Run asynchronous image detection and annotation for a list of generic
        /// files, such as PDF files, which may contain multiple pages and multiple
        /// images per page. Progress and results can be retrieved through the
        /// `google.longrunning.Operations` interface.
        /// `Operation.metadata` contains `OperationMetadata` (metadata).
        /// `Operation.response` contains `AsyncBatchAnnotateFilesResponse` (results).
        /// </summary>
        /// <param name="requests">
        /// Individual async file annotation requests for this batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AsyncBatchAnnotateFilesResponse, OperationMetadata>> AsyncBatchAnnotateFilesAsync(scg::IEnumerable<AsyncAnnotateFileRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            AsyncBatchAnnotateFilesAsync(new AsyncBatchAnnotateFilesRequest
            {
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Run asynchronous image detection and annotation for a list of generic
        /// files, such as PDF files, which may contain multiple pages and multiple
        /// images per page. Progress and results can be retrieved through the
        /// `google.longrunning.Operations` interface.
        /// `Operation.metadata` contains `OperationMetadata` (metadata).
        /// `Operation.response` contains `AsyncBatchAnnotateFilesResponse` (results).
        /// </summary>
        /// <param name="requests">
        /// Individual async file annotation requests for this batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AsyncBatchAnnotateFilesResponse, OperationMetadata>> AsyncBatchAnnotateFilesAsync(scg::IEnumerable<AsyncAnnotateFileRequest> requests, st::CancellationToken cancellationToken) =>
            AsyncBatchAnnotateFilesAsync(requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ImageAnnotator client wrapper implementation, for convenient use.</summary>
    public sealed partial class ImageAnnotatorClientImpl : ImageAnnotatorClient
    {
        private readonly gaxgrpc::ApiCall<BatchAnnotateImagesRequest, BatchAnnotateImagesResponse> _callBatchAnnotateImages;

        private readonly gaxgrpc::ApiCall<AsyncBatchAnnotateFilesRequest, lro::Operation> _callAsyncBatchAnnotateFiles;

        /// <summary>
        /// Constructs a client wrapper for the ImageAnnotator service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ImageAnnotatorSettings"/> used within this client.</param>
        public ImageAnnotatorClientImpl(ImageAnnotator.ImageAnnotatorClient grpcClient, ImageAnnotatorSettings settings)
        {
            GrpcClient = grpcClient;
            ImageAnnotatorSettings effectiveSettings = settings ?? ImageAnnotatorSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            AsyncBatchAnnotateFilesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.AsyncBatchAnnotateFilesOperationsSettings);
            _callBatchAnnotateImages = clientHelper.BuildApiCall<BatchAnnotateImagesRequest, BatchAnnotateImagesResponse>(grpcClient.BatchAnnotateImagesAsync, grpcClient.BatchAnnotateImages, effectiveSettings.BatchAnnotateImagesSettings);
            Modify_ApiCall(ref _callBatchAnnotateImages);
            Modify_BatchAnnotateImagesApiCall(ref _callBatchAnnotateImages);
            _callAsyncBatchAnnotateFiles = clientHelper.BuildApiCall<AsyncBatchAnnotateFilesRequest, lro::Operation>(grpcClient.AsyncBatchAnnotateFilesAsync, grpcClient.AsyncBatchAnnotateFiles, effectiveSettings.AsyncBatchAnnotateFilesSettings);
            Modify_ApiCall(ref _callAsyncBatchAnnotateFiles);
            Modify_AsyncBatchAnnotateFilesApiCall(ref _callAsyncBatchAnnotateFiles);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_BatchAnnotateImagesApiCall(ref gaxgrpc::ApiCall<BatchAnnotateImagesRequest, BatchAnnotateImagesResponse> call);

        partial void Modify_AsyncBatchAnnotateFilesApiCall(ref gaxgrpc::ApiCall<AsyncBatchAnnotateFilesRequest, lro::Operation> call);

        partial void OnConstruction(ImageAnnotator.ImageAnnotatorClient grpcClient, ImageAnnotatorSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ImageAnnotator client</summary>
        public override ImageAnnotator.ImageAnnotatorClient GrpcClient { get; }

        partial void Modify_BatchAnnotateImagesRequest(ref BatchAnnotateImagesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AsyncBatchAnnotateFilesRequest(ref AsyncBatchAnnotateFilesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Run image detection and annotation for a batch of images.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchAnnotateImagesResponse BatchAnnotateImages(BatchAnnotateImagesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchAnnotateImagesRequest(ref request, ref callSettings);
            return _callBatchAnnotateImages.Sync(request, callSettings);
        }

        /// <summary>
        /// Run image detection and annotation for a batch of images.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchAnnotateImagesResponse> BatchAnnotateImagesAsync(BatchAnnotateImagesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchAnnotateImagesRequest(ref request, ref callSettings);
            return _callBatchAnnotateImages.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>AsyncBatchAnnotateFiles</c>.</summary>
        public override lro::OperationsClient AsyncBatchAnnotateFilesOperationsClient { get; }

        /// <summary>
        /// Run asynchronous image detection and annotation for a list of generic
        /// files, such as PDF files, which may contain multiple pages and multiple
        /// images per page. Progress and results can be retrieved through the
        /// `google.longrunning.Operations` interface.
        /// `Operation.metadata` contains `OperationMetadata` (metadata).
        /// `Operation.response` contains `AsyncBatchAnnotateFilesResponse` (results).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AsyncBatchAnnotateFilesResponse, OperationMetadata> AsyncBatchAnnotateFiles(AsyncBatchAnnotateFilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AsyncBatchAnnotateFilesRequest(ref request, ref callSettings);
            return new lro::Operation<AsyncBatchAnnotateFilesResponse, OperationMetadata>(_callAsyncBatchAnnotateFiles.Sync(request, callSettings), AsyncBatchAnnotateFilesOperationsClient);
        }

        /// <summary>
        /// Run asynchronous image detection and annotation for a list of generic
        /// files, such as PDF files, which may contain multiple pages and multiple
        /// images per page. Progress and results can be retrieved through the
        /// `google.longrunning.Operations` interface.
        /// `Operation.metadata` contains `OperationMetadata` (metadata).
        /// `Operation.response` contains `AsyncBatchAnnotateFilesResponse` (results).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AsyncBatchAnnotateFilesResponse, OperationMetadata>> AsyncBatchAnnotateFilesAsync(AsyncBatchAnnotateFilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AsyncBatchAnnotateFilesRequest(ref request, ref callSettings);
            return new lro::Operation<AsyncBatchAnnotateFilesResponse, OperationMetadata>(await _callAsyncBatchAnnotateFiles.Async(request, callSettings).ConfigureAwait(false), AsyncBatchAnnotateFilesOperationsClient);
        }
    }

    public static partial class ImageAnnotator
    {
        public partial class ImageAnnotatorClient
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
