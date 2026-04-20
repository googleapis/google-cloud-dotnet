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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
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

namespace Google.Maps.MapManagement.V2Beta
{
    /// <summary>Settings for <see cref="MapManagementClient"/> instances.</summary>
    public sealed partial class MapManagementSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="MapManagementSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="MapManagementSettings"/>.</returns>
        public static MapManagementSettings GetDefault() => new MapManagementSettings();

        /// <summary>Constructs a new <see cref="MapManagementSettings"/> object with default settings.</summary>
        public MapManagementSettings()
        {
        }

        private MapManagementSettings(MapManagementSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateMapConfigSettings = existing.CreateMapConfigSettings;
            GetMapConfigSettings = existing.GetMapConfigSettings;
            ListMapConfigsSettings = existing.ListMapConfigsSettings;
            UpdateMapConfigSettings = existing.UpdateMapConfigSettings;
            DeleteMapConfigSettings = existing.DeleteMapConfigSettings;
            CreateStyleConfigSettings = existing.CreateStyleConfigSettings;
            GetStyleConfigSettings = existing.GetStyleConfigSettings;
            ListStyleConfigsSettings = existing.ListStyleConfigsSettings;
            UpdateStyleConfigSettings = existing.UpdateStyleConfigSettings;
            DeleteStyleConfigSettings = existing.DeleteStyleConfigSettings;
            CreateMapContextConfigSettings = existing.CreateMapContextConfigSettings;
            GetMapContextConfigSettings = existing.GetMapContextConfigSettings;
            ListMapContextConfigsSettings = existing.ListMapContextConfigsSettings;
            UpdateMapContextConfigSettings = existing.UpdateMapContextConfigSettings;
            DeleteMapContextConfigSettings = existing.DeleteMapContextConfigSettings;
            OnCopy(existing);
        }

