// Copyright 2026 Google LLC
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
    /// <summary>Settings for <see cref="CreativeSetServiceClient"/> instances.</summary>
    public sealed partial class CreativeSetServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CreativeSetServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CreativeSetServiceSettings"/>.</returns>
        public static CreativeSetServiceSettings GetDefault() => new CreativeSetServiceSettings();

        /// <summary>Constructs a new <see cref="CreativeSetServiceSettings"/> object with default settings.</summary>
        public CreativeSetServiceSettings()
        {
        }

        private CreativeSetServiceSettings(CreativeSetServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCreativeSetSettings = existing.GetCreativeSetSettings;
            ListCreativeSetsSettings = existing.ListCreativeSetsSettings;
            CreateCreativeSetSettings = existing.CreateCreativeSetSettings;
            UpdateCreativeSetSettings = existing.UpdateCreativeSetSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CreativeSetServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CreativeSetServiceClient.GetCreativeSet</c> and <c>CreativeSetServiceClient.GetCreativeSetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCreativeSetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CreativeSetServiceClient.ListCreativeSets</c> and <c>CreativeSetServiceClient.ListCreativeSetsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCreativeSetsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CreativeSetServiceClient.CreateCreativeSet</c> and <c>CreativeSetServiceClient.CreateCreativeSetAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateCreativeSetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CreativeSetServiceClient.UpdateCreativeSet</c> and <c>CreativeSetServiceClient.UpdateCreativeSetAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateCreativeSetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CreativeSetServiceSettings"/> object.</returns>
        public CreativeSetServiceSettings Clone() => new CreativeSetServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CreativeSetServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class CreativeSetServiceClientBuilder : gaxgrpc::ClientBuilderBase<CreativeSetServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CreativeSetServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CreativeSetServiceClientBuilder() : base(CreativeSetServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CreativeSetServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CreativeSetServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CreativeSetServiceClient Build()
        {
            CreativeSetServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CreativeSetServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CreativeSetServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CreativeSetServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CreativeSetServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CreativeSetServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CreativeSetServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CreativeSetServiceClient.ChannelPool;
    }

    /// <summary>CreativeSetService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `CreativeSet` objects.
    /// </remarks>
    public abstract partial class CreativeSetServiceClient
    {
        /// <summary>
        /// The default endpoint for the CreativeSetService service, which is a host of "admanager.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default CreativeSetService scopes.</summary>
        /// <remarks>
        /// The default CreativeSetService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/admanager</description></item>
        /// <item><description>https://www.googleapis.com/auth/admanager.readonly</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admanager",
            "https://www.googleapis.com/auth/admanager.readonly",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CreativeSetService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CreativeSetServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CreativeSetServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CreativeSetServiceClient"/>.</returns>
        public static stt::Task<CreativeSetServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CreativeSetServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CreativeSetServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CreativeSetServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="CreativeSetServiceClient"/>.</returns>
        public static CreativeSetServiceClient Create() => new CreativeSetServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CreativeSetServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CreativeSetServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CreativeSetServiceClient"/>.</returns>
        internal static CreativeSetServiceClient Create(grpccore::CallInvoker callInvoker, CreativeSetServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CreativeSetService.CreativeSetServiceClient grpcClient = new CreativeSetService.CreativeSetServiceClient(callInvoker);
            return new CreativeSetServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CreativeSetService client</summary>
        public virtual CreativeSetService.CreativeSetServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `CreativeSet` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CreativeSet GetCreativeSet(GetCreativeSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `CreativeSet` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreativeSet> GetCreativeSetAsync(GetCreativeSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `CreativeSet` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreativeSet> GetCreativeSetAsync(GetCreativeSetRequest request, st::CancellationToken cancellationToken) =>
            GetCreativeSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `CreativeSet` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CreativeSet.
        /// Format: `networks/{network_code}/creativeSets/{creative_set_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CreativeSet GetCreativeSet(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCreativeSet(new GetCreativeSetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `CreativeSet` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CreativeSet.
        /// Format: `networks/{network_code}/creativeSets/{creative_set_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreativeSet> GetCreativeSetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCreativeSetAsync(new GetCreativeSetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `CreativeSet` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CreativeSet.
        /// Format: `networks/{network_code}/creativeSets/{creative_set_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreativeSet> GetCreativeSetAsync(string name, st::CancellationToken cancellationToken) =>
            GetCreativeSetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `CreativeSet` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CreativeSet.
        /// Format: `networks/{network_code}/creativeSets/{creative_set_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CreativeSet GetCreativeSet(CreativeSetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCreativeSet(new GetCreativeSetRequest
            {
                CreativeSetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `CreativeSet` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CreativeSet.
        /// Format: `networks/{network_code}/creativeSets/{creative_set_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreativeSet> GetCreativeSetAsync(CreativeSetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCreativeSetAsync(new GetCreativeSetRequest
            {
                CreativeSetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `CreativeSet` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CreativeSet.
        /// Format: `networks/{network_code}/creativeSets/{creative_set_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreativeSet> GetCreativeSetAsync(CreativeSetName name, st::CancellationToken cancellationToken) =>
            GetCreativeSetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists `CreativeSet` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CreativeSet"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCreativeSetsResponse, CreativeSet> ListCreativeSets(ListCreativeSetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `CreativeSet` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CreativeSet"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCreativeSetsResponse, CreativeSet> ListCreativeSetsAsync(ListCreativeSetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `CreativeSet` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CreativeSets.
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
        /// <returns>A pageable sequence of <see cref="CreativeSet"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCreativeSetsResponse, CreativeSet> ListCreativeSets(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCreativeSetsRequest request = new ListCreativeSetsRequest
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
            return ListCreativeSets(request, callSettings);
        }

        /// <summary>
        /// Lists `CreativeSet` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CreativeSets.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CreativeSet"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCreativeSetsResponse, CreativeSet> ListCreativeSetsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCreativeSetsRequest request = new ListCreativeSetsRequest
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
            return ListCreativeSetsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists `CreativeSet` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CreativeSets.
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
        /// <returns>A pageable sequence of <see cref="CreativeSet"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCreativeSetsResponse, CreativeSet> ListCreativeSets(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCreativeSetsRequest request = new ListCreativeSetsRequest
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
            return ListCreativeSets(request, callSettings);
        }

        /// <summary>
        /// Lists `CreativeSet` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CreativeSets.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CreativeSet"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCreativeSetsResponse, CreativeSet> ListCreativeSetsAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCreativeSetsRequest request = new ListCreativeSetsRequest
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
            return ListCreativeSetsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a `CreativeSet` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CreativeSet CreateCreativeSet(CreateCreativeSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `CreativeSet` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreativeSet> CreateCreativeSetAsync(CreateCreativeSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `CreativeSet` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreativeSet> CreateCreativeSetAsync(CreateCreativeSetRequest request, st::CancellationToken cancellationToken) =>
            CreateCreativeSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `CreativeSet` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `CreativeSet` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="creativeSet">
        /// Required. The `CreativeSet` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CreativeSet CreateCreativeSet(string parent, CreativeSet creativeSet, gaxgrpc::CallSettings callSettings = null) =>
            CreateCreativeSet(new CreateCreativeSetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CreativeSet = gax::GaxPreconditions.CheckNotNull(creativeSet, nameof(creativeSet)),
            }, callSettings);

        /// <summary>
        /// Creates a `CreativeSet` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `CreativeSet` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="creativeSet">
        /// Required. The `CreativeSet` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreativeSet> CreateCreativeSetAsync(string parent, CreativeSet creativeSet, gaxgrpc::CallSettings callSettings = null) =>
            CreateCreativeSetAsync(new CreateCreativeSetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CreativeSet = gax::GaxPreconditions.CheckNotNull(creativeSet, nameof(creativeSet)),
            }, callSettings);

        /// <summary>
        /// Creates a `CreativeSet` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `CreativeSet` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="creativeSet">
        /// Required. The `CreativeSet` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreativeSet> CreateCreativeSetAsync(string parent, CreativeSet creativeSet, st::CancellationToken cancellationToken) =>
            CreateCreativeSetAsync(parent, creativeSet, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `CreativeSet` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `CreativeSet` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="creativeSet">
        /// Required. The `CreativeSet` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CreativeSet CreateCreativeSet(NetworkName parent, CreativeSet creativeSet, gaxgrpc::CallSettings callSettings = null) =>
            CreateCreativeSet(new CreateCreativeSetRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CreativeSet = gax::GaxPreconditions.CheckNotNull(creativeSet, nameof(creativeSet)),
            }, callSettings);

        /// <summary>
        /// Creates a `CreativeSet` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `CreativeSet` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="creativeSet">
        /// Required. The `CreativeSet` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreativeSet> CreateCreativeSetAsync(NetworkName parent, CreativeSet creativeSet, gaxgrpc::CallSettings callSettings = null) =>
            CreateCreativeSetAsync(new CreateCreativeSetRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CreativeSet = gax::GaxPreconditions.CheckNotNull(creativeSet, nameof(creativeSet)),
            }, callSettings);

        /// <summary>
        /// Creates a `CreativeSet` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `CreativeSet` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="creativeSet">
        /// Required. The `CreativeSet` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreativeSet> CreateCreativeSetAsync(NetworkName parent, CreativeSet creativeSet, st::CancellationToken cancellationToken) =>
            CreateCreativeSetAsync(parent, creativeSet, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `CreativeSet` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CreativeSet UpdateCreativeSet(UpdateCreativeSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `CreativeSet` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreativeSet> UpdateCreativeSetAsync(UpdateCreativeSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `CreativeSet` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreativeSet> UpdateCreativeSetAsync(UpdateCreativeSetRequest request, st::CancellationToken cancellationToken) =>
            UpdateCreativeSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `CreativeSet` object.
        /// </summary>
        /// <param name="creativeSet">
        /// Required. The `CreativeSet` to update.
        /// 
        /// The `CreativeSet`'s `name` is used to identify the `CreativeSet` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CreativeSet UpdateCreativeSet(CreativeSet creativeSet, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCreativeSet(new UpdateCreativeSetRequest
            {
                CreativeSet = gax::GaxPreconditions.CheckNotNull(creativeSet, nameof(creativeSet)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a `CreativeSet` object.
        /// </summary>
        /// <param name="creativeSet">
        /// Required. The `CreativeSet` to update.
        /// 
        /// The `CreativeSet`'s `name` is used to identify the `CreativeSet` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreativeSet> UpdateCreativeSetAsync(CreativeSet creativeSet, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCreativeSetAsync(new UpdateCreativeSetRequest
            {
                CreativeSet = gax::GaxPreconditions.CheckNotNull(creativeSet, nameof(creativeSet)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a `CreativeSet` object.
        /// </summary>
        /// <param name="creativeSet">
        /// Required. The `CreativeSet` to update.
        /// 
        /// The `CreativeSet`'s `name` is used to identify the `CreativeSet` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreativeSet> UpdateCreativeSetAsync(CreativeSet creativeSet, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateCreativeSetAsync(creativeSet, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CreativeSetService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `CreativeSet` objects.
    /// </remarks>
    public sealed partial class CreativeSetServiceClientImpl : CreativeSetServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCreativeSetRequest, CreativeSet> _callGetCreativeSet;

        private readonly gaxgrpc::ApiCall<ListCreativeSetsRequest, ListCreativeSetsResponse> _callListCreativeSets;

        private readonly gaxgrpc::ApiCall<CreateCreativeSetRequest, CreativeSet> _callCreateCreativeSet;

        private readonly gaxgrpc::ApiCall<UpdateCreativeSetRequest, CreativeSet> _callUpdateCreativeSet;

        /// <summary>
        /// Constructs a client wrapper for the CreativeSetService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CreativeSetServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CreativeSetServiceClientImpl(CreativeSetService.CreativeSetServiceClient grpcClient, CreativeSetServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CreativeSetServiceSettings effectiveSettings = settings ?? CreativeSetServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetCreativeSet = clientHelper.BuildApiCall<GetCreativeSetRequest, CreativeSet>("GetCreativeSet", grpcClient.GetCreativeSetAsync, grpcClient.GetCreativeSet, effectiveSettings.GetCreativeSetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCreativeSet);
            Modify_GetCreativeSetApiCall(ref _callGetCreativeSet);
            _callListCreativeSets = clientHelper.BuildApiCall<ListCreativeSetsRequest, ListCreativeSetsResponse>("ListCreativeSets", grpcClient.ListCreativeSetsAsync, grpcClient.ListCreativeSets, effectiveSettings.ListCreativeSetsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCreativeSets);
            Modify_ListCreativeSetsApiCall(ref _callListCreativeSets);
            _callCreateCreativeSet = clientHelper.BuildApiCall<CreateCreativeSetRequest, CreativeSet>("CreateCreativeSet", grpcClient.CreateCreativeSetAsync, grpcClient.CreateCreativeSet, effectiveSettings.CreateCreativeSetSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCreativeSet);
            Modify_CreateCreativeSetApiCall(ref _callCreateCreativeSet);
            _callUpdateCreativeSet = clientHelper.BuildApiCall<UpdateCreativeSetRequest, CreativeSet>("UpdateCreativeSet", grpcClient.UpdateCreativeSetAsync, grpcClient.UpdateCreativeSet, effectiveSettings.UpdateCreativeSetSettings).WithGoogleRequestParam("creative_set.name", request => request.CreativeSet?.Name);
            Modify_ApiCall(ref _callUpdateCreativeSet);
            Modify_UpdateCreativeSetApiCall(ref _callUpdateCreativeSet);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetCreativeSetApiCall(ref gaxgrpc::ApiCall<GetCreativeSetRequest, CreativeSet> call);

        partial void Modify_ListCreativeSetsApiCall(ref gaxgrpc::ApiCall<ListCreativeSetsRequest, ListCreativeSetsResponse> call);

        partial void Modify_CreateCreativeSetApiCall(ref gaxgrpc::ApiCall<CreateCreativeSetRequest, CreativeSet> call);

        partial void Modify_UpdateCreativeSetApiCall(ref gaxgrpc::ApiCall<UpdateCreativeSetRequest, CreativeSet> call);

        partial void OnConstruction(CreativeSetService.CreativeSetServiceClient grpcClient, CreativeSetServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CreativeSetService client</summary>
        public override CreativeSetService.CreativeSetServiceClient GrpcClient { get; }

        partial void Modify_GetCreativeSetRequest(ref GetCreativeSetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCreativeSetsRequest(ref ListCreativeSetsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateCreativeSetRequest(ref CreateCreativeSetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateCreativeSetRequest(ref UpdateCreativeSetRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves a `CreativeSet` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CreativeSet GetCreativeSet(GetCreativeSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCreativeSetRequest(ref request, ref callSettings);
            return _callGetCreativeSet.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a `CreativeSet` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CreativeSet> GetCreativeSetAsync(GetCreativeSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCreativeSetRequest(ref request, ref callSettings);
            return _callGetCreativeSet.Async(request, callSettings);
        }

        /// <summary>
        /// Lists `CreativeSet` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CreativeSet"/> resources.</returns>
        public override gax::PagedEnumerable<ListCreativeSetsResponse, CreativeSet> ListCreativeSets(ListCreativeSetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCreativeSetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCreativeSetsRequest, ListCreativeSetsResponse, CreativeSet>(_callListCreativeSets, request, callSettings);
        }

        /// <summary>
        /// Lists `CreativeSet` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CreativeSet"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCreativeSetsResponse, CreativeSet> ListCreativeSetsAsync(ListCreativeSetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCreativeSetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCreativeSetsRequest, ListCreativeSetsResponse, CreativeSet>(_callListCreativeSets, request, callSettings);
        }

        /// <summary>
        /// Creates a `CreativeSet` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CreativeSet CreateCreativeSet(CreateCreativeSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCreativeSetRequest(ref request, ref callSettings);
            return _callCreateCreativeSet.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a `CreativeSet` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CreativeSet> CreateCreativeSetAsync(CreateCreativeSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCreativeSetRequest(ref request, ref callSettings);
            return _callCreateCreativeSet.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a `CreativeSet` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CreativeSet UpdateCreativeSet(UpdateCreativeSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCreativeSetRequest(ref request, ref callSettings);
            return _callUpdateCreativeSet.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a `CreativeSet` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CreativeSet> UpdateCreativeSetAsync(UpdateCreativeSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCreativeSetRequest(ref request, ref callSettings);
            return _callUpdateCreativeSet.Async(request, callSettings);
        }
    }

    public partial class ListCreativeSetsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCreativeSetsResponse : gaxgrpc::IPageResponse<CreativeSet>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CreativeSet> GetEnumerator() => CreativeSets.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
