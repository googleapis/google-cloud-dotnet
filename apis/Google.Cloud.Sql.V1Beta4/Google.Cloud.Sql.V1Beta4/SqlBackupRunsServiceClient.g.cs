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
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.Sql.V1Beta4
{
    /// <summary>Settings for <see cref="SqlBackupRunsServiceClient"/> instances.</summary>
    public sealed partial class SqlBackupRunsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SqlBackupRunsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SqlBackupRunsServiceSettings"/>.</returns>
        public static SqlBackupRunsServiceSettings GetDefault() => new SqlBackupRunsServiceSettings();

        /// <summary>Constructs a new <see cref="SqlBackupRunsServiceSettings"/> object with default settings.</summary>
        public SqlBackupRunsServiceSettings()
        {
        }

        private SqlBackupRunsServiceSettings(SqlBackupRunsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            DeleteSettings = existing.DeleteSettings;
            GetSettings = existing.GetSettings;
            InsertSettings = existing.InsertSettings;
            ListSettings = existing.ListSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SqlBackupRunsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlBackupRunsServiceClient.Delete</c> and <c>SqlBackupRunsServiceClient.DeleteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlBackupRunsServiceClient.Get</c> and <c>SqlBackupRunsServiceClient.GetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlBackupRunsServiceClient.Insert</c> and <c>SqlBackupRunsServiceClient.InsertAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InsertSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlBackupRunsServiceClient.List</c> and <c>SqlBackupRunsServiceClient.ListAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SqlBackupRunsServiceSettings"/> object.</returns>
        public SqlBackupRunsServiceSettings Clone() => new SqlBackupRunsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SqlBackupRunsServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class SqlBackupRunsServiceClientBuilder : gaxgrpc::ClientBuilderBase<SqlBackupRunsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SqlBackupRunsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SqlBackupRunsServiceClientBuilder() : base(SqlBackupRunsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SqlBackupRunsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SqlBackupRunsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SqlBackupRunsServiceClient Build()
        {
            SqlBackupRunsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SqlBackupRunsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SqlBackupRunsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SqlBackupRunsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SqlBackupRunsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SqlBackupRunsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SqlBackupRunsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SqlBackupRunsServiceClient.ChannelPool;
    }

    /// <summary>SqlBackupRunsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing database backups.
    /// </remarks>
    public abstract partial class SqlBackupRunsServiceClient
    {
        /// <summary>
        /// The default endpoint for the SqlBackupRunsService service, which is a host of "sqladmin.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "sqladmin.googleapis.com:443";

        /// <summary>The default SqlBackupRunsService scopes.</summary>
        /// <remarks>
        /// The default SqlBackupRunsService scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(SqlBackupRunsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SqlBackupRunsServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="SqlBackupRunsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SqlBackupRunsServiceClient"/>.</returns>
        public static stt::Task<SqlBackupRunsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SqlBackupRunsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SqlBackupRunsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="SqlBackupRunsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SqlBackupRunsServiceClient"/>.</returns>
        public static SqlBackupRunsServiceClient Create() => new SqlBackupRunsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SqlBackupRunsServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SqlBackupRunsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SqlBackupRunsServiceClient"/>.</returns>
        internal static SqlBackupRunsServiceClient Create(grpccore::CallInvoker callInvoker, SqlBackupRunsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SqlBackupRunsService.SqlBackupRunsServiceClient grpcClient = new SqlBackupRunsService.SqlBackupRunsServiceClient(callInvoker);
            return new SqlBackupRunsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC SqlBackupRunsService client</summary>
        public virtual SqlBackupRunsService.SqlBackupRunsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the backup taken by a backup run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Delete(SqlBackupRunsDeleteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the backup taken by a backup run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(SqlBackupRunsDeleteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the backup taken by a backup run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(SqlBackupRunsDeleteRequest request, st::CancellationToken cancellationToken) =>
            DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a resource containing information about a backup run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BackupRun Get(SqlBackupRunsGetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a resource containing information about a backup run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupRun> GetAsync(SqlBackupRunsGetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a resource containing information about a backup run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupRun> GetAsync(SqlBackupRunsGetRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new backup run on demand.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Insert(SqlBackupRunsInsertRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new backup run on demand.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(SqlBackupRunsInsertRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new backup run on demand.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(SqlBackupRunsInsertRequest request, st::CancellationToken cancellationToken) =>
            InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all backup runs associated with the project or a given instance and
        /// configuration in the reverse chronological order of the backup initiation
        /// time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BackupRun"/> resources.</returns>
        public virtual gax::PagedEnumerable<BackupRunsListResponse, BackupRun> List(SqlBackupRunsListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all backup runs associated with the project or a given instance and
        /// configuration in the reverse chronological order of the backup initiation
        /// time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BackupRun"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<BackupRunsListResponse, BackupRun> ListAsync(SqlBackupRunsListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();
    }

    /// <summary>SqlBackupRunsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing database backups.
    /// </remarks>
    public sealed partial class SqlBackupRunsServiceClientImpl : SqlBackupRunsServiceClient
    {
        private readonly gaxgrpc::ApiCall<SqlBackupRunsDeleteRequest, Operation> _callDelete;

        private readonly gaxgrpc::ApiCall<SqlBackupRunsGetRequest, BackupRun> _callGet;

        private readonly gaxgrpc::ApiCall<SqlBackupRunsInsertRequest, Operation> _callInsert;

        private readonly gaxgrpc::ApiCall<SqlBackupRunsListRequest, BackupRunsListResponse> _callList;

        /// <summary>
        /// Constructs a client wrapper for the SqlBackupRunsService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SqlBackupRunsServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SqlBackupRunsServiceClientImpl(SqlBackupRunsService.SqlBackupRunsServiceClient grpcClient, SqlBackupRunsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SqlBackupRunsServiceSettings effectiveSettings = settings ?? SqlBackupRunsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callDelete = clientHelper.BuildApiCall<SqlBackupRunsDeleteRequest, Operation>("Delete", grpcClient.DeleteAsync, grpcClient.Delete, effectiveSettings.DeleteSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance).WithGoogleRequestParam("id", request => gaxgrpc::RoutingHeaderExtractor<SqlBackupRunsDeleteRequest>.FormatRoutingHeaderValue(request.Id));
            Modify_ApiCall(ref _callDelete);
            Modify_DeleteApiCall(ref _callDelete);
            _callGet = clientHelper.BuildApiCall<SqlBackupRunsGetRequest, BackupRun>("Get", grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance).WithGoogleRequestParam("id", request => gaxgrpc::RoutingHeaderExtractor<SqlBackupRunsGetRequest>.FormatRoutingHeaderValue(request.Id));
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callInsert = clientHelper.BuildApiCall<SqlBackupRunsInsertRequest, Operation>("Insert", grpcClient.InsertAsync, grpcClient.Insert, effectiveSettings.InsertSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callInsert);
            Modify_InsertApiCall(ref _callInsert);
            _callList = clientHelper.BuildApiCall<SqlBackupRunsListRequest, BackupRunsListResponse>("List", grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_DeleteApiCall(ref gaxgrpc::ApiCall<SqlBackupRunsDeleteRequest, Operation> call);

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<SqlBackupRunsGetRequest, BackupRun> call);

        partial void Modify_InsertApiCall(ref gaxgrpc::ApiCall<SqlBackupRunsInsertRequest, Operation> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<SqlBackupRunsListRequest, BackupRunsListResponse> call);

        partial void OnConstruction(SqlBackupRunsService.SqlBackupRunsServiceClient grpcClient, SqlBackupRunsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SqlBackupRunsService client</summary>
        public override SqlBackupRunsService.SqlBackupRunsServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_SqlBackupRunsDeleteRequest(ref SqlBackupRunsDeleteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlBackupRunsGetRequest(ref SqlBackupRunsGetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlBackupRunsInsertRequest(ref SqlBackupRunsInsertRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlBackupRunsListRequest(ref SqlBackupRunsListRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Deletes the backup taken by a backup run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Delete(SqlBackupRunsDeleteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlBackupRunsDeleteRequest(ref request, ref callSettings);
            return _callDelete.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the backup taken by a backup run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> DeleteAsync(SqlBackupRunsDeleteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlBackupRunsDeleteRequest(ref request, ref callSettings);
            return _callDelete.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a resource containing information about a backup run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BackupRun Get(SqlBackupRunsGetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlBackupRunsGetRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a resource containing information about a backup run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BackupRun> GetAsync(SqlBackupRunsGetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlBackupRunsGetRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new backup run on demand.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Insert(SqlBackupRunsInsertRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlBackupRunsInsertRequest(ref request, ref callSettings);
            return _callInsert.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new backup run on demand.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> InsertAsync(SqlBackupRunsInsertRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlBackupRunsInsertRequest(ref request, ref callSettings);
            return _callInsert.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all backup runs associated with the project or a given instance and
        /// configuration in the reverse chronological order of the backup initiation
        /// time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BackupRun"/> resources.</returns>
        public override gax::PagedEnumerable<BackupRunsListResponse, BackupRun> List(SqlBackupRunsListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlBackupRunsListRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SqlBackupRunsListRequest, BackupRunsListResponse, BackupRun>(_callList, request, callSettings);
        }

        /// <summary>
        /// Lists all backup runs associated with the project or a given instance and
        /// configuration in the reverse chronological order of the backup initiation
        /// time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BackupRun"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<BackupRunsListResponse, BackupRun> ListAsync(SqlBackupRunsListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlBackupRunsListRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SqlBackupRunsListRequest, BackupRunsListResponse, BackupRun>(_callList, request, callSettings);
        }
    }

    public partial class SqlBackupRunsListRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => MaxResults;
            set => MaxResults = value;
        }
    }

    public partial class BackupRunsListResponse : gaxgrpc::IPageResponse<BackupRun>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<BackupRun> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class SqlBackupRunsService
    {
        public partial class SqlBackupRunsServiceClient
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
