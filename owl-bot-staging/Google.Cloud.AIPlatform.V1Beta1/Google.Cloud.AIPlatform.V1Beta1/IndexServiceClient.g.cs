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
    /// <summary>Settings for <see cref="IndexServiceClient"/> instances.</summary>
    public sealed partial class IndexServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="IndexServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="IndexServiceSettings"/>.</returns>
        public static IndexServiceSettings GetDefault() => new IndexServiceSettings();

        /// <summary>Constructs a new <see cref="IndexServiceSettings"/> object with default settings.</summary>
        public IndexServiceSettings()
        {
        }

        private IndexServiceSettings(IndexServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateIndexSettings = existing.CreateIndexSettings;
            CreateIndexOperationsSettings = existing.CreateIndexOperationsSettings.Clone();
            GetIndexSettings = existing.GetIndexSettings;
            ListIndexesSettings = existing.ListIndexesSettings;
            UpdateIndexSettings = existing.UpdateIndexSettings;
            UpdateIndexOperationsSettings = existing.UpdateIndexOperationsSettings.Clone();
            DeleteIndexSettings = existing.DeleteIndexSettings;
            DeleteIndexOperationsSettings = existing.DeleteIndexOperationsSettings.Clone();
            UpsertDatapointsSettings = existing.UpsertDatapointsSettings;
            RemoveDatapointsSettings = existing.RemoveDatapointsSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(IndexServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IndexServiceClient.CreateIndex</c> and <c>IndexServiceClient.CreateIndexAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateIndexSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>IndexServiceClient.CreateIndex</c> and
        /// <c>IndexServiceClient.CreateIndexAsync</c>.
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
        public lro::OperationsSettings CreateIndexOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>IndexServiceClient.GetIndex</c>
        ///  and <c>IndexServiceClient.GetIndexAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIndexSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IndexServiceClient.ListIndexes</c> and <c>IndexServiceClient.ListIndexesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListIndexesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IndexServiceClient.UpdateIndex</c> and <c>IndexServiceClient.UpdateIndexAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateIndexSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>IndexServiceClient.UpdateIndex</c> and
        /// <c>IndexServiceClient.UpdateIndexAsync</c>.
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
        public lro::OperationsSettings UpdateIndexOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IndexServiceClient.DeleteIndex</c> and <c>IndexServiceClient.DeleteIndexAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteIndexSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>IndexServiceClient.DeleteIndex</c> and
        /// <c>IndexServiceClient.DeleteIndexAsync</c>.
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
        public lro::OperationsSettings DeleteIndexOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IndexServiceClient.UpsertDatapoints</c> and <c>IndexServiceClient.UpsertDatapointsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpsertDatapointsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IndexServiceClient.RemoveDatapoints</c> and <c>IndexServiceClient.RemoveDatapointsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RemoveDatapointsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="IndexServiceSettings"/> object.</returns>
        public IndexServiceSettings Clone() => new IndexServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="IndexServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class IndexServiceClientBuilder : gaxgrpc::ClientBuilderBase<IndexServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public IndexServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public IndexServiceClientBuilder() : base(IndexServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref IndexServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<IndexServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override IndexServiceClient Build()
        {
            IndexServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<IndexServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<IndexServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private IndexServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return IndexServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<IndexServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return IndexServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => IndexServiceClient.ChannelPool;
    }

    /// <summary>IndexService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service for creating and managing Vertex AI's Index resources.
    /// </remarks>
    public abstract partial class IndexServiceClient
    {
        /// <summary>
        /// The default endpoint for the IndexService service, which is a host of "aiplatform.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "aiplatform.googleapis.com:443";

        /// <summary>The default IndexService scopes.</summary>
        /// <remarks>
        /// The default IndexService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(IndexService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="IndexServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="IndexServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="IndexServiceClient"/>.</returns>
        public static stt::Task<IndexServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new IndexServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="IndexServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="IndexServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="IndexServiceClient"/>.</returns>
        public static IndexServiceClient Create() => new IndexServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="IndexServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="IndexServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="IndexServiceClient"/>.</returns>
        internal static IndexServiceClient Create(grpccore::CallInvoker callInvoker, IndexServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            IndexService.IndexServiceClient grpcClient = new IndexService.IndexServiceClient(callInvoker);
            return new IndexServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC IndexService client</summary>
        public virtual IndexService.IndexServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an Index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Index, CreateIndexOperationMetadata> CreateIndex(CreateIndexRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an Index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Index, CreateIndexOperationMetadata>> CreateIndexAsync(CreateIndexRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an Index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Index, CreateIndexOperationMetadata>> CreateIndexAsync(CreateIndexRequest request, st::CancellationToken cancellationToken) =>
            CreateIndexAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateIndex</c>.</summary>
        public virtual lro::OperationsClient CreateIndexOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateIndex</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Index, CreateIndexOperationMetadata> PollOnceCreateIndex(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Index, CreateIndexOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateIndexOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateIndex</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Index, CreateIndexOperationMetadata>> PollOnceCreateIndexAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Index, CreateIndexOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateIndexOperationsClient, callSettings);

        /// <summary>
        /// Creates an Index.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the Index in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="index">
        /// Required. The Index to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Index, CreateIndexOperationMetadata> CreateIndex(string parent, Index index, gaxgrpc::CallSettings callSettings = null) =>
            CreateIndex(new CreateIndexRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Index = gax::GaxPreconditions.CheckNotNull(index, nameof(index)),
            }, callSettings);

        /// <summary>
        /// Creates an Index.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the Index in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="index">
        /// Required. The Index to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Index, CreateIndexOperationMetadata>> CreateIndexAsync(string parent, Index index, gaxgrpc::CallSettings callSettings = null) =>
            CreateIndexAsync(new CreateIndexRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Index = gax::GaxPreconditions.CheckNotNull(index, nameof(index)),
            }, callSettings);

        /// <summary>
        /// Creates an Index.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the Index in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="index">
        /// Required. The Index to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Index, CreateIndexOperationMetadata>> CreateIndexAsync(string parent, Index index, st::CancellationToken cancellationToken) =>
            CreateIndexAsync(parent, index, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an Index.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the Index in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="index">
        /// Required. The Index to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Index, CreateIndexOperationMetadata> CreateIndex(gagr::LocationName parent, Index index, gaxgrpc::CallSettings callSettings = null) =>
            CreateIndex(new CreateIndexRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Index = gax::GaxPreconditions.CheckNotNull(index, nameof(index)),
            }, callSettings);

        /// <summary>
        /// Creates an Index.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the Index in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="index">
        /// Required. The Index to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Index, CreateIndexOperationMetadata>> CreateIndexAsync(gagr::LocationName parent, Index index, gaxgrpc::CallSettings callSettings = null) =>
            CreateIndexAsync(new CreateIndexRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Index = gax::GaxPreconditions.CheckNotNull(index, nameof(index)),
            }, callSettings);

        /// <summary>
        /// Creates an Index.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the Index in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="index">
        /// Required. The Index to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Index, CreateIndexOperationMetadata>> CreateIndexAsync(gagr::LocationName parent, Index index, st::CancellationToken cancellationToken) =>
            CreateIndexAsync(parent, index, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an Index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Index GetIndex(GetIndexRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an Index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Index> GetIndexAsync(GetIndexRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an Index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Index> GetIndexAsync(GetIndexRequest request, st::CancellationToken cancellationToken) =>
            GetIndexAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an Index.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Index resource.
        /// Format:
        /// `projects/{project}/locations/{location}/indexes/{index}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Index GetIndex(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetIndex(new GetIndexRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an Index.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Index resource.
        /// Format:
        /// `projects/{project}/locations/{location}/indexes/{index}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Index> GetIndexAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetIndexAsync(new GetIndexRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an Index.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Index resource.
        /// Format:
        /// `projects/{project}/locations/{location}/indexes/{index}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Index> GetIndexAsync(string name, st::CancellationToken cancellationToken) =>
            GetIndexAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an Index.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Index resource.
        /// Format:
        /// `projects/{project}/locations/{location}/indexes/{index}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Index GetIndex(IndexName name, gaxgrpc::CallSettings callSettings = null) =>
            GetIndex(new GetIndexRequest
            {
                IndexName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an Index.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Index resource.
        /// Format:
        /// `projects/{project}/locations/{location}/indexes/{index}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Index> GetIndexAsync(IndexName name, gaxgrpc::CallSettings callSettings = null) =>
            GetIndexAsync(new GetIndexRequest
            {
                IndexName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an Index.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Index resource.
        /// Format:
        /// `projects/{project}/locations/{location}/indexes/{index}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Index> GetIndexAsync(IndexName name, st::CancellationToken cancellationToken) =>
            GetIndexAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Indexes in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Index"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListIndexesResponse, Index> ListIndexes(ListIndexesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Indexes in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Index"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListIndexesResponse, Index> ListIndexesAsync(ListIndexesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Indexes in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location from which to list the Indexes.
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
        /// <returns>A pageable sequence of <see cref="Index"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListIndexesResponse, Index> ListIndexes(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListIndexesRequest request = new ListIndexesRequest
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
            return ListIndexes(request, callSettings);
        }

        /// <summary>
        /// Lists Indexes in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location from which to list the Indexes.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Index"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListIndexesResponse, Index> ListIndexesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListIndexesRequest request = new ListIndexesRequest
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
            return ListIndexesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Indexes in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location from which to list the Indexes.
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
        /// <returns>A pageable sequence of <see cref="Index"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListIndexesResponse, Index> ListIndexes(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListIndexesRequest request = new ListIndexesRequest
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
            return ListIndexes(request, callSettings);
        }

        /// <summary>
        /// Lists Indexes in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location from which to list the Indexes.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Index"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListIndexesResponse, Index> ListIndexesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListIndexesRequest request = new ListIndexesRequest
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
            return ListIndexesAsync(request, callSettings);
        }

        /// <summary>
        /// Updates an Index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Index, UpdateIndexOperationMetadata> UpdateIndex(UpdateIndexRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an Index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Index, UpdateIndexOperationMetadata>> UpdateIndexAsync(UpdateIndexRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an Index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Index, UpdateIndexOperationMetadata>> UpdateIndexAsync(UpdateIndexRequest request, st::CancellationToken cancellationToken) =>
            UpdateIndexAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateIndex</c>.</summary>
        public virtual lro::OperationsClient UpdateIndexOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateIndex</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Index, UpdateIndexOperationMetadata> PollOnceUpdateIndex(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Index, UpdateIndexOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateIndexOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateIndex</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Index, UpdateIndexOperationMetadata>> PollOnceUpdateIndexAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Index, UpdateIndexOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateIndexOperationsClient, callSettings);

        /// <summary>
        /// Updates an Index.
        /// </summary>
        /// <param name="index">
        /// Required. The Index which updates the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// The update mask applies to the resource.
        /// For the `FieldMask` definition, see
        /// [google.protobuf.FieldMask][google.protobuf.FieldMask].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Index, UpdateIndexOperationMetadata> UpdateIndex(Index index, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateIndex(new UpdateIndexRequest
            {
                Index = gax::GaxPreconditions.CheckNotNull(index, nameof(index)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an Index.
        /// </summary>
        /// <param name="index">
        /// Required. The Index which updates the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// The update mask applies to the resource.
        /// For the `FieldMask` definition, see
        /// [google.protobuf.FieldMask][google.protobuf.FieldMask].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Index, UpdateIndexOperationMetadata>> UpdateIndexAsync(Index index, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateIndexAsync(new UpdateIndexRequest
            {
                Index = gax::GaxPreconditions.CheckNotNull(index, nameof(index)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an Index.
        /// </summary>
        /// <param name="index">
        /// Required. The Index which updates the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// The update mask applies to the resource.
        /// For the `FieldMask` definition, see
        /// [google.protobuf.FieldMask][google.protobuf.FieldMask].
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Index, UpdateIndexOperationMetadata>> UpdateIndexAsync(Index index, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateIndexAsync(index, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an Index.
        /// An Index can only be deleted when all its
        /// [DeployedIndexes][google.cloud.aiplatform.v1beta1.Index.deployed_indexes]
        /// had been undeployed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteIndex(DeleteIndexRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an Index.
        /// An Index can only be deleted when all its
        /// [DeployedIndexes][google.cloud.aiplatform.v1beta1.Index.deployed_indexes]
        /// had been undeployed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteIndexAsync(DeleteIndexRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an Index.
        /// An Index can only be deleted when all its
        /// [DeployedIndexes][google.cloud.aiplatform.v1beta1.Index.deployed_indexes]
        /// had been undeployed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteIndexAsync(DeleteIndexRequest request, st::CancellationToken cancellationToken) =>
            DeleteIndexAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteIndex</c>.</summary>
        public virtual lro::OperationsClient DeleteIndexOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteIndex</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> PollOnceDeleteIndex(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteIndexOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteIndex</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> PollOnceDeleteIndexAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteIndexOperationsClient, callSettings);

        /// <summary>
        /// Deletes an Index.
        /// An Index can only be deleted when all its
        /// [DeployedIndexes][google.cloud.aiplatform.v1beta1.Index.deployed_indexes]
        /// had been undeployed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Index resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/indexes/{index}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteIndex(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIndex(new DeleteIndexRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an Index.
        /// An Index can only be deleted when all its
        /// [DeployedIndexes][google.cloud.aiplatform.v1beta1.Index.deployed_indexes]
        /// had been undeployed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Index resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/indexes/{index}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteIndexAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIndexAsync(new DeleteIndexRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an Index.
        /// An Index can only be deleted when all its
        /// [DeployedIndexes][google.cloud.aiplatform.v1beta1.Index.deployed_indexes]
        /// had been undeployed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Index resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/indexes/{index}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteIndexAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteIndexAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an Index.
        /// An Index can only be deleted when all its
        /// [DeployedIndexes][google.cloud.aiplatform.v1beta1.Index.deployed_indexes]
        /// had been undeployed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Index resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/indexes/{index}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteIndex(IndexName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIndex(new DeleteIndexRequest
            {
                IndexName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an Index.
        /// An Index can only be deleted when all its
        /// [DeployedIndexes][google.cloud.aiplatform.v1beta1.Index.deployed_indexes]
        /// had been undeployed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Index resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/indexes/{index}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteIndexAsync(IndexName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIndexAsync(new DeleteIndexRequest
            {
                IndexName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an Index.
        /// An Index can only be deleted when all its
        /// [DeployedIndexes][google.cloud.aiplatform.v1beta1.Index.deployed_indexes]
        /// had been undeployed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Index resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/indexes/{index}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteIndexAsync(IndexName name, st::CancellationToken cancellationToken) =>
            DeleteIndexAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Add/update Datapoints into an Index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UpsertDatapointsResponse UpsertDatapoints(UpsertDatapointsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Add/update Datapoints into an Index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UpsertDatapointsResponse> UpsertDatapointsAsync(UpsertDatapointsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Add/update Datapoints into an Index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UpsertDatapointsResponse> UpsertDatapointsAsync(UpsertDatapointsRequest request, st::CancellationToken cancellationToken) =>
            UpsertDatapointsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Remove Datapoints from an Index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RemoveDatapointsResponse RemoveDatapoints(RemoveDatapointsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Remove Datapoints from an Index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveDatapointsResponse> RemoveDatapointsAsync(RemoveDatapointsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Remove Datapoints from an Index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveDatapointsResponse> RemoveDatapointsAsync(RemoveDatapointsRequest request, st::CancellationToken cancellationToken) =>
            RemoveDatapointsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>IndexService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service for creating and managing Vertex AI's Index resources.
    /// </remarks>
    public sealed partial class IndexServiceClientImpl : IndexServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateIndexRequest, lro::Operation> _callCreateIndex;

        private readonly gaxgrpc::ApiCall<GetIndexRequest, Index> _callGetIndex;

        private readonly gaxgrpc::ApiCall<ListIndexesRequest, ListIndexesResponse> _callListIndexes;

        private readonly gaxgrpc::ApiCall<UpdateIndexRequest, lro::Operation> _callUpdateIndex;

        private readonly gaxgrpc::ApiCall<DeleteIndexRequest, lro::Operation> _callDeleteIndex;

        private readonly gaxgrpc::ApiCall<UpsertDatapointsRequest, UpsertDatapointsResponse> _callUpsertDatapoints;

        private readonly gaxgrpc::ApiCall<RemoveDatapointsRequest, RemoveDatapointsResponse> _callRemoveDatapoints;

        /// <summary>
        /// Constructs a client wrapper for the IndexService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="IndexServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public IndexServiceClientImpl(IndexService.IndexServiceClient grpcClient, IndexServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            IndexServiceSettings effectiveSettings = settings ?? IndexServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateIndexOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateIndexOperationsSettings, logger);
            UpdateIndexOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateIndexOperationsSettings, logger);
            DeleteIndexOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteIndexOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreateIndex = clientHelper.BuildApiCall<CreateIndexRequest, lro::Operation>("CreateIndex", grpcClient.CreateIndexAsync, grpcClient.CreateIndex, effectiveSettings.CreateIndexSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateIndex);
            Modify_CreateIndexApiCall(ref _callCreateIndex);
            _callGetIndex = clientHelper.BuildApiCall<GetIndexRequest, Index>("GetIndex", grpcClient.GetIndexAsync, grpcClient.GetIndex, effectiveSettings.GetIndexSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetIndex);
            Modify_GetIndexApiCall(ref _callGetIndex);
            _callListIndexes = clientHelper.BuildApiCall<ListIndexesRequest, ListIndexesResponse>("ListIndexes", grpcClient.ListIndexesAsync, grpcClient.ListIndexes, effectiveSettings.ListIndexesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListIndexes);
            Modify_ListIndexesApiCall(ref _callListIndexes);
            _callUpdateIndex = clientHelper.BuildApiCall<UpdateIndexRequest, lro::Operation>("UpdateIndex", grpcClient.UpdateIndexAsync, grpcClient.UpdateIndex, effectiveSettings.UpdateIndexSettings).WithGoogleRequestParam("index.name", request => request.Index?.Name);
            Modify_ApiCall(ref _callUpdateIndex);
            Modify_UpdateIndexApiCall(ref _callUpdateIndex);
            _callDeleteIndex = clientHelper.BuildApiCall<DeleteIndexRequest, lro::Operation>("DeleteIndex", grpcClient.DeleteIndexAsync, grpcClient.DeleteIndex, effectiveSettings.DeleteIndexSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteIndex);
            Modify_DeleteIndexApiCall(ref _callDeleteIndex);
            _callUpsertDatapoints = clientHelper.BuildApiCall<UpsertDatapointsRequest, UpsertDatapointsResponse>("UpsertDatapoints", grpcClient.UpsertDatapointsAsync, grpcClient.UpsertDatapoints, effectiveSettings.UpsertDatapointsSettings).WithGoogleRequestParam("index", request => request.Index);
            Modify_ApiCall(ref _callUpsertDatapoints);
            Modify_UpsertDatapointsApiCall(ref _callUpsertDatapoints);
            _callRemoveDatapoints = clientHelper.BuildApiCall<RemoveDatapointsRequest, RemoveDatapointsResponse>("RemoveDatapoints", grpcClient.RemoveDatapointsAsync, grpcClient.RemoveDatapoints, effectiveSettings.RemoveDatapointsSettings).WithGoogleRequestParam("index", request => request.Index);
            Modify_ApiCall(ref _callRemoveDatapoints);
            Modify_RemoveDatapointsApiCall(ref _callRemoveDatapoints);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateIndexApiCall(ref gaxgrpc::ApiCall<CreateIndexRequest, lro::Operation> call);

        partial void Modify_GetIndexApiCall(ref gaxgrpc::ApiCall<GetIndexRequest, Index> call);

        partial void Modify_ListIndexesApiCall(ref gaxgrpc::ApiCall<ListIndexesRequest, ListIndexesResponse> call);

        partial void Modify_UpdateIndexApiCall(ref gaxgrpc::ApiCall<UpdateIndexRequest, lro::Operation> call);

        partial void Modify_DeleteIndexApiCall(ref gaxgrpc::ApiCall<DeleteIndexRequest, lro::Operation> call);

        partial void Modify_UpsertDatapointsApiCall(ref gaxgrpc::ApiCall<UpsertDatapointsRequest, UpsertDatapointsResponse> call);

        partial void Modify_RemoveDatapointsApiCall(ref gaxgrpc::ApiCall<RemoveDatapointsRequest, RemoveDatapointsResponse> call);

        partial void OnConstruction(IndexService.IndexServiceClient grpcClient, IndexServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC IndexService client</summary>
        public override IndexService.IndexServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateIndexRequest(ref CreateIndexRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIndexRequest(ref GetIndexRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListIndexesRequest(ref ListIndexesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateIndexRequest(ref UpdateIndexRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteIndexRequest(ref DeleteIndexRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpsertDatapointsRequest(ref UpsertDatapointsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RemoveDatapointsRequest(ref RemoveDatapointsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateIndex</c>.</summary>
        public override lro::OperationsClient CreateIndexOperationsClient { get; }

        /// <summary>
        /// Creates an Index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Index, CreateIndexOperationMetadata> CreateIndex(CreateIndexRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateIndexRequest(ref request, ref callSettings);
            return new lro::Operation<Index, CreateIndexOperationMetadata>(_callCreateIndex.Sync(request, callSettings), CreateIndexOperationsClient);
        }

        /// <summary>
        /// Creates an Index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Index, CreateIndexOperationMetadata>> CreateIndexAsync(CreateIndexRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateIndexRequest(ref request, ref callSettings);
            return new lro::Operation<Index, CreateIndexOperationMetadata>(await _callCreateIndex.Async(request, callSettings).ConfigureAwait(false), CreateIndexOperationsClient);
        }

        /// <summary>
        /// Gets an Index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Index GetIndex(GetIndexRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIndexRequest(ref request, ref callSettings);
            return _callGetIndex.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an Index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Index> GetIndexAsync(GetIndexRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIndexRequest(ref request, ref callSettings);
            return _callGetIndex.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Indexes in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Index"/> resources.</returns>
        public override gax::PagedEnumerable<ListIndexesResponse, Index> ListIndexes(ListIndexesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListIndexesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListIndexesRequest, ListIndexesResponse, Index>(_callListIndexes, request, callSettings);
        }

        /// <summary>
        /// Lists Indexes in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Index"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListIndexesResponse, Index> ListIndexesAsync(ListIndexesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListIndexesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListIndexesRequest, ListIndexesResponse, Index>(_callListIndexes, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateIndex</c>.</summary>
        public override lro::OperationsClient UpdateIndexOperationsClient { get; }

        /// <summary>
        /// Updates an Index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Index, UpdateIndexOperationMetadata> UpdateIndex(UpdateIndexRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateIndexRequest(ref request, ref callSettings);
            return new lro::Operation<Index, UpdateIndexOperationMetadata>(_callUpdateIndex.Sync(request, callSettings), UpdateIndexOperationsClient);
        }

        /// <summary>
        /// Updates an Index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Index, UpdateIndexOperationMetadata>> UpdateIndexAsync(UpdateIndexRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateIndexRequest(ref request, ref callSettings);
            return new lro::Operation<Index, UpdateIndexOperationMetadata>(await _callUpdateIndex.Async(request, callSettings).ConfigureAwait(false), UpdateIndexOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteIndex</c>.</summary>
        public override lro::OperationsClient DeleteIndexOperationsClient { get; }

        /// <summary>
        /// Deletes an Index.
        /// An Index can only be deleted when all its
        /// [DeployedIndexes][google.cloud.aiplatform.v1beta1.Index.deployed_indexes]
        /// had been undeployed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteIndex(DeleteIndexRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteIndexRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(_callDeleteIndex.Sync(request, callSettings), DeleteIndexOperationsClient);
        }

        /// <summary>
        /// Deletes an Index.
        /// An Index can only be deleted when all its
        /// [DeployedIndexes][google.cloud.aiplatform.v1beta1.Index.deployed_indexes]
        /// had been undeployed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteIndexAsync(DeleteIndexRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteIndexRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(await _callDeleteIndex.Async(request, callSettings).ConfigureAwait(false), DeleteIndexOperationsClient);
        }

        /// <summary>
        /// Add/update Datapoints into an Index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UpsertDatapointsResponse UpsertDatapoints(UpsertDatapointsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpsertDatapointsRequest(ref request, ref callSettings);
            return _callUpsertDatapoints.Sync(request, callSettings);
        }

        /// <summary>
        /// Add/update Datapoints into an Index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UpsertDatapointsResponse> UpsertDatapointsAsync(UpsertDatapointsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpsertDatapointsRequest(ref request, ref callSettings);
            return _callUpsertDatapoints.Async(request, callSettings);
        }

        /// <summary>
        /// Remove Datapoints from an Index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RemoveDatapointsResponse RemoveDatapoints(RemoveDatapointsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveDatapointsRequest(ref request, ref callSettings);
            return _callRemoveDatapoints.Sync(request, callSettings);
        }

        /// <summary>
        /// Remove Datapoints from an Index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RemoveDatapointsResponse> RemoveDatapointsAsync(RemoveDatapointsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveDatapointsRequest(ref request, ref callSettings);
            return _callRemoveDatapoints.Async(request, callSettings);
        }
    }

    public partial class ListIndexesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListIndexesResponse : gaxgrpc::IPageResponse<Index>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Index> GetEnumerator() => Indexes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class IndexService
    {
        public partial class IndexServiceClient
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

    public static partial class IndexService
    {
        public partial class IndexServiceClient
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
