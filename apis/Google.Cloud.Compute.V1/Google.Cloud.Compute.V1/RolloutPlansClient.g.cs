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

namespace Google.Cloud.Compute.V1
{
    /// <summary>Settings for <see cref="RolloutPlansClient"/> instances.</summary>
    public sealed partial class RolloutPlansSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="RolloutPlansSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="RolloutPlansSettings"/>.</returns>
        public static RolloutPlansSettings GetDefault() => new RolloutPlansSettings();

        /// <summary>Constructs a new <see cref="RolloutPlansSettings"/> object with default settings.</summary>
        public RolloutPlansSettings()
        {
        }

        private RolloutPlansSettings(RolloutPlansSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            DeleteSettings = existing.DeleteSettings;
            DeleteOperationsSettings = existing.DeleteOperationsSettings.Clone();
            GetSettings = existing.GetSettings;
            InsertSettings = existing.InsertSettings;
            InsertOperationsSettings = existing.InsertOperationsSettings.Clone();
            ListSettings = existing.ListSettings;
            OnCopy(existing);
        }

        partial void OnCopy(RolloutPlansSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>RolloutPlansClient.Delete</c>
        ///  and <c>RolloutPlansClient.DeleteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>RolloutPlansClient.Delete</c> and
        /// <c>RolloutPlansClient.DeleteAsync</c>.
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
        public lro::OperationsSettings DeleteOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>RolloutPlansClient.Get</c>
        /// and <c>RolloutPlansClient.GetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>RolloutPlansClient.Insert</c>
        ///  and <c>RolloutPlansClient.InsertAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InsertSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>RolloutPlansClient.Insert</c> and
        /// <c>RolloutPlansClient.InsertAsync</c>.
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
        public lro::OperationsSettings InsertOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>RolloutPlansClient.List</c>
        /// and <c>RolloutPlansClient.ListAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="RolloutPlansSettings"/> object.</returns>
        public RolloutPlansSettings Clone() => new RolloutPlansSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="RolloutPlansClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class RolloutPlansClientBuilder : gaxgrpc::ClientBuilderBase<RolloutPlansClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public RolloutPlansSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public RolloutPlansClientBuilder() : base(RolloutPlansClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref RolloutPlansClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<RolloutPlansClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override RolloutPlansClient Build()
        {
            RolloutPlansClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<RolloutPlansClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<RolloutPlansClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private RolloutPlansClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return RolloutPlansClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<RolloutPlansClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return RolloutPlansClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => RolloutPlansClient.ChannelPool;
    }

    /// <summary>RolloutPlans client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The RolloutPlans API.
    /// </remarks>
    public abstract partial class RolloutPlansClient
    {
        /// <summary>
        /// The default endpoint for the RolloutPlans service, which is a host of "compute.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default RolloutPlans scopes.</summary>
        /// <remarks>
        /// The default RolloutPlans scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/compute</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/compute",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(RolloutPlans.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="RolloutPlansClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="RolloutPlansClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="RolloutPlansClient"/>.</returns>
        public static stt::Task<RolloutPlansClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new RolloutPlansClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="RolloutPlansClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="RolloutPlansClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="RolloutPlansClient"/>.</returns>
        public static RolloutPlansClient Create() => new RolloutPlansClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="RolloutPlansClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="RolloutPlansSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="RolloutPlansClient"/>.</returns>
        internal static RolloutPlansClient Create(grpccore::CallInvoker callInvoker, RolloutPlansSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            RolloutPlans.RolloutPlansClient grpcClient = new RolloutPlans.RolloutPlansClient(callInvoker);
            return new RolloutPlansClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC RolloutPlans client</summary>
        public virtual RolloutPlans.RolloutPlansClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a RolloutPlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Delete(DeleteRolloutPlanRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a RolloutPlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteRolloutPlanRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a RolloutPlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteRolloutPlanRequest request, st::CancellationToken cancellationToken) =>
            DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>Delete</c>.</summary>
        public virtual lro::OperationsClient DeleteOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Delete</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceDelete(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Delete</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceDeleteAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteOperationsClient, callSettings);

        /// <summary>
        /// Deletes a RolloutPlan.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="rolloutPlan">
        /// Name of the RolloutPlan resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Delete(string project, string rolloutPlan, gaxgrpc::CallSettings callSettings = null) =>
            Delete(new DeleteRolloutPlanRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                RolloutPlan = gax::GaxPreconditions.CheckNotNullOrEmpty(rolloutPlan, nameof(rolloutPlan)),
            }, callSettings);

        /// <summary>
        /// Deletes a RolloutPlan.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="rolloutPlan">
        /// Name of the RolloutPlan resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(string project, string rolloutPlan, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAsync(new DeleteRolloutPlanRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                RolloutPlan = gax::GaxPreconditions.CheckNotNullOrEmpty(rolloutPlan, nameof(rolloutPlan)),
            }, callSettings);

