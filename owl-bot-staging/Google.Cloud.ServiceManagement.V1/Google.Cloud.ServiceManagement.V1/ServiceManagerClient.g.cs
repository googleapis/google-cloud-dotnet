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
using ga = Google.Api;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gciv = Google.Cloud.Iam.V1;
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

namespace Google.Cloud.ServiceManagement.V1
{
    /// <summary>Settings for <see cref="ServiceManagerClient"/> instances.</summary>
    public sealed partial class ServiceManagerSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ServiceManagerSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ServiceManagerSettings"/>.</returns>
        public static ServiceManagerSettings GetDefault() => new ServiceManagerSettings();

        /// <summary>Constructs a new <see cref="ServiceManagerSettings"/> object with default settings.</summary>
        public ServiceManagerSettings()
        {
        }

        private ServiceManagerSettings(ServiceManagerSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListServicesSettings = existing.ListServicesSettings;
            GetServiceSettings = existing.GetServiceSettings;
            CreateServiceSettings = existing.CreateServiceSettings;
            CreateServiceOperationsSettings = existing.CreateServiceOperationsSettings.Clone();
            DeleteServiceSettings = existing.DeleteServiceSettings;
            DeleteServiceOperationsSettings = existing.DeleteServiceOperationsSettings.Clone();
            UndeleteServiceSettings = existing.UndeleteServiceSettings;
            UndeleteServiceOperationsSettings = existing.UndeleteServiceOperationsSettings.Clone();
            ListServiceConfigsSettings = existing.ListServiceConfigsSettings;
            GetServiceConfigSettings = existing.GetServiceConfigSettings;
            CreateServiceConfigSettings = existing.CreateServiceConfigSettings;
            SubmitConfigSourceSettings = existing.SubmitConfigSourceSettings;
            SubmitConfigSourceOperationsSettings = existing.SubmitConfigSourceOperationsSettings.Clone();
            ListServiceRolloutsSettings = existing.ListServiceRolloutsSettings;
            GetServiceRolloutSettings = existing.GetServiceRolloutSettings;
            CreateServiceRolloutSettings = existing.CreateServiceRolloutSettings;
            CreateServiceRolloutOperationsSettings = existing.CreateServiceRolloutOperationsSettings.Clone();
            GenerateConfigReportSettings = existing.GenerateConfigReportSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(ServiceManagerSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceManagerClient.ListServices</c> and <c>ServiceManagerClient.ListServicesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListServicesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceManagerClient.GetService</c> and <c>ServiceManagerClient.GetServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetServiceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceManagerClient.CreateService</c> and <c>ServiceManagerClient.CreateServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateServiceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ServiceManagerClient.CreateService</c> and
        /// <c>ServiceManagerClient.CreateServiceAsync</c>.
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
        public lro::OperationsSettings CreateServiceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceManagerClient.DeleteService</c> and <c>ServiceManagerClient.DeleteServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteServiceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ServiceManagerClient.DeleteService</c> and
        /// <c>ServiceManagerClient.DeleteServiceAsync</c>.
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
        public lro::OperationsSettings DeleteServiceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceManagerClient.UndeleteService</c> and <c>ServiceManagerClient.UndeleteServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UndeleteServiceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ServiceManagerClient.UndeleteService</c> and
        /// <c>ServiceManagerClient.UndeleteServiceAsync</c>.
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
        public lro::OperationsSettings UndeleteServiceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceManagerClient.ListServiceConfigs</c> and <c>ServiceManagerClient.ListServiceConfigsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListServiceConfigsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceManagerClient.GetServiceConfig</c> and <c>ServiceManagerClient.GetServiceConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetServiceConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceManagerClient.CreateServiceConfig</c> and <c>ServiceManagerClient.CreateServiceConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateServiceConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceManagerClient.SubmitConfigSource</c> and <c>ServiceManagerClient.SubmitConfigSourceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SubmitConfigSourceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ServiceManagerClient.SubmitConfigSource</c> and
        /// <c>ServiceManagerClient.SubmitConfigSourceAsync</c>.
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
        public lro::OperationsSettings SubmitConfigSourceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceManagerClient.ListServiceRollouts</c> and <c>ServiceManagerClient.ListServiceRolloutsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListServiceRolloutsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceManagerClient.GetServiceRollout</c> and <c>ServiceManagerClient.GetServiceRolloutAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetServiceRolloutSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceManagerClient.CreateServiceRollout</c> and <c>ServiceManagerClient.CreateServiceRolloutAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateServiceRolloutSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ServiceManagerClient.CreateServiceRollout</c> and
        /// <c>ServiceManagerClient.CreateServiceRolloutAsync</c>.
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
        public lro::OperationsSettings CreateServiceRolloutOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceManagerClient.GenerateConfigReport</c> and <c>ServiceManagerClient.GenerateConfigReportAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GenerateConfigReportSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ServiceManagerSettings"/> object.</returns>
        public ServiceManagerSettings Clone() => new ServiceManagerSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ServiceManagerClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class ServiceManagerClientBuilder : gaxgrpc::ClientBuilderBase<ServiceManagerClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ServiceManagerSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ServiceManagerClientBuilder() : base(ServiceManagerClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ServiceManagerClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ServiceManagerClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ServiceManagerClient Build()
        {
            ServiceManagerClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ServiceManagerClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ServiceManagerClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ServiceManagerClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ServiceManagerClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ServiceManagerClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ServiceManagerClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ServiceManagerClient.ChannelPool;
    }

    /// <summary>ServiceManager client wrapper, for convenient use.</summary>
    /// <remarks>
    /// [Google Service Management
    /// API](https://cloud.google.com/service-infrastructure/docs/overview)
    /// </remarks>
    public abstract partial class ServiceManagerClient
    {
        /// <summary>
        /// The default endpoint for the ServiceManager service, which is a host of "servicemanagement.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "servicemanagement.googleapis.com:443";

        /// <summary>The default ServiceManager scopes.</summary>
        /// <remarks>
        /// The default ServiceManager scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform.read-only</description></item>
        /// <item><description>https://www.googleapis.com/auth/service.management</description></item>
        /// <item><description>https://www.googleapis.com/auth/service.management.readonly</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
            "https://www.googleapis.com/auth/service.management",
            "https://www.googleapis.com/auth/service.management.readonly",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ServiceManager.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ServiceManagerClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ServiceManagerClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ServiceManagerClient"/>.</returns>
        public static stt::Task<ServiceManagerClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ServiceManagerClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ServiceManagerClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ServiceManagerClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ServiceManagerClient"/>.</returns>
        public static ServiceManagerClient Create() => new ServiceManagerClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ServiceManagerClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ServiceManagerSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ServiceManagerClient"/>.</returns>
        internal static ServiceManagerClient Create(grpccore::CallInvoker callInvoker, ServiceManagerSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ServiceManager.ServiceManagerClient grpcClient = new ServiceManager.ServiceManagerClient(callInvoker);
            return new ServiceManagerClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ServiceManager client</summary>
        public virtual ServiceManager.ServiceManagerClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists managed services.
        /// 
        /// Returns all public services. For authenticated users, also returns all
        /// services the calling user has "servicemanagement.services.get" permission
        /// for.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ManagedService"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServicesResponse, ManagedService> ListServices(ListServicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists managed services.
        /// 
        /// Returns all public services. For authenticated users, also returns all
        /// services the calling user has "servicemanagement.services.get" permission
        /// for.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ManagedService"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServicesResponse, ManagedService> ListServicesAsync(ListServicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists managed services.
        /// 
        /// Returns all public services. For authenticated users, also returns all
        /// services the calling user has "servicemanagement.services.get" permission
        /// for.
        /// </summary>
        /// <param name="producerProjectId">
        /// Include services produced by the specified project.
        /// </param>
        /// <param name="consumerId">
        /// Include services consumed by the specified consumer.
        /// 
        /// The Google Service Management implementation accepts the following
        /// forms:
        /// - project:&lt;project_id&gt;
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
        /// <returns>A pageable sequence of <see cref="ManagedService"/> resources.</returns>
        [sys::ObsoleteAttribute]
        public virtual gax::PagedEnumerable<ListServicesResponse, ManagedService> ListServices(string producerProjectId, string consumerId, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServicesRequest request = new ListServicesRequest
            {
                ProducerProjectId = producerProjectId ?? "",
                ConsumerId = consumerId ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListServices(request, callSettings);
        }

        /// <summary>
        /// Lists managed services.
        /// 
        /// Returns all public services. For authenticated users, also returns all
        /// services the calling user has "servicemanagement.services.get" permission
        /// for.
        /// </summary>
        /// <param name="producerProjectId">
        /// Include services produced by the specified project.
        /// </param>
        /// <param name="consumerId">
        /// Include services consumed by the specified consumer.
        /// 
        /// The Google Service Management implementation accepts the following
        /// forms:
        /// - project:&lt;project_id&gt;
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
        /// <returns>A pageable asynchronous sequence of <see cref="ManagedService"/> resources.</returns>
        [sys::ObsoleteAttribute]
        public virtual gax::PagedAsyncEnumerable<ListServicesResponse, ManagedService> ListServicesAsync(string producerProjectId, string consumerId, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServicesRequest request = new ListServicesRequest
            {
                ProducerProjectId = producerProjectId ?? "",
                ConsumerId = consumerId ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListServicesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a managed service. Authentication is required unless the service is
        /// public.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ManagedService GetService(GetServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a managed service. Authentication is required unless the service is
        /// public.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManagedService> GetServiceAsync(GetServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a managed service. Authentication is required unless the service is
        /// public.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManagedService> GetServiceAsync(GetServiceRequest request, st::CancellationToken cancellationToken) =>
            GetServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a managed service. Authentication is required unless the service is
        /// public.
        /// </summary>
        /// <param name="serviceName">
        /// Required. The name of the service.  See the `ServiceManager` overview for
        /// naming requirements.  For example: `example.googleapis.com`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ManagedService GetService(string serviceName, gaxgrpc::CallSettings callSettings = null) =>
            GetService(new GetServiceRequest
            {
                ServiceName = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceName, nameof(serviceName)),
            }, callSettings);

        /// <summary>
        /// Gets a managed service. Authentication is required unless the service is
        /// public.
        /// </summary>
        /// <param name="serviceName">
        /// Required. The name of the service.  See the `ServiceManager` overview for
        /// naming requirements.  For example: `example.googleapis.com`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManagedService> GetServiceAsync(string serviceName, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceAsync(new GetServiceRequest
            {
                ServiceName = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceName, nameof(serviceName)),
            }, callSettings);

        /// <summary>
        /// Gets a managed service. Authentication is required unless the service is
        /// public.
        /// </summary>
        /// <param name="serviceName">
        /// Required. The name of the service.  See the `ServiceManager` overview for
        /// naming requirements.  For example: `example.googleapis.com`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManagedService> GetServiceAsync(string serviceName, st::CancellationToken cancellationToken) =>
            GetServiceAsync(serviceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new managed service.
        /// 
        /// A managed service is immutable, and is subject to mandatory 30-day
        /// data retention. You cannot move a service or recreate it within 30 days
        /// after deletion.
        /// 
        /// One producer project can own no more than 500 services. For security and
        /// reliability purposes, a production service should be hosted in a
        /// dedicated producer project.
        /// 
        /// Operation&lt;response: ManagedService&gt;
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ManagedService, OperationMetadata> CreateService(CreateServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new managed service.
        /// 
        /// A managed service is immutable, and is subject to mandatory 30-day
        /// data retention. You cannot move a service or recreate it within 30 days
        /// after deletion.
        /// 
        /// One producer project can own no more than 500 services. For security and
        /// reliability purposes, a production service should be hosted in a
        /// dedicated producer project.
        /// 
        /// Operation&lt;response: ManagedService&gt;
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ManagedService, OperationMetadata>> CreateServiceAsync(CreateServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new managed service.
        /// 
        /// A managed service is immutable, and is subject to mandatory 30-day
        /// data retention. You cannot move a service or recreate it within 30 days
        /// after deletion.
        /// 
        /// One producer project can own no more than 500 services. For security and
        /// reliability purposes, a production service should be hosted in a
        /// dedicated producer project.
        /// 
        /// Operation&lt;response: ManagedService&gt;
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ManagedService, OperationMetadata>> CreateServiceAsync(CreateServiceRequest request, st::CancellationToken cancellationToken) =>
            CreateServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateService</c>.</summary>
        public virtual lro::OperationsClient CreateServiceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateService</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ManagedService, OperationMetadata> PollOnceCreateService(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ManagedService, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateServiceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateService</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ManagedService, OperationMetadata>> PollOnceCreateServiceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ManagedService, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateServiceOperationsClient, callSettings);

        /// <summary>
        /// Creates a new managed service.
        /// 
        /// A managed service is immutable, and is subject to mandatory 30-day
        /// data retention. You cannot move a service or recreate it within 30 days
        /// after deletion.
        /// 
        /// One producer project can own no more than 500 services. For security and
        /// reliability purposes, a production service should be hosted in a
        /// dedicated producer project.
        /// 
        /// Operation&lt;response: ManagedService&gt;
        /// </summary>
        /// <param name="service">
        /// Required. Initial values for the service resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ManagedService, OperationMetadata> CreateService(ManagedService service, gaxgrpc::CallSettings callSettings = null) =>
            CreateService(new CreateServiceRequest
            {
                Service = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
            }, callSettings);

        /// <summary>
        /// Creates a new managed service.
        /// 
        /// A managed service is immutable, and is subject to mandatory 30-day
        /// data retention. You cannot move a service or recreate it within 30 days
        /// after deletion.
        /// 
        /// One producer project can own no more than 500 services. For security and
        /// reliability purposes, a production service should be hosted in a
        /// dedicated producer project.
        /// 
        /// Operation&lt;response: ManagedService&gt;
        /// </summary>
        /// <param name="service">
        /// Required. Initial values for the service resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ManagedService, OperationMetadata>> CreateServiceAsync(ManagedService service, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceAsync(new CreateServiceRequest
            {
                Service = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
            }, callSettings);

        /// <summary>
        /// Creates a new managed service.
        /// 
        /// A managed service is immutable, and is subject to mandatory 30-day
        /// data retention. You cannot move a service or recreate it within 30 days
        /// after deletion.
        /// 
        /// One producer project can own no more than 500 services. For security and
        /// reliability purposes, a production service should be hosted in a
        /// dedicated producer project.
        /// 
        /// Operation&lt;response: ManagedService&gt;
        /// </summary>
        /// <param name="service">
        /// Required. Initial values for the service resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ManagedService, OperationMetadata>> CreateServiceAsync(ManagedService service, st::CancellationToken cancellationToken) =>
            CreateServiceAsync(service, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a managed service. This method will change the service to the
        /// `Soft-Delete` state for 30 days. Within this period, service producers may
        /// call
        /// [UndeleteService][google.api.servicemanagement.v1.ServiceManager.UndeleteService]
        /// to restore the service. After 30 days, the service will be permanently
        /// deleted.
        /// 
        /// Operation&lt;response: google.protobuf.Empty&gt;
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteService(DeleteServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a managed service. This method will change the service to the
        /// `Soft-Delete` state for 30 days. Within this period, service producers may
        /// call
        /// [UndeleteService][google.api.servicemanagement.v1.ServiceManager.UndeleteService]
        /// to restore the service. After 30 days, the service will be permanently
        /// deleted.
        /// 
        /// Operation&lt;response: google.protobuf.Empty&gt;
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceAsync(DeleteServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a managed service. This method will change the service to the
        /// `Soft-Delete` state for 30 days. Within this period, service producers may
        /// call
        /// [UndeleteService][google.api.servicemanagement.v1.ServiceManager.UndeleteService]
        /// to restore the service. After 30 days, the service will be permanently
        /// deleted.
        /// 
        /// Operation&lt;response: google.protobuf.Empty&gt;
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceAsync(DeleteServiceRequest request, st::CancellationToken cancellationToken) =>
            DeleteServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteService</c>.</summary>
        public virtual lro::OperationsClient DeleteServiceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteService</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteService(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteServiceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteService</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteServiceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteServiceOperationsClient, callSettings);

        /// <summary>
        /// Deletes a managed service. This method will change the service to the
        /// `Soft-Delete` state for 30 days. Within this period, service producers may
        /// call
        /// [UndeleteService][google.api.servicemanagement.v1.ServiceManager.UndeleteService]
        /// to restore the service. After 30 days, the service will be permanently
        /// deleted.
        /// 
        /// Operation&lt;response: google.protobuf.Empty&gt;
        /// </summary>
        /// <param name="serviceName">
        /// Required. The name of the service.  See the
        /// [overview](https://cloud.google.com/service-management/overview) for naming
        /// requirements.  For example: `example.googleapis.com`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteService(string serviceName, gaxgrpc::CallSettings callSettings = null) =>
            DeleteService(new DeleteServiceRequest
            {
                ServiceName = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceName, nameof(serviceName)),
            }, callSettings);

        /// <summary>
        /// Deletes a managed service. This method will change the service to the
        /// `Soft-Delete` state for 30 days. Within this period, service producers may
        /// call
        /// [UndeleteService][google.api.servicemanagement.v1.ServiceManager.UndeleteService]
        /// to restore the service. After 30 days, the service will be permanently
        /// deleted.
        /// 
        /// Operation&lt;response: google.protobuf.Empty&gt;
        /// </summary>
        /// <param name="serviceName">
        /// Required. The name of the service.  See the
        /// [overview](https://cloud.google.com/service-management/overview) for naming
        /// requirements.  For example: `example.googleapis.com`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceAsync(string serviceName, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceAsync(new DeleteServiceRequest
            {
                ServiceName = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceName, nameof(serviceName)),
            }, callSettings);

        /// <summary>
        /// Deletes a managed service. This method will change the service to the
        /// `Soft-Delete` state for 30 days. Within this period, service producers may
        /// call
        /// [UndeleteService][google.api.servicemanagement.v1.ServiceManager.UndeleteService]
        /// to restore the service. After 30 days, the service will be permanently
        /// deleted.
        /// 
        /// Operation&lt;response: google.protobuf.Empty&gt;
        /// </summary>
        /// <param name="serviceName">
        /// Required. The name of the service.  See the
        /// [overview](https://cloud.google.com/service-management/overview) for naming
        /// requirements.  For example: `example.googleapis.com`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceAsync(string serviceName, st::CancellationToken cancellationToken) =>
            DeleteServiceAsync(serviceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Revives a previously deleted managed service. The method restores the
        /// service using the configuration at the time the service was deleted.
        /// The target service must exist and must have been deleted within the
        /// last 30 days.
        /// 
        /// Operation&lt;response: UndeleteServiceResponse&gt;
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UndeleteServiceResponse, OperationMetadata> UndeleteService(UndeleteServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Revives a previously deleted managed service. The method restores the
        /// service using the configuration at the time the service was deleted.
        /// The target service must exist and must have been deleted within the
        /// last 30 days.
        /// 
        /// Operation&lt;response: UndeleteServiceResponse&gt;
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UndeleteServiceResponse, OperationMetadata>> UndeleteServiceAsync(UndeleteServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Revives a previously deleted managed service. The method restores the
        /// service using the configuration at the time the service was deleted.
        /// The target service must exist and must have been deleted within the
        /// last 30 days.
        /// 
        /// Operation&lt;response: UndeleteServiceResponse&gt;
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UndeleteServiceResponse, OperationMetadata>> UndeleteServiceAsync(UndeleteServiceRequest request, st::CancellationToken cancellationToken) =>
            UndeleteServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UndeleteService</c>.</summary>
        public virtual lro::OperationsClient UndeleteServiceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UndeleteService</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<UndeleteServiceResponse, OperationMetadata> PollOnceUndeleteService(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<UndeleteServiceResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UndeleteServiceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UndeleteService</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<UndeleteServiceResponse, OperationMetadata>> PollOnceUndeleteServiceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<UndeleteServiceResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UndeleteServiceOperationsClient, callSettings);

        /// <summary>
        /// Revives a previously deleted managed service. The method restores the
        /// service using the configuration at the time the service was deleted.
        /// The target service must exist and must have been deleted within the
        /// last 30 days.
        /// 
        /// Operation&lt;response: UndeleteServiceResponse&gt;
        /// </summary>
        /// <param name="serviceName">
        /// Required. The name of the service. See the
        /// [overview](https://cloud.google.com/service-management/overview) for naming
        /// requirements. For example: `example.googleapis.com`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UndeleteServiceResponse, OperationMetadata> UndeleteService(string serviceName, gaxgrpc::CallSettings callSettings = null) =>
            UndeleteService(new UndeleteServiceRequest
            {
                ServiceName = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceName, nameof(serviceName)),
            }, callSettings);

        /// <summary>
        /// Revives a previously deleted managed service. The method restores the
        /// service using the configuration at the time the service was deleted.
        /// The target service must exist and must have been deleted within the
        /// last 30 days.
        /// 
        /// Operation&lt;response: UndeleteServiceResponse&gt;
        /// </summary>
        /// <param name="serviceName">
        /// Required. The name of the service. See the
        /// [overview](https://cloud.google.com/service-management/overview) for naming
        /// requirements. For example: `example.googleapis.com`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UndeleteServiceResponse, OperationMetadata>> UndeleteServiceAsync(string serviceName, gaxgrpc::CallSettings callSettings = null) =>
            UndeleteServiceAsync(new UndeleteServiceRequest
            {
                ServiceName = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceName, nameof(serviceName)),
            }, callSettings);

        /// <summary>
        /// Revives a previously deleted managed service. The method restores the
        /// service using the configuration at the time the service was deleted.
        /// The target service must exist and must have been deleted within the
        /// last 30 days.
        /// 
        /// Operation&lt;response: UndeleteServiceResponse&gt;
        /// </summary>
        /// <param name="serviceName">
        /// Required. The name of the service. See the
        /// [overview](https://cloud.google.com/service-management/overview) for naming
        /// requirements. For example: `example.googleapis.com`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UndeleteServiceResponse, OperationMetadata>> UndeleteServiceAsync(string serviceName, st::CancellationToken cancellationToken) =>
            UndeleteServiceAsync(serviceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the history of the service configuration for a managed service,
        /// from the newest to the oldest.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ga::Service"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServiceConfigsResponse, ga::Service> ListServiceConfigs(ListServiceConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the history of the service configuration for a managed service,
        /// from the newest to the oldest.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ga::Service"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServiceConfigsResponse, ga::Service> ListServiceConfigsAsync(ListServiceConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the history of the service configuration for a managed service,
        /// from the newest to the oldest.
        /// </summary>
        /// <param name="serviceName">
        /// Required. The name of the service.  See the
        /// [overview](https://cloud.google.com/service-management/overview) for naming
        /// requirements.  For example: `example.googleapis.com`.
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
        /// <returns>A pageable sequence of <see cref="ga::Service"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServiceConfigsResponse, ga::Service> ListServiceConfigs(string serviceName, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServiceConfigsRequest request = new ListServiceConfigsRequest
            {
                ServiceName = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceName, nameof(serviceName)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListServiceConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists the history of the service configuration for a managed service,
        /// from the newest to the oldest.
        /// </summary>
        /// <param name="serviceName">
        /// Required. The name of the service.  See the
        /// [overview](https://cloud.google.com/service-management/overview) for naming
        /// requirements.  For example: `example.googleapis.com`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ga::Service"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServiceConfigsResponse, ga::Service> ListServiceConfigsAsync(string serviceName, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServiceConfigsRequest request = new ListServiceConfigsRequest
            {
                ServiceName = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceName, nameof(serviceName)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListServiceConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a service configuration (version) for a managed service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ga::Service GetServiceConfig(GetServiceConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a service configuration (version) for a managed service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::Service> GetServiceConfigAsync(GetServiceConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a service configuration (version) for a managed service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::Service> GetServiceConfigAsync(GetServiceConfigRequest request, st::CancellationToken cancellationToken) =>
            GetServiceConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a service configuration (version) for a managed service.
        /// </summary>
        /// <param name="serviceName">
        /// Required. The name of the service.  See the
        /// [overview](https://cloud.google.com/service-management/overview) for naming
        /// requirements.  For example: `example.googleapis.com`.
        /// </param>
        /// <param name="configId">
        /// Required. The id of the service configuration resource.
        /// 
        /// This field must be specified for the server to return all fields, including
        /// `SourceInfo`.
        /// </param>
        /// <param name="view">
        /// Specifies which parts of the Service Config should be returned in the
        /// response.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ga::Service GetServiceConfig(string serviceName, string configId, GetServiceConfigRequest.Types.ConfigView view, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceConfig(new GetServiceConfigRequest
            {
                ServiceName = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceName, nameof(serviceName)),
                ConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(configId, nameof(configId)),
                View = view,
            }, callSettings);

        /// <summary>
        /// Gets a service configuration (version) for a managed service.
        /// </summary>
        /// <param name="serviceName">
        /// Required. The name of the service.  See the
        /// [overview](https://cloud.google.com/service-management/overview) for naming
        /// requirements.  For example: `example.googleapis.com`.
        /// </param>
        /// <param name="configId">
        /// Required. The id of the service configuration resource.
        /// 
        /// This field must be specified for the server to return all fields, including
        /// `SourceInfo`.
        /// </param>
        /// <param name="view">
        /// Specifies which parts of the Service Config should be returned in the
        /// response.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::Service> GetServiceConfigAsync(string serviceName, string configId, GetServiceConfigRequest.Types.ConfigView view, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceConfigAsync(new GetServiceConfigRequest
            {
                ServiceName = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceName, nameof(serviceName)),
                ConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(configId, nameof(configId)),
                View = view,
            }, callSettings);

        /// <summary>
        /// Gets a service configuration (version) for a managed service.
        /// </summary>
        /// <param name="serviceName">
        /// Required. The name of the service.  See the
        /// [overview](https://cloud.google.com/service-management/overview) for naming
        /// requirements.  For example: `example.googleapis.com`.
        /// </param>
        /// <param name="configId">
        /// Required. The id of the service configuration resource.
        /// 
        /// This field must be specified for the server to return all fields, including
        /// `SourceInfo`.
        /// </param>
        /// <param name="view">
        /// Specifies which parts of the Service Config should be returned in the
        /// response.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::Service> GetServiceConfigAsync(string serviceName, string configId, GetServiceConfigRequest.Types.ConfigView view, st::CancellationToken cancellationToken) =>
            GetServiceConfigAsync(serviceName, configId, view, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new service configuration (version) for a managed service.
        /// This method only stores the service configuration. To roll out the service
        /// configuration to backend systems please call
        /// [CreateServiceRollout][google.api.servicemanagement.v1.ServiceManager.CreateServiceRollout].
        /// 
        /// Only the 100 most recent service configurations and ones referenced by
        /// existing rollouts are kept for each service. The rest will be deleted
        /// eventually.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ga::Service CreateServiceConfig(CreateServiceConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new service configuration (version) for a managed service.
        /// This method only stores the service configuration. To roll out the service
        /// configuration to backend systems please call
        /// [CreateServiceRollout][google.api.servicemanagement.v1.ServiceManager.CreateServiceRollout].
        /// 
        /// Only the 100 most recent service configurations and ones referenced by
        /// existing rollouts are kept for each service. The rest will be deleted
        /// eventually.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::Service> CreateServiceConfigAsync(CreateServiceConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new service configuration (version) for a managed service.
        /// This method only stores the service configuration. To roll out the service
        /// configuration to backend systems please call
        /// [CreateServiceRollout][google.api.servicemanagement.v1.ServiceManager.CreateServiceRollout].
        /// 
        /// Only the 100 most recent service configurations and ones referenced by
        /// existing rollouts are kept for each service. The rest will be deleted
        /// eventually.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::Service> CreateServiceConfigAsync(CreateServiceConfigRequest request, st::CancellationToken cancellationToken) =>
            CreateServiceConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new service configuration (version) for a managed service.
        /// This method only stores the service configuration. To roll out the service
        /// configuration to backend systems please call
        /// [CreateServiceRollout][google.api.servicemanagement.v1.ServiceManager.CreateServiceRollout].
        /// 
        /// Only the 100 most recent service configurations and ones referenced by
        /// existing rollouts are kept for each service. The rest will be deleted
        /// eventually.
        /// </summary>
        /// <param name="serviceName">
        /// Required. The name of the service.  See the
        /// [overview](https://cloud.google.com/service-management/overview) for naming
        /// requirements.  For example: `example.googleapis.com`.
        /// </param>
        /// <param name="serviceConfig">
        /// Required. The service configuration resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ga::Service CreateServiceConfig(string serviceName, ga::Service serviceConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceConfig(new CreateServiceConfigRequest
            {
                ServiceName = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceName, nameof(serviceName)),
                ServiceConfig = gax::GaxPreconditions.CheckNotNull(serviceConfig, nameof(serviceConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new service configuration (version) for a managed service.
        /// This method only stores the service configuration. To roll out the service
        /// configuration to backend systems please call
        /// [CreateServiceRollout][google.api.servicemanagement.v1.ServiceManager.CreateServiceRollout].
        /// 
        /// Only the 100 most recent service configurations and ones referenced by
        /// existing rollouts are kept for each service. The rest will be deleted
        /// eventually.
        /// </summary>
        /// <param name="serviceName">
        /// Required. The name of the service.  See the
        /// [overview](https://cloud.google.com/service-management/overview) for naming
        /// requirements.  For example: `example.googleapis.com`.
        /// </param>
        /// <param name="serviceConfig">
        /// Required. The service configuration resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::Service> CreateServiceConfigAsync(string serviceName, ga::Service serviceConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceConfigAsync(new CreateServiceConfigRequest
            {
                ServiceName = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceName, nameof(serviceName)),
                ServiceConfig = gax::GaxPreconditions.CheckNotNull(serviceConfig, nameof(serviceConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new service configuration (version) for a managed service.
        /// This method only stores the service configuration. To roll out the service
        /// configuration to backend systems please call
        /// [CreateServiceRollout][google.api.servicemanagement.v1.ServiceManager.CreateServiceRollout].
        /// 
        /// Only the 100 most recent service configurations and ones referenced by
        /// existing rollouts are kept for each service. The rest will be deleted
        /// eventually.
        /// </summary>
        /// <param name="serviceName">
        /// Required. The name of the service.  See the
        /// [overview](https://cloud.google.com/service-management/overview) for naming
        /// requirements.  For example: `example.googleapis.com`.
        /// </param>
        /// <param name="serviceConfig">
        /// Required. The service configuration resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::Service> CreateServiceConfigAsync(string serviceName, ga::Service serviceConfig, st::CancellationToken cancellationToken) =>
            CreateServiceConfigAsync(serviceName, serviceConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new service configuration (version) for a managed service based
        /// on
        /// user-supplied configuration source files (for example: OpenAPI
        /// Specification). This method stores the source configurations as well as the
        /// generated service configuration. To rollout the service configuration to
        /// other services,
        /// please call
        /// [CreateServiceRollout][google.api.servicemanagement.v1.ServiceManager.CreateServiceRollout].
        /// 
        /// Only the 100 most recent configuration sources and ones referenced by
        /// existing service configurtions are kept for each service. The rest will be
        /// deleted eventually.
        /// 
        /// Operation&lt;response: SubmitConfigSourceResponse&gt;
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SubmitConfigSourceResponse, OperationMetadata> SubmitConfigSource(SubmitConfigSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new service configuration (version) for a managed service based
        /// on
        /// user-supplied configuration source files (for example: OpenAPI
        /// Specification). This method stores the source configurations as well as the
        /// generated service configuration. To rollout the service configuration to
        /// other services,
        /// please call
        /// [CreateServiceRollout][google.api.servicemanagement.v1.ServiceManager.CreateServiceRollout].
        /// 
        /// Only the 100 most recent configuration sources and ones referenced by
        /// existing service configurtions are kept for each service. The rest will be
        /// deleted eventually.
        /// 
        /// Operation&lt;response: SubmitConfigSourceResponse&gt;
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SubmitConfigSourceResponse, OperationMetadata>> SubmitConfigSourceAsync(SubmitConfigSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new service configuration (version) for a managed service based
        /// on
        /// user-supplied configuration source files (for example: OpenAPI
        /// Specification). This method stores the source configurations as well as the
        /// generated service configuration. To rollout the service configuration to
        /// other services,
        /// please call
        /// [CreateServiceRollout][google.api.servicemanagement.v1.ServiceManager.CreateServiceRollout].
        /// 
        /// Only the 100 most recent configuration sources and ones referenced by
        /// existing service configurtions are kept for each service. The rest will be
        /// deleted eventually.
        /// 
        /// Operation&lt;response: SubmitConfigSourceResponse&gt;
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SubmitConfigSourceResponse, OperationMetadata>> SubmitConfigSourceAsync(SubmitConfigSourceRequest request, st::CancellationToken cancellationToken) =>
            SubmitConfigSourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SubmitConfigSource</c>.</summary>
        public virtual lro::OperationsClient SubmitConfigSourceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SubmitConfigSource</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<SubmitConfigSourceResponse, OperationMetadata> PollOnceSubmitConfigSource(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<SubmitConfigSourceResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SubmitConfigSourceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SubmitConfigSource</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<SubmitConfigSourceResponse, OperationMetadata>> PollOnceSubmitConfigSourceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<SubmitConfigSourceResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SubmitConfigSourceOperationsClient, callSettings);

        /// <summary>
        /// Creates a new service configuration (version) for a managed service based
        /// on
        /// user-supplied configuration source files (for example: OpenAPI
        /// Specification). This method stores the source configurations as well as the
        /// generated service configuration. To rollout the service configuration to
        /// other services,
        /// please call
        /// [CreateServiceRollout][google.api.servicemanagement.v1.ServiceManager.CreateServiceRollout].
        /// 
        /// Only the 100 most recent configuration sources and ones referenced by
        /// existing service configurtions are kept for each service. The rest will be
        /// deleted eventually.
        /// 
        /// Operation&lt;response: SubmitConfigSourceResponse&gt;
        /// </summary>
        /// <param name="serviceName">
        /// Required. The name of the service.  See the
        /// [overview](https://cloud.google.com/service-management/overview) for naming
        /// requirements.  For example: `example.googleapis.com`.
        /// </param>
        /// <param name="configSource">
        /// Required. The source configuration for the service.
        /// </param>
        /// <param name="validateOnly">
        /// Optional. If set, this will result in the generation of a
        /// `google.api.Service` configuration based on the `ConfigSource` provided,
        /// but the generated config and the sources will NOT be persisted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SubmitConfigSourceResponse, OperationMetadata> SubmitConfigSource(string serviceName, ConfigSource configSource, bool validateOnly, gaxgrpc::CallSettings callSettings = null) =>
            SubmitConfigSource(new SubmitConfigSourceRequest
            {
                ServiceName = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceName, nameof(serviceName)),
                ConfigSource = gax::GaxPreconditions.CheckNotNull(configSource, nameof(configSource)),
                ValidateOnly = validateOnly,
            }, callSettings);

        /// <summary>
        /// Creates a new service configuration (version) for a managed service based
        /// on
        /// user-supplied configuration source files (for example: OpenAPI
        /// Specification). This method stores the source configurations as well as the
        /// generated service configuration. To rollout the service configuration to
        /// other services,
        /// please call
        /// [CreateServiceRollout][google.api.servicemanagement.v1.ServiceManager.CreateServiceRollout].
        /// 
        /// Only the 100 most recent configuration sources and ones referenced by
        /// existing service configurtions are kept for each service. The rest will be
        /// deleted eventually.
        /// 
        /// Operation&lt;response: SubmitConfigSourceResponse&gt;
        /// </summary>
        /// <param name="serviceName">
        /// Required. The name of the service.  See the
        /// [overview](https://cloud.google.com/service-management/overview) for naming
        /// requirements.  For example: `example.googleapis.com`.
        /// </param>
        /// <param name="configSource">
        /// Required. The source configuration for the service.
        /// </param>
        /// <param name="validateOnly">
        /// Optional. If set, this will result in the generation of a
        /// `google.api.Service` configuration based on the `ConfigSource` provided,
        /// but the generated config and the sources will NOT be persisted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SubmitConfigSourceResponse, OperationMetadata>> SubmitConfigSourceAsync(string serviceName, ConfigSource configSource, bool validateOnly, gaxgrpc::CallSettings callSettings = null) =>
            SubmitConfigSourceAsync(new SubmitConfigSourceRequest
            {
                ServiceName = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceName, nameof(serviceName)),
                ConfigSource = gax::GaxPreconditions.CheckNotNull(configSource, nameof(configSource)),
                ValidateOnly = validateOnly,
            }, callSettings);

        /// <summary>
        /// Creates a new service configuration (version) for a managed service based
        /// on
        /// user-supplied configuration source files (for example: OpenAPI
        /// Specification). This method stores the source configurations as well as the
        /// generated service configuration. To rollout the service configuration to
        /// other services,
        /// please call
        /// [CreateServiceRollout][google.api.servicemanagement.v1.ServiceManager.CreateServiceRollout].
        /// 
        /// Only the 100 most recent configuration sources and ones referenced by
        /// existing service configurtions are kept for each service. The rest will be
        /// deleted eventually.
        /// 
        /// Operation&lt;response: SubmitConfigSourceResponse&gt;
        /// </summary>
        /// <param name="serviceName">
        /// Required. The name of the service.  See the
        /// [overview](https://cloud.google.com/service-management/overview) for naming
        /// requirements.  For example: `example.googleapis.com`.
        /// </param>
        /// <param name="configSource">
        /// Required. The source configuration for the service.
        /// </param>
        /// <param name="validateOnly">
        /// Optional. If set, this will result in the generation of a
        /// `google.api.Service` configuration based on the `ConfigSource` provided,
        /// but the generated config and the sources will NOT be persisted.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SubmitConfigSourceResponse, OperationMetadata>> SubmitConfigSourceAsync(string serviceName, ConfigSource configSource, bool validateOnly, st::CancellationToken cancellationToken) =>
            SubmitConfigSourceAsync(serviceName, configSource, validateOnly, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the history of the service configuration rollouts for a managed
        /// service, from the newest to the oldest.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Rollout"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServiceRolloutsResponse, Rollout> ListServiceRollouts(ListServiceRolloutsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the history of the service configuration rollouts for a managed
        /// service, from the newest to the oldest.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Rollout"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServiceRolloutsResponse, Rollout> ListServiceRolloutsAsync(ListServiceRolloutsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the history of the service configuration rollouts for a managed
        /// service, from the newest to the oldest.
        /// </summary>
        /// <param name="serviceName">
        /// Required. The name of the service.  See the
        /// [overview](https://cloud.google.com/service-management/overview) for naming
        /// requirements.  For example: `example.googleapis.com`.
        /// </param>
        /// <param name="filter">
        /// Required. Use `filter` to return subset of rollouts.
        /// The following filters are supported:
        /// 
        /// -- By [status]
        /// [google.api.servicemanagement.v1.Rollout.RolloutStatus]. For example,
        /// `filter='status=SUCCESS'`
        /// 
        /// -- By [strategy]
        /// [google.api.servicemanagement.v1.Rollout.strategy]. For example,
        /// `filter='strategy=TrafficPercentStrategy'`
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
        /// <returns>A pageable sequence of <see cref="Rollout"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServiceRolloutsResponse, Rollout> ListServiceRollouts(string serviceName, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServiceRolloutsRequest request = new ListServiceRolloutsRequest
            {
                ServiceName = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceName, nameof(serviceName)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListServiceRollouts(request, callSettings);
        }

        /// <summary>
        /// Lists the history of the service configuration rollouts for a managed
        /// service, from the newest to the oldest.
        /// </summary>
        /// <param name="serviceName">
        /// Required. The name of the service.  See the
        /// [overview](https://cloud.google.com/service-management/overview) for naming
        /// requirements.  For example: `example.googleapis.com`.
        /// </param>
        /// <param name="filter">
        /// Required. Use `filter` to return subset of rollouts.
        /// The following filters are supported:
        /// 
        /// -- By [status]
        /// [google.api.servicemanagement.v1.Rollout.RolloutStatus]. For example,
        /// `filter='status=SUCCESS'`
        /// 
        /// -- By [strategy]
        /// [google.api.servicemanagement.v1.Rollout.strategy]. For example,
        /// `filter='strategy=TrafficPercentStrategy'`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Rollout"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServiceRolloutsResponse, Rollout> ListServiceRolloutsAsync(string serviceName, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServiceRolloutsRequest request = new ListServiceRolloutsRequest
            {
                ServiceName = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceName, nameof(serviceName)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListServiceRolloutsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a service configuration
        /// [rollout][google.api.servicemanagement.v1.Rollout].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Rollout GetServiceRollout(GetServiceRolloutRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a service configuration
        /// [rollout][google.api.servicemanagement.v1.Rollout].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rollout> GetServiceRolloutAsync(GetServiceRolloutRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a service configuration
        /// [rollout][google.api.servicemanagement.v1.Rollout].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rollout> GetServiceRolloutAsync(GetServiceRolloutRequest request, st::CancellationToken cancellationToken) =>
            GetServiceRolloutAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a service configuration
        /// [rollout][google.api.servicemanagement.v1.Rollout].
        /// </summary>
        /// <param name="serviceName">
        /// Required. The name of the service.  See the
        /// [overview](https://cloud.google.com/service-management/overview) for naming
        /// requirements.  For example: `example.googleapis.com`.
        /// </param>
        /// <param name="rolloutId">
        /// Required. The id of the rollout resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Rollout GetServiceRollout(string serviceName, string rolloutId, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceRollout(new GetServiceRolloutRequest
            {
                ServiceName = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceName, nameof(serviceName)),
                RolloutId = gax::GaxPreconditions.CheckNotNullOrEmpty(rolloutId, nameof(rolloutId)),
            }, callSettings);

        /// <summary>
        /// Gets a service configuration
        /// [rollout][google.api.servicemanagement.v1.Rollout].
        /// </summary>
        /// <param name="serviceName">
        /// Required. The name of the service.  See the
        /// [overview](https://cloud.google.com/service-management/overview) for naming
        /// requirements.  For example: `example.googleapis.com`.
        /// </param>
        /// <param name="rolloutId">
        /// Required. The id of the rollout resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rollout> GetServiceRolloutAsync(string serviceName, string rolloutId, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceRolloutAsync(new GetServiceRolloutRequest
            {
                ServiceName = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceName, nameof(serviceName)),
                RolloutId = gax::GaxPreconditions.CheckNotNullOrEmpty(rolloutId, nameof(rolloutId)),
            }, callSettings);

        /// <summary>
        /// Gets a service configuration
        /// [rollout][google.api.servicemanagement.v1.Rollout].
        /// </summary>
        /// <param name="serviceName">
        /// Required. The name of the service.  See the
        /// [overview](https://cloud.google.com/service-management/overview) for naming
        /// requirements.  For example: `example.googleapis.com`.
        /// </param>
        /// <param name="rolloutId">
        /// Required. The id of the rollout resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rollout> GetServiceRolloutAsync(string serviceName, string rolloutId, st::CancellationToken cancellationToken) =>
            GetServiceRolloutAsync(serviceName, rolloutId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new service configuration rollout. Based on rollout, the
        /// Google Service Management will roll out the service configurations to
        /// different backend services. For example, the logging configuration will be
        /// pushed to Google Cloud Logging.
        /// 
        /// Please note that any previous pending and running Rollouts and associated
        /// Operations will be automatically cancelled so that the latest Rollout will
        /// not be blocked by previous Rollouts.
        /// 
        /// Only the 100 most recent (in any state) and the last 10 successful (if not
        /// already part of the set of 100 most recent) rollouts are kept for each
        /// service. The rest will be deleted eventually.
        /// 
        /// Operation&lt;response: Rollout&gt;
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Rollout, OperationMetadata> CreateServiceRollout(CreateServiceRolloutRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new service configuration rollout. Based on rollout, the
        /// Google Service Management will roll out the service configurations to
        /// different backend services. For example, the logging configuration will be
        /// pushed to Google Cloud Logging.
        /// 
        /// Please note that any previous pending and running Rollouts and associated
        /// Operations will be automatically cancelled so that the latest Rollout will
        /// not be blocked by previous Rollouts.
        /// 
        /// Only the 100 most recent (in any state) and the last 10 successful (if not
        /// already part of the set of 100 most recent) rollouts are kept for each
        /// service. The rest will be deleted eventually.
        /// 
        /// Operation&lt;response: Rollout&gt;
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Rollout, OperationMetadata>> CreateServiceRolloutAsync(CreateServiceRolloutRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new service configuration rollout. Based on rollout, the
        /// Google Service Management will roll out the service configurations to
        /// different backend services. For example, the logging configuration will be
        /// pushed to Google Cloud Logging.
        /// 
        /// Please note that any previous pending and running Rollouts and associated
        /// Operations will be automatically cancelled so that the latest Rollout will
        /// not be blocked by previous Rollouts.
        /// 
        /// Only the 100 most recent (in any state) and the last 10 successful (if not
        /// already part of the set of 100 most recent) rollouts are kept for each
        /// service. The rest will be deleted eventually.
        /// 
        /// Operation&lt;response: Rollout&gt;
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Rollout, OperationMetadata>> CreateServiceRolloutAsync(CreateServiceRolloutRequest request, st::CancellationToken cancellationToken) =>
            CreateServiceRolloutAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateServiceRollout</c>.</summary>
        public virtual lro::OperationsClient CreateServiceRolloutOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateServiceRollout</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Rollout, OperationMetadata> PollOnceCreateServiceRollout(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Rollout, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateServiceRolloutOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateServiceRollout</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Rollout, OperationMetadata>> PollOnceCreateServiceRolloutAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Rollout, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateServiceRolloutOperationsClient, callSettings);

        /// <summary>
        /// Creates a new service configuration rollout. Based on rollout, the
        /// Google Service Management will roll out the service configurations to
        /// different backend services. For example, the logging configuration will be
        /// pushed to Google Cloud Logging.
        /// 
        /// Please note that any previous pending and running Rollouts and associated
        /// Operations will be automatically cancelled so that the latest Rollout will
        /// not be blocked by previous Rollouts.
        /// 
        /// Only the 100 most recent (in any state) and the last 10 successful (if not
        /// already part of the set of 100 most recent) rollouts are kept for each
        /// service. The rest will be deleted eventually.
        /// 
        /// Operation&lt;response: Rollout&gt;
        /// </summary>
        /// <param name="serviceName">
        /// Required. The name of the service.  See the
        /// [overview](https://cloud.google.com/service-management/overview) for naming
        /// requirements.  For example: `example.googleapis.com`.
        /// </param>
        /// <param name="rollout">
        /// Required. The rollout resource. The `service_name` field is output only.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Rollout, OperationMetadata> CreateServiceRollout(string serviceName, Rollout rollout, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceRollout(new CreateServiceRolloutRequest
            {
                ServiceName = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceName, nameof(serviceName)),
                Rollout = gax::GaxPreconditions.CheckNotNull(rollout, nameof(rollout)),
            }, callSettings);

        /// <summary>
        /// Creates a new service configuration rollout. Based on rollout, the
        /// Google Service Management will roll out the service configurations to
        /// different backend services. For example, the logging configuration will be
        /// pushed to Google Cloud Logging.
        /// 
        /// Please note that any previous pending and running Rollouts and associated
        /// Operations will be automatically cancelled so that the latest Rollout will
        /// not be blocked by previous Rollouts.
        /// 
        /// Only the 100 most recent (in any state) and the last 10 successful (if not
        /// already part of the set of 100 most recent) rollouts are kept for each
        /// service. The rest will be deleted eventually.
        /// 
        /// Operation&lt;response: Rollout&gt;
        /// </summary>
        /// <param name="serviceName">
        /// Required. The name of the service.  See the
        /// [overview](https://cloud.google.com/service-management/overview) for naming
        /// requirements.  For example: `example.googleapis.com`.
        /// </param>
        /// <param name="rollout">
        /// Required. The rollout resource. The `service_name` field is output only.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Rollout, OperationMetadata>> CreateServiceRolloutAsync(string serviceName, Rollout rollout, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceRolloutAsync(new CreateServiceRolloutRequest
            {
                ServiceName = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceName, nameof(serviceName)),
                Rollout = gax::GaxPreconditions.CheckNotNull(rollout, nameof(rollout)),
            }, callSettings);

        /// <summary>
        /// Creates a new service configuration rollout. Based on rollout, the
        /// Google Service Management will roll out the service configurations to
        /// different backend services. For example, the logging configuration will be
        /// pushed to Google Cloud Logging.
        /// 
        /// Please note that any previous pending and running Rollouts and associated
        /// Operations will be automatically cancelled so that the latest Rollout will
        /// not be blocked by previous Rollouts.
        /// 
        /// Only the 100 most recent (in any state) and the last 10 successful (if not
        /// already part of the set of 100 most recent) rollouts are kept for each
        /// service. The rest will be deleted eventually.
        /// 
        /// Operation&lt;response: Rollout&gt;
        /// </summary>
        /// <param name="serviceName">
        /// Required. The name of the service.  See the
        /// [overview](https://cloud.google.com/service-management/overview) for naming
        /// requirements.  For example: `example.googleapis.com`.
        /// </param>
        /// <param name="rollout">
        /// Required. The rollout resource. The `service_name` field is output only.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Rollout, OperationMetadata>> CreateServiceRolloutAsync(string serviceName, Rollout rollout, st::CancellationToken cancellationToken) =>
            CreateServiceRolloutAsync(serviceName, rollout, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates and returns a report (errors, warnings and changes from
        /// existing configurations) associated with
        /// GenerateConfigReportRequest.new_value
        /// 
        /// If GenerateConfigReportRequest.old_value is specified,
        /// GenerateConfigReportRequest will contain a single ChangeReport based on the
        /// comparison between GenerateConfigReportRequest.new_value and
        /// GenerateConfigReportRequest.old_value.
        /// If GenerateConfigReportRequest.old_value is not specified, this method
        /// will compare GenerateConfigReportRequest.new_value with the last pushed
        /// service configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateConfigReportResponse GenerateConfigReport(GenerateConfigReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates and returns a report (errors, warnings and changes from
        /// existing configurations) associated with
        /// GenerateConfigReportRequest.new_value
        /// 
        /// If GenerateConfigReportRequest.old_value is specified,
        /// GenerateConfigReportRequest will contain a single ChangeReport based on the
        /// comparison between GenerateConfigReportRequest.new_value and
        /// GenerateConfigReportRequest.old_value.
        /// If GenerateConfigReportRequest.old_value is not specified, this method
        /// will compare GenerateConfigReportRequest.new_value with the last pushed
        /// service configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateConfigReportResponse> GenerateConfigReportAsync(GenerateConfigReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates and returns a report (errors, warnings and changes from
        /// existing configurations) associated with
        /// GenerateConfigReportRequest.new_value
        /// 
        /// If GenerateConfigReportRequest.old_value is specified,
        /// GenerateConfigReportRequest will contain a single ChangeReport based on the
        /// comparison between GenerateConfigReportRequest.new_value and
        /// GenerateConfigReportRequest.old_value.
        /// If GenerateConfigReportRequest.old_value is not specified, this method
        /// will compare GenerateConfigReportRequest.new_value with the last pushed
        /// service configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateConfigReportResponse> GenerateConfigReportAsync(GenerateConfigReportRequest request, st::CancellationToken cancellationToken) =>
            GenerateConfigReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates and returns a report (errors, warnings and changes from
        /// existing configurations) associated with
        /// GenerateConfigReportRequest.new_value
        /// 
        /// If GenerateConfigReportRequest.old_value is specified,
        /// GenerateConfigReportRequest will contain a single ChangeReport based on the
        /// comparison between GenerateConfigReportRequest.new_value and
        /// GenerateConfigReportRequest.old_value.
        /// If GenerateConfigReportRequest.old_value is not specified, this method
        /// will compare GenerateConfigReportRequest.new_value with the last pushed
        /// service configuration.
        /// </summary>
        /// <param name="newConfig">
        /// Required. Service configuration for which we want to generate the report.
        /// For this version of API, the supported types are
        /// [google.api.servicemanagement.v1.ConfigRef][google.api.servicemanagement.v1.ConfigRef],
        /// [google.api.servicemanagement.v1.ConfigSource][google.api.servicemanagement.v1.ConfigSource],
        /// and [google.api.Service][google.api.Service]
        /// </param>
        /// <param name="oldConfig">
        /// Optional. Service configuration against which the comparison will be done.
        /// For this version of API, the supported types are
        /// [google.api.servicemanagement.v1.ConfigRef][google.api.servicemanagement.v1.ConfigRef],
        /// [google.api.servicemanagement.v1.ConfigSource][google.api.servicemanagement.v1.ConfigSource],
        /// and [google.api.Service][google.api.Service]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateConfigReportResponse GenerateConfigReport(wkt::Any newConfig, wkt::Any oldConfig, gaxgrpc::CallSettings callSettings = null) =>
            GenerateConfigReport(new GenerateConfigReportRequest
            {
                NewConfig = gax::GaxPreconditions.CheckNotNull(newConfig, nameof(newConfig)),
                OldConfig = oldConfig,
            }, callSettings);

        /// <summary>
        /// Generates and returns a report (errors, warnings and changes from
        /// existing configurations) associated with
        /// GenerateConfigReportRequest.new_value
        /// 
        /// If GenerateConfigReportRequest.old_value is specified,
        /// GenerateConfigReportRequest will contain a single ChangeReport based on the
        /// comparison between GenerateConfigReportRequest.new_value and
        /// GenerateConfigReportRequest.old_value.
        /// If GenerateConfigReportRequest.old_value is not specified, this method
        /// will compare GenerateConfigReportRequest.new_value with the last pushed
        /// service configuration.
        /// </summary>
        /// <param name="newConfig">
        /// Required. Service configuration for which we want to generate the report.
        /// For this version of API, the supported types are
        /// [google.api.servicemanagement.v1.ConfigRef][google.api.servicemanagement.v1.ConfigRef],
        /// [google.api.servicemanagement.v1.ConfigSource][google.api.servicemanagement.v1.ConfigSource],
        /// and [google.api.Service][google.api.Service]
        /// </param>
        /// <param name="oldConfig">
        /// Optional. Service configuration against which the comparison will be done.
        /// For this version of API, the supported types are
        /// [google.api.servicemanagement.v1.ConfigRef][google.api.servicemanagement.v1.ConfigRef],
        /// [google.api.servicemanagement.v1.ConfigSource][google.api.servicemanagement.v1.ConfigSource],
        /// and [google.api.Service][google.api.Service]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateConfigReportResponse> GenerateConfigReportAsync(wkt::Any newConfig, wkt::Any oldConfig, gaxgrpc::CallSettings callSettings = null) =>
            GenerateConfigReportAsync(new GenerateConfigReportRequest
            {
                NewConfig = gax::GaxPreconditions.CheckNotNull(newConfig, nameof(newConfig)),
                OldConfig = oldConfig,
            }, callSettings);

        /// <summary>
        /// Generates and returns a report (errors, warnings and changes from
        /// existing configurations) associated with
        /// GenerateConfigReportRequest.new_value
        /// 
        /// If GenerateConfigReportRequest.old_value is specified,
        /// GenerateConfigReportRequest will contain a single ChangeReport based on the
        /// comparison between GenerateConfigReportRequest.new_value and
        /// GenerateConfigReportRequest.old_value.
        /// If GenerateConfigReportRequest.old_value is not specified, this method
        /// will compare GenerateConfigReportRequest.new_value with the last pushed
        /// service configuration.
        /// </summary>
        /// <param name="newConfig">
        /// Required. Service configuration for which we want to generate the report.
        /// For this version of API, the supported types are
        /// [google.api.servicemanagement.v1.ConfigRef][google.api.servicemanagement.v1.ConfigRef],
        /// [google.api.servicemanagement.v1.ConfigSource][google.api.servicemanagement.v1.ConfigSource],
        /// and [google.api.Service][google.api.Service]
        /// </param>
        /// <param name="oldConfig">
        /// Optional. Service configuration against which the comparison will be done.
        /// For this version of API, the supported types are
        /// [google.api.servicemanagement.v1.ConfigRef][google.api.servicemanagement.v1.ConfigRef],
        /// [google.api.servicemanagement.v1.ConfigSource][google.api.servicemanagement.v1.ConfigSource],
        /// and [google.api.Service][google.api.Service]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateConfigReportResponse> GenerateConfigReportAsync(wkt::Any newConfig, wkt::Any oldConfig, st::CancellationToken cancellationToken) =>
            GenerateConfigReportAsync(newConfig, oldConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ServiceManager client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// [Google Service Management
    /// API](https://cloud.google.com/service-infrastructure/docs/overview)
    /// </remarks>
    public sealed partial class ServiceManagerClientImpl : ServiceManagerClient
    {
        private readonly gaxgrpc::ApiCall<ListServicesRequest, ListServicesResponse> _callListServices;

        private readonly gaxgrpc::ApiCall<GetServiceRequest, ManagedService> _callGetService;

        private readonly gaxgrpc::ApiCall<CreateServiceRequest, lro::Operation> _callCreateService;

        private readonly gaxgrpc::ApiCall<DeleteServiceRequest, lro::Operation> _callDeleteService;

        private readonly gaxgrpc::ApiCall<UndeleteServiceRequest, lro::Operation> _callUndeleteService;

        private readonly gaxgrpc::ApiCall<ListServiceConfigsRequest, ListServiceConfigsResponse> _callListServiceConfigs;

        private readonly gaxgrpc::ApiCall<GetServiceConfigRequest, ga::Service> _callGetServiceConfig;

        private readonly gaxgrpc::ApiCall<CreateServiceConfigRequest, ga::Service> _callCreateServiceConfig;

        private readonly gaxgrpc::ApiCall<SubmitConfigSourceRequest, lro::Operation> _callSubmitConfigSource;

        private readonly gaxgrpc::ApiCall<ListServiceRolloutsRequest, ListServiceRolloutsResponse> _callListServiceRollouts;

        private readonly gaxgrpc::ApiCall<GetServiceRolloutRequest, Rollout> _callGetServiceRollout;

        private readonly gaxgrpc::ApiCall<CreateServiceRolloutRequest, lro::Operation> _callCreateServiceRollout;

        private readonly gaxgrpc::ApiCall<GenerateConfigReportRequest, GenerateConfigReportResponse> _callGenerateConfigReport;

        /// <summary>
        /// Constructs a client wrapper for the ServiceManager service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ServiceManagerSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ServiceManagerClientImpl(ServiceManager.ServiceManagerClient grpcClient, ServiceManagerSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ServiceManagerSettings effectiveSettings = settings ?? ServiceManagerSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateServiceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateServiceOperationsSettings, logger);
            DeleteServiceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteServiceOperationsSettings, logger);
            UndeleteServiceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UndeleteServiceOperationsSettings, logger);
            SubmitConfigSourceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.SubmitConfigSourceOperationsSettings, logger);
            CreateServiceRolloutOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateServiceRolloutOperationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListServices = clientHelper.BuildApiCall<ListServicesRequest, ListServicesResponse>("ListServices", grpcClient.ListServicesAsync, grpcClient.ListServices, effectiveSettings.ListServicesSettings);
            Modify_ApiCall(ref _callListServices);
            Modify_ListServicesApiCall(ref _callListServices);
            _callGetService = clientHelper.BuildApiCall<GetServiceRequest, ManagedService>("GetService", grpcClient.GetServiceAsync, grpcClient.GetService, effectiveSettings.GetServiceSettings).WithGoogleRequestParam("service_name", request => request.ServiceName);
            Modify_ApiCall(ref _callGetService);
            Modify_GetServiceApiCall(ref _callGetService);
            _callCreateService = clientHelper.BuildApiCall<CreateServiceRequest, lro::Operation>("CreateService", grpcClient.CreateServiceAsync, grpcClient.CreateService, effectiveSettings.CreateServiceSettings);
            Modify_ApiCall(ref _callCreateService);
            Modify_CreateServiceApiCall(ref _callCreateService);
            _callDeleteService = clientHelper.BuildApiCall<DeleteServiceRequest, lro::Operation>("DeleteService", grpcClient.DeleteServiceAsync, grpcClient.DeleteService, effectiveSettings.DeleteServiceSettings).WithGoogleRequestParam("service_name", request => request.ServiceName);
            Modify_ApiCall(ref _callDeleteService);
            Modify_DeleteServiceApiCall(ref _callDeleteService);
            _callUndeleteService = clientHelper.BuildApiCall<UndeleteServiceRequest, lro::Operation>("UndeleteService", grpcClient.UndeleteServiceAsync, grpcClient.UndeleteService, effectiveSettings.UndeleteServiceSettings).WithGoogleRequestParam("service_name", request => request.ServiceName);
            Modify_ApiCall(ref _callUndeleteService);
            Modify_UndeleteServiceApiCall(ref _callUndeleteService);
            _callListServiceConfigs = clientHelper.BuildApiCall<ListServiceConfigsRequest, ListServiceConfigsResponse>("ListServiceConfigs", grpcClient.ListServiceConfigsAsync, grpcClient.ListServiceConfigs, effectiveSettings.ListServiceConfigsSettings).WithGoogleRequestParam("service_name", request => request.ServiceName);
            Modify_ApiCall(ref _callListServiceConfigs);
            Modify_ListServiceConfigsApiCall(ref _callListServiceConfigs);
            _callGetServiceConfig = clientHelper.BuildApiCall<GetServiceConfigRequest, ga::Service>("GetServiceConfig", grpcClient.GetServiceConfigAsync, grpcClient.GetServiceConfig, effectiveSettings.GetServiceConfigSettings).WithGoogleRequestParam("service_name", request => request.ServiceName).WithGoogleRequestParam("config_id", request => request.ConfigId);
            Modify_ApiCall(ref _callGetServiceConfig);
            Modify_GetServiceConfigApiCall(ref _callGetServiceConfig);
            _callCreateServiceConfig = clientHelper.BuildApiCall<CreateServiceConfigRequest, ga::Service>("CreateServiceConfig", grpcClient.CreateServiceConfigAsync, grpcClient.CreateServiceConfig, effectiveSettings.CreateServiceConfigSettings).WithGoogleRequestParam("service_name", request => request.ServiceName);
            Modify_ApiCall(ref _callCreateServiceConfig);
            Modify_CreateServiceConfigApiCall(ref _callCreateServiceConfig);
            _callSubmitConfigSource = clientHelper.BuildApiCall<SubmitConfigSourceRequest, lro::Operation>("SubmitConfigSource", grpcClient.SubmitConfigSourceAsync, grpcClient.SubmitConfigSource, effectiveSettings.SubmitConfigSourceSettings).WithGoogleRequestParam("service_name", request => request.ServiceName);
            Modify_ApiCall(ref _callSubmitConfigSource);
            Modify_SubmitConfigSourceApiCall(ref _callSubmitConfigSource);
            _callListServiceRollouts = clientHelper.BuildApiCall<ListServiceRolloutsRequest, ListServiceRolloutsResponse>("ListServiceRollouts", grpcClient.ListServiceRolloutsAsync, grpcClient.ListServiceRollouts, effectiveSettings.ListServiceRolloutsSettings).WithGoogleRequestParam("service_name", request => request.ServiceName);
            Modify_ApiCall(ref _callListServiceRollouts);
            Modify_ListServiceRolloutsApiCall(ref _callListServiceRollouts);
            _callGetServiceRollout = clientHelper.BuildApiCall<GetServiceRolloutRequest, Rollout>("GetServiceRollout", grpcClient.GetServiceRolloutAsync, grpcClient.GetServiceRollout, effectiveSettings.GetServiceRolloutSettings).WithGoogleRequestParam("service_name", request => request.ServiceName).WithGoogleRequestParam("rollout_id", request => request.RolloutId);
            Modify_ApiCall(ref _callGetServiceRollout);
            Modify_GetServiceRolloutApiCall(ref _callGetServiceRollout);
            _callCreateServiceRollout = clientHelper.BuildApiCall<CreateServiceRolloutRequest, lro::Operation>("CreateServiceRollout", grpcClient.CreateServiceRolloutAsync, grpcClient.CreateServiceRollout, effectiveSettings.CreateServiceRolloutSettings).WithGoogleRequestParam("service_name", request => request.ServiceName);
            Modify_ApiCall(ref _callCreateServiceRollout);
            Modify_CreateServiceRolloutApiCall(ref _callCreateServiceRollout);
            _callGenerateConfigReport = clientHelper.BuildApiCall<GenerateConfigReportRequest, GenerateConfigReportResponse>("GenerateConfigReport", grpcClient.GenerateConfigReportAsync, grpcClient.GenerateConfigReport, effectiveSettings.GenerateConfigReportSettings);
            Modify_ApiCall(ref _callGenerateConfigReport);
            Modify_GenerateConfigReportApiCall(ref _callGenerateConfigReport);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListServicesApiCall(ref gaxgrpc::ApiCall<ListServicesRequest, ListServicesResponse> call);

        partial void Modify_GetServiceApiCall(ref gaxgrpc::ApiCall<GetServiceRequest, ManagedService> call);

        partial void Modify_CreateServiceApiCall(ref gaxgrpc::ApiCall<CreateServiceRequest, lro::Operation> call);

        partial void Modify_DeleteServiceApiCall(ref gaxgrpc::ApiCall<DeleteServiceRequest, lro::Operation> call);

        partial void Modify_UndeleteServiceApiCall(ref gaxgrpc::ApiCall<UndeleteServiceRequest, lro::Operation> call);

        partial void Modify_ListServiceConfigsApiCall(ref gaxgrpc::ApiCall<ListServiceConfigsRequest, ListServiceConfigsResponse> call);

        partial void Modify_GetServiceConfigApiCall(ref gaxgrpc::ApiCall<GetServiceConfigRequest, ga::Service> call);

        partial void Modify_CreateServiceConfigApiCall(ref gaxgrpc::ApiCall<CreateServiceConfigRequest, ga::Service> call);

        partial void Modify_SubmitConfigSourceApiCall(ref gaxgrpc::ApiCall<SubmitConfigSourceRequest, lro::Operation> call);

        partial void Modify_ListServiceRolloutsApiCall(ref gaxgrpc::ApiCall<ListServiceRolloutsRequest, ListServiceRolloutsResponse> call);

        partial void Modify_GetServiceRolloutApiCall(ref gaxgrpc::ApiCall<GetServiceRolloutRequest, Rollout> call);

        partial void Modify_CreateServiceRolloutApiCall(ref gaxgrpc::ApiCall<CreateServiceRolloutRequest, lro::Operation> call);

        partial void Modify_GenerateConfigReportApiCall(ref gaxgrpc::ApiCall<GenerateConfigReportRequest, GenerateConfigReportResponse> call);

        partial void OnConstruction(ServiceManager.ServiceManagerClient grpcClient, ServiceManagerSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ServiceManager client</summary>
        public override ServiceManager.ServiceManagerClient GrpcClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListServicesRequest(ref ListServicesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetServiceRequest(ref GetServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateServiceRequest(ref CreateServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteServiceRequest(ref DeleteServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UndeleteServiceRequest(ref UndeleteServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListServiceConfigsRequest(ref ListServiceConfigsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetServiceConfigRequest(ref GetServiceConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateServiceConfigRequest(ref CreateServiceConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SubmitConfigSourceRequest(ref SubmitConfigSourceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListServiceRolloutsRequest(ref ListServiceRolloutsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetServiceRolloutRequest(ref GetServiceRolloutRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateServiceRolloutRequest(ref CreateServiceRolloutRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateConfigReportRequest(ref GenerateConfigReportRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists managed services.
        /// 
        /// Returns all public services. For authenticated users, also returns all
        /// services the calling user has "servicemanagement.services.get" permission
        /// for.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ManagedService"/> resources.</returns>
        public override gax::PagedEnumerable<ListServicesResponse, ManagedService> ListServices(ListServicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServicesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListServicesRequest, ListServicesResponse, ManagedService>(_callListServices, request, callSettings);
        }

        /// <summary>
        /// Lists managed services.
        /// 
        /// Returns all public services. For authenticated users, also returns all
        /// services the calling user has "servicemanagement.services.get" permission
        /// for.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ManagedService"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListServicesResponse, ManagedService> ListServicesAsync(ListServicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServicesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListServicesRequest, ListServicesResponse, ManagedService>(_callListServices, request, callSettings);
        }

        /// <summary>
        /// Gets a managed service. Authentication is required unless the service is
        /// public.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ManagedService GetService(GetServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceRequest(ref request, ref callSettings);
            return _callGetService.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a managed service. Authentication is required unless the service is
        /// public.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ManagedService> GetServiceAsync(GetServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceRequest(ref request, ref callSettings);
            return _callGetService.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateService</c>.</summary>
        public override lro::OperationsClient CreateServiceOperationsClient { get; }

        /// <summary>
        /// Creates a new managed service.
        /// 
        /// A managed service is immutable, and is subject to mandatory 30-day
        /// data retention. You cannot move a service or recreate it within 30 days
        /// after deletion.
        /// 
        /// One producer project can own no more than 500 services. For security and
        /// reliability purposes, a production service should be hosted in a
        /// dedicated producer project.
        /// 
        /// Operation&lt;response: ManagedService&gt;
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ManagedService, OperationMetadata> CreateService(CreateServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServiceRequest(ref request, ref callSettings);
            return new lro::Operation<ManagedService, OperationMetadata>(_callCreateService.Sync(request, callSettings), CreateServiceOperationsClient);
        }

        /// <summary>
        /// Creates a new managed service.
        /// 
        /// A managed service is immutable, and is subject to mandatory 30-day
        /// data retention. You cannot move a service or recreate it within 30 days
        /// after deletion.
        /// 
        /// One producer project can own no more than 500 services. For security and
        /// reliability purposes, a production service should be hosted in a
        /// dedicated producer project.
        /// 
        /// Operation&lt;response: ManagedService&gt;
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ManagedService, OperationMetadata>> CreateServiceAsync(CreateServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServiceRequest(ref request, ref callSettings);
            return new lro::Operation<ManagedService, OperationMetadata>(await _callCreateService.Async(request, callSettings).ConfigureAwait(false), CreateServiceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteService</c>.</summary>
        public override lro::OperationsClient DeleteServiceOperationsClient { get; }

        /// <summary>
        /// Deletes a managed service. This method will change the service to the
        /// `Soft-Delete` state for 30 days. Within this period, service producers may
        /// call
        /// [UndeleteService][google.api.servicemanagement.v1.ServiceManager.UndeleteService]
        /// to restore the service. After 30 days, the service will be permanently
        /// deleted.
        /// 
        /// Operation&lt;response: google.protobuf.Empty&gt;
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteService(DeleteServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServiceRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteService.Sync(request, callSettings), DeleteServiceOperationsClient);
        }

        /// <summary>
        /// Deletes a managed service. This method will change the service to the
        /// `Soft-Delete` state for 30 days. Within this period, service producers may
        /// call
        /// [UndeleteService][google.api.servicemanagement.v1.ServiceManager.UndeleteService]
        /// to restore the service. After 30 days, the service will be permanently
        /// deleted.
        /// 
        /// Operation&lt;response: google.protobuf.Empty&gt;
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceAsync(DeleteServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServiceRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteService.Async(request, callSettings).ConfigureAwait(false), DeleteServiceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UndeleteService</c>.</summary>
        public override lro::OperationsClient UndeleteServiceOperationsClient { get; }

        /// <summary>
        /// Revives a previously deleted managed service. The method restores the
        /// service using the configuration at the time the service was deleted.
        /// The target service must exist and must have been deleted within the
        /// last 30 days.
        /// 
        /// Operation&lt;response: UndeleteServiceResponse&gt;
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<UndeleteServiceResponse, OperationMetadata> UndeleteService(UndeleteServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeleteServiceRequest(ref request, ref callSettings);
            return new lro::Operation<UndeleteServiceResponse, OperationMetadata>(_callUndeleteService.Sync(request, callSettings), UndeleteServiceOperationsClient);
        }

        /// <summary>
        /// Revives a previously deleted managed service. The method restores the
        /// service using the configuration at the time the service was deleted.
        /// The target service must exist and must have been deleted within the
        /// last 30 days.
        /// 
        /// Operation&lt;response: UndeleteServiceResponse&gt;
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<UndeleteServiceResponse, OperationMetadata>> UndeleteServiceAsync(UndeleteServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeleteServiceRequest(ref request, ref callSettings);
            return new lro::Operation<UndeleteServiceResponse, OperationMetadata>(await _callUndeleteService.Async(request, callSettings).ConfigureAwait(false), UndeleteServiceOperationsClient);
        }

        /// <summary>
        /// Lists the history of the service configuration for a managed service,
        /// from the newest to the oldest.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ga::Service"/> resources.</returns>
        public override gax::PagedEnumerable<ListServiceConfigsResponse, ga::Service> ListServiceConfigs(ListServiceConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServiceConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListServiceConfigsRequest, ListServiceConfigsResponse, ga::Service>(_callListServiceConfigs, request, callSettings);
        }

        /// <summary>
        /// Lists the history of the service configuration for a managed service,
        /// from the newest to the oldest.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ga::Service"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListServiceConfigsResponse, ga::Service> ListServiceConfigsAsync(ListServiceConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServiceConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListServiceConfigsRequest, ListServiceConfigsResponse, ga::Service>(_callListServiceConfigs, request, callSettings);
        }

        /// <summary>
        /// Gets a service configuration (version) for a managed service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ga::Service GetServiceConfig(GetServiceConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceConfigRequest(ref request, ref callSettings);
            return _callGetServiceConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a service configuration (version) for a managed service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ga::Service> GetServiceConfigAsync(GetServiceConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceConfigRequest(ref request, ref callSettings);
            return _callGetServiceConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new service configuration (version) for a managed service.
        /// This method only stores the service configuration. To roll out the service
        /// configuration to backend systems please call
        /// [CreateServiceRollout][google.api.servicemanagement.v1.ServiceManager.CreateServiceRollout].
        /// 
        /// Only the 100 most recent service configurations and ones referenced by
        /// existing rollouts are kept for each service. The rest will be deleted
        /// eventually.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ga::Service CreateServiceConfig(CreateServiceConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServiceConfigRequest(ref request, ref callSettings);
            return _callCreateServiceConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new service configuration (version) for a managed service.
        /// This method only stores the service configuration. To roll out the service
        /// configuration to backend systems please call
        /// [CreateServiceRollout][google.api.servicemanagement.v1.ServiceManager.CreateServiceRollout].
        /// 
        /// Only the 100 most recent service configurations and ones referenced by
        /// existing rollouts are kept for each service. The rest will be deleted
        /// eventually.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ga::Service> CreateServiceConfigAsync(CreateServiceConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServiceConfigRequest(ref request, ref callSettings);
            return _callCreateServiceConfig.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>SubmitConfigSource</c>.</summary>
        public override lro::OperationsClient SubmitConfigSourceOperationsClient { get; }

        /// <summary>
        /// Creates a new service configuration (version) for a managed service based
        /// on
        /// user-supplied configuration source files (for example: OpenAPI
        /// Specification). This method stores the source configurations as well as the
        /// generated service configuration. To rollout the service configuration to
        /// other services,
        /// please call
        /// [CreateServiceRollout][google.api.servicemanagement.v1.ServiceManager.CreateServiceRollout].
        /// 
        /// Only the 100 most recent configuration sources and ones referenced by
        /// existing service configurtions are kept for each service. The rest will be
        /// deleted eventually.
        /// 
        /// Operation&lt;response: SubmitConfigSourceResponse&gt;
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<SubmitConfigSourceResponse, OperationMetadata> SubmitConfigSource(SubmitConfigSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SubmitConfigSourceRequest(ref request, ref callSettings);
            return new lro::Operation<SubmitConfigSourceResponse, OperationMetadata>(_callSubmitConfigSource.Sync(request, callSettings), SubmitConfigSourceOperationsClient);
        }

        /// <summary>
        /// Creates a new service configuration (version) for a managed service based
        /// on
        /// user-supplied configuration source files (for example: OpenAPI
        /// Specification). This method stores the source configurations as well as the
        /// generated service configuration. To rollout the service configuration to
        /// other services,
        /// please call
        /// [CreateServiceRollout][google.api.servicemanagement.v1.ServiceManager.CreateServiceRollout].
        /// 
        /// Only the 100 most recent configuration sources and ones referenced by
        /// existing service configurtions are kept for each service. The rest will be
        /// deleted eventually.
        /// 
        /// Operation&lt;response: SubmitConfigSourceResponse&gt;
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<SubmitConfigSourceResponse, OperationMetadata>> SubmitConfigSourceAsync(SubmitConfigSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SubmitConfigSourceRequest(ref request, ref callSettings);
            return new lro::Operation<SubmitConfigSourceResponse, OperationMetadata>(await _callSubmitConfigSource.Async(request, callSettings).ConfigureAwait(false), SubmitConfigSourceOperationsClient);
        }

        /// <summary>
        /// Lists the history of the service configuration rollouts for a managed
        /// service, from the newest to the oldest.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Rollout"/> resources.</returns>
        public override gax::PagedEnumerable<ListServiceRolloutsResponse, Rollout> ListServiceRollouts(ListServiceRolloutsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServiceRolloutsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListServiceRolloutsRequest, ListServiceRolloutsResponse, Rollout>(_callListServiceRollouts, request, callSettings);
        }

        /// <summary>
        /// Lists the history of the service configuration rollouts for a managed
        /// service, from the newest to the oldest.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Rollout"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListServiceRolloutsResponse, Rollout> ListServiceRolloutsAsync(ListServiceRolloutsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServiceRolloutsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListServiceRolloutsRequest, ListServiceRolloutsResponse, Rollout>(_callListServiceRollouts, request, callSettings);
        }

        /// <summary>
        /// Gets a service configuration
        /// [rollout][google.api.servicemanagement.v1.Rollout].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Rollout GetServiceRollout(GetServiceRolloutRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceRolloutRequest(ref request, ref callSettings);
            return _callGetServiceRollout.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a service configuration
        /// [rollout][google.api.servicemanagement.v1.Rollout].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Rollout> GetServiceRolloutAsync(GetServiceRolloutRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceRolloutRequest(ref request, ref callSettings);
            return _callGetServiceRollout.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateServiceRollout</c>.</summary>
        public override lro::OperationsClient CreateServiceRolloutOperationsClient { get; }

        /// <summary>
        /// Creates a new service configuration rollout. Based on rollout, the
        /// Google Service Management will roll out the service configurations to
        /// different backend services. For example, the logging configuration will be
        /// pushed to Google Cloud Logging.
        /// 
        /// Please note that any previous pending and running Rollouts and associated
        /// Operations will be automatically cancelled so that the latest Rollout will
        /// not be blocked by previous Rollouts.
        /// 
        /// Only the 100 most recent (in any state) and the last 10 successful (if not
        /// already part of the set of 100 most recent) rollouts are kept for each
        /// service. The rest will be deleted eventually.
        /// 
        /// Operation&lt;response: Rollout&gt;
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Rollout, OperationMetadata> CreateServiceRollout(CreateServiceRolloutRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServiceRolloutRequest(ref request, ref callSettings);
            return new lro::Operation<Rollout, OperationMetadata>(_callCreateServiceRollout.Sync(request, callSettings), CreateServiceRolloutOperationsClient);
        }

        /// <summary>
        /// Creates a new service configuration rollout. Based on rollout, the
        /// Google Service Management will roll out the service configurations to
        /// different backend services. For example, the logging configuration will be
        /// pushed to Google Cloud Logging.
        /// 
        /// Please note that any previous pending and running Rollouts and associated
        /// Operations will be automatically cancelled so that the latest Rollout will
        /// not be blocked by previous Rollouts.
        /// 
        /// Only the 100 most recent (in any state) and the last 10 successful (if not
        /// already part of the set of 100 most recent) rollouts are kept for each
        /// service. The rest will be deleted eventually.
        /// 
        /// Operation&lt;response: Rollout&gt;
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Rollout, OperationMetadata>> CreateServiceRolloutAsync(CreateServiceRolloutRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServiceRolloutRequest(ref request, ref callSettings);
            return new lro::Operation<Rollout, OperationMetadata>(await _callCreateServiceRollout.Async(request, callSettings).ConfigureAwait(false), CreateServiceRolloutOperationsClient);
        }

        /// <summary>
        /// Generates and returns a report (errors, warnings and changes from
        /// existing configurations) associated with
        /// GenerateConfigReportRequest.new_value
        /// 
        /// If GenerateConfigReportRequest.old_value is specified,
        /// GenerateConfigReportRequest will contain a single ChangeReport based on the
        /// comparison between GenerateConfigReportRequest.new_value and
        /// GenerateConfigReportRequest.old_value.
        /// If GenerateConfigReportRequest.old_value is not specified, this method
        /// will compare GenerateConfigReportRequest.new_value with the last pushed
        /// service configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateConfigReportResponse GenerateConfigReport(GenerateConfigReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateConfigReportRequest(ref request, ref callSettings);
            return _callGenerateConfigReport.Sync(request, callSettings);
        }

        /// <summary>
        /// Generates and returns a report (errors, warnings and changes from
        /// existing configurations) associated with
        /// GenerateConfigReportRequest.new_value
        /// 
        /// If GenerateConfigReportRequest.old_value is specified,
        /// GenerateConfigReportRequest will contain a single ChangeReport based on the
        /// comparison between GenerateConfigReportRequest.new_value and
        /// GenerateConfigReportRequest.old_value.
        /// If GenerateConfigReportRequest.old_value is not specified, this method
        /// will compare GenerateConfigReportRequest.new_value with the last pushed
        /// service configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateConfigReportResponse> GenerateConfigReportAsync(GenerateConfigReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateConfigReportRequest(ref request, ref callSettings);
            return _callGenerateConfigReport.Async(request, callSettings);
        }
    }

    public partial class ListServicesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListServiceConfigsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListServiceRolloutsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListServicesResponse : gaxgrpc::IPageResponse<ManagedService>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ManagedService> GetEnumerator() => Services.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListServiceConfigsResponse : gaxgrpc::IPageResponse<ga::Service>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ga::Service> GetEnumerator() => ServiceConfigs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListServiceRolloutsResponse : gaxgrpc::IPageResponse<Rollout>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Rollout> GetEnumerator() => Rollouts.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ServiceManager
    {
        public partial class ServiceManagerClient
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

    public static partial class ServiceManager
    {
        public partial class ServiceManagerClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="gciv::IAMPolicy.IAMPolicyClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gciv::IAMPolicy.IAMPolicyClient"/> for the same target as this client.
            /// </returns>
            public virtual gciv::IAMPolicy.IAMPolicyClient CreateIAMPolicyClient() =>
                new gciv::IAMPolicy.IAMPolicyClient(CallInvoker);
        }
    }
}
