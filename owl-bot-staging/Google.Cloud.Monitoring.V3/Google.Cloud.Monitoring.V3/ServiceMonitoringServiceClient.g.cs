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
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Monitoring.V3
{
    /// <summary>Settings for <see cref="ServiceMonitoringServiceClient"/> instances.</summary>
    public sealed partial class ServiceMonitoringServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ServiceMonitoringServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ServiceMonitoringServiceSettings"/>.</returns>
        public static ServiceMonitoringServiceSettings GetDefault() => new ServiceMonitoringServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ServiceMonitoringServiceSettings"/> object with default settings.
        /// </summary>
        public ServiceMonitoringServiceSettings()
        {
        }

        private ServiceMonitoringServiceSettings(ServiceMonitoringServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateServiceSettings = existing.CreateServiceSettings;
            GetServiceSettings = existing.GetServiceSettings;
            ListServicesSettings = existing.ListServicesSettings;
            UpdateServiceSettings = existing.UpdateServiceSettings;
            DeleteServiceSettings = existing.DeleteServiceSettings;
            CreateServiceLevelObjectiveSettings = existing.CreateServiceLevelObjectiveSettings;
            GetServiceLevelObjectiveSettings = existing.GetServiceLevelObjectiveSettings;
            ListServiceLevelObjectivesSettings = existing.ListServiceLevelObjectivesSettings;
            UpdateServiceLevelObjectiveSettings = existing.UpdateServiceLevelObjectiveSettings;
            DeleteServiceLevelObjectiveSettings = existing.DeleteServiceLevelObjectiveSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ServiceMonitoringServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceMonitoringServiceClient.CreateService</c> and <c>ServiceMonitoringServiceClient.CreateServiceAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateServiceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceMonitoringServiceClient.GetService</c> and <c>ServiceMonitoringServiceClient.GetServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetServiceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceMonitoringServiceClient.ListServices</c> and <c>ServiceMonitoringServiceClient.ListServicesAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListServicesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceMonitoringServiceClient.UpdateService</c> and <c>ServiceMonitoringServiceClient.UpdateServiceAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateServiceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceMonitoringServiceClient.DeleteService</c> and <c>ServiceMonitoringServiceClient.DeleteServiceAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteServiceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceMonitoringServiceClient.CreateServiceLevelObjective</c> and
        /// <c>ServiceMonitoringServiceClient.CreateServiceLevelObjectiveAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateServiceLevelObjectiveSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceMonitoringServiceClient.GetServiceLevelObjective</c> and
        /// <c>ServiceMonitoringServiceClient.GetServiceLevelObjectiveAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetServiceLevelObjectiveSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceMonitoringServiceClient.ListServiceLevelObjectives</c> and
        /// <c>ServiceMonitoringServiceClient.ListServiceLevelObjectivesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListServiceLevelObjectivesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceMonitoringServiceClient.UpdateServiceLevelObjective</c> and
        /// <c>ServiceMonitoringServiceClient.UpdateServiceLevelObjectiveAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateServiceLevelObjectiveSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceMonitoringServiceClient.DeleteServiceLevelObjective</c> and
        /// <c>ServiceMonitoringServiceClient.DeleteServiceLevelObjectiveAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteServiceLevelObjectiveSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ServiceMonitoringServiceSettings"/> object.</returns>
        public ServiceMonitoringServiceSettings Clone() => new ServiceMonitoringServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ServiceMonitoringServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class ServiceMonitoringServiceClientBuilder : gaxgrpc::ClientBuilderBase<ServiceMonitoringServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ServiceMonitoringServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ServiceMonitoringServiceClientBuilder() : base(ServiceMonitoringServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ServiceMonitoringServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ServiceMonitoringServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ServiceMonitoringServiceClient Build()
        {
            ServiceMonitoringServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ServiceMonitoringServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ServiceMonitoringServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ServiceMonitoringServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ServiceMonitoringServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ServiceMonitoringServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ServiceMonitoringServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ServiceMonitoringServiceClient.ChannelPool;
    }

    /// <summary>ServiceMonitoringService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The Cloud Monitoring Service-Oriented Monitoring API has endpoints for
    /// managing and querying aspects of a Metrics Scope's services. These include
    /// the `Service`'s monitored resources, its Service-Level Objectives, and a
    /// taxonomy of categorized Health Metrics.
    /// </remarks>
    public abstract partial class ServiceMonitoringServiceClient
    {
        /// <summary>
        /// The default endpoint for the ServiceMonitoringService service, which is a host of
        /// "monitoring.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "monitoring.googleapis.com:443";

        /// <summary>The default ServiceMonitoringService scopes.</summary>
        /// <remarks>
        /// The default ServiceMonitoringService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/monitoring</description></item>
        /// <item><description>https://www.googleapis.com/auth/monitoring.read</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/monitoring",
            "https://www.googleapis.com/auth/monitoring.read",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ServiceMonitoringService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ServiceMonitoringServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ServiceMonitoringServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ServiceMonitoringServiceClient"/>.</returns>
        public static stt::Task<ServiceMonitoringServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ServiceMonitoringServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ServiceMonitoringServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ServiceMonitoringServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ServiceMonitoringServiceClient"/>.</returns>
        public static ServiceMonitoringServiceClient Create() => new ServiceMonitoringServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ServiceMonitoringServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ServiceMonitoringServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ServiceMonitoringServiceClient"/>.</returns>
        internal static ServiceMonitoringServiceClient Create(grpccore::CallInvoker callInvoker, ServiceMonitoringServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ServiceMonitoringService.ServiceMonitoringServiceClient grpcClient = new ServiceMonitoringService.ServiceMonitoringServiceClient(callInvoker);
            return new ServiceMonitoringServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ServiceMonitoringService client</summary>
        public virtual ServiceMonitoringService.ServiceMonitoringServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Create a `Service`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Service CreateService(CreateServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a `Service`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> CreateServiceAsync(CreateServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a `Service`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> CreateServiceAsync(CreateServiceRequest request, st::CancellationToken cancellationToken) =>
            CreateServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a `Service`.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource
        /// [name](https://cloud.google.com/monitoring/api/v3#project_name) of the
        /// parent Metrics Scope. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="service">
        /// Required. The `Service` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Service CreateService(string parent, Service service, gaxgrpc::CallSettings callSettings = null) =>
            CreateService(new CreateServiceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Service = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
            }, callSettings);

        /// <summary>
        /// Create a `Service`.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource
        /// [name](https://cloud.google.com/monitoring/api/v3#project_name) of the
        /// parent Metrics Scope. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="service">
        /// Required. The `Service` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> CreateServiceAsync(string parent, Service service, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceAsync(new CreateServiceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Service = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
            }, callSettings);

        /// <summary>
        /// Create a `Service`.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource
        /// [name](https://cloud.google.com/monitoring/api/v3#project_name) of the
        /// parent Metrics Scope. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="service">
        /// Required. The `Service` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> CreateServiceAsync(string parent, Service service, st::CancellationToken cancellationToken) =>
            CreateServiceAsync(parent, service, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a `Service`.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource
        /// [name](https://cloud.google.com/monitoring/api/v3#project_name) of the
        /// parent Metrics Scope. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="service">
        /// Required. The `Service` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Service CreateService(gagr::ProjectName parent, Service service, gaxgrpc::CallSettings callSettings = null) =>
            CreateService(new CreateServiceRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Service = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
            }, callSettings);

        /// <summary>
        /// Create a `Service`.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource
        /// [name](https://cloud.google.com/monitoring/api/v3#project_name) of the
        /// parent Metrics Scope. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="service">
        /// Required. The `Service` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> CreateServiceAsync(gagr::ProjectName parent, Service service, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceAsync(new CreateServiceRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Service = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
            }, callSettings);

        /// <summary>
        /// Create a `Service`.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource
        /// [name](https://cloud.google.com/monitoring/api/v3#project_name) of the
        /// parent Metrics Scope. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="service">
        /// Required. The `Service` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> CreateServiceAsync(gagr::ProjectName parent, Service service, st::CancellationToken cancellationToken) =>
            CreateServiceAsync(parent, service, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a `Service`.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource
        /// [name](https://cloud.google.com/monitoring/api/v3#project_name) of the
        /// parent Metrics Scope. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="service">
        /// Required. The `Service` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Service CreateService(gagr::OrganizationName parent, Service service, gaxgrpc::CallSettings callSettings = null) =>
            CreateService(new CreateServiceRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Service = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
            }, callSettings);

        /// <summary>
        /// Create a `Service`.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource
        /// [name](https://cloud.google.com/monitoring/api/v3#project_name) of the
        /// parent Metrics Scope. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="service">
        /// Required. The `Service` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> CreateServiceAsync(gagr::OrganizationName parent, Service service, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceAsync(new CreateServiceRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Service = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
            }, callSettings);

        /// <summary>
        /// Create a `Service`.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource
        /// [name](https://cloud.google.com/monitoring/api/v3#project_name) of the
        /// parent Metrics Scope. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="service">
        /// Required. The `Service` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> CreateServiceAsync(gagr::OrganizationName parent, Service service, st::CancellationToken cancellationToken) =>
            CreateServiceAsync(parent, service, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a `Service`.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource
        /// [name](https://cloud.google.com/monitoring/api/v3#project_name) of the
        /// parent Metrics Scope. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="service">
        /// Required. The `Service` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Service CreateService(gagr::FolderName parent, Service service, gaxgrpc::CallSettings callSettings = null) =>
            CreateService(new CreateServiceRequest
            {
                ParentAsFolderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Service = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
            }, callSettings);

        /// <summary>
        /// Create a `Service`.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource
        /// [name](https://cloud.google.com/monitoring/api/v3#project_name) of the
        /// parent Metrics Scope. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="service">
        /// Required. The `Service` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> CreateServiceAsync(gagr::FolderName parent, Service service, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceAsync(new CreateServiceRequest
            {
                ParentAsFolderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Service = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
            }, callSettings);

        /// <summary>
        /// Create a `Service`.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource
        /// [name](https://cloud.google.com/monitoring/api/v3#project_name) of the
        /// parent Metrics Scope. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="service">
        /// Required. The `Service` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> CreateServiceAsync(gagr::FolderName parent, Service service, st::CancellationToken cancellationToken) =>
            CreateServiceAsync(parent, service, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a `Service`.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource
        /// [name](https://cloud.google.com/monitoring/api/v3#project_name) of the
        /// parent Metrics Scope. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="service">
        /// Required. The `Service` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Service CreateService(gax::IResourceName parent, Service service, gaxgrpc::CallSettings callSettings = null) =>
            CreateService(new CreateServiceRequest
            {
                ParentAsResourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Service = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
            }, callSettings);

        /// <summary>
        /// Create a `Service`.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource
        /// [name](https://cloud.google.com/monitoring/api/v3#project_name) of the
        /// parent Metrics Scope. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="service">
        /// Required. The `Service` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> CreateServiceAsync(gax::IResourceName parent, Service service, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceAsync(new CreateServiceRequest
            {
                ParentAsResourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Service = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
            }, callSettings);

        /// <summary>
        /// Create a `Service`.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource
        /// [name](https://cloud.google.com/monitoring/api/v3#project_name) of the
        /// parent Metrics Scope. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="service">
        /// Required. The `Service` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> CreateServiceAsync(gax::IResourceName parent, Service service, st::CancellationToken cancellationToken) =>
            CreateServiceAsync(parent, service, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the named `Service`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Service GetService(GetServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get the named `Service`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> GetServiceAsync(GetServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get the named `Service`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> GetServiceAsync(GetServiceRequest request, st::CancellationToken cancellationToken) =>
            GetServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the named `Service`.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the `Service`. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Service GetService(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetService(new GetServiceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the named `Service`.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the `Service`. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> GetServiceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceAsync(new GetServiceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the named `Service`.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the `Service`. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> GetServiceAsync(string name, st::CancellationToken cancellationToken) =>
            GetServiceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the named `Service`.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the `Service`. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Service GetService(ServiceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetService(new GetServiceRequest
            {
                ServiceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the named `Service`.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the `Service`. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> GetServiceAsync(ServiceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceAsync(new GetServiceRequest
            {
                ServiceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the named `Service`.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the `Service`. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> GetServiceAsync(ServiceName name, st::CancellationToken cancellationToken) =>
            GetServiceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the named `Service`.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the `Service`. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Service GetService(gax::IResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetService(new GetServiceRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the named `Service`.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the `Service`. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> GetServiceAsync(gax::IResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceAsync(new GetServiceRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the named `Service`.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the `Service`. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> GetServiceAsync(gax::IResourceName name, st::CancellationToken cancellationToken) =>
            GetServiceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List `Service`s for this Metrics Scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServicesResponse, Service> ListServices(ListServicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List `Service`s for this Metrics Scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServicesResponse, Service> ListServicesAsync(ListServicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List `Service`s for this Metrics Scope.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent containing the listed services,
        /// either a [project](https://cloud.google.com/monitoring/api/v3#project_name)
        /// or a Monitoring Metrics Scope. The formats are:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// workspaces/[HOST_PROJECT_ID_OR_NUMBER]
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
        /// <returns>A pageable sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServicesResponse, Service> ListServices(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServicesRequest request = new ListServicesRequest
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
            return ListServices(request, callSettings);
        }

        /// <summary>
        /// List `Service`s for this Metrics Scope.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent containing the listed services,
        /// either a [project](https://cloud.google.com/monitoring/api/v3#project_name)
        /// or a Monitoring Metrics Scope. The formats are:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// workspaces/[HOST_PROJECT_ID_OR_NUMBER]
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
        /// <returns>A pageable asynchronous sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServicesResponse, Service> ListServicesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServicesRequest request = new ListServicesRequest
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
            return ListServicesAsync(request, callSettings);
        }

        /// <summary>
        /// List `Service`s for this Metrics Scope.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent containing the listed services,
        /// either a [project](https://cloud.google.com/monitoring/api/v3#project_name)
        /// or a Monitoring Metrics Scope. The formats are:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// workspaces/[HOST_PROJECT_ID_OR_NUMBER]
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
        /// <returns>A pageable sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServicesResponse, Service> ListServices(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServicesRequest request = new ListServicesRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// List `Service`s for this Metrics Scope.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent containing the listed services,
        /// either a [project](https://cloud.google.com/monitoring/api/v3#project_name)
        /// or a Monitoring Metrics Scope. The formats are:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// workspaces/[HOST_PROJECT_ID_OR_NUMBER]
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
        /// <returns>A pageable asynchronous sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServicesResponse, Service> ListServicesAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServicesRequest request = new ListServicesRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// List `Service`s for this Metrics Scope.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent containing the listed services,
        /// either a [project](https://cloud.google.com/monitoring/api/v3#project_name)
        /// or a Monitoring Metrics Scope. The formats are:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// workspaces/[HOST_PROJECT_ID_OR_NUMBER]
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
        /// <returns>A pageable sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServicesResponse, Service> ListServices(gagr::OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServicesRequest request = new ListServicesRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// List `Service`s for this Metrics Scope.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent containing the listed services,
        /// either a [project](https://cloud.google.com/monitoring/api/v3#project_name)
        /// or a Monitoring Metrics Scope. The formats are:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// workspaces/[HOST_PROJECT_ID_OR_NUMBER]
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
        /// <returns>A pageable asynchronous sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServicesResponse, Service> ListServicesAsync(gagr::OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServicesRequest request = new ListServicesRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// List `Service`s for this Metrics Scope.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent containing the listed services,
        /// either a [project](https://cloud.google.com/monitoring/api/v3#project_name)
        /// or a Monitoring Metrics Scope. The formats are:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// workspaces/[HOST_PROJECT_ID_OR_NUMBER]
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
        /// <returns>A pageable sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServicesResponse, Service> ListServices(gagr::FolderName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServicesRequest request = new ListServicesRequest
            {
                ParentAsFolderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// List `Service`s for this Metrics Scope.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent containing the listed services,
        /// either a [project](https://cloud.google.com/monitoring/api/v3#project_name)
        /// or a Monitoring Metrics Scope. The formats are:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// workspaces/[HOST_PROJECT_ID_OR_NUMBER]
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
        /// <returns>A pageable asynchronous sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServicesResponse, Service> ListServicesAsync(gagr::FolderName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServicesRequest request = new ListServicesRequest
            {
                ParentAsFolderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// List `Service`s for this Metrics Scope.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent containing the listed services,
        /// either a [project](https://cloud.google.com/monitoring/api/v3#project_name)
        /// or a Monitoring Metrics Scope. The formats are:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// workspaces/[HOST_PROJECT_ID_OR_NUMBER]
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
        /// <returns>A pageable sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServicesResponse, Service> ListServices(gax::IResourceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServicesRequest request = new ListServicesRequest
            {
                ParentAsResourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// List `Service`s for this Metrics Scope.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent containing the listed services,
        /// either a [project](https://cloud.google.com/monitoring/api/v3#project_name)
        /// or a Monitoring Metrics Scope. The formats are:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// workspaces/[HOST_PROJECT_ID_OR_NUMBER]
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
        /// <returns>A pageable asynchronous sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServicesResponse, Service> ListServicesAsync(gax::IResourceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServicesRequest request = new ListServicesRequest
            {
                ParentAsResourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Update this `Service`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Service UpdateService(UpdateServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update this `Service`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> UpdateServiceAsync(UpdateServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update this `Service`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> UpdateServiceAsync(UpdateServiceRequest request, st::CancellationToken cancellationToken) =>
            UpdateServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update this `Service`.
        /// </summary>
        /// <param name="service">
        /// Required. The `Service` to draw updates from.
        /// The given `name` specifies the resource to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Service UpdateService(Service service, gaxgrpc::CallSettings callSettings = null) =>
            UpdateService(new UpdateServiceRequest
            {
                Service = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
            }, callSettings);

        /// <summary>
        /// Update this `Service`.
        /// </summary>
        /// <param name="service">
        /// Required. The `Service` to draw updates from.
        /// The given `name` specifies the resource to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> UpdateServiceAsync(Service service, gaxgrpc::CallSettings callSettings = null) =>
            UpdateServiceAsync(new UpdateServiceRequest
            {
                Service = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
            }, callSettings);

        /// <summary>
        /// Update this `Service`.
        /// </summary>
        /// <param name="service">
        /// Required. The `Service` to draw updates from.
        /// The given `name` specifies the resource to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> UpdateServiceAsync(Service service, st::CancellationToken cancellationToken) =>
            UpdateServiceAsync(service, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Soft delete this `Service`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteService(DeleteServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Soft delete this `Service`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteServiceAsync(DeleteServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Soft delete this `Service`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteServiceAsync(DeleteServiceRequest request, st::CancellationToken cancellationToken) =>
            DeleteServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Soft delete this `Service`.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the `Service` to delete. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteService(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteService(new DeleteServiceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Soft delete this `Service`.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the `Service` to delete. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteServiceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceAsync(new DeleteServiceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Soft delete this `Service`.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the `Service` to delete. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteServiceAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteServiceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Soft delete this `Service`.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the `Service` to delete. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteService(ServiceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteService(new DeleteServiceRequest
            {
                ServiceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Soft delete this `Service`.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the `Service` to delete. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteServiceAsync(ServiceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceAsync(new DeleteServiceRequest
            {
                ServiceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Soft delete this `Service`.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the `Service` to delete. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteServiceAsync(ServiceName name, st::CancellationToken cancellationToken) =>
            DeleteServiceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Soft delete this `Service`.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the `Service` to delete. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteService(gax::IResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteService(new DeleteServiceRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Soft delete this `Service`.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the `Service` to delete. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteServiceAsync(gax::IResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceAsync(new DeleteServiceRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Soft delete this `Service`.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the `Service` to delete. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteServiceAsync(gax::IResourceName name, st::CancellationToken cancellationToken) =>
            DeleteServiceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a `ServiceLevelObjective` for the given `Service`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceLevelObjective CreateServiceLevelObjective(CreateServiceLevelObjectiveRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a `ServiceLevelObjective` for the given `Service`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceLevelObjective> CreateServiceLevelObjectiveAsync(CreateServiceLevelObjectiveRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a `ServiceLevelObjective` for the given `Service`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceLevelObjective> CreateServiceLevelObjectiveAsync(CreateServiceLevelObjectiveRequest request, st::CancellationToken cancellationToken) =>
            CreateServiceLevelObjectiveAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a `ServiceLevelObjective` for the given `Service`.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent `Service`. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
        /// </param>
        /// <param name="serviceLevelObjective">
        /// Required. The `ServiceLevelObjective` to create.
        /// The provided `name` will be respected if no `ServiceLevelObjective` exists
        /// with this name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceLevelObjective CreateServiceLevelObjective(string parent, ServiceLevelObjective serviceLevelObjective, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceLevelObjective(new CreateServiceLevelObjectiveRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ServiceLevelObjective = gax::GaxPreconditions.CheckNotNull(serviceLevelObjective, nameof(serviceLevelObjective)),
            }, callSettings);

        /// <summary>
        /// Create a `ServiceLevelObjective` for the given `Service`.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent `Service`. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
        /// </param>
        /// <param name="serviceLevelObjective">
        /// Required. The `ServiceLevelObjective` to create.
        /// The provided `name` will be respected if no `ServiceLevelObjective` exists
        /// with this name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceLevelObjective> CreateServiceLevelObjectiveAsync(string parent, ServiceLevelObjective serviceLevelObjective, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceLevelObjectiveAsync(new CreateServiceLevelObjectiveRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ServiceLevelObjective = gax::GaxPreconditions.CheckNotNull(serviceLevelObjective, nameof(serviceLevelObjective)),
            }, callSettings);

        /// <summary>
        /// Create a `ServiceLevelObjective` for the given `Service`.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent `Service`. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
        /// </param>
        /// <param name="serviceLevelObjective">
        /// Required. The `ServiceLevelObjective` to create.
        /// The provided `name` will be respected if no `ServiceLevelObjective` exists
        /// with this name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceLevelObjective> CreateServiceLevelObjectiveAsync(string parent, ServiceLevelObjective serviceLevelObjective, st::CancellationToken cancellationToken) =>
            CreateServiceLevelObjectiveAsync(parent, serviceLevelObjective, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a `ServiceLevelObjective` for the given `Service`.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent `Service`. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
        /// </param>
        /// <param name="serviceLevelObjective">
        /// Required. The `ServiceLevelObjective` to create.
        /// The provided `name` will be respected if no `ServiceLevelObjective` exists
        /// with this name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceLevelObjective CreateServiceLevelObjective(ServiceName parent, ServiceLevelObjective serviceLevelObjective, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceLevelObjective(new CreateServiceLevelObjectiveRequest
            {
                ParentAsServiceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ServiceLevelObjective = gax::GaxPreconditions.CheckNotNull(serviceLevelObjective, nameof(serviceLevelObjective)),
            }, callSettings);

        /// <summary>
        /// Create a `ServiceLevelObjective` for the given `Service`.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent `Service`. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
        /// </param>
        /// <param name="serviceLevelObjective">
        /// Required. The `ServiceLevelObjective` to create.
        /// The provided `name` will be respected if no `ServiceLevelObjective` exists
        /// with this name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceLevelObjective> CreateServiceLevelObjectiveAsync(ServiceName parent, ServiceLevelObjective serviceLevelObjective, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceLevelObjectiveAsync(new CreateServiceLevelObjectiveRequest
            {
                ParentAsServiceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ServiceLevelObjective = gax::GaxPreconditions.CheckNotNull(serviceLevelObjective, nameof(serviceLevelObjective)),
            }, callSettings);

        /// <summary>
        /// Create a `ServiceLevelObjective` for the given `Service`.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent `Service`. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
        /// </param>
        /// <param name="serviceLevelObjective">
        /// Required. The `ServiceLevelObjective` to create.
        /// The provided `name` will be respected if no `ServiceLevelObjective` exists
        /// with this name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceLevelObjective> CreateServiceLevelObjectiveAsync(ServiceName parent, ServiceLevelObjective serviceLevelObjective, st::CancellationToken cancellationToken) =>
            CreateServiceLevelObjectiveAsync(parent, serviceLevelObjective, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a `ServiceLevelObjective` for the given `Service`.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent `Service`. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
        /// </param>
        /// <param name="serviceLevelObjective">
        /// Required. The `ServiceLevelObjective` to create.
        /// The provided `name` will be respected if no `ServiceLevelObjective` exists
        /// with this name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceLevelObjective CreateServiceLevelObjective(gax::IResourceName parent, ServiceLevelObjective serviceLevelObjective, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceLevelObjective(new CreateServiceLevelObjectiveRequest
            {
                ParentAsResourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ServiceLevelObjective = gax::GaxPreconditions.CheckNotNull(serviceLevelObjective, nameof(serviceLevelObjective)),
            }, callSettings);

        /// <summary>
        /// Create a `ServiceLevelObjective` for the given `Service`.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent `Service`. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
        /// </param>
        /// <param name="serviceLevelObjective">
        /// Required. The `ServiceLevelObjective` to create.
        /// The provided `name` will be respected if no `ServiceLevelObjective` exists
        /// with this name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceLevelObjective> CreateServiceLevelObjectiveAsync(gax::IResourceName parent, ServiceLevelObjective serviceLevelObjective, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceLevelObjectiveAsync(new CreateServiceLevelObjectiveRequest
            {
                ParentAsResourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ServiceLevelObjective = gax::GaxPreconditions.CheckNotNull(serviceLevelObjective, nameof(serviceLevelObjective)),
            }, callSettings);

        /// <summary>
        /// Create a `ServiceLevelObjective` for the given `Service`.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent `Service`. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
        /// </param>
        /// <param name="serviceLevelObjective">
        /// Required. The `ServiceLevelObjective` to create.
        /// The provided `name` will be respected if no `ServiceLevelObjective` exists
        /// with this name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceLevelObjective> CreateServiceLevelObjectiveAsync(gax::IResourceName parent, ServiceLevelObjective serviceLevelObjective, st::CancellationToken cancellationToken) =>
            CreateServiceLevelObjectiveAsync(parent, serviceLevelObjective, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a `ServiceLevelObjective` by name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceLevelObjective GetServiceLevelObjective(GetServiceLevelObjectiveRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a `ServiceLevelObjective` by name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceLevelObjective> GetServiceLevelObjectiveAsync(GetServiceLevelObjectiveRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a `ServiceLevelObjective` by name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceLevelObjective> GetServiceLevelObjectiveAsync(GetServiceLevelObjectiveRequest request, st::CancellationToken cancellationToken) =>
            GetServiceLevelObjectiveAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a `ServiceLevelObjective` by name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the `ServiceLevelObjective` to get. The format
        /// is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]/serviceLevelObjectives/[SLO_NAME]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceLevelObjective GetServiceLevelObjective(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceLevelObjective(new GetServiceLevelObjectiveRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a `ServiceLevelObjective` by name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the `ServiceLevelObjective` to get. The format
        /// is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]/serviceLevelObjectives/[SLO_NAME]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceLevelObjective> GetServiceLevelObjectiveAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceLevelObjectiveAsync(new GetServiceLevelObjectiveRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a `ServiceLevelObjective` by name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the `ServiceLevelObjective` to get. The format
        /// is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]/serviceLevelObjectives/[SLO_NAME]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceLevelObjective> GetServiceLevelObjectiveAsync(string name, st::CancellationToken cancellationToken) =>
            GetServiceLevelObjectiveAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a `ServiceLevelObjective` by name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the `ServiceLevelObjective` to get. The format
        /// is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]/serviceLevelObjectives/[SLO_NAME]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceLevelObjective GetServiceLevelObjective(ServiceLevelObjectiveName name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceLevelObjective(new GetServiceLevelObjectiveRequest
            {
                ServiceLevelObjectiveName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a `ServiceLevelObjective` by name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the `ServiceLevelObjective` to get. The format
        /// is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]/serviceLevelObjectives/[SLO_NAME]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceLevelObjective> GetServiceLevelObjectiveAsync(ServiceLevelObjectiveName name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceLevelObjectiveAsync(new GetServiceLevelObjectiveRequest
            {
                ServiceLevelObjectiveName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a `ServiceLevelObjective` by name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the `ServiceLevelObjective` to get. The format
        /// is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]/serviceLevelObjectives/[SLO_NAME]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceLevelObjective> GetServiceLevelObjectiveAsync(ServiceLevelObjectiveName name, st::CancellationToken cancellationToken) =>
            GetServiceLevelObjectiveAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a `ServiceLevelObjective` by name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the `ServiceLevelObjective` to get. The format
        /// is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]/serviceLevelObjectives/[SLO_NAME]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceLevelObjective GetServiceLevelObjective(gax::IResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceLevelObjective(new GetServiceLevelObjectiveRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a `ServiceLevelObjective` by name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the `ServiceLevelObjective` to get. The format
        /// is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]/serviceLevelObjectives/[SLO_NAME]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceLevelObjective> GetServiceLevelObjectiveAsync(gax::IResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceLevelObjectiveAsync(new GetServiceLevelObjectiveRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a `ServiceLevelObjective` by name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the `ServiceLevelObjective` to get. The format
        /// is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]/serviceLevelObjectives/[SLO_NAME]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceLevelObjective> GetServiceLevelObjectiveAsync(gax::IResourceName name, st::CancellationToken cancellationToken) =>
            GetServiceLevelObjectiveAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List the `ServiceLevelObjective`s for the given `Service`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ServiceLevelObjective"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServiceLevelObjectivesResponse, ServiceLevelObjective> ListServiceLevelObjectives(ListServiceLevelObjectivesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List the `ServiceLevelObjective`s for the given `Service`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ServiceLevelObjective"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServiceLevelObjectivesResponse, ServiceLevelObjective> ListServiceLevelObjectivesAsync(ListServiceLevelObjectivesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List the `ServiceLevelObjective`s for the given `Service`.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent containing the listed SLOs, either a
        /// project or a Monitoring Metrics Scope. The formats are:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
        /// workspaces/[HOST_PROJECT_ID_OR_NUMBER]/services/-
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
        /// <returns>A pageable sequence of <see cref="ServiceLevelObjective"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServiceLevelObjectivesResponse, ServiceLevelObjective> ListServiceLevelObjectives(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServiceLevelObjectivesRequest request = new ListServiceLevelObjectivesRequest
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
            return ListServiceLevelObjectives(request, callSettings);
        }

        /// <summary>
        /// List the `ServiceLevelObjective`s for the given `Service`.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent containing the listed SLOs, either a
        /// project or a Monitoring Metrics Scope. The formats are:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
        /// workspaces/[HOST_PROJECT_ID_OR_NUMBER]/services/-
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
        /// <returns>A pageable asynchronous sequence of <see cref="ServiceLevelObjective"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServiceLevelObjectivesResponse, ServiceLevelObjective> ListServiceLevelObjectivesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServiceLevelObjectivesRequest request = new ListServiceLevelObjectivesRequest
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
            return ListServiceLevelObjectivesAsync(request, callSettings);
        }

        /// <summary>
        /// List the `ServiceLevelObjective`s for the given `Service`.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent containing the listed SLOs, either a
        /// project or a Monitoring Metrics Scope. The formats are:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
        /// workspaces/[HOST_PROJECT_ID_OR_NUMBER]/services/-
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
        /// <returns>A pageable sequence of <see cref="ServiceLevelObjective"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServiceLevelObjectivesResponse, ServiceLevelObjective> ListServiceLevelObjectives(ServiceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServiceLevelObjectivesRequest request = new ListServiceLevelObjectivesRequest
            {
                ParentAsServiceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListServiceLevelObjectives(request, callSettings);
        }

        /// <summary>
        /// List the `ServiceLevelObjective`s for the given `Service`.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent containing the listed SLOs, either a
        /// project or a Monitoring Metrics Scope. The formats are:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
        /// workspaces/[HOST_PROJECT_ID_OR_NUMBER]/services/-
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
        /// <returns>A pageable asynchronous sequence of <see cref="ServiceLevelObjective"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServiceLevelObjectivesResponse, ServiceLevelObjective> ListServiceLevelObjectivesAsync(ServiceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServiceLevelObjectivesRequest request = new ListServiceLevelObjectivesRequest
            {
                ParentAsServiceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListServiceLevelObjectivesAsync(request, callSettings);
        }

        /// <summary>
        /// List the `ServiceLevelObjective`s for the given `Service`.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent containing the listed SLOs, either a
        /// project or a Monitoring Metrics Scope. The formats are:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
        /// workspaces/[HOST_PROJECT_ID_OR_NUMBER]/services/-
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
        /// <returns>A pageable sequence of <see cref="ServiceLevelObjective"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServiceLevelObjectivesResponse, ServiceLevelObjective> ListServiceLevelObjectives(gax::IResourceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServiceLevelObjectivesRequest request = new ListServiceLevelObjectivesRequest
            {
                ParentAsResourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListServiceLevelObjectives(request, callSettings);
        }

        /// <summary>
        /// List the `ServiceLevelObjective`s for the given `Service`.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent containing the listed SLOs, either a
        /// project or a Monitoring Metrics Scope. The formats are:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
        /// workspaces/[HOST_PROJECT_ID_OR_NUMBER]/services/-
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
        /// <returns>A pageable asynchronous sequence of <see cref="ServiceLevelObjective"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServiceLevelObjectivesResponse, ServiceLevelObjective> ListServiceLevelObjectivesAsync(gax::IResourceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServiceLevelObjectivesRequest request = new ListServiceLevelObjectivesRequest
            {
                ParentAsResourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListServiceLevelObjectivesAsync(request, callSettings);
        }

        /// <summary>
        /// Update the given `ServiceLevelObjective`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceLevelObjective UpdateServiceLevelObjective(UpdateServiceLevelObjectiveRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update the given `ServiceLevelObjective`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceLevelObjective> UpdateServiceLevelObjectiveAsync(UpdateServiceLevelObjectiveRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update the given `ServiceLevelObjective`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceLevelObjective> UpdateServiceLevelObjectiveAsync(UpdateServiceLevelObjectiveRequest request, st::CancellationToken cancellationToken) =>
            UpdateServiceLevelObjectiveAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update the given `ServiceLevelObjective`.
        /// </summary>
        /// <param name="serviceLevelObjective">
        /// Required. The `ServiceLevelObjective` to draw updates from.
        /// The given `name` specifies the resource to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceLevelObjective UpdateServiceLevelObjective(ServiceLevelObjective serviceLevelObjective, gaxgrpc::CallSettings callSettings = null) =>
            UpdateServiceLevelObjective(new UpdateServiceLevelObjectiveRequest
            {
                ServiceLevelObjective = gax::GaxPreconditions.CheckNotNull(serviceLevelObjective, nameof(serviceLevelObjective)),
            }, callSettings);

        /// <summary>
        /// Update the given `ServiceLevelObjective`.
        /// </summary>
        /// <param name="serviceLevelObjective">
        /// Required. The `ServiceLevelObjective` to draw updates from.
        /// The given `name` specifies the resource to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceLevelObjective> UpdateServiceLevelObjectiveAsync(ServiceLevelObjective serviceLevelObjective, gaxgrpc::CallSettings callSettings = null) =>
            UpdateServiceLevelObjectiveAsync(new UpdateServiceLevelObjectiveRequest
            {
                ServiceLevelObjective = gax::GaxPreconditions.CheckNotNull(serviceLevelObjective, nameof(serviceLevelObjective)),
            }, callSettings);

        /// <summary>
        /// Update the given `ServiceLevelObjective`.
        /// </summary>
        /// <param name="serviceLevelObjective">
        /// Required. The `ServiceLevelObjective` to draw updates from.
        /// The given `name` specifies the resource to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceLevelObjective> UpdateServiceLevelObjectiveAsync(ServiceLevelObjective serviceLevelObjective, st::CancellationToken cancellationToken) =>
            UpdateServiceLevelObjectiveAsync(serviceLevelObjective, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete the given `ServiceLevelObjective`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteServiceLevelObjective(DeleteServiceLevelObjectiveRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete the given `ServiceLevelObjective`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteServiceLevelObjectiveAsync(DeleteServiceLevelObjectiveRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete the given `ServiceLevelObjective`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteServiceLevelObjectiveAsync(DeleteServiceLevelObjectiveRequest request, st::CancellationToken cancellationToken) =>
            DeleteServiceLevelObjectiveAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete the given `ServiceLevelObjective`.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the `ServiceLevelObjective` to delete. The
        /// format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]/serviceLevelObjectives/[SLO_NAME]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteServiceLevelObjective(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceLevelObjective(new DeleteServiceLevelObjectiveRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete the given `ServiceLevelObjective`.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the `ServiceLevelObjective` to delete. The
        /// format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]/serviceLevelObjectives/[SLO_NAME]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteServiceLevelObjectiveAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceLevelObjectiveAsync(new DeleteServiceLevelObjectiveRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete the given `ServiceLevelObjective`.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the `ServiceLevelObjective` to delete. The
        /// format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]/serviceLevelObjectives/[SLO_NAME]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteServiceLevelObjectiveAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteServiceLevelObjectiveAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete the given `ServiceLevelObjective`.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the `ServiceLevelObjective` to delete. The
        /// format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]/serviceLevelObjectives/[SLO_NAME]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteServiceLevelObjective(ServiceLevelObjectiveName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceLevelObjective(new DeleteServiceLevelObjectiveRequest
            {
                ServiceLevelObjectiveName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete the given `ServiceLevelObjective`.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the `ServiceLevelObjective` to delete. The
        /// format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]/serviceLevelObjectives/[SLO_NAME]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteServiceLevelObjectiveAsync(ServiceLevelObjectiveName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceLevelObjectiveAsync(new DeleteServiceLevelObjectiveRequest
            {
                ServiceLevelObjectiveName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete the given `ServiceLevelObjective`.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the `ServiceLevelObjective` to delete. The
        /// format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]/serviceLevelObjectives/[SLO_NAME]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteServiceLevelObjectiveAsync(ServiceLevelObjectiveName name, st::CancellationToken cancellationToken) =>
            DeleteServiceLevelObjectiveAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete the given `ServiceLevelObjective`.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the `ServiceLevelObjective` to delete. The
        /// format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]/serviceLevelObjectives/[SLO_NAME]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteServiceLevelObjective(gax::IResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceLevelObjective(new DeleteServiceLevelObjectiveRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete the given `ServiceLevelObjective`.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the `ServiceLevelObjective` to delete. The
        /// format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]/serviceLevelObjectives/[SLO_NAME]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteServiceLevelObjectiveAsync(gax::IResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceLevelObjectiveAsync(new DeleteServiceLevelObjectiveRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete the given `ServiceLevelObjective`.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the `ServiceLevelObjective` to delete. The
        /// format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]/serviceLevelObjectives/[SLO_NAME]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteServiceLevelObjectiveAsync(gax::IResourceName name, st::CancellationToken cancellationToken) =>
            DeleteServiceLevelObjectiveAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ServiceMonitoringService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The Cloud Monitoring Service-Oriented Monitoring API has endpoints for
    /// managing and querying aspects of a Metrics Scope's services. These include
    /// the `Service`'s monitored resources, its Service-Level Objectives, and a
    /// taxonomy of categorized Health Metrics.
    /// </remarks>
    public sealed partial class ServiceMonitoringServiceClientImpl : ServiceMonitoringServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateServiceRequest, Service> _callCreateService;

        private readonly gaxgrpc::ApiCall<GetServiceRequest, Service> _callGetService;

        private readonly gaxgrpc::ApiCall<ListServicesRequest, ListServicesResponse> _callListServices;

        private readonly gaxgrpc::ApiCall<UpdateServiceRequest, Service> _callUpdateService;

        private readonly gaxgrpc::ApiCall<DeleteServiceRequest, wkt::Empty> _callDeleteService;

        private readonly gaxgrpc::ApiCall<CreateServiceLevelObjectiveRequest, ServiceLevelObjective> _callCreateServiceLevelObjective;

        private readonly gaxgrpc::ApiCall<GetServiceLevelObjectiveRequest, ServiceLevelObjective> _callGetServiceLevelObjective;

        private readonly gaxgrpc::ApiCall<ListServiceLevelObjectivesRequest, ListServiceLevelObjectivesResponse> _callListServiceLevelObjectives;

        private readonly gaxgrpc::ApiCall<UpdateServiceLevelObjectiveRequest, ServiceLevelObjective> _callUpdateServiceLevelObjective;

        private readonly gaxgrpc::ApiCall<DeleteServiceLevelObjectiveRequest, wkt::Empty> _callDeleteServiceLevelObjective;

        /// <summary>
        /// Constructs a client wrapper for the ServiceMonitoringService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="ServiceMonitoringServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ServiceMonitoringServiceClientImpl(ServiceMonitoringService.ServiceMonitoringServiceClient grpcClient, ServiceMonitoringServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ServiceMonitoringServiceSettings effectiveSettings = settings ?? ServiceMonitoringServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callCreateService = clientHelper.BuildApiCall<CreateServiceRequest, Service>("CreateService", grpcClient.CreateServiceAsync, grpcClient.CreateService, effectiveSettings.CreateServiceSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateService);
            Modify_CreateServiceApiCall(ref _callCreateService);
            _callGetService = clientHelper.BuildApiCall<GetServiceRequest, Service>("GetService", grpcClient.GetServiceAsync, grpcClient.GetService, effectiveSettings.GetServiceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetService);
            Modify_GetServiceApiCall(ref _callGetService);
            _callListServices = clientHelper.BuildApiCall<ListServicesRequest, ListServicesResponse>("ListServices", grpcClient.ListServicesAsync, grpcClient.ListServices, effectiveSettings.ListServicesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListServices);
            Modify_ListServicesApiCall(ref _callListServices);
            _callUpdateService = clientHelper.BuildApiCall<UpdateServiceRequest, Service>("UpdateService", grpcClient.UpdateServiceAsync, grpcClient.UpdateService, effectiveSettings.UpdateServiceSettings).WithGoogleRequestParam("service.name", request => request.Service?.Name);
            Modify_ApiCall(ref _callUpdateService);
            Modify_UpdateServiceApiCall(ref _callUpdateService);
            _callDeleteService = clientHelper.BuildApiCall<DeleteServiceRequest, wkt::Empty>("DeleteService", grpcClient.DeleteServiceAsync, grpcClient.DeleteService, effectiveSettings.DeleteServiceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteService);
            Modify_DeleteServiceApiCall(ref _callDeleteService);
            _callCreateServiceLevelObjective = clientHelper.BuildApiCall<CreateServiceLevelObjectiveRequest, ServiceLevelObjective>("CreateServiceLevelObjective", grpcClient.CreateServiceLevelObjectiveAsync, grpcClient.CreateServiceLevelObjective, effectiveSettings.CreateServiceLevelObjectiveSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateServiceLevelObjective);
            Modify_CreateServiceLevelObjectiveApiCall(ref _callCreateServiceLevelObjective);
            _callGetServiceLevelObjective = clientHelper.BuildApiCall<GetServiceLevelObjectiveRequest, ServiceLevelObjective>("GetServiceLevelObjective", grpcClient.GetServiceLevelObjectiveAsync, grpcClient.GetServiceLevelObjective, effectiveSettings.GetServiceLevelObjectiveSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetServiceLevelObjective);
            Modify_GetServiceLevelObjectiveApiCall(ref _callGetServiceLevelObjective);
            _callListServiceLevelObjectives = clientHelper.BuildApiCall<ListServiceLevelObjectivesRequest, ListServiceLevelObjectivesResponse>("ListServiceLevelObjectives", grpcClient.ListServiceLevelObjectivesAsync, grpcClient.ListServiceLevelObjectives, effectiveSettings.ListServiceLevelObjectivesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListServiceLevelObjectives);
            Modify_ListServiceLevelObjectivesApiCall(ref _callListServiceLevelObjectives);
            _callUpdateServiceLevelObjective = clientHelper.BuildApiCall<UpdateServiceLevelObjectiveRequest, ServiceLevelObjective>("UpdateServiceLevelObjective", grpcClient.UpdateServiceLevelObjectiveAsync, grpcClient.UpdateServiceLevelObjective, effectiveSettings.UpdateServiceLevelObjectiveSettings).WithGoogleRequestParam("service_level_objective.name", request => request.ServiceLevelObjective?.Name);
            Modify_ApiCall(ref _callUpdateServiceLevelObjective);
            Modify_UpdateServiceLevelObjectiveApiCall(ref _callUpdateServiceLevelObjective);
            _callDeleteServiceLevelObjective = clientHelper.BuildApiCall<DeleteServiceLevelObjectiveRequest, wkt::Empty>("DeleteServiceLevelObjective", grpcClient.DeleteServiceLevelObjectiveAsync, grpcClient.DeleteServiceLevelObjective, effectiveSettings.DeleteServiceLevelObjectiveSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteServiceLevelObjective);
            Modify_DeleteServiceLevelObjectiveApiCall(ref _callDeleteServiceLevelObjective);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateServiceApiCall(ref gaxgrpc::ApiCall<CreateServiceRequest, Service> call);

        partial void Modify_GetServiceApiCall(ref gaxgrpc::ApiCall<GetServiceRequest, Service> call);

        partial void Modify_ListServicesApiCall(ref gaxgrpc::ApiCall<ListServicesRequest, ListServicesResponse> call);

        partial void Modify_UpdateServiceApiCall(ref gaxgrpc::ApiCall<UpdateServiceRequest, Service> call);

        partial void Modify_DeleteServiceApiCall(ref gaxgrpc::ApiCall<DeleteServiceRequest, wkt::Empty> call);

        partial void Modify_CreateServiceLevelObjectiveApiCall(ref gaxgrpc::ApiCall<CreateServiceLevelObjectiveRequest, ServiceLevelObjective> call);

        partial void Modify_GetServiceLevelObjectiveApiCall(ref gaxgrpc::ApiCall<GetServiceLevelObjectiveRequest, ServiceLevelObjective> call);

        partial void Modify_ListServiceLevelObjectivesApiCall(ref gaxgrpc::ApiCall<ListServiceLevelObjectivesRequest, ListServiceLevelObjectivesResponse> call);

        partial void Modify_UpdateServiceLevelObjectiveApiCall(ref gaxgrpc::ApiCall<UpdateServiceLevelObjectiveRequest, ServiceLevelObjective> call);

        partial void Modify_DeleteServiceLevelObjectiveApiCall(ref gaxgrpc::ApiCall<DeleteServiceLevelObjectiveRequest, wkt::Empty> call);

        partial void OnConstruction(ServiceMonitoringService.ServiceMonitoringServiceClient grpcClient, ServiceMonitoringServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ServiceMonitoringService client</summary>
        public override ServiceMonitoringService.ServiceMonitoringServiceClient GrpcClient { get; }

        partial void Modify_CreateServiceRequest(ref CreateServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetServiceRequest(ref GetServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListServicesRequest(ref ListServicesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateServiceRequest(ref UpdateServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteServiceRequest(ref DeleteServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateServiceLevelObjectiveRequest(ref CreateServiceLevelObjectiveRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetServiceLevelObjectiveRequest(ref GetServiceLevelObjectiveRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListServiceLevelObjectivesRequest(ref ListServiceLevelObjectivesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateServiceLevelObjectiveRequest(ref UpdateServiceLevelObjectiveRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteServiceLevelObjectiveRequest(ref DeleteServiceLevelObjectiveRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Create a `Service`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Service CreateService(CreateServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServiceRequest(ref request, ref callSettings);
            return _callCreateService.Sync(request, callSettings);
        }

        /// <summary>
        /// Create a `Service`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Service> CreateServiceAsync(CreateServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServiceRequest(ref request, ref callSettings);
            return _callCreateService.Async(request, callSettings);
        }

        /// <summary>
        /// Get the named `Service`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Service GetService(GetServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceRequest(ref request, ref callSettings);
            return _callGetService.Sync(request, callSettings);
        }

        /// <summary>
        /// Get the named `Service`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Service> GetServiceAsync(GetServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceRequest(ref request, ref callSettings);
            return _callGetService.Async(request, callSettings);
        }

        /// <summary>
        /// List `Service`s for this Metrics Scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Service"/> resources.</returns>
        public override gax::PagedEnumerable<ListServicesResponse, Service> ListServices(ListServicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServicesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListServicesRequest, ListServicesResponse, Service>(_callListServices, request, callSettings);
        }

        /// <summary>
        /// List `Service`s for this Metrics Scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Service"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListServicesResponse, Service> ListServicesAsync(ListServicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServicesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListServicesRequest, ListServicesResponse, Service>(_callListServices, request, callSettings);
        }

        /// <summary>
        /// Update this `Service`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Service UpdateService(UpdateServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateServiceRequest(ref request, ref callSettings);
            return _callUpdateService.Sync(request, callSettings);
        }

        /// <summary>
        /// Update this `Service`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Service> UpdateServiceAsync(UpdateServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateServiceRequest(ref request, ref callSettings);
            return _callUpdateService.Async(request, callSettings);
        }

        /// <summary>
        /// Soft delete this `Service`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteService(DeleteServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServiceRequest(ref request, ref callSettings);
            _callDeleteService.Sync(request, callSettings);
        }

        /// <summary>
        /// Soft delete this `Service`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteServiceAsync(DeleteServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServiceRequest(ref request, ref callSettings);
            return _callDeleteService.Async(request, callSettings);
        }

        /// <summary>
        /// Create a `ServiceLevelObjective` for the given `Service`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ServiceLevelObjective CreateServiceLevelObjective(CreateServiceLevelObjectiveRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServiceLevelObjectiveRequest(ref request, ref callSettings);
            return _callCreateServiceLevelObjective.Sync(request, callSettings);
        }

        /// <summary>
        /// Create a `ServiceLevelObjective` for the given `Service`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ServiceLevelObjective> CreateServiceLevelObjectiveAsync(CreateServiceLevelObjectiveRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServiceLevelObjectiveRequest(ref request, ref callSettings);
            return _callCreateServiceLevelObjective.Async(request, callSettings);
        }

        /// <summary>
        /// Get a `ServiceLevelObjective` by name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ServiceLevelObjective GetServiceLevelObjective(GetServiceLevelObjectiveRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceLevelObjectiveRequest(ref request, ref callSettings);
            return _callGetServiceLevelObjective.Sync(request, callSettings);
        }

        /// <summary>
        /// Get a `ServiceLevelObjective` by name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ServiceLevelObjective> GetServiceLevelObjectiveAsync(GetServiceLevelObjectiveRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceLevelObjectiveRequest(ref request, ref callSettings);
            return _callGetServiceLevelObjective.Async(request, callSettings);
        }

        /// <summary>
        /// List the `ServiceLevelObjective`s for the given `Service`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ServiceLevelObjective"/> resources.</returns>
        public override gax::PagedEnumerable<ListServiceLevelObjectivesResponse, ServiceLevelObjective> ListServiceLevelObjectives(ListServiceLevelObjectivesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServiceLevelObjectivesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListServiceLevelObjectivesRequest, ListServiceLevelObjectivesResponse, ServiceLevelObjective>(_callListServiceLevelObjectives, request, callSettings);
        }

        /// <summary>
        /// List the `ServiceLevelObjective`s for the given `Service`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ServiceLevelObjective"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListServiceLevelObjectivesResponse, ServiceLevelObjective> ListServiceLevelObjectivesAsync(ListServiceLevelObjectivesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServiceLevelObjectivesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListServiceLevelObjectivesRequest, ListServiceLevelObjectivesResponse, ServiceLevelObjective>(_callListServiceLevelObjectives, request, callSettings);
        }

        /// <summary>
        /// Update the given `ServiceLevelObjective`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ServiceLevelObjective UpdateServiceLevelObjective(UpdateServiceLevelObjectiveRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateServiceLevelObjectiveRequest(ref request, ref callSettings);
            return _callUpdateServiceLevelObjective.Sync(request, callSettings);
        }

        /// <summary>
        /// Update the given `ServiceLevelObjective`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ServiceLevelObjective> UpdateServiceLevelObjectiveAsync(UpdateServiceLevelObjectiveRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateServiceLevelObjectiveRequest(ref request, ref callSettings);
            return _callUpdateServiceLevelObjective.Async(request, callSettings);
        }

        /// <summary>
        /// Delete the given `ServiceLevelObjective`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteServiceLevelObjective(DeleteServiceLevelObjectiveRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServiceLevelObjectiveRequest(ref request, ref callSettings);
            _callDeleteServiceLevelObjective.Sync(request, callSettings);
        }

        /// <summary>
        /// Delete the given `ServiceLevelObjective`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteServiceLevelObjectiveAsync(DeleteServiceLevelObjectiveRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServiceLevelObjectiveRequest(ref request, ref callSettings);
            return _callDeleteServiceLevelObjective.Async(request, callSettings);
        }
    }

    public partial class ListServicesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListServiceLevelObjectivesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListServicesResponse : gaxgrpc::IPageResponse<Service>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Service> GetEnumerator() => Services.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListServiceLevelObjectivesResponse : gaxgrpc::IPageResponse<ServiceLevelObjective>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ServiceLevelObjective> GetEnumerator() => ServiceLevelObjectives.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
