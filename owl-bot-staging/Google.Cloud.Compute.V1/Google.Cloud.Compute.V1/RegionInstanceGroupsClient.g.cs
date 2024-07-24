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
using lro = Google.LongRunning;
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
    /// <summary>Settings for <see cref="RegionInstanceGroupsClient"/> instances.</summary>
    public sealed partial class RegionInstanceGroupsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="RegionInstanceGroupsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="RegionInstanceGroupsSettings"/>.</returns>
        public static RegionInstanceGroupsSettings GetDefault() => new RegionInstanceGroupsSettings();

        /// <summary>Constructs a new <see cref="RegionInstanceGroupsSettings"/> object with default settings.</summary>
        public RegionInstanceGroupsSettings()
        {
        }

        private RegionInstanceGroupsSettings(RegionInstanceGroupsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetSettings = existing.GetSettings;
            ListSettings = existing.ListSettings;
            ListInstancesSettings = existing.ListInstancesSettings;
            SetNamedPortsSettings = existing.SetNamedPortsSettings;
            SetNamedPortsOperationsSettings = existing.SetNamedPortsOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(RegionInstanceGroupsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionInstanceGroupsClient.Get</c> and <c>RegionInstanceGroupsClient.GetAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionInstanceGroupsClient.List</c> and <c>RegionInstanceGroupsClient.ListAsync</c>.
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

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionInstanceGroupsClient.ListInstances</c> and <c>RegionInstanceGroupsClient.ListInstancesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListInstancesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionInstanceGroupsClient.SetNamedPorts</c> and <c>RegionInstanceGroupsClient.SetNamedPortsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetNamedPortsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>RegionInstanceGroupsClient.SetNamedPorts</c> and
        /// <c>RegionInstanceGroupsClient.SetNamedPortsAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings SetNamedPortsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="RegionInstanceGroupsSettings"/> object.</returns>
        public RegionInstanceGroupsSettings Clone() => new RegionInstanceGroupsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="RegionInstanceGroupsClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class RegionInstanceGroupsClientBuilder : gaxgrpc::ClientBuilderBase<RegionInstanceGroupsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public RegionInstanceGroupsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public RegionInstanceGroupsClientBuilder() : base(RegionInstanceGroupsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref RegionInstanceGroupsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<RegionInstanceGroupsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override RegionInstanceGroupsClient Build()
        {
            RegionInstanceGroupsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<RegionInstanceGroupsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<RegionInstanceGroupsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private RegionInstanceGroupsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return RegionInstanceGroupsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<RegionInstanceGroupsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return RegionInstanceGroupsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => RegionInstanceGroupsClient.ChannelPool;
    }

    /// <summary>RegionInstanceGroups client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The RegionInstanceGroups API.
    /// </remarks>
    public abstract partial class RegionInstanceGroupsClient
    {
        /// <summary>
        /// The default endpoint for the RegionInstanceGroups service, which is a host of "compute.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default RegionInstanceGroups scopes.</summary>
        /// <remarks>
        /// The default RegionInstanceGroups scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/compute</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/compute",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(RegionInstanceGroups.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="RegionInstanceGroupsClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="RegionInstanceGroupsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="RegionInstanceGroupsClient"/>.</returns>
        public static stt::Task<RegionInstanceGroupsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new RegionInstanceGroupsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="RegionInstanceGroupsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="RegionInstanceGroupsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="RegionInstanceGroupsClient"/>.</returns>
        public static RegionInstanceGroupsClient Create() => new RegionInstanceGroupsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="RegionInstanceGroupsClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="RegionInstanceGroupsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="RegionInstanceGroupsClient"/>.</returns>
        internal static RegionInstanceGroupsClient Create(grpccore::CallInvoker callInvoker, RegionInstanceGroupsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            RegionInstanceGroups.RegionInstanceGroupsClient grpcClient = new RegionInstanceGroups.RegionInstanceGroupsClient(callInvoker);
            return new RegionInstanceGroupsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC RegionInstanceGroups client</summary>
        public virtual RegionInstanceGroups.RegionInstanceGroupsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified instance group resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InstanceGroup Get(GetRegionInstanceGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified instance group resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceGroup> GetAsync(GetRegionInstanceGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified instance group resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceGroup> GetAsync(GetRegionInstanceGroupRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified instance group resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="instanceGroup">
        /// Name of the instance group resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InstanceGroup Get(string project, string region, string instanceGroup, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetRegionInstanceGroupRequest
            {
                InstanceGroup = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceGroup, nameof(instanceGroup)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Returns the specified instance group resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="instanceGroup">
        /// Name of the instance group resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceGroup> GetAsync(string project, string region, string instanceGroup, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetRegionInstanceGroupRequest
            {
                InstanceGroup = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceGroup, nameof(instanceGroup)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Returns the specified instance group resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="instanceGroup">
        /// Name of the instance group resource to return.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceGroup> GetAsync(string project, string region, string instanceGroup, st::CancellationToken cancellationToken) =>
            GetAsync(project, region, instanceGroup, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the list of instance group resources contained within the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="InstanceGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<RegionInstanceGroupList, InstanceGroup> List(ListRegionInstanceGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of instance group resources contained within the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="InstanceGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<RegionInstanceGroupList, InstanceGroup> ListAsync(ListRegionInstanceGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of instance group resources contained within the specified region.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
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
        /// <returns>A pageable sequence of <see cref="InstanceGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<RegionInstanceGroupList, InstanceGroup> List(string project, string region, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRegionInstanceGroupsRequest request = new ListRegionInstanceGroupsRequest
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
        /// Retrieves the list of instance group resources contained within the specified region.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
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
        /// <returns>A pageable asynchronous sequence of <see cref="InstanceGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<RegionInstanceGroupList, InstanceGroup> ListAsync(string project, string region, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRegionInstanceGroupsRequest request = new ListRegionInstanceGroupsRequest
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

        /// <summary>
        /// Lists the instances in the specified instance group and displays information about the named ports. Depending on the specified options, this method can list all instances or only the instances that are running. The orderBy query parameter is not supported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="InstanceWithNamedPorts"/> resources.</returns>
        public virtual gax::PagedEnumerable<RegionInstanceGroupsListInstances, InstanceWithNamedPorts> ListInstances(ListInstancesRegionInstanceGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the instances in the specified instance group and displays information about the named ports. Depending on the specified options, this method can list all instances or only the instances that are running. The orderBy query parameter is not supported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="InstanceWithNamedPorts"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<RegionInstanceGroupsListInstances, InstanceWithNamedPorts> ListInstancesAsync(ListInstancesRegionInstanceGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the instances in the specified instance group and displays information about the named ports. Depending on the specified options, this method can list all instances or only the instances that are running. The orderBy query parameter is not supported.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="instanceGroup">
        /// Name of the regional instance group for which we want to list the instances.
        /// </param>
        /// <param name="regionInstanceGroupsListInstancesRequestResource">
        /// The body resource for this request
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
        /// <returns>A pageable sequence of <see cref="InstanceWithNamedPorts"/> resources.</returns>
        public virtual gax::PagedEnumerable<RegionInstanceGroupsListInstances, InstanceWithNamedPorts> ListInstances(string project, string region, string instanceGroup, RegionInstanceGroupsListInstancesRequest regionInstanceGroupsListInstancesRequestResource, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstancesRegionInstanceGroupsRequest request = new ListInstancesRegionInstanceGroupsRequest
            {
                InstanceGroup = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceGroup, nameof(instanceGroup)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                RegionInstanceGroupsListInstancesRequestResource = gax::GaxPreconditions.CheckNotNull(regionInstanceGroupsListInstancesRequestResource, nameof(regionInstanceGroupsListInstancesRequestResource)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListInstances(request, callSettings);
        }

        /// <summary>
        /// Lists the instances in the specified instance group and displays information about the named ports. Depending on the specified options, this method can list all instances or only the instances that are running. The orderBy query parameter is not supported.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="instanceGroup">
        /// Name of the regional instance group for which we want to list the instances.
        /// </param>
        /// <param name="regionInstanceGroupsListInstancesRequestResource">
        /// The body resource for this request
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
        /// <returns>A pageable asynchronous sequence of <see cref="InstanceWithNamedPorts"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<RegionInstanceGroupsListInstances, InstanceWithNamedPorts> ListInstancesAsync(string project, string region, string instanceGroup, RegionInstanceGroupsListInstancesRequest regionInstanceGroupsListInstancesRequestResource, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstancesRegionInstanceGroupsRequest request = new ListInstancesRegionInstanceGroupsRequest
            {
                InstanceGroup = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceGroup, nameof(instanceGroup)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                RegionInstanceGroupsListInstancesRequestResource = gax::GaxPreconditions.CheckNotNull(regionInstanceGroupsListInstancesRequestResource, nameof(regionInstanceGroupsListInstancesRequestResource)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListInstancesAsync(request, callSettings);
        }

        /// <summary>
        /// Sets the named ports for the specified regional instance group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetNamedPorts(SetNamedPortsRegionInstanceGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the named ports for the specified regional instance group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetNamedPortsAsync(SetNamedPortsRegionInstanceGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the named ports for the specified regional instance group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetNamedPortsAsync(SetNamedPortsRegionInstanceGroupRequest request, st::CancellationToken cancellationToken) =>
            SetNamedPortsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SetNamedPorts</c>.</summary>
        public virtual lro::OperationsClient SetNamedPortsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SetNamedPorts</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceSetNamedPorts(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetNamedPortsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetNamedPorts</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceSetNamedPortsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetNamedPortsOperationsClient, callSettings);

        /// <summary>
        /// Sets the named ports for the specified regional instance group.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="instanceGroup">
        /// The name of the regional instance group where the named ports are updated.
        /// </param>
        /// <param name="regionInstanceGroupsSetNamedPortsRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetNamedPorts(string project, string region, string instanceGroup, RegionInstanceGroupsSetNamedPortsRequest regionInstanceGroupsSetNamedPortsRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetNamedPorts(new SetNamedPortsRegionInstanceGroupRequest
            {
                InstanceGroup = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceGroup, nameof(instanceGroup)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                RegionInstanceGroupsSetNamedPortsRequestResource = gax::GaxPreconditions.CheckNotNull(regionInstanceGroupsSetNamedPortsRequestResource, nameof(regionInstanceGroupsSetNamedPortsRequestResource)),
            }, callSettings);

        /// <summary>
        /// Sets the named ports for the specified regional instance group.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="instanceGroup">
        /// The name of the regional instance group where the named ports are updated.
        /// </param>
        /// <param name="regionInstanceGroupsSetNamedPortsRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetNamedPortsAsync(string project, string region, string instanceGroup, RegionInstanceGroupsSetNamedPortsRequest regionInstanceGroupsSetNamedPortsRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetNamedPortsAsync(new SetNamedPortsRegionInstanceGroupRequest
            {
                InstanceGroup = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceGroup, nameof(instanceGroup)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                RegionInstanceGroupsSetNamedPortsRequestResource = gax::GaxPreconditions.CheckNotNull(regionInstanceGroupsSetNamedPortsRequestResource, nameof(regionInstanceGroupsSetNamedPortsRequestResource)),
            }, callSettings);

        /// <summary>
        /// Sets the named ports for the specified regional instance group.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="instanceGroup">
        /// The name of the regional instance group where the named ports are updated.
        /// </param>
        /// <param name="regionInstanceGroupsSetNamedPortsRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetNamedPortsAsync(string project, string region, string instanceGroup, RegionInstanceGroupsSetNamedPortsRequest regionInstanceGroupsSetNamedPortsRequestResource, st::CancellationToken cancellationToken) =>
            SetNamedPortsAsync(project, region, instanceGroup, regionInstanceGroupsSetNamedPortsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>RegionInstanceGroups client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The RegionInstanceGroups API.
    /// </remarks>
    public sealed partial class RegionInstanceGroupsClientImpl : RegionInstanceGroupsClient
    {
        private readonly gaxgrpc::ApiCall<GetRegionInstanceGroupRequest, InstanceGroup> _callGet;

        private readonly gaxgrpc::ApiCall<ListRegionInstanceGroupsRequest, RegionInstanceGroupList> _callList;

        private readonly gaxgrpc::ApiCall<ListInstancesRegionInstanceGroupsRequest, RegionInstanceGroupsListInstances> _callListInstances;

        private readonly gaxgrpc::ApiCall<SetNamedPortsRegionInstanceGroupRequest, Operation> _callSetNamedPorts;

        /// <summary>
        /// Constructs a client wrapper for the RegionInstanceGroups service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="RegionInstanceGroupsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public RegionInstanceGroupsClientImpl(RegionInstanceGroups.RegionInstanceGroupsClient grpcClient, RegionInstanceGroupsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            RegionInstanceGroupsSettings effectiveSettings = settings ?? RegionInstanceGroupsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            SetNamedPortsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForRegionOperations(), effectiveSettings.SetNamedPortsOperationsSettings, logger);
            _callGet = clientHelper.BuildApiCall<GetRegionInstanceGroupRequest, InstanceGroup>("Get", grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("instance_group", request => request.InstanceGroup);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callList = clientHelper.BuildApiCall<ListRegionInstanceGroupsRequest, RegionInstanceGroupList>("List", grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            _callListInstances = clientHelper.BuildApiCall<ListInstancesRegionInstanceGroupsRequest, RegionInstanceGroupsListInstances>("ListInstances", grpcClient.ListInstancesAsync, grpcClient.ListInstances, effectiveSettings.ListInstancesSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("instance_group", request => request.InstanceGroup);
            Modify_ApiCall(ref _callListInstances);
            Modify_ListInstancesApiCall(ref _callListInstances);
            _callSetNamedPorts = clientHelper.BuildApiCall<SetNamedPortsRegionInstanceGroupRequest, Operation>("SetNamedPorts", grpcClient.SetNamedPortsAsync, grpcClient.SetNamedPorts, effectiveSettings.SetNamedPortsSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("instance_group", request => request.InstanceGroup);
            Modify_ApiCall(ref _callSetNamedPorts);
            Modify_SetNamedPortsApiCall(ref _callSetNamedPorts);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetRegionInstanceGroupRequest, InstanceGroup> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListRegionInstanceGroupsRequest, RegionInstanceGroupList> call);

        partial void Modify_ListInstancesApiCall(ref gaxgrpc::ApiCall<ListInstancesRegionInstanceGroupsRequest, RegionInstanceGroupsListInstances> call);

        partial void Modify_SetNamedPortsApiCall(ref gaxgrpc::ApiCall<SetNamedPortsRegionInstanceGroupRequest, Operation> call);

        partial void OnConstruction(RegionInstanceGroups.RegionInstanceGroupsClient grpcClient, RegionInstanceGroupsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC RegionInstanceGroups client</summary>
        public override RegionInstanceGroups.RegionInstanceGroupsClient GrpcClient { get; }

        partial void Modify_GetRegionInstanceGroupRequest(ref GetRegionInstanceGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRegionInstanceGroupsRequest(ref ListRegionInstanceGroupsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListInstancesRegionInstanceGroupsRequest(ref ListInstancesRegionInstanceGroupsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetNamedPortsRegionInstanceGroupRequest(ref SetNamedPortsRegionInstanceGroupRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the specified instance group resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override InstanceGroup Get(GetRegionInstanceGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRegionInstanceGroupRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified instance group resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<InstanceGroup> GetAsync(GetRegionInstanceGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRegionInstanceGroupRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of instance group resources contained within the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="InstanceGroup"/> resources.</returns>
        public override gax::PagedEnumerable<RegionInstanceGroupList, InstanceGroup> List(ListRegionInstanceGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRegionInstanceGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRegionInstanceGroupsRequest, RegionInstanceGroupList, InstanceGroup>(_callList, request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of instance group resources contained within the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="InstanceGroup"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<RegionInstanceGroupList, InstanceGroup> ListAsync(ListRegionInstanceGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRegionInstanceGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRegionInstanceGroupsRequest, RegionInstanceGroupList, InstanceGroup>(_callList, request, callSettings);
        }

        /// <summary>
        /// Lists the instances in the specified instance group and displays information about the named ports. Depending on the specified options, this method can list all instances or only the instances that are running. The orderBy query parameter is not supported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="InstanceWithNamedPorts"/> resources.</returns>
        public override gax::PagedEnumerable<RegionInstanceGroupsListInstances, InstanceWithNamedPorts> ListInstances(ListInstancesRegionInstanceGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstancesRegionInstanceGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListInstancesRegionInstanceGroupsRequest, RegionInstanceGroupsListInstances, InstanceWithNamedPorts>(_callListInstances, request, callSettings);
        }

        /// <summary>
        /// Lists the instances in the specified instance group and displays information about the named ports. Depending on the specified options, this method can list all instances or only the instances that are running. The orderBy query parameter is not supported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="InstanceWithNamedPorts"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<RegionInstanceGroupsListInstances, InstanceWithNamedPorts> ListInstancesAsync(ListInstancesRegionInstanceGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstancesRegionInstanceGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListInstancesRegionInstanceGroupsRequest, RegionInstanceGroupsListInstances, InstanceWithNamedPorts>(_callListInstances, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>SetNamedPorts</c>.</summary>
        public override lro::OperationsClient SetNamedPortsOperationsClient { get; }

        /// <summary>
        /// Sets the named ports for the specified regional instance group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> SetNamedPorts(SetNamedPortsRegionInstanceGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetNamedPortsRegionInstanceGroupRequest(ref request, ref callSettings);
            Operation response = _callSetNamedPorts.Sync(request, callSettings);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetNamedPortsOperationsClient);
        }

        /// <summary>
        /// Sets the named ports for the specified regional instance group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> SetNamedPortsAsync(SetNamedPortsRegionInstanceGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetNamedPortsRegionInstanceGroupRequest(ref request, ref callSettings);
            Operation response = await _callSetNamedPorts.Async(request, callSettings).ConfigureAwait(false);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetNamedPortsOperationsClient);
        }
    }

    public partial class ListRegionInstanceGroupsRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class ListInstancesRegionInstanceGroupsRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class RegionInstanceGroupList : gaxgrpc::IPageResponse<InstanceGroup>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<InstanceGroup> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class RegionInstanceGroupsListInstances : gaxgrpc::IPageResponse<InstanceWithNamedPorts>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<InstanceWithNamedPorts> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class RegionInstanceGroups
    {
        public partial class RegionInstanceGroupsClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client, delegating to RegionOperations.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClientForRegionOperations() =>
                RegionOperations.RegionOperationsClient.CreateOperationsClient(CallInvoker);
        }
    }
}
