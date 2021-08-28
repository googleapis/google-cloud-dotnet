// Copyright 2021 Google LLC
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
    /// <summary>Settings for <see cref="GameServerClustersServiceClient"/> instances.</summary>
    public sealed partial class GameServerClustersServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="GameServerClustersServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="GameServerClustersServiceSettings"/>.</returns>
        public static GameServerClustersServiceSettings GetDefault() => new GameServerClustersServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="GameServerClustersServiceSettings"/> object with default settings.
        /// </summary>
        public GameServerClustersServiceSettings()
        {
        }

        private GameServerClustersServiceSettings(GameServerClustersServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListGameServerClustersSettings = existing.ListGameServerClustersSettings;
            GetGameServerClusterSettings = existing.GetGameServerClusterSettings;
            CreateGameServerClusterSettings = existing.CreateGameServerClusterSettings;
            CreateGameServerClusterOperationsSettings = existing.CreateGameServerClusterOperationsSettings.Clone();
            PreviewCreateGameServerClusterSettings = existing.PreviewCreateGameServerClusterSettings;
            DeleteGameServerClusterSettings = existing.DeleteGameServerClusterSettings;
            DeleteGameServerClusterOperationsSettings = existing.DeleteGameServerClusterOperationsSettings.Clone();
            PreviewDeleteGameServerClusterSettings = existing.PreviewDeleteGameServerClusterSettings;
            UpdateGameServerClusterSettings = existing.UpdateGameServerClusterSettings;
            UpdateGameServerClusterOperationsSettings = existing.UpdateGameServerClusterOperationsSettings.Clone();
            PreviewUpdateGameServerClusterSettings = existing.PreviewUpdateGameServerClusterSettings;
            OnCopy(existing);
        }

        partial void OnCopy(GameServerClustersServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GameServerClustersServiceClient.ListGameServerClusters</c> and
        /// <c>GameServerClustersServiceClient.ListGameServerClustersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListGameServerClustersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GameServerClustersServiceClient.GetGameServerCluster</c> and
        /// <c>GameServerClustersServiceClient.GetGameServerClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetGameServerClusterSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GameServerClustersServiceClient.CreateGameServerCluster</c> and
        /// <c>GameServerClustersServiceClient.CreateGameServerClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateGameServerClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GameServerClustersServiceClient.CreateGameServerCluster</c>
        /// and <c>GameServerClustersServiceClient.CreateGameServerClusterAsync</c>.
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
        public lro::OperationsSettings CreateGameServerClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GameServerClustersServiceClient.PreviewCreateGameServerCluster</c> and
        /// <c>GameServerClustersServiceClient.PreviewCreateGameServerClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PreviewCreateGameServerClusterSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GameServerClustersServiceClient.DeleteGameServerCluster</c> and
        /// <c>GameServerClustersServiceClient.DeleteGameServerClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteGameServerClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GameServerClustersServiceClient.DeleteGameServerCluster</c>
        /// and <c>GameServerClustersServiceClient.DeleteGameServerClusterAsync</c>.
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
        public lro::OperationsSettings DeleteGameServerClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GameServerClustersServiceClient.PreviewDeleteGameServerCluster</c> and
        /// <c>GameServerClustersServiceClient.PreviewDeleteGameServerClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PreviewDeleteGameServerClusterSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GameServerClustersServiceClient.UpdateGameServerCluster</c> and
        /// <c>GameServerClustersServiceClient.UpdateGameServerClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateGameServerClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GameServerClustersServiceClient.UpdateGameServerCluster</c>
        /// and <c>GameServerClustersServiceClient.UpdateGameServerClusterAsync</c>.
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
        public lro::OperationsSettings UpdateGameServerClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GameServerClustersServiceClient.PreviewUpdateGameServerCluster</c> and
        /// <c>GameServerClustersServiceClient.PreviewUpdateGameServerClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PreviewUpdateGameServerClusterSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="GameServerClustersServiceSettings"/> object.</returns>
        public GameServerClustersServiceSettings Clone() => new GameServerClustersServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="GameServerClustersServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class GameServerClustersServiceClientBuilder : gaxgrpc::ClientBuilderBase<GameServerClustersServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public GameServerClustersServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public GameServerClustersServiceClientBuilder()
        {
            UseJwtAccessWithScopes = GameServerClustersServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref GameServerClustersServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<GameServerClustersServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override GameServerClustersServiceClient Build()
        {
            GameServerClustersServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<GameServerClustersServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<GameServerClustersServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private GameServerClustersServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return GameServerClustersServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<GameServerClustersServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return GameServerClustersServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => GameServerClustersServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => GameServerClustersServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => GameServerClustersServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>GameServerClustersService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The game server cluster maps to Kubernetes clusters running Agones and is
    /// used to manage fleets within clusters.
    /// </remarks>
    public abstract partial class GameServerClustersServiceClient
    {
        /// <summary>
        /// The default endpoint for the GameServerClustersService service, which is a host of
        /// "gameservices.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "gameservices.googleapis.com:443";

        /// <summary>The default GameServerClustersService scopes.</summary>
        /// <remarks>
        /// The default GameServerClustersService scopes are:
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
        /// Asynchronously creates a <see cref="GameServerClustersServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="GameServerClustersServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="GameServerClustersServiceClient"/>.</returns>
        public static stt::Task<GameServerClustersServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new GameServerClustersServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="GameServerClustersServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="GameServerClustersServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="GameServerClustersServiceClient"/>.</returns>
        public static GameServerClustersServiceClient Create() => new GameServerClustersServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="GameServerClustersServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="GameServerClustersServiceSettings"/>.</param>
        /// <returns>The created <see cref="GameServerClustersServiceClient"/>.</returns>
        internal static GameServerClustersServiceClient Create(grpccore::CallInvoker callInvoker, GameServerClustersServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            GameServerClustersService.GameServerClustersServiceClient grpcClient = new GameServerClustersService.GameServerClustersServiceClient(callInvoker);
            return new GameServerClustersServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC GameServerClustersService client</summary>
        public virtual GameServerClustersService.GameServerClustersServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists game server clusters in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GameServerCluster"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGameServerClustersResponse, GameServerCluster> ListGameServerClusters(ListGameServerClustersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists game server clusters in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GameServerCluster"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGameServerClustersResponse, GameServerCluster> ListGameServerClustersAsync(ListGameServerClustersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists game server clusters in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, in the following form:
        /// "projects/{project}/locations/{location}/realms/{realm}".
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
        /// <returns>A pageable sequence of <see cref="GameServerCluster"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGameServerClustersResponse, GameServerCluster> ListGameServerClusters(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListGameServerClusters(new ListGameServerClustersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists game server clusters in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, in the following form:
        /// "projects/{project}/locations/{location}/realms/{realm}".
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
        /// <returns>A pageable asynchronous sequence of <see cref="GameServerCluster"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGameServerClustersResponse, GameServerCluster> ListGameServerClustersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListGameServerClustersAsync(new ListGameServerClustersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists game server clusters in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, in the following form:
        /// "projects/{project}/locations/{location}/realms/{realm}".
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
        /// <returns>A pageable sequence of <see cref="GameServerCluster"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGameServerClustersResponse, GameServerCluster> ListGameServerClusters(RealmName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListGameServerClusters(new ListGameServerClustersRequest
            {
                ParentAsRealmName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists game server clusters in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, in the following form:
        /// "projects/{project}/locations/{location}/realms/{realm}".
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
        /// <returns>A pageable asynchronous sequence of <see cref="GameServerCluster"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGameServerClustersResponse, GameServerCluster> ListGameServerClustersAsync(RealmName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListGameServerClustersAsync(new ListGameServerClustersRequest
            {
                ParentAsRealmName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets details of a single game server cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GameServerCluster GetGameServerCluster(GetGameServerClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single game server cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GameServerCluster> GetGameServerClusterAsync(GetGameServerClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single game server cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GameServerCluster> GetGameServerClusterAsync(GetGameServerClusterRequest request, st::CancellationToken cancellationToken) =>
            GetGameServerClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single game server cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the game server cluster to retrieve, in the following form:
        /// `projects/{project}/locations/{location}/realms/{realm-id}/gameServerClusters/{cluster}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GameServerCluster GetGameServerCluster(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGameServerCluster(new GetGameServerClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single game server cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the game server cluster to retrieve, in the following form:
        /// `projects/{project}/locations/{location}/realms/{realm-id}/gameServerClusters/{cluster}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GameServerCluster> GetGameServerClusterAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGameServerClusterAsync(new GetGameServerClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single game server cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the game server cluster to retrieve, in the following form:
        /// `projects/{project}/locations/{location}/realms/{realm-id}/gameServerClusters/{cluster}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GameServerCluster> GetGameServerClusterAsync(string name, st::CancellationToken cancellationToken) =>
            GetGameServerClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single game server cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the game server cluster to retrieve, in the following form:
        /// `projects/{project}/locations/{location}/realms/{realm-id}/gameServerClusters/{cluster}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GameServerCluster GetGameServerCluster(GameServerClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGameServerCluster(new GetGameServerClusterRequest
            {
                GameServerClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single game server cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the game server cluster to retrieve, in the following form:
        /// `projects/{project}/locations/{location}/realms/{realm-id}/gameServerClusters/{cluster}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GameServerCluster> GetGameServerClusterAsync(GameServerClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGameServerClusterAsync(new GetGameServerClusterRequest
            {
                GameServerClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single game server cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the game server cluster to retrieve, in the following form:
        /// `projects/{project}/locations/{location}/realms/{realm-id}/gameServerClusters/{cluster}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GameServerCluster> GetGameServerClusterAsync(GameServerClusterName name, st::CancellationToken cancellationToken) =>
            GetGameServerClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new game server cluster in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GameServerCluster, OperationMetadata> CreateGameServerCluster(CreateGameServerClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new game server cluster in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GameServerCluster, OperationMetadata>> CreateGameServerClusterAsync(CreateGameServerClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new game server cluster in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GameServerCluster, OperationMetadata>> CreateGameServerClusterAsync(CreateGameServerClusterRequest request, st::CancellationToken cancellationToken) =>
            CreateGameServerClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateGameServerCluster</c>.</summary>
        public virtual lro::OperationsClient CreateGameServerClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateGameServerCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<GameServerCluster, OperationMetadata> PollOnceCreateGameServerCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GameServerCluster, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateGameServerClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateGameServerCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<GameServerCluster, OperationMetadata>> PollOnceCreateGameServerClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GameServerCluster, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateGameServerClusterOperationsClient, callSettings);

        /// <summary>
        /// Creates a new game server cluster in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, in the following form:
        /// `projects/{project}/locations/{location}/realms/{realm-id}`.
        /// </param>
        /// <param name="gameServerCluster">
        /// Required. The game server cluster resource to be created.
        /// </param>
        /// <param name="gameServerClusterId">
        /// Required. The ID of the game server cluster resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GameServerCluster, OperationMetadata> CreateGameServerCluster(string parent, GameServerCluster gameServerCluster, string gameServerClusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGameServerCluster(new CreateGameServerClusterRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                GameServerClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(gameServerClusterId, nameof(gameServerClusterId)),
                GameServerCluster = gax::GaxPreconditions.CheckNotNull(gameServerCluster, nameof(gameServerCluster)),
            }, callSettings);

        /// <summary>
        /// Creates a new game server cluster in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, in the following form:
        /// `projects/{project}/locations/{location}/realms/{realm-id}`.
        /// </param>
        /// <param name="gameServerCluster">
        /// Required. The game server cluster resource to be created.
        /// </param>
        /// <param name="gameServerClusterId">
        /// Required. The ID of the game server cluster resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GameServerCluster, OperationMetadata>> CreateGameServerClusterAsync(string parent, GameServerCluster gameServerCluster, string gameServerClusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGameServerClusterAsync(new CreateGameServerClusterRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                GameServerClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(gameServerClusterId, nameof(gameServerClusterId)),
                GameServerCluster = gax::GaxPreconditions.CheckNotNull(gameServerCluster, nameof(gameServerCluster)),
            }, callSettings);

        /// <summary>
        /// Creates a new game server cluster in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, in the following form:
        /// `projects/{project}/locations/{location}/realms/{realm-id}`.
        /// </param>
        /// <param name="gameServerCluster">
        /// Required. The game server cluster resource to be created.
        /// </param>
        /// <param name="gameServerClusterId">
        /// Required. The ID of the game server cluster resource to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GameServerCluster, OperationMetadata>> CreateGameServerClusterAsync(string parent, GameServerCluster gameServerCluster, string gameServerClusterId, st::CancellationToken cancellationToken) =>
            CreateGameServerClusterAsync(parent, gameServerCluster, gameServerClusterId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new game server cluster in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, in the following form:
        /// `projects/{project}/locations/{location}/realms/{realm-id}`.
        /// </param>
        /// <param name="gameServerCluster">
        /// Required. The game server cluster resource to be created.
        /// </param>
        /// <param name="gameServerClusterId">
        /// Required. The ID of the game server cluster resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GameServerCluster, OperationMetadata> CreateGameServerCluster(RealmName parent, GameServerCluster gameServerCluster, string gameServerClusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGameServerCluster(new CreateGameServerClusterRequest
            {
                ParentAsRealmName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                GameServerClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(gameServerClusterId, nameof(gameServerClusterId)),
                GameServerCluster = gax::GaxPreconditions.CheckNotNull(gameServerCluster, nameof(gameServerCluster)),
            }, callSettings);

        /// <summary>
        /// Creates a new game server cluster in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, in the following form:
        /// `projects/{project}/locations/{location}/realms/{realm-id}`.
        /// </param>
        /// <param name="gameServerCluster">
        /// Required. The game server cluster resource to be created.
        /// </param>
        /// <param name="gameServerClusterId">
        /// Required. The ID of the game server cluster resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GameServerCluster, OperationMetadata>> CreateGameServerClusterAsync(RealmName parent, GameServerCluster gameServerCluster, string gameServerClusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGameServerClusterAsync(new CreateGameServerClusterRequest
            {
                ParentAsRealmName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                GameServerClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(gameServerClusterId, nameof(gameServerClusterId)),
                GameServerCluster = gax::GaxPreconditions.CheckNotNull(gameServerCluster, nameof(gameServerCluster)),
            }, callSettings);

        /// <summary>
        /// Creates a new game server cluster in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, in the following form:
        /// `projects/{project}/locations/{location}/realms/{realm-id}`.
        /// </param>
        /// <param name="gameServerCluster">
        /// Required. The game server cluster resource to be created.
        /// </param>
        /// <param name="gameServerClusterId">
        /// Required. The ID of the game server cluster resource to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GameServerCluster, OperationMetadata>> CreateGameServerClusterAsync(RealmName parent, GameServerCluster gameServerCluster, string gameServerClusterId, st::CancellationToken cancellationToken) =>
            CreateGameServerClusterAsync(parent, gameServerCluster, gameServerClusterId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Previews creation of a new game server cluster in a given project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PreviewCreateGameServerClusterResponse PreviewCreateGameServerCluster(PreviewCreateGameServerClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Previews creation of a new game server cluster in a given project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PreviewCreateGameServerClusterResponse> PreviewCreateGameServerClusterAsync(PreviewCreateGameServerClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Previews creation of a new game server cluster in a given project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PreviewCreateGameServerClusterResponse> PreviewCreateGameServerClusterAsync(PreviewCreateGameServerClusterRequest request, st::CancellationToken cancellationToken) =>
            PreviewCreateGameServerClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single game server cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteGameServerCluster(DeleteGameServerClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single game server cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGameServerClusterAsync(DeleteGameServerClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single game server cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGameServerClusterAsync(DeleteGameServerClusterRequest request, st::CancellationToken cancellationToken) =>
            DeleteGameServerClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteGameServerCluster</c>.</summary>
        public virtual lro::OperationsClient DeleteGameServerClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteGameServerCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteGameServerCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteGameServerClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteGameServerCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteGameServerClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteGameServerClusterOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single game server cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the game server cluster to delete, in the following form:
        /// `projects/{project}/locations/{location}/gameServerClusters/{cluster}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteGameServerCluster(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGameServerCluster(new DeleteGameServerClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single game server cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the game server cluster to delete, in the following form:
        /// `projects/{project}/locations/{location}/gameServerClusters/{cluster}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGameServerClusterAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGameServerClusterAsync(new DeleteGameServerClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single game server cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the game server cluster to delete, in the following form:
        /// `projects/{project}/locations/{location}/gameServerClusters/{cluster}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGameServerClusterAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteGameServerClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single game server cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the game server cluster to delete, in the following form:
        /// `projects/{project}/locations/{location}/gameServerClusters/{cluster}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteGameServerCluster(GameServerClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGameServerCluster(new DeleteGameServerClusterRequest
            {
                GameServerClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single game server cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the game server cluster to delete, in the following form:
        /// `projects/{project}/locations/{location}/gameServerClusters/{cluster}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGameServerClusterAsync(GameServerClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGameServerClusterAsync(new DeleteGameServerClusterRequest
            {
                GameServerClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single game server cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the game server cluster to delete, in the following form:
        /// `projects/{project}/locations/{location}/gameServerClusters/{cluster}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGameServerClusterAsync(GameServerClusterName name, st::CancellationToken cancellationToken) =>
            DeleteGameServerClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Previews deletion of a single game server cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PreviewDeleteGameServerClusterResponse PreviewDeleteGameServerCluster(PreviewDeleteGameServerClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Previews deletion of a single game server cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PreviewDeleteGameServerClusterResponse> PreviewDeleteGameServerClusterAsync(PreviewDeleteGameServerClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Previews deletion of a single game server cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PreviewDeleteGameServerClusterResponse> PreviewDeleteGameServerClusterAsync(PreviewDeleteGameServerClusterRequest request, st::CancellationToken cancellationToken) =>
            PreviewDeleteGameServerClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Patches a single game server cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GameServerCluster, OperationMetadata> UpdateGameServerCluster(UpdateGameServerClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches a single game server cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GameServerCluster, OperationMetadata>> UpdateGameServerClusterAsync(UpdateGameServerClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches a single game server cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GameServerCluster, OperationMetadata>> UpdateGameServerClusterAsync(UpdateGameServerClusterRequest request, st::CancellationToken cancellationToken) =>
            UpdateGameServerClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateGameServerCluster</c>.</summary>
        public virtual lro::OperationsClient UpdateGameServerClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateGameServerCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<GameServerCluster, OperationMetadata> PollOnceUpdateGameServerCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GameServerCluster, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateGameServerClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateGameServerCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<GameServerCluster, OperationMetadata>> PollOnceUpdateGameServerClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GameServerCluster, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateGameServerClusterOperationsClient, callSettings);

        /// <summary>
        /// Patches a single game server cluster.
        /// </summary>
        /// <param name="gameServerCluster">
        /// Required. The game server cluster to be updated.
        /// Only fields specified in update_mask are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field. For the `FieldMask` definition, see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GameServerCluster, OperationMetadata> UpdateGameServerCluster(GameServerCluster gameServerCluster, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGameServerCluster(new UpdateGameServerClusterRequest
            {
                GameServerCluster = gax::GaxPreconditions.CheckNotNull(gameServerCluster, nameof(gameServerCluster)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Patches a single game server cluster.
        /// </summary>
        /// <param name="gameServerCluster">
        /// Required. The game server cluster to be updated.
        /// Only fields specified in update_mask are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field. For the `FieldMask` definition, see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GameServerCluster, OperationMetadata>> UpdateGameServerClusterAsync(GameServerCluster gameServerCluster, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGameServerClusterAsync(new UpdateGameServerClusterRequest
            {
                GameServerCluster = gax::GaxPreconditions.CheckNotNull(gameServerCluster, nameof(gameServerCluster)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Patches a single game server cluster.
        /// </summary>
        /// <param name="gameServerCluster">
        /// Required. The game server cluster to be updated.
        /// Only fields specified in update_mask are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field. For the `FieldMask` definition, see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GameServerCluster, OperationMetadata>> UpdateGameServerClusterAsync(GameServerCluster gameServerCluster, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateGameServerClusterAsync(gameServerCluster, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Previews updating a GameServerCluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PreviewUpdateGameServerClusterResponse PreviewUpdateGameServerCluster(PreviewUpdateGameServerClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Previews updating a GameServerCluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PreviewUpdateGameServerClusterResponse> PreviewUpdateGameServerClusterAsync(PreviewUpdateGameServerClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Previews updating a GameServerCluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PreviewUpdateGameServerClusterResponse> PreviewUpdateGameServerClusterAsync(PreviewUpdateGameServerClusterRequest request, st::CancellationToken cancellationToken) =>
            PreviewUpdateGameServerClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>GameServerClustersService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The game server cluster maps to Kubernetes clusters running Agones and is
    /// used to manage fleets within clusters.
    /// </remarks>
    public sealed partial class GameServerClustersServiceClientImpl : GameServerClustersServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListGameServerClustersRequest, ListGameServerClustersResponse> _callListGameServerClusters;

        private readonly gaxgrpc::ApiCall<GetGameServerClusterRequest, GameServerCluster> _callGetGameServerCluster;

        private readonly gaxgrpc::ApiCall<CreateGameServerClusterRequest, lro::Operation> _callCreateGameServerCluster;

        private readonly gaxgrpc::ApiCall<PreviewCreateGameServerClusterRequest, PreviewCreateGameServerClusterResponse> _callPreviewCreateGameServerCluster;

        private readonly gaxgrpc::ApiCall<DeleteGameServerClusterRequest, lro::Operation> _callDeleteGameServerCluster;

        private readonly gaxgrpc::ApiCall<PreviewDeleteGameServerClusterRequest, PreviewDeleteGameServerClusterResponse> _callPreviewDeleteGameServerCluster;

        private readonly gaxgrpc::ApiCall<UpdateGameServerClusterRequest, lro::Operation> _callUpdateGameServerCluster;

        private readonly gaxgrpc::ApiCall<PreviewUpdateGameServerClusterRequest, PreviewUpdateGameServerClusterResponse> _callPreviewUpdateGameServerCluster;

        /// <summary>
        /// Constructs a client wrapper for the GameServerClustersService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="GameServerClustersServiceSettings"/> used within this client.
        /// </param>
        public GameServerClustersServiceClientImpl(GameServerClustersService.GameServerClustersServiceClient grpcClient, GameServerClustersServiceSettings settings)
        {
            GrpcClient = grpcClient;
            GameServerClustersServiceSettings effectiveSettings = settings ?? GameServerClustersServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            CreateGameServerClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateGameServerClusterOperationsSettings);
            DeleteGameServerClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteGameServerClusterOperationsSettings);
            UpdateGameServerClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateGameServerClusterOperationsSettings);
            _callListGameServerClusters = clientHelper.BuildApiCall<ListGameServerClustersRequest, ListGameServerClustersResponse>(grpcClient.ListGameServerClustersAsync, grpcClient.ListGameServerClusters, effectiveSettings.ListGameServerClustersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListGameServerClusters);
            Modify_ListGameServerClustersApiCall(ref _callListGameServerClusters);
            _callGetGameServerCluster = clientHelper.BuildApiCall<GetGameServerClusterRequest, GameServerCluster>(grpcClient.GetGameServerClusterAsync, grpcClient.GetGameServerCluster, effectiveSettings.GetGameServerClusterSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetGameServerCluster);
            Modify_GetGameServerClusterApiCall(ref _callGetGameServerCluster);
            _callCreateGameServerCluster = clientHelper.BuildApiCall<CreateGameServerClusterRequest, lro::Operation>(grpcClient.CreateGameServerClusterAsync, grpcClient.CreateGameServerCluster, effectiveSettings.CreateGameServerClusterSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateGameServerCluster);
            Modify_CreateGameServerClusterApiCall(ref _callCreateGameServerCluster);
            _callPreviewCreateGameServerCluster = clientHelper.BuildApiCall<PreviewCreateGameServerClusterRequest, PreviewCreateGameServerClusterResponse>(grpcClient.PreviewCreateGameServerClusterAsync, grpcClient.PreviewCreateGameServerCluster, effectiveSettings.PreviewCreateGameServerClusterSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callPreviewCreateGameServerCluster);
            Modify_PreviewCreateGameServerClusterApiCall(ref _callPreviewCreateGameServerCluster);
            _callDeleteGameServerCluster = clientHelper.BuildApiCall<DeleteGameServerClusterRequest, lro::Operation>(grpcClient.DeleteGameServerClusterAsync, grpcClient.DeleteGameServerCluster, effectiveSettings.DeleteGameServerClusterSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteGameServerCluster);
            Modify_DeleteGameServerClusterApiCall(ref _callDeleteGameServerCluster);
            _callPreviewDeleteGameServerCluster = clientHelper.BuildApiCall<PreviewDeleteGameServerClusterRequest, PreviewDeleteGameServerClusterResponse>(grpcClient.PreviewDeleteGameServerClusterAsync, grpcClient.PreviewDeleteGameServerCluster, effectiveSettings.PreviewDeleteGameServerClusterSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callPreviewDeleteGameServerCluster);
            Modify_PreviewDeleteGameServerClusterApiCall(ref _callPreviewDeleteGameServerCluster);
            _callUpdateGameServerCluster = clientHelper.BuildApiCall<UpdateGameServerClusterRequest, lro::Operation>(grpcClient.UpdateGameServerClusterAsync, grpcClient.UpdateGameServerCluster, effectiveSettings.UpdateGameServerClusterSettings).WithGoogleRequestParam("game_server_cluster.name", request => request.GameServerCluster?.Name);
            Modify_ApiCall(ref _callUpdateGameServerCluster);
            Modify_UpdateGameServerClusterApiCall(ref _callUpdateGameServerCluster);
            _callPreviewUpdateGameServerCluster = clientHelper.BuildApiCall<PreviewUpdateGameServerClusterRequest, PreviewUpdateGameServerClusterResponse>(grpcClient.PreviewUpdateGameServerClusterAsync, grpcClient.PreviewUpdateGameServerCluster, effectiveSettings.PreviewUpdateGameServerClusterSettings).WithGoogleRequestParam("game_server_cluster.name", request => request.GameServerCluster?.Name);
            Modify_ApiCall(ref _callPreviewUpdateGameServerCluster);
            Modify_PreviewUpdateGameServerClusterApiCall(ref _callPreviewUpdateGameServerCluster);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListGameServerClustersApiCall(ref gaxgrpc::ApiCall<ListGameServerClustersRequest, ListGameServerClustersResponse> call);

        partial void Modify_GetGameServerClusterApiCall(ref gaxgrpc::ApiCall<GetGameServerClusterRequest, GameServerCluster> call);

        partial void Modify_CreateGameServerClusterApiCall(ref gaxgrpc::ApiCall<CreateGameServerClusterRequest, lro::Operation> call);

        partial void Modify_PreviewCreateGameServerClusterApiCall(ref gaxgrpc::ApiCall<PreviewCreateGameServerClusterRequest, PreviewCreateGameServerClusterResponse> call);

        partial void Modify_DeleteGameServerClusterApiCall(ref gaxgrpc::ApiCall<DeleteGameServerClusterRequest, lro::Operation> call);

        partial void Modify_PreviewDeleteGameServerClusterApiCall(ref gaxgrpc::ApiCall<PreviewDeleteGameServerClusterRequest, PreviewDeleteGameServerClusterResponse> call);

        partial void Modify_UpdateGameServerClusterApiCall(ref gaxgrpc::ApiCall<UpdateGameServerClusterRequest, lro::Operation> call);

        partial void Modify_PreviewUpdateGameServerClusterApiCall(ref gaxgrpc::ApiCall<PreviewUpdateGameServerClusterRequest, PreviewUpdateGameServerClusterResponse> call);

        partial void OnConstruction(GameServerClustersService.GameServerClustersServiceClient grpcClient, GameServerClustersServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC GameServerClustersService client</summary>
        public override GameServerClustersService.GameServerClustersServiceClient GrpcClient { get; }

        partial void Modify_ListGameServerClustersRequest(ref ListGameServerClustersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetGameServerClusterRequest(ref GetGameServerClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateGameServerClusterRequest(ref CreateGameServerClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PreviewCreateGameServerClusterRequest(ref PreviewCreateGameServerClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteGameServerClusterRequest(ref DeleteGameServerClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PreviewDeleteGameServerClusterRequest(ref PreviewDeleteGameServerClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateGameServerClusterRequest(ref UpdateGameServerClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PreviewUpdateGameServerClusterRequest(ref PreviewUpdateGameServerClusterRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists game server clusters in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GameServerCluster"/> resources.</returns>
        public override gax::PagedEnumerable<ListGameServerClustersResponse, GameServerCluster> ListGameServerClusters(ListGameServerClustersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGameServerClustersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListGameServerClustersRequest, ListGameServerClustersResponse, GameServerCluster>(_callListGameServerClusters, request, callSettings);
        }

        /// <summary>
        /// Lists game server clusters in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GameServerCluster"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListGameServerClustersResponse, GameServerCluster> ListGameServerClustersAsync(ListGameServerClustersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGameServerClustersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListGameServerClustersRequest, ListGameServerClustersResponse, GameServerCluster>(_callListGameServerClusters, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single game server cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GameServerCluster GetGameServerCluster(GetGameServerClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGameServerClusterRequest(ref request, ref callSettings);
            return _callGetGameServerCluster.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single game server cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GameServerCluster> GetGameServerClusterAsync(GetGameServerClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGameServerClusterRequest(ref request, ref callSettings);
            return _callGetGameServerCluster.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateGameServerCluster</c>.</summary>
        public override lro::OperationsClient CreateGameServerClusterOperationsClient { get; }

        /// <summary>
        /// Creates a new game server cluster in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<GameServerCluster, OperationMetadata> CreateGameServerCluster(CreateGameServerClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGameServerClusterRequest(ref request, ref callSettings);
            return new lro::Operation<GameServerCluster, OperationMetadata>(_callCreateGameServerCluster.Sync(request, callSettings), CreateGameServerClusterOperationsClient);
        }

        /// <summary>
        /// Creates a new game server cluster in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<GameServerCluster, OperationMetadata>> CreateGameServerClusterAsync(CreateGameServerClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGameServerClusterRequest(ref request, ref callSettings);
            return new lro::Operation<GameServerCluster, OperationMetadata>(await _callCreateGameServerCluster.Async(request, callSettings).ConfigureAwait(false), CreateGameServerClusterOperationsClient);
        }

        /// <summary>
        /// Previews creation of a new game server cluster in a given project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PreviewCreateGameServerClusterResponse PreviewCreateGameServerCluster(PreviewCreateGameServerClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PreviewCreateGameServerClusterRequest(ref request, ref callSettings);
            return _callPreviewCreateGameServerCluster.Sync(request, callSettings);
        }

        /// <summary>
        /// Previews creation of a new game server cluster in a given project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PreviewCreateGameServerClusterResponse> PreviewCreateGameServerClusterAsync(PreviewCreateGameServerClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PreviewCreateGameServerClusterRequest(ref request, ref callSettings);
            return _callPreviewCreateGameServerCluster.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteGameServerCluster</c>.</summary>
        public override lro::OperationsClient DeleteGameServerClusterOperationsClient { get; }

        /// <summary>
        /// Deletes a single game server cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteGameServerCluster(DeleteGameServerClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGameServerClusterRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteGameServerCluster.Sync(request, callSettings), DeleteGameServerClusterOperationsClient);
        }

        /// <summary>
        /// Deletes a single game server cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGameServerClusterAsync(DeleteGameServerClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGameServerClusterRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteGameServerCluster.Async(request, callSettings).ConfigureAwait(false), DeleteGameServerClusterOperationsClient);
        }

        /// <summary>
        /// Previews deletion of a single game server cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PreviewDeleteGameServerClusterResponse PreviewDeleteGameServerCluster(PreviewDeleteGameServerClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PreviewDeleteGameServerClusterRequest(ref request, ref callSettings);
            return _callPreviewDeleteGameServerCluster.Sync(request, callSettings);
        }

        /// <summary>
        /// Previews deletion of a single game server cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PreviewDeleteGameServerClusterResponse> PreviewDeleteGameServerClusterAsync(PreviewDeleteGameServerClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PreviewDeleteGameServerClusterRequest(ref request, ref callSettings);
            return _callPreviewDeleteGameServerCluster.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateGameServerCluster</c>.</summary>
        public override lro::OperationsClient UpdateGameServerClusterOperationsClient { get; }

        /// <summary>
        /// Patches a single game server cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<GameServerCluster, OperationMetadata> UpdateGameServerCluster(UpdateGameServerClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGameServerClusterRequest(ref request, ref callSettings);
            return new lro::Operation<GameServerCluster, OperationMetadata>(_callUpdateGameServerCluster.Sync(request, callSettings), UpdateGameServerClusterOperationsClient);
        }

        /// <summary>
        /// Patches a single game server cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<GameServerCluster, OperationMetadata>> UpdateGameServerClusterAsync(UpdateGameServerClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGameServerClusterRequest(ref request, ref callSettings);
            return new lro::Operation<GameServerCluster, OperationMetadata>(await _callUpdateGameServerCluster.Async(request, callSettings).ConfigureAwait(false), UpdateGameServerClusterOperationsClient);
        }

        /// <summary>
        /// Previews updating a GameServerCluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PreviewUpdateGameServerClusterResponse PreviewUpdateGameServerCluster(PreviewUpdateGameServerClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PreviewUpdateGameServerClusterRequest(ref request, ref callSettings);
            return _callPreviewUpdateGameServerCluster.Sync(request, callSettings);
        }

        /// <summary>
        /// Previews updating a GameServerCluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PreviewUpdateGameServerClusterResponse> PreviewUpdateGameServerClusterAsync(PreviewUpdateGameServerClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PreviewUpdateGameServerClusterRequest(ref request, ref callSettings);
            return _callPreviewUpdateGameServerCluster.Async(request, callSettings);
        }
    }

    public partial class ListGameServerClustersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListGameServerClustersResponse : gaxgrpc::IPageResponse<GameServerCluster>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<GameServerCluster> GetEnumerator() => GameServerClusters.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class GameServerClustersService
    {
        public partial class GameServerClustersServiceClient
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
