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
using gciv = Google.Cloud.Iam.V1;
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

namespace Google.Cloud.AIPlatform.V1Beta1
{
    /// <summary>Settings for <see cref="ModelMonitoringServiceClient"/> instances.</summary>
    public sealed partial class ModelMonitoringServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ModelMonitoringServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ModelMonitoringServiceSettings"/>.</returns>
        public static ModelMonitoringServiceSettings GetDefault() => new ModelMonitoringServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ModelMonitoringServiceSettings"/> object with default settings.
        /// </summary>
        public ModelMonitoringServiceSettings()
        {
        }

        private ModelMonitoringServiceSettings(ModelMonitoringServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateModelMonitorSettings = existing.CreateModelMonitorSettings;
            CreateModelMonitorOperationsSettings = existing.CreateModelMonitorOperationsSettings.Clone();
            UpdateModelMonitorSettings = existing.UpdateModelMonitorSettings;
            UpdateModelMonitorOperationsSettings = existing.UpdateModelMonitorOperationsSettings.Clone();
            GetModelMonitorSettings = existing.GetModelMonitorSettings;
            ListModelMonitorsSettings = existing.ListModelMonitorsSettings;
            DeleteModelMonitorSettings = existing.DeleteModelMonitorSettings;
            DeleteModelMonitorOperationsSettings = existing.DeleteModelMonitorOperationsSettings.Clone();
            CreateModelMonitoringJobSettings = existing.CreateModelMonitoringJobSettings;
            GetModelMonitoringJobSettings = existing.GetModelMonitoringJobSettings;
            ListModelMonitoringJobsSettings = existing.ListModelMonitoringJobsSettings;
            DeleteModelMonitoringJobSettings = existing.DeleteModelMonitoringJobSettings;
            DeleteModelMonitoringJobOperationsSettings = existing.DeleteModelMonitoringJobOperationsSettings.Clone();
            SearchModelMonitoringStatsSettings = existing.SearchModelMonitoringStatsSettings;
            SearchModelMonitoringAlertsSettings = existing.SearchModelMonitoringAlertsSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(ModelMonitoringServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelMonitoringServiceClient.CreateModelMonitor</c> and
        /// <c>ModelMonitoringServiceClient.CreateModelMonitorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateModelMonitorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ModelMonitoringServiceClient.CreateModelMonitor</c> and
        /// <c>ModelMonitoringServiceClient.CreateModelMonitorAsync</c>.
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
        public lro::OperationsSettings CreateModelMonitorOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelMonitoringServiceClient.UpdateModelMonitor</c> and
        /// <c>ModelMonitoringServiceClient.UpdateModelMonitorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateModelMonitorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ModelMonitoringServiceClient.UpdateModelMonitor</c> and
        /// <c>ModelMonitoringServiceClient.UpdateModelMonitorAsync</c>.
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
        public lro::OperationsSettings UpdateModelMonitorOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelMonitoringServiceClient.GetModelMonitor</c> and <c>ModelMonitoringServiceClient.GetModelMonitorAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetModelMonitorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelMonitoringServiceClient.ListModelMonitors</c> and
        /// <c>ModelMonitoringServiceClient.ListModelMonitorsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListModelMonitorsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelMonitoringServiceClient.DeleteModelMonitor</c> and
        /// <c>ModelMonitoringServiceClient.DeleteModelMonitorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteModelMonitorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ModelMonitoringServiceClient.DeleteModelMonitor</c> and
        /// <c>ModelMonitoringServiceClient.DeleteModelMonitorAsync</c>.
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
        public lro::OperationsSettings DeleteModelMonitorOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelMonitoringServiceClient.CreateModelMonitoringJob</c> and
        /// <c>ModelMonitoringServiceClient.CreateModelMonitoringJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateModelMonitoringJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelMonitoringServiceClient.GetModelMonitoringJob</c> and
        /// <c>ModelMonitoringServiceClient.GetModelMonitoringJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetModelMonitoringJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelMonitoringServiceClient.ListModelMonitoringJobs</c> and
        /// <c>ModelMonitoringServiceClient.ListModelMonitoringJobsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListModelMonitoringJobsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelMonitoringServiceClient.DeleteModelMonitoringJob</c> and
        /// <c>ModelMonitoringServiceClient.DeleteModelMonitoringJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteModelMonitoringJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ModelMonitoringServiceClient.DeleteModelMonitoringJob</c>
        /// and <c>ModelMonitoringServiceClient.DeleteModelMonitoringJobAsync</c>.
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
        public lro::OperationsSettings DeleteModelMonitoringJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelMonitoringServiceClient.SearchModelMonitoringStats</c> and
        /// <c>ModelMonitoringServiceClient.SearchModelMonitoringStatsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchModelMonitoringStatsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelMonitoringServiceClient.SearchModelMonitoringAlerts</c> and
        /// <c>ModelMonitoringServiceClient.SearchModelMonitoringAlertsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchModelMonitoringAlertsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ModelMonitoringServiceSettings"/> object.</returns>
        public ModelMonitoringServiceSettings Clone() => new ModelMonitoringServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ModelMonitoringServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class ModelMonitoringServiceClientBuilder : gaxgrpc::ClientBuilderBase<ModelMonitoringServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ModelMonitoringServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ModelMonitoringServiceClientBuilder() : base(ModelMonitoringServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ModelMonitoringServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ModelMonitoringServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ModelMonitoringServiceClient Build()
        {
            ModelMonitoringServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ModelMonitoringServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ModelMonitoringServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ModelMonitoringServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ModelMonitoringServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ModelMonitoringServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ModelMonitoringServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ModelMonitoringServiceClient.ChannelPool;
    }

    /// <summary>ModelMonitoringService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service for creating and managing Vertex AI Model moitoring. This includes
    /// `ModelMonitor` resources, `ModelMonitoringJob` resources.
    /// </remarks>
    public abstract partial class ModelMonitoringServiceClient
    {
        /// <summary>
        /// The default endpoint for the ModelMonitoringService service, which is a host of "aiplatform.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "aiplatform.googleapis.com:443";

        /// <summary>The default ModelMonitoringService scopes.</summary>
        /// <remarks>
        /// The default ModelMonitoringService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ModelMonitoringService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ModelMonitoringServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ModelMonitoringServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ModelMonitoringServiceClient"/>.</returns>
        public static stt::Task<ModelMonitoringServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ModelMonitoringServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ModelMonitoringServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ModelMonitoringServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ModelMonitoringServiceClient"/>.</returns>
        public static ModelMonitoringServiceClient Create() => new ModelMonitoringServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ModelMonitoringServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ModelMonitoringServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ModelMonitoringServiceClient"/>.</returns>
        internal static ModelMonitoringServiceClient Create(grpccore::CallInvoker callInvoker, ModelMonitoringServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ModelMonitoringService.ModelMonitoringServiceClient grpcClient = new ModelMonitoringService.ModelMonitoringServiceClient(callInvoker);
            return new ModelMonitoringServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ModelMonitoringService client</summary>
        public virtual ModelMonitoringService.ModelMonitoringServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a ModelMonitor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ModelMonitor, CreateModelMonitorOperationMetadata> CreateModelMonitor(CreateModelMonitorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a ModelMonitor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ModelMonitor, CreateModelMonitorOperationMetadata>> CreateModelMonitorAsync(CreateModelMonitorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a ModelMonitor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ModelMonitor, CreateModelMonitorOperationMetadata>> CreateModelMonitorAsync(CreateModelMonitorRequest request, st::CancellationToken cancellationToken) =>
            CreateModelMonitorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateModelMonitor</c>.</summary>
        public virtual lro::OperationsClient CreateModelMonitorOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateModelMonitor</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ModelMonitor, CreateModelMonitorOperationMetadata> PollOnceCreateModelMonitor(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ModelMonitor, CreateModelMonitorOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateModelMonitorOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateModelMonitor</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ModelMonitor, CreateModelMonitorOperationMetadata>> PollOnceCreateModelMonitorAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ModelMonitor, CreateModelMonitorOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateModelMonitorOperationsClient, callSettings);

        /// <summary>
        /// Creates a ModelMonitor.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the ModelMonitor in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="modelMonitor">
        /// Required. The ModelMonitor to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ModelMonitor, CreateModelMonitorOperationMetadata> CreateModelMonitor(string parent, ModelMonitor modelMonitor, gaxgrpc::CallSettings callSettings = null) =>
            CreateModelMonitor(new CreateModelMonitorRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ModelMonitor = gax::GaxPreconditions.CheckNotNull(modelMonitor, nameof(modelMonitor)),
            }, callSettings);

        /// <summary>
        /// Creates a ModelMonitor.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the ModelMonitor in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="modelMonitor">
        /// Required. The ModelMonitor to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ModelMonitor, CreateModelMonitorOperationMetadata>> CreateModelMonitorAsync(string parent, ModelMonitor modelMonitor, gaxgrpc::CallSettings callSettings = null) =>
            CreateModelMonitorAsync(new CreateModelMonitorRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ModelMonitor = gax::GaxPreconditions.CheckNotNull(modelMonitor, nameof(modelMonitor)),
            }, callSettings);

        /// <summary>
        /// Creates a ModelMonitor.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the ModelMonitor in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="modelMonitor">
        /// Required. The ModelMonitor to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ModelMonitor, CreateModelMonitorOperationMetadata>> CreateModelMonitorAsync(string parent, ModelMonitor modelMonitor, st::CancellationToken cancellationToken) =>
            CreateModelMonitorAsync(parent, modelMonitor, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a ModelMonitor.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the ModelMonitor in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="modelMonitor">
        /// Required. The ModelMonitor to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ModelMonitor, CreateModelMonitorOperationMetadata> CreateModelMonitor(gagr::LocationName parent, ModelMonitor modelMonitor, gaxgrpc::CallSettings callSettings = null) =>
            CreateModelMonitor(new CreateModelMonitorRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ModelMonitor = gax::GaxPreconditions.CheckNotNull(modelMonitor, nameof(modelMonitor)),
            }, callSettings);

        /// <summary>
        /// Creates a ModelMonitor.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the ModelMonitor in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="modelMonitor">
        /// Required. The ModelMonitor to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ModelMonitor, CreateModelMonitorOperationMetadata>> CreateModelMonitorAsync(gagr::LocationName parent, ModelMonitor modelMonitor, gaxgrpc::CallSettings callSettings = null) =>
            CreateModelMonitorAsync(new CreateModelMonitorRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ModelMonitor = gax::GaxPreconditions.CheckNotNull(modelMonitor, nameof(modelMonitor)),
            }, callSettings);

        /// <summary>
        /// Creates a ModelMonitor.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the ModelMonitor in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="modelMonitor">
        /// Required. The ModelMonitor to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ModelMonitor, CreateModelMonitorOperationMetadata>> CreateModelMonitorAsync(gagr::LocationName parent, ModelMonitor modelMonitor, st::CancellationToken cancellationToken) =>
            CreateModelMonitorAsync(parent, modelMonitor, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a ModelMonitor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ModelMonitor, UpdateModelMonitorOperationMetadata> UpdateModelMonitor(UpdateModelMonitorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a ModelMonitor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ModelMonitor, UpdateModelMonitorOperationMetadata>> UpdateModelMonitorAsync(UpdateModelMonitorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a ModelMonitor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ModelMonitor, UpdateModelMonitorOperationMetadata>> UpdateModelMonitorAsync(UpdateModelMonitorRequest request, st::CancellationToken cancellationToken) =>
            UpdateModelMonitorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateModelMonitor</c>.</summary>
        public virtual lro::OperationsClient UpdateModelMonitorOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateModelMonitor</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ModelMonitor, UpdateModelMonitorOperationMetadata> PollOnceUpdateModelMonitor(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ModelMonitor, UpdateModelMonitorOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateModelMonitorOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateModelMonitor</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ModelMonitor, UpdateModelMonitorOperationMetadata>> PollOnceUpdateModelMonitorAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ModelMonitor, UpdateModelMonitorOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateModelMonitorOperationsClient, callSettings);

        /// <summary>
        /// Updates a ModelMonitor.
        /// </summary>
        /// <param name="modelMonitor">
        /// Required. The model monitoring configuration which replaces the resource on
        /// the server.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask specifying which fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ModelMonitor, UpdateModelMonitorOperationMetadata> UpdateModelMonitor(ModelMonitor modelMonitor, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateModelMonitor(new UpdateModelMonitorRequest
            {
                ModelMonitor = gax::GaxPreconditions.CheckNotNull(modelMonitor, nameof(modelMonitor)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a ModelMonitor.
        /// </summary>
        /// <param name="modelMonitor">
        /// Required. The model monitoring configuration which replaces the resource on
        /// the server.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask specifying which fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ModelMonitor, UpdateModelMonitorOperationMetadata>> UpdateModelMonitorAsync(ModelMonitor modelMonitor, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateModelMonitorAsync(new UpdateModelMonitorRequest
            {
                ModelMonitor = gax::GaxPreconditions.CheckNotNull(modelMonitor, nameof(modelMonitor)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a ModelMonitor.
        /// </summary>
        /// <param name="modelMonitor">
        /// Required. The model monitoring configuration which replaces the resource on
        /// the server.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask specifying which fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ModelMonitor, UpdateModelMonitorOperationMetadata>> UpdateModelMonitorAsync(ModelMonitor modelMonitor, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateModelMonitorAsync(modelMonitor, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a ModelMonitor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ModelMonitor GetModelMonitor(GetModelMonitorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a ModelMonitor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelMonitor> GetModelMonitorAsync(GetModelMonitorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a ModelMonitor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelMonitor> GetModelMonitorAsync(GetModelMonitorRequest request, st::CancellationToken cancellationToken) =>
            GetModelMonitorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a ModelMonitor.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ModelMonitor resource.
        /// Format:
        /// `projects/{project}/locations/{location}/modelMonitors/{model_monitor}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ModelMonitor GetModelMonitor(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetModelMonitor(new GetModelMonitorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a ModelMonitor.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ModelMonitor resource.
        /// Format:
        /// `projects/{project}/locations/{location}/modelMonitors/{model_monitor}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelMonitor> GetModelMonitorAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetModelMonitorAsync(new GetModelMonitorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a ModelMonitor.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ModelMonitor resource.
        /// Format:
        /// `projects/{project}/locations/{location}/modelMonitors/{model_monitor}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelMonitor> GetModelMonitorAsync(string name, st::CancellationToken cancellationToken) =>
            GetModelMonitorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a ModelMonitor.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ModelMonitor resource.
        /// Format:
        /// `projects/{project}/locations/{location}/modelMonitors/{model_monitor}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ModelMonitor GetModelMonitor(ModelMonitorName name, gaxgrpc::CallSettings callSettings = null) =>
            GetModelMonitor(new GetModelMonitorRequest
            {
                ModelMonitorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a ModelMonitor.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ModelMonitor resource.
        /// Format:
        /// `projects/{project}/locations/{location}/modelMonitors/{model_monitor}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelMonitor> GetModelMonitorAsync(ModelMonitorName name, gaxgrpc::CallSettings callSettings = null) =>
            GetModelMonitorAsync(new GetModelMonitorRequest
            {
                ModelMonitorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a ModelMonitor.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ModelMonitor resource.
        /// Format:
        /// `projects/{project}/locations/{location}/modelMonitors/{model_monitor}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelMonitor> GetModelMonitorAsync(ModelMonitorName name, st::CancellationToken cancellationToken) =>
            GetModelMonitorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists ModelMonitors in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ModelMonitor"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListModelMonitorsResponse, ModelMonitor> ListModelMonitors(ListModelMonitorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ModelMonitors in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ModelMonitor"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListModelMonitorsResponse, ModelMonitor> ListModelMonitorsAsync(ListModelMonitorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ModelMonitors in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the ModelMonitors from.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="ModelMonitor"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListModelMonitorsResponse, ModelMonitor> ListModelMonitors(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelMonitorsRequest request = new ListModelMonitorsRequest
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
            return ListModelMonitors(request, callSettings);
        }

        /// <summary>
        /// Lists ModelMonitors in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the ModelMonitors from.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ModelMonitor"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListModelMonitorsResponse, ModelMonitor> ListModelMonitorsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelMonitorsRequest request = new ListModelMonitorsRequest
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
            return ListModelMonitorsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists ModelMonitors in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the ModelMonitors from.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="ModelMonitor"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListModelMonitorsResponse, ModelMonitor> ListModelMonitors(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelMonitorsRequest request = new ListModelMonitorsRequest
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
            return ListModelMonitors(request, callSettings);
        }

        /// <summary>
        /// Lists ModelMonitors in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the ModelMonitors from.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ModelMonitor"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListModelMonitorsResponse, ModelMonitor> ListModelMonitorsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelMonitorsRequest request = new ListModelMonitorsRequest
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
            return ListModelMonitorsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a ModelMonitor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteModelMonitor(DeleteModelMonitorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a ModelMonitor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteModelMonitorAsync(DeleteModelMonitorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a ModelMonitor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteModelMonitorAsync(DeleteModelMonitorRequest request, st::CancellationToken cancellationToken) =>
            DeleteModelMonitorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteModelMonitor</c>.</summary>
        public virtual lro::OperationsClient DeleteModelMonitorOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteModelMonitor</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> PollOnceDeleteModelMonitor(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteModelMonitorOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteModelMonitor</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> PollOnceDeleteModelMonitorAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteModelMonitorOperationsClient, callSettings);

        /// <summary>
        /// Deletes a ModelMonitor.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ModelMonitor resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/modelMonitords/{model_monitor}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteModelMonitor(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteModelMonitor(new DeleteModelMonitorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a ModelMonitor.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ModelMonitor resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/modelMonitords/{model_monitor}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteModelMonitorAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteModelMonitorAsync(new DeleteModelMonitorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a ModelMonitor.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ModelMonitor resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/modelMonitords/{model_monitor}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteModelMonitorAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteModelMonitorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a ModelMonitor.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ModelMonitor resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/modelMonitords/{model_monitor}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteModelMonitor(ModelMonitorName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteModelMonitor(new DeleteModelMonitorRequest
            {
                ModelMonitorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a ModelMonitor.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ModelMonitor resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/modelMonitords/{model_monitor}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteModelMonitorAsync(ModelMonitorName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteModelMonitorAsync(new DeleteModelMonitorRequest
            {
                ModelMonitorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a ModelMonitor.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ModelMonitor resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/modelMonitords/{model_monitor}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteModelMonitorAsync(ModelMonitorName name, st::CancellationToken cancellationToken) =>
            DeleteModelMonitorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a ModelMonitoringJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ModelMonitoringJob CreateModelMonitoringJob(CreateModelMonitoringJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a ModelMonitoringJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelMonitoringJob> CreateModelMonitoringJobAsync(CreateModelMonitoringJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a ModelMonitoringJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelMonitoringJob> CreateModelMonitoringJobAsync(CreateModelMonitoringJobRequest request, st::CancellationToken cancellationToken) =>
            CreateModelMonitoringJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a ModelMonitoringJob.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the ModelMonitoringJob.
        /// Format:
        /// `projects/{project}/locations/{location}/modelMoniitors/{model_monitor}`
        /// </param>
        /// <param name="modelMonitoringJob">
        /// Required. The ModelMonitoringJob to create
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ModelMonitoringJob CreateModelMonitoringJob(string parent, ModelMonitoringJob modelMonitoringJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateModelMonitoringJob(new CreateModelMonitoringJobRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ModelMonitoringJob = gax::GaxPreconditions.CheckNotNull(modelMonitoringJob, nameof(modelMonitoringJob)),
            }, callSettings);

        /// <summary>
        /// Creates a ModelMonitoringJob.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the ModelMonitoringJob.
        /// Format:
        /// `projects/{project}/locations/{location}/modelMoniitors/{model_monitor}`
        /// </param>
        /// <param name="modelMonitoringJob">
        /// Required. The ModelMonitoringJob to create
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelMonitoringJob> CreateModelMonitoringJobAsync(string parent, ModelMonitoringJob modelMonitoringJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateModelMonitoringJobAsync(new CreateModelMonitoringJobRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ModelMonitoringJob = gax::GaxPreconditions.CheckNotNull(modelMonitoringJob, nameof(modelMonitoringJob)),
            }, callSettings);

        /// <summary>
        /// Creates a ModelMonitoringJob.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the ModelMonitoringJob.
        /// Format:
        /// `projects/{project}/locations/{location}/modelMoniitors/{model_monitor}`
        /// </param>
        /// <param name="modelMonitoringJob">
        /// Required. The ModelMonitoringJob to create
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelMonitoringJob> CreateModelMonitoringJobAsync(string parent, ModelMonitoringJob modelMonitoringJob, st::CancellationToken cancellationToken) =>
            CreateModelMonitoringJobAsync(parent, modelMonitoringJob, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a ModelMonitoringJob.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the ModelMonitoringJob.
        /// Format:
        /// `projects/{project}/locations/{location}/modelMoniitors/{model_monitor}`
        /// </param>
        /// <param name="modelMonitoringJob">
        /// Required. The ModelMonitoringJob to create
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ModelMonitoringJob CreateModelMonitoringJob(ModelMonitorName parent, ModelMonitoringJob modelMonitoringJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateModelMonitoringJob(new CreateModelMonitoringJobRequest
            {
                ParentAsModelMonitorName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ModelMonitoringJob = gax::GaxPreconditions.CheckNotNull(modelMonitoringJob, nameof(modelMonitoringJob)),
            }, callSettings);

        /// <summary>
        /// Creates a ModelMonitoringJob.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the ModelMonitoringJob.
        /// Format:
        /// `projects/{project}/locations/{location}/modelMoniitors/{model_monitor}`
        /// </param>
        /// <param name="modelMonitoringJob">
        /// Required. The ModelMonitoringJob to create
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelMonitoringJob> CreateModelMonitoringJobAsync(ModelMonitorName parent, ModelMonitoringJob modelMonitoringJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateModelMonitoringJobAsync(new CreateModelMonitoringJobRequest
            {
                ParentAsModelMonitorName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ModelMonitoringJob = gax::GaxPreconditions.CheckNotNull(modelMonitoringJob, nameof(modelMonitoringJob)),
            }, callSettings);

        /// <summary>
        /// Creates a ModelMonitoringJob.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the ModelMonitoringJob.
        /// Format:
        /// `projects/{project}/locations/{location}/modelMoniitors/{model_monitor}`
        /// </param>
        /// <param name="modelMonitoringJob">
        /// Required. The ModelMonitoringJob to create
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelMonitoringJob> CreateModelMonitoringJobAsync(ModelMonitorName parent, ModelMonitoringJob modelMonitoringJob, st::CancellationToken cancellationToken) =>
            CreateModelMonitoringJobAsync(parent, modelMonitoringJob, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a ModelMonitoringJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ModelMonitoringJob GetModelMonitoringJob(GetModelMonitoringJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a ModelMonitoringJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelMonitoringJob> GetModelMonitoringJobAsync(GetModelMonitoringJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a ModelMonitoringJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelMonitoringJob> GetModelMonitoringJobAsync(GetModelMonitoringJobRequest request, st::CancellationToken cancellationToken) =>
            GetModelMonitoringJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a ModelMonitoringJob.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ModelMonitoringJob.
        /// Format:
        /// `projects/{project}/locations/{location}/modelMonitors/{model_monitor}/modelMonitoringJobs/{model_monitoring_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ModelMonitoringJob GetModelMonitoringJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetModelMonitoringJob(new GetModelMonitoringJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a ModelMonitoringJob.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ModelMonitoringJob.
        /// Format:
        /// `projects/{project}/locations/{location}/modelMonitors/{model_monitor}/modelMonitoringJobs/{model_monitoring_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelMonitoringJob> GetModelMonitoringJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetModelMonitoringJobAsync(new GetModelMonitoringJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a ModelMonitoringJob.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ModelMonitoringJob.
        /// Format:
        /// `projects/{project}/locations/{location}/modelMonitors/{model_monitor}/modelMonitoringJobs/{model_monitoring_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelMonitoringJob> GetModelMonitoringJobAsync(string name, st::CancellationToken cancellationToken) =>
            GetModelMonitoringJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a ModelMonitoringJob.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ModelMonitoringJob.
        /// Format:
        /// `projects/{project}/locations/{location}/modelMonitors/{model_monitor}/modelMonitoringJobs/{model_monitoring_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ModelMonitoringJob GetModelMonitoringJob(ModelMonitoringJobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetModelMonitoringJob(new GetModelMonitoringJobRequest
            {
                ModelMonitoringJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a ModelMonitoringJob.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ModelMonitoringJob.
        /// Format:
        /// `projects/{project}/locations/{location}/modelMonitors/{model_monitor}/modelMonitoringJobs/{model_monitoring_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelMonitoringJob> GetModelMonitoringJobAsync(ModelMonitoringJobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetModelMonitoringJobAsync(new GetModelMonitoringJobRequest
            {
                ModelMonitoringJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a ModelMonitoringJob.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ModelMonitoringJob.
        /// Format:
        /// `projects/{project}/locations/{location}/modelMonitors/{model_monitor}/modelMonitoringJobs/{model_monitoring_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelMonitoringJob> GetModelMonitoringJobAsync(ModelMonitoringJobName name, st::CancellationToken cancellationToken) =>
            GetModelMonitoringJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists ModelMonitoringJobs.
        /// Callers may choose to read across multiple Monitors as per
        /// [AIP-159](https://google.aip.dev/159) by using '-' (the hyphen or dash
        /// character) as a wildcard character instead of modelMonitor id in the
        /// parent. Format
        /// `projects/{project_id}/locations/{location}/moodelMonitors/-/modelMonitoringJobs`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ModelMonitoringJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListModelMonitoringJobsResponse, ModelMonitoringJob> ListModelMonitoringJobs(ListModelMonitoringJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ModelMonitoringJobs.
        /// Callers may choose to read across multiple Monitors as per
        /// [AIP-159](https://google.aip.dev/159) by using '-' (the hyphen or dash
        /// character) as a wildcard character instead of modelMonitor id in the
        /// parent. Format
        /// `projects/{project_id}/locations/{location}/moodelMonitors/-/modelMonitoringJobs`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ModelMonitoringJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListModelMonitoringJobsResponse, ModelMonitoringJob> ListModelMonitoringJobsAsync(ListModelMonitoringJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ModelMonitoringJobs.
        /// Callers may choose to read across multiple Monitors as per
        /// [AIP-159](https://google.aip.dev/159) by using '-' (the hyphen or dash
        /// character) as a wildcard character instead of modelMonitor id in the
        /// parent. Format
        /// `projects/{project_id}/locations/{location}/moodelMonitors/-/modelMonitoringJobs`
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the ModelMonitoringJob.
        /// Format:
        /// `projects/{project}/locations/{location}/modelMonitors/{model_monitor}`
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
        /// <returns>A pageable sequence of <see cref="ModelMonitoringJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListModelMonitoringJobsResponse, ModelMonitoringJob> ListModelMonitoringJobs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelMonitoringJobsRequest request = new ListModelMonitoringJobsRequest
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
            return ListModelMonitoringJobs(request, callSettings);
        }

        /// <summary>
        /// Lists ModelMonitoringJobs.
        /// Callers may choose to read across multiple Monitors as per
        /// [AIP-159](https://google.aip.dev/159) by using '-' (the hyphen or dash
        /// character) as a wildcard character instead of modelMonitor id in the
        /// parent. Format
        /// `projects/{project_id}/locations/{location}/moodelMonitors/-/modelMonitoringJobs`
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the ModelMonitoringJob.
        /// Format:
        /// `projects/{project}/locations/{location}/modelMonitors/{model_monitor}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ModelMonitoringJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListModelMonitoringJobsResponse, ModelMonitoringJob> ListModelMonitoringJobsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelMonitoringJobsRequest request = new ListModelMonitoringJobsRequest
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
            return ListModelMonitoringJobsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists ModelMonitoringJobs.
        /// Callers may choose to read across multiple Monitors as per
        /// [AIP-159](https://google.aip.dev/159) by using '-' (the hyphen or dash
        /// character) as a wildcard character instead of modelMonitor id in the
        /// parent. Format
        /// `projects/{project_id}/locations/{location}/moodelMonitors/-/modelMonitoringJobs`
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the ModelMonitoringJob.
        /// Format:
        /// `projects/{project}/locations/{location}/modelMonitors/{model_monitor}`
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
        /// <returns>A pageable sequence of <see cref="ModelMonitoringJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListModelMonitoringJobsResponse, ModelMonitoringJob> ListModelMonitoringJobs(ModelMonitorName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelMonitoringJobsRequest request = new ListModelMonitoringJobsRequest
            {
                ParentAsModelMonitorName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListModelMonitoringJobs(request, callSettings);
        }

        /// <summary>
        /// Lists ModelMonitoringJobs.
        /// Callers may choose to read across multiple Monitors as per
        /// [AIP-159](https://google.aip.dev/159) by using '-' (the hyphen or dash
        /// character) as a wildcard character instead of modelMonitor id in the
        /// parent. Format
        /// `projects/{project_id}/locations/{location}/moodelMonitors/-/modelMonitoringJobs`
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the ModelMonitoringJob.
        /// Format:
        /// `projects/{project}/locations/{location}/modelMonitors/{model_monitor}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ModelMonitoringJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListModelMonitoringJobsResponse, ModelMonitoringJob> ListModelMonitoringJobsAsync(ModelMonitorName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelMonitoringJobsRequest request = new ListModelMonitoringJobsRequest
            {
                ParentAsModelMonitorName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListModelMonitoringJobsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a ModelMonitoringJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteModelMonitoringJob(DeleteModelMonitoringJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a ModelMonitoringJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteModelMonitoringJobAsync(DeleteModelMonitoringJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a ModelMonitoringJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteModelMonitoringJobAsync(DeleteModelMonitoringJobRequest request, st::CancellationToken cancellationToken) =>
            DeleteModelMonitoringJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteModelMonitoringJob</c>.</summary>
        public virtual lro::OperationsClient DeleteModelMonitoringJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteModelMonitoringJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> PollOnceDeleteModelMonitoringJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteModelMonitoringJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteModelMonitoringJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> PollOnceDeleteModelMonitoringJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteModelMonitoringJobOperationsClient, callSettings);

        /// <summary>
        /// Deletes a ModelMonitoringJob.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the model monitoring job to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/modelMonitors/{model_monitor}/modelMonitoringJobs/{model_monitoring_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteModelMonitoringJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteModelMonitoringJob(new DeleteModelMonitoringJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a ModelMonitoringJob.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the model monitoring job to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/modelMonitors/{model_monitor}/modelMonitoringJobs/{model_monitoring_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteModelMonitoringJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteModelMonitoringJobAsync(new DeleteModelMonitoringJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a ModelMonitoringJob.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the model monitoring job to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/modelMonitors/{model_monitor}/modelMonitoringJobs/{model_monitoring_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteModelMonitoringJobAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteModelMonitoringJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a ModelMonitoringJob.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the model monitoring job to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/modelMonitors/{model_monitor}/modelMonitoringJobs/{model_monitoring_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteModelMonitoringJob(ModelMonitoringJobName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteModelMonitoringJob(new DeleteModelMonitoringJobRequest
            {
                ModelMonitoringJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a ModelMonitoringJob.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the model monitoring job to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/modelMonitors/{model_monitor}/modelMonitoringJobs/{model_monitoring_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteModelMonitoringJobAsync(ModelMonitoringJobName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteModelMonitoringJobAsync(new DeleteModelMonitoringJobRequest
            {
                ModelMonitoringJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a ModelMonitoringJob.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the model monitoring job to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/modelMonitors/{model_monitor}/modelMonitoringJobs/{model_monitoring_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteModelMonitoringJobAsync(ModelMonitoringJobName name, st::CancellationToken cancellationToken) =>
            DeleteModelMonitoringJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Searches Model Monitoring Stats generated within a given time window.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ModelMonitoringStats"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchModelMonitoringStatsResponse, ModelMonitoringStats> SearchModelMonitoringStats(SearchModelMonitoringStatsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches Model Monitoring Stats generated within a given time window.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ModelMonitoringStats"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchModelMonitoringStatsResponse, ModelMonitoringStats> SearchModelMonitoringStatsAsync(SearchModelMonitoringStatsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches Model Monitoring Stats generated within a given time window.
        /// </summary>
        /// <param name="modelMonitor">
        /// Required. ModelMonitor resource name.
        /// Format:
        /// `projects/{project}/locations/{location}/modelMonitors/{model_monitor}`
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
        /// <returns>A pageable sequence of <see cref="ModelMonitoringStats"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchModelMonitoringStatsResponse, ModelMonitoringStats> SearchModelMonitoringStats(string modelMonitor, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchModelMonitoringStatsRequest request = new SearchModelMonitoringStatsRequest
            {
                ModelMonitor = gax::GaxPreconditions.CheckNotNullOrEmpty(modelMonitor, nameof(modelMonitor)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchModelMonitoringStats(request, callSettings);
        }

        /// <summary>
        /// Searches Model Monitoring Stats generated within a given time window.
        /// </summary>
        /// <param name="modelMonitor">
        /// Required. ModelMonitor resource name.
        /// Format:
        /// `projects/{project}/locations/{location}/modelMonitors/{model_monitor}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ModelMonitoringStats"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchModelMonitoringStatsResponse, ModelMonitoringStats> SearchModelMonitoringStatsAsync(string modelMonitor, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchModelMonitoringStatsRequest request = new SearchModelMonitoringStatsRequest
            {
                ModelMonitor = gax::GaxPreconditions.CheckNotNullOrEmpty(modelMonitor, nameof(modelMonitor)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchModelMonitoringStatsAsync(request, callSettings);
        }

        /// <summary>
        /// Searches Model Monitoring Stats generated within a given time window.
        /// </summary>
        /// <param name="modelMonitor">
        /// Required. ModelMonitor resource name.
        /// Format:
        /// `projects/{project}/locations/{location}/modelMonitors/{model_monitor}`
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
        /// <returns>A pageable sequence of <see cref="ModelMonitoringStats"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchModelMonitoringStatsResponse, ModelMonitoringStats> SearchModelMonitoringStats(ModelMonitorName modelMonitor, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchModelMonitoringStatsRequest request = new SearchModelMonitoringStatsRequest
            {
                ModelMonitorAsModelMonitorName = gax::GaxPreconditions.CheckNotNull(modelMonitor, nameof(modelMonitor)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchModelMonitoringStats(request, callSettings);
        }

        /// <summary>
        /// Searches Model Monitoring Stats generated within a given time window.
        /// </summary>
        /// <param name="modelMonitor">
        /// Required. ModelMonitor resource name.
        /// Format:
        /// `projects/{project}/locations/{location}/modelMonitors/{model_monitor}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ModelMonitoringStats"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchModelMonitoringStatsResponse, ModelMonitoringStats> SearchModelMonitoringStatsAsync(ModelMonitorName modelMonitor, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchModelMonitoringStatsRequest request = new SearchModelMonitoringStatsRequest
            {
                ModelMonitorAsModelMonitorName = gax::GaxPreconditions.CheckNotNull(modelMonitor, nameof(modelMonitor)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchModelMonitoringStatsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the Model Monitoring alerts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ModelMonitoringAlert"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchModelMonitoringAlertsResponse, ModelMonitoringAlert> SearchModelMonitoringAlerts(SearchModelMonitoringAlertsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the Model Monitoring alerts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ModelMonitoringAlert"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchModelMonitoringAlertsResponse, ModelMonitoringAlert> SearchModelMonitoringAlertsAsync(SearchModelMonitoringAlertsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the Model Monitoring alerts.
        /// </summary>
        /// <param name="modelMonitor">
        /// Required. ModelMonitor resource name.
        /// Format:
        /// `projects/{project}/locations/{location}/modelMonitors/{model_monitor}`
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
        /// <returns>A pageable sequence of <see cref="ModelMonitoringAlert"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchModelMonitoringAlertsResponse, ModelMonitoringAlert> SearchModelMonitoringAlerts(string modelMonitor, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchModelMonitoringAlertsRequest request = new SearchModelMonitoringAlertsRequest
            {
                ModelMonitor = gax::GaxPreconditions.CheckNotNullOrEmpty(modelMonitor, nameof(modelMonitor)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchModelMonitoringAlerts(request, callSettings);
        }

        /// <summary>
        /// Returns the Model Monitoring alerts.
        /// </summary>
        /// <param name="modelMonitor">
        /// Required. ModelMonitor resource name.
        /// Format:
        /// `projects/{project}/locations/{location}/modelMonitors/{model_monitor}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ModelMonitoringAlert"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchModelMonitoringAlertsResponse, ModelMonitoringAlert> SearchModelMonitoringAlertsAsync(string modelMonitor, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchModelMonitoringAlertsRequest request = new SearchModelMonitoringAlertsRequest
            {
                ModelMonitor = gax::GaxPreconditions.CheckNotNullOrEmpty(modelMonitor, nameof(modelMonitor)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchModelMonitoringAlertsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the Model Monitoring alerts.
        /// </summary>
        /// <param name="modelMonitor">
        /// Required. ModelMonitor resource name.
        /// Format:
        /// `projects/{project}/locations/{location}/modelMonitors/{model_monitor}`
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
        /// <returns>A pageable sequence of <see cref="ModelMonitoringAlert"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchModelMonitoringAlertsResponse, ModelMonitoringAlert> SearchModelMonitoringAlerts(ModelMonitorName modelMonitor, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchModelMonitoringAlertsRequest request = new SearchModelMonitoringAlertsRequest
            {
                ModelMonitorAsModelMonitorName = gax::GaxPreconditions.CheckNotNull(modelMonitor, nameof(modelMonitor)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchModelMonitoringAlerts(request, callSettings);
        }

        /// <summary>
        /// Returns the Model Monitoring alerts.
        /// </summary>
        /// <param name="modelMonitor">
        /// Required. ModelMonitor resource name.
        /// Format:
        /// `projects/{project}/locations/{location}/modelMonitors/{model_monitor}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ModelMonitoringAlert"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchModelMonitoringAlertsResponse, ModelMonitoringAlert> SearchModelMonitoringAlertsAsync(ModelMonitorName modelMonitor, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchModelMonitoringAlertsRequest request = new SearchModelMonitoringAlertsRequest
            {
                ModelMonitorAsModelMonitorName = gax::GaxPreconditions.CheckNotNull(modelMonitor, nameof(modelMonitor)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchModelMonitoringAlertsAsync(request, callSettings);
        }
    }

    /// <summary>ModelMonitoringService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service for creating and managing Vertex AI Model moitoring. This includes
    /// `ModelMonitor` resources, `ModelMonitoringJob` resources.
    /// </remarks>
    public sealed partial class ModelMonitoringServiceClientImpl : ModelMonitoringServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateModelMonitorRequest, lro::Operation> _callCreateModelMonitor;

        private readonly gaxgrpc::ApiCall<UpdateModelMonitorRequest, lro::Operation> _callUpdateModelMonitor;

        private readonly gaxgrpc::ApiCall<GetModelMonitorRequest, ModelMonitor> _callGetModelMonitor;

        private readonly gaxgrpc::ApiCall<ListModelMonitorsRequest, ListModelMonitorsResponse> _callListModelMonitors;

        private readonly gaxgrpc::ApiCall<DeleteModelMonitorRequest, lro::Operation> _callDeleteModelMonitor;

        private readonly gaxgrpc::ApiCall<CreateModelMonitoringJobRequest, ModelMonitoringJob> _callCreateModelMonitoringJob;

        private readonly gaxgrpc::ApiCall<GetModelMonitoringJobRequest, ModelMonitoringJob> _callGetModelMonitoringJob;

        private readonly gaxgrpc::ApiCall<ListModelMonitoringJobsRequest, ListModelMonitoringJobsResponse> _callListModelMonitoringJobs;

        private readonly gaxgrpc::ApiCall<DeleteModelMonitoringJobRequest, lro::Operation> _callDeleteModelMonitoringJob;

        private readonly gaxgrpc::ApiCall<SearchModelMonitoringStatsRequest, SearchModelMonitoringStatsResponse> _callSearchModelMonitoringStats;

        private readonly gaxgrpc::ApiCall<SearchModelMonitoringAlertsRequest, SearchModelMonitoringAlertsResponse> _callSearchModelMonitoringAlerts;

        /// <summary>
        /// Constructs a client wrapper for the ModelMonitoringService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="ModelMonitoringServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ModelMonitoringServiceClientImpl(ModelMonitoringService.ModelMonitoringServiceClient grpcClient, ModelMonitoringServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ModelMonitoringServiceSettings effectiveSettings = settings ?? ModelMonitoringServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateModelMonitorOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateModelMonitorOperationsSettings, logger);
            UpdateModelMonitorOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateModelMonitorOperationsSettings, logger);
            DeleteModelMonitorOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteModelMonitorOperationsSettings, logger);
            DeleteModelMonitoringJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteModelMonitoringJobOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreateModelMonitor = clientHelper.BuildApiCall<CreateModelMonitorRequest, lro::Operation>("CreateModelMonitor", grpcClient.CreateModelMonitorAsync, grpcClient.CreateModelMonitor, effectiveSettings.CreateModelMonitorSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateModelMonitor);
            Modify_CreateModelMonitorApiCall(ref _callCreateModelMonitor);
            _callUpdateModelMonitor = clientHelper.BuildApiCall<UpdateModelMonitorRequest, lro::Operation>("UpdateModelMonitor", grpcClient.UpdateModelMonitorAsync, grpcClient.UpdateModelMonitor, effectiveSettings.UpdateModelMonitorSettings).WithGoogleRequestParam("model_monitor.name", request => request.ModelMonitor?.Name);
            Modify_ApiCall(ref _callUpdateModelMonitor);
            Modify_UpdateModelMonitorApiCall(ref _callUpdateModelMonitor);
            _callGetModelMonitor = clientHelper.BuildApiCall<GetModelMonitorRequest, ModelMonitor>("GetModelMonitor", grpcClient.GetModelMonitorAsync, grpcClient.GetModelMonitor, effectiveSettings.GetModelMonitorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetModelMonitor);
            Modify_GetModelMonitorApiCall(ref _callGetModelMonitor);
            _callListModelMonitors = clientHelper.BuildApiCall<ListModelMonitorsRequest, ListModelMonitorsResponse>("ListModelMonitors", grpcClient.ListModelMonitorsAsync, grpcClient.ListModelMonitors, effectiveSettings.ListModelMonitorsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListModelMonitors);
            Modify_ListModelMonitorsApiCall(ref _callListModelMonitors);
            _callDeleteModelMonitor = clientHelper.BuildApiCall<DeleteModelMonitorRequest, lro::Operation>("DeleteModelMonitor", grpcClient.DeleteModelMonitorAsync, grpcClient.DeleteModelMonitor, effectiveSettings.DeleteModelMonitorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteModelMonitor);
            Modify_DeleteModelMonitorApiCall(ref _callDeleteModelMonitor);
            _callCreateModelMonitoringJob = clientHelper.BuildApiCall<CreateModelMonitoringJobRequest, ModelMonitoringJob>("CreateModelMonitoringJob", grpcClient.CreateModelMonitoringJobAsync, grpcClient.CreateModelMonitoringJob, effectiveSettings.CreateModelMonitoringJobSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateModelMonitoringJob);
            Modify_CreateModelMonitoringJobApiCall(ref _callCreateModelMonitoringJob);
            _callGetModelMonitoringJob = clientHelper.BuildApiCall<GetModelMonitoringJobRequest, ModelMonitoringJob>("GetModelMonitoringJob", grpcClient.GetModelMonitoringJobAsync, grpcClient.GetModelMonitoringJob, effectiveSettings.GetModelMonitoringJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetModelMonitoringJob);
            Modify_GetModelMonitoringJobApiCall(ref _callGetModelMonitoringJob);
            _callListModelMonitoringJobs = clientHelper.BuildApiCall<ListModelMonitoringJobsRequest, ListModelMonitoringJobsResponse>("ListModelMonitoringJobs", grpcClient.ListModelMonitoringJobsAsync, grpcClient.ListModelMonitoringJobs, effectiveSettings.ListModelMonitoringJobsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListModelMonitoringJobs);
            Modify_ListModelMonitoringJobsApiCall(ref _callListModelMonitoringJobs);
            _callDeleteModelMonitoringJob = clientHelper.BuildApiCall<DeleteModelMonitoringJobRequest, lro::Operation>("DeleteModelMonitoringJob", grpcClient.DeleteModelMonitoringJobAsync, grpcClient.DeleteModelMonitoringJob, effectiveSettings.DeleteModelMonitoringJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteModelMonitoringJob);
            Modify_DeleteModelMonitoringJobApiCall(ref _callDeleteModelMonitoringJob);
            _callSearchModelMonitoringStats = clientHelper.BuildApiCall<SearchModelMonitoringStatsRequest, SearchModelMonitoringStatsResponse>("SearchModelMonitoringStats", grpcClient.SearchModelMonitoringStatsAsync, grpcClient.SearchModelMonitoringStats, effectiveSettings.SearchModelMonitoringStatsSettings).WithGoogleRequestParam("model_monitor", request => request.ModelMonitor);
            Modify_ApiCall(ref _callSearchModelMonitoringStats);
            Modify_SearchModelMonitoringStatsApiCall(ref _callSearchModelMonitoringStats);
            _callSearchModelMonitoringAlerts = clientHelper.BuildApiCall<SearchModelMonitoringAlertsRequest, SearchModelMonitoringAlertsResponse>("SearchModelMonitoringAlerts", grpcClient.SearchModelMonitoringAlertsAsync, grpcClient.SearchModelMonitoringAlerts, effectiveSettings.SearchModelMonitoringAlertsSettings).WithGoogleRequestParam("model_monitor", request => request.ModelMonitor);
            Modify_ApiCall(ref _callSearchModelMonitoringAlerts);
            Modify_SearchModelMonitoringAlertsApiCall(ref _callSearchModelMonitoringAlerts);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateModelMonitorApiCall(ref gaxgrpc::ApiCall<CreateModelMonitorRequest, lro::Operation> call);

        partial void Modify_UpdateModelMonitorApiCall(ref gaxgrpc::ApiCall<UpdateModelMonitorRequest, lro::Operation> call);

        partial void Modify_GetModelMonitorApiCall(ref gaxgrpc::ApiCall<GetModelMonitorRequest, ModelMonitor> call);

        partial void Modify_ListModelMonitorsApiCall(ref gaxgrpc::ApiCall<ListModelMonitorsRequest, ListModelMonitorsResponse> call);

        partial void Modify_DeleteModelMonitorApiCall(ref gaxgrpc::ApiCall<DeleteModelMonitorRequest, lro::Operation> call);

        partial void Modify_CreateModelMonitoringJobApiCall(ref gaxgrpc::ApiCall<CreateModelMonitoringJobRequest, ModelMonitoringJob> call);

        partial void Modify_GetModelMonitoringJobApiCall(ref gaxgrpc::ApiCall<GetModelMonitoringJobRequest, ModelMonitoringJob> call);

        partial void Modify_ListModelMonitoringJobsApiCall(ref gaxgrpc::ApiCall<ListModelMonitoringJobsRequest, ListModelMonitoringJobsResponse> call);

        partial void Modify_DeleteModelMonitoringJobApiCall(ref gaxgrpc::ApiCall<DeleteModelMonitoringJobRequest, lro::Operation> call);

        partial void Modify_SearchModelMonitoringStatsApiCall(ref gaxgrpc::ApiCall<SearchModelMonitoringStatsRequest, SearchModelMonitoringStatsResponse> call);

        partial void Modify_SearchModelMonitoringAlertsApiCall(ref gaxgrpc::ApiCall<SearchModelMonitoringAlertsRequest, SearchModelMonitoringAlertsResponse> call);

        partial void OnConstruction(ModelMonitoringService.ModelMonitoringServiceClient grpcClient, ModelMonitoringServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ModelMonitoringService client</summary>
        public override ModelMonitoringService.ModelMonitoringServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateModelMonitorRequest(ref CreateModelMonitorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateModelMonitorRequest(ref UpdateModelMonitorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetModelMonitorRequest(ref GetModelMonitorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListModelMonitorsRequest(ref ListModelMonitorsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteModelMonitorRequest(ref DeleteModelMonitorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateModelMonitoringJobRequest(ref CreateModelMonitoringJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetModelMonitoringJobRequest(ref GetModelMonitoringJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListModelMonitoringJobsRequest(ref ListModelMonitoringJobsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteModelMonitoringJobRequest(ref DeleteModelMonitoringJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchModelMonitoringStatsRequest(ref SearchModelMonitoringStatsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchModelMonitoringAlertsRequest(ref SearchModelMonitoringAlertsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateModelMonitor</c>.</summary>
        public override lro::OperationsClient CreateModelMonitorOperationsClient { get; }

        /// <summary>
        /// Creates a ModelMonitor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ModelMonitor, CreateModelMonitorOperationMetadata> CreateModelMonitor(CreateModelMonitorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateModelMonitorRequest(ref request, ref callSettings);
            return new lro::Operation<ModelMonitor, CreateModelMonitorOperationMetadata>(_callCreateModelMonitor.Sync(request, callSettings), CreateModelMonitorOperationsClient);
        }

        /// <summary>
        /// Creates a ModelMonitor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ModelMonitor, CreateModelMonitorOperationMetadata>> CreateModelMonitorAsync(CreateModelMonitorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateModelMonitorRequest(ref request, ref callSettings);
            return new lro::Operation<ModelMonitor, CreateModelMonitorOperationMetadata>(await _callCreateModelMonitor.Async(request, callSettings).ConfigureAwait(false), CreateModelMonitorOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateModelMonitor</c>.</summary>
        public override lro::OperationsClient UpdateModelMonitorOperationsClient { get; }

        /// <summary>
        /// Updates a ModelMonitor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ModelMonitor, UpdateModelMonitorOperationMetadata> UpdateModelMonitor(UpdateModelMonitorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateModelMonitorRequest(ref request, ref callSettings);
            return new lro::Operation<ModelMonitor, UpdateModelMonitorOperationMetadata>(_callUpdateModelMonitor.Sync(request, callSettings), UpdateModelMonitorOperationsClient);
        }

        /// <summary>
        /// Updates a ModelMonitor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ModelMonitor, UpdateModelMonitorOperationMetadata>> UpdateModelMonitorAsync(UpdateModelMonitorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateModelMonitorRequest(ref request, ref callSettings);
            return new lro::Operation<ModelMonitor, UpdateModelMonitorOperationMetadata>(await _callUpdateModelMonitor.Async(request, callSettings).ConfigureAwait(false), UpdateModelMonitorOperationsClient);
        }

        /// <summary>
        /// Gets a ModelMonitor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ModelMonitor GetModelMonitor(GetModelMonitorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetModelMonitorRequest(ref request, ref callSettings);
            return _callGetModelMonitor.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a ModelMonitor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ModelMonitor> GetModelMonitorAsync(GetModelMonitorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetModelMonitorRequest(ref request, ref callSettings);
            return _callGetModelMonitor.Async(request, callSettings);
        }

        /// <summary>
        /// Lists ModelMonitors in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ModelMonitor"/> resources.</returns>
        public override gax::PagedEnumerable<ListModelMonitorsResponse, ModelMonitor> ListModelMonitors(ListModelMonitorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListModelMonitorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListModelMonitorsRequest, ListModelMonitorsResponse, ModelMonitor>(_callListModelMonitors, request, callSettings);
        }

        /// <summary>
        /// Lists ModelMonitors in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ModelMonitor"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListModelMonitorsResponse, ModelMonitor> ListModelMonitorsAsync(ListModelMonitorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListModelMonitorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListModelMonitorsRequest, ListModelMonitorsResponse, ModelMonitor>(_callListModelMonitors, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteModelMonitor</c>.</summary>
        public override lro::OperationsClient DeleteModelMonitorOperationsClient { get; }

        /// <summary>
        /// Deletes a ModelMonitor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteModelMonitor(DeleteModelMonitorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteModelMonitorRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(_callDeleteModelMonitor.Sync(request, callSettings), DeleteModelMonitorOperationsClient);
        }

        /// <summary>
        /// Deletes a ModelMonitor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteModelMonitorAsync(DeleteModelMonitorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteModelMonitorRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(await _callDeleteModelMonitor.Async(request, callSettings).ConfigureAwait(false), DeleteModelMonitorOperationsClient);
        }

        /// <summary>
        /// Creates a ModelMonitoringJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ModelMonitoringJob CreateModelMonitoringJob(CreateModelMonitoringJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateModelMonitoringJobRequest(ref request, ref callSettings);
            return _callCreateModelMonitoringJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a ModelMonitoringJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ModelMonitoringJob> CreateModelMonitoringJobAsync(CreateModelMonitoringJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateModelMonitoringJobRequest(ref request, ref callSettings);
            return _callCreateModelMonitoringJob.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a ModelMonitoringJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ModelMonitoringJob GetModelMonitoringJob(GetModelMonitoringJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetModelMonitoringJobRequest(ref request, ref callSettings);
            return _callGetModelMonitoringJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a ModelMonitoringJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ModelMonitoringJob> GetModelMonitoringJobAsync(GetModelMonitoringJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetModelMonitoringJobRequest(ref request, ref callSettings);
            return _callGetModelMonitoringJob.Async(request, callSettings);
        }

        /// <summary>
        /// Lists ModelMonitoringJobs.
        /// Callers may choose to read across multiple Monitors as per
        /// [AIP-159](https://google.aip.dev/159) by using '-' (the hyphen or dash
        /// character) as a wildcard character instead of modelMonitor id in the
        /// parent. Format
        /// `projects/{project_id}/locations/{location}/moodelMonitors/-/modelMonitoringJobs`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ModelMonitoringJob"/> resources.</returns>
        public override gax::PagedEnumerable<ListModelMonitoringJobsResponse, ModelMonitoringJob> ListModelMonitoringJobs(ListModelMonitoringJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListModelMonitoringJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListModelMonitoringJobsRequest, ListModelMonitoringJobsResponse, ModelMonitoringJob>(_callListModelMonitoringJobs, request, callSettings);
        }

        /// <summary>
        /// Lists ModelMonitoringJobs.
        /// Callers may choose to read across multiple Monitors as per
        /// [AIP-159](https://google.aip.dev/159) by using '-' (the hyphen or dash
        /// character) as a wildcard character instead of modelMonitor id in the
        /// parent. Format
        /// `projects/{project_id}/locations/{location}/moodelMonitors/-/modelMonitoringJobs`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ModelMonitoringJob"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListModelMonitoringJobsResponse, ModelMonitoringJob> ListModelMonitoringJobsAsync(ListModelMonitoringJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListModelMonitoringJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListModelMonitoringJobsRequest, ListModelMonitoringJobsResponse, ModelMonitoringJob>(_callListModelMonitoringJobs, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteModelMonitoringJob</c>.</summary>
        public override lro::OperationsClient DeleteModelMonitoringJobOperationsClient { get; }

        /// <summary>
        /// Deletes a ModelMonitoringJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteModelMonitoringJob(DeleteModelMonitoringJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteModelMonitoringJobRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(_callDeleteModelMonitoringJob.Sync(request, callSettings), DeleteModelMonitoringJobOperationsClient);
        }

        /// <summary>
        /// Deletes a ModelMonitoringJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteModelMonitoringJobAsync(DeleteModelMonitoringJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteModelMonitoringJobRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(await _callDeleteModelMonitoringJob.Async(request, callSettings).ConfigureAwait(false), DeleteModelMonitoringJobOperationsClient);
        }

        /// <summary>
        /// Searches Model Monitoring Stats generated within a given time window.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ModelMonitoringStats"/> resources.</returns>
        public override gax::PagedEnumerable<SearchModelMonitoringStatsResponse, ModelMonitoringStats> SearchModelMonitoringStats(SearchModelMonitoringStatsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchModelMonitoringStatsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchModelMonitoringStatsRequest, SearchModelMonitoringStatsResponse, ModelMonitoringStats>(_callSearchModelMonitoringStats, request, callSettings);
        }

        /// <summary>
        /// Searches Model Monitoring Stats generated within a given time window.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ModelMonitoringStats"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchModelMonitoringStatsResponse, ModelMonitoringStats> SearchModelMonitoringStatsAsync(SearchModelMonitoringStatsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchModelMonitoringStatsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchModelMonitoringStatsRequest, SearchModelMonitoringStatsResponse, ModelMonitoringStats>(_callSearchModelMonitoringStats, request, callSettings);
        }

        /// <summary>
        /// Returns the Model Monitoring alerts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ModelMonitoringAlert"/> resources.</returns>
        public override gax::PagedEnumerable<SearchModelMonitoringAlertsResponse, ModelMonitoringAlert> SearchModelMonitoringAlerts(SearchModelMonitoringAlertsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchModelMonitoringAlertsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchModelMonitoringAlertsRequest, SearchModelMonitoringAlertsResponse, ModelMonitoringAlert>(_callSearchModelMonitoringAlerts, request, callSettings);
        }

        /// <summary>
        /// Returns the Model Monitoring alerts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ModelMonitoringAlert"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchModelMonitoringAlertsResponse, ModelMonitoringAlert> SearchModelMonitoringAlertsAsync(SearchModelMonitoringAlertsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchModelMonitoringAlertsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchModelMonitoringAlertsRequest, SearchModelMonitoringAlertsResponse, ModelMonitoringAlert>(_callSearchModelMonitoringAlerts, request, callSettings);
        }
    }

    public partial class ListModelMonitorsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListModelMonitoringJobsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchModelMonitoringStatsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchModelMonitoringAlertsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListModelMonitorsResponse : gaxgrpc::IPageResponse<ModelMonitor>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ModelMonitor> GetEnumerator() => ModelMonitors.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListModelMonitoringJobsResponse : gaxgrpc::IPageResponse<ModelMonitoringJob>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ModelMonitoringJob> GetEnumerator() => ModelMonitoringJobs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class SearchModelMonitoringStatsResponse : gaxgrpc::IPageResponse<ModelMonitoringStats>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ModelMonitoringStats> GetEnumerator() => MonitoringStats.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class SearchModelMonitoringAlertsResponse : gaxgrpc::IPageResponse<ModelMonitoringAlert>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ModelMonitoringAlert> GetEnumerator() => ModelMonitoringAlerts.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ModelMonitoringService
    {
        public partial class ModelMonitoringServiceClient
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

    public static partial class ModelMonitoringService
    {
        public partial class ModelMonitoringServiceClient
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
