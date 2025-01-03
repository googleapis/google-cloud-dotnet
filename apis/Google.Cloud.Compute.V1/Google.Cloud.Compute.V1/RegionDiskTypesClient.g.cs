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

namespace Google.Cloud.Compute.V1
{
    /// <summary>Settings for <see cref="RegionDiskTypesClient"/> instances.</summary>
    public sealed partial class RegionDiskTypesSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="RegionDiskTypesSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="RegionDiskTypesSettings"/>.</returns>
        public static RegionDiskTypesSettings GetDefault() => new RegionDiskTypesSettings();

        /// <summary>Constructs a new <see cref="RegionDiskTypesSettings"/> object with default settings.</summary>
        public RegionDiskTypesSettings()
        {
        }

        private RegionDiskTypesSettings(RegionDiskTypesSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetSettings = existing.GetSettings;
            ListSettings = existing.ListSettings;
            OnCopy(existing);
        }

        partial void OnCopy(RegionDiskTypesSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>RegionDiskTypesClient.Get</c>
        ///  and <c>RegionDiskTypesClient.GetAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>RegionDiskTypesClient.List</c>
        ///  and <c>RegionDiskTypesClient.ListAsync</c>.
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
        /// <returns>A deep clone of this <see cref="RegionDiskTypesSettings"/> object.</returns>
        public RegionDiskTypesSettings Clone() => new RegionDiskTypesSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="RegionDiskTypesClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class RegionDiskTypesClientBuilder : gaxgrpc::ClientBuilderBase<RegionDiskTypesClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public RegionDiskTypesSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public RegionDiskTypesClientBuilder() : base(RegionDiskTypesClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref RegionDiskTypesClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<RegionDiskTypesClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override RegionDiskTypesClient Build()
        {
            RegionDiskTypesClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<RegionDiskTypesClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<RegionDiskTypesClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private RegionDiskTypesClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return RegionDiskTypesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<RegionDiskTypesClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return RegionDiskTypesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => RegionDiskTypesClient.ChannelPool;
    }

    /// <summary>RegionDiskTypes client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The RegionDiskTypes API.
    /// </remarks>
    public abstract partial class RegionDiskTypesClient
    {
        /// <summary>
        /// The default endpoint for the RegionDiskTypes service, which is a host of "compute.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default RegionDiskTypes scopes.</summary>
        /// <remarks>
        /// The default RegionDiskTypes scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(RegionDiskTypes.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="RegionDiskTypesClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="RegionDiskTypesClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="RegionDiskTypesClient"/>.</returns>
        public static stt::Task<RegionDiskTypesClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new RegionDiskTypesClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="RegionDiskTypesClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="RegionDiskTypesClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="RegionDiskTypesClient"/>.</returns>
        public static RegionDiskTypesClient Create() => new RegionDiskTypesClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="RegionDiskTypesClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="RegionDiskTypesSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="RegionDiskTypesClient"/>.</returns>
        internal static RegionDiskTypesClient Create(grpccore::CallInvoker callInvoker, RegionDiskTypesSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            RegionDiskTypes.RegionDiskTypesClient grpcClient = new RegionDiskTypes.RegionDiskTypesClient(callInvoker);
            return new RegionDiskTypesClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC RegionDiskTypes client</summary>
        public virtual RegionDiskTypes.RegionDiskTypesClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified regional disk type.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DiskType Get(GetRegionDiskTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified regional disk type.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiskType> GetAsync(GetRegionDiskTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified regional disk type.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiskType> GetAsync(GetRegionDiskTypeRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified regional disk type.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="diskType">
        /// Name of the disk type to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DiskType Get(string project, string region, string diskType, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetRegionDiskTypeRequest
            {
                DiskType = gax::GaxPreconditions.CheckNotNullOrEmpty(diskType, nameof(diskType)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Returns the specified regional disk type.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="diskType">
        /// Name of the disk type to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiskType> GetAsync(string project, string region, string diskType, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetRegionDiskTypeRequest
            {
                DiskType = gax::GaxPreconditions.CheckNotNullOrEmpty(diskType, nameof(diskType)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Returns the specified regional disk type.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="diskType">
        /// Name of the disk type to return.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiskType> GetAsync(string project, string region, string diskType, st::CancellationToken cancellationToken) =>
            GetAsync(project, region, diskType, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a list of regional disk types available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DiskType"/> resources.</returns>
        public virtual gax::PagedEnumerable<RegionDiskTypeList, DiskType> List(ListRegionDiskTypesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of regional disk types available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DiskType"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<RegionDiskTypeList, DiskType> ListAsync(ListRegionDiskTypesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of regional disk types available to the specified project.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
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
        /// <returns>A pageable sequence of <see cref="DiskType"/> resources.</returns>
        public virtual gax::PagedEnumerable<RegionDiskTypeList, DiskType> List(string project, string region, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRegionDiskTypesRequest request = new ListRegionDiskTypesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
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
        /// Retrieves a list of regional disk types available to the specified project.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DiskType"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<RegionDiskTypeList, DiskType> ListAsync(string project, string region, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRegionDiskTypesRequest request = new ListRegionDiskTypesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
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

    /// <summary>RegionDiskTypes client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The RegionDiskTypes API.
    /// </remarks>
    public sealed partial class RegionDiskTypesClientImpl : RegionDiskTypesClient
    {
        private readonly gaxgrpc::ApiCall<GetRegionDiskTypeRequest, DiskType> _callGet;

        private readonly gaxgrpc::ApiCall<ListRegionDiskTypesRequest, RegionDiskTypeList> _callList;

        /// <summary>
        /// Constructs a client wrapper for the RegionDiskTypes service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="RegionDiskTypesSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public RegionDiskTypesClientImpl(RegionDiskTypes.RegionDiskTypesClient grpcClient, RegionDiskTypesSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            RegionDiskTypesSettings effectiveSettings = settings ?? RegionDiskTypesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGet = clientHelper.BuildApiCall<GetRegionDiskTypeRequest, DiskType>("Get", grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("disk_type", request => request.DiskType);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callList = clientHelper.BuildApiCall<ListRegionDiskTypesRequest, RegionDiskTypeList>("List", grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetRegionDiskTypeRequest, DiskType> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListRegionDiskTypesRequest, RegionDiskTypeList> call);

        partial void OnConstruction(RegionDiskTypes.RegionDiskTypesClient grpcClient, RegionDiskTypesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC RegionDiskTypes client</summary>
        public override RegionDiskTypes.RegionDiskTypesClient GrpcClient { get; }

        partial void Modify_GetRegionDiskTypeRequest(ref GetRegionDiskTypeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRegionDiskTypesRequest(ref ListRegionDiskTypesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the specified regional disk type.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DiskType Get(GetRegionDiskTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRegionDiskTypeRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified regional disk type.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DiskType> GetAsync(GetRegionDiskTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRegionDiskTypeRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of regional disk types available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DiskType"/> resources.</returns>
        public override gax::PagedEnumerable<RegionDiskTypeList, DiskType> List(ListRegionDiskTypesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRegionDiskTypesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRegionDiskTypesRequest, RegionDiskTypeList, DiskType>(_callList, request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of regional disk types available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DiskType"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<RegionDiskTypeList, DiskType> ListAsync(ListRegionDiskTypesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRegionDiskTypesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRegionDiskTypesRequest, RegionDiskTypeList, DiskType>(_callList, request, callSettings);
        }
    }

    public partial class ListRegionDiskTypesRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class RegionDiskTypeList : gaxgrpc::IPageResponse<DiskType>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DiskType> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
