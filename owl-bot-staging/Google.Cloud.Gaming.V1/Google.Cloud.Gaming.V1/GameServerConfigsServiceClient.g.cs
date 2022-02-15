// Copyright 2022 Google LLC
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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Gaming.V1
{
    /// <summary>Settings for <see cref="GameServerConfigsServiceClient"/> instances.</summary>
    public sealed partial class GameServerConfigsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="GameServerConfigsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="GameServerConfigsServiceSettings"/>.</returns>
        public static GameServerConfigsServiceSettings GetDefault() => new GameServerConfigsServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="GameServerConfigsServiceSettings"/> object with default settings.
        /// </summary>
        public GameServerConfigsServiceSettings()
        {
        }

        private GameServerConfigsServiceSettings(GameServerConfigsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListGameServerConfigsSettings = existing.ListGameServerConfigsSettings;
            GetGameServerConfigSettings = existing.GetGameServerConfigSettings;
            CreateGameServerConfigSettings = existing.CreateGameServerConfigSettings;
            CreateGameServerConfigOperationsSettings = existing.CreateGameServerConfigOperationsSettings.Clone();
            DeleteGameServerConfigSettings = existing.DeleteGameServerConfigSettings;
            DeleteGameServerConfigOperationsSettings = existing.DeleteGameServerConfigOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(GameServerConfigsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GameServerConfigsServiceClient.ListGameServerConfigs</c> and
        /// <c>GameServerConfigsServiceClient.ListGameServerConfigsAsync</c>.
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
        public gaxgrpc::CallSettings ListGameServerConfigsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GameServerConfigsServiceClient.GetGameServerConfig</c> and
        /// <c>GameServerConfigsServiceClient.GetGameServerConfigAsync</c>.
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
        public gaxgrpc::CallSettings GetGameServerConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GameServerConfigsServiceClient.CreateGameServerConfig</c> and
        /// <c>GameServerConfigsServiceClient.CreateGameServerConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateGameServerConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GameServerConfigsServiceClient.CreateGameServerConfig</c>
        /// and <c>GameServerConfigsServiceClient.CreateGameServerConfigAsync</c>.
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
        public lro::OperationsSettings CreateGameServerConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GameServerConfigsServiceClient.DeleteGameServerConfig</c> and
        /// <c>GameServerConfigsServiceClient.DeleteGameServerConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteGameServerConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GameServerConfigsServiceClient.DeleteGameServerConfig</c>
        /// and <c>GameServerConfigsServiceClient.DeleteGameServerConfigAsync</c>.
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
        public lro::OperationsSettings DeleteGameServerConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="GameServerConfigsServiceSettings"/> object.</returns>
        public GameServerConfigsServiceSettings Clone() => new GameServerConfigsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="GameServerConfigsServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class GameServerConfigsServiceClientBuilder : gaxgrpc::ClientBuilderBase<GameServerConfigsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public GameServerConfigsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public GameServerConfigsServiceClientBuilder()
        {
            UseJwtAccessWithScopes = GameServerConfigsServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref GameServerConfigsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<GameServerConfigsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override GameServerConfigsServiceClient Build()
        {
            GameServerConfigsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<GameServerConfigsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<GameServerConfigsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private GameServerConfigsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return GameServerConfigsServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<GameServerConfigsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return GameServerConfigsServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => GameServerConfigsServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => GameServerConfigsServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => GameServerConfigsServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>GameServerConfigsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The game server config configures the game servers in an Agones fleet.
    /// </remarks>
    public abstract partial class GameServerConfigsServiceClient
    {
        /// <summary>
        /// The default endpoint for the GameServerConfigsService service, which is a host of
        /// "gameservices.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "gameservices.googleapis.com:443";

        /// <summary>The default GameServerConfigsService scopes.</summary>
        /// <remarks>
        /// The default GameServerConfigsService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes, UseJwtAccessWithScopes);

        internal static bool UseJwtAccessWithScopes
        {
            get
            {
                bool useJwtAccessWithScopes = true;
                MaybeUseJwtAccessWithScopes(ref useJwtAccessWithScopes);
                return useJwtAccessWithScopes;
            }
        }

        static partial void MaybeUseJwtAccessWithScopes(ref bool useJwtAccessWithScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="GameServerConfigsServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="GameServerConfigsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="GameServerConfigsServiceClient"/>.</returns>
        public static stt::Task<GameServerConfigsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new GameServerConfigsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="GameServerConfigsServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="GameServerConfigsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="GameServerConfigsServiceClient"/>.</returns>
        public static GameServerConfigsServiceClient Create() => new GameServerConfigsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="GameServerConfigsServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="GameServerConfigsServiceSettings"/>.</param>
        /// <returns>The created <see cref="GameServerConfigsServiceClient"/>.</returns>
        internal static GameServerConfigsServiceClient Create(grpccore::CallInvoker callInvoker, GameServerConfigsServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            GameServerConfigsService.GameServerConfigsServiceClient grpcClient = new GameServerConfigsService.GameServerConfigsServiceClient(callInvoker);
            return new GameServerConfigsServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC GameServerConfigsService client</summary>
        public virtual GameServerConfigsService.GameServerConfigsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists game server configs in a given project, location, and game server
        /// deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GameServerConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGameServerConfigsResponse, GameServerConfig> ListGameServerConfigs(ListGameServerConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists game server configs in a given project, location, and game server
        /// deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GameServerConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGameServerConfigsResponse, GameServerConfig> ListGameServerConfigsAsync(ListGameServerConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists game server configs in a given project, location, and game server
        /// deployment.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, in the following form:
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/configs/*`.
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
        /// <returns>A pageable sequence of <see cref="GameServerConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGameServerConfigsResponse, GameServerConfig> ListGameServerConfigs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListGameServerConfigs(new ListGameServerConfigsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists game server configs in a given project, location, and game server
        /// deployment.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, in the following form:
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/configs/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="GameServerConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGameServerConfigsResponse, GameServerConfig> ListGameServerConfigsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListGameServerConfigsAsync(new ListGameServerConfigsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists game server configs in a given project, location, and game server
        /// deployment.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, in the following form:
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/configs/*`.
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
        /// <returns>A pageable sequence of <see cref="GameServerConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGameServerConfigsResponse, GameServerConfig> ListGameServerConfigs(GameServerDeploymentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListGameServerConfigs(new ListGameServerConfigsRequest
            {
                ParentAsGameServerDeploymentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists game server configs in a given project, location, and game server
        /// deployment.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, in the following form:
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/configs/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="GameServerConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGameServerConfigsResponse, GameServerConfig> ListGameServerConfigsAsync(GameServerDeploymentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListGameServerConfigsAsync(new ListGameServerConfigsRequest
            {
                ParentAsGameServerDeploymentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets details of a single game server config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GameServerConfig GetGameServerConfig(GetGameServerConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single game server config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GameServerConfig> GetGameServerConfigAsync(GetGameServerConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single game server config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GameServerConfig> GetGameServerConfigAsync(GetGameServerConfigRequest request, st::CancellationToken cancellationToken) =>
            GetGameServerConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single game server config.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the game server config to retrieve, in the following form:
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/configs/{config}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GameServerConfig GetGameServerConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGameServerConfig(new GetGameServerConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single game server config.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the game server config to retrieve, in the following form:
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/configs/{config}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GameServerConfig> GetGameServerConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGameServerConfigAsync(new GetGameServerConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single game server config.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the game server config to retrieve, in the following form:
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/configs/{config}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GameServerConfig> GetGameServerConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetGameServerConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single game server config.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the game server config to retrieve, in the following form:
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/configs/{config}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GameServerConfig GetGameServerConfig(GameServerConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGameServerConfig(new GetGameServerConfigRequest
            {
                GameServerConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single game server config.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the game server config to retrieve, in the following form:
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/configs/{config}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GameServerConfig> GetGameServerConfigAsync(GameServerConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGameServerConfigAsync(new GetGameServerConfigRequest
            {
                GameServerConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single game server config.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the game server config to retrieve, in the following form:
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/configs/{config}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GameServerConfig> GetGameServerConfigAsync(GameServerConfigName name, st::CancellationToken cancellationToken) =>
            GetGameServerConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new game server config in a given project, location, and game
        /// server deployment. Game server configs are immutable, and are not applied
        /// until referenced in the game server deployment rollout resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GameServerConfig, OperationMetadata> CreateGameServerConfig(CreateGameServerConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new game server config in a given project, location, and game
        /// server deployment. Game server configs are immutable, and are not applied
        /// until referenced in the game server deployment rollout resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GameServerConfig, OperationMetadata>> CreateGameServerConfigAsync(CreateGameServerConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new game server config in a given project, location, and game
        /// server deployment. Game server configs are immutable, and are not applied
        /// until referenced in the game server deployment rollout resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GameServerConfig, OperationMetadata>> CreateGameServerConfigAsync(CreateGameServerConfigRequest request, st::CancellationToken cancellationToken) =>
            CreateGameServerConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateGameServerConfig</c>.</summary>
        public virtual lro::OperationsClient CreateGameServerConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateGameServerConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<GameServerConfig, OperationMetadata> PollOnceCreateGameServerConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GameServerConfig, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateGameServerConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateGameServerConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<GameServerConfig, OperationMetadata>> PollOnceCreateGameServerConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GameServerConfig, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateGameServerConfigOperationsClient, callSettings);

        /// <summary>
        /// Creates a new game server config in a given project, location, and game
        /// server deployment. Game server configs are immutable, and are not applied
        /// until referenced in the game server deployment rollout resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, in the following form:
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/`.
        /// </param>
        /// <param name="gameServerConfig">
        /// Required. The game server config resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GameServerConfig, OperationMetadata> CreateGameServerConfig(string parent, GameServerConfig gameServerConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateGameServerConfig(new CreateGameServerConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                GameServerConfig = gax::GaxPreconditions.CheckNotNull(gameServerConfig, nameof(gameServerConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new game server config in a given project, location, and game
        /// server deployment. Game server configs are immutable, and are not applied
        /// until referenced in the game server deployment rollout resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, in the following form:
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/`.
        /// </param>
        /// <param name="gameServerConfig">
        /// Required. The game server config resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GameServerConfig, OperationMetadata>> CreateGameServerConfigAsync(string parent, GameServerConfig gameServerConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateGameServerConfigAsync(new CreateGameServerConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                GameServerConfig = gax::GaxPreconditions.CheckNotNull(gameServerConfig, nameof(gameServerConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new game server config in a given project, location, and game
        /// server deployment. Game server configs are immutable, and are not applied
        /// until referenced in the game server deployment rollout resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, in the following form:
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/`.
        /// </param>
        /// <param name="gameServerConfig">
        /// Required. The game server config resource to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GameServerConfig, OperationMetadata>> CreateGameServerConfigAsync(string parent, GameServerConfig gameServerConfig, st::CancellationToken cancellationToken) =>
            CreateGameServerConfigAsync(parent, gameServerConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new game server config in a given project, location, and game
        /// server deployment. Game server configs are immutable, and are not applied
        /// until referenced in the game server deployment rollout resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, in the following form:
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/`.
        /// </param>
        /// <param name="gameServerConfig">
        /// Required. The game server config resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GameServerConfig, OperationMetadata> CreateGameServerConfig(GameServerDeploymentName parent, GameServerConfig gameServerConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateGameServerConfig(new CreateGameServerConfigRequest
            {
                ParentAsGameServerDeploymentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                GameServerConfig = gax::GaxPreconditions.CheckNotNull(gameServerConfig, nameof(gameServerConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new game server config in a given project, location, and game
        /// server deployment. Game server configs are immutable, and are not applied
        /// until referenced in the game server deployment rollout resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, in the following form:
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/`.
        /// </param>
        /// <param name="gameServerConfig">
        /// Required. The game server config resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GameServerConfig, OperationMetadata>> CreateGameServerConfigAsync(GameServerDeploymentName parent, GameServerConfig gameServerConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateGameServerConfigAsync(new CreateGameServerConfigRequest
            {
                ParentAsGameServerDeploymentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                GameServerConfig = gax::GaxPreconditions.CheckNotNull(gameServerConfig, nameof(gameServerConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new game server config in a given project, location, and game
        /// server deployment. Game server configs are immutable, and are not applied
        /// until referenced in the game server deployment rollout resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, in the following form:
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/`.
        /// </param>
        /// <param name="gameServerConfig">
        /// Required. The game server config resource to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GameServerConfig, OperationMetadata>> CreateGameServerConfigAsync(GameServerDeploymentName parent, GameServerConfig gameServerConfig, st::CancellationToken cancellationToken) =>
            CreateGameServerConfigAsync(parent, gameServerConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single game server config. The deletion will fail if the game
        /// server config is referenced in a game server deployment rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteGameServerConfig(DeleteGameServerConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single game server config. The deletion will fail if the game
        /// server config is referenced in a game server deployment rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGameServerConfigAsync(DeleteGameServerConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single game server config. The deletion will fail if the game
        /// server config is referenced in a game server deployment rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGameServerConfigAsync(DeleteGameServerConfigRequest request, st::CancellationToken cancellationToken) =>
            DeleteGameServerConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteGameServerConfig</c>.</summary>
        public virtual lro::OperationsClient DeleteGameServerConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteGameServerConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteGameServerConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteGameServerConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteGameServerConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteGameServerConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteGameServerConfigOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single game server config. The deletion will fail if the game
        /// server config is referenced in a game server deployment rollout.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the game server config to delete, in the following form:
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/configs/{config}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteGameServerConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGameServerConfig(new DeleteGameServerConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single game server config. The deletion will fail if the game
        /// server config is referenced in a game server deployment rollout.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the game server config to delete, in the following form:
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/configs/{config}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGameServerConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGameServerConfigAsync(new DeleteGameServerConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single game server config. The deletion will fail if the game
        /// server config is referenced in a game server deployment rollout.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the game server config to delete, in the following form:
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/configs/{config}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGameServerConfigAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteGameServerConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single game server config. The deletion will fail if the game
        /// server config is referenced in a game server deployment rollout.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the game server config to delete, in the following form:
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/configs/{config}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteGameServerConfig(GameServerConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGameServerConfig(new DeleteGameServerConfigRequest
            {
                GameServerConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single game server config. The deletion will fail if the game
        /// server config is referenced in a game server deployment rollout.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the game server config to delete, in the following form:
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/configs/{config}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGameServerConfigAsync(GameServerConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGameServerConfigAsync(new DeleteGameServerConfigRequest
            {
                GameServerConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single game server config. The deletion will fail if the game
        /// server config is referenced in a game server deployment rollout.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the game server config to delete, in the following form:
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/configs/{config}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGameServerConfigAsync(GameServerConfigName name, st::CancellationToken cancellationToken) =>
            DeleteGameServerConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>GameServerConfigsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The game server config configures the game servers in an Agones fleet.
    /// </remarks>
    public sealed partial class GameServerConfigsServiceClientImpl : GameServerConfigsServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListGameServerConfigsRequest, ListGameServerConfigsResponse> _callListGameServerConfigs;

        private readonly gaxgrpc::ApiCall<GetGameServerConfigRequest, GameServerConfig> _callGetGameServerConfig;

        private readonly gaxgrpc::ApiCall<CreateGameServerConfigRequest, lro::Operation> _callCreateGameServerConfig;

        private readonly gaxgrpc::ApiCall<DeleteGameServerConfigRequest, lro::Operation> _callDeleteGameServerConfig;

        /// <summary>
        /// Constructs a client wrapper for the GameServerConfigsService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="GameServerConfigsServiceSettings"/> used within this client.
        /// </param>
        public GameServerConfigsServiceClientImpl(GameServerConfigsService.GameServerConfigsServiceClient grpcClient, GameServerConfigsServiceSettings settings)
        {
            GrpcClient = grpcClient;
            GameServerConfigsServiceSettings effectiveSettings = settings ?? GameServerConfigsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            CreateGameServerConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateGameServerConfigOperationsSettings);
            DeleteGameServerConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteGameServerConfigOperationsSettings);
            _callListGameServerConfigs = clientHelper.BuildApiCall<ListGameServerConfigsRequest, ListGameServerConfigsResponse>(grpcClient.ListGameServerConfigsAsync, grpcClient.ListGameServerConfigs, effectiveSettings.ListGameServerConfigsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListGameServerConfigs);
            Modify_ListGameServerConfigsApiCall(ref _callListGameServerConfigs);
            _callGetGameServerConfig = clientHelper.BuildApiCall<GetGameServerConfigRequest, GameServerConfig>(grpcClient.GetGameServerConfigAsync, grpcClient.GetGameServerConfig, effectiveSettings.GetGameServerConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetGameServerConfig);
            Modify_GetGameServerConfigApiCall(ref _callGetGameServerConfig);
            _callCreateGameServerConfig = clientHelper.BuildApiCall<CreateGameServerConfigRequest, lro::Operation>(grpcClient.CreateGameServerConfigAsync, grpcClient.CreateGameServerConfig, effectiveSettings.CreateGameServerConfigSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateGameServerConfig);
            Modify_CreateGameServerConfigApiCall(ref _callCreateGameServerConfig);
            _callDeleteGameServerConfig = clientHelper.BuildApiCall<DeleteGameServerConfigRequest, lro::Operation>(grpcClient.DeleteGameServerConfigAsync, grpcClient.DeleteGameServerConfig, effectiveSettings.DeleteGameServerConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteGameServerConfig);
            Modify_DeleteGameServerConfigApiCall(ref _callDeleteGameServerConfig);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListGameServerConfigsApiCall(ref gaxgrpc::ApiCall<ListGameServerConfigsRequest, ListGameServerConfigsResponse> call);

        partial void Modify_GetGameServerConfigApiCall(ref gaxgrpc::ApiCall<GetGameServerConfigRequest, GameServerConfig> call);

        partial void Modify_CreateGameServerConfigApiCall(ref gaxgrpc::ApiCall<CreateGameServerConfigRequest, lro::Operation> call);

        partial void Modify_DeleteGameServerConfigApiCall(ref gaxgrpc::ApiCall<DeleteGameServerConfigRequest, lro::Operation> call);

        partial void OnConstruction(GameServerConfigsService.GameServerConfigsServiceClient grpcClient, GameServerConfigsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC GameServerConfigsService client</summary>
        public override GameServerConfigsService.GameServerConfigsServiceClient GrpcClient { get; }

        partial void Modify_ListGameServerConfigsRequest(ref ListGameServerConfigsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetGameServerConfigRequest(ref GetGameServerConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateGameServerConfigRequest(ref CreateGameServerConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteGameServerConfigRequest(ref DeleteGameServerConfigRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists game server configs in a given project, location, and game server
        /// deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GameServerConfig"/> resources.</returns>
        public override gax::PagedEnumerable<ListGameServerConfigsResponse, GameServerConfig> ListGameServerConfigs(ListGameServerConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGameServerConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListGameServerConfigsRequest, ListGameServerConfigsResponse, GameServerConfig>(_callListGameServerConfigs, request, callSettings);
        }

        /// <summary>
        /// Lists game server configs in a given project, location, and game server
        /// deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GameServerConfig"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListGameServerConfigsResponse, GameServerConfig> ListGameServerConfigsAsync(ListGameServerConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGameServerConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListGameServerConfigsRequest, ListGameServerConfigsResponse, GameServerConfig>(_callListGameServerConfigs, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single game server config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GameServerConfig GetGameServerConfig(GetGameServerConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGameServerConfigRequest(ref request, ref callSettings);
            return _callGetGameServerConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single game server config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GameServerConfig> GetGameServerConfigAsync(GetGameServerConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGameServerConfigRequest(ref request, ref callSettings);
            return _callGetGameServerConfig.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateGameServerConfig</c>.</summary>
        public override lro::OperationsClient CreateGameServerConfigOperationsClient { get; }

        /// <summary>
        /// Creates a new game server config in a given project, location, and game
        /// server deployment. Game server configs are immutable, and are not applied
        /// until referenced in the game server deployment rollout resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<GameServerConfig, OperationMetadata> CreateGameServerConfig(CreateGameServerConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGameServerConfigRequest(ref request, ref callSettings);
            return new lro::Operation<GameServerConfig, OperationMetadata>(_callCreateGameServerConfig.Sync(request, callSettings), CreateGameServerConfigOperationsClient);
        }

        /// <summary>
        /// Creates a new game server config in a given project, location, and game
        /// server deployment. Game server configs are immutable, and are not applied
        /// until referenced in the game server deployment rollout resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<GameServerConfig, OperationMetadata>> CreateGameServerConfigAsync(CreateGameServerConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGameServerConfigRequest(ref request, ref callSettings);
            return new lro::Operation<GameServerConfig, OperationMetadata>(await _callCreateGameServerConfig.Async(request, callSettings).ConfigureAwait(false), CreateGameServerConfigOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteGameServerConfig</c>.</summary>
        public override lro::OperationsClient DeleteGameServerConfigOperationsClient { get; }

        /// <summary>
        /// Deletes a single game server config. The deletion will fail if the game
        /// server config is referenced in a game server deployment rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteGameServerConfig(DeleteGameServerConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGameServerConfigRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteGameServerConfig.Sync(request, callSettings), DeleteGameServerConfigOperationsClient);
        }

        /// <summary>
        /// Deletes a single game server config. The deletion will fail if the game
        /// server config is referenced in a game server deployment rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGameServerConfigAsync(DeleteGameServerConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGameServerConfigRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteGameServerConfig.Async(request, callSettings).ConfigureAwait(false), DeleteGameServerConfigOperationsClient);
        }
    }

    public partial class ListGameServerConfigsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListGameServerConfigsResponse : gaxgrpc::IPageResponse<GameServerConfig>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<GameServerConfig> GetEnumerator() => GameServerConfigs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class GameServerConfigsService
    {
        public partial class GameServerConfigsServiceClient
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
}
