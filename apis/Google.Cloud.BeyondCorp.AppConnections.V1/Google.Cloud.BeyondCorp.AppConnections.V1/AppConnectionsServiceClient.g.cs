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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gciv = Google.Cloud.Iam.V1;
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

namespace Google.Cloud.BeyondCorp.AppConnections.V1
{
    /// <summary>Settings for <see cref="AppConnectionsServiceClient"/> instances.</summary>
    public sealed partial class AppConnectionsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AppConnectionsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AppConnectionsServiceSettings"/>.</returns>
        public static AppConnectionsServiceSettings GetDefault() => new AppConnectionsServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="AppConnectionsServiceSettings"/> object with default settings.
        /// </summary>
        public AppConnectionsServiceSettings()
        {
        }

        private AppConnectionsServiceSettings(AppConnectionsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListAppConnectionsSettings = existing.ListAppConnectionsSettings;
            GetAppConnectionSettings = existing.GetAppConnectionSettings;
            CreateAppConnectionSettings = existing.CreateAppConnectionSettings;
            CreateAppConnectionOperationsSettings = existing.CreateAppConnectionOperationsSettings.Clone();
            UpdateAppConnectionSettings = existing.UpdateAppConnectionSettings;
            UpdateAppConnectionOperationsSettings = existing.UpdateAppConnectionOperationsSettings.Clone();
            DeleteAppConnectionSettings = existing.DeleteAppConnectionSettings;
            DeleteAppConnectionOperationsSettings = existing.DeleteAppConnectionOperationsSettings.Clone();
            ResolveAppConnectionsSettings = existing.ResolveAppConnectionsSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(AppConnectionsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppConnectionsServiceClient.ListAppConnections</c> and
        /// <c>AppConnectionsServiceClient.ListAppConnectionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAppConnectionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppConnectionsServiceClient.GetAppConnection</c> and <c>AppConnectionsServiceClient.GetAppConnectionAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAppConnectionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppConnectionsServiceClient.CreateAppConnection</c> and
        /// <c>AppConnectionsServiceClient.CreateAppConnectionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAppConnectionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>AppConnectionsServiceClient.CreateAppConnection</c> and
        /// <c>AppConnectionsServiceClient.CreateAppConnectionAsync</c>.
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
        public lro::OperationsSettings CreateAppConnectionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppConnectionsServiceClient.UpdateAppConnection</c> and
        /// <c>AppConnectionsServiceClient.UpdateAppConnectionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAppConnectionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>AppConnectionsServiceClient.UpdateAppConnection</c> and
        /// <c>AppConnectionsServiceClient.UpdateAppConnectionAsync</c>.
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
        public lro::OperationsSettings UpdateAppConnectionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppConnectionsServiceClient.DeleteAppConnection</c> and
        /// <c>AppConnectionsServiceClient.DeleteAppConnectionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAppConnectionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>AppConnectionsServiceClient.DeleteAppConnection</c> and
        /// <c>AppConnectionsServiceClient.DeleteAppConnectionAsync</c>.
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
        public lro::OperationsSettings DeleteAppConnectionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppConnectionsServiceClient.ResolveAppConnections</c> and
        /// <c>AppConnectionsServiceClient.ResolveAppConnectionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ResolveAppConnectionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AppConnectionsServiceSettings"/> object.</returns>
        public AppConnectionsServiceSettings Clone() => new AppConnectionsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AppConnectionsServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class AppConnectionsServiceClientBuilder : gaxgrpc::ClientBuilderBase<AppConnectionsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AppConnectionsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AppConnectionsServiceClientBuilder() : base(AppConnectionsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AppConnectionsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AppConnectionsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AppConnectionsServiceClient Build()
        {
            AppConnectionsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AppConnectionsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AppConnectionsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AppConnectionsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AppConnectionsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AppConnectionsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AppConnectionsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AppConnectionsServiceClient.ChannelPool;
    }

    /// <summary>AppConnectionsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// API Overview:
    /// 
    /// The `beyondcorp.googleapis.com` service implements the Google Cloud
    /// BeyondCorp API.
    /// 
    /// Data Model:
    /// 
    /// The AppConnectionsService exposes the following resources:
    /// 
    /// * AppConnections, named as follows:
    /// `projects/{project_id}/locations/{location_id}/appConnections/{app_connection_id}`.
    /// 
    /// The AppConnectionsService service provides methods to manage
    /// (create/read/update/delete) BeyondCorp AppConnections.
    /// </remarks>
    public abstract partial class AppConnectionsServiceClient
    {
        /// <summary>
        /// The default endpoint for the AppConnectionsService service, which is a host of "beyondcorp.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "beyondcorp.googleapis.com:443";

        /// <summary>The default AppConnectionsService scopes.</summary>
        /// <remarks>
        /// The default AppConnectionsService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AppConnectionsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AppConnectionsServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="AppConnectionsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AppConnectionsServiceClient"/>.</returns>
        public static stt::Task<AppConnectionsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AppConnectionsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AppConnectionsServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="AppConnectionsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AppConnectionsServiceClient"/>.</returns>
        public static AppConnectionsServiceClient Create() => new AppConnectionsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AppConnectionsServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AppConnectionsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AppConnectionsServiceClient"/>.</returns>
        internal static AppConnectionsServiceClient Create(grpccore::CallInvoker callInvoker, AppConnectionsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AppConnectionsService.AppConnectionsServiceClient grpcClient = new AppConnectionsService.AppConnectionsServiceClient(callInvoker);
            return new AppConnectionsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AppConnectionsService client</summary>
        public virtual AppConnectionsService.AppConnectionsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists AppConnections in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AppConnection"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAppConnectionsResponse, AppConnection> ListAppConnections(ListAppConnectionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists AppConnections in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AppConnection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAppConnectionsResponse, AppConnection> ListAppConnectionsAsync(ListAppConnectionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists AppConnections in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the AppConnection location using the form:
        /// `projects/{project_id}/locations/{location_id}`
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
        /// <returns>A pageable sequence of <see cref="AppConnection"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAppConnectionsResponse, AppConnection> ListAppConnections(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAppConnectionsRequest request = new ListAppConnectionsRequest
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
            return ListAppConnections(request, callSettings);
        }

        /// <summary>
        /// Lists AppConnections in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the AppConnection location using the form:
        /// `projects/{project_id}/locations/{location_id}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="AppConnection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAppConnectionsResponse, AppConnection> ListAppConnectionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAppConnectionsRequest request = new ListAppConnectionsRequest
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
            return ListAppConnectionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists AppConnections in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the AppConnection location using the form:
        /// `projects/{project_id}/locations/{location_id}`
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
        /// <returns>A pageable sequence of <see cref="AppConnection"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAppConnectionsResponse, AppConnection> ListAppConnections(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAppConnectionsRequest request = new ListAppConnectionsRequest
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
            return ListAppConnections(request, callSettings);
        }

        /// <summary>
        /// Lists AppConnections in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the AppConnection location using the form:
        /// `projects/{project_id}/locations/{location_id}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="AppConnection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAppConnectionsResponse, AppConnection> ListAppConnectionsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAppConnectionsRequest request = new ListAppConnectionsRequest
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
            return ListAppConnectionsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single AppConnection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AppConnection GetAppConnection(GetAppConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single AppConnection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppConnection> GetAppConnectionAsync(GetAppConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single AppConnection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppConnection> GetAppConnectionAsync(GetAppConnectionRequest request, st::CancellationToken cancellationToken) =>
            GetAppConnectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single AppConnection.
        /// </summary>
        /// <param name="name">
        /// Required. BeyondCorp AppConnection name using the form:
        /// `projects/{project_id}/locations/{location_id}/appConnections/{app_connection_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AppConnection GetAppConnection(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAppConnection(new GetAppConnectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single AppConnection.
        /// </summary>
        /// <param name="name">
        /// Required. BeyondCorp AppConnection name using the form:
        /// `projects/{project_id}/locations/{location_id}/appConnections/{app_connection_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppConnection> GetAppConnectionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAppConnectionAsync(new GetAppConnectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single AppConnection.
        /// </summary>
        /// <param name="name">
        /// Required. BeyondCorp AppConnection name using the form:
        /// `projects/{project_id}/locations/{location_id}/appConnections/{app_connection_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppConnection> GetAppConnectionAsync(string name, st::CancellationToken cancellationToken) =>
            GetAppConnectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single AppConnection.
        /// </summary>
        /// <param name="name">
        /// Required. BeyondCorp AppConnection name using the form:
        /// `projects/{project_id}/locations/{location_id}/appConnections/{app_connection_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AppConnection GetAppConnection(AppConnectionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAppConnection(new GetAppConnectionRequest
            {
                AppConnectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single AppConnection.
        /// </summary>
        /// <param name="name">
        /// Required. BeyondCorp AppConnection name using the form:
        /// `projects/{project_id}/locations/{location_id}/appConnections/{app_connection_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppConnection> GetAppConnectionAsync(AppConnectionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAppConnectionAsync(new GetAppConnectionRequest
            {
                AppConnectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single AppConnection.
        /// </summary>
        /// <param name="name">
        /// Required. BeyondCorp AppConnection name using the form:
        /// `projects/{project_id}/locations/{location_id}/appConnections/{app_connection_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppConnection> GetAppConnectionAsync(AppConnectionName name, st::CancellationToken cancellationToken) =>
            GetAppConnectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new AppConnection in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AppConnection, AppConnectionOperationMetadata> CreateAppConnection(CreateAppConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new AppConnection in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AppConnection, AppConnectionOperationMetadata>> CreateAppConnectionAsync(CreateAppConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new AppConnection in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AppConnection, AppConnectionOperationMetadata>> CreateAppConnectionAsync(CreateAppConnectionRequest request, st::CancellationToken cancellationToken) =>
            CreateAppConnectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateAppConnection</c>.</summary>
        public virtual lro::OperationsClient CreateAppConnectionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateAppConnection</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AppConnection, AppConnectionOperationMetadata> PollOnceCreateAppConnection(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AppConnection, AppConnectionOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAppConnectionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateAppConnection</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AppConnection, AppConnectionOperationMetadata>> PollOnceCreateAppConnectionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AppConnection, AppConnectionOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAppConnectionOperationsClient, callSettings);

        /// <summary>
        /// Creates a new AppConnection in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource project name of the AppConnection location using the
        /// form: `projects/{project_id}/locations/{location_id}`
        /// </param>
        /// <param name="appConnection">
        /// Required. A BeyondCorp AppConnection resource.
        /// </param>
        /// <param name="appConnectionId">
        /// Optional. User-settable AppConnection resource ID.
        /// * Must start with a letter.
        /// * Must contain between 4-63 characters from `/[a-z][0-9]-/`.
        /// * Must end with a number or a letter.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AppConnection, AppConnectionOperationMetadata> CreateAppConnection(string parent, AppConnection appConnection, string appConnectionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAppConnection(new CreateAppConnectionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AppConnectionId = appConnectionId ?? "",
                AppConnection = gax::GaxPreconditions.CheckNotNull(appConnection, nameof(appConnection)),
            }, callSettings);

        /// <summary>
        /// Creates a new AppConnection in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource project name of the AppConnection location using the
        /// form: `projects/{project_id}/locations/{location_id}`
        /// </param>
        /// <param name="appConnection">
        /// Required. A BeyondCorp AppConnection resource.
        /// </param>
        /// <param name="appConnectionId">
        /// Optional. User-settable AppConnection resource ID.
        /// * Must start with a letter.
        /// * Must contain between 4-63 characters from `/[a-z][0-9]-/`.
        /// * Must end with a number or a letter.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AppConnection, AppConnectionOperationMetadata>> CreateAppConnectionAsync(string parent, AppConnection appConnection, string appConnectionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAppConnectionAsync(new CreateAppConnectionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AppConnectionId = appConnectionId ?? "",
                AppConnection = gax::GaxPreconditions.CheckNotNull(appConnection, nameof(appConnection)),
            }, callSettings);

        /// <summary>
        /// Creates a new AppConnection in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource project name of the AppConnection location using the
        /// form: `projects/{project_id}/locations/{location_id}`
        /// </param>
        /// <param name="appConnection">
        /// Required. A BeyondCorp AppConnection resource.
        /// </param>
        /// <param name="appConnectionId">
        /// Optional. User-settable AppConnection resource ID.
        /// * Must start with a letter.
        /// * Must contain between 4-63 characters from `/[a-z][0-9]-/`.
        /// * Must end with a number or a letter.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AppConnection, AppConnectionOperationMetadata>> CreateAppConnectionAsync(string parent, AppConnection appConnection, string appConnectionId, st::CancellationToken cancellationToken) =>
            CreateAppConnectionAsync(parent, appConnection, appConnectionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new AppConnection in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource project name of the AppConnection location using the
        /// form: `projects/{project_id}/locations/{location_id}`
        /// </param>
        /// <param name="appConnection">
        /// Required. A BeyondCorp AppConnection resource.
        /// </param>
        /// <param name="appConnectionId">
        /// Optional. User-settable AppConnection resource ID.
        /// * Must start with a letter.
        /// * Must contain between 4-63 characters from `/[a-z][0-9]-/`.
        /// * Must end with a number or a letter.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AppConnection, AppConnectionOperationMetadata> CreateAppConnection(gagr::LocationName parent, AppConnection appConnection, string appConnectionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAppConnection(new CreateAppConnectionRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AppConnectionId = appConnectionId ?? "",
                AppConnection = gax::GaxPreconditions.CheckNotNull(appConnection, nameof(appConnection)),
            }, callSettings);

        /// <summary>
        /// Creates a new AppConnection in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource project name of the AppConnection location using the
        /// form: `projects/{project_id}/locations/{location_id}`
        /// </param>
        /// <param name="appConnection">
        /// Required. A BeyondCorp AppConnection resource.
        /// </param>
        /// <param name="appConnectionId">
        /// Optional. User-settable AppConnection resource ID.
        /// * Must start with a letter.
        /// * Must contain between 4-63 characters from `/[a-z][0-9]-/`.
        /// * Must end with a number or a letter.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AppConnection, AppConnectionOperationMetadata>> CreateAppConnectionAsync(gagr::LocationName parent, AppConnection appConnection, string appConnectionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAppConnectionAsync(new CreateAppConnectionRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AppConnectionId = appConnectionId ?? "",
                AppConnection = gax::GaxPreconditions.CheckNotNull(appConnection, nameof(appConnection)),
            }, callSettings);

        /// <summary>
        /// Creates a new AppConnection in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource project name of the AppConnection location using the
        /// form: `projects/{project_id}/locations/{location_id}`
        /// </param>
        /// <param name="appConnection">
        /// Required. A BeyondCorp AppConnection resource.
        /// </param>
        /// <param name="appConnectionId">
        /// Optional. User-settable AppConnection resource ID.
        /// * Must start with a letter.
        /// * Must contain between 4-63 characters from `/[a-z][0-9]-/`.
        /// * Must end with a number or a letter.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AppConnection, AppConnectionOperationMetadata>> CreateAppConnectionAsync(gagr::LocationName parent, AppConnection appConnection, string appConnectionId, st::CancellationToken cancellationToken) =>
            CreateAppConnectionAsync(parent, appConnection, appConnectionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single AppConnection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AppConnection, AppConnectionOperationMetadata> UpdateAppConnection(UpdateAppConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single AppConnection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AppConnection, AppConnectionOperationMetadata>> UpdateAppConnectionAsync(UpdateAppConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single AppConnection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AppConnection, AppConnectionOperationMetadata>> UpdateAppConnectionAsync(UpdateAppConnectionRequest request, st::CancellationToken cancellationToken) =>
            UpdateAppConnectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateAppConnection</c>.</summary>
        public virtual lro::OperationsClient UpdateAppConnectionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateAppConnection</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AppConnection, AppConnectionOperationMetadata> PollOnceUpdateAppConnection(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AppConnection, AppConnectionOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAppConnectionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateAppConnection</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AppConnection, AppConnectionOperationMetadata>> PollOnceUpdateAppConnectionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AppConnection, AppConnectionOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAppConnectionOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single AppConnection.
        /// </summary>
        /// <param name="appConnection">
        /// Required. AppConnection message with updated fields. Only supported fields
        /// specified in update_mask are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field. The elements of the repeated paths field may only include these
        /// fields from [BeyondCorp.AppConnection]:
        /// * `labels`
        /// * `display_name`
        /// * `application_endpoint`
        /// * `connectors`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AppConnection, AppConnectionOperationMetadata> UpdateAppConnection(AppConnection appConnection, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAppConnection(new UpdateAppConnectionRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                AppConnection = gax::GaxPreconditions.CheckNotNull(appConnection, nameof(appConnection)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single AppConnection.
        /// </summary>
        /// <param name="appConnection">
        /// Required. AppConnection message with updated fields. Only supported fields
        /// specified in update_mask are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field. The elements of the repeated paths field may only include these
        /// fields from [BeyondCorp.AppConnection]:
        /// * `labels`
        /// * `display_name`
        /// * `application_endpoint`
        /// * `connectors`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AppConnection, AppConnectionOperationMetadata>> UpdateAppConnectionAsync(AppConnection appConnection, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAppConnectionAsync(new UpdateAppConnectionRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                AppConnection = gax::GaxPreconditions.CheckNotNull(appConnection, nameof(appConnection)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single AppConnection.
        /// </summary>
        /// <param name="appConnection">
        /// Required. AppConnection message with updated fields. Only supported fields
        /// specified in update_mask are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field. The elements of the repeated paths field may only include these
        /// fields from [BeyondCorp.AppConnection]:
        /// * `labels`
        /// * `display_name`
        /// * `application_endpoint`
        /// * `connectors`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AppConnection, AppConnectionOperationMetadata>> UpdateAppConnectionAsync(AppConnection appConnection, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAppConnectionAsync(appConnection, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single AppConnection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, AppConnectionOperationMetadata> DeleteAppConnection(DeleteAppConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single AppConnection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, AppConnectionOperationMetadata>> DeleteAppConnectionAsync(DeleteAppConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single AppConnection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, AppConnectionOperationMetadata>> DeleteAppConnectionAsync(DeleteAppConnectionRequest request, st::CancellationToken cancellationToken) =>
            DeleteAppConnectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteAppConnection</c>.</summary>
        public virtual lro::OperationsClient DeleteAppConnectionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteAppConnection</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, AppConnectionOperationMetadata> PollOnceDeleteAppConnection(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, AppConnectionOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAppConnectionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteAppConnection</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, AppConnectionOperationMetadata>> PollOnceDeleteAppConnectionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, AppConnectionOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAppConnectionOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single AppConnection.
        /// </summary>
        /// <param name="name">
        /// Required. BeyondCorp Connector name using the form:
        /// `projects/{project_id}/locations/{location_id}/appConnections/{app_connection_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, AppConnectionOperationMetadata> DeleteAppConnection(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAppConnection(new DeleteAppConnectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single AppConnection.
        /// </summary>
        /// <param name="name">
        /// Required. BeyondCorp Connector name using the form:
        /// `projects/{project_id}/locations/{location_id}/appConnections/{app_connection_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, AppConnectionOperationMetadata>> DeleteAppConnectionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAppConnectionAsync(new DeleteAppConnectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single AppConnection.
        /// </summary>
        /// <param name="name">
        /// Required. BeyondCorp Connector name using the form:
        /// `projects/{project_id}/locations/{location_id}/appConnections/{app_connection_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, AppConnectionOperationMetadata>> DeleteAppConnectionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAppConnectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single AppConnection.
        /// </summary>
        /// <param name="name">
        /// Required. BeyondCorp Connector name using the form:
        /// `projects/{project_id}/locations/{location_id}/appConnections/{app_connection_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, AppConnectionOperationMetadata> DeleteAppConnection(AppConnectionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAppConnection(new DeleteAppConnectionRequest
            {
                AppConnectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single AppConnection.
        /// </summary>
        /// <param name="name">
        /// Required. BeyondCorp Connector name using the form:
        /// `projects/{project_id}/locations/{location_id}/appConnections/{app_connection_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, AppConnectionOperationMetadata>> DeleteAppConnectionAsync(AppConnectionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAppConnectionAsync(new DeleteAppConnectionRequest
            {
                AppConnectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single AppConnection.
        /// </summary>
        /// <param name="name">
        /// Required. BeyondCorp Connector name using the form:
        /// `projects/{project_id}/locations/{location_id}/appConnections/{app_connection_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, AppConnectionOperationMetadata>> DeleteAppConnectionAsync(AppConnectionName name, st::CancellationToken cancellationToken) =>
            DeleteAppConnectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resolves AppConnections details for a given AppConnector.
        /// An internal method called by a connector to find AppConnections to connect
        /// to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable sequence of <see cref="ResolveAppConnectionsResponse.Types.AppConnectionDetails"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ResolveAppConnectionsResponse, ResolveAppConnectionsResponse.Types.AppConnectionDetails> ResolveAppConnections(ResolveAppConnectionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resolves AppConnections details for a given AppConnector.
        /// An internal method called by a connector to find AppConnections to connect
        /// to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ResolveAppConnectionsResponse.Types.AppConnectionDetails"/>
        /// resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ResolveAppConnectionsResponse, ResolveAppConnectionsResponse.Types.AppConnectionDetails> ResolveAppConnectionsAsync(ResolveAppConnectionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resolves AppConnections details for a given AppConnector.
        /// An internal method called by a connector to find AppConnections to connect
        /// to.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the AppConnection location using the form:
        /// `projects/{project_id}/locations/{location_id}`
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
        /// <returns>
        /// A pageable sequence of <see cref="ResolveAppConnectionsResponse.Types.AppConnectionDetails"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ResolveAppConnectionsResponse, ResolveAppConnectionsResponse.Types.AppConnectionDetails> ResolveAppConnections(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ResolveAppConnectionsRequest request = new ResolveAppConnectionsRequest
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
            return ResolveAppConnections(request, callSettings);
        }

        /// <summary>
        /// Resolves AppConnections details for a given AppConnector.
        /// An internal method called by a connector to find AppConnections to connect
        /// to.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the AppConnection location using the form:
        /// `projects/{project_id}/locations/{location_id}`
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
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ResolveAppConnectionsResponse.Types.AppConnectionDetails"/>
        /// resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ResolveAppConnectionsResponse, ResolveAppConnectionsResponse.Types.AppConnectionDetails> ResolveAppConnectionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ResolveAppConnectionsRequest request = new ResolveAppConnectionsRequest
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
            return ResolveAppConnectionsAsync(request, callSettings);
        }

        /// <summary>
        /// Resolves AppConnections details for a given AppConnector.
        /// An internal method called by a connector to find AppConnections to connect
        /// to.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the AppConnection location using the form:
        /// `projects/{project_id}/locations/{location_id}`
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
        /// <returns>
        /// A pageable sequence of <see cref="ResolveAppConnectionsResponse.Types.AppConnectionDetails"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ResolveAppConnectionsResponse, ResolveAppConnectionsResponse.Types.AppConnectionDetails> ResolveAppConnections(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ResolveAppConnectionsRequest request = new ResolveAppConnectionsRequest
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
            return ResolveAppConnections(request, callSettings);
        }

        /// <summary>
        /// Resolves AppConnections details for a given AppConnector.
        /// An internal method called by a connector to find AppConnections to connect
        /// to.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the AppConnection location using the form:
        /// `projects/{project_id}/locations/{location_id}`
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
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ResolveAppConnectionsResponse.Types.AppConnectionDetails"/>
        /// resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ResolveAppConnectionsResponse, ResolveAppConnectionsResponse.Types.AppConnectionDetails> ResolveAppConnectionsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ResolveAppConnectionsRequest request = new ResolveAppConnectionsRequest
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
            return ResolveAppConnectionsAsync(request, callSettings);
        }
    }

    /// <summary>AppConnectionsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// API Overview:
    /// 
    /// The `beyondcorp.googleapis.com` service implements the Google Cloud
    /// BeyondCorp API.
    /// 
    /// Data Model:
    /// 
    /// The AppConnectionsService exposes the following resources:
    /// 
    /// * AppConnections, named as follows:
    /// `projects/{project_id}/locations/{location_id}/appConnections/{app_connection_id}`.
    /// 
    /// The AppConnectionsService service provides methods to manage
    /// (create/read/update/delete) BeyondCorp AppConnections.
    /// </remarks>
    public sealed partial class AppConnectionsServiceClientImpl : AppConnectionsServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListAppConnectionsRequest, ListAppConnectionsResponse> _callListAppConnections;

        private readonly gaxgrpc::ApiCall<GetAppConnectionRequest, AppConnection> _callGetAppConnection;

        private readonly gaxgrpc::ApiCall<CreateAppConnectionRequest, lro::Operation> _callCreateAppConnection;

        private readonly gaxgrpc::ApiCall<UpdateAppConnectionRequest, lro::Operation> _callUpdateAppConnection;

        private readonly gaxgrpc::ApiCall<DeleteAppConnectionRequest, lro::Operation> _callDeleteAppConnection;

        private readonly gaxgrpc::ApiCall<ResolveAppConnectionsRequest, ResolveAppConnectionsResponse> _callResolveAppConnections;

        /// <summary>
        /// Constructs a client wrapper for the AppConnectionsService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AppConnectionsServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AppConnectionsServiceClientImpl(AppConnectionsService.AppConnectionsServiceClient grpcClient, AppConnectionsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AppConnectionsServiceSettings effectiveSettings = settings ?? AppConnectionsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateAppConnectionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateAppConnectionOperationsSettings, logger);
            UpdateAppConnectionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateAppConnectionOperationsSettings, logger);
            DeleteAppConnectionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteAppConnectionOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListAppConnections = clientHelper.BuildApiCall<ListAppConnectionsRequest, ListAppConnectionsResponse>("ListAppConnections", grpcClient.ListAppConnectionsAsync, grpcClient.ListAppConnections, effectiveSettings.ListAppConnectionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAppConnections);
            Modify_ListAppConnectionsApiCall(ref _callListAppConnections);
            _callGetAppConnection = clientHelper.BuildApiCall<GetAppConnectionRequest, AppConnection>("GetAppConnection", grpcClient.GetAppConnectionAsync, grpcClient.GetAppConnection, effectiveSettings.GetAppConnectionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAppConnection);
            Modify_GetAppConnectionApiCall(ref _callGetAppConnection);
            _callCreateAppConnection = clientHelper.BuildApiCall<CreateAppConnectionRequest, lro::Operation>("CreateAppConnection", grpcClient.CreateAppConnectionAsync, grpcClient.CreateAppConnection, effectiveSettings.CreateAppConnectionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAppConnection);
            Modify_CreateAppConnectionApiCall(ref _callCreateAppConnection);
            _callUpdateAppConnection = clientHelper.BuildApiCall<UpdateAppConnectionRequest, lro::Operation>("UpdateAppConnection", grpcClient.UpdateAppConnectionAsync, grpcClient.UpdateAppConnection, effectiveSettings.UpdateAppConnectionSettings).WithGoogleRequestParam("app_connection.name", request => request.AppConnection?.Name);
            Modify_ApiCall(ref _callUpdateAppConnection);
            Modify_UpdateAppConnectionApiCall(ref _callUpdateAppConnection);
            _callDeleteAppConnection = clientHelper.BuildApiCall<DeleteAppConnectionRequest, lro::Operation>("DeleteAppConnection", grpcClient.DeleteAppConnectionAsync, grpcClient.DeleteAppConnection, effectiveSettings.DeleteAppConnectionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAppConnection);
            Modify_DeleteAppConnectionApiCall(ref _callDeleteAppConnection);
            _callResolveAppConnections = clientHelper.BuildApiCall<ResolveAppConnectionsRequest, ResolveAppConnectionsResponse>("ResolveAppConnections", grpcClient.ResolveAppConnectionsAsync, grpcClient.ResolveAppConnections, effectiveSettings.ResolveAppConnectionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callResolveAppConnections);
            Modify_ResolveAppConnectionsApiCall(ref _callResolveAppConnections);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListAppConnectionsApiCall(ref gaxgrpc::ApiCall<ListAppConnectionsRequest, ListAppConnectionsResponse> call);

        partial void Modify_GetAppConnectionApiCall(ref gaxgrpc::ApiCall<GetAppConnectionRequest, AppConnection> call);

        partial void Modify_CreateAppConnectionApiCall(ref gaxgrpc::ApiCall<CreateAppConnectionRequest, lro::Operation> call);

        partial void Modify_UpdateAppConnectionApiCall(ref gaxgrpc::ApiCall<UpdateAppConnectionRequest, lro::Operation> call);

        partial void Modify_DeleteAppConnectionApiCall(ref gaxgrpc::ApiCall<DeleteAppConnectionRequest, lro::Operation> call);

        partial void Modify_ResolveAppConnectionsApiCall(ref gaxgrpc::ApiCall<ResolveAppConnectionsRequest, ResolveAppConnectionsResponse> call);

        partial void OnConstruction(AppConnectionsService.AppConnectionsServiceClient grpcClient, AppConnectionsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AppConnectionsService client</summary>
        public override AppConnectionsService.AppConnectionsServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListAppConnectionsRequest(ref ListAppConnectionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAppConnectionRequest(ref GetAppConnectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAppConnectionRequest(ref CreateAppConnectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAppConnectionRequest(ref UpdateAppConnectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAppConnectionRequest(ref DeleteAppConnectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ResolveAppConnectionsRequest(ref ResolveAppConnectionsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists AppConnections in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AppConnection"/> resources.</returns>
        public override gax::PagedEnumerable<ListAppConnectionsResponse, AppConnection> ListAppConnections(ListAppConnectionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAppConnectionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAppConnectionsRequest, ListAppConnectionsResponse, AppConnection>(_callListAppConnections, request, callSettings);
        }

        /// <summary>
        /// Lists AppConnections in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AppConnection"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAppConnectionsResponse, AppConnection> ListAppConnectionsAsync(ListAppConnectionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAppConnectionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAppConnectionsRequest, ListAppConnectionsResponse, AppConnection>(_callListAppConnections, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single AppConnection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AppConnection GetAppConnection(GetAppConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAppConnectionRequest(ref request, ref callSettings);
            return _callGetAppConnection.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single AppConnection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AppConnection> GetAppConnectionAsync(GetAppConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAppConnectionRequest(ref request, ref callSettings);
            return _callGetAppConnection.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateAppConnection</c>.</summary>
        public override lro::OperationsClient CreateAppConnectionOperationsClient { get; }

        /// <summary>
        /// Creates a new AppConnection in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AppConnection, AppConnectionOperationMetadata> CreateAppConnection(CreateAppConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAppConnectionRequest(ref request, ref callSettings);
            return new lro::Operation<AppConnection, AppConnectionOperationMetadata>(_callCreateAppConnection.Sync(request, callSettings), CreateAppConnectionOperationsClient);
        }

        /// <summary>
        /// Creates a new AppConnection in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AppConnection, AppConnectionOperationMetadata>> CreateAppConnectionAsync(CreateAppConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAppConnectionRequest(ref request, ref callSettings);
            return new lro::Operation<AppConnection, AppConnectionOperationMetadata>(await _callCreateAppConnection.Async(request, callSettings).ConfigureAwait(false), CreateAppConnectionOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateAppConnection</c>.</summary>
        public override lro::OperationsClient UpdateAppConnectionOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single AppConnection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AppConnection, AppConnectionOperationMetadata> UpdateAppConnection(UpdateAppConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAppConnectionRequest(ref request, ref callSettings);
            return new lro::Operation<AppConnection, AppConnectionOperationMetadata>(_callUpdateAppConnection.Sync(request, callSettings), UpdateAppConnectionOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single AppConnection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AppConnection, AppConnectionOperationMetadata>> UpdateAppConnectionAsync(UpdateAppConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAppConnectionRequest(ref request, ref callSettings);
            return new lro::Operation<AppConnection, AppConnectionOperationMetadata>(await _callUpdateAppConnection.Async(request, callSettings).ConfigureAwait(false), UpdateAppConnectionOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteAppConnection</c>.</summary>
        public override lro::OperationsClient DeleteAppConnectionOperationsClient { get; }

        /// <summary>
        /// Deletes a single AppConnection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, AppConnectionOperationMetadata> DeleteAppConnection(DeleteAppConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAppConnectionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, AppConnectionOperationMetadata>(_callDeleteAppConnection.Sync(request, callSettings), DeleteAppConnectionOperationsClient);
        }

        /// <summary>
        /// Deletes a single AppConnection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, AppConnectionOperationMetadata>> DeleteAppConnectionAsync(DeleteAppConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAppConnectionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, AppConnectionOperationMetadata>(await _callDeleteAppConnection.Async(request, callSettings).ConfigureAwait(false), DeleteAppConnectionOperationsClient);
        }

        /// <summary>
        /// Resolves AppConnections details for a given AppConnector.
        /// An internal method called by a connector to find AppConnections to connect
        /// to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable sequence of <see cref="ResolveAppConnectionsResponse.Types.AppConnectionDetails"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ResolveAppConnectionsResponse, ResolveAppConnectionsResponse.Types.AppConnectionDetails> ResolveAppConnections(ResolveAppConnectionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResolveAppConnectionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ResolveAppConnectionsRequest, ResolveAppConnectionsResponse, ResolveAppConnectionsResponse.Types.AppConnectionDetails>(_callResolveAppConnections, request, callSettings);
        }

        /// <summary>
        /// Resolves AppConnections details for a given AppConnector.
        /// An internal method called by a connector to find AppConnections to connect
        /// to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ResolveAppConnectionsResponse.Types.AppConnectionDetails"/>
        /// resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ResolveAppConnectionsResponse, ResolveAppConnectionsResponse.Types.AppConnectionDetails> ResolveAppConnectionsAsync(ResolveAppConnectionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResolveAppConnectionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ResolveAppConnectionsRequest, ResolveAppConnectionsResponse, ResolveAppConnectionsResponse.Types.AppConnectionDetails>(_callResolveAppConnections, request, callSettings);
        }
    }

    public partial class ListAppConnectionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ResolveAppConnectionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAppConnectionsResponse : gaxgrpc::IPageResponse<AppConnection>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AppConnection> GetEnumerator() => AppConnections.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ResolveAppConnectionsResponse : gaxgrpc::IPageResponse<ResolveAppConnectionsResponse.Types.AppConnectionDetails>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Types.AppConnectionDetails> GetEnumerator() => AppConnectionDetails.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class AppConnectionsService
    {
        public partial class AppConnectionsServiceClient
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

    public static partial class AppConnectionsService
    {
        public partial class AppConnectionsServiceClient
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

            /// <summary>
            /// Creates a new instance of <see cref="gciv::IAMPolicy.IAMPolicyClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gciv::IAMPolicy.IAMPolicyClient"/> for the same target as this client.
            /// </returns>
            public virtual gciv::IAMPolicy.IAMPolicyClient CreateIAMPolicyClient() =>
                new gciv::IAMPolicy.IAMPolicyClient(CallInvoker);
        }
    }
}
