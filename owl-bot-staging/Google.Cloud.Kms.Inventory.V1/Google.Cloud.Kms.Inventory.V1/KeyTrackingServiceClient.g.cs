// Copyright 2024 Google LLC
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
    /// <summary>Settings for <see cref="KeyTrackingServiceClient"/> instances.</summary>
    public sealed partial class KeyTrackingServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="KeyTrackingServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="KeyTrackingServiceSettings"/>.</returns>
        public static KeyTrackingServiceSettings GetDefault() => new KeyTrackingServiceSettings();

        /// <summary>Constructs a new <see cref="KeyTrackingServiceSettings"/> object with default settings.</summary>
        public KeyTrackingServiceSettings()
        {
        }

        private KeyTrackingServiceSettings(KeyTrackingServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetProtectedResourcesSummarySettings = existing.GetProtectedResourcesSummarySettings;
            SearchProtectedResourcesSettings = existing.SearchProtectedResourcesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(KeyTrackingServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeyTrackingServiceClient.GetProtectedResourcesSummary</c> and
        /// <c>KeyTrackingServiceClient.GetProtectedResourcesSummaryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetProtectedResourcesSummarySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeyTrackingServiceClient.SearchProtectedResources</c> and
        /// <c>KeyTrackingServiceClient.SearchProtectedResourcesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchProtectedResourcesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="KeyTrackingServiceSettings"/> object.</returns>
        public KeyTrackingServiceSettings Clone() => new KeyTrackingServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="KeyTrackingServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class KeyTrackingServiceClientBuilder : gaxgrpc::ClientBuilderBase<KeyTrackingServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public KeyTrackingServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public KeyTrackingServiceClientBuilder() : base(KeyTrackingServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref KeyTrackingServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<KeyTrackingServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override KeyTrackingServiceClient Build()
        {
            KeyTrackingServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<KeyTrackingServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<KeyTrackingServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private KeyTrackingServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return KeyTrackingServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<KeyTrackingServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return KeyTrackingServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => KeyTrackingServiceClient.ChannelPool;
    }

    /// <summary>KeyTrackingService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Returns information about the resources in an org that are protected by a
    /// given Cloud KMS key via CMEK.
    /// </remarks>
    public abstract partial class KeyTrackingServiceClient
    {
        /// <summary>
        /// The default endpoint for the KeyTrackingService service, which is a host of "kmsinventory.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "kmsinventory.googleapis.com:443";

        /// <summary>The default KeyTrackingService scopes.</summary>
        /// <remarks>
        /// The default KeyTrackingService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(KeyTrackingService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="KeyTrackingServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="KeyTrackingServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="KeyTrackingServiceClient"/>.</returns>
        public static stt::Task<KeyTrackingServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new KeyTrackingServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="KeyTrackingServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="KeyTrackingServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="KeyTrackingServiceClient"/>.</returns>
        public static KeyTrackingServiceClient Create() => new KeyTrackingServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="KeyTrackingServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="KeyTrackingServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="KeyTrackingServiceClient"/>.</returns>
        internal static KeyTrackingServiceClient Create(grpccore::CallInvoker callInvoker, KeyTrackingServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            KeyTrackingService.KeyTrackingServiceClient grpcClient = new KeyTrackingService.KeyTrackingServiceClient(callInvoker);
            return new KeyTrackingServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC KeyTrackingService client</summary>
        public virtual KeyTrackingService.KeyTrackingServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns aggregate information about the resources protected by the given
        /// Cloud KMS [CryptoKey][google.cloud.kms.v1.CryptoKey]. Only resources within
        /// the same Cloud organization as the key will be returned. The project that
        /// holds the key must be part of an organization in order for this call to
        /// succeed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProtectedResourcesSummary GetProtectedResourcesSummary(GetProtectedResourcesSummaryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns aggregate information about the resources protected by the given
        /// Cloud KMS [CryptoKey][google.cloud.kms.v1.CryptoKey]. Only resources within
        /// the same Cloud organization as the key will be returned. The project that
        /// holds the key must be part of an organization in order for this call to
        /// succeed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProtectedResourcesSummary> GetProtectedResourcesSummaryAsync(GetProtectedResourcesSummaryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns aggregate information about the resources protected by the given
        /// Cloud KMS [CryptoKey][google.cloud.kms.v1.CryptoKey]. Only resources within
        /// the same Cloud organization as the key will be returned. The project that
        /// holds the key must be part of an organization in order for this call to
        /// succeed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProtectedResourcesSummary> GetProtectedResourcesSummaryAsync(GetProtectedResourcesSummaryRequest request, st::CancellationToken cancellationToken) =>
            GetProtectedResourcesSummaryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns aggregate information about the resources protected by the given
        /// Cloud KMS [CryptoKey][google.cloud.kms.v1.CryptoKey]. Only resources within
        /// the same Cloud organization as the key will be returned. The project that
        /// holds the key must be part of an organization in order for this call to
        /// succeed.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [CryptoKey][google.cloud.kms.v1.CryptoKey].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProtectedResourcesSummary GetProtectedResourcesSummary(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProtectedResourcesSummary(new GetProtectedResourcesSummaryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns aggregate information about the resources protected by the given
        /// Cloud KMS [CryptoKey][google.cloud.kms.v1.CryptoKey]. Only resources within
        /// the same Cloud organization as the key will be returned. The project that
        /// holds the key must be part of an organization in order for this call to
        /// succeed.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [CryptoKey][google.cloud.kms.v1.CryptoKey].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProtectedResourcesSummary> GetProtectedResourcesSummaryAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProtectedResourcesSummaryAsync(new GetProtectedResourcesSummaryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns aggregate information about the resources protected by the given
        /// Cloud KMS [CryptoKey][google.cloud.kms.v1.CryptoKey]. Only resources within
        /// the same Cloud organization as the key will be returned. The project that
        /// holds the key must be part of an organization in order for this call to
        /// succeed.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [CryptoKey][google.cloud.kms.v1.CryptoKey].
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProtectedResourcesSummary> GetProtectedResourcesSummaryAsync(string name, st::CancellationToken cancellationToken) =>
            GetProtectedResourcesSummaryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns aggregate information about the resources protected by the given
        /// Cloud KMS [CryptoKey][google.cloud.kms.v1.CryptoKey]. Only resources within
        /// the same Cloud organization as the key will be returned. The project that
        /// holds the key must be part of an organization in order for this call to
        /// succeed.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [CryptoKey][google.cloud.kms.v1.CryptoKey].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProtectedResourcesSummary GetProtectedResourcesSummary(ProtectedResourcesSummaryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProtectedResourcesSummary(new GetProtectedResourcesSummaryRequest
            {
                ProtectedResourcesSummaryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns aggregate information about the resources protected by the given
        /// Cloud KMS [CryptoKey][google.cloud.kms.v1.CryptoKey]. Only resources within
        /// the same Cloud organization as the key will be returned. The project that
        /// holds the key must be part of an organization in order for this call to
        /// succeed.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [CryptoKey][google.cloud.kms.v1.CryptoKey].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProtectedResourcesSummary> GetProtectedResourcesSummaryAsync(ProtectedResourcesSummaryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProtectedResourcesSummaryAsync(new GetProtectedResourcesSummaryRequest
            {
                ProtectedResourcesSummaryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns aggregate information about the resources protected by the given
        /// Cloud KMS [CryptoKey][google.cloud.kms.v1.CryptoKey]. Only resources within
        /// the same Cloud organization as the key will be returned. The project that
        /// holds the key must be part of an organization in order for this call to
        /// succeed.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [CryptoKey][google.cloud.kms.v1.CryptoKey].
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProtectedResourcesSummary> GetProtectedResourcesSummaryAsync(ProtectedResourcesSummaryName name, st::CancellationToken cancellationToken) =>
            GetProtectedResourcesSummaryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns metadata about the resources protected by the given Cloud KMS
        /// [CryptoKey][google.cloud.kms.v1.CryptoKey] in the given Cloud organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ProtectedResource"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchProtectedResourcesResponse, ProtectedResource> SearchProtectedResources(SearchProtectedResourcesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns metadata about the resources protected by the given Cloud KMS
        /// [CryptoKey][google.cloud.kms.v1.CryptoKey] in the given Cloud organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ProtectedResource"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchProtectedResourcesResponse, ProtectedResource> SearchProtectedResourcesAsync(SearchProtectedResourcesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns metadata about the resources protected by the given Cloud KMS
        /// [CryptoKey][google.cloud.kms.v1.CryptoKey] in the given Cloud organization.
        /// </summary>
        /// <param name="scope">
        /// Required. Resource name of the organization.
        /// Example: organizations/123
        /// </param>
        /// <param name="cryptoKey">
        /// Required. The resource name of the
        /// [CryptoKey][google.cloud.kms.v1.CryptoKey].
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
        /// <returns>A pageable sequence of <see cref="ProtectedResource"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchProtectedResourcesResponse, ProtectedResource> SearchProtectedResources(string scope, string cryptoKey, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchProtectedResourcesRequest request = new SearchProtectedResourcesRequest
            {
                Scope = gax::GaxPreconditions.CheckNotNullOrEmpty(scope, nameof(scope)),
                CryptoKey = gax::GaxPreconditions.CheckNotNullOrEmpty(cryptoKey, nameof(cryptoKey)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchProtectedResources(request, callSettings);
        }

        /// <summary>
        /// Returns metadata about the resources protected by the given Cloud KMS
        /// [CryptoKey][google.cloud.kms.v1.CryptoKey] in the given Cloud organization.
        /// </summary>
        /// <param name="scope">
        /// Required. Resource name of the organization.
        /// Example: organizations/123
        /// </param>
        /// <param name="cryptoKey">
        /// Required. The resource name of the
        /// [CryptoKey][google.cloud.kms.v1.CryptoKey].
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
        /// <returns>A pageable asynchronous sequence of <see cref="ProtectedResource"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchProtectedResourcesResponse, ProtectedResource> SearchProtectedResourcesAsync(string scope, string cryptoKey, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchProtectedResourcesRequest request = new SearchProtectedResourcesRequest
            {
                Scope = gax::GaxPreconditions.CheckNotNullOrEmpty(scope, nameof(scope)),
                CryptoKey = gax::GaxPreconditions.CheckNotNullOrEmpty(cryptoKey, nameof(cryptoKey)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchProtectedResourcesAsync(request, callSettings);
        }

        /// <summary>
        /// Returns metadata about the resources protected by the given Cloud KMS
        /// [CryptoKey][google.cloud.kms.v1.CryptoKey] in the given Cloud organization.
        /// </summary>
        /// <param name="scope">
        /// Required. Resource name of the organization.
        /// Example: organizations/123
        /// </param>
        /// <param name="cryptoKey">
        /// Required. The resource name of the
        /// [CryptoKey][google.cloud.kms.v1.CryptoKey].
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
        /// <returns>A pageable sequence of <see cref="ProtectedResource"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchProtectedResourcesResponse, ProtectedResource> SearchProtectedResources(gagr::OrganizationName scope, gax::IResourceName cryptoKey, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchProtectedResourcesRequest request = new SearchProtectedResourcesRequest
            {
                ScopeAsOrganizationName = gax::GaxPreconditions.CheckNotNull(scope, nameof(scope)),
                CryptoKeyAsResourceName = gax::GaxPreconditions.CheckNotNull(cryptoKey, nameof(cryptoKey)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchProtectedResources(request, callSettings);
        }

        /// <summary>
        /// Returns metadata about the resources protected by the given Cloud KMS
        /// [CryptoKey][google.cloud.kms.v1.CryptoKey] in the given Cloud organization.
        /// </summary>
        /// <param name="scope">
        /// Required. Resource name of the organization.
        /// Example: organizations/123
        /// </param>
        /// <param name="cryptoKey">
        /// Required. The resource name of the
        /// [CryptoKey][google.cloud.kms.v1.CryptoKey].
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
        /// <returns>A pageable asynchronous sequence of <see cref="ProtectedResource"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchProtectedResourcesResponse, ProtectedResource> SearchProtectedResourcesAsync(gagr::OrganizationName scope, gax::IResourceName cryptoKey, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchProtectedResourcesRequest request = new SearchProtectedResourcesRequest
            {
                ScopeAsOrganizationName = gax::GaxPreconditions.CheckNotNull(scope, nameof(scope)),
                CryptoKeyAsResourceName = gax::GaxPreconditions.CheckNotNull(cryptoKey, nameof(cryptoKey)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchProtectedResourcesAsync(request, callSettings);
        }
    }

    /// <summary>KeyTrackingService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Returns information about the resources in an org that are protected by a
    /// given Cloud KMS key via CMEK.
    /// </remarks>
    public sealed partial class KeyTrackingServiceClientImpl : KeyTrackingServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetProtectedResourcesSummaryRequest, ProtectedResourcesSummary> _callGetProtectedResourcesSummary;

        private readonly gaxgrpc::ApiCall<SearchProtectedResourcesRequest, SearchProtectedResourcesResponse> _callSearchProtectedResources;

        /// <summary>
        /// Constructs a client wrapper for the KeyTrackingService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="KeyTrackingServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public KeyTrackingServiceClientImpl(KeyTrackingService.KeyTrackingServiceClient grpcClient, KeyTrackingServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            KeyTrackingServiceSettings effectiveSettings = settings ?? KeyTrackingServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetProtectedResourcesSummary = clientHelper.BuildApiCall<GetProtectedResourcesSummaryRequest, ProtectedResourcesSummary>("GetProtectedResourcesSummary", grpcClient.GetProtectedResourcesSummaryAsync, grpcClient.GetProtectedResourcesSummary, effectiveSettings.GetProtectedResourcesSummarySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetProtectedResourcesSummary);
            Modify_GetProtectedResourcesSummaryApiCall(ref _callGetProtectedResourcesSummary);
            _callSearchProtectedResources = clientHelper.BuildApiCall<SearchProtectedResourcesRequest, SearchProtectedResourcesResponse>("SearchProtectedResources", grpcClient.SearchProtectedResourcesAsync, grpcClient.SearchProtectedResources, effectiveSettings.SearchProtectedResourcesSettings).WithGoogleRequestParam("scope", request => request.Scope);
            Modify_ApiCall(ref _callSearchProtectedResources);
            Modify_SearchProtectedResourcesApiCall(ref _callSearchProtectedResources);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetProtectedResourcesSummaryApiCall(ref gaxgrpc::ApiCall<GetProtectedResourcesSummaryRequest, ProtectedResourcesSummary> call);

        partial void Modify_SearchProtectedResourcesApiCall(ref gaxgrpc::ApiCall<SearchProtectedResourcesRequest, SearchProtectedResourcesResponse> call);

        partial void OnConstruction(KeyTrackingService.KeyTrackingServiceClient grpcClient, KeyTrackingServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC KeyTrackingService client</summary>
        public override KeyTrackingService.KeyTrackingServiceClient GrpcClient { get; }

        partial void Modify_GetProtectedResourcesSummaryRequest(ref GetProtectedResourcesSummaryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchProtectedResourcesRequest(ref SearchProtectedResourcesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns aggregate information about the resources protected by the given
        /// Cloud KMS [CryptoKey][google.cloud.kms.v1.CryptoKey]. Only resources within
        /// the same Cloud organization as the key will be returned. The project that
        /// holds the key must be part of an organization in order for this call to
        /// succeed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ProtectedResourcesSummary GetProtectedResourcesSummary(GetProtectedResourcesSummaryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProtectedResourcesSummaryRequest(ref request, ref callSettings);
            return _callGetProtectedResourcesSummary.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns aggregate information about the resources protected by the given
        /// Cloud KMS [CryptoKey][google.cloud.kms.v1.CryptoKey]. Only resources within
        /// the same Cloud organization as the key will be returned. The project that
        /// holds the key must be part of an organization in order for this call to
        /// succeed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ProtectedResourcesSummary> GetProtectedResourcesSummaryAsync(GetProtectedResourcesSummaryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProtectedResourcesSummaryRequest(ref request, ref callSettings);
            return _callGetProtectedResourcesSummary.Async(request, callSettings);
        }

        /// <summary>
        /// Returns metadata about the resources protected by the given Cloud KMS
        /// [CryptoKey][google.cloud.kms.v1.CryptoKey] in the given Cloud organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ProtectedResource"/> resources.</returns>
        public override gax::PagedEnumerable<SearchProtectedResourcesResponse, ProtectedResource> SearchProtectedResources(SearchProtectedResourcesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchProtectedResourcesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchProtectedResourcesRequest, SearchProtectedResourcesResponse, ProtectedResource>(_callSearchProtectedResources, request, callSettings);
        }

        /// <summary>
        /// Returns metadata about the resources protected by the given Cloud KMS
        /// [CryptoKey][google.cloud.kms.v1.CryptoKey] in the given Cloud organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ProtectedResource"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchProtectedResourcesResponse, ProtectedResource> SearchProtectedResourcesAsync(SearchProtectedResourcesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchProtectedResourcesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchProtectedResourcesRequest, SearchProtectedResourcesResponse, ProtectedResource>(_callSearchProtectedResources, request, callSettings);
        }
    }

    public partial class SearchProtectedResourcesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchProtectedResourcesResponse : gaxgrpc::IPageResponse<ProtectedResource>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ProtectedResource> GetEnumerator() => ProtectedResources.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
