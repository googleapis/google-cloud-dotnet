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
    /// <summary>Settings for <see cref="TaxonomyCategoryServiceClient"/> instances.</summary>
    public sealed partial class TaxonomyCategoryServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="TaxonomyCategoryServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="TaxonomyCategoryServiceSettings"/>.</returns>
        public static TaxonomyCategoryServiceSettings GetDefault() => new TaxonomyCategoryServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="TaxonomyCategoryServiceSettings"/> object with default settings.
        /// </summary>
        public TaxonomyCategoryServiceSettings()
        {
        }

        private TaxonomyCategoryServiceSettings(TaxonomyCategoryServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetTaxonomyCategorySettings = existing.GetTaxonomyCategorySettings;
            ListTaxonomyCategoriesSettings = existing.ListTaxonomyCategoriesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(TaxonomyCategoryServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TaxonomyCategoryServiceClient.GetTaxonomyCategory</c> and
        /// <c>TaxonomyCategoryServiceClient.GetTaxonomyCategoryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTaxonomyCategorySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TaxonomyCategoryServiceClient.ListTaxonomyCategories</c> and
        /// <c>TaxonomyCategoryServiceClient.ListTaxonomyCategoriesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTaxonomyCategoriesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="TaxonomyCategoryServiceSettings"/> object.</returns>
        public TaxonomyCategoryServiceSettings Clone() => new TaxonomyCategoryServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="TaxonomyCategoryServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class TaxonomyCategoryServiceClientBuilder : gaxgrpc::ClientBuilderBase<TaxonomyCategoryServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public TaxonomyCategoryServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public TaxonomyCategoryServiceClientBuilder() : base(TaxonomyCategoryServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref TaxonomyCategoryServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<TaxonomyCategoryServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override TaxonomyCategoryServiceClient Build()
        {
            TaxonomyCategoryServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<TaxonomyCategoryServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<TaxonomyCategoryServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private TaxonomyCategoryServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return TaxonomyCategoryServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<TaxonomyCategoryServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return TaxonomyCategoryServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => TaxonomyCategoryServiceClient.ChannelPool;
    }

    /// <summary>TaxonomyCategoryService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `TaxonomyCategory` objects.
    /// </remarks>
    public abstract partial class TaxonomyCategoryServiceClient
    {
        /// <summary>
        /// The default endpoint for the TaxonomyCategoryService service, which is a host of "admanager.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default TaxonomyCategoryService scopes.</summary>
        /// <remarks>The default TaxonomyCategoryService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(TaxonomyCategoryService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="TaxonomyCategoryServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="TaxonomyCategoryServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="TaxonomyCategoryServiceClient"/>.</returns>
        public static stt::Task<TaxonomyCategoryServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new TaxonomyCategoryServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="TaxonomyCategoryServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="TaxonomyCategoryServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="TaxonomyCategoryServiceClient"/>.</returns>
        public static TaxonomyCategoryServiceClient Create() => new TaxonomyCategoryServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="TaxonomyCategoryServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="TaxonomyCategoryServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="TaxonomyCategoryServiceClient"/>.</returns>
        internal static TaxonomyCategoryServiceClient Create(grpccore::CallInvoker callInvoker, TaxonomyCategoryServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            TaxonomyCategoryService.TaxonomyCategoryServiceClient grpcClient = new TaxonomyCategoryService.TaxonomyCategoryServiceClient(callInvoker);
            return new TaxonomyCategoryServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC TaxonomyCategoryService client</summary>
        public virtual TaxonomyCategoryService.TaxonomyCategoryServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `TaxonomyCategory` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TaxonomyCategory GetTaxonomyCategory(GetTaxonomyCategoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `TaxonomyCategory` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TaxonomyCategory> GetTaxonomyCategoryAsync(GetTaxonomyCategoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `TaxonomyCategory` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TaxonomyCategory> GetTaxonomyCategoryAsync(GetTaxonomyCategoryRequest request, st::CancellationToken cancellationToken) =>
            GetTaxonomyCategoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `TaxonomyCategory` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the TaxonomyCategory.
        /// Format: `networks/{network_code}/taxonomyCategories/{taxonomy_category_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TaxonomyCategory GetTaxonomyCategory(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTaxonomyCategory(new GetTaxonomyCategoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `TaxonomyCategory` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the TaxonomyCategory.
        /// Format: `networks/{network_code}/taxonomyCategories/{taxonomy_category_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TaxonomyCategory> GetTaxonomyCategoryAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTaxonomyCategoryAsync(new GetTaxonomyCategoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `TaxonomyCategory` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the TaxonomyCategory.
        /// Format: `networks/{network_code}/taxonomyCategories/{taxonomy_category_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TaxonomyCategory> GetTaxonomyCategoryAsync(string name, st::CancellationToken cancellationToken) =>
            GetTaxonomyCategoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `TaxonomyCategory` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the TaxonomyCategory.
        /// Format: `networks/{network_code}/taxonomyCategories/{taxonomy_category_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TaxonomyCategory GetTaxonomyCategory(TaxonomyCategoryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTaxonomyCategory(new GetTaxonomyCategoryRequest
            {
                TaxonomyCategoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `TaxonomyCategory` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the TaxonomyCategory.
        /// Format: `networks/{network_code}/taxonomyCategories/{taxonomy_category_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TaxonomyCategory> GetTaxonomyCategoryAsync(TaxonomyCategoryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTaxonomyCategoryAsync(new GetTaxonomyCategoryRequest
            {
                TaxonomyCategoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `TaxonomyCategory` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the TaxonomyCategory.
        /// Format: `networks/{network_code}/taxonomyCategories/{taxonomy_category_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TaxonomyCategory> GetTaxonomyCategoryAsync(TaxonomyCategoryName name, st::CancellationToken cancellationToken) =>
            GetTaxonomyCategoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a list of `TaxonomyCategory` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TaxonomyCategory"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTaxonomyCategoriesResponse, TaxonomyCategory> ListTaxonomyCategories(ListTaxonomyCategoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `TaxonomyCategory` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TaxonomyCategory"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTaxonomyCategoriesResponse, TaxonomyCategory> ListTaxonomyCategoriesAsync(ListTaxonomyCategoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `TaxonomyCategory` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of TaxonomyCategories.
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
        /// <returns>A pageable sequence of <see cref="TaxonomyCategory"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTaxonomyCategoriesResponse, TaxonomyCategory> ListTaxonomyCategories(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTaxonomyCategoriesRequest request = new ListTaxonomyCategoriesRequest
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
            return ListTaxonomyCategories(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `TaxonomyCategory` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of TaxonomyCategories.
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
        /// <returns>A pageable asynchronous sequence of <see cref="TaxonomyCategory"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTaxonomyCategoriesResponse, TaxonomyCategory> ListTaxonomyCategoriesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTaxonomyCategoriesRequest request = new ListTaxonomyCategoriesRequest
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
            return ListTaxonomyCategoriesAsync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `TaxonomyCategory` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of TaxonomyCategories.
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
        /// <returns>A pageable sequence of <see cref="TaxonomyCategory"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTaxonomyCategoriesResponse, TaxonomyCategory> ListTaxonomyCategories(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTaxonomyCategoriesRequest request = new ListTaxonomyCategoriesRequest
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
            return ListTaxonomyCategories(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `TaxonomyCategory` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of TaxonomyCategories.
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
        /// <returns>A pageable asynchronous sequence of <see cref="TaxonomyCategory"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTaxonomyCategoriesResponse, TaxonomyCategory> ListTaxonomyCategoriesAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTaxonomyCategoriesRequest request = new ListTaxonomyCategoriesRequest
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
            return ListTaxonomyCategoriesAsync(request, callSettings);
        }
    }

    /// <summary>TaxonomyCategoryService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `TaxonomyCategory` objects.
    /// </remarks>
    public sealed partial class TaxonomyCategoryServiceClientImpl : TaxonomyCategoryServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetTaxonomyCategoryRequest, TaxonomyCategory> _callGetTaxonomyCategory;

        private readonly gaxgrpc::ApiCall<ListTaxonomyCategoriesRequest, ListTaxonomyCategoriesResponse> _callListTaxonomyCategories;

        /// <summary>
        /// Constructs a client wrapper for the TaxonomyCategoryService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="TaxonomyCategoryServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public TaxonomyCategoryServiceClientImpl(TaxonomyCategoryService.TaxonomyCategoryServiceClient grpcClient, TaxonomyCategoryServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            TaxonomyCategoryServiceSettings effectiveSettings = settings ?? TaxonomyCategoryServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetTaxonomyCategory = clientHelper.BuildApiCall<GetTaxonomyCategoryRequest, TaxonomyCategory>("GetTaxonomyCategory", grpcClient.GetTaxonomyCategoryAsync, grpcClient.GetTaxonomyCategory, effectiveSettings.GetTaxonomyCategorySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTaxonomyCategory);
            Modify_GetTaxonomyCategoryApiCall(ref _callGetTaxonomyCategory);
            _callListTaxonomyCategories = clientHelper.BuildApiCall<ListTaxonomyCategoriesRequest, ListTaxonomyCategoriesResponse>("ListTaxonomyCategories", grpcClient.ListTaxonomyCategoriesAsync, grpcClient.ListTaxonomyCategories, effectiveSettings.ListTaxonomyCategoriesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTaxonomyCategories);
            Modify_ListTaxonomyCategoriesApiCall(ref _callListTaxonomyCategories);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetTaxonomyCategoryApiCall(ref gaxgrpc::ApiCall<GetTaxonomyCategoryRequest, TaxonomyCategory> call);

        partial void Modify_ListTaxonomyCategoriesApiCall(ref gaxgrpc::ApiCall<ListTaxonomyCategoriesRequest, ListTaxonomyCategoriesResponse> call);

        partial void OnConstruction(TaxonomyCategoryService.TaxonomyCategoryServiceClient grpcClient, TaxonomyCategoryServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC TaxonomyCategoryService client</summary>
        public override TaxonomyCategoryService.TaxonomyCategoryServiceClient GrpcClient { get; }

        partial void Modify_GetTaxonomyCategoryRequest(ref GetTaxonomyCategoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTaxonomyCategoriesRequest(ref ListTaxonomyCategoriesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// API to retrieve a `TaxonomyCategory` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TaxonomyCategory GetTaxonomyCategory(GetTaxonomyCategoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTaxonomyCategoryRequest(ref request, ref callSettings);
            return _callGetTaxonomyCategory.Sync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a `TaxonomyCategory` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TaxonomyCategory> GetTaxonomyCategoryAsync(GetTaxonomyCategoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTaxonomyCategoryRequest(ref request, ref callSettings);
            return _callGetTaxonomyCategory.Async(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `TaxonomyCategory` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TaxonomyCategory"/> resources.</returns>
        public override gax::PagedEnumerable<ListTaxonomyCategoriesResponse, TaxonomyCategory> ListTaxonomyCategories(ListTaxonomyCategoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTaxonomyCategoriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTaxonomyCategoriesRequest, ListTaxonomyCategoriesResponse, TaxonomyCategory>(_callListTaxonomyCategories, request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `TaxonomyCategory` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TaxonomyCategory"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTaxonomyCategoriesResponse, TaxonomyCategory> ListTaxonomyCategoriesAsync(ListTaxonomyCategoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTaxonomyCategoriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTaxonomyCategoriesRequest, ListTaxonomyCategoriesResponse, TaxonomyCategory>(_callListTaxonomyCategories, request, callSettings);
        }
    }

    public partial class ListTaxonomyCategoriesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTaxonomyCategoriesResponse : gaxgrpc::IPageResponse<TaxonomyCategory>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<TaxonomyCategory> GetEnumerator() => TaxonomyCategories.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
