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
    /// <summary>Settings for <see cref="AdUnitServiceClient"/> instances.</summary>
    public sealed partial class AdUnitServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AdUnitServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AdUnitServiceSettings"/>.</returns>
        public static AdUnitServiceSettings GetDefault() => new AdUnitServiceSettings();

        /// <summary>Constructs a new <see cref="AdUnitServiceSettings"/> object with default settings.</summary>
        public AdUnitServiceSettings()
        {
        }

        private AdUnitServiceSettings(AdUnitServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetAdUnitSettings = existing.GetAdUnitSettings;
            ListAdUnitsSettings = existing.ListAdUnitsSettings;
            ListAdUnitSizesSettings = existing.ListAdUnitSizesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AdUnitServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdUnitServiceClient.GetAdUnit</c> and <c>AdUnitServiceClient.GetAdUnitAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAdUnitSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdUnitServiceClient.ListAdUnits</c> and <c>AdUnitServiceClient.ListAdUnitsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAdUnitsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdUnitServiceClient.ListAdUnitSizes</c> and <c>AdUnitServiceClient.ListAdUnitSizesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAdUnitSizesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AdUnitServiceSettings"/> object.</returns>
        public AdUnitServiceSettings Clone() => new AdUnitServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AdUnitServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class AdUnitServiceClientBuilder : gaxgrpc::ClientBuilderBase<AdUnitServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AdUnitServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AdUnitServiceClientBuilder() : base(AdUnitServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AdUnitServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AdUnitServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AdUnitServiceClient Build()
        {
            AdUnitServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AdUnitServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AdUnitServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AdUnitServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AdUnitServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AdUnitServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AdUnitServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AdUnitServiceClient.ChannelPool;
    }

    /// <summary>AdUnitService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling AdUnit objects.
    /// </remarks>
    public abstract partial class AdUnitServiceClient
    {
        /// <summary>
        /// The default endpoint for the AdUnitService service, which is a host of "admanager.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default AdUnitService scopes.</summary>
        /// <remarks>
        /// The default AdUnitService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/admanager</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admanager",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AdUnitService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AdUnitServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AdUnitServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AdUnitServiceClient"/>.</returns>
        public static stt::Task<AdUnitServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AdUnitServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AdUnitServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AdUnitServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AdUnitServiceClient"/>.</returns>
        public static AdUnitServiceClient Create() => new AdUnitServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AdUnitServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AdUnitServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AdUnitServiceClient"/>.</returns>
        internal static AdUnitServiceClient Create(grpccore::CallInvoker callInvoker, AdUnitServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AdUnitService.AdUnitServiceClient grpcClient = new AdUnitService.AdUnitServiceClient(callInvoker);
            return new AdUnitServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AdUnitService client</summary>
        public virtual AdUnitService.AdUnitServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve an AdUnit object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AdUnit GetAdUnit(GetAdUnitRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve an AdUnit object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdUnit> GetAdUnitAsync(GetAdUnitRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve an AdUnit object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdUnit> GetAdUnitAsync(GetAdUnitRequest request, st::CancellationToken cancellationToken) =>
            GetAdUnitAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve an AdUnit object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AdUnit.
        /// Format: `networks/{network_code}/adUnits/{ad_unit_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AdUnit GetAdUnit(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAdUnit(new GetAdUnitRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve an AdUnit object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AdUnit.
        /// Format: `networks/{network_code}/adUnits/{ad_unit_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdUnit> GetAdUnitAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAdUnitAsync(new GetAdUnitRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve an AdUnit object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AdUnit.
        /// Format: `networks/{network_code}/adUnits/{ad_unit_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdUnit> GetAdUnitAsync(string name, st::CancellationToken cancellationToken) =>
            GetAdUnitAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve an AdUnit object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AdUnit.
        /// Format: `networks/{network_code}/adUnits/{ad_unit_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AdUnit GetAdUnit(AdUnitName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAdUnit(new GetAdUnitRequest
            {
                AdUnitName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve an AdUnit object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AdUnit.
        /// Format: `networks/{network_code}/adUnits/{ad_unit_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdUnit> GetAdUnitAsync(AdUnitName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAdUnitAsync(new GetAdUnitRequest
            {
                AdUnitName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve an AdUnit object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AdUnit.
        /// Format: `networks/{network_code}/adUnits/{ad_unit_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdUnit> GetAdUnitAsync(AdUnitName name, st::CancellationToken cancellationToken) =>
            GetAdUnitAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a list of AdUnit objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AdUnit"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAdUnitsResponse, AdUnit> ListAdUnits(ListAdUnitsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of AdUnit objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AdUnit"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAdUnitsResponse, AdUnit> ListAdUnitsAsync(ListAdUnitsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of AdUnit objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of AdUnits.
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
        /// <returns>A pageable sequence of <see cref="AdUnit"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAdUnitsResponse, AdUnit> ListAdUnits(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAdUnitsRequest request = new ListAdUnitsRequest
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
            return ListAdUnits(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of AdUnit objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of AdUnits.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AdUnit"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAdUnitsResponse, AdUnit> ListAdUnitsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAdUnitsRequest request = new ListAdUnitsRequest
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
            return ListAdUnitsAsync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of AdUnit objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of AdUnits.
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
        /// <returns>A pageable sequence of <see cref="AdUnit"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAdUnitsResponse, AdUnit> ListAdUnits(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAdUnitsRequest request = new ListAdUnitsRequest
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
            return ListAdUnits(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of AdUnit objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of AdUnits.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AdUnit"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAdUnitsResponse, AdUnit> ListAdUnitsAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAdUnitsRequest request = new ListAdUnitsRequest
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
            return ListAdUnitsAsync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of AdUnitSize objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AdUnitSize"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAdUnitSizesResponse, AdUnitSize> ListAdUnitSizes(ListAdUnitSizesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of AdUnitSize objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AdUnitSize"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAdUnitSizesResponse, AdUnitSize> ListAdUnitSizesAsync(ListAdUnitSizesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of AdUnitSize objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of AdUnitSizes.
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
        /// <returns>A pageable sequence of <see cref="AdUnitSize"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAdUnitSizesResponse, AdUnitSize> ListAdUnitSizes(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAdUnitSizesRequest request = new ListAdUnitSizesRequest
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
            return ListAdUnitSizes(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of AdUnitSize objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of AdUnitSizes.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AdUnitSize"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAdUnitSizesResponse, AdUnitSize> ListAdUnitSizesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAdUnitSizesRequest request = new ListAdUnitSizesRequest
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
            return ListAdUnitSizesAsync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of AdUnitSize objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of AdUnitSizes.
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
        /// <returns>A pageable sequence of <see cref="AdUnitSize"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAdUnitSizesResponse, AdUnitSize> ListAdUnitSizes(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAdUnitSizesRequest request = new ListAdUnitSizesRequest
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
            return ListAdUnitSizes(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of AdUnitSize objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of AdUnitSizes.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AdUnitSize"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAdUnitSizesResponse, AdUnitSize> ListAdUnitSizesAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAdUnitSizesRequest request = new ListAdUnitSizesRequest
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
            return ListAdUnitSizesAsync(request, callSettings);
        }
    }

    /// <summary>AdUnitService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling AdUnit objects.
    /// </remarks>
    public sealed partial class AdUnitServiceClientImpl : AdUnitServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetAdUnitRequest, AdUnit> _callGetAdUnit;

        private readonly gaxgrpc::ApiCall<ListAdUnitsRequest, ListAdUnitsResponse> _callListAdUnits;

        private readonly gaxgrpc::ApiCall<ListAdUnitSizesRequest, ListAdUnitSizesResponse> _callListAdUnitSizes;

        /// <summary>
        /// Constructs a client wrapper for the AdUnitService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AdUnitServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AdUnitServiceClientImpl(AdUnitService.AdUnitServiceClient grpcClient, AdUnitServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AdUnitServiceSettings effectiveSettings = settings ?? AdUnitServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetAdUnit = clientHelper.BuildApiCall<GetAdUnitRequest, AdUnit>("GetAdUnit", grpcClient.GetAdUnitAsync, grpcClient.GetAdUnit, effectiveSettings.GetAdUnitSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAdUnit);
            Modify_GetAdUnitApiCall(ref _callGetAdUnit);
            _callListAdUnits = clientHelper.BuildApiCall<ListAdUnitsRequest, ListAdUnitsResponse>("ListAdUnits", grpcClient.ListAdUnitsAsync, grpcClient.ListAdUnits, effectiveSettings.ListAdUnitsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAdUnits);
            Modify_ListAdUnitsApiCall(ref _callListAdUnits);
            _callListAdUnitSizes = clientHelper.BuildApiCall<ListAdUnitSizesRequest, ListAdUnitSizesResponse>("ListAdUnitSizes", grpcClient.ListAdUnitSizesAsync, grpcClient.ListAdUnitSizes, effectiveSettings.ListAdUnitSizesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAdUnitSizes);
            Modify_ListAdUnitSizesApiCall(ref _callListAdUnitSizes);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetAdUnitApiCall(ref gaxgrpc::ApiCall<GetAdUnitRequest, AdUnit> call);

        partial void Modify_ListAdUnitsApiCall(ref gaxgrpc::ApiCall<ListAdUnitsRequest, ListAdUnitsResponse> call);

        partial void Modify_ListAdUnitSizesApiCall(ref gaxgrpc::ApiCall<ListAdUnitSizesRequest, ListAdUnitSizesResponse> call);

        partial void OnConstruction(AdUnitService.AdUnitServiceClient grpcClient, AdUnitServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AdUnitService client</summary>
        public override AdUnitService.AdUnitServiceClient GrpcClient { get; }

        partial void Modify_GetAdUnitRequest(ref GetAdUnitRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAdUnitsRequest(ref ListAdUnitsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAdUnitSizesRequest(ref ListAdUnitSizesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// API to retrieve an AdUnit object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AdUnit GetAdUnit(GetAdUnitRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAdUnitRequest(ref request, ref callSettings);
            return _callGetAdUnit.Sync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve an AdUnit object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AdUnit> GetAdUnitAsync(GetAdUnitRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAdUnitRequest(ref request, ref callSettings);
            return _callGetAdUnit.Async(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of AdUnit objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AdUnit"/> resources.</returns>
        public override gax::PagedEnumerable<ListAdUnitsResponse, AdUnit> ListAdUnits(ListAdUnitsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAdUnitsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAdUnitsRequest, ListAdUnitsResponse, AdUnit>(_callListAdUnits, request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of AdUnit objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AdUnit"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAdUnitsResponse, AdUnit> ListAdUnitsAsync(ListAdUnitsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAdUnitsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAdUnitsRequest, ListAdUnitsResponse, AdUnit>(_callListAdUnits, request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of AdUnitSize objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AdUnitSize"/> resources.</returns>
        public override gax::PagedEnumerable<ListAdUnitSizesResponse, AdUnitSize> ListAdUnitSizes(ListAdUnitSizesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAdUnitSizesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAdUnitSizesRequest, ListAdUnitSizesResponse, AdUnitSize>(_callListAdUnitSizes, request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of AdUnitSize objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AdUnitSize"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAdUnitSizesResponse, AdUnitSize> ListAdUnitSizesAsync(ListAdUnitSizesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAdUnitSizesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAdUnitSizesRequest, ListAdUnitSizesResponse, AdUnitSize>(_callListAdUnitSizes, request, callSettings);
        }
    }

    public partial class ListAdUnitsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAdUnitSizesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAdUnitsResponse : gaxgrpc::IPageResponse<AdUnit>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AdUnit> GetEnumerator() => AdUnits.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAdUnitSizesResponse : gaxgrpc::IPageResponse<AdUnitSize>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AdUnitSize> GetEnumerator() => AdUnitSizes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
