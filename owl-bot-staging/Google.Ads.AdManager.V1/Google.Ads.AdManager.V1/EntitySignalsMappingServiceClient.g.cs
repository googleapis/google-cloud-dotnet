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

namespace Google.Ads.AdManager.V1
{
    /// <summary>Settings for <see cref="EntitySignalsMappingServiceClient"/> instances.</summary>
    public sealed partial class EntitySignalsMappingServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="EntitySignalsMappingServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="EntitySignalsMappingServiceSettings"/>.</returns>
        public static EntitySignalsMappingServiceSettings GetDefault() => new EntitySignalsMappingServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="EntitySignalsMappingServiceSettings"/> object with default settings.
        /// </summary>
        public EntitySignalsMappingServiceSettings()
        {
        }

        private EntitySignalsMappingServiceSettings(EntitySignalsMappingServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetEntitySignalsMappingSettings = existing.GetEntitySignalsMappingSettings;
            ListEntitySignalsMappingsSettings = existing.ListEntitySignalsMappingsSettings;
            CreateEntitySignalsMappingSettings = existing.CreateEntitySignalsMappingSettings;
            UpdateEntitySignalsMappingSettings = existing.UpdateEntitySignalsMappingSettings;
            BatchCreateEntitySignalsMappingsSettings = existing.BatchCreateEntitySignalsMappingsSettings;
            BatchUpdateEntitySignalsMappingsSettings = existing.BatchUpdateEntitySignalsMappingsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(EntitySignalsMappingServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EntitySignalsMappingServiceClient.GetEntitySignalsMapping</c> and
        /// <c>EntitySignalsMappingServiceClient.GetEntitySignalsMappingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEntitySignalsMappingSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EntitySignalsMappingServiceClient.ListEntitySignalsMappings</c> and
        /// <c>EntitySignalsMappingServiceClient.ListEntitySignalsMappingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEntitySignalsMappingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EntitySignalsMappingServiceClient.CreateEntitySignalsMapping</c> and
        /// <c>EntitySignalsMappingServiceClient.CreateEntitySignalsMappingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateEntitySignalsMappingSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EntitySignalsMappingServiceClient.UpdateEntitySignalsMapping</c> and
        /// <c>EntitySignalsMappingServiceClient.UpdateEntitySignalsMappingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateEntitySignalsMappingSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EntitySignalsMappingServiceClient.BatchCreateEntitySignalsMappings</c> and
        /// <c>EntitySignalsMappingServiceClient.BatchCreateEntitySignalsMappingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchCreateEntitySignalsMappingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EntitySignalsMappingServiceClient.BatchUpdateEntitySignalsMappings</c> and
        /// <c>EntitySignalsMappingServiceClient.BatchUpdateEntitySignalsMappingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchUpdateEntitySignalsMappingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="EntitySignalsMappingServiceSettings"/> object.</returns>
        public EntitySignalsMappingServiceSettings Clone() => new EntitySignalsMappingServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="EntitySignalsMappingServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class EntitySignalsMappingServiceClientBuilder : gaxgrpc::ClientBuilderBase<EntitySignalsMappingServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public EntitySignalsMappingServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public EntitySignalsMappingServiceClientBuilder() : base(EntitySignalsMappingServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref EntitySignalsMappingServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<EntitySignalsMappingServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override EntitySignalsMappingServiceClient Build()
        {
            EntitySignalsMappingServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<EntitySignalsMappingServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<EntitySignalsMappingServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private EntitySignalsMappingServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return EntitySignalsMappingServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<EntitySignalsMappingServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return EntitySignalsMappingServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => EntitySignalsMappingServiceClient.ChannelPool;
    }

    /// <summary>EntitySignalsMappingService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `EntitySignalsMapping` objects.
    /// </remarks>
    public abstract partial class EntitySignalsMappingServiceClient
    {
        /// <summary>
        /// The default endpoint for the EntitySignalsMappingService service, which is a host of
        /// "admanager.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default EntitySignalsMappingService scopes.</summary>
        /// <remarks>The default EntitySignalsMappingService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(EntitySignalsMappingService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="EntitySignalsMappingServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="EntitySignalsMappingServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="EntitySignalsMappingServiceClient"/>.</returns>
        public static stt::Task<EntitySignalsMappingServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new EntitySignalsMappingServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="EntitySignalsMappingServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="EntitySignalsMappingServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="EntitySignalsMappingServiceClient"/>.</returns>
        public static EntitySignalsMappingServiceClient Create() => new EntitySignalsMappingServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="EntitySignalsMappingServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="EntitySignalsMappingServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="EntitySignalsMappingServiceClient"/>.</returns>
        internal static EntitySignalsMappingServiceClient Create(grpccore::CallInvoker callInvoker, EntitySignalsMappingServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            EntitySignalsMappingService.EntitySignalsMappingServiceClient grpcClient = new EntitySignalsMappingService.EntitySignalsMappingServiceClient(callInvoker);
            return new EntitySignalsMappingServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC EntitySignalsMappingService client</summary>
        public virtual EntitySignalsMappingService.EntitySignalsMappingServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `EntitySignalsMapping` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntitySignalsMapping GetEntitySignalsMapping(GetEntitySignalsMappingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `EntitySignalsMapping` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntitySignalsMapping> GetEntitySignalsMappingAsync(GetEntitySignalsMappingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `EntitySignalsMapping` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntitySignalsMapping> GetEntitySignalsMappingAsync(GetEntitySignalsMappingRequest request, st::CancellationToken cancellationToken) =>
            GetEntitySignalsMappingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `EntitySignalsMapping` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EntitySignalsMapping.
        /// Format:
        /// `networks/{network_code}/entitySignalsMappings/{entity_signals_mapping_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntitySignalsMapping GetEntitySignalsMapping(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntitySignalsMapping(new GetEntitySignalsMappingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `EntitySignalsMapping` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EntitySignalsMapping.
        /// Format:
        /// `networks/{network_code}/entitySignalsMappings/{entity_signals_mapping_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntitySignalsMapping> GetEntitySignalsMappingAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntitySignalsMappingAsync(new GetEntitySignalsMappingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `EntitySignalsMapping` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EntitySignalsMapping.
        /// Format:
        /// `networks/{network_code}/entitySignalsMappings/{entity_signals_mapping_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntitySignalsMapping> GetEntitySignalsMappingAsync(string name, st::CancellationToken cancellationToken) =>
            GetEntitySignalsMappingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `EntitySignalsMapping` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EntitySignalsMapping.
        /// Format:
        /// `networks/{network_code}/entitySignalsMappings/{entity_signals_mapping_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntitySignalsMapping GetEntitySignalsMapping(EntitySignalsMappingName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntitySignalsMapping(new GetEntitySignalsMappingRequest
            {
                EntitySignalsMappingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `EntitySignalsMapping` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EntitySignalsMapping.
        /// Format:
        /// `networks/{network_code}/entitySignalsMappings/{entity_signals_mapping_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntitySignalsMapping> GetEntitySignalsMappingAsync(EntitySignalsMappingName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntitySignalsMappingAsync(new GetEntitySignalsMappingRequest
            {
                EntitySignalsMappingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `EntitySignalsMapping` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EntitySignalsMapping.
        /// Format:
        /// `networks/{network_code}/entitySignalsMappings/{entity_signals_mapping_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntitySignalsMapping> GetEntitySignalsMappingAsync(EntitySignalsMappingName name, st::CancellationToken cancellationToken) =>
            GetEntitySignalsMappingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a list of `EntitySignalsMapping` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EntitySignalsMapping"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntitySignalsMappingsResponse, EntitySignalsMapping> ListEntitySignalsMappings(ListEntitySignalsMappingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `EntitySignalsMapping` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EntitySignalsMapping"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntitySignalsMappingsResponse, EntitySignalsMapping> ListEntitySignalsMappingsAsync(ListEntitySignalsMappingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `EntitySignalsMapping` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of EntitySignalsMappings.
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
        /// <returns>A pageable sequence of <see cref="EntitySignalsMapping"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntitySignalsMappingsResponse, EntitySignalsMapping> ListEntitySignalsMappings(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntitySignalsMappingsRequest request = new ListEntitySignalsMappingsRequest
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
            return ListEntitySignalsMappings(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `EntitySignalsMapping` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of EntitySignalsMappings.
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
        /// <returns>A pageable asynchronous sequence of <see cref="EntitySignalsMapping"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntitySignalsMappingsResponse, EntitySignalsMapping> ListEntitySignalsMappingsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntitySignalsMappingsRequest request = new ListEntitySignalsMappingsRequest
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
            return ListEntitySignalsMappingsAsync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `EntitySignalsMapping` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of EntitySignalsMappings.
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
        /// <returns>A pageable sequence of <see cref="EntitySignalsMapping"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntitySignalsMappingsResponse, EntitySignalsMapping> ListEntitySignalsMappings(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntitySignalsMappingsRequest request = new ListEntitySignalsMappingsRequest
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
            return ListEntitySignalsMappings(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `EntitySignalsMapping` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of EntitySignalsMappings.
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
        /// <returns>A pageable asynchronous sequence of <see cref="EntitySignalsMapping"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntitySignalsMappingsResponse, EntitySignalsMapping> ListEntitySignalsMappingsAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntitySignalsMappingsRequest request = new ListEntitySignalsMappingsRequest
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
            return ListEntitySignalsMappingsAsync(request, callSettings);
        }

        /// <summary>
        /// API to create an `EntitySignalsMapping` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntitySignalsMapping CreateEntitySignalsMapping(CreateEntitySignalsMappingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to create an `EntitySignalsMapping` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntitySignalsMapping> CreateEntitySignalsMappingAsync(CreateEntitySignalsMappingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to create an `EntitySignalsMapping` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntitySignalsMapping> CreateEntitySignalsMappingAsync(CreateEntitySignalsMappingRequest request, st::CancellationToken cancellationToken) =>
            CreateEntitySignalsMappingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to create an `EntitySignalsMapping` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this EntitySignalsMapping will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="entitySignalsMapping">
        /// Required. The EntitySignalsMapping object to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntitySignalsMapping CreateEntitySignalsMapping(string parent, EntitySignalsMapping entitySignalsMapping, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntitySignalsMapping(new CreateEntitySignalsMappingRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EntitySignalsMapping = gax::GaxPreconditions.CheckNotNull(entitySignalsMapping, nameof(entitySignalsMapping)),
            }, callSettings);

        /// <summary>
        /// API to create an `EntitySignalsMapping` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this EntitySignalsMapping will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="entitySignalsMapping">
        /// Required. The EntitySignalsMapping object to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntitySignalsMapping> CreateEntitySignalsMappingAsync(string parent, EntitySignalsMapping entitySignalsMapping, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntitySignalsMappingAsync(new CreateEntitySignalsMappingRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EntitySignalsMapping = gax::GaxPreconditions.CheckNotNull(entitySignalsMapping, nameof(entitySignalsMapping)),
            }, callSettings);

        /// <summary>
        /// API to create an `EntitySignalsMapping` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this EntitySignalsMapping will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="entitySignalsMapping">
        /// Required. The EntitySignalsMapping object to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntitySignalsMapping> CreateEntitySignalsMappingAsync(string parent, EntitySignalsMapping entitySignalsMapping, st::CancellationToken cancellationToken) =>
            CreateEntitySignalsMappingAsync(parent, entitySignalsMapping, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to create an `EntitySignalsMapping` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this EntitySignalsMapping will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="entitySignalsMapping">
        /// Required. The EntitySignalsMapping object to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntitySignalsMapping CreateEntitySignalsMapping(NetworkName parent, EntitySignalsMapping entitySignalsMapping, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntitySignalsMapping(new CreateEntitySignalsMappingRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EntitySignalsMapping = gax::GaxPreconditions.CheckNotNull(entitySignalsMapping, nameof(entitySignalsMapping)),
            }, callSettings);

        /// <summary>
        /// API to create an `EntitySignalsMapping` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this EntitySignalsMapping will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="entitySignalsMapping">
        /// Required. The EntitySignalsMapping object to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntitySignalsMapping> CreateEntitySignalsMappingAsync(NetworkName parent, EntitySignalsMapping entitySignalsMapping, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntitySignalsMappingAsync(new CreateEntitySignalsMappingRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EntitySignalsMapping = gax::GaxPreconditions.CheckNotNull(entitySignalsMapping, nameof(entitySignalsMapping)),
            }, callSettings);

        /// <summary>
        /// API to create an `EntitySignalsMapping` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this EntitySignalsMapping will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="entitySignalsMapping">
        /// Required. The EntitySignalsMapping object to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntitySignalsMapping> CreateEntitySignalsMappingAsync(NetworkName parent, EntitySignalsMapping entitySignalsMapping, st::CancellationToken cancellationToken) =>
            CreateEntitySignalsMappingAsync(parent, entitySignalsMapping, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to update an `EntitySignalsMapping` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntitySignalsMapping UpdateEntitySignalsMapping(UpdateEntitySignalsMappingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to update an `EntitySignalsMapping` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntitySignalsMapping> UpdateEntitySignalsMappingAsync(UpdateEntitySignalsMappingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to update an `EntitySignalsMapping` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntitySignalsMapping> UpdateEntitySignalsMappingAsync(UpdateEntitySignalsMappingRequest request, st::CancellationToken cancellationToken) =>
            UpdateEntitySignalsMappingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to update an `EntitySignalsMapping` object.
        /// </summary>
        /// <param name="entitySignalsMapping">
        /// Required. The `EntitySignalsMapping` to update.
        /// 
        /// The EntitySignalsMapping's name is used to identify the
        /// EntitySignalsMapping to update.
        /// Format:
        /// `networks/{network_code}/entitySignalsMappings/{entity_signals_mapping}`
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntitySignalsMapping UpdateEntitySignalsMapping(EntitySignalsMapping entitySignalsMapping, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEntitySignalsMapping(new UpdateEntitySignalsMappingRequest
            {
                EntitySignalsMapping = gax::GaxPreconditions.CheckNotNull(entitySignalsMapping, nameof(entitySignalsMapping)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// API to update an `EntitySignalsMapping` object.
        /// </summary>
        /// <param name="entitySignalsMapping">
        /// Required. The `EntitySignalsMapping` to update.
        /// 
        /// The EntitySignalsMapping's name is used to identify the
        /// EntitySignalsMapping to update.
        /// Format:
        /// `networks/{network_code}/entitySignalsMappings/{entity_signals_mapping}`
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntitySignalsMapping> UpdateEntitySignalsMappingAsync(EntitySignalsMapping entitySignalsMapping, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEntitySignalsMappingAsync(new UpdateEntitySignalsMappingRequest
            {
                EntitySignalsMapping = gax::GaxPreconditions.CheckNotNull(entitySignalsMapping, nameof(entitySignalsMapping)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// API to update an `EntitySignalsMapping` object.
        /// </summary>
        /// <param name="entitySignalsMapping">
        /// Required. The `EntitySignalsMapping` to update.
        /// 
        /// The EntitySignalsMapping's name is used to identify the
        /// EntitySignalsMapping to update.
        /// Format:
        /// `networks/{network_code}/entitySignalsMappings/{entity_signals_mapping}`
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntitySignalsMapping> UpdateEntitySignalsMappingAsync(EntitySignalsMapping entitySignalsMapping, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateEntitySignalsMappingAsync(entitySignalsMapping, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch create `EntitySignalsMapping` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateEntitySignalsMappingsResponse BatchCreateEntitySignalsMappings(BatchCreateEntitySignalsMappingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to batch create `EntitySignalsMapping` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateEntitySignalsMappingsResponse> BatchCreateEntitySignalsMappingsAsync(BatchCreateEntitySignalsMappingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to batch create `EntitySignalsMapping` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateEntitySignalsMappingsResponse> BatchCreateEntitySignalsMappingsAsync(BatchCreateEntitySignalsMappingsRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateEntitySignalsMappingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch create `EntitySignalsMapping` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `EntitySignalsMappings` will be
        /// created. Format: `networks/{network_code}` The parent field in the
        /// CreateEntitySignalsMappingRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The `EntitySignalsMapping` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateEntitySignalsMappingsResponse BatchCreateEntitySignalsMappings(string parent, scg::IEnumerable<CreateEntitySignalsMappingRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateEntitySignalsMappings(new BatchCreateEntitySignalsMappingsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch create `EntitySignalsMapping` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `EntitySignalsMappings` will be
        /// created. Format: `networks/{network_code}` The parent field in the
        /// CreateEntitySignalsMappingRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The `EntitySignalsMapping` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateEntitySignalsMappingsResponse> BatchCreateEntitySignalsMappingsAsync(string parent, scg::IEnumerable<CreateEntitySignalsMappingRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateEntitySignalsMappingsAsync(new BatchCreateEntitySignalsMappingsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch create `EntitySignalsMapping` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `EntitySignalsMappings` will be
        /// created. Format: `networks/{network_code}` The parent field in the
        /// CreateEntitySignalsMappingRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The `EntitySignalsMapping` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateEntitySignalsMappingsResponse> BatchCreateEntitySignalsMappingsAsync(string parent, scg::IEnumerable<CreateEntitySignalsMappingRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateEntitySignalsMappingsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch create `EntitySignalsMapping` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `EntitySignalsMappings` will be
        /// created. Format: `networks/{network_code}` The parent field in the
        /// CreateEntitySignalsMappingRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The `EntitySignalsMapping` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateEntitySignalsMappingsResponse BatchCreateEntitySignalsMappings(NetworkName parent, scg::IEnumerable<CreateEntitySignalsMappingRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateEntitySignalsMappings(new BatchCreateEntitySignalsMappingsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch create `EntitySignalsMapping` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `EntitySignalsMappings` will be
        /// created. Format: `networks/{network_code}` The parent field in the
        /// CreateEntitySignalsMappingRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The `EntitySignalsMapping` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateEntitySignalsMappingsResponse> BatchCreateEntitySignalsMappingsAsync(NetworkName parent, scg::IEnumerable<CreateEntitySignalsMappingRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateEntitySignalsMappingsAsync(new BatchCreateEntitySignalsMappingsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch create `EntitySignalsMapping` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `EntitySignalsMappings` will be
        /// created. Format: `networks/{network_code}` The parent field in the
        /// CreateEntitySignalsMappingRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The `EntitySignalsMapping` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateEntitySignalsMappingsResponse> BatchCreateEntitySignalsMappingsAsync(NetworkName parent, scg::IEnumerable<CreateEntitySignalsMappingRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateEntitySignalsMappingsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch update `EntitySignalsMapping` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateEntitySignalsMappingsResponse BatchUpdateEntitySignalsMappings(BatchUpdateEntitySignalsMappingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to batch update `EntitySignalsMapping` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateEntitySignalsMappingsResponse> BatchUpdateEntitySignalsMappingsAsync(BatchUpdateEntitySignalsMappingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to batch update `EntitySignalsMapping` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateEntitySignalsMappingsResponse> BatchUpdateEntitySignalsMappingsAsync(BatchUpdateEntitySignalsMappingsRequest request, st::CancellationToken cancellationToken) =>
            BatchUpdateEntitySignalsMappingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch update `EntitySignalsMapping` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `EntitySignalsMappings` will be
        /// updated. Format: `networks/{network_code}` The parent field in the
        /// UpdateEntitySignalsMappingRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The `EntitySignalsMapping` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateEntitySignalsMappingsResponse BatchUpdateEntitySignalsMappings(string parent, scg::IEnumerable<UpdateEntitySignalsMappingRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateEntitySignalsMappings(new BatchUpdateEntitySignalsMappingsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch update `EntitySignalsMapping` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `EntitySignalsMappings` will be
        /// updated. Format: `networks/{network_code}` The parent field in the
        /// UpdateEntitySignalsMappingRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The `EntitySignalsMapping` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateEntitySignalsMappingsResponse> BatchUpdateEntitySignalsMappingsAsync(string parent, scg::IEnumerable<UpdateEntitySignalsMappingRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateEntitySignalsMappingsAsync(new BatchUpdateEntitySignalsMappingsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch update `EntitySignalsMapping` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `EntitySignalsMappings` will be
        /// updated. Format: `networks/{network_code}` The parent field in the
        /// UpdateEntitySignalsMappingRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The `EntitySignalsMapping` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateEntitySignalsMappingsResponse> BatchUpdateEntitySignalsMappingsAsync(string parent, scg::IEnumerable<UpdateEntitySignalsMappingRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateEntitySignalsMappingsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch update `EntitySignalsMapping` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `EntitySignalsMappings` will be
        /// updated. Format: `networks/{network_code}` The parent field in the
        /// UpdateEntitySignalsMappingRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The `EntitySignalsMapping` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateEntitySignalsMappingsResponse BatchUpdateEntitySignalsMappings(NetworkName parent, scg::IEnumerable<UpdateEntitySignalsMappingRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateEntitySignalsMappings(new BatchUpdateEntitySignalsMappingsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch update `EntitySignalsMapping` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `EntitySignalsMappings` will be
        /// updated. Format: `networks/{network_code}` The parent field in the
        /// UpdateEntitySignalsMappingRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The `EntitySignalsMapping` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateEntitySignalsMappingsResponse> BatchUpdateEntitySignalsMappingsAsync(NetworkName parent, scg::IEnumerable<UpdateEntitySignalsMappingRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateEntitySignalsMappingsAsync(new BatchUpdateEntitySignalsMappingsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch update `EntitySignalsMapping` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `EntitySignalsMappings` will be
        /// updated. Format: `networks/{network_code}` The parent field in the
        /// UpdateEntitySignalsMappingRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The `EntitySignalsMapping` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateEntitySignalsMappingsResponse> BatchUpdateEntitySignalsMappingsAsync(NetworkName parent, scg::IEnumerable<UpdateEntitySignalsMappingRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateEntitySignalsMappingsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>EntitySignalsMappingService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `EntitySignalsMapping` objects.
    /// </remarks>
    public sealed partial class EntitySignalsMappingServiceClientImpl : EntitySignalsMappingServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetEntitySignalsMappingRequest, EntitySignalsMapping> _callGetEntitySignalsMapping;

        private readonly gaxgrpc::ApiCall<ListEntitySignalsMappingsRequest, ListEntitySignalsMappingsResponse> _callListEntitySignalsMappings;

        private readonly gaxgrpc::ApiCall<CreateEntitySignalsMappingRequest, EntitySignalsMapping> _callCreateEntitySignalsMapping;

        private readonly gaxgrpc::ApiCall<UpdateEntitySignalsMappingRequest, EntitySignalsMapping> _callUpdateEntitySignalsMapping;

        private readonly gaxgrpc::ApiCall<BatchCreateEntitySignalsMappingsRequest, BatchCreateEntitySignalsMappingsResponse> _callBatchCreateEntitySignalsMappings;

        private readonly gaxgrpc::ApiCall<BatchUpdateEntitySignalsMappingsRequest, BatchUpdateEntitySignalsMappingsResponse> _callBatchUpdateEntitySignalsMappings;

        /// <summary>
        /// Constructs a client wrapper for the EntitySignalsMappingService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="EntitySignalsMappingServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public EntitySignalsMappingServiceClientImpl(EntitySignalsMappingService.EntitySignalsMappingServiceClient grpcClient, EntitySignalsMappingServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            EntitySignalsMappingServiceSettings effectiveSettings = settings ?? EntitySignalsMappingServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetEntitySignalsMapping = clientHelper.BuildApiCall<GetEntitySignalsMappingRequest, EntitySignalsMapping>("GetEntitySignalsMapping", grpcClient.GetEntitySignalsMappingAsync, grpcClient.GetEntitySignalsMapping, effectiveSettings.GetEntitySignalsMappingSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEntitySignalsMapping);
            Modify_GetEntitySignalsMappingApiCall(ref _callGetEntitySignalsMapping);
            _callListEntitySignalsMappings = clientHelper.BuildApiCall<ListEntitySignalsMappingsRequest, ListEntitySignalsMappingsResponse>("ListEntitySignalsMappings", grpcClient.ListEntitySignalsMappingsAsync, grpcClient.ListEntitySignalsMappings, effectiveSettings.ListEntitySignalsMappingsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEntitySignalsMappings);
            Modify_ListEntitySignalsMappingsApiCall(ref _callListEntitySignalsMappings);
            _callCreateEntitySignalsMapping = clientHelper.BuildApiCall<CreateEntitySignalsMappingRequest, EntitySignalsMapping>("CreateEntitySignalsMapping", grpcClient.CreateEntitySignalsMappingAsync, grpcClient.CreateEntitySignalsMapping, effectiveSettings.CreateEntitySignalsMappingSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateEntitySignalsMapping);
            Modify_CreateEntitySignalsMappingApiCall(ref _callCreateEntitySignalsMapping);
            _callUpdateEntitySignalsMapping = clientHelper.BuildApiCall<UpdateEntitySignalsMappingRequest, EntitySignalsMapping>("UpdateEntitySignalsMapping", grpcClient.UpdateEntitySignalsMappingAsync, grpcClient.UpdateEntitySignalsMapping, effectiveSettings.UpdateEntitySignalsMappingSettings).WithGoogleRequestParam("entity_signals_mapping.name", request => request.EntitySignalsMapping?.Name);
            Modify_ApiCall(ref _callUpdateEntitySignalsMapping);
            Modify_UpdateEntitySignalsMappingApiCall(ref _callUpdateEntitySignalsMapping);
            _callBatchCreateEntitySignalsMappings = clientHelper.BuildApiCall<BatchCreateEntitySignalsMappingsRequest, BatchCreateEntitySignalsMappingsResponse>("BatchCreateEntitySignalsMappings", grpcClient.BatchCreateEntitySignalsMappingsAsync, grpcClient.BatchCreateEntitySignalsMappings, effectiveSettings.BatchCreateEntitySignalsMappingsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCreateEntitySignalsMappings);
            Modify_BatchCreateEntitySignalsMappingsApiCall(ref _callBatchCreateEntitySignalsMappings);
            _callBatchUpdateEntitySignalsMappings = clientHelper.BuildApiCall<BatchUpdateEntitySignalsMappingsRequest, BatchUpdateEntitySignalsMappingsResponse>("BatchUpdateEntitySignalsMappings", grpcClient.BatchUpdateEntitySignalsMappingsAsync, grpcClient.BatchUpdateEntitySignalsMappings, effectiveSettings.BatchUpdateEntitySignalsMappingsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchUpdateEntitySignalsMappings);
            Modify_BatchUpdateEntitySignalsMappingsApiCall(ref _callBatchUpdateEntitySignalsMappings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetEntitySignalsMappingApiCall(ref gaxgrpc::ApiCall<GetEntitySignalsMappingRequest, EntitySignalsMapping> call);

        partial void Modify_ListEntitySignalsMappingsApiCall(ref gaxgrpc::ApiCall<ListEntitySignalsMappingsRequest, ListEntitySignalsMappingsResponse> call);

        partial void Modify_CreateEntitySignalsMappingApiCall(ref gaxgrpc::ApiCall<CreateEntitySignalsMappingRequest, EntitySignalsMapping> call);

        partial void Modify_UpdateEntitySignalsMappingApiCall(ref gaxgrpc::ApiCall<UpdateEntitySignalsMappingRequest, EntitySignalsMapping> call);

        partial void Modify_BatchCreateEntitySignalsMappingsApiCall(ref gaxgrpc::ApiCall<BatchCreateEntitySignalsMappingsRequest, BatchCreateEntitySignalsMappingsResponse> call);

        partial void Modify_BatchUpdateEntitySignalsMappingsApiCall(ref gaxgrpc::ApiCall<BatchUpdateEntitySignalsMappingsRequest, BatchUpdateEntitySignalsMappingsResponse> call);

        partial void OnConstruction(EntitySignalsMappingService.EntitySignalsMappingServiceClient grpcClient, EntitySignalsMappingServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC EntitySignalsMappingService client</summary>
        public override EntitySignalsMappingService.EntitySignalsMappingServiceClient GrpcClient { get; }

        partial void Modify_GetEntitySignalsMappingRequest(ref GetEntitySignalsMappingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListEntitySignalsMappingsRequest(ref ListEntitySignalsMappingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateEntitySignalsMappingRequest(ref CreateEntitySignalsMappingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateEntitySignalsMappingRequest(ref UpdateEntitySignalsMappingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateEntitySignalsMappingsRequest(ref BatchCreateEntitySignalsMappingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUpdateEntitySignalsMappingsRequest(ref BatchUpdateEntitySignalsMappingsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// API to retrieve a `EntitySignalsMapping` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EntitySignalsMapping GetEntitySignalsMapping(GetEntitySignalsMappingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEntitySignalsMappingRequest(ref request, ref callSettings);
            return _callGetEntitySignalsMapping.Sync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a `EntitySignalsMapping` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EntitySignalsMapping> GetEntitySignalsMappingAsync(GetEntitySignalsMappingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEntitySignalsMappingRequest(ref request, ref callSettings);
            return _callGetEntitySignalsMapping.Async(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `EntitySignalsMapping` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EntitySignalsMapping"/> resources.</returns>
        public override gax::PagedEnumerable<ListEntitySignalsMappingsResponse, EntitySignalsMapping> ListEntitySignalsMappings(ListEntitySignalsMappingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEntitySignalsMappingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEntitySignalsMappingsRequest, ListEntitySignalsMappingsResponse, EntitySignalsMapping>(_callListEntitySignalsMappings, request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `EntitySignalsMapping` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EntitySignalsMapping"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEntitySignalsMappingsResponse, EntitySignalsMapping> ListEntitySignalsMappingsAsync(ListEntitySignalsMappingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEntitySignalsMappingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEntitySignalsMappingsRequest, ListEntitySignalsMappingsResponse, EntitySignalsMapping>(_callListEntitySignalsMappings, request, callSettings);
        }

        /// <summary>
        /// API to create an `EntitySignalsMapping` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EntitySignalsMapping CreateEntitySignalsMapping(CreateEntitySignalsMappingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEntitySignalsMappingRequest(ref request, ref callSettings);
            return _callCreateEntitySignalsMapping.Sync(request, callSettings);
        }

        /// <summary>
        /// API to create an `EntitySignalsMapping` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EntitySignalsMapping> CreateEntitySignalsMappingAsync(CreateEntitySignalsMappingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEntitySignalsMappingRequest(ref request, ref callSettings);
            return _callCreateEntitySignalsMapping.Async(request, callSettings);
        }

        /// <summary>
        /// API to update an `EntitySignalsMapping` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EntitySignalsMapping UpdateEntitySignalsMapping(UpdateEntitySignalsMappingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEntitySignalsMappingRequest(ref request, ref callSettings);
            return _callUpdateEntitySignalsMapping.Sync(request, callSettings);
        }

        /// <summary>
        /// API to update an `EntitySignalsMapping` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EntitySignalsMapping> UpdateEntitySignalsMappingAsync(UpdateEntitySignalsMappingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEntitySignalsMappingRequest(ref request, ref callSettings);
            return _callUpdateEntitySignalsMapping.Async(request, callSettings);
        }

        /// <summary>
        /// API to batch create `EntitySignalsMapping` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchCreateEntitySignalsMappingsResponse BatchCreateEntitySignalsMappings(BatchCreateEntitySignalsMappingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateEntitySignalsMappingsRequest(ref request, ref callSettings);
            return _callBatchCreateEntitySignalsMappings.Sync(request, callSettings);
        }

        /// <summary>
        /// API to batch create `EntitySignalsMapping` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchCreateEntitySignalsMappingsResponse> BatchCreateEntitySignalsMappingsAsync(BatchCreateEntitySignalsMappingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateEntitySignalsMappingsRequest(ref request, ref callSettings);
            return _callBatchCreateEntitySignalsMappings.Async(request, callSettings);
        }

        /// <summary>
        /// API to batch update `EntitySignalsMapping` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchUpdateEntitySignalsMappingsResponse BatchUpdateEntitySignalsMappings(BatchUpdateEntitySignalsMappingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateEntitySignalsMappingsRequest(ref request, ref callSettings);
            return _callBatchUpdateEntitySignalsMappings.Sync(request, callSettings);
        }

        /// <summary>
        /// API to batch update `EntitySignalsMapping` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchUpdateEntitySignalsMappingsResponse> BatchUpdateEntitySignalsMappingsAsync(BatchUpdateEntitySignalsMappingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateEntitySignalsMappingsRequest(ref request, ref callSettings);
            return _callBatchUpdateEntitySignalsMappings.Async(request, callSettings);
        }
    }

    public partial class ListEntitySignalsMappingsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEntitySignalsMappingsResponse : gaxgrpc::IPageResponse<EntitySignalsMapping>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<EntitySignalsMapping> GetEnumerator() => EntitySignalsMappings.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
