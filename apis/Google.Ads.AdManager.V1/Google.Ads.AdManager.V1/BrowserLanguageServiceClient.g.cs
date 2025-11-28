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
    /// <summary>Settings for <see cref="BrowserLanguageServiceClient"/> instances.</summary>
    public sealed partial class BrowserLanguageServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="BrowserLanguageServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="BrowserLanguageServiceSettings"/>.</returns>
        public static BrowserLanguageServiceSettings GetDefault() => new BrowserLanguageServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="BrowserLanguageServiceSettings"/> object with default settings.
        /// </summary>
        public BrowserLanguageServiceSettings()
        {
        }

        private BrowserLanguageServiceSettings(BrowserLanguageServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetBrowserLanguageSettings = existing.GetBrowserLanguageSettings;
            ListBrowserLanguagesSettings = existing.ListBrowserLanguagesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(BrowserLanguageServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BrowserLanguageServiceClient.GetBrowserLanguage</c> and
        /// <c>BrowserLanguageServiceClient.GetBrowserLanguageAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetBrowserLanguageSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BrowserLanguageServiceClient.ListBrowserLanguages</c> and
        /// <c>BrowserLanguageServiceClient.ListBrowserLanguagesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListBrowserLanguagesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="BrowserLanguageServiceSettings"/> object.</returns>
        public BrowserLanguageServiceSettings Clone() => new BrowserLanguageServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="BrowserLanguageServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class BrowserLanguageServiceClientBuilder : gaxgrpc::ClientBuilderBase<BrowserLanguageServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public BrowserLanguageServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public BrowserLanguageServiceClientBuilder() : base(BrowserLanguageServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref BrowserLanguageServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<BrowserLanguageServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override BrowserLanguageServiceClient Build()
        {
            BrowserLanguageServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<BrowserLanguageServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<BrowserLanguageServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private BrowserLanguageServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return BrowserLanguageServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<BrowserLanguageServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BrowserLanguageServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => BrowserLanguageServiceClient.ChannelPool;
    }

    /// <summary>BrowserLanguageService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `BrowserLanguage` objects.
    /// </remarks>
    public abstract partial class BrowserLanguageServiceClient
    {
        /// <summary>
        /// The default endpoint for the BrowserLanguageService service, which is a host of "admanager.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default BrowserLanguageService scopes.</summary>
        /// <remarks>
        /// The default BrowserLanguageService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/admanager</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admanager",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(BrowserLanguageService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="BrowserLanguageServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="BrowserLanguageServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="BrowserLanguageServiceClient"/>.</returns>
        public static stt::Task<BrowserLanguageServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new BrowserLanguageServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="BrowserLanguageServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="BrowserLanguageServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="BrowserLanguageServiceClient"/>.</returns>
        public static BrowserLanguageServiceClient Create() => new BrowserLanguageServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="BrowserLanguageServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="BrowserLanguageServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="BrowserLanguageServiceClient"/>.</returns>
        internal static BrowserLanguageServiceClient Create(grpccore::CallInvoker callInvoker, BrowserLanguageServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            BrowserLanguageService.BrowserLanguageServiceClient grpcClient = new BrowserLanguageService.BrowserLanguageServiceClient(callInvoker);
            return new BrowserLanguageServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC BrowserLanguageService client</summary>
        public virtual BrowserLanguageService.BrowserLanguageServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `BrowserLanguage` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BrowserLanguage GetBrowserLanguage(GetBrowserLanguageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `BrowserLanguage` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BrowserLanguage> GetBrowserLanguageAsync(GetBrowserLanguageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `BrowserLanguage` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BrowserLanguage> GetBrowserLanguageAsync(GetBrowserLanguageRequest request, st::CancellationToken cancellationToken) =>
            GetBrowserLanguageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `BrowserLanguage` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the BrowserLanguage.
        /// Format: `networks/{network_code}/browserLanguages/{browser_language_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BrowserLanguage GetBrowserLanguage(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBrowserLanguage(new GetBrowserLanguageRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `BrowserLanguage` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the BrowserLanguage.
        /// Format: `networks/{network_code}/browserLanguages/{browser_language_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BrowserLanguage> GetBrowserLanguageAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBrowserLanguageAsync(new GetBrowserLanguageRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `BrowserLanguage` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the BrowserLanguage.
        /// Format: `networks/{network_code}/browserLanguages/{browser_language_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BrowserLanguage> GetBrowserLanguageAsync(string name, st::CancellationToken cancellationToken) =>
            GetBrowserLanguageAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `BrowserLanguage` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the BrowserLanguage.
        /// Format: `networks/{network_code}/browserLanguages/{browser_language_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BrowserLanguage GetBrowserLanguage(BrowserLanguageName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBrowserLanguage(new GetBrowserLanguageRequest
            {
                BrowserLanguageName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `BrowserLanguage` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the BrowserLanguage.
        /// Format: `networks/{network_code}/browserLanguages/{browser_language_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BrowserLanguage> GetBrowserLanguageAsync(BrowserLanguageName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBrowserLanguageAsync(new GetBrowserLanguageRequest
            {
                BrowserLanguageName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `BrowserLanguage` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the BrowserLanguage.
        /// Format: `networks/{network_code}/browserLanguages/{browser_language_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BrowserLanguage> GetBrowserLanguageAsync(BrowserLanguageName name, st::CancellationToken cancellationToken) =>
            GetBrowserLanguageAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a list of `BrowserLanguage` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BrowserLanguage"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBrowserLanguagesResponse, BrowserLanguage> ListBrowserLanguages(ListBrowserLanguagesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `BrowserLanguage` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BrowserLanguage"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBrowserLanguagesResponse, BrowserLanguage> ListBrowserLanguagesAsync(ListBrowserLanguagesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `BrowserLanguage` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of BrowserLanguages.
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
        /// <returns>A pageable sequence of <see cref="BrowserLanguage"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBrowserLanguagesResponse, BrowserLanguage> ListBrowserLanguages(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBrowserLanguagesRequest request = new ListBrowserLanguagesRequest
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
            return ListBrowserLanguages(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `BrowserLanguage` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of BrowserLanguages.
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
        /// <returns>A pageable asynchronous sequence of <see cref="BrowserLanguage"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBrowserLanguagesResponse, BrowserLanguage> ListBrowserLanguagesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBrowserLanguagesRequest request = new ListBrowserLanguagesRequest
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
            return ListBrowserLanguagesAsync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `BrowserLanguage` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of BrowserLanguages.
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
        /// <returns>A pageable sequence of <see cref="BrowserLanguage"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBrowserLanguagesResponse, BrowserLanguage> ListBrowserLanguages(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBrowserLanguagesRequest request = new ListBrowserLanguagesRequest
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
            return ListBrowserLanguages(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `BrowserLanguage` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of BrowserLanguages.
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
        /// <returns>A pageable asynchronous sequence of <see cref="BrowserLanguage"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBrowserLanguagesResponse, BrowserLanguage> ListBrowserLanguagesAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBrowserLanguagesRequest request = new ListBrowserLanguagesRequest
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
            return ListBrowserLanguagesAsync(request, callSettings);
        }
    }

    /// <summary>BrowserLanguageService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `BrowserLanguage` objects.
    /// </remarks>
    public sealed partial class BrowserLanguageServiceClientImpl : BrowserLanguageServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetBrowserLanguageRequest, BrowserLanguage> _callGetBrowserLanguage;

        private readonly gaxgrpc::ApiCall<ListBrowserLanguagesRequest, ListBrowserLanguagesResponse> _callListBrowserLanguages;

        /// <summary>
        /// Constructs a client wrapper for the BrowserLanguageService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="BrowserLanguageServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public BrowserLanguageServiceClientImpl(BrowserLanguageService.BrowserLanguageServiceClient grpcClient, BrowserLanguageServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            BrowserLanguageServiceSettings effectiveSettings = settings ?? BrowserLanguageServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetBrowserLanguage = clientHelper.BuildApiCall<GetBrowserLanguageRequest, BrowserLanguage>("GetBrowserLanguage", grpcClient.GetBrowserLanguageAsync, grpcClient.GetBrowserLanguage, effectiveSettings.GetBrowserLanguageSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetBrowserLanguage);
            Modify_GetBrowserLanguageApiCall(ref _callGetBrowserLanguage);
            _callListBrowserLanguages = clientHelper.BuildApiCall<ListBrowserLanguagesRequest, ListBrowserLanguagesResponse>("ListBrowserLanguages", grpcClient.ListBrowserLanguagesAsync, grpcClient.ListBrowserLanguages, effectiveSettings.ListBrowserLanguagesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListBrowserLanguages);
            Modify_ListBrowserLanguagesApiCall(ref _callListBrowserLanguages);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetBrowserLanguageApiCall(ref gaxgrpc::ApiCall<GetBrowserLanguageRequest, BrowserLanguage> call);

        partial void Modify_ListBrowserLanguagesApiCall(ref gaxgrpc::ApiCall<ListBrowserLanguagesRequest, ListBrowserLanguagesResponse> call);

        partial void OnConstruction(BrowserLanguageService.BrowserLanguageServiceClient grpcClient, BrowserLanguageServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC BrowserLanguageService client</summary>
        public override BrowserLanguageService.BrowserLanguageServiceClient GrpcClient { get; }

        partial void Modify_GetBrowserLanguageRequest(ref GetBrowserLanguageRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBrowserLanguagesRequest(ref ListBrowserLanguagesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// API to retrieve a `BrowserLanguage` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BrowserLanguage GetBrowserLanguage(GetBrowserLanguageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBrowserLanguageRequest(ref request, ref callSettings);
            return _callGetBrowserLanguage.Sync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a `BrowserLanguage` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BrowserLanguage> GetBrowserLanguageAsync(GetBrowserLanguageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBrowserLanguageRequest(ref request, ref callSettings);
            return _callGetBrowserLanguage.Async(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `BrowserLanguage` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BrowserLanguage"/> resources.</returns>
        public override gax::PagedEnumerable<ListBrowserLanguagesResponse, BrowserLanguage> ListBrowserLanguages(ListBrowserLanguagesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBrowserLanguagesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListBrowserLanguagesRequest, ListBrowserLanguagesResponse, BrowserLanguage>(_callListBrowserLanguages, request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `BrowserLanguage` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BrowserLanguage"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListBrowserLanguagesResponse, BrowserLanguage> ListBrowserLanguagesAsync(ListBrowserLanguagesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBrowserLanguagesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListBrowserLanguagesRequest, ListBrowserLanguagesResponse, BrowserLanguage>(_callListBrowserLanguages, request, callSettings);
        }
    }

    public partial class ListBrowserLanguagesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBrowserLanguagesResponse : gaxgrpc::IPageResponse<BrowserLanguage>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<BrowserLanguage> GetEnumerator() => BrowserLanguages.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
