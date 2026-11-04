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

namespace Google.Cloud.Sql.V1Beta4
{
    /// <summary>Settings for <see cref="SqlFlagsServiceClient"/> instances.</summary>
    public sealed partial class SqlFlagsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SqlFlagsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SqlFlagsServiceSettings"/>.</returns>
        public static SqlFlagsServiceSettings GetDefault() => new SqlFlagsServiceSettings();

        /// <summary>Constructs a new <see cref="SqlFlagsServiceSettings"/> object with default settings.</summary>
        public SqlFlagsServiceSettings()
        {
        }

        private SqlFlagsServiceSettings(SqlFlagsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListSettings = existing.ListSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SqlFlagsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>SqlFlagsServiceClient.List</c>
        ///  and <c>SqlFlagsServiceClient.ListAsync</c>.
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
        /// <returns>A deep clone of this <see cref="SqlFlagsServiceSettings"/> object.</returns>
        public SqlFlagsServiceSettings Clone() => new SqlFlagsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SqlFlagsServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class SqlFlagsServiceClientBuilder : gaxgrpc::ClientBuilderBase<SqlFlagsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SqlFlagsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SqlFlagsServiceClientBuilder() : base(SqlFlagsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SqlFlagsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SqlFlagsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SqlFlagsServiceClient Build()
        {
            SqlFlagsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SqlFlagsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SqlFlagsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SqlFlagsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SqlFlagsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SqlFlagsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SqlFlagsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SqlFlagsServiceClient.ChannelPool;
    }

    /// <summary>SqlFlagsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage database flags for Cloud SQL instances.
    /// </remarks>
    public abstract partial class SqlFlagsServiceClient
    {
        /// <summary>
        /// The default endpoint for the SqlFlagsService service, which is a host of "sqladmin.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "sqladmin.googleapis.com:443";

        /// <summary>The default SqlFlagsService scopes.</summary>
        /// <remarks>
        /// The default SqlFlagsService scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(SqlFlagsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SqlFlagsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SqlFlagsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SqlFlagsServiceClient"/>.</returns>
        public static stt::Task<SqlFlagsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SqlFlagsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SqlFlagsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SqlFlagsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SqlFlagsServiceClient"/>.</returns>
        public static SqlFlagsServiceClient Create() => new SqlFlagsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SqlFlagsServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SqlFlagsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SqlFlagsServiceClient"/>.</returns>
        internal static SqlFlagsServiceClient Create(grpccore::CallInvoker callInvoker, SqlFlagsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SqlFlagsService.SqlFlagsServiceClient grpcClient = new SqlFlagsService.SqlFlagsServiceClient(callInvoker);
            return new SqlFlagsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC SqlFlagsService client</summary>
        public virtual SqlFlagsService.SqlFlagsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all available database flags for Cloud SQL instances.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FlagsListResponse List(SqlFlagsListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all available database flags for Cloud SQL instances.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FlagsListResponse> ListAsync(SqlFlagsListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all available database flags for Cloud SQL instances.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FlagsListResponse> ListAsync(SqlFlagsListRequest request, st::CancellationToken cancellationToken) =>
            ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>SqlFlagsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage database flags for Cloud SQL instances.
    /// </remarks>
    public sealed partial class SqlFlagsServiceClientImpl : SqlFlagsServiceClient
    {
        private readonly gaxgrpc::ApiCall<SqlFlagsListRequest, FlagsListResponse> _callList;

        /// <summary>
        /// Constructs a client wrapper for the SqlFlagsService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SqlFlagsServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SqlFlagsServiceClientImpl(SqlFlagsService.SqlFlagsServiceClient grpcClient, SqlFlagsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SqlFlagsServiceSettings effectiveSettings = settings ?? SqlFlagsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callList = clientHelper.BuildApiCall<SqlFlagsListRequest, FlagsListResponse>("List", grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<SqlFlagsListRequest, FlagsListResponse> call);

        partial void OnConstruction(SqlFlagsService.SqlFlagsServiceClient grpcClient, SqlFlagsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SqlFlagsService client</summary>
        public override SqlFlagsService.SqlFlagsServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_SqlFlagsListRequest(ref SqlFlagsListRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists all available database flags for Cloud SQL instances.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FlagsListResponse List(SqlFlagsListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlFlagsListRequest(ref request, ref callSettings);
            return _callList.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists all available database flags for Cloud SQL instances.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FlagsListResponse> ListAsync(SqlFlagsListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlFlagsListRequest(ref request, ref callSettings);
            return _callList.Async(request, callSettings);
        }
    }

    public static partial class SqlFlagsService
    {
        public partial class SqlFlagsServiceClient
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
