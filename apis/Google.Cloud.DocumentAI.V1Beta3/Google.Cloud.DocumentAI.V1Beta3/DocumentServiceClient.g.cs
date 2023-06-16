// Copyright 2023 Google LLC
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
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

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
            return DocumentServiceClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<DocumentServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DocumentServiceClient.Create(callInvoker, Settings, Logger);
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
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Dataset, UpdateDatasetOperationMetadata> UpdateDataset(UpdateDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates metadata associated with a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Dataset, UpdateDatasetOperationMetadata>> UpdateDatasetAsync(UpdateDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates metadata associated with a dataset.
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
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            UpdateDatasetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateDatasetOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callUpdateDataset = clientHelper.BuildApiCall<UpdateDatasetRequest, lro::Operation>("UpdateDataset", grpcClient.UpdateDatasetAsync, grpcClient.UpdateDataset, effectiveSettings.UpdateDatasetSettings).WithGoogleRequestParam("dataset.name", request => request.Dataset?.Name);
            Modify_ApiCall(ref _callUpdateDataset);
            Modify_UpdateDatasetApiCall(ref _callUpdateDataset);
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

        partial void Modify_GetDatasetSchemaApiCall(ref gaxgrpc::ApiCall<GetDatasetSchemaRequest, DatasetSchema> call);

        partial void Modify_UpdateDatasetSchemaApiCall(ref gaxgrpc::ApiCall<UpdateDatasetSchemaRequest, DatasetSchema> call);

        partial void OnConstruction(DocumentService.DocumentServiceClient grpcClient, DocumentServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DocumentService client</summary>
        public override DocumentService.DocumentServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_UpdateDatasetRequest(ref UpdateDatasetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDatasetSchemaRequest(ref GetDatasetSchemaRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDatasetSchemaRequest(ref UpdateDatasetSchemaRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>UpdateDataset</c>.</summary>
        public override lro::OperationsClient UpdateDatasetOperationsClient { get; }

        /// <summary>
        /// Updates metadata associated with a dataset.
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
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Dataset, UpdateDatasetOperationMetadata>> UpdateDatasetAsync(UpdateDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDatasetRequest(ref request, ref callSettings);
            return new lro::Operation<Dataset, UpdateDatasetOperationMetadata>(await _callUpdateDataset.Async(request, callSettings).ConfigureAwait(false), UpdateDatasetOperationsClient);
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
