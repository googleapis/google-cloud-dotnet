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

namespace Google.Cloud.Chronicle.V1
{
    /// <summary>Settings for <see cref="EntityServiceClient"/> instances.</summary>
    public sealed partial class EntityServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="EntityServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="EntityServiceSettings"/>.</returns>
        public static EntityServiceSettings GetDefault() => new EntityServiceSettings();

        /// <summary>Constructs a new <see cref="EntityServiceSettings"/> object with default settings.</summary>
        public EntityServiceSettings()
        {
        }

        private EntityServiceSettings(EntityServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetWatchlistSettings = existing.GetWatchlistSettings;
            ListWatchlistsSettings = existing.ListWatchlistsSettings;
            CreateWatchlistSettings = existing.CreateWatchlistSettings;
            UpdateWatchlistSettings = existing.UpdateWatchlistSettings;
            DeleteWatchlistSettings = existing.DeleteWatchlistSettings;
            OnCopy(existing);
        }

        partial void OnCopy(EntityServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EntityServiceClient.GetWatchlist</c> and <c>EntityServiceClient.GetWatchlistAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 90000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 90 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetWatchlistSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(90000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(90000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EntityServiceClient.ListWatchlists</c> and <c>EntityServiceClient.ListWatchlistsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 90000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 90 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListWatchlistsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(90000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(90000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EntityServiceClient.CreateWatchlist</c> and <c>EntityServiceClient.CreateWatchlistAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 90 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateWatchlistSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(90000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EntityServiceClient.UpdateWatchlist</c> and <c>EntityServiceClient.UpdateWatchlistAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 90 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateWatchlistSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(90000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EntityServiceClient.DeleteWatchlist</c> and <c>EntityServiceClient.DeleteWatchlistAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 90 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteWatchlistSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(90000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="EntityServiceSettings"/> object.</returns>
        public EntityServiceSettings Clone() => new EntityServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="EntityServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class EntityServiceClientBuilder : gaxgrpc::ClientBuilderBase<EntityServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public EntityServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public EntityServiceClientBuilder() : base(EntityServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref EntityServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<EntityServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override EntityServiceClient Build()
        {
            EntityServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<EntityServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<EntityServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private EntityServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return EntityServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<EntityServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return EntityServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => EntityServiceClient.ChannelPool;
    }

    /// <summary>EntityService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// EntityService contains apis for finding entities.
    /// </remarks>
    public abstract partial class EntityServiceClient
    {
        /// <summary>
        /// The default endpoint for the EntityService service, which is a host of "chronicle.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "chronicle.googleapis.com:443";

        /// <summary>The default EntityService scopes.</summary>
        /// <remarks>
        /// The default EntityService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(EntityService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="EntityServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="EntityServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="EntityServiceClient"/>.</returns>
        public static stt::Task<EntityServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new EntityServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="EntityServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="EntityServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="EntityServiceClient"/>.</returns>
        public static EntityServiceClient Create() => new EntityServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="EntityServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="EntityServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="EntityServiceClient"/>.</returns>
        internal static EntityServiceClient Create(grpccore::CallInvoker callInvoker, EntityServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            EntityService.EntityServiceClient grpcClient = new EntityService.EntityServiceClient(callInvoker);
            return new EntityServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC EntityService client</summary>
        public virtual EntityService.EntityServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets watchlist details for the given watchlist ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Watchlist GetWatchlist(GetWatchlistRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets watchlist details for the given watchlist ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Watchlist> GetWatchlistAsync(GetWatchlistRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets watchlist details for the given watchlist ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Watchlist> GetWatchlistAsync(GetWatchlistRequest request, st::CancellationToken cancellationToken) =>
            GetWatchlistAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets watchlist details for the given watchlist ID.
        /// </summary>
        /// <param name="name">
        /// Required. The parent, which owns this collection of watchlists.
        /// The name of the watchlist to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/watchlists/{watchlist}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Watchlist GetWatchlist(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetWatchlist(new GetWatchlistRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets watchlist details for the given watchlist ID.
        /// </summary>
        /// <param name="name">
        /// Required. The parent, which owns this collection of watchlists.
        /// The name of the watchlist to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/watchlists/{watchlist}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Watchlist> GetWatchlistAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetWatchlistAsync(new GetWatchlistRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets watchlist details for the given watchlist ID.
        /// </summary>
        /// <param name="name">
        /// Required. The parent, which owns this collection of watchlists.
        /// The name of the watchlist to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/watchlists/{watchlist}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Watchlist> GetWatchlistAsync(string name, st::CancellationToken cancellationToken) =>
            GetWatchlistAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets watchlist details for the given watchlist ID.
        /// </summary>
        /// <param name="name">
        /// Required. The parent, which owns this collection of watchlists.
        /// The name of the watchlist to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/watchlists/{watchlist}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Watchlist GetWatchlist(WatchlistName name, gaxgrpc::CallSettings callSettings = null) =>
            GetWatchlist(new GetWatchlistRequest
            {
                WatchlistName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets watchlist details for the given watchlist ID.
        /// </summary>
        /// <param name="name">
        /// Required. The parent, which owns this collection of watchlists.
        /// The name of the watchlist to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/watchlists/{watchlist}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Watchlist> GetWatchlistAsync(WatchlistName name, gaxgrpc::CallSettings callSettings = null) =>
            GetWatchlistAsync(new GetWatchlistRequest
            {
                WatchlistName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets watchlist details for the given watchlist ID.
        /// </summary>
        /// <param name="name">
        /// Required. The parent, which owns this collection of watchlists.
        /// The name of the watchlist to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/watchlists/{watchlist}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Watchlist> GetWatchlistAsync(WatchlistName name, st::CancellationToken cancellationToken) =>
            GetWatchlistAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all watchlists for the given instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Watchlist"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWatchlistsResponse, Watchlist> ListWatchlists(ListWatchlistsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all watchlists for the given instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Watchlist"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWatchlistsResponse, Watchlist> ListWatchlistsAsync(ListWatchlistsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all watchlists for the given instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of watchlists.
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
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
        /// <returns>A pageable sequence of <see cref="Watchlist"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWatchlistsResponse, Watchlist> ListWatchlists(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWatchlistsRequest request = new ListWatchlistsRequest
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
            return ListWatchlists(request, callSettings);
        }

        /// <summary>
        /// Lists all watchlists for the given instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of watchlists.
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Watchlist"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWatchlistsResponse, Watchlist> ListWatchlistsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWatchlistsRequest request = new ListWatchlistsRequest
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
            return ListWatchlistsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all watchlists for the given instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of watchlists.
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
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
        /// <returns>A pageable sequence of <see cref="Watchlist"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWatchlistsResponse, Watchlist> ListWatchlists(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWatchlistsRequest request = new ListWatchlistsRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListWatchlists(request, callSettings);
        }

        /// <summary>
        /// Lists all watchlists for the given instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of watchlists.
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Watchlist"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWatchlistsResponse, Watchlist> ListWatchlistsAsync(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWatchlistsRequest request = new ListWatchlistsRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListWatchlistsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a watchlist for the given instance.
        /// Note that there can be at most 200 watchlists per instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Watchlist CreateWatchlist(CreateWatchlistRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a watchlist for the given instance.
        /// Note that there can be at most 200 watchlists per instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Watchlist> CreateWatchlistAsync(CreateWatchlistRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a watchlist for the given instance.
        /// Note that there can be at most 200 watchlists per instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Watchlist> CreateWatchlistAsync(CreateWatchlistRequest request, st::CancellationToken cancellationToken) =>
            CreateWatchlistAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a watchlist for the given instance.
        /// Note that there can be at most 200 watchlists per instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this watchlist will be created.
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
        /// </param>
        /// <param name="watchlist">
        /// Required. The watchlist to create.
        /// </param>
        /// <param name="watchlistId">
        /// Optional. The ID to use for the watchlist,
        /// which will become the final component of the watchlist's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Watchlist CreateWatchlist(string parent, Watchlist watchlist, string watchlistId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWatchlist(new CreateWatchlistRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                WatchlistId = watchlistId ?? "",
                Watchlist = gax::GaxPreconditions.CheckNotNull(watchlist, nameof(watchlist)),
            }, callSettings);

        /// <summary>
        /// Creates a watchlist for the given instance.
        /// Note that there can be at most 200 watchlists per instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this watchlist will be created.
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
        /// </param>
        /// <param name="watchlist">
        /// Required. The watchlist to create.
        /// </param>
        /// <param name="watchlistId">
        /// Optional. The ID to use for the watchlist,
        /// which will become the final component of the watchlist's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Watchlist> CreateWatchlistAsync(string parent, Watchlist watchlist, string watchlistId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWatchlistAsync(new CreateWatchlistRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                WatchlistId = watchlistId ?? "",
                Watchlist = gax::GaxPreconditions.CheckNotNull(watchlist, nameof(watchlist)),
            }, callSettings);

        /// <summary>
        /// Creates a watchlist for the given instance.
        /// Note that there can be at most 200 watchlists per instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this watchlist will be created.
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
        /// </param>
        /// <param name="watchlist">
        /// Required. The watchlist to create.
        /// </param>
        /// <param name="watchlistId">
        /// Optional. The ID to use for the watchlist,
        /// which will become the final component of the watchlist's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Watchlist> CreateWatchlistAsync(string parent, Watchlist watchlist, string watchlistId, st::CancellationToken cancellationToken) =>
            CreateWatchlistAsync(parent, watchlist, watchlistId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a watchlist for the given instance.
        /// Note that there can be at most 200 watchlists per instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this watchlist will be created.
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
        /// </param>
        /// <param name="watchlist">
        /// Required. The watchlist to create.
        /// </param>
        /// <param name="watchlistId">
        /// Optional. The ID to use for the watchlist,
        /// which will become the final component of the watchlist's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Watchlist CreateWatchlist(InstanceName parent, Watchlist watchlist, string watchlistId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWatchlist(new CreateWatchlistRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                WatchlistId = watchlistId ?? "",
                Watchlist = gax::GaxPreconditions.CheckNotNull(watchlist, nameof(watchlist)),
            }, callSettings);

        /// <summary>
        /// Creates a watchlist for the given instance.
        /// Note that there can be at most 200 watchlists per instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this watchlist will be created.
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
        /// </param>
        /// <param name="watchlist">
        /// Required. The watchlist to create.
        /// </param>
        /// <param name="watchlistId">
        /// Optional. The ID to use for the watchlist,
        /// which will become the final component of the watchlist's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Watchlist> CreateWatchlistAsync(InstanceName parent, Watchlist watchlist, string watchlistId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWatchlistAsync(new CreateWatchlistRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                WatchlistId = watchlistId ?? "",
                Watchlist = gax::GaxPreconditions.CheckNotNull(watchlist, nameof(watchlist)),
            }, callSettings);

        /// <summary>
        /// Creates a watchlist for the given instance.
        /// Note that there can be at most 200 watchlists per instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this watchlist will be created.
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
        /// </param>
        /// <param name="watchlist">
        /// Required. The watchlist to create.
        /// </param>
        /// <param name="watchlistId">
        /// Optional. The ID to use for the watchlist,
        /// which will become the final component of the watchlist's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Watchlist> CreateWatchlistAsync(InstanceName parent, Watchlist watchlist, string watchlistId, st::CancellationToken cancellationToken) =>
            CreateWatchlistAsync(parent, watchlist, watchlistId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the watchlist for the given instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Watchlist UpdateWatchlist(UpdateWatchlistRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the watchlist for the given instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Watchlist> UpdateWatchlistAsync(UpdateWatchlistRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the watchlist for the given instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Watchlist> UpdateWatchlistAsync(UpdateWatchlistRequest request, st::CancellationToken cancellationToken) =>
            UpdateWatchlistAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the watchlist for the given instance.
        /// </summary>
        /// <param name="watchlist">
        /// Required. The watchlist to update.
        /// 
        /// The watchlist's `name` field is used to identify the watchlist to update.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/watchlists/{watchlist}`
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Watchlist UpdateWatchlist(Watchlist watchlist, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateWatchlist(new UpdateWatchlistRequest
            {
                Watchlist = gax::GaxPreconditions.CheckNotNull(watchlist, nameof(watchlist)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the watchlist for the given instance.
        /// </summary>
        /// <param name="watchlist">
        /// Required. The watchlist to update.
        /// 
        /// The watchlist's `name` field is used to identify the watchlist to update.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/watchlists/{watchlist}`
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Watchlist> UpdateWatchlistAsync(Watchlist watchlist, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateWatchlistAsync(new UpdateWatchlistRequest
            {
                Watchlist = gax::GaxPreconditions.CheckNotNull(watchlist, nameof(watchlist)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the watchlist for the given instance.
        /// </summary>
        /// <param name="watchlist">
        /// Required. The watchlist to update.
        /// 
        /// The watchlist's `name` field is used to identify the watchlist to update.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/watchlists/{watchlist}`
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Watchlist> UpdateWatchlistAsync(Watchlist watchlist, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateWatchlistAsync(watchlist, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the watchlist for the given instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteWatchlist(DeleteWatchlistRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the watchlist for the given instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteWatchlistAsync(DeleteWatchlistRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the watchlist for the given instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteWatchlistAsync(DeleteWatchlistRequest request, st::CancellationToken cancellationToken) =>
            DeleteWatchlistAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the watchlist for the given instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the watchlist to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/watchlists/{watchlist}`
        /// </param>
        /// <param name="force">
        /// Optional. If set to true, any entities under this watchlist will also be
        /// deleted. (Otherwise, the request will only work if the watchlist has no
        /// entities.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteWatchlist(string name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWatchlist(new DeleteWatchlistRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Deletes the watchlist for the given instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the watchlist to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/watchlists/{watchlist}`
        /// </param>
        /// <param name="force">
        /// Optional. If set to true, any entities under this watchlist will also be
        /// deleted. (Otherwise, the request will only work if the watchlist has no
        /// entities.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteWatchlistAsync(string name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWatchlistAsync(new DeleteWatchlistRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Deletes the watchlist for the given instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the watchlist to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/watchlists/{watchlist}`
        /// </param>
        /// <param name="force">
        /// Optional. If set to true, any entities under this watchlist will also be
        /// deleted. (Otherwise, the request will only work if the watchlist has no
        /// entities.)
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteWatchlistAsync(string name, bool force, st::CancellationToken cancellationToken) =>
            DeleteWatchlistAsync(name, force, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the watchlist for the given instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the watchlist to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/watchlists/{watchlist}`
        /// </param>
        /// <param name="force">
        /// Optional. If set to true, any entities under this watchlist will also be
        /// deleted. (Otherwise, the request will only work if the watchlist has no
        /// entities.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteWatchlist(WatchlistName name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWatchlist(new DeleteWatchlistRequest
            {
                WatchlistName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Deletes the watchlist for the given instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the watchlist to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/watchlists/{watchlist}`
        /// </param>
        /// <param name="force">
        /// Optional. If set to true, any entities under this watchlist will also be
        /// deleted. (Otherwise, the request will only work if the watchlist has no
        /// entities.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteWatchlistAsync(WatchlistName name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWatchlistAsync(new DeleteWatchlistRequest
            {
                WatchlistName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Deletes the watchlist for the given instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the watchlist to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/watchlists/{watchlist}`
        /// </param>
        /// <param name="force">
        /// Optional. If set to true, any entities under this watchlist will also be
        /// deleted. (Otherwise, the request will only work if the watchlist has no
        /// entities.)
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteWatchlistAsync(WatchlistName name, bool force, st::CancellationToken cancellationToken) =>
            DeleteWatchlistAsync(name, force, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>EntityService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// EntityService contains apis for finding entities.
    /// </remarks>
    public sealed partial class EntityServiceClientImpl : EntityServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetWatchlistRequest, Watchlist> _callGetWatchlist;

        private readonly gaxgrpc::ApiCall<ListWatchlistsRequest, ListWatchlistsResponse> _callListWatchlists;

        private readonly gaxgrpc::ApiCall<CreateWatchlistRequest, Watchlist> _callCreateWatchlist;

        private readonly gaxgrpc::ApiCall<UpdateWatchlistRequest, Watchlist> _callUpdateWatchlist;

        private readonly gaxgrpc::ApiCall<DeleteWatchlistRequest, wkt::Empty> _callDeleteWatchlist;

        /// <summary>
        /// Constructs a client wrapper for the EntityService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="EntityServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public EntityServiceClientImpl(EntityService.EntityServiceClient grpcClient, EntityServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            EntityServiceSettings effectiveSettings = settings ?? EntityServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetWatchlist = clientHelper.BuildApiCall<GetWatchlistRequest, Watchlist>("GetWatchlist", grpcClient.GetWatchlistAsync, grpcClient.GetWatchlist, effectiveSettings.GetWatchlistSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetWatchlist);
            Modify_GetWatchlistApiCall(ref _callGetWatchlist);
            _callListWatchlists = clientHelper.BuildApiCall<ListWatchlistsRequest, ListWatchlistsResponse>("ListWatchlists", grpcClient.ListWatchlistsAsync, grpcClient.ListWatchlists, effectiveSettings.ListWatchlistsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListWatchlists);
            Modify_ListWatchlistsApiCall(ref _callListWatchlists);
            _callCreateWatchlist = clientHelper.BuildApiCall<CreateWatchlistRequest, Watchlist>("CreateWatchlist", grpcClient.CreateWatchlistAsync, grpcClient.CreateWatchlist, effectiveSettings.CreateWatchlistSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateWatchlist);
            Modify_CreateWatchlistApiCall(ref _callCreateWatchlist);
            _callUpdateWatchlist = clientHelper.BuildApiCall<UpdateWatchlistRequest, Watchlist>("UpdateWatchlist", grpcClient.UpdateWatchlistAsync, grpcClient.UpdateWatchlist, effectiveSettings.UpdateWatchlistSettings).WithGoogleRequestParam("watchlist.name", request => request.Watchlist?.Name);
            Modify_ApiCall(ref _callUpdateWatchlist);
            Modify_UpdateWatchlistApiCall(ref _callUpdateWatchlist);
            _callDeleteWatchlist = clientHelper.BuildApiCall<DeleteWatchlistRequest, wkt::Empty>("DeleteWatchlist", grpcClient.DeleteWatchlistAsync, grpcClient.DeleteWatchlist, effectiveSettings.DeleteWatchlistSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteWatchlist);
            Modify_DeleteWatchlistApiCall(ref _callDeleteWatchlist);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetWatchlistApiCall(ref gaxgrpc::ApiCall<GetWatchlistRequest, Watchlist> call);

        partial void Modify_ListWatchlistsApiCall(ref gaxgrpc::ApiCall<ListWatchlistsRequest, ListWatchlistsResponse> call);

        partial void Modify_CreateWatchlistApiCall(ref gaxgrpc::ApiCall<CreateWatchlistRequest, Watchlist> call);

        partial void Modify_UpdateWatchlistApiCall(ref gaxgrpc::ApiCall<UpdateWatchlistRequest, Watchlist> call);

        partial void Modify_DeleteWatchlistApiCall(ref gaxgrpc::ApiCall<DeleteWatchlistRequest, wkt::Empty> call);

        partial void OnConstruction(EntityService.EntityServiceClient grpcClient, EntityServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC EntityService client</summary>
        public override EntityService.EntityServiceClient GrpcClient { get; }

        partial void Modify_GetWatchlistRequest(ref GetWatchlistRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListWatchlistsRequest(ref ListWatchlistsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateWatchlistRequest(ref CreateWatchlistRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateWatchlistRequest(ref UpdateWatchlistRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteWatchlistRequest(ref DeleteWatchlistRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets watchlist details for the given watchlist ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Watchlist GetWatchlist(GetWatchlistRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetWatchlistRequest(ref request, ref callSettings);
            return _callGetWatchlist.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets watchlist details for the given watchlist ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Watchlist> GetWatchlistAsync(GetWatchlistRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetWatchlistRequest(ref request, ref callSettings);
            return _callGetWatchlist.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all watchlists for the given instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Watchlist"/> resources.</returns>
        public override gax::PagedEnumerable<ListWatchlistsResponse, Watchlist> ListWatchlists(ListWatchlistsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListWatchlistsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListWatchlistsRequest, ListWatchlistsResponse, Watchlist>(_callListWatchlists, request, callSettings);
        }

        /// <summary>
        /// Lists all watchlists for the given instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Watchlist"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListWatchlistsResponse, Watchlist> ListWatchlistsAsync(ListWatchlistsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListWatchlistsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListWatchlistsRequest, ListWatchlistsResponse, Watchlist>(_callListWatchlists, request, callSettings);
        }

        /// <summary>
        /// Creates a watchlist for the given instance.
        /// Note that there can be at most 200 watchlists per instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Watchlist CreateWatchlist(CreateWatchlistRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateWatchlistRequest(ref request, ref callSettings);
            return _callCreateWatchlist.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a watchlist for the given instance.
        /// Note that there can be at most 200 watchlists per instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Watchlist> CreateWatchlistAsync(CreateWatchlistRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateWatchlistRequest(ref request, ref callSettings);
            return _callCreateWatchlist.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the watchlist for the given instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Watchlist UpdateWatchlist(UpdateWatchlistRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateWatchlistRequest(ref request, ref callSettings);
            return _callUpdateWatchlist.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the watchlist for the given instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Watchlist> UpdateWatchlistAsync(UpdateWatchlistRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateWatchlistRequest(ref request, ref callSettings);
            return _callUpdateWatchlist.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the watchlist for the given instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteWatchlist(DeleteWatchlistRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteWatchlistRequest(ref request, ref callSettings);
            _callDeleteWatchlist.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the watchlist for the given instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteWatchlistAsync(DeleteWatchlistRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteWatchlistRequest(ref request, ref callSettings);
            return _callDeleteWatchlist.Async(request, callSettings);
        }
    }

    public partial class ListWatchlistsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListWatchlistsResponse : gaxgrpc::IPageResponse<Watchlist>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Watchlist> GetEnumerator() => Watchlists.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