        /// <summary>
        /// Deletes a RolloutPlan.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="rolloutPlan">
        /// Name of the RolloutPlan resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(string project, string rolloutPlan, st::CancellationToken cancellationToken) =>
            DeleteAsync(project, rolloutPlan, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single project-scoped RolloutPlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RolloutPlan Get(GetRolloutPlanRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single project-scoped RolloutPlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RolloutPlan> GetAsync(GetRolloutPlanRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single project-scoped RolloutPlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RolloutPlan> GetAsync(GetRolloutPlanRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single project-scoped RolloutPlan.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="rolloutPlan">
        /// Name of the persistent rollout plan to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RolloutPlan Get(string project, string rolloutPlan, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetRolloutPlanRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                RolloutPlan = gax::GaxPreconditions.CheckNotNullOrEmpty(rolloutPlan, nameof(rolloutPlan)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single project-scoped RolloutPlan.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="rolloutPlan">
        /// Name of the persistent rollout plan to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RolloutPlan> GetAsync(string project, string rolloutPlan, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetRolloutPlanRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                RolloutPlan = gax::GaxPreconditions.CheckNotNullOrEmpty(rolloutPlan, nameof(rolloutPlan)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single project-scoped RolloutPlan.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="rolloutPlan">
        /// Name of the persistent rollout plan to return.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RolloutPlan> GetAsync(string project, string rolloutPlan, st::CancellationToken cancellationToken) =>
            GetAsync(project, rolloutPlan, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new RolloutPlan in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Insert(InsertRolloutPlanRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new RolloutPlan in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertRolloutPlanRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new RolloutPlan in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertRolloutPlanRequest request, st::CancellationToken cancellationToken) =>
            InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>Insert</c>.</summary>
        public virtual lro::OperationsClient InsertOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Insert</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceInsert(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), InsertOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Insert</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceInsertAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), InsertOperationsClient, callSettings);

        /// <summary>
        /// Creates a new RolloutPlan in a given project and location.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="rolloutPlanResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Insert(string project, RolloutPlan rolloutPlanResource, gaxgrpc::CallSettings callSettings = null) =>
            Insert(new InsertRolloutPlanRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                RolloutPlanResource = gax::GaxPreconditions.CheckNotNull(rolloutPlanResource, nameof(rolloutPlanResource)),
            }, callSettings);

        /// <summary>
        /// Creates a new RolloutPlan in a given project and location.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="rolloutPlanResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(string project, RolloutPlan rolloutPlanResource, gaxgrpc::CallSettings callSettings = null) =>
            InsertAsync(new InsertRolloutPlanRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                RolloutPlanResource = gax::GaxPreconditions.CheckNotNull(rolloutPlanResource, nameof(rolloutPlanResource)),
            }, callSettings);

        /// <summary>
        /// Creates a new RolloutPlan in a given project and location.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="rolloutPlanResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(string project, RolloutPlan rolloutPlanResource, st::CancellationToken cancellationToken) =>
            InsertAsync(project, rolloutPlanResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists RolloutPlans in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RolloutPlan"/> resources.</returns>
        public virtual gax::PagedEnumerable<RolloutPlansListResponse, RolloutPlan> List(ListRolloutPlansRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists RolloutPlans in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RolloutPlan"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<RolloutPlansListResponse, RolloutPlan> ListAsync(ListRolloutPlansRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists RolloutPlans in a given project and location.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
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
        /// <returns>A pageable sequence of <see cref="RolloutPlan"/> resources.</returns>
        public virtual gax::PagedEnumerable<RolloutPlansListResponse, RolloutPlan> List(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRolloutPlansRequest request = new ListRolloutPlansRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return List(request, callSettings);
        }

        /// <summary>
        /// Lists RolloutPlans in a given project and location.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
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
        /// <returns>A pageable asynchronous sequence of <see cref="RolloutPlan"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<RolloutPlansListResponse, RolloutPlan> ListAsync(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRolloutPlansRequest request = new ListRolloutPlansRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAsync(request, callSettings);
        }
    }

    /// <summary>RolloutPlans client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The RolloutPlans API.
    /// </remarks>
    public sealed partial class RolloutPlansClientImpl : RolloutPlansClient
    {
        private readonly gaxgrpc::ApiCall<DeleteRolloutPlanRequest, Operation> _callDelete;

        private readonly gaxgrpc::ApiCall<GetRolloutPlanRequest, RolloutPlan> _callGet;

        private readonly gaxgrpc::ApiCall<InsertRolloutPlanRequest, Operation> _callInsert;

        private readonly gaxgrpc::ApiCall<ListRolloutPlansRequest, RolloutPlansListResponse> _callList;

        /// <summary>
        /// Constructs a client wrapper for the RolloutPlans service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="RolloutPlansSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public RolloutPlansClientImpl(RolloutPlans.RolloutPlansClient grpcClient, RolloutPlansSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            RolloutPlansSettings effectiveSettings = settings ?? RolloutPlansSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            DeleteOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.DeleteOperationsSettings, logger);
            InsertOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.InsertOperationsSettings, logger);
            _callDelete = clientHelper.BuildApiCall<DeleteRolloutPlanRequest, Operation>("Delete", grpcClient.DeleteAsync, grpcClient.Delete, effectiveSettings.DeleteSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("rollout_plan", request => request.RolloutPlan);
            Modify_ApiCall(ref _callDelete);
            Modify_DeleteApiCall(ref _callDelete);
            _callGet = clientHelper.BuildApiCall<GetRolloutPlanRequest, RolloutPlan>("Get", grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("rollout_plan", request => request.RolloutPlan);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callInsert = clientHelper.BuildApiCall<InsertRolloutPlanRequest, Operation>("Insert", grpcClient.InsertAsync, grpcClient.Insert, effectiveSettings.InsertSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callInsert);
            Modify_InsertApiCall(ref _callInsert);
            _callList = clientHelper.BuildApiCall<ListRolloutPlansRequest, RolloutPlansListResponse>("List", grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_DeleteApiCall(ref gaxgrpc::ApiCall<DeleteRolloutPlanRequest, Operation> call);

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetRolloutPlanRequest, RolloutPlan> call);

        partial void Modify_InsertApiCall(ref gaxgrpc::ApiCall<InsertRolloutPlanRequest, Operation> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListRolloutPlansRequest, RolloutPlansListResponse> call);

        partial void OnConstruction(RolloutPlans.RolloutPlansClient grpcClient, RolloutPlansSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC RolloutPlans client</summary>
        public override RolloutPlans.RolloutPlansClient GrpcClient { get; }

        partial void Modify_DeleteRolloutPlanRequest(ref DeleteRolloutPlanRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRolloutPlanRequest(ref GetRolloutPlanRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InsertRolloutPlanRequest(ref InsertRolloutPlanRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRolloutPlansRequest(ref ListRolloutPlansRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>Delete</c>.</summary>
        public override lro::OperationsClient DeleteOperationsClient { get; }

        /// <summary>
        /// Deletes a RolloutPlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Delete(DeleteRolloutPlanRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRolloutPlanRequest(ref request, ref callSettings);
            Operation response = _callDelete.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DeleteOperationsClient);
        }

        /// <summary>
        /// Deletes a RolloutPlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteRolloutPlanRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRolloutPlanRequest(ref request, ref callSettings);
            Operation response = await _callDelete.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DeleteOperationsClient);
        }

        /// <summary>
        /// Gets details of a single project-scoped RolloutPlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RolloutPlan Get(GetRolloutPlanRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRolloutPlanRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single project-scoped RolloutPlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RolloutPlan> GetAsync(GetRolloutPlanRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRolloutPlanRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>Insert</c>.</summary>
        public override lro::OperationsClient InsertOperationsClient { get; }

        /// <summary>
        /// Creates a new RolloutPlan in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Insert(InsertRolloutPlanRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertRolloutPlanRequest(ref request, ref callSettings);
            Operation response = _callInsert.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), InsertOperationsClient);
        }

        /// <summary>
        /// Creates a new RolloutPlan in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertRolloutPlanRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertRolloutPlanRequest(ref request, ref callSettings);
            Operation response = await _callInsert.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), InsertOperationsClient);
        }

        /// <summary>
        /// Lists RolloutPlans in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RolloutPlan"/> resources.</returns>
        public override gax::PagedEnumerable<RolloutPlansListResponse, RolloutPlan> List(ListRolloutPlansRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRolloutPlansRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRolloutPlansRequest, RolloutPlansListResponse, RolloutPlan>(_callList, request, callSettings);
        }

        /// <summary>
        /// Lists RolloutPlans in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RolloutPlan"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<RolloutPlansListResponse, RolloutPlan> ListAsync(ListRolloutPlansRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRolloutPlansRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRolloutPlansRequest, RolloutPlansListResponse, RolloutPlan>(_callList, request, callSettings);
        }
    }

    public partial class ListRolloutPlansRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class RolloutPlansListResponse : gaxgrpc::IPageResponse<RolloutPlan>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<RolloutPlan> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class RolloutPlans
    {
        public partial class RolloutPlansClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client, delegating to GlobalOperations.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClientForGlobalOperations() =>
                GlobalOperations.GlobalOperationsClient.CreateOperationsClient(CallInvoker);
        }
    }
}
