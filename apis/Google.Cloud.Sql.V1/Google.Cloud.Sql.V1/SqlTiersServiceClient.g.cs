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
    /// <summary>Settings for <see cref="SqlTiersServiceClient"/> instances.</summary>
    public sealed partial class SqlTiersServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SqlTiersServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SqlTiersServiceSettings"/>.</returns>
        public static SqlTiersServiceSettings GetDefault() => new SqlTiersServiceSettings();

        /// <summary>Constructs a new <see cref="SqlTiersServiceSettings"/> object with default settings.</summary>
        public SqlTiersServiceSettings()
        {
        }

        private SqlTiersServiceSettings(SqlTiersServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListSettings = existing.ListSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SqlTiersServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>SqlTiersServiceClient.List</c>
        ///  and <c>SqlTiersServiceClient.ListAsync</c>.
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
        /// <returns>A deep clone of this <see cref="SqlTiersServiceSettings"/> object.</returns>
        public SqlTiersServiceSettings Clone() => new SqlTiersServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SqlTiersServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class SqlTiersServiceClientBuilder : gaxgrpc::ClientBuilderBase<SqlTiersServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SqlTiersServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SqlTiersServiceClientBuilder() : base(SqlTiersServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SqlTiersServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SqlTiersServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SqlTiersServiceClient Build()
        {
            SqlTiersServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SqlTiersServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SqlTiersServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SqlTiersServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SqlTiersServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SqlTiersServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SqlTiersServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SqlTiersServiceClient.ChannelPool;
    }

    /// <summary>SqlTiersService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for providing machine types (tiers) for Cloud SQL instances.
    /// </remarks>
    public abstract partial class SqlTiersServiceClient
    {
        /// <summary>
        /// The default endpoint for the SqlTiersService service, which is a host of "sqladmin.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "sqladmin.googleapis.com:443";

        /// <summary>The default SqlTiersService scopes.</summary>
        /// <remarks>
        /// The default SqlTiersService scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(SqlTiersService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SqlTiersServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SqlTiersServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SqlTiersServiceClient"/>.</returns>
        public static stt::Task<SqlTiersServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SqlTiersServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SqlTiersServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SqlTiersServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SqlTiersServiceClient"/>.</returns>
        public static SqlTiersServiceClient Create() => new SqlTiersServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SqlTiersServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SqlTiersServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SqlTiersServiceClient"/>.</returns>
        internal static SqlTiersServiceClient Create(grpccore::CallInvoker callInvoker, SqlTiersServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SqlTiersService.SqlTiersServiceClient grpcClient = new SqlTiersService.SqlTiersServiceClient(callInvoker);
            return new SqlTiersServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC SqlTiersService client</summary>
        public virtual SqlTiersService.SqlTiersServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all available machine types (tiers) for Cloud SQL, for example,
        /// `db-custom-1-3840`. For more information, see
        /// https://cloud.google.com/sql/pricing.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TiersListResponse List(SqlTiersListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all available machine types (tiers) for Cloud SQL, for example,
        /// `db-custom-1-3840`. For more information, see
        /// https://cloud.google.com/sql/pricing.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TiersListResponse> ListAsync(SqlTiersListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all available machine types (tiers) for Cloud SQL, for example,
        /// `db-custom-1-3840`. For more information, see
        /// https://cloud.google.com/sql/pricing.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TiersListResponse> ListAsync(SqlTiersListRequest request, st::CancellationToken cancellationToken) =>
            ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>SqlTiersService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for providing machine types (tiers) for Cloud SQL instances.
    /// </remarks>
    public sealed partial class SqlTiersServiceClientImpl : SqlTiersServiceClient
    {
        private readonly gaxgrpc::ApiCall<SqlTiersListRequest, TiersListResponse> _callList;

        /// <summary>
        /// Constructs a client wrapper for the SqlTiersService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SqlTiersServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SqlTiersServiceClientImpl(SqlTiersService.SqlTiersServiceClient grpcClient, SqlTiersServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SqlTiersServiceSettings effectiveSettings = settings ?? SqlTiersServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callList = clientHelper.BuildApiCall<SqlTiersListRequest, TiersListResponse>("List", grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<SqlTiersListRequest, TiersListResponse> call);

        partial void OnConstruction(SqlTiersService.SqlTiersServiceClient grpcClient, SqlTiersServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SqlTiersService client</summary>
        public override SqlTiersService.SqlTiersServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_SqlTiersListRequest(ref SqlTiersListRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists all available machine types (tiers) for Cloud SQL, for example,
        /// `db-custom-1-3840`. For more information, see
        /// https://cloud.google.com/sql/pricing.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TiersListResponse List(SqlTiersListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlTiersListRequest(ref request, ref callSettings);
            return _callList.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists all available machine types (tiers) for Cloud SQL, for example,
        /// `db-custom-1-3840`. For more information, see
        /// https://cloud.google.com/sql/pricing.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TiersListResponse> ListAsync(SqlTiersListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlTiersListRequest(ref request, ref callSettings);
            return _callList.Async(request, callSettings);
        }
    }

    public static partial class SqlTiersService
    {
        public partial class SqlTiersServiceClient
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
