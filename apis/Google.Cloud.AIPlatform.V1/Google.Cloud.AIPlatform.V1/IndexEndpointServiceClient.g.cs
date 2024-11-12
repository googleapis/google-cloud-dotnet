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
    /// <summary>Settings for <see cref="IndexEndpointServiceClient"/> instances.</summary>
    public sealed partial class IndexEndpointServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="IndexEndpointServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="IndexEndpointServiceSettings"/>.</returns>
        public static IndexEndpointServiceSettings GetDefault() => new IndexEndpointServiceSettings();

        /// <summary>Constructs a new <see cref="IndexEndpointServiceSettings"/> object with default settings.</summary>
        public IndexEndpointServiceSettings()
        {
        }

        private IndexEndpointServiceSettings(IndexEndpointServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateIndexEndpointSettings = existing.CreateIndexEndpointSettings;
            CreateIndexEndpointOperationsSettings = existing.CreateIndexEndpointOperationsSettings.Clone();
            GetIndexEndpointSettings = existing.GetIndexEndpointSettings;
            ListIndexEndpointsSettings = existing.ListIndexEndpointsSettings;
            UpdateIndexEndpointSettings = existing.UpdateIndexEndpointSettings;
            DeleteIndexEndpointSettings = existing.DeleteIndexEndpointSettings;
            DeleteIndexEndpointOperationsSettings = existing.DeleteIndexEndpointOperationsSettings.Clone();
            DeployIndexSettings = existing.DeployIndexSettings;
            DeployIndexOperationsSettings = existing.DeployIndexOperationsSettings.Clone();
            UndeployIndexSettings = existing.UndeployIndexSettings;
            UndeployIndexOperationsSettings = existing.UndeployIndexOperationsSettings.Clone();
            MutateDeployedIndexSettings = existing.MutateDeployedIndexSettings;
            MutateDeployedIndexOperationsSettings = existing.MutateDeployedIndexOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(IndexEndpointServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IndexEndpointServiceClient.CreateIndexEndpoint</c> and
        /// <c>IndexEndpointServiceClient.CreateIndexEndpointAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateIndexEndpointSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>IndexEndpointServiceClient.CreateIndexEndpoint</c> and
        /// <c>IndexEndpointServiceClient.CreateIndexEndpointAsync</c>.
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
        public lro::OperationsSettings CreateIndexEndpointOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IndexEndpointServiceClient.GetIndexEndpoint</c> and <c>IndexEndpointServiceClient.GetIndexEndpointAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIndexEndpointSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IndexEndpointServiceClient.ListIndexEndpoints</c> and
        /// <c>IndexEndpointServiceClient.ListIndexEndpointsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListIndexEndpointsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IndexEndpointServiceClient.UpdateIndexEndpoint</c> and
        /// <c>IndexEndpointServiceClient.UpdateIndexEndpointAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateIndexEndpointSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IndexEndpointServiceClient.DeleteIndexEndpoint</c> and
        /// <c>IndexEndpointServiceClient.DeleteIndexEndpointAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteIndexEndpointSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>IndexEndpointServiceClient.DeleteIndexEndpoint</c> and
        /// <c>IndexEndpointServiceClient.DeleteIndexEndpointAsync</c>.
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
        public lro::OperationsSettings DeleteIndexEndpointOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IndexEndpointServiceClient.DeployIndex</c> and <c>IndexEndpointServiceClient.DeployIndexAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeployIndexSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>IndexEndpointServiceClient.DeployIndex</c> and
        /// <c>IndexEndpointServiceClient.DeployIndexAsync</c>.
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
        public lro::OperationsSettings DeployIndexOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IndexEndpointServiceClient.UndeployIndex</c> and <c>IndexEndpointServiceClient.UndeployIndexAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UndeployIndexSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>IndexEndpointServiceClient.UndeployIndex</c> and
        /// <c>IndexEndpointServiceClient.UndeployIndexAsync</c>.
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
        public lro::OperationsSettings UndeployIndexOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IndexEndpointServiceClient.MutateDeployedIndex</c> and
        /// <c>IndexEndpointServiceClient.MutateDeployedIndexAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateDeployedIndexSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>IndexEndpointServiceClient.MutateDeployedIndex</c> and
        /// <c>IndexEndpointServiceClient.MutateDeployedIndexAsync</c>.
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
        public lro::OperationsSettings MutateDeployedIndexOperationsSettings { get; set; } = new lro::OperationsSettings
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
        /// <returns>A deep clone of this <see cref="IndexEndpointServiceSettings"/> object.</returns>
        public IndexEndpointServiceSettings Clone() => new IndexEndpointServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="IndexEndpointServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class IndexEndpointServiceClientBuilder : gaxgrpc::ClientBuilderBase<IndexEndpointServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public IndexEndpointServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public IndexEndpointServiceClientBuilder() : base(IndexEndpointServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref IndexEndpointServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<IndexEndpointServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override IndexEndpointServiceClient Build()
        {
            IndexEndpointServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<IndexEndpointServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<IndexEndpointServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private IndexEndpointServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return IndexEndpointServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<IndexEndpointServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return IndexEndpointServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => IndexEndpointServiceClient.ChannelPool;
    }

    /// <summary>IndexEndpointService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service for managing Vertex AI's IndexEndpoints.
    /// </remarks>
    public abstract partial class IndexEndpointServiceClient
    {
        /// <summary>
        /// The default endpoint for the IndexEndpointService service, which is a host of "aiplatform.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "aiplatform.googleapis.com:443";

        /// <summary>The default IndexEndpointService scopes.</summary>
        /// <remarks>
        /// The default IndexEndpointService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(IndexEndpointService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="IndexEndpointServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="IndexEndpointServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="IndexEndpointServiceClient"/>.</returns>
        public static stt::Task<IndexEndpointServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new IndexEndpointServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="IndexEndpointServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="IndexEndpointServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="IndexEndpointServiceClient"/>.</returns>
        public static IndexEndpointServiceClient Create() => new IndexEndpointServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="IndexEndpointServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="IndexEndpointServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="IndexEndpointServiceClient"/>.</returns>
        internal static IndexEndpointServiceClient Create(grpccore::CallInvoker callInvoker, IndexEndpointServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            IndexEndpointService.IndexEndpointServiceClient grpcClient = new IndexEndpointService.IndexEndpointServiceClient(callInvoker);
            return new IndexEndpointServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC IndexEndpointService client</summary>
        public virtual IndexEndpointService.IndexEndpointServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<IndexEndpoint, CreateIndexEndpointOperationMetadata> CreateIndexEndpoint(CreateIndexEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IndexEndpoint, CreateIndexEndpointOperationMetadata>> CreateIndexEndpointAsync(CreateIndexEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IndexEndpoint, CreateIndexEndpointOperationMetadata>> CreateIndexEndpointAsync(CreateIndexEndpointRequest request, st::CancellationToken cancellationToken) =>
            CreateIndexEndpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateIndexEndpoint</c>.</summary>
        public virtual lro::OperationsClient CreateIndexEndpointOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateIndexEndpoint</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<IndexEndpoint, CreateIndexEndpointOperationMetadata> PollOnceCreateIndexEndpoint(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<IndexEndpoint, CreateIndexEndpointOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateIndexEndpointOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateIndexEndpoint</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<IndexEndpoint, CreateIndexEndpointOperationMetadata>> PollOnceCreateIndexEndpointAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<IndexEndpoint, CreateIndexEndpointOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateIndexEndpointOperationsClient, callSettings);

        /// <summary>
        /// Creates an IndexEndpoint.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the IndexEndpoint in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="indexEndpoint">
        /// Required. The IndexEndpoint to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<IndexEndpoint, CreateIndexEndpointOperationMetadata> CreateIndexEndpoint(string parent, IndexEndpoint indexEndpoint, gaxgrpc::CallSettings callSettings = null) =>
            CreateIndexEndpoint(new CreateIndexEndpointRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                IndexEndpoint = gax::GaxPreconditions.CheckNotNull(indexEndpoint, nameof(indexEndpoint)),
            }, callSettings);

        /// <summary>
        /// Creates an IndexEndpoint.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the IndexEndpoint in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="indexEndpoint">
        /// Required. The IndexEndpoint to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IndexEndpoint, CreateIndexEndpointOperationMetadata>> CreateIndexEndpointAsync(string parent, IndexEndpoint indexEndpoint, gaxgrpc::CallSettings callSettings = null) =>
            CreateIndexEndpointAsync(new CreateIndexEndpointRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                IndexEndpoint = gax::GaxPreconditions.CheckNotNull(indexEndpoint, nameof(indexEndpoint)),
            }, callSettings);

        /// <summary>
        /// Creates an IndexEndpoint.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the IndexEndpoint in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="indexEndpoint">
        /// Required. The IndexEndpoint to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IndexEndpoint, CreateIndexEndpointOperationMetadata>> CreateIndexEndpointAsync(string parent, IndexEndpoint indexEndpoint, st::CancellationToken cancellationToken) =>
            CreateIndexEndpointAsync(parent, indexEndpoint, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an IndexEndpoint.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the IndexEndpoint in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="indexEndpoint">
        /// Required. The IndexEndpoint to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<IndexEndpoint, CreateIndexEndpointOperationMetadata> CreateIndexEndpoint(gagr::LocationName parent, IndexEndpoint indexEndpoint, gaxgrpc::CallSettings callSettings = null) =>
            CreateIndexEndpoint(new CreateIndexEndpointRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                IndexEndpoint = gax::GaxPreconditions.CheckNotNull(indexEndpoint, nameof(indexEndpoint)),
            }, callSettings);

        /// <summary>
        /// Creates an IndexEndpoint.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the IndexEndpoint in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="indexEndpoint">
        /// Required. The IndexEndpoint to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IndexEndpoint, CreateIndexEndpointOperationMetadata>> CreateIndexEndpointAsync(gagr::LocationName parent, IndexEndpoint indexEndpoint, gaxgrpc::CallSettings callSettings = null) =>
            CreateIndexEndpointAsync(new CreateIndexEndpointRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                IndexEndpoint = gax::GaxPreconditions.CheckNotNull(indexEndpoint, nameof(indexEndpoint)),
            }, callSettings);

        /// <summary>
        /// Creates an IndexEndpoint.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the IndexEndpoint in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="indexEndpoint">
        /// Required. The IndexEndpoint to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IndexEndpoint, CreateIndexEndpointOperationMetadata>> CreateIndexEndpointAsync(gagr::LocationName parent, IndexEndpoint indexEndpoint, st::CancellationToken cancellationToken) =>
            CreateIndexEndpointAsync(parent, indexEndpoint, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IndexEndpoint GetIndexEndpoint(GetIndexEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IndexEndpoint> GetIndexEndpointAsync(GetIndexEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IndexEndpoint> GetIndexEndpointAsync(GetIndexEndpointRequest request, st::CancellationToken cancellationToken) =>
            GetIndexEndpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an IndexEndpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the IndexEndpoint resource.
        /// Format:
        /// `projects/{project}/locations/{location}/indexEndpoints/{index_endpoint}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IndexEndpoint GetIndexEndpoint(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetIndexEndpoint(new GetIndexEndpointRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an IndexEndpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the IndexEndpoint resource.
        /// Format:
        /// `projects/{project}/locations/{location}/indexEndpoints/{index_endpoint}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IndexEndpoint> GetIndexEndpointAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetIndexEndpointAsync(new GetIndexEndpointRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an IndexEndpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the IndexEndpoint resource.
        /// Format:
        /// `projects/{project}/locations/{location}/indexEndpoints/{index_endpoint}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IndexEndpoint> GetIndexEndpointAsync(string name, st::CancellationToken cancellationToken) =>
            GetIndexEndpointAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an IndexEndpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the IndexEndpoint resource.
        /// Format:
        /// `projects/{project}/locations/{location}/indexEndpoints/{index_endpoint}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IndexEndpoint GetIndexEndpoint(IndexEndpointName name, gaxgrpc::CallSettings callSettings = null) =>
            GetIndexEndpoint(new GetIndexEndpointRequest
            {
                IndexEndpointName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an IndexEndpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the IndexEndpoint resource.
        /// Format:
        /// `projects/{project}/locations/{location}/indexEndpoints/{index_endpoint}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IndexEndpoint> GetIndexEndpointAsync(IndexEndpointName name, gaxgrpc::CallSettings callSettings = null) =>
            GetIndexEndpointAsync(new GetIndexEndpointRequest
            {
                IndexEndpointName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an IndexEndpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the IndexEndpoint resource.
        /// Format:
        /// `projects/{project}/locations/{location}/indexEndpoints/{index_endpoint}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IndexEndpoint> GetIndexEndpointAsync(IndexEndpointName name, st::CancellationToken cancellationToken) =>
            GetIndexEndpointAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists IndexEndpoints in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="IndexEndpoint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListIndexEndpointsResponse, IndexEndpoint> ListIndexEndpoints(ListIndexEndpointsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists IndexEndpoints in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="IndexEndpoint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListIndexEndpointsResponse, IndexEndpoint> ListIndexEndpointsAsync(ListIndexEndpointsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists IndexEndpoints in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location from which to list the
        /// IndexEndpoints. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="IndexEndpoint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListIndexEndpointsResponse, IndexEndpoint> ListIndexEndpoints(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListIndexEndpointsRequest request = new ListIndexEndpointsRequest
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
            return ListIndexEndpoints(request, callSettings);
        }

        /// <summary>
        /// Lists IndexEndpoints in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location from which to list the
        /// IndexEndpoints. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="IndexEndpoint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListIndexEndpointsResponse, IndexEndpoint> ListIndexEndpointsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListIndexEndpointsRequest request = new ListIndexEndpointsRequest
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
            return ListIndexEndpointsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists IndexEndpoints in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location from which to list the
        /// IndexEndpoints. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="IndexEndpoint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListIndexEndpointsResponse, IndexEndpoint> ListIndexEndpoints(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListIndexEndpointsRequest request = new ListIndexEndpointsRequest
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
            return ListIndexEndpoints(request, callSettings);
        }

        /// <summary>
        /// Lists IndexEndpoints in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location from which to list the
        /// IndexEndpoints. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="IndexEndpoint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListIndexEndpointsResponse, IndexEndpoint> ListIndexEndpointsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListIndexEndpointsRequest request = new ListIndexEndpointsRequest
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
            return ListIndexEndpointsAsync(request, callSettings);
        }

        /// <summary>
        /// Updates an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IndexEndpoint UpdateIndexEndpoint(UpdateIndexEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IndexEndpoint> UpdateIndexEndpointAsync(UpdateIndexEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IndexEndpoint> UpdateIndexEndpointAsync(UpdateIndexEndpointRequest request, st::CancellationToken cancellationToken) =>
            UpdateIndexEndpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an IndexEndpoint.
        /// </summary>
        /// <param name="indexEndpoint">
        /// Required. The IndexEndpoint which replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource. See
        /// [google.protobuf.FieldMask][google.protobuf.FieldMask].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IndexEndpoint UpdateIndexEndpoint(IndexEndpoint indexEndpoint, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateIndexEndpoint(new UpdateIndexEndpointRequest
            {
                IndexEndpoint = gax::GaxPreconditions.CheckNotNull(indexEndpoint, nameof(indexEndpoint)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an IndexEndpoint.
        /// </summary>
        /// <param name="indexEndpoint">
        /// Required. The IndexEndpoint which replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource. See
        /// [google.protobuf.FieldMask][google.protobuf.FieldMask].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IndexEndpoint> UpdateIndexEndpointAsync(IndexEndpoint indexEndpoint, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateIndexEndpointAsync(new UpdateIndexEndpointRequest
            {
                IndexEndpoint = gax::GaxPreconditions.CheckNotNull(indexEndpoint, nameof(indexEndpoint)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an IndexEndpoint.
        /// </summary>
        /// <param name="indexEndpoint">
        /// Required. The IndexEndpoint which replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource. See
        /// [google.protobuf.FieldMask][google.protobuf.FieldMask].
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IndexEndpoint> UpdateIndexEndpointAsync(IndexEndpoint indexEndpoint, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateIndexEndpointAsync(indexEndpoint, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteIndexEndpoint(DeleteIndexEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteIndexEndpointAsync(DeleteIndexEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteIndexEndpointAsync(DeleteIndexEndpointRequest request, st::CancellationToken cancellationToken) =>
            DeleteIndexEndpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteIndexEndpoint</c>.</summary>
        public virtual lro::OperationsClient DeleteIndexEndpointOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteIndexEndpoint</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> PollOnceDeleteIndexEndpoint(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteIndexEndpointOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteIndexEndpoint</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> PollOnceDeleteIndexEndpointAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteIndexEndpointOperationsClient, callSettings);

        /// <summary>
        /// Deletes an IndexEndpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the IndexEndpoint resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/indexEndpoints/{index_endpoint}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteIndexEndpoint(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIndexEndpoint(new DeleteIndexEndpointRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an IndexEndpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the IndexEndpoint resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/indexEndpoints/{index_endpoint}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteIndexEndpointAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIndexEndpointAsync(new DeleteIndexEndpointRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an IndexEndpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the IndexEndpoint resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/indexEndpoints/{index_endpoint}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteIndexEndpointAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteIndexEndpointAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an IndexEndpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the IndexEndpoint resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/indexEndpoints/{index_endpoint}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteIndexEndpoint(IndexEndpointName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIndexEndpoint(new DeleteIndexEndpointRequest
            {
                IndexEndpointName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an IndexEndpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the IndexEndpoint resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/indexEndpoints/{index_endpoint}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteIndexEndpointAsync(IndexEndpointName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIndexEndpointAsync(new DeleteIndexEndpointRequest
            {
                IndexEndpointName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an IndexEndpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the IndexEndpoint resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/indexEndpoints/{index_endpoint}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteIndexEndpointAsync(IndexEndpointName name, st::CancellationToken cancellationToken) =>
            DeleteIndexEndpointAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deploys an Index into this IndexEndpoint, creating a DeployedIndex within
        /// it.
        /// Only non-empty Indexes can be deployed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeployIndexResponse, DeployIndexOperationMetadata> DeployIndex(DeployIndexRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deploys an Index into this IndexEndpoint, creating a DeployedIndex within
        /// it.
        /// Only non-empty Indexes can be deployed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployIndexResponse, DeployIndexOperationMetadata>> DeployIndexAsync(DeployIndexRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deploys an Index into this IndexEndpoint, creating a DeployedIndex within
        /// it.
        /// Only non-empty Indexes can be deployed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployIndexResponse, DeployIndexOperationMetadata>> DeployIndexAsync(DeployIndexRequest request, st::CancellationToken cancellationToken) =>
            DeployIndexAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeployIndex</c>.</summary>
        public virtual lro::OperationsClient DeployIndexOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeployIndex</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DeployIndexResponse, DeployIndexOperationMetadata> PollOnceDeployIndex(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DeployIndexResponse, DeployIndexOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeployIndexOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeployIndex</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DeployIndexResponse, DeployIndexOperationMetadata>> PollOnceDeployIndexAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DeployIndexResponse, DeployIndexOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeployIndexOperationsClient, callSettings);

        /// <summary>
        /// Deploys an Index into this IndexEndpoint, creating a DeployedIndex within
        /// it.
        /// Only non-empty Indexes can be deployed.
        /// </summary>
        /// <param name="indexEndpoint">
        /// Required. The name of the IndexEndpoint resource into which to deploy an
        /// Index. Format:
        /// `projects/{project}/locations/{location}/indexEndpoints/{index_endpoint}`
        /// </param>
        /// <param name="deployedIndex">
        /// Required. The DeployedIndex to be created within the IndexEndpoint.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeployIndexResponse, DeployIndexOperationMetadata> DeployIndex(string indexEndpoint, DeployedIndex deployedIndex, gaxgrpc::CallSettings callSettings = null) =>
            DeployIndex(new DeployIndexRequest
            {
                IndexEndpoint = gax::GaxPreconditions.CheckNotNullOrEmpty(indexEndpoint, nameof(indexEndpoint)),
                DeployedIndex = gax::GaxPreconditions.CheckNotNull(deployedIndex, nameof(deployedIndex)),
            }, callSettings);

        /// <summary>
        /// Deploys an Index into this IndexEndpoint, creating a DeployedIndex within
        /// it.
        /// Only non-empty Indexes can be deployed.
        /// </summary>
        /// <param name="indexEndpoint">
        /// Required. The name of the IndexEndpoint resource into which to deploy an
        /// Index. Format:
        /// `projects/{project}/locations/{location}/indexEndpoints/{index_endpoint}`
        /// </param>
        /// <param name="deployedIndex">
        /// Required. The DeployedIndex to be created within the IndexEndpoint.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployIndexResponse, DeployIndexOperationMetadata>> DeployIndexAsync(string indexEndpoint, DeployedIndex deployedIndex, gaxgrpc::CallSettings callSettings = null) =>
            DeployIndexAsync(new DeployIndexRequest
            {
                IndexEndpoint = gax::GaxPreconditions.CheckNotNullOrEmpty(indexEndpoint, nameof(indexEndpoint)),
                DeployedIndex = gax::GaxPreconditions.CheckNotNull(deployedIndex, nameof(deployedIndex)),
            }, callSettings);

        /// <summary>
        /// Deploys an Index into this IndexEndpoint, creating a DeployedIndex within
        /// it.
        /// Only non-empty Indexes can be deployed.
        /// </summary>
        /// <param name="indexEndpoint">
        /// Required. The name of the IndexEndpoint resource into which to deploy an
        /// Index. Format:
        /// `projects/{project}/locations/{location}/indexEndpoints/{index_endpoint}`
        /// </param>
        /// <param name="deployedIndex">
        /// Required. The DeployedIndex to be created within the IndexEndpoint.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployIndexResponse, DeployIndexOperationMetadata>> DeployIndexAsync(string indexEndpoint, DeployedIndex deployedIndex, st::CancellationToken cancellationToken) =>
            DeployIndexAsync(indexEndpoint, deployedIndex, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deploys an Index into this IndexEndpoint, creating a DeployedIndex within
        /// it.
        /// Only non-empty Indexes can be deployed.
        /// </summary>
        /// <param name="indexEndpoint">
        /// Required. The name of the IndexEndpoint resource into which to deploy an
        /// Index. Format:
        /// `projects/{project}/locations/{location}/indexEndpoints/{index_endpoint}`
        /// </param>
        /// <param name="deployedIndex">
        /// Required. The DeployedIndex to be created within the IndexEndpoint.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeployIndexResponse, DeployIndexOperationMetadata> DeployIndex(IndexEndpointName indexEndpoint, DeployedIndex deployedIndex, gaxgrpc::CallSettings callSettings = null) =>
            DeployIndex(new DeployIndexRequest
            {
                IndexEndpointAsIndexEndpointName = gax::GaxPreconditions.CheckNotNull(indexEndpoint, nameof(indexEndpoint)),
                DeployedIndex = gax::GaxPreconditions.CheckNotNull(deployedIndex, nameof(deployedIndex)),
            }, callSettings);

        /// <summary>
        /// Deploys an Index into this IndexEndpoint, creating a DeployedIndex within
        /// it.
        /// Only non-empty Indexes can be deployed.
        /// </summary>
        /// <param name="indexEndpoint">
        /// Required. The name of the IndexEndpoint resource into which to deploy an
        /// Index. Format:
        /// `projects/{project}/locations/{location}/indexEndpoints/{index_endpoint}`
        /// </param>
        /// <param name="deployedIndex">
        /// Required. The DeployedIndex to be created within the IndexEndpoint.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployIndexResponse, DeployIndexOperationMetadata>> DeployIndexAsync(IndexEndpointName indexEndpoint, DeployedIndex deployedIndex, gaxgrpc::CallSettings callSettings = null) =>
            DeployIndexAsync(new DeployIndexRequest
            {
                IndexEndpointAsIndexEndpointName = gax::GaxPreconditions.CheckNotNull(indexEndpoint, nameof(indexEndpoint)),
                DeployedIndex = gax::GaxPreconditions.CheckNotNull(deployedIndex, nameof(deployedIndex)),
            }, callSettings);

        /// <summary>
        /// Deploys an Index into this IndexEndpoint, creating a DeployedIndex within
        /// it.
        /// Only non-empty Indexes can be deployed.
        /// </summary>
        /// <param name="indexEndpoint">
        /// Required. The name of the IndexEndpoint resource into which to deploy an
        /// Index. Format:
        /// `projects/{project}/locations/{location}/indexEndpoints/{index_endpoint}`
        /// </param>
        /// <param name="deployedIndex">
        /// Required. The DeployedIndex to be created within the IndexEndpoint.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployIndexResponse, DeployIndexOperationMetadata>> DeployIndexAsync(IndexEndpointName indexEndpoint, DeployedIndex deployedIndex, st::CancellationToken cancellationToken) =>
            DeployIndexAsync(indexEndpoint, deployedIndex, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Undeploys an Index from an IndexEndpoint, removing a DeployedIndex from it,
        /// and freeing all resources it's using.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UndeployIndexResponse, UndeployIndexOperationMetadata> UndeployIndex(UndeployIndexRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Undeploys an Index from an IndexEndpoint, removing a DeployedIndex from it,
        /// and freeing all resources it's using.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UndeployIndexResponse, UndeployIndexOperationMetadata>> UndeployIndexAsync(UndeployIndexRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Undeploys an Index from an IndexEndpoint, removing a DeployedIndex from it,
        /// and freeing all resources it's using.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UndeployIndexResponse, UndeployIndexOperationMetadata>> UndeployIndexAsync(UndeployIndexRequest request, st::CancellationToken cancellationToken) =>
            UndeployIndexAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UndeployIndex</c>.</summary>
        public virtual lro::OperationsClient UndeployIndexOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UndeployIndex</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<UndeployIndexResponse, UndeployIndexOperationMetadata> PollOnceUndeployIndex(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<UndeployIndexResponse, UndeployIndexOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UndeployIndexOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UndeployIndex</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<UndeployIndexResponse, UndeployIndexOperationMetadata>> PollOnceUndeployIndexAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<UndeployIndexResponse, UndeployIndexOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UndeployIndexOperationsClient, callSettings);

        /// <summary>
        /// Undeploys an Index from an IndexEndpoint, removing a DeployedIndex from it,
        /// and freeing all resources it's using.
        /// </summary>
        /// <param name="indexEndpoint">
        /// Required. The name of the IndexEndpoint resource from which to undeploy an
        /// Index. Format:
        /// `projects/{project}/locations/{location}/indexEndpoints/{index_endpoint}`
        /// </param>
        /// <param name="deployedIndexId">
        /// Required. The ID of the DeployedIndex to be undeployed from the
        /// IndexEndpoint.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UndeployIndexResponse, UndeployIndexOperationMetadata> UndeployIndex(string indexEndpoint, string deployedIndexId, gaxgrpc::CallSettings callSettings = null) =>
            UndeployIndex(new UndeployIndexRequest
            {
                IndexEndpoint = gax::GaxPreconditions.CheckNotNullOrEmpty(indexEndpoint, nameof(indexEndpoint)),
                DeployedIndexId = gax::GaxPreconditions.CheckNotNullOrEmpty(deployedIndexId, nameof(deployedIndexId)),
            }, callSettings);

        /// <summary>
        /// Undeploys an Index from an IndexEndpoint, removing a DeployedIndex from it,
        /// and freeing all resources it's using.
        /// </summary>
        /// <param name="indexEndpoint">
        /// Required. The name of the IndexEndpoint resource from which to undeploy an
        /// Index. Format:
        /// `projects/{project}/locations/{location}/indexEndpoints/{index_endpoint}`
        /// </param>
        /// <param name="deployedIndexId">
        /// Required. The ID of the DeployedIndex to be undeployed from the
        /// IndexEndpoint.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UndeployIndexResponse, UndeployIndexOperationMetadata>> UndeployIndexAsync(string indexEndpoint, string deployedIndexId, gaxgrpc::CallSettings callSettings = null) =>
            UndeployIndexAsync(new UndeployIndexRequest
            {
                IndexEndpoint = gax::GaxPreconditions.CheckNotNullOrEmpty(indexEndpoint, nameof(indexEndpoint)),
                DeployedIndexId = gax::GaxPreconditions.CheckNotNullOrEmpty(deployedIndexId, nameof(deployedIndexId)),
            }, callSettings);

        /// <summary>
        /// Undeploys an Index from an IndexEndpoint, removing a DeployedIndex from it,
        /// and freeing all resources it's using.
        /// </summary>
        /// <param name="indexEndpoint">
        /// Required. The name of the IndexEndpoint resource from which to undeploy an
        /// Index. Format:
        /// `projects/{project}/locations/{location}/indexEndpoints/{index_endpoint}`
        /// </param>
        /// <param name="deployedIndexId">
        /// Required. The ID of the DeployedIndex to be undeployed from the
        /// IndexEndpoint.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UndeployIndexResponse, UndeployIndexOperationMetadata>> UndeployIndexAsync(string indexEndpoint, string deployedIndexId, st::CancellationToken cancellationToken) =>
            UndeployIndexAsync(indexEndpoint, deployedIndexId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Undeploys an Index from an IndexEndpoint, removing a DeployedIndex from it,
        /// and freeing all resources it's using.
        /// </summary>
        /// <param name="indexEndpoint">
        /// Required. The name of the IndexEndpoint resource from which to undeploy an
        /// Index. Format:
        /// `projects/{project}/locations/{location}/indexEndpoints/{index_endpoint}`
        /// </param>
        /// <param name="deployedIndexId">
        /// Required. The ID of the DeployedIndex to be undeployed from the
        /// IndexEndpoint.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UndeployIndexResponse, UndeployIndexOperationMetadata> UndeployIndex(IndexEndpointName indexEndpoint, string deployedIndexId, gaxgrpc::CallSettings callSettings = null) =>
            UndeployIndex(new UndeployIndexRequest
            {
                IndexEndpointAsIndexEndpointName = gax::GaxPreconditions.CheckNotNull(indexEndpoint, nameof(indexEndpoint)),
                DeployedIndexId = gax::GaxPreconditions.CheckNotNullOrEmpty(deployedIndexId, nameof(deployedIndexId)),
            }, callSettings);

        /// <summary>
        /// Undeploys an Index from an IndexEndpoint, removing a DeployedIndex from it,
        /// and freeing all resources it's using.
        /// </summary>
        /// <param name="indexEndpoint">
        /// Required. The name of the IndexEndpoint resource from which to undeploy an
        /// Index. Format:
        /// `projects/{project}/locations/{location}/indexEndpoints/{index_endpoint}`
        /// </param>
        /// <param name="deployedIndexId">
        /// Required. The ID of the DeployedIndex to be undeployed from the
        /// IndexEndpoint.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UndeployIndexResponse, UndeployIndexOperationMetadata>> UndeployIndexAsync(IndexEndpointName indexEndpoint, string deployedIndexId, gaxgrpc::CallSettings callSettings = null) =>
            UndeployIndexAsync(new UndeployIndexRequest
            {
                IndexEndpointAsIndexEndpointName = gax::GaxPreconditions.CheckNotNull(indexEndpoint, nameof(indexEndpoint)),
                DeployedIndexId = gax::GaxPreconditions.CheckNotNullOrEmpty(deployedIndexId, nameof(deployedIndexId)),
            }, callSettings);

        /// <summary>
        /// Undeploys an Index from an IndexEndpoint, removing a DeployedIndex from it,
        /// and freeing all resources it's using.
        /// </summary>
        /// <param name="indexEndpoint">
        /// Required. The name of the IndexEndpoint resource from which to undeploy an
        /// Index. Format:
        /// `projects/{project}/locations/{location}/indexEndpoints/{index_endpoint}`
        /// </param>
        /// <param name="deployedIndexId">
        /// Required. The ID of the DeployedIndex to be undeployed from the
        /// IndexEndpoint.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UndeployIndexResponse, UndeployIndexOperationMetadata>> UndeployIndexAsync(IndexEndpointName indexEndpoint, string deployedIndexId, st::CancellationToken cancellationToken) =>
            UndeployIndexAsync(indexEndpoint, deployedIndexId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update an existing DeployedIndex under an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MutateDeployedIndexResponse, MutateDeployedIndexOperationMetadata> MutateDeployedIndex(MutateDeployedIndexRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update an existing DeployedIndex under an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MutateDeployedIndexResponse, MutateDeployedIndexOperationMetadata>> MutateDeployedIndexAsync(MutateDeployedIndexRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update an existing DeployedIndex under an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MutateDeployedIndexResponse, MutateDeployedIndexOperationMetadata>> MutateDeployedIndexAsync(MutateDeployedIndexRequest request, st::CancellationToken cancellationToken) =>
            MutateDeployedIndexAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>MutateDeployedIndex</c>.</summary>
        public virtual lro::OperationsClient MutateDeployedIndexOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>MutateDeployedIndex</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<MutateDeployedIndexResponse, MutateDeployedIndexOperationMetadata> PollOnceMutateDeployedIndex(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MutateDeployedIndexResponse, MutateDeployedIndexOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), MutateDeployedIndexOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>MutateDeployedIndex</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<MutateDeployedIndexResponse, MutateDeployedIndexOperationMetadata>> PollOnceMutateDeployedIndexAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MutateDeployedIndexResponse, MutateDeployedIndexOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), MutateDeployedIndexOperationsClient, callSettings);

        /// <summary>
        /// Update an existing DeployedIndex under an IndexEndpoint.
        /// </summary>
        /// <param name="indexEndpoint">
        /// Required. The name of the IndexEndpoint resource into which to deploy an
        /// Index. Format:
        /// `projects/{project}/locations/{location}/indexEndpoints/{index_endpoint}`
        /// </param>
        /// <param name="deployedIndex">
        /// Required. The DeployedIndex to be updated within the IndexEndpoint.
        /// Currently, the updatable fields are
        /// [DeployedIndex.automatic_resources][google.cloud.aiplatform.v1.DeployedIndex.automatic_resources]
        /// and
        /// [DeployedIndex.dedicated_resources][google.cloud.aiplatform.v1.DeployedIndex.dedicated_resources]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MutateDeployedIndexResponse, MutateDeployedIndexOperationMetadata> MutateDeployedIndex(string indexEndpoint, DeployedIndex deployedIndex, gaxgrpc::CallSettings callSettings = null) =>
            MutateDeployedIndex(new MutateDeployedIndexRequest
            {
                IndexEndpoint = gax::GaxPreconditions.CheckNotNullOrEmpty(indexEndpoint, nameof(indexEndpoint)),
                DeployedIndex = gax::GaxPreconditions.CheckNotNull(deployedIndex, nameof(deployedIndex)),
            }, callSettings);

        /// <summary>
        /// Update an existing DeployedIndex under an IndexEndpoint.
        /// </summary>
        /// <param name="indexEndpoint">
        /// Required. The name of the IndexEndpoint resource into which to deploy an
        /// Index. Format:
        /// `projects/{project}/locations/{location}/indexEndpoints/{index_endpoint}`
        /// </param>
        /// <param name="deployedIndex">
        /// Required. The DeployedIndex to be updated within the IndexEndpoint.
        /// Currently, the updatable fields are
        /// [DeployedIndex.automatic_resources][google.cloud.aiplatform.v1.DeployedIndex.automatic_resources]
        /// and
        /// [DeployedIndex.dedicated_resources][google.cloud.aiplatform.v1.DeployedIndex.dedicated_resources]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MutateDeployedIndexResponse, MutateDeployedIndexOperationMetadata>> MutateDeployedIndexAsync(string indexEndpoint, DeployedIndex deployedIndex, gaxgrpc::CallSettings callSettings = null) =>
            MutateDeployedIndexAsync(new MutateDeployedIndexRequest
            {
                IndexEndpoint = gax::GaxPreconditions.CheckNotNullOrEmpty(indexEndpoint, nameof(indexEndpoint)),
                DeployedIndex = gax::GaxPreconditions.CheckNotNull(deployedIndex, nameof(deployedIndex)),
            }, callSettings);

        /// <summary>
        /// Update an existing DeployedIndex under an IndexEndpoint.
        /// </summary>
        /// <param name="indexEndpoint">
        /// Required. The name of the IndexEndpoint resource into which to deploy an
        /// Index. Format:
        /// `projects/{project}/locations/{location}/indexEndpoints/{index_endpoint}`
        /// </param>
        /// <param name="deployedIndex">
        /// Required. The DeployedIndex to be updated within the IndexEndpoint.
        /// Currently, the updatable fields are
        /// [DeployedIndex.automatic_resources][google.cloud.aiplatform.v1.DeployedIndex.automatic_resources]
        /// and
        /// [DeployedIndex.dedicated_resources][google.cloud.aiplatform.v1.DeployedIndex.dedicated_resources]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MutateDeployedIndexResponse, MutateDeployedIndexOperationMetadata>> MutateDeployedIndexAsync(string indexEndpoint, DeployedIndex deployedIndex, st::CancellationToken cancellationToken) =>
            MutateDeployedIndexAsync(indexEndpoint, deployedIndex, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update an existing DeployedIndex under an IndexEndpoint.
        /// </summary>
        /// <param name="indexEndpoint">
        /// Required. The name of the IndexEndpoint resource into which to deploy an
        /// Index. Format:
        /// `projects/{project}/locations/{location}/indexEndpoints/{index_endpoint}`
        /// </param>
        /// <param name="deployedIndex">
        /// Required. The DeployedIndex to be updated within the IndexEndpoint.
        /// Currently, the updatable fields are
        /// [DeployedIndex.automatic_resources][google.cloud.aiplatform.v1.DeployedIndex.automatic_resources]
        /// and
        /// [DeployedIndex.dedicated_resources][google.cloud.aiplatform.v1.DeployedIndex.dedicated_resources]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MutateDeployedIndexResponse, MutateDeployedIndexOperationMetadata> MutateDeployedIndex(IndexEndpointName indexEndpoint, DeployedIndex deployedIndex, gaxgrpc::CallSettings callSettings = null) =>
            MutateDeployedIndex(new MutateDeployedIndexRequest
            {
                IndexEndpointAsIndexEndpointName = gax::GaxPreconditions.CheckNotNull(indexEndpoint, nameof(indexEndpoint)),
                DeployedIndex = gax::GaxPreconditions.CheckNotNull(deployedIndex, nameof(deployedIndex)),
            }, callSettings);

        /// <summary>
        /// Update an existing DeployedIndex under an IndexEndpoint.
        /// </summary>
        /// <param name="indexEndpoint">
        /// Required. The name of the IndexEndpoint resource into which to deploy an
        /// Index. Format:
        /// `projects/{project}/locations/{location}/indexEndpoints/{index_endpoint}`
        /// </param>
        /// <param name="deployedIndex">
        /// Required. The DeployedIndex to be updated within the IndexEndpoint.
        /// Currently, the updatable fields are
        /// [DeployedIndex.automatic_resources][google.cloud.aiplatform.v1.DeployedIndex.automatic_resources]
        /// and
        /// [DeployedIndex.dedicated_resources][google.cloud.aiplatform.v1.DeployedIndex.dedicated_resources]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MutateDeployedIndexResponse, MutateDeployedIndexOperationMetadata>> MutateDeployedIndexAsync(IndexEndpointName indexEndpoint, DeployedIndex deployedIndex, gaxgrpc::CallSettings callSettings = null) =>
            MutateDeployedIndexAsync(new MutateDeployedIndexRequest
            {
                IndexEndpointAsIndexEndpointName = gax::GaxPreconditions.CheckNotNull(indexEndpoint, nameof(indexEndpoint)),
                DeployedIndex = gax::GaxPreconditions.CheckNotNull(deployedIndex, nameof(deployedIndex)),
            }, callSettings);

        /// <summary>
        /// Update an existing DeployedIndex under an IndexEndpoint.
        /// </summary>
        /// <param name="indexEndpoint">
        /// Required. The name of the IndexEndpoint resource into which to deploy an
        /// Index. Format:
        /// `projects/{project}/locations/{location}/indexEndpoints/{index_endpoint}`
        /// </param>
        /// <param name="deployedIndex">
        /// Required. The DeployedIndex to be updated within the IndexEndpoint.
        /// Currently, the updatable fields are
        /// [DeployedIndex.automatic_resources][google.cloud.aiplatform.v1.DeployedIndex.automatic_resources]
        /// and
        /// [DeployedIndex.dedicated_resources][google.cloud.aiplatform.v1.DeployedIndex.dedicated_resources]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MutateDeployedIndexResponse, MutateDeployedIndexOperationMetadata>> MutateDeployedIndexAsync(IndexEndpointName indexEndpoint, DeployedIndex deployedIndex, st::CancellationToken cancellationToken) =>
            MutateDeployedIndexAsync(indexEndpoint, deployedIndex, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>IndexEndpointService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service for managing Vertex AI's IndexEndpoints.
    /// </remarks>
    public sealed partial class IndexEndpointServiceClientImpl : IndexEndpointServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateIndexEndpointRequest, lro::Operation> _callCreateIndexEndpoint;

        private readonly gaxgrpc::ApiCall<GetIndexEndpointRequest, IndexEndpoint> _callGetIndexEndpoint;

        private readonly gaxgrpc::ApiCall<ListIndexEndpointsRequest, ListIndexEndpointsResponse> _callListIndexEndpoints;

        private readonly gaxgrpc::ApiCall<UpdateIndexEndpointRequest, IndexEndpoint> _callUpdateIndexEndpoint;

        private readonly gaxgrpc::ApiCall<DeleteIndexEndpointRequest, lro::Operation> _callDeleteIndexEndpoint;

        private readonly gaxgrpc::ApiCall<DeployIndexRequest, lro::Operation> _callDeployIndex;

        private readonly gaxgrpc::ApiCall<UndeployIndexRequest, lro::Operation> _callUndeployIndex;

        private readonly gaxgrpc::ApiCall<MutateDeployedIndexRequest, lro::Operation> _callMutateDeployedIndex;

        /// <summary>
        /// Constructs a client wrapper for the IndexEndpointService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="IndexEndpointServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public IndexEndpointServiceClientImpl(IndexEndpointService.IndexEndpointServiceClient grpcClient, IndexEndpointServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            IndexEndpointServiceSettings effectiveSettings = settings ?? IndexEndpointServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateIndexEndpointOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateIndexEndpointOperationsSettings, logger);
            DeleteIndexEndpointOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteIndexEndpointOperationsSettings, logger);
            DeployIndexOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeployIndexOperationsSettings, logger);
            UndeployIndexOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UndeployIndexOperationsSettings, logger);
            MutateDeployedIndexOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.MutateDeployedIndexOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreateIndexEndpoint = clientHelper.BuildApiCall<CreateIndexEndpointRequest, lro::Operation>("CreateIndexEndpoint", grpcClient.CreateIndexEndpointAsync, grpcClient.CreateIndexEndpoint, effectiveSettings.CreateIndexEndpointSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateIndexEndpoint);
            Modify_CreateIndexEndpointApiCall(ref _callCreateIndexEndpoint);
            _callGetIndexEndpoint = clientHelper.BuildApiCall<GetIndexEndpointRequest, IndexEndpoint>("GetIndexEndpoint", grpcClient.GetIndexEndpointAsync, grpcClient.GetIndexEndpoint, effectiveSettings.GetIndexEndpointSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetIndexEndpoint);
            Modify_GetIndexEndpointApiCall(ref _callGetIndexEndpoint);
            _callListIndexEndpoints = clientHelper.BuildApiCall<ListIndexEndpointsRequest, ListIndexEndpointsResponse>("ListIndexEndpoints", grpcClient.ListIndexEndpointsAsync, grpcClient.ListIndexEndpoints, effectiveSettings.ListIndexEndpointsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListIndexEndpoints);
            Modify_ListIndexEndpointsApiCall(ref _callListIndexEndpoints);
            _callUpdateIndexEndpoint = clientHelper.BuildApiCall<UpdateIndexEndpointRequest, IndexEndpoint>("UpdateIndexEndpoint", grpcClient.UpdateIndexEndpointAsync, grpcClient.UpdateIndexEndpoint, effectiveSettings.UpdateIndexEndpointSettings).WithGoogleRequestParam("index_endpoint.name", request => request.IndexEndpoint?.Name);
            Modify_ApiCall(ref _callUpdateIndexEndpoint);
            Modify_UpdateIndexEndpointApiCall(ref _callUpdateIndexEndpoint);
            _callDeleteIndexEndpoint = clientHelper.BuildApiCall<DeleteIndexEndpointRequest, lro::Operation>("DeleteIndexEndpoint", grpcClient.DeleteIndexEndpointAsync, grpcClient.DeleteIndexEndpoint, effectiveSettings.DeleteIndexEndpointSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteIndexEndpoint);
            Modify_DeleteIndexEndpointApiCall(ref _callDeleteIndexEndpoint);
            _callDeployIndex = clientHelper.BuildApiCall<DeployIndexRequest, lro::Operation>("DeployIndex", grpcClient.DeployIndexAsync, grpcClient.DeployIndex, effectiveSettings.DeployIndexSettings).WithGoogleRequestParam("index_endpoint", request => request.IndexEndpoint);
            Modify_ApiCall(ref _callDeployIndex);
            Modify_DeployIndexApiCall(ref _callDeployIndex);
            _callUndeployIndex = clientHelper.BuildApiCall<UndeployIndexRequest, lro::Operation>("UndeployIndex", grpcClient.UndeployIndexAsync, grpcClient.UndeployIndex, effectiveSettings.UndeployIndexSettings).WithGoogleRequestParam("index_endpoint", request => request.IndexEndpoint);
            Modify_ApiCall(ref _callUndeployIndex);
            Modify_UndeployIndexApiCall(ref _callUndeployIndex);
            _callMutateDeployedIndex = clientHelper.BuildApiCall<MutateDeployedIndexRequest, lro::Operation>("MutateDeployedIndex", grpcClient.MutateDeployedIndexAsync, grpcClient.MutateDeployedIndex, effectiveSettings.MutateDeployedIndexSettings).WithGoogleRequestParam("index_endpoint", request => request.IndexEndpoint);
            Modify_ApiCall(ref _callMutateDeployedIndex);
            Modify_MutateDeployedIndexApiCall(ref _callMutateDeployedIndex);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateIndexEndpointApiCall(ref gaxgrpc::ApiCall<CreateIndexEndpointRequest, lro::Operation> call);

        partial void Modify_GetIndexEndpointApiCall(ref gaxgrpc::ApiCall<GetIndexEndpointRequest, IndexEndpoint> call);

        partial void Modify_ListIndexEndpointsApiCall(ref gaxgrpc::ApiCall<ListIndexEndpointsRequest, ListIndexEndpointsResponse> call);

        partial void Modify_UpdateIndexEndpointApiCall(ref gaxgrpc::ApiCall<UpdateIndexEndpointRequest, IndexEndpoint> call);

        partial void Modify_DeleteIndexEndpointApiCall(ref gaxgrpc::ApiCall<DeleteIndexEndpointRequest, lro::Operation> call);

        partial void Modify_DeployIndexApiCall(ref gaxgrpc::ApiCall<DeployIndexRequest, lro::Operation> call);

        partial void Modify_UndeployIndexApiCall(ref gaxgrpc::ApiCall<UndeployIndexRequest, lro::Operation> call);

        partial void Modify_MutateDeployedIndexApiCall(ref gaxgrpc::ApiCall<MutateDeployedIndexRequest, lro::Operation> call);

        partial void OnConstruction(IndexEndpointService.IndexEndpointServiceClient grpcClient, IndexEndpointServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC IndexEndpointService client</summary>
        public override IndexEndpointService.IndexEndpointServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateIndexEndpointRequest(ref CreateIndexEndpointRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIndexEndpointRequest(ref GetIndexEndpointRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListIndexEndpointsRequest(ref ListIndexEndpointsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateIndexEndpointRequest(ref UpdateIndexEndpointRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteIndexEndpointRequest(ref DeleteIndexEndpointRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeployIndexRequest(ref DeployIndexRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UndeployIndexRequest(ref UndeployIndexRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateDeployedIndexRequest(ref MutateDeployedIndexRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateIndexEndpoint</c>.</summary>
        public override lro::OperationsClient CreateIndexEndpointOperationsClient { get; }

        /// <summary>
        /// Creates an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<IndexEndpoint, CreateIndexEndpointOperationMetadata> CreateIndexEndpoint(CreateIndexEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateIndexEndpointRequest(ref request, ref callSettings);
            return new lro::Operation<IndexEndpoint, CreateIndexEndpointOperationMetadata>(_callCreateIndexEndpoint.Sync(request, callSettings), CreateIndexEndpointOperationsClient);
        }

        /// <summary>
        /// Creates an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<IndexEndpoint, CreateIndexEndpointOperationMetadata>> CreateIndexEndpointAsync(CreateIndexEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateIndexEndpointRequest(ref request, ref callSettings);
            return new lro::Operation<IndexEndpoint, CreateIndexEndpointOperationMetadata>(await _callCreateIndexEndpoint.Async(request, callSettings).ConfigureAwait(false), CreateIndexEndpointOperationsClient);
        }

        /// <summary>
        /// Gets an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override IndexEndpoint GetIndexEndpoint(GetIndexEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIndexEndpointRequest(ref request, ref callSettings);
            return _callGetIndexEndpoint.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<IndexEndpoint> GetIndexEndpointAsync(GetIndexEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIndexEndpointRequest(ref request, ref callSettings);
            return _callGetIndexEndpoint.Async(request, callSettings);
        }

        /// <summary>
        /// Lists IndexEndpoints in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="IndexEndpoint"/> resources.</returns>
        public override gax::PagedEnumerable<ListIndexEndpointsResponse, IndexEndpoint> ListIndexEndpoints(ListIndexEndpointsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListIndexEndpointsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListIndexEndpointsRequest, ListIndexEndpointsResponse, IndexEndpoint>(_callListIndexEndpoints, request, callSettings);
        }

        /// <summary>
        /// Lists IndexEndpoints in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="IndexEndpoint"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListIndexEndpointsResponse, IndexEndpoint> ListIndexEndpointsAsync(ListIndexEndpointsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListIndexEndpointsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListIndexEndpointsRequest, ListIndexEndpointsResponse, IndexEndpoint>(_callListIndexEndpoints, request, callSettings);
        }

        /// <summary>
        /// Updates an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override IndexEndpoint UpdateIndexEndpoint(UpdateIndexEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateIndexEndpointRequest(ref request, ref callSettings);
            return _callUpdateIndexEndpoint.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<IndexEndpoint> UpdateIndexEndpointAsync(UpdateIndexEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateIndexEndpointRequest(ref request, ref callSettings);
            return _callUpdateIndexEndpoint.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteIndexEndpoint</c>.</summary>
        public override lro::OperationsClient DeleteIndexEndpointOperationsClient { get; }

        /// <summary>
        /// Deletes an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteIndexEndpoint(DeleteIndexEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteIndexEndpointRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(_callDeleteIndexEndpoint.Sync(request, callSettings), DeleteIndexEndpointOperationsClient);
        }

        /// <summary>
        /// Deletes an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteIndexEndpointAsync(DeleteIndexEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteIndexEndpointRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(await _callDeleteIndexEndpoint.Async(request, callSettings).ConfigureAwait(false), DeleteIndexEndpointOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeployIndex</c>.</summary>
        public override lro::OperationsClient DeployIndexOperationsClient { get; }

        /// <summary>
        /// Deploys an Index into this IndexEndpoint, creating a DeployedIndex within
        /// it.
        /// Only non-empty Indexes can be deployed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DeployIndexResponse, DeployIndexOperationMetadata> DeployIndex(DeployIndexRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeployIndexRequest(ref request, ref callSettings);
            return new lro::Operation<DeployIndexResponse, DeployIndexOperationMetadata>(_callDeployIndex.Sync(request, callSettings), DeployIndexOperationsClient);
        }

        /// <summary>
        /// Deploys an Index into this IndexEndpoint, creating a DeployedIndex within
        /// it.
        /// Only non-empty Indexes can be deployed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DeployIndexResponse, DeployIndexOperationMetadata>> DeployIndexAsync(DeployIndexRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeployIndexRequest(ref request, ref callSettings);
            return new lro::Operation<DeployIndexResponse, DeployIndexOperationMetadata>(await _callDeployIndex.Async(request, callSettings).ConfigureAwait(false), DeployIndexOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UndeployIndex</c>.</summary>
        public override lro::OperationsClient UndeployIndexOperationsClient { get; }

        /// <summary>
        /// Undeploys an Index from an IndexEndpoint, removing a DeployedIndex from it,
        /// and freeing all resources it's using.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<UndeployIndexResponse, UndeployIndexOperationMetadata> UndeployIndex(UndeployIndexRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeployIndexRequest(ref request, ref callSettings);
            return new lro::Operation<UndeployIndexResponse, UndeployIndexOperationMetadata>(_callUndeployIndex.Sync(request, callSettings), UndeployIndexOperationsClient);
        }

        /// <summary>
        /// Undeploys an Index from an IndexEndpoint, removing a DeployedIndex from it,
        /// and freeing all resources it's using.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<UndeployIndexResponse, UndeployIndexOperationMetadata>> UndeployIndexAsync(UndeployIndexRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeployIndexRequest(ref request, ref callSettings);
            return new lro::Operation<UndeployIndexResponse, UndeployIndexOperationMetadata>(await _callUndeployIndex.Async(request, callSettings).ConfigureAwait(false), UndeployIndexOperationsClient);
        }

        /// <summary>The long-running operations client for <c>MutateDeployedIndex</c>.</summary>
        public override lro::OperationsClient MutateDeployedIndexOperationsClient { get; }

        /// <summary>
        /// Update an existing DeployedIndex under an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<MutateDeployedIndexResponse, MutateDeployedIndexOperationMetadata> MutateDeployedIndex(MutateDeployedIndexRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateDeployedIndexRequest(ref request, ref callSettings);
            return new lro::Operation<MutateDeployedIndexResponse, MutateDeployedIndexOperationMetadata>(_callMutateDeployedIndex.Sync(request, callSettings), MutateDeployedIndexOperationsClient);
        }

        /// <summary>
        /// Update an existing DeployedIndex under an IndexEndpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<MutateDeployedIndexResponse, MutateDeployedIndexOperationMetadata>> MutateDeployedIndexAsync(MutateDeployedIndexRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateDeployedIndexRequest(ref request, ref callSettings);
            return new lro::Operation<MutateDeployedIndexResponse, MutateDeployedIndexOperationMetadata>(await _callMutateDeployedIndex.Async(request, callSettings).ConfigureAwait(false), MutateDeployedIndexOperationsClient);
        }
    }

    public partial class ListIndexEndpointsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListIndexEndpointsResponse : gaxgrpc::IPageResponse<IndexEndpoint>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<IndexEndpoint> GetEnumerator() => IndexEndpoints.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class IndexEndpointService
    {
        public partial class IndexEndpointServiceClient
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

    public static partial class IndexEndpointService
    {
        public partial class IndexEndpointServiceClient
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
