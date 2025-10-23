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
    /// <summary>Settings for <see cref="CmsMetadataKeyServiceClient"/> instances.</summary>
    public sealed partial class CmsMetadataKeyServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CmsMetadataKeyServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CmsMetadataKeyServiceSettings"/>.</returns>
        public static CmsMetadataKeyServiceSettings GetDefault() => new CmsMetadataKeyServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CmsMetadataKeyServiceSettings"/> object with default settings.
        /// </summary>
        public CmsMetadataKeyServiceSettings()
        {
        }

        private CmsMetadataKeyServiceSettings(CmsMetadataKeyServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCmsMetadataKeySettings = existing.GetCmsMetadataKeySettings;
            ListCmsMetadataKeysSettings = existing.ListCmsMetadataKeysSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CmsMetadataKeyServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CmsMetadataKeyServiceClient.GetCmsMetadataKey</c> and
        /// <c>CmsMetadataKeyServiceClient.GetCmsMetadataKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCmsMetadataKeySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CmsMetadataKeyServiceClient.ListCmsMetadataKeys</c> and
        /// <c>CmsMetadataKeyServiceClient.ListCmsMetadataKeysAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCmsMetadataKeysSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CmsMetadataKeyServiceSettings"/> object.</returns>
        public CmsMetadataKeyServiceSettings Clone() => new CmsMetadataKeyServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CmsMetadataKeyServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class CmsMetadataKeyServiceClientBuilder : gaxgrpc::ClientBuilderBase<CmsMetadataKeyServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CmsMetadataKeyServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CmsMetadataKeyServiceClientBuilder() : base(CmsMetadataKeyServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CmsMetadataKeyServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CmsMetadataKeyServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CmsMetadataKeyServiceClient Build()
        {
            CmsMetadataKeyServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CmsMetadataKeyServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CmsMetadataKeyServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CmsMetadataKeyServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CmsMetadataKeyServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CmsMetadataKeyServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CmsMetadataKeyServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CmsMetadataKeyServiceClient.ChannelPool;
    }

    /// <summary>CmsMetadataKeyService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `CmsMetadataKey` objects.
    /// </remarks>
    public abstract partial class CmsMetadataKeyServiceClient
    {
        /// <summary>
        /// The default endpoint for the CmsMetadataKeyService service, which is a host of "admanager.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default CmsMetadataKeyService scopes.</summary>
        /// <remarks>
        /// The default CmsMetadataKeyService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/admanager</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admanager",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CmsMetadataKeyService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CmsMetadataKeyServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="CmsMetadataKeyServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CmsMetadataKeyServiceClient"/>.</returns>
        public static stt::Task<CmsMetadataKeyServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CmsMetadataKeyServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CmsMetadataKeyServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="CmsMetadataKeyServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CmsMetadataKeyServiceClient"/>.</returns>
        public static CmsMetadataKeyServiceClient Create() => new CmsMetadataKeyServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CmsMetadataKeyServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CmsMetadataKeyServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CmsMetadataKeyServiceClient"/>.</returns>
        internal static CmsMetadataKeyServiceClient Create(grpccore::CallInvoker callInvoker, CmsMetadataKeyServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CmsMetadataKeyService.CmsMetadataKeyServiceClient grpcClient = new CmsMetadataKeyService.CmsMetadataKeyServiceClient(callInvoker);
            return new CmsMetadataKeyServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CmsMetadataKeyService client</summary>
        public virtual CmsMetadataKeyService.CmsMetadataKeyServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `CmsMetadataKey` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CmsMetadataKey GetCmsMetadataKey(GetCmsMetadataKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `CmsMetadataKey` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CmsMetadataKey> GetCmsMetadataKeyAsync(GetCmsMetadataKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `CmsMetadataKey` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CmsMetadataKey> GetCmsMetadataKeyAsync(GetCmsMetadataKeyRequest request, st::CancellationToken cancellationToken) =>
            GetCmsMetadataKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `CmsMetadataKey` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CmsMetadataKey.
        /// Format: `networks/{network_code}/cmsMetadataKeys/{cms_metadata_key_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CmsMetadataKey GetCmsMetadataKey(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCmsMetadataKey(new GetCmsMetadataKeyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `CmsMetadataKey` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CmsMetadataKey.
        /// Format: `networks/{network_code}/cmsMetadataKeys/{cms_metadata_key_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CmsMetadataKey> GetCmsMetadataKeyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCmsMetadataKeyAsync(new GetCmsMetadataKeyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `CmsMetadataKey` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CmsMetadataKey.
        /// Format: `networks/{network_code}/cmsMetadataKeys/{cms_metadata_key_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CmsMetadataKey> GetCmsMetadataKeyAsync(string name, st::CancellationToken cancellationToken) =>
            GetCmsMetadataKeyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `CmsMetadataKey` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CmsMetadataKey.
        /// Format: `networks/{network_code}/cmsMetadataKeys/{cms_metadata_key_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CmsMetadataKey GetCmsMetadataKey(CmsMetadataKeyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCmsMetadataKey(new GetCmsMetadataKeyRequest
            {
                CmsMetadataKeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `CmsMetadataKey` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CmsMetadataKey.
        /// Format: `networks/{network_code}/cmsMetadataKeys/{cms_metadata_key_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CmsMetadataKey> GetCmsMetadataKeyAsync(CmsMetadataKeyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCmsMetadataKeyAsync(new GetCmsMetadataKeyRequest
            {
                CmsMetadataKeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `CmsMetadataKey` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CmsMetadataKey.
        /// Format: `networks/{network_code}/cmsMetadataKeys/{cms_metadata_key_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CmsMetadataKey> GetCmsMetadataKeyAsync(CmsMetadataKeyName name, st::CancellationToken cancellationToken) =>
            GetCmsMetadataKeyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a list of `CmsMetadataKey` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CmsMetadataKey"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCmsMetadataKeysResponse, CmsMetadataKey> ListCmsMetadataKeys(ListCmsMetadataKeysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `CmsMetadataKey` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CmsMetadataKey"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCmsMetadataKeysResponse, CmsMetadataKey> ListCmsMetadataKeysAsync(ListCmsMetadataKeysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `CmsMetadataKey` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CmsMetadataKeys.
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
        /// <returns>A pageable sequence of <see cref="CmsMetadataKey"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCmsMetadataKeysResponse, CmsMetadataKey> ListCmsMetadataKeys(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCmsMetadataKeysRequest request = new ListCmsMetadataKeysRequest
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
            return ListCmsMetadataKeys(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `CmsMetadataKey` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CmsMetadataKeys.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CmsMetadataKey"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCmsMetadataKeysResponse, CmsMetadataKey> ListCmsMetadataKeysAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCmsMetadataKeysRequest request = new ListCmsMetadataKeysRequest
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
            return ListCmsMetadataKeysAsync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `CmsMetadataKey` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CmsMetadataKeys.
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
        /// <returns>A pageable sequence of <see cref="CmsMetadataKey"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCmsMetadataKeysResponse, CmsMetadataKey> ListCmsMetadataKeys(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCmsMetadataKeysRequest request = new ListCmsMetadataKeysRequest
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
            return ListCmsMetadataKeys(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `CmsMetadataKey` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CmsMetadataKeys.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CmsMetadataKey"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCmsMetadataKeysResponse, CmsMetadataKey> ListCmsMetadataKeysAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCmsMetadataKeysRequest request = new ListCmsMetadataKeysRequest
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
            return ListCmsMetadataKeysAsync(request, callSettings);
        }
    }

    /// <summary>CmsMetadataKeyService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `CmsMetadataKey` objects.
    /// </remarks>
    public sealed partial class CmsMetadataKeyServiceClientImpl : CmsMetadataKeyServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCmsMetadataKeyRequest, CmsMetadataKey> _callGetCmsMetadataKey;

        private readonly gaxgrpc::ApiCall<ListCmsMetadataKeysRequest, ListCmsMetadataKeysResponse> _callListCmsMetadataKeys;

        /// <summary>
        /// Constructs a client wrapper for the CmsMetadataKeyService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CmsMetadataKeyServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CmsMetadataKeyServiceClientImpl(CmsMetadataKeyService.CmsMetadataKeyServiceClient grpcClient, CmsMetadataKeyServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CmsMetadataKeyServiceSettings effectiveSettings = settings ?? CmsMetadataKeyServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetCmsMetadataKey = clientHelper.BuildApiCall<GetCmsMetadataKeyRequest, CmsMetadataKey>("GetCmsMetadataKey", grpcClient.GetCmsMetadataKeyAsync, grpcClient.GetCmsMetadataKey, effectiveSettings.GetCmsMetadataKeySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCmsMetadataKey);
            Modify_GetCmsMetadataKeyApiCall(ref _callGetCmsMetadataKey);
            _callListCmsMetadataKeys = clientHelper.BuildApiCall<ListCmsMetadataKeysRequest, ListCmsMetadataKeysResponse>("ListCmsMetadataKeys", grpcClient.ListCmsMetadataKeysAsync, grpcClient.ListCmsMetadataKeys, effectiveSettings.ListCmsMetadataKeysSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCmsMetadataKeys);
            Modify_ListCmsMetadataKeysApiCall(ref _callListCmsMetadataKeys);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetCmsMetadataKeyApiCall(ref gaxgrpc::ApiCall<GetCmsMetadataKeyRequest, CmsMetadataKey> call);

        partial void Modify_ListCmsMetadataKeysApiCall(ref gaxgrpc::ApiCall<ListCmsMetadataKeysRequest, ListCmsMetadataKeysResponse> call);

        partial void OnConstruction(CmsMetadataKeyService.CmsMetadataKeyServiceClient grpcClient, CmsMetadataKeyServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CmsMetadataKeyService client</summary>
        public override CmsMetadataKeyService.CmsMetadataKeyServiceClient GrpcClient { get; }

        partial void Modify_GetCmsMetadataKeyRequest(ref GetCmsMetadataKeyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCmsMetadataKeysRequest(ref ListCmsMetadataKeysRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// API to retrieve a `CmsMetadataKey` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CmsMetadataKey GetCmsMetadataKey(GetCmsMetadataKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCmsMetadataKeyRequest(ref request, ref callSettings);
            return _callGetCmsMetadataKey.Sync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a `CmsMetadataKey` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CmsMetadataKey> GetCmsMetadataKeyAsync(GetCmsMetadataKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCmsMetadataKeyRequest(ref request, ref callSettings);
            return _callGetCmsMetadataKey.Async(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `CmsMetadataKey` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CmsMetadataKey"/> resources.</returns>
        public override gax::PagedEnumerable<ListCmsMetadataKeysResponse, CmsMetadataKey> ListCmsMetadataKeys(ListCmsMetadataKeysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCmsMetadataKeysRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCmsMetadataKeysRequest, ListCmsMetadataKeysResponse, CmsMetadataKey>(_callListCmsMetadataKeys, request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `CmsMetadataKey` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CmsMetadataKey"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCmsMetadataKeysResponse, CmsMetadataKey> ListCmsMetadataKeysAsync(ListCmsMetadataKeysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCmsMetadataKeysRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCmsMetadataKeysRequest, ListCmsMetadataKeysResponse, CmsMetadataKey>(_callListCmsMetadataKeys, request, callSettings);
        }
    }

    public partial class ListCmsMetadataKeysRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCmsMetadataKeysResponse : gaxgrpc::IPageResponse<CmsMetadataKey>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CmsMetadataKey> GetEnumerator() => CmsMetadataKeys.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
