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

namespace Google.Cloud.Sql.V1
{
    /// <summary>Settings for <see cref="SqlWorkloadCapturesServiceClient"/> instances.</summary>
    public sealed partial class SqlWorkloadCapturesServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SqlWorkloadCapturesServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SqlWorkloadCapturesServiceSettings"/>.</returns>
        public static SqlWorkloadCapturesServiceSettings GetDefault() => new SqlWorkloadCapturesServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="SqlWorkloadCapturesServiceSettings"/> object with default settings.
        /// </summary>
        public SqlWorkloadCapturesServiceSettings()
        {
        }

        private SqlWorkloadCapturesServiceSettings(SqlWorkloadCapturesServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            StartSettings = existing.StartSettings;
            StopSettings = existing.StopSettings;
            StartReplaySettings = existing.StartReplaySettings;
            StopReplaySettings = existing.StopReplaySettings;
            ListSettings = existing.ListSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SqlWorkloadCapturesServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlWorkloadCapturesServiceClient.Start</c> and <c>SqlWorkloadCapturesServiceClient.StartAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StartSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlWorkloadCapturesServiceClient.Stop</c> and <c>SqlWorkloadCapturesServiceClient.StopAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StopSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlWorkloadCapturesServiceClient.StartReplay</c> and <c>SqlWorkloadCapturesServiceClient.StartReplayAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StartReplaySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlWorkloadCapturesServiceClient.StopReplay</c> and <c>SqlWorkloadCapturesServiceClient.StopReplayAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StopReplaySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlWorkloadCapturesServiceClient.List</c> and <c>SqlWorkloadCapturesServiceClient.ListAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SqlWorkloadCapturesServiceSettings"/> object.</returns>
        public SqlWorkloadCapturesServiceSettings Clone() => new SqlWorkloadCapturesServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SqlWorkloadCapturesServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class SqlWorkloadCapturesServiceClientBuilder : gaxgrpc::ClientBuilderBase<SqlWorkloadCapturesServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SqlWorkloadCapturesServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SqlWorkloadCapturesServiceClientBuilder() : base(SqlWorkloadCapturesServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SqlWorkloadCapturesServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SqlWorkloadCapturesServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SqlWorkloadCapturesServiceClient Build()
        {
            SqlWorkloadCapturesServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SqlWorkloadCapturesServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SqlWorkloadCapturesServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SqlWorkloadCapturesServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SqlWorkloadCapturesServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SqlWorkloadCapturesServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SqlWorkloadCapturesServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SqlWorkloadCapturesServiceClient.ChannelPool;
    }

    /// <summary>SqlWorkloadCapturesService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Cloud SQL Workload Captures service.
    /// </remarks>
    public abstract partial class SqlWorkloadCapturesServiceClient
    {
        /// <summary>
        /// The default endpoint for the SqlWorkloadCapturesService service, which is a host of
        /// "sqladmin.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "sqladmin.googleapis.com:443";

        /// <summary>The default SqlWorkloadCapturesService scopes.</summary>
        /// <remarks>
        /// The default SqlWorkloadCapturesService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/sqlservice.admin</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/sqlservice.admin",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(SqlWorkloadCapturesService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SqlWorkloadCapturesServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="SqlWorkloadCapturesServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SqlWorkloadCapturesServiceClient"/>.</returns>
        public static stt::Task<SqlWorkloadCapturesServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SqlWorkloadCapturesServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SqlWorkloadCapturesServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="SqlWorkloadCapturesServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SqlWorkloadCapturesServiceClient"/>.</returns>
        public static SqlWorkloadCapturesServiceClient Create() => new SqlWorkloadCapturesServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SqlWorkloadCapturesServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SqlWorkloadCapturesServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SqlWorkloadCapturesServiceClient"/>.</returns>
        internal static SqlWorkloadCapturesServiceClient Create(grpccore::CallInvoker callInvoker, SqlWorkloadCapturesServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SqlWorkloadCapturesService.SqlWorkloadCapturesServiceClient grpcClient = new SqlWorkloadCapturesService.SqlWorkloadCapturesServiceClient(callInvoker);
            return new SqlWorkloadCapturesServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC SqlWorkloadCapturesService client</summary>
        public virtual SqlWorkloadCapturesService.SqlWorkloadCapturesServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Starts capturing the SQL queries, transactions, and other operations
        /// executed on the primary instance. This traffic is securely stored and forms
        /// a "captured workload". This workload can be replayed later on a different
        /// instance to safely test performance impacts, database upgrades,
        /// configuration changes etc. before applying them to production.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Start(WorkloadCapturesStartRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts capturing the SQL queries, transactions, and other operations
        /// executed on the primary instance. This traffic is securely stored and forms
        /// a "captured workload". This workload can be replayed later on a different
        /// instance to safely test performance impacts, database upgrades,
        /// configuration changes etc. before applying them to production.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> StartAsync(WorkloadCapturesStartRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts capturing the SQL queries, transactions, and other operations
        /// executed on the primary instance. This traffic is securely stored and forms
        /// a "captured workload". This workload can be replayed later on a different
        /// instance to safely test performance impacts, database upgrades,
        /// configuration changes etc. before applying them to production.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> StartAsync(WorkloadCapturesStartRequest request, st::CancellationToken cancellationToken) =>
            StartAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Stops capturing the query traffic and related operations executed on the
        /// primary instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Stop(WorkloadCapturesStopRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops capturing the query traffic and related operations executed on the
        /// primary instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> StopAsync(WorkloadCapturesStopRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops capturing the query traffic and related operations executed on the
        /// primary instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> StopAsync(WorkloadCapturesStopRequest request, st::CancellationToken cancellationToken) =>
            StopAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts executing a captured workload on a separate Cloud SQL instance
        /// provisioned for workload replay. This target instance simulates the
        /// production environment without affecting the primary instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation StartReplay(WorkloadCapturesStartReplayRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts executing a captured workload on a separate Cloud SQL instance
        /// provisioned for workload replay. This target instance simulates the
        /// production environment without affecting the primary instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> StartReplayAsync(WorkloadCapturesStartReplayRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts executing a captured workload on a separate Cloud SQL instance
        /// provisioned for workload replay. This target instance simulates the
        /// production environment without affecting the primary instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> StartReplayAsync(WorkloadCapturesStartReplayRequest request, st::CancellationToken cancellationToken) =>
            StartReplayAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Stops an active workload replay on the target Cloud SQL replay instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation StopReplay(WorkloadCapturesStopReplayRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops an active workload replay on the target Cloud SQL replay instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> StopReplayAsync(WorkloadCapturesStopReplayRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops an active workload replay on the target Cloud SQL replay instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> StopReplayAsync(WorkloadCapturesStopReplayRequest request, st::CancellationToken cancellationToken) =>
            StopReplayAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all captured workloads associated with the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WorkloadCapturesListResponse List(SqlWorkloadCapturesListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all captured workloads associated with the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkloadCapturesListResponse> ListAsync(SqlWorkloadCapturesListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all captured workloads associated with the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkloadCapturesListResponse> ListAsync(SqlWorkloadCapturesListRequest request, st::CancellationToken cancellationToken) =>
            ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>SqlWorkloadCapturesService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Cloud SQL Workload Captures service.
    /// </remarks>
    public sealed partial class SqlWorkloadCapturesServiceClientImpl : SqlWorkloadCapturesServiceClient
    {
        private readonly gaxgrpc::ApiCall<WorkloadCapturesStartRequest, Operation> _callStart;

        private readonly gaxgrpc::ApiCall<WorkloadCapturesStopRequest, Operation> _callStop;

        private readonly gaxgrpc::ApiCall<WorkloadCapturesStartReplayRequest, Operation> _callStartReplay;

        private readonly gaxgrpc::ApiCall<WorkloadCapturesStopReplayRequest, Operation> _callStopReplay;

        private readonly gaxgrpc::ApiCall<SqlWorkloadCapturesListRequest, WorkloadCapturesListResponse> _callList;

        /// <summary>
        /// Constructs a client wrapper for the SqlWorkloadCapturesService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="SqlWorkloadCapturesServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SqlWorkloadCapturesServiceClientImpl(SqlWorkloadCapturesService.SqlWorkloadCapturesServiceClient grpcClient, SqlWorkloadCapturesServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SqlWorkloadCapturesServiceSettings effectiveSettings = settings ?? SqlWorkloadCapturesServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callStart = clientHelper.BuildApiCall<WorkloadCapturesStartRequest, Operation>("Start", grpcClient.StartAsync, grpcClient.Start, effectiveSettings.StartSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callStart);
            Modify_StartApiCall(ref _callStart);
            _callStop = clientHelper.BuildApiCall<WorkloadCapturesStopRequest, Operation>("Stop", grpcClient.StopAsync, grpcClient.Stop, effectiveSettings.StopSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callStop);
            Modify_StopApiCall(ref _callStop);
            _callStartReplay = clientHelper.BuildApiCall<WorkloadCapturesStartReplayRequest, Operation>("StartReplay", grpcClient.StartReplayAsync, grpcClient.StartReplay, effectiveSettings.StartReplaySettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance).WithGoogleRequestParam("workload_id", request => request.WorkloadId);
            Modify_ApiCall(ref _callStartReplay);
            Modify_StartReplayApiCall(ref _callStartReplay);
            _callStopReplay = clientHelper.BuildApiCall<WorkloadCapturesStopReplayRequest, Operation>("StopReplay", grpcClient.StopReplayAsync, grpcClient.StopReplay, effectiveSettings.StopReplaySettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callStopReplay);
            Modify_StopReplayApiCall(ref _callStopReplay);
            _callList = clientHelper.BuildApiCall<SqlWorkloadCapturesListRequest, WorkloadCapturesListResponse>("List", grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_StartApiCall(ref gaxgrpc::ApiCall<WorkloadCapturesStartRequest, Operation> call);

        partial void Modify_StopApiCall(ref gaxgrpc::ApiCall<WorkloadCapturesStopRequest, Operation> call);

        partial void Modify_StartReplayApiCall(ref gaxgrpc::ApiCall<WorkloadCapturesStartReplayRequest, Operation> call);

        partial void Modify_StopReplayApiCall(ref gaxgrpc::ApiCall<WorkloadCapturesStopReplayRequest, Operation> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<SqlWorkloadCapturesListRequest, WorkloadCapturesListResponse> call);

        partial void OnConstruction(SqlWorkloadCapturesService.SqlWorkloadCapturesServiceClient grpcClient, SqlWorkloadCapturesServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SqlWorkloadCapturesService client</summary>
        public override SqlWorkloadCapturesService.SqlWorkloadCapturesServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_WorkloadCapturesStartRequest(ref WorkloadCapturesStartRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_WorkloadCapturesStopRequest(ref WorkloadCapturesStopRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_WorkloadCapturesStartReplayRequest(ref WorkloadCapturesStartReplayRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_WorkloadCapturesStopReplayRequest(ref WorkloadCapturesStopReplayRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlWorkloadCapturesListRequest(ref SqlWorkloadCapturesListRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Starts capturing the SQL queries, transactions, and other operations
        /// executed on the primary instance. This traffic is securely stored and forms
        /// a "captured workload". This workload can be replayed later on a different
        /// instance to safely test performance impacts, database upgrades,
        /// configuration changes etc. before applying them to production.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Start(WorkloadCapturesStartRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_WorkloadCapturesStartRequest(ref request, ref callSettings);
            return _callStart.Sync(request, callSettings);
        }

        /// <summary>
        /// Starts capturing the SQL queries, transactions, and other operations
        /// executed on the primary instance. This traffic is securely stored and forms
        /// a "captured workload". This workload can be replayed later on a different
        /// instance to safely test performance impacts, database upgrades,
        /// configuration changes etc. before applying them to production.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> StartAsync(WorkloadCapturesStartRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_WorkloadCapturesStartRequest(ref request, ref callSettings);
            return _callStart.Async(request, callSettings);
        }

        /// <summary>
        /// Stops capturing the query traffic and related operations executed on the
        /// primary instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Stop(WorkloadCapturesStopRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_WorkloadCapturesStopRequest(ref request, ref callSettings);
            return _callStop.Sync(request, callSettings);
        }

        /// <summary>
        /// Stops capturing the query traffic and related operations executed on the
        /// primary instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> StopAsync(WorkloadCapturesStopRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_WorkloadCapturesStopRequest(ref request, ref callSettings);
            return _callStop.Async(request, callSettings);
        }

        /// <summary>
        /// Starts executing a captured workload on a separate Cloud SQL instance
        /// provisioned for workload replay. This target instance simulates the
        /// production environment without affecting the primary instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation StartReplay(WorkloadCapturesStartReplayRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_WorkloadCapturesStartReplayRequest(ref request, ref callSettings);
            return _callStartReplay.Sync(request, callSettings);
        }

        /// <summary>
        /// Starts executing a captured workload on a separate Cloud SQL instance
        /// provisioned for workload replay. This target instance simulates the
        /// production environment without affecting the primary instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> StartReplayAsync(WorkloadCapturesStartReplayRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_WorkloadCapturesStartReplayRequest(ref request, ref callSettings);
            return _callStartReplay.Async(request, callSettings);
        }

        /// <summary>
        /// Stops an active workload replay on the target Cloud SQL replay instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation StopReplay(WorkloadCapturesStopReplayRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_WorkloadCapturesStopReplayRequest(ref request, ref callSettings);
            return _callStopReplay.Sync(request, callSettings);
        }

        /// <summary>
        /// Stops an active workload replay on the target Cloud SQL replay instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> StopReplayAsync(WorkloadCapturesStopReplayRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_WorkloadCapturesStopReplayRequest(ref request, ref callSettings);
            return _callStopReplay.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all captured workloads associated with the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override WorkloadCapturesListResponse List(SqlWorkloadCapturesListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlWorkloadCapturesListRequest(ref request, ref callSettings);
            return _callList.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists all captured workloads associated with the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<WorkloadCapturesListResponse> ListAsync(SqlWorkloadCapturesListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlWorkloadCapturesListRequest(ref request, ref callSettings);
            return _callList.Async(request, callSettings);
        }
    }

    public static partial class SqlWorkloadCapturesService
    {
        public partial class SqlWorkloadCapturesServiceClient
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
