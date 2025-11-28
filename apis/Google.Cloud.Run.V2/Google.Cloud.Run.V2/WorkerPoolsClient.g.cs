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

namespace Google.Cloud.Run.V2
{
    /// <summary>Settings for <see cref="WorkerPoolsClient"/> instances.</summary>
    public sealed partial class WorkerPoolsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="WorkerPoolsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="WorkerPoolsSettings"/>.</returns>
        public static WorkerPoolsSettings GetDefault() => new WorkerPoolsSettings();

        /// <summary>Constructs a new <see cref="WorkerPoolsSettings"/> object with default settings.</summary>
        public WorkerPoolsSettings()
        {
        }

        private WorkerPoolsSettings(WorkerPoolsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateWorkerPoolSettings = existing.CreateWorkerPoolSettings;
            CreateWorkerPoolOperationsSettings = existing.CreateWorkerPoolOperationsSettings.Clone();
            GetWorkerPoolSettings = existing.GetWorkerPoolSettings;
            ListWorkerPoolsSettings = existing.ListWorkerPoolsSettings;
            UpdateWorkerPoolSettings = existing.UpdateWorkerPoolSettings;
            UpdateWorkerPoolOperationsSettings = existing.UpdateWorkerPoolOperationsSettings.Clone();
            DeleteWorkerPoolSettings = existing.DeleteWorkerPoolSettings;
            DeleteWorkerPoolOperationsSettings = existing.DeleteWorkerPoolOperationsSettings.Clone();
            GetIamPolicySettings = existing.GetIamPolicySettings;
            SetIamPolicySettings = existing.SetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(WorkerPoolsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkerPoolsClient.CreateWorkerPool</c> and <c>WorkerPoolsClient.CreateWorkerPoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateWorkerPoolSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>WorkerPoolsClient.CreateWorkerPool</c> and
        /// <c>WorkerPoolsClient.CreateWorkerPoolAsync</c>.
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
        public lro::OperationsSettings CreateWorkerPoolOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkerPoolsClient.GetWorkerPool</c> and <c>WorkerPoolsClient.GetWorkerPoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetWorkerPoolSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkerPoolsClient.ListWorkerPools</c> and <c>WorkerPoolsClient.ListWorkerPoolsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListWorkerPoolsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkerPoolsClient.UpdateWorkerPool</c> and <c>WorkerPoolsClient.UpdateWorkerPoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateWorkerPoolSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>WorkerPoolsClient.UpdateWorkerPool</c> and
        /// <c>WorkerPoolsClient.UpdateWorkerPoolAsync</c>.
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
        public lro::OperationsSettings UpdateWorkerPoolOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkerPoolsClient.DeleteWorkerPool</c> and <c>WorkerPoolsClient.DeleteWorkerPoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteWorkerPoolSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>WorkerPoolsClient.DeleteWorkerPool</c> and
        /// <c>WorkerPoolsClient.DeleteWorkerPoolAsync</c>.
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
        public lro::OperationsSettings DeleteWorkerPoolOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkerPoolsClient.GetIamPolicy</c> and <c>WorkerPoolsClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkerPoolsClient.SetIamPolicy</c> and <c>WorkerPoolsClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkerPoolsClient.TestIamPermissions</c> and <c>WorkerPoolsClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="WorkerPoolsSettings"/> object.</returns>
        public WorkerPoolsSettings Clone() => new WorkerPoolsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="WorkerPoolsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class WorkerPoolsClientBuilder : gaxgrpc::ClientBuilderBase<WorkerPoolsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public WorkerPoolsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public WorkerPoolsClientBuilder() : base(WorkerPoolsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref WorkerPoolsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<WorkerPoolsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override WorkerPoolsClient Build()
        {
            WorkerPoolsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<WorkerPoolsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<WorkerPoolsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private WorkerPoolsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return WorkerPoolsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<WorkerPoolsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return WorkerPoolsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => WorkerPoolsClient.ChannelPool;
    }

    /// <summary>WorkerPools client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Cloud Run WorkerPool Control Plane API.
    /// </remarks>
    public abstract partial class WorkerPoolsClient
    {
        /// <summary>
        /// The default endpoint for the WorkerPools service, which is a host of "run.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "run.googleapis.com:443";

        /// <summary>The default WorkerPools scopes.</summary>
        /// <remarks>
        /// The default WorkerPools scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(WorkerPools.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="WorkerPoolsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="WorkerPoolsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="WorkerPoolsClient"/>.</returns>
        public static stt::Task<WorkerPoolsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new WorkerPoolsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="WorkerPoolsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="WorkerPoolsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="WorkerPoolsClient"/>.</returns>
        public static WorkerPoolsClient Create() => new WorkerPoolsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="WorkerPoolsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="WorkerPoolsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="WorkerPoolsClient"/>.</returns>
        internal static WorkerPoolsClient Create(grpccore::CallInvoker callInvoker, WorkerPoolsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            WorkerPools.WorkerPoolsClient grpcClient = new WorkerPools.WorkerPoolsClient(callInvoker);
            return new WorkerPoolsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC WorkerPools client</summary>
        public virtual WorkerPools.WorkerPoolsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new WorkerPool in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkerPool, WorkerPool> CreateWorkerPool(CreateWorkerPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new WorkerPool in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkerPool, WorkerPool>> CreateWorkerPoolAsync(CreateWorkerPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new WorkerPool in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkerPool, WorkerPool>> CreateWorkerPoolAsync(CreateWorkerPoolRequest request, st::CancellationToken cancellationToken) =>
            CreateWorkerPoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateWorkerPool</c>.</summary>
        public virtual lro::OperationsClient CreateWorkerPoolOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateWorkerPool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<WorkerPool, WorkerPool> PollOnceCreateWorkerPool(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<WorkerPool, WorkerPool>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateWorkerPoolOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateWorkerPool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<WorkerPool, WorkerPool>> PollOnceCreateWorkerPoolAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<WorkerPool, WorkerPool>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateWorkerPoolOperationsClient, callSettings);

        /// <summary>
        /// Creates a new WorkerPool in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location and project in which this worker pool should be
        /// created. Format: `projects/{project}/locations/{location}`, where
        /// `{project}` can be project id or number. Only lowercase characters, digits,
        /// and hyphens.
        /// </param>
        /// <param name="workerPool">
        /// Required. The WorkerPool instance to create.
        /// </param>
        /// <param name="workerPoolId">
        /// Required. The unique identifier for the WorkerPool. It must begin with
        /// letter, and cannot end with hyphen; must contain fewer than 50 characters.
        /// The name of the worker pool becomes
        /// `{parent}/workerPools/{worker_pool_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkerPool, WorkerPool> CreateWorkerPool(string parent, WorkerPool workerPool, string workerPoolId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkerPool(new CreateWorkerPoolRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                WorkerPool = gax::GaxPreconditions.CheckNotNull(workerPool, nameof(workerPool)),
                WorkerPoolId = gax::GaxPreconditions.CheckNotNullOrEmpty(workerPoolId, nameof(workerPoolId)),
            }, callSettings);

        /// <summary>
        /// Creates a new WorkerPool in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location and project in which this worker pool should be
        /// created. Format: `projects/{project}/locations/{location}`, where
        /// `{project}` can be project id or number. Only lowercase characters, digits,
        /// and hyphens.
        /// </param>
        /// <param name="workerPool">
        /// Required. The WorkerPool instance to create.
        /// </param>
        /// <param name="workerPoolId">
        /// Required. The unique identifier for the WorkerPool. It must begin with
        /// letter, and cannot end with hyphen; must contain fewer than 50 characters.
        /// The name of the worker pool becomes
        /// `{parent}/workerPools/{worker_pool_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkerPool, WorkerPool>> CreateWorkerPoolAsync(string parent, WorkerPool workerPool, string workerPoolId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkerPoolAsync(new CreateWorkerPoolRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                WorkerPool = gax::GaxPreconditions.CheckNotNull(workerPool, nameof(workerPool)),
                WorkerPoolId = gax::GaxPreconditions.CheckNotNullOrEmpty(workerPoolId, nameof(workerPoolId)),
            }, callSettings);

        /// <summary>
        /// Creates a new WorkerPool in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location and project in which this worker pool should be
        /// created. Format: `projects/{project}/locations/{location}`, where
        /// `{project}` can be project id or number. Only lowercase characters, digits,
        /// and hyphens.
        /// </param>
        /// <param name="workerPool">
        /// Required. The WorkerPool instance to create.
        /// </param>
        /// <param name="workerPoolId">
        /// Required. The unique identifier for the WorkerPool. It must begin with
        /// letter, and cannot end with hyphen; must contain fewer than 50 characters.
        /// The name of the worker pool becomes
        /// `{parent}/workerPools/{worker_pool_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkerPool, WorkerPool>> CreateWorkerPoolAsync(string parent, WorkerPool workerPool, string workerPoolId, st::CancellationToken cancellationToken) =>
            CreateWorkerPoolAsync(parent, workerPool, workerPoolId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new WorkerPool in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location and project in which this worker pool should be
        /// created. Format: `projects/{project}/locations/{location}`, where
        /// `{project}` can be project id or number. Only lowercase characters, digits,
        /// and hyphens.
        /// </param>
        /// <param name="workerPool">
        /// Required. The WorkerPool instance to create.
        /// </param>
        /// <param name="workerPoolId">
        /// Required. The unique identifier for the WorkerPool. It must begin with
        /// letter, and cannot end with hyphen; must contain fewer than 50 characters.
        /// The name of the worker pool becomes
        /// `{parent}/workerPools/{worker_pool_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkerPool, WorkerPool> CreateWorkerPool(gagr::LocationName parent, WorkerPool workerPool, string workerPoolId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkerPool(new CreateWorkerPoolRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                WorkerPool = gax::GaxPreconditions.CheckNotNull(workerPool, nameof(workerPool)),
                WorkerPoolId = gax::GaxPreconditions.CheckNotNullOrEmpty(workerPoolId, nameof(workerPoolId)),
            }, callSettings);

        /// <summary>
        /// Creates a new WorkerPool in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location and project in which this worker pool should be
        /// created. Format: `projects/{project}/locations/{location}`, where
        /// `{project}` can be project id or number. Only lowercase characters, digits,
        /// and hyphens.
        /// </param>
        /// <param name="workerPool">
        /// Required. The WorkerPool instance to create.
        /// </param>
        /// <param name="workerPoolId">
        /// Required. The unique identifier for the WorkerPool. It must begin with
        /// letter, and cannot end with hyphen; must contain fewer than 50 characters.
        /// The name of the worker pool becomes
        /// `{parent}/workerPools/{worker_pool_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkerPool, WorkerPool>> CreateWorkerPoolAsync(gagr::LocationName parent, WorkerPool workerPool, string workerPoolId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkerPoolAsync(new CreateWorkerPoolRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                WorkerPool = gax::GaxPreconditions.CheckNotNull(workerPool, nameof(workerPool)),
                WorkerPoolId = gax::GaxPreconditions.CheckNotNullOrEmpty(workerPoolId, nameof(workerPoolId)),
            }, callSettings);

        /// <summary>
        /// Creates a new WorkerPool in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location and project in which this worker pool should be
        /// created. Format: `projects/{project}/locations/{location}`, where
        /// `{project}` can be project id or number. Only lowercase characters, digits,
        /// and hyphens.
        /// </param>
        /// <param name="workerPool">
        /// Required. The WorkerPool instance to create.
        /// </param>
        /// <param name="workerPoolId">
        /// Required. The unique identifier for the WorkerPool. It must begin with
        /// letter, and cannot end with hyphen; must contain fewer than 50 characters.
        /// The name of the worker pool becomes
        /// `{parent}/workerPools/{worker_pool_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkerPool, WorkerPool>> CreateWorkerPoolAsync(gagr::LocationName parent, WorkerPool workerPool, string workerPoolId, st::CancellationToken cancellationToken) =>
            CreateWorkerPoolAsync(parent, workerPool, workerPoolId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a WorkerPool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WorkerPool GetWorkerPool(GetWorkerPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a WorkerPool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkerPool> GetWorkerPoolAsync(GetWorkerPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a WorkerPool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkerPool> GetWorkerPoolAsync(GetWorkerPoolRequest request, st::CancellationToken cancellationToken) =>
            GetWorkerPoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a WorkerPool.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the WorkerPool.
        /// Format:
        /// `projects/{project}/locations/{location}/workerPools/{worker_pool}`, where
        /// `{project}` can be project id or number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WorkerPool GetWorkerPool(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkerPool(new GetWorkerPoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a WorkerPool.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the WorkerPool.
        /// Format:
        /// `projects/{project}/locations/{location}/workerPools/{worker_pool}`, where
        /// `{project}` can be project id or number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkerPool> GetWorkerPoolAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkerPoolAsync(new GetWorkerPoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a WorkerPool.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the WorkerPool.
        /// Format:
        /// `projects/{project}/locations/{location}/workerPools/{worker_pool}`, where
        /// `{project}` can be project id or number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkerPool> GetWorkerPoolAsync(string name, st::CancellationToken cancellationToken) =>
            GetWorkerPoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a WorkerPool.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the WorkerPool.
        /// Format:
        /// `projects/{project}/locations/{location}/workerPools/{worker_pool}`, where
        /// `{project}` can be project id or number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WorkerPool GetWorkerPool(WorkerPoolName name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkerPool(new GetWorkerPoolRequest
            {
                WorkerPoolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a WorkerPool.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the WorkerPool.
        /// Format:
        /// `projects/{project}/locations/{location}/workerPools/{worker_pool}`, where
        /// `{project}` can be project id or number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkerPool> GetWorkerPoolAsync(WorkerPoolName name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkerPoolAsync(new GetWorkerPoolRequest
            {
                WorkerPoolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a WorkerPool.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the WorkerPool.
        /// Format:
        /// `projects/{project}/locations/{location}/workerPools/{worker_pool}`, where
        /// `{project}` can be project id or number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkerPool> GetWorkerPoolAsync(WorkerPoolName name, st::CancellationToken cancellationToken) =>
            GetWorkerPoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists WorkerPools. Results are sorted by creation time, descending.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="WorkerPool"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkerPoolsResponse, WorkerPool> ListWorkerPools(ListWorkerPoolsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists WorkerPools. Results are sorted by creation time, descending.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="WorkerPool"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkerPoolsResponse, WorkerPool> ListWorkerPoolsAsync(ListWorkerPoolsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists WorkerPools. Results are sorted by creation time, descending.
        /// </summary>
        /// <param name="parent">
        /// Required. The location and project to list resources on.
        /// Location must be a valid Google Cloud region, and cannot be the "-"
        /// wildcard. Format: `projects/{project}/locations/{location}`, where
        /// `{project}` can be project id or number.
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
        /// <returns>A pageable sequence of <see cref="WorkerPool"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkerPoolsResponse, WorkerPool> ListWorkerPools(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkerPoolsRequest request = new ListWorkerPoolsRequest
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
            return ListWorkerPools(request, callSettings);
        }

        /// <summary>
        /// Lists WorkerPools. Results are sorted by creation time, descending.
        /// </summary>
        /// <param name="parent">
        /// Required. The location and project to list resources on.
        /// Location must be a valid Google Cloud region, and cannot be the "-"
        /// wildcard. Format: `projects/{project}/locations/{location}`, where
        /// `{project}` can be project id or number.
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
        /// <returns>A pageable asynchronous sequence of <see cref="WorkerPool"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkerPoolsResponse, WorkerPool> ListWorkerPoolsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkerPoolsRequest request = new ListWorkerPoolsRequest
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
            return ListWorkerPoolsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists WorkerPools. Results are sorted by creation time, descending.
        /// </summary>
        /// <param name="parent">
        /// Required. The location and project to list resources on.
        /// Location must be a valid Google Cloud region, and cannot be the "-"
        /// wildcard. Format: `projects/{project}/locations/{location}`, where
        /// `{project}` can be project id or number.
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
        /// <returns>A pageable sequence of <see cref="WorkerPool"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkerPoolsResponse, WorkerPool> ListWorkerPools(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkerPoolsRequest request = new ListWorkerPoolsRequest
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
            return ListWorkerPools(request, callSettings);
        }

        /// <summary>
        /// Lists WorkerPools. Results are sorted by creation time, descending.
        /// </summary>
        /// <param name="parent">
        /// Required. The location and project to list resources on.
        /// Location must be a valid Google Cloud region, and cannot be the "-"
        /// wildcard. Format: `projects/{project}/locations/{location}`, where
        /// `{project}` can be project id or number.
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
        /// <returns>A pageable asynchronous sequence of <see cref="WorkerPool"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkerPoolsResponse, WorkerPool> ListWorkerPoolsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkerPoolsRequest request = new ListWorkerPoolsRequest
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
            return ListWorkerPoolsAsync(request, callSettings);
        }

        /// <summary>
        /// Updates a WorkerPool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkerPool, WorkerPool> UpdateWorkerPool(UpdateWorkerPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a WorkerPool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkerPool, WorkerPool>> UpdateWorkerPoolAsync(UpdateWorkerPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a WorkerPool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkerPool, WorkerPool>> UpdateWorkerPoolAsync(UpdateWorkerPoolRequest request, st::CancellationToken cancellationToken) =>
            UpdateWorkerPoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateWorkerPool</c>.</summary>
        public virtual lro::OperationsClient UpdateWorkerPoolOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateWorkerPool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<WorkerPool, WorkerPool> PollOnceUpdateWorkerPool(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<WorkerPool, WorkerPool>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateWorkerPoolOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateWorkerPool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<WorkerPool, WorkerPool>> PollOnceUpdateWorkerPoolAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<WorkerPool, WorkerPool>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateWorkerPoolOperationsClient, callSettings);

        /// <summary>
        /// Updates a WorkerPool.
        /// </summary>
        /// <param name="workerPool">
        /// Required. The WorkerPool to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkerPool, WorkerPool> UpdateWorkerPool(WorkerPool workerPool, gaxgrpc::CallSettings callSettings = null) =>
            UpdateWorkerPool(new UpdateWorkerPoolRequest
            {
                WorkerPool = gax::GaxPreconditions.CheckNotNull(workerPool, nameof(workerPool)),
            }, callSettings);

        /// <summary>
        /// Updates a WorkerPool.
        /// </summary>
        /// <param name="workerPool">
        /// Required. The WorkerPool to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkerPool, WorkerPool>> UpdateWorkerPoolAsync(WorkerPool workerPool, gaxgrpc::CallSettings callSettings = null) =>
            UpdateWorkerPoolAsync(new UpdateWorkerPoolRequest
            {
                WorkerPool = gax::GaxPreconditions.CheckNotNull(workerPool, nameof(workerPool)),
            }, callSettings);

        /// <summary>
        /// Updates a WorkerPool.
        /// </summary>
        /// <param name="workerPool">
        /// Required. The WorkerPool to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkerPool, WorkerPool>> UpdateWorkerPoolAsync(WorkerPool workerPool, st::CancellationToken cancellationToken) =>
            UpdateWorkerPoolAsync(workerPool, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a WorkerPool.
        /// </summary>
        /// <param name="workerPool">
        /// Required. The WorkerPool to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkerPool, WorkerPool> UpdateWorkerPool(WorkerPool workerPool, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateWorkerPool(new UpdateWorkerPoolRequest
            {
                UpdateMask = updateMask,
                WorkerPool = gax::GaxPreconditions.CheckNotNull(workerPool, nameof(workerPool)),
            }, callSettings);

        /// <summary>
        /// Updates a WorkerPool.
        /// </summary>
        /// <param name="workerPool">
        /// Required. The WorkerPool to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkerPool, WorkerPool>> UpdateWorkerPoolAsync(WorkerPool workerPool, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateWorkerPoolAsync(new UpdateWorkerPoolRequest
            {
                UpdateMask = updateMask,
                WorkerPool = gax::GaxPreconditions.CheckNotNull(workerPool, nameof(workerPool)),
            }, callSettings);

        /// <summary>
        /// Updates a WorkerPool.
        /// </summary>
        /// <param name="workerPool">
        /// Required. The WorkerPool to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkerPool, WorkerPool>> UpdateWorkerPoolAsync(WorkerPool workerPool, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateWorkerPoolAsync(workerPool, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a WorkerPool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkerPool, WorkerPool> DeleteWorkerPool(DeleteWorkerPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a WorkerPool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkerPool, WorkerPool>> DeleteWorkerPoolAsync(DeleteWorkerPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a WorkerPool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkerPool, WorkerPool>> DeleteWorkerPoolAsync(DeleteWorkerPoolRequest request, st::CancellationToken cancellationToken) =>
            DeleteWorkerPoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteWorkerPool</c>.</summary>
        public virtual lro::OperationsClient DeleteWorkerPoolOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteWorkerPool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<WorkerPool, WorkerPool> PollOnceDeleteWorkerPool(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<WorkerPool, WorkerPool>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteWorkerPoolOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteWorkerPool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<WorkerPool, WorkerPool>> PollOnceDeleteWorkerPoolAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<WorkerPool, WorkerPool>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteWorkerPoolOperationsClient, callSettings);

        /// <summary>
        /// Deletes a WorkerPool.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the WorkerPool.
        /// Format:
        /// `projects/{project}/locations/{location}/workerPools/{worker_pool}`, where
        /// `{project}` can be project id or number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkerPool, WorkerPool> DeleteWorkerPool(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkerPool(new DeleteWorkerPoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a WorkerPool.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the WorkerPool.
        /// Format:
        /// `projects/{project}/locations/{location}/workerPools/{worker_pool}`, where
        /// `{project}` can be project id or number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkerPool, WorkerPool>> DeleteWorkerPoolAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkerPoolAsync(new DeleteWorkerPoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a WorkerPool.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the WorkerPool.
        /// Format:
        /// `projects/{project}/locations/{location}/workerPools/{worker_pool}`, where
        /// `{project}` can be project id or number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkerPool, WorkerPool>> DeleteWorkerPoolAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteWorkerPoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a WorkerPool.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the WorkerPool.
        /// Format:
        /// `projects/{project}/locations/{location}/workerPools/{worker_pool}`, where
        /// `{project}` can be project id or number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkerPool, WorkerPool> DeleteWorkerPool(WorkerPoolName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkerPool(new DeleteWorkerPoolRequest
            {
                WorkerPoolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a WorkerPool.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the WorkerPool.
        /// Format:
        /// `projects/{project}/locations/{location}/workerPools/{worker_pool}`, where
        /// `{project}` can be project id or number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkerPool, WorkerPool>> DeleteWorkerPoolAsync(WorkerPoolName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkerPoolAsync(new DeleteWorkerPoolRequest
            {
                WorkerPoolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a WorkerPool.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the WorkerPool.
        /// Format:
        /// `projects/{project}/locations/{location}/workerPools/{worker_pool}`, where
        /// `{project}` can be project id or number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkerPool, WorkerPool>> DeleteWorkerPoolAsync(WorkerPoolName name, st::CancellationToken cancellationToken) =>
            DeleteWorkerPoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the IAM Access Control policy currently in effect for the given
        /// Cloud Run WorkerPool. This result does not include any inherited policies.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the IAM Access Control policy currently in effect for the given
        /// Cloud Run WorkerPool. This result does not include any inherited policies.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the IAM Access Control policy currently in effect for the given
        /// Cloud Run WorkerPool. This result does not include any inherited policies.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the IAM Access control policy for the specified WorkerPool. Overwrites
        /// any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the IAM Access control policy for the specified WorkerPool. Overwrites
        /// any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the IAM Access control policy for the specified WorkerPool. Overwrites
        /// any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that a caller has on the specified Project.
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that a caller has on the specified Project.
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that a caller has on the specified Project.
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>WorkerPools client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Cloud Run WorkerPool Control Plane API.
    /// </remarks>
    public sealed partial class WorkerPoolsClientImpl : WorkerPoolsClient
    {
        private readonly gaxgrpc::ApiCall<CreateWorkerPoolRequest, lro::Operation> _callCreateWorkerPool;

        private readonly gaxgrpc::ApiCall<GetWorkerPoolRequest, WorkerPool> _callGetWorkerPool;

        private readonly gaxgrpc::ApiCall<ListWorkerPoolsRequest, ListWorkerPoolsResponse> _callListWorkerPools;

        private readonly gaxgrpc::ApiCall<UpdateWorkerPoolRequest, lro::Operation> _callUpdateWorkerPool;

        private readonly gaxgrpc::ApiCall<DeleteWorkerPoolRequest, lro::Operation> _callDeleteWorkerPool;

        private readonly gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> _callGetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> _callSetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> _callTestIamPermissions;

        /// <summary>
        /// Constructs a client wrapper for the WorkerPools service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="WorkerPoolsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public WorkerPoolsClientImpl(WorkerPools.WorkerPoolsClient grpcClient, WorkerPoolsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            WorkerPoolsSettings effectiveSettings = settings ?? WorkerPoolsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateWorkerPoolOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateWorkerPoolOperationsSettings, logger);
            UpdateWorkerPoolOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateWorkerPoolOperationsSettings, logger);
            DeleteWorkerPoolOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteWorkerPoolOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCreateWorkerPool = clientHelper.BuildApiCall<CreateWorkerPoolRequest, lro::Operation>("CreateWorkerPool", grpcClient.CreateWorkerPoolAsync, grpcClient.CreateWorkerPool, effectiveSettings.CreateWorkerPoolSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<CreateWorkerPoolRequest>().WithExtractedParameter("location", "^projects/[^/]+/locations/([^/]+)/?$", request => request.Parent));
            Modify_ApiCall(ref _callCreateWorkerPool);
            Modify_CreateWorkerPoolApiCall(ref _callCreateWorkerPool);
            _callGetWorkerPool = clientHelper.BuildApiCall<GetWorkerPoolRequest, WorkerPool>("GetWorkerPool", grpcClient.GetWorkerPoolAsync, grpcClient.GetWorkerPool, effectiveSettings.GetWorkerPoolSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<GetWorkerPoolRequest>().WithExtractedParameter("location", "^projects/[^/]+/locations/([^/]+)(?:/.*)?$", request => request.Name));
            Modify_ApiCall(ref _callGetWorkerPool);
            Modify_GetWorkerPoolApiCall(ref _callGetWorkerPool);
            _callListWorkerPools = clientHelper.BuildApiCall<ListWorkerPoolsRequest, ListWorkerPoolsResponse>("ListWorkerPools", grpcClient.ListWorkerPoolsAsync, grpcClient.ListWorkerPools, effectiveSettings.ListWorkerPoolsSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<ListWorkerPoolsRequest>().WithExtractedParameter("location", "^projects/[^/]+/locations/([^/]+)/?$", request => request.Parent));
            Modify_ApiCall(ref _callListWorkerPools);
            Modify_ListWorkerPoolsApiCall(ref _callListWorkerPools);
            _callUpdateWorkerPool = clientHelper.BuildApiCall<UpdateWorkerPoolRequest, lro::Operation>("UpdateWorkerPool", grpcClient.UpdateWorkerPoolAsync, grpcClient.UpdateWorkerPool, effectiveSettings.UpdateWorkerPoolSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<UpdateWorkerPoolRequest>().WithExtractedParameter("location", "^projects/[^/]+/locations/([^/]+)(?:/.*)?$", request => request.WorkerPool?.Name));
            Modify_ApiCall(ref _callUpdateWorkerPool);
            Modify_UpdateWorkerPoolApiCall(ref _callUpdateWorkerPool);
            _callDeleteWorkerPool = clientHelper.BuildApiCall<DeleteWorkerPoolRequest, lro::Operation>("DeleteWorkerPool", grpcClient.DeleteWorkerPoolAsync, grpcClient.DeleteWorkerPool, effectiveSettings.DeleteWorkerPoolSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<DeleteWorkerPoolRequest>().WithExtractedParameter("location", "^projects/[^/]+/locations/([^/]+)(?:/.*)?$", request => request.Name));
            Modify_ApiCall(ref _callDeleteWorkerPool);
            Modify_DeleteWorkerPoolApiCall(ref _callDeleteWorkerPool);
            _callGetIamPolicy = clientHelper.BuildApiCall<gciv::GetIamPolicyRequest, gciv::Policy>("GetIamPolicy", grpcClient.GetIamPolicyAsync, grpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            _callSetIamPolicy = clientHelper.BuildApiCall<gciv::SetIamPolicyRequest, gciv::Policy>("SetIamPolicy", grpcClient.SetIamPolicyAsync, grpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            _callTestIamPermissions = clientHelper.BuildApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse>("TestIamPermissions", grpcClient.TestIamPermissionsAsync, grpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateWorkerPoolApiCall(ref gaxgrpc::ApiCall<CreateWorkerPoolRequest, lro::Operation> call);

        partial void Modify_GetWorkerPoolApiCall(ref gaxgrpc::ApiCall<GetWorkerPoolRequest, WorkerPool> call);

        partial void Modify_ListWorkerPoolsApiCall(ref gaxgrpc::ApiCall<ListWorkerPoolsRequest, ListWorkerPoolsResponse> call);

        partial void Modify_UpdateWorkerPoolApiCall(ref gaxgrpc::ApiCall<UpdateWorkerPoolRequest, lro::Operation> call);

        partial void Modify_DeleteWorkerPoolApiCall(ref gaxgrpc::ApiCall<DeleteWorkerPoolRequest, lro::Operation> call);

        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> call);

        partial void OnConstruction(WorkerPools.WorkerPoolsClient grpcClient, WorkerPoolsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC WorkerPools client</summary>
        public override WorkerPools.WorkerPoolsClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CreateWorkerPoolRequest(ref CreateWorkerPoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetWorkerPoolRequest(ref GetWorkerPoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListWorkerPoolsRequest(ref ListWorkerPoolsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateWorkerPoolRequest(ref UpdateWorkerPoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteWorkerPoolRequest(ref DeleteWorkerPoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIamPolicyRequest(ref gciv::GetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetIamPolicyRequest(ref gciv::SetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TestIamPermissionsRequest(ref gciv::TestIamPermissionsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateWorkerPool</c>.</summary>
        public override lro::OperationsClient CreateWorkerPoolOperationsClient { get; }

        /// <summary>
        /// Creates a new WorkerPool in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<WorkerPool, WorkerPool> CreateWorkerPool(CreateWorkerPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateWorkerPoolRequest(ref request, ref callSettings);
            return new lro::Operation<WorkerPool, WorkerPool>(_callCreateWorkerPool.Sync(request, callSettings), CreateWorkerPoolOperationsClient);
        }

        /// <summary>
        /// Creates a new WorkerPool in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<WorkerPool, WorkerPool>> CreateWorkerPoolAsync(CreateWorkerPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateWorkerPoolRequest(ref request, ref callSettings);
            return new lro::Operation<WorkerPool, WorkerPool>(await _callCreateWorkerPool.Async(request, callSettings).ConfigureAwait(false), CreateWorkerPoolOperationsClient);
        }

        /// <summary>
        /// Gets information about a WorkerPool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override WorkerPool GetWorkerPool(GetWorkerPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetWorkerPoolRequest(ref request, ref callSettings);
            return _callGetWorkerPool.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets information about a WorkerPool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<WorkerPool> GetWorkerPoolAsync(GetWorkerPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetWorkerPoolRequest(ref request, ref callSettings);
            return _callGetWorkerPool.Async(request, callSettings);
        }

        /// <summary>
        /// Lists WorkerPools. Results are sorted by creation time, descending.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="WorkerPool"/> resources.</returns>
        public override gax::PagedEnumerable<ListWorkerPoolsResponse, WorkerPool> ListWorkerPools(ListWorkerPoolsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListWorkerPoolsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListWorkerPoolsRequest, ListWorkerPoolsResponse, WorkerPool>(_callListWorkerPools, request, callSettings);
        }

        /// <summary>
        /// Lists WorkerPools. Results are sorted by creation time, descending.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="WorkerPool"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListWorkerPoolsResponse, WorkerPool> ListWorkerPoolsAsync(ListWorkerPoolsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListWorkerPoolsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListWorkerPoolsRequest, ListWorkerPoolsResponse, WorkerPool>(_callListWorkerPools, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateWorkerPool</c>.</summary>
        public override lro::OperationsClient UpdateWorkerPoolOperationsClient { get; }

        /// <summary>
        /// Updates a WorkerPool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<WorkerPool, WorkerPool> UpdateWorkerPool(UpdateWorkerPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateWorkerPoolRequest(ref request, ref callSettings);
            return new lro::Operation<WorkerPool, WorkerPool>(_callUpdateWorkerPool.Sync(request, callSettings), UpdateWorkerPoolOperationsClient);
        }

        /// <summary>
        /// Updates a WorkerPool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<WorkerPool, WorkerPool>> UpdateWorkerPoolAsync(UpdateWorkerPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateWorkerPoolRequest(ref request, ref callSettings);
            return new lro::Operation<WorkerPool, WorkerPool>(await _callUpdateWorkerPool.Async(request, callSettings).ConfigureAwait(false), UpdateWorkerPoolOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteWorkerPool</c>.</summary>
        public override lro::OperationsClient DeleteWorkerPoolOperationsClient { get; }

        /// <summary>
        /// Deletes a WorkerPool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<WorkerPool, WorkerPool> DeleteWorkerPool(DeleteWorkerPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteWorkerPoolRequest(ref request, ref callSettings);
            return new lro::Operation<WorkerPool, WorkerPool>(_callDeleteWorkerPool.Sync(request, callSettings), DeleteWorkerPoolOperationsClient);
        }

        /// <summary>
        /// Deletes a WorkerPool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<WorkerPool, WorkerPool>> DeleteWorkerPoolAsync(DeleteWorkerPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteWorkerPoolRequest(ref request, ref callSettings);
            return new lro::Operation<WorkerPool, WorkerPool>(await _callDeleteWorkerPool.Async(request, callSettings).ConfigureAwait(false), DeleteWorkerPoolOperationsClient);
        }

        /// <summary>
        /// Gets the IAM Access Control policy currently in effect for the given
        /// Cloud Run WorkerPool. This result does not include any inherited policies.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the IAM Access Control policy currently in effect for the given
        /// Cloud Run WorkerPool. This result does not include any inherited policies.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the IAM Access control policy for the specified WorkerPool. Overwrites
        /// any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the IAM Access control policy for the specified WorkerPool. Overwrites
        /// any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified Project.
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified Project.
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Async(request, callSettings);
        }
    }

    public partial class ListWorkerPoolsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListWorkerPoolsResponse : gaxgrpc::IPageResponse<WorkerPool>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<WorkerPool> GetEnumerator() => WorkerPools.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class WorkerPools
    {
        public partial class WorkerPoolsClient
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

    public static partial class WorkerPools
    {
        public partial class WorkerPoolsClient
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