        partial void OnCopy(MapManagementSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MapManagementClient.CreateMapConfig</c> and <c>MapManagementClient.CreateMapConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateMapConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MapManagementClient.GetMapConfig</c> and <c>MapManagementClient.GetMapConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetMapConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MapManagementClient.ListMapConfigs</c> and <c>MapManagementClient.ListMapConfigsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListMapConfigsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MapManagementClient.UpdateMapConfig</c> and <c>MapManagementClient.UpdateMapConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateMapConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MapManagementClient.DeleteMapConfig</c> and <c>MapManagementClient.DeleteMapConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteMapConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MapManagementClient.CreateStyleConfig</c> and <c>MapManagementClient.CreateStyleConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateStyleConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MapManagementClient.GetStyleConfig</c> and <c>MapManagementClient.GetStyleConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetStyleConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MapManagementClient.ListStyleConfigs</c> and <c>MapManagementClient.ListStyleConfigsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListStyleConfigsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MapManagementClient.UpdateStyleConfig</c> and <c>MapManagementClient.UpdateStyleConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateStyleConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MapManagementClient.DeleteStyleConfig</c> and <c>MapManagementClient.DeleteStyleConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteStyleConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MapManagementClient.CreateMapContextConfig</c> and <c>MapManagementClient.CreateMapContextConfigAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateMapContextConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MapManagementClient.GetMapContextConfig</c> and <c>MapManagementClient.GetMapContextConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetMapContextConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MapManagementClient.ListMapContextConfigs</c> and <c>MapManagementClient.ListMapContextConfigsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListMapContextConfigsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MapManagementClient.UpdateMapContextConfig</c> and <c>MapManagementClient.UpdateMapContextConfigAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateMapContextConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MapManagementClient.DeleteMapContextConfig</c> and <c>MapManagementClient.DeleteMapContextConfigAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteMapContextConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="MapManagementSettings"/> object.</returns>
        public MapManagementSettings Clone() => new MapManagementSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="MapManagementClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class MapManagementClientBuilder : gaxgrpc::ClientBuilderBase<MapManagementClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public MapManagementSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public MapManagementClientBuilder() : base(MapManagementClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref MapManagementClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<MapManagementClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override MapManagementClient Build()
        {
            MapManagementClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<MapManagementClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<MapManagementClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private MapManagementClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return MapManagementClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<MapManagementClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return MapManagementClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => MapManagementClient.ChannelPool;
    }

    /// <summary>MapManagement client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The Map Management API uses your inputs to create and manage
    /// Google Cloud based styling resources for Google Maps.
    /// 
    /// Using this API, you can can create and manage MapConfigs (Map IDs),
    /// StyleConfigs (JSON-based styling), and MapContextConfigs (associations
    /// between styles, datasets, and map variants).
    /// 
    /// This API offers features through three channels:
    /// * `v2alpha`: Experimental features.
    /// * `v2beta`: Preview features, recommended for early adoption.
    /// * `v2`: General Availability (GA) features.
    /// 
    /// Capabilities described here are generally available across both the v2alpha
    /// and v2beta endpoints.
    /// </remarks>
    public abstract partial class MapManagementClient
    {
        /// <summary>
        /// The default endpoint for the MapManagement service, which is a host of "mapmanagement.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "mapmanagement.googleapis.com:443";

        /// <summary>The default MapManagement scopes.</summary>
        /// <remarks>
        /// The default MapManagement scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(MapManagement.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="MapManagementClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="MapManagementClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="MapManagementClient"/>.</returns>
        public static stt::Task<MapManagementClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new MapManagementClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="MapManagementClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="MapManagementClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="MapManagementClient"/>.</returns>
        public static MapManagementClient Create() => new MapManagementClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="MapManagementClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="MapManagementSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="MapManagementClient"/>.</returns>
        internal static MapManagementClient Create(grpccore::CallInvoker callInvoker, MapManagementSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            MapManagement.MapManagementClient grpcClient = new MapManagement.MapManagementClient(callInvoker);
            return new MapManagementClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC MapManagement client</summary>
        public virtual MapManagement.MapManagementClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a MapConfig in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MapConfig CreateMapConfig(CreateMapConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a MapConfig in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MapConfig> CreateMapConfigAsync(CreateMapConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a MapConfig in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MapConfig> CreateMapConfigAsync(CreateMapConfigRequest request, st::CancellationToken cancellationToken) =>
            CreateMapConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a MapConfig in a project.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent project that will own the MapConfig.
        /// Format: `projects/{$my-project-id}`
        /// </param>
        /// <param name="mapConfig">
        /// Required. The MapConfig to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MapConfig CreateMapConfig(string parent, MapConfig mapConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateMapConfig(new CreateMapConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MapConfig = gax::GaxPreconditions.CheckNotNull(mapConfig, nameof(mapConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a MapConfig in a project.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent project that will own the MapConfig.
        /// Format: `projects/{$my-project-id}`
        /// </param>
        /// <param name="mapConfig">
        /// Required. The MapConfig to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MapConfig> CreateMapConfigAsync(string parent, MapConfig mapConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateMapConfigAsync(new CreateMapConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MapConfig = gax::GaxPreconditions.CheckNotNull(mapConfig, nameof(mapConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a MapConfig in a project.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent project that will own the MapConfig.
        /// Format: `projects/{$my-project-id}`
        /// </param>
        /// <param name="mapConfig">
        /// Required. The MapConfig to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MapConfig> CreateMapConfigAsync(string parent, MapConfig mapConfig, st::CancellationToken cancellationToken) =>
            CreateMapConfigAsync(parent, mapConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a MapConfig in a project.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent project that will own the MapConfig.
        /// Format: `projects/{$my-project-id}`
        /// </param>
        /// <param name="mapConfig">
        /// Required. The MapConfig to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MapConfig CreateMapConfig(gagr::ProjectName parent, MapConfig mapConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateMapConfig(new CreateMapConfigRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MapConfig = gax::GaxPreconditions.CheckNotNull(mapConfig, nameof(mapConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a MapConfig in a project.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent project that will own the MapConfig.
        /// Format: `projects/{$my-project-id}`
        /// </param>
        /// <param name="mapConfig">
        /// Required. The MapConfig to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MapConfig> CreateMapConfigAsync(gagr::ProjectName parent, MapConfig mapConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateMapConfigAsync(new CreateMapConfigRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MapConfig = gax::GaxPreconditions.CheckNotNull(mapConfig, nameof(mapConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a MapConfig in a project.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent project that will own the MapConfig.
        /// Format: `projects/{$my-project-id}`
        /// </param>
        /// <param name="mapConfig">
        /// Required. The MapConfig to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MapConfig> CreateMapConfigAsync(gagr::ProjectName parent, MapConfig mapConfig, st::CancellationToken cancellationToken) =>
            CreateMapConfigAsync(parent, mapConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a MapConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MapConfig GetMapConfig(GetMapConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a MapConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MapConfig> GetMapConfigAsync(GetMapConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a MapConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MapConfig> GetMapConfigAsync(GetMapConfigRequest request, st::CancellationToken cancellationToken) =>
            GetMapConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a MapConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the MapConfig.
        /// Format: `projects/{project}/mapConfigs/{map_config}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MapConfig GetMapConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMapConfig(new GetMapConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a MapConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the MapConfig.
        /// Format: `projects/{project}/mapConfigs/{map_config}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MapConfig> GetMapConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMapConfigAsync(new GetMapConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a MapConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the MapConfig.
        /// Format: `projects/{project}/mapConfigs/{map_config}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MapConfig> GetMapConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetMapConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a MapConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the MapConfig.
        /// Format: `projects/{project}/mapConfigs/{map_config}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MapConfig GetMapConfig(MapConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMapConfig(new GetMapConfigRequest
            {
                MapConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a MapConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the MapConfig.
        /// Format: `projects/{project}/mapConfigs/{map_config}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MapConfig> GetMapConfigAsync(MapConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMapConfigAsync(new GetMapConfigRequest
            {
                MapConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a MapConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the MapConfig.
        /// Format: `projects/{project}/mapConfigs/{map_config}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MapConfig> GetMapConfigAsync(MapConfigName name, st::CancellationToken cancellationToken) =>
            GetMapConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists MapConfigs for a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MapConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMapConfigsResponse, MapConfig> ListMapConfigs(ListMapConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists MapConfigs for a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MapConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMapConfigsResponse, MapConfig> ListMapConfigsAsync(ListMapConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists MapConfigs for a project.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent project that owns the MapConfigs.
        /// Format: `projects/{project}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MapConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMapConfigsResponse, MapConfig> ListMapConfigs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMapConfigsRequest request = new ListMapConfigsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMapConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists MapConfigs for a project.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent project that owns the MapConfigs.
        /// Format: `projects/{project}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MapConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMapConfigsResponse, MapConfig> ListMapConfigsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMapConfigsRequest request = new ListMapConfigsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMapConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists MapConfigs for a project.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent project that owns the MapConfigs.
        /// Format: `projects/{project}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MapConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMapConfigsResponse, MapConfig> ListMapConfigs(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMapConfigsRequest request = new ListMapConfigsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMapConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists MapConfigs for a project.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent project that owns the MapConfigs.
        /// Format: `projects/{project}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MapConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMapConfigsResponse, MapConfig> ListMapConfigsAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMapConfigsRequest request = new ListMapConfigsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMapConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Updates a MapConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MapConfig UpdateMapConfig(UpdateMapConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a MapConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MapConfig> UpdateMapConfigAsync(UpdateMapConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a MapConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MapConfig> UpdateMapConfigAsync(UpdateMapConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateMapConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a MapConfig.
        /// </summary>
        /// <param name="mapConfig">
        /// Required. The MapConfig to update.
        /// 
        /// The MapConfig's `name` field is used to identify the MapConfig to update.
        /// Format: `projects/{project}/mapConfigs/{map_config}`
        /// </param>
        /// <param name="updateMask">
        /// Optional. The specific field to update for the MapConfig. If not specified,
        /// the MapConfig will be updated in its entirety. Valid fields are:
        /// 
        /// * `display_name`
        /// * `description`
        /// * `map_features`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MapConfig UpdateMapConfig(MapConfig mapConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMapConfig(new UpdateMapConfigRequest
            {
                MapConfig = gax::GaxPreconditions.CheckNotNull(mapConfig, nameof(mapConfig)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a MapConfig.
        /// </summary>
        /// <param name="mapConfig">
        /// Required. The MapConfig to update.
        /// 
        /// The MapConfig's `name` field is used to identify the MapConfig to update.
        /// Format: `projects/{project}/mapConfigs/{map_config}`
        /// </param>
        /// <param name="updateMask">
        /// Optional. The specific field to update for the MapConfig. If not specified,
        /// the MapConfig will be updated in its entirety. Valid fields are:
        /// 
        /// * `display_name`
        /// * `description`
        /// * `map_features`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MapConfig> UpdateMapConfigAsync(MapConfig mapConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMapConfigAsync(new UpdateMapConfigRequest
            {
                MapConfig = gax::GaxPreconditions.CheckNotNull(mapConfig, nameof(mapConfig)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a MapConfig.
        /// </summary>
        /// <param name="mapConfig">
        /// Required. The MapConfig to update.
        /// 
        /// The MapConfig's `name` field is used to identify the MapConfig to update.
        /// Format: `projects/{project}/mapConfigs/{map_config}`
        /// </param>
        /// <param name="updateMask">
        /// Optional. The specific field to update for the MapConfig. If not specified,
        /// the MapConfig will be updated in its entirety. Valid fields are:
        /// 
        /// * `display_name`
        /// * `description`
        /// * `map_features`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MapConfig> UpdateMapConfigAsync(MapConfig mapConfig, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateMapConfigAsync(mapConfig, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a MapConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteMapConfig(DeleteMapConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a MapConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMapConfigAsync(DeleteMapConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a MapConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMapConfigAsync(DeleteMapConfigRequest request, st::CancellationToken cancellationToken) =>
            DeleteMapConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a MapConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the MapConfig to delete.
        /// Format: `projects/{project}/mapConfigs/{map_config}`
        /// </param>
        /// <param name="force">
        /// Optional. If set to true, any MapContextConfigs from this MapConfig will
        /// also be deleted. (Otherwise, the request will only work if the MapConfig
        /// has no MapContextConfigs.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteMapConfig(string name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMapConfig(new DeleteMapConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Deletes a MapConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the MapConfig to delete.
        /// Format: `projects/{project}/mapConfigs/{map_config}`
        /// </param>
        /// <param name="force">
        /// Optional. If set to true, any MapContextConfigs from this MapConfig will
        /// also be deleted. (Otherwise, the request will only work if the MapConfig
        /// has no MapContextConfigs.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMapConfigAsync(string name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMapConfigAsync(new DeleteMapConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Deletes a MapConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the MapConfig to delete.
        /// Format: `projects/{project}/mapConfigs/{map_config}`
        /// </param>
        /// <param name="force">
        /// Optional. If set to true, any MapContextConfigs from this MapConfig will
        /// also be deleted. (Otherwise, the request will only work if the MapConfig
        /// has no MapContextConfigs.)
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMapConfigAsync(string name, bool force, st::CancellationToken cancellationToken) =>
            DeleteMapConfigAsync(name, force, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a MapConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the MapConfig to delete.
        /// Format: `projects/{project}/mapConfigs/{map_config}`
        /// </param>
        /// <param name="force">
        /// Optional. If set to true, any MapContextConfigs from this MapConfig will
        /// also be deleted. (Otherwise, the request will only work if the MapConfig
        /// has no MapContextConfigs.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteMapConfig(MapConfigName name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMapConfig(new DeleteMapConfigRequest
            {
                MapConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Deletes a MapConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the MapConfig to delete.
        /// Format: `projects/{project}/mapConfigs/{map_config}`
        /// </param>
        /// <param name="force">
        /// Optional. If set to true, any MapContextConfigs from this MapConfig will
        /// also be deleted. (Otherwise, the request will only work if the MapConfig
        /// has no MapContextConfigs.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMapConfigAsync(MapConfigName name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMapConfigAsync(new DeleteMapConfigRequest
            {
                MapConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Deletes a MapConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the MapConfig to delete.
        /// Format: `projects/{project}/mapConfigs/{map_config}`
        /// </param>
        /// <param name="force">
        /// Optional. If set to true, any MapContextConfigs from this MapConfig will
        /// also be deleted. (Otherwise, the request will only work if the MapConfig
        /// has no MapContextConfigs.)
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMapConfigAsync(MapConfigName name, bool force, st::CancellationToken cancellationToken) =>
            DeleteMapConfigAsync(name, force, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a StyleConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StyleConfig CreateStyleConfig(CreateStyleConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a StyleConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StyleConfig> CreateStyleConfigAsync(CreateStyleConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a StyleConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StyleConfig> CreateStyleConfigAsync(CreateStyleConfigRequest request, st::CancellationToken cancellationToken) =>
            CreateStyleConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a StyleConfig.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent project that will own the StyleConfig.
        /// Format: `projects/{project}`
        /// </param>
        /// <param name="styleConfig">
        /// Required. The StyleConfig to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StyleConfig CreateStyleConfig(string parent, StyleConfig styleConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateStyleConfig(new CreateStyleConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                StyleConfig = gax::GaxPreconditions.CheckNotNull(styleConfig, nameof(styleConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a StyleConfig.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent project that will own the StyleConfig.
        /// Format: `projects/{project}`
        /// </param>
        /// <param name="styleConfig">
        /// Required. The StyleConfig to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StyleConfig> CreateStyleConfigAsync(string parent, StyleConfig styleConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateStyleConfigAsync(new CreateStyleConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                StyleConfig = gax::GaxPreconditions.CheckNotNull(styleConfig, nameof(styleConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a StyleConfig.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent project that will own the StyleConfig.
        /// Format: `projects/{project}`
        /// </param>
        /// <param name="styleConfig">
        /// Required. The StyleConfig to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StyleConfig> CreateStyleConfigAsync(string parent, StyleConfig styleConfig, st::CancellationToken cancellationToken) =>
            CreateStyleConfigAsync(parent, styleConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a StyleConfig.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent project that will own the StyleConfig.
        /// Format: `projects/{project}`
        /// </param>
        /// <param name="styleConfig">
        /// Required. The StyleConfig to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StyleConfig CreateStyleConfig(gagr::ProjectName parent, StyleConfig styleConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateStyleConfig(new CreateStyleConfigRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                StyleConfig = gax::GaxPreconditions.CheckNotNull(styleConfig, nameof(styleConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a StyleConfig.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent project that will own the StyleConfig.
        /// Format: `projects/{project}`
        /// </param>
        /// <param name="styleConfig">
        /// Required. The StyleConfig to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StyleConfig> CreateStyleConfigAsync(gagr::ProjectName parent, StyleConfig styleConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateStyleConfigAsync(new CreateStyleConfigRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                StyleConfig = gax::GaxPreconditions.CheckNotNull(styleConfig, nameof(styleConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a StyleConfig.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent project that will own the StyleConfig.
        /// Format: `projects/{project}`
        /// </param>
        /// <param name="styleConfig">
        /// Required. The StyleConfig to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StyleConfig> CreateStyleConfigAsync(gagr::ProjectName parent, StyleConfig styleConfig, st::CancellationToken cancellationToken) =>
            CreateStyleConfigAsync(parent, styleConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a StyleConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StyleConfig GetStyleConfig(GetStyleConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a StyleConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StyleConfig> GetStyleConfigAsync(GetStyleConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a StyleConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StyleConfig> GetStyleConfigAsync(GetStyleConfigRequest request, st::CancellationToken cancellationToken) =>
            GetStyleConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a StyleConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the StyleConfig.
        /// Format: `projects/{project}/styleConfigs/{style_config}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StyleConfig GetStyleConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetStyleConfig(new GetStyleConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a StyleConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the StyleConfig.
        /// Format: `projects/{project}/styleConfigs/{style_config}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StyleConfig> GetStyleConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetStyleConfigAsync(new GetStyleConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a StyleConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the StyleConfig.
        /// Format: `projects/{project}/styleConfigs/{style_config}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StyleConfig> GetStyleConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetStyleConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a StyleConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the StyleConfig.
        /// Format: `projects/{project}/styleConfigs/{style_config}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StyleConfig GetStyleConfig(StyleConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetStyleConfig(new GetStyleConfigRequest
            {
                StyleConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a StyleConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the StyleConfig.
        /// Format: `projects/{project}/styleConfigs/{style_config}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StyleConfig> GetStyleConfigAsync(StyleConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetStyleConfigAsync(new GetStyleConfigRequest
            {
                StyleConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a StyleConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the StyleConfig.
        /// Format: `projects/{project}/styleConfigs/{style_config}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StyleConfig> GetStyleConfigAsync(StyleConfigName name, st::CancellationToken cancellationToken) =>
            GetStyleConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists StyleConfigs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="StyleConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListStyleConfigsResponse, StyleConfig> ListStyleConfigs(ListStyleConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists StyleConfigs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="StyleConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListStyleConfigsResponse, StyleConfig> ListStyleConfigsAsync(ListStyleConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists StyleConfigs.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent project that owns the StyleConfigs.
        /// Format: `projects/{project}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="StyleConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListStyleConfigsResponse, StyleConfig> ListStyleConfigs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListStyleConfigsRequest request = new ListStyleConfigsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListStyleConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists StyleConfigs.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent project that owns the StyleConfigs.
        /// Format: `projects/{project}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="StyleConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListStyleConfigsResponse, StyleConfig> ListStyleConfigsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListStyleConfigsRequest request = new ListStyleConfigsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListStyleConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists StyleConfigs.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent project that owns the StyleConfigs.
        /// Format: `projects/{project}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="StyleConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListStyleConfigsResponse, StyleConfig> ListStyleConfigs(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListStyleConfigsRequest request = new ListStyleConfigsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListStyleConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists StyleConfigs.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent project that owns the StyleConfigs.
        /// Format: `projects/{project}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="StyleConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListStyleConfigsResponse, StyleConfig> ListStyleConfigsAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListStyleConfigsRequest request = new ListStyleConfigsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListStyleConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Updates a StyleConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StyleConfig UpdateStyleConfig(UpdateStyleConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a StyleConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StyleConfig> UpdateStyleConfigAsync(UpdateStyleConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a StyleConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StyleConfig> UpdateStyleConfigAsync(UpdateStyleConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateStyleConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a StyleConfig.
        /// </summary>
        /// <param name="styleConfig">
        /// Required. The StyleConfig to update.
        /// 
        /// The StyleConfig's `name` field is used to identify the StyleConfig to
        /// update. Format: `projects/{project}/styleConfigs/{style_config}`
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update. If not specified, the StyleConfig
        /// will be updated in its entirety. Valid fields are:
        /// 
        /// * `display_name`
        /// * `description`
        /// * `json_style_sheet`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StyleConfig UpdateStyleConfig(StyleConfig styleConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateStyleConfig(new UpdateStyleConfigRequest
            {
                StyleConfig = gax::GaxPreconditions.CheckNotNull(styleConfig, nameof(styleConfig)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a StyleConfig.
        /// </summary>
        /// <param name="styleConfig">
        /// Required. The StyleConfig to update.
        /// 
        /// The StyleConfig's `name` field is used to identify the StyleConfig to
        /// update. Format: `projects/{project}/styleConfigs/{style_config}`
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update. If not specified, the StyleConfig
        /// will be updated in its entirety. Valid fields are:
        /// 
        /// * `display_name`
        /// * `description`
        /// * `json_style_sheet`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StyleConfig> UpdateStyleConfigAsync(StyleConfig styleConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateStyleConfigAsync(new UpdateStyleConfigRequest
            {
                StyleConfig = gax::GaxPreconditions.CheckNotNull(styleConfig, nameof(styleConfig)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a StyleConfig.
        /// </summary>
        /// <param name="styleConfig">
        /// Required. The StyleConfig to update.
        /// 
        /// The StyleConfig's `name` field is used to identify the StyleConfig to
        /// update. Format: `projects/{project}/styleConfigs/{style_config}`
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update. If not specified, the StyleConfig
        /// will be updated in its entirety. Valid fields are:
        /// 
        /// * `display_name`
        /// * `description`
        /// * `json_style_sheet`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StyleConfig> UpdateStyleConfigAsync(StyleConfig styleConfig, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateStyleConfigAsync(styleConfig, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a StyleConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteStyleConfig(DeleteStyleConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a StyleConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteStyleConfigAsync(DeleteStyleConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a StyleConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteStyleConfigAsync(DeleteStyleConfigRequest request, st::CancellationToken cancellationToken) =>
            DeleteStyleConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a StyleConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the StyleConfig to delete.
        /// Format: `projects/{project}/styleConfigs/{style_config}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteStyleConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteStyleConfig(new DeleteStyleConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a StyleConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the StyleConfig to delete.
        /// Format: `projects/{project}/styleConfigs/{style_config}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteStyleConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteStyleConfigAsync(new DeleteStyleConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a StyleConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the StyleConfig to delete.
        /// Format: `projects/{project}/styleConfigs/{style_config}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteStyleConfigAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteStyleConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a StyleConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the StyleConfig to delete.
        /// Format: `projects/{project}/styleConfigs/{style_config}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteStyleConfig(StyleConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteStyleConfig(new DeleteStyleConfigRequest
            {
                StyleConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a StyleConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the StyleConfig to delete.
        /// Format: `projects/{project}/styleConfigs/{style_config}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteStyleConfigAsync(StyleConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteStyleConfigAsync(new DeleteStyleConfigRequest
            {
                StyleConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a StyleConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the StyleConfig to delete.
        /// Format: `projects/{project}/styleConfigs/{style_config}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteStyleConfigAsync(StyleConfigName name, st::CancellationToken cancellationToken) =>
            DeleteStyleConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a MapContextConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MapContextConfig CreateMapContextConfig(CreateMapContextConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a MapContextConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MapContextConfig> CreateMapContextConfigAsync(CreateMapContextConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a MapContextConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MapContextConfig> CreateMapContextConfigAsync(CreateMapContextConfigRequest request, st::CancellationToken cancellationToken) =>
            CreateMapContextConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a MapContextConfig.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent MapConfig that will own the MapContextConfig.
        /// Format: `projects/{project}/mapConfigs/{map_config}`
        /// </param>
        /// <param name="mapContextConfig">
        /// Required. The MapContextConfig to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MapContextConfig CreateMapContextConfig(string parent, MapContextConfig mapContextConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateMapContextConfig(new CreateMapContextConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MapContextConfig = gax::GaxPreconditions.CheckNotNull(mapContextConfig, nameof(mapContextConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a MapContextConfig.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent MapConfig that will own the MapContextConfig.
        /// Format: `projects/{project}/mapConfigs/{map_config}`
        /// </param>
        /// <param name="mapContextConfig">
        /// Required. The MapContextConfig to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MapContextConfig> CreateMapContextConfigAsync(string parent, MapContextConfig mapContextConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateMapContextConfigAsync(new CreateMapContextConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MapContextConfig = gax::GaxPreconditions.CheckNotNull(mapContextConfig, nameof(mapContextConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a MapContextConfig.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent MapConfig that will own the MapContextConfig.
        /// Format: `projects/{project}/mapConfigs/{map_config}`
        /// </param>
        /// <param name="mapContextConfig">
        /// Required. The MapContextConfig to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MapContextConfig> CreateMapContextConfigAsync(string parent, MapContextConfig mapContextConfig, st::CancellationToken cancellationToken) =>
            CreateMapContextConfigAsync(parent, mapContextConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a MapContextConfig.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent MapConfig that will own the MapContextConfig.
        /// Format: `projects/{project}/mapConfigs/{map_config}`
        /// </param>
        /// <param name="mapContextConfig">
        /// Required. The MapContextConfig to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MapContextConfig CreateMapContextConfig(MapConfigName parent, MapContextConfig mapContextConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateMapContextConfig(new CreateMapContextConfigRequest
            {
                ParentAsMapConfigName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MapContextConfig = gax::GaxPreconditions.CheckNotNull(mapContextConfig, nameof(mapContextConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a MapContextConfig.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent MapConfig that will own the MapContextConfig.
        /// Format: `projects/{project}/mapConfigs/{map_config}`
        /// </param>
        /// <param name="mapContextConfig">
        /// Required. The MapContextConfig to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MapContextConfig> CreateMapContextConfigAsync(MapConfigName parent, MapContextConfig mapContextConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateMapContextConfigAsync(new CreateMapContextConfigRequest
            {
                ParentAsMapConfigName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MapContextConfig = gax::GaxPreconditions.CheckNotNull(mapContextConfig, nameof(mapContextConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a MapContextConfig.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent MapConfig that will own the MapContextConfig.
        /// Format: `projects/{project}/mapConfigs/{map_config}`
        /// </param>
        /// <param name="mapContextConfig">
        /// Required. The MapContextConfig to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MapContextConfig> CreateMapContextConfigAsync(MapConfigName parent, MapContextConfig mapContextConfig, st::CancellationToken cancellationToken) =>
            CreateMapContextConfigAsync(parent, mapContextConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a MapContextConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MapContextConfig GetMapContextConfig(GetMapContextConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a MapContextConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MapContextConfig> GetMapContextConfigAsync(GetMapContextConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a MapContextConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MapContextConfig> GetMapContextConfigAsync(GetMapContextConfigRequest request, st::CancellationToken cancellationToken) =>
            GetMapContextConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a MapContextConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the MapContextConfig.
        /// Format:
        /// `projects/{project}/mapConfigs/{map_config}/mapContextConfigs/{map_context_config}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MapContextConfig GetMapContextConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMapContextConfig(new GetMapContextConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a MapContextConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the MapContextConfig.
        /// Format:
        /// `projects/{project}/mapConfigs/{map_config}/mapContextConfigs/{map_context_config}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MapContextConfig> GetMapContextConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMapContextConfigAsync(new GetMapContextConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a MapContextConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the MapContextConfig.
        /// Format:
        /// `projects/{project}/mapConfigs/{map_config}/mapContextConfigs/{map_context_config}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MapContextConfig> GetMapContextConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetMapContextConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a MapContextConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the MapContextConfig.
        /// Format:
        /// `projects/{project}/mapConfigs/{map_config}/mapContextConfigs/{map_context_config}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MapContextConfig GetMapContextConfig(MapContextConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMapContextConfig(new GetMapContextConfigRequest
            {
                MapContextConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a MapContextConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the MapContextConfig.
        /// Format:
        /// `projects/{project}/mapConfigs/{map_config}/mapContextConfigs/{map_context_config}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MapContextConfig> GetMapContextConfigAsync(MapContextConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMapContextConfigAsync(new GetMapContextConfigRequest
            {
                MapContextConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a MapContextConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the MapContextConfig.
        /// Format:
        /// `projects/{project}/mapConfigs/{map_config}/mapContextConfigs/{map_context_config}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MapContextConfig> GetMapContextConfigAsync(MapContextConfigName name, st::CancellationToken cancellationToken) =>
            GetMapContextConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists MapContextConfigs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MapContextConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMapContextConfigsResponse, MapContextConfig> ListMapContextConfigs(ListMapContextConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists MapContextConfigs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MapContextConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMapContextConfigsResponse, MapContextConfig> ListMapContextConfigsAsync(ListMapContextConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists MapContextConfigs.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent MapConfig that owns the MapContextConfigs.
        /// Format: `projects/{project}/mapConfigs/{map_config}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MapContextConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMapContextConfigsResponse, MapContextConfig> ListMapContextConfigs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMapContextConfigsRequest request = new ListMapContextConfigsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMapContextConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists MapContextConfigs.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent MapConfig that owns the MapContextConfigs.
        /// Format: `projects/{project}/mapConfigs/{map_config}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MapContextConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMapContextConfigsResponse, MapContextConfig> ListMapContextConfigsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMapContextConfigsRequest request = new ListMapContextConfigsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMapContextConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists MapContextConfigs.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent MapConfig that owns the MapContextConfigs.
        /// Format: `projects/{project}/mapConfigs/{map_config}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MapContextConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMapContextConfigsResponse, MapContextConfig> ListMapContextConfigs(MapConfigName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMapContextConfigsRequest request = new ListMapContextConfigsRequest
            {
                ParentAsMapConfigName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMapContextConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists MapContextConfigs.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent MapConfig that owns the MapContextConfigs.
        /// Format: `projects/{project}/mapConfigs/{map_config}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MapContextConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMapContextConfigsResponse, MapContextConfig> ListMapContextConfigsAsync(MapConfigName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMapContextConfigsRequest request = new ListMapContextConfigsRequest
            {
                ParentAsMapConfigName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMapContextConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Updates a MapContextConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MapContextConfig UpdateMapContextConfig(UpdateMapContextConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a MapContextConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MapContextConfig> UpdateMapContextConfigAsync(UpdateMapContextConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a MapContextConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MapContextConfig> UpdateMapContextConfigAsync(UpdateMapContextConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateMapContextConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a MapContextConfig.
        /// </summary>
        /// <param name="mapContextConfig">
        /// Required. The MapContextConfig to update.
        /// 
        /// The MapContextConfig's `name` field is used to identify the
        /// MapContextConfig to update. Format:
        /// `projects/{project}/mapConfigs/{map_config}/mapContextConfigs/{map_context_config}`
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update. If not specified, the
        /// MapContextConfig will be updated in its entirety. Valid fields are:
        /// 
        /// * `display_name`
        /// * `alias`
        /// * `map_variants`
        /// * `style_config`
        /// * `dataset`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MapContextConfig UpdateMapContextConfig(MapContextConfig mapContextConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMapContextConfig(new UpdateMapContextConfigRequest
            {
                MapContextConfig = gax::GaxPreconditions.CheckNotNull(mapContextConfig, nameof(mapContextConfig)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a MapContextConfig.
        /// </summary>
        /// <param name="mapContextConfig">
        /// Required. The MapContextConfig to update.
        /// 
        /// The MapContextConfig's `name` field is used to identify the
        /// MapContextConfig to update. Format:
        /// `projects/{project}/mapConfigs/{map_config}/mapContextConfigs/{map_context_config}`
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update. If not specified, the
        /// MapContextConfig will be updated in its entirety. Valid fields are:
        /// 
        /// * `display_name`
        /// * `alias`
        /// * `map_variants`
        /// * `style_config`
        /// * `dataset`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MapContextConfig> UpdateMapContextConfigAsync(MapContextConfig mapContextConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMapContextConfigAsync(new UpdateMapContextConfigRequest
            {
                MapContextConfig = gax::GaxPreconditions.CheckNotNull(mapContextConfig, nameof(mapContextConfig)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a MapContextConfig.
        /// </summary>
        /// <param name="mapContextConfig">
        /// Required. The MapContextConfig to update.
        /// 
        /// The MapContextConfig's `name` field is used to identify the
        /// MapContextConfig to update. Format:
        /// `projects/{project}/mapConfigs/{map_config}/mapContextConfigs/{map_context_config}`
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update. If not specified, the
        /// MapContextConfig will be updated in its entirety. Valid fields are:
        /// 
        /// * `display_name`
        /// * `alias`
        /// * `map_variants`
        /// * `style_config`
        /// * `dataset`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MapContextConfig> UpdateMapContextConfigAsync(MapContextConfig mapContextConfig, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateMapContextConfigAsync(mapContextConfig, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a MapContextConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteMapContextConfig(DeleteMapContextConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a MapContextConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMapContextConfigAsync(DeleteMapContextConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a MapContextConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMapContextConfigAsync(DeleteMapContextConfigRequest request, st::CancellationToken cancellationToken) =>
            DeleteMapContextConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a MapContextConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the MapContextConfig to delete.
        /// Format:
        /// `projects/{project}/mapConfigs/{map_config}/mapContextConfigs/{map_context_config}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteMapContextConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMapContextConfig(new DeleteMapContextConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a MapContextConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the MapContextConfig to delete.
        /// Format:
        /// `projects/{project}/mapConfigs/{map_config}/mapContextConfigs/{map_context_config}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMapContextConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMapContextConfigAsync(new DeleteMapContextConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a MapContextConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the MapContextConfig to delete.
        /// Format:
        /// `projects/{project}/mapConfigs/{map_config}/mapContextConfigs/{map_context_config}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMapContextConfigAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteMapContextConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a MapContextConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the MapContextConfig to delete.
        /// Format:
        /// `projects/{project}/mapConfigs/{map_config}/mapContextConfigs/{map_context_config}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteMapContextConfig(MapContextConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMapContextConfig(new DeleteMapContextConfigRequest
            {
                MapContextConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a MapContextConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the MapContextConfig to delete.
        /// Format:
        /// `projects/{project}/mapConfigs/{map_config}/mapContextConfigs/{map_context_config}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMapContextConfigAsync(MapContextConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMapContextConfigAsync(new DeleteMapContextConfigRequest
            {
                MapContextConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a MapContextConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the MapContextConfig to delete.
        /// Format:
        /// `projects/{project}/mapConfigs/{map_config}/mapContextConfigs/{map_context_config}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMapContextConfigAsync(MapContextConfigName name, st::CancellationToken cancellationToken) =>
            DeleteMapContextConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>MapManagement client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The Map Management API uses your inputs to create and manage
    /// Google Cloud based styling resources for Google Maps.
    /// 
    /// Using this API, you can can create and manage MapConfigs (Map IDs),
    /// StyleConfigs (JSON-based styling), and MapContextConfigs (associations
    /// between styles, datasets, and map variants).
    /// 
    /// This API offers features through three channels:
    /// * `v2alpha`: Experimental features.
    /// * `v2beta`: Preview features, recommended for early adoption.
    /// * `v2`: General Availability (GA) features.
    /// 
    /// Capabilities described here are generally available across both the v2alpha
    /// and v2beta endpoints.
    /// </remarks>
    public sealed partial class MapManagementClientImpl : MapManagementClient
    {
        private readonly gaxgrpc::ApiCall<CreateMapConfigRequest, MapConfig> _callCreateMapConfig;

        private readonly gaxgrpc::ApiCall<GetMapConfigRequest, MapConfig> _callGetMapConfig;

        private readonly gaxgrpc::ApiCall<ListMapConfigsRequest, ListMapConfigsResponse> _callListMapConfigs;

        private readonly gaxgrpc::ApiCall<UpdateMapConfigRequest, MapConfig> _callUpdateMapConfig;

        private readonly gaxgrpc::ApiCall<DeleteMapConfigRequest, wkt::Empty> _callDeleteMapConfig;

        private readonly gaxgrpc::ApiCall<CreateStyleConfigRequest, StyleConfig> _callCreateStyleConfig;

        private readonly gaxgrpc::ApiCall<GetStyleConfigRequest, StyleConfig> _callGetStyleConfig;

        private readonly gaxgrpc::ApiCall<ListStyleConfigsRequest, ListStyleConfigsResponse> _callListStyleConfigs;

        private readonly gaxgrpc::ApiCall<UpdateStyleConfigRequest, StyleConfig> _callUpdateStyleConfig;

        private readonly gaxgrpc::ApiCall<DeleteStyleConfigRequest, wkt::Empty> _callDeleteStyleConfig;

        private readonly gaxgrpc::ApiCall<CreateMapContextConfigRequest, MapContextConfig> _callCreateMapContextConfig;

        private readonly gaxgrpc::ApiCall<GetMapContextConfigRequest, MapContextConfig> _callGetMapContextConfig;

        private readonly gaxgrpc::ApiCall<ListMapContextConfigsRequest, ListMapContextConfigsResponse> _callListMapContextConfigs;

        private readonly gaxgrpc::ApiCall<UpdateMapContextConfigRequest, MapContextConfig> _callUpdateMapContextConfig;

        private readonly gaxgrpc::ApiCall<DeleteMapContextConfigRequest, wkt::Empty> _callDeleteMapContextConfig;

        /// <summary>
        /// Constructs a client wrapper for the MapManagement service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="MapManagementSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public MapManagementClientImpl(MapManagement.MapManagementClient grpcClient, MapManagementSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            MapManagementSettings effectiveSettings = settings ?? MapManagementSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callCreateMapConfig = clientHelper.BuildApiCall<CreateMapConfigRequest, MapConfig>("CreateMapConfig", grpcClient.CreateMapConfigAsync, grpcClient.CreateMapConfig, effectiveSettings.CreateMapConfigSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateMapConfig);
            Modify_CreateMapConfigApiCall(ref _callCreateMapConfig);
            _callGetMapConfig = clientHelper.BuildApiCall<GetMapConfigRequest, MapConfig>("GetMapConfig", grpcClient.GetMapConfigAsync, grpcClient.GetMapConfig, effectiveSettings.GetMapConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMapConfig);
            Modify_GetMapConfigApiCall(ref _callGetMapConfig);
            _callListMapConfigs = clientHelper.BuildApiCall<ListMapConfigsRequest, ListMapConfigsResponse>("ListMapConfigs", grpcClient.ListMapConfigsAsync, grpcClient.ListMapConfigs, effectiveSettings.ListMapConfigsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListMapConfigs);
            Modify_ListMapConfigsApiCall(ref _callListMapConfigs);
            _callUpdateMapConfig = clientHelper.BuildApiCall<UpdateMapConfigRequest, MapConfig>("UpdateMapConfig", grpcClient.UpdateMapConfigAsync, grpcClient.UpdateMapConfig, effectiveSettings.UpdateMapConfigSettings).WithGoogleRequestParam("map_config.name", request => request.MapConfig?.Name);
            Modify_ApiCall(ref _callUpdateMapConfig);
            Modify_UpdateMapConfigApiCall(ref _callUpdateMapConfig);
            _callDeleteMapConfig = clientHelper.BuildApiCall<DeleteMapConfigRequest, wkt::Empty>("DeleteMapConfig", grpcClient.DeleteMapConfigAsync, grpcClient.DeleteMapConfig, effectiveSettings.DeleteMapConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteMapConfig);
            Modify_DeleteMapConfigApiCall(ref _callDeleteMapConfig);
            _callCreateStyleConfig = clientHelper.BuildApiCall<CreateStyleConfigRequest, StyleConfig>("CreateStyleConfig", grpcClient.CreateStyleConfigAsync, grpcClient.CreateStyleConfig, effectiveSettings.CreateStyleConfigSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateStyleConfig);
            Modify_CreateStyleConfigApiCall(ref _callCreateStyleConfig);
            _callGetStyleConfig = clientHelper.BuildApiCall<GetStyleConfigRequest, StyleConfig>("GetStyleConfig", grpcClient.GetStyleConfigAsync, grpcClient.GetStyleConfig, effectiveSettings.GetStyleConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetStyleConfig);
            Modify_GetStyleConfigApiCall(ref _callGetStyleConfig);
            _callListStyleConfigs = clientHelper.BuildApiCall<ListStyleConfigsRequest, ListStyleConfigsResponse>("ListStyleConfigs", grpcClient.ListStyleConfigsAsync, grpcClient.ListStyleConfigs, effectiveSettings.ListStyleConfigsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListStyleConfigs);
            Modify_ListStyleConfigsApiCall(ref _callListStyleConfigs);
            _callUpdateStyleConfig = clientHelper.BuildApiCall<UpdateStyleConfigRequest, StyleConfig>("UpdateStyleConfig", grpcClient.UpdateStyleConfigAsync, grpcClient.UpdateStyleConfig, effectiveSettings.UpdateStyleConfigSettings).WithGoogleRequestParam("style_config.name", request => request.StyleConfig?.Name);
            Modify_ApiCall(ref _callUpdateStyleConfig);
            Modify_UpdateStyleConfigApiCall(ref _callUpdateStyleConfig);
            _callDeleteStyleConfig = clientHelper.BuildApiCall<DeleteStyleConfigRequest, wkt::Empty>("DeleteStyleConfig", grpcClient.DeleteStyleConfigAsync, grpcClient.DeleteStyleConfig, effectiveSettings.DeleteStyleConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteStyleConfig);
            Modify_DeleteStyleConfigApiCall(ref _callDeleteStyleConfig);
            _callCreateMapContextConfig = clientHelper.BuildApiCall<CreateMapContextConfigRequest, MapContextConfig>("CreateMapContextConfig", grpcClient.CreateMapContextConfigAsync, grpcClient.CreateMapContextConfig, effectiveSettings.CreateMapContextConfigSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateMapContextConfig);
            Modify_CreateMapContextConfigApiCall(ref _callCreateMapContextConfig);
            _callGetMapContextConfig = clientHelper.BuildApiCall<GetMapContextConfigRequest, MapContextConfig>("GetMapContextConfig", grpcClient.GetMapContextConfigAsync, grpcClient.GetMapContextConfig, effectiveSettings.GetMapContextConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMapContextConfig);
            Modify_GetMapContextConfigApiCall(ref _callGetMapContextConfig);
            _callListMapContextConfigs = clientHelper.BuildApiCall<ListMapContextConfigsRequest, ListMapContextConfigsResponse>("ListMapContextConfigs", grpcClient.ListMapContextConfigsAsync, grpcClient.ListMapContextConfigs, effectiveSettings.ListMapContextConfigsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListMapContextConfigs);
            Modify_ListMapContextConfigsApiCall(ref _callListMapContextConfigs);
            _callUpdateMapContextConfig = clientHelper.BuildApiCall<UpdateMapContextConfigRequest, MapContextConfig>("UpdateMapContextConfig", grpcClient.UpdateMapContextConfigAsync, grpcClient.UpdateMapContextConfig, effectiveSettings.UpdateMapContextConfigSettings).WithGoogleRequestParam("map_context_config.name", request => request.MapContextConfig?.Name);
            Modify_ApiCall(ref _callUpdateMapContextConfig);
            Modify_UpdateMapContextConfigApiCall(ref _callUpdateMapContextConfig);
            _callDeleteMapContextConfig = clientHelper.BuildApiCall<DeleteMapContextConfigRequest, wkt::Empty>("DeleteMapContextConfig", grpcClient.DeleteMapContextConfigAsync, grpcClient.DeleteMapContextConfig, effectiveSettings.DeleteMapContextConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteMapContextConfig);
            Modify_DeleteMapContextConfigApiCall(ref _callDeleteMapContextConfig);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateMapConfigApiCall(ref gaxgrpc::ApiCall<CreateMapConfigRequest, MapConfig> call);

        partial void Modify_GetMapConfigApiCall(ref gaxgrpc::ApiCall<GetMapConfigRequest, MapConfig> call);

        partial void Modify_ListMapConfigsApiCall(ref gaxgrpc::ApiCall<ListMapConfigsRequest, ListMapConfigsResponse> call);

        partial void Modify_UpdateMapConfigApiCall(ref gaxgrpc::ApiCall<UpdateMapConfigRequest, MapConfig> call);

        partial void Modify_DeleteMapConfigApiCall(ref gaxgrpc::ApiCall<DeleteMapConfigRequest, wkt::Empty> call);

        partial void Modify_CreateStyleConfigApiCall(ref gaxgrpc::ApiCall<CreateStyleConfigRequest, StyleConfig> call);

        partial void Modify_GetStyleConfigApiCall(ref gaxgrpc::ApiCall<GetStyleConfigRequest, StyleConfig> call);

        partial void Modify_ListStyleConfigsApiCall(ref gaxgrpc::ApiCall<ListStyleConfigsRequest, ListStyleConfigsResponse> call);

        partial void Modify_UpdateStyleConfigApiCall(ref gaxgrpc::ApiCall<UpdateStyleConfigRequest, StyleConfig> call);

        partial void Modify_DeleteStyleConfigApiCall(ref gaxgrpc::ApiCall<DeleteStyleConfigRequest, wkt::Empty> call);

        partial void Modify_CreateMapContextConfigApiCall(ref gaxgrpc::ApiCall<CreateMapContextConfigRequest, MapContextConfig> call);

        partial void Modify_GetMapContextConfigApiCall(ref gaxgrpc::ApiCall<GetMapContextConfigRequest, MapContextConfig> call);

        partial void Modify_ListMapContextConfigsApiCall(ref gaxgrpc::ApiCall<ListMapContextConfigsRequest, ListMapContextConfigsResponse> call);

        partial void Modify_UpdateMapContextConfigApiCall(ref gaxgrpc::ApiCall<UpdateMapContextConfigRequest, MapContextConfig> call);

        partial void Modify_DeleteMapContextConfigApiCall(ref gaxgrpc::ApiCall<DeleteMapContextConfigRequest, wkt::Empty> call);

        partial void OnConstruction(MapManagement.MapManagementClient grpcClient, MapManagementSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC MapManagement client</summary>
        public override MapManagement.MapManagementClient GrpcClient { get; }

        partial void Modify_CreateMapConfigRequest(ref CreateMapConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetMapConfigRequest(ref GetMapConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListMapConfigsRequest(ref ListMapConfigsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateMapConfigRequest(ref UpdateMapConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteMapConfigRequest(ref DeleteMapConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateStyleConfigRequest(ref CreateStyleConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetStyleConfigRequest(ref GetStyleConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListStyleConfigsRequest(ref ListStyleConfigsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateStyleConfigRequest(ref UpdateStyleConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteStyleConfigRequest(ref DeleteStyleConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateMapContextConfigRequest(ref CreateMapContextConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetMapContextConfigRequest(ref GetMapContextConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListMapContextConfigsRequest(ref ListMapContextConfigsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateMapContextConfigRequest(ref UpdateMapContextConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteMapContextConfigRequest(ref DeleteMapContextConfigRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a MapConfig in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MapConfig CreateMapConfig(CreateMapConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMapConfigRequest(ref request, ref callSettings);
            return _callCreateMapConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a MapConfig in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MapConfig> CreateMapConfigAsync(CreateMapConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMapConfigRequest(ref request, ref callSettings);
            return _callCreateMapConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a MapConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MapConfig GetMapConfig(GetMapConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMapConfigRequest(ref request, ref callSettings);
            return _callGetMapConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a MapConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MapConfig> GetMapConfigAsync(GetMapConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMapConfigRequest(ref request, ref callSettings);
            return _callGetMapConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Lists MapConfigs for a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MapConfig"/> resources.</returns>
        public override gax::PagedEnumerable<ListMapConfigsResponse, MapConfig> ListMapConfigs(ListMapConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMapConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMapConfigsRequest, ListMapConfigsResponse, MapConfig>(_callListMapConfigs, request, callSettings);
        }

        /// <summary>
        /// Lists MapConfigs for a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MapConfig"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListMapConfigsResponse, MapConfig> ListMapConfigsAsync(ListMapConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMapConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMapConfigsRequest, ListMapConfigsResponse, MapConfig>(_callListMapConfigs, request, callSettings);
        }

        /// <summary>
        /// Updates a MapConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MapConfig UpdateMapConfig(UpdateMapConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMapConfigRequest(ref request, ref callSettings);
            return _callUpdateMapConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a MapConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MapConfig> UpdateMapConfigAsync(UpdateMapConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMapConfigRequest(ref request, ref callSettings);
            return _callUpdateMapConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a MapConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteMapConfig(DeleteMapConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMapConfigRequest(ref request, ref callSettings);
            _callDeleteMapConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a MapConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteMapConfigAsync(DeleteMapConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMapConfigRequest(ref request, ref callSettings);
            return _callDeleteMapConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a StyleConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override StyleConfig CreateStyleConfig(CreateStyleConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateStyleConfigRequest(ref request, ref callSettings);
            return _callCreateStyleConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a StyleConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<StyleConfig> CreateStyleConfigAsync(CreateStyleConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateStyleConfigRequest(ref request, ref callSettings);
            return _callCreateStyleConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a StyleConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override StyleConfig GetStyleConfig(GetStyleConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetStyleConfigRequest(ref request, ref callSettings);
            return _callGetStyleConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a StyleConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<StyleConfig> GetStyleConfigAsync(GetStyleConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetStyleConfigRequest(ref request, ref callSettings);
            return _callGetStyleConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Lists StyleConfigs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="StyleConfig"/> resources.</returns>
        public override gax::PagedEnumerable<ListStyleConfigsResponse, StyleConfig> ListStyleConfigs(ListStyleConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListStyleConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListStyleConfigsRequest, ListStyleConfigsResponse, StyleConfig>(_callListStyleConfigs, request, callSettings);
        }

        /// <summary>
        /// Lists StyleConfigs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="StyleConfig"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListStyleConfigsResponse, StyleConfig> ListStyleConfigsAsync(ListStyleConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListStyleConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListStyleConfigsRequest, ListStyleConfigsResponse, StyleConfig>(_callListStyleConfigs, request, callSettings);
        }

        /// <summary>
        /// Updates a StyleConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override StyleConfig UpdateStyleConfig(UpdateStyleConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateStyleConfigRequest(ref request, ref callSettings);
            return _callUpdateStyleConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a StyleConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<StyleConfig> UpdateStyleConfigAsync(UpdateStyleConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateStyleConfigRequest(ref request, ref callSettings);
            return _callUpdateStyleConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a StyleConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteStyleConfig(DeleteStyleConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteStyleConfigRequest(ref request, ref callSettings);
            _callDeleteStyleConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a StyleConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteStyleConfigAsync(DeleteStyleConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteStyleConfigRequest(ref request, ref callSettings);
            return _callDeleteStyleConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a MapContextConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MapContextConfig CreateMapContextConfig(CreateMapContextConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMapContextConfigRequest(ref request, ref callSettings);
            return _callCreateMapContextConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a MapContextConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MapContextConfig> CreateMapContextConfigAsync(CreateMapContextConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMapContextConfigRequest(ref request, ref callSettings);
            return _callCreateMapContextConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a MapContextConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MapContextConfig GetMapContextConfig(GetMapContextConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMapContextConfigRequest(ref request, ref callSettings);
            return _callGetMapContextConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a MapContextConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MapContextConfig> GetMapContextConfigAsync(GetMapContextConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMapContextConfigRequest(ref request, ref callSettings);
            return _callGetMapContextConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Lists MapContextConfigs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MapContextConfig"/> resources.</returns>
        public override gax::PagedEnumerable<ListMapContextConfigsResponse, MapContextConfig> ListMapContextConfigs(ListMapContextConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMapContextConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMapContextConfigsRequest, ListMapContextConfigsResponse, MapContextConfig>(_callListMapContextConfigs, request, callSettings);
        }

        /// <summary>
        /// Lists MapContextConfigs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MapContextConfig"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListMapContextConfigsResponse, MapContextConfig> ListMapContextConfigsAsync(ListMapContextConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMapContextConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMapContextConfigsRequest, ListMapContextConfigsResponse, MapContextConfig>(_callListMapContextConfigs, request, callSettings);
        }

        /// <summary>
        /// Updates a MapContextConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MapContextConfig UpdateMapContextConfig(UpdateMapContextConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMapContextConfigRequest(ref request, ref callSettings);
            return _callUpdateMapContextConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a MapContextConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MapContextConfig> UpdateMapContextConfigAsync(UpdateMapContextConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMapContextConfigRequest(ref request, ref callSettings);
            return _callUpdateMapContextConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a MapContextConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteMapContextConfig(DeleteMapContextConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMapContextConfigRequest(ref request, ref callSettings);
            _callDeleteMapContextConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a MapContextConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteMapContextConfigAsync(DeleteMapContextConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMapContextConfigRequest(ref request, ref callSettings);
            return _callDeleteMapContextConfig.Async(request, callSettings);
        }
    }

    public partial class ListMapConfigsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListStyleConfigsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMapContextConfigsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMapConfigsResponse : gaxgrpc::IPageResponse<MapConfig>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<MapConfig> GetEnumerator() => MapConfigs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListStyleConfigsResponse : gaxgrpc::IPageResponse<StyleConfig>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<StyleConfig> GetEnumerator() => StyleConfigs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListMapContextConfigsResponse : gaxgrpc::IPageResponse<MapContextConfig>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<MapContextConfig> GetEnumerator() => MapContextConfigs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
