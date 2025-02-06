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
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Datastore.Admin.V1
{
    /// <summary>Settings for <see cref="DatastoreAdminClient"/> instances.</summary>
    public sealed partial class DatastoreAdminSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DatastoreAdminSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DatastoreAdminSettings"/>.</returns>
        public static DatastoreAdminSettings GetDefault() => new DatastoreAdminSettings();

        /// <summary>Constructs a new <see cref="DatastoreAdminSettings"/> object with default settings.</summary>
        public DatastoreAdminSettings()
        {
        }

        private DatastoreAdminSettings(DatastoreAdminSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ExportEntitiesSettings = existing.ExportEntitiesSettings;
            ExportEntitiesOperationsSettings = existing.ExportEntitiesOperationsSettings.Clone();
            ImportEntitiesSettings = existing.ImportEntitiesSettings;
            ImportEntitiesOperationsSettings = existing.ImportEntitiesOperationsSettings.Clone();
            CreateIndexSettings = existing.CreateIndexSettings;
            CreateIndexOperationsSettings = existing.CreateIndexOperationsSettings.Clone();
            DeleteIndexSettings = existing.DeleteIndexSettings;
            DeleteIndexOperationsSettings = existing.DeleteIndexOperationsSettings.Clone();
            GetIndexSettings = existing.GetIndexSettings;
            ListIndexesSettings = existing.ListIndexesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DatastoreAdminSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatastoreAdminClient.ExportEntities</c> and <c>DatastoreAdminClient.ExportEntitiesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExportEntitiesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DatastoreAdminClient.ExportEntities</c> and
        /// <c>DatastoreAdminClient.ExportEntitiesAsync</c>.
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
        public lro::OperationsSettings ExportEntitiesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatastoreAdminClient.ImportEntities</c> and <c>DatastoreAdminClient.ImportEntitiesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ImportEntitiesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DatastoreAdminClient.ImportEntities</c> and
        /// <c>DatastoreAdminClient.ImportEntitiesAsync</c>.
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
        public lro::OperationsSettings ImportEntitiesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatastoreAdminClient.CreateIndex</c> and <c>DatastoreAdminClient.CreateIndexAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateIndexSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DatastoreAdminClient.CreateIndex</c> and
        /// <c>DatastoreAdminClient.CreateIndexAsync</c>.
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
        public lro::OperationsSettings CreateIndexOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatastoreAdminClient.DeleteIndex</c> and <c>DatastoreAdminClient.DeleteIndexAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteIndexSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DatastoreAdminClient.DeleteIndex</c> and
        /// <c>DatastoreAdminClient.DeleteIndexAsync</c>.
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
        public lro::OperationsSettings DeleteIndexOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatastoreAdminClient.GetIndex</c> and <c>DatastoreAdminClient.GetIndexAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIndexSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatastoreAdminClient.ListIndexes</c> and <c>DatastoreAdminClient.ListIndexesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListIndexesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DatastoreAdminSettings"/> object.</returns>
        public DatastoreAdminSettings Clone() => new DatastoreAdminSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DatastoreAdminClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class DatastoreAdminClientBuilder : gaxgrpc::ClientBuilderBase<DatastoreAdminClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DatastoreAdminSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DatastoreAdminClientBuilder() : base(DatastoreAdminClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DatastoreAdminClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DatastoreAdminClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DatastoreAdminClient Build()
        {
            DatastoreAdminClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DatastoreAdminClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DatastoreAdminClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DatastoreAdminClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DatastoreAdminClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DatastoreAdminClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DatastoreAdminClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DatastoreAdminClient.ChannelPool;
    }

    /// <summary>DatastoreAdmin client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Google Cloud Datastore Admin API
    /// 
    /// The Datastore Admin API provides several admin services for Cloud Datastore.
    /// 
    /// Concepts: Project, namespace, kind, and entity as defined in the Google Cloud
    /// Datastore API.
    /// 
    /// Operation: An Operation represents work being performed in the background.
    /// 
    /// EntityFilter: Allows specifying a subset of entities in a project. This is
    /// specified as a combination of kinds and namespaces (either or both of which
    /// may be all).
    /// 
    /// Export/Import Service:
    /// 
    /// - The Export/Import service provides the ability to copy all or a subset of
    /// entities to/from Google Cloud Storage.
    /// - Exported data may be imported into Cloud Datastore for any Google Cloud
    /// Platform project. It is not restricted to the export source project. It is
    /// possible to export from one project and then import into another.
    /// - Exported data can also be loaded into Google BigQuery for analysis.
    /// - Exports and imports are performed asynchronously. An Operation resource is
    /// created for each export/import. The state (including any errors encountered)
    /// of the export/import may be queried via the Operation resource.
    /// 
    /// Index Service:
    /// 
    /// - The index service manages Cloud Datastore composite indexes.
    /// - Index creation and deletion are performed asynchronously.
    /// An Operation resource is created for each such asynchronous operation.
    /// The state of the operation (including any errors encountered)
    /// may be queried via the Operation resource.
    /// 
    /// Operation Service:
    /// 
    /// - The Operations collection provides a record of actions performed for the
    /// specified project (including any operations in progress). Operations are not
    /// created directly but through calls on other collections or resources.
    /// - An operation that is not yet done may be cancelled. The request to cancel
    /// is asynchronous and the operation may continue to run for some time after the
    /// request to cancel is made.
    /// - An operation that is done may be deleted so that it is no longer listed as
    /// part of the Operation collection.
    /// - ListOperations returns all pending operations, but not completed
    /// operations.
    /// - Operations are created by service DatastoreAdmin, but are accessed via
    /// service google.longrunning.Operations.
    /// </remarks>
    public abstract partial class DatastoreAdminClient
    {
        /// <summary>
        /// The default endpoint for the DatastoreAdmin service, which is a host of "datastore.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "datastore.googleapis.com:443";

        /// <summary>The default DatastoreAdmin scopes.</summary>
        /// <remarks>
        /// The default DatastoreAdmin scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/datastore</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/datastore",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DatastoreAdmin.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DatastoreAdminClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DatastoreAdminClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DatastoreAdminClient"/>.</returns>
        public static stt::Task<DatastoreAdminClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DatastoreAdminClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DatastoreAdminClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DatastoreAdminClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DatastoreAdminClient"/>.</returns>
        public static DatastoreAdminClient Create() => new DatastoreAdminClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DatastoreAdminClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DatastoreAdminSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DatastoreAdminClient"/>.</returns>
        internal static DatastoreAdminClient Create(grpccore::CallInvoker callInvoker, DatastoreAdminSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DatastoreAdmin.DatastoreAdminClient grpcClient = new DatastoreAdmin.DatastoreAdminClient(callInvoker);
            return new DatastoreAdminClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DatastoreAdmin client</summary>
        public virtual DatastoreAdmin.DatastoreAdminClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Exports a copy of all or a subset of entities from Google Cloud Datastore
        /// to another storage system, such as Google Cloud Storage. Recent updates to
        /// entities may not be reflected in the export. The export occurs in the
        /// background and its progress can be monitored and managed via the
        /// Operation resource that is created. The output of an export may only be
        /// used once the associated operation is done. If an export operation is
        /// cancelled before completion it may leave partial data behind in Google
        /// Cloud Storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportEntitiesResponse, ExportEntitiesMetadata> ExportEntities(ExportEntitiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports a copy of all or a subset of entities from Google Cloud Datastore
        /// to another storage system, such as Google Cloud Storage. Recent updates to
        /// entities may not be reflected in the export. The export occurs in the
        /// background and its progress can be monitored and managed via the
        /// Operation resource that is created. The output of an export may only be
        /// used once the associated operation is done. If an export operation is
        /// cancelled before completion it may leave partial data behind in Google
        /// Cloud Storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportEntitiesResponse, ExportEntitiesMetadata>> ExportEntitiesAsync(ExportEntitiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports a copy of all or a subset of entities from Google Cloud Datastore
        /// to another storage system, such as Google Cloud Storage. Recent updates to
        /// entities may not be reflected in the export. The export occurs in the
        /// background and its progress can be monitored and managed via the
        /// Operation resource that is created. The output of an export may only be
        /// used once the associated operation is done. If an export operation is
        /// cancelled before completion it may leave partial data behind in Google
        /// Cloud Storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportEntitiesResponse, ExportEntitiesMetadata>> ExportEntitiesAsync(ExportEntitiesRequest request, st::CancellationToken cancellationToken) =>
            ExportEntitiesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ExportEntities</c>.</summary>
        public virtual lro::OperationsClient ExportEntitiesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ExportEntities</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ExportEntitiesResponse, ExportEntitiesMetadata> PollOnceExportEntities(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportEntitiesResponse, ExportEntitiesMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportEntitiesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportEntities</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ExportEntitiesResponse, ExportEntitiesMetadata>> PollOnceExportEntitiesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportEntitiesResponse, ExportEntitiesMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportEntitiesOperationsClient, callSettings);

        /// <summary>
        /// Exports a copy of all or a subset of entities from Google Cloud Datastore
        /// to another storage system, such as Google Cloud Storage. Recent updates to
        /// entities may not be reflected in the export. The export occurs in the
        /// background and its progress can be monitored and managed via the
        /// Operation resource that is created. The output of an export may only be
        /// used once the associated operation is done. If an export operation is
        /// cancelled before completion it may leave partial data behind in Google
        /// Cloud Storage.
        /// </summary>
        /// <param name="projectId">
        /// Required. Project ID against which to make the request.
        /// </param>
        /// <param name="labels">
        /// Client-assigned labels.
        /// </param>
        /// <param name="entityFilter">
        /// Description of what data from the project is included in the export.
        /// </param>
        /// <param name="outputUrlPrefix">
        /// Required. Location for the export metadata and data files.
        /// 
        /// The full resource URL of the external storage location. Currently, only
        /// Google Cloud Storage is supported. So output_url_prefix should be of the
        /// form: `gs://BUCKET_NAME[/NAMESPACE_PATH]`, where `BUCKET_NAME` is the
        /// name of the Cloud Storage bucket and `NAMESPACE_PATH` is an optional Cloud
        /// Storage namespace path (this is not a Cloud Datastore namespace). For more
        /// information about Cloud Storage namespace paths, see
        /// [Object name
        /// considerations](https://cloud.google.com/storage/docs/naming#object-considerations).
        /// 
        /// The resulting files will be nested deeper than the specified URL prefix.
        /// The final output URL will be provided in the
        /// [google.datastore.admin.v1.ExportEntitiesResponse.output_url][google.datastore.admin.v1.ExportEntitiesResponse.output_url]
        /// field. That value should be used for subsequent ImportEntities operations.
        /// 
        /// By nesting the data files deeper, the same Cloud Storage bucket can be used
        /// in multiple ExportEntities operations without conflict.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportEntitiesResponse, ExportEntitiesMetadata> ExportEntities(string projectId, scg::IDictionary<string, string> labels, EntityFilter entityFilter, string outputUrlPrefix, gaxgrpc::CallSettings callSettings = null) =>
            ExportEntities(new ExportEntitiesRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Labels =
                {
                    labels ?? new scg::Dictionary<string, string>(),
                },
                EntityFilter = entityFilter,
                OutputUrlPrefix = gax::GaxPreconditions.CheckNotNullOrEmpty(outputUrlPrefix, nameof(outputUrlPrefix)),
            }, callSettings);

        /// <summary>
        /// Exports a copy of all or a subset of entities from Google Cloud Datastore
        /// to another storage system, such as Google Cloud Storage. Recent updates to
        /// entities may not be reflected in the export. The export occurs in the
        /// background and its progress can be monitored and managed via the
        /// Operation resource that is created. The output of an export may only be
        /// used once the associated operation is done. If an export operation is
        /// cancelled before completion it may leave partial data behind in Google
        /// Cloud Storage.
        /// </summary>
        /// <param name="projectId">
        /// Required. Project ID against which to make the request.
        /// </param>
        /// <param name="labels">
        /// Client-assigned labels.
        /// </param>
        /// <param name="entityFilter">
        /// Description of what data from the project is included in the export.
        /// </param>
        /// <param name="outputUrlPrefix">
        /// Required. Location for the export metadata and data files.
        /// 
        /// The full resource URL of the external storage location. Currently, only
        /// Google Cloud Storage is supported. So output_url_prefix should be of the
        /// form: `gs://BUCKET_NAME[/NAMESPACE_PATH]`, where `BUCKET_NAME` is the
        /// name of the Cloud Storage bucket and `NAMESPACE_PATH` is an optional Cloud
        /// Storage namespace path (this is not a Cloud Datastore namespace). For more
        /// information about Cloud Storage namespace paths, see
        /// [Object name
        /// considerations](https://cloud.google.com/storage/docs/naming#object-considerations).
        /// 
        /// The resulting files will be nested deeper than the specified URL prefix.
        /// The final output URL will be provided in the
        /// [google.datastore.admin.v1.ExportEntitiesResponse.output_url][google.datastore.admin.v1.ExportEntitiesResponse.output_url]
        /// field. That value should be used for subsequent ImportEntities operations.
        /// 
        /// By nesting the data files deeper, the same Cloud Storage bucket can be used
        /// in multiple ExportEntities operations without conflict.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportEntitiesResponse, ExportEntitiesMetadata>> ExportEntitiesAsync(string projectId, scg::IDictionary<string, string> labels, EntityFilter entityFilter, string outputUrlPrefix, gaxgrpc::CallSettings callSettings = null) =>
            ExportEntitiesAsync(new ExportEntitiesRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Labels =
                {
                    labels ?? new scg::Dictionary<string, string>(),
                },
                EntityFilter = entityFilter,
                OutputUrlPrefix = gax::GaxPreconditions.CheckNotNullOrEmpty(outputUrlPrefix, nameof(outputUrlPrefix)),
            }, callSettings);

        /// <summary>
        /// Exports a copy of all or a subset of entities from Google Cloud Datastore
        /// to another storage system, such as Google Cloud Storage. Recent updates to
        /// entities may not be reflected in the export. The export occurs in the
        /// background and its progress can be monitored and managed via the
        /// Operation resource that is created. The output of an export may only be
        /// used once the associated operation is done. If an export operation is
        /// cancelled before completion it may leave partial data behind in Google
        /// Cloud Storage.
        /// </summary>
        /// <param name="projectId">
        /// Required. Project ID against which to make the request.
        /// </param>
        /// <param name="labels">
        /// Client-assigned labels.
        /// </param>
        /// <param name="entityFilter">
        /// Description of what data from the project is included in the export.
        /// </param>
        /// <param name="outputUrlPrefix">
        /// Required. Location for the export metadata and data files.
        /// 
        /// The full resource URL of the external storage location. Currently, only
        /// Google Cloud Storage is supported. So output_url_prefix should be of the
        /// form: `gs://BUCKET_NAME[/NAMESPACE_PATH]`, where `BUCKET_NAME` is the
        /// name of the Cloud Storage bucket and `NAMESPACE_PATH` is an optional Cloud
        /// Storage namespace path (this is not a Cloud Datastore namespace). For more
        /// information about Cloud Storage namespace paths, see
        /// [Object name
        /// considerations](https://cloud.google.com/storage/docs/naming#object-considerations).
        /// 
        /// The resulting files will be nested deeper than the specified URL prefix.
        /// The final output URL will be provided in the
        /// [google.datastore.admin.v1.ExportEntitiesResponse.output_url][google.datastore.admin.v1.ExportEntitiesResponse.output_url]
        /// field. That value should be used for subsequent ImportEntities operations.
        /// 
        /// By nesting the data files deeper, the same Cloud Storage bucket can be used
        /// in multiple ExportEntities operations without conflict.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportEntitiesResponse, ExportEntitiesMetadata>> ExportEntitiesAsync(string projectId, scg::IDictionary<string, string> labels, EntityFilter entityFilter, string outputUrlPrefix, st::CancellationToken cancellationToken) =>
            ExportEntitiesAsync(projectId, labels, entityFilter, outputUrlPrefix, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports entities into Google Cloud Datastore. Existing entities with the
        /// same key are overwritten. The import occurs in the background and its
        /// progress can be monitored and managed via the Operation resource that is
        /// created. If an ImportEntities operation is cancelled, it is possible
        /// that a subset of the data has already been imported to Cloud Datastore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, ImportEntitiesMetadata> ImportEntities(ImportEntitiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports entities into Google Cloud Datastore. Existing entities with the
        /// same key are overwritten. The import occurs in the background and its
        /// progress can be monitored and managed via the Operation resource that is
        /// created. If an ImportEntities operation is cancelled, it is possible
        /// that a subset of the data has already been imported to Cloud Datastore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, ImportEntitiesMetadata>> ImportEntitiesAsync(ImportEntitiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports entities into Google Cloud Datastore. Existing entities with the
        /// same key are overwritten. The import occurs in the background and its
        /// progress can be monitored and managed via the Operation resource that is
        /// created. If an ImportEntities operation is cancelled, it is possible
        /// that a subset of the data has already been imported to Cloud Datastore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, ImportEntitiesMetadata>> ImportEntitiesAsync(ImportEntitiesRequest request, st::CancellationToken cancellationToken) =>
            ImportEntitiesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ImportEntities</c>.</summary>
        public virtual lro::OperationsClient ImportEntitiesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ImportEntities</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, ImportEntitiesMetadata> PollOnceImportEntities(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, ImportEntitiesMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportEntitiesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ImportEntities</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, ImportEntitiesMetadata>> PollOnceImportEntitiesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, ImportEntitiesMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportEntitiesOperationsClient, callSettings);

        /// <summary>
        /// Imports entities into Google Cloud Datastore. Existing entities with the
        /// same key are overwritten. The import occurs in the background and its
        /// progress can be monitored and managed via the Operation resource that is
        /// created. If an ImportEntities operation is cancelled, it is possible
        /// that a subset of the data has already been imported to Cloud Datastore.
        /// </summary>
        /// <param name="projectId">
        /// Required. Project ID against which to make the request.
        /// </param>
        /// <param name="labels">
        /// Client-assigned labels.
        /// </param>
        /// <param name="inputUrl">
        /// Required. The full resource URL of the external storage location.
        /// Currently, only Google Cloud Storage is supported. So input_url should be
        /// of the form:
        /// `gs://BUCKET_NAME[/NAMESPACE_PATH]/OVERALL_EXPORT_METADATA_FILE`, where
        /// `BUCKET_NAME` is the name of the Cloud Storage bucket, `NAMESPACE_PATH` is
        /// an optional Cloud Storage namespace path (this is not a Cloud Datastore
        /// namespace), and `OVERALL_EXPORT_METADATA_FILE` is the metadata file written
        /// by the ExportEntities operation. For more information about Cloud Storage
        /// namespace paths, see
        /// [Object name
        /// considerations](https://cloud.google.com/storage/docs/naming#object-considerations).
        /// 
        /// For more information, see
        /// [google.datastore.admin.v1.ExportEntitiesResponse.output_url][google.datastore.admin.v1.ExportEntitiesResponse.output_url].
        /// </param>
        /// <param name="entityFilter">
        /// Optionally specify which kinds/namespaces are to be imported. If provided,
        /// the list must be a subset of the EntityFilter used in creating the export,
        /// otherwise a FAILED_PRECONDITION error will be returned. If no filter is
        /// specified then all entities from the export are imported.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, ImportEntitiesMetadata> ImportEntities(string projectId, scg::IDictionary<string, string> labels, string inputUrl, EntityFilter entityFilter, gaxgrpc::CallSettings callSettings = null) =>
            ImportEntities(new ImportEntitiesRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Labels =
                {
                    labels ?? new scg::Dictionary<string, string>(),
                },
                InputUrl = gax::GaxPreconditions.CheckNotNullOrEmpty(inputUrl, nameof(inputUrl)),
                EntityFilter = entityFilter,
            }, callSettings);

        /// <summary>
        /// Imports entities into Google Cloud Datastore. Existing entities with the
        /// same key are overwritten. The import occurs in the background and its
        /// progress can be monitored and managed via the Operation resource that is
        /// created. If an ImportEntities operation is cancelled, it is possible
        /// that a subset of the data has already been imported to Cloud Datastore.
        /// </summary>
        /// <param name="projectId">
        /// Required. Project ID against which to make the request.
        /// </param>
        /// <param name="labels">
        /// Client-assigned labels.
        /// </param>
        /// <param name="inputUrl">
        /// Required. The full resource URL of the external storage location.
        /// Currently, only Google Cloud Storage is supported. So input_url should be
        /// of the form:
        /// `gs://BUCKET_NAME[/NAMESPACE_PATH]/OVERALL_EXPORT_METADATA_FILE`, where
        /// `BUCKET_NAME` is the name of the Cloud Storage bucket, `NAMESPACE_PATH` is
        /// an optional Cloud Storage namespace path (this is not a Cloud Datastore
        /// namespace), and `OVERALL_EXPORT_METADATA_FILE` is the metadata file written
        /// by the ExportEntities operation. For more information about Cloud Storage
        /// namespace paths, see
        /// [Object name
        /// considerations](https://cloud.google.com/storage/docs/naming#object-considerations).
        /// 
        /// For more information, see
        /// [google.datastore.admin.v1.ExportEntitiesResponse.output_url][google.datastore.admin.v1.ExportEntitiesResponse.output_url].
        /// </param>
        /// <param name="entityFilter">
        /// Optionally specify which kinds/namespaces are to be imported. If provided,
        /// the list must be a subset of the EntityFilter used in creating the export,
        /// otherwise a FAILED_PRECONDITION error will be returned. If no filter is
        /// specified then all entities from the export are imported.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, ImportEntitiesMetadata>> ImportEntitiesAsync(string projectId, scg::IDictionary<string, string> labels, string inputUrl, EntityFilter entityFilter, gaxgrpc::CallSettings callSettings = null) =>
            ImportEntitiesAsync(new ImportEntitiesRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Labels =
                {
                    labels ?? new scg::Dictionary<string, string>(),
                },
                InputUrl = gax::GaxPreconditions.CheckNotNullOrEmpty(inputUrl, nameof(inputUrl)),
                EntityFilter = entityFilter,
            }, callSettings);

        /// <summary>
        /// Imports entities into Google Cloud Datastore. Existing entities with the
        /// same key are overwritten. The import occurs in the background and its
        /// progress can be monitored and managed via the Operation resource that is
        /// created. If an ImportEntities operation is cancelled, it is possible
        /// that a subset of the data has already been imported to Cloud Datastore.
        /// </summary>
        /// <param name="projectId">
        /// Required. Project ID against which to make the request.
        /// </param>
        /// <param name="labels">
        /// Client-assigned labels.
        /// </param>
        /// <param name="inputUrl">
        /// Required. The full resource URL of the external storage location.
        /// Currently, only Google Cloud Storage is supported. So input_url should be
        /// of the form:
        /// `gs://BUCKET_NAME[/NAMESPACE_PATH]/OVERALL_EXPORT_METADATA_FILE`, where
        /// `BUCKET_NAME` is the name of the Cloud Storage bucket, `NAMESPACE_PATH` is
        /// an optional Cloud Storage namespace path (this is not a Cloud Datastore
        /// namespace), and `OVERALL_EXPORT_METADATA_FILE` is the metadata file written
        /// by the ExportEntities operation. For more information about Cloud Storage
        /// namespace paths, see
        /// [Object name
        /// considerations](https://cloud.google.com/storage/docs/naming#object-considerations).
        /// 
        /// For more information, see
        /// [google.datastore.admin.v1.ExportEntitiesResponse.output_url][google.datastore.admin.v1.ExportEntitiesResponse.output_url].
        /// </param>
        /// <param name="entityFilter">
        /// Optionally specify which kinds/namespaces are to be imported. If provided,
        /// the list must be a subset of the EntityFilter used in creating the export,
        /// otherwise a FAILED_PRECONDITION error will be returned. If no filter is
        /// specified then all entities from the export are imported.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, ImportEntitiesMetadata>> ImportEntitiesAsync(string projectId, scg::IDictionary<string, string> labels, string inputUrl, EntityFilter entityFilter, st::CancellationToken cancellationToken) =>
            ImportEntitiesAsync(projectId, labels, inputUrl, entityFilter, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates the specified index.
        /// A newly created index's initial state is `CREATING`. On completion of the
        /// returned [google.longrunning.Operation][google.longrunning.Operation], the
        /// state will be `READY`. If the index already exists, the call will return an
        /// `ALREADY_EXISTS` status.
        /// 
        /// During index creation, the process could result in an error, in which
        /// case the index will move to the `ERROR` state. The process can be recovered
        /// by fixing the data that caused the error, removing the index with
        /// [delete][google.datastore.admin.v1.DatastoreAdmin.DeleteIndex], then
        /// re-creating the index with [create]
        /// [google.datastore.admin.v1.DatastoreAdmin.CreateIndex].
        /// 
        /// Indexes with a single property cannot be created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Index, IndexOperationMetadata> CreateIndex(CreateIndexRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates the specified index.
        /// A newly created index's initial state is `CREATING`. On completion of the
        /// returned [google.longrunning.Operation][google.longrunning.Operation], the
        /// state will be `READY`. If the index already exists, the call will return an
        /// `ALREADY_EXISTS` status.
        /// 
        /// During index creation, the process could result in an error, in which
        /// case the index will move to the `ERROR` state. The process can be recovered
        /// by fixing the data that caused the error, removing the index with
        /// [delete][google.datastore.admin.v1.DatastoreAdmin.DeleteIndex], then
        /// re-creating the index with [create]
        /// [google.datastore.admin.v1.DatastoreAdmin.CreateIndex].
        /// 
        /// Indexes with a single property cannot be created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Index, IndexOperationMetadata>> CreateIndexAsync(CreateIndexRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates the specified index.
        /// A newly created index's initial state is `CREATING`. On completion of the
        /// returned [google.longrunning.Operation][google.longrunning.Operation], the
        /// state will be `READY`. If the index already exists, the call will return an
        /// `ALREADY_EXISTS` status.
        /// 
        /// During index creation, the process could result in an error, in which
        /// case the index will move to the `ERROR` state. The process can be recovered
        /// by fixing the data that caused the error, removing the index with
        /// [delete][google.datastore.admin.v1.DatastoreAdmin.DeleteIndex], then
        /// re-creating the index with [create]
        /// [google.datastore.admin.v1.DatastoreAdmin.CreateIndex].
        /// 
        /// Indexes with a single property cannot be created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Index, IndexOperationMetadata>> CreateIndexAsync(CreateIndexRequest request, st::CancellationToken cancellationToken) =>
            CreateIndexAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateIndex</c>.</summary>
        public virtual lro::OperationsClient CreateIndexOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateIndex</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Index, IndexOperationMetadata> PollOnceCreateIndex(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Index, IndexOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateIndexOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateIndex</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Index, IndexOperationMetadata>> PollOnceCreateIndexAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Index, IndexOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateIndexOperationsClient, callSettings);

        /// <summary>
        /// Deletes an existing index.
        /// An index can only be deleted if it is in a `READY` or `ERROR` state. On
        /// successful execution of the request, the index will be in a `DELETING`
        /// [state][google.datastore.admin.v1.Index.State]. And on completion of the
        /// returned [google.longrunning.Operation][google.longrunning.Operation], the
        /// index will be removed.
        /// 
        /// During index deletion, the process could result in an error, in which
        /// case the index will move to the `ERROR` state. The process can be recovered
        /// by fixing the data that caused the error, followed by calling
        /// [delete][google.datastore.admin.v1.DatastoreAdmin.DeleteIndex] again.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Index, IndexOperationMetadata> DeleteIndex(DeleteIndexRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an existing index.
        /// An index can only be deleted if it is in a `READY` or `ERROR` state. On
        /// successful execution of the request, the index will be in a `DELETING`
        /// [state][google.datastore.admin.v1.Index.State]. And on completion of the
        /// returned [google.longrunning.Operation][google.longrunning.Operation], the
        /// index will be removed.
        /// 
        /// During index deletion, the process could result in an error, in which
        /// case the index will move to the `ERROR` state. The process can be recovered
        /// by fixing the data that caused the error, followed by calling
        /// [delete][google.datastore.admin.v1.DatastoreAdmin.DeleteIndex] again.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Index, IndexOperationMetadata>> DeleteIndexAsync(DeleteIndexRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an existing index.
        /// An index can only be deleted if it is in a `READY` or `ERROR` state. On
        /// successful execution of the request, the index will be in a `DELETING`
        /// [state][google.datastore.admin.v1.Index.State]. And on completion of the
        /// returned [google.longrunning.Operation][google.longrunning.Operation], the
        /// index will be removed.
        /// 
        /// During index deletion, the process could result in an error, in which
        /// case the index will move to the `ERROR` state. The process can be recovered
        /// by fixing the data that caused the error, followed by calling
        /// [delete][google.datastore.admin.v1.DatastoreAdmin.DeleteIndex] again.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Index, IndexOperationMetadata>> DeleteIndexAsync(DeleteIndexRequest request, st::CancellationToken cancellationToken) =>
            DeleteIndexAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteIndex</c>.</summary>
        public virtual lro::OperationsClient DeleteIndexOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteIndex</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Index, IndexOperationMetadata> PollOnceDeleteIndex(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Index, IndexOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteIndexOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteIndex</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Index, IndexOperationMetadata>> PollOnceDeleteIndexAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Index, IndexOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteIndexOperationsClient, callSettings);

        /// <summary>
        /// Gets an index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Index GetIndex(GetIndexRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Index> GetIndexAsync(GetIndexRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Index> GetIndexAsync(GetIndexRequest request, st::CancellationToken cancellationToken) =>
            GetIndexAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the indexes that match the specified filters.  Datastore uses an
        /// eventually consistent query to fetch the list of indexes and may
        /// occasionally return stale results.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Index"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListIndexesResponse, Index> ListIndexes(ListIndexesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the indexes that match the specified filters.  Datastore uses an
        /// eventually consistent query to fetch the list of indexes and may
        /// occasionally return stale results.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Index"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListIndexesResponse, Index> ListIndexesAsync(ListIndexesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();
    }

    /// <summary>DatastoreAdmin client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Google Cloud Datastore Admin API
    /// 
    /// The Datastore Admin API provides several admin services for Cloud Datastore.
    /// 
    /// Concepts: Project, namespace, kind, and entity as defined in the Google Cloud
    /// Datastore API.
    /// 
    /// Operation: An Operation represents work being performed in the background.
    /// 
    /// EntityFilter: Allows specifying a subset of entities in a project. This is
    /// specified as a combination of kinds and namespaces (either or both of which
    /// may be all).
    /// 
    /// Export/Import Service:
    /// 
    /// - The Export/Import service provides the ability to copy all or a subset of
    /// entities to/from Google Cloud Storage.
    /// - Exported data may be imported into Cloud Datastore for any Google Cloud
    /// Platform project. It is not restricted to the export source project. It is
    /// possible to export from one project and then import into another.
    /// - Exported data can also be loaded into Google BigQuery for analysis.
    /// - Exports and imports are performed asynchronously. An Operation resource is
    /// created for each export/import. The state (including any errors encountered)
    /// of the export/import may be queried via the Operation resource.
    /// 
    /// Index Service:
    /// 
    /// - The index service manages Cloud Datastore composite indexes.
    /// - Index creation and deletion are performed asynchronously.
    /// An Operation resource is created for each such asynchronous operation.
    /// The state of the operation (including any errors encountered)
    /// may be queried via the Operation resource.
    /// 
    /// Operation Service:
    /// 
    /// - The Operations collection provides a record of actions performed for the
    /// specified project (including any operations in progress). Operations are not
    /// created directly but through calls on other collections or resources.
    /// - An operation that is not yet done may be cancelled. The request to cancel
    /// is asynchronous and the operation may continue to run for some time after the
    /// request to cancel is made.
    /// - An operation that is done may be deleted so that it is no longer listed as
    /// part of the Operation collection.
    /// - ListOperations returns all pending operations, but not completed
    /// operations.
    /// - Operations are created by service DatastoreAdmin, but are accessed via
    /// service google.longrunning.Operations.
    /// </remarks>
    public sealed partial class DatastoreAdminClientImpl : DatastoreAdminClient
    {
        private readonly gaxgrpc::ApiCall<ExportEntitiesRequest, lro::Operation> _callExportEntities;

        private readonly gaxgrpc::ApiCall<ImportEntitiesRequest, lro::Operation> _callImportEntities;

        private readonly gaxgrpc::ApiCall<CreateIndexRequest, lro::Operation> _callCreateIndex;

        private readonly gaxgrpc::ApiCall<DeleteIndexRequest, lro::Operation> _callDeleteIndex;

        private readonly gaxgrpc::ApiCall<GetIndexRequest, Index> _callGetIndex;

        private readonly gaxgrpc::ApiCall<ListIndexesRequest, ListIndexesResponse> _callListIndexes;

        /// <summary>
        /// Constructs a client wrapper for the DatastoreAdmin service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DatastoreAdminSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DatastoreAdminClientImpl(DatastoreAdmin.DatastoreAdminClient grpcClient, DatastoreAdminSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DatastoreAdminSettings effectiveSettings = settings ?? DatastoreAdminSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            ExportEntitiesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ExportEntitiesOperationsSettings, logger);
            ImportEntitiesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ImportEntitiesOperationsSettings, logger);
            CreateIndexOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateIndexOperationsSettings, logger);
            DeleteIndexOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteIndexOperationsSettings, logger);
            _callExportEntities = clientHelper.BuildApiCall<ExportEntitiesRequest, lro::Operation>("ExportEntities", grpcClient.ExportEntitiesAsync, grpcClient.ExportEntities, effectiveSettings.ExportEntitiesSettings).WithGoogleRequestParam("project_id", request => request.ProjectId);
            Modify_ApiCall(ref _callExportEntities);
            Modify_ExportEntitiesApiCall(ref _callExportEntities);
            _callImportEntities = clientHelper.BuildApiCall<ImportEntitiesRequest, lro::Operation>("ImportEntities", grpcClient.ImportEntitiesAsync, grpcClient.ImportEntities, effectiveSettings.ImportEntitiesSettings).WithGoogleRequestParam("project_id", request => request.ProjectId);
            Modify_ApiCall(ref _callImportEntities);
            Modify_ImportEntitiesApiCall(ref _callImportEntities);
            _callCreateIndex = clientHelper.BuildApiCall<CreateIndexRequest, lro::Operation>("CreateIndex", grpcClient.CreateIndexAsync, grpcClient.CreateIndex, effectiveSettings.CreateIndexSettings).WithGoogleRequestParam("project_id", request => request.ProjectId);
            Modify_ApiCall(ref _callCreateIndex);
            Modify_CreateIndexApiCall(ref _callCreateIndex);
            _callDeleteIndex = clientHelper.BuildApiCall<DeleteIndexRequest, lro::Operation>("DeleteIndex", grpcClient.DeleteIndexAsync, grpcClient.DeleteIndex, effectiveSettings.DeleteIndexSettings).WithGoogleRequestParam("project_id", request => request.ProjectId).WithGoogleRequestParam("index_id", request => request.IndexId);
            Modify_ApiCall(ref _callDeleteIndex);
            Modify_DeleteIndexApiCall(ref _callDeleteIndex);
            _callGetIndex = clientHelper.BuildApiCall<GetIndexRequest, Index>("GetIndex", grpcClient.GetIndexAsync, grpcClient.GetIndex, effectiveSettings.GetIndexSettings).WithGoogleRequestParam("project_id", request => request.ProjectId).WithGoogleRequestParam("index_id", request => request.IndexId);
            Modify_ApiCall(ref _callGetIndex);
            Modify_GetIndexApiCall(ref _callGetIndex);
            _callListIndexes = clientHelper.BuildApiCall<ListIndexesRequest, ListIndexesResponse>("ListIndexes", grpcClient.ListIndexesAsync, grpcClient.ListIndexes, effectiveSettings.ListIndexesSettings).WithGoogleRequestParam("project_id", request => request.ProjectId);
            Modify_ApiCall(ref _callListIndexes);
            Modify_ListIndexesApiCall(ref _callListIndexes);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ExportEntitiesApiCall(ref gaxgrpc::ApiCall<ExportEntitiesRequest, lro::Operation> call);

        partial void Modify_ImportEntitiesApiCall(ref gaxgrpc::ApiCall<ImportEntitiesRequest, lro::Operation> call);

        partial void Modify_CreateIndexApiCall(ref gaxgrpc::ApiCall<CreateIndexRequest, lro::Operation> call);

        partial void Modify_DeleteIndexApiCall(ref gaxgrpc::ApiCall<DeleteIndexRequest, lro::Operation> call);

        partial void Modify_GetIndexApiCall(ref gaxgrpc::ApiCall<GetIndexRequest, Index> call);

        partial void Modify_ListIndexesApiCall(ref gaxgrpc::ApiCall<ListIndexesRequest, ListIndexesResponse> call);

        partial void OnConstruction(DatastoreAdmin.DatastoreAdminClient grpcClient, DatastoreAdminSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DatastoreAdmin client</summary>
        public override DatastoreAdmin.DatastoreAdminClient GrpcClient { get; }

        partial void Modify_ExportEntitiesRequest(ref ExportEntitiesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportEntitiesRequest(ref ImportEntitiesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateIndexRequest(ref CreateIndexRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteIndexRequest(ref DeleteIndexRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIndexRequest(ref GetIndexRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListIndexesRequest(ref ListIndexesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>ExportEntities</c>.</summary>
        public override lro::OperationsClient ExportEntitiesOperationsClient { get; }

        /// <summary>
        /// Exports a copy of all or a subset of entities from Google Cloud Datastore
        /// to another storage system, such as Google Cloud Storage. Recent updates to
        /// entities may not be reflected in the export. The export occurs in the
        /// background and its progress can be monitored and managed via the
        /// Operation resource that is created. The output of an export may only be
        /// used once the associated operation is done. If an export operation is
        /// cancelled before completion it may leave partial data behind in Google
        /// Cloud Storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ExportEntitiesResponse, ExportEntitiesMetadata> ExportEntities(ExportEntitiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportEntitiesRequest(ref request, ref callSettings);
            return new lro::Operation<ExportEntitiesResponse, ExportEntitiesMetadata>(_callExportEntities.Sync(request, callSettings), ExportEntitiesOperationsClient);
        }

        /// <summary>
        /// Exports a copy of all or a subset of entities from Google Cloud Datastore
        /// to another storage system, such as Google Cloud Storage. Recent updates to
        /// entities may not be reflected in the export. The export occurs in the
        /// background and its progress can be monitored and managed via the
        /// Operation resource that is created. The output of an export may only be
        /// used once the associated operation is done. If an export operation is
        /// cancelled before completion it may leave partial data behind in Google
        /// Cloud Storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ExportEntitiesResponse, ExportEntitiesMetadata>> ExportEntitiesAsync(ExportEntitiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportEntitiesRequest(ref request, ref callSettings);
            return new lro::Operation<ExportEntitiesResponse, ExportEntitiesMetadata>(await _callExportEntities.Async(request, callSettings).ConfigureAwait(false), ExportEntitiesOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ImportEntities</c>.</summary>
        public override lro::OperationsClient ImportEntitiesOperationsClient { get; }

        /// <summary>
        /// Imports entities into Google Cloud Datastore. Existing entities with the
        /// same key are overwritten. The import occurs in the background and its
        /// progress can be monitored and managed via the Operation resource that is
        /// created. If an ImportEntities operation is cancelled, it is possible
        /// that a subset of the data has already been imported to Cloud Datastore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, ImportEntitiesMetadata> ImportEntities(ImportEntitiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportEntitiesRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, ImportEntitiesMetadata>(_callImportEntities.Sync(request, callSettings), ImportEntitiesOperationsClient);
        }

        /// <summary>
        /// Imports entities into Google Cloud Datastore. Existing entities with the
        /// same key are overwritten. The import occurs in the background and its
        /// progress can be monitored and managed via the Operation resource that is
        /// created. If an ImportEntities operation is cancelled, it is possible
        /// that a subset of the data has already been imported to Cloud Datastore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, ImportEntitiesMetadata>> ImportEntitiesAsync(ImportEntitiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportEntitiesRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, ImportEntitiesMetadata>(await _callImportEntities.Async(request, callSettings).ConfigureAwait(false), ImportEntitiesOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateIndex</c>.</summary>
        public override lro::OperationsClient CreateIndexOperationsClient { get; }

        /// <summary>
        /// Creates the specified index.
        /// A newly created index's initial state is `CREATING`. On completion of the
        /// returned [google.longrunning.Operation][google.longrunning.Operation], the
        /// state will be `READY`. If the index already exists, the call will return an
        /// `ALREADY_EXISTS` status.
        /// 
        /// During index creation, the process could result in an error, in which
        /// case the index will move to the `ERROR` state. The process can be recovered
        /// by fixing the data that caused the error, removing the index with
        /// [delete][google.datastore.admin.v1.DatastoreAdmin.DeleteIndex], then
        /// re-creating the index with [create]
        /// [google.datastore.admin.v1.DatastoreAdmin.CreateIndex].
        /// 
        /// Indexes with a single property cannot be created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Index, IndexOperationMetadata> CreateIndex(CreateIndexRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateIndexRequest(ref request, ref callSettings);
            return new lro::Operation<Index, IndexOperationMetadata>(_callCreateIndex.Sync(request, callSettings), CreateIndexOperationsClient);
        }

        /// <summary>
        /// Creates the specified index.
        /// A newly created index's initial state is `CREATING`. On completion of the
        /// returned [google.longrunning.Operation][google.longrunning.Operation], the
        /// state will be `READY`. If the index already exists, the call will return an
        /// `ALREADY_EXISTS` status.
        /// 
        /// During index creation, the process could result in an error, in which
        /// case the index will move to the `ERROR` state. The process can be recovered
        /// by fixing the data that caused the error, removing the index with
        /// [delete][google.datastore.admin.v1.DatastoreAdmin.DeleteIndex], then
        /// re-creating the index with [create]
        /// [google.datastore.admin.v1.DatastoreAdmin.CreateIndex].
        /// 
        /// Indexes with a single property cannot be created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Index, IndexOperationMetadata>> CreateIndexAsync(CreateIndexRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateIndexRequest(ref request, ref callSettings);
            return new lro::Operation<Index, IndexOperationMetadata>(await _callCreateIndex.Async(request, callSettings).ConfigureAwait(false), CreateIndexOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteIndex</c>.</summary>
        public override lro::OperationsClient DeleteIndexOperationsClient { get; }

        /// <summary>
        /// Deletes an existing index.
        /// An index can only be deleted if it is in a `READY` or `ERROR` state. On
        /// successful execution of the request, the index will be in a `DELETING`
        /// [state][google.datastore.admin.v1.Index.State]. And on completion of the
        /// returned [google.longrunning.Operation][google.longrunning.Operation], the
        /// index will be removed.
        /// 
        /// During index deletion, the process could result in an error, in which
        /// case the index will move to the `ERROR` state. The process can be recovered
        /// by fixing the data that caused the error, followed by calling
        /// [delete][google.datastore.admin.v1.DatastoreAdmin.DeleteIndex] again.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Index, IndexOperationMetadata> DeleteIndex(DeleteIndexRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteIndexRequest(ref request, ref callSettings);
            return new lro::Operation<Index, IndexOperationMetadata>(_callDeleteIndex.Sync(request, callSettings), DeleteIndexOperationsClient);
        }

        /// <summary>
        /// Deletes an existing index.
        /// An index can only be deleted if it is in a `READY` or `ERROR` state. On
        /// successful execution of the request, the index will be in a `DELETING`
        /// [state][google.datastore.admin.v1.Index.State]. And on completion of the
        /// returned [google.longrunning.Operation][google.longrunning.Operation], the
        /// index will be removed.
        /// 
        /// During index deletion, the process could result in an error, in which
        /// case the index will move to the `ERROR` state. The process can be recovered
        /// by fixing the data that caused the error, followed by calling
        /// [delete][google.datastore.admin.v1.DatastoreAdmin.DeleteIndex] again.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Index, IndexOperationMetadata>> DeleteIndexAsync(DeleteIndexRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteIndexRequest(ref request, ref callSettings);
            return new lro::Operation<Index, IndexOperationMetadata>(await _callDeleteIndex.Async(request, callSettings).ConfigureAwait(false), DeleteIndexOperationsClient);
        }

        /// <summary>
        /// Gets an index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Index GetIndex(GetIndexRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIndexRequest(ref request, ref callSettings);
            return _callGetIndex.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Index> GetIndexAsync(GetIndexRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIndexRequest(ref request, ref callSettings);
            return _callGetIndex.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the indexes that match the specified filters.  Datastore uses an
        /// eventually consistent query to fetch the list of indexes and may
        /// occasionally return stale results.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Index"/> resources.</returns>
        public override gax::PagedEnumerable<ListIndexesResponse, Index> ListIndexes(ListIndexesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListIndexesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListIndexesRequest, ListIndexesResponse, Index>(_callListIndexes, request, callSettings);
        }

        /// <summary>
        /// Lists the indexes that match the specified filters.  Datastore uses an
        /// eventually consistent query to fetch the list of indexes and may
        /// occasionally return stale results.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Index"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListIndexesResponse, Index> ListIndexesAsync(ListIndexesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListIndexesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListIndexesRequest, ListIndexesResponse, Index>(_callListIndexes, request, callSettings);
        }
    }

    public partial class ListIndexesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListIndexesResponse : gaxgrpc::IPageResponse<Index>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Index> GetEnumerator() => Indexes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class DatastoreAdmin
    {
        public partial class DatastoreAdminClient
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
