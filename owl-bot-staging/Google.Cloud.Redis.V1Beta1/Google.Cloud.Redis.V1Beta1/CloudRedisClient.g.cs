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

namespace Google.Cloud.Redis.V1Beta1
{
    /// <summary>Settings for <see cref="CloudRedisClient"/> instances.</summary>
    public sealed partial class CloudRedisSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CloudRedisSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CloudRedisSettings"/>.</returns>
        public static CloudRedisSettings GetDefault() => new CloudRedisSettings();

        /// <summary>Constructs a new <see cref="CloudRedisSettings"/> object with default settings.</summary>
        public CloudRedisSettings()
        {
        }

        private CloudRedisSettings(CloudRedisSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListInstancesSettings = existing.ListInstancesSettings;
            GetInstanceSettings = existing.GetInstanceSettings;
            GetInstanceAuthStringSettings = existing.GetInstanceAuthStringSettings;
            CreateInstanceSettings = existing.CreateInstanceSettings;
            CreateInstanceOperationsSettings = existing.CreateInstanceOperationsSettings.Clone();
            UpdateInstanceSettings = existing.UpdateInstanceSettings;
            UpdateInstanceOperationsSettings = existing.UpdateInstanceOperationsSettings.Clone();
            UpgradeInstanceSettings = existing.UpgradeInstanceSettings;
            UpgradeInstanceOperationsSettings = existing.UpgradeInstanceOperationsSettings.Clone();
            ImportInstanceSettings = existing.ImportInstanceSettings;
            ImportInstanceOperationsSettings = existing.ImportInstanceOperationsSettings.Clone();
            ExportInstanceSettings = existing.ExportInstanceSettings;
            ExportInstanceOperationsSettings = existing.ExportInstanceOperationsSettings.Clone();
            FailoverInstanceSettings = existing.FailoverInstanceSettings;
            FailoverInstanceOperationsSettings = existing.FailoverInstanceOperationsSettings.Clone();
            DeleteInstanceSettings = existing.DeleteInstanceSettings;
            DeleteInstanceOperationsSettings = existing.DeleteInstanceOperationsSettings.Clone();
            RescheduleMaintenanceSettings = existing.RescheduleMaintenanceSettings;
            RescheduleMaintenanceOperationsSettings = existing.RescheduleMaintenanceOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(CloudRedisSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudRedisClient.ListInstances</c> and <c>CloudRedisClient.ListInstancesAsync</c>.
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
        /// <c>CloudRedisClient.GetInstance</c> and <c>CloudRedisClient.GetInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudRedisClient.GetInstanceAuthString</c> and <c>CloudRedisClient.GetInstanceAuthStringAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetInstanceAuthStringSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudRedisClient.CreateInstance</c> and <c>CloudRedisClient.CreateInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudRedisClient.CreateInstance</c> and
        /// <c>CloudRedisClient.CreateInstanceAsync</c>.
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
        /// <c>CloudRedisClient.UpdateInstance</c> and <c>CloudRedisClient.UpdateInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudRedisClient.UpdateInstance</c> and
        /// <c>CloudRedisClient.UpdateInstanceAsync</c>.
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
        /// <c>CloudRedisClient.UpgradeInstance</c> and <c>CloudRedisClient.UpgradeInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpgradeInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudRedisClient.UpgradeInstance</c> and
        /// <c>CloudRedisClient.UpgradeInstanceAsync</c>.
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
        public lro::OperationsSettings UpgradeInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudRedisClient.ImportInstance</c> and <c>CloudRedisClient.ImportInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ImportInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudRedisClient.ImportInstance</c> and
        /// <c>CloudRedisClient.ImportInstanceAsync</c>.
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
        public lro::OperationsSettings ImportInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudRedisClient.ExportInstance</c> and <c>CloudRedisClient.ExportInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExportInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudRedisClient.ExportInstance</c> and
        /// <c>CloudRedisClient.ExportInstanceAsync</c>.
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
        public lro::OperationsSettings ExportInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudRedisClient.FailoverInstance</c> and <c>CloudRedisClient.FailoverInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FailoverInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudRedisClient.FailoverInstance</c> and
        /// <c>CloudRedisClient.FailoverInstanceAsync</c>.
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
        public lro::OperationsSettings FailoverInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudRedisClient.DeleteInstance</c> and <c>CloudRedisClient.DeleteInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudRedisClient.DeleteInstance</c> and
        /// <c>CloudRedisClient.DeleteInstanceAsync</c>.
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
        /// <c>CloudRedisClient.RescheduleMaintenance</c> and <c>CloudRedisClient.RescheduleMaintenanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RescheduleMaintenanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudRedisClient.RescheduleMaintenance</c> and
        /// <c>CloudRedisClient.RescheduleMaintenanceAsync</c>.
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

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CloudRedisSettings"/> object.</returns>
        public CloudRedisSettings Clone() => new CloudRedisSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CloudRedisClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class CloudRedisClientBuilder : gaxgrpc::ClientBuilderBase<CloudRedisClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CloudRedisSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CloudRedisClientBuilder() : base(CloudRedisClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CloudRedisClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CloudRedisClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CloudRedisClient Build()
        {
            CloudRedisClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CloudRedisClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CloudRedisClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CloudRedisClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CloudRedisClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CloudRedisClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CloudRedisClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CloudRedisClient.ChannelPool;
    }

    /// <summary>CloudRedis client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Configures and manages Cloud Memorystore for Redis instances
    /// 
    /// Google Cloud Memorystore for Redis v1beta1
    /// 
    /// The `redis.googleapis.com` service implements the Google Cloud Memorystore
    /// for Redis API and defines the following resource model for managing Redis
    /// instances:
    /// * The service works with a collection of cloud projects, named: `/projects/*`
    /// * Each project has a collection of available locations, named: `/locations/*`
    /// * Each location has a collection of Redis instances, named: `/instances/*`
    /// * As such, Redis instances are resources of the form:
    /// `/projects/{project_id}/locations/{location_id}/instances/{instance_id}`
    /// 
    /// Note that location_id must be referring to a GCP `region`; for example:
    /// * `projects/redpepper-1290/locations/us-central1/instances/my-redis`
    /// </remarks>
    public abstract partial class CloudRedisClient
    {
        /// <summary>
        /// The default endpoint for the CloudRedis service, which is a host of "redis.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "redis.googleapis.com:443";

        /// <summary>The default CloudRedis scopes.</summary>
        /// <remarks>
        /// The default CloudRedis scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CloudRedis.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CloudRedisClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CloudRedisClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CloudRedisClient"/>.</returns>
        public static stt::Task<CloudRedisClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CloudRedisClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CloudRedisClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="CloudRedisClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CloudRedisClient"/>.</returns>
        public static CloudRedisClient Create() => new CloudRedisClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CloudRedisClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CloudRedisSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CloudRedisClient"/>.</returns>
        internal static CloudRedisClient Create(grpccore::CallInvoker callInvoker, CloudRedisSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CloudRedis.CloudRedisClient grpcClient = new CloudRedis.CloudRedisClient(callInvoker);
            return new CloudRedisClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CloudRedis client</summary>
        public virtual CloudRedis.CloudRedisClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all Redis instances owned by a project in either the specified
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
        /// <returns>A pageable sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all Redis instances owned by a project in either the specified
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
        /// <returns>A pageable asynchronous sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all Redis instances owned by a project in either the specified
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
        /// Required. The resource name of the instance location using the form:
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
        /// Lists all Redis instances owned by a project in either the specified
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
        /// Required. The resource name of the instance location using the form:
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
        /// Lists all Redis instances owned by a project in either the specified
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
        /// Required. The resource name of the instance location using the form:
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
        /// Lists all Redis instances owned by a project in either the specified
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
        /// Required. The resource name of the instance location using the form:
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
        /// Gets the details of a specific Redis instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance GetInstance(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a specific Redis instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a specific Redis instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(GetInstanceRequest request, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a specific Redis instance.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance GetInstance(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstance(new GetInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific Redis instance.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstanceAsync(new GetInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific Redis instance.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(string name, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a specific Redis instance.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance GetInstance(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstance(new GetInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific Redis instance.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstanceAsync(new GetInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific Redis instance.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(InstanceName name, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the AUTH string for a Redis instance. If AUTH is not enabled for the
        /// instance the response will be empty. This information is not included in
        /// the details returned to GetInstance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InstanceAuthString GetInstanceAuthString(GetInstanceAuthStringRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the AUTH string for a Redis instance. If AUTH is not enabled for the
        /// instance the response will be empty. This information is not included in
        /// the details returned to GetInstance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceAuthString> GetInstanceAuthStringAsync(GetInstanceAuthStringRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the AUTH string for a Redis instance. If AUTH is not enabled for the
        /// instance the response will be empty. This information is not included in
        /// the details returned to GetInstance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceAuthString> GetInstanceAuthStringAsync(GetInstanceAuthStringRequest request, st::CancellationToken cancellationToken) =>
            GetInstanceAuthStringAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the AUTH string for a Redis instance. If AUTH is not enabled for the
        /// instance the response will be empty. This information is not included in
        /// the details returned to GetInstance.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InstanceAuthString GetInstanceAuthString(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstanceAuthString(new GetInstanceAuthStringRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the AUTH string for a Redis instance. If AUTH is not enabled for the
        /// instance the response will be empty. This information is not included in
        /// the details returned to GetInstance.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceAuthString> GetInstanceAuthStringAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstanceAuthStringAsync(new GetInstanceAuthStringRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the AUTH string for a Redis instance. If AUTH is not enabled for the
        /// instance the response will be empty. This information is not included in
        /// the details returned to GetInstance.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceAuthString> GetInstanceAuthStringAsync(string name, st::CancellationToken cancellationToken) =>
            GetInstanceAuthStringAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the AUTH string for a Redis instance. If AUTH is not enabled for the
        /// instance the response will be empty. This information is not included in
        /// the details returned to GetInstance.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InstanceAuthString GetInstanceAuthString(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstanceAuthString(new GetInstanceAuthStringRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the AUTH string for a Redis instance. If AUTH is not enabled for the
        /// instance the response will be empty. This information is not included in
        /// the details returned to GetInstance.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceAuthString> GetInstanceAuthStringAsync(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstanceAuthStringAsync(new GetInstanceAuthStringRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the AUTH string for a Redis instance. If AUTH is not enabled for the
        /// instance the response will be empty. This information is not included in
        /// the details returned to GetInstance.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceAuthString> GetInstanceAuthStringAsync(InstanceName name, st::CancellationToken cancellationToken) =>
            GetInstanceAuthStringAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Redis instance based on the specified tier and memory size.
        /// 
        /// By default, the instance is accessible from the project's
        /// [default network](https://cloud.google.com/vpc/docs/vpc).
        /// 
        /// The creation is executed asynchronously and callers may check the returned
        /// operation to track its progress. Once the operation is completed the Redis
        /// instance will be fully functional. The completed longrunning.Operation will
        /// contain the new instance object in the response field.
        /// 
        /// The returned operation is automatically deleted after a few hours, so there
        /// is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, wkt::Any> CreateInstance(CreateInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Redis instance based on the specified tier and memory size.
        /// 
        /// By default, the instance is accessible from the project's
        /// [default network](https://cloud.google.com/vpc/docs/vpc).
        /// 
        /// The creation is executed asynchronously and callers may check the returned
        /// operation to track its progress. Once the operation is completed the Redis
        /// instance will be fully functional. The completed longrunning.Operation will
        /// contain the new instance object in the response field.
        /// 
        /// The returned operation is automatically deleted after a few hours, so there
        /// is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, wkt::Any>> CreateInstanceAsync(CreateInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Redis instance based on the specified tier and memory size.
        /// 
        /// By default, the instance is accessible from the project's
        /// [default network](https://cloud.google.com/vpc/docs/vpc).
        /// 
        /// The creation is executed asynchronously and callers may check the returned
        /// operation to track its progress. Once the operation is completed the Redis
        /// instance will be fully functional. The completed longrunning.Operation will
        /// contain the new instance object in the response field.
        /// 
        /// The returned operation is automatically deleted after a few hours, so there
        /// is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, wkt::Any>> CreateInstanceAsync(CreateInstanceRequest request, st::CancellationToken cancellationToken) =>
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
        public virtual lro::Operation<Instance, wkt::Any> PollOnceCreateInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, wkt::Any>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, wkt::Any>> PollOnceCreateInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, wkt::Any>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateInstanceOperationsClient, callSettings);

        /// <summary>
        /// Creates a Redis instance based on the specified tier and memory size.
        /// 
        /// By default, the instance is accessible from the project's
        /// [default network](https://cloud.google.com/vpc/docs/vpc).
        /// 
        /// The creation is executed asynchronously and callers may check the returned
        /// operation to track its progress. Once the operation is completed the Redis
        /// instance will be fully functional. The completed longrunning.Operation will
        /// contain the new instance object in the response field.
        /// 
        /// The returned operation is automatically deleted after a few hours, so there
        /// is no need to call DeleteOperation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the instance location using the form:
        /// `projects/{project_id}/locations/{location_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="instanceId">
        /// Required. The logical name of the Redis instance in the customer project
        /// with the following restrictions:
        /// 
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-40 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the customer project / location
        /// </param>
        /// <param name="instance">
        /// Required. A Redis [Instance] resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, wkt::Any> CreateInstance(string parent, string instanceId, Instance instance, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstance(new CreateInstanceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Creates a Redis instance based on the specified tier and memory size.
        /// 
        /// By default, the instance is accessible from the project's
        /// [default network](https://cloud.google.com/vpc/docs/vpc).
        /// 
        /// The creation is executed asynchronously and callers may check the returned
        /// operation to track its progress. Once the operation is completed the Redis
        /// instance will be fully functional. The completed longrunning.Operation will
        /// contain the new instance object in the response field.
        /// 
        /// The returned operation is automatically deleted after a few hours, so there
        /// is no need to call DeleteOperation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the instance location using the form:
        /// `projects/{project_id}/locations/{location_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="instanceId">
        /// Required. The logical name of the Redis instance in the customer project
        /// with the following restrictions:
        /// 
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-40 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the customer project / location
        /// </param>
        /// <param name="instance">
        /// Required. A Redis [Instance] resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, wkt::Any>> CreateInstanceAsync(string parent, string instanceId, Instance instance, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstanceAsync(new CreateInstanceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Creates a Redis instance based on the specified tier and memory size.
        /// 
        /// By default, the instance is accessible from the project's
        /// [default network](https://cloud.google.com/vpc/docs/vpc).
        /// 
        /// The creation is executed asynchronously and callers may check the returned
        /// operation to track its progress. Once the operation is completed the Redis
        /// instance will be fully functional. The completed longrunning.Operation will
        /// contain the new instance object in the response field.
        /// 
        /// The returned operation is automatically deleted after a few hours, so there
        /// is no need to call DeleteOperation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the instance location using the form:
        /// `projects/{project_id}/locations/{location_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="instanceId">
        /// Required. The logical name of the Redis instance in the customer project
        /// with the following restrictions:
        /// 
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-40 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the customer project / location
        /// </param>
        /// <param name="instance">
        /// Required. A Redis [Instance] resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, wkt::Any>> CreateInstanceAsync(string parent, string instanceId, Instance instance, st::CancellationToken cancellationToken) =>
            CreateInstanceAsync(parent, instanceId, instance, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Redis instance based on the specified tier and memory size.
        /// 
        /// By default, the instance is accessible from the project's
        /// [default network](https://cloud.google.com/vpc/docs/vpc).
        /// 
        /// The creation is executed asynchronously and callers may check the returned
        /// operation to track its progress. Once the operation is completed the Redis
        /// instance will be fully functional. The completed longrunning.Operation will
        /// contain the new instance object in the response field.
        /// 
        /// The returned operation is automatically deleted after a few hours, so there
        /// is no need to call DeleteOperation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the instance location using the form:
        /// `projects/{project_id}/locations/{location_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="instanceId">
        /// Required. The logical name of the Redis instance in the customer project
        /// with the following restrictions:
        /// 
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-40 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the customer project / location
        /// </param>
        /// <param name="instance">
        /// Required. A Redis [Instance] resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, wkt::Any> CreateInstance(gagr::LocationName parent, string instanceId, Instance instance, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstance(new CreateInstanceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Creates a Redis instance based on the specified tier and memory size.
        /// 
        /// By default, the instance is accessible from the project's
        /// [default network](https://cloud.google.com/vpc/docs/vpc).
        /// 
        /// The creation is executed asynchronously and callers may check the returned
        /// operation to track its progress. Once the operation is completed the Redis
        /// instance will be fully functional. The completed longrunning.Operation will
        /// contain the new instance object in the response field.
        /// 
        /// The returned operation is automatically deleted after a few hours, so there
        /// is no need to call DeleteOperation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the instance location using the form:
        /// `projects/{project_id}/locations/{location_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="instanceId">
        /// Required. The logical name of the Redis instance in the customer project
        /// with the following restrictions:
        /// 
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-40 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the customer project / location
        /// </param>
        /// <param name="instance">
        /// Required. A Redis [Instance] resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, wkt::Any>> CreateInstanceAsync(gagr::LocationName parent, string instanceId, Instance instance, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstanceAsync(new CreateInstanceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Creates a Redis instance based on the specified tier and memory size.
        /// 
        /// By default, the instance is accessible from the project's
        /// [default network](https://cloud.google.com/vpc/docs/vpc).
        /// 
        /// The creation is executed asynchronously and callers may check the returned
        /// operation to track its progress. Once the operation is completed the Redis
        /// instance will be fully functional. The completed longrunning.Operation will
        /// contain the new instance object in the response field.
        /// 
        /// The returned operation is automatically deleted after a few hours, so there
        /// is no need to call DeleteOperation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the instance location using the form:
        /// `projects/{project_id}/locations/{location_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="instanceId">
        /// Required. The logical name of the Redis instance in the customer project
        /// with the following restrictions:
        /// 
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-40 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the customer project / location
        /// </param>
        /// <param name="instance">
        /// Required. A Redis [Instance] resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, wkt::Any>> CreateInstanceAsync(gagr::LocationName parent, string instanceId, Instance instance, st::CancellationToken cancellationToken) =>
            CreateInstanceAsync(parent, instanceId, instance, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the metadata and configuration of a specific Redis instance.
        /// 
        /// Completed longrunning.Operation will contain the new instance object
        /// in the response field. The returned operation is automatically deleted
        /// after a few hours, so there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, wkt::Any> UpdateInstance(UpdateInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the metadata and configuration of a specific Redis instance.
        /// 
        /// Completed longrunning.Operation will contain the new instance object
        /// in the response field. The returned operation is automatically deleted
        /// after a few hours, so there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, wkt::Any>> UpdateInstanceAsync(UpdateInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the metadata and configuration of a specific Redis instance.
        /// 
        /// Completed longrunning.Operation will contain the new instance object
        /// in the response field. The returned operation is automatically deleted
        /// after a few hours, so there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, wkt::Any>> UpdateInstanceAsync(UpdateInstanceRequest request, st::CancellationToken cancellationToken) =>
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
        public virtual lro::Operation<Instance, wkt::Any> PollOnceUpdateInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, wkt::Any>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, wkt::Any>> PollOnceUpdateInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, wkt::Any>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateInstanceOperationsClient, callSettings);

        /// <summary>
        /// Updates the metadata and configuration of a specific Redis instance.
        /// 
        /// Completed longrunning.Operation will contain the new instance object
        /// in the response field. The returned operation is automatically deleted
        /// after a few hours, so there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field. The elements of the repeated paths field may only include these
        /// fields from [Instance][google.cloud.redis.v1beta1.Instance]:
        /// 
        /// *   `displayName`
        /// *   `labels`
        /// *   `memorySizeGb`
        /// *   `redisConfig`
        /// *   `replica_count`
        /// </param>
        /// <param name="instance">
        /// Required. Update description.
        /// Only fields specified in update_mask are updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, wkt::Any> UpdateInstance(wkt::FieldMask updateMask, Instance instance, gaxgrpc::CallSettings callSettings = null) =>
            UpdateInstance(new UpdateInstanceRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Updates the metadata and configuration of a specific Redis instance.
        /// 
        /// Completed longrunning.Operation will contain the new instance object
        /// in the response field. The returned operation is automatically deleted
        /// after a few hours, so there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field. The elements of the repeated paths field may only include these
        /// fields from [Instance][google.cloud.redis.v1beta1.Instance]:
        /// 
        /// *   `displayName`
        /// *   `labels`
        /// *   `memorySizeGb`
        /// *   `redisConfig`
        /// *   `replica_count`
        /// </param>
        /// <param name="instance">
        /// Required. Update description.
        /// Only fields specified in update_mask are updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, wkt::Any>> UpdateInstanceAsync(wkt::FieldMask updateMask, Instance instance, gaxgrpc::CallSettings callSettings = null) =>
            UpdateInstanceAsync(new UpdateInstanceRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Updates the metadata and configuration of a specific Redis instance.
        /// 
        /// Completed longrunning.Operation will contain the new instance object
        /// in the response field. The returned operation is automatically deleted
        /// after a few hours, so there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field. The elements of the repeated paths field may only include these
        /// fields from [Instance][google.cloud.redis.v1beta1.Instance]:
        /// 
        /// *   `displayName`
        /// *   `labels`
        /// *   `memorySizeGb`
        /// *   `redisConfig`
        /// *   `replica_count`
        /// </param>
        /// <param name="instance">
        /// Required. Update description.
        /// Only fields specified in update_mask are updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, wkt::Any>> UpdateInstanceAsync(wkt::FieldMask updateMask, Instance instance, st::CancellationToken cancellationToken) =>
            UpdateInstanceAsync(updateMask, instance, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Upgrades Redis instance to the newer Redis version specified in the
        /// request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, wkt::Any> UpgradeInstance(UpgradeInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Upgrades Redis instance to the newer Redis version specified in the
        /// request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, wkt::Any>> UpgradeInstanceAsync(UpgradeInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Upgrades Redis instance to the newer Redis version specified in the
        /// request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, wkt::Any>> UpgradeInstanceAsync(UpgradeInstanceRequest request, st::CancellationToken cancellationToken) =>
            UpgradeInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpgradeInstance</c>.</summary>
        public virtual lro::OperationsClient UpgradeInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpgradeInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, wkt::Any> PollOnceUpgradeInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, wkt::Any>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpgradeInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpgradeInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, wkt::Any>> PollOnceUpgradeInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, wkt::Any>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpgradeInstanceOperationsClient, callSettings);

        /// <summary>
        /// Upgrades Redis instance to the newer Redis version specified in the
        /// request.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="redisVersion">
        /// Required. Specifies the target version of Redis software to upgrade to.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, wkt::Any> UpgradeInstance(string name, string redisVersion, gaxgrpc::CallSettings callSettings = null) =>
            UpgradeInstance(new UpgradeInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                RedisVersion = gax::GaxPreconditions.CheckNotNullOrEmpty(redisVersion, nameof(redisVersion)),
            }, callSettings);

        /// <summary>
        /// Upgrades Redis instance to the newer Redis version specified in the
        /// request.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="redisVersion">
        /// Required. Specifies the target version of Redis software to upgrade to.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, wkt::Any>> UpgradeInstanceAsync(string name, string redisVersion, gaxgrpc::CallSettings callSettings = null) =>
            UpgradeInstanceAsync(new UpgradeInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                RedisVersion = gax::GaxPreconditions.CheckNotNullOrEmpty(redisVersion, nameof(redisVersion)),
            }, callSettings);

        /// <summary>
        /// Upgrades Redis instance to the newer Redis version specified in the
        /// request.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="redisVersion">
        /// Required. Specifies the target version of Redis software to upgrade to.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, wkt::Any>> UpgradeInstanceAsync(string name, string redisVersion, st::CancellationToken cancellationToken) =>
            UpgradeInstanceAsync(name, redisVersion, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Upgrades Redis instance to the newer Redis version specified in the
        /// request.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="redisVersion">
        /// Required. Specifies the target version of Redis software to upgrade to.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, wkt::Any> UpgradeInstance(InstanceName name, string redisVersion, gaxgrpc::CallSettings callSettings = null) =>
            UpgradeInstance(new UpgradeInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                RedisVersion = gax::GaxPreconditions.CheckNotNullOrEmpty(redisVersion, nameof(redisVersion)),
            }, callSettings);

        /// <summary>
        /// Upgrades Redis instance to the newer Redis version specified in the
        /// request.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="redisVersion">
        /// Required. Specifies the target version of Redis software to upgrade to.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, wkt::Any>> UpgradeInstanceAsync(InstanceName name, string redisVersion, gaxgrpc::CallSettings callSettings = null) =>
            UpgradeInstanceAsync(new UpgradeInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                RedisVersion = gax::GaxPreconditions.CheckNotNullOrEmpty(redisVersion, nameof(redisVersion)),
            }, callSettings);

        /// <summary>
        /// Upgrades Redis instance to the newer Redis version specified in the
        /// request.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="redisVersion">
        /// Required. Specifies the target version of Redis software to upgrade to.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, wkt::Any>> UpgradeInstanceAsync(InstanceName name, string redisVersion, st::CancellationToken cancellationToken) =>
            UpgradeInstanceAsync(name, redisVersion, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Import a Redis RDB snapshot file from Cloud Storage into a Redis instance.
        /// 
        /// Redis may stop serving during this operation. Instance state will be
        /// IMPORTING for entire operation. When complete, the instance will contain
        /// only data from the imported file.
        /// 
        /// The returned operation is automatically deleted after a few hours, so
        /// there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, wkt::Any> ImportInstance(ImportInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Import a Redis RDB snapshot file from Cloud Storage into a Redis instance.
        /// 
        /// Redis may stop serving during this operation. Instance state will be
        /// IMPORTING for entire operation. When complete, the instance will contain
        /// only data from the imported file.
        /// 
        /// The returned operation is automatically deleted after a few hours, so
        /// there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, wkt::Any>> ImportInstanceAsync(ImportInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Import a Redis RDB snapshot file from Cloud Storage into a Redis instance.
        /// 
        /// Redis may stop serving during this operation. Instance state will be
        /// IMPORTING for entire operation. When complete, the instance will contain
        /// only data from the imported file.
        /// 
        /// The returned operation is automatically deleted after a few hours, so
        /// there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, wkt::Any>> ImportInstanceAsync(ImportInstanceRequest request, st::CancellationToken cancellationToken) =>
            ImportInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ImportInstance</c>.</summary>
        public virtual lro::OperationsClient ImportInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ImportInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, wkt::Any> PollOnceImportInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, wkt::Any>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ImportInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, wkt::Any>> PollOnceImportInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, wkt::Any>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportInstanceOperationsClient, callSettings);

        /// <summary>
        /// Import a Redis RDB snapshot file from Cloud Storage into a Redis instance.
        /// 
        /// Redis may stop serving during this operation. Instance state will be
        /// IMPORTING for entire operation. When complete, the instance will contain
        /// only data from the imported file.
        /// 
        /// The returned operation is automatically deleted after a few hours, so
        /// there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="inputConfig">
        /// Required. Specify data to be imported.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, wkt::Any> ImportInstance(string name, InputConfig inputConfig, gaxgrpc::CallSettings callSettings = null) =>
            ImportInstance(new ImportInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                InputConfig = gax::GaxPreconditions.CheckNotNull(inputConfig, nameof(inputConfig)),
            }, callSettings);

        /// <summary>
        /// Import a Redis RDB snapshot file from Cloud Storage into a Redis instance.
        /// 
        /// Redis may stop serving during this operation. Instance state will be
        /// IMPORTING for entire operation. When complete, the instance will contain
        /// only data from the imported file.
        /// 
        /// The returned operation is automatically deleted after a few hours, so
        /// there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="inputConfig">
        /// Required. Specify data to be imported.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, wkt::Any>> ImportInstanceAsync(string name, InputConfig inputConfig, gaxgrpc::CallSettings callSettings = null) =>
            ImportInstanceAsync(new ImportInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                InputConfig = gax::GaxPreconditions.CheckNotNull(inputConfig, nameof(inputConfig)),
            }, callSettings);

        /// <summary>
        /// Import a Redis RDB snapshot file from Cloud Storage into a Redis instance.
        /// 
        /// Redis may stop serving during this operation. Instance state will be
        /// IMPORTING for entire operation. When complete, the instance will contain
        /// only data from the imported file.
        /// 
        /// The returned operation is automatically deleted after a few hours, so
        /// there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="inputConfig">
        /// Required. Specify data to be imported.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, wkt::Any>> ImportInstanceAsync(string name, InputConfig inputConfig, st::CancellationToken cancellationToken) =>
            ImportInstanceAsync(name, inputConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Export Redis instance data into a Redis RDB format file in Cloud Storage.
        /// 
        /// Redis will continue serving during this operation.
        /// 
        /// The returned operation is automatically deleted after a few hours, so
        /// there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, wkt::Any> ExportInstance(ExportInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Export Redis instance data into a Redis RDB format file in Cloud Storage.
        /// 
        /// Redis will continue serving during this operation.
        /// 
        /// The returned operation is automatically deleted after a few hours, so
        /// there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, wkt::Any>> ExportInstanceAsync(ExportInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Export Redis instance data into a Redis RDB format file in Cloud Storage.
        /// 
        /// Redis will continue serving during this operation.
        /// 
        /// The returned operation is automatically deleted after a few hours, so
        /// there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, wkt::Any>> ExportInstanceAsync(ExportInstanceRequest request, st::CancellationToken cancellationToken) =>
            ExportInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ExportInstance</c>.</summary>
        public virtual lro::OperationsClient ExportInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ExportInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, wkt::Any> PollOnceExportInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, wkt::Any>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, wkt::Any>> PollOnceExportInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, wkt::Any>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportInstanceOperationsClient, callSettings);

        /// <summary>
        /// Export Redis instance data into a Redis RDB format file in Cloud Storage.
        /// 
        /// Redis will continue serving during this operation.
        /// 
        /// The returned operation is automatically deleted after a few hours, so
        /// there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="outputConfig">
        /// Required. Specify data to be exported.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, wkt::Any> ExportInstance(string name, OutputConfig outputConfig, gaxgrpc::CallSettings callSettings = null) =>
            ExportInstance(new ExportInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                OutputConfig = gax::GaxPreconditions.CheckNotNull(outputConfig, nameof(outputConfig)),
            }, callSettings);

        /// <summary>
        /// Export Redis instance data into a Redis RDB format file in Cloud Storage.
        /// 
        /// Redis will continue serving during this operation.
        /// 
        /// The returned operation is automatically deleted after a few hours, so
        /// there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="outputConfig">
        /// Required. Specify data to be exported.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, wkt::Any>> ExportInstanceAsync(string name, OutputConfig outputConfig, gaxgrpc::CallSettings callSettings = null) =>
            ExportInstanceAsync(new ExportInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                OutputConfig = gax::GaxPreconditions.CheckNotNull(outputConfig, nameof(outputConfig)),
            }, callSettings);

