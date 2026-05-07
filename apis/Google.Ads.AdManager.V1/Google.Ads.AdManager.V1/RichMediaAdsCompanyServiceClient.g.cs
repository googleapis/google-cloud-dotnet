// Copyright 2026 Google LLC
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

namespace Google.Ads.AdManager.V1
{
    /// <summary>Settings for <see cref="RichMediaAdsCompanyServiceClient"/> instances.</summary>
    public sealed partial class RichMediaAdsCompanyServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="RichMediaAdsCompanyServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="RichMediaAdsCompanyServiceSettings"/>.</returns>
        public static RichMediaAdsCompanyServiceSettings GetDefault() => new RichMediaAdsCompanyServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="RichMediaAdsCompanyServiceSettings"/> object with default settings.
        /// </summary>
        public RichMediaAdsCompanyServiceSettings()
        {
        }

        private RichMediaAdsCompanyServiceSettings(RichMediaAdsCompanyServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetRichMediaAdsCompanySettings = existing.GetRichMediaAdsCompanySettings;
            ListRichMediaAdsCompaniesSettings = existing.ListRichMediaAdsCompaniesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(RichMediaAdsCompanyServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RichMediaAdsCompanyServiceClient.GetRichMediaAdsCompany</c> and
        /// <c>RichMediaAdsCompanyServiceClient.GetRichMediaAdsCompanyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetRichMediaAdsCompanySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RichMediaAdsCompanyServiceClient.ListRichMediaAdsCompanies</c> and
        /// <c>RichMediaAdsCompanyServiceClient.ListRichMediaAdsCompaniesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListRichMediaAdsCompaniesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="RichMediaAdsCompanyServiceSettings"/> object.</returns>
        public RichMediaAdsCompanyServiceSettings Clone() => new RichMediaAdsCompanyServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="RichMediaAdsCompanyServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class RichMediaAdsCompanyServiceClientBuilder : gaxgrpc::ClientBuilderBase<RichMediaAdsCompanyServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public RichMediaAdsCompanyServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public RichMediaAdsCompanyServiceClientBuilder() : base(RichMediaAdsCompanyServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref RichMediaAdsCompanyServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<RichMediaAdsCompanyServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override RichMediaAdsCompanyServiceClient Build()
        {
            RichMediaAdsCompanyServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<RichMediaAdsCompanyServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<RichMediaAdsCompanyServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private RichMediaAdsCompanyServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return RichMediaAdsCompanyServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<RichMediaAdsCompanyServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return RichMediaAdsCompanyServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => RichMediaAdsCompanyServiceClient.ChannelPool;
    }

    /// <summary>RichMediaAdsCompanyService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `RichMediaAdsCompany` objects.
    /// </remarks>
    public abstract partial class RichMediaAdsCompanyServiceClient
    {
        /// <summary>
        /// The default endpoint for the RichMediaAdsCompanyService service, which is a host of
        /// "admanager.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default RichMediaAdsCompanyService scopes.</summary>
        /// <remarks>
        /// The default RichMediaAdsCompanyService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/admanager</description></item>
        /// <item><description>https://www.googleapis.com/auth/admanager.readonly</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admanager",
            "https://www.googleapis.com/auth/admanager.readonly",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(RichMediaAdsCompanyService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="RichMediaAdsCompanyServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="RichMediaAdsCompanyServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="RichMediaAdsCompanyServiceClient"/>.</returns>
        public static stt::Task<RichMediaAdsCompanyServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new RichMediaAdsCompanyServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="RichMediaAdsCompanyServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="RichMediaAdsCompanyServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="RichMediaAdsCompanyServiceClient"/>.</returns>
        public static RichMediaAdsCompanyServiceClient Create() => new RichMediaAdsCompanyServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="RichMediaAdsCompanyServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="RichMediaAdsCompanyServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="RichMediaAdsCompanyServiceClient"/>.</returns>
        internal static RichMediaAdsCompanyServiceClient Create(grpccore::CallInvoker callInvoker, RichMediaAdsCompanyServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            RichMediaAdsCompanyService.RichMediaAdsCompanyServiceClient grpcClient = new RichMediaAdsCompanyService.RichMediaAdsCompanyServiceClient(callInvoker);
            return new RichMediaAdsCompanyServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC RichMediaAdsCompanyService client</summary>
        public virtual RichMediaAdsCompanyService.RichMediaAdsCompanyServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `RichMediaAdsCompany` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RichMediaAdsCompany GetRichMediaAdsCompany(GetRichMediaAdsCompanyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `RichMediaAdsCompany` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RichMediaAdsCompany> GetRichMediaAdsCompanyAsync(GetRichMediaAdsCompanyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `RichMediaAdsCompany` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RichMediaAdsCompany> GetRichMediaAdsCompanyAsync(GetRichMediaAdsCompanyRequest request, st::CancellationToken cancellationToken) =>
            GetRichMediaAdsCompanyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `RichMediaAdsCompany` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the RichMediaAdsCompany.
        /// Format:
        /// `networks/{network_code}/richMediaAdsCompanies/{rich_media_ads_company_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RichMediaAdsCompany GetRichMediaAdsCompany(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRichMediaAdsCompany(new GetRichMediaAdsCompanyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `RichMediaAdsCompany` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the RichMediaAdsCompany.
        /// Format:
        /// `networks/{network_code}/richMediaAdsCompanies/{rich_media_ads_company_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RichMediaAdsCompany> GetRichMediaAdsCompanyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRichMediaAdsCompanyAsync(new GetRichMediaAdsCompanyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `RichMediaAdsCompany` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the RichMediaAdsCompany.
        /// Format:
        /// `networks/{network_code}/richMediaAdsCompanies/{rich_media_ads_company_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RichMediaAdsCompany> GetRichMediaAdsCompanyAsync(string name, st::CancellationToken cancellationToken) =>
            GetRichMediaAdsCompanyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `RichMediaAdsCompany` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the RichMediaAdsCompany.
        /// Format:
        /// `networks/{network_code}/richMediaAdsCompanies/{rich_media_ads_company_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RichMediaAdsCompany GetRichMediaAdsCompany(RichMediaAdsCompanyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRichMediaAdsCompany(new GetRichMediaAdsCompanyRequest
            {
                RichMediaAdsCompanyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `RichMediaAdsCompany` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the RichMediaAdsCompany.
        /// Format:
        /// `networks/{network_code}/richMediaAdsCompanies/{rich_media_ads_company_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RichMediaAdsCompany> GetRichMediaAdsCompanyAsync(RichMediaAdsCompanyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRichMediaAdsCompanyAsync(new GetRichMediaAdsCompanyRequest
            {
                RichMediaAdsCompanyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `RichMediaAdsCompany` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the RichMediaAdsCompany.
        /// Format:
        /// `networks/{network_code}/richMediaAdsCompanies/{rich_media_ads_company_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RichMediaAdsCompany> GetRichMediaAdsCompanyAsync(RichMediaAdsCompanyName name, st::CancellationToken cancellationToken) =>
            GetRichMediaAdsCompanyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a list of `RichMediaAdsCompany` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RichMediaAdsCompany"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRichMediaAdsCompaniesResponse, RichMediaAdsCompany> ListRichMediaAdsCompanies(ListRichMediaAdsCompaniesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `RichMediaAdsCompany` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RichMediaAdsCompany"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRichMediaAdsCompaniesResponse, RichMediaAdsCompany> ListRichMediaAdsCompaniesAsync(ListRichMediaAdsCompaniesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `RichMediaAdsCompany` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of RichMediaAdsCompanies.
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
        /// <returns>A pageable sequence of <see cref="RichMediaAdsCompany"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRichMediaAdsCompaniesResponse, RichMediaAdsCompany> ListRichMediaAdsCompanies(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRichMediaAdsCompaniesRequest request = new ListRichMediaAdsCompaniesRequest
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
            return ListRichMediaAdsCompanies(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `RichMediaAdsCompany` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of RichMediaAdsCompanies.
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
        /// <returns>A pageable asynchronous sequence of <see cref="RichMediaAdsCompany"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRichMediaAdsCompaniesResponse, RichMediaAdsCompany> ListRichMediaAdsCompaniesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRichMediaAdsCompaniesRequest request = new ListRichMediaAdsCompaniesRequest
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
            return ListRichMediaAdsCompaniesAsync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `RichMediaAdsCompany` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of RichMediaAdsCompanies.
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
        /// <returns>A pageable sequence of <see cref="RichMediaAdsCompany"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRichMediaAdsCompaniesResponse, RichMediaAdsCompany> ListRichMediaAdsCompanies(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRichMediaAdsCompaniesRequest request = new ListRichMediaAdsCompaniesRequest
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
            return ListRichMediaAdsCompanies(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `RichMediaAdsCompany` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of RichMediaAdsCompanies.
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
        /// <returns>A pageable asynchronous sequence of <see cref="RichMediaAdsCompany"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRichMediaAdsCompaniesResponse, RichMediaAdsCompany> ListRichMediaAdsCompaniesAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRichMediaAdsCompaniesRequest request = new ListRichMediaAdsCompaniesRequest
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
            return ListRichMediaAdsCompaniesAsync(request, callSettings);
        }
    }

    /// <summary>RichMediaAdsCompanyService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `RichMediaAdsCompany` objects.
    /// </remarks>
    public sealed partial class RichMediaAdsCompanyServiceClientImpl : RichMediaAdsCompanyServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetRichMediaAdsCompanyRequest, RichMediaAdsCompany> _callGetRichMediaAdsCompany;

        private readonly gaxgrpc::ApiCall<ListRichMediaAdsCompaniesRequest, ListRichMediaAdsCompaniesResponse> _callListRichMediaAdsCompanies;

        /// <summary>
        /// Constructs a client wrapper for the RichMediaAdsCompanyService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="RichMediaAdsCompanyServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public RichMediaAdsCompanyServiceClientImpl(RichMediaAdsCompanyService.RichMediaAdsCompanyServiceClient grpcClient, RichMediaAdsCompanyServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            RichMediaAdsCompanyServiceSettings effectiveSettings = settings ?? RichMediaAdsCompanyServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetRichMediaAdsCompany = clientHelper.BuildApiCall<GetRichMediaAdsCompanyRequest, RichMediaAdsCompany>("GetRichMediaAdsCompany", grpcClient.GetRichMediaAdsCompanyAsync, grpcClient.GetRichMediaAdsCompany, effectiveSettings.GetRichMediaAdsCompanySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRichMediaAdsCompany);
            Modify_GetRichMediaAdsCompanyApiCall(ref _callGetRichMediaAdsCompany);
            _callListRichMediaAdsCompanies = clientHelper.BuildApiCall<ListRichMediaAdsCompaniesRequest, ListRichMediaAdsCompaniesResponse>("ListRichMediaAdsCompanies", grpcClient.ListRichMediaAdsCompaniesAsync, grpcClient.ListRichMediaAdsCompanies, effectiveSettings.ListRichMediaAdsCompaniesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRichMediaAdsCompanies);
            Modify_ListRichMediaAdsCompaniesApiCall(ref _callListRichMediaAdsCompanies);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetRichMediaAdsCompanyApiCall(ref gaxgrpc::ApiCall<GetRichMediaAdsCompanyRequest, RichMediaAdsCompany> call);

        partial void Modify_ListRichMediaAdsCompaniesApiCall(ref gaxgrpc::ApiCall<ListRichMediaAdsCompaniesRequest, ListRichMediaAdsCompaniesResponse> call);

        partial void OnConstruction(RichMediaAdsCompanyService.RichMediaAdsCompanyServiceClient grpcClient, RichMediaAdsCompanyServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC RichMediaAdsCompanyService client</summary>
        public override RichMediaAdsCompanyService.RichMediaAdsCompanyServiceClient GrpcClient { get; }

        partial void Modify_GetRichMediaAdsCompanyRequest(ref GetRichMediaAdsCompanyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRichMediaAdsCompaniesRequest(ref ListRichMediaAdsCompaniesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// API to retrieve a `RichMediaAdsCompany` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RichMediaAdsCompany GetRichMediaAdsCompany(GetRichMediaAdsCompanyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRichMediaAdsCompanyRequest(ref request, ref callSettings);
            return _callGetRichMediaAdsCompany.Sync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a `RichMediaAdsCompany` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RichMediaAdsCompany> GetRichMediaAdsCompanyAsync(GetRichMediaAdsCompanyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRichMediaAdsCompanyRequest(ref request, ref callSettings);
            return _callGetRichMediaAdsCompany.Async(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `RichMediaAdsCompany` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RichMediaAdsCompany"/> resources.</returns>
        public override gax::PagedEnumerable<ListRichMediaAdsCompaniesResponse, RichMediaAdsCompany> ListRichMediaAdsCompanies(ListRichMediaAdsCompaniesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRichMediaAdsCompaniesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRichMediaAdsCompaniesRequest, ListRichMediaAdsCompaniesResponse, RichMediaAdsCompany>(_callListRichMediaAdsCompanies, request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `RichMediaAdsCompany` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RichMediaAdsCompany"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRichMediaAdsCompaniesResponse, RichMediaAdsCompany> ListRichMediaAdsCompaniesAsync(ListRichMediaAdsCompaniesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRichMediaAdsCompaniesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRichMediaAdsCompaniesRequest, ListRichMediaAdsCompaniesResponse, RichMediaAdsCompany>(_callListRichMediaAdsCompanies, request, callSettings);
        }
    }

    public partial class ListRichMediaAdsCompaniesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRichMediaAdsCompaniesResponse : gaxgrpc::IPageResponse<RichMediaAdsCompany>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<RichMediaAdsCompany> GetEnumerator() => RichMediaAdsCompanies.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
