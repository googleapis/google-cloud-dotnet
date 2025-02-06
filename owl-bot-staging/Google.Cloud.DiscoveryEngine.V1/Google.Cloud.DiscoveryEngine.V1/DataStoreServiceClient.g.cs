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
    /// <summary>Settings for <see cref="DataStoreServiceClient"/> instances.</summary>
    public sealed partial class DataStoreServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DataStoreServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DataStoreServiceSettings"/>.</returns>
        public static DataStoreServiceSettings GetDefault() => new DataStoreServiceSettings();

        /// <summary>Constructs a new <see cref="DataStoreServiceSettings"/> object with default settings.</summary>
        public DataStoreServiceSettings()
        {
        }

        private DataStoreServiceSettings(DataStoreServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateDataStoreSettings = existing.CreateDataStoreSettings;
            CreateDataStoreOperationsSettings = existing.CreateDataStoreOperationsSettings.Clone();
            GetDataStoreSettings = existing.GetDataStoreSettings;
            ListDataStoresSettings = existing.ListDataStoresSettings;
            DeleteDataStoreSettings = existing.DeleteDataStoreSettings;
            DeleteDataStoreOperationsSettings = existing.DeleteDataStoreOperationsSettings.Clone();
            UpdateDataStoreSettings = existing.UpdateDataStoreSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DataStoreServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataStoreServiceClient.CreateDataStore</c> and <c>DataStoreServiceClient.CreateDataStoreAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDataStoreSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataStoreServiceClient.CreateDataStore</c> and
        /// <c>DataStoreServiceClient.CreateDataStoreAsync</c>.
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
        public lro::OperationsSettings CreateDataStoreOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataStoreServiceClient.GetDataStore</c> and <c>DataStoreServiceClient.GetDataStoreAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDataStoreSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataStoreServiceClient.ListDataStores</c> and <c>DataStoreServiceClient.ListDataStoresAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDataStoresSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataStoreServiceClient.DeleteDataStore</c> and <c>DataStoreServiceClient.DeleteDataStoreAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDataStoreSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataStoreServiceClient.DeleteDataStore</c> and
        /// <c>DataStoreServiceClient.DeleteDataStoreAsync</c>.
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
        public lro::OperationsSettings DeleteDataStoreOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataStoreServiceClient.UpdateDataStore</c> and <c>DataStoreServiceClient.UpdateDataStoreAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDataStoreSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DataStoreServiceSettings"/> object.</returns>
        public DataStoreServiceSettings Clone() => new DataStoreServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DataStoreServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class DataStoreServiceClientBuilder : gaxgrpc::ClientBuilderBase<DataStoreServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DataStoreServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DataStoreServiceClientBuilder() : base(DataStoreServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DataStoreServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DataStoreServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DataStoreServiceClient Build()
        {
            DataStoreServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DataStoreServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DataStoreServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DataStoreServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DataStoreServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DataStoreServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DataStoreServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DataStoreServiceClient.ChannelPool;
    }

    /// <summary>DataStoreService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [DataStore][google.cloud.discoveryengine.v1.DataStore]
    /// configuration.
    /// </remarks>
    public abstract partial class DataStoreServiceClient
    {
        /// <summary>
        /// The default endpoint for the DataStoreService service, which is a host of "discoveryengine.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "discoveryengine.googleapis.com:443";

        /// <summary>The default DataStoreService scopes.</summary>
        /// <remarks>
        /// The default DataStoreService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DataStoreService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DataStoreServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DataStoreServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DataStoreServiceClient"/>.</returns>
        public static stt::Task<DataStoreServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DataStoreServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DataStoreServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DataStoreServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DataStoreServiceClient"/>.</returns>
        public static DataStoreServiceClient Create() => new DataStoreServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DataStoreServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DataStoreServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DataStoreServiceClient"/>.</returns>
        internal static DataStoreServiceClient Create(grpccore::CallInvoker callInvoker, DataStoreServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DataStoreService.DataStoreServiceClient grpcClient = new DataStoreService.DataStoreServiceClient(callInvoker);
            return new DataStoreServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DataStoreService client</summary>
        public virtual DataStoreService.DataStoreServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [DataStore][google.cloud.discoveryengine.v1.DataStore].
        /// 
        /// DataStore is for storing
        /// [Documents][google.cloud.discoveryengine.v1.Document]. To serve these
        /// documents for Search, or Recommendation use case, an
        /// [Engine][google.cloud.discoveryengine.v1.Engine] needs to be created
        /// separately.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataStore, CreateDataStoreMetadata> CreateDataStore(CreateDataStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [DataStore][google.cloud.discoveryengine.v1.DataStore].
        /// 
        /// DataStore is for storing
        /// [Documents][google.cloud.discoveryengine.v1.Document]. To serve these
        /// documents for Search, or Recommendation use case, an
        /// [Engine][google.cloud.discoveryengine.v1.Engine] needs to be created
        /// separately.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataStore, CreateDataStoreMetadata>> CreateDataStoreAsync(CreateDataStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [DataStore][google.cloud.discoveryengine.v1.DataStore].
        /// 
        /// DataStore is for storing
        /// [Documents][google.cloud.discoveryengine.v1.Document]. To serve these
        /// documents for Search, or Recommendation use case, an
        /// [Engine][google.cloud.discoveryengine.v1.Engine] needs to be created
        /// separately.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataStore, CreateDataStoreMetadata>> CreateDataStoreAsync(CreateDataStoreRequest request, st::CancellationToken cancellationToken) =>
            CreateDataStoreAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateDataStore</c>.</summary>
        public virtual lro::OperationsClient CreateDataStoreOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateDataStore</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DataStore, CreateDataStoreMetadata> PollOnceCreateDataStore(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DataStore, CreateDataStoreMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDataStoreOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateDataStore</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DataStore, CreateDataStoreMetadata>> PollOnceCreateDataStoreAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DataStore, CreateDataStoreMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDataStoreOperationsClient, callSettings);

        /// <summary>
        /// Creates a [DataStore][google.cloud.discoveryengine.v1.DataStore].
        /// 
        /// DataStore is for storing
        /// [Documents][google.cloud.discoveryengine.v1.Document]. To serve these
        /// documents for Search, or Recommendation use case, an
        /// [Engine][google.cloud.discoveryengine.v1.Engine] needs to be created
        /// separately.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, such as
        /// `projects/{project}/locations/{location}/collections/{collection}`.
        /// </param>
        /// <param name="dataStore">
        /// Required. The [DataStore][google.cloud.discoveryengine.v1.DataStore] to
        /// create.
        /// </param>
        /// <param name="dataStoreId">
        /// Required. The ID to use for the
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore], which will become
        /// the final component of the
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore]'s resource name.
        /// 
        /// This field must conform to [RFC-1034](https://tools.ietf.org/html/rfc1034)
        /// standard with a length limit of 63 characters. Otherwise, an
        /// INVALID_ARGUMENT error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataStore, CreateDataStoreMetadata> CreateDataStore(string parent, DataStore dataStore, string dataStoreId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataStore(new CreateDataStoreRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DataStore = gax::GaxPreconditions.CheckNotNull(dataStore, nameof(dataStore)),
                DataStoreId = gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)),
            }, callSettings);

        /// <summary>
        /// Creates a [DataStore][google.cloud.discoveryengine.v1.DataStore].
        /// 
        /// DataStore is for storing
        /// [Documents][google.cloud.discoveryengine.v1.Document]. To serve these
        /// documents for Search, or Recommendation use case, an
        /// [Engine][google.cloud.discoveryengine.v1.Engine] needs to be created
        /// separately.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, such as
        /// `projects/{project}/locations/{location}/collections/{collection}`.
        /// </param>
        /// <param name="dataStore">
        /// Required. The [DataStore][google.cloud.discoveryengine.v1.DataStore] to
        /// create.
        /// </param>
        /// <param name="dataStoreId">
        /// Required. The ID to use for the
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore], which will become
        /// the final component of the
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore]'s resource name.
        /// 
        /// This field must conform to [RFC-1034](https://tools.ietf.org/html/rfc1034)
        /// standard with a length limit of 63 characters. Otherwise, an
        /// INVALID_ARGUMENT error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataStore, CreateDataStoreMetadata>> CreateDataStoreAsync(string parent, DataStore dataStore, string dataStoreId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataStoreAsync(new CreateDataStoreRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DataStore = gax::GaxPreconditions.CheckNotNull(dataStore, nameof(dataStore)),
                DataStoreId = gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)),
            }, callSettings);

        /// <summary>
        /// Creates a [DataStore][google.cloud.discoveryengine.v1.DataStore].
        /// 
        /// DataStore is for storing
        /// [Documents][google.cloud.discoveryengine.v1.Document]. To serve these
        /// documents for Search, or Recommendation use case, an
        /// [Engine][google.cloud.discoveryengine.v1.Engine] needs to be created
        /// separately.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, such as
        /// `projects/{project}/locations/{location}/collections/{collection}`.
        /// </param>
        /// <param name="dataStore">
        /// Required. The [DataStore][google.cloud.discoveryengine.v1.DataStore] to
        /// create.
        /// </param>
        /// <param name="dataStoreId">
        /// Required. The ID to use for the
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore], which will become
        /// the final component of the
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore]'s resource name.
        /// 
        /// This field must conform to [RFC-1034](https://tools.ietf.org/html/rfc1034)
        /// standard with a length limit of 63 characters. Otherwise, an
        /// INVALID_ARGUMENT error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataStore, CreateDataStoreMetadata>> CreateDataStoreAsync(string parent, DataStore dataStore, string dataStoreId, st::CancellationToken cancellationToken) =>
            CreateDataStoreAsync(parent, dataStore, dataStoreId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a [DataStore][google.cloud.discoveryengine.v1.DataStore].
        /// 
        /// DataStore is for storing
        /// [Documents][google.cloud.discoveryengine.v1.Document]. To serve these
        /// documents for Search, or Recommendation use case, an
        /// [Engine][google.cloud.discoveryengine.v1.Engine] needs to be created
        /// separately.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, such as
        /// `projects/{project}/locations/{location}/collections/{collection}`.
        /// </param>
        /// <param name="dataStore">
        /// Required. The [DataStore][google.cloud.discoveryengine.v1.DataStore] to
        /// create.
        /// </param>
        /// <param name="dataStoreId">
        /// Required. The ID to use for the
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore], which will become
        /// the final component of the
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore]'s resource name.
        /// 
        /// This field must conform to [RFC-1034](https://tools.ietf.org/html/rfc1034)
        /// standard with a length limit of 63 characters. Otherwise, an
        /// INVALID_ARGUMENT error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataStore, CreateDataStoreMetadata> CreateDataStore(CollectionName parent, DataStore dataStore, string dataStoreId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataStore(new CreateDataStoreRequest
            {
                ParentAsCollectionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DataStore = gax::GaxPreconditions.CheckNotNull(dataStore, nameof(dataStore)),
                DataStoreId = gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)),
            }, callSettings);

        /// <summary>
        /// Creates a [DataStore][google.cloud.discoveryengine.v1.DataStore].
        /// 
        /// DataStore is for storing
        /// [Documents][google.cloud.discoveryengine.v1.Document]. To serve these
        /// documents for Search, or Recommendation use case, an
        /// [Engine][google.cloud.discoveryengine.v1.Engine] needs to be created
        /// separately.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, such as
        /// `projects/{project}/locations/{location}/collections/{collection}`.
        /// </param>
        /// <param name="dataStore">
        /// Required. The [DataStore][google.cloud.discoveryengine.v1.DataStore] to
        /// create.
        /// </param>
        /// <param name="dataStoreId">
        /// Required. The ID to use for the
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore], which will become
        /// the final component of the
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore]'s resource name.
        /// 
        /// This field must conform to [RFC-1034](https://tools.ietf.org/html/rfc1034)
        /// standard with a length limit of 63 characters. Otherwise, an
        /// INVALID_ARGUMENT error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataStore, CreateDataStoreMetadata>> CreateDataStoreAsync(CollectionName parent, DataStore dataStore, string dataStoreId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataStoreAsync(new CreateDataStoreRequest
            {
                ParentAsCollectionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DataStore = gax::GaxPreconditions.CheckNotNull(dataStore, nameof(dataStore)),
                DataStoreId = gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)),
            }, callSettings);

        /// <summary>
        /// Creates a [DataStore][google.cloud.discoveryengine.v1.DataStore].
        /// 
        /// DataStore is for storing
        /// [Documents][google.cloud.discoveryengine.v1.Document]. To serve these
        /// documents for Search, or Recommendation use case, an
        /// [Engine][google.cloud.discoveryengine.v1.Engine] needs to be created
        /// separately.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, such as
        /// `projects/{project}/locations/{location}/collections/{collection}`.
        /// </param>
        /// <param name="dataStore">
        /// Required. The [DataStore][google.cloud.discoveryengine.v1.DataStore] to
        /// create.
        /// </param>
        /// <param name="dataStoreId">
        /// Required. The ID to use for the
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore], which will become
        /// the final component of the
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore]'s resource name.
        /// 
        /// This field must conform to [RFC-1034](https://tools.ietf.org/html/rfc1034)
        /// standard with a length limit of 63 characters. Otherwise, an
        /// INVALID_ARGUMENT error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataStore, CreateDataStoreMetadata>> CreateDataStoreAsync(CollectionName parent, DataStore dataStore, string dataStoreId, st::CancellationToken cancellationToken) =>
            CreateDataStoreAsync(parent, dataStore, dataStoreId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a [DataStore][google.cloud.discoveryengine.v1.DataStore].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataStore GetDataStore(GetDataStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a [DataStore][google.cloud.discoveryengine.v1.DataStore].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataStore> GetDataStoreAsync(GetDataStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a [DataStore][google.cloud.discoveryengine.v1.DataStore].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataStore> GetDataStoreAsync(GetDataStoreRequest request, st::CancellationToken cancellationToken) =>
            GetDataStoreAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a [DataStore][google.cloud.discoveryengine.v1.DataStore].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore], such as
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}`.
        /// 
        /// If the caller does not have permission to access the
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the requested [DataStore][google.cloud.discoveryengine.v1.DataStore]
        /// does not exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataStore GetDataStore(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataStore(new GetDataStoreRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [DataStore][google.cloud.discoveryengine.v1.DataStore].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore], such as
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}`.
        /// 
        /// If the caller does not have permission to access the
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the requested [DataStore][google.cloud.discoveryengine.v1.DataStore]
        /// does not exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataStore> GetDataStoreAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataStoreAsync(new GetDataStoreRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [DataStore][google.cloud.discoveryengine.v1.DataStore].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore], such as
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}`.
        /// 
        /// If the caller does not have permission to access the
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the requested [DataStore][google.cloud.discoveryengine.v1.DataStore]
        /// does not exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataStore> GetDataStoreAsync(string name, st::CancellationToken cancellationToken) =>
            GetDataStoreAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a [DataStore][google.cloud.discoveryengine.v1.DataStore].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore], such as
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}`.
        /// 
        /// If the caller does not have permission to access the
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the requested [DataStore][google.cloud.discoveryengine.v1.DataStore]
        /// does not exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataStore GetDataStore(DataStoreName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataStore(new GetDataStoreRequest
            {
                DataStoreName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [DataStore][google.cloud.discoveryengine.v1.DataStore].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore], such as
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}`.
        /// 
        /// If the caller does not have permission to access the
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the requested [DataStore][google.cloud.discoveryengine.v1.DataStore]
        /// does not exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataStore> GetDataStoreAsync(DataStoreName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataStoreAsync(new GetDataStoreRequest
            {
                DataStoreName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [DataStore][google.cloud.discoveryengine.v1.DataStore].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore], such as
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}`.
        /// 
        /// If the caller does not have permission to access the
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the requested [DataStore][google.cloud.discoveryengine.v1.DataStore]
        /// does not exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataStore> GetDataStoreAsync(DataStoreName name, st::CancellationToken cancellationToken) =>
            GetDataStoreAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all the [DataStore][google.cloud.discoveryengine.v1.DataStore]s
        /// associated with the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataStore"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataStoresResponse, DataStore> ListDataStores(ListDataStoresRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the [DataStore][google.cloud.discoveryengine.v1.DataStore]s
        /// associated with the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataStore"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataStoresResponse, DataStore> ListDataStoresAsync(ListDataStoresRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the [DataStore][google.cloud.discoveryengine.v1.DataStore]s
        /// associated with the project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent branch resource name, such as
        /// `projects/{project}/locations/{location}/collections/{collection_id}`.
        /// 
        /// If the caller does not have permission to list
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore]s under this
        /// location, regardless of whether or not this data store exists, a
        /// PERMISSION_DENIED error is returned.
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
        /// <returns>A pageable sequence of <see cref="DataStore"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataStoresResponse, DataStore> ListDataStores(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataStoresRequest request = new ListDataStoresRequest
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
            return ListDataStores(request, callSettings);
        }

        /// <summary>
        /// Lists all the [DataStore][google.cloud.discoveryengine.v1.DataStore]s
        /// associated with the project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent branch resource name, such as
        /// `projects/{project}/locations/{location}/collections/{collection_id}`.
        /// 
        /// If the caller does not have permission to list
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore]s under this
        /// location, regardless of whether or not this data store exists, a
        /// PERMISSION_DENIED error is returned.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataStore"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataStoresResponse, DataStore> ListDataStoresAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataStoresRequest request = new ListDataStoresRequest
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
            return ListDataStoresAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all the [DataStore][google.cloud.discoveryengine.v1.DataStore]s
        /// associated with the project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent branch resource name, such as
        /// `projects/{project}/locations/{location}/collections/{collection_id}`.
        /// 
        /// If the caller does not have permission to list
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore]s under this
        /// location, regardless of whether or not this data store exists, a
        /// PERMISSION_DENIED error is returned.
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
        /// <returns>A pageable sequence of <see cref="DataStore"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataStoresResponse, DataStore> ListDataStores(CollectionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataStoresRequest request = new ListDataStoresRequest
            {
                ParentAsCollectionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDataStores(request, callSettings);
        }

        /// <summary>
        /// Lists all the [DataStore][google.cloud.discoveryengine.v1.DataStore]s
        /// associated with the project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent branch resource name, such as
        /// `projects/{project}/locations/{location}/collections/{collection_id}`.
        /// 
        /// If the caller does not have permission to list
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore]s under this
        /// location, regardless of whether or not this data store exists, a
        /// PERMISSION_DENIED error is returned.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataStore"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataStoresResponse, DataStore> ListDataStoresAsync(CollectionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataStoresRequest request = new ListDataStoresRequest
            {
                ParentAsCollectionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDataStoresAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a [DataStore][google.cloud.discoveryengine.v1.DataStore].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteDataStoreMetadata> DeleteDataStore(DeleteDataStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a [DataStore][google.cloud.discoveryengine.v1.DataStore].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteDataStoreMetadata>> DeleteDataStoreAsync(DeleteDataStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a [DataStore][google.cloud.discoveryengine.v1.DataStore].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteDataStoreMetadata>> DeleteDataStoreAsync(DeleteDataStoreRequest request, st::CancellationToken cancellationToken) =>
            DeleteDataStoreAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteDataStore</c>.</summary>
        public virtual lro::OperationsClient DeleteDataStoreOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteDataStore</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteDataStoreMetadata> PollOnceDeleteDataStore(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteDataStoreMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDataStoreOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteDataStore</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteDataStoreMetadata>> PollOnceDeleteDataStoreAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteDataStoreMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDataStoreOperationsClient, callSettings);

        /// <summary>
        /// Deletes a [DataStore][google.cloud.discoveryengine.v1.DataStore].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore], such as
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}`.
        /// 
        /// If the caller does not have permission to delete the
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [DataStore][google.cloud.discoveryengine.v1.DataStore] to delete
        /// does not exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteDataStoreMetadata> DeleteDataStore(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataStore(new DeleteDataStoreRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [DataStore][google.cloud.discoveryengine.v1.DataStore].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore], such as
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}`.
        /// 
        /// If the caller does not have permission to delete the
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [DataStore][google.cloud.discoveryengine.v1.DataStore] to delete
        /// does not exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteDataStoreMetadata>> DeleteDataStoreAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataStoreAsync(new DeleteDataStoreRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [DataStore][google.cloud.discoveryengine.v1.DataStore].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore], such as
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}`.
        /// 
        /// If the caller does not have permission to delete the
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [DataStore][google.cloud.discoveryengine.v1.DataStore] to delete
        /// does not exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteDataStoreMetadata>> DeleteDataStoreAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDataStoreAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a [DataStore][google.cloud.discoveryengine.v1.DataStore].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore], such as
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}`.
        /// 
        /// If the caller does not have permission to delete the
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [DataStore][google.cloud.discoveryengine.v1.DataStore] to delete
        /// does not exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteDataStoreMetadata> DeleteDataStore(DataStoreName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataStore(new DeleteDataStoreRequest
            {
                DataStoreName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [DataStore][google.cloud.discoveryengine.v1.DataStore].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore], such as
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}`.
        /// 
        /// If the caller does not have permission to delete the
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [DataStore][google.cloud.discoveryengine.v1.DataStore] to delete
        /// does not exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteDataStoreMetadata>> DeleteDataStoreAsync(DataStoreName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataStoreAsync(new DeleteDataStoreRequest
            {
                DataStoreName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [DataStore][google.cloud.discoveryengine.v1.DataStore].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore], such as
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}`.
        /// 
        /// If the caller does not have permission to delete the
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [DataStore][google.cloud.discoveryengine.v1.DataStore] to delete
        /// does not exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteDataStoreMetadata>> DeleteDataStoreAsync(DataStoreName name, st::CancellationToken cancellationToken) =>
            DeleteDataStoreAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a [DataStore][google.cloud.discoveryengine.v1.DataStore]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataStore UpdateDataStore(UpdateDataStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a [DataStore][google.cloud.discoveryengine.v1.DataStore]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataStore> UpdateDataStoreAsync(UpdateDataStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a [DataStore][google.cloud.discoveryengine.v1.DataStore]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataStore> UpdateDataStoreAsync(UpdateDataStoreRequest request, st::CancellationToken cancellationToken) =>
            UpdateDataStoreAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a [DataStore][google.cloud.discoveryengine.v1.DataStore]
        /// </summary>
        /// <param name="dataStore">
        /// Required. The [DataStore][google.cloud.discoveryengine.v1.DataStore] to
        /// update.
        /// 
        /// If the caller does not have permission to update the
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [DataStore][google.cloud.discoveryengine.v1.DataStore] to update
        /// does not exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore] to update.
        /// 
        /// If an unsupported or unknown field is provided, an INVALID_ARGUMENT error
        /// is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataStore UpdateDataStore(DataStore dataStore, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataStore(new UpdateDataStoreRequest
            {
                DataStore = gax::GaxPreconditions.CheckNotNull(dataStore, nameof(dataStore)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a [DataStore][google.cloud.discoveryengine.v1.DataStore]
        /// </summary>
        /// <param name="dataStore">
        /// Required. The [DataStore][google.cloud.discoveryengine.v1.DataStore] to
        /// update.
        /// 
        /// If the caller does not have permission to update the
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [DataStore][google.cloud.discoveryengine.v1.DataStore] to update
        /// does not exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore] to update.
        /// 
        /// If an unsupported or unknown field is provided, an INVALID_ARGUMENT error
        /// is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataStore> UpdateDataStoreAsync(DataStore dataStore, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataStoreAsync(new UpdateDataStoreRequest
            {
                DataStore = gax::GaxPreconditions.CheckNotNull(dataStore, nameof(dataStore)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a [DataStore][google.cloud.discoveryengine.v1.DataStore]
        /// </summary>
        /// <param name="dataStore">
        /// Required. The [DataStore][google.cloud.discoveryengine.v1.DataStore] to
        /// update.
        /// 
        /// If the caller does not have permission to update the
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [DataStore][google.cloud.discoveryengine.v1.DataStore] to update
        /// does not exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore] to update.
        /// 
        /// If an unsupported or unknown field is provided, an INVALID_ARGUMENT error
        /// is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataStore> UpdateDataStoreAsync(DataStore dataStore, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDataStoreAsync(dataStore, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>DataStoreService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [DataStore][google.cloud.discoveryengine.v1.DataStore]
    /// configuration.
    /// </remarks>
    public sealed partial class DataStoreServiceClientImpl : DataStoreServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateDataStoreRequest, lro::Operation> _callCreateDataStore;

        private readonly gaxgrpc::ApiCall<GetDataStoreRequest, DataStore> _callGetDataStore;

        private readonly gaxgrpc::ApiCall<ListDataStoresRequest, ListDataStoresResponse> _callListDataStores;

        private readonly gaxgrpc::ApiCall<DeleteDataStoreRequest, lro::Operation> _callDeleteDataStore;

        private readonly gaxgrpc::ApiCall<UpdateDataStoreRequest, DataStore> _callUpdateDataStore;

        /// <summary>
        /// Constructs a client wrapper for the DataStoreService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DataStoreServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DataStoreServiceClientImpl(DataStoreService.DataStoreServiceClient grpcClient, DataStoreServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DataStoreServiceSettings effectiveSettings = settings ?? DataStoreServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateDataStoreOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateDataStoreOperationsSettings, logger);
            DeleteDataStoreOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteDataStoreOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCreateDataStore = clientHelper.BuildApiCall<CreateDataStoreRequest, lro::Operation>("CreateDataStore", grpcClient.CreateDataStoreAsync, grpcClient.CreateDataStore, effectiveSettings.CreateDataStoreSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDataStore);
            Modify_CreateDataStoreApiCall(ref _callCreateDataStore);
            _callGetDataStore = clientHelper.BuildApiCall<GetDataStoreRequest, DataStore>("GetDataStore", grpcClient.GetDataStoreAsync, grpcClient.GetDataStore, effectiveSettings.GetDataStoreSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDataStore);
            Modify_GetDataStoreApiCall(ref _callGetDataStore);
            _callListDataStores = clientHelper.BuildApiCall<ListDataStoresRequest, ListDataStoresResponse>("ListDataStores", grpcClient.ListDataStoresAsync, grpcClient.ListDataStores, effectiveSettings.ListDataStoresSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDataStores);
            Modify_ListDataStoresApiCall(ref _callListDataStores);
            _callDeleteDataStore = clientHelper.BuildApiCall<DeleteDataStoreRequest, lro::Operation>("DeleteDataStore", grpcClient.DeleteDataStoreAsync, grpcClient.DeleteDataStore, effectiveSettings.DeleteDataStoreSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDataStore);
            Modify_DeleteDataStoreApiCall(ref _callDeleteDataStore);
            _callUpdateDataStore = clientHelper.BuildApiCall<UpdateDataStoreRequest, DataStore>("UpdateDataStore", grpcClient.UpdateDataStoreAsync, grpcClient.UpdateDataStore, effectiveSettings.UpdateDataStoreSettings).WithGoogleRequestParam("data_store.name", request => request.DataStore?.Name);
            Modify_ApiCall(ref _callUpdateDataStore);
            Modify_UpdateDataStoreApiCall(ref _callUpdateDataStore);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateDataStoreApiCall(ref gaxgrpc::ApiCall<CreateDataStoreRequest, lro::Operation> call);

        partial void Modify_GetDataStoreApiCall(ref gaxgrpc::ApiCall<GetDataStoreRequest, DataStore> call);

        partial void Modify_ListDataStoresApiCall(ref gaxgrpc::ApiCall<ListDataStoresRequest, ListDataStoresResponse> call);

        partial void Modify_DeleteDataStoreApiCall(ref gaxgrpc::ApiCall<DeleteDataStoreRequest, lro::Operation> call);

        partial void Modify_UpdateDataStoreApiCall(ref gaxgrpc::ApiCall<UpdateDataStoreRequest, DataStore> call);

        partial void OnConstruction(DataStoreService.DataStoreServiceClient grpcClient, DataStoreServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DataStoreService client</summary>
        public override DataStoreService.DataStoreServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CreateDataStoreRequest(ref CreateDataStoreRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDataStoreRequest(ref GetDataStoreRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDataStoresRequest(ref ListDataStoresRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDataStoreRequest(ref DeleteDataStoreRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDataStoreRequest(ref UpdateDataStoreRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateDataStore</c>.</summary>
        public override lro::OperationsClient CreateDataStoreOperationsClient { get; }

        /// <summary>
        /// Creates a [DataStore][google.cloud.discoveryengine.v1.DataStore].
        /// 
        /// DataStore is for storing
        /// [Documents][google.cloud.discoveryengine.v1.Document]. To serve these
        /// documents for Search, or Recommendation use case, an
        /// [Engine][google.cloud.discoveryengine.v1.Engine] needs to be created
        /// separately.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DataStore, CreateDataStoreMetadata> CreateDataStore(CreateDataStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDataStoreRequest(ref request, ref callSettings);
            return new lro::Operation<DataStore, CreateDataStoreMetadata>(_callCreateDataStore.Sync(request, callSettings), CreateDataStoreOperationsClient);
        }

        /// <summary>
        /// Creates a [DataStore][google.cloud.discoveryengine.v1.DataStore].
        /// 
        /// DataStore is for storing
        /// [Documents][google.cloud.discoveryengine.v1.Document]. To serve these
        /// documents for Search, or Recommendation use case, an
        /// [Engine][google.cloud.discoveryengine.v1.Engine] needs to be created
        /// separately.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DataStore, CreateDataStoreMetadata>> CreateDataStoreAsync(CreateDataStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDataStoreRequest(ref request, ref callSettings);
            return new lro::Operation<DataStore, CreateDataStoreMetadata>(await _callCreateDataStore.Async(request, callSettings).ConfigureAwait(false), CreateDataStoreOperationsClient);
        }

        /// <summary>
        /// Gets a [DataStore][google.cloud.discoveryengine.v1.DataStore].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataStore GetDataStore(GetDataStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataStoreRequest(ref request, ref callSettings);
            return _callGetDataStore.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a [DataStore][google.cloud.discoveryengine.v1.DataStore].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataStore> GetDataStoreAsync(GetDataStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataStoreRequest(ref request, ref callSettings);
            return _callGetDataStore.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all the [DataStore][google.cloud.discoveryengine.v1.DataStore]s
        /// associated with the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataStore"/> resources.</returns>
        public override gax::PagedEnumerable<ListDataStoresResponse, DataStore> ListDataStores(ListDataStoresRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataStoresRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDataStoresRequest, ListDataStoresResponse, DataStore>(_callListDataStores, request, callSettings);
        }

        /// <summary>
        /// Lists all the [DataStore][google.cloud.discoveryengine.v1.DataStore]s
        /// associated with the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataStore"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDataStoresResponse, DataStore> ListDataStoresAsync(ListDataStoresRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataStoresRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDataStoresRequest, ListDataStoresResponse, DataStore>(_callListDataStores, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteDataStore</c>.</summary>
        public override lro::OperationsClient DeleteDataStoreOperationsClient { get; }

        /// <summary>
        /// Deletes a [DataStore][google.cloud.discoveryengine.v1.DataStore].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteDataStoreMetadata> DeleteDataStore(DeleteDataStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDataStoreRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteDataStoreMetadata>(_callDeleteDataStore.Sync(request, callSettings), DeleteDataStoreOperationsClient);
        }

        /// <summary>
        /// Deletes a [DataStore][google.cloud.discoveryengine.v1.DataStore].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteDataStoreMetadata>> DeleteDataStoreAsync(DeleteDataStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDataStoreRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteDataStoreMetadata>(await _callDeleteDataStore.Async(request, callSettings).ConfigureAwait(false), DeleteDataStoreOperationsClient);
        }

        /// <summary>
        /// Updates a [DataStore][google.cloud.discoveryengine.v1.DataStore]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataStore UpdateDataStore(UpdateDataStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataStoreRequest(ref request, ref callSettings);
            return _callUpdateDataStore.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a [DataStore][google.cloud.discoveryengine.v1.DataStore]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataStore> UpdateDataStoreAsync(UpdateDataStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataStoreRequest(ref request, ref callSettings);
            return _callUpdateDataStore.Async(request, callSettings);
        }
    }

    public partial class ListDataStoresRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDataStoresResponse : gaxgrpc::IPageResponse<DataStore>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DataStore> GetEnumerator() => DataStores.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class DataStoreService
    {
        public partial class DataStoreServiceClient
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

    public static partial class DataStoreService
    {
        public partial class DataStoreServiceClient
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
