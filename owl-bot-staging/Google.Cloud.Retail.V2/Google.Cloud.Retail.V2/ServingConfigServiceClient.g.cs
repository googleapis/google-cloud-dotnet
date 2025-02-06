// Copyright 2025 Google LLC
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

namespace Google.Cloud.Retail.V2
{
    /// <summary>Settings for <see cref="ServingConfigServiceClient"/> instances.</summary>
    public sealed partial class ServingConfigServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ServingConfigServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ServingConfigServiceSettings"/>.</returns>
        public static ServingConfigServiceSettings GetDefault() => new ServingConfigServiceSettings();

        /// <summary>Constructs a new <see cref="ServingConfigServiceSettings"/> object with default settings.</summary>
        public ServingConfigServiceSettings()
        {
        }

        private ServingConfigServiceSettings(ServingConfigServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateServingConfigSettings = existing.CreateServingConfigSettings;
            DeleteServingConfigSettings = existing.DeleteServingConfigSettings;
            UpdateServingConfigSettings = existing.UpdateServingConfigSettings;
            GetServingConfigSettings = existing.GetServingConfigSettings;
            ListServingConfigsSettings = existing.ListServingConfigsSettings;
            AddControlSettings = existing.AddControlSettings;
            RemoveControlSettings = existing.RemoveControlSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ServingConfigServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServingConfigServiceClient.CreateServingConfig</c> and
        /// <c>ServingConfigServiceClient.CreateServingConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateServingConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServingConfigServiceClient.DeleteServingConfig</c> and
        /// <c>ServingConfigServiceClient.DeleteServingConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteServingConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServingConfigServiceClient.UpdateServingConfig</c> and
        /// <c>ServingConfigServiceClient.UpdateServingConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateServingConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServingConfigServiceClient.GetServingConfig</c> and <c>ServingConfigServiceClient.GetServingConfigAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetServingConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServingConfigServiceClient.ListServingConfigs</c> and
        /// <c>ServingConfigServiceClient.ListServingConfigsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListServingConfigsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServingConfigServiceClient.AddControl</c> and <c>ServingConfigServiceClient.AddControlAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AddControlSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServingConfigServiceClient.RemoveControl</c> and <c>ServingConfigServiceClient.RemoveControlAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RemoveControlSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ServingConfigServiceSettings"/> object.</returns>
        public ServingConfigServiceSettings Clone() => new ServingConfigServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ServingConfigServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class ServingConfigServiceClientBuilder : gaxgrpc::ClientBuilderBase<ServingConfigServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ServingConfigServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ServingConfigServiceClientBuilder() : base(ServingConfigServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ServingConfigServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ServingConfigServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ServingConfigServiceClient Build()
        {
            ServingConfigServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ServingConfigServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ServingConfigServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ServingConfigServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ServingConfigServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ServingConfigServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ServingConfigServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ServingConfigServiceClient.ChannelPool;
    }

    /// <summary>ServingConfigService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for modifying ServingConfig.
    /// </remarks>
    public abstract partial class ServingConfigServiceClient
    {
        /// <summary>
        /// The default endpoint for the ServingConfigService service, which is a host of "retail.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "retail.googleapis.com:443";

        /// <summary>The default ServingConfigService scopes.</summary>
        /// <remarks>
        /// The default ServingConfigService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ServingConfigService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ServingConfigServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ServingConfigServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ServingConfigServiceClient"/>.</returns>
        public static stt::Task<ServingConfigServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ServingConfigServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ServingConfigServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="ServingConfigServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ServingConfigServiceClient"/>.</returns>
        public static ServingConfigServiceClient Create() => new ServingConfigServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ServingConfigServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ServingConfigServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ServingConfigServiceClient"/>.</returns>
        internal static ServingConfigServiceClient Create(grpccore::CallInvoker callInvoker, ServingConfigServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ServingConfigService.ServingConfigServiceClient grpcClient = new ServingConfigService.ServingConfigServiceClient(callInvoker);
            return new ServingConfigServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ServingConfigService client</summary>
        public virtual ServingConfigService.ServingConfigServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a ServingConfig.
        /// 
        /// A maximum of 100 [ServingConfig][google.cloud.retail.v2.ServingConfig]s are
        /// allowed in a [Catalog][google.cloud.retail.v2.Catalog], otherwise a
        /// FAILED_PRECONDITION error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServingConfig CreateServingConfig(CreateServingConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a ServingConfig.
        /// 
        /// A maximum of 100 [ServingConfig][google.cloud.retail.v2.ServingConfig]s are
        /// allowed in a [Catalog][google.cloud.retail.v2.Catalog], otherwise a
        /// FAILED_PRECONDITION error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServingConfig> CreateServingConfigAsync(CreateServingConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a ServingConfig.
        /// 
        /// A maximum of 100 [ServingConfig][google.cloud.retail.v2.ServingConfig]s are
        /// allowed in a [Catalog][google.cloud.retail.v2.Catalog], otherwise a
        /// FAILED_PRECONDITION error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServingConfig> CreateServingConfigAsync(CreateServingConfigRequest request, st::CancellationToken cancellationToken) =>
            CreateServingConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a ServingConfig.
        /// 
        /// A maximum of 100 [ServingConfig][google.cloud.retail.v2.ServingConfig]s are
        /// allowed in a [Catalog][google.cloud.retail.v2.Catalog], otherwise a
        /// FAILED_PRECONDITION error is returned.
        /// </summary>
        /// <param name="parent">
        /// Required. Full resource name of parent. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}`
        /// </param>
        /// <param name="servingConfig">
        /// Required. The ServingConfig to create.
        /// </param>
        /// <param name="servingConfigId">
        /// Required. The ID to use for the ServingConfig, which will become the final
        /// component of the ServingConfig's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServingConfig CreateServingConfig(string parent, ServingConfig servingConfig, string servingConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateServingConfig(new CreateServingConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ServingConfig = gax::GaxPreconditions.CheckNotNull(servingConfig, nameof(servingConfig)),
                ServingConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(servingConfigId, nameof(servingConfigId)),
            }, callSettings);

        /// <summary>
        /// Creates a ServingConfig.
        /// 
        /// A maximum of 100 [ServingConfig][google.cloud.retail.v2.ServingConfig]s are
        /// allowed in a [Catalog][google.cloud.retail.v2.Catalog], otherwise a
        /// FAILED_PRECONDITION error is returned.
        /// </summary>
        /// <param name="parent">
        /// Required. Full resource name of parent. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}`
        /// </param>
        /// <param name="servingConfig">
        /// Required. The ServingConfig to create.
        /// </param>
        /// <param name="servingConfigId">
        /// Required. The ID to use for the ServingConfig, which will become the final
        /// component of the ServingConfig's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServingConfig> CreateServingConfigAsync(string parent, ServingConfig servingConfig, string servingConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateServingConfigAsync(new CreateServingConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ServingConfig = gax::GaxPreconditions.CheckNotNull(servingConfig, nameof(servingConfig)),
                ServingConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(servingConfigId, nameof(servingConfigId)),
            }, callSettings);

