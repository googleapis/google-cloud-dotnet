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

namespace Google.Cloud.DiscoveryEngine.V1Beta
{
    /// <summary>Settings for <see cref="AclConfigServiceClient"/> instances.</summary>
    public sealed partial class AclConfigServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AclConfigServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AclConfigServiceSettings"/>.</returns>
        public static AclConfigServiceSettings GetDefault() => new AclConfigServiceSettings();

        /// <summary>Constructs a new <see cref="AclConfigServiceSettings"/> object with default settings.</summary>
        public AclConfigServiceSettings()
        {
        }

        private AclConfigServiceSettings(AclConfigServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            UpdateAclConfigSettings = existing.UpdateAclConfigSettings;
            GetAclConfigSettings = existing.GetAclConfigSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AclConfigServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AclConfigServiceClient.UpdateAclConfig</c> and <c>AclConfigServiceClient.UpdateAclConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAclConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AclConfigServiceClient.GetAclConfig</c> and <c>AclConfigServiceClient.GetAclConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAclConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AclConfigServiceSettings"/> object.</returns>
        public AclConfigServiceSettings Clone() => new AclConfigServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AclConfigServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class AclConfigServiceClientBuilder : gaxgrpc::ClientBuilderBase<AclConfigServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AclConfigServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AclConfigServiceClientBuilder() : base(AclConfigServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AclConfigServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AclConfigServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AclConfigServiceClient Build()
        {
            AclConfigServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AclConfigServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AclConfigServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AclConfigServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AclConfigServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AclConfigServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AclConfigServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AclConfigServiceClient.ChannelPool;
    }

    /// <summary>AclConfigService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing Acl Configuration.
    /// </remarks>
    public abstract partial class AclConfigServiceClient
    {
        /// <summary>
        /// The default endpoint for the AclConfigService service, which is a host of "discoveryengine.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "discoveryengine.googleapis.com:443";

        /// <summary>The default AclConfigService scopes.</summary>
        /// <remarks>
        /// The default AclConfigService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/discoveryengine.readwrite</description></item>
        /// <item><description>https://www.googleapis.com/auth/discoveryengine.serving.readwrite</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/discoveryengine.readwrite",
            "https://www.googleapis.com/auth/discoveryengine.serving.readwrite",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AclConfigService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AclConfigServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AclConfigServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AclConfigServiceClient"/>.</returns>
        public static stt::Task<AclConfigServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AclConfigServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AclConfigServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AclConfigServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AclConfigServiceClient"/>.</returns>
        public static AclConfigServiceClient Create() => new AclConfigServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AclConfigServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AclConfigServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AclConfigServiceClient"/>.</returns>
        internal static AclConfigServiceClient Create(grpccore::CallInvoker callInvoker, AclConfigServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AclConfigService.AclConfigServiceClient grpcClient = new AclConfigService.AclConfigServiceClient(callInvoker);
            return new AclConfigServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AclConfigService client</summary>
        public virtual AclConfigService.AclConfigServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Default ACL configuration for use in a location of a customer's project.
        /// Updates will only reflect to new data stores. Existing data stores will
        /// still use the old value.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AclConfig UpdateAclConfig(UpdateAclConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Default ACL configuration for use in a location of a customer's project.
        /// Updates will only reflect to new data stores. Existing data stores will
        /// still use the old value.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AclConfig> UpdateAclConfigAsync(UpdateAclConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Default ACL configuration for use in a location of a customer's project.
        /// Updates will only reflect to new data stores. Existing data stores will
        /// still use the old value.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AclConfig> UpdateAclConfigAsync(UpdateAclConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateAclConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the [AclConfig][google.cloud.discoveryengine.v1beta.AclConfig].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AclConfig GetAclConfig(GetAclConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the [AclConfig][google.cloud.discoveryengine.v1beta.AclConfig].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AclConfig> GetAclConfigAsync(GetAclConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the [AclConfig][google.cloud.discoveryengine.v1beta.AclConfig].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AclConfig> GetAclConfigAsync(GetAclConfigRequest request, st::CancellationToken cancellationToken) =>
            GetAclConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the [AclConfig][google.cloud.discoveryengine.v1beta.AclConfig].
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of
        /// [AclConfig][google.cloud.discoveryengine.v1beta.AclConfig], such as
        /// `projects/*/locations/*/aclConfig`.
        /// 
        /// If the caller does not have permission to access the
        /// [AclConfig][google.cloud.discoveryengine.v1beta.AclConfig], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AclConfig GetAclConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAclConfig(new GetAclConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the [AclConfig][google.cloud.discoveryengine.v1beta.AclConfig].
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of
        /// [AclConfig][google.cloud.discoveryengine.v1beta.AclConfig], such as
        /// `projects/*/locations/*/aclConfig`.
        /// 
        /// If the caller does not have permission to access the
        /// [AclConfig][google.cloud.discoveryengine.v1beta.AclConfig], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AclConfig> GetAclConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAclConfigAsync(new GetAclConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the [AclConfig][google.cloud.discoveryengine.v1beta.AclConfig].
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of
        /// [AclConfig][google.cloud.discoveryengine.v1beta.AclConfig], such as
        /// `projects/*/locations/*/aclConfig`.
        /// 
        /// If the caller does not have permission to access the
        /// [AclConfig][google.cloud.discoveryengine.v1beta.AclConfig], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AclConfig> GetAclConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetAclConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the [AclConfig][google.cloud.discoveryengine.v1beta.AclConfig].
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of
        /// [AclConfig][google.cloud.discoveryengine.v1beta.AclConfig], such as
        /// `projects/*/locations/*/aclConfig`.
        /// 
        /// If the caller does not have permission to access the
        /// [AclConfig][google.cloud.discoveryengine.v1beta.AclConfig], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AclConfig GetAclConfig(AclConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAclConfig(new GetAclConfigRequest
            {
                AclConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the [AclConfig][google.cloud.discoveryengine.v1beta.AclConfig].
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of
        /// [AclConfig][google.cloud.discoveryengine.v1beta.AclConfig], such as
        /// `projects/*/locations/*/aclConfig`.
        /// 
        /// If the caller does not have permission to access the
        /// [AclConfig][google.cloud.discoveryengine.v1beta.AclConfig], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AclConfig> GetAclConfigAsync(AclConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAclConfigAsync(new GetAclConfigRequest
            {
                AclConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the [AclConfig][google.cloud.discoveryengine.v1beta.AclConfig].
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of
        /// [AclConfig][google.cloud.discoveryengine.v1beta.AclConfig], such as
        /// `projects/*/locations/*/aclConfig`.
        /// 
        /// If the caller does not have permission to access the
        /// [AclConfig][google.cloud.discoveryengine.v1beta.AclConfig], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AclConfig> GetAclConfigAsync(AclConfigName name, st::CancellationToken cancellationToken) =>
            GetAclConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AclConfigService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing Acl Configuration.
    /// </remarks>
    public sealed partial class AclConfigServiceClientImpl : AclConfigServiceClient
    {
        private readonly gaxgrpc::ApiCall<UpdateAclConfigRequest, AclConfig> _callUpdateAclConfig;

        private readonly gaxgrpc::ApiCall<GetAclConfigRequest, AclConfig> _callGetAclConfig;

        /// <summary>
        /// Constructs a client wrapper for the AclConfigService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AclConfigServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AclConfigServiceClientImpl(AclConfigService.AclConfigServiceClient grpcClient, AclConfigServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AclConfigServiceSettings effectiveSettings = settings ?? AclConfigServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callUpdateAclConfig = clientHelper.BuildApiCall<UpdateAclConfigRequest, AclConfig>("UpdateAclConfig", grpcClient.UpdateAclConfigAsync, grpcClient.UpdateAclConfig, effectiveSettings.UpdateAclConfigSettings).WithGoogleRequestParam("acl_config.name", request => request.AclConfig?.Name);
            Modify_ApiCall(ref _callUpdateAclConfig);
            Modify_UpdateAclConfigApiCall(ref _callUpdateAclConfig);
            _callGetAclConfig = clientHelper.BuildApiCall<GetAclConfigRequest, AclConfig>("GetAclConfig", grpcClient.GetAclConfigAsync, grpcClient.GetAclConfig, effectiveSettings.GetAclConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAclConfig);
            Modify_GetAclConfigApiCall(ref _callGetAclConfig);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_UpdateAclConfigApiCall(ref gaxgrpc::ApiCall<UpdateAclConfigRequest, AclConfig> call);

        partial void Modify_GetAclConfigApiCall(ref gaxgrpc::ApiCall<GetAclConfigRequest, AclConfig> call);

        partial void OnConstruction(AclConfigService.AclConfigServiceClient grpcClient, AclConfigServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AclConfigService client</summary>
        public override AclConfigService.AclConfigServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_UpdateAclConfigRequest(ref UpdateAclConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAclConfigRequest(ref GetAclConfigRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Default ACL configuration for use in a location of a customer's project.
        /// Updates will only reflect to new data stores. Existing data stores will
        /// still use the old value.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AclConfig UpdateAclConfig(UpdateAclConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAclConfigRequest(ref request, ref callSettings);
            return _callUpdateAclConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Default ACL configuration for use in a location of a customer's project.
        /// Updates will only reflect to new data stores. Existing data stores will
        /// still use the old value.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AclConfig> UpdateAclConfigAsync(UpdateAclConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAclConfigRequest(ref request, ref callSettings);
            return _callUpdateAclConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the [AclConfig][google.cloud.discoveryengine.v1beta.AclConfig].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AclConfig GetAclConfig(GetAclConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAclConfigRequest(ref request, ref callSettings);
            return _callGetAclConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the [AclConfig][google.cloud.discoveryengine.v1beta.AclConfig].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AclConfig> GetAclConfigAsync(GetAclConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAclConfigRequest(ref request, ref callSettings);
            return _callGetAclConfig.Async(request, callSettings);
        }
    }

    public static partial class AclConfigService
    {
        public partial class AclConfigServiceClient
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
