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

namespace Google.Cloud.BeyondCorp.AppGateways.V1
{
    /// <summary>Settings for <see cref="AppGatewaysServiceClient"/> instances.</summary>
    public sealed partial class AppGatewaysServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AppGatewaysServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AppGatewaysServiceSettings"/>.</returns>
        public static AppGatewaysServiceSettings GetDefault() => new AppGatewaysServiceSettings();

        /// <summary>Constructs a new <see cref="AppGatewaysServiceSettings"/> object with default settings.</summary>
        public AppGatewaysServiceSettings()
        {
        }

        private AppGatewaysServiceSettings(AppGatewaysServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListAppGatewaysSettings = existing.ListAppGatewaysSettings;
            GetAppGatewaySettings = existing.GetAppGatewaySettings;
            CreateAppGatewaySettings = existing.CreateAppGatewaySettings;
            CreateAppGatewayOperationsSettings = existing.CreateAppGatewayOperationsSettings.Clone();
            DeleteAppGatewaySettings = existing.DeleteAppGatewaySettings;
            DeleteAppGatewayOperationsSettings = existing.DeleteAppGatewayOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(AppGatewaysServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppGatewaysServiceClient.ListAppGateways</c> and <c>AppGatewaysServiceClient.ListAppGatewaysAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAppGatewaysSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppGatewaysServiceClient.GetAppGateway</c> and <c>AppGatewaysServiceClient.GetAppGatewayAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAppGatewaySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppGatewaysServiceClient.CreateAppGateway</c> and <c>AppGatewaysServiceClient.CreateAppGatewayAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAppGatewaySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>AppGatewaysServiceClient.CreateAppGateway</c> and
        /// <c>AppGatewaysServiceClient.CreateAppGatewayAsync</c>.
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
        public lro::OperationsSettings CreateAppGatewayOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppGatewaysServiceClient.DeleteAppGateway</c> and <c>AppGatewaysServiceClient.DeleteAppGatewayAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAppGatewaySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>AppGatewaysServiceClient.DeleteAppGateway</c> and
        /// <c>AppGatewaysServiceClient.DeleteAppGatewayAsync</c>.
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
        public lro::OperationsSettings DeleteAppGatewayOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AppGatewaysServiceSettings"/> object.</returns>
        public AppGatewaysServiceSettings Clone() => new AppGatewaysServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AppGatewaysServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class AppGatewaysServiceClientBuilder : gaxgrpc::ClientBuilderBase<AppGatewaysServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AppGatewaysServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AppGatewaysServiceClientBuilder() : base(AppGatewaysServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AppGatewaysServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AppGatewaysServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AppGatewaysServiceClient Build()
        {
            AppGatewaysServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AppGatewaysServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AppGatewaysServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AppGatewaysServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AppGatewaysServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AppGatewaysServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AppGatewaysServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AppGatewaysServiceClient.ChannelPool;
    }

    /// <summary>AppGatewaysService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// API Overview:
    /// 
    /// The `beyondcorp.googleapis.com` service implements the Google Cloud
    /// BeyondCorp API.
    /// 
    /// Data Model:
    /// 
    /// The AppGatewaysService exposes the following resources:
    /// 
    /// * AppGateways, named as follows:
    /// `projects/{project_id}/locations/{location_id}/appGateways/{app_gateway_id}`.
    /// 
    /// The AppGatewaysService service provides methods to manage
    /// (create/read/update/delete) BeyondCorp AppGateways.
    /// </remarks>
    public abstract partial class AppGatewaysServiceClient
    {
        /// <summary>
        /// The default endpoint for the AppGatewaysService service, which is a host of "beyondcorp.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "beyondcorp.googleapis.com:443";

        /// <summary>The default AppGatewaysService scopes.</summary>
        /// <remarks>
        /// The default AppGatewaysService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AppGatewaysService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AppGatewaysServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AppGatewaysServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AppGatewaysServiceClient"/>.</returns>
        public static stt::Task<AppGatewaysServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AppGatewaysServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AppGatewaysServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AppGatewaysServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="AppGatewaysServiceClient"/>.</returns>
        public static AppGatewaysServiceClient Create() => new AppGatewaysServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AppGatewaysServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AppGatewaysServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AppGatewaysServiceClient"/>.</returns>
        internal static AppGatewaysServiceClient Create(grpccore::CallInvoker callInvoker, AppGatewaysServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AppGatewaysService.AppGatewaysServiceClient grpcClient = new AppGatewaysService.AppGatewaysServiceClient(callInvoker);
            return new AppGatewaysServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AppGatewaysService client</summary>
        public virtual AppGatewaysService.AppGatewaysServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists AppGateways in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AppGateway"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAppGatewaysResponse, AppGateway> ListAppGateways(ListAppGatewaysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists AppGateways in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AppGateway"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAppGatewaysResponse, AppGateway> ListAppGatewaysAsync(ListAppGatewaysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists AppGateways in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the AppGateway location using the form:
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
        /// <returns>A pageable sequence of <see cref="AppGateway"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAppGatewaysResponse, AppGateway> ListAppGateways(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAppGatewaysRequest request = new ListAppGatewaysRequest
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
            return ListAppGateways(request, callSettings);
        }

        /// <summary>
        /// Lists AppGateways in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the AppGateway location using the form:
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
        /// <returns>A pageable asynchronous sequence of <see cref="AppGateway"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAppGatewaysResponse, AppGateway> ListAppGatewaysAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAppGatewaysRequest request = new ListAppGatewaysRequest
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
            return ListAppGatewaysAsync(request, callSettings);
        }

        /// <summary>
        /// Lists AppGateways in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the AppGateway location using the form:
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
        /// <returns>A pageable sequence of <see cref="AppGateway"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAppGatewaysResponse, AppGateway> ListAppGateways(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAppGatewaysRequest request = new ListAppGatewaysRequest
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
            return ListAppGateways(request, callSettings);
        }

        /// <summary>
        /// Lists AppGateways in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the AppGateway location using the form:
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
        /// <returns>A pageable asynchronous sequence of <see cref="AppGateway"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAppGatewaysResponse, AppGateway> ListAppGatewaysAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAppGatewaysRequest request = new ListAppGatewaysRequest
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
            return ListAppGatewaysAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single AppGateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AppGateway GetAppGateway(GetAppGatewayRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single AppGateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppGateway> GetAppGatewayAsync(GetAppGatewayRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single AppGateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppGateway> GetAppGatewayAsync(GetAppGatewayRequest request, st::CancellationToken cancellationToken) =>
            GetAppGatewayAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single AppGateway.
        /// </summary>
        /// <param name="name">
        /// Required. BeyondCorp AppGateway name using the form:
        /// `projects/{project_id}/locations/{location_id}/appGateways/{app_gateway_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AppGateway GetAppGateway(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAppGateway(new GetAppGatewayRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single AppGateway.
        /// </summary>
        /// <param name="name">
        /// Required. BeyondCorp AppGateway name using the form:
        /// `projects/{project_id}/locations/{location_id}/appGateways/{app_gateway_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppGateway> GetAppGatewayAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAppGatewayAsync(new GetAppGatewayRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single AppGateway.
        /// </summary>
        /// <param name="name">
        /// Required. BeyondCorp AppGateway name using the form:
        /// `projects/{project_id}/locations/{location_id}/appGateways/{app_gateway_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppGateway> GetAppGatewayAsync(string name, st::CancellationToken cancellationToken) =>
            GetAppGatewayAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single AppGateway.
        /// </summary>
        /// <param name="name">
        /// Required. BeyondCorp AppGateway name using the form:
        /// `projects/{project_id}/locations/{location_id}/appGateways/{app_gateway_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AppGateway GetAppGateway(AppGatewayName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAppGateway(new GetAppGatewayRequest
            {
                AppGatewayName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single AppGateway.
        /// </summary>
        /// <param name="name">
        /// Required. BeyondCorp AppGateway name using the form:
        /// `projects/{project_id}/locations/{location_id}/appGateways/{app_gateway_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppGateway> GetAppGatewayAsync(AppGatewayName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAppGatewayAsync(new GetAppGatewayRequest
            {
                AppGatewayName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single AppGateway.
        /// </summary>
        /// <param name="name">
        /// Required. BeyondCorp AppGateway name using the form:
        /// `projects/{project_id}/locations/{location_id}/appGateways/{app_gateway_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppGateway> GetAppGatewayAsync(AppGatewayName name, st::CancellationToken cancellationToken) =>
            GetAppGatewayAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new AppGateway in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AppGateway, AppGatewayOperationMetadata> CreateAppGateway(CreateAppGatewayRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new AppGateway in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AppGateway, AppGatewayOperationMetadata>> CreateAppGatewayAsync(CreateAppGatewayRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new AppGateway in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AppGateway, AppGatewayOperationMetadata>> CreateAppGatewayAsync(CreateAppGatewayRequest request, st::CancellationToken cancellationToken) =>
            CreateAppGatewayAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateAppGateway</c>.</summary>
        public virtual lro::OperationsClient CreateAppGatewayOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateAppGateway</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AppGateway, AppGatewayOperationMetadata> PollOnceCreateAppGateway(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AppGateway, AppGatewayOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAppGatewayOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateAppGateway</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AppGateway, AppGatewayOperationMetadata>> PollOnceCreateAppGatewayAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AppGateway, AppGatewayOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAppGatewayOperationsClient, callSettings);

        /// <summary>
        /// Creates a new AppGateway in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource project name of the AppGateway location using the
        /// form: `projects/{project_id}/locations/{location_id}`
        /// </param>
        /// <param name="appGateway">
        /// Required. A BeyondCorp AppGateway resource.
        /// </param>
        /// <param name="appGatewayId">
        /// Optional. User-settable AppGateway resource ID.
        /// * Must start with a letter.
        /// * Must contain between 4-63 characters from `/[a-z][0-9]-/`.
        /// * Must end with a number or a letter.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AppGateway, AppGatewayOperationMetadata> CreateAppGateway(string parent, AppGateway appGateway, string appGatewayId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAppGateway(new CreateAppGatewayRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AppGatewayId = appGatewayId ?? "",
                AppGateway = gax::GaxPreconditions.CheckNotNull(appGateway, nameof(appGateway)),
            }, callSettings);

        /// <summary>
        /// Creates a new AppGateway in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource project name of the AppGateway location using the
        /// form: `projects/{project_id}/locations/{location_id}`
        /// </param>
        /// <param name="appGateway">
        /// Required. A BeyondCorp AppGateway resource.
        /// </param>
        /// <param name="appGatewayId">
        /// Optional. User-settable AppGateway resource ID.
        /// * Must start with a letter.
        /// * Must contain between 4-63 characters from `/[a-z][0-9]-/`.
        /// * Must end with a number or a letter.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AppGateway, AppGatewayOperationMetadata>> CreateAppGatewayAsync(string parent, AppGateway appGateway, string appGatewayId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAppGatewayAsync(new CreateAppGatewayRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AppGatewayId = appGatewayId ?? "",
                AppGateway = gax::GaxPreconditions.CheckNotNull(appGateway, nameof(appGateway)),
            }, callSettings);

        /// <summary>
        /// Creates a new AppGateway in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource project name of the AppGateway location using the
        /// form: `projects/{project_id}/locations/{location_id}`
        /// </param>
        /// <param name="appGateway">
        /// Required. A BeyondCorp AppGateway resource.
        /// </param>
        /// <param name="appGatewayId">
        /// Optional. User-settable AppGateway resource ID.
        /// * Must start with a letter.
        /// * Must contain between 4-63 characters from `/[a-z][0-9]-/`.
        /// * Must end with a number or a letter.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AppGateway, AppGatewayOperationMetadata>> CreateAppGatewayAsync(string parent, AppGateway appGateway, string appGatewayId, st::CancellationToken cancellationToken) =>
            CreateAppGatewayAsync(parent, appGateway, appGatewayId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new AppGateway in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource project name of the AppGateway location using the
        /// form: `projects/{project_id}/locations/{location_id}`
        /// </param>
        /// <param name="appGateway">
        /// Required. A BeyondCorp AppGateway resource.
        /// </param>
        /// <param name="appGatewayId">
        /// Optional. User-settable AppGateway resource ID.
        /// * Must start with a letter.
        /// * Must contain between 4-63 characters from `/[a-z][0-9]-/`.
        /// * Must end with a number or a letter.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AppGateway, AppGatewayOperationMetadata> CreateAppGateway(gagr::LocationName parent, AppGateway appGateway, string appGatewayId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAppGateway(new CreateAppGatewayRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AppGatewayId = appGatewayId ?? "",
                AppGateway = gax::GaxPreconditions.CheckNotNull(appGateway, nameof(appGateway)),
            }, callSettings);

        /// <summary>
        /// Creates a new AppGateway in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource project name of the AppGateway location using the
        /// form: `projects/{project_id}/locations/{location_id}`
        /// </param>
        /// <param name="appGateway">
        /// Required. A BeyondCorp AppGateway resource.
        /// </param>
        /// <param name="appGatewayId">
        /// Optional. User-settable AppGateway resource ID.
        /// * Must start with a letter.
        /// * Must contain between 4-63 characters from `/[a-z][0-9]-/`.
        /// * Must end with a number or a letter.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AppGateway, AppGatewayOperationMetadata>> CreateAppGatewayAsync(gagr::LocationName parent, AppGateway appGateway, string appGatewayId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAppGatewayAsync(new CreateAppGatewayRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AppGatewayId = appGatewayId ?? "",
                AppGateway = gax::GaxPreconditions.CheckNotNull(appGateway, nameof(appGateway)),
            }, callSettings);

        /// <summary>
        /// Creates a new AppGateway in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource project name of the AppGateway location using the
        /// form: `projects/{project_id}/locations/{location_id}`
        /// </param>
        /// <param name="appGateway">
        /// Required. A BeyondCorp AppGateway resource.
        /// </param>
        /// <param name="appGatewayId">
        /// Optional. User-settable AppGateway resource ID.
        /// * Must start with a letter.
        /// * Must contain between 4-63 characters from `/[a-z][0-9]-/`.
        /// * Must end with a number or a letter.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AppGateway, AppGatewayOperationMetadata>> CreateAppGatewayAsync(gagr::LocationName parent, AppGateway appGateway, string appGatewayId, st::CancellationToken cancellationToken) =>
            CreateAppGatewayAsync(parent, appGateway, appGatewayId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single AppGateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, AppGatewayOperationMetadata> DeleteAppGateway(DeleteAppGatewayRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single AppGateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, AppGatewayOperationMetadata>> DeleteAppGatewayAsync(DeleteAppGatewayRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single AppGateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, AppGatewayOperationMetadata>> DeleteAppGatewayAsync(DeleteAppGatewayRequest request, st::CancellationToken cancellationToken) =>
            DeleteAppGatewayAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteAppGateway</c>.</summary>
        public virtual lro::OperationsClient DeleteAppGatewayOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteAppGateway</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, AppGatewayOperationMetadata> PollOnceDeleteAppGateway(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, AppGatewayOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAppGatewayOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteAppGateway</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, AppGatewayOperationMetadata>> PollOnceDeleteAppGatewayAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, AppGatewayOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAppGatewayOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single AppGateway.
        /// </summary>
        /// <param name="name">
        /// Required. BeyondCorp AppGateway name using the form:
        /// `projects/{project_id}/locations/{location_id}/appGateways/{app_gateway_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, AppGatewayOperationMetadata> DeleteAppGateway(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAppGateway(new DeleteAppGatewayRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single AppGateway.
        /// </summary>
        /// <param name="name">
        /// Required. BeyondCorp AppGateway name using the form:
        /// `projects/{project_id}/locations/{location_id}/appGateways/{app_gateway_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, AppGatewayOperationMetadata>> DeleteAppGatewayAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAppGatewayAsync(new DeleteAppGatewayRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single AppGateway.
        /// </summary>
        /// <param name="name">
        /// Required. BeyondCorp AppGateway name using the form:
        /// `projects/{project_id}/locations/{location_id}/appGateways/{app_gateway_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, AppGatewayOperationMetadata>> DeleteAppGatewayAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAppGatewayAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single AppGateway.
        /// </summary>
        /// <param name="name">
        /// Required. BeyondCorp AppGateway name using the form:
        /// `projects/{project_id}/locations/{location_id}/appGateways/{app_gateway_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, AppGatewayOperationMetadata> DeleteAppGateway(AppGatewayName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAppGateway(new DeleteAppGatewayRequest
            {
                AppGatewayName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single AppGateway.
        /// </summary>
        /// <param name="name">
        /// Required. BeyondCorp AppGateway name using the form:
        /// `projects/{project_id}/locations/{location_id}/appGateways/{app_gateway_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, AppGatewayOperationMetadata>> DeleteAppGatewayAsync(AppGatewayName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAppGatewayAsync(new DeleteAppGatewayRequest
            {
                AppGatewayName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single AppGateway.
        /// </summary>
        /// <param name="name">
        /// Required. BeyondCorp AppGateway name using the form:
        /// `projects/{project_id}/locations/{location_id}/appGateways/{app_gateway_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, AppGatewayOperationMetadata>> DeleteAppGatewayAsync(AppGatewayName name, st::CancellationToken cancellationToken) =>
            DeleteAppGatewayAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AppGatewaysService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// API Overview:
    /// 
    /// The `beyondcorp.googleapis.com` service implements the Google Cloud
    /// BeyondCorp API.
    /// 
    /// Data Model:
    /// 
    /// The AppGatewaysService exposes the following resources:
    /// 
    /// * AppGateways, named as follows:
    /// `projects/{project_id}/locations/{location_id}/appGateways/{app_gateway_id}`.
    /// 
    /// The AppGatewaysService service provides methods to manage
    /// (create/read/update/delete) BeyondCorp AppGateways.
    /// </remarks>
    public sealed partial class AppGatewaysServiceClientImpl : AppGatewaysServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListAppGatewaysRequest, ListAppGatewaysResponse> _callListAppGateways;

        private readonly gaxgrpc::ApiCall<GetAppGatewayRequest, AppGateway> _callGetAppGateway;

        private readonly gaxgrpc::ApiCall<CreateAppGatewayRequest, lro::Operation> _callCreateAppGateway;

        private readonly gaxgrpc::ApiCall<DeleteAppGatewayRequest, lro::Operation> _callDeleteAppGateway;

        /// <summary>
        /// Constructs a client wrapper for the AppGatewaysService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AppGatewaysServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AppGatewaysServiceClientImpl(AppGatewaysService.AppGatewaysServiceClient grpcClient, AppGatewaysServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AppGatewaysServiceSettings effectiveSettings = settings ?? AppGatewaysServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateAppGatewayOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateAppGatewayOperationsSettings, logger);
            DeleteAppGatewayOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteAppGatewayOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListAppGateways = clientHelper.BuildApiCall<ListAppGatewaysRequest, ListAppGatewaysResponse>("ListAppGateways", grpcClient.ListAppGatewaysAsync, grpcClient.ListAppGateways, effectiveSettings.ListAppGatewaysSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAppGateways);
            Modify_ListAppGatewaysApiCall(ref _callListAppGateways);
            _callGetAppGateway = clientHelper.BuildApiCall<GetAppGatewayRequest, AppGateway>("GetAppGateway", grpcClient.GetAppGatewayAsync, grpcClient.GetAppGateway, effectiveSettings.GetAppGatewaySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAppGateway);
            Modify_GetAppGatewayApiCall(ref _callGetAppGateway);
            _callCreateAppGateway = clientHelper.BuildApiCall<CreateAppGatewayRequest, lro::Operation>("CreateAppGateway", grpcClient.CreateAppGatewayAsync, grpcClient.CreateAppGateway, effectiveSettings.CreateAppGatewaySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAppGateway);
            Modify_CreateAppGatewayApiCall(ref _callCreateAppGateway);
            _callDeleteAppGateway = clientHelper.BuildApiCall<DeleteAppGatewayRequest, lro::Operation>("DeleteAppGateway", grpcClient.DeleteAppGatewayAsync, grpcClient.DeleteAppGateway, effectiveSettings.DeleteAppGatewaySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAppGateway);
            Modify_DeleteAppGatewayApiCall(ref _callDeleteAppGateway);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListAppGatewaysApiCall(ref gaxgrpc::ApiCall<ListAppGatewaysRequest, ListAppGatewaysResponse> call);

        partial void Modify_GetAppGatewayApiCall(ref gaxgrpc::ApiCall<GetAppGatewayRequest, AppGateway> call);

        partial void Modify_CreateAppGatewayApiCall(ref gaxgrpc::ApiCall<CreateAppGatewayRequest, lro::Operation> call);

        partial void Modify_DeleteAppGatewayApiCall(ref gaxgrpc::ApiCall<DeleteAppGatewayRequest, lro::Operation> call);

        partial void OnConstruction(AppGatewaysService.AppGatewaysServiceClient grpcClient, AppGatewaysServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AppGatewaysService client</summary>
        public override AppGatewaysService.AppGatewaysServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListAppGatewaysRequest(ref ListAppGatewaysRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAppGatewayRequest(ref GetAppGatewayRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAppGatewayRequest(ref CreateAppGatewayRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAppGatewayRequest(ref DeleteAppGatewayRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists AppGateways in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AppGateway"/> resources.</returns>
        public override gax::PagedEnumerable<ListAppGatewaysResponse, AppGateway> ListAppGateways(ListAppGatewaysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAppGatewaysRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAppGatewaysRequest, ListAppGatewaysResponse, AppGateway>(_callListAppGateways, request, callSettings);
        }

        /// <summary>
        /// Lists AppGateways in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AppGateway"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAppGatewaysResponse, AppGateway> ListAppGatewaysAsync(ListAppGatewaysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAppGatewaysRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAppGatewaysRequest, ListAppGatewaysResponse, AppGateway>(_callListAppGateways, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single AppGateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AppGateway GetAppGateway(GetAppGatewayRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAppGatewayRequest(ref request, ref callSettings);
            return _callGetAppGateway.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single AppGateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AppGateway> GetAppGatewayAsync(GetAppGatewayRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAppGatewayRequest(ref request, ref callSettings);
            return _callGetAppGateway.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateAppGateway</c>.</summary>
        public override lro::OperationsClient CreateAppGatewayOperationsClient { get; }

        /// <summary>
        /// Creates a new AppGateway in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AppGateway, AppGatewayOperationMetadata> CreateAppGateway(CreateAppGatewayRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAppGatewayRequest(ref request, ref callSettings);
            return new lro::Operation<AppGateway, AppGatewayOperationMetadata>(_callCreateAppGateway.Sync(request, callSettings), CreateAppGatewayOperationsClient);
        }

        /// <summary>
        /// Creates a new AppGateway in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AppGateway, AppGatewayOperationMetadata>> CreateAppGatewayAsync(CreateAppGatewayRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAppGatewayRequest(ref request, ref callSettings);
            return new lro::Operation<AppGateway, AppGatewayOperationMetadata>(await _callCreateAppGateway.Async(request, callSettings).ConfigureAwait(false), CreateAppGatewayOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteAppGateway</c>.</summary>
        public override lro::OperationsClient DeleteAppGatewayOperationsClient { get; }

        /// <summary>
        /// Deletes a single AppGateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, AppGatewayOperationMetadata> DeleteAppGateway(DeleteAppGatewayRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAppGatewayRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, AppGatewayOperationMetadata>(_callDeleteAppGateway.Sync(request, callSettings), DeleteAppGatewayOperationsClient);
        }

        /// <summary>
        /// Deletes a single AppGateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, AppGatewayOperationMetadata>> DeleteAppGatewayAsync(DeleteAppGatewayRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAppGatewayRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, AppGatewayOperationMetadata>(await _callDeleteAppGateway.Async(request, callSettings).ConfigureAwait(false), DeleteAppGatewayOperationsClient);
        }
    }

    public partial class ListAppGatewaysRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAppGatewaysResponse : gaxgrpc::IPageResponse<AppGateway>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AppGateway> GetEnumerator() => AppGateways.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class AppGatewaysService
    {
        public partial class AppGatewaysServiceClient
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

    public static partial class AppGatewaysService
    {
        public partial class AppGatewaysServiceClient
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
