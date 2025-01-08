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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gckv = Google.Cloud.Kms.V1;
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

namespace Google.Cloud.Kms.Inventory.V1
{
    /// <summary>Settings for <see cref="KeyDashboardServiceClient"/> instances.</summary>
    public sealed partial class KeyDashboardServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="KeyDashboardServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="KeyDashboardServiceSettings"/>.</returns>
        public static KeyDashboardServiceSettings GetDefault() => new KeyDashboardServiceSettings();

        /// <summary>Constructs a new <see cref="KeyDashboardServiceSettings"/> object with default settings.</summary>
        public KeyDashboardServiceSettings()
        {
        }

        private KeyDashboardServiceSettings(KeyDashboardServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListCryptoKeysSettings = existing.ListCryptoKeysSettings;
            OnCopy(existing);
        }

        partial void OnCopy(KeyDashboardServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeyDashboardServiceClient.ListCryptoKeys</c> and <c>KeyDashboardServiceClient.ListCryptoKeysAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCryptoKeysSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="KeyDashboardServiceSettings"/> object.</returns>
        public KeyDashboardServiceSettings Clone() => new KeyDashboardServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="KeyDashboardServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class KeyDashboardServiceClientBuilder : gaxgrpc::ClientBuilderBase<KeyDashboardServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public KeyDashboardServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public KeyDashboardServiceClientBuilder() : base(KeyDashboardServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref KeyDashboardServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<KeyDashboardServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override KeyDashboardServiceClient Build()
        {
            KeyDashboardServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<KeyDashboardServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<KeyDashboardServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private KeyDashboardServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return KeyDashboardServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<KeyDashboardServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return KeyDashboardServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => KeyDashboardServiceClient.ChannelPool;
    }

    /// <summary>KeyDashboardService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides a cross-region view of all Cloud KMS keys in a given Cloud project.
    /// </remarks>
    public abstract partial class KeyDashboardServiceClient
    {
        /// <summary>
        /// The default endpoint for the KeyDashboardService service, which is a host of "kmsinventory.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "kmsinventory.googleapis.com:443";

        /// <summary>The default KeyDashboardService scopes.</summary>
        /// <remarks>
        /// The default KeyDashboardService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(KeyDashboardService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="KeyDashboardServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="KeyDashboardServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="KeyDashboardServiceClient"/>.</returns>
        public static stt::Task<KeyDashboardServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new KeyDashboardServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="KeyDashboardServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="KeyDashboardServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="KeyDashboardServiceClient"/>.</returns>
        public static KeyDashboardServiceClient Create() => new KeyDashboardServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="KeyDashboardServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="KeyDashboardServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="KeyDashboardServiceClient"/>.</returns>
        internal static KeyDashboardServiceClient Create(grpccore::CallInvoker callInvoker, KeyDashboardServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            KeyDashboardService.KeyDashboardServiceClient grpcClient = new KeyDashboardService.KeyDashboardServiceClient(callInvoker);
            return new KeyDashboardServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC KeyDashboardService client</summary>
        public virtual KeyDashboardService.KeyDashboardServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns cryptographic keys managed by Cloud KMS in a given Cloud project.
        /// Note that this data is sourced from snapshots, meaning it may not
        /// completely reflect the actual state of key metadata at call time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="gckv::CryptoKey"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCryptoKeysResponse, gckv::CryptoKey> ListCryptoKeys(ListCryptoKeysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns cryptographic keys managed by Cloud KMS in a given Cloud project.
        /// Note that this data is sourced from snapshots, meaning it may not
        /// completely reflect the actual state of key metadata at call time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="gckv::CryptoKey"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCryptoKeysResponse, gckv::CryptoKey> ListCryptoKeysAsync(ListCryptoKeysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns cryptographic keys managed by Cloud KMS in a given Cloud project.
        /// Note that this data is sourced from snapshots, meaning it may not
        /// completely reflect the actual state of key metadata at call time.
        /// </summary>
        /// <param name="parent">
        /// Required. The Google Cloud project for which to retrieve key metadata, in
        /// the format `projects/*`
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
        /// <returns>A pageable sequence of <see cref="gckv::CryptoKey"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCryptoKeysResponse, gckv::CryptoKey> ListCryptoKeys(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCryptoKeysRequest request = new ListCryptoKeysRequest
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
            return ListCryptoKeys(request, callSettings);
        }

        /// <summary>
        /// Returns cryptographic keys managed by Cloud KMS in a given Cloud project.
        /// Note that this data is sourced from snapshots, meaning it may not
        /// completely reflect the actual state of key metadata at call time.
        /// </summary>
        /// <param name="parent">
        /// Required. The Google Cloud project for which to retrieve key metadata, in
        /// the format `projects/*`
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
        /// <returns>A pageable asynchronous sequence of <see cref="gckv::CryptoKey"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCryptoKeysResponse, gckv::CryptoKey> ListCryptoKeysAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCryptoKeysRequest request = new ListCryptoKeysRequest
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
            return ListCryptoKeysAsync(request, callSettings);
        }

        /// <summary>
        /// Returns cryptographic keys managed by Cloud KMS in a given Cloud project.
        /// Note that this data is sourced from snapshots, meaning it may not
        /// completely reflect the actual state of key metadata at call time.
        /// </summary>
        /// <param name="parent">
        /// Required. The Google Cloud project for which to retrieve key metadata, in
        /// the format `projects/*`
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
        /// <returns>A pageable sequence of <see cref="gckv::CryptoKey"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCryptoKeysResponse, gckv::CryptoKey> ListCryptoKeys(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCryptoKeysRequest request = new ListCryptoKeysRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCryptoKeys(request, callSettings);
        }

