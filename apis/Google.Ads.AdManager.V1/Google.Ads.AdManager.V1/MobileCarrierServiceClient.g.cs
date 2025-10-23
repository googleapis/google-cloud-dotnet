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

namespace Google.Ads.AdManager.V1
{
    /// <summary>Settings for <see cref="MobileCarrierServiceClient"/> instances.</summary>
    public sealed partial class MobileCarrierServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="MobileCarrierServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="MobileCarrierServiceSettings"/>.</returns>
        public static MobileCarrierServiceSettings GetDefault() => new MobileCarrierServiceSettings();

        /// <summary>Constructs a new <see cref="MobileCarrierServiceSettings"/> object with default settings.</summary>
        public MobileCarrierServiceSettings()
        {
        }

        private MobileCarrierServiceSettings(MobileCarrierServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetMobileCarrierSettings = existing.GetMobileCarrierSettings;
            ListMobileCarriersSettings = existing.ListMobileCarriersSettings;
            OnCopy(existing);
        }

        partial void OnCopy(MobileCarrierServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MobileCarrierServiceClient.GetMobileCarrier</c> and <c>MobileCarrierServiceClient.GetMobileCarrierAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetMobileCarrierSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MobileCarrierServiceClient.ListMobileCarriers</c> and
        /// <c>MobileCarrierServiceClient.ListMobileCarriersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListMobileCarriersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="MobileCarrierServiceSettings"/> object.</returns>
        public MobileCarrierServiceSettings Clone() => new MobileCarrierServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="MobileCarrierServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class MobileCarrierServiceClientBuilder : gaxgrpc::ClientBuilderBase<MobileCarrierServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public MobileCarrierServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public MobileCarrierServiceClientBuilder() : base(MobileCarrierServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref MobileCarrierServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<MobileCarrierServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override MobileCarrierServiceClient Build()
        {
            MobileCarrierServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<MobileCarrierServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<MobileCarrierServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private MobileCarrierServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return MobileCarrierServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<MobileCarrierServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return MobileCarrierServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => MobileCarrierServiceClient.ChannelPool;
    }

    /// <summary>MobileCarrierService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `MobileCarrier` objects.
    /// </remarks>
    public abstract partial class MobileCarrierServiceClient
    {
        /// <summary>
        /// The default endpoint for the MobileCarrierService service, which is a host of "admanager.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default MobileCarrierService scopes.</summary>
        /// <remarks>
        /// The default MobileCarrierService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/admanager</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admanager",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(MobileCarrierService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="MobileCarrierServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="MobileCarrierServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="MobileCarrierServiceClient"/>.</returns>
        public static stt::Task<MobileCarrierServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new MobileCarrierServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="MobileCarrierServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="MobileCarrierServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="MobileCarrierServiceClient"/>.</returns>
        public static MobileCarrierServiceClient Create() => new MobileCarrierServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="MobileCarrierServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="MobileCarrierServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="MobileCarrierServiceClient"/>.</returns>
        internal static MobileCarrierServiceClient Create(grpccore::CallInvoker callInvoker, MobileCarrierServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            MobileCarrierService.MobileCarrierServiceClient grpcClient = new MobileCarrierService.MobileCarrierServiceClient(callInvoker);
            return new MobileCarrierServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC MobileCarrierService client</summary>
        public virtual MobileCarrierService.MobileCarrierServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `MobileCarrier` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MobileCarrier GetMobileCarrier(GetMobileCarrierRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `MobileCarrier` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MobileCarrier> GetMobileCarrierAsync(GetMobileCarrierRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `MobileCarrier` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MobileCarrier> GetMobileCarrierAsync(GetMobileCarrierRequest request, st::CancellationToken cancellationToken) =>
            GetMobileCarrierAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `MobileCarrier` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the MobileCarrier.
        /// Format: `networks/{network_code}/mobileCarriers/{mobile_carrier_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MobileCarrier GetMobileCarrier(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMobileCarrier(new GetMobileCarrierRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `MobileCarrier` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the MobileCarrier.
        /// Format: `networks/{network_code}/mobileCarriers/{mobile_carrier_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MobileCarrier> GetMobileCarrierAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMobileCarrierAsync(new GetMobileCarrierRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `MobileCarrier` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the MobileCarrier.
        /// Format: `networks/{network_code}/mobileCarriers/{mobile_carrier_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MobileCarrier> GetMobileCarrierAsync(string name, st::CancellationToken cancellationToken) =>
            GetMobileCarrierAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `MobileCarrier` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the MobileCarrier.
        /// Format: `networks/{network_code}/mobileCarriers/{mobile_carrier_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MobileCarrier GetMobileCarrier(MobileCarrierName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMobileCarrier(new GetMobileCarrierRequest
            {
                MobileCarrierName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `MobileCarrier` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the MobileCarrier.
        /// Format: `networks/{network_code}/mobileCarriers/{mobile_carrier_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MobileCarrier> GetMobileCarrierAsync(MobileCarrierName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMobileCarrierAsync(new GetMobileCarrierRequest
            {
                MobileCarrierName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `MobileCarrier` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the MobileCarrier.
        /// Format: `networks/{network_code}/mobileCarriers/{mobile_carrier_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MobileCarrier> GetMobileCarrierAsync(MobileCarrierName name, st::CancellationToken cancellationToken) =>
            GetMobileCarrierAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a list of `MobileCarrier` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MobileCarrier"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMobileCarriersResponse, MobileCarrier> ListMobileCarriers(ListMobileCarriersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `MobileCarrier` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MobileCarrier"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMobileCarriersResponse, MobileCarrier> ListMobileCarriersAsync(ListMobileCarriersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `MobileCarrier` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of MobileCarriers.
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
        /// <returns>A pageable sequence of <see cref="MobileCarrier"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMobileCarriersResponse, MobileCarrier> ListMobileCarriers(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMobileCarriersRequest request = new ListMobileCarriersRequest
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
            return ListMobileCarriers(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `MobileCarrier` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of MobileCarriers.
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
        /// <returns>A pageable asynchronous sequence of <see cref="MobileCarrier"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMobileCarriersResponse, MobileCarrier> ListMobileCarriersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMobileCarriersRequest request = new ListMobileCarriersRequest
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
            return ListMobileCarriersAsync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `MobileCarrier` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of MobileCarriers.
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
        /// <returns>A pageable sequence of <see cref="MobileCarrier"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMobileCarriersResponse, MobileCarrier> ListMobileCarriers(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMobileCarriersRequest request = new ListMobileCarriersRequest
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
            return ListMobileCarriers(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `MobileCarrier` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of MobileCarriers.
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
        /// <returns>A pageable asynchronous sequence of <see cref="MobileCarrier"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMobileCarriersResponse, MobileCarrier> ListMobileCarriersAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMobileCarriersRequest request = new ListMobileCarriersRequest
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
            return ListMobileCarriersAsync(request, callSettings);
        }
    }

    /// <summary>MobileCarrierService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `MobileCarrier` objects.
    /// </remarks>
    public sealed partial class MobileCarrierServiceClientImpl : MobileCarrierServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetMobileCarrierRequest, MobileCarrier> _callGetMobileCarrier;

        private readonly gaxgrpc::ApiCall<ListMobileCarriersRequest, ListMobileCarriersResponse> _callListMobileCarriers;

        /// <summary>
        /// Constructs a client wrapper for the MobileCarrierService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="MobileCarrierServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public MobileCarrierServiceClientImpl(MobileCarrierService.MobileCarrierServiceClient grpcClient, MobileCarrierServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            MobileCarrierServiceSettings effectiveSettings = settings ?? MobileCarrierServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetMobileCarrier = clientHelper.BuildApiCall<GetMobileCarrierRequest, MobileCarrier>("GetMobileCarrier", grpcClient.GetMobileCarrierAsync, grpcClient.GetMobileCarrier, effectiveSettings.GetMobileCarrierSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMobileCarrier);
            Modify_GetMobileCarrierApiCall(ref _callGetMobileCarrier);
            _callListMobileCarriers = clientHelper.BuildApiCall<ListMobileCarriersRequest, ListMobileCarriersResponse>("ListMobileCarriers", grpcClient.ListMobileCarriersAsync, grpcClient.ListMobileCarriers, effectiveSettings.ListMobileCarriersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListMobileCarriers);
            Modify_ListMobileCarriersApiCall(ref _callListMobileCarriers);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetMobileCarrierApiCall(ref gaxgrpc::ApiCall<GetMobileCarrierRequest, MobileCarrier> call);

        partial void Modify_ListMobileCarriersApiCall(ref gaxgrpc::ApiCall<ListMobileCarriersRequest, ListMobileCarriersResponse> call);

        partial void OnConstruction(MobileCarrierService.MobileCarrierServiceClient grpcClient, MobileCarrierServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC MobileCarrierService client</summary>
        public override MobileCarrierService.MobileCarrierServiceClient GrpcClient { get; }

        partial void Modify_GetMobileCarrierRequest(ref GetMobileCarrierRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListMobileCarriersRequest(ref ListMobileCarriersRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// API to retrieve a `MobileCarrier` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MobileCarrier GetMobileCarrier(GetMobileCarrierRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMobileCarrierRequest(ref request, ref callSettings);
            return _callGetMobileCarrier.Sync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a `MobileCarrier` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MobileCarrier> GetMobileCarrierAsync(GetMobileCarrierRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMobileCarrierRequest(ref request, ref callSettings);
            return _callGetMobileCarrier.Async(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `MobileCarrier` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MobileCarrier"/> resources.</returns>
        public override gax::PagedEnumerable<ListMobileCarriersResponse, MobileCarrier> ListMobileCarriers(ListMobileCarriersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMobileCarriersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMobileCarriersRequest, ListMobileCarriersResponse, MobileCarrier>(_callListMobileCarriers, request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `MobileCarrier` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MobileCarrier"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListMobileCarriersResponse, MobileCarrier> ListMobileCarriersAsync(ListMobileCarriersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMobileCarriersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMobileCarriersRequest, ListMobileCarriersResponse, MobileCarrier>(_callListMobileCarriers, request, callSettings);
        }
    }

    public partial class ListMobileCarriersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMobileCarriersResponse : gaxgrpc::IPageResponse<MobileCarrier>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<MobileCarrier> GetEnumerator() => MobileCarriers.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
