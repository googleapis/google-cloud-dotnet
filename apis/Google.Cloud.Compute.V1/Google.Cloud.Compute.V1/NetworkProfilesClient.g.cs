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

namespace Google.Cloud.Compute.V1
{
    /// <summary>Settings for <see cref="NetworkProfilesClient"/> instances.</summary>
    public sealed partial class NetworkProfilesSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="NetworkProfilesSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="NetworkProfilesSettings"/>.</returns>
        public static NetworkProfilesSettings GetDefault() => new NetworkProfilesSettings();

        /// <summary>Constructs a new <see cref="NetworkProfilesSettings"/> object with default settings.</summary>
        public NetworkProfilesSettings()
        {
        }

        private NetworkProfilesSettings(NetworkProfilesSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetSettings = existing.GetSettings;
            ListSettings = existing.ListSettings;
            OnCopy(existing);
        }

        partial void OnCopy(NetworkProfilesSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>NetworkProfilesClient.Get</c>
        ///  and <c>NetworkProfilesClient.GetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>NetworkProfilesClient.List</c>
        ///  and <c>NetworkProfilesClient.ListAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="NetworkProfilesSettings"/> object.</returns>
        public NetworkProfilesSettings Clone() => new NetworkProfilesSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="NetworkProfilesClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class NetworkProfilesClientBuilder : gaxgrpc::ClientBuilderBase<NetworkProfilesClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public NetworkProfilesSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public NetworkProfilesClientBuilder() : base(NetworkProfilesClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref NetworkProfilesClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<NetworkProfilesClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override NetworkProfilesClient Build()
        {
            NetworkProfilesClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<NetworkProfilesClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<NetworkProfilesClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private NetworkProfilesClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return NetworkProfilesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<NetworkProfilesClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return NetworkProfilesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => NetworkProfilesClient.ChannelPool;
    }

    /// <summary>NetworkProfiles client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The NetworkProfiles API.
    /// </remarks>
    public abstract partial class NetworkProfilesClient
    {
        /// <summary>
        /// The default endpoint for the NetworkProfiles service, which is a host of "compute.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default NetworkProfiles scopes.</summary>
        /// <remarks>
        /// The default NetworkProfiles scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/compute.readonly</description></item>
        /// <item><description>https://www.googleapis.com/auth/compute</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/compute.readonly",
            "https://www.googleapis.com/auth/compute",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(NetworkProfiles.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="NetworkProfilesClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="NetworkProfilesClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="NetworkProfilesClient"/>.</returns>
        public static stt::Task<NetworkProfilesClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new NetworkProfilesClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="NetworkProfilesClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="NetworkProfilesClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="NetworkProfilesClient"/>.</returns>
        public static NetworkProfilesClient Create() => new NetworkProfilesClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="NetworkProfilesClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="NetworkProfilesSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="NetworkProfilesClient"/>.</returns>
        internal static NetworkProfilesClient Create(grpccore::CallInvoker callInvoker, NetworkProfilesSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            NetworkProfiles.NetworkProfilesClient grpcClient = new NetworkProfiles.NetworkProfilesClient(callInvoker);
            return new NetworkProfilesClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC NetworkProfiles client</summary>
        public virtual NetworkProfiles.NetworkProfilesClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified network profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NetworkProfile Get(GetNetworkProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified network profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NetworkProfile> GetAsync(GetNetworkProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified network profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NetworkProfile> GetAsync(GetNetworkProfileRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified network profile.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="networkProfile">
        /// Name of the network profile to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NetworkProfile Get(string project, string networkProfile, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetNetworkProfileRequest
            {
                NetworkProfile = gax::GaxPreconditions.CheckNotNullOrEmpty(networkProfile, nameof(networkProfile)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Returns the specified network profile.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="networkProfile">
        /// Name of the network profile to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NetworkProfile> GetAsync(string project, string networkProfile, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetNetworkProfileRequest
            {
                NetworkProfile = gax::GaxPreconditions.CheckNotNullOrEmpty(networkProfile, nameof(networkProfile)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Returns the specified network profile.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="networkProfile">
        /// Name of the network profile to return.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NetworkProfile> GetAsync(string project, string networkProfile, st::CancellationToken cancellationToken) =>
            GetAsync(project, networkProfile, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a list of network profiles available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="NetworkProfile"/> resources.</returns>
        public virtual gax::PagedEnumerable<NetworkProfilesListResponse, NetworkProfile> List(ListNetworkProfilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of network profiles available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="NetworkProfile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<NetworkProfilesListResponse, NetworkProfile> ListAsync(ListNetworkProfilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of network profiles available to the specified project.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
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
        /// <returns>A pageable sequence of <see cref="NetworkProfile"/> resources.</returns>
        public virtual gax::PagedEnumerable<NetworkProfilesListResponse, NetworkProfile> List(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNetworkProfilesRequest request = new ListNetworkProfilesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return List(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of network profiles available to the specified project.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
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
        /// <returns>A pageable asynchronous sequence of <see cref="NetworkProfile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<NetworkProfilesListResponse, NetworkProfile> ListAsync(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNetworkProfilesRequest request = new ListNetworkProfilesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAsync(request, callSettings);
        }
    }

    /// <summary>NetworkProfiles client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The NetworkProfiles API.
    /// </remarks>
    public sealed partial class NetworkProfilesClientImpl : NetworkProfilesClient
    {
        private readonly gaxgrpc::ApiCall<GetNetworkProfileRequest, NetworkProfile> _callGet;

        private readonly gaxgrpc::ApiCall<ListNetworkProfilesRequest, NetworkProfilesListResponse> _callList;

        /// <summary>
        /// Constructs a client wrapper for the NetworkProfiles service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="NetworkProfilesSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public NetworkProfilesClientImpl(NetworkProfiles.NetworkProfilesClient grpcClient, NetworkProfilesSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            NetworkProfilesSettings effectiveSettings = settings ?? NetworkProfilesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGet = clientHelper.BuildApiCall<GetNetworkProfileRequest, NetworkProfile>("Get", grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("network_profile", request => request.NetworkProfile);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callList = clientHelper.BuildApiCall<ListNetworkProfilesRequest, NetworkProfilesListResponse>("List", grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetNetworkProfileRequest, NetworkProfile> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListNetworkProfilesRequest, NetworkProfilesListResponse> call);

        partial void OnConstruction(NetworkProfiles.NetworkProfilesClient grpcClient, NetworkProfilesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC NetworkProfiles client</summary>
        public override NetworkProfiles.NetworkProfilesClient GrpcClient { get; }

        partial void Modify_GetNetworkProfileRequest(ref GetNetworkProfileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListNetworkProfilesRequest(ref ListNetworkProfilesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the specified network profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override NetworkProfile Get(GetNetworkProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNetworkProfileRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified network profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<NetworkProfile> GetAsync(GetNetworkProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNetworkProfileRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of network profiles available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="NetworkProfile"/> resources.</returns>
        public override gax::PagedEnumerable<NetworkProfilesListResponse, NetworkProfile> List(ListNetworkProfilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNetworkProfilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListNetworkProfilesRequest, NetworkProfilesListResponse, NetworkProfile>(_callList, request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of network profiles available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="NetworkProfile"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<NetworkProfilesListResponse, NetworkProfile> ListAsync(ListNetworkProfilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNetworkProfilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListNetworkProfilesRequest, NetworkProfilesListResponse, NetworkProfile>(_callList, request, callSettings);
        }
    }

    public partial class ListNetworkProfilesRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class NetworkProfilesListResponse : gaxgrpc::IPageResponse<NetworkProfile>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<NetworkProfile> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
