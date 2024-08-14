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
using gciv = Google.Cloud.Iam.V1;
using gcl = Google.Cloud.Location;
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

namespace Google.Cloud.AIPlatform.V1Beta1
{
    /// <summary>Settings for <see cref="GenAiCacheServiceClient"/> instances.</summary>
    public sealed partial class GenAiCacheServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="GenAiCacheServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="GenAiCacheServiceSettings"/>.</returns>
        public static GenAiCacheServiceSettings GetDefault() => new GenAiCacheServiceSettings();

        /// <summary>Constructs a new <see cref="GenAiCacheServiceSettings"/> object with default settings.</summary>
        public GenAiCacheServiceSettings()
        {
        }

        private GenAiCacheServiceSettings(GenAiCacheServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateCachedContentSettings = existing.CreateCachedContentSettings;
            GetCachedContentSettings = existing.GetCachedContentSettings;
            UpdateCachedContentSettings = existing.UpdateCachedContentSettings;
            DeleteCachedContentSettings = existing.DeleteCachedContentSettings;
            ListCachedContentsSettings = existing.ListCachedContentsSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(GenAiCacheServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GenAiCacheServiceClient.CreateCachedContent</c> and <c>GenAiCacheServiceClient.CreateCachedContentAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateCachedContentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GenAiCacheServiceClient.GetCachedContent</c> and <c>GenAiCacheServiceClient.GetCachedContentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCachedContentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GenAiCacheServiceClient.UpdateCachedContent</c> and <c>GenAiCacheServiceClient.UpdateCachedContentAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateCachedContentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GenAiCacheServiceClient.DeleteCachedContent</c> and <c>GenAiCacheServiceClient.DeleteCachedContentAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteCachedContentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GenAiCacheServiceClient.ListCachedContents</c> and <c>GenAiCacheServiceClient.ListCachedContentsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCachedContentsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="GenAiCacheServiceSettings"/> object.</returns>
        public GenAiCacheServiceSettings Clone() => new GenAiCacheServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="GenAiCacheServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class GenAiCacheServiceClientBuilder : gaxgrpc::ClientBuilderBase<GenAiCacheServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public GenAiCacheServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public GenAiCacheServiceClientBuilder() : base(GenAiCacheServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref GenAiCacheServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<GenAiCacheServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override GenAiCacheServiceClient Build()
        {
            GenAiCacheServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<GenAiCacheServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<GenAiCacheServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private GenAiCacheServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return GenAiCacheServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<GenAiCacheServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return GenAiCacheServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => GenAiCacheServiceClient.ChannelPool;
    }

    /// <summary>GenAiCacheService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing Vertex AI's CachedContent resource.
    /// </remarks>
    public abstract partial class GenAiCacheServiceClient
    {
        /// <summary>
        /// The default endpoint for the GenAiCacheService service, which is a host of "aiplatform.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "aiplatform.googleapis.com:443";

        /// <summary>The default GenAiCacheService scopes.</summary>
        /// <remarks>
        /// The default GenAiCacheService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(GenAiCacheService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="GenAiCacheServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="GenAiCacheServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="GenAiCacheServiceClient"/>.</returns>
        public static stt::Task<GenAiCacheServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new GenAiCacheServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="GenAiCacheServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="GenAiCacheServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="GenAiCacheServiceClient"/>.</returns>
        public static GenAiCacheServiceClient Create() => new GenAiCacheServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="GenAiCacheServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="GenAiCacheServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="GenAiCacheServiceClient"/>.</returns>
        internal static GenAiCacheServiceClient Create(grpccore::CallInvoker callInvoker, GenAiCacheServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            GenAiCacheService.GenAiCacheServiceClient grpcClient = new GenAiCacheService.GenAiCacheServiceClient(callInvoker);
            return new GenAiCacheServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC GenAiCacheService client</summary>
        public virtual GenAiCacheService.GenAiCacheServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates cached content, this call will initialize the cached content in the
        /// data storage, and users need to pay for the cache data storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CachedContent CreateCachedContent(CreateCachedContentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates cached content, this call will initialize the cached content in the
        /// data storage, and users need to pay for the cache data storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CachedContent> CreateCachedContentAsync(CreateCachedContentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates cached content, this call will initialize the cached content in the
        /// data storage, and users need to pay for the cache data storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CachedContent> CreateCachedContentAsync(CreateCachedContentRequest request, st::CancellationToken cancellationToken) =>
            CreateCachedContentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates cached content, this call will initialize the cached content in the
        /// data storage, and users need to pay for the cache data storage.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where the cached content will be created
        /// </param>
        /// <param name="cachedContent">
        /// Required. The cached content to create
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CachedContent CreateCachedContent(string parent, CachedContent cachedContent, gaxgrpc::CallSettings callSettings = null) =>
            CreateCachedContent(new CreateCachedContentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CachedContent = gax::GaxPreconditions.CheckNotNull(cachedContent, nameof(cachedContent)),
            }, callSettings);

        /// <summary>
        /// Creates cached content, this call will initialize the cached content in the
        /// data storage, and users need to pay for the cache data storage.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where the cached content will be created
        /// </param>
        /// <param name="cachedContent">
        /// Required. The cached content to create
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CachedContent> CreateCachedContentAsync(string parent, CachedContent cachedContent, gaxgrpc::CallSettings callSettings = null) =>
            CreateCachedContentAsync(new CreateCachedContentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CachedContent = gax::GaxPreconditions.CheckNotNull(cachedContent, nameof(cachedContent)),
            }, callSettings);

        /// <summary>
        /// Creates cached content, this call will initialize the cached content in the
        /// data storage, and users need to pay for the cache data storage.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where the cached content will be created
        /// </param>
        /// <param name="cachedContent">
        /// Required. The cached content to create
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CachedContent> CreateCachedContentAsync(string parent, CachedContent cachedContent, st::CancellationToken cancellationToken) =>
            CreateCachedContentAsync(parent, cachedContent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates cached content, this call will initialize the cached content in the
        /// data storage, and users need to pay for the cache data storage.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where the cached content will be created
        /// </param>
        /// <param name="cachedContent">
        /// Required. The cached content to create
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CachedContent CreateCachedContent(gagr::LocationName parent, CachedContent cachedContent, gaxgrpc::CallSettings callSettings = null) =>
            CreateCachedContent(new CreateCachedContentRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CachedContent = gax::GaxPreconditions.CheckNotNull(cachedContent, nameof(cachedContent)),
            }, callSettings);

        /// <summary>
        /// Creates cached content, this call will initialize the cached content in the
        /// data storage, and users need to pay for the cache data storage.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where the cached content will be created
        /// </param>
        /// <param name="cachedContent">
        /// Required. The cached content to create
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CachedContent> CreateCachedContentAsync(gagr::LocationName parent, CachedContent cachedContent, gaxgrpc::CallSettings callSettings = null) =>
            CreateCachedContentAsync(new CreateCachedContentRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CachedContent = gax::GaxPreconditions.CheckNotNull(cachedContent, nameof(cachedContent)),
            }, callSettings);

        /// <summary>
        /// Creates cached content, this call will initialize the cached content in the
        /// data storage, and users need to pay for the cache data storage.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where the cached content will be created
        /// </param>
        /// <param name="cachedContent">
        /// Required. The cached content to create
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CachedContent> CreateCachedContentAsync(gagr::LocationName parent, CachedContent cachedContent, st::CancellationToken cancellationToken) =>
            CreateCachedContentAsync(parent, cachedContent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets cached content configurations
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CachedContent GetCachedContent(GetCachedContentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets cached content configurations
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CachedContent> GetCachedContentAsync(GetCachedContentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets cached content configurations
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CachedContent> GetCachedContentAsync(GetCachedContentRequest request, st::CancellationToken cancellationToken) =>
            GetCachedContentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets cached content configurations
        /// </summary>
        /// <param name="name">
        /// Required. The resource name referring to the cached content
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CachedContent GetCachedContent(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCachedContent(new GetCachedContentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets cached content configurations
        /// </summary>
        /// <param name="name">
        /// Required. The resource name referring to the cached content
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CachedContent> GetCachedContentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCachedContentAsync(new GetCachedContentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets cached content configurations
        /// </summary>
        /// <param name="name">
        /// Required. The resource name referring to the cached content
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CachedContent> GetCachedContentAsync(string name, st::CancellationToken cancellationToken) =>
            GetCachedContentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets cached content configurations
        /// </summary>
        /// <param name="name">
        /// Required. The resource name referring to the cached content
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CachedContent GetCachedContent(CachedContentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCachedContent(new GetCachedContentRequest
            {
                CachedContentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets cached content configurations
        /// </summary>
        /// <param name="name">
        /// Required. The resource name referring to the cached content
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CachedContent> GetCachedContentAsync(CachedContentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCachedContentAsync(new GetCachedContentRequest
            {
                CachedContentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets cached content configurations
        /// </summary>
        /// <param name="name">
        /// Required. The resource name referring to the cached content
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CachedContent> GetCachedContentAsync(CachedContentName name, st::CancellationToken cancellationToken) =>
            GetCachedContentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates cached content configurations
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CachedContent UpdateCachedContent(UpdateCachedContentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates cached content configurations
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CachedContent> UpdateCachedContentAsync(UpdateCachedContentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates cached content configurations
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CachedContent> UpdateCachedContentAsync(UpdateCachedContentRequest request, st::CancellationToken cancellationToken) =>
            UpdateCachedContentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates cached content configurations
        /// </summary>
        /// <param name="cachedContent">
        /// Required. The cached content to update
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CachedContent UpdateCachedContent(CachedContent cachedContent, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCachedContent(new UpdateCachedContentRequest
            {
                CachedContent = gax::GaxPreconditions.CheckNotNull(cachedContent, nameof(cachedContent)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates cached content configurations
        /// </summary>
        /// <param name="cachedContent">
        /// Required. The cached content to update
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CachedContent> UpdateCachedContentAsync(CachedContent cachedContent, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCachedContentAsync(new UpdateCachedContentRequest
            {
                CachedContent = gax::GaxPreconditions.CheckNotNull(cachedContent, nameof(cachedContent)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates cached content configurations
        /// </summary>
        /// <param name="cachedContent">
        /// Required. The cached content to update
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CachedContent> UpdateCachedContentAsync(CachedContent cachedContent, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateCachedContentAsync(cachedContent, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes cached content
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCachedContent(DeleteCachedContentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes cached content
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCachedContentAsync(DeleteCachedContentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes cached content
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCachedContentAsync(DeleteCachedContentRequest request, st::CancellationToken cancellationToken) =>
            DeleteCachedContentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes cached content
        /// </summary>
        /// <param name="name">
        /// Required. The resource name referring to the cached content
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCachedContent(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCachedContent(new DeleteCachedContentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes cached content
        /// </summary>
        /// <param name="name">
        /// Required. The resource name referring to the cached content
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCachedContentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCachedContentAsync(new DeleteCachedContentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes cached content
        /// </summary>
        /// <param name="name">
        /// Required. The resource name referring to the cached content
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCachedContentAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteCachedContentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes cached content
        /// </summary>
        /// <param name="name">
        /// Required. The resource name referring to the cached content
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCachedContent(CachedContentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCachedContent(new DeleteCachedContentRequest
            {
                CachedContentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes cached content
        /// </summary>
        /// <param name="name">
        /// Required. The resource name referring to the cached content
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCachedContentAsync(CachedContentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCachedContentAsync(new DeleteCachedContentRequest
            {
                CachedContentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes cached content
        /// </summary>
        /// <param name="name">
        /// Required. The resource name referring to the cached content
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCachedContentAsync(CachedContentName name, st::CancellationToken cancellationToken) =>
            DeleteCachedContentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists cached contents in a project
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CachedContent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCachedContentsResponse, CachedContent> ListCachedContents(ListCachedContentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists cached contents in a project
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CachedContent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCachedContentsResponse, CachedContent> ListCachedContentsAsync(ListCachedContentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists cached contents in a project
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of cached contents.
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
        /// <returns>A pageable sequence of <see cref="CachedContent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCachedContentsResponse, CachedContent> ListCachedContents(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCachedContentsRequest request = new ListCachedContentsRequest
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
            return ListCachedContents(request, callSettings);
        }

        /// <summary>
        /// Lists cached contents in a project
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of cached contents.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CachedContent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCachedContentsResponse, CachedContent> ListCachedContentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCachedContentsRequest request = new ListCachedContentsRequest
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
            return ListCachedContentsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists cached contents in a project
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of cached contents.
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
        /// <returns>A pageable sequence of <see cref="CachedContent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCachedContentsResponse, CachedContent> ListCachedContents(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCachedContentsRequest request = new ListCachedContentsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCachedContents(request, callSettings);
        }

        /// <summary>
        /// Lists cached contents in a project
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of cached contents.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CachedContent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCachedContentsResponse, CachedContent> ListCachedContentsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCachedContentsRequest request = new ListCachedContentsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCachedContentsAsync(request, callSettings);
        }
    }

    /// <summary>GenAiCacheService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing Vertex AI's CachedContent resource.
    /// </remarks>
    public sealed partial class GenAiCacheServiceClientImpl : GenAiCacheServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateCachedContentRequest, CachedContent> _callCreateCachedContent;

        private readonly gaxgrpc::ApiCall<GetCachedContentRequest, CachedContent> _callGetCachedContent;

        private readonly gaxgrpc::ApiCall<UpdateCachedContentRequest, CachedContent> _callUpdateCachedContent;

        private readonly gaxgrpc::ApiCall<DeleteCachedContentRequest, wkt::Empty> _callDeleteCachedContent;

        private readonly gaxgrpc::ApiCall<ListCachedContentsRequest, ListCachedContentsResponse> _callListCachedContents;

        /// <summary>
        /// Constructs a client wrapper for the GenAiCacheService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="GenAiCacheServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public GenAiCacheServiceClientImpl(GenAiCacheService.GenAiCacheServiceClient grpcClient, GenAiCacheServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            GenAiCacheServiceSettings effectiveSettings = settings ?? GenAiCacheServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreateCachedContent = clientHelper.BuildApiCall<CreateCachedContentRequest, CachedContent>("CreateCachedContent", grpcClient.CreateCachedContentAsync, grpcClient.CreateCachedContent, effectiveSettings.CreateCachedContentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCachedContent);
            Modify_CreateCachedContentApiCall(ref _callCreateCachedContent);
            _callGetCachedContent = clientHelper.BuildApiCall<GetCachedContentRequest, CachedContent>("GetCachedContent", grpcClient.GetCachedContentAsync, grpcClient.GetCachedContent, effectiveSettings.GetCachedContentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCachedContent);
            Modify_GetCachedContentApiCall(ref _callGetCachedContent);
            _callUpdateCachedContent = clientHelper.BuildApiCall<UpdateCachedContentRequest, CachedContent>("UpdateCachedContent", grpcClient.UpdateCachedContentAsync, grpcClient.UpdateCachedContent, effectiveSettings.UpdateCachedContentSettings).WithGoogleRequestParam("cached_content.name", request => request.CachedContent?.Name);
            Modify_ApiCall(ref _callUpdateCachedContent);
            Modify_UpdateCachedContentApiCall(ref _callUpdateCachedContent);
            _callDeleteCachedContent = clientHelper.BuildApiCall<DeleteCachedContentRequest, wkt::Empty>("DeleteCachedContent", grpcClient.DeleteCachedContentAsync, grpcClient.DeleteCachedContent, effectiveSettings.DeleteCachedContentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteCachedContent);
            Modify_DeleteCachedContentApiCall(ref _callDeleteCachedContent);
            _callListCachedContents = clientHelper.BuildApiCall<ListCachedContentsRequest, ListCachedContentsResponse>("ListCachedContents", grpcClient.ListCachedContentsAsync, grpcClient.ListCachedContents, effectiveSettings.ListCachedContentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCachedContents);
            Modify_ListCachedContentsApiCall(ref _callListCachedContents);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateCachedContentApiCall(ref gaxgrpc::ApiCall<CreateCachedContentRequest, CachedContent> call);

        partial void Modify_GetCachedContentApiCall(ref gaxgrpc::ApiCall<GetCachedContentRequest, CachedContent> call);

        partial void Modify_UpdateCachedContentApiCall(ref gaxgrpc::ApiCall<UpdateCachedContentRequest, CachedContent> call);

        partial void Modify_DeleteCachedContentApiCall(ref gaxgrpc::ApiCall<DeleteCachedContentRequest, wkt::Empty> call);

        partial void Modify_ListCachedContentsApiCall(ref gaxgrpc::ApiCall<ListCachedContentsRequest, ListCachedContentsResponse> call);

        partial void OnConstruction(GenAiCacheService.GenAiCacheServiceClient grpcClient, GenAiCacheServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC GenAiCacheService client</summary>
        public override GenAiCacheService.GenAiCacheServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateCachedContentRequest(ref CreateCachedContentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCachedContentRequest(ref GetCachedContentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateCachedContentRequest(ref UpdateCachedContentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteCachedContentRequest(ref DeleteCachedContentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCachedContentsRequest(ref ListCachedContentsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates cached content, this call will initialize the cached content in the
        /// data storage, and users need to pay for the cache data storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CachedContent CreateCachedContent(CreateCachedContentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCachedContentRequest(ref request, ref callSettings);
            return _callCreateCachedContent.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates cached content, this call will initialize the cached content in the
        /// data storage, and users need to pay for the cache data storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CachedContent> CreateCachedContentAsync(CreateCachedContentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCachedContentRequest(ref request, ref callSettings);
            return _callCreateCachedContent.Async(request, callSettings);
        }

        /// <summary>
        /// Gets cached content configurations
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CachedContent GetCachedContent(GetCachedContentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCachedContentRequest(ref request, ref callSettings);
            return _callGetCachedContent.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets cached content configurations
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CachedContent> GetCachedContentAsync(GetCachedContentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCachedContentRequest(ref request, ref callSettings);
            return _callGetCachedContent.Async(request, callSettings);
        }

        /// <summary>
        /// Updates cached content configurations
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CachedContent UpdateCachedContent(UpdateCachedContentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCachedContentRequest(ref request, ref callSettings);
            return _callUpdateCachedContent.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates cached content configurations
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CachedContent> UpdateCachedContentAsync(UpdateCachedContentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCachedContentRequest(ref request, ref callSettings);
            return _callUpdateCachedContent.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes cached content
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteCachedContent(DeleteCachedContentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCachedContentRequest(ref request, ref callSettings);
            _callDeleteCachedContent.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes cached content
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteCachedContentAsync(DeleteCachedContentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCachedContentRequest(ref request, ref callSettings);
            return _callDeleteCachedContent.Async(request, callSettings);
        }

        /// <summary>
        /// Lists cached contents in a project
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CachedContent"/> resources.</returns>
        public override gax::PagedEnumerable<ListCachedContentsResponse, CachedContent> ListCachedContents(ListCachedContentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCachedContentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCachedContentsRequest, ListCachedContentsResponse, CachedContent>(_callListCachedContents, request, callSettings);
        }

        /// <summary>
        /// Lists cached contents in a project
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CachedContent"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCachedContentsResponse, CachedContent> ListCachedContentsAsync(ListCachedContentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCachedContentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCachedContentsRequest, ListCachedContentsResponse, CachedContent>(_callListCachedContents, request, callSettings);
        }
    }

    public partial class ListCachedContentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCachedContentsResponse : gaxgrpc::IPageResponse<CachedContent>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CachedContent> GetEnumerator() => CachedContents.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class GenAiCacheService
    {
        public partial class GenAiCacheServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="gcl::Locations.LocationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gcl::Locations.LocationsClient"/> for the same target as this client.
            /// </returns>
            public virtual gcl::Locations.LocationsClient CreateLocationsClient() =>
                new gcl::Locations.LocationsClient(CallInvoker);

            /// <summary>
            /// Creates a new instance of <see cref="gciv::IAMPolicy.IAMPolicyClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gciv::IAMPolicy.IAMPolicyClient"/> for the same target as this client.
            /// </returns>
            public virtual gciv::IAMPolicy.IAMPolicyClient CreateIAMPolicyClient() =>
                new gciv::IAMPolicy.IAMPolicyClient(CallInvoker);
        }
    }
}
