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
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.Maintenance.Api.V1Beta
{
    /// <summary>Settings for <see cref="MaintenanceClient"/> instances.</summary>
    public sealed partial class MaintenanceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="MaintenanceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="MaintenanceSettings"/>.</returns>
        public static MaintenanceSettings GetDefault() => new MaintenanceSettings();

        /// <summary>Constructs a new <see cref="MaintenanceSettings"/> object with default settings.</summary>
        public MaintenanceSettings()
        {
        }

        private MaintenanceSettings(MaintenanceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            SummarizeMaintenancesSettings = existing.SummarizeMaintenancesSettings;
            ListResourceMaintenancesSettings = existing.ListResourceMaintenancesSettings;
            GetResourceMaintenanceSettings = existing.GetResourceMaintenanceSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(MaintenanceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MaintenanceClient.SummarizeMaintenances</c> and <c>MaintenanceClient.SummarizeMaintenancesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SummarizeMaintenancesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MaintenanceClient.ListResourceMaintenances</c> and <c>MaintenanceClient.ListResourceMaintenancesAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListResourceMaintenancesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MaintenanceClient.GetResourceMaintenance</c> and <c>MaintenanceClient.GetResourceMaintenanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetResourceMaintenanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="MaintenanceSettings"/> object.</returns>
        public MaintenanceSettings Clone() => new MaintenanceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="MaintenanceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class MaintenanceClientBuilder : gaxgrpc::ClientBuilderBase<MaintenanceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public MaintenanceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public MaintenanceClientBuilder() : base(MaintenanceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref MaintenanceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<MaintenanceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override MaintenanceClient Build()
        {
            MaintenanceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<MaintenanceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<MaintenanceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private MaintenanceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return MaintenanceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<MaintenanceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return MaintenanceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => MaintenanceClient.ChannelPool;
    }

    /// <summary>Maintenance client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Unified Maintenance service
    /// </remarks>
    public abstract partial class MaintenanceClient
    {
        /// <summary>
        /// The default endpoint for the Maintenance service, which is a host of "maintenance.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "maintenance.googleapis.com:443";

        /// <summary>The default Maintenance scopes.</summary>
        /// <remarks>
        /// The default Maintenance scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Maintenance.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="MaintenanceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="MaintenanceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="MaintenanceClient"/>.</returns>
        public static stt::Task<MaintenanceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new MaintenanceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="MaintenanceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="MaintenanceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="MaintenanceClient"/>.</returns>
        public static MaintenanceClient Create() => new MaintenanceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="MaintenanceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="MaintenanceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="MaintenanceClient"/>.</returns>
        internal static MaintenanceClient Create(grpccore::CallInvoker callInvoker, MaintenanceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Maintenance.MaintenanceClient grpcClient = new Maintenance.MaintenanceClient(callInvoker);
            return new MaintenanceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Maintenance client</summary>
        public virtual Maintenance.MaintenanceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the statistics of a specific maintenance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MaintenanceSummary"/> resources.</returns>
        public virtual gax::PagedEnumerable<SummarizeMaintenancesResponse, MaintenanceSummary> SummarizeMaintenances(SummarizeMaintenancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the statistics of a specific maintenance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MaintenanceSummary"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SummarizeMaintenancesResponse, MaintenanceSummary> SummarizeMaintenancesAsync(SummarizeMaintenancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the statistics of a specific maintenance.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the resource maintenance.
        /// eg. `projects/123/locations/*`
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
        /// <returns>A pageable sequence of <see cref="MaintenanceSummary"/> resources.</returns>
        public virtual gax::PagedEnumerable<SummarizeMaintenancesResponse, MaintenanceSummary> SummarizeMaintenances(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SummarizeMaintenancesRequest request = new SummarizeMaintenancesRequest
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
            return SummarizeMaintenances(request, callSettings);
        }

        /// <summary>
        /// Retrieves the statistics of a specific maintenance.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the resource maintenance.
        /// eg. `projects/123/locations/*`
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
        /// <returns>A pageable asynchronous sequence of <see cref="MaintenanceSummary"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SummarizeMaintenancesResponse, MaintenanceSummary> SummarizeMaintenancesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SummarizeMaintenancesRequest request = new SummarizeMaintenancesRequest
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
            return SummarizeMaintenancesAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the statistics of a specific maintenance.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the resource maintenance.
        /// eg. `projects/123/locations/*`
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
        /// <returns>A pageable sequence of <see cref="MaintenanceSummary"/> resources.</returns>
        public virtual gax::PagedEnumerable<SummarizeMaintenancesResponse, MaintenanceSummary> SummarizeMaintenances(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SummarizeMaintenancesRequest request = new SummarizeMaintenancesRequest
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
            return SummarizeMaintenances(request, callSettings);
        }

        /// <summary>
        /// Retrieves the statistics of a specific maintenance.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the resource maintenance.
        /// eg. `projects/123/locations/*`
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
        /// <returns>A pageable asynchronous sequence of <see cref="MaintenanceSummary"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SummarizeMaintenancesResponse, MaintenanceSummary> SummarizeMaintenancesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SummarizeMaintenancesRequest request = new SummarizeMaintenancesRequest
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
            return SummarizeMaintenancesAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieve a collection of resource maintenances.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ResourceMaintenance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListResourceMaintenancesResponse, ResourceMaintenance> ListResourceMaintenances(ListResourceMaintenancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a collection of resource maintenances.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ResourceMaintenance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListResourceMaintenancesResponse, ResourceMaintenance> ListResourceMaintenancesAsync(ListResourceMaintenancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a collection of resource maintenances.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the resource maintenance.
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
        /// <returns>A pageable sequence of <see cref="ResourceMaintenance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListResourceMaintenancesResponse, ResourceMaintenance> ListResourceMaintenances(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListResourceMaintenancesRequest request = new ListResourceMaintenancesRequest
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
            return ListResourceMaintenances(request, callSettings);
        }

        /// <summary>
        /// Retrieve a collection of resource maintenances.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the resource maintenance.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ResourceMaintenance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListResourceMaintenancesResponse, ResourceMaintenance> ListResourceMaintenancesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListResourceMaintenancesRequest request = new ListResourceMaintenancesRequest
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
            return ListResourceMaintenancesAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieve a collection of resource maintenances.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the resource maintenance.
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
        /// <returns>A pageable sequence of <see cref="ResourceMaintenance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListResourceMaintenancesResponse, ResourceMaintenance> ListResourceMaintenances(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListResourceMaintenancesRequest request = new ListResourceMaintenancesRequest
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
            return ListResourceMaintenances(request, callSettings);
        }

        /// <summary>
        /// Retrieve a collection of resource maintenances.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the resource maintenance.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ResourceMaintenance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListResourceMaintenancesResponse, ResourceMaintenance> ListResourceMaintenancesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListResourceMaintenancesRequest request = new ListResourceMaintenancesRequest
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
            return ListResourceMaintenancesAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieve a single resource maintenance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ResourceMaintenance GetResourceMaintenance(GetResourceMaintenanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a single resource maintenance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResourceMaintenance> GetResourceMaintenanceAsync(GetResourceMaintenanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a single resource maintenance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResourceMaintenance> GetResourceMaintenanceAsync(GetResourceMaintenanceRequest request, st::CancellationToken cancellationToken) =>
            GetResourceMaintenanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve a single resource maintenance.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ResourceMaintenance GetResourceMaintenance(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetResourceMaintenance(new GetResourceMaintenanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a single resource maintenance.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResourceMaintenance> GetResourceMaintenanceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetResourceMaintenanceAsync(new GetResourceMaintenanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a single resource maintenance.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResourceMaintenance> GetResourceMaintenanceAsync(string name, st::CancellationToken cancellationToken) =>
            GetResourceMaintenanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve a single resource maintenance.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ResourceMaintenance GetResourceMaintenance(ResourceMaintenanceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetResourceMaintenance(new GetResourceMaintenanceRequest
            {
                ResourceMaintenanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a single resource maintenance.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResourceMaintenance> GetResourceMaintenanceAsync(ResourceMaintenanceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetResourceMaintenanceAsync(new GetResourceMaintenanceRequest
            {
                ResourceMaintenanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a single resource maintenance.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the resource within a service.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResourceMaintenance> GetResourceMaintenanceAsync(ResourceMaintenanceName name, st::CancellationToken cancellationToken) =>
            GetResourceMaintenanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Maintenance client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Unified Maintenance service
    /// </remarks>
    public sealed partial class MaintenanceClientImpl : MaintenanceClient
    {
        private readonly gaxgrpc::ApiCall<SummarizeMaintenancesRequest, SummarizeMaintenancesResponse> _callSummarizeMaintenances;

        private readonly gaxgrpc::ApiCall<ListResourceMaintenancesRequest, ListResourceMaintenancesResponse> _callListResourceMaintenances;

        private readonly gaxgrpc::ApiCall<GetResourceMaintenanceRequest, ResourceMaintenance> _callGetResourceMaintenance;

        /// <summary>
        /// Constructs a client wrapper for the Maintenance service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="MaintenanceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public MaintenanceClientImpl(Maintenance.MaintenanceClient grpcClient, MaintenanceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            MaintenanceSettings effectiveSettings = settings ?? MaintenanceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callSummarizeMaintenances = clientHelper.BuildApiCall<SummarizeMaintenancesRequest, SummarizeMaintenancesResponse>("SummarizeMaintenances", grpcClient.SummarizeMaintenancesAsync, grpcClient.SummarizeMaintenances, effectiveSettings.SummarizeMaintenancesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callSummarizeMaintenances);
            Modify_SummarizeMaintenancesApiCall(ref _callSummarizeMaintenances);
            _callListResourceMaintenances = clientHelper.BuildApiCall<ListResourceMaintenancesRequest, ListResourceMaintenancesResponse>("ListResourceMaintenances", grpcClient.ListResourceMaintenancesAsync, grpcClient.ListResourceMaintenances, effectiveSettings.ListResourceMaintenancesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListResourceMaintenances);
            Modify_ListResourceMaintenancesApiCall(ref _callListResourceMaintenances);
            _callGetResourceMaintenance = clientHelper.BuildApiCall<GetResourceMaintenanceRequest, ResourceMaintenance>("GetResourceMaintenance", grpcClient.GetResourceMaintenanceAsync, grpcClient.GetResourceMaintenance, effectiveSettings.GetResourceMaintenanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetResourceMaintenance);
            Modify_GetResourceMaintenanceApiCall(ref _callGetResourceMaintenance);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_SummarizeMaintenancesApiCall(ref gaxgrpc::ApiCall<SummarizeMaintenancesRequest, SummarizeMaintenancesResponse> call);

        partial void Modify_ListResourceMaintenancesApiCall(ref gaxgrpc::ApiCall<ListResourceMaintenancesRequest, ListResourceMaintenancesResponse> call);

        partial void Modify_GetResourceMaintenanceApiCall(ref gaxgrpc::ApiCall<GetResourceMaintenanceRequest, ResourceMaintenance> call);

        partial void OnConstruction(Maintenance.MaintenanceClient grpcClient, MaintenanceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Maintenance client</summary>
        public override Maintenance.MaintenanceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_SummarizeMaintenancesRequest(ref SummarizeMaintenancesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListResourceMaintenancesRequest(ref ListResourceMaintenancesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetResourceMaintenanceRequest(ref GetResourceMaintenanceRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves the statistics of a specific maintenance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MaintenanceSummary"/> resources.</returns>
        public override gax::PagedEnumerable<SummarizeMaintenancesResponse, MaintenanceSummary> SummarizeMaintenances(SummarizeMaintenancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SummarizeMaintenancesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SummarizeMaintenancesRequest, SummarizeMaintenancesResponse, MaintenanceSummary>(_callSummarizeMaintenances, request, callSettings);
        }

        /// <summary>
        /// Retrieves the statistics of a specific maintenance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MaintenanceSummary"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SummarizeMaintenancesResponse, MaintenanceSummary> SummarizeMaintenancesAsync(SummarizeMaintenancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SummarizeMaintenancesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SummarizeMaintenancesRequest, SummarizeMaintenancesResponse, MaintenanceSummary>(_callSummarizeMaintenances, request, callSettings);
        }

        /// <summary>
        /// Retrieve a collection of resource maintenances.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ResourceMaintenance"/> resources.</returns>
        public override gax::PagedEnumerable<ListResourceMaintenancesResponse, ResourceMaintenance> ListResourceMaintenances(ListResourceMaintenancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListResourceMaintenancesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListResourceMaintenancesRequest, ListResourceMaintenancesResponse, ResourceMaintenance>(_callListResourceMaintenances, request, callSettings);
        }

        /// <summary>
        /// Retrieve a collection of resource maintenances.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ResourceMaintenance"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListResourceMaintenancesResponse, ResourceMaintenance> ListResourceMaintenancesAsync(ListResourceMaintenancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListResourceMaintenancesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListResourceMaintenancesRequest, ListResourceMaintenancesResponse, ResourceMaintenance>(_callListResourceMaintenances, request, callSettings);
        }

        /// <summary>
        /// Retrieve a single resource maintenance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ResourceMaintenance GetResourceMaintenance(GetResourceMaintenanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetResourceMaintenanceRequest(ref request, ref callSettings);
            return _callGetResourceMaintenance.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieve a single resource maintenance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ResourceMaintenance> GetResourceMaintenanceAsync(GetResourceMaintenanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetResourceMaintenanceRequest(ref request, ref callSettings);
            return _callGetResourceMaintenance.Async(request, callSettings);
        }
    }

    public partial class SummarizeMaintenancesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListResourceMaintenancesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SummarizeMaintenancesResponse : gaxgrpc::IPageResponse<MaintenanceSummary>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<MaintenanceSummary> GetEnumerator() => Maintenances.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListResourceMaintenancesResponse : gaxgrpc::IPageResponse<ResourceMaintenance>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ResourceMaintenance> GetEnumerator() => ResourceMaintenances.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Maintenance
    {
        public partial class MaintenanceClient
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
