// Copyright 2022 Google LLC
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
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.DocumentAI.V1
{
    /// <summary>Settings for <see cref="DocumentProcessorServiceClient"/> instances.</summary>
    public sealed partial class DocumentProcessorServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DocumentProcessorServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DocumentProcessorServiceSettings"/>.</returns>
        public static DocumentProcessorServiceSettings GetDefault() => new DocumentProcessorServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="DocumentProcessorServiceSettings"/> object with default settings.
        /// </summary>
        public DocumentProcessorServiceSettings()
        {
        }

        private DocumentProcessorServiceSettings(DocumentProcessorServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ProcessDocumentSettings = existing.ProcessDocumentSettings;
            BatchProcessDocumentsSettings = existing.BatchProcessDocumentsSettings;
            BatchProcessDocumentsOperationsSettings = existing.BatchProcessDocumentsOperationsSettings.Clone();
            ReviewDocumentSettings = existing.ReviewDocumentSettings;
            ReviewDocumentOperationsSettings = existing.ReviewDocumentOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(DocumentProcessorServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentProcessorServiceClient.ProcessDocument</c> and
        /// <c>DocumentProcessorServiceClient.ProcessDocumentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ProcessDocumentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentProcessorServiceClient.BatchProcessDocuments</c> and
        /// <c>DocumentProcessorServiceClient.BatchProcessDocumentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchProcessDocumentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DocumentProcessorServiceClient.BatchProcessDocuments</c> and
        /// <c>DocumentProcessorServiceClient.BatchProcessDocumentsAsync</c>.
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
        public lro::OperationsSettings BatchProcessDocumentsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentProcessorServiceClient.ReviewDocument</c> and
        /// <c>DocumentProcessorServiceClient.ReviewDocumentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReviewDocumentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DocumentProcessorServiceClient.ReviewDocument</c> and
        /// <c>DocumentProcessorServiceClient.ReviewDocumentAsync</c>.
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
        public lro::OperationsSettings ReviewDocumentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DocumentProcessorServiceSettings"/> object.</returns>
        public DocumentProcessorServiceSettings Clone() => new DocumentProcessorServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DocumentProcessorServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class DocumentProcessorServiceClientBuilder : gaxgrpc::ClientBuilderBase<DocumentProcessorServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DocumentProcessorServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DocumentProcessorServiceClientBuilder() : base(DocumentProcessorServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DocumentProcessorServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DocumentProcessorServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DocumentProcessorServiceClient Build()
        {
            DocumentProcessorServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DocumentProcessorServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DocumentProcessorServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DocumentProcessorServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DocumentProcessorServiceClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<DocumentProcessorServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DocumentProcessorServiceClient.Create(callInvoker, Settings, Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DocumentProcessorServiceClient.ChannelPool;
    }

    /// <summary>DocumentProcessorService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to call Cloud DocumentAI to process documents according to the
    /// processor's definition. Processors are built using state-of-the-art Google
    /// AI such as natural language, computer vision, and translation to extract
    /// structured information from unstructured or semi-structured documents.
    /// </remarks>
    public abstract partial class DocumentProcessorServiceClient
    {
        /// <summary>
        /// The default endpoint for the DocumentProcessorService service, which is a host of
        /// "documentai.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "documentai.googleapis.com:443";

        /// <summary>The default DocumentProcessorService scopes.</summary>
        /// <remarks>
        /// The default DocumentProcessorService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DocumentProcessorService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DocumentProcessorServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="DocumentProcessorServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DocumentProcessorServiceClient"/>.</returns>
        public static stt::Task<DocumentProcessorServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DocumentProcessorServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DocumentProcessorServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="DocumentProcessorServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DocumentProcessorServiceClient"/>.</returns>
        public static DocumentProcessorServiceClient Create() => new DocumentProcessorServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DocumentProcessorServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DocumentProcessorServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DocumentProcessorServiceClient"/>.</returns>
        internal static DocumentProcessorServiceClient Create(grpccore::CallInvoker callInvoker, DocumentProcessorServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DocumentProcessorService.DocumentProcessorServiceClient grpcClient = new DocumentProcessorService.DocumentProcessorServiceClient(callInvoker);
            return new DocumentProcessorServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DocumentProcessorService client</summary>
        public virtual DocumentProcessorService.DocumentProcessorServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Processes a single document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProcessResponse ProcessDocument(ProcessRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Processes a single document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProcessResponse> ProcessDocumentAsync(ProcessRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Processes a single document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProcessResponse> ProcessDocumentAsync(ProcessRequest request, st::CancellationToken cancellationToken) =>
            ProcessDocumentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Processes a single document.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProcessResponse ProcessDocument(string name, gaxgrpc::CallSettings callSettings = null) =>
            ProcessDocument(new ProcessRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Processes a single document.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProcessResponse> ProcessDocumentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ProcessDocumentAsync(new ProcessRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Processes a single document.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProcessResponse> ProcessDocumentAsync(string name, st::CancellationToken cancellationToken) =>
            ProcessDocumentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Processes a single document.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProcessResponse ProcessDocument(ProcessorName name, gaxgrpc::CallSettings callSettings = null) =>
            ProcessDocument(new ProcessRequest
            {
                ProcessorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Processes a single document.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProcessResponse> ProcessDocumentAsync(ProcessorName name, gaxgrpc::CallSettings callSettings = null) =>
            ProcessDocumentAsync(new ProcessRequest
            {
                ProcessorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Processes a single document.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProcessResponse> ProcessDocumentAsync(ProcessorName name, st::CancellationToken cancellationToken) =>
            ProcessDocumentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// LRO endpoint to batch process many documents. The output is written
        /// to Cloud Storage as JSON in the [Document] format.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchProcessResponse, BatchProcessMetadata> BatchProcessDocuments(BatchProcessRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// LRO endpoint to batch process many documents. The output is written
        /// to Cloud Storage as JSON in the [Document] format.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchProcessResponse, BatchProcessMetadata>> BatchProcessDocumentsAsync(BatchProcessRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// LRO endpoint to batch process many documents. The output is written
        /// to Cloud Storage as JSON in the [Document] format.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchProcessResponse, BatchProcessMetadata>> BatchProcessDocumentsAsync(BatchProcessRequest request, st::CancellationToken cancellationToken) =>
            BatchProcessDocumentsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>BatchProcessDocuments</c>.</summary>
        public virtual lro::OperationsClient BatchProcessDocumentsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchProcessDocuments</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BatchProcessResponse, BatchProcessMetadata> PollOnceBatchProcessDocuments(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchProcessResponse, BatchProcessMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchProcessDocumentsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchProcessDocuments</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BatchProcessResponse, BatchProcessMetadata>> PollOnceBatchProcessDocumentsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchProcessResponse, BatchProcessMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchProcessDocumentsOperationsClient, callSettings);

        /// <summary>
        /// LRO endpoint to batch process many documents. The output is written
        /// to Cloud Storage as JSON in the [Document] format.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchProcessResponse, BatchProcessMetadata> BatchProcessDocuments(string name, gaxgrpc::CallSettings callSettings = null) =>
            BatchProcessDocuments(new BatchProcessRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// LRO endpoint to batch process many documents. The output is written
        /// to Cloud Storage as JSON in the [Document] format.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchProcessResponse, BatchProcessMetadata>> BatchProcessDocumentsAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            BatchProcessDocumentsAsync(new BatchProcessRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// LRO endpoint to batch process many documents. The output is written
        /// to Cloud Storage as JSON in the [Document] format.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchProcessResponse, BatchProcessMetadata>> BatchProcessDocumentsAsync(string name, st::CancellationToken cancellationToken) =>
            BatchProcessDocumentsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// LRO endpoint to batch process many documents. The output is written
        /// to Cloud Storage as JSON in the [Document] format.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchProcessResponse, BatchProcessMetadata> BatchProcessDocuments(ProcessorName name, gaxgrpc::CallSettings callSettings = null) =>
            BatchProcessDocuments(new BatchProcessRequest
            {
                ProcessorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// LRO endpoint to batch process many documents. The output is written
        /// to Cloud Storage as JSON in the [Document] format.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchProcessResponse, BatchProcessMetadata>> BatchProcessDocumentsAsync(ProcessorName name, gaxgrpc::CallSettings callSettings = null) =>
            BatchProcessDocumentsAsync(new BatchProcessRequest
            {
                ProcessorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// LRO endpoint to batch process many documents. The output is written
        /// to Cloud Storage as JSON in the [Document] format.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchProcessResponse, BatchProcessMetadata>> BatchProcessDocumentsAsync(ProcessorName name, st::CancellationToken cancellationToken) =>
            BatchProcessDocumentsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Send a document for Human Review. The input document should be processed by
        /// the specified processor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata> ReviewDocument(ReviewDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Send a document for Human Review. The input document should be processed by
        /// the specified processor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata>> ReviewDocumentAsync(ReviewDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Send a document for Human Review. The input document should be processed by
        /// the specified processor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata>> ReviewDocumentAsync(ReviewDocumentRequest request, st::CancellationToken cancellationToken) =>
            ReviewDocumentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ReviewDocument</c>.</summary>
        public virtual lro::OperationsClient ReviewDocumentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ReviewDocument</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata> PollOnceReviewDocument(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ReviewDocumentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ReviewDocument</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata>> PollOnceReviewDocumentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ReviewDocumentOperationsClient, callSettings);

        /// <summary>
        /// Send a document for Human Review. The input document should be processed by
        /// the specified processor.
        /// </summary>
        /// <param name="humanReviewConfig">
        /// Required. The resource name of the HumanReviewConfig that the document will be
        /// reviewed with.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata> ReviewDocument(string humanReviewConfig, gaxgrpc::CallSettings callSettings = null) =>
            ReviewDocument(new ReviewDocumentRequest
            {
                HumanReviewConfig = gax::GaxPreconditions.CheckNotNullOrEmpty(humanReviewConfig, nameof(humanReviewConfig)),
            }, callSettings);

        /// <summary>
        /// Send a document for Human Review. The input document should be processed by
        /// the specified processor.
        /// </summary>
        /// <param name="humanReviewConfig">
        /// Required. The resource name of the HumanReviewConfig that the document will be
        /// reviewed with.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata>> ReviewDocumentAsync(string humanReviewConfig, gaxgrpc::CallSettings callSettings = null) =>
            ReviewDocumentAsync(new ReviewDocumentRequest
            {
                HumanReviewConfig = gax::GaxPreconditions.CheckNotNullOrEmpty(humanReviewConfig, nameof(humanReviewConfig)),
            }, callSettings);

        /// <summary>
        /// Send a document for Human Review. The input document should be processed by
        /// the specified processor.
        /// </summary>
        /// <param name="humanReviewConfig">
        /// Required. The resource name of the HumanReviewConfig that the document will be
        /// reviewed with.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata>> ReviewDocumentAsync(string humanReviewConfig, st::CancellationToken cancellationToken) =>
            ReviewDocumentAsync(humanReviewConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Send a document for Human Review. The input document should be processed by
        /// the specified processor.
        /// </summary>
        /// <param name="humanReviewConfig">
        /// Required. The resource name of the HumanReviewConfig that the document will be
        /// reviewed with.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata> ReviewDocument(HumanReviewConfigName humanReviewConfig, gaxgrpc::CallSettings callSettings = null) =>
            ReviewDocument(new ReviewDocumentRequest
            {
                HumanReviewConfigAsHumanReviewConfigName = gax::GaxPreconditions.CheckNotNull(humanReviewConfig, nameof(humanReviewConfig)),
            }, callSettings);

        /// <summary>
        /// Send a document for Human Review. The input document should be processed by
        /// the specified processor.
        /// </summary>
        /// <param name="humanReviewConfig">
        /// Required. The resource name of the HumanReviewConfig that the document will be
        /// reviewed with.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata>> ReviewDocumentAsync(HumanReviewConfigName humanReviewConfig, gaxgrpc::CallSettings callSettings = null) =>
            ReviewDocumentAsync(new ReviewDocumentRequest
            {
                HumanReviewConfigAsHumanReviewConfigName = gax::GaxPreconditions.CheckNotNull(humanReviewConfig, nameof(humanReviewConfig)),
            }, callSettings);

        /// <summary>
        /// Send a document for Human Review. The input document should be processed by
        /// the specified processor.
        /// </summary>
        /// <param name="humanReviewConfig">
        /// Required. The resource name of the HumanReviewConfig that the document will be
        /// reviewed with.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata>> ReviewDocumentAsync(HumanReviewConfigName humanReviewConfig, st::CancellationToken cancellationToken) =>
            ReviewDocumentAsync(humanReviewConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>DocumentProcessorService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to call Cloud DocumentAI to process documents according to the
    /// processor's definition. Processors are built using state-of-the-art Google
    /// AI such as natural language, computer vision, and translation to extract
    /// structured information from unstructured or semi-structured documents.
    /// </remarks>
    public sealed partial class DocumentProcessorServiceClientImpl : DocumentProcessorServiceClient
    {
        private readonly gaxgrpc::ApiCall<ProcessRequest, ProcessResponse> _callProcessDocument;

        private readonly gaxgrpc::ApiCall<BatchProcessRequest, lro::Operation> _callBatchProcessDocuments;

        private readonly gaxgrpc::ApiCall<ReviewDocumentRequest, lro::Operation> _callReviewDocument;

        /// <summary>
        /// Constructs a client wrapper for the DocumentProcessorService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="DocumentProcessorServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DocumentProcessorServiceClientImpl(DocumentProcessorService.DocumentProcessorServiceClient grpcClient, DocumentProcessorServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DocumentProcessorServiceSettings effectiveSettings = settings ?? DocumentProcessorServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            BatchProcessDocumentsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.BatchProcessDocumentsOperationsSettings, logger);
            ReviewDocumentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ReviewDocumentOperationsSettings, logger);
            _callProcessDocument = clientHelper.BuildApiCall<ProcessRequest, ProcessResponse>("ProcessDocument", grpcClient.ProcessDocumentAsync, grpcClient.ProcessDocument, effectiveSettings.ProcessDocumentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callProcessDocument);
            Modify_ProcessDocumentApiCall(ref _callProcessDocument);
            _callBatchProcessDocuments = clientHelper.BuildApiCall<BatchProcessRequest, lro::Operation>("BatchProcessDocuments", grpcClient.BatchProcessDocumentsAsync, grpcClient.BatchProcessDocuments, effectiveSettings.BatchProcessDocumentsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callBatchProcessDocuments);
            Modify_BatchProcessDocumentsApiCall(ref _callBatchProcessDocuments);
            _callReviewDocument = clientHelper.BuildApiCall<ReviewDocumentRequest, lro::Operation>("ReviewDocument", grpcClient.ReviewDocumentAsync, grpcClient.ReviewDocument, effectiveSettings.ReviewDocumentSettings).WithGoogleRequestParam("human_review_config", request => request.HumanReviewConfig);
            Modify_ApiCall(ref _callReviewDocument);
            Modify_ReviewDocumentApiCall(ref _callReviewDocument);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ProcessDocumentApiCall(ref gaxgrpc::ApiCall<ProcessRequest, ProcessResponse> call);

        partial void Modify_BatchProcessDocumentsApiCall(ref gaxgrpc::ApiCall<BatchProcessRequest, lro::Operation> call);

        partial void Modify_ReviewDocumentApiCall(ref gaxgrpc::ApiCall<ReviewDocumentRequest, lro::Operation> call);

        partial void OnConstruction(DocumentProcessorService.DocumentProcessorServiceClient grpcClient, DocumentProcessorServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DocumentProcessorService client</summary>
        public override DocumentProcessorService.DocumentProcessorServiceClient GrpcClient { get; }

        partial void Modify_ProcessRequest(ref ProcessRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchProcessRequest(ref BatchProcessRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReviewDocumentRequest(ref ReviewDocumentRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Processes a single document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ProcessResponse ProcessDocument(ProcessRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ProcessRequest(ref request, ref callSettings);
            return _callProcessDocument.Sync(request, callSettings);
        }

        /// <summary>
        /// Processes a single document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ProcessResponse> ProcessDocumentAsync(ProcessRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ProcessRequest(ref request, ref callSettings);
            return _callProcessDocument.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>BatchProcessDocuments</c>.</summary>
        public override lro::OperationsClient BatchProcessDocumentsOperationsClient { get; }

        /// <summary>
        /// LRO endpoint to batch process many documents. The output is written
        /// to Cloud Storage as JSON in the [Document] format.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BatchProcessResponse, BatchProcessMetadata> BatchProcessDocuments(BatchProcessRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchProcessRequest(ref request, ref callSettings);
            return new lro::Operation<BatchProcessResponse, BatchProcessMetadata>(_callBatchProcessDocuments.Sync(request, callSettings), BatchProcessDocumentsOperationsClient);
        }

        /// <summary>
        /// LRO endpoint to batch process many documents. The output is written
        /// to Cloud Storage as JSON in the [Document] format.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BatchProcessResponse, BatchProcessMetadata>> BatchProcessDocumentsAsync(BatchProcessRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchProcessRequest(ref request, ref callSettings);
            return new lro::Operation<BatchProcessResponse, BatchProcessMetadata>(await _callBatchProcessDocuments.Async(request, callSettings).ConfigureAwait(false), BatchProcessDocumentsOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ReviewDocument</c>.</summary>
        public override lro::OperationsClient ReviewDocumentOperationsClient { get; }

        /// <summary>
        /// Send a document for Human Review. The input document should be processed by
        /// the specified processor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata> ReviewDocument(ReviewDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReviewDocumentRequest(ref request, ref callSettings);
            return new lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata>(_callReviewDocument.Sync(request, callSettings), ReviewDocumentOperationsClient);
        }

        /// <summary>
        /// Send a document for Human Review. The input document should be processed by
        /// the specified processor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata>> ReviewDocumentAsync(ReviewDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReviewDocumentRequest(ref request, ref callSettings);
            return new lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata>(await _callReviewDocument.Async(request, callSettings).ConfigureAwait(false), ReviewDocumentOperationsClient);
        }
    }

    public static partial class DocumentProcessorService
    {
        public partial class DocumentProcessorServiceClient
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
