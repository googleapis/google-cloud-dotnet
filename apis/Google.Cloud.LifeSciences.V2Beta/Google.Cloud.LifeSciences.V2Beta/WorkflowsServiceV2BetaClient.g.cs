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
using gcl = Google.Cloud.Location;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using lro = Google.LongRunning;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.LifeSciences.V2Beta
{
    /// <summary>Settings for <see cref="WorkflowsServiceV2BetaClient"/> instances.</summary>
    public sealed partial class WorkflowsServiceV2BetaSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="WorkflowsServiceV2BetaSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="WorkflowsServiceV2BetaSettings"/>.</returns>
        public static WorkflowsServiceV2BetaSettings GetDefault() => new WorkflowsServiceV2BetaSettings();

        /// <summary>
        /// Constructs a new <see cref="WorkflowsServiceV2BetaSettings"/> object with default settings.
        /// </summary>
        public WorkflowsServiceV2BetaSettings()
        {
        }

        private WorkflowsServiceV2BetaSettings(WorkflowsServiceV2BetaSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            RunPipelineSettings = existing.RunPipelineSettings;
            RunPipelineOperationsSettings = existing.RunPipelineOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(WorkflowsServiceV2BetaSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkflowsServiceV2BetaClient.RunPipeline</c> and <c>WorkflowsServiceV2BetaClient.RunPipelineAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RunPipelineSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>WorkflowsServiceV2BetaClient.RunPipeline</c> and
        /// <c>WorkflowsServiceV2BetaClient.RunPipelineAsync</c>.
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
        public lro::OperationsSettings RunPipelineOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="WorkflowsServiceV2BetaSettings"/> object.</returns>
        public WorkflowsServiceV2BetaSettings Clone() => new WorkflowsServiceV2BetaSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="WorkflowsServiceV2BetaClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class WorkflowsServiceV2BetaClientBuilder : gaxgrpc::ClientBuilderBase<WorkflowsServiceV2BetaClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public WorkflowsServiceV2BetaSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public WorkflowsServiceV2BetaClientBuilder() : base(WorkflowsServiceV2BetaClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref WorkflowsServiceV2BetaClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<WorkflowsServiceV2BetaClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override WorkflowsServiceV2BetaClient Build()
        {
            WorkflowsServiceV2BetaClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<WorkflowsServiceV2BetaClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<WorkflowsServiceV2BetaClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private WorkflowsServiceV2BetaClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return WorkflowsServiceV2BetaClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<WorkflowsServiceV2BetaClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return WorkflowsServiceV2BetaClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => WorkflowsServiceV2BetaClient.ChannelPool;
    }

    /// <summary>WorkflowsServiceV2Beta client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service for running workflows, such as pipelines consisting of Docker
    /// containers.
    /// </remarks>
    public abstract partial class WorkflowsServiceV2BetaClient
    {
        /// <summary>
        /// The default endpoint for the WorkflowsServiceV2Beta service, which is a host of
        /// "lifesciences.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "lifesciences.googleapis.com:443";

        /// <summary>The default WorkflowsServiceV2Beta scopes.</summary>
        /// <remarks>
        /// The default WorkflowsServiceV2Beta scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(WorkflowsServiceV2Beta.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="WorkflowsServiceV2BetaClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="WorkflowsServiceV2BetaClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="WorkflowsServiceV2BetaClient"/>.</returns>
        public static stt::Task<WorkflowsServiceV2BetaClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new WorkflowsServiceV2BetaClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="WorkflowsServiceV2BetaClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="WorkflowsServiceV2BetaClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="WorkflowsServiceV2BetaClient"/>.</returns>
        public static WorkflowsServiceV2BetaClient Create() => new WorkflowsServiceV2BetaClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="WorkflowsServiceV2BetaClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="WorkflowsServiceV2BetaSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="WorkflowsServiceV2BetaClient"/>.</returns>
        internal static WorkflowsServiceV2BetaClient Create(grpccore::CallInvoker callInvoker, WorkflowsServiceV2BetaSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            WorkflowsServiceV2Beta.WorkflowsServiceV2BetaClient grpcClient = new WorkflowsServiceV2Beta.WorkflowsServiceV2BetaClient(callInvoker);
            return new WorkflowsServiceV2BetaClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC WorkflowsServiceV2Beta client</summary>
        public virtual WorkflowsServiceV2Beta.WorkflowsServiceV2BetaClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Runs a pipeline.  The returned Operation's [metadata]
        /// [google.longrunning.Operation.metadata] field will contain a
        /// [google.cloud.lifesciences.v2beta.Metadata][google.cloud.lifesciences.v2beta.Metadata]
        /// object describing the status of the pipeline execution. The
        /// [response][google.longrunning.Operation.response] field will contain a
        /// [google.cloud.lifesciences.v2beta.RunPipelineResponse][google.cloud.lifesciences.v2beta.RunPipelineResponse]
        /// object if the pipeline completes successfully.
        /// 
        /// **Note:** Before you can use this method, the *Life Sciences Service Agent*
        /// must have access to your project. This is done automatically when the
        /// Cloud Life Sciences API is first enabled, but if you delete this permission
        /// you must disable and re-enable the API to grant the Life Sciences
        /// Service Agent the required permissions.
        /// Authorization requires the following [Google
        /// IAM](https://cloud.google.com/iam/) permission:
        /// 
        /// * `lifesciences.workflows.run`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RunPipelineResponse, Metadata> RunPipeline(RunPipelineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Runs a pipeline.  The returned Operation's [metadata]
        /// [google.longrunning.Operation.metadata] field will contain a
        /// [google.cloud.lifesciences.v2beta.Metadata][google.cloud.lifesciences.v2beta.Metadata]
        /// object describing the status of the pipeline execution. The
        /// [response][google.longrunning.Operation.response] field will contain a
        /// [google.cloud.lifesciences.v2beta.RunPipelineResponse][google.cloud.lifesciences.v2beta.RunPipelineResponse]
        /// object if the pipeline completes successfully.
        /// 
        /// **Note:** Before you can use this method, the *Life Sciences Service Agent*
        /// must have access to your project. This is done automatically when the
        /// Cloud Life Sciences API is first enabled, but if you delete this permission
        /// you must disable and re-enable the API to grant the Life Sciences
        /// Service Agent the required permissions.
        /// Authorization requires the following [Google
        /// IAM](https://cloud.google.com/iam/) permission:
        /// 
        /// * `lifesciences.workflows.run`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RunPipelineResponse, Metadata>> RunPipelineAsync(RunPipelineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Runs a pipeline.  The returned Operation's [metadata]
        /// [google.longrunning.Operation.metadata] field will contain a
        /// [google.cloud.lifesciences.v2beta.Metadata][google.cloud.lifesciences.v2beta.Metadata]
        /// object describing the status of the pipeline execution. The
        /// [response][google.longrunning.Operation.response] field will contain a
        /// [google.cloud.lifesciences.v2beta.RunPipelineResponse][google.cloud.lifesciences.v2beta.RunPipelineResponse]
        /// object if the pipeline completes successfully.
        /// 
        /// **Note:** Before you can use this method, the *Life Sciences Service Agent*
        /// must have access to your project. This is done automatically when the
        /// Cloud Life Sciences API is first enabled, but if you delete this permission
        /// you must disable and re-enable the API to grant the Life Sciences
        /// Service Agent the required permissions.
        /// Authorization requires the following [Google
        /// IAM](https://cloud.google.com/iam/) permission:
        /// 
        /// * `lifesciences.workflows.run`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RunPipelineResponse, Metadata>> RunPipelineAsync(RunPipelineRequest request, st::CancellationToken cancellationToken) =>
            RunPipelineAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RunPipeline</c>.</summary>
        public virtual lro::OperationsClient RunPipelineOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RunPipeline</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<RunPipelineResponse, Metadata> PollOnceRunPipeline(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RunPipelineResponse, Metadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RunPipelineOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RunPipeline</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<RunPipelineResponse, Metadata>> PollOnceRunPipelineAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RunPipelineResponse, Metadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RunPipelineOperationsClient, callSettings);
    }

    /// <summary>WorkflowsServiceV2Beta client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service for running workflows, such as pipelines consisting of Docker
    /// containers.
    /// </remarks>
    public sealed partial class WorkflowsServiceV2BetaClientImpl : WorkflowsServiceV2BetaClient
    {
        private readonly gaxgrpc::ApiCall<RunPipelineRequest, lro::Operation> _callRunPipeline;

        /// <summary>
        /// Constructs a client wrapper for the WorkflowsServiceV2Beta service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="WorkflowsServiceV2BetaSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public WorkflowsServiceV2BetaClientImpl(WorkflowsServiceV2Beta.WorkflowsServiceV2BetaClient grpcClient, WorkflowsServiceV2BetaSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            WorkflowsServiceV2BetaSettings effectiveSettings = settings ?? WorkflowsServiceV2BetaSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            RunPipelineOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RunPipelineOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callRunPipeline = clientHelper.BuildApiCall<RunPipelineRequest, lro::Operation>("RunPipeline", grpcClient.RunPipelineAsync, grpcClient.RunPipeline, effectiveSettings.RunPipelineSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callRunPipeline);
            Modify_RunPipelineApiCall(ref _callRunPipeline);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_RunPipelineApiCall(ref gaxgrpc::ApiCall<RunPipelineRequest, lro::Operation> call);

        partial void OnConstruction(WorkflowsServiceV2Beta.WorkflowsServiceV2BetaClient grpcClient, WorkflowsServiceV2BetaSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC WorkflowsServiceV2Beta client</summary>
        public override WorkflowsServiceV2Beta.WorkflowsServiceV2BetaClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_RunPipelineRequest(ref RunPipelineRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>RunPipeline</c>.</summary>
        public override lro::OperationsClient RunPipelineOperationsClient { get; }

        /// <summary>
        /// Runs a pipeline.  The returned Operation's [metadata]
        /// [google.longrunning.Operation.metadata] field will contain a
        /// [google.cloud.lifesciences.v2beta.Metadata][google.cloud.lifesciences.v2beta.Metadata]
        /// object describing the status of the pipeline execution. The
        /// [response][google.longrunning.Operation.response] field will contain a
        /// [google.cloud.lifesciences.v2beta.RunPipelineResponse][google.cloud.lifesciences.v2beta.RunPipelineResponse]
        /// object if the pipeline completes successfully.
        /// 
        /// **Note:** Before you can use this method, the *Life Sciences Service Agent*
        /// must have access to your project. This is done automatically when the
        /// Cloud Life Sciences API is first enabled, but if you delete this permission
        /// you must disable and re-enable the API to grant the Life Sciences
        /// Service Agent the required permissions.
        /// Authorization requires the following [Google
        /// IAM](https://cloud.google.com/iam/) permission:
        /// 
        /// * `lifesciences.workflows.run`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<RunPipelineResponse, Metadata> RunPipeline(RunPipelineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunPipelineRequest(ref request, ref callSettings);
            return new lro::Operation<RunPipelineResponse, Metadata>(_callRunPipeline.Sync(request, callSettings), RunPipelineOperationsClient);
        }

        /// <summary>
        /// Runs a pipeline.  The returned Operation's [metadata]
        /// [google.longrunning.Operation.metadata] field will contain a
        /// [google.cloud.lifesciences.v2beta.Metadata][google.cloud.lifesciences.v2beta.Metadata]
        /// object describing the status of the pipeline execution. The
        /// [response][google.longrunning.Operation.response] field will contain a
        /// [google.cloud.lifesciences.v2beta.RunPipelineResponse][google.cloud.lifesciences.v2beta.RunPipelineResponse]
        /// object if the pipeline completes successfully.
        /// 
        /// **Note:** Before you can use this method, the *Life Sciences Service Agent*
        /// must have access to your project. This is done automatically when the
        /// Cloud Life Sciences API is first enabled, but if you delete this permission
        /// you must disable and re-enable the API to grant the Life Sciences
        /// Service Agent the required permissions.
        /// Authorization requires the following [Google
        /// IAM](https://cloud.google.com/iam/) permission:
        /// 
        /// * `lifesciences.workflows.run`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<RunPipelineResponse, Metadata>> RunPipelineAsync(RunPipelineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunPipelineRequest(ref request, ref callSettings);
            return new lro::Operation<RunPipelineResponse, Metadata>(await _callRunPipeline.Async(request, callSettings).ConfigureAwait(false), RunPipelineOperationsClient);
        }
    }

    public static partial class WorkflowsServiceV2Beta
    {
        public partial class WorkflowsServiceV2BetaClient
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

    public static partial class WorkflowsServiceV2Beta
    {
        public partial class WorkflowsServiceV2BetaClient
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
