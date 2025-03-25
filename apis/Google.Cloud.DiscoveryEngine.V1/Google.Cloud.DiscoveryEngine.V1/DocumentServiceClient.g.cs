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
using gcl = Google.Cloud.Location;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using lro = Google.LongRunning;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.DiscoveryEngine.V1
{
    /// <summary>Settings for <see cref="DocumentServiceClient"/> instances.</summary>
    public sealed partial class DocumentServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DocumentServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DocumentServiceSettings"/>.</returns>
        public static DocumentServiceSettings GetDefault() => new DocumentServiceSettings();

        /// <summary>Constructs a new <see cref="DocumentServiceSettings"/> object with default settings.</summary>
        public DocumentServiceSettings()
        {
        }

        private DocumentServiceSettings(DocumentServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetDocumentSettings = existing.GetDocumentSettings;
            ListDocumentsSettings = existing.ListDocumentsSettings;
            CreateDocumentSettings = existing.CreateDocumentSettings;
            UpdateDocumentSettings = existing.UpdateDocumentSettings;
            DeleteDocumentSettings = existing.DeleteDocumentSettings;
            ImportDocumentsSettings = existing.ImportDocumentsSettings;
            ImportDocumentsOperationsSettings = existing.ImportDocumentsOperationsSettings.Clone();
            PurgeDocumentsSettings = existing.PurgeDocumentsSettings;
            PurgeDocumentsOperationsSettings = existing.PurgeDocumentsOperationsSettings.Clone();
            BatchGetDocumentsMetadataSettings = existing.BatchGetDocumentsMetadataSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DocumentServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentServiceClient.GetDocument</c> and <c>DocumentServiceClient.GetDocumentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDocumentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentServiceClient.ListDocuments</c> and <c>DocumentServiceClient.ListDocumentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDocumentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentServiceClient.CreateDocument</c> and <c>DocumentServiceClient.CreateDocumentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDocumentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentServiceClient.UpdateDocument</c> and <c>DocumentServiceClient.UpdateDocumentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDocumentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentServiceClient.DeleteDocument</c> and <c>DocumentServiceClient.DeleteDocumentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDocumentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentServiceClient.ImportDocuments</c> and <c>DocumentServiceClient.ImportDocumentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ImportDocumentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DocumentServiceClient.ImportDocuments</c> and
        /// <c>DocumentServiceClient.ImportDocumentsAsync</c>.
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
        public lro::OperationsSettings ImportDocumentsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentServiceClient.PurgeDocuments</c> and <c>DocumentServiceClient.PurgeDocumentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PurgeDocumentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DocumentServiceClient.PurgeDocuments</c> and
        /// <c>DocumentServiceClient.PurgeDocumentsAsync</c>.
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
        public lro::OperationsSettings PurgeDocumentsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentServiceClient.BatchGetDocumentsMetadata</c> and
        /// <c>DocumentServiceClient.BatchGetDocumentsMetadataAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchGetDocumentsMetadataSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DocumentServiceSettings"/> object.</returns>
        public DocumentServiceSettings Clone() => new DocumentServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DocumentServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class DocumentServiceClientBuilder : gaxgrpc::ClientBuilderBase<DocumentServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DocumentServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DocumentServiceClientBuilder() : base(DocumentServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DocumentServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DocumentServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DocumentServiceClient Build()
        {
            DocumentServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DocumentServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DocumentServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DocumentServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DocumentServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DocumentServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DocumentServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DocumentServiceClient.ChannelPool;
    }

    /// <summary>DocumentService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for ingesting [Document][google.cloud.discoveryengine.v1.Document]
    /// information of the customer's website.
    /// </remarks>
    public abstract partial class DocumentServiceClient
    {
        /// <summary>
        /// The default endpoint for the DocumentService service, which is a host of "discoveryengine.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "discoveryengine.googleapis.com:443";

        /// <summary>The default DocumentService scopes.</summary>
        /// <remarks>
        /// The default DocumentService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DocumentService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DocumentServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DocumentServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DocumentServiceClient"/>.</returns>
        public static stt::Task<DocumentServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DocumentServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DocumentServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DocumentServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DocumentServiceClient"/>.</returns>
        public static DocumentServiceClient Create() => new DocumentServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DocumentServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DocumentServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DocumentServiceClient"/>.</returns>
        internal static DocumentServiceClient Create(grpccore::CallInvoker callInvoker, DocumentServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DocumentService.DocumentServiceClient grpcClient = new DocumentService.DocumentServiceClient(callInvoker);
            return new DocumentServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DocumentService client</summary>
        public virtual DocumentService.DocumentServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a [Document][google.cloud.discoveryengine.v1.Document].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Document GetDocument(GetDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a [Document][google.cloud.discoveryengine.v1.Document].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Document> GetDocumentAsync(GetDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a [Document][google.cloud.discoveryengine.v1.Document].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Document> GetDocumentAsync(GetDocumentRequest request, st::CancellationToken cancellationToken) =>
            GetDocumentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a [Document][google.cloud.discoveryengine.v1.Document].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [Document][google.cloud.discoveryengine.v1.Document], such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}/documents/{document}`.
        /// 
        /// If the caller does not have permission to access the
        /// [Document][google.cloud.discoveryengine.v1.Document], regardless of whether
        /// or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// If the requested [Document][google.cloud.discoveryengine.v1.Document] does
        /// not exist, a `NOT_FOUND` error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Document GetDocument(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDocument(new GetDocumentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [Document][google.cloud.discoveryengine.v1.Document].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [Document][google.cloud.discoveryengine.v1.Document], such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}/documents/{document}`.
        /// 
        /// If the caller does not have permission to access the
        /// [Document][google.cloud.discoveryengine.v1.Document], regardless of whether
        /// or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// If the requested [Document][google.cloud.discoveryengine.v1.Document] does
        /// not exist, a `NOT_FOUND` error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Document> GetDocumentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDocumentAsync(new GetDocumentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [Document][google.cloud.discoveryengine.v1.Document].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [Document][google.cloud.discoveryengine.v1.Document], such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}/documents/{document}`.
        /// 
        /// If the caller does not have permission to access the
        /// [Document][google.cloud.discoveryengine.v1.Document], regardless of whether
        /// or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// If the requested [Document][google.cloud.discoveryengine.v1.Document] does
        /// not exist, a `NOT_FOUND` error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Document> GetDocumentAsync(string name, st::CancellationToken cancellationToken) =>
            GetDocumentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a [Document][google.cloud.discoveryengine.v1.Document].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [Document][google.cloud.discoveryengine.v1.Document], such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}/documents/{document}`.
        /// 
        /// If the caller does not have permission to access the
        /// [Document][google.cloud.discoveryengine.v1.Document], regardless of whether
        /// or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// If the requested [Document][google.cloud.discoveryengine.v1.Document] does
        /// not exist, a `NOT_FOUND` error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Document GetDocument(DocumentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDocument(new GetDocumentRequest
            {
                DocumentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [Document][google.cloud.discoveryengine.v1.Document].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [Document][google.cloud.discoveryengine.v1.Document], such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}/documents/{document}`.
        /// 
        /// If the caller does not have permission to access the
        /// [Document][google.cloud.discoveryengine.v1.Document], regardless of whether
        /// or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// If the requested [Document][google.cloud.discoveryengine.v1.Document] does
        /// not exist, a `NOT_FOUND` error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Document> GetDocumentAsync(DocumentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDocumentAsync(new GetDocumentRequest
            {
                DocumentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [Document][google.cloud.discoveryengine.v1.Document].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [Document][google.cloud.discoveryengine.v1.Document], such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}/documents/{document}`.
        /// 
        /// If the caller does not have permission to access the
        /// [Document][google.cloud.discoveryengine.v1.Document], regardless of whether
        /// or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// If the requested [Document][google.cloud.discoveryengine.v1.Document] does
        /// not exist, a `NOT_FOUND` error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Document> GetDocumentAsync(DocumentName name, st::CancellationToken cancellationToken) =>
            GetDocumentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a list of [Document][google.cloud.discoveryengine.v1.Document]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Document"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDocumentsResponse, Document> ListDocuments(ListDocumentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a list of [Document][google.cloud.discoveryengine.v1.Document]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Document"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDocumentsResponse, Document> ListDocumentsAsync(ListDocumentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a list of [Document][google.cloud.discoveryengine.v1.Document]s.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent branch resource name, such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}`.
        /// Use `default_branch` as the branch ID, to list documents under the default
        /// branch.
        /// 
        /// If the caller does not have permission to list
        /// [Document][google.cloud.discoveryengine.v1.Document]s under this branch,
        /// regardless of whether or not this branch exists, a `PERMISSION_DENIED`
        /// error is returned.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Document"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDocumentsResponse, Document> ListDocuments(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDocumentsRequest request = new ListDocumentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDocuments(request, callSettings);
        }

        /// <summary>
        /// Gets a list of [Document][google.cloud.discoveryengine.v1.Document]s.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent branch resource name, such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}`.
        /// Use `default_branch` as the branch ID, to list documents under the default
        /// branch.
        /// 
        /// If the caller does not have permission to list
        /// [Document][google.cloud.discoveryengine.v1.Document]s under this branch,
        /// regardless of whether or not this branch exists, a `PERMISSION_DENIED`
        /// error is returned.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Document"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDocumentsResponse, Document> ListDocumentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDocumentsRequest request = new ListDocumentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDocumentsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a list of [Document][google.cloud.discoveryengine.v1.Document]s.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent branch resource name, such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}`.
        /// Use `default_branch` as the branch ID, to list documents under the default
        /// branch.
        /// 
        /// If the caller does not have permission to list
        /// [Document][google.cloud.discoveryengine.v1.Document]s under this branch,
        /// regardless of whether or not this branch exists, a `PERMISSION_DENIED`
        /// error is returned.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Document"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDocumentsResponse, Document> ListDocuments(BranchName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDocumentsRequest request = new ListDocumentsRequest
            {
                ParentAsBranchName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDocuments(request, callSettings);
        }

        /// <summary>
        /// Gets a list of [Document][google.cloud.discoveryengine.v1.Document]s.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent branch resource name, such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}`.
        /// Use `default_branch` as the branch ID, to list documents under the default
        /// branch.
        /// 
        /// If the caller does not have permission to list
        /// [Document][google.cloud.discoveryengine.v1.Document]s under this branch,
        /// regardless of whether or not this branch exists, a `PERMISSION_DENIED`
        /// error is returned.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Document"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDocumentsResponse, Document> ListDocumentsAsync(BranchName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDocumentsRequest request = new ListDocumentsRequest
            {
                ParentAsBranchName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDocumentsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a [Document][google.cloud.discoveryengine.v1.Document].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Document CreateDocument(CreateDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [Document][google.cloud.discoveryengine.v1.Document].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Document> CreateDocumentAsync(CreateDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [Document][google.cloud.discoveryengine.v1.Document].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Document> CreateDocumentAsync(CreateDocumentRequest request, st::CancellationToken cancellationToken) =>
            CreateDocumentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a [Document][google.cloud.discoveryengine.v1.Document].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}`.
        /// </param>
        /// <param name="document">
        /// Required. The [Document][google.cloud.discoveryengine.v1.Document] to
        /// create.
        /// </param>
        /// <param name="documentId">
        /// Required. The ID to use for the
        /// [Document][google.cloud.discoveryengine.v1.Document], which becomes the
        /// final component of the
        /// [Document.name][google.cloud.discoveryengine.v1.Document.name].
        /// 
        /// If the caller does not have permission to create the
        /// [Document][google.cloud.discoveryengine.v1.Document], regardless of whether
        /// or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// This field must be unique among all
        /// [Document][google.cloud.discoveryengine.v1.Document]s with the same
        /// [parent][google.cloud.discoveryengine.v1.CreateDocumentRequest.parent].
        /// Otherwise, an `ALREADY_EXISTS` error is returned.
        /// 
        /// This field must conform to [RFC-1034](https://tools.ietf.org/html/rfc1034)
        /// standard with a length limit of 128 characters. Otherwise, an
        /// `INVALID_ARGUMENT` error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Document CreateDocument(string parent, Document document, string documentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDocument(new CreateDocumentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
                DocumentId = gax::GaxPreconditions.CheckNotNullOrEmpty(documentId, nameof(documentId)),
            }, callSettings);

        /// <summary>
        /// Creates a [Document][google.cloud.discoveryengine.v1.Document].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}`.
        /// </param>
        /// <param name="document">
        /// Required. The [Document][google.cloud.discoveryengine.v1.Document] to
        /// create.
        /// </param>
        /// <param name="documentId">
        /// Required. The ID to use for the
        /// [Document][google.cloud.discoveryengine.v1.Document], which becomes the
        /// final component of the
        /// [Document.name][google.cloud.discoveryengine.v1.Document.name].
        /// 
        /// If the caller does not have permission to create the
        /// [Document][google.cloud.discoveryengine.v1.Document], regardless of whether
        /// or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// This field must be unique among all
        /// [Document][google.cloud.discoveryengine.v1.Document]s with the same
        /// [parent][google.cloud.discoveryengine.v1.CreateDocumentRequest.parent].
        /// Otherwise, an `ALREADY_EXISTS` error is returned.
        /// 
        /// This field must conform to [RFC-1034](https://tools.ietf.org/html/rfc1034)
        /// standard with a length limit of 128 characters. Otherwise, an
        /// `INVALID_ARGUMENT` error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Document> CreateDocumentAsync(string parent, Document document, string documentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDocumentAsync(new CreateDocumentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
                DocumentId = gax::GaxPreconditions.CheckNotNullOrEmpty(documentId, nameof(documentId)),
            }, callSettings);

        /// <summary>
        /// Creates a [Document][google.cloud.discoveryengine.v1.Document].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}`.
        /// </param>
        /// <param name="document">
        /// Required. The [Document][google.cloud.discoveryengine.v1.Document] to
        /// create.
        /// </param>
        /// <param name="documentId">
        /// Required. The ID to use for the
        /// [Document][google.cloud.discoveryengine.v1.Document], which becomes the
        /// final component of the
        /// [Document.name][google.cloud.discoveryengine.v1.Document.name].
        /// 
        /// If the caller does not have permission to create the
        /// [Document][google.cloud.discoveryengine.v1.Document], regardless of whether
        /// or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// This field must be unique among all
        /// [Document][google.cloud.discoveryengine.v1.Document]s with the same
        /// [parent][google.cloud.discoveryengine.v1.CreateDocumentRequest.parent].
        /// Otherwise, an `ALREADY_EXISTS` error is returned.
        /// 
        /// This field must conform to [RFC-1034](https://tools.ietf.org/html/rfc1034)
        /// standard with a length limit of 128 characters. Otherwise, an
        /// `INVALID_ARGUMENT` error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Document> CreateDocumentAsync(string parent, Document document, string documentId, st::CancellationToken cancellationToken) =>
            CreateDocumentAsync(parent, document, documentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a [Document][google.cloud.discoveryengine.v1.Document].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}`.
        /// </param>
        /// <param name="document">
        /// Required. The [Document][google.cloud.discoveryengine.v1.Document] to
        /// create.
        /// </param>
        /// <param name="documentId">
        /// Required. The ID to use for the
        /// [Document][google.cloud.discoveryengine.v1.Document], which becomes the
        /// final component of the
        /// [Document.name][google.cloud.discoveryengine.v1.Document.name].
        /// 
        /// If the caller does not have permission to create the
        /// [Document][google.cloud.discoveryengine.v1.Document], regardless of whether
        /// or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// This field must be unique among all
        /// [Document][google.cloud.discoveryengine.v1.Document]s with the same
        /// [parent][google.cloud.discoveryengine.v1.CreateDocumentRequest.parent].
        /// Otherwise, an `ALREADY_EXISTS` error is returned.
        /// 
        /// This field must conform to [RFC-1034](https://tools.ietf.org/html/rfc1034)
        /// standard with a length limit of 128 characters. Otherwise, an
        /// `INVALID_ARGUMENT` error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Document CreateDocument(BranchName parent, Document document, string documentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDocument(new CreateDocumentRequest
            {
                ParentAsBranchName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
                DocumentId = gax::GaxPreconditions.CheckNotNullOrEmpty(documentId, nameof(documentId)),
            }, callSettings);

        /// <summary>
        /// Creates a [Document][google.cloud.discoveryengine.v1.Document].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}`.
        /// </param>
        /// <param name="document">
        /// Required. The [Document][google.cloud.discoveryengine.v1.Document] to
        /// create.
        /// </param>
        /// <param name="documentId">
        /// Required. The ID to use for the
        /// [Document][google.cloud.discoveryengine.v1.Document], which becomes the
        /// final component of the
        /// [Document.name][google.cloud.discoveryengine.v1.Document.name].
        /// 
        /// If the caller does not have permission to create the
        /// [Document][google.cloud.discoveryengine.v1.Document], regardless of whether
        /// or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// This field must be unique among all
        /// [Document][google.cloud.discoveryengine.v1.Document]s with the same
        /// [parent][google.cloud.discoveryengine.v1.CreateDocumentRequest.parent].
        /// Otherwise, an `ALREADY_EXISTS` error is returned.
        /// 
        /// This field must conform to [RFC-1034](https://tools.ietf.org/html/rfc1034)
        /// standard with a length limit of 128 characters. Otherwise, an
        /// `INVALID_ARGUMENT` error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Document> CreateDocumentAsync(BranchName parent, Document document, string documentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDocumentAsync(new CreateDocumentRequest
            {
                ParentAsBranchName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
                DocumentId = gax::GaxPreconditions.CheckNotNullOrEmpty(documentId, nameof(documentId)),
            }, callSettings);

        /// <summary>
        /// Creates a [Document][google.cloud.discoveryengine.v1.Document].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}`.
        /// </param>
        /// <param name="document">
        /// Required. The [Document][google.cloud.discoveryengine.v1.Document] to
        /// create.
        /// </param>
        /// <param name="documentId">
        /// Required. The ID to use for the
        /// [Document][google.cloud.discoveryengine.v1.Document], which becomes the
        /// final component of the
        /// [Document.name][google.cloud.discoveryengine.v1.Document.name].
        /// 
        /// If the caller does not have permission to create the
        /// [Document][google.cloud.discoveryengine.v1.Document], regardless of whether
        /// or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// This field must be unique among all
        /// [Document][google.cloud.discoveryengine.v1.Document]s with the same
        /// [parent][google.cloud.discoveryengine.v1.CreateDocumentRequest.parent].
        /// Otherwise, an `ALREADY_EXISTS` error is returned.
        /// 
        /// This field must conform to [RFC-1034](https://tools.ietf.org/html/rfc1034)
        /// standard with a length limit of 128 characters. Otherwise, an
        /// `INVALID_ARGUMENT` error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Document> CreateDocumentAsync(BranchName parent, Document document, string documentId, st::CancellationToken cancellationToken) =>
            CreateDocumentAsync(parent, document, documentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a [Document][google.cloud.discoveryengine.v1.Document].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Document UpdateDocument(UpdateDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a [Document][google.cloud.discoveryengine.v1.Document].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Document> UpdateDocumentAsync(UpdateDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a [Document][google.cloud.discoveryengine.v1.Document].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Document> UpdateDocumentAsync(UpdateDocumentRequest request, st::CancellationToken cancellationToken) =>
            UpdateDocumentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a [Document][google.cloud.discoveryengine.v1.Document].
        /// </summary>
        /// <param name="document">
        /// Required. The document to update/create.
        /// 
        /// If the caller does not have permission to update the
        /// [Document][google.cloud.discoveryengine.v1.Document], regardless of whether
        /// or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// If the [Document][google.cloud.discoveryengine.v1.Document] to update does
        /// not exist and
        /// [allow_missing][google.cloud.discoveryengine.v1.UpdateDocumentRequest.allow_missing]
        /// is not set, a `NOT_FOUND` error is returned.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided imported 'document' to update. If
        /// not set, by default updates all fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Document UpdateDocument(Document document, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDocument(new UpdateDocumentRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a [Document][google.cloud.discoveryengine.v1.Document].
        /// </summary>
        /// <param name="document">
        /// Required. The document to update/create.
        /// 
        /// If the caller does not have permission to update the
        /// [Document][google.cloud.discoveryengine.v1.Document], regardless of whether
        /// or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// If the [Document][google.cloud.discoveryengine.v1.Document] to update does
        /// not exist and
        /// [allow_missing][google.cloud.discoveryengine.v1.UpdateDocumentRequest.allow_missing]
        /// is not set, a `NOT_FOUND` error is returned.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided imported 'document' to update. If
        /// not set, by default updates all fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Document> UpdateDocumentAsync(Document document, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDocumentAsync(new UpdateDocumentRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a [Document][google.cloud.discoveryengine.v1.Document].
        /// </summary>
        /// <param name="document">
        /// Required. The document to update/create.
        /// 
        /// If the caller does not have permission to update the
        /// [Document][google.cloud.discoveryengine.v1.Document], regardless of whether
        /// or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// If the [Document][google.cloud.discoveryengine.v1.Document] to update does
        /// not exist and
        /// [allow_missing][google.cloud.discoveryengine.v1.UpdateDocumentRequest.allow_missing]
        /// is not set, a `NOT_FOUND` error is returned.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided imported 'document' to update. If
        /// not set, by default updates all fields.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Document> UpdateDocumentAsync(Document document, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDocumentAsync(document, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a [Document][google.cloud.discoveryengine.v1.Document].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDocument(DeleteDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a [Document][google.cloud.discoveryengine.v1.Document].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDocumentAsync(DeleteDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a [Document][google.cloud.discoveryengine.v1.Document].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDocumentAsync(DeleteDocumentRequest request, st::CancellationToken cancellationToken) =>
            DeleteDocumentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a [Document][google.cloud.discoveryengine.v1.Document].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [Document][google.cloud.discoveryengine.v1.Document], such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}/documents/{document}`.
        /// 
        /// If the caller does not have permission to delete the
        /// [Document][google.cloud.discoveryengine.v1.Document], regardless of whether
        /// or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// If the [Document][google.cloud.discoveryengine.v1.Document] to delete does
        /// not exist, a `NOT_FOUND` error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDocument(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDocument(new DeleteDocumentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [Document][google.cloud.discoveryengine.v1.Document].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [Document][google.cloud.discoveryengine.v1.Document], such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}/documents/{document}`.
        /// 
        /// If the caller does not have permission to delete the
        /// [Document][google.cloud.discoveryengine.v1.Document], regardless of whether
        /// or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// If the [Document][google.cloud.discoveryengine.v1.Document] to delete does
        /// not exist, a `NOT_FOUND` error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDocumentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDocumentAsync(new DeleteDocumentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [Document][google.cloud.discoveryengine.v1.Document].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [Document][google.cloud.discoveryengine.v1.Document], such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}/documents/{document}`.
        /// 
        /// If the caller does not have permission to delete the
        /// [Document][google.cloud.discoveryengine.v1.Document], regardless of whether
        /// or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// If the [Document][google.cloud.discoveryengine.v1.Document] to delete does
        /// not exist, a `NOT_FOUND` error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDocumentAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDocumentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a [Document][google.cloud.discoveryengine.v1.Document].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [Document][google.cloud.discoveryengine.v1.Document], such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}/documents/{document}`.
        /// 
        /// If the caller does not have permission to delete the
        /// [Document][google.cloud.discoveryengine.v1.Document], regardless of whether
        /// or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// If the [Document][google.cloud.discoveryengine.v1.Document] to delete does
        /// not exist, a `NOT_FOUND` error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDocument(DocumentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDocument(new DeleteDocumentRequest
            {
                DocumentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [Document][google.cloud.discoveryengine.v1.Document].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [Document][google.cloud.discoveryengine.v1.Document], such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}/documents/{document}`.
        /// 
        /// If the caller does not have permission to delete the
        /// [Document][google.cloud.discoveryengine.v1.Document], regardless of whether
        /// or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// If the [Document][google.cloud.discoveryengine.v1.Document] to delete does
        /// not exist, a `NOT_FOUND` error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDocumentAsync(DocumentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDocumentAsync(new DeleteDocumentRequest
            {
                DocumentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [Document][google.cloud.discoveryengine.v1.Document].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [Document][google.cloud.discoveryengine.v1.Document], such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}/documents/{document}`.
        /// 
        /// If the caller does not have permission to delete the
        /// [Document][google.cloud.discoveryengine.v1.Document], regardless of whether
        /// or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// If the [Document][google.cloud.discoveryengine.v1.Document] to delete does
        /// not exist, a `NOT_FOUND` error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDocumentAsync(DocumentName name, st::CancellationToken cancellationToken) =>
            DeleteDocumentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Bulk import of multiple
        /// [Document][google.cloud.discoveryengine.v1.Document]s. Request processing
        /// may be synchronous. Non-existing items are created.
        /// 
        /// Note: It is possible for a subset of the
        /// [Document][google.cloud.discoveryengine.v1.Document]s to be successfully
        /// updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportDocumentsResponse, ImportDocumentsMetadata> ImportDocuments(ImportDocumentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Bulk import of multiple
        /// [Document][google.cloud.discoveryengine.v1.Document]s. Request processing
        /// may be synchronous. Non-existing items are created.
        /// 
        /// Note: It is possible for a subset of the
        /// [Document][google.cloud.discoveryengine.v1.Document]s to be successfully
        /// updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportDocumentsResponse, ImportDocumentsMetadata>> ImportDocumentsAsync(ImportDocumentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Bulk import of multiple
        /// [Document][google.cloud.discoveryengine.v1.Document]s. Request processing
        /// may be synchronous. Non-existing items are created.
        /// 
        /// Note: It is possible for a subset of the
        /// [Document][google.cloud.discoveryengine.v1.Document]s to be successfully
        /// updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportDocumentsResponse, ImportDocumentsMetadata>> ImportDocumentsAsync(ImportDocumentsRequest request, st::CancellationToken cancellationToken) =>
            ImportDocumentsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ImportDocuments</c>.</summary>
        public virtual lro::OperationsClient ImportDocumentsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ImportDocuments</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ImportDocumentsResponse, ImportDocumentsMetadata> PollOnceImportDocuments(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportDocumentsResponse, ImportDocumentsMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportDocumentsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ImportDocuments</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ImportDocumentsResponse, ImportDocumentsMetadata>> PollOnceImportDocumentsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportDocumentsResponse, ImportDocumentsMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportDocumentsOperationsClient, callSettings);

        /// <summary>
        /// Permanently deletes all selected
        /// [Document][google.cloud.discoveryengine.v1.Document]s in a branch.
        /// 
        /// This process is asynchronous. Depending on the number of
        /// [Document][google.cloud.discoveryengine.v1.Document]s to be deleted, this
        /// operation can take hours to complete. Before the delete operation
        /// completes, some [Document][google.cloud.discoveryengine.v1.Document]s might
        /// still be returned by
        /// [DocumentService.GetDocument][google.cloud.discoveryengine.v1.DocumentService.GetDocument]
        /// or
        /// [DocumentService.ListDocuments][google.cloud.discoveryengine.v1.DocumentService.ListDocuments].
        /// 
        /// To get a list of the [Document][google.cloud.discoveryengine.v1.Document]s
        /// to be deleted, set
        /// [PurgeDocumentsRequest.force][google.cloud.discoveryengine.v1.PurgeDocumentsRequest.force]
        /// to false.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PurgeDocumentsResponse, PurgeDocumentsMetadata> PurgeDocuments(PurgeDocumentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Permanently deletes all selected
        /// [Document][google.cloud.discoveryengine.v1.Document]s in a branch.
        /// 
        /// This process is asynchronous. Depending on the number of
        /// [Document][google.cloud.discoveryengine.v1.Document]s to be deleted, this
        /// operation can take hours to complete. Before the delete operation
        /// completes, some [Document][google.cloud.discoveryengine.v1.Document]s might
        /// still be returned by
        /// [DocumentService.GetDocument][google.cloud.discoveryengine.v1.DocumentService.GetDocument]
        /// or
        /// [DocumentService.ListDocuments][google.cloud.discoveryengine.v1.DocumentService.ListDocuments].
        /// 
        /// To get a list of the [Document][google.cloud.discoveryengine.v1.Document]s
        /// to be deleted, set
        /// [PurgeDocumentsRequest.force][google.cloud.discoveryengine.v1.PurgeDocumentsRequest.force]
        /// to false.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PurgeDocumentsResponse, PurgeDocumentsMetadata>> PurgeDocumentsAsync(PurgeDocumentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Permanently deletes all selected
        /// [Document][google.cloud.discoveryengine.v1.Document]s in a branch.
        /// 
        /// This process is asynchronous. Depending on the number of
        /// [Document][google.cloud.discoveryengine.v1.Document]s to be deleted, this
        /// operation can take hours to complete. Before the delete operation
        /// completes, some [Document][google.cloud.discoveryengine.v1.Document]s might
        /// still be returned by
        /// [DocumentService.GetDocument][google.cloud.discoveryengine.v1.DocumentService.GetDocument]
        /// or
        /// [DocumentService.ListDocuments][google.cloud.discoveryengine.v1.DocumentService.ListDocuments].
        /// 
        /// To get a list of the [Document][google.cloud.discoveryengine.v1.Document]s
        /// to be deleted, set
        /// [PurgeDocumentsRequest.force][google.cloud.discoveryengine.v1.PurgeDocumentsRequest.force]
        /// to false.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PurgeDocumentsResponse, PurgeDocumentsMetadata>> PurgeDocumentsAsync(PurgeDocumentsRequest request, st::CancellationToken cancellationToken) =>
            PurgeDocumentsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>PurgeDocuments</c>.</summary>
        public virtual lro::OperationsClient PurgeDocumentsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>PurgeDocuments</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<PurgeDocumentsResponse, PurgeDocumentsMetadata> PollOncePurgeDocuments(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PurgeDocumentsResponse, PurgeDocumentsMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PurgeDocumentsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>PurgeDocuments</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<PurgeDocumentsResponse, PurgeDocumentsMetadata>> PollOncePurgeDocumentsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PurgeDocumentsResponse, PurgeDocumentsMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PurgeDocumentsOperationsClient, callSettings);

        /// <summary>
        /// Gets index freshness metadata for
        /// [Document][google.cloud.discoveryengine.v1.Document]s. Supported for
        /// website search only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchGetDocumentsMetadataResponse BatchGetDocumentsMetadata(BatchGetDocumentsMetadataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets index freshness metadata for
        /// [Document][google.cloud.discoveryengine.v1.Document]s. Supported for
        /// website search only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchGetDocumentsMetadataResponse> BatchGetDocumentsMetadataAsync(BatchGetDocumentsMetadataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets index freshness metadata for
        /// [Document][google.cloud.discoveryengine.v1.Document]s. Supported for
        /// website search only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchGetDocumentsMetadataResponse> BatchGetDocumentsMetadataAsync(BatchGetDocumentsMetadataRequest request, st::CancellationToken cancellationToken) =>
            BatchGetDocumentsMetadataAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets index freshness metadata for
        /// [Document][google.cloud.discoveryengine.v1.Document]s. Supported for
        /// website search only.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent branch resource name, such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchGetDocumentsMetadataResponse BatchGetDocumentsMetadata(string parent, gaxgrpc::CallSettings callSettings = null) =>
            BatchGetDocumentsMetadata(new BatchGetDocumentsMetadataRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Gets index freshness metadata for
        /// [Document][google.cloud.discoveryengine.v1.Document]s. Supported for
        /// website search only.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent branch resource name, such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchGetDocumentsMetadataResponse> BatchGetDocumentsMetadataAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            BatchGetDocumentsMetadataAsync(new BatchGetDocumentsMetadataRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Gets index freshness metadata for
        /// [Document][google.cloud.discoveryengine.v1.Document]s. Supported for
        /// website search only.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent branch resource name, such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchGetDocumentsMetadataResponse> BatchGetDocumentsMetadataAsync(string parent, st::CancellationToken cancellationToken) =>
            BatchGetDocumentsMetadataAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets index freshness metadata for
        /// [Document][google.cloud.discoveryengine.v1.Document]s. Supported for
        /// website search only.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent branch resource name, such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchGetDocumentsMetadataResponse BatchGetDocumentsMetadata(BranchName parent, gaxgrpc::CallSettings callSettings = null) =>
            BatchGetDocumentsMetadata(new BatchGetDocumentsMetadataRequest
            {
                ParentAsBranchName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Gets index freshness metadata for
        /// [Document][google.cloud.discoveryengine.v1.Document]s. Supported for
        /// website search only.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent branch resource name, such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchGetDocumentsMetadataResponse> BatchGetDocumentsMetadataAsync(BranchName parent, gaxgrpc::CallSettings callSettings = null) =>
            BatchGetDocumentsMetadataAsync(new BatchGetDocumentsMetadataRequest
            {
                ParentAsBranchName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Gets index freshness metadata for
        /// [Document][google.cloud.discoveryengine.v1.Document]s. Supported for
        /// website search only.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent branch resource name, such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchGetDocumentsMetadataResponse> BatchGetDocumentsMetadataAsync(BranchName parent, st::CancellationToken cancellationToken) =>
            BatchGetDocumentsMetadataAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>DocumentService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for ingesting [Document][google.cloud.discoveryengine.v1.Document]
    /// information of the customer's website.
    /// </remarks>
    public sealed partial class DocumentServiceClientImpl : DocumentServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetDocumentRequest, Document> _callGetDocument;

        private readonly gaxgrpc::ApiCall<ListDocumentsRequest, ListDocumentsResponse> _callListDocuments;

        private readonly gaxgrpc::ApiCall<CreateDocumentRequest, Document> _callCreateDocument;

        private readonly gaxgrpc::ApiCall<UpdateDocumentRequest, Document> _callUpdateDocument;

        private readonly gaxgrpc::ApiCall<DeleteDocumentRequest, wkt::Empty> _callDeleteDocument;

        private readonly gaxgrpc::ApiCall<ImportDocumentsRequest, lro::Operation> _callImportDocuments;

        private readonly gaxgrpc::ApiCall<PurgeDocumentsRequest, lro::Operation> _callPurgeDocuments;

        private readonly gaxgrpc::ApiCall<BatchGetDocumentsMetadataRequest, BatchGetDocumentsMetadataResponse> _callBatchGetDocumentsMetadata;

        /// <summary>
        /// Constructs a client wrapper for the DocumentService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DocumentServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DocumentServiceClientImpl(DocumentService.DocumentServiceClient grpcClient, DocumentServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DocumentServiceSettings effectiveSettings = settings ?? DocumentServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            ImportDocumentsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ImportDocumentsOperationsSettings, logger);
            PurgeDocumentsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.PurgeDocumentsOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callGetDocument = clientHelper.BuildApiCall<GetDocumentRequest, Document>("GetDocument", grpcClient.GetDocumentAsync, grpcClient.GetDocument, effectiveSettings.GetDocumentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDocument);
            Modify_GetDocumentApiCall(ref _callGetDocument);
            _callListDocuments = clientHelper.BuildApiCall<ListDocumentsRequest, ListDocumentsResponse>("ListDocuments", grpcClient.ListDocumentsAsync, grpcClient.ListDocuments, effectiveSettings.ListDocumentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDocuments);
            Modify_ListDocumentsApiCall(ref _callListDocuments);
            _callCreateDocument = clientHelper.BuildApiCall<CreateDocumentRequest, Document>("CreateDocument", grpcClient.CreateDocumentAsync, grpcClient.CreateDocument, effectiveSettings.CreateDocumentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDocument);
            Modify_CreateDocumentApiCall(ref _callCreateDocument);
            _callUpdateDocument = clientHelper.BuildApiCall<UpdateDocumentRequest, Document>("UpdateDocument", grpcClient.UpdateDocumentAsync, grpcClient.UpdateDocument, effectiveSettings.UpdateDocumentSettings).WithGoogleRequestParam("document.name", request => request.Document?.Name);
            Modify_ApiCall(ref _callUpdateDocument);
            Modify_UpdateDocumentApiCall(ref _callUpdateDocument);
            _callDeleteDocument = clientHelper.BuildApiCall<DeleteDocumentRequest, wkt::Empty>("DeleteDocument", grpcClient.DeleteDocumentAsync, grpcClient.DeleteDocument, effectiveSettings.DeleteDocumentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDocument);
            Modify_DeleteDocumentApiCall(ref _callDeleteDocument);
            _callImportDocuments = clientHelper.BuildApiCall<ImportDocumentsRequest, lro::Operation>("ImportDocuments", grpcClient.ImportDocumentsAsync, grpcClient.ImportDocuments, effectiveSettings.ImportDocumentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callImportDocuments);
            Modify_ImportDocumentsApiCall(ref _callImportDocuments);
            _callPurgeDocuments = clientHelper.BuildApiCall<PurgeDocumentsRequest, lro::Operation>("PurgeDocuments", grpcClient.PurgeDocumentsAsync, grpcClient.PurgeDocuments, effectiveSettings.PurgeDocumentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callPurgeDocuments);
            Modify_PurgeDocumentsApiCall(ref _callPurgeDocuments);
            _callBatchGetDocumentsMetadata = clientHelper.BuildApiCall<BatchGetDocumentsMetadataRequest, BatchGetDocumentsMetadataResponse>("BatchGetDocumentsMetadata", grpcClient.BatchGetDocumentsMetadataAsync, grpcClient.BatchGetDocumentsMetadata, effectiveSettings.BatchGetDocumentsMetadataSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchGetDocumentsMetadata);
            Modify_BatchGetDocumentsMetadataApiCall(ref _callBatchGetDocumentsMetadata);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetDocumentApiCall(ref gaxgrpc::ApiCall<GetDocumentRequest, Document> call);

        partial void Modify_ListDocumentsApiCall(ref gaxgrpc::ApiCall<ListDocumentsRequest, ListDocumentsResponse> call);

        partial void Modify_CreateDocumentApiCall(ref gaxgrpc::ApiCall<CreateDocumentRequest, Document> call);

        partial void Modify_UpdateDocumentApiCall(ref gaxgrpc::ApiCall<UpdateDocumentRequest, Document> call);

        partial void Modify_DeleteDocumentApiCall(ref gaxgrpc::ApiCall<DeleteDocumentRequest, wkt::Empty> call);

        partial void Modify_ImportDocumentsApiCall(ref gaxgrpc::ApiCall<ImportDocumentsRequest, lro::Operation> call);

        partial void Modify_PurgeDocumentsApiCall(ref gaxgrpc::ApiCall<PurgeDocumentsRequest, lro::Operation> call);

        partial void Modify_BatchGetDocumentsMetadataApiCall(ref gaxgrpc::ApiCall<BatchGetDocumentsMetadataRequest, BatchGetDocumentsMetadataResponse> call);

        partial void OnConstruction(DocumentService.DocumentServiceClient grpcClient, DocumentServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DocumentService client</summary>
        public override DocumentService.DocumentServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_GetDocumentRequest(ref GetDocumentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDocumentsRequest(ref ListDocumentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateDocumentRequest(ref CreateDocumentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDocumentRequest(ref UpdateDocumentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDocumentRequest(ref DeleteDocumentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportDocumentsRequest(ref ImportDocumentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PurgeDocumentsRequest(ref PurgeDocumentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchGetDocumentsMetadataRequest(ref BatchGetDocumentsMetadataRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets a [Document][google.cloud.discoveryengine.v1.Document].
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
        /// Gets a [Document][google.cloud.discoveryengine.v1.Document].
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
        /// Gets a list of [Document][google.cloud.discoveryengine.v1.Document]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Document"/> resources.</returns>
        public override gax::PagedEnumerable<ListDocumentsResponse, Document> ListDocuments(ListDocumentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDocumentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDocumentsRequest, ListDocumentsResponse, Document>(_callListDocuments, request, callSettings);
        }

        /// <summary>
        /// Gets a list of [Document][google.cloud.discoveryengine.v1.Document]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Document"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDocumentsResponse, Document> ListDocumentsAsync(ListDocumentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDocumentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDocumentsRequest, ListDocumentsResponse, Document>(_callListDocuments, request, callSettings);
        }

        /// <summary>
        /// Creates a [Document][google.cloud.discoveryengine.v1.Document].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Document CreateDocument(CreateDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDocumentRequest(ref request, ref callSettings);
            return _callCreateDocument.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a [Document][google.cloud.discoveryengine.v1.Document].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Document> CreateDocumentAsync(CreateDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDocumentRequest(ref request, ref callSettings);
            return _callCreateDocument.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a [Document][google.cloud.discoveryengine.v1.Document].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Document UpdateDocument(UpdateDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDocumentRequest(ref request, ref callSettings);
            return _callUpdateDocument.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a [Document][google.cloud.discoveryengine.v1.Document].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Document> UpdateDocumentAsync(UpdateDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDocumentRequest(ref request, ref callSettings);
            return _callUpdateDocument.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a [Document][google.cloud.discoveryengine.v1.Document].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteDocument(DeleteDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDocumentRequest(ref request, ref callSettings);
            _callDeleteDocument.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a [Document][google.cloud.discoveryengine.v1.Document].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteDocumentAsync(DeleteDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDocumentRequest(ref request, ref callSettings);
            return _callDeleteDocument.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>ImportDocuments</c>.</summary>
        public override lro::OperationsClient ImportDocumentsOperationsClient { get; }

        /// <summary>
        /// Bulk import of multiple
        /// [Document][google.cloud.discoveryengine.v1.Document]s. Request processing
        /// may be synchronous. Non-existing items are created.
        /// 
        /// Note: It is possible for a subset of the
        /// [Document][google.cloud.discoveryengine.v1.Document]s to be successfully
        /// updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ImportDocumentsResponse, ImportDocumentsMetadata> ImportDocuments(ImportDocumentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportDocumentsRequest(ref request, ref callSettings);
            return new lro::Operation<ImportDocumentsResponse, ImportDocumentsMetadata>(_callImportDocuments.Sync(request, callSettings), ImportDocumentsOperationsClient);
        }

        /// <summary>
        /// Bulk import of multiple
        /// [Document][google.cloud.discoveryengine.v1.Document]s. Request processing
        /// may be synchronous. Non-existing items are created.
        /// 
        /// Note: It is possible for a subset of the
        /// [Document][google.cloud.discoveryengine.v1.Document]s to be successfully
        /// updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ImportDocumentsResponse, ImportDocumentsMetadata>> ImportDocumentsAsync(ImportDocumentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportDocumentsRequest(ref request, ref callSettings);
            return new lro::Operation<ImportDocumentsResponse, ImportDocumentsMetadata>(await _callImportDocuments.Async(request, callSettings).ConfigureAwait(false), ImportDocumentsOperationsClient);
        }

        /// <summary>The long-running operations client for <c>PurgeDocuments</c>.</summary>
        public override lro::OperationsClient PurgeDocumentsOperationsClient { get; }

        /// <summary>
        /// Permanently deletes all selected
        /// [Document][google.cloud.discoveryengine.v1.Document]s in a branch.
        /// 
        /// This process is asynchronous. Depending on the number of
        /// [Document][google.cloud.discoveryengine.v1.Document]s to be deleted, this
        /// operation can take hours to complete. Before the delete operation
        /// completes, some [Document][google.cloud.discoveryengine.v1.Document]s might
        /// still be returned by
        /// [DocumentService.GetDocument][google.cloud.discoveryengine.v1.DocumentService.GetDocument]
        /// or
        /// [DocumentService.ListDocuments][google.cloud.discoveryengine.v1.DocumentService.ListDocuments].
        /// 
        /// To get a list of the [Document][google.cloud.discoveryengine.v1.Document]s
        /// to be deleted, set
        /// [PurgeDocumentsRequest.force][google.cloud.discoveryengine.v1.PurgeDocumentsRequest.force]
        /// to false.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<PurgeDocumentsResponse, PurgeDocumentsMetadata> PurgeDocuments(PurgeDocumentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PurgeDocumentsRequest(ref request, ref callSettings);
            return new lro::Operation<PurgeDocumentsResponse, PurgeDocumentsMetadata>(_callPurgeDocuments.Sync(request, callSettings), PurgeDocumentsOperationsClient);
        }

        /// <summary>
        /// Permanently deletes all selected
        /// [Document][google.cloud.discoveryengine.v1.Document]s in a branch.
        /// 
        /// This process is asynchronous. Depending on the number of
        /// [Document][google.cloud.discoveryengine.v1.Document]s to be deleted, this
        /// operation can take hours to complete. Before the delete operation
        /// completes, some [Document][google.cloud.discoveryengine.v1.Document]s might
        /// still be returned by
        /// [DocumentService.GetDocument][google.cloud.discoveryengine.v1.DocumentService.GetDocument]
        /// or
        /// [DocumentService.ListDocuments][google.cloud.discoveryengine.v1.DocumentService.ListDocuments].
        /// 
        /// To get a list of the [Document][google.cloud.discoveryengine.v1.Document]s
        /// to be deleted, set
        /// [PurgeDocumentsRequest.force][google.cloud.discoveryengine.v1.PurgeDocumentsRequest.force]
        /// to false.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<PurgeDocumentsResponse, PurgeDocumentsMetadata>> PurgeDocumentsAsync(PurgeDocumentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PurgeDocumentsRequest(ref request, ref callSettings);
            return new lro::Operation<PurgeDocumentsResponse, PurgeDocumentsMetadata>(await _callPurgeDocuments.Async(request, callSettings).ConfigureAwait(false), PurgeDocumentsOperationsClient);
        }

        /// <summary>
        /// Gets index freshness metadata for
        /// [Document][google.cloud.discoveryengine.v1.Document]s. Supported for
        /// website search only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchGetDocumentsMetadataResponse BatchGetDocumentsMetadata(BatchGetDocumentsMetadataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchGetDocumentsMetadataRequest(ref request, ref callSettings);
            return _callBatchGetDocumentsMetadata.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets index freshness metadata for
        /// [Document][google.cloud.discoveryengine.v1.Document]s. Supported for
        /// website search only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchGetDocumentsMetadataResponse> BatchGetDocumentsMetadataAsync(BatchGetDocumentsMetadataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchGetDocumentsMetadataRequest(ref request, ref callSettings);
            return _callBatchGetDocumentsMetadata.Async(request, callSettings);
        }
    }

    public partial class ListDocumentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDocumentsResponse : gaxgrpc::IPageResponse<Document>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Document> GetEnumerator() => Documents.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class DocumentService
    {
        public partial class DocumentServiceClient
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

    public static partial class DocumentService
    {
        public partial class DocumentServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="gcl::Locations.LocationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gcl::Locations.LocationsClient"/> for the same target as this client.
            /// </returns>
            public virtual gcl::Locations.LocationsClient CreateLocationsClient() =>
                new gcl::Locations.LocationsClient(CallInvoker);
        }
    }
}
