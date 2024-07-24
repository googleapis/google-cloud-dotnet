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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gcl = Google.Cloud.Location;
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
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Redis.Cluster.V1
{
    /// <summary>Settings for <see cref="CloudRedisClusterClient"/> instances.</summary>
    public sealed partial class CloudRedisClusterSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CloudRedisClusterSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CloudRedisClusterSettings"/>.</returns>
        public static CloudRedisClusterSettings GetDefault() => new CloudRedisClusterSettings();

        /// <summary>Constructs a new <see cref="CloudRedisClusterSettings"/> object with default settings.</summary>
        public CloudRedisClusterSettings()
        {
        }

        private CloudRedisClusterSettings(CloudRedisClusterSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListClustersSettings = existing.ListClustersSettings;
            GetClusterSettings = existing.GetClusterSettings;
            UpdateClusterSettings = existing.UpdateClusterSettings;
            UpdateClusterOperationsSettings = existing.UpdateClusterOperationsSettings.Clone();
            DeleteClusterSettings = existing.DeleteClusterSettings;
            DeleteClusterOperationsSettings = existing.DeleteClusterOperationsSettings.Clone();
            CreateClusterSettings = existing.CreateClusterSettings;
            CreateClusterOperationsSettings = existing.CreateClusterOperationsSettings.Clone();
            GetClusterCertificateAuthoritySettings = existing.GetClusterCertificateAuthoritySettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CloudRedisClusterSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudRedisClusterClient.ListClusters</c> and <c>CloudRedisClusterClient.ListClustersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListClustersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudRedisClusterClient.GetCluster</c> and <c>CloudRedisClusterClient.GetClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudRedisClusterClient.UpdateCluster</c> and <c>CloudRedisClusterClient.UpdateClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudRedisClusterClient.UpdateCluster</c> and
        /// <c>CloudRedisClusterClient.UpdateClusterAsync</c>.
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
        public lro::OperationsSettings UpdateClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudRedisClusterClient.DeleteCluster</c> and <c>CloudRedisClusterClient.DeleteClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudRedisClusterClient.DeleteCluster</c> and
        /// <c>CloudRedisClusterClient.DeleteClusterAsync</c>.
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
        public lro::OperationsSettings DeleteClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudRedisClusterClient.CreateCluster</c> and <c>CloudRedisClusterClient.CreateClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudRedisClusterClient.CreateCluster</c> and
        /// <c>CloudRedisClusterClient.CreateClusterAsync</c>.
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
        public lro::OperationsSettings CreateClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudRedisClusterClient.GetClusterCertificateAuthority</c> and
        /// <c>CloudRedisClusterClient.GetClusterCertificateAuthorityAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetClusterCertificateAuthoritySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CloudRedisClusterSettings"/> object.</returns>
        public CloudRedisClusterSettings Clone() => new CloudRedisClusterSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CloudRedisClusterClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class CloudRedisClusterClientBuilder : gaxgrpc::ClientBuilderBase<CloudRedisClusterClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CloudRedisClusterSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CloudRedisClusterClientBuilder() : base(CloudRedisClusterClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CloudRedisClusterClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CloudRedisClusterClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CloudRedisClusterClient Build()
        {
            CloudRedisClusterClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CloudRedisClusterClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CloudRedisClusterClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CloudRedisClusterClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CloudRedisClusterClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CloudRedisClusterClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CloudRedisClusterClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CloudRedisClusterClient.ChannelPool;
    }

    /// <summary>CloudRedisCluster client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Configures and manages Cloud Memorystore for Redis clusters
    /// 
    /// Google Cloud Memorystore for Redis Cluster
    /// 
    /// The `redis.googleapis.com` service implements the Google Cloud Memorystore
    /// for Redis API and defines the following resource model for managing Redis
    /// clusters:
    /// * The service works with a collection of cloud projects, named: `/projects/*`
    /// * Each project has a collection of available locations, named: `/locations/*`
    /// * Each location has a collection of Redis clusters, named: `/clusters/*`
    /// * As such, Redis clusters are resources of the form:
    /// `/projects/{project_id}/locations/{location_id}/clusters/{instance_id}`
    /// 
    /// Note that location_id must be a GCP `region`; for example:
    /// * `projects/redpepper-1290/locations/us-central1/clusters/my-redis`
    /// 
    /// We use API version selector for Flex APIs
    /// * The versioning strategy is release-based versioning
    /// * Our backend CLH only deals with the superset version (called v1main)
    /// * Existing backend for Redis Gen1 and MRR is not touched.
    /// * More details in go/redis-flex-api-versioning
    /// </remarks>
    public abstract partial class CloudRedisClusterClient
    {
        /// <summary>
        /// The default endpoint for the CloudRedisCluster service, which is a host of "redis.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "redis.googleapis.com:443";

        /// <summary>The default CloudRedisCluster scopes.</summary>
        /// <remarks>
        /// The default CloudRedisCluster scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CloudRedisCluster.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CloudRedisClusterClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CloudRedisClusterClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CloudRedisClusterClient"/>.</returns>
        public static stt::Task<CloudRedisClusterClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CloudRedisClusterClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CloudRedisClusterClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CloudRedisClusterClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CloudRedisClusterClient"/>.</returns>
        public static CloudRedisClusterClient Create() => new CloudRedisClusterClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CloudRedisClusterClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CloudRedisClusterSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CloudRedisClusterClient"/>.</returns>
        internal static CloudRedisClusterClient Create(grpccore::CallInvoker callInvoker, CloudRedisClusterSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CloudRedisCluster.CloudRedisClusterClient grpcClient = new CloudRedisCluster.CloudRedisClusterClient(callInvoker);
            return new CloudRedisClusterClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CloudRedisCluster client</summary>
        public virtual CloudRedisCluster.CloudRedisClusterClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all Redis clusters owned by a project in either the specified
        /// location (region) or all locations.
        /// 
        /// The location should have the following format:
        /// 
        /// * `projects/{project_id}/locations/{location_id}`
        /// 
        /// If `location_id` is specified as `-` (wildcard), then all regions
        /// available to the project are queried, and the results are aggregated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Cluster"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListClustersResponse, Cluster> ListClusters(ListClustersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all Redis clusters owned by a project in either the specified
        /// location (region) or all locations.
        /// 
        /// The location should have the following format:
        /// 
        /// * `projects/{project_id}/locations/{location_id}`
        /// 
        /// If `location_id` is specified as `-` (wildcard), then all regions
        /// available to the project are queried, and the results are aggregated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Cluster"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListClustersResponse, Cluster> ListClustersAsync(ListClustersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all Redis clusters owned by a project in either the specified
        /// location (region) or all locations.
        /// 
        /// The location should have the following format:
        /// 
        /// * `projects/{project_id}/locations/{location_id}`
        /// 
        /// If `location_id` is specified as `-` (wildcard), then all regions
        /// available to the project are queried, and the results are aggregated.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the cluster location using the form:
        /// `projects/{project_id}/locations/{location_id}`
        /// where `location_id` refers to a GCP region.
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
        /// <returns>A pageable sequence of <see cref="Cluster"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListClustersResponse, Cluster> ListClusters(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListClustersRequest request = new ListClustersRequest
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
            return ListClusters(request, callSettings);
        }

        /// <summary>
        /// Lists all Redis clusters owned by a project in either the specified
        /// location (region) or all locations.
        /// 
        /// The location should have the following format:
        /// 
        /// * `projects/{project_id}/locations/{location_id}`
        /// 
        /// If `location_id` is specified as `-` (wildcard), then all regions
        /// available to the project are queried, and the results are aggregated.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the cluster location using the form:
        /// `projects/{project_id}/locations/{location_id}`
        /// where `location_id` refers to a GCP region.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Cluster"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListClustersResponse, Cluster> ListClustersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListClustersRequest request = new ListClustersRequest
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
            return ListClustersAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all Redis clusters owned by a project in either the specified
        /// location (region) or all locations.
        /// 
        /// The location should have the following format:
        /// 
        /// * `projects/{project_id}/locations/{location_id}`
        /// 
        /// If `location_id` is specified as `-` (wildcard), then all regions
        /// available to the project are queried, and the results are aggregated.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the cluster location using the form:
        /// `projects/{project_id}/locations/{location_id}`
        /// where `location_id` refers to a GCP region.
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
        /// <returns>A pageable sequence of <see cref="Cluster"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListClustersResponse, Cluster> ListClusters(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListClustersRequest request = new ListClustersRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListClusters(request, callSettings);
        }

        /// <summary>
        /// Lists all Redis clusters owned by a project in either the specified
        /// location (region) or all locations.
        /// 
        /// The location should have the following format:
        /// 
        /// * `projects/{project_id}/locations/{location_id}`
        /// 
        /// If `location_id` is specified as `-` (wildcard), then all regions
        /// available to the project are queried, and the results are aggregated.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the cluster location using the form:
        /// `projects/{project_id}/locations/{location_id}`
        /// where `location_id` refers to a GCP region.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Cluster"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListClustersResponse, Cluster> ListClustersAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListClustersRequest request = new ListClustersRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListClustersAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a specific Redis cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Cluster GetCluster(GetClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a specific Redis cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Cluster> GetClusterAsync(GetClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a specific Redis cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Cluster> GetClusterAsync(GetClusterRequest request, st::CancellationToken cancellationToken) =>
            GetClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a specific Redis cluster.
        /// </summary>
        /// <param name="name">
        /// Required. Redis cluster resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/clusters/{cluster_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Cluster GetCluster(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCluster(new GetClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific Redis cluster.
        /// </summary>
        /// <param name="name">
        /// Required. Redis cluster resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/clusters/{cluster_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Cluster> GetClusterAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetClusterAsync(new GetClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific Redis cluster.
        /// </summary>
        /// <param name="name">
        /// Required. Redis cluster resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/clusters/{cluster_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Cluster> GetClusterAsync(string name, st::CancellationToken cancellationToken) =>
            GetClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a specific Redis cluster.
        /// </summary>
        /// <param name="name">
        /// Required. Redis cluster resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/clusters/{cluster_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Cluster GetCluster(ClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCluster(new GetClusterRequest
            {
                ClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific Redis cluster.
        /// </summary>
        /// <param name="name">
        /// Required. Redis cluster resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/clusters/{cluster_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Cluster> GetClusterAsync(ClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            GetClusterAsync(new GetClusterRequest
            {
                ClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific Redis cluster.
        /// </summary>
        /// <param name="name">
        /// Required. Redis cluster resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/clusters/{cluster_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Cluster> GetClusterAsync(ClusterName name, st::CancellationToken cancellationToken) =>
            GetClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the metadata and configuration of a specific Redis cluster.
        /// 
        /// Completed longrunning.Operation will contain the new cluster object
        /// in the response field. The returned operation is automatically deleted
        /// after a few hours, so there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Cluster, wkt::Any> UpdateCluster(UpdateClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the metadata and configuration of a specific Redis cluster.
        /// 
        /// Completed longrunning.Operation will contain the new cluster object
        /// in the response field. The returned operation is automatically deleted
        /// after a few hours, so there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, wkt::Any>> UpdateClusterAsync(UpdateClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the metadata and configuration of a specific Redis cluster.
        /// 
        /// Completed longrunning.Operation will contain the new cluster object
        /// in the response field. The returned operation is automatically deleted
        /// after a few hours, so there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, wkt::Any>> UpdateClusterAsync(UpdateClusterRequest request, st::CancellationToken cancellationToken) =>
            UpdateClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateCluster</c>.</summary>
        public virtual lro::OperationsClient UpdateClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Cluster, wkt::Any> PollOnceUpdateCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Cluster, wkt::Any>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Cluster, wkt::Any>> PollOnceUpdateClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Cluster, wkt::Any>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateClusterOperationsClient, callSettings);

        /// <summary>
        /// Updates the metadata and configuration of a specific Redis cluster.
        /// 
        /// Completed longrunning.Operation will contain the new cluster object
        /// in the response field. The returned operation is automatically deleted
        /// after a few hours, so there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="cluster">
        /// Required. Update description.
        /// Only fields specified in update_mask are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field. The elements of the repeated paths field may only include these
        /// fields from [Cluster][google.cloud.redis.cluster.v1.Cluster]:
        /// 
        /// *   `size_gb`
        /// *   `replica_count`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Cluster, wkt::Any> UpdateCluster(Cluster cluster, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCluster(new UpdateClusterRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Cluster = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
            }, callSettings);

        /// <summary>
        /// Updates the metadata and configuration of a specific Redis cluster.
        /// 
        /// Completed longrunning.Operation will contain the new cluster object
        /// in the response field. The returned operation is automatically deleted
        /// after a few hours, so there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="cluster">
        /// Required. Update description.
        /// Only fields specified in update_mask are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field. The elements of the repeated paths field may only include these
        /// fields from [Cluster][google.cloud.redis.cluster.v1.Cluster]:
        /// 
        /// *   `size_gb`
        /// *   `replica_count`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, wkt::Any>> UpdateClusterAsync(Cluster cluster, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateClusterAsync(new UpdateClusterRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Cluster = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
            }, callSettings);

        /// <summary>
        /// Updates the metadata and configuration of a specific Redis cluster.
        /// 
        /// Completed longrunning.Operation will contain the new cluster object
        /// in the response field. The returned operation is automatically deleted
        /// after a few hours, so there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="cluster">
        /// Required. Update description.
        /// Only fields specified in update_mask are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field. The elements of the repeated paths field may only include these
        /// fields from [Cluster][google.cloud.redis.cluster.v1.Cluster]:
        /// 
        /// *   `size_gb`
        /// *   `replica_count`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, wkt::Any>> UpdateClusterAsync(Cluster cluster, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateClusterAsync(cluster, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a specific Redis cluster. Cluster stops serving and data is
        /// deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Any> DeleteCluster(DeleteClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a specific Redis cluster. Cluster stops serving and data is
        /// deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Any>> DeleteClusterAsync(DeleteClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a specific Redis cluster. Cluster stops serving and data is
        /// deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Any>> DeleteClusterAsync(DeleteClusterRequest request, st::CancellationToken cancellationToken) =>
            DeleteClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteCluster</c>.</summary>
        public virtual lro::OperationsClient DeleteClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Any> PollOnceDeleteCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, wkt::Any>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Any>> PollOnceDeleteClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, wkt::Any>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteClusterOperationsClient, callSettings);

        /// <summary>
        /// Deletes a specific Redis cluster. Cluster stops serving and data is
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. Redis cluster resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/clusters/{cluster_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Any> DeleteCluster(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCluster(new DeleteClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific Redis cluster. Cluster stops serving and data is
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. Redis cluster resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/clusters/{cluster_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Any>> DeleteClusterAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteClusterAsync(new DeleteClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific Redis cluster. Cluster stops serving and data is
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. Redis cluster resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/clusters/{cluster_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Any>> DeleteClusterAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a specific Redis cluster. Cluster stops serving and data is
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. Redis cluster resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/clusters/{cluster_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Any> DeleteCluster(ClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCluster(new DeleteClusterRequest
            {
                ClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific Redis cluster. Cluster stops serving and data is
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. Redis cluster resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/clusters/{cluster_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Any>> DeleteClusterAsync(ClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteClusterAsync(new DeleteClusterRequest
            {
                ClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific Redis cluster. Cluster stops serving and data is
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. Redis cluster resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/clusters/{cluster_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Any>> DeleteClusterAsync(ClusterName name, st::CancellationToken cancellationToken) =>
            DeleteClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Redis cluster based on the specified properties.
        /// The creation is executed asynchronously and callers may check the returned
        /// operation to track its progress. Once the operation is completed the Redis
        /// cluster will be fully functional. The completed longrunning.Operation will
        /// contain the new cluster object in the response field.
        /// 
        /// The returned operation is automatically deleted after a few hours, so there
        /// is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Cluster, wkt::Any> CreateCluster(CreateClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Redis cluster based on the specified properties.
        /// The creation is executed asynchronously and callers may check the returned
        /// operation to track its progress. Once the operation is completed the Redis
        /// cluster will be fully functional. The completed longrunning.Operation will
        /// contain the new cluster object in the response field.
        /// 
        /// The returned operation is automatically deleted after a few hours, so there
        /// is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, wkt::Any>> CreateClusterAsync(CreateClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Redis cluster based on the specified properties.
        /// The creation is executed asynchronously and callers may check the returned
        /// operation to track its progress. Once the operation is completed the Redis
        /// cluster will be fully functional. The completed longrunning.Operation will
        /// contain the new cluster object in the response field.
        /// 
        /// The returned operation is automatically deleted after a few hours, so there
        /// is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, wkt::Any>> CreateClusterAsync(CreateClusterRequest request, st::CancellationToken cancellationToken) =>
            CreateClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateCluster</c>.</summary>
        public virtual lro::OperationsClient CreateClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Cluster, wkt::Any> PollOnceCreateCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Cluster, wkt::Any>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Cluster, wkt::Any>> PollOnceCreateClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Cluster, wkt::Any>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateClusterOperationsClient, callSettings);

        /// <summary>
        /// Creates a Redis cluster based on the specified properties.
        /// The creation is executed asynchronously and callers may check the returned
        /// operation to track its progress. Once the operation is completed the Redis
        /// cluster will be fully functional. The completed longrunning.Operation will
        /// contain the new cluster object in the response field.
        /// 
        /// The returned operation is automatically deleted after a few hours, so there
        /// is no need to call DeleteOperation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the cluster location using the form:
        /// `projects/{project_id}/locations/{location_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="cluster">
        /// Required. The cluster that is to be created.
        /// </param>
        /// <param name="clusterId">
        /// Required. The logical name of the Redis cluster in the customer project
        /// with the following restrictions:
        /// 
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the customer project / location
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Cluster, wkt::Any> CreateCluster(string parent, Cluster cluster, string clusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCluster(new CreateClusterRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                Cluster = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
            }, callSettings);

        /// <summary>
        /// Creates a Redis cluster based on the specified properties.
        /// The creation is executed asynchronously and callers may check the returned
        /// operation to track its progress. Once the operation is completed the Redis
        /// cluster will be fully functional. The completed longrunning.Operation will
        /// contain the new cluster object in the response field.
        /// 
        /// The returned operation is automatically deleted after a few hours, so there
        /// is no need to call DeleteOperation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the cluster location using the form:
        /// `projects/{project_id}/locations/{location_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="cluster">
        /// Required. The cluster that is to be created.
        /// </param>
        /// <param name="clusterId">
        /// Required. The logical name of the Redis cluster in the customer project
        /// with the following restrictions:
        /// 
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the customer project / location
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, wkt::Any>> CreateClusterAsync(string parent, Cluster cluster, string clusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateClusterAsync(new CreateClusterRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                Cluster = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
            }, callSettings);

        /// <summary>
        /// Creates a Redis cluster based on the specified properties.
        /// The creation is executed asynchronously and callers may check the returned
        /// operation to track its progress. Once the operation is completed the Redis
        /// cluster will be fully functional. The completed longrunning.Operation will
        /// contain the new cluster object in the response field.
        /// 
        /// The returned operation is automatically deleted after a few hours, so there
        /// is no need to call DeleteOperation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the cluster location using the form:
        /// `projects/{project_id}/locations/{location_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="cluster">
        /// Required. The cluster that is to be created.
        /// </param>
        /// <param name="clusterId">
        /// Required. The logical name of the Redis cluster in the customer project
        /// with the following restrictions:
        /// 
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the customer project / location
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, wkt::Any>> CreateClusterAsync(string parent, Cluster cluster, string clusterId, st::CancellationToken cancellationToken) =>
            CreateClusterAsync(parent, cluster, clusterId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Redis cluster based on the specified properties.
        /// The creation is executed asynchronously and callers may check the returned
        /// operation to track its progress. Once the operation is completed the Redis
        /// cluster will be fully functional. The completed longrunning.Operation will
        /// contain the new cluster object in the response field.
        /// 
        /// The returned operation is automatically deleted after a few hours, so there
        /// is no need to call DeleteOperation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the cluster location using the form:
        /// `projects/{project_id}/locations/{location_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="cluster">
        /// Required. The cluster that is to be created.
        /// </param>
        /// <param name="clusterId">
        /// Required. The logical name of the Redis cluster in the customer project
        /// with the following restrictions:
        /// 
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the customer project / location
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Cluster, wkt::Any> CreateCluster(gagr::LocationName parent, Cluster cluster, string clusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCluster(new CreateClusterRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                Cluster = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
            }, callSettings);

        /// <summary>
        /// Creates a Redis cluster based on the specified properties.
        /// The creation is executed asynchronously and callers may check the returned
        /// operation to track its progress. Once the operation is completed the Redis
        /// cluster will be fully functional. The completed longrunning.Operation will
        /// contain the new cluster object in the response field.
        /// 
        /// The returned operation is automatically deleted after a few hours, so there
        /// is no need to call DeleteOperation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the cluster location using the form:
        /// `projects/{project_id}/locations/{location_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="cluster">
        /// Required. The cluster that is to be created.
        /// </param>
        /// <param name="clusterId">
        /// Required. The logical name of the Redis cluster in the customer project
        /// with the following restrictions:
        /// 
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the customer project / location
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, wkt::Any>> CreateClusterAsync(gagr::LocationName parent, Cluster cluster, string clusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateClusterAsync(new CreateClusterRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                Cluster = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
            }, callSettings);

        /// <summary>
        /// Creates a Redis cluster based on the specified properties.
        /// The creation is executed asynchronously and callers may check the returned
        /// operation to track its progress. Once the operation is completed the Redis
        /// cluster will be fully functional. The completed longrunning.Operation will
        /// contain the new cluster object in the response field.
        /// 
        /// The returned operation is automatically deleted after a few hours, so there
        /// is no need to call DeleteOperation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the cluster location using the form:
        /// `projects/{project_id}/locations/{location_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="cluster">
        /// Required. The cluster that is to be created.
        /// </param>
        /// <param name="clusterId">
        /// Required. The logical name of the Redis cluster in the customer project
        /// with the following restrictions:
        /// 
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the customer project / location
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, wkt::Any>> CreateClusterAsync(gagr::LocationName parent, Cluster cluster, string clusterId, st::CancellationToken cancellationToken) =>
            CreateClusterAsync(parent, cluster, clusterId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of certificate authority information for Redis cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CertificateAuthority GetClusterCertificateAuthority(GetClusterCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of certificate authority information for Redis cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateAuthority> GetClusterCertificateAuthorityAsync(GetClusterCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of certificate authority information for Redis cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateAuthority> GetClusterCertificateAuthorityAsync(GetClusterCertificateAuthorityRequest request, st::CancellationToken cancellationToken) =>
            GetClusterCertificateAuthorityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of certificate authority information for Redis cluster.
        /// </summary>
        /// <param name="name">
        /// Required. Redis cluster certificate authority resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/clusters/{cluster_id}/certificateAuthority`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CertificateAuthority GetClusterCertificateAuthority(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetClusterCertificateAuthority(new GetClusterCertificateAuthorityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of certificate authority information for Redis cluster.
        /// </summary>
        /// <param name="name">
        /// Required. Redis cluster certificate authority resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/clusters/{cluster_id}/certificateAuthority`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateAuthority> GetClusterCertificateAuthorityAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetClusterCertificateAuthorityAsync(new GetClusterCertificateAuthorityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of certificate authority information for Redis cluster.
        /// </summary>
        /// <param name="name">
        /// Required. Redis cluster certificate authority resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/clusters/{cluster_id}/certificateAuthority`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateAuthority> GetClusterCertificateAuthorityAsync(string name, st::CancellationToken cancellationToken) =>
            GetClusterCertificateAuthorityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of certificate authority information for Redis cluster.
        /// </summary>
        /// <param name="name">
        /// Required. Redis cluster certificate authority resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/clusters/{cluster_id}/certificateAuthority`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CertificateAuthority GetClusterCertificateAuthority(CertificateAuthorityName name, gaxgrpc::CallSettings callSettings = null) =>
            GetClusterCertificateAuthority(new GetClusterCertificateAuthorityRequest
            {
                CertificateAuthorityName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of certificate authority information for Redis cluster.
        /// </summary>
        /// <param name="name">
        /// Required. Redis cluster certificate authority resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/clusters/{cluster_id}/certificateAuthority`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateAuthority> GetClusterCertificateAuthorityAsync(CertificateAuthorityName name, gaxgrpc::CallSettings callSettings = null) =>
            GetClusterCertificateAuthorityAsync(new GetClusterCertificateAuthorityRequest
            {
                CertificateAuthorityName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of certificate authority information for Redis cluster.
        /// </summary>
        /// <param name="name">
        /// Required. Redis cluster certificate authority resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/clusters/{cluster_id}/certificateAuthority`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateAuthority> GetClusterCertificateAuthorityAsync(CertificateAuthorityName name, st::CancellationToken cancellationToken) =>
            GetClusterCertificateAuthorityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CloudRedisCluster client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Configures and manages Cloud Memorystore for Redis clusters
    /// 
    /// Google Cloud Memorystore for Redis Cluster
    /// 
    /// The `redis.googleapis.com` service implements the Google Cloud Memorystore
    /// for Redis API and defines the following resource model for managing Redis
    /// clusters:
    /// * The service works with a collection of cloud projects, named: `/projects/*`
    /// * Each project has a collection of available locations, named: `/locations/*`
    /// * Each location has a collection of Redis clusters, named: `/clusters/*`
    /// * As such, Redis clusters are resources of the form:
    /// `/projects/{project_id}/locations/{location_id}/clusters/{instance_id}`
    /// 
    /// Note that location_id must be a GCP `region`; for example:
    /// * `projects/redpepper-1290/locations/us-central1/clusters/my-redis`
    /// 
    /// We use API version selector for Flex APIs
    /// * The versioning strategy is release-based versioning
    /// * Our backend CLH only deals with the superset version (called v1main)
    /// * Existing backend for Redis Gen1 and MRR is not touched.
    /// * More details in go/redis-flex-api-versioning
    /// </remarks>
    public sealed partial class CloudRedisClusterClientImpl : CloudRedisClusterClient
    {
        private readonly gaxgrpc::ApiCall<ListClustersRequest, ListClustersResponse> _callListClusters;

        private readonly gaxgrpc::ApiCall<GetClusterRequest, Cluster> _callGetCluster;

        private readonly gaxgrpc::ApiCall<UpdateClusterRequest, lro::Operation> _callUpdateCluster;

        private readonly gaxgrpc::ApiCall<DeleteClusterRequest, lro::Operation> _callDeleteCluster;

        private readonly gaxgrpc::ApiCall<CreateClusterRequest, lro::Operation> _callCreateCluster;

        private readonly gaxgrpc::ApiCall<GetClusterCertificateAuthorityRequest, CertificateAuthority> _callGetClusterCertificateAuthority;

        /// <summary>
        /// Constructs a client wrapper for the CloudRedisCluster service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CloudRedisClusterSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CloudRedisClusterClientImpl(CloudRedisCluster.CloudRedisClusterClient grpcClient, CloudRedisClusterSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CloudRedisClusterSettings effectiveSettings = settings ?? CloudRedisClusterSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            UpdateClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateClusterOperationsSettings, logger);
            DeleteClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteClusterOperationsSettings, logger);
            CreateClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateClusterOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListClusters = clientHelper.BuildApiCall<ListClustersRequest, ListClustersResponse>("ListClusters", grpcClient.ListClustersAsync, grpcClient.ListClusters, effectiveSettings.ListClustersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListClusters);
            Modify_ListClustersApiCall(ref _callListClusters);
            _callGetCluster = clientHelper.BuildApiCall<GetClusterRequest, Cluster>("GetCluster", grpcClient.GetClusterAsync, grpcClient.GetCluster, effectiveSettings.GetClusterSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCluster);
            Modify_GetClusterApiCall(ref _callGetCluster);
            _callUpdateCluster = clientHelper.BuildApiCall<UpdateClusterRequest, lro::Operation>("UpdateCluster", grpcClient.UpdateClusterAsync, grpcClient.UpdateCluster, effectiveSettings.UpdateClusterSettings).WithGoogleRequestParam("cluster.name", request => request.Cluster?.Name);
            Modify_ApiCall(ref _callUpdateCluster);
            Modify_UpdateClusterApiCall(ref _callUpdateCluster);
            _callDeleteCluster = clientHelper.BuildApiCall<DeleteClusterRequest, lro::Operation>("DeleteCluster", grpcClient.DeleteClusterAsync, grpcClient.DeleteCluster, effectiveSettings.DeleteClusterSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteCluster);
            Modify_DeleteClusterApiCall(ref _callDeleteCluster);
            _callCreateCluster = clientHelper.BuildApiCall<CreateClusterRequest, lro::Operation>("CreateCluster", grpcClient.CreateClusterAsync, grpcClient.CreateCluster, effectiveSettings.CreateClusterSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCluster);
            Modify_CreateClusterApiCall(ref _callCreateCluster);
            _callGetClusterCertificateAuthority = clientHelper.BuildApiCall<GetClusterCertificateAuthorityRequest, CertificateAuthority>("GetClusterCertificateAuthority", grpcClient.GetClusterCertificateAuthorityAsync, grpcClient.GetClusterCertificateAuthority, effectiveSettings.GetClusterCertificateAuthoritySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetClusterCertificateAuthority);
            Modify_GetClusterCertificateAuthorityApiCall(ref _callGetClusterCertificateAuthority);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListClustersApiCall(ref gaxgrpc::ApiCall<ListClustersRequest, ListClustersResponse> call);

        partial void Modify_GetClusterApiCall(ref gaxgrpc::ApiCall<GetClusterRequest, Cluster> call);

        partial void Modify_UpdateClusterApiCall(ref gaxgrpc::ApiCall<UpdateClusterRequest, lro::Operation> call);

        partial void Modify_DeleteClusterApiCall(ref gaxgrpc::ApiCall<DeleteClusterRequest, lro::Operation> call);

        partial void Modify_CreateClusterApiCall(ref gaxgrpc::ApiCall<CreateClusterRequest, lro::Operation> call);

        partial void Modify_GetClusterCertificateAuthorityApiCall(ref gaxgrpc::ApiCall<GetClusterCertificateAuthorityRequest, CertificateAuthority> call);

        partial void OnConstruction(CloudRedisCluster.CloudRedisClusterClient grpcClient, CloudRedisClusterSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CloudRedisCluster client</summary>
        public override CloudRedisCluster.CloudRedisClusterClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListClustersRequest(ref ListClustersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetClusterRequest(ref GetClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateClusterRequest(ref UpdateClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteClusterRequest(ref DeleteClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateClusterRequest(ref CreateClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetClusterCertificateAuthorityRequest(ref GetClusterCertificateAuthorityRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists all Redis clusters owned by a project in either the specified
        /// location (region) or all locations.
        /// 
        /// The location should have the following format:
        /// 
        /// * `projects/{project_id}/locations/{location_id}`
        /// 
        /// If `location_id` is specified as `-` (wildcard), then all regions
        /// available to the project are queried, and the results are aggregated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Cluster"/> resources.</returns>
        public override gax::PagedEnumerable<ListClustersResponse, Cluster> ListClusters(ListClustersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListClustersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListClustersRequest, ListClustersResponse, Cluster>(_callListClusters, request, callSettings);
        }

        /// <summary>
        /// Lists all Redis clusters owned by a project in either the specified
        /// location (region) or all locations.
        /// 
        /// The location should have the following format:
        /// 
        /// * `projects/{project_id}/locations/{location_id}`
        /// 
        /// If `location_id` is specified as `-` (wildcard), then all regions
        /// available to the project are queried, and the results are aggregated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Cluster"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListClustersResponse, Cluster> ListClustersAsync(ListClustersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListClustersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListClustersRequest, ListClustersResponse, Cluster>(_callListClusters, request, callSettings);
        }

        /// <summary>
        /// Gets the details of a specific Redis cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Cluster GetCluster(GetClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetClusterRequest(ref request, ref callSettings);
            return _callGetCluster.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a specific Redis cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Cluster> GetClusterAsync(GetClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetClusterRequest(ref request, ref callSettings);
            return _callGetCluster.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateCluster</c>.</summary>
        public override lro::OperationsClient UpdateClusterOperationsClient { get; }

        /// <summary>
        /// Updates the metadata and configuration of a specific Redis cluster.
        /// 
        /// Completed longrunning.Operation will contain the new cluster object
        /// in the response field. The returned operation is automatically deleted
        /// after a few hours, so there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Cluster, wkt::Any> UpdateCluster(UpdateClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateClusterRequest(ref request, ref callSettings);
            return new lro::Operation<Cluster, wkt::Any>(_callUpdateCluster.Sync(request, callSettings), UpdateClusterOperationsClient);
        }

        /// <summary>
        /// Updates the metadata and configuration of a specific Redis cluster.
        /// 
        /// Completed longrunning.Operation will contain the new cluster object
        /// in the response field. The returned operation is automatically deleted
        /// after a few hours, so there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Cluster, wkt::Any>> UpdateClusterAsync(UpdateClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateClusterRequest(ref request, ref callSettings);
            return new lro::Operation<Cluster, wkt::Any>(await _callUpdateCluster.Async(request, callSettings).ConfigureAwait(false), UpdateClusterOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteCluster</c>.</summary>
        public override lro::OperationsClient DeleteClusterOperationsClient { get; }

        /// <summary>
        /// Deletes a specific Redis cluster. Cluster stops serving and data is
        /// deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, wkt::Any> DeleteCluster(DeleteClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteClusterRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, wkt::Any>(_callDeleteCluster.Sync(request, callSettings), DeleteClusterOperationsClient);
        }

        /// <summary>
        /// Deletes a specific Redis cluster. Cluster stops serving and data is
        /// deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, wkt::Any>> DeleteClusterAsync(DeleteClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteClusterRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, wkt::Any>(await _callDeleteCluster.Async(request, callSettings).ConfigureAwait(false), DeleteClusterOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateCluster</c>.</summary>
        public override lro::OperationsClient CreateClusterOperationsClient { get; }

        /// <summary>
        /// Creates a Redis cluster based on the specified properties.
        /// The creation is executed asynchronously and callers may check the returned
        /// operation to track its progress. Once the operation is completed the Redis
        /// cluster will be fully functional. The completed longrunning.Operation will
        /// contain the new cluster object in the response field.
        /// 
        /// The returned operation is automatically deleted after a few hours, so there
        /// is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Cluster, wkt::Any> CreateCluster(CreateClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateClusterRequest(ref request, ref callSettings);
            return new lro::Operation<Cluster, wkt::Any>(_callCreateCluster.Sync(request, callSettings), CreateClusterOperationsClient);
        }

        /// <summary>
        /// Creates a Redis cluster based on the specified properties.
        /// The creation is executed asynchronously and callers may check the returned
        /// operation to track its progress. Once the operation is completed the Redis
        /// cluster will be fully functional. The completed longrunning.Operation will
        /// contain the new cluster object in the response field.
        /// 
        /// The returned operation is automatically deleted after a few hours, so there
        /// is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Cluster, wkt::Any>> CreateClusterAsync(CreateClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateClusterRequest(ref request, ref callSettings);
            return new lro::Operation<Cluster, wkt::Any>(await _callCreateCluster.Async(request, callSettings).ConfigureAwait(false), CreateClusterOperationsClient);
        }

        /// <summary>
        /// Gets the details of certificate authority information for Redis cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CertificateAuthority GetClusterCertificateAuthority(GetClusterCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetClusterCertificateAuthorityRequest(ref request, ref callSettings);
            return _callGetClusterCertificateAuthority.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of certificate authority information for Redis cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CertificateAuthority> GetClusterCertificateAuthorityAsync(GetClusterCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetClusterCertificateAuthorityRequest(ref request, ref callSettings);
            return _callGetClusterCertificateAuthority.Async(request, callSettings);
        }
    }

    public partial class ListClustersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListClustersResponse : gaxgrpc::IPageResponse<Cluster>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Cluster> GetEnumerator() => Clusters.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class CloudRedisCluster
    {
        public partial class CloudRedisClusterClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() =>
                new lro::Operations.OperationsClient(CallInvoker);
        }
    }

    public static partial class CloudRedisCluster
    {
        public partial class CloudRedisClusterClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="gcl::Locations.LocationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gcl::Locations.LocationsClient"/> for the same target as this client.
            /// </returns>
            public virtual gcl::Locations.LocationsClient CreateLocationsClient() =>
                new gcl::Locations.LocationsClient(CallInvoker);
        }
    }
}
