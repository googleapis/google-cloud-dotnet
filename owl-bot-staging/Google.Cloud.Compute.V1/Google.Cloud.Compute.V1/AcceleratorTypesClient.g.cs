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
    /// <summary>Settings for <see cref="AcceleratorTypesClient"/> instances.</summary>
    public sealed partial class AcceleratorTypesSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AcceleratorTypesSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AcceleratorTypesSettings"/>.</returns>
        public static AcceleratorTypesSettings GetDefault() => new AcceleratorTypesSettings();

        /// <summary>Constructs a new <see cref="AcceleratorTypesSettings"/> object with default settings.</summary>
        public AcceleratorTypesSettings()
        {
        }

        private AcceleratorTypesSettings(AcceleratorTypesSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            AggregatedListSettings = existing.AggregatedListSettings;
            GetSettings = existing.GetSettings;
            ListSettings = existing.ListSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AcceleratorTypesSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AcceleratorTypesClient.AggregatedList</c> and <c>AcceleratorTypesClient.AggregatedListAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AcceleratorTypesClient.Get</c>
        ///  and <c>AcceleratorTypesClient.GetAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AcceleratorTypesClient.List</c>
        ///  and <c>AcceleratorTypesClient.ListAsync</c>.
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
        /// <returns>A deep clone of this <see cref="AcceleratorTypesSettings"/> object.</returns>
        public AcceleratorTypesSettings Clone() => new AcceleratorTypesSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AcceleratorTypesClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class AcceleratorTypesClientBuilder : gaxgrpc::ClientBuilderBase<AcceleratorTypesClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AcceleratorTypesSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AcceleratorTypesClientBuilder() : base(AcceleratorTypesClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AcceleratorTypesClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AcceleratorTypesClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AcceleratorTypesClient Build()
        {
            AcceleratorTypesClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AcceleratorTypesClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AcceleratorTypesClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AcceleratorTypesClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AcceleratorTypesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AcceleratorTypesClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AcceleratorTypesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AcceleratorTypesClient.ChannelPool;
    }

    /// <summary>AcceleratorTypes client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Services
    /// 
    /// The AcceleratorTypes API.
    /// </remarks>
    public abstract partial class AcceleratorTypesClient
    {
        /// <summary>
        /// The default endpoint for the AcceleratorTypes service, which is a host of "compute.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default AcceleratorTypes scopes.</summary>
        /// <remarks>
        /// The default AcceleratorTypes scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AcceleratorTypes.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AcceleratorTypesClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AcceleratorTypesClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AcceleratorTypesClient"/>.</returns>
        public static stt::Task<AcceleratorTypesClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AcceleratorTypesClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AcceleratorTypesClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AcceleratorTypesClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AcceleratorTypesClient"/>.</returns>
        public static AcceleratorTypesClient Create() => new AcceleratorTypesClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AcceleratorTypesClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AcceleratorTypesSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AcceleratorTypesClient"/>.</returns>
        internal static AcceleratorTypesClient Create(grpccore::CallInvoker callInvoker, AcceleratorTypesSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AcceleratorTypes.AcceleratorTypesClient grpcClient = new AcceleratorTypes.AcceleratorTypesClient(callInvoker);
            return new AcceleratorTypesClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AcceleratorTypes client</summary>
        public virtual AcceleratorTypes.AcceleratorTypesClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an aggregated list of accelerator types. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.</returns>
        public virtual gax::PagedEnumerable<AcceleratorTypeAggregatedList, scg::KeyValuePair<string, AcceleratorTypesScopedList>> AggregatedList(AggregatedListAcceleratorTypesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an aggregated list of accelerator types. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<AcceleratorTypeAggregatedList, scg::KeyValuePair<string, AcceleratorTypesScopedList>> AggregatedListAsync(AggregatedListAcceleratorTypesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an aggregated list of accelerator types. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
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
        public virtual gax::PagedEnumerable<AcceleratorTypeAggregatedList, scg::KeyValuePair<string, AcceleratorTypesScopedList>> AggregatedList(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            AggregatedListAcceleratorTypesRequest request = new AggregatedListAcceleratorTypesRequest
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
        /// Retrieves an aggregated list of accelerator types. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
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
        public virtual gax::PagedAsyncEnumerable<AcceleratorTypeAggregatedList, scg::KeyValuePair<string, AcceleratorTypesScopedList>> AggregatedListAsync(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            AggregatedListAcceleratorTypesRequest request = new AggregatedListAcceleratorTypesRequest
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
        /// Returns the specified accelerator type.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AcceleratorType Get(GetAcceleratorTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified accelerator type.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AcceleratorType> GetAsync(GetAcceleratorTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified accelerator type.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AcceleratorType> GetAsync(GetAcceleratorTypeRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified accelerator type.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="acceleratorType">
        /// Name of the accelerator type to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AcceleratorType Get(string project, string zone, string acceleratorType, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetAcceleratorTypeRequest
            {
                AcceleratorType = gax::GaxPreconditions.CheckNotNullOrEmpty(acceleratorType, nameof(acceleratorType)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Returns the specified accelerator type.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="acceleratorType">
        /// Name of the accelerator type to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AcceleratorType> GetAsync(string project, string zone, string acceleratorType, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetAcceleratorTypeRequest
            {
                AcceleratorType = gax::GaxPreconditions.CheckNotNullOrEmpty(acceleratorType, nameof(acceleratorType)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Returns the specified accelerator type.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="acceleratorType">
        /// Name of the accelerator type to return.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AcceleratorType> GetAsync(string project, string zone, string acceleratorType, st::CancellationToken cancellationToken) =>
            GetAsync(project, zone, acceleratorType, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a list of accelerator types that are available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AcceleratorType"/> resources.</returns>
        public virtual gax::PagedEnumerable<AcceleratorTypeList, AcceleratorType> List(ListAcceleratorTypesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of accelerator types that are available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AcceleratorType"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<AcceleratorTypeList, AcceleratorType> ListAsync(ListAcceleratorTypesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of accelerator types that are available to the specified project.
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
        /// <returns>A pageable sequence of <see cref="AcceleratorType"/> resources.</returns>
        public virtual gax::PagedEnumerable<AcceleratorTypeList, AcceleratorType> List(string project, string zone, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAcceleratorTypesRequest request = new ListAcceleratorTypesRequest
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
        /// Retrieves a list of accelerator types that are available to the specified project.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AcceleratorType"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<AcceleratorTypeList, AcceleratorType> ListAsync(string project, string zone, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAcceleratorTypesRequest request = new ListAcceleratorTypesRequest
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

    /// <summary>AcceleratorTypes client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Services
    /// 
    /// The AcceleratorTypes API.
    /// </remarks>
    public sealed partial class AcceleratorTypesClientImpl : AcceleratorTypesClient
    {
        private readonly gaxgrpc::ApiCall<AggregatedListAcceleratorTypesRequest, AcceleratorTypeAggregatedList> _callAggregatedList;

        private readonly gaxgrpc::ApiCall<GetAcceleratorTypeRequest, AcceleratorType> _callGet;

        private readonly gaxgrpc::ApiCall<ListAcceleratorTypesRequest, AcceleratorTypeList> _callList;

        /// <summary>
        /// Constructs a client wrapper for the AcceleratorTypes service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AcceleratorTypesSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AcceleratorTypesClientImpl(AcceleratorTypes.AcceleratorTypesClient grpcClient, AcceleratorTypesSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AcceleratorTypesSettings effectiveSettings = settings ?? AcceleratorTypesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callAggregatedList = clientHelper.BuildApiCall<AggregatedListAcceleratorTypesRequest, AcceleratorTypeAggregatedList>("AggregatedList", grpcClient.AggregatedListAsync, grpcClient.AggregatedList, effectiveSettings.AggregatedListSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callAggregatedList);
            Modify_AggregatedListApiCall(ref _callAggregatedList);
            _callGet = clientHelper.BuildApiCall<GetAcceleratorTypeRequest, AcceleratorType>("Get", grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("accelerator_type", request => request.AcceleratorType);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callList = clientHelper.BuildApiCall<ListAcceleratorTypesRequest, AcceleratorTypeList>("List", grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_AggregatedListApiCall(ref gaxgrpc::ApiCall<AggregatedListAcceleratorTypesRequest, AcceleratorTypeAggregatedList> call);

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetAcceleratorTypeRequest, AcceleratorType> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListAcceleratorTypesRequest, AcceleratorTypeList> call);

        partial void OnConstruction(AcceleratorTypes.AcceleratorTypesClient grpcClient, AcceleratorTypesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AcceleratorTypes client</summary>
        public override AcceleratorTypes.AcceleratorTypesClient GrpcClient { get; }

        partial void Modify_AggregatedListAcceleratorTypesRequest(ref AggregatedListAcceleratorTypesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAcceleratorTypeRequest(ref GetAcceleratorTypeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAcceleratorTypesRequest(ref ListAcceleratorTypesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves an aggregated list of accelerator types. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.</returns>
        public override gax::PagedEnumerable<AcceleratorTypeAggregatedList, scg::KeyValuePair<string, AcceleratorTypesScopedList>> AggregatedList(AggregatedListAcceleratorTypesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregatedListAcceleratorTypesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<AggregatedListAcceleratorTypesRequest, AcceleratorTypeAggregatedList, scg::KeyValuePair<string, AcceleratorTypesScopedList>>(_callAggregatedList, request, callSettings);
        }

        /// <summary>
        /// Retrieves an aggregated list of accelerator types. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<AcceleratorTypeAggregatedList, scg::KeyValuePair<string, AcceleratorTypesScopedList>> AggregatedListAsync(AggregatedListAcceleratorTypesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregatedListAcceleratorTypesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<AggregatedListAcceleratorTypesRequest, AcceleratorTypeAggregatedList, scg::KeyValuePair<string, AcceleratorTypesScopedList>>(_callAggregatedList, request, callSettings);
        }

        /// <summary>
        /// Returns the specified accelerator type.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AcceleratorType Get(GetAcceleratorTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAcceleratorTypeRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified accelerator type.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AcceleratorType> GetAsync(GetAcceleratorTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAcceleratorTypeRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of accelerator types that are available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AcceleratorType"/> resources.</returns>
        public override gax::PagedEnumerable<AcceleratorTypeList, AcceleratorType> List(ListAcceleratorTypesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAcceleratorTypesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAcceleratorTypesRequest, AcceleratorTypeList, AcceleratorType>(_callList, request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of accelerator types that are available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AcceleratorType"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<AcceleratorTypeList, AcceleratorType> ListAsync(ListAcceleratorTypesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAcceleratorTypesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAcceleratorTypesRequest, AcceleratorTypeList, AcceleratorType>(_callList, request, callSettings);
        }
    }

    public partial class AggregatedListAcceleratorTypesRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class ListAcceleratorTypesRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class AcceleratorTypeAggregatedList : gaxgrpc::IPageResponse<scg::KeyValuePair<string, AcceleratorTypesScopedList>>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<scg::KeyValuePair<string, AcceleratorTypesScopedList>> GetEnumerator() =>
            Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class AcceleratorTypeList : gaxgrpc::IPageResponse<AcceleratorType>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AcceleratorType> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
