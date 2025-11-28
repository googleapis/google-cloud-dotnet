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
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.AlloyDb.V1
{
    /// <summary>Settings for <see cref="AlloyDBCSQLAdminClient"/> instances.</summary>
    public sealed partial class AlloyDBCSQLAdminSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AlloyDBCSQLAdminSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AlloyDBCSQLAdminSettings"/>.</returns>
        public static AlloyDBCSQLAdminSettings GetDefault() => new AlloyDBCSQLAdminSettings();

        /// <summary>Constructs a new <see cref="AlloyDBCSQLAdminSettings"/> object with default settings.</summary>
        public AlloyDBCSQLAdminSettings()
        {
        }

        private AlloyDBCSQLAdminSettings(AlloyDBCSQLAdminSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            RestoreFromCloudSQLSettings = existing.RestoreFromCloudSQLSettings;
            RestoreFromCloudSQLOperationsSettings = existing.RestoreFromCloudSQLOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(AlloyDBCSQLAdminSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlloyDBCSQLAdminClient.RestoreFromCloudSQL</c> and <c>AlloyDBCSQLAdminClient.RestoreFromCloudSQLAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RestoreFromCloudSQLSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>AlloyDBCSQLAdminClient.RestoreFromCloudSQL</c> and
        /// <c>AlloyDBCSQLAdminClient.RestoreFromCloudSQLAsync</c>.
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
        public lro::OperationsSettings RestoreFromCloudSQLOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AlloyDBCSQLAdminSettings"/> object.</returns>
        public AlloyDBCSQLAdminSettings Clone() => new AlloyDBCSQLAdminSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AlloyDBCSQLAdminClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class AlloyDBCSQLAdminClientBuilder : gaxgrpc::ClientBuilderBase<AlloyDBCSQLAdminClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AlloyDBCSQLAdminSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AlloyDBCSQLAdminClientBuilder() : base(AlloyDBCSQLAdminClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AlloyDBCSQLAdminClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AlloyDBCSQLAdminClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AlloyDBCSQLAdminClient Build()
        {
            AlloyDBCSQLAdminClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AlloyDBCSQLAdminClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AlloyDBCSQLAdminClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AlloyDBCSQLAdminClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AlloyDBCSQLAdminClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AlloyDBCSQLAdminClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AlloyDBCSQLAdminClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AlloyDBCSQLAdminClient.ChannelPool;
    }

    /// <summary>AlloyDBCSQLAdmin client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for interactions with CloudSQL.
    /// </remarks>
    public abstract partial class AlloyDBCSQLAdminClient
    {
        /// <summary>
        /// The default endpoint for the AlloyDBCSQLAdmin service, which is a host of "alloydb.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "alloydb.googleapis.com:443";

        /// <summary>The default AlloyDBCSQLAdmin scopes.</summary>
        /// <remarks>
        /// The default AlloyDBCSQLAdmin scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AlloyDBCSQLAdmin.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AlloyDBCSQLAdminClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AlloyDBCSQLAdminClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AlloyDBCSQLAdminClient"/>.</returns>
        public static stt::Task<AlloyDBCSQLAdminClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AlloyDBCSQLAdminClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AlloyDBCSQLAdminClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AlloyDBCSQLAdminClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AlloyDBCSQLAdminClient"/>.</returns>
        public static AlloyDBCSQLAdminClient Create() => new AlloyDBCSQLAdminClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AlloyDBCSQLAdminClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AlloyDBCSQLAdminSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AlloyDBCSQLAdminClient"/>.</returns>
        internal static AlloyDBCSQLAdminClient Create(grpccore::CallInvoker callInvoker, AlloyDBCSQLAdminSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AlloyDBCSQLAdmin.AlloyDBCSQLAdminClient grpcClient = new AlloyDBCSQLAdmin.AlloyDBCSQLAdminClient(callInvoker);
            return new AlloyDBCSQLAdminClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AlloyDBCSQLAdmin client</summary>
        public virtual AlloyDBCSQLAdmin.AlloyDBCSQLAdminClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Restores an AlloyDB cluster from a CloudSQL resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Cluster, OperationMetadata> RestoreFromCloudSQL(RestoreFromCloudSQLRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Restores an AlloyDB cluster from a CloudSQL resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> RestoreFromCloudSQLAsync(RestoreFromCloudSQLRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Restores an AlloyDB cluster from a CloudSQL resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> RestoreFromCloudSQLAsync(RestoreFromCloudSQLRequest request, st::CancellationToken cancellationToken) =>
            RestoreFromCloudSQLAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RestoreFromCloudSQL</c>.</summary>
        public virtual lro::OperationsClient RestoreFromCloudSQLOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RestoreFromCloudSQL</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Cluster, OperationMetadata> PollOnceRestoreFromCloudSQL(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Cluster, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RestoreFromCloudSQLOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RestoreFromCloudSQL</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> PollOnceRestoreFromCloudSQLAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Cluster, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RestoreFromCloudSQLOperationsClient, callSettings);

        /// <summary>
        /// Restores an AlloyDB cluster from a CloudSQL resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The location of the new cluster. For the required format, see the
        /// comment on Cluster.name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. ID of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Cluster, OperationMetadata> RestoreFromCloudSQL(string parent, string clusterId, gaxgrpc::CallSettings callSettings = null) =>
            RestoreFromCloudSQL(new RestoreFromCloudSQLRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
            }, callSettings);

        /// <summary>
        /// Restores an AlloyDB cluster from a CloudSQL resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The location of the new cluster. For the required format, see the
        /// comment on Cluster.name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. ID of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> RestoreFromCloudSQLAsync(string parent, string clusterId, gaxgrpc::CallSettings callSettings = null) =>
            RestoreFromCloudSQLAsync(new RestoreFromCloudSQLRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
            }, callSettings);

        /// <summary>
        /// Restores an AlloyDB cluster from a CloudSQL resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The location of the new cluster. For the required format, see the
        /// comment on Cluster.name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. ID of the requesting object.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> RestoreFromCloudSQLAsync(string parent, string clusterId, st::CancellationToken cancellationToken) =>
            RestoreFromCloudSQLAsync(parent, clusterId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Restores an AlloyDB cluster from a CloudSQL resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The location of the new cluster. For the required format, see the
        /// comment on Cluster.name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. ID of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Cluster, OperationMetadata> RestoreFromCloudSQL(gagr::LocationName parent, string clusterId, gaxgrpc::CallSettings callSettings = null) =>
            RestoreFromCloudSQL(new RestoreFromCloudSQLRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
            }, callSettings);

        /// <summary>
        /// Restores an AlloyDB cluster from a CloudSQL resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The location of the new cluster. For the required format, see the
        /// comment on Cluster.name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. ID of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> RestoreFromCloudSQLAsync(gagr::LocationName parent, string clusterId, gaxgrpc::CallSettings callSettings = null) =>
            RestoreFromCloudSQLAsync(new RestoreFromCloudSQLRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
            }, callSettings);

        /// <summary>
        /// Restores an AlloyDB cluster from a CloudSQL resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The location of the new cluster. For the required format, see the
        /// comment on Cluster.name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. ID of the requesting object.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> RestoreFromCloudSQLAsync(gagr::LocationName parent, string clusterId, st::CancellationToken cancellationToken) =>
            RestoreFromCloudSQLAsync(parent, clusterId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AlloyDBCSQLAdmin client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for interactions with CloudSQL.
    /// </remarks>
    public sealed partial class AlloyDBCSQLAdminClientImpl : AlloyDBCSQLAdminClient
    {
        private readonly gaxgrpc::ApiCall<RestoreFromCloudSQLRequest, lro::Operation> _callRestoreFromCloudSQL;

        /// <summary>
        /// Constructs a client wrapper for the AlloyDBCSQLAdmin service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AlloyDBCSQLAdminSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AlloyDBCSQLAdminClientImpl(AlloyDBCSQLAdmin.AlloyDBCSQLAdminClient grpcClient, AlloyDBCSQLAdminSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AlloyDBCSQLAdminSettings effectiveSettings = settings ?? AlloyDBCSQLAdminSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            RestoreFromCloudSQLOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RestoreFromCloudSQLOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callRestoreFromCloudSQL = clientHelper.BuildApiCall<RestoreFromCloudSQLRequest, lro::Operation>("RestoreFromCloudSQL", grpcClient.RestoreFromCloudSQLAsync, grpcClient.RestoreFromCloudSQL, effectiveSettings.RestoreFromCloudSQLSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callRestoreFromCloudSQL);
            Modify_RestoreFromCloudSQLApiCall(ref _callRestoreFromCloudSQL);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_RestoreFromCloudSQLApiCall(ref gaxgrpc::ApiCall<RestoreFromCloudSQLRequest, lro::Operation> call);

        partial void OnConstruction(AlloyDBCSQLAdmin.AlloyDBCSQLAdminClient grpcClient, AlloyDBCSQLAdminSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AlloyDBCSQLAdmin client</summary>
        public override AlloyDBCSQLAdmin.AlloyDBCSQLAdminClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_RestoreFromCloudSQLRequest(ref RestoreFromCloudSQLRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>RestoreFromCloudSQL</c>.</summary>
        public override lro::OperationsClient RestoreFromCloudSQLOperationsClient { get; }

        /// <summary>
        /// Restores an AlloyDB cluster from a CloudSQL resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Cluster, OperationMetadata> RestoreFromCloudSQL(RestoreFromCloudSQLRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestoreFromCloudSQLRequest(ref request, ref callSettings);
            return new lro::Operation<Cluster, OperationMetadata>(_callRestoreFromCloudSQL.Sync(request, callSettings), RestoreFromCloudSQLOperationsClient);
        }

        /// <summary>
        /// Restores an AlloyDB cluster from a CloudSQL resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Cluster, OperationMetadata>> RestoreFromCloudSQLAsync(RestoreFromCloudSQLRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestoreFromCloudSQLRequest(ref request, ref callSettings);
            return new lro::Operation<Cluster, OperationMetadata>(await _callRestoreFromCloudSQL.Async(request, callSettings).ConfigureAwait(false), RestoreFromCloudSQLOperationsClient);
        }
    }

    public static partial class AlloyDBCSQLAdmin
    {
        public partial class AlloyDBCSQLAdminClient
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

    public static partial class AlloyDBCSQLAdmin
    {
        public partial class AlloyDBCSQLAdminClient
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