        /// <summary>
        /// Creates a ServingConfig.
        /// 
        /// A maximum of 100 [ServingConfig][google.cloud.retail.v2.ServingConfig]s are
        /// allowed in a [Catalog][google.cloud.retail.v2.Catalog], otherwise a
        /// FAILED_PRECONDITION error is returned.
        /// </summary>
        /// <param name="parent">
        /// Required. Full resource name of parent. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}`
        /// </param>
        /// <param name="servingConfig">
        /// Required. The ServingConfig to create.
        /// </param>
        /// <param name="servingConfigId">
        /// Required. The ID to use for the ServingConfig, which will become the final
        /// component of the ServingConfig's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-_/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServingConfig> CreateServingConfigAsync(string parent, ServingConfig servingConfig, string servingConfigId, st::CancellationToken cancellationToken) =>
            CreateServingConfigAsync(parent, servingConfig, servingConfigId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a ServingConfig.
        /// 
        /// A maximum of 100 [ServingConfig][google.cloud.retail.v2.ServingConfig]s are
        /// allowed in a [Catalog][google.cloud.retail.v2.Catalog], otherwise a
        /// FAILED_PRECONDITION error is returned.
        /// </summary>
        /// <param name="parent">
        /// Required. Full resource name of parent. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}`
        /// </param>
        /// <param name="servingConfig">
        /// Required. The ServingConfig to create.
        /// </param>
        /// <param name="servingConfigId">
        /// Required. The ID to use for the ServingConfig, which will become the final
        /// component of the ServingConfig's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServingConfig CreateServingConfig(CatalogName parent, ServingConfig servingConfig, string servingConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateServingConfig(new CreateServingConfigRequest
            {
                ParentAsCatalogName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ServingConfig = gax::GaxPreconditions.CheckNotNull(servingConfig, nameof(servingConfig)),
                ServingConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(servingConfigId, nameof(servingConfigId)),
            }, callSettings);

