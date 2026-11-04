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
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Sql.V1Beta4
{
    /// <summary>Settings for <see cref="SqlOperationsServiceClient"/> instances.</summary>
    public sealed partial class SqlOperationsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SqlOperationsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SqlOperationsServiceSettings"/>.</returns>
        public static SqlOperationsServiceSettings GetDefault() => new SqlOperationsServiceSettings();

        /// <summary>Constructs a new <see cref="SqlOperationsServiceSettings"/> object with default settings.</summary>
        public SqlOperationsServiceSettings()
        {
        }

        private SqlOperationsServiceSettings(SqlOperationsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetSettings = existing.GetSettings;
            ListSettings = existing.ListSettings;
            CancelSettings = existing.CancelSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SqlOperationsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlOperationsServiceClient.Get</c> and <c>SqlOperationsServiceClient.GetAsync</c>.
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
        /// <c>SqlOperationsServiceClient.List</c> and <c>SqlOperationsServiceClient.ListAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlOperationsServiceClient.Cancel</c> and <c>SqlOperationsServiceClient.CancelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CancelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SqlOperationsServiceSettings"/> object.</returns>
        public SqlOperationsServiceSettings Clone() => new SqlOperationsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SqlOperationsServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class SqlOperationsServiceClientBuilder : gaxgrpc::ClientBuilderBase<SqlOperationsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SqlOperationsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SqlOperationsServiceClientBuilder() : base(SqlOperationsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SqlOperationsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SqlOperationsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SqlOperationsServiceClient Build()
        {
            SqlOperationsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SqlOperationsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SqlOperationsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SqlOperationsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SqlOperationsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SqlOperationsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SqlOperationsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SqlOperationsServiceClient.ChannelPool;
    }

    /// <summary>SqlOperationsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch operations for database instances.
    /// </remarks>
    public abstract partial class SqlOperationsServiceClient
    {
        /// <summary>
        /// The default endpoint for the SqlOperationsService service, which is a host of "sqladmin.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "sqladmin.googleapis.com:443";

        /// <summary>The default SqlOperationsService scopes.</summary>
        /// <remarks>
        /// The default SqlOperationsService scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(SqlOperationsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SqlOperationsServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="SqlOperationsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SqlOperationsServiceClient"/>.</returns>
        public static stt::Task<SqlOperationsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SqlOperationsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SqlOperationsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="SqlOperationsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SqlOperationsServiceClient"/>.</returns>
        public static SqlOperationsServiceClient Create() => new SqlOperationsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SqlOperationsServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SqlOperationsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SqlOperationsServiceClient"/>.</returns>
        internal static SqlOperationsServiceClient Create(grpccore::CallInvoker callInvoker, SqlOperationsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SqlOperationsService.SqlOperationsServiceClient grpcClient = new SqlOperationsService.SqlOperationsServiceClient(callInvoker);
            return new SqlOperationsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC SqlOperationsService client</summary>
        public virtual SqlOperationsService.SqlOperationsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an instance operation that has been performed on an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Get(SqlOperationsGetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an instance operation that has been performed on an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> GetAsync(SqlOperationsGetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an instance operation that has been performed on an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> GetAsync(SqlOperationsGetRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all instance operations that have been performed on the given Cloud
        /// SQL instance in the reverse chronological order of the start time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Operation"/> resources.</returns>
        public virtual gax::PagedEnumerable<OperationsListResponse, Operation> List(SqlOperationsListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all instance operations that have been performed on the given Cloud
        /// SQL instance in the reverse chronological order of the start time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Operation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<OperationsListResponse, Operation> ListAsync(SqlOperationsListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels an instance operation that has been performed on an instance.
        /// Ordinarily, this method name should be `CancelSqlOperation`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void Cancel(SqlOperationsCancelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels an instance operation that has been performed on an instance.
        /// Ordinarily, this method name should be `CancelSqlOperation`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelAsync(SqlOperationsCancelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels an instance operation that has been performed on an instance.
        /// Ordinarily, this method name should be `CancelSqlOperation`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelAsync(SqlOperationsCancelRequest request, st::CancellationToken cancellationToken) =>
            CancelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>SqlOperationsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch operations for database instances.
    /// </remarks>
    public sealed partial class SqlOperationsServiceClientImpl : SqlOperationsServiceClient
    {
        private readonly gaxgrpc::ApiCall<SqlOperationsGetRequest, Operation> _callGet;

        private readonly gaxgrpc::ApiCall<SqlOperationsListRequest, OperationsListResponse> _callList;

        private readonly gaxgrpc::ApiCall<SqlOperationsCancelRequest, wkt::Empty> _callCancel;

        /// <summary>
        /// Constructs a client wrapper for the SqlOperationsService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SqlOperationsServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SqlOperationsServiceClientImpl(SqlOperationsService.SqlOperationsServiceClient grpcClient, SqlOperationsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SqlOperationsServiceSettings effectiveSettings = settings ?? SqlOperationsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callGet = clientHelper.BuildApiCall<SqlOperationsGetRequest, Operation>("Get", grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("operation", request => request.Operation);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callList = clientHelper.BuildApiCall<SqlOperationsListRequest, OperationsListResponse>("List", grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            _callCancel = clientHelper.BuildApiCall<SqlOperationsCancelRequest, wkt::Empty>("Cancel", grpcClient.CancelAsync, grpcClient.Cancel, effectiveSettings.CancelSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("operation", request => request.Operation);
            Modify_ApiCall(ref _callCancel);
            Modify_CancelApiCall(ref _callCancel);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<SqlOperationsGetRequest, Operation> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<SqlOperationsListRequest, OperationsListResponse> call);

        partial void Modify_CancelApiCall(ref gaxgrpc::ApiCall<SqlOperationsCancelRequest, wkt::Empty> call);

        partial void OnConstruction(SqlOperationsService.SqlOperationsServiceClient grpcClient, SqlOperationsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SqlOperationsService client</summary>
        public override SqlOperationsService.SqlOperationsServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_SqlOperationsGetRequest(ref SqlOperationsGetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlOperationsListRequest(ref SqlOperationsListRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlOperationsCancelRequest(ref SqlOperationsCancelRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves an instance operation that has been performed on an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Get(SqlOperationsGetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlOperationsGetRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves an instance operation that has been performed on an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> GetAsync(SqlOperationsGetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlOperationsGetRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all instance operations that have been performed on the given Cloud
        /// SQL instance in the reverse chronological order of the start time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Operation"/> resources.</returns>
        public override gax::PagedEnumerable<OperationsListResponse, Operation> List(SqlOperationsListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlOperationsListRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SqlOperationsListRequest, OperationsListResponse, Operation>(_callList, request, callSettings);
        }

        /// <summary>
        /// Lists all instance operations that have been performed on the given Cloud
        /// SQL instance in the reverse chronological order of the start time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Operation"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<OperationsListResponse, Operation> ListAsync(SqlOperationsListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlOperationsListRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SqlOperationsListRequest, OperationsListResponse, Operation>(_callList, request, callSettings);
        }

        /// <summary>
        /// Cancels an instance operation that has been performed on an instance.
        /// Ordinarily, this method name should be `CancelSqlOperation`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void Cancel(SqlOperationsCancelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlOperationsCancelRequest(ref request, ref callSettings);
            _callCancel.Sync(request, callSettings);
        }

        /// <summary>
        /// Cancels an instance operation that has been performed on an instance.
        /// Ordinarily, this method name should be `CancelSqlOperation`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task CancelAsync(SqlOperationsCancelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlOperationsCancelRequest(ref request, ref callSettings);
            return _callCancel.Async(request, callSettings);
        }
    }

    public partial class SqlOperationsListRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class OperationsListResponse : gaxgrpc::IPageResponse<Operation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Operation> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class SqlOperationsService
    {
        public partial class SqlOperationsServiceClient
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
