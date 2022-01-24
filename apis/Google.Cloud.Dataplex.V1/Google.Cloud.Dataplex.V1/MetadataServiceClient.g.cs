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
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Dataplex.V1
{
    /// <summary>Settings for <see cref="MetadataServiceClient"/> instances.</summary>
    public sealed partial class MetadataServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="MetadataServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="MetadataServiceSettings"/>.</returns>
        public static MetadataServiceSettings GetDefault() => new MetadataServiceSettings();

        /// <summary>Constructs a new <see cref="MetadataServiceSettings"/> object with default settings.</summary>
        public MetadataServiceSettings()
        {
        }

        private MetadataServiceSettings(MetadataServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetEntitySettings = existing.GetEntitySettings;
            ListEntitiesSettings = existing.ListEntitiesSettings;
            GetPartitionSettings = existing.GetPartitionSettings;
            ListPartitionsSettings = existing.ListPartitionsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(MetadataServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.GetEntity</c> and <c>MetadataServiceClient.GetEntityAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEntitySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.ListEntities</c> and <c>MetadataServiceClient.ListEntitiesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEntitiesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.GetPartition</c> and <c>MetadataServiceClient.GetPartitionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetPartitionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.ListPartitions</c> and <c>MetadataServiceClient.ListPartitionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListPartitionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="MetadataServiceSettings"/> object.</returns>
        public MetadataServiceSettings Clone() => new MetadataServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="MetadataServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class MetadataServiceClientBuilder : gaxgrpc::ClientBuilderBase<MetadataServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public MetadataServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public MetadataServiceClientBuilder()
        {
            UseJwtAccessWithScopes = MetadataServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref MetadataServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<MetadataServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override MetadataServiceClient Build()
        {
            MetadataServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<MetadataServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<MetadataServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private MetadataServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return MetadataServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<MetadataServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return MetadataServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => MetadataServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => MetadataServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => MetadataServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>MetadataService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Metadata service manages metadata resources such as tables, filesets and
    /// partitions.
    /// </remarks>
    public abstract partial class MetadataServiceClient
    {
        /// <summary>
        /// The default endpoint for the MetadataService service, which is a host of "dataplex.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dataplex.googleapis.com:443";

        /// <summary>The default MetadataService scopes.</summary>
        /// <remarks>
        /// The default MetadataService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
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
        /// Asynchronously creates a <see cref="MetadataServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="MetadataServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="MetadataServiceClient"/>.</returns>
        public static stt::Task<MetadataServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new MetadataServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="MetadataServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="MetadataServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="MetadataServiceClient"/>.</returns>
        public static MetadataServiceClient Create() => new MetadataServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="MetadataServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="MetadataServiceSettings"/>.</param>
        /// <returns>The created <see cref="MetadataServiceClient"/>.</returns>
        internal static MetadataServiceClient Create(grpccore::CallInvoker callInvoker, MetadataServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            MetadataService.MetadataServiceClient grpcClient = new MetadataService.MetadataServiceClient(callInvoker);
            return new MetadataServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC MetadataService client</summary>
        public virtual MetadataService.MetadataServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Get a metadata entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Entity GetEntity(GetEntityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a metadata entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entity> GetEntityAsync(GetEntityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a metadata entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entity> GetEntityAsync(GetEntityRequest request, st::CancellationToken cancellationToken) =>
            GetEntityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a metadata entity.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the entity:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}.`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Entity GetEntity(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntity(new GetEntityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a metadata entity.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the entity:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}.`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entity> GetEntityAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntityAsync(new GetEntityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a metadata entity.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the entity:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}.`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entity> GetEntityAsync(string name, st::CancellationToken cancellationToken) =>
            GetEntityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a metadata entity.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the entity:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}.`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Entity GetEntity(EntityName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntity(new GetEntityRequest
            {
                EntityName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a metadata entity.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the entity:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}.`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entity> GetEntityAsync(EntityName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntityAsync(new GetEntityRequest
            {
                EntityName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a metadata entity.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the entity:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}.`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entity> GetEntityAsync(EntityName name, st::CancellationToken cancellationToken) =>
            GetEntityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List metadata entities in a zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Entity"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntitiesResponse, Entity> ListEntities(ListEntitiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List metadata entities in a zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Entity"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntitiesResponse, Entity> ListEntitiesAsync(ListEntitiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List metadata entities in a zone.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}`.
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
        /// <returns>A pageable sequence of <see cref="Entity"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntitiesResponse, Entity> ListEntities(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListEntities(new ListEntitiesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List metadata entities in a zone.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Entity"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntitiesResponse, Entity> ListEntitiesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListEntitiesAsync(new ListEntitiesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List metadata entities in a zone.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}`.
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
        /// <returns>A pageable sequence of <see cref="Entity"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntitiesResponse, Entity> ListEntities(ZoneName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListEntities(new ListEntitiesRequest
            {
                ParentAsZoneName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List metadata entities in a zone.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Entity"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntitiesResponse, Entity> ListEntitiesAsync(ZoneName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListEntitiesAsync(new ListEntitiesRequest
            {
                ParentAsZoneName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Get a metadata partition of an entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Partition GetPartition(GetPartitionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a metadata partition of an entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Partition> GetPartitionAsync(GetPartitionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a metadata partition of an entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Partition> GetPartitionAsync(GetPartitionRequest request, st::CancellationToken cancellationToken) =>
            GetPartitionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a metadata partition of an entity.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the partition:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}/partitions/{partition_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Partition GetPartition(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPartition(new GetPartitionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a metadata partition of an entity.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the partition:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}/partitions/{partition_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Partition> GetPartitionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPartitionAsync(new GetPartitionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a metadata partition of an entity.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the partition:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}/partitions/{partition_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Partition> GetPartitionAsync(string name, st::CancellationToken cancellationToken) =>
            GetPartitionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a metadata partition of an entity.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the partition:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}/partitions/{partition_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Partition GetPartition(PartitionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPartition(new GetPartitionRequest
            {
                PartitionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a metadata partition of an entity.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the partition:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}/partitions/{partition_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Partition> GetPartitionAsync(PartitionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPartitionAsync(new GetPartitionRequest
            {
                PartitionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a metadata partition of an entity.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the partition:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}/partitions/{partition_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Partition> GetPartitionAsync(PartitionName name, st::CancellationToken cancellationToken) =>
            GetPartitionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List metadata partitions of an entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Partition"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPartitionsResponse, Partition> ListPartitions(ListPartitionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List metadata partitions of an entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Partition"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPartitionsResponse, Partition> ListPartitionsAsync(ListPartitionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List metadata partitions of an entity.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent entity:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}`.
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
        /// <returns>A pageable sequence of <see cref="Partition"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPartitionsResponse, Partition> ListPartitions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListPartitions(new ListPartitionsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List metadata partitions of an entity.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent entity:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Partition"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPartitionsResponse, Partition> ListPartitionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListPartitionsAsync(new ListPartitionsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List metadata partitions of an entity.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent entity:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}`.
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
        /// <returns>A pageable sequence of <see cref="Partition"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPartitionsResponse, Partition> ListPartitions(EntityName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListPartitions(new ListPartitionsRequest
            {
                ParentAsEntityName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List metadata partitions of an entity.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent entity:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Partition"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPartitionsResponse, Partition> ListPartitionsAsync(EntityName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListPartitionsAsync(new ListPartitionsRequest
            {
                ParentAsEntityName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);
    }

    /// <summary>MetadataService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Metadata service manages metadata resources such as tables, filesets and
    /// partitions.
    /// </remarks>
    public sealed partial class MetadataServiceClientImpl : MetadataServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetEntityRequest, Entity> _callGetEntity;

        private readonly gaxgrpc::ApiCall<ListEntitiesRequest, ListEntitiesResponse> _callListEntities;

        private readonly gaxgrpc::ApiCall<GetPartitionRequest, Partition> _callGetPartition;

        private readonly gaxgrpc::ApiCall<ListPartitionsRequest, ListPartitionsResponse> _callListPartitions;

        /// <summary>
        /// Constructs a client wrapper for the MetadataService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="MetadataServiceSettings"/> used within this client.</param>
        public MetadataServiceClientImpl(MetadataService.MetadataServiceClient grpcClient, MetadataServiceSettings settings)
        {
            GrpcClient = grpcClient;
            MetadataServiceSettings effectiveSettings = settings ?? MetadataServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetEntity = clientHelper.BuildApiCall<GetEntityRequest, Entity>(grpcClient.GetEntityAsync, grpcClient.GetEntity, effectiveSettings.GetEntitySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEntity);
            Modify_GetEntityApiCall(ref _callGetEntity);
            _callListEntities = clientHelper.BuildApiCall<ListEntitiesRequest, ListEntitiesResponse>(grpcClient.ListEntitiesAsync, grpcClient.ListEntities, effectiveSettings.ListEntitiesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEntities);
            Modify_ListEntitiesApiCall(ref _callListEntities);
            _callGetPartition = clientHelper.BuildApiCall<GetPartitionRequest, Partition>(grpcClient.GetPartitionAsync, grpcClient.GetPartition, effectiveSettings.GetPartitionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPartition);
            Modify_GetPartitionApiCall(ref _callGetPartition);
            _callListPartitions = clientHelper.BuildApiCall<ListPartitionsRequest, ListPartitionsResponse>(grpcClient.ListPartitionsAsync, grpcClient.ListPartitions, effectiveSettings.ListPartitionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPartitions);
            Modify_ListPartitionsApiCall(ref _callListPartitions);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetEntityApiCall(ref gaxgrpc::ApiCall<GetEntityRequest, Entity> call);

        partial void Modify_ListEntitiesApiCall(ref gaxgrpc::ApiCall<ListEntitiesRequest, ListEntitiesResponse> call);

        partial void Modify_GetPartitionApiCall(ref gaxgrpc::ApiCall<GetPartitionRequest, Partition> call);

        partial void Modify_ListPartitionsApiCall(ref gaxgrpc::ApiCall<ListPartitionsRequest, ListPartitionsResponse> call);

        partial void OnConstruction(MetadataService.MetadataServiceClient grpcClient, MetadataServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC MetadataService client</summary>
        public override MetadataService.MetadataServiceClient GrpcClient { get; }

        partial void Modify_GetEntityRequest(ref GetEntityRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListEntitiesRequest(ref ListEntitiesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPartitionRequest(ref GetPartitionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPartitionsRequest(ref ListPartitionsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Get a metadata entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Entity GetEntity(GetEntityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEntityRequest(ref request, ref callSettings);
            return _callGetEntity.Sync(request, callSettings);
        }

        /// <summary>
        /// Get a metadata entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Entity> GetEntityAsync(GetEntityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEntityRequest(ref request, ref callSettings);
            return _callGetEntity.Async(request, callSettings);
        }

        /// <summary>
        /// List metadata entities in a zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Entity"/> resources.</returns>
        public override gax::PagedEnumerable<ListEntitiesResponse, Entity> ListEntities(ListEntitiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEntitiesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEntitiesRequest, ListEntitiesResponse, Entity>(_callListEntities, request, callSettings);
        }

        /// <summary>
        /// List metadata entities in a zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Entity"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEntitiesResponse, Entity> ListEntitiesAsync(ListEntitiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEntitiesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEntitiesRequest, ListEntitiesResponse, Entity>(_callListEntities, request, callSettings);
        }

        /// <summary>
        /// Get a metadata partition of an entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Partition GetPartition(GetPartitionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPartitionRequest(ref request, ref callSettings);
            return _callGetPartition.Sync(request, callSettings);
        }

        /// <summary>
        /// Get a metadata partition of an entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Partition> GetPartitionAsync(GetPartitionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPartitionRequest(ref request, ref callSettings);
            return _callGetPartition.Async(request, callSettings);
        }

        /// <summary>
        /// List metadata partitions of an entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Partition"/> resources.</returns>
        public override gax::PagedEnumerable<ListPartitionsResponse, Partition> ListPartitions(ListPartitionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPartitionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPartitionsRequest, ListPartitionsResponse, Partition>(_callListPartitions, request, callSettings);
        }

        /// <summary>
        /// List metadata partitions of an entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Partition"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPartitionsResponse, Partition> ListPartitionsAsync(ListPartitionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPartitionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPartitionsRequest, ListPartitionsResponse, Partition>(_callListPartitions, request, callSettings);
        }
    }

    public partial class ListEntitiesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPartitionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEntitiesResponse : gaxgrpc::IPageResponse<Entity>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Entity> GetEnumerator() => Entities.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListPartitionsResponse : gaxgrpc::IPageResponse<Partition>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Partition> GetEnumerator() => Partitions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
