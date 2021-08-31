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
    /// <summary>Settings for <see cref="ModelServiceClient"/> instances.</summary>
    public sealed partial class ModelServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ModelServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ModelServiceSettings"/>.</returns>
        public static ModelServiceSettings GetDefault() => new ModelServiceSettings();

        /// <summary>Constructs a new <see cref="ModelServiceSettings"/> object with default settings.</summary>
        public ModelServiceSettings()
        {
        }

        private ModelServiceSettings(ModelServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            UploadModelSettings = existing.UploadModelSettings;
            UploadModelOperationsSettings = existing.UploadModelOperationsSettings.Clone();
            GetModelSettings = existing.GetModelSettings;
            ListModelsSettings = existing.ListModelsSettings;
            UpdateModelSettings = existing.UpdateModelSettings;
            DeleteModelSettings = existing.DeleteModelSettings;
            DeleteModelOperationsSettings = existing.DeleteModelOperationsSettings.Clone();
            ExportModelSettings = existing.ExportModelSettings;
            ExportModelOperationsSettings = existing.ExportModelOperationsSettings.Clone();
            GetModelEvaluationSettings = existing.GetModelEvaluationSettings;
            ListModelEvaluationsSettings = existing.ListModelEvaluationsSettings;
            GetModelEvaluationSliceSettings = existing.GetModelEvaluationSliceSettings;
            ListModelEvaluationSlicesSettings = existing.ListModelEvaluationSlicesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ModelServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelServiceClient.UploadModel</c> and <c>ModelServiceClient.UploadModelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UploadModelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ModelServiceClient.UploadModel</c> and
        /// <c>ModelServiceClient.UploadModelAsync</c>.
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
        public lro::OperationsSettings UploadModelOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ModelServiceClient.GetModel</c>
        ///  and <c>ModelServiceClient.GetModelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetModelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelServiceClient.ListModels</c> and <c>ModelServiceClient.ListModelsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListModelsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelServiceClient.UpdateModel</c> and <c>ModelServiceClient.UpdateModelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateModelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelServiceClient.DeleteModel</c> and <c>ModelServiceClient.DeleteModelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteModelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ModelServiceClient.DeleteModel</c> and
        /// <c>ModelServiceClient.DeleteModelAsync</c>.
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
        public lro::OperationsSettings DeleteModelOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelServiceClient.ExportModel</c> and <c>ModelServiceClient.ExportModelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExportModelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ModelServiceClient.ExportModel</c> and
        /// <c>ModelServiceClient.ExportModelAsync</c>.
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
        public lro::OperationsSettings ExportModelOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelServiceClient.GetModelEvaluation</c> and <c>ModelServiceClient.GetModelEvaluationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetModelEvaluationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelServiceClient.ListModelEvaluations</c> and <c>ModelServiceClient.ListModelEvaluationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListModelEvaluationsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelServiceClient.GetModelEvaluationSlice</c> and <c>ModelServiceClient.GetModelEvaluationSliceAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetModelEvaluationSliceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelServiceClient.ListModelEvaluationSlices</c> and <c>ModelServiceClient.ListModelEvaluationSlicesAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListModelEvaluationSlicesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ModelServiceSettings"/> object.</returns>
        public ModelServiceSettings Clone() => new ModelServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ModelServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class ModelServiceClientBuilder : gaxgrpc::ClientBuilderBase<ModelServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ModelServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ModelServiceClientBuilder()
        {
            UseJwtAccessWithScopes = ModelServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref ModelServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ModelServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ModelServiceClient Build()
        {
            ModelServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ModelServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ModelServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ModelServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ModelServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<ModelServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ModelServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => ModelServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => ModelServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ModelServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>ModelService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service for managing Vertex AI's machine learning Models.
    /// </remarks>
    public abstract partial class ModelServiceClient
    {
        /// <summary>
        /// The default endpoint for the ModelService service, which is a host of "aiplatform.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "aiplatform.googleapis.com:443";

        /// <summary>The default ModelService scopes.</summary>
        /// <remarks>
        /// The default ModelService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes, UseJwtAccessWithScopes);

        internal static bool UseJwtAccessWithScopes
        {
            get
            {
                bool useJwtAccessWithScopes = true;
                MaybeUseJwtAccessWithScopes(ref useJwtAccessWithScopes);
                return useJwtAccessWithScopes;
            }
        }

        static partial void MaybeUseJwtAccessWithScopes(ref bool useJwtAccessWithScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="ModelServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ModelServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ModelServiceClient"/>.</returns>
        public static stt::Task<ModelServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ModelServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ModelServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ModelServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ModelServiceClient"/>.</returns>
        public static ModelServiceClient Create() => new ModelServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ModelServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ModelServiceSettings"/>.</param>
        /// <returns>The created <see cref="ModelServiceClient"/>.</returns>
        internal static ModelServiceClient Create(grpccore::CallInvoker callInvoker, ModelServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ModelService.ModelServiceClient grpcClient = new ModelService.ModelServiceClient(callInvoker);
            return new ModelServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC ModelService client</summary>
        public virtual ModelService.ModelServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Uploads a Model artifact into Vertex AI.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UploadModelResponse, UploadModelOperationMetadata> UploadModel(UploadModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Uploads a Model artifact into Vertex AI.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UploadModelResponse, UploadModelOperationMetadata>> UploadModelAsync(UploadModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Uploads a Model artifact into Vertex AI.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UploadModelResponse, UploadModelOperationMetadata>> UploadModelAsync(UploadModelRequest request, st::CancellationToken cancellationToken) =>
            UploadModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UploadModel</c>.</summary>
        public virtual lro::OperationsClient UploadModelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UploadModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<UploadModelResponse, UploadModelOperationMetadata> PollOnceUploadModel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<UploadModelResponse, UploadModelOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UploadModelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UploadModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<UploadModelResponse, UploadModelOperationMetadata>> PollOnceUploadModelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<UploadModelResponse, UploadModelOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UploadModelOperationsClient, callSettings);

        /// <summary>
        /// Uploads a Model artifact into Vertex AI.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location into which to upload the Model.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="model">
        /// Required. The Model to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UploadModelResponse, UploadModelOperationMetadata> UploadModel(string parent, Model model, gaxgrpc::CallSettings callSettings = null) =>
            UploadModel(new UploadModelRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Model = gax::GaxPreconditions.CheckNotNull(model, nameof(model)),
            }, callSettings);

        /// <summary>
        /// Uploads a Model artifact into Vertex AI.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location into which to upload the Model.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="model">
        /// Required. The Model to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UploadModelResponse, UploadModelOperationMetadata>> UploadModelAsync(string parent, Model model, gaxgrpc::CallSettings callSettings = null) =>
            UploadModelAsync(new UploadModelRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Model = gax::GaxPreconditions.CheckNotNull(model, nameof(model)),
            }, callSettings);

        /// <summary>
        /// Uploads a Model artifact into Vertex AI.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location into which to upload the Model.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="model">
        /// Required. The Model to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UploadModelResponse, UploadModelOperationMetadata>> UploadModelAsync(string parent, Model model, st::CancellationToken cancellationToken) =>
            UploadModelAsync(parent, model, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Uploads a Model artifact into Vertex AI.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location into which to upload the Model.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="model">
        /// Required. The Model to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UploadModelResponse, UploadModelOperationMetadata> UploadModel(gagr::LocationName parent, Model model, gaxgrpc::CallSettings callSettings = null) =>
            UploadModel(new UploadModelRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Model = gax::GaxPreconditions.CheckNotNull(model, nameof(model)),
            }, callSettings);

        /// <summary>
        /// Uploads a Model artifact into Vertex AI.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location into which to upload the Model.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="model">
        /// Required. The Model to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UploadModelResponse, UploadModelOperationMetadata>> UploadModelAsync(gagr::LocationName parent, Model model, gaxgrpc::CallSettings callSettings = null) =>
            UploadModelAsync(new UploadModelRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Model = gax::GaxPreconditions.CheckNotNull(model, nameof(model)),
            }, callSettings);

        /// <summary>
        /// Uploads a Model artifact into Vertex AI.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location into which to upload the Model.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="model">
        /// Required. The Model to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UploadModelResponse, UploadModelOperationMetadata>> UploadModelAsync(gagr::LocationName parent, Model model, st::CancellationToken cancellationToken) =>
            UploadModelAsync(parent, model, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Model GetModel(GetModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a Model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> GetModelAsync(GetModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a Model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> GetModelAsync(GetModelRequest request, st::CancellationToken cancellationToken) =>
            GetModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Model resource.
        /// Format: `projects/{project}/locations/{location}/models/{model}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Model GetModel(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetModel(new GetModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Model resource.
        /// Format: `projects/{project}/locations/{location}/models/{model}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> GetModelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetModelAsync(new GetModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Model resource.
        /// Format: `projects/{project}/locations/{location}/models/{model}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> GetModelAsync(string name, st::CancellationToken cancellationToken) =>
            GetModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Model resource.
        /// Format: `projects/{project}/locations/{location}/models/{model}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Model GetModel(ModelName name, gaxgrpc::CallSettings callSettings = null) =>
            GetModel(new GetModelRequest
            {
                ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Model resource.
        /// Format: `projects/{project}/locations/{location}/models/{model}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> GetModelAsync(ModelName name, gaxgrpc::CallSettings callSettings = null) =>
            GetModelAsync(new GetModelRequest
            {
                ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Model resource.
        /// Format: `projects/{project}/locations/{location}/models/{model}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> GetModelAsync(ModelName name, st::CancellationToken cancellationToken) =>
            GetModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Models in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Model"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListModelsResponse, Model> ListModels(ListModelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Models in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Model"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListModelsResponse, Model> ListModelsAsync(ListModelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Models in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the Models from.
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
        /// <returns>A pageable sequence of <see cref="Model"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListModelsResponse, Model> ListModels(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListModels(new ListModelsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Models in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the Models from.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Model"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListModelsResponse, Model> ListModelsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListModelsAsync(new ListModelsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Models in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the Models from.
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
        /// <returns>A pageable sequence of <see cref="Model"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListModelsResponse, Model> ListModels(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListModels(new ListModelsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Models in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the Models from.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Model"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListModelsResponse, Model> ListModelsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListModelsAsync(new ListModelsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Updates a Model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Model UpdateModel(UpdateModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a Model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> UpdateModelAsync(UpdateModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a Model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> UpdateModelAsync(UpdateModelRequest request, st::CancellationToken cancellationToken) =>
            UpdateModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a Model.
        /// </summary>
        /// <param name="model">
        /// Required. The Model which replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource.
        /// For the `FieldMask` definition, see [google.protobuf.FieldMask][google.protobuf.FieldMask].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Model UpdateModel(Model model, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateModel(new UpdateModelRequest
            {
                Model = gax::GaxPreconditions.CheckNotNull(model, nameof(model)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a Model.
        /// </summary>
        /// <param name="model">
        /// Required. The Model which replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource.
        /// For the `FieldMask` definition, see [google.protobuf.FieldMask][google.protobuf.FieldMask].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> UpdateModelAsync(Model model, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateModelAsync(new UpdateModelRequest
            {
                Model = gax::GaxPreconditions.CheckNotNull(model, nameof(model)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a Model.
        /// </summary>
        /// <param name="model">
        /// Required. The Model which replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource.
        /// For the `FieldMask` definition, see [google.protobuf.FieldMask][google.protobuf.FieldMask].
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> UpdateModelAsync(Model model, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateModelAsync(model, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Model.
        /// Note: Model can only be deleted if there are no DeployedModels created
        /// from it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteModel(DeleteModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Model.
        /// Note: Model can only be deleted if there are no DeployedModels created
        /// from it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteModelAsync(DeleteModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Model.
        /// Note: Model can only be deleted if there are no DeployedModels created
        /// from it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteModelAsync(DeleteModelRequest request, st::CancellationToken cancellationToken) =>
            DeleteModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteModel</c>.</summary>
        public virtual lro::OperationsClient DeleteModelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> PollOnceDeleteModel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteModelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> PollOnceDeleteModelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteModelOperationsClient, callSettings);

        /// <summary>
        /// Deletes a Model.
        /// Note: Model can only be deleted if there are no DeployedModels created
        /// from it.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Model resource to be deleted.
        /// Format: `projects/{project}/locations/{location}/models/{model}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteModel(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteModel(new DeleteModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Model.
        /// Note: Model can only be deleted if there are no DeployedModels created
        /// from it.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Model resource to be deleted.
        /// Format: `projects/{project}/locations/{location}/models/{model}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteModelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteModelAsync(new DeleteModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Model.
        /// Note: Model can only be deleted if there are no DeployedModels created
        /// from it.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Model resource to be deleted.
        /// Format: `projects/{project}/locations/{location}/models/{model}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteModelAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Model.
        /// Note: Model can only be deleted if there are no DeployedModels created
        /// from it.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Model resource to be deleted.
        /// Format: `projects/{project}/locations/{location}/models/{model}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteModel(ModelName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteModel(new DeleteModelRequest
            {
                ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Model.
        /// Note: Model can only be deleted if there are no DeployedModels created
        /// from it.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Model resource to be deleted.
        /// Format: `projects/{project}/locations/{location}/models/{model}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteModelAsync(ModelName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteModelAsync(new DeleteModelRequest
            {
                ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Model.
        /// Note: Model can only be deleted if there are no DeployedModels created
        /// from it.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Model resource to be deleted.
        /// Format: `projects/{project}/locations/{location}/models/{model}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteModelAsync(ModelName name, st::CancellationToken cancellationToken) =>
            DeleteModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports a trained, exportable, Model to a location specified by the
        /// user. A Model is considered to be exportable if it has at least one
        /// [supported export format][google.cloud.aiplatform.v1.Model.supported_export_formats].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportModelResponse, ExportModelOperationMetadata> ExportModel(ExportModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports a trained, exportable, Model to a location specified by the
        /// user. A Model is considered to be exportable if it has at least one
        /// [supported export format][google.cloud.aiplatform.v1.Model.supported_export_formats].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportModelResponse, ExportModelOperationMetadata>> ExportModelAsync(ExportModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports a trained, exportable, Model to a location specified by the
        /// user. A Model is considered to be exportable if it has at least one
        /// [supported export format][google.cloud.aiplatform.v1.Model.supported_export_formats].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportModelResponse, ExportModelOperationMetadata>> ExportModelAsync(ExportModelRequest request, st::CancellationToken cancellationToken) =>
            ExportModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ExportModel</c>.</summary>
        public virtual lro::OperationsClient ExportModelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ExportModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ExportModelResponse, ExportModelOperationMetadata> PollOnceExportModel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportModelResponse, ExportModelOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportModelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ExportModelResponse, ExportModelOperationMetadata>> PollOnceExportModelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportModelResponse, ExportModelOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportModelOperationsClient, callSettings);

        /// <summary>
        /// Exports a trained, exportable, Model to a location specified by the
        /// user. A Model is considered to be exportable if it has at least one
        /// [supported export format][google.cloud.aiplatform.v1.Model.supported_export_formats].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Model to export.
        /// Format: `projects/{project}/locations/{location}/models/{model}`
        /// </param>
        /// <param name="outputConfig">
        /// Required. The desired output location and configuration.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportModelResponse, ExportModelOperationMetadata> ExportModel(string name, ExportModelRequest.Types.OutputConfig outputConfig, gaxgrpc::CallSettings callSettings = null) =>
            ExportModel(new ExportModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                OutputConfig = gax::GaxPreconditions.CheckNotNull(outputConfig, nameof(outputConfig)),
            }, callSettings);

        /// <summary>
        /// Exports a trained, exportable, Model to a location specified by the
        /// user. A Model is considered to be exportable if it has at least one
        /// [supported export format][google.cloud.aiplatform.v1.Model.supported_export_formats].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Model to export.
        /// Format: `projects/{project}/locations/{location}/models/{model}`
        /// </param>
        /// <param name="outputConfig">
        /// Required. The desired output location and configuration.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportModelResponse, ExportModelOperationMetadata>> ExportModelAsync(string name, ExportModelRequest.Types.OutputConfig outputConfig, gaxgrpc::CallSettings callSettings = null) =>
            ExportModelAsync(new ExportModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                OutputConfig = gax::GaxPreconditions.CheckNotNull(outputConfig, nameof(outputConfig)),
            }, callSettings);

        /// <summary>
        /// Exports a trained, exportable, Model to a location specified by the
        /// user. A Model is considered to be exportable if it has at least one
        /// [supported export format][google.cloud.aiplatform.v1.Model.supported_export_formats].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Model to export.
        /// Format: `projects/{project}/locations/{location}/models/{model}`
        /// </param>
        /// <param name="outputConfig">
        /// Required. The desired output location and configuration.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportModelResponse, ExportModelOperationMetadata>> ExportModelAsync(string name, ExportModelRequest.Types.OutputConfig outputConfig, st::CancellationToken cancellationToken) =>
            ExportModelAsync(name, outputConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports a trained, exportable, Model to a location specified by the
        /// user. A Model is considered to be exportable if it has at least one
        /// [supported export format][google.cloud.aiplatform.v1.Model.supported_export_formats].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Model to export.
        /// Format: `projects/{project}/locations/{location}/models/{model}`
        /// </param>
        /// <param name="outputConfig">
        /// Required. The desired output location and configuration.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportModelResponse, ExportModelOperationMetadata> ExportModel(ModelName name, ExportModelRequest.Types.OutputConfig outputConfig, gaxgrpc::CallSettings callSettings = null) =>
            ExportModel(new ExportModelRequest
            {
                ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                OutputConfig = gax::GaxPreconditions.CheckNotNull(outputConfig, nameof(outputConfig)),
            }, callSettings);

        /// <summary>
        /// Exports a trained, exportable, Model to a location specified by the
        /// user. A Model is considered to be exportable if it has at least one
        /// [supported export format][google.cloud.aiplatform.v1.Model.supported_export_formats].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Model to export.
        /// Format: `projects/{project}/locations/{location}/models/{model}`
        /// </param>
        /// <param name="outputConfig">
        /// Required. The desired output location and configuration.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportModelResponse, ExportModelOperationMetadata>> ExportModelAsync(ModelName name, ExportModelRequest.Types.OutputConfig outputConfig, gaxgrpc::CallSettings callSettings = null) =>
            ExportModelAsync(new ExportModelRequest
            {
                ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                OutputConfig = gax::GaxPreconditions.CheckNotNull(outputConfig, nameof(outputConfig)),
            }, callSettings);

        /// <summary>
        /// Exports a trained, exportable, Model to a location specified by the
        /// user. A Model is considered to be exportable if it has at least one
        /// [supported export format][google.cloud.aiplatform.v1.Model.supported_export_formats].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Model to export.
        /// Format: `projects/{project}/locations/{location}/models/{model}`
        /// </param>
        /// <param name="outputConfig">
        /// Required. The desired output location and configuration.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportModelResponse, ExportModelOperationMetadata>> ExportModelAsync(ModelName name, ExportModelRequest.Types.OutputConfig outputConfig, st::CancellationToken cancellationToken) =>
            ExportModelAsync(name, outputConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a ModelEvaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ModelEvaluation GetModelEvaluation(GetModelEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a ModelEvaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelEvaluation> GetModelEvaluationAsync(GetModelEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a ModelEvaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelEvaluation> GetModelEvaluationAsync(GetModelEvaluationRequest request, st::CancellationToken cancellationToken) =>
            GetModelEvaluationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a ModelEvaluation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ModelEvaluation resource.
        /// Format:
        /// `projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ModelEvaluation GetModelEvaluation(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetModelEvaluation(new GetModelEvaluationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a ModelEvaluation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ModelEvaluation resource.
        /// Format:
        /// `projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelEvaluation> GetModelEvaluationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetModelEvaluationAsync(new GetModelEvaluationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a ModelEvaluation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ModelEvaluation resource.
        /// Format:
        /// `projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelEvaluation> GetModelEvaluationAsync(string name, st::CancellationToken cancellationToken) =>
            GetModelEvaluationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a ModelEvaluation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ModelEvaluation resource.
        /// Format:
        /// `projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ModelEvaluation GetModelEvaluation(ModelEvaluationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetModelEvaluation(new GetModelEvaluationRequest
            {
                ModelEvaluationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a ModelEvaluation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ModelEvaluation resource.
        /// Format:
        /// `projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelEvaluation> GetModelEvaluationAsync(ModelEvaluationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetModelEvaluationAsync(new GetModelEvaluationRequest
            {
                ModelEvaluationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a ModelEvaluation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ModelEvaluation resource.
        /// Format:
        /// `projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelEvaluation> GetModelEvaluationAsync(ModelEvaluationName name, st::CancellationToken cancellationToken) =>
            GetModelEvaluationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists ModelEvaluations in a Model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ModelEvaluation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListModelEvaluationsResponse, ModelEvaluation> ListModelEvaluations(ListModelEvaluationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ModelEvaluations in a Model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ModelEvaluation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListModelEvaluationsResponse, ModelEvaluation> ListModelEvaluationsAsync(ListModelEvaluationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ModelEvaluations in a Model.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Model to list the ModelEvaluations from.
        /// Format: `projects/{project}/locations/{location}/models/{model}`
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
        /// <returns>A pageable sequence of <see cref="ModelEvaluation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListModelEvaluationsResponse, ModelEvaluation> ListModelEvaluations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListModelEvaluations(new ListModelEvaluationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists ModelEvaluations in a Model.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Model to list the ModelEvaluations from.
        /// Format: `projects/{project}/locations/{location}/models/{model}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ModelEvaluation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListModelEvaluationsResponse, ModelEvaluation> ListModelEvaluationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListModelEvaluationsAsync(new ListModelEvaluationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists ModelEvaluations in a Model.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Model to list the ModelEvaluations from.
        /// Format: `projects/{project}/locations/{location}/models/{model}`
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
        /// <returns>A pageable sequence of <see cref="ModelEvaluation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListModelEvaluationsResponse, ModelEvaluation> ListModelEvaluations(ModelName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListModelEvaluations(new ListModelEvaluationsRequest
            {
                ParentAsModelName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists ModelEvaluations in a Model.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Model to list the ModelEvaluations from.
        /// Format: `projects/{project}/locations/{location}/models/{model}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ModelEvaluation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListModelEvaluationsResponse, ModelEvaluation> ListModelEvaluationsAsync(ModelName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListModelEvaluationsAsync(new ListModelEvaluationsRequest
            {
                ParentAsModelName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets a ModelEvaluationSlice.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ModelEvaluationSlice GetModelEvaluationSlice(GetModelEvaluationSliceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a ModelEvaluationSlice.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelEvaluationSlice> GetModelEvaluationSliceAsync(GetModelEvaluationSliceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a ModelEvaluationSlice.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelEvaluationSlice> GetModelEvaluationSliceAsync(GetModelEvaluationSliceRequest request, st::CancellationToken cancellationToken) =>
            GetModelEvaluationSliceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a ModelEvaluationSlice.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ModelEvaluationSlice resource.
        /// Format:
        /// `projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}/slices/{slice}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ModelEvaluationSlice GetModelEvaluationSlice(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetModelEvaluationSlice(new GetModelEvaluationSliceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a ModelEvaluationSlice.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ModelEvaluationSlice resource.
        /// Format:
        /// `projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}/slices/{slice}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelEvaluationSlice> GetModelEvaluationSliceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetModelEvaluationSliceAsync(new GetModelEvaluationSliceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a ModelEvaluationSlice.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ModelEvaluationSlice resource.
        /// Format:
        /// `projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}/slices/{slice}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelEvaluationSlice> GetModelEvaluationSliceAsync(string name, st::CancellationToken cancellationToken) =>
            GetModelEvaluationSliceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a ModelEvaluationSlice.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ModelEvaluationSlice resource.
        /// Format:
        /// `projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}/slices/{slice}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ModelEvaluationSlice GetModelEvaluationSlice(ModelEvaluationSliceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetModelEvaluationSlice(new GetModelEvaluationSliceRequest
            {
                ModelEvaluationSliceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a ModelEvaluationSlice.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ModelEvaluationSlice resource.
        /// Format:
        /// `projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}/slices/{slice}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelEvaluationSlice> GetModelEvaluationSliceAsync(ModelEvaluationSliceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetModelEvaluationSliceAsync(new GetModelEvaluationSliceRequest
            {
                ModelEvaluationSliceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a ModelEvaluationSlice.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ModelEvaluationSlice resource.
        /// Format:
        /// `projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}/slices/{slice}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelEvaluationSlice> GetModelEvaluationSliceAsync(ModelEvaluationSliceName name, st::CancellationToken cancellationToken) =>
            GetModelEvaluationSliceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists ModelEvaluationSlices in a ModelEvaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ModelEvaluationSlice"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListModelEvaluationSlicesResponse, ModelEvaluationSlice> ListModelEvaluationSlices(ListModelEvaluationSlicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ModelEvaluationSlices in a ModelEvaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ModelEvaluationSlice"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListModelEvaluationSlicesResponse, ModelEvaluationSlice> ListModelEvaluationSlicesAsync(ListModelEvaluationSlicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ModelEvaluationSlices in a ModelEvaluation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ModelEvaluation to list the ModelEvaluationSlices
        /// from. Format:
        /// `projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}`
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
        /// <returns>A pageable sequence of <see cref="ModelEvaluationSlice"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListModelEvaluationSlicesResponse, ModelEvaluationSlice> ListModelEvaluationSlices(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListModelEvaluationSlices(new ListModelEvaluationSlicesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists ModelEvaluationSlices in a ModelEvaluation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ModelEvaluation to list the ModelEvaluationSlices
        /// from. Format:
        /// `projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ModelEvaluationSlice"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListModelEvaluationSlicesResponse, ModelEvaluationSlice> ListModelEvaluationSlicesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListModelEvaluationSlicesAsync(new ListModelEvaluationSlicesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists ModelEvaluationSlices in a ModelEvaluation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ModelEvaluation to list the ModelEvaluationSlices
        /// from. Format:
        /// `projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}`
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
        /// <returns>A pageable sequence of <see cref="ModelEvaluationSlice"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListModelEvaluationSlicesResponse, ModelEvaluationSlice> ListModelEvaluationSlices(ModelEvaluationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListModelEvaluationSlices(new ListModelEvaluationSlicesRequest
            {
                ParentAsModelEvaluationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists ModelEvaluationSlices in a ModelEvaluation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ModelEvaluation to list the ModelEvaluationSlices
        /// from. Format:
        /// `projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ModelEvaluationSlice"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListModelEvaluationSlicesResponse, ModelEvaluationSlice> ListModelEvaluationSlicesAsync(ModelEvaluationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListModelEvaluationSlicesAsync(new ListModelEvaluationSlicesRequest
            {
                ParentAsModelEvaluationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);
    }

    /// <summary>ModelService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service for managing Vertex AI's machine learning Models.
    /// </remarks>
    public sealed partial class ModelServiceClientImpl : ModelServiceClient
    {
        private readonly gaxgrpc::ApiCall<UploadModelRequest, lro::Operation> _callUploadModel;

        private readonly gaxgrpc::ApiCall<GetModelRequest, Model> _callGetModel;

        private readonly gaxgrpc::ApiCall<ListModelsRequest, ListModelsResponse> _callListModels;

        private readonly gaxgrpc::ApiCall<UpdateModelRequest, Model> _callUpdateModel;

        private readonly gaxgrpc::ApiCall<DeleteModelRequest, lro::Operation> _callDeleteModel;

        private readonly gaxgrpc::ApiCall<ExportModelRequest, lro::Operation> _callExportModel;

        private readonly gaxgrpc::ApiCall<GetModelEvaluationRequest, ModelEvaluation> _callGetModelEvaluation;

        private readonly gaxgrpc::ApiCall<ListModelEvaluationsRequest, ListModelEvaluationsResponse> _callListModelEvaluations;

        private readonly gaxgrpc::ApiCall<GetModelEvaluationSliceRequest, ModelEvaluationSlice> _callGetModelEvaluationSlice;

        private readonly gaxgrpc::ApiCall<ListModelEvaluationSlicesRequest, ListModelEvaluationSlicesResponse> _callListModelEvaluationSlices;

        /// <summary>
        /// Constructs a client wrapper for the ModelService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ModelServiceSettings"/> used within this client.</param>
        public ModelServiceClientImpl(ModelService.ModelServiceClient grpcClient, ModelServiceSettings settings)
        {
            GrpcClient = grpcClient;
            ModelServiceSettings effectiveSettings = settings ?? ModelServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            UploadModelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UploadModelOperationsSettings);
            DeleteModelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteModelOperationsSettings);
            ExportModelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ExportModelOperationsSettings);
            _callUploadModel = clientHelper.BuildApiCall<UploadModelRequest, lro::Operation>(grpcClient.UploadModelAsync, grpcClient.UploadModel, effectiveSettings.UploadModelSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callUploadModel);
            Modify_UploadModelApiCall(ref _callUploadModel);
            _callGetModel = clientHelper.BuildApiCall<GetModelRequest, Model>(grpcClient.GetModelAsync, grpcClient.GetModel, effectiveSettings.GetModelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetModel);
            Modify_GetModelApiCall(ref _callGetModel);
            _callListModels = clientHelper.BuildApiCall<ListModelsRequest, ListModelsResponse>(grpcClient.ListModelsAsync, grpcClient.ListModels, effectiveSettings.ListModelsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListModels);
            Modify_ListModelsApiCall(ref _callListModels);
            _callUpdateModel = clientHelper.BuildApiCall<UpdateModelRequest, Model>(grpcClient.UpdateModelAsync, grpcClient.UpdateModel, effectiveSettings.UpdateModelSettings).WithGoogleRequestParam("model.name", request => request.Model?.Name);
            Modify_ApiCall(ref _callUpdateModel);
            Modify_UpdateModelApiCall(ref _callUpdateModel);
            _callDeleteModel = clientHelper.BuildApiCall<DeleteModelRequest, lro::Operation>(grpcClient.DeleteModelAsync, grpcClient.DeleteModel, effectiveSettings.DeleteModelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteModel);
            Modify_DeleteModelApiCall(ref _callDeleteModel);
            _callExportModel = clientHelper.BuildApiCall<ExportModelRequest, lro::Operation>(grpcClient.ExportModelAsync, grpcClient.ExportModel, effectiveSettings.ExportModelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callExportModel);
            Modify_ExportModelApiCall(ref _callExportModel);
            _callGetModelEvaluation = clientHelper.BuildApiCall<GetModelEvaluationRequest, ModelEvaluation>(grpcClient.GetModelEvaluationAsync, grpcClient.GetModelEvaluation, effectiveSettings.GetModelEvaluationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetModelEvaluation);
            Modify_GetModelEvaluationApiCall(ref _callGetModelEvaluation);
            _callListModelEvaluations = clientHelper.BuildApiCall<ListModelEvaluationsRequest, ListModelEvaluationsResponse>(grpcClient.ListModelEvaluationsAsync, grpcClient.ListModelEvaluations, effectiveSettings.ListModelEvaluationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListModelEvaluations);
            Modify_ListModelEvaluationsApiCall(ref _callListModelEvaluations);
            _callGetModelEvaluationSlice = clientHelper.BuildApiCall<GetModelEvaluationSliceRequest, ModelEvaluationSlice>(grpcClient.GetModelEvaluationSliceAsync, grpcClient.GetModelEvaluationSlice, effectiveSettings.GetModelEvaluationSliceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetModelEvaluationSlice);
            Modify_GetModelEvaluationSliceApiCall(ref _callGetModelEvaluationSlice);
            _callListModelEvaluationSlices = clientHelper.BuildApiCall<ListModelEvaluationSlicesRequest, ListModelEvaluationSlicesResponse>(grpcClient.ListModelEvaluationSlicesAsync, grpcClient.ListModelEvaluationSlices, effectiveSettings.ListModelEvaluationSlicesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListModelEvaluationSlices);
            Modify_ListModelEvaluationSlicesApiCall(ref _callListModelEvaluationSlices);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_UploadModelApiCall(ref gaxgrpc::ApiCall<UploadModelRequest, lro::Operation> call);

        partial void Modify_GetModelApiCall(ref gaxgrpc::ApiCall<GetModelRequest, Model> call);

        partial void Modify_ListModelsApiCall(ref gaxgrpc::ApiCall<ListModelsRequest, ListModelsResponse> call);

        partial void Modify_UpdateModelApiCall(ref gaxgrpc::ApiCall<UpdateModelRequest, Model> call);

        partial void Modify_DeleteModelApiCall(ref gaxgrpc::ApiCall<DeleteModelRequest, lro::Operation> call);

        partial void Modify_ExportModelApiCall(ref gaxgrpc::ApiCall<ExportModelRequest, lro::Operation> call);

        partial void Modify_GetModelEvaluationApiCall(ref gaxgrpc::ApiCall<GetModelEvaluationRequest, ModelEvaluation> call);

        partial void Modify_ListModelEvaluationsApiCall(ref gaxgrpc::ApiCall<ListModelEvaluationsRequest, ListModelEvaluationsResponse> call);

        partial void Modify_GetModelEvaluationSliceApiCall(ref gaxgrpc::ApiCall<GetModelEvaluationSliceRequest, ModelEvaluationSlice> call);

        partial void Modify_ListModelEvaluationSlicesApiCall(ref gaxgrpc::ApiCall<ListModelEvaluationSlicesRequest, ListModelEvaluationSlicesResponse> call);

        partial void OnConstruction(ModelService.ModelServiceClient grpcClient, ModelServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ModelService client</summary>
        public override ModelService.ModelServiceClient GrpcClient { get; }

        partial void Modify_UploadModelRequest(ref UploadModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetModelRequest(ref GetModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListModelsRequest(ref ListModelsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateModelRequest(ref UpdateModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteModelRequest(ref DeleteModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportModelRequest(ref ExportModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetModelEvaluationRequest(ref GetModelEvaluationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListModelEvaluationsRequest(ref ListModelEvaluationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetModelEvaluationSliceRequest(ref GetModelEvaluationSliceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListModelEvaluationSlicesRequest(ref ListModelEvaluationSlicesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>UploadModel</c>.</summary>
        public override lro::OperationsClient UploadModelOperationsClient { get; }

        /// <summary>
        /// Uploads a Model artifact into Vertex AI.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<UploadModelResponse, UploadModelOperationMetadata> UploadModel(UploadModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UploadModelRequest(ref request, ref callSettings);
            return new lro::Operation<UploadModelResponse, UploadModelOperationMetadata>(_callUploadModel.Sync(request, callSettings), UploadModelOperationsClient);
        }

        /// <summary>
        /// Uploads a Model artifact into Vertex AI.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<UploadModelResponse, UploadModelOperationMetadata>> UploadModelAsync(UploadModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UploadModelRequest(ref request, ref callSettings);
            return new lro::Operation<UploadModelResponse, UploadModelOperationMetadata>(await _callUploadModel.Async(request, callSettings).ConfigureAwait(false), UploadModelOperationsClient);
        }

        /// <summary>
        /// Gets a Model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Model GetModel(GetModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetModelRequest(ref request, ref callSettings);
            return _callGetModel.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a Model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Model> GetModelAsync(GetModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetModelRequest(ref request, ref callSettings);
            return _callGetModel.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Models in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Model"/> resources.</returns>
        public override gax::PagedEnumerable<ListModelsResponse, Model> ListModels(ListModelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListModelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListModelsRequest, ListModelsResponse, Model>(_callListModels, request, callSettings);
        }

        /// <summary>
        /// Lists Models in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Model"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListModelsResponse, Model> ListModelsAsync(ListModelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListModelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListModelsRequest, ListModelsResponse, Model>(_callListModels, request, callSettings);
        }

        /// <summary>
        /// Updates a Model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Model UpdateModel(UpdateModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateModelRequest(ref request, ref callSettings);
            return _callUpdateModel.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a Model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Model> UpdateModelAsync(UpdateModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateModelRequest(ref request, ref callSettings);
            return _callUpdateModel.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteModel</c>.</summary>
        public override lro::OperationsClient DeleteModelOperationsClient { get; }

        /// <summary>
        /// Deletes a Model.
        /// Note: Model can only be deleted if there are no DeployedModels created
        /// from it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteModel(DeleteModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteModelRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(_callDeleteModel.Sync(request, callSettings), DeleteModelOperationsClient);
        }

        /// <summary>
        /// Deletes a Model.
        /// Note: Model can only be deleted if there are no DeployedModels created
        /// from it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteModelAsync(DeleteModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteModelRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(await _callDeleteModel.Async(request, callSettings).ConfigureAwait(false), DeleteModelOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ExportModel</c>.</summary>
        public override lro::OperationsClient ExportModelOperationsClient { get; }

        /// <summary>
        /// Exports a trained, exportable, Model to a location specified by the
        /// user. A Model is considered to be exportable if it has at least one
        /// [supported export format][google.cloud.aiplatform.v1.Model.supported_export_formats].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ExportModelResponse, ExportModelOperationMetadata> ExportModel(ExportModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportModelRequest(ref request, ref callSettings);
            return new lro::Operation<ExportModelResponse, ExportModelOperationMetadata>(_callExportModel.Sync(request, callSettings), ExportModelOperationsClient);
        }

        /// <summary>
        /// Exports a trained, exportable, Model to a location specified by the
        /// user. A Model is considered to be exportable if it has at least one
        /// [supported export format][google.cloud.aiplatform.v1.Model.supported_export_formats].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ExportModelResponse, ExportModelOperationMetadata>> ExportModelAsync(ExportModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportModelRequest(ref request, ref callSettings);
            return new lro::Operation<ExportModelResponse, ExportModelOperationMetadata>(await _callExportModel.Async(request, callSettings).ConfigureAwait(false), ExportModelOperationsClient);
        }

        /// <summary>
        /// Gets a ModelEvaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ModelEvaluation GetModelEvaluation(GetModelEvaluationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetModelEvaluationRequest(ref request, ref callSettings);
            return _callGetModelEvaluation.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a ModelEvaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ModelEvaluation> GetModelEvaluationAsync(GetModelEvaluationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetModelEvaluationRequest(ref request, ref callSettings);
            return _callGetModelEvaluation.Async(request, callSettings);
        }

        /// <summary>
        /// Lists ModelEvaluations in a Model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ModelEvaluation"/> resources.</returns>
        public override gax::PagedEnumerable<ListModelEvaluationsResponse, ModelEvaluation> ListModelEvaluations(ListModelEvaluationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListModelEvaluationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListModelEvaluationsRequest, ListModelEvaluationsResponse, ModelEvaluation>(_callListModelEvaluations, request, callSettings);
        }

        /// <summary>
        /// Lists ModelEvaluations in a Model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ModelEvaluation"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListModelEvaluationsResponse, ModelEvaluation> ListModelEvaluationsAsync(ListModelEvaluationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListModelEvaluationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListModelEvaluationsRequest, ListModelEvaluationsResponse, ModelEvaluation>(_callListModelEvaluations, request, callSettings);
        }

        /// <summary>
        /// Gets a ModelEvaluationSlice.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ModelEvaluationSlice GetModelEvaluationSlice(GetModelEvaluationSliceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetModelEvaluationSliceRequest(ref request, ref callSettings);
            return _callGetModelEvaluationSlice.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a ModelEvaluationSlice.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ModelEvaluationSlice> GetModelEvaluationSliceAsync(GetModelEvaluationSliceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetModelEvaluationSliceRequest(ref request, ref callSettings);
            return _callGetModelEvaluationSlice.Async(request, callSettings);
        }

        /// <summary>
        /// Lists ModelEvaluationSlices in a ModelEvaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ModelEvaluationSlice"/> resources.</returns>
        public override gax::PagedEnumerable<ListModelEvaluationSlicesResponse, ModelEvaluationSlice> ListModelEvaluationSlices(ListModelEvaluationSlicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListModelEvaluationSlicesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListModelEvaluationSlicesRequest, ListModelEvaluationSlicesResponse, ModelEvaluationSlice>(_callListModelEvaluationSlices, request, callSettings);
        }

        /// <summary>
        /// Lists ModelEvaluationSlices in a ModelEvaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ModelEvaluationSlice"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListModelEvaluationSlicesResponse, ModelEvaluationSlice> ListModelEvaluationSlicesAsync(ListModelEvaluationSlicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListModelEvaluationSlicesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListModelEvaluationSlicesRequest, ListModelEvaluationSlicesResponse, ModelEvaluationSlice>(_callListModelEvaluationSlices, request, callSettings);
        }
    }

    public partial class ListModelsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListModelEvaluationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListModelEvaluationSlicesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListModelsResponse : gaxgrpc::IPageResponse<Model>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Model> GetEnumerator() => Models.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListModelEvaluationsResponse : gaxgrpc::IPageResponse<ModelEvaluation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ModelEvaluation> GetEnumerator() => ModelEvaluations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListModelEvaluationSlicesResponse : gaxgrpc::IPageResponse<ModelEvaluationSlice>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ModelEvaluationSlice> GetEnumerator() => ModelEvaluationSlices.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ModelService
    {
        public partial class ModelServiceClient
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
