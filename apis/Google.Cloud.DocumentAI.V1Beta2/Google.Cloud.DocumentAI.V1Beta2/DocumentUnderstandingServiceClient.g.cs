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
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.DocumentAI.V1Beta2
{
    /// <summary>Settings for <see cref="DocumentUnderstandingServiceClient"/> instances.</summary>
    public sealed partial class DocumentUnderstandingServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DocumentUnderstandingServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DocumentUnderstandingServiceSettings"/>.</returns>
        public static DocumentUnderstandingServiceSettings GetDefault() => new DocumentUnderstandingServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="DocumentUnderstandingServiceSettings"/> object with default settings.
        /// </summary>
        public DocumentUnderstandingServiceSettings()
        {
        }

        private DocumentUnderstandingServiceSettings(DocumentUnderstandingServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            BatchProcessDocumentsSettings = existing.BatchProcessDocumentsSettings;
            BatchProcessDocumentsOperationsSettings = existing.BatchProcessDocumentsOperationsSettings.Clone();
            ProcessDocumentSettings = existing.ProcessDocumentSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DocumentUnderstandingServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentUnderstandingServiceClient.BatchProcessDocuments</c> and
        /// <c>DocumentUnderstandingServiceClient.BatchProcessDocumentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchProcessDocumentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DocumentUnderstandingServiceClient.BatchProcessDocuments</c>
        /// and <c>DocumentUnderstandingServiceClient.BatchProcessDocumentsAsync</c>.
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
        /// <c>DocumentUnderstandingServiceClient.ProcessDocument</c> and
        /// <c>DocumentUnderstandingServiceClient.ProcessDocumentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ProcessDocumentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DocumentUnderstandingServiceSettings"/> object.</returns>
        public DocumentUnderstandingServiceSettings Clone() => new DocumentUnderstandingServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DocumentUnderstandingServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class DocumentUnderstandingServiceClientBuilder : gaxgrpc::ClientBuilderBase<DocumentUnderstandingServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DocumentUnderstandingServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref DocumentUnderstandingServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DocumentUnderstandingServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DocumentUnderstandingServiceClient Build()
        {
            DocumentUnderstandingServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DocumentUnderstandingServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DocumentUnderstandingServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DocumentUnderstandingServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DocumentUnderstandingServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<DocumentUnderstandingServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DocumentUnderstandingServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => DocumentUnderstandingServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => DocumentUnderstandingServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DocumentUnderstandingServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>DocumentUnderstandingService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to parse structured information from unstructured or semi-structured
    /// documents using state-of-the-art Google AI such as natural language,
    /// computer vision, and translation.
    /// </remarks>
    public abstract partial class DocumentUnderstandingServiceClient
    {
        /// <summary>
        /// The default endpoint for the DocumentUnderstandingService service, which is a host of
        /// "us-documentai.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "us-documentai.googleapis.com:443";

        /// <summary>The default DocumentUnderstandingService scopes.</summary>
        /// <remarks>
        /// The default DocumentUnderstandingService scopes are:
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
        /// Asynchronously creates a <see cref="DocumentUnderstandingServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="DocumentUnderstandingServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DocumentUnderstandingServiceClient"/>.</returns>
        public static stt::Task<DocumentUnderstandingServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DocumentUnderstandingServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DocumentUnderstandingServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="DocumentUnderstandingServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DocumentUnderstandingServiceClient"/>.</returns>
        public static DocumentUnderstandingServiceClient Create() => new DocumentUnderstandingServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DocumentUnderstandingServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DocumentUnderstandingServiceSettings"/>.</param>
        /// <returns>The created <see cref="DocumentUnderstandingServiceClient"/>.</returns>
        internal static DocumentUnderstandingServiceClient Create(grpccore::CallInvoker callInvoker, DocumentUnderstandingServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DocumentUnderstandingService.DocumentUnderstandingServiceClient grpcClient = new DocumentUnderstandingService.DocumentUnderstandingServiceClient(callInvoker);
            return new DocumentUnderstandingServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC DocumentUnderstandingService client</summary>
        public virtual DocumentUnderstandingService.DocumentUnderstandingServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// LRO endpoint to batch process many documents. The output is written
        /// to Cloud Storage as JSON in the [Document] format.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchProcessDocumentsResponse, OperationMetadata> BatchProcessDocuments(BatchProcessDocumentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// LRO endpoint to batch process many documents. The output is written
        /// to Cloud Storage as JSON in the [Document] format.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchProcessDocumentsResponse, OperationMetadata>> BatchProcessDocumentsAsync(BatchProcessDocumentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// LRO endpoint to batch process many documents. The output is written
        /// to Cloud Storage as JSON in the [Document] format.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchProcessDocumentsResponse, OperationMetadata>> BatchProcessDocumentsAsync(BatchProcessDocumentsRequest request, st::CancellationToken cancellationToken) =>
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
        public virtual lro::Operation<BatchProcessDocumentsResponse, OperationMetadata> PollOnceBatchProcessDocuments(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchProcessDocumentsResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchProcessDocumentsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchProcessDocuments</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BatchProcessDocumentsResponse, OperationMetadata>> PollOnceBatchProcessDocumentsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchProcessDocumentsResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchProcessDocumentsOperationsClient, callSettings);

        /// <summary>
        /// LRO endpoint to batch process many documents. The output is written
        /// to Cloud Storage as JSON in the [Document] format.
        /// </summary>
        /// <param name="requests">
        /// Required. Individual requests for each document.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchProcessDocumentsResponse, OperationMetadata> BatchProcessDocuments(scg::IEnumerable<ProcessDocumentRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchProcessDocuments(new BatchProcessDocumentsRequest
            {
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// LRO endpoint to batch process many documents. The output is written
        /// to Cloud Storage as JSON in the [Document] format.
        /// </summary>
        /// <param name="requests">
        /// Required. Individual requests for each document.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchProcessDocumentsResponse, OperationMetadata>> BatchProcessDocumentsAsync(scg::IEnumerable<ProcessDocumentRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchProcessDocumentsAsync(new BatchProcessDocumentsRequest
            {
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// LRO endpoint to batch process many documents. The output is written
        /// to Cloud Storage as JSON in the [Document] format.
        /// </summary>
        /// <param name="requests">
        /// Required. Individual requests for each document.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchProcessDocumentsResponse, OperationMetadata>> BatchProcessDocumentsAsync(scg::IEnumerable<ProcessDocumentRequest> requests, st::CancellationToken cancellationToken) =>
            BatchProcessDocumentsAsync(requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Processes a single document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Document ProcessDocument(ProcessDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Processes a single document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Document> ProcessDocumentAsync(ProcessDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Processes a single document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Document> ProcessDocumentAsync(ProcessDocumentRequest request, st::CancellationToken cancellationToken) =>
            ProcessDocumentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>DocumentUnderstandingService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to parse structured information from unstructured or semi-structured
    /// documents using state-of-the-art Google AI such as natural language,
    /// computer vision, and translation.
    /// </remarks>
    public sealed partial class DocumentUnderstandingServiceClientImpl : DocumentUnderstandingServiceClient
    {
        private readonly gaxgrpc::ApiCall<BatchProcessDocumentsRequest, lro::Operation> _callBatchProcessDocuments;

        private readonly gaxgrpc::ApiCall<ProcessDocumentRequest, Document> _callProcessDocument;

        /// <summary>
        /// Constructs a client wrapper for the DocumentUnderstandingService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="DocumentUnderstandingServiceSettings"/> used within this client.
        /// </param>
        public DocumentUnderstandingServiceClientImpl(DocumentUnderstandingService.DocumentUnderstandingServiceClient grpcClient, DocumentUnderstandingServiceSettings settings)
        {
            GrpcClient = grpcClient;
            DocumentUnderstandingServiceSettings effectiveSettings = settings ?? DocumentUnderstandingServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            BatchProcessDocumentsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.BatchProcessDocumentsOperationsSettings);
            _callBatchProcessDocuments = clientHelper.BuildApiCall<BatchProcessDocumentsRequest, lro::Operation>(grpcClient.BatchProcessDocumentsAsync, grpcClient.BatchProcessDocuments, effectiveSettings.BatchProcessDocumentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchProcessDocuments);
            Modify_BatchProcessDocumentsApiCall(ref _callBatchProcessDocuments);
            _callProcessDocument = clientHelper.BuildApiCall<ProcessDocumentRequest, Document>(grpcClient.ProcessDocumentAsync, grpcClient.ProcessDocument, effectiveSettings.ProcessDocumentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callProcessDocument);
            Modify_ProcessDocumentApiCall(ref _callProcessDocument);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_BatchProcessDocumentsApiCall(ref gaxgrpc::ApiCall<BatchProcessDocumentsRequest, lro::Operation> call);

        partial void Modify_ProcessDocumentApiCall(ref gaxgrpc::ApiCall<ProcessDocumentRequest, Document> call);

        partial void OnConstruction(DocumentUnderstandingService.DocumentUnderstandingServiceClient grpcClient, DocumentUnderstandingServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DocumentUnderstandingService client</summary>
        public override DocumentUnderstandingService.DocumentUnderstandingServiceClient GrpcClient { get; }

        partial void Modify_BatchProcessDocumentsRequest(ref BatchProcessDocumentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ProcessDocumentRequest(ref ProcessDocumentRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>BatchProcessDocuments</c>.</summary>
        public override lro::OperationsClient BatchProcessDocumentsOperationsClient { get; }

        /// <summary>
        /// LRO endpoint to batch process many documents. The output is written
        /// to Cloud Storage as JSON in the [Document] format.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BatchProcessDocumentsResponse, OperationMetadata> BatchProcessDocuments(BatchProcessDocumentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchProcessDocumentsRequest(ref request, ref callSettings);
            return new lro::Operation<BatchProcessDocumentsResponse, OperationMetadata>(_callBatchProcessDocuments.Sync(request, callSettings), BatchProcessDocumentsOperationsClient);
        }

        /// <summary>
        /// LRO endpoint to batch process many documents. The output is written
        /// to Cloud Storage as JSON in the [Document] format.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BatchProcessDocumentsResponse, OperationMetadata>> BatchProcessDocumentsAsync(BatchProcessDocumentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchProcessDocumentsRequest(ref request, ref callSettings);
            return new lro::Operation<BatchProcessDocumentsResponse, OperationMetadata>(await _callBatchProcessDocuments.Async(request, callSettings).ConfigureAwait(false), BatchProcessDocumentsOperationsClient);
        }

        /// <summary>
        /// Processes a single document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Document ProcessDocument(ProcessDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ProcessDocumentRequest(ref request, ref callSettings);
            return _callProcessDocument.Sync(request, callSettings);
        }

        /// <summary>
        /// Processes a single document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Document> ProcessDocumentAsync(ProcessDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ProcessDocumentRequest(ref request, ref callSettings);
            return _callProcessDocument.Async(request, callSettings);
        }
    }

    public static partial class DocumentUnderstandingService
    {
        public partial class DocumentUnderstandingServiceClient
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
