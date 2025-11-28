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
    /// <summary>Settings for <see cref="PrivateAuctionDealServiceClient"/> instances.</summary>
    public sealed partial class PrivateAuctionDealServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="PrivateAuctionDealServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="PrivateAuctionDealServiceSettings"/>.</returns>
        public static PrivateAuctionDealServiceSettings GetDefault() => new PrivateAuctionDealServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="PrivateAuctionDealServiceSettings"/> object with default settings.
        /// </summary>
        public PrivateAuctionDealServiceSettings()
        {
        }

        private PrivateAuctionDealServiceSettings(PrivateAuctionDealServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetPrivateAuctionDealSettings = existing.GetPrivateAuctionDealSettings;
            ListPrivateAuctionDealsSettings = existing.ListPrivateAuctionDealsSettings;
            CreatePrivateAuctionDealSettings = existing.CreatePrivateAuctionDealSettings;
            UpdatePrivateAuctionDealSettings = existing.UpdatePrivateAuctionDealSettings;
            OnCopy(existing);
        }

        partial void OnCopy(PrivateAuctionDealServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PrivateAuctionDealServiceClient.GetPrivateAuctionDeal</c> and
        /// <c>PrivateAuctionDealServiceClient.GetPrivateAuctionDealAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetPrivateAuctionDealSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PrivateAuctionDealServiceClient.ListPrivateAuctionDeals</c> and
        /// <c>PrivateAuctionDealServiceClient.ListPrivateAuctionDealsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListPrivateAuctionDealsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PrivateAuctionDealServiceClient.CreatePrivateAuctionDeal</c> and
        /// <c>PrivateAuctionDealServiceClient.CreatePrivateAuctionDealAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreatePrivateAuctionDealSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PrivateAuctionDealServiceClient.UpdatePrivateAuctionDeal</c> and
        /// <c>PrivateAuctionDealServiceClient.UpdatePrivateAuctionDealAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdatePrivateAuctionDealSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="PrivateAuctionDealServiceSettings"/> object.</returns>
        public PrivateAuctionDealServiceSettings Clone() => new PrivateAuctionDealServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PrivateAuctionDealServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class PrivateAuctionDealServiceClientBuilder : gaxgrpc::ClientBuilderBase<PrivateAuctionDealServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public PrivateAuctionDealServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public PrivateAuctionDealServiceClientBuilder() : base(PrivateAuctionDealServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref PrivateAuctionDealServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<PrivateAuctionDealServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override PrivateAuctionDealServiceClient Build()
        {
            PrivateAuctionDealServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<PrivateAuctionDealServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<PrivateAuctionDealServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private PrivateAuctionDealServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PrivateAuctionDealServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<PrivateAuctionDealServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PrivateAuctionDealServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => PrivateAuctionDealServiceClient.ChannelPool;
    }

    /// <summary>PrivateAuctionDealService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `PrivateAuctionDeal` objects.
    /// </remarks>
    public abstract partial class PrivateAuctionDealServiceClient
    {
        /// <summary>
        /// The default endpoint for the PrivateAuctionDealService service, which is a host of
        /// "admanager.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default PrivateAuctionDealService scopes.</summary>
        /// <remarks>
        /// The default PrivateAuctionDealService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/admanager</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admanager",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(PrivateAuctionDealService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="PrivateAuctionDealServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="PrivateAuctionDealServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="PrivateAuctionDealServiceClient"/>.</returns>
        public static stt::Task<PrivateAuctionDealServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new PrivateAuctionDealServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="PrivateAuctionDealServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="PrivateAuctionDealServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="PrivateAuctionDealServiceClient"/>.</returns>
        public static PrivateAuctionDealServiceClient Create() => new PrivateAuctionDealServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="PrivateAuctionDealServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="PrivateAuctionDealServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="PrivateAuctionDealServiceClient"/>.</returns>
        internal static PrivateAuctionDealServiceClient Create(grpccore::CallInvoker callInvoker, PrivateAuctionDealServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            PrivateAuctionDealService.PrivateAuctionDealServiceClient grpcClient = new PrivateAuctionDealService.PrivateAuctionDealServiceClient(callInvoker);
            return new PrivateAuctionDealServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC PrivateAuctionDealService client</summary>
        public virtual PrivateAuctionDealService.PrivateAuctionDealServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `PrivateAuctionDeal` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrivateAuctionDeal GetPrivateAuctionDeal(GetPrivateAuctionDealRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `PrivateAuctionDeal` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateAuctionDeal> GetPrivateAuctionDealAsync(GetPrivateAuctionDealRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `PrivateAuctionDeal` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateAuctionDeal> GetPrivateAuctionDealAsync(GetPrivateAuctionDealRequest request, st::CancellationToken cancellationToken) =>
            GetPrivateAuctionDealAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `PrivateAuctionDeal` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the PrivateAuctionDeal.
        /// Format:
        /// `networks/{network_code}/privateAuctionDeals/{private_auction_deal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrivateAuctionDeal GetPrivateAuctionDeal(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPrivateAuctionDeal(new GetPrivateAuctionDealRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `PrivateAuctionDeal` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the PrivateAuctionDeal.
        /// Format:
        /// `networks/{network_code}/privateAuctionDeals/{private_auction_deal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateAuctionDeal> GetPrivateAuctionDealAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPrivateAuctionDealAsync(new GetPrivateAuctionDealRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `PrivateAuctionDeal` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the PrivateAuctionDeal.
        /// Format:
        /// `networks/{network_code}/privateAuctionDeals/{private_auction_deal_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateAuctionDeal> GetPrivateAuctionDealAsync(string name, st::CancellationToken cancellationToken) =>
            GetPrivateAuctionDealAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `PrivateAuctionDeal` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the PrivateAuctionDeal.
        /// Format:
        /// `networks/{network_code}/privateAuctionDeals/{private_auction_deal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrivateAuctionDeal GetPrivateAuctionDeal(PrivateAuctionDealName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPrivateAuctionDeal(new GetPrivateAuctionDealRequest
            {
                PrivateAuctionDealName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `PrivateAuctionDeal` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the PrivateAuctionDeal.
        /// Format:
        /// `networks/{network_code}/privateAuctionDeals/{private_auction_deal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateAuctionDeal> GetPrivateAuctionDealAsync(PrivateAuctionDealName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPrivateAuctionDealAsync(new GetPrivateAuctionDealRequest
            {
                PrivateAuctionDealName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `PrivateAuctionDeal` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the PrivateAuctionDeal.
        /// Format:
        /// `networks/{network_code}/privateAuctionDeals/{private_auction_deal_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateAuctionDeal> GetPrivateAuctionDealAsync(PrivateAuctionDealName name, st::CancellationToken cancellationToken) =>
            GetPrivateAuctionDealAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a list of `PrivateAuctionDeal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PrivateAuctionDeal"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPrivateAuctionDealsResponse, PrivateAuctionDeal> ListPrivateAuctionDeals(ListPrivateAuctionDealsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `PrivateAuctionDeal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PrivateAuctionDeal"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPrivateAuctionDealsResponse, PrivateAuctionDeal> ListPrivateAuctionDealsAsync(ListPrivateAuctionDealsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `PrivateAuctionDeal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of PrivateAuctionDeals.
        /// Format:
        /// `networks/{network_code}`
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
        /// <returns>A pageable sequence of <see cref="PrivateAuctionDeal"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPrivateAuctionDealsResponse, PrivateAuctionDeal> ListPrivateAuctionDeals(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPrivateAuctionDealsRequest request = new ListPrivateAuctionDealsRequest
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
            return ListPrivateAuctionDeals(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `PrivateAuctionDeal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of PrivateAuctionDeals.
        /// Format:
        /// `networks/{network_code}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="PrivateAuctionDeal"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPrivateAuctionDealsResponse, PrivateAuctionDeal> ListPrivateAuctionDealsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPrivateAuctionDealsRequest request = new ListPrivateAuctionDealsRequest
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
            return ListPrivateAuctionDealsAsync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `PrivateAuctionDeal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of PrivateAuctionDeals.
        /// Format:
        /// `networks/{network_code}`
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
        /// <returns>A pageable sequence of <see cref="PrivateAuctionDeal"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPrivateAuctionDealsResponse, PrivateAuctionDeal> ListPrivateAuctionDeals(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPrivateAuctionDealsRequest request = new ListPrivateAuctionDealsRequest
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
            return ListPrivateAuctionDeals(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `PrivateAuctionDeal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of PrivateAuctionDeals.
        /// Format:
        /// `networks/{network_code}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="PrivateAuctionDeal"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPrivateAuctionDealsResponse, PrivateAuctionDeal> ListPrivateAuctionDealsAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPrivateAuctionDealsRequest request = new ListPrivateAuctionDealsRequest
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
            return ListPrivateAuctionDealsAsync(request, callSettings);
        }

        /// <summary>
        /// API to create a `PrivateAuctionDeal` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrivateAuctionDeal CreatePrivateAuctionDeal(CreatePrivateAuctionDealRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to create a `PrivateAuctionDeal` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateAuctionDeal> CreatePrivateAuctionDealAsync(CreatePrivateAuctionDealRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to create a `PrivateAuctionDeal` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateAuctionDeal> CreatePrivateAuctionDealAsync(CreatePrivateAuctionDealRequest request, st::CancellationToken cancellationToken) =>
            CreatePrivateAuctionDealAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to create a `PrivateAuctionDeal` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `PrivateAuctionDeal` will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="privateAuctionDeal">
        /// Required. The `PrivateAuctionDeal` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrivateAuctionDeal CreatePrivateAuctionDeal(string parent, PrivateAuctionDeal privateAuctionDeal, gaxgrpc::CallSettings callSettings = null) =>
            CreatePrivateAuctionDeal(new CreatePrivateAuctionDealRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PrivateAuctionDeal = gax::GaxPreconditions.CheckNotNull(privateAuctionDeal, nameof(privateAuctionDeal)),
            }, callSettings);

        /// <summary>
        /// API to create a `PrivateAuctionDeal` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `PrivateAuctionDeal` will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="privateAuctionDeal">
        /// Required. The `PrivateAuctionDeal` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateAuctionDeal> CreatePrivateAuctionDealAsync(string parent, PrivateAuctionDeal privateAuctionDeal, gaxgrpc::CallSettings callSettings = null) =>
            CreatePrivateAuctionDealAsync(new CreatePrivateAuctionDealRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PrivateAuctionDeal = gax::GaxPreconditions.CheckNotNull(privateAuctionDeal, nameof(privateAuctionDeal)),
            }, callSettings);

        /// <summary>
        /// API to create a `PrivateAuctionDeal` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `PrivateAuctionDeal` will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="privateAuctionDeal">
        /// Required. The `PrivateAuctionDeal` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateAuctionDeal> CreatePrivateAuctionDealAsync(string parent, PrivateAuctionDeal privateAuctionDeal, st::CancellationToken cancellationToken) =>
            CreatePrivateAuctionDealAsync(parent, privateAuctionDeal, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to create a `PrivateAuctionDeal` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `PrivateAuctionDeal` will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="privateAuctionDeal">
        /// Required. The `PrivateAuctionDeal` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrivateAuctionDeal CreatePrivateAuctionDeal(NetworkName parent, PrivateAuctionDeal privateAuctionDeal, gaxgrpc::CallSettings callSettings = null) =>
            CreatePrivateAuctionDeal(new CreatePrivateAuctionDealRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PrivateAuctionDeal = gax::GaxPreconditions.CheckNotNull(privateAuctionDeal, nameof(privateAuctionDeal)),
            }, callSettings);

        /// <summary>
        /// API to create a `PrivateAuctionDeal` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `PrivateAuctionDeal` will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="privateAuctionDeal">
        /// Required. The `PrivateAuctionDeal` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateAuctionDeal> CreatePrivateAuctionDealAsync(NetworkName parent, PrivateAuctionDeal privateAuctionDeal, gaxgrpc::CallSettings callSettings = null) =>
            CreatePrivateAuctionDealAsync(new CreatePrivateAuctionDealRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PrivateAuctionDeal = gax::GaxPreconditions.CheckNotNull(privateAuctionDeal, nameof(privateAuctionDeal)),
            }, callSettings);

        /// <summary>
        /// API to create a `PrivateAuctionDeal` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `PrivateAuctionDeal` will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="privateAuctionDeal">
        /// Required. The `PrivateAuctionDeal` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateAuctionDeal> CreatePrivateAuctionDealAsync(NetworkName parent, PrivateAuctionDeal privateAuctionDeal, st::CancellationToken cancellationToken) =>
            CreatePrivateAuctionDealAsync(parent, privateAuctionDeal, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to update a `PrivateAuctionDeal` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrivateAuctionDeal UpdatePrivateAuctionDeal(UpdatePrivateAuctionDealRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to update a `PrivateAuctionDeal` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateAuctionDeal> UpdatePrivateAuctionDealAsync(UpdatePrivateAuctionDealRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to update a `PrivateAuctionDeal` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateAuctionDeal> UpdatePrivateAuctionDealAsync(UpdatePrivateAuctionDealRequest request, st::CancellationToken cancellationToken) =>
            UpdatePrivateAuctionDealAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to update a `PrivateAuctionDeal` object.
        /// </summary>
        /// <param name="privateAuctionDeal">
        /// Required. The `PrivateAuctionDeal` to update.
        /// 
        /// The `PrivateAuctionDeal`'s `name` is used to identify the
        /// `PrivateAuctionDeal` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrivateAuctionDeal UpdatePrivateAuctionDeal(PrivateAuctionDeal privateAuctionDeal, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePrivateAuctionDeal(new UpdatePrivateAuctionDealRequest
            {
                PrivateAuctionDeal = gax::GaxPreconditions.CheckNotNull(privateAuctionDeal, nameof(privateAuctionDeal)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// API to update a `PrivateAuctionDeal` object.
        /// </summary>
        /// <param name="privateAuctionDeal">
        /// Required. The `PrivateAuctionDeal` to update.
        /// 
        /// The `PrivateAuctionDeal`'s `name` is used to identify the
        /// `PrivateAuctionDeal` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateAuctionDeal> UpdatePrivateAuctionDealAsync(PrivateAuctionDeal privateAuctionDeal, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePrivateAuctionDealAsync(new UpdatePrivateAuctionDealRequest
            {
                PrivateAuctionDeal = gax::GaxPreconditions.CheckNotNull(privateAuctionDeal, nameof(privateAuctionDeal)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// API to update a `PrivateAuctionDeal` object.
        /// </summary>
        /// <param name="privateAuctionDeal">
        /// Required. The `PrivateAuctionDeal` to update.
        /// 
        /// The `PrivateAuctionDeal`'s `name` is used to identify the
        /// `PrivateAuctionDeal` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateAuctionDeal> UpdatePrivateAuctionDealAsync(PrivateAuctionDeal privateAuctionDeal, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdatePrivateAuctionDealAsync(privateAuctionDeal, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>PrivateAuctionDealService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `PrivateAuctionDeal` objects.
    /// </remarks>
    public sealed partial class PrivateAuctionDealServiceClientImpl : PrivateAuctionDealServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetPrivateAuctionDealRequest, PrivateAuctionDeal> _callGetPrivateAuctionDeal;

        private readonly gaxgrpc::ApiCall<ListPrivateAuctionDealsRequest, ListPrivateAuctionDealsResponse> _callListPrivateAuctionDeals;

        private readonly gaxgrpc::ApiCall<CreatePrivateAuctionDealRequest, PrivateAuctionDeal> _callCreatePrivateAuctionDeal;

        private readonly gaxgrpc::ApiCall<UpdatePrivateAuctionDealRequest, PrivateAuctionDeal> _callUpdatePrivateAuctionDeal;

        /// <summary>
        /// Constructs a client wrapper for the PrivateAuctionDealService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="PrivateAuctionDealServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public PrivateAuctionDealServiceClientImpl(PrivateAuctionDealService.PrivateAuctionDealServiceClient grpcClient, PrivateAuctionDealServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            PrivateAuctionDealServiceSettings effectiveSettings = settings ?? PrivateAuctionDealServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetPrivateAuctionDeal = clientHelper.BuildApiCall<GetPrivateAuctionDealRequest, PrivateAuctionDeal>("GetPrivateAuctionDeal", grpcClient.GetPrivateAuctionDealAsync, grpcClient.GetPrivateAuctionDeal, effectiveSettings.GetPrivateAuctionDealSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPrivateAuctionDeal);
            Modify_GetPrivateAuctionDealApiCall(ref _callGetPrivateAuctionDeal);
            _callListPrivateAuctionDeals = clientHelper.BuildApiCall<ListPrivateAuctionDealsRequest, ListPrivateAuctionDealsResponse>("ListPrivateAuctionDeals", grpcClient.ListPrivateAuctionDealsAsync, grpcClient.ListPrivateAuctionDeals, effectiveSettings.ListPrivateAuctionDealsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPrivateAuctionDeals);
            Modify_ListPrivateAuctionDealsApiCall(ref _callListPrivateAuctionDeals);
            _callCreatePrivateAuctionDeal = clientHelper.BuildApiCall<CreatePrivateAuctionDealRequest, PrivateAuctionDeal>("CreatePrivateAuctionDeal", grpcClient.CreatePrivateAuctionDealAsync, grpcClient.CreatePrivateAuctionDeal, effectiveSettings.CreatePrivateAuctionDealSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreatePrivateAuctionDeal);
            Modify_CreatePrivateAuctionDealApiCall(ref _callCreatePrivateAuctionDeal);
            _callUpdatePrivateAuctionDeal = clientHelper.BuildApiCall<UpdatePrivateAuctionDealRequest, PrivateAuctionDeal>("UpdatePrivateAuctionDeal", grpcClient.UpdatePrivateAuctionDealAsync, grpcClient.UpdatePrivateAuctionDeal, effectiveSettings.UpdatePrivateAuctionDealSettings).WithGoogleRequestParam("private_auction_deal.name", request => request.PrivateAuctionDeal?.Name);
            Modify_ApiCall(ref _callUpdatePrivateAuctionDeal);
            Modify_UpdatePrivateAuctionDealApiCall(ref _callUpdatePrivateAuctionDeal);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetPrivateAuctionDealApiCall(ref gaxgrpc::ApiCall<GetPrivateAuctionDealRequest, PrivateAuctionDeal> call);

        partial void Modify_ListPrivateAuctionDealsApiCall(ref gaxgrpc::ApiCall<ListPrivateAuctionDealsRequest, ListPrivateAuctionDealsResponse> call);

        partial void Modify_CreatePrivateAuctionDealApiCall(ref gaxgrpc::ApiCall<CreatePrivateAuctionDealRequest, PrivateAuctionDeal> call);

        partial void Modify_UpdatePrivateAuctionDealApiCall(ref gaxgrpc::ApiCall<UpdatePrivateAuctionDealRequest, PrivateAuctionDeal> call);

        partial void OnConstruction(PrivateAuctionDealService.PrivateAuctionDealServiceClient grpcClient, PrivateAuctionDealServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC PrivateAuctionDealService client</summary>
        public override PrivateAuctionDealService.PrivateAuctionDealServiceClient GrpcClient { get; }

        partial void Modify_GetPrivateAuctionDealRequest(ref GetPrivateAuctionDealRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPrivateAuctionDealsRequest(ref ListPrivateAuctionDealsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreatePrivateAuctionDealRequest(ref CreatePrivateAuctionDealRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdatePrivateAuctionDealRequest(ref UpdatePrivateAuctionDealRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// API to retrieve a `PrivateAuctionDeal` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PrivateAuctionDeal GetPrivateAuctionDeal(GetPrivateAuctionDealRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPrivateAuctionDealRequest(ref request, ref callSettings);
            return _callGetPrivateAuctionDeal.Sync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a `PrivateAuctionDeal` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PrivateAuctionDeal> GetPrivateAuctionDealAsync(GetPrivateAuctionDealRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPrivateAuctionDealRequest(ref request, ref callSettings);
            return _callGetPrivateAuctionDeal.Async(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `PrivateAuctionDeal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PrivateAuctionDeal"/> resources.</returns>
        public override gax::PagedEnumerable<ListPrivateAuctionDealsResponse, PrivateAuctionDeal> ListPrivateAuctionDeals(ListPrivateAuctionDealsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPrivateAuctionDealsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPrivateAuctionDealsRequest, ListPrivateAuctionDealsResponse, PrivateAuctionDeal>(_callListPrivateAuctionDeals, request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `PrivateAuctionDeal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PrivateAuctionDeal"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPrivateAuctionDealsResponse, PrivateAuctionDeal> ListPrivateAuctionDealsAsync(ListPrivateAuctionDealsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPrivateAuctionDealsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPrivateAuctionDealsRequest, ListPrivateAuctionDealsResponse, PrivateAuctionDeal>(_callListPrivateAuctionDeals, request, callSettings);
        }

        /// <summary>
        /// API to create a `PrivateAuctionDeal` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PrivateAuctionDeal CreatePrivateAuctionDeal(CreatePrivateAuctionDealRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePrivateAuctionDealRequest(ref request, ref callSettings);
            return _callCreatePrivateAuctionDeal.Sync(request, callSettings);
        }

        /// <summary>
        /// API to create a `PrivateAuctionDeal` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PrivateAuctionDeal> CreatePrivateAuctionDealAsync(CreatePrivateAuctionDealRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePrivateAuctionDealRequest(ref request, ref callSettings);
            return _callCreatePrivateAuctionDeal.Async(request, callSettings);
        }

        /// <summary>
        /// API to update a `PrivateAuctionDeal` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PrivateAuctionDeal UpdatePrivateAuctionDeal(UpdatePrivateAuctionDealRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePrivateAuctionDealRequest(ref request, ref callSettings);
            return _callUpdatePrivateAuctionDeal.Sync(request, callSettings);
        }

        /// <summary>
        /// API to update a `PrivateAuctionDeal` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PrivateAuctionDeal> UpdatePrivateAuctionDealAsync(UpdatePrivateAuctionDealRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePrivateAuctionDealRequest(ref request, ref callSettings);
            return _callUpdatePrivateAuctionDeal.Async(request, callSettings);
        }
    }

    public partial class ListPrivateAuctionDealsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPrivateAuctionDealsResponse : gaxgrpc::IPageResponse<PrivateAuctionDeal>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PrivateAuctionDeal> GetEnumerator() => PrivateAuctionDeals.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
