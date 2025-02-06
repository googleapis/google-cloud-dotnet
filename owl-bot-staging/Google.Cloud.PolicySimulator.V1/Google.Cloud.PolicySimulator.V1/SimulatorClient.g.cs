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

namespace Google.Cloud.PolicySimulator.V1
{
    /// <summary>Settings for <see cref="SimulatorClient"/> instances.</summary>
    public sealed partial class SimulatorSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SimulatorSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SimulatorSettings"/>.</returns>
        public static SimulatorSettings GetDefault() => new SimulatorSettings();

        /// <summary>Constructs a new <see cref="SimulatorSettings"/> object with default settings.</summary>
        public SimulatorSettings()
        {
        }

        private SimulatorSettings(SimulatorSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetReplaySettings = existing.GetReplaySettings;
            CreateReplaySettings = existing.CreateReplaySettings;
            CreateReplayOperationsSettings = existing.CreateReplayOperationsSettings.Clone();
            ListReplayResultsSettings = existing.ListReplayResultsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SimulatorSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>SimulatorClient.GetReplay</c>
        ///  and <c>SimulatorClient.GetReplayAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetReplaySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SimulatorClient.CreateReplay</c> and <c>SimulatorClient.CreateReplayAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateReplaySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>SimulatorClient.CreateReplay</c> and
        /// <c>SimulatorClient.CreateReplayAsync</c>.
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
        public lro::OperationsSettings CreateReplayOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SimulatorClient.ListReplayResults</c> and <c>SimulatorClient.ListReplayResultsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListReplayResultsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SimulatorSettings"/> object.</returns>
        public SimulatorSettings Clone() => new SimulatorSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SimulatorClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class SimulatorClientBuilder : gaxgrpc::ClientBuilderBase<SimulatorClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SimulatorSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SimulatorClientBuilder() : base(SimulatorClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SimulatorClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SimulatorClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SimulatorClient Build()
        {
            SimulatorClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SimulatorClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SimulatorClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SimulatorClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SimulatorClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SimulatorClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SimulatorClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SimulatorClient.ChannelPool;
    }

    /// <summary>Simulator client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Policy Simulator API service.
    /// 
    /// Policy Simulator is a collection of endpoints for creating, running, and
    /// viewing a [Replay][google.cloud.policysimulator.v1.Replay]. A
    /// [Replay][google.cloud.policysimulator.v1.Replay] is a type of simulation that
    /// lets you see how your principals' access to resources might change if you
    /// changed your IAM policy.
    /// 
    /// During a [Replay][google.cloud.policysimulator.v1.Replay], Policy Simulator
    /// re-evaluates, or replays, past access attempts under both the current policy
    /// and  your proposed policy, and compares those results to determine how your
    /// principals' access might change under the proposed policy.
    /// </remarks>
    public abstract partial class SimulatorClient
    {
        /// <summary>
        /// The default endpoint for the Simulator service, which is a host of "policysimulator.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "policysimulator.googleapis.com:443";

        /// <summary>The default Simulator scopes.</summary>
        /// <remarks>
        /// The default Simulator scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Simulator.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SimulatorClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="SimulatorClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SimulatorClient"/>.</returns>
        public static stt::Task<SimulatorClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SimulatorClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SimulatorClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="SimulatorClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SimulatorClient"/>.</returns>
        public static SimulatorClient Create() => new SimulatorClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SimulatorClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SimulatorSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SimulatorClient"/>.</returns>
        internal static SimulatorClient Create(grpccore::CallInvoker callInvoker, SimulatorSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Simulator.SimulatorClient grpcClient = new Simulator.SimulatorClient(callInvoker);
            return new SimulatorClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Simulator client</summary>
        public virtual Simulator.SimulatorClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the specified [Replay][google.cloud.policysimulator.v1.Replay]. Each
        /// `Replay` is available for at least 7 days.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Replay GetReplay(GetReplayRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the specified [Replay][google.cloud.policysimulator.v1.Replay]. Each
        /// `Replay` is available for at least 7 days.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Replay> GetReplayAsync(GetReplayRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the specified [Replay][google.cloud.policysimulator.v1.Replay]. Each
        /// `Replay` is available for at least 7 days.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Replay> GetReplayAsync(GetReplayRequest request, st::CancellationToken cancellationToken) =>
            GetReplayAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the specified [Replay][google.cloud.policysimulator.v1.Replay]. Each
        /// `Replay` is available for at least 7 days.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the [Replay][google.cloud.policysimulator.v1.Replay]
        /// to retrieve, in the following format:
        /// 
        /// `{projects|folders|organizations}/{resource-id}/locations/global/replays/{replay-id}`,
        /// where `{resource-id}` is the ID of the project, folder, or organization
        /// that owns the `Replay`.
        /// 
        /// Example:
        /// `projects/my-example-project/locations/global/replays/506a5f7f-38ce-4d7d-8e03-479ce1833c36`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Replay GetReplay(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetReplay(new GetReplayRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the specified [Replay][google.cloud.policysimulator.v1.Replay]. Each
        /// `Replay` is available for at least 7 days.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the [Replay][google.cloud.policysimulator.v1.Replay]
        /// to retrieve, in the following format:
        /// 
        /// `{projects|folders|organizations}/{resource-id}/locations/global/replays/{replay-id}`,
        /// where `{resource-id}` is the ID of the project, folder, or organization
        /// that owns the `Replay`.
        /// 
        /// Example:
        /// `projects/my-example-project/locations/global/replays/506a5f7f-38ce-4d7d-8e03-479ce1833c36`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Replay> GetReplayAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetReplayAsync(new GetReplayRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the specified [Replay][google.cloud.policysimulator.v1.Replay]. Each
        /// `Replay` is available for at least 7 days.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the [Replay][google.cloud.policysimulator.v1.Replay]
        /// to retrieve, in the following format:
        /// 
        /// `{projects|folders|organizations}/{resource-id}/locations/global/replays/{replay-id}`,
        /// where `{resource-id}` is the ID of the project, folder, or organization
        /// that owns the `Replay`.
        /// 
        /// Example:
        /// `projects/my-example-project/locations/global/replays/506a5f7f-38ce-4d7d-8e03-479ce1833c36`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Replay> GetReplayAsync(string name, st::CancellationToken cancellationToken) =>
            GetReplayAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the specified [Replay][google.cloud.policysimulator.v1.Replay]. Each
        /// `Replay` is available for at least 7 days.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the [Replay][google.cloud.policysimulator.v1.Replay]
        /// to retrieve, in the following format:
        /// 
        /// `{projects|folders|organizations}/{resource-id}/locations/global/replays/{replay-id}`,
        /// where `{resource-id}` is the ID of the project, folder, or organization
        /// that owns the `Replay`.
        /// 
        /// Example:
        /// `projects/my-example-project/locations/global/replays/506a5f7f-38ce-4d7d-8e03-479ce1833c36`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Replay GetReplay(ReplayName name, gaxgrpc::CallSettings callSettings = null) =>
            GetReplay(new GetReplayRequest
            {
                ReplayName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the specified [Replay][google.cloud.policysimulator.v1.Replay]. Each
        /// `Replay` is available for at least 7 days.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the [Replay][google.cloud.policysimulator.v1.Replay]
        /// to retrieve, in the following format:
        /// 
        /// `{projects|folders|organizations}/{resource-id}/locations/global/replays/{replay-id}`,
        /// where `{resource-id}` is the ID of the project, folder, or organization
        /// that owns the `Replay`.
        /// 
        /// Example:
        /// `projects/my-example-project/locations/global/replays/506a5f7f-38ce-4d7d-8e03-479ce1833c36`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Replay> GetReplayAsync(ReplayName name, gaxgrpc::CallSettings callSettings = null) =>
            GetReplayAsync(new GetReplayRequest
            {
                ReplayName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the specified [Replay][google.cloud.policysimulator.v1.Replay]. Each
        /// `Replay` is available for at least 7 days.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the [Replay][google.cloud.policysimulator.v1.Replay]
        /// to retrieve, in the following format:
        /// 
        /// `{projects|folders|organizations}/{resource-id}/locations/global/replays/{replay-id}`,
        /// where `{resource-id}` is the ID of the project, folder, or organization
        /// that owns the `Replay`.
        /// 
        /// Example:
        /// `projects/my-example-project/locations/global/replays/506a5f7f-38ce-4d7d-8e03-479ce1833c36`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Replay> GetReplayAsync(ReplayName name, st::CancellationToken cancellationToken) =>
            GetReplayAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates and starts a [Replay][google.cloud.policysimulator.v1.Replay] using
        /// the given [ReplayConfig][google.cloud.policysimulator.v1.ReplayConfig].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Replay, ReplayOperationMetadata> CreateReplay(CreateReplayRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates and starts a [Replay][google.cloud.policysimulator.v1.Replay] using
        /// the given [ReplayConfig][google.cloud.policysimulator.v1.ReplayConfig].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Replay, ReplayOperationMetadata>> CreateReplayAsync(CreateReplayRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates and starts a [Replay][google.cloud.policysimulator.v1.Replay] using
        /// the given [ReplayConfig][google.cloud.policysimulator.v1.ReplayConfig].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Replay, ReplayOperationMetadata>> CreateReplayAsync(CreateReplayRequest request, st::CancellationToken cancellationToken) =>
            CreateReplayAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateReplay</c>.</summary>
        public virtual lro::OperationsClient CreateReplayOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateReplay</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Replay, ReplayOperationMetadata> PollOnceCreateReplay(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Replay, ReplayOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateReplayOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateReplay</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Replay, ReplayOperationMetadata>> PollOnceCreateReplayAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Replay, ReplayOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateReplayOperationsClient, callSettings);

        /// <summary>
        /// Creates and starts a [Replay][google.cloud.policysimulator.v1.Replay] using
        /// the given [ReplayConfig][google.cloud.policysimulator.v1.ReplayConfig].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this
        /// [Replay][google.cloud.policysimulator.v1.Replay] will be created. This
        /// resource must be a project, folder, or organization with a location.
        /// 
        /// Example: `projects/my-example-project/locations/global`
        /// </param>
        /// <param name="replay">
        /// Required. The [Replay][google.cloud.policysimulator.v1.Replay] to create.
        /// Set `Replay.ReplayConfig` to configure the replay.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Replay, ReplayOperationMetadata> CreateReplay(string parent, Replay replay, gaxgrpc::CallSettings callSettings = null) =>
            CreateReplay(new CreateReplayRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Replay = gax::GaxPreconditions.CheckNotNull(replay, nameof(replay)),
            }, callSettings);

        /// <summary>
        /// Creates and starts a [Replay][google.cloud.policysimulator.v1.Replay] using
        /// the given [ReplayConfig][google.cloud.policysimulator.v1.ReplayConfig].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this
        /// [Replay][google.cloud.policysimulator.v1.Replay] will be created. This
        /// resource must be a project, folder, or organization with a location.
        /// 
        /// Example: `projects/my-example-project/locations/global`
        /// </param>
        /// <param name="replay">
        /// Required. The [Replay][google.cloud.policysimulator.v1.Replay] to create.
        /// Set `Replay.ReplayConfig` to configure the replay.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Replay, ReplayOperationMetadata>> CreateReplayAsync(string parent, Replay replay, gaxgrpc::CallSettings callSettings = null) =>
            CreateReplayAsync(new CreateReplayRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Replay = gax::GaxPreconditions.CheckNotNull(replay, nameof(replay)),
            }, callSettings);

        /// <summary>
        /// Creates and starts a [Replay][google.cloud.policysimulator.v1.Replay] using
        /// the given [ReplayConfig][google.cloud.policysimulator.v1.ReplayConfig].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this
        /// [Replay][google.cloud.policysimulator.v1.Replay] will be created. This
        /// resource must be a project, folder, or organization with a location.
        /// 
        /// Example: `projects/my-example-project/locations/global`
        /// </param>
        /// <param name="replay">
        /// Required. The [Replay][google.cloud.policysimulator.v1.Replay] to create.
        /// Set `Replay.ReplayConfig` to configure the replay.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Replay, ReplayOperationMetadata>> CreateReplayAsync(string parent, Replay replay, st::CancellationToken cancellationToken) =>
            CreateReplayAsync(parent, replay, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the results of running a
        /// [Replay][google.cloud.policysimulator.v1.Replay].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ReplayResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReplayResultsResponse, ReplayResult> ListReplayResults(ListReplayResultsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the results of running a
        /// [Replay][google.cloud.policysimulator.v1.Replay].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ReplayResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReplayResultsResponse, ReplayResult> ListReplayResultsAsync(ListReplayResultsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the results of running a
        /// [Replay][google.cloud.policysimulator.v1.Replay].
        /// </summary>
        /// <param name="parent">
        /// Required. The [Replay][google.cloud.policysimulator.v1.Replay] whose
        /// results are listed, in the following format:
        /// 
        /// `{projects|folders|organizations}/{resource-id}/locations/global/replays/{replay-id}`
        /// 
        /// Example:
        /// `projects/my-project/locations/global/replays/506a5f7f-38ce-4d7d-8e03-479ce1833c36`
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
        /// <returns>A pageable sequence of <see cref="ReplayResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReplayResultsResponse, ReplayResult> ListReplayResults(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReplayResultsRequest request = new ListReplayResultsRequest
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
            return ListReplayResults(request, callSettings);
        }

        /// <summary>
        /// Lists the results of running a
        /// [Replay][google.cloud.policysimulator.v1.Replay].
        /// </summary>
        /// <param name="parent">
        /// Required. The [Replay][google.cloud.policysimulator.v1.Replay] whose
        /// results are listed, in the following format:
        /// 
        /// `{projects|folders|organizations}/{resource-id}/locations/global/replays/{replay-id}`
        /// 
        /// Example:
        /// `projects/my-project/locations/global/replays/506a5f7f-38ce-4d7d-8e03-479ce1833c36`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ReplayResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReplayResultsResponse, ReplayResult> ListReplayResultsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReplayResultsRequest request = new ListReplayResultsRequest
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
            return ListReplayResultsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the results of running a
        /// [Replay][google.cloud.policysimulator.v1.Replay].
        /// </summary>
        /// <param name="parent">
        /// Required. The [Replay][google.cloud.policysimulator.v1.Replay] whose
        /// results are listed, in the following format:
        /// 
        /// `{projects|folders|organizations}/{resource-id}/locations/global/replays/{replay-id}`
        /// 
        /// Example:
        /// `projects/my-project/locations/global/replays/506a5f7f-38ce-4d7d-8e03-479ce1833c36`
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
        /// <returns>A pageable sequence of <see cref="ReplayResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReplayResultsResponse, ReplayResult> ListReplayResults(ReplayName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReplayResultsRequest request = new ListReplayResultsRequest
            {
                ParentAsReplayName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListReplayResults(request, callSettings);
        }

        /// <summary>
        /// Lists the results of running a
        /// [Replay][google.cloud.policysimulator.v1.Replay].
        /// </summary>
        /// <param name="parent">
        /// Required. The [Replay][google.cloud.policysimulator.v1.Replay] whose
        /// results are listed, in the following format:
        /// 
        /// `{projects|folders|organizations}/{resource-id}/locations/global/replays/{replay-id}`
        /// 
        /// Example:
        /// `projects/my-project/locations/global/replays/506a5f7f-38ce-4d7d-8e03-479ce1833c36`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ReplayResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReplayResultsResponse, ReplayResult> ListReplayResultsAsync(ReplayName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReplayResultsRequest request = new ListReplayResultsRequest
            {
                ParentAsReplayName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListReplayResultsAsync(request, callSettings);
        }
    }

    /// <summary>Simulator client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Policy Simulator API service.
    /// 
    /// Policy Simulator is a collection of endpoints for creating, running, and
    /// viewing a [Replay][google.cloud.policysimulator.v1.Replay]. A
    /// [Replay][google.cloud.policysimulator.v1.Replay] is a type of simulation that
    /// lets you see how your principals' access to resources might change if you
    /// changed your IAM policy.
    /// 
    /// During a [Replay][google.cloud.policysimulator.v1.Replay], Policy Simulator
    /// re-evaluates, or replays, past access attempts under both the current policy
    /// and  your proposed policy, and compares those results to determine how your
    /// principals' access might change under the proposed policy.
    /// </remarks>
    public sealed partial class SimulatorClientImpl : SimulatorClient
    {
        private readonly gaxgrpc::ApiCall<GetReplayRequest, Replay> _callGetReplay;

        private readonly gaxgrpc::ApiCall<CreateReplayRequest, lro::Operation> _callCreateReplay;

        private readonly gaxgrpc::ApiCall<ListReplayResultsRequest, ListReplayResultsResponse> _callListReplayResults;

        /// <summary>
        /// Constructs a client wrapper for the Simulator service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SimulatorSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SimulatorClientImpl(Simulator.SimulatorClient grpcClient, SimulatorSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SimulatorSettings effectiveSettings = settings ?? SimulatorSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateReplayOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateReplayOperationsSettings, logger);
            _callGetReplay = clientHelper.BuildApiCall<GetReplayRequest, Replay>("GetReplay", grpcClient.GetReplayAsync, grpcClient.GetReplay, effectiveSettings.GetReplaySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetReplay);
            Modify_GetReplayApiCall(ref _callGetReplay);
            _callCreateReplay = clientHelper.BuildApiCall<CreateReplayRequest, lro::Operation>("CreateReplay", grpcClient.CreateReplayAsync, grpcClient.CreateReplay, effectiveSettings.CreateReplaySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateReplay);
            Modify_CreateReplayApiCall(ref _callCreateReplay);
            _callListReplayResults = clientHelper.BuildApiCall<ListReplayResultsRequest, ListReplayResultsResponse>("ListReplayResults", grpcClient.ListReplayResultsAsync, grpcClient.ListReplayResults, effectiveSettings.ListReplayResultsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListReplayResults);
            Modify_ListReplayResultsApiCall(ref _callListReplayResults);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetReplayApiCall(ref gaxgrpc::ApiCall<GetReplayRequest, Replay> call);

        partial void Modify_CreateReplayApiCall(ref gaxgrpc::ApiCall<CreateReplayRequest, lro::Operation> call);

        partial void Modify_ListReplayResultsApiCall(ref gaxgrpc::ApiCall<ListReplayResultsRequest, ListReplayResultsResponse> call);

        partial void OnConstruction(Simulator.SimulatorClient grpcClient, SimulatorSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Simulator client</summary>
        public override Simulator.SimulatorClient GrpcClient { get; }

        partial void Modify_GetReplayRequest(ref GetReplayRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateReplayRequest(ref CreateReplayRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListReplayResultsRequest(ref ListReplayResultsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets the specified [Replay][google.cloud.policysimulator.v1.Replay]. Each
        /// `Replay` is available for at least 7 days.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Replay GetReplay(GetReplayRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReplayRequest(ref request, ref callSettings);
            return _callGetReplay.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the specified [Replay][google.cloud.policysimulator.v1.Replay]. Each
        /// `Replay` is available for at least 7 days.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Replay> GetReplayAsync(GetReplayRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReplayRequest(ref request, ref callSettings);
            return _callGetReplay.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateReplay</c>.</summary>
        public override lro::OperationsClient CreateReplayOperationsClient { get; }

        /// <summary>
        /// Creates and starts a [Replay][google.cloud.policysimulator.v1.Replay] using
        /// the given [ReplayConfig][google.cloud.policysimulator.v1.ReplayConfig].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Replay, ReplayOperationMetadata> CreateReplay(CreateReplayRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateReplayRequest(ref request, ref callSettings);
            return new lro::Operation<Replay, ReplayOperationMetadata>(_callCreateReplay.Sync(request, callSettings), CreateReplayOperationsClient);
        }

        /// <summary>
        /// Creates and starts a [Replay][google.cloud.policysimulator.v1.Replay] using
        /// the given [ReplayConfig][google.cloud.policysimulator.v1.ReplayConfig].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Replay, ReplayOperationMetadata>> CreateReplayAsync(CreateReplayRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateReplayRequest(ref request, ref callSettings);
            return new lro::Operation<Replay, ReplayOperationMetadata>(await _callCreateReplay.Async(request, callSettings).ConfigureAwait(false), CreateReplayOperationsClient);
        }

        /// <summary>
        /// Lists the results of running a
        /// [Replay][google.cloud.policysimulator.v1.Replay].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ReplayResult"/> resources.</returns>
        public override gax::PagedEnumerable<ListReplayResultsResponse, ReplayResult> ListReplayResults(ListReplayResultsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReplayResultsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListReplayResultsRequest, ListReplayResultsResponse, ReplayResult>(_callListReplayResults, request, callSettings);
        }

        /// <summary>
        /// Lists the results of running a
        /// [Replay][google.cloud.policysimulator.v1.Replay].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ReplayResult"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListReplayResultsResponse, ReplayResult> ListReplayResultsAsync(ListReplayResultsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReplayResultsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListReplayResultsRequest, ListReplayResultsResponse, ReplayResult>(_callListReplayResults, request, callSettings);
        }
    }

    public partial class ListReplayResultsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListReplayResultsResponse : gaxgrpc::IPageResponse<ReplayResult>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ReplayResult> GetEnumerator() => ReplayResults.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Simulator
    {
        public partial class SimulatorClient
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
