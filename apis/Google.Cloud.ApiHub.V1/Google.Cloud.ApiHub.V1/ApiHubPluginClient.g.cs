// Copyright 2024 Google LLC
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

namespace Google.Cloud.ApiHub.V1
{
    /// <summary>Settings for <see cref="ApiHubPluginClient"/> instances.</summary>
    public sealed partial class ApiHubPluginSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ApiHubPluginSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ApiHubPluginSettings"/>.</returns>
        public static ApiHubPluginSettings GetDefault() => new ApiHubPluginSettings();

        /// <summary>Constructs a new <see cref="ApiHubPluginSettings"/> object with default settings.</summary>
        public ApiHubPluginSettings()
        {
        }

        private ApiHubPluginSettings(ApiHubPluginSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetPluginSettings = existing.GetPluginSettings;
            EnablePluginSettings = existing.EnablePluginSettings;
            DisablePluginSettings = existing.DisablePluginSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ApiHubPluginSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiHubPluginClient.GetPlugin</c> and <c>ApiHubPluginClient.GetPluginAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetPluginSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiHubPluginClient.EnablePlugin</c> and <c>ApiHubPluginClient.EnablePluginAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings EnablePluginSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiHubPluginClient.DisablePlugin</c> and <c>ApiHubPluginClient.DisablePluginAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DisablePluginSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ApiHubPluginSettings"/> object.</returns>
        public ApiHubPluginSettings Clone() => new ApiHubPluginSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ApiHubPluginClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class ApiHubPluginClientBuilder : gaxgrpc::ClientBuilderBase<ApiHubPluginClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ApiHubPluginSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ApiHubPluginClientBuilder() : base(ApiHubPluginClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ApiHubPluginClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ApiHubPluginClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ApiHubPluginClient Build()
        {
            ApiHubPluginClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ApiHubPluginClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ApiHubPluginClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ApiHubPluginClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ApiHubPluginClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ApiHubPluginClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ApiHubPluginClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ApiHubPluginClient.ChannelPool;
    }

    /// <summary>ApiHubPlugin client wrapper, for convenient use.</summary>
    /// <remarks>
    /// This service is used for managing plugins inside the API Hub.
    /// </remarks>
    public abstract partial class ApiHubPluginClient
    {
        /// <summary>
        /// The default endpoint for the ApiHubPlugin service, which is a host of "apihub.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "apihub.googleapis.com:443";

        /// <summary>The default ApiHubPlugin scopes.</summary>
        /// <remarks>
        /// The default ApiHubPlugin scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ApiHubPlugin.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ApiHubPluginClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ApiHubPluginClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ApiHubPluginClient"/>.</returns>
        public static stt::Task<ApiHubPluginClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ApiHubPluginClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ApiHubPluginClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ApiHubPluginClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ApiHubPluginClient"/>.</returns>
        public static ApiHubPluginClient Create() => new ApiHubPluginClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ApiHubPluginClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ApiHubPluginSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ApiHubPluginClient"/>.</returns>
        internal static ApiHubPluginClient Create(grpccore::CallInvoker callInvoker, ApiHubPluginSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ApiHubPlugin.ApiHubPluginClient grpcClient = new ApiHubPlugin.ApiHubPluginClient(callInvoker);
            return new ApiHubPluginClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ApiHubPlugin client</summary>
        public virtual ApiHubPlugin.ApiHubPluginClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Get details about an API Hub plugin.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Plugin GetPlugin(GetPluginRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details about an API Hub plugin.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Plugin> GetPluginAsync(GetPluginRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details about an API Hub plugin.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Plugin> GetPluginAsync(GetPluginRequest request, st::CancellationToken cancellationToken) =>
            GetPluginAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details about an API Hub plugin.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin to retrieve.
        /// Format: `projects/{project}/locations/{location}/plugins/{plugin}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Plugin GetPlugin(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPlugin(new GetPluginRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details about an API Hub plugin.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin to retrieve.
        /// Format: `projects/{project}/locations/{location}/plugins/{plugin}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Plugin> GetPluginAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPluginAsync(new GetPluginRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details about an API Hub plugin.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin to retrieve.
        /// Format: `projects/{project}/locations/{location}/plugins/{plugin}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Plugin> GetPluginAsync(string name, st::CancellationToken cancellationToken) =>
            GetPluginAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details about an API Hub plugin.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin to retrieve.
        /// Format: `projects/{project}/locations/{location}/plugins/{plugin}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Plugin GetPlugin(PluginName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPlugin(new GetPluginRequest
            {
                PluginName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details about an API Hub plugin.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin to retrieve.
        /// Format: `projects/{project}/locations/{location}/plugins/{plugin}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Plugin> GetPluginAsync(PluginName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPluginAsync(new GetPluginRequest
            {
                PluginName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details about an API Hub plugin.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin to retrieve.
        /// Format: `projects/{project}/locations/{location}/plugins/{plugin}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Plugin> GetPluginAsync(PluginName name, st::CancellationToken cancellationToken) =>
            GetPluginAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Enables a plugin.
        /// The `state` of the plugin after enabling is `ENABLED`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Plugin EnablePlugin(EnablePluginRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enables a plugin.
        /// The `state` of the plugin after enabling is `ENABLED`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Plugin> EnablePluginAsync(EnablePluginRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enables a plugin.
        /// The `state` of the plugin after enabling is `ENABLED`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Plugin> EnablePluginAsync(EnablePluginRequest request, st::CancellationToken cancellationToken) =>
            EnablePluginAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Enables a plugin.
        /// The `state` of the plugin after enabling is `ENABLED`
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin to enable.
        /// Format: `projects/{project}/locations/{location}/plugins/{plugin}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Plugin EnablePlugin(string name, gaxgrpc::CallSettings callSettings = null) =>
            EnablePlugin(new EnablePluginRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Enables a plugin.
        /// The `state` of the plugin after enabling is `ENABLED`
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin to enable.
        /// Format: `projects/{project}/locations/{location}/plugins/{plugin}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Plugin> EnablePluginAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            EnablePluginAsync(new EnablePluginRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Enables a plugin.
        /// The `state` of the plugin after enabling is `ENABLED`
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin to enable.
        /// Format: `projects/{project}/locations/{location}/plugins/{plugin}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Plugin> EnablePluginAsync(string name, st::CancellationToken cancellationToken) =>
            EnablePluginAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Enables a plugin.
        /// The `state` of the plugin after enabling is `ENABLED`
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin to enable.
        /// Format: `projects/{project}/locations/{location}/plugins/{plugin}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Plugin EnablePlugin(PluginName name, gaxgrpc::CallSettings callSettings = null) =>
            EnablePlugin(new EnablePluginRequest
            {
                PluginName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Enables a plugin.
        /// The `state` of the plugin after enabling is `ENABLED`
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin to enable.
        /// Format: `projects/{project}/locations/{location}/plugins/{plugin}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Plugin> EnablePluginAsync(PluginName name, gaxgrpc::CallSettings callSettings = null) =>
            EnablePluginAsync(new EnablePluginRequest
            {
                PluginName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Enables a plugin.
        /// The `state` of the plugin after enabling is `ENABLED`
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin to enable.
        /// Format: `projects/{project}/locations/{location}/plugins/{plugin}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Plugin> EnablePluginAsync(PluginName name, st::CancellationToken cancellationToken) =>
            EnablePluginAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Disables a plugin.
        /// The `state` of the plugin after disabling is `DISABLED`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Plugin DisablePlugin(DisablePluginRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Disables a plugin.
        /// The `state` of the plugin after disabling is `DISABLED`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Plugin> DisablePluginAsync(DisablePluginRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Disables a plugin.
        /// The `state` of the plugin after disabling is `DISABLED`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Plugin> DisablePluginAsync(DisablePluginRequest request, st::CancellationToken cancellationToken) =>
            DisablePluginAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Disables a plugin.
        /// The `state` of the plugin after disabling is `DISABLED`
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin to disable.
        /// Format: `projects/{project}/locations/{location}/plugins/{plugin}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Plugin DisablePlugin(string name, gaxgrpc::CallSettings callSettings = null) =>
            DisablePlugin(new DisablePluginRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Disables a plugin.
        /// The `state` of the plugin after disabling is `DISABLED`
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin to disable.
        /// Format: `projects/{project}/locations/{location}/plugins/{plugin}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Plugin> DisablePluginAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DisablePluginAsync(new DisablePluginRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Disables a plugin.
        /// The `state` of the plugin after disabling is `DISABLED`
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin to disable.
        /// Format: `projects/{project}/locations/{location}/plugins/{plugin}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Plugin> DisablePluginAsync(string name, st::CancellationToken cancellationToken) =>
            DisablePluginAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Disables a plugin.
        /// The `state` of the plugin after disabling is `DISABLED`
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin to disable.
        /// Format: `projects/{project}/locations/{location}/plugins/{plugin}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Plugin DisablePlugin(PluginName name, gaxgrpc::CallSettings callSettings = null) =>
            DisablePlugin(new DisablePluginRequest
            {
                PluginName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Disables a plugin.
        /// The `state` of the plugin after disabling is `DISABLED`
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin to disable.
        /// Format: `projects/{project}/locations/{location}/plugins/{plugin}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Plugin> DisablePluginAsync(PluginName name, gaxgrpc::CallSettings callSettings = null) =>
            DisablePluginAsync(new DisablePluginRequest
            {
                PluginName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Disables a plugin.
        /// The `state` of the plugin after disabling is `DISABLED`
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin to disable.
        /// Format: `projects/{project}/locations/{location}/plugins/{plugin}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Plugin> DisablePluginAsync(PluginName name, st::CancellationToken cancellationToken) =>
            DisablePluginAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ApiHubPlugin client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// This service is used for managing plugins inside the API Hub.
    /// </remarks>
    public sealed partial class ApiHubPluginClientImpl : ApiHubPluginClient
    {
        private readonly gaxgrpc::ApiCall<GetPluginRequest, Plugin> _callGetPlugin;

        private readonly gaxgrpc::ApiCall<EnablePluginRequest, Plugin> _callEnablePlugin;

        private readonly gaxgrpc::ApiCall<DisablePluginRequest, Plugin> _callDisablePlugin;

        /// <summary>
        /// Constructs a client wrapper for the ApiHubPlugin service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ApiHubPluginSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ApiHubPluginClientImpl(ApiHubPlugin.ApiHubPluginClient grpcClient, ApiHubPluginSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ApiHubPluginSettings effectiveSettings = settings ?? ApiHubPluginSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callGetPlugin = clientHelper.BuildApiCall<GetPluginRequest, Plugin>("GetPlugin", grpcClient.GetPluginAsync, grpcClient.GetPlugin, effectiveSettings.GetPluginSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPlugin);
            Modify_GetPluginApiCall(ref _callGetPlugin);
            _callEnablePlugin = clientHelper.BuildApiCall<EnablePluginRequest, Plugin>("EnablePlugin", grpcClient.EnablePluginAsync, grpcClient.EnablePlugin, effectiveSettings.EnablePluginSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callEnablePlugin);
            Modify_EnablePluginApiCall(ref _callEnablePlugin);
            _callDisablePlugin = clientHelper.BuildApiCall<DisablePluginRequest, Plugin>("DisablePlugin", grpcClient.DisablePluginAsync, grpcClient.DisablePlugin, effectiveSettings.DisablePluginSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDisablePlugin);
            Modify_DisablePluginApiCall(ref _callDisablePlugin);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetPluginApiCall(ref gaxgrpc::ApiCall<GetPluginRequest, Plugin> call);

        partial void Modify_EnablePluginApiCall(ref gaxgrpc::ApiCall<EnablePluginRequest, Plugin> call);

        partial void Modify_DisablePluginApiCall(ref gaxgrpc::ApiCall<DisablePluginRequest, Plugin> call);

        partial void OnConstruction(ApiHubPlugin.ApiHubPluginClient grpcClient, ApiHubPluginSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ApiHubPlugin client</summary>
        public override ApiHubPlugin.ApiHubPluginClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_GetPluginRequest(ref GetPluginRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_EnablePluginRequest(ref EnablePluginRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DisablePluginRequest(ref DisablePluginRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Get details about an API Hub plugin.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Plugin GetPlugin(GetPluginRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPluginRequest(ref request, ref callSettings);
            return _callGetPlugin.Sync(request, callSettings);
        }

        /// <summary>
        /// Get details about an API Hub plugin.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Plugin> GetPluginAsync(GetPluginRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPluginRequest(ref request, ref callSettings);
            return _callGetPlugin.Async(request, callSettings);
        }

        /// <summary>
        /// Enables a plugin.
        /// The `state` of the plugin after enabling is `ENABLED`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Plugin EnablePlugin(EnablePluginRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnablePluginRequest(ref request, ref callSettings);
            return _callEnablePlugin.Sync(request, callSettings);
        }

        /// <summary>
        /// Enables a plugin.
        /// The `state` of the plugin after enabling is `ENABLED`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Plugin> EnablePluginAsync(EnablePluginRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnablePluginRequest(ref request, ref callSettings);
            return _callEnablePlugin.Async(request, callSettings);
        }

        /// <summary>
        /// Disables a plugin.
        /// The `state` of the plugin after disabling is `DISABLED`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Plugin DisablePlugin(DisablePluginRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DisablePluginRequest(ref request, ref callSettings);
            return _callDisablePlugin.Sync(request, callSettings);
        }

        /// <summary>
        /// Disables a plugin.
        /// The `state` of the plugin after disabling is `DISABLED`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Plugin> DisablePluginAsync(DisablePluginRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DisablePluginRequest(ref request, ref callSettings);
            return _callDisablePlugin.Async(request, callSettings);
        }
    }

    public static partial class ApiHubPlugin
    {
        public partial class ApiHubPluginClient
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
