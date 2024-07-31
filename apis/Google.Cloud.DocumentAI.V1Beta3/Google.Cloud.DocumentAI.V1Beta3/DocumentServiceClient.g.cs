// Copyright 2024 Google LLC
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

namespace Google.Cloud.DocumentAI.V1Beta3
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
            UpdateDatasetSettings = existing.UpdateDatasetSettings;
            UpdateDatasetOperationsSettings = existing.UpdateDatasetOperationsSettings.Clone();
            ImportDocumentsSettings = existing.ImportDocumentsSettings;
            ImportDocumentsOperationsSettings = existing.ImportDocumentsOperationsSettings.Clone();
            GetDocumentSettings = existing.GetDocumentSettings;
            ListDocumentsSettings = existing.ListDocumentsSettings;
            BatchDeleteDocumentsSettings = existing.BatchDeleteDocumentsSettings;
            BatchDeleteDocumentsOperationsSettings = existing.BatchDeleteDocumentsOperationsSettings.Clone();
            GetDatasetSchemaSettings = existing.GetDatasetSchemaSettings;
            UpdateDatasetSchemaSettings = existing.UpdateDatasetSchemaSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DocumentServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentServiceClient.UpdateDataset</c> and <c>DocumentServiceClient.UpdateDatasetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDatasetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DocumentServiceClient.UpdateDataset</c> and
        /// <c>DocumentServiceClient.UpdateDatasetAsync</c>.
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
        public lro::OperationsSettings UpdateDatasetOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentServiceClient.ImportDocuments</c> and <c>DocumentServiceClient.ImportDocumentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ImportDocumentsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

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
        /// <c>DocumentServiceClient.GetDocument</c> and <c>DocumentServiceClient.GetDocumentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDocumentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentServiceClient.ListDocuments</c> and <c>DocumentServiceClient.ListDocumentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDocumentsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentServiceClient.BatchDeleteDocuments</c> and <c>DocumentServiceClient.BatchDeleteDocumentsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchDeleteDocumentsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DocumentServiceClient.BatchDeleteDocuments</c> and
        /// <c>DocumentServiceClient.BatchDeleteDocumentsAsync</c>.
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
        public lro::OperationsSettings BatchDeleteDocumentsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentServiceClient.GetDatasetSchema</c> and <c>DocumentServiceClient.GetDatasetSchemaAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDatasetSchemaSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentServiceClient.UpdateDatasetSchema</c> and <c>DocumentServiceClient.UpdateDatasetSchemaAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDatasetSchemaSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

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
    /// Service to call Cloud DocumentAI to manage document collection (dataset).
    /// </remarks>
    public abstract partial class DocumentServiceClient
    {
        /// <summary>
        /// The default endpoint for the DocumentService service, which is a host of "documentai.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "documentai.googleapis.com:443";

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
        /// Updates metadata associated with a dataset.
        /// Note that this method requires the
        /// `documentai.googleapis.com/datasets.update` permission on the project,
        /// which is highly privileged. A user or service account with this permission
        /// can create new processors that can interact with any gcs bucket in your
        /// project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Dataset, UpdateDatasetOperationMetadata> UpdateDataset(UpdateDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates metadata associated with a dataset.
        /// Note that this method requires the
        /// `documentai.googleapis.com/datasets.update` permission on the project,
        /// which is highly privileged. A user or service account with this permission
        /// can create new processors that can interact with any gcs bucket in your
        /// project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Dataset, UpdateDatasetOperationMetadata>> UpdateDatasetAsync(UpdateDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates metadata associated with a dataset.
        /// Note that this method requires the
        /// `documentai.googleapis.com/datasets.update` permission on the project,
        /// which is highly privileged. A user or service account with this permission
        /// can create new processors that can interact with any gcs bucket in your
        /// project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Dataset, UpdateDatasetOperationMetadata>> UpdateDatasetAsync(UpdateDatasetRequest request, st::CancellationToken cancellationToken) =>
            UpdateDatasetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateDataset</c>.</summary>
        public virtual lro::OperationsClient UpdateDatasetOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateDataset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Dataset, UpdateDatasetOperationMetadata> PollOnceUpdateDataset(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Dataset, UpdateDatasetOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDatasetOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateDataset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Dataset, UpdateDatasetOperationMetadata>> PollOnceUpdateDatasetAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Dataset, UpdateDatasetOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDatasetOperationsClient, callSettings);

        /// <summary>
        /// Updates metadata associated with a dataset.
        /// Note that this method requires the
        /// `documentai.googleapis.com/datasets.update` permission on the project,
        /// which is highly privileged. A user or service account with this permission
        /// can create new processors that can interact with any gcs bucket in your
        /// project.
        /// </summary>
        /// <param name="dataset">
        /// Required. The `name` field of the `Dataset` is used to identify the
        /// resource to be updated.
        /// </param>
        /// <param name="updateMask">
        /// The update mask applies to the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Dataset, UpdateDatasetOperationMetadata> UpdateDataset(Dataset dataset, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataset(new UpdateDatasetRequest
            {
                Dataset = gax::GaxPreconditions.CheckNotNull(dataset, nameof(dataset)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates metadata associated with a dataset.
        /// Note that this method requires the
        /// `documentai.googleapis.com/datasets.update` permission on the project,
        /// which is highly privileged. A user or service account with this permission
        /// can create new processors that can interact with any gcs bucket in your
        /// project.
        /// </summary>
        /// <param name="dataset">
        /// Required. The `name` field of the `Dataset` is used to identify the
        /// resource to be updated.
        /// </param>
        /// <param name="updateMask">
        /// The update mask applies to the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Dataset, UpdateDatasetOperationMetadata>> UpdateDatasetAsync(Dataset dataset, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDatasetAsync(new UpdateDatasetRequest
            {
                Dataset = gax::GaxPreconditions.CheckNotNull(dataset, nameof(dataset)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates metadata associated with a dataset.
        /// Note that this method requires the
        /// `documentai.googleapis.com/datasets.update` permission on the project,
        /// which is highly privileged. A user or service account with this permission
        /// can create new processors that can interact with any gcs bucket in your
        /// project.
        /// </summary>
        /// <param name="dataset">
        /// Required. The `name` field of the `Dataset` is used to identify the
        /// resource to be updated.
        /// </param>
        /// <param name="updateMask">
        /// The update mask applies to the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Dataset, UpdateDatasetOperationMetadata>> UpdateDatasetAsync(Dataset dataset, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDatasetAsync(dataset, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Import documents into a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportDocumentsResponse, ImportDocumentsMetadata> ImportDocuments(ImportDocumentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Import documents into a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportDocumentsResponse, ImportDocumentsMetadata>> ImportDocumentsAsync(ImportDocumentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Import documents into a dataset.
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
        /// Import documents into a dataset.
        /// </summary>
        /// <param name="dataset">
        /// Required. The dataset resource name.
        /// Format:
        /// projects/{project}/locations/{location}/processors/{processor}/dataset
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportDocumentsResponse, ImportDocumentsMetadata> ImportDocuments(string dataset, gaxgrpc::CallSettings callSettings = null) =>
            ImportDocuments(new ImportDocumentsRequest
            {
                Dataset = gax::GaxPreconditions.CheckNotNullOrEmpty(dataset, nameof(dataset)),
            }, callSettings);

        /// <summary>
        /// Import documents into a dataset.
        /// </summary>
        /// <param name="dataset">
        /// Required. The dataset resource name.
        /// Format:
        /// projects/{project}/locations/{location}/processors/{processor}/dataset
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportDocumentsResponse, ImportDocumentsMetadata>> ImportDocumentsAsync(string dataset, gaxgrpc::CallSettings callSettings = null) =>
            ImportDocumentsAsync(new ImportDocumentsRequest
            {
                Dataset = gax::GaxPreconditions.CheckNotNullOrEmpty(dataset, nameof(dataset)),
            }, callSettings);

        /// <summary>
        /// Import documents into a dataset.
        /// </summary>
        /// <param name="dataset">
        /// Required. The dataset resource name.
        /// Format:
        /// projects/{project}/locations/{location}/processors/{processor}/dataset
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportDocumentsResponse, ImportDocumentsMetadata>> ImportDocumentsAsync(string dataset, st::CancellationToken cancellationToken) =>
            ImportDocumentsAsync(dataset, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Import documents into a dataset.
        /// </summary>
        /// <param name="dataset">
        /// Required. The dataset resource name.
        /// Format:
        /// projects/{project}/locations/{location}/processors/{processor}/dataset
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportDocumentsResponse, ImportDocumentsMetadata> ImportDocuments(DatasetName dataset, gaxgrpc::CallSettings callSettings = null) =>
            ImportDocuments(new ImportDocumentsRequest
            {
                DatasetAsDatasetName = gax::GaxPreconditions.CheckNotNull(dataset, nameof(dataset)),
            }, callSettings);

        /// <summary>
        /// Import documents into a dataset.
        /// </summary>
        /// <param name="dataset">
        /// Required. The dataset resource name.
        /// Format:
        /// projects/{project}/locations/{location}/processors/{processor}/dataset
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportDocumentsResponse, ImportDocumentsMetadata>> ImportDocumentsAsync(DatasetName dataset, gaxgrpc::CallSettings callSettings = null) =>
            ImportDocumentsAsync(new ImportDocumentsRequest
            {
                DatasetAsDatasetName = gax::GaxPreconditions.CheckNotNull(dataset, nameof(dataset)),
            }, callSettings);

        /// <summary>
        /// Import documents into a dataset.
        /// </summary>
        /// <param name="dataset">
        /// Required. The dataset resource name.
        /// Format:
        /// projects/{project}/locations/{location}/processors/{processor}/dataset
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportDocumentsResponse, ImportDocumentsMetadata>> ImportDocumentsAsync(DatasetName dataset, st::CancellationToken cancellationToken) =>
            ImportDocumentsAsync(dataset, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns relevant fields present in the requested document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GetDocumentResponse GetDocument(GetDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns relevant fields present in the requested document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetDocumentResponse> GetDocumentAsync(GetDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns relevant fields present in the requested document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetDocumentResponse> GetDocumentAsync(GetDocumentRequest request, st::CancellationToken cancellationToken) =>
            GetDocumentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns relevant fields present in the requested document.
        /// </summary>
        /// <param name="dataset">
        /// Required. The resource name of the dataset that the document belongs to .
        /// Format:
        /// projects/{project}/locations/{location}/processors/{processor}/dataset
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GetDocumentResponse GetDocument(string dataset, gaxgrpc::CallSettings callSettings = null) =>
            GetDocument(new GetDocumentRequest
            {
                Dataset = gax::GaxPreconditions.CheckNotNullOrEmpty(dataset, nameof(dataset)),
            }, callSettings);

        /// <summary>
        /// Returns relevant fields present in the requested document.
        /// </summary>
        /// <param name="dataset">
        /// Required. The resource name of the dataset that the document belongs to .
        /// Format:
        /// projects/{project}/locations/{location}/processors/{processor}/dataset
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetDocumentResponse> GetDocumentAsync(string dataset, gaxgrpc::CallSettings callSettings = null) =>
            GetDocumentAsync(new GetDocumentRequest
            {
                Dataset = gax::GaxPreconditions.CheckNotNullOrEmpty(dataset, nameof(dataset)),
            }, callSettings);

        /// <summary>
        /// Returns relevant fields present in the requested document.
        /// </summary>
        /// <param name="dataset">
        /// Required. The resource name of the dataset that the document belongs to .
        /// Format:
        /// projects/{project}/locations/{location}/processors/{processor}/dataset
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetDocumentResponse> GetDocumentAsync(string dataset, st::CancellationToken cancellationToken) =>
            GetDocumentAsync(dataset, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns relevant fields present in the requested document.
        /// </summary>
        /// <param name="dataset">
        /// Required. The resource name of the dataset that the document belongs to .
        /// Format:
        /// projects/{project}/locations/{location}/processors/{processor}/dataset
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GetDocumentResponse GetDocument(DatasetName dataset, gaxgrpc::CallSettings callSettings = null) =>
            GetDocument(new GetDocumentRequest
            {
                DatasetAsDatasetName = gax::GaxPreconditions.CheckNotNull(dataset, nameof(dataset)),
            }, callSettings);

        /// <summary>
        /// Returns relevant fields present in the requested document.
        /// </summary>
        /// <param name="dataset">
        /// Required. The resource name of the dataset that the document belongs to .
        /// Format:
        /// projects/{project}/locations/{location}/processors/{processor}/dataset
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetDocumentResponse> GetDocumentAsync(DatasetName dataset, gaxgrpc::CallSettings callSettings = null) =>
            GetDocumentAsync(new GetDocumentRequest
            {
                DatasetAsDatasetName = gax::GaxPreconditions.CheckNotNull(dataset, nameof(dataset)),
            }, callSettings);

        /// <summary>
        /// Returns relevant fields present in the requested document.
        /// </summary>
        /// <param name="dataset">
        /// Required. The resource name of the dataset that the document belongs to .
        /// Format:
        /// projects/{project}/locations/{location}/processors/{processor}/dataset
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetDocumentResponse> GetDocumentAsync(DatasetName dataset, st::CancellationToken cancellationToken) =>
            GetDocumentAsync(dataset, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a list of documents present in the dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DocumentMetadata"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDocumentsResponse, DocumentMetadata> ListDocuments(ListDocumentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of documents present in the dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DocumentMetadata"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDocumentsResponse, DocumentMetadata> ListDocumentsAsync(ListDocumentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of documents present in the dataset.
        /// </summary>
        /// <param name="dataset">
        /// Required. The resource name of the dataset to be listed.
        /// Format:
        /// projects/{project}/locations/{location}/processors/{processor}/dataset
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
        /// <returns>A pageable sequence of <see cref="DocumentMetadata"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDocumentsResponse, DocumentMetadata> ListDocuments(string dataset, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDocumentsRequest request = new ListDocumentsRequest
            {
                Dataset = gax::GaxPreconditions.CheckNotNullOrEmpty(dataset, nameof(dataset)),
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
        /// Returns a list of documents present in the dataset.
        /// </summary>
        /// <param name="dataset">
        /// Required. The resource name of the dataset to be listed.
        /// Format:
        /// projects/{project}/locations/{location}/processors/{processor}/dataset
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
        /// <returns>A pageable asynchronous sequence of <see cref="DocumentMetadata"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDocumentsResponse, DocumentMetadata> ListDocumentsAsync(string dataset, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDocumentsRequest request = new ListDocumentsRequest
            {
                Dataset = gax::GaxPreconditions.CheckNotNullOrEmpty(dataset, nameof(dataset)),
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
        /// Returns a list of documents present in the dataset.
        /// </summary>
        /// <param name="dataset">
        /// Required. The resource name of the dataset to be listed.
        /// Format:
        /// projects/{project}/locations/{location}/processors/{processor}/dataset
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
        /// <returns>A pageable sequence of <see cref="DocumentMetadata"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDocumentsResponse, DocumentMetadata> ListDocuments(DatasetName dataset, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDocumentsRequest request = new ListDocumentsRequest
            {
                DatasetAsDatasetName = gax::GaxPreconditions.CheckNotNull(dataset, nameof(dataset)),
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
        /// Returns a list of documents present in the dataset.
        /// </summary>
        /// <param name="dataset">
        /// Required. The resource name of the dataset to be listed.
        /// Format:
        /// projects/{project}/locations/{location}/processors/{processor}/dataset
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
        /// <returns>A pageable asynchronous sequence of <see cref="DocumentMetadata"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDocumentsResponse, DocumentMetadata> ListDocumentsAsync(DatasetName dataset, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDocumentsRequest request = new ListDocumentsRequest
            {
                DatasetAsDatasetName = gax::GaxPreconditions.CheckNotNull(dataset, nameof(dataset)),
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
        /// Deletes a set of documents.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchDeleteDocumentsResponse, BatchDeleteDocumentsMetadata> BatchDeleteDocuments(BatchDeleteDocumentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a set of documents.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchDeleteDocumentsResponse, BatchDeleteDocumentsMetadata>> BatchDeleteDocumentsAsync(BatchDeleteDocumentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a set of documents.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchDeleteDocumentsResponse, BatchDeleteDocumentsMetadata>> BatchDeleteDocumentsAsync(BatchDeleteDocumentsRequest request, st::CancellationToken cancellationToken) =>
            BatchDeleteDocumentsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>BatchDeleteDocuments</c>.</summary>
        public virtual lro::OperationsClient BatchDeleteDocumentsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchDeleteDocuments</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BatchDeleteDocumentsResponse, BatchDeleteDocumentsMetadata> PollOnceBatchDeleteDocuments(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchDeleteDocumentsResponse, BatchDeleteDocumentsMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchDeleteDocumentsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchDeleteDocuments</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BatchDeleteDocumentsResponse, BatchDeleteDocumentsMetadata>> PollOnceBatchDeleteDocumentsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchDeleteDocumentsResponse, BatchDeleteDocumentsMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchDeleteDocumentsOperationsClient, callSettings);

        /// <summary>
        /// Deletes a set of documents.
        /// </summary>
        /// <param name="dataset">
        /// Required. The dataset resource name.
        /// Format:
        /// projects/{project}/locations/{location}/processors/{processor}/dataset
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchDeleteDocumentsResponse, BatchDeleteDocumentsMetadata> BatchDeleteDocuments(string dataset, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteDocuments(new BatchDeleteDocumentsRequest
            {
                Dataset = gax::GaxPreconditions.CheckNotNullOrEmpty(dataset, nameof(dataset)),
            }, callSettings);

        /// <summary>
        /// Deletes a set of documents.
        /// </summary>
        /// <param name="dataset">
        /// Required. The dataset resource name.
        /// Format:
        /// projects/{project}/locations/{location}/processors/{processor}/dataset
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchDeleteDocumentsResponse, BatchDeleteDocumentsMetadata>> BatchDeleteDocumentsAsync(string dataset, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteDocumentsAsync(new BatchDeleteDocumentsRequest
            {
                Dataset = gax::GaxPreconditions.CheckNotNullOrEmpty(dataset, nameof(dataset)),
            }, callSettings);

        /// <summary>
        /// Deletes a set of documents.
        /// </summary>
        /// <param name="dataset">
        /// Required. The dataset resource name.
        /// Format:
        /// projects/{project}/locations/{location}/processors/{processor}/dataset
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchDeleteDocumentsResponse, BatchDeleteDocumentsMetadata>> BatchDeleteDocumentsAsync(string dataset, st::CancellationToken cancellationToken) =>
            BatchDeleteDocumentsAsync(dataset, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the `DatasetSchema` of a `Dataset`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DatasetSchema GetDatasetSchema(GetDatasetSchemaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the `DatasetSchema` of a `Dataset`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DatasetSchema> GetDatasetSchemaAsync(GetDatasetSchemaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the `DatasetSchema` of a `Dataset`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DatasetSchema> GetDatasetSchemaAsync(GetDatasetSchemaRequest request, st::CancellationToken cancellationToken) =>
            GetDatasetSchemaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the `DatasetSchema` of a `Dataset`.
        /// </summary>
        /// <param name="name">
        /// Required. The dataset schema resource name.
        /// Format:
        /// projects/{project}/locations/{location}/processors/{processor}/dataset/datasetSchema
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DatasetSchema GetDatasetSchema(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDatasetSchema(new GetDatasetSchemaRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the `DatasetSchema` of a `Dataset`.
        /// </summary>
        /// <param name="name">
        /// Required. The dataset schema resource name.
        /// Format:
        /// projects/{project}/locations/{location}/processors/{processor}/dataset/datasetSchema
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DatasetSchema> GetDatasetSchemaAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDatasetSchemaAsync(new GetDatasetSchemaRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the `DatasetSchema` of a `Dataset`.
        /// </summary>
        /// <param name="name">
        /// Required. The dataset schema resource name.
        /// Format:
        /// projects/{project}/locations/{location}/processors/{processor}/dataset/datasetSchema
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DatasetSchema> GetDatasetSchemaAsync(string name, st::CancellationToken cancellationToken) =>
            GetDatasetSchemaAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the `DatasetSchema` of a `Dataset`.
        /// </summary>
        /// <param name="name">
        /// Required. The dataset schema resource name.
        /// Format:
        /// projects/{project}/locations/{location}/processors/{processor}/dataset/datasetSchema
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DatasetSchema GetDatasetSchema(DatasetSchemaName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDatasetSchema(new GetDatasetSchemaRequest
            {
                DatasetSchemaName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the `DatasetSchema` of a `Dataset`.
        /// </summary>
        /// <param name="name">
        /// Required. The dataset schema resource name.
        /// Format:
        /// projects/{project}/locations/{location}/processors/{processor}/dataset/datasetSchema
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DatasetSchema> GetDatasetSchemaAsync(DatasetSchemaName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDatasetSchemaAsync(new GetDatasetSchemaRequest
            {
                DatasetSchemaName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the `DatasetSchema` of a `Dataset`.
        /// </summary>
        /// <param name="name">
        /// Required. The dataset schema resource name.
        /// Format:
        /// projects/{project}/locations/{location}/processors/{processor}/dataset/datasetSchema
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DatasetSchema> GetDatasetSchemaAsync(DatasetSchemaName name, st::CancellationToken cancellationToken) =>
            GetDatasetSchemaAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `DatasetSchema`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DatasetSchema UpdateDatasetSchema(UpdateDatasetSchemaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `DatasetSchema`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DatasetSchema> UpdateDatasetSchemaAsync(UpdateDatasetSchemaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `DatasetSchema`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DatasetSchema> UpdateDatasetSchemaAsync(UpdateDatasetSchemaRequest request, st::CancellationToken cancellationToken) =>
            UpdateDatasetSchemaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `DatasetSchema`.
        /// </summary>
        /// <param name="datasetSchema">
        /// Required. The name field of the `DatasetSchema` is used to identify the
        /// resource to be updated.
        /// </param>
        /// <param name="updateMask">
        /// The update mask applies to the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DatasetSchema UpdateDatasetSchema(DatasetSchema datasetSchema, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDatasetSchema(new UpdateDatasetSchemaRequest
            {
                DatasetSchema = gax::GaxPreconditions.CheckNotNull(datasetSchema, nameof(datasetSchema)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a `DatasetSchema`.
        /// </summary>
        /// <param name="datasetSchema">
        /// Required. The name field of the `DatasetSchema` is used to identify the
        /// resource to be updated.
        /// </param>
        /// <param name="updateMask">
        /// The update mask applies to the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DatasetSchema> UpdateDatasetSchemaAsync(DatasetSchema datasetSchema, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDatasetSchemaAsync(new UpdateDatasetSchemaRequest
            {
                DatasetSchema = gax::GaxPreconditions.CheckNotNull(datasetSchema, nameof(datasetSchema)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a `DatasetSchema`.
        /// </summary>
        /// <param name="datasetSchema">
        /// Required. The name field of the `DatasetSchema` is used to identify the
        /// resource to be updated.
        /// </param>
        /// <param name="updateMask">
        /// The update mask applies to the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DatasetSchema> UpdateDatasetSchemaAsync(DatasetSchema datasetSchema, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDatasetSchemaAsync(datasetSchema, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>DocumentService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to call Cloud DocumentAI to manage document collection (dataset).
    /// </remarks>
    public sealed partial class DocumentServiceClientImpl : DocumentServiceClient
    {
        private readonly gaxgrpc::ApiCall<UpdateDatasetRequest, lro::Operation> _callUpdateDataset;

        private readonly gaxgrpc::ApiCall<ImportDocumentsRequest, lro::Operation> _callImportDocuments;

        private readonly gaxgrpc::ApiCall<GetDocumentRequest, GetDocumentResponse> _callGetDocument;

        private readonly gaxgrpc::ApiCall<ListDocumentsRequest, ListDocumentsResponse> _callListDocuments;

        private readonly gaxgrpc::ApiCall<BatchDeleteDocumentsRequest, lro::Operation> _callBatchDeleteDocuments;

        private readonly gaxgrpc::ApiCall<GetDatasetSchemaRequest, DatasetSchema> _callGetDatasetSchema;

        private readonly gaxgrpc::ApiCall<UpdateDatasetSchemaRequest, DatasetSchema> _callUpdateDatasetSchema;

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
            UpdateDatasetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateDatasetOperationsSettings, logger);
            ImportDocumentsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ImportDocumentsOperationsSettings, logger);
            BatchDeleteDocumentsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.BatchDeleteDocumentsOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callUpdateDataset = clientHelper.BuildApiCall<UpdateDatasetRequest, lro::Operation>("UpdateDataset", grpcClient.UpdateDatasetAsync, grpcClient.UpdateDataset, effectiveSettings.UpdateDatasetSettings).WithGoogleRequestParam("dataset.name", request => request.Dataset?.Name);
            Modify_ApiCall(ref _callUpdateDataset);
            Modify_UpdateDatasetApiCall(ref _callUpdateDataset);
            _callImportDocuments = clientHelper.BuildApiCall<ImportDocumentsRequest, lro::Operation>("ImportDocuments", grpcClient.ImportDocumentsAsync, grpcClient.ImportDocuments, effectiveSettings.ImportDocumentsSettings).WithGoogleRequestParam("dataset", request => request.Dataset);
            Modify_ApiCall(ref _callImportDocuments);
            Modify_ImportDocumentsApiCall(ref _callImportDocuments);
            _callGetDocument = clientHelper.BuildApiCall<GetDocumentRequest, GetDocumentResponse>("GetDocument", grpcClient.GetDocumentAsync, grpcClient.GetDocument, effectiveSettings.GetDocumentSettings).WithGoogleRequestParam("dataset", request => request.Dataset);
            Modify_ApiCall(ref _callGetDocument);
            Modify_GetDocumentApiCall(ref _callGetDocument);
            _callListDocuments = clientHelper.BuildApiCall<ListDocumentsRequest, ListDocumentsResponse>("ListDocuments", grpcClient.ListDocumentsAsync, grpcClient.ListDocuments, effectiveSettings.ListDocumentsSettings).WithGoogleRequestParam("dataset", request => request.Dataset);
            Modify_ApiCall(ref _callListDocuments);
            Modify_ListDocumentsApiCall(ref _callListDocuments);
            _callBatchDeleteDocuments = clientHelper.BuildApiCall<BatchDeleteDocumentsRequest, lro::Operation>("BatchDeleteDocuments", grpcClient.BatchDeleteDocumentsAsync, grpcClient.BatchDeleteDocuments, effectiveSettings.BatchDeleteDocumentsSettings).WithGoogleRequestParam("dataset", request => request.Dataset);
            Modify_ApiCall(ref _callBatchDeleteDocuments);
            Modify_BatchDeleteDocumentsApiCall(ref _callBatchDeleteDocuments);
            _callGetDatasetSchema = clientHelper.BuildApiCall<GetDatasetSchemaRequest, DatasetSchema>("GetDatasetSchema", grpcClient.GetDatasetSchemaAsync, grpcClient.GetDatasetSchema, effectiveSettings.GetDatasetSchemaSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDatasetSchema);
            Modify_GetDatasetSchemaApiCall(ref _callGetDatasetSchema);
            _callUpdateDatasetSchema = clientHelper.BuildApiCall<UpdateDatasetSchemaRequest, DatasetSchema>("UpdateDatasetSchema", grpcClient.UpdateDatasetSchemaAsync, grpcClient.UpdateDatasetSchema, effectiveSettings.UpdateDatasetSchemaSettings).WithGoogleRequestParam("dataset_schema.name", request => request.DatasetSchema?.Name);
            Modify_ApiCall(ref _callUpdateDatasetSchema);
            Modify_UpdateDatasetSchemaApiCall(ref _callUpdateDatasetSchema);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_UpdateDatasetApiCall(ref gaxgrpc::ApiCall<UpdateDatasetRequest, lro::Operation> call);

        partial void Modify_ImportDocumentsApiCall(ref gaxgrpc::ApiCall<ImportDocumentsRequest, lro::Operation> call);

        partial void Modify_GetDocumentApiCall(ref gaxgrpc::ApiCall<GetDocumentRequest, GetDocumentResponse> call);

        partial void Modify_ListDocumentsApiCall(ref gaxgrpc::ApiCall<ListDocumentsRequest, ListDocumentsResponse> call);

        partial void Modify_BatchDeleteDocumentsApiCall(ref gaxgrpc::ApiCall<BatchDeleteDocumentsRequest, lro::Operation> call);

        partial void Modify_GetDatasetSchemaApiCall(ref gaxgrpc::ApiCall<GetDatasetSchemaRequest, DatasetSchema> call);

        partial void Modify_UpdateDatasetSchemaApiCall(ref gaxgrpc::ApiCall<UpdateDatasetSchemaRequest, DatasetSchema> call);

        partial void OnConstruction(DocumentService.DocumentServiceClient grpcClient, DocumentServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DocumentService client</summary>
        public override DocumentService.DocumentServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_UpdateDatasetRequest(ref UpdateDatasetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportDocumentsRequest(ref ImportDocumentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDocumentRequest(ref GetDocumentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDocumentsRequest(ref ListDocumentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchDeleteDocumentsRequest(ref BatchDeleteDocumentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDatasetSchemaRequest(ref GetDatasetSchemaRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDatasetSchemaRequest(ref UpdateDatasetSchemaRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>UpdateDataset</c>.</summary>
        public override lro::OperationsClient UpdateDatasetOperationsClient { get; }

        /// <summary>
        /// Updates metadata associated with a dataset.
        /// Note that this method requires the
        /// `documentai.googleapis.com/datasets.update` permission on the project,
        /// which is highly privileged. A user or service account with this permission
        /// can create new processors that can interact with any gcs bucket in your
        /// project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Dataset, UpdateDatasetOperationMetadata> UpdateDataset(UpdateDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDatasetRequest(ref request, ref callSettings);
            return new lro::Operation<Dataset, UpdateDatasetOperationMetadata>(_callUpdateDataset.Sync(request, callSettings), UpdateDatasetOperationsClient);
        }

        /// <summary>
        /// Updates metadata associated with a dataset.
        /// Note that this method requires the
        /// `documentai.googleapis.com/datasets.update` permission on the project,
        /// which is highly privileged. A user or service account with this permission
        /// can create new processors that can interact with any gcs bucket in your
        /// project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Dataset, UpdateDatasetOperationMetadata>> UpdateDatasetAsync(UpdateDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDatasetRequest(ref request, ref callSettings);
            return new lro::Operation<Dataset, UpdateDatasetOperationMetadata>(await _callUpdateDataset.Async(request, callSettings).ConfigureAwait(false), UpdateDatasetOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ImportDocuments</c>.</summary>
        public override lro::OperationsClient ImportDocumentsOperationsClient { get; }

        /// <summary>
        /// Import documents into a dataset.
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
        /// Import documents into a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ImportDocumentsResponse, ImportDocumentsMetadata>> ImportDocumentsAsync(ImportDocumentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportDocumentsRequest(ref request, ref callSettings);
            return new lro::Operation<ImportDocumentsResponse, ImportDocumentsMetadata>(await _callImportDocuments.Async(request, callSettings).ConfigureAwait(false), ImportDocumentsOperationsClient);
        }

        /// <summary>
        /// Returns relevant fields present in the requested document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GetDocumentResponse GetDocument(GetDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDocumentRequest(ref request, ref callSettings);
            return _callGetDocument.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns relevant fields present in the requested document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GetDocumentResponse> GetDocumentAsync(GetDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDocumentRequest(ref request, ref callSettings);
            return _callGetDocument.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a list of documents present in the dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DocumentMetadata"/> resources.</returns>
        public override gax::PagedEnumerable<ListDocumentsResponse, DocumentMetadata> ListDocuments(ListDocumentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDocumentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDocumentsRequest, ListDocumentsResponse, DocumentMetadata>(_callListDocuments, request, callSettings);
        }

        /// <summary>
        /// Returns a list of documents present in the dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DocumentMetadata"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDocumentsResponse, DocumentMetadata> ListDocumentsAsync(ListDocumentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDocumentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDocumentsRequest, ListDocumentsResponse, DocumentMetadata>(_callListDocuments, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>BatchDeleteDocuments</c>.</summary>
        public override lro::OperationsClient BatchDeleteDocumentsOperationsClient { get; }

        /// <summary>
        /// Deletes a set of documents.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BatchDeleteDocumentsResponse, BatchDeleteDocumentsMetadata> BatchDeleteDocuments(BatchDeleteDocumentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeleteDocumentsRequest(ref request, ref callSettings);
            return new lro::Operation<BatchDeleteDocumentsResponse, BatchDeleteDocumentsMetadata>(_callBatchDeleteDocuments.Sync(request, callSettings), BatchDeleteDocumentsOperationsClient);
        }

        /// <summary>
        /// Deletes a set of documents.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BatchDeleteDocumentsResponse, BatchDeleteDocumentsMetadata>> BatchDeleteDocumentsAsync(BatchDeleteDocumentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeleteDocumentsRequest(ref request, ref callSettings);
            return new lro::Operation<BatchDeleteDocumentsResponse, BatchDeleteDocumentsMetadata>(await _callBatchDeleteDocuments.Async(request, callSettings).ConfigureAwait(false), BatchDeleteDocumentsOperationsClient);
        }

        /// <summary>
        /// Gets the `DatasetSchema` of a `Dataset`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DatasetSchema GetDatasetSchema(GetDatasetSchemaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDatasetSchemaRequest(ref request, ref callSettings);
            return _callGetDatasetSchema.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the `DatasetSchema` of a `Dataset`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DatasetSchema> GetDatasetSchemaAsync(GetDatasetSchemaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDatasetSchemaRequest(ref request, ref callSettings);
            return _callGetDatasetSchema.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a `DatasetSchema`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DatasetSchema UpdateDatasetSchema(UpdateDatasetSchemaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDatasetSchemaRequest(ref request, ref callSettings);
            return _callUpdateDatasetSchema.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a `DatasetSchema`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DatasetSchema> UpdateDatasetSchemaAsync(UpdateDatasetSchemaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDatasetSchemaRequest(ref request, ref callSettings);
            return _callUpdateDatasetSchema.Async(request, callSettings);
        }
    }

    public partial class ListDocumentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDocumentsResponse : gaxgrpc::IPageResponse<DocumentMetadata>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DocumentMetadata> GetEnumerator() => DocumentMetadata.GetEnumerator();

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
