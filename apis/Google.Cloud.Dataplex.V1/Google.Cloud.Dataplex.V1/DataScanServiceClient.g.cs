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
    /// <summary>Settings for <see cref="DataScanServiceClient"/> instances.</summary>
    public sealed partial class DataScanServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DataScanServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DataScanServiceSettings"/>.</returns>
        public static DataScanServiceSettings GetDefault() => new DataScanServiceSettings();

        /// <summary>Constructs a new <see cref="DataScanServiceSettings"/> object with default settings.</summary>
        public DataScanServiceSettings()
        {
        }

        private DataScanServiceSettings(DataScanServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateDataScanSettings = existing.CreateDataScanSettings;
            CreateDataScanOperationsSettings = existing.CreateDataScanOperationsSettings.Clone();
            UpdateDataScanSettings = existing.UpdateDataScanSettings;
            UpdateDataScanOperationsSettings = existing.UpdateDataScanOperationsSettings.Clone();
            DeleteDataScanSettings = existing.DeleteDataScanSettings;
            DeleteDataScanOperationsSettings = existing.DeleteDataScanOperationsSettings.Clone();
            GetDataScanSettings = existing.GetDataScanSettings;
            ListDataScansSettings = existing.ListDataScansSettings;
            RunDataScanSettings = existing.RunDataScanSettings;
            GetDataScanJobSettings = existing.GetDataScanJobSettings;
            ListDataScanJobsSettings = existing.ListDataScanJobsSettings;
            GenerateDataQualityRulesSettings = existing.GenerateDataQualityRulesSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(DataScanServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataScanServiceClient.CreateDataScan</c> and <c>DataScanServiceClient.CreateDataScanAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDataScanSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataScanServiceClient.CreateDataScan</c> and
        /// <c>DataScanServiceClient.CreateDataScanAsync</c>.
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
        public lro::OperationsSettings CreateDataScanOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataScanServiceClient.UpdateDataScan</c> and <c>DataScanServiceClient.UpdateDataScanAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDataScanSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataScanServiceClient.UpdateDataScan</c> and
        /// <c>DataScanServiceClient.UpdateDataScanAsync</c>.
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
        public lro::OperationsSettings UpdateDataScanOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataScanServiceClient.DeleteDataScan</c> and <c>DataScanServiceClient.DeleteDataScanAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDataScanSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataScanServiceClient.DeleteDataScan</c> and
        /// <c>DataScanServiceClient.DeleteDataScanAsync</c>.
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
        public lro::OperationsSettings DeleteDataScanOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataScanServiceClient.GetDataScan</c> and <c>DataScanServiceClient.GetDataScanAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDataScanSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataScanServiceClient.ListDataScans</c> and <c>DataScanServiceClient.ListDataScansAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDataScansSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataScanServiceClient.RunDataScan</c> and <c>DataScanServiceClient.RunDataScanAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RunDataScanSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataScanServiceClient.GetDataScanJob</c> and <c>DataScanServiceClient.GetDataScanJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDataScanJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataScanServiceClient.ListDataScanJobs</c> and <c>DataScanServiceClient.ListDataScanJobsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDataScanJobsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataScanServiceClient.GenerateDataQualityRules</c> and
        /// <c>DataScanServiceClient.GenerateDataQualityRulesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GenerateDataQualityRulesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DataScanServiceSettings"/> object.</returns>
        public DataScanServiceSettings Clone() => new DataScanServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DataScanServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class DataScanServiceClientBuilder : gaxgrpc::ClientBuilderBase<DataScanServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DataScanServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DataScanServiceClientBuilder() : base(DataScanServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DataScanServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DataScanServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DataScanServiceClient Build()
        {
            DataScanServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DataScanServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DataScanServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DataScanServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DataScanServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DataScanServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DataScanServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DataScanServiceClient.ChannelPool;
    }

    /// <summary>DataScanService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// DataScanService manages DataScan resources which can be configured to run
    /// various types of data scanning workload and generate enriched metadata (e.g.
    /// Data Profile, Data Quality) for the data source.
    /// </remarks>
    public abstract partial class DataScanServiceClient
    {
        /// <summary>
        /// The default endpoint for the DataScanService service, which is a host of "dataplex.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dataplex.googleapis.com:443";

        /// <summary>The default DataScanService scopes.</summary>
        /// <remarks>
        /// The default DataScanService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DataScanService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DataScanServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DataScanServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DataScanServiceClient"/>.</returns>
        public static stt::Task<DataScanServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DataScanServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DataScanServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DataScanServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DataScanServiceClient"/>.</returns>
        public static DataScanServiceClient Create() => new DataScanServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DataScanServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DataScanServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DataScanServiceClient"/>.</returns>
        internal static DataScanServiceClient Create(grpccore::CallInvoker callInvoker, DataScanServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DataScanService.DataScanServiceClient grpcClient = new DataScanService.DataScanServiceClient(callInvoker);
            return new DataScanServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DataScanService client</summary>
        public virtual DataScanService.DataScanServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a DataScan resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataScan, OperationMetadata> CreateDataScan(CreateDataScanRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a DataScan resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataScan, OperationMetadata>> CreateDataScanAsync(CreateDataScanRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a DataScan resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataScan, OperationMetadata>> CreateDataScanAsync(CreateDataScanRequest request, st::CancellationToken cancellationToken) =>
            CreateDataScanAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateDataScan</c>.</summary>
        public virtual lro::OperationsClient CreateDataScanOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateDataScan</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DataScan, OperationMetadata> PollOnceCreateDataScan(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DataScan, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDataScanOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateDataScan</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DataScan, OperationMetadata>> PollOnceCreateDataScanAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DataScan, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDataScanOperationsClient, callSettings);

        /// <summary>
        /// Creates a DataScan resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent location:
        /// `projects/{project}/locations/{location_id}`
        /// where `project` refers to a *project_id* or *project_number* and
        /// `location_id` refers to a GCP region.
        /// </param>
        /// <param name="dataScan">
        /// Required. DataScan resource.
        /// </param>
        /// <param name="dataScanId">
        /// Required. DataScan identifier.
        /// 
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must end with a number or a letter.
        /// * Must be between 1-63 characters.
        /// * Must be unique within the customer project / location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataScan, OperationMetadata> CreateDataScan(string parent, DataScan dataScan, string dataScanId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataScan(new CreateDataScanRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DataScan = gax::GaxPreconditions.CheckNotNull(dataScan, nameof(dataScan)),
                DataScanId = gax::GaxPreconditions.CheckNotNullOrEmpty(dataScanId, nameof(dataScanId)),
            }, callSettings);

        /// <summary>
        /// Creates a DataScan resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent location:
        /// `projects/{project}/locations/{location_id}`
        /// where `project` refers to a *project_id* or *project_number* and
        /// `location_id` refers to a GCP region.
        /// </param>
        /// <param name="dataScan">
        /// Required. DataScan resource.
        /// </param>
        /// <param name="dataScanId">
        /// Required. DataScan identifier.
        /// 
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must end with a number or a letter.
        /// * Must be between 1-63 characters.
        /// * Must be unique within the customer project / location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataScan, OperationMetadata>> CreateDataScanAsync(string parent, DataScan dataScan, string dataScanId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataScanAsync(new CreateDataScanRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DataScan = gax::GaxPreconditions.CheckNotNull(dataScan, nameof(dataScan)),
                DataScanId = gax::GaxPreconditions.CheckNotNullOrEmpty(dataScanId, nameof(dataScanId)),
            }, callSettings);

        /// <summary>
        /// Creates a DataScan resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent location:
        /// `projects/{project}/locations/{location_id}`
        /// where `project` refers to a *project_id* or *project_number* and
        /// `location_id` refers to a GCP region.
        /// </param>
        /// <param name="dataScan">
        /// Required. DataScan resource.
        /// </param>
        /// <param name="dataScanId">
        /// Required. DataScan identifier.
        /// 
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must end with a number or a letter.
        /// * Must be between 1-63 characters.
        /// * Must be unique within the customer project / location.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataScan, OperationMetadata>> CreateDataScanAsync(string parent, DataScan dataScan, string dataScanId, st::CancellationToken cancellationToken) =>
            CreateDataScanAsync(parent, dataScan, dataScanId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a DataScan resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent location:
        /// `projects/{project}/locations/{location_id}`
        /// where `project` refers to a *project_id* or *project_number* and
        /// `location_id` refers to a GCP region.
        /// </param>
        /// <param name="dataScan">
        /// Required. DataScan resource.
        /// </param>
        /// <param name="dataScanId">
        /// Required. DataScan identifier.
        /// 
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must end with a number or a letter.
        /// * Must be between 1-63 characters.
        /// * Must be unique within the customer project / location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataScan, OperationMetadata> CreateDataScan(gagr::LocationName parent, DataScan dataScan, string dataScanId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataScan(new CreateDataScanRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DataScan = gax::GaxPreconditions.CheckNotNull(dataScan, nameof(dataScan)),
                DataScanId = gax::GaxPreconditions.CheckNotNullOrEmpty(dataScanId, nameof(dataScanId)),
            }, callSettings);

        /// <summary>
        /// Creates a DataScan resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent location:
        /// `projects/{project}/locations/{location_id}`
        /// where `project` refers to a *project_id* or *project_number* and
        /// `location_id` refers to a GCP region.
        /// </param>
        /// <param name="dataScan">
        /// Required. DataScan resource.
        /// </param>
        /// <param name="dataScanId">
        /// Required. DataScan identifier.
        /// 
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must end with a number or a letter.
        /// * Must be between 1-63 characters.
        /// * Must be unique within the customer project / location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataScan, OperationMetadata>> CreateDataScanAsync(gagr::LocationName parent, DataScan dataScan, string dataScanId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataScanAsync(new CreateDataScanRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DataScan = gax::GaxPreconditions.CheckNotNull(dataScan, nameof(dataScan)),
                DataScanId = gax::GaxPreconditions.CheckNotNullOrEmpty(dataScanId, nameof(dataScanId)),
            }, callSettings);

        /// <summary>
        /// Creates a DataScan resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent location:
        /// `projects/{project}/locations/{location_id}`
        /// where `project` refers to a *project_id* or *project_number* and
        /// `location_id` refers to a GCP region.
        /// </param>
        /// <param name="dataScan">
        /// Required. DataScan resource.
        /// </param>
        /// <param name="dataScanId">
        /// Required. DataScan identifier.
        /// 
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must end with a number or a letter.
        /// * Must be between 1-63 characters.
        /// * Must be unique within the customer project / location.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataScan, OperationMetadata>> CreateDataScanAsync(gagr::LocationName parent, DataScan dataScan, string dataScanId, st::CancellationToken cancellationToken) =>
            CreateDataScanAsync(parent, dataScan, dataScanId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a DataScan resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataScan, OperationMetadata> UpdateDataScan(UpdateDataScanRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a DataScan resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataScan, OperationMetadata>> UpdateDataScanAsync(UpdateDataScanRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a DataScan resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataScan, OperationMetadata>> UpdateDataScanAsync(UpdateDataScanRequest request, st::CancellationToken cancellationToken) =>
            UpdateDataScanAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateDataScan</c>.</summary>
        public virtual lro::OperationsClient UpdateDataScanOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateDataScan</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DataScan, OperationMetadata> PollOnceUpdateDataScan(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DataScan, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDataScanOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateDataScan</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DataScan, OperationMetadata>> PollOnceUpdateDataScanAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DataScan, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDataScanOperationsClient, callSettings);

        /// <summary>
        /// Updates a DataScan resource.
        /// </summary>
        /// <param name="dataScan">
        /// Required. DataScan resource to be updated.
        /// 
        /// Only fields specified in `update_mask` are updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Mask of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataScan, OperationMetadata> UpdateDataScan(DataScan dataScan, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataScan(new UpdateDataScanRequest
            {
                DataScan = gax::GaxPreconditions.CheckNotNull(dataScan, nameof(dataScan)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a DataScan resource.
        /// </summary>
        /// <param name="dataScan">
        /// Required. DataScan resource to be updated.
        /// 
        /// Only fields specified in `update_mask` are updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Mask of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataScan, OperationMetadata>> UpdateDataScanAsync(DataScan dataScan, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataScanAsync(new UpdateDataScanRequest
            {
                DataScan = gax::GaxPreconditions.CheckNotNull(dataScan, nameof(dataScan)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a DataScan resource.
        /// </summary>
        /// <param name="dataScan">
        /// Required. DataScan resource to be updated.
        /// 
        /// Only fields specified in `update_mask` are updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Mask of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataScan, OperationMetadata>> UpdateDataScanAsync(DataScan dataScan, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDataScanAsync(dataScan, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a DataScan resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDataScan(DeleteDataScanRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a DataScan resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataScanAsync(DeleteDataScanRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a DataScan resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataScanAsync(DeleteDataScanRequest request, st::CancellationToken cancellationToken) =>
            DeleteDataScanAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteDataScan</c>.</summary>
        public virtual lro::OperationsClient DeleteDataScanOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteDataScan</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteDataScan(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDataScanOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteDataScan</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteDataScanAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDataScanOperationsClient, callSettings);

        /// <summary>
        /// Deletes a DataScan resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the dataScan:
        /// `projects/{project}/locations/{location_id}/dataScans/{data_scan_id}`
        /// where `project` refers to a *project_id* or *project_number* and
        /// `location_id` refers to a GCP region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDataScan(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataScan(new DeleteDataScanRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a DataScan resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the dataScan:
        /// `projects/{project}/locations/{location_id}/dataScans/{data_scan_id}`
        /// where `project` refers to a *project_id* or *project_number* and
        /// `location_id` refers to a GCP region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataScanAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataScanAsync(new DeleteDataScanRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a DataScan resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the dataScan:
        /// `projects/{project}/locations/{location_id}/dataScans/{data_scan_id}`
        /// where `project` refers to a *project_id* or *project_number* and
        /// `location_id` refers to a GCP region.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataScanAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDataScanAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a DataScan resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the dataScan:
        /// `projects/{project}/locations/{location_id}/dataScans/{data_scan_id}`
        /// where `project` refers to a *project_id* or *project_number* and
        /// `location_id` refers to a GCP region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDataScan(DataScanName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataScan(new DeleteDataScanRequest
            {
                DataScanName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a DataScan resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the dataScan:
        /// `projects/{project}/locations/{location_id}/dataScans/{data_scan_id}`
        /// where `project` refers to a *project_id* or *project_number* and
        /// `location_id` refers to a GCP region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataScanAsync(DataScanName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataScanAsync(new DeleteDataScanRequest
            {
                DataScanName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a DataScan resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the dataScan:
        /// `projects/{project}/locations/{location_id}/dataScans/{data_scan_id}`
        /// where `project` refers to a *project_id* or *project_number* and
        /// `location_id` refers to a GCP region.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataScanAsync(DataScanName name, st::CancellationToken cancellationToken) =>
            DeleteDataScanAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a DataScan resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataScan GetDataScan(GetDataScanRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a DataScan resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataScan> GetDataScanAsync(GetDataScanRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a DataScan resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataScan> GetDataScanAsync(GetDataScanRequest request, st::CancellationToken cancellationToken) =>
            GetDataScanAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a DataScan resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the dataScan:
        /// `projects/{project}/locations/{location_id}/dataScans/{data_scan_id}`
        /// where `project` refers to a *project_id* or *project_number* and
        /// `location_id` refers to a GCP region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataScan GetDataScan(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataScan(new GetDataScanRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a DataScan resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the dataScan:
        /// `projects/{project}/locations/{location_id}/dataScans/{data_scan_id}`
        /// where `project` refers to a *project_id* or *project_number* and
        /// `location_id` refers to a GCP region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataScan> GetDataScanAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataScanAsync(new GetDataScanRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a DataScan resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the dataScan:
        /// `projects/{project}/locations/{location_id}/dataScans/{data_scan_id}`
        /// where `project` refers to a *project_id* or *project_number* and
        /// `location_id` refers to a GCP region.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataScan> GetDataScanAsync(string name, st::CancellationToken cancellationToken) =>
            GetDataScanAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a DataScan resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the dataScan:
        /// `projects/{project}/locations/{location_id}/dataScans/{data_scan_id}`
        /// where `project` refers to a *project_id* or *project_number* and
        /// `location_id` refers to a GCP region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataScan GetDataScan(DataScanName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataScan(new GetDataScanRequest
            {
                DataScanName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a DataScan resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the dataScan:
        /// `projects/{project}/locations/{location_id}/dataScans/{data_scan_id}`
        /// where `project` refers to a *project_id* or *project_number* and
        /// `location_id` refers to a GCP region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataScan> GetDataScanAsync(DataScanName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataScanAsync(new GetDataScanRequest
            {
                DataScanName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a DataScan resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the dataScan:
        /// `projects/{project}/locations/{location_id}/dataScans/{data_scan_id}`
        /// where `project` refers to a *project_id* or *project_number* and
        /// `location_id` refers to a GCP region.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataScan> GetDataScanAsync(DataScanName name, st::CancellationToken cancellationToken) =>
            GetDataScanAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists DataScans.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataScan"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataScansResponse, DataScan> ListDataScans(ListDataScansRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists DataScans.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataScan"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataScansResponse, DataScan> ListDataScansAsync(ListDataScansRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists DataScans.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent location:
        /// `projects/{project}/locations/{location_id}`
        /// where `project` refers to a *project_id* or *project_number* and
        /// `location_id` refers to a GCP region.
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
        /// <returns>A pageable sequence of <see cref="DataScan"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataScansResponse, DataScan> ListDataScans(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataScansRequest request = new ListDataScansRequest
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
            return ListDataScans(request, callSettings);
        }

        /// <summary>
        /// Lists DataScans.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent location:
        /// `projects/{project}/locations/{location_id}`
        /// where `project` refers to a *project_id* or *project_number* and
        /// `location_id` refers to a GCP region.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataScan"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataScansResponse, DataScan> ListDataScansAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataScansRequest request = new ListDataScansRequest
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
            return ListDataScansAsync(request, callSettings);
        }

        /// <summary>
        /// Lists DataScans.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent location:
        /// `projects/{project}/locations/{location_id}`
        /// where `project` refers to a *project_id* or *project_number* and
        /// `location_id` refers to a GCP region.
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
        /// <returns>A pageable sequence of <see cref="DataScan"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataScansResponse, DataScan> ListDataScans(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataScansRequest request = new ListDataScansRequest
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
            return ListDataScans(request, callSettings);
        }

        /// <summary>
        /// Lists DataScans.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent location:
        /// `projects/{project}/locations/{location_id}`
        /// where `project` refers to a *project_id* or *project_number* and
        /// `location_id` refers to a GCP region.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataScan"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataScansResponse, DataScan> ListDataScansAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataScansRequest request = new ListDataScansRequest
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
            return ListDataScansAsync(request, callSettings);
        }

        /// <summary>
        /// Runs an on-demand execution of a DataScan
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RunDataScanResponse RunDataScan(RunDataScanRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Runs an on-demand execution of a DataScan
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunDataScanResponse> RunDataScanAsync(RunDataScanRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Runs an on-demand execution of a DataScan
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunDataScanResponse> RunDataScanAsync(RunDataScanRequest request, st::CancellationToken cancellationToken) =>
            RunDataScanAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Runs an on-demand execution of a DataScan
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DataScan:
        /// `projects/{project}/locations/{location_id}/dataScans/{data_scan_id}`.
        /// where `project` refers to a *project_id* or *project_number* and
        /// `location_id` refers to a GCP region.
        /// 
        /// Only **OnDemand** data scans are allowed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RunDataScanResponse RunDataScan(string name, gaxgrpc::CallSettings callSettings = null) =>
            RunDataScan(new RunDataScanRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Runs an on-demand execution of a DataScan
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DataScan:
        /// `projects/{project}/locations/{location_id}/dataScans/{data_scan_id}`.
        /// where `project` refers to a *project_id* or *project_number* and
        /// `location_id` refers to a GCP region.
        /// 
        /// Only **OnDemand** data scans are allowed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunDataScanResponse> RunDataScanAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            RunDataScanAsync(new RunDataScanRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Runs an on-demand execution of a DataScan
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DataScan:
        /// `projects/{project}/locations/{location_id}/dataScans/{data_scan_id}`.
        /// where `project` refers to a *project_id* or *project_number* and
        /// `location_id` refers to a GCP region.
        /// 
        /// Only **OnDemand** data scans are allowed.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunDataScanResponse> RunDataScanAsync(string name, st::CancellationToken cancellationToken) =>
            RunDataScanAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Runs an on-demand execution of a DataScan
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DataScan:
        /// `projects/{project}/locations/{location_id}/dataScans/{data_scan_id}`.
        /// where `project` refers to a *project_id* or *project_number* and
        /// `location_id` refers to a GCP region.
        /// 
        /// Only **OnDemand** data scans are allowed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RunDataScanResponse RunDataScan(DataScanName name, gaxgrpc::CallSettings callSettings = null) =>
            RunDataScan(new RunDataScanRequest
            {
                DataScanName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Runs an on-demand execution of a DataScan
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DataScan:
        /// `projects/{project}/locations/{location_id}/dataScans/{data_scan_id}`.
        /// where `project` refers to a *project_id* or *project_number* and
        /// `location_id` refers to a GCP region.
        /// 
        /// Only **OnDemand** data scans are allowed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunDataScanResponse> RunDataScanAsync(DataScanName name, gaxgrpc::CallSettings callSettings = null) =>
            RunDataScanAsync(new RunDataScanRequest
            {
                DataScanName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Runs an on-demand execution of a DataScan
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DataScan:
        /// `projects/{project}/locations/{location_id}/dataScans/{data_scan_id}`.
        /// where `project` refers to a *project_id* or *project_number* and
        /// `location_id` refers to a GCP region.
        /// 
        /// Only **OnDemand** data scans are allowed.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunDataScanResponse> RunDataScanAsync(DataScanName name, st::CancellationToken cancellationToken) =>
            RunDataScanAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a DataScanJob resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataScanJob GetDataScanJob(GetDataScanJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a DataScanJob resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataScanJob> GetDataScanJobAsync(GetDataScanJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a DataScanJob resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataScanJob> GetDataScanJobAsync(GetDataScanJobRequest request, st::CancellationToken cancellationToken) =>
            GetDataScanJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a DataScanJob resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DataScanJob:
        /// `projects/{project}/locations/{location_id}/dataScans/{data_scan_id}/jobs/{data_scan_job_id}`
        /// where `project` refers to a *project_id* or *project_number* and
        /// `location_id` refers to a GCP region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataScanJob GetDataScanJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataScanJob(new GetDataScanJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a DataScanJob resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DataScanJob:
        /// `projects/{project}/locations/{location_id}/dataScans/{data_scan_id}/jobs/{data_scan_job_id}`
        /// where `project` refers to a *project_id* or *project_number* and
        /// `location_id` refers to a GCP region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataScanJob> GetDataScanJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataScanJobAsync(new GetDataScanJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a DataScanJob resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DataScanJob:
        /// `projects/{project}/locations/{location_id}/dataScans/{data_scan_id}/jobs/{data_scan_job_id}`
        /// where `project` refers to a *project_id* or *project_number* and
        /// `location_id` refers to a GCP region.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataScanJob> GetDataScanJobAsync(string name, st::CancellationToken cancellationToken) =>
            GetDataScanJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a DataScanJob resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DataScanJob:
        /// `projects/{project}/locations/{location_id}/dataScans/{data_scan_id}/jobs/{data_scan_job_id}`
        /// where `project` refers to a *project_id* or *project_number* and
        /// `location_id` refers to a GCP region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataScanJob GetDataScanJob(DataScanJobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataScanJob(new GetDataScanJobRequest
            {
                DataScanJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a DataScanJob resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DataScanJob:
        /// `projects/{project}/locations/{location_id}/dataScans/{data_scan_id}/jobs/{data_scan_job_id}`
        /// where `project` refers to a *project_id* or *project_number* and
        /// `location_id` refers to a GCP region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataScanJob> GetDataScanJobAsync(DataScanJobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataScanJobAsync(new GetDataScanJobRequest
            {
                DataScanJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a DataScanJob resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DataScanJob:
        /// `projects/{project}/locations/{location_id}/dataScans/{data_scan_id}/jobs/{data_scan_job_id}`
        /// where `project` refers to a *project_id* or *project_number* and
        /// `location_id` refers to a GCP region.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataScanJob> GetDataScanJobAsync(DataScanJobName name, st::CancellationToken cancellationToken) =>
            GetDataScanJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists DataScanJobs under the given DataScan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataScanJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataScanJobsResponse, DataScanJob> ListDataScanJobs(ListDataScanJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists DataScanJobs under the given DataScan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataScanJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataScanJobsResponse, DataScanJob> ListDataScanJobsAsync(ListDataScanJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists DataScanJobs under the given DataScan.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent environment:
        /// `projects/{project}/locations/{location_id}/dataScans/{data_scan_id}`
        /// where `project` refers to a *project_id* or *project_number* and
        /// `location_id` refers to a GCP region.
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
        /// <returns>A pageable sequence of <see cref="DataScanJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataScanJobsResponse, DataScanJob> ListDataScanJobs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataScanJobsRequest request = new ListDataScanJobsRequest
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
            return ListDataScanJobs(request, callSettings);
        }

        /// <summary>
        /// Lists DataScanJobs under the given DataScan.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent environment:
        /// `projects/{project}/locations/{location_id}/dataScans/{data_scan_id}`
        /// where `project` refers to a *project_id* or *project_number* and
        /// `location_id` refers to a GCP region.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataScanJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataScanJobsResponse, DataScanJob> ListDataScanJobsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataScanJobsRequest request = new ListDataScanJobsRequest
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
            return ListDataScanJobsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists DataScanJobs under the given DataScan.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent environment:
        /// `projects/{project}/locations/{location_id}/dataScans/{data_scan_id}`
        /// where `project` refers to a *project_id* or *project_number* and
        /// `location_id` refers to a GCP region.
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
        /// <returns>A pageable sequence of <see cref="DataScanJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataScanJobsResponse, DataScanJob> ListDataScanJobs(DataScanName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataScanJobsRequest request = new ListDataScanJobsRequest
            {
                ParentAsDataScanName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDataScanJobs(request, callSettings);
        }

        /// <summary>
        /// Lists DataScanJobs under the given DataScan.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent environment:
        /// `projects/{project}/locations/{location_id}/dataScans/{data_scan_id}`
        /// where `project` refers to a *project_id* or *project_number* and
        /// `location_id` refers to a GCP region.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataScanJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataScanJobsResponse, DataScanJob> ListDataScanJobsAsync(DataScanName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataScanJobsRequest request = new ListDataScanJobsRequest
            {
                ParentAsDataScanName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDataScanJobsAsync(request, callSettings);
        }

        /// <summary>
        /// Generates recommended data quality rules based on the results of a data
        /// profiling scan.
        /// 
        /// Use the recommendations to build rules for a data quality scan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateDataQualityRulesResponse GenerateDataQualityRules(GenerateDataQualityRulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates recommended data quality rules based on the results of a data
        /// profiling scan.
        /// 
        /// Use the recommendations to build rules for a data quality scan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateDataQualityRulesResponse> GenerateDataQualityRulesAsync(GenerateDataQualityRulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates recommended data quality rules based on the results of a data
        /// profiling scan.
        /// 
        /// Use the recommendations to build rules for a data quality scan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateDataQualityRulesResponse> GenerateDataQualityRulesAsync(GenerateDataQualityRulesRequest request, st::CancellationToken cancellationToken) =>
            GenerateDataQualityRulesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates recommended data quality rules based on the results of a data
        /// profiling scan.
        /// 
        /// Use the recommendations to build rules for a data quality scan.
        /// </summary>
        /// <param name="name">
        /// Required. The name must be one of the following:
        /// 
        /// * The name of a data scan with at least one successful, completed data
        /// profiling job
        /// * The name of a successful, completed data profiling job (a data scan job
        /// where the job type is data profiling)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateDataQualityRulesResponse GenerateDataQualityRules(string name, gaxgrpc::CallSettings callSettings = null) =>
            GenerateDataQualityRules(new GenerateDataQualityRulesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Generates recommended data quality rules based on the results of a data
        /// profiling scan.
        /// 
        /// Use the recommendations to build rules for a data quality scan.
        /// </summary>
        /// <param name="name">
        /// Required. The name must be one of the following:
        /// 
        /// * The name of a data scan with at least one successful, completed data
        /// profiling job
        /// * The name of a successful, completed data profiling job (a data scan job
        /// where the job type is data profiling)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateDataQualityRulesResponse> GenerateDataQualityRulesAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GenerateDataQualityRulesAsync(new GenerateDataQualityRulesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Generates recommended data quality rules based on the results of a data
        /// profiling scan.
        /// 
        /// Use the recommendations to build rules for a data quality scan.
        /// </summary>
        /// <param name="name">
        /// Required. The name must be one of the following:
        /// 
        /// * The name of a data scan with at least one successful, completed data
        /// profiling job
        /// * The name of a successful, completed data profiling job (a data scan job
        /// where the job type is data profiling)
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateDataQualityRulesResponse> GenerateDataQualityRulesAsync(string name, st::CancellationToken cancellationToken) =>
            GenerateDataQualityRulesAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>DataScanService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// DataScanService manages DataScan resources which can be configured to run
    /// various types of data scanning workload and generate enriched metadata (e.g.
    /// Data Profile, Data Quality) for the data source.
    /// </remarks>
    public sealed partial class DataScanServiceClientImpl : DataScanServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateDataScanRequest, lro::Operation> _callCreateDataScan;

        private readonly gaxgrpc::ApiCall<UpdateDataScanRequest, lro::Operation> _callUpdateDataScan;

        private readonly gaxgrpc::ApiCall<DeleteDataScanRequest, lro::Operation> _callDeleteDataScan;

        private readonly gaxgrpc::ApiCall<GetDataScanRequest, DataScan> _callGetDataScan;

        private readonly gaxgrpc::ApiCall<ListDataScansRequest, ListDataScansResponse> _callListDataScans;

        private readonly gaxgrpc::ApiCall<RunDataScanRequest, RunDataScanResponse> _callRunDataScan;

        private readonly gaxgrpc::ApiCall<GetDataScanJobRequest, DataScanJob> _callGetDataScanJob;

        private readonly gaxgrpc::ApiCall<ListDataScanJobsRequest, ListDataScanJobsResponse> _callListDataScanJobs;

        private readonly gaxgrpc::ApiCall<GenerateDataQualityRulesRequest, GenerateDataQualityRulesResponse> _callGenerateDataQualityRules;

        /// <summary>
        /// Constructs a client wrapper for the DataScanService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DataScanServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DataScanServiceClientImpl(DataScanService.DataScanServiceClient grpcClient, DataScanServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DataScanServiceSettings effectiveSettings = settings ?? DataScanServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateDataScanOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateDataScanOperationsSettings, logger);
            UpdateDataScanOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateDataScanOperationsSettings, logger);
            DeleteDataScanOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteDataScanOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreateDataScan = clientHelper.BuildApiCall<CreateDataScanRequest, lro::Operation>("CreateDataScan", grpcClient.CreateDataScanAsync, grpcClient.CreateDataScan, effectiveSettings.CreateDataScanSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDataScan);
            Modify_CreateDataScanApiCall(ref _callCreateDataScan);
            _callUpdateDataScan = clientHelper.BuildApiCall<UpdateDataScanRequest, lro::Operation>("UpdateDataScan", grpcClient.UpdateDataScanAsync, grpcClient.UpdateDataScan, effectiveSettings.UpdateDataScanSettings).WithGoogleRequestParam("data_scan.name", request => request.DataScan?.Name);
            Modify_ApiCall(ref _callUpdateDataScan);
            Modify_UpdateDataScanApiCall(ref _callUpdateDataScan);
            _callDeleteDataScan = clientHelper.BuildApiCall<DeleteDataScanRequest, lro::Operation>("DeleteDataScan", grpcClient.DeleteDataScanAsync, grpcClient.DeleteDataScan, effectiveSettings.DeleteDataScanSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDataScan);
            Modify_DeleteDataScanApiCall(ref _callDeleteDataScan);
            _callGetDataScan = clientHelper.BuildApiCall<GetDataScanRequest, DataScan>("GetDataScan", grpcClient.GetDataScanAsync, grpcClient.GetDataScan, effectiveSettings.GetDataScanSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDataScan);
            Modify_GetDataScanApiCall(ref _callGetDataScan);
            _callListDataScans = clientHelper.BuildApiCall<ListDataScansRequest, ListDataScansResponse>("ListDataScans", grpcClient.ListDataScansAsync, grpcClient.ListDataScans, effectiveSettings.ListDataScansSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDataScans);
            Modify_ListDataScansApiCall(ref _callListDataScans);
            _callRunDataScan = clientHelper.BuildApiCall<RunDataScanRequest, RunDataScanResponse>("RunDataScan", grpcClient.RunDataScanAsync, grpcClient.RunDataScan, effectiveSettings.RunDataScanSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRunDataScan);
            Modify_RunDataScanApiCall(ref _callRunDataScan);
            _callGetDataScanJob = clientHelper.BuildApiCall<GetDataScanJobRequest, DataScanJob>("GetDataScanJob", grpcClient.GetDataScanJobAsync, grpcClient.GetDataScanJob, effectiveSettings.GetDataScanJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDataScanJob);
            Modify_GetDataScanJobApiCall(ref _callGetDataScanJob);
            _callListDataScanJobs = clientHelper.BuildApiCall<ListDataScanJobsRequest, ListDataScanJobsResponse>("ListDataScanJobs", grpcClient.ListDataScanJobsAsync, grpcClient.ListDataScanJobs, effectiveSettings.ListDataScanJobsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDataScanJobs);
            Modify_ListDataScanJobsApiCall(ref _callListDataScanJobs);
            _callGenerateDataQualityRules = clientHelper.BuildApiCall<GenerateDataQualityRulesRequest, GenerateDataQualityRulesResponse>("GenerateDataQualityRules", grpcClient.GenerateDataQualityRulesAsync, grpcClient.GenerateDataQualityRules, effectiveSettings.GenerateDataQualityRulesSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGenerateDataQualityRules);
            Modify_GenerateDataQualityRulesApiCall(ref _callGenerateDataQualityRules);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateDataScanApiCall(ref gaxgrpc::ApiCall<CreateDataScanRequest, lro::Operation> call);

        partial void Modify_UpdateDataScanApiCall(ref gaxgrpc::ApiCall<UpdateDataScanRequest, lro::Operation> call);

        partial void Modify_DeleteDataScanApiCall(ref gaxgrpc::ApiCall<DeleteDataScanRequest, lro::Operation> call);

        partial void Modify_GetDataScanApiCall(ref gaxgrpc::ApiCall<GetDataScanRequest, DataScan> call);

        partial void Modify_ListDataScansApiCall(ref gaxgrpc::ApiCall<ListDataScansRequest, ListDataScansResponse> call);

        partial void Modify_RunDataScanApiCall(ref gaxgrpc::ApiCall<RunDataScanRequest, RunDataScanResponse> call);

        partial void Modify_GetDataScanJobApiCall(ref gaxgrpc::ApiCall<GetDataScanJobRequest, DataScanJob> call);

        partial void Modify_ListDataScanJobsApiCall(ref gaxgrpc::ApiCall<ListDataScanJobsRequest, ListDataScanJobsResponse> call);

        partial void Modify_GenerateDataQualityRulesApiCall(ref gaxgrpc::ApiCall<GenerateDataQualityRulesRequest, GenerateDataQualityRulesResponse> call);

        partial void OnConstruction(DataScanService.DataScanServiceClient grpcClient, DataScanServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DataScanService client</summary>
        public override DataScanService.DataScanServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateDataScanRequest(ref CreateDataScanRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDataScanRequest(ref UpdateDataScanRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDataScanRequest(ref DeleteDataScanRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDataScanRequest(ref GetDataScanRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDataScansRequest(ref ListDataScansRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RunDataScanRequest(ref RunDataScanRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDataScanJobRequest(ref GetDataScanJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDataScanJobsRequest(ref ListDataScanJobsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateDataQualityRulesRequest(ref GenerateDataQualityRulesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateDataScan</c>.</summary>
        public override lro::OperationsClient CreateDataScanOperationsClient { get; }

        /// <summary>
        /// Creates a DataScan resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DataScan, OperationMetadata> CreateDataScan(CreateDataScanRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDataScanRequest(ref request, ref callSettings);
            return new lro::Operation<DataScan, OperationMetadata>(_callCreateDataScan.Sync(request, callSettings), CreateDataScanOperationsClient);
        }

        /// <summary>
        /// Creates a DataScan resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DataScan, OperationMetadata>> CreateDataScanAsync(CreateDataScanRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDataScanRequest(ref request, ref callSettings);
            return new lro::Operation<DataScan, OperationMetadata>(await _callCreateDataScan.Async(request, callSettings).ConfigureAwait(false), CreateDataScanOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateDataScan</c>.</summary>
        public override lro::OperationsClient UpdateDataScanOperationsClient { get; }

        /// <summary>
        /// Updates a DataScan resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DataScan, OperationMetadata> UpdateDataScan(UpdateDataScanRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataScanRequest(ref request, ref callSettings);
            return new lro::Operation<DataScan, OperationMetadata>(_callUpdateDataScan.Sync(request, callSettings), UpdateDataScanOperationsClient);
        }

        /// <summary>
        /// Updates a DataScan resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DataScan, OperationMetadata>> UpdateDataScanAsync(UpdateDataScanRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataScanRequest(ref request, ref callSettings);
            return new lro::Operation<DataScan, OperationMetadata>(await _callUpdateDataScan.Async(request, callSettings).ConfigureAwait(false), UpdateDataScanOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteDataScan</c>.</summary>
        public override lro::OperationsClient DeleteDataScanOperationsClient { get; }

        /// <summary>
        /// Deletes a DataScan resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteDataScan(DeleteDataScanRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDataScanRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteDataScan.Sync(request, callSettings), DeleteDataScanOperationsClient);
        }

        /// <summary>
        /// Deletes a DataScan resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataScanAsync(DeleteDataScanRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDataScanRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteDataScan.Async(request, callSettings).ConfigureAwait(false), DeleteDataScanOperationsClient);
        }

        /// <summary>
        /// Gets a DataScan resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataScan GetDataScan(GetDataScanRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataScanRequest(ref request, ref callSettings);
            return _callGetDataScan.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a DataScan resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataScan> GetDataScanAsync(GetDataScanRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataScanRequest(ref request, ref callSettings);
            return _callGetDataScan.Async(request, callSettings);
        }

        /// <summary>
        /// Lists DataScans.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataScan"/> resources.</returns>
        public override gax::PagedEnumerable<ListDataScansResponse, DataScan> ListDataScans(ListDataScansRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataScansRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDataScansRequest, ListDataScansResponse, DataScan>(_callListDataScans, request, callSettings);
        }

        /// <summary>
        /// Lists DataScans.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataScan"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDataScansResponse, DataScan> ListDataScansAsync(ListDataScansRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataScansRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDataScansRequest, ListDataScansResponse, DataScan>(_callListDataScans, request, callSettings);
        }

        /// <summary>
        /// Runs an on-demand execution of a DataScan
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RunDataScanResponse RunDataScan(RunDataScanRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunDataScanRequest(ref request, ref callSettings);
            return _callRunDataScan.Sync(request, callSettings);
        }

        /// <summary>
        /// Runs an on-demand execution of a DataScan
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RunDataScanResponse> RunDataScanAsync(RunDataScanRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunDataScanRequest(ref request, ref callSettings);
            return _callRunDataScan.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a DataScanJob resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataScanJob GetDataScanJob(GetDataScanJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataScanJobRequest(ref request, ref callSettings);
            return _callGetDataScanJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a DataScanJob resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataScanJob> GetDataScanJobAsync(GetDataScanJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataScanJobRequest(ref request, ref callSettings);
            return _callGetDataScanJob.Async(request, callSettings);
        }

        /// <summary>
        /// Lists DataScanJobs under the given DataScan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataScanJob"/> resources.</returns>
        public override gax::PagedEnumerable<ListDataScanJobsResponse, DataScanJob> ListDataScanJobs(ListDataScanJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataScanJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDataScanJobsRequest, ListDataScanJobsResponse, DataScanJob>(_callListDataScanJobs, request, callSettings);
        }

        /// <summary>
        /// Lists DataScanJobs under the given DataScan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataScanJob"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDataScanJobsResponse, DataScanJob> ListDataScanJobsAsync(ListDataScanJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataScanJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDataScanJobsRequest, ListDataScanJobsResponse, DataScanJob>(_callListDataScanJobs, request, callSettings);
        }

        /// <summary>
        /// Generates recommended data quality rules based on the results of a data
        /// profiling scan.
        /// 
        /// Use the recommendations to build rules for a data quality scan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateDataQualityRulesResponse GenerateDataQualityRules(GenerateDataQualityRulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateDataQualityRulesRequest(ref request, ref callSettings);
            return _callGenerateDataQualityRules.Sync(request, callSettings);
        }

        /// <summary>
        /// Generates recommended data quality rules based on the results of a data
        /// profiling scan.
        /// 
        /// Use the recommendations to build rules for a data quality scan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateDataQualityRulesResponse> GenerateDataQualityRulesAsync(GenerateDataQualityRulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateDataQualityRulesRequest(ref request, ref callSettings);
            return _callGenerateDataQualityRules.Async(request, callSettings);
        }
    }

    public partial class ListDataScansRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDataScanJobsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDataScansResponse : gaxgrpc::IPageResponse<DataScan>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DataScan> GetEnumerator() => DataScans.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDataScanJobsResponse : gaxgrpc::IPageResponse<DataScanJob>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DataScanJob> GetEnumerator() => DataScanJobs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class DataScanService
    {
        public partial class DataScanServiceClient
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

    public static partial class DataScanService
    {
        public partial class DataScanServiceClient
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
