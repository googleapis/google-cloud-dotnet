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

namespace Google.Cloud.AssuredWorkloads.V1
{
    /// <summary>Settings for <see cref="AssuredWorkloadsServiceClient"/> instances.</summary>
    public sealed partial class AssuredWorkloadsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AssuredWorkloadsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AssuredWorkloadsServiceSettings"/>.</returns>
        public static AssuredWorkloadsServiceSettings GetDefault() => new AssuredWorkloadsServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="AssuredWorkloadsServiceSettings"/> object with default settings.
        /// </summary>
        public AssuredWorkloadsServiceSettings()
        {
        }

        private AssuredWorkloadsServiceSettings(AssuredWorkloadsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateWorkloadSettings = existing.CreateWorkloadSettings;
            CreateWorkloadOperationsSettings = existing.CreateWorkloadOperationsSettings.Clone();
            UpdateWorkloadSettings = existing.UpdateWorkloadSettings;
            RestrictAllowedResourcesSettings = existing.RestrictAllowedResourcesSettings;
            DeleteWorkloadSettings = existing.DeleteWorkloadSettings;
            GetWorkloadSettings = existing.GetWorkloadSettings;
            ListWorkloadsSettings = existing.ListWorkloadsSettings;
            ListViolationsSettings = existing.ListViolationsSettings;
            GetViolationSettings = existing.GetViolationSettings;
            AcknowledgeViolationSettings = existing.AcknowledgeViolationSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AssuredWorkloadsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssuredWorkloadsServiceClient.CreateWorkload</c> and <c>AssuredWorkloadsServiceClient.CreateWorkloadAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateWorkloadSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AssuredWorkloadsServiceClient.CreateWorkload</c> and
        /// <c>AssuredWorkloadsServiceClient.CreateWorkloadAsync</c>.
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
        public lro::OperationsSettings CreateWorkloadOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssuredWorkloadsServiceClient.UpdateWorkload</c> and <c>AssuredWorkloadsServiceClient.UpdateWorkloadAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateWorkloadSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssuredWorkloadsServiceClient.RestrictAllowedResources</c> and
        /// <c>AssuredWorkloadsServiceClient.RestrictAllowedResourcesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RestrictAllowedResourcesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssuredWorkloadsServiceClient.DeleteWorkload</c> and <c>AssuredWorkloadsServiceClient.DeleteWorkloadAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteWorkloadSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssuredWorkloadsServiceClient.GetWorkload</c> and <c>AssuredWorkloadsServiceClient.GetWorkloadAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetWorkloadSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssuredWorkloadsServiceClient.ListWorkloads</c> and <c>AssuredWorkloadsServiceClient.ListWorkloadsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListWorkloadsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssuredWorkloadsServiceClient.ListViolations</c> and <c>AssuredWorkloadsServiceClient.ListViolationsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListViolationsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssuredWorkloadsServiceClient.GetViolation</c> and <c>AssuredWorkloadsServiceClient.GetViolationAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetViolationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssuredWorkloadsServiceClient.AcknowledgeViolation</c> and
        /// <c>AssuredWorkloadsServiceClient.AcknowledgeViolationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AcknowledgeViolationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AssuredWorkloadsServiceSettings"/> object.</returns>
        public AssuredWorkloadsServiceSettings Clone() => new AssuredWorkloadsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AssuredWorkloadsServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class AssuredWorkloadsServiceClientBuilder : gaxgrpc::ClientBuilderBase<AssuredWorkloadsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AssuredWorkloadsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AssuredWorkloadsServiceClientBuilder() : base(AssuredWorkloadsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AssuredWorkloadsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AssuredWorkloadsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AssuredWorkloadsServiceClient Build()
        {
            AssuredWorkloadsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AssuredWorkloadsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AssuredWorkloadsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AssuredWorkloadsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AssuredWorkloadsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AssuredWorkloadsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AssuredWorkloadsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AssuredWorkloadsServiceClient.ChannelPool;
    }

    /// <summary>AssuredWorkloadsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage AssuredWorkloads.
    /// </remarks>
    public abstract partial class AssuredWorkloadsServiceClient
    {
        /// <summary>
        /// The default endpoint for the AssuredWorkloadsService service, which is a host of
        /// "assuredworkloads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "assuredworkloads.googleapis.com:443";

        /// <summary>The default AssuredWorkloadsService scopes.</summary>
        /// <remarks>
        /// The default AssuredWorkloadsService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AssuredWorkloadsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AssuredWorkloadsServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="AssuredWorkloadsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AssuredWorkloadsServiceClient"/>.</returns>
        public static stt::Task<AssuredWorkloadsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AssuredWorkloadsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AssuredWorkloadsServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="AssuredWorkloadsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AssuredWorkloadsServiceClient"/>.</returns>
        public static AssuredWorkloadsServiceClient Create() => new AssuredWorkloadsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AssuredWorkloadsServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AssuredWorkloadsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AssuredWorkloadsServiceClient"/>.</returns>
        internal static AssuredWorkloadsServiceClient Create(grpccore::CallInvoker callInvoker, AssuredWorkloadsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AssuredWorkloadsService.AssuredWorkloadsServiceClient grpcClient = new AssuredWorkloadsService.AssuredWorkloadsServiceClient(callInvoker);
            return new AssuredWorkloadsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AssuredWorkloadsService client</summary>
        public virtual AssuredWorkloadsService.AssuredWorkloadsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates Assured Workload.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Workload, CreateWorkloadOperationMetadata> CreateWorkload(CreateWorkloadRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates Assured Workload.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workload, CreateWorkloadOperationMetadata>> CreateWorkloadAsync(CreateWorkloadRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates Assured Workload.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workload, CreateWorkloadOperationMetadata>> CreateWorkloadAsync(CreateWorkloadRequest request, st::CancellationToken cancellationToken) =>
            CreateWorkloadAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateWorkload</c>.</summary>
        public virtual lro::OperationsClient CreateWorkloadOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateWorkload</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Workload, CreateWorkloadOperationMetadata> PollOnceCreateWorkload(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Workload, CreateWorkloadOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateWorkloadOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateWorkload</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Workload, CreateWorkloadOperationMetadata>> PollOnceCreateWorkloadAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Workload, CreateWorkloadOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateWorkloadOperationsClient, callSettings);

        /// <summary>
        /// Creates Assured Workload.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the new Workload's parent.
        /// Must be of the form `organizations/{org_id}/locations/{location_id}`.
        /// </param>
        /// <param name="workload">
        /// Required. Assured Workload to create
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Workload, CreateWorkloadOperationMetadata> CreateWorkload(string parent, Workload workload, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkload(new CreateWorkloadRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Workload = gax::GaxPreconditions.CheckNotNull(workload, nameof(workload)),
            }, callSettings);

        /// <summary>
        /// Creates Assured Workload.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the new Workload's parent.
        /// Must be of the form `organizations/{org_id}/locations/{location_id}`.
        /// </param>
        /// <param name="workload">
        /// Required. Assured Workload to create
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workload, CreateWorkloadOperationMetadata>> CreateWorkloadAsync(string parent, Workload workload, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkloadAsync(new CreateWorkloadRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Workload = gax::GaxPreconditions.CheckNotNull(workload, nameof(workload)),
            }, callSettings);

        /// <summary>
        /// Creates Assured Workload.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the new Workload's parent.
        /// Must be of the form `organizations/{org_id}/locations/{location_id}`.
        /// </param>
        /// <param name="workload">
        /// Required. Assured Workload to create
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workload, CreateWorkloadOperationMetadata>> CreateWorkloadAsync(string parent, Workload workload, st::CancellationToken cancellationToken) =>
            CreateWorkloadAsync(parent, workload, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates Assured Workload.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the new Workload's parent.
        /// Must be of the form `organizations/{org_id}/locations/{location_id}`.
        /// </param>
        /// <param name="workload">
        /// Required. Assured Workload to create
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Workload, CreateWorkloadOperationMetadata> CreateWorkload(LocationName parent, Workload workload, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkload(new CreateWorkloadRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Workload = gax::GaxPreconditions.CheckNotNull(workload, nameof(workload)),
            }, callSettings);

        /// <summary>
        /// Creates Assured Workload.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the new Workload's parent.
        /// Must be of the form `organizations/{org_id}/locations/{location_id}`.
        /// </param>
        /// <param name="workload">
        /// Required. Assured Workload to create
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workload, CreateWorkloadOperationMetadata>> CreateWorkloadAsync(LocationName parent, Workload workload, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkloadAsync(new CreateWorkloadRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Workload = gax::GaxPreconditions.CheckNotNull(workload, nameof(workload)),
            }, callSettings);

        /// <summary>
        /// Creates Assured Workload.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the new Workload's parent.
        /// Must be of the form `organizations/{org_id}/locations/{location_id}`.
        /// </param>
        /// <param name="workload">
        /// Required. Assured Workload to create
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workload, CreateWorkloadOperationMetadata>> CreateWorkloadAsync(LocationName parent, Workload workload, st::CancellationToken cancellationToken) =>
            CreateWorkloadAsync(parent, workload, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing workload.
        /// Currently allows updating of workload display_name and labels.
        /// For force updates don't set etag field in the Workload.
        /// Only one update operation per workload can be in progress.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Workload UpdateWorkload(UpdateWorkloadRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing workload.
        /// Currently allows updating of workload display_name and labels.
        /// For force updates don't set etag field in the Workload.
        /// Only one update operation per workload can be in progress.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workload> UpdateWorkloadAsync(UpdateWorkloadRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing workload.
        /// Currently allows updating of workload display_name and labels.
        /// For force updates don't set etag field in the Workload.
        /// Only one update operation per workload can be in progress.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workload> UpdateWorkloadAsync(UpdateWorkloadRequest request, st::CancellationToken cancellationToken) =>
            UpdateWorkloadAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing workload.
        /// Currently allows updating of workload display_name and labels.
        /// For force updates don't set etag field in the Workload.
        /// Only one update operation per workload can be in progress.
        /// </summary>
        /// <param name="workload">
        /// Required. The workload to update.
        /// The workload's `name` field is used to identify the workload to be updated.
        /// Format:
        /// organizations/{org_id}/locations/{location_id}/workloads/{workload_id}
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Workload UpdateWorkload(Workload workload, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateWorkload(new UpdateWorkloadRequest
            {
                Workload = gax::GaxPreconditions.CheckNotNull(workload, nameof(workload)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an existing workload.
        /// Currently allows updating of workload display_name and labels.
        /// For force updates don't set etag field in the Workload.
        /// Only one update operation per workload can be in progress.
        /// </summary>
        /// <param name="workload">
        /// Required. The workload to update.
        /// The workload's `name` field is used to identify the workload to be updated.
        /// Format:
        /// organizations/{org_id}/locations/{location_id}/workloads/{workload_id}
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workload> UpdateWorkloadAsync(Workload workload, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateWorkloadAsync(new UpdateWorkloadRequest
            {
                Workload = gax::GaxPreconditions.CheckNotNull(workload, nameof(workload)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an existing workload.
        /// Currently allows updating of workload display_name and labels.
        /// For force updates don't set etag field in the Workload.
        /// Only one update operation per workload can be in progress.
        /// </summary>
        /// <param name="workload">
        /// Required. The workload to update.
        /// The workload's `name` field is used to identify the workload to be updated.
        /// Format:
        /// organizations/{org_id}/locations/{location_id}/workloads/{workload_id}
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workload> UpdateWorkloadAsync(Workload workload, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateWorkloadAsync(workload, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Restrict the list of resources allowed in the Workload environment.
        /// The current list of allowed products can be found at
        /// https://cloud.google.com/assured-workloads/docs/supported-products
        /// In addition to assuredworkloads.workload.update permission, the user should
        /// also have orgpolicy.policy.set permission on the folder resource
        /// to use this functionality.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RestrictAllowedResourcesResponse RestrictAllowedResources(RestrictAllowedResourcesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Restrict the list of resources allowed in the Workload environment.
        /// The current list of allowed products can be found at
        /// https://cloud.google.com/assured-workloads/docs/supported-products
        /// In addition to assuredworkloads.workload.update permission, the user should
        /// also have orgpolicy.policy.set permission on the folder resource
        /// to use this functionality.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RestrictAllowedResourcesResponse> RestrictAllowedResourcesAsync(RestrictAllowedResourcesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Restrict the list of resources allowed in the Workload environment.
        /// The current list of allowed products can be found at
        /// https://cloud.google.com/assured-workloads/docs/supported-products
        /// In addition to assuredworkloads.workload.update permission, the user should
        /// also have orgpolicy.policy.set permission on the folder resource
        /// to use this functionality.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RestrictAllowedResourcesResponse> RestrictAllowedResourcesAsync(RestrictAllowedResourcesRequest request, st::CancellationToken cancellationToken) =>
            RestrictAllowedResourcesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the workload. Make sure that workload's direct children are already
        /// in a deleted state, otherwise the request will fail with a
        /// FAILED_PRECONDITION error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteWorkload(DeleteWorkloadRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the workload. Make sure that workload's direct children are already
        /// in a deleted state, otherwise the request will fail with a
        /// FAILED_PRECONDITION error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteWorkloadAsync(DeleteWorkloadRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the workload. Make sure that workload's direct children are already
        /// in a deleted state, otherwise the request will fail with a
        /// FAILED_PRECONDITION error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteWorkloadAsync(DeleteWorkloadRequest request, st::CancellationToken cancellationToken) =>
            DeleteWorkloadAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the workload. Make sure that workload's direct children are already
        /// in a deleted state, otherwise the request will fail with a
        /// FAILED_PRECONDITION error.
        /// </summary>
        /// <param name="name">
        /// Required. The `name` field is used to identify the workload.
        /// Format:
        /// organizations/{org_id}/locations/{location_id}/workloads/{workload_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteWorkload(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkload(new DeleteWorkloadRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the workload. Make sure that workload's direct children are already
        /// in a deleted state, otherwise the request will fail with a
        /// FAILED_PRECONDITION error.
        /// </summary>
        /// <param name="name">
        /// Required. The `name` field is used to identify the workload.
        /// Format:
        /// organizations/{org_id}/locations/{location_id}/workloads/{workload_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteWorkloadAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkloadAsync(new DeleteWorkloadRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the workload. Make sure that workload's direct children are already
        /// in a deleted state, otherwise the request will fail with a
        /// FAILED_PRECONDITION error.
        /// </summary>
        /// <param name="name">
        /// Required. The `name` field is used to identify the workload.
        /// Format:
        /// organizations/{org_id}/locations/{location_id}/workloads/{workload_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteWorkloadAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteWorkloadAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the workload. Make sure that workload's direct children are already
        /// in a deleted state, otherwise the request will fail with a
        /// FAILED_PRECONDITION error.
        /// </summary>
        /// <param name="name">
        /// Required. The `name` field is used to identify the workload.
        /// Format:
        /// organizations/{org_id}/locations/{location_id}/workloads/{workload_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteWorkload(WorkloadName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkload(new DeleteWorkloadRequest
            {
                WorkloadName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the workload. Make sure that workload's direct children are already
        /// in a deleted state, otherwise the request will fail with a
        /// FAILED_PRECONDITION error.
        /// </summary>
        /// <param name="name">
        /// Required. The `name` field is used to identify the workload.
        /// Format:
        /// organizations/{org_id}/locations/{location_id}/workloads/{workload_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteWorkloadAsync(WorkloadName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkloadAsync(new DeleteWorkloadRequest
            {
                WorkloadName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the workload. Make sure that workload's direct children are already
        /// in a deleted state, otherwise the request will fail with a
        /// FAILED_PRECONDITION error.
        /// </summary>
        /// <param name="name">
        /// Required. The `name` field is used to identify the workload.
        /// Format:
        /// organizations/{org_id}/locations/{location_id}/workloads/{workload_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteWorkloadAsync(WorkloadName name, st::CancellationToken cancellationToken) =>
            DeleteWorkloadAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets Assured Workload associated with a CRM Node
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Workload GetWorkload(GetWorkloadRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets Assured Workload associated with a CRM Node
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workload> GetWorkloadAsync(GetWorkloadRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets Assured Workload associated with a CRM Node
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workload> GetWorkloadAsync(GetWorkloadRequest request, st::CancellationToken cancellationToken) =>
            GetWorkloadAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets Assured Workload associated with a CRM Node
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Workload to fetch. This is the workload's
        /// relative path in the API, formatted as
        /// "organizations/{organization_id}/locations/{location_id}/workloads/{workload_id}".
        /// For example,
        /// "organizations/123/locations/us-east1/workloads/assured-workload-1".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Workload GetWorkload(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkload(new GetWorkloadRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets Assured Workload associated with a CRM Node
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Workload to fetch. This is the workload's
        /// relative path in the API, formatted as
        /// "organizations/{organization_id}/locations/{location_id}/workloads/{workload_id}".
        /// For example,
        /// "organizations/123/locations/us-east1/workloads/assured-workload-1".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workload> GetWorkloadAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkloadAsync(new GetWorkloadRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets Assured Workload associated with a CRM Node
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Workload to fetch. This is the workload's
        /// relative path in the API, formatted as
        /// "organizations/{organization_id}/locations/{location_id}/workloads/{workload_id}".
        /// For example,
        /// "organizations/123/locations/us-east1/workloads/assured-workload-1".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workload> GetWorkloadAsync(string name, st::CancellationToken cancellationToken) =>
            GetWorkloadAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets Assured Workload associated with a CRM Node
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Workload to fetch. This is the workload's
        /// relative path in the API, formatted as
        /// "organizations/{organization_id}/locations/{location_id}/workloads/{workload_id}".
        /// For example,
        /// "organizations/123/locations/us-east1/workloads/assured-workload-1".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Workload GetWorkload(WorkloadName name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkload(new GetWorkloadRequest
            {
                WorkloadName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets Assured Workload associated with a CRM Node
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Workload to fetch. This is the workload's
        /// relative path in the API, formatted as
        /// "organizations/{organization_id}/locations/{location_id}/workloads/{workload_id}".
        /// For example,
        /// "organizations/123/locations/us-east1/workloads/assured-workload-1".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workload> GetWorkloadAsync(WorkloadName name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkloadAsync(new GetWorkloadRequest
            {
                WorkloadName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets Assured Workload associated with a CRM Node
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Workload to fetch. This is the workload's
        /// relative path in the API, formatted as
        /// "organizations/{organization_id}/locations/{location_id}/workloads/{workload_id}".
        /// For example,
        /// "organizations/123/locations/us-east1/workloads/assured-workload-1".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workload> GetWorkloadAsync(WorkloadName name, st::CancellationToken cancellationToken) =>
            GetWorkloadAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Assured Workloads under a CRM Node.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Workload"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkloadsResponse, Workload> ListWorkloads(ListWorkloadsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Assured Workloads under a CRM Node.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Workload"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkloadsResponse, Workload> ListWorkloadsAsync(ListWorkloadsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Assured Workloads under a CRM Node.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent Resource to list workloads from.
        /// Must be of the form `organizations/{org_id}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="Workload"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkloadsResponse, Workload> ListWorkloads(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkloadsRequest request = new ListWorkloadsRequest
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
            return ListWorkloads(request, callSettings);
        }

        /// <summary>
        /// Lists Assured Workloads under a CRM Node.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent Resource to list workloads from.
        /// Must be of the form `organizations/{org_id}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Workload"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkloadsResponse, Workload> ListWorkloadsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkloadsRequest request = new ListWorkloadsRequest
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
            return ListWorkloadsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Assured Workloads under a CRM Node.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent Resource to list workloads from.
        /// Must be of the form `organizations/{org_id}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="Workload"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkloadsResponse, Workload> ListWorkloads(LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkloadsRequest request = new ListWorkloadsRequest
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
            return ListWorkloads(request, callSettings);
        }

        /// <summary>
        /// Lists Assured Workloads under a CRM Node.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent Resource to list workloads from.
        /// Must be of the form `organizations/{org_id}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Workload"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkloadsResponse, Workload> ListWorkloadsAsync(LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkloadsRequest request = new ListWorkloadsRequest
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
            return ListWorkloadsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the Violations in the AssuredWorkload Environment.
        /// Callers may also choose to read across multiple Workloads as per
        /// [AIP-159](https://google.aip.dev/159) by using '-' (the hyphen or dash
        /// character) as a wildcard character instead of workload-id in the parent.
        /// Format `organizations/{org_id}/locations/{location}/workloads/-`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Violation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListViolationsResponse, Violation> ListViolations(ListViolationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the Violations in the AssuredWorkload Environment.
        /// Callers may also choose to read across multiple Workloads as per
        /// [AIP-159](https://google.aip.dev/159) by using '-' (the hyphen or dash
        /// character) as a wildcard character instead of workload-id in the parent.
        /// Format `organizations/{org_id}/locations/{location}/workloads/-`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Violation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListViolationsResponse, Violation> ListViolationsAsync(ListViolationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the Violations in the AssuredWorkload Environment.
        /// Callers may also choose to read across multiple Workloads as per
        /// [AIP-159](https://google.aip.dev/159) by using '-' (the hyphen or dash
        /// character) as a wildcard character instead of workload-id in the parent.
        /// Format `organizations/{org_id}/locations/{location}/workloads/-`
        /// </summary>
        /// <param name="parent">
        /// Required. The Workload name.
        /// Format `organizations/{org_id}/locations/{location}/workloads/{workload}`.
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
        /// <returns>A pageable sequence of <see cref="Violation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListViolationsResponse, Violation> ListViolations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListViolationsRequest request = new ListViolationsRequest
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
            return ListViolations(request, callSettings);
        }

        /// <summary>
        /// Lists the Violations in the AssuredWorkload Environment.
        /// Callers may also choose to read across multiple Workloads as per
        /// [AIP-159](https://google.aip.dev/159) by using '-' (the hyphen or dash
        /// character) as a wildcard character instead of workload-id in the parent.
        /// Format `organizations/{org_id}/locations/{location}/workloads/-`
        /// </summary>
        /// <param name="parent">
        /// Required. The Workload name.
        /// Format `organizations/{org_id}/locations/{location}/workloads/{workload}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Violation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListViolationsResponse, Violation> ListViolationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListViolationsRequest request = new ListViolationsRequest
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
            return ListViolationsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the Violations in the AssuredWorkload Environment.
        /// Callers may also choose to read across multiple Workloads as per
        /// [AIP-159](https://google.aip.dev/159) by using '-' (the hyphen or dash
        /// character) as a wildcard character instead of workload-id in the parent.
        /// Format `organizations/{org_id}/locations/{location}/workloads/-`
        /// </summary>
        /// <param name="parent">
        /// Required. The Workload name.
        /// Format `organizations/{org_id}/locations/{location}/workloads/{workload}`.
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
        /// <returns>A pageable sequence of <see cref="Violation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListViolationsResponse, Violation> ListViolations(WorkloadName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListViolationsRequest request = new ListViolationsRequest
            {
                ParentAsWorkloadName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListViolations(request, callSettings);
        }

        /// <summary>
        /// Lists the Violations in the AssuredWorkload Environment.
        /// Callers may also choose to read across multiple Workloads as per
        /// [AIP-159](https://google.aip.dev/159) by using '-' (the hyphen or dash
        /// character) as a wildcard character instead of workload-id in the parent.
        /// Format `organizations/{org_id}/locations/{location}/workloads/-`
        /// </summary>
        /// <param name="parent">
        /// Required. The Workload name.
        /// Format `organizations/{org_id}/locations/{location}/workloads/{workload}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Violation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListViolationsResponse, Violation> ListViolationsAsync(WorkloadName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListViolationsRequest request = new ListViolationsRequest
            {
                ParentAsWorkloadName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListViolationsAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves Assured Workload Violation based on ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Violation GetViolation(GetViolationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves Assured Workload Violation based on ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Violation> GetViolationAsync(GetViolationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves Assured Workload Violation based on ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Violation> GetViolationAsync(GetViolationRequest request, st::CancellationToken cancellationToken) =>
            GetViolationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves Assured Workload Violation based on ID.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Violation to fetch (ie. Violation.name).
        /// Format:
        /// organizations/{organization}/locations/{location}/workloads/{workload}/violations/{violation}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Violation GetViolation(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetViolation(new GetViolationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves Assured Workload Violation based on ID.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Violation to fetch (ie. Violation.name).
        /// Format:
        /// organizations/{organization}/locations/{location}/workloads/{workload}/violations/{violation}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Violation> GetViolationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetViolationAsync(new GetViolationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves Assured Workload Violation based on ID.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Violation to fetch (ie. Violation.name).
        /// Format:
        /// organizations/{organization}/locations/{location}/workloads/{workload}/violations/{violation}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Violation> GetViolationAsync(string name, st::CancellationToken cancellationToken) =>
            GetViolationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves Assured Workload Violation based on ID.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Violation to fetch (ie. Violation.name).
        /// Format:
        /// organizations/{organization}/locations/{location}/workloads/{workload}/violations/{violation}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Violation GetViolation(ViolationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetViolation(new GetViolationRequest
            {
                ViolationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves Assured Workload Violation based on ID.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Violation to fetch (ie. Violation.name).
        /// Format:
        /// organizations/{organization}/locations/{location}/workloads/{workload}/violations/{violation}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Violation> GetViolationAsync(ViolationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetViolationAsync(new GetViolationRequest
            {
                ViolationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves Assured Workload Violation based on ID.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Violation to fetch (ie. Violation.name).
        /// Format:
        /// organizations/{organization}/locations/{location}/workloads/{workload}/violations/{violation}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Violation> GetViolationAsync(ViolationName name, st::CancellationToken cancellationToken) =>
            GetViolationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Acknowledges an existing violation. By acknowledging a violation, users
        /// acknowledge the existence of a compliance violation in their workload and
        /// decide to ignore it due to a valid business justification. Acknowledgement
        /// is a permanent operation and it cannot be reverted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AcknowledgeViolationResponse AcknowledgeViolation(AcknowledgeViolationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Acknowledges an existing violation. By acknowledging a violation, users
        /// acknowledge the existence of a compliance violation in their workload and
        /// decide to ignore it due to a valid business justification. Acknowledgement
        /// is a permanent operation and it cannot be reverted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AcknowledgeViolationResponse> AcknowledgeViolationAsync(AcknowledgeViolationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Acknowledges an existing violation. By acknowledging a violation, users
        /// acknowledge the existence of a compliance violation in their workload and
        /// decide to ignore it due to a valid business justification. Acknowledgement
        /// is a permanent operation and it cannot be reverted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AcknowledgeViolationResponse> AcknowledgeViolationAsync(AcknowledgeViolationRequest request, st::CancellationToken cancellationToken) =>
            AcknowledgeViolationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AssuredWorkloadsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage AssuredWorkloads.
    /// </remarks>
    public sealed partial class AssuredWorkloadsServiceClientImpl : AssuredWorkloadsServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateWorkloadRequest, lro::Operation> _callCreateWorkload;

        private readonly gaxgrpc::ApiCall<UpdateWorkloadRequest, Workload> _callUpdateWorkload;

        private readonly gaxgrpc::ApiCall<RestrictAllowedResourcesRequest, RestrictAllowedResourcesResponse> _callRestrictAllowedResources;

        private readonly gaxgrpc::ApiCall<DeleteWorkloadRequest, wkt::Empty> _callDeleteWorkload;

        private readonly gaxgrpc::ApiCall<GetWorkloadRequest, Workload> _callGetWorkload;

        private readonly gaxgrpc::ApiCall<ListWorkloadsRequest, ListWorkloadsResponse> _callListWorkloads;

        private readonly gaxgrpc::ApiCall<ListViolationsRequest, ListViolationsResponse> _callListViolations;

        private readonly gaxgrpc::ApiCall<GetViolationRequest, Violation> _callGetViolation;

        private readonly gaxgrpc::ApiCall<AcknowledgeViolationRequest, AcknowledgeViolationResponse> _callAcknowledgeViolation;

        /// <summary>
        /// Constructs a client wrapper for the AssuredWorkloadsService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="AssuredWorkloadsServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AssuredWorkloadsServiceClientImpl(AssuredWorkloadsService.AssuredWorkloadsServiceClient grpcClient, AssuredWorkloadsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AssuredWorkloadsServiceSettings effectiveSettings = settings ?? AssuredWorkloadsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateWorkloadOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateWorkloadOperationsSettings, logger);
            _callCreateWorkload = clientHelper.BuildApiCall<CreateWorkloadRequest, lro::Operation>("CreateWorkload", grpcClient.CreateWorkloadAsync, grpcClient.CreateWorkload, effectiveSettings.CreateWorkloadSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateWorkload);
            Modify_CreateWorkloadApiCall(ref _callCreateWorkload);
            _callUpdateWorkload = clientHelper.BuildApiCall<UpdateWorkloadRequest, Workload>("UpdateWorkload", grpcClient.UpdateWorkloadAsync, grpcClient.UpdateWorkload, effectiveSettings.UpdateWorkloadSettings).WithGoogleRequestParam("workload.name", request => request.Workload?.Name);
            Modify_ApiCall(ref _callUpdateWorkload);
            Modify_UpdateWorkloadApiCall(ref _callUpdateWorkload);
            _callRestrictAllowedResources = clientHelper.BuildApiCall<RestrictAllowedResourcesRequest, RestrictAllowedResourcesResponse>("RestrictAllowedResources", grpcClient.RestrictAllowedResourcesAsync, grpcClient.RestrictAllowedResources, effectiveSettings.RestrictAllowedResourcesSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRestrictAllowedResources);
            Modify_RestrictAllowedResourcesApiCall(ref _callRestrictAllowedResources);
            _callDeleteWorkload = clientHelper.BuildApiCall<DeleteWorkloadRequest, wkt::Empty>("DeleteWorkload", grpcClient.DeleteWorkloadAsync, grpcClient.DeleteWorkload, effectiveSettings.DeleteWorkloadSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteWorkload);
            Modify_DeleteWorkloadApiCall(ref _callDeleteWorkload);
            _callGetWorkload = clientHelper.BuildApiCall<GetWorkloadRequest, Workload>("GetWorkload", grpcClient.GetWorkloadAsync, grpcClient.GetWorkload, effectiveSettings.GetWorkloadSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetWorkload);
            Modify_GetWorkloadApiCall(ref _callGetWorkload);
            _callListWorkloads = clientHelper.BuildApiCall<ListWorkloadsRequest, ListWorkloadsResponse>("ListWorkloads", grpcClient.ListWorkloadsAsync, grpcClient.ListWorkloads, effectiveSettings.ListWorkloadsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListWorkloads);
            Modify_ListWorkloadsApiCall(ref _callListWorkloads);
            _callListViolations = clientHelper.BuildApiCall<ListViolationsRequest, ListViolationsResponse>("ListViolations", grpcClient.ListViolationsAsync, grpcClient.ListViolations, effectiveSettings.ListViolationsSettings);
            Modify_ApiCall(ref _callListViolations);
            Modify_ListViolationsApiCall(ref _callListViolations);
            _callGetViolation = clientHelper.BuildApiCall<GetViolationRequest, Violation>("GetViolation", grpcClient.GetViolationAsync, grpcClient.GetViolation, effectiveSettings.GetViolationSettings);
            Modify_ApiCall(ref _callGetViolation);
            Modify_GetViolationApiCall(ref _callGetViolation);
            _callAcknowledgeViolation = clientHelper.BuildApiCall<AcknowledgeViolationRequest, AcknowledgeViolationResponse>("AcknowledgeViolation", grpcClient.AcknowledgeViolationAsync, grpcClient.AcknowledgeViolation, effectiveSettings.AcknowledgeViolationSettings);
            Modify_ApiCall(ref _callAcknowledgeViolation);
            Modify_AcknowledgeViolationApiCall(ref _callAcknowledgeViolation);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateWorkloadApiCall(ref gaxgrpc::ApiCall<CreateWorkloadRequest, lro::Operation> call);

        partial void Modify_UpdateWorkloadApiCall(ref gaxgrpc::ApiCall<UpdateWorkloadRequest, Workload> call);

        partial void Modify_RestrictAllowedResourcesApiCall(ref gaxgrpc::ApiCall<RestrictAllowedResourcesRequest, RestrictAllowedResourcesResponse> call);

        partial void Modify_DeleteWorkloadApiCall(ref gaxgrpc::ApiCall<DeleteWorkloadRequest, wkt::Empty> call);

        partial void Modify_GetWorkloadApiCall(ref gaxgrpc::ApiCall<GetWorkloadRequest, Workload> call);

        partial void Modify_ListWorkloadsApiCall(ref gaxgrpc::ApiCall<ListWorkloadsRequest, ListWorkloadsResponse> call);

        partial void Modify_ListViolationsApiCall(ref gaxgrpc::ApiCall<ListViolationsRequest, ListViolationsResponse> call);

        partial void Modify_GetViolationApiCall(ref gaxgrpc::ApiCall<GetViolationRequest, Violation> call);

        partial void Modify_AcknowledgeViolationApiCall(ref gaxgrpc::ApiCall<AcknowledgeViolationRequest, AcknowledgeViolationResponse> call);

        partial void OnConstruction(AssuredWorkloadsService.AssuredWorkloadsServiceClient grpcClient, AssuredWorkloadsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AssuredWorkloadsService client</summary>
        public override AssuredWorkloadsService.AssuredWorkloadsServiceClient GrpcClient { get; }

        partial void Modify_CreateWorkloadRequest(ref CreateWorkloadRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateWorkloadRequest(ref UpdateWorkloadRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RestrictAllowedResourcesRequest(ref RestrictAllowedResourcesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteWorkloadRequest(ref DeleteWorkloadRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetWorkloadRequest(ref GetWorkloadRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListWorkloadsRequest(ref ListWorkloadsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListViolationsRequest(ref ListViolationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetViolationRequest(ref GetViolationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AcknowledgeViolationRequest(ref AcknowledgeViolationRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateWorkload</c>.</summary>
        public override lro::OperationsClient CreateWorkloadOperationsClient { get; }

        /// <summary>
        /// Creates Assured Workload.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Workload, CreateWorkloadOperationMetadata> CreateWorkload(CreateWorkloadRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateWorkloadRequest(ref request, ref callSettings);
            return new lro::Operation<Workload, CreateWorkloadOperationMetadata>(_callCreateWorkload.Sync(request, callSettings), CreateWorkloadOperationsClient);
        }

        /// <summary>
        /// Creates Assured Workload.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Workload, CreateWorkloadOperationMetadata>> CreateWorkloadAsync(CreateWorkloadRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateWorkloadRequest(ref request, ref callSettings);
            return new lro::Operation<Workload, CreateWorkloadOperationMetadata>(await _callCreateWorkload.Async(request, callSettings).ConfigureAwait(false), CreateWorkloadOperationsClient);
        }

        /// <summary>
        /// Updates an existing workload.
        /// Currently allows updating of workload display_name and labels.
        /// For force updates don't set etag field in the Workload.
        /// Only one update operation per workload can be in progress.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Workload UpdateWorkload(UpdateWorkloadRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateWorkloadRequest(ref request, ref callSettings);
            return _callUpdateWorkload.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an existing workload.
        /// Currently allows updating of workload display_name and labels.
        /// For force updates don't set etag field in the Workload.
        /// Only one update operation per workload can be in progress.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Workload> UpdateWorkloadAsync(UpdateWorkloadRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateWorkloadRequest(ref request, ref callSettings);
            return _callUpdateWorkload.Async(request, callSettings);
        }

        /// <summary>
        /// Restrict the list of resources allowed in the Workload environment.
        /// The current list of allowed products can be found at
        /// https://cloud.google.com/assured-workloads/docs/supported-products
        /// In addition to assuredworkloads.workload.update permission, the user should
        /// also have orgpolicy.policy.set permission on the folder resource
        /// to use this functionality.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RestrictAllowedResourcesResponse RestrictAllowedResources(RestrictAllowedResourcesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestrictAllowedResourcesRequest(ref request, ref callSettings);
            return _callRestrictAllowedResources.Sync(request, callSettings);
        }

        /// <summary>
        /// Restrict the list of resources allowed in the Workload environment.
        /// The current list of allowed products can be found at
        /// https://cloud.google.com/assured-workloads/docs/supported-products
        /// In addition to assuredworkloads.workload.update permission, the user should
        /// also have orgpolicy.policy.set permission on the folder resource
        /// to use this functionality.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RestrictAllowedResourcesResponse> RestrictAllowedResourcesAsync(RestrictAllowedResourcesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestrictAllowedResourcesRequest(ref request, ref callSettings);
            return _callRestrictAllowedResources.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the workload. Make sure that workload's direct children are already
        /// in a deleted state, otherwise the request will fail with a
        /// FAILED_PRECONDITION error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteWorkload(DeleteWorkloadRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteWorkloadRequest(ref request, ref callSettings);
            _callDeleteWorkload.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the workload. Make sure that workload's direct children are already
        /// in a deleted state, otherwise the request will fail with a
        /// FAILED_PRECONDITION error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteWorkloadAsync(DeleteWorkloadRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteWorkloadRequest(ref request, ref callSettings);
            return _callDeleteWorkload.Async(request, callSettings);
        }

        /// <summary>
        /// Gets Assured Workload associated with a CRM Node
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Workload GetWorkload(GetWorkloadRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetWorkloadRequest(ref request, ref callSettings);
            return _callGetWorkload.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets Assured Workload associated with a CRM Node
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Workload> GetWorkloadAsync(GetWorkloadRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetWorkloadRequest(ref request, ref callSettings);
            return _callGetWorkload.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Assured Workloads under a CRM Node.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Workload"/> resources.</returns>
        public override gax::PagedEnumerable<ListWorkloadsResponse, Workload> ListWorkloads(ListWorkloadsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListWorkloadsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListWorkloadsRequest, ListWorkloadsResponse, Workload>(_callListWorkloads, request, callSettings);
        }

        /// <summary>
        /// Lists Assured Workloads under a CRM Node.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Workload"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListWorkloadsResponse, Workload> ListWorkloadsAsync(ListWorkloadsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListWorkloadsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListWorkloadsRequest, ListWorkloadsResponse, Workload>(_callListWorkloads, request, callSettings);
        }

        /// <summary>
        /// Lists the Violations in the AssuredWorkload Environment.
        /// Callers may also choose to read across multiple Workloads as per
        /// [AIP-159](https://google.aip.dev/159) by using '-' (the hyphen or dash
        /// character) as a wildcard character instead of workload-id in the parent.
        /// Format `organizations/{org_id}/locations/{location}/workloads/-`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Violation"/> resources.</returns>
        public override gax::PagedEnumerable<ListViolationsResponse, Violation> ListViolations(ListViolationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListViolationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListViolationsRequest, ListViolationsResponse, Violation>(_callListViolations, request, callSettings);
        }

        /// <summary>
        /// Lists the Violations in the AssuredWorkload Environment.
        /// Callers may also choose to read across multiple Workloads as per
        /// [AIP-159](https://google.aip.dev/159) by using '-' (the hyphen or dash
        /// character) as a wildcard character instead of workload-id in the parent.
        /// Format `organizations/{org_id}/locations/{location}/workloads/-`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Violation"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListViolationsResponse, Violation> ListViolationsAsync(ListViolationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListViolationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListViolationsRequest, ListViolationsResponse, Violation>(_callListViolations, request, callSettings);
        }

        /// <summary>
        /// Retrieves Assured Workload Violation based on ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Violation GetViolation(GetViolationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetViolationRequest(ref request, ref callSettings);
            return _callGetViolation.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves Assured Workload Violation based on ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Violation> GetViolationAsync(GetViolationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetViolationRequest(ref request, ref callSettings);
            return _callGetViolation.Async(request, callSettings);
        }

        /// <summary>
        /// Acknowledges an existing violation. By acknowledging a violation, users
        /// acknowledge the existence of a compliance violation in their workload and
        /// decide to ignore it due to a valid business justification. Acknowledgement
        /// is a permanent operation and it cannot be reverted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AcknowledgeViolationResponse AcknowledgeViolation(AcknowledgeViolationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AcknowledgeViolationRequest(ref request, ref callSettings);
            return _callAcknowledgeViolation.Sync(request, callSettings);
        }

        /// <summary>
        /// Acknowledges an existing violation. By acknowledging a violation, users
        /// acknowledge the existence of a compliance violation in their workload and
        /// decide to ignore it due to a valid business justification. Acknowledgement
        /// is a permanent operation and it cannot be reverted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AcknowledgeViolationResponse> AcknowledgeViolationAsync(AcknowledgeViolationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AcknowledgeViolationRequest(ref request, ref callSettings);
            return _callAcknowledgeViolation.Async(request, callSettings);
        }
    }

    public partial class ListWorkloadsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListViolationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListWorkloadsResponse : gaxgrpc::IPageResponse<Workload>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Workload> GetEnumerator() => Workloads.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListViolationsResponse : gaxgrpc::IPageResponse<Violation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Violation> GetEnumerator() => Violations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class AssuredWorkloadsService
    {
        public partial class AssuredWorkloadsServiceClient
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
