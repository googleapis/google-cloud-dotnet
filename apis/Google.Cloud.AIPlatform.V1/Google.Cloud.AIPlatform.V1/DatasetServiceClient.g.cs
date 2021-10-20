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
using gagr = Google.Api.Gax.ResourceNames;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.AIPlatform.V1
{
    /// <summary>Settings for <see cref="DatasetServiceClient"/> instances.</summary>
    public sealed partial class DatasetServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DatasetServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DatasetServiceSettings"/>.</returns>
        public static DatasetServiceSettings GetDefault() => new DatasetServiceSettings();

        /// <summary>Constructs a new <see cref="DatasetServiceSettings"/> object with default settings.</summary>
        public DatasetServiceSettings()
        {
        }

        private DatasetServiceSettings(DatasetServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateDatasetSettings = existing.CreateDatasetSettings;
            CreateDatasetOperationsSettings = existing.CreateDatasetOperationsSettings.Clone();
            GetDatasetSettings = existing.GetDatasetSettings;
            UpdateDatasetSettings = existing.UpdateDatasetSettings;
            ListDatasetsSettings = existing.ListDatasetsSettings;
            DeleteDatasetSettings = existing.DeleteDatasetSettings;
            DeleteDatasetOperationsSettings = existing.DeleteDatasetOperationsSettings.Clone();
            ImportDataSettings = existing.ImportDataSettings;
            ImportDataOperationsSettings = existing.ImportDataOperationsSettings.Clone();
            ExportDataSettings = existing.ExportDataSettings;
            ExportDataOperationsSettings = existing.ExportDataOperationsSettings.Clone();
            ListDataItemsSettings = existing.ListDataItemsSettings;
            GetAnnotationSpecSettings = existing.GetAnnotationSpecSettings;
            ListAnnotationsSettings = existing.ListAnnotationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DatasetServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatasetServiceClient.CreateDataset</c> and <c>DatasetServiceClient.CreateDatasetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDatasetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DatasetServiceClient.CreateDataset</c> and
        /// <c>DatasetServiceClient.CreateDatasetAsync</c>.
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
        public lro::OperationsSettings CreateDatasetOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatasetServiceClient.GetDataset</c> and <c>DatasetServiceClient.GetDatasetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDatasetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatasetServiceClient.UpdateDataset</c> and <c>DatasetServiceClient.UpdateDatasetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDatasetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatasetServiceClient.ListDatasets</c> and <c>DatasetServiceClient.ListDatasetsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDatasetsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatasetServiceClient.DeleteDataset</c> and <c>DatasetServiceClient.DeleteDatasetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDatasetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DatasetServiceClient.DeleteDataset</c> and
        /// <c>DatasetServiceClient.DeleteDatasetAsync</c>.
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
        public lro::OperationsSettings DeleteDatasetOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatasetServiceClient.ImportData</c> and <c>DatasetServiceClient.ImportDataAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ImportDataSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DatasetServiceClient.ImportData</c> and
        /// <c>DatasetServiceClient.ImportDataAsync</c>.
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
        public lro::OperationsSettings ImportDataOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatasetServiceClient.ExportData</c> and <c>DatasetServiceClient.ExportDataAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExportDataSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DatasetServiceClient.ExportData</c> and
        /// <c>DatasetServiceClient.ExportDataAsync</c>.
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
        public lro::OperationsSettings ExportDataOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatasetServiceClient.ListDataItems</c> and <c>DatasetServiceClient.ListDataItemsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDataItemsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatasetServiceClient.GetAnnotationSpec</c> and <c>DatasetServiceClient.GetAnnotationSpecAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAnnotationSpecSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatasetServiceClient.ListAnnotations</c> and <c>DatasetServiceClient.ListAnnotationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAnnotationsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DatasetServiceSettings"/> object.</returns>
        public DatasetServiceSettings Clone() => new DatasetServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DatasetServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class DatasetServiceClientBuilder : gaxgrpc::ClientBuilderBase<DatasetServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DatasetServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DatasetServiceClientBuilder()
        {
            UseJwtAccessWithScopes = DatasetServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref DatasetServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DatasetServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DatasetServiceClient Build()
        {
            DatasetServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DatasetServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DatasetServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DatasetServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DatasetServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<DatasetServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DatasetServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => DatasetServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => DatasetServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DatasetServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>DatasetService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The service that handles the CRUD of Vertex AI Dataset and its child
    /// resources.
    /// Service for managing datasets.
    /// </remarks>
    public abstract partial class DatasetServiceClient
    {
        /// <summary>
        /// The default endpoint for the DatasetService service, which is a host of "aiplatform.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "aiplatform.googleapis.com:443";

        /// <summary>The default DatasetService scopes.</summary>
        /// <remarks>
        /// The default DatasetService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes, UseJwtAccessWithScopes);

        internal static bool UseJwtAccessWithScopes
        {
            get
            {
                bool useJwtAccessWithScopes = true;
                MaybeUseJwtAccessWithScopes(ref useJwtAccessWithScopes);
                return useJwtAccessWithScopes;
            }
        }

        static partial void MaybeUseJwtAccessWithScopes(ref bool useJwtAccessWithScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="DatasetServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DatasetServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DatasetServiceClient"/>.</returns>
        public static stt::Task<DatasetServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DatasetServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DatasetServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DatasetServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DatasetServiceClient"/>.</returns>
        public static DatasetServiceClient Create() => new DatasetServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DatasetServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DatasetServiceSettings"/>.</param>
        /// <returns>The created <see cref="DatasetServiceClient"/>.</returns>
        internal static DatasetServiceClient Create(grpccore::CallInvoker callInvoker, DatasetServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DatasetService.DatasetServiceClient grpcClient = new DatasetService.DatasetServiceClient(callInvoker);
            return new DatasetServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC DatasetService client</summary>
        public virtual DatasetService.DatasetServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Dataset, CreateDatasetOperationMetadata> CreateDataset(CreateDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Dataset, CreateDatasetOperationMetadata>> CreateDatasetAsync(CreateDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Dataset, CreateDatasetOperationMetadata>> CreateDatasetAsync(CreateDatasetRequest request, st::CancellationToken cancellationToken) =>
            CreateDatasetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateDataset</c>.</summary>
        public virtual lro::OperationsClient CreateDatasetOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateDataset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Dataset, CreateDatasetOperationMetadata> PollOnceCreateDataset(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Dataset, CreateDatasetOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDatasetOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateDataset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Dataset, CreateDatasetOperationMetadata>> PollOnceCreateDatasetAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Dataset, CreateDatasetOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDatasetOperationsClient, callSettings);

        /// <summary>
        /// Creates a Dataset.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the Dataset in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="dataset">
        /// Required. The Dataset to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Dataset, CreateDatasetOperationMetadata> CreateDataset(string parent, Dataset dataset, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataset(new CreateDatasetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Dataset = gax::GaxPreconditions.CheckNotNull(dataset, nameof(dataset)),
            }, callSettings);

        /// <summary>
        /// Creates a Dataset.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the Dataset in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="dataset">
        /// Required. The Dataset to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Dataset, CreateDatasetOperationMetadata>> CreateDatasetAsync(string parent, Dataset dataset, gaxgrpc::CallSettings callSettings = null) =>
            CreateDatasetAsync(new CreateDatasetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Dataset = gax::GaxPreconditions.CheckNotNull(dataset, nameof(dataset)),
            }, callSettings);

        /// <summary>
        /// Creates a Dataset.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the Dataset in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="dataset">
        /// Required. The Dataset to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Dataset, CreateDatasetOperationMetadata>> CreateDatasetAsync(string parent, Dataset dataset, st::CancellationToken cancellationToken) =>
            CreateDatasetAsync(parent, dataset, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Dataset.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the Dataset in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="dataset">
        /// Required. The Dataset to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Dataset, CreateDatasetOperationMetadata> CreateDataset(gagr::LocationName parent, Dataset dataset, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataset(new CreateDatasetRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Dataset = gax::GaxPreconditions.CheckNotNull(dataset, nameof(dataset)),
            }, callSettings);

        /// <summary>
        /// Creates a Dataset.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the Dataset in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="dataset">
        /// Required. The Dataset to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Dataset, CreateDatasetOperationMetadata>> CreateDatasetAsync(gagr::LocationName parent, Dataset dataset, gaxgrpc::CallSettings callSettings = null) =>
            CreateDatasetAsync(new CreateDatasetRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Dataset = gax::GaxPreconditions.CheckNotNull(dataset, nameof(dataset)),
            }, callSettings);

        /// <summary>
        /// Creates a Dataset.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the Dataset in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="dataset">
        /// Required. The Dataset to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Dataset, CreateDatasetOperationMetadata>> CreateDatasetAsync(gagr::LocationName parent, Dataset dataset, st::CancellationToken cancellationToken) =>
            CreateDatasetAsync(parent, dataset, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dataset GetDataset(GetDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a Dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> GetDatasetAsync(GetDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a Dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> GetDatasetAsync(GetDatasetRequest request, st::CancellationToken cancellationToken) =>
            GetDatasetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Dataset resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dataset GetDataset(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataset(new GetDatasetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Dataset resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> GetDatasetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDatasetAsync(new GetDatasetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Dataset resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> GetDatasetAsync(string name, st::CancellationToken cancellationToken) =>
            GetDatasetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Dataset resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dataset GetDataset(DatasetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataset(new GetDatasetRequest
            {
                DatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Dataset resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> GetDatasetAsync(DatasetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDatasetAsync(new GetDatasetRequest
            {
                DatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Dataset resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> GetDatasetAsync(DatasetName name, st::CancellationToken cancellationToken) =>
            GetDatasetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a Dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dataset UpdateDataset(UpdateDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a Dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> UpdateDatasetAsync(UpdateDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a Dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> UpdateDatasetAsync(UpdateDatasetRequest request, st::CancellationToken cancellationToken) =>
            UpdateDatasetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a Dataset.
        /// </summary>
        /// <param name="dataset">
        /// Required. The Dataset which replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource.
        /// For the `FieldMask` definition, see [google.protobuf.FieldMask][google.protobuf.FieldMask].
        /// Updatable fields:
        /// 
        /// * `display_name`
        /// * `description`
        /// * `labels`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dataset UpdateDataset(Dataset dataset, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataset(new UpdateDatasetRequest
            {
                Dataset = gax::GaxPreconditions.CheckNotNull(dataset, nameof(dataset)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a Dataset.
        /// </summary>
        /// <param name="dataset">
        /// Required. The Dataset which replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource.
        /// For the `FieldMask` definition, see [google.protobuf.FieldMask][google.protobuf.FieldMask].
        /// Updatable fields:
        /// 
        /// * `display_name`
        /// * `description`
        /// * `labels`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> UpdateDatasetAsync(Dataset dataset, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDatasetAsync(new UpdateDatasetRequest
            {
                Dataset = gax::GaxPreconditions.CheckNotNull(dataset, nameof(dataset)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a Dataset.
        /// </summary>
        /// <param name="dataset">
        /// Required. The Dataset which replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource.
        /// For the `FieldMask` definition, see [google.protobuf.FieldMask][google.protobuf.FieldMask].
        /// Updatable fields:
        /// 
        /// * `display_name`
        /// * `description`
        /// * `labels`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> UpdateDatasetAsync(Dataset dataset, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDatasetAsync(dataset, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Datasets in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Dataset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDatasetsResponse, Dataset> ListDatasets(ListDatasetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Datasets in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Dataset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDatasetsResponse, Dataset> ListDatasetsAsync(ListDatasetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Datasets in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the Dataset's parent resource.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="Dataset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDatasetsResponse, Dataset> ListDatasets(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDatasets(new ListDatasetsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Datasets in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the Dataset's parent resource.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Dataset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDatasetsResponse, Dataset> ListDatasetsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDatasetsAsync(new ListDatasetsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Datasets in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the Dataset's parent resource.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="Dataset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDatasetsResponse, Dataset> ListDatasets(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDatasets(new ListDatasetsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Datasets in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the Dataset's parent resource.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Dataset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDatasetsResponse, Dataset> ListDatasetsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDatasetsAsync(new ListDatasetsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Deletes a Dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteDataset(DeleteDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteDatasetAsync(DeleteDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteDatasetAsync(DeleteDatasetRequest request, st::CancellationToken cancellationToken) =>
            DeleteDatasetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteDataset</c>.</summary>
        public virtual lro::OperationsClient DeleteDatasetOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteDataset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> PollOnceDeleteDataset(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDatasetOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteDataset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> PollOnceDeleteDatasetAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDatasetOperationsClient, callSettings);

        /// <summary>
        /// Deletes a Dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Dataset to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/datasets/{dataset}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteDataset(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataset(new DeleteDatasetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Dataset to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/datasets/{dataset}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteDatasetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDatasetAsync(new DeleteDatasetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Dataset to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/datasets/{dataset}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteDatasetAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDatasetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Dataset to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/datasets/{dataset}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteDataset(DatasetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataset(new DeleteDatasetRequest
            {
                DatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Dataset to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/datasets/{dataset}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteDatasetAsync(DatasetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDatasetAsync(new DeleteDatasetRequest
            {
                DatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Dataset to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/datasets/{dataset}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteDatasetAsync(DatasetName name, st::CancellationToken cancellationToken) =>
            DeleteDatasetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports data into a Dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportDataResponse, ImportDataOperationMetadata> ImportData(ImportDataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports data into a Dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportDataResponse, ImportDataOperationMetadata>> ImportDataAsync(ImportDataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports data into a Dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportDataResponse, ImportDataOperationMetadata>> ImportDataAsync(ImportDataRequest request, st::CancellationToken cancellationToken) =>
            ImportDataAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ImportData</c>.</summary>
        public virtual lro::OperationsClient ImportDataOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ImportData</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ImportDataResponse, ImportDataOperationMetadata> PollOnceImportData(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportDataResponse, ImportDataOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportDataOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ImportData</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ImportDataResponse, ImportDataOperationMetadata>> PollOnceImportDataAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportDataResponse, ImportDataOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportDataOperationsClient, callSettings);

        /// <summary>
        /// Imports data into a Dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Dataset resource.
        /// Format:
        /// `projects/{project}/locations/{location}/datasets/{dataset}`
        /// </param>
        /// <param name="importConfigs">
        /// Required. The desired input locations. The contents of all input locations will be
        /// imported in one batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportDataResponse, ImportDataOperationMetadata> ImportData(string name, scg::IEnumerable<ImportDataConfig> importConfigs, gaxgrpc::CallSettings callSettings = null) =>
            ImportData(new ImportDataRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                ImportConfigs =
                {
                    gax::GaxPreconditions.CheckNotNull(importConfigs, nameof(importConfigs)),
                },
            }, callSettings);

        /// <summary>
        /// Imports data into a Dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Dataset resource.
        /// Format:
        /// `projects/{project}/locations/{location}/datasets/{dataset}`
        /// </param>
        /// <param name="importConfigs">
        /// Required. The desired input locations. The contents of all input locations will be
        /// imported in one batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportDataResponse, ImportDataOperationMetadata>> ImportDataAsync(string name, scg::IEnumerable<ImportDataConfig> importConfigs, gaxgrpc::CallSettings callSettings = null) =>
            ImportDataAsync(new ImportDataRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                ImportConfigs =
                {
                    gax::GaxPreconditions.CheckNotNull(importConfigs, nameof(importConfigs)),
                },
            }, callSettings);

        /// <summary>
        /// Imports data into a Dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Dataset resource.
        /// Format:
        /// `projects/{project}/locations/{location}/datasets/{dataset}`
        /// </param>
        /// <param name="importConfigs">
        /// Required. The desired input locations. The contents of all input locations will be
        /// imported in one batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportDataResponse, ImportDataOperationMetadata>> ImportDataAsync(string name, scg::IEnumerable<ImportDataConfig> importConfigs, st::CancellationToken cancellationToken) =>
            ImportDataAsync(name, importConfigs, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports data into a Dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Dataset resource.
        /// Format:
        /// `projects/{project}/locations/{location}/datasets/{dataset}`
        /// </param>
        /// <param name="importConfigs">
        /// Required. The desired input locations. The contents of all input locations will be
        /// imported in one batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportDataResponse, ImportDataOperationMetadata> ImportData(DatasetName name, scg::IEnumerable<ImportDataConfig> importConfigs, gaxgrpc::CallSettings callSettings = null) =>
            ImportData(new ImportDataRequest
            {
                DatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                ImportConfigs =
                {
                    gax::GaxPreconditions.CheckNotNull(importConfigs, nameof(importConfigs)),
                },
            }, callSettings);

        /// <summary>
        /// Imports data into a Dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Dataset resource.
        /// Format:
        /// `projects/{project}/locations/{location}/datasets/{dataset}`
        /// </param>
        /// <param name="importConfigs">
        /// Required. The desired input locations. The contents of all input locations will be
        /// imported in one batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportDataResponse, ImportDataOperationMetadata>> ImportDataAsync(DatasetName name, scg::IEnumerable<ImportDataConfig> importConfigs, gaxgrpc::CallSettings callSettings = null) =>
            ImportDataAsync(new ImportDataRequest
            {
                DatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                ImportConfigs =
                {
                    gax::GaxPreconditions.CheckNotNull(importConfigs, nameof(importConfigs)),
                },
            }, callSettings);

        /// <summary>
        /// Imports data into a Dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Dataset resource.
        /// Format:
        /// `projects/{project}/locations/{location}/datasets/{dataset}`
        /// </param>
        /// <param name="importConfigs">
        /// Required. The desired input locations. The contents of all input locations will be
        /// imported in one batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportDataResponse, ImportDataOperationMetadata>> ImportDataAsync(DatasetName name, scg::IEnumerable<ImportDataConfig> importConfigs, st::CancellationToken cancellationToken) =>
            ImportDataAsync(name, importConfigs, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports data from a Dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportDataResponse, ExportDataOperationMetadata> ExportData(ExportDataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports data from a Dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportDataResponse, ExportDataOperationMetadata>> ExportDataAsync(ExportDataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports data from a Dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportDataResponse, ExportDataOperationMetadata>> ExportDataAsync(ExportDataRequest request, st::CancellationToken cancellationToken) =>
            ExportDataAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ExportData</c>.</summary>
        public virtual lro::OperationsClient ExportDataOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ExportData</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ExportDataResponse, ExportDataOperationMetadata> PollOnceExportData(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportDataResponse, ExportDataOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportDataOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportData</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ExportDataResponse, ExportDataOperationMetadata>> PollOnceExportDataAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportDataResponse, ExportDataOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportDataOperationsClient, callSettings);

        /// <summary>
        /// Exports data from a Dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Dataset resource.
        /// Format:
        /// `projects/{project}/locations/{location}/datasets/{dataset}`
        /// </param>
        /// <param name="exportConfig">
        /// Required. The desired output location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportDataResponse, ExportDataOperationMetadata> ExportData(string name, ExportDataConfig exportConfig, gaxgrpc::CallSettings callSettings = null) =>
            ExportData(new ExportDataRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                ExportConfig = gax::GaxPreconditions.CheckNotNull(exportConfig, nameof(exportConfig)),
            }, callSettings);

        /// <summary>
        /// Exports data from a Dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Dataset resource.
        /// Format:
        /// `projects/{project}/locations/{location}/datasets/{dataset}`
        /// </param>
        /// <param name="exportConfig">
        /// Required. The desired output location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportDataResponse, ExportDataOperationMetadata>> ExportDataAsync(string name, ExportDataConfig exportConfig, gaxgrpc::CallSettings callSettings = null) =>
            ExportDataAsync(new ExportDataRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                ExportConfig = gax::GaxPreconditions.CheckNotNull(exportConfig, nameof(exportConfig)),
            }, callSettings);

        /// <summary>
        /// Exports data from a Dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Dataset resource.
        /// Format:
        /// `projects/{project}/locations/{location}/datasets/{dataset}`
        /// </param>
        /// <param name="exportConfig">
        /// Required. The desired output location.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportDataResponse, ExportDataOperationMetadata>> ExportDataAsync(string name, ExportDataConfig exportConfig, st::CancellationToken cancellationToken) =>
            ExportDataAsync(name, exportConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports data from a Dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Dataset resource.
        /// Format:
        /// `projects/{project}/locations/{location}/datasets/{dataset}`
        /// </param>
        /// <param name="exportConfig">
        /// Required. The desired output location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportDataResponse, ExportDataOperationMetadata> ExportData(DatasetName name, ExportDataConfig exportConfig, gaxgrpc::CallSettings callSettings = null) =>
            ExportData(new ExportDataRequest
            {
                DatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                ExportConfig = gax::GaxPreconditions.CheckNotNull(exportConfig, nameof(exportConfig)),
            }, callSettings);

        /// <summary>
        /// Exports data from a Dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Dataset resource.
        /// Format:
        /// `projects/{project}/locations/{location}/datasets/{dataset}`
        /// </param>
        /// <param name="exportConfig">
        /// Required. The desired output location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportDataResponse, ExportDataOperationMetadata>> ExportDataAsync(DatasetName name, ExportDataConfig exportConfig, gaxgrpc::CallSettings callSettings = null) =>
            ExportDataAsync(new ExportDataRequest
            {
                DatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                ExportConfig = gax::GaxPreconditions.CheckNotNull(exportConfig, nameof(exportConfig)),
            }, callSettings);

        /// <summary>
        /// Exports data from a Dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Dataset resource.
        /// Format:
        /// `projects/{project}/locations/{location}/datasets/{dataset}`
        /// </param>
        /// <param name="exportConfig">
        /// Required. The desired output location.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportDataResponse, ExportDataOperationMetadata>> ExportDataAsync(DatasetName name, ExportDataConfig exportConfig, st::CancellationToken cancellationToken) =>
            ExportDataAsync(name, exportConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists DataItems in a Dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataItem"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataItemsResponse, DataItem> ListDataItems(ListDataItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists DataItems in a Dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataItem"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataItemsResponse, DataItem> ListDataItemsAsync(ListDataItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists DataItems in a Dataset.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Dataset to list DataItems from.
        /// Format:
        /// `projects/{project}/locations/{location}/datasets/{dataset}`
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
        /// <returns>A pageable sequence of <see cref="DataItem"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataItemsResponse, DataItem> ListDataItems(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDataItems(new ListDataItemsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists DataItems in a Dataset.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Dataset to list DataItems from.
        /// Format:
        /// `projects/{project}/locations/{location}/datasets/{dataset}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataItem"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataItemsResponse, DataItem> ListDataItemsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDataItemsAsync(new ListDataItemsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists DataItems in a Dataset.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Dataset to list DataItems from.
        /// Format:
        /// `projects/{project}/locations/{location}/datasets/{dataset}`
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
        /// <returns>A pageable sequence of <see cref="DataItem"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataItemsResponse, DataItem> ListDataItems(DatasetName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDataItems(new ListDataItemsRequest
            {
                ParentAsDatasetName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists DataItems in a Dataset.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Dataset to list DataItems from.
        /// Format:
        /// `projects/{project}/locations/{location}/datasets/{dataset}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataItem"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataItemsResponse, DataItem> ListDataItemsAsync(DatasetName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDataItemsAsync(new ListDataItemsRequest
            {
                ParentAsDatasetName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets an AnnotationSpec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnnotationSpec GetAnnotationSpec(GetAnnotationSpecRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an AnnotationSpec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotationSpec> GetAnnotationSpecAsync(GetAnnotationSpecRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an AnnotationSpec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotationSpec> GetAnnotationSpecAsync(GetAnnotationSpecRequest request, st::CancellationToken cancellationToken) =>
            GetAnnotationSpecAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an AnnotationSpec.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the AnnotationSpec resource.
        /// Format:
        /// `projects/{project}/locations/{location}/datasets/{dataset}/annotationSpecs/{annotation_spec}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnnotationSpec GetAnnotationSpec(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnnotationSpec(new GetAnnotationSpecRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an AnnotationSpec.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the AnnotationSpec resource.
        /// Format:
        /// `projects/{project}/locations/{location}/datasets/{dataset}/annotationSpecs/{annotation_spec}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotationSpec> GetAnnotationSpecAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnnotationSpecAsync(new GetAnnotationSpecRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an AnnotationSpec.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the AnnotationSpec resource.
        /// Format:
        /// `projects/{project}/locations/{location}/datasets/{dataset}/annotationSpecs/{annotation_spec}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotationSpec> GetAnnotationSpecAsync(string name, st::CancellationToken cancellationToken) =>
            GetAnnotationSpecAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an AnnotationSpec.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the AnnotationSpec resource.
        /// Format:
        /// `projects/{project}/locations/{location}/datasets/{dataset}/annotationSpecs/{annotation_spec}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnnotationSpec GetAnnotationSpec(AnnotationSpecName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnnotationSpec(new GetAnnotationSpecRequest
            {
                AnnotationSpecName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an AnnotationSpec.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the AnnotationSpec resource.
        /// Format:
        /// `projects/{project}/locations/{location}/datasets/{dataset}/annotationSpecs/{annotation_spec}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotationSpec> GetAnnotationSpecAsync(AnnotationSpecName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnnotationSpecAsync(new GetAnnotationSpecRequest
            {
                AnnotationSpecName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an AnnotationSpec.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the AnnotationSpec resource.
        /// Format:
        /// `projects/{project}/locations/{location}/datasets/{dataset}/annotationSpecs/{annotation_spec}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotationSpec> GetAnnotationSpecAsync(AnnotationSpecName name, st::CancellationToken cancellationToken) =>
            GetAnnotationSpecAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Annotations belongs to a dataitem
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Annotation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAnnotationsResponse, Annotation> ListAnnotations(ListAnnotationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Annotations belongs to a dataitem
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Annotation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAnnotationsResponse, Annotation> ListAnnotationsAsync(ListAnnotationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Annotations belongs to a dataitem
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the DataItem to list Annotations from.
        /// Format:
        /// `projects/{project}/locations/{location}/datasets/{dataset}/dataItems/{data_item}`
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
        /// <returns>A pageable sequence of <see cref="Annotation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAnnotationsResponse, Annotation> ListAnnotations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAnnotations(new ListAnnotationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Annotations belongs to a dataitem
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the DataItem to list Annotations from.
        /// Format:
        /// `projects/{project}/locations/{location}/datasets/{dataset}/dataItems/{data_item}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Annotation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAnnotationsResponse, Annotation> ListAnnotationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAnnotationsAsync(new ListAnnotationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Annotations belongs to a dataitem
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the DataItem to list Annotations from.
        /// Format:
        /// `projects/{project}/locations/{location}/datasets/{dataset}/dataItems/{data_item}`
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
        /// <returns>A pageable sequence of <see cref="Annotation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAnnotationsResponse, Annotation> ListAnnotations(DataItemName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAnnotations(new ListAnnotationsRequest
            {
                ParentAsDataItemName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Annotations belongs to a dataitem
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the DataItem to list Annotations from.
        /// Format:
        /// `projects/{project}/locations/{location}/datasets/{dataset}/dataItems/{data_item}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Annotation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAnnotationsResponse, Annotation> ListAnnotationsAsync(DataItemName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAnnotationsAsync(new ListAnnotationsRequest
            {
                ParentAsDataItemName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);
    }

    /// <summary>DatasetService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The service that handles the CRUD of Vertex AI Dataset and its child
    /// resources.
    /// Service for managing datasets.
    /// </remarks>
    public sealed partial class DatasetServiceClientImpl : DatasetServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateDatasetRequest, lro::Operation> _callCreateDataset;

        private readonly gaxgrpc::ApiCall<GetDatasetRequest, Dataset> _callGetDataset;

        private readonly gaxgrpc::ApiCall<UpdateDatasetRequest, Dataset> _callUpdateDataset;

        private readonly gaxgrpc::ApiCall<ListDatasetsRequest, ListDatasetsResponse> _callListDatasets;

        private readonly gaxgrpc::ApiCall<DeleteDatasetRequest, lro::Operation> _callDeleteDataset;

        private readonly gaxgrpc::ApiCall<ImportDataRequest, lro::Operation> _callImportData;

        private readonly gaxgrpc::ApiCall<ExportDataRequest, lro::Operation> _callExportData;

        private readonly gaxgrpc::ApiCall<ListDataItemsRequest, ListDataItemsResponse> _callListDataItems;

        private readonly gaxgrpc::ApiCall<GetAnnotationSpecRequest, AnnotationSpec> _callGetAnnotationSpec;

        private readonly gaxgrpc::ApiCall<ListAnnotationsRequest, ListAnnotationsResponse> _callListAnnotations;

        /// <summary>
        /// Constructs a client wrapper for the DatasetService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DatasetServiceSettings"/> used within this client.</param>
        public DatasetServiceClientImpl(DatasetService.DatasetServiceClient grpcClient, DatasetServiceSettings settings)
        {
            GrpcClient = grpcClient;
            DatasetServiceSettings effectiveSettings = settings ?? DatasetServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            CreateDatasetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateDatasetOperationsSettings);
            DeleteDatasetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteDatasetOperationsSettings);
            ImportDataOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ImportDataOperationsSettings);
            ExportDataOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ExportDataOperationsSettings);
            _callCreateDataset = clientHelper.BuildApiCall<CreateDatasetRequest, lro::Operation>(grpcClient.CreateDatasetAsync, grpcClient.CreateDataset, effectiveSettings.CreateDatasetSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDataset);
            Modify_CreateDatasetApiCall(ref _callCreateDataset);
            _callGetDataset = clientHelper.BuildApiCall<GetDatasetRequest, Dataset>(grpcClient.GetDatasetAsync, grpcClient.GetDataset, effectiveSettings.GetDatasetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDataset);
            Modify_GetDatasetApiCall(ref _callGetDataset);
            _callUpdateDataset = clientHelper.BuildApiCall<UpdateDatasetRequest, Dataset>(grpcClient.UpdateDatasetAsync, grpcClient.UpdateDataset, effectiveSettings.UpdateDatasetSettings).WithGoogleRequestParam("dataset.name", request => request.Dataset?.Name);
            Modify_ApiCall(ref _callUpdateDataset);
            Modify_UpdateDatasetApiCall(ref _callUpdateDataset);
            _callListDatasets = clientHelper.BuildApiCall<ListDatasetsRequest, ListDatasetsResponse>(grpcClient.ListDatasetsAsync, grpcClient.ListDatasets, effectiveSettings.ListDatasetsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDatasets);
            Modify_ListDatasetsApiCall(ref _callListDatasets);
            _callDeleteDataset = clientHelper.BuildApiCall<DeleteDatasetRequest, lro::Operation>(grpcClient.DeleteDatasetAsync, grpcClient.DeleteDataset, effectiveSettings.DeleteDatasetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDataset);
            Modify_DeleteDatasetApiCall(ref _callDeleteDataset);
            _callImportData = clientHelper.BuildApiCall<ImportDataRequest, lro::Operation>(grpcClient.ImportDataAsync, grpcClient.ImportData, effectiveSettings.ImportDataSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callImportData);
            Modify_ImportDataApiCall(ref _callImportData);
            _callExportData = clientHelper.BuildApiCall<ExportDataRequest, lro::Operation>(grpcClient.ExportDataAsync, grpcClient.ExportData, effectiveSettings.ExportDataSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callExportData);
            Modify_ExportDataApiCall(ref _callExportData);
            _callListDataItems = clientHelper.BuildApiCall<ListDataItemsRequest, ListDataItemsResponse>(grpcClient.ListDataItemsAsync, grpcClient.ListDataItems, effectiveSettings.ListDataItemsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDataItems);
            Modify_ListDataItemsApiCall(ref _callListDataItems);
            _callGetAnnotationSpec = clientHelper.BuildApiCall<GetAnnotationSpecRequest, AnnotationSpec>(grpcClient.GetAnnotationSpecAsync, grpcClient.GetAnnotationSpec, effectiveSettings.GetAnnotationSpecSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAnnotationSpec);
            Modify_GetAnnotationSpecApiCall(ref _callGetAnnotationSpec);
            _callListAnnotations = clientHelper.BuildApiCall<ListAnnotationsRequest, ListAnnotationsResponse>(grpcClient.ListAnnotationsAsync, grpcClient.ListAnnotations, effectiveSettings.ListAnnotationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAnnotations);
            Modify_ListAnnotationsApiCall(ref _callListAnnotations);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateDatasetApiCall(ref gaxgrpc::ApiCall<CreateDatasetRequest, lro::Operation> call);

        partial void Modify_GetDatasetApiCall(ref gaxgrpc::ApiCall<GetDatasetRequest, Dataset> call);

        partial void Modify_UpdateDatasetApiCall(ref gaxgrpc::ApiCall<UpdateDatasetRequest, Dataset> call);

        partial void Modify_ListDatasetsApiCall(ref gaxgrpc::ApiCall<ListDatasetsRequest, ListDatasetsResponse> call);

        partial void Modify_DeleteDatasetApiCall(ref gaxgrpc::ApiCall<DeleteDatasetRequest, lro::Operation> call);

        partial void Modify_ImportDataApiCall(ref gaxgrpc::ApiCall<ImportDataRequest, lro::Operation> call);

        partial void Modify_ExportDataApiCall(ref gaxgrpc::ApiCall<ExportDataRequest, lro::Operation> call);

        partial void Modify_ListDataItemsApiCall(ref gaxgrpc::ApiCall<ListDataItemsRequest, ListDataItemsResponse> call);

        partial void Modify_GetAnnotationSpecApiCall(ref gaxgrpc::ApiCall<GetAnnotationSpecRequest, AnnotationSpec> call);

        partial void Modify_ListAnnotationsApiCall(ref gaxgrpc::ApiCall<ListAnnotationsRequest, ListAnnotationsResponse> call);

        partial void OnConstruction(DatasetService.DatasetServiceClient grpcClient, DatasetServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DatasetService client</summary>
        public override DatasetService.DatasetServiceClient GrpcClient { get; }

        partial void Modify_CreateDatasetRequest(ref CreateDatasetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDatasetRequest(ref GetDatasetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDatasetRequest(ref UpdateDatasetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDatasetsRequest(ref ListDatasetsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDatasetRequest(ref DeleteDatasetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportDataRequest(ref ImportDataRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportDataRequest(ref ExportDataRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDataItemsRequest(ref ListDataItemsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAnnotationSpecRequest(ref GetAnnotationSpecRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAnnotationsRequest(ref ListAnnotationsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateDataset</c>.</summary>
        public override lro::OperationsClient CreateDatasetOperationsClient { get; }

        /// <summary>
        /// Creates a Dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Dataset, CreateDatasetOperationMetadata> CreateDataset(CreateDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDatasetRequest(ref request, ref callSettings);
            return new lro::Operation<Dataset, CreateDatasetOperationMetadata>(_callCreateDataset.Sync(request, callSettings), CreateDatasetOperationsClient);
        }

        /// <summary>
        /// Creates a Dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Dataset, CreateDatasetOperationMetadata>> CreateDatasetAsync(CreateDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDatasetRequest(ref request, ref callSettings);
            return new lro::Operation<Dataset, CreateDatasetOperationMetadata>(await _callCreateDataset.Async(request, callSettings).ConfigureAwait(false), CreateDatasetOperationsClient);
        }

        /// <summary>
        /// Gets a Dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Dataset GetDataset(GetDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDatasetRequest(ref request, ref callSettings);
            return _callGetDataset.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a Dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Dataset> GetDatasetAsync(GetDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDatasetRequest(ref request, ref callSettings);
            return _callGetDataset.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a Dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Dataset UpdateDataset(UpdateDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDatasetRequest(ref request, ref callSettings);
            return _callUpdateDataset.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a Dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Dataset> UpdateDatasetAsync(UpdateDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDatasetRequest(ref request, ref callSettings);
            return _callUpdateDataset.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Datasets in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Dataset"/> resources.</returns>
        public override gax::PagedEnumerable<ListDatasetsResponse, Dataset> ListDatasets(ListDatasetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDatasetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDatasetsRequest, ListDatasetsResponse, Dataset>(_callListDatasets, request, callSettings);
        }

        /// <summary>
        /// Lists Datasets in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Dataset"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDatasetsResponse, Dataset> ListDatasetsAsync(ListDatasetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDatasetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDatasetsRequest, ListDatasetsResponse, Dataset>(_callListDatasets, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteDataset</c>.</summary>
        public override lro::OperationsClient DeleteDatasetOperationsClient { get; }

        /// <summary>
        /// Deletes a Dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteDataset(DeleteDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDatasetRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(_callDeleteDataset.Sync(request, callSettings), DeleteDatasetOperationsClient);
        }

        /// <summary>
        /// Deletes a Dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteDatasetAsync(DeleteDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDatasetRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(await _callDeleteDataset.Async(request, callSettings).ConfigureAwait(false), DeleteDatasetOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ImportData</c>.</summary>
        public override lro::OperationsClient ImportDataOperationsClient { get; }

        /// <summary>
        /// Imports data into a Dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ImportDataResponse, ImportDataOperationMetadata> ImportData(ImportDataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportDataRequest(ref request, ref callSettings);
            return new lro::Operation<ImportDataResponse, ImportDataOperationMetadata>(_callImportData.Sync(request, callSettings), ImportDataOperationsClient);
        }

        /// <summary>
        /// Imports data into a Dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ImportDataResponse, ImportDataOperationMetadata>> ImportDataAsync(ImportDataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportDataRequest(ref request, ref callSettings);
            return new lro::Operation<ImportDataResponse, ImportDataOperationMetadata>(await _callImportData.Async(request, callSettings).ConfigureAwait(false), ImportDataOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ExportData</c>.</summary>
        public override lro::OperationsClient ExportDataOperationsClient { get; }

        /// <summary>
        /// Exports data from a Dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ExportDataResponse, ExportDataOperationMetadata> ExportData(ExportDataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportDataRequest(ref request, ref callSettings);
            return new lro::Operation<ExportDataResponse, ExportDataOperationMetadata>(_callExportData.Sync(request, callSettings), ExportDataOperationsClient);
        }

        /// <summary>
        /// Exports data from a Dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ExportDataResponse, ExportDataOperationMetadata>> ExportDataAsync(ExportDataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportDataRequest(ref request, ref callSettings);
            return new lro::Operation<ExportDataResponse, ExportDataOperationMetadata>(await _callExportData.Async(request, callSettings).ConfigureAwait(false), ExportDataOperationsClient);
        }

        /// <summary>
        /// Lists DataItems in a Dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataItem"/> resources.</returns>
        public override gax::PagedEnumerable<ListDataItemsResponse, DataItem> ListDataItems(ListDataItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataItemsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDataItemsRequest, ListDataItemsResponse, DataItem>(_callListDataItems, request, callSettings);
        }

        /// <summary>
        /// Lists DataItems in a Dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataItem"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDataItemsResponse, DataItem> ListDataItemsAsync(ListDataItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataItemsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDataItemsRequest, ListDataItemsResponse, DataItem>(_callListDataItems, request, callSettings);
        }

        /// <summary>
        /// Gets an AnnotationSpec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AnnotationSpec GetAnnotationSpec(GetAnnotationSpecRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAnnotationSpecRequest(ref request, ref callSettings);
            return _callGetAnnotationSpec.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an AnnotationSpec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AnnotationSpec> GetAnnotationSpecAsync(GetAnnotationSpecRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAnnotationSpecRequest(ref request, ref callSettings);
            return _callGetAnnotationSpec.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Annotations belongs to a dataitem
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Annotation"/> resources.</returns>
        public override gax::PagedEnumerable<ListAnnotationsResponse, Annotation> ListAnnotations(ListAnnotationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAnnotationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAnnotationsRequest, ListAnnotationsResponse, Annotation>(_callListAnnotations, request, callSettings);
        }

        /// <summary>
        /// Lists Annotations belongs to a dataitem
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Annotation"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAnnotationsResponse, Annotation> ListAnnotationsAsync(ListAnnotationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAnnotationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAnnotationsRequest, ListAnnotationsResponse, Annotation>(_callListAnnotations, request, callSettings);
        }
    }

    public partial class ListDatasetsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDataItemsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAnnotationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDatasetsResponse : gaxgrpc::IPageResponse<Dataset>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Dataset> GetEnumerator() => Datasets.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDataItemsResponse : gaxgrpc::IPageResponse<DataItem>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DataItem> GetEnumerator() => DataItems.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAnnotationsResponse : gaxgrpc::IPageResponse<Annotation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Annotation> GetEnumerator() => Annotations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class DatasetService
    {
        public partial class DatasetServiceClient
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
