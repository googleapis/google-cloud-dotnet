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
    /// <summary>Settings for <see cref="SiteServiceClient"/> instances.</summary>
    public sealed partial class SiteServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SiteServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SiteServiceSettings"/>.</returns>
        public static SiteServiceSettings GetDefault() => new SiteServiceSettings();

        /// <summary>Constructs a new <see cref="SiteServiceSettings"/> object with default settings.</summary>
        public SiteServiceSettings()
        {
        }

        private SiteServiceSettings(SiteServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetSiteSettings = existing.GetSiteSettings;
            ListSitesSettings = existing.ListSitesSettings;
            CreateSiteSettings = existing.CreateSiteSettings;
            BatchCreateSitesSettings = existing.BatchCreateSitesSettings;
            UpdateSiteSettings = existing.UpdateSiteSettings;
            BatchUpdateSitesSettings = existing.BatchUpdateSitesSettings;
            BatchDeactivateSitesSettings = existing.BatchDeactivateSitesSettings;
            BatchSubmitSitesForApprovalSettings = existing.BatchSubmitSitesForApprovalSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SiteServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>SiteServiceClient.GetSite</c>
        ///  and <c>SiteServiceClient.GetSiteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSiteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>SiteServiceClient.ListSites</c>
        ///  and <c>SiteServiceClient.ListSitesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSitesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SiteServiceClient.CreateSite</c> and <c>SiteServiceClient.CreateSiteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSiteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SiteServiceClient.BatchCreateSites</c> and <c>SiteServiceClient.BatchCreateSitesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchCreateSitesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SiteServiceClient.UpdateSite</c> and <c>SiteServiceClient.UpdateSiteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSiteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SiteServiceClient.BatchUpdateSites</c> and <c>SiteServiceClient.BatchUpdateSitesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchUpdateSitesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SiteServiceClient.BatchDeactivateSites</c> and <c>SiteServiceClient.BatchDeactivateSitesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchDeactivateSitesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SiteServiceClient.BatchSubmitSitesForApproval</c> and
        /// <c>SiteServiceClient.BatchSubmitSitesForApprovalAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchSubmitSitesForApprovalSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SiteServiceSettings"/> object.</returns>
        public SiteServiceSettings Clone() => new SiteServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SiteServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class SiteServiceClientBuilder : gaxgrpc::ClientBuilderBase<SiteServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SiteServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SiteServiceClientBuilder() : base(SiteServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SiteServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SiteServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SiteServiceClient Build()
        {
            SiteServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SiteServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SiteServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SiteServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SiteServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SiteServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SiteServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SiteServiceClient.ChannelPool;
    }

    /// <summary>SiteService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `Site` objects.
    /// </remarks>
    public abstract partial class SiteServiceClient
    {
        /// <summary>
        /// The default endpoint for the SiteService service, which is a host of "admanager.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default SiteService scopes.</summary>
        /// <remarks>
        /// The default SiteService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/admanager</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admanager",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(SiteService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SiteServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SiteServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SiteServiceClient"/>.</returns>
        public static stt::Task<SiteServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SiteServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SiteServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SiteServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SiteServiceClient"/>.</returns>
        public static SiteServiceClient Create() => new SiteServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SiteServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SiteServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SiteServiceClient"/>.</returns>
        internal static SiteServiceClient Create(grpccore::CallInvoker callInvoker, SiteServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SiteService.SiteServiceClient grpcClient = new SiteService.SiteServiceClient(callInvoker);
            return new SiteServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC SiteService client</summary>
        public virtual SiteService.SiteServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `Site` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Site GetSite(GetSiteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `Site` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Site> GetSiteAsync(GetSiteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `Site` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Site> GetSiteAsync(GetSiteRequest request, st::CancellationToken cancellationToken) =>
            GetSiteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `Site` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Site.
        /// Format: `networks/{network_code}/sites/{site_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Site GetSite(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSite(new GetSiteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `Site` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Site.
        /// Format: `networks/{network_code}/sites/{site_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Site> GetSiteAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSiteAsync(new GetSiteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `Site` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Site.
        /// Format: `networks/{network_code}/sites/{site_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Site> GetSiteAsync(string name, st::CancellationToken cancellationToken) =>
            GetSiteAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `Site` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Site.
        /// Format: `networks/{network_code}/sites/{site_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Site GetSite(SiteName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSite(new GetSiteRequest
            {
                SiteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `Site` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Site.
        /// Format: `networks/{network_code}/sites/{site_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Site> GetSiteAsync(SiteName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSiteAsync(new GetSiteRequest
            {
                SiteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `Site` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Site.
        /// Format: `networks/{network_code}/sites/{site_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Site> GetSiteAsync(SiteName name, st::CancellationToken cancellationToken) =>
            GetSiteAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a list of `Site` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Site"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSitesResponse, Site> ListSites(ListSitesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `Site` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Site"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSitesResponse, Site> ListSitesAsync(ListSitesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `Site` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Sites.
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
        /// <returns>A pageable sequence of <see cref="Site"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSitesResponse, Site> ListSites(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSitesRequest request = new ListSitesRequest
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
            return ListSites(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Site` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Sites.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Site"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSitesResponse, Site> ListSitesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSitesRequest request = new ListSitesRequest
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
            return ListSitesAsync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Site` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Sites.
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
        /// <returns>A pageable sequence of <see cref="Site"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSitesResponse, Site> ListSites(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSitesRequest request = new ListSitesRequest
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
            return ListSites(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Site` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Sites.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Site"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSitesResponse, Site> ListSitesAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSitesRequest request = new ListSitesRequest
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
            return ListSitesAsync(request, callSettings);
        }

        /// <summary>
        /// API to create a `Site` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Site CreateSite(CreateSiteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to create a `Site` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Site> CreateSiteAsync(CreateSiteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to create a `Site` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Site> CreateSiteAsync(CreateSiteRequest request, st::CancellationToken cancellationToken) =>
            CreateSiteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to create a `Site` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `Site` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="site">
        /// Required. The `Site` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Site CreateSite(string parent, Site site, gaxgrpc::CallSettings callSettings = null) =>
            CreateSite(new CreateSiteRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Site = gax::GaxPreconditions.CheckNotNull(site, nameof(site)),
            }, callSettings);

        /// <summary>
        /// API to create a `Site` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `Site` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="site">
        /// Required. The `Site` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Site> CreateSiteAsync(string parent, Site site, gaxgrpc::CallSettings callSettings = null) =>
            CreateSiteAsync(new CreateSiteRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Site = gax::GaxPreconditions.CheckNotNull(site, nameof(site)),
            }, callSettings);

        /// <summary>
        /// API to create a `Site` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `Site` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="site">
        /// Required. The `Site` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Site> CreateSiteAsync(string parent, Site site, st::CancellationToken cancellationToken) =>
            CreateSiteAsync(parent, site, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to create a `Site` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `Site` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="site">
        /// Required. The `Site` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Site CreateSite(NetworkName parent, Site site, gaxgrpc::CallSettings callSettings = null) =>
            CreateSite(new CreateSiteRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Site = gax::GaxPreconditions.CheckNotNull(site, nameof(site)),
            }, callSettings);

        /// <summary>
        /// API to create a `Site` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `Site` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="site">
        /// Required. The `Site` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Site> CreateSiteAsync(NetworkName parent, Site site, gaxgrpc::CallSettings callSettings = null) =>
            CreateSiteAsync(new CreateSiteRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Site = gax::GaxPreconditions.CheckNotNull(site, nameof(site)),
            }, callSettings);

        /// <summary>
        /// API to create a `Site` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `Site` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="site">
        /// Required. The `Site` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Site> CreateSiteAsync(NetworkName parent, Site site, st::CancellationToken cancellationToken) =>
            CreateSiteAsync(parent, site, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch create `Site` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateSitesResponse BatchCreateSites(BatchCreateSitesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to batch create `Site` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateSitesResponse> BatchCreateSitesAsync(BatchCreateSitesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to batch create `Site` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateSitesResponse> BatchCreateSitesAsync(BatchCreateSitesRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateSitesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch create `Site` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Sites` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateSiteRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Site` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateSitesResponse BatchCreateSites(string parent, scg::IEnumerable<CreateSiteRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateSites(new BatchCreateSitesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch create `Site` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Sites` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateSiteRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Site` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateSitesResponse> BatchCreateSitesAsync(string parent, scg::IEnumerable<CreateSiteRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateSitesAsync(new BatchCreateSitesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch create `Site` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Sites` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateSiteRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Site` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateSitesResponse> BatchCreateSitesAsync(string parent, scg::IEnumerable<CreateSiteRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateSitesAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch create `Site` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Sites` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateSiteRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Site` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateSitesResponse BatchCreateSites(NetworkName parent, scg::IEnumerable<CreateSiteRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateSites(new BatchCreateSitesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch create `Site` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Sites` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateSiteRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Site` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateSitesResponse> BatchCreateSitesAsync(NetworkName parent, scg::IEnumerable<CreateSiteRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateSitesAsync(new BatchCreateSitesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch create `Site` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Sites` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateSiteRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Site` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateSitesResponse> BatchCreateSitesAsync(NetworkName parent, scg::IEnumerable<CreateSiteRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateSitesAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to update a `Site` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Site UpdateSite(UpdateSiteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to update a `Site` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Site> UpdateSiteAsync(UpdateSiteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to update a `Site` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Site> UpdateSiteAsync(UpdateSiteRequest request, st::CancellationToken cancellationToken) =>
            UpdateSiteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to update a `Site` object.
        /// </summary>
        /// <param name="site">
        /// Required. The `Site` to update.
        /// 
        /// The `Site`'s `name` is used to identify the `Site` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Site UpdateSite(Site site, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSite(new UpdateSiteRequest
            {
                Site = gax::GaxPreconditions.CheckNotNull(site, nameof(site)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// API to update a `Site` object.
        /// </summary>
        /// <param name="site">
        /// Required. The `Site` to update.
        /// 
        /// The `Site`'s `name` is used to identify the `Site` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Site> UpdateSiteAsync(Site site, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSiteAsync(new UpdateSiteRequest
            {
                Site = gax::GaxPreconditions.CheckNotNull(site, nameof(site)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// API to update a `Site` object.
        /// </summary>
        /// <param name="site">
        /// Required. The `Site` to update.
        /// 
        /// The `Site`'s `name` is used to identify the `Site` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Site> UpdateSiteAsync(Site site, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSiteAsync(site, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch update `Site` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateSitesResponse BatchUpdateSites(BatchUpdateSitesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to batch update `Site` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateSitesResponse> BatchUpdateSitesAsync(BatchUpdateSitesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to batch update `Site` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateSitesResponse> BatchUpdateSitesAsync(BatchUpdateSitesRequest request, st::CancellationToken cancellationToken) =>
            BatchUpdateSitesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch update `Site` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Sites` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateSiteRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Site` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateSitesResponse BatchUpdateSites(string parent, scg::IEnumerable<UpdateSiteRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateSites(new BatchUpdateSitesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch update `Site` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Sites` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateSiteRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Site` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateSitesResponse> BatchUpdateSitesAsync(string parent, scg::IEnumerable<UpdateSiteRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateSitesAsync(new BatchUpdateSitesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch update `Site` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Sites` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateSiteRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Site` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateSitesResponse> BatchUpdateSitesAsync(string parent, scg::IEnumerable<UpdateSiteRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateSitesAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch update `Site` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Sites` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateSiteRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Site` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateSitesResponse BatchUpdateSites(NetworkName parent, scg::IEnumerable<UpdateSiteRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateSites(new BatchUpdateSitesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch update `Site` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Sites` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateSiteRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Site` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateSitesResponse> BatchUpdateSitesAsync(NetworkName parent, scg::IEnumerable<UpdateSiteRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateSitesAsync(new BatchUpdateSitesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch update `Site` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Sites` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateSiteRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Site` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateSitesResponse> BatchUpdateSitesAsync(NetworkName parent, scg::IEnumerable<UpdateSiteRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateSitesAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deactivates a list of `Site` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateSitesResponse BatchDeactivateSites(BatchDeactivateSitesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deactivates a list of `Site` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateSitesResponse> BatchDeactivateSitesAsync(BatchDeactivateSitesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deactivates a list of `Site` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateSitesResponse> BatchDeactivateSitesAsync(BatchDeactivateSitesRequest request, st::CancellationToken cancellationToken) =>
            BatchDeactivateSitesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deactivates a list of `Site` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `Site` objects to deactivate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateSitesResponse BatchDeactivateSites(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateSites(new BatchDeactivateSitesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `Site` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `Site` objects to deactivate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateSitesResponse> BatchDeactivateSitesAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateSitesAsync(new BatchDeactivateSitesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `Site` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `Site` objects to deactivate.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateSitesResponse> BatchDeactivateSitesAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchDeactivateSitesAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deactivates a list of `Site` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `Site` objects to deactivate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateSitesResponse BatchDeactivateSites(NetworkName parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateSites(new BatchDeactivateSitesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `Site` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `Site` objects to deactivate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateSitesResponse> BatchDeactivateSitesAsync(NetworkName parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateSitesAsync(new BatchDeactivateSitesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `Site` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `Site` objects to deactivate.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateSitesResponse> BatchDeactivateSitesAsync(NetworkName parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchDeactivateSitesAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Submits a list of `Site` objects for approval.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchSubmitSitesForApprovalResponse BatchSubmitSitesForApproval(BatchSubmitSitesForApprovalRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Submits a list of `Site` objects for approval.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchSubmitSitesForApprovalResponse> BatchSubmitSitesForApprovalAsync(BatchSubmitSitesForApprovalRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Submits a list of `Site` objects for approval.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchSubmitSitesForApprovalResponse> BatchSubmitSitesForApprovalAsync(BatchSubmitSitesForApprovalRequest request, st::CancellationToken cancellationToken) =>
            BatchSubmitSitesForApprovalAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Submits a list of `Site` objects for approval.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `Site` objects to submit for approval.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchSubmitSitesForApprovalResponse BatchSubmitSitesForApproval(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchSubmitSitesForApproval(new BatchSubmitSitesForApprovalRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Submits a list of `Site` objects for approval.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `Site` objects to submit for approval.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchSubmitSitesForApprovalResponse> BatchSubmitSitesForApprovalAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchSubmitSitesForApprovalAsync(new BatchSubmitSitesForApprovalRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Submits a list of `Site` objects for approval.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `Site` objects to submit for approval.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchSubmitSitesForApprovalResponse> BatchSubmitSitesForApprovalAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchSubmitSitesForApprovalAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Submits a list of `Site` objects for approval.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `Site` objects to submit for approval.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchSubmitSitesForApprovalResponse BatchSubmitSitesForApproval(NetworkName parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchSubmitSitesForApproval(new BatchSubmitSitesForApprovalRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Submits a list of `Site` objects for approval.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `Site` objects to submit for approval.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchSubmitSitesForApprovalResponse> BatchSubmitSitesForApprovalAsync(NetworkName parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchSubmitSitesForApprovalAsync(new BatchSubmitSitesForApprovalRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Submits a list of `Site` objects for approval.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `Site` objects to submit for approval.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchSubmitSitesForApprovalResponse> BatchSubmitSitesForApprovalAsync(NetworkName parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchSubmitSitesForApprovalAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>SiteService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `Site` objects.
    /// </remarks>
    public sealed partial class SiteServiceClientImpl : SiteServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetSiteRequest, Site> _callGetSite;

        private readonly gaxgrpc::ApiCall<ListSitesRequest, ListSitesResponse> _callListSites;

        private readonly gaxgrpc::ApiCall<CreateSiteRequest, Site> _callCreateSite;

        private readonly gaxgrpc::ApiCall<BatchCreateSitesRequest, BatchCreateSitesResponse> _callBatchCreateSites;

        private readonly gaxgrpc::ApiCall<UpdateSiteRequest, Site> _callUpdateSite;

        private readonly gaxgrpc::ApiCall<BatchUpdateSitesRequest, BatchUpdateSitesResponse> _callBatchUpdateSites;

        private readonly gaxgrpc::ApiCall<BatchDeactivateSitesRequest, BatchDeactivateSitesResponse> _callBatchDeactivateSites;

        private readonly gaxgrpc::ApiCall<BatchSubmitSitesForApprovalRequest, BatchSubmitSitesForApprovalResponse> _callBatchSubmitSitesForApproval;

        /// <summary>
        /// Constructs a client wrapper for the SiteService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SiteServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SiteServiceClientImpl(SiteService.SiteServiceClient grpcClient, SiteServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SiteServiceSettings effectiveSettings = settings ?? SiteServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetSite = clientHelper.BuildApiCall<GetSiteRequest, Site>("GetSite", grpcClient.GetSiteAsync, grpcClient.GetSite, effectiveSettings.GetSiteSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSite);
            Modify_GetSiteApiCall(ref _callGetSite);
            _callListSites = clientHelper.BuildApiCall<ListSitesRequest, ListSitesResponse>("ListSites", grpcClient.ListSitesAsync, grpcClient.ListSites, effectiveSettings.ListSitesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSites);
            Modify_ListSitesApiCall(ref _callListSites);
            _callCreateSite = clientHelper.BuildApiCall<CreateSiteRequest, Site>("CreateSite", grpcClient.CreateSiteAsync, grpcClient.CreateSite, effectiveSettings.CreateSiteSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSite);
            Modify_CreateSiteApiCall(ref _callCreateSite);
            _callBatchCreateSites = clientHelper.BuildApiCall<BatchCreateSitesRequest, BatchCreateSitesResponse>("BatchCreateSites", grpcClient.BatchCreateSitesAsync, grpcClient.BatchCreateSites, effectiveSettings.BatchCreateSitesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCreateSites);
            Modify_BatchCreateSitesApiCall(ref _callBatchCreateSites);
            _callUpdateSite = clientHelper.BuildApiCall<UpdateSiteRequest, Site>("UpdateSite", grpcClient.UpdateSiteAsync, grpcClient.UpdateSite, effectiveSettings.UpdateSiteSettings).WithGoogleRequestParam("site.name", request => request.Site?.Name);
            Modify_ApiCall(ref _callUpdateSite);
            Modify_UpdateSiteApiCall(ref _callUpdateSite);
            _callBatchUpdateSites = clientHelper.BuildApiCall<BatchUpdateSitesRequest, BatchUpdateSitesResponse>("BatchUpdateSites", grpcClient.BatchUpdateSitesAsync, grpcClient.BatchUpdateSites, effectiveSettings.BatchUpdateSitesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchUpdateSites);
            Modify_BatchUpdateSitesApiCall(ref _callBatchUpdateSites);
            _callBatchDeactivateSites = clientHelper.BuildApiCall<BatchDeactivateSitesRequest, BatchDeactivateSitesResponse>("BatchDeactivateSites", grpcClient.BatchDeactivateSitesAsync, grpcClient.BatchDeactivateSites, effectiveSettings.BatchDeactivateSitesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchDeactivateSites);
            Modify_BatchDeactivateSitesApiCall(ref _callBatchDeactivateSites);
            _callBatchSubmitSitesForApproval = clientHelper.BuildApiCall<BatchSubmitSitesForApprovalRequest, BatchSubmitSitesForApprovalResponse>("BatchSubmitSitesForApproval", grpcClient.BatchSubmitSitesForApprovalAsync, grpcClient.BatchSubmitSitesForApproval, effectiveSettings.BatchSubmitSitesForApprovalSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchSubmitSitesForApproval);
            Modify_BatchSubmitSitesForApprovalApiCall(ref _callBatchSubmitSitesForApproval);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetSiteApiCall(ref gaxgrpc::ApiCall<GetSiteRequest, Site> call);

        partial void Modify_ListSitesApiCall(ref gaxgrpc::ApiCall<ListSitesRequest, ListSitesResponse> call);

        partial void Modify_CreateSiteApiCall(ref gaxgrpc::ApiCall<CreateSiteRequest, Site> call);

        partial void Modify_BatchCreateSitesApiCall(ref gaxgrpc::ApiCall<BatchCreateSitesRequest, BatchCreateSitesResponse> call);

        partial void Modify_UpdateSiteApiCall(ref gaxgrpc::ApiCall<UpdateSiteRequest, Site> call);

        partial void Modify_BatchUpdateSitesApiCall(ref gaxgrpc::ApiCall<BatchUpdateSitesRequest, BatchUpdateSitesResponse> call);

        partial void Modify_BatchDeactivateSitesApiCall(ref gaxgrpc::ApiCall<BatchDeactivateSitesRequest, BatchDeactivateSitesResponse> call);

        partial void Modify_BatchSubmitSitesForApprovalApiCall(ref gaxgrpc::ApiCall<BatchSubmitSitesForApprovalRequest, BatchSubmitSitesForApprovalResponse> call);

        partial void OnConstruction(SiteService.SiteServiceClient grpcClient, SiteServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SiteService client</summary>
        public override SiteService.SiteServiceClient GrpcClient { get; }

        partial void Modify_GetSiteRequest(ref GetSiteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSitesRequest(ref ListSitesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateSiteRequest(ref CreateSiteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateSitesRequest(ref BatchCreateSitesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSiteRequest(ref UpdateSiteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUpdateSitesRequest(ref BatchUpdateSitesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchDeactivateSitesRequest(ref BatchDeactivateSitesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchSubmitSitesForApprovalRequest(ref BatchSubmitSitesForApprovalRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// API to retrieve a `Site` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Site GetSite(GetSiteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSiteRequest(ref request, ref callSettings);
            return _callGetSite.Sync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a `Site` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Site> GetSiteAsync(GetSiteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSiteRequest(ref request, ref callSettings);
            return _callGetSite.Async(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Site` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Site"/> resources.</returns>
        public override gax::PagedEnumerable<ListSitesResponse, Site> ListSites(ListSitesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSitesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSitesRequest, ListSitesResponse, Site>(_callListSites, request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Site` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Site"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSitesResponse, Site> ListSitesAsync(ListSitesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSitesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSitesRequest, ListSitesResponse, Site>(_callListSites, request, callSettings);
        }

        /// <summary>
        /// API to create a `Site` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Site CreateSite(CreateSiteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSiteRequest(ref request, ref callSettings);
            return _callCreateSite.Sync(request, callSettings);
        }

        /// <summary>
        /// API to create a `Site` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Site> CreateSiteAsync(CreateSiteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSiteRequest(ref request, ref callSettings);
            return _callCreateSite.Async(request, callSettings);
        }

        /// <summary>
        /// API to batch create `Site` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchCreateSitesResponse BatchCreateSites(BatchCreateSitesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateSitesRequest(ref request, ref callSettings);
            return _callBatchCreateSites.Sync(request, callSettings);
        }

        /// <summary>
        /// API to batch create `Site` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchCreateSitesResponse> BatchCreateSitesAsync(BatchCreateSitesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateSitesRequest(ref request, ref callSettings);
            return _callBatchCreateSites.Async(request, callSettings);
        }

        /// <summary>
        /// API to update a `Site` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Site UpdateSite(UpdateSiteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSiteRequest(ref request, ref callSettings);
            return _callUpdateSite.Sync(request, callSettings);
        }

        /// <summary>
        /// API to update a `Site` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Site> UpdateSiteAsync(UpdateSiteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSiteRequest(ref request, ref callSettings);
            return _callUpdateSite.Async(request, callSettings);
        }

        /// <summary>
        /// API to batch update `Site` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchUpdateSitesResponse BatchUpdateSites(BatchUpdateSitesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateSitesRequest(ref request, ref callSettings);
            return _callBatchUpdateSites.Sync(request, callSettings);
        }

        /// <summary>
        /// API to batch update `Site` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchUpdateSitesResponse> BatchUpdateSitesAsync(BatchUpdateSitesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateSitesRequest(ref request, ref callSettings);
            return _callBatchUpdateSites.Async(request, callSettings);
        }

        /// <summary>
        /// Deactivates a list of `Site` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchDeactivateSitesResponse BatchDeactivateSites(BatchDeactivateSitesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeactivateSitesRequest(ref request, ref callSettings);
            return _callBatchDeactivateSites.Sync(request, callSettings);
        }

        /// <summary>
        /// Deactivates a list of `Site` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchDeactivateSitesResponse> BatchDeactivateSitesAsync(BatchDeactivateSitesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeactivateSitesRequest(ref request, ref callSettings);
            return _callBatchDeactivateSites.Async(request, callSettings);
        }

        /// <summary>
        /// Submits a list of `Site` objects for approval.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchSubmitSitesForApprovalResponse BatchSubmitSitesForApproval(BatchSubmitSitesForApprovalRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchSubmitSitesForApprovalRequest(ref request, ref callSettings);
            return _callBatchSubmitSitesForApproval.Sync(request, callSettings);
        }

        /// <summary>
        /// Submits a list of `Site` objects for approval.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchSubmitSitesForApprovalResponse> BatchSubmitSitesForApprovalAsync(BatchSubmitSitesForApprovalRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchSubmitSitesForApprovalRequest(ref request, ref callSettings);
            return _callBatchSubmitSitesForApproval.Async(request, callSettings);
        }
    }

    public partial class ListSitesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSitesResponse : gaxgrpc::IPageResponse<Site>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Site> GetEnumerator() => Sites.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
