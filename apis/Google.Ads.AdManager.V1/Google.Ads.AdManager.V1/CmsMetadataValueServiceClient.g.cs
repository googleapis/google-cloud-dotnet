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
    /// <summary>Settings for <see cref="CmsMetadataValueServiceClient"/> instances.</summary>
    public sealed partial class CmsMetadataValueServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CmsMetadataValueServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CmsMetadataValueServiceSettings"/>.</returns>
        public static CmsMetadataValueServiceSettings GetDefault() => new CmsMetadataValueServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CmsMetadataValueServiceSettings"/> object with default settings.
        /// </summary>
        public CmsMetadataValueServiceSettings()
        {
        }

        private CmsMetadataValueServiceSettings(CmsMetadataValueServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCmsMetadataValueSettings = existing.GetCmsMetadataValueSettings;
            ListCmsMetadataValuesSettings = existing.ListCmsMetadataValuesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CmsMetadataValueServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CmsMetadataValueServiceClient.GetCmsMetadataValue</c> and
        /// <c>CmsMetadataValueServiceClient.GetCmsMetadataValueAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCmsMetadataValueSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CmsMetadataValueServiceClient.ListCmsMetadataValues</c> and
        /// <c>CmsMetadataValueServiceClient.ListCmsMetadataValuesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCmsMetadataValuesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CmsMetadataValueServiceSettings"/> object.</returns>
        public CmsMetadataValueServiceSettings Clone() => new CmsMetadataValueServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CmsMetadataValueServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class CmsMetadataValueServiceClientBuilder : gaxgrpc::ClientBuilderBase<CmsMetadataValueServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CmsMetadataValueServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CmsMetadataValueServiceClientBuilder() : base(CmsMetadataValueServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CmsMetadataValueServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CmsMetadataValueServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CmsMetadataValueServiceClient Build()
        {
            CmsMetadataValueServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CmsMetadataValueServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CmsMetadataValueServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CmsMetadataValueServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CmsMetadataValueServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CmsMetadataValueServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CmsMetadataValueServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CmsMetadataValueServiceClient.ChannelPool;
    }

    /// <summary>CmsMetadataValueService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `CmsMetadataValue` objects.
    /// </remarks>
    public abstract partial class CmsMetadataValueServiceClient
    {
        /// <summary>
        /// The default endpoint for the CmsMetadataValueService service, which is a host of "admanager.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default CmsMetadataValueService scopes.</summary>
        /// <remarks>
        /// The default CmsMetadataValueService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/admanager</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admanager",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CmsMetadataValueService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CmsMetadataValueServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="CmsMetadataValueServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CmsMetadataValueServiceClient"/>.</returns>
        public static stt::Task<CmsMetadataValueServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CmsMetadataValueServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CmsMetadataValueServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="CmsMetadataValueServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CmsMetadataValueServiceClient"/>.</returns>
        public static CmsMetadataValueServiceClient Create() => new CmsMetadataValueServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CmsMetadataValueServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CmsMetadataValueServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CmsMetadataValueServiceClient"/>.</returns>
        internal static CmsMetadataValueServiceClient Create(grpccore::CallInvoker callInvoker, CmsMetadataValueServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CmsMetadataValueService.CmsMetadataValueServiceClient grpcClient = new CmsMetadataValueService.CmsMetadataValueServiceClient(callInvoker);
            return new CmsMetadataValueServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CmsMetadataValueService client</summary>
        public virtual CmsMetadataValueService.CmsMetadataValueServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `CmsMetadataKey` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CmsMetadataValue GetCmsMetadataValue(GetCmsMetadataValueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `CmsMetadataKey` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CmsMetadataValue> GetCmsMetadataValueAsync(GetCmsMetadataValueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `CmsMetadataKey` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CmsMetadataValue> GetCmsMetadataValueAsync(GetCmsMetadataValueRequest request, st::CancellationToken cancellationToken) =>
            GetCmsMetadataValueAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `CmsMetadataKey` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CmsMetadataKey.
        /// Format: `networks/{network_code}/cmsMetadataValues/{cms_metadata_value_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CmsMetadataValue GetCmsMetadataValue(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCmsMetadataValue(new GetCmsMetadataValueRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `CmsMetadataKey` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CmsMetadataKey.
        /// Format: `networks/{network_code}/cmsMetadataValues/{cms_metadata_value_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CmsMetadataValue> GetCmsMetadataValueAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCmsMetadataValueAsync(new GetCmsMetadataValueRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `CmsMetadataKey` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CmsMetadataKey.
        /// Format: `networks/{network_code}/cmsMetadataValues/{cms_metadata_value_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CmsMetadataValue> GetCmsMetadataValueAsync(string name, st::CancellationToken cancellationToken) =>
            GetCmsMetadataValueAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `CmsMetadataKey` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CmsMetadataKey.
        /// Format: `networks/{network_code}/cmsMetadataValues/{cms_metadata_value_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CmsMetadataValue GetCmsMetadataValue(CmsMetadataValueName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCmsMetadataValue(new GetCmsMetadataValueRequest
            {
                CmsMetadataValueName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `CmsMetadataKey` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CmsMetadataKey.
        /// Format: `networks/{network_code}/cmsMetadataValues/{cms_metadata_value_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CmsMetadataValue> GetCmsMetadataValueAsync(CmsMetadataValueName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCmsMetadataValueAsync(new GetCmsMetadataValueRequest
            {
                CmsMetadataValueName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `CmsMetadataKey` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CmsMetadataKey.
        /// Format: `networks/{network_code}/cmsMetadataValues/{cms_metadata_value_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CmsMetadataValue> GetCmsMetadataValueAsync(CmsMetadataValueName name, st::CancellationToken cancellationToken) =>
            GetCmsMetadataValueAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a list of `CmsMetadataValue` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CmsMetadataValue"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCmsMetadataValuesResponse, CmsMetadataValue> ListCmsMetadataValues(ListCmsMetadataValuesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `CmsMetadataValue` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CmsMetadataValue"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCmsMetadataValuesResponse, CmsMetadataValue> ListCmsMetadataValuesAsync(ListCmsMetadataValuesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `CmsMetadataValue` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CmsMetadataValues.
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
        /// <returns>A pageable sequence of <see cref="CmsMetadataValue"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCmsMetadataValuesResponse, CmsMetadataValue> ListCmsMetadataValues(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCmsMetadataValuesRequest request = new ListCmsMetadataValuesRequest
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
            return ListCmsMetadataValues(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `CmsMetadataValue` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CmsMetadataValues.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CmsMetadataValue"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCmsMetadataValuesResponse, CmsMetadataValue> ListCmsMetadataValuesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCmsMetadataValuesRequest request = new ListCmsMetadataValuesRequest
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
            return ListCmsMetadataValuesAsync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `CmsMetadataValue` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CmsMetadataValues.
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
        /// <returns>A pageable sequence of <see cref="CmsMetadataValue"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCmsMetadataValuesResponse, CmsMetadataValue> ListCmsMetadataValues(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCmsMetadataValuesRequest request = new ListCmsMetadataValuesRequest
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
            return ListCmsMetadataValues(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `CmsMetadataValue` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CmsMetadataValues.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CmsMetadataValue"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCmsMetadataValuesResponse, CmsMetadataValue> ListCmsMetadataValuesAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCmsMetadataValuesRequest request = new ListCmsMetadataValuesRequest
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
            return ListCmsMetadataValuesAsync(request, callSettings);
        }
    }

    /// <summary>CmsMetadataValueService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `CmsMetadataValue` objects.
    /// </remarks>
    public sealed partial class CmsMetadataValueServiceClientImpl : CmsMetadataValueServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCmsMetadataValueRequest, CmsMetadataValue> _callGetCmsMetadataValue;

        private readonly gaxgrpc::ApiCall<ListCmsMetadataValuesRequest, ListCmsMetadataValuesResponse> _callListCmsMetadataValues;

        /// <summary>
        /// Constructs a client wrapper for the CmsMetadataValueService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="CmsMetadataValueServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CmsMetadataValueServiceClientImpl(CmsMetadataValueService.CmsMetadataValueServiceClient grpcClient, CmsMetadataValueServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CmsMetadataValueServiceSettings effectiveSettings = settings ?? CmsMetadataValueServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetCmsMetadataValue = clientHelper.BuildApiCall<GetCmsMetadataValueRequest, CmsMetadataValue>("GetCmsMetadataValue", grpcClient.GetCmsMetadataValueAsync, grpcClient.GetCmsMetadataValue, effectiveSettings.GetCmsMetadataValueSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCmsMetadataValue);
            Modify_GetCmsMetadataValueApiCall(ref _callGetCmsMetadataValue);
            _callListCmsMetadataValues = clientHelper.BuildApiCall<ListCmsMetadataValuesRequest, ListCmsMetadataValuesResponse>("ListCmsMetadataValues", grpcClient.ListCmsMetadataValuesAsync, grpcClient.ListCmsMetadataValues, effectiveSettings.ListCmsMetadataValuesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCmsMetadataValues);
            Modify_ListCmsMetadataValuesApiCall(ref _callListCmsMetadataValues);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetCmsMetadataValueApiCall(ref gaxgrpc::ApiCall<GetCmsMetadataValueRequest, CmsMetadataValue> call);

        partial void Modify_ListCmsMetadataValuesApiCall(ref gaxgrpc::ApiCall<ListCmsMetadataValuesRequest, ListCmsMetadataValuesResponse> call);

        partial void OnConstruction(CmsMetadataValueService.CmsMetadataValueServiceClient grpcClient, CmsMetadataValueServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CmsMetadataValueService client</summary>
        public override CmsMetadataValueService.CmsMetadataValueServiceClient GrpcClient { get; }

        partial void Modify_GetCmsMetadataValueRequest(ref GetCmsMetadataValueRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCmsMetadataValuesRequest(ref ListCmsMetadataValuesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// API to retrieve a `CmsMetadataKey` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CmsMetadataValue GetCmsMetadataValue(GetCmsMetadataValueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCmsMetadataValueRequest(ref request, ref callSettings);
            return _callGetCmsMetadataValue.Sync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a `CmsMetadataKey` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CmsMetadataValue> GetCmsMetadataValueAsync(GetCmsMetadataValueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCmsMetadataValueRequest(ref request, ref callSettings);
            return _callGetCmsMetadataValue.Async(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `CmsMetadataValue` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CmsMetadataValue"/> resources.</returns>
        public override gax::PagedEnumerable<ListCmsMetadataValuesResponse, CmsMetadataValue> ListCmsMetadataValues(ListCmsMetadataValuesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCmsMetadataValuesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCmsMetadataValuesRequest, ListCmsMetadataValuesResponse, CmsMetadataValue>(_callListCmsMetadataValues, request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `CmsMetadataValue` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CmsMetadataValue"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCmsMetadataValuesResponse, CmsMetadataValue> ListCmsMetadataValuesAsync(ListCmsMetadataValuesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCmsMetadataValuesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCmsMetadataValuesRequest, ListCmsMetadataValuesResponse, CmsMetadataValue>(_callListCmsMetadataValues, request, callSettings);
        }
    }

    public partial class ListCmsMetadataValuesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCmsMetadataValuesResponse : gaxgrpc::IPageResponse<CmsMetadataValue>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CmsMetadataValue> GetEnumerator() => CmsMetadataValues.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
