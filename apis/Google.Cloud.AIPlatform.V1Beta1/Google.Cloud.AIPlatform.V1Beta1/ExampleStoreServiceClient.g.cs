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

namespace Google.Cloud.AIPlatform.V1Beta1
{
    /// <summary>Settings for <see cref="ExampleStoreServiceClient"/> instances.</summary>
    public sealed partial class ExampleStoreServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ExampleStoreServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ExampleStoreServiceSettings"/>.</returns>
        public static ExampleStoreServiceSettings GetDefault() => new ExampleStoreServiceSettings();

        /// <summary>Constructs a new <see cref="ExampleStoreServiceSettings"/> object with default settings.</summary>
        public ExampleStoreServiceSettings()
        {
        }

        private ExampleStoreServiceSettings(ExampleStoreServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateExampleStoreSettings = existing.CreateExampleStoreSettings;
            CreateExampleStoreOperationsSettings = existing.CreateExampleStoreOperationsSettings.Clone();
            GetExampleStoreSettings = existing.GetExampleStoreSettings;
            UpdateExampleStoreSettings = existing.UpdateExampleStoreSettings;
            UpdateExampleStoreOperationsSettings = existing.UpdateExampleStoreOperationsSettings.Clone();
            DeleteExampleStoreSettings = existing.DeleteExampleStoreSettings;
            DeleteExampleStoreOperationsSettings = existing.DeleteExampleStoreOperationsSettings.Clone();
            ListExampleStoresSettings = existing.ListExampleStoresSettings;
            UpsertExamplesSettings = existing.UpsertExamplesSettings;
            RemoveExamplesSettings = existing.RemoveExamplesSettings;
            SearchExamplesSettings = existing.SearchExamplesSettings;
            FetchExamplesSettings = existing.FetchExamplesSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(ExampleStoreServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ExampleStoreServiceClient.CreateExampleStore</c> and <c>ExampleStoreServiceClient.CreateExampleStoreAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateExampleStoreSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ExampleStoreServiceClient.CreateExampleStore</c> and
        /// <c>ExampleStoreServiceClient.CreateExampleStoreAsync</c>.
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
        public lro::OperationsSettings CreateExampleStoreOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ExampleStoreServiceClient.GetExampleStore</c> and <c>ExampleStoreServiceClient.GetExampleStoreAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetExampleStoreSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ExampleStoreServiceClient.UpdateExampleStore</c> and <c>ExampleStoreServiceClient.UpdateExampleStoreAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateExampleStoreSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ExampleStoreServiceClient.UpdateExampleStore</c> and
        /// <c>ExampleStoreServiceClient.UpdateExampleStoreAsync</c>.
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
        public lro::OperationsSettings UpdateExampleStoreOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ExampleStoreServiceClient.DeleteExampleStore</c> and <c>ExampleStoreServiceClient.DeleteExampleStoreAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteExampleStoreSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ExampleStoreServiceClient.DeleteExampleStore</c> and
        /// <c>ExampleStoreServiceClient.DeleteExampleStoreAsync</c>.
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
        public lro::OperationsSettings DeleteExampleStoreOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ExampleStoreServiceClient.ListExampleStores</c> and <c>ExampleStoreServiceClient.ListExampleStoresAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListExampleStoresSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ExampleStoreServiceClient.UpsertExamples</c> and <c>ExampleStoreServiceClient.UpsertExamplesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpsertExamplesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ExampleStoreServiceClient.RemoveExamples</c> and <c>ExampleStoreServiceClient.RemoveExamplesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RemoveExamplesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ExampleStoreServiceClient.SearchExamples</c> and <c>ExampleStoreServiceClient.SearchExamplesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchExamplesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ExampleStoreServiceClient.FetchExamples</c> and <c>ExampleStoreServiceClient.FetchExamplesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FetchExamplesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ExampleStoreServiceSettings"/> object.</returns>
        public ExampleStoreServiceSettings Clone() => new ExampleStoreServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ExampleStoreServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class ExampleStoreServiceClientBuilder : gaxgrpc::ClientBuilderBase<ExampleStoreServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ExampleStoreServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ExampleStoreServiceClientBuilder() : base(ExampleStoreServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ExampleStoreServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ExampleStoreServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ExampleStoreServiceClient Build()
        {
            ExampleStoreServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ExampleStoreServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ExampleStoreServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ExampleStoreServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ExampleStoreServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ExampleStoreServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ExampleStoreServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ExampleStoreServiceClient.ChannelPool;
    }

    /// <summary>ExampleStoreService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service for managing and retrieving few-shot examples.
    /// </remarks>
    public abstract partial class ExampleStoreServiceClient
    {
        /// <summary>
        /// The default endpoint for the ExampleStoreService service, which is a host of "aiplatform.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "aiplatform.googleapis.com:443";

        /// <summary>The default ExampleStoreService scopes.</summary>
        /// <remarks>
        /// The default ExampleStoreService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ExampleStoreService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ExampleStoreServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="ExampleStoreServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ExampleStoreServiceClient"/>.</returns>
        public static stt::Task<ExampleStoreServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ExampleStoreServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ExampleStoreServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="ExampleStoreServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ExampleStoreServiceClient"/>.</returns>
        public static ExampleStoreServiceClient Create() => new ExampleStoreServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ExampleStoreServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ExampleStoreServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ExampleStoreServiceClient"/>.</returns>
        internal static ExampleStoreServiceClient Create(grpccore::CallInvoker callInvoker, ExampleStoreServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ExampleStoreService.ExampleStoreServiceClient grpcClient = new ExampleStoreService.ExampleStoreServiceClient(callInvoker);
            return new ExampleStoreServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ExampleStoreService client</summary>
        public virtual ExampleStoreService.ExampleStoreServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Create an ExampleStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExampleStore, CreateExampleStoreOperationMetadata> CreateExampleStore(CreateExampleStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create an ExampleStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExampleStore, CreateExampleStoreOperationMetadata>> CreateExampleStoreAsync(CreateExampleStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create an ExampleStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExampleStore, CreateExampleStoreOperationMetadata>> CreateExampleStoreAsync(CreateExampleStoreRequest request, st::CancellationToken cancellationToken) =>
            CreateExampleStoreAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateExampleStore</c>.</summary>
        public virtual lro::OperationsClient CreateExampleStoreOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateExampleStore</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ExampleStore, CreateExampleStoreOperationMetadata> PollOnceCreateExampleStore(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExampleStore, CreateExampleStoreOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateExampleStoreOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateExampleStore</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ExampleStore, CreateExampleStoreOperationMetadata>> PollOnceCreateExampleStoreAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExampleStore, CreateExampleStoreOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateExampleStoreOperationsClient, callSettings);

        /// <summary>
        /// Create an ExampleStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the ExampleStore in.
        /// Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="exampleStore">
        /// Required. The Example Store to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExampleStore, CreateExampleStoreOperationMetadata> CreateExampleStore(string parent, ExampleStore exampleStore, gaxgrpc::CallSettings callSettings = null) =>
            CreateExampleStore(new CreateExampleStoreRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ExampleStore = gax::GaxPreconditions.CheckNotNull(exampleStore, nameof(exampleStore)),
            }, callSettings);

        /// <summary>
        /// Create an ExampleStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the ExampleStore in.
        /// Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="exampleStore">
        /// Required. The Example Store to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExampleStore, CreateExampleStoreOperationMetadata>> CreateExampleStoreAsync(string parent, ExampleStore exampleStore, gaxgrpc::CallSettings callSettings = null) =>
            CreateExampleStoreAsync(new CreateExampleStoreRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ExampleStore = gax::GaxPreconditions.CheckNotNull(exampleStore, nameof(exampleStore)),
            }, callSettings);

        /// <summary>
        /// Create an ExampleStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the ExampleStore in.
        /// Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="exampleStore">
        /// Required. The Example Store to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExampleStore, CreateExampleStoreOperationMetadata>> CreateExampleStoreAsync(string parent, ExampleStore exampleStore, st::CancellationToken cancellationToken) =>
            CreateExampleStoreAsync(parent, exampleStore, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create an ExampleStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the ExampleStore in.
        /// Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="exampleStore">
        /// Required. The Example Store to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExampleStore, CreateExampleStoreOperationMetadata> CreateExampleStore(gagr::LocationName parent, ExampleStore exampleStore, gaxgrpc::CallSettings callSettings = null) =>
            CreateExampleStore(new CreateExampleStoreRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ExampleStore = gax::GaxPreconditions.CheckNotNull(exampleStore, nameof(exampleStore)),
            }, callSettings);

        /// <summary>
        /// Create an ExampleStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the ExampleStore in.
        /// Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="exampleStore">
        /// Required. The Example Store to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExampleStore, CreateExampleStoreOperationMetadata>> CreateExampleStoreAsync(gagr::LocationName parent, ExampleStore exampleStore, gaxgrpc::CallSettings callSettings = null) =>
            CreateExampleStoreAsync(new CreateExampleStoreRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ExampleStore = gax::GaxPreconditions.CheckNotNull(exampleStore, nameof(exampleStore)),
            }, callSettings);

        /// <summary>
        /// Create an ExampleStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the ExampleStore in.
        /// Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="exampleStore">
        /// Required. The Example Store to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExampleStore, CreateExampleStoreOperationMetadata>> CreateExampleStoreAsync(gagr::LocationName parent, ExampleStore exampleStore, st::CancellationToken cancellationToken) =>
            CreateExampleStoreAsync(parent, exampleStore, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get an ExampleStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExampleStore GetExampleStore(GetExampleStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get an ExampleStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExampleStore> GetExampleStoreAsync(GetExampleStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get an ExampleStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExampleStore> GetExampleStoreAsync(GetExampleStoreRequest request, st::CancellationToken cancellationToken) =>
            GetExampleStoreAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get an ExampleStore.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ExampleStore.
        /// Format:
        /// `projects/{project}/locations/{location}/exampleStores/{example_store}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExampleStore GetExampleStore(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetExampleStore(new GetExampleStoreRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get an ExampleStore.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ExampleStore.
        /// Format:
        /// `projects/{project}/locations/{location}/exampleStores/{example_store}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExampleStore> GetExampleStoreAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetExampleStoreAsync(new GetExampleStoreRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get an ExampleStore.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ExampleStore.
        /// Format:
        /// `projects/{project}/locations/{location}/exampleStores/{example_store}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExampleStore> GetExampleStoreAsync(string name, st::CancellationToken cancellationToken) =>
            GetExampleStoreAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get an ExampleStore.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ExampleStore.
        /// Format:
        /// `projects/{project}/locations/{location}/exampleStores/{example_store}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExampleStore GetExampleStore(ExampleStoreName name, gaxgrpc::CallSettings callSettings = null) =>
            GetExampleStore(new GetExampleStoreRequest
            {
                ExampleStoreName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get an ExampleStore.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ExampleStore.
        /// Format:
        /// `projects/{project}/locations/{location}/exampleStores/{example_store}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExampleStore> GetExampleStoreAsync(ExampleStoreName name, gaxgrpc::CallSettings callSettings = null) =>
            GetExampleStoreAsync(new GetExampleStoreRequest
            {
                ExampleStoreName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get an ExampleStore.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ExampleStore.
        /// Format:
        /// `projects/{project}/locations/{location}/exampleStores/{example_store}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExampleStore> GetExampleStoreAsync(ExampleStoreName name, st::CancellationToken cancellationToken) =>
            GetExampleStoreAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update an ExampleStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExampleStore, UpdateExampleStoreOperationMetadata> UpdateExampleStore(UpdateExampleStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update an ExampleStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExampleStore, UpdateExampleStoreOperationMetadata>> UpdateExampleStoreAsync(UpdateExampleStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update an ExampleStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExampleStore, UpdateExampleStoreOperationMetadata>> UpdateExampleStoreAsync(UpdateExampleStoreRequest request, st::CancellationToken cancellationToken) =>
            UpdateExampleStoreAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateExampleStore</c>.</summary>
        public virtual lro::OperationsClient UpdateExampleStoreOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateExampleStore</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ExampleStore, UpdateExampleStoreOperationMetadata> PollOnceUpdateExampleStore(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExampleStore, UpdateExampleStoreOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateExampleStoreOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateExampleStore</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ExampleStore, UpdateExampleStoreOperationMetadata>> PollOnceUpdateExampleStoreAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExampleStore, UpdateExampleStoreOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateExampleStoreOperationsClient, callSettings);

        /// <summary>
        /// Update an ExampleStore.
        /// </summary>
        /// <param name="exampleStore">
        /// Required. The Example Store which replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Mask specifying which fields to update.
        /// Supported fields:
        /// 
        /// * `display_name`
        /// * `description`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExampleStore, UpdateExampleStoreOperationMetadata> UpdateExampleStore(ExampleStore exampleStore, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateExampleStore(new UpdateExampleStoreRequest
            {
                ExampleStore = gax::GaxPreconditions.CheckNotNull(exampleStore, nameof(exampleStore)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update an ExampleStore.
        /// </summary>
        /// <param name="exampleStore">
        /// Required. The Example Store which replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Mask specifying which fields to update.
        /// Supported fields:
        /// 
        /// * `display_name`
        /// * `description`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExampleStore, UpdateExampleStoreOperationMetadata>> UpdateExampleStoreAsync(ExampleStore exampleStore, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateExampleStoreAsync(new UpdateExampleStoreRequest
            {
                ExampleStore = gax::GaxPreconditions.CheckNotNull(exampleStore, nameof(exampleStore)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update an ExampleStore.
        /// </summary>
        /// <param name="exampleStore">
        /// Required. The Example Store which replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Mask specifying which fields to update.
        /// Supported fields:
        /// 
        /// * `display_name`
        /// * `description`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExampleStore, UpdateExampleStoreOperationMetadata>> UpdateExampleStoreAsync(ExampleStore exampleStore, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateExampleStoreAsync(exampleStore, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete an ExampleStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteExampleStoreOperationMetadata> DeleteExampleStore(DeleteExampleStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete an ExampleStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteExampleStoreOperationMetadata>> DeleteExampleStoreAsync(DeleteExampleStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete an ExampleStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteExampleStoreOperationMetadata>> DeleteExampleStoreAsync(DeleteExampleStoreRequest request, st::CancellationToken cancellationToken) =>
            DeleteExampleStoreAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteExampleStore</c>.</summary>
        public virtual lro::OperationsClient DeleteExampleStoreOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteExampleStore</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteExampleStoreOperationMetadata> PollOnceDeleteExampleStore(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteExampleStoreOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteExampleStoreOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteExampleStore</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteExampleStoreOperationMetadata>> PollOnceDeleteExampleStoreAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteExampleStoreOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteExampleStoreOperationsClient, callSettings);

        /// <summary>
        /// Delete an ExampleStore.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ExampleStore to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/exampleStores/{example_store}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteExampleStoreOperationMetadata> DeleteExampleStore(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExampleStore(new DeleteExampleStoreRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete an ExampleStore.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ExampleStore to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/exampleStores/{example_store}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteExampleStoreOperationMetadata>> DeleteExampleStoreAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExampleStoreAsync(new DeleteExampleStoreRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete an ExampleStore.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ExampleStore to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/exampleStores/{example_store}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteExampleStoreOperationMetadata>> DeleteExampleStoreAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteExampleStoreAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete an ExampleStore.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ExampleStore to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/exampleStores/{example_store}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteExampleStoreOperationMetadata> DeleteExampleStore(ExampleStoreName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExampleStore(new DeleteExampleStoreRequest
            {
                ExampleStoreName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete an ExampleStore.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ExampleStore to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/exampleStores/{example_store}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteExampleStoreOperationMetadata>> DeleteExampleStoreAsync(ExampleStoreName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExampleStoreAsync(new DeleteExampleStoreRequest
            {
                ExampleStoreName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete an ExampleStore.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ExampleStore to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/exampleStores/{example_store}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteExampleStoreOperationMetadata>> DeleteExampleStoreAsync(ExampleStoreName name, st::CancellationToken cancellationToken) =>
            DeleteExampleStoreAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List ExampleStores in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ExampleStore"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExampleStoresResponse, ExampleStore> ListExampleStores(ListExampleStoresRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List ExampleStores in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ExampleStore"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExampleStoresResponse, ExampleStore> ListExampleStoresAsync(ListExampleStoresRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List ExampleStores in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the ExampleStores from.
        /// Format:
        /// `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="ExampleStore"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExampleStoresResponse, ExampleStore> ListExampleStores(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExampleStoresRequest request = new ListExampleStoresRequest
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
            return ListExampleStores(request, callSettings);
        }

        /// <summary>
        /// List ExampleStores in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the ExampleStores from.
        /// Format:
        /// `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ExampleStore"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExampleStoresResponse, ExampleStore> ListExampleStoresAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExampleStoresRequest request = new ListExampleStoresRequest
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
            return ListExampleStoresAsync(request, callSettings);
        }

        /// <summary>
        /// List ExampleStores in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the ExampleStores from.
        /// Format:
        /// `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="ExampleStore"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExampleStoresResponse, ExampleStore> ListExampleStores(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExampleStoresRequest request = new ListExampleStoresRequest
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
            return ListExampleStores(request, callSettings);
        }

        /// <summary>
        /// List ExampleStores in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the ExampleStores from.
        /// Format:
        /// `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ExampleStore"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExampleStoresResponse, ExampleStore> ListExampleStoresAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExampleStoresRequest request = new ListExampleStoresRequest
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
            return ListExampleStoresAsync(request, callSettings);
        }

        /// <summary>
        /// Create or update Examples in the Example Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UpsertExamplesResponse UpsertExamples(UpsertExamplesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create or update Examples in the Example Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UpsertExamplesResponse> UpsertExamplesAsync(UpsertExamplesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create or update Examples in the Example Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UpsertExamplesResponse> UpsertExamplesAsync(UpsertExamplesRequest request, st::CancellationToken cancellationToken) =>
            UpsertExamplesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Remove Examples from the Example Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RemoveExamplesResponse RemoveExamples(RemoveExamplesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Remove Examples from the Example Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveExamplesResponse> RemoveExamplesAsync(RemoveExamplesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Remove Examples from the Example Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveExamplesResponse> RemoveExamplesAsync(RemoveExamplesRequest request, st::CancellationToken cancellationToken) =>
            RemoveExamplesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Search for similar Examples for given selection criteria.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SearchExamplesResponse SearchExamples(SearchExamplesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Search for similar Examples for given selection criteria.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchExamplesResponse> SearchExamplesAsync(SearchExamplesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Search for similar Examples for given selection criteria.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchExamplesResponse> SearchExamplesAsync(SearchExamplesRequest request, st::CancellationToken cancellationToken) =>
            SearchExamplesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get Examples from the Example Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Example"/> resources.</returns>
        public virtual gax::PagedEnumerable<FetchExamplesResponse, Example> FetchExamples(FetchExamplesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get Examples from the Example Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Example"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<FetchExamplesResponse, Example> FetchExamplesAsync(FetchExamplesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();
    }

    /// <summary>ExampleStoreService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service for managing and retrieving few-shot examples.
    /// </remarks>
    public sealed partial class ExampleStoreServiceClientImpl : ExampleStoreServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateExampleStoreRequest, lro::Operation> _callCreateExampleStore;

        private readonly gaxgrpc::ApiCall<GetExampleStoreRequest, ExampleStore> _callGetExampleStore;

        private readonly gaxgrpc::ApiCall<UpdateExampleStoreRequest, lro::Operation> _callUpdateExampleStore;

        private readonly gaxgrpc::ApiCall<DeleteExampleStoreRequest, lro::Operation> _callDeleteExampleStore;

        private readonly gaxgrpc::ApiCall<ListExampleStoresRequest, ListExampleStoresResponse> _callListExampleStores;

        private readonly gaxgrpc::ApiCall<UpsertExamplesRequest, UpsertExamplesResponse> _callUpsertExamples;

        private readonly gaxgrpc::ApiCall<RemoveExamplesRequest, RemoveExamplesResponse> _callRemoveExamples;

        private readonly gaxgrpc::ApiCall<SearchExamplesRequest, SearchExamplesResponse> _callSearchExamples;

        private readonly gaxgrpc::ApiCall<FetchExamplesRequest, FetchExamplesResponse> _callFetchExamples;

        /// <summary>
        /// Constructs a client wrapper for the ExampleStoreService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ExampleStoreServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ExampleStoreServiceClientImpl(ExampleStoreService.ExampleStoreServiceClient grpcClient, ExampleStoreServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ExampleStoreServiceSettings effectiveSettings = settings ?? ExampleStoreServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateExampleStoreOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateExampleStoreOperationsSettings, logger);
            UpdateExampleStoreOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateExampleStoreOperationsSettings, logger);
            DeleteExampleStoreOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteExampleStoreOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreateExampleStore = clientHelper.BuildApiCall<CreateExampleStoreRequest, lro::Operation>("CreateExampleStore", grpcClient.CreateExampleStoreAsync, grpcClient.CreateExampleStore, effectiveSettings.CreateExampleStoreSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateExampleStore);
            Modify_CreateExampleStoreApiCall(ref _callCreateExampleStore);
            _callGetExampleStore = clientHelper.BuildApiCall<GetExampleStoreRequest, ExampleStore>("GetExampleStore", grpcClient.GetExampleStoreAsync, grpcClient.GetExampleStore, effectiveSettings.GetExampleStoreSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetExampleStore);
            Modify_GetExampleStoreApiCall(ref _callGetExampleStore);
            _callUpdateExampleStore = clientHelper.BuildApiCall<UpdateExampleStoreRequest, lro::Operation>("UpdateExampleStore", grpcClient.UpdateExampleStoreAsync, grpcClient.UpdateExampleStore, effectiveSettings.UpdateExampleStoreSettings).WithGoogleRequestParam("example_store.name", request => request.ExampleStore?.Name);
            Modify_ApiCall(ref _callUpdateExampleStore);
            Modify_UpdateExampleStoreApiCall(ref _callUpdateExampleStore);
            _callDeleteExampleStore = clientHelper.BuildApiCall<DeleteExampleStoreRequest, lro::Operation>("DeleteExampleStore", grpcClient.DeleteExampleStoreAsync, grpcClient.DeleteExampleStore, effectiveSettings.DeleteExampleStoreSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteExampleStore);
            Modify_DeleteExampleStoreApiCall(ref _callDeleteExampleStore);
            _callListExampleStores = clientHelper.BuildApiCall<ListExampleStoresRequest, ListExampleStoresResponse>("ListExampleStores", grpcClient.ListExampleStoresAsync, grpcClient.ListExampleStores, effectiveSettings.ListExampleStoresSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListExampleStores);
            Modify_ListExampleStoresApiCall(ref _callListExampleStores);
            _callUpsertExamples = clientHelper.BuildApiCall<UpsertExamplesRequest, UpsertExamplesResponse>("UpsertExamples", grpcClient.UpsertExamplesAsync, grpcClient.UpsertExamples, effectiveSettings.UpsertExamplesSettings).WithGoogleRequestParam("example_store", request => request.ExampleStore);
            Modify_ApiCall(ref _callUpsertExamples);
            Modify_UpsertExamplesApiCall(ref _callUpsertExamples);
            _callRemoveExamples = clientHelper.BuildApiCall<RemoveExamplesRequest, RemoveExamplesResponse>("RemoveExamples", grpcClient.RemoveExamplesAsync, grpcClient.RemoveExamples, effectiveSettings.RemoveExamplesSettings).WithGoogleRequestParam("example_store", request => request.ExampleStore);
            Modify_ApiCall(ref _callRemoveExamples);
            Modify_RemoveExamplesApiCall(ref _callRemoveExamples);
            _callSearchExamples = clientHelper.BuildApiCall<SearchExamplesRequest, SearchExamplesResponse>("SearchExamples", grpcClient.SearchExamplesAsync, grpcClient.SearchExamples, effectiveSettings.SearchExamplesSettings).WithGoogleRequestParam("example_store", request => request.ExampleStore);
            Modify_ApiCall(ref _callSearchExamples);
            Modify_SearchExamplesApiCall(ref _callSearchExamples);
            _callFetchExamples = clientHelper.BuildApiCall<FetchExamplesRequest, FetchExamplesResponse>("FetchExamples", grpcClient.FetchExamplesAsync, grpcClient.FetchExamples, effectiveSettings.FetchExamplesSettings).WithGoogleRequestParam("example_store", request => request.ExampleStore);
            Modify_ApiCall(ref _callFetchExamples);
            Modify_FetchExamplesApiCall(ref _callFetchExamples);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateExampleStoreApiCall(ref gaxgrpc::ApiCall<CreateExampleStoreRequest, lro::Operation> call);

        partial void Modify_GetExampleStoreApiCall(ref gaxgrpc::ApiCall<GetExampleStoreRequest, ExampleStore> call);

        partial void Modify_UpdateExampleStoreApiCall(ref gaxgrpc::ApiCall<UpdateExampleStoreRequest, lro::Operation> call);

        partial void Modify_DeleteExampleStoreApiCall(ref gaxgrpc::ApiCall<DeleteExampleStoreRequest, lro::Operation> call);

        partial void Modify_ListExampleStoresApiCall(ref gaxgrpc::ApiCall<ListExampleStoresRequest, ListExampleStoresResponse> call);

        partial void Modify_UpsertExamplesApiCall(ref gaxgrpc::ApiCall<UpsertExamplesRequest, UpsertExamplesResponse> call);

        partial void Modify_RemoveExamplesApiCall(ref gaxgrpc::ApiCall<RemoveExamplesRequest, RemoveExamplesResponse> call);

        partial void Modify_SearchExamplesApiCall(ref gaxgrpc::ApiCall<SearchExamplesRequest, SearchExamplesResponse> call);

        partial void Modify_FetchExamplesApiCall(ref gaxgrpc::ApiCall<FetchExamplesRequest, FetchExamplesResponse> call);

        partial void OnConstruction(ExampleStoreService.ExampleStoreServiceClient grpcClient, ExampleStoreServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ExampleStoreService client</summary>
        public override ExampleStoreService.ExampleStoreServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateExampleStoreRequest(ref CreateExampleStoreRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetExampleStoreRequest(ref GetExampleStoreRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateExampleStoreRequest(ref UpdateExampleStoreRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteExampleStoreRequest(ref DeleteExampleStoreRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListExampleStoresRequest(ref ListExampleStoresRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpsertExamplesRequest(ref UpsertExamplesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RemoveExamplesRequest(ref RemoveExamplesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchExamplesRequest(ref SearchExamplesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FetchExamplesRequest(ref FetchExamplesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateExampleStore</c>.</summary>
        public override lro::OperationsClient CreateExampleStoreOperationsClient { get; }

        /// <summary>
        /// Create an ExampleStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ExampleStore, CreateExampleStoreOperationMetadata> CreateExampleStore(CreateExampleStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateExampleStoreRequest(ref request, ref callSettings);
            return new lro::Operation<ExampleStore, CreateExampleStoreOperationMetadata>(_callCreateExampleStore.Sync(request, callSettings), CreateExampleStoreOperationsClient);
        }

        /// <summary>
        /// Create an ExampleStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ExampleStore, CreateExampleStoreOperationMetadata>> CreateExampleStoreAsync(CreateExampleStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateExampleStoreRequest(ref request, ref callSettings);
            return new lro::Operation<ExampleStore, CreateExampleStoreOperationMetadata>(await _callCreateExampleStore.Async(request, callSettings).ConfigureAwait(false), CreateExampleStoreOperationsClient);
        }

        /// <summary>
        /// Get an ExampleStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ExampleStore GetExampleStore(GetExampleStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetExampleStoreRequest(ref request, ref callSettings);
            return _callGetExampleStore.Sync(request, callSettings);
        }

        /// <summary>
        /// Get an ExampleStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ExampleStore> GetExampleStoreAsync(GetExampleStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetExampleStoreRequest(ref request, ref callSettings);
            return _callGetExampleStore.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateExampleStore</c>.</summary>
        public override lro::OperationsClient UpdateExampleStoreOperationsClient { get; }

        /// <summary>
        /// Update an ExampleStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ExampleStore, UpdateExampleStoreOperationMetadata> UpdateExampleStore(UpdateExampleStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateExampleStoreRequest(ref request, ref callSettings);
            return new lro::Operation<ExampleStore, UpdateExampleStoreOperationMetadata>(_callUpdateExampleStore.Sync(request, callSettings), UpdateExampleStoreOperationsClient);
        }

        /// <summary>
        /// Update an ExampleStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ExampleStore, UpdateExampleStoreOperationMetadata>> UpdateExampleStoreAsync(UpdateExampleStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateExampleStoreRequest(ref request, ref callSettings);
            return new lro::Operation<ExampleStore, UpdateExampleStoreOperationMetadata>(await _callUpdateExampleStore.Async(request, callSettings).ConfigureAwait(false), UpdateExampleStoreOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteExampleStore</c>.</summary>
        public override lro::OperationsClient DeleteExampleStoreOperationsClient { get; }

        /// <summary>
        /// Delete an ExampleStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteExampleStoreOperationMetadata> DeleteExampleStore(DeleteExampleStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteExampleStoreRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteExampleStoreOperationMetadata>(_callDeleteExampleStore.Sync(request, callSettings), DeleteExampleStoreOperationsClient);
        }

        /// <summary>
        /// Delete an ExampleStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteExampleStoreOperationMetadata>> DeleteExampleStoreAsync(DeleteExampleStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteExampleStoreRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteExampleStoreOperationMetadata>(await _callDeleteExampleStore.Async(request, callSettings).ConfigureAwait(false), DeleteExampleStoreOperationsClient);
        }

        /// <summary>
        /// List ExampleStores in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ExampleStore"/> resources.</returns>
        public override gax::PagedEnumerable<ListExampleStoresResponse, ExampleStore> ListExampleStores(ListExampleStoresRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListExampleStoresRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListExampleStoresRequest, ListExampleStoresResponse, ExampleStore>(_callListExampleStores, request, callSettings);
        }

        /// <summary>
        /// List ExampleStores in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ExampleStore"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListExampleStoresResponse, ExampleStore> ListExampleStoresAsync(ListExampleStoresRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListExampleStoresRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListExampleStoresRequest, ListExampleStoresResponse, ExampleStore>(_callListExampleStores, request, callSettings);
        }

        /// <summary>
        /// Create or update Examples in the Example Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UpsertExamplesResponse UpsertExamples(UpsertExamplesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpsertExamplesRequest(ref request, ref callSettings);
            return _callUpsertExamples.Sync(request, callSettings);
        }

        /// <summary>
        /// Create or update Examples in the Example Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UpsertExamplesResponse> UpsertExamplesAsync(UpsertExamplesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpsertExamplesRequest(ref request, ref callSettings);
            return _callUpsertExamples.Async(request, callSettings);
        }

        /// <summary>
        /// Remove Examples from the Example Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RemoveExamplesResponse RemoveExamples(RemoveExamplesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveExamplesRequest(ref request, ref callSettings);
            return _callRemoveExamples.Sync(request, callSettings);
        }

        /// <summary>
        /// Remove Examples from the Example Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RemoveExamplesResponse> RemoveExamplesAsync(RemoveExamplesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveExamplesRequest(ref request, ref callSettings);
            return _callRemoveExamples.Async(request, callSettings);
        }

        /// <summary>
        /// Search for similar Examples for given selection criteria.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SearchExamplesResponse SearchExamples(SearchExamplesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchExamplesRequest(ref request, ref callSettings);
            return _callSearchExamples.Sync(request, callSettings);
        }

        /// <summary>
        /// Search for similar Examples for given selection criteria.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SearchExamplesResponse> SearchExamplesAsync(SearchExamplesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchExamplesRequest(ref request, ref callSettings);
            return _callSearchExamples.Async(request, callSettings);
        }

        /// <summary>
        /// Get Examples from the Example Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Example"/> resources.</returns>
        public override gax::PagedEnumerable<FetchExamplesResponse, Example> FetchExamples(FetchExamplesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchExamplesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<FetchExamplesRequest, FetchExamplesResponse, Example>(_callFetchExamples, request, callSettings);
        }

        /// <summary>
        /// Get Examples from the Example Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Example"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<FetchExamplesResponse, Example> FetchExamplesAsync(FetchExamplesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchExamplesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<FetchExamplesRequest, FetchExamplesResponse, Example>(_callFetchExamples, request, callSettings);
        }
    }

    public partial class ListExampleStoresRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class FetchExamplesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListExampleStoresResponse : gaxgrpc::IPageResponse<ExampleStore>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ExampleStore> GetEnumerator() => ExampleStores.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class FetchExamplesResponse : gaxgrpc::IPageResponse<Example>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Example> GetEnumerator() => Examples.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ExampleStoreService
    {
        public partial class ExampleStoreServiceClient
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

    public static partial class ExampleStoreService
    {
        public partial class ExampleStoreServiceClient
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
