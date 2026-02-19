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
using gcl = Google.Cloud.Location;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.VectorSearch.V1
{
    /// <summary>Settings for <see cref="DataObjectServiceClient"/> instances.</summary>
    public sealed partial class DataObjectServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DataObjectServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DataObjectServiceSettings"/>.</returns>
        public static DataObjectServiceSettings GetDefault() => new DataObjectServiceSettings();

        /// <summary>Constructs a new <see cref="DataObjectServiceSettings"/> object with default settings.</summary>
        public DataObjectServiceSettings()
        {
        }

        private DataObjectServiceSettings(DataObjectServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateDataObjectSettings = existing.CreateDataObjectSettings;
            BatchCreateDataObjectsSettings = existing.BatchCreateDataObjectsSettings;
            GetDataObjectSettings = existing.GetDataObjectSettings;
            UpdateDataObjectSettings = existing.UpdateDataObjectSettings;
            BatchUpdateDataObjectsSettings = existing.BatchUpdateDataObjectsSettings;
            DeleteDataObjectSettings = existing.DeleteDataObjectSettings;
            BatchDeleteDataObjectsSettings = existing.BatchDeleteDataObjectsSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DataObjectServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataObjectServiceClient.CreateDataObject</c> and <c>DataObjectServiceClient.CreateDataObjectAsync</c>.
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
        public gaxgrpc::CallSettings CreateDataObjectSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataObjectServiceClient.BatchCreateDataObjects</c> and
        /// <c>DataObjectServiceClient.BatchCreateDataObjectsAsync</c>.
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
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchCreateDataObjectsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataObjectServiceClient.GetDataObject</c> and <c>DataObjectServiceClient.GetDataObjectAsync</c>.
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
        public gaxgrpc::CallSettings GetDataObjectSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataObjectServiceClient.UpdateDataObject</c> and <c>DataObjectServiceClient.UpdateDataObjectAsync</c>.
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
        public gaxgrpc::CallSettings UpdateDataObjectSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataObjectServiceClient.BatchUpdateDataObjects</c> and
        /// <c>DataObjectServiceClient.BatchUpdateDataObjectsAsync</c>.
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
        public gaxgrpc::CallSettings BatchUpdateDataObjectsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataObjectServiceClient.DeleteDataObject</c> and <c>DataObjectServiceClient.DeleteDataObjectAsync</c>.
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
        public gaxgrpc::CallSettings DeleteDataObjectSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataObjectServiceClient.BatchDeleteDataObjects</c> and
        /// <c>DataObjectServiceClient.BatchDeleteDataObjectsAsync</c>.
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
        public gaxgrpc::CallSettings BatchDeleteDataObjectsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DataObjectServiceSettings"/> object.</returns>
        public DataObjectServiceSettings Clone() => new DataObjectServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DataObjectServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class DataObjectServiceClientBuilder : gaxgrpc::ClientBuilderBase<DataObjectServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DataObjectServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DataObjectServiceClientBuilder() : base(DataObjectServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DataObjectServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DataObjectServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DataObjectServiceClient Build()
        {
            DataObjectServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DataObjectServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DataObjectServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DataObjectServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DataObjectServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DataObjectServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DataObjectServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DataObjectServiceClient.ChannelPool;
    }

    /// <summary>DataObjectService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for creating and managing data objects.
    /// </remarks>
    public abstract partial class DataObjectServiceClient
    {
        /// <summary>
        /// The default endpoint for the DataObjectService service, which is a host of "vectorsearch.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "vectorsearch.googleapis.com:443";

        /// <summary>The default DataObjectService scopes.</summary>
        /// <remarks>
        /// The default DataObjectService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DataObjectService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DataObjectServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DataObjectServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DataObjectServiceClient"/>.</returns>
        public static stt::Task<DataObjectServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DataObjectServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DataObjectServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DataObjectServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DataObjectServiceClient"/>.</returns>
        public static DataObjectServiceClient Create() => new DataObjectServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DataObjectServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DataObjectServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DataObjectServiceClient"/>.</returns>
        internal static DataObjectServiceClient Create(grpccore::CallInvoker callInvoker, DataObjectServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DataObjectService.DataObjectServiceClient grpcClient = new DataObjectService.DataObjectServiceClient(callInvoker);
            return new DataObjectServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DataObjectService client</summary>
        public virtual DataObjectService.DataObjectServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a dataObject.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataObject CreateDataObject(CreateDataObjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a dataObject.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataObject> CreateDataObjectAsync(CreateDataObjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a dataObject.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataObject> CreateDataObjectAsync(CreateDataObjectRequest request, st::CancellationToken cancellationToken) =>
            CreateDataObjectAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a dataObject.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Collection to create the DataObject in.
        /// Format: `projects/{project}/locations/{location}/collections/{collection}`
        /// </param>
        /// <param name="dataObject">
        /// Required. The DataObject to create.
        /// </param>
        /// <param name="dataObjectId">
        /// Required. The id of the dataObject to create.
        /// The id must be 1-63 characters long, and comply with
        /// [RFC1035](https://www.ietf.org/rfc/rfc1035.txt).
        /// Specifically, it must be 1-63 characters long and match the regular
        /// expression `[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataObject CreateDataObject(string parent, DataObject dataObject, string dataObjectId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataObject(new CreateDataObjectRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DataObjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(dataObjectId, nameof(dataObjectId)),
                DataObject = gax::GaxPreconditions.CheckNotNull(dataObject, nameof(dataObject)),
            }, callSettings);

        /// <summary>
        /// Creates a dataObject.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Collection to create the DataObject in.
        /// Format: `projects/{project}/locations/{location}/collections/{collection}`
        /// </param>
        /// <param name="dataObject">
        /// Required. The DataObject to create.
        /// </param>
        /// <param name="dataObjectId">
        /// Required. The id of the dataObject to create.
        /// The id must be 1-63 characters long, and comply with
        /// [RFC1035](https://www.ietf.org/rfc/rfc1035.txt).
        /// Specifically, it must be 1-63 characters long and match the regular
        /// expression `[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataObject> CreateDataObjectAsync(string parent, DataObject dataObject, string dataObjectId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataObjectAsync(new CreateDataObjectRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DataObjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(dataObjectId, nameof(dataObjectId)),
                DataObject = gax::GaxPreconditions.CheckNotNull(dataObject, nameof(dataObject)),
            }, callSettings);

        /// <summary>
        /// Creates a dataObject.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Collection to create the DataObject in.
        /// Format: `projects/{project}/locations/{location}/collections/{collection}`
        /// </param>
        /// <param name="dataObject">
        /// Required. The DataObject to create.
        /// </param>
        /// <param name="dataObjectId">
        /// Required. The id of the dataObject to create.
        /// The id must be 1-63 characters long, and comply with
        /// [RFC1035](https://www.ietf.org/rfc/rfc1035.txt).
        /// Specifically, it must be 1-63 characters long and match the regular
        /// expression `[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataObject> CreateDataObjectAsync(string parent, DataObject dataObject, string dataObjectId, st::CancellationToken cancellationToken) =>
            CreateDataObjectAsync(parent, dataObject, dataObjectId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a dataObject.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Collection to create the DataObject in.
        /// Format: `projects/{project}/locations/{location}/collections/{collection}`
        /// </param>
        /// <param name="dataObject">
        /// Required. The DataObject to create.
        /// </param>
        /// <param name="dataObjectId">
        /// Required. The id of the dataObject to create.
        /// The id must be 1-63 characters long, and comply with
        /// [RFC1035](https://www.ietf.org/rfc/rfc1035.txt).
        /// Specifically, it must be 1-63 characters long and match the regular
        /// expression `[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataObject CreateDataObject(CollectionName parent, DataObject dataObject, string dataObjectId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataObject(new CreateDataObjectRequest
            {
                ParentAsCollectionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DataObjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(dataObjectId, nameof(dataObjectId)),
                DataObject = gax::GaxPreconditions.CheckNotNull(dataObject, nameof(dataObject)),
            }, callSettings);

        /// <summary>
        /// Creates a dataObject.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Collection to create the DataObject in.
        /// Format: `projects/{project}/locations/{location}/collections/{collection}`
        /// </param>
        /// <param name="dataObject">
        /// Required. The DataObject to create.
        /// </param>
        /// <param name="dataObjectId">
        /// Required. The id of the dataObject to create.
        /// The id must be 1-63 characters long, and comply with
        /// [RFC1035](https://www.ietf.org/rfc/rfc1035.txt).
        /// Specifically, it must be 1-63 characters long and match the regular
        /// expression `[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataObject> CreateDataObjectAsync(CollectionName parent, DataObject dataObject, string dataObjectId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataObjectAsync(new CreateDataObjectRequest
            {
                ParentAsCollectionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DataObjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(dataObjectId, nameof(dataObjectId)),
                DataObject = gax::GaxPreconditions.CheckNotNull(dataObject, nameof(dataObject)),
            }, callSettings);

        /// <summary>
        /// Creates a dataObject.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Collection to create the DataObject in.
        /// Format: `projects/{project}/locations/{location}/collections/{collection}`
        /// </param>
        /// <param name="dataObject">
        /// Required. The DataObject to create.
        /// </param>
        /// <param name="dataObjectId">
        /// Required. The id of the dataObject to create.
        /// The id must be 1-63 characters long, and comply with
        /// [RFC1035](https://www.ietf.org/rfc/rfc1035.txt).
        /// Specifically, it must be 1-63 characters long and match the regular
        /// expression `[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataObject> CreateDataObjectAsync(CollectionName parent, DataObject dataObject, string dataObjectId, st::CancellationToken cancellationToken) =>
            CreateDataObjectAsync(parent, dataObject, dataObjectId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a batch of dataObjects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateDataObjectsResponse BatchCreateDataObjects(BatchCreateDataObjectsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a batch of dataObjects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateDataObjectsResponse> BatchCreateDataObjectsAsync(BatchCreateDataObjectsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a batch of dataObjects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateDataObjectsResponse> BatchCreateDataObjectsAsync(BatchCreateDataObjectsRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateDataObjectsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a data object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataObject GetDataObject(GetDataObjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a data object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataObject> GetDataObjectAsync(GetDataObjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a data object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataObject> GetDataObjectAsync(GetDataObjectRequest request, st::CancellationToken cancellationToken) =>
            GetDataObjectAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a data object.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DataObject resource.
        /// Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataObjects/{dataObject}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataObject GetDataObject(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataObject(new GetDataObjectRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a data object.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DataObject resource.
        /// Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataObjects/{dataObject}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataObject> GetDataObjectAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataObjectAsync(new GetDataObjectRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a data object.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DataObject resource.
        /// Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataObjects/{dataObject}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataObject> GetDataObjectAsync(string name, st::CancellationToken cancellationToken) =>
            GetDataObjectAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a data object.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DataObject resource.
        /// Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataObjects/{dataObject}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataObject GetDataObject(DataObjectName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataObject(new GetDataObjectRequest
            {
                DataObjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a data object.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DataObject resource.
        /// Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataObjects/{dataObject}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataObject> GetDataObjectAsync(DataObjectName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataObjectAsync(new GetDataObjectRequest
            {
                DataObjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a data object.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DataObject resource.
        /// Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataObjects/{dataObject}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataObject> GetDataObjectAsync(DataObjectName name, st::CancellationToken cancellationToken) =>
            GetDataObjectAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a dataObject.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataObject UpdateDataObject(UpdateDataObjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a dataObject.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataObject> UpdateDataObjectAsync(UpdateDataObjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a dataObject.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataObject> UpdateDataObjectAsync(UpdateDataObjectRequest request, st::CancellationToken cancellationToken) =>
            UpdateDataObjectAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a dataObject.
        /// </summary>
        /// <param name="dataObject">
        /// Required. The DataObject which replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The update mask applies to the resource. See
        /// [google.protobuf.FieldMask][google.protobuf.FieldMask].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataObject UpdateDataObject(DataObject dataObject, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataObject(new UpdateDataObjectRequest
            {
                DataObject = gax::GaxPreconditions.CheckNotNull(dataObject, nameof(dataObject)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a dataObject.
        /// </summary>
        /// <param name="dataObject">
        /// Required. The DataObject which replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The update mask applies to the resource. See
        /// [google.protobuf.FieldMask][google.protobuf.FieldMask].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataObject> UpdateDataObjectAsync(DataObject dataObject, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataObjectAsync(new UpdateDataObjectRequest
            {
                DataObject = gax::GaxPreconditions.CheckNotNull(dataObject, nameof(dataObject)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a dataObject.
        /// </summary>
        /// <param name="dataObject">
        /// Required. The DataObject which replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The update mask applies to the resource. See
        /// [google.protobuf.FieldMask][google.protobuf.FieldMask].
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataObject> UpdateDataObjectAsync(DataObject dataObject, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDataObjectAsync(dataObject, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates dataObjects in a batch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateDataObjectsResponse BatchUpdateDataObjects(BatchUpdateDataObjectsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates dataObjects in a batch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateDataObjectsResponse> BatchUpdateDataObjectsAsync(BatchUpdateDataObjectsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates dataObjects in a batch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateDataObjectsResponse> BatchUpdateDataObjectsAsync(BatchUpdateDataObjectsRequest request, st::CancellationToken cancellationToken) =>
            BatchUpdateDataObjectsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates dataObjects in a batch.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Collection to update the DataObjects in.
        /// Format: `projects/{project}/locations/{location}/collections/{collection}`.
        /// The parent field in the UpdateDataObjectRequest messages must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the resources to update.
        /// A maximum of 1000 DataObjects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateDataObjectsResponse BatchUpdateDataObjects(string parent, scg::IEnumerable<UpdateDataObjectRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateDataObjects(new BatchUpdateDataObjectsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Updates dataObjects in a batch.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Collection to update the DataObjects in.
        /// Format: `projects/{project}/locations/{location}/collections/{collection}`.
        /// The parent field in the UpdateDataObjectRequest messages must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the resources to update.
        /// A maximum of 1000 DataObjects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateDataObjectsResponse> BatchUpdateDataObjectsAsync(string parent, scg::IEnumerable<UpdateDataObjectRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateDataObjectsAsync(new BatchUpdateDataObjectsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Updates dataObjects in a batch.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Collection to update the DataObjects in.
        /// Format: `projects/{project}/locations/{location}/collections/{collection}`.
        /// The parent field in the UpdateDataObjectRequest messages must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the resources to update.
        /// A maximum of 1000 DataObjects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateDataObjectsResponse> BatchUpdateDataObjectsAsync(string parent, scg::IEnumerable<UpdateDataObjectRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateDataObjectsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates dataObjects in a batch.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Collection to update the DataObjects in.
        /// Format: `projects/{project}/locations/{location}/collections/{collection}`.
        /// The parent field in the UpdateDataObjectRequest messages must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the resources to update.
        /// A maximum of 1000 DataObjects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateDataObjectsResponse BatchUpdateDataObjects(CollectionName parent, scg::IEnumerable<UpdateDataObjectRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateDataObjects(new BatchUpdateDataObjectsRequest
            {
                ParentAsCollectionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Updates dataObjects in a batch.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Collection to update the DataObjects in.
        /// Format: `projects/{project}/locations/{location}/collections/{collection}`.
        /// The parent field in the UpdateDataObjectRequest messages must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the resources to update.
        /// A maximum of 1000 DataObjects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateDataObjectsResponse> BatchUpdateDataObjectsAsync(CollectionName parent, scg::IEnumerable<UpdateDataObjectRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateDataObjectsAsync(new BatchUpdateDataObjectsRequest
            {
                ParentAsCollectionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Updates dataObjects in a batch.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Collection to update the DataObjects in.
        /// Format: `projects/{project}/locations/{location}/collections/{collection}`.
        /// The parent field in the UpdateDataObjectRequest messages must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the resources to update.
        /// A maximum of 1000 DataObjects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateDataObjectsResponse> BatchUpdateDataObjectsAsync(CollectionName parent, scg::IEnumerable<UpdateDataObjectRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateDataObjectsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a dataObject.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDataObject(DeleteDataObjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a dataObject.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataObjectAsync(DeleteDataObjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a dataObject.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataObjectAsync(DeleteDataObjectRequest request, st::CancellationToken cancellationToken) =>
            DeleteDataObjectAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a dataObject.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DataObject resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataObjects/{dataObject}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDataObject(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataObject(new DeleteDataObjectRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a dataObject.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DataObject resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataObjects/{dataObject}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataObjectAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataObjectAsync(new DeleteDataObjectRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a dataObject.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DataObject resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataObjects/{dataObject}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataObjectAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDataObjectAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a dataObject.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DataObject resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataObjects/{dataObject}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDataObject(DataObjectName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataObject(new DeleteDataObjectRequest
            {
                DataObjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a dataObject.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DataObject resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataObjects/{dataObject}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataObjectAsync(DataObjectName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataObjectAsync(new DeleteDataObjectRequest
            {
                DataObjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a dataObject.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DataObject resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataObjects/{dataObject}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataObjectAsync(DataObjectName name, st::CancellationToken cancellationToken) =>
            DeleteDataObjectAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes dataObjects in a batch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void BatchDeleteDataObjects(BatchDeleteDataObjectsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes dataObjects in a batch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteDataObjectsAsync(BatchDeleteDataObjectsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes dataObjects in a batch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteDataObjectsAsync(BatchDeleteDataObjectsRequest request, st::CancellationToken cancellationToken) =>
            BatchDeleteDataObjectsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes dataObjects in a batch.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Collection to delete the DataObjects in.
        /// Format: `projects/{project}/locations/{location}/collections/{collection}`.
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the resources to delete.
        /// A maximum of 1000 DataObjects can be deleted in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void BatchDeleteDataObjects(string parent, scg::IEnumerable<DeleteDataObjectRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteDataObjects(new BatchDeleteDataObjectsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Deletes dataObjects in a batch.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Collection to delete the DataObjects in.
        /// Format: `projects/{project}/locations/{location}/collections/{collection}`.
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the resources to delete.
        /// A maximum of 1000 DataObjects can be deleted in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteDataObjectsAsync(string parent, scg::IEnumerable<DeleteDataObjectRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteDataObjectsAsync(new BatchDeleteDataObjectsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Deletes dataObjects in a batch.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Collection to delete the DataObjects in.
        /// Format: `projects/{project}/locations/{location}/collections/{collection}`.
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the resources to delete.
        /// A maximum of 1000 DataObjects can be deleted in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteDataObjectsAsync(string parent, scg::IEnumerable<DeleteDataObjectRequest> requests, st::CancellationToken cancellationToken) =>
            BatchDeleteDataObjectsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes dataObjects in a batch.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Collection to delete the DataObjects in.
        /// Format: `projects/{project}/locations/{location}/collections/{collection}`.
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the resources to delete.
        /// A maximum of 1000 DataObjects can be deleted in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void BatchDeleteDataObjects(CollectionName parent, scg::IEnumerable<DeleteDataObjectRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteDataObjects(new BatchDeleteDataObjectsRequest
            {
                ParentAsCollectionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Deletes dataObjects in a batch.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Collection to delete the DataObjects in.
        /// Format: `projects/{project}/locations/{location}/collections/{collection}`.
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the resources to delete.
        /// A maximum of 1000 DataObjects can be deleted in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteDataObjectsAsync(CollectionName parent, scg::IEnumerable<DeleteDataObjectRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteDataObjectsAsync(new BatchDeleteDataObjectsRequest
            {
                ParentAsCollectionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Deletes dataObjects in a batch.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Collection to delete the DataObjects in.
        /// Format: `projects/{project}/locations/{location}/collections/{collection}`.
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the resources to delete.
        /// A maximum of 1000 DataObjects can be deleted in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteDataObjectsAsync(CollectionName parent, scg::IEnumerable<DeleteDataObjectRequest> requests, st::CancellationToken cancellationToken) =>
            BatchDeleteDataObjectsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>DataObjectService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for creating and managing data objects.
    /// </remarks>
    public sealed partial class DataObjectServiceClientImpl : DataObjectServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateDataObjectRequest, DataObject> _callCreateDataObject;

        private readonly gaxgrpc::ApiCall<BatchCreateDataObjectsRequest, BatchCreateDataObjectsResponse> _callBatchCreateDataObjects;

        private readonly gaxgrpc::ApiCall<GetDataObjectRequest, DataObject> _callGetDataObject;

        private readonly gaxgrpc::ApiCall<UpdateDataObjectRequest, DataObject> _callUpdateDataObject;

        private readonly gaxgrpc::ApiCall<BatchUpdateDataObjectsRequest, BatchUpdateDataObjectsResponse> _callBatchUpdateDataObjects;

        private readonly gaxgrpc::ApiCall<DeleteDataObjectRequest, wkt::Empty> _callDeleteDataObject;

        private readonly gaxgrpc::ApiCall<BatchDeleteDataObjectsRequest, wkt::Empty> _callBatchDeleteDataObjects;

        /// <summary>
        /// Constructs a client wrapper for the DataObjectService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DataObjectServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DataObjectServiceClientImpl(DataObjectService.DataObjectServiceClient grpcClient, DataObjectServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DataObjectServiceSettings effectiveSettings = settings ?? DataObjectServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCreateDataObject = clientHelper.BuildApiCall<CreateDataObjectRequest, DataObject>("CreateDataObject", grpcClient.CreateDataObjectAsync, grpcClient.CreateDataObject, effectiveSettings.CreateDataObjectSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDataObject);
            Modify_CreateDataObjectApiCall(ref _callCreateDataObject);
            _callBatchCreateDataObjects = clientHelper.BuildApiCall<BatchCreateDataObjectsRequest, BatchCreateDataObjectsResponse>("BatchCreateDataObjects", grpcClient.BatchCreateDataObjectsAsync, grpcClient.BatchCreateDataObjects, effectiveSettings.BatchCreateDataObjectsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCreateDataObjects);
            Modify_BatchCreateDataObjectsApiCall(ref _callBatchCreateDataObjects);
            _callGetDataObject = clientHelper.BuildApiCall<GetDataObjectRequest, DataObject>("GetDataObject", grpcClient.GetDataObjectAsync, grpcClient.GetDataObject, effectiveSettings.GetDataObjectSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDataObject);
            Modify_GetDataObjectApiCall(ref _callGetDataObject);
            _callUpdateDataObject = clientHelper.BuildApiCall<UpdateDataObjectRequest, DataObject>("UpdateDataObject", grpcClient.UpdateDataObjectAsync, grpcClient.UpdateDataObject, effectiveSettings.UpdateDataObjectSettings).WithGoogleRequestParam("data_object.name", request => request.DataObject?.Name);
            Modify_ApiCall(ref _callUpdateDataObject);
            Modify_UpdateDataObjectApiCall(ref _callUpdateDataObject);
            _callBatchUpdateDataObjects = clientHelper.BuildApiCall<BatchUpdateDataObjectsRequest, BatchUpdateDataObjectsResponse>("BatchUpdateDataObjects", grpcClient.BatchUpdateDataObjectsAsync, grpcClient.BatchUpdateDataObjects, effectiveSettings.BatchUpdateDataObjectsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchUpdateDataObjects);
            Modify_BatchUpdateDataObjectsApiCall(ref _callBatchUpdateDataObjects);
            _callDeleteDataObject = clientHelper.BuildApiCall<DeleteDataObjectRequest, wkt::Empty>("DeleteDataObject", grpcClient.DeleteDataObjectAsync, grpcClient.DeleteDataObject, effectiveSettings.DeleteDataObjectSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDataObject);
            Modify_DeleteDataObjectApiCall(ref _callDeleteDataObject);
            _callBatchDeleteDataObjects = clientHelper.BuildApiCall<BatchDeleteDataObjectsRequest, wkt::Empty>("BatchDeleteDataObjects", grpcClient.BatchDeleteDataObjectsAsync, grpcClient.BatchDeleteDataObjects, effectiveSettings.BatchDeleteDataObjectsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchDeleteDataObjects);
            Modify_BatchDeleteDataObjectsApiCall(ref _callBatchDeleteDataObjects);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateDataObjectApiCall(ref gaxgrpc::ApiCall<CreateDataObjectRequest, DataObject> call);

        partial void Modify_BatchCreateDataObjectsApiCall(ref gaxgrpc::ApiCall<BatchCreateDataObjectsRequest, BatchCreateDataObjectsResponse> call);

        partial void Modify_GetDataObjectApiCall(ref gaxgrpc::ApiCall<GetDataObjectRequest, DataObject> call);

        partial void Modify_UpdateDataObjectApiCall(ref gaxgrpc::ApiCall<UpdateDataObjectRequest, DataObject> call);

        partial void Modify_BatchUpdateDataObjectsApiCall(ref gaxgrpc::ApiCall<BatchUpdateDataObjectsRequest, BatchUpdateDataObjectsResponse> call);

        partial void Modify_DeleteDataObjectApiCall(ref gaxgrpc::ApiCall<DeleteDataObjectRequest, wkt::Empty> call);

        partial void Modify_BatchDeleteDataObjectsApiCall(ref gaxgrpc::ApiCall<BatchDeleteDataObjectsRequest, wkt::Empty> call);

        partial void OnConstruction(DataObjectService.DataObjectServiceClient grpcClient, DataObjectServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DataObjectService client</summary>
        public override DataObjectService.DataObjectServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CreateDataObjectRequest(ref CreateDataObjectRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateDataObjectsRequest(ref BatchCreateDataObjectsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDataObjectRequest(ref GetDataObjectRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDataObjectRequest(ref UpdateDataObjectRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUpdateDataObjectsRequest(ref BatchUpdateDataObjectsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDataObjectRequest(ref DeleteDataObjectRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchDeleteDataObjectsRequest(ref BatchDeleteDataObjectsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a dataObject.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataObject CreateDataObject(CreateDataObjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDataObjectRequest(ref request, ref callSettings);
            return _callCreateDataObject.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a dataObject.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataObject> CreateDataObjectAsync(CreateDataObjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDataObjectRequest(ref request, ref callSettings);
            return _callCreateDataObject.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a batch of dataObjects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchCreateDataObjectsResponse BatchCreateDataObjects(BatchCreateDataObjectsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateDataObjectsRequest(ref request, ref callSettings);
            return _callBatchCreateDataObjects.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a batch of dataObjects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchCreateDataObjectsResponse> BatchCreateDataObjectsAsync(BatchCreateDataObjectsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateDataObjectsRequest(ref request, ref callSettings);
            return _callBatchCreateDataObjects.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a data object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataObject GetDataObject(GetDataObjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataObjectRequest(ref request, ref callSettings);
            return _callGetDataObject.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a data object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataObject> GetDataObjectAsync(GetDataObjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataObjectRequest(ref request, ref callSettings);
            return _callGetDataObject.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a dataObject.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataObject UpdateDataObject(UpdateDataObjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataObjectRequest(ref request, ref callSettings);
            return _callUpdateDataObject.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a dataObject.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataObject> UpdateDataObjectAsync(UpdateDataObjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataObjectRequest(ref request, ref callSettings);
            return _callUpdateDataObject.Async(request, callSettings);
        }

        /// <summary>
        /// Updates dataObjects in a batch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchUpdateDataObjectsResponse BatchUpdateDataObjects(BatchUpdateDataObjectsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateDataObjectsRequest(ref request, ref callSettings);
            return _callBatchUpdateDataObjects.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates dataObjects in a batch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchUpdateDataObjectsResponse> BatchUpdateDataObjectsAsync(BatchUpdateDataObjectsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateDataObjectsRequest(ref request, ref callSettings);
            return _callBatchUpdateDataObjects.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a dataObject.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteDataObject(DeleteDataObjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDataObjectRequest(ref request, ref callSettings);
            _callDeleteDataObject.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a dataObject.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteDataObjectAsync(DeleteDataObjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDataObjectRequest(ref request, ref callSettings);
            return _callDeleteDataObject.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes dataObjects in a batch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void BatchDeleteDataObjects(BatchDeleteDataObjectsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeleteDataObjectsRequest(ref request, ref callSettings);
            _callBatchDeleteDataObjects.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes dataObjects in a batch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task BatchDeleteDataObjectsAsync(BatchDeleteDataObjectsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeleteDataObjectsRequest(ref request, ref callSettings);
            return _callBatchDeleteDataObjects.Async(request, callSettings);
        }
    }

    public static partial class DataObjectService
    {
        public partial class DataObjectServiceClient
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