        /// <summary>
        /// Export Redis instance data into a Redis RDB format file in Cloud Storage.
        /// 
        /// Redis will continue serving during this operation.
        /// 
        /// The returned operation is automatically deleted after a few hours, so
        /// there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="outputConfig">
        /// Required. Specify data to be exported.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, wkt::Any>> ExportInstanceAsync(string name, OutputConfig outputConfig, st::CancellationToken cancellationToken) =>
            ExportInstanceAsync(name, outputConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Initiates a failover of the primary node to current replica node for a
        /// specific STANDARD tier Cloud Memorystore for Redis instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, wkt::Any> FailoverInstance(FailoverInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Initiates a failover of the primary node to current replica node for a
        /// specific STANDARD tier Cloud Memorystore for Redis instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, wkt::Any>> FailoverInstanceAsync(FailoverInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Initiates a failover of the primary node to current replica node for a
        /// specific STANDARD tier Cloud Memorystore for Redis instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, wkt::Any>> FailoverInstanceAsync(FailoverInstanceRequest request, st::CancellationToken cancellationToken) =>
            FailoverInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>FailoverInstance</c>.</summary>
        public virtual lro::OperationsClient FailoverInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>FailoverInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, wkt::Any> PollOnceFailoverInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, wkt::Any>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), FailoverInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>FailoverInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, wkt::Any>> PollOnceFailoverInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, wkt::Any>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), FailoverInstanceOperationsClient, callSettings);

        /// <summary>
        /// Initiates a failover of the primary node to current replica node for a
        /// specific STANDARD tier Cloud Memorystore for Redis instance.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="dataProtectionMode">
        /// Optional. Available data protection modes that the user can choose. If it's
        /// unspecified, data protection mode will be LIMITED_DATA_LOSS by default.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, wkt::Any> FailoverInstance(string name, FailoverInstanceRequest.Types.DataProtectionMode dataProtectionMode, gaxgrpc::CallSettings callSettings = null) =>
            FailoverInstance(new FailoverInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                DataProtectionMode = dataProtectionMode,
            }, callSettings);

        /// <summary>
        /// Initiates a failover of the primary node to current replica node for a
        /// specific STANDARD tier Cloud Memorystore for Redis instance.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="dataProtectionMode">
        /// Optional. Available data protection modes that the user can choose. If it's
        /// unspecified, data protection mode will be LIMITED_DATA_LOSS by default.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, wkt::Any>> FailoverInstanceAsync(string name, FailoverInstanceRequest.Types.DataProtectionMode dataProtectionMode, gaxgrpc::CallSettings callSettings = null) =>
            FailoverInstanceAsync(new FailoverInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                DataProtectionMode = dataProtectionMode,
            }, callSettings);

        /// <summary>
        /// Initiates a failover of the primary node to current replica node for a
        /// specific STANDARD tier Cloud Memorystore for Redis instance.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="dataProtectionMode">
        /// Optional. Available data protection modes that the user can choose. If it's
        /// unspecified, data protection mode will be LIMITED_DATA_LOSS by default.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, wkt::Any>> FailoverInstanceAsync(string name, FailoverInstanceRequest.Types.DataProtectionMode dataProtectionMode, st::CancellationToken cancellationToken) =>
            FailoverInstanceAsync(name, dataProtectionMode, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Initiates a failover of the primary node to current replica node for a
        /// specific STANDARD tier Cloud Memorystore for Redis instance.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="dataProtectionMode">
        /// Optional. Available data protection modes that the user can choose. If it's
        /// unspecified, data protection mode will be LIMITED_DATA_LOSS by default.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, wkt::Any> FailoverInstance(InstanceName name, FailoverInstanceRequest.Types.DataProtectionMode dataProtectionMode, gaxgrpc::CallSettings callSettings = null) =>
            FailoverInstance(new FailoverInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                DataProtectionMode = dataProtectionMode,
            }, callSettings);

        /// <summary>
        /// Initiates a failover of the primary node to current replica node for a
        /// specific STANDARD tier Cloud Memorystore for Redis instance.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="dataProtectionMode">
        /// Optional. Available data protection modes that the user can choose. If it's
        /// unspecified, data protection mode will be LIMITED_DATA_LOSS by default.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, wkt::Any>> FailoverInstanceAsync(InstanceName name, FailoverInstanceRequest.Types.DataProtectionMode dataProtectionMode, gaxgrpc::CallSettings callSettings = null) =>
            FailoverInstanceAsync(new FailoverInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                DataProtectionMode = dataProtectionMode,
            }, callSettings);

        /// <summary>
        /// Initiates a failover of the primary node to current replica node for a
        /// specific STANDARD tier Cloud Memorystore for Redis instance.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="dataProtectionMode">
        /// Optional. Available data protection modes that the user can choose. If it's
        /// unspecified, data protection mode will be LIMITED_DATA_LOSS by default.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, wkt::Any>> FailoverInstanceAsync(InstanceName name, FailoverInstanceRequest.Types.DataProtectionMode dataProtectionMode, st::CancellationToken cancellationToken) =>
            FailoverInstanceAsync(name, dataProtectionMode, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a specific Redis instance.  Instance stops serving and data is
        /// deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Any> DeleteInstance(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a specific Redis instance.  Instance stops serving and data is
        /// deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Any>> DeleteInstanceAsync(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a specific Redis instance.  Instance stops serving and data is
        /// deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Any>> DeleteInstanceAsync(DeleteInstanceRequest request, st::CancellationToken cancellationToken) =>
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
        public virtual lro::Operation<wkt::Empty, wkt::Any> PollOnceDeleteInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, wkt::Any>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Any>> PollOnceDeleteInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, wkt::Any>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteInstanceOperationsClient, callSettings);

        /// <summary>
        /// Deletes a specific Redis instance.  Instance stops serving and data is
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Any> DeleteInstance(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstance(new DeleteInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific Redis instance.  Instance stops serving and data is
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Any>> DeleteInstanceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstanceAsync(new DeleteInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific Redis instance.  Instance stops serving and data is
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Any>> DeleteInstanceAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a specific Redis instance.  Instance stops serving and data is
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Any> DeleteInstance(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstance(new DeleteInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific Redis instance.  Instance stops serving and data is
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Any>> DeleteInstanceAsync(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstanceAsync(new DeleteInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific Redis instance.  Instance stops serving and data is
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Any>> DeleteInstanceAsync(InstanceName name, st::CancellationToken cancellationToken) =>
            DeleteInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reschedule maintenance for a given instance in a given project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, wkt::Any> RescheduleMaintenance(RescheduleMaintenanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reschedule maintenance for a given instance in a given project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, wkt::Any>> RescheduleMaintenanceAsync(RescheduleMaintenanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reschedule maintenance for a given instance in a given project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, wkt::Any>> RescheduleMaintenanceAsync(RescheduleMaintenanceRequest request, st::CancellationToken cancellationToken) =>
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
        public virtual lro::Operation<Instance, wkt::Any> PollOnceRescheduleMaintenance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, wkt::Any>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RescheduleMaintenanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RescheduleMaintenance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, wkt::Any>> PollOnceRescheduleMaintenanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, wkt::Any>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RescheduleMaintenanceOperationsClient, callSettings);

        /// <summary>
        /// Reschedule maintenance for a given instance in a given project and
        /// location.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="rescheduleType">
        /// Required. If reschedule type is SPECIFIC_TIME, must set up schedule_time as well.
        /// </param>
        /// <param name="scheduleTime">
        /// Optional. Timestamp when the maintenance shall be rescheduled to if
        /// reschedule_type=SPECIFIC_TIME, in RFC 3339 format, for
        /// example `2012-11-15T16:19:00.094Z`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, wkt::Any> RescheduleMaintenance(string name, RescheduleMaintenanceRequest.Types.RescheduleType rescheduleType, wkt::Timestamp scheduleTime, gaxgrpc::CallSettings callSettings = null) =>
            RescheduleMaintenance(new RescheduleMaintenanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                RescheduleType = rescheduleType,
                ScheduleTime = scheduleTime,
            }, callSettings);

        /// <summary>
        /// Reschedule maintenance for a given instance in a given project and
        /// location.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="rescheduleType">
        /// Required. If reschedule type is SPECIFIC_TIME, must set up schedule_time as well.
        /// </param>
        /// <param name="scheduleTime">
        /// Optional. Timestamp when the maintenance shall be rescheduled to if
        /// reschedule_type=SPECIFIC_TIME, in RFC 3339 format, for
        /// example `2012-11-15T16:19:00.094Z`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, wkt::Any>> RescheduleMaintenanceAsync(string name, RescheduleMaintenanceRequest.Types.RescheduleType rescheduleType, wkt::Timestamp scheduleTime, gaxgrpc::CallSettings callSettings = null) =>
            RescheduleMaintenanceAsync(new RescheduleMaintenanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                RescheduleType = rescheduleType,
                ScheduleTime = scheduleTime,
            }, callSettings);

        /// <summary>
        /// Reschedule maintenance for a given instance in a given project and
        /// location.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="rescheduleType">
        /// Required. If reschedule type is SPECIFIC_TIME, must set up schedule_time as well.
        /// </param>
        /// <param name="scheduleTime">
        /// Optional. Timestamp when the maintenance shall be rescheduled to if
        /// reschedule_type=SPECIFIC_TIME, in RFC 3339 format, for
        /// example `2012-11-15T16:19:00.094Z`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, wkt::Any>> RescheduleMaintenanceAsync(string name, RescheduleMaintenanceRequest.Types.RescheduleType rescheduleType, wkt::Timestamp scheduleTime, st::CancellationToken cancellationToken) =>
            RescheduleMaintenanceAsync(name, rescheduleType, scheduleTime, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reschedule maintenance for a given instance in a given project and
        /// location.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="rescheduleType">
        /// Required. If reschedule type is SPECIFIC_TIME, must set up schedule_time as well.
        /// </param>
        /// <param name="scheduleTime">
        /// Optional. Timestamp when the maintenance shall be rescheduled to if
        /// reschedule_type=SPECIFIC_TIME, in RFC 3339 format, for
        /// example `2012-11-15T16:19:00.094Z`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, wkt::Any> RescheduleMaintenance(InstanceName name, RescheduleMaintenanceRequest.Types.RescheduleType rescheduleType, wkt::Timestamp scheduleTime, gaxgrpc::CallSettings callSettings = null) =>
            RescheduleMaintenance(new RescheduleMaintenanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                RescheduleType = rescheduleType,
                ScheduleTime = scheduleTime,
            }, callSettings);

        /// <summary>
        /// Reschedule maintenance for a given instance in a given project and
        /// location.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="rescheduleType">
        /// Required. If reschedule type is SPECIFIC_TIME, must set up schedule_time as well.
        /// </param>
        /// <param name="scheduleTime">
        /// Optional. Timestamp when the maintenance shall be rescheduled to if
        /// reschedule_type=SPECIFIC_TIME, in RFC 3339 format, for
        /// example `2012-11-15T16:19:00.094Z`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, wkt::Any>> RescheduleMaintenanceAsync(InstanceName name, RescheduleMaintenanceRequest.Types.RescheduleType rescheduleType, wkt::Timestamp scheduleTime, gaxgrpc::CallSettings callSettings = null) =>
            RescheduleMaintenanceAsync(new RescheduleMaintenanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                RescheduleType = rescheduleType,
                ScheduleTime = scheduleTime,
            }, callSettings);

        /// <summary>
        /// Reschedule maintenance for a given instance in a given project and
        /// location.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="rescheduleType">
        /// Required. If reschedule type is SPECIFIC_TIME, must set up schedule_time as well.
        /// </param>
        /// <param name="scheduleTime">
        /// Optional. Timestamp when the maintenance shall be rescheduled to if
        /// reschedule_type=SPECIFIC_TIME, in RFC 3339 format, for
        /// example `2012-11-15T16:19:00.094Z`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, wkt::Any>> RescheduleMaintenanceAsync(InstanceName name, RescheduleMaintenanceRequest.Types.RescheduleType rescheduleType, wkt::Timestamp scheduleTime, st::CancellationToken cancellationToken) =>
            RescheduleMaintenanceAsync(name, rescheduleType, scheduleTime, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CloudRedis client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Configures and manages Cloud Memorystore for Redis instances
    /// 
    /// Google Cloud Memorystore for Redis v1beta1
    /// 
    /// The `redis.googleapis.com` service implements the Google Cloud Memorystore
    /// for Redis API and defines the following resource model for managing Redis
    /// instances:
    /// * The service works with a collection of cloud projects, named: `/projects/*`
    /// * Each project has a collection of available locations, named: `/locations/*`
    /// * Each location has a collection of Redis instances, named: `/instances/*`
    /// * As such, Redis instances are resources of the form:
    /// `/projects/{project_id}/locations/{location_id}/instances/{instance_id}`
    /// 
    /// Note that location_id must be referring to a GCP `region`; for example:
    /// * `projects/redpepper-1290/locations/us-central1/instances/my-redis`
    /// </remarks>
    public sealed partial class CloudRedisClientImpl : CloudRedisClient
    {
        private readonly gaxgrpc::ApiCall<ListInstancesRequest, ListInstancesResponse> _callListInstances;

        private readonly gaxgrpc::ApiCall<GetInstanceRequest, Instance> _callGetInstance;

        private readonly gaxgrpc::ApiCall<GetInstanceAuthStringRequest, InstanceAuthString> _callGetInstanceAuthString;

        private readonly gaxgrpc::ApiCall<CreateInstanceRequest, lro::Operation> _callCreateInstance;

        private readonly gaxgrpc::ApiCall<UpdateInstanceRequest, lro::Operation> _callUpdateInstance;

        private readonly gaxgrpc::ApiCall<UpgradeInstanceRequest, lro::Operation> _callUpgradeInstance;

        private readonly gaxgrpc::ApiCall<ImportInstanceRequest, lro::Operation> _callImportInstance;

        private readonly gaxgrpc::ApiCall<ExportInstanceRequest, lro::Operation> _callExportInstance;

        private readonly gaxgrpc::ApiCall<FailoverInstanceRequest, lro::Operation> _callFailoverInstance;

        private readonly gaxgrpc::ApiCall<DeleteInstanceRequest, lro::Operation> _callDeleteInstance;

        private readonly gaxgrpc::ApiCall<RescheduleMaintenanceRequest, lro::Operation> _callRescheduleMaintenance;

        /// <summary>
        /// Constructs a client wrapper for the CloudRedis service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CloudRedisSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CloudRedisClientImpl(CloudRedis.CloudRedisClient grpcClient, CloudRedisSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CloudRedisSettings effectiveSettings = settings ?? CloudRedisSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateInstanceOperationsSettings, logger);
            UpdateInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateInstanceOperationsSettings, logger);
            UpgradeInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpgradeInstanceOperationsSettings, logger);
            ImportInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ImportInstanceOperationsSettings, logger);
            ExportInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ExportInstanceOperationsSettings, logger);
            FailoverInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.FailoverInstanceOperationsSettings, logger);
            DeleteInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteInstanceOperationsSettings, logger);
            RescheduleMaintenanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RescheduleMaintenanceOperationsSettings, logger);
            _callListInstances = clientHelper.BuildApiCall<ListInstancesRequest, ListInstancesResponse>("ListInstances", grpcClient.ListInstancesAsync, grpcClient.ListInstances, effectiveSettings.ListInstancesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListInstances);
            Modify_ListInstancesApiCall(ref _callListInstances);
            _callGetInstance = clientHelper.BuildApiCall<GetInstanceRequest, Instance>("GetInstance", grpcClient.GetInstanceAsync, grpcClient.GetInstance, effectiveSettings.GetInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetInstance);
            Modify_GetInstanceApiCall(ref _callGetInstance);
            _callGetInstanceAuthString = clientHelper.BuildApiCall<GetInstanceAuthStringRequest, InstanceAuthString>("GetInstanceAuthString", grpcClient.GetInstanceAuthStringAsync, grpcClient.GetInstanceAuthString, effectiveSettings.GetInstanceAuthStringSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetInstanceAuthString);
            Modify_GetInstanceAuthStringApiCall(ref _callGetInstanceAuthString);
            _callCreateInstance = clientHelper.BuildApiCall<CreateInstanceRequest, lro::Operation>("CreateInstance", grpcClient.CreateInstanceAsync, grpcClient.CreateInstance, effectiveSettings.CreateInstanceSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateInstance);
            Modify_CreateInstanceApiCall(ref _callCreateInstance);
            _callUpdateInstance = clientHelper.BuildApiCall<UpdateInstanceRequest, lro::Operation>("UpdateInstance", grpcClient.UpdateInstanceAsync, grpcClient.UpdateInstance, effectiveSettings.UpdateInstanceSettings).WithGoogleRequestParam("instance.name", request => request.Instance?.Name);
            Modify_ApiCall(ref _callUpdateInstance);
            Modify_UpdateInstanceApiCall(ref _callUpdateInstance);
            _callUpgradeInstance = clientHelper.BuildApiCall<UpgradeInstanceRequest, lro::Operation>("UpgradeInstance", grpcClient.UpgradeInstanceAsync, grpcClient.UpgradeInstance, effectiveSettings.UpgradeInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpgradeInstance);
            Modify_UpgradeInstanceApiCall(ref _callUpgradeInstance);
            _callImportInstance = clientHelper.BuildApiCall<ImportInstanceRequest, lro::Operation>("ImportInstance", grpcClient.ImportInstanceAsync, grpcClient.ImportInstance, effectiveSettings.ImportInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callImportInstance);
            Modify_ImportInstanceApiCall(ref _callImportInstance);
            _callExportInstance = clientHelper.BuildApiCall<ExportInstanceRequest, lro::Operation>("ExportInstance", grpcClient.ExportInstanceAsync, grpcClient.ExportInstance, effectiveSettings.ExportInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callExportInstance);
            Modify_ExportInstanceApiCall(ref _callExportInstance);
            _callFailoverInstance = clientHelper.BuildApiCall<FailoverInstanceRequest, lro::Operation>("FailoverInstance", grpcClient.FailoverInstanceAsync, grpcClient.FailoverInstance, effectiveSettings.FailoverInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callFailoverInstance);
            Modify_FailoverInstanceApiCall(ref _callFailoverInstance);
            _callDeleteInstance = clientHelper.BuildApiCall<DeleteInstanceRequest, lro::Operation>("DeleteInstance", grpcClient.DeleteInstanceAsync, grpcClient.DeleteInstance, effectiveSettings.DeleteInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteInstance);
            Modify_DeleteInstanceApiCall(ref _callDeleteInstance);
            _callRescheduleMaintenance = clientHelper.BuildApiCall<RescheduleMaintenanceRequest, lro::Operation>("RescheduleMaintenance", grpcClient.RescheduleMaintenanceAsync, grpcClient.RescheduleMaintenance, effectiveSettings.RescheduleMaintenanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRescheduleMaintenance);
            Modify_RescheduleMaintenanceApiCall(ref _callRescheduleMaintenance);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListInstancesApiCall(ref gaxgrpc::ApiCall<ListInstancesRequest, ListInstancesResponse> call);

        partial void Modify_GetInstanceApiCall(ref gaxgrpc::ApiCall<GetInstanceRequest, Instance> call);

        partial void Modify_GetInstanceAuthStringApiCall(ref gaxgrpc::ApiCall<GetInstanceAuthStringRequest, InstanceAuthString> call);

        partial void Modify_CreateInstanceApiCall(ref gaxgrpc::ApiCall<CreateInstanceRequest, lro::Operation> call);

        partial void Modify_UpdateInstanceApiCall(ref gaxgrpc::ApiCall<UpdateInstanceRequest, lro::Operation> call);

        partial void Modify_UpgradeInstanceApiCall(ref gaxgrpc::ApiCall<UpgradeInstanceRequest, lro::Operation> call);

        partial void Modify_ImportInstanceApiCall(ref gaxgrpc::ApiCall<ImportInstanceRequest, lro::Operation> call);

        partial void Modify_ExportInstanceApiCall(ref gaxgrpc::ApiCall<ExportInstanceRequest, lro::Operation> call);

        partial void Modify_FailoverInstanceApiCall(ref gaxgrpc::ApiCall<FailoverInstanceRequest, lro::Operation> call);

        partial void Modify_DeleteInstanceApiCall(ref gaxgrpc::ApiCall<DeleteInstanceRequest, lro::Operation> call);

        partial void Modify_RescheduleMaintenanceApiCall(ref gaxgrpc::ApiCall<RescheduleMaintenanceRequest, lro::Operation> call);

        partial void OnConstruction(CloudRedis.CloudRedisClient grpcClient, CloudRedisSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CloudRedis client</summary>
        public override CloudRedis.CloudRedisClient GrpcClient { get; }

        partial void Modify_ListInstancesRequest(ref ListInstancesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetInstanceRequest(ref GetInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetInstanceAuthStringRequest(ref GetInstanceAuthStringRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateInstanceRequest(ref CreateInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateInstanceRequest(ref UpdateInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpgradeInstanceRequest(ref UpgradeInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportInstanceRequest(ref ImportInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportInstanceRequest(ref ExportInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FailoverInstanceRequest(ref FailoverInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteInstanceRequest(ref DeleteInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RescheduleMaintenanceRequest(ref RescheduleMaintenanceRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists all Redis instances owned by a project in either the specified
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
        /// <returns>A pageable sequence of <see cref="Instance"/> resources.</returns>
        public override gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstancesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListInstancesRequest, ListInstancesResponse, Instance>(_callListInstances, request, callSettings);
        }

        /// <summary>
        /// Lists all Redis instances owned by a project in either the specified
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
        /// <returns>A pageable asynchronous sequence of <see cref="Instance"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstancesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListInstancesRequest, ListInstancesResponse, Instance>(_callListInstances, request, callSettings);
        }

        /// <summary>
        /// Gets the details of a specific Redis instance.
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
        /// Gets the details of a specific Redis instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Instance> GetInstanceAsync(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInstanceRequest(ref request, ref callSettings);
            return _callGetInstance.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the AUTH string for a Redis instance. If AUTH is not enabled for the
        /// instance the response will be empty. This information is not included in
        /// the details returned to GetInstance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override InstanceAuthString GetInstanceAuthString(GetInstanceAuthStringRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInstanceAuthStringRequest(ref request, ref callSettings);
            return _callGetInstanceAuthString.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the AUTH string for a Redis instance. If AUTH is not enabled for the
        /// instance the response will be empty. This information is not included in
        /// the details returned to GetInstance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<InstanceAuthString> GetInstanceAuthStringAsync(GetInstanceAuthStringRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInstanceAuthStringRequest(ref request, ref callSettings);
            return _callGetInstanceAuthString.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateInstance</c>.</summary>
        public override lro::OperationsClient CreateInstanceOperationsClient { get; }

        /// <summary>
        /// Creates a Redis instance based on the specified tier and memory size.
        /// 
        /// By default, the instance is accessible from the project's
        /// [default network](https://cloud.google.com/vpc/docs/vpc).
        /// 
        /// The creation is executed asynchronously and callers may check the returned
        /// operation to track its progress. Once the operation is completed the Redis
        /// instance will be fully functional. The completed longrunning.Operation will
        /// contain the new instance object in the response field.
        /// 
        /// The returned operation is automatically deleted after a few hours, so there
        /// is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, wkt::Any> CreateInstance(CreateInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, wkt::Any>(_callCreateInstance.Sync(request, callSettings), CreateInstanceOperationsClient);
        }

        /// <summary>
        /// Creates a Redis instance based on the specified tier and memory size.
        /// 
        /// By default, the instance is accessible from the project's
        /// [default network](https://cloud.google.com/vpc/docs/vpc).
        /// 
        /// The creation is executed asynchronously and callers may check the returned
        /// operation to track its progress. Once the operation is completed the Redis
        /// instance will be fully functional. The completed longrunning.Operation will
        /// contain the new instance object in the response field.
        /// 
        /// The returned operation is automatically deleted after a few hours, so there
        /// is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, wkt::Any>> CreateInstanceAsync(CreateInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, wkt::Any>(await _callCreateInstance.Async(request, callSettings).ConfigureAwait(false), CreateInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateInstance</c>.</summary>
        public override lro::OperationsClient UpdateInstanceOperationsClient { get; }

        /// <summary>
        /// Updates the metadata and configuration of a specific Redis instance.
        /// 
        /// Completed longrunning.Operation will contain the new instance object
        /// in the response field. The returned operation is automatically deleted
        /// after a few hours, so there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, wkt::Any> UpdateInstance(UpdateInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, wkt::Any>(_callUpdateInstance.Sync(request, callSettings), UpdateInstanceOperationsClient);
        }

        /// <summary>
        /// Updates the metadata and configuration of a specific Redis instance.
        /// 
        /// Completed longrunning.Operation will contain the new instance object
        /// in the response field. The returned operation is automatically deleted
        /// after a few hours, so there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, wkt::Any>> UpdateInstanceAsync(UpdateInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, wkt::Any>(await _callUpdateInstance.Async(request, callSettings).ConfigureAwait(false), UpdateInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpgradeInstance</c>.</summary>
        public override lro::OperationsClient UpgradeInstanceOperationsClient { get; }

        /// <summary>
        /// Upgrades Redis instance to the newer Redis version specified in the
        /// request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, wkt::Any> UpgradeInstance(UpgradeInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpgradeInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, wkt::Any>(_callUpgradeInstance.Sync(request, callSettings), UpgradeInstanceOperationsClient);
        }

        /// <summary>
        /// Upgrades Redis instance to the newer Redis version specified in the
        /// request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, wkt::Any>> UpgradeInstanceAsync(UpgradeInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpgradeInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, wkt::Any>(await _callUpgradeInstance.Async(request, callSettings).ConfigureAwait(false), UpgradeInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ImportInstance</c>.</summary>
        public override lro::OperationsClient ImportInstanceOperationsClient { get; }

        /// <summary>
        /// Import a Redis RDB snapshot file from Cloud Storage into a Redis instance.
        /// 
        /// Redis may stop serving during this operation. Instance state will be
        /// IMPORTING for entire operation. When complete, the instance will contain
        /// only data from the imported file.
        /// 
        /// The returned operation is automatically deleted after a few hours, so
        /// there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, wkt::Any> ImportInstance(ImportInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, wkt::Any>(_callImportInstance.Sync(request, callSettings), ImportInstanceOperationsClient);
        }

        /// <summary>
        /// Import a Redis RDB snapshot file from Cloud Storage into a Redis instance.
        /// 
        /// Redis may stop serving during this operation. Instance state will be
        /// IMPORTING for entire operation. When complete, the instance will contain
        /// only data from the imported file.
        /// 
        /// The returned operation is automatically deleted after a few hours, so
        /// there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, wkt::Any>> ImportInstanceAsync(ImportInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, wkt::Any>(await _callImportInstance.Async(request, callSettings).ConfigureAwait(false), ImportInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ExportInstance</c>.</summary>
        public override lro::OperationsClient ExportInstanceOperationsClient { get; }

        /// <summary>
        /// Export Redis instance data into a Redis RDB format file in Cloud Storage.
        /// 
        /// Redis will continue serving during this operation.
        /// 
        /// The returned operation is automatically deleted after a few hours, so
        /// there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, wkt::Any> ExportInstance(ExportInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, wkt::Any>(_callExportInstance.Sync(request, callSettings), ExportInstanceOperationsClient);
        }

        /// <summary>
        /// Export Redis instance data into a Redis RDB format file in Cloud Storage.
        /// 
        /// Redis will continue serving during this operation.
        /// 
        /// The returned operation is automatically deleted after a few hours, so
        /// there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, wkt::Any>> ExportInstanceAsync(ExportInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, wkt::Any>(await _callExportInstance.Async(request, callSettings).ConfigureAwait(false), ExportInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>FailoverInstance</c>.</summary>
        public override lro::OperationsClient FailoverInstanceOperationsClient { get; }

        /// <summary>
        /// Initiates a failover of the primary node to current replica node for a
        /// specific STANDARD tier Cloud Memorystore for Redis instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, wkt::Any> FailoverInstance(FailoverInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FailoverInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, wkt::Any>(_callFailoverInstance.Sync(request, callSettings), FailoverInstanceOperationsClient);
        }

        /// <summary>
        /// Initiates a failover of the primary node to current replica node for a
        /// specific STANDARD tier Cloud Memorystore for Redis instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, wkt::Any>> FailoverInstanceAsync(FailoverInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FailoverInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, wkt::Any>(await _callFailoverInstance.Async(request, callSettings).ConfigureAwait(false), FailoverInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteInstance</c>.</summary>
        public override lro::OperationsClient DeleteInstanceOperationsClient { get; }

        /// <summary>
        /// Deletes a specific Redis instance.  Instance stops serving and data is
        /// deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, wkt::Any> DeleteInstance(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, wkt::Any>(_callDeleteInstance.Sync(request, callSettings), DeleteInstanceOperationsClient);
        }

        /// <summary>
        /// Deletes a specific Redis instance.  Instance stops serving and data is
        /// deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, wkt::Any>> DeleteInstanceAsync(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, wkt::Any>(await _callDeleteInstance.Async(request, callSettings).ConfigureAwait(false), DeleteInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RescheduleMaintenance</c>.</summary>
        public override lro::OperationsClient RescheduleMaintenanceOperationsClient { get; }

        /// <summary>
        /// Reschedule maintenance for a given instance in a given project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, wkt::Any> RescheduleMaintenance(RescheduleMaintenanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RescheduleMaintenanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, wkt::Any>(_callRescheduleMaintenance.Sync(request, callSettings), RescheduleMaintenanceOperationsClient);
        }

        /// <summary>
        /// Reschedule maintenance for a given instance in a given project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, wkt::Any>> RescheduleMaintenanceAsync(RescheduleMaintenanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RescheduleMaintenanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, wkt::Any>(await _callRescheduleMaintenance.Async(request, callSettings).ConfigureAwait(false), RescheduleMaintenanceOperationsClient);
        }
    }

    public partial class ListInstancesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListInstancesResponse : gaxgrpc::IPageResponse<Instance>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Instance> GetEnumerator() => Instances.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class CloudRedis
    {
        public partial class CloudRedisClient
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
}
