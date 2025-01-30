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

namespace Google.Cloud.Dataproc.V1
{
    /// <summary>Settings for <see cref="BatchControllerClient"/> instances.</summary>
    public sealed partial class BatchControllerSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="BatchControllerSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="BatchControllerSettings"/>.</returns>
        public static BatchControllerSettings GetDefault() => new BatchControllerSettings();

        /// <summary>Constructs a new <see cref="BatchControllerSettings"/> object with default settings.</summary>
        public BatchControllerSettings()
        {
        }

        private BatchControllerSettings(BatchControllerSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateBatchSettings = existing.CreateBatchSettings;
            CreateBatchOperationsSettings = existing.CreateBatchOperationsSettings.Clone();
            GetBatchSettings = existing.GetBatchSettings;
            ListBatchesSettings = existing.ListBatchesSettings;
            DeleteBatchSettings = existing.DeleteBatchSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(BatchControllerSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BatchControllerClient.CreateBatch</c> and <c>BatchControllerClient.CreateBatchAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateBatchSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>BatchControllerClient.CreateBatch</c> and
        /// <c>BatchControllerClient.CreateBatchAsync</c>.
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
        public lro::OperationsSettings CreateBatchOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BatchControllerClient.GetBatch</c> and <c>BatchControllerClient.GetBatchAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetBatchSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BatchControllerClient.ListBatches</c> and <c>BatchControllerClient.ListBatchesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListBatchesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BatchControllerClient.DeleteBatch</c> and <c>BatchControllerClient.DeleteBatchAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteBatchSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="BatchControllerSettings"/> object.</returns>
        public BatchControllerSettings Clone() => new BatchControllerSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="BatchControllerClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class BatchControllerClientBuilder : gaxgrpc::ClientBuilderBase<BatchControllerClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public BatchControllerSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public BatchControllerClientBuilder() : base(BatchControllerClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref BatchControllerClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<BatchControllerClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override BatchControllerClient Build()
        {
            BatchControllerClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<BatchControllerClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<BatchControllerClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private BatchControllerClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return BatchControllerClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<BatchControllerClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BatchControllerClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => BatchControllerClient.ChannelPool;
    }

    /// <summary>BatchController client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The BatchController provides methods to manage batch workloads.
    /// </remarks>
    public abstract partial class BatchControllerClient
    {
        /// <summary>
        /// The default endpoint for the BatchController service, which is a host of "dataproc.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dataproc.googleapis.com:443";

        /// <summary>The default BatchController scopes.</summary>
        /// <remarks>
        /// The default BatchController scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(BatchController.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="BatchControllerClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="BatchControllerClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="BatchControllerClient"/>.</returns>
        public static stt::Task<BatchControllerClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new BatchControllerClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="BatchControllerClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="BatchControllerClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="BatchControllerClient"/>.</returns>
        public static BatchControllerClient Create() => new BatchControllerClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="BatchControllerClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="BatchControllerSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="BatchControllerClient"/>.</returns>
        internal static BatchControllerClient Create(grpccore::CallInvoker callInvoker, BatchControllerSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            BatchController.BatchControllerClient grpcClient = new BatchController.BatchControllerClient(callInvoker);
            return new BatchControllerClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC BatchController client</summary>
        public virtual BatchController.BatchControllerClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a batch workload that executes asynchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Batch, BatchOperationMetadata> CreateBatch(CreateBatchRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a batch workload that executes asynchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Batch, BatchOperationMetadata>> CreateBatchAsync(CreateBatchRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a batch workload that executes asynchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Batch, BatchOperationMetadata>> CreateBatchAsync(CreateBatchRequest request, st::CancellationToken cancellationToken) =>
            CreateBatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateBatch</c>.</summary>
        public virtual lro::OperationsClient CreateBatchOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateBatch</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Batch, BatchOperationMetadata> PollOnceCreateBatch(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Batch, BatchOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateBatchOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateBatch</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Batch, BatchOperationMetadata>> PollOnceCreateBatchAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Batch, BatchOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateBatchOperationsClient, callSettings);

        /// <summary>
        /// Creates a batch workload that executes asynchronously.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this batch will be created.
        /// </param>
        /// <param name="batch">
        /// Required. The batch to create.
        /// </param>
        /// <param name="batchId">
        /// Optional. The ID to use for the batch, which will become the final
        /// component of the batch's resource name.
        /// 
        /// This value must be 4-63 characters. Valid characters are `/[a-z][0-9]-/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Batch, BatchOperationMetadata> CreateBatch(string parent, Batch batch, string batchId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBatch(new CreateBatchRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Batch = gax::GaxPreconditions.CheckNotNull(batch, nameof(batch)),
                BatchId = batchId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a batch workload that executes asynchronously.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this batch will be created.
        /// </param>
        /// <param name="batch">
        /// Required. The batch to create.
        /// </param>
        /// <param name="batchId">
        /// Optional. The ID to use for the batch, which will become the final
        /// component of the batch's resource name.
        /// 
        /// This value must be 4-63 characters. Valid characters are `/[a-z][0-9]-/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Batch, BatchOperationMetadata>> CreateBatchAsync(string parent, Batch batch, string batchId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBatchAsync(new CreateBatchRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Batch = gax::GaxPreconditions.CheckNotNull(batch, nameof(batch)),
                BatchId = batchId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a batch workload that executes asynchronously.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this batch will be created.
        /// </param>
        /// <param name="batch">
        /// Required. The batch to create.
        /// </param>
        /// <param name="batchId">
        /// Optional. The ID to use for the batch, which will become the final
        /// component of the batch's resource name.
        /// 
        /// This value must be 4-63 characters. Valid characters are `/[a-z][0-9]-/`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Batch, BatchOperationMetadata>> CreateBatchAsync(string parent, Batch batch, string batchId, st::CancellationToken cancellationToken) =>
            CreateBatchAsync(parent, batch, batchId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a batch workload that executes asynchronously.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this batch will be created.
        /// </param>
        /// <param name="batch">
        /// Required. The batch to create.
        /// </param>
        /// <param name="batchId">
        /// Optional. The ID to use for the batch, which will become the final
        /// component of the batch's resource name.
        /// 
        /// This value must be 4-63 characters. Valid characters are `/[a-z][0-9]-/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Batch, BatchOperationMetadata> CreateBatch(gagr::LocationName parent, Batch batch, string batchId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBatch(new CreateBatchRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Batch = gax::GaxPreconditions.CheckNotNull(batch, nameof(batch)),
                BatchId = batchId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a batch workload that executes asynchronously.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this batch will be created.
        /// </param>
        /// <param name="batch">
        /// Required. The batch to create.
        /// </param>
        /// <param name="batchId">
        /// Optional. The ID to use for the batch, which will become the final
        /// component of the batch's resource name.
        /// 
        /// This value must be 4-63 characters. Valid characters are `/[a-z][0-9]-/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Batch, BatchOperationMetadata>> CreateBatchAsync(gagr::LocationName parent, Batch batch, string batchId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBatchAsync(new CreateBatchRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Batch = gax::GaxPreconditions.CheckNotNull(batch, nameof(batch)),
                BatchId = batchId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a batch workload that executes asynchronously.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this batch will be created.
        /// </param>
        /// <param name="batch">
        /// Required. The batch to create.
        /// </param>
        /// <param name="batchId">
        /// Optional. The ID to use for the batch, which will become the final
        /// component of the batch's resource name.
        /// 
        /// This value must be 4-63 characters. Valid characters are `/[a-z][0-9]-/`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Batch, BatchOperationMetadata>> CreateBatchAsync(gagr::LocationName parent, Batch batch, string batchId, st::CancellationToken cancellationToken) =>
            CreateBatchAsync(parent, batch, batchId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the batch workload resource representation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Batch GetBatch(GetBatchRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the batch workload resource representation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Batch> GetBatchAsync(GetBatchRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the batch workload resource representation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Batch> GetBatchAsync(GetBatchRequest request, st::CancellationToken cancellationToken) =>
            GetBatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the batch workload resource representation.
        /// </summary>
        /// <param name="name">
        /// Required. The fully qualified name of the batch to retrieve
        /// in the format
        /// "projects/PROJECT_ID/locations/DATAPROC_REGION/batches/BATCH_ID"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Batch GetBatch(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBatch(new GetBatchRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the batch workload resource representation.
        /// </summary>
        /// <param name="name">
        /// Required. The fully qualified name of the batch to retrieve
        /// in the format
        /// "projects/PROJECT_ID/locations/DATAPROC_REGION/batches/BATCH_ID"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Batch> GetBatchAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBatchAsync(new GetBatchRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the batch workload resource representation.
        /// </summary>
        /// <param name="name">
        /// Required. The fully qualified name of the batch to retrieve
        /// in the format
        /// "projects/PROJECT_ID/locations/DATAPROC_REGION/batches/BATCH_ID"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Batch> GetBatchAsync(string name, st::CancellationToken cancellationToken) =>
            GetBatchAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the batch workload resource representation.
        /// </summary>
        /// <param name="name">
        /// Required. The fully qualified name of the batch to retrieve
        /// in the format
        /// "projects/PROJECT_ID/locations/DATAPROC_REGION/batches/BATCH_ID"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Batch GetBatch(BatchName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBatch(new GetBatchRequest
            {
                BatchName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the batch workload resource representation.
        /// </summary>
        /// <param name="name">
        /// Required. The fully qualified name of the batch to retrieve
        /// in the format
        /// "projects/PROJECT_ID/locations/DATAPROC_REGION/batches/BATCH_ID"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Batch> GetBatchAsync(BatchName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBatchAsync(new GetBatchRequest
            {
                BatchName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the batch workload resource representation.
        /// </summary>
        /// <param name="name">
        /// Required. The fully qualified name of the batch to retrieve
        /// in the format
        /// "projects/PROJECT_ID/locations/DATAPROC_REGION/batches/BATCH_ID"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Batch> GetBatchAsync(BatchName name, st::CancellationToken cancellationToken) =>
            GetBatchAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists batch workloads.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Batch"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBatchesResponse, Batch> ListBatches(ListBatchesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists batch workloads.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Batch"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBatchesResponse, Batch> ListBatchesAsync(ListBatchesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists batch workloads.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of batches.
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
        /// <returns>A pageable sequence of <see cref="Batch"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBatchesResponse, Batch> ListBatches(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBatchesRequest request = new ListBatchesRequest
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
            return ListBatches(request, callSettings);
        }

        /// <summary>
        /// Lists batch workloads.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of batches.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Batch"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBatchesResponse, Batch> ListBatchesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBatchesRequest request = new ListBatchesRequest
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
            return ListBatchesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists batch workloads.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of batches.
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
        /// <returns>A pageable sequence of <see cref="Batch"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBatchesResponse, Batch> ListBatches(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBatchesRequest request = new ListBatchesRequest
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
            return ListBatches(request, callSettings);
        }

        /// <summary>
        /// Lists batch workloads.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of batches.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Batch"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBatchesResponse, Batch> ListBatchesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBatchesRequest request = new ListBatchesRequest
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
            return ListBatchesAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes the batch workload resource. If the batch is not in terminal state,
        /// the delete fails and the response returns `FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteBatch(DeleteBatchRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the batch workload resource. If the batch is not in terminal state,
        /// the delete fails and the response returns `FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBatchAsync(DeleteBatchRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the batch workload resource. If the batch is not in terminal state,
        /// the delete fails and the response returns `FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBatchAsync(DeleteBatchRequest request, st::CancellationToken cancellationToken) =>
            DeleteBatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the batch workload resource. If the batch is not in terminal state,
        /// the delete fails and the response returns `FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="name">
        /// Required. The fully qualified name of the batch to retrieve
        /// in the format
        /// "projects/PROJECT_ID/locations/DATAPROC_REGION/batches/BATCH_ID"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteBatch(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBatch(new DeleteBatchRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the batch workload resource. If the batch is not in terminal state,
        /// the delete fails and the response returns `FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="name">
        /// Required. The fully qualified name of the batch to retrieve
        /// in the format
        /// "projects/PROJECT_ID/locations/DATAPROC_REGION/batches/BATCH_ID"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBatchAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBatchAsync(new DeleteBatchRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the batch workload resource. If the batch is not in terminal state,
        /// the delete fails and the response returns `FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="name">
        /// Required. The fully qualified name of the batch to retrieve
        /// in the format
        /// "projects/PROJECT_ID/locations/DATAPROC_REGION/batches/BATCH_ID"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBatchAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteBatchAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the batch workload resource. If the batch is not in terminal state,
        /// the delete fails and the response returns `FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="name">
        /// Required. The fully qualified name of the batch to retrieve
        /// in the format
        /// "projects/PROJECT_ID/locations/DATAPROC_REGION/batches/BATCH_ID"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteBatch(BatchName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBatch(new DeleteBatchRequest
            {
                BatchName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the batch workload resource. If the batch is not in terminal state,
        /// the delete fails and the response returns `FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="name">
        /// Required. The fully qualified name of the batch to retrieve
        /// in the format
        /// "projects/PROJECT_ID/locations/DATAPROC_REGION/batches/BATCH_ID"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBatchAsync(BatchName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBatchAsync(new DeleteBatchRequest
            {
                BatchName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the batch workload resource. If the batch is not in terminal state,
        /// the delete fails and the response returns `FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="name">
        /// Required. The fully qualified name of the batch to retrieve
        /// in the format
        /// "projects/PROJECT_ID/locations/DATAPROC_REGION/batches/BATCH_ID"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBatchAsync(BatchName name, st::CancellationToken cancellationToken) =>
            DeleteBatchAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>BatchController client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The BatchController provides methods to manage batch workloads.
    /// </remarks>
    public sealed partial class BatchControllerClientImpl : BatchControllerClient
    {
        private readonly gaxgrpc::ApiCall<CreateBatchRequest, lro::Operation> _callCreateBatch;

        private readonly gaxgrpc::ApiCall<GetBatchRequest, Batch> _callGetBatch;

        private readonly gaxgrpc::ApiCall<ListBatchesRequest, ListBatchesResponse> _callListBatches;

        private readonly gaxgrpc::ApiCall<DeleteBatchRequest, wkt::Empty> _callDeleteBatch;

        /// <summary>
        /// Constructs a client wrapper for the BatchController service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="BatchControllerSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public BatchControllerClientImpl(BatchController.BatchControllerClient grpcClient, BatchControllerSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            BatchControllerSettings effectiveSettings = settings ?? BatchControllerSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateBatchOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateBatchOperationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreateBatch = clientHelper.BuildApiCall<CreateBatchRequest, lro::Operation>("CreateBatch", grpcClient.CreateBatchAsync, grpcClient.CreateBatch, effectiveSettings.CreateBatchSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateBatch);
            Modify_CreateBatchApiCall(ref _callCreateBatch);
            _callGetBatch = clientHelper.BuildApiCall<GetBatchRequest, Batch>("GetBatch", grpcClient.GetBatchAsync, grpcClient.GetBatch, effectiveSettings.GetBatchSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetBatch);
            Modify_GetBatchApiCall(ref _callGetBatch);
            _callListBatches = clientHelper.BuildApiCall<ListBatchesRequest, ListBatchesResponse>("ListBatches", grpcClient.ListBatchesAsync, grpcClient.ListBatches, effectiveSettings.ListBatchesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListBatches);
            Modify_ListBatchesApiCall(ref _callListBatches);
            _callDeleteBatch = clientHelper.BuildApiCall<DeleteBatchRequest, wkt::Empty>("DeleteBatch", grpcClient.DeleteBatchAsync, grpcClient.DeleteBatch, effectiveSettings.DeleteBatchSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteBatch);
            Modify_DeleteBatchApiCall(ref _callDeleteBatch);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateBatchApiCall(ref gaxgrpc::ApiCall<CreateBatchRequest, lro::Operation> call);

        partial void Modify_GetBatchApiCall(ref gaxgrpc::ApiCall<GetBatchRequest, Batch> call);

        partial void Modify_ListBatchesApiCall(ref gaxgrpc::ApiCall<ListBatchesRequest, ListBatchesResponse> call);

        partial void Modify_DeleteBatchApiCall(ref gaxgrpc::ApiCall<DeleteBatchRequest, wkt::Empty> call);

        partial void OnConstruction(BatchController.BatchControllerClient grpcClient, BatchControllerSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC BatchController client</summary>
        public override BatchController.BatchControllerClient GrpcClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateBatchRequest(ref CreateBatchRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetBatchRequest(ref GetBatchRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBatchesRequest(ref ListBatchesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteBatchRequest(ref DeleteBatchRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateBatch</c>.</summary>
        public override lro::OperationsClient CreateBatchOperationsClient { get; }

        /// <summary>
        /// Creates a batch workload that executes asynchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Batch, BatchOperationMetadata> CreateBatch(CreateBatchRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBatchRequest(ref request, ref callSettings);
            return new lro::Operation<Batch, BatchOperationMetadata>(_callCreateBatch.Sync(request, callSettings), CreateBatchOperationsClient);
        }

        /// <summary>
        /// Creates a batch workload that executes asynchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Batch, BatchOperationMetadata>> CreateBatchAsync(CreateBatchRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBatchRequest(ref request, ref callSettings);
            return new lro::Operation<Batch, BatchOperationMetadata>(await _callCreateBatch.Async(request, callSettings).ConfigureAwait(false), CreateBatchOperationsClient);
        }

        /// <summary>
        /// Gets the batch workload resource representation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Batch GetBatch(GetBatchRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBatchRequest(ref request, ref callSettings);
            return _callGetBatch.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the batch workload resource representation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Batch> GetBatchAsync(GetBatchRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBatchRequest(ref request, ref callSettings);
            return _callGetBatch.Async(request, callSettings);
        }

        /// <summary>
        /// Lists batch workloads.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Batch"/> resources.</returns>
        public override gax::PagedEnumerable<ListBatchesResponse, Batch> ListBatches(ListBatchesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBatchesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListBatchesRequest, ListBatchesResponse, Batch>(_callListBatches, request, callSettings);
        }

        /// <summary>
        /// Lists batch workloads.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Batch"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListBatchesResponse, Batch> ListBatchesAsync(ListBatchesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBatchesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListBatchesRequest, ListBatchesResponse, Batch>(_callListBatches, request, callSettings);
        }

        /// <summary>
        /// Deletes the batch workload resource. If the batch is not in terminal state,
        /// the delete fails and the response returns `FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteBatch(DeleteBatchRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBatchRequest(ref request, ref callSettings);
            _callDeleteBatch.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the batch workload resource. If the batch is not in terminal state,
        /// the delete fails and the response returns `FAILED_PRECONDITION`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteBatchAsync(DeleteBatchRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBatchRequest(ref request, ref callSettings);
            return _callDeleteBatch.Async(request, callSettings);
        }
    }

    public partial class ListBatchesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBatchesResponse : gaxgrpc::IPageResponse<Batch>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Batch> GetEnumerator() => Batches.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class BatchController
    {
        public partial class BatchControllerClient
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

    public static partial class BatchController
    {
        public partial class BatchControllerClient
        {
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
