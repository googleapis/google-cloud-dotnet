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

namespace Google.Ads.AdManager.V1
{
    /// <summary>Settings for <see cref="TeamServiceClient"/> instances.</summary>
    public sealed partial class TeamServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="TeamServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="TeamServiceSettings"/>.</returns>
        public static TeamServiceSettings GetDefault() => new TeamServiceSettings();

        /// <summary>Constructs a new <see cref="TeamServiceSettings"/> object with default settings.</summary>
        public TeamServiceSettings()
        {
        }

        private TeamServiceSettings(TeamServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetTeamSettings = existing.GetTeamSettings;
            ListTeamsSettings = existing.ListTeamsSettings;
            CreateTeamSettings = existing.CreateTeamSettings;
            BatchCreateTeamsSettings = existing.BatchCreateTeamsSettings;
            UpdateTeamSettings = existing.UpdateTeamSettings;
            BatchUpdateTeamsSettings = existing.BatchUpdateTeamsSettings;
            BatchActivateTeamsSettings = existing.BatchActivateTeamsSettings;
            BatchDeactivateTeamsSettings = existing.BatchDeactivateTeamsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(TeamServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>TeamServiceClient.GetTeam</c>
        ///  and <c>TeamServiceClient.GetTeamAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTeamSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>TeamServiceClient.ListTeams</c>
        ///  and <c>TeamServiceClient.ListTeamsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTeamsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TeamServiceClient.CreateTeam</c> and <c>TeamServiceClient.CreateTeamAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTeamSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TeamServiceClient.BatchCreateTeams</c> and <c>TeamServiceClient.BatchCreateTeamsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchCreateTeamsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TeamServiceClient.UpdateTeam</c> and <c>TeamServiceClient.UpdateTeamAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateTeamSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TeamServiceClient.BatchUpdateTeams</c> and <c>TeamServiceClient.BatchUpdateTeamsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchUpdateTeamsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TeamServiceClient.BatchActivateTeams</c> and <c>TeamServiceClient.BatchActivateTeamsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchActivateTeamsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TeamServiceClient.BatchDeactivateTeams</c> and <c>TeamServiceClient.BatchDeactivateTeamsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchDeactivateTeamsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="TeamServiceSettings"/> object.</returns>
        public TeamServiceSettings Clone() => new TeamServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="TeamServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class TeamServiceClientBuilder : gaxgrpc::ClientBuilderBase<TeamServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public TeamServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public TeamServiceClientBuilder() : base(TeamServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref TeamServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<TeamServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override TeamServiceClient Build()
        {
            TeamServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<TeamServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<TeamServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private TeamServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return TeamServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<TeamServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return TeamServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => TeamServiceClient.ChannelPool;
    }

    /// <summary>TeamService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `Team` objects.
    /// </remarks>
    public abstract partial class TeamServiceClient
    {
        /// <summary>
        /// The default endpoint for the TeamService service, which is a host of "admanager.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default TeamService scopes.</summary>
        /// <remarks>
        /// The default TeamService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/admanager</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admanager",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(TeamService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="TeamServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TeamServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="TeamServiceClient"/>.</returns>
        public static stt::Task<TeamServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new TeamServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="TeamServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TeamServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="TeamServiceClient"/>.</returns>
        public static TeamServiceClient Create() => new TeamServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="TeamServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="TeamServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="TeamServiceClient"/>.</returns>
        internal static TeamServiceClient Create(grpccore::CallInvoker callInvoker, TeamServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            TeamService.TeamServiceClient grpcClient = new TeamService.TeamServiceClient(callInvoker);
            return new TeamServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC TeamService client</summary>
        public virtual TeamService.TeamServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `Team` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Team GetTeam(GetTeamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `Team` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Team> GetTeamAsync(GetTeamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `Team` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Team> GetTeamAsync(GetTeamRequest request, st::CancellationToken cancellationToken) =>
            GetTeamAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `Team` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Team.
        /// Format: `networks/{network_code}/teams/{team_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Team GetTeam(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTeam(new GetTeamRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `Team` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Team.
        /// Format: `networks/{network_code}/teams/{team_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Team> GetTeamAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTeamAsync(new GetTeamRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `Team` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Team.
        /// Format: `networks/{network_code}/teams/{team_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Team> GetTeamAsync(string name, st::CancellationToken cancellationToken) =>
            GetTeamAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `Team` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Team.
        /// Format: `networks/{network_code}/teams/{team_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Team GetTeam(TeamName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTeam(new GetTeamRequest
            {
                TeamName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `Team` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Team.
        /// Format: `networks/{network_code}/teams/{team_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Team> GetTeamAsync(TeamName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTeamAsync(new GetTeamRequest
            {
                TeamName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `Team` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Team.
        /// Format: `networks/{network_code}/teams/{team_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Team> GetTeamAsync(TeamName name, st::CancellationToken cancellationToken) =>
            GetTeamAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a list of `Team` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Team"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTeamsResponse, Team> ListTeams(ListTeamsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `Team` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Team"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTeamsResponse, Team> ListTeamsAsync(ListTeamsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `Team` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Teams.
        /// Format: `networks/{network_code}`
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
        /// <returns>A pageable sequence of <see cref="Team"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTeamsResponse, Team> ListTeams(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTeamsRequest request = new ListTeamsRequest
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
            return ListTeams(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Team` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Teams.
        /// Format: `networks/{network_code}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Team"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTeamsResponse, Team> ListTeamsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTeamsRequest request = new ListTeamsRequest
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
            return ListTeamsAsync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Team` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Teams.
        /// Format: `networks/{network_code}`
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
        /// <returns>A pageable sequence of <see cref="Team"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTeamsResponse, Team> ListTeams(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTeamsRequest request = new ListTeamsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTeams(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Team` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Teams.
        /// Format: `networks/{network_code}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Team"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTeamsResponse, Team> ListTeamsAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTeamsRequest request = new ListTeamsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTeamsAsync(request, callSettings);
        }

        /// <summary>
        /// API to create a `Team` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Team CreateTeam(CreateTeamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to create a `Team` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Team> CreateTeamAsync(CreateTeamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to create a `Team` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Team> CreateTeamAsync(CreateTeamRequest request, st::CancellationToken cancellationToken) =>
            CreateTeamAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to create a `Team` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `Team` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="team">
        /// Required. The `Team` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Team CreateTeam(string parent, Team team, gaxgrpc::CallSettings callSettings = null) =>
            CreateTeam(new CreateTeamRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Team = gax::GaxPreconditions.CheckNotNull(team, nameof(team)),
            }, callSettings);

        /// <summary>
        /// API to create a `Team` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `Team` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="team">
        /// Required. The `Team` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Team> CreateTeamAsync(string parent, Team team, gaxgrpc::CallSettings callSettings = null) =>
            CreateTeamAsync(new CreateTeamRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Team = gax::GaxPreconditions.CheckNotNull(team, nameof(team)),
            }, callSettings);

        /// <summary>
        /// API to create a `Team` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `Team` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="team">
        /// Required. The `Team` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Team> CreateTeamAsync(string parent, Team team, st::CancellationToken cancellationToken) =>
            CreateTeamAsync(parent, team, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to create a `Team` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `Team` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="team">
        /// Required. The `Team` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Team CreateTeam(NetworkName parent, Team team, gaxgrpc::CallSettings callSettings = null) =>
            CreateTeam(new CreateTeamRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Team = gax::GaxPreconditions.CheckNotNull(team, nameof(team)),
            }, callSettings);

        /// <summary>
        /// API to create a `Team` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `Team` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="team">
        /// Required. The `Team` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Team> CreateTeamAsync(NetworkName parent, Team team, gaxgrpc::CallSettings callSettings = null) =>
            CreateTeamAsync(new CreateTeamRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Team = gax::GaxPreconditions.CheckNotNull(team, nameof(team)),
            }, callSettings);

        /// <summary>
        /// API to create a `Team` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `Team` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="team">
        /// Required. The `Team` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Team> CreateTeamAsync(NetworkName parent, Team team, st::CancellationToken cancellationToken) =>
            CreateTeamAsync(parent, team, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch create `Team` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateTeamsResponse BatchCreateTeams(BatchCreateTeamsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to batch create `Team` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateTeamsResponse> BatchCreateTeamsAsync(BatchCreateTeamsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to batch create `Team` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateTeamsResponse> BatchCreateTeamsAsync(BatchCreateTeamsRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateTeamsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch create `Team` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Teams` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateTeamRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Team` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateTeamsResponse BatchCreateTeams(string parent, scg::IEnumerable<CreateTeamRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateTeams(new BatchCreateTeamsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch create `Team` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Teams` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateTeamRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Team` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateTeamsResponse> BatchCreateTeamsAsync(string parent, scg::IEnumerable<CreateTeamRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateTeamsAsync(new BatchCreateTeamsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch create `Team` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Teams` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateTeamRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Team` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateTeamsResponse> BatchCreateTeamsAsync(string parent, scg::IEnumerable<CreateTeamRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateTeamsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch create `Team` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Teams` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateTeamRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Team` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateTeamsResponse BatchCreateTeams(NetworkName parent, scg::IEnumerable<CreateTeamRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateTeams(new BatchCreateTeamsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch create `Team` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Teams` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateTeamRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Team` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateTeamsResponse> BatchCreateTeamsAsync(NetworkName parent, scg::IEnumerable<CreateTeamRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateTeamsAsync(new BatchCreateTeamsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch create `Team` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Teams` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateTeamRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Team` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateTeamsResponse> BatchCreateTeamsAsync(NetworkName parent, scg::IEnumerable<CreateTeamRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateTeamsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to update a `Team` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Team UpdateTeam(UpdateTeamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to update a `Team` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Team> UpdateTeamAsync(UpdateTeamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to update a `Team` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Team> UpdateTeamAsync(UpdateTeamRequest request, st::CancellationToken cancellationToken) =>
            UpdateTeamAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to update a `Team` object.
        /// </summary>
        /// <param name="team">
        /// Required. The `Team` to update.
        /// 
        /// The `Team`'s `name` is used to identify the `Team` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Team UpdateTeam(Team team, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTeam(new UpdateTeamRequest
            {
                Team = gax::GaxPreconditions.CheckNotNull(team, nameof(team)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// API to update a `Team` object.
        /// </summary>
        /// <param name="team">
        /// Required. The `Team` to update.
        /// 
        /// The `Team`'s `name` is used to identify the `Team` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Team> UpdateTeamAsync(Team team, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTeamAsync(new UpdateTeamRequest
            {
                Team = gax::GaxPreconditions.CheckNotNull(team, nameof(team)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// API to update a `Team` object.
        /// </summary>
        /// <param name="team">
        /// Required. The `Team` to update.
        /// 
        /// The `Team`'s `name` is used to identify the `Team` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Team> UpdateTeamAsync(Team team, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateTeamAsync(team, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch update `Team` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateTeamsResponse BatchUpdateTeams(BatchUpdateTeamsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to batch update `Team` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateTeamsResponse> BatchUpdateTeamsAsync(BatchUpdateTeamsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to batch update `Team` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateTeamsResponse> BatchUpdateTeamsAsync(BatchUpdateTeamsRequest request, st::CancellationToken cancellationToken) =>
            BatchUpdateTeamsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch update `Team` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Teams` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateTeamRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Team` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateTeamsResponse BatchUpdateTeams(string parent, scg::IEnumerable<UpdateTeamRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateTeams(new BatchUpdateTeamsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch update `Team` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Teams` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateTeamRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Team` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateTeamsResponse> BatchUpdateTeamsAsync(string parent, scg::IEnumerable<UpdateTeamRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateTeamsAsync(new BatchUpdateTeamsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch update `Team` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Teams` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateTeamRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Team` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateTeamsResponse> BatchUpdateTeamsAsync(string parent, scg::IEnumerable<UpdateTeamRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateTeamsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch update `Team` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Teams` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateTeamRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Team` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateTeamsResponse BatchUpdateTeams(NetworkName parent, scg::IEnumerable<UpdateTeamRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateTeams(new BatchUpdateTeamsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch update `Team` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Teams` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateTeamRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Team` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateTeamsResponse> BatchUpdateTeamsAsync(NetworkName parent, scg::IEnumerable<UpdateTeamRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateTeamsAsync(new BatchUpdateTeamsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch update `Team` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Teams` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateTeamRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Team` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateTeamsResponse> BatchUpdateTeamsAsync(NetworkName parent, scg::IEnumerable<UpdateTeamRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateTeamsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch activate `Team` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateTeamsResponse BatchActivateTeams(BatchActivateTeamsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to batch activate `Team` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateTeamsResponse> BatchActivateTeamsAsync(BatchActivateTeamsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to batch activate `Team` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateTeamsResponse> BatchActivateTeamsAsync(BatchActivateTeamsRequest request, st::CancellationToken cancellationToken) =>
            BatchActivateTeamsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch activate `Team` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `Team`s to activate.
        /// Format: `networks/{network_code}/teams/{team_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateTeamsResponse BatchActivateTeams(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateTeams(new BatchActivateTeamsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch activate `Team` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `Team`s to activate.
        /// Format: `networks/{network_code}/teams/{team_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateTeamsResponse> BatchActivateTeamsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateTeamsAsync(new BatchActivateTeamsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch activate `Team` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `Team`s to activate.
        /// Format: `networks/{network_code}/teams/{team_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateTeamsResponse> BatchActivateTeamsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchActivateTeamsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch activate `Team` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `Team`s to activate.
        /// Format: `networks/{network_code}/teams/{team_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateTeamsResponse BatchActivateTeams(NetworkName parent, scg::IEnumerable<TeamName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateTeams(new BatchActivateTeamsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TeamNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch activate `Team` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `Team`s to activate.
        /// Format: `networks/{network_code}/teams/{team_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateTeamsResponse> BatchActivateTeamsAsync(NetworkName parent, scg::IEnumerable<TeamName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateTeamsAsync(new BatchActivateTeamsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TeamNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch activate `Team` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `Team`s to activate.
        /// Format: `networks/{network_code}/teams/{team_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateTeamsResponse> BatchActivateTeamsAsync(NetworkName parent, scg::IEnumerable<TeamName> names, st::CancellationToken cancellationToken) =>
            BatchActivateTeamsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch deactivate `Team` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateTeamsResponse BatchDeactivateTeams(BatchDeactivateTeamsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to batch deactivate `Team` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateTeamsResponse> BatchDeactivateTeamsAsync(BatchDeactivateTeamsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to batch deactivate `Team` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateTeamsResponse> BatchDeactivateTeamsAsync(BatchDeactivateTeamsRequest request, st::CancellationToken cancellationToken) =>
            BatchDeactivateTeamsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch deactivate `Team` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `Team`s to deactivate.
        /// Format: `networks/{network_code}/teams/{team_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateTeamsResponse BatchDeactivateTeams(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateTeams(new BatchDeactivateTeamsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch deactivate `Team` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `Team`s to deactivate.
        /// Format: `networks/{network_code}/teams/{team_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateTeamsResponse> BatchDeactivateTeamsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateTeamsAsync(new BatchDeactivateTeamsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch deactivate `Team` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `Team`s to deactivate.
        /// Format: `networks/{network_code}/teams/{team_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateTeamsResponse> BatchDeactivateTeamsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchDeactivateTeamsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch deactivate `Team` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `Team`s to deactivate.
        /// Format: `networks/{network_code}/teams/{team_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateTeamsResponse BatchDeactivateTeams(NetworkName parent, scg::IEnumerable<TeamName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateTeams(new BatchDeactivateTeamsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TeamNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch deactivate `Team` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `Team`s to deactivate.
        /// Format: `networks/{network_code}/teams/{team_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateTeamsResponse> BatchDeactivateTeamsAsync(NetworkName parent, scg::IEnumerable<TeamName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateTeamsAsync(new BatchDeactivateTeamsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TeamNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch deactivate `Team` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `Team`s to deactivate.
        /// Format: `networks/{network_code}/teams/{team_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateTeamsResponse> BatchDeactivateTeamsAsync(NetworkName parent, scg::IEnumerable<TeamName> names, st::CancellationToken cancellationToken) =>
            BatchDeactivateTeamsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>TeamService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `Team` objects.
    /// </remarks>
    public sealed partial class TeamServiceClientImpl : TeamServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetTeamRequest, Team> _callGetTeam;

        private readonly gaxgrpc::ApiCall<ListTeamsRequest, ListTeamsResponse> _callListTeams;

        private readonly gaxgrpc::ApiCall<CreateTeamRequest, Team> _callCreateTeam;

        private readonly gaxgrpc::ApiCall<BatchCreateTeamsRequest, BatchCreateTeamsResponse> _callBatchCreateTeams;

        private readonly gaxgrpc::ApiCall<UpdateTeamRequest, Team> _callUpdateTeam;

        private readonly gaxgrpc::ApiCall<BatchUpdateTeamsRequest, BatchUpdateTeamsResponse> _callBatchUpdateTeams;

        private readonly gaxgrpc::ApiCall<BatchActivateTeamsRequest, BatchActivateTeamsResponse> _callBatchActivateTeams;

        private readonly gaxgrpc::ApiCall<BatchDeactivateTeamsRequest, BatchDeactivateTeamsResponse> _callBatchDeactivateTeams;

        /// <summary>
        /// Constructs a client wrapper for the TeamService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="TeamServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public TeamServiceClientImpl(TeamService.TeamServiceClient grpcClient, TeamServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            TeamServiceSettings effectiveSettings = settings ?? TeamServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetTeam = clientHelper.BuildApiCall<GetTeamRequest, Team>("GetTeam", grpcClient.GetTeamAsync, grpcClient.GetTeam, effectiveSettings.GetTeamSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTeam);
            Modify_GetTeamApiCall(ref _callGetTeam);
            _callListTeams = clientHelper.BuildApiCall<ListTeamsRequest, ListTeamsResponse>("ListTeams", grpcClient.ListTeamsAsync, grpcClient.ListTeams, effectiveSettings.ListTeamsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTeams);
            Modify_ListTeamsApiCall(ref _callListTeams);
            _callCreateTeam = clientHelper.BuildApiCall<CreateTeamRequest, Team>("CreateTeam", grpcClient.CreateTeamAsync, grpcClient.CreateTeam, effectiveSettings.CreateTeamSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateTeam);
            Modify_CreateTeamApiCall(ref _callCreateTeam);
            _callBatchCreateTeams = clientHelper.BuildApiCall<BatchCreateTeamsRequest, BatchCreateTeamsResponse>("BatchCreateTeams", grpcClient.BatchCreateTeamsAsync, grpcClient.BatchCreateTeams, effectiveSettings.BatchCreateTeamsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCreateTeams);
            Modify_BatchCreateTeamsApiCall(ref _callBatchCreateTeams);
            _callUpdateTeam = clientHelper.BuildApiCall<UpdateTeamRequest, Team>("UpdateTeam", grpcClient.UpdateTeamAsync, grpcClient.UpdateTeam, effectiveSettings.UpdateTeamSettings).WithGoogleRequestParam("team.name", request => request.Team?.Name);
            Modify_ApiCall(ref _callUpdateTeam);
            Modify_UpdateTeamApiCall(ref _callUpdateTeam);
            _callBatchUpdateTeams = clientHelper.BuildApiCall<BatchUpdateTeamsRequest, BatchUpdateTeamsResponse>("BatchUpdateTeams", grpcClient.BatchUpdateTeamsAsync, grpcClient.BatchUpdateTeams, effectiveSettings.BatchUpdateTeamsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchUpdateTeams);
            Modify_BatchUpdateTeamsApiCall(ref _callBatchUpdateTeams);
            _callBatchActivateTeams = clientHelper.BuildApiCall<BatchActivateTeamsRequest, BatchActivateTeamsResponse>("BatchActivateTeams", grpcClient.BatchActivateTeamsAsync, grpcClient.BatchActivateTeams, effectiveSettings.BatchActivateTeamsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchActivateTeams);
            Modify_BatchActivateTeamsApiCall(ref _callBatchActivateTeams);
            _callBatchDeactivateTeams = clientHelper.BuildApiCall<BatchDeactivateTeamsRequest, BatchDeactivateTeamsResponse>("BatchDeactivateTeams", grpcClient.BatchDeactivateTeamsAsync, grpcClient.BatchDeactivateTeams, effectiveSettings.BatchDeactivateTeamsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchDeactivateTeams);
            Modify_BatchDeactivateTeamsApiCall(ref _callBatchDeactivateTeams);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetTeamApiCall(ref gaxgrpc::ApiCall<GetTeamRequest, Team> call);

        partial void Modify_ListTeamsApiCall(ref gaxgrpc::ApiCall<ListTeamsRequest, ListTeamsResponse> call);

        partial void Modify_CreateTeamApiCall(ref gaxgrpc::ApiCall<CreateTeamRequest, Team> call);

        partial void Modify_BatchCreateTeamsApiCall(ref gaxgrpc::ApiCall<BatchCreateTeamsRequest, BatchCreateTeamsResponse> call);

        partial void Modify_UpdateTeamApiCall(ref gaxgrpc::ApiCall<UpdateTeamRequest, Team> call);

        partial void Modify_BatchUpdateTeamsApiCall(ref gaxgrpc::ApiCall<BatchUpdateTeamsRequest, BatchUpdateTeamsResponse> call);

        partial void Modify_BatchActivateTeamsApiCall(ref gaxgrpc::ApiCall<BatchActivateTeamsRequest, BatchActivateTeamsResponse> call);

        partial void Modify_BatchDeactivateTeamsApiCall(ref gaxgrpc::ApiCall<BatchDeactivateTeamsRequest, BatchDeactivateTeamsResponse> call);

        partial void OnConstruction(TeamService.TeamServiceClient grpcClient, TeamServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC TeamService client</summary>
        public override TeamService.TeamServiceClient GrpcClient { get; }

        partial void Modify_GetTeamRequest(ref GetTeamRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTeamsRequest(ref ListTeamsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateTeamRequest(ref CreateTeamRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateTeamsRequest(ref BatchCreateTeamsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateTeamRequest(ref UpdateTeamRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUpdateTeamsRequest(ref BatchUpdateTeamsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchActivateTeamsRequest(ref BatchActivateTeamsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchDeactivateTeamsRequest(ref BatchDeactivateTeamsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// API to retrieve a `Team` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Team GetTeam(GetTeamRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTeamRequest(ref request, ref callSettings);
            return _callGetTeam.Sync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a `Team` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Team> GetTeamAsync(GetTeamRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTeamRequest(ref request, ref callSettings);
            return _callGetTeam.Async(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Team` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Team"/> resources.</returns>
        public override gax::PagedEnumerable<ListTeamsResponse, Team> ListTeams(ListTeamsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTeamsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTeamsRequest, ListTeamsResponse, Team>(_callListTeams, request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Team` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Team"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTeamsResponse, Team> ListTeamsAsync(ListTeamsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTeamsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTeamsRequest, ListTeamsResponse, Team>(_callListTeams, request, callSettings);
        }

        /// <summary>
        /// API to create a `Team` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Team CreateTeam(CreateTeamRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTeamRequest(ref request, ref callSettings);
            return _callCreateTeam.Sync(request, callSettings);
        }

        /// <summary>
        /// API to create a `Team` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Team> CreateTeamAsync(CreateTeamRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTeamRequest(ref request, ref callSettings);
            return _callCreateTeam.Async(request, callSettings);
        }

        /// <summary>
        /// API to batch create `Team` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchCreateTeamsResponse BatchCreateTeams(BatchCreateTeamsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateTeamsRequest(ref request, ref callSettings);
            return _callBatchCreateTeams.Sync(request, callSettings);
        }

        /// <summary>
        /// API to batch create `Team` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchCreateTeamsResponse> BatchCreateTeamsAsync(BatchCreateTeamsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateTeamsRequest(ref request, ref callSettings);
            return _callBatchCreateTeams.Async(request, callSettings);
        }

        /// <summary>
        /// API to update a `Team` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Team UpdateTeam(UpdateTeamRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTeamRequest(ref request, ref callSettings);
            return _callUpdateTeam.Sync(request, callSettings);
        }

        /// <summary>
        /// API to update a `Team` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Team> UpdateTeamAsync(UpdateTeamRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTeamRequest(ref request, ref callSettings);
            return _callUpdateTeam.Async(request, callSettings);
        }

        /// <summary>
        /// API to batch update `Team` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchUpdateTeamsResponse BatchUpdateTeams(BatchUpdateTeamsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateTeamsRequest(ref request, ref callSettings);
            return _callBatchUpdateTeams.Sync(request, callSettings);
        }

        /// <summary>
        /// API to batch update `Team` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchUpdateTeamsResponse> BatchUpdateTeamsAsync(BatchUpdateTeamsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateTeamsRequest(ref request, ref callSettings);
            return _callBatchUpdateTeams.Async(request, callSettings);
        }

        /// <summary>
        /// API to batch activate `Team` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchActivateTeamsResponse BatchActivateTeams(BatchActivateTeamsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchActivateTeamsRequest(ref request, ref callSettings);
            return _callBatchActivateTeams.Sync(request, callSettings);
        }

        /// <summary>
        /// API to batch activate `Team` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchActivateTeamsResponse> BatchActivateTeamsAsync(BatchActivateTeamsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchActivateTeamsRequest(ref request, ref callSettings);
            return _callBatchActivateTeams.Async(request, callSettings);
        }

        /// <summary>
        /// API to batch deactivate `Team` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchDeactivateTeamsResponse BatchDeactivateTeams(BatchDeactivateTeamsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeactivateTeamsRequest(ref request, ref callSettings);
            return _callBatchDeactivateTeams.Sync(request, callSettings);
        }

        /// <summary>
        /// API to batch deactivate `Team` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchDeactivateTeamsResponse> BatchDeactivateTeamsAsync(BatchDeactivateTeamsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeactivateTeamsRequest(ref request, ref callSettings);
            return _callBatchDeactivateTeams.Async(request, callSettings);
        }
    }

    public partial class ListTeamsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTeamsResponse : gaxgrpc::IPageResponse<Team>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Team> GetEnumerator() => Teams.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
