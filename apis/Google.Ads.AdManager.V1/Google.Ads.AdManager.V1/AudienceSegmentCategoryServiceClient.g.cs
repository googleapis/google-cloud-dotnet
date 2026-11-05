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
    /// <summary>Settings for <see cref="AudienceSegmentCategoryServiceClient"/> instances.</summary>
    public sealed partial class AudienceSegmentCategoryServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AudienceSegmentCategoryServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AudienceSegmentCategoryServiceSettings"/>.</returns>
        public static AudienceSegmentCategoryServiceSettings GetDefault() => new AudienceSegmentCategoryServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="AudienceSegmentCategoryServiceSettings"/> object with default settings.
        /// </summary>
        public AudienceSegmentCategoryServiceSettings()
        {
        }

        private AudienceSegmentCategoryServiceSettings(AudienceSegmentCategoryServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetAudienceSegmentCategorySettings = existing.GetAudienceSegmentCategorySettings;
            ListAudienceSegmentCategoriesSettings = existing.ListAudienceSegmentCategoriesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AudienceSegmentCategoryServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AudienceSegmentCategoryServiceClient.GetAudienceSegmentCategory</c> and
        /// <c>AudienceSegmentCategoryServiceClient.GetAudienceSegmentCategoryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAudienceSegmentCategorySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AudienceSegmentCategoryServiceClient.ListAudienceSegmentCategories</c> and
        /// <c>AudienceSegmentCategoryServiceClient.ListAudienceSegmentCategoriesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAudienceSegmentCategoriesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AudienceSegmentCategoryServiceSettings"/> object.</returns>
        public AudienceSegmentCategoryServiceSettings Clone() => new AudienceSegmentCategoryServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AudienceSegmentCategoryServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class AudienceSegmentCategoryServiceClientBuilder : gaxgrpc::ClientBuilderBase<AudienceSegmentCategoryServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AudienceSegmentCategoryServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AudienceSegmentCategoryServiceClientBuilder() : base(AudienceSegmentCategoryServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AudienceSegmentCategoryServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AudienceSegmentCategoryServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AudienceSegmentCategoryServiceClient Build()
        {
            AudienceSegmentCategoryServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AudienceSegmentCategoryServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AudienceSegmentCategoryServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AudienceSegmentCategoryServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AudienceSegmentCategoryServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AudienceSegmentCategoryServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AudienceSegmentCategoryServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AudienceSegmentCategoryServiceClient.ChannelPool;
    }

    /// <summary>AudienceSegmentCategoryService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `AudienceSegmentCategory` objects.
    /// </remarks>
    public abstract partial class AudienceSegmentCategoryServiceClient
    {
        /// <summary>
        /// The default endpoint for the AudienceSegmentCategoryService service, which is a host of
        /// "admanager.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default AudienceSegmentCategoryService scopes.</summary>
        /// <remarks>
        /// The default AudienceSegmentCategoryService scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AudienceSegmentCategoryService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AudienceSegmentCategoryServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="AudienceSegmentCategoryServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AudienceSegmentCategoryServiceClient"/>.</returns>
        public static stt::Task<AudienceSegmentCategoryServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AudienceSegmentCategoryServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AudienceSegmentCategoryServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="AudienceSegmentCategoryServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AudienceSegmentCategoryServiceClient"/>.</returns>
        public static AudienceSegmentCategoryServiceClient Create() =>
            new AudienceSegmentCategoryServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AudienceSegmentCategoryServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AudienceSegmentCategoryServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AudienceSegmentCategoryServiceClient"/>.</returns>
        internal static AudienceSegmentCategoryServiceClient Create(grpccore::CallInvoker callInvoker, AudienceSegmentCategoryServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AudienceSegmentCategoryService.AudienceSegmentCategoryServiceClient grpcClient = new AudienceSegmentCategoryService.AudienceSegmentCategoryServiceClient(callInvoker);
            return new AudienceSegmentCategoryServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AudienceSegmentCategoryService client</summary>
        public virtual AudienceSegmentCategoryService.AudienceSegmentCategoryServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `AudienceSegmentCategory` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AudienceSegmentCategory GetAudienceSegmentCategory(GetAudienceSegmentCategoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `AudienceSegmentCategory` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AudienceSegmentCategory> GetAudienceSegmentCategoryAsync(GetAudienceSegmentCategoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `AudienceSegmentCategory` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AudienceSegmentCategory> GetAudienceSegmentCategoryAsync(GetAudienceSegmentCategoryRequest request, st::CancellationToken cancellationToken) =>
            GetAudienceSegmentCategoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `AudienceSegmentCategory` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AudienceSegmentCategory.
        /// Format:
        /// `networks/{network_code}/audienceSegmentCategories/{audience_segment_category_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AudienceSegmentCategory GetAudienceSegmentCategory(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAudienceSegmentCategory(new GetAudienceSegmentCategoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `AudienceSegmentCategory` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AudienceSegmentCategory.
        /// Format:
        /// `networks/{network_code}/audienceSegmentCategories/{audience_segment_category_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AudienceSegmentCategory> GetAudienceSegmentCategoryAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAudienceSegmentCategoryAsync(new GetAudienceSegmentCategoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `AudienceSegmentCategory` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AudienceSegmentCategory.
        /// Format:
        /// `networks/{network_code}/audienceSegmentCategories/{audience_segment_category_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AudienceSegmentCategory> GetAudienceSegmentCategoryAsync(string name, st::CancellationToken cancellationToken) =>
            GetAudienceSegmentCategoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `AudienceSegmentCategory` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AudienceSegmentCategory.
        /// Format:
        /// `networks/{network_code}/audienceSegmentCategories/{audience_segment_category_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AudienceSegmentCategory GetAudienceSegmentCategory(AudienceSegmentCategoryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAudienceSegmentCategory(new GetAudienceSegmentCategoryRequest
            {
                AudienceSegmentCategoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `AudienceSegmentCategory` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AudienceSegmentCategory.
        /// Format:
        /// `networks/{network_code}/audienceSegmentCategories/{audience_segment_category_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AudienceSegmentCategory> GetAudienceSegmentCategoryAsync(AudienceSegmentCategoryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAudienceSegmentCategoryAsync(new GetAudienceSegmentCategoryRequest
            {
                AudienceSegmentCategoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `AudienceSegmentCategory` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AudienceSegmentCategory.
        /// Format:
        /// `networks/{network_code}/audienceSegmentCategories/{audience_segment_category_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AudienceSegmentCategory> GetAudienceSegmentCategoryAsync(AudienceSegmentCategoryName name, st::CancellationToken cancellationToken) =>
            GetAudienceSegmentCategoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists `AudienceSegmentCategory` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AudienceSegmentCategory"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAudienceSegmentCategoriesResponse, AudienceSegmentCategory> ListAudienceSegmentCategories(ListAudienceSegmentCategoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `AudienceSegmentCategory` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AudienceSegmentCategory"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAudienceSegmentCategoriesResponse, AudienceSegmentCategory> ListAudienceSegmentCategoriesAsync(ListAudienceSegmentCategoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `AudienceSegmentCategory` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of
        /// AudienceSegmentCategories. Format: `networks/{network_code}`
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
        /// <returns>A pageable sequence of <see cref="AudienceSegmentCategory"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAudienceSegmentCategoriesResponse, AudienceSegmentCategory> ListAudienceSegmentCategories(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAudienceSegmentCategoriesRequest request = new ListAudienceSegmentCategoriesRequest
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
            return ListAudienceSegmentCategories(request, callSettings);
        }

        /// <summary>
        /// Lists `AudienceSegmentCategory` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of
        /// AudienceSegmentCategories. Format: `networks/{network_code}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="AudienceSegmentCategory"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAudienceSegmentCategoriesResponse, AudienceSegmentCategory> ListAudienceSegmentCategoriesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAudienceSegmentCategoriesRequest request = new ListAudienceSegmentCategoriesRequest
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
            return ListAudienceSegmentCategoriesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists `AudienceSegmentCategory` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of
        /// AudienceSegmentCategories. Format: `networks/{network_code}`
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
        /// <returns>A pageable sequence of <see cref="AudienceSegmentCategory"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAudienceSegmentCategoriesResponse, AudienceSegmentCategory> ListAudienceSegmentCategories(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAudienceSegmentCategoriesRequest request = new ListAudienceSegmentCategoriesRequest
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
            return ListAudienceSegmentCategories(request, callSettings);
        }

        /// <summary>
        /// Lists `AudienceSegmentCategory` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of
        /// AudienceSegmentCategories. Format: `networks/{network_code}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="AudienceSegmentCategory"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAudienceSegmentCategoriesResponse, AudienceSegmentCategory> ListAudienceSegmentCategoriesAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAudienceSegmentCategoriesRequest request = new ListAudienceSegmentCategoriesRequest
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
            return ListAudienceSegmentCategoriesAsync(request, callSettings);
        }
    }

    /// <summary>AudienceSegmentCategoryService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `AudienceSegmentCategory` objects.
    /// </remarks>
    public sealed partial class AudienceSegmentCategoryServiceClientImpl : AudienceSegmentCategoryServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetAudienceSegmentCategoryRequest, AudienceSegmentCategory> _callGetAudienceSegmentCategory;

        private readonly gaxgrpc::ApiCall<ListAudienceSegmentCategoriesRequest, ListAudienceSegmentCategoriesResponse> _callListAudienceSegmentCategories;

        /// <summary>
        /// Constructs a client wrapper for the AudienceSegmentCategoryService service, with the specified gRPC client
        /// and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="AudienceSegmentCategoryServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AudienceSegmentCategoryServiceClientImpl(AudienceSegmentCategoryService.AudienceSegmentCategoryServiceClient grpcClient, AudienceSegmentCategoryServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AudienceSegmentCategoryServiceSettings effectiveSettings = settings ?? AudienceSegmentCategoryServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetAudienceSegmentCategory = clientHelper.BuildApiCall<GetAudienceSegmentCategoryRequest, AudienceSegmentCategory>("GetAudienceSegmentCategory", grpcClient.GetAudienceSegmentCategoryAsync, grpcClient.GetAudienceSegmentCategory, effectiveSettings.GetAudienceSegmentCategorySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAudienceSegmentCategory);
            Modify_GetAudienceSegmentCategoryApiCall(ref _callGetAudienceSegmentCategory);
            _callListAudienceSegmentCategories = clientHelper.BuildApiCall<ListAudienceSegmentCategoriesRequest, ListAudienceSegmentCategoriesResponse>("ListAudienceSegmentCategories", grpcClient.ListAudienceSegmentCategoriesAsync, grpcClient.ListAudienceSegmentCategories, effectiveSettings.ListAudienceSegmentCategoriesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAudienceSegmentCategories);
            Modify_ListAudienceSegmentCategoriesApiCall(ref _callListAudienceSegmentCategories);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetAudienceSegmentCategoryApiCall(ref gaxgrpc::ApiCall<GetAudienceSegmentCategoryRequest, AudienceSegmentCategory> call);

        partial void Modify_ListAudienceSegmentCategoriesApiCall(ref gaxgrpc::ApiCall<ListAudienceSegmentCategoriesRequest, ListAudienceSegmentCategoriesResponse> call);

        partial void OnConstruction(AudienceSegmentCategoryService.AudienceSegmentCategoryServiceClient grpcClient, AudienceSegmentCategoryServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AudienceSegmentCategoryService client</summary>
        public override AudienceSegmentCategoryService.AudienceSegmentCategoryServiceClient GrpcClient { get; }

        partial void Modify_GetAudienceSegmentCategoryRequest(ref GetAudienceSegmentCategoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAudienceSegmentCategoriesRequest(ref ListAudienceSegmentCategoriesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves a `AudienceSegmentCategory` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AudienceSegmentCategory GetAudienceSegmentCategory(GetAudienceSegmentCategoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAudienceSegmentCategoryRequest(ref request, ref callSettings);
            return _callGetAudienceSegmentCategory.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a `AudienceSegmentCategory` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AudienceSegmentCategory> GetAudienceSegmentCategoryAsync(GetAudienceSegmentCategoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAudienceSegmentCategoryRequest(ref request, ref callSettings);
            return _callGetAudienceSegmentCategory.Async(request, callSettings);
        }

        /// <summary>
        /// Lists `AudienceSegmentCategory` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AudienceSegmentCategory"/> resources.</returns>
        public override gax::PagedEnumerable<ListAudienceSegmentCategoriesResponse, AudienceSegmentCategory> ListAudienceSegmentCategories(ListAudienceSegmentCategoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAudienceSegmentCategoriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAudienceSegmentCategoriesRequest, ListAudienceSegmentCategoriesResponse, AudienceSegmentCategory>(_callListAudienceSegmentCategories, request, callSettings);
        }

        /// <summary>
        /// Lists `AudienceSegmentCategory` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AudienceSegmentCategory"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAudienceSegmentCategoriesResponse, AudienceSegmentCategory> ListAudienceSegmentCategoriesAsync(ListAudienceSegmentCategoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAudienceSegmentCategoriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAudienceSegmentCategoriesRequest, ListAudienceSegmentCategoriesResponse, AudienceSegmentCategory>(_callListAudienceSegmentCategories, request, callSettings);
        }
    }

    public partial class ListAudienceSegmentCategoriesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAudienceSegmentCategoriesResponse : gaxgrpc::IPageResponse<AudienceSegmentCategory>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AudienceSegmentCategory> GetEnumerator() => AudienceSegmentCategories.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
