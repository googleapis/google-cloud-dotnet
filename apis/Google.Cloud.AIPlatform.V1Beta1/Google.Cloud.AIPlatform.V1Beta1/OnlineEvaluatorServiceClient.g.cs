// Copyright 2026 Google LLC
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
    /// <summary>Settings for <see cref="OnlineEvaluatorServiceClient"/> instances.</summary>
    public sealed partial class OnlineEvaluatorServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="OnlineEvaluatorServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="OnlineEvaluatorServiceSettings"/>.</returns>
        public static OnlineEvaluatorServiceSettings GetDefault() => new OnlineEvaluatorServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="OnlineEvaluatorServiceSettings"/> object with default settings.
        /// </summary>
        public OnlineEvaluatorServiceSettings()
        {
        }

        private OnlineEvaluatorServiceSettings(OnlineEvaluatorServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateOnlineEvaluatorSettings = existing.CreateOnlineEvaluatorSettings;
            CreateOnlineEvaluatorOperationsSettings = existing.CreateOnlineEvaluatorOperationsSettings.Clone();
            GetOnlineEvaluatorSettings = existing.GetOnlineEvaluatorSettings;
            UpdateOnlineEvaluatorSettings = existing.UpdateOnlineEvaluatorSettings;
            UpdateOnlineEvaluatorOperationsSettings = existing.UpdateOnlineEvaluatorOperationsSettings.Clone();
            DeleteOnlineEvaluatorSettings = existing.DeleteOnlineEvaluatorSettings;
            DeleteOnlineEvaluatorOperationsSettings = existing.DeleteOnlineEvaluatorOperationsSettings.Clone();
            ListOnlineEvaluatorsSettings = existing.ListOnlineEvaluatorsSettings;
            ActivateOnlineEvaluatorSettings = existing.ActivateOnlineEvaluatorSettings;
            ActivateOnlineEvaluatorOperationsSettings = existing.ActivateOnlineEvaluatorOperationsSettings.Clone();
            SuspendOnlineEvaluatorSettings = existing.SuspendOnlineEvaluatorSettings;
            SuspendOnlineEvaluatorOperationsSettings = existing.SuspendOnlineEvaluatorOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(OnlineEvaluatorServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OnlineEvaluatorServiceClient.CreateOnlineEvaluator</c> and
        /// <c>OnlineEvaluatorServiceClient.CreateOnlineEvaluatorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateOnlineEvaluatorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>OnlineEvaluatorServiceClient.CreateOnlineEvaluator</c> and
        /// <c>OnlineEvaluatorServiceClient.CreateOnlineEvaluatorAsync</c>.
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
        public lro::OperationsSettings CreateOnlineEvaluatorOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OnlineEvaluatorServiceClient.GetOnlineEvaluator</c> and
        /// <c>OnlineEvaluatorServiceClient.GetOnlineEvaluatorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetOnlineEvaluatorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OnlineEvaluatorServiceClient.UpdateOnlineEvaluator</c> and
        /// <c>OnlineEvaluatorServiceClient.UpdateOnlineEvaluatorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateOnlineEvaluatorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>OnlineEvaluatorServiceClient.UpdateOnlineEvaluator</c> and
        /// <c>OnlineEvaluatorServiceClient.UpdateOnlineEvaluatorAsync</c>.
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
        public lro::OperationsSettings UpdateOnlineEvaluatorOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OnlineEvaluatorServiceClient.DeleteOnlineEvaluator</c> and
        /// <c>OnlineEvaluatorServiceClient.DeleteOnlineEvaluatorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteOnlineEvaluatorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>OnlineEvaluatorServiceClient.DeleteOnlineEvaluator</c> and
        /// <c>OnlineEvaluatorServiceClient.DeleteOnlineEvaluatorAsync</c>.
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
        public lro::OperationsSettings DeleteOnlineEvaluatorOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OnlineEvaluatorServiceClient.ListOnlineEvaluators</c> and
        /// <c>OnlineEvaluatorServiceClient.ListOnlineEvaluatorsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListOnlineEvaluatorsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OnlineEvaluatorServiceClient.ActivateOnlineEvaluator</c> and
        /// <c>OnlineEvaluatorServiceClient.ActivateOnlineEvaluatorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ActivateOnlineEvaluatorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>OnlineEvaluatorServiceClient.ActivateOnlineEvaluator</c> and
        /// <c>OnlineEvaluatorServiceClient.ActivateOnlineEvaluatorAsync</c>.
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
        public lro::OperationsSettings ActivateOnlineEvaluatorOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OnlineEvaluatorServiceClient.SuspendOnlineEvaluator</c> and
        /// <c>OnlineEvaluatorServiceClient.SuspendOnlineEvaluatorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SuspendOnlineEvaluatorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>OnlineEvaluatorServiceClient.SuspendOnlineEvaluator</c> and
        /// <c>OnlineEvaluatorServiceClient.SuspendOnlineEvaluatorAsync</c>.
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
        public lro::OperationsSettings SuspendOnlineEvaluatorOperationsSettings { get; set; } = new lro::OperationsSettings
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
        /// <returns>A deep clone of this <see cref="OnlineEvaluatorServiceSettings"/> object.</returns>
        public OnlineEvaluatorServiceSettings Clone() => new OnlineEvaluatorServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="OnlineEvaluatorServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class OnlineEvaluatorServiceClientBuilder : gaxgrpc::ClientBuilderBase<OnlineEvaluatorServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public OnlineEvaluatorServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public OnlineEvaluatorServiceClientBuilder() : base(OnlineEvaluatorServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref OnlineEvaluatorServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<OnlineEvaluatorServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override OnlineEvaluatorServiceClient Build()
        {
            OnlineEvaluatorServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<OnlineEvaluatorServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<OnlineEvaluatorServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private OnlineEvaluatorServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return OnlineEvaluatorServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<OnlineEvaluatorServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return OnlineEvaluatorServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => OnlineEvaluatorServiceClient.ChannelPool;
    }

    /// <summary>OnlineEvaluatorService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// This service is used to create and manage Vertex AI OnlineEvaluators.
    /// </remarks>
    public abstract partial class OnlineEvaluatorServiceClient
    {
        /// <summary>
        /// The default endpoint for the OnlineEvaluatorService service, which is a host of "aiplatform.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "aiplatform.googleapis.com:443";

        /// <summary>The default OnlineEvaluatorService scopes.</summary>
        /// <remarks>
        /// The default OnlineEvaluatorService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(OnlineEvaluatorService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="OnlineEvaluatorServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="OnlineEvaluatorServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="OnlineEvaluatorServiceClient"/>.</returns>
        public static stt::Task<OnlineEvaluatorServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new OnlineEvaluatorServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="OnlineEvaluatorServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="OnlineEvaluatorServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="OnlineEvaluatorServiceClient"/>.</returns>
        public static OnlineEvaluatorServiceClient Create() => new OnlineEvaluatorServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="OnlineEvaluatorServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="OnlineEvaluatorServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="OnlineEvaluatorServiceClient"/>.</returns>
        internal static OnlineEvaluatorServiceClient Create(grpccore::CallInvoker callInvoker, OnlineEvaluatorServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            OnlineEvaluatorService.OnlineEvaluatorServiceClient grpcClient = new OnlineEvaluatorService.OnlineEvaluatorServiceClient(callInvoker);
            return new OnlineEvaluatorServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC OnlineEvaluatorService client</summary>
        public virtual OnlineEvaluatorService.OnlineEvaluatorServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an OnlineEvaluator in the given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<OnlineEvaluator, CreateOnlineEvaluatorOperationMetadata> CreateOnlineEvaluator(CreateOnlineEvaluatorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an OnlineEvaluator in the given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OnlineEvaluator, CreateOnlineEvaluatorOperationMetadata>> CreateOnlineEvaluatorAsync(CreateOnlineEvaluatorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an OnlineEvaluator in the given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OnlineEvaluator, CreateOnlineEvaluatorOperationMetadata>> CreateOnlineEvaluatorAsync(CreateOnlineEvaluatorRequest request, st::CancellationToken cancellationToken) =>
            CreateOnlineEvaluatorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateOnlineEvaluator</c>.</summary>
        public virtual lro::OperationsClient CreateOnlineEvaluatorOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateOnlineEvaluator</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<OnlineEvaluator, CreateOnlineEvaluatorOperationMetadata> PollOnceCreateOnlineEvaluator(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<OnlineEvaluator, CreateOnlineEvaluatorOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateOnlineEvaluatorOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateOnlineEvaluator</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<OnlineEvaluator, CreateOnlineEvaluatorOperationMetadata>> PollOnceCreateOnlineEvaluatorAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<OnlineEvaluator, CreateOnlineEvaluatorOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateOnlineEvaluatorOperationsClient, callSettings);

        /// <summary>
        /// Creates an OnlineEvaluator in the given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where the OnlineEvaluator will be created.
        /// Format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="onlineEvaluator">
        /// Required. The OnlineEvaluator to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<OnlineEvaluator, CreateOnlineEvaluatorOperationMetadata> CreateOnlineEvaluator(string parent, OnlineEvaluator onlineEvaluator, gaxgrpc::CallSettings callSettings = null) =>
            CreateOnlineEvaluator(new CreateOnlineEvaluatorRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                OnlineEvaluator = gax::GaxPreconditions.CheckNotNull(onlineEvaluator, nameof(onlineEvaluator)),
            }, callSettings);

        /// <summary>
        /// Creates an OnlineEvaluator in the given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where the OnlineEvaluator will be created.
        /// Format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="onlineEvaluator">
        /// Required. The OnlineEvaluator to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OnlineEvaluator, CreateOnlineEvaluatorOperationMetadata>> CreateOnlineEvaluatorAsync(string parent, OnlineEvaluator onlineEvaluator, gaxgrpc::CallSettings callSettings = null) =>
            CreateOnlineEvaluatorAsync(new CreateOnlineEvaluatorRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                OnlineEvaluator = gax::GaxPreconditions.CheckNotNull(onlineEvaluator, nameof(onlineEvaluator)),
            }, callSettings);

        /// <summary>
        /// Creates an OnlineEvaluator in the given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where the OnlineEvaluator will be created.
        /// Format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="onlineEvaluator">
        /// Required. The OnlineEvaluator to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OnlineEvaluator, CreateOnlineEvaluatorOperationMetadata>> CreateOnlineEvaluatorAsync(string parent, OnlineEvaluator onlineEvaluator, st::CancellationToken cancellationToken) =>
            CreateOnlineEvaluatorAsync(parent, onlineEvaluator, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an OnlineEvaluator in the given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where the OnlineEvaluator will be created.
        /// Format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="onlineEvaluator">
        /// Required. The OnlineEvaluator to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<OnlineEvaluator, CreateOnlineEvaluatorOperationMetadata> CreateOnlineEvaluator(gagr::LocationName parent, OnlineEvaluator onlineEvaluator, gaxgrpc::CallSettings callSettings = null) =>
            CreateOnlineEvaluator(new CreateOnlineEvaluatorRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OnlineEvaluator = gax::GaxPreconditions.CheckNotNull(onlineEvaluator, nameof(onlineEvaluator)),
            }, callSettings);

        /// <summary>
        /// Creates an OnlineEvaluator in the given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where the OnlineEvaluator will be created.
        /// Format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="onlineEvaluator">
        /// Required. The OnlineEvaluator to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OnlineEvaluator, CreateOnlineEvaluatorOperationMetadata>> CreateOnlineEvaluatorAsync(gagr::LocationName parent, OnlineEvaluator onlineEvaluator, gaxgrpc::CallSettings callSettings = null) =>
            CreateOnlineEvaluatorAsync(new CreateOnlineEvaluatorRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OnlineEvaluator = gax::GaxPreconditions.CheckNotNull(onlineEvaluator, nameof(onlineEvaluator)),
            }, callSettings);

        /// <summary>
        /// Creates an OnlineEvaluator in the given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where the OnlineEvaluator will be created.
        /// Format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="onlineEvaluator">
        /// Required. The OnlineEvaluator to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OnlineEvaluator, CreateOnlineEvaluatorOperationMetadata>> CreateOnlineEvaluatorAsync(gagr::LocationName parent, OnlineEvaluator onlineEvaluator, st::CancellationToken cancellationToken) =>
            CreateOnlineEvaluatorAsync(parent, onlineEvaluator, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of an OnlineEvaluator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual OnlineEvaluator GetOnlineEvaluator(GetOnlineEvaluatorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of an OnlineEvaluator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OnlineEvaluator> GetOnlineEvaluatorAsync(GetOnlineEvaluatorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of an OnlineEvaluator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OnlineEvaluator> GetOnlineEvaluatorAsync(GetOnlineEvaluatorRequest request, st::CancellationToken cancellationToken) =>
            GetOnlineEvaluatorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of an OnlineEvaluator.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OnlineEvaluator to retrieve.
        /// Format: projects/{project}/locations/{location}/onlineEvaluators/{id}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual OnlineEvaluator GetOnlineEvaluator(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOnlineEvaluator(new GetOnlineEvaluatorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of an OnlineEvaluator.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OnlineEvaluator to retrieve.
        /// Format: projects/{project}/locations/{location}/onlineEvaluators/{id}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OnlineEvaluator> GetOnlineEvaluatorAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOnlineEvaluatorAsync(new GetOnlineEvaluatorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of an OnlineEvaluator.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OnlineEvaluator to retrieve.
        /// Format: projects/{project}/locations/{location}/onlineEvaluators/{id}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OnlineEvaluator> GetOnlineEvaluatorAsync(string name, st::CancellationToken cancellationToken) =>
            GetOnlineEvaluatorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of an OnlineEvaluator.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OnlineEvaluator to retrieve.
        /// Format: projects/{project}/locations/{location}/onlineEvaluators/{id}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual OnlineEvaluator GetOnlineEvaluator(OnlineEvaluatorName name, gaxgrpc::CallSettings callSettings = null) =>
            GetOnlineEvaluator(new GetOnlineEvaluatorRequest
            {
                OnlineEvaluatorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of an OnlineEvaluator.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OnlineEvaluator to retrieve.
        /// Format: projects/{project}/locations/{location}/onlineEvaluators/{id}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OnlineEvaluator> GetOnlineEvaluatorAsync(OnlineEvaluatorName name, gaxgrpc::CallSettings callSettings = null) =>
            GetOnlineEvaluatorAsync(new GetOnlineEvaluatorRequest
            {
                OnlineEvaluatorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of an OnlineEvaluator.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OnlineEvaluator to retrieve.
        /// Format: projects/{project}/locations/{location}/onlineEvaluators/{id}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OnlineEvaluator> GetOnlineEvaluatorAsync(OnlineEvaluatorName name, st::CancellationToken cancellationToken) =>
            GetOnlineEvaluatorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the fields of an OnlineEvaluator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<OnlineEvaluator, UpdateOnlineEvaluatorOperationMetadata> UpdateOnlineEvaluator(UpdateOnlineEvaluatorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the fields of an OnlineEvaluator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OnlineEvaluator, UpdateOnlineEvaluatorOperationMetadata>> UpdateOnlineEvaluatorAsync(UpdateOnlineEvaluatorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the fields of an OnlineEvaluator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OnlineEvaluator, UpdateOnlineEvaluatorOperationMetadata>> UpdateOnlineEvaluatorAsync(UpdateOnlineEvaluatorRequest request, st::CancellationToken cancellationToken) =>
            UpdateOnlineEvaluatorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateOnlineEvaluator</c>.</summary>
        public virtual lro::OperationsClient UpdateOnlineEvaluatorOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateOnlineEvaluator</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<OnlineEvaluator, UpdateOnlineEvaluatorOperationMetadata> PollOnceUpdateOnlineEvaluator(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<OnlineEvaluator, UpdateOnlineEvaluatorOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateOnlineEvaluatorOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateOnlineEvaluator</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<OnlineEvaluator, UpdateOnlineEvaluatorOperationMetadata>> PollOnceUpdateOnlineEvaluatorAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<OnlineEvaluator, UpdateOnlineEvaluatorOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateOnlineEvaluatorOperationsClient, callSettings);

        /// <summary>
        /// Updates the fields of an OnlineEvaluator.
        /// </summary>
        /// <param name="onlineEvaluator">
        /// Required. The OnlineEvaluator to update.
        /// Format: projects/{project}/locations/{location}/onlineEvaluators/{id}.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to control which fields get updated. If the
        /// mask is not present, all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<OnlineEvaluator, UpdateOnlineEvaluatorOperationMetadata> UpdateOnlineEvaluator(OnlineEvaluator onlineEvaluator, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateOnlineEvaluator(new UpdateOnlineEvaluatorRequest
            {
                OnlineEvaluator = gax::GaxPreconditions.CheckNotNull(onlineEvaluator, nameof(onlineEvaluator)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the fields of an OnlineEvaluator.
        /// </summary>
        /// <param name="onlineEvaluator">
        /// Required. The OnlineEvaluator to update.
        /// Format: projects/{project}/locations/{location}/onlineEvaluators/{id}.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to control which fields get updated. If the
        /// mask is not present, all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OnlineEvaluator, UpdateOnlineEvaluatorOperationMetadata>> UpdateOnlineEvaluatorAsync(OnlineEvaluator onlineEvaluator, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateOnlineEvaluatorAsync(new UpdateOnlineEvaluatorRequest
            {
                OnlineEvaluator = gax::GaxPreconditions.CheckNotNull(onlineEvaluator, nameof(onlineEvaluator)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the fields of an OnlineEvaluator.
        /// </summary>
        /// <param name="onlineEvaluator">
        /// Required. The OnlineEvaluator to update.
        /// Format: projects/{project}/locations/{location}/onlineEvaluators/{id}.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to control which fields get updated. If the
        /// mask is not present, all fields will be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OnlineEvaluator, UpdateOnlineEvaluatorOperationMetadata>> UpdateOnlineEvaluatorAsync(OnlineEvaluator onlineEvaluator, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateOnlineEvaluatorAsync(onlineEvaluator, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an OnlineEvaluator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOnlineEvaluatorOperationMetadata> DeleteOnlineEvaluator(DeleteOnlineEvaluatorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an OnlineEvaluator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOnlineEvaluatorOperationMetadata>> DeleteOnlineEvaluatorAsync(DeleteOnlineEvaluatorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an OnlineEvaluator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOnlineEvaluatorOperationMetadata>> DeleteOnlineEvaluatorAsync(DeleteOnlineEvaluatorRequest request, st::CancellationToken cancellationToken) =>
            DeleteOnlineEvaluatorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteOnlineEvaluator</c>.</summary>
        public virtual lro::OperationsClient DeleteOnlineEvaluatorOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteOnlineEvaluator</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOnlineEvaluatorOperationMetadata> PollOnceDeleteOnlineEvaluator(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOnlineEvaluatorOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteOnlineEvaluatorOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteOnlineEvaluator</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOnlineEvaluatorOperationMetadata>> PollOnceDeleteOnlineEvaluatorAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOnlineEvaluatorOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteOnlineEvaluatorOperationsClient, callSettings);

        /// <summary>
        /// Deletes an OnlineEvaluator.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OnlineEvaluator to delete.
        /// Format: projects/{project}/locations/{location}/onlineEvaluators/{id}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOnlineEvaluatorOperationMetadata> DeleteOnlineEvaluator(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteOnlineEvaluator(new DeleteOnlineEvaluatorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an OnlineEvaluator.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OnlineEvaluator to delete.
        /// Format: projects/{project}/locations/{location}/onlineEvaluators/{id}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOnlineEvaluatorOperationMetadata>> DeleteOnlineEvaluatorAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteOnlineEvaluatorAsync(new DeleteOnlineEvaluatorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an OnlineEvaluator.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OnlineEvaluator to delete.
        /// Format: projects/{project}/locations/{location}/onlineEvaluators/{id}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOnlineEvaluatorOperationMetadata>> DeleteOnlineEvaluatorAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteOnlineEvaluatorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an OnlineEvaluator.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OnlineEvaluator to delete.
        /// Format: projects/{project}/locations/{location}/onlineEvaluators/{id}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOnlineEvaluatorOperationMetadata> DeleteOnlineEvaluator(OnlineEvaluatorName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteOnlineEvaluator(new DeleteOnlineEvaluatorRequest
            {
                OnlineEvaluatorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an OnlineEvaluator.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OnlineEvaluator to delete.
        /// Format: projects/{project}/locations/{location}/onlineEvaluators/{id}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOnlineEvaluatorOperationMetadata>> DeleteOnlineEvaluatorAsync(OnlineEvaluatorName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteOnlineEvaluatorAsync(new DeleteOnlineEvaluatorRequest
            {
                OnlineEvaluatorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an OnlineEvaluator.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OnlineEvaluator to delete.
        /// Format: projects/{project}/locations/{location}/onlineEvaluators/{id}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOnlineEvaluatorOperationMetadata>> DeleteOnlineEvaluatorAsync(OnlineEvaluatorName name, st::CancellationToken cancellationToken) =>
            DeleteOnlineEvaluatorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the OnlineEvaluators for the given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="OnlineEvaluator"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOnlineEvaluatorsResponse, OnlineEvaluator> ListOnlineEvaluators(ListOnlineEvaluatorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the OnlineEvaluators for the given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="OnlineEvaluator"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOnlineEvaluatorsResponse, OnlineEvaluator> ListOnlineEvaluatorsAsync(ListOnlineEvaluatorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the OnlineEvaluators for the given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the OnlineEvaluators to list.
        /// Format: projects/{project}/locations/{location}.
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
        /// <returns>A pageable sequence of <see cref="OnlineEvaluator"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOnlineEvaluatorsResponse, OnlineEvaluator> ListOnlineEvaluators(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOnlineEvaluatorsRequest request = new ListOnlineEvaluatorsRequest
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
            return ListOnlineEvaluators(request, callSettings);
        }

        /// <summary>
        /// Lists the OnlineEvaluators for the given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the OnlineEvaluators to list.
        /// Format: projects/{project}/locations/{location}.
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
        /// <returns>A pageable asynchronous sequence of <see cref="OnlineEvaluator"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOnlineEvaluatorsResponse, OnlineEvaluator> ListOnlineEvaluatorsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOnlineEvaluatorsRequest request = new ListOnlineEvaluatorsRequest
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
            return ListOnlineEvaluatorsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the OnlineEvaluators for the given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the OnlineEvaluators to list.
        /// Format: projects/{project}/locations/{location}.
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
        /// <returns>A pageable sequence of <see cref="OnlineEvaluator"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOnlineEvaluatorsResponse, OnlineEvaluator> ListOnlineEvaluators(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOnlineEvaluatorsRequest request = new ListOnlineEvaluatorsRequest
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
            return ListOnlineEvaluators(request, callSettings);
        }

        /// <summary>
        /// Lists the OnlineEvaluators for the given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the OnlineEvaluators to list.
        /// Format: projects/{project}/locations/{location}.
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
        /// <returns>A pageable asynchronous sequence of <see cref="OnlineEvaluator"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOnlineEvaluatorsResponse, OnlineEvaluator> ListOnlineEvaluatorsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOnlineEvaluatorsRequest request = new ListOnlineEvaluatorsRequest
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
            return ListOnlineEvaluatorsAsync(request, callSettings);
        }

        /// <summary>
        /// Activates an OnlineEvaluator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<OnlineEvaluator, ActivateOnlineEvaluatorOperationMetadata> ActivateOnlineEvaluator(ActivateOnlineEvaluatorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Activates an OnlineEvaluator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OnlineEvaluator, ActivateOnlineEvaluatorOperationMetadata>> ActivateOnlineEvaluatorAsync(ActivateOnlineEvaluatorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Activates an OnlineEvaluator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OnlineEvaluator, ActivateOnlineEvaluatorOperationMetadata>> ActivateOnlineEvaluatorAsync(ActivateOnlineEvaluatorRequest request, st::CancellationToken cancellationToken) =>
            ActivateOnlineEvaluatorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ActivateOnlineEvaluator</c>.</summary>
        public virtual lro::OperationsClient ActivateOnlineEvaluatorOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ActivateOnlineEvaluator</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<OnlineEvaluator, ActivateOnlineEvaluatorOperationMetadata> PollOnceActivateOnlineEvaluator(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<OnlineEvaluator, ActivateOnlineEvaluatorOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ActivateOnlineEvaluatorOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ActivateOnlineEvaluator</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<OnlineEvaluator, ActivateOnlineEvaluatorOperationMetadata>> PollOnceActivateOnlineEvaluatorAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<OnlineEvaluator, ActivateOnlineEvaluatorOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ActivateOnlineEvaluatorOperationsClient, callSettings);

        /// <summary>
        /// Activates an OnlineEvaluator.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OnlineEvaluator to activate.
        /// Format: projects/{project}/locations/{location}/onlineEvaluators/{id}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<OnlineEvaluator, ActivateOnlineEvaluatorOperationMetadata> ActivateOnlineEvaluator(string name, gaxgrpc::CallSettings callSettings = null) =>
            ActivateOnlineEvaluator(new ActivateOnlineEvaluatorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Activates an OnlineEvaluator.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OnlineEvaluator to activate.
        /// Format: projects/{project}/locations/{location}/onlineEvaluators/{id}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OnlineEvaluator, ActivateOnlineEvaluatorOperationMetadata>> ActivateOnlineEvaluatorAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ActivateOnlineEvaluatorAsync(new ActivateOnlineEvaluatorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Activates an OnlineEvaluator.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OnlineEvaluator to activate.
        /// Format: projects/{project}/locations/{location}/onlineEvaluators/{id}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OnlineEvaluator, ActivateOnlineEvaluatorOperationMetadata>> ActivateOnlineEvaluatorAsync(string name, st::CancellationToken cancellationToken) =>
            ActivateOnlineEvaluatorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Activates an OnlineEvaluator.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OnlineEvaluator to activate.
        /// Format: projects/{project}/locations/{location}/onlineEvaluators/{id}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<OnlineEvaluator, ActivateOnlineEvaluatorOperationMetadata> ActivateOnlineEvaluator(OnlineEvaluatorName name, gaxgrpc::CallSettings callSettings = null) =>
            ActivateOnlineEvaluator(new ActivateOnlineEvaluatorRequest
            {
                OnlineEvaluatorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Activates an OnlineEvaluator.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OnlineEvaluator to activate.
        /// Format: projects/{project}/locations/{location}/onlineEvaluators/{id}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OnlineEvaluator, ActivateOnlineEvaluatorOperationMetadata>> ActivateOnlineEvaluatorAsync(OnlineEvaluatorName name, gaxgrpc::CallSettings callSettings = null) =>
            ActivateOnlineEvaluatorAsync(new ActivateOnlineEvaluatorRequest
            {
                OnlineEvaluatorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Activates an OnlineEvaluator.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OnlineEvaluator to activate.
        /// Format: projects/{project}/locations/{location}/onlineEvaluators/{id}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OnlineEvaluator, ActivateOnlineEvaluatorOperationMetadata>> ActivateOnlineEvaluatorAsync(OnlineEvaluatorName name, st::CancellationToken cancellationToken) =>
            ActivateOnlineEvaluatorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Suspends an OnlineEvaluator. When an OnlineEvaluator is suspended, it won't
        /// run any evaluations until it is activated again.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<OnlineEvaluator, SuspendOnlineEvaluatorOperationMetadata> SuspendOnlineEvaluator(SuspendOnlineEvaluatorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Suspends an OnlineEvaluator. When an OnlineEvaluator is suspended, it won't
        /// run any evaluations until it is activated again.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OnlineEvaluator, SuspendOnlineEvaluatorOperationMetadata>> SuspendOnlineEvaluatorAsync(SuspendOnlineEvaluatorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Suspends an OnlineEvaluator. When an OnlineEvaluator is suspended, it won't
        /// run any evaluations until it is activated again.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OnlineEvaluator, SuspendOnlineEvaluatorOperationMetadata>> SuspendOnlineEvaluatorAsync(SuspendOnlineEvaluatorRequest request, st::CancellationToken cancellationToken) =>
            SuspendOnlineEvaluatorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SuspendOnlineEvaluator</c>.</summary>
        public virtual lro::OperationsClient SuspendOnlineEvaluatorOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SuspendOnlineEvaluator</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<OnlineEvaluator, SuspendOnlineEvaluatorOperationMetadata> PollOnceSuspendOnlineEvaluator(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<OnlineEvaluator, SuspendOnlineEvaluatorOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SuspendOnlineEvaluatorOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SuspendOnlineEvaluator</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<OnlineEvaluator, SuspendOnlineEvaluatorOperationMetadata>> PollOnceSuspendOnlineEvaluatorAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<OnlineEvaluator, SuspendOnlineEvaluatorOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SuspendOnlineEvaluatorOperationsClient, callSettings);

        /// <summary>
        /// Suspends an OnlineEvaluator. When an OnlineEvaluator is suspended, it won't
        /// run any evaluations until it is activated again.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OnlineEvaluator to suspend.
        /// Format: projects/{project}/locations/{location}/onlineEvaluators/{id}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<OnlineEvaluator, SuspendOnlineEvaluatorOperationMetadata> SuspendOnlineEvaluator(string name, gaxgrpc::CallSettings callSettings = null) =>
            SuspendOnlineEvaluator(new SuspendOnlineEvaluatorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Suspends an OnlineEvaluator. When an OnlineEvaluator is suspended, it won't
        /// run any evaluations until it is activated again.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OnlineEvaluator to suspend.
        /// Format: projects/{project}/locations/{location}/onlineEvaluators/{id}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OnlineEvaluator, SuspendOnlineEvaluatorOperationMetadata>> SuspendOnlineEvaluatorAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            SuspendOnlineEvaluatorAsync(new SuspendOnlineEvaluatorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Suspends an OnlineEvaluator. When an OnlineEvaluator is suspended, it won't
        /// run any evaluations until it is activated again.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OnlineEvaluator to suspend.
        /// Format: projects/{project}/locations/{location}/onlineEvaluators/{id}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OnlineEvaluator, SuspendOnlineEvaluatorOperationMetadata>> SuspendOnlineEvaluatorAsync(string name, st::CancellationToken cancellationToken) =>
            SuspendOnlineEvaluatorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Suspends an OnlineEvaluator. When an OnlineEvaluator is suspended, it won't
        /// run any evaluations until it is activated again.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OnlineEvaluator to suspend.
        /// Format: projects/{project}/locations/{location}/onlineEvaluators/{id}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<OnlineEvaluator, SuspendOnlineEvaluatorOperationMetadata> SuspendOnlineEvaluator(OnlineEvaluatorName name, gaxgrpc::CallSettings callSettings = null) =>
            SuspendOnlineEvaluator(new SuspendOnlineEvaluatorRequest
            {
                OnlineEvaluatorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Suspends an OnlineEvaluator. When an OnlineEvaluator is suspended, it won't
        /// run any evaluations until it is activated again.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OnlineEvaluator to suspend.
        /// Format: projects/{project}/locations/{location}/onlineEvaluators/{id}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OnlineEvaluator, SuspendOnlineEvaluatorOperationMetadata>> SuspendOnlineEvaluatorAsync(OnlineEvaluatorName name, gaxgrpc::CallSettings callSettings = null) =>
            SuspendOnlineEvaluatorAsync(new SuspendOnlineEvaluatorRequest
            {
                OnlineEvaluatorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Suspends an OnlineEvaluator. When an OnlineEvaluator is suspended, it won't
        /// run any evaluations until it is activated again.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OnlineEvaluator to suspend.
        /// Format: projects/{project}/locations/{location}/onlineEvaluators/{id}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OnlineEvaluator, SuspendOnlineEvaluatorOperationMetadata>> SuspendOnlineEvaluatorAsync(OnlineEvaluatorName name, st::CancellationToken cancellationToken) =>
            SuspendOnlineEvaluatorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>OnlineEvaluatorService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// This service is used to create and manage Vertex AI OnlineEvaluators.
    /// </remarks>
    public sealed partial class OnlineEvaluatorServiceClientImpl : OnlineEvaluatorServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateOnlineEvaluatorRequest, lro::Operation> _callCreateOnlineEvaluator;

        private readonly gaxgrpc::ApiCall<GetOnlineEvaluatorRequest, OnlineEvaluator> _callGetOnlineEvaluator;

        private readonly gaxgrpc::ApiCall<UpdateOnlineEvaluatorRequest, lro::Operation> _callUpdateOnlineEvaluator;

        private readonly gaxgrpc::ApiCall<DeleteOnlineEvaluatorRequest, lro::Operation> _callDeleteOnlineEvaluator;

        private readonly gaxgrpc::ApiCall<ListOnlineEvaluatorsRequest, ListOnlineEvaluatorsResponse> _callListOnlineEvaluators;

        private readonly gaxgrpc::ApiCall<ActivateOnlineEvaluatorRequest, lro::Operation> _callActivateOnlineEvaluator;

        private readonly gaxgrpc::ApiCall<SuspendOnlineEvaluatorRequest, lro::Operation> _callSuspendOnlineEvaluator;

        /// <summary>
        /// Constructs a client wrapper for the OnlineEvaluatorService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="OnlineEvaluatorServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public OnlineEvaluatorServiceClientImpl(OnlineEvaluatorService.OnlineEvaluatorServiceClient grpcClient, OnlineEvaluatorServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            OnlineEvaluatorServiceSettings effectiveSettings = settings ?? OnlineEvaluatorServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateOnlineEvaluatorOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateOnlineEvaluatorOperationsSettings, logger);
            UpdateOnlineEvaluatorOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateOnlineEvaluatorOperationsSettings, logger);
            DeleteOnlineEvaluatorOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteOnlineEvaluatorOperationsSettings, logger);
            ActivateOnlineEvaluatorOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ActivateOnlineEvaluatorOperationsSettings, logger);
            SuspendOnlineEvaluatorOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.SuspendOnlineEvaluatorOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreateOnlineEvaluator = clientHelper.BuildApiCall<CreateOnlineEvaluatorRequest, lro::Operation>("CreateOnlineEvaluator", grpcClient.CreateOnlineEvaluatorAsync, grpcClient.CreateOnlineEvaluator, effectiveSettings.CreateOnlineEvaluatorSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateOnlineEvaluator);
            Modify_CreateOnlineEvaluatorApiCall(ref _callCreateOnlineEvaluator);
            _callGetOnlineEvaluator = clientHelper.BuildApiCall<GetOnlineEvaluatorRequest, OnlineEvaluator>("GetOnlineEvaluator", grpcClient.GetOnlineEvaluatorAsync, grpcClient.GetOnlineEvaluator, effectiveSettings.GetOnlineEvaluatorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetOnlineEvaluator);
            Modify_GetOnlineEvaluatorApiCall(ref _callGetOnlineEvaluator);
            _callUpdateOnlineEvaluator = clientHelper.BuildApiCall<UpdateOnlineEvaluatorRequest, lro::Operation>("UpdateOnlineEvaluator", grpcClient.UpdateOnlineEvaluatorAsync, grpcClient.UpdateOnlineEvaluator, effectiveSettings.UpdateOnlineEvaluatorSettings).WithGoogleRequestParam("online_evaluator.name", request => request.OnlineEvaluator?.Name);
            Modify_ApiCall(ref _callUpdateOnlineEvaluator);
            Modify_UpdateOnlineEvaluatorApiCall(ref _callUpdateOnlineEvaluator);
            _callDeleteOnlineEvaluator = clientHelper.BuildApiCall<DeleteOnlineEvaluatorRequest, lro::Operation>("DeleteOnlineEvaluator", grpcClient.DeleteOnlineEvaluatorAsync, grpcClient.DeleteOnlineEvaluator, effectiveSettings.DeleteOnlineEvaluatorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteOnlineEvaluator);
            Modify_DeleteOnlineEvaluatorApiCall(ref _callDeleteOnlineEvaluator);
            _callListOnlineEvaluators = clientHelper.BuildApiCall<ListOnlineEvaluatorsRequest, ListOnlineEvaluatorsResponse>("ListOnlineEvaluators", grpcClient.ListOnlineEvaluatorsAsync, grpcClient.ListOnlineEvaluators, effectiveSettings.ListOnlineEvaluatorsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListOnlineEvaluators);
            Modify_ListOnlineEvaluatorsApiCall(ref _callListOnlineEvaluators);
            _callActivateOnlineEvaluator = clientHelper.BuildApiCall<ActivateOnlineEvaluatorRequest, lro::Operation>("ActivateOnlineEvaluator", grpcClient.ActivateOnlineEvaluatorAsync, grpcClient.ActivateOnlineEvaluator, effectiveSettings.ActivateOnlineEvaluatorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callActivateOnlineEvaluator);
            Modify_ActivateOnlineEvaluatorApiCall(ref _callActivateOnlineEvaluator);
            _callSuspendOnlineEvaluator = clientHelper.BuildApiCall<SuspendOnlineEvaluatorRequest, lro::Operation>("SuspendOnlineEvaluator", grpcClient.SuspendOnlineEvaluatorAsync, grpcClient.SuspendOnlineEvaluator, effectiveSettings.SuspendOnlineEvaluatorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callSuspendOnlineEvaluator);
            Modify_SuspendOnlineEvaluatorApiCall(ref _callSuspendOnlineEvaluator);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateOnlineEvaluatorApiCall(ref gaxgrpc::ApiCall<CreateOnlineEvaluatorRequest, lro::Operation> call);

        partial void Modify_GetOnlineEvaluatorApiCall(ref gaxgrpc::ApiCall<GetOnlineEvaluatorRequest, OnlineEvaluator> call);

        partial void Modify_UpdateOnlineEvaluatorApiCall(ref gaxgrpc::ApiCall<UpdateOnlineEvaluatorRequest, lro::Operation> call);

        partial void Modify_DeleteOnlineEvaluatorApiCall(ref gaxgrpc::ApiCall<DeleteOnlineEvaluatorRequest, lro::Operation> call);

        partial void Modify_ListOnlineEvaluatorsApiCall(ref gaxgrpc::ApiCall<ListOnlineEvaluatorsRequest, ListOnlineEvaluatorsResponse> call);

        partial void Modify_ActivateOnlineEvaluatorApiCall(ref gaxgrpc::ApiCall<ActivateOnlineEvaluatorRequest, lro::Operation> call);

        partial void Modify_SuspendOnlineEvaluatorApiCall(ref gaxgrpc::ApiCall<SuspendOnlineEvaluatorRequest, lro::Operation> call);

        partial void OnConstruction(OnlineEvaluatorService.OnlineEvaluatorServiceClient grpcClient, OnlineEvaluatorServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC OnlineEvaluatorService client</summary>
        public override OnlineEvaluatorService.OnlineEvaluatorServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateOnlineEvaluatorRequest(ref CreateOnlineEvaluatorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetOnlineEvaluatorRequest(ref GetOnlineEvaluatorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateOnlineEvaluatorRequest(ref UpdateOnlineEvaluatorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteOnlineEvaluatorRequest(ref DeleteOnlineEvaluatorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListOnlineEvaluatorsRequest(ref ListOnlineEvaluatorsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ActivateOnlineEvaluatorRequest(ref ActivateOnlineEvaluatorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SuspendOnlineEvaluatorRequest(ref SuspendOnlineEvaluatorRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateOnlineEvaluator</c>.</summary>
        public override lro::OperationsClient CreateOnlineEvaluatorOperationsClient { get; }

        /// <summary>
        /// Creates an OnlineEvaluator in the given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<OnlineEvaluator, CreateOnlineEvaluatorOperationMetadata> CreateOnlineEvaluator(CreateOnlineEvaluatorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateOnlineEvaluatorRequest(ref request, ref callSettings);
            return new lro::Operation<OnlineEvaluator, CreateOnlineEvaluatorOperationMetadata>(_callCreateOnlineEvaluator.Sync(request, callSettings), CreateOnlineEvaluatorOperationsClient);
        }

        /// <summary>
        /// Creates an OnlineEvaluator in the given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<OnlineEvaluator, CreateOnlineEvaluatorOperationMetadata>> CreateOnlineEvaluatorAsync(CreateOnlineEvaluatorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateOnlineEvaluatorRequest(ref request, ref callSettings);
            return new lro::Operation<OnlineEvaluator, CreateOnlineEvaluatorOperationMetadata>(await _callCreateOnlineEvaluator.Async(request, callSettings).ConfigureAwait(false), CreateOnlineEvaluatorOperationsClient);
        }

        /// <summary>
        /// Gets details of an OnlineEvaluator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override OnlineEvaluator GetOnlineEvaluator(GetOnlineEvaluatorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOnlineEvaluatorRequest(ref request, ref callSettings);
            return _callGetOnlineEvaluator.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of an OnlineEvaluator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<OnlineEvaluator> GetOnlineEvaluatorAsync(GetOnlineEvaluatorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOnlineEvaluatorRequest(ref request, ref callSettings);
            return _callGetOnlineEvaluator.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateOnlineEvaluator</c>.</summary>
        public override lro::OperationsClient UpdateOnlineEvaluatorOperationsClient { get; }

        /// <summary>
        /// Updates the fields of an OnlineEvaluator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<OnlineEvaluator, UpdateOnlineEvaluatorOperationMetadata> UpdateOnlineEvaluator(UpdateOnlineEvaluatorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateOnlineEvaluatorRequest(ref request, ref callSettings);
            return new lro::Operation<OnlineEvaluator, UpdateOnlineEvaluatorOperationMetadata>(_callUpdateOnlineEvaluator.Sync(request, callSettings), UpdateOnlineEvaluatorOperationsClient);
        }

        /// <summary>
        /// Updates the fields of an OnlineEvaluator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<OnlineEvaluator, UpdateOnlineEvaluatorOperationMetadata>> UpdateOnlineEvaluatorAsync(UpdateOnlineEvaluatorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateOnlineEvaluatorRequest(ref request, ref callSettings);
            return new lro::Operation<OnlineEvaluator, UpdateOnlineEvaluatorOperationMetadata>(await _callUpdateOnlineEvaluator.Async(request, callSettings).ConfigureAwait(false), UpdateOnlineEvaluatorOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteOnlineEvaluator</c>.</summary>
        public override lro::OperationsClient DeleteOnlineEvaluatorOperationsClient { get; }

        /// <summary>
        /// Deletes an OnlineEvaluator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteOnlineEvaluatorOperationMetadata> DeleteOnlineEvaluator(DeleteOnlineEvaluatorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteOnlineEvaluatorRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOnlineEvaluatorOperationMetadata>(_callDeleteOnlineEvaluator.Sync(request, callSettings), DeleteOnlineEvaluatorOperationsClient);
        }

        /// <summary>
        /// Deletes an OnlineEvaluator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteOnlineEvaluatorOperationMetadata>> DeleteOnlineEvaluatorAsync(DeleteOnlineEvaluatorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteOnlineEvaluatorRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOnlineEvaluatorOperationMetadata>(await _callDeleteOnlineEvaluator.Async(request, callSettings).ConfigureAwait(false), DeleteOnlineEvaluatorOperationsClient);
        }

        /// <summary>
        /// Lists the OnlineEvaluators for the given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="OnlineEvaluator"/> resources.</returns>
        public override gax::PagedEnumerable<ListOnlineEvaluatorsResponse, OnlineEvaluator> ListOnlineEvaluators(ListOnlineEvaluatorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOnlineEvaluatorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListOnlineEvaluatorsRequest, ListOnlineEvaluatorsResponse, OnlineEvaluator>(_callListOnlineEvaluators, request, callSettings);
        }

        /// <summary>
        /// Lists the OnlineEvaluators for the given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="OnlineEvaluator"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListOnlineEvaluatorsResponse, OnlineEvaluator> ListOnlineEvaluatorsAsync(ListOnlineEvaluatorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOnlineEvaluatorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListOnlineEvaluatorsRequest, ListOnlineEvaluatorsResponse, OnlineEvaluator>(_callListOnlineEvaluators, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>ActivateOnlineEvaluator</c>.</summary>
        public override lro::OperationsClient ActivateOnlineEvaluatorOperationsClient { get; }

        /// <summary>
        /// Activates an OnlineEvaluator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<OnlineEvaluator, ActivateOnlineEvaluatorOperationMetadata> ActivateOnlineEvaluator(ActivateOnlineEvaluatorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ActivateOnlineEvaluatorRequest(ref request, ref callSettings);
            return new lro::Operation<OnlineEvaluator, ActivateOnlineEvaluatorOperationMetadata>(_callActivateOnlineEvaluator.Sync(request, callSettings), ActivateOnlineEvaluatorOperationsClient);
        }

        /// <summary>
        /// Activates an OnlineEvaluator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<OnlineEvaluator, ActivateOnlineEvaluatorOperationMetadata>> ActivateOnlineEvaluatorAsync(ActivateOnlineEvaluatorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ActivateOnlineEvaluatorRequest(ref request, ref callSettings);
            return new lro::Operation<OnlineEvaluator, ActivateOnlineEvaluatorOperationMetadata>(await _callActivateOnlineEvaluator.Async(request, callSettings).ConfigureAwait(false), ActivateOnlineEvaluatorOperationsClient);
        }

        /// <summary>The long-running operations client for <c>SuspendOnlineEvaluator</c>.</summary>
        public override lro::OperationsClient SuspendOnlineEvaluatorOperationsClient { get; }

        /// <summary>
        /// Suspends an OnlineEvaluator. When an OnlineEvaluator is suspended, it won't
        /// run any evaluations until it is activated again.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<OnlineEvaluator, SuspendOnlineEvaluatorOperationMetadata> SuspendOnlineEvaluator(SuspendOnlineEvaluatorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SuspendOnlineEvaluatorRequest(ref request, ref callSettings);
            return new lro::Operation<OnlineEvaluator, SuspendOnlineEvaluatorOperationMetadata>(_callSuspendOnlineEvaluator.Sync(request, callSettings), SuspendOnlineEvaluatorOperationsClient);
        }

        /// <summary>
        /// Suspends an OnlineEvaluator. When an OnlineEvaluator is suspended, it won't
        /// run any evaluations until it is activated again.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<OnlineEvaluator, SuspendOnlineEvaluatorOperationMetadata>> SuspendOnlineEvaluatorAsync(SuspendOnlineEvaluatorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SuspendOnlineEvaluatorRequest(ref request, ref callSettings);
            return new lro::Operation<OnlineEvaluator, SuspendOnlineEvaluatorOperationMetadata>(await _callSuspendOnlineEvaluator.Async(request, callSettings).ConfigureAwait(false), SuspendOnlineEvaluatorOperationsClient);
        }
    }

    public partial class ListOnlineEvaluatorsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListOnlineEvaluatorsResponse : gaxgrpc::IPageResponse<OnlineEvaluator>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<OnlineEvaluator> GetEnumerator() => OnlineEvaluators.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class OnlineEvaluatorService
    {
        public partial class OnlineEvaluatorServiceClient
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

    public static partial class OnlineEvaluatorService
    {
        public partial class OnlineEvaluatorServiceClient
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
