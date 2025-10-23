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
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Dialogflow.V2Beta1
{
    /// <summary>Settings for <see cref="GeneratorEvaluationsClient"/> instances.</summary>
    public sealed partial class GeneratorEvaluationsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="GeneratorEvaluationsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="GeneratorEvaluationsSettings"/>.</returns>
        public static GeneratorEvaluationsSettings GetDefault() => new GeneratorEvaluationsSettings();

        /// <summary>Constructs a new <see cref="GeneratorEvaluationsSettings"/> object with default settings.</summary>
        public GeneratorEvaluationsSettings()
        {
        }

        private GeneratorEvaluationsSettings(GeneratorEvaluationsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateGeneratorEvaluationSettings = existing.CreateGeneratorEvaluationSettings;
            CreateGeneratorEvaluationOperationsSettings = existing.CreateGeneratorEvaluationOperationsSettings.Clone();
            GetGeneratorEvaluationSettings = existing.GetGeneratorEvaluationSettings;
            ListGeneratorEvaluationsSettings = existing.ListGeneratorEvaluationsSettings;
            DeleteGeneratorEvaluationSettings = existing.DeleteGeneratorEvaluationSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(GeneratorEvaluationsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GeneratorEvaluationsClient.CreateGeneratorEvaluation</c> and
        /// <c>GeneratorEvaluationsClient.CreateGeneratorEvaluationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateGeneratorEvaluationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GeneratorEvaluationsClient.CreateGeneratorEvaluation</c> and
        /// <c>GeneratorEvaluationsClient.CreateGeneratorEvaluationAsync</c>.
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
        public lro::OperationsSettings CreateGeneratorEvaluationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GeneratorEvaluationsClient.GetGeneratorEvaluation</c> and
        /// <c>GeneratorEvaluationsClient.GetGeneratorEvaluationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetGeneratorEvaluationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GeneratorEvaluationsClient.ListGeneratorEvaluations</c> and
        /// <c>GeneratorEvaluationsClient.ListGeneratorEvaluationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListGeneratorEvaluationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GeneratorEvaluationsClient.DeleteGeneratorEvaluation</c> and
        /// <c>GeneratorEvaluationsClient.DeleteGeneratorEvaluationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteGeneratorEvaluationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="GeneratorEvaluationsSettings"/> object.</returns>
        public GeneratorEvaluationsSettings Clone() => new GeneratorEvaluationsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="GeneratorEvaluationsClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class GeneratorEvaluationsClientBuilder : gaxgrpc::ClientBuilderBase<GeneratorEvaluationsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public GeneratorEvaluationsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public GeneratorEvaluationsClientBuilder() : base(GeneratorEvaluationsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref GeneratorEvaluationsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<GeneratorEvaluationsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override GeneratorEvaluationsClient Build()
        {
            GeneratorEvaluationsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<GeneratorEvaluationsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<GeneratorEvaluationsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private GeneratorEvaluationsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return GeneratorEvaluationsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<GeneratorEvaluationsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return GeneratorEvaluationsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => GeneratorEvaluationsClient.ChannelPool;
    }

    /// <summary>GeneratorEvaluations client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing generator evaluations.
    /// </remarks>
    public abstract partial class GeneratorEvaluationsClient
    {
        /// <summary>
        /// The default endpoint for the GeneratorEvaluations service, which is a host of "dialogflow.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dialogflow.googleapis.com:443";

        /// <summary>The default GeneratorEvaluations scopes.</summary>
        /// <remarks>
        /// The default GeneratorEvaluations scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/dialogflow</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/dialogflow",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(GeneratorEvaluations.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="GeneratorEvaluationsClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="GeneratorEvaluationsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="GeneratorEvaluationsClient"/>.</returns>
        public static stt::Task<GeneratorEvaluationsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new GeneratorEvaluationsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="GeneratorEvaluationsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="GeneratorEvaluationsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="GeneratorEvaluationsClient"/>.</returns>
        public static GeneratorEvaluationsClient Create() => new GeneratorEvaluationsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="GeneratorEvaluationsClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="GeneratorEvaluationsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="GeneratorEvaluationsClient"/>.</returns>
        internal static GeneratorEvaluationsClient Create(grpccore::CallInvoker callInvoker, GeneratorEvaluationsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            GeneratorEvaluations.GeneratorEvaluationsClient grpcClient = new GeneratorEvaluations.GeneratorEvaluationsClient(callInvoker);
            return new GeneratorEvaluationsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC GeneratorEvaluations client</summary>
        public virtual GeneratorEvaluations.GeneratorEvaluationsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates evaluation of a generator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GeneratorEvaluation, GeneratorEvaluationOperationMetadata> CreateGeneratorEvaluation(CreateGeneratorEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates evaluation of a generator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GeneratorEvaluation, GeneratorEvaluationOperationMetadata>> CreateGeneratorEvaluationAsync(CreateGeneratorEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates evaluation of a generator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GeneratorEvaluation, GeneratorEvaluationOperationMetadata>> CreateGeneratorEvaluationAsync(CreateGeneratorEvaluationRequest request, st::CancellationToken cancellationToken) =>
            CreateGeneratorEvaluationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateGeneratorEvaluation</c>.</summary>
        public virtual lro::OperationsClient CreateGeneratorEvaluationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateGeneratorEvaluation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<GeneratorEvaluation, GeneratorEvaluationOperationMetadata> PollOnceCreateGeneratorEvaluation(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GeneratorEvaluation, GeneratorEvaluationOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateGeneratorEvaluationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateGeneratorEvaluation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<GeneratorEvaluation, GeneratorEvaluationOperationMetadata>> PollOnceCreateGeneratorEvaluationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GeneratorEvaluation, GeneratorEvaluationOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateGeneratorEvaluationOperationsClient, callSettings);

        /// <summary>
        /// Creates evaluation of a generator.
        /// </summary>
        /// <param name="parent">
        /// Required. The generator resource name. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/generators/&lt;Generator ID&gt;`
        /// </param>
        /// <param name="generatorEvaluation">
        /// Required. The generator evaluation to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GeneratorEvaluation, GeneratorEvaluationOperationMetadata> CreateGeneratorEvaluation(string parent, GeneratorEvaluation generatorEvaluation, gaxgrpc::CallSettings callSettings = null) =>
            CreateGeneratorEvaluation(new CreateGeneratorEvaluationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                GeneratorEvaluation = gax::GaxPreconditions.CheckNotNull(generatorEvaluation, nameof(generatorEvaluation)),
            }, callSettings);

        /// <summary>
        /// Creates evaluation of a generator.
        /// </summary>
        /// <param name="parent">
        /// Required. The generator resource name. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/generators/&lt;Generator ID&gt;`
        /// </param>
        /// <param name="generatorEvaluation">
        /// Required. The generator evaluation to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GeneratorEvaluation, GeneratorEvaluationOperationMetadata>> CreateGeneratorEvaluationAsync(string parent, GeneratorEvaluation generatorEvaluation, gaxgrpc::CallSettings callSettings = null) =>
            CreateGeneratorEvaluationAsync(new CreateGeneratorEvaluationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                GeneratorEvaluation = gax::GaxPreconditions.CheckNotNull(generatorEvaluation, nameof(generatorEvaluation)),
            }, callSettings);

        /// <summary>
        /// Creates evaluation of a generator.
        /// </summary>
        /// <param name="parent">
        /// Required. The generator resource name. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/generators/&lt;Generator ID&gt;`
        /// </param>
        /// <param name="generatorEvaluation">
        /// Required. The generator evaluation to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GeneratorEvaluation, GeneratorEvaluationOperationMetadata>> CreateGeneratorEvaluationAsync(string parent, GeneratorEvaluation generatorEvaluation, st::CancellationToken cancellationToken) =>
            CreateGeneratorEvaluationAsync(parent, generatorEvaluation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates evaluation of a generator.
        /// </summary>
        /// <param name="parent">
        /// Required. The generator resource name. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/generators/&lt;Generator ID&gt;`
        /// </param>
        /// <param name="generatorEvaluation">
        /// Required. The generator evaluation to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GeneratorEvaluation, GeneratorEvaluationOperationMetadata> CreateGeneratorEvaluation(GeneratorName parent, GeneratorEvaluation generatorEvaluation, gaxgrpc::CallSettings callSettings = null) =>
            CreateGeneratorEvaluation(new CreateGeneratorEvaluationRequest
            {
                ParentAsGeneratorName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                GeneratorEvaluation = gax::GaxPreconditions.CheckNotNull(generatorEvaluation, nameof(generatorEvaluation)),
            }, callSettings);

        /// <summary>
        /// Creates evaluation of a generator.
        /// </summary>
        /// <param name="parent">
        /// Required. The generator resource name. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/generators/&lt;Generator ID&gt;`
        /// </param>
        /// <param name="generatorEvaluation">
        /// Required. The generator evaluation to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GeneratorEvaluation, GeneratorEvaluationOperationMetadata>> CreateGeneratorEvaluationAsync(GeneratorName parent, GeneratorEvaluation generatorEvaluation, gaxgrpc::CallSettings callSettings = null) =>
            CreateGeneratorEvaluationAsync(new CreateGeneratorEvaluationRequest
            {
                ParentAsGeneratorName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                GeneratorEvaluation = gax::GaxPreconditions.CheckNotNull(generatorEvaluation, nameof(generatorEvaluation)),
            }, callSettings);

        /// <summary>
        /// Creates evaluation of a generator.
        /// </summary>
        /// <param name="parent">
        /// Required. The generator resource name. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/generators/&lt;Generator ID&gt;`
        /// </param>
        /// <param name="generatorEvaluation">
        /// Required. The generator evaluation to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GeneratorEvaluation, GeneratorEvaluationOperationMetadata>> CreateGeneratorEvaluationAsync(GeneratorName parent, GeneratorEvaluation generatorEvaluation, st::CancellationToken cancellationToken) =>
            CreateGeneratorEvaluationAsync(parent, generatorEvaluation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an evaluation of generator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GeneratorEvaluation GetGeneratorEvaluation(GetGeneratorEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an evaluation of generator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GeneratorEvaluation> GetGeneratorEvaluationAsync(GetGeneratorEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an evaluation of generator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GeneratorEvaluation> GetGeneratorEvaluationAsync(GetGeneratorEvaluationRequest request, st::CancellationToken cancellationToken) =>
            GetGeneratorEvaluationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an evaluation of generator.
        /// </summary>
        /// <param name="name">
        /// Required. The generator evaluation resource name. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/generators/&lt;Generator
        /// ID&gt;/evaluations/&lt;Evaluation ID&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GeneratorEvaluation GetGeneratorEvaluation(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGeneratorEvaluation(new GetGeneratorEvaluationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an evaluation of generator.
        /// </summary>
        /// <param name="name">
        /// Required. The generator evaluation resource name. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/generators/&lt;Generator
        /// ID&gt;/evaluations/&lt;Evaluation ID&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GeneratorEvaluation> GetGeneratorEvaluationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGeneratorEvaluationAsync(new GetGeneratorEvaluationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an evaluation of generator.
        /// </summary>
        /// <param name="name">
        /// Required. The generator evaluation resource name. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/generators/&lt;Generator
        /// ID&gt;/evaluations/&lt;Evaluation ID&gt;`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GeneratorEvaluation> GetGeneratorEvaluationAsync(string name, st::CancellationToken cancellationToken) =>
            GetGeneratorEvaluationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an evaluation of generator.
        /// </summary>
        /// <param name="name">
        /// Required. The generator evaluation resource name. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/generators/&lt;Generator
        /// ID&gt;/evaluations/&lt;Evaluation ID&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GeneratorEvaluation GetGeneratorEvaluation(GeneratorEvaluationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGeneratorEvaluation(new GetGeneratorEvaluationRequest
            {
                GeneratorEvaluationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an evaluation of generator.
        /// </summary>
        /// <param name="name">
        /// Required. The generator evaluation resource name. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/generators/&lt;Generator
        /// ID&gt;/evaluations/&lt;Evaluation ID&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GeneratorEvaluation> GetGeneratorEvaluationAsync(GeneratorEvaluationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGeneratorEvaluationAsync(new GetGeneratorEvaluationRequest
            {
                GeneratorEvaluationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an evaluation of generator.
        /// </summary>
        /// <param name="name">
        /// Required. The generator evaluation resource name. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/generators/&lt;Generator
        /// ID&gt;/evaluations/&lt;Evaluation ID&gt;`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GeneratorEvaluation> GetGeneratorEvaluationAsync(GeneratorEvaluationName name, st::CancellationToken cancellationToken) =>
            GetGeneratorEvaluationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists evaluations of generator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GeneratorEvaluation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGeneratorEvaluationsResponse, GeneratorEvaluation> ListGeneratorEvaluations(ListGeneratorEvaluationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists evaluations of generator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GeneratorEvaluation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGeneratorEvaluationsResponse, GeneratorEvaluation> ListGeneratorEvaluationsAsync(ListGeneratorEvaluationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists evaluations of generator.
        /// </summary>
        /// <param name="parent">
        /// Required. The generator resource name. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/generators/&lt;Generator ID&gt;`
        /// Wildcard value `-` is supported on generator_id to list evaluations across
        /// all generators under same project.
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
        /// <returns>A pageable sequence of <see cref="GeneratorEvaluation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGeneratorEvaluationsResponse, GeneratorEvaluation> ListGeneratorEvaluations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGeneratorEvaluationsRequest request = new ListGeneratorEvaluationsRequest
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
            return ListGeneratorEvaluations(request, callSettings);
        }

        /// <summary>
        /// Lists evaluations of generator.
        /// </summary>
        /// <param name="parent">
        /// Required. The generator resource name. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/generators/&lt;Generator ID&gt;`
        /// Wildcard value `-` is supported on generator_id to list evaluations across
        /// all generators under same project.
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
        /// <returns>A pageable asynchronous sequence of <see cref="GeneratorEvaluation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGeneratorEvaluationsResponse, GeneratorEvaluation> ListGeneratorEvaluationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGeneratorEvaluationsRequest request = new ListGeneratorEvaluationsRequest
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
            return ListGeneratorEvaluationsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists evaluations of generator.
        /// </summary>
        /// <param name="parent">
        /// Required. The generator resource name. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/generators/&lt;Generator ID&gt;`
        /// Wildcard value `-` is supported on generator_id to list evaluations across
        /// all generators under same project.
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
        /// <returns>A pageable sequence of <see cref="GeneratorEvaluation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGeneratorEvaluationsResponse, GeneratorEvaluation> ListGeneratorEvaluations(GeneratorName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGeneratorEvaluationsRequest request = new ListGeneratorEvaluationsRequest
            {
                ParentAsGeneratorName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListGeneratorEvaluations(request, callSettings);
        }

        /// <summary>
        /// Lists evaluations of generator.
        /// </summary>
        /// <param name="parent">
        /// Required. The generator resource name. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/generators/&lt;Generator ID&gt;`
        /// Wildcard value `-` is supported on generator_id to list evaluations across
        /// all generators under same project.
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
        /// <returns>A pageable asynchronous sequence of <see cref="GeneratorEvaluation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGeneratorEvaluationsResponse, GeneratorEvaluation> ListGeneratorEvaluationsAsync(GeneratorName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGeneratorEvaluationsRequest request = new ListGeneratorEvaluationsRequest
            {
                ParentAsGeneratorName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListGeneratorEvaluationsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes an evaluation of generator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteGeneratorEvaluation(DeleteGeneratorEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an evaluation of generator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGeneratorEvaluationAsync(DeleteGeneratorEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an evaluation of generator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGeneratorEvaluationAsync(DeleteGeneratorEvaluationRequest request, st::CancellationToken cancellationToken) =>
            DeleteGeneratorEvaluationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an evaluation of generator.
        /// </summary>
        /// <param name="name">
        /// Required. The generator evaluation resource name. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/generators/&lt;Generator ID&gt;/
        /// evaluations/&lt;Evaluation ID&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteGeneratorEvaluation(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGeneratorEvaluation(new DeleteGeneratorEvaluationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an evaluation of generator.
        /// </summary>
        /// <param name="name">
        /// Required. The generator evaluation resource name. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/generators/&lt;Generator ID&gt;/
        /// evaluations/&lt;Evaluation ID&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGeneratorEvaluationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGeneratorEvaluationAsync(new DeleteGeneratorEvaluationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an evaluation of generator.
        /// </summary>
        /// <param name="name">
        /// Required. The generator evaluation resource name. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/generators/&lt;Generator ID&gt;/
        /// evaluations/&lt;Evaluation ID&gt;`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGeneratorEvaluationAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteGeneratorEvaluationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an evaluation of generator.
        /// </summary>
        /// <param name="name">
        /// Required. The generator evaluation resource name. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/generators/&lt;Generator ID&gt;/
        /// evaluations/&lt;Evaluation ID&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteGeneratorEvaluation(GeneratorEvaluationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGeneratorEvaluation(new DeleteGeneratorEvaluationRequest
            {
                GeneratorEvaluationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an evaluation of generator.
        /// </summary>
        /// <param name="name">
        /// Required. The generator evaluation resource name. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/generators/&lt;Generator ID&gt;/
        /// evaluations/&lt;Evaluation ID&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGeneratorEvaluationAsync(GeneratorEvaluationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGeneratorEvaluationAsync(new DeleteGeneratorEvaluationRequest
            {
                GeneratorEvaluationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an evaluation of generator.
        /// </summary>
        /// <param name="name">
        /// Required. The generator evaluation resource name. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/generators/&lt;Generator ID&gt;/
        /// evaluations/&lt;Evaluation ID&gt;`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGeneratorEvaluationAsync(GeneratorEvaluationName name, st::CancellationToken cancellationToken) =>
            DeleteGeneratorEvaluationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>GeneratorEvaluations client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing generator evaluations.
    /// </remarks>
    public sealed partial class GeneratorEvaluationsClientImpl : GeneratorEvaluationsClient
    {
        private readonly gaxgrpc::ApiCall<CreateGeneratorEvaluationRequest, lro::Operation> _callCreateGeneratorEvaluation;

        private readonly gaxgrpc::ApiCall<GetGeneratorEvaluationRequest, GeneratorEvaluation> _callGetGeneratorEvaluation;

        private readonly gaxgrpc::ApiCall<ListGeneratorEvaluationsRequest, ListGeneratorEvaluationsResponse> _callListGeneratorEvaluations;

        private readonly gaxgrpc::ApiCall<DeleteGeneratorEvaluationRequest, wkt::Empty> _callDeleteGeneratorEvaluation;

        /// <summary>
        /// Constructs a client wrapper for the GeneratorEvaluations service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="GeneratorEvaluationsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public GeneratorEvaluationsClientImpl(GeneratorEvaluations.GeneratorEvaluationsClient grpcClient, GeneratorEvaluationsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            GeneratorEvaluationsSettings effectiveSettings = settings ?? GeneratorEvaluationsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateGeneratorEvaluationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateGeneratorEvaluationOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCreateGeneratorEvaluation = clientHelper.BuildApiCall<CreateGeneratorEvaluationRequest, lro::Operation>("CreateGeneratorEvaluation", grpcClient.CreateGeneratorEvaluationAsync, grpcClient.CreateGeneratorEvaluation, effectiveSettings.CreateGeneratorEvaluationSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateGeneratorEvaluation);
            Modify_CreateGeneratorEvaluationApiCall(ref _callCreateGeneratorEvaluation);
            _callGetGeneratorEvaluation = clientHelper.BuildApiCall<GetGeneratorEvaluationRequest, GeneratorEvaluation>("GetGeneratorEvaluation", grpcClient.GetGeneratorEvaluationAsync, grpcClient.GetGeneratorEvaluation, effectiveSettings.GetGeneratorEvaluationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetGeneratorEvaluation);
            Modify_GetGeneratorEvaluationApiCall(ref _callGetGeneratorEvaluation);
            _callListGeneratorEvaluations = clientHelper.BuildApiCall<ListGeneratorEvaluationsRequest, ListGeneratorEvaluationsResponse>("ListGeneratorEvaluations", grpcClient.ListGeneratorEvaluationsAsync, grpcClient.ListGeneratorEvaluations, effectiveSettings.ListGeneratorEvaluationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListGeneratorEvaluations);
            Modify_ListGeneratorEvaluationsApiCall(ref _callListGeneratorEvaluations);
            _callDeleteGeneratorEvaluation = clientHelper.BuildApiCall<DeleteGeneratorEvaluationRequest, wkt::Empty>("DeleteGeneratorEvaluation", grpcClient.DeleteGeneratorEvaluationAsync, grpcClient.DeleteGeneratorEvaluation, effectiveSettings.DeleteGeneratorEvaluationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteGeneratorEvaluation);
            Modify_DeleteGeneratorEvaluationApiCall(ref _callDeleteGeneratorEvaluation);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateGeneratorEvaluationApiCall(ref gaxgrpc::ApiCall<CreateGeneratorEvaluationRequest, lro::Operation> call);

        partial void Modify_GetGeneratorEvaluationApiCall(ref gaxgrpc::ApiCall<GetGeneratorEvaluationRequest, GeneratorEvaluation> call);

        partial void Modify_ListGeneratorEvaluationsApiCall(ref gaxgrpc::ApiCall<ListGeneratorEvaluationsRequest, ListGeneratorEvaluationsResponse> call);

        partial void Modify_DeleteGeneratorEvaluationApiCall(ref gaxgrpc::ApiCall<DeleteGeneratorEvaluationRequest, wkt::Empty> call);

        partial void OnConstruction(GeneratorEvaluations.GeneratorEvaluationsClient grpcClient, GeneratorEvaluationsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC GeneratorEvaluations client</summary>
        public override GeneratorEvaluations.GeneratorEvaluationsClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CreateGeneratorEvaluationRequest(ref CreateGeneratorEvaluationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetGeneratorEvaluationRequest(ref GetGeneratorEvaluationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListGeneratorEvaluationsRequest(ref ListGeneratorEvaluationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteGeneratorEvaluationRequest(ref DeleteGeneratorEvaluationRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateGeneratorEvaluation</c>.</summary>
        public override lro::OperationsClient CreateGeneratorEvaluationOperationsClient { get; }

        /// <summary>
        /// Creates evaluation of a generator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<GeneratorEvaluation, GeneratorEvaluationOperationMetadata> CreateGeneratorEvaluation(CreateGeneratorEvaluationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGeneratorEvaluationRequest(ref request, ref callSettings);
            return new lro::Operation<GeneratorEvaluation, GeneratorEvaluationOperationMetadata>(_callCreateGeneratorEvaluation.Sync(request, callSettings), CreateGeneratorEvaluationOperationsClient);
        }

        /// <summary>
        /// Creates evaluation of a generator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<GeneratorEvaluation, GeneratorEvaluationOperationMetadata>> CreateGeneratorEvaluationAsync(CreateGeneratorEvaluationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGeneratorEvaluationRequest(ref request, ref callSettings);
            return new lro::Operation<GeneratorEvaluation, GeneratorEvaluationOperationMetadata>(await _callCreateGeneratorEvaluation.Async(request, callSettings).ConfigureAwait(false), CreateGeneratorEvaluationOperationsClient);
        }

        /// <summary>
        /// Gets an evaluation of generator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GeneratorEvaluation GetGeneratorEvaluation(GetGeneratorEvaluationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGeneratorEvaluationRequest(ref request, ref callSettings);
            return _callGetGeneratorEvaluation.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an evaluation of generator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GeneratorEvaluation> GetGeneratorEvaluationAsync(GetGeneratorEvaluationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGeneratorEvaluationRequest(ref request, ref callSettings);
            return _callGetGeneratorEvaluation.Async(request, callSettings);
        }

        /// <summary>
        /// Lists evaluations of generator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GeneratorEvaluation"/> resources.</returns>
        public override gax::PagedEnumerable<ListGeneratorEvaluationsResponse, GeneratorEvaluation> ListGeneratorEvaluations(ListGeneratorEvaluationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGeneratorEvaluationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListGeneratorEvaluationsRequest, ListGeneratorEvaluationsResponse, GeneratorEvaluation>(_callListGeneratorEvaluations, request, callSettings);
        }

        /// <summary>
        /// Lists evaluations of generator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GeneratorEvaluation"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListGeneratorEvaluationsResponse, GeneratorEvaluation> ListGeneratorEvaluationsAsync(ListGeneratorEvaluationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGeneratorEvaluationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListGeneratorEvaluationsRequest, ListGeneratorEvaluationsResponse, GeneratorEvaluation>(_callListGeneratorEvaluations, request, callSettings);
        }

        /// <summary>
        /// Deletes an evaluation of generator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteGeneratorEvaluation(DeleteGeneratorEvaluationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGeneratorEvaluationRequest(ref request, ref callSettings);
            _callDeleteGeneratorEvaluation.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an evaluation of generator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteGeneratorEvaluationAsync(DeleteGeneratorEvaluationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGeneratorEvaluationRequest(ref request, ref callSettings);
            return _callDeleteGeneratorEvaluation.Async(request, callSettings);
        }
    }

    public partial class ListGeneratorEvaluationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListGeneratorEvaluationsResponse : gaxgrpc::IPageResponse<GeneratorEvaluation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<GeneratorEvaluation> GetEnumerator() => GeneratorEvaluations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class GeneratorEvaluations
    {
        public partial class GeneratorEvaluationsClient
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

    public static partial class GeneratorEvaluations
    {
        public partial class GeneratorEvaluationsClient
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
