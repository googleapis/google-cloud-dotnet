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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gcl = Google.Cloud.Location;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using linq = System.Linq;
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

namespace Google.Cloud.Memcache.V1Beta2
{
    /// <summary>Settings for <see cref="CloudMemcacheClient"/> instances.</summary>
    public sealed partial class CloudMemcacheSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CloudMemcacheSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CloudMemcacheSettings"/>.</returns>
        public static CloudMemcacheSettings GetDefault() => new CloudMemcacheSettings();

        /// <summary>Constructs a new <see cref="CloudMemcacheSettings"/> object with default settings.</summary>
        public CloudMemcacheSettings()
        {
        }

        private CloudMemcacheSettings(CloudMemcacheSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListInstancesSettings = existing.ListInstancesSettings;
            GetInstanceSettings = existing.GetInstanceSettings;
            CreateInstanceSettings = existing.CreateInstanceSettings;
            CreateInstanceOperationsSettings = existing.CreateInstanceOperationsSettings.Clone();
            UpdateInstanceSettings = existing.UpdateInstanceSettings;
            UpdateInstanceOperationsSettings = existing.UpdateInstanceOperationsSettings.Clone();
            UpdateParametersSettings = existing.UpdateParametersSettings;
            UpdateParametersOperationsSettings = existing.UpdateParametersOperationsSettings.Clone();
            DeleteInstanceSettings = existing.DeleteInstanceSettings;
            DeleteInstanceOperationsSettings = existing.DeleteInstanceOperationsSettings.Clone();
            ApplyParametersSettings = existing.ApplyParametersSettings;
            ApplyParametersOperationsSettings = existing.ApplyParametersOperationsSettings.Clone();
            ApplySoftwareUpdateSettings = existing.ApplySoftwareUpdateSettings;
            ApplySoftwareUpdateOperationsSettings = existing.ApplySoftwareUpdateOperationsSettings.Clone();
            RescheduleMaintenanceSettings = existing.RescheduleMaintenanceSettings;
            RescheduleMaintenanceOperationsSettings = existing.RescheduleMaintenanceOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CloudMemcacheSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudMemcacheClient.ListInstances</c> and <c>CloudMemcacheClient.ListInstancesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 1200 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListInstancesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(1200000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudMemcacheClient.GetInstance</c> and <c>CloudMemcacheClient.GetInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 1200 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(1200000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudMemcacheClient.CreateInstance</c> and <c>CloudMemcacheClient.CreateInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 1200 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(1200000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudMemcacheClient.CreateInstance</c> and
        /// <c>CloudMemcacheClient.CreateInstanceAsync</c>.
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
        public lro::OperationsSettings CreateInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudMemcacheClient.UpdateInstance</c> and <c>CloudMemcacheClient.UpdateInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 1200 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(1200000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudMemcacheClient.UpdateInstance</c> and
        /// <c>CloudMemcacheClient.UpdateInstanceAsync</c>.
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
        public lro::OperationsSettings UpdateInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudMemcacheClient.UpdateParameters</c> and <c>CloudMemcacheClient.UpdateParametersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 1200 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateParametersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(1200000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudMemcacheClient.UpdateParameters</c> and
        /// <c>CloudMemcacheClient.UpdateParametersAsync</c>.
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
        public lro::OperationsSettings UpdateParametersOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudMemcacheClient.DeleteInstance</c> and <c>CloudMemcacheClient.DeleteInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 1200 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(1200000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudMemcacheClient.DeleteInstance</c> and
        /// <c>CloudMemcacheClient.DeleteInstanceAsync</c>.
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
        public lro::OperationsSettings DeleteInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudMemcacheClient.ApplyParameters</c> and <c>CloudMemcacheClient.ApplyParametersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 1200 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ApplyParametersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(1200000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudMemcacheClient.ApplyParameters</c> and
        /// <c>CloudMemcacheClient.ApplyParametersAsync</c>.
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
        public lro::OperationsSettings ApplyParametersOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudMemcacheClient.ApplySoftwareUpdate</c> and <c>CloudMemcacheClient.ApplySoftwareUpdateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 1200 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ApplySoftwareUpdateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(1200000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudMemcacheClient.ApplySoftwareUpdate</c> and
        /// <c>CloudMemcacheClient.ApplySoftwareUpdateAsync</c>.
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
        public lro::OperationsSettings ApplySoftwareUpdateOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudMemcacheClient.RescheduleMaintenance</c> and <c>CloudMemcacheClient.RescheduleMaintenanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 1200 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RescheduleMaintenanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(1200000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudMemcacheClient.RescheduleMaintenance</c> and
        /// <c>CloudMemcacheClient.RescheduleMaintenanceAsync</c>.
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
        public lro::OperationsSettings RescheduleMaintenanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CloudMemcacheSettings"/> object.</returns>
        public CloudMemcacheSettings Clone() => new CloudMemcacheSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CloudMemcacheClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class CloudMemcacheClientBuilder : gaxgrpc::ClientBuilderBase<CloudMemcacheClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CloudMemcacheSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CloudMemcacheClientBuilder() : base(CloudMemcacheClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CloudMemcacheClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CloudMemcacheClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CloudMemcacheClient Build()
        {
            CloudMemcacheClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CloudMemcacheClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CloudMemcacheClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CloudMemcacheClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CloudMemcacheClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CloudMemcacheClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CloudMemcacheClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CloudMemcacheClient.ChannelPool;
    }

    /// <summary>CloudMemcache client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Configures and manages Cloud Memorystore for Memcached instances.
    /// 
    /// 
    /// The `memcache.googleapis.com` service implements the Google Cloud Memorystore
    /// for Memcached API and defines the following resource model for managing
    /// Memorystore Memcached (also called Memcached below) instances:
    /// * The service works with a collection of cloud projects, named: `/projects/*`
    /// * Each project has a collection of available locations, named: `/locations/*`
    /// * Each location has a collection of Memcached instances, named:
    /// `/instances/*`
    /// * As such, Memcached instances are resources of the form:
    /// `/projects/{project_id}/locations/{location_id}/instances/{instance_id}`
    /// 
    /// Note that location_id must be a GCP `region`; for example:
    /// * `projects/my-memcached-project/locations/us-central1/instances/my-memcached`
    /// </remarks>
    public abstract partial class CloudMemcacheClient
    {
        /// <summary>
        /// The default endpoint for the CloudMemcache service, which is a host of "memcache.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "memcache.googleapis.com:443";

        /// <summary>The default CloudMemcache scopes.</summary>
        /// <remarks>
        /// The default CloudMemcache scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CloudMemcache.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CloudMemcacheClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CloudMemcacheClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CloudMemcacheClient"/>.</returns>
        public static stt::Task<CloudMemcacheClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CloudMemcacheClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CloudMemcacheClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CloudMemcacheClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CloudMemcacheClient"/>.</returns>
        public static CloudMemcacheClient Create() => new CloudMemcacheClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CloudMemcacheClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CloudMemcacheSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CloudMemcacheClient"/>.</returns>
        internal static CloudMemcacheClient Create(grpccore::CallInvoker callInvoker, CloudMemcacheSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CloudMemcache.CloudMemcacheClient grpcClient = new CloudMemcache.CloudMemcacheClient(callInvoker);
            return new CloudMemcacheClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CloudMemcache client</summary>
        public virtual CloudMemcache.CloudMemcacheClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Instances in a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Instances in a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Instances in a given location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the instance location using the form:
        /// `projects/{project_id}/locations/{location_id}`
        /// where `location_id` refers to a GCP region
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
        /// <returns>A pageable sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstancesRequest request = new ListInstancesRequest
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
            return ListInstances(request, callSettings);
        }

        /// <summary>
        /// Lists Instances in a given location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the instance location using the form:
        /// `projects/{project_id}/locations/{location_id}`
        /// where `location_id` refers to a GCP region
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
        /// <returns>A pageable asynchronous sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstancesRequest request = new ListInstancesRequest
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
            return ListInstancesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Instances in a given location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the instance location using the form:
        /// `projects/{project_id}/locations/{location_id}`
        /// where `location_id` refers to a GCP region
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
        /// <returns>A pageable sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstancesRequest request = new ListInstancesRequest
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
            return ListInstances(request, callSettings);
        }

        /// <summary>
        /// Lists Instances in a given location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the instance location using the form:
        /// `projects/{project_id}/locations/{location_id}`
        /// where `location_id` refers to a GCP region
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
        /// <returns>A pageable asynchronous sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstancesRequest request = new ListInstancesRequest
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
            return ListInstancesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance GetInstance(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(GetInstanceRequest request, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. Memcached instance resource name in the format:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance GetInstance(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstance(new GetInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. Memcached instance resource name in the format:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstanceAsync(new GetInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. Memcached instance resource name in the format:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(string name, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. Memcached instance resource name in the format:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance GetInstance(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstance(new GetInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. Memcached instance resource name in the format:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstanceAsync(new GetInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. Memcached instance resource name in the format:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(InstanceName name, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Instance in a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> CreateInstance(CreateInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Instance in a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(CreateInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Instance in a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(CreateInstanceRequest request, st::CancellationToken cancellationToken) =>
            CreateInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateInstance</c>.</summary>
        public virtual lro::OperationsClient CreateInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceCreateInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceCreateInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateInstanceOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Instance in a given location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the instance location using the form:
        /// `projects/{project_id}/locations/{location_id}`
        /// where `location_id` refers to a GCP region
        /// </param>
        /// <param name="instanceId">
        /// Required. The logical name of the Memcached instance in the user
        /// project with the following restrictions:
        /// 
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-40 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the user project / location.
        /// 
        /// If any of the above are not met, the API raises an invalid argument error.
        /// </param>
        /// <param name="resource">
        /// Required. A Memcached [Instance] resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> CreateInstance(string parent, string instanceId, Instance resource, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstance(new CreateInstanceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                Resource = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Creates a new Instance in a given location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the instance location using the form:
        /// `projects/{project_id}/locations/{location_id}`
        /// where `location_id` refers to a GCP region
        /// </param>
        /// <param name="instanceId">
        /// Required. The logical name of the Memcached instance in the user
        /// project with the following restrictions:
        /// 
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-40 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the user project / location.
        /// 
        /// If any of the above are not met, the API raises an invalid argument error.
        /// </param>
        /// <param name="resource">
        /// Required. A Memcached [Instance] resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(string parent, string instanceId, Instance resource, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstanceAsync(new CreateInstanceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                Resource = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Creates a new Instance in a given location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the instance location using the form:
        /// `projects/{project_id}/locations/{location_id}`
        /// where `location_id` refers to a GCP region
        /// </param>
        /// <param name="instanceId">
        /// Required. The logical name of the Memcached instance in the user
        /// project with the following restrictions:
        /// 
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-40 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the user project / location.
        /// 
        /// If any of the above are not met, the API raises an invalid argument error.
        /// </param>
        /// <param name="resource">
        /// Required. A Memcached [Instance] resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(string parent, string instanceId, Instance resource, st::CancellationToken cancellationToken) =>
            CreateInstanceAsync(parent, instanceId, resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Instance in a given location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the instance location using the form:
        /// `projects/{project_id}/locations/{location_id}`
        /// where `location_id` refers to a GCP region
        /// </param>
        /// <param name="instanceId">
        /// Required. The logical name of the Memcached instance in the user
        /// project with the following restrictions:
        /// 
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-40 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the user project / location.
        /// 
        /// If any of the above are not met, the API raises an invalid argument error.
        /// </param>
        /// <param name="resource">
        /// Required. A Memcached [Instance] resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> CreateInstance(gagr::LocationName parent, string instanceId, Instance resource, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstance(new CreateInstanceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                Resource = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Creates a new Instance in a given location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the instance location using the form:
        /// `projects/{project_id}/locations/{location_id}`
        /// where `location_id` refers to a GCP region
        /// </param>
        /// <param name="instanceId">
        /// Required. The logical name of the Memcached instance in the user
        /// project with the following restrictions:
        /// 
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-40 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the user project / location.
        /// 
        /// If any of the above are not met, the API raises an invalid argument error.
        /// </param>
        /// <param name="resource">
        /// Required. A Memcached [Instance] resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(gagr::LocationName parent, string instanceId, Instance resource, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstanceAsync(new CreateInstanceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                Resource = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Creates a new Instance in a given location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the instance location using the form:
        /// `projects/{project_id}/locations/{location_id}`
        /// where `location_id` refers to a GCP region
        /// </param>
        /// <param name="instanceId">
        /// Required. The logical name of the Memcached instance in the user
        /// project with the following restrictions:
        /// 
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-40 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the user project / location.
        /// 
        /// If any of the above are not met, the API raises an invalid argument error.
        /// </param>
        /// <param name="resource">
        /// Required. A Memcached [Instance] resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(gagr::LocationName parent, string instanceId, Instance resource, st::CancellationToken cancellationToken) =>
            CreateInstanceAsync(parent, instanceId, resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing Instance in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> UpdateInstance(UpdateInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing Instance in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> UpdateInstanceAsync(UpdateInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing Instance in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> UpdateInstanceAsync(UpdateInstanceRequest request, st::CancellationToken cancellationToken) =>
            UpdateInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateInstance</c>.</summary>
        public virtual lro::OperationsClient UpdateInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceUpdateInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceUpdateInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateInstanceOperationsClient, callSettings);

        /// <summary>
        /// Updates an existing Instance in a given project and location.
        /// </summary>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// 
        /// *  `displayName`
        /// </param>
        /// <param name="resource">
        /// Required. A Memcached [Instance] resource.
        /// Only fields specified in update_mask are updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> UpdateInstance(wkt::FieldMask updateMask, Instance resource, gaxgrpc::CallSettings callSettings = null) =>
            UpdateInstance(new UpdateInstanceRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Resource = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Updates an existing Instance in a given project and location.
        /// </summary>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// 
        /// *  `displayName`
        /// </param>
        /// <param name="resource">
        /// Required. A Memcached [Instance] resource.
        /// Only fields specified in update_mask are updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> UpdateInstanceAsync(wkt::FieldMask updateMask, Instance resource, gaxgrpc::CallSettings callSettings = null) =>
            UpdateInstanceAsync(new UpdateInstanceRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Resource = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Updates an existing Instance in a given project and location.
        /// </summary>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// 
        /// *  `displayName`
        /// </param>
        /// <param name="resource">
        /// Required. A Memcached [Instance] resource.
        /// Only fields specified in update_mask are updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> UpdateInstanceAsync(wkt::FieldMask updateMask, Instance resource, st::CancellationToken cancellationToken) =>
            UpdateInstanceAsync(updateMask, resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the defined Memcached parameters for an existing instance.
        /// This method only stages the parameters, it must be followed by
        /// `ApplyParameters` to apply the parameters to nodes of the Memcached
        /// instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> UpdateParameters(UpdateParametersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the defined Memcached parameters for an existing instance.
        /// This method only stages the parameters, it must be followed by
        /// `ApplyParameters` to apply the parameters to nodes of the Memcached
        /// instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> UpdateParametersAsync(UpdateParametersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the defined Memcached parameters for an existing instance.
        /// This method only stages the parameters, it must be followed by
        /// `ApplyParameters` to apply the parameters to nodes of the Memcached
        /// instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> UpdateParametersAsync(UpdateParametersRequest request, st::CancellationToken cancellationToken) =>
            UpdateParametersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateParameters</c>.</summary>
        public virtual lro::OperationsClient UpdateParametersOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateParameters</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceUpdateParameters(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateParametersOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateParameters</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceUpdateParametersAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateParametersOperationsClient, callSettings);

        /// <summary>
        /// Updates the defined Memcached parameters for an existing instance.
        /// This method only stages the parameters, it must be followed by
        /// `ApplyParameters` to apply the parameters to nodes of the Memcached
        /// instance.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the Memcached instance for which the parameters should be
        /// updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="parameters">
        /// The parameters to apply to the instance.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> UpdateParameters(string name, wkt::FieldMask updateMask, MemcacheParameters parameters, gaxgrpc::CallSettings callSettings = null) =>
            UpdateParameters(new UpdateParametersRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Parameters = parameters,
            }, callSettings);

        /// <summary>
        /// Updates the defined Memcached parameters for an existing instance.
        /// This method only stages the parameters, it must be followed by
        /// `ApplyParameters` to apply the parameters to nodes of the Memcached
        /// instance.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the Memcached instance for which the parameters should be
        /// updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="parameters">
        /// The parameters to apply to the instance.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> UpdateParametersAsync(string name, wkt::FieldMask updateMask, MemcacheParameters parameters, gaxgrpc::CallSettings callSettings = null) =>
            UpdateParametersAsync(new UpdateParametersRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Parameters = parameters,
            }, callSettings);

        /// <summary>
        /// Updates the defined Memcached parameters for an existing instance.
        /// This method only stages the parameters, it must be followed by
        /// `ApplyParameters` to apply the parameters to nodes of the Memcached
        /// instance.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the Memcached instance for which the parameters should be
        /// updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="parameters">
        /// The parameters to apply to the instance.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> UpdateParametersAsync(string name, wkt::FieldMask updateMask, MemcacheParameters parameters, st::CancellationToken cancellationToken) =>
            UpdateParametersAsync(name, updateMask, parameters, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the defined Memcached parameters for an existing instance.
        /// This method only stages the parameters, it must be followed by
        /// `ApplyParameters` to apply the parameters to nodes of the Memcached
        /// instance.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the Memcached instance for which the parameters should be
        /// updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="parameters">
        /// The parameters to apply to the instance.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> UpdateParameters(InstanceName name, wkt::FieldMask updateMask, MemcacheParameters parameters, gaxgrpc::CallSettings callSettings = null) =>
            UpdateParameters(new UpdateParametersRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Parameters = parameters,
            }, callSettings);

        /// <summary>
        /// Updates the defined Memcached parameters for an existing instance.
        /// This method only stages the parameters, it must be followed by
        /// `ApplyParameters` to apply the parameters to nodes of the Memcached
        /// instance.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the Memcached instance for which the parameters should be
        /// updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="parameters">
        /// The parameters to apply to the instance.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> UpdateParametersAsync(InstanceName name, wkt::FieldMask updateMask, MemcacheParameters parameters, gaxgrpc::CallSettings callSettings = null) =>
            UpdateParametersAsync(new UpdateParametersRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Parameters = parameters,
            }, callSettings);

        /// <summary>
        /// Updates the defined Memcached parameters for an existing instance.
        /// This method only stages the parameters, it must be followed by
        /// `ApplyParameters` to apply the parameters to nodes of the Memcached
        /// instance.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the Memcached instance for which the parameters should be
        /// updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="parameters">
        /// The parameters to apply to the instance.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> UpdateParametersAsync(InstanceName name, wkt::FieldMask updateMask, MemcacheParameters parameters, st::CancellationToken cancellationToken) =>
            UpdateParametersAsync(name, updateMask, parameters, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteInstance(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(DeleteInstanceRequest request, st::CancellationToken cancellationToken) =>
            DeleteInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteInstance</c>.</summary>
        public virtual lro::OperationsClient DeleteInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteInstanceOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. Memcached instance resource name in the format:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteInstance(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstance(new DeleteInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. Memcached instance resource name in the format:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstanceAsync(new DeleteInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. Memcached instance resource name in the format:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. Memcached instance resource name in the format:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteInstance(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstance(new DeleteInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. Memcached instance resource name in the format:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstanceAsync(new DeleteInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. Memcached instance resource name in the format:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(InstanceName name, st::CancellationToken cancellationToken) =>
            DeleteInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// `ApplyParameters` restarts the set of specified nodes in order to update
        /// them to the current set of parameters for the Memcached Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> ApplyParameters(ApplyParametersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// `ApplyParameters` restarts the set of specified nodes in order to update
        /// them to the current set of parameters for the Memcached Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> ApplyParametersAsync(ApplyParametersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// `ApplyParameters` restarts the set of specified nodes in order to update
        /// them to the current set of parameters for the Memcached Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> ApplyParametersAsync(ApplyParametersRequest request, st::CancellationToken cancellationToken) =>
            ApplyParametersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ApplyParameters</c>.</summary>
        public virtual lro::OperationsClient ApplyParametersOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ApplyParameters</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceApplyParameters(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ApplyParametersOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ApplyParameters</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceApplyParametersAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ApplyParametersOperationsClient, callSettings);

        /// <summary>
        /// `ApplyParameters` restarts the set of specified nodes in order to update
        /// them to the current set of parameters for the Memcached Instance.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the Memcached instance for which parameter group updates
        /// should be applied.
        /// </param>
        /// <param name="nodeIds">
        /// Nodes to which the instance-level parameter group is applied.
        /// </param>
        /// <param name="applyAll">
        /// Whether to apply instance-level parameter group to all nodes. If set to
        /// true, users are restricted from specifying individual nodes, and
        /// `ApplyParameters` updates all nodes within the instance.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> ApplyParameters(string name, scg::IEnumerable<string> nodeIds, bool applyAll, gaxgrpc::CallSettings callSettings = null) =>
            ApplyParameters(new ApplyParametersRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                NodeIds =
                {
                    nodeIds ?? linq::Enumerable.Empty<string>(),
                },
                ApplyAll = applyAll,
            }, callSettings);

        /// <summary>
        /// `ApplyParameters` restarts the set of specified nodes in order to update
        /// them to the current set of parameters for the Memcached Instance.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the Memcached instance for which parameter group updates
        /// should be applied.
        /// </param>
        /// <param name="nodeIds">
        /// Nodes to which the instance-level parameter group is applied.
        /// </param>
        /// <param name="applyAll">
        /// Whether to apply instance-level parameter group to all nodes. If set to
        /// true, users are restricted from specifying individual nodes, and
        /// `ApplyParameters` updates all nodes within the instance.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> ApplyParametersAsync(string name, scg::IEnumerable<string> nodeIds, bool applyAll, gaxgrpc::CallSettings callSettings = null) =>
            ApplyParametersAsync(new ApplyParametersRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                NodeIds =
                {
                    nodeIds ?? linq::Enumerable.Empty<string>(),
                },
                ApplyAll = applyAll,
            }, callSettings);

        /// <summary>
        /// `ApplyParameters` restarts the set of specified nodes in order to update
        /// them to the current set of parameters for the Memcached Instance.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the Memcached instance for which parameter group updates
        /// should be applied.
        /// </param>
        /// <param name="nodeIds">
        /// Nodes to which the instance-level parameter group is applied.
        /// </param>
        /// <param name="applyAll">
        /// Whether to apply instance-level parameter group to all nodes. If set to
        /// true, users are restricted from specifying individual nodes, and
        /// `ApplyParameters` updates all nodes within the instance.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> ApplyParametersAsync(string name, scg::IEnumerable<string> nodeIds, bool applyAll, st::CancellationToken cancellationToken) =>
            ApplyParametersAsync(name, nodeIds, applyAll, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// `ApplyParameters` restarts the set of specified nodes in order to update
        /// them to the current set of parameters for the Memcached Instance.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the Memcached instance for which parameter group updates
        /// should be applied.
        /// </param>
        /// <param name="nodeIds">
        /// Nodes to which the instance-level parameter group is applied.
        /// </param>
        /// <param name="applyAll">
        /// Whether to apply instance-level parameter group to all nodes. If set to
        /// true, users are restricted from specifying individual nodes, and
        /// `ApplyParameters` updates all nodes within the instance.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> ApplyParameters(InstanceName name, scg::IEnumerable<string> nodeIds, bool applyAll, gaxgrpc::CallSettings callSettings = null) =>
            ApplyParameters(new ApplyParametersRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                NodeIds =
                {
                    nodeIds ?? linq::Enumerable.Empty<string>(),
                },
                ApplyAll = applyAll,
            }, callSettings);

        /// <summary>
        /// `ApplyParameters` restarts the set of specified nodes in order to update
        /// them to the current set of parameters for the Memcached Instance.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the Memcached instance for which parameter group updates
        /// should be applied.
        /// </param>
        /// <param name="nodeIds">
        /// Nodes to which the instance-level parameter group is applied.
        /// </param>
        /// <param name="applyAll">
        /// Whether to apply instance-level parameter group to all nodes. If set to
        /// true, users are restricted from specifying individual nodes, and
        /// `ApplyParameters` updates all nodes within the instance.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> ApplyParametersAsync(InstanceName name, scg::IEnumerable<string> nodeIds, bool applyAll, gaxgrpc::CallSettings callSettings = null) =>
            ApplyParametersAsync(new ApplyParametersRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                NodeIds =
                {
                    nodeIds ?? linq::Enumerable.Empty<string>(),
                },
                ApplyAll = applyAll,
            }, callSettings);

        /// <summary>
        /// `ApplyParameters` restarts the set of specified nodes in order to update
        /// them to the current set of parameters for the Memcached Instance.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the Memcached instance for which parameter group updates
        /// should be applied.
        /// </param>
        /// <param name="nodeIds">
        /// Nodes to which the instance-level parameter group is applied.
        /// </param>
        /// <param name="applyAll">
        /// Whether to apply instance-level parameter group to all nodes. If set to
        /// true, users are restricted from specifying individual nodes, and
        /// `ApplyParameters` updates all nodes within the instance.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> ApplyParametersAsync(InstanceName name, scg::IEnumerable<string> nodeIds, bool applyAll, st::CancellationToken cancellationToken) =>
            ApplyParametersAsync(name, nodeIds, applyAll, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates software on the selected nodes of the Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> ApplySoftwareUpdate(ApplySoftwareUpdateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates software on the selected nodes of the Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> ApplySoftwareUpdateAsync(ApplySoftwareUpdateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates software on the selected nodes of the Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> ApplySoftwareUpdateAsync(ApplySoftwareUpdateRequest request, st::CancellationToken cancellationToken) =>
            ApplySoftwareUpdateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ApplySoftwareUpdate</c>.</summary>
        public virtual lro::OperationsClient ApplySoftwareUpdateOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ApplySoftwareUpdate</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceApplySoftwareUpdate(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ApplySoftwareUpdateOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ApplySoftwareUpdate</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceApplySoftwareUpdateAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ApplySoftwareUpdateOperationsClient, callSettings);

        /// <summary>
        /// Updates software on the selected nodes of the Instance.
        /// </summary>
        /// <param name="instance">
        /// Required. Resource name of the Memcached instance for which software update should be
        /// applied.
        /// </param>
        /// <param name="nodeIds">
        /// Nodes to which we should apply the update to. Note all the selected nodes
        /// are updated in parallel.
        /// </param>
        /// <param name="applyAll">
        /// Whether to apply the update to all nodes. If set to
        /// true, will explicitly restrict users from specifying any nodes, and apply
        /// software update to all nodes (where applicable) within the instance.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> ApplySoftwareUpdate(string instance, scg::IEnumerable<string> nodeIds, bool applyAll, gaxgrpc::CallSettings callSettings = null) =>
            ApplySoftwareUpdate(new ApplySoftwareUpdateRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                NodeIds =
                {
                    nodeIds ?? linq::Enumerable.Empty<string>(),
                },
                ApplyAll = applyAll,
            }, callSettings);

        /// <summary>
        /// Updates software on the selected nodes of the Instance.
        /// </summary>
        /// <param name="instance">
        /// Required. Resource name of the Memcached instance for which software update should be
        /// applied.
        /// </param>
        /// <param name="nodeIds">
        /// Nodes to which we should apply the update to. Note all the selected nodes
        /// are updated in parallel.
        /// </param>
        /// <param name="applyAll">
        /// Whether to apply the update to all nodes. If set to
        /// true, will explicitly restrict users from specifying any nodes, and apply
        /// software update to all nodes (where applicable) within the instance.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> ApplySoftwareUpdateAsync(string instance, scg::IEnumerable<string> nodeIds, bool applyAll, gaxgrpc::CallSettings callSettings = null) =>
            ApplySoftwareUpdateAsync(new ApplySoftwareUpdateRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                NodeIds =
                {
                    nodeIds ?? linq::Enumerable.Empty<string>(),
                },
                ApplyAll = applyAll,
            }, callSettings);

        /// <summary>
        /// Updates software on the selected nodes of the Instance.
        /// </summary>
        /// <param name="instance">
        /// Required. Resource name of the Memcached instance for which software update should be
        /// applied.
        /// </param>
        /// <param name="nodeIds">
        /// Nodes to which we should apply the update to. Note all the selected nodes
        /// are updated in parallel.
        /// </param>
        /// <param name="applyAll">
        /// Whether to apply the update to all nodes. If set to
        /// true, will explicitly restrict users from specifying any nodes, and apply
        /// software update to all nodes (where applicable) within the instance.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> ApplySoftwareUpdateAsync(string instance, scg::IEnumerable<string> nodeIds, bool applyAll, st::CancellationToken cancellationToken) =>
            ApplySoftwareUpdateAsync(instance, nodeIds, applyAll, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates software on the selected nodes of the Instance.
        /// </summary>
        /// <param name="instance">
        /// Required. Resource name of the Memcached instance for which software update should be
        /// applied.
        /// </param>
        /// <param name="nodeIds">
        /// Nodes to which we should apply the update to. Note all the selected nodes
        /// are updated in parallel.
        /// </param>
        /// <param name="applyAll">
        /// Whether to apply the update to all nodes. If set to
        /// true, will explicitly restrict users from specifying any nodes, and apply
        /// software update to all nodes (where applicable) within the instance.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> ApplySoftwareUpdate(InstanceName instance, scg::IEnumerable<string> nodeIds, bool applyAll, gaxgrpc::CallSettings callSettings = null) =>
            ApplySoftwareUpdate(new ApplySoftwareUpdateRequest
            {
                InstanceAsInstanceName = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
                NodeIds =
                {
                    nodeIds ?? linq::Enumerable.Empty<string>(),
                },
                ApplyAll = applyAll,
            }, callSettings);

        /// <summary>
        /// Updates software on the selected nodes of the Instance.
        /// </summary>
        /// <param name="instance">
        /// Required. Resource name of the Memcached instance for which software update should be
        /// applied.
        /// </param>
        /// <param name="nodeIds">
        /// Nodes to which we should apply the update to. Note all the selected nodes
        /// are updated in parallel.
        /// </param>
        /// <param name="applyAll">
        /// Whether to apply the update to all nodes. If set to
        /// true, will explicitly restrict users from specifying any nodes, and apply
        /// software update to all nodes (where applicable) within the instance.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> ApplySoftwareUpdateAsync(InstanceName instance, scg::IEnumerable<string> nodeIds, bool applyAll, gaxgrpc::CallSettings callSettings = null) =>
            ApplySoftwareUpdateAsync(new ApplySoftwareUpdateRequest
            {
                InstanceAsInstanceName = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
                NodeIds =
                {
                    nodeIds ?? linq::Enumerable.Empty<string>(),
                },
                ApplyAll = applyAll,
            }, callSettings);

        /// <summary>
        /// Updates software on the selected nodes of the Instance.
        /// </summary>
        /// <param name="instance">
        /// Required. Resource name of the Memcached instance for which software update should be
        /// applied.
        /// </param>
        /// <param name="nodeIds">
        /// Nodes to which we should apply the update to. Note all the selected nodes
        /// are updated in parallel.
        /// </param>
        /// <param name="applyAll">
        /// Whether to apply the update to all nodes. If set to
        /// true, will explicitly restrict users from specifying any nodes, and apply
        /// software update to all nodes (where applicable) within the instance.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> ApplySoftwareUpdateAsync(InstanceName instance, scg::IEnumerable<string> nodeIds, bool applyAll, st::CancellationToken cancellationToken) =>
            ApplySoftwareUpdateAsync(instance, nodeIds, applyAll, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Performs the apply phase of the RescheduleMaintenance verb.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> RescheduleMaintenance(RescheduleMaintenanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Performs the apply phase of the RescheduleMaintenance verb.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> RescheduleMaintenanceAsync(RescheduleMaintenanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Performs the apply phase of the RescheduleMaintenance verb.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> RescheduleMaintenanceAsync(RescheduleMaintenanceRequest request, st::CancellationToken cancellationToken) =>
            RescheduleMaintenanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RescheduleMaintenance</c>.</summary>
        public virtual lro::OperationsClient RescheduleMaintenanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RescheduleMaintenance</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceRescheduleMaintenance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RescheduleMaintenanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RescheduleMaintenance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceRescheduleMaintenanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RescheduleMaintenanceOperationsClient, callSettings);

        /// <summary>
        /// Performs the apply phase of the RescheduleMaintenance verb.
        /// </summary>
        /// <param name="instance">
        /// Required. Memcache instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="rescheduleType">
        /// Required. If reschedule type is SPECIFIC_TIME, must set up schedule_time as well.
        /// </param>
        /// <param name="scheduleTime">
        /// Timestamp when the maintenance shall be rescheduled to if
        /// reschedule_type=SPECIFIC_TIME, in RFC 3339 format, for
        /// example `2012-11-15T16:19:00.094Z`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> RescheduleMaintenance(string instance, RescheduleMaintenanceRequest.Types.RescheduleType rescheduleType, wkt::Timestamp scheduleTime, gaxgrpc::CallSettings callSettings = null) =>
            RescheduleMaintenance(new RescheduleMaintenanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                RescheduleType = rescheduleType,
                ScheduleTime = scheduleTime,
            }, callSettings);

        /// <summary>
        /// Performs the apply phase of the RescheduleMaintenance verb.
        /// </summary>
        /// <param name="instance">
        /// Required. Memcache instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="rescheduleType">
        /// Required. If reschedule type is SPECIFIC_TIME, must set up schedule_time as well.
        /// </param>
        /// <param name="scheduleTime">
        /// Timestamp when the maintenance shall be rescheduled to if
        /// reschedule_type=SPECIFIC_TIME, in RFC 3339 format, for
        /// example `2012-11-15T16:19:00.094Z`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> RescheduleMaintenanceAsync(string instance, RescheduleMaintenanceRequest.Types.RescheduleType rescheduleType, wkt::Timestamp scheduleTime, gaxgrpc::CallSettings callSettings = null) =>
            RescheduleMaintenanceAsync(new RescheduleMaintenanceRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                RescheduleType = rescheduleType,
                ScheduleTime = scheduleTime,
            }, callSettings);

        /// <summary>
        /// Performs the apply phase of the RescheduleMaintenance verb.
        /// </summary>
        /// <param name="instance">
        /// Required. Memcache instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="rescheduleType">
        /// Required. If reschedule type is SPECIFIC_TIME, must set up schedule_time as well.
        /// </param>
        /// <param name="scheduleTime">
        /// Timestamp when the maintenance shall be rescheduled to if
        /// reschedule_type=SPECIFIC_TIME, in RFC 3339 format, for
        /// example `2012-11-15T16:19:00.094Z`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> RescheduleMaintenanceAsync(string instance, RescheduleMaintenanceRequest.Types.RescheduleType rescheduleType, wkt::Timestamp scheduleTime, st::CancellationToken cancellationToken) =>
            RescheduleMaintenanceAsync(instance, rescheduleType, scheduleTime, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Performs the apply phase of the RescheduleMaintenance verb.
        /// </summary>
        /// <param name="instance">
        /// Required. Memcache instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="rescheduleType">
        /// Required. If reschedule type is SPECIFIC_TIME, must set up schedule_time as well.
        /// </param>
        /// <param name="scheduleTime">
        /// Timestamp when the maintenance shall be rescheduled to if
        /// reschedule_type=SPECIFIC_TIME, in RFC 3339 format, for
        /// example `2012-11-15T16:19:00.094Z`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> RescheduleMaintenance(InstanceName instance, RescheduleMaintenanceRequest.Types.RescheduleType rescheduleType, wkt::Timestamp scheduleTime, gaxgrpc::CallSettings callSettings = null) =>
            RescheduleMaintenance(new RescheduleMaintenanceRequest
            {
                InstanceAsInstanceName = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
                RescheduleType = rescheduleType,
                ScheduleTime = scheduleTime,
            }, callSettings);

        /// <summary>
        /// Performs the apply phase of the RescheduleMaintenance verb.
        /// </summary>
        /// <param name="instance">
        /// Required. Memcache instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="rescheduleType">
        /// Required. If reschedule type is SPECIFIC_TIME, must set up schedule_time as well.
        /// </param>
        /// <param name="scheduleTime">
        /// Timestamp when the maintenance shall be rescheduled to if
        /// reschedule_type=SPECIFIC_TIME, in RFC 3339 format, for
        /// example `2012-11-15T16:19:00.094Z`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> RescheduleMaintenanceAsync(InstanceName instance, RescheduleMaintenanceRequest.Types.RescheduleType rescheduleType, wkt::Timestamp scheduleTime, gaxgrpc::CallSettings callSettings = null) =>
            RescheduleMaintenanceAsync(new RescheduleMaintenanceRequest
            {
                InstanceAsInstanceName = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
                RescheduleType = rescheduleType,
                ScheduleTime = scheduleTime,
            }, callSettings);

        /// <summary>
        /// Performs the apply phase of the RescheduleMaintenance verb.
        /// </summary>
        /// <param name="instance">
        /// Required. Memcache instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="rescheduleType">
        /// Required. If reschedule type is SPECIFIC_TIME, must set up schedule_time as well.
        /// </param>
        /// <param name="scheduleTime">
        /// Timestamp when the maintenance shall be rescheduled to if
        /// reschedule_type=SPECIFIC_TIME, in RFC 3339 format, for
        /// example `2012-11-15T16:19:00.094Z`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> RescheduleMaintenanceAsync(InstanceName instance, RescheduleMaintenanceRequest.Types.RescheduleType rescheduleType, wkt::Timestamp scheduleTime, st::CancellationToken cancellationToken) =>
            RescheduleMaintenanceAsync(instance, rescheduleType, scheduleTime, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CloudMemcache client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Configures and manages Cloud Memorystore for Memcached instances.
    /// 
    /// 
    /// The `memcache.googleapis.com` service implements the Google Cloud Memorystore
    /// for Memcached API and defines the following resource model for managing
    /// Memorystore Memcached (also called Memcached below) instances:
    /// * The service works with a collection of cloud projects, named: `/projects/*`
    /// * Each project has a collection of available locations, named: `/locations/*`
    /// * Each location has a collection of Memcached instances, named:
    /// `/instances/*`
    /// * As such, Memcached instances are resources of the form:
    /// `/projects/{project_id}/locations/{location_id}/instances/{instance_id}`
    /// 
    /// Note that location_id must be a GCP `region`; for example:
    /// * `projects/my-memcached-project/locations/us-central1/instances/my-memcached`
    /// </remarks>
    public sealed partial class CloudMemcacheClientImpl : CloudMemcacheClient
    {
        private readonly gaxgrpc::ApiCall<ListInstancesRequest, ListInstancesResponse> _callListInstances;

        private readonly gaxgrpc::ApiCall<GetInstanceRequest, Instance> _callGetInstance;

        private readonly gaxgrpc::ApiCall<CreateInstanceRequest, lro::Operation> _callCreateInstance;

        private readonly gaxgrpc::ApiCall<UpdateInstanceRequest, lro::Operation> _callUpdateInstance;

        private readonly gaxgrpc::ApiCall<UpdateParametersRequest, lro::Operation> _callUpdateParameters;

        private readonly gaxgrpc::ApiCall<DeleteInstanceRequest, lro::Operation> _callDeleteInstance;

        private readonly gaxgrpc::ApiCall<ApplyParametersRequest, lro::Operation> _callApplyParameters;

        private readonly gaxgrpc::ApiCall<ApplySoftwareUpdateRequest, lro::Operation> _callApplySoftwareUpdate;

        private readonly gaxgrpc::ApiCall<RescheduleMaintenanceRequest, lro::Operation> _callRescheduleMaintenance;

        /// <summary>
        /// Constructs a client wrapper for the CloudMemcache service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CloudMemcacheSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CloudMemcacheClientImpl(CloudMemcache.CloudMemcacheClient grpcClient, CloudMemcacheSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CloudMemcacheSettings effectiveSettings = settings ?? CloudMemcacheSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateInstanceOperationsSettings, logger);
            UpdateInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateInstanceOperationsSettings, logger);
            UpdateParametersOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateParametersOperationsSettings, logger);
            DeleteInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteInstanceOperationsSettings, logger);
            ApplyParametersOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ApplyParametersOperationsSettings, logger);
            ApplySoftwareUpdateOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ApplySoftwareUpdateOperationsSettings, logger);
            RescheduleMaintenanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RescheduleMaintenanceOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListInstances = clientHelper.BuildApiCall<ListInstancesRequest, ListInstancesResponse>("ListInstances", grpcClient.ListInstancesAsync, grpcClient.ListInstances, effectiveSettings.ListInstancesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListInstances);
            Modify_ListInstancesApiCall(ref _callListInstances);
            _callGetInstance = clientHelper.BuildApiCall<GetInstanceRequest, Instance>("GetInstance", grpcClient.GetInstanceAsync, grpcClient.GetInstance, effectiveSettings.GetInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetInstance);
            Modify_GetInstanceApiCall(ref _callGetInstance);
            _callCreateInstance = clientHelper.BuildApiCall<CreateInstanceRequest, lro::Operation>("CreateInstance", grpcClient.CreateInstanceAsync, grpcClient.CreateInstance, effectiveSettings.CreateInstanceSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateInstance);
            Modify_CreateInstanceApiCall(ref _callCreateInstance);
            _callUpdateInstance = clientHelper.BuildApiCall<UpdateInstanceRequest, lro::Operation>("UpdateInstance", grpcClient.UpdateInstanceAsync, grpcClient.UpdateInstance, effectiveSettings.UpdateInstanceSettings).WithGoogleRequestParam("resource.name", request => request.Resource?.Name);
            Modify_ApiCall(ref _callUpdateInstance);
            Modify_UpdateInstanceApiCall(ref _callUpdateInstance);
            _callUpdateParameters = clientHelper.BuildApiCall<UpdateParametersRequest, lro::Operation>("UpdateParameters", grpcClient.UpdateParametersAsync, grpcClient.UpdateParameters, effectiveSettings.UpdateParametersSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateParameters);
            Modify_UpdateParametersApiCall(ref _callUpdateParameters);
            _callDeleteInstance = clientHelper.BuildApiCall<DeleteInstanceRequest, lro::Operation>("DeleteInstance", grpcClient.DeleteInstanceAsync, grpcClient.DeleteInstance, effectiveSettings.DeleteInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteInstance);
            Modify_DeleteInstanceApiCall(ref _callDeleteInstance);
            _callApplyParameters = clientHelper.BuildApiCall<ApplyParametersRequest, lro::Operation>("ApplyParameters", grpcClient.ApplyParametersAsync, grpcClient.ApplyParameters, effectiveSettings.ApplyParametersSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callApplyParameters);
            Modify_ApplyParametersApiCall(ref _callApplyParameters);
            _callApplySoftwareUpdate = clientHelper.BuildApiCall<ApplySoftwareUpdateRequest, lro::Operation>("ApplySoftwareUpdate", grpcClient.ApplySoftwareUpdateAsync, grpcClient.ApplySoftwareUpdate, effectiveSettings.ApplySoftwareUpdateSettings).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callApplySoftwareUpdate);
            Modify_ApplySoftwareUpdateApiCall(ref _callApplySoftwareUpdate);
            _callRescheduleMaintenance = clientHelper.BuildApiCall<RescheduleMaintenanceRequest, lro::Operation>("RescheduleMaintenance", grpcClient.RescheduleMaintenanceAsync, grpcClient.RescheduleMaintenance, effectiveSettings.RescheduleMaintenanceSettings).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callRescheduleMaintenance);
            Modify_RescheduleMaintenanceApiCall(ref _callRescheduleMaintenance);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListInstancesApiCall(ref gaxgrpc::ApiCall<ListInstancesRequest, ListInstancesResponse> call);

        partial void Modify_GetInstanceApiCall(ref gaxgrpc::ApiCall<GetInstanceRequest, Instance> call);

        partial void Modify_CreateInstanceApiCall(ref gaxgrpc::ApiCall<CreateInstanceRequest, lro::Operation> call);

        partial void Modify_UpdateInstanceApiCall(ref gaxgrpc::ApiCall<UpdateInstanceRequest, lro::Operation> call);

        partial void Modify_UpdateParametersApiCall(ref gaxgrpc::ApiCall<UpdateParametersRequest, lro::Operation> call);

        partial void Modify_DeleteInstanceApiCall(ref gaxgrpc::ApiCall<DeleteInstanceRequest, lro::Operation> call);

        partial void Modify_ApplyParametersApiCall(ref gaxgrpc::ApiCall<ApplyParametersRequest, lro::Operation> call);

        partial void Modify_ApplySoftwareUpdateApiCall(ref gaxgrpc::ApiCall<ApplySoftwareUpdateRequest, lro::Operation> call);

        partial void Modify_RescheduleMaintenanceApiCall(ref gaxgrpc::ApiCall<RescheduleMaintenanceRequest, lro::Operation> call);

        partial void OnConstruction(CloudMemcache.CloudMemcacheClient grpcClient, CloudMemcacheSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CloudMemcache client</summary>
        public override CloudMemcache.CloudMemcacheClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListInstancesRequest(ref ListInstancesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetInstanceRequest(ref GetInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateInstanceRequest(ref CreateInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateInstanceRequest(ref UpdateInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateParametersRequest(ref UpdateParametersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteInstanceRequest(ref DeleteInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ApplyParametersRequest(ref ApplyParametersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ApplySoftwareUpdateRequest(ref ApplySoftwareUpdateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RescheduleMaintenanceRequest(ref RescheduleMaintenanceRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists Instances in a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Instance"/> resources.</returns>
        public override gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstancesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListInstancesRequest, ListInstancesResponse, Instance>(_callListInstances, request, callSettings);
        }

        /// <summary>
        /// Lists Instances in a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Instance"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstancesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListInstancesRequest, ListInstancesResponse, Instance>(_callListInstances, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Instance GetInstance(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInstanceRequest(ref request, ref callSettings);
            return _callGetInstance.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Instance> GetInstanceAsync(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInstanceRequest(ref request, ref callSettings);
            return _callGetInstance.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateInstance</c>.</summary>
        public override lro::OperationsClient CreateInstanceOperationsClient { get; }

        /// <summary>
        /// Creates a new Instance in a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> CreateInstance(CreateInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callCreateInstance.Sync(request, callSettings), CreateInstanceOperationsClient);
        }

        /// <summary>
        /// Creates a new Instance in a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(CreateInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callCreateInstance.Async(request, callSettings).ConfigureAwait(false), CreateInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateInstance</c>.</summary>
        public override lro::OperationsClient UpdateInstanceOperationsClient { get; }

        /// <summary>
        /// Updates an existing Instance in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> UpdateInstance(UpdateInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callUpdateInstance.Sync(request, callSettings), UpdateInstanceOperationsClient);
        }

        /// <summary>
        /// Updates an existing Instance in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> UpdateInstanceAsync(UpdateInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callUpdateInstance.Async(request, callSettings).ConfigureAwait(false), UpdateInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateParameters</c>.</summary>
        public override lro::OperationsClient UpdateParametersOperationsClient { get; }

        /// <summary>
        /// Updates the defined Memcached parameters for an existing instance.
        /// This method only stages the parameters, it must be followed by
        /// `ApplyParameters` to apply the parameters to nodes of the Memcached
        /// instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> UpdateParameters(UpdateParametersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateParametersRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callUpdateParameters.Sync(request, callSettings), UpdateParametersOperationsClient);
        }

        /// <summary>
        /// Updates the defined Memcached parameters for an existing instance.
        /// This method only stages the parameters, it must be followed by
        /// `ApplyParameters` to apply the parameters to nodes of the Memcached
        /// instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> UpdateParametersAsync(UpdateParametersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateParametersRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callUpdateParameters.Async(request, callSettings).ConfigureAwait(false), UpdateParametersOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteInstance</c>.</summary>
        public override lro::OperationsClient DeleteInstanceOperationsClient { get; }

        /// <summary>
        /// Deletes a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteInstance(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteInstance.Sync(request, callSettings), DeleteInstanceOperationsClient);
        }

        /// <summary>
        /// Deletes a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteInstance.Async(request, callSettings).ConfigureAwait(false), DeleteInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ApplyParameters</c>.</summary>
        public override lro::OperationsClient ApplyParametersOperationsClient { get; }

        /// <summary>
        /// `ApplyParameters` restarts the set of specified nodes in order to update
        /// them to the current set of parameters for the Memcached Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> ApplyParameters(ApplyParametersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ApplyParametersRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callApplyParameters.Sync(request, callSettings), ApplyParametersOperationsClient);
        }

        /// <summary>
        /// `ApplyParameters` restarts the set of specified nodes in order to update
        /// them to the current set of parameters for the Memcached Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> ApplyParametersAsync(ApplyParametersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ApplyParametersRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callApplyParameters.Async(request, callSettings).ConfigureAwait(false), ApplyParametersOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ApplySoftwareUpdate</c>.</summary>
        public override lro::OperationsClient ApplySoftwareUpdateOperationsClient { get; }

        /// <summary>
        /// Updates software on the selected nodes of the Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> ApplySoftwareUpdate(ApplySoftwareUpdateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ApplySoftwareUpdateRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callApplySoftwareUpdate.Sync(request, callSettings), ApplySoftwareUpdateOperationsClient);
        }

        /// <summary>
        /// Updates software on the selected nodes of the Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> ApplySoftwareUpdateAsync(ApplySoftwareUpdateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ApplySoftwareUpdateRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callApplySoftwareUpdate.Async(request, callSettings).ConfigureAwait(false), ApplySoftwareUpdateOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RescheduleMaintenance</c>.</summary>
        public override lro::OperationsClient RescheduleMaintenanceOperationsClient { get; }

        /// <summary>
        /// Performs the apply phase of the RescheduleMaintenance verb.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> RescheduleMaintenance(RescheduleMaintenanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RescheduleMaintenanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callRescheduleMaintenance.Sync(request, callSettings), RescheduleMaintenanceOperationsClient);
        }

        /// <summary>
        /// Performs the apply phase of the RescheduleMaintenance verb.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> RescheduleMaintenanceAsync(RescheduleMaintenanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RescheduleMaintenanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callRescheduleMaintenance.Async(request, callSettings).ConfigureAwait(false), RescheduleMaintenanceOperationsClient);
        }
    }

    public partial class ListInstancesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListInstancesResponse : gaxgrpc::IPageResponse<Instance>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Instance> GetEnumerator() => Resources.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class CloudMemcache
    {
        public partial class CloudMemcacheClient
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

    public static partial class CloudMemcache
    {
        public partial class CloudMemcacheClient
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
