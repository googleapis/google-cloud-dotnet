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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gcl = Google.Cloud.Location;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using lro = Google.LongRunning;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

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
            CreatePluginSettings = existing.CreatePluginSettings;
            ListPluginsSettings = existing.ListPluginsSettings;
            DeletePluginSettings = existing.DeletePluginSettings;
            DeletePluginOperationsSettings = existing.DeletePluginOperationsSettings.Clone();
            CreatePluginInstanceSettings = existing.CreatePluginInstanceSettings;
            CreatePluginInstanceOperationsSettings = existing.CreatePluginInstanceOperationsSettings.Clone();
            ExecutePluginInstanceActionSettings = existing.ExecutePluginInstanceActionSettings;
            ExecutePluginInstanceActionOperationsSettings = existing.ExecutePluginInstanceActionOperationsSettings.Clone();
            GetPluginInstanceSettings = existing.GetPluginInstanceSettings;
            ListPluginInstancesSettings = existing.ListPluginInstancesSettings;
            EnablePluginInstanceActionSettings = existing.EnablePluginInstanceActionSettings;
            EnablePluginInstanceActionOperationsSettings = existing.EnablePluginInstanceActionOperationsSettings.Clone();
            DisablePluginInstanceActionSettings = existing.DisablePluginInstanceActionSettings;
            DisablePluginInstanceActionOperationsSettings = existing.DisablePluginInstanceActionOperationsSettings.Clone();
            UpdatePluginInstanceSettings = existing.UpdatePluginInstanceSettings;
            DeletePluginInstanceSettings = existing.DeletePluginInstanceSettings;
            DeletePluginInstanceOperationsSettings = existing.DeletePluginInstanceOperationsSettings.Clone();
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiHubPluginClient.CreatePlugin</c> and <c>ApiHubPluginClient.CreatePluginAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreatePluginSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiHubPluginClient.ListPlugins</c> and <c>ApiHubPluginClient.ListPluginsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListPluginsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiHubPluginClient.DeletePlugin</c> and <c>ApiHubPluginClient.DeletePluginAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeletePluginSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ApiHubPluginClient.DeletePlugin</c> and
        /// <c>ApiHubPluginClient.DeletePluginAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DeletePluginOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiHubPluginClient.CreatePluginInstance</c> and <c>ApiHubPluginClient.CreatePluginInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreatePluginInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ApiHubPluginClient.CreatePluginInstance</c> and
        /// <c>ApiHubPluginClient.CreatePluginInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreatePluginInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiHubPluginClient.ExecutePluginInstanceAction</c> and
        /// <c>ApiHubPluginClient.ExecutePluginInstanceActionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExecutePluginInstanceActionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ApiHubPluginClient.ExecutePluginInstanceAction</c> and
        /// <c>ApiHubPluginClient.ExecutePluginInstanceActionAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings ExecutePluginInstanceActionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiHubPluginClient.GetPluginInstance</c> and <c>ApiHubPluginClient.GetPluginInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetPluginInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiHubPluginClient.ListPluginInstances</c> and <c>ApiHubPluginClient.ListPluginInstancesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListPluginInstancesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiHubPluginClient.EnablePluginInstanceAction</c> and
        /// <c>ApiHubPluginClient.EnablePluginInstanceActionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings EnablePluginInstanceActionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ApiHubPluginClient.EnablePluginInstanceAction</c> and
        /// <c>ApiHubPluginClient.EnablePluginInstanceActionAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings EnablePluginInstanceActionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiHubPluginClient.DisablePluginInstanceAction</c> and
        /// <c>ApiHubPluginClient.DisablePluginInstanceActionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DisablePluginInstanceActionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ApiHubPluginClient.DisablePluginInstanceAction</c> and
        /// <c>ApiHubPluginClient.DisablePluginInstanceActionAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DisablePluginInstanceActionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiHubPluginClient.UpdatePluginInstance</c> and <c>ApiHubPluginClient.UpdatePluginInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdatePluginInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiHubPluginClient.DeletePluginInstance</c> and <c>ApiHubPluginClient.DeletePluginInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeletePluginInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ApiHubPluginClient.DeletePluginInstance</c> and
        /// <c>ApiHubPluginClient.DeletePluginInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DeletePluginInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

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
        /// Get an API Hub plugin.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Plugin GetPlugin(GetPluginRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get an API Hub plugin.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Plugin> GetPluginAsync(GetPluginRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get an API Hub plugin.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Plugin> GetPluginAsync(GetPluginRequest request, st::CancellationToken cancellationToken) =>
            GetPluginAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get an API Hub plugin.
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
        /// Get an API Hub plugin.
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
        /// Get an API Hub plugin.
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
        /// Get an API Hub plugin.
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
        /// Get an API Hub plugin.
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
        /// Get an API Hub plugin.
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

        /// <summary>
        /// Create an API Hub plugin resource in the API hub.
        /// Once a plugin is created, it can be used to create plugin instances.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Plugin CreatePlugin(CreatePluginRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create an API Hub plugin resource in the API hub.
        /// Once a plugin is created, it can be used to create plugin instances.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Plugin> CreatePluginAsync(CreatePluginRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create an API Hub plugin resource in the API hub.
        /// Once a plugin is created, it can be used to create plugin instances.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Plugin> CreatePluginAsync(CreatePluginRequest request, st::CancellationToken cancellationToken) =>
            CreatePluginAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create an API Hub plugin resource in the API hub.
        /// Once a plugin is created, it can be used to create plugin instances.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this plugin will be created.
        /// Format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="plugin">
        /// Required. The plugin to create.
        /// </param>
        /// <param name="pluginId">
        /// Optional. The ID to use for the Plugin resource, which will become the
        /// final component of the Plugin's resource name. This field is optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another Plugin resource in the API hub
        /// instance.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-63 characters, overall resource name which will be
        /// of format
        /// `projects/{project}/locations/{location}/plugins/{plugin}`,
        /// its length is limited to 1000 characters and valid characters are
        /// /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Plugin CreatePlugin(string parent, Plugin plugin, string pluginId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePlugin(new CreatePluginRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PluginId = pluginId ?? "",
                Plugin = gax::GaxPreconditions.CheckNotNull(plugin, nameof(plugin)),
            }, callSettings);

        /// <summary>
        /// Create an API Hub plugin resource in the API hub.
        /// Once a plugin is created, it can be used to create plugin instances.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this plugin will be created.
        /// Format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="plugin">
        /// Required. The plugin to create.
        /// </param>
        /// <param name="pluginId">
        /// Optional. The ID to use for the Plugin resource, which will become the
        /// final component of the Plugin's resource name. This field is optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another Plugin resource in the API hub
        /// instance.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-63 characters, overall resource name which will be
        /// of format
        /// `projects/{project}/locations/{location}/plugins/{plugin}`,
        /// its length is limited to 1000 characters and valid characters are
        /// /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Plugin> CreatePluginAsync(string parent, Plugin plugin, string pluginId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePluginAsync(new CreatePluginRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PluginId = pluginId ?? "",
                Plugin = gax::GaxPreconditions.CheckNotNull(plugin, nameof(plugin)),
            }, callSettings);

        /// <summary>
        /// Create an API Hub plugin resource in the API hub.
        /// Once a plugin is created, it can be used to create plugin instances.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this plugin will be created.
        /// Format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="plugin">
        /// Required. The plugin to create.
        /// </param>
        /// <param name="pluginId">
        /// Optional. The ID to use for the Plugin resource, which will become the
        /// final component of the Plugin's resource name. This field is optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another Plugin resource in the API hub
        /// instance.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-63 characters, overall resource name which will be
        /// of format
        /// `projects/{project}/locations/{location}/plugins/{plugin}`,
        /// its length is limited to 1000 characters and valid characters are
        /// /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Plugin> CreatePluginAsync(string parent, Plugin plugin, string pluginId, st::CancellationToken cancellationToken) =>
            CreatePluginAsync(parent, plugin, pluginId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create an API Hub plugin resource in the API hub.
        /// Once a plugin is created, it can be used to create plugin instances.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this plugin will be created.
        /// Format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="plugin">
        /// Required. The plugin to create.
        /// </param>
        /// <param name="pluginId">
        /// Optional. The ID to use for the Plugin resource, which will become the
        /// final component of the Plugin's resource name. This field is optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another Plugin resource in the API hub
        /// instance.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-63 characters, overall resource name which will be
        /// of format
        /// `projects/{project}/locations/{location}/plugins/{plugin}`,
        /// its length is limited to 1000 characters and valid characters are
        /// /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Plugin CreatePlugin(gagr::LocationName parent, Plugin plugin, string pluginId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePlugin(new CreatePluginRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PluginId = pluginId ?? "",
                Plugin = gax::GaxPreconditions.CheckNotNull(plugin, nameof(plugin)),
            }, callSettings);

        /// <summary>
        /// Create an API Hub plugin resource in the API hub.
        /// Once a plugin is created, it can be used to create plugin instances.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this plugin will be created.
        /// Format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="plugin">
        /// Required. The plugin to create.
        /// </param>
        /// <param name="pluginId">
        /// Optional. The ID to use for the Plugin resource, which will become the
        /// final component of the Plugin's resource name. This field is optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another Plugin resource in the API hub
        /// instance.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-63 characters, overall resource name which will be
        /// of format
        /// `projects/{project}/locations/{location}/plugins/{plugin}`,
        /// its length is limited to 1000 characters and valid characters are
        /// /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Plugin> CreatePluginAsync(gagr::LocationName parent, Plugin plugin, string pluginId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePluginAsync(new CreatePluginRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PluginId = pluginId ?? "",
                Plugin = gax::GaxPreconditions.CheckNotNull(plugin, nameof(plugin)),
            }, callSettings);

        /// <summary>
        /// Create an API Hub plugin resource in the API hub.
        /// Once a plugin is created, it can be used to create plugin instances.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this plugin will be created.
        /// Format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="plugin">
        /// Required. The plugin to create.
        /// </param>
        /// <param name="pluginId">
        /// Optional. The ID to use for the Plugin resource, which will become the
        /// final component of the Plugin's resource name. This field is optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another Plugin resource in the API hub
        /// instance.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-63 characters, overall resource name which will be
        /// of format
        /// `projects/{project}/locations/{location}/plugins/{plugin}`,
        /// its length is limited to 1000 characters and valid characters are
        /// /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Plugin> CreatePluginAsync(gagr::LocationName parent, Plugin plugin, string pluginId, st::CancellationToken cancellationToken) =>
            CreatePluginAsync(parent, plugin, pluginId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List all the plugins in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Plugin"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPluginsResponse, Plugin> ListPlugins(ListPluginsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all the plugins in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Plugin"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPluginsResponse, Plugin> ListPluginsAsync(ListPluginsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all the plugins in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this plugin will be created.
        /// Format: `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="Plugin"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPluginsResponse, Plugin> ListPlugins(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPluginsRequest request = new ListPluginsRequest
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
            return ListPlugins(request, callSettings);
        }

        /// <summary>
        /// List all the plugins in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this plugin will be created.
        /// Format: `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Plugin"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPluginsResponse, Plugin> ListPluginsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPluginsRequest request = new ListPluginsRequest
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
            return ListPluginsAsync(request, callSettings);
        }

        /// <summary>
        /// List all the plugins in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this plugin will be created.
        /// Format: `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="Plugin"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPluginsResponse, Plugin> ListPlugins(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPluginsRequest request = new ListPluginsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPlugins(request, callSettings);
        }

        /// <summary>
        /// List all the plugins in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this plugin will be created.
        /// Format: `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Plugin"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPluginsResponse, Plugin> ListPluginsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPluginsRequest request = new ListPluginsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPluginsAsync(request, callSettings);
        }

        /// <summary>
        /// Delete a Plugin in API hub.
        /// Note, only user owned plugins can be deleted via this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeletePlugin(DeletePluginRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a Plugin in API hub.
        /// Note, only user owned plugins can be deleted via this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePluginAsync(DeletePluginRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a Plugin in API hub.
        /// Note, only user owned plugins can be deleted via this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePluginAsync(DeletePluginRequest request, st::CancellationToken cancellationToken) =>
            DeletePluginAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeletePlugin</c>.</summary>
        public virtual lro::OperationsClient DeletePluginOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeletePlugin</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeletePlugin(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeletePluginOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeletePlugin</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeletePluginAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeletePluginOperationsClient, callSettings);

        /// <summary>
        /// Delete a Plugin in API hub.
        /// Note, only user owned plugins can be deleted via this method.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Plugin resource to delete.
        /// Format: `projects/{project}/locations/{location}/plugins/{plugin}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeletePlugin(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePlugin(new DeletePluginRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a Plugin in API hub.
        /// Note, only user owned plugins can be deleted via this method.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Plugin resource to delete.
        /// Format: `projects/{project}/locations/{location}/plugins/{plugin}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePluginAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePluginAsync(new DeletePluginRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a Plugin in API hub.
        /// Note, only user owned plugins can be deleted via this method.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Plugin resource to delete.
        /// Format: `projects/{project}/locations/{location}/plugins/{plugin}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePluginAsync(string name, st::CancellationToken cancellationToken) =>
            DeletePluginAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a Plugin in API hub.
        /// Note, only user owned plugins can be deleted via this method.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Plugin resource to delete.
        /// Format: `projects/{project}/locations/{location}/plugins/{plugin}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeletePlugin(PluginName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePlugin(new DeletePluginRequest
            {
                PluginName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a Plugin in API hub.
        /// Note, only user owned plugins can be deleted via this method.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Plugin resource to delete.
        /// Format: `projects/{project}/locations/{location}/plugins/{plugin}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePluginAsync(PluginName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePluginAsync(new DeletePluginRequest
            {
                PluginName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a Plugin in API hub.
        /// Note, only user owned plugins can be deleted via this method.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Plugin resource to delete.
        /// Format: `projects/{project}/locations/{location}/plugins/{plugin}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePluginAsync(PluginName name, st::CancellationToken cancellationToken) =>
            DeletePluginAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Plugin instance in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PluginInstance, OperationMetadata> CreatePluginInstance(CreatePluginInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Plugin instance in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PluginInstance, OperationMetadata>> CreatePluginInstanceAsync(CreatePluginInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Plugin instance in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PluginInstance, OperationMetadata>> CreatePluginInstanceAsync(CreatePluginInstanceRequest request, st::CancellationToken cancellationToken) =>
            CreatePluginInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreatePluginInstance</c>.</summary>
        public virtual lro::OperationsClient CreatePluginInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreatePluginInstance</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<PluginInstance, OperationMetadata> PollOnceCreatePluginInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PluginInstance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreatePluginInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreatePluginInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<PluginInstance, OperationMetadata>> PollOnceCreatePluginInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PluginInstance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreatePluginInstanceOperationsClient, callSettings);

        /// <summary>
        /// Creates a Plugin instance in the API hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the plugin instance resource.
        /// Format: `projects/{project}/locations/{location}/plugins/{plugin}`
        /// </param>
        /// <param name="pluginInstance">
        /// Required. The plugin instance to create.
        /// </param>
        /// <param name="pluginInstanceId">
        /// Optional. The ID to use for the plugin instance, which will become the
        /// final component of the plugin instance's resource name. This field is
        /// optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another plugin instance in the plugin
        /// resource.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PluginInstance, OperationMetadata> CreatePluginInstance(string parent, PluginInstance pluginInstance, string pluginInstanceId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePluginInstance(new CreatePluginInstanceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PluginInstanceId = pluginInstanceId ?? "",
                PluginInstance = gax::GaxPreconditions.CheckNotNull(pluginInstance, nameof(pluginInstance)),
            }, callSettings);

        /// <summary>
        /// Creates a Plugin instance in the API hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the plugin instance resource.
        /// Format: `projects/{project}/locations/{location}/plugins/{plugin}`
        /// </param>
        /// <param name="pluginInstance">
        /// Required. The plugin instance to create.
        /// </param>
        /// <param name="pluginInstanceId">
        /// Optional. The ID to use for the plugin instance, which will become the
        /// final component of the plugin instance's resource name. This field is
        /// optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another plugin instance in the plugin
        /// resource.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PluginInstance, OperationMetadata>> CreatePluginInstanceAsync(string parent, PluginInstance pluginInstance, string pluginInstanceId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePluginInstanceAsync(new CreatePluginInstanceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PluginInstanceId = pluginInstanceId ?? "",
                PluginInstance = gax::GaxPreconditions.CheckNotNull(pluginInstance, nameof(pluginInstance)),
            }, callSettings);

        /// <summary>
        /// Creates a Plugin instance in the API hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the plugin instance resource.
        /// Format: `projects/{project}/locations/{location}/plugins/{plugin}`
        /// </param>
        /// <param name="pluginInstance">
        /// Required. The plugin instance to create.
        /// </param>
        /// <param name="pluginInstanceId">
        /// Optional. The ID to use for the plugin instance, which will become the
        /// final component of the plugin instance's resource name. This field is
        /// optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another plugin instance in the plugin
        /// resource.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PluginInstance, OperationMetadata>> CreatePluginInstanceAsync(string parent, PluginInstance pluginInstance, string pluginInstanceId, st::CancellationToken cancellationToken) =>
            CreatePluginInstanceAsync(parent, pluginInstance, pluginInstanceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Plugin instance in the API hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the plugin instance resource.
        /// Format: `projects/{project}/locations/{location}/plugins/{plugin}`
        /// </param>
        /// <param name="pluginInstance">
        /// Required. The plugin instance to create.
        /// </param>
        /// <param name="pluginInstanceId">
        /// Optional. The ID to use for the plugin instance, which will become the
        /// final component of the plugin instance's resource name. This field is
        /// optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another plugin instance in the plugin
        /// resource.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PluginInstance, OperationMetadata> CreatePluginInstance(PluginName parent, PluginInstance pluginInstance, string pluginInstanceId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePluginInstance(new CreatePluginInstanceRequest
            {
                ParentAsPluginName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PluginInstanceId = pluginInstanceId ?? "",
                PluginInstance = gax::GaxPreconditions.CheckNotNull(pluginInstance, nameof(pluginInstance)),
            }, callSettings);

        /// <summary>
        /// Creates a Plugin instance in the API hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the plugin instance resource.
        /// Format: `projects/{project}/locations/{location}/plugins/{plugin}`
        /// </param>
        /// <param name="pluginInstance">
        /// Required. The plugin instance to create.
        /// </param>
        /// <param name="pluginInstanceId">
        /// Optional. The ID to use for the plugin instance, which will become the
        /// final component of the plugin instance's resource name. This field is
        /// optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another plugin instance in the plugin
        /// resource.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PluginInstance, OperationMetadata>> CreatePluginInstanceAsync(PluginName parent, PluginInstance pluginInstance, string pluginInstanceId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePluginInstanceAsync(new CreatePluginInstanceRequest
            {
                ParentAsPluginName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PluginInstanceId = pluginInstanceId ?? "",
                PluginInstance = gax::GaxPreconditions.CheckNotNull(pluginInstance, nameof(pluginInstance)),
            }, callSettings);

        /// <summary>
        /// Creates a Plugin instance in the API hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the plugin instance resource.
        /// Format: `projects/{project}/locations/{location}/plugins/{plugin}`
        /// </param>
        /// <param name="pluginInstance">
        /// Required. The plugin instance to create.
        /// </param>
        /// <param name="pluginInstanceId">
        /// Optional. The ID to use for the plugin instance, which will become the
        /// final component of the plugin instance's resource name. This field is
        /// optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified id is already used by another plugin instance in the plugin
        /// resource.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PluginInstance, OperationMetadata>> CreatePluginInstanceAsync(PluginName parent, PluginInstance pluginInstance, string pluginInstanceId, st::CancellationToken cancellationToken) =>
            CreatePluginInstanceAsync(parent, pluginInstance, pluginInstanceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Executes a plugin instance in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExecutePluginInstanceActionResponse, OperationMetadata> ExecutePluginInstanceAction(ExecutePluginInstanceActionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Executes a plugin instance in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExecutePluginInstanceActionResponse, OperationMetadata>> ExecutePluginInstanceActionAsync(ExecutePluginInstanceActionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Executes a plugin instance in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExecutePluginInstanceActionResponse, OperationMetadata>> ExecutePluginInstanceActionAsync(ExecutePluginInstanceActionRequest request, st::CancellationToken cancellationToken) =>
            ExecutePluginInstanceActionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ExecutePluginInstanceAction</c>.</summary>
        public virtual lro::OperationsClient ExecutePluginInstanceActionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExecutePluginInstanceAction</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ExecutePluginInstanceActionResponse, OperationMetadata> PollOnceExecutePluginInstanceAction(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExecutePluginInstanceActionResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExecutePluginInstanceActionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExecutePluginInstanceAction</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ExecutePluginInstanceActionResponse, OperationMetadata>> PollOnceExecutePluginInstanceActionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExecutePluginInstanceActionResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExecutePluginInstanceActionOperationsClient, callSettings);

        /// <summary>
        /// Executes a plugin instance in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin instance to execute.
        /// Format:
        /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`
        /// </param>
        /// <param name="actionExecutionDetail">
        /// Required. The execution details for the action to execute.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExecutePluginInstanceActionResponse, OperationMetadata> ExecutePluginInstanceAction(string name, ActionExecutionDetail actionExecutionDetail, gaxgrpc::CallSettings callSettings = null) =>
            ExecutePluginInstanceAction(new ExecutePluginInstanceActionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                ActionExecutionDetail = gax::GaxPreconditions.CheckNotNull(actionExecutionDetail, nameof(actionExecutionDetail)),
            }, callSettings);

        /// <summary>
        /// Executes a plugin instance in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin instance to execute.
        /// Format:
        /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`
        /// </param>
        /// <param name="actionExecutionDetail">
        /// Required. The execution details for the action to execute.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExecutePluginInstanceActionResponse, OperationMetadata>> ExecutePluginInstanceActionAsync(string name, ActionExecutionDetail actionExecutionDetail, gaxgrpc::CallSettings callSettings = null) =>
            ExecutePluginInstanceActionAsync(new ExecutePluginInstanceActionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                ActionExecutionDetail = gax::GaxPreconditions.CheckNotNull(actionExecutionDetail, nameof(actionExecutionDetail)),
            }, callSettings);

        /// <summary>
        /// Executes a plugin instance in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin instance to execute.
        /// Format:
        /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`
        /// </param>
        /// <param name="actionExecutionDetail">
        /// Required. The execution details for the action to execute.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExecutePluginInstanceActionResponse, OperationMetadata>> ExecutePluginInstanceActionAsync(string name, ActionExecutionDetail actionExecutionDetail, st::CancellationToken cancellationToken) =>
            ExecutePluginInstanceActionAsync(name, actionExecutionDetail, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Executes a plugin instance in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin instance to execute.
        /// Format:
        /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`
        /// </param>
        /// <param name="actionExecutionDetail">
        /// Required. The execution details for the action to execute.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExecutePluginInstanceActionResponse, OperationMetadata> ExecutePluginInstanceAction(PluginInstanceName name, ActionExecutionDetail actionExecutionDetail, gaxgrpc::CallSettings callSettings = null) =>
            ExecutePluginInstanceAction(new ExecutePluginInstanceActionRequest
            {
                PluginInstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                ActionExecutionDetail = gax::GaxPreconditions.CheckNotNull(actionExecutionDetail, nameof(actionExecutionDetail)),
            }, callSettings);

        /// <summary>
        /// Executes a plugin instance in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin instance to execute.
        /// Format:
        /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`
        /// </param>
        /// <param name="actionExecutionDetail">
        /// Required. The execution details for the action to execute.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExecutePluginInstanceActionResponse, OperationMetadata>> ExecutePluginInstanceActionAsync(PluginInstanceName name, ActionExecutionDetail actionExecutionDetail, gaxgrpc::CallSettings callSettings = null) =>
            ExecutePluginInstanceActionAsync(new ExecutePluginInstanceActionRequest
            {
                PluginInstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                ActionExecutionDetail = gax::GaxPreconditions.CheckNotNull(actionExecutionDetail, nameof(actionExecutionDetail)),
            }, callSettings);

        /// <summary>
        /// Executes a plugin instance in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin instance to execute.
        /// Format:
        /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`
        /// </param>
        /// <param name="actionExecutionDetail">
        /// Required. The execution details for the action to execute.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExecutePluginInstanceActionResponse, OperationMetadata>> ExecutePluginInstanceActionAsync(PluginInstanceName name, ActionExecutionDetail actionExecutionDetail, st::CancellationToken cancellationToken) =>
            ExecutePluginInstanceActionAsync(name, actionExecutionDetail, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get an API Hub plugin instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PluginInstance GetPluginInstance(GetPluginInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get an API Hub plugin instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PluginInstance> GetPluginInstanceAsync(GetPluginInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get an API Hub plugin instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PluginInstance> GetPluginInstanceAsync(GetPluginInstanceRequest request, st::CancellationToken cancellationToken) =>
            GetPluginInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get an API Hub plugin instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin instance to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PluginInstance GetPluginInstance(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPluginInstance(new GetPluginInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get an API Hub plugin instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin instance to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PluginInstance> GetPluginInstanceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPluginInstanceAsync(new GetPluginInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get an API Hub plugin instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin instance to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PluginInstance> GetPluginInstanceAsync(string name, st::CancellationToken cancellationToken) =>
            GetPluginInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get an API Hub plugin instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin instance to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PluginInstance GetPluginInstance(PluginInstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPluginInstance(new GetPluginInstanceRequest
            {
                PluginInstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get an API Hub plugin instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin instance to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PluginInstance> GetPluginInstanceAsync(PluginInstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPluginInstanceAsync(new GetPluginInstanceRequest
            {
                PluginInstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get an API Hub plugin instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin instance to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PluginInstance> GetPluginInstanceAsync(PluginInstanceName name, st::CancellationToken cancellationToken) =>
            GetPluginInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List all the plugins in a given project and location.
        /// `-` can be used as wildcard value for {plugin_id}
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PluginInstance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPluginInstancesResponse, PluginInstance> ListPluginInstances(ListPluginInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all the plugins in a given project and location.
        /// `-` can be used as wildcard value for {plugin_id}
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PluginInstance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPluginInstancesResponse, PluginInstance> ListPluginInstancesAsync(ListPluginInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all the plugins in a given project and location.
        /// `-` can be used as wildcard value for {plugin_id}
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this plugin will be created.
        /// Format: `projects/{project}/locations/{location}/plugins/{plugin}`.
        /// To list plugin instances for multiple plugins,
        /// use the - character instead of the plugin ID.
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
        /// <returns>A pageable sequence of <see cref="PluginInstance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPluginInstancesResponse, PluginInstance> ListPluginInstances(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPluginInstancesRequest request = new ListPluginInstancesRequest
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
            return ListPluginInstances(request, callSettings);
        }

        /// <summary>
        /// List all the plugins in a given project and location.
        /// `-` can be used as wildcard value for {plugin_id}
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this plugin will be created.
        /// Format: `projects/{project}/locations/{location}/plugins/{plugin}`.
        /// To list plugin instances for multiple plugins,
        /// use the - character instead of the plugin ID.
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
        /// <returns>A pageable asynchronous sequence of <see cref="PluginInstance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPluginInstancesResponse, PluginInstance> ListPluginInstancesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPluginInstancesRequest request = new ListPluginInstancesRequest
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
            return ListPluginInstancesAsync(request, callSettings);
        }

        /// <summary>
        /// List all the plugins in a given project and location.
        /// `-` can be used as wildcard value for {plugin_id}
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this plugin will be created.
        /// Format: `projects/{project}/locations/{location}/plugins/{plugin}`.
        /// To list plugin instances for multiple plugins,
        /// use the - character instead of the plugin ID.
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
        /// <returns>A pageable sequence of <see cref="PluginInstance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPluginInstancesResponse, PluginInstance> ListPluginInstances(PluginName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPluginInstancesRequest request = new ListPluginInstancesRequest
            {
                ParentAsPluginName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPluginInstances(request, callSettings);
        }

        /// <summary>
        /// List all the plugins in a given project and location.
        /// `-` can be used as wildcard value for {plugin_id}
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this plugin will be created.
        /// Format: `projects/{project}/locations/{location}/plugins/{plugin}`.
        /// To list plugin instances for multiple plugins,
        /// use the - character instead of the plugin ID.
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
        /// <returns>A pageable asynchronous sequence of <see cref="PluginInstance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPluginInstancesResponse, PluginInstance> ListPluginInstancesAsync(PluginName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPluginInstancesRequest request = new ListPluginInstancesRequest
            {
                ParentAsPluginName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPluginInstancesAsync(request, callSettings);
        }

        /// <summary>
        /// Enables a plugin instance in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EnablePluginInstanceActionResponse, OperationMetadata> EnablePluginInstanceAction(EnablePluginInstanceActionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enables a plugin instance in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EnablePluginInstanceActionResponse, OperationMetadata>> EnablePluginInstanceActionAsync(EnablePluginInstanceActionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enables a plugin instance in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EnablePluginInstanceActionResponse, OperationMetadata>> EnablePluginInstanceActionAsync(EnablePluginInstanceActionRequest request, st::CancellationToken cancellationToken) =>
            EnablePluginInstanceActionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>EnablePluginInstanceAction</c>.</summary>
        public virtual lro::OperationsClient EnablePluginInstanceActionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>EnablePluginInstanceAction</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<EnablePluginInstanceActionResponse, OperationMetadata> PollOnceEnablePluginInstanceAction(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<EnablePluginInstanceActionResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), EnablePluginInstanceActionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>EnablePluginInstanceAction</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<EnablePluginInstanceActionResponse, OperationMetadata>> PollOnceEnablePluginInstanceActionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<EnablePluginInstanceActionResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), EnablePluginInstanceActionOperationsClient, callSettings);

        /// <summary>
        /// Enables a plugin instance in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin instance to enable.
        /// Format:
        /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`
        /// </param>
        /// <param name="actionId">
        /// Required. The action id to enable.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EnablePluginInstanceActionResponse, OperationMetadata> EnablePluginInstanceAction(string name, string actionId, gaxgrpc::CallSettings callSettings = null) =>
            EnablePluginInstanceAction(new EnablePluginInstanceActionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                ActionId = gax::GaxPreconditions.CheckNotNullOrEmpty(actionId, nameof(actionId)),
            }, callSettings);

        /// <summary>
        /// Enables a plugin instance in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin instance to enable.
        /// Format:
        /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`
        /// </param>
        /// <param name="actionId">
        /// Required. The action id to enable.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EnablePluginInstanceActionResponse, OperationMetadata>> EnablePluginInstanceActionAsync(string name, string actionId, gaxgrpc::CallSettings callSettings = null) =>
            EnablePluginInstanceActionAsync(new EnablePluginInstanceActionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                ActionId = gax::GaxPreconditions.CheckNotNullOrEmpty(actionId, nameof(actionId)),
            }, callSettings);

        /// <summary>
        /// Enables a plugin instance in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin instance to enable.
        /// Format:
        /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`
        /// </param>
        /// <param name="actionId">
        /// Required. The action id to enable.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EnablePluginInstanceActionResponse, OperationMetadata>> EnablePluginInstanceActionAsync(string name, string actionId, st::CancellationToken cancellationToken) =>
            EnablePluginInstanceActionAsync(name, actionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Enables a plugin instance in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin instance to enable.
        /// Format:
        /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`
        /// </param>
        /// <param name="actionId">
        /// Required. The action id to enable.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EnablePluginInstanceActionResponse, OperationMetadata> EnablePluginInstanceAction(PluginInstanceName name, string actionId, gaxgrpc::CallSettings callSettings = null) =>
            EnablePluginInstanceAction(new EnablePluginInstanceActionRequest
            {
                PluginInstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                ActionId = gax::GaxPreconditions.CheckNotNullOrEmpty(actionId, nameof(actionId)),
            }, callSettings);

        /// <summary>
        /// Enables a plugin instance in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin instance to enable.
        /// Format:
        /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`
        /// </param>
        /// <param name="actionId">
        /// Required. The action id to enable.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EnablePluginInstanceActionResponse, OperationMetadata>> EnablePluginInstanceActionAsync(PluginInstanceName name, string actionId, gaxgrpc::CallSettings callSettings = null) =>
            EnablePluginInstanceActionAsync(new EnablePluginInstanceActionRequest
            {
                PluginInstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                ActionId = gax::GaxPreconditions.CheckNotNullOrEmpty(actionId, nameof(actionId)),
            }, callSettings);

        /// <summary>
        /// Enables a plugin instance in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin instance to enable.
        /// Format:
        /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`
        /// </param>
        /// <param name="actionId">
        /// Required. The action id to enable.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EnablePluginInstanceActionResponse, OperationMetadata>> EnablePluginInstanceActionAsync(PluginInstanceName name, string actionId, st::CancellationToken cancellationToken) =>
            EnablePluginInstanceActionAsync(name, actionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Disables a plugin instance in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DisablePluginInstanceActionResponse, OperationMetadata> DisablePluginInstanceAction(DisablePluginInstanceActionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Disables a plugin instance in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DisablePluginInstanceActionResponse, OperationMetadata>> DisablePluginInstanceActionAsync(DisablePluginInstanceActionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Disables a plugin instance in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DisablePluginInstanceActionResponse, OperationMetadata>> DisablePluginInstanceActionAsync(DisablePluginInstanceActionRequest request, st::CancellationToken cancellationToken) =>
            DisablePluginInstanceActionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DisablePluginInstanceAction</c>.</summary>
        public virtual lro::OperationsClient DisablePluginInstanceActionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DisablePluginInstanceAction</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DisablePluginInstanceActionResponse, OperationMetadata> PollOnceDisablePluginInstanceAction(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DisablePluginInstanceActionResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DisablePluginInstanceActionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DisablePluginInstanceAction</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DisablePluginInstanceActionResponse, OperationMetadata>> PollOnceDisablePluginInstanceActionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DisablePluginInstanceActionResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DisablePluginInstanceActionOperationsClient, callSettings);

        /// <summary>
        /// Disables a plugin instance in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin instance to disable.
        /// Format:
        /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`
        /// </param>
        /// <param name="actionId">
        /// Required. The action id to disable.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DisablePluginInstanceActionResponse, OperationMetadata> DisablePluginInstanceAction(string name, string actionId, gaxgrpc::CallSettings callSettings = null) =>
            DisablePluginInstanceAction(new DisablePluginInstanceActionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                ActionId = gax::GaxPreconditions.CheckNotNullOrEmpty(actionId, nameof(actionId)),
            }, callSettings);

        /// <summary>
        /// Disables a plugin instance in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin instance to disable.
        /// Format:
        /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`
        /// </param>
        /// <param name="actionId">
        /// Required. The action id to disable.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DisablePluginInstanceActionResponse, OperationMetadata>> DisablePluginInstanceActionAsync(string name, string actionId, gaxgrpc::CallSettings callSettings = null) =>
            DisablePluginInstanceActionAsync(new DisablePluginInstanceActionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                ActionId = gax::GaxPreconditions.CheckNotNullOrEmpty(actionId, nameof(actionId)),
            }, callSettings);

        /// <summary>
        /// Disables a plugin instance in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin instance to disable.
        /// Format:
        /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`
        /// </param>
        /// <param name="actionId">
        /// Required. The action id to disable.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DisablePluginInstanceActionResponse, OperationMetadata>> DisablePluginInstanceActionAsync(string name, string actionId, st::CancellationToken cancellationToken) =>
            DisablePluginInstanceActionAsync(name, actionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Disables a plugin instance in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin instance to disable.
        /// Format:
        /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`
        /// </param>
        /// <param name="actionId">
        /// Required. The action id to disable.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DisablePluginInstanceActionResponse, OperationMetadata> DisablePluginInstanceAction(PluginInstanceName name, string actionId, gaxgrpc::CallSettings callSettings = null) =>
            DisablePluginInstanceAction(new DisablePluginInstanceActionRequest
            {
                PluginInstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                ActionId = gax::GaxPreconditions.CheckNotNullOrEmpty(actionId, nameof(actionId)),
            }, callSettings);

        /// <summary>
        /// Disables a plugin instance in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin instance to disable.
        /// Format:
        /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`
        /// </param>
        /// <param name="actionId">
        /// Required. The action id to disable.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DisablePluginInstanceActionResponse, OperationMetadata>> DisablePluginInstanceActionAsync(PluginInstanceName name, string actionId, gaxgrpc::CallSettings callSettings = null) =>
            DisablePluginInstanceActionAsync(new DisablePluginInstanceActionRequest
            {
                PluginInstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                ActionId = gax::GaxPreconditions.CheckNotNullOrEmpty(actionId, nameof(actionId)),
            }, callSettings);

        /// <summary>
        /// Disables a plugin instance in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin instance to disable.
        /// Format:
        /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`
        /// </param>
        /// <param name="actionId">
        /// Required. The action id to disable.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DisablePluginInstanceActionResponse, OperationMetadata>> DisablePluginInstanceActionAsync(PluginInstanceName name, string actionId, st::CancellationToken cancellationToken) =>
            DisablePluginInstanceActionAsync(name, actionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a plugin instance in the API hub.
        /// The following fields in the
        /// [plugin_instance][google.cloud.apihub.v1.PluginInstance] can be updated
        /// currently:
        /// 
        /// * [display_name][google.cloud.apihub.v1.PluginInstance.display_name]
        /// * [schedule_cron_expression][PluginInstance.actions.schedule_cron_expression]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdatePluginInstanceRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// 
        /// To update the
        /// [auth_config][google.cloud.apihub.v1.PluginInstance.auth_config] and
        /// [additional_config][google.cloud.apihub.v1.PluginInstance.additional_config]
        /// of the plugin instance, use the
        /// [ApplyPluginInstanceConfig][google.cloud.apihub.v1.ApiHubPlugin.ApplyPluginInstanceConfig]
        /// method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PluginInstance UpdatePluginInstance(UpdatePluginInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a plugin instance in the API hub.
        /// The following fields in the
        /// [plugin_instance][google.cloud.apihub.v1.PluginInstance] can be updated
        /// currently:
        /// 
        /// * [display_name][google.cloud.apihub.v1.PluginInstance.display_name]
        /// * [schedule_cron_expression][PluginInstance.actions.schedule_cron_expression]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdatePluginInstanceRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// 
        /// To update the
        /// [auth_config][google.cloud.apihub.v1.PluginInstance.auth_config] and
        /// [additional_config][google.cloud.apihub.v1.PluginInstance.additional_config]
        /// of the plugin instance, use the
        /// [ApplyPluginInstanceConfig][google.cloud.apihub.v1.ApiHubPlugin.ApplyPluginInstanceConfig]
        /// method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PluginInstance> UpdatePluginInstanceAsync(UpdatePluginInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a plugin instance in the API hub.
        /// The following fields in the
        /// [plugin_instance][google.cloud.apihub.v1.PluginInstance] can be updated
        /// currently:
        /// 
        /// * [display_name][google.cloud.apihub.v1.PluginInstance.display_name]
        /// * [schedule_cron_expression][PluginInstance.actions.schedule_cron_expression]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdatePluginInstanceRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// 
        /// To update the
        /// [auth_config][google.cloud.apihub.v1.PluginInstance.auth_config] and
        /// [additional_config][google.cloud.apihub.v1.PluginInstance.additional_config]
        /// of the plugin instance, use the
        /// [ApplyPluginInstanceConfig][google.cloud.apihub.v1.ApiHubPlugin.ApplyPluginInstanceConfig]
        /// method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PluginInstance> UpdatePluginInstanceAsync(UpdatePluginInstanceRequest request, st::CancellationToken cancellationToken) =>
            UpdatePluginInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a plugin instance in the API hub.
        /// The following fields in the
        /// [plugin_instance][google.cloud.apihub.v1.PluginInstance] can be updated
        /// currently:
        /// 
        /// * [display_name][google.cloud.apihub.v1.PluginInstance.display_name]
        /// * [schedule_cron_expression][PluginInstance.actions.schedule_cron_expression]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdatePluginInstanceRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// 
        /// To update the
        /// [auth_config][google.cloud.apihub.v1.PluginInstance.auth_config] and
        /// [additional_config][google.cloud.apihub.v1.PluginInstance.additional_config]
        /// of the plugin instance, use the
        /// [ApplyPluginInstanceConfig][google.cloud.apihub.v1.ApiHubPlugin.ApplyPluginInstanceConfig]
        /// method.
        /// </summary>
        /// <param name="pluginInstance">
        /// Required. The plugin instance to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PluginInstance UpdatePluginInstance(PluginInstance pluginInstance, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePluginInstance(new UpdatePluginInstanceRequest
            {
                PluginInstance = gax::GaxPreconditions.CheckNotNull(pluginInstance, nameof(pluginInstance)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a plugin instance in the API hub.
        /// The following fields in the
        /// [plugin_instance][google.cloud.apihub.v1.PluginInstance] can be updated
        /// currently:
        /// 
        /// * [display_name][google.cloud.apihub.v1.PluginInstance.display_name]
        /// * [schedule_cron_expression][PluginInstance.actions.schedule_cron_expression]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdatePluginInstanceRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// 
        /// To update the
        /// [auth_config][google.cloud.apihub.v1.PluginInstance.auth_config] and
        /// [additional_config][google.cloud.apihub.v1.PluginInstance.additional_config]
        /// of the plugin instance, use the
        /// [ApplyPluginInstanceConfig][google.cloud.apihub.v1.ApiHubPlugin.ApplyPluginInstanceConfig]
        /// method.
        /// </summary>
        /// <param name="pluginInstance">
        /// Required. The plugin instance to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PluginInstance> UpdatePluginInstanceAsync(PluginInstance pluginInstance, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePluginInstanceAsync(new UpdatePluginInstanceRequest
            {
                PluginInstance = gax::GaxPreconditions.CheckNotNull(pluginInstance, nameof(pluginInstance)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a plugin instance in the API hub.
        /// The following fields in the
        /// [plugin_instance][google.cloud.apihub.v1.PluginInstance] can be updated
        /// currently:
        /// 
        /// * [display_name][google.cloud.apihub.v1.PluginInstance.display_name]
        /// * [schedule_cron_expression][PluginInstance.actions.schedule_cron_expression]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdatePluginInstanceRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// 
        /// To update the
        /// [auth_config][google.cloud.apihub.v1.PluginInstance.auth_config] and
        /// [additional_config][google.cloud.apihub.v1.PluginInstance.additional_config]
        /// of the plugin instance, use the
        /// [ApplyPluginInstanceConfig][google.cloud.apihub.v1.ApiHubPlugin.ApplyPluginInstanceConfig]
        /// method.
        /// </summary>
        /// <param name="pluginInstance">
        /// Required. The plugin instance to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PluginInstance> UpdatePluginInstanceAsync(PluginInstance pluginInstance, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdatePluginInstanceAsync(pluginInstance, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a plugin instance in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeletePluginInstance(DeletePluginInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a plugin instance in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePluginInstanceAsync(DeletePluginInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a plugin instance in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePluginInstanceAsync(DeletePluginInstanceRequest request, st::CancellationToken cancellationToken) =>
            DeletePluginInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeletePluginInstance</c>.</summary>
        public virtual lro::OperationsClient DeletePluginInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeletePluginInstance</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeletePluginInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeletePluginInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeletePluginInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeletePluginInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeletePluginInstanceOperationsClient, callSettings);

        /// <summary>
        /// Deletes a plugin instance in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin instance to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeletePluginInstance(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePluginInstance(new DeletePluginInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a plugin instance in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin instance to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePluginInstanceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePluginInstanceAsync(new DeletePluginInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a plugin instance in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin instance to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePluginInstanceAsync(string name, st::CancellationToken cancellationToken) =>
            DeletePluginInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a plugin instance in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin instance to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeletePluginInstance(PluginInstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePluginInstance(new DeletePluginInstanceRequest
            {
                PluginInstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a plugin instance in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin instance to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePluginInstanceAsync(PluginInstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePluginInstanceAsync(new DeletePluginInstanceRequest
            {
                PluginInstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a plugin instance in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the plugin instance to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePluginInstanceAsync(PluginInstanceName name, st::CancellationToken cancellationToken) =>
            DeletePluginInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
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

        private readonly gaxgrpc::ApiCall<CreatePluginRequest, Plugin> _callCreatePlugin;

        private readonly gaxgrpc::ApiCall<ListPluginsRequest, ListPluginsResponse> _callListPlugins;

        private readonly gaxgrpc::ApiCall<DeletePluginRequest, lro::Operation> _callDeletePlugin;

        private readonly gaxgrpc::ApiCall<CreatePluginInstanceRequest, lro::Operation> _callCreatePluginInstance;

        private readonly gaxgrpc::ApiCall<ExecutePluginInstanceActionRequest, lro::Operation> _callExecutePluginInstanceAction;

        private readonly gaxgrpc::ApiCall<GetPluginInstanceRequest, PluginInstance> _callGetPluginInstance;

        private readonly gaxgrpc::ApiCall<ListPluginInstancesRequest, ListPluginInstancesResponse> _callListPluginInstances;

        private readonly gaxgrpc::ApiCall<EnablePluginInstanceActionRequest, lro::Operation> _callEnablePluginInstanceAction;

        private readonly gaxgrpc::ApiCall<DisablePluginInstanceActionRequest, lro::Operation> _callDisablePluginInstanceAction;

        private readonly gaxgrpc::ApiCall<UpdatePluginInstanceRequest, PluginInstance> _callUpdatePluginInstance;

        private readonly gaxgrpc::ApiCall<DeletePluginInstanceRequest, lro::Operation> _callDeletePluginInstance;

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
            DeletePluginOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeletePluginOperationsSettings, logger);
            CreatePluginInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreatePluginInstanceOperationsSettings, logger);
            ExecutePluginInstanceActionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ExecutePluginInstanceActionOperationsSettings, logger);
            EnablePluginInstanceActionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.EnablePluginInstanceActionOperationsSettings, logger);
            DisablePluginInstanceActionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DisablePluginInstanceActionOperationsSettings, logger);
            DeletePluginInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeletePluginInstanceOperationsSettings, logger);
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
            _callCreatePlugin = clientHelper.BuildApiCall<CreatePluginRequest, Plugin>("CreatePlugin", grpcClient.CreatePluginAsync, grpcClient.CreatePlugin, effectiveSettings.CreatePluginSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreatePlugin);
            Modify_CreatePluginApiCall(ref _callCreatePlugin);
            _callListPlugins = clientHelper.BuildApiCall<ListPluginsRequest, ListPluginsResponse>("ListPlugins", grpcClient.ListPluginsAsync, grpcClient.ListPlugins, effectiveSettings.ListPluginsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPlugins);
            Modify_ListPluginsApiCall(ref _callListPlugins);
            _callDeletePlugin = clientHelper.BuildApiCall<DeletePluginRequest, lro::Operation>("DeletePlugin", grpcClient.DeletePluginAsync, grpcClient.DeletePlugin, effectiveSettings.DeletePluginSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeletePlugin);
            Modify_DeletePluginApiCall(ref _callDeletePlugin);
            _callCreatePluginInstance = clientHelper.BuildApiCall<CreatePluginInstanceRequest, lro::Operation>("CreatePluginInstance", grpcClient.CreatePluginInstanceAsync, grpcClient.CreatePluginInstance, effectiveSettings.CreatePluginInstanceSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreatePluginInstance);
            Modify_CreatePluginInstanceApiCall(ref _callCreatePluginInstance);
            _callExecutePluginInstanceAction = clientHelper.BuildApiCall<ExecutePluginInstanceActionRequest, lro::Operation>("ExecutePluginInstanceAction", grpcClient.ExecutePluginInstanceActionAsync, grpcClient.ExecutePluginInstanceAction, effectiveSettings.ExecutePluginInstanceActionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callExecutePluginInstanceAction);
            Modify_ExecutePluginInstanceActionApiCall(ref _callExecutePluginInstanceAction);
            _callGetPluginInstance = clientHelper.BuildApiCall<GetPluginInstanceRequest, PluginInstance>("GetPluginInstance", grpcClient.GetPluginInstanceAsync, grpcClient.GetPluginInstance, effectiveSettings.GetPluginInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPluginInstance);
            Modify_GetPluginInstanceApiCall(ref _callGetPluginInstance);
            _callListPluginInstances = clientHelper.BuildApiCall<ListPluginInstancesRequest, ListPluginInstancesResponse>("ListPluginInstances", grpcClient.ListPluginInstancesAsync, grpcClient.ListPluginInstances, effectiveSettings.ListPluginInstancesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPluginInstances);
            Modify_ListPluginInstancesApiCall(ref _callListPluginInstances);
            _callEnablePluginInstanceAction = clientHelper.BuildApiCall<EnablePluginInstanceActionRequest, lro::Operation>("EnablePluginInstanceAction", grpcClient.EnablePluginInstanceActionAsync, grpcClient.EnablePluginInstanceAction, effectiveSettings.EnablePluginInstanceActionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callEnablePluginInstanceAction);
            Modify_EnablePluginInstanceActionApiCall(ref _callEnablePluginInstanceAction);
            _callDisablePluginInstanceAction = clientHelper.BuildApiCall<DisablePluginInstanceActionRequest, lro::Operation>("DisablePluginInstanceAction", grpcClient.DisablePluginInstanceActionAsync, grpcClient.DisablePluginInstanceAction, effectiveSettings.DisablePluginInstanceActionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDisablePluginInstanceAction);
            Modify_DisablePluginInstanceActionApiCall(ref _callDisablePluginInstanceAction);
            _callUpdatePluginInstance = clientHelper.BuildApiCall<UpdatePluginInstanceRequest, PluginInstance>("UpdatePluginInstance", grpcClient.UpdatePluginInstanceAsync, grpcClient.UpdatePluginInstance, effectiveSettings.UpdatePluginInstanceSettings).WithGoogleRequestParam("plugin_instance.name", request => request.PluginInstance?.Name);
            Modify_ApiCall(ref _callUpdatePluginInstance);
            Modify_UpdatePluginInstanceApiCall(ref _callUpdatePluginInstance);
            _callDeletePluginInstance = clientHelper.BuildApiCall<DeletePluginInstanceRequest, lro::Operation>("DeletePluginInstance", grpcClient.DeletePluginInstanceAsync, grpcClient.DeletePluginInstance, effectiveSettings.DeletePluginInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeletePluginInstance);
            Modify_DeletePluginInstanceApiCall(ref _callDeletePluginInstance);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetPluginApiCall(ref gaxgrpc::ApiCall<GetPluginRequest, Plugin> call);

        partial void Modify_EnablePluginApiCall(ref gaxgrpc::ApiCall<EnablePluginRequest, Plugin> call);

        partial void Modify_DisablePluginApiCall(ref gaxgrpc::ApiCall<DisablePluginRequest, Plugin> call);

        partial void Modify_CreatePluginApiCall(ref gaxgrpc::ApiCall<CreatePluginRequest, Plugin> call);

        partial void Modify_ListPluginsApiCall(ref gaxgrpc::ApiCall<ListPluginsRequest, ListPluginsResponse> call);

        partial void Modify_DeletePluginApiCall(ref gaxgrpc::ApiCall<DeletePluginRequest, lro::Operation> call);

        partial void Modify_CreatePluginInstanceApiCall(ref gaxgrpc::ApiCall<CreatePluginInstanceRequest, lro::Operation> call);

        partial void Modify_ExecutePluginInstanceActionApiCall(ref gaxgrpc::ApiCall<ExecutePluginInstanceActionRequest, lro::Operation> call);

        partial void Modify_GetPluginInstanceApiCall(ref gaxgrpc::ApiCall<GetPluginInstanceRequest, PluginInstance> call);

        partial void Modify_ListPluginInstancesApiCall(ref gaxgrpc::ApiCall<ListPluginInstancesRequest, ListPluginInstancesResponse> call);

        partial void Modify_EnablePluginInstanceActionApiCall(ref gaxgrpc::ApiCall<EnablePluginInstanceActionRequest, lro::Operation> call);

        partial void Modify_DisablePluginInstanceActionApiCall(ref gaxgrpc::ApiCall<DisablePluginInstanceActionRequest, lro::Operation> call);

        partial void Modify_UpdatePluginInstanceApiCall(ref gaxgrpc::ApiCall<UpdatePluginInstanceRequest, PluginInstance> call);

        partial void Modify_DeletePluginInstanceApiCall(ref gaxgrpc::ApiCall<DeletePluginInstanceRequest, lro::Operation> call);

        partial void OnConstruction(ApiHubPlugin.ApiHubPluginClient grpcClient, ApiHubPluginSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ApiHubPlugin client</summary>
        public override ApiHubPlugin.ApiHubPluginClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_GetPluginRequest(ref GetPluginRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_EnablePluginRequest(ref EnablePluginRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DisablePluginRequest(ref DisablePluginRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreatePluginRequest(ref CreatePluginRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPluginsRequest(ref ListPluginsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeletePluginRequest(ref DeletePluginRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreatePluginInstanceRequest(ref CreatePluginInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExecutePluginInstanceActionRequest(ref ExecutePluginInstanceActionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPluginInstanceRequest(ref GetPluginInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPluginInstancesRequest(ref ListPluginInstancesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_EnablePluginInstanceActionRequest(ref EnablePluginInstanceActionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DisablePluginInstanceActionRequest(ref DisablePluginInstanceActionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdatePluginInstanceRequest(ref UpdatePluginInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeletePluginInstanceRequest(ref DeletePluginInstanceRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Get an API Hub plugin.
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
        /// Get an API Hub plugin.
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

        /// <summary>
        /// Create an API Hub plugin resource in the API hub.
        /// Once a plugin is created, it can be used to create plugin instances.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Plugin CreatePlugin(CreatePluginRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePluginRequest(ref request, ref callSettings);
            return _callCreatePlugin.Sync(request, callSettings);
        }

        /// <summary>
        /// Create an API Hub plugin resource in the API hub.
        /// Once a plugin is created, it can be used to create plugin instances.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Plugin> CreatePluginAsync(CreatePluginRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePluginRequest(ref request, ref callSettings);
            return _callCreatePlugin.Async(request, callSettings);
        }

        /// <summary>
        /// List all the plugins in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Plugin"/> resources.</returns>
        public override gax::PagedEnumerable<ListPluginsResponse, Plugin> ListPlugins(ListPluginsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPluginsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPluginsRequest, ListPluginsResponse, Plugin>(_callListPlugins, request, callSettings);
        }

        /// <summary>
        /// List all the plugins in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Plugin"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPluginsResponse, Plugin> ListPluginsAsync(ListPluginsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPluginsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPluginsRequest, ListPluginsResponse, Plugin>(_callListPlugins, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeletePlugin</c>.</summary>
        public override lro::OperationsClient DeletePluginOperationsClient { get; }

        /// <summary>
        /// Delete a Plugin in API hub.
        /// Note, only user owned plugins can be deleted via this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeletePlugin(DeletePluginRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePluginRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeletePlugin.Sync(request, callSettings), DeletePluginOperationsClient);
        }

        /// <summary>
        /// Delete a Plugin in API hub.
        /// Note, only user owned plugins can be deleted via this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePluginAsync(DeletePluginRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePluginRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeletePlugin.Async(request, callSettings).ConfigureAwait(false), DeletePluginOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreatePluginInstance</c>.</summary>
        public override lro::OperationsClient CreatePluginInstanceOperationsClient { get; }

        /// <summary>
        /// Creates a Plugin instance in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<PluginInstance, OperationMetadata> CreatePluginInstance(CreatePluginInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePluginInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<PluginInstance, OperationMetadata>(_callCreatePluginInstance.Sync(request, callSettings), CreatePluginInstanceOperationsClient);
        }

        /// <summary>
        /// Creates a Plugin instance in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<PluginInstance, OperationMetadata>> CreatePluginInstanceAsync(CreatePluginInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePluginInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<PluginInstance, OperationMetadata>(await _callCreatePluginInstance.Async(request, callSettings).ConfigureAwait(false), CreatePluginInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ExecutePluginInstanceAction</c>.</summary>
        public override lro::OperationsClient ExecutePluginInstanceActionOperationsClient { get; }

        /// <summary>
        /// Executes a plugin instance in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ExecutePluginInstanceActionResponse, OperationMetadata> ExecutePluginInstanceAction(ExecutePluginInstanceActionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExecutePluginInstanceActionRequest(ref request, ref callSettings);
            return new lro::Operation<ExecutePluginInstanceActionResponse, OperationMetadata>(_callExecutePluginInstanceAction.Sync(request, callSettings), ExecutePluginInstanceActionOperationsClient);
        }

        /// <summary>
        /// Executes a plugin instance in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ExecutePluginInstanceActionResponse, OperationMetadata>> ExecutePluginInstanceActionAsync(ExecutePluginInstanceActionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExecutePluginInstanceActionRequest(ref request, ref callSettings);
            return new lro::Operation<ExecutePluginInstanceActionResponse, OperationMetadata>(await _callExecutePluginInstanceAction.Async(request, callSettings).ConfigureAwait(false), ExecutePluginInstanceActionOperationsClient);
        }

        /// <summary>
        /// Get an API Hub plugin instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PluginInstance GetPluginInstance(GetPluginInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPluginInstanceRequest(ref request, ref callSettings);
            return _callGetPluginInstance.Sync(request, callSettings);
        }

        /// <summary>
        /// Get an API Hub plugin instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PluginInstance> GetPluginInstanceAsync(GetPluginInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPluginInstanceRequest(ref request, ref callSettings);
            return _callGetPluginInstance.Async(request, callSettings);
        }

        /// <summary>
        /// List all the plugins in a given project and location.
        /// `-` can be used as wildcard value for {plugin_id}
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PluginInstance"/> resources.</returns>
        public override gax::PagedEnumerable<ListPluginInstancesResponse, PluginInstance> ListPluginInstances(ListPluginInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPluginInstancesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPluginInstancesRequest, ListPluginInstancesResponse, PluginInstance>(_callListPluginInstances, request, callSettings);
        }

        /// <summary>
        /// List all the plugins in a given project and location.
        /// `-` can be used as wildcard value for {plugin_id}
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PluginInstance"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPluginInstancesResponse, PluginInstance> ListPluginInstancesAsync(ListPluginInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPluginInstancesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPluginInstancesRequest, ListPluginInstancesResponse, PluginInstance>(_callListPluginInstances, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>EnablePluginInstanceAction</c>.</summary>
        public override lro::OperationsClient EnablePluginInstanceActionOperationsClient { get; }

        /// <summary>
        /// Enables a plugin instance in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<EnablePluginInstanceActionResponse, OperationMetadata> EnablePluginInstanceAction(EnablePluginInstanceActionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnablePluginInstanceActionRequest(ref request, ref callSettings);
            return new lro::Operation<EnablePluginInstanceActionResponse, OperationMetadata>(_callEnablePluginInstanceAction.Sync(request, callSettings), EnablePluginInstanceActionOperationsClient);
        }

        /// <summary>
        /// Enables a plugin instance in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<EnablePluginInstanceActionResponse, OperationMetadata>> EnablePluginInstanceActionAsync(EnablePluginInstanceActionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnablePluginInstanceActionRequest(ref request, ref callSettings);
            return new lro::Operation<EnablePluginInstanceActionResponse, OperationMetadata>(await _callEnablePluginInstanceAction.Async(request, callSettings).ConfigureAwait(false), EnablePluginInstanceActionOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DisablePluginInstanceAction</c>.</summary>
        public override lro::OperationsClient DisablePluginInstanceActionOperationsClient { get; }

        /// <summary>
        /// Disables a plugin instance in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DisablePluginInstanceActionResponse, OperationMetadata> DisablePluginInstanceAction(DisablePluginInstanceActionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DisablePluginInstanceActionRequest(ref request, ref callSettings);
            return new lro::Operation<DisablePluginInstanceActionResponse, OperationMetadata>(_callDisablePluginInstanceAction.Sync(request, callSettings), DisablePluginInstanceActionOperationsClient);
        }

        /// <summary>
        /// Disables a plugin instance in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DisablePluginInstanceActionResponse, OperationMetadata>> DisablePluginInstanceActionAsync(DisablePluginInstanceActionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DisablePluginInstanceActionRequest(ref request, ref callSettings);
            return new lro::Operation<DisablePluginInstanceActionResponse, OperationMetadata>(await _callDisablePluginInstanceAction.Async(request, callSettings).ConfigureAwait(false), DisablePluginInstanceActionOperationsClient);
        }

        /// <summary>
        /// Updates a plugin instance in the API hub.
        /// The following fields in the
        /// [plugin_instance][google.cloud.apihub.v1.PluginInstance] can be updated
        /// currently:
        /// 
        /// * [display_name][google.cloud.apihub.v1.PluginInstance.display_name]
        /// * [schedule_cron_expression][PluginInstance.actions.schedule_cron_expression]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdatePluginInstanceRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// 
        /// To update the
        /// [auth_config][google.cloud.apihub.v1.PluginInstance.auth_config] and
        /// [additional_config][google.cloud.apihub.v1.PluginInstance.additional_config]
        /// of the plugin instance, use the
        /// [ApplyPluginInstanceConfig][google.cloud.apihub.v1.ApiHubPlugin.ApplyPluginInstanceConfig]
        /// method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PluginInstance UpdatePluginInstance(UpdatePluginInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePluginInstanceRequest(ref request, ref callSettings);
            return _callUpdatePluginInstance.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a plugin instance in the API hub.
        /// The following fields in the
        /// [plugin_instance][google.cloud.apihub.v1.PluginInstance] can be updated
        /// currently:
        /// 
        /// * [display_name][google.cloud.apihub.v1.PluginInstance.display_name]
        /// * [schedule_cron_expression][PluginInstance.actions.schedule_cron_expression]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdatePluginInstanceRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// 
        /// To update the
        /// [auth_config][google.cloud.apihub.v1.PluginInstance.auth_config] and
        /// [additional_config][google.cloud.apihub.v1.PluginInstance.additional_config]
        /// of the plugin instance, use the
        /// [ApplyPluginInstanceConfig][google.cloud.apihub.v1.ApiHubPlugin.ApplyPluginInstanceConfig]
        /// method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PluginInstance> UpdatePluginInstanceAsync(UpdatePluginInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePluginInstanceRequest(ref request, ref callSettings);
            return _callUpdatePluginInstance.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeletePluginInstance</c>.</summary>
        public override lro::OperationsClient DeletePluginInstanceOperationsClient { get; }

        /// <summary>
        /// Deletes a plugin instance in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeletePluginInstance(DeletePluginInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePluginInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeletePluginInstance.Sync(request, callSettings), DeletePluginInstanceOperationsClient);
        }

        /// <summary>
        /// Deletes a plugin instance in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePluginInstanceAsync(DeletePluginInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePluginInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeletePluginInstance.Async(request, callSettings).ConfigureAwait(false), DeletePluginInstanceOperationsClient);
        }
    }

    public partial class ListPluginsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPluginInstancesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPluginsResponse : gaxgrpc::IPageResponse<Plugin>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Plugin> GetEnumerator() => Plugins.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListPluginInstancesResponse : gaxgrpc::IPageResponse<PluginInstance>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PluginInstance> GetEnumerator() => PluginInstances.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ApiHubPlugin
    {
        public partial class ApiHubPluginClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() =>
                new lro::Operations.OperationsClient(CallInvoker);
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
