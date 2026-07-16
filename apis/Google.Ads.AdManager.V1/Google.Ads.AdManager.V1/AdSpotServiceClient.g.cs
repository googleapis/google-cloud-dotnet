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
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Ads.AdManager.V1
{
    /// <summary>Settings for <see cref="AdSpotServiceClient"/> instances.</summary>
    public sealed partial class AdSpotServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AdSpotServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AdSpotServiceSettings"/>.</returns>
        public static AdSpotServiceSettings GetDefault() => new AdSpotServiceSettings();

        /// <summary>Constructs a new <see cref="AdSpotServiceSettings"/> object with default settings.</summary>
        public AdSpotServiceSettings()
        {
        }

        private AdSpotServiceSettings(AdSpotServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetAdSpotSettings = existing.GetAdSpotSettings;
            ListAdSpotsSettings = existing.ListAdSpotsSettings;
            CreateAdSpotSettings = existing.CreateAdSpotSettings;
            BatchCreateAdSpotsSettings = existing.BatchCreateAdSpotsSettings;
            UpdateAdSpotSettings = existing.UpdateAdSpotSettings;
            BatchUpdateAdSpotsSettings = existing.BatchUpdateAdSpotsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AdSpotServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdSpotServiceClient.GetAdSpot</c> and <c>AdSpotServiceClient.GetAdSpotAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAdSpotSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdSpotServiceClient.ListAdSpots</c> and <c>AdSpotServiceClient.ListAdSpotsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAdSpotsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdSpotServiceClient.CreateAdSpot</c> and <c>AdSpotServiceClient.CreateAdSpotAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAdSpotSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdSpotServiceClient.BatchCreateAdSpots</c> and <c>AdSpotServiceClient.BatchCreateAdSpotsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchCreateAdSpotsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdSpotServiceClient.UpdateAdSpot</c> and <c>AdSpotServiceClient.UpdateAdSpotAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAdSpotSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdSpotServiceClient.BatchUpdateAdSpots</c> and <c>AdSpotServiceClient.BatchUpdateAdSpotsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchUpdateAdSpotsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AdSpotServiceSettings"/> object.</returns>
        public AdSpotServiceSettings Clone() => new AdSpotServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AdSpotServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class AdSpotServiceClientBuilder : gaxgrpc::ClientBuilderBase<AdSpotServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AdSpotServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AdSpotServiceClientBuilder() : base(AdSpotServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AdSpotServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AdSpotServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AdSpotServiceClient Build()
        {
            AdSpotServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AdSpotServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AdSpotServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AdSpotServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AdSpotServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AdSpotServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AdSpotServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AdSpotServiceClient.ChannelPool;
    }

    /// <summary>AdSpotService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `AdSpot` objects.
    /// </remarks>
    public abstract partial class AdSpotServiceClient
    {
        /// <summary>
        /// The default endpoint for the AdSpotService service, which is a host of "admanager.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default AdSpotService scopes.</summary>
        /// <remarks>
        /// The default AdSpotService scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AdSpotService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AdSpotServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AdSpotServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AdSpotServiceClient"/>.</returns>
        public static stt::Task<AdSpotServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AdSpotServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AdSpotServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AdSpotServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AdSpotServiceClient"/>.</returns>
        public static AdSpotServiceClient Create() => new AdSpotServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AdSpotServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AdSpotServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AdSpotServiceClient"/>.</returns>
        internal static AdSpotServiceClient Create(grpccore::CallInvoker callInvoker, AdSpotServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AdSpotService.AdSpotServiceClient grpcClient = new AdSpotService.AdSpotServiceClient(callInvoker);
            return new AdSpotServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AdSpotService client</summary>
        public virtual AdSpotService.AdSpotServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an `AdSpot` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AdSpot GetAdSpot(GetAdSpotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an `AdSpot` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdSpot> GetAdSpotAsync(GetAdSpotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an `AdSpot` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdSpot> GetAdSpotAsync(GetAdSpotRequest request, st::CancellationToken cancellationToken) =>
            GetAdSpotAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves an `AdSpot` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AdSpot.
        /// Format: `networks/{network_code}/adSpots/{ad_spot_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AdSpot GetAdSpot(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAdSpot(new GetAdSpotRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves an `AdSpot` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AdSpot.
        /// Format: `networks/{network_code}/adSpots/{ad_spot_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdSpot> GetAdSpotAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAdSpotAsync(new GetAdSpotRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves an `AdSpot` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AdSpot.
        /// Format: `networks/{network_code}/adSpots/{ad_spot_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdSpot> GetAdSpotAsync(string name, st::CancellationToken cancellationToken) =>
            GetAdSpotAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves an `AdSpot` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AdSpot.
        /// Format: `networks/{network_code}/adSpots/{ad_spot_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AdSpot GetAdSpot(AdSpotName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAdSpot(new GetAdSpotRequest
            {
                AdSpotName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves an `AdSpot` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AdSpot.
        /// Format: `networks/{network_code}/adSpots/{ad_spot_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdSpot> GetAdSpotAsync(AdSpotName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAdSpotAsync(new GetAdSpotRequest
            {
                AdSpotName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves an `AdSpot` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AdSpot.
        /// Format: `networks/{network_code}/adSpots/{ad_spot_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdSpot> GetAdSpotAsync(AdSpotName name, st::CancellationToken cancellationToken) =>
            GetAdSpotAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists `AdSpot` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AdSpot"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAdSpotsResponse, AdSpot> ListAdSpots(ListAdSpotsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `AdSpot` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AdSpot"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAdSpotsResponse, AdSpot> ListAdSpotsAsync(ListAdSpotsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `AdSpot` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of AdSpots.
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
        /// <returns>A pageable sequence of <see cref="AdSpot"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAdSpotsResponse, AdSpot> ListAdSpots(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAdSpotsRequest request = new ListAdSpotsRequest
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
            return ListAdSpots(request, callSettings);
        }

        /// <summary>
        /// Lists `AdSpot` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of AdSpots.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AdSpot"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAdSpotsResponse, AdSpot> ListAdSpotsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAdSpotsRequest request = new ListAdSpotsRequest
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
            return ListAdSpotsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists `AdSpot` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of AdSpots.
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
        /// <returns>A pageable sequence of <see cref="AdSpot"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAdSpotsResponse, AdSpot> ListAdSpots(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAdSpotsRequest request = new ListAdSpotsRequest
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
            return ListAdSpots(request, callSettings);
        }

        /// <summary>
        /// Lists `AdSpot` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of AdSpots.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AdSpot"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAdSpotsResponse, AdSpot> ListAdSpotsAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAdSpotsRequest request = new ListAdSpotsRequest
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
            return ListAdSpotsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates an `AdSpot` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AdSpot CreateAdSpot(CreateAdSpotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an `AdSpot` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdSpot> CreateAdSpotAsync(CreateAdSpotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an `AdSpot` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdSpot> CreateAdSpotAsync(CreateAdSpotRequest request, st::CancellationToken cancellationToken) =>
            CreateAdSpotAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an `AdSpot` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `AdSpot` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="adSpot">
        /// Required. The `AdSpot` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AdSpot CreateAdSpot(string parent, AdSpot adSpot, gaxgrpc::CallSettings callSettings = null) =>
            CreateAdSpot(new CreateAdSpotRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AdSpot = gax::GaxPreconditions.CheckNotNull(adSpot, nameof(adSpot)),
            }, callSettings);

        /// <summary>
        /// Creates an `AdSpot` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `AdSpot` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="adSpot">
        /// Required. The `AdSpot` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdSpot> CreateAdSpotAsync(string parent, AdSpot adSpot, gaxgrpc::CallSettings callSettings = null) =>
            CreateAdSpotAsync(new CreateAdSpotRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AdSpot = gax::GaxPreconditions.CheckNotNull(adSpot, nameof(adSpot)),
            }, callSettings);

        /// <summary>
        /// Creates an `AdSpot` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `AdSpot` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="adSpot">
        /// Required. The `AdSpot` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdSpot> CreateAdSpotAsync(string parent, AdSpot adSpot, st::CancellationToken cancellationToken) =>
            CreateAdSpotAsync(parent, adSpot, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an `AdSpot` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `AdSpot` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="adSpot">
        /// Required. The `AdSpot` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AdSpot CreateAdSpot(NetworkName parent, AdSpot adSpot, gaxgrpc::CallSettings callSettings = null) =>
            CreateAdSpot(new CreateAdSpotRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AdSpot = gax::GaxPreconditions.CheckNotNull(adSpot, nameof(adSpot)),
            }, callSettings);

        /// <summary>
        /// Creates an `AdSpot` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `AdSpot` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="adSpot">
        /// Required. The `AdSpot` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdSpot> CreateAdSpotAsync(NetworkName parent, AdSpot adSpot, gaxgrpc::CallSettings callSettings = null) =>
            CreateAdSpotAsync(new CreateAdSpotRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AdSpot = gax::GaxPreconditions.CheckNotNull(adSpot, nameof(adSpot)),
            }, callSettings);

        /// <summary>
        /// Creates an `AdSpot` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `AdSpot` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="adSpot">
        /// Required. The `AdSpot` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdSpot> CreateAdSpotAsync(NetworkName parent, AdSpot adSpot, st::CancellationToken cancellationToken) =>
            CreateAdSpotAsync(parent, adSpot, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch creates `AdSpot` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateAdSpotsResponse BatchCreateAdSpots(BatchCreateAdSpotsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch creates `AdSpot` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateAdSpotsResponse> BatchCreateAdSpotsAsync(BatchCreateAdSpotsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch creates `AdSpot` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateAdSpotsResponse> BatchCreateAdSpotsAsync(BatchCreateAdSpotsRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateAdSpotsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch creates `AdSpot` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `AdSpots` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateAdSpotRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `AdSpot` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateAdSpotsResponse BatchCreateAdSpots(string parent, scg::IEnumerable<CreateAdSpotRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateAdSpots(new BatchCreateAdSpotsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch creates `AdSpot` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `AdSpots` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateAdSpotRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `AdSpot` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateAdSpotsResponse> BatchCreateAdSpotsAsync(string parent, scg::IEnumerable<CreateAdSpotRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateAdSpotsAsync(new BatchCreateAdSpotsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch creates `AdSpot` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `AdSpots` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateAdSpotRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `AdSpot` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateAdSpotsResponse> BatchCreateAdSpotsAsync(string parent, scg::IEnumerable<CreateAdSpotRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateAdSpotsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch creates `AdSpot` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `AdSpots` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateAdSpotRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `AdSpot` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateAdSpotsResponse BatchCreateAdSpots(NetworkName parent, scg::IEnumerable<CreateAdSpotRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateAdSpots(new BatchCreateAdSpotsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch creates `AdSpot` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `AdSpots` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateAdSpotRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `AdSpot` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateAdSpotsResponse> BatchCreateAdSpotsAsync(NetworkName parent, scg::IEnumerable<CreateAdSpotRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateAdSpotsAsync(new BatchCreateAdSpotsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch creates `AdSpot` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `AdSpots` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateAdSpotRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `AdSpot` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateAdSpotsResponse> BatchCreateAdSpotsAsync(NetworkName parent, scg::IEnumerable<CreateAdSpotRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateAdSpotsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an `AdSpot` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AdSpot UpdateAdSpot(UpdateAdSpotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an `AdSpot` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdSpot> UpdateAdSpotAsync(UpdateAdSpotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an `AdSpot` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdSpot> UpdateAdSpotAsync(UpdateAdSpotRequest request, st::CancellationToken cancellationToken) =>
            UpdateAdSpotAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an `AdSpot` object.
        /// </summary>
        /// <param name="adSpot">
        /// Required. The `AdSpot` to update.
        /// 
        /// The `AdSpot`'s `name` is used to identify the `AdSpot` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AdSpot UpdateAdSpot(AdSpot adSpot, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAdSpot(new UpdateAdSpotRequest
            {
                AdSpot = gax::GaxPreconditions.CheckNotNull(adSpot, nameof(adSpot)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an `AdSpot` object.
        /// </summary>
        /// <param name="adSpot">
        /// Required. The `AdSpot` to update.
        /// 
        /// The `AdSpot`'s `name` is used to identify the `AdSpot` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdSpot> UpdateAdSpotAsync(AdSpot adSpot, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAdSpotAsync(new UpdateAdSpotRequest
            {
                AdSpot = gax::GaxPreconditions.CheckNotNull(adSpot, nameof(adSpot)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an `AdSpot` object.
        /// </summary>
        /// <param name="adSpot">
        /// Required. The `AdSpot` to update.
        /// 
        /// The `AdSpot`'s `name` is used to identify the `AdSpot` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdSpot> UpdateAdSpotAsync(AdSpot adSpot, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAdSpotAsync(adSpot, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `AdSpot` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateAdSpotsResponse BatchUpdateAdSpots(BatchUpdateAdSpotsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch updates `AdSpot` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateAdSpotsResponse> BatchUpdateAdSpotsAsync(BatchUpdateAdSpotsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch updates `AdSpot` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateAdSpotsResponse> BatchUpdateAdSpotsAsync(BatchUpdateAdSpotsRequest request, st::CancellationToken cancellationToken) =>
            BatchUpdateAdSpotsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `AdSpot` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `AdSpots` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateAdSpotRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `AdSpot` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateAdSpotsResponse BatchUpdateAdSpots(string parent, scg::IEnumerable<UpdateAdSpotRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateAdSpots(new BatchUpdateAdSpotsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `AdSpot` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `AdSpots` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateAdSpotRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `AdSpot` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateAdSpotsResponse> BatchUpdateAdSpotsAsync(string parent, scg::IEnumerable<UpdateAdSpotRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateAdSpotsAsync(new BatchUpdateAdSpotsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `AdSpot` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `AdSpots` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateAdSpotRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `AdSpot` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateAdSpotsResponse> BatchUpdateAdSpotsAsync(string parent, scg::IEnumerable<UpdateAdSpotRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateAdSpotsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `AdSpot` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `AdSpots` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateAdSpotRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `AdSpot` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateAdSpotsResponse BatchUpdateAdSpots(NetworkName parent, scg::IEnumerable<UpdateAdSpotRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateAdSpots(new BatchUpdateAdSpotsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `AdSpot` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `AdSpots` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateAdSpotRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `AdSpot` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateAdSpotsResponse> BatchUpdateAdSpotsAsync(NetworkName parent, scg::IEnumerable<UpdateAdSpotRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateAdSpotsAsync(new BatchUpdateAdSpotsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `AdSpot` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `AdSpots` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateAdSpotRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `AdSpot` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateAdSpotsResponse> BatchUpdateAdSpotsAsync(NetworkName parent, scg::IEnumerable<UpdateAdSpotRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateAdSpotsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AdSpotService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `AdSpot` objects.
    /// </remarks>
    public sealed partial class AdSpotServiceClientImpl : AdSpotServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetAdSpotRequest, AdSpot> _callGetAdSpot;

        private readonly gaxgrpc::ApiCall<ListAdSpotsRequest, ListAdSpotsResponse> _callListAdSpots;

        private readonly gaxgrpc::ApiCall<CreateAdSpotRequest, AdSpot> _callCreateAdSpot;

        private readonly gaxgrpc::ApiCall<BatchCreateAdSpotsRequest, BatchCreateAdSpotsResponse> _callBatchCreateAdSpots;

        private readonly gaxgrpc::ApiCall<UpdateAdSpotRequest, AdSpot> _callUpdateAdSpot;

        private readonly gaxgrpc::ApiCall<BatchUpdateAdSpotsRequest, BatchUpdateAdSpotsResponse> _callBatchUpdateAdSpots;

        /// <summary>
        /// Constructs a client wrapper for the AdSpotService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AdSpotServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AdSpotServiceClientImpl(AdSpotService.AdSpotServiceClient grpcClient, AdSpotServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AdSpotServiceSettings effectiveSettings = settings ?? AdSpotServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetAdSpot = clientHelper.BuildApiCall<GetAdSpotRequest, AdSpot>("GetAdSpot", grpcClient.GetAdSpotAsync, grpcClient.GetAdSpot, effectiveSettings.GetAdSpotSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAdSpot);
            Modify_GetAdSpotApiCall(ref _callGetAdSpot);
            _callListAdSpots = clientHelper.BuildApiCall<ListAdSpotsRequest, ListAdSpotsResponse>("ListAdSpots", grpcClient.ListAdSpotsAsync, grpcClient.ListAdSpots, effectiveSettings.ListAdSpotsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAdSpots);
            Modify_ListAdSpotsApiCall(ref _callListAdSpots);
            _callCreateAdSpot = clientHelper.BuildApiCall<CreateAdSpotRequest, AdSpot>("CreateAdSpot", grpcClient.CreateAdSpotAsync, grpcClient.CreateAdSpot, effectiveSettings.CreateAdSpotSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAdSpot);
            Modify_CreateAdSpotApiCall(ref _callCreateAdSpot);
            _callBatchCreateAdSpots = clientHelper.BuildApiCall<BatchCreateAdSpotsRequest, BatchCreateAdSpotsResponse>("BatchCreateAdSpots", grpcClient.BatchCreateAdSpotsAsync, grpcClient.BatchCreateAdSpots, effectiveSettings.BatchCreateAdSpotsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCreateAdSpots);
            Modify_BatchCreateAdSpotsApiCall(ref _callBatchCreateAdSpots);
            _callUpdateAdSpot = clientHelper.BuildApiCall<UpdateAdSpotRequest, AdSpot>("UpdateAdSpot", grpcClient.UpdateAdSpotAsync, grpcClient.UpdateAdSpot, effectiveSettings.UpdateAdSpotSettings).WithGoogleRequestParam("ad_spot.name", request => request.AdSpot?.Name);
            Modify_ApiCall(ref _callUpdateAdSpot);
            Modify_UpdateAdSpotApiCall(ref _callUpdateAdSpot);
            _callBatchUpdateAdSpots = clientHelper.BuildApiCall<BatchUpdateAdSpotsRequest, BatchUpdateAdSpotsResponse>("BatchUpdateAdSpots", grpcClient.BatchUpdateAdSpotsAsync, grpcClient.BatchUpdateAdSpots, effectiveSettings.BatchUpdateAdSpotsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchUpdateAdSpots);
            Modify_BatchUpdateAdSpotsApiCall(ref _callBatchUpdateAdSpots);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetAdSpotApiCall(ref gaxgrpc::ApiCall<GetAdSpotRequest, AdSpot> call);

        partial void Modify_ListAdSpotsApiCall(ref gaxgrpc::ApiCall<ListAdSpotsRequest, ListAdSpotsResponse> call);

        partial void Modify_CreateAdSpotApiCall(ref gaxgrpc::ApiCall<CreateAdSpotRequest, AdSpot> call);

        partial void Modify_BatchCreateAdSpotsApiCall(ref gaxgrpc::ApiCall<BatchCreateAdSpotsRequest, BatchCreateAdSpotsResponse> call);

        partial void Modify_UpdateAdSpotApiCall(ref gaxgrpc::ApiCall<UpdateAdSpotRequest, AdSpot> call);

        partial void Modify_BatchUpdateAdSpotsApiCall(ref gaxgrpc::ApiCall<BatchUpdateAdSpotsRequest, BatchUpdateAdSpotsResponse> call);

        partial void OnConstruction(AdSpotService.AdSpotServiceClient grpcClient, AdSpotServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AdSpotService client</summary>
        public override AdSpotService.AdSpotServiceClient GrpcClient { get; }

        partial void Modify_GetAdSpotRequest(ref GetAdSpotRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAdSpotsRequest(ref ListAdSpotsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAdSpotRequest(ref CreateAdSpotRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateAdSpotsRequest(ref BatchCreateAdSpotsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAdSpotRequest(ref UpdateAdSpotRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUpdateAdSpotsRequest(ref BatchUpdateAdSpotsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves an `AdSpot` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AdSpot GetAdSpot(GetAdSpotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAdSpotRequest(ref request, ref callSettings);
            return _callGetAdSpot.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves an `AdSpot` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AdSpot> GetAdSpotAsync(GetAdSpotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAdSpotRequest(ref request, ref callSettings);
            return _callGetAdSpot.Async(request, callSettings);
        }

        /// <summary>
        /// Lists `AdSpot` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AdSpot"/> resources.</returns>
        public override gax::PagedEnumerable<ListAdSpotsResponse, AdSpot> ListAdSpots(ListAdSpotsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAdSpotsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAdSpotsRequest, ListAdSpotsResponse, AdSpot>(_callListAdSpots, request, callSettings);
        }

        /// <summary>
        /// Lists `AdSpot` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AdSpot"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAdSpotsResponse, AdSpot> ListAdSpotsAsync(ListAdSpotsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAdSpotsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAdSpotsRequest, ListAdSpotsResponse, AdSpot>(_callListAdSpots, request, callSettings);
        }

        /// <summary>
        /// Creates an `AdSpot` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AdSpot CreateAdSpot(CreateAdSpotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAdSpotRequest(ref request, ref callSettings);
            return _callCreateAdSpot.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an `AdSpot` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AdSpot> CreateAdSpotAsync(CreateAdSpotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAdSpotRequest(ref request, ref callSettings);
            return _callCreateAdSpot.Async(request, callSettings);
        }

        /// <summary>
        /// Batch creates `AdSpot` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchCreateAdSpotsResponse BatchCreateAdSpots(BatchCreateAdSpotsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateAdSpotsRequest(ref request, ref callSettings);
            return _callBatchCreateAdSpots.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch creates `AdSpot` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchCreateAdSpotsResponse> BatchCreateAdSpotsAsync(BatchCreateAdSpotsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateAdSpotsRequest(ref request, ref callSettings);
            return _callBatchCreateAdSpots.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an `AdSpot` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AdSpot UpdateAdSpot(UpdateAdSpotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAdSpotRequest(ref request, ref callSettings);
            return _callUpdateAdSpot.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an `AdSpot` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AdSpot> UpdateAdSpotAsync(UpdateAdSpotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAdSpotRequest(ref request, ref callSettings);
            return _callUpdateAdSpot.Async(request, callSettings);
        }

        /// <summary>
        /// Batch updates `AdSpot` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchUpdateAdSpotsResponse BatchUpdateAdSpots(BatchUpdateAdSpotsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateAdSpotsRequest(ref request, ref callSettings);
            return _callBatchUpdateAdSpots.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch updates `AdSpot` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchUpdateAdSpotsResponse> BatchUpdateAdSpotsAsync(BatchUpdateAdSpotsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateAdSpotsRequest(ref request, ref callSettings);
            return _callBatchUpdateAdSpots.Async(request, callSettings);
        }
    }

    public partial class ListAdSpotsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAdSpotsResponse : gaxgrpc::IPageResponse<AdSpot>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AdSpot> GetEnumerator() => AdSpots.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
