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
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.AIPlatform.V1Beta1
{
    /// <summary>Settings for <see cref="MemoryBankServiceClient"/> instances.</summary>
    public sealed partial class MemoryBankServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="MemoryBankServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="MemoryBankServiceSettings"/>.</returns>
        public static MemoryBankServiceSettings GetDefault() => new MemoryBankServiceSettings();

        /// <summary>Constructs a new <see cref="MemoryBankServiceSettings"/> object with default settings.</summary>
        public MemoryBankServiceSettings()
        {
        }

        private MemoryBankServiceSettings(MemoryBankServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateMemorySettings = existing.CreateMemorySettings;
            CreateMemoryOperationsSettings = existing.CreateMemoryOperationsSettings.Clone();
            GetMemorySettings = existing.GetMemorySettings;
            UpdateMemorySettings = existing.UpdateMemorySettings;
            UpdateMemoryOperationsSettings = existing.UpdateMemoryOperationsSettings.Clone();
            ListMemoriesSettings = existing.ListMemoriesSettings;
            DeleteMemorySettings = existing.DeleteMemorySettings;
            DeleteMemoryOperationsSettings = existing.DeleteMemoryOperationsSettings.Clone();
            GenerateMemoriesSettings = existing.GenerateMemoriesSettings;
            GenerateMemoriesOperationsSettings = existing.GenerateMemoriesOperationsSettings.Clone();
            RetrieveMemoriesSettings = existing.RetrieveMemoriesSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(MemoryBankServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemoryBankServiceClient.CreateMemory</c> and <c>MemoryBankServiceClient.CreateMemoryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateMemorySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>MemoryBankServiceClient.CreateMemory</c> and
        /// <c>MemoryBankServiceClient.CreateMemoryAsync</c>.
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
        public lro::OperationsSettings CreateMemoryOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemoryBankServiceClient.GetMemory</c> and <c>MemoryBankServiceClient.GetMemoryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetMemorySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemoryBankServiceClient.UpdateMemory</c> and <c>MemoryBankServiceClient.UpdateMemoryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateMemorySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>MemoryBankServiceClient.UpdateMemory</c> and
        /// <c>MemoryBankServiceClient.UpdateMemoryAsync</c>.
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
        public lro::OperationsSettings UpdateMemoryOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemoryBankServiceClient.ListMemories</c> and <c>MemoryBankServiceClient.ListMemoriesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListMemoriesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemoryBankServiceClient.DeleteMemory</c> and <c>MemoryBankServiceClient.DeleteMemoryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteMemorySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>MemoryBankServiceClient.DeleteMemory</c> and
        /// <c>MemoryBankServiceClient.DeleteMemoryAsync</c>.
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
        public lro::OperationsSettings DeleteMemoryOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemoryBankServiceClient.GenerateMemories</c> and <c>MemoryBankServiceClient.GenerateMemoriesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GenerateMemoriesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>MemoryBankServiceClient.GenerateMemories</c> and
        /// <c>MemoryBankServiceClient.GenerateMemoriesAsync</c>.
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
        public lro::OperationsSettings GenerateMemoriesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemoryBankServiceClient.RetrieveMemories</c> and <c>MemoryBankServiceClient.RetrieveMemoriesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RetrieveMemoriesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="MemoryBankServiceSettings"/> object.</returns>
        public MemoryBankServiceSettings Clone() => new MemoryBankServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="MemoryBankServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class MemoryBankServiceClientBuilder : gaxgrpc::ClientBuilderBase<MemoryBankServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public MemoryBankServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public MemoryBankServiceClientBuilder() : base(MemoryBankServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref MemoryBankServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<MemoryBankServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override MemoryBankServiceClient Build()
        {
            MemoryBankServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<MemoryBankServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<MemoryBankServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private MemoryBankServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return MemoryBankServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<MemoryBankServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return MemoryBankServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => MemoryBankServiceClient.ChannelPool;
    }

    /// <summary>MemoryBankService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service for managing memories for LLM applications.
    /// </remarks>
    public abstract partial class MemoryBankServiceClient
    {
        /// <summary>
        /// The default endpoint for the MemoryBankService service, which is a host of "aiplatform.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "aiplatform.googleapis.com:443";

        /// <summary>The default MemoryBankService scopes.</summary>
        /// <remarks>
        /// The default MemoryBankService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(MemoryBankService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="MemoryBankServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="MemoryBankServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="MemoryBankServiceClient"/>.</returns>
        public static stt::Task<MemoryBankServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new MemoryBankServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="MemoryBankServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="MemoryBankServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="MemoryBankServiceClient"/>.</returns>
        public static MemoryBankServiceClient Create() => new MemoryBankServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="MemoryBankServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="MemoryBankServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="MemoryBankServiceClient"/>.</returns>
        internal static MemoryBankServiceClient Create(grpccore::CallInvoker callInvoker, MemoryBankServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            MemoryBankService.MemoryBankServiceClient grpcClient = new MemoryBankService.MemoryBankServiceClient(callInvoker);
            return new MemoryBankServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC MemoryBankService client</summary>
        public virtual MemoryBankService.MemoryBankServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Create a Memory.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Memory, CreateMemoryOperationMetadata> CreateMemory(CreateMemoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a Memory.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Memory, CreateMemoryOperationMetadata>> CreateMemoryAsync(CreateMemoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a Memory.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Memory, CreateMemoryOperationMetadata>> CreateMemoryAsync(CreateMemoryRequest request, st::CancellationToken cancellationToken) =>
            CreateMemoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateMemory</c>.</summary>
        public virtual lro::OperationsClient CreateMemoryOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateMemory</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Memory, CreateMemoryOperationMetadata> PollOnceCreateMemory(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Memory, CreateMemoryOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateMemoryOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateMemory</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Memory, CreateMemoryOperationMetadata>> PollOnceCreateMemoryAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Memory, CreateMemoryOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateMemoryOperationsClient, callSettings);

        /// <summary>
        /// Get a Memory.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Memory GetMemory(GetMemoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a Memory.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Memory> GetMemoryAsync(GetMemoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a Memory.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Memory> GetMemoryAsync(GetMemoryRequest request, st::CancellationToken cancellationToken) =>
            GetMemoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a Memory.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Memory.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/memories/{memory}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Memory GetMemory(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMemory(new GetMemoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a Memory.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Memory.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/memories/{memory}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Memory> GetMemoryAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMemoryAsync(new GetMemoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a Memory.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Memory.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/memories/{memory}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Memory> GetMemoryAsync(string name, st::CancellationToken cancellationToken) =>
            GetMemoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a Memory.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Memory.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/memories/{memory}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Memory GetMemory(MemoryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMemory(new GetMemoryRequest
            {
                MemoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a Memory.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Memory.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/memories/{memory}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Memory> GetMemoryAsync(MemoryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMemoryAsync(new GetMemoryRequest
            {
                MemoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a Memory.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Memory.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/memories/{memory}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Memory> GetMemoryAsync(MemoryName name, st::CancellationToken cancellationToken) =>
            GetMemoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a Memory.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Memory, UpdateMemoryOperationMetadata> UpdateMemory(UpdateMemoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a Memory.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Memory, UpdateMemoryOperationMetadata>> UpdateMemoryAsync(UpdateMemoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a Memory.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Memory, UpdateMemoryOperationMetadata>> UpdateMemoryAsync(UpdateMemoryRequest request, st::CancellationToken cancellationToken) =>
            UpdateMemoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateMemory</c>.</summary>
        public virtual lro::OperationsClient UpdateMemoryOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateMemory</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Memory, UpdateMemoryOperationMetadata> PollOnceUpdateMemory(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Memory, UpdateMemoryOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateMemoryOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateMemory</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Memory, UpdateMemoryOperationMetadata>> PollOnceUpdateMemoryAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Memory, UpdateMemoryOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateMemoryOperationsClient, callSettings);

        /// <summary>
        /// Update a Memory.
        /// </summary>
        /// <param name="memory">
        /// Required. The Memory which replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Mask specifying which fields to update.
        /// Supported fields:
        /// 
        /// * `display_name`
        /// * `description`
        /// * `fact`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Memory, UpdateMemoryOperationMetadata> UpdateMemory(Memory memory, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMemory(new UpdateMemoryRequest
            {
                Memory = gax::GaxPreconditions.CheckNotNull(memory, nameof(memory)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a Memory.
        /// </summary>
        /// <param name="memory">
        /// Required. The Memory which replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Mask specifying which fields to update.
        /// Supported fields:
        /// 
        /// * `display_name`
        /// * `description`
        /// * `fact`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Memory, UpdateMemoryOperationMetadata>> UpdateMemoryAsync(Memory memory, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMemoryAsync(new UpdateMemoryRequest
            {
                Memory = gax::GaxPreconditions.CheckNotNull(memory, nameof(memory)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a Memory.
        /// </summary>
        /// <param name="memory">
        /// Required. The Memory which replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Mask specifying which fields to update.
        /// Supported fields:
        /// 
        /// * `display_name`
        /// * `description`
        /// * `fact`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Memory, UpdateMemoryOperationMetadata>> UpdateMemoryAsync(Memory memory, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateMemoryAsync(memory, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List Memories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Memory"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMemoriesResponse, Memory> ListMemories(ListMemoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List Memories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Memory"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMemoriesResponse, Memory> ListMemoriesAsync(ListMemoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List Memories.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ReasoningEngine to list the Memories
        /// under. Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}`
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
        /// <returns>A pageable sequence of <see cref="Memory"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMemoriesResponse, Memory> ListMemories(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMemoriesRequest request = new ListMemoriesRequest
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
            return ListMemories(request, callSettings);
        }

        /// <summary>
        /// List Memories.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ReasoningEngine to list the Memories
        /// under. Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Memory"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMemoriesResponse, Memory> ListMemoriesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMemoriesRequest request = new ListMemoriesRequest
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
            return ListMemoriesAsync(request, callSettings);
        }

        /// <summary>
        /// List Memories.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ReasoningEngine to list the Memories
        /// under. Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}`
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
        /// <returns>A pageable sequence of <see cref="Memory"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMemoriesResponse, Memory> ListMemories(ReasoningEngineName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMemoriesRequest request = new ListMemoriesRequest
            {
                ParentAsReasoningEngineName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMemories(request, callSettings);
        }

        /// <summary>
        /// List Memories.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ReasoningEngine to list the Memories
        /// under. Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Memory"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMemoriesResponse, Memory> ListMemoriesAsync(ReasoningEngineName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMemoriesRequest request = new ListMemoriesRequest
            {
                ParentAsReasoningEngineName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMemoriesAsync(request, callSettings);
        }

        /// <summary>
        /// Delete a Memory.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteMemoryOperationMetadata> DeleteMemory(DeleteMemoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a Memory.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteMemoryOperationMetadata>> DeleteMemoryAsync(DeleteMemoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a Memory.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteMemoryOperationMetadata>> DeleteMemoryAsync(DeleteMemoryRequest request, st::CancellationToken cancellationToken) =>
            DeleteMemoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteMemory</c>.</summary>
        public virtual lro::OperationsClient DeleteMemoryOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteMemory</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteMemoryOperationMetadata> PollOnceDeleteMemory(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteMemoryOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteMemoryOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteMemory</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteMemoryOperationMetadata>> PollOnceDeleteMemoryAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteMemoryOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteMemoryOperationsClient, callSettings);

        /// <summary>
        /// Delete a Memory.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Memory to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/memories/{memory}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteMemoryOperationMetadata> DeleteMemory(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMemory(new DeleteMemoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a Memory.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Memory to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/memories/{memory}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteMemoryOperationMetadata>> DeleteMemoryAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMemoryAsync(new DeleteMemoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a Memory.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Memory to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/memories/{memory}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteMemoryOperationMetadata>> DeleteMemoryAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteMemoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a Memory.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Memory to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/memories/{memory}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteMemoryOperationMetadata> DeleteMemory(MemoryName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMemory(new DeleteMemoryRequest
            {
                MemoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a Memory.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Memory to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/memories/{memory}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteMemoryOperationMetadata>> DeleteMemoryAsync(MemoryName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMemoryAsync(new DeleteMemoryRequest
            {
                MemoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a Memory.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Memory to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/memories/{memory}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteMemoryOperationMetadata>> DeleteMemoryAsync(MemoryName name, st::CancellationToken cancellationToken) =>
            DeleteMemoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generate memories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GenerateMemoriesResponse, GenerateMemoriesOperationMetadata> GenerateMemories(GenerateMemoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generate memories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GenerateMemoriesResponse, GenerateMemoriesOperationMetadata>> GenerateMemoriesAsync(GenerateMemoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generate memories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GenerateMemoriesResponse, GenerateMemoriesOperationMetadata>> GenerateMemoriesAsync(GenerateMemoriesRequest request, st::CancellationToken cancellationToken) =>
            GenerateMemoriesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>GenerateMemories</c>.</summary>
        public virtual lro::OperationsClient GenerateMemoriesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>GenerateMemories</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<GenerateMemoriesResponse, GenerateMemoriesOperationMetadata> PollOnceGenerateMemories(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GenerateMemoriesResponse, GenerateMemoriesOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), GenerateMemoriesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>GenerateMemories</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<GenerateMemoriesResponse, GenerateMemoriesOperationMetadata>> PollOnceGenerateMemoriesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GenerateMemoriesResponse, GenerateMemoriesOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), GenerateMemoriesOperationsClient, callSettings);

        /// <summary>
        /// Generate memories.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ReasoningEngine to generate memories
        /// for. Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GenerateMemoriesResponse, GenerateMemoriesOperationMetadata> GenerateMemories(string parent, gaxgrpc::CallSettings callSettings = null) =>
            GenerateMemories(new GenerateMemoriesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Generate memories.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ReasoningEngine to generate memories
        /// for. Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GenerateMemoriesResponse, GenerateMemoriesOperationMetadata>> GenerateMemoriesAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            GenerateMemoriesAsync(new GenerateMemoriesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Generate memories.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ReasoningEngine to generate memories
        /// for. Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GenerateMemoriesResponse, GenerateMemoriesOperationMetadata>> GenerateMemoriesAsync(string parent, st::CancellationToken cancellationToken) =>
            GenerateMemoriesAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generate memories.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ReasoningEngine to generate memories
        /// for. Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GenerateMemoriesResponse, GenerateMemoriesOperationMetadata> GenerateMemories(ReasoningEngineName parent, gaxgrpc::CallSettings callSettings = null) =>
            GenerateMemories(new GenerateMemoriesRequest
            {
                ParentAsReasoningEngineName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Generate memories.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ReasoningEngine to generate memories
        /// for. Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GenerateMemoriesResponse, GenerateMemoriesOperationMetadata>> GenerateMemoriesAsync(ReasoningEngineName parent, gaxgrpc::CallSettings callSettings = null) =>
            GenerateMemoriesAsync(new GenerateMemoriesRequest
            {
                ParentAsReasoningEngineName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Generate memories.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ReasoningEngine to generate memories
        /// for. Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GenerateMemoriesResponse, GenerateMemoriesOperationMetadata>> GenerateMemoriesAsync(ReasoningEngineName parent, st::CancellationToken cancellationToken) =>
            GenerateMemoriesAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve memories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RetrieveMemoriesResponse RetrieveMemories(RetrieveMemoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve memories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetrieveMemoriesResponse> RetrieveMemoriesAsync(RetrieveMemoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve memories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetrieveMemoriesResponse> RetrieveMemoriesAsync(RetrieveMemoriesRequest request, st::CancellationToken cancellationToken) =>
            RetrieveMemoriesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve memories.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ReasoningEngine to retrieve memories
        /// from. Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RetrieveMemoriesResponse RetrieveMemories(string parent, gaxgrpc::CallSettings callSettings = null) =>
            RetrieveMemories(new RetrieveMemoriesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Retrieve memories.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ReasoningEngine to retrieve memories
        /// from. Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetrieveMemoriesResponse> RetrieveMemoriesAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            RetrieveMemoriesAsync(new RetrieveMemoriesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Retrieve memories.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ReasoningEngine to retrieve memories
        /// from. Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetrieveMemoriesResponse> RetrieveMemoriesAsync(string parent, st::CancellationToken cancellationToken) =>
            RetrieveMemoriesAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve memories.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ReasoningEngine to retrieve memories
        /// from. Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RetrieveMemoriesResponse RetrieveMemories(ReasoningEngineName parent, gaxgrpc::CallSettings callSettings = null) =>
            RetrieveMemories(new RetrieveMemoriesRequest
            {
                ParentAsReasoningEngineName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Retrieve memories.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ReasoningEngine to retrieve memories
        /// from. Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetrieveMemoriesResponse> RetrieveMemoriesAsync(ReasoningEngineName parent, gaxgrpc::CallSettings callSettings = null) =>
            RetrieveMemoriesAsync(new RetrieveMemoriesRequest
            {
                ParentAsReasoningEngineName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Retrieve memories.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ReasoningEngine to retrieve memories
        /// from. Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetrieveMemoriesResponse> RetrieveMemoriesAsync(ReasoningEngineName parent, st::CancellationToken cancellationToken) =>
            RetrieveMemoriesAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>MemoryBankService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service for managing memories for LLM applications.
    /// </remarks>
    public sealed partial class MemoryBankServiceClientImpl : MemoryBankServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateMemoryRequest, lro::Operation> _callCreateMemory;

        private readonly gaxgrpc::ApiCall<GetMemoryRequest, Memory> _callGetMemory;

        private readonly gaxgrpc::ApiCall<UpdateMemoryRequest, lro::Operation> _callUpdateMemory;

        private readonly gaxgrpc::ApiCall<ListMemoriesRequest, ListMemoriesResponse> _callListMemories;

        private readonly gaxgrpc::ApiCall<DeleteMemoryRequest, lro::Operation> _callDeleteMemory;

        private readonly gaxgrpc::ApiCall<GenerateMemoriesRequest, lro::Operation> _callGenerateMemories;

        private readonly gaxgrpc::ApiCall<RetrieveMemoriesRequest, RetrieveMemoriesResponse> _callRetrieveMemories;

        /// <summary>
        /// Constructs a client wrapper for the MemoryBankService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="MemoryBankServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public MemoryBankServiceClientImpl(MemoryBankService.MemoryBankServiceClient grpcClient, MemoryBankServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            MemoryBankServiceSettings effectiveSettings = settings ?? MemoryBankServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateMemoryOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateMemoryOperationsSettings, logger);
            UpdateMemoryOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateMemoryOperationsSettings, logger);
            DeleteMemoryOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteMemoryOperationsSettings, logger);
            GenerateMemoriesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.GenerateMemoriesOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreateMemory = clientHelper.BuildApiCall<CreateMemoryRequest, lro::Operation>("CreateMemory", grpcClient.CreateMemoryAsync, grpcClient.CreateMemory, effectiveSettings.CreateMemorySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateMemory);
            Modify_CreateMemoryApiCall(ref _callCreateMemory);
            _callGetMemory = clientHelper.BuildApiCall<GetMemoryRequest, Memory>("GetMemory", grpcClient.GetMemoryAsync, grpcClient.GetMemory, effectiveSettings.GetMemorySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMemory);
            Modify_GetMemoryApiCall(ref _callGetMemory);
            _callUpdateMemory = clientHelper.BuildApiCall<UpdateMemoryRequest, lro::Operation>("UpdateMemory", grpcClient.UpdateMemoryAsync, grpcClient.UpdateMemory, effectiveSettings.UpdateMemorySettings).WithGoogleRequestParam("memory.name", request => request.Memory?.Name);
            Modify_ApiCall(ref _callUpdateMemory);
            Modify_UpdateMemoryApiCall(ref _callUpdateMemory);
            _callListMemories = clientHelper.BuildApiCall<ListMemoriesRequest, ListMemoriesResponse>("ListMemories", grpcClient.ListMemoriesAsync, grpcClient.ListMemories, effectiveSettings.ListMemoriesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListMemories);
            Modify_ListMemoriesApiCall(ref _callListMemories);
            _callDeleteMemory = clientHelper.BuildApiCall<DeleteMemoryRequest, lro::Operation>("DeleteMemory", grpcClient.DeleteMemoryAsync, grpcClient.DeleteMemory, effectiveSettings.DeleteMemorySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteMemory);
            Modify_DeleteMemoryApiCall(ref _callDeleteMemory);
            _callGenerateMemories = clientHelper.BuildApiCall<GenerateMemoriesRequest, lro::Operation>("GenerateMemories", grpcClient.GenerateMemoriesAsync, grpcClient.GenerateMemories, effectiveSettings.GenerateMemoriesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callGenerateMemories);
            Modify_GenerateMemoriesApiCall(ref _callGenerateMemories);
            _callRetrieveMemories = clientHelper.BuildApiCall<RetrieveMemoriesRequest, RetrieveMemoriesResponse>("RetrieveMemories", grpcClient.RetrieveMemoriesAsync, grpcClient.RetrieveMemories, effectiveSettings.RetrieveMemoriesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callRetrieveMemories);
            Modify_RetrieveMemoriesApiCall(ref _callRetrieveMemories);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateMemoryApiCall(ref gaxgrpc::ApiCall<CreateMemoryRequest, lro::Operation> call);

        partial void Modify_GetMemoryApiCall(ref gaxgrpc::ApiCall<GetMemoryRequest, Memory> call);

        partial void Modify_UpdateMemoryApiCall(ref gaxgrpc::ApiCall<UpdateMemoryRequest, lro::Operation> call);

        partial void Modify_ListMemoriesApiCall(ref gaxgrpc::ApiCall<ListMemoriesRequest, ListMemoriesResponse> call);

        partial void Modify_DeleteMemoryApiCall(ref gaxgrpc::ApiCall<DeleteMemoryRequest, lro::Operation> call);

        partial void Modify_GenerateMemoriesApiCall(ref gaxgrpc::ApiCall<GenerateMemoriesRequest, lro::Operation> call);

        partial void Modify_RetrieveMemoriesApiCall(ref gaxgrpc::ApiCall<RetrieveMemoriesRequest, RetrieveMemoriesResponse> call);

        partial void OnConstruction(MemoryBankService.MemoryBankServiceClient grpcClient, MemoryBankServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC MemoryBankService client</summary>
        public override MemoryBankService.MemoryBankServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateMemoryRequest(ref CreateMemoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetMemoryRequest(ref GetMemoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateMemoryRequest(ref UpdateMemoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListMemoriesRequest(ref ListMemoriesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteMemoryRequest(ref DeleteMemoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateMemoriesRequest(ref GenerateMemoriesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RetrieveMemoriesRequest(ref RetrieveMemoriesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateMemory</c>.</summary>
        public override lro::OperationsClient CreateMemoryOperationsClient { get; }

        /// <summary>
        /// Create a Memory.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Memory, CreateMemoryOperationMetadata> CreateMemory(CreateMemoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMemoryRequest(ref request, ref callSettings);
            return new lro::Operation<Memory, CreateMemoryOperationMetadata>(_callCreateMemory.Sync(request, callSettings), CreateMemoryOperationsClient);
        }

        /// <summary>
        /// Create a Memory.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Memory, CreateMemoryOperationMetadata>> CreateMemoryAsync(CreateMemoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMemoryRequest(ref request, ref callSettings);
            return new lro::Operation<Memory, CreateMemoryOperationMetadata>(await _callCreateMemory.Async(request, callSettings).ConfigureAwait(false), CreateMemoryOperationsClient);
        }

        /// <summary>
        /// Get a Memory.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Memory GetMemory(GetMemoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMemoryRequest(ref request, ref callSettings);
            return _callGetMemory.Sync(request, callSettings);
        }

        /// <summary>
        /// Get a Memory.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Memory> GetMemoryAsync(GetMemoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMemoryRequest(ref request, ref callSettings);
            return _callGetMemory.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateMemory</c>.</summary>
        public override lro::OperationsClient UpdateMemoryOperationsClient { get; }

        /// <summary>
        /// Update a Memory.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Memory, UpdateMemoryOperationMetadata> UpdateMemory(UpdateMemoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMemoryRequest(ref request, ref callSettings);
            return new lro::Operation<Memory, UpdateMemoryOperationMetadata>(_callUpdateMemory.Sync(request, callSettings), UpdateMemoryOperationsClient);
        }

        /// <summary>
        /// Update a Memory.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Memory, UpdateMemoryOperationMetadata>> UpdateMemoryAsync(UpdateMemoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMemoryRequest(ref request, ref callSettings);
            return new lro::Operation<Memory, UpdateMemoryOperationMetadata>(await _callUpdateMemory.Async(request, callSettings).ConfigureAwait(false), UpdateMemoryOperationsClient);
        }

        /// <summary>
        /// List Memories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Memory"/> resources.</returns>
        public override gax::PagedEnumerable<ListMemoriesResponse, Memory> ListMemories(ListMemoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMemoriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMemoriesRequest, ListMemoriesResponse, Memory>(_callListMemories, request, callSettings);
        }

        /// <summary>
        /// List Memories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Memory"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListMemoriesResponse, Memory> ListMemoriesAsync(ListMemoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMemoriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMemoriesRequest, ListMemoriesResponse, Memory>(_callListMemories, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteMemory</c>.</summary>
        public override lro::OperationsClient DeleteMemoryOperationsClient { get; }

        /// <summary>
        /// Delete a Memory.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteMemoryOperationMetadata> DeleteMemory(DeleteMemoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMemoryRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteMemoryOperationMetadata>(_callDeleteMemory.Sync(request, callSettings), DeleteMemoryOperationsClient);
        }

        /// <summary>
        /// Delete a Memory.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteMemoryOperationMetadata>> DeleteMemoryAsync(DeleteMemoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMemoryRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteMemoryOperationMetadata>(await _callDeleteMemory.Async(request, callSettings).ConfigureAwait(false), DeleteMemoryOperationsClient);
        }

        /// <summary>The long-running operations client for <c>GenerateMemories</c>.</summary>
        public override lro::OperationsClient GenerateMemoriesOperationsClient { get; }

        /// <summary>
        /// Generate memories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<GenerateMemoriesResponse, GenerateMemoriesOperationMetadata> GenerateMemories(GenerateMemoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateMemoriesRequest(ref request, ref callSettings);
            return new lro::Operation<GenerateMemoriesResponse, GenerateMemoriesOperationMetadata>(_callGenerateMemories.Sync(request, callSettings), GenerateMemoriesOperationsClient);
        }

        /// <summary>
        /// Generate memories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<GenerateMemoriesResponse, GenerateMemoriesOperationMetadata>> GenerateMemoriesAsync(GenerateMemoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateMemoriesRequest(ref request, ref callSettings);
            return new lro::Operation<GenerateMemoriesResponse, GenerateMemoriesOperationMetadata>(await _callGenerateMemories.Async(request, callSettings).ConfigureAwait(false), GenerateMemoriesOperationsClient);
        }

        /// <summary>
        /// Retrieve memories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RetrieveMemoriesResponse RetrieveMemories(RetrieveMemoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RetrieveMemoriesRequest(ref request, ref callSettings);
            return _callRetrieveMemories.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieve memories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RetrieveMemoriesResponse> RetrieveMemoriesAsync(RetrieveMemoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RetrieveMemoriesRequest(ref request, ref callSettings);
            return _callRetrieveMemories.Async(request, callSettings);
        }
    }

    public partial class ListMemoriesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMemoriesResponse : gaxgrpc::IPageResponse<Memory>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Memory> GetEnumerator() => Memories.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class MemoryBankService
    {
        public partial class MemoryBankServiceClient
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

    public static partial class MemoryBankService
    {
        public partial class MemoryBankServiceClient
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
