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
using lro = Google.LongRunning;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.ServiceUsage.V1
{
    /// <summary>Settings for <see cref="ServiceUsageClient"/> instances.</summary>
    public sealed partial class ServiceUsageSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ServiceUsageSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ServiceUsageSettings"/>.</returns>
        public static ServiceUsageSettings GetDefault() => new ServiceUsageSettings();

        /// <summary>Constructs a new <see cref="ServiceUsageSettings"/> object with default settings.</summary>
        public ServiceUsageSettings()
        {
        }

        private ServiceUsageSettings(ServiceUsageSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            EnableServiceSettings = existing.EnableServiceSettings;
            EnableServiceOperationsSettings = existing.EnableServiceOperationsSettings.Clone();
            DisableServiceSettings = existing.DisableServiceSettings;
            DisableServiceOperationsSettings = existing.DisableServiceOperationsSettings.Clone();
            GetServiceSettings = existing.GetServiceSettings;
            ListServicesSettings = existing.ListServicesSettings;
            BatchEnableServicesSettings = existing.BatchEnableServicesSettings;
            BatchEnableServicesOperationsSettings = existing.BatchEnableServicesOperationsSettings.Clone();
            BatchGetServicesSettings = existing.BatchGetServicesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ServiceUsageSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceUsageClient.EnableService</c> and <c>ServiceUsageClient.EnableServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings EnableServiceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ServiceUsageClient.EnableService</c> and
        /// <c>ServiceUsageClient.EnableServiceAsync</c>.
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
        public lro::OperationsSettings EnableServiceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceUsageClient.DisableService</c> and <c>ServiceUsageClient.DisableServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DisableServiceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ServiceUsageClient.DisableService</c> and
        /// <c>ServiceUsageClient.DisableServiceAsync</c>.
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
        public lro::OperationsSettings DisableServiceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceUsageClient.GetService</c> and <c>ServiceUsageClient.GetServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetServiceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceUsageClient.ListServices</c> and <c>ServiceUsageClient.ListServicesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListServicesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceUsageClient.BatchEnableServices</c> and <c>ServiceUsageClient.BatchEnableServicesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchEnableServicesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ServiceUsageClient.BatchEnableServices</c> and
        /// <c>ServiceUsageClient.BatchEnableServicesAsync</c>.
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
        public lro::OperationsSettings BatchEnableServicesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceUsageClient.BatchGetServices</c> and <c>ServiceUsageClient.BatchGetServicesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchGetServicesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ServiceUsageSettings"/> object.</returns>
        public ServiceUsageSettings Clone() => new ServiceUsageSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ServiceUsageClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class ServiceUsageClientBuilder : gaxgrpc::ClientBuilderBase<ServiceUsageClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ServiceUsageSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ServiceUsageClientBuilder() : base(ServiceUsageClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ServiceUsageClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ServiceUsageClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ServiceUsageClient Build()
        {
            ServiceUsageClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ServiceUsageClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ServiceUsageClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ServiceUsageClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ServiceUsageClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ServiceUsageClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ServiceUsageClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ServiceUsageClient.ChannelPool;
    }

    /// <summary>ServiceUsage client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Enables services that service consumers want to use on Google Cloud Platform,
    /// lists the available or enabled services, or disables services that service
    /// consumers no longer use.
    /// 
    /// See [Service Usage API](https://cloud.google.com/service-usage/docs/overview)
    /// </remarks>
    public abstract partial class ServiceUsageClient
    {
        /// <summary>
        /// The default endpoint for the ServiceUsage service, which is a host of "serviceusage.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "serviceusage.googleapis.com:443";

        /// <summary>The default ServiceUsage scopes.</summary>
        /// <remarks>
        /// The default ServiceUsage scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform.read-only</description></item>
        /// <item><description>https://www.googleapis.com/auth/service.management</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
            "https://www.googleapis.com/auth/service.management",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ServiceUsage.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ServiceUsageClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ServiceUsageClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ServiceUsageClient"/>.</returns>
        public static stt::Task<ServiceUsageClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ServiceUsageClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ServiceUsageClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ServiceUsageClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ServiceUsageClient"/>.</returns>
        public static ServiceUsageClient Create() => new ServiceUsageClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ServiceUsageClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ServiceUsageSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ServiceUsageClient"/>.</returns>
        internal static ServiceUsageClient Create(grpccore::CallInvoker callInvoker, ServiceUsageSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ServiceUsage.ServiceUsageClient grpcClient = new ServiceUsage.ServiceUsageClient(callInvoker);
            return new ServiceUsageClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ServiceUsage client</summary>
        public virtual ServiceUsage.ServiceUsageClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Enable a service so that it can be used with a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EnableServiceResponse, OperationMetadata> EnableService(EnableServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enable a service so that it can be used with a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EnableServiceResponse, OperationMetadata>> EnableServiceAsync(EnableServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enable a service so that it can be used with a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EnableServiceResponse, OperationMetadata>> EnableServiceAsync(EnableServiceRequest request, st::CancellationToken cancellationToken) =>
            EnableServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>EnableService</c>.</summary>
        public virtual lro::OperationsClient EnableServiceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>EnableService</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<EnableServiceResponse, OperationMetadata> PollOnceEnableService(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<EnableServiceResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), EnableServiceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>EnableService</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<EnableServiceResponse, OperationMetadata>> PollOnceEnableServiceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<EnableServiceResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), EnableServiceOperationsClient, callSettings);

        /// <summary>
        /// Disable a service so that it can no longer be used with a project.
        /// This prevents unintended usage that may cause unexpected billing
        /// charges or security leaks.
        /// 
        /// It is not valid to call the disable method on a service that is not
        /// currently enabled. Callers will receive a `FAILED_PRECONDITION` status if
        /// the target service is not currently enabled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DisableServiceResponse, OperationMetadata> DisableService(DisableServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Disable a service so that it can no longer be used with a project.
        /// This prevents unintended usage that may cause unexpected billing
        /// charges or security leaks.
        /// 
        /// It is not valid to call the disable method on a service that is not
        /// currently enabled. Callers will receive a `FAILED_PRECONDITION` status if
        /// the target service is not currently enabled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DisableServiceResponse, OperationMetadata>> DisableServiceAsync(DisableServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Disable a service so that it can no longer be used with a project.
        /// This prevents unintended usage that may cause unexpected billing
        /// charges or security leaks.
        /// 
        /// It is not valid to call the disable method on a service that is not
        /// currently enabled. Callers will receive a `FAILED_PRECONDITION` status if
        /// the target service is not currently enabled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DisableServiceResponse, OperationMetadata>> DisableServiceAsync(DisableServiceRequest request, st::CancellationToken cancellationToken) =>
            DisableServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DisableService</c>.</summary>
        public virtual lro::OperationsClient DisableServiceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DisableService</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DisableServiceResponse, OperationMetadata> PollOnceDisableService(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DisableServiceResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DisableServiceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DisableService</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DisableServiceResponse, OperationMetadata>> PollOnceDisableServiceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DisableServiceResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DisableServiceOperationsClient, callSettings);

        /// <summary>
        /// Returns the service configuration and enabled state for a given service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Service GetService(GetServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the service configuration and enabled state for a given service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> GetServiceAsync(GetServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the service configuration and enabled state for a given service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> GetServiceAsync(GetServiceRequest request, st::CancellationToken cancellationToken) =>
            GetServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List all services available to the specified project, and the current
        /// state of those services with respect to the project. The list includes
        /// all public services, all services for which the calling user has the
        /// `servicemanagement.services.bind` permission, and all services that have
        /// already been enabled on the project. The list can be filtered to
        /// only include services in a specific state, for example to only include
        /// services enabled on the project.
        /// 
        /// WARNING: If you need to query enabled services frequently or across
        /// an organization, you should use
        /// [Cloud Asset Inventory
        /// API](https://cloud.google.com/asset-inventory/docs/apis), which provides
        /// higher throughput and richer filtering capability.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServicesResponse, Service> ListServices(ListServicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all services available to the specified project, and the current
        /// state of those services with respect to the project. The list includes
        /// all public services, all services for which the calling user has the
        /// `servicemanagement.services.bind` permission, and all services that have
        /// already been enabled on the project. The list can be filtered to
        /// only include services in a specific state, for example to only include
        /// services enabled on the project.
        /// 
        /// WARNING: If you need to query enabled services frequently or across
        /// an organization, you should use
        /// [Cloud Asset Inventory
        /// API](https://cloud.google.com/asset-inventory/docs/apis), which provides
        /// higher throughput and richer filtering capability.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServicesResponse, Service> ListServicesAsync(ListServicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enable multiple services on a project. The operation is atomic: if enabling
        /// any service fails, then the entire batch fails, and no state changes occur.
        /// To enable a single service, use the `EnableService` method instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchEnableServicesResponse, OperationMetadata> BatchEnableServices(BatchEnableServicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enable multiple services on a project. The operation is atomic: if enabling
        /// any service fails, then the entire batch fails, and no state changes occur.
        /// To enable a single service, use the `EnableService` method instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchEnableServicesResponse, OperationMetadata>> BatchEnableServicesAsync(BatchEnableServicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enable multiple services on a project. The operation is atomic: if enabling
        /// any service fails, then the entire batch fails, and no state changes occur.
        /// To enable a single service, use the `EnableService` method instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchEnableServicesResponse, OperationMetadata>> BatchEnableServicesAsync(BatchEnableServicesRequest request, st::CancellationToken cancellationToken) =>
            BatchEnableServicesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>BatchEnableServices</c>.</summary>
        public virtual lro::OperationsClient BatchEnableServicesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchEnableServices</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BatchEnableServicesResponse, OperationMetadata> PollOnceBatchEnableServices(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchEnableServicesResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchEnableServicesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchEnableServices</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BatchEnableServicesResponse, OperationMetadata>> PollOnceBatchEnableServicesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchEnableServicesResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchEnableServicesOperationsClient, callSettings);

        /// <summary>
        /// Returns the service configurations and enabled states for a given list of
        /// services.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchGetServicesResponse BatchGetServices(BatchGetServicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the service configurations and enabled states for a given list of
        /// services.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchGetServicesResponse> BatchGetServicesAsync(BatchGetServicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the service configurations and enabled states for a given list of
        /// services.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchGetServicesResponse> BatchGetServicesAsync(BatchGetServicesRequest request, st::CancellationToken cancellationToken) =>
            BatchGetServicesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ServiceUsage client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Enables services that service consumers want to use on Google Cloud Platform,
    /// lists the available or enabled services, or disables services that service
    /// consumers no longer use.
    /// 
    /// See [Service Usage API](https://cloud.google.com/service-usage/docs/overview)
    /// </remarks>
    public sealed partial class ServiceUsageClientImpl : ServiceUsageClient
    {
        private readonly gaxgrpc::ApiCall<EnableServiceRequest, lro::Operation> _callEnableService;

        private readonly gaxgrpc::ApiCall<DisableServiceRequest, lro::Operation> _callDisableService;

        private readonly gaxgrpc::ApiCall<GetServiceRequest, Service> _callGetService;

        private readonly gaxgrpc::ApiCall<ListServicesRequest, ListServicesResponse> _callListServices;

        private readonly gaxgrpc::ApiCall<BatchEnableServicesRequest, lro::Operation> _callBatchEnableServices;

        private readonly gaxgrpc::ApiCall<BatchGetServicesRequest, BatchGetServicesResponse> _callBatchGetServices;

        /// <summary>
        /// Constructs a client wrapper for the ServiceUsage service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ServiceUsageSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ServiceUsageClientImpl(ServiceUsage.ServiceUsageClient grpcClient, ServiceUsageSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ServiceUsageSettings effectiveSettings = settings ?? ServiceUsageSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            EnableServiceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.EnableServiceOperationsSettings, logger);
            DisableServiceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DisableServiceOperationsSettings, logger);
            BatchEnableServicesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.BatchEnableServicesOperationsSettings, logger);
            _callEnableService = clientHelper.BuildApiCall<EnableServiceRequest, lro::Operation>("EnableService", grpcClient.EnableServiceAsync, grpcClient.EnableService, effectiveSettings.EnableServiceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callEnableService);
            Modify_EnableServiceApiCall(ref _callEnableService);
            _callDisableService = clientHelper.BuildApiCall<DisableServiceRequest, lro::Operation>("DisableService", grpcClient.DisableServiceAsync, grpcClient.DisableService, effectiveSettings.DisableServiceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDisableService);
            Modify_DisableServiceApiCall(ref _callDisableService);
            _callGetService = clientHelper.BuildApiCall<GetServiceRequest, Service>("GetService", grpcClient.GetServiceAsync, grpcClient.GetService, effectiveSettings.GetServiceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetService);
            Modify_GetServiceApiCall(ref _callGetService);
            _callListServices = clientHelper.BuildApiCall<ListServicesRequest, ListServicesResponse>("ListServices", grpcClient.ListServicesAsync, grpcClient.ListServices, effectiveSettings.ListServicesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListServices);
            Modify_ListServicesApiCall(ref _callListServices);
            _callBatchEnableServices = clientHelper.BuildApiCall<BatchEnableServicesRequest, lro::Operation>("BatchEnableServices", grpcClient.BatchEnableServicesAsync, grpcClient.BatchEnableServices, effectiveSettings.BatchEnableServicesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchEnableServices);
            Modify_BatchEnableServicesApiCall(ref _callBatchEnableServices);
            _callBatchGetServices = clientHelper.BuildApiCall<BatchGetServicesRequest, BatchGetServicesResponse>("BatchGetServices", grpcClient.BatchGetServicesAsync, grpcClient.BatchGetServices, effectiveSettings.BatchGetServicesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchGetServices);
            Modify_BatchGetServicesApiCall(ref _callBatchGetServices);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_EnableServiceApiCall(ref gaxgrpc::ApiCall<EnableServiceRequest, lro::Operation> call);

        partial void Modify_DisableServiceApiCall(ref gaxgrpc::ApiCall<DisableServiceRequest, lro::Operation> call);

        partial void Modify_GetServiceApiCall(ref gaxgrpc::ApiCall<GetServiceRequest, Service> call);

        partial void Modify_ListServicesApiCall(ref gaxgrpc::ApiCall<ListServicesRequest, ListServicesResponse> call);

        partial void Modify_BatchEnableServicesApiCall(ref gaxgrpc::ApiCall<BatchEnableServicesRequest, lro::Operation> call);

        partial void Modify_BatchGetServicesApiCall(ref gaxgrpc::ApiCall<BatchGetServicesRequest, BatchGetServicesResponse> call);

        partial void OnConstruction(ServiceUsage.ServiceUsageClient grpcClient, ServiceUsageSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ServiceUsage client</summary>
        public override ServiceUsage.ServiceUsageClient GrpcClient { get; }

        partial void Modify_EnableServiceRequest(ref EnableServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DisableServiceRequest(ref DisableServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetServiceRequest(ref GetServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListServicesRequest(ref ListServicesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchEnableServicesRequest(ref BatchEnableServicesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchGetServicesRequest(ref BatchGetServicesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>EnableService</c>.</summary>
        public override lro::OperationsClient EnableServiceOperationsClient { get; }

        /// <summary>
        /// Enable a service so that it can be used with a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<EnableServiceResponse, OperationMetadata> EnableService(EnableServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnableServiceRequest(ref request, ref callSettings);
            return new lro::Operation<EnableServiceResponse, OperationMetadata>(_callEnableService.Sync(request, callSettings), EnableServiceOperationsClient);
        }

        /// <summary>
        /// Enable a service so that it can be used with a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<EnableServiceResponse, OperationMetadata>> EnableServiceAsync(EnableServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnableServiceRequest(ref request, ref callSettings);
            return new lro::Operation<EnableServiceResponse, OperationMetadata>(await _callEnableService.Async(request, callSettings).ConfigureAwait(false), EnableServiceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DisableService</c>.</summary>
        public override lro::OperationsClient DisableServiceOperationsClient { get; }

        /// <summary>
        /// Disable a service so that it can no longer be used with a project.
        /// This prevents unintended usage that may cause unexpected billing
        /// charges or security leaks.
        /// 
        /// It is not valid to call the disable method on a service that is not
        /// currently enabled. Callers will receive a `FAILED_PRECONDITION` status if
        /// the target service is not currently enabled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DisableServiceResponse, OperationMetadata> DisableService(DisableServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DisableServiceRequest(ref request, ref callSettings);
            return new lro::Operation<DisableServiceResponse, OperationMetadata>(_callDisableService.Sync(request, callSettings), DisableServiceOperationsClient);
        }

        /// <summary>
        /// Disable a service so that it can no longer be used with a project.
        /// This prevents unintended usage that may cause unexpected billing
        /// charges or security leaks.
        /// 
        /// It is not valid to call the disable method on a service that is not
        /// currently enabled. Callers will receive a `FAILED_PRECONDITION` status if
        /// the target service is not currently enabled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DisableServiceResponse, OperationMetadata>> DisableServiceAsync(DisableServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DisableServiceRequest(ref request, ref callSettings);
            return new lro::Operation<DisableServiceResponse, OperationMetadata>(await _callDisableService.Async(request, callSettings).ConfigureAwait(false), DisableServiceOperationsClient);
        }

        /// <summary>
        /// Returns the service configuration and enabled state for a given service.
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
        /// Returns the service configuration and enabled state for a given service.
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
        /// List all services available to the specified project, and the current
        /// state of those services with respect to the project. The list includes
        /// all public services, all services for which the calling user has the
        /// `servicemanagement.services.bind` permission, and all services that have
        /// already been enabled on the project. The list can be filtered to
        /// only include services in a specific state, for example to only include
        /// services enabled on the project.
        /// 
        /// WARNING: If you need to query enabled services frequently or across
        /// an organization, you should use
        /// [Cloud Asset Inventory
        /// API](https://cloud.google.com/asset-inventory/docs/apis), which provides
        /// higher throughput and richer filtering capability.
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
        /// List all services available to the specified project, and the current
        /// state of those services with respect to the project. The list includes
        /// all public services, all services for which the calling user has the
        /// `servicemanagement.services.bind` permission, and all services that have
        /// already been enabled on the project. The list can be filtered to
        /// only include services in a specific state, for example to only include
        /// services enabled on the project.
        /// 
        /// WARNING: If you need to query enabled services frequently or across
        /// an organization, you should use
        /// [Cloud Asset Inventory
        /// API](https://cloud.google.com/asset-inventory/docs/apis), which provides
        /// higher throughput and richer filtering capability.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Service"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListServicesResponse, Service> ListServicesAsync(ListServicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServicesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListServicesRequest, ListServicesResponse, Service>(_callListServices, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>BatchEnableServices</c>.</summary>
        public override lro::OperationsClient BatchEnableServicesOperationsClient { get; }

        /// <summary>
        /// Enable multiple services on a project. The operation is atomic: if enabling
        /// any service fails, then the entire batch fails, and no state changes occur.
        /// To enable a single service, use the `EnableService` method instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BatchEnableServicesResponse, OperationMetadata> BatchEnableServices(BatchEnableServicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchEnableServicesRequest(ref request, ref callSettings);
            return new lro::Operation<BatchEnableServicesResponse, OperationMetadata>(_callBatchEnableServices.Sync(request, callSettings), BatchEnableServicesOperationsClient);
        }

        /// <summary>
        /// Enable multiple services on a project. The operation is atomic: if enabling
        /// any service fails, then the entire batch fails, and no state changes occur.
        /// To enable a single service, use the `EnableService` method instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BatchEnableServicesResponse, OperationMetadata>> BatchEnableServicesAsync(BatchEnableServicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchEnableServicesRequest(ref request, ref callSettings);
            return new lro::Operation<BatchEnableServicesResponse, OperationMetadata>(await _callBatchEnableServices.Async(request, callSettings).ConfigureAwait(false), BatchEnableServicesOperationsClient);
        }

        /// <summary>
        /// Returns the service configurations and enabled states for a given list of
        /// services.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchGetServicesResponse BatchGetServices(BatchGetServicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchGetServicesRequest(ref request, ref callSettings);
            return _callBatchGetServices.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the service configurations and enabled states for a given list of
        /// services.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchGetServicesResponse> BatchGetServicesAsync(BatchGetServicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchGetServicesRequest(ref request, ref callSettings);
            return _callBatchGetServices.Async(request, callSettings);
        }
    }

    public partial class ListServicesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListServicesResponse : gaxgrpc::IPageResponse<Service>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Service> GetEnumerator() => Services.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ServiceUsage
    {
        public partial class ServiceUsageClient
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
