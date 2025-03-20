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
    /// <summary>Settings for <see cref="DeploymentResourcePoolServiceClient"/> instances.</summary>
    public sealed partial class DeploymentResourcePoolServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DeploymentResourcePoolServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DeploymentResourcePoolServiceSettings"/>.</returns>
        public static DeploymentResourcePoolServiceSettings GetDefault() => new DeploymentResourcePoolServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="DeploymentResourcePoolServiceSettings"/> object with default settings.
        /// </summary>
        public DeploymentResourcePoolServiceSettings()
        {
        }

        private DeploymentResourcePoolServiceSettings(DeploymentResourcePoolServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateDeploymentResourcePoolSettings = existing.CreateDeploymentResourcePoolSettings;
            CreateDeploymentResourcePoolOperationsSettings = existing.CreateDeploymentResourcePoolOperationsSettings.Clone();
            GetDeploymentResourcePoolSettings = existing.GetDeploymentResourcePoolSettings;
            ListDeploymentResourcePoolsSettings = existing.ListDeploymentResourcePoolsSettings;
            UpdateDeploymentResourcePoolSettings = existing.UpdateDeploymentResourcePoolSettings;
            UpdateDeploymentResourcePoolOperationsSettings = existing.UpdateDeploymentResourcePoolOperationsSettings.Clone();
            DeleteDeploymentResourcePoolSettings = existing.DeleteDeploymentResourcePoolSettings;
            DeleteDeploymentResourcePoolOperationsSettings = existing.DeleteDeploymentResourcePoolOperationsSettings.Clone();
            QueryDeployedModelsSettings = existing.QueryDeployedModelsSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(DeploymentResourcePoolServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeploymentResourcePoolServiceClient.CreateDeploymentResourcePool</c> and
        /// <c>DeploymentResourcePoolServiceClient.CreateDeploymentResourcePoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDeploymentResourcePoolSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>DeploymentResourcePoolServiceClient.CreateDeploymentResourcePool</c> and
        /// <c>DeploymentResourcePoolServiceClient.CreateDeploymentResourcePoolAsync</c>.
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
        public lro::OperationsSettings CreateDeploymentResourcePoolOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeploymentResourcePoolServiceClient.GetDeploymentResourcePool</c> and
        /// <c>DeploymentResourcePoolServiceClient.GetDeploymentResourcePoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDeploymentResourcePoolSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeploymentResourcePoolServiceClient.ListDeploymentResourcePools</c> and
        /// <c>DeploymentResourcePoolServiceClient.ListDeploymentResourcePoolsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDeploymentResourcePoolsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeploymentResourcePoolServiceClient.UpdateDeploymentResourcePool</c> and
        /// <c>DeploymentResourcePoolServiceClient.UpdateDeploymentResourcePoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDeploymentResourcePoolSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>DeploymentResourcePoolServiceClient.UpdateDeploymentResourcePool</c> and
        /// <c>DeploymentResourcePoolServiceClient.UpdateDeploymentResourcePoolAsync</c>.
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
        public lro::OperationsSettings UpdateDeploymentResourcePoolOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeploymentResourcePoolServiceClient.DeleteDeploymentResourcePool</c> and
        /// <c>DeploymentResourcePoolServiceClient.DeleteDeploymentResourcePoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDeploymentResourcePoolSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>DeploymentResourcePoolServiceClient.DeleteDeploymentResourcePool</c> and
        /// <c>DeploymentResourcePoolServiceClient.DeleteDeploymentResourcePoolAsync</c>.
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
        public lro::OperationsSettings DeleteDeploymentResourcePoolOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeploymentResourcePoolServiceClient.QueryDeployedModels</c> and
        /// <c>DeploymentResourcePoolServiceClient.QueryDeployedModelsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings QueryDeployedModelsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DeploymentResourcePoolServiceSettings"/> object.</returns>
        public DeploymentResourcePoolServiceSettings Clone() => new DeploymentResourcePoolServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DeploymentResourcePoolServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class DeploymentResourcePoolServiceClientBuilder : gaxgrpc::ClientBuilderBase<DeploymentResourcePoolServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DeploymentResourcePoolServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DeploymentResourcePoolServiceClientBuilder() : base(DeploymentResourcePoolServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DeploymentResourcePoolServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DeploymentResourcePoolServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DeploymentResourcePoolServiceClient Build()
        {
            DeploymentResourcePoolServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DeploymentResourcePoolServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DeploymentResourcePoolServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DeploymentResourcePoolServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DeploymentResourcePoolServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DeploymentResourcePoolServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DeploymentResourcePoolServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DeploymentResourcePoolServiceClient.ChannelPool;
    }

    /// <summary>DeploymentResourcePoolService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service that manages the DeploymentResourcePool resource.
    /// </remarks>
    public abstract partial class DeploymentResourcePoolServiceClient
    {
        /// <summary>
        /// The default endpoint for the DeploymentResourcePoolService service, which is a host of
        /// "aiplatform.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "aiplatform.googleapis.com:443";

        /// <summary>The default DeploymentResourcePoolService scopes.</summary>
        /// <remarks>
        /// The default DeploymentResourcePoolService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DeploymentResourcePoolService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DeploymentResourcePoolServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="DeploymentResourcePoolServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DeploymentResourcePoolServiceClient"/>.</returns>
        public static stt::Task<DeploymentResourcePoolServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DeploymentResourcePoolServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DeploymentResourcePoolServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="DeploymentResourcePoolServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DeploymentResourcePoolServiceClient"/>.</returns>
        public static DeploymentResourcePoolServiceClient Create() =>
            new DeploymentResourcePoolServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DeploymentResourcePoolServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DeploymentResourcePoolServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DeploymentResourcePoolServiceClient"/>.</returns>
        internal static DeploymentResourcePoolServiceClient Create(grpccore::CallInvoker callInvoker, DeploymentResourcePoolServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DeploymentResourcePoolService.DeploymentResourcePoolServiceClient grpcClient = new DeploymentResourcePoolService.DeploymentResourcePoolServiceClient(callInvoker);
            return new DeploymentResourcePoolServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DeploymentResourcePoolService client</summary>
        public virtual DeploymentResourcePoolService.DeploymentResourcePoolServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Create a DeploymentResourcePool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeploymentResourcePool, CreateDeploymentResourcePoolOperationMetadata> CreateDeploymentResourcePool(CreateDeploymentResourcePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a DeploymentResourcePool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeploymentResourcePool, CreateDeploymentResourcePoolOperationMetadata>> CreateDeploymentResourcePoolAsync(CreateDeploymentResourcePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a DeploymentResourcePool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeploymentResourcePool, CreateDeploymentResourcePoolOperationMetadata>> CreateDeploymentResourcePoolAsync(CreateDeploymentResourcePoolRequest request, st::CancellationToken cancellationToken) =>
            CreateDeploymentResourcePoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateDeploymentResourcePool</c>.</summary>
        public virtual lro::OperationsClient CreateDeploymentResourcePoolOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateDeploymentResourcePool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DeploymentResourcePool, CreateDeploymentResourcePoolOperationMetadata> PollOnceCreateDeploymentResourcePool(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DeploymentResourcePool, CreateDeploymentResourcePoolOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDeploymentResourcePoolOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateDeploymentResourcePool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DeploymentResourcePool, CreateDeploymentResourcePoolOperationMetadata>> PollOnceCreateDeploymentResourcePoolAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DeploymentResourcePool, CreateDeploymentResourcePoolOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDeploymentResourcePoolOperationsClient, callSettings);

        /// <summary>
        /// Create a DeploymentResourcePool.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location resource where this DeploymentResourcePool
        /// will be created. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="deploymentResourcePool">
        /// Required. The DeploymentResourcePool to create.
        /// </param>
        /// <param name="deploymentResourcePoolId">
        /// Required. The ID to use for the DeploymentResourcePool, which
        /// will become the final component of the DeploymentResourcePool's resource
        /// name.
        /// 
        /// The maximum length is 63 characters, and valid characters
        /// are `/^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeploymentResourcePool, CreateDeploymentResourcePoolOperationMetadata> CreateDeploymentResourcePool(string parent, DeploymentResourcePool deploymentResourcePool, string deploymentResourcePoolId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeploymentResourcePool(new CreateDeploymentResourcePoolRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DeploymentResourcePool = gax::GaxPreconditions.CheckNotNull(deploymentResourcePool, nameof(deploymentResourcePool)),
                DeploymentResourcePoolId = gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentResourcePoolId, nameof(deploymentResourcePoolId)),
            }, callSettings);

        /// <summary>
        /// Create a DeploymentResourcePool.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location resource where this DeploymentResourcePool
        /// will be created. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="deploymentResourcePool">
        /// Required. The DeploymentResourcePool to create.
        /// </param>
        /// <param name="deploymentResourcePoolId">
        /// Required. The ID to use for the DeploymentResourcePool, which
        /// will become the final component of the DeploymentResourcePool's resource
        /// name.
        /// 
        /// The maximum length is 63 characters, and valid characters
        /// are `/^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeploymentResourcePool, CreateDeploymentResourcePoolOperationMetadata>> CreateDeploymentResourcePoolAsync(string parent, DeploymentResourcePool deploymentResourcePool, string deploymentResourcePoolId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeploymentResourcePoolAsync(new CreateDeploymentResourcePoolRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DeploymentResourcePool = gax::GaxPreconditions.CheckNotNull(deploymentResourcePool, nameof(deploymentResourcePool)),
                DeploymentResourcePoolId = gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentResourcePoolId, nameof(deploymentResourcePoolId)),
            }, callSettings);

        /// <summary>
        /// Create a DeploymentResourcePool.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location resource where this DeploymentResourcePool
        /// will be created. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="deploymentResourcePool">
        /// Required. The DeploymentResourcePool to create.
        /// </param>
        /// <param name="deploymentResourcePoolId">
        /// Required. The ID to use for the DeploymentResourcePool, which
        /// will become the final component of the DeploymentResourcePool's resource
        /// name.
        /// 
        /// The maximum length is 63 characters, and valid characters
        /// are `/^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$/`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeploymentResourcePool, CreateDeploymentResourcePoolOperationMetadata>> CreateDeploymentResourcePoolAsync(string parent, DeploymentResourcePool deploymentResourcePool, string deploymentResourcePoolId, st::CancellationToken cancellationToken) =>
            CreateDeploymentResourcePoolAsync(parent, deploymentResourcePool, deploymentResourcePoolId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a DeploymentResourcePool.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location resource where this DeploymentResourcePool
        /// will be created. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="deploymentResourcePool">
        /// Required. The DeploymentResourcePool to create.
        /// </param>
        /// <param name="deploymentResourcePoolId">
        /// Required. The ID to use for the DeploymentResourcePool, which
        /// will become the final component of the DeploymentResourcePool's resource
        /// name.
        /// 
        /// The maximum length is 63 characters, and valid characters
        /// are `/^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeploymentResourcePool, CreateDeploymentResourcePoolOperationMetadata> CreateDeploymentResourcePool(gagr::LocationName parent, DeploymentResourcePool deploymentResourcePool, string deploymentResourcePoolId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeploymentResourcePool(new CreateDeploymentResourcePoolRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DeploymentResourcePool = gax::GaxPreconditions.CheckNotNull(deploymentResourcePool, nameof(deploymentResourcePool)),
                DeploymentResourcePoolId = gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentResourcePoolId, nameof(deploymentResourcePoolId)),
            }, callSettings);

        /// <summary>
        /// Create a DeploymentResourcePool.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location resource where this DeploymentResourcePool
        /// will be created. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="deploymentResourcePool">
        /// Required. The DeploymentResourcePool to create.
        /// </param>
        /// <param name="deploymentResourcePoolId">
        /// Required. The ID to use for the DeploymentResourcePool, which
        /// will become the final component of the DeploymentResourcePool's resource
        /// name.
        /// 
        /// The maximum length is 63 characters, and valid characters
        /// are `/^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeploymentResourcePool, CreateDeploymentResourcePoolOperationMetadata>> CreateDeploymentResourcePoolAsync(gagr::LocationName parent, DeploymentResourcePool deploymentResourcePool, string deploymentResourcePoolId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeploymentResourcePoolAsync(new CreateDeploymentResourcePoolRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DeploymentResourcePool = gax::GaxPreconditions.CheckNotNull(deploymentResourcePool, nameof(deploymentResourcePool)),
                DeploymentResourcePoolId = gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentResourcePoolId, nameof(deploymentResourcePoolId)),
            }, callSettings);

        /// <summary>
        /// Create a DeploymentResourcePool.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location resource where this DeploymentResourcePool
        /// will be created. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="deploymentResourcePool">
        /// Required. The DeploymentResourcePool to create.
        /// </param>
        /// <param name="deploymentResourcePoolId">
        /// Required. The ID to use for the DeploymentResourcePool, which
        /// will become the final component of the DeploymentResourcePool's resource
        /// name.
        /// 
        /// The maximum length is 63 characters, and valid characters
        /// are `/^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$/`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeploymentResourcePool, CreateDeploymentResourcePoolOperationMetadata>> CreateDeploymentResourcePoolAsync(gagr::LocationName parent, DeploymentResourcePool deploymentResourcePool, string deploymentResourcePoolId, st::CancellationToken cancellationToken) =>
            CreateDeploymentResourcePoolAsync(parent, deploymentResourcePool, deploymentResourcePoolId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a DeploymentResourcePool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeploymentResourcePool GetDeploymentResourcePool(GetDeploymentResourcePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a DeploymentResourcePool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeploymentResourcePool> GetDeploymentResourcePoolAsync(GetDeploymentResourcePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a DeploymentResourcePool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeploymentResourcePool> GetDeploymentResourcePoolAsync(GetDeploymentResourcePoolRequest request, st::CancellationToken cancellationToken) =>
            GetDeploymentResourcePoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a DeploymentResourcePool.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DeploymentResourcePool to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/deploymentResourcePools/{deployment_resource_pool}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeploymentResourcePool GetDeploymentResourcePool(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeploymentResourcePool(new GetDeploymentResourcePoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a DeploymentResourcePool.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DeploymentResourcePool to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/deploymentResourcePools/{deployment_resource_pool}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeploymentResourcePool> GetDeploymentResourcePoolAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeploymentResourcePoolAsync(new GetDeploymentResourcePoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a DeploymentResourcePool.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DeploymentResourcePool to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/deploymentResourcePools/{deployment_resource_pool}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeploymentResourcePool> GetDeploymentResourcePoolAsync(string name, st::CancellationToken cancellationToken) =>
            GetDeploymentResourcePoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a DeploymentResourcePool.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DeploymentResourcePool to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/deploymentResourcePools/{deployment_resource_pool}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeploymentResourcePool GetDeploymentResourcePool(DeploymentResourcePoolName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeploymentResourcePool(new GetDeploymentResourcePoolRequest
            {
                DeploymentResourcePoolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a DeploymentResourcePool.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DeploymentResourcePool to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/deploymentResourcePools/{deployment_resource_pool}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeploymentResourcePool> GetDeploymentResourcePoolAsync(DeploymentResourcePoolName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeploymentResourcePoolAsync(new GetDeploymentResourcePoolRequest
            {
                DeploymentResourcePoolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a DeploymentResourcePool.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DeploymentResourcePool to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/deploymentResourcePools/{deployment_resource_pool}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeploymentResourcePool> GetDeploymentResourcePoolAsync(DeploymentResourcePoolName name, st::CancellationToken cancellationToken) =>
            GetDeploymentResourcePoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List DeploymentResourcePools in a location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DeploymentResourcePool"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeploymentResourcePoolsResponse, DeploymentResourcePool> ListDeploymentResourcePools(ListDeploymentResourcePoolsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List DeploymentResourcePools in a location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DeploymentResourcePool"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeploymentResourcePoolsResponse, DeploymentResourcePool> ListDeploymentResourcePoolsAsync(ListDeploymentResourcePoolsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List DeploymentResourcePools in a location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent Location which owns this collection of
        /// DeploymentResourcePools. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="DeploymentResourcePool"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeploymentResourcePoolsResponse, DeploymentResourcePool> ListDeploymentResourcePools(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeploymentResourcePoolsRequest request = new ListDeploymentResourcePoolsRequest
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
            return ListDeploymentResourcePools(request, callSettings);
        }

        /// <summary>
        /// List DeploymentResourcePools in a location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent Location which owns this collection of
        /// DeploymentResourcePools. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="DeploymentResourcePool"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeploymentResourcePoolsResponse, DeploymentResourcePool> ListDeploymentResourcePoolsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeploymentResourcePoolsRequest request = new ListDeploymentResourcePoolsRequest
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
            return ListDeploymentResourcePoolsAsync(request, callSettings);
        }

        /// <summary>
        /// List DeploymentResourcePools in a location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent Location which owns this collection of
        /// DeploymentResourcePools. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="DeploymentResourcePool"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeploymentResourcePoolsResponse, DeploymentResourcePool> ListDeploymentResourcePools(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeploymentResourcePoolsRequest request = new ListDeploymentResourcePoolsRequest
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
            return ListDeploymentResourcePools(request, callSettings);
        }

        /// <summary>
        /// List DeploymentResourcePools in a location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent Location which owns this collection of
        /// DeploymentResourcePools. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="DeploymentResourcePool"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeploymentResourcePoolsResponse, DeploymentResourcePool> ListDeploymentResourcePoolsAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeploymentResourcePoolsRequest request = new ListDeploymentResourcePoolsRequest
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
            return ListDeploymentResourcePoolsAsync(request, callSettings);
        }

        /// <summary>
        /// Update a DeploymentResourcePool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeploymentResourcePool, UpdateDeploymentResourcePoolOperationMetadata> UpdateDeploymentResourcePool(UpdateDeploymentResourcePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a DeploymentResourcePool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeploymentResourcePool, UpdateDeploymentResourcePoolOperationMetadata>> UpdateDeploymentResourcePoolAsync(UpdateDeploymentResourcePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a DeploymentResourcePool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeploymentResourcePool, UpdateDeploymentResourcePoolOperationMetadata>> UpdateDeploymentResourcePoolAsync(UpdateDeploymentResourcePoolRequest request, st::CancellationToken cancellationToken) =>
            UpdateDeploymentResourcePoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateDeploymentResourcePool</c>.</summary>
        public virtual lro::OperationsClient UpdateDeploymentResourcePoolOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateDeploymentResourcePool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DeploymentResourcePool, UpdateDeploymentResourcePoolOperationMetadata> PollOnceUpdateDeploymentResourcePool(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DeploymentResourcePool, UpdateDeploymentResourcePoolOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDeploymentResourcePoolOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateDeploymentResourcePool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DeploymentResourcePool, UpdateDeploymentResourcePoolOperationMetadata>> PollOnceUpdateDeploymentResourcePoolAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DeploymentResourcePool, UpdateDeploymentResourcePoolOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDeploymentResourcePoolOperationsClient, callSettings);

        /// <summary>
        /// Update a DeploymentResourcePool.
        /// </summary>
        /// <param name="deploymentResourcePool">
        /// Required. The DeploymentResourcePool to update.
        /// 
        /// The DeploymentResourcePool's `name` field is used to identify the
        /// DeploymentResourcePool to update.
        /// Format:
        /// `projects/{project}/locations/{location}/deploymentResourcePools/{deployment_resource_pool}`
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeploymentResourcePool, UpdateDeploymentResourcePoolOperationMetadata> UpdateDeploymentResourcePool(DeploymentResourcePool deploymentResourcePool, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDeploymentResourcePool(new UpdateDeploymentResourcePoolRequest
            {
                DeploymentResourcePool = gax::GaxPreconditions.CheckNotNull(deploymentResourcePool, nameof(deploymentResourcePool)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Update a DeploymentResourcePool.
        /// </summary>
        /// <param name="deploymentResourcePool">
        /// Required. The DeploymentResourcePool to update.
        /// 
        /// The DeploymentResourcePool's `name` field is used to identify the
        /// DeploymentResourcePool to update.
        /// Format:
        /// `projects/{project}/locations/{location}/deploymentResourcePools/{deployment_resource_pool}`
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeploymentResourcePool, UpdateDeploymentResourcePoolOperationMetadata>> UpdateDeploymentResourcePoolAsync(DeploymentResourcePool deploymentResourcePool, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDeploymentResourcePoolAsync(new UpdateDeploymentResourcePoolRequest
            {
                DeploymentResourcePool = gax::GaxPreconditions.CheckNotNull(deploymentResourcePool, nameof(deploymentResourcePool)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Update a DeploymentResourcePool.
        /// </summary>
        /// <param name="deploymentResourcePool">
        /// Required. The DeploymentResourcePool to update.
        /// 
        /// The DeploymentResourcePool's `name` field is used to identify the
        /// DeploymentResourcePool to update.
        /// Format:
        /// `projects/{project}/locations/{location}/deploymentResourcePools/{deployment_resource_pool}`
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeploymentResourcePool, UpdateDeploymentResourcePoolOperationMetadata>> UpdateDeploymentResourcePoolAsync(DeploymentResourcePool deploymentResourcePool, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDeploymentResourcePoolAsync(deploymentResourcePool, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a DeploymentResourcePool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteDeploymentResourcePool(DeleteDeploymentResourcePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a DeploymentResourcePool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteDeploymentResourcePoolAsync(DeleteDeploymentResourcePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a DeploymentResourcePool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteDeploymentResourcePoolAsync(DeleteDeploymentResourcePoolRequest request, st::CancellationToken cancellationToken) =>
            DeleteDeploymentResourcePoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteDeploymentResourcePool</c>.</summary>
        public virtual lro::OperationsClient DeleteDeploymentResourcePoolOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteDeploymentResourcePool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> PollOnceDeleteDeploymentResourcePool(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDeploymentResourcePoolOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteDeploymentResourcePool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> PollOnceDeleteDeploymentResourcePoolAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDeploymentResourcePoolOperationsClient, callSettings);

        /// <summary>
        /// Delete a DeploymentResourcePool.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DeploymentResourcePool to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/deploymentResourcePools/{deployment_resource_pool}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteDeploymentResourcePool(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDeploymentResourcePool(new DeleteDeploymentResourcePoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a DeploymentResourcePool.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DeploymentResourcePool to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/deploymentResourcePools/{deployment_resource_pool}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteDeploymentResourcePoolAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDeploymentResourcePoolAsync(new DeleteDeploymentResourcePoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a DeploymentResourcePool.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DeploymentResourcePool to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/deploymentResourcePools/{deployment_resource_pool}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteDeploymentResourcePoolAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDeploymentResourcePoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a DeploymentResourcePool.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DeploymentResourcePool to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/deploymentResourcePools/{deployment_resource_pool}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteDeploymentResourcePool(DeploymentResourcePoolName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDeploymentResourcePool(new DeleteDeploymentResourcePoolRequest
            {
                DeploymentResourcePoolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a DeploymentResourcePool.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DeploymentResourcePool to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/deploymentResourcePools/{deployment_resource_pool}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteDeploymentResourcePoolAsync(DeploymentResourcePoolName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDeploymentResourcePoolAsync(new DeleteDeploymentResourcePoolRequest
            {
                DeploymentResourcePoolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a DeploymentResourcePool.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DeploymentResourcePool to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/deploymentResourcePools/{deployment_resource_pool}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteDeploymentResourcePoolAsync(DeploymentResourcePoolName name, st::CancellationToken cancellationToken) =>
            DeleteDeploymentResourcePoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List DeployedModels that have been deployed on this DeploymentResourcePool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DeployedModel"/> resources.</returns>
        public virtual gax::PagedEnumerable<QueryDeployedModelsResponse, DeployedModel> QueryDeployedModels(QueryDeployedModelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List DeployedModels that have been deployed on this DeploymentResourcePool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DeployedModel"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<QueryDeployedModelsResponse, DeployedModel> QueryDeployedModelsAsync(QueryDeployedModelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List DeployedModels that have been deployed on this DeploymentResourcePool.
        /// </summary>
        /// <param name="deploymentResourcePool">
        /// Required. The name of the target DeploymentResourcePool to query.
        /// Format:
        /// `projects/{project}/locations/{location}/deploymentResourcePools/{deployment_resource_pool}`
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
        /// <returns>A pageable sequence of <see cref="DeployedModel"/> resources.</returns>
        public virtual gax::PagedEnumerable<QueryDeployedModelsResponse, DeployedModel> QueryDeployedModels(string deploymentResourcePool, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            QueryDeployedModelsRequest request = new QueryDeployedModelsRequest
            {
                DeploymentResourcePool = gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentResourcePool, nameof(deploymentResourcePool)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return QueryDeployedModels(request, callSettings);
        }

        /// <summary>
        /// List DeployedModels that have been deployed on this DeploymentResourcePool.
        /// </summary>
        /// <param name="deploymentResourcePool">
        /// Required. The name of the target DeploymentResourcePool to query.
        /// Format:
        /// `projects/{project}/locations/{location}/deploymentResourcePools/{deployment_resource_pool}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="DeployedModel"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<QueryDeployedModelsResponse, DeployedModel> QueryDeployedModelsAsync(string deploymentResourcePool, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            QueryDeployedModelsRequest request = new QueryDeployedModelsRequest
            {
                DeploymentResourcePool = gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentResourcePool, nameof(deploymentResourcePool)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return QueryDeployedModelsAsync(request, callSettings);
        }
    }

    /// <summary>DeploymentResourcePoolService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service that manages the DeploymentResourcePool resource.
    /// </remarks>
    public sealed partial class DeploymentResourcePoolServiceClientImpl : DeploymentResourcePoolServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateDeploymentResourcePoolRequest, lro::Operation> _callCreateDeploymentResourcePool;

        private readonly gaxgrpc::ApiCall<GetDeploymentResourcePoolRequest, DeploymentResourcePool> _callGetDeploymentResourcePool;

        private readonly gaxgrpc::ApiCall<ListDeploymentResourcePoolsRequest, ListDeploymentResourcePoolsResponse> _callListDeploymentResourcePools;

        private readonly gaxgrpc::ApiCall<UpdateDeploymentResourcePoolRequest, lro::Operation> _callUpdateDeploymentResourcePool;

        private readonly gaxgrpc::ApiCall<DeleteDeploymentResourcePoolRequest, lro::Operation> _callDeleteDeploymentResourcePool;

        private readonly gaxgrpc::ApiCall<QueryDeployedModelsRequest, QueryDeployedModelsResponse> _callQueryDeployedModels;

        /// <summary>
        /// Constructs a client wrapper for the DeploymentResourcePoolService service, with the specified gRPC client
        /// and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="DeploymentResourcePoolServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DeploymentResourcePoolServiceClientImpl(DeploymentResourcePoolService.DeploymentResourcePoolServiceClient grpcClient, DeploymentResourcePoolServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DeploymentResourcePoolServiceSettings effectiveSettings = settings ?? DeploymentResourcePoolServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateDeploymentResourcePoolOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateDeploymentResourcePoolOperationsSettings, logger);
            UpdateDeploymentResourcePoolOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateDeploymentResourcePoolOperationsSettings, logger);
            DeleteDeploymentResourcePoolOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteDeploymentResourcePoolOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreateDeploymentResourcePool = clientHelper.BuildApiCall<CreateDeploymentResourcePoolRequest, lro::Operation>("CreateDeploymentResourcePool", grpcClient.CreateDeploymentResourcePoolAsync, grpcClient.CreateDeploymentResourcePool, effectiveSettings.CreateDeploymentResourcePoolSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDeploymentResourcePool);
            Modify_CreateDeploymentResourcePoolApiCall(ref _callCreateDeploymentResourcePool);
            _callGetDeploymentResourcePool = clientHelper.BuildApiCall<GetDeploymentResourcePoolRequest, DeploymentResourcePool>("GetDeploymentResourcePool", grpcClient.GetDeploymentResourcePoolAsync, grpcClient.GetDeploymentResourcePool, effectiveSettings.GetDeploymentResourcePoolSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDeploymentResourcePool);
            Modify_GetDeploymentResourcePoolApiCall(ref _callGetDeploymentResourcePool);
            _callListDeploymentResourcePools = clientHelper.BuildApiCall<ListDeploymentResourcePoolsRequest, ListDeploymentResourcePoolsResponse>("ListDeploymentResourcePools", grpcClient.ListDeploymentResourcePoolsAsync, grpcClient.ListDeploymentResourcePools, effectiveSettings.ListDeploymentResourcePoolsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDeploymentResourcePools);
            Modify_ListDeploymentResourcePoolsApiCall(ref _callListDeploymentResourcePools);
            _callUpdateDeploymentResourcePool = clientHelper.BuildApiCall<UpdateDeploymentResourcePoolRequest, lro::Operation>("UpdateDeploymentResourcePool", grpcClient.UpdateDeploymentResourcePoolAsync, grpcClient.UpdateDeploymentResourcePool, effectiveSettings.UpdateDeploymentResourcePoolSettings).WithGoogleRequestParam("deployment_resource_pool.name", request => request.DeploymentResourcePool?.Name);
            Modify_ApiCall(ref _callUpdateDeploymentResourcePool);
            Modify_UpdateDeploymentResourcePoolApiCall(ref _callUpdateDeploymentResourcePool);
            _callDeleteDeploymentResourcePool = clientHelper.BuildApiCall<DeleteDeploymentResourcePoolRequest, lro::Operation>("DeleteDeploymentResourcePool", grpcClient.DeleteDeploymentResourcePoolAsync, grpcClient.DeleteDeploymentResourcePool, effectiveSettings.DeleteDeploymentResourcePoolSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDeploymentResourcePool);
            Modify_DeleteDeploymentResourcePoolApiCall(ref _callDeleteDeploymentResourcePool);
            _callQueryDeployedModels = clientHelper.BuildApiCall<QueryDeployedModelsRequest, QueryDeployedModelsResponse>("QueryDeployedModels", grpcClient.QueryDeployedModelsAsync, grpcClient.QueryDeployedModels, effectiveSettings.QueryDeployedModelsSettings).WithGoogleRequestParam("deployment_resource_pool", request => request.DeploymentResourcePool);
            Modify_ApiCall(ref _callQueryDeployedModels);
            Modify_QueryDeployedModelsApiCall(ref _callQueryDeployedModels);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateDeploymentResourcePoolApiCall(ref gaxgrpc::ApiCall<CreateDeploymentResourcePoolRequest, lro::Operation> call);

        partial void Modify_GetDeploymentResourcePoolApiCall(ref gaxgrpc::ApiCall<GetDeploymentResourcePoolRequest, DeploymentResourcePool> call);

        partial void Modify_ListDeploymentResourcePoolsApiCall(ref gaxgrpc::ApiCall<ListDeploymentResourcePoolsRequest, ListDeploymentResourcePoolsResponse> call);

        partial void Modify_UpdateDeploymentResourcePoolApiCall(ref gaxgrpc::ApiCall<UpdateDeploymentResourcePoolRequest, lro::Operation> call);

        partial void Modify_DeleteDeploymentResourcePoolApiCall(ref gaxgrpc::ApiCall<DeleteDeploymentResourcePoolRequest, lro::Operation> call);

        partial void Modify_QueryDeployedModelsApiCall(ref gaxgrpc::ApiCall<QueryDeployedModelsRequest, QueryDeployedModelsResponse> call);

        partial void OnConstruction(DeploymentResourcePoolService.DeploymentResourcePoolServiceClient grpcClient, DeploymentResourcePoolServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DeploymentResourcePoolService client</summary>
        public override DeploymentResourcePoolService.DeploymentResourcePoolServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateDeploymentResourcePoolRequest(ref CreateDeploymentResourcePoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDeploymentResourcePoolRequest(ref GetDeploymentResourcePoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDeploymentResourcePoolsRequest(ref ListDeploymentResourcePoolsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDeploymentResourcePoolRequest(ref UpdateDeploymentResourcePoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDeploymentResourcePoolRequest(ref DeleteDeploymentResourcePoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_QueryDeployedModelsRequest(ref QueryDeployedModelsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateDeploymentResourcePool</c>.</summary>
        public override lro::OperationsClient CreateDeploymentResourcePoolOperationsClient { get; }

        /// <summary>
        /// Create a DeploymentResourcePool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DeploymentResourcePool, CreateDeploymentResourcePoolOperationMetadata> CreateDeploymentResourcePool(CreateDeploymentResourcePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDeploymentResourcePoolRequest(ref request, ref callSettings);
            return new lro::Operation<DeploymentResourcePool, CreateDeploymentResourcePoolOperationMetadata>(_callCreateDeploymentResourcePool.Sync(request, callSettings), CreateDeploymentResourcePoolOperationsClient);
        }

        /// <summary>
        /// Create a DeploymentResourcePool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DeploymentResourcePool, CreateDeploymentResourcePoolOperationMetadata>> CreateDeploymentResourcePoolAsync(CreateDeploymentResourcePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDeploymentResourcePoolRequest(ref request, ref callSettings);
            return new lro::Operation<DeploymentResourcePool, CreateDeploymentResourcePoolOperationMetadata>(await _callCreateDeploymentResourcePool.Async(request, callSettings).ConfigureAwait(false), CreateDeploymentResourcePoolOperationsClient);
        }

        /// <summary>
        /// Get a DeploymentResourcePool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DeploymentResourcePool GetDeploymentResourcePool(GetDeploymentResourcePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDeploymentResourcePoolRequest(ref request, ref callSettings);
            return _callGetDeploymentResourcePool.Sync(request, callSettings);
        }

        /// <summary>
        /// Get a DeploymentResourcePool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DeploymentResourcePool> GetDeploymentResourcePoolAsync(GetDeploymentResourcePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDeploymentResourcePoolRequest(ref request, ref callSettings);
            return _callGetDeploymentResourcePool.Async(request, callSettings);
        }

        /// <summary>
        /// List DeploymentResourcePools in a location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DeploymentResourcePool"/> resources.</returns>
        public override gax::PagedEnumerable<ListDeploymentResourcePoolsResponse, DeploymentResourcePool> ListDeploymentResourcePools(ListDeploymentResourcePoolsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDeploymentResourcePoolsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDeploymentResourcePoolsRequest, ListDeploymentResourcePoolsResponse, DeploymentResourcePool>(_callListDeploymentResourcePools, request, callSettings);
        }

        /// <summary>
        /// List DeploymentResourcePools in a location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DeploymentResourcePool"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDeploymentResourcePoolsResponse, DeploymentResourcePool> ListDeploymentResourcePoolsAsync(ListDeploymentResourcePoolsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDeploymentResourcePoolsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDeploymentResourcePoolsRequest, ListDeploymentResourcePoolsResponse, DeploymentResourcePool>(_callListDeploymentResourcePools, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateDeploymentResourcePool</c>.</summary>
        public override lro::OperationsClient UpdateDeploymentResourcePoolOperationsClient { get; }

        /// <summary>
        /// Update a DeploymentResourcePool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DeploymentResourcePool, UpdateDeploymentResourcePoolOperationMetadata> UpdateDeploymentResourcePool(UpdateDeploymentResourcePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDeploymentResourcePoolRequest(ref request, ref callSettings);
            return new lro::Operation<DeploymentResourcePool, UpdateDeploymentResourcePoolOperationMetadata>(_callUpdateDeploymentResourcePool.Sync(request, callSettings), UpdateDeploymentResourcePoolOperationsClient);
        }

        /// <summary>
        /// Update a DeploymentResourcePool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DeploymentResourcePool, UpdateDeploymentResourcePoolOperationMetadata>> UpdateDeploymentResourcePoolAsync(UpdateDeploymentResourcePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDeploymentResourcePoolRequest(ref request, ref callSettings);
            return new lro::Operation<DeploymentResourcePool, UpdateDeploymentResourcePoolOperationMetadata>(await _callUpdateDeploymentResourcePool.Async(request, callSettings).ConfigureAwait(false), UpdateDeploymentResourcePoolOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteDeploymentResourcePool</c>.</summary>
        public override lro::OperationsClient DeleteDeploymentResourcePoolOperationsClient { get; }

        /// <summary>
        /// Delete a DeploymentResourcePool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteDeploymentResourcePool(DeleteDeploymentResourcePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDeploymentResourcePoolRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(_callDeleteDeploymentResourcePool.Sync(request, callSettings), DeleteDeploymentResourcePoolOperationsClient);
        }

        /// <summary>
        /// Delete a DeploymentResourcePool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteDeploymentResourcePoolAsync(DeleteDeploymentResourcePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDeploymentResourcePoolRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(await _callDeleteDeploymentResourcePool.Async(request, callSettings).ConfigureAwait(false), DeleteDeploymentResourcePoolOperationsClient);
        }

        /// <summary>
        /// List DeployedModels that have been deployed on this DeploymentResourcePool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DeployedModel"/> resources.</returns>
        public override gax::PagedEnumerable<QueryDeployedModelsResponse, DeployedModel> QueryDeployedModels(QueryDeployedModelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryDeployedModelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<QueryDeployedModelsRequest, QueryDeployedModelsResponse, DeployedModel>(_callQueryDeployedModels, request, callSettings);
        }

        /// <summary>
        /// List DeployedModels that have been deployed on this DeploymentResourcePool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DeployedModel"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<QueryDeployedModelsResponse, DeployedModel> QueryDeployedModelsAsync(QueryDeployedModelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryDeployedModelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<QueryDeployedModelsRequest, QueryDeployedModelsResponse, DeployedModel>(_callQueryDeployedModels, request, callSettings);
        }
    }

    public partial class ListDeploymentResourcePoolsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class QueryDeployedModelsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDeploymentResourcePoolsResponse : gaxgrpc::IPageResponse<DeploymentResourcePool>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DeploymentResourcePool> GetEnumerator() => DeploymentResourcePools.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class QueryDeployedModelsResponse : gaxgrpc::IPageResponse<DeployedModel>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DeployedModel> GetEnumerator() => DeployedModels.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class DeploymentResourcePoolService
    {
        public partial class DeploymentResourcePoolServiceClient
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

    public static partial class DeploymentResourcePoolService
    {
        public partial class DeploymentResourcePoolServiceClient
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
