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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
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
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Maps.MapsPlatformDatasets.V1
{
    /// <summary>Settings for <see cref="MapsPlatformDatasetsClient"/> instances.</summary>
    public sealed partial class MapsPlatformDatasetsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="MapsPlatformDatasetsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="MapsPlatformDatasetsSettings"/>.</returns>
        public static MapsPlatformDatasetsSettings GetDefault() => new MapsPlatformDatasetsSettings();

        /// <summary>Constructs a new <see cref="MapsPlatformDatasetsSettings"/> object with default settings.</summary>
        public MapsPlatformDatasetsSettings()
        {
        }

        private MapsPlatformDatasetsSettings(MapsPlatformDatasetsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateDatasetSettings = existing.CreateDatasetSettings;
            UpdateDatasetMetadataSettings = existing.UpdateDatasetMetadataSettings;
            GetDatasetSettings = existing.GetDatasetSettings;
            FetchDatasetErrorsSettings = existing.FetchDatasetErrorsSettings;
            ListDatasetsSettings = existing.ListDatasetsSettings;
            DeleteDatasetSettings = existing.DeleteDatasetSettings;
            OnCopy(existing);
        }

        partial void OnCopy(MapsPlatformDatasetsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MapsPlatformDatasetsClient.CreateDataset</c> and <c>MapsPlatformDatasetsClient.CreateDatasetAsync</c>.
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
        /// <c>MapsPlatformDatasetsClient.UpdateDatasetMetadata</c> and
        /// <c>MapsPlatformDatasetsClient.UpdateDatasetMetadataAsync</c>.
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
        /// <c>MapsPlatformDatasetsClient.GetDataset</c> and <c>MapsPlatformDatasetsClient.GetDatasetAsync</c>.
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
        /// <c>MapsPlatformDatasetsClient.FetchDatasetErrors</c> and
        /// <c>MapsPlatformDatasetsClient.FetchDatasetErrorsAsync</c>.
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
        public gaxgrpc::CallSettings FetchDatasetErrorsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MapsPlatformDatasetsClient.ListDatasets</c> and <c>MapsPlatformDatasetsClient.ListDatasetsAsync</c>.
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
        /// <c>MapsPlatformDatasetsClient.DeleteDataset</c> and <c>MapsPlatformDatasetsClient.DeleteDatasetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDatasetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="MapsPlatformDatasetsSettings"/> object.</returns>
        public MapsPlatformDatasetsSettings Clone() => new MapsPlatformDatasetsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="MapsPlatformDatasetsClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class MapsPlatformDatasetsClientBuilder : gaxgrpc::ClientBuilderBase<MapsPlatformDatasetsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public MapsPlatformDatasetsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public MapsPlatformDatasetsClientBuilder() : base(MapsPlatformDatasetsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref MapsPlatformDatasetsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<MapsPlatformDatasetsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override MapsPlatformDatasetsClient Build()
        {
            MapsPlatformDatasetsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<MapsPlatformDatasetsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<MapsPlatformDatasetsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private MapsPlatformDatasetsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return MapsPlatformDatasetsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<MapsPlatformDatasetsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return MapsPlatformDatasetsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => MapsPlatformDatasetsClient.ChannelPool;
    }

    /// <summary>MapsPlatformDatasets client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service definition for the Maps Platform Datasets API.
    /// </remarks>
    public abstract partial class MapsPlatformDatasetsClient
    {
        /// <summary>
        /// The default endpoint for the MapsPlatformDatasets service, which is a host of
        /// "mapsplatformdatasets.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "mapsplatformdatasets.googleapis.com:443";

        /// <summary>The default MapsPlatformDatasets scopes.</summary>
        /// <remarks>
        /// The default MapsPlatformDatasets scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(MapsPlatformDatasets.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="MapsPlatformDatasetsClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="MapsPlatformDatasetsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="MapsPlatformDatasetsClient"/>.</returns>
        public static stt::Task<MapsPlatformDatasetsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new MapsPlatformDatasetsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="MapsPlatformDatasetsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="MapsPlatformDatasetsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="MapsPlatformDatasetsClient"/>.</returns>
        public static MapsPlatformDatasetsClient Create() => new MapsPlatformDatasetsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="MapsPlatformDatasetsClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="MapsPlatformDatasetsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="MapsPlatformDatasetsClient"/>.</returns>
        internal static MapsPlatformDatasetsClient Create(grpccore::CallInvoker callInvoker, MapsPlatformDatasetsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            MapsPlatformDatasets.MapsPlatformDatasetsClient grpcClient = new MapsPlatformDatasets.MapsPlatformDatasetsClient(callInvoker);
            return new MapsPlatformDatasetsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC MapsPlatformDatasets client</summary>
        public virtual MapsPlatformDatasets.MapsPlatformDatasetsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new dataset for the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dataset CreateDataset(CreateDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new dataset for the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> CreateDatasetAsync(CreateDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new dataset for the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> CreateDatasetAsync(CreateDatasetRequest request, st::CancellationToken cancellationToken) =>
            CreateDatasetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new dataset for the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent project that will own the dataset.
        /// Format: projects/{project}
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
        /// Creates a new dataset for the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent project that will own the dataset.
        /// Format: projects/{project}
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
        /// Creates a new dataset for the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent project that will own the dataset.
        /// Format: projects/{project}
        /// </param>
        /// <param name="dataset">
        /// Required. The dataset version to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> CreateDatasetAsync(string parent, Dataset dataset, st::CancellationToken cancellationToken) =>
            CreateDatasetAsync(parent, dataset, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new dataset for the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent project that will own the dataset.
        /// Format: projects/{project}
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
        /// Creates a new dataset for the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent project that will own the dataset.
        /// Format: projects/{project}
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
        /// Creates a new dataset for the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent project that will own the dataset.
        /// Format: projects/{project}
        /// </param>
        /// <param name="dataset">
        /// Required. The dataset version to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> CreateDatasetAsync(gagr::ProjectName parent, Dataset dataset, st::CancellationToken cancellationToken) =>
            CreateDatasetAsync(parent, dataset, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the metadata for the dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dataset UpdateDatasetMetadata(UpdateDatasetMetadataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the metadata for the dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> UpdateDatasetMetadataAsync(UpdateDatasetMetadataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the metadata for the dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> UpdateDatasetMetadataAsync(UpdateDatasetMetadataRequest request, st::CancellationToken cancellationToken) =>
            UpdateDatasetMetadataAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the metadata for the dataset.
        /// </summary>
        /// <param name="dataset">
        /// Required. Resource name of the dataset to update.
        /// Format: projects/{project}/datasets/{dataset_id}
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// 
        /// The value "*" is used for full replacement (default).
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
        /// Updates the metadata for the dataset.
        /// </summary>
        /// <param name="dataset">
        /// Required. Resource name of the dataset to update.
        /// Format: projects/{project}/datasets/{dataset_id}
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// 
        /// The value "*" is used for full replacement (default).
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
        /// Updates the metadata for the dataset.
        /// </summary>
        /// <param name="dataset">
        /// Required. Resource name of the dataset to update.
        /// Format: projects/{project}/datasets/{dataset_id}
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// 
        /// The value "*" is used for full replacement (default).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> UpdateDatasetMetadataAsync(Dataset dataset, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDatasetMetadataAsync(dataset, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dataset GetDataset(GetDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> GetDatasetAsync(GetDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> GetDatasetAsync(GetDatasetRequest request, st::CancellationToken cancellationToken) =>
            GetDatasetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the dataset.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name.
        /// Format: projects/{project}/datasets/{dataset_id}
        /// 
        /// 
        /// Can also fetch some special versions by appending "@" and a tag.
        /// Format: projects/{project}/datasets/{dataset_id}@{tag}
        /// 
        /// Tag "active": The info of the latest completed version will be included,
        /// and NOT_FOUND if the dataset does not have one.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dataset GetDataset(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataset(new GetDatasetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the dataset.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name.
        /// Format: projects/{project}/datasets/{dataset_id}
        /// 
        /// 
        /// Can also fetch some special versions by appending "@" and a tag.
        /// Format: projects/{project}/datasets/{dataset_id}@{tag}
        /// 
        /// Tag "active": The info of the latest completed version will be included,
        /// and NOT_FOUND if the dataset does not have one.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> GetDatasetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDatasetAsync(new GetDatasetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the dataset.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name.
        /// Format: projects/{project}/datasets/{dataset_id}
        /// 
        /// 
        /// Can also fetch some special versions by appending "@" and a tag.
        /// Format: projects/{project}/datasets/{dataset_id}@{tag}
        /// 
        /// Tag "active": The info of the latest completed version will be included,
        /// and NOT_FOUND if the dataset does not have one.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> GetDatasetAsync(string name, st::CancellationToken cancellationToken) =>
            GetDatasetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the dataset.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name.
        /// Format: projects/{project}/datasets/{dataset_id}
        /// 
        /// 
        /// Can also fetch some special versions by appending "@" and a tag.
        /// Format: projects/{project}/datasets/{dataset_id}@{tag}
        /// 
        /// Tag "active": The info of the latest completed version will be included,
        /// and NOT_FOUND if the dataset does not have one.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dataset GetDataset(DatasetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataset(new GetDatasetRequest
            {
                DatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the dataset.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name.
        /// Format: projects/{project}/datasets/{dataset_id}
        /// 
        /// 
        /// Can also fetch some special versions by appending "@" and a tag.
        /// Format: projects/{project}/datasets/{dataset_id}@{tag}
        /// 
        /// Tag "active": The info of the latest completed version will be included,
        /// and NOT_FOUND if the dataset does not have one.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> GetDatasetAsync(DatasetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDatasetAsync(new GetDatasetRequest
            {
                DatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the dataset.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name.
        /// Format: projects/{project}/datasets/{dataset_id}
        /// 
        /// 
        /// Can also fetch some special versions by appending "@" and a tag.
        /// Format: projects/{project}/datasets/{dataset_id}@{tag}
        /// 
        /// Tag "active": The info of the latest completed version will be included,
        /// and NOT_FOUND if the dataset does not have one.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> GetDatasetAsync(DatasetName name, st::CancellationToken cancellationToken) =>
            GetDatasetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets all the errors of a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="gr::Status"/> resources.</returns>
        public virtual gax::PagedEnumerable<FetchDatasetErrorsResponse, gr::Status> FetchDatasetErrors(FetchDatasetErrorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets all the errors of a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="gr::Status"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<FetchDatasetErrorsResponse, gr::Status> FetchDatasetErrorsAsync(FetchDatasetErrorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets all the errors of a dataset.
        /// </summary>
        /// <param name="dataset">
        /// Required. The name of the dataset to list all the errors for.
        /// Format: projects/{project}/datasets/{dataset_id}
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
        /// <returns>A pageable sequence of <see cref="gr::Status"/> resources.</returns>
        public virtual gax::PagedEnumerable<FetchDatasetErrorsResponse, gr::Status> FetchDatasetErrors(string dataset, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            FetchDatasetErrors(new FetchDatasetErrorsRequest
            {
                Dataset = gax::GaxPreconditions.CheckNotNullOrEmpty(dataset, nameof(dataset)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets all the errors of a dataset.
        /// </summary>
        /// <param name="dataset">
        /// Required. The name of the dataset to list all the errors for.
        /// Format: projects/{project}/datasets/{dataset_id}
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
        /// <returns>A pageable asynchronous sequence of <see cref="gr::Status"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<FetchDatasetErrorsResponse, gr::Status> FetchDatasetErrorsAsync(string dataset, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            FetchDatasetErrorsAsync(new FetchDatasetErrorsRequest
            {
                Dataset = gax::GaxPreconditions.CheckNotNullOrEmpty(dataset, nameof(dataset)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets all the errors of a dataset.
        /// </summary>
        /// <param name="dataset">
        /// Required. The name of the dataset to list all the errors for.
        /// Format: projects/{project}/datasets/{dataset_id}
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
        /// <returns>A pageable sequence of <see cref="gr::Status"/> resources.</returns>
        public virtual gax::PagedEnumerable<FetchDatasetErrorsResponse, gr::Status> FetchDatasetErrors(DatasetName dataset, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            FetchDatasetErrors(new FetchDatasetErrorsRequest
            {
                DatasetAsDatasetName = gax::GaxPreconditions.CheckNotNull(dataset, nameof(dataset)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets all the errors of a dataset.
        /// </summary>
        /// <param name="dataset">
        /// Required. The name of the dataset to list all the errors for.
        /// Format: projects/{project}/datasets/{dataset_id}
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
        /// <returns>A pageable asynchronous sequence of <see cref="gr::Status"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<FetchDatasetErrorsResponse, gr::Status> FetchDatasetErrorsAsync(DatasetName dataset, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            FetchDatasetErrorsAsync(new FetchDatasetErrorsRequest
            {
                DatasetAsDatasetName = gax::GaxPreconditions.CheckNotNull(dataset, nameof(dataset)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all the datasets for the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Dataset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDatasetsResponse, Dataset> ListDatasets(ListDatasetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the datasets for the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Dataset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDatasetsResponse, Dataset> ListDatasetsAsync(ListDatasetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the datasets for the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project to list all the datasets for.
        /// Format: projects/{project}
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
        /// Lists all the datasets for the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project to list all the datasets for.
        /// Format: projects/{project}
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
        /// Lists all the datasets for the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project to list all the datasets for.
        /// Format: projects/{project}
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
        /// Lists all the datasets for the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project to list all the datasets for.
        /// Format: projects/{project}
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
        /// Deletes the specified dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDataset(DeleteDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDatasetAsync(DeleteDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDatasetAsync(DeleteDatasetRequest request, st::CancellationToken cancellationToken) =>
            DeleteDatasetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the dataset to delete.
        /// Format: projects/{project}/datasets/{dataset_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDataset(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataset(new DeleteDatasetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the dataset to delete.
        /// Format: projects/{project}/datasets/{dataset_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDatasetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDatasetAsync(new DeleteDatasetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the dataset to delete.
        /// Format: projects/{project}/datasets/{dataset_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDatasetAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDatasetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the dataset to delete.
        /// Format: projects/{project}/datasets/{dataset_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDataset(DatasetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataset(new DeleteDatasetRequest
            {
                DatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the dataset to delete.
        /// Format: projects/{project}/datasets/{dataset_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDatasetAsync(DatasetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDatasetAsync(new DeleteDatasetRequest
            {
                DatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the dataset to delete.
        /// Format: projects/{project}/datasets/{dataset_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDatasetAsync(DatasetName name, st::CancellationToken cancellationToken) =>
            DeleteDatasetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>MapsPlatformDatasets client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service definition for the Maps Platform Datasets API.
    /// </remarks>
    public sealed partial class MapsPlatformDatasetsClientImpl : MapsPlatformDatasetsClient
    {
        private readonly gaxgrpc::ApiCall<CreateDatasetRequest, Dataset> _callCreateDataset;

        private readonly gaxgrpc::ApiCall<UpdateDatasetMetadataRequest, Dataset> _callUpdateDatasetMetadata;

        private readonly gaxgrpc::ApiCall<GetDatasetRequest, Dataset> _callGetDataset;

        private readonly gaxgrpc::ApiCall<FetchDatasetErrorsRequest, FetchDatasetErrorsResponse> _callFetchDatasetErrors;

        private readonly gaxgrpc::ApiCall<ListDatasetsRequest, ListDatasetsResponse> _callListDatasets;

        private readonly gaxgrpc::ApiCall<DeleteDatasetRequest, wkt::Empty> _callDeleteDataset;

        /// <summary>
        /// Constructs a client wrapper for the MapsPlatformDatasets service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="MapsPlatformDatasetsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public MapsPlatformDatasetsClientImpl(MapsPlatformDatasets.MapsPlatformDatasetsClient grpcClient, MapsPlatformDatasetsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            MapsPlatformDatasetsSettings effectiveSettings = settings ?? MapsPlatformDatasetsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callCreateDataset = clientHelper.BuildApiCall<CreateDatasetRequest, Dataset>("CreateDataset", grpcClient.CreateDatasetAsync, grpcClient.CreateDataset, effectiveSettings.CreateDatasetSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDataset);
            Modify_CreateDatasetApiCall(ref _callCreateDataset);
            _callUpdateDatasetMetadata = clientHelper.BuildApiCall<UpdateDatasetMetadataRequest, Dataset>("UpdateDatasetMetadata", grpcClient.UpdateDatasetMetadataAsync, grpcClient.UpdateDatasetMetadata, effectiveSettings.UpdateDatasetMetadataSettings).WithGoogleRequestParam("dataset.name", request => request.Dataset?.Name);
            Modify_ApiCall(ref _callUpdateDatasetMetadata);
            Modify_UpdateDatasetMetadataApiCall(ref _callUpdateDatasetMetadata);
            _callGetDataset = clientHelper.BuildApiCall<GetDatasetRequest, Dataset>("GetDataset", grpcClient.GetDatasetAsync, grpcClient.GetDataset, effectiveSettings.GetDatasetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDataset);
            Modify_GetDatasetApiCall(ref _callGetDataset);
            _callFetchDatasetErrors = clientHelper.BuildApiCall<FetchDatasetErrorsRequest, FetchDatasetErrorsResponse>("FetchDatasetErrors", grpcClient.FetchDatasetErrorsAsync, grpcClient.FetchDatasetErrors, effectiveSettings.FetchDatasetErrorsSettings).WithGoogleRequestParam("dataset", request => request.Dataset);
            Modify_ApiCall(ref _callFetchDatasetErrors);
            Modify_FetchDatasetErrorsApiCall(ref _callFetchDatasetErrors);
            _callListDatasets = clientHelper.BuildApiCall<ListDatasetsRequest, ListDatasetsResponse>("ListDatasets", grpcClient.ListDatasetsAsync, grpcClient.ListDatasets, effectiveSettings.ListDatasetsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDatasets);
            Modify_ListDatasetsApiCall(ref _callListDatasets);
            _callDeleteDataset = clientHelper.BuildApiCall<DeleteDatasetRequest, wkt::Empty>("DeleteDataset", grpcClient.DeleteDatasetAsync, grpcClient.DeleteDataset, effectiveSettings.DeleteDatasetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDataset);
            Modify_DeleteDatasetApiCall(ref _callDeleteDataset);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateDatasetApiCall(ref gaxgrpc::ApiCall<CreateDatasetRequest, Dataset> call);

        partial void Modify_UpdateDatasetMetadataApiCall(ref gaxgrpc::ApiCall<UpdateDatasetMetadataRequest, Dataset> call);

        partial void Modify_GetDatasetApiCall(ref gaxgrpc::ApiCall<GetDatasetRequest, Dataset> call);

        partial void Modify_FetchDatasetErrorsApiCall(ref gaxgrpc::ApiCall<FetchDatasetErrorsRequest, FetchDatasetErrorsResponse> call);

        partial void Modify_ListDatasetsApiCall(ref gaxgrpc::ApiCall<ListDatasetsRequest, ListDatasetsResponse> call);

        partial void Modify_DeleteDatasetApiCall(ref gaxgrpc::ApiCall<DeleteDatasetRequest, wkt::Empty> call);

        partial void OnConstruction(MapsPlatformDatasets.MapsPlatformDatasetsClient grpcClient, MapsPlatformDatasetsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC MapsPlatformDatasets client</summary>
        public override MapsPlatformDatasets.MapsPlatformDatasetsClient GrpcClient { get; }

        partial void Modify_CreateDatasetRequest(ref CreateDatasetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDatasetMetadataRequest(ref UpdateDatasetMetadataRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDatasetRequest(ref GetDatasetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FetchDatasetErrorsRequest(ref FetchDatasetErrorsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDatasetsRequest(ref ListDatasetsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDatasetRequest(ref DeleteDatasetRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a new dataset for the specified project.
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
        /// Creates a new dataset for the specified project.
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
        /// Updates the metadata for the dataset.
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
        /// Updates the metadata for the dataset.
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
        /// Gets the dataset.
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
        /// Gets the dataset.
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
        /// Gets all the errors of a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="gr::Status"/> resources.</returns>
        public override gax::PagedEnumerable<FetchDatasetErrorsResponse, gr::Status> FetchDatasetErrors(FetchDatasetErrorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchDatasetErrorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<FetchDatasetErrorsRequest, FetchDatasetErrorsResponse, gr::Status>(_callFetchDatasetErrors, request, callSettings);
        }

        /// <summary>
        /// Gets all the errors of a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="gr::Status"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<FetchDatasetErrorsResponse, gr::Status> FetchDatasetErrorsAsync(FetchDatasetErrorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchDatasetErrorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<FetchDatasetErrorsRequest, FetchDatasetErrorsResponse, gr::Status>(_callFetchDatasetErrors, request, callSettings);
        }

        /// <summary>
        /// Lists all the datasets for the specified project.
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
        /// Lists all the datasets for the specified project.
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
        /// Deletes the specified dataset.
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
        /// Deletes the specified dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteDatasetAsync(DeleteDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDatasetRequest(ref request, ref callSettings);
            return _callDeleteDataset.Async(request, callSettings);
        }
    }

    public partial class FetchDatasetErrorsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDatasetsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class FetchDatasetErrorsResponse : gaxgrpc::IPageResponse<gr::Status>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<gr::Status> GetEnumerator() => Errors.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDatasetsResponse : gaxgrpc::IPageResponse<Dataset>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Dataset> GetEnumerator() => Datasets.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
