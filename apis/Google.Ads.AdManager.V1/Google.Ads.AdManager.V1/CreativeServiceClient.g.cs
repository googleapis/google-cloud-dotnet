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

namespace Google.Ads.AdManager.V1
{
    /// <summary>Settings for <see cref="CreativeServiceClient"/> instances.</summary>
    public sealed partial class CreativeServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CreativeServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CreativeServiceSettings"/>.</returns>
        public static CreativeServiceSettings GetDefault() => new CreativeServiceSettings();

        /// <summary>Constructs a new <see cref="CreativeServiceSettings"/> object with default settings.</summary>
        public CreativeServiceSettings()
        {
        }

        private CreativeServiceSettings(CreativeServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCreativeSettings = existing.GetCreativeSettings;
            ListCreativesSettings = existing.ListCreativesSettings;
            BatchActivateCreativesSettings = existing.BatchActivateCreativesSettings;
            BatchDeactivateCreativesSettings = existing.BatchDeactivateCreativesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CreativeServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CreativeServiceClient.GetCreative</c> and <c>CreativeServiceClient.GetCreativeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCreativeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CreativeServiceClient.ListCreatives</c> and <c>CreativeServiceClient.ListCreativesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCreativesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CreativeServiceClient.BatchActivateCreatives</c> and <c>CreativeServiceClient.BatchActivateCreativesAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchActivateCreativesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CreativeServiceClient.BatchDeactivateCreatives</c> and
        /// <c>CreativeServiceClient.BatchDeactivateCreativesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchDeactivateCreativesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CreativeServiceSettings"/> object.</returns>
        public CreativeServiceSettings Clone() => new CreativeServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CreativeServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class CreativeServiceClientBuilder : gaxgrpc::ClientBuilderBase<CreativeServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CreativeServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CreativeServiceClientBuilder() : base(CreativeServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CreativeServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CreativeServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CreativeServiceClient Build()
        {
            CreativeServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CreativeServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CreativeServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CreativeServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CreativeServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CreativeServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CreativeServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CreativeServiceClient.ChannelPool;
    }

    /// <summary>CreativeService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `Creative` objects.
    /// </remarks>
    public abstract partial class CreativeServiceClient
    {
        /// <summary>
        /// The default endpoint for the CreativeService service, which is a host of "admanager.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default CreativeService scopes.</summary>
        /// <remarks>
        /// The default CreativeService scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CreativeService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CreativeServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CreativeServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CreativeServiceClient"/>.</returns>
        public static stt::Task<CreativeServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CreativeServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CreativeServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CreativeServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CreativeServiceClient"/>.</returns>
        public static CreativeServiceClient Create() => new CreativeServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CreativeServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CreativeServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CreativeServiceClient"/>.</returns>
        internal static CreativeServiceClient Create(grpccore::CallInvoker callInvoker, CreativeServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CreativeService.CreativeServiceClient grpcClient = new CreativeService.CreativeServiceClient(callInvoker);
            return new CreativeServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CreativeService client</summary>
        public virtual CreativeService.CreativeServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `Creative` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Creative GetCreative(GetCreativeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `Creative` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Creative> GetCreativeAsync(GetCreativeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `Creative` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Creative> GetCreativeAsync(GetCreativeRequest request, st::CancellationToken cancellationToken) =>
            GetCreativeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `Creative` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Creative.
        /// Format: `networks/{network_code}/creatives/{creative_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Creative GetCreative(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCreative(new GetCreativeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `Creative` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Creative.
        /// Format: `networks/{network_code}/creatives/{creative_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Creative> GetCreativeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCreativeAsync(new GetCreativeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `Creative` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Creative.
        /// Format: `networks/{network_code}/creatives/{creative_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Creative> GetCreativeAsync(string name, st::CancellationToken cancellationToken) =>
            GetCreativeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `Creative` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Creative.
        /// Format: `networks/{network_code}/creatives/{creative_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Creative GetCreative(CreativeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCreative(new GetCreativeRequest
            {
                CreativeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `Creative` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Creative.
        /// Format: `networks/{network_code}/creatives/{creative_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Creative> GetCreativeAsync(CreativeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCreativeAsync(new GetCreativeRequest
            {
                CreativeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `Creative` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Creative.
        /// Format: `networks/{network_code}/creatives/{creative_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Creative> GetCreativeAsync(CreativeName name, st::CancellationToken cancellationToken) =>
            GetCreativeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists `Creative` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Creative"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCreativesResponse, Creative> ListCreatives(ListCreativesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `Creative` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Creative"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCreativesResponse, Creative> ListCreativesAsync(ListCreativesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `Creative` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Creatives.
        /// Format: networks/{network_code}
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
        /// <returns>A pageable sequence of <see cref="Creative"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCreativesResponse, Creative> ListCreatives(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCreativesRequest request = new ListCreativesRequest
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
            return ListCreatives(request, callSettings);
        }

        /// <summary>
        /// Lists `Creative` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Creatives.
        /// Format: networks/{network_code}
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
        /// <returns>A pageable asynchronous sequence of <see cref="Creative"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCreativesResponse, Creative> ListCreativesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCreativesRequest request = new ListCreativesRequest
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
            return ListCreativesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists `Creative` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Creatives.
        /// Format: networks/{network_code}
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
        /// <returns>A pageable sequence of <see cref="Creative"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCreativesResponse, Creative> ListCreatives(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCreativesRequest request = new ListCreativesRequest
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
            return ListCreatives(request, callSettings);
        }

        /// <summary>
        /// Lists `Creative` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Creatives.
        /// Format: networks/{network_code}
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
        /// <returns>A pageable asynchronous sequence of <see cref="Creative"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCreativesResponse, Creative> ListCreativesAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCreativesRequest request = new ListCreativesRequest
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
            return ListCreativesAsync(request, callSettings);
        }

        /// <summary>
        /// Batch activates `Creative` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateCreativesResponse BatchActivateCreatives(BatchActivateCreativesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch activates `Creative` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateCreativesResponse> BatchActivateCreativesAsync(BatchActivateCreativesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch activates `Creative` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateCreativesResponse> BatchActivateCreativesAsync(BatchActivateCreativesRequest request, st::CancellationToken cancellationToken) =>
            BatchActivateCreativesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch activates `Creative` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `Creative`s to activate.
        /// Format: `networks/{network_code}/creatives/{creative_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateCreativesResponse BatchActivateCreatives(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateCreatives(new BatchActivateCreativesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch activates `Creative` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `Creative`s to activate.
        /// Format: `networks/{network_code}/creatives/{creative_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateCreativesResponse> BatchActivateCreativesAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateCreativesAsync(new BatchActivateCreativesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch activates `Creative` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `Creative`s to activate.
        /// Format: `networks/{network_code}/creatives/{creative_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateCreativesResponse> BatchActivateCreativesAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchActivateCreativesAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch activates `Creative` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `Creative`s to activate.
        /// Format: `networks/{network_code}/creatives/{creative_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateCreativesResponse BatchActivateCreatives(NetworkName parent, scg::IEnumerable<CreativeName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateCreatives(new BatchActivateCreativesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CreativeNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch activates `Creative` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `Creative`s to activate.
        /// Format: `networks/{network_code}/creatives/{creative_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateCreativesResponse> BatchActivateCreativesAsync(NetworkName parent, scg::IEnumerable<CreativeName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateCreativesAsync(new BatchActivateCreativesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CreativeNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch activates `Creative` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `Creative`s to activate.
        /// Format: `networks/{network_code}/creatives/{creative_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateCreativesResponse> BatchActivateCreativesAsync(NetworkName parent, scg::IEnumerable<CreativeName> names, st::CancellationToken cancellationToken) =>
            BatchActivateCreativesAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deactivates a list of `Creative` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateCreativesResponse BatchDeactivateCreatives(BatchDeactivateCreativesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deactivates a list of `Creative` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateCreativesResponse> BatchDeactivateCreativesAsync(BatchDeactivateCreativesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deactivates a list of `Creative` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateCreativesResponse> BatchDeactivateCreativesAsync(BatchDeactivateCreativesRequest request, st::CancellationToken cancellationToken) =>
            BatchDeactivateCreativesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deactivates a list of `Creative` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `Creative`s to deactivate.
        /// Format: `networks/{network_code}/creatives/{creative_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateCreativesResponse BatchDeactivateCreatives(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateCreatives(new BatchDeactivateCreativesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `Creative` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `Creative`s to deactivate.
        /// Format: `networks/{network_code}/creatives/{creative_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateCreativesResponse> BatchDeactivateCreativesAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateCreativesAsync(new BatchDeactivateCreativesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `Creative` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `Creative`s to deactivate.
        /// Format: `networks/{network_code}/creatives/{creative_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateCreativesResponse> BatchDeactivateCreativesAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchDeactivateCreativesAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deactivates a list of `Creative` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `Creative`s to deactivate.
        /// Format: `networks/{network_code}/creatives/{creative_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateCreativesResponse BatchDeactivateCreatives(NetworkName parent, scg::IEnumerable<CreativeName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateCreatives(new BatchDeactivateCreativesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CreativeNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `Creative` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `Creative`s to deactivate.
        /// Format: `networks/{network_code}/creatives/{creative_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateCreativesResponse> BatchDeactivateCreativesAsync(NetworkName parent, scg::IEnumerable<CreativeName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateCreativesAsync(new BatchDeactivateCreativesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CreativeNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `Creative` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `Creative`s to deactivate.
        /// Format: `networks/{network_code}/creatives/{creative_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateCreativesResponse> BatchDeactivateCreativesAsync(NetworkName parent, scg::IEnumerable<CreativeName> names, st::CancellationToken cancellationToken) =>
            BatchDeactivateCreativesAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CreativeService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `Creative` objects.
    /// </remarks>
    public sealed partial class CreativeServiceClientImpl : CreativeServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCreativeRequest, Creative> _callGetCreative;

        private readonly gaxgrpc::ApiCall<ListCreativesRequest, ListCreativesResponse> _callListCreatives;

        private readonly gaxgrpc::ApiCall<BatchActivateCreativesRequest, BatchActivateCreativesResponse> _callBatchActivateCreatives;

        private readonly gaxgrpc::ApiCall<BatchDeactivateCreativesRequest, BatchDeactivateCreativesResponse> _callBatchDeactivateCreatives;

        /// <summary>
        /// Constructs a client wrapper for the CreativeService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CreativeServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CreativeServiceClientImpl(CreativeService.CreativeServiceClient grpcClient, CreativeServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CreativeServiceSettings effectiveSettings = settings ?? CreativeServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetCreative = clientHelper.BuildApiCall<GetCreativeRequest, Creative>("GetCreative", grpcClient.GetCreativeAsync, grpcClient.GetCreative, effectiveSettings.GetCreativeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCreative);
            Modify_GetCreativeApiCall(ref _callGetCreative);
            _callListCreatives = clientHelper.BuildApiCall<ListCreativesRequest, ListCreativesResponse>("ListCreatives", grpcClient.ListCreativesAsync, grpcClient.ListCreatives, effectiveSettings.ListCreativesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCreatives);
            Modify_ListCreativesApiCall(ref _callListCreatives);
            _callBatchActivateCreatives = clientHelper.BuildApiCall<BatchActivateCreativesRequest, BatchActivateCreativesResponse>("BatchActivateCreatives", grpcClient.BatchActivateCreativesAsync, grpcClient.BatchActivateCreatives, effectiveSettings.BatchActivateCreativesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchActivateCreatives);
            Modify_BatchActivateCreativesApiCall(ref _callBatchActivateCreatives);
            _callBatchDeactivateCreatives = clientHelper.BuildApiCall<BatchDeactivateCreativesRequest, BatchDeactivateCreativesResponse>("BatchDeactivateCreatives", grpcClient.BatchDeactivateCreativesAsync, grpcClient.BatchDeactivateCreatives, effectiveSettings.BatchDeactivateCreativesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchDeactivateCreatives);
            Modify_BatchDeactivateCreativesApiCall(ref _callBatchDeactivateCreatives);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetCreativeApiCall(ref gaxgrpc::ApiCall<GetCreativeRequest, Creative> call);

        partial void Modify_ListCreativesApiCall(ref gaxgrpc::ApiCall<ListCreativesRequest, ListCreativesResponse> call);

        partial void Modify_BatchActivateCreativesApiCall(ref gaxgrpc::ApiCall<BatchActivateCreativesRequest, BatchActivateCreativesResponse> call);

        partial void Modify_BatchDeactivateCreativesApiCall(ref gaxgrpc::ApiCall<BatchDeactivateCreativesRequest, BatchDeactivateCreativesResponse> call);

        partial void OnConstruction(CreativeService.CreativeServiceClient grpcClient, CreativeServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CreativeService client</summary>
        public override CreativeService.CreativeServiceClient GrpcClient { get; }

        partial void Modify_GetCreativeRequest(ref GetCreativeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCreativesRequest(ref ListCreativesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchActivateCreativesRequest(ref BatchActivateCreativesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchDeactivateCreativesRequest(ref BatchDeactivateCreativesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves a `Creative` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Creative GetCreative(GetCreativeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCreativeRequest(ref request, ref callSettings);
            return _callGetCreative.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a `Creative` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Creative> GetCreativeAsync(GetCreativeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCreativeRequest(ref request, ref callSettings);
            return _callGetCreative.Async(request, callSettings);
        }

        /// <summary>
        /// Lists `Creative` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Creative"/> resources.</returns>
        public override gax::PagedEnumerable<ListCreativesResponse, Creative> ListCreatives(ListCreativesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCreativesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCreativesRequest, ListCreativesResponse, Creative>(_callListCreatives, request, callSettings);
        }

        /// <summary>
        /// Lists `Creative` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Creative"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCreativesResponse, Creative> ListCreativesAsync(ListCreativesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCreativesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCreativesRequest, ListCreativesResponse, Creative>(_callListCreatives, request, callSettings);
        }

        /// <summary>
        /// Batch activates `Creative` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchActivateCreativesResponse BatchActivateCreatives(BatchActivateCreativesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchActivateCreativesRequest(ref request, ref callSettings);
            return _callBatchActivateCreatives.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch activates `Creative` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchActivateCreativesResponse> BatchActivateCreativesAsync(BatchActivateCreativesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchActivateCreativesRequest(ref request, ref callSettings);
            return _callBatchActivateCreatives.Async(request, callSettings);
        }

        /// <summary>
        /// Deactivates a list of `Creative` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchDeactivateCreativesResponse BatchDeactivateCreatives(BatchDeactivateCreativesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeactivateCreativesRequest(ref request, ref callSettings);
            return _callBatchDeactivateCreatives.Sync(request, callSettings);
        }

        /// <summary>
        /// Deactivates a list of `Creative` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchDeactivateCreativesResponse> BatchDeactivateCreativesAsync(BatchDeactivateCreativesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeactivateCreativesRequest(ref request, ref callSettings);
            return _callBatchDeactivateCreatives.Async(request, callSettings);
        }
    }

    public partial class ListCreativesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCreativesResponse : gaxgrpc::IPageResponse<Creative>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Creative> GetEnumerator() => Creatives.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