        /// <summary>
        /// Returns cryptographic keys managed by Cloud KMS in a given Cloud project.
        /// Note that this data is sourced from snapshots, meaning it may not
        /// completely reflect the actual state of key metadata at call time.
        /// </summary>
        /// <param name="parent">
        /// Required. The Google Cloud project for which to retrieve key metadata, in
        /// the format `projects/*`
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
        /// <returns>A pageable asynchronous sequence of <see cref="gckv::CryptoKey"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCryptoKeysResponse, gckv::CryptoKey> ListCryptoKeysAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCryptoKeysRequest request = new ListCryptoKeysRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCryptoKeysAsync(request, callSettings);
        }
    }

    /// <summary>KeyDashboardService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides a cross-region view of all Cloud KMS keys in a given Cloud project.
    /// </remarks>
    public sealed partial class KeyDashboardServiceClientImpl : KeyDashboardServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListCryptoKeysRequest, ListCryptoKeysResponse> _callListCryptoKeys;

        /// <summary>
        /// Constructs a client wrapper for the KeyDashboardService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="KeyDashboardServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public KeyDashboardServiceClientImpl(KeyDashboardService.KeyDashboardServiceClient grpcClient, KeyDashboardServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            KeyDashboardServiceSettings effectiveSettings = settings ?? KeyDashboardServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callListCryptoKeys = clientHelper.BuildApiCall<ListCryptoKeysRequest, ListCryptoKeysResponse>("ListCryptoKeys", grpcClient.ListCryptoKeysAsync, grpcClient.ListCryptoKeys, effectiveSettings.ListCryptoKeysSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCryptoKeys);
            Modify_ListCryptoKeysApiCall(ref _callListCryptoKeys);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListCryptoKeysApiCall(ref gaxgrpc::ApiCall<ListCryptoKeysRequest, ListCryptoKeysResponse> call);

        partial void OnConstruction(KeyDashboardService.KeyDashboardServiceClient grpcClient, KeyDashboardServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC KeyDashboardService client</summary>
        public override KeyDashboardService.KeyDashboardServiceClient GrpcClient { get; }

        partial void Modify_ListCryptoKeysRequest(ref ListCryptoKeysRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns cryptographic keys managed by Cloud KMS in a given Cloud project.
        /// Note that this data is sourced from snapshots, meaning it may not
        /// completely reflect the actual state of key metadata at call time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="gckv::CryptoKey"/> resources.</returns>
        public override gax::PagedEnumerable<ListCryptoKeysResponse, gckv::CryptoKey> ListCryptoKeys(ListCryptoKeysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCryptoKeysRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCryptoKeysRequest, ListCryptoKeysResponse, gckv::CryptoKey>(_callListCryptoKeys, request, callSettings);
        }

        /// <summary>
        /// Returns cryptographic keys managed by Cloud KMS in a given Cloud project.
        /// Note that this data is sourced from snapshots, meaning it may not
        /// completely reflect the actual state of key metadata at call time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="gckv::CryptoKey"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCryptoKeysResponse, gckv::CryptoKey> ListCryptoKeysAsync(ListCryptoKeysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCryptoKeysRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCryptoKeysRequest, ListCryptoKeysResponse, gckv::CryptoKey>(_callListCryptoKeys, request, callSettings);
        }
    }

    public partial class ListCryptoKeysRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCryptoKeysResponse : gaxgrpc::IPageResponse<gckv::CryptoKey>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<gckv::CryptoKey> GetEnumerator() => CryptoKeys.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
