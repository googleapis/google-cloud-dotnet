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
using lro = Google.LongRunning;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.DiscoveryEngine.V1
{
    /// <summary>Settings for <see cref="DataConnectorServiceClient"/> instances.</summary>
    public sealed partial class DataConnectorServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DataConnectorServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DataConnectorServiceSettings"/>.</returns>
        public static DataConnectorServiceSettings GetDefault() => new DataConnectorServiceSettings();

        /// <summary>Constructs a new <see cref="DataConnectorServiceSettings"/> object with default settings.</summary>
        public DataConnectorServiceSettings()
        {
        }

        private DataConnectorServiceSettings(DataConnectorServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            SetUpDataConnectorSettings = existing.SetUpDataConnectorSettings;
            SetUpDataConnectorOperationsSettings = existing.SetUpDataConnectorOperationsSettings.Clone();
            GetDataConnectorSettings = existing.GetDataConnectorSettings;
            UpdateDataConnectorSettings = existing.UpdateDataConnectorSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DataConnectorServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataConnectorServiceClient.SetUpDataConnector</c> and
        /// <c>DataConnectorServiceClient.SetUpDataConnectorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetUpDataConnectorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataConnectorServiceClient.SetUpDataConnector</c> and
        /// <c>DataConnectorServiceClient.SetUpDataConnectorAsync</c>.
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
        public lro::OperationsSettings SetUpDataConnectorOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataConnectorServiceClient.GetDataConnector</c> and <c>DataConnectorServiceClient.GetDataConnectorAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDataConnectorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataConnectorServiceClient.UpdateDataConnector</c> and
        /// <c>DataConnectorServiceClient.UpdateDataConnectorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDataConnectorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DataConnectorServiceSettings"/> object.</returns>
        public DataConnectorServiceSettings Clone() => new DataConnectorServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DataConnectorServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class DataConnectorServiceClientBuilder : gaxgrpc::ClientBuilderBase<DataConnectorServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DataConnectorServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DataConnectorServiceClientBuilder() : base(DataConnectorServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DataConnectorServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DataConnectorServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DataConnectorServiceClient Build()
        {
            DataConnectorServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DataConnectorServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DataConnectorServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DataConnectorServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DataConnectorServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DataConnectorServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DataConnectorServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DataConnectorServiceClient.ChannelPool;
    }

    /// <summary>DataConnectorService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for data connector management.
    /// </remarks>
    public abstract partial class DataConnectorServiceClient
    {
        /// <summary>
        /// The default endpoint for the DataConnectorService service, which is a host of
        /// "discoveryengine.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "discoveryengine.googleapis.com:443";

        /// <summary>The default DataConnectorService scopes.</summary>
        /// <remarks>
        /// The default DataConnectorService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/discoveryengine.assist.readwrite</description></item>
        /// <item><description>https://www.googleapis.com/auth/discoveryengine.readwrite</description></item>
        /// <item><description>https://www.googleapis.com/auth/discoveryengine.serving.readwrite</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/discoveryengine.assist.readwrite",
            "https://www.googleapis.com/auth/discoveryengine.readwrite",
            "https://www.googleapis.com/auth/discoveryengine.serving.readwrite",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DataConnectorService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DataConnectorServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="DataConnectorServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DataConnectorServiceClient"/>.</returns>
        public static stt::Task<DataConnectorServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DataConnectorServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DataConnectorServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="DataConnectorServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DataConnectorServiceClient"/>.</returns>
        public static DataConnectorServiceClient Create() => new DataConnectorServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DataConnectorServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DataConnectorServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DataConnectorServiceClient"/>.</returns>
        internal static DataConnectorServiceClient Create(grpccore::CallInvoker callInvoker, DataConnectorServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DataConnectorService.DataConnectorServiceClient grpcClient = new DataConnectorService.DataConnectorServiceClient(callInvoker);
            return new DataConnectorServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DataConnectorService client</summary>
        public virtual DataConnectorService.DataConnectorServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [Collection][google.cloud.discoveryengine.v1.Collection] and sets
        /// up the [DataConnector][google.cloud.discoveryengine.v1.DataConnector] for
        /// it. To stop a
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector] after setup,
        /// use the
        /// [CollectionService.DeleteCollection][google.cloud.discoveryengine.v1.CollectionService.DeleteCollection]
        /// method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataConnector, SetUpDataConnectorMetadata> SetUpDataConnector(SetUpDataConnectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [Collection][google.cloud.discoveryengine.v1.Collection] and sets
        /// up the [DataConnector][google.cloud.discoveryengine.v1.DataConnector] for
        /// it. To stop a
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector] after setup,
        /// use the
        /// [CollectionService.DeleteCollection][google.cloud.discoveryengine.v1.CollectionService.DeleteCollection]
        /// method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataConnector, SetUpDataConnectorMetadata>> SetUpDataConnectorAsync(SetUpDataConnectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [Collection][google.cloud.discoveryengine.v1.Collection] and sets
        /// up the [DataConnector][google.cloud.discoveryengine.v1.DataConnector] for
        /// it. To stop a
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector] after setup,
        /// use the
        /// [CollectionService.DeleteCollection][google.cloud.discoveryengine.v1.CollectionService.DeleteCollection]
        /// method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataConnector, SetUpDataConnectorMetadata>> SetUpDataConnectorAsync(SetUpDataConnectorRequest request, st::CancellationToken cancellationToken) =>
            SetUpDataConnectorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SetUpDataConnector</c>.</summary>
        public virtual lro::OperationsClient SetUpDataConnectorOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SetUpDataConnector</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DataConnector, SetUpDataConnectorMetadata> PollOnceSetUpDataConnector(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DataConnector, SetUpDataConnectorMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetUpDataConnectorOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetUpDataConnector</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DataConnector, SetUpDataConnectorMetadata>> PollOnceSetUpDataConnectorAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DataConnector, SetUpDataConnectorMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetUpDataConnectorOperationsClient, callSettings);

        /// <summary>
        /// Creates a [Collection][google.cloud.discoveryengine.v1.Collection] and sets
        /// up the [DataConnector][google.cloud.discoveryengine.v1.DataConnector] for
        /// it. To stop a
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector] after setup,
        /// use the
        /// [CollectionService.DeleteCollection][google.cloud.discoveryengine.v1.CollectionService.DeleteCollection]
        /// method.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of
        /// [Collection][google.cloud.discoveryengine.v1.Collection], in the format of
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="collectionId">
        /// Required. The ID to use for the
        /// [Collection][google.cloud.discoveryengine.v1.Collection], which will become
        /// the final component of the
        /// [Collection][google.cloud.discoveryengine.v1.Collection]'s resource name. A
        /// new [Collection][google.cloud.discoveryengine.v1.Collection] is created as
        /// part of the [DataConnector][google.cloud.discoveryengine.v1.DataConnector]
        /// setup. [DataConnector][google.cloud.discoveryengine.v1.DataConnector] is a
        /// singleton resource under
        /// [Collection][google.cloud.discoveryengine.v1.Collection], managing all
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore]s of the
        /// [Collection][google.cloud.discoveryengine.v1.Collection].
        /// 
        /// Should conform to
        /// [RFC-1034](https://tools.ietf.org/html/rfc1034) standard with a length
        /// limit of 63 characters. Otherwise, an `INVALID_ARGUMENT` error is returned.
        /// </param>
        /// <param name="collectionDisplayName">
        /// Required. The display name of the
        /// [Collection][google.cloud.discoveryengine.v1.Collection].
        /// 
        /// Should be human readable, used to display collections in the Console
        /// Dashboard. UTF-8 encoded string with limit of 1024 characters.
        /// </param>
        /// <param name="dataConnector">
        /// Required. The
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector] to
        /// initialize in the newly created
        /// [Collection][google.cloud.discoveryengine.v1.Collection].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataConnector, SetUpDataConnectorMetadata> SetUpDataConnector(string parent, string collectionId, string collectionDisplayName, DataConnector dataConnector, gaxgrpc::CallSettings callSettings = null) =>
            SetUpDataConnector(new SetUpDataConnectorRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CollectionId = gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)),
                CollectionDisplayName = gax::GaxPreconditions.CheckNotNullOrEmpty(collectionDisplayName, nameof(collectionDisplayName)),
                DataConnector = gax::GaxPreconditions.CheckNotNull(dataConnector, nameof(dataConnector)),
            }, callSettings);

        /// <summary>
        /// Creates a [Collection][google.cloud.discoveryengine.v1.Collection] and sets
        /// up the [DataConnector][google.cloud.discoveryengine.v1.DataConnector] for
        /// it. To stop a
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector] after setup,
        /// use the
        /// [CollectionService.DeleteCollection][google.cloud.discoveryengine.v1.CollectionService.DeleteCollection]
        /// method.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of
        /// [Collection][google.cloud.discoveryengine.v1.Collection], in the format of
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="collectionId">
        /// Required. The ID to use for the
        /// [Collection][google.cloud.discoveryengine.v1.Collection], which will become
        /// the final component of the
        /// [Collection][google.cloud.discoveryengine.v1.Collection]'s resource name. A
        /// new [Collection][google.cloud.discoveryengine.v1.Collection] is created as
        /// part of the [DataConnector][google.cloud.discoveryengine.v1.DataConnector]
        /// setup. [DataConnector][google.cloud.discoveryengine.v1.DataConnector] is a
        /// singleton resource under
        /// [Collection][google.cloud.discoveryengine.v1.Collection], managing all
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore]s of the
        /// [Collection][google.cloud.discoveryengine.v1.Collection].
        /// 
        /// Should conform to
        /// [RFC-1034](https://tools.ietf.org/html/rfc1034) standard with a length
        /// limit of 63 characters. Otherwise, an `INVALID_ARGUMENT` error is returned.
        /// </param>
        /// <param name="collectionDisplayName">
        /// Required. The display name of the
        /// [Collection][google.cloud.discoveryengine.v1.Collection].
        /// 
        /// Should be human readable, used to display collections in the Console
        /// Dashboard. UTF-8 encoded string with limit of 1024 characters.
        /// </param>
        /// <param name="dataConnector">
        /// Required. The
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector] to
        /// initialize in the newly created
        /// [Collection][google.cloud.discoveryengine.v1.Collection].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataConnector, SetUpDataConnectorMetadata>> SetUpDataConnectorAsync(string parent, string collectionId, string collectionDisplayName, DataConnector dataConnector, gaxgrpc::CallSettings callSettings = null) =>
            SetUpDataConnectorAsync(new SetUpDataConnectorRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CollectionId = gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)),
                CollectionDisplayName = gax::GaxPreconditions.CheckNotNullOrEmpty(collectionDisplayName, nameof(collectionDisplayName)),
                DataConnector = gax::GaxPreconditions.CheckNotNull(dataConnector, nameof(dataConnector)),
            }, callSettings);

        /// <summary>
        /// Creates a [Collection][google.cloud.discoveryengine.v1.Collection] and sets
        /// up the [DataConnector][google.cloud.discoveryengine.v1.DataConnector] for
        /// it. To stop a
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector] after setup,
        /// use the
        /// [CollectionService.DeleteCollection][google.cloud.discoveryengine.v1.CollectionService.DeleteCollection]
        /// method.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of
        /// [Collection][google.cloud.discoveryengine.v1.Collection], in the format of
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="collectionId">
        /// Required. The ID to use for the
        /// [Collection][google.cloud.discoveryengine.v1.Collection], which will become
        /// the final component of the
        /// [Collection][google.cloud.discoveryengine.v1.Collection]'s resource name. A
        /// new [Collection][google.cloud.discoveryengine.v1.Collection] is created as
        /// part of the [DataConnector][google.cloud.discoveryengine.v1.DataConnector]
        /// setup. [DataConnector][google.cloud.discoveryengine.v1.DataConnector] is a
        /// singleton resource under
        /// [Collection][google.cloud.discoveryengine.v1.Collection], managing all
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore]s of the
        /// [Collection][google.cloud.discoveryengine.v1.Collection].
        /// 
        /// Should conform to
        /// [RFC-1034](https://tools.ietf.org/html/rfc1034) standard with a length
        /// limit of 63 characters. Otherwise, an `INVALID_ARGUMENT` error is returned.
        /// </param>
        /// <param name="collectionDisplayName">
        /// Required. The display name of the
        /// [Collection][google.cloud.discoveryengine.v1.Collection].
        /// 
        /// Should be human readable, used to display collections in the Console
        /// Dashboard. UTF-8 encoded string with limit of 1024 characters.
        /// </param>
        /// <param name="dataConnector">
        /// Required. The
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector] to
        /// initialize in the newly created
        /// [Collection][google.cloud.discoveryengine.v1.Collection].
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataConnector, SetUpDataConnectorMetadata>> SetUpDataConnectorAsync(string parent, string collectionId, string collectionDisplayName, DataConnector dataConnector, st::CancellationToken cancellationToken) =>
            SetUpDataConnectorAsync(parent, collectionId, collectionDisplayName, dataConnector, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a [Collection][google.cloud.discoveryengine.v1.Collection] and sets
        /// up the [DataConnector][google.cloud.discoveryengine.v1.DataConnector] for
        /// it. To stop a
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector] after setup,
        /// use the
        /// [CollectionService.DeleteCollection][google.cloud.discoveryengine.v1.CollectionService.DeleteCollection]
        /// method.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of
        /// [Collection][google.cloud.discoveryengine.v1.Collection], in the format of
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="collectionId">
        /// Required. The ID to use for the
        /// [Collection][google.cloud.discoveryengine.v1.Collection], which will become
        /// the final component of the
        /// [Collection][google.cloud.discoveryengine.v1.Collection]'s resource name. A
        /// new [Collection][google.cloud.discoveryengine.v1.Collection] is created as
        /// part of the [DataConnector][google.cloud.discoveryengine.v1.DataConnector]
        /// setup. [DataConnector][google.cloud.discoveryengine.v1.DataConnector] is a
        /// singleton resource under
        /// [Collection][google.cloud.discoveryengine.v1.Collection], managing all
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore]s of the
        /// [Collection][google.cloud.discoveryengine.v1.Collection].
        /// 
        /// Should conform to
        /// [RFC-1034](https://tools.ietf.org/html/rfc1034) standard with a length
        /// limit of 63 characters. Otherwise, an `INVALID_ARGUMENT` error is returned.
        /// </param>
        /// <param name="collectionDisplayName">
        /// Required. The display name of the
        /// [Collection][google.cloud.discoveryengine.v1.Collection].
        /// 
        /// Should be human readable, used to display collections in the Console
        /// Dashboard. UTF-8 encoded string with limit of 1024 characters.
        /// </param>
        /// <param name="dataConnector">
        /// Required. The
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector] to
        /// initialize in the newly created
        /// [Collection][google.cloud.discoveryengine.v1.Collection].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataConnector, SetUpDataConnectorMetadata> SetUpDataConnector(LocationName parent, string collectionId, string collectionDisplayName, DataConnector dataConnector, gaxgrpc::CallSettings callSettings = null) =>
            SetUpDataConnector(new SetUpDataConnectorRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CollectionId = gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)),
                CollectionDisplayName = gax::GaxPreconditions.CheckNotNullOrEmpty(collectionDisplayName, nameof(collectionDisplayName)),
                DataConnector = gax::GaxPreconditions.CheckNotNull(dataConnector, nameof(dataConnector)),
            }, callSettings);

        /// <summary>
        /// Creates a [Collection][google.cloud.discoveryengine.v1.Collection] and sets
        /// up the [DataConnector][google.cloud.discoveryengine.v1.DataConnector] for
        /// it. To stop a
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector] after setup,
        /// use the
        /// [CollectionService.DeleteCollection][google.cloud.discoveryengine.v1.CollectionService.DeleteCollection]
        /// method.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of
        /// [Collection][google.cloud.discoveryengine.v1.Collection], in the format of
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="collectionId">
        /// Required. The ID to use for the
        /// [Collection][google.cloud.discoveryengine.v1.Collection], which will become
        /// the final component of the
        /// [Collection][google.cloud.discoveryengine.v1.Collection]'s resource name. A
        /// new [Collection][google.cloud.discoveryengine.v1.Collection] is created as
        /// part of the [DataConnector][google.cloud.discoveryengine.v1.DataConnector]
        /// setup. [DataConnector][google.cloud.discoveryengine.v1.DataConnector] is a
        /// singleton resource under
        /// [Collection][google.cloud.discoveryengine.v1.Collection], managing all
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore]s of the
        /// [Collection][google.cloud.discoveryengine.v1.Collection].
        /// 
        /// Should conform to
        /// [RFC-1034](https://tools.ietf.org/html/rfc1034) standard with a length
        /// limit of 63 characters. Otherwise, an `INVALID_ARGUMENT` error is returned.
        /// </param>
        /// <param name="collectionDisplayName">
        /// Required. The display name of the
        /// [Collection][google.cloud.discoveryengine.v1.Collection].
        /// 
        /// Should be human readable, used to display collections in the Console
        /// Dashboard. UTF-8 encoded string with limit of 1024 characters.
        /// </param>
        /// <param name="dataConnector">
        /// Required. The
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector] to
        /// initialize in the newly created
        /// [Collection][google.cloud.discoveryengine.v1.Collection].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataConnector, SetUpDataConnectorMetadata>> SetUpDataConnectorAsync(LocationName parent, string collectionId, string collectionDisplayName, DataConnector dataConnector, gaxgrpc::CallSettings callSettings = null) =>
            SetUpDataConnectorAsync(new SetUpDataConnectorRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CollectionId = gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)),
                CollectionDisplayName = gax::GaxPreconditions.CheckNotNullOrEmpty(collectionDisplayName, nameof(collectionDisplayName)),
                DataConnector = gax::GaxPreconditions.CheckNotNull(dataConnector, nameof(dataConnector)),
            }, callSettings);

        /// <summary>
        /// Creates a [Collection][google.cloud.discoveryengine.v1.Collection] and sets
        /// up the [DataConnector][google.cloud.discoveryengine.v1.DataConnector] for
        /// it. To stop a
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector] after setup,
        /// use the
        /// [CollectionService.DeleteCollection][google.cloud.discoveryengine.v1.CollectionService.DeleteCollection]
        /// method.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of
        /// [Collection][google.cloud.discoveryengine.v1.Collection], in the format of
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="collectionId">
        /// Required. The ID to use for the
        /// [Collection][google.cloud.discoveryengine.v1.Collection], which will become
        /// the final component of the
        /// [Collection][google.cloud.discoveryengine.v1.Collection]'s resource name. A
        /// new [Collection][google.cloud.discoveryengine.v1.Collection] is created as
        /// part of the [DataConnector][google.cloud.discoveryengine.v1.DataConnector]
        /// setup. [DataConnector][google.cloud.discoveryengine.v1.DataConnector] is a
        /// singleton resource under
        /// [Collection][google.cloud.discoveryengine.v1.Collection], managing all
        /// [DataStore][google.cloud.discoveryengine.v1.DataStore]s of the
        /// [Collection][google.cloud.discoveryengine.v1.Collection].
        /// 
        /// Should conform to
        /// [RFC-1034](https://tools.ietf.org/html/rfc1034) standard with a length
        /// limit of 63 characters. Otherwise, an `INVALID_ARGUMENT` error is returned.
        /// </param>
        /// <param name="collectionDisplayName">
        /// Required. The display name of the
        /// [Collection][google.cloud.discoveryengine.v1.Collection].
        /// 
        /// Should be human readable, used to display collections in the Console
        /// Dashboard. UTF-8 encoded string with limit of 1024 characters.
        /// </param>
        /// <param name="dataConnector">
        /// Required. The
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector] to
        /// initialize in the newly created
        /// [Collection][google.cloud.discoveryengine.v1.Collection].
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataConnector, SetUpDataConnectorMetadata>> SetUpDataConnectorAsync(LocationName parent, string collectionId, string collectionDisplayName, DataConnector dataConnector, st::CancellationToken cancellationToken) =>
            SetUpDataConnectorAsync(parent, collectionId, collectionDisplayName, dataConnector, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the [DataConnector][google.cloud.discoveryengine.v1.DataConnector].
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector] is a
        /// singleton resource for each
        /// [Collection][google.cloud.discoveryengine.v1.Collection].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataConnector GetDataConnector(GetDataConnectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the [DataConnector][google.cloud.discoveryengine.v1.DataConnector].
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector] is a
        /// singleton resource for each
        /// [Collection][google.cloud.discoveryengine.v1.Collection].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataConnector> GetDataConnectorAsync(GetDataConnectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the [DataConnector][google.cloud.discoveryengine.v1.DataConnector].
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector] is a
        /// singleton resource for each
        /// [Collection][google.cloud.discoveryengine.v1.Collection].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataConnector> GetDataConnectorAsync(GetDataConnectorRequest request, st::CancellationToken cancellationToken) =>
            GetDataConnectorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the [DataConnector][google.cloud.discoveryengine.v1.DataConnector].
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector] is a
        /// singleton resource for each
        /// [Collection][google.cloud.discoveryengine.v1.Collection].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector], such as
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataConnector`.
        /// 
        /// If the caller does not have permission to access the
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector], regardless
        /// of whether or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// If the requested
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector] does not
        /// exist, a `NOT_FOUND` error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataConnector GetDataConnector(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataConnector(new GetDataConnectorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the [DataConnector][google.cloud.discoveryengine.v1.DataConnector].
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector] is a
        /// singleton resource for each
        /// [Collection][google.cloud.discoveryengine.v1.Collection].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector], such as
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataConnector`.
        /// 
        /// If the caller does not have permission to access the
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector], regardless
        /// of whether or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// If the requested
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector] does not
        /// exist, a `NOT_FOUND` error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataConnector> GetDataConnectorAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataConnectorAsync(new GetDataConnectorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the [DataConnector][google.cloud.discoveryengine.v1.DataConnector].
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector] is a
        /// singleton resource for each
        /// [Collection][google.cloud.discoveryengine.v1.Collection].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector], such as
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataConnector`.
        /// 
        /// If the caller does not have permission to access the
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector], regardless
        /// of whether or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// If the requested
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector] does not
        /// exist, a `NOT_FOUND` error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataConnector> GetDataConnectorAsync(string name, st::CancellationToken cancellationToken) =>
            GetDataConnectorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the [DataConnector][google.cloud.discoveryengine.v1.DataConnector].
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector] is a
        /// singleton resource for each
        /// [Collection][google.cloud.discoveryengine.v1.Collection].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector], such as
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataConnector`.
        /// 
        /// If the caller does not have permission to access the
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector], regardless
        /// of whether or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// If the requested
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector] does not
        /// exist, a `NOT_FOUND` error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataConnector GetDataConnector(DataConnectorName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataConnector(new GetDataConnectorRequest
            {
                DataConnectorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the [DataConnector][google.cloud.discoveryengine.v1.DataConnector].
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector] is a
        /// singleton resource for each
        /// [Collection][google.cloud.discoveryengine.v1.Collection].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector], such as
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataConnector`.
        /// 
        /// If the caller does not have permission to access the
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector], regardless
        /// of whether or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// If the requested
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector] does not
        /// exist, a `NOT_FOUND` error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataConnector> GetDataConnectorAsync(DataConnectorName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataConnectorAsync(new GetDataConnectorRequest
            {
                DataConnectorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the [DataConnector][google.cloud.discoveryengine.v1.DataConnector].
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector] is a
        /// singleton resource for each
        /// [Collection][google.cloud.discoveryengine.v1.Collection].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector], such as
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataConnector`.
        /// 
        /// If the caller does not have permission to access the
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector], regardless
        /// of whether or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// If the requested
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector] does not
        /// exist, a `NOT_FOUND` error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataConnector> GetDataConnectorAsync(DataConnectorName name, st::CancellationToken cancellationToken) =>
            GetDataConnectorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a [DataConnector][google.cloud.discoveryengine.v1.DataConnector].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataConnector UpdateDataConnector(UpdateDataConnectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a [DataConnector][google.cloud.discoveryengine.v1.DataConnector].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataConnector> UpdateDataConnectorAsync(UpdateDataConnectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a [DataConnector][google.cloud.discoveryengine.v1.DataConnector].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataConnector> UpdateDataConnectorAsync(UpdateDataConnectorRequest request, st::CancellationToken cancellationToken) =>
            UpdateDataConnectorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a [DataConnector][google.cloud.discoveryengine.v1.DataConnector].
        /// </summary>
        /// <param name="dataConnector">
        /// Required. The
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector] to update.
        /// 
        /// If the caller does not have permission to update the
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector], regardless
        /// of whether or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// If the [DataConnector][google.cloud.discoveryengine.v1.DataConnector] does
        /// not exist, a `NOT_FOUND` error is returned.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector] to update.
        /// 
        /// Supported field paths include:
        /// 
        /// - `refresh_interval`
        /// - `params`
        /// - `auto_run_disabled`
        /// - `action_config`
        /// - `action_config.action_params`
        /// - `action_config.service_name`
        /// - `destination_configs`
        /// - `blocking_reasons`
        /// - `sync_mode`
        /// - `incremental_sync_disabled`
        /// - `incremental_refresh_interval`
        /// - `data_protection_policy`
        /// 
        /// Note:  Support for these fields may vary depending on the connector type.
        /// For example, not all connectors support `destination_configs`.
        /// 
        /// If an unsupported or unknown field path is provided, the request will
        /// return an `INVALID_ARGUMENT` error.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataConnector UpdateDataConnector(DataConnector dataConnector, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataConnector(new UpdateDataConnectorRequest
            {
                DataConnector = gax::GaxPreconditions.CheckNotNull(dataConnector, nameof(dataConnector)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a [DataConnector][google.cloud.discoveryengine.v1.DataConnector].
        /// </summary>
        /// <param name="dataConnector">
        /// Required. The
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector] to update.
        /// 
        /// If the caller does not have permission to update the
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector], regardless
        /// of whether or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// If the [DataConnector][google.cloud.discoveryengine.v1.DataConnector] does
        /// not exist, a `NOT_FOUND` error is returned.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector] to update.
        /// 
        /// Supported field paths include:
        /// 
        /// - `refresh_interval`
        /// - `params`
        /// - `auto_run_disabled`
        /// - `action_config`
        /// - `action_config.action_params`
        /// - `action_config.service_name`
        /// - `destination_configs`
        /// - `blocking_reasons`
        /// - `sync_mode`
        /// - `incremental_sync_disabled`
        /// - `incremental_refresh_interval`
        /// - `data_protection_policy`
        /// 
        /// Note:  Support for these fields may vary depending on the connector type.
        /// For example, not all connectors support `destination_configs`.
        /// 
        /// If an unsupported or unknown field path is provided, the request will
        /// return an `INVALID_ARGUMENT` error.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataConnector> UpdateDataConnectorAsync(DataConnector dataConnector, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataConnectorAsync(new UpdateDataConnectorRequest
            {
                DataConnector = gax::GaxPreconditions.CheckNotNull(dataConnector, nameof(dataConnector)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a [DataConnector][google.cloud.discoveryengine.v1.DataConnector].
        /// </summary>
        /// <param name="dataConnector">
        /// Required. The
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector] to update.
        /// 
        /// If the caller does not have permission to update the
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector], regardless
        /// of whether or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// If the [DataConnector][google.cloud.discoveryengine.v1.DataConnector] does
        /// not exist, a `NOT_FOUND` error is returned.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector] to update.
        /// 
        /// Supported field paths include:
        /// 
        /// - `refresh_interval`
        /// - `params`
        /// - `auto_run_disabled`
        /// - `action_config`
        /// - `action_config.action_params`
        /// - `action_config.service_name`
        /// - `destination_configs`
        /// - `blocking_reasons`
        /// - `sync_mode`
        /// - `incremental_sync_disabled`
        /// - `incremental_refresh_interval`
        /// - `data_protection_policy`
        /// 
        /// Note:  Support for these fields may vary depending on the connector type.
        /// For example, not all connectors support `destination_configs`.
        /// 
        /// If an unsupported or unknown field path is provided, the request will
        /// return an `INVALID_ARGUMENT` error.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataConnector> UpdateDataConnectorAsync(DataConnector dataConnector, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDataConnectorAsync(dataConnector, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>DataConnectorService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for data connector management.
    /// </remarks>
    public sealed partial class DataConnectorServiceClientImpl : DataConnectorServiceClient
    {
        private readonly gaxgrpc::ApiCall<SetUpDataConnectorRequest, lro::Operation> _callSetUpDataConnector;

        private readonly gaxgrpc::ApiCall<GetDataConnectorRequest, DataConnector> _callGetDataConnector;

        private readonly gaxgrpc::ApiCall<UpdateDataConnectorRequest, DataConnector> _callUpdateDataConnector;

        /// <summary>
        /// Constructs a client wrapper for the DataConnectorService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DataConnectorServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DataConnectorServiceClientImpl(DataConnectorService.DataConnectorServiceClient grpcClient, DataConnectorServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DataConnectorServiceSettings effectiveSettings = settings ?? DataConnectorServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            SetUpDataConnectorOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.SetUpDataConnectorOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callSetUpDataConnector = clientHelper.BuildApiCall<SetUpDataConnectorRequest, lro::Operation>("SetUpDataConnector", grpcClient.SetUpDataConnectorAsync, grpcClient.SetUpDataConnector, effectiveSettings.SetUpDataConnectorSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callSetUpDataConnector);
            Modify_SetUpDataConnectorApiCall(ref _callSetUpDataConnector);
            _callGetDataConnector = clientHelper.BuildApiCall<GetDataConnectorRequest, DataConnector>("GetDataConnector", grpcClient.GetDataConnectorAsync, grpcClient.GetDataConnector, effectiveSettings.GetDataConnectorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDataConnector);
            Modify_GetDataConnectorApiCall(ref _callGetDataConnector);
            _callUpdateDataConnector = clientHelper.BuildApiCall<UpdateDataConnectorRequest, DataConnector>("UpdateDataConnector", grpcClient.UpdateDataConnectorAsync, grpcClient.UpdateDataConnector, effectiveSettings.UpdateDataConnectorSettings).WithGoogleRequestParam("data_connector.name", request => request.DataConnector?.Name);
            Modify_ApiCall(ref _callUpdateDataConnector);
            Modify_UpdateDataConnectorApiCall(ref _callUpdateDataConnector);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_SetUpDataConnectorApiCall(ref gaxgrpc::ApiCall<SetUpDataConnectorRequest, lro::Operation> call);

        partial void Modify_GetDataConnectorApiCall(ref gaxgrpc::ApiCall<GetDataConnectorRequest, DataConnector> call);

        partial void Modify_UpdateDataConnectorApiCall(ref gaxgrpc::ApiCall<UpdateDataConnectorRequest, DataConnector> call);

        partial void OnConstruction(DataConnectorService.DataConnectorServiceClient grpcClient, DataConnectorServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DataConnectorService client</summary>
        public override DataConnectorService.DataConnectorServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_SetUpDataConnectorRequest(ref SetUpDataConnectorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDataConnectorRequest(ref GetDataConnectorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDataConnectorRequest(ref UpdateDataConnectorRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>SetUpDataConnector</c>.</summary>
        public override lro::OperationsClient SetUpDataConnectorOperationsClient { get; }

        /// <summary>
        /// Creates a [Collection][google.cloud.discoveryengine.v1.Collection] and sets
        /// up the [DataConnector][google.cloud.discoveryengine.v1.DataConnector] for
        /// it. To stop a
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector] after setup,
        /// use the
        /// [CollectionService.DeleteCollection][google.cloud.discoveryengine.v1.CollectionService.DeleteCollection]
        /// method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DataConnector, SetUpDataConnectorMetadata> SetUpDataConnector(SetUpDataConnectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetUpDataConnectorRequest(ref request, ref callSettings);
            return new lro::Operation<DataConnector, SetUpDataConnectorMetadata>(_callSetUpDataConnector.Sync(request, callSettings), SetUpDataConnectorOperationsClient);
        }

        /// <summary>
        /// Creates a [Collection][google.cloud.discoveryengine.v1.Collection] and sets
        /// up the [DataConnector][google.cloud.discoveryengine.v1.DataConnector] for
        /// it. To stop a
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector] after setup,
        /// use the
        /// [CollectionService.DeleteCollection][google.cloud.discoveryengine.v1.CollectionService.DeleteCollection]
        /// method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DataConnector, SetUpDataConnectorMetadata>> SetUpDataConnectorAsync(SetUpDataConnectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetUpDataConnectorRequest(ref request, ref callSettings);
            return new lro::Operation<DataConnector, SetUpDataConnectorMetadata>(await _callSetUpDataConnector.Async(request, callSettings).ConfigureAwait(false), SetUpDataConnectorOperationsClient);
        }

        /// <summary>
        /// Gets the [DataConnector][google.cloud.discoveryengine.v1.DataConnector].
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector] is a
        /// singleton resource for each
        /// [Collection][google.cloud.discoveryengine.v1.Collection].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataConnector GetDataConnector(GetDataConnectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataConnectorRequest(ref request, ref callSettings);
            return _callGetDataConnector.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the [DataConnector][google.cloud.discoveryengine.v1.DataConnector].
        /// [DataConnector][google.cloud.discoveryengine.v1.DataConnector] is a
        /// singleton resource for each
        /// [Collection][google.cloud.discoveryengine.v1.Collection].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataConnector> GetDataConnectorAsync(GetDataConnectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataConnectorRequest(ref request, ref callSettings);
            return _callGetDataConnector.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a [DataConnector][google.cloud.discoveryengine.v1.DataConnector].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataConnector UpdateDataConnector(UpdateDataConnectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataConnectorRequest(ref request, ref callSettings);
            return _callUpdateDataConnector.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a [DataConnector][google.cloud.discoveryengine.v1.DataConnector].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataConnector> UpdateDataConnectorAsync(UpdateDataConnectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataConnectorRequest(ref request, ref callSettings);
            return _callUpdateDataConnector.Async(request, callSettings);
        }
    }

    public static partial class DataConnectorService
    {
        public partial class DataConnectorServiceClient
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

    public static partial class DataConnectorService
    {
        public partial class DataConnectorServiceClient
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
