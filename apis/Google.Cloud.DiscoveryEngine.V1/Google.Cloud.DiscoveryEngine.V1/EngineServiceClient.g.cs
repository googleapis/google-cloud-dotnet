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

namespace Google.Cloud.DiscoveryEngine.V1
{
    /// <summary>Settings for <see cref="EngineServiceClient"/> instances.</summary>
    public sealed partial class EngineServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="EngineServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="EngineServiceSettings"/>.</returns>
        public static EngineServiceSettings GetDefault() => new EngineServiceSettings();

        /// <summary>Constructs a new <see cref="EngineServiceSettings"/> object with default settings.</summary>
        public EngineServiceSettings()
        {
        }

        private EngineServiceSettings(EngineServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateEngineSettings = existing.CreateEngineSettings;
            CreateEngineOperationsSettings = existing.CreateEngineOperationsSettings.Clone();
            DeleteEngineSettings = existing.DeleteEngineSettings;
            DeleteEngineOperationsSettings = existing.DeleteEngineOperationsSettings.Clone();
            UpdateEngineSettings = existing.UpdateEngineSettings;
            GetEngineSettings = existing.GetEngineSettings;
            ListEnginesSettings = existing.ListEnginesSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(EngineServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EngineServiceClient.CreateEngine</c> and <c>EngineServiceClient.CreateEngineAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateEngineSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>EngineServiceClient.CreateEngine</c> and
        /// <c>EngineServiceClient.CreateEngineAsync</c>.
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
        public lro::OperationsSettings CreateEngineOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EngineServiceClient.DeleteEngine</c> and <c>EngineServiceClient.DeleteEngineAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteEngineSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>EngineServiceClient.DeleteEngine</c> and
        /// <c>EngineServiceClient.DeleteEngineAsync</c>.
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
        public lro::OperationsSettings DeleteEngineOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EngineServiceClient.UpdateEngine</c> and <c>EngineServiceClient.UpdateEngineAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateEngineSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EngineServiceClient.GetEngine</c> and <c>EngineServiceClient.GetEngineAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEngineSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EngineServiceClient.ListEngines</c> and <c>EngineServiceClient.ListEnginesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEnginesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="EngineServiceSettings"/> object.</returns>
        public EngineServiceSettings Clone() => new EngineServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="EngineServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class EngineServiceClientBuilder : gaxgrpc::ClientBuilderBase<EngineServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public EngineServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public EngineServiceClientBuilder() : base(EngineServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref EngineServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<EngineServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override EngineServiceClient Build()
        {
            EngineServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<EngineServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<EngineServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private EngineServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return EngineServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<EngineServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return EngineServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => EngineServiceClient.ChannelPool;
    }

    /// <summary>EngineService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [Engine][google.cloud.discoveryengine.v1.Engine]
    /// configuration.
    /// </remarks>
    public abstract partial class EngineServiceClient
    {
        /// <summary>
        /// The default endpoint for the EngineService service, which is a host of "discoveryengine.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "discoveryengine.googleapis.com:443";

        /// <summary>The default EngineService scopes.</summary>
        /// <remarks>
        /// The default EngineService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(EngineService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="EngineServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="EngineServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="EngineServiceClient"/>.</returns>
        public static stt::Task<EngineServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new EngineServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="EngineServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="EngineServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="EngineServiceClient"/>.</returns>
        public static EngineServiceClient Create() => new EngineServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="EngineServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="EngineServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="EngineServiceClient"/>.</returns>
        internal static EngineServiceClient Create(grpccore::CallInvoker callInvoker, EngineServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            EngineService.EngineServiceClient grpcClient = new EngineService.EngineServiceClient(callInvoker);
            return new EngineServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC EngineService client</summary>
        public virtual EngineService.EngineServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [Engine][google.cloud.discoveryengine.v1.Engine].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Engine, CreateEngineMetadata> CreateEngine(CreateEngineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [Engine][google.cloud.discoveryengine.v1.Engine].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Engine, CreateEngineMetadata>> CreateEngineAsync(CreateEngineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [Engine][google.cloud.discoveryengine.v1.Engine].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Engine, CreateEngineMetadata>> CreateEngineAsync(CreateEngineRequest request, st::CancellationToken cancellationToken) =>
            CreateEngineAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateEngine</c>.</summary>
        public virtual lro::OperationsClient CreateEngineOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateEngine</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Engine, CreateEngineMetadata> PollOnceCreateEngine(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Engine, CreateEngineMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateEngineOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateEngine</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Engine, CreateEngineMetadata>> PollOnceCreateEngineAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Engine, CreateEngineMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateEngineOperationsClient, callSettings);

        /// <summary>
        /// Creates a [Engine][google.cloud.discoveryengine.v1.Engine].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, such as
        /// `projects/{project}/locations/{location}/collections/{collection}`.
        /// </param>
        /// <param name="engine">
        /// Required. The [Engine][google.cloud.discoveryengine.v1.Engine] to create.
        /// </param>
        /// <param name="engineId">
        /// Required. The ID to use for the
        /// [Engine][google.cloud.discoveryengine.v1.Engine], which will become the
        /// final component of the [Engine][google.cloud.discoveryengine.v1.Engine]'s
        /// resource name.
        /// 
        /// This field must conform to [RFC-1034](https://tools.ietf.org/html/rfc1034)
        /// standard with a length limit of 63 characters. Otherwise, an
        /// INVALID_ARGUMENT error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Engine, CreateEngineMetadata> CreateEngine(string parent, Engine engine, string engineId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEngine(new CreateEngineRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Engine = gax::GaxPreconditions.CheckNotNull(engine, nameof(engine)),
                EngineId = gax::GaxPreconditions.CheckNotNullOrEmpty(engineId, nameof(engineId)),
            }, callSettings);

        /// <summary>
        /// Creates a [Engine][google.cloud.discoveryengine.v1.Engine].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, such as
        /// `projects/{project}/locations/{location}/collections/{collection}`.
        /// </param>
        /// <param name="engine">
        /// Required. The [Engine][google.cloud.discoveryengine.v1.Engine] to create.
        /// </param>
        /// <param name="engineId">
        /// Required. The ID to use for the
        /// [Engine][google.cloud.discoveryengine.v1.Engine], which will become the
        /// final component of the [Engine][google.cloud.discoveryengine.v1.Engine]'s
        /// resource name.
        /// 
        /// This field must conform to [RFC-1034](https://tools.ietf.org/html/rfc1034)
        /// standard with a length limit of 63 characters. Otherwise, an
        /// INVALID_ARGUMENT error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Engine, CreateEngineMetadata>> CreateEngineAsync(string parent, Engine engine, string engineId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEngineAsync(new CreateEngineRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Engine = gax::GaxPreconditions.CheckNotNull(engine, nameof(engine)),
                EngineId = gax::GaxPreconditions.CheckNotNullOrEmpty(engineId, nameof(engineId)),
            }, callSettings);

        /// <summary>
        /// Creates a [Engine][google.cloud.discoveryengine.v1.Engine].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, such as
        /// `projects/{project}/locations/{location}/collections/{collection}`.
        /// </param>
        /// <param name="engine">
        /// Required. The [Engine][google.cloud.discoveryengine.v1.Engine] to create.
        /// </param>
        /// <param name="engineId">
        /// Required. The ID to use for the
        /// [Engine][google.cloud.discoveryengine.v1.Engine], which will become the
        /// final component of the [Engine][google.cloud.discoveryengine.v1.Engine]'s
        /// resource name.
        /// 
        /// This field must conform to [RFC-1034](https://tools.ietf.org/html/rfc1034)
        /// standard with a length limit of 63 characters. Otherwise, an
        /// INVALID_ARGUMENT error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Engine, CreateEngineMetadata>> CreateEngineAsync(string parent, Engine engine, string engineId, st::CancellationToken cancellationToken) =>
            CreateEngineAsync(parent, engine, engineId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a [Engine][google.cloud.discoveryengine.v1.Engine].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, such as
        /// `projects/{project}/locations/{location}/collections/{collection}`.
        /// </param>
        /// <param name="engine">
        /// Required. The [Engine][google.cloud.discoveryengine.v1.Engine] to create.
        /// </param>
        /// <param name="engineId">
        /// Required. The ID to use for the
        /// [Engine][google.cloud.discoveryengine.v1.Engine], which will become the
        /// final component of the [Engine][google.cloud.discoveryengine.v1.Engine]'s
        /// resource name.
        /// 
        /// This field must conform to [RFC-1034](https://tools.ietf.org/html/rfc1034)
        /// standard with a length limit of 63 characters. Otherwise, an
        /// INVALID_ARGUMENT error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Engine, CreateEngineMetadata> CreateEngine(CollectionName parent, Engine engine, string engineId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEngine(new CreateEngineRequest
            {
                ParentAsCollectionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Engine = gax::GaxPreconditions.CheckNotNull(engine, nameof(engine)),
                EngineId = gax::GaxPreconditions.CheckNotNullOrEmpty(engineId, nameof(engineId)),
            }, callSettings);

        /// <summary>
        /// Creates a [Engine][google.cloud.discoveryengine.v1.Engine].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, such as
        /// `projects/{project}/locations/{location}/collections/{collection}`.
        /// </param>
        /// <param name="engine">
        /// Required. The [Engine][google.cloud.discoveryengine.v1.Engine] to create.
        /// </param>
        /// <param name="engineId">
        /// Required. The ID to use for the
        /// [Engine][google.cloud.discoveryengine.v1.Engine], which will become the
        /// final component of the [Engine][google.cloud.discoveryengine.v1.Engine]'s
        /// resource name.
        /// 
        /// This field must conform to [RFC-1034](https://tools.ietf.org/html/rfc1034)
        /// standard with a length limit of 63 characters. Otherwise, an
        /// INVALID_ARGUMENT error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Engine, CreateEngineMetadata>> CreateEngineAsync(CollectionName parent, Engine engine, string engineId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEngineAsync(new CreateEngineRequest
            {
                ParentAsCollectionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Engine = gax::GaxPreconditions.CheckNotNull(engine, nameof(engine)),
                EngineId = gax::GaxPreconditions.CheckNotNullOrEmpty(engineId, nameof(engineId)),
            }, callSettings);

        /// <summary>
        /// Creates a [Engine][google.cloud.discoveryengine.v1.Engine].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, such as
        /// `projects/{project}/locations/{location}/collections/{collection}`.
        /// </param>
        /// <param name="engine">
        /// Required. The [Engine][google.cloud.discoveryengine.v1.Engine] to create.
        /// </param>
        /// <param name="engineId">
        /// Required. The ID to use for the
        /// [Engine][google.cloud.discoveryengine.v1.Engine], which will become the
        /// final component of the [Engine][google.cloud.discoveryengine.v1.Engine]'s
        /// resource name.
        /// 
        /// This field must conform to [RFC-1034](https://tools.ietf.org/html/rfc1034)
        /// standard with a length limit of 63 characters. Otherwise, an
        /// INVALID_ARGUMENT error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Engine, CreateEngineMetadata>> CreateEngineAsync(CollectionName parent, Engine engine, string engineId, st::CancellationToken cancellationToken) =>
            CreateEngineAsync(parent, engine, engineId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a [Engine][google.cloud.discoveryengine.v1.Engine].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteEngineMetadata> DeleteEngine(DeleteEngineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a [Engine][google.cloud.discoveryengine.v1.Engine].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteEngineMetadata>> DeleteEngineAsync(DeleteEngineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a [Engine][google.cloud.discoveryengine.v1.Engine].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteEngineMetadata>> DeleteEngineAsync(DeleteEngineRequest request, st::CancellationToken cancellationToken) =>
            DeleteEngineAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteEngine</c>.</summary>
        public virtual lro::OperationsClient DeleteEngineOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteEngine</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteEngineMetadata> PollOnceDeleteEngine(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteEngineMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteEngineOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteEngine</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteEngineMetadata>> PollOnceDeleteEngineAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteEngineMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteEngineOperationsClient, callSettings);

        /// <summary>
        /// Deletes a [Engine][google.cloud.discoveryengine.v1.Engine].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [Engine][google.cloud.discoveryengine.v1.Engine], such as
        /// `projects/{project}/locations/{location}/collections/{collection_id}/engines/{engine_id}`.
        /// 
        /// If the caller does not have permission to delete the
        /// [Engine][google.cloud.discoveryengine.v1.Engine], regardless of whether or
        /// not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [Engine][google.cloud.discoveryengine.v1.Engine] to delete does not
        /// exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteEngineMetadata> DeleteEngine(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEngine(new DeleteEngineRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [Engine][google.cloud.discoveryengine.v1.Engine].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [Engine][google.cloud.discoveryengine.v1.Engine], such as
        /// `projects/{project}/locations/{location}/collections/{collection_id}/engines/{engine_id}`.
        /// 
        /// If the caller does not have permission to delete the
        /// [Engine][google.cloud.discoveryengine.v1.Engine], regardless of whether or
        /// not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [Engine][google.cloud.discoveryengine.v1.Engine] to delete does not
        /// exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteEngineMetadata>> DeleteEngineAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEngineAsync(new DeleteEngineRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [Engine][google.cloud.discoveryengine.v1.Engine].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [Engine][google.cloud.discoveryengine.v1.Engine], such as
        /// `projects/{project}/locations/{location}/collections/{collection_id}/engines/{engine_id}`.
        /// 
        /// If the caller does not have permission to delete the
        /// [Engine][google.cloud.discoveryengine.v1.Engine], regardless of whether or
        /// not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [Engine][google.cloud.discoveryengine.v1.Engine] to delete does not
        /// exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteEngineMetadata>> DeleteEngineAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteEngineAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a [Engine][google.cloud.discoveryengine.v1.Engine].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [Engine][google.cloud.discoveryengine.v1.Engine], such as
        /// `projects/{project}/locations/{location}/collections/{collection_id}/engines/{engine_id}`.
        /// 
        /// If the caller does not have permission to delete the
        /// [Engine][google.cloud.discoveryengine.v1.Engine], regardless of whether or
        /// not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [Engine][google.cloud.discoveryengine.v1.Engine] to delete does not
        /// exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteEngineMetadata> DeleteEngine(EngineName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEngine(new DeleteEngineRequest
            {
                EngineName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [Engine][google.cloud.discoveryengine.v1.Engine].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [Engine][google.cloud.discoveryengine.v1.Engine], such as
        /// `projects/{project}/locations/{location}/collections/{collection_id}/engines/{engine_id}`.
        /// 
        /// If the caller does not have permission to delete the
        /// [Engine][google.cloud.discoveryengine.v1.Engine], regardless of whether or
        /// not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [Engine][google.cloud.discoveryengine.v1.Engine] to delete does not
        /// exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteEngineMetadata>> DeleteEngineAsync(EngineName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEngineAsync(new DeleteEngineRequest
            {
                EngineName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [Engine][google.cloud.discoveryengine.v1.Engine].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [Engine][google.cloud.discoveryengine.v1.Engine], such as
        /// `projects/{project}/locations/{location}/collections/{collection_id}/engines/{engine_id}`.
        /// 
        /// If the caller does not have permission to delete the
        /// [Engine][google.cloud.discoveryengine.v1.Engine], regardless of whether or
        /// not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [Engine][google.cloud.discoveryengine.v1.Engine] to delete does not
        /// exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteEngineMetadata>> DeleteEngineAsync(EngineName name, st::CancellationToken cancellationToken) =>
            DeleteEngineAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an [Engine][google.cloud.discoveryengine.v1.Engine]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Engine UpdateEngine(UpdateEngineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an [Engine][google.cloud.discoveryengine.v1.Engine]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Engine> UpdateEngineAsync(UpdateEngineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an [Engine][google.cloud.discoveryengine.v1.Engine]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Engine> UpdateEngineAsync(UpdateEngineRequest request, st::CancellationToken cancellationToken) =>
            UpdateEngineAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an [Engine][google.cloud.discoveryengine.v1.Engine]
        /// </summary>
        /// <param name="engine">
        /// Required. The [Engine][google.cloud.discoveryengine.v1.Engine] to update.
        /// 
        /// If the caller does not have permission to update the
        /// [Engine][google.cloud.discoveryengine.v1.Engine], regardless of whether or
        /// not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [Engine][google.cloud.discoveryengine.v1.Engine] to update does not
        /// exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided
        /// [Engine][google.cloud.discoveryengine.v1.Engine] to update.
        /// 
        /// If an unsupported or unknown field is provided, an INVALID_ARGUMENT error
        /// is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Engine UpdateEngine(Engine engine, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEngine(new UpdateEngineRequest
            {
                Engine = gax::GaxPreconditions.CheckNotNull(engine, nameof(engine)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an [Engine][google.cloud.discoveryengine.v1.Engine]
        /// </summary>
        /// <param name="engine">
        /// Required. The [Engine][google.cloud.discoveryengine.v1.Engine] to update.
        /// 
        /// If the caller does not have permission to update the
        /// [Engine][google.cloud.discoveryengine.v1.Engine], regardless of whether or
        /// not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [Engine][google.cloud.discoveryengine.v1.Engine] to update does not
        /// exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided
        /// [Engine][google.cloud.discoveryengine.v1.Engine] to update.
        /// 
        /// If an unsupported or unknown field is provided, an INVALID_ARGUMENT error
        /// is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Engine> UpdateEngineAsync(Engine engine, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEngineAsync(new UpdateEngineRequest
            {
                Engine = gax::GaxPreconditions.CheckNotNull(engine, nameof(engine)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an [Engine][google.cloud.discoveryengine.v1.Engine]
        /// </summary>
        /// <param name="engine">
        /// Required. The [Engine][google.cloud.discoveryengine.v1.Engine] to update.
        /// 
        /// If the caller does not have permission to update the
        /// [Engine][google.cloud.discoveryengine.v1.Engine], regardless of whether or
        /// not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [Engine][google.cloud.discoveryengine.v1.Engine] to update does not
        /// exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided
        /// [Engine][google.cloud.discoveryengine.v1.Engine] to update.
        /// 
        /// If an unsupported or unknown field is provided, an INVALID_ARGUMENT error
        /// is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Engine> UpdateEngineAsync(Engine engine, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateEngineAsync(engine, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a [Engine][google.cloud.discoveryengine.v1.Engine].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Engine GetEngine(GetEngineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a [Engine][google.cloud.discoveryengine.v1.Engine].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Engine> GetEngineAsync(GetEngineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a [Engine][google.cloud.discoveryengine.v1.Engine].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Engine> GetEngineAsync(GetEngineRequest request, st::CancellationToken cancellationToken) =>
            GetEngineAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a [Engine][google.cloud.discoveryengine.v1.Engine].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [Engine][google.cloud.discoveryengine.v1.Engine], such as
        /// `projects/{project}/locations/{location}/collections/{collection_id}/engines/{engine_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Engine GetEngine(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEngine(new GetEngineRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [Engine][google.cloud.discoveryengine.v1.Engine].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [Engine][google.cloud.discoveryengine.v1.Engine], such as
        /// `projects/{project}/locations/{location}/collections/{collection_id}/engines/{engine_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Engine> GetEngineAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEngineAsync(new GetEngineRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [Engine][google.cloud.discoveryengine.v1.Engine].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [Engine][google.cloud.discoveryengine.v1.Engine], such as
        /// `projects/{project}/locations/{location}/collections/{collection_id}/engines/{engine_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Engine> GetEngineAsync(string name, st::CancellationToken cancellationToken) =>
            GetEngineAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a [Engine][google.cloud.discoveryengine.v1.Engine].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [Engine][google.cloud.discoveryengine.v1.Engine], such as
        /// `projects/{project}/locations/{location}/collections/{collection_id}/engines/{engine_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Engine GetEngine(EngineName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEngine(new GetEngineRequest
            {
                EngineName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [Engine][google.cloud.discoveryengine.v1.Engine].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [Engine][google.cloud.discoveryengine.v1.Engine], such as
        /// `projects/{project}/locations/{location}/collections/{collection_id}/engines/{engine_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Engine> GetEngineAsync(EngineName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEngineAsync(new GetEngineRequest
            {
                EngineName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [Engine][google.cloud.discoveryengine.v1.Engine].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [Engine][google.cloud.discoveryengine.v1.Engine], such as
        /// `projects/{project}/locations/{location}/collections/{collection_id}/engines/{engine_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Engine> GetEngineAsync(EngineName name, st::CancellationToken cancellationToken) =>
            GetEngineAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all the [Engine][google.cloud.discoveryengine.v1.Engine]s associated
        /// with the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Engine"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEnginesResponse, Engine> ListEngines(ListEnginesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the [Engine][google.cloud.discoveryengine.v1.Engine]s associated
        /// with the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Engine"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEnginesResponse, Engine> ListEnginesAsync(ListEnginesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the [Engine][google.cloud.discoveryengine.v1.Engine]s associated
        /// with the project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, such as
        /// `projects/{project}/locations/{location}/collections/{collection_id}`.
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
        /// <returns>A pageable sequence of <see cref="Engine"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEnginesResponse, Engine> ListEngines(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEnginesRequest request = new ListEnginesRequest
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
            return ListEngines(request, callSettings);
        }

        /// <summary>
        /// Lists all the [Engine][google.cloud.discoveryengine.v1.Engine]s associated
        /// with the project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, such as
        /// `projects/{project}/locations/{location}/collections/{collection_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Engine"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEnginesResponse, Engine> ListEnginesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEnginesRequest request = new ListEnginesRequest
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
            return ListEnginesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all the [Engine][google.cloud.discoveryengine.v1.Engine]s associated
        /// with the project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, such as
        /// `projects/{project}/locations/{location}/collections/{collection_id}`.
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
        /// <returns>A pageable sequence of <see cref="Engine"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEnginesResponse, Engine> ListEngines(CollectionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEnginesRequest request = new ListEnginesRequest
            {
                ParentAsCollectionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEngines(request, callSettings);
        }

        /// <summary>
        /// Lists all the [Engine][google.cloud.discoveryengine.v1.Engine]s associated
        /// with the project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, such as
        /// `projects/{project}/locations/{location}/collections/{collection_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Engine"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEnginesResponse, Engine> ListEnginesAsync(CollectionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEnginesRequest request = new ListEnginesRequest
            {
                ParentAsCollectionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEnginesAsync(request, callSettings);
        }
    }

    /// <summary>EngineService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [Engine][google.cloud.discoveryengine.v1.Engine]
    /// configuration.
    /// </remarks>
    public sealed partial class EngineServiceClientImpl : EngineServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateEngineRequest, lro::Operation> _callCreateEngine;

        private readonly gaxgrpc::ApiCall<DeleteEngineRequest, lro::Operation> _callDeleteEngine;

        private readonly gaxgrpc::ApiCall<UpdateEngineRequest, Engine> _callUpdateEngine;

        private readonly gaxgrpc::ApiCall<GetEngineRequest, Engine> _callGetEngine;

        private readonly gaxgrpc::ApiCall<ListEnginesRequest, ListEnginesResponse> _callListEngines;

        /// <summary>
        /// Constructs a client wrapper for the EngineService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="EngineServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public EngineServiceClientImpl(EngineService.EngineServiceClient grpcClient, EngineServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            EngineServiceSettings effectiveSettings = settings ?? EngineServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateEngineOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateEngineOperationsSettings, logger);
            DeleteEngineOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteEngineOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCreateEngine = clientHelper.BuildApiCall<CreateEngineRequest, lro::Operation>("CreateEngine", grpcClient.CreateEngineAsync, grpcClient.CreateEngine, effectiveSettings.CreateEngineSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateEngine);
            Modify_CreateEngineApiCall(ref _callCreateEngine);
            _callDeleteEngine = clientHelper.BuildApiCall<DeleteEngineRequest, lro::Operation>("DeleteEngine", grpcClient.DeleteEngineAsync, grpcClient.DeleteEngine, effectiveSettings.DeleteEngineSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteEngine);
            Modify_DeleteEngineApiCall(ref _callDeleteEngine);
            _callUpdateEngine = clientHelper.BuildApiCall<UpdateEngineRequest, Engine>("UpdateEngine", grpcClient.UpdateEngineAsync, grpcClient.UpdateEngine, effectiveSettings.UpdateEngineSettings).WithGoogleRequestParam("engine.name", request => request.Engine?.Name);
            Modify_ApiCall(ref _callUpdateEngine);
            Modify_UpdateEngineApiCall(ref _callUpdateEngine);
            _callGetEngine = clientHelper.BuildApiCall<GetEngineRequest, Engine>("GetEngine", grpcClient.GetEngineAsync, grpcClient.GetEngine, effectiveSettings.GetEngineSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEngine);
            Modify_GetEngineApiCall(ref _callGetEngine);
            _callListEngines = clientHelper.BuildApiCall<ListEnginesRequest, ListEnginesResponse>("ListEngines", grpcClient.ListEnginesAsync, grpcClient.ListEngines, effectiveSettings.ListEnginesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEngines);
            Modify_ListEnginesApiCall(ref _callListEngines);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateEngineApiCall(ref gaxgrpc::ApiCall<CreateEngineRequest, lro::Operation> call);

        partial void Modify_DeleteEngineApiCall(ref gaxgrpc::ApiCall<DeleteEngineRequest, lro::Operation> call);

        partial void Modify_UpdateEngineApiCall(ref gaxgrpc::ApiCall<UpdateEngineRequest, Engine> call);

        partial void Modify_GetEngineApiCall(ref gaxgrpc::ApiCall<GetEngineRequest, Engine> call);

        partial void Modify_ListEnginesApiCall(ref gaxgrpc::ApiCall<ListEnginesRequest, ListEnginesResponse> call);

        partial void OnConstruction(EngineService.EngineServiceClient grpcClient, EngineServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC EngineService client</summary>
        public override EngineService.EngineServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CreateEngineRequest(ref CreateEngineRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteEngineRequest(ref DeleteEngineRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateEngineRequest(ref UpdateEngineRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEngineRequest(ref GetEngineRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListEnginesRequest(ref ListEnginesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateEngine</c>.</summary>
        public override lro::OperationsClient CreateEngineOperationsClient { get; }

        /// <summary>
        /// Creates a [Engine][google.cloud.discoveryengine.v1.Engine].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Engine, CreateEngineMetadata> CreateEngine(CreateEngineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEngineRequest(ref request, ref callSettings);
            return new lro::Operation<Engine, CreateEngineMetadata>(_callCreateEngine.Sync(request, callSettings), CreateEngineOperationsClient);
        }

        /// <summary>
        /// Creates a [Engine][google.cloud.discoveryengine.v1.Engine].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Engine, CreateEngineMetadata>> CreateEngineAsync(CreateEngineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEngineRequest(ref request, ref callSettings);
            return new lro::Operation<Engine, CreateEngineMetadata>(await _callCreateEngine.Async(request, callSettings).ConfigureAwait(false), CreateEngineOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteEngine</c>.</summary>
        public override lro::OperationsClient DeleteEngineOperationsClient { get; }

        /// <summary>
        /// Deletes a [Engine][google.cloud.discoveryengine.v1.Engine].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteEngineMetadata> DeleteEngine(DeleteEngineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEngineRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteEngineMetadata>(_callDeleteEngine.Sync(request, callSettings), DeleteEngineOperationsClient);
        }

        /// <summary>
        /// Deletes a [Engine][google.cloud.discoveryengine.v1.Engine].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteEngineMetadata>> DeleteEngineAsync(DeleteEngineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEngineRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteEngineMetadata>(await _callDeleteEngine.Async(request, callSettings).ConfigureAwait(false), DeleteEngineOperationsClient);
        }

        /// <summary>
        /// Updates an [Engine][google.cloud.discoveryengine.v1.Engine]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Engine UpdateEngine(UpdateEngineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEngineRequest(ref request, ref callSettings);
            return _callUpdateEngine.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an [Engine][google.cloud.discoveryengine.v1.Engine]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Engine> UpdateEngineAsync(UpdateEngineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEngineRequest(ref request, ref callSettings);
            return _callUpdateEngine.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a [Engine][google.cloud.discoveryengine.v1.Engine].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Engine GetEngine(GetEngineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEngineRequest(ref request, ref callSettings);
            return _callGetEngine.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a [Engine][google.cloud.discoveryengine.v1.Engine].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Engine> GetEngineAsync(GetEngineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEngineRequest(ref request, ref callSettings);
            return _callGetEngine.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all the [Engine][google.cloud.discoveryengine.v1.Engine]s associated
        /// with the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Engine"/> resources.</returns>
        public override gax::PagedEnumerable<ListEnginesResponse, Engine> ListEngines(ListEnginesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEnginesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEnginesRequest, ListEnginesResponse, Engine>(_callListEngines, request, callSettings);
        }

        /// <summary>
        /// Lists all the [Engine][google.cloud.discoveryengine.v1.Engine]s associated
        /// with the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Engine"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEnginesResponse, Engine> ListEnginesAsync(ListEnginesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEnginesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEnginesRequest, ListEnginesResponse, Engine>(_callListEngines, request, callSettings);
        }
    }

    public partial class ListEnginesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEnginesResponse : gaxgrpc::IPageResponse<Engine>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Engine> GetEnumerator() => Engines.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class EngineService
    {
        public partial class EngineServiceClient
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

    public static partial class EngineService
    {
        public partial class EngineServiceClient
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
