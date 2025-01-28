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
            ListModelVersionsSettings = existing.ListModelVersionsSettings;
            ListModelVersionCheckpointsSettings = existing.ListModelVersionCheckpointsSettings;
            UpdateModelSettings = existing.UpdateModelSettings;
            UpdateExplanationDatasetSettings = existing.UpdateExplanationDatasetSettings;
            UpdateExplanationDatasetOperationsSettings = existing.UpdateExplanationDatasetOperationsSettings.Clone();
            DeleteModelSettings = existing.DeleteModelSettings;
            DeleteModelOperationsSettings = existing.DeleteModelOperationsSettings.Clone();
            DeleteModelVersionSettings = existing.DeleteModelVersionSettings;
            DeleteModelVersionOperationsSettings = existing.DeleteModelVersionOperationsSettings.Clone();
            MergeVersionAliasesSettings = existing.MergeVersionAliasesSettings;
            ExportModelSettings = existing.ExportModelSettings;
            ExportModelOperationsSettings = existing.ExportModelOperationsSettings.Clone();
            CopyModelSettings = existing.CopyModelSettings;
            CopyModelOperationsSettings = existing.CopyModelOperationsSettings.Clone();
            ImportModelEvaluationSettings = existing.ImportModelEvaluationSettings;
            BatchImportModelEvaluationSlicesSettings = existing.BatchImportModelEvaluationSlicesSettings;
            BatchImportEvaluatedAnnotationsSettings = existing.BatchImportEvaluatedAnnotationsSettings;
            GetModelEvaluationSettings = existing.GetModelEvaluationSettings;
            ListModelEvaluationsSettings = existing.ListModelEvaluationsSettings;
            GetModelEvaluationSliceSettings = existing.GetModelEvaluationSliceSettings;
            ListModelEvaluationSlicesSettings = existing.ListModelEvaluationSlicesSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
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
        /// <c>ModelServiceClient.ListModelVersions</c> and <c>ModelServiceClient.ListModelVersionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListModelVersionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelServiceClient.ListModelVersionCheckpoints</c> and
        /// <c>ModelServiceClient.ListModelVersionCheckpointsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListModelVersionCheckpointsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

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
        /// <c>ModelServiceClient.UpdateExplanationDataset</c> and <c>ModelServiceClient.UpdateExplanationDatasetAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateExplanationDatasetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ModelServiceClient.UpdateExplanationDataset</c> and
        /// <c>ModelServiceClient.UpdateExplanationDatasetAsync</c>.
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
        public lro::OperationsSettings UpdateExplanationDatasetOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

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
        /// <c>ModelServiceClient.DeleteModelVersion</c> and <c>ModelServiceClient.DeleteModelVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteModelVersionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ModelServiceClient.DeleteModelVersion</c> and
        /// <c>ModelServiceClient.DeleteModelVersionAsync</c>.
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
        public lro::OperationsSettings DeleteModelVersionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelServiceClient.MergeVersionAliases</c> and <c>ModelServiceClient.MergeVersionAliasesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MergeVersionAliasesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

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
        /// <c>ModelServiceClient.CopyModel</c> and <c>ModelServiceClient.CopyModelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CopyModelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ModelServiceClient.CopyModel</c> and
        /// <c>ModelServiceClient.CopyModelAsync</c>.
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
        public lro::OperationsSettings CopyModelOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelServiceClient.ImportModelEvaluation</c> and <c>ModelServiceClient.ImportModelEvaluationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ImportModelEvaluationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelServiceClient.BatchImportModelEvaluationSlices</c> and
        /// <c>ModelServiceClient.BatchImportModelEvaluationSlicesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchImportModelEvaluationSlicesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelServiceClient.BatchImportEvaluatedAnnotations</c> and
        /// <c>ModelServiceClient.BatchImportEvaluatedAnnotationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchImportEvaluatedAnnotationsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

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

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

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
        public ModelServiceClientBuilder() : base(ModelServiceClient.ServiceMetadata)
        {
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
            return ModelServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ModelServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ModelServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ModelServiceClient.ChannelPool;
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

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ModelService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

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
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ModelServiceClient"/>.</returns>
        internal static ModelServiceClient Create(grpccore::CallInvoker callInvoker, ModelServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ModelService.ModelServiceClient grpcClient = new ModelService.ModelServiceClient(callInvoker);
            return new ModelServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

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
        /// 
        /// In order to retrieve a specific version of the model, also provide
        /// the version ID or version alias.
        /// Example: `projects/{project}/locations/{location}/models/{model}@2`
        /// or
        /// `projects/{project}/locations/{location}/models/{model}@golden`
        /// If no version ID or alias is specified, the "default" version will be
        /// returned. The "default" version alias is created for the first version of
        /// the model, and can be moved to other versions later on. There will be
        /// exactly one default version.
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
        /// 
        /// In order to retrieve a specific version of the model, also provide
        /// the version ID or version alias.
        /// Example: `projects/{project}/locations/{location}/models/{model}@2`
        /// or
        /// `projects/{project}/locations/{location}/models/{model}@golden`
        /// If no version ID or alias is specified, the "default" version will be
        /// returned. The "default" version alias is created for the first version of
        /// the model, and can be moved to other versions later on. There will be
        /// exactly one default version.
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
        /// 
        /// In order to retrieve a specific version of the model, also provide
        /// the version ID or version alias.
        /// Example: `projects/{project}/locations/{location}/models/{model}@2`
        /// or
        /// `projects/{project}/locations/{location}/models/{model}@golden`
        /// If no version ID or alias is specified, the "default" version will be
        /// returned. The "default" version alias is created for the first version of
        /// the model, and can be moved to other versions later on. There will be
        /// exactly one default version.
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
        /// 
        /// In order to retrieve a specific version of the model, also provide
        /// the version ID or version alias.
        /// Example: `projects/{project}/locations/{location}/models/{model}@2`
        /// or
        /// `projects/{project}/locations/{location}/models/{model}@golden`
        /// If no version ID or alias is specified, the "default" version will be
        /// returned. The "default" version alias is created for the first version of
        /// the model, and can be moved to other versions later on. There will be
        /// exactly one default version.
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
        /// 
        /// In order to retrieve a specific version of the model, also provide
        /// the version ID or version alias.
        /// Example: `projects/{project}/locations/{location}/models/{model}@2`
        /// or
        /// `projects/{project}/locations/{location}/models/{model}@golden`
        /// If no version ID or alias is specified, the "default" version will be
        /// returned. The "default" version alias is created for the first version of
        /// the model, and can be moved to other versions later on. There will be
        /// exactly one default version.
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
        /// 
        /// In order to retrieve a specific version of the model, also provide
        /// the version ID or version alias.
        /// Example: `projects/{project}/locations/{location}/models/{model}@2`
        /// or
        /// `projects/{project}/locations/{location}/models/{model}@golden`
        /// If no version ID or alias is specified, the "default" version will be
        /// returned. The "default" version alias is created for the first version of
        /// the model, and can be moved to other versions later on. There will be
        /// exactly one default version.
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
        public virtual gax::PagedEnumerable<ListModelsResponse, Model> ListModels(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelsRequest request = new ListModelsRequest
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
            return ListModels(request, callSettings);
        }

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
        public virtual gax::PagedAsyncEnumerable<ListModelsResponse, Model> ListModelsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelsRequest request = new ListModelsRequest
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
            return ListModelsAsync(request, callSettings);
        }

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
        public virtual gax::PagedEnumerable<ListModelsResponse, Model> ListModels(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelsRequest request = new ListModelsRequest
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
            return ListModels(request, callSettings);
        }

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
        public virtual gax::PagedAsyncEnumerable<ListModelsResponse, Model> ListModelsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelsRequest request = new ListModelsRequest
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
            return ListModelsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists versions of the specified model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Model"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListModelVersionsResponse, Model> ListModelVersions(ListModelVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists versions of the specified model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Model"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListModelVersionsResponse, Model> ListModelVersionsAsync(ListModelVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists versions of the specified model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the model to list versions for.
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
        public virtual gax::PagedEnumerable<ListModelVersionsResponse, Model> ListModelVersions(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelVersionsRequest request = new ListModelVersionsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListModelVersions(request, callSettings);
        }

        /// <summary>
        /// Lists versions of the specified model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the model to list versions for.
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
        public virtual gax::PagedAsyncEnumerable<ListModelVersionsResponse, Model> ListModelVersionsAsync(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelVersionsRequest request = new ListModelVersionsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListModelVersionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists versions of the specified model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the model to list versions for.
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
        public virtual gax::PagedEnumerable<ListModelVersionsResponse, Model> ListModelVersions(ModelName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelVersionsRequest request = new ListModelVersionsRequest
            {
                ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListModelVersions(request, callSettings);
        }

        /// <summary>
        /// Lists versions of the specified model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the model to list versions for.
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
        public virtual gax::PagedAsyncEnumerable<ListModelVersionsResponse, Model> ListModelVersionsAsync(ModelName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelVersionsRequest request = new ListModelVersionsRequest
            {
                ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListModelVersionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists checkpoints of the specified model version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ModelVersionCheckpoint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListModelVersionCheckpointsResponse, ModelVersionCheckpoint> ListModelVersionCheckpoints(ListModelVersionCheckpointsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists checkpoints of the specified model version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ModelVersionCheckpoint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListModelVersionCheckpointsResponse, ModelVersionCheckpoint> ListModelVersionCheckpointsAsync(ListModelVersionCheckpointsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists checkpoints of the specified model version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the model version to list checkpoints for.
        /// `projects/{project}/locations/{location}/models/{model}@{version}`
        /// Example: `projects/{project}/locations/{location}/models/{model}@2`
        /// or
        /// `projects/{project}/locations/{location}/models/{model}@golden`
        /// If no version ID or alias is specified, the latest version will be
        /// used.
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
        /// <returns>A pageable sequence of <see cref="ModelVersionCheckpoint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListModelVersionCheckpointsResponse, ModelVersionCheckpoint> ListModelVersionCheckpoints(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelVersionCheckpointsRequest request = new ListModelVersionCheckpointsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListModelVersionCheckpoints(request, callSettings);
        }

        /// <summary>
        /// Lists checkpoints of the specified model version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the model version to list checkpoints for.
        /// `projects/{project}/locations/{location}/models/{model}@{version}`
        /// Example: `projects/{project}/locations/{location}/models/{model}@2`
        /// or
        /// `projects/{project}/locations/{location}/models/{model}@golden`
        /// If no version ID or alias is specified, the latest version will be
        /// used.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ModelVersionCheckpoint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListModelVersionCheckpointsResponse, ModelVersionCheckpoint> ListModelVersionCheckpointsAsync(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelVersionCheckpointsRequest request = new ListModelVersionCheckpointsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListModelVersionCheckpointsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists checkpoints of the specified model version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the model version to list checkpoints for.
        /// `projects/{project}/locations/{location}/models/{model}@{version}`
        /// Example: `projects/{project}/locations/{location}/models/{model}@2`
        /// or
        /// `projects/{project}/locations/{location}/models/{model}@golden`
        /// If no version ID or alias is specified, the latest version will be
        /// used.
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
        /// <returns>A pageable sequence of <see cref="ModelVersionCheckpoint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListModelVersionCheckpointsResponse, ModelVersionCheckpoint> ListModelVersionCheckpoints(ModelName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelVersionCheckpointsRequest request = new ListModelVersionCheckpointsRequest
            {
                ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListModelVersionCheckpoints(request, callSettings);
        }

        /// <summary>
        /// Lists checkpoints of the specified model version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the model version to list checkpoints for.
        /// `projects/{project}/locations/{location}/models/{model}@{version}`
        /// Example: `projects/{project}/locations/{location}/models/{model}@2`
        /// or
        /// `projects/{project}/locations/{location}/models/{model}@golden`
        /// If no version ID or alias is specified, the latest version will be
        /// used.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ModelVersionCheckpoint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListModelVersionCheckpointsResponse, ModelVersionCheckpoint> ListModelVersionCheckpointsAsync(ModelName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelVersionCheckpointsRequest request = new ListModelVersionCheckpointsRequest
            {
                ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListModelVersionCheckpointsAsync(request, callSettings);
        }

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
        /// When Model Versioning is enabled, the model.name will be used to determine
        /// whether to update the model or model version.
        /// 1. model.name with the @ value, e.g. models/123@1, refers to a version
        /// specific update.
        /// 2. model.name without the @ value, e.g. models/123, refers to a model
        /// update.
        /// 3. model.name with @-, e.g. models/123@-, refers to a model update.
        /// 4. Supported model fields: display_name, description; supported
        /// version-specific fields: version_description. Labels are supported in both
        /// scenarios. Both the model labels and the version labels are merged when a
        /// model is returned. When updating labels, if the request is for
        /// model-specific update, model label gets updated. Otherwise, version labels
        /// get updated.
        /// 5. A model name or model version name fields update mismatch will cause a
        /// precondition error.
        /// 6. One request cannot update both the model and the version fields. You
        /// must update them separately.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource.
        /// For the `FieldMask` definition, see
        /// [google.protobuf.FieldMask][google.protobuf.FieldMask].
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
        /// When Model Versioning is enabled, the model.name will be used to determine
        /// whether to update the model or model version.
        /// 1. model.name with the @ value, e.g. models/123@1, refers to a version
        /// specific update.
        /// 2. model.name without the @ value, e.g. models/123, refers to a model
        /// update.
        /// 3. model.name with @-, e.g. models/123@-, refers to a model update.
        /// 4. Supported model fields: display_name, description; supported
        /// version-specific fields: version_description. Labels are supported in both
        /// scenarios. Both the model labels and the version labels are merged when a
        /// model is returned. When updating labels, if the request is for
        /// model-specific update, model label gets updated. Otherwise, version labels
        /// get updated.
        /// 5. A model name or model version name fields update mismatch will cause a
        /// precondition error.
        /// 6. One request cannot update both the model and the version fields. You
        /// must update them separately.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource.
        /// For the `FieldMask` definition, see
        /// [google.protobuf.FieldMask][google.protobuf.FieldMask].
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
        /// When Model Versioning is enabled, the model.name will be used to determine
        /// whether to update the model or model version.
        /// 1. model.name with the @ value, e.g. models/123@1, refers to a version
        /// specific update.
        /// 2. model.name without the @ value, e.g. models/123, refers to a model
        /// update.
        /// 3. model.name with @-, e.g. models/123@-, refers to a model update.
        /// 4. Supported model fields: display_name, description; supported
        /// version-specific fields: version_description. Labels are supported in both
        /// scenarios. Both the model labels and the version labels are merged when a
        /// model is returned. When updating labels, if the request is for
        /// model-specific update, model label gets updated. Otherwise, version labels
        /// get updated.
        /// 5. A model name or model version name fields update mismatch will cause a
        /// precondition error.
        /// 6. One request cannot update both the model and the version fields. You
        /// must update them separately.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource.
        /// For the `FieldMask` definition, see
        /// [google.protobuf.FieldMask][google.protobuf.FieldMask].
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> UpdateModelAsync(Model model, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateModelAsync(model, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Incrementally update the dataset used for an examples model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UpdateExplanationDatasetResponse, UpdateExplanationDatasetOperationMetadata> UpdateExplanationDataset(UpdateExplanationDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Incrementally update the dataset used for an examples model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UpdateExplanationDatasetResponse, UpdateExplanationDatasetOperationMetadata>> UpdateExplanationDatasetAsync(UpdateExplanationDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Incrementally update the dataset used for an examples model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UpdateExplanationDatasetResponse, UpdateExplanationDatasetOperationMetadata>> UpdateExplanationDatasetAsync(UpdateExplanationDatasetRequest request, st::CancellationToken cancellationToken) =>
            UpdateExplanationDatasetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateExplanationDataset</c>.</summary>
        public virtual lro::OperationsClient UpdateExplanationDatasetOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateExplanationDataset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<UpdateExplanationDatasetResponse, UpdateExplanationDatasetOperationMetadata> PollOnceUpdateExplanationDataset(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<UpdateExplanationDatasetResponse, UpdateExplanationDatasetOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateExplanationDatasetOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateExplanationDataset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<UpdateExplanationDatasetResponse, UpdateExplanationDatasetOperationMetadata>> PollOnceUpdateExplanationDatasetAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<UpdateExplanationDatasetResponse, UpdateExplanationDatasetOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateExplanationDatasetOperationsClient, callSettings);

        /// <summary>
        /// Incrementally update the dataset used for an examples model.
        /// </summary>
        /// <param name="model">
        /// Required. The resource name of the Model to update.
        /// Format: `projects/{project}/locations/{location}/models/{model}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UpdateExplanationDatasetResponse, UpdateExplanationDatasetOperationMetadata> UpdateExplanationDataset(string model, gaxgrpc::CallSettings callSettings = null) =>
            UpdateExplanationDataset(new UpdateExplanationDatasetRequest
            {
                Model = gax::GaxPreconditions.CheckNotNullOrEmpty(model, nameof(model)),
            }, callSettings);

        /// <summary>
        /// Incrementally update the dataset used for an examples model.
        /// </summary>
        /// <param name="model">
        /// Required. The resource name of the Model to update.
        /// Format: `projects/{project}/locations/{location}/models/{model}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UpdateExplanationDatasetResponse, UpdateExplanationDatasetOperationMetadata>> UpdateExplanationDatasetAsync(string model, gaxgrpc::CallSettings callSettings = null) =>
            UpdateExplanationDatasetAsync(new UpdateExplanationDatasetRequest
            {
                Model = gax::GaxPreconditions.CheckNotNullOrEmpty(model, nameof(model)),
            }, callSettings);

        /// <summary>
        /// Incrementally update the dataset used for an examples model.
        /// </summary>
        /// <param name="model">
        /// Required. The resource name of the Model to update.
        /// Format: `projects/{project}/locations/{location}/models/{model}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UpdateExplanationDatasetResponse, UpdateExplanationDatasetOperationMetadata>> UpdateExplanationDatasetAsync(string model, st::CancellationToken cancellationToken) =>
            UpdateExplanationDatasetAsync(model, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Incrementally update the dataset used for an examples model.
        /// </summary>
        /// <param name="model">
        /// Required. The resource name of the Model to update.
        /// Format: `projects/{project}/locations/{location}/models/{model}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UpdateExplanationDatasetResponse, UpdateExplanationDatasetOperationMetadata> UpdateExplanationDataset(ModelName model, gaxgrpc::CallSettings callSettings = null) =>
            UpdateExplanationDataset(new UpdateExplanationDatasetRequest
            {
                ModelAsModelName = gax::GaxPreconditions.CheckNotNull(model, nameof(model)),
            }, callSettings);

        /// <summary>
        /// Incrementally update the dataset used for an examples model.
        /// </summary>
        /// <param name="model">
        /// Required. The resource name of the Model to update.
        /// Format: `projects/{project}/locations/{location}/models/{model}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UpdateExplanationDatasetResponse, UpdateExplanationDatasetOperationMetadata>> UpdateExplanationDatasetAsync(ModelName model, gaxgrpc::CallSettings callSettings = null) =>
            UpdateExplanationDatasetAsync(new UpdateExplanationDatasetRequest
            {
                ModelAsModelName = gax::GaxPreconditions.CheckNotNull(model, nameof(model)),
            }, callSettings);

        /// <summary>
        /// Incrementally update the dataset used for an examples model.
        /// </summary>
        /// <param name="model">
        /// Required. The resource name of the Model to update.
        /// Format: `projects/{project}/locations/{location}/models/{model}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UpdateExplanationDatasetResponse, UpdateExplanationDatasetOperationMetadata>> UpdateExplanationDatasetAsync(ModelName model, st::CancellationToken cancellationToken) =>
            UpdateExplanationDatasetAsync(model, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Model.
        /// 
        /// A model cannot be deleted if any
        /// [Endpoint][google.cloud.aiplatform.v1.Endpoint] resource has a
        /// [DeployedModel][google.cloud.aiplatform.v1.DeployedModel] based on the
        /// model in its
        /// [deployed_models][google.cloud.aiplatform.v1.Endpoint.deployed_models]
        /// field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteModel(DeleteModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Model.
        /// 
        /// A model cannot be deleted if any
        /// [Endpoint][google.cloud.aiplatform.v1.Endpoint] resource has a
        /// [DeployedModel][google.cloud.aiplatform.v1.DeployedModel] based on the
        /// model in its
        /// [deployed_models][google.cloud.aiplatform.v1.Endpoint.deployed_models]
        /// field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteModelAsync(DeleteModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Model.
        /// 
        /// A model cannot be deleted if any
        /// [Endpoint][google.cloud.aiplatform.v1.Endpoint] resource has a
        /// [DeployedModel][google.cloud.aiplatform.v1.DeployedModel] based on the
        /// model in its
        /// [deployed_models][google.cloud.aiplatform.v1.Endpoint.deployed_models]
        /// field.
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
        /// 
        /// A model cannot be deleted if any
        /// [Endpoint][google.cloud.aiplatform.v1.Endpoint] resource has a
        /// [DeployedModel][google.cloud.aiplatform.v1.DeployedModel] based on the
        /// model in its
        /// [deployed_models][google.cloud.aiplatform.v1.Endpoint.deployed_models]
        /// field.
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
        /// 
        /// A model cannot be deleted if any
        /// [Endpoint][google.cloud.aiplatform.v1.Endpoint] resource has a
        /// [DeployedModel][google.cloud.aiplatform.v1.DeployedModel] based on the
        /// model in its
        /// [deployed_models][google.cloud.aiplatform.v1.Endpoint.deployed_models]
        /// field.
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
        /// 
        /// A model cannot be deleted if any
        /// [Endpoint][google.cloud.aiplatform.v1.Endpoint] resource has a
        /// [DeployedModel][google.cloud.aiplatform.v1.DeployedModel] based on the
        /// model in its
        /// [deployed_models][google.cloud.aiplatform.v1.Endpoint.deployed_models]
        /// field.
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
        /// 
        /// A model cannot be deleted if any
        /// [Endpoint][google.cloud.aiplatform.v1.Endpoint] resource has a
        /// [DeployedModel][google.cloud.aiplatform.v1.DeployedModel] based on the
        /// model in its
        /// [deployed_models][google.cloud.aiplatform.v1.Endpoint.deployed_models]
        /// field.
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
        /// 
        /// A model cannot be deleted if any
        /// [Endpoint][google.cloud.aiplatform.v1.Endpoint] resource has a
        /// [DeployedModel][google.cloud.aiplatform.v1.DeployedModel] based on the
        /// model in its
        /// [deployed_models][google.cloud.aiplatform.v1.Endpoint.deployed_models]
        /// field.
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
        /// 
        /// A model cannot be deleted if any
        /// [Endpoint][google.cloud.aiplatform.v1.Endpoint] resource has a
        /// [DeployedModel][google.cloud.aiplatform.v1.DeployedModel] based on the
        /// model in its
        /// [deployed_models][google.cloud.aiplatform.v1.Endpoint.deployed_models]
        /// field.
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
        /// Deletes a Model version.
        /// 
        /// Model version can only be deleted if there are no
        /// [DeployedModels][google.cloud.aiplatform.v1.DeployedModel] created from it.
        /// Deleting the only version in the Model is not allowed. Use
        /// [DeleteModel][google.cloud.aiplatform.v1.ModelService.DeleteModel] for
        /// deleting the Model instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteModelVersion(DeleteModelVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Model version.
        /// 
        /// Model version can only be deleted if there are no
        /// [DeployedModels][google.cloud.aiplatform.v1.DeployedModel] created from it.
        /// Deleting the only version in the Model is not allowed. Use
        /// [DeleteModel][google.cloud.aiplatform.v1.ModelService.DeleteModel] for
        /// deleting the Model instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteModelVersionAsync(DeleteModelVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Model version.
        /// 
        /// Model version can only be deleted if there are no
        /// [DeployedModels][google.cloud.aiplatform.v1.DeployedModel] created from it.
        /// Deleting the only version in the Model is not allowed. Use
        /// [DeleteModel][google.cloud.aiplatform.v1.ModelService.DeleteModel] for
        /// deleting the Model instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteModelVersionAsync(DeleteModelVersionRequest request, st::CancellationToken cancellationToken) =>
            DeleteModelVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteModelVersion</c>.</summary>
        public virtual lro::OperationsClient DeleteModelVersionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteModelVersion</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> PollOnceDeleteModelVersion(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteModelVersionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteModelVersion</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> PollOnceDeleteModelVersionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteModelVersionOperationsClient, callSettings);

        /// <summary>
        /// Deletes a Model version.
        /// 
        /// Model version can only be deleted if there are no
        /// [DeployedModels][google.cloud.aiplatform.v1.DeployedModel] created from it.
        /// Deleting the only version in the Model is not allowed. Use
        /// [DeleteModel][google.cloud.aiplatform.v1.ModelService.DeleteModel] for
        /// deleting the Model instead.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the model version to be deleted, with a version ID
        /// explicitly included.
        /// 
        /// Example: `projects/{project}/locations/{location}/models/{model}@1234`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteModelVersion(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteModelVersion(new DeleteModelVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Model version.
        /// 
        /// Model version can only be deleted if there are no
        /// [DeployedModels][google.cloud.aiplatform.v1.DeployedModel] created from it.
        /// Deleting the only version in the Model is not allowed. Use
        /// [DeleteModel][google.cloud.aiplatform.v1.ModelService.DeleteModel] for
        /// deleting the Model instead.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the model version to be deleted, with a version ID
        /// explicitly included.
        /// 
        /// Example: `projects/{project}/locations/{location}/models/{model}@1234`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteModelVersionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteModelVersionAsync(new DeleteModelVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Model version.
        /// 
        /// Model version can only be deleted if there are no
        /// [DeployedModels][google.cloud.aiplatform.v1.DeployedModel] created from it.
        /// Deleting the only version in the Model is not allowed. Use
        /// [DeleteModel][google.cloud.aiplatform.v1.ModelService.DeleteModel] for
        /// deleting the Model instead.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the model version to be deleted, with a version ID
        /// explicitly included.
        /// 
        /// Example: `projects/{project}/locations/{location}/models/{model}@1234`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteModelVersionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteModelVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Model version.
        /// 
        /// Model version can only be deleted if there are no
        /// [DeployedModels][google.cloud.aiplatform.v1.DeployedModel] created from it.
        /// Deleting the only version in the Model is not allowed. Use
        /// [DeleteModel][google.cloud.aiplatform.v1.ModelService.DeleteModel] for
        /// deleting the Model instead.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the model version to be deleted, with a version ID
        /// explicitly included.
        /// 
        /// Example: `projects/{project}/locations/{location}/models/{model}@1234`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteModelVersion(ModelName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteModelVersion(new DeleteModelVersionRequest
            {
                ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Model version.
        /// 
        /// Model version can only be deleted if there are no
        /// [DeployedModels][google.cloud.aiplatform.v1.DeployedModel] created from it.
        /// Deleting the only version in the Model is not allowed. Use
        /// [DeleteModel][google.cloud.aiplatform.v1.ModelService.DeleteModel] for
        /// deleting the Model instead.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the model version to be deleted, with a version ID
        /// explicitly included.
        /// 
        /// Example: `projects/{project}/locations/{location}/models/{model}@1234`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteModelVersionAsync(ModelName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteModelVersionAsync(new DeleteModelVersionRequest
            {
                ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Model version.
        /// 
        /// Model version can only be deleted if there are no
        /// [DeployedModels][google.cloud.aiplatform.v1.DeployedModel] created from it.
        /// Deleting the only version in the Model is not allowed. Use
        /// [DeleteModel][google.cloud.aiplatform.v1.ModelService.DeleteModel] for
        /// deleting the Model instead.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the model version to be deleted, with a version ID
        /// explicitly included.
        /// 
        /// Example: `projects/{project}/locations/{location}/models/{model}@1234`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteModelVersionAsync(ModelName name, st::CancellationToken cancellationToken) =>
            DeleteModelVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Merges a set of aliases for a Model version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Model MergeVersionAliases(MergeVersionAliasesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Merges a set of aliases for a Model version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> MergeVersionAliasesAsync(MergeVersionAliasesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Merges a set of aliases for a Model version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> MergeVersionAliasesAsync(MergeVersionAliasesRequest request, st::CancellationToken cancellationToken) =>
            MergeVersionAliasesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Merges a set of aliases for a Model version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the model version to merge aliases, with a version ID
        /// explicitly included.
        /// 
        /// Example: `projects/{project}/locations/{location}/models/{model}@1234`
        /// </param>
        /// <param name="versionAliases">
        /// Required. The set of version aliases to merge.
        /// The alias should be at most 128 characters, and match
        /// `[a-z][a-zA-Z0-9-]{0,126}[a-z-0-9]`.
        /// Add the `-` prefix to an alias means removing that alias from the version.
        /// `-` is NOT counted in the 128 characters. Example: `-golden` means removing
        /// the `golden` alias from the version.
        /// 
        /// There is NO ordering in aliases, which means
        /// 1) The aliases returned from GetModel API might not have the exactly same
        /// order from this MergeVersionAliases API. 2) Adding and deleting the same
        /// alias in the request is not recommended, and the 2 operations will be
        /// cancelled out.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Model MergeVersionAliases(string name, scg::IEnumerable<string> versionAliases, gaxgrpc::CallSettings callSettings = null) =>
            MergeVersionAliases(new MergeVersionAliasesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                VersionAliases =
                {
                    gax::GaxPreconditions.CheckNotNull(versionAliases, nameof(versionAliases)),
                },
            }, callSettings);

        /// <summary>
        /// Merges a set of aliases for a Model version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the model version to merge aliases, with a version ID
        /// explicitly included.
        /// 
        /// Example: `projects/{project}/locations/{location}/models/{model}@1234`
        /// </param>
        /// <param name="versionAliases">
        /// Required. The set of version aliases to merge.
        /// The alias should be at most 128 characters, and match
        /// `[a-z][a-zA-Z0-9-]{0,126}[a-z-0-9]`.
        /// Add the `-` prefix to an alias means removing that alias from the version.
        /// `-` is NOT counted in the 128 characters. Example: `-golden` means removing
        /// the `golden` alias from the version.
        /// 
        /// There is NO ordering in aliases, which means
        /// 1) The aliases returned from GetModel API might not have the exactly same
        /// order from this MergeVersionAliases API. 2) Adding and deleting the same
        /// alias in the request is not recommended, and the 2 operations will be
        /// cancelled out.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> MergeVersionAliasesAsync(string name, scg::IEnumerable<string> versionAliases, gaxgrpc::CallSettings callSettings = null) =>
            MergeVersionAliasesAsync(new MergeVersionAliasesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                VersionAliases =
                {
                    gax::GaxPreconditions.CheckNotNull(versionAliases, nameof(versionAliases)),
                },
            }, callSettings);

        /// <summary>
        /// Merges a set of aliases for a Model version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the model version to merge aliases, with a version ID
        /// explicitly included.
        /// 
        /// Example: `projects/{project}/locations/{location}/models/{model}@1234`
        /// </param>
        /// <param name="versionAliases">
        /// Required. The set of version aliases to merge.
        /// The alias should be at most 128 characters, and match
        /// `[a-z][a-zA-Z0-9-]{0,126}[a-z-0-9]`.
        /// Add the `-` prefix to an alias means removing that alias from the version.
        /// `-` is NOT counted in the 128 characters. Example: `-golden` means removing
        /// the `golden` alias from the version.
        /// 
        /// There is NO ordering in aliases, which means
        /// 1) The aliases returned from GetModel API might not have the exactly same
        /// order from this MergeVersionAliases API. 2) Adding and deleting the same
        /// alias in the request is not recommended, and the 2 operations will be
        /// cancelled out.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> MergeVersionAliasesAsync(string name, scg::IEnumerable<string> versionAliases, st::CancellationToken cancellationToken) =>
            MergeVersionAliasesAsync(name, versionAliases, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Merges a set of aliases for a Model version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the model version to merge aliases, with a version ID
        /// explicitly included.
        /// 
        /// Example: `projects/{project}/locations/{location}/models/{model}@1234`
        /// </param>
        /// <param name="versionAliases">
        /// Required. The set of version aliases to merge.
        /// The alias should be at most 128 characters, and match
        /// `[a-z][a-zA-Z0-9-]{0,126}[a-z-0-9]`.
        /// Add the `-` prefix to an alias means removing that alias from the version.
        /// `-` is NOT counted in the 128 characters. Example: `-golden` means removing
        /// the `golden` alias from the version.
        /// 
        /// There is NO ordering in aliases, which means
        /// 1) The aliases returned from GetModel API might not have the exactly same
        /// order from this MergeVersionAliases API. 2) Adding and deleting the same
        /// alias in the request is not recommended, and the 2 operations will be
        /// cancelled out.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Model MergeVersionAliases(ModelName name, scg::IEnumerable<string> versionAliases, gaxgrpc::CallSettings callSettings = null) =>
            MergeVersionAliases(new MergeVersionAliasesRequest
            {
                ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                VersionAliases =
                {
                    gax::GaxPreconditions.CheckNotNull(versionAliases, nameof(versionAliases)),
                },
            }, callSettings);

        /// <summary>
        /// Merges a set of aliases for a Model version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the model version to merge aliases, with a version ID
        /// explicitly included.
        /// 
        /// Example: `projects/{project}/locations/{location}/models/{model}@1234`
        /// </param>
        /// <param name="versionAliases">
        /// Required. The set of version aliases to merge.
        /// The alias should be at most 128 characters, and match
        /// `[a-z][a-zA-Z0-9-]{0,126}[a-z-0-9]`.
        /// Add the `-` prefix to an alias means removing that alias from the version.
        /// `-` is NOT counted in the 128 characters. Example: `-golden` means removing
        /// the `golden` alias from the version.
        /// 
        /// There is NO ordering in aliases, which means
        /// 1) The aliases returned from GetModel API might not have the exactly same
        /// order from this MergeVersionAliases API. 2) Adding and deleting the same
        /// alias in the request is not recommended, and the 2 operations will be
        /// cancelled out.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> MergeVersionAliasesAsync(ModelName name, scg::IEnumerable<string> versionAliases, gaxgrpc::CallSettings callSettings = null) =>
            MergeVersionAliasesAsync(new MergeVersionAliasesRequest
            {
                ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                VersionAliases =
                {
                    gax::GaxPreconditions.CheckNotNull(versionAliases, nameof(versionAliases)),
                },
            }, callSettings);

        /// <summary>
        /// Merges a set of aliases for a Model version.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the model version to merge aliases, with a version ID
        /// explicitly included.
        /// 
        /// Example: `projects/{project}/locations/{location}/models/{model}@1234`
        /// </param>
        /// <param name="versionAliases">
        /// Required. The set of version aliases to merge.
        /// The alias should be at most 128 characters, and match
        /// `[a-z][a-zA-Z0-9-]{0,126}[a-z-0-9]`.
        /// Add the `-` prefix to an alias means removing that alias from the version.
        /// `-` is NOT counted in the 128 characters. Example: `-golden` means removing
        /// the `golden` alias from the version.
        /// 
        /// There is NO ordering in aliases, which means
        /// 1) The aliases returned from GetModel API might not have the exactly same
        /// order from this MergeVersionAliases API. 2) Adding and deleting the same
        /// alias in the request is not recommended, and the 2 operations will be
        /// cancelled out.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> MergeVersionAliasesAsync(ModelName name, scg::IEnumerable<string> versionAliases, st::CancellationToken cancellationToken) =>
            MergeVersionAliasesAsync(name, versionAliases, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports a trained, exportable Model to a location specified by the
        /// user. A Model is considered to be exportable if it has at least one
        /// [supported export
        /// format][google.cloud.aiplatform.v1.Model.supported_export_formats].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportModelResponse, ExportModelOperationMetadata> ExportModel(ExportModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports a trained, exportable Model to a location specified by the
        /// user. A Model is considered to be exportable if it has at least one
        /// [supported export
        /// format][google.cloud.aiplatform.v1.Model.supported_export_formats].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportModelResponse, ExportModelOperationMetadata>> ExportModelAsync(ExportModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports a trained, exportable Model to a location specified by the
        /// user. A Model is considered to be exportable if it has at least one
        /// [supported export
        /// format][google.cloud.aiplatform.v1.Model.supported_export_formats].
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
        /// Exports a trained, exportable Model to a location specified by the
        /// user. A Model is considered to be exportable if it has at least one
        /// [supported export
        /// format][google.cloud.aiplatform.v1.Model.supported_export_formats].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Model to export.
        /// The resource name may contain version id or version alias to specify the
        /// version, if no version is specified, the default version will be exported.
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
        /// Exports a trained, exportable Model to a location specified by the
        /// user. A Model is considered to be exportable if it has at least one
        /// [supported export
        /// format][google.cloud.aiplatform.v1.Model.supported_export_formats].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Model to export.
        /// The resource name may contain version id or version alias to specify the
        /// version, if no version is specified, the default version will be exported.
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
        /// Exports a trained, exportable Model to a location specified by the
        /// user. A Model is considered to be exportable if it has at least one
        /// [supported export
        /// format][google.cloud.aiplatform.v1.Model.supported_export_formats].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Model to export.
        /// The resource name may contain version id or version alias to specify the
        /// version, if no version is specified, the default version will be exported.
        /// </param>
        /// <param name="outputConfig">
        /// Required. The desired output location and configuration.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportModelResponse, ExportModelOperationMetadata>> ExportModelAsync(string name, ExportModelRequest.Types.OutputConfig outputConfig, st::CancellationToken cancellationToken) =>
            ExportModelAsync(name, outputConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports a trained, exportable Model to a location specified by the
        /// user. A Model is considered to be exportable if it has at least one
        /// [supported export
        /// format][google.cloud.aiplatform.v1.Model.supported_export_formats].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Model to export.
        /// The resource name may contain version id or version alias to specify the
        /// version, if no version is specified, the default version will be exported.
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
        /// Exports a trained, exportable Model to a location specified by the
        /// user. A Model is considered to be exportable if it has at least one
        /// [supported export
        /// format][google.cloud.aiplatform.v1.Model.supported_export_formats].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Model to export.
        /// The resource name may contain version id or version alias to specify the
        /// version, if no version is specified, the default version will be exported.
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
        /// Exports a trained, exportable Model to a location specified by the
        /// user. A Model is considered to be exportable if it has at least one
        /// [supported export
        /// format][google.cloud.aiplatform.v1.Model.supported_export_formats].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Model to export.
        /// The resource name may contain version id or version alias to specify the
        /// version, if no version is specified, the default version will be exported.
        /// </param>
        /// <param name="outputConfig">
        /// Required. The desired output location and configuration.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportModelResponse, ExportModelOperationMetadata>> ExportModelAsync(ModelName name, ExportModelRequest.Types.OutputConfig outputConfig, st::CancellationToken cancellationToken) =>
            ExportModelAsync(name, outputConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Copies an already existing Vertex AI Model into the specified Location.
        /// The source Model must exist in the same Project.
        /// When copying custom Models, the users themselves are responsible for
        /// [Model.metadata][google.cloud.aiplatform.v1.Model.metadata] content to be
        /// region-agnostic, as well as making sure that any resources (e.g. files) it
        /// depends on remain accessible.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CopyModelResponse, CopyModelOperationMetadata> CopyModel(CopyModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Copies an already existing Vertex AI Model into the specified Location.
        /// The source Model must exist in the same Project.
        /// When copying custom Models, the users themselves are responsible for
        /// [Model.metadata][google.cloud.aiplatform.v1.Model.metadata] content to be
        /// region-agnostic, as well as making sure that any resources (e.g. files) it
        /// depends on remain accessible.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CopyModelResponse, CopyModelOperationMetadata>> CopyModelAsync(CopyModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Copies an already existing Vertex AI Model into the specified Location.
        /// The source Model must exist in the same Project.
        /// When copying custom Models, the users themselves are responsible for
        /// [Model.metadata][google.cloud.aiplatform.v1.Model.metadata] content to be
        /// region-agnostic, as well as making sure that any resources (e.g. files) it
        /// depends on remain accessible.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CopyModelResponse, CopyModelOperationMetadata>> CopyModelAsync(CopyModelRequest request, st::CancellationToken cancellationToken) =>
            CopyModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CopyModel</c>.</summary>
        public virtual lro::OperationsClient CopyModelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CopyModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<CopyModelResponse, CopyModelOperationMetadata> PollOnceCopyModel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CopyModelResponse, CopyModelOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CopyModelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CopyModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<CopyModelResponse, CopyModelOperationMetadata>> PollOnceCopyModelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CopyModelResponse, CopyModelOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CopyModelOperationsClient, callSettings);

        /// <summary>
        /// Copies an already existing Vertex AI Model into the specified Location.
        /// The source Model must exist in the same Project.
        /// When copying custom Models, the users themselves are responsible for
        /// [Model.metadata][google.cloud.aiplatform.v1.Model.metadata] content to be
        /// region-agnostic, as well as making sure that any resources (e.g. files) it
        /// depends on remain accessible.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location into which to copy the Model.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="sourceModel">
        /// Required. The resource name of the Model to copy. That Model must be in the
        /// same Project. Format:
        /// `projects/{project}/locations/{location}/models/{model}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CopyModelResponse, CopyModelOperationMetadata> CopyModel(string parent, string sourceModel, gaxgrpc::CallSettings callSettings = null) =>
            CopyModel(new CopyModelRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SourceModel = gax::GaxPreconditions.CheckNotNullOrEmpty(sourceModel, nameof(sourceModel)),
            }, callSettings);

        /// <summary>
        /// Copies an already existing Vertex AI Model into the specified Location.
        /// The source Model must exist in the same Project.
        /// When copying custom Models, the users themselves are responsible for
        /// [Model.metadata][google.cloud.aiplatform.v1.Model.metadata] content to be
        /// region-agnostic, as well as making sure that any resources (e.g. files) it
        /// depends on remain accessible.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location into which to copy the Model.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="sourceModel">
        /// Required. The resource name of the Model to copy. That Model must be in the
        /// same Project. Format:
        /// `projects/{project}/locations/{location}/models/{model}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CopyModelResponse, CopyModelOperationMetadata>> CopyModelAsync(string parent, string sourceModel, gaxgrpc::CallSettings callSettings = null) =>
            CopyModelAsync(new CopyModelRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SourceModel = gax::GaxPreconditions.CheckNotNullOrEmpty(sourceModel, nameof(sourceModel)),
            }, callSettings);

        /// <summary>
        /// Copies an already existing Vertex AI Model into the specified Location.
        /// The source Model must exist in the same Project.
        /// When copying custom Models, the users themselves are responsible for
        /// [Model.metadata][google.cloud.aiplatform.v1.Model.metadata] content to be
        /// region-agnostic, as well as making sure that any resources (e.g. files) it
        /// depends on remain accessible.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location into which to copy the Model.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="sourceModel">
        /// Required. The resource name of the Model to copy. That Model must be in the
        /// same Project. Format:
        /// `projects/{project}/locations/{location}/models/{model}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CopyModelResponse, CopyModelOperationMetadata>> CopyModelAsync(string parent, string sourceModel, st::CancellationToken cancellationToken) =>
            CopyModelAsync(parent, sourceModel, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Copies an already existing Vertex AI Model into the specified Location.
        /// The source Model must exist in the same Project.
        /// When copying custom Models, the users themselves are responsible for
        /// [Model.metadata][google.cloud.aiplatform.v1.Model.metadata] content to be
        /// region-agnostic, as well as making sure that any resources (e.g. files) it
        /// depends on remain accessible.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location into which to copy the Model.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="sourceModel">
        /// Required. The resource name of the Model to copy. That Model must be in the
        /// same Project. Format:
        /// `projects/{project}/locations/{location}/models/{model}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CopyModelResponse, CopyModelOperationMetadata> CopyModel(gagr::LocationName parent, ModelName sourceModel, gaxgrpc::CallSettings callSettings = null) =>
            CopyModel(new CopyModelRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SourceModelAsModelName = gax::GaxPreconditions.CheckNotNull(sourceModel, nameof(sourceModel)),
            }, callSettings);

        /// <summary>
        /// Copies an already existing Vertex AI Model into the specified Location.
        /// The source Model must exist in the same Project.
        /// When copying custom Models, the users themselves are responsible for
        /// [Model.metadata][google.cloud.aiplatform.v1.Model.metadata] content to be
        /// region-agnostic, as well as making sure that any resources (e.g. files) it
        /// depends on remain accessible.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location into which to copy the Model.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="sourceModel">
        /// Required. The resource name of the Model to copy. That Model must be in the
        /// same Project. Format:
        /// `projects/{project}/locations/{location}/models/{model}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CopyModelResponse, CopyModelOperationMetadata>> CopyModelAsync(gagr::LocationName parent, ModelName sourceModel, gaxgrpc::CallSettings callSettings = null) =>
            CopyModelAsync(new CopyModelRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SourceModelAsModelName = gax::GaxPreconditions.CheckNotNull(sourceModel, nameof(sourceModel)),
            }, callSettings);

        /// <summary>
        /// Copies an already existing Vertex AI Model into the specified Location.
        /// The source Model must exist in the same Project.
        /// When copying custom Models, the users themselves are responsible for
        /// [Model.metadata][google.cloud.aiplatform.v1.Model.metadata] content to be
        /// region-agnostic, as well as making sure that any resources (e.g. files) it
        /// depends on remain accessible.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location into which to copy the Model.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="sourceModel">
        /// Required. The resource name of the Model to copy. That Model must be in the
        /// same Project. Format:
        /// `projects/{project}/locations/{location}/models/{model}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CopyModelResponse, CopyModelOperationMetadata>> CopyModelAsync(gagr::LocationName parent, ModelName sourceModel, st::CancellationToken cancellationToken) =>
            CopyModelAsync(parent, sourceModel, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports an externally generated ModelEvaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ModelEvaluation ImportModelEvaluation(ImportModelEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports an externally generated ModelEvaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelEvaluation> ImportModelEvaluationAsync(ImportModelEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports an externally generated ModelEvaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelEvaluation> ImportModelEvaluationAsync(ImportModelEvaluationRequest request, st::CancellationToken cancellationToken) =>
            ImportModelEvaluationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports an externally generated ModelEvaluation.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent model resource.
        /// Format: `projects/{project}/locations/{location}/models/{model}`
        /// </param>
        /// <param name="modelEvaluation">
        /// Required. Model evaluation resource to be imported.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ModelEvaluation ImportModelEvaluation(string parent, ModelEvaluation modelEvaluation, gaxgrpc::CallSettings callSettings = null) =>
            ImportModelEvaluation(new ImportModelEvaluationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ModelEvaluation = gax::GaxPreconditions.CheckNotNull(modelEvaluation, nameof(modelEvaluation)),
            }, callSettings);

        /// <summary>
        /// Imports an externally generated ModelEvaluation.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent model resource.
        /// Format: `projects/{project}/locations/{location}/models/{model}`
        /// </param>
        /// <param name="modelEvaluation">
        /// Required. Model evaluation resource to be imported.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelEvaluation> ImportModelEvaluationAsync(string parent, ModelEvaluation modelEvaluation, gaxgrpc::CallSettings callSettings = null) =>
            ImportModelEvaluationAsync(new ImportModelEvaluationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ModelEvaluation = gax::GaxPreconditions.CheckNotNull(modelEvaluation, nameof(modelEvaluation)),
            }, callSettings);

        /// <summary>
        /// Imports an externally generated ModelEvaluation.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent model resource.
        /// Format: `projects/{project}/locations/{location}/models/{model}`
        /// </param>
        /// <param name="modelEvaluation">
        /// Required. Model evaluation resource to be imported.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelEvaluation> ImportModelEvaluationAsync(string parent, ModelEvaluation modelEvaluation, st::CancellationToken cancellationToken) =>
            ImportModelEvaluationAsync(parent, modelEvaluation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports an externally generated ModelEvaluation.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent model resource.
        /// Format: `projects/{project}/locations/{location}/models/{model}`
        /// </param>
        /// <param name="modelEvaluation">
        /// Required. Model evaluation resource to be imported.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ModelEvaluation ImportModelEvaluation(ModelName parent, ModelEvaluation modelEvaluation, gaxgrpc::CallSettings callSettings = null) =>
            ImportModelEvaluation(new ImportModelEvaluationRequest
            {
                ParentAsModelName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ModelEvaluation = gax::GaxPreconditions.CheckNotNull(modelEvaluation, nameof(modelEvaluation)),
            }, callSettings);

        /// <summary>
        /// Imports an externally generated ModelEvaluation.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent model resource.
        /// Format: `projects/{project}/locations/{location}/models/{model}`
        /// </param>
        /// <param name="modelEvaluation">
        /// Required. Model evaluation resource to be imported.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelEvaluation> ImportModelEvaluationAsync(ModelName parent, ModelEvaluation modelEvaluation, gaxgrpc::CallSettings callSettings = null) =>
            ImportModelEvaluationAsync(new ImportModelEvaluationRequest
            {
                ParentAsModelName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ModelEvaluation = gax::GaxPreconditions.CheckNotNull(modelEvaluation, nameof(modelEvaluation)),
            }, callSettings);

        /// <summary>
        /// Imports an externally generated ModelEvaluation.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent model resource.
        /// Format: `projects/{project}/locations/{location}/models/{model}`
        /// </param>
        /// <param name="modelEvaluation">
        /// Required. Model evaluation resource to be imported.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelEvaluation> ImportModelEvaluationAsync(ModelName parent, ModelEvaluation modelEvaluation, st::CancellationToken cancellationToken) =>
            ImportModelEvaluationAsync(parent, modelEvaluation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports a list of externally generated ModelEvaluationSlice.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchImportModelEvaluationSlicesResponse BatchImportModelEvaluationSlices(BatchImportModelEvaluationSlicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports a list of externally generated ModelEvaluationSlice.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchImportModelEvaluationSlicesResponse> BatchImportModelEvaluationSlicesAsync(BatchImportModelEvaluationSlicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports a list of externally generated ModelEvaluationSlice.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchImportModelEvaluationSlicesResponse> BatchImportModelEvaluationSlicesAsync(BatchImportModelEvaluationSlicesRequest request, st::CancellationToken cancellationToken) =>
            BatchImportModelEvaluationSlicesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports a list of externally generated ModelEvaluationSlice.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent ModelEvaluation resource.
        /// Format:
        /// `projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}`
        /// </param>
        /// <param name="modelEvaluationSlices">
        /// Required. Model evaluation slice resource to be imported.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchImportModelEvaluationSlicesResponse BatchImportModelEvaluationSlices(string parent, scg::IEnumerable<ModelEvaluationSlice> modelEvaluationSlices, gaxgrpc::CallSettings callSettings = null) =>
            BatchImportModelEvaluationSlices(new BatchImportModelEvaluationSlicesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ModelEvaluationSlices =
                {
                    gax::GaxPreconditions.CheckNotNull(modelEvaluationSlices, nameof(modelEvaluationSlices)),
                },
            }, callSettings);

        /// <summary>
        /// Imports a list of externally generated ModelEvaluationSlice.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent ModelEvaluation resource.
        /// Format:
        /// `projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}`
        /// </param>
        /// <param name="modelEvaluationSlices">
        /// Required. Model evaluation slice resource to be imported.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchImportModelEvaluationSlicesResponse> BatchImportModelEvaluationSlicesAsync(string parent, scg::IEnumerable<ModelEvaluationSlice> modelEvaluationSlices, gaxgrpc::CallSettings callSettings = null) =>
            BatchImportModelEvaluationSlicesAsync(new BatchImportModelEvaluationSlicesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ModelEvaluationSlices =
                {
                    gax::GaxPreconditions.CheckNotNull(modelEvaluationSlices, nameof(modelEvaluationSlices)),
                },
            }, callSettings);

        /// <summary>
        /// Imports a list of externally generated ModelEvaluationSlice.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent ModelEvaluation resource.
        /// Format:
        /// `projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}`
        /// </param>
        /// <param name="modelEvaluationSlices">
        /// Required. Model evaluation slice resource to be imported.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchImportModelEvaluationSlicesResponse> BatchImportModelEvaluationSlicesAsync(string parent, scg::IEnumerable<ModelEvaluationSlice> modelEvaluationSlices, st::CancellationToken cancellationToken) =>
            BatchImportModelEvaluationSlicesAsync(parent, modelEvaluationSlices, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports a list of externally generated ModelEvaluationSlice.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent ModelEvaluation resource.
        /// Format:
        /// `projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}`
        /// </param>
        /// <param name="modelEvaluationSlices">
        /// Required. Model evaluation slice resource to be imported.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchImportModelEvaluationSlicesResponse BatchImportModelEvaluationSlices(ModelEvaluationName parent, scg::IEnumerable<ModelEvaluationSlice> modelEvaluationSlices, gaxgrpc::CallSettings callSettings = null) =>
            BatchImportModelEvaluationSlices(new BatchImportModelEvaluationSlicesRequest
            {
                ParentAsModelEvaluationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ModelEvaluationSlices =
                {
                    gax::GaxPreconditions.CheckNotNull(modelEvaluationSlices, nameof(modelEvaluationSlices)),
                },
            }, callSettings);

        /// <summary>
        /// Imports a list of externally generated ModelEvaluationSlice.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent ModelEvaluation resource.
        /// Format:
        /// `projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}`
        /// </param>
        /// <param name="modelEvaluationSlices">
        /// Required. Model evaluation slice resource to be imported.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchImportModelEvaluationSlicesResponse> BatchImportModelEvaluationSlicesAsync(ModelEvaluationName parent, scg::IEnumerable<ModelEvaluationSlice> modelEvaluationSlices, gaxgrpc::CallSettings callSettings = null) =>
            BatchImportModelEvaluationSlicesAsync(new BatchImportModelEvaluationSlicesRequest
            {
                ParentAsModelEvaluationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ModelEvaluationSlices =
                {
                    gax::GaxPreconditions.CheckNotNull(modelEvaluationSlices, nameof(modelEvaluationSlices)),
                },
            }, callSettings);

        /// <summary>
        /// Imports a list of externally generated ModelEvaluationSlice.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent ModelEvaluation resource.
        /// Format:
        /// `projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}`
        /// </param>
        /// <param name="modelEvaluationSlices">
        /// Required. Model evaluation slice resource to be imported.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchImportModelEvaluationSlicesResponse> BatchImportModelEvaluationSlicesAsync(ModelEvaluationName parent, scg::IEnumerable<ModelEvaluationSlice> modelEvaluationSlices, st::CancellationToken cancellationToken) =>
            BatchImportModelEvaluationSlicesAsync(parent, modelEvaluationSlices, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports a list of externally generated EvaluatedAnnotations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchImportEvaluatedAnnotationsResponse BatchImportEvaluatedAnnotations(BatchImportEvaluatedAnnotationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports a list of externally generated EvaluatedAnnotations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchImportEvaluatedAnnotationsResponse> BatchImportEvaluatedAnnotationsAsync(BatchImportEvaluatedAnnotationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports a list of externally generated EvaluatedAnnotations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchImportEvaluatedAnnotationsResponse> BatchImportEvaluatedAnnotationsAsync(BatchImportEvaluatedAnnotationsRequest request, st::CancellationToken cancellationToken) =>
            BatchImportEvaluatedAnnotationsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports a list of externally generated EvaluatedAnnotations.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent ModelEvaluationSlice resource.
        /// Format:
        /// `projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}/slices/{slice}`
        /// </param>
        /// <param name="evaluatedAnnotations">
        /// Required. Evaluated annotations resource to be imported.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchImportEvaluatedAnnotationsResponse BatchImportEvaluatedAnnotations(string parent, scg::IEnumerable<EvaluatedAnnotation> evaluatedAnnotations, gaxgrpc::CallSettings callSettings = null) =>
            BatchImportEvaluatedAnnotations(new BatchImportEvaluatedAnnotationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EvaluatedAnnotations =
                {
                    gax::GaxPreconditions.CheckNotNull(evaluatedAnnotations, nameof(evaluatedAnnotations)),
                },
            }, callSettings);

        /// <summary>
        /// Imports a list of externally generated EvaluatedAnnotations.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent ModelEvaluationSlice resource.
        /// Format:
        /// `projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}/slices/{slice}`
        /// </param>
        /// <param name="evaluatedAnnotations">
        /// Required. Evaluated annotations resource to be imported.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchImportEvaluatedAnnotationsResponse> BatchImportEvaluatedAnnotationsAsync(string parent, scg::IEnumerable<EvaluatedAnnotation> evaluatedAnnotations, gaxgrpc::CallSettings callSettings = null) =>
            BatchImportEvaluatedAnnotationsAsync(new BatchImportEvaluatedAnnotationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EvaluatedAnnotations =
                {
                    gax::GaxPreconditions.CheckNotNull(evaluatedAnnotations, nameof(evaluatedAnnotations)),
                },
            }, callSettings);

        /// <summary>
        /// Imports a list of externally generated EvaluatedAnnotations.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent ModelEvaluationSlice resource.
        /// Format:
        /// `projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}/slices/{slice}`
        /// </param>
        /// <param name="evaluatedAnnotations">
        /// Required. Evaluated annotations resource to be imported.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchImportEvaluatedAnnotationsResponse> BatchImportEvaluatedAnnotationsAsync(string parent, scg::IEnumerable<EvaluatedAnnotation> evaluatedAnnotations, st::CancellationToken cancellationToken) =>
            BatchImportEvaluatedAnnotationsAsync(parent, evaluatedAnnotations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports a list of externally generated EvaluatedAnnotations.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent ModelEvaluationSlice resource.
        /// Format:
        /// `projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}/slices/{slice}`
        /// </param>
        /// <param name="evaluatedAnnotations">
        /// Required. Evaluated annotations resource to be imported.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchImportEvaluatedAnnotationsResponse BatchImportEvaluatedAnnotations(ModelEvaluationSliceName parent, scg::IEnumerable<EvaluatedAnnotation> evaluatedAnnotations, gaxgrpc::CallSettings callSettings = null) =>
            BatchImportEvaluatedAnnotations(new BatchImportEvaluatedAnnotationsRequest
            {
                ParentAsModelEvaluationSliceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EvaluatedAnnotations =
                {
                    gax::GaxPreconditions.CheckNotNull(evaluatedAnnotations, nameof(evaluatedAnnotations)),
                },
            }, callSettings);

        /// <summary>
        /// Imports a list of externally generated EvaluatedAnnotations.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent ModelEvaluationSlice resource.
        /// Format:
        /// `projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}/slices/{slice}`
        /// </param>
        /// <param name="evaluatedAnnotations">
        /// Required. Evaluated annotations resource to be imported.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchImportEvaluatedAnnotationsResponse> BatchImportEvaluatedAnnotationsAsync(ModelEvaluationSliceName parent, scg::IEnumerable<EvaluatedAnnotation> evaluatedAnnotations, gaxgrpc::CallSettings callSettings = null) =>
            BatchImportEvaluatedAnnotationsAsync(new BatchImportEvaluatedAnnotationsRequest
            {
                ParentAsModelEvaluationSliceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EvaluatedAnnotations =
                {
                    gax::GaxPreconditions.CheckNotNull(evaluatedAnnotations, nameof(evaluatedAnnotations)),
                },
            }, callSettings);

        /// <summary>
        /// Imports a list of externally generated EvaluatedAnnotations.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent ModelEvaluationSlice resource.
        /// Format:
        /// `projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}/slices/{slice}`
        /// </param>
        /// <param name="evaluatedAnnotations">
        /// Required. Evaluated annotations resource to be imported.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchImportEvaluatedAnnotationsResponse> BatchImportEvaluatedAnnotationsAsync(ModelEvaluationSliceName parent, scg::IEnumerable<EvaluatedAnnotation> evaluatedAnnotations, st::CancellationToken cancellationToken) =>
            BatchImportEvaluatedAnnotationsAsync(parent, evaluatedAnnotations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual gax::PagedEnumerable<ListModelEvaluationsResponse, ModelEvaluation> ListModelEvaluations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelEvaluationsRequest request = new ListModelEvaluationsRequest
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
            return ListModelEvaluations(request, callSettings);
        }

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
        public virtual gax::PagedAsyncEnumerable<ListModelEvaluationsResponse, ModelEvaluation> ListModelEvaluationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelEvaluationsRequest request = new ListModelEvaluationsRequest
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
            return ListModelEvaluationsAsync(request, callSettings);
        }

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
        public virtual gax::PagedEnumerable<ListModelEvaluationsResponse, ModelEvaluation> ListModelEvaluations(ModelName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelEvaluationsRequest request = new ListModelEvaluationsRequest
            {
                ParentAsModelName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListModelEvaluations(request, callSettings);
        }

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
        public virtual gax::PagedAsyncEnumerable<ListModelEvaluationsResponse, ModelEvaluation> ListModelEvaluationsAsync(ModelName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelEvaluationsRequest request = new ListModelEvaluationsRequest
            {
                ParentAsModelName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListModelEvaluationsAsync(request, callSettings);
        }

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
        /// Required. The resource name of the ModelEvaluation to list the
        /// ModelEvaluationSlices from. Format:
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
        public virtual gax::PagedEnumerable<ListModelEvaluationSlicesResponse, ModelEvaluationSlice> ListModelEvaluationSlices(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelEvaluationSlicesRequest request = new ListModelEvaluationSlicesRequest
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
            return ListModelEvaluationSlices(request, callSettings);
        }

        /// <summary>
        /// Lists ModelEvaluationSlices in a ModelEvaluation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ModelEvaluation to list the
        /// ModelEvaluationSlices from. Format:
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
        public virtual gax::PagedAsyncEnumerable<ListModelEvaluationSlicesResponse, ModelEvaluationSlice> ListModelEvaluationSlicesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelEvaluationSlicesRequest request = new ListModelEvaluationSlicesRequest
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
            return ListModelEvaluationSlicesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists ModelEvaluationSlices in a ModelEvaluation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ModelEvaluation to list the
        /// ModelEvaluationSlices from. Format:
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
        public virtual gax::PagedEnumerable<ListModelEvaluationSlicesResponse, ModelEvaluationSlice> ListModelEvaluationSlices(ModelEvaluationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelEvaluationSlicesRequest request = new ListModelEvaluationSlicesRequest
            {
                ParentAsModelEvaluationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListModelEvaluationSlices(request, callSettings);
        }

        /// <summary>
        /// Lists ModelEvaluationSlices in a ModelEvaluation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ModelEvaluation to list the
        /// ModelEvaluationSlices from. Format:
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
        public virtual gax::PagedAsyncEnumerable<ListModelEvaluationSlicesResponse, ModelEvaluationSlice> ListModelEvaluationSlicesAsync(ModelEvaluationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelEvaluationSlicesRequest request = new ListModelEvaluationSlicesRequest
            {
                ParentAsModelEvaluationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListModelEvaluationSlicesAsync(request, callSettings);
        }
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

        private readonly gaxgrpc::ApiCall<ListModelVersionsRequest, ListModelVersionsResponse> _callListModelVersions;

        private readonly gaxgrpc::ApiCall<ListModelVersionCheckpointsRequest, ListModelVersionCheckpointsResponse> _callListModelVersionCheckpoints;

        private readonly gaxgrpc::ApiCall<UpdateModelRequest, Model> _callUpdateModel;

        private readonly gaxgrpc::ApiCall<UpdateExplanationDatasetRequest, lro::Operation> _callUpdateExplanationDataset;

        private readonly gaxgrpc::ApiCall<DeleteModelRequest, lro::Operation> _callDeleteModel;

        private readonly gaxgrpc::ApiCall<DeleteModelVersionRequest, lro::Operation> _callDeleteModelVersion;

        private readonly gaxgrpc::ApiCall<MergeVersionAliasesRequest, Model> _callMergeVersionAliases;

        private readonly gaxgrpc::ApiCall<ExportModelRequest, lro::Operation> _callExportModel;

        private readonly gaxgrpc::ApiCall<CopyModelRequest, lro::Operation> _callCopyModel;

        private readonly gaxgrpc::ApiCall<ImportModelEvaluationRequest, ModelEvaluation> _callImportModelEvaluation;

        private readonly gaxgrpc::ApiCall<BatchImportModelEvaluationSlicesRequest, BatchImportModelEvaluationSlicesResponse> _callBatchImportModelEvaluationSlices;

        private readonly gaxgrpc::ApiCall<BatchImportEvaluatedAnnotationsRequest, BatchImportEvaluatedAnnotationsResponse> _callBatchImportEvaluatedAnnotations;

        private readonly gaxgrpc::ApiCall<GetModelEvaluationRequest, ModelEvaluation> _callGetModelEvaluation;

        private readonly gaxgrpc::ApiCall<ListModelEvaluationsRequest, ListModelEvaluationsResponse> _callListModelEvaluations;

        private readonly gaxgrpc::ApiCall<GetModelEvaluationSliceRequest, ModelEvaluationSlice> _callGetModelEvaluationSlice;

        private readonly gaxgrpc::ApiCall<ListModelEvaluationSlicesRequest, ListModelEvaluationSlicesResponse> _callListModelEvaluationSlices;

        /// <summary>
        /// Constructs a client wrapper for the ModelService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ModelServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ModelServiceClientImpl(ModelService.ModelServiceClient grpcClient, ModelServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ModelServiceSettings effectiveSettings = settings ?? ModelServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            UploadModelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UploadModelOperationsSettings, logger);
            UpdateExplanationDatasetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateExplanationDatasetOperationsSettings, logger);
            DeleteModelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteModelOperationsSettings, logger);
            DeleteModelVersionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteModelVersionOperationsSettings, logger);
            ExportModelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ExportModelOperationsSettings, logger);
            CopyModelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CopyModelOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callUploadModel = clientHelper.BuildApiCall<UploadModelRequest, lro::Operation>("UploadModel", grpcClient.UploadModelAsync, grpcClient.UploadModel, effectiveSettings.UploadModelSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callUploadModel);
            Modify_UploadModelApiCall(ref _callUploadModel);
            _callGetModel = clientHelper.BuildApiCall<GetModelRequest, Model>("GetModel", grpcClient.GetModelAsync, grpcClient.GetModel, effectiveSettings.GetModelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetModel);
            Modify_GetModelApiCall(ref _callGetModel);
            _callListModels = clientHelper.BuildApiCall<ListModelsRequest, ListModelsResponse>("ListModels", grpcClient.ListModelsAsync, grpcClient.ListModels, effectiveSettings.ListModelsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListModels);
            Modify_ListModelsApiCall(ref _callListModels);
            _callListModelVersions = clientHelper.BuildApiCall<ListModelVersionsRequest, ListModelVersionsResponse>("ListModelVersions", grpcClient.ListModelVersionsAsync, grpcClient.ListModelVersions, effectiveSettings.ListModelVersionsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callListModelVersions);
            Modify_ListModelVersionsApiCall(ref _callListModelVersions);
            _callListModelVersionCheckpoints = clientHelper.BuildApiCall<ListModelVersionCheckpointsRequest, ListModelVersionCheckpointsResponse>("ListModelVersionCheckpoints", grpcClient.ListModelVersionCheckpointsAsync, grpcClient.ListModelVersionCheckpoints, effectiveSettings.ListModelVersionCheckpointsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callListModelVersionCheckpoints);
            Modify_ListModelVersionCheckpointsApiCall(ref _callListModelVersionCheckpoints);
            _callUpdateModel = clientHelper.BuildApiCall<UpdateModelRequest, Model>("UpdateModel", grpcClient.UpdateModelAsync, grpcClient.UpdateModel, effectiveSettings.UpdateModelSettings).WithGoogleRequestParam("model.name", request => request.Model?.Name);
            Modify_ApiCall(ref _callUpdateModel);
            Modify_UpdateModelApiCall(ref _callUpdateModel);
            _callUpdateExplanationDataset = clientHelper.BuildApiCall<UpdateExplanationDatasetRequest, lro::Operation>("UpdateExplanationDataset", grpcClient.UpdateExplanationDatasetAsync, grpcClient.UpdateExplanationDataset, effectiveSettings.UpdateExplanationDatasetSettings).WithGoogleRequestParam("model", request => request.Model);
            Modify_ApiCall(ref _callUpdateExplanationDataset);
            Modify_UpdateExplanationDatasetApiCall(ref _callUpdateExplanationDataset);
            _callDeleteModel = clientHelper.BuildApiCall<DeleteModelRequest, lro::Operation>("DeleteModel", grpcClient.DeleteModelAsync, grpcClient.DeleteModel, effectiveSettings.DeleteModelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteModel);
            Modify_DeleteModelApiCall(ref _callDeleteModel);
            _callDeleteModelVersion = clientHelper.BuildApiCall<DeleteModelVersionRequest, lro::Operation>("DeleteModelVersion", grpcClient.DeleteModelVersionAsync, grpcClient.DeleteModelVersion, effectiveSettings.DeleteModelVersionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteModelVersion);
            Modify_DeleteModelVersionApiCall(ref _callDeleteModelVersion);
            _callMergeVersionAliases = clientHelper.BuildApiCall<MergeVersionAliasesRequest, Model>("MergeVersionAliases", grpcClient.MergeVersionAliasesAsync, grpcClient.MergeVersionAliases, effectiveSettings.MergeVersionAliasesSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callMergeVersionAliases);
            Modify_MergeVersionAliasesApiCall(ref _callMergeVersionAliases);
            _callExportModel = clientHelper.BuildApiCall<ExportModelRequest, lro::Operation>("ExportModel", grpcClient.ExportModelAsync, grpcClient.ExportModel, effectiveSettings.ExportModelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callExportModel);
            Modify_ExportModelApiCall(ref _callExportModel);
            _callCopyModel = clientHelper.BuildApiCall<CopyModelRequest, lro::Operation>("CopyModel", grpcClient.CopyModelAsync, grpcClient.CopyModel, effectiveSettings.CopyModelSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCopyModel);
            Modify_CopyModelApiCall(ref _callCopyModel);
            _callImportModelEvaluation = clientHelper.BuildApiCall<ImportModelEvaluationRequest, ModelEvaluation>("ImportModelEvaluation", grpcClient.ImportModelEvaluationAsync, grpcClient.ImportModelEvaluation, effectiveSettings.ImportModelEvaluationSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callImportModelEvaluation);
            Modify_ImportModelEvaluationApiCall(ref _callImportModelEvaluation);
            _callBatchImportModelEvaluationSlices = clientHelper.BuildApiCall<BatchImportModelEvaluationSlicesRequest, BatchImportModelEvaluationSlicesResponse>("BatchImportModelEvaluationSlices", grpcClient.BatchImportModelEvaluationSlicesAsync, grpcClient.BatchImportModelEvaluationSlices, effectiveSettings.BatchImportModelEvaluationSlicesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchImportModelEvaluationSlices);
            Modify_BatchImportModelEvaluationSlicesApiCall(ref _callBatchImportModelEvaluationSlices);
            _callBatchImportEvaluatedAnnotations = clientHelper.BuildApiCall<BatchImportEvaluatedAnnotationsRequest, BatchImportEvaluatedAnnotationsResponse>("BatchImportEvaluatedAnnotations", grpcClient.BatchImportEvaluatedAnnotationsAsync, grpcClient.BatchImportEvaluatedAnnotations, effectiveSettings.BatchImportEvaluatedAnnotationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchImportEvaluatedAnnotations);
            Modify_BatchImportEvaluatedAnnotationsApiCall(ref _callBatchImportEvaluatedAnnotations);
            _callGetModelEvaluation = clientHelper.BuildApiCall<GetModelEvaluationRequest, ModelEvaluation>("GetModelEvaluation", grpcClient.GetModelEvaluationAsync, grpcClient.GetModelEvaluation, effectiveSettings.GetModelEvaluationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetModelEvaluation);
            Modify_GetModelEvaluationApiCall(ref _callGetModelEvaluation);
            _callListModelEvaluations = clientHelper.BuildApiCall<ListModelEvaluationsRequest, ListModelEvaluationsResponse>("ListModelEvaluations", grpcClient.ListModelEvaluationsAsync, grpcClient.ListModelEvaluations, effectiveSettings.ListModelEvaluationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListModelEvaluations);
            Modify_ListModelEvaluationsApiCall(ref _callListModelEvaluations);
            _callGetModelEvaluationSlice = clientHelper.BuildApiCall<GetModelEvaluationSliceRequest, ModelEvaluationSlice>("GetModelEvaluationSlice", grpcClient.GetModelEvaluationSliceAsync, grpcClient.GetModelEvaluationSlice, effectiveSettings.GetModelEvaluationSliceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetModelEvaluationSlice);
            Modify_GetModelEvaluationSliceApiCall(ref _callGetModelEvaluationSlice);
            _callListModelEvaluationSlices = clientHelper.BuildApiCall<ListModelEvaluationSlicesRequest, ListModelEvaluationSlicesResponse>("ListModelEvaluationSlices", grpcClient.ListModelEvaluationSlicesAsync, grpcClient.ListModelEvaluationSlices, effectiveSettings.ListModelEvaluationSlicesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListModelEvaluationSlices);
            Modify_ListModelEvaluationSlicesApiCall(ref _callListModelEvaluationSlices);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_UploadModelApiCall(ref gaxgrpc::ApiCall<UploadModelRequest, lro::Operation> call);

        partial void Modify_GetModelApiCall(ref gaxgrpc::ApiCall<GetModelRequest, Model> call);

        partial void Modify_ListModelsApiCall(ref gaxgrpc::ApiCall<ListModelsRequest, ListModelsResponse> call);

        partial void Modify_ListModelVersionsApiCall(ref gaxgrpc::ApiCall<ListModelVersionsRequest, ListModelVersionsResponse> call);

        partial void Modify_ListModelVersionCheckpointsApiCall(ref gaxgrpc::ApiCall<ListModelVersionCheckpointsRequest, ListModelVersionCheckpointsResponse> call);

        partial void Modify_UpdateModelApiCall(ref gaxgrpc::ApiCall<UpdateModelRequest, Model> call);

        partial void Modify_UpdateExplanationDatasetApiCall(ref gaxgrpc::ApiCall<UpdateExplanationDatasetRequest, lro::Operation> call);

        partial void Modify_DeleteModelApiCall(ref gaxgrpc::ApiCall<DeleteModelRequest, lro::Operation> call);

        partial void Modify_DeleteModelVersionApiCall(ref gaxgrpc::ApiCall<DeleteModelVersionRequest, lro::Operation> call);

        partial void Modify_MergeVersionAliasesApiCall(ref gaxgrpc::ApiCall<MergeVersionAliasesRequest, Model> call);

        partial void Modify_ExportModelApiCall(ref gaxgrpc::ApiCall<ExportModelRequest, lro::Operation> call);

        partial void Modify_CopyModelApiCall(ref gaxgrpc::ApiCall<CopyModelRequest, lro::Operation> call);

        partial void Modify_ImportModelEvaluationApiCall(ref gaxgrpc::ApiCall<ImportModelEvaluationRequest, ModelEvaluation> call);

        partial void Modify_BatchImportModelEvaluationSlicesApiCall(ref gaxgrpc::ApiCall<BatchImportModelEvaluationSlicesRequest, BatchImportModelEvaluationSlicesResponse> call);

        partial void Modify_BatchImportEvaluatedAnnotationsApiCall(ref gaxgrpc::ApiCall<BatchImportEvaluatedAnnotationsRequest, BatchImportEvaluatedAnnotationsResponse> call);

        partial void Modify_GetModelEvaluationApiCall(ref gaxgrpc::ApiCall<GetModelEvaluationRequest, ModelEvaluation> call);

        partial void Modify_ListModelEvaluationsApiCall(ref gaxgrpc::ApiCall<ListModelEvaluationsRequest, ListModelEvaluationsResponse> call);

        partial void Modify_GetModelEvaluationSliceApiCall(ref gaxgrpc::ApiCall<GetModelEvaluationSliceRequest, ModelEvaluationSlice> call);

        partial void Modify_ListModelEvaluationSlicesApiCall(ref gaxgrpc::ApiCall<ListModelEvaluationSlicesRequest, ListModelEvaluationSlicesResponse> call);

        partial void OnConstruction(ModelService.ModelServiceClient grpcClient, ModelServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ModelService client</summary>
        public override ModelService.ModelServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_UploadModelRequest(ref UploadModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetModelRequest(ref GetModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListModelsRequest(ref ListModelsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListModelVersionsRequest(ref ListModelVersionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListModelVersionCheckpointsRequest(ref ListModelVersionCheckpointsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateModelRequest(ref UpdateModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateExplanationDatasetRequest(ref UpdateExplanationDatasetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteModelRequest(ref DeleteModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteModelVersionRequest(ref DeleteModelVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MergeVersionAliasesRequest(ref MergeVersionAliasesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportModelRequest(ref ExportModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CopyModelRequest(ref CopyModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportModelEvaluationRequest(ref ImportModelEvaluationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchImportModelEvaluationSlicesRequest(ref BatchImportModelEvaluationSlicesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchImportEvaluatedAnnotationsRequest(ref BatchImportEvaluatedAnnotationsRequest request, ref gaxgrpc::CallSettings settings);

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
        /// Lists versions of the specified model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Model"/> resources.</returns>
        public override gax::PagedEnumerable<ListModelVersionsResponse, Model> ListModelVersions(ListModelVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListModelVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListModelVersionsRequest, ListModelVersionsResponse, Model>(_callListModelVersions, request, callSettings);
        }

        /// <summary>
        /// Lists versions of the specified model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Model"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListModelVersionsResponse, Model> ListModelVersionsAsync(ListModelVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListModelVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListModelVersionsRequest, ListModelVersionsResponse, Model>(_callListModelVersions, request, callSettings);
        }

        /// <summary>
        /// Lists checkpoints of the specified model version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ModelVersionCheckpoint"/> resources.</returns>
        public override gax::PagedEnumerable<ListModelVersionCheckpointsResponse, ModelVersionCheckpoint> ListModelVersionCheckpoints(ListModelVersionCheckpointsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListModelVersionCheckpointsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListModelVersionCheckpointsRequest, ListModelVersionCheckpointsResponse, ModelVersionCheckpoint>(_callListModelVersionCheckpoints, request, callSettings);
        }

        /// <summary>
        /// Lists checkpoints of the specified model version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ModelVersionCheckpoint"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListModelVersionCheckpointsResponse, ModelVersionCheckpoint> ListModelVersionCheckpointsAsync(ListModelVersionCheckpointsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListModelVersionCheckpointsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListModelVersionCheckpointsRequest, ListModelVersionCheckpointsResponse, ModelVersionCheckpoint>(_callListModelVersionCheckpoints, request, callSettings);
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

        /// <summary>The long-running operations client for <c>UpdateExplanationDataset</c>.</summary>
        public override lro::OperationsClient UpdateExplanationDatasetOperationsClient { get; }

        /// <summary>
        /// Incrementally update the dataset used for an examples model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<UpdateExplanationDatasetResponse, UpdateExplanationDatasetOperationMetadata> UpdateExplanationDataset(UpdateExplanationDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateExplanationDatasetRequest(ref request, ref callSettings);
            return new lro::Operation<UpdateExplanationDatasetResponse, UpdateExplanationDatasetOperationMetadata>(_callUpdateExplanationDataset.Sync(request, callSettings), UpdateExplanationDatasetOperationsClient);
        }

        /// <summary>
        /// Incrementally update the dataset used for an examples model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<UpdateExplanationDatasetResponse, UpdateExplanationDatasetOperationMetadata>> UpdateExplanationDatasetAsync(UpdateExplanationDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateExplanationDatasetRequest(ref request, ref callSettings);
            return new lro::Operation<UpdateExplanationDatasetResponse, UpdateExplanationDatasetOperationMetadata>(await _callUpdateExplanationDataset.Async(request, callSettings).ConfigureAwait(false), UpdateExplanationDatasetOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteModel</c>.</summary>
        public override lro::OperationsClient DeleteModelOperationsClient { get; }

        /// <summary>
        /// Deletes a Model.
        /// 
        /// A model cannot be deleted if any
        /// [Endpoint][google.cloud.aiplatform.v1.Endpoint] resource has a
        /// [DeployedModel][google.cloud.aiplatform.v1.DeployedModel] based on the
        /// model in its
        /// [deployed_models][google.cloud.aiplatform.v1.Endpoint.deployed_models]
        /// field.
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
        /// 
        /// A model cannot be deleted if any
        /// [Endpoint][google.cloud.aiplatform.v1.Endpoint] resource has a
        /// [DeployedModel][google.cloud.aiplatform.v1.DeployedModel] based on the
        /// model in its
        /// [deployed_models][google.cloud.aiplatform.v1.Endpoint.deployed_models]
        /// field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteModelAsync(DeleteModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteModelRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(await _callDeleteModel.Async(request, callSettings).ConfigureAwait(false), DeleteModelOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteModelVersion</c>.</summary>
        public override lro::OperationsClient DeleteModelVersionOperationsClient { get; }

        /// <summary>
        /// Deletes a Model version.
        /// 
        /// Model version can only be deleted if there are no
        /// [DeployedModels][google.cloud.aiplatform.v1.DeployedModel] created from it.
        /// Deleting the only version in the Model is not allowed. Use
        /// [DeleteModel][google.cloud.aiplatform.v1.ModelService.DeleteModel] for
        /// deleting the Model instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteModelVersion(DeleteModelVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteModelVersionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(_callDeleteModelVersion.Sync(request, callSettings), DeleteModelVersionOperationsClient);
        }

        /// <summary>
        /// Deletes a Model version.
        /// 
        /// Model version can only be deleted if there are no
        /// [DeployedModels][google.cloud.aiplatform.v1.DeployedModel] created from it.
        /// Deleting the only version in the Model is not allowed. Use
        /// [DeleteModel][google.cloud.aiplatform.v1.ModelService.DeleteModel] for
        /// deleting the Model instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteModelVersionAsync(DeleteModelVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteModelVersionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(await _callDeleteModelVersion.Async(request, callSettings).ConfigureAwait(false), DeleteModelVersionOperationsClient);
        }

        /// <summary>
        /// Merges a set of aliases for a Model version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Model MergeVersionAliases(MergeVersionAliasesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MergeVersionAliasesRequest(ref request, ref callSettings);
            return _callMergeVersionAliases.Sync(request, callSettings);
        }

        /// <summary>
        /// Merges a set of aliases for a Model version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Model> MergeVersionAliasesAsync(MergeVersionAliasesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MergeVersionAliasesRequest(ref request, ref callSettings);
            return _callMergeVersionAliases.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>ExportModel</c>.</summary>
        public override lro::OperationsClient ExportModelOperationsClient { get; }

        /// <summary>
        /// Exports a trained, exportable Model to a location specified by the
        /// user. A Model is considered to be exportable if it has at least one
        /// [supported export
        /// format][google.cloud.aiplatform.v1.Model.supported_export_formats].
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
        /// Exports a trained, exportable Model to a location specified by the
        /// user. A Model is considered to be exportable if it has at least one
        /// [supported export
        /// format][google.cloud.aiplatform.v1.Model.supported_export_formats].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ExportModelResponse, ExportModelOperationMetadata>> ExportModelAsync(ExportModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportModelRequest(ref request, ref callSettings);
            return new lro::Operation<ExportModelResponse, ExportModelOperationMetadata>(await _callExportModel.Async(request, callSettings).ConfigureAwait(false), ExportModelOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CopyModel</c>.</summary>
        public override lro::OperationsClient CopyModelOperationsClient { get; }

        /// <summary>
        /// Copies an already existing Vertex AI Model into the specified Location.
        /// The source Model must exist in the same Project.
        /// When copying custom Models, the users themselves are responsible for
        /// [Model.metadata][google.cloud.aiplatform.v1.Model.metadata] content to be
        /// region-agnostic, as well as making sure that any resources (e.g. files) it
        /// depends on remain accessible.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<CopyModelResponse, CopyModelOperationMetadata> CopyModel(CopyModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CopyModelRequest(ref request, ref callSettings);
            return new lro::Operation<CopyModelResponse, CopyModelOperationMetadata>(_callCopyModel.Sync(request, callSettings), CopyModelOperationsClient);
        }

        /// <summary>
        /// Copies an already existing Vertex AI Model into the specified Location.
        /// The source Model must exist in the same Project.
        /// When copying custom Models, the users themselves are responsible for
        /// [Model.metadata][google.cloud.aiplatform.v1.Model.metadata] content to be
        /// region-agnostic, as well as making sure that any resources (e.g. files) it
        /// depends on remain accessible.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<CopyModelResponse, CopyModelOperationMetadata>> CopyModelAsync(CopyModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CopyModelRequest(ref request, ref callSettings);
            return new lro::Operation<CopyModelResponse, CopyModelOperationMetadata>(await _callCopyModel.Async(request, callSettings).ConfigureAwait(false), CopyModelOperationsClient);
        }

        /// <summary>
        /// Imports an externally generated ModelEvaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ModelEvaluation ImportModelEvaluation(ImportModelEvaluationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportModelEvaluationRequest(ref request, ref callSettings);
            return _callImportModelEvaluation.Sync(request, callSettings);
        }

        /// <summary>
        /// Imports an externally generated ModelEvaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ModelEvaluation> ImportModelEvaluationAsync(ImportModelEvaluationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportModelEvaluationRequest(ref request, ref callSettings);
            return _callImportModelEvaluation.Async(request, callSettings);
        }

        /// <summary>
        /// Imports a list of externally generated ModelEvaluationSlice.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchImportModelEvaluationSlicesResponse BatchImportModelEvaluationSlices(BatchImportModelEvaluationSlicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchImportModelEvaluationSlicesRequest(ref request, ref callSettings);
            return _callBatchImportModelEvaluationSlices.Sync(request, callSettings);
        }

        /// <summary>
        /// Imports a list of externally generated ModelEvaluationSlice.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchImportModelEvaluationSlicesResponse> BatchImportModelEvaluationSlicesAsync(BatchImportModelEvaluationSlicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchImportModelEvaluationSlicesRequest(ref request, ref callSettings);
            return _callBatchImportModelEvaluationSlices.Async(request, callSettings);
        }

        /// <summary>
        /// Imports a list of externally generated EvaluatedAnnotations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchImportEvaluatedAnnotationsResponse BatchImportEvaluatedAnnotations(BatchImportEvaluatedAnnotationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchImportEvaluatedAnnotationsRequest(ref request, ref callSettings);
            return _callBatchImportEvaluatedAnnotations.Sync(request, callSettings);
        }

        /// <summary>
        /// Imports a list of externally generated EvaluatedAnnotations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchImportEvaluatedAnnotationsResponse> BatchImportEvaluatedAnnotationsAsync(BatchImportEvaluatedAnnotationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchImportEvaluatedAnnotationsRequest(ref request, ref callSettings);
            return _callBatchImportEvaluatedAnnotations.Async(request, callSettings);
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

    public partial class ListModelVersionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListModelVersionCheckpointsRequest : gaxgrpc::IPageRequest
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

    public partial class ListModelVersionsResponse : gaxgrpc::IPageResponse<Model>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Model> GetEnumerator() => Models.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListModelVersionCheckpointsResponse : gaxgrpc::IPageResponse<ModelVersionCheckpoint>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ModelVersionCheckpoint> GetEnumerator() => Checkpoints.GetEnumerator();

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

    public static partial class ModelService
    {
        public partial class ModelServiceClient
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
