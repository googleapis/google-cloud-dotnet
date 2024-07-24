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
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
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

namespace Google.Cloud.Retail.V2
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
            CreateModelSettings = existing.CreateModelSettings;
            CreateModelOperationsSettings = existing.CreateModelOperationsSettings.Clone();
            GetModelSettings = existing.GetModelSettings;
            PauseModelSettings = existing.PauseModelSettings;
            ResumeModelSettings = existing.ResumeModelSettings;
            DeleteModelSettings = existing.DeleteModelSettings;
            ListModelsSettings = existing.ListModelsSettings;
            UpdateModelSettings = existing.UpdateModelSettings;
            TuneModelSettings = existing.TuneModelSettings;
            TuneModelOperationsSettings = existing.TuneModelOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ModelServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelServiceClient.CreateModel</c> and <c>ModelServiceClient.CreateModelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateModelSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ModelServiceClient.CreateModel</c> and
        /// <c>ModelServiceClient.CreateModelAsync</c>.
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
        public lro::OperationsSettings CreateModelOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ModelServiceClient.GetModel</c>
        ///  and <c>ModelServiceClient.GetModelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetModelSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelServiceClient.PauseModel</c> and <c>ModelServiceClient.PauseModelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PauseModelSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelServiceClient.ResumeModel</c> and <c>ModelServiceClient.ResumeModelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ResumeModelSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelServiceClient.DeleteModel</c> and <c>ModelServiceClient.DeleteModelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteModelSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelServiceClient.ListModels</c> and <c>ModelServiceClient.ListModelsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListModelsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelServiceClient.UpdateModel</c> and <c>ModelServiceClient.UpdateModelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateModelSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelServiceClient.TuneModel</c> and <c>ModelServiceClient.TuneModelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TuneModelSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ModelServiceClient.TuneModel</c> and
        /// <c>ModelServiceClient.TuneModelAsync</c>.
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
        public lro::OperationsSettings TuneModelOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

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
    /// Service for performing CRUD operations on models.
    /// Recommendation models contain all the metadata necessary to generate a set of
    /// models for the `Predict()` API. A model is queried
    /// indirectly via a ServingConfig, which associates a model with a
    /// given Placement (e.g. Frequently Bought Together on Home Page).
    /// 
    /// This service allows you to do the following:
    /// 
    /// * Initiate training of a model.
    /// * Pause training of an existing model.
    /// * List all the available models along with their metadata.
    /// * Control their tuning schedule.
    /// </remarks>
    public abstract partial class ModelServiceClient
    {
        /// <summary>
        /// The default endpoint for the ModelService service, which is a host of "retail.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "retail.googleapis.com:443";

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

        /// <summary>
        /// Creates a new model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Model, CreateModelMetadata> CreateModel(CreateModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Model, CreateModelMetadata>> CreateModelAsync(CreateModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Model, CreateModelMetadata>> CreateModelAsync(CreateModelRequest request, st::CancellationToken cancellationToken) =>
            CreateModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateModel</c>.</summary>
        public virtual lro::OperationsClient CreateModelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Model, CreateModelMetadata> PollOnceCreateModel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Model, CreateModelMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateModelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Model, CreateModelMetadata>> PollOnceCreateModelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Model, CreateModelMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateModelOperationsClient, callSettings);

        /// <summary>
        /// Creates a new model.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource under which to create the model. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}`
        /// </param>
        /// <param name="model">
        /// Required. The payload of the [Model][google.cloud.retail.v2.Model]  to
        /// create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Model, CreateModelMetadata> CreateModel(string parent, Model model, gaxgrpc::CallSettings callSettings = null) =>
            CreateModel(new CreateModelRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Model = gax::GaxPreconditions.CheckNotNull(model, nameof(model)),
            }, callSettings);

        /// <summary>
        /// Creates a new model.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource under which to create the model. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}`
        /// </param>
        /// <param name="model">
        /// Required. The payload of the [Model][google.cloud.retail.v2.Model]  to
        /// create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Model, CreateModelMetadata>> CreateModelAsync(string parent, Model model, gaxgrpc::CallSettings callSettings = null) =>
            CreateModelAsync(new CreateModelRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Model = gax::GaxPreconditions.CheckNotNull(model, nameof(model)),
            }, callSettings);

        /// <summary>
        /// Creates a new model.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource under which to create the model. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}`
        /// </param>
        /// <param name="model">
        /// Required. The payload of the [Model][google.cloud.retail.v2.Model]  to
        /// create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Model, CreateModelMetadata>> CreateModelAsync(string parent, Model model, st::CancellationToken cancellationToken) =>
            CreateModelAsync(parent, model, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new model.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource under which to create the model. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}`
        /// </param>
        /// <param name="model">
        /// Required. The payload of the [Model][google.cloud.retail.v2.Model]  to
        /// create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Model, CreateModelMetadata> CreateModel(CatalogName parent, Model model, gaxgrpc::CallSettings callSettings = null) =>
            CreateModel(new CreateModelRequest
            {
                ParentAsCatalogName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Model = gax::GaxPreconditions.CheckNotNull(model, nameof(model)),
            }, callSettings);

        /// <summary>
        /// Creates a new model.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource under which to create the model. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}`
        /// </param>
        /// <param name="model">
        /// Required. The payload of the [Model][google.cloud.retail.v2.Model]  to
        /// create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Model, CreateModelMetadata>> CreateModelAsync(CatalogName parent, Model model, gaxgrpc::CallSettings callSettings = null) =>
            CreateModelAsync(new CreateModelRequest
            {
                ParentAsCatalogName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Model = gax::GaxPreconditions.CheckNotNull(model, nameof(model)),
            }, callSettings);

        /// <summary>
        /// Creates a new model.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource under which to create the model. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}`
        /// </param>
        /// <param name="model">
        /// Required. The payload of the [Model][google.cloud.retail.v2.Model]  to
        /// create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Model, CreateModelMetadata>> CreateModelAsync(CatalogName parent, Model model, st::CancellationToken cancellationToken) =>
            CreateModelAsync(parent, model, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Model GetModel(GetModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> GetModelAsync(GetModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> GetModelAsync(GetModelRequest request, st::CancellationToken cancellationToken) =>
            GetModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a model.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the [Model][google.cloud.retail.v2.Model] to
        /// get. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog}/models/{model_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Model GetModel(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetModel(new GetModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a model.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the [Model][google.cloud.retail.v2.Model] to
        /// get. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog}/models/{model_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> GetModelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetModelAsync(new GetModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a model.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the [Model][google.cloud.retail.v2.Model] to
        /// get. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog}/models/{model_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> GetModelAsync(string name, st::CancellationToken cancellationToken) =>
            GetModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a model.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the [Model][google.cloud.retail.v2.Model] to
        /// get. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog}/models/{model_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Model GetModel(ModelName name, gaxgrpc::CallSettings callSettings = null) =>
            GetModel(new GetModelRequest
            {
                ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a model.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the [Model][google.cloud.retail.v2.Model] to
        /// get. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog}/models/{model_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> GetModelAsync(ModelName name, gaxgrpc::CallSettings callSettings = null) =>
            GetModelAsync(new GetModelRequest
            {
                ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a model.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the [Model][google.cloud.retail.v2.Model] to
        /// get. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog}/models/{model_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> GetModelAsync(ModelName name, st::CancellationToken cancellationToken) =>
            GetModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Pauses the training of an existing model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Model PauseModel(PauseModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Pauses the training of an existing model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> PauseModelAsync(PauseModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Pauses the training of an existing model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> PauseModelAsync(PauseModelRequest request, st::CancellationToken cancellationToken) =>
            PauseModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Pauses the training of an existing model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the model to pause.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/models/{model_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Model PauseModel(string name, gaxgrpc::CallSettings callSettings = null) =>
            PauseModel(new PauseModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Pauses the training of an existing model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the model to pause.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/models/{model_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> PauseModelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            PauseModelAsync(new PauseModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Pauses the training of an existing model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the model to pause.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/models/{model_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> PauseModelAsync(string name, st::CancellationToken cancellationToken) =>
            PauseModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Pauses the training of an existing model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the model to pause.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/models/{model_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Model PauseModel(ModelName name, gaxgrpc::CallSettings callSettings = null) =>
            PauseModel(new PauseModelRequest
            {
                ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Pauses the training of an existing model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the model to pause.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/models/{model_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> PauseModelAsync(ModelName name, gaxgrpc::CallSettings callSettings = null) =>
            PauseModelAsync(new PauseModelRequest
            {
                ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Pauses the training of an existing model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the model to pause.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/models/{model_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> PauseModelAsync(ModelName name, st::CancellationToken cancellationToken) =>
            PauseModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resumes the training of an existing model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Model ResumeModel(ResumeModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resumes the training of an existing model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> ResumeModelAsync(ResumeModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resumes the training of an existing model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> ResumeModelAsync(ResumeModelRequest request, st::CancellationToken cancellationToken) =>
            ResumeModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resumes the training of an existing model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the model to resume.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/models/{model_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Model ResumeModel(string name, gaxgrpc::CallSettings callSettings = null) =>
            ResumeModel(new ResumeModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Resumes the training of an existing model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the model to resume.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/models/{model_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> ResumeModelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ResumeModelAsync(new ResumeModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Resumes the training of an existing model.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the model to resume.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/models/{model_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> ResumeModelAsync(string name, st::CancellationToken cancellationToken) =>
            ResumeModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteModel(DeleteModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an existing model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteModelAsync(DeleteModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an existing model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteModelAsync(DeleteModelRequest request, st::CancellationToken cancellationToken) =>
            DeleteModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing model.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the [Model][google.cloud.retail.v2.Model] to
        /// delete. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/models/{model_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteModel(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteModel(new DeleteModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing model.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the [Model][google.cloud.retail.v2.Model] to
        /// delete. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/models/{model_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteModelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteModelAsync(new DeleteModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing model.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the [Model][google.cloud.retail.v2.Model] to
        /// delete. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/models/{model_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteModelAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing model.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the [Model][google.cloud.retail.v2.Model] to
        /// delete. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/models/{model_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteModel(ModelName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteModel(new DeleteModelRequest
            {
                ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing model.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the [Model][google.cloud.retail.v2.Model] to
        /// delete. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/models/{model_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteModelAsync(ModelName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteModelAsync(new DeleteModelRequest
            {
                ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing model.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the [Model][google.cloud.retail.v2.Model] to
        /// delete. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/models/{model_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteModelAsync(ModelName name, st::CancellationToken cancellationToken) =>
            DeleteModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all the models linked to this event store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Model"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListModelsResponse, Model> ListModels(ListModelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the models linked to this event store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Model"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListModelsResponse, Model> ListModelsAsync(ListModelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the models linked to this event store.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent for which to list models.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}`
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
        /// Lists all the models linked to this event store.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent for which to list models.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}`
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
        /// Lists all the models linked to this event store.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent for which to list models.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}`
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
        public virtual gax::PagedEnumerable<ListModelsResponse, Model> ListModels(CatalogName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelsRequest request = new ListModelsRequest
            {
                ParentAsCatalogName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Lists all the models linked to this event store.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent for which to list models.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}`
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
        public virtual gax::PagedAsyncEnumerable<ListModelsResponse, Model> ListModelsAsync(CatalogName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelsRequest request = new ListModelsRequest
            {
                ParentAsCatalogName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Update of model metadata. Only fields that
        /// currently can be updated are: `filtering_option` and
        /// `periodic_tuning_state`.
        /// If other values are provided, this API method ignores them.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Model UpdateModel(UpdateModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update of model metadata. Only fields that
        /// currently can be updated are: `filtering_option` and
        /// `periodic_tuning_state`.
        /// If other values are provided, this API method ignores them.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> UpdateModelAsync(UpdateModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update of model metadata. Only fields that
        /// currently can be updated are: `filtering_option` and
        /// `periodic_tuning_state`.
        /// If other values are provided, this API method ignores them.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> UpdateModelAsync(UpdateModelRequest request, st::CancellationToken cancellationToken) =>
            UpdateModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update of model metadata. Only fields that
        /// currently can be updated are: `filtering_option` and
        /// `periodic_tuning_state`.
        /// If other values are provided, this API method ignores them.
        /// </summary>
        /// <param name="model">
        /// Required. The body of the updated [Model][google.cloud.retail.v2.Model].
        /// </param>
        /// <param name="updateMask">
        /// Optional. Indicates which fields in the provided 'model' to
        /// update. If not set, by default updates all fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Model UpdateModel(Model model, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateModel(new UpdateModelRequest
            {
                Model = gax::GaxPreconditions.CheckNotNull(model, nameof(model)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update of model metadata. Only fields that
        /// currently can be updated are: `filtering_option` and
        /// `periodic_tuning_state`.
        /// If other values are provided, this API method ignores them.
        /// </summary>
        /// <param name="model">
        /// Required. The body of the updated [Model][google.cloud.retail.v2.Model].
        /// </param>
        /// <param name="updateMask">
        /// Optional. Indicates which fields in the provided 'model' to
        /// update. If not set, by default updates all fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> UpdateModelAsync(Model model, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateModelAsync(new UpdateModelRequest
            {
                Model = gax::GaxPreconditions.CheckNotNull(model, nameof(model)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update of model metadata. Only fields that
        /// currently can be updated are: `filtering_option` and
        /// `periodic_tuning_state`.
        /// If other values are provided, this API method ignores them.
        /// </summary>
        /// <param name="model">
        /// Required. The body of the updated [Model][google.cloud.retail.v2.Model].
        /// </param>
        /// <param name="updateMask">
        /// Optional. Indicates which fields in the provided 'model' to
        /// update. If not set, by default updates all fields.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> UpdateModelAsync(Model model, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateModelAsync(model, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Tunes an existing model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TuneModelResponse, TuneModelMetadata> TuneModel(TuneModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Tunes an existing model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TuneModelResponse, TuneModelMetadata>> TuneModelAsync(TuneModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Tunes an existing model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TuneModelResponse, TuneModelMetadata>> TuneModelAsync(TuneModelRequest request, st::CancellationToken cancellationToken) =>
            TuneModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>TuneModel</c>.</summary>
        public virtual lro::OperationsClient TuneModelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>TuneModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<TuneModelResponse, TuneModelMetadata> PollOnceTuneModel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TuneModelResponse, TuneModelMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), TuneModelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>TuneModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<TuneModelResponse, TuneModelMetadata>> PollOnceTuneModelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TuneModelResponse, TuneModelMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), TuneModelOperationsClient, callSettings);

        /// <summary>
        /// Tunes an existing model.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the model to tune.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/models/{model_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TuneModelResponse, TuneModelMetadata> TuneModel(string name, gaxgrpc::CallSettings callSettings = null) =>
            TuneModel(new TuneModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Tunes an existing model.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the model to tune.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/models/{model_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TuneModelResponse, TuneModelMetadata>> TuneModelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            TuneModelAsync(new TuneModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Tunes an existing model.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the model to tune.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/models/{model_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TuneModelResponse, TuneModelMetadata>> TuneModelAsync(string name, st::CancellationToken cancellationToken) =>
            TuneModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Tunes an existing model.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the model to tune.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/models/{model_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TuneModelResponse, TuneModelMetadata> TuneModel(ModelName name, gaxgrpc::CallSettings callSettings = null) =>
            TuneModel(new TuneModelRequest
            {
                ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Tunes an existing model.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the model to tune.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/models/{model_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TuneModelResponse, TuneModelMetadata>> TuneModelAsync(ModelName name, gaxgrpc::CallSettings callSettings = null) =>
            TuneModelAsync(new TuneModelRequest
            {
                ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Tunes an existing model.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the model to tune.
        /// Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/models/{model_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TuneModelResponse, TuneModelMetadata>> TuneModelAsync(ModelName name, st::CancellationToken cancellationToken) =>
            TuneModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ModelService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for performing CRUD operations on models.
    /// Recommendation models contain all the metadata necessary to generate a set of
    /// models for the `Predict()` API. A model is queried
    /// indirectly via a ServingConfig, which associates a model with a
    /// given Placement (e.g. Frequently Bought Together on Home Page).
    /// 
    /// This service allows you to do the following:
    /// 
    /// * Initiate training of a model.
    /// * Pause training of an existing model.
    /// * List all the available models along with their metadata.
    /// * Control their tuning schedule.
    /// </remarks>
    public sealed partial class ModelServiceClientImpl : ModelServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateModelRequest, lro::Operation> _callCreateModel;

        private readonly gaxgrpc::ApiCall<GetModelRequest, Model> _callGetModel;

        private readonly gaxgrpc::ApiCall<PauseModelRequest, Model> _callPauseModel;

        private readonly gaxgrpc::ApiCall<ResumeModelRequest, Model> _callResumeModel;

        private readonly gaxgrpc::ApiCall<DeleteModelRequest, wkt::Empty> _callDeleteModel;

        private readonly gaxgrpc::ApiCall<ListModelsRequest, ListModelsResponse> _callListModels;

        private readonly gaxgrpc::ApiCall<UpdateModelRequest, Model> _callUpdateModel;

        private readonly gaxgrpc::ApiCall<TuneModelRequest, lro::Operation> _callTuneModel;

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
            CreateModelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateModelOperationsSettings, logger);
            TuneModelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.TuneModelOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCreateModel = clientHelper.BuildApiCall<CreateModelRequest, lro::Operation>("CreateModel", grpcClient.CreateModelAsync, grpcClient.CreateModel, effectiveSettings.CreateModelSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateModel);
            Modify_CreateModelApiCall(ref _callCreateModel);
            _callGetModel = clientHelper.BuildApiCall<GetModelRequest, Model>("GetModel", grpcClient.GetModelAsync, grpcClient.GetModel, effectiveSettings.GetModelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetModel);
            Modify_GetModelApiCall(ref _callGetModel);
            _callPauseModel = clientHelper.BuildApiCall<PauseModelRequest, Model>("PauseModel", grpcClient.PauseModelAsync, grpcClient.PauseModel, effectiveSettings.PauseModelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callPauseModel);
            Modify_PauseModelApiCall(ref _callPauseModel);
            _callResumeModel = clientHelper.BuildApiCall<ResumeModelRequest, Model>("ResumeModel", grpcClient.ResumeModelAsync, grpcClient.ResumeModel, effectiveSettings.ResumeModelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callResumeModel);
            Modify_ResumeModelApiCall(ref _callResumeModel);
            _callDeleteModel = clientHelper.BuildApiCall<DeleteModelRequest, wkt::Empty>("DeleteModel", grpcClient.DeleteModelAsync, grpcClient.DeleteModel, effectiveSettings.DeleteModelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteModel);
            Modify_DeleteModelApiCall(ref _callDeleteModel);
            _callListModels = clientHelper.BuildApiCall<ListModelsRequest, ListModelsResponse>("ListModels", grpcClient.ListModelsAsync, grpcClient.ListModels, effectiveSettings.ListModelsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListModels);
            Modify_ListModelsApiCall(ref _callListModels);
            _callUpdateModel = clientHelper.BuildApiCall<UpdateModelRequest, Model>("UpdateModel", grpcClient.UpdateModelAsync, grpcClient.UpdateModel, effectiveSettings.UpdateModelSettings).WithGoogleRequestParam("model.name", request => request.Model?.Name);
            Modify_ApiCall(ref _callUpdateModel);
            Modify_UpdateModelApiCall(ref _callUpdateModel);
            _callTuneModel = clientHelper.BuildApiCall<TuneModelRequest, lro::Operation>("TuneModel", grpcClient.TuneModelAsync, grpcClient.TuneModel, effectiveSettings.TuneModelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callTuneModel);
            Modify_TuneModelApiCall(ref _callTuneModel);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateModelApiCall(ref gaxgrpc::ApiCall<CreateModelRequest, lro::Operation> call);

        partial void Modify_GetModelApiCall(ref gaxgrpc::ApiCall<GetModelRequest, Model> call);

        partial void Modify_PauseModelApiCall(ref gaxgrpc::ApiCall<PauseModelRequest, Model> call);

        partial void Modify_ResumeModelApiCall(ref gaxgrpc::ApiCall<ResumeModelRequest, Model> call);

        partial void Modify_DeleteModelApiCall(ref gaxgrpc::ApiCall<DeleteModelRequest, wkt::Empty> call);

        partial void Modify_ListModelsApiCall(ref gaxgrpc::ApiCall<ListModelsRequest, ListModelsResponse> call);

        partial void Modify_UpdateModelApiCall(ref gaxgrpc::ApiCall<UpdateModelRequest, Model> call);

        partial void Modify_TuneModelApiCall(ref gaxgrpc::ApiCall<TuneModelRequest, lro::Operation> call);

        partial void OnConstruction(ModelService.ModelServiceClient grpcClient, ModelServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ModelService client</summary>
        public override ModelService.ModelServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CreateModelRequest(ref CreateModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetModelRequest(ref GetModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PauseModelRequest(ref PauseModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ResumeModelRequest(ref ResumeModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteModelRequest(ref DeleteModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListModelsRequest(ref ListModelsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateModelRequest(ref UpdateModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TuneModelRequest(ref TuneModelRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateModel</c>.</summary>
        public override lro::OperationsClient CreateModelOperationsClient { get; }

        /// <summary>
        /// Creates a new model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Model, CreateModelMetadata> CreateModel(CreateModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateModelRequest(ref request, ref callSettings);
            return new lro::Operation<Model, CreateModelMetadata>(_callCreateModel.Sync(request, callSettings), CreateModelOperationsClient);
        }

        /// <summary>
        /// Creates a new model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Model, CreateModelMetadata>> CreateModelAsync(CreateModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateModelRequest(ref request, ref callSettings);
            return new lro::Operation<Model, CreateModelMetadata>(await _callCreateModel.Async(request, callSettings).ConfigureAwait(false), CreateModelOperationsClient);
        }

        /// <summary>
        /// Gets a model.
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
        /// Gets a model.
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
        /// Pauses the training of an existing model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Model PauseModel(PauseModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PauseModelRequest(ref request, ref callSettings);
            return _callPauseModel.Sync(request, callSettings);
        }

        /// <summary>
        /// Pauses the training of an existing model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Model> PauseModelAsync(PauseModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PauseModelRequest(ref request, ref callSettings);
            return _callPauseModel.Async(request, callSettings);
        }

        /// <summary>
        /// Resumes the training of an existing model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Model ResumeModel(ResumeModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResumeModelRequest(ref request, ref callSettings);
            return _callResumeModel.Sync(request, callSettings);
        }

        /// <summary>
        /// Resumes the training of an existing model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Model> ResumeModelAsync(ResumeModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResumeModelRequest(ref request, ref callSettings);
            return _callResumeModel.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an existing model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteModel(DeleteModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteModelRequest(ref request, ref callSettings);
            _callDeleteModel.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an existing model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteModelAsync(DeleteModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteModelRequest(ref request, ref callSettings);
            return _callDeleteModel.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all the models linked to this event store.
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
        /// Lists all the models linked to this event store.
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
        /// Update of model metadata. Only fields that
        /// currently can be updated are: `filtering_option` and
        /// `periodic_tuning_state`.
        /// If other values are provided, this API method ignores them.
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
        /// Update of model metadata. Only fields that
        /// currently can be updated are: `filtering_option` and
        /// `periodic_tuning_state`.
        /// If other values are provided, this API method ignores them.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Model> UpdateModelAsync(UpdateModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateModelRequest(ref request, ref callSettings);
            return _callUpdateModel.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>TuneModel</c>.</summary>
        public override lro::OperationsClient TuneModelOperationsClient { get; }

        /// <summary>
        /// Tunes an existing model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<TuneModelResponse, TuneModelMetadata> TuneModel(TuneModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TuneModelRequest(ref request, ref callSettings);
            return new lro::Operation<TuneModelResponse, TuneModelMetadata>(_callTuneModel.Sync(request, callSettings), TuneModelOperationsClient);
        }

        /// <summary>
        /// Tunes an existing model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<TuneModelResponse, TuneModelMetadata>> TuneModelAsync(TuneModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TuneModelRequest(ref request, ref callSettings);
            return new lro::Operation<TuneModelResponse, TuneModelMetadata>(await _callTuneModel.Async(request, callSettings).ConfigureAwait(false), TuneModelOperationsClient);
        }
    }

    public partial class ListModelsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListModelsResponse : gaxgrpc::IPageResponse<Model>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Model> GetEnumerator() => Models.GetEnumerator();

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
        }
    }
}
