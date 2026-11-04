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
    /// <summary>Settings for <see cref="SqlInstanceNamesServiceClient"/> instances.</summary>
    public sealed partial class SqlInstanceNamesServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SqlInstanceNamesServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SqlInstanceNamesServiceSettings"/>.</returns>
        public static SqlInstanceNamesServiceSettings GetDefault() => new SqlInstanceNamesServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="SqlInstanceNamesServiceSettings"/> object with default settings.
        /// </summary>
        public SqlInstanceNamesServiceSettings()
        {
        }

        private SqlInstanceNamesServiceSettings(SqlInstanceNamesServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SqlInstanceNamesServiceSettings existing);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SqlInstanceNamesServiceSettings"/> object.</returns>
        public SqlInstanceNamesServiceSettings Clone() => new SqlInstanceNamesServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SqlInstanceNamesServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class SqlInstanceNamesServiceClientBuilder : gaxgrpc::ClientBuilderBase<SqlInstanceNamesServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SqlInstanceNamesServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SqlInstanceNamesServiceClientBuilder() : base(SqlInstanceNamesServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SqlInstanceNamesServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SqlInstanceNamesServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SqlInstanceNamesServiceClient Build()
        {
            SqlInstanceNamesServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SqlInstanceNamesServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SqlInstanceNamesServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SqlInstanceNamesServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SqlInstanceNamesServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SqlInstanceNamesServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SqlInstanceNamesServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SqlInstanceNamesServiceClient.ChannelPool;
    }

    /// <summary>SqlInstanceNamesService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Cloud SQL instance names service.
    /// </remarks>
    public abstract partial class SqlInstanceNamesServiceClient
    {
        /// <summary>
        /// The default endpoint for the SqlInstanceNamesService service, which is a host of "sqladmin.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "sqladmin.googleapis.com:443";

        /// <summary>The default SqlInstanceNamesService scopes.</summary>
        /// <remarks>The default SqlInstanceNamesService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(SqlInstanceNamesService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SqlInstanceNamesServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="SqlInstanceNamesServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SqlInstanceNamesServiceClient"/>.</returns>
        public static stt::Task<SqlInstanceNamesServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SqlInstanceNamesServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SqlInstanceNamesServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="SqlInstanceNamesServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SqlInstanceNamesServiceClient"/>.</returns>
        public static SqlInstanceNamesServiceClient Create() => new SqlInstanceNamesServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SqlInstanceNamesServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SqlInstanceNamesServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SqlInstanceNamesServiceClient"/>.</returns>
        internal static SqlInstanceNamesServiceClient Create(grpccore::CallInvoker callInvoker, SqlInstanceNamesServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SqlInstanceNamesService.SqlInstanceNamesServiceClient grpcClient = new SqlInstanceNamesService.SqlInstanceNamesServiceClient(callInvoker);
            return new SqlInstanceNamesServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC SqlInstanceNamesService client</summary>
        public virtual SqlInstanceNamesService.SqlInstanceNamesServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();
    }

    /// <summary>SqlInstanceNamesService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Cloud SQL instance names service.
    /// </remarks>
    public sealed partial class SqlInstanceNamesServiceClientImpl : SqlInstanceNamesServiceClient
    {
        /// <summary>
        /// Constructs a client wrapper for the SqlInstanceNamesService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="SqlInstanceNamesServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SqlInstanceNamesServiceClientImpl(SqlInstanceNamesService.SqlInstanceNamesServiceClient grpcClient, SqlInstanceNamesServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SqlInstanceNamesServiceSettings effectiveSettings = settings ?? SqlInstanceNamesServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void OnConstruction(SqlInstanceNamesService.SqlInstanceNamesServiceClient grpcClient, SqlInstanceNamesServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SqlInstanceNamesService client</summary>
        public override SqlInstanceNamesService.SqlInstanceNamesServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }
    }

    public static partial class SqlInstanceNamesService
    {
        public partial class SqlInstanceNamesServiceClient
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
