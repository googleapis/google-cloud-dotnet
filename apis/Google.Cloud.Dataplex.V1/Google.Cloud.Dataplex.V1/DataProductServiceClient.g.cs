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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gciv = Google.Cloud.Iam.V1;
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

namespace Google.Cloud.Dataplex.V1
{
    /// <summary>Settings for <see cref="DataProductServiceClient"/> instances.</summary>
    public sealed partial class DataProductServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DataProductServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DataProductServiceSettings"/>.</returns>
        public static DataProductServiceSettings GetDefault() => new DataProductServiceSettings();

        /// <summary>Constructs a new <see cref="DataProductServiceSettings"/> object with default settings.</summary>
        public DataProductServiceSettings()
        {
        }

        private DataProductServiceSettings(DataProductServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateDataProductSettings = existing.CreateDataProductSettings;
            CreateDataProductOperationsSettings = existing.CreateDataProductOperationsSettings.Clone();
            DeleteDataProductSettings = existing.DeleteDataProductSettings;
            DeleteDataProductOperationsSettings = existing.DeleteDataProductOperationsSettings.Clone();
            GetDataProductSettings = existing.GetDataProductSettings;
            ListDataProductsSettings = existing.ListDataProductsSettings;
            UpdateDataProductSettings = existing.UpdateDataProductSettings;
            UpdateDataProductOperationsSettings = existing.UpdateDataProductOperationsSettings.Clone();
            CreateDataAssetSettings = existing.CreateDataAssetSettings;
            CreateDataAssetOperationsSettings = existing.CreateDataAssetOperationsSettings.Clone();
            UpdateDataAssetSettings = existing.UpdateDataAssetSettings;
            UpdateDataAssetOperationsSettings = existing.UpdateDataAssetOperationsSettings.Clone();
            DeleteDataAssetSettings = existing.DeleteDataAssetSettings;
            DeleteDataAssetOperationsSettings = existing.DeleteDataAssetOperationsSettings.Clone();
            GetDataAssetSettings = existing.GetDataAssetSettings;
            ListDataAssetsSettings = existing.ListDataAssetsSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(DataProductServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataProductServiceClient.CreateDataProduct</c> and <c>DataProductServiceClient.CreateDataProductAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDataProductSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataProductServiceClient.CreateDataProduct</c> and
        /// <c>DataProductServiceClient.CreateDataProductAsync</c>.
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
        public lro::OperationsSettings CreateDataProductOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataProductServiceClient.DeleteDataProduct</c> and <c>DataProductServiceClient.DeleteDataProductAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDataProductSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataProductServiceClient.DeleteDataProduct</c> and
        /// <c>DataProductServiceClient.DeleteDataProductAsync</c>.
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
        public lro::OperationsSettings DeleteDataProductOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataProductServiceClient.GetDataProduct</c> and <c>DataProductServiceClient.GetDataProductAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDataProductSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataProductServiceClient.ListDataProducts</c> and <c>DataProductServiceClient.ListDataProductsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDataProductsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataProductServiceClient.UpdateDataProduct</c> and <c>DataProductServiceClient.UpdateDataProductAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDataProductSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataProductServiceClient.UpdateDataProduct</c> and
        /// <c>DataProductServiceClient.UpdateDataProductAsync</c>.
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
        public lro::OperationsSettings UpdateDataProductOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataProductServiceClient.CreateDataAsset</c> and <c>DataProductServiceClient.CreateDataAssetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDataAssetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataProductServiceClient.CreateDataAsset</c> and
        /// <c>DataProductServiceClient.CreateDataAssetAsync</c>.
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
        public lro::OperationsSettings CreateDataAssetOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataProductServiceClient.UpdateDataAsset</c> and <c>DataProductServiceClient.UpdateDataAssetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDataAssetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataProductServiceClient.UpdateDataAsset</c> and
        /// <c>DataProductServiceClient.UpdateDataAssetAsync</c>.
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
        public lro::OperationsSettings UpdateDataAssetOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataProductServiceClient.DeleteDataAsset</c> and <c>DataProductServiceClient.DeleteDataAssetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDataAssetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataProductServiceClient.DeleteDataAsset</c> and
        /// <c>DataProductServiceClient.DeleteDataAssetAsync</c>.
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
        public lro::OperationsSettings DeleteDataAssetOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataProductServiceClient.GetDataAsset</c> and <c>DataProductServiceClient.GetDataAssetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDataAssetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataProductServiceClient.ListDataAssets</c> and <c>DataProductServiceClient.ListDataAssetsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDataAssetsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DataProductServiceSettings"/> object.</returns>
        public DataProductServiceSettings Clone() => new DataProductServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DataProductServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class DataProductServiceClientBuilder : gaxgrpc::ClientBuilderBase<DataProductServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DataProductServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DataProductServiceClientBuilder() : base(DataProductServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DataProductServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DataProductServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DataProductServiceClient Build()
        {
            DataProductServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DataProductServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DataProductServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DataProductServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DataProductServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DataProductServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DataProductServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DataProductServiceClient.ChannelPool;
    }

    /// <summary>DataProductService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// `DataProductService` provides APIs for managing data products and
    /// the underlying data assets.
    /// </remarks>
    public abstract partial class DataProductServiceClient
    {
        /// <summary>
        /// The default endpoint for the DataProductService service, which is a host of "dataplex.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dataplex.googleapis.com:443";

        /// <summary>The default DataProductService scopes.</summary>
        /// <remarks>
        /// The default DataProductService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DataProductService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DataProductServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DataProductServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DataProductServiceClient"/>.</returns>
        public static stt::Task<DataProductServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DataProductServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DataProductServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DataProductServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="DataProductServiceClient"/>.</returns>
        public static DataProductServiceClient Create() => new DataProductServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DataProductServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DataProductServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DataProductServiceClient"/>.</returns>
        internal static DataProductServiceClient Create(grpccore::CallInvoker callInvoker, DataProductServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DataProductService.DataProductServiceClient grpcClient = new DataProductService.DataProductServiceClient(callInvoker);
            return new DataProductServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DataProductService client</summary>
        public virtual DataProductService.DataProductServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a data product.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataProduct, OperationMetadata> CreateDataProduct(CreateDataProductRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a data product.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataProduct, OperationMetadata>> CreateDataProductAsync(CreateDataProductRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a data product.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataProduct, OperationMetadata>> CreateDataProductAsync(CreateDataProductRequest request, st::CancellationToken cancellationToken) =>
            CreateDataProductAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateDataProduct</c>.</summary>
        public virtual lro::OperationsClient CreateDataProductOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateDataProduct</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DataProduct, OperationMetadata> PollOnceCreateDataProduct(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DataProduct, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDataProductOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateDataProduct</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DataProduct, OperationMetadata>> PollOnceCreateDataProductAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DataProduct, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDataProductOperationsClient, callSettings);

        /// <summary>
        /// Creates a data product.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this data product will be created.
        /// Format: projects/{project_id_or_number}/locations/{location_id}
        /// </param>
        /// <param name="dataProduct">
        /// Required. The data product to create.
        /// </param>
        /// <param name="dataProductId">
        /// Optional. The ID of the data product to create.
        /// 
        /// The ID must conform to RFC-1034 and contain only lower-case letters (a-z),
        /// numbers (0-9), or hyphens, with the first character a letter, the last a
        /// letter or a number, and a 63 character maximum. Characters outside of
        /// ASCII are not permitted.
        /// Valid format regex: `^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$`
        /// If not provided, a system generated ID will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataProduct, OperationMetadata> CreateDataProduct(string parent, DataProduct dataProduct, string dataProductId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataProduct(new CreateDataProductRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DataProductId = dataProductId ?? "",
                DataProduct = gax::GaxPreconditions.CheckNotNull(dataProduct, nameof(dataProduct)),
            }, callSettings);

        /// <summary>
        /// Creates a data product.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this data product will be created.
        /// Format: projects/{project_id_or_number}/locations/{location_id}
        /// </param>
        /// <param name="dataProduct">
        /// Required. The data product to create.
        /// </param>
        /// <param name="dataProductId">
        /// Optional. The ID of the data product to create.
        /// 
        /// The ID must conform to RFC-1034 and contain only lower-case letters (a-z),
        /// numbers (0-9), or hyphens, with the first character a letter, the last a
        /// letter or a number, and a 63 character maximum. Characters outside of
        /// ASCII are not permitted.
        /// Valid format regex: `^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$`
        /// If not provided, a system generated ID will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataProduct, OperationMetadata>> CreateDataProductAsync(string parent, DataProduct dataProduct, string dataProductId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataProductAsync(new CreateDataProductRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DataProductId = dataProductId ?? "",
                DataProduct = gax::GaxPreconditions.CheckNotNull(dataProduct, nameof(dataProduct)),
            }, callSettings);

        /// <summary>
        /// Creates a data product.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this data product will be created.
        /// Format: projects/{project_id_or_number}/locations/{location_id}
        /// </param>
        /// <param name="dataProduct">
        /// Required. The data product to create.
        /// </param>
        /// <param name="dataProductId">
        /// Optional. The ID of the data product to create.
        /// 
        /// The ID must conform to RFC-1034 and contain only lower-case letters (a-z),
        /// numbers (0-9), or hyphens, with the first character a letter, the last a
        /// letter or a number, and a 63 character maximum. Characters outside of
        /// ASCII are not permitted.
        /// Valid format regex: `^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$`
        /// If not provided, a system generated ID will be used.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataProduct, OperationMetadata>> CreateDataProductAsync(string parent, DataProduct dataProduct, string dataProductId, st::CancellationToken cancellationToken) =>
            CreateDataProductAsync(parent, dataProduct, dataProductId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a data product.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this data product will be created.
        /// Format: projects/{project_id_or_number}/locations/{location_id}
        /// </param>
        /// <param name="dataProduct">
        /// Required. The data product to create.
        /// </param>
        /// <param name="dataProductId">
        /// Optional. The ID of the data product to create.
        /// 
        /// The ID must conform to RFC-1034 and contain only lower-case letters (a-z),
        /// numbers (0-9), or hyphens, with the first character a letter, the last a
        /// letter or a number, and a 63 character maximum. Characters outside of
        /// ASCII are not permitted.
        /// Valid format regex: `^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$`
        /// If not provided, a system generated ID will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataProduct, OperationMetadata> CreateDataProduct(gagr::LocationName parent, DataProduct dataProduct, string dataProductId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataProduct(new CreateDataProductRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DataProductId = dataProductId ?? "",
                DataProduct = gax::GaxPreconditions.CheckNotNull(dataProduct, nameof(dataProduct)),
            }, callSettings);

        /// <summary>
        /// Creates a data product.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this data product will be created.
        /// Format: projects/{project_id_or_number}/locations/{location_id}
        /// </param>
        /// <param name="dataProduct">
        /// Required. The data product to create.
        /// </param>
        /// <param name="dataProductId">
        /// Optional. The ID of the data product to create.
        /// 
        /// The ID must conform to RFC-1034 and contain only lower-case letters (a-z),
        /// numbers (0-9), or hyphens, with the first character a letter, the last a
        /// letter or a number, and a 63 character maximum. Characters outside of
        /// ASCII are not permitted.
        /// Valid format regex: `^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$`
        /// If not provided, a system generated ID will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataProduct, OperationMetadata>> CreateDataProductAsync(gagr::LocationName parent, DataProduct dataProduct, string dataProductId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataProductAsync(new CreateDataProductRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DataProductId = dataProductId ?? "",
                DataProduct = gax::GaxPreconditions.CheckNotNull(dataProduct, nameof(dataProduct)),
            }, callSettings);

