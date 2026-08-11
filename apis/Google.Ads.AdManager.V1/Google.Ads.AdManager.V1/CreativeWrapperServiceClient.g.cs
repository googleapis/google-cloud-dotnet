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
    /// <summary>Settings for <see cref="CreativeWrapperServiceClient"/> instances.</summary>
    public sealed partial class CreativeWrapperServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CreativeWrapperServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CreativeWrapperServiceSettings"/>.</returns>
        public static CreativeWrapperServiceSettings GetDefault() => new CreativeWrapperServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CreativeWrapperServiceSettings"/> object with default settings.
        /// </summary>
        public CreativeWrapperServiceSettings()
        {
        }

        private CreativeWrapperServiceSettings(CreativeWrapperServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCreativeWrapperSettings = existing.GetCreativeWrapperSettings;
            ListCreativeWrappersSettings = existing.ListCreativeWrappersSettings;
            CreateCreativeWrapperSettings = existing.CreateCreativeWrapperSettings;
            BatchCreateCreativeWrappersSettings = existing.BatchCreateCreativeWrappersSettings;
            UpdateCreativeWrapperSettings = existing.UpdateCreativeWrapperSettings;
            BatchUpdateCreativeWrappersSettings = existing.BatchUpdateCreativeWrappersSettings;
            BatchActivateCreativeWrappersSettings = existing.BatchActivateCreativeWrappersSettings;
            BatchDeactivateCreativeWrappersSettings = existing.BatchDeactivateCreativeWrappersSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CreativeWrapperServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CreativeWrapperServiceClient.GetCreativeWrapper</c> and
        /// <c>CreativeWrapperServiceClient.GetCreativeWrapperAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCreativeWrapperSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CreativeWrapperServiceClient.ListCreativeWrappers</c> and
        /// <c>CreativeWrapperServiceClient.ListCreativeWrappersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCreativeWrappersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CreativeWrapperServiceClient.CreateCreativeWrapper</c> and
        /// <c>CreativeWrapperServiceClient.CreateCreativeWrapperAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateCreativeWrapperSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CreativeWrapperServiceClient.BatchCreateCreativeWrappers</c> and
        /// <c>CreativeWrapperServiceClient.BatchCreateCreativeWrappersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchCreateCreativeWrappersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CreativeWrapperServiceClient.UpdateCreativeWrapper</c> and
        /// <c>CreativeWrapperServiceClient.UpdateCreativeWrapperAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateCreativeWrapperSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CreativeWrapperServiceClient.BatchUpdateCreativeWrappers</c> and
        /// <c>CreativeWrapperServiceClient.BatchUpdateCreativeWrappersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchUpdateCreativeWrappersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CreativeWrapperServiceClient.BatchActivateCreativeWrappers</c> and
        /// <c>CreativeWrapperServiceClient.BatchActivateCreativeWrappersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchActivateCreativeWrappersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CreativeWrapperServiceClient.BatchDeactivateCreativeWrappers</c> and
        /// <c>CreativeWrapperServiceClient.BatchDeactivateCreativeWrappersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchDeactivateCreativeWrappersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CreativeWrapperServiceSettings"/> object.</returns>
        public CreativeWrapperServiceSettings Clone() => new CreativeWrapperServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CreativeWrapperServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class CreativeWrapperServiceClientBuilder : gaxgrpc::ClientBuilderBase<CreativeWrapperServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CreativeWrapperServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CreativeWrapperServiceClientBuilder() : base(CreativeWrapperServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CreativeWrapperServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CreativeWrapperServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CreativeWrapperServiceClient Build()
        {
            CreativeWrapperServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CreativeWrapperServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CreativeWrapperServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CreativeWrapperServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CreativeWrapperServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CreativeWrapperServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CreativeWrapperServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CreativeWrapperServiceClient.ChannelPool;
    }

    /// <summary>CreativeWrapperService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `CreativeWrapper` objects.
    /// </remarks>
    public abstract partial class CreativeWrapperServiceClient
    {
        /// <summary>
        /// The default endpoint for the CreativeWrapperService service, which is a host of "admanager.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default CreativeWrapperService scopes.</summary>
        /// <remarks>
        /// The default CreativeWrapperService scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CreativeWrapperService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CreativeWrapperServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="CreativeWrapperServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CreativeWrapperServiceClient"/>.</returns>
        public static stt::Task<CreativeWrapperServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CreativeWrapperServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CreativeWrapperServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="CreativeWrapperServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CreativeWrapperServiceClient"/>.</returns>
        public static CreativeWrapperServiceClient Create() => new CreativeWrapperServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CreativeWrapperServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CreativeWrapperServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CreativeWrapperServiceClient"/>.</returns>
        internal static CreativeWrapperServiceClient Create(grpccore::CallInvoker callInvoker, CreativeWrapperServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CreativeWrapperService.CreativeWrapperServiceClient grpcClient = new CreativeWrapperService.CreativeWrapperServiceClient(callInvoker);
            return new CreativeWrapperServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CreativeWrapperService client</summary>
        public virtual CreativeWrapperService.CreativeWrapperServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `CreativeWrapper` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CreativeWrapper GetCreativeWrapper(GetCreativeWrapperRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `CreativeWrapper` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreativeWrapper> GetCreativeWrapperAsync(GetCreativeWrapperRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `CreativeWrapper` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreativeWrapper> GetCreativeWrapperAsync(GetCreativeWrapperRequest request, st::CancellationToken cancellationToken) =>
            GetCreativeWrapperAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `CreativeWrapper` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CreativeWrapper.
        /// Format: `networks/{network_code}/creativeWrappers/{creative_wrapper_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CreativeWrapper GetCreativeWrapper(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCreativeWrapper(new GetCreativeWrapperRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `CreativeWrapper` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CreativeWrapper.
        /// Format: `networks/{network_code}/creativeWrappers/{creative_wrapper_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreativeWrapper> GetCreativeWrapperAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCreativeWrapperAsync(new GetCreativeWrapperRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `CreativeWrapper` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CreativeWrapper.
        /// Format: `networks/{network_code}/creativeWrappers/{creative_wrapper_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreativeWrapper> GetCreativeWrapperAsync(string name, st::CancellationToken cancellationToken) =>
            GetCreativeWrapperAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `CreativeWrapper` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CreativeWrapper.
        /// Format: `networks/{network_code}/creativeWrappers/{creative_wrapper_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CreativeWrapper GetCreativeWrapper(CreativeWrapperName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCreativeWrapper(new GetCreativeWrapperRequest
            {
                CreativeWrapperName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `CreativeWrapper` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CreativeWrapper.
        /// Format: `networks/{network_code}/creativeWrappers/{creative_wrapper_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreativeWrapper> GetCreativeWrapperAsync(CreativeWrapperName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCreativeWrapperAsync(new GetCreativeWrapperRequest
            {
                CreativeWrapperName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `CreativeWrapper` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CreativeWrapper.
        /// Format: `networks/{network_code}/creativeWrappers/{creative_wrapper_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreativeWrapper> GetCreativeWrapperAsync(CreativeWrapperName name, st::CancellationToken cancellationToken) =>
            GetCreativeWrapperAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists `CreativeWrapper` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CreativeWrapper"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCreativeWrappersResponse, CreativeWrapper> ListCreativeWrappers(ListCreativeWrappersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `CreativeWrapper` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CreativeWrapper"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCreativeWrappersResponse, CreativeWrapper> ListCreativeWrappersAsync(ListCreativeWrappersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `CreativeWrapper` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CreativeWrappers.
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
        /// <returns>A pageable sequence of <see cref="CreativeWrapper"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCreativeWrappersResponse, CreativeWrapper> ListCreativeWrappers(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCreativeWrappersRequest request = new ListCreativeWrappersRequest
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
            return ListCreativeWrappers(request, callSettings);
        }

        /// <summary>
        /// Lists `CreativeWrapper` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CreativeWrappers.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CreativeWrapper"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCreativeWrappersResponse, CreativeWrapper> ListCreativeWrappersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCreativeWrappersRequest request = new ListCreativeWrappersRequest
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
            return ListCreativeWrappersAsync(request, callSettings);
        }

        /// <summary>
        /// Lists `CreativeWrapper` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CreativeWrappers.
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
        /// <returns>A pageable sequence of <see cref="CreativeWrapper"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCreativeWrappersResponse, CreativeWrapper> ListCreativeWrappers(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCreativeWrappersRequest request = new ListCreativeWrappersRequest
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
            return ListCreativeWrappers(request, callSettings);
        }

        /// <summary>
        /// Lists `CreativeWrapper` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CreativeWrappers.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CreativeWrapper"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCreativeWrappersResponse, CreativeWrapper> ListCreativeWrappersAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCreativeWrappersRequest request = new ListCreativeWrappersRequest
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
            return ListCreativeWrappersAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a `CreativeWrapper` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CreativeWrapper CreateCreativeWrapper(CreateCreativeWrapperRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `CreativeWrapper` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreativeWrapper> CreateCreativeWrapperAsync(CreateCreativeWrapperRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `CreativeWrapper` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreativeWrapper> CreateCreativeWrapperAsync(CreateCreativeWrapperRequest request, st::CancellationToken cancellationToken) =>
            CreateCreativeWrapperAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `CreativeWrapper` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `CreativeWrapper` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="creativeWrapper">
        /// Required. The `CreativeWrapper` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CreativeWrapper CreateCreativeWrapper(string parent, CreativeWrapper creativeWrapper, gaxgrpc::CallSettings callSettings = null) =>
            CreateCreativeWrapper(new CreateCreativeWrapperRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CreativeWrapper = gax::GaxPreconditions.CheckNotNull(creativeWrapper, nameof(creativeWrapper)),
            }, callSettings);

        /// <summary>
        /// Creates a `CreativeWrapper` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `CreativeWrapper` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="creativeWrapper">
        /// Required. The `CreativeWrapper` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreativeWrapper> CreateCreativeWrapperAsync(string parent, CreativeWrapper creativeWrapper, gaxgrpc::CallSettings callSettings = null) =>
            CreateCreativeWrapperAsync(new CreateCreativeWrapperRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CreativeWrapper = gax::GaxPreconditions.CheckNotNull(creativeWrapper, nameof(creativeWrapper)),
            }, callSettings);

        /// <summary>
        /// Creates a `CreativeWrapper` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `CreativeWrapper` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="creativeWrapper">
        /// Required. The `CreativeWrapper` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreativeWrapper> CreateCreativeWrapperAsync(string parent, CreativeWrapper creativeWrapper, st::CancellationToken cancellationToken) =>
            CreateCreativeWrapperAsync(parent, creativeWrapper, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `CreativeWrapper` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `CreativeWrapper` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="creativeWrapper">
        /// Required. The `CreativeWrapper` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CreativeWrapper CreateCreativeWrapper(NetworkName parent, CreativeWrapper creativeWrapper, gaxgrpc::CallSettings callSettings = null) =>
            CreateCreativeWrapper(new CreateCreativeWrapperRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CreativeWrapper = gax::GaxPreconditions.CheckNotNull(creativeWrapper, nameof(creativeWrapper)),
            }, callSettings);

        /// <summary>
        /// Creates a `CreativeWrapper` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `CreativeWrapper` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="creativeWrapper">
        /// Required. The `CreativeWrapper` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreativeWrapper> CreateCreativeWrapperAsync(NetworkName parent, CreativeWrapper creativeWrapper, gaxgrpc::CallSettings callSettings = null) =>
            CreateCreativeWrapperAsync(new CreateCreativeWrapperRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CreativeWrapper = gax::GaxPreconditions.CheckNotNull(creativeWrapper, nameof(creativeWrapper)),
            }, callSettings);

        /// <summary>
        /// Creates a `CreativeWrapper` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `CreativeWrapper` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="creativeWrapper">
        /// Required. The `CreativeWrapper` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreativeWrapper> CreateCreativeWrapperAsync(NetworkName parent, CreativeWrapper creativeWrapper, st::CancellationToken cancellationToken) =>
            CreateCreativeWrapperAsync(parent, creativeWrapper, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates `CreativeWrapper` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateCreativeWrappersResponse BatchCreateCreativeWrappers(BatchCreateCreativeWrappersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates `CreativeWrapper` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateCreativeWrappersResponse> BatchCreateCreativeWrappersAsync(BatchCreateCreativeWrappersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates `CreativeWrapper` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateCreativeWrappersResponse> BatchCreateCreativeWrappersAsync(BatchCreateCreativeWrappersRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateCreativeWrappersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates `CreativeWrapper` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `CreativeWrappers` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateCreativeWrapperRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `CreativeWrapper` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateCreativeWrappersResponse BatchCreateCreativeWrappers(string parent, scg::IEnumerable<CreateCreativeWrapperRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateCreativeWrappers(new BatchCreateCreativeWrappersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates `CreativeWrapper` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `CreativeWrappers` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateCreativeWrapperRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `CreativeWrapper` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateCreativeWrappersResponse> BatchCreateCreativeWrappersAsync(string parent, scg::IEnumerable<CreateCreativeWrapperRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateCreativeWrappersAsync(new BatchCreateCreativeWrappersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates `CreativeWrapper` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `CreativeWrappers` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateCreativeWrapperRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `CreativeWrapper` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateCreativeWrappersResponse> BatchCreateCreativeWrappersAsync(string parent, scg::IEnumerable<CreateCreativeWrapperRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateCreativeWrappersAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates `CreativeWrapper` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `CreativeWrappers` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateCreativeWrapperRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `CreativeWrapper` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateCreativeWrappersResponse BatchCreateCreativeWrappers(NetworkName parent, scg::IEnumerable<CreateCreativeWrapperRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateCreativeWrappers(new BatchCreateCreativeWrappersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates `CreativeWrapper` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `CreativeWrappers` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateCreativeWrapperRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `CreativeWrapper` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateCreativeWrappersResponse> BatchCreateCreativeWrappersAsync(NetworkName parent, scg::IEnumerable<CreateCreativeWrapperRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateCreativeWrappersAsync(new BatchCreateCreativeWrappersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates `CreativeWrapper` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `CreativeWrappers` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateCreativeWrapperRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `CreativeWrapper` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateCreativeWrappersResponse> BatchCreateCreativeWrappersAsync(NetworkName parent, scg::IEnumerable<CreateCreativeWrapperRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateCreativeWrappersAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `CreativeWrapper` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CreativeWrapper UpdateCreativeWrapper(UpdateCreativeWrapperRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `CreativeWrapper` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreativeWrapper> UpdateCreativeWrapperAsync(UpdateCreativeWrapperRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `CreativeWrapper` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreativeWrapper> UpdateCreativeWrapperAsync(UpdateCreativeWrapperRequest request, st::CancellationToken cancellationToken) =>
            UpdateCreativeWrapperAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `CreativeWrapper` object.
        /// </summary>
        /// <param name="creativeWrapper">
        /// Required. The `CreativeWrapper` to update.
        /// 
        /// The `CreativeWrapper`'s `name` is used to identify the `CreativeWrapper` to
        /// update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CreativeWrapper UpdateCreativeWrapper(CreativeWrapper creativeWrapper, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCreativeWrapper(new UpdateCreativeWrapperRequest
            {
                CreativeWrapper = gax::GaxPreconditions.CheckNotNull(creativeWrapper, nameof(creativeWrapper)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a `CreativeWrapper` object.
        /// </summary>
        /// <param name="creativeWrapper">
        /// Required. The `CreativeWrapper` to update.
        /// 
        /// The `CreativeWrapper`'s `name` is used to identify the `CreativeWrapper` to
        /// update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreativeWrapper> UpdateCreativeWrapperAsync(CreativeWrapper creativeWrapper, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCreativeWrapperAsync(new UpdateCreativeWrapperRequest
            {
                CreativeWrapper = gax::GaxPreconditions.CheckNotNull(creativeWrapper, nameof(creativeWrapper)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a `CreativeWrapper` object.
        /// </summary>
        /// <param name="creativeWrapper">
        /// Required. The `CreativeWrapper` to update.
        /// 
        /// The `CreativeWrapper`'s `name` is used to identify the `CreativeWrapper` to
        /// update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreativeWrapper> UpdateCreativeWrapperAsync(CreativeWrapper creativeWrapper, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateCreativeWrapperAsync(creativeWrapper, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `CreativeWrapper` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateCreativeWrappersResponse BatchUpdateCreativeWrappers(BatchUpdateCreativeWrappersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch updates `CreativeWrapper` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateCreativeWrappersResponse> BatchUpdateCreativeWrappersAsync(BatchUpdateCreativeWrappersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch updates `CreativeWrapper` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateCreativeWrappersResponse> BatchUpdateCreativeWrappersAsync(BatchUpdateCreativeWrappersRequest request, st::CancellationToken cancellationToken) =>
            BatchUpdateCreativeWrappersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `CreativeWrapper` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `CreativeWrappers` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateCreativeWrapperRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `CreativeWrapper` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateCreativeWrappersResponse BatchUpdateCreativeWrappers(string parent, scg::IEnumerable<UpdateCreativeWrapperRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateCreativeWrappers(new BatchUpdateCreativeWrappersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `CreativeWrapper` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `CreativeWrappers` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateCreativeWrapperRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `CreativeWrapper` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateCreativeWrappersResponse> BatchUpdateCreativeWrappersAsync(string parent, scg::IEnumerable<UpdateCreativeWrapperRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateCreativeWrappersAsync(new BatchUpdateCreativeWrappersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `CreativeWrapper` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `CreativeWrappers` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateCreativeWrapperRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `CreativeWrapper` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateCreativeWrappersResponse> BatchUpdateCreativeWrappersAsync(string parent, scg::IEnumerable<UpdateCreativeWrapperRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateCreativeWrappersAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `CreativeWrapper` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `CreativeWrappers` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateCreativeWrapperRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `CreativeWrapper` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateCreativeWrappersResponse BatchUpdateCreativeWrappers(NetworkName parent, scg::IEnumerable<UpdateCreativeWrapperRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateCreativeWrappers(new BatchUpdateCreativeWrappersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `CreativeWrapper` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `CreativeWrappers` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateCreativeWrapperRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `CreativeWrapper` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateCreativeWrappersResponse> BatchUpdateCreativeWrappersAsync(NetworkName parent, scg::IEnumerable<UpdateCreativeWrapperRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateCreativeWrappersAsync(new BatchUpdateCreativeWrappersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `CreativeWrapper` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `CreativeWrappers` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateCreativeWrapperRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `CreativeWrapper` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateCreativeWrappersResponse> BatchUpdateCreativeWrappersAsync(NetworkName parent, scg::IEnumerable<UpdateCreativeWrapperRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateCreativeWrappersAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch activates `CreativeWrapper` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateCreativeWrappersResponse BatchActivateCreativeWrappers(BatchActivateCreativeWrappersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch activates `CreativeWrapper` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateCreativeWrappersResponse> BatchActivateCreativeWrappersAsync(BatchActivateCreativeWrappersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch activates `CreativeWrapper` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateCreativeWrappersResponse> BatchActivateCreativeWrappersAsync(BatchActivateCreativeWrappersRequest request, st::CancellationToken cancellationToken) =>
            BatchActivateCreativeWrappersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch activates `CreativeWrapper` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `CreativeWrapper` objects to activate.
        /// Format: `networks/{network_code}/creativeWrappers/{creative_wrapper_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateCreativeWrappersResponse BatchActivateCreativeWrappers(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateCreativeWrappers(new BatchActivateCreativeWrappersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch activates `CreativeWrapper` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `CreativeWrapper` objects to activate.
        /// Format: `networks/{network_code}/creativeWrappers/{creative_wrapper_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateCreativeWrappersResponse> BatchActivateCreativeWrappersAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateCreativeWrappersAsync(new BatchActivateCreativeWrappersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch activates `CreativeWrapper` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `CreativeWrapper` objects to activate.
        /// Format: `networks/{network_code}/creativeWrappers/{creative_wrapper_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateCreativeWrappersResponse> BatchActivateCreativeWrappersAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchActivateCreativeWrappersAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch activates `CreativeWrapper` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `CreativeWrapper` objects to activate.
        /// Format: `networks/{network_code}/creativeWrappers/{creative_wrapper_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateCreativeWrappersResponse BatchActivateCreativeWrappers(NetworkName parent, scg::IEnumerable<CreativeWrapperName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateCreativeWrappers(new BatchActivateCreativeWrappersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CreativeWrapperNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch activates `CreativeWrapper` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `CreativeWrapper` objects to activate.
        /// Format: `networks/{network_code}/creativeWrappers/{creative_wrapper_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateCreativeWrappersResponse> BatchActivateCreativeWrappersAsync(NetworkName parent, scg::IEnumerable<CreativeWrapperName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateCreativeWrappersAsync(new BatchActivateCreativeWrappersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CreativeWrapperNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch activates `CreativeWrapper` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `CreativeWrapper` objects to activate.
        /// Format: `networks/{network_code}/creativeWrappers/{creative_wrapper_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateCreativeWrappersResponse> BatchActivateCreativeWrappersAsync(NetworkName parent, scg::IEnumerable<CreativeWrapperName> names, st::CancellationToken cancellationToken) =>
            BatchActivateCreativeWrappersAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deactivates a list of `CreativeWrapper` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateCreativeWrappersResponse BatchDeactivateCreativeWrappers(BatchDeactivateCreativeWrappersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deactivates a list of `CreativeWrapper` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateCreativeWrappersResponse> BatchDeactivateCreativeWrappersAsync(BatchDeactivateCreativeWrappersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deactivates a list of `CreativeWrapper` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateCreativeWrappersResponse> BatchDeactivateCreativeWrappersAsync(BatchDeactivateCreativeWrappersRequest request, st::CancellationToken cancellationToken) =>
            BatchDeactivateCreativeWrappersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deactivates a list of `CreativeWrapper` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `CreativeWrapper` objects to
        /// deactivate. Format:
        /// `networks/{network_code}/creativeWrappers/{creative_wrapper_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateCreativeWrappersResponse BatchDeactivateCreativeWrappers(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateCreativeWrappers(new BatchDeactivateCreativeWrappersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `CreativeWrapper` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `CreativeWrapper` objects to
        /// deactivate. Format:
        /// `networks/{network_code}/creativeWrappers/{creative_wrapper_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateCreativeWrappersResponse> BatchDeactivateCreativeWrappersAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateCreativeWrappersAsync(new BatchDeactivateCreativeWrappersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `CreativeWrapper` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `CreativeWrapper` objects to
        /// deactivate. Format:
        /// `networks/{network_code}/creativeWrappers/{creative_wrapper_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateCreativeWrappersResponse> BatchDeactivateCreativeWrappersAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchDeactivateCreativeWrappersAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deactivates a list of `CreativeWrapper` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `CreativeWrapper` objects to
        /// deactivate. Format:
        /// `networks/{network_code}/creativeWrappers/{creative_wrapper_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateCreativeWrappersResponse BatchDeactivateCreativeWrappers(NetworkName parent, scg::IEnumerable<CreativeWrapperName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateCreativeWrappers(new BatchDeactivateCreativeWrappersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CreativeWrapperNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `CreativeWrapper` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `CreativeWrapper` objects to
        /// deactivate. Format:
        /// `networks/{network_code}/creativeWrappers/{creative_wrapper_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateCreativeWrappersResponse> BatchDeactivateCreativeWrappersAsync(NetworkName parent, scg::IEnumerable<CreativeWrapperName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateCreativeWrappersAsync(new BatchDeactivateCreativeWrappersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CreativeWrapperNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `CreativeWrapper` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `CreativeWrapper` objects to
        /// deactivate. Format:
        /// `networks/{network_code}/creativeWrappers/{creative_wrapper_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateCreativeWrappersResponse> BatchDeactivateCreativeWrappersAsync(NetworkName parent, scg::IEnumerable<CreativeWrapperName> names, st::CancellationToken cancellationToken) =>
            BatchDeactivateCreativeWrappersAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CreativeWrapperService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `CreativeWrapper` objects.
    /// </remarks>
    public sealed partial class CreativeWrapperServiceClientImpl : CreativeWrapperServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCreativeWrapperRequest, CreativeWrapper> _callGetCreativeWrapper;

        private readonly gaxgrpc::ApiCall<ListCreativeWrappersRequest, ListCreativeWrappersResponse> _callListCreativeWrappers;

        private readonly gaxgrpc::ApiCall<CreateCreativeWrapperRequest, CreativeWrapper> _callCreateCreativeWrapper;

        private readonly gaxgrpc::ApiCall<BatchCreateCreativeWrappersRequest, BatchCreateCreativeWrappersResponse> _callBatchCreateCreativeWrappers;

        private readonly gaxgrpc::ApiCall<UpdateCreativeWrapperRequest, CreativeWrapper> _callUpdateCreativeWrapper;

        private readonly gaxgrpc::ApiCall<BatchUpdateCreativeWrappersRequest, BatchUpdateCreativeWrappersResponse> _callBatchUpdateCreativeWrappers;

        private readonly gaxgrpc::ApiCall<BatchActivateCreativeWrappersRequest, BatchActivateCreativeWrappersResponse> _callBatchActivateCreativeWrappers;

        private readonly gaxgrpc::ApiCall<BatchDeactivateCreativeWrappersRequest, BatchDeactivateCreativeWrappersResponse> _callBatchDeactivateCreativeWrappers;

        /// <summary>
        /// Constructs a client wrapper for the CreativeWrapperService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="CreativeWrapperServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CreativeWrapperServiceClientImpl(CreativeWrapperService.CreativeWrapperServiceClient grpcClient, CreativeWrapperServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CreativeWrapperServiceSettings effectiveSettings = settings ?? CreativeWrapperServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetCreativeWrapper = clientHelper.BuildApiCall<GetCreativeWrapperRequest, CreativeWrapper>("GetCreativeWrapper", grpcClient.GetCreativeWrapperAsync, grpcClient.GetCreativeWrapper, effectiveSettings.GetCreativeWrapperSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCreativeWrapper);
            Modify_GetCreativeWrapperApiCall(ref _callGetCreativeWrapper);
            _callListCreativeWrappers = clientHelper.BuildApiCall<ListCreativeWrappersRequest, ListCreativeWrappersResponse>("ListCreativeWrappers", grpcClient.ListCreativeWrappersAsync, grpcClient.ListCreativeWrappers, effectiveSettings.ListCreativeWrappersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCreativeWrappers);
            Modify_ListCreativeWrappersApiCall(ref _callListCreativeWrappers);
            _callCreateCreativeWrapper = clientHelper.BuildApiCall<CreateCreativeWrapperRequest, CreativeWrapper>("CreateCreativeWrapper", grpcClient.CreateCreativeWrapperAsync, grpcClient.CreateCreativeWrapper, effectiveSettings.CreateCreativeWrapperSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCreativeWrapper);
            Modify_CreateCreativeWrapperApiCall(ref _callCreateCreativeWrapper);
            _callBatchCreateCreativeWrappers = clientHelper.BuildApiCall<BatchCreateCreativeWrappersRequest, BatchCreateCreativeWrappersResponse>("BatchCreateCreativeWrappers", grpcClient.BatchCreateCreativeWrappersAsync, grpcClient.BatchCreateCreativeWrappers, effectiveSettings.BatchCreateCreativeWrappersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCreateCreativeWrappers);
            Modify_BatchCreateCreativeWrappersApiCall(ref _callBatchCreateCreativeWrappers);
            _callUpdateCreativeWrapper = clientHelper.BuildApiCall<UpdateCreativeWrapperRequest, CreativeWrapper>("UpdateCreativeWrapper", grpcClient.UpdateCreativeWrapperAsync, grpcClient.UpdateCreativeWrapper, effectiveSettings.UpdateCreativeWrapperSettings).WithGoogleRequestParam("creative_wrapper.name", request => request.CreativeWrapper?.Name);
            Modify_ApiCall(ref _callUpdateCreativeWrapper);
            Modify_UpdateCreativeWrapperApiCall(ref _callUpdateCreativeWrapper);
            _callBatchUpdateCreativeWrappers = clientHelper.BuildApiCall<BatchUpdateCreativeWrappersRequest, BatchUpdateCreativeWrappersResponse>("BatchUpdateCreativeWrappers", grpcClient.BatchUpdateCreativeWrappersAsync, grpcClient.BatchUpdateCreativeWrappers, effectiveSettings.BatchUpdateCreativeWrappersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchUpdateCreativeWrappers);
            Modify_BatchUpdateCreativeWrappersApiCall(ref _callBatchUpdateCreativeWrappers);
            _callBatchActivateCreativeWrappers = clientHelper.BuildApiCall<BatchActivateCreativeWrappersRequest, BatchActivateCreativeWrappersResponse>("BatchActivateCreativeWrappers", grpcClient.BatchActivateCreativeWrappersAsync, grpcClient.BatchActivateCreativeWrappers, effectiveSettings.BatchActivateCreativeWrappersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchActivateCreativeWrappers);
            Modify_BatchActivateCreativeWrappersApiCall(ref _callBatchActivateCreativeWrappers);
            _callBatchDeactivateCreativeWrappers = clientHelper.BuildApiCall<BatchDeactivateCreativeWrappersRequest, BatchDeactivateCreativeWrappersResponse>("BatchDeactivateCreativeWrappers", grpcClient.BatchDeactivateCreativeWrappersAsync, grpcClient.BatchDeactivateCreativeWrappers, effectiveSettings.BatchDeactivateCreativeWrappersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchDeactivateCreativeWrappers);
            Modify_BatchDeactivateCreativeWrappersApiCall(ref _callBatchDeactivateCreativeWrappers);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetCreativeWrapperApiCall(ref gaxgrpc::ApiCall<GetCreativeWrapperRequest, CreativeWrapper> call);

        partial void Modify_ListCreativeWrappersApiCall(ref gaxgrpc::ApiCall<ListCreativeWrappersRequest, ListCreativeWrappersResponse> call);

        partial void Modify_CreateCreativeWrapperApiCall(ref gaxgrpc::ApiCall<CreateCreativeWrapperRequest, CreativeWrapper> call);

        partial void Modify_BatchCreateCreativeWrappersApiCall(ref gaxgrpc::ApiCall<BatchCreateCreativeWrappersRequest, BatchCreateCreativeWrappersResponse> call);

        partial void Modify_UpdateCreativeWrapperApiCall(ref gaxgrpc::ApiCall<UpdateCreativeWrapperRequest, CreativeWrapper> call);

        partial void Modify_BatchUpdateCreativeWrappersApiCall(ref gaxgrpc::ApiCall<BatchUpdateCreativeWrappersRequest, BatchUpdateCreativeWrappersResponse> call);

        partial void Modify_BatchActivateCreativeWrappersApiCall(ref gaxgrpc::ApiCall<BatchActivateCreativeWrappersRequest, BatchActivateCreativeWrappersResponse> call);

        partial void Modify_BatchDeactivateCreativeWrappersApiCall(ref gaxgrpc::ApiCall<BatchDeactivateCreativeWrappersRequest, BatchDeactivateCreativeWrappersResponse> call);

        partial void OnConstruction(CreativeWrapperService.CreativeWrapperServiceClient grpcClient, CreativeWrapperServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CreativeWrapperService client</summary>
        public override CreativeWrapperService.CreativeWrapperServiceClient GrpcClient { get; }

        partial void Modify_GetCreativeWrapperRequest(ref GetCreativeWrapperRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCreativeWrappersRequest(ref ListCreativeWrappersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateCreativeWrapperRequest(ref CreateCreativeWrapperRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateCreativeWrappersRequest(ref BatchCreateCreativeWrappersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateCreativeWrapperRequest(ref UpdateCreativeWrapperRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUpdateCreativeWrappersRequest(ref BatchUpdateCreativeWrappersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchActivateCreativeWrappersRequest(ref BatchActivateCreativeWrappersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchDeactivateCreativeWrappersRequest(ref BatchDeactivateCreativeWrappersRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves a `CreativeWrapper` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CreativeWrapper GetCreativeWrapper(GetCreativeWrapperRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCreativeWrapperRequest(ref request, ref callSettings);
            return _callGetCreativeWrapper.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a `CreativeWrapper` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CreativeWrapper> GetCreativeWrapperAsync(GetCreativeWrapperRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCreativeWrapperRequest(ref request, ref callSettings);
            return _callGetCreativeWrapper.Async(request, callSettings);
        }

        /// <summary>
        /// Lists `CreativeWrapper` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CreativeWrapper"/> resources.</returns>
        public override gax::PagedEnumerable<ListCreativeWrappersResponse, CreativeWrapper> ListCreativeWrappers(ListCreativeWrappersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCreativeWrappersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCreativeWrappersRequest, ListCreativeWrappersResponse, CreativeWrapper>(_callListCreativeWrappers, request, callSettings);
        }

        /// <summary>
        /// Lists `CreativeWrapper` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CreativeWrapper"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCreativeWrappersResponse, CreativeWrapper> ListCreativeWrappersAsync(ListCreativeWrappersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCreativeWrappersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCreativeWrappersRequest, ListCreativeWrappersResponse, CreativeWrapper>(_callListCreativeWrappers, request, callSettings);
        }

        /// <summary>
        /// Creates a `CreativeWrapper` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CreativeWrapper CreateCreativeWrapper(CreateCreativeWrapperRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCreativeWrapperRequest(ref request, ref callSettings);
            return _callCreateCreativeWrapper.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a `CreativeWrapper` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CreativeWrapper> CreateCreativeWrapperAsync(CreateCreativeWrapperRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCreativeWrapperRequest(ref request, ref callSettings);
            return _callCreateCreativeWrapper.Async(request, callSettings);
        }

        /// <summary>
        /// Creates `CreativeWrapper` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchCreateCreativeWrappersResponse BatchCreateCreativeWrappers(BatchCreateCreativeWrappersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateCreativeWrappersRequest(ref request, ref callSettings);
            return _callBatchCreateCreativeWrappers.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates `CreativeWrapper` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchCreateCreativeWrappersResponse> BatchCreateCreativeWrappersAsync(BatchCreateCreativeWrappersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateCreativeWrappersRequest(ref request, ref callSettings);
            return _callBatchCreateCreativeWrappers.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a `CreativeWrapper` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CreativeWrapper UpdateCreativeWrapper(UpdateCreativeWrapperRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCreativeWrapperRequest(ref request, ref callSettings);
            return _callUpdateCreativeWrapper.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a `CreativeWrapper` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CreativeWrapper> UpdateCreativeWrapperAsync(UpdateCreativeWrapperRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCreativeWrapperRequest(ref request, ref callSettings);
            return _callUpdateCreativeWrapper.Async(request, callSettings);
        }

        /// <summary>
        /// Batch updates `CreativeWrapper` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchUpdateCreativeWrappersResponse BatchUpdateCreativeWrappers(BatchUpdateCreativeWrappersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateCreativeWrappersRequest(ref request, ref callSettings);
            return _callBatchUpdateCreativeWrappers.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch updates `CreativeWrapper` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchUpdateCreativeWrappersResponse> BatchUpdateCreativeWrappersAsync(BatchUpdateCreativeWrappersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateCreativeWrappersRequest(ref request, ref callSettings);
            return _callBatchUpdateCreativeWrappers.Async(request, callSettings);
        }

        /// <summary>
        /// Batch activates `CreativeWrapper` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchActivateCreativeWrappersResponse BatchActivateCreativeWrappers(BatchActivateCreativeWrappersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchActivateCreativeWrappersRequest(ref request, ref callSettings);
            return _callBatchActivateCreativeWrappers.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch activates `CreativeWrapper` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchActivateCreativeWrappersResponse> BatchActivateCreativeWrappersAsync(BatchActivateCreativeWrappersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchActivateCreativeWrappersRequest(ref request, ref callSettings);
            return _callBatchActivateCreativeWrappers.Async(request, callSettings);
        }

        /// <summary>
        /// Deactivates a list of `CreativeWrapper` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchDeactivateCreativeWrappersResponse BatchDeactivateCreativeWrappers(BatchDeactivateCreativeWrappersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeactivateCreativeWrappersRequest(ref request, ref callSettings);
            return _callBatchDeactivateCreativeWrappers.Sync(request, callSettings);
        }

        /// <summary>
        /// Deactivates a list of `CreativeWrapper` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchDeactivateCreativeWrappersResponse> BatchDeactivateCreativeWrappersAsync(BatchDeactivateCreativeWrappersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeactivateCreativeWrappersRequest(ref request, ref callSettings);
            return _callBatchDeactivateCreativeWrappers.Async(request, callSettings);
        }
    }

    public partial class ListCreativeWrappersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCreativeWrappersResponse : gaxgrpc::IPageResponse<CreativeWrapper>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CreativeWrapper> GetEnumerator() => CreativeWrappers.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
