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
    /// <summary>Settings for <see cref="YieldPartnerServiceClient"/> instances.</summary>
    public sealed partial class YieldPartnerServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="YieldPartnerServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="YieldPartnerServiceSettings"/>.</returns>
        public static YieldPartnerServiceSettings GetDefault() => new YieldPartnerServiceSettings();

        /// <summary>Constructs a new <see cref="YieldPartnerServiceSettings"/> object with default settings.</summary>
        public YieldPartnerServiceSettings()
        {
        }

        private YieldPartnerServiceSettings(YieldPartnerServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetYieldPartnerSettings = existing.GetYieldPartnerSettings;
            ListYieldPartnersSettings = existing.ListYieldPartnersSettings;
            OnCopy(existing);
        }

        partial void OnCopy(YieldPartnerServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>YieldPartnerServiceClient.GetYieldPartner</c> and <c>YieldPartnerServiceClient.GetYieldPartnerAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetYieldPartnerSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>YieldPartnerServiceClient.ListYieldPartners</c> and <c>YieldPartnerServiceClient.ListYieldPartnersAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListYieldPartnersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="YieldPartnerServiceSettings"/> object.</returns>
        public YieldPartnerServiceSettings Clone() => new YieldPartnerServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="YieldPartnerServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class YieldPartnerServiceClientBuilder : gaxgrpc::ClientBuilderBase<YieldPartnerServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public YieldPartnerServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public YieldPartnerServiceClientBuilder() : base(YieldPartnerServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref YieldPartnerServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<YieldPartnerServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override YieldPartnerServiceClient Build()
        {
            YieldPartnerServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<YieldPartnerServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<YieldPartnerServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private YieldPartnerServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return YieldPartnerServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<YieldPartnerServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return YieldPartnerServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => YieldPartnerServiceClient.ChannelPool;
    }

    /// <summary>YieldPartnerService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for retrieving yield partners.
    /// </remarks>
    public abstract partial class YieldPartnerServiceClient
    {
        /// <summary>
        /// The default endpoint for the YieldPartnerService service, which is a host of "admanager.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default YieldPartnerService scopes.</summary>
        /// <remarks>
        /// The default YieldPartnerService scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(YieldPartnerService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="YieldPartnerServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="YieldPartnerServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="YieldPartnerServiceClient"/>.</returns>
        public static stt::Task<YieldPartnerServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new YieldPartnerServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="YieldPartnerServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="YieldPartnerServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="YieldPartnerServiceClient"/>.</returns>
        public static YieldPartnerServiceClient Create() => new YieldPartnerServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="YieldPartnerServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="YieldPartnerServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="YieldPartnerServiceClient"/>.</returns>
        internal static YieldPartnerServiceClient Create(grpccore::CallInvoker callInvoker, YieldPartnerServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            YieldPartnerService.YieldPartnerServiceClient grpcClient = new YieldPartnerService.YieldPartnerServiceClient(callInvoker);
            return new YieldPartnerServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC YieldPartnerService client</summary>
        public virtual YieldPartnerService.YieldPartnerServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a `YieldPartner` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual YieldPartner GetYieldPartner(GetYieldPartnerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a `YieldPartner` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<YieldPartner> GetYieldPartnerAsync(GetYieldPartnerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a `YieldPartner` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<YieldPartner> GetYieldPartnerAsync(GetYieldPartnerRequest request, st::CancellationToken cancellationToken) =>
            GetYieldPartnerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a `YieldPartner` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the yield partner.
        /// Format: `networks/{network_code}/yieldPartners/{yieldPartnerId}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual YieldPartner GetYieldPartner(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetYieldPartner(new GetYieldPartnerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a `YieldPartner` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the yield partner.
        /// Format: `networks/{network_code}/yieldPartners/{yieldPartnerId}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<YieldPartner> GetYieldPartnerAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetYieldPartnerAsync(new GetYieldPartnerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a `YieldPartner` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the yield partner.
        /// Format: `networks/{network_code}/yieldPartners/{yieldPartnerId}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<YieldPartner> GetYieldPartnerAsync(string name, st::CancellationToken cancellationToken) =>
            GetYieldPartnerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a `YieldPartner` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the yield partner.
        /// Format: `networks/{network_code}/yieldPartners/{yieldPartnerId}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual YieldPartner GetYieldPartner(YieldPartnerName name, gaxgrpc::CallSettings callSettings = null) =>
            GetYieldPartner(new GetYieldPartnerRequest
            {
                YieldPartnerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a `YieldPartner` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the yield partner.
        /// Format: `networks/{network_code}/yieldPartners/{yieldPartnerId}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<YieldPartner> GetYieldPartnerAsync(YieldPartnerName name, gaxgrpc::CallSettings callSettings = null) =>
            GetYieldPartnerAsync(new GetYieldPartnerRequest
            {
                YieldPartnerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a `YieldPartner` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the yield partner.
        /// Format: `networks/{network_code}/yieldPartners/{yieldPartnerId}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<YieldPartner> GetYieldPartnerAsync(YieldPartnerName name, st::CancellationToken cancellationToken) =>
            GetYieldPartnerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a list of all yield partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="YieldPartner"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListYieldPartnersResponse, YieldPartner> ListYieldPartners(ListYieldPartnersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a list of all yield partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="YieldPartner"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListYieldPartnersResponse, YieldPartner> ListYieldPartnersAsync(ListYieldPartnersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a list of all yield partners.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of yield partners.
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
        /// <returns>A pageable sequence of <see cref="YieldPartner"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListYieldPartnersResponse, YieldPartner> ListYieldPartners(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListYieldPartnersRequest request = new ListYieldPartnersRequest
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
            return ListYieldPartners(request, callSettings);
        }

        /// <summary>
        /// Gets a list of all yield partners.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of yield partners.
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
        /// <returns>A pageable asynchronous sequence of <see cref="YieldPartner"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListYieldPartnersResponse, YieldPartner> ListYieldPartnersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListYieldPartnersRequest request = new ListYieldPartnersRequest
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
            return ListYieldPartnersAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a list of all yield partners.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of yield partners.
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
        /// <returns>A pageable sequence of <see cref="YieldPartner"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListYieldPartnersResponse, YieldPartner> ListYieldPartners(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListYieldPartnersRequest request = new ListYieldPartnersRequest
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
            return ListYieldPartners(request, callSettings);
        }

        /// <summary>
        /// Gets a list of all yield partners.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of yield partners.
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
        /// <returns>A pageable asynchronous sequence of <see cref="YieldPartner"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListYieldPartnersResponse, YieldPartner> ListYieldPartnersAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListYieldPartnersRequest request = new ListYieldPartnersRequest
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
            return ListYieldPartnersAsync(request, callSettings);
        }
    }

    /// <summary>YieldPartnerService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for retrieving yield partners.
    /// </remarks>
    public sealed partial class YieldPartnerServiceClientImpl : YieldPartnerServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetYieldPartnerRequest, YieldPartner> _callGetYieldPartner;

        private readonly gaxgrpc::ApiCall<ListYieldPartnersRequest, ListYieldPartnersResponse> _callListYieldPartners;

        /// <summary>
        /// Constructs a client wrapper for the YieldPartnerService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="YieldPartnerServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public YieldPartnerServiceClientImpl(YieldPartnerService.YieldPartnerServiceClient grpcClient, YieldPartnerServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            YieldPartnerServiceSettings effectiveSettings = settings ?? YieldPartnerServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetYieldPartner = clientHelper.BuildApiCall<GetYieldPartnerRequest, YieldPartner>("GetYieldPartner", grpcClient.GetYieldPartnerAsync, grpcClient.GetYieldPartner, effectiveSettings.GetYieldPartnerSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetYieldPartner);
            Modify_GetYieldPartnerApiCall(ref _callGetYieldPartner);
            _callListYieldPartners = clientHelper.BuildApiCall<ListYieldPartnersRequest, ListYieldPartnersResponse>("ListYieldPartners", grpcClient.ListYieldPartnersAsync, grpcClient.ListYieldPartners, effectiveSettings.ListYieldPartnersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListYieldPartners);
            Modify_ListYieldPartnersApiCall(ref _callListYieldPartners);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetYieldPartnerApiCall(ref gaxgrpc::ApiCall<GetYieldPartnerRequest, YieldPartner> call);

        partial void Modify_ListYieldPartnersApiCall(ref gaxgrpc::ApiCall<ListYieldPartnersRequest, ListYieldPartnersResponse> call);

        partial void OnConstruction(YieldPartnerService.YieldPartnerServiceClient grpcClient, YieldPartnerServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC YieldPartnerService client</summary>
        public override YieldPartnerService.YieldPartnerServiceClient GrpcClient { get; }

        partial void Modify_GetYieldPartnerRequest(ref GetYieldPartnerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListYieldPartnersRequest(ref ListYieldPartnersRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets a `YieldPartner` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override YieldPartner GetYieldPartner(GetYieldPartnerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetYieldPartnerRequest(ref request, ref callSettings);
            return _callGetYieldPartner.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a `YieldPartner` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<YieldPartner> GetYieldPartnerAsync(GetYieldPartnerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetYieldPartnerRequest(ref request, ref callSettings);
            return _callGetYieldPartner.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a list of all yield partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="YieldPartner"/> resources.</returns>
        public override gax::PagedEnumerable<ListYieldPartnersResponse, YieldPartner> ListYieldPartners(ListYieldPartnersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListYieldPartnersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListYieldPartnersRequest, ListYieldPartnersResponse, YieldPartner>(_callListYieldPartners, request, callSettings);
        }

        /// <summary>
        /// Gets a list of all yield partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="YieldPartner"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListYieldPartnersResponse, YieldPartner> ListYieldPartnersAsync(ListYieldPartnersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListYieldPartnersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListYieldPartnersRequest, ListYieldPartnersResponse, YieldPartner>(_callListYieldPartners, request, callSettings);
        }
    }

    public partial class ListYieldPartnersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListYieldPartnersResponse : gaxgrpc::IPageResponse<YieldPartner>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<YieldPartner> GetEnumerator() => YieldPartners.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
