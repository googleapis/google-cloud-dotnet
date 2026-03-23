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
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.DataCatalog.Lineage.ConfigManagement.V1
{
    /// <summary>Settings for <see cref="ConfigManagementServiceClient"/> instances.</summary>
    public sealed partial class ConfigManagementServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ConfigManagementServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ConfigManagementServiceSettings"/>.</returns>
        public static ConfigManagementServiceSettings GetDefault() => new ConfigManagementServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ConfigManagementServiceSettings"/> object with default settings.
        /// </summary>
        public ConfigManagementServiceSettings()
        {
        }

        private ConfigManagementServiceSettings(ConfigManagementServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetConfigSettings = existing.GetConfigSettings;
            UpdateConfigSettings = existing.UpdateConfigSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ConfigManagementServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigManagementServiceClient.GetConfig</c> and <c>ConfigManagementServiceClient.GetConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigManagementServiceClient.UpdateConfig</c> and <c>ConfigManagementServiceClient.UpdateConfigAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ConfigManagementServiceSettings"/> object.</returns>
        public ConfigManagementServiceSettings Clone() => new ConfigManagementServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ConfigManagementServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class ConfigManagementServiceClientBuilder : gaxgrpc::ClientBuilderBase<ConfigManagementServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ConfigManagementServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ConfigManagementServiceClientBuilder() : base(ConfigManagementServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ConfigManagementServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ConfigManagementServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ConfigManagementServiceClient Build()
        {
            ConfigManagementServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ConfigManagementServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ConfigManagementServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ConfigManagementServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ConfigManagementServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ConfigManagementServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ConfigManagementServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ConfigManagementServiceClient.ChannelPool;
    }

    /// <summary>ConfigManagementService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Lineage Config Management service. Config Management service is used to
    /// manage the configuration for Data Lineage. These Configs define different
    /// configuration options for Lineage customers to control behaviour of lineage
    /// systems.
    /// </remarks>
    public abstract partial class ConfigManagementServiceClient
    {
        /// <summary>
        /// The default endpoint for the ConfigManagementService service, which is a host of
        /// "datalineage.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "datalineage.googleapis.com:443";

        /// <summary>The default ConfigManagementService scopes.</summary>
        /// <remarks>
        /// The default ConfigManagementService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ConfigManagementService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ConfigManagementServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ConfigManagementServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ConfigManagementServiceClient"/>.</returns>
        public static stt::Task<ConfigManagementServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ConfigManagementServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ConfigManagementServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ConfigManagementServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ConfigManagementServiceClient"/>.</returns>
        public static ConfigManagementServiceClient Create() => new ConfigManagementServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ConfigManagementServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ConfigManagementServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ConfigManagementServiceClient"/>.</returns>
        internal static ConfigManagementServiceClient Create(grpccore::CallInvoker callInvoker, ConfigManagementServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ConfigManagementService.ConfigManagementServiceClient grpcClient = new ConfigManagementService.ConfigManagementServiceClient(callInvoker);
            return new ConfigManagementServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ConfigManagementService client</summary>
        public virtual ConfigManagementService.ConfigManagementServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Get the Config for a given resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Config GetConfig(GetConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get the Config for a given resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Config> GetConfigAsync(GetConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get the Config for a given resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Config> GetConfigAsync(GetConfigRequest request, st::CancellationToken cancellationToken) =>
            GetConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the Config for a given resource.
        /// </summary>
        /// <param name="name">
        /// Required. REQUIRED: The resource name of the config to be fetched.
        /// Format:
        /// `organizations/{organization_id}/locations/global/config`
        /// `folders/{folder_id}/locations/global/config`
        /// `projects/{project_id}/locations/global/config`
        /// `projects/{project_number}/locations/global/config`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Config GetConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConfig(new GetConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the Config for a given resource.
        /// </summary>
        /// <param name="name">
        /// Required. REQUIRED: The resource name of the config to be fetched.
        /// Format:
        /// `organizations/{organization_id}/locations/global/config`
        /// `folders/{folder_id}/locations/global/config`
        /// `projects/{project_id}/locations/global/config`
        /// `projects/{project_number}/locations/global/config`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Config> GetConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConfigAsync(new GetConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the Config for a given resource.
        /// </summary>
        /// <param name="name">
        /// Required. REQUIRED: The resource name of the config to be fetched.
        /// Format:
        /// `organizations/{organization_id}/locations/global/config`
        /// `folders/{folder_id}/locations/global/config`
        /// `projects/{project_id}/locations/global/config`
        /// `projects/{project_number}/locations/global/config`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Config> GetConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the Config for a given resource.
        /// </summary>
        /// <param name="name">
        /// Required. REQUIRED: The resource name of the config to be fetched.
        /// Format:
        /// `organizations/{organization_id}/locations/global/config`
        /// `folders/{folder_id}/locations/global/config`
        /// `projects/{project_id}/locations/global/config`
        /// `projects/{project_number}/locations/global/config`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Config GetConfig(ConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConfig(new GetConfigRequest
            {
                ConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the Config for a given resource.
        /// </summary>
        /// <param name="name">
        /// Required. REQUIRED: The resource name of the config to be fetched.
        /// Format:
        /// `organizations/{organization_id}/locations/global/config`
        /// `folders/{folder_id}/locations/global/config`
        /// `projects/{project_id}/locations/global/config`
        /// `projects/{project_number}/locations/global/config`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Config> GetConfigAsync(ConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConfigAsync(new GetConfigRequest
            {
                ConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the Config for a given resource.
        /// </summary>
        /// <param name="name">
        /// Required. REQUIRED: The resource name of the config to be fetched.
        /// Format:
        /// `organizations/{organization_id}/locations/global/config`
        /// `folders/{folder_id}/locations/global/config`
        /// `projects/{project_id}/locations/global/config`
        /// `projects/{project_number}/locations/global/config`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Config> GetConfigAsync(ConfigName name, st::CancellationToken cancellationToken) =>
            GetConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update the Config for a given resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Config UpdateConfig(UpdateConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update the Config for a given resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Config> UpdateConfigAsync(UpdateConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update the Config for a given resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Config> UpdateConfigAsync(UpdateConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update the Config for a given resource.
        /// </summary>
        /// <param name="config">
        /// Required. REQUIRED: The config to be applied to the resource and all its
        /// descendants.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Config UpdateConfig(Config config, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConfig(new UpdateConfigRequest
            {
                Config = gax::GaxPreconditions.CheckNotNull(config, nameof(config)),
            }, callSettings);

        /// <summary>
        /// Update the Config for a given resource.
        /// </summary>
        /// <param name="config">
        /// Required. REQUIRED: The config to be applied to the resource and all its
        /// descendants.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Config> UpdateConfigAsync(Config config, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConfigAsync(new UpdateConfigRequest
            {
                Config = gax::GaxPreconditions.CheckNotNull(config, nameof(config)),
            }, callSettings);

        /// <summary>
        /// Update the Config for a given resource.
        /// </summary>
        /// <param name="config">
        /// Required. REQUIRED: The config to be applied to the resource and all its
        /// descendants.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Config> UpdateConfigAsync(Config config, st::CancellationToken cancellationToken) =>
            UpdateConfigAsync(config, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ConfigManagementService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Lineage Config Management service. Config Management service is used to
    /// manage the configuration for Data Lineage. These Configs define different
    /// configuration options for Lineage customers to control behaviour of lineage
    /// systems.
    /// </remarks>
    public sealed partial class ConfigManagementServiceClientImpl : ConfigManagementServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetConfigRequest, Config> _callGetConfig;

        private readonly gaxgrpc::ApiCall<UpdateConfigRequest, Config> _callUpdateConfig;

        /// <summary>
        /// Constructs a client wrapper for the ConfigManagementService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="ConfigManagementServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ConfigManagementServiceClientImpl(ConfigManagementService.ConfigManagementServiceClient grpcClient, ConfigManagementServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ConfigManagementServiceSettings effectiveSettings = settings ?? ConfigManagementServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetConfig = clientHelper.BuildApiCall<GetConfigRequest, Config>("GetConfig", grpcClient.GetConfigAsync, grpcClient.GetConfig, effectiveSettings.GetConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetConfig);
            Modify_GetConfigApiCall(ref _callGetConfig);
            _callUpdateConfig = clientHelper.BuildApiCall<UpdateConfigRequest, Config>("UpdateConfig", grpcClient.UpdateConfigAsync, grpcClient.UpdateConfig, effectiveSettings.UpdateConfigSettings).WithGoogleRequestParam("config.name", request => request.Config?.Name);
            Modify_ApiCall(ref _callUpdateConfig);
            Modify_UpdateConfigApiCall(ref _callUpdateConfig);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetConfigApiCall(ref gaxgrpc::ApiCall<GetConfigRequest, Config> call);

        partial void Modify_UpdateConfigApiCall(ref gaxgrpc::ApiCall<UpdateConfigRequest, Config> call);

        partial void OnConstruction(ConfigManagementService.ConfigManagementServiceClient grpcClient, ConfigManagementServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ConfigManagementService client</summary>
        public override ConfigManagementService.ConfigManagementServiceClient GrpcClient { get; }

        partial void Modify_GetConfigRequest(ref GetConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateConfigRequest(ref UpdateConfigRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Get the Config for a given resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Config GetConfig(GetConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConfigRequest(ref request, ref callSettings);
            return _callGetConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Get the Config for a given resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Config> GetConfigAsync(GetConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConfigRequest(ref request, ref callSettings);
            return _callGetConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Update the Config for a given resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Config UpdateConfig(UpdateConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConfigRequest(ref request, ref callSettings);
            return _callUpdateConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Update the Config for a given resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Config> UpdateConfigAsync(UpdateConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConfigRequest(ref request, ref callSettings);
            return _callUpdateConfig.Async(request, callSettings);
        }
    }
}
