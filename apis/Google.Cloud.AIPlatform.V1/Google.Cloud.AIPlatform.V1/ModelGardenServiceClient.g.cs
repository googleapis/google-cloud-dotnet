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
using gciv = Google.Cloud.Iam.V1;
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

namespace Google.Cloud.AIPlatform.V1
{
    /// <summary>Settings for <see cref="ModelGardenServiceClient"/> instances.</summary>
    public sealed partial class ModelGardenServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ModelGardenServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ModelGardenServiceSettings"/>.</returns>
        public static ModelGardenServiceSettings GetDefault() => new ModelGardenServiceSettings();

        /// <summary>Constructs a new <see cref="ModelGardenServiceSettings"/> object with default settings.</summary>
        public ModelGardenServiceSettings()
        {
        }

        private ModelGardenServiceSettings(ModelGardenServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetPublisherModelSettings = existing.GetPublisherModelSettings;
            DeploySettings = existing.DeploySettings;
            DeployOperationsSettings = existing.DeployOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(ModelGardenServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelGardenServiceClient.GetPublisherModel</c> and <c>ModelGardenServiceClient.GetPublisherModelAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetPublisherModelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelGardenServiceClient.Deploy</c> and <c>ModelGardenServiceClient.DeployAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeploySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ModelGardenServiceClient.Deploy</c> and
        /// <c>ModelGardenServiceClient.DeployAsync</c>.
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
        public lro::OperationsSettings DeployOperationsSettings { get; set; } = new lro::OperationsSettings
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
        /// <returns>A deep clone of this <see cref="ModelGardenServiceSettings"/> object.</returns>
        public ModelGardenServiceSettings Clone() => new ModelGardenServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ModelGardenServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class ModelGardenServiceClientBuilder : gaxgrpc::ClientBuilderBase<ModelGardenServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ModelGardenServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ModelGardenServiceClientBuilder() : base(ModelGardenServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ModelGardenServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ModelGardenServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ModelGardenServiceClient Build()
        {
            ModelGardenServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ModelGardenServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ModelGardenServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ModelGardenServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ModelGardenServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ModelGardenServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ModelGardenServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ModelGardenServiceClient.ChannelPool;
    }

    /// <summary>ModelGardenService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The interface of Model Garden Service.
    /// </remarks>
    public abstract partial class ModelGardenServiceClient
    {
        /// <summary>
        /// The default endpoint for the ModelGardenService service, which is a host of "aiplatform.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "aiplatform.googleapis.com:443";

        /// <summary>The default ModelGardenService scopes.</summary>
        /// <remarks>
        /// The default ModelGardenService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ModelGardenService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ModelGardenServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ModelGardenServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ModelGardenServiceClient"/>.</returns>
        public static stt::Task<ModelGardenServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ModelGardenServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ModelGardenServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ModelGardenServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="ModelGardenServiceClient"/>.</returns>
        public static ModelGardenServiceClient Create() => new ModelGardenServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ModelGardenServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ModelGardenServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ModelGardenServiceClient"/>.</returns>
        internal static ModelGardenServiceClient Create(grpccore::CallInvoker callInvoker, ModelGardenServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ModelGardenService.ModelGardenServiceClient grpcClient = new ModelGardenService.ModelGardenServiceClient(callInvoker);
            return new ModelGardenServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ModelGardenService client</summary>
        public virtual ModelGardenService.ModelGardenServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a Model Garden publisher model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PublisherModel GetPublisherModel(GetPublisherModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a Model Garden publisher model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublisherModel> GetPublisherModelAsync(GetPublisherModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a Model Garden publisher model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublisherModel> GetPublisherModelAsync(GetPublisherModelRequest request, st::CancellationToken cancellationToken) =>
            GetPublisherModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Model Garden publisher model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PublisherModel resource.
        /// Format:
        /// `publishers/{publisher}/models/{publisher_model}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PublisherModel GetPublisherModel(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPublisherModel(new GetPublisherModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Model Garden publisher model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PublisherModel resource.
        /// Format:
        /// `publishers/{publisher}/models/{publisher_model}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublisherModel> GetPublisherModelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPublisherModelAsync(new GetPublisherModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Model Garden publisher model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PublisherModel resource.
        /// Format:
        /// `publishers/{publisher}/models/{publisher_model}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublisherModel> GetPublisherModelAsync(string name, st::CancellationToken cancellationToken) =>
            GetPublisherModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Model Garden publisher model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PublisherModel resource.
        /// Format:
        /// `publishers/{publisher}/models/{publisher_model}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PublisherModel GetPublisherModel(PublisherModelName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPublisherModel(new GetPublisherModelRequest
            {
                PublisherModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Model Garden publisher model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PublisherModel resource.
        /// Format:
        /// `publishers/{publisher}/models/{publisher_model}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublisherModel> GetPublisherModelAsync(PublisherModelName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPublisherModelAsync(new GetPublisherModelRequest
            {
                PublisherModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Model Garden publisher model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PublisherModel resource.
        /// Format:
        /// `publishers/{publisher}/models/{publisher_model}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublisherModel> GetPublisherModelAsync(PublisherModelName name, st::CancellationToken cancellationToken) =>
            GetPublisherModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deploys a model to a new endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeployResponse, DeployOperationMetadata> Deploy(DeployRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deploys a model to a new endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployResponse, DeployOperationMetadata>> DeployAsync(DeployRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deploys a model to a new endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployResponse, DeployOperationMetadata>> DeployAsync(DeployRequest request, st::CancellationToken cancellationToken) =>
            DeployAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>Deploy</c>.</summary>
        public virtual lro::OperationsClient DeployOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Deploy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DeployResponse, DeployOperationMetadata> PollOnceDeploy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DeployResponse, DeployOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeployOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Deploy</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DeployResponse, DeployOperationMetadata>> PollOnceDeployAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DeployResponse, DeployOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeployOperationsClient, callSettings);
    }

    /// <summary>ModelGardenService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The interface of Model Garden Service.
    /// </remarks>
    public sealed partial class ModelGardenServiceClientImpl : ModelGardenServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetPublisherModelRequest, PublisherModel> _callGetPublisherModel;

        private readonly gaxgrpc::ApiCall<DeployRequest, lro::Operation> _callDeploy;

        /// <summary>
        /// Constructs a client wrapper for the ModelGardenService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ModelGardenServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ModelGardenServiceClientImpl(ModelGardenService.ModelGardenServiceClient grpcClient, ModelGardenServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ModelGardenServiceSettings effectiveSettings = settings ?? ModelGardenServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            DeployOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeployOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callGetPublisherModel = clientHelper.BuildApiCall<GetPublisherModelRequest, PublisherModel>("GetPublisherModel", grpcClient.GetPublisherModelAsync, grpcClient.GetPublisherModel, effectiveSettings.GetPublisherModelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPublisherModel);
            Modify_GetPublisherModelApiCall(ref _callGetPublisherModel);
            _callDeploy = clientHelper.BuildApiCall<DeployRequest, lro::Operation>("Deploy", grpcClient.DeployAsync, grpcClient.Deploy, effectiveSettings.DeploySettings).WithGoogleRequestParam("destination", request => request.Destination);
            Modify_ApiCall(ref _callDeploy);
            Modify_DeployApiCall(ref _callDeploy);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetPublisherModelApiCall(ref gaxgrpc::ApiCall<GetPublisherModelRequest, PublisherModel> call);

        partial void Modify_DeployApiCall(ref gaxgrpc::ApiCall<DeployRequest, lro::Operation> call);

        partial void OnConstruction(ModelGardenService.ModelGardenServiceClient grpcClient, ModelGardenServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ModelGardenService client</summary>
        public override ModelGardenService.ModelGardenServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_GetPublisherModelRequest(ref GetPublisherModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeployRequest(ref DeployRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets a Model Garden publisher model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PublisherModel GetPublisherModel(GetPublisherModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPublisherModelRequest(ref request, ref callSettings);
            return _callGetPublisherModel.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a Model Garden publisher model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PublisherModel> GetPublisherModelAsync(GetPublisherModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPublisherModelRequest(ref request, ref callSettings);
            return _callGetPublisherModel.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>Deploy</c>.</summary>
        public override lro::OperationsClient DeployOperationsClient { get; }

        /// <summary>
        /// Deploys a model to a new endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DeployResponse, DeployOperationMetadata> Deploy(DeployRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeployRequest(ref request, ref callSettings);
            return new lro::Operation<DeployResponse, DeployOperationMetadata>(_callDeploy.Sync(request, callSettings), DeployOperationsClient);
        }

        /// <summary>
        /// Deploys a model to a new endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DeployResponse, DeployOperationMetadata>> DeployAsync(DeployRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeployRequest(ref request, ref callSettings);
            return new lro::Operation<DeployResponse, DeployOperationMetadata>(await _callDeploy.Async(request, callSettings).ConfigureAwait(false), DeployOperationsClient);
        }
    }

    public static partial class ModelGardenService
    {
        public partial class ModelGardenServiceClient
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

    public static partial class ModelGardenService
    {
        public partial class ModelGardenServiceClient
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
