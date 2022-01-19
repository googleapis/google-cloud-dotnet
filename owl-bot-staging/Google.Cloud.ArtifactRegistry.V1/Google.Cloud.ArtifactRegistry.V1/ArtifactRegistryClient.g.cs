// Copyright 2022 Google LLC
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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using gagr = Google.Api.Gax.ResourceNames;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.ArtifactRegistry.V1
{
    /// <summary>Settings for <see cref="ArtifactRegistryClient"/> instances.</summary>
    public sealed partial class ArtifactRegistrySettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ArtifactRegistrySettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ArtifactRegistrySettings"/>.</returns>
        public static ArtifactRegistrySettings GetDefault() => new ArtifactRegistrySettings();

        /// <summary>Constructs a new <see cref="ArtifactRegistrySettings"/> object with default settings.</summary>
        public ArtifactRegistrySettings()
        {
        }

        private ArtifactRegistrySettings(ArtifactRegistrySettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListDockerImagesSettings = existing.ListDockerImagesSettings;
            ListRepositoriesSettings = existing.ListRepositoriesSettings;
            GetRepositorySettings = existing.GetRepositorySettings;
            OnCopy(existing);
        }

        partial void OnCopy(ArtifactRegistrySettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.ListDockerImages</c> and <c>ArtifactRegistryClient.ListDockerImagesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDockerImagesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.ListRepositories</c> and <c>ArtifactRegistryClient.ListRepositoriesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListRepositoriesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.GetRepository</c> and <c>ArtifactRegistryClient.GetRepositoryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetRepositorySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ArtifactRegistrySettings"/> object.</returns>
        public ArtifactRegistrySettings Clone() => new ArtifactRegistrySettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ArtifactRegistryClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class ArtifactRegistryClientBuilder : gaxgrpc::ClientBuilderBase<ArtifactRegistryClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ArtifactRegistrySettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ArtifactRegistryClientBuilder()
        {
            UseJwtAccessWithScopes = ArtifactRegistryClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref ArtifactRegistryClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ArtifactRegistryClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ArtifactRegistryClient Build()
        {
            ArtifactRegistryClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ArtifactRegistryClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ArtifactRegistryClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ArtifactRegistryClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ArtifactRegistryClient.Create(callInvoker, Settings);
        }

        private async stt::Task<ArtifactRegistryClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ArtifactRegistryClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => ArtifactRegistryClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => ArtifactRegistryClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ArtifactRegistryClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>ArtifactRegistry client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The Artifact Registry API service.
    /// 
    /// Artifact Registry is an artifact management system for storing artifacts
    /// from different package management systems.
    /// 
    /// The resources managed by this API are:
    /// 
    /// * Repositories, which group packages and their data.
    /// * Packages, which group versions and their tags.
    /// * Versions, which are specific forms of a package.
    /// * Tags, which represent alternative names for versions.
    /// * Files, which contain content and are optionally associated with a Package
    /// or Version.
    /// </remarks>
    public abstract partial class ArtifactRegistryClient
    {
        /// <summary>
        /// The default endpoint for the ArtifactRegistry service, which is a host of "artifactregistry.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "artifactregistry.googleapis.com:443";

        /// <summary>The default ArtifactRegistry scopes.</summary>
        /// <remarks>
        /// The default ArtifactRegistry scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform.read-only</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes, UseJwtAccessWithScopes);

        internal static bool UseJwtAccessWithScopes
        {
            get
            {
                bool useJwtAccessWithScopes = true;
                MaybeUseJwtAccessWithScopes(ref useJwtAccessWithScopes);
                return useJwtAccessWithScopes;
            }
        }

        static partial void MaybeUseJwtAccessWithScopes(ref bool useJwtAccessWithScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="ArtifactRegistryClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ArtifactRegistryClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ArtifactRegistryClient"/>.</returns>
        public static stt::Task<ArtifactRegistryClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ArtifactRegistryClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ArtifactRegistryClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ArtifactRegistryClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ArtifactRegistryClient"/>.</returns>
        public static ArtifactRegistryClient Create() => new ArtifactRegistryClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ArtifactRegistryClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ArtifactRegistrySettings"/>.</param>
        /// <returns>The created <see cref="ArtifactRegistryClient"/>.</returns>
        internal static ArtifactRegistryClient Create(grpccore::CallInvoker callInvoker, ArtifactRegistrySettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ArtifactRegistry.ArtifactRegistryClient grpcClient = new ArtifactRegistry.ArtifactRegistryClient(callInvoker);
            return new ArtifactRegistryClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC ArtifactRegistry client</summary>
        public virtual ArtifactRegistry.ArtifactRegistryClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists docker images.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DockerImage"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDockerImagesResponse, DockerImage> ListDockerImages(ListDockerImagesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists docker images.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DockerImage"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDockerImagesResponse, DockerImage> ListDockerImagesAsync(ListDockerImagesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists docker images.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource whose docker images will be listed.
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
        /// <returns>A pageable sequence of <see cref="DockerImage"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDockerImagesResponse, DockerImage> ListDockerImages(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDockerImages(new ListDockerImagesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists docker images.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource whose docker images will be listed.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DockerImage"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDockerImagesResponse, DockerImage> ListDockerImagesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDockerImagesAsync(new ListDockerImagesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists repositories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Repository"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRepositoriesResponse, Repository> ListRepositories(ListRepositoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists repositories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Repository"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRepositoriesResponse, Repository> ListRepositoriesAsync(ListRepositoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists repositories.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource whose repositories will be listed.
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
        /// <returns>A pageable sequence of <see cref="Repository"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRepositoriesResponse, Repository> ListRepositories(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListRepositories(new ListRepositoriesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists repositories.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource whose repositories will be listed.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Repository"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRepositoriesResponse, Repository> ListRepositoriesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListRepositoriesAsync(new ListRepositoriesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists repositories.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource whose repositories will be listed.
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
        /// <returns>A pageable sequence of <see cref="Repository"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRepositoriesResponse, Repository> ListRepositories(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListRepositories(new ListRepositoriesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists repositories.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource whose repositories will be listed.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Repository"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRepositoriesResponse, Repository> ListRepositoriesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListRepositoriesAsync(new ListRepositoriesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Repository GetRepository(GetRepositoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Repository> GetRepositoryAsync(GetRepositoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Repository> GetRepositoryAsync(GetRepositoryRequest request, st::CancellationToken cancellationToken) =>
            GetRepositoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a repository.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the repository to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Repository GetRepository(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRepository(new GetRepositoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a repository.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the repository to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Repository> GetRepositoryAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRepositoryAsync(new GetRepositoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a repository.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the repository to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Repository> GetRepositoryAsync(string name, st::CancellationToken cancellationToken) =>
            GetRepositoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a repository.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the repository to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Repository GetRepository(RepositoryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRepository(new GetRepositoryRequest
            {
                RepositoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a repository.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the repository to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Repository> GetRepositoryAsync(RepositoryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRepositoryAsync(new GetRepositoryRequest
            {
                RepositoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a repository.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the repository to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Repository> GetRepositoryAsync(RepositoryName name, st::CancellationToken cancellationToken) =>
            GetRepositoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ArtifactRegistry client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The Artifact Registry API service.
    /// 
    /// Artifact Registry is an artifact management system for storing artifacts
    /// from different package management systems.
    /// 
    /// The resources managed by this API are:
    /// 
    /// * Repositories, which group packages and their data.
    /// * Packages, which group versions and their tags.
    /// * Versions, which are specific forms of a package.
    /// * Tags, which represent alternative names for versions.
    /// * Files, which contain content and are optionally associated with a Package
    /// or Version.
    /// </remarks>
    public sealed partial class ArtifactRegistryClientImpl : ArtifactRegistryClient
    {
        private readonly gaxgrpc::ApiCall<ListDockerImagesRequest, ListDockerImagesResponse> _callListDockerImages;

        private readonly gaxgrpc::ApiCall<ListRepositoriesRequest, ListRepositoriesResponse> _callListRepositories;

        private readonly gaxgrpc::ApiCall<GetRepositoryRequest, Repository> _callGetRepository;

        /// <summary>
        /// Constructs a client wrapper for the ArtifactRegistry service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ArtifactRegistrySettings"/> used within this client.</param>
        public ArtifactRegistryClientImpl(ArtifactRegistry.ArtifactRegistryClient grpcClient, ArtifactRegistrySettings settings)
        {
            GrpcClient = grpcClient;
            ArtifactRegistrySettings effectiveSettings = settings ?? ArtifactRegistrySettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callListDockerImages = clientHelper.BuildApiCall<ListDockerImagesRequest, ListDockerImagesResponse>(grpcClient.ListDockerImagesAsync, grpcClient.ListDockerImages, effectiveSettings.ListDockerImagesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDockerImages);
            Modify_ListDockerImagesApiCall(ref _callListDockerImages);
            _callListRepositories = clientHelper.BuildApiCall<ListRepositoriesRequest, ListRepositoriesResponse>(grpcClient.ListRepositoriesAsync, grpcClient.ListRepositories, effectiveSettings.ListRepositoriesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRepositories);
            Modify_ListRepositoriesApiCall(ref _callListRepositories);
            _callGetRepository = clientHelper.BuildApiCall<GetRepositoryRequest, Repository>(grpcClient.GetRepositoryAsync, grpcClient.GetRepository, effectiveSettings.GetRepositorySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRepository);
            Modify_GetRepositoryApiCall(ref _callGetRepository);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListDockerImagesApiCall(ref gaxgrpc::ApiCall<ListDockerImagesRequest, ListDockerImagesResponse> call);

        partial void Modify_ListRepositoriesApiCall(ref gaxgrpc::ApiCall<ListRepositoriesRequest, ListRepositoriesResponse> call);

        partial void Modify_GetRepositoryApiCall(ref gaxgrpc::ApiCall<GetRepositoryRequest, Repository> call);

        partial void OnConstruction(ArtifactRegistry.ArtifactRegistryClient grpcClient, ArtifactRegistrySettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ArtifactRegistry client</summary>
        public override ArtifactRegistry.ArtifactRegistryClient GrpcClient { get; }

        partial void Modify_ListDockerImagesRequest(ref ListDockerImagesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRepositoriesRequest(ref ListRepositoriesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRepositoryRequest(ref GetRepositoryRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists docker images.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DockerImage"/> resources.</returns>
        public override gax::PagedEnumerable<ListDockerImagesResponse, DockerImage> ListDockerImages(ListDockerImagesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDockerImagesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDockerImagesRequest, ListDockerImagesResponse, DockerImage>(_callListDockerImages, request, callSettings);
        }

        /// <summary>
        /// Lists docker images.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DockerImage"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDockerImagesResponse, DockerImage> ListDockerImagesAsync(ListDockerImagesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDockerImagesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDockerImagesRequest, ListDockerImagesResponse, DockerImage>(_callListDockerImages, request, callSettings);
        }

        /// <summary>
        /// Lists repositories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Repository"/> resources.</returns>
        public override gax::PagedEnumerable<ListRepositoriesResponse, Repository> ListRepositories(ListRepositoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRepositoriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRepositoriesRequest, ListRepositoriesResponse, Repository>(_callListRepositories, request, callSettings);
        }

        /// <summary>
        /// Lists repositories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Repository"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRepositoriesResponse, Repository> ListRepositoriesAsync(ListRepositoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRepositoriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRepositoriesRequest, ListRepositoriesResponse, Repository>(_callListRepositories, request, callSettings);
        }

        /// <summary>
        /// Gets a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Repository GetRepository(GetRepositoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRepositoryRequest(ref request, ref callSettings);
            return _callGetRepository.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Repository> GetRepositoryAsync(GetRepositoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRepositoryRequest(ref request, ref callSettings);
            return _callGetRepository.Async(request, callSettings);
        }
    }

    public partial class ListDockerImagesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRepositoriesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDockerImagesResponse : gaxgrpc::IPageResponse<DockerImage>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DockerImage> GetEnumerator() => DockerImages.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListRepositoriesResponse : gaxgrpc::IPageResponse<Repository>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Repository> GetEnumerator() => Repositories.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
