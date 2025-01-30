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
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Iap.V1
{
    /// <summary>Settings for <see cref="IdentityAwareProxyOAuthServiceClient"/> instances.</summary>
    public sealed partial class IdentityAwareProxyOAuthServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="IdentityAwareProxyOAuthServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="IdentityAwareProxyOAuthServiceSettings"/>.</returns>
        public static IdentityAwareProxyOAuthServiceSettings GetDefault() => new IdentityAwareProxyOAuthServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="IdentityAwareProxyOAuthServiceSettings"/> object with default settings.
        /// </summary>
        public IdentityAwareProxyOAuthServiceSettings()
        {
        }

        private IdentityAwareProxyOAuthServiceSettings(IdentityAwareProxyOAuthServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListBrandsSettings = existing.ListBrandsSettings;
            CreateBrandSettings = existing.CreateBrandSettings;
            GetBrandSettings = existing.GetBrandSettings;
            CreateIdentityAwareProxyClientSettings = existing.CreateIdentityAwareProxyClientSettings;
            ListIdentityAwareProxyClientsSettings = existing.ListIdentityAwareProxyClientsSettings;
            GetIdentityAwareProxyClientSettings = existing.GetIdentityAwareProxyClientSettings;
            ResetIdentityAwareProxyClientSecretSettings = existing.ResetIdentityAwareProxyClientSecretSettings;
            DeleteIdentityAwareProxyClientSettings = existing.DeleteIdentityAwareProxyClientSettings;
            OnCopy(existing);
        }

        partial void OnCopy(IdentityAwareProxyOAuthServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IdentityAwareProxyOAuthServiceClient.ListBrands</c> and
        /// <c>IdentityAwareProxyOAuthServiceClient.ListBrandsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListBrandsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IdentityAwareProxyOAuthServiceClient.CreateBrand</c> and
        /// <c>IdentityAwareProxyOAuthServiceClient.CreateBrandAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateBrandSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IdentityAwareProxyOAuthServiceClient.GetBrand</c> and
        /// <c>IdentityAwareProxyOAuthServiceClient.GetBrandAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetBrandSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IdentityAwareProxyOAuthServiceClient.CreateIdentityAwareProxyClient</c> and
        /// <c>IdentityAwareProxyOAuthServiceClient.CreateIdentityAwareProxyClientAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateIdentityAwareProxyClientSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IdentityAwareProxyOAuthServiceClient.ListIdentityAwareProxyClients</c> and
        /// <c>IdentityAwareProxyOAuthServiceClient.ListIdentityAwareProxyClientsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListIdentityAwareProxyClientsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IdentityAwareProxyOAuthServiceClient.GetIdentityAwareProxyClient</c> and
        /// <c>IdentityAwareProxyOAuthServiceClient.GetIdentityAwareProxyClientAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIdentityAwareProxyClientSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IdentityAwareProxyOAuthServiceClient.ResetIdentityAwareProxyClientSecret</c> and
        /// <c>IdentityAwareProxyOAuthServiceClient.ResetIdentityAwareProxyClientSecretAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ResetIdentityAwareProxyClientSecretSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IdentityAwareProxyOAuthServiceClient.DeleteIdentityAwareProxyClient</c> and
        /// <c>IdentityAwareProxyOAuthServiceClient.DeleteIdentityAwareProxyClientAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteIdentityAwareProxyClientSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="IdentityAwareProxyOAuthServiceSettings"/> object.</returns>
        public IdentityAwareProxyOAuthServiceSettings Clone() => new IdentityAwareProxyOAuthServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="IdentityAwareProxyOAuthServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class IdentityAwareProxyOAuthServiceClientBuilder : gaxgrpc::ClientBuilderBase<IdentityAwareProxyOAuthServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public IdentityAwareProxyOAuthServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public IdentityAwareProxyOAuthServiceClientBuilder() : base(IdentityAwareProxyOAuthServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref IdentityAwareProxyOAuthServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<IdentityAwareProxyOAuthServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override IdentityAwareProxyOAuthServiceClient Build()
        {
            IdentityAwareProxyOAuthServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<IdentityAwareProxyOAuthServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<IdentityAwareProxyOAuthServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private IdentityAwareProxyOAuthServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return IdentityAwareProxyOAuthServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<IdentityAwareProxyOAuthServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return IdentityAwareProxyOAuthServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => IdentityAwareProxyOAuthServiceClient.ChannelPool;
    }

    /// <summary>IdentityAwareProxyOAuthService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// API to programmatically create, list and retrieve Identity Aware Proxy (IAP)
    /// OAuth brands; and create, retrieve, delete and reset-secret of IAP OAuth
    /// clients.
    /// </remarks>
    public abstract partial class IdentityAwareProxyOAuthServiceClient
    {
        /// <summary>
        /// The default endpoint for the IdentityAwareProxyOAuthService service, which is a host of "iap.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "iap.googleapis.com:443";

        /// <summary>The default IdentityAwareProxyOAuthService scopes.</summary>
        /// <remarks>
        /// The default IdentityAwareProxyOAuthService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(IdentityAwareProxyOAuthService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="IdentityAwareProxyOAuthServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="IdentityAwareProxyOAuthServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="IdentityAwareProxyOAuthServiceClient"/>.</returns>
        public static stt::Task<IdentityAwareProxyOAuthServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new IdentityAwareProxyOAuthServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="IdentityAwareProxyOAuthServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="IdentityAwareProxyOAuthServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="IdentityAwareProxyOAuthServiceClient"/>.</returns>
        public static IdentityAwareProxyOAuthServiceClient Create() =>
            new IdentityAwareProxyOAuthServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="IdentityAwareProxyOAuthServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="IdentityAwareProxyOAuthServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="IdentityAwareProxyOAuthServiceClient"/>.</returns>
        internal static IdentityAwareProxyOAuthServiceClient Create(grpccore::CallInvoker callInvoker, IdentityAwareProxyOAuthServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            IdentityAwareProxyOAuthService.IdentityAwareProxyOAuthServiceClient grpcClient = new IdentityAwareProxyOAuthService.IdentityAwareProxyOAuthServiceClient(callInvoker);
            return new IdentityAwareProxyOAuthServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC IdentityAwareProxyOAuthService client</summary>
        public virtual IdentityAwareProxyOAuthService.IdentityAwareProxyOAuthServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the existing brands for the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListBrandsResponse ListBrands(ListBrandsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the existing brands for the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListBrandsResponse> ListBrandsAsync(ListBrandsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the existing brands for the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListBrandsResponse> ListBrandsAsync(ListBrandsRequest request, st::CancellationToken cancellationToken) =>
            ListBrandsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Constructs a new OAuth brand for the project if one does not exist.
        /// The created brand is "internal only", meaning that OAuth clients created
        /// under it only accept requests from users who belong to the same Google
        /// Workspace organization as the project. The brand is created in an
        /// un-reviewed status. NOTE: The "internal only" status can be manually
        /// changed in the Google Cloud Console. Requires that a brand does not already
        /// exist for the project, and that the specified support email is owned by the
        /// caller.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Brand CreateBrand(CreateBrandRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Constructs a new OAuth brand for the project if one does not exist.
        /// The created brand is "internal only", meaning that OAuth clients created
        /// under it only accept requests from users who belong to the same Google
        /// Workspace organization as the project. The brand is created in an
        /// un-reviewed status. NOTE: The "internal only" status can be manually
        /// changed in the Google Cloud Console. Requires that a brand does not already
        /// exist for the project, and that the specified support email is owned by the
        /// caller.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Brand> CreateBrandAsync(CreateBrandRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Constructs a new OAuth brand for the project if one does not exist.
        /// The created brand is "internal only", meaning that OAuth clients created
        /// under it only accept requests from users who belong to the same Google
        /// Workspace organization as the project. The brand is created in an
        /// un-reviewed status. NOTE: The "internal only" status can be manually
        /// changed in the Google Cloud Console. Requires that a brand does not already
        /// exist for the project, and that the specified support email is owned by the
        /// caller.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Brand> CreateBrandAsync(CreateBrandRequest request, st::CancellationToken cancellationToken) =>
            CreateBrandAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the OAuth brand of the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Brand GetBrand(GetBrandRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the OAuth brand of the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Brand> GetBrandAsync(GetBrandRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the OAuth brand of the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Brand> GetBrandAsync(GetBrandRequest request, st::CancellationToken cancellationToken) =>
            GetBrandAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an Identity Aware Proxy (IAP) OAuth client. The client is owned
        /// by IAP. Requires that the brand for the project exists and that it is
        /// set for internal-only use.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IdentityAwareProxyClient CreateIdentityAwareProxyClient(CreateIdentityAwareProxyClientRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an Identity Aware Proxy (IAP) OAuth client. The client is owned
        /// by IAP. Requires that the brand for the project exists and that it is
        /// set for internal-only use.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IdentityAwareProxyClient> CreateIdentityAwareProxyClientAsync(CreateIdentityAwareProxyClientRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an Identity Aware Proxy (IAP) OAuth client. The client is owned
        /// by IAP. Requires that the brand for the project exists and that it is
        /// set for internal-only use.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IdentityAwareProxyClient> CreateIdentityAwareProxyClientAsync(CreateIdentityAwareProxyClientRequest request, st::CancellationToken cancellationToken) =>
            CreateIdentityAwareProxyClientAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the existing clients for the brand.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="IdentityAwareProxyClient"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListIdentityAwareProxyClientsResponse, IdentityAwareProxyClient> ListIdentityAwareProxyClients(ListIdentityAwareProxyClientsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the existing clients for the brand.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="IdentityAwareProxyClient"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListIdentityAwareProxyClientsResponse, IdentityAwareProxyClient> ListIdentityAwareProxyClientsAsync(ListIdentityAwareProxyClientsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an Identity Aware Proxy (IAP) OAuth client.
        /// Requires that the client is owned by IAP.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IdentityAwareProxyClient GetIdentityAwareProxyClient(GetIdentityAwareProxyClientRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an Identity Aware Proxy (IAP) OAuth client.
        /// Requires that the client is owned by IAP.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IdentityAwareProxyClient> GetIdentityAwareProxyClientAsync(GetIdentityAwareProxyClientRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an Identity Aware Proxy (IAP) OAuth client.
        /// Requires that the client is owned by IAP.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IdentityAwareProxyClient> GetIdentityAwareProxyClientAsync(GetIdentityAwareProxyClientRequest request, st::CancellationToken cancellationToken) =>
            GetIdentityAwareProxyClientAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resets an Identity Aware Proxy (IAP) OAuth client secret. Useful if the
        /// secret was compromised. Requires that the client is owned by IAP.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IdentityAwareProxyClient ResetIdentityAwareProxyClientSecret(ResetIdentityAwareProxyClientSecretRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resets an Identity Aware Proxy (IAP) OAuth client secret. Useful if the
        /// secret was compromised. Requires that the client is owned by IAP.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IdentityAwareProxyClient> ResetIdentityAwareProxyClientSecretAsync(ResetIdentityAwareProxyClientSecretRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resets an Identity Aware Proxy (IAP) OAuth client secret. Useful if the
        /// secret was compromised. Requires that the client is owned by IAP.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IdentityAwareProxyClient> ResetIdentityAwareProxyClientSecretAsync(ResetIdentityAwareProxyClientSecretRequest request, st::CancellationToken cancellationToken) =>
            ResetIdentityAwareProxyClientSecretAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an Identity Aware Proxy (IAP) OAuth client. Useful for removing
        /// obsolete clients, managing the number of clients in a given project, and
        /// cleaning up after tests. Requires that the client is owned by IAP.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteIdentityAwareProxyClient(DeleteIdentityAwareProxyClientRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an Identity Aware Proxy (IAP) OAuth client. Useful for removing
        /// obsolete clients, managing the number of clients in a given project, and
        /// cleaning up after tests. Requires that the client is owned by IAP.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteIdentityAwareProxyClientAsync(DeleteIdentityAwareProxyClientRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an Identity Aware Proxy (IAP) OAuth client. Useful for removing
        /// obsolete clients, managing the number of clients in a given project, and
        /// cleaning up after tests. Requires that the client is owned by IAP.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteIdentityAwareProxyClientAsync(DeleteIdentityAwareProxyClientRequest request, st::CancellationToken cancellationToken) =>
            DeleteIdentityAwareProxyClientAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>IdentityAwareProxyOAuthService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// API to programmatically create, list and retrieve Identity Aware Proxy (IAP)
    /// OAuth brands; and create, retrieve, delete and reset-secret of IAP OAuth
    /// clients.
    /// </remarks>
    public sealed partial class IdentityAwareProxyOAuthServiceClientImpl : IdentityAwareProxyOAuthServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListBrandsRequest, ListBrandsResponse> _callListBrands;

        private readonly gaxgrpc::ApiCall<CreateBrandRequest, Brand> _callCreateBrand;

        private readonly gaxgrpc::ApiCall<GetBrandRequest, Brand> _callGetBrand;

        private readonly gaxgrpc::ApiCall<CreateIdentityAwareProxyClientRequest, IdentityAwareProxyClient> _callCreateIdentityAwareProxyClient;

        private readonly gaxgrpc::ApiCall<ListIdentityAwareProxyClientsRequest, ListIdentityAwareProxyClientsResponse> _callListIdentityAwareProxyClients;

        private readonly gaxgrpc::ApiCall<GetIdentityAwareProxyClientRequest, IdentityAwareProxyClient> _callGetIdentityAwareProxyClient;

        private readonly gaxgrpc::ApiCall<ResetIdentityAwareProxyClientSecretRequest, IdentityAwareProxyClient> _callResetIdentityAwareProxyClientSecret;

        private readonly gaxgrpc::ApiCall<DeleteIdentityAwareProxyClientRequest, wkt::Empty> _callDeleteIdentityAwareProxyClient;

        /// <summary>
        /// Constructs a client wrapper for the IdentityAwareProxyOAuthService service, with the specified gRPC client
        /// and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="IdentityAwareProxyOAuthServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public IdentityAwareProxyOAuthServiceClientImpl(IdentityAwareProxyOAuthService.IdentityAwareProxyOAuthServiceClient grpcClient, IdentityAwareProxyOAuthServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            IdentityAwareProxyOAuthServiceSettings effectiveSettings = settings ?? IdentityAwareProxyOAuthServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callListBrands = clientHelper.BuildApiCall<ListBrandsRequest, ListBrandsResponse>("ListBrands", grpcClient.ListBrandsAsync, grpcClient.ListBrands, effectiveSettings.ListBrandsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListBrands);
            Modify_ListBrandsApiCall(ref _callListBrands);
            _callCreateBrand = clientHelper.BuildApiCall<CreateBrandRequest, Brand>("CreateBrand", grpcClient.CreateBrandAsync, grpcClient.CreateBrand, effectiveSettings.CreateBrandSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateBrand);
            Modify_CreateBrandApiCall(ref _callCreateBrand);
            _callGetBrand = clientHelper.BuildApiCall<GetBrandRequest, Brand>("GetBrand", grpcClient.GetBrandAsync, grpcClient.GetBrand, effectiveSettings.GetBrandSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetBrand);
            Modify_GetBrandApiCall(ref _callGetBrand);
            _callCreateIdentityAwareProxyClient = clientHelper.BuildApiCall<CreateIdentityAwareProxyClientRequest, IdentityAwareProxyClient>("CreateIdentityAwareProxyClient", grpcClient.CreateIdentityAwareProxyClientAsync, grpcClient.CreateIdentityAwareProxyClient, effectiveSettings.CreateIdentityAwareProxyClientSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateIdentityAwareProxyClient);
            Modify_CreateIdentityAwareProxyClientApiCall(ref _callCreateIdentityAwareProxyClient);
            _callListIdentityAwareProxyClients = clientHelper.BuildApiCall<ListIdentityAwareProxyClientsRequest, ListIdentityAwareProxyClientsResponse>("ListIdentityAwareProxyClients", grpcClient.ListIdentityAwareProxyClientsAsync, grpcClient.ListIdentityAwareProxyClients, effectiveSettings.ListIdentityAwareProxyClientsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListIdentityAwareProxyClients);
            Modify_ListIdentityAwareProxyClientsApiCall(ref _callListIdentityAwareProxyClients);
            _callGetIdentityAwareProxyClient = clientHelper.BuildApiCall<GetIdentityAwareProxyClientRequest, IdentityAwareProxyClient>("GetIdentityAwareProxyClient", grpcClient.GetIdentityAwareProxyClientAsync, grpcClient.GetIdentityAwareProxyClient, effectiveSettings.GetIdentityAwareProxyClientSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetIdentityAwareProxyClient);
            Modify_GetIdentityAwareProxyClientApiCall(ref _callGetIdentityAwareProxyClient);
            _callResetIdentityAwareProxyClientSecret = clientHelper.BuildApiCall<ResetIdentityAwareProxyClientSecretRequest, IdentityAwareProxyClient>("ResetIdentityAwareProxyClientSecret", grpcClient.ResetIdentityAwareProxyClientSecretAsync, grpcClient.ResetIdentityAwareProxyClientSecret, effectiveSettings.ResetIdentityAwareProxyClientSecretSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callResetIdentityAwareProxyClientSecret);
            Modify_ResetIdentityAwareProxyClientSecretApiCall(ref _callResetIdentityAwareProxyClientSecret);
            _callDeleteIdentityAwareProxyClient = clientHelper.BuildApiCall<DeleteIdentityAwareProxyClientRequest, wkt::Empty>("DeleteIdentityAwareProxyClient", grpcClient.DeleteIdentityAwareProxyClientAsync, grpcClient.DeleteIdentityAwareProxyClient, effectiveSettings.DeleteIdentityAwareProxyClientSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteIdentityAwareProxyClient);
            Modify_DeleteIdentityAwareProxyClientApiCall(ref _callDeleteIdentityAwareProxyClient);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListBrandsApiCall(ref gaxgrpc::ApiCall<ListBrandsRequest, ListBrandsResponse> call);

        partial void Modify_CreateBrandApiCall(ref gaxgrpc::ApiCall<CreateBrandRequest, Brand> call);

        partial void Modify_GetBrandApiCall(ref gaxgrpc::ApiCall<GetBrandRequest, Brand> call);

        partial void Modify_CreateIdentityAwareProxyClientApiCall(ref gaxgrpc::ApiCall<CreateIdentityAwareProxyClientRequest, IdentityAwareProxyClient> call);

        partial void Modify_ListIdentityAwareProxyClientsApiCall(ref gaxgrpc::ApiCall<ListIdentityAwareProxyClientsRequest, ListIdentityAwareProxyClientsResponse> call);

        partial void Modify_GetIdentityAwareProxyClientApiCall(ref gaxgrpc::ApiCall<GetIdentityAwareProxyClientRequest, IdentityAwareProxyClient> call);

        partial void Modify_ResetIdentityAwareProxyClientSecretApiCall(ref gaxgrpc::ApiCall<ResetIdentityAwareProxyClientSecretRequest, IdentityAwareProxyClient> call);

        partial void Modify_DeleteIdentityAwareProxyClientApiCall(ref gaxgrpc::ApiCall<DeleteIdentityAwareProxyClientRequest, wkt::Empty> call);

        partial void OnConstruction(IdentityAwareProxyOAuthService.IdentityAwareProxyOAuthServiceClient grpcClient, IdentityAwareProxyOAuthServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC IdentityAwareProxyOAuthService client</summary>
        public override IdentityAwareProxyOAuthService.IdentityAwareProxyOAuthServiceClient GrpcClient { get; }

        partial void Modify_ListBrandsRequest(ref ListBrandsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateBrandRequest(ref CreateBrandRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetBrandRequest(ref GetBrandRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateIdentityAwareProxyClientRequest(ref CreateIdentityAwareProxyClientRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListIdentityAwareProxyClientsRequest(ref ListIdentityAwareProxyClientsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIdentityAwareProxyClientRequest(ref GetIdentityAwareProxyClientRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ResetIdentityAwareProxyClientSecretRequest(ref ResetIdentityAwareProxyClientSecretRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteIdentityAwareProxyClientRequest(ref DeleteIdentityAwareProxyClientRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists the existing brands for the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListBrandsResponse ListBrands(ListBrandsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBrandsRequest(ref request, ref callSettings);
            return _callListBrands.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists the existing brands for the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListBrandsResponse> ListBrandsAsync(ListBrandsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBrandsRequest(ref request, ref callSettings);
            return _callListBrands.Async(request, callSettings);
        }

        /// <summary>
        /// Constructs a new OAuth brand for the project if one does not exist.
        /// The created brand is "internal only", meaning that OAuth clients created
        /// under it only accept requests from users who belong to the same Google
        /// Workspace organization as the project. The brand is created in an
        /// un-reviewed status. NOTE: The "internal only" status can be manually
        /// changed in the Google Cloud Console. Requires that a brand does not already
        /// exist for the project, and that the specified support email is owned by the
        /// caller.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Brand CreateBrand(CreateBrandRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBrandRequest(ref request, ref callSettings);
            return _callCreateBrand.Sync(request, callSettings);
        }

        /// <summary>
        /// Constructs a new OAuth brand for the project if one does not exist.
        /// The created brand is "internal only", meaning that OAuth clients created
        /// under it only accept requests from users who belong to the same Google
        /// Workspace organization as the project. The brand is created in an
        /// un-reviewed status. NOTE: The "internal only" status can be manually
        /// changed in the Google Cloud Console. Requires that a brand does not already
        /// exist for the project, and that the specified support email is owned by the
        /// caller.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Brand> CreateBrandAsync(CreateBrandRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBrandRequest(ref request, ref callSettings);
            return _callCreateBrand.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves the OAuth brand of the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Brand GetBrand(GetBrandRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBrandRequest(ref request, ref callSettings);
            return _callGetBrand.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the OAuth brand of the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Brand> GetBrandAsync(GetBrandRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBrandRequest(ref request, ref callSettings);
            return _callGetBrand.Async(request, callSettings);
        }

        /// <summary>
        /// Creates an Identity Aware Proxy (IAP) OAuth client. The client is owned
        /// by IAP. Requires that the brand for the project exists and that it is
        /// set for internal-only use.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override IdentityAwareProxyClient CreateIdentityAwareProxyClient(CreateIdentityAwareProxyClientRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateIdentityAwareProxyClientRequest(ref request, ref callSettings);
            return _callCreateIdentityAwareProxyClient.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an Identity Aware Proxy (IAP) OAuth client. The client is owned
        /// by IAP. Requires that the brand for the project exists and that it is
        /// set for internal-only use.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<IdentityAwareProxyClient> CreateIdentityAwareProxyClientAsync(CreateIdentityAwareProxyClientRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateIdentityAwareProxyClientRequest(ref request, ref callSettings);
            return _callCreateIdentityAwareProxyClient.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the existing clients for the brand.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="IdentityAwareProxyClient"/> resources.</returns>
        public override gax::PagedEnumerable<ListIdentityAwareProxyClientsResponse, IdentityAwareProxyClient> ListIdentityAwareProxyClients(ListIdentityAwareProxyClientsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListIdentityAwareProxyClientsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListIdentityAwareProxyClientsRequest, ListIdentityAwareProxyClientsResponse, IdentityAwareProxyClient>(_callListIdentityAwareProxyClients, request, callSettings);
        }

        /// <summary>
        /// Lists the existing clients for the brand.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="IdentityAwareProxyClient"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListIdentityAwareProxyClientsResponse, IdentityAwareProxyClient> ListIdentityAwareProxyClientsAsync(ListIdentityAwareProxyClientsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListIdentityAwareProxyClientsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListIdentityAwareProxyClientsRequest, ListIdentityAwareProxyClientsResponse, IdentityAwareProxyClient>(_callListIdentityAwareProxyClients, request, callSettings);
        }

        /// <summary>
        /// Retrieves an Identity Aware Proxy (IAP) OAuth client.
        /// Requires that the client is owned by IAP.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override IdentityAwareProxyClient GetIdentityAwareProxyClient(GetIdentityAwareProxyClientRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIdentityAwareProxyClientRequest(ref request, ref callSettings);
            return _callGetIdentityAwareProxyClient.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves an Identity Aware Proxy (IAP) OAuth client.
        /// Requires that the client is owned by IAP.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<IdentityAwareProxyClient> GetIdentityAwareProxyClientAsync(GetIdentityAwareProxyClientRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIdentityAwareProxyClientRequest(ref request, ref callSettings);
            return _callGetIdentityAwareProxyClient.Async(request, callSettings);
        }

        /// <summary>
        /// Resets an Identity Aware Proxy (IAP) OAuth client secret. Useful if the
        /// secret was compromised. Requires that the client is owned by IAP.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override IdentityAwareProxyClient ResetIdentityAwareProxyClientSecret(ResetIdentityAwareProxyClientSecretRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResetIdentityAwareProxyClientSecretRequest(ref request, ref callSettings);
            return _callResetIdentityAwareProxyClientSecret.Sync(request, callSettings);
        }

        /// <summary>
        /// Resets an Identity Aware Proxy (IAP) OAuth client secret. Useful if the
        /// secret was compromised. Requires that the client is owned by IAP.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<IdentityAwareProxyClient> ResetIdentityAwareProxyClientSecretAsync(ResetIdentityAwareProxyClientSecretRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResetIdentityAwareProxyClientSecretRequest(ref request, ref callSettings);
            return _callResetIdentityAwareProxyClientSecret.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an Identity Aware Proxy (IAP) OAuth client. Useful for removing
        /// obsolete clients, managing the number of clients in a given project, and
        /// cleaning up after tests. Requires that the client is owned by IAP.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteIdentityAwareProxyClient(DeleteIdentityAwareProxyClientRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteIdentityAwareProxyClientRequest(ref request, ref callSettings);
            _callDeleteIdentityAwareProxyClient.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an Identity Aware Proxy (IAP) OAuth client. Useful for removing
        /// obsolete clients, managing the number of clients in a given project, and
        /// cleaning up after tests. Requires that the client is owned by IAP.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteIdentityAwareProxyClientAsync(DeleteIdentityAwareProxyClientRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteIdentityAwareProxyClientRequest(ref request, ref callSettings);
            return _callDeleteIdentityAwareProxyClient.Async(request, callSettings);
        }
    }

    public partial class ListIdentityAwareProxyClientsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListIdentityAwareProxyClientsResponse : gaxgrpc::IPageResponse<IdentityAwareProxyClient>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<IdentityAwareProxyClient> GetEnumerator() => IdentityAwareProxyClients.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
