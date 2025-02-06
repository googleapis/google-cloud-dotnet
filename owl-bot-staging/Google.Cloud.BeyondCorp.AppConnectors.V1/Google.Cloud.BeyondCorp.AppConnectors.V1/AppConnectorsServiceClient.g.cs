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

namespace Google.Cloud.BeyondCorp.AppConnectors.V1
{
    /// <summary>Settings for <see cref="AppConnectorsServiceClient"/> instances.</summary>
    public sealed partial class AppConnectorsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AppConnectorsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AppConnectorsServiceSettings"/>.</returns>
        public static AppConnectorsServiceSettings GetDefault() => new AppConnectorsServiceSettings();

        /// <summary>Constructs a new <see cref="AppConnectorsServiceSettings"/> object with default settings.</summary>
        public AppConnectorsServiceSettings()
        {
        }

        private AppConnectorsServiceSettings(AppConnectorsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListAppConnectorsSettings = existing.ListAppConnectorsSettings;
            GetAppConnectorSettings = existing.GetAppConnectorSettings;
            CreateAppConnectorSettings = existing.CreateAppConnectorSettings;
            CreateAppConnectorOperationsSettings = existing.CreateAppConnectorOperationsSettings.Clone();
            UpdateAppConnectorSettings = existing.UpdateAppConnectorSettings;
            UpdateAppConnectorOperationsSettings = existing.UpdateAppConnectorOperationsSettings.Clone();
            DeleteAppConnectorSettings = existing.DeleteAppConnectorSettings;
            DeleteAppConnectorOperationsSettings = existing.DeleteAppConnectorOperationsSettings.Clone();
            ReportStatusSettings = existing.ReportStatusSettings;
            ReportStatusOperationsSettings = existing.ReportStatusOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(AppConnectorsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppConnectorsServiceClient.ListAppConnectors</c> and <c>AppConnectorsServiceClient.ListAppConnectorsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAppConnectorsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppConnectorsServiceClient.GetAppConnector</c> and <c>AppConnectorsServiceClient.GetAppConnectorAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAppConnectorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppConnectorsServiceClient.CreateAppConnector</c> and
        /// <c>AppConnectorsServiceClient.CreateAppConnectorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAppConnectorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>AppConnectorsServiceClient.CreateAppConnector</c> and
        /// <c>AppConnectorsServiceClient.CreateAppConnectorAsync</c>.
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
        public lro::OperationsSettings CreateAppConnectorOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppConnectorsServiceClient.UpdateAppConnector</c> and
        /// <c>AppConnectorsServiceClient.UpdateAppConnectorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAppConnectorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>AppConnectorsServiceClient.UpdateAppConnector</c> and
        /// <c>AppConnectorsServiceClient.UpdateAppConnectorAsync</c>.
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
        public lro::OperationsSettings UpdateAppConnectorOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppConnectorsServiceClient.DeleteAppConnector</c> and
        /// <c>AppConnectorsServiceClient.DeleteAppConnectorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAppConnectorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>AppConnectorsServiceClient.DeleteAppConnector</c> and
        /// <c>AppConnectorsServiceClient.DeleteAppConnectorAsync</c>.
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
        public lro::OperationsSettings DeleteAppConnectorOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppConnectorsServiceClient.ReportStatus</c> and <c>AppConnectorsServiceClient.ReportStatusAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReportStatusSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>AppConnectorsServiceClient.ReportStatus</c> and
        /// <c>AppConnectorsServiceClient.ReportStatusAsync</c>.
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
        public lro::OperationsSettings ReportStatusOperationsSettings { get; set; } = new lro::OperationsSettings
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
        /// <returns>A deep clone of this <see cref="AppConnectorsServiceSettings"/> object.</returns>
        public AppConnectorsServiceSettings Clone() => new AppConnectorsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AppConnectorsServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class AppConnectorsServiceClientBuilder : gaxgrpc::ClientBuilderBase<AppConnectorsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AppConnectorsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AppConnectorsServiceClientBuilder() : base(AppConnectorsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AppConnectorsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AppConnectorsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AppConnectorsServiceClient Build()
        {
            AppConnectorsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AppConnectorsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AppConnectorsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AppConnectorsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AppConnectorsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AppConnectorsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AppConnectorsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AppConnectorsServiceClient.ChannelPool;
    }

    /// <summary>AppConnectorsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// API Overview:
    /// 
    /// The `beyondcorp.googleapis.com` service implements the Google Cloud
    /// BeyondCorp API.
    /// 
    /// Data Model:
    /// 
    /// The AppConnectorsService exposes the following resource:
    /// 
    /// * AppConnectors, named as follows:
    /// `projects/{project_id}/locations/{location_id}/appConnectors/{app_connector_id}`.
    /// 
    /// The AppConnectorsService provides methods to manage
    /// (create/read/update/delete) BeyondCorp AppConnectors.
    /// </remarks>
    public abstract partial class AppConnectorsServiceClient
    {
        /// <summary>
        /// The default endpoint for the AppConnectorsService service, which is a host of "beyondcorp.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "beyondcorp.googleapis.com:443";

        /// <summary>The default AppConnectorsService scopes.</summary>
        /// <remarks>
        /// The default AppConnectorsService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AppConnectorsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AppConnectorsServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="AppConnectorsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AppConnectorsServiceClient"/>.</returns>
        public static stt::Task<AppConnectorsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AppConnectorsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AppConnectorsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="AppConnectorsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AppConnectorsServiceClient"/>.</returns>
        public static AppConnectorsServiceClient Create() => new AppConnectorsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AppConnectorsServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AppConnectorsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AppConnectorsServiceClient"/>.</returns>
        internal static AppConnectorsServiceClient Create(grpccore::CallInvoker callInvoker, AppConnectorsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AppConnectorsService.AppConnectorsServiceClient grpcClient = new AppConnectorsService.AppConnectorsServiceClient(callInvoker);
            return new AppConnectorsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AppConnectorsService client</summary>
        public virtual AppConnectorsService.AppConnectorsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists AppConnectors in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AppConnector"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAppConnectorsResponse, AppConnector> ListAppConnectors(ListAppConnectorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists AppConnectors in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AppConnector"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAppConnectorsResponse, AppConnector> ListAppConnectorsAsync(ListAppConnectorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists AppConnectors in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the AppConnector location using the form:
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
        /// <returns>A pageable sequence of <see cref="AppConnector"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAppConnectorsResponse, AppConnector> ListAppConnectors(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAppConnectorsRequest request = new ListAppConnectorsRequest
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
            return ListAppConnectors(request, callSettings);
        }

        /// <summary>
        /// Lists AppConnectors in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the AppConnector location using the form:
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
        /// <returns>A pageable asynchronous sequence of <see cref="AppConnector"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAppConnectorsResponse, AppConnector> ListAppConnectorsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAppConnectorsRequest request = new ListAppConnectorsRequest
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
            return ListAppConnectorsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists AppConnectors in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the AppConnector location using the form:
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
        /// <returns>A pageable sequence of <see cref="AppConnector"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAppConnectorsResponse, AppConnector> ListAppConnectors(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAppConnectorsRequest request = new ListAppConnectorsRequest
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
            return ListAppConnectors(request, callSettings);
        }

        /// <summary>
        /// Lists AppConnectors in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the AppConnector location using the form:
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
        /// <returns>A pageable asynchronous sequence of <see cref="AppConnector"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAppConnectorsResponse, AppConnector> ListAppConnectorsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAppConnectorsRequest request = new ListAppConnectorsRequest
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
            return ListAppConnectorsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single AppConnector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AppConnector GetAppConnector(GetAppConnectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single AppConnector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppConnector> GetAppConnectorAsync(GetAppConnectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single AppConnector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppConnector> GetAppConnectorAsync(GetAppConnectorRequest request, st::CancellationToken cancellationToken) =>
            GetAppConnectorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single AppConnector.
        /// </summary>
        /// <param name="name">
        /// Required. BeyondCorp AppConnector name using the form:
        /// `projects/{project_id}/locations/{location_id}/appConnectors/{app_connector_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AppConnector GetAppConnector(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAppConnector(new GetAppConnectorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single AppConnector.
        /// </summary>
        /// <param name="name">
        /// Required. BeyondCorp AppConnector name using the form:
        /// `projects/{project_id}/locations/{location_id}/appConnectors/{app_connector_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppConnector> GetAppConnectorAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAppConnectorAsync(new GetAppConnectorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single AppConnector.
        /// </summary>
        /// <param name="name">
        /// Required. BeyondCorp AppConnector name using the form:
        /// `projects/{project_id}/locations/{location_id}/appConnectors/{app_connector_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppConnector> GetAppConnectorAsync(string name, st::CancellationToken cancellationToken) =>
            GetAppConnectorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single AppConnector.
        /// </summary>
        /// <param name="name">
        /// Required. BeyondCorp AppConnector name using the form:
        /// `projects/{project_id}/locations/{location_id}/appConnectors/{app_connector_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AppConnector GetAppConnector(AppConnectorName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAppConnector(new GetAppConnectorRequest
            {
                AppConnectorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single AppConnector.
        /// </summary>
        /// <param name="name">
        /// Required. BeyondCorp AppConnector name using the form:
        /// `projects/{project_id}/locations/{location_id}/appConnectors/{app_connector_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppConnector> GetAppConnectorAsync(AppConnectorName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAppConnectorAsync(new GetAppConnectorRequest
            {
                AppConnectorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single AppConnector.
        /// </summary>
        /// <param name="name">
        /// Required. BeyondCorp AppConnector name using the form:
        /// `projects/{project_id}/locations/{location_id}/appConnectors/{app_connector_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppConnector> GetAppConnectorAsync(AppConnectorName name, st::CancellationToken cancellationToken) =>
            GetAppConnectorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new AppConnector in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AppConnector, AppConnectorOperationMetadata> CreateAppConnector(CreateAppConnectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new AppConnector in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AppConnector, AppConnectorOperationMetadata>> CreateAppConnectorAsync(CreateAppConnectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new AppConnector in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AppConnector, AppConnectorOperationMetadata>> CreateAppConnectorAsync(CreateAppConnectorRequest request, st::CancellationToken cancellationToken) =>
            CreateAppConnectorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateAppConnector</c>.</summary>
        public virtual lro::OperationsClient CreateAppConnectorOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateAppConnector</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AppConnector, AppConnectorOperationMetadata> PollOnceCreateAppConnector(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AppConnector, AppConnectorOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAppConnectorOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateAppConnector</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AppConnector, AppConnectorOperationMetadata>> PollOnceCreateAppConnectorAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AppConnector, AppConnectorOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAppConnectorOperationsClient, callSettings);

        /// <summary>
        /// Creates a new AppConnector in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource project name of the AppConnector location using the
        /// form: `projects/{project_id}/locations/{location_id}`
        /// </param>
        /// <param name="appConnector">
        /// Required. A BeyondCorp AppConnector resource.
        /// </param>
        /// <param name="appConnectorId">
        /// Optional. User-settable AppConnector resource ID.
        /// 
        /// * Must start with a letter.
        /// * Must contain between 4-63 characters from `/[a-z][0-9]-/`.
        /// * Must end with a number or a letter.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AppConnector, AppConnectorOperationMetadata> CreateAppConnector(string parent, AppConnector appConnector, string appConnectorId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAppConnector(new CreateAppConnectorRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AppConnectorId = appConnectorId ?? "",
                AppConnector = gax::GaxPreconditions.CheckNotNull(appConnector, nameof(appConnector)),
            }, callSettings);

        /// <summary>
        /// Creates a new AppConnector in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource project name of the AppConnector location using the
        /// form: `projects/{project_id}/locations/{location_id}`
        /// </param>
        /// <param name="appConnector">
        /// Required. A BeyondCorp AppConnector resource.
        /// </param>
        /// <param name="appConnectorId">
        /// Optional. User-settable AppConnector resource ID.
        /// 
        /// * Must start with a letter.
        /// * Must contain between 4-63 characters from `/[a-z][0-9]-/`.
        /// * Must end with a number or a letter.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AppConnector, AppConnectorOperationMetadata>> CreateAppConnectorAsync(string parent, AppConnector appConnector, string appConnectorId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAppConnectorAsync(new CreateAppConnectorRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AppConnectorId = appConnectorId ?? "",
                AppConnector = gax::GaxPreconditions.CheckNotNull(appConnector, nameof(appConnector)),
            }, callSettings);

        /// <summary>
        /// Creates a new AppConnector in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource project name of the AppConnector location using the
        /// form: `projects/{project_id}/locations/{location_id}`
        /// </param>
        /// <param name="appConnector">
        /// Required. A BeyondCorp AppConnector resource.
        /// </param>
        /// <param name="appConnectorId">
        /// Optional. User-settable AppConnector resource ID.
        /// 
        /// * Must start with a letter.
        /// * Must contain between 4-63 characters from `/[a-z][0-9]-/`.
        /// * Must end with a number or a letter.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AppConnector, AppConnectorOperationMetadata>> CreateAppConnectorAsync(string parent, AppConnector appConnector, string appConnectorId, st::CancellationToken cancellationToken) =>
            CreateAppConnectorAsync(parent, appConnector, appConnectorId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new AppConnector in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource project name of the AppConnector location using the
        /// form: `projects/{project_id}/locations/{location_id}`
        /// </param>
        /// <param name="appConnector">
        /// Required. A BeyondCorp AppConnector resource.
        /// </param>
        /// <param name="appConnectorId">
        /// Optional. User-settable AppConnector resource ID.
        /// 
        /// * Must start with a letter.
        /// * Must contain between 4-63 characters from `/[a-z][0-9]-/`.
        /// * Must end with a number or a letter.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AppConnector, AppConnectorOperationMetadata> CreateAppConnector(gagr::LocationName parent, AppConnector appConnector, string appConnectorId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAppConnector(new CreateAppConnectorRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AppConnectorId = appConnectorId ?? "",
                AppConnector = gax::GaxPreconditions.CheckNotNull(appConnector, nameof(appConnector)),
            }, callSettings);

        /// <summary>
        /// Creates a new AppConnector in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource project name of the AppConnector location using the
        /// form: `projects/{project_id}/locations/{location_id}`
        /// </param>
        /// <param name="appConnector">
        /// Required. A BeyondCorp AppConnector resource.
        /// </param>
        /// <param name="appConnectorId">
        /// Optional. User-settable AppConnector resource ID.
        /// 
        /// * Must start with a letter.
        /// * Must contain between 4-63 characters from `/[a-z][0-9]-/`.
        /// * Must end with a number or a letter.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AppConnector, AppConnectorOperationMetadata>> CreateAppConnectorAsync(gagr::LocationName parent, AppConnector appConnector, string appConnectorId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAppConnectorAsync(new CreateAppConnectorRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AppConnectorId = appConnectorId ?? "",
                AppConnector = gax::GaxPreconditions.CheckNotNull(appConnector, nameof(appConnector)),
            }, callSettings);

        /// <summary>
        /// Creates a new AppConnector in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource project name of the AppConnector location using the
        /// form: `projects/{project_id}/locations/{location_id}`
        /// </param>
        /// <param name="appConnector">
        /// Required. A BeyondCorp AppConnector resource.
        /// </param>
        /// <param name="appConnectorId">
        /// Optional. User-settable AppConnector resource ID.
        /// 
        /// * Must start with a letter.
        /// * Must contain between 4-63 characters from `/[a-z][0-9]-/`.
        /// * Must end with a number or a letter.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AppConnector, AppConnectorOperationMetadata>> CreateAppConnectorAsync(gagr::LocationName parent, AppConnector appConnector, string appConnectorId, st::CancellationToken cancellationToken) =>
            CreateAppConnectorAsync(parent, appConnector, appConnectorId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single AppConnector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AppConnector, AppConnectorOperationMetadata> UpdateAppConnector(UpdateAppConnectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single AppConnector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AppConnector, AppConnectorOperationMetadata>> UpdateAppConnectorAsync(UpdateAppConnectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single AppConnector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AppConnector, AppConnectorOperationMetadata>> UpdateAppConnectorAsync(UpdateAppConnectorRequest request, st::CancellationToken cancellationToken) =>
            UpdateAppConnectorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateAppConnector</c>.</summary>
        public virtual lro::OperationsClient UpdateAppConnectorOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateAppConnector</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AppConnector, AppConnectorOperationMetadata> PollOnceUpdateAppConnector(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AppConnector, AppConnectorOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAppConnectorOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateAppConnector</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AppConnector, AppConnectorOperationMetadata>> PollOnceUpdateAppConnectorAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AppConnector, AppConnectorOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAppConnectorOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single AppConnector.
        /// </summary>
        /// <param name="appConnector">
        /// Required. AppConnector message with updated fields. Only supported fields
        /// specified in update_mask are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field. The elements of the repeated paths field may only include these
        /// fields from [BeyondCorp.AppConnector]:
        /// * `labels`
        /// * `display_name`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AppConnector, AppConnectorOperationMetadata> UpdateAppConnector(AppConnector appConnector, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAppConnector(new UpdateAppConnectorRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                AppConnector = gax::GaxPreconditions.CheckNotNull(appConnector, nameof(appConnector)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single AppConnector.
        /// </summary>
        /// <param name="appConnector">
        /// Required. AppConnector message with updated fields. Only supported fields
        /// specified in update_mask are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field. The elements of the repeated paths field may only include these
        /// fields from [BeyondCorp.AppConnector]:
        /// * `labels`
        /// * `display_name`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AppConnector, AppConnectorOperationMetadata>> UpdateAppConnectorAsync(AppConnector appConnector, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAppConnectorAsync(new UpdateAppConnectorRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                AppConnector = gax::GaxPreconditions.CheckNotNull(appConnector, nameof(appConnector)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single AppConnector.
        /// </summary>
        /// <param name="appConnector">
        /// Required. AppConnector message with updated fields. Only supported fields
        /// specified in update_mask are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field. The elements of the repeated paths field may only include these
        /// fields from [BeyondCorp.AppConnector]:
        /// * `labels`
        /// * `display_name`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AppConnector, AppConnectorOperationMetadata>> UpdateAppConnectorAsync(AppConnector appConnector, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAppConnectorAsync(appConnector, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single AppConnector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, AppConnectorOperationMetadata> DeleteAppConnector(DeleteAppConnectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single AppConnector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, AppConnectorOperationMetadata>> DeleteAppConnectorAsync(DeleteAppConnectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single AppConnector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, AppConnectorOperationMetadata>> DeleteAppConnectorAsync(DeleteAppConnectorRequest request, st::CancellationToken cancellationToken) =>
            DeleteAppConnectorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteAppConnector</c>.</summary>
        public virtual lro::OperationsClient DeleteAppConnectorOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteAppConnector</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, AppConnectorOperationMetadata> PollOnceDeleteAppConnector(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, AppConnectorOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAppConnectorOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteAppConnector</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, AppConnectorOperationMetadata>> PollOnceDeleteAppConnectorAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, AppConnectorOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAppConnectorOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single AppConnector.
        /// </summary>
        /// <param name="name">
        /// Required. BeyondCorp AppConnector name using the form:
        /// `projects/{project_id}/locations/{location_id}/appConnectors/{app_connector_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, AppConnectorOperationMetadata> DeleteAppConnector(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAppConnector(new DeleteAppConnectorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single AppConnector.
        /// </summary>
        /// <param name="name">
        /// Required. BeyondCorp AppConnector name using the form:
        /// `projects/{project_id}/locations/{location_id}/appConnectors/{app_connector_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, AppConnectorOperationMetadata>> DeleteAppConnectorAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAppConnectorAsync(new DeleteAppConnectorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single AppConnector.
        /// </summary>
        /// <param name="name">
        /// Required. BeyondCorp AppConnector name using the form:
        /// `projects/{project_id}/locations/{location_id}/appConnectors/{app_connector_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, AppConnectorOperationMetadata>> DeleteAppConnectorAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAppConnectorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single AppConnector.
        /// </summary>
        /// <param name="name">
        /// Required. BeyondCorp AppConnector name using the form:
        /// `projects/{project_id}/locations/{location_id}/appConnectors/{app_connector_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, AppConnectorOperationMetadata> DeleteAppConnector(AppConnectorName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAppConnector(new DeleteAppConnectorRequest
            {
                AppConnectorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single AppConnector.
        /// </summary>
        /// <param name="name">
        /// Required. BeyondCorp AppConnector name using the form:
        /// `projects/{project_id}/locations/{location_id}/appConnectors/{app_connector_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, AppConnectorOperationMetadata>> DeleteAppConnectorAsync(AppConnectorName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAppConnectorAsync(new DeleteAppConnectorRequest
            {
                AppConnectorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single AppConnector.
        /// </summary>
        /// <param name="name">
        /// Required. BeyondCorp AppConnector name using the form:
        /// `projects/{project_id}/locations/{location_id}/appConnectors/{app_connector_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, AppConnectorOperationMetadata>> DeleteAppConnectorAsync(AppConnectorName name, st::CancellationToken cancellationToken) =>
            DeleteAppConnectorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Report status for a given connector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AppConnector, AppConnectorOperationMetadata> ReportStatus(ReportStatusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Report status for a given connector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AppConnector, AppConnectorOperationMetadata>> ReportStatusAsync(ReportStatusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Report status for a given connector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AppConnector, AppConnectorOperationMetadata>> ReportStatusAsync(ReportStatusRequest request, st::CancellationToken cancellationToken) =>
            ReportStatusAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ReportStatus</c>.</summary>
        public virtual lro::OperationsClient ReportStatusOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ReportStatus</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AppConnector, AppConnectorOperationMetadata> PollOnceReportStatus(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AppConnector, AppConnectorOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ReportStatusOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ReportStatus</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AppConnector, AppConnectorOperationMetadata>> PollOnceReportStatusAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AppConnector, AppConnectorOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ReportStatusOperationsClient, callSettings);

        /// <summary>
        /// Report status for a given connector.
        /// </summary>
        /// <param name="appConnector">
        /// Required. BeyondCorp Connector name using the form:
        /// `projects/{project_id}/locations/{location_id}/connectors/{connector}`
        /// </param>
        /// <param name="resourceInfo">
        /// Required. Resource info of the connector.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AppConnector, AppConnectorOperationMetadata> ReportStatus(string appConnector, ResourceInfo resourceInfo, gaxgrpc::CallSettings callSettings = null) =>
            ReportStatus(new ReportStatusRequest
            {
                AppConnector = gax::GaxPreconditions.CheckNotNullOrEmpty(appConnector, nameof(appConnector)),
                ResourceInfo = gax::GaxPreconditions.CheckNotNull(resourceInfo, nameof(resourceInfo)),
            }, callSettings);

        /// <summary>
        /// Report status for a given connector.
        /// </summary>
        /// <param name="appConnector">
        /// Required. BeyondCorp Connector name using the form:
        /// `projects/{project_id}/locations/{location_id}/connectors/{connector}`
        /// </param>
        /// <param name="resourceInfo">
        /// Required. Resource info of the connector.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AppConnector, AppConnectorOperationMetadata>> ReportStatusAsync(string appConnector, ResourceInfo resourceInfo, gaxgrpc::CallSettings callSettings = null) =>
            ReportStatusAsync(new ReportStatusRequest
            {
                AppConnector = gax::GaxPreconditions.CheckNotNullOrEmpty(appConnector, nameof(appConnector)),
                ResourceInfo = gax::GaxPreconditions.CheckNotNull(resourceInfo, nameof(resourceInfo)),
            }, callSettings);

        /// <summary>
        /// Report status for a given connector.
        /// </summary>
        /// <param name="appConnector">
        /// Required. BeyondCorp Connector name using the form:
        /// `projects/{project_id}/locations/{location_id}/connectors/{connector}`
        /// </param>
        /// <param name="resourceInfo">
        /// Required. Resource info of the connector.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AppConnector, AppConnectorOperationMetadata>> ReportStatusAsync(string appConnector, ResourceInfo resourceInfo, st::CancellationToken cancellationToken) =>
            ReportStatusAsync(appConnector, resourceInfo, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Report status for a given connector.
        /// </summary>
        /// <param name="appConnector">
        /// Required. BeyondCorp Connector name using the form:
        /// `projects/{project_id}/locations/{location_id}/connectors/{connector}`
        /// </param>
        /// <param name="resourceInfo">
        /// Required. Resource info of the connector.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AppConnector, AppConnectorOperationMetadata> ReportStatus(AppConnectorName appConnector, ResourceInfo resourceInfo, gaxgrpc::CallSettings callSettings = null) =>
            ReportStatus(new ReportStatusRequest
            {
                AppConnectorAsAppConnectorName = gax::GaxPreconditions.CheckNotNull(appConnector, nameof(appConnector)),
                ResourceInfo = gax::GaxPreconditions.CheckNotNull(resourceInfo, nameof(resourceInfo)),
            }, callSettings);

        /// <summary>
        /// Report status for a given connector.
        /// </summary>
        /// <param name="appConnector">
        /// Required. BeyondCorp Connector name using the form:
        /// `projects/{project_id}/locations/{location_id}/connectors/{connector}`
        /// </param>
        /// <param name="resourceInfo">
        /// Required. Resource info of the connector.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AppConnector, AppConnectorOperationMetadata>> ReportStatusAsync(AppConnectorName appConnector, ResourceInfo resourceInfo, gaxgrpc::CallSettings callSettings = null) =>
            ReportStatusAsync(new ReportStatusRequest
            {
                AppConnectorAsAppConnectorName = gax::GaxPreconditions.CheckNotNull(appConnector, nameof(appConnector)),
                ResourceInfo = gax::GaxPreconditions.CheckNotNull(resourceInfo, nameof(resourceInfo)),
            }, callSettings);

        /// <summary>
        /// Report status for a given connector.
        /// </summary>
        /// <param name="appConnector">
        /// Required. BeyondCorp Connector name using the form:
        /// `projects/{project_id}/locations/{location_id}/connectors/{connector}`
        /// </param>
        /// <param name="resourceInfo">
        /// Required. Resource info of the connector.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AppConnector, AppConnectorOperationMetadata>> ReportStatusAsync(AppConnectorName appConnector, ResourceInfo resourceInfo, st::CancellationToken cancellationToken) =>
            ReportStatusAsync(appConnector, resourceInfo, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AppConnectorsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// API Overview:
    /// 
    /// The `beyondcorp.googleapis.com` service implements the Google Cloud
    /// BeyondCorp API.
    /// 
    /// Data Model:
    /// 
    /// The AppConnectorsService exposes the following resource:
    /// 
    /// * AppConnectors, named as follows:
    /// `projects/{project_id}/locations/{location_id}/appConnectors/{app_connector_id}`.
    /// 
    /// The AppConnectorsService provides methods to manage
    /// (create/read/update/delete) BeyondCorp AppConnectors.
    /// </remarks>
    public sealed partial class AppConnectorsServiceClientImpl : AppConnectorsServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListAppConnectorsRequest, ListAppConnectorsResponse> _callListAppConnectors;

        private readonly gaxgrpc::ApiCall<GetAppConnectorRequest, AppConnector> _callGetAppConnector;

        private readonly gaxgrpc::ApiCall<CreateAppConnectorRequest, lro::Operation> _callCreateAppConnector;

        private readonly gaxgrpc::ApiCall<UpdateAppConnectorRequest, lro::Operation> _callUpdateAppConnector;

        private readonly gaxgrpc::ApiCall<DeleteAppConnectorRequest, lro::Operation> _callDeleteAppConnector;

        private readonly gaxgrpc::ApiCall<ReportStatusRequest, lro::Operation> _callReportStatus;

        /// <summary>
        /// Constructs a client wrapper for the AppConnectorsService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AppConnectorsServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AppConnectorsServiceClientImpl(AppConnectorsService.AppConnectorsServiceClient grpcClient, AppConnectorsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AppConnectorsServiceSettings effectiveSettings = settings ?? AppConnectorsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateAppConnectorOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateAppConnectorOperationsSettings, logger);
            UpdateAppConnectorOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateAppConnectorOperationsSettings, logger);
            DeleteAppConnectorOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteAppConnectorOperationsSettings, logger);
            ReportStatusOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ReportStatusOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListAppConnectors = clientHelper.BuildApiCall<ListAppConnectorsRequest, ListAppConnectorsResponse>("ListAppConnectors", grpcClient.ListAppConnectorsAsync, grpcClient.ListAppConnectors, effectiveSettings.ListAppConnectorsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAppConnectors);
            Modify_ListAppConnectorsApiCall(ref _callListAppConnectors);
            _callGetAppConnector = clientHelper.BuildApiCall<GetAppConnectorRequest, AppConnector>("GetAppConnector", grpcClient.GetAppConnectorAsync, grpcClient.GetAppConnector, effectiveSettings.GetAppConnectorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAppConnector);
            Modify_GetAppConnectorApiCall(ref _callGetAppConnector);
            _callCreateAppConnector = clientHelper.BuildApiCall<CreateAppConnectorRequest, lro::Operation>("CreateAppConnector", grpcClient.CreateAppConnectorAsync, grpcClient.CreateAppConnector, effectiveSettings.CreateAppConnectorSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAppConnector);
            Modify_CreateAppConnectorApiCall(ref _callCreateAppConnector);
            _callUpdateAppConnector = clientHelper.BuildApiCall<UpdateAppConnectorRequest, lro::Operation>("UpdateAppConnector", grpcClient.UpdateAppConnectorAsync, grpcClient.UpdateAppConnector, effectiveSettings.UpdateAppConnectorSettings).WithGoogleRequestParam("app_connector.name", request => request.AppConnector?.Name);
            Modify_ApiCall(ref _callUpdateAppConnector);
            Modify_UpdateAppConnectorApiCall(ref _callUpdateAppConnector);
            _callDeleteAppConnector = clientHelper.BuildApiCall<DeleteAppConnectorRequest, lro::Operation>("DeleteAppConnector", grpcClient.DeleteAppConnectorAsync, grpcClient.DeleteAppConnector, effectiveSettings.DeleteAppConnectorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAppConnector);
            Modify_DeleteAppConnectorApiCall(ref _callDeleteAppConnector);
            _callReportStatus = clientHelper.BuildApiCall<ReportStatusRequest, lro::Operation>("ReportStatus", grpcClient.ReportStatusAsync, grpcClient.ReportStatus, effectiveSettings.ReportStatusSettings).WithGoogleRequestParam("app_connector", request => request.AppConnector);
            Modify_ApiCall(ref _callReportStatus);
            Modify_ReportStatusApiCall(ref _callReportStatus);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListAppConnectorsApiCall(ref gaxgrpc::ApiCall<ListAppConnectorsRequest, ListAppConnectorsResponse> call);

        partial void Modify_GetAppConnectorApiCall(ref gaxgrpc::ApiCall<GetAppConnectorRequest, AppConnector> call);

        partial void Modify_CreateAppConnectorApiCall(ref gaxgrpc::ApiCall<CreateAppConnectorRequest, lro::Operation> call);

        partial void Modify_UpdateAppConnectorApiCall(ref gaxgrpc::ApiCall<UpdateAppConnectorRequest, lro::Operation> call);

        partial void Modify_DeleteAppConnectorApiCall(ref gaxgrpc::ApiCall<DeleteAppConnectorRequest, lro::Operation> call);

        partial void Modify_ReportStatusApiCall(ref gaxgrpc::ApiCall<ReportStatusRequest, lro::Operation> call);

        partial void OnConstruction(AppConnectorsService.AppConnectorsServiceClient grpcClient, AppConnectorsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AppConnectorsService client</summary>
        public override AppConnectorsService.AppConnectorsServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListAppConnectorsRequest(ref ListAppConnectorsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAppConnectorRequest(ref GetAppConnectorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAppConnectorRequest(ref CreateAppConnectorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAppConnectorRequest(ref UpdateAppConnectorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAppConnectorRequest(ref DeleteAppConnectorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReportStatusRequest(ref ReportStatusRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists AppConnectors in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AppConnector"/> resources.</returns>
        public override gax::PagedEnumerable<ListAppConnectorsResponse, AppConnector> ListAppConnectors(ListAppConnectorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAppConnectorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAppConnectorsRequest, ListAppConnectorsResponse, AppConnector>(_callListAppConnectors, request, callSettings);
        }

        /// <summary>
        /// Lists AppConnectors in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AppConnector"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAppConnectorsResponse, AppConnector> ListAppConnectorsAsync(ListAppConnectorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAppConnectorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAppConnectorsRequest, ListAppConnectorsResponse, AppConnector>(_callListAppConnectors, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single AppConnector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AppConnector GetAppConnector(GetAppConnectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAppConnectorRequest(ref request, ref callSettings);
            return _callGetAppConnector.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single AppConnector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AppConnector> GetAppConnectorAsync(GetAppConnectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAppConnectorRequest(ref request, ref callSettings);
            return _callGetAppConnector.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateAppConnector</c>.</summary>
        public override lro::OperationsClient CreateAppConnectorOperationsClient { get; }

        /// <summary>
        /// Creates a new AppConnector in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AppConnector, AppConnectorOperationMetadata> CreateAppConnector(CreateAppConnectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAppConnectorRequest(ref request, ref callSettings);
            return new lro::Operation<AppConnector, AppConnectorOperationMetadata>(_callCreateAppConnector.Sync(request, callSettings), CreateAppConnectorOperationsClient);
        }

        /// <summary>
        /// Creates a new AppConnector in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AppConnector, AppConnectorOperationMetadata>> CreateAppConnectorAsync(CreateAppConnectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAppConnectorRequest(ref request, ref callSettings);
            return new lro::Operation<AppConnector, AppConnectorOperationMetadata>(await _callCreateAppConnector.Async(request, callSettings).ConfigureAwait(false), CreateAppConnectorOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateAppConnector</c>.</summary>
        public override lro::OperationsClient UpdateAppConnectorOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single AppConnector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AppConnector, AppConnectorOperationMetadata> UpdateAppConnector(UpdateAppConnectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAppConnectorRequest(ref request, ref callSettings);
            return new lro::Operation<AppConnector, AppConnectorOperationMetadata>(_callUpdateAppConnector.Sync(request, callSettings), UpdateAppConnectorOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single AppConnector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AppConnector, AppConnectorOperationMetadata>> UpdateAppConnectorAsync(UpdateAppConnectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAppConnectorRequest(ref request, ref callSettings);
            return new lro::Operation<AppConnector, AppConnectorOperationMetadata>(await _callUpdateAppConnector.Async(request, callSettings).ConfigureAwait(false), UpdateAppConnectorOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteAppConnector</c>.</summary>
        public override lro::OperationsClient DeleteAppConnectorOperationsClient { get; }

        /// <summary>
        /// Deletes a single AppConnector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, AppConnectorOperationMetadata> DeleteAppConnector(DeleteAppConnectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAppConnectorRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, AppConnectorOperationMetadata>(_callDeleteAppConnector.Sync(request, callSettings), DeleteAppConnectorOperationsClient);
        }

        /// <summary>
        /// Deletes a single AppConnector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, AppConnectorOperationMetadata>> DeleteAppConnectorAsync(DeleteAppConnectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAppConnectorRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, AppConnectorOperationMetadata>(await _callDeleteAppConnector.Async(request, callSettings).ConfigureAwait(false), DeleteAppConnectorOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ReportStatus</c>.</summary>
        public override lro::OperationsClient ReportStatusOperationsClient { get; }

        /// <summary>
        /// Report status for a given connector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AppConnector, AppConnectorOperationMetadata> ReportStatus(ReportStatusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReportStatusRequest(ref request, ref callSettings);
            return new lro::Operation<AppConnector, AppConnectorOperationMetadata>(_callReportStatus.Sync(request, callSettings), ReportStatusOperationsClient);
        }

        /// <summary>
        /// Report status for a given connector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AppConnector, AppConnectorOperationMetadata>> ReportStatusAsync(ReportStatusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReportStatusRequest(ref request, ref callSettings);
            return new lro::Operation<AppConnector, AppConnectorOperationMetadata>(await _callReportStatus.Async(request, callSettings).ConfigureAwait(false), ReportStatusOperationsClient);
        }
    }

    public partial class ListAppConnectorsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAppConnectorsResponse : gaxgrpc::IPageResponse<AppConnector>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AppConnector> GetEnumerator() => AppConnectors.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class AppConnectorsService
    {
        public partial class AppConnectorsServiceClient
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

    public static partial class AppConnectorsService
    {
        public partial class AppConnectorsServiceClient
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
