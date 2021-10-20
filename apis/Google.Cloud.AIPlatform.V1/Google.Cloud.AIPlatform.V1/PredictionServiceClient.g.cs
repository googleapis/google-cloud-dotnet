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

using ga = Google.Api;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.AIPlatform.V1
{
    /// <summary>Settings for <see cref="PredictionServiceClient"/> instances.</summary>
    public sealed partial class PredictionServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="PredictionServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="PredictionServiceSettings"/>.</returns>
        public static PredictionServiceSettings GetDefault() => new PredictionServiceSettings();

        /// <summary>Constructs a new <see cref="PredictionServiceSettings"/> object with default settings.</summary>
        public PredictionServiceSettings()
        {
        }

        private PredictionServiceSettings(PredictionServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            PredictSettings = existing.PredictSettings;
            RawPredictSettings = existing.RawPredictSettings;
            ExplainSettings = existing.ExplainSettings;
            OnCopy(existing);
        }

        partial void OnCopy(PredictionServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PredictionServiceClient.Predict</c> and <c>PredictionServiceClient.PredictAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PredictSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PredictionServiceClient.RawPredict</c> and <c>PredictionServiceClient.RawPredictAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RawPredictSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PredictionServiceClient.Explain</c> and <c>PredictionServiceClient.ExplainAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExplainSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="PredictionServiceSettings"/> object.</returns>
        public PredictionServiceSettings Clone() => new PredictionServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PredictionServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class PredictionServiceClientBuilder : gaxgrpc::ClientBuilderBase<PredictionServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public PredictionServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public PredictionServiceClientBuilder()
        {
            UseJwtAccessWithScopes = PredictionServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref PredictionServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<PredictionServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override PredictionServiceClient Build()
        {
            PredictionServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<PredictionServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<PredictionServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private PredictionServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PredictionServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<PredictionServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PredictionServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => PredictionServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => PredictionServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => PredictionServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>PredictionService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service for online predictions and explanations.
    /// </remarks>
    public abstract partial class PredictionServiceClient
    {
        /// <summary>
        /// The default endpoint for the PredictionService service, which is a host of "aiplatform.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "aiplatform.googleapis.com:443";

        /// <summary>The default PredictionService scopes.</summary>
        /// <remarks>
        /// The default PredictionService scopes are:
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
        /// Asynchronously creates a <see cref="PredictionServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="PredictionServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="PredictionServiceClient"/>.</returns>
        public static stt::Task<PredictionServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new PredictionServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="PredictionServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="PredictionServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="PredictionServiceClient"/>.</returns>
        public static PredictionServiceClient Create() => new PredictionServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="PredictionServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="PredictionServiceSettings"/>.</param>
        /// <returns>The created <see cref="PredictionServiceClient"/>.</returns>
        internal static PredictionServiceClient Create(grpccore::CallInvoker callInvoker, PredictionServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            PredictionService.PredictionServiceClient grpcClient = new PredictionService.PredictionServiceClient(callInvoker);
            return new PredictionServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC PredictionService client</summary>
        public virtual PredictionService.PredictionServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Perform an online prediction.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PredictResponse Predict(PredictRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Perform an online prediction.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PredictResponse> PredictAsync(PredictRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Perform an online prediction.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PredictResponse> PredictAsync(PredictRequest request, st::CancellationToken cancellationToken) =>
            PredictAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Perform an online prediction.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint requested to serve the prediction.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="instances">
        /// Required. The instances that are the input to the prediction call.
        /// A DeployedModel may have an upper limit on the number of instances it
        /// supports per request, and when it is exceeded the prediction call errors
        /// in case of AutoML Models, or, in case of customer created Models, the
        /// behaviour is as documented by that Model.
        /// The schema of any single instance may be specified via Endpoint's
        /// DeployedModels' [Model's][google.cloud.aiplatform.v1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1.Model.predict_schemata]
        /// [instance_schema_uri][google.cloud.aiplatform.v1.PredictSchemata.instance_schema_uri].
        /// </param>
        /// <param name="parameters">
        /// The parameters that govern the prediction. The schema of the parameters may
        /// be specified via Endpoint's DeployedModels' [Model's ][google.cloud.aiplatform.v1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1.Model.predict_schemata]
        /// [parameters_schema_uri][google.cloud.aiplatform.v1.PredictSchemata.parameters_schema_uri].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PredictResponse Predict(string endpoint, scg::IEnumerable<wkt::Value> instances, wkt::Value parameters, gaxgrpc::CallSettings callSettings = null) =>
            Predict(new PredictRequest
            {
                Endpoint = gax::GaxPreconditions.CheckNotNullOrEmpty(endpoint, nameof(endpoint)),
                Instances =
                {
                    gax::GaxPreconditions.CheckNotNull(instances, nameof(instances)),
                },
                Parameters = parameters,
            }, callSettings);

        /// <summary>
        /// Perform an online prediction.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint requested to serve the prediction.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="instances">
        /// Required. The instances that are the input to the prediction call.
        /// A DeployedModel may have an upper limit on the number of instances it
        /// supports per request, and when it is exceeded the prediction call errors
        /// in case of AutoML Models, or, in case of customer created Models, the
        /// behaviour is as documented by that Model.
        /// The schema of any single instance may be specified via Endpoint's
        /// DeployedModels' [Model's][google.cloud.aiplatform.v1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1.Model.predict_schemata]
        /// [instance_schema_uri][google.cloud.aiplatform.v1.PredictSchemata.instance_schema_uri].
        /// </param>
        /// <param name="parameters">
        /// The parameters that govern the prediction. The schema of the parameters may
        /// be specified via Endpoint's DeployedModels' [Model's ][google.cloud.aiplatform.v1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1.Model.predict_schemata]
        /// [parameters_schema_uri][google.cloud.aiplatform.v1.PredictSchemata.parameters_schema_uri].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PredictResponse> PredictAsync(string endpoint, scg::IEnumerable<wkt::Value> instances, wkt::Value parameters, gaxgrpc::CallSettings callSettings = null) =>
            PredictAsync(new PredictRequest
            {
                Endpoint = gax::GaxPreconditions.CheckNotNullOrEmpty(endpoint, nameof(endpoint)),
                Instances =
                {
                    gax::GaxPreconditions.CheckNotNull(instances, nameof(instances)),
                },
                Parameters = parameters,
            }, callSettings);

        /// <summary>
        /// Perform an online prediction.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint requested to serve the prediction.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="instances">
        /// Required. The instances that are the input to the prediction call.
        /// A DeployedModel may have an upper limit on the number of instances it
        /// supports per request, and when it is exceeded the prediction call errors
        /// in case of AutoML Models, or, in case of customer created Models, the
        /// behaviour is as documented by that Model.
        /// The schema of any single instance may be specified via Endpoint's
        /// DeployedModels' [Model's][google.cloud.aiplatform.v1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1.Model.predict_schemata]
        /// [instance_schema_uri][google.cloud.aiplatform.v1.PredictSchemata.instance_schema_uri].
        /// </param>
        /// <param name="parameters">
        /// The parameters that govern the prediction. The schema of the parameters may
        /// be specified via Endpoint's DeployedModels' [Model's ][google.cloud.aiplatform.v1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1.Model.predict_schemata]
        /// [parameters_schema_uri][google.cloud.aiplatform.v1.PredictSchemata.parameters_schema_uri].
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PredictResponse> PredictAsync(string endpoint, scg::IEnumerable<wkt::Value> instances, wkt::Value parameters, st::CancellationToken cancellationToken) =>
            PredictAsync(endpoint, instances, parameters, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Perform an online prediction.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint requested to serve the prediction.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="instances">
        /// Required. The instances that are the input to the prediction call.
        /// A DeployedModel may have an upper limit on the number of instances it
        /// supports per request, and when it is exceeded the prediction call errors
        /// in case of AutoML Models, or, in case of customer created Models, the
        /// behaviour is as documented by that Model.
        /// The schema of any single instance may be specified via Endpoint's
        /// DeployedModels' [Model's][google.cloud.aiplatform.v1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1.Model.predict_schemata]
        /// [instance_schema_uri][google.cloud.aiplatform.v1.PredictSchemata.instance_schema_uri].
        /// </param>
        /// <param name="parameters">
        /// The parameters that govern the prediction. The schema of the parameters may
        /// be specified via Endpoint's DeployedModels' [Model's ][google.cloud.aiplatform.v1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1.Model.predict_schemata]
        /// [parameters_schema_uri][google.cloud.aiplatform.v1.PredictSchemata.parameters_schema_uri].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PredictResponse Predict(EndpointName endpoint, scg::IEnumerable<wkt::Value> instances, wkt::Value parameters, gaxgrpc::CallSettings callSettings = null) =>
            Predict(new PredictRequest
            {
                EndpointAsEndpointName = gax::GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint)),
                Instances =
                {
                    gax::GaxPreconditions.CheckNotNull(instances, nameof(instances)),
                },
                Parameters = parameters,
            }, callSettings);

        /// <summary>
        /// Perform an online prediction.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint requested to serve the prediction.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="instances">
        /// Required. The instances that are the input to the prediction call.
        /// A DeployedModel may have an upper limit on the number of instances it
        /// supports per request, and when it is exceeded the prediction call errors
        /// in case of AutoML Models, or, in case of customer created Models, the
        /// behaviour is as documented by that Model.
        /// The schema of any single instance may be specified via Endpoint's
        /// DeployedModels' [Model's][google.cloud.aiplatform.v1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1.Model.predict_schemata]
        /// [instance_schema_uri][google.cloud.aiplatform.v1.PredictSchemata.instance_schema_uri].
        /// </param>
        /// <param name="parameters">
        /// The parameters that govern the prediction. The schema of the parameters may
        /// be specified via Endpoint's DeployedModels' [Model's ][google.cloud.aiplatform.v1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1.Model.predict_schemata]
        /// [parameters_schema_uri][google.cloud.aiplatform.v1.PredictSchemata.parameters_schema_uri].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PredictResponse> PredictAsync(EndpointName endpoint, scg::IEnumerable<wkt::Value> instances, wkt::Value parameters, gaxgrpc::CallSettings callSettings = null) =>
            PredictAsync(new PredictRequest
            {
                EndpointAsEndpointName = gax::GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint)),
                Instances =
                {
                    gax::GaxPreconditions.CheckNotNull(instances, nameof(instances)),
                },
                Parameters = parameters,
            }, callSettings);

        /// <summary>
        /// Perform an online prediction.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint requested to serve the prediction.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="instances">
        /// Required. The instances that are the input to the prediction call.
        /// A DeployedModel may have an upper limit on the number of instances it
        /// supports per request, and when it is exceeded the prediction call errors
        /// in case of AutoML Models, or, in case of customer created Models, the
        /// behaviour is as documented by that Model.
        /// The schema of any single instance may be specified via Endpoint's
        /// DeployedModels' [Model's][google.cloud.aiplatform.v1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1.Model.predict_schemata]
        /// [instance_schema_uri][google.cloud.aiplatform.v1.PredictSchemata.instance_schema_uri].
        /// </param>
        /// <param name="parameters">
        /// The parameters that govern the prediction. The schema of the parameters may
        /// be specified via Endpoint's DeployedModels' [Model's ][google.cloud.aiplatform.v1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1.Model.predict_schemata]
        /// [parameters_schema_uri][google.cloud.aiplatform.v1.PredictSchemata.parameters_schema_uri].
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PredictResponse> PredictAsync(EndpointName endpoint, scg::IEnumerable<wkt::Value> instances, wkt::Value parameters, st::CancellationToken cancellationToken) =>
            PredictAsync(endpoint, instances, parameters, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Perform an online prediction with an arbitrary HTTP payload.
        /// 
        /// The response includes the following HTTP headers:
        /// 
        /// * `X-Vertex-AI-Endpoint-Id`: ID of the [Endpoint][google.cloud.aiplatform.v1.Endpoint] that served this
        /// prediction.
        /// 
        /// * `X-Vertex-AI-Deployed-Model-Id`: ID of the Endpoint's [DeployedModel][google.cloud.aiplatform.v1.DeployedModel]
        /// that served this prediction.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ga::HttpBody RawPredict(RawPredictRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Perform an online prediction with an arbitrary HTTP payload.
        /// 
        /// The response includes the following HTTP headers:
        /// 
        /// * `X-Vertex-AI-Endpoint-Id`: ID of the [Endpoint][google.cloud.aiplatform.v1.Endpoint] that served this
        /// prediction.
        /// 
        /// * `X-Vertex-AI-Deployed-Model-Id`: ID of the Endpoint's [DeployedModel][google.cloud.aiplatform.v1.DeployedModel]
        /// that served this prediction.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::HttpBody> RawPredictAsync(RawPredictRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Perform an online prediction with an arbitrary HTTP payload.
        /// 
        /// The response includes the following HTTP headers:
        /// 
        /// * `X-Vertex-AI-Endpoint-Id`: ID of the [Endpoint][google.cloud.aiplatform.v1.Endpoint] that served this
        /// prediction.
        /// 
        /// * `X-Vertex-AI-Deployed-Model-Id`: ID of the Endpoint's [DeployedModel][google.cloud.aiplatform.v1.DeployedModel]
        /// that served this prediction.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::HttpBody> RawPredictAsync(RawPredictRequest request, st::CancellationToken cancellationToken) =>
            RawPredictAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Perform an online prediction with an arbitrary HTTP payload.
        /// 
        /// The response includes the following HTTP headers:
        /// 
        /// * `X-Vertex-AI-Endpoint-Id`: ID of the [Endpoint][google.cloud.aiplatform.v1.Endpoint] that served this
        /// prediction.
        /// 
        /// * `X-Vertex-AI-Deployed-Model-Id`: ID of the Endpoint's [DeployedModel][google.cloud.aiplatform.v1.DeployedModel]
        /// that served this prediction.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint requested to serve the prediction.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="httpBody">
        /// The prediction input. Supports HTTP headers and arbitrary data payload.
        /// 
        /// A [DeployedModel][google.cloud.aiplatform.v1.DeployedModel] may have an upper limit on the number of instances it
        /// supports per request. When this limit it is exceeded for an AutoML model,
        /// the [RawPredict][google.cloud.aiplatform.v1.PredictionService.RawPredict] method returns an error.
        /// When this limit is exceeded for a custom-trained model, the behavior varies
        /// depending on the model.
        /// 
        /// You can specify the schema for each instance in the
        /// [predict_schemata.instance_schema_uri][google.cloud.aiplatform.v1.PredictSchemata.instance_schema_uri]
        /// field when you create a [Model][google.cloud.aiplatform.v1.Model]. This schema applies when you deploy the
        /// `Model` as a `DeployedModel` to an [Endpoint][google.cloud.aiplatform.v1.Endpoint] and use the `RawPredict`
        /// method.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ga::HttpBody RawPredict(string endpoint, ga::HttpBody httpBody, gaxgrpc::CallSettings callSettings = null) =>
            RawPredict(new RawPredictRequest
            {
                Endpoint = gax::GaxPreconditions.CheckNotNullOrEmpty(endpoint, nameof(endpoint)),
                HttpBody = httpBody,
            }, callSettings);

        /// <summary>
        /// Perform an online prediction with an arbitrary HTTP payload.
        /// 
        /// The response includes the following HTTP headers:
        /// 
        /// * `X-Vertex-AI-Endpoint-Id`: ID of the [Endpoint][google.cloud.aiplatform.v1.Endpoint] that served this
        /// prediction.
        /// 
        /// * `X-Vertex-AI-Deployed-Model-Id`: ID of the Endpoint's [DeployedModel][google.cloud.aiplatform.v1.DeployedModel]
        /// that served this prediction.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint requested to serve the prediction.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="httpBody">
        /// The prediction input. Supports HTTP headers and arbitrary data payload.
        /// 
        /// A [DeployedModel][google.cloud.aiplatform.v1.DeployedModel] may have an upper limit on the number of instances it
        /// supports per request. When this limit it is exceeded for an AutoML model,
        /// the [RawPredict][google.cloud.aiplatform.v1.PredictionService.RawPredict] method returns an error.
        /// When this limit is exceeded for a custom-trained model, the behavior varies
        /// depending on the model.
        /// 
        /// You can specify the schema for each instance in the
        /// [predict_schemata.instance_schema_uri][google.cloud.aiplatform.v1.PredictSchemata.instance_schema_uri]
        /// field when you create a [Model][google.cloud.aiplatform.v1.Model]. This schema applies when you deploy the
        /// `Model` as a `DeployedModel` to an [Endpoint][google.cloud.aiplatform.v1.Endpoint] and use the `RawPredict`
        /// method.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::HttpBody> RawPredictAsync(string endpoint, ga::HttpBody httpBody, gaxgrpc::CallSettings callSettings = null) =>
            RawPredictAsync(new RawPredictRequest
            {
                Endpoint = gax::GaxPreconditions.CheckNotNullOrEmpty(endpoint, nameof(endpoint)),
                HttpBody = httpBody,
            }, callSettings);

        /// <summary>
        /// Perform an online prediction with an arbitrary HTTP payload.
        /// 
        /// The response includes the following HTTP headers:
        /// 
        /// * `X-Vertex-AI-Endpoint-Id`: ID of the [Endpoint][google.cloud.aiplatform.v1.Endpoint] that served this
        /// prediction.
        /// 
        /// * `X-Vertex-AI-Deployed-Model-Id`: ID of the Endpoint's [DeployedModel][google.cloud.aiplatform.v1.DeployedModel]
        /// that served this prediction.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint requested to serve the prediction.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="httpBody">
        /// The prediction input. Supports HTTP headers and arbitrary data payload.
        /// 
        /// A [DeployedModel][google.cloud.aiplatform.v1.DeployedModel] may have an upper limit on the number of instances it
        /// supports per request. When this limit it is exceeded for an AutoML model,
        /// the [RawPredict][google.cloud.aiplatform.v1.PredictionService.RawPredict] method returns an error.
        /// When this limit is exceeded for a custom-trained model, the behavior varies
        /// depending on the model.
        /// 
        /// You can specify the schema for each instance in the
        /// [predict_schemata.instance_schema_uri][google.cloud.aiplatform.v1.PredictSchemata.instance_schema_uri]
        /// field when you create a [Model][google.cloud.aiplatform.v1.Model]. This schema applies when you deploy the
        /// `Model` as a `DeployedModel` to an [Endpoint][google.cloud.aiplatform.v1.Endpoint] and use the `RawPredict`
        /// method.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::HttpBody> RawPredictAsync(string endpoint, ga::HttpBody httpBody, st::CancellationToken cancellationToken) =>
            RawPredictAsync(endpoint, httpBody, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Perform an online prediction with an arbitrary HTTP payload.
        /// 
        /// The response includes the following HTTP headers:
        /// 
        /// * `X-Vertex-AI-Endpoint-Id`: ID of the [Endpoint][google.cloud.aiplatform.v1.Endpoint] that served this
        /// prediction.
        /// 
        /// * `X-Vertex-AI-Deployed-Model-Id`: ID of the Endpoint's [DeployedModel][google.cloud.aiplatform.v1.DeployedModel]
        /// that served this prediction.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint requested to serve the prediction.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="httpBody">
        /// The prediction input. Supports HTTP headers and arbitrary data payload.
        /// 
        /// A [DeployedModel][google.cloud.aiplatform.v1.DeployedModel] may have an upper limit on the number of instances it
        /// supports per request. When this limit it is exceeded for an AutoML model,
        /// the [RawPredict][google.cloud.aiplatform.v1.PredictionService.RawPredict] method returns an error.
        /// When this limit is exceeded for a custom-trained model, the behavior varies
        /// depending on the model.
        /// 
        /// You can specify the schema for each instance in the
        /// [predict_schemata.instance_schema_uri][google.cloud.aiplatform.v1.PredictSchemata.instance_schema_uri]
        /// field when you create a [Model][google.cloud.aiplatform.v1.Model]. This schema applies when you deploy the
        /// `Model` as a `DeployedModel` to an [Endpoint][google.cloud.aiplatform.v1.Endpoint] and use the `RawPredict`
        /// method.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ga::HttpBody RawPredict(EndpointName endpoint, ga::HttpBody httpBody, gaxgrpc::CallSettings callSettings = null) =>
            RawPredict(new RawPredictRequest
            {
                EndpointAsEndpointName = gax::GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint)),
                HttpBody = httpBody,
            }, callSettings);

        /// <summary>
        /// Perform an online prediction with an arbitrary HTTP payload.
        /// 
        /// The response includes the following HTTP headers:
        /// 
        /// * `X-Vertex-AI-Endpoint-Id`: ID of the [Endpoint][google.cloud.aiplatform.v1.Endpoint] that served this
        /// prediction.
        /// 
        /// * `X-Vertex-AI-Deployed-Model-Id`: ID of the Endpoint's [DeployedModel][google.cloud.aiplatform.v1.DeployedModel]
        /// that served this prediction.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint requested to serve the prediction.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="httpBody">
        /// The prediction input. Supports HTTP headers and arbitrary data payload.
        /// 
        /// A [DeployedModel][google.cloud.aiplatform.v1.DeployedModel] may have an upper limit on the number of instances it
        /// supports per request. When this limit it is exceeded for an AutoML model,
        /// the [RawPredict][google.cloud.aiplatform.v1.PredictionService.RawPredict] method returns an error.
        /// When this limit is exceeded for a custom-trained model, the behavior varies
        /// depending on the model.
        /// 
        /// You can specify the schema for each instance in the
        /// [predict_schemata.instance_schema_uri][google.cloud.aiplatform.v1.PredictSchemata.instance_schema_uri]
        /// field when you create a [Model][google.cloud.aiplatform.v1.Model]. This schema applies when you deploy the
        /// `Model` as a `DeployedModel` to an [Endpoint][google.cloud.aiplatform.v1.Endpoint] and use the `RawPredict`
        /// method.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::HttpBody> RawPredictAsync(EndpointName endpoint, ga::HttpBody httpBody, gaxgrpc::CallSettings callSettings = null) =>
            RawPredictAsync(new RawPredictRequest
            {
                EndpointAsEndpointName = gax::GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint)),
                HttpBody = httpBody,
            }, callSettings);

        /// <summary>
        /// Perform an online prediction with an arbitrary HTTP payload.
        /// 
        /// The response includes the following HTTP headers:
        /// 
        /// * `X-Vertex-AI-Endpoint-Id`: ID of the [Endpoint][google.cloud.aiplatform.v1.Endpoint] that served this
        /// prediction.
        /// 
        /// * `X-Vertex-AI-Deployed-Model-Id`: ID of the Endpoint's [DeployedModel][google.cloud.aiplatform.v1.DeployedModel]
        /// that served this prediction.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint requested to serve the prediction.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="httpBody">
        /// The prediction input. Supports HTTP headers and arbitrary data payload.
        /// 
        /// A [DeployedModel][google.cloud.aiplatform.v1.DeployedModel] may have an upper limit on the number of instances it
        /// supports per request. When this limit it is exceeded for an AutoML model,
        /// the [RawPredict][google.cloud.aiplatform.v1.PredictionService.RawPredict] method returns an error.
        /// When this limit is exceeded for a custom-trained model, the behavior varies
        /// depending on the model.
        /// 
        /// You can specify the schema for each instance in the
        /// [predict_schemata.instance_schema_uri][google.cloud.aiplatform.v1.PredictSchemata.instance_schema_uri]
        /// field when you create a [Model][google.cloud.aiplatform.v1.Model]. This schema applies when you deploy the
        /// `Model` as a `DeployedModel` to an [Endpoint][google.cloud.aiplatform.v1.Endpoint] and use the `RawPredict`
        /// method.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::HttpBody> RawPredictAsync(EndpointName endpoint, ga::HttpBody httpBody, st::CancellationToken cancellationToken) =>
            RawPredictAsync(endpoint, httpBody, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Perform an online explanation.
        /// 
        /// If [deployed_model_id][google.cloud.aiplatform.v1.ExplainRequest.deployed_model_id] is specified,
        /// the corresponding DeployModel must have
        /// [explanation_spec][google.cloud.aiplatform.v1.DeployedModel.explanation_spec]
        /// populated. If [deployed_model_id][google.cloud.aiplatform.v1.ExplainRequest.deployed_model_id]
        /// is not specified, all DeployedModels must have
        /// [explanation_spec][google.cloud.aiplatform.v1.DeployedModel.explanation_spec]
        /// populated. Only deployed AutoML tabular Models have
        /// explanation_spec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExplainResponse Explain(ExplainRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Perform an online explanation.
        /// 
        /// If [deployed_model_id][google.cloud.aiplatform.v1.ExplainRequest.deployed_model_id] is specified,
        /// the corresponding DeployModel must have
        /// [explanation_spec][google.cloud.aiplatform.v1.DeployedModel.explanation_spec]
        /// populated. If [deployed_model_id][google.cloud.aiplatform.v1.ExplainRequest.deployed_model_id]
        /// is not specified, all DeployedModels must have
        /// [explanation_spec][google.cloud.aiplatform.v1.DeployedModel.explanation_spec]
        /// populated. Only deployed AutoML tabular Models have
        /// explanation_spec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExplainResponse> ExplainAsync(ExplainRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Perform an online explanation.
        /// 
        /// If [deployed_model_id][google.cloud.aiplatform.v1.ExplainRequest.deployed_model_id] is specified,
        /// the corresponding DeployModel must have
        /// [explanation_spec][google.cloud.aiplatform.v1.DeployedModel.explanation_spec]
        /// populated. If [deployed_model_id][google.cloud.aiplatform.v1.ExplainRequest.deployed_model_id]
        /// is not specified, all DeployedModels must have
        /// [explanation_spec][google.cloud.aiplatform.v1.DeployedModel.explanation_spec]
        /// populated. Only deployed AutoML tabular Models have
        /// explanation_spec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExplainResponse> ExplainAsync(ExplainRequest request, st::CancellationToken cancellationToken) =>
            ExplainAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Perform an online explanation.
        /// 
        /// If [deployed_model_id][google.cloud.aiplatform.v1.ExplainRequest.deployed_model_id] is specified,
        /// the corresponding DeployModel must have
        /// [explanation_spec][google.cloud.aiplatform.v1.DeployedModel.explanation_spec]
        /// populated. If [deployed_model_id][google.cloud.aiplatform.v1.ExplainRequest.deployed_model_id]
        /// is not specified, all DeployedModels must have
        /// [explanation_spec][google.cloud.aiplatform.v1.DeployedModel.explanation_spec]
        /// populated. Only deployed AutoML tabular Models have
        /// explanation_spec.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint requested to serve the explanation.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="instances">
        /// Required. The instances that are the input to the explanation call.
        /// A DeployedModel may have an upper limit on the number of instances it
        /// supports per request, and when it is exceeded the explanation call errors
        /// in case of AutoML Models, or, in case of customer created Models, the
        /// behaviour is as documented by that Model.
        /// The schema of any single instance may be specified via Endpoint's
        /// DeployedModels' [Model's][google.cloud.aiplatform.v1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1.Model.predict_schemata]
        /// [instance_schema_uri][google.cloud.aiplatform.v1.PredictSchemata.instance_schema_uri].
        /// </param>
        /// <param name="parameters">
        /// The parameters that govern the prediction. The schema of the parameters may
        /// be specified via Endpoint's DeployedModels' [Model's ][google.cloud.aiplatform.v1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1.Model.predict_schemata]
        /// [parameters_schema_uri][google.cloud.aiplatform.v1.PredictSchemata.parameters_schema_uri].
        /// </param>
        /// <param name="deployedModelId">
        /// If specified, this ExplainRequest will be served by the chosen
        /// DeployedModel, overriding [Endpoint.traffic_split][google.cloud.aiplatform.v1.Endpoint.traffic_split].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExplainResponse Explain(string endpoint, scg::IEnumerable<wkt::Value> instances, wkt::Value parameters, string deployedModelId, gaxgrpc::CallSettings callSettings = null) =>
            Explain(new ExplainRequest
            {
                Endpoint = gax::GaxPreconditions.CheckNotNullOrEmpty(endpoint, nameof(endpoint)),
                Instances =
                {
                    gax::GaxPreconditions.CheckNotNull(instances, nameof(instances)),
                },
                Parameters = parameters,
                DeployedModelId = deployedModelId ?? "",
            }, callSettings);

        /// <summary>
        /// Perform an online explanation.
        /// 
        /// If [deployed_model_id][google.cloud.aiplatform.v1.ExplainRequest.deployed_model_id] is specified,
        /// the corresponding DeployModel must have
        /// [explanation_spec][google.cloud.aiplatform.v1.DeployedModel.explanation_spec]
        /// populated. If [deployed_model_id][google.cloud.aiplatform.v1.ExplainRequest.deployed_model_id]
        /// is not specified, all DeployedModels must have
        /// [explanation_spec][google.cloud.aiplatform.v1.DeployedModel.explanation_spec]
        /// populated. Only deployed AutoML tabular Models have
        /// explanation_spec.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint requested to serve the explanation.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="instances">
        /// Required. The instances that are the input to the explanation call.
        /// A DeployedModel may have an upper limit on the number of instances it
        /// supports per request, and when it is exceeded the explanation call errors
        /// in case of AutoML Models, or, in case of customer created Models, the
        /// behaviour is as documented by that Model.
        /// The schema of any single instance may be specified via Endpoint's
        /// DeployedModels' [Model's][google.cloud.aiplatform.v1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1.Model.predict_schemata]
        /// [instance_schema_uri][google.cloud.aiplatform.v1.PredictSchemata.instance_schema_uri].
        /// </param>
        /// <param name="parameters">
        /// The parameters that govern the prediction. The schema of the parameters may
        /// be specified via Endpoint's DeployedModels' [Model's ][google.cloud.aiplatform.v1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1.Model.predict_schemata]
        /// [parameters_schema_uri][google.cloud.aiplatform.v1.PredictSchemata.parameters_schema_uri].
        /// </param>
        /// <param name="deployedModelId">
        /// If specified, this ExplainRequest will be served by the chosen
        /// DeployedModel, overriding [Endpoint.traffic_split][google.cloud.aiplatform.v1.Endpoint.traffic_split].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExplainResponse> ExplainAsync(string endpoint, scg::IEnumerable<wkt::Value> instances, wkt::Value parameters, string deployedModelId, gaxgrpc::CallSettings callSettings = null) =>
            ExplainAsync(new ExplainRequest
            {
                Endpoint = gax::GaxPreconditions.CheckNotNullOrEmpty(endpoint, nameof(endpoint)),
                Instances =
                {
                    gax::GaxPreconditions.CheckNotNull(instances, nameof(instances)),
                },
                Parameters = parameters,
                DeployedModelId = deployedModelId ?? "",
            }, callSettings);

        /// <summary>
        /// Perform an online explanation.
        /// 
        /// If [deployed_model_id][google.cloud.aiplatform.v1.ExplainRequest.deployed_model_id] is specified,
        /// the corresponding DeployModel must have
        /// [explanation_spec][google.cloud.aiplatform.v1.DeployedModel.explanation_spec]
        /// populated. If [deployed_model_id][google.cloud.aiplatform.v1.ExplainRequest.deployed_model_id]
        /// is not specified, all DeployedModels must have
        /// [explanation_spec][google.cloud.aiplatform.v1.DeployedModel.explanation_spec]
        /// populated. Only deployed AutoML tabular Models have
        /// explanation_spec.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint requested to serve the explanation.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="instances">
        /// Required. The instances that are the input to the explanation call.
        /// A DeployedModel may have an upper limit on the number of instances it
        /// supports per request, and when it is exceeded the explanation call errors
        /// in case of AutoML Models, or, in case of customer created Models, the
        /// behaviour is as documented by that Model.
        /// The schema of any single instance may be specified via Endpoint's
        /// DeployedModels' [Model's][google.cloud.aiplatform.v1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1.Model.predict_schemata]
        /// [instance_schema_uri][google.cloud.aiplatform.v1.PredictSchemata.instance_schema_uri].
        /// </param>
        /// <param name="parameters">
        /// The parameters that govern the prediction. The schema of the parameters may
        /// be specified via Endpoint's DeployedModels' [Model's ][google.cloud.aiplatform.v1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1.Model.predict_schemata]
        /// [parameters_schema_uri][google.cloud.aiplatform.v1.PredictSchemata.parameters_schema_uri].
        /// </param>
        /// <param name="deployedModelId">
        /// If specified, this ExplainRequest will be served by the chosen
        /// DeployedModel, overriding [Endpoint.traffic_split][google.cloud.aiplatform.v1.Endpoint.traffic_split].
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExplainResponse> ExplainAsync(string endpoint, scg::IEnumerable<wkt::Value> instances, wkt::Value parameters, string deployedModelId, st::CancellationToken cancellationToken) =>
            ExplainAsync(endpoint, instances, parameters, deployedModelId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Perform an online explanation.
        /// 
        /// If [deployed_model_id][google.cloud.aiplatform.v1.ExplainRequest.deployed_model_id] is specified,
        /// the corresponding DeployModel must have
        /// [explanation_spec][google.cloud.aiplatform.v1.DeployedModel.explanation_spec]
        /// populated. If [deployed_model_id][google.cloud.aiplatform.v1.ExplainRequest.deployed_model_id]
        /// is not specified, all DeployedModels must have
        /// [explanation_spec][google.cloud.aiplatform.v1.DeployedModel.explanation_spec]
        /// populated. Only deployed AutoML tabular Models have
        /// explanation_spec.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint requested to serve the explanation.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="instances">
        /// Required. The instances that are the input to the explanation call.
        /// A DeployedModel may have an upper limit on the number of instances it
        /// supports per request, and when it is exceeded the explanation call errors
        /// in case of AutoML Models, or, in case of customer created Models, the
        /// behaviour is as documented by that Model.
        /// The schema of any single instance may be specified via Endpoint's
        /// DeployedModels' [Model's][google.cloud.aiplatform.v1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1.Model.predict_schemata]
        /// [instance_schema_uri][google.cloud.aiplatform.v1.PredictSchemata.instance_schema_uri].
        /// </param>
        /// <param name="parameters">
        /// The parameters that govern the prediction. The schema of the parameters may
        /// be specified via Endpoint's DeployedModels' [Model's ][google.cloud.aiplatform.v1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1.Model.predict_schemata]
        /// [parameters_schema_uri][google.cloud.aiplatform.v1.PredictSchemata.parameters_schema_uri].
        /// </param>
        /// <param name="deployedModelId">
        /// If specified, this ExplainRequest will be served by the chosen
        /// DeployedModel, overriding [Endpoint.traffic_split][google.cloud.aiplatform.v1.Endpoint.traffic_split].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExplainResponse Explain(EndpointName endpoint, scg::IEnumerable<wkt::Value> instances, wkt::Value parameters, string deployedModelId, gaxgrpc::CallSettings callSettings = null) =>
            Explain(new ExplainRequest
            {
                EndpointAsEndpointName = gax::GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint)),
                Instances =
                {
                    gax::GaxPreconditions.CheckNotNull(instances, nameof(instances)),
                },
                Parameters = parameters,
                DeployedModelId = deployedModelId ?? "",
            }, callSettings);

        /// <summary>
        /// Perform an online explanation.
        /// 
        /// If [deployed_model_id][google.cloud.aiplatform.v1.ExplainRequest.deployed_model_id] is specified,
        /// the corresponding DeployModel must have
        /// [explanation_spec][google.cloud.aiplatform.v1.DeployedModel.explanation_spec]
        /// populated. If [deployed_model_id][google.cloud.aiplatform.v1.ExplainRequest.deployed_model_id]
        /// is not specified, all DeployedModels must have
        /// [explanation_spec][google.cloud.aiplatform.v1.DeployedModel.explanation_spec]
        /// populated. Only deployed AutoML tabular Models have
        /// explanation_spec.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint requested to serve the explanation.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="instances">
        /// Required. The instances that are the input to the explanation call.
        /// A DeployedModel may have an upper limit on the number of instances it
        /// supports per request, and when it is exceeded the explanation call errors
        /// in case of AutoML Models, or, in case of customer created Models, the
        /// behaviour is as documented by that Model.
        /// The schema of any single instance may be specified via Endpoint's
        /// DeployedModels' [Model's][google.cloud.aiplatform.v1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1.Model.predict_schemata]
        /// [instance_schema_uri][google.cloud.aiplatform.v1.PredictSchemata.instance_schema_uri].
        /// </param>
        /// <param name="parameters">
        /// The parameters that govern the prediction. The schema of the parameters may
        /// be specified via Endpoint's DeployedModels' [Model's ][google.cloud.aiplatform.v1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1.Model.predict_schemata]
        /// [parameters_schema_uri][google.cloud.aiplatform.v1.PredictSchemata.parameters_schema_uri].
        /// </param>
        /// <param name="deployedModelId">
        /// If specified, this ExplainRequest will be served by the chosen
        /// DeployedModel, overriding [Endpoint.traffic_split][google.cloud.aiplatform.v1.Endpoint.traffic_split].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExplainResponse> ExplainAsync(EndpointName endpoint, scg::IEnumerable<wkt::Value> instances, wkt::Value parameters, string deployedModelId, gaxgrpc::CallSettings callSettings = null) =>
            ExplainAsync(new ExplainRequest
            {
                EndpointAsEndpointName = gax::GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint)),
                Instances =
                {
                    gax::GaxPreconditions.CheckNotNull(instances, nameof(instances)),
                },
                Parameters = parameters,
                DeployedModelId = deployedModelId ?? "",
            }, callSettings);

        /// <summary>
        /// Perform an online explanation.
        /// 
        /// If [deployed_model_id][google.cloud.aiplatform.v1.ExplainRequest.deployed_model_id] is specified,
        /// the corresponding DeployModel must have
        /// [explanation_spec][google.cloud.aiplatform.v1.DeployedModel.explanation_spec]
        /// populated. If [deployed_model_id][google.cloud.aiplatform.v1.ExplainRequest.deployed_model_id]
        /// is not specified, all DeployedModels must have
        /// [explanation_spec][google.cloud.aiplatform.v1.DeployedModel.explanation_spec]
        /// populated. Only deployed AutoML tabular Models have
        /// explanation_spec.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint requested to serve the explanation.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="instances">
        /// Required. The instances that are the input to the explanation call.
        /// A DeployedModel may have an upper limit on the number of instances it
        /// supports per request, and when it is exceeded the explanation call errors
        /// in case of AutoML Models, or, in case of customer created Models, the
        /// behaviour is as documented by that Model.
        /// The schema of any single instance may be specified via Endpoint's
        /// DeployedModels' [Model's][google.cloud.aiplatform.v1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1.Model.predict_schemata]
        /// [instance_schema_uri][google.cloud.aiplatform.v1.PredictSchemata.instance_schema_uri].
        /// </param>
        /// <param name="parameters">
        /// The parameters that govern the prediction. The schema of the parameters may
        /// be specified via Endpoint's DeployedModels' [Model's ][google.cloud.aiplatform.v1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1.Model.predict_schemata]
        /// [parameters_schema_uri][google.cloud.aiplatform.v1.PredictSchemata.parameters_schema_uri].
        /// </param>
        /// <param name="deployedModelId">
        /// If specified, this ExplainRequest will be served by the chosen
        /// DeployedModel, overriding [Endpoint.traffic_split][google.cloud.aiplatform.v1.Endpoint.traffic_split].
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExplainResponse> ExplainAsync(EndpointName endpoint, scg::IEnumerable<wkt::Value> instances, wkt::Value parameters, string deployedModelId, st::CancellationToken cancellationToken) =>
            ExplainAsync(endpoint, instances, parameters, deployedModelId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>PredictionService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service for online predictions and explanations.
    /// </remarks>
    public sealed partial class PredictionServiceClientImpl : PredictionServiceClient
    {
        private readonly gaxgrpc::ApiCall<PredictRequest, PredictResponse> _callPredict;

        private readonly gaxgrpc::ApiCall<RawPredictRequest, ga::HttpBody> _callRawPredict;

        private readonly gaxgrpc::ApiCall<ExplainRequest, ExplainResponse> _callExplain;

        /// <summary>
        /// Constructs a client wrapper for the PredictionService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="PredictionServiceSettings"/> used within this client.</param>
        public PredictionServiceClientImpl(PredictionService.PredictionServiceClient grpcClient, PredictionServiceSettings settings)
        {
            GrpcClient = grpcClient;
            PredictionServiceSettings effectiveSettings = settings ?? PredictionServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callPredict = clientHelper.BuildApiCall<PredictRequest, PredictResponse>(grpcClient.PredictAsync, grpcClient.Predict, effectiveSettings.PredictSettings).WithGoogleRequestParam("endpoint", request => request.Endpoint);
            Modify_ApiCall(ref _callPredict);
            Modify_PredictApiCall(ref _callPredict);
            _callRawPredict = clientHelper.BuildApiCall<RawPredictRequest, ga::HttpBody>(grpcClient.RawPredictAsync, grpcClient.RawPredict, effectiveSettings.RawPredictSettings).WithGoogleRequestParam("endpoint", request => request.Endpoint);
            Modify_ApiCall(ref _callRawPredict);
            Modify_RawPredictApiCall(ref _callRawPredict);
            _callExplain = clientHelper.BuildApiCall<ExplainRequest, ExplainResponse>(grpcClient.ExplainAsync, grpcClient.Explain, effectiveSettings.ExplainSettings).WithGoogleRequestParam("endpoint", request => request.Endpoint);
            Modify_ApiCall(ref _callExplain);
            Modify_ExplainApiCall(ref _callExplain);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_PredictApiCall(ref gaxgrpc::ApiCall<PredictRequest, PredictResponse> call);

        partial void Modify_RawPredictApiCall(ref gaxgrpc::ApiCall<RawPredictRequest, ga::HttpBody> call);

        partial void Modify_ExplainApiCall(ref gaxgrpc::ApiCall<ExplainRequest, ExplainResponse> call);

        partial void OnConstruction(PredictionService.PredictionServiceClient grpcClient, PredictionServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC PredictionService client</summary>
        public override PredictionService.PredictionServiceClient GrpcClient { get; }

        partial void Modify_PredictRequest(ref PredictRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RawPredictRequest(ref RawPredictRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExplainRequest(ref ExplainRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Perform an online prediction.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PredictResponse Predict(PredictRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PredictRequest(ref request, ref callSettings);
            return _callPredict.Sync(request, callSettings);
        }

        /// <summary>
        /// Perform an online prediction.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PredictResponse> PredictAsync(PredictRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PredictRequest(ref request, ref callSettings);
            return _callPredict.Async(request, callSettings);
        }

        /// <summary>
        /// Perform an online prediction with an arbitrary HTTP payload.
        /// 
        /// The response includes the following HTTP headers:
        /// 
        /// * `X-Vertex-AI-Endpoint-Id`: ID of the [Endpoint][google.cloud.aiplatform.v1.Endpoint] that served this
        /// prediction.
        /// 
        /// * `X-Vertex-AI-Deployed-Model-Id`: ID of the Endpoint's [DeployedModel][google.cloud.aiplatform.v1.DeployedModel]
        /// that served this prediction.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ga::HttpBody RawPredict(RawPredictRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RawPredictRequest(ref request, ref callSettings);
            return _callRawPredict.Sync(request, callSettings);
        }

        /// <summary>
        /// Perform an online prediction with an arbitrary HTTP payload.
        /// 
        /// The response includes the following HTTP headers:
        /// 
        /// * `X-Vertex-AI-Endpoint-Id`: ID of the [Endpoint][google.cloud.aiplatform.v1.Endpoint] that served this
        /// prediction.
        /// 
        /// * `X-Vertex-AI-Deployed-Model-Id`: ID of the Endpoint's [DeployedModel][google.cloud.aiplatform.v1.DeployedModel]
        /// that served this prediction.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ga::HttpBody> RawPredictAsync(RawPredictRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RawPredictRequest(ref request, ref callSettings);
            return _callRawPredict.Async(request, callSettings);
        }

        /// <summary>
        /// Perform an online explanation.
        /// 
        /// If [deployed_model_id][google.cloud.aiplatform.v1.ExplainRequest.deployed_model_id] is specified,
        /// the corresponding DeployModel must have
        /// [explanation_spec][google.cloud.aiplatform.v1.DeployedModel.explanation_spec]
        /// populated. If [deployed_model_id][google.cloud.aiplatform.v1.ExplainRequest.deployed_model_id]
        /// is not specified, all DeployedModels must have
        /// [explanation_spec][google.cloud.aiplatform.v1.DeployedModel.explanation_spec]
        /// populated. Only deployed AutoML tabular Models have
        /// explanation_spec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ExplainResponse Explain(ExplainRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExplainRequest(ref request, ref callSettings);
            return _callExplain.Sync(request, callSettings);
        }

        /// <summary>
        /// Perform an online explanation.
        /// 
        /// If [deployed_model_id][google.cloud.aiplatform.v1.ExplainRequest.deployed_model_id] is specified,
        /// the corresponding DeployModel must have
        /// [explanation_spec][google.cloud.aiplatform.v1.DeployedModel.explanation_spec]
        /// populated. If [deployed_model_id][google.cloud.aiplatform.v1.ExplainRequest.deployed_model_id]
        /// is not specified, all DeployedModels must have
        /// [explanation_spec][google.cloud.aiplatform.v1.DeployedModel.explanation_spec]
        /// populated. Only deployed AutoML tabular Models have
        /// explanation_spec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ExplainResponse> ExplainAsync(ExplainRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExplainRequest(ref request, ref callSettings);
            return _callExplain.Async(request, callSettings);
        }
    }
}
