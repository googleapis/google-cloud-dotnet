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
using ga = Google.Api;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gciv = Google.Cloud.Iam.V1;
using gcl = Google.Cloud.Location;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using linq = System.Linq;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.AIPlatform.V1Beta1
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
            StreamRawPredictSettings = existing.StreamRawPredictSettings;
            DirectPredictSettings = existing.DirectPredictSettings;
            DirectRawPredictSettings = existing.DirectRawPredictSettings;
            StreamDirectPredictSettings = existing.StreamDirectPredictSettings;
            StreamDirectPredictStreamingSettings = existing.StreamDirectPredictStreamingSettings;
            StreamDirectRawPredictSettings = existing.StreamDirectRawPredictSettings;
            StreamDirectRawPredictStreamingSettings = existing.StreamDirectRawPredictStreamingSettings;
            StreamingPredictSettings = existing.StreamingPredictSettings;
            StreamingPredictStreamingSettings = existing.StreamingPredictStreamingSettings;
            ServerStreamingPredictSettings = existing.ServerStreamingPredictSettings;
            StreamingRawPredictSettings = existing.StreamingRawPredictSettings;
            StreamingRawPredictStreamingSettings = existing.StreamingRawPredictStreamingSettings;
            ExplainSettings = existing.ExplainSettings;
            CountTokensSettings = existing.CountTokensSettings;
            GenerateContentSettings = existing.GenerateContentSettings;
            StreamGenerateContentSettings = existing.StreamGenerateContentSettings;
            ChatCompletionsSettings = existing.ChatCompletionsSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
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
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PredictSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

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
        /// <c>PredictionServiceClient.StreamRawPredict</c> and <c>PredictionServiceClient.StreamRawPredictAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StreamRawPredictSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PredictionServiceClient.DirectPredict</c> and <c>PredictionServiceClient.DirectPredictAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DirectPredictSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PredictionServiceClient.DirectRawPredict</c> and <c>PredictionServiceClient.DirectRawPredictAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DirectRawPredictSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PredictionServiceClient.StreamDirectPredict</c> and <c>PredictionServiceClient.StreamDirectPredictAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StreamDirectPredictSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::BidirectionalStreamingSettings"/> for calls to
        /// <c>PredictionServiceClient.StreamDirectPredict</c> and <c>PredictionServiceClient.StreamDirectPredictAsync</c>
        /// .
        /// </summary>
        /// <remarks>The default local send queue size is 100.</remarks>
        public gaxgrpc::BidirectionalStreamingSettings StreamDirectPredictStreamingSettings { get; set; } = new gaxgrpc::BidirectionalStreamingSettings(100);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PredictionServiceClient.StreamDirectRawPredict</c> and
        /// <c>PredictionServiceClient.StreamDirectRawPredictAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StreamDirectRawPredictSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::BidirectionalStreamingSettings"/> for calls to
        /// <c>PredictionServiceClient.StreamDirectRawPredict</c> and
        /// <c>PredictionServiceClient.StreamDirectRawPredictAsync</c>.
        /// </summary>
        /// <remarks>The default local send queue size is 100.</remarks>
        public gaxgrpc::BidirectionalStreamingSettings StreamDirectRawPredictStreamingSettings { get; set; } = new gaxgrpc::BidirectionalStreamingSettings(100);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PredictionServiceClient.StreamingPredict</c> and <c>PredictionServiceClient.StreamingPredictAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StreamingPredictSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::BidirectionalStreamingSettings"/> for calls to
        /// <c>PredictionServiceClient.StreamingPredict</c> and <c>PredictionServiceClient.StreamingPredictAsync</c>.
        /// </summary>
        /// <remarks>The default local send queue size is 100.</remarks>
        public gaxgrpc::BidirectionalStreamingSettings StreamingPredictStreamingSettings { get; set; } = new gaxgrpc::BidirectionalStreamingSettings(100);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PredictionServiceClient.ServerStreamingPredict</c> and
        /// <c>PredictionServiceClient.ServerStreamingPredictAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ServerStreamingPredictSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PredictionServiceClient.StreamingRawPredict</c> and <c>PredictionServiceClient.StreamingRawPredictAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StreamingRawPredictSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::BidirectionalStreamingSettings"/> for calls to
        /// <c>PredictionServiceClient.StreamingRawPredict</c> and <c>PredictionServiceClient.StreamingRawPredictAsync</c>
        /// .
        /// </summary>
        /// <remarks>The default local send queue size is 100.</remarks>
        public gaxgrpc::BidirectionalStreamingSettings StreamingRawPredictStreamingSettings { get; set; } = new gaxgrpc::BidirectionalStreamingSettings(100);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PredictionServiceClient.Explain</c> and <c>PredictionServiceClient.ExplainAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExplainSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PredictionServiceClient.CountTokens</c> and <c>PredictionServiceClient.CountTokensAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CountTokensSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PredictionServiceClient.GenerateContent</c> and <c>PredictionServiceClient.GenerateContentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GenerateContentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PredictionServiceClient.StreamGenerateContent</c> and
        /// <c>PredictionServiceClient.StreamGenerateContentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StreamGenerateContentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PredictionServiceClient.ChatCompletions</c> and <c>PredictionServiceClient.ChatCompletionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ChatCompletionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

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
        public PredictionServiceClientBuilder() : base(PredictionServiceClient.ServiceMetadata)
        {
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
            return PredictionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<PredictionServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PredictionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => PredictionServiceClient.ChannelPool;
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
        /// <item><description>https://www.googleapis.com/auth/cloud-platform.read-only</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(PredictionService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

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
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="PredictionServiceClient"/>.</returns>
        internal static PredictionServiceClient Create(grpccore::CallInvoker callInvoker, PredictionServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            PredictionService.PredictionServiceClient grpcClient = new PredictionService.PredictionServiceClient(callInvoker);
            return new PredictionServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

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
        /// DeployedModels'
        /// [Model's][google.cloud.aiplatform.v1beta1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1beta1.Model.predict_schemata]
        /// [instance_schema_uri][google.cloud.aiplatform.v1beta1.PredictSchemata.instance_schema_uri].
        /// </param>
        /// <param name="parameters">
        /// The parameters that govern the prediction. The schema of the parameters may
        /// be specified via Endpoint's DeployedModels' [Model's
        /// ][google.cloud.aiplatform.v1beta1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1beta1.Model.predict_schemata]
        /// [parameters_schema_uri][google.cloud.aiplatform.v1beta1.PredictSchemata.parameters_schema_uri].
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
        /// DeployedModels'
        /// [Model's][google.cloud.aiplatform.v1beta1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1beta1.Model.predict_schemata]
        /// [instance_schema_uri][google.cloud.aiplatform.v1beta1.PredictSchemata.instance_schema_uri].
        /// </param>
        /// <param name="parameters">
        /// The parameters that govern the prediction. The schema of the parameters may
        /// be specified via Endpoint's DeployedModels' [Model's
        /// ][google.cloud.aiplatform.v1beta1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1beta1.Model.predict_schemata]
        /// [parameters_schema_uri][google.cloud.aiplatform.v1beta1.PredictSchemata.parameters_schema_uri].
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
        /// DeployedModels'
        /// [Model's][google.cloud.aiplatform.v1beta1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1beta1.Model.predict_schemata]
        /// [instance_schema_uri][google.cloud.aiplatform.v1beta1.PredictSchemata.instance_schema_uri].
        /// </param>
        /// <param name="parameters">
        /// The parameters that govern the prediction. The schema of the parameters may
        /// be specified via Endpoint's DeployedModels' [Model's
        /// ][google.cloud.aiplatform.v1beta1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1beta1.Model.predict_schemata]
        /// [parameters_schema_uri][google.cloud.aiplatform.v1beta1.PredictSchemata.parameters_schema_uri].
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
        /// DeployedModels'
        /// [Model's][google.cloud.aiplatform.v1beta1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1beta1.Model.predict_schemata]
        /// [instance_schema_uri][google.cloud.aiplatform.v1beta1.PredictSchemata.instance_schema_uri].
        /// </param>
        /// <param name="parameters">
        /// The parameters that govern the prediction. The schema of the parameters may
        /// be specified via Endpoint's DeployedModels' [Model's
        /// ][google.cloud.aiplatform.v1beta1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1beta1.Model.predict_schemata]
        /// [parameters_schema_uri][google.cloud.aiplatform.v1beta1.PredictSchemata.parameters_schema_uri].
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
        /// DeployedModels'
        /// [Model's][google.cloud.aiplatform.v1beta1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1beta1.Model.predict_schemata]
        /// [instance_schema_uri][google.cloud.aiplatform.v1beta1.PredictSchemata.instance_schema_uri].
        /// </param>
        /// <param name="parameters">
        /// The parameters that govern the prediction. The schema of the parameters may
        /// be specified via Endpoint's DeployedModels' [Model's
        /// ][google.cloud.aiplatform.v1beta1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1beta1.Model.predict_schemata]
        /// [parameters_schema_uri][google.cloud.aiplatform.v1beta1.PredictSchemata.parameters_schema_uri].
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
        /// DeployedModels'
        /// [Model's][google.cloud.aiplatform.v1beta1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1beta1.Model.predict_schemata]
        /// [instance_schema_uri][google.cloud.aiplatform.v1beta1.PredictSchemata.instance_schema_uri].
        /// </param>
        /// <param name="parameters">
        /// The parameters that govern the prediction. The schema of the parameters may
        /// be specified via Endpoint's DeployedModels' [Model's
        /// ][google.cloud.aiplatform.v1beta1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1beta1.Model.predict_schemata]
        /// [parameters_schema_uri][google.cloud.aiplatform.v1beta1.PredictSchemata.parameters_schema_uri].
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
        /// * `X-Vertex-AI-Endpoint-Id`: ID of the
        /// [Endpoint][google.cloud.aiplatform.v1beta1.Endpoint] that served this
        /// prediction.
        /// 
        /// * `X-Vertex-AI-Deployed-Model-Id`: ID of the Endpoint's
        /// [DeployedModel][google.cloud.aiplatform.v1beta1.DeployedModel] that served
        /// this prediction.
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
        /// * `X-Vertex-AI-Endpoint-Id`: ID of the
        /// [Endpoint][google.cloud.aiplatform.v1beta1.Endpoint] that served this
        /// prediction.
        /// 
        /// * `X-Vertex-AI-Deployed-Model-Id`: ID of the Endpoint's
        /// [DeployedModel][google.cloud.aiplatform.v1beta1.DeployedModel] that served
        /// this prediction.
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
        /// * `X-Vertex-AI-Endpoint-Id`: ID of the
        /// [Endpoint][google.cloud.aiplatform.v1beta1.Endpoint] that served this
        /// prediction.
        /// 
        /// * `X-Vertex-AI-Deployed-Model-Id`: ID of the Endpoint's
        /// [DeployedModel][google.cloud.aiplatform.v1beta1.DeployedModel] that served
        /// this prediction.
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
        /// * `X-Vertex-AI-Endpoint-Id`: ID of the
        /// [Endpoint][google.cloud.aiplatform.v1beta1.Endpoint] that served this
        /// prediction.
        /// 
        /// * `X-Vertex-AI-Deployed-Model-Id`: ID of the Endpoint's
        /// [DeployedModel][google.cloud.aiplatform.v1beta1.DeployedModel] that served
        /// this prediction.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint requested to serve the prediction.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="httpBody">
        /// The prediction input. Supports HTTP headers and arbitrary data payload.
        /// 
        /// A [DeployedModel][google.cloud.aiplatform.v1beta1.DeployedModel] may have
        /// an upper limit on the number of instances it supports per request. When
        /// this limit it is exceeded for an AutoML model, the
        /// [RawPredict][google.cloud.aiplatform.v1beta1.PredictionService.RawPredict]
        /// method returns an error. When this limit is exceeded for a custom-trained
        /// model, the behavior varies depending on the model.
        /// 
        /// You can specify the schema for each instance in the
        /// [predict_schemata.instance_schema_uri][google.cloud.aiplatform.v1beta1.PredictSchemata.instance_schema_uri]
        /// field when you create a [Model][google.cloud.aiplatform.v1beta1.Model].
        /// This schema applies when you deploy the `Model` as a `DeployedModel` to an
        /// [Endpoint][google.cloud.aiplatform.v1beta1.Endpoint] and use the
        /// `RawPredict` method.
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
        /// * `X-Vertex-AI-Endpoint-Id`: ID of the
        /// [Endpoint][google.cloud.aiplatform.v1beta1.Endpoint] that served this
        /// prediction.
        /// 
        /// * `X-Vertex-AI-Deployed-Model-Id`: ID of the Endpoint's
        /// [DeployedModel][google.cloud.aiplatform.v1beta1.DeployedModel] that served
        /// this prediction.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint requested to serve the prediction.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="httpBody">
        /// The prediction input. Supports HTTP headers and arbitrary data payload.
        /// 
        /// A [DeployedModel][google.cloud.aiplatform.v1beta1.DeployedModel] may have
        /// an upper limit on the number of instances it supports per request. When
        /// this limit it is exceeded for an AutoML model, the
        /// [RawPredict][google.cloud.aiplatform.v1beta1.PredictionService.RawPredict]
        /// method returns an error. When this limit is exceeded for a custom-trained
        /// model, the behavior varies depending on the model.
        /// 
        /// You can specify the schema for each instance in the
        /// [predict_schemata.instance_schema_uri][google.cloud.aiplatform.v1beta1.PredictSchemata.instance_schema_uri]
        /// field when you create a [Model][google.cloud.aiplatform.v1beta1.Model].
        /// This schema applies when you deploy the `Model` as a `DeployedModel` to an
        /// [Endpoint][google.cloud.aiplatform.v1beta1.Endpoint] and use the
        /// `RawPredict` method.
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
        /// * `X-Vertex-AI-Endpoint-Id`: ID of the
        /// [Endpoint][google.cloud.aiplatform.v1beta1.Endpoint] that served this
        /// prediction.
        /// 
        /// * `X-Vertex-AI-Deployed-Model-Id`: ID of the Endpoint's
        /// [DeployedModel][google.cloud.aiplatform.v1beta1.DeployedModel] that served
        /// this prediction.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint requested to serve the prediction.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="httpBody">
        /// The prediction input. Supports HTTP headers and arbitrary data payload.
        /// 
        /// A [DeployedModel][google.cloud.aiplatform.v1beta1.DeployedModel] may have
        /// an upper limit on the number of instances it supports per request. When
        /// this limit it is exceeded for an AutoML model, the
        /// [RawPredict][google.cloud.aiplatform.v1beta1.PredictionService.RawPredict]
        /// method returns an error. When this limit is exceeded for a custom-trained
        /// model, the behavior varies depending on the model.
        /// 
        /// You can specify the schema for each instance in the
        /// [predict_schemata.instance_schema_uri][google.cloud.aiplatform.v1beta1.PredictSchemata.instance_schema_uri]
        /// field when you create a [Model][google.cloud.aiplatform.v1beta1.Model].
        /// This schema applies when you deploy the `Model` as a `DeployedModel` to an
        /// [Endpoint][google.cloud.aiplatform.v1beta1.Endpoint] and use the
        /// `RawPredict` method.
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
        /// * `X-Vertex-AI-Endpoint-Id`: ID of the
        /// [Endpoint][google.cloud.aiplatform.v1beta1.Endpoint] that served this
        /// prediction.
        /// 
        /// * `X-Vertex-AI-Deployed-Model-Id`: ID of the Endpoint's
        /// [DeployedModel][google.cloud.aiplatform.v1beta1.DeployedModel] that served
        /// this prediction.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint requested to serve the prediction.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="httpBody">
        /// The prediction input. Supports HTTP headers and arbitrary data payload.
        /// 
        /// A [DeployedModel][google.cloud.aiplatform.v1beta1.DeployedModel] may have
        /// an upper limit on the number of instances it supports per request. When
        /// this limit it is exceeded for an AutoML model, the
        /// [RawPredict][google.cloud.aiplatform.v1beta1.PredictionService.RawPredict]
        /// method returns an error. When this limit is exceeded for a custom-trained
        /// model, the behavior varies depending on the model.
        /// 
        /// You can specify the schema for each instance in the
        /// [predict_schemata.instance_schema_uri][google.cloud.aiplatform.v1beta1.PredictSchemata.instance_schema_uri]
        /// field when you create a [Model][google.cloud.aiplatform.v1beta1.Model].
        /// This schema applies when you deploy the `Model` as a `DeployedModel` to an
        /// [Endpoint][google.cloud.aiplatform.v1beta1.Endpoint] and use the
        /// `RawPredict` method.
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
        /// * `X-Vertex-AI-Endpoint-Id`: ID of the
        /// [Endpoint][google.cloud.aiplatform.v1beta1.Endpoint] that served this
        /// prediction.
        /// 
        /// * `X-Vertex-AI-Deployed-Model-Id`: ID of the Endpoint's
        /// [DeployedModel][google.cloud.aiplatform.v1beta1.DeployedModel] that served
        /// this prediction.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint requested to serve the prediction.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="httpBody">
        /// The prediction input. Supports HTTP headers and arbitrary data payload.
        /// 
        /// A [DeployedModel][google.cloud.aiplatform.v1beta1.DeployedModel] may have
        /// an upper limit on the number of instances it supports per request. When
        /// this limit it is exceeded for an AutoML model, the
        /// [RawPredict][google.cloud.aiplatform.v1beta1.PredictionService.RawPredict]
        /// method returns an error. When this limit is exceeded for a custom-trained
        /// model, the behavior varies depending on the model.
        /// 
        /// You can specify the schema for each instance in the
        /// [predict_schemata.instance_schema_uri][google.cloud.aiplatform.v1beta1.PredictSchemata.instance_schema_uri]
        /// field when you create a [Model][google.cloud.aiplatform.v1beta1.Model].
        /// This schema applies when you deploy the `Model` as a `DeployedModel` to an
        /// [Endpoint][google.cloud.aiplatform.v1beta1.Endpoint] and use the
        /// `RawPredict` method.
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
        /// * `X-Vertex-AI-Endpoint-Id`: ID of the
        /// [Endpoint][google.cloud.aiplatform.v1beta1.Endpoint] that served this
        /// prediction.
        /// 
        /// * `X-Vertex-AI-Deployed-Model-Id`: ID of the Endpoint's
        /// [DeployedModel][google.cloud.aiplatform.v1beta1.DeployedModel] that served
        /// this prediction.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint requested to serve the prediction.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="httpBody">
        /// The prediction input. Supports HTTP headers and arbitrary data payload.
        /// 
        /// A [DeployedModel][google.cloud.aiplatform.v1beta1.DeployedModel] may have
        /// an upper limit on the number of instances it supports per request. When
        /// this limit it is exceeded for an AutoML model, the
        /// [RawPredict][google.cloud.aiplatform.v1beta1.PredictionService.RawPredict]
        /// method returns an error. When this limit is exceeded for a custom-trained
        /// model, the behavior varies depending on the model.
        /// 
        /// You can specify the schema for each instance in the
        /// [predict_schemata.instance_schema_uri][google.cloud.aiplatform.v1beta1.PredictSchemata.instance_schema_uri]
        /// field when you create a [Model][google.cloud.aiplatform.v1beta1.Model].
        /// This schema applies when you deploy the `Model` as a `DeployedModel` to an
        /// [Endpoint][google.cloud.aiplatform.v1beta1.Endpoint] and use the
        /// `RawPredict` method.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::HttpBody> RawPredictAsync(EndpointName endpoint, ga::HttpBody httpBody, st::CancellationToken cancellationToken) =>
            RawPredictAsync(endpoint, httpBody, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Server streaming methods for <see cref="StreamRawPredict(StreamRawPredictRequest,gaxgrpc::CallSettings)"/>.
        /// </summary>
        public abstract partial class StreamRawPredictStream : gaxgrpc::ServerStreamingBase<ga::HttpBody>
        {
        }

        /// <summary>
        /// Perform a streaming online prediction with an arbitrary HTTP payload.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual StreamRawPredictStream StreamRawPredict(StreamRawPredictRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Perform a streaming online prediction with an arbitrary HTTP payload.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint requested to serve the prediction.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="httpBody">
        /// The prediction input. Supports HTTP headers and arbitrary data payload.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual StreamRawPredictStream StreamRawPredict(string endpoint, ga::HttpBody httpBody, gaxgrpc::CallSettings callSettings = null) =>
            StreamRawPredict(new StreamRawPredictRequest
            {
                Endpoint = gax::GaxPreconditions.CheckNotNullOrEmpty(endpoint, nameof(endpoint)),
                HttpBody = httpBody,
            }, callSettings);

        /// <summary>
        /// Perform a streaming online prediction with an arbitrary HTTP payload.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint requested to serve the prediction.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="httpBody">
        /// The prediction input. Supports HTTP headers and arbitrary data payload.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual StreamRawPredictStream StreamRawPredict(EndpointName endpoint, ga::HttpBody httpBody, gaxgrpc::CallSettings callSettings = null) =>
            StreamRawPredict(new StreamRawPredictRequest
            {
                EndpointAsEndpointName = gax::GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint)),
                HttpBody = httpBody,
            }, callSettings);

        /// <summary>
        /// Perform an unary online prediction request to a gRPC model server for
        /// Vertex first-party products and frameworks.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DirectPredictResponse DirectPredict(DirectPredictRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Perform an unary online prediction request to a gRPC model server for
        /// Vertex first-party products and frameworks.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DirectPredictResponse> DirectPredictAsync(DirectPredictRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Perform an unary online prediction request to a gRPC model server for
        /// Vertex first-party products and frameworks.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DirectPredictResponse> DirectPredictAsync(DirectPredictRequest request, st::CancellationToken cancellationToken) =>
            DirectPredictAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Perform an unary online prediction request to a gRPC model server for
        /// custom containers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DirectRawPredictResponse DirectRawPredict(DirectRawPredictRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Perform an unary online prediction request to a gRPC model server for
        /// custom containers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DirectRawPredictResponse> DirectRawPredictAsync(DirectRawPredictRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Perform an unary online prediction request to a gRPC model server for
        /// custom containers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DirectRawPredictResponse> DirectRawPredictAsync(DirectRawPredictRequest request, st::CancellationToken cancellationToken) =>
            DirectRawPredictAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Bidirectional streaming methods for
        /// <see cref="StreamDirectPredict(gaxgrpc::CallSettings,gaxgrpc::BidirectionalStreamingSettings)"/>.
        /// </summary>
        public abstract partial class StreamDirectPredictStream : gaxgrpc::BidirectionalStreamingBase<StreamDirectPredictRequest, StreamDirectPredictResponse>
        {
        }

        /// <summary>
        /// Perform a streaming online prediction request to a gRPC model server for
        /// Vertex first-party products and frameworks.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public virtual StreamDirectPredictStream StreamDirectPredict(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Bidirectional streaming methods for
        /// <see cref="StreamDirectRawPredict(gaxgrpc::CallSettings,gaxgrpc::BidirectionalStreamingSettings)"/>.
        /// </summary>
        public abstract partial class StreamDirectRawPredictStream : gaxgrpc::BidirectionalStreamingBase<StreamDirectRawPredictRequest, StreamDirectRawPredictResponse>
        {
        }

        /// <summary>
        /// Perform a streaming online prediction request to a gRPC model server for
        /// custom containers.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public virtual StreamDirectRawPredictStream StreamDirectRawPredict(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Bidirectional streaming methods for
        /// <see cref="StreamingPredict(gaxgrpc::CallSettings,gaxgrpc::BidirectionalStreamingSettings)"/>.
        /// </summary>
        public abstract partial class StreamingPredictStream : gaxgrpc::BidirectionalStreamingBase<StreamingPredictRequest, StreamingPredictResponse>
        {
        }

        /// <summary>
        /// Perform a streaming online prediction request for Vertex first-party
        /// products and frameworks.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public virtual StreamingPredictStream StreamingPredict(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Server streaming methods for
        /// <see cref="ServerStreamingPredict(StreamingPredictRequest,gaxgrpc::CallSettings)"/>.
        /// </summary>
        public abstract partial class ServerStreamingPredictStream : gaxgrpc::ServerStreamingBase<StreamingPredictResponse>
        {
        }

        /// <summary>
        /// Perform a server-side streaming online prediction request for Vertex
        /// LLM streaming.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ServerStreamingPredictStream ServerStreamingPredict(StreamingPredictRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Bidirectional streaming methods for
        /// <see cref="StreamingRawPredict(gaxgrpc::CallSettings,gaxgrpc::BidirectionalStreamingSettings)"/>.
        /// </summary>
        public abstract partial class StreamingRawPredictStream : gaxgrpc::BidirectionalStreamingBase<StreamingRawPredictRequest, StreamingRawPredictResponse>
        {
        }

        /// <summary>
        /// Perform a streaming online prediction request through gRPC.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public virtual StreamingRawPredictStream StreamingRawPredict(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Perform an online explanation.
        /// 
        /// If
        /// [deployed_model_id][google.cloud.aiplatform.v1beta1.ExplainRequest.deployed_model_id]
        /// is specified, the corresponding DeployModel must have
        /// [explanation_spec][google.cloud.aiplatform.v1beta1.DeployedModel.explanation_spec]
        /// populated. If
        /// [deployed_model_id][google.cloud.aiplatform.v1beta1.ExplainRequest.deployed_model_id]
        /// is not specified, all DeployedModels must have
        /// [explanation_spec][google.cloud.aiplatform.v1beta1.DeployedModel.explanation_spec]
        /// populated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExplainResponse Explain(ExplainRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Perform an online explanation.
        /// 
        /// If
        /// [deployed_model_id][google.cloud.aiplatform.v1beta1.ExplainRequest.deployed_model_id]
        /// is specified, the corresponding DeployModel must have
        /// [explanation_spec][google.cloud.aiplatform.v1beta1.DeployedModel.explanation_spec]
        /// populated. If
        /// [deployed_model_id][google.cloud.aiplatform.v1beta1.ExplainRequest.deployed_model_id]
        /// is not specified, all DeployedModels must have
        /// [explanation_spec][google.cloud.aiplatform.v1beta1.DeployedModel.explanation_spec]
        /// populated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExplainResponse> ExplainAsync(ExplainRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Perform an online explanation.
        /// 
        /// If
        /// [deployed_model_id][google.cloud.aiplatform.v1beta1.ExplainRequest.deployed_model_id]
        /// is specified, the corresponding DeployModel must have
        /// [explanation_spec][google.cloud.aiplatform.v1beta1.DeployedModel.explanation_spec]
        /// populated. If
        /// [deployed_model_id][google.cloud.aiplatform.v1beta1.ExplainRequest.deployed_model_id]
        /// is not specified, all DeployedModels must have
        /// [explanation_spec][google.cloud.aiplatform.v1beta1.DeployedModel.explanation_spec]
        /// populated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExplainResponse> ExplainAsync(ExplainRequest request, st::CancellationToken cancellationToken) =>
            ExplainAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Perform an online explanation.
        /// 
        /// If
        /// [deployed_model_id][google.cloud.aiplatform.v1beta1.ExplainRequest.deployed_model_id]
        /// is specified, the corresponding DeployModel must have
        /// [explanation_spec][google.cloud.aiplatform.v1beta1.DeployedModel.explanation_spec]
        /// populated. If
        /// [deployed_model_id][google.cloud.aiplatform.v1beta1.ExplainRequest.deployed_model_id]
        /// is not specified, all DeployedModels must have
        /// [explanation_spec][google.cloud.aiplatform.v1beta1.DeployedModel.explanation_spec]
        /// populated.
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
        /// DeployedModels'
        /// [Model's][google.cloud.aiplatform.v1beta1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1beta1.Model.predict_schemata]
        /// [instance_schema_uri][google.cloud.aiplatform.v1beta1.PredictSchemata.instance_schema_uri].
        /// </param>
        /// <param name="parameters">
        /// The parameters that govern the prediction. The schema of the parameters may
        /// be specified via Endpoint's DeployedModels' [Model's
        /// ][google.cloud.aiplatform.v1beta1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1beta1.Model.predict_schemata]
        /// [parameters_schema_uri][google.cloud.aiplatform.v1beta1.PredictSchemata.parameters_schema_uri].
        /// </param>
        /// <param name="deployedModelId">
        /// If specified, this ExplainRequest will be served by the chosen
        /// DeployedModel, overriding
        /// [Endpoint.traffic_split][google.cloud.aiplatform.v1beta1.Endpoint.traffic_split].
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
        /// If
        /// [deployed_model_id][google.cloud.aiplatform.v1beta1.ExplainRequest.deployed_model_id]
        /// is specified, the corresponding DeployModel must have
        /// [explanation_spec][google.cloud.aiplatform.v1beta1.DeployedModel.explanation_spec]
        /// populated. If
        /// [deployed_model_id][google.cloud.aiplatform.v1beta1.ExplainRequest.deployed_model_id]
        /// is not specified, all DeployedModels must have
        /// [explanation_spec][google.cloud.aiplatform.v1beta1.DeployedModel.explanation_spec]
        /// populated.
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
        /// DeployedModels'
        /// [Model's][google.cloud.aiplatform.v1beta1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1beta1.Model.predict_schemata]
        /// [instance_schema_uri][google.cloud.aiplatform.v1beta1.PredictSchemata.instance_schema_uri].
        /// </param>
        /// <param name="parameters">
        /// The parameters that govern the prediction. The schema of the parameters may
        /// be specified via Endpoint's DeployedModels' [Model's
        /// ][google.cloud.aiplatform.v1beta1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1beta1.Model.predict_schemata]
        /// [parameters_schema_uri][google.cloud.aiplatform.v1beta1.PredictSchemata.parameters_schema_uri].
        /// </param>
        /// <param name="deployedModelId">
        /// If specified, this ExplainRequest will be served by the chosen
        /// DeployedModel, overriding
        /// [Endpoint.traffic_split][google.cloud.aiplatform.v1beta1.Endpoint.traffic_split].
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
        /// If
        /// [deployed_model_id][google.cloud.aiplatform.v1beta1.ExplainRequest.deployed_model_id]
        /// is specified, the corresponding DeployModel must have
        /// [explanation_spec][google.cloud.aiplatform.v1beta1.DeployedModel.explanation_spec]
        /// populated. If
        /// [deployed_model_id][google.cloud.aiplatform.v1beta1.ExplainRequest.deployed_model_id]
        /// is not specified, all DeployedModels must have
        /// [explanation_spec][google.cloud.aiplatform.v1beta1.DeployedModel.explanation_spec]
        /// populated.
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
        /// DeployedModels'
        /// [Model's][google.cloud.aiplatform.v1beta1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1beta1.Model.predict_schemata]
        /// [instance_schema_uri][google.cloud.aiplatform.v1beta1.PredictSchemata.instance_schema_uri].
        /// </param>
        /// <param name="parameters">
        /// The parameters that govern the prediction. The schema of the parameters may
        /// be specified via Endpoint's DeployedModels' [Model's
        /// ][google.cloud.aiplatform.v1beta1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1beta1.Model.predict_schemata]
        /// [parameters_schema_uri][google.cloud.aiplatform.v1beta1.PredictSchemata.parameters_schema_uri].
        /// </param>
        /// <param name="deployedModelId">
        /// If specified, this ExplainRequest will be served by the chosen
        /// DeployedModel, overriding
        /// [Endpoint.traffic_split][google.cloud.aiplatform.v1beta1.Endpoint.traffic_split].
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExplainResponse> ExplainAsync(string endpoint, scg::IEnumerable<wkt::Value> instances, wkt::Value parameters, string deployedModelId, st::CancellationToken cancellationToken) =>
            ExplainAsync(endpoint, instances, parameters, deployedModelId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Perform an online explanation.
        /// 
        /// If
        /// [deployed_model_id][google.cloud.aiplatform.v1beta1.ExplainRequest.deployed_model_id]
        /// is specified, the corresponding DeployModel must have
        /// [explanation_spec][google.cloud.aiplatform.v1beta1.DeployedModel.explanation_spec]
        /// populated. If
        /// [deployed_model_id][google.cloud.aiplatform.v1beta1.ExplainRequest.deployed_model_id]
        /// is not specified, all DeployedModels must have
        /// [explanation_spec][google.cloud.aiplatform.v1beta1.DeployedModel.explanation_spec]
        /// populated.
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
        /// DeployedModels'
        /// [Model's][google.cloud.aiplatform.v1beta1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1beta1.Model.predict_schemata]
        /// [instance_schema_uri][google.cloud.aiplatform.v1beta1.PredictSchemata.instance_schema_uri].
        /// </param>
        /// <param name="parameters">
        /// The parameters that govern the prediction. The schema of the parameters may
        /// be specified via Endpoint's DeployedModels' [Model's
        /// ][google.cloud.aiplatform.v1beta1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1beta1.Model.predict_schemata]
        /// [parameters_schema_uri][google.cloud.aiplatform.v1beta1.PredictSchemata.parameters_schema_uri].
        /// </param>
        /// <param name="deployedModelId">
        /// If specified, this ExplainRequest will be served by the chosen
        /// DeployedModel, overriding
        /// [Endpoint.traffic_split][google.cloud.aiplatform.v1beta1.Endpoint.traffic_split].
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
        /// If
        /// [deployed_model_id][google.cloud.aiplatform.v1beta1.ExplainRequest.deployed_model_id]
        /// is specified, the corresponding DeployModel must have
        /// [explanation_spec][google.cloud.aiplatform.v1beta1.DeployedModel.explanation_spec]
        /// populated. If
        /// [deployed_model_id][google.cloud.aiplatform.v1beta1.ExplainRequest.deployed_model_id]
        /// is not specified, all DeployedModels must have
        /// [explanation_spec][google.cloud.aiplatform.v1beta1.DeployedModel.explanation_spec]
        /// populated.
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
        /// DeployedModels'
        /// [Model's][google.cloud.aiplatform.v1beta1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1beta1.Model.predict_schemata]
        /// [instance_schema_uri][google.cloud.aiplatform.v1beta1.PredictSchemata.instance_schema_uri].
        /// </param>
        /// <param name="parameters">
        /// The parameters that govern the prediction. The schema of the parameters may
        /// be specified via Endpoint's DeployedModels' [Model's
        /// ][google.cloud.aiplatform.v1beta1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1beta1.Model.predict_schemata]
        /// [parameters_schema_uri][google.cloud.aiplatform.v1beta1.PredictSchemata.parameters_schema_uri].
        /// </param>
        /// <param name="deployedModelId">
        /// If specified, this ExplainRequest will be served by the chosen
        /// DeployedModel, overriding
        /// [Endpoint.traffic_split][google.cloud.aiplatform.v1beta1.Endpoint.traffic_split].
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
        /// If
        /// [deployed_model_id][google.cloud.aiplatform.v1beta1.ExplainRequest.deployed_model_id]
        /// is specified, the corresponding DeployModel must have
        /// [explanation_spec][google.cloud.aiplatform.v1beta1.DeployedModel.explanation_spec]
        /// populated. If
        /// [deployed_model_id][google.cloud.aiplatform.v1beta1.ExplainRequest.deployed_model_id]
        /// is not specified, all DeployedModels must have
        /// [explanation_spec][google.cloud.aiplatform.v1beta1.DeployedModel.explanation_spec]
        /// populated.
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
        /// DeployedModels'
        /// [Model's][google.cloud.aiplatform.v1beta1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1beta1.Model.predict_schemata]
        /// [instance_schema_uri][google.cloud.aiplatform.v1beta1.PredictSchemata.instance_schema_uri].
        /// </param>
        /// <param name="parameters">
        /// The parameters that govern the prediction. The schema of the parameters may
        /// be specified via Endpoint's DeployedModels' [Model's
        /// ][google.cloud.aiplatform.v1beta1.DeployedModel.model]
        /// [PredictSchemata's][google.cloud.aiplatform.v1beta1.Model.predict_schemata]
        /// [parameters_schema_uri][google.cloud.aiplatform.v1beta1.PredictSchemata.parameters_schema_uri].
        /// </param>
        /// <param name="deployedModelId">
        /// If specified, this ExplainRequest will be served by the chosen
        /// DeployedModel, overriding
        /// [Endpoint.traffic_split][google.cloud.aiplatform.v1beta1.Endpoint.traffic_split].
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExplainResponse> ExplainAsync(EndpointName endpoint, scg::IEnumerable<wkt::Value> instances, wkt::Value parameters, string deployedModelId, st::CancellationToken cancellationToken) =>
            ExplainAsync(endpoint, instances, parameters, deployedModelId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Perform a token counting.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CountTokensResponse CountTokens(CountTokensRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Perform a token counting.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CountTokensResponse> CountTokensAsync(CountTokensRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Perform a token counting.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CountTokensResponse> CountTokensAsync(CountTokensRequest request, st::CancellationToken cancellationToken) =>
            CountTokensAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Perform a token counting.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint requested to perform token counting.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="instances">
        /// Optional. The instances that are the input to token counting call.
        /// Schema is identical to the prediction schema of the underlying model.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CountTokensResponse CountTokens(string endpoint, scg::IEnumerable<wkt::Value> instances, gaxgrpc::CallSettings callSettings = null) =>
            CountTokens(new CountTokensRequest
            {
                Endpoint = gax::GaxPreconditions.CheckNotNullOrEmpty(endpoint, nameof(endpoint)),
                Instances =
                {
                    instances ?? linq::Enumerable.Empty<wkt::Value>(),
                },
            }, callSettings);

        /// <summary>
        /// Perform a token counting.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint requested to perform token counting.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="instances">
        /// Optional. The instances that are the input to token counting call.
        /// Schema is identical to the prediction schema of the underlying model.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CountTokensResponse> CountTokensAsync(string endpoint, scg::IEnumerable<wkt::Value> instances, gaxgrpc::CallSettings callSettings = null) =>
            CountTokensAsync(new CountTokensRequest
            {
                Endpoint = gax::GaxPreconditions.CheckNotNullOrEmpty(endpoint, nameof(endpoint)),
                Instances =
                {
                    instances ?? linq::Enumerable.Empty<wkt::Value>(),
                },
            }, callSettings);

        /// <summary>
        /// Perform a token counting.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint requested to perform token counting.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="instances">
        /// Optional. The instances that are the input to token counting call.
        /// Schema is identical to the prediction schema of the underlying model.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CountTokensResponse> CountTokensAsync(string endpoint, scg::IEnumerable<wkt::Value> instances, st::CancellationToken cancellationToken) =>
            CountTokensAsync(endpoint, instances, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Perform a token counting.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint requested to perform token counting.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="instances">
        /// Optional. The instances that are the input to token counting call.
        /// Schema is identical to the prediction schema of the underlying model.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CountTokensResponse CountTokens(EndpointName endpoint, scg::IEnumerable<wkt::Value> instances, gaxgrpc::CallSettings callSettings = null) =>
            CountTokens(new CountTokensRequest
            {
                EndpointAsEndpointName = gax::GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint)),
                Instances =
                {
                    instances ?? linq::Enumerable.Empty<wkt::Value>(),
                },
            }, callSettings);

        /// <summary>
        /// Perform a token counting.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint requested to perform token counting.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="instances">
        /// Optional. The instances that are the input to token counting call.
        /// Schema is identical to the prediction schema of the underlying model.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CountTokensResponse> CountTokensAsync(EndpointName endpoint, scg::IEnumerable<wkt::Value> instances, gaxgrpc::CallSettings callSettings = null) =>
            CountTokensAsync(new CountTokensRequest
            {
                EndpointAsEndpointName = gax::GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint)),
                Instances =
                {
                    instances ?? linq::Enumerable.Empty<wkt::Value>(),
                },
            }, callSettings);

        /// <summary>
        /// Perform a token counting.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint requested to perform token counting.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="instances">
        /// Optional. The instances that are the input to token counting call.
        /// Schema is identical to the prediction schema of the underlying model.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CountTokensResponse> CountTokensAsync(EndpointName endpoint, scg::IEnumerable<wkt::Value> instances, st::CancellationToken cancellationToken) =>
            CountTokensAsync(endpoint, instances, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generate content with multimodal inputs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateContentResponse GenerateContent(GenerateContentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generate content with multimodal inputs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateContentResponse> GenerateContentAsync(GenerateContentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generate content with multimodal inputs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateContentResponse> GenerateContentAsync(GenerateContentRequest request, st::CancellationToken cancellationToken) =>
            GenerateContentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generate content with multimodal inputs.
        /// </summary>
        /// <param name="model">
        /// Required. The fully qualified name of the publisher model or tuned model
        /// endpoint to use.
        /// 
        /// Publisher model format:
        /// `projects/{project}/locations/{location}/publishers/*/models/*`
        /// 
        /// Tuned model endpoint format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="contents">
        /// Required. The content of the current conversation with the model.
        /// 
        /// For single-turn queries, this is a single instance. For multi-turn queries,
        /// this is a repeated field that contains conversation history + latest
        /// request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateContentResponse GenerateContent(string model, scg::IEnumerable<Content> contents, gaxgrpc::CallSettings callSettings = null) =>
            GenerateContent(new GenerateContentRequest
            {
                Model = gax::GaxPreconditions.CheckNotNullOrEmpty(model, nameof(model)),
                Contents =
                {
                    gax::GaxPreconditions.CheckNotNull(contents, nameof(contents)),
                },
            }, callSettings);

        /// <summary>
        /// Generate content with multimodal inputs.
        /// </summary>
        /// <param name="model">
        /// Required. The fully qualified name of the publisher model or tuned model
        /// endpoint to use.
        /// 
        /// Publisher model format:
        /// `projects/{project}/locations/{location}/publishers/*/models/*`
        /// 
        /// Tuned model endpoint format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="contents">
        /// Required. The content of the current conversation with the model.
        /// 
        /// For single-turn queries, this is a single instance. For multi-turn queries,
        /// this is a repeated field that contains conversation history + latest
        /// request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateContentResponse> GenerateContentAsync(string model, scg::IEnumerable<Content> contents, gaxgrpc::CallSettings callSettings = null) =>
            GenerateContentAsync(new GenerateContentRequest
            {
                Model = gax::GaxPreconditions.CheckNotNullOrEmpty(model, nameof(model)),
                Contents =
                {
                    gax::GaxPreconditions.CheckNotNull(contents, nameof(contents)),
                },
            }, callSettings);

        /// <summary>
        /// Generate content with multimodal inputs.
        /// </summary>
        /// <param name="model">
        /// Required. The fully qualified name of the publisher model or tuned model
        /// endpoint to use.
        /// 
        /// Publisher model format:
        /// `projects/{project}/locations/{location}/publishers/*/models/*`
        /// 
        /// Tuned model endpoint format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="contents">
        /// Required. The content of the current conversation with the model.
        /// 
        /// For single-turn queries, this is a single instance. For multi-turn queries,
        /// this is a repeated field that contains conversation history + latest
        /// request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateContentResponse> GenerateContentAsync(string model, scg::IEnumerable<Content> contents, st::CancellationToken cancellationToken) =>
            GenerateContentAsync(model, contents, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Server streaming methods for
        /// <see cref="StreamGenerateContent(GenerateContentRequest,gaxgrpc::CallSettings)"/>.
        /// </summary>
        public abstract partial class StreamGenerateContentStream : gaxgrpc::ServerStreamingBase<GenerateContentResponse>
        {
        }

        /// <summary>
        /// Generate content with multimodal inputs with streaming support.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual StreamGenerateContentStream StreamGenerateContent(GenerateContentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generate content with multimodal inputs with streaming support.
        /// </summary>
        /// <param name="model">
        /// Required. The fully qualified name of the publisher model or tuned model
        /// endpoint to use.
        /// 
        /// Publisher model format:
        /// `projects/{project}/locations/{location}/publishers/*/models/*`
        /// 
        /// Tuned model endpoint format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="contents">
        /// Required. The content of the current conversation with the model.
        /// 
        /// For single-turn queries, this is a single instance. For multi-turn queries,
        /// this is a repeated field that contains conversation history + latest
        /// request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual StreamGenerateContentStream StreamGenerateContent(string model, scg::IEnumerable<Content> contents, gaxgrpc::CallSettings callSettings = null) =>
            StreamGenerateContent(new GenerateContentRequest
            {
                Model = gax::GaxPreconditions.CheckNotNullOrEmpty(model, nameof(model)),
                Contents =
                {
                    gax::GaxPreconditions.CheckNotNull(contents, nameof(contents)),
                },
            }, callSettings);

        /// <summary>
        /// Server streaming methods for <see cref="ChatCompletions(ChatCompletionsRequest,gaxgrpc::CallSettings)"/>.
        /// </summary>
        public abstract partial class ChatCompletionsStream : gaxgrpc::ServerStreamingBase<ga::HttpBody>
        {
        }

        /// <summary>
        /// Exposes an OpenAI-compatible endpoint for chat completions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ChatCompletionsStream ChatCompletions(ChatCompletionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exposes an OpenAI-compatible endpoint for chat completions.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the endpoint requested to serve the prediction.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="httpBody">
        /// Optional. The prediction input. Supports HTTP headers and arbitrary data
        /// payload.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ChatCompletionsStream ChatCompletions(string endpoint, ga::HttpBody httpBody, gaxgrpc::CallSettings callSettings = null) =>
            ChatCompletions(new ChatCompletionsRequest
            {
                Endpoint = gax::GaxPreconditions.CheckNotNullOrEmpty(endpoint, nameof(endpoint)),
                HttpBody = httpBody,
            }, callSettings);

        /// <summary>
        /// Exposes an OpenAI-compatible endpoint for chat completions.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the endpoint requested to serve the prediction.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="httpBody">
        /// Optional. The prediction input. Supports HTTP headers and arbitrary data
        /// payload.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ChatCompletionsStream ChatCompletions(EndpointName endpoint, ga::HttpBody httpBody, gaxgrpc::CallSettings callSettings = null) =>
            ChatCompletions(new ChatCompletionsRequest
            {
                EndpointAsEndpointName = gax::GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint)),
                HttpBody = httpBody,
            }, callSettings);
    }

    /// <summary>PredictionService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service for online predictions and explanations.
    /// </remarks>
    public sealed partial class PredictionServiceClientImpl : PredictionServiceClient
    {
        private readonly gaxgrpc::ApiCall<PredictRequest, PredictResponse> _callPredict;

        private readonly gaxgrpc::ApiCall<RawPredictRequest, ga::HttpBody> _callRawPredict;

        private readonly gaxgrpc::ApiServerStreamingCall<StreamRawPredictRequest, ga::HttpBody> _callStreamRawPredict;

        private readonly gaxgrpc::ApiCall<DirectPredictRequest, DirectPredictResponse> _callDirectPredict;

        private readonly gaxgrpc::ApiCall<DirectRawPredictRequest, DirectRawPredictResponse> _callDirectRawPredict;

        private readonly gaxgrpc::ApiBidirectionalStreamingCall<StreamDirectPredictRequest, StreamDirectPredictResponse> _callStreamDirectPredict;

        private readonly gaxgrpc::ApiBidirectionalStreamingCall<StreamDirectRawPredictRequest, StreamDirectRawPredictResponse> _callStreamDirectRawPredict;

        private readonly gaxgrpc::ApiBidirectionalStreamingCall<StreamingPredictRequest, StreamingPredictResponse> _callStreamingPredict;

        private readonly gaxgrpc::ApiServerStreamingCall<StreamingPredictRequest, StreamingPredictResponse> _callServerStreamingPredict;

        private readonly gaxgrpc::ApiBidirectionalStreamingCall<StreamingRawPredictRequest, StreamingRawPredictResponse> _callStreamingRawPredict;

        private readonly gaxgrpc::ApiCall<ExplainRequest, ExplainResponse> _callExplain;

        private readonly gaxgrpc::ApiCall<CountTokensRequest, CountTokensResponse> _callCountTokens;

        private readonly gaxgrpc::ApiCall<GenerateContentRequest, GenerateContentResponse> _callGenerateContent;

        private readonly gaxgrpc::ApiServerStreamingCall<GenerateContentRequest, GenerateContentResponse> _callStreamGenerateContent;

        private readonly gaxgrpc::ApiServerStreamingCall<ChatCompletionsRequest, ga::HttpBody> _callChatCompletions;

        /// <summary>
        /// Constructs a client wrapper for the PredictionService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="PredictionServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public PredictionServiceClientImpl(PredictionService.PredictionServiceClient grpcClient, PredictionServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            PredictionServiceSettings effectiveSettings = settings ?? PredictionServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callPredict = clientHelper.BuildApiCall<PredictRequest, PredictResponse>("Predict", grpcClient.PredictAsync, grpcClient.Predict, effectiveSettings.PredictSettings).WithGoogleRequestParam("endpoint", request => request.Endpoint);
            Modify_ApiCall(ref _callPredict);
            Modify_PredictApiCall(ref _callPredict);
            _callRawPredict = clientHelper.BuildApiCall<RawPredictRequest, ga::HttpBody>("RawPredict", grpcClient.RawPredictAsync, grpcClient.RawPredict, effectiveSettings.RawPredictSettings).WithGoogleRequestParam("endpoint", request => request.Endpoint);
            Modify_ApiCall(ref _callRawPredict);
            Modify_RawPredictApiCall(ref _callRawPredict);
            _callStreamRawPredict = clientHelper.BuildApiCall<StreamRawPredictRequest, ga::HttpBody>("StreamRawPredict", grpcClient.StreamRawPredict, effectiveSettings.StreamRawPredictSettings).WithGoogleRequestParam("endpoint", request => request.Endpoint);
            Modify_ApiCall(ref _callStreamRawPredict);
            Modify_StreamRawPredictApiCall(ref _callStreamRawPredict);
            _callDirectPredict = clientHelper.BuildApiCall<DirectPredictRequest, DirectPredictResponse>("DirectPredict", grpcClient.DirectPredictAsync, grpcClient.DirectPredict, effectiveSettings.DirectPredictSettings).WithGoogleRequestParam("endpoint", request => request.Endpoint);
            Modify_ApiCall(ref _callDirectPredict);
            Modify_DirectPredictApiCall(ref _callDirectPredict);
            _callDirectRawPredict = clientHelper.BuildApiCall<DirectRawPredictRequest, DirectRawPredictResponse>("DirectRawPredict", grpcClient.DirectRawPredictAsync, grpcClient.DirectRawPredict, effectiveSettings.DirectRawPredictSettings).WithGoogleRequestParam("endpoint", request => request.Endpoint);
            Modify_ApiCall(ref _callDirectRawPredict);
            Modify_DirectRawPredictApiCall(ref _callDirectRawPredict);
            _callStreamDirectPredict = clientHelper.BuildApiCall<StreamDirectPredictRequest, StreamDirectPredictResponse>("StreamDirectPredict", grpcClient.StreamDirectPredict, effectiveSettings.StreamDirectPredictSettings, effectiveSettings.StreamDirectPredictStreamingSettings);
            Modify_ApiCall(ref _callStreamDirectPredict);
            Modify_StreamDirectPredictApiCall(ref _callStreamDirectPredict);
            _callStreamDirectRawPredict = clientHelper.BuildApiCall<StreamDirectRawPredictRequest, StreamDirectRawPredictResponse>("StreamDirectRawPredict", grpcClient.StreamDirectRawPredict, effectiveSettings.StreamDirectRawPredictSettings, effectiveSettings.StreamDirectRawPredictStreamingSettings);
            Modify_ApiCall(ref _callStreamDirectRawPredict);
            Modify_StreamDirectRawPredictApiCall(ref _callStreamDirectRawPredict);
            _callStreamingPredict = clientHelper.BuildApiCall<StreamingPredictRequest, StreamingPredictResponse>("StreamingPredict", grpcClient.StreamingPredict, effectiveSettings.StreamingPredictSettings, effectiveSettings.StreamingPredictStreamingSettings);
            Modify_ApiCall(ref _callStreamingPredict);
            Modify_StreamingPredictApiCall(ref _callStreamingPredict);
            _callServerStreamingPredict = clientHelper.BuildApiCall<StreamingPredictRequest, StreamingPredictResponse>("ServerStreamingPredict", grpcClient.ServerStreamingPredict, effectiveSettings.ServerStreamingPredictSettings).WithGoogleRequestParam("endpoint", request => request.Endpoint);
            Modify_ApiCall(ref _callServerStreamingPredict);
            Modify_ServerStreamingPredictApiCall(ref _callServerStreamingPredict);
            _callStreamingRawPredict = clientHelper.BuildApiCall<StreamingRawPredictRequest, StreamingRawPredictResponse>("StreamingRawPredict", grpcClient.StreamingRawPredict, effectiveSettings.StreamingRawPredictSettings, effectiveSettings.StreamingRawPredictStreamingSettings);
            Modify_ApiCall(ref _callStreamingRawPredict);
            Modify_StreamingRawPredictApiCall(ref _callStreamingRawPredict);
            _callExplain = clientHelper.BuildApiCall<ExplainRequest, ExplainResponse>("Explain", grpcClient.ExplainAsync, grpcClient.Explain, effectiveSettings.ExplainSettings).WithGoogleRequestParam("endpoint", request => request.Endpoint);
            Modify_ApiCall(ref _callExplain);
            Modify_ExplainApiCall(ref _callExplain);
            _callCountTokens = clientHelper.BuildApiCall<CountTokensRequest, CountTokensResponse>("CountTokens", grpcClient.CountTokensAsync, grpcClient.CountTokens, effectiveSettings.CountTokensSettings).WithGoogleRequestParam("endpoint", request => request.Endpoint);
            Modify_ApiCall(ref _callCountTokens);
            Modify_CountTokensApiCall(ref _callCountTokens);
            _callGenerateContent = clientHelper.BuildApiCall<GenerateContentRequest, GenerateContentResponse>("GenerateContent", grpcClient.GenerateContentAsync, grpcClient.GenerateContent, effectiveSettings.GenerateContentSettings).WithGoogleRequestParam("model", request => request.Model);
            Modify_ApiCall(ref _callGenerateContent);
            Modify_GenerateContentApiCall(ref _callGenerateContent);
            _callStreamGenerateContent = clientHelper.BuildApiCall<GenerateContentRequest, GenerateContentResponse>("StreamGenerateContent", grpcClient.StreamGenerateContent, effectiveSettings.StreamGenerateContentSettings).WithGoogleRequestParam("model", request => request.Model);
            Modify_ApiCall(ref _callStreamGenerateContent);
            Modify_StreamGenerateContentApiCall(ref _callStreamGenerateContent);
            _callChatCompletions = clientHelper.BuildApiCall<ChatCompletionsRequest, ga::HttpBody>("ChatCompletions", grpcClient.ChatCompletions, effectiveSettings.ChatCompletionsSettings).WithGoogleRequestParam("endpoint", request => request.Endpoint);
            Modify_ApiCall(ref _callChatCompletions);
            Modify_ChatCompletionsApiCall(ref _callChatCompletions);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiBidirectionalStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiServerStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_PredictApiCall(ref gaxgrpc::ApiCall<PredictRequest, PredictResponse> call);

        partial void Modify_RawPredictApiCall(ref gaxgrpc::ApiCall<RawPredictRequest, ga::HttpBody> call);

        partial void Modify_StreamRawPredictApiCall(ref gaxgrpc::ApiServerStreamingCall<StreamRawPredictRequest, ga::HttpBody> call);

        partial void Modify_DirectPredictApiCall(ref gaxgrpc::ApiCall<DirectPredictRequest, DirectPredictResponse> call);

        partial void Modify_DirectRawPredictApiCall(ref gaxgrpc::ApiCall<DirectRawPredictRequest, DirectRawPredictResponse> call);

        partial void Modify_StreamDirectPredictApiCall(ref gaxgrpc::ApiBidirectionalStreamingCall<StreamDirectPredictRequest, StreamDirectPredictResponse> call);

        partial void Modify_StreamDirectRawPredictApiCall(ref gaxgrpc::ApiBidirectionalStreamingCall<StreamDirectRawPredictRequest, StreamDirectRawPredictResponse> call);

        partial void Modify_StreamingPredictApiCall(ref gaxgrpc::ApiBidirectionalStreamingCall<StreamingPredictRequest, StreamingPredictResponse> call);

        partial void Modify_ServerStreamingPredictApiCall(ref gaxgrpc::ApiServerStreamingCall<StreamingPredictRequest, StreamingPredictResponse> call);

        partial void Modify_StreamingRawPredictApiCall(ref gaxgrpc::ApiBidirectionalStreamingCall<StreamingRawPredictRequest, StreamingRawPredictResponse> call);

        partial void Modify_ExplainApiCall(ref gaxgrpc::ApiCall<ExplainRequest, ExplainResponse> call);

        partial void Modify_CountTokensApiCall(ref gaxgrpc::ApiCall<CountTokensRequest, CountTokensResponse> call);

        partial void Modify_GenerateContentApiCall(ref gaxgrpc::ApiCall<GenerateContentRequest, GenerateContentResponse> call);

        partial void Modify_StreamGenerateContentApiCall(ref gaxgrpc::ApiServerStreamingCall<GenerateContentRequest, GenerateContentResponse> call);

        partial void Modify_ChatCompletionsApiCall(ref gaxgrpc::ApiServerStreamingCall<ChatCompletionsRequest, ga::HttpBody> call);

        partial void OnConstruction(PredictionService.PredictionServiceClient grpcClient, PredictionServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC PredictionService client</summary>
        public override PredictionService.PredictionServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_PredictRequest(ref PredictRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RawPredictRequest(ref RawPredictRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StreamRawPredictRequest(ref StreamRawPredictRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DirectPredictRequest(ref DirectPredictRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DirectRawPredictRequest(ref DirectRawPredictRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StreamDirectPredictRequestCallSettings(ref gaxgrpc::CallSettings settings);

        partial void Modify_StreamDirectPredictRequestRequest(ref StreamDirectPredictRequest request);

        partial void Modify_StreamDirectRawPredictRequestCallSettings(ref gaxgrpc::CallSettings settings);

        partial void Modify_StreamDirectRawPredictRequestRequest(ref StreamDirectRawPredictRequest request);

        partial void Modify_StreamingPredictRequestCallSettings(ref gaxgrpc::CallSettings settings);

        partial void Modify_StreamingPredictRequestRequest(ref StreamingPredictRequest request);

        partial void Modify_StreamingPredictRequest(ref StreamingPredictRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StreamingRawPredictRequestCallSettings(ref gaxgrpc::CallSettings settings);

        partial void Modify_StreamingRawPredictRequestRequest(ref StreamingRawPredictRequest request);

        partial void Modify_ExplainRequest(ref ExplainRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CountTokensRequest(ref CountTokensRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateContentRequest(ref GenerateContentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ChatCompletionsRequest(ref ChatCompletionsRequest request, ref gaxgrpc::CallSettings settings);

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
        /// * `X-Vertex-AI-Endpoint-Id`: ID of the
        /// [Endpoint][google.cloud.aiplatform.v1beta1.Endpoint] that served this
        /// prediction.
        /// 
        /// * `X-Vertex-AI-Deployed-Model-Id`: ID of the Endpoint's
        /// [DeployedModel][google.cloud.aiplatform.v1beta1.DeployedModel] that served
        /// this prediction.
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
        /// * `X-Vertex-AI-Endpoint-Id`: ID of the
        /// [Endpoint][google.cloud.aiplatform.v1beta1.Endpoint] that served this
        /// prediction.
        /// 
        /// * `X-Vertex-AI-Deployed-Model-Id`: ID of the Endpoint's
        /// [DeployedModel][google.cloud.aiplatform.v1beta1.DeployedModel] that served
        /// this prediction.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ga::HttpBody> RawPredictAsync(RawPredictRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RawPredictRequest(ref request, ref callSettings);
            return _callRawPredict.Async(request, callSettings);
        }

        internal sealed partial class StreamRawPredictStreamImpl : StreamRawPredictStream
        {
            /// <summary>Construct the server streaming method for <c>StreamRawPredict</c>.</summary>
            /// <param name="call">The underlying gRPC server streaming call.</param>
            public StreamRawPredictStreamImpl(grpccore::AsyncServerStreamingCall<ga::HttpBody> call) => GrpcCall = call;

            public override grpccore::AsyncServerStreamingCall<ga::HttpBody> GrpcCall { get; }
        }

        /// <summary>
        /// Perform a streaming online prediction with an arbitrary HTTP payload.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public override PredictionServiceClient.StreamRawPredictStream StreamRawPredict(StreamRawPredictRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StreamRawPredictRequest(ref request, ref callSettings);
            return new StreamRawPredictStreamImpl(_callStreamRawPredict.Call(request, callSettings));
        }

        /// <summary>
        /// Perform an unary online prediction request to a gRPC model server for
        /// Vertex first-party products and frameworks.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DirectPredictResponse DirectPredict(DirectPredictRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DirectPredictRequest(ref request, ref callSettings);
            return _callDirectPredict.Sync(request, callSettings);
        }

        /// <summary>
        /// Perform an unary online prediction request to a gRPC model server for
        /// Vertex first-party products and frameworks.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DirectPredictResponse> DirectPredictAsync(DirectPredictRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DirectPredictRequest(ref request, ref callSettings);
            return _callDirectPredict.Async(request, callSettings);
        }

        /// <summary>
        /// Perform an unary online prediction request to a gRPC model server for
        /// custom containers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DirectRawPredictResponse DirectRawPredict(DirectRawPredictRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DirectRawPredictRequest(ref request, ref callSettings);
            return _callDirectRawPredict.Sync(request, callSettings);
        }

        /// <summary>
        /// Perform an unary online prediction request to a gRPC model server for
        /// custom containers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DirectRawPredictResponse> DirectRawPredictAsync(DirectRawPredictRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DirectRawPredictRequest(ref request, ref callSettings);
            return _callDirectRawPredict.Async(request, callSettings);
        }

        internal sealed partial class StreamDirectPredictStreamImpl : StreamDirectPredictStream
        {
            /// <summary>Construct the bidirectional streaming method for <c>StreamDirectPredict</c>.</summary>
            /// <param name="service">The service containing this streaming method.</param>
            /// <param name="call">The underlying gRPC duplex streaming call.</param>
            /// <param name="writeBuffer">
            /// The <see cref="gaxgrpc::BufferedClientStreamWriter{StreamDirectPredictRequest}"/> instance associated
            /// with this streaming call.
            /// </param>
            public StreamDirectPredictStreamImpl(PredictionServiceClientImpl service, grpccore::AsyncDuplexStreamingCall<StreamDirectPredictRequest, StreamDirectPredictResponse> call, gaxgrpc::BufferedClientStreamWriter<StreamDirectPredictRequest> writeBuffer)
            {
                _service = service;
                GrpcCall = call;
                _writeBuffer = writeBuffer;
            }

            private PredictionServiceClientImpl _service;

            private gaxgrpc::BufferedClientStreamWriter<StreamDirectPredictRequest> _writeBuffer;

            public override grpccore::AsyncDuplexStreamingCall<StreamDirectPredictRequest, StreamDirectPredictResponse> GrpcCall { get; }

            private StreamDirectPredictRequest ModifyRequest(StreamDirectPredictRequest request)
            {
                _service.Modify_StreamDirectPredictRequestRequest(ref request);
                return request;
            }

            public override stt::Task TryWriteAsync(StreamDirectPredictRequest message) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message));

            public override stt::Task WriteAsync(StreamDirectPredictRequest message) =>
                _writeBuffer.WriteAsync(ModifyRequest(message));

            public override stt::Task TryWriteAsync(StreamDirectPredictRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message), options);

            public override stt::Task WriteAsync(StreamDirectPredictRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.WriteAsync(ModifyRequest(message), options);

            public override stt::Task TryWriteCompleteAsync() => _writeBuffer.TryWriteCompleteAsync();

            public override stt::Task WriteCompleteAsync() => _writeBuffer.WriteCompleteAsync();
        }

        /// <summary>
        /// Perform a streaming online prediction request to a gRPC model server for
        /// Vertex first-party products and frameworks.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public override PredictionServiceClient.StreamDirectPredictStream StreamDirectPredict(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null)
        {
            Modify_StreamDirectPredictRequestCallSettings(ref callSettings);
            gaxgrpc::BidirectionalStreamingSettings effectiveStreamingSettings = streamingSettings ?? _callStreamDirectPredict.StreamingSettings;
            grpccore::AsyncDuplexStreamingCall<StreamDirectPredictRequest, StreamDirectPredictResponse> call = _callStreamDirectPredict.Call(callSettings);
            gaxgrpc::BufferedClientStreamWriter<StreamDirectPredictRequest> writeBuffer = new gaxgrpc::BufferedClientStreamWriter<StreamDirectPredictRequest>(call.RequestStream, effectiveStreamingSettings.BufferedClientWriterCapacity);
            return new StreamDirectPredictStreamImpl(this, call, writeBuffer);
        }

        internal sealed partial class StreamDirectRawPredictStreamImpl : StreamDirectRawPredictStream
        {
            /// <summary>Construct the bidirectional streaming method for <c>StreamDirectRawPredict</c>.</summary>
            /// <param name="service">The service containing this streaming method.</param>
            /// <param name="call">The underlying gRPC duplex streaming call.</param>
            /// <param name="writeBuffer">
            /// The <see cref="gaxgrpc::BufferedClientStreamWriter{StreamDirectRawPredictRequest}"/> instance associated
            /// with this streaming call.
            /// </param>
            public StreamDirectRawPredictStreamImpl(PredictionServiceClientImpl service, grpccore::AsyncDuplexStreamingCall<StreamDirectRawPredictRequest, StreamDirectRawPredictResponse> call, gaxgrpc::BufferedClientStreamWriter<StreamDirectRawPredictRequest> writeBuffer)
            {
                _service = service;
                GrpcCall = call;
                _writeBuffer = writeBuffer;
            }

            private PredictionServiceClientImpl _service;

            private gaxgrpc::BufferedClientStreamWriter<StreamDirectRawPredictRequest> _writeBuffer;

            public override grpccore::AsyncDuplexStreamingCall<StreamDirectRawPredictRequest, StreamDirectRawPredictResponse> GrpcCall { get; }

            private StreamDirectRawPredictRequest ModifyRequest(StreamDirectRawPredictRequest request)
            {
                _service.Modify_StreamDirectRawPredictRequestRequest(ref request);
                return request;
            }

            public override stt::Task TryWriteAsync(StreamDirectRawPredictRequest message) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message));

            public override stt::Task WriteAsync(StreamDirectRawPredictRequest message) =>
                _writeBuffer.WriteAsync(ModifyRequest(message));

            public override stt::Task TryWriteAsync(StreamDirectRawPredictRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message), options);

            public override stt::Task WriteAsync(StreamDirectRawPredictRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.WriteAsync(ModifyRequest(message), options);

            public override stt::Task TryWriteCompleteAsync() => _writeBuffer.TryWriteCompleteAsync();

            public override stt::Task WriteCompleteAsync() => _writeBuffer.WriteCompleteAsync();
        }

        /// <summary>
        /// Perform a streaming online prediction request to a gRPC model server for
        /// custom containers.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public override PredictionServiceClient.StreamDirectRawPredictStream StreamDirectRawPredict(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null)
        {
            Modify_StreamDirectRawPredictRequestCallSettings(ref callSettings);
            gaxgrpc::BidirectionalStreamingSettings effectiveStreamingSettings = streamingSettings ?? _callStreamDirectRawPredict.StreamingSettings;
            grpccore::AsyncDuplexStreamingCall<StreamDirectRawPredictRequest, StreamDirectRawPredictResponse> call = _callStreamDirectRawPredict.Call(callSettings);
            gaxgrpc::BufferedClientStreamWriter<StreamDirectRawPredictRequest> writeBuffer = new gaxgrpc::BufferedClientStreamWriter<StreamDirectRawPredictRequest>(call.RequestStream, effectiveStreamingSettings.BufferedClientWriterCapacity);
            return new StreamDirectRawPredictStreamImpl(this, call, writeBuffer);
        }

        internal sealed partial class StreamingPredictStreamImpl : StreamingPredictStream
        {
            /// <summary>Construct the bidirectional streaming method for <c>StreamingPredict</c>.</summary>
            /// <param name="service">The service containing this streaming method.</param>
            /// <param name="call">The underlying gRPC duplex streaming call.</param>
            /// <param name="writeBuffer">
            /// The <see cref="gaxgrpc::BufferedClientStreamWriter{StreamingPredictRequest}"/> instance associated with
            /// this streaming call.
            /// </param>
            public StreamingPredictStreamImpl(PredictionServiceClientImpl service, grpccore::AsyncDuplexStreamingCall<StreamingPredictRequest, StreamingPredictResponse> call, gaxgrpc::BufferedClientStreamWriter<StreamingPredictRequest> writeBuffer)
            {
                _service = service;
                GrpcCall = call;
                _writeBuffer = writeBuffer;
            }

            private PredictionServiceClientImpl _service;

            private gaxgrpc::BufferedClientStreamWriter<StreamingPredictRequest> _writeBuffer;

            public override grpccore::AsyncDuplexStreamingCall<StreamingPredictRequest, StreamingPredictResponse> GrpcCall { get; }

            private StreamingPredictRequest ModifyRequest(StreamingPredictRequest request)
            {
                _service.Modify_StreamingPredictRequestRequest(ref request);
                return request;
            }

            public override stt::Task TryWriteAsync(StreamingPredictRequest message) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message));

            public override stt::Task WriteAsync(StreamingPredictRequest message) =>
                _writeBuffer.WriteAsync(ModifyRequest(message));

            public override stt::Task TryWriteAsync(StreamingPredictRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message), options);

            public override stt::Task WriteAsync(StreamingPredictRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.WriteAsync(ModifyRequest(message), options);

            public override stt::Task TryWriteCompleteAsync() => _writeBuffer.TryWriteCompleteAsync();

            public override stt::Task WriteCompleteAsync() => _writeBuffer.WriteCompleteAsync();
        }

        /// <summary>
        /// Perform a streaming online prediction request for Vertex first-party
        /// products and frameworks.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public override PredictionServiceClient.StreamingPredictStream StreamingPredict(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null)
        {
            Modify_StreamingPredictRequestCallSettings(ref callSettings);
            gaxgrpc::BidirectionalStreamingSettings effectiveStreamingSettings = streamingSettings ?? _callStreamingPredict.StreamingSettings;
            grpccore::AsyncDuplexStreamingCall<StreamingPredictRequest, StreamingPredictResponse> call = _callStreamingPredict.Call(callSettings);
            gaxgrpc::BufferedClientStreamWriter<StreamingPredictRequest> writeBuffer = new gaxgrpc::BufferedClientStreamWriter<StreamingPredictRequest>(call.RequestStream, effectiveStreamingSettings.BufferedClientWriterCapacity);
            return new StreamingPredictStreamImpl(this, call, writeBuffer);
        }

        internal sealed partial class ServerStreamingPredictStreamImpl : ServerStreamingPredictStream
        {
            /// <summary>Construct the server streaming method for <c>ServerStreamingPredict</c>.</summary>
            /// <param name="call">The underlying gRPC server streaming call.</param>
            public ServerStreamingPredictStreamImpl(grpccore::AsyncServerStreamingCall<StreamingPredictResponse> call) => GrpcCall = call;

            public override grpccore::AsyncServerStreamingCall<StreamingPredictResponse> GrpcCall { get; }
        }

        /// <summary>
        /// Perform a server-side streaming online prediction request for Vertex
        /// LLM streaming.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public override PredictionServiceClient.ServerStreamingPredictStream ServerStreamingPredict(StreamingPredictRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StreamingPredictRequest(ref request, ref callSettings);
            return new ServerStreamingPredictStreamImpl(_callServerStreamingPredict.Call(request, callSettings));
        }

        internal sealed partial class StreamingRawPredictStreamImpl : StreamingRawPredictStream
        {
            /// <summary>Construct the bidirectional streaming method for <c>StreamingRawPredict</c>.</summary>
            /// <param name="service">The service containing this streaming method.</param>
            /// <param name="call">The underlying gRPC duplex streaming call.</param>
            /// <param name="writeBuffer">
            /// The <see cref="gaxgrpc::BufferedClientStreamWriter{StreamingRawPredictRequest}"/> instance associated
            /// with this streaming call.
            /// </param>
            public StreamingRawPredictStreamImpl(PredictionServiceClientImpl service, grpccore::AsyncDuplexStreamingCall<StreamingRawPredictRequest, StreamingRawPredictResponse> call, gaxgrpc::BufferedClientStreamWriter<StreamingRawPredictRequest> writeBuffer)
            {
                _service = service;
                GrpcCall = call;
                _writeBuffer = writeBuffer;
            }

            private PredictionServiceClientImpl _service;

            private gaxgrpc::BufferedClientStreamWriter<StreamingRawPredictRequest> _writeBuffer;

            public override grpccore::AsyncDuplexStreamingCall<StreamingRawPredictRequest, StreamingRawPredictResponse> GrpcCall { get; }

            private StreamingRawPredictRequest ModifyRequest(StreamingRawPredictRequest request)
            {
                _service.Modify_StreamingRawPredictRequestRequest(ref request);
                return request;
            }

            public override stt::Task TryWriteAsync(StreamingRawPredictRequest message) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message));

            public override stt::Task WriteAsync(StreamingRawPredictRequest message) =>
                _writeBuffer.WriteAsync(ModifyRequest(message));

            public override stt::Task TryWriteAsync(StreamingRawPredictRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message), options);

            public override stt::Task WriteAsync(StreamingRawPredictRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.WriteAsync(ModifyRequest(message), options);

            public override stt::Task TryWriteCompleteAsync() => _writeBuffer.TryWriteCompleteAsync();

            public override stt::Task WriteCompleteAsync() => _writeBuffer.WriteCompleteAsync();
        }

        /// <summary>
        /// Perform a streaming online prediction request through gRPC.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public override PredictionServiceClient.StreamingRawPredictStream StreamingRawPredict(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null)
        {
            Modify_StreamingRawPredictRequestCallSettings(ref callSettings);
            gaxgrpc::BidirectionalStreamingSettings effectiveStreamingSettings = streamingSettings ?? _callStreamingRawPredict.StreamingSettings;
            grpccore::AsyncDuplexStreamingCall<StreamingRawPredictRequest, StreamingRawPredictResponse> call = _callStreamingRawPredict.Call(callSettings);
            gaxgrpc::BufferedClientStreamWriter<StreamingRawPredictRequest> writeBuffer = new gaxgrpc::BufferedClientStreamWriter<StreamingRawPredictRequest>(call.RequestStream, effectiveStreamingSettings.BufferedClientWriterCapacity);
            return new StreamingRawPredictStreamImpl(this, call, writeBuffer);
        }

        /// <summary>
        /// Perform an online explanation.
        /// 
        /// If
        /// [deployed_model_id][google.cloud.aiplatform.v1beta1.ExplainRequest.deployed_model_id]
        /// is specified, the corresponding DeployModel must have
        /// [explanation_spec][google.cloud.aiplatform.v1beta1.DeployedModel.explanation_spec]
        /// populated. If
        /// [deployed_model_id][google.cloud.aiplatform.v1beta1.ExplainRequest.deployed_model_id]
        /// is not specified, all DeployedModels must have
        /// [explanation_spec][google.cloud.aiplatform.v1beta1.DeployedModel.explanation_spec]
        /// populated.
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
        /// If
        /// [deployed_model_id][google.cloud.aiplatform.v1beta1.ExplainRequest.deployed_model_id]
        /// is specified, the corresponding DeployModel must have
        /// [explanation_spec][google.cloud.aiplatform.v1beta1.DeployedModel.explanation_spec]
        /// populated. If
        /// [deployed_model_id][google.cloud.aiplatform.v1beta1.ExplainRequest.deployed_model_id]
        /// is not specified, all DeployedModels must have
        /// [explanation_spec][google.cloud.aiplatform.v1beta1.DeployedModel.explanation_spec]
        /// populated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ExplainResponse> ExplainAsync(ExplainRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExplainRequest(ref request, ref callSettings);
            return _callExplain.Async(request, callSettings);
        }

        /// <summary>
        /// Perform a token counting.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CountTokensResponse CountTokens(CountTokensRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CountTokensRequest(ref request, ref callSettings);
            return _callCountTokens.Sync(request, callSettings);
        }

        /// <summary>
        /// Perform a token counting.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CountTokensResponse> CountTokensAsync(CountTokensRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CountTokensRequest(ref request, ref callSettings);
            return _callCountTokens.Async(request, callSettings);
        }

        /// <summary>
        /// Generate content with multimodal inputs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateContentResponse GenerateContent(GenerateContentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateContentRequest(ref request, ref callSettings);
            return _callGenerateContent.Sync(request, callSettings);
        }

        /// <summary>
        /// Generate content with multimodal inputs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateContentResponse> GenerateContentAsync(GenerateContentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateContentRequest(ref request, ref callSettings);
            return _callGenerateContent.Async(request, callSettings);
        }

        internal sealed partial class StreamGenerateContentStreamImpl : StreamGenerateContentStream
        {
            /// <summary>Construct the server streaming method for <c>StreamGenerateContent</c>.</summary>
            /// <param name="call">The underlying gRPC server streaming call.</param>
            public StreamGenerateContentStreamImpl(grpccore::AsyncServerStreamingCall<GenerateContentResponse> call) => GrpcCall = call;

            public override grpccore::AsyncServerStreamingCall<GenerateContentResponse> GrpcCall { get; }
        }

        /// <summary>
        /// Generate content with multimodal inputs with streaming support.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public override PredictionServiceClient.StreamGenerateContentStream StreamGenerateContent(GenerateContentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateContentRequest(ref request, ref callSettings);
            return new StreamGenerateContentStreamImpl(_callStreamGenerateContent.Call(request, callSettings));
        }

        internal sealed partial class ChatCompletionsStreamImpl : ChatCompletionsStream
        {
            /// <summary>Construct the server streaming method for <c>ChatCompletions</c>.</summary>
            /// <param name="call">The underlying gRPC server streaming call.</param>
            public ChatCompletionsStreamImpl(grpccore::AsyncServerStreamingCall<ga::HttpBody> call) => GrpcCall = call;

            public override grpccore::AsyncServerStreamingCall<ga::HttpBody> GrpcCall { get; }
        }

        /// <summary>
        /// Exposes an OpenAI-compatible endpoint for chat completions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public override PredictionServiceClient.ChatCompletionsStream ChatCompletions(ChatCompletionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ChatCompletionsRequest(ref request, ref callSettings);
            return new ChatCompletionsStreamImpl(_callChatCompletions.Call(request, callSettings));
        }
    }

    public static partial class PredictionService
    {
        public partial class PredictionServiceClient
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
