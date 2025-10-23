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
    /// <summary>Settings for <see cref="BrowserServiceClient"/> instances.</summary>
    public sealed partial class BrowserServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="BrowserServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="BrowserServiceSettings"/>.</returns>
        public static BrowserServiceSettings GetDefault() => new BrowserServiceSettings();

        /// <summary>Constructs a new <see cref="BrowserServiceSettings"/> object with default settings.</summary>
        public BrowserServiceSettings()
        {
        }

        private BrowserServiceSettings(BrowserServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetBrowserSettings = existing.GetBrowserSettings;
            ListBrowsersSettings = existing.ListBrowsersSettings;
            OnCopy(existing);
        }

        partial void OnCopy(BrowserServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BrowserServiceClient.GetBrowser</c> and <c>BrowserServiceClient.GetBrowserAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetBrowserSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BrowserServiceClient.ListBrowsers</c> and <c>BrowserServiceClient.ListBrowsersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListBrowsersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="BrowserServiceSettings"/> object.</returns>
        public BrowserServiceSettings Clone() => new BrowserServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="BrowserServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class BrowserServiceClientBuilder : gaxgrpc::ClientBuilderBase<BrowserServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public BrowserServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public BrowserServiceClientBuilder() : base(BrowserServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref BrowserServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<BrowserServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override BrowserServiceClient Build()
        {
            BrowserServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<BrowserServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<BrowserServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private BrowserServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return BrowserServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<BrowserServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BrowserServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => BrowserServiceClient.ChannelPool;
    }

    /// <summary>BrowserService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `Browser` objects.
    /// </remarks>
    public abstract partial class BrowserServiceClient
    {
        /// <summary>
        /// The default endpoint for the BrowserService service, which is a host of "admanager.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default BrowserService scopes.</summary>
        /// <remarks>
        /// The default BrowserService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/admanager</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admanager",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(BrowserService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="BrowserServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="BrowserServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="BrowserServiceClient"/>.</returns>
        public static stt::Task<BrowserServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new BrowserServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="BrowserServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="BrowserServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="BrowserServiceClient"/>.</returns>
        public static BrowserServiceClient Create() => new BrowserServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="BrowserServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="BrowserServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="BrowserServiceClient"/>.</returns>
        internal static BrowserServiceClient Create(grpccore::CallInvoker callInvoker, BrowserServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            BrowserService.BrowserServiceClient grpcClient = new BrowserService.BrowserServiceClient(callInvoker);
            return new BrowserServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC BrowserService client</summary>
        public virtual BrowserService.BrowserServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `Browser` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Browser GetBrowser(GetBrowserRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `Browser` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Browser> GetBrowserAsync(GetBrowserRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `Browser` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Browser> GetBrowserAsync(GetBrowserRequest request, st::CancellationToken cancellationToken) =>
            GetBrowserAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `Browser` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Browser.
        /// Format: `networks/{network_code}/browsers/{browser_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Browser GetBrowser(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBrowser(new GetBrowserRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `Browser` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Browser.
        /// Format: `networks/{network_code}/browsers/{browser_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Browser> GetBrowserAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBrowserAsync(new GetBrowserRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `Browser` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Browser.
        /// Format: `networks/{network_code}/browsers/{browser_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Browser> GetBrowserAsync(string name, st::CancellationToken cancellationToken) =>
            GetBrowserAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `Browser` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Browser.
        /// Format: `networks/{network_code}/browsers/{browser_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Browser GetBrowser(BrowserName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBrowser(new GetBrowserRequest
            {
                BrowserName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `Browser` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Browser.
        /// Format: `networks/{network_code}/browsers/{browser_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Browser> GetBrowserAsync(BrowserName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBrowserAsync(new GetBrowserRequest
            {
                BrowserName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `Browser` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Browser.
        /// Format: `networks/{network_code}/browsers/{browser_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Browser> GetBrowserAsync(BrowserName name, st::CancellationToken cancellationToken) =>
            GetBrowserAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a list of `Browser` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Browser"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBrowsersResponse, Browser> ListBrowsers(ListBrowsersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `Browser` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Browser"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBrowsersResponse, Browser> ListBrowsersAsync(ListBrowsersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `Browser` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Browsers.
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
        /// <returns>A pageable sequence of <see cref="Browser"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBrowsersResponse, Browser> ListBrowsers(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBrowsersRequest request = new ListBrowsersRequest
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
            return ListBrowsers(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Browser` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Browsers.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Browser"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBrowsersResponse, Browser> ListBrowsersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBrowsersRequest request = new ListBrowsersRequest
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
            return ListBrowsersAsync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Browser` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Browsers.
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
        /// <returns>A pageable sequence of <see cref="Browser"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBrowsersResponse, Browser> ListBrowsers(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBrowsersRequest request = new ListBrowsersRequest
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
            return ListBrowsers(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Browser` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Browsers.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Browser"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBrowsersResponse, Browser> ListBrowsersAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBrowsersRequest request = new ListBrowsersRequest
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
            return ListBrowsersAsync(request, callSettings);
        }
    }

    /// <summary>BrowserService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `Browser` objects.
    /// </remarks>
    public sealed partial class BrowserServiceClientImpl : BrowserServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetBrowserRequest, Browser> _callGetBrowser;

        private readonly gaxgrpc::ApiCall<ListBrowsersRequest, ListBrowsersResponse> _callListBrowsers;

        /// <summary>
        /// Constructs a client wrapper for the BrowserService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="BrowserServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public BrowserServiceClientImpl(BrowserService.BrowserServiceClient grpcClient, BrowserServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            BrowserServiceSettings effectiveSettings = settings ?? BrowserServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetBrowser = clientHelper.BuildApiCall<GetBrowserRequest, Browser>("GetBrowser", grpcClient.GetBrowserAsync, grpcClient.GetBrowser, effectiveSettings.GetBrowserSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetBrowser);
            Modify_GetBrowserApiCall(ref _callGetBrowser);
            _callListBrowsers = clientHelper.BuildApiCall<ListBrowsersRequest, ListBrowsersResponse>("ListBrowsers", grpcClient.ListBrowsersAsync, grpcClient.ListBrowsers, effectiveSettings.ListBrowsersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListBrowsers);
            Modify_ListBrowsersApiCall(ref _callListBrowsers);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetBrowserApiCall(ref gaxgrpc::ApiCall<GetBrowserRequest, Browser> call);

        partial void Modify_ListBrowsersApiCall(ref gaxgrpc::ApiCall<ListBrowsersRequest, ListBrowsersResponse> call);

        partial void OnConstruction(BrowserService.BrowserServiceClient grpcClient, BrowserServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC BrowserService client</summary>
        public override BrowserService.BrowserServiceClient GrpcClient { get; }

        partial void Modify_GetBrowserRequest(ref GetBrowserRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBrowsersRequest(ref ListBrowsersRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// API to retrieve a `Browser` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Browser GetBrowser(GetBrowserRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBrowserRequest(ref request, ref callSettings);
            return _callGetBrowser.Sync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a `Browser` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Browser> GetBrowserAsync(GetBrowserRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBrowserRequest(ref request, ref callSettings);
            return _callGetBrowser.Async(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Browser` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Browser"/> resources.</returns>
        public override gax::PagedEnumerable<ListBrowsersResponse, Browser> ListBrowsers(ListBrowsersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBrowsersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListBrowsersRequest, ListBrowsersResponse, Browser>(_callListBrowsers, request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Browser` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Browser"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListBrowsersResponse, Browser> ListBrowsersAsync(ListBrowsersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBrowsersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListBrowsersRequest, ListBrowsersResponse, Browser>(_callListBrowsers, request, callSettings);
        }
    }

    public partial class ListBrowsersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBrowsersResponse : gaxgrpc::IPageResponse<Browser>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Browser> GetEnumerator() => Browsers.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