        /// <summary>
        /// Creates a data product.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this data product will be created.
        /// Format: projects/{project_id_or_number}/locations/{location_id}
        /// </param>
        /// <param name="dataProduct">
        /// Required. The data product to create.
        /// </param>
        /// <param name="dataProductId">
        /// Optional. The ID of the data product to create.
        /// 
        /// The ID must conform to RFC-1034 and contain only lower-case letters (a-z),
        /// numbers (0-9), or hyphens, with the first character a letter, the last a
        /// letter or a number, and a 63 character maximum. Characters outside of
        /// ASCII are not permitted.
        /// Valid format regex: `^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$`
        /// If not provided, a system generated ID will be used.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataProduct, OperationMetadata>> CreateDataProductAsync(gagr::LocationName parent, DataProduct dataProduct, string dataProductId, st::CancellationToken cancellationToken) =>
            CreateDataProductAsync(parent, dataProduct, dataProductId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a data product. The deletion will fail if the data product is not
        /// empty (i.e. contains at least one data asset).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDataProduct(DeleteDataProductRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a data product. The deletion will fail if the data product is not
        /// empty (i.e. contains at least one data asset).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataProductAsync(DeleteDataProductRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a data product. The deletion will fail if the data product is not
        /// empty (i.e. contains at least one data asset).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataProductAsync(DeleteDataProductRequest request, st::CancellationToken cancellationToken) =>
            DeleteDataProductAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteDataProduct</c>.</summary>
        public virtual lro::OperationsClient DeleteDataProductOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteDataProduct</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteDataProduct(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDataProductOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteDataProduct</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteDataProductAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDataProductOperationsClient, callSettings);

        /// <summary>
        /// Deletes a data product. The deletion will fail if the data product is not
        /// empty (i.e. contains at least one data asset).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data product to delete.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/dataProducts/{data_product_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDataProduct(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataProduct(new DeleteDataProductRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a data product. The deletion will fail if the data product is not
        /// empty (i.e. contains at least one data asset).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data product to delete.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/dataProducts/{data_product_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataProductAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataProductAsync(new DeleteDataProductRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a data product. The deletion will fail if the data product is not
        /// empty (i.e. contains at least one data asset).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data product to delete.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/dataProducts/{data_product_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataProductAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDataProductAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a data product. The deletion will fail if the data product is not
        /// empty (i.e. contains at least one data asset).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data product to delete.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/dataProducts/{data_product_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDataProduct(DataProductName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataProduct(new DeleteDataProductRequest
            {
                DataProductName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a data product. The deletion will fail if the data product is not
        /// empty (i.e. contains at least one data asset).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data product to delete.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/dataProducts/{data_product_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataProductAsync(DataProductName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataProductAsync(new DeleteDataProductRequest
            {
                DataProductName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a data product. The deletion will fail if the data product is not
        /// empty (i.e. contains at least one data asset).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data product to delete.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/dataProducts/{data_product_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataProductAsync(DataProductName name, st::CancellationToken cancellationToken) =>
            DeleteDataProductAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a data product.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataProduct GetDataProduct(GetDataProductRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a data product.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataProduct> GetDataProductAsync(GetDataProductRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a data product.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataProduct> GetDataProductAsync(GetDataProductRequest request, st::CancellationToken cancellationToken) =>
            GetDataProductAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a data product.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data product to retrieve.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/dataProducts/{data_product_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataProduct GetDataProduct(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataProduct(new GetDataProductRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a data product.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data product to retrieve.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/dataProducts/{data_product_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataProduct> GetDataProductAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataProductAsync(new GetDataProductRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a data product.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data product to retrieve.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/dataProducts/{data_product_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataProduct> GetDataProductAsync(string name, st::CancellationToken cancellationToken) =>
            GetDataProductAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a data product.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data product to retrieve.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/dataProducts/{data_product_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataProduct GetDataProduct(DataProductName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataProduct(new GetDataProductRequest
            {
                DataProductName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a data product.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data product to retrieve.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/dataProducts/{data_product_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataProduct> GetDataProductAsync(DataProductName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataProductAsync(new GetDataProductRequest
            {
                DataProductName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a data product.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data product to retrieve.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/dataProducts/{data_product_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataProduct> GetDataProductAsync(DataProductName name, st::CancellationToken cancellationToken) =>
            GetDataProductAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists data products for a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataProduct"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataProductsResponse, DataProduct> ListDataProducts(ListDataProductsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists data products for a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataProduct"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataProductsResponse, DataProduct> ListDataProductsAsync(ListDataProductsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists data products for a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which has this collection of data products.
        /// 
        /// Format: `projects/{project_id_or_number}/locations/{location_id}`.
        /// 
        /// Supports listing across all locations with the wildcard `-` (hyphen)
        /// character. Example: `projects/{project_id_or_number}/locations/-`
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
        /// <returns>A pageable sequence of <see cref="DataProduct"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataProductsResponse, DataProduct> ListDataProducts(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataProductsRequest request = new ListDataProductsRequest
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
            return ListDataProducts(request, callSettings);
        }

        /// <summary>
        /// Lists data products for a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which has this collection of data products.
        /// 
        /// Format: `projects/{project_id_or_number}/locations/{location_id}`.
        /// 
        /// Supports listing across all locations with the wildcard `-` (hyphen)
        /// character. Example: `projects/{project_id_or_number}/locations/-`
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataProduct"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataProductsResponse, DataProduct> ListDataProductsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataProductsRequest request = new ListDataProductsRequest
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
            return ListDataProductsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists data products for a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which has this collection of data products.
        /// 
        /// Format: `projects/{project_id_or_number}/locations/{location_id}`.
        /// 
        /// Supports listing across all locations with the wildcard `-` (hyphen)
        /// character. Example: `projects/{project_id_or_number}/locations/-`
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
        /// <returns>A pageable sequence of <see cref="DataProduct"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataProductsResponse, DataProduct> ListDataProducts(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataProductsRequest request = new ListDataProductsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDataProducts(request, callSettings);
        }

        /// <summary>
        /// Lists data products for a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which has this collection of data products.
        /// 
        /// Format: `projects/{project_id_or_number}/locations/{location_id}`.
        /// 
        /// Supports listing across all locations with the wildcard `-` (hyphen)
        /// character. Example: `projects/{project_id_or_number}/locations/-`
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataProduct"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataProductsResponse, DataProduct> ListDataProductsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataProductsRequest request = new ListDataProductsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDataProductsAsync(request, callSettings);
        }

        /// <summary>
        /// Updates a data product.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataProduct, OperationMetadata> UpdateDataProduct(UpdateDataProductRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a data product.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataProduct, OperationMetadata>> UpdateDataProductAsync(UpdateDataProductRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a data product.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataProduct, OperationMetadata>> UpdateDataProductAsync(UpdateDataProductRequest request, st::CancellationToken cancellationToken) =>
            UpdateDataProductAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateDataProduct</c>.</summary>
        public virtual lro::OperationsClient UpdateDataProductOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateDataProduct</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DataProduct, OperationMetadata> PollOnceUpdateDataProduct(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DataProduct, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDataProductOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateDataProduct</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DataProduct, OperationMetadata>> PollOnceUpdateDataProductAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DataProduct, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDataProductOperationsClient, callSettings);

        /// <summary>
        /// Updates a data product.
        /// </summary>
        /// <param name="dataProduct">
        /// Required. The data product to update.
        /// The data product's `name` field is used to identify the data product to
        /// update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// If this is empty or not set, then all the fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataProduct, OperationMetadata> UpdateDataProduct(DataProduct dataProduct, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataProduct(new UpdateDataProductRequest
            {
                DataProduct = gax::GaxPreconditions.CheckNotNull(dataProduct, nameof(dataProduct)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a data product.
        /// </summary>
        /// <param name="dataProduct">
        /// Required. The data product to update.
        /// The data product's `name` field is used to identify the data product to
        /// update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// If this is empty or not set, then all the fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataProduct, OperationMetadata>> UpdateDataProductAsync(DataProduct dataProduct, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataProductAsync(new UpdateDataProductRequest
            {
                DataProduct = gax::GaxPreconditions.CheckNotNull(dataProduct, nameof(dataProduct)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a data product.
        /// </summary>
        /// <param name="dataProduct">
        /// Required. The data product to update.
        /// The data product's `name` field is used to identify the data product to
        /// update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// If this is empty or not set, then all the fields will be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataProduct, OperationMetadata>> UpdateDataProductAsync(DataProduct dataProduct, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDataProductAsync(dataProduct, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a data asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataAsset, OperationMetadata> CreateDataAsset(CreateDataAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a data asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataAsset, OperationMetadata>> CreateDataAssetAsync(CreateDataAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a data asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataAsset, OperationMetadata>> CreateDataAssetAsync(CreateDataAssetRequest request, st::CancellationToken cancellationToken) =>
            CreateDataAssetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateDataAsset</c>.</summary>
        public virtual lro::OperationsClient CreateDataAssetOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateDataAsset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DataAsset, OperationMetadata> PollOnceCreateDataAsset(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DataAsset, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDataAssetOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateDataAsset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DataAsset, OperationMetadata>> PollOnceCreateDataAssetAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DataAsset, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDataAssetOperationsClient, callSettings);

        /// <summary>
        /// Creates a data asset.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this data asset will be created.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/dataProducts/{data_product_id}
        /// </param>
        /// <param name="dataAsset">
        /// Required. The data asset to create.
        /// </param>
        /// <param name="dataAssetId">
        /// Optional. The ID of the data asset to create.
        /// 
        /// The ID must conform to RFC-1034 and contain only lower-case letters (a-z),
        /// numbers (0-9), or hyphens, with the first character a letter, the last a
        /// letter or a number, and a 63 character maximum. Characters outside of
        /// ASCII are not permitted.
        /// Valid format regex: `^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$`
        /// If not provided, a system generated ID will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataAsset, OperationMetadata> CreateDataAsset(string parent, DataAsset dataAsset, string dataAssetId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataAsset(new CreateDataAssetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DataAssetId = dataAssetId ?? "",
                DataAsset = gax::GaxPreconditions.CheckNotNull(dataAsset, nameof(dataAsset)),
            }, callSettings);

        /// <summary>
        /// Creates a data asset.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this data asset will be created.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/dataProducts/{data_product_id}
        /// </param>
        /// <param name="dataAsset">
        /// Required. The data asset to create.
        /// </param>
        /// <param name="dataAssetId">
        /// Optional. The ID of the data asset to create.
        /// 
        /// The ID must conform to RFC-1034 and contain only lower-case letters (a-z),
        /// numbers (0-9), or hyphens, with the first character a letter, the last a
        /// letter or a number, and a 63 character maximum. Characters outside of
        /// ASCII are not permitted.
        /// Valid format regex: `^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$`
        /// If not provided, a system generated ID will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataAsset, OperationMetadata>> CreateDataAssetAsync(string parent, DataAsset dataAsset, string dataAssetId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataAssetAsync(new CreateDataAssetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DataAssetId = dataAssetId ?? "",
                DataAsset = gax::GaxPreconditions.CheckNotNull(dataAsset, nameof(dataAsset)),
            }, callSettings);

        /// <summary>
        /// Creates a data asset.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this data asset will be created.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/dataProducts/{data_product_id}
        /// </param>
        /// <param name="dataAsset">
        /// Required. The data asset to create.
        /// </param>
        /// <param name="dataAssetId">
        /// Optional. The ID of the data asset to create.
        /// 
        /// The ID must conform to RFC-1034 and contain only lower-case letters (a-z),
        /// numbers (0-9), or hyphens, with the first character a letter, the last a
        /// letter or a number, and a 63 character maximum. Characters outside of
        /// ASCII are not permitted.
        /// Valid format regex: `^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$`
        /// If not provided, a system generated ID will be used.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataAsset, OperationMetadata>> CreateDataAssetAsync(string parent, DataAsset dataAsset, string dataAssetId, st::CancellationToken cancellationToken) =>
            CreateDataAssetAsync(parent, dataAsset, dataAssetId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a data asset.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this data asset will be created.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/dataProducts/{data_product_id}
        /// </param>
        /// <param name="dataAsset">
        /// Required. The data asset to create.
        /// </param>
        /// <param name="dataAssetId">
        /// Optional. The ID of the data asset to create.
        /// 
        /// The ID must conform to RFC-1034 and contain only lower-case letters (a-z),
        /// numbers (0-9), or hyphens, with the first character a letter, the last a
        /// letter or a number, and a 63 character maximum. Characters outside of
        /// ASCII are not permitted.
        /// Valid format regex: `^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$`
        /// If not provided, a system generated ID will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataAsset, OperationMetadata> CreateDataAsset(DataProductName parent, DataAsset dataAsset, string dataAssetId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataAsset(new CreateDataAssetRequest
            {
                ParentAsDataProductName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DataAssetId = dataAssetId ?? "",
                DataAsset = gax::GaxPreconditions.CheckNotNull(dataAsset, nameof(dataAsset)),
            }, callSettings);

        /// <summary>
        /// Creates a data asset.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this data asset will be created.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/dataProducts/{data_product_id}
        /// </param>
        /// <param name="dataAsset">
        /// Required. The data asset to create.
        /// </param>
        /// <param name="dataAssetId">
        /// Optional. The ID of the data asset to create.
        /// 
        /// The ID must conform to RFC-1034 and contain only lower-case letters (a-z),
        /// numbers (0-9), or hyphens, with the first character a letter, the last a
        /// letter or a number, and a 63 character maximum. Characters outside of
        /// ASCII are not permitted.
        /// Valid format regex: `^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$`
        /// If not provided, a system generated ID will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataAsset, OperationMetadata>> CreateDataAssetAsync(DataProductName parent, DataAsset dataAsset, string dataAssetId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataAssetAsync(new CreateDataAssetRequest
            {
                ParentAsDataProductName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DataAssetId = dataAssetId ?? "",
                DataAsset = gax::GaxPreconditions.CheckNotNull(dataAsset, nameof(dataAsset)),
            }, callSettings);

        /// <summary>
        /// Creates a data asset.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this data asset will be created.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/dataProducts/{data_product_id}
        /// </param>
        /// <param name="dataAsset">
        /// Required. The data asset to create.
        /// </param>
        /// <param name="dataAssetId">
        /// Optional. The ID of the data asset to create.
        /// 
        /// The ID must conform to RFC-1034 and contain only lower-case letters (a-z),
        /// numbers (0-9), or hyphens, with the first character a letter, the last a
        /// letter or a number, and a 63 character maximum. Characters outside of
        /// ASCII are not permitted.
        /// Valid format regex: `^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$`
        /// If not provided, a system generated ID will be used.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataAsset, OperationMetadata>> CreateDataAssetAsync(DataProductName parent, DataAsset dataAsset, string dataAssetId, st::CancellationToken cancellationToken) =>
            CreateDataAssetAsync(parent, dataAsset, dataAssetId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a data asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataAsset, OperationMetadata> UpdateDataAsset(UpdateDataAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a data asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataAsset, OperationMetadata>> UpdateDataAssetAsync(UpdateDataAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a data asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataAsset, OperationMetadata>> UpdateDataAssetAsync(UpdateDataAssetRequest request, st::CancellationToken cancellationToken) =>
            UpdateDataAssetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateDataAsset</c>.</summary>
        public virtual lro::OperationsClient UpdateDataAssetOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateDataAsset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DataAsset, OperationMetadata> PollOnceUpdateDataAsset(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DataAsset, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDataAssetOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateDataAsset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DataAsset, OperationMetadata>> PollOnceUpdateDataAssetAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DataAsset, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDataAssetOperationsClient, callSettings);

        /// <summary>
        /// Updates a data asset.
        /// </summary>
        /// <param name="dataAsset">
        /// Required. The data asset to update.
        /// The data asset's `name` field is used to identify the data asset to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// If this is empty or not set, then all the fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataAsset, OperationMetadata> UpdateDataAsset(DataAsset dataAsset, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataAsset(new UpdateDataAssetRequest
            {
                DataAsset = gax::GaxPreconditions.CheckNotNull(dataAsset, nameof(dataAsset)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a data asset.
        /// </summary>
        /// <param name="dataAsset">
        /// Required. The data asset to update.
        /// The data asset's `name` field is used to identify the data asset to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// If this is empty or not set, then all the fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataAsset, OperationMetadata>> UpdateDataAssetAsync(DataAsset dataAsset, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataAssetAsync(new UpdateDataAssetRequest
            {
                DataAsset = gax::GaxPreconditions.CheckNotNull(dataAsset, nameof(dataAsset)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a data asset.
        /// </summary>
        /// <param name="dataAsset">
        /// Required. The data asset to update.
        /// The data asset's `name` field is used to identify the data asset to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// If this is empty or not set, then all the fields will be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataAsset, OperationMetadata>> UpdateDataAssetAsync(DataAsset dataAsset, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDataAssetAsync(dataAsset, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a data asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDataAsset(DeleteDataAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a data asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataAssetAsync(DeleteDataAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a data asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataAssetAsync(DeleteDataAssetRequest request, st::CancellationToken cancellationToken) =>
            DeleteDataAssetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteDataAsset</c>.</summary>
        public virtual lro::OperationsClient DeleteDataAssetOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteDataAsset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteDataAsset(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDataAssetOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteDataAsset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteDataAssetAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDataAssetOperationsClient, callSettings);

        /// <summary>
        /// Deletes a data asset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data asset to delete.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/dataProducts/{data_product_id}/dataAssets/{data_asset_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDataAsset(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataAsset(new DeleteDataAssetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a data asset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data asset to delete.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/dataProducts/{data_product_id}/dataAssets/{data_asset_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataAssetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataAssetAsync(new DeleteDataAssetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a data asset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data asset to delete.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/dataProducts/{data_product_id}/dataAssets/{data_asset_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataAssetAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDataAssetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a data asset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data asset to delete.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/dataProducts/{data_product_id}/dataAssets/{data_asset_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDataAsset(DataAssetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataAsset(new DeleteDataAssetRequest
            {
                DataAssetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a data asset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data asset to delete.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/dataProducts/{data_product_id}/dataAssets/{data_asset_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataAssetAsync(DataAssetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataAssetAsync(new DeleteDataAssetRequest
            {
                DataAssetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a data asset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data asset to delete.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/dataProducts/{data_product_id}/dataAssets/{data_asset_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataAssetAsync(DataAssetName name, st::CancellationToken cancellationToken) =>
            DeleteDataAssetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a data asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataAsset GetDataAsset(GetDataAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a data asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAsset> GetDataAssetAsync(GetDataAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a data asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAsset> GetDataAssetAsync(GetDataAssetRequest request, st::CancellationToken cancellationToken) =>
            GetDataAssetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a data asset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data asset to retrieve.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/dataProducts/{data_product_id}/dataAssets/{data_asset_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataAsset GetDataAsset(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataAsset(new GetDataAssetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a data asset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data asset to retrieve.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/dataProducts/{data_product_id}/dataAssets/{data_asset_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAsset> GetDataAssetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataAssetAsync(new GetDataAssetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a data asset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data asset to retrieve.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/dataProducts/{data_product_id}/dataAssets/{data_asset_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAsset> GetDataAssetAsync(string name, st::CancellationToken cancellationToken) =>
            GetDataAssetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a data asset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data asset to retrieve.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/dataProducts/{data_product_id}/dataAssets/{data_asset_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataAsset GetDataAsset(DataAssetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataAsset(new GetDataAssetRequest
            {
                DataAssetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a data asset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data asset to retrieve.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/dataProducts/{data_product_id}/dataAssets/{data_asset_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAsset> GetDataAssetAsync(DataAssetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataAssetAsync(new GetDataAssetRequest
            {
                DataAssetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a data asset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data asset to retrieve.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/dataProducts/{data_product_id}/dataAssets/{data_asset_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAsset> GetDataAssetAsync(DataAssetName name, st::CancellationToken cancellationToken) =>
            GetDataAssetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists data assets for a given data product.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataAsset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataAssetsResponse, DataAsset> ListDataAssets(ListDataAssetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists data assets for a given data product.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataAsset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataAssetsResponse, DataAsset> ListDataAssetsAsync(ListDataAssetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists data assets for a given data product.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which has this collection of data assets.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/dataProducts/{data_product_id}
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
        /// <returns>A pageable sequence of <see cref="DataAsset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataAssetsResponse, DataAsset> ListDataAssets(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataAssetsRequest request = new ListDataAssetsRequest
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
            return ListDataAssets(request, callSettings);
        }

        /// <summary>
        /// Lists data assets for a given data product.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which has this collection of data assets.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/dataProducts/{data_product_id}
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataAsset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataAssetsResponse, DataAsset> ListDataAssetsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataAssetsRequest request = new ListDataAssetsRequest
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
            return ListDataAssetsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists data assets for a given data product.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which has this collection of data assets.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/dataProducts/{data_product_id}
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
        /// <returns>A pageable sequence of <see cref="DataAsset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataAssetsResponse, DataAsset> ListDataAssets(DataProductName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataAssetsRequest request = new ListDataAssetsRequest
            {
                ParentAsDataProductName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDataAssets(request, callSettings);
        }

        /// <summary>
        /// Lists data assets for a given data product.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which has this collection of data assets.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/dataProducts/{data_product_id}
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataAsset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataAssetsResponse, DataAsset> ListDataAssetsAsync(DataProductName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataAssetsRequest request = new ListDataAssetsRequest
            {
                ParentAsDataProductName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDataAssetsAsync(request, callSettings);
        }
    }

    /// <summary>DataProductService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// `DataProductService` provides APIs for managing data products and
    /// the underlying data assets.
    /// </remarks>
    public sealed partial class DataProductServiceClientImpl : DataProductServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateDataProductRequest, lro::Operation> _callCreateDataProduct;

        private readonly gaxgrpc::ApiCall<DeleteDataProductRequest, lro::Operation> _callDeleteDataProduct;

        private readonly gaxgrpc::ApiCall<GetDataProductRequest, DataProduct> _callGetDataProduct;

        private readonly gaxgrpc::ApiCall<ListDataProductsRequest, ListDataProductsResponse> _callListDataProducts;

        private readonly gaxgrpc::ApiCall<UpdateDataProductRequest, lro::Operation> _callUpdateDataProduct;

        private readonly gaxgrpc::ApiCall<CreateDataAssetRequest, lro::Operation> _callCreateDataAsset;

        private readonly gaxgrpc::ApiCall<UpdateDataAssetRequest, lro::Operation> _callUpdateDataAsset;

        private readonly gaxgrpc::ApiCall<DeleteDataAssetRequest, lro::Operation> _callDeleteDataAsset;

        private readonly gaxgrpc::ApiCall<GetDataAssetRequest, DataAsset> _callGetDataAsset;

        private readonly gaxgrpc::ApiCall<ListDataAssetsRequest, ListDataAssetsResponse> _callListDataAssets;

        /// <summary>
        /// Constructs a client wrapper for the DataProductService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DataProductServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DataProductServiceClientImpl(DataProductService.DataProductServiceClient grpcClient, DataProductServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DataProductServiceSettings effectiveSettings = settings ?? DataProductServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateDataProductOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateDataProductOperationsSettings, logger);
            DeleteDataProductOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteDataProductOperationsSettings, logger);
            UpdateDataProductOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateDataProductOperationsSettings, logger);
            CreateDataAssetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateDataAssetOperationsSettings, logger);
            UpdateDataAssetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateDataAssetOperationsSettings, logger);
            DeleteDataAssetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteDataAssetOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreateDataProduct = clientHelper.BuildApiCall<CreateDataProductRequest, lro::Operation>("CreateDataProduct", grpcClient.CreateDataProductAsync, grpcClient.CreateDataProduct, effectiveSettings.CreateDataProductSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDataProduct);
            Modify_CreateDataProductApiCall(ref _callCreateDataProduct);
            _callDeleteDataProduct = clientHelper.BuildApiCall<DeleteDataProductRequest, lro::Operation>("DeleteDataProduct", grpcClient.DeleteDataProductAsync, grpcClient.DeleteDataProduct, effectiveSettings.DeleteDataProductSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDataProduct);
            Modify_DeleteDataProductApiCall(ref _callDeleteDataProduct);
            _callGetDataProduct = clientHelper.BuildApiCall<GetDataProductRequest, DataProduct>("GetDataProduct", grpcClient.GetDataProductAsync, grpcClient.GetDataProduct, effectiveSettings.GetDataProductSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDataProduct);
            Modify_GetDataProductApiCall(ref _callGetDataProduct);
            _callListDataProducts = clientHelper.BuildApiCall<ListDataProductsRequest, ListDataProductsResponse>("ListDataProducts", grpcClient.ListDataProductsAsync, grpcClient.ListDataProducts, effectiveSettings.ListDataProductsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDataProducts);
            Modify_ListDataProductsApiCall(ref _callListDataProducts);
            _callUpdateDataProduct = clientHelper.BuildApiCall<UpdateDataProductRequest, lro::Operation>("UpdateDataProduct", grpcClient.UpdateDataProductAsync, grpcClient.UpdateDataProduct, effectiveSettings.UpdateDataProductSettings).WithGoogleRequestParam("data_product.name", request => request.DataProduct?.Name);
            Modify_ApiCall(ref _callUpdateDataProduct);
            Modify_UpdateDataProductApiCall(ref _callUpdateDataProduct);
            _callCreateDataAsset = clientHelper.BuildApiCall<CreateDataAssetRequest, lro::Operation>("CreateDataAsset", grpcClient.CreateDataAssetAsync, grpcClient.CreateDataAsset, effectiveSettings.CreateDataAssetSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDataAsset);
            Modify_CreateDataAssetApiCall(ref _callCreateDataAsset);
            _callUpdateDataAsset = clientHelper.BuildApiCall<UpdateDataAssetRequest, lro::Operation>("UpdateDataAsset", grpcClient.UpdateDataAssetAsync, grpcClient.UpdateDataAsset, effectiveSettings.UpdateDataAssetSettings).WithGoogleRequestParam("data_asset.name", request => request.DataAsset?.Name);
            Modify_ApiCall(ref _callUpdateDataAsset);
            Modify_UpdateDataAssetApiCall(ref _callUpdateDataAsset);
            _callDeleteDataAsset = clientHelper.BuildApiCall<DeleteDataAssetRequest, lro::Operation>("DeleteDataAsset", grpcClient.DeleteDataAssetAsync, grpcClient.DeleteDataAsset, effectiveSettings.DeleteDataAssetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDataAsset);
            Modify_DeleteDataAssetApiCall(ref _callDeleteDataAsset);
            _callGetDataAsset = clientHelper.BuildApiCall<GetDataAssetRequest, DataAsset>("GetDataAsset", grpcClient.GetDataAssetAsync, grpcClient.GetDataAsset, effectiveSettings.GetDataAssetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDataAsset);
            Modify_GetDataAssetApiCall(ref _callGetDataAsset);
            _callListDataAssets = clientHelper.BuildApiCall<ListDataAssetsRequest, ListDataAssetsResponse>("ListDataAssets", grpcClient.ListDataAssetsAsync, grpcClient.ListDataAssets, effectiveSettings.ListDataAssetsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDataAssets);
            Modify_ListDataAssetsApiCall(ref _callListDataAssets);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateDataProductApiCall(ref gaxgrpc::ApiCall<CreateDataProductRequest, lro::Operation> call);

        partial void Modify_DeleteDataProductApiCall(ref gaxgrpc::ApiCall<DeleteDataProductRequest, lro::Operation> call);

        partial void Modify_GetDataProductApiCall(ref gaxgrpc::ApiCall<GetDataProductRequest, DataProduct> call);

        partial void Modify_ListDataProductsApiCall(ref gaxgrpc::ApiCall<ListDataProductsRequest, ListDataProductsResponse> call);

        partial void Modify_UpdateDataProductApiCall(ref gaxgrpc::ApiCall<UpdateDataProductRequest, lro::Operation> call);

        partial void Modify_CreateDataAssetApiCall(ref gaxgrpc::ApiCall<CreateDataAssetRequest, lro::Operation> call);

        partial void Modify_UpdateDataAssetApiCall(ref gaxgrpc::ApiCall<UpdateDataAssetRequest, lro::Operation> call);

        partial void Modify_DeleteDataAssetApiCall(ref gaxgrpc::ApiCall<DeleteDataAssetRequest, lro::Operation> call);

        partial void Modify_GetDataAssetApiCall(ref gaxgrpc::ApiCall<GetDataAssetRequest, DataAsset> call);

        partial void Modify_ListDataAssetsApiCall(ref gaxgrpc::ApiCall<ListDataAssetsRequest, ListDataAssetsResponse> call);

        partial void OnConstruction(DataProductService.DataProductServiceClient grpcClient, DataProductServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DataProductService client</summary>
        public override DataProductService.DataProductServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateDataProductRequest(ref CreateDataProductRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDataProductRequest(ref DeleteDataProductRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDataProductRequest(ref GetDataProductRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDataProductsRequest(ref ListDataProductsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDataProductRequest(ref UpdateDataProductRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateDataAssetRequest(ref CreateDataAssetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDataAssetRequest(ref UpdateDataAssetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDataAssetRequest(ref DeleteDataAssetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDataAssetRequest(ref GetDataAssetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDataAssetsRequest(ref ListDataAssetsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateDataProduct</c>.</summary>
        public override lro::OperationsClient CreateDataProductOperationsClient { get; }

        /// <summary>
        /// Creates a data product.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DataProduct, OperationMetadata> CreateDataProduct(CreateDataProductRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDataProductRequest(ref request, ref callSettings);
            return new lro::Operation<DataProduct, OperationMetadata>(_callCreateDataProduct.Sync(request, callSettings), CreateDataProductOperationsClient);
        }

        /// <summary>
        /// Creates a data product.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DataProduct, OperationMetadata>> CreateDataProductAsync(CreateDataProductRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDataProductRequest(ref request, ref callSettings);
            return new lro::Operation<DataProduct, OperationMetadata>(await _callCreateDataProduct.Async(request, callSettings).ConfigureAwait(false), CreateDataProductOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteDataProduct</c>.</summary>
        public override lro::OperationsClient DeleteDataProductOperationsClient { get; }

        /// <summary>
        /// Deletes a data product. The deletion will fail if the data product is not
        /// empty (i.e. contains at least one data asset).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteDataProduct(DeleteDataProductRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDataProductRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteDataProduct.Sync(request, callSettings), DeleteDataProductOperationsClient);
        }

        /// <summary>
        /// Deletes a data product. The deletion will fail if the data product is not
        /// empty (i.e. contains at least one data asset).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataProductAsync(DeleteDataProductRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDataProductRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteDataProduct.Async(request, callSettings).ConfigureAwait(false), DeleteDataProductOperationsClient);
        }

        /// <summary>
        /// Gets a data product.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataProduct GetDataProduct(GetDataProductRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataProductRequest(ref request, ref callSettings);
            return _callGetDataProduct.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a data product.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataProduct> GetDataProductAsync(GetDataProductRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataProductRequest(ref request, ref callSettings);
            return _callGetDataProduct.Async(request, callSettings);
        }

        /// <summary>
        /// Lists data products for a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataProduct"/> resources.</returns>
        public override gax::PagedEnumerable<ListDataProductsResponse, DataProduct> ListDataProducts(ListDataProductsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataProductsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDataProductsRequest, ListDataProductsResponse, DataProduct>(_callListDataProducts, request, callSettings);
        }

        /// <summary>
        /// Lists data products for a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataProduct"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDataProductsResponse, DataProduct> ListDataProductsAsync(ListDataProductsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataProductsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDataProductsRequest, ListDataProductsResponse, DataProduct>(_callListDataProducts, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateDataProduct</c>.</summary>
        public override lro::OperationsClient UpdateDataProductOperationsClient { get; }

        /// <summary>
        /// Updates a data product.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DataProduct, OperationMetadata> UpdateDataProduct(UpdateDataProductRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataProductRequest(ref request, ref callSettings);
            return new lro::Operation<DataProduct, OperationMetadata>(_callUpdateDataProduct.Sync(request, callSettings), UpdateDataProductOperationsClient);
        }

        /// <summary>
        /// Updates a data product.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DataProduct, OperationMetadata>> UpdateDataProductAsync(UpdateDataProductRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataProductRequest(ref request, ref callSettings);
            return new lro::Operation<DataProduct, OperationMetadata>(await _callUpdateDataProduct.Async(request, callSettings).ConfigureAwait(false), UpdateDataProductOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateDataAsset</c>.</summary>
        public override lro::OperationsClient CreateDataAssetOperationsClient { get; }

        /// <summary>
        /// Creates a data asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DataAsset, OperationMetadata> CreateDataAsset(CreateDataAssetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDataAssetRequest(ref request, ref callSettings);
            return new lro::Operation<DataAsset, OperationMetadata>(_callCreateDataAsset.Sync(request, callSettings), CreateDataAssetOperationsClient);
        }

        /// <summary>
        /// Creates a data asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DataAsset, OperationMetadata>> CreateDataAssetAsync(CreateDataAssetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDataAssetRequest(ref request, ref callSettings);
            return new lro::Operation<DataAsset, OperationMetadata>(await _callCreateDataAsset.Async(request, callSettings).ConfigureAwait(false), CreateDataAssetOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateDataAsset</c>.</summary>
        public override lro::OperationsClient UpdateDataAssetOperationsClient { get; }

        /// <summary>
        /// Updates a data asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DataAsset, OperationMetadata> UpdateDataAsset(UpdateDataAssetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataAssetRequest(ref request, ref callSettings);
            return new lro::Operation<DataAsset, OperationMetadata>(_callUpdateDataAsset.Sync(request, callSettings), UpdateDataAssetOperationsClient);
        }

        /// <summary>
        /// Updates a data asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DataAsset, OperationMetadata>> UpdateDataAssetAsync(UpdateDataAssetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataAssetRequest(ref request, ref callSettings);
            return new lro::Operation<DataAsset, OperationMetadata>(await _callUpdateDataAsset.Async(request, callSettings).ConfigureAwait(false), UpdateDataAssetOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteDataAsset</c>.</summary>
        public override lro::OperationsClient DeleteDataAssetOperationsClient { get; }

        /// <summary>
        /// Deletes a data asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteDataAsset(DeleteDataAssetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDataAssetRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteDataAsset.Sync(request, callSettings), DeleteDataAssetOperationsClient);
        }

        /// <summary>
        /// Deletes a data asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataAssetAsync(DeleteDataAssetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDataAssetRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteDataAsset.Async(request, callSettings).ConfigureAwait(false), DeleteDataAssetOperationsClient);
        }

        /// <summary>
        /// Gets a data asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataAsset GetDataAsset(GetDataAssetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataAssetRequest(ref request, ref callSettings);
            return _callGetDataAsset.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a data asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataAsset> GetDataAssetAsync(GetDataAssetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataAssetRequest(ref request, ref callSettings);
            return _callGetDataAsset.Async(request, callSettings);
        }

        /// <summary>
        /// Lists data assets for a given data product.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataAsset"/> resources.</returns>
        public override gax::PagedEnumerable<ListDataAssetsResponse, DataAsset> ListDataAssets(ListDataAssetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataAssetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDataAssetsRequest, ListDataAssetsResponse, DataAsset>(_callListDataAssets, request, callSettings);
        }

        /// <summary>
        /// Lists data assets for a given data product.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataAsset"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDataAssetsResponse, DataAsset> ListDataAssetsAsync(ListDataAssetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataAssetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDataAssetsRequest, ListDataAssetsResponse, DataAsset>(_callListDataAssets, request, callSettings);
        }
    }

    public partial class ListDataProductsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDataAssetsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDataProductsResponse : gaxgrpc::IPageResponse<DataProduct>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DataProduct> GetEnumerator() => DataProducts.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDataAssetsResponse : gaxgrpc::IPageResponse<DataAsset>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DataAsset> GetEnumerator() => DataAssets.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class DataProductService
    {
        public partial class DataProductServiceClient
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

    public static partial class DataProductService
    {
        public partial class DataProductServiceClient
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

            /// <summary>
            /// Creates a new instance of <see cref="gciv::IAMPolicy.IAMPolicyClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gciv::IAMPolicy.IAMPolicyClient"/> for the same target as this client.
            /// </returns>
            public virtual gciv::IAMPolicy.IAMPolicyClient CreateIAMPolicyClient() =>
                new gciv::IAMPolicy.IAMPolicyClient(CallInvoker);
        }
    }
}
