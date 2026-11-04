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
    /// <summary>Settings for <see cref="SqlConnectServiceClient"/> instances.</summary>
    public sealed partial class SqlConnectServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SqlConnectServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SqlConnectServiceSettings"/>.</returns>
        public static SqlConnectServiceSettings GetDefault() => new SqlConnectServiceSettings();

        /// <summary>Constructs a new <see cref="SqlConnectServiceSettings"/> object with default settings.</summary>
        public SqlConnectServiceSettings()
        {
        }

        private SqlConnectServiceSettings(SqlConnectServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetConnectSettingsSettings = existing.GetConnectSettingsSettings;
            ResolveConnectSettingsSettings = existing.ResolveConnectSettingsSettings;
            GenerateEphemeralCertSettings = existing.GenerateEphemeralCertSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SqlConnectServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlConnectServiceClient.GetConnectSettings</c> and <c>SqlConnectServiceClient.GetConnectSettingsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetConnectSettingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlConnectServiceClient.ResolveConnectSettings</c> and
        /// <c>SqlConnectServiceClient.ResolveConnectSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ResolveConnectSettingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlConnectServiceClient.GenerateEphemeralCert</c> and
        /// <c>SqlConnectServiceClient.GenerateEphemeralCertAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GenerateEphemeralCertSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SqlConnectServiceSettings"/> object.</returns>
        public SqlConnectServiceSettings Clone() => new SqlConnectServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SqlConnectServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class SqlConnectServiceClientBuilder : gaxgrpc::ClientBuilderBase<SqlConnectServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SqlConnectServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SqlConnectServiceClientBuilder() : base(SqlConnectServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SqlConnectServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SqlConnectServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SqlConnectServiceClient Build()
        {
            SqlConnectServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SqlConnectServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SqlConnectServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SqlConnectServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SqlConnectServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SqlConnectServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SqlConnectServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SqlConnectServiceClient.ChannelPool;
    }

    /// <summary>SqlConnectService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Cloud SQL connect service.
    /// </remarks>
    public abstract partial class SqlConnectServiceClient
    {
        /// <summary>
        /// The default endpoint for the SqlConnectService service, which is a host of "sqladmin.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "sqladmin.googleapis.com:443";

        /// <summary>The default SqlConnectService scopes.</summary>
        /// <remarks>
        /// The default SqlConnectService scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(SqlConnectService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SqlConnectServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SqlConnectServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SqlConnectServiceClient"/>.</returns>
        public static stt::Task<SqlConnectServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SqlConnectServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SqlConnectServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SqlConnectServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SqlConnectServiceClient"/>.</returns>
        public static SqlConnectServiceClient Create() => new SqlConnectServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SqlConnectServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SqlConnectServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SqlConnectServiceClient"/>.</returns>
        internal static SqlConnectServiceClient Create(grpccore::CallInvoker callInvoker, SqlConnectServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SqlConnectService.SqlConnectServiceClient grpcClient = new SqlConnectService.SqlConnectServiceClient(callInvoker);
            return new SqlConnectServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC SqlConnectService client</summary>
        public virtual SqlConnectService.SqlConnectServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves connect settings about a Cloud SQL instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConnectSettings GetConnectSettings(GetConnectSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves connect settings about a Cloud SQL instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectSettings> GetConnectSettingsAsync(GetConnectSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves connect settings about a Cloud SQL instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectSettings> GetConnectSettingsAsync(GetConnectSettingsRequest request, st::CancellationToken cancellationToken) =>
            GetConnectSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves connect settings about a Cloud SQL instance using the instance
        /// DNS name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConnectSettings ResolveConnectSettings(ResolveConnectSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves connect settings about a Cloud SQL instance using the instance
        /// DNS name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectSettings> ResolveConnectSettingsAsync(ResolveConnectSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves connect settings about a Cloud SQL instance using the instance
        /// DNS name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectSettings> ResolveConnectSettingsAsync(ResolveConnectSettingsRequest request, st::CancellationToken cancellationToken) =>
            ResolveConnectSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates a short-lived X509 certificate containing the provided public key
        /// and signed by a private key specific to the target instance. Users may use
        /// the certificate to authenticate as themselves when connecting to the
        /// database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateEphemeralCertResponse GenerateEphemeralCert(GenerateEphemeralCertRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates a short-lived X509 certificate containing the provided public key
        /// and signed by a private key specific to the target instance. Users may use
        /// the certificate to authenticate as themselves when connecting to the
        /// database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateEphemeralCertResponse> GenerateEphemeralCertAsync(GenerateEphemeralCertRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates a short-lived X509 certificate containing the provided public key
        /// and signed by a private key specific to the target instance. Users may use
        /// the certificate to authenticate as themselves when connecting to the
        /// database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateEphemeralCertResponse> GenerateEphemeralCertAsync(GenerateEphemeralCertRequest request, st::CancellationToken cancellationToken) =>
            GenerateEphemeralCertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>SqlConnectService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Cloud SQL connect service.
    /// </remarks>
    public sealed partial class SqlConnectServiceClientImpl : SqlConnectServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetConnectSettingsRequest, ConnectSettings> _callGetConnectSettings;

        private readonly gaxgrpc::ApiCall<ResolveConnectSettingsRequest, ConnectSettings> _callResolveConnectSettings;

        private readonly gaxgrpc::ApiCall<GenerateEphemeralCertRequest, GenerateEphemeralCertResponse> _callGenerateEphemeralCert;

        /// <summary>
        /// Constructs a client wrapper for the SqlConnectService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SqlConnectServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SqlConnectServiceClientImpl(SqlConnectService.SqlConnectServiceClient grpcClient, SqlConnectServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SqlConnectServiceSettings effectiveSettings = settings ?? SqlConnectServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callGetConnectSettings = clientHelper.BuildApiCall<GetConnectSettingsRequest, ConnectSettings>("GetConnectSettings", grpcClient.GetConnectSettingsAsync, grpcClient.GetConnectSettings, effectiveSettings.GetConnectSettingsSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callGetConnectSettings);
            Modify_GetConnectSettingsApiCall(ref _callGetConnectSettings);
            _callResolveConnectSettings = clientHelper.BuildApiCall<ResolveConnectSettingsRequest, ConnectSettings>("ResolveConnectSettings", grpcClient.ResolveConnectSettingsAsync, grpcClient.ResolveConnectSettings, effectiveSettings.ResolveConnectSettingsSettings).WithGoogleRequestParam("location", request => request.Location).WithGoogleRequestParam("dns_name", request => request.DnsName);
            Modify_ApiCall(ref _callResolveConnectSettings);
            Modify_ResolveConnectSettingsApiCall(ref _callResolveConnectSettings);
            _callGenerateEphemeralCert = clientHelper.BuildApiCall<GenerateEphemeralCertRequest, GenerateEphemeralCertResponse>("GenerateEphemeralCert", grpcClient.GenerateEphemeralCertAsync, grpcClient.GenerateEphemeralCert, effectiveSettings.GenerateEphemeralCertSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callGenerateEphemeralCert);
            Modify_GenerateEphemeralCertApiCall(ref _callGenerateEphemeralCert);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetConnectSettingsApiCall(ref gaxgrpc::ApiCall<GetConnectSettingsRequest, ConnectSettings> call);

        partial void Modify_ResolveConnectSettingsApiCall(ref gaxgrpc::ApiCall<ResolveConnectSettingsRequest, ConnectSettings> call);

        partial void Modify_GenerateEphemeralCertApiCall(ref gaxgrpc::ApiCall<GenerateEphemeralCertRequest, GenerateEphemeralCertResponse> call);

        partial void OnConstruction(SqlConnectService.SqlConnectServiceClient grpcClient, SqlConnectServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SqlConnectService client</summary>
        public override SqlConnectService.SqlConnectServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_GetConnectSettingsRequest(ref GetConnectSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ResolveConnectSettingsRequest(ref ResolveConnectSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateEphemeralCertRequest(ref GenerateEphemeralCertRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves connect settings about a Cloud SQL instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ConnectSettings GetConnectSettings(GetConnectSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConnectSettingsRequest(ref request, ref callSettings);
            return _callGetConnectSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves connect settings about a Cloud SQL instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ConnectSettings> GetConnectSettingsAsync(GetConnectSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConnectSettingsRequest(ref request, ref callSettings);
            return _callGetConnectSettings.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves connect settings about a Cloud SQL instance using the instance
        /// DNS name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ConnectSettings ResolveConnectSettings(ResolveConnectSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResolveConnectSettingsRequest(ref request, ref callSettings);
            return _callResolveConnectSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves connect settings about a Cloud SQL instance using the instance
        /// DNS name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ConnectSettings> ResolveConnectSettingsAsync(ResolveConnectSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResolveConnectSettingsRequest(ref request, ref callSettings);
            return _callResolveConnectSettings.Async(request, callSettings);
        }

        /// <summary>
        /// Generates a short-lived X509 certificate containing the provided public key
        /// and signed by a private key specific to the target instance. Users may use
        /// the certificate to authenticate as themselves when connecting to the
        /// database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateEphemeralCertResponse GenerateEphemeralCert(GenerateEphemeralCertRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateEphemeralCertRequest(ref request, ref callSettings);
            return _callGenerateEphemeralCert.Sync(request, callSettings);
        }

        /// <summary>
        /// Generates a short-lived X509 certificate containing the provided public key
        /// and signed by a private key specific to the target instance. Users may use
        /// the certificate to authenticate as themselves when connecting to the
        /// database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateEphemeralCertResponse> GenerateEphemeralCertAsync(GenerateEphemeralCertRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateEphemeralCertRequest(ref request, ref callSettings);
            return _callGenerateEphemeralCert.Async(request, callSettings);
        }
    }

    public static partial class SqlConnectService
    {
        public partial class SqlConnectServiceClient
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
