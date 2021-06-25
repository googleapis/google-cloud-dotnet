// Copyright 2021 Google LLC
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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using gagr = Google.Api.Gax.ResourceNames;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.AIPlatform.V1
{
    /// <summary>Settings for <see cref="PipelineServiceClient"/> instances.</summary>
    public sealed partial class PipelineServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="PipelineServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="PipelineServiceSettings"/>.</returns>
        public static PipelineServiceSettings GetDefault() => new PipelineServiceSettings();

        /// <summary>Constructs a new <see cref="PipelineServiceSettings"/> object with default settings.</summary>
        public PipelineServiceSettings()
        {
        }

        private PipelineServiceSettings(PipelineServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateTrainingPipelineSettings = existing.CreateTrainingPipelineSettings;
            GetTrainingPipelineSettings = existing.GetTrainingPipelineSettings;
            ListTrainingPipelinesSettings = existing.ListTrainingPipelinesSettings;
            DeleteTrainingPipelineSettings = existing.DeleteTrainingPipelineSettings;
            DeleteTrainingPipelineOperationsSettings = existing.DeleteTrainingPipelineOperationsSettings.Clone();
            CancelTrainingPipelineSettings = existing.CancelTrainingPipelineSettings;
            OnCopy(existing);
        }

        partial void OnCopy(PipelineServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PipelineServiceClient.CreateTrainingPipeline</c> and <c>PipelineServiceClient.CreateTrainingPipelineAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTrainingPipelineSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PipelineServiceClient.GetTrainingPipeline</c> and <c>PipelineServiceClient.GetTrainingPipelineAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTrainingPipelineSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PipelineServiceClient.ListTrainingPipelines</c> and <c>PipelineServiceClient.ListTrainingPipelinesAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTrainingPipelinesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PipelineServiceClient.DeleteTrainingPipeline</c> and <c>PipelineServiceClient.DeleteTrainingPipelineAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTrainingPipelineSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>PipelineServiceClient.DeleteTrainingPipeline</c> and
        /// <c>PipelineServiceClient.DeleteTrainingPipelineAsync</c>.
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
        public lro::OperationsSettings DeleteTrainingPipelineOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PipelineServiceClient.CancelTrainingPipeline</c> and <c>PipelineServiceClient.CancelTrainingPipelineAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CancelTrainingPipelineSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="PipelineServiceSettings"/> object.</returns>
        public PipelineServiceSettings Clone() => new PipelineServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PipelineServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class PipelineServiceClientBuilder : gaxgrpc::ClientBuilderBase<PipelineServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public PipelineServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref PipelineServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<PipelineServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override PipelineServiceClient Build()
        {
            PipelineServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<PipelineServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<PipelineServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private PipelineServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PipelineServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<PipelineServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PipelineServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => PipelineServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => PipelineServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => PipelineServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>PipelineService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service for creating and managing Vertex AI's pipelines. This includes both
    /// `TrainingPipeline` resources (used for AutoML and custom training) and
    /// `PipelineJob` resources (used for Vertex Pipelines).
    /// </remarks>
    public abstract partial class PipelineServiceClient
    {
        /// <summary>
        /// The default endpoint for the PipelineService service, which is a host of "aiplatform.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "aiplatform.googleapis.com:443";

        /// <summary>The default PipelineService scopes.</summary>
        /// <remarks>
        /// The default PipelineService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="PipelineServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="PipelineServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="PipelineServiceClient"/>.</returns>
        public static stt::Task<PipelineServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new PipelineServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="PipelineServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="PipelineServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="PipelineServiceClient"/>.</returns>
        public static PipelineServiceClient Create() => new PipelineServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="PipelineServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="PipelineServiceSettings"/>.</param>
        /// <returns>The created <see cref="PipelineServiceClient"/>.</returns>
        internal static PipelineServiceClient Create(grpccore::CallInvoker callInvoker, PipelineServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            PipelineService.PipelineServiceClient grpcClient = new PipelineService.PipelineServiceClient(callInvoker);
            return new PipelineServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC PipelineService client</summary>
        public virtual PipelineService.PipelineServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a TrainingPipeline. A created TrainingPipeline right away will be
        /// attempted to be run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TrainingPipeline CreateTrainingPipeline(CreateTrainingPipelineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a TrainingPipeline. A created TrainingPipeline right away will be
        /// attempted to be run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TrainingPipeline> CreateTrainingPipelineAsync(CreateTrainingPipelineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a TrainingPipeline. A created TrainingPipeline right away will be
        /// attempted to be run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TrainingPipeline> CreateTrainingPipelineAsync(CreateTrainingPipelineRequest request, st::CancellationToken cancellationToken) =>
            CreateTrainingPipelineAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a TrainingPipeline. A created TrainingPipeline right away will be
        /// attempted to be run.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the TrainingPipeline in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="trainingPipeline">
        /// Required. The TrainingPipeline to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TrainingPipeline CreateTrainingPipeline(string parent, TrainingPipeline trainingPipeline, gaxgrpc::CallSettings callSettings = null) =>
            CreateTrainingPipeline(new CreateTrainingPipelineRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TrainingPipeline = gax::GaxPreconditions.CheckNotNull(trainingPipeline, nameof(trainingPipeline)),
            }, callSettings);

        /// <summary>
        /// Creates a TrainingPipeline. A created TrainingPipeline right away will be
        /// attempted to be run.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the TrainingPipeline in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="trainingPipeline">
        /// Required. The TrainingPipeline to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TrainingPipeline> CreateTrainingPipelineAsync(string parent, TrainingPipeline trainingPipeline, gaxgrpc::CallSettings callSettings = null) =>
            CreateTrainingPipelineAsync(new CreateTrainingPipelineRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TrainingPipeline = gax::GaxPreconditions.CheckNotNull(trainingPipeline, nameof(trainingPipeline)),
            }, callSettings);

        /// <summary>
        /// Creates a TrainingPipeline. A created TrainingPipeline right away will be
        /// attempted to be run.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the TrainingPipeline in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="trainingPipeline">
        /// Required. The TrainingPipeline to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TrainingPipeline> CreateTrainingPipelineAsync(string parent, TrainingPipeline trainingPipeline, st::CancellationToken cancellationToken) =>
            CreateTrainingPipelineAsync(parent, trainingPipeline, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a TrainingPipeline. A created TrainingPipeline right away will be
        /// attempted to be run.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the TrainingPipeline in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="trainingPipeline">
        /// Required. The TrainingPipeline to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TrainingPipeline CreateTrainingPipeline(gagr::LocationName parent, TrainingPipeline trainingPipeline, gaxgrpc::CallSettings callSettings = null) =>
            CreateTrainingPipeline(new CreateTrainingPipelineRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TrainingPipeline = gax::GaxPreconditions.CheckNotNull(trainingPipeline, nameof(trainingPipeline)),
            }, callSettings);

        /// <summary>
        /// Creates a TrainingPipeline. A created TrainingPipeline right away will be
        /// attempted to be run.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the TrainingPipeline in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="trainingPipeline">
        /// Required. The TrainingPipeline to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TrainingPipeline> CreateTrainingPipelineAsync(gagr::LocationName parent, TrainingPipeline trainingPipeline, gaxgrpc::CallSettings callSettings = null) =>
            CreateTrainingPipelineAsync(new CreateTrainingPipelineRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TrainingPipeline = gax::GaxPreconditions.CheckNotNull(trainingPipeline, nameof(trainingPipeline)),
            }, callSettings);

        /// <summary>
        /// Creates a TrainingPipeline. A created TrainingPipeline right away will be
        /// attempted to be run.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the TrainingPipeline in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="trainingPipeline">
        /// Required. The TrainingPipeline to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TrainingPipeline> CreateTrainingPipelineAsync(gagr::LocationName parent, TrainingPipeline trainingPipeline, st::CancellationToken cancellationToken) =>
            CreateTrainingPipelineAsync(parent, trainingPipeline, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a TrainingPipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TrainingPipeline GetTrainingPipeline(GetTrainingPipelineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a TrainingPipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TrainingPipeline> GetTrainingPipelineAsync(GetTrainingPipelineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a TrainingPipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TrainingPipeline> GetTrainingPipelineAsync(GetTrainingPipelineRequest request, st::CancellationToken cancellationToken) =>
            GetTrainingPipelineAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a TrainingPipeline.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TrainingPipeline resource.
        /// Format:
        /// `projects/{project}/locations/{location}/trainingPipelines/{training_pipeline}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TrainingPipeline GetTrainingPipeline(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTrainingPipeline(new GetTrainingPipelineRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a TrainingPipeline.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TrainingPipeline resource.
        /// Format:
        /// `projects/{project}/locations/{location}/trainingPipelines/{training_pipeline}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TrainingPipeline> GetTrainingPipelineAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTrainingPipelineAsync(new GetTrainingPipelineRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a TrainingPipeline.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TrainingPipeline resource.
        /// Format:
        /// `projects/{project}/locations/{location}/trainingPipelines/{training_pipeline}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TrainingPipeline> GetTrainingPipelineAsync(string name, st::CancellationToken cancellationToken) =>
            GetTrainingPipelineAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a TrainingPipeline.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TrainingPipeline resource.
        /// Format:
        /// `projects/{project}/locations/{location}/trainingPipelines/{training_pipeline}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TrainingPipeline GetTrainingPipeline(TrainingPipelineName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTrainingPipeline(new GetTrainingPipelineRequest
            {
                TrainingPipelineName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a TrainingPipeline.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TrainingPipeline resource.
        /// Format:
        /// `projects/{project}/locations/{location}/trainingPipelines/{training_pipeline}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TrainingPipeline> GetTrainingPipelineAsync(TrainingPipelineName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTrainingPipelineAsync(new GetTrainingPipelineRequest
            {
                TrainingPipelineName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a TrainingPipeline.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TrainingPipeline resource.
        /// Format:
        /// `projects/{project}/locations/{location}/trainingPipelines/{training_pipeline}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TrainingPipeline> GetTrainingPipelineAsync(TrainingPipelineName name, st::CancellationToken cancellationToken) =>
            GetTrainingPipelineAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists TrainingPipelines in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TrainingPipeline"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTrainingPipelinesResponse, TrainingPipeline> ListTrainingPipelines(ListTrainingPipelinesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists TrainingPipelines in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TrainingPipeline"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTrainingPipelinesResponse, TrainingPipeline> ListTrainingPipelinesAsync(ListTrainingPipelinesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists TrainingPipelines in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the TrainingPipelines from.
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
        /// <returns>A pageable sequence of <see cref="TrainingPipeline"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTrainingPipelinesResponse, TrainingPipeline> ListTrainingPipelines(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTrainingPipelines(new ListTrainingPipelinesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists TrainingPipelines in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the TrainingPipelines from.
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
        /// <returns>A pageable asynchronous sequence of <see cref="TrainingPipeline"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTrainingPipelinesResponse, TrainingPipeline> ListTrainingPipelinesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTrainingPipelinesAsync(new ListTrainingPipelinesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists TrainingPipelines in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the TrainingPipelines from.
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
        /// <returns>A pageable sequence of <see cref="TrainingPipeline"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTrainingPipelinesResponse, TrainingPipeline> ListTrainingPipelines(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTrainingPipelines(new ListTrainingPipelinesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists TrainingPipelines in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the TrainingPipelines from.
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
        /// <returns>A pageable asynchronous sequence of <see cref="TrainingPipeline"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTrainingPipelinesResponse, TrainingPipeline> ListTrainingPipelinesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTrainingPipelinesAsync(new ListTrainingPipelinesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Deletes a TrainingPipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteTrainingPipeline(DeleteTrainingPipelineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a TrainingPipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteTrainingPipelineAsync(DeleteTrainingPipelineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a TrainingPipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteTrainingPipelineAsync(DeleteTrainingPipelineRequest request, st::CancellationToken cancellationToken) =>
            DeleteTrainingPipelineAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteTrainingPipeline</c>.</summary>
        public virtual lro::OperationsClient DeleteTrainingPipelineOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteTrainingPipeline</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> PollOnceDeleteTrainingPipeline(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteTrainingPipelineOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteTrainingPipeline</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> PollOnceDeleteTrainingPipelineAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteTrainingPipelineOperationsClient, callSettings);

        /// <summary>
        /// Deletes a TrainingPipeline.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TrainingPipeline resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/trainingPipelines/{training_pipeline}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteTrainingPipeline(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTrainingPipeline(new DeleteTrainingPipelineRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a TrainingPipeline.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TrainingPipeline resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/trainingPipelines/{training_pipeline}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteTrainingPipelineAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTrainingPipelineAsync(new DeleteTrainingPipelineRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a TrainingPipeline.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TrainingPipeline resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/trainingPipelines/{training_pipeline}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteTrainingPipelineAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteTrainingPipelineAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a TrainingPipeline.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TrainingPipeline resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/trainingPipelines/{training_pipeline}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteTrainingPipeline(TrainingPipelineName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTrainingPipeline(new DeleteTrainingPipelineRequest
            {
                TrainingPipelineName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a TrainingPipeline.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TrainingPipeline resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/trainingPipelines/{training_pipeline}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteTrainingPipelineAsync(TrainingPipelineName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTrainingPipelineAsync(new DeleteTrainingPipelineRequest
            {
                TrainingPipelineName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a TrainingPipeline.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TrainingPipeline resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/trainingPipelines/{training_pipeline}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteTrainingPipelineAsync(TrainingPipelineName name, st::CancellationToken cancellationToken) =>
            DeleteTrainingPipelineAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels a TrainingPipeline.
        /// Starts asynchronous cancellation on the TrainingPipeline. The server
        /// makes a best effort to cancel the pipeline, but success is not
        /// guaranteed. Clients can use [PipelineService.GetTrainingPipeline][google.cloud.aiplatform.v1.PipelineService.GetTrainingPipeline] or
        /// other methods to check whether the cancellation succeeded or whether the
        /// pipeline completed despite cancellation. On successful cancellation,
        /// the TrainingPipeline is not deleted; instead it becomes a pipeline with
        /// a [TrainingPipeline.error][google.cloud.aiplatform.v1.TrainingPipeline.error] value with a [google.rpc.Status.code][google.rpc.Status.code] of 1,
        /// corresponding to `Code.CANCELLED`, and [TrainingPipeline.state][google.cloud.aiplatform.v1.TrainingPipeline.state] is set to
        /// `CANCELLED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void CancelTrainingPipeline(CancelTrainingPipelineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels a TrainingPipeline.
        /// Starts asynchronous cancellation on the TrainingPipeline. The server
        /// makes a best effort to cancel the pipeline, but success is not
        /// guaranteed. Clients can use [PipelineService.GetTrainingPipeline][google.cloud.aiplatform.v1.PipelineService.GetTrainingPipeline] or
        /// other methods to check whether the cancellation succeeded or whether the
        /// pipeline completed despite cancellation. On successful cancellation,
        /// the TrainingPipeline is not deleted; instead it becomes a pipeline with
        /// a [TrainingPipeline.error][google.cloud.aiplatform.v1.TrainingPipeline.error] value with a [google.rpc.Status.code][google.rpc.Status.code] of 1,
        /// corresponding to `Code.CANCELLED`, and [TrainingPipeline.state][google.cloud.aiplatform.v1.TrainingPipeline.state] is set to
        /// `CANCELLED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelTrainingPipelineAsync(CancelTrainingPipelineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels a TrainingPipeline.
        /// Starts asynchronous cancellation on the TrainingPipeline. The server
        /// makes a best effort to cancel the pipeline, but success is not
        /// guaranteed. Clients can use [PipelineService.GetTrainingPipeline][google.cloud.aiplatform.v1.PipelineService.GetTrainingPipeline] or
        /// other methods to check whether the cancellation succeeded or whether the
        /// pipeline completed despite cancellation. On successful cancellation,
        /// the TrainingPipeline is not deleted; instead it becomes a pipeline with
        /// a [TrainingPipeline.error][google.cloud.aiplatform.v1.TrainingPipeline.error] value with a [google.rpc.Status.code][google.rpc.Status.code] of 1,
        /// corresponding to `Code.CANCELLED`, and [TrainingPipeline.state][google.cloud.aiplatform.v1.TrainingPipeline.state] is set to
        /// `CANCELLED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelTrainingPipelineAsync(CancelTrainingPipelineRequest request, st::CancellationToken cancellationToken) =>
            CancelTrainingPipelineAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels a TrainingPipeline.
        /// Starts asynchronous cancellation on the TrainingPipeline. The server
        /// makes a best effort to cancel the pipeline, but success is not
        /// guaranteed. Clients can use [PipelineService.GetTrainingPipeline][google.cloud.aiplatform.v1.PipelineService.GetTrainingPipeline] or
        /// other methods to check whether the cancellation succeeded or whether the
        /// pipeline completed despite cancellation. On successful cancellation,
        /// the TrainingPipeline is not deleted; instead it becomes a pipeline with
        /// a [TrainingPipeline.error][google.cloud.aiplatform.v1.TrainingPipeline.error] value with a [google.rpc.Status.code][google.rpc.Status.code] of 1,
        /// corresponding to `Code.CANCELLED`, and [TrainingPipeline.state][google.cloud.aiplatform.v1.TrainingPipeline.state] is set to
        /// `CANCELLED`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TrainingPipeline to cancel.
        /// Format:
        /// `projects/{project}/locations/{location}/trainingPipelines/{training_pipeline}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void CancelTrainingPipeline(string name, gaxgrpc::CallSettings callSettings = null) =>
            CancelTrainingPipeline(new CancelTrainingPipelineRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels a TrainingPipeline.
        /// Starts asynchronous cancellation on the TrainingPipeline. The server
        /// makes a best effort to cancel the pipeline, but success is not
        /// guaranteed. Clients can use [PipelineService.GetTrainingPipeline][google.cloud.aiplatform.v1.PipelineService.GetTrainingPipeline] or
        /// other methods to check whether the cancellation succeeded or whether the
        /// pipeline completed despite cancellation. On successful cancellation,
        /// the TrainingPipeline is not deleted; instead it becomes a pipeline with
        /// a [TrainingPipeline.error][google.cloud.aiplatform.v1.TrainingPipeline.error] value with a [google.rpc.Status.code][google.rpc.Status.code] of 1,
        /// corresponding to `Code.CANCELLED`, and [TrainingPipeline.state][google.cloud.aiplatform.v1.TrainingPipeline.state] is set to
        /// `CANCELLED`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TrainingPipeline to cancel.
        /// Format:
        /// `projects/{project}/locations/{location}/trainingPipelines/{training_pipeline}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelTrainingPipelineAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            CancelTrainingPipelineAsync(new CancelTrainingPipelineRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels a TrainingPipeline.
        /// Starts asynchronous cancellation on the TrainingPipeline. The server
        /// makes a best effort to cancel the pipeline, but success is not
        /// guaranteed. Clients can use [PipelineService.GetTrainingPipeline][google.cloud.aiplatform.v1.PipelineService.GetTrainingPipeline] or
        /// other methods to check whether the cancellation succeeded or whether the
        /// pipeline completed despite cancellation. On successful cancellation,
        /// the TrainingPipeline is not deleted; instead it becomes a pipeline with
        /// a [TrainingPipeline.error][google.cloud.aiplatform.v1.TrainingPipeline.error] value with a [google.rpc.Status.code][google.rpc.Status.code] of 1,
        /// corresponding to `Code.CANCELLED`, and [TrainingPipeline.state][google.cloud.aiplatform.v1.TrainingPipeline.state] is set to
        /// `CANCELLED`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TrainingPipeline to cancel.
        /// Format:
        /// `projects/{project}/locations/{location}/trainingPipelines/{training_pipeline}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelTrainingPipelineAsync(string name, st::CancellationToken cancellationToken) =>
            CancelTrainingPipelineAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels a TrainingPipeline.
        /// Starts asynchronous cancellation on the TrainingPipeline. The server
        /// makes a best effort to cancel the pipeline, but success is not
        /// guaranteed. Clients can use [PipelineService.GetTrainingPipeline][google.cloud.aiplatform.v1.PipelineService.GetTrainingPipeline] or
        /// other methods to check whether the cancellation succeeded or whether the
        /// pipeline completed despite cancellation. On successful cancellation,
        /// the TrainingPipeline is not deleted; instead it becomes a pipeline with
        /// a [TrainingPipeline.error][google.cloud.aiplatform.v1.TrainingPipeline.error] value with a [google.rpc.Status.code][google.rpc.Status.code] of 1,
        /// corresponding to `Code.CANCELLED`, and [TrainingPipeline.state][google.cloud.aiplatform.v1.TrainingPipeline.state] is set to
        /// `CANCELLED`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TrainingPipeline to cancel.
        /// Format:
        /// `projects/{project}/locations/{location}/trainingPipelines/{training_pipeline}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void CancelTrainingPipeline(TrainingPipelineName name, gaxgrpc::CallSettings callSettings = null) =>
            CancelTrainingPipeline(new CancelTrainingPipelineRequest
            {
                TrainingPipelineName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels a TrainingPipeline.
        /// Starts asynchronous cancellation on the TrainingPipeline. The server
        /// makes a best effort to cancel the pipeline, but success is not
        /// guaranteed. Clients can use [PipelineService.GetTrainingPipeline][google.cloud.aiplatform.v1.PipelineService.GetTrainingPipeline] or
        /// other methods to check whether the cancellation succeeded or whether the
        /// pipeline completed despite cancellation. On successful cancellation,
        /// the TrainingPipeline is not deleted; instead it becomes a pipeline with
        /// a [TrainingPipeline.error][google.cloud.aiplatform.v1.TrainingPipeline.error] value with a [google.rpc.Status.code][google.rpc.Status.code] of 1,
        /// corresponding to `Code.CANCELLED`, and [TrainingPipeline.state][google.cloud.aiplatform.v1.TrainingPipeline.state] is set to
        /// `CANCELLED`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TrainingPipeline to cancel.
        /// Format:
        /// `projects/{project}/locations/{location}/trainingPipelines/{training_pipeline}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelTrainingPipelineAsync(TrainingPipelineName name, gaxgrpc::CallSettings callSettings = null) =>
            CancelTrainingPipelineAsync(new CancelTrainingPipelineRequest
            {
                TrainingPipelineName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels a TrainingPipeline.
        /// Starts asynchronous cancellation on the TrainingPipeline. The server
        /// makes a best effort to cancel the pipeline, but success is not
        /// guaranteed. Clients can use [PipelineService.GetTrainingPipeline][google.cloud.aiplatform.v1.PipelineService.GetTrainingPipeline] or
        /// other methods to check whether the cancellation succeeded or whether the
        /// pipeline completed despite cancellation. On successful cancellation,
        /// the TrainingPipeline is not deleted; instead it becomes a pipeline with
        /// a [TrainingPipeline.error][google.cloud.aiplatform.v1.TrainingPipeline.error] value with a [google.rpc.Status.code][google.rpc.Status.code] of 1,
        /// corresponding to `Code.CANCELLED`, and [TrainingPipeline.state][google.cloud.aiplatform.v1.TrainingPipeline.state] is set to
        /// `CANCELLED`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TrainingPipeline to cancel.
        /// Format:
        /// `projects/{project}/locations/{location}/trainingPipelines/{training_pipeline}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelTrainingPipelineAsync(TrainingPipelineName name, st::CancellationToken cancellationToken) =>
            CancelTrainingPipelineAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>PipelineService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service for creating and managing Vertex AI's pipelines. This includes both
    /// `TrainingPipeline` resources (used for AutoML and custom training) and
    /// `PipelineJob` resources (used for Vertex Pipelines).
    /// </remarks>
    public sealed partial class PipelineServiceClientImpl : PipelineServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateTrainingPipelineRequest, TrainingPipeline> _callCreateTrainingPipeline;

        private readonly gaxgrpc::ApiCall<GetTrainingPipelineRequest, TrainingPipeline> _callGetTrainingPipeline;

        private readonly gaxgrpc::ApiCall<ListTrainingPipelinesRequest, ListTrainingPipelinesResponse> _callListTrainingPipelines;

        private readonly gaxgrpc::ApiCall<DeleteTrainingPipelineRequest, lro::Operation> _callDeleteTrainingPipeline;

        private readonly gaxgrpc::ApiCall<CancelTrainingPipelineRequest, wkt::Empty> _callCancelTrainingPipeline;

        /// <summary>
        /// Constructs a client wrapper for the PipelineService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="PipelineServiceSettings"/> used within this client.</param>
        public PipelineServiceClientImpl(PipelineService.PipelineServiceClient grpcClient, PipelineServiceSettings settings)
        {
            GrpcClient = grpcClient;
            PipelineServiceSettings effectiveSettings = settings ?? PipelineServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            DeleteTrainingPipelineOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteTrainingPipelineOperationsSettings);
            _callCreateTrainingPipeline = clientHelper.BuildApiCall<CreateTrainingPipelineRequest, TrainingPipeline>(grpcClient.CreateTrainingPipelineAsync, grpcClient.CreateTrainingPipeline, effectiveSettings.CreateTrainingPipelineSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateTrainingPipeline);
            Modify_CreateTrainingPipelineApiCall(ref _callCreateTrainingPipeline);
            _callGetTrainingPipeline = clientHelper.BuildApiCall<GetTrainingPipelineRequest, TrainingPipeline>(grpcClient.GetTrainingPipelineAsync, grpcClient.GetTrainingPipeline, effectiveSettings.GetTrainingPipelineSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTrainingPipeline);
            Modify_GetTrainingPipelineApiCall(ref _callGetTrainingPipeline);
            _callListTrainingPipelines = clientHelper.BuildApiCall<ListTrainingPipelinesRequest, ListTrainingPipelinesResponse>(grpcClient.ListTrainingPipelinesAsync, grpcClient.ListTrainingPipelines, effectiveSettings.ListTrainingPipelinesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTrainingPipelines);
            Modify_ListTrainingPipelinesApiCall(ref _callListTrainingPipelines);
            _callDeleteTrainingPipeline = clientHelper.BuildApiCall<DeleteTrainingPipelineRequest, lro::Operation>(grpcClient.DeleteTrainingPipelineAsync, grpcClient.DeleteTrainingPipeline, effectiveSettings.DeleteTrainingPipelineSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTrainingPipeline);
            Modify_DeleteTrainingPipelineApiCall(ref _callDeleteTrainingPipeline);
            _callCancelTrainingPipeline = clientHelper.BuildApiCall<CancelTrainingPipelineRequest, wkt::Empty>(grpcClient.CancelTrainingPipelineAsync, grpcClient.CancelTrainingPipeline, effectiveSettings.CancelTrainingPipelineSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCancelTrainingPipeline);
            Modify_CancelTrainingPipelineApiCall(ref _callCancelTrainingPipeline);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateTrainingPipelineApiCall(ref gaxgrpc::ApiCall<CreateTrainingPipelineRequest, TrainingPipeline> call);

        partial void Modify_GetTrainingPipelineApiCall(ref gaxgrpc::ApiCall<GetTrainingPipelineRequest, TrainingPipeline> call);

        partial void Modify_ListTrainingPipelinesApiCall(ref gaxgrpc::ApiCall<ListTrainingPipelinesRequest, ListTrainingPipelinesResponse> call);

        partial void Modify_DeleteTrainingPipelineApiCall(ref gaxgrpc::ApiCall<DeleteTrainingPipelineRequest, lro::Operation> call);

        partial void Modify_CancelTrainingPipelineApiCall(ref gaxgrpc::ApiCall<CancelTrainingPipelineRequest, wkt::Empty> call);

        partial void OnConstruction(PipelineService.PipelineServiceClient grpcClient, PipelineServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC PipelineService client</summary>
        public override PipelineService.PipelineServiceClient GrpcClient { get; }

        partial void Modify_CreateTrainingPipelineRequest(ref CreateTrainingPipelineRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTrainingPipelineRequest(ref GetTrainingPipelineRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTrainingPipelinesRequest(ref ListTrainingPipelinesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTrainingPipelineRequest(ref DeleteTrainingPipelineRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CancelTrainingPipelineRequest(ref CancelTrainingPipelineRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a TrainingPipeline. A created TrainingPipeline right away will be
        /// attempted to be run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TrainingPipeline CreateTrainingPipeline(CreateTrainingPipelineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTrainingPipelineRequest(ref request, ref callSettings);
            return _callCreateTrainingPipeline.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a TrainingPipeline. A created TrainingPipeline right away will be
        /// attempted to be run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TrainingPipeline> CreateTrainingPipelineAsync(CreateTrainingPipelineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTrainingPipelineRequest(ref request, ref callSettings);
            return _callCreateTrainingPipeline.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a TrainingPipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TrainingPipeline GetTrainingPipeline(GetTrainingPipelineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTrainingPipelineRequest(ref request, ref callSettings);
            return _callGetTrainingPipeline.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a TrainingPipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TrainingPipeline> GetTrainingPipelineAsync(GetTrainingPipelineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTrainingPipelineRequest(ref request, ref callSettings);
            return _callGetTrainingPipeline.Async(request, callSettings);
        }

        /// <summary>
        /// Lists TrainingPipelines in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TrainingPipeline"/> resources.</returns>
        public override gax::PagedEnumerable<ListTrainingPipelinesResponse, TrainingPipeline> ListTrainingPipelines(ListTrainingPipelinesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTrainingPipelinesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTrainingPipelinesRequest, ListTrainingPipelinesResponse, TrainingPipeline>(_callListTrainingPipelines, request, callSettings);
        }

        /// <summary>
        /// Lists TrainingPipelines in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TrainingPipeline"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTrainingPipelinesResponse, TrainingPipeline> ListTrainingPipelinesAsync(ListTrainingPipelinesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTrainingPipelinesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTrainingPipelinesRequest, ListTrainingPipelinesResponse, TrainingPipeline>(_callListTrainingPipelines, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteTrainingPipeline</c>.</summary>
        public override lro::OperationsClient DeleteTrainingPipelineOperationsClient { get; }

        /// <summary>
        /// Deletes a TrainingPipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteTrainingPipeline(DeleteTrainingPipelineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTrainingPipelineRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(_callDeleteTrainingPipeline.Sync(request, callSettings), DeleteTrainingPipelineOperationsClient);
        }

        /// <summary>
        /// Deletes a TrainingPipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteTrainingPipelineAsync(DeleteTrainingPipelineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTrainingPipelineRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(await _callDeleteTrainingPipeline.Async(request, callSettings).ConfigureAwait(false), DeleteTrainingPipelineOperationsClient);
        }

        /// <summary>
        /// Cancels a TrainingPipeline.
        /// Starts asynchronous cancellation on the TrainingPipeline. The server
        /// makes a best effort to cancel the pipeline, but success is not
        /// guaranteed. Clients can use [PipelineService.GetTrainingPipeline][google.cloud.aiplatform.v1.PipelineService.GetTrainingPipeline] or
        /// other methods to check whether the cancellation succeeded or whether the
        /// pipeline completed despite cancellation. On successful cancellation,
        /// the TrainingPipeline is not deleted; instead it becomes a pipeline with
        /// a [TrainingPipeline.error][google.cloud.aiplatform.v1.TrainingPipeline.error] value with a [google.rpc.Status.code][google.rpc.Status.code] of 1,
        /// corresponding to `Code.CANCELLED`, and [TrainingPipeline.state][google.cloud.aiplatform.v1.TrainingPipeline.state] is set to
        /// `CANCELLED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void CancelTrainingPipeline(CancelTrainingPipelineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelTrainingPipelineRequest(ref request, ref callSettings);
            _callCancelTrainingPipeline.Sync(request, callSettings);
        }

        /// <summary>
        /// Cancels a TrainingPipeline.
        /// Starts asynchronous cancellation on the TrainingPipeline. The server
        /// makes a best effort to cancel the pipeline, but success is not
        /// guaranteed. Clients can use [PipelineService.GetTrainingPipeline][google.cloud.aiplatform.v1.PipelineService.GetTrainingPipeline] or
        /// other methods to check whether the cancellation succeeded or whether the
        /// pipeline completed despite cancellation. On successful cancellation,
        /// the TrainingPipeline is not deleted; instead it becomes a pipeline with
        /// a [TrainingPipeline.error][google.cloud.aiplatform.v1.TrainingPipeline.error] value with a [google.rpc.Status.code][google.rpc.Status.code] of 1,
        /// corresponding to `Code.CANCELLED`, and [TrainingPipeline.state][google.cloud.aiplatform.v1.TrainingPipeline.state] is set to
        /// `CANCELLED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task CancelTrainingPipelineAsync(CancelTrainingPipelineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelTrainingPipelineRequest(ref request, ref callSettings);
            return _callCancelTrainingPipeline.Async(request, callSettings);
        }
    }

    public partial class ListTrainingPipelinesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTrainingPipelinesResponse : gaxgrpc::IPageResponse<TrainingPipeline>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<TrainingPipeline> GetEnumerator() => TrainingPipelines.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class PipelineService
    {
        public partial class PipelineServiceClient
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
