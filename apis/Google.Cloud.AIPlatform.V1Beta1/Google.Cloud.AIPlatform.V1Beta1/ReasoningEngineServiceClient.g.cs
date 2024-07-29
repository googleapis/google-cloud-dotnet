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
    /// <summary>Settings for <see cref="ReasoningEngineServiceClient"/> instances.</summary>
    public sealed partial class ReasoningEngineServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ReasoningEngineServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ReasoningEngineServiceSettings"/>.</returns>
        public static ReasoningEngineServiceSettings GetDefault() => new ReasoningEngineServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ReasoningEngineServiceSettings"/> object with default settings.
        /// </summary>
        public ReasoningEngineServiceSettings()
        {
        }

        private ReasoningEngineServiceSettings(ReasoningEngineServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateReasoningEngineSettings = existing.CreateReasoningEngineSettings;
            CreateReasoningEngineOperationsSettings = existing.CreateReasoningEngineOperationsSettings.Clone();
            GetReasoningEngineSettings = existing.GetReasoningEngineSettings;
            ListReasoningEnginesSettings = existing.ListReasoningEnginesSettings;
            UpdateReasoningEngineSettings = existing.UpdateReasoningEngineSettings;
            UpdateReasoningEngineOperationsSettings = existing.UpdateReasoningEngineOperationsSettings.Clone();
            DeleteReasoningEngineSettings = existing.DeleteReasoningEngineSettings;
            DeleteReasoningEngineOperationsSettings = existing.DeleteReasoningEngineOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(ReasoningEngineServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReasoningEngineServiceClient.CreateReasoningEngine</c> and
        /// <c>ReasoningEngineServiceClient.CreateReasoningEngineAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateReasoningEngineSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ReasoningEngineServiceClient.CreateReasoningEngine</c> and
        /// <c>ReasoningEngineServiceClient.CreateReasoningEngineAsync</c>.
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
        public lro::OperationsSettings CreateReasoningEngineOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReasoningEngineServiceClient.GetReasoningEngine</c> and
        /// <c>ReasoningEngineServiceClient.GetReasoningEngineAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetReasoningEngineSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReasoningEngineServiceClient.ListReasoningEngines</c> and
        /// <c>ReasoningEngineServiceClient.ListReasoningEnginesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListReasoningEnginesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReasoningEngineServiceClient.UpdateReasoningEngine</c> and
        /// <c>ReasoningEngineServiceClient.UpdateReasoningEngineAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateReasoningEngineSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ReasoningEngineServiceClient.UpdateReasoningEngine</c> and
        /// <c>ReasoningEngineServiceClient.UpdateReasoningEngineAsync</c>.
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
        public lro::OperationsSettings UpdateReasoningEngineOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReasoningEngineServiceClient.DeleteReasoningEngine</c> and
        /// <c>ReasoningEngineServiceClient.DeleteReasoningEngineAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteReasoningEngineSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ReasoningEngineServiceClient.DeleteReasoningEngine</c> and
        /// <c>ReasoningEngineServiceClient.DeleteReasoningEngineAsync</c>.
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
        public lro::OperationsSettings DeleteReasoningEngineOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ReasoningEngineServiceSettings"/> object.</returns>
        public ReasoningEngineServiceSettings Clone() => new ReasoningEngineServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ReasoningEngineServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class ReasoningEngineServiceClientBuilder : gaxgrpc::ClientBuilderBase<ReasoningEngineServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ReasoningEngineServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ReasoningEngineServiceClientBuilder() : base(ReasoningEngineServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ReasoningEngineServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ReasoningEngineServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ReasoningEngineServiceClient Build()
        {
            ReasoningEngineServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ReasoningEngineServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ReasoningEngineServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ReasoningEngineServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ReasoningEngineServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ReasoningEngineServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ReasoningEngineServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ReasoningEngineServiceClient.ChannelPool;
    }

    /// <summary>ReasoningEngineService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service for managing Vertex AI's Reasoning Engines.
    /// </remarks>
    public abstract partial class ReasoningEngineServiceClient
    {
        /// <summary>
        /// The default endpoint for the ReasoningEngineService service, which is a host of "aiplatform.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "aiplatform.googleapis.com:443";

        /// <summary>The default ReasoningEngineService scopes.</summary>
        /// <remarks>
        /// The default ReasoningEngineService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ReasoningEngineService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ReasoningEngineServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ReasoningEngineServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ReasoningEngineServiceClient"/>.</returns>
        public static stt::Task<ReasoningEngineServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ReasoningEngineServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ReasoningEngineServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ReasoningEngineServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ReasoningEngineServiceClient"/>.</returns>
        public static ReasoningEngineServiceClient Create() => new ReasoningEngineServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ReasoningEngineServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ReasoningEngineServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ReasoningEngineServiceClient"/>.</returns>
        internal static ReasoningEngineServiceClient Create(grpccore::CallInvoker callInvoker, ReasoningEngineServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ReasoningEngineService.ReasoningEngineServiceClient grpcClient = new ReasoningEngineService.ReasoningEngineServiceClient(callInvoker);
            return new ReasoningEngineServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ReasoningEngineService client</summary>
        public virtual ReasoningEngineService.ReasoningEngineServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a reasoning engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ReasoningEngine, CreateReasoningEngineOperationMetadata> CreateReasoningEngine(CreateReasoningEngineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a reasoning engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ReasoningEngine, CreateReasoningEngineOperationMetadata>> CreateReasoningEngineAsync(CreateReasoningEngineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a reasoning engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ReasoningEngine, CreateReasoningEngineOperationMetadata>> CreateReasoningEngineAsync(CreateReasoningEngineRequest request, st::CancellationToken cancellationToken) =>
            CreateReasoningEngineAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateReasoningEngine</c>.</summary>
        public virtual lro::OperationsClient CreateReasoningEngineOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateReasoningEngine</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ReasoningEngine, CreateReasoningEngineOperationMetadata> PollOnceCreateReasoningEngine(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ReasoningEngine, CreateReasoningEngineOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateReasoningEngineOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateReasoningEngine</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ReasoningEngine, CreateReasoningEngineOperationMetadata>> PollOnceCreateReasoningEngineAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ReasoningEngine, CreateReasoningEngineOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateReasoningEngineOperationsClient, callSettings);

        /// <summary>
        /// Creates a reasoning engine.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the ReasoningEngine
        /// in. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="reasoningEngine">
        /// Required. The ReasoningEngine to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ReasoningEngine, CreateReasoningEngineOperationMetadata> CreateReasoningEngine(string parent, ReasoningEngine reasoningEngine, gaxgrpc::CallSettings callSettings = null) =>
            CreateReasoningEngine(new CreateReasoningEngineRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ReasoningEngine = gax::GaxPreconditions.CheckNotNull(reasoningEngine, nameof(reasoningEngine)),
            }, callSettings);

        /// <summary>
        /// Creates a reasoning engine.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the ReasoningEngine
        /// in. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="reasoningEngine">
        /// Required. The ReasoningEngine to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ReasoningEngine, CreateReasoningEngineOperationMetadata>> CreateReasoningEngineAsync(string parent, ReasoningEngine reasoningEngine, gaxgrpc::CallSettings callSettings = null) =>
            CreateReasoningEngineAsync(new CreateReasoningEngineRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ReasoningEngine = gax::GaxPreconditions.CheckNotNull(reasoningEngine, nameof(reasoningEngine)),
            }, callSettings);

        /// <summary>
        /// Creates a reasoning engine.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the ReasoningEngine
        /// in. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="reasoningEngine">
        /// Required. The ReasoningEngine to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ReasoningEngine, CreateReasoningEngineOperationMetadata>> CreateReasoningEngineAsync(string parent, ReasoningEngine reasoningEngine, st::CancellationToken cancellationToken) =>
            CreateReasoningEngineAsync(parent, reasoningEngine, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a reasoning engine.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the ReasoningEngine
        /// in. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="reasoningEngine">
        /// Required. The ReasoningEngine to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ReasoningEngine, CreateReasoningEngineOperationMetadata> CreateReasoningEngine(gagr::LocationName parent, ReasoningEngine reasoningEngine, gaxgrpc::CallSettings callSettings = null) =>
            CreateReasoningEngine(new CreateReasoningEngineRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ReasoningEngine = gax::GaxPreconditions.CheckNotNull(reasoningEngine, nameof(reasoningEngine)),
            }, callSettings);

        /// <summary>
        /// Creates a reasoning engine.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the ReasoningEngine
        /// in. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="reasoningEngine">
        /// Required. The ReasoningEngine to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ReasoningEngine, CreateReasoningEngineOperationMetadata>> CreateReasoningEngineAsync(gagr::LocationName parent, ReasoningEngine reasoningEngine, gaxgrpc::CallSettings callSettings = null) =>
            CreateReasoningEngineAsync(new CreateReasoningEngineRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ReasoningEngine = gax::GaxPreconditions.CheckNotNull(reasoningEngine, nameof(reasoningEngine)),
            }, callSettings);

        /// <summary>
        /// Creates a reasoning engine.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the ReasoningEngine
        /// in. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="reasoningEngine">
        /// Required. The ReasoningEngine to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ReasoningEngine, CreateReasoningEngineOperationMetadata>> CreateReasoningEngineAsync(gagr::LocationName parent, ReasoningEngine reasoningEngine, st::CancellationToken cancellationToken) =>
            CreateReasoningEngineAsync(parent, reasoningEngine, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a reasoning engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReasoningEngine GetReasoningEngine(GetReasoningEngineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a reasoning engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReasoningEngine> GetReasoningEngineAsync(GetReasoningEngineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a reasoning engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReasoningEngine> GetReasoningEngineAsync(GetReasoningEngineRequest request, st::CancellationToken cancellationToken) =>
            GetReasoningEngineAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a reasoning engine.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ReasoningEngine resource.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReasoningEngine GetReasoningEngine(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetReasoningEngine(new GetReasoningEngineRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a reasoning engine.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ReasoningEngine resource.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReasoningEngine> GetReasoningEngineAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetReasoningEngineAsync(new GetReasoningEngineRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a reasoning engine.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ReasoningEngine resource.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReasoningEngine> GetReasoningEngineAsync(string name, st::CancellationToken cancellationToken) =>
            GetReasoningEngineAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a reasoning engine.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ReasoningEngine resource.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReasoningEngine GetReasoningEngine(ReasoningEngineName name, gaxgrpc::CallSettings callSettings = null) =>
            GetReasoningEngine(new GetReasoningEngineRequest
            {
                ReasoningEngineName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a reasoning engine.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ReasoningEngine resource.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReasoningEngine> GetReasoningEngineAsync(ReasoningEngineName name, gaxgrpc::CallSettings callSettings = null) =>
            GetReasoningEngineAsync(new GetReasoningEngineRequest
            {
                ReasoningEngineName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a reasoning engine.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ReasoningEngine resource.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReasoningEngine> GetReasoningEngineAsync(ReasoningEngineName name, st::CancellationToken cancellationToken) =>
            GetReasoningEngineAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists reasoning engines in a location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ReasoningEngine"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReasoningEnginesResponse, ReasoningEngine> ListReasoningEngines(ListReasoningEnginesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists reasoning engines in a location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ReasoningEngine"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReasoningEnginesResponse, ReasoningEngine> ListReasoningEnginesAsync(ListReasoningEnginesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists reasoning engines in a location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the ReasoningEngines
        /// from. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="ReasoningEngine"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReasoningEnginesResponse, ReasoningEngine> ListReasoningEngines(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReasoningEnginesRequest request = new ListReasoningEnginesRequest
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
            return ListReasoningEngines(request, callSettings);
        }

        /// <summary>
        /// Lists reasoning engines in a location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the ReasoningEngines
        /// from. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ReasoningEngine"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReasoningEnginesResponse, ReasoningEngine> ListReasoningEnginesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReasoningEnginesRequest request = new ListReasoningEnginesRequest
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
            return ListReasoningEnginesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists reasoning engines in a location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the ReasoningEngines
        /// from. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="ReasoningEngine"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReasoningEnginesResponse, ReasoningEngine> ListReasoningEngines(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReasoningEnginesRequest request = new ListReasoningEnginesRequest
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
            return ListReasoningEngines(request, callSettings);
        }

        /// <summary>
        /// Lists reasoning engines in a location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the ReasoningEngines
        /// from. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ReasoningEngine"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReasoningEnginesResponse, ReasoningEngine> ListReasoningEnginesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReasoningEnginesRequest request = new ListReasoningEnginesRequest
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
            return ListReasoningEnginesAsync(request, callSettings);
        }

        /// <summary>
        /// Updates a reasoning engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ReasoningEngine, UpdateReasoningEngineOperationMetadata> UpdateReasoningEngine(UpdateReasoningEngineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a reasoning engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ReasoningEngine, UpdateReasoningEngineOperationMetadata>> UpdateReasoningEngineAsync(UpdateReasoningEngineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a reasoning engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ReasoningEngine, UpdateReasoningEngineOperationMetadata>> UpdateReasoningEngineAsync(UpdateReasoningEngineRequest request, st::CancellationToken cancellationToken) =>
            UpdateReasoningEngineAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateReasoningEngine</c>.</summary>
        public virtual lro::OperationsClient UpdateReasoningEngineOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateReasoningEngine</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ReasoningEngine, UpdateReasoningEngineOperationMetadata> PollOnceUpdateReasoningEngine(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ReasoningEngine, UpdateReasoningEngineOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateReasoningEngineOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateReasoningEngine</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ReasoningEngine, UpdateReasoningEngineOperationMetadata>> PollOnceUpdateReasoningEngineAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ReasoningEngine, UpdateReasoningEngineOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateReasoningEngineOperationsClient, callSettings);

        /// <summary>
        /// Updates a reasoning engine.
        /// </summary>
        /// <param name="reasoningEngine">
        /// Required. The ReasoningEngine which replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask specifying which fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ReasoningEngine, UpdateReasoningEngineOperationMetadata> UpdateReasoningEngine(ReasoningEngine reasoningEngine, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateReasoningEngine(new UpdateReasoningEngineRequest
            {
                ReasoningEngine = gax::GaxPreconditions.CheckNotNull(reasoningEngine, nameof(reasoningEngine)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a reasoning engine.
        /// </summary>
        /// <param name="reasoningEngine">
        /// Required. The ReasoningEngine which replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask specifying which fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ReasoningEngine, UpdateReasoningEngineOperationMetadata>> UpdateReasoningEngineAsync(ReasoningEngine reasoningEngine, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateReasoningEngineAsync(new UpdateReasoningEngineRequest
            {
                ReasoningEngine = gax::GaxPreconditions.CheckNotNull(reasoningEngine, nameof(reasoningEngine)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a reasoning engine.
        /// </summary>
        /// <param name="reasoningEngine">
        /// Required. The ReasoningEngine which replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask specifying which fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ReasoningEngine, UpdateReasoningEngineOperationMetadata>> UpdateReasoningEngineAsync(ReasoningEngine reasoningEngine, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateReasoningEngineAsync(reasoningEngine, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a reasoning engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteReasoningEngine(DeleteReasoningEngineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a reasoning engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteReasoningEngineAsync(DeleteReasoningEngineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a reasoning engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteReasoningEngineAsync(DeleteReasoningEngineRequest request, st::CancellationToken cancellationToken) =>
            DeleteReasoningEngineAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteReasoningEngine</c>.</summary>
        public virtual lro::OperationsClient DeleteReasoningEngineOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteReasoningEngine</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> PollOnceDeleteReasoningEngine(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteReasoningEngineOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteReasoningEngine</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> PollOnceDeleteReasoningEngineAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteReasoningEngineOperationsClient, callSettings);

        /// <summary>
        /// Deletes a reasoning engine.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ReasoningEngine resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteReasoningEngine(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReasoningEngine(new DeleteReasoningEngineRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a reasoning engine.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ReasoningEngine resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteReasoningEngineAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReasoningEngineAsync(new DeleteReasoningEngineRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a reasoning engine.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ReasoningEngine resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteReasoningEngineAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteReasoningEngineAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a reasoning engine.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ReasoningEngine resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteReasoningEngine(ReasoningEngineName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReasoningEngine(new DeleteReasoningEngineRequest
            {
                ReasoningEngineName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a reasoning engine.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ReasoningEngine resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteReasoningEngineAsync(ReasoningEngineName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReasoningEngineAsync(new DeleteReasoningEngineRequest
            {
                ReasoningEngineName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a reasoning engine.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ReasoningEngine resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteReasoningEngineAsync(ReasoningEngineName name, st::CancellationToken cancellationToken) =>
            DeleteReasoningEngineAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ReasoningEngineService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service for managing Vertex AI's Reasoning Engines.
    /// </remarks>
    public sealed partial class ReasoningEngineServiceClientImpl : ReasoningEngineServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateReasoningEngineRequest, lro::Operation> _callCreateReasoningEngine;

        private readonly gaxgrpc::ApiCall<GetReasoningEngineRequest, ReasoningEngine> _callGetReasoningEngine;

        private readonly gaxgrpc::ApiCall<ListReasoningEnginesRequest, ListReasoningEnginesResponse> _callListReasoningEngines;

        private readonly gaxgrpc::ApiCall<UpdateReasoningEngineRequest, lro::Operation> _callUpdateReasoningEngine;

        private readonly gaxgrpc::ApiCall<DeleteReasoningEngineRequest, lro::Operation> _callDeleteReasoningEngine;

        /// <summary>
        /// Constructs a client wrapper for the ReasoningEngineService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="ReasoningEngineServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ReasoningEngineServiceClientImpl(ReasoningEngineService.ReasoningEngineServiceClient grpcClient, ReasoningEngineServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ReasoningEngineServiceSettings effectiveSettings = settings ?? ReasoningEngineServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateReasoningEngineOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateReasoningEngineOperationsSettings, logger);
            UpdateReasoningEngineOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateReasoningEngineOperationsSettings, logger);
            DeleteReasoningEngineOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteReasoningEngineOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreateReasoningEngine = clientHelper.BuildApiCall<CreateReasoningEngineRequest, lro::Operation>("CreateReasoningEngine", grpcClient.CreateReasoningEngineAsync, grpcClient.CreateReasoningEngine, effectiveSettings.CreateReasoningEngineSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateReasoningEngine);
            Modify_CreateReasoningEngineApiCall(ref _callCreateReasoningEngine);
            _callGetReasoningEngine = clientHelper.BuildApiCall<GetReasoningEngineRequest, ReasoningEngine>("GetReasoningEngine", grpcClient.GetReasoningEngineAsync, grpcClient.GetReasoningEngine, effectiveSettings.GetReasoningEngineSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetReasoningEngine);
            Modify_GetReasoningEngineApiCall(ref _callGetReasoningEngine);
            _callListReasoningEngines = clientHelper.BuildApiCall<ListReasoningEnginesRequest, ListReasoningEnginesResponse>("ListReasoningEngines", grpcClient.ListReasoningEnginesAsync, grpcClient.ListReasoningEngines, effectiveSettings.ListReasoningEnginesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListReasoningEngines);
            Modify_ListReasoningEnginesApiCall(ref _callListReasoningEngines);
            _callUpdateReasoningEngine = clientHelper.BuildApiCall<UpdateReasoningEngineRequest, lro::Operation>("UpdateReasoningEngine", grpcClient.UpdateReasoningEngineAsync, grpcClient.UpdateReasoningEngine, effectiveSettings.UpdateReasoningEngineSettings).WithGoogleRequestParam("reasoning_engine.name", request => request.ReasoningEngine?.Name);
            Modify_ApiCall(ref _callUpdateReasoningEngine);
            Modify_UpdateReasoningEngineApiCall(ref _callUpdateReasoningEngine);
            _callDeleteReasoningEngine = clientHelper.BuildApiCall<DeleteReasoningEngineRequest, lro::Operation>("DeleteReasoningEngine", grpcClient.DeleteReasoningEngineAsync, grpcClient.DeleteReasoningEngine, effectiveSettings.DeleteReasoningEngineSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteReasoningEngine);
            Modify_DeleteReasoningEngineApiCall(ref _callDeleteReasoningEngine);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateReasoningEngineApiCall(ref gaxgrpc::ApiCall<CreateReasoningEngineRequest, lro::Operation> call);

        partial void Modify_GetReasoningEngineApiCall(ref gaxgrpc::ApiCall<GetReasoningEngineRequest, ReasoningEngine> call);

        partial void Modify_ListReasoningEnginesApiCall(ref gaxgrpc::ApiCall<ListReasoningEnginesRequest, ListReasoningEnginesResponse> call);

        partial void Modify_UpdateReasoningEngineApiCall(ref gaxgrpc::ApiCall<UpdateReasoningEngineRequest, lro::Operation> call);

        partial void Modify_DeleteReasoningEngineApiCall(ref gaxgrpc::ApiCall<DeleteReasoningEngineRequest, lro::Operation> call);

        partial void OnConstruction(ReasoningEngineService.ReasoningEngineServiceClient grpcClient, ReasoningEngineServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ReasoningEngineService client</summary>
        public override ReasoningEngineService.ReasoningEngineServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateReasoningEngineRequest(ref CreateReasoningEngineRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetReasoningEngineRequest(ref GetReasoningEngineRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListReasoningEnginesRequest(ref ListReasoningEnginesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateReasoningEngineRequest(ref UpdateReasoningEngineRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteReasoningEngineRequest(ref DeleteReasoningEngineRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateReasoningEngine</c>.</summary>
        public override lro::OperationsClient CreateReasoningEngineOperationsClient { get; }

        /// <summary>
        /// Creates a reasoning engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ReasoningEngine, CreateReasoningEngineOperationMetadata> CreateReasoningEngine(CreateReasoningEngineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateReasoningEngineRequest(ref request, ref callSettings);
            return new lro::Operation<ReasoningEngine, CreateReasoningEngineOperationMetadata>(_callCreateReasoningEngine.Sync(request, callSettings), CreateReasoningEngineOperationsClient);
        }

        /// <summary>
        /// Creates a reasoning engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ReasoningEngine, CreateReasoningEngineOperationMetadata>> CreateReasoningEngineAsync(CreateReasoningEngineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateReasoningEngineRequest(ref request, ref callSettings);
            return new lro::Operation<ReasoningEngine, CreateReasoningEngineOperationMetadata>(await _callCreateReasoningEngine.Async(request, callSettings).ConfigureAwait(false), CreateReasoningEngineOperationsClient);
        }

        /// <summary>
        /// Gets a reasoning engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReasoningEngine GetReasoningEngine(GetReasoningEngineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReasoningEngineRequest(ref request, ref callSettings);
            return _callGetReasoningEngine.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a reasoning engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReasoningEngine> GetReasoningEngineAsync(GetReasoningEngineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReasoningEngineRequest(ref request, ref callSettings);
            return _callGetReasoningEngine.Async(request, callSettings);
        }

        /// <summary>
        /// Lists reasoning engines in a location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ReasoningEngine"/> resources.</returns>
        public override gax::PagedEnumerable<ListReasoningEnginesResponse, ReasoningEngine> ListReasoningEngines(ListReasoningEnginesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReasoningEnginesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListReasoningEnginesRequest, ListReasoningEnginesResponse, ReasoningEngine>(_callListReasoningEngines, request, callSettings);
        }

        /// <summary>
        /// Lists reasoning engines in a location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ReasoningEngine"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListReasoningEnginesResponse, ReasoningEngine> ListReasoningEnginesAsync(ListReasoningEnginesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReasoningEnginesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListReasoningEnginesRequest, ListReasoningEnginesResponse, ReasoningEngine>(_callListReasoningEngines, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateReasoningEngine</c>.</summary>
        public override lro::OperationsClient UpdateReasoningEngineOperationsClient { get; }

        /// <summary>
        /// Updates a reasoning engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ReasoningEngine, UpdateReasoningEngineOperationMetadata> UpdateReasoningEngine(UpdateReasoningEngineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateReasoningEngineRequest(ref request, ref callSettings);
            return new lro::Operation<ReasoningEngine, UpdateReasoningEngineOperationMetadata>(_callUpdateReasoningEngine.Sync(request, callSettings), UpdateReasoningEngineOperationsClient);
        }

        /// <summary>
        /// Updates a reasoning engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ReasoningEngine, UpdateReasoningEngineOperationMetadata>> UpdateReasoningEngineAsync(UpdateReasoningEngineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateReasoningEngineRequest(ref request, ref callSettings);
            return new lro::Operation<ReasoningEngine, UpdateReasoningEngineOperationMetadata>(await _callUpdateReasoningEngine.Async(request, callSettings).ConfigureAwait(false), UpdateReasoningEngineOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteReasoningEngine</c>.</summary>
        public override lro::OperationsClient DeleteReasoningEngineOperationsClient { get; }

        /// <summary>
        /// Deletes a reasoning engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteReasoningEngine(DeleteReasoningEngineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteReasoningEngineRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(_callDeleteReasoningEngine.Sync(request, callSettings), DeleteReasoningEngineOperationsClient);
        }

        /// <summary>
        /// Deletes a reasoning engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteReasoningEngineAsync(DeleteReasoningEngineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteReasoningEngineRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(await _callDeleteReasoningEngine.Async(request, callSettings).ConfigureAwait(false), DeleteReasoningEngineOperationsClient);
        }
    }

    public partial class ListReasoningEnginesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListReasoningEnginesResponse : gaxgrpc::IPageResponse<ReasoningEngine>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ReasoningEngine> GetEnumerator() => ReasoningEngines.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ReasoningEngineService
    {
        public partial class ReasoningEngineServiceClient
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

    public static partial class ReasoningEngineService
    {
        public partial class ReasoningEngineServiceClient
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
