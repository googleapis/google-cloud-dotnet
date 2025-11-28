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
    /// <summary>Settings for <see cref="CustomTargetingKeyServiceClient"/> instances.</summary>
    public sealed partial class CustomTargetingKeyServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CustomTargetingKeyServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CustomTargetingKeyServiceSettings"/>.</returns>
        public static CustomTargetingKeyServiceSettings GetDefault() => new CustomTargetingKeyServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CustomTargetingKeyServiceSettings"/> object with default settings.
        /// </summary>
        public CustomTargetingKeyServiceSettings()
        {
        }

        private CustomTargetingKeyServiceSettings(CustomTargetingKeyServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCustomTargetingKeySettings = existing.GetCustomTargetingKeySettings;
            ListCustomTargetingKeysSettings = existing.ListCustomTargetingKeysSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CustomTargetingKeyServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomTargetingKeyServiceClient.GetCustomTargetingKey</c> and
        /// <c>CustomTargetingKeyServiceClient.GetCustomTargetingKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCustomTargetingKeySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomTargetingKeyServiceClient.ListCustomTargetingKeys</c> and
        /// <c>CustomTargetingKeyServiceClient.ListCustomTargetingKeysAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCustomTargetingKeysSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CustomTargetingKeyServiceSettings"/> object.</returns>
        public CustomTargetingKeyServiceSettings Clone() => new CustomTargetingKeyServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CustomTargetingKeyServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class CustomTargetingKeyServiceClientBuilder : gaxgrpc::ClientBuilderBase<CustomTargetingKeyServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CustomTargetingKeyServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CustomTargetingKeyServiceClientBuilder() : base(CustomTargetingKeyServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CustomTargetingKeyServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CustomTargetingKeyServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CustomTargetingKeyServiceClient Build()
        {
            CustomTargetingKeyServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CustomTargetingKeyServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CustomTargetingKeyServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CustomTargetingKeyServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CustomTargetingKeyServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CustomTargetingKeyServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CustomTargetingKeyServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CustomTargetingKeyServiceClient.ChannelPool;
    }

    /// <summary>CustomTargetingKeyService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `CustomTargetingKey` objects.
    /// </remarks>
    public abstract partial class CustomTargetingKeyServiceClient
    {
        /// <summary>
        /// The default endpoint for the CustomTargetingKeyService service, which is a host of
        /// "admanager.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default CustomTargetingKeyService scopes.</summary>
        /// <remarks>
        /// The default CustomTargetingKeyService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/admanager</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admanager",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CustomTargetingKeyService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CustomTargetingKeyServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CustomTargetingKeyServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CustomTargetingKeyServiceClient"/>.</returns>
        public static stt::Task<CustomTargetingKeyServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CustomTargetingKeyServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CustomTargetingKeyServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CustomTargetingKeyServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CustomTargetingKeyServiceClient"/>.</returns>
        public static CustomTargetingKeyServiceClient Create() => new CustomTargetingKeyServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CustomTargetingKeyServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CustomTargetingKeyServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CustomTargetingKeyServiceClient"/>.</returns>
        internal static CustomTargetingKeyServiceClient Create(grpccore::CallInvoker callInvoker, CustomTargetingKeyServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CustomTargetingKeyService.CustomTargetingKeyServiceClient grpcClient = new CustomTargetingKeyService.CustomTargetingKeyServiceClient(callInvoker);
            return new CustomTargetingKeyServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CustomTargetingKeyService client</summary>
        public virtual CustomTargetingKeyService.CustomTargetingKeyServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `CustomTargetingKey` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomTargetingKey GetCustomTargetingKey(GetCustomTargetingKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `CustomTargetingKey` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomTargetingKey> GetCustomTargetingKeyAsync(GetCustomTargetingKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `CustomTargetingKey` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomTargetingKey> GetCustomTargetingKeyAsync(GetCustomTargetingKeyRequest request, st::CancellationToken cancellationToken) =>
            GetCustomTargetingKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `CustomTargetingKey` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CustomTargetingKey.
        /// Format:
        /// `networks/{network_code}/customTargetingKeys/{custom_targeting_key_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomTargetingKey GetCustomTargetingKey(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomTargetingKey(new GetCustomTargetingKeyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `CustomTargetingKey` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CustomTargetingKey.
        /// Format:
        /// `networks/{network_code}/customTargetingKeys/{custom_targeting_key_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomTargetingKey> GetCustomTargetingKeyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomTargetingKeyAsync(new GetCustomTargetingKeyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `CustomTargetingKey` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CustomTargetingKey.
        /// Format:
        /// `networks/{network_code}/customTargetingKeys/{custom_targeting_key_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomTargetingKey> GetCustomTargetingKeyAsync(string name, st::CancellationToken cancellationToken) =>
            GetCustomTargetingKeyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `CustomTargetingKey` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CustomTargetingKey.
        /// Format:
        /// `networks/{network_code}/customTargetingKeys/{custom_targeting_key_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomTargetingKey GetCustomTargetingKey(CustomTargetingKeyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomTargetingKey(new GetCustomTargetingKeyRequest
            {
                CustomTargetingKeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `CustomTargetingKey` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CustomTargetingKey.
        /// Format:
        /// `networks/{network_code}/customTargetingKeys/{custom_targeting_key_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomTargetingKey> GetCustomTargetingKeyAsync(CustomTargetingKeyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomTargetingKeyAsync(new GetCustomTargetingKeyRequest
            {
                CustomTargetingKeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `CustomTargetingKey` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CustomTargetingKey.
        /// Format:
        /// `networks/{network_code}/customTargetingKeys/{custom_targeting_key_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomTargetingKey> GetCustomTargetingKeyAsync(CustomTargetingKeyName name, st::CancellationToken cancellationToken) =>
            GetCustomTargetingKeyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a list of `CustomTargetingKey` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CustomTargetingKey"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCustomTargetingKeysResponse, CustomTargetingKey> ListCustomTargetingKeys(ListCustomTargetingKeysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `CustomTargetingKey` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CustomTargetingKey"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCustomTargetingKeysResponse, CustomTargetingKey> ListCustomTargetingKeysAsync(ListCustomTargetingKeysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `CustomTargetingKey` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CustomTargetingKeys.
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
        /// <returns>A pageable sequence of <see cref="CustomTargetingKey"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCustomTargetingKeysResponse, CustomTargetingKey> ListCustomTargetingKeys(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCustomTargetingKeysRequest request = new ListCustomTargetingKeysRequest
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
            return ListCustomTargetingKeys(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `CustomTargetingKey` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CustomTargetingKeys.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CustomTargetingKey"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCustomTargetingKeysResponse, CustomTargetingKey> ListCustomTargetingKeysAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCustomTargetingKeysRequest request = new ListCustomTargetingKeysRequest
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
            return ListCustomTargetingKeysAsync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `CustomTargetingKey` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CustomTargetingKeys.
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
        /// <returns>A pageable sequence of <see cref="CustomTargetingKey"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCustomTargetingKeysResponse, CustomTargetingKey> ListCustomTargetingKeys(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCustomTargetingKeysRequest request = new ListCustomTargetingKeysRequest
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
            return ListCustomTargetingKeys(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `CustomTargetingKey` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CustomTargetingKeys.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CustomTargetingKey"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCustomTargetingKeysResponse, CustomTargetingKey> ListCustomTargetingKeysAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCustomTargetingKeysRequest request = new ListCustomTargetingKeysRequest
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
            return ListCustomTargetingKeysAsync(request, callSettings);
        }
    }

    /// <summary>CustomTargetingKeyService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `CustomTargetingKey` objects.
    /// </remarks>
    public sealed partial class CustomTargetingKeyServiceClientImpl : CustomTargetingKeyServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCustomTargetingKeyRequest, CustomTargetingKey> _callGetCustomTargetingKey;

        private readonly gaxgrpc::ApiCall<ListCustomTargetingKeysRequest, ListCustomTargetingKeysResponse> _callListCustomTargetingKeys;

        /// <summary>
        /// Constructs a client wrapper for the CustomTargetingKeyService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="CustomTargetingKeyServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CustomTargetingKeyServiceClientImpl(CustomTargetingKeyService.CustomTargetingKeyServiceClient grpcClient, CustomTargetingKeyServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CustomTargetingKeyServiceSettings effectiveSettings = settings ?? CustomTargetingKeyServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetCustomTargetingKey = clientHelper.BuildApiCall<GetCustomTargetingKeyRequest, CustomTargetingKey>("GetCustomTargetingKey", grpcClient.GetCustomTargetingKeyAsync, grpcClient.GetCustomTargetingKey, effectiveSettings.GetCustomTargetingKeySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCustomTargetingKey);
            Modify_GetCustomTargetingKeyApiCall(ref _callGetCustomTargetingKey);
            _callListCustomTargetingKeys = clientHelper.BuildApiCall<ListCustomTargetingKeysRequest, ListCustomTargetingKeysResponse>("ListCustomTargetingKeys", grpcClient.ListCustomTargetingKeysAsync, grpcClient.ListCustomTargetingKeys, effectiveSettings.ListCustomTargetingKeysSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCustomTargetingKeys);
            Modify_ListCustomTargetingKeysApiCall(ref _callListCustomTargetingKeys);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetCustomTargetingKeyApiCall(ref gaxgrpc::ApiCall<GetCustomTargetingKeyRequest, CustomTargetingKey> call);

        partial void Modify_ListCustomTargetingKeysApiCall(ref gaxgrpc::ApiCall<ListCustomTargetingKeysRequest, ListCustomTargetingKeysResponse> call);

        partial void OnConstruction(CustomTargetingKeyService.CustomTargetingKeyServiceClient grpcClient, CustomTargetingKeyServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CustomTargetingKeyService client</summary>
        public override CustomTargetingKeyService.CustomTargetingKeyServiceClient GrpcClient { get; }

        partial void Modify_GetCustomTargetingKeyRequest(ref GetCustomTargetingKeyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCustomTargetingKeysRequest(ref ListCustomTargetingKeysRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// API to retrieve a `CustomTargetingKey` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CustomTargetingKey GetCustomTargetingKey(GetCustomTargetingKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomTargetingKeyRequest(ref request, ref callSettings);
            return _callGetCustomTargetingKey.Sync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a `CustomTargetingKey` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CustomTargetingKey> GetCustomTargetingKeyAsync(GetCustomTargetingKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomTargetingKeyRequest(ref request, ref callSettings);
            return _callGetCustomTargetingKey.Async(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `CustomTargetingKey` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CustomTargetingKey"/> resources.</returns>
        public override gax::PagedEnumerable<ListCustomTargetingKeysResponse, CustomTargetingKey> ListCustomTargetingKeys(ListCustomTargetingKeysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCustomTargetingKeysRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCustomTargetingKeysRequest, ListCustomTargetingKeysResponse, CustomTargetingKey>(_callListCustomTargetingKeys, request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `CustomTargetingKey` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CustomTargetingKey"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCustomTargetingKeysResponse, CustomTargetingKey> ListCustomTargetingKeysAsync(ListCustomTargetingKeysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCustomTargetingKeysRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCustomTargetingKeysRequest, ListCustomTargetingKeysResponse, CustomTargetingKey>(_callListCustomTargetingKeys, request, callSettings);
        }
    }

    public partial class ListCustomTargetingKeysRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCustomTargetingKeysResponse : gaxgrpc::IPageResponse<CustomTargetingKey>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CustomTargetingKey> GetEnumerator() => CustomTargetingKeys.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
