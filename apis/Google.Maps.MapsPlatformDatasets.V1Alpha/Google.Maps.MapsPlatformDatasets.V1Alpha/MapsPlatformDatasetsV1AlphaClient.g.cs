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
using gagr = Google.Api.Gax.ResourceNames;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Maps.MapsPlatformDatasets.V1Alpha
{
    /// <summary>Settings for <see cref="MapsPlatformDatasetsV1AlphaClient"/> instances.</summary>
    public sealed partial class MapsPlatformDatasetsV1AlphaSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="MapsPlatformDatasetsV1AlphaSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="MapsPlatformDatasetsV1AlphaSettings"/>.</returns>
        public static MapsPlatformDatasetsV1AlphaSettings GetDefault() => new MapsPlatformDatasetsV1AlphaSettings();

        /// <summary>
        /// Constructs a new <see cref="MapsPlatformDatasetsV1AlphaSettings"/> object with default settings.
        /// </summary>
        public MapsPlatformDatasetsV1AlphaSettings()
        {
        }

        private MapsPlatformDatasetsV1AlphaSettings(MapsPlatformDatasetsV1AlphaSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateDatasetSettings = existing.CreateDatasetSettings;
            UpdateDatasetMetadataSettings = existing.UpdateDatasetMetadataSettings;
            GetDatasetSettings = existing.GetDatasetSettings;
            ListDatasetVersionsSettings = existing.ListDatasetVersionsSettings;
            ListDatasetsSettings = existing.ListDatasetsSettings;
            DeleteDatasetSettings = existing.DeleteDatasetSettings;
            DeleteDatasetVersionSettings = existing.DeleteDatasetVersionSettings;
            OnCopy(existing);
        }

        partial void OnCopy(MapsPlatformDatasetsV1AlphaSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MapsPlatformDatasetsV1AlphaClient.CreateDataset</c> and
        /// <c>MapsPlatformDatasetsV1AlphaClient.CreateDatasetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDatasetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MapsPlatformDatasetsV1AlphaClient.UpdateDatasetMetadata</c> and
        /// <c>MapsPlatformDatasetsV1AlphaClient.UpdateDatasetMetadataAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDatasetMetadataSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MapsPlatformDatasetsV1AlphaClient.GetDataset</c> and <c>MapsPlatformDatasetsV1AlphaClient.GetDatasetAsync</c>
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
        public gaxgrpc::CallSettings GetDatasetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MapsPlatformDatasetsV1AlphaClient.ListDatasetVersions</c> and
        /// <c>MapsPlatformDatasetsV1AlphaClient.ListDatasetVersionsAsync</c>.
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
        public gaxgrpc::CallSettings ListDatasetVersionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MapsPlatformDatasetsV1AlphaClient.ListDatasets</c> and
        /// <c>MapsPlatformDatasetsV1AlphaClient.ListDatasetsAsync</c>.
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
        public gaxgrpc::CallSettings ListDatasetsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MapsPlatformDatasetsV1AlphaClient.DeleteDataset</c> and
        /// <c>MapsPlatformDatasetsV1AlphaClient.DeleteDatasetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDatasetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MapsPlatformDatasetsV1AlphaClient.DeleteDatasetVersion</c> and
        /// <c>MapsPlatformDatasetsV1AlphaClient.DeleteDatasetVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDatasetVersionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="MapsPlatformDatasetsV1AlphaSettings"/> object.</returns>
        public MapsPlatformDatasetsV1AlphaSettings Clone() => new MapsPlatformDatasetsV1AlphaSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="MapsPlatformDatasetsV1AlphaClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class MapsPlatformDatasetsV1AlphaClientBuilder : gaxgrpc::ClientBuilderBase<MapsPlatformDatasetsV1AlphaClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public MapsPlatformDatasetsV1AlphaSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public MapsPlatformDatasetsV1AlphaClientBuilder() : base(MapsPlatformDatasetsV1AlphaClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref MapsPlatformDatasetsV1AlphaClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<MapsPlatformDatasetsV1AlphaClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override MapsPlatformDatasetsV1AlphaClient Build()
        {
            MapsPlatformDatasetsV1AlphaClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<MapsPlatformDatasetsV1AlphaClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<MapsPlatformDatasetsV1AlphaClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private MapsPlatformDatasetsV1AlphaClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return MapsPlatformDatasetsV1AlphaClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<MapsPlatformDatasetsV1AlphaClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return MapsPlatformDatasetsV1AlphaClient.Create(callInvoker, Settings, Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => MapsPlatformDatasetsV1AlphaClient.ChannelPool;
    }

    /// <summary>MapsPlatformDatasetsV1Alpha client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service definition for the Maps Platform Datasets API.
    /// </remarks>
    public abstract partial class MapsPlatformDatasetsV1AlphaClient
    {
        /// <summary>
        /// The default endpoint for the MapsPlatformDatasetsV1Alpha service, which is a host of
        /// "mapsplatformdatasets.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "mapsplatformdatasets.googleapis.com:443";

        /// <summary>The default MapsPlatformDatasetsV1Alpha scopes.</summary>
        /// <remarks>
        /// The default MapsPlatformDatasetsV1Alpha scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(MapsPlatformDatasetsV1Alpha.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="MapsPlatformDatasetsV1AlphaClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="MapsPlatformDatasetsV1AlphaClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="MapsPlatformDatasetsV1AlphaClient"/>.</returns>
        public static stt::Task<MapsPlatformDatasetsV1AlphaClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new MapsPlatformDatasetsV1AlphaClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="MapsPlatformDatasetsV1AlphaClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="MapsPlatformDatasetsV1AlphaClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="MapsPlatformDatasetsV1AlphaClient"/>.</returns>
        public static MapsPlatformDatasetsV1AlphaClient Create() => new MapsPlatformDatasetsV1AlphaClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="MapsPlatformDatasetsV1AlphaClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="MapsPlatformDatasetsV1AlphaSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="MapsPlatformDatasetsV1AlphaClient"/>.</returns>
        internal static MapsPlatformDatasetsV1AlphaClient Create(grpccore::CallInvoker callInvoker, MapsPlatformDatasetsV1AlphaSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            MapsPlatformDatasetsV1Alpha.MapsPlatformDatasetsV1AlphaClient grpcClient = new MapsPlatformDatasetsV1Alpha.MapsPlatformDatasetsV1AlphaClient(callInvoker);
            return new MapsPlatformDatasetsV1AlphaClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC MapsPlatformDatasetsV1Alpha client</summary>
        public virtual MapsPlatformDatasetsV1Alpha.MapsPlatformDatasetsV1AlphaClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new dataset for the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dataset CreateDataset(CreateDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new dataset for the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> CreateDatasetAsync(CreateDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new dataset for the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> CreateDatasetAsync(CreateDatasetRequest request, st::CancellationToken cancellationToken) =>
            CreateDatasetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new dataset for the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent project that will own the dataset.
        /// Format: projects/{$project_number}
        /// </param>
        /// <param name="dataset">
        /// Required. The dataset version to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dataset CreateDataset(string parent, Dataset dataset, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataset(new CreateDatasetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Dataset = gax::GaxPreconditions.CheckNotNull(dataset, nameof(dataset)),
            }, callSettings);

        /// <summary>
        /// Create a new dataset for the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent project that will own the dataset.
        /// Format: projects/{$project_number}
        /// </param>
        /// <param name="dataset">
        /// Required. The dataset version to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> CreateDatasetAsync(string parent, Dataset dataset, gaxgrpc::CallSettings callSettings = null) =>
            CreateDatasetAsync(new CreateDatasetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Dataset = gax::GaxPreconditions.CheckNotNull(dataset, nameof(dataset)),
            }, callSettings);

        /// <summary>
        /// Create a new dataset for the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent project that will own the dataset.
        /// Format: projects/{$project_number}
        /// </param>
        /// <param name="dataset">
        /// Required. The dataset version to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> CreateDatasetAsync(string parent, Dataset dataset, st::CancellationToken cancellationToken) =>
            CreateDatasetAsync(parent, dataset, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new dataset for the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent project that will own the dataset.
        /// Format: projects/{$project_number}
        /// </param>
        /// <param name="dataset">
        /// Required. The dataset version to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dataset CreateDataset(gagr::ProjectName parent, Dataset dataset, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataset(new CreateDatasetRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Dataset = gax::GaxPreconditions.CheckNotNull(dataset, nameof(dataset)),
            }, callSettings);

        /// <summary>
        /// Create a new dataset for the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent project that will own the dataset.
        /// Format: projects/{$project_number}
        /// </param>
        /// <param name="dataset">
        /// Required. The dataset version to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> CreateDatasetAsync(gagr::ProjectName parent, Dataset dataset, gaxgrpc::CallSettings callSettings = null) =>
            CreateDatasetAsync(new CreateDatasetRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Dataset = gax::GaxPreconditions.CheckNotNull(dataset, nameof(dataset)),
            }, callSettings);

        /// <summary>
        /// Create a new dataset for the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent project that will own the dataset.
        /// Format: projects/{$project_number}
        /// </param>
        /// <param name="dataset">
        /// Required. The dataset version to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> CreateDatasetAsync(gagr::ProjectName parent, Dataset dataset, st::CancellationToken cancellationToken) =>
            CreateDatasetAsync(parent, dataset, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update the metadata for the dataset. To update the data use: UploadDataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dataset UpdateDatasetMetadata(UpdateDatasetMetadataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update the metadata for the dataset. To update the data use: UploadDataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> UpdateDatasetMetadataAsync(UpdateDatasetMetadataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update the metadata for the dataset. To update the data use: UploadDataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> UpdateDatasetMetadataAsync(UpdateDatasetMetadataRequest request, st::CancellationToken cancellationToken) =>
            UpdateDatasetMetadataAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update the metadata for the dataset. To update the data use: UploadDataset.
        /// </summary>
        /// <param name="dataset">
        /// Required. The dataset to update. The dataset's name is used to identify the dataset
        /// to be updated. The name has the format:
        /// projects/{project}/datasets/{dataset_id}
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated. Support the value "*" for full
        /// replacement.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dataset UpdateDatasetMetadata(Dataset dataset, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDatasetMetadata(new UpdateDatasetMetadataRequest
            {
                Dataset = gax::GaxPreconditions.CheckNotNull(dataset, nameof(dataset)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update the metadata for the dataset. To update the data use: UploadDataset.
        /// </summary>
        /// <param name="dataset">
        /// Required. The dataset to update. The dataset's name is used to identify the dataset
        /// to be updated. The name has the format:
        /// projects/{project}/datasets/{dataset_id}
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated. Support the value "*" for full
        /// replacement.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> UpdateDatasetMetadataAsync(Dataset dataset, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDatasetMetadataAsync(new UpdateDatasetMetadataRequest
            {
                Dataset = gax::GaxPreconditions.CheckNotNull(dataset, nameof(dataset)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update the metadata for the dataset. To update the data use: UploadDataset.
        /// </summary>
        /// <param name="dataset">
        /// Required. The dataset to update. The dataset's name is used to identify the dataset
        /// to be updated. The name has the format:
        /// projects/{project}/datasets/{dataset_id}
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated. Support the value "*" for full
        /// replacement.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> UpdateDatasetMetadataAsync(Dataset dataset, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDatasetMetadataAsync(dataset, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the published or latest version of the dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dataset GetDataset(GetDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get the published or latest version of the dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> GetDatasetAsync(GetDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get the published or latest version of the dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> GetDatasetAsync(GetDatasetRequest request, st::CancellationToken cancellationToken) =>
            GetDatasetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the published or latest version of the dataset.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name. Can also fetch a specified version
        /// projects/{project}/datasets/{dataset_id}
        /// projects/{project}/datasets/{dataset_id}@{version-id}
        /// 
        /// In order to retrieve a previous version of the dataset, also provide
        /// the version ID.
        /// Example: projects/123/datasets/assisted-driving-preferences@c7cfa2a8
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dataset GetDataset(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataset(new GetDatasetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the published or latest version of the dataset.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name. Can also fetch a specified version
        /// projects/{project}/datasets/{dataset_id}
        /// projects/{project}/datasets/{dataset_id}@{version-id}
        /// 
        /// In order to retrieve a previous version of the dataset, also provide
        /// the version ID.
        /// Example: projects/123/datasets/assisted-driving-preferences@c7cfa2a8
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> GetDatasetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDatasetAsync(new GetDatasetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the published or latest version of the dataset.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name. Can also fetch a specified version
        /// projects/{project}/datasets/{dataset_id}
        /// projects/{project}/datasets/{dataset_id}@{version-id}
        /// 
        /// In order to retrieve a previous version of the dataset, also provide
        /// the version ID.
        /// Example: projects/123/datasets/assisted-driving-preferences@c7cfa2a8
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> GetDatasetAsync(string name, st::CancellationToken cancellationToken) =>
            GetDatasetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the published or latest version of the dataset.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name. Can also fetch a specified version
        /// projects/{project}/datasets/{dataset_id}
        /// projects/{project}/datasets/{dataset_id}@{version-id}
        /// 
        /// In order to retrieve a previous version of the dataset, also provide
        /// the version ID.
        /// Example: projects/123/datasets/assisted-driving-preferences@c7cfa2a8
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dataset GetDataset(DatasetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataset(new GetDatasetRequest
            {
                DatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the published or latest version of the dataset.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name. Can also fetch a specified version
        /// projects/{project}/datasets/{dataset_id}
        /// projects/{project}/datasets/{dataset_id}@{version-id}
        /// 
        /// In order to retrieve a previous version of the dataset, also provide
        /// the version ID.
        /// Example: projects/123/datasets/assisted-driving-preferences@c7cfa2a8
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> GetDatasetAsync(DatasetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDatasetAsync(new GetDatasetRequest
            {
                DatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the published or latest version of the dataset.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name. Can also fetch a specified version
        /// projects/{project}/datasets/{dataset_id}
        /// projects/{project}/datasets/{dataset_id}@{version-id}
        /// 
        /// In order to retrieve a previous version of the dataset, also provide
        /// the version ID.
        /// Example: projects/123/datasets/assisted-driving-preferences@c7cfa2a8
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> GetDatasetAsync(DatasetName name, st::CancellationToken cancellationToken) =>
            GetDatasetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List all the versions of a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Dataset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDatasetVersionsResponse, Dataset> ListDatasetVersions(ListDatasetVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all the versions of a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Dataset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDatasetVersionsResponse, Dataset> ListDatasetVersionsAsync(ListDatasetVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all the versions of a dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the dataset to list all the versions for.
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
        public virtual gax::PagedEnumerable<ListDatasetVersionsResponse, Dataset> ListDatasetVersions(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDatasetVersions(new ListDatasetVersionsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List all the versions of a dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the dataset to list all the versions for.
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
        public virtual gax::PagedAsyncEnumerable<ListDatasetVersionsResponse, Dataset> ListDatasetVersionsAsync(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDatasetVersionsAsync(new ListDatasetVersionsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List all the versions of a dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the dataset to list all the versions for.
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
        public virtual gax::PagedEnumerable<ListDatasetVersionsResponse, Dataset> ListDatasetVersions(DatasetName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDatasetVersions(new ListDatasetVersionsRequest
            {
                DatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List all the versions of a dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the dataset to list all the versions for.
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
        public virtual gax::PagedAsyncEnumerable<ListDatasetVersionsResponse, Dataset> ListDatasetVersionsAsync(DatasetName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDatasetVersionsAsync(new ListDatasetVersionsRequest
            {
                DatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List all the datasets for the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Dataset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDatasetsResponse, Dataset> ListDatasets(ListDatasetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all the datasets for the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Dataset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDatasetsResponse, Dataset> ListDatasetsAsync(ListDatasetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all the datasets for the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project to list all the datasets for.
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
        /// List all the datasets for the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project to list all the datasets for.
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
        /// List all the datasets for the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project to list all the datasets for.
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
        public virtual gax::PagedEnumerable<ListDatasetsResponse, Dataset> ListDatasets(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDatasets(new ListDatasetsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List all the datasets for the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project to list all the datasets for.
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
        public virtual gax::PagedAsyncEnumerable<ListDatasetsResponse, Dataset> ListDatasetsAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDatasetsAsync(new ListDatasetsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Delete the specified dataset and optionally all its corresponding
        /// versions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDataset(DeleteDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete the specified dataset and optionally all its corresponding
        /// versions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDatasetAsync(DeleteDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete the specified dataset and optionally all its corresponding
        /// versions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDatasetAsync(DeleteDatasetRequest request, st::CancellationToken cancellationToken) =>
            DeleteDatasetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete the specified dataset and optionally all its corresponding
        /// versions.
        /// </summary>
        /// <param name="name">
        /// Required. Format: projects/${project}/datasets/{dataset_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDataset(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataset(new DeleteDatasetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete the specified dataset and optionally all its corresponding
        /// versions.
        /// </summary>
        /// <param name="name">
        /// Required. Format: projects/${project}/datasets/{dataset_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDatasetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDatasetAsync(new DeleteDatasetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete the specified dataset and optionally all its corresponding
        /// versions.
        /// </summary>
        /// <param name="name">
        /// Required. Format: projects/${project}/datasets/{dataset_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDatasetAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDatasetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete the specified dataset and optionally all its corresponding
        /// versions.
        /// </summary>
        /// <param name="name">
        /// Required. Format: projects/${project}/datasets/{dataset_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDataset(DatasetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataset(new DeleteDatasetRequest
            {
                DatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete the specified dataset and optionally all its corresponding
        /// versions.
        /// </summary>
        /// <param name="name">
        /// Required. Format: projects/${project}/datasets/{dataset_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDatasetAsync(DatasetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDatasetAsync(new DeleteDatasetRequest
            {
                DatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete the specified dataset and optionally all its corresponding
        /// versions.
        /// </summary>
        /// <param name="name">
        /// Required. Format: projects/${project}/datasets/{dataset_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDatasetAsync(DatasetName name, st::CancellationToken cancellationToken) =>
            DeleteDatasetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a specific version of the dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDatasetVersion(DeleteDatasetVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a specific version of the dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDatasetVersionAsync(DeleteDatasetVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a specific version of the dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDatasetVersionAsync(DeleteDatasetVersionRequest request, st::CancellationToken cancellationToken) =>
            DeleteDatasetVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a specific version of the dataset.
        /// </summary>
        /// <param name="name">
        /// Required. Format: projects/${project}/datasets/{dataset_id}@{version-id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDatasetVersion(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDatasetVersion(new DeleteDatasetVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a specific version of the dataset.
        /// </summary>
        /// <param name="name">
        /// Required. Format: projects/${project}/datasets/{dataset_id}@{version-id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDatasetVersionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDatasetVersionAsync(new DeleteDatasetVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a specific version of the dataset.
        /// </summary>
        /// <param name="name">
        /// Required. Format: projects/${project}/datasets/{dataset_id}@{version-id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDatasetVersionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDatasetVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a specific version of the dataset.
        /// </summary>
        /// <param name="name">
        /// Required. Format: projects/${project}/datasets/{dataset_id}@{version-id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDatasetVersion(DatasetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDatasetVersion(new DeleteDatasetVersionRequest
            {
                DatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a specific version of the dataset.
        /// </summary>
        /// <param name="name">
        /// Required. Format: projects/${project}/datasets/{dataset_id}@{version-id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDatasetVersionAsync(DatasetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDatasetVersionAsync(new DeleteDatasetVersionRequest
            {
                DatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a specific version of the dataset.
        /// </summary>
        /// <param name="name">
        /// Required. Format: projects/${project}/datasets/{dataset_id}@{version-id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDatasetVersionAsync(DatasetName name, st::CancellationToken cancellationToken) =>
            DeleteDatasetVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>MapsPlatformDatasetsV1Alpha client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service definition for the Maps Platform Datasets API.
    /// </remarks>
    public sealed partial class MapsPlatformDatasetsV1AlphaClientImpl : MapsPlatformDatasetsV1AlphaClient
    {
        private readonly gaxgrpc::ApiCall<CreateDatasetRequest, Dataset> _callCreateDataset;

        private readonly gaxgrpc::ApiCall<UpdateDatasetMetadataRequest, Dataset> _callUpdateDatasetMetadata;

        private readonly gaxgrpc::ApiCall<GetDatasetRequest, Dataset> _callGetDataset;

        private readonly gaxgrpc::ApiCall<ListDatasetVersionsRequest, ListDatasetVersionsResponse> _callListDatasetVersions;

        private readonly gaxgrpc::ApiCall<ListDatasetsRequest, ListDatasetsResponse> _callListDatasets;

        private readonly gaxgrpc::ApiCall<DeleteDatasetRequest, wkt::Empty> _callDeleteDataset;

        private readonly gaxgrpc::ApiCall<DeleteDatasetVersionRequest, wkt::Empty> _callDeleteDatasetVersion;

        /// <summary>
        /// Constructs a client wrapper for the MapsPlatformDatasetsV1Alpha service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="MapsPlatformDatasetsV1AlphaSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public MapsPlatformDatasetsV1AlphaClientImpl(MapsPlatformDatasetsV1Alpha.MapsPlatformDatasetsV1AlphaClient grpcClient, MapsPlatformDatasetsV1AlphaSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            MapsPlatformDatasetsV1AlphaSettings effectiveSettings = settings ?? MapsPlatformDatasetsV1AlphaSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            _callCreateDataset = clientHelper.BuildApiCall<CreateDatasetRequest, Dataset>("CreateDataset", grpcClient.CreateDatasetAsync, grpcClient.CreateDataset, effectiveSettings.CreateDatasetSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDataset);
            Modify_CreateDatasetApiCall(ref _callCreateDataset);
            _callUpdateDatasetMetadata = clientHelper.BuildApiCall<UpdateDatasetMetadataRequest, Dataset>("UpdateDatasetMetadata", grpcClient.UpdateDatasetMetadataAsync, grpcClient.UpdateDatasetMetadata, effectiveSettings.UpdateDatasetMetadataSettings).WithGoogleRequestParam("dataset.name", request => request.Dataset?.Name);
            Modify_ApiCall(ref _callUpdateDatasetMetadata);
            Modify_UpdateDatasetMetadataApiCall(ref _callUpdateDatasetMetadata);
            _callGetDataset = clientHelper.BuildApiCall<GetDatasetRequest, Dataset>("GetDataset", grpcClient.GetDatasetAsync, grpcClient.GetDataset, effectiveSettings.GetDatasetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDataset);
            Modify_GetDatasetApiCall(ref _callGetDataset);
            _callListDatasetVersions = clientHelper.BuildApiCall<ListDatasetVersionsRequest, ListDatasetVersionsResponse>("ListDatasetVersions", grpcClient.ListDatasetVersionsAsync, grpcClient.ListDatasetVersions, effectiveSettings.ListDatasetVersionsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callListDatasetVersions);
            Modify_ListDatasetVersionsApiCall(ref _callListDatasetVersions);
            _callListDatasets = clientHelper.BuildApiCall<ListDatasetsRequest, ListDatasetsResponse>("ListDatasets", grpcClient.ListDatasetsAsync, grpcClient.ListDatasets, effectiveSettings.ListDatasetsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDatasets);
            Modify_ListDatasetsApiCall(ref _callListDatasets);
            _callDeleteDataset = clientHelper.BuildApiCall<DeleteDatasetRequest, wkt::Empty>("DeleteDataset", grpcClient.DeleteDatasetAsync, grpcClient.DeleteDataset, effectiveSettings.DeleteDatasetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDataset);
            Modify_DeleteDatasetApiCall(ref _callDeleteDataset);
            _callDeleteDatasetVersion = clientHelper.BuildApiCall<DeleteDatasetVersionRequest, wkt::Empty>("DeleteDatasetVersion", grpcClient.DeleteDatasetVersionAsync, grpcClient.DeleteDatasetVersion, effectiveSettings.DeleteDatasetVersionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDatasetVersion);
            Modify_DeleteDatasetVersionApiCall(ref _callDeleteDatasetVersion);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateDatasetApiCall(ref gaxgrpc::ApiCall<CreateDatasetRequest, Dataset> call);

        partial void Modify_UpdateDatasetMetadataApiCall(ref gaxgrpc::ApiCall<UpdateDatasetMetadataRequest, Dataset> call);

        partial void Modify_GetDatasetApiCall(ref gaxgrpc::ApiCall<GetDatasetRequest, Dataset> call);

        partial void Modify_ListDatasetVersionsApiCall(ref gaxgrpc::ApiCall<ListDatasetVersionsRequest, ListDatasetVersionsResponse> call);

        partial void Modify_ListDatasetsApiCall(ref gaxgrpc::ApiCall<ListDatasetsRequest, ListDatasetsResponse> call);

        partial void Modify_DeleteDatasetApiCall(ref gaxgrpc::ApiCall<DeleteDatasetRequest, wkt::Empty> call);

        partial void Modify_DeleteDatasetVersionApiCall(ref gaxgrpc::ApiCall<DeleteDatasetVersionRequest, wkt::Empty> call);

        partial void OnConstruction(MapsPlatformDatasetsV1Alpha.MapsPlatformDatasetsV1AlphaClient grpcClient, MapsPlatformDatasetsV1AlphaSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC MapsPlatformDatasetsV1Alpha client</summary>
        public override MapsPlatformDatasetsV1Alpha.MapsPlatformDatasetsV1AlphaClient GrpcClient { get; }

        partial void Modify_CreateDatasetRequest(ref CreateDatasetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDatasetMetadataRequest(ref UpdateDatasetMetadataRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDatasetRequest(ref GetDatasetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDatasetVersionsRequest(ref ListDatasetVersionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDatasetsRequest(ref ListDatasetsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDatasetRequest(ref DeleteDatasetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDatasetVersionRequest(ref DeleteDatasetVersionRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Create a new dataset for the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Dataset CreateDataset(CreateDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDatasetRequest(ref request, ref callSettings);
            return _callCreateDataset.Sync(request, callSettings);
        }

        /// <summary>
        /// Create a new dataset for the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Dataset> CreateDatasetAsync(CreateDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDatasetRequest(ref request, ref callSettings);
            return _callCreateDataset.Async(request, callSettings);
        }

        /// <summary>
        /// Update the metadata for the dataset. To update the data use: UploadDataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Dataset UpdateDatasetMetadata(UpdateDatasetMetadataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDatasetMetadataRequest(ref request, ref callSettings);
            return _callUpdateDatasetMetadata.Sync(request, callSettings);
        }

        /// <summary>
        /// Update the metadata for the dataset. To update the data use: UploadDataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Dataset> UpdateDatasetMetadataAsync(UpdateDatasetMetadataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDatasetMetadataRequest(ref request, ref callSettings);
            return _callUpdateDatasetMetadata.Async(request, callSettings);
        }

        /// <summary>
        /// Get the published or latest version of the dataset.
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
        /// Get the published or latest version of the dataset.
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
        /// List all the versions of a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Dataset"/> resources.</returns>
        public override gax::PagedEnumerable<ListDatasetVersionsResponse, Dataset> ListDatasetVersions(ListDatasetVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDatasetVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDatasetVersionsRequest, ListDatasetVersionsResponse, Dataset>(_callListDatasetVersions, request, callSettings);
        }

        /// <summary>
        /// List all the versions of a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Dataset"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDatasetVersionsResponse, Dataset> ListDatasetVersionsAsync(ListDatasetVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDatasetVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDatasetVersionsRequest, ListDatasetVersionsResponse, Dataset>(_callListDatasetVersions, request, callSettings);
        }

        /// <summary>
        /// List all the datasets for the specified project.
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
        /// List all the datasets for the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Dataset"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDatasetsResponse, Dataset> ListDatasetsAsync(ListDatasetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDatasetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDatasetsRequest, ListDatasetsResponse, Dataset>(_callListDatasets, request, callSettings);
        }

        /// <summary>
        /// Delete the specified dataset and optionally all its corresponding
        /// versions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteDataset(DeleteDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDatasetRequest(ref request, ref callSettings);
            _callDeleteDataset.Sync(request, callSettings);
        }

        /// <summary>
        /// Delete the specified dataset and optionally all its corresponding
        /// versions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteDatasetAsync(DeleteDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDatasetRequest(ref request, ref callSettings);
            return _callDeleteDataset.Async(request, callSettings);
        }

        /// <summary>
        /// Delete a specific version of the dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteDatasetVersion(DeleteDatasetVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDatasetVersionRequest(ref request, ref callSettings);
            _callDeleteDatasetVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Delete a specific version of the dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteDatasetVersionAsync(DeleteDatasetVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDatasetVersionRequest(ref request, ref callSettings);
            return _callDeleteDatasetVersion.Async(request, callSettings);
        }
    }

    public partial class ListDatasetVersionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDatasetsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDatasetVersionsResponse : gaxgrpc::IPageResponse<Dataset>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Dataset> GetEnumerator() => Datasets.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDatasetsResponse : gaxgrpc::IPageResponse<Dataset>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Dataset> GetEnumerator() => Datasets.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
