// Copyright 2026 Google LLC
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
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Developers.Knowledge.V1
{
    /// <summary>Settings for <see cref="DeveloperKnowledgeClient"/> instances.</summary>
    public sealed partial class DeveloperKnowledgeSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DeveloperKnowledgeSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DeveloperKnowledgeSettings"/>.</returns>
        public static DeveloperKnowledgeSettings GetDefault() => new DeveloperKnowledgeSettings();

        /// <summary>Constructs a new <see cref="DeveloperKnowledgeSettings"/> object with default settings.</summary>
        public DeveloperKnowledgeSettings()
        {
        }

        private DeveloperKnowledgeSettings(DeveloperKnowledgeSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            SearchDocumentChunksSettings = existing.SearchDocumentChunksSettings;
            GetDocumentSettings = existing.GetDocumentSettings;
            BatchGetDocumentsSettings = existing.BatchGetDocumentsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DeveloperKnowledgeSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeveloperKnowledgeClient.SearchDocumentChunks</c> and
        /// <c>DeveloperKnowledgeClient.SearchDocumentChunksAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchDocumentChunksSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeveloperKnowledgeClient.GetDocument</c> and <c>DeveloperKnowledgeClient.GetDocumentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDocumentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeveloperKnowledgeClient.BatchGetDocuments</c> and <c>DeveloperKnowledgeClient.BatchGetDocumentsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchGetDocumentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DeveloperKnowledgeSettings"/> object.</returns>
        public DeveloperKnowledgeSettings Clone() => new DeveloperKnowledgeSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DeveloperKnowledgeClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class DeveloperKnowledgeClientBuilder : gaxgrpc::ClientBuilderBase<DeveloperKnowledgeClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DeveloperKnowledgeSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DeveloperKnowledgeClientBuilder() : base(DeveloperKnowledgeClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DeveloperKnowledgeClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DeveloperKnowledgeClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DeveloperKnowledgeClient Build()
        {
            DeveloperKnowledgeClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DeveloperKnowledgeClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DeveloperKnowledgeClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DeveloperKnowledgeClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DeveloperKnowledgeClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DeveloperKnowledgeClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DeveloperKnowledgeClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DeveloperKnowledgeClient.ChannelPool;
    }

    /// <summary>DeveloperKnowledge client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The Developer Knowledge API provides programmatic access to Google's public
    /// developer documentation, enabling you to integrate this knowledge base into
    /// your own applications and workflows.
    /// 
    /// The API is designed to be the canonical source for machine-readable access to
    /// Google's developer documentation.
    /// 
    /// A typical use case is to first use
    /// [DeveloperKnowledge.SearchDocumentChunks][google.developers.knowledge.v1.DeveloperKnowledge.SearchDocumentChunks]
    /// to find relevant page URIs based on a query, and then use
    /// [DeveloperKnowledge.GetDocument][google.developers.knowledge.v1.DeveloperKnowledge.GetDocument]
    /// or
    /// [DeveloperKnowledge.BatchGetDocuments][google.developers.knowledge.v1.DeveloperKnowledge.BatchGetDocuments]
    /// to fetch the full content of the top results.
    /// 
    /// All document content is provided in Markdown format.
    /// </remarks>
    public abstract partial class DeveloperKnowledgeClient
    {
        /// <summary>
        /// The default endpoint for the DeveloperKnowledge service, which is a host of
        /// "developerknowledge.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "developerknowledge.googleapis.com:443";

        /// <summary>The default DeveloperKnowledge scopes.</summary>
        /// <remarks>
        /// The default DeveloperKnowledge scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DeveloperKnowledge.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DeveloperKnowledgeClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DeveloperKnowledgeClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DeveloperKnowledgeClient"/>.</returns>
        public static stt::Task<DeveloperKnowledgeClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DeveloperKnowledgeClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DeveloperKnowledgeClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DeveloperKnowledgeClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="DeveloperKnowledgeClient"/>.</returns>
        public static DeveloperKnowledgeClient Create() => new DeveloperKnowledgeClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DeveloperKnowledgeClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DeveloperKnowledgeSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DeveloperKnowledgeClient"/>.</returns>
        internal static DeveloperKnowledgeClient Create(grpccore::CallInvoker callInvoker, DeveloperKnowledgeSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DeveloperKnowledge.DeveloperKnowledgeClient grpcClient = new DeveloperKnowledge.DeveloperKnowledgeClient(callInvoker);
            return new DeveloperKnowledgeClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DeveloperKnowledge client</summary>
        public virtual DeveloperKnowledge.DeveloperKnowledgeClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Searches for developer knowledge across Google's developer documentation.
        /// Returns [DocumentChunk][google.developers.knowledge.v1.DocumentChunk]s
        /// based on the user's query. There may be many chunks from the same
        /// [Document][google.developers.knowledge.v1.Document].  To retrieve full
        /// documents, use
        /// [DeveloperKnowledge.GetDocument][google.developers.knowledge.v1.DeveloperKnowledge.GetDocument]
        /// or
        /// [DeveloperKnowledge.BatchGetDocuments][google.developers.knowledge.v1.DeveloperKnowledge.BatchGetDocuments]
        /// with the
        /// [DocumentChunk.parent][google.developers.knowledge.v1.DocumentChunk.parent]
        /// returned in the
        /// [SearchDocumentChunksResponse.results][google.developers.knowledge.v1.SearchDocumentChunksResponse.results].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DocumentChunk"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchDocumentChunksResponse, DocumentChunk> SearchDocumentChunks(SearchDocumentChunksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches for developer knowledge across Google's developer documentation.
        /// Returns [DocumentChunk][google.developers.knowledge.v1.DocumentChunk]s
        /// based on the user's query. There may be many chunks from the same
        /// [Document][google.developers.knowledge.v1.Document].  To retrieve full
        /// documents, use
        /// [DeveloperKnowledge.GetDocument][google.developers.knowledge.v1.DeveloperKnowledge.GetDocument]
        /// or
        /// [DeveloperKnowledge.BatchGetDocuments][google.developers.knowledge.v1.DeveloperKnowledge.BatchGetDocuments]
        /// with the
        /// [DocumentChunk.parent][google.developers.knowledge.v1.DocumentChunk.parent]
        /// returned in the
        /// [SearchDocumentChunksResponse.results][google.developers.knowledge.v1.SearchDocumentChunksResponse.results].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DocumentChunk"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchDocumentChunksResponse, DocumentChunk> SearchDocumentChunksAsync(SearchDocumentChunksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a single document with its full Markdown content.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Document GetDocument(GetDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a single document with its full Markdown content.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Document> GetDocumentAsync(GetDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a single document with its full Markdown content.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Document> GetDocumentAsync(GetDocumentRequest request, st::CancellationToken cancellationToken) =>
            GetDocumentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a single document with its full Markdown content.
        /// </summary>
        /// <param name="name">
        /// Required. Specifies the name of the document to retrieve.
        /// Format: `documents/{uri_without_scheme}`
        /// Example: `documents/docs.cloud.google.com/storage/docs/creating-buckets`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Document GetDocument(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDocument(new GetDocumentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a single document with its full Markdown content.
        /// </summary>
        /// <param name="name">
        /// Required. Specifies the name of the document to retrieve.
        /// Format: `documents/{uri_without_scheme}`
        /// Example: `documents/docs.cloud.google.com/storage/docs/creating-buckets`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Document> GetDocumentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDocumentAsync(new GetDocumentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a single document with its full Markdown content.
        /// </summary>
        /// <param name="name">
        /// Required. Specifies the name of the document to retrieve.
        /// Format: `documents/{uri_without_scheme}`
        /// Example: `documents/docs.cloud.google.com/storage/docs/creating-buckets`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Document> GetDocumentAsync(string name, st::CancellationToken cancellationToken) =>
            GetDocumentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a single document with its full Markdown content.
        /// </summary>
        /// <param name="name">
        /// Required. Specifies the name of the document to retrieve.
        /// Format: `documents/{uri_without_scheme}`
        /// Example: `documents/docs.cloud.google.com/storage/docs/creating-buckets`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Document GetDocument(DocumentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDocument(new GetDocumentRequest
            {
                DocumentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a single document with its full Markdown content.
        /// </summary>
        /// <param name="name">
        /// Required. Specifies the name of the document to retrieve.
        /// Format: `documents/{uri_without_scheme}`
        /// Example: `documents/docs.cloud.google.com/storage/docs/creating-buckets`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Document> GetDocumentAsync(DocumentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDocumentAsync(new GetDocumentRequest
            {
                DocumentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a single document with its full Markdown content.
        /// </summary>
        /// <param name="name">
        /// Required. Specifies the name of the document to retrieve.
        /// Format: `documents/{uri_without_scheme}`
        /// Example: `documents/docs.cloud.google.com/storage/docs/creating-buckets`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Document> GetDocumentAsync(DocumentName name, st::CancellationToken cancellationToken) =>
            GetDocumentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves multiple documents, each with its full Markdown content.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchGetDocumentsResponse BatchGetDocuments(BatchGetDocumentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves multiple documents, each with its full Markdown content.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchGetDocumentsResponse> BatchGetDocumentsAsync(BatchGetDocumentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves multiple documents, each with its full Markdown content.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchGetDocumentsResponse> BatchGetDocumentsAsync(BatchGetDocumentsRequest request, st::CancellationToken cancellationToken) =>
            BatchGetDocumentsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>DeveloperKnowledge client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The Developer Knowledge API provides programmatic access to Google's public
    /// developer documentation, enabling you to integrate this knowledge base into
    /// your own applications and workflows.
    /// 
    /// The API is designed to be the canonical source for machine-readable access to
    /// Google's developer documentation.
    /// 
    /// A typical use case is to first use
    /// [DeveloperKnowledge.SearchDocumentChunks][google.developers.knowledge.v1.DeveloperKnowledge.SearchDocumentChunks]
    /// to find relevant page URIs based on a query, and then use
    /// [DeveloperKnowledge.GetDocument][google.developers.knowledge.v1.DeveloperKnowledge.GetDocument]
    /// or
    /// [DeveloperKnowledge.BatchGetDocuments][google.developers.knowledge.v1.DeveloperKnowledge.BatchGetDocuments]
    /// to fetch the full content of the top results.
    /// 
    /// All document content is provided in Markdown format.
    /// </remarks>
    public sealed partial class DeveloperKnowledgeClientImpl : DeveloperKnowledgeClient
    {
        private readonly gaxgrpc::ApiCall<SearchDocumentChunksRequest, SearchDocumentChunksResponse> _callSearchDocumentChunks;

        private readonly gaxgrpc::ApiCall<GetDocumentRequest, Document> _callGetDocument;

        private readonly gaxgrpc::ApiCall<BatchGetDocumentsRequest, BatchGetDocumentsResponse> _callBatchGetDocuments;

        /// <summary>
        /// Constructs a client wrapper for the DeveloperKnowledge service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DeveloperKnowledgeSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DeveloperKnowledgeClientImpl(DeveloperKnowledge.DeveloperKnowledgeClient grpcClient, DeveloperKnowledgeSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DeveloperKnowledgeSettings effectiveSettings = settings ?? DeveloperKnowledgeSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callSearchDocumentChunks = clientHelper.BuildApiCall<SearchDocumentChunksRequest, SearchDocumentChunksResponse>("SearchDocumentChunks", grpcClient.SearchDocumentChunksAsync, grpcClient.SearchDocumentChunks, effectiveSettings.SearchDocumentChunksSettings);
            Modify_ApiCall(ref _callSearchDocumentChunks);
            Modify_SearchDocumentChunksApiCall(ref _callSearchDocumentChunks);
            _callGetDocument = clientHelper.BuildApiCall<GetDocumentRequest, Document>("GetDocument", grpcClient.GetDocumentAsync, grpcClient.GetDocument, effectiveSettings.GetDocumentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDocument);
            Modify_GetDocumentApiCall(ref _callGetDocument);
            _callBatchGetDocuments = clientHelper.BuildApiCall<BatchGetDocumentsRequest, BatchGetDocumentsResponse>("BatchGetDocuments", grpcClient.BatchGetDocumentsAsync, grpcClient.BatchGetDocuments, effectiveSettings.BatchGetDocumentsSettings);
            Modify_ApiCall(ref _callBatchGetDocuments);
            Modify_BatchGetDocumentsApiCall(ref _callBatchGetDocuments);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_SearchDocumentChunksApiCall(ref gaxgrpc::ApiCall<SearchDocumentChunksRequest, SearchDocumentChunksResponse> call);

        partial void Modify_GetDocumentApiCall(ref gaxgrpc::ApiCall<GetDocumentRequest, Document> call);

        partial void Modify_BatchGetDocumentsApiCall(ref gaxgrpc::ApiCall<BatchGetDocumentsRequest, BatchGetDocumentsResponse> call);

        partial void OnConstruction(DeveloperKnowledge.DeveloperKnowledgeClient grpcClient, DeveloperKnowledgeSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DeveloperKnowledge client</summary>
        public override DeveloperKnowledge.DeveloperKnowledgeClient GrpcClient { get; }

        partial void Modify_SearchDocumentChunksRequest(ref SearchDocumentChunksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDocumentRequest(ref GetDocumentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchGetDocumentsRequest(ref BatchGetDocumentsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Searches for developer knowledge across Google's developer documentation.
        /// Returns [DocumentChunk][google.developers.knowledge.v1.DocumentChunk]s
        /// based on the user's query. There may be many chunks from the same
        /// [Document][google.developers.knowledge.v1.Document].  To retrieve full
        /// documents, use
        /// [DeveloperKnowledge.GetDocument][google.developers.knowledge.v1.DeveloperKnowledge.GetDocument]
        /// or
        /// [DeveloperKnowledge.BatchGetDocuments][google.developers.knowledge.v1.DeveloperKnowledge.BatchGetDocuments]
        /// with the
        /// [DocumentChunk.parent][google.developers.knowledge.v1.DocumentChunk.parent]
        /// returned in the
        /// [SearchDocumentChunksResponse.results][google.developers.knowledge.v1.SearchDocumentChunksResponse.results].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DocumentChunk"/> resources.</returns>
        public override gax::PagedEnumerable<SearchDocumentChunksResponse, DocumentChunk> SearchDocumentChunks(SearchDocumentChunksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchDocumentChunksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchDocumentChunksRequest, SearchDocumentChunksResponse, DocumentChunk>(_callSearchDocumentChunks, request, callSettings);
        }

        /// <summary>
        /// Searches for developer knowledge across Google's developer documentation.
        /// Returns [DocumentChunk][google.developers.knowledge.v1.DocumentChunk]s
        /// based on the user's query. There may be many chunks from the same
        /// [Document][google.developers.knowledge.v1.Document].  To retrieve full
        /// documents, use
        /// [DeveloperKnowledge.GetDocument][google.developers.knowledge.v1.DeveloperKnowledge.GetDocument]
        /// or
        /// [DeveloperKnowledge.BatchGetDocuments][google.developers.knowledge.v1.DeveloperKnowledge.BatchGetDocuments]
        /// with the
        /// [DocumentChunk.parent][google.developers.knowledge.v1.DocumentChunk.parent]
        /// returned in the
        /// [SearchDocumentChunksResponse.results][google.developers.knowledge.v1.SearchDocumentChunksResponse.results].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DocumentChunk"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchDocumentChunksResponse, DocumentChunk> SearchDocumentChunksAsync(SearchDocumentChunksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchDocumentChunksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchDocumentChunksRequest, SearchDocumentChunksResponse, DocumentChunk>(_callSearchDocumentChunks, request, callSettings);
        }

        /// <summary>
        /// Retrieves a single document with its full Markdown content.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Document GetDocument(GetDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDocumentRequest(ref request, ref callSettings);
            return _callGetDocument.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a single document with its full Markdown content.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Document> GetDocumentAsync(GetDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDocumentRequest(ref request, ref callSettings);
            return _callGetDocument.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves multiple documents, each with its full Markdown content.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchGetDocumentsResponse BatchGetDocuments(BatchGetDocumentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchGetDocumentsRequest(ref request, ref callSettings);
            return _callBatchGetDocuments.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves multiple documents, each with its full Markdown content.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchGetDocumentsResponse> BatchGetDocumentsAsync(BatchGetDocumentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchGetDocumentsRequest(ref request, ref callSettings);
            return _callBatchGetDocuments.Async(request, callSettings);
        }
    }

    public partial class SearchDocumentChunksRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchDocumentChunksResponse : gaxgrpc::IPageResponse<DocumentChunk>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DocumentChunk> GetEnumerator() => Results.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
