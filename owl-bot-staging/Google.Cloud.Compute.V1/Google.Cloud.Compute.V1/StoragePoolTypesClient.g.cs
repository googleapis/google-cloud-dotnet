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
    /// <summary>Settings for <see cref="StoragePoolTypesClient"/> instances.</summary>
    public sealed partial class StoragePoolTypesSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="StoragePoolTypesSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="StoragePoolTypesSettings"/>.</returns>
        public static StoragePoolTypesSettings GetDefault() => new StoragePoolTypesSettings();

        /// <summary>Constructs a new <see cref="StoragePoolTypesSettings"/> object with default settings.</summary>
        public StoragePoolTypesSettings()
        {
        }

        private StoragePoolTypesSettings(StoragePoolTypesSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            AggregatedListSettings = existing.AggregatedListSettings;
            GetSettings = existing.GetSettings;
            ListSettings = existing.ListSettings;
            OnCopy(existing);
        }

        partial void OnCopy(StoragePoolTypesSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StoragePoolTypesClient.AggregatedList</c> and <c>StoragePoolTypesClient.AggregatedListAsync</c>.
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
        public gaxgrpc::CallSettings AggregatedListSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>StoragePoolTypesClient.Get</c>
        ///  and <c>StoragePoolTypesClient.GetAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>StoragePoolTypesClient.List</c>
        ///  and <c>StoragePoolTypesClient.ListAsync</c>.
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
        /// <returns>A deep clone of this <see cref="StoragePoolTypesSettings"/> object.</returns>
        public StoragePoolTypesSettings Clone() => new StoragePoolTypesSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="StoragePoolTypesClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class StoragePoolTypesClientBuilder : gaxgrpc::ClientBuilderBase<StoragePoolTypesClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public StoragePoolTypesSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public StoragePoolTypesClientBuilder() : base(StoragePoolTypesClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref StoragePoolTypesClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<StoragePoolTypesClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override StoragePoolTypesClient Build()
        {
            StoragePoolTypesClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<StoragePoolTypesClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<StoragePoolTypesClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private StoragePoolTypesClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return StoragePoolTypesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<StoragePoolTypesClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return StoragePoolTypesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => StoragePoolTypesClient.ChannelPool;
    }

    /// <summary>StoragePoolTypes client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The StoragePoolTypes API.
    /// </remarks>
    public abstract partial class StoragePoolTypesClient
    {
        /// <summary>
        /// The default endpoint for the StoragePoolTypes service, which is a host of "compute.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default StoragePoolTypes scopes.</summary>
        /// <remarks>
        /// The default StoragePoolTypes scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(StoragePoolTypes.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="StoragePoolTypesClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="StoragePoolTypesClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="StoragePoolTypesClient"/>.</returns>
        public static stt::Task<StoragePoolTypesClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new StoragePoolTypesClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="StoragePoolTypesClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="StoragePoolTypesClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="StoragePoolTypesClient"/>.</returns>
        public static StoragePoolTypesClient Create() => new StoragePoolTypesClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="StoragePoolTypesClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="StoragePoolTypesSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="StoragePoolTypesClient"/>.</returns>
        internal static StoragePoolTypesClient Create(grpccore::CallInvoker callInvoker, StoragePoolTypesSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            StoragePoolTypes.StoragePoolTypesClient grpcClient = new StoragePoolTypes.StoragePoolTypesClient(callInvoker);
            return new StoragePoolTypesClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC StoragePoolTypes client</summary>
        public virtual StoragePoolTypes.StoragePoolTypesClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an aggregated list of storage pool types. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.</returns>
        public virtual gax::PagedEnumerable<StoragePoolTypeAggregatedList, scg::KeyValuePair<string, StoragePoolTypesScopedList>> AggregatedList(AggregatedListStoragePoolTypesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an aggregated list of storage pool types. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<StoragePoolTypeAggregatedList, scg::KeyValuePair<string, StoragePoolTypesScopedList>> AggregatedListAsync(AggregatedListStoragePoolTypesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an aggregated list of storage pool types. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
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
        /// <returns>A pageable sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.</returns>
        public virtual gax::PagedEnumerable<StoragePoolTypeAggregatedList, scg::KeyValuePair<string, StoragePoolTypesScopedList>> AggregatedList(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            AggregatedListStoragePoolTypesRequest request = new AggregatedListStoragePoolTypesRequest
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
            return AggregatedList(request, callSettings);
        }

        /// <summary>
        /// Retrieves an aggregated list of storage pool types. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
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
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<StoragePoolTypeAggregatedList, scg::KeyValuePair<string, StoragePoolTypesScopedList>> AggregatedListAsync(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            AggregatedListStoragePoolTypesRequest request = new AggregatedListStoragePoolTypesRequest
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
            return AggregatedListAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified storage pool type.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StoragePoolType Get(GetStoragePoolTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified storage pool type.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StoragePoolType> GetAsync(GetStoragePoolTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified storage pool type.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StoragePoolType> GetAsync(GetStoragePoolTypeRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified storage pool type.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="storagePoolType">
        /// Name of the storage pool type to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StoragePoolType Get(string project, string zone, string storagePoolType, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetStoragePoolTypeRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                StoragePoolType = gax::GaxPreconditions.CheckNotNullOrEmpty(storagePoolType, nameof(storagePoolType)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Returns the specified storage pool type.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="storagePoolType">
        /// Name of the storage pool type to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StoragePoolType> GetAsync(string project, string zone, string storagePoolType, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetStoragePoolTypeRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                StoragePoolType = gax::GaxPreconditions.CheckNotNullOrEmpty(storagePoolType, nameof(storagePoolType)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Returns the specified storage pool type.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="storagePoolType">
        /// Name of the storage pool type to return.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StoragePoolType> GetAsync(string project, string zone, string storagePoolType, st::CancellationToken cancellationToken) =>
            GetAsync(project, zone, storagePoolType, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a list of storage pool types available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="StoragePoolType"/> resources.</returns>
        public virtual gax::PagedEnumerable<StoragePoolTypeList, StoragePoolType> List(ListStoragePoolTypesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of storage pool types available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="StoragePoolType"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<StoragePoolTypeList, StoragePoolType> ListAsync(ListStoragePoolTypesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of storage pool types available to the specified project.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
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
        /// <returns>A pageable sequence of <see cref="StoragePoolType"/> resources.</returns>
        public virtual gax::PagedEnumerable<StoragePoolTypeList, StoragePoolType> List(string project, string zone, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListStoragePoolTypesRequest request = new ListStoragePoolTypesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
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
        /// Retrieves a list of storage pool types available to the specified project.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
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
        /// <returns>A pageable asynchronous sequence of <see cref="StoragePoolType"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<StoragePoolTypeList, StoragePoolType> ListAsync(string project, string zone, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListStoragePoolTypesRequest request = new ListStoragePoolTypesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
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

    /// <summary>StoragePoolTypes client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The StoragePoolTypes API.
    /// </remarks>
    public sealed partial class StoragePoolTypesClientImpl : StoragePoolTypesClient
    {
        private readonly gaxgrpc::ApiCall<AggregatedListStoragePoolTypesRequest, StoragePoolTypeAggregatedList> _callAggregatedList;

        private readonly gaxgrpc::ApiCall<GetStoragePoolTypeRequest, StoragePoolType> _callGet;

        private readonly gaxgrpc::ApiCall<ListStoragePoolTypesRequest, StoragePoolTypeList> _callList;

        /// <summary>
        /// Constructs a client wrapper for the StoragePoolTypes service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="StoragePoolTypesSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public StoragePoolTypesClientImpl(StoragePoolTypes.StoragePoolTypesClient grpcClient, StoragePoolTypesSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            StoragePoolTypesSettings effectiveSettings = settings ?? StoragePoolTypesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callAggregatedList = clientHelper.BuildApiCall<AggregatedListStoragePoolTypesRequest, StoragePoolTypeAggregatedList>("AggregatedList", grpcClient.AggregatedListAsync, grpcClient.AggregatedList, effectiveSettings.AggregatedListSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callAggregatedList);
            Modify_AggregatedListApiCall(ref _callAggregatedList);
            _callGet = clientHelper.BuildApiCall<GetStoragePoolTypeRequest, StoragePoolType>("Get", grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("storage_pool_type", request => request.StoragePoolType);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callList = clientHelper.BuildApiCall<ListStoragePoolTypesRequest, StoragePoolTypeList>("List", grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_AggregatedListApiCall(ref gaxgrpc::ApiCall<AggregatedListStoragePoolTypesRequest, StoragePoolTypeAggregatedList> call);

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetStoragePoolTypeRequest, StoragePoolType> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListStoragePoolTypesRequest, StoragePoolTypeList> call);

        partial void OnConstruction(StoragePoolTypes.StoragePoolTypesClient grpcClient, StoragePoolTypesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC StoragePoolTypes client</summary>
        public override StoragePoolTypes.StoragePoolTypesClient GrpcClient { get; }

        partial void Modify_AggregatedListStoragePoolTypesRequest(ref AggregatedListStoragePoolTypesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetStoragePoolTypeRequest(ref GetStoragePoolTypeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListStoragePoolTypesRequest(ref ListStoragePoolTypesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves an aggregated list of storage pool types. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.</returns>
        public override gax::PagedEnumerable<StoragePoolTypeAggregatedList, scg::KeyValuePair<string, StoragePoolTypesScopedList>> AggregatedList(AggregatedListStoragePoolTypesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregatedListStoragePoolTypesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<AggregatedListStoragePoolTypesRequest, StoragePoolTypeAggregatedList, scg::KeyValuePair<string, StoragePoolTypesScopedList>>(_callAggregatedList, request, callSettings);
        }

        /// <summary>
        /// Retrieves an aggregated list of storage pool types. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<StoragePoolTypeAggregatedList, scg::KeyValuePair<string, StoragePoolTypesScopedList>> AggregatedListAsync(AggregatedListStoragePoolTypesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregatedListStoragePoolTypesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<AggregatedListStoragePoolTypesRequest, StoragePoolTypeAggregatedList, scg::KeyValuePair<string, StoragePoolTypesScopedList>>(_callAggregatedList, request, callSettings);
        }

        /// <summary>
        /// Returns the specified storage pool type.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override StoragePoolType Get(GetStoragePoolTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetStoragePoolTypeRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified storage pool type.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<StoragePoolType> GetAsync(GetStoragePoolTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetStoragePoolTypeRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of storage pool types available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="StoragePoolType"/> resources.</returns>
        public override gax::PagedEnumerable<StoragePoolTypeList, StoragePoolType> List(ListStoragePoolTypesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListStoragePoolTypesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListStoragePoolTypesRequest, StoragePoolTypeList, StoragePoolType>(_callList, request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of storage pool types available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="StoragePoolType"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<StoragePoolTypeList, StoragePoolType> ListAsync(ListStoragePoolTypesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListStoragePoolTypesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListStoragePoolTypesRequest, StoragePoolTypeList, StoragePoolType>(_callList, request, callSettings);
        }
    }

    public partial class AggregatedListStoragePoolTypesRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class ListStoragePoolTypesRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class StoragePoolTypeAggregatedList : gaxgrpc::IPageResponse<scg::KeyValuePair<string, StoragePoolTypesScopedList>>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<scg::KeyValuePair<string, StoragePoolTypesScopedList>> GetEnumerator() =>
            Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class StoragePoolTypeList : gaxgrpc::IPageResponse<StoragePoolType>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<StoragePoolType> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
