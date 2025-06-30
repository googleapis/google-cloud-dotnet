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
    /// <summary>Settings for <see cref="PrivateAuctionServiceClient"/> instances.</summary>
    public sealed partial class PrivateAuctionServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="PrivateAuctionServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="PrivateAuctionServiceSettings"/>.</returns>
        public static PrivateAuctionServiceSettings GetDefault() => new PrivateAuctionServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="PrivateAuctionServiceSettings"/> object with default settings.
        /// </summary>
        public PrivateAuctionServiceSettings()
        {
        }

        private PrivateAuctionServiceSettings(PrivateAuctionServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetPrivateAuctionSettings = existing.GetPrivateAuctionSettings;
            ListPrivateAuctionsSettings = existing.ListPrivateAuctionsSettings;
            CreatePrivateAuctionSettings = existing.CreatePrivateAuctionSettings;
            UpdatePrivateAuctionSettings = existing.UpdatePrivateAuctionSettings;
            OnCopy(existing);
        }

        partial void OnCopy(PrivateAuctionServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PrivateAuctionServiceClient.GetPrivateAuction</c> and
        /// <c>PrivateAuctionServiceClient.GetPrivateAuctionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetPrivateAuctionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PrivateAuctionServiceClient.ListPrivateAuctions</c> and
        /// <c>PrivateAuctionServiceClient.ListPrivateAuctionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListPrivateAuctionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PrivateAuctionServiceClient.CreatePrivateAuction</c> and
        /// <c>PrivateAuctionServiceClient.CreatePrivateAuctionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreatePrivateAuctionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PrivateAuctionServiceClient.UpdatePrivateAuction</c> and
        /// <c>PrivateAuctionServiceClient.UpdatePrivateAuctionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdatePrivateAuctionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="PrivateAuctionServiceSettings"/> object.</returns>
        public PrivateAuctionServiceSettings Clone() => new PrivateAuctionServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PrivateAuctionServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class PrivateAuctionServiceClientBuilder : gaxgrpc::ClientBuilderBase<PrivateAuctionServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public PrivateAuctionServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public PrivateAuctionServiceClientBuilder() : base(PrivateAuctionServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref PrivateAuctionServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<PrivateAuctionServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override PrivateAuctionServiceClient Build()
        {
            PrivateAuctionServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<PrivateAuctionServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<PrivateAuctionServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private PrivateAuctionServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PrivateAuctionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<PrivateAuctionServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PrivateAuctionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => PrivateAuctionServiceClient.ChannelPool;
    }

    /// <summary>PrivateAuctionService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `PrivateAuction` objects.
    /// </remarks>
    public abstract partial class PrivateAuctionServiceClient
    {
        /// <summary>
        /// The default endpoint for the PrivateAuctionService service, which is a host of "admanager.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default PrivateAuctionService scopes.</summary>
        /// <remarks>
        /// The default PrivateAuctionService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/admanager</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admanager",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(PrivateAuctionService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="PrivateAuctionServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="PrivateAuctionServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="PrivateAuctionServiceClient"/>.</returns>
        public static stt::Task<PrivateAuctionServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new PrivateAuctionServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="PrivateAuctionServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="PrivateAuctionServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="PrivateAuctionServiceClient"/>.</returns>
        public static PrivateAuctionServiceClient Create() => new PrivateAuctionServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="PrivateAuctionServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="PrivateAuctionServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="PrivateAuctionServiceClient"/>.</returns>
        internal static PrivateAuctionServiceClient Create(grpccore::CallInvoker callInvoker, PrivateAuctionServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            PrivateAuctionService.PrivateAuctionServiceClient grpcClient = new PrivateAuctionService.PrivateAuctionServiceClient(callInvoker);
            return new PrivateAuctionServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC PrivateAuctionService client</summary>
        public virtual PrivateAuctionService.PrivateAuctionServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `PrivateAuction` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrivateAuction GetPrivateAuction(GetPrivateAuctionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `PrivateAuction` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateAuction> GetPrivateAuctionAsync(GetPrivateAuctionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `PrivateAuction` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateAuction> GetPrivateAuctionAsync(GetPrivateAuctionRequest request, st::CancellationToken cancellationToken) =>
            GetPrivateAuctionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `PrivateAuction` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the PrivateAuction.
        /// Format:
        /// `networks/{network_code}/privateAuctions/{private_auction_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrivateAuction GetPrivateAuction(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPrivateAuction(new GetPrivateAuctionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `PrivateAuction` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the PrivateAuction.
        /// Format:
        /// `networks/{network_code}/privateAuctions/{private_auction_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateAuction> GetPrivateAuctionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPrivateAuctionAsync(new GetPrivateAuctionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `PrivateAuction` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the PrivateAuction.
        /// Format:
        /// `networks/{network_code}/privateAuctions/{private_auction_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateAuction> GetPrivateAuctionAsync(string name, st::CancellationToken cancellationToken) =>
            GetPrivateAuctionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `PrivateAuction` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the PrivateAuction.
        /// Format:
        /// `networks/{network_code}/privateAuctions/{private_auction_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrivateAuction GetPrivateAuction(PrivateAuctionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPrivateAuction(new GetPrivateAuctionRequest
            {
                PrivateAuctionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `PrivateAuction` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the PrivateAuction.
        /// Format:
        /// `networks/{network_code}/privateAuctions/{private_auction_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateAuction> GetPrivateAuctionAsync(PrivateAuctionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPrivateAuctionAsync(new GetPrivateAuctionRequest
            {
                PrivateAuctionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `PrivateAuction` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the PrivateAuction.
        /// Format:
        /// `networks/{network_code}/privateAuctions/{private_auction_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateAuction> GetPrivateAuctionAsync(PrivateAuctionName name, st::CancellationToken cancellationToken) =>
            GetPrivateAuctionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a list of `PrivateAuction` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PrivateAuction"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPrivateAuctionsResponse, PrivateAuction> ListPrivateAuctions(ListPrivateAuctionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `PrivateAuction` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PrivateAuction"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPrivateAuctionsResponse, PrivateAuction> ListPrivateAuctionsAsync(ListPrivateAuctionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `PrivateAuction` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of PrivateAuctions.
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
        /// <returns>A pageable sequence of <see cref="PrivateAuction"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPrivateAuctionsResponse, PrivateAuction> ListPrivateAuctions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPrivateAuctionsRequest request = new ListPrivateAuctionsRequest
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
            return ListPrivateAuctions(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `PrivateAuction` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of PrivateAuctions.
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
        /// <returns>A pageable asynchronous sequence of <see cref="PrivateAuction"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPrivateAuctionsResponse, PrivateAuction> ListPrivateAuctionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPrivateAuctionsRequest request = new ListPrivateAuctionsRequest
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
            return ListPrivateAuctionsAsync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `PrivateAuction` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of PrivateAuctions.
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
        /// <returns>A pageable sequence of <see cref="PrivateAuction"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPrivateAuctionsResponse, PrivateAuction> ListPrivateAuctions(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPrivateAuctionsRequest request = new ListPrivateAuctionsRequest
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
            return ListPrivateAuctions(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `PrivateAuction` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of PrivateAuctions.
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
        /// <returns>A pageable asynchronous sequence of <see cref="PrivateAuction"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPrivateAuctionsResponse, PrivateAuction> ListPrivateAuctionsAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPrivateAuctionsRequest request = new ListPrivateAuctionsRequest
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
            return ListPrivateAuctionsAsync(request, callSettings);
        }

        /// <summary>
        /// API to create a `PrivateAuction` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrivateAuction CreatePrivateAuction(CreatePrivateAuctionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to create a `PrivateAuction` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateAuction> CreatePrivateAuctionAsync(CreatePrivateAuctionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to create a `PrivateAuction` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateAuction> CreatePrivateAuctionAsync(CreatePrivateAuctionRequest request, st::CancellationToken cancellationToken) =>
            CreatePrivateAuctionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to create a `PrivateAuction` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `PrivateAuction` will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="privateAuction">
        /// Required. The `PrivateAuction` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrivateAuction CreatePrivateAuction(string parent, PrivateAuction privateAuction, gaxgrpc::CallSettings callSettings = null) =>
            CreatePrivateAuction(new CreatePrivateAuctionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PrivateAuction = gax::GaxPreconditions.CheckNotNull(privateAuction, nameof(privateAuction)),
            }, callSettings);

        /// <summary>
        /// API to create a `PrivateAuction` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `PrivateAuction` will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="privateAuction">
        /// Required. The `PrivateAuction` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateAuction> CreatePrivateAuctionAsync(string parent, PrivateAuction privateAuction, gaxgrpc::CallSettings callSettings = null) =>
            CreatePrivateAuctionAsync(new CreatePrivateAuctionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PrivateAuction = gax::GaxPreconditions.CheckNotNull(privateAuction, nameof(privateAuction)),
            }, callSettings);

        /// <summary>
        /// API to create a `PrivateAuction` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `PrivateAuction` will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="privateAuction">
        /// Required. The `PrivateAuction` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateAuction> CreatePrivateAuctionAsync(string parent, PrivateAuction privateAuction, st::CancellationToken cancellationToken) =>
            CreatePrivateAuctionAsync(parent, privateAuction, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to create a `PrivateAuction` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `PrivateAuction` will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="privateAuction">
        /// Required. The `PrivateAuction` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrivateAuction CreatePrivateAuction(NetworkName parent, PrivateAuction privateAuction, gaxgrpc::CallSettings callSettings = null) =>
            CreatePrivateAuction(new CreatePrivateAuctionRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PrivateAuction = gax::GaxPreconditions.CheckNotNull(privateAuction, nameof(privateAuction)),
            }, callSettings);

        /// <summary>
        /// API to create a `PrivateAuction` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `PrivateAuction` will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="privateAuction">
        /// Required. The `PrivateAuction` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateAuction> CreatePrivateAuctionAsync(NetworkName parent, PrivateAuction privateAuction, gaxgrpc::CallSettings callSettings = null) =>
            CreatePrivateAuctionAsync(new CreatePrivateAuctionRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PrivateAuction = gax::GaxPreconditions.CheckNotNull(privateAuction, nameof(privateAuction)),
            }, callSettings);

        /// <summary>
        /// API to create a `PrivateAuction` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `PrivateAuction` will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="privateAuction">
        /// Required. The `PrivateAuction` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateAuction> CreatePrivateAuctionAsync(NetworkName parent, PrivateAuction privateAuction, st::CancellationToken cancellationToken) =>
            CreatePrivateAuctionAsync(parent, privateAuction, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to update a `PrivateAuction` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrivateAuction UpdatePrivateAuction(UpdatePrivateAuctionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to update a `PrivateAuction` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateAuction> UpdatePrivateAuctionAsync(UpdatePrivateAuctionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to update a `PrivateAuction` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateAuction> UpdatePrivateAuctionAsync(UpdatePrivateAuctionRequest request, st::CancellationToken cancellationToken) =>
            UpdatePrivateAuctionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to update a `PrivateAuction` object.
        /// </summary>
        /// <param name="privateAuction">
        /// Required. The `PrivateAuction` to update.
        /// 
        /// The `PrivateAuction`'s `name` is used to identify the
        /// `PrivateAuction` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrivateAuction UpdatePrivateAuction(PrivateAuction privateAuction, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePrivateAuction(new UpdatePrivateAuctionRequest
            {
                PrivateAuction = gax::GaxPreconditions.CheckNotNull(privateAuction, nameof(privateAuction)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// API to update a `PrivateAuction` object.
        /// </summary>
        /// <param name="privateAuction">
        /// Required. The `PrivateAuction` to update.
        /// 
        /// The `PrivateAuction`'s `name` is used to identify the
        /// `PrivateAuction` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateAuction> UpdatePrivateAuctionAsync(PrivateAuction privateAuction, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePrivateAuctionAsync(new UpdatePrivateAuctionRequest
            {
                PrivateAuction = gax::GaxPreconditions.CheckNotNull(privateAuction, nameof(privateAuction)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// API to update a `PrivateAuction` object.
        /// </summary>
        /// <param name="privateAuction">
        /// Required. The `PrivateAuction` to update.
        /// 
        /// The `PrivateAuction`'s `name` is used to identify the
        /// `PrivateAuction` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateAuction> UpdatePrivateAuctionAsync(PrivateAuction privateAuction, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdatePrivateAuctionAsync(privateAuction, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>PrivateAuctionService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `PrivateAuction` objects.
    /// </remarks>
    public sealed partial class PrivateAuctionServiceClientImpl : PrivateAuctionServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetPrivateAuctionRequest, PrivateAuction> _callGetPrivateAuction;

        private readonly gaxgrpc::ApiCall<ListPrivateAuctionsRequest, ListPrivateAuctionsResponse> _callListPrivateAuctions;

        private readonly gaxgrpc::ApiCall<CreatePrivateAuctionRequest, PrivateAuction> _callCreatePrivateAuction;

        private readonly gaxgrpc::ApiCall<UpdatePrivateAuctionRequest, PrivateAuction> _callUpdatePrivateAuction;

        /// <summary>
        /// Constructs a client wrapper for the PrivateAuctionService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="PrivateAuctionServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public PrivateAuctionServiceClientImpl(PrivateAuctionService.PrivateAuctionServiceClient grpcClient, PrivateAuctionServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            PrivateAuctionServiceSettings effectiveSettings = settings ?? PrivateAuctionServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetPrivateAuction = clientHelper.BuildApiCall<GetPrivateAuctionRequest, PrivateAuction>("GetPrivateAuction", grpcClient.GetPrivateAuctionAsync, grpcClient.GetPrivateAuction, effectiveSettings.GetPrivateAuctionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPrivateAuction);
            Modify_GetPrivateAuctionApiCall(ref _callGetPrivateAuction);
            _callListPrivateAuctions = clientHelper.BuildApiCall<ListPrivateAuctionsRequest, ListPrivateAuctionsResponse>("ListPrivateAuctions", grpcClient.ListPrivateAuctionsAsync, grpcClient.ListPrivateAuctions, effectiveSettings.ListPrivateAuctionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPrivateAuctions);
            Modify_ListPrivateAuctionsApiCall(ref _callListPrivateAuctions);
            _callCreatePrivateAuction = clientHelper.BuildApiCall<CreatePrivateAuctionRequest, PrivateAuction>("CreatePrivateAuction", grpcClient.CreatePrivateAuctionAsync, grpcClient.CreatePrivateAuction, effectiveSettings.CreatePrivateAuctionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreatePrivateAuction);
            Modify_CreatePrivateAuctionApiCall(ref _callCreatePrivateAuction);
            _callUpdatePrivateAuction = clientHelper.BuildApiCall<UpdatePrivateAuctionRequest, PrivateAuction>("UpdatePrivateAuction", grpcClient.UpdatePrivateAuctionAsync, grpcClient.UpdatePrivateAuction, effectiveSettings.UpdatePrivateAuctionSettings).WithGoogleRequestParam("private_auction.name", request => request.PrivateAuction?.Name);
            Modify_ApiCall(ref _callUpdatePrivateAuction);
            Modify_UpdatePrivateAuctionApiCall(ref _callUpdatePrivateAuction);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetPrivateAuctionApiCall(ref gaxgrpc::ApiCall<GetPrivateAuctionRequest, PrivateAuction> call);

        partial void Modify_ListPrivateAuctionsApiCall(ref gaxgrpc::ApiCall<ListPrivateAuctionsRequest, ListPrivateAuctionsResponse> call);

        partial void Modify_CreatePrivateAuctionApiCall(ref gaxgrpc::ApiCall<CreatePrivateAuctionRequest, PrivateAuction> call);

        partial void Modify_UpdatePrivateAuctionApiCall(ref gaxgrpc::ApiCall<UpdatePrivateAuctionRequest, PrivateAuction> call);

        partial void OnConstruction(PrivateAuctionService.PrivateAuctionServiceClient grpcClient, PrivateAuctionServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC PrivateAuctionService client</summary>
        public override PrivateAuctionService.PrivateAuctionServiceClient GrpcClient { get; }

        partial void Modify_GetPrivateAuctionRequest(ref GetPrivateAuctionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPrivateAuctionsRequest(ref ListPrivateAuctionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreatePrivateAuctionRequest(ref CreatePrivateAuctionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdatePrivateAuctionRequest(ref UpdatePrivateAuctionRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// API to retrieve a `PrivateAuction` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PrivateAuction GetPrivateAuction(GetPrivateAuctionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPrivateAuctionRequest(ref request, ref callSettings);
            return _callGetPrivateAuction.Sync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a `PrivateAuction` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PrivateAuction> GetPrivateAuctionAsync(GetPrivateAuctionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPrivateAuctionRequest(ref request, ref callSettings);
            return _callGetPrivateAuction.Async(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `PrivateAuction` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PrivateAuction"/> resources.</returns>
        public override gax::PagedEnumerable<ListPrivateAuctionsResponse, PrivateAuction> ListPrivateAuctions(ListPrivateAuctionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPrivateAuctionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPrivateAuctionsRequest, ListPrivateAuctionsResponse, PrivateAuction>(_callListPrivateAuctions, request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `PrivateAuction` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PrivateAuction"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPrivateAuctionsResponse, PrivateAuction> ListPrivateAuctionsAsync(ListPrivateAuctionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPrivateAuctionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPrivateAuctionsRequest, ListPrivateAuctionsResponse, PrivateAuction>(_callListPrivateAuctions, request, callSettings);
        }

        /// <summary>
        /// API to create a `PrivateAuction` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PrivateAuction CreatePrivateAuction(CreatePrivateAuctionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePrivateAuctionRequest(ref request, ref callSettings);
            return _callCreatePrivateAuction.Sync(request, callSettings);
        }

        /// <summary>
        /// API to create a `PrivateAuction` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PrivateAuction> CreatePrivateAuctionAsync(CreatePrivateAuctionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePrivateAuctionRequest(ref request, ref callSettings);
            return _callCreatePrivateAuction.Async(request, callSettings);
        }

        /// <summary>
        /// API to update a `PrivateAuction` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PrivateAuction UpdatePrivateAuction(UpdatePrivateAuctionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePrivateAuctionRequest(ref request, ref callSettings);
            return _callUpdatePrivateAuction.Sync(request, callSettings);
        }

        /// <summary>
        /// API to update a `PrivateAuction` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PrivateAuction> UpdatePrivateAuctionAsync(UpdatePrivateAuctionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePrivateAuctionRequest(ref request, ref callSettings);
            return _callUpdatePrivateAuction.Async(request, callSettings);
        }
    }

    public partial class ListPrivateAuctionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPrivateAuctionsResponse : gaxgrpc::IPageResponse<PrivateAuction>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PrivateAuction> GetEnumerator() => PrivateAuctions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