        /// <summary>
        /// Creates a ServingConfig.
        /// 
        /// A maximum of 100 [ServingConfig][google.cloud.retail.v2.ServingConfig]s are
        /// allowed in a [Catalog][google.cloud.retail.v2.Catalog], otherwise a
        /// FAILED_PRECONDITION error is returned.
        /// </summary>
        /// <param name="parent">
        /// Required. Full resource name of parent. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}`
        /// </param>
        /// <param name="servingConfig">
        /// Required. The ServingConfig to create.
        /// </param>
        /// <param name="servingConfigId">
        /// Required. The ID to use for the ServingConfig, which will become the final
        /// component of the ServingConfig's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServingConfig> CreateServingConfigAsync(CatalogName parent, ServingConfig servingConfig, string servingConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateServingConfigAsync(new CreateServingConfigRequest
            {
                ParentAsCatalogName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ServingConfig = gax::GaxPreconditions.CheckNotNull(servingConfig, nameof(servingConfig)),
                ServingConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(servingConfigId, nameof(servingConfigId)),
            }, callSettings);

        /// <summary>
        /// Creates a ServingConfig.
        /// 
        /// A maximum of 100 [ServingConfig][google.cloud.retail.v2.ServingConfig]s are
        /// allowed in a [Catalog][google.cloud.retail.v2.Catalog], otherwise a
        /// FAILED_PRECONDITION error is returned.
        /// </summary>
        /// <param name="parent">
        /// Required. Full resource name of parent. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}`
        /// </param>
        /// <param name="servingConfig">
        /// Required. The ServingConfig to create.
        /// </param>
        /// <param name="servingConfigId">
        /// Required. The ID to use for the ServingConfig, which will become the final
        /// component of the ServingConfig's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-_/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServingConfig> CreateServingConfigAsync(CatalogName parent, ServingConfig servingConfig, string servingConfigId, st::CancellationToken cancellationToken) =>
            CreateServingConfigAsync(parent, servingConfig, servingConfigId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a ServingConfig.
        /// 
        /// Returns a NotFound error if the ServingConfig does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteServingConfig(DeleteServingConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a ServingConfig.
        /// 
        /// Returns a NotFound error if the ServingConfig does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteServingConfigAsync(DeleteServingConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a ServingConfig.
        /// 
        /// Returns a NotFound error if the ServingConfig does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteServingConfigAsync(DeleteServingConfigRequest request, st::CancellationToken cancellationToken) =>
            DeleteServingConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a ServingConfig.
        /// 
        /// Returns a NotFound error if the ServingConfig does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ServingConfig to delete. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/servingConfigs/{serving_config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteServingConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServingConfig(new DeleteServingConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a ServingConfig.
        /// 
        /// Returns a NotFound error if the ServingConfig does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ServingConfig to delete. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/servingConfigs/{serving_config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteServingConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServingConfigAsync(new DeleteServingConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a ServingConfig.
        /// 
        /// Returns a NotFound error if the ServingConfig does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ServingConfig to delete. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/servingConfigs/{serving_config_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteServingConfigAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteServingConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a ServingConfig.
        /// 
        /// Returns a NotFound error if the ServingConfig does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ServingConfig to delete. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/servingConfigs/{serving_config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteServingConfig(ServingConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServingConfig(new DeleteServingConfigRequest
            {
                ServingConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a ServingConfig.
        /// 
        /// Returns a NotFound error if the ServingConfig does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ServingConfig to delete. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/servingConfigs/{serving_config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteServingConfigAsync(ServingConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServingConfigAsync(new DeleteServingConfigRequest
            {
                ServingConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a ServingConfig.
        /// 
        /// Returns a NotFound error if the ServingConfig does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ServingConfig to delete. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/servingConfigs/{serving_config_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteServingConfigAsync(ServingConfigName name, st::CancellationToken cancellationToken) =>
            DeleteServingConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a ServingConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServingConfig UpdateServingConfig(UpdateServingConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a ServingConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServingConfig> UpdateServingConfigAsync(UpdateServingConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a ServingConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServingConfig> UpdateServingConfigAsync(UpdateServingConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateServingConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a ServingConfig.
        /// </summary>
        /// <param name="servingConfig">
        /// Required. The ServingConfig to update.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided
        /// [ServingConfig][google.cloud.retail.v2.ServingConfig] to update. The
        /// following are NOT supported:
        /// 
        /// * [ServingConfig.name][google.cloud.retail.v2.ServingConfig.name]
        /// 
        /// If not set, all supported fields are updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServingConfig UpdateServingConfig(ServingConfig servingConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateServingConfig(new UpdateServingConfigRequest
            {
                ServingConfig = gax::GaxPreconditions.CheckNotNull(servingConfig, nameof(servingConfig)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a ServingConfig.
        /// </summary>
        /// <param name="servingConfig">
        /// Required. The ServingConfig to update.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided
        /// [ServingConfig][google.cloud.retail.v2.ServingConfig] to update. The
        /// following are NOT supported:
        /// 
        /// * [ServingConfig.name][google.cloud.retail.v2.ServingConfig.name]
        /// 
        /// If not set, all supported fields are updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServingConfig> UpdateServingConfigAsync(ServingConfig servingConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateServingConfigAsync(new UpdateServingConfigRequest
            {
                ServingConfig = gax::GaxPreconditions.CheckNotNull(servingConfig, nameof(servingConfig)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a ServingConfig.
        /// </summary>
        /// <param name="servingConfig">
        /// Required. The ServingConfig to update.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided
        /// [ServingConfig][google.cloud.retail.v2.ServingConfig] to update. The
        /// following are NOT supported:
        /// 
        /// * [ServingConfig.name][google.cloud.retail.v2.ServingConfig.name]
        /// 
        /// If not set, all supported fields are updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServingConfig> UpdateServingConfigAsync(ServingConfig servingConfig, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateServingConfigAsync(servingConfig, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a ServingConfig.
        /// 
        /// Returns a NotFound error if the ServingConfig does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServingConfig GetServingConfig(GetServingConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a ServingConfig.
        /// 
        /// Returns a NotFound error if the ServingConfig does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServingConfig> GetServingConfigAsync(GetServingConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a ServingConfig.
        /// 
        /// Returns a NotFound error if the ServingConfig does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServingConfig> GetServingConfigAsync(GetServingConfigRequest request, st::CancellationToken cancellationToken) =>
            GetServingConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a ServingConfig.
        /// 
        /// Returns a NotFound error if the ServingConfig does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ServingConfig to get. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/servingConfigs/{serving_config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServingConfig GetServingConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetServingConfig(new GetServingConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a ServingConfig.
        /// 
        /// Returns a NotFound error if the ServingConfig does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ServingConfig to get. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/servingConfigs/{serving_config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServingConfig> GetServingConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetServingConfigAsync(new GetServingConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a ServingConfig.
        /// 
        /// Returns a NotFound error if the ServingConfig does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ServingConfig to get. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/servingConfigs/{serving_config_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServingConfig> GetServingConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetServingConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a ServingConfig.
        /// 
        /// Returns a NotFound error if the ServingConfig does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ServingConfig to get. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/servingConfigs/{serving_config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServingConfig GetServingConfig(ServingConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetServingConfig(new GetServingConfigRequest
            {
                ServingConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a ServingConfig.
        /// 
        /// Returns a NotFound error if the ServingConfig does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ServingConfig to get. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/servingConfigs/{serving_config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServingConfig> GetServingConfigAsync(ServingConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetServingConfigAsync(new GetServingConfigRequest
            {
                ServingConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a ServingConfig.
        /// 
        /// Returns a NotFound error if the ServingConfig does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ServingConfig to get. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/servingConfigs/{serving_config_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServingConfig> GetServingConfigAsync(ServingConfigName name, st::CancellationToken cancellationToken) =>
            GetServingConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all ServingConfigs linked to this catalog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ServingConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServingConfigsResponse, ServingConfig> ListServingConfigs(ListServingConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all ServingConfigs linked to this catalog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ServingConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServingConfigsResponse, ServingConfig> ListServingConfigsAsync(ListServingConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all ServingConfigs linked to this catalog.
        /// </summary>
        /// <param name="parent">
        /// Required. The catalog resource name. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}`
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
        /// <returns>A pageable sequence of <see cref="ServingConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServingConfigsResponse, ServingConfig> ListServingConfigs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServingConfigsRequest request = new ListServingConfigsRequest
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
            return ListServingConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists all ServingConfigs linked to this catalog.
        /// </summary>
        /// <param name="parent">
        /// Required. The catalog resource name. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ServingConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServingConfigsResponse, ServingConfig> ListServingConfigsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServingConfigsRequest request = new ListServingConfigsRequest
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
            return ListServingConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all ServingConfigs linked to this catalog.
        /// </summary>
        /// <param name="parent">
        /// Required. The catalog resource name. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}`
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
        /// <returns>A pageable sequence of <see cref="ServingConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServingConfigsResponse, ServingConfig> ListServingConfigs(CatalogName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServingConfigsRequest request = new ListServingConfigsRequest
            {
                ParentAsCatalogName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListServingConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists all ServingConfigs linked to this catalog.
        /// </summary>
        /// <param name="parent">
        /// Required. The catalog resource name. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ServingConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServingConfigsResponse, ServingConfig> ListServingConfigsAsync(CatalogName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServingConfigsRequest request = new ListServingConfigsRequest
            {
                ParentAsCatalogName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListServingConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Enables a Control on the specified ServingConfig.
        /// The control is added in the last position of the list of controls
        /// it belongs to (e.g. if it's a facet spec control it will be applied
        /// in the last position of servingConfig.facetSpecIds)
        /// Returns a ALREADY_EXISTS error if the control has already been applied.
        /// Returns a FAILED_PRECONDITION error if the addition could exceed maximum
        /// number of control allowed for that type of control.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServingConfig AddControl(AddControlRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enables a Control on the specified ServingConfig.
        /// The control is added in the last position of the list of controls
        /// it belongs to (e.g. if it's a facet spec control it will be applied
        /// in the last position of servingConfig.facetSpecIds)
        /// Returns a ALREADY_EXISTS error if the control has already been applied.
        /// Returns a FAILED_PRECONDITION error if the addition could exceed maximum
        /// number of control allowed for that type of control.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServingConfig> AddControlAsync(AddControlRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enables a Control on the specified ServingConfig.
        /// The control is added in the last position of the list of controls
        /// it belongs to (e.g. if it's a facet spec control it will be applied
        /// in the last position of servingConfig.facetSpecIds)
        /// Returns a ALREADY_EXISTS error if the control has already been applied.
        /// Returns a FAILED_PRECONDITION error if the addition could exceed maximum
        /// number of control allowed for that type of control.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServingConfig> AddControlAsync(AddControlRequest request, st::CancellationToken cancellationToken) =>
            AddControlAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Enables a Control on the specified ServingConfig.
        /// The control is added in the last position of the list of controls
        /// it belongs to (e.g. if it's a facet spec control it will be applied
        /// in the last position of servingConfig.facetSpecIds)
        /// Returns a ALREADY_EXISTS error if the control has already been applied.
        /// Returns a FAILED_PRECONDITION error if the addition could exceed maximum
        /// number of control allowed for that type of control.
        /// </summary>
        /// <param name="servingConfig">
        /// Required. The source ServingConfig resource name . Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/servingConfigs/{serving_config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServingConfig AddControl(string servingConfig, gaxgrpc::CallSettings callSettings = null) =>
            AddControl(new AddControlRequest
            {
                ServingConfig = gax::GaxPreconditions.CheckNotNullOrEmpty(servingConfig, nameof(servingConfig)),
            }, callSettings);

        /// <summary>
        /// Enables a Control on the specified ServingConfig.
        /// The control is added in the last position of the list of controls
        /// it belongs to (e.g. if it's a facet spec control it will be applied
        /// in the last position of servingConfig.facetSpecIds)
        /// Returns a ALREADY_EXISTS error if the control has already been applied.
        /// Returns a FAILED_PRECONDITION error if the addition could exceed maximum
        /// number of control allowed for that type of control.
        /// </summary>
        /// <param name="servingConfig">
        /// Required. The source ServingConfig resource name . Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/servingConfigs/{serving_config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServingConfig> AddControlAsync(string servingConfig, gaxgrpc::CallSettings callSettings = null) =>
            AddControlAsync(new AddControlRequest
            {
                ServingConfig = gax::GaxPreconditions.CheckNotNullOrEmpty(servingConfig, nameof(servingConfig)),
            }, callSettings);

        /// <summary>
        /// Enables a Control on the specified ServingConfig.
        /// The control is added in the last position of the list of controls
        /// it belongs to (e.g. if it's a facet spec control it will be applied
        /// in the last position of servingConfig.facetSpecIds)
        /// Returns a ALREADY_EXISTS error if the control has already been applied.
        /// Returns a FAILED_PRECONDITION error if the addition could exceed maximum
        /// number of control allowed for that type of control.
        /// </summary>
        /// <param name="servingConfig">
        /// Required. The source ServingConfig resource name . Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/servingConfigs/{serving_config_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServingConfig> AddControlAsync(string servingConfig, st::CancellationToken cancellationToken) =>
            AddControlAsync(servingConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Enables a Control on the specified ServingConfig.
        /// The control is added in the last position of the list of controls
        /// it belongs to (e.g. if it's a facet spec control it will be applied
        /// in the last position of servingConfig.facetSpecIds)
        /// Returns a ALREADY_EXISTS error if the control has already been applied.
        /// Returns a FAILED_PRECONDITION error if the addition could exceed maximum
        /// number of control allowed for that type of control.
        /// </summary>
        /// <param name="servingConfig">
        /// Required. The source ServingConfig resource name . Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/servingConfigs/{serving_config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServingConfig AddControl(ServingConfigName servingConfig, gaxgrpc::CallSettings callSettings = null) =>
            AddControl(new AddControlRequest
            {
                ServingConfigAsServingConfigName = gax::GaxPreconditions.CheckNotNull(servingConfig, nameof(servingConfig)),
            }, callSettings);

        /// <summary>
        /// Enables a Control on the specified ServingConfig.
        /// The control is added in the last position of the list of controls
        /// it belongs to (e.g. if it's a facet spec control it will be applied
        /// in the last position of servingConfig.facetSpecIds)
        /// Returns a ALREADY_EXISTS error if the control has already been applied.
        /// Returns a FAILED_PRECONDITION error if the addition could exceed maximum
        /// number of control allowed for that type of control.
        /// </summary>
        /// <param name="servingConfig">
        /// Required. The source ServingConfig resource name . Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/servingConfigs/{serving_config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServingConfig> AddControlAsync(ServingConfigName servingConfig, gaxgrpc::CallSettings callSettings = null) =>
            AddControlAsync(new AddControlRequest
            {
                ServingConfigAsServingConfigName = gax::GaxPreconditions.CheckNotNull(servingConfig, nameof(servingConfig)),
            }, callSettings);

        /// <summary>
        /// Enables a Control on the specified ServingConfig.
        /// The control is added in the last position of the list of controls
        /// it belongs to (e.g. if it's a facet spec control it will be applied
        /// in the last position of servingConfig.facetSpecIds)
        /// Returns a ALREADY_EXISTS error if the control has already been applied.
        /// Returns a FAILED_PRECONDITION error if the addition could exceed maximum
        /// number of control allowed for that type of control.
        /// </summary>
        /// <param name="servingConfig">
        /// Required. The source ServingConfig resource name . Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/servingConfigs/{serving_config_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServingConfig> AddControlAsync(ServingConfigName servingConfig, st::CancellationToken cancellationToken) =>
            AddControlAsync(servingConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Disables a Control on the specified ServingConfig.
        /// The control is removed from the ServingConfig.
        /// Returns a NOT_FOUND error if the Control is not enabled for the
        /// ServingConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServingConfig RemoveControl(RemoveControlRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Disables a Control on the specified ServingConfig.
        /// The control is removed from the ServingConfig.
        /// Returns a NOT_FOUND error if the Control is not enabled for the
        /// ServingConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServingConfig> RemoveControlAsync(RemoveControlRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Disables a Control on the specified ServingConfig.
        /// The control is removed from the ServingConfig.
        /// Returns a NOT_FOUND error if the Control is not enabled for the
        /// ServingConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServingConfig> RemoveControlAsync(RemoveControlRequest request, st::CancellationToken cancellationToken) =>
            RemoveControlAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Disables a Control on the specified ServingConfig.
        /// The control is removed from the ServingConfig.
        /// Returns a NOT_FOUND error if the Control is not enabled for the
        /// ServingConfig.
        /// </summary>
        /// <param name="servingConfig">
        /// Required. The source ServingConfig resource name . Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/servingConfigs/{serving_config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServingConfig RemoveControl(string servingConfig, gaxgrpc::CallSettings callSettings = null) =>
            RemoveControl(new RemoveControlRequest
            {
                ServingConfig = gax::GaxPreconditions.CheckNotNullOrEmpty(servingConfig, nameof(servingConfig)),
            }, callSettings);

        /// <summary>
        /// Disables a Control on the specified ServingConfig.
        /// The control is removed from the ServingConfig.
        /// Returns a NOT_FOUND error if the Control is not enabled for the
        /// ServingConfig.
        /// </summary>
        /// <param name="servingConfig">
        /// Required. The source ServingConfig resource name . Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/servingConfigs/{serving_config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServingConfig> RemoveControlAsync(string servingConfig, gaxgrpc::CallSettings callSettings = null) =>
            RemoveControlAsync(new RemoveControlRequest
            {
                ServingConfig = gax::GaxPreconditions.CheckNotNullOrEmpty(servingConfig, nameof(servingConfig)),
            }, callSettings);

        /// <summary>
        /// Disables a Control on the specified ServingConfig.
        /// The control is removed from the ServingConfig.
        /// Returns a NOT_FOUND error if the Control is not enabled for the
        /// ServingConfig.
        /// </summary>
        /// <param name="servingConfig">
        /// Required. The source ServingConfig resource name . Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/servingConfigs/{serving_config_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServingConfig> RemoveControlAsync(string servingConfig, st::CancellationToken cancellationToken) =>
            RemoveControlAsync(servingConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Disables a Control on the specified ServingConfig.
        /// The control is removed from the ServingConfig.
        /// Returns a NOT_FOUND error if the Control is not enabled for the
        /// ServingConfig.
        /// </summary>
        /// <param name="servingConfig">
        /// Required. The source ServingConfig resource name . Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/servingConfigs/{serving_config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServingConfig RemoveControl(ServingConfigName servingConfig, gaxgrpc::CallSettings callSettings = null) =>
            RemoveControl(new RemoveControlRequest
            {
                ServingConfigAsServingConfigName = gax::GaxPreconditions.CheckNotNull(servingConfig, nameof(servingConfig)),
            }, callSettings);

        /// <summary>
        /// Disables a Control on the specified ServingConfig.
        /// The control is removed from the ServingConfig.
        /// Returns a NOT_FOUND error if the Control is not enabled for the
        /// ServingConfig.
        /// </summary>
        /// <param name="servingConfig">
        /// Required. The source ServingConfig resource name . Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/servingConfigs/{serving_config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServingConfig> RemoveControlAsync(ServingConfigName servingConfig, gaxgrpc::CallSettings callSettings = null) =>
            RemoveControlAsync(new RemoveControlRequest
            {
                ServingConfigAsServingConfigName = gax::GaxPreconditions.CheckNotNull(servingConfig, nameof(servingConfig)),
            }, callSettings);

        /// <summary>
        /// Disables a Control on the specified ServingConfig.
        /// The control is removed from the ServingConfig.
        /// Returns a NOT_FOUND error if the Control is not enabled for the
        /// ServingConfig.
        /// </summary>
        /// <param name="servingConfig">
        /// Required. The source ServingConfig resource name . Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/servingConfigs/{serving_config_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServingConfig> RemoveControlAsync(ServingConfigName servingConfig, st::CancellationToken cancellationToken) =>
            RemoveControlAsync(servingConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ServingConfigService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for modifying ServingConfig.
    /// </remarks>
    public sealed partial class ServingConfigServiceClientImpl : ServingConfigServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateServingConfigRequest, ServingConfig> _callCreateServingConfig;

        private readonly gaxgrpc::ApiCall<DeleteServingConfigRequest, wkt::Empty> _callDeleteServingConfig;

        private readonly gaxgrpc::ApiCall<UpdateServingConfigRequest, ServingConfig> _callUpdateServingConfig;

        private readonly gaxgrpc::ApiCall<GetServingConfigRequest, ServingConfig> _callGetServingConfig;

        private readonly gaxgrpc::ApiCall<ListServingConfigsRequest, ListServingConfigsResponse> _callListServingConfigs;

        private readonly gaxgrpc::ApiCall<AddControlRequest, ServingConfig> _callAddControl;

        private readonly gaxgrpc::ApiCall<RemoveControlRequest, ServingConfig> _callRemoveControl;

        /// <summary>
        /// Constructs a client wrapper for the ServingConfigService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ServingConfigServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ServingConfigServiceClientImpl(ServingConfigService.ServingConfigServiceClient grpcClient, ServingConfigServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ServingConfigServiceSettings effectiveSettings = settings ?? ServingConfigServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCreateServingConfig = clientHelper.BuildApiCall<CreateServingConfigRequest, ServingConfig>("CreateServingConfig", grpcClient.CreateServingConfigAsync, grpcClient.CreateServingConfig, effectiveSettings.CreateServingConfigSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateServingConfig);
            Modify_CreateServingConfigApiCall(ref _callCreateServingConfig);
            _callDeleteServingConfig = clientHelper.BuildApiCall<DeleteServingConfigRequest, wkt::Empty>("DeleteServingConfig", grpcClient.DeleteServingConfigAsync, grpcClient.DeleteServingConfig, effectiveSettings.DeleteServingConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteServingConfig);
            Modify_DeleteServingConfigApiCall(ref _callDeleteServingConfig);
            _callUpdateServingConfig = clientHelper.BuildApiCall<UpdateServingConfigRequest, ServingConfig>("UpdateServingConfig", grpcClient.UpdateServingConfigAsync, grpcClient.UpdateServingConfig, effectiveSettings.UpdateServingConfigSettings).WithGoogleRequestParam("serving_config.name", request => request.ServingConfig?.Name);
            Modify_ApiCall(ref _callUpdateServingConfig);
            Modify_UpdateServingConfigApiCall(ref _callUpdateServingConfig);
            _callGetServingConfig = clientHelper.BuildApiCall<GetServingConfigRequest, ServingConfig>("GetServingConfig", grpcClient.GetServingConfigAsync, grpcClient.GetServingConfig, effectiveSettings.GetServingConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetServingConfig);
            Modify_GetServingConfigApiCall(ref _callGetServingConfig);
            _callListServingConfigs = clientHelper.BuildApiCall<ListServingConfigsRequest, ListServingConfigsResponse>("ListServingConfigs", grpcClient.ListServingConfigsAsync, grpcClient.ListServingConfigs, effectiveSettings.ListServingConfigsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListServingConfigs);
            Modify_ListServingConfigsApiCall(ref _callListServingConfigs);
            _callAddControl = clientHelper.BuildApiCall<AddControlRequest, ServingConfig>("AddControl", grpcClient.AddControlAsync, grpcClient.AddControl, effectiveSettings.AddControlSettings).WithGoogleRequestParam("serving_config", request => request.ServingConfig);
            Modify_ApiCall(ref _callAddControl);
            Modify_AddControlApiCall(ref _callAddControl);
            _callRemoveControl = clientHelper.BuildApiCall<RemoveControlRequest, ServingConfig>("RemoveControl", grpcClient.RemoveControlAsync, grpcClient.RemoveControl, effectiveSettings.RemoveControlSettings).WithGoogleRequestParam("serving_config", request => request.ServingConfig);
            Modify_ApiCall(ref _callRemoveControl);
            Modify_RemoveControlApiCall(ref _callRemoveControl);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateServingConfigApiCall(ref gaxgrpc::ApiCall<CreateServingConfigRequest, ServingConfig> call);

        partial void Modify_DeleteServingConfigApiCall(ref gaxgrpc::ApiCall<DeleteServingConfigRequest, wkt::Empty> call);

        partial void Modify_UpdateServingConfigApiCall(ref gaxgrpc::ApiCall<UpdateServingConfigRequest, ServingConfig> call);

        partial void Modify_GetServingConfigApiCall(ref gaxgrpc::ApiCall<GetServingConfigRequest, ServingConfig> call);

        partial void Modify_ListServingConfigsApiCall(ref gaxgrpc::ApiCall<ListServingConfigsRequest, ListServingConfigsResponse> call);

        partial void Modify_AddControlApiCall(ref gaxgrpc::ApiCall<AddControlRequest, ServingConfig> call);

        partial void Modify_RemoveControlApiCall(ref gaxgrpc::ApiCall<RemoveControlRequest, ServingConfig> call);

        partial void OnConstruction(ServingConfigService.ServingConfigServiceClient grpcClient, ServingConfigServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ServingConfigService client</summary>
        public override ServingConfigService.ServingConfigServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CreateServingConfigRequest(ref CreateServingConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteServingConfigRequest(ref DeleteServingConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateServingConfigRequest(ref UpdateServingConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetServingConfigRequest(ref GetServingConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListServingConfigsRequest(ref ListServingConfigsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AddControlRequest(ref AddControlRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RemoveControlRequest(ref RemoveControlRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a ServingConfig.
        /// 
        /// A maximum of 100 [ServingConfig][google.cloud.retail.v2.ServingConfig]s are
        /// allowed in a [Catalog][google.cloud.retail.v2.Catalog], otherwise a
        /// FAILED_PRECONDITION error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ServingConfig CreateServingConfig(CreateServingConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServingConfigRequest(ref request, ref callSettings);
            return _callCreateServingConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a ServingConfig.
        /// 
        /// A maximum of 100 [ServingConfig][google.cloud.retail.v2.ServingConfig]s are
        /// allowed in a [Catalog][google.cloud.retail.v2.Catalog], otherwise a
        /// FAILED_PRECONDITION error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ServingConfig> CreateServingConfigAsync(CreateServingConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServingConfigRequest(ref request, ref callSettings);
            return _callCreateServingConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a ServingConfig.
        /// 
        /// Returns a NotFound error if the ServingConfig does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteServingConfig(DeleteServingConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServingConfigRequest(ref request, ref callSettings);
            _callDeleteServingConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a ServingConfig.
        /// 
        /// Returns a NotFound error if the ServingConfig does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteServingConfigAsync(DeleteServingConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServingConfigRequest(ref request, ref callSettings);
            return _callDeleteServingConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a ServingConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ServingConfig UpdateServingConfig(UpdateServingConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateServingConfigRequest(ref request, ref callSettings);
            return _callUpdateServingConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a ServingConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ServingConfig> UpdateServingConfigAsync(UpdateServingConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateServingConfigRequest(ref request, ref callSettings);
            return _callUpdateServingConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a ServingConfig.
        /// 
        /// Returns a NotFound error if the ServingConfig does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ServingConfig GetServingConfig(GetServingConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServingConfigRequest(ref request, ref callSettings);
            return _callGetServingConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a ServingConfig.
        /// 
        /// Returns a NotFound error if the ServingConfig does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ServingConfig> GetServingConfigAsync(GetServingConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServingConfigRequest(ref request, ref callSettings);
            return _callGetServingConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all ServingConfigs linked to this catalog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ServingConfig"/> resources.</returns>
        public override gax::PagedEnumerable<ListServingConfigsResponse, ServingConfig> ListServingConfigs(ListServingConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServingConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListServingConfigsRequest, ListServingConfigsResponse, ServingConfig>(_callListServingConfigs, request, callSettings);
        }

        /// <summary>
        /// Lists all ServingConfigs linked to this catalog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ServingConfig"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListServingConfigsResponse, ServingConfig> ListServingConfigsAsync(ListServingConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServingConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListServingConfigsRequest, ListServingConfigsResponse, ServingConfig>(_callListServingConfigs, request, callSettings);
        }

        /// <summary>
        /// Enables a Control on the specified ServingConfig.
        /// The control is added in the last position of the list of controls
        /// it belongs to (e.g. if it's a facet spec control it will be applied
        /// in the last position of servingConfig.facetSpecIds)
        /// Returns a ALREADY_EXISTS error if the control has already been applied.
        /// Returns a FAILED_PRECONDITION error if the addition could exceed maximum
        /// number of control allowed for that type of control.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ServingConfig AddControl(AddControlRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddControlRequest(ref request, ref callSettings);
            return _callAddControl.Sync(request, callSettings);
        }

        /// <summary>
        /// Enables a Control on the specified ServingConfig.
        /// The control is added in the last position of the list of controls
        /// it belongs to (e.g. if it's a facet spec control it will be applied
        /// in the last position of servingConfig.facetSpecIds)
        /// Returns a ALREADY_EXISTS error if the control has already been applied.
        /// Returns a FAILED_PRECONDITION error if the addition could exceed maximum
        /// number of control allowed for that type of control.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ServingConfig> AddControlAsync(AddControlRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddControlRequest(ref request, ref callSettings);
            return _callAddControl.Async(request, callSettings);
        }

        /// <summary>
        /// Disables a Control on the specified ServingConfig.
        /// The control is removed from the ServingConfig.
        /// Returns a NOT_FOUND error if the Control is not enabled for the
        /// ServingConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ServingConfig RemoveControl(RemoveControlRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveControlRequest(ref request, ref callSettings);
            return _callRemoveControl.Sync(request, callSettings);
        }

        /// <summary>
        /// Disables a Control on the specified ServingConfig.
        /// The control is removed from the ServingConfig.
        /// Returns a NOT_FOUND error if the Control is not enabled for the
        /// ServingConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ServingConfig> RemoveControlAsync(RemoveControlRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveControlRequest(ref request, ref callSettings);
            return _callRemoveControl.Async(request, callSettings);
        }
    }

    public partial class ListServingConfigsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListServingConfigsResponse : gaxgrpc::IPageResponse<ServingConfig>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ServingConfig> GetEnumerator() => ServingConfigs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ServingConfigService
    {
        public partial class ServingConfigServiceClient
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
