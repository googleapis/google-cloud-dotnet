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
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.DiscoveryEngine.V1
{
    /// <summary>Settings for <see cref="WidgetConfigServiceClient"/> instances.</summary>
    public sealed partial class WidgetConfigServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="WidgetConfigServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="WidgetConfigServiceSettings"/>.</returns>
        public static WidgetConfigServiceSettings GetDefault() => new WidgetConfigServiceSettings();

        /// <summary>Constructs a new <see cref="WidgetConfigServiceSettings"/> object with default settings.</summary>
        public WidgetConfigServiceSettings()
        {
        }

        private WidgetConfigServiceSettings(WidgetConfigServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetWidgetConfigSettings = existing.GetWidgetConfigSettings;
            UpdateWidgetConfigSettings = existing.UpdateWidgetConfigSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(WidgetConfigServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WidgetConfigServiceClient.GetWidgetConfig</c> and <c>WidgetConfigServiceClient.GetWidgetConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetWidgetConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WidgetConfigServiceClient.UpdateWidgetConfig</c> and <c>WidgetConfigServiceClient.UpdateWidgetConfigAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateWidgetConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="WidgetConfigServiceSettings"/> object.</returns>
        public WidgetConfigServiceSettings Clone() => new WidgetConfigServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="WidgetConfigServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class WidgetConfigServiceClientBuilder : gaxgrpc::ClientBuilderBase<WidgetConfigServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public WidgetConfigServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public WidgetConfigServiceClientBuilder() : base(WidgetConfigServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref WidgetConfigServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<WidgetConfigServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override WidgetConfigServiceClient Build()
        {
            WidgetConfigServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<WidgetConfigServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<WidgetConfigServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private WidgetConfigServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return WidgetConfigServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<WidgetConfigServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return WidgetConfigServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => WidgetConfigServiceClient.ChannelPool;
    }

    /// <summary>WidgetConfigService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing
    /// [WidgetConfig][google.cloud.discoveryengine.v1.WidgetConfig] configuration.
    /// </remarks>
    public abstract partial class WidgetConfigServiceClient
    {
        /// <summary>
        /// The default endpoint for the WidgetConfigService service, which is a host of
        /// "discoveryengine.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "discoveryengine.googleapis.com:443";

        /// <summary>The default WidgetConfigService scopes.</summary>
        /// <remarks>
        /// The default WidgetConfigService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/discoveryengine.assist.readwrite</description></item>
        /// <item><description>https://www.googleapis.com/auth/discoveryengine.readwrite</description></item>
        /// <item><description>https://www.googleapis.com/auth/discoveryengine.serving.readwrite</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/discoveryengine.assist.readwrite",
            "https://www.googleapis.com/auth/discoveryengine.readwrite",
            "https://www.googleapis.com/auth/discoveryengine.serving.readwrite",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(WidgetConfigService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="WidgetConfigServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="WidgetConfigServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="WidgetConfigServiceClient"/>.</returns>
        public static stt::Task<WidgetConfigServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new WidgetConfigServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="WidgetConfigServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="WidgetConfigServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="WidgetConfigServiceClient"/>.</returns>
        public static WidgetConfigServiceClient Create() => new WidgetConfigServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="WidgetConfigServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="WidgetConfigServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="WidgetConfigServiceClient"/>.</returns>
        internal static WidgetConfigServiceClient Create(grpccore::CallInvoker callInvoker, WidgetConfigServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            WidgetConfigService.WidgetConfigServiceClient grpcClient = new WidgetConfigService.WidgetConfigServiceClient(callInvoker);
            return new WidgetConfigServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC WidgetConfigService client</summary>
        public virtual WidgetConfigService.WidgetConfigServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a [WidgetConfig][google.cloud.discoveryengine.v1.WidgetConfig].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WidgetConfig GetWidgetConfig(GetWidgetConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a [WidgetConfig][google.cloud.discoveryengine.v1.WidgetConfig].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WidgetConfig> GetWidgetConfigAsync(GetWidgetConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a [WidgetConfig][google.cloud.discoveryengine.v1.WidgetConfig].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WidgetConfig> GetWidgetConfigAsync(GetWidgetConfigRequest request, st::CancellationToken cancellationToken) =>
            GetWidgetConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a [WidgetConfig][google.cloud.discoveryengine.v1.WidgetConfig].
        /// </summary>
        /// <param name="name">
        /// Required. Full WidgetConfig resource name. Format:
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}/widgetConfigs/{widget_config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WidgetConfig GetWidgetConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetWidgetConfig(new GetWidgetConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [WidgetConfig][google.cloud.discoveryengine.v1.WidgetConfig].
        /// </summary>
        /// <param name="name">
        /// Required. Full WidgetConfig resource name. Format:
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}/widgetConfigs/{widget_config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WidgetConfig> GetWidgetConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetWidgetConfigAsync(new GetWidgetConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [WidgetConfig][google.cloud.discoveryengine.v1.WidgetConfig].
        /// </summary>
        /// <param name="name">
        /// Required. Full WidgetConfig resource name. Format:
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}/widgetConfigs/{widget_config_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WidgetConfig> GetWidgetConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetWidgetConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a [WidgetConfig][google.cloud.discoveryengine.v1.WidgetConfig].
        /// </summary>
        /// <param name="name">
        /// Required. Full WidgetConfig resource name. Format:
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}/widgetConfigs/{widget_config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WidgetConfig GetWidgetConfig(WidgetConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetWidgetConfig(new GetWidgetConfigRequest
            {
                WidgetConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [WidgetConfig][google.cloud.discoveryengine.v1.WidgetConfig].
        /// </summary>
        /// <param name="name">
        /// Required. Full WidgetConfig resource name. Format:
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}/widgetConfigs/{widget_config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WidgetConfig> GetWidgetConfigAsync(WidgetConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetWidgetConfigAsync(new GetWidgetConfigRequest
            {
                WidgetConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [WidgetConfig][google.cloud.discoveryengine.v1.WidgetConfig].
        /// </summary>
        /// <param name="name">
        /// Required. Full WidgetConfig resource name. Format:
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}/widgetConfigs/{widget_config_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WidgetConfig> GetWidgetConfigAsync(WidgetConfigName name, st::CancellationToken cancellationToken) =>
            GetWidgetConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a WidgetConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WidgetConfig UpdateWidgetConfig(UpdateWidgetConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a WidgetConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WidgetConfig> UpdateWidgetConfigAsync(UpdateWidgetConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a WidgetConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WidgetConfig> UpdateWidgetConfigAsync(UpdateWidgetConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateWidgetConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a WidgetConfig.
        /// </summary>
        /// <param name="widgetConfig">
        /// Required. The [WidgetConfig][google.cloud.discoveryengine.v1.WidgetConfig]
        /// to update.
        /// 
        /// If the caller does not have permission to update the
        /// [WidgetConfig][google.cloud.discoveryengine.v1.WidgetConfig], then a
        /// PERMISSION_DENIED error is returned.
        /// 
        /// If the [WidgetConfig][google.cloud.discoveryengine.v1.WidgetConfig] to
        /// update does not exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided
        /// [WidgetConfig][google.cloud.discoveryengine.v1.WidgetConfig] to update. The
        /// following are the only supported fields:
        /// 
        /// * [WidgetConfig.enable_autocomplete][google.cloud.discoveryengine.v1.WidgetConfig.enable_autocomplete]
        /// 
        /// If not set, all supported fields are updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WidgetConfig UpdateWidgetConfig(WidgetConfig widgetConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateWidgetConfig(new UpdateWidgetConfigRequest
            {
                WidgetConfig = gax::GaxPreconditions.CheckNotNull(widgetConfig, nameof(widgetConfig)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a WidgetConfig.
        /// </summary>
        /// <param name="widgetConfig">
        /// Required. The [WidgetConfig][google.cloud.discoveryengine.v1.WidgetConfig]
        /// to update.
        /// 
        /// If the caller does not have permission to update the
        /// [WidgetConfig][google.cloud.discoveryengine.v1.WidgetConfig], then a
        /// PERMISSION_DENIED error is returned.
        /// 
        /// If the [WidgetConfig][google.cloud.discoveryengine.v1.WidgetConfig] to
        /// update does not exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided
        /// [WidgetConfig][google.cloud.discoveryengine.v1.WidgetConfig] to update. The
        /// following are the only supported fields:
        /// 
        /// * [WidgetConfig.enable_autocomplete][google.cloud.discoveryengine.v1.WidgetConfig.enable_autocomplete]
        /// 
        /// If not set, all supported fields are updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WidgetConfig> UpdateWidgetConfigAsync(WidgetConfig widgetConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateWidgetConfigAsync(new UpdateWidgetConfigRequest
            {
                WidgetConfig = gax::GaxPreconditions.CheckNotNull(widgetConfig, nameof(widgetConfig)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a WidgetConfig.
        /// </summary>
        /// <param name="widgetConfig">
        /// Required. The [WidgetConfig][google.cloud.discoveryengine.v1.WidgetConfig]
        /// to update.
        /// 
        /// If the caller does not have permission to update the
        /// [WidgetConfig][google.cloud.discoveryengine.v1.WidgetConfig], then a
        /// PERMISSION_DENIED error is returned.
        /// 
        /// If the [WidgetConfig][google.cloud.discoveryengine.v1.WidgetConfig] to
        /// update does not exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided
        /// [WidgetConfig][google.cloud.discoveryengine.v1.WidgetConfig] to update. The
        /// following are the only supported fields:
        /// 
        /// * [WidgetConfig.enable_autocomplete][google.cloud.discoveryengine.v1.WidgetConfig.enable_autocomplete]
        /// 
        /// If not set, all supported fields are updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WidgetConfig> UpdateWidgetConfigAsync(WidgetConfig widgetConfig, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateWidgetConfigAsync(widgetConfig, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>WidgetConfigService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing
    /// [WidgetConfig][google.cloud.discoveryengine.v1.WidgetConfig] configuration.
    /// </remarks>
    public sealed partial class WidgetConfigServiceClientImpl : WidgetConfigServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetWidgetConfigRequest, WidgetConfig> _callGetWidgetConfig;

        private readonly gaxgrpc::ApiCall<UpdateWidgetConfigRequest, WidgetConfig> _callUpdateWidgetConfig;

        /// <summary>
        /// Constructs a client wrapper for the WidgetConfigService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="WidgetConfigServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public WidgetConfigServiceClientImpl(WidgetConfigService.WidgetConfigServiceClient grpcClient, WidgetConfigServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            WidgetConfigServiceSettings effectiveSettings = settings ?? WidgetConfigServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callGetWidgetConfig = clientHelper.BuildApiCall<GetWidgetConfigRequest, WidgetConfig>("GetWidgetConfig", grpcClient.GetWidgetConfigAsync, grpcClient.GetWidgetConfig, effectiveSettings.GetWidgetConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetWidgetConfig);
            Modify_GetWidgetConfigApiCall(ref _callGetWidgetConfig);
            _callUpdateWidgetConfig = clientHelper.BuildApiCall<UpdateWidgetConfigRequest, WidgetConfig>("UpdateWidgetConfig", grpcClient.UpdateWidgetConfigAsync, grpcClient.UpdateWidgetConfig, effectiveSettings.UpdateWidgetConfigSettings).WithGoogleRequestParam("widget_config.name", request => request.WidgetConfig?.Name);
            Modify_ApiCall(ref _callUpdateWidgetConfig);
            Modify_UpdateWidgetConfigApiCall(ref _callUpdateWidgetConfig);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetWidgetConfigApiCall(ref gaxgrpc::ApiCall<GetWidgetConfigRequest, WidgetConfig> call);

        partial void Modify_UpdateWidgetConfigApiCall(ref gaxgrpc::ApiCall<UpdateWidgetConfigRequest, WidgetConfig> call);

        partial void OnConstruction(WidgetConfigService.WidgetConfigServiceClient grpcClient, WidgetConfigServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC WidgetConfigService client</summary>
        public override WidgetConfigService.WidgetConfigServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_GetWidgetConfigRequest(ref GetWidgetConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateWidgetConfigRequest(ref UpdateWidgetConfigRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets a [WidgetConfig][google.cloud.discoveryengine.v1.WidgetConfig].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override WidgetConfig GetWidgetConfig(GetWidgetConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetWidgetConfigRequest(ref request, ref callSettings);
            return _callGetWidgetConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a [WidgetConfig][google.cloud.discoveryengine.v1.WidgetConfig].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<WidgetConfig> GetWidgetConfigAsync(GetWidgetConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetWidgetConfigRequest(ref request, ref callSettings);
            return _callGetWidgetConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Update a WidgetConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override WidgetConfig UpdateWidgetConfig(UpdateWidgetConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateWidgetConfigRequest(ref request, ref callSettings);
            return _callUpdateWidgetConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Update a WidgetConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<WidgetConfig> UpdateWidgetConfigAsync(UpdateWidgetConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateWidgetConfigRequest(ref request, ref callSettings);
            return _callUpdateWidgetConfig.Async(request, callSettings);
        }
    }

    public static partial class WidgetConfigService
    {
        public partial class WidgetConfigServiceClient
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
