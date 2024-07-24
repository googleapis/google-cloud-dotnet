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

namespace Google.Cloud.Compute.V1
{
    /// <summary>Settings for <see cref="InstanceGroupManagerResizeRequestsClient"/> instances.</summary>
    public sealed partial class InstanceGroupManagerResizeRequestsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="InstanceGroupManagerResizeRequestsSettings"/>.
        /// </summary>
        /// <returns>A new instance of the default <see cref="InstanceGroupManagerResizeRequestsSettings"/>.</returns>
        public static InstanceGroupManagerResizeRequestsSettings GetDefault() =>
            new InstanceGroupManagerResizeRequestsSettings();

        /// <summary>
        /// Constructs a new <see cref="InstanceGroupManagerResizeRequestsSettings"/> object with default settings.
        /// </summary>
        public InstanceGroupManagerResizeRequestsSettings()
        {
        }

        private InstanceGroupManagerResizeRequestsSettings(InstanceGroupManagerResizeRequestsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CancelSettings = existing.CancelSettings;
            CancelOperationsSettings = existing.CancelOperationsSettings.Clone();
            DeleteSettings = existing.DeleteSettings;
            DeleteOperationsSettings = existing.DeleteOperationsSettings.Clone();
            GetSettings = existing.GetSettings;
            InsertSettings = existing.InsertSettings;
            InsertOperationsSettings = existing.InsertOperationsSettings.Clone();
            ListSettings = existing.ListSettings;
            OnCopy(existing);
        }

        partial void OnCopy(InstanceGroupManagerResizeRequestsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceGroupManagerResizeRequestsClient.Cancel</c> and
        /// <c>InstanceGroupManagerResizeRequestsClient.CancelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CancelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstanceGroupManagerResizeRequestsClient.Cancel</c> and
        /// <c>InstanceGroupManagerResizeRequestsClient.CancelAsync</c>.
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
        public lro::OperationsSettings CancelOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceGroupManagerResizeRequestsClient.Delete</c> and
        /// <c>InstanceGroupManagerResizeRequestsClient.DeleteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstanceGroupManagerResizeRequestsClient.Delete</c> and
        /// <c>InstanceGroupManagerResizeRequestsClient.DeleteAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceGroupManagerResizeRequestsClient.Get</c> and <c>InstanceGroupManagerResizeRequestsClient.GetAsync</c>
        /// .
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceGroupManagerResizeRequestsClient.Insert</c> and
        /// <c>InstanceGroupManagerResizeRequestsClient.InsertAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InsertSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstanceGroupManagerResizeRequestsClient.Insert</c> and
        /// <c>InstanceGroupManagerResizeRequestsClient.InsertAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceGroupManagerResizeRequestsClient.List</c> and
        /// <c>InstanceGroupManagerResizeRequestsClient.ListAsync</c>.
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
        /// <returns>A deep clone of this <see cref="InstanceGroupManagerResizeRequestsSettings"/> object.</returns>
        public InstanceGroupManagerResizeRequestsSettings Clone() => new InstanceGroupManagerResizeRequestsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="InstanceGroupManagerResizeRequestsClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class InstanceGroupManagerResizeRequestsClientBuilder : gaxgrpc::ClientBuilderBase<InstanceGroupManagerResizeRequestsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public InstanceGroupManagerResizeRequestsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public InstanceGroupManagerResizeRequestsClientBuilder() : base(InstanceGroupManagerResizeRequestsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref InstanceGroupManagerResizeRequestsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<InstanceGroupManagerResizeRequestsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override InstanceGroupManagerResizeRequestsClient Build()
        {
            InstanceGroupManagerResizeRequestsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<InstanceGroupManagerResizeRequestsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<InstanceGroupManagerResizeRequestsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private InstanceGroupManagerResizeRequestsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return InstanceGroupManagerResizeRequestsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<InstanceGroupManagerResizeRequestsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return InstanceGroupManagerResizeRequestsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => InstanceGroupManagerResizeRequestsClient.ChannelPool;
    }

    /// <summary>InstanceGroupManagerResizeRequests client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The InstanceGroupManagerResizeRequests API.
    /// </remarks>
    public abstract partial class InstanceGroupManagerResizeRequestsClient
    {
        /// <summary>
        /// The default endpoint for the InstanceGroupManagerResizeRequests service, which is a host of
        /// "compute.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default InstanceGroupManagerResizeRequests scopes.</summary>
        /// <remarks>
        /// The default InstanceGroupManagerResizeRequests scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(InstanceGroupManagerResizeRequests.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="InstanceGroupManagerResizeRequestsClient"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="InstanceGroupManagerResizeRequestsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="InstanceGroupManagerResizeRequestsClient"/>.</returns>
        public static stt::Task<InstanceGroupManagerResizeRequestsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new InstanceGroupManagerResizeRequestsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="InstanceGroupManagerResizeRequestsClient"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="InstanceGroupManagerResizeRequestsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="InstanceGroupManagerResizeRequestsClient"/>.</returns>
        public static InstanceGroupManagerResizeRequestsClient Create() =>
            new InstanceGroupManagerResizeRequestsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="InstanceGroupManagerResizeRequestsClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="InstanceGroupManagerResizeRequestsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="InstanceGroupManagerResizeRequestsClient"/>.</returns>
        internal static InstanceGroupManagerResizeRequestsClient Create(grpccore::CallInvoker callInvoker, InstanceGroupManagerResizeRequestsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            InstanceGroupManagerResizeRequests.InstanceGroupManagerResizeRequestsClient grpcClient = new InstanceGroupManagerResizeRequests.InstanceGroupManagerResizeRequestsClient(callInvoker);
            return new InstanceGroupManagerResizeRequestsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC InstanceGroupManagerResizeRequests client</summary>
        public virtual InstanceGroupManagerResizeRequests.InstanceGroupManagerResizeRequestsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels the specified resize request and removes it from the queue. Cancelled resize request does no longer wait for the resources to be provisioned. Cancel is only possible for requests that are accepted in the queue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Cancel(CancelInstanceGroupManagerResizeRequestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels the specified resize request and removes it from the queue. Cancelled resize request does no longer wait for the resources to be provisioned. Cancel is only possible for requests that are accepted in the queue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> CancelAsync(CancelInstanceGroupManagerResizeRequestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels the specified resize request and removes it from the queue. Cancelled resize request does no longer wait for the resources to be provisioned. Cancel is only possible for requests that are accepted in the queue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> CancelAsync(CancelInstanceGroupManagerResizeRequestRequest request, st::CancellationToken cancellationToken) =>
            CancelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>Cancel</c>.</summary>
        public virtual lro::OperationsClient CancelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Cancel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceCancel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CancelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Cancel</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceCancelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CancelOperationsClient, callSettings);

        /// <summary>
        /// Cancels the specified resize request and removes it from the queue. Cancelled resize request does no longer wait for the resources to be provisioned. Cancel is only possible for requests that are accepted in the queue.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone where the managed instance group is located. The name should conform to RFC1035.
        /// </param>
        /// <param name="instanceGroupManager">
        /// The name of the managed instance group. The name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="resizeRequest">
        /// The name of the resize request to cancel. The name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Cancel(string project, string zone, string instanceGroupManager, string resizeRequest, gaxgrpc::CallSettings callSettings = null) =>
            Cancel(new CancelInstanceGroupManagerResizeRequestRequest
            {
                InstanceGroupManager = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceGroupManager, nameof(instanceGroupManager)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                ResizeRequest = gax::GaxPreconditions.CheckNotNullOrEmpty(resizeRequest, nameof(resizeRequest)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Cancels the specified resize request and removes it from the queue. Cancelled resize request does no longer wait for the resources to be provisioned. Cancel is only possible for requests that are accepted in the queue.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone where the managed instance group is located. The name should conform to RFC1035.
        /// </param>
        /// <param name="instanceGroupManager">
        /// The name of the managed instance group. The name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="resizeRequest">
        /// The name of the resize request to cancel. The name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> CancelAsync(string project, string zone, string instanceGroupManager, string resizeRequest, gaxgrpc::CallSettings callSettings = null) =>
            CancelAsync(new CancelInstanceGroupManagerResizeRequestRequest
            {
                InstanceGroupManager = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceGroupManager, nameof(instanceGroupManager)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                ResizeRequest = gax::GaxPreconditions.CheckNotNullOrEmpty(resizeRequest, nameof(resizeRequest)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Cancels the specified resize request and removes it from the queue. Cancelled resize request does no longer wait for the resources to be provisioned. Cancel is only possible for requests that are accepted in the queue.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone where the managed instance group is located. The name should conform to RFC1035.
        /// </param>
        /// <param name="instanceGroupManager">
        /// The name of the managed instance group. The name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="resizeRequest">
        /// The name of the resize request to cancel. The name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> CancelAsync(string project, string zone, string instanceGroupManager, string resizeRequest, st::CancellationToken cancellationToken) =>
            CancelAsync(project, zone, instanceGroupManager, resizeRequest, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified, inactive resize request. Requests that are still active cannot be deleted. Deleting request does not delete instances that were provisioned previously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Delete(DeleteInstanceGroupManagerResizeRequestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified, inactive resize request. Requests that are still active cannot be deleted. Deleting request does not delete instances that were provisioned previously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteInstanceGroupManagerResizeRequestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified, inactive resize request. Requests that are still active cannot be deleted. Deleting request does not delete instances that were provisioned previously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteInstanceGroupManagerResizeRequestRequest request, st::CancellationToken cancellationToken) =>
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
        /// Deletes the specified, inactive resize request. Requests that are still active cannot be deleted. Deleting request does not delete instances that were provisioned previously.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone where the managed instance group is located. The name should conform to RFC1035.
        /// </param>
        /// <param name="instanceGroupManager">
        /// The name of the managed instance group. The name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="resizeRequest">
        /// The name of the resize request to delete. The name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Delete(string project, string zone, string instanceGroupManager, string resizeRequest, gaxgrpc::CallSettings callSettings = null) =>
            Delete(new DeleteInstanceGroupManagerResizeRequestRequest
            {
                InstanceGroupManager = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceGroupManager, nameof(instanceGroupManager)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                ResizeRequest = gax::GaxPreconditions.CheckNotNullOrEmpty(resizeRequest, nameof(resizeRequest)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified, inactive resize request. Requests that are still active cannot be deleted. Deleting request does not delete instances that were provisioned previously.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone where the managed instance group is located. The name should conform to RFC1035.
        /// </param>
        /// <param name="instanceGroupManager">
        /// The name of the managed instance group. The name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="resizeRequest">
        /// The name of the resize request to delete. The name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(string project, string zone, string instanceGroupManager, string resizeRequest, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAsync(new DeleteInstanceGroupManagerResizeRequestRequest
            {
                InstanceGroupManager = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceGroupManager, nameof(instanceGroupManager)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                ResizeRequest = gax::GaxPreconditions.CheckNotNullOrEmpty(resizeRequest, nameof(resizeRequest)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified, inactive resize request. Requests that are still active cannot be deleted. Deleting request does not delete instances that were provisioned previously.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone where the managed instance group is located. The name should conform to RFC1035.
        /// </param>
        /// <param name="instanceGroupManager">
        /// The name of the managed instance group. The name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="resizeRequest">
        /// The name of the resize request to delete. The name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(string project, string zone, string instanceGroupManager, string resizeRequest, st::CancellationToken cancellationToken) =>
            DeleteAsync(project, zone, instanceGroupManager, resizeRequest, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns all of the details about the specified resize request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InstanceGroupManagerResizeRequest Get(GetInstanceGroupManagerResizeRequestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns all of the details about the specified resize request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceGroupManagerResizeRequest> GetAsync(GetInstanceGroupManagerResizeRequestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns all of the details about the specified resize request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceGroupManagerResizeRequest> GetAsync(GetInstanceGroupManagerResizeRequestRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns all of the details about the specified resize request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// Name of the href="/compute/docs/regions-zones/#available"&gt;zone scoping this request. Name should conform to RFC1035.
        /// </param>
        /// <param name="instanceGroupManager">
        /// The name of the managed instance group. Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="resizeRequest">
        /// The name of the resize request. Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InstanceGroupManagerResizeRequest Get(string project, string zone, string instanceGroupManager, string resizeRequest, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetInstanceGroupManagerResizeRequestRequest
            {
                InstanceGroupManager = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceGroupManager, nameof(instanceGroupManager)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                ResizeRequest = gax::GaxPreconditions.CheckNotNullOrEmpty(resizeRequest, nameof(resizeRequest)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Returns all of the details about the specified resize request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// Name of the href="/compute/docs/regions-zones/#available"&gt;zone scoping this request. Name should conform to RFC1035.
        /// </param>
        /// <param name="instanceGroupManager">
        /// The name of the managed instance group. Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="resizeRequest">
        /// The name of the resize request. Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceGroupManagerResizeRequest> GetAsync(string project, string zone, string instanceGroupManager, string resizeRequest, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetInstanceGroupManagerResizeRequestRequest
            {
                InstanceGroupManager = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceGroupManager, nameof(instanceGroupManager)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                ResizeRequest = gax::GaxPreconditions.CheckNotNullOrEmpty(resizeRequest, nameof(resizeRequest)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Returns all of the details about the specified resize request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// Name of the href="/compute/docs/regions-zones/#available"&gt;zone scoping this request. Name should conform to RFC1035.
        /// </param>
        /// <param name="instanceGroupManager">
        /// The name of the managed instance group. Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="resizeRequest">
        /// The name of the resize request. Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceGroupManagerResizeRequest> GetAsync(string project, string zone, string instanceGroupManager, string resizeRequest, st::CancellationToken cancellationToken) =>
            GetAsync(project, zone, instanceGroupManager, resizeRequest, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new resize request that starts provisioning VMs immediately or queues VM creation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Insert(InsertInstanceGroupManagerResizeRequestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new resize request that starts provisioning VMs immediately or queues VM creation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertInstanceGroupManagerResizeRequestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new resize request that starts provisioning VMs immediately or queues VM creation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertInstanceGroupManagerResizeRequestRequest request, st::CancellationToken cancellationToken) =>
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
        /// Creates a new resize request that starts provisioning VMs immediately or queues VM creation.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone where the managed instance group is located and where the resize request will be created. Name should conform to RFC1035.
        /// </param>
        /// <param name="instanceGroupManager">
        /// The name of the managed instance group to which the resize request will be added. Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="instanceGroupManagerResizeRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Insert(string project, string zone, string instanceGroupManager, InstanceGroupManagerResizeRequest instanceGroupManagerResizeRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            Insert(new InsertInstanceGroupManagerResizeRequestRequest
            {
                InstanceGroupManager = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceGroupManager, nameof(instanceGroupManager)),
                InstanceGroupManagerResizeRequestResource = gax::GaxPreconditions.CheckNotNull(instanceGroupManagerResizeRequestResource, nameof(instanceGroupManagerResizeRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Creates a new resize request that starts provisioning VMs immediately or queues VM creation.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone where the managed instance group is located and where the resize request will be created. Name should conform to RFC1035.
        /// </param>
        /// <param name="instanceGroupManager">
        /// The name of the managed instance group to which the resize request will be added. Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="instanceGroupManagerResizeRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(string project, string zone, string instanceGroupManager, InstanceGroupManagerResizeRequest instanceGroupManagerResizeRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            InsertAsync(new InsertInstanceGroupManagerResizeRequestRequest
            {
                InstanceGroupManager = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceGroupManager, nameof(instanceGroupManager)),
                InstanceGroupManagerResizeRequestResource = gax::GaxPreconditions.CheckNotNull(instanceGroupManagerResizeRequestResource, nameof(instanceGroupManagerResizeRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Creates a new resize request that starts provisioning VMs immediately or queues VM creation.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone where the managed instance group is located and where the resize request will be created. Name should conform to RFC1035.
        /// </param>
        /// <param name="instanceGroupManager">
        /// The name of the managed instance group to which the resize request will be added. Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="instanceGroupManagerResizeRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(string project, string zone, string instanceGroupManager, InstanceGroupManagerResizeRequest instanceGroupManagerResizeRequestResource, st::CancellationToken cancellationToken) =>
            InsertAsync(project, zone, instanceGroupManager, instanceGroupManagerResizeRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a list of resize requests that are contained in the managed instance group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="InstanceGroupManagerResizeRequest"/> resources.</returns>
        public virtual gax::PagedEnumerable<InstanceGroupManagerResizeRequestsListResponse, InstanceGroupManagerResizeRequest> List(ListInstanceGroupManagerResizeRequestsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of resize requests that are contained in the managed instance group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="InstanceGroupManagerResizeRequest"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<InstanceGroupManagerResizeRequestsListResponse, InstanceGroupManagerResizeRequest> ListAsync(ListInstanceGroupManagerResizeRequestsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of resize requests that are contained in the managed instance group.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone where the managed instance group is located. The name should conform to RFC1035.
        /// </param>
        /// <param name="instanceGroupManager">
        /// The name of the managed instance group. The name should conform to RFC1035.
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
        /// <returns>A pageable sequence of <see cref="InstanceGroupManagerResizeRequest"/> resources.</returns>
        public virtual gax::PagedEnumerable<InstanceGroupManagerResizeRequestsListResponse, InstanceGroupManagerResizeRequest> List(string project, string zone, string instanceGroupManager, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstanceGroupManagerResizeRequestsRequest request = new ListInstanceGroupManagerResizeRequestsRequest
            {
                InstanceGroupManager = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceGroupManager, nameof(instanceGroupManager)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
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
        /// Retrieves a list of resize requests that are contained in the managed instance group.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone where the managed instance group is located. The name should conform to RFC1035.
        /// </param>
        /// <param name="instanceGroupManager">
        /// The name of the managed instance group. The name should conform to RFC1035.
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
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="InstanceGroupManagerResizeRequest"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<InstanceGroupManagerResizeRequestsListResponse, InstanceGroupManagerResizeRequest> ListAsync(string project, string zone, string instanceGroupManager, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstanceGroupManagerResizeRequestsRequest request = new ListInstanceGroupManagerResizeRequestsRequest
            {
                InstanceGroupManager = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceGroupManager, nameof(instanceGroupManager)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
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

    /// <summary>InstanceGroupManagerResizeRequests client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The InstanceGroupManagerResizeRequests API.
    /// </remarks>
    public sealed partial class InstanceGroupManagerResizeRequestsClientImpl : InstanceGroupManagerResizeRequestsClient
    {
        private readonly gaxgrpc::ApiCall<CancelInstanceGroupManagerResizeRequestRequest, Operation> _callCancel;

        private readonly gaxgrpc::ApiCall<DeleteInstanceGroupManagerResizeRequestRequest, Operation> _callDelete;

        private readonly gaxgrpc::ApiCall<GetInstanceGroupManagerResizeRequestRequest, InstanceGroupManagerResizeRequest> _callGet;

        private readonly gaxgrpc::ApiCall<InsertInstanceGroupManagerResizeRequestRequest, Operation> _callInsert;

        private readonly gaxgrpc::ApiCall<ListInstanceGroupManagerResizeRequestsRequest, InstanceGroupManagerResizeRequestsListResponse> _callList;

        /// <summary>
        /// Constructs a client wrapper for the InstanceGroupManagerResizeRequests service, with the specified gRPC
        /// client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="InstanceGroupManagerResizeRequestsSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public InstanceGroupManagerResizeRequestsClientImpl(InstanceGroupManagerResizeRequests.InstanceGroupManagerResizeRequestsClient grpcClient, InstanceGroupManagerResizeRequestsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            InstanceGroupManagerResizeRequestsSettings effectiveSettings = settings ?? InstanceGroupManagerResizeRequestsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CancelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.CancelOperationsSettings, logger);
            DeleteOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.DeleteOperationsSettings, logger);
            InsertOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.InsertOperationsSettings, logger);
            _callCancel = clientHelper.BuildApiCall<CancelInstanceGroupManagerResizeRequestRequest, Operation>("Cancel", grpcClient.CancelAsync, grpcClient.Cancel, effectiveSettings.CancelSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance_group_manager", request => request.InstanceGroupManager).WithGoogleRequestParam("resize_request", request => request.ResizeRequest);
            Modify_ApiCall(ref _callCancel);
            Modify_CancelApiCall(ref _callCancel);
            _callDelete = clientHelper.BuildApiCall<DeleteInstanceGroupManagerResizeRequestRequest, Operation>("Delete", grpcClient.DeleteAsync, grpcClient.Delete, effectiveSettings.DeleteSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance_group_manager", request => request.InstanceGroupManager).WithGoogleRequestParam("resize_request", request => request.ResizeRequest);
            Modify_ApiCall(ref _callDelete);
            Modify_DeleteApiCall(ref _callDelete);
            _callGet = clientHelper.BuildApiCall<GetInstanceGroupManagerResizeRequestRequest, InstanceGroupManagerResizeRequest>("Get", grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance_group_manager", request => request.InstanceGroupManager).WithGoogleRequestParam("resize_request", request => request.ResizeRequest);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callInsert = clientHelper.BuildApiCall<InsertInstanceGroupManagerResizeRequestRequest, Operation>("Insert", grpcClient.InsertAsync, grpcClient.Insert, effectiveSettings.InsertSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance_group_manager", request => request.InstanceGroupManager);
            Modify_ApiCall(ref _callInsert);
            Modify_InsertApiCall(ref _callInsert);
            _callList = clientHelper.BuildApiCall<ListInstanceGroupManagerResizeRequestsRequest, InstanceGroupManagerResizeRequestsListResponse>("List", grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance_group_manager", request => request.InstanceGroupManager);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CancelApiCall(ref gaxgrpc::ApiCall<CancelInstanceGroupManagerResizeRequestRequest, Operation> call);

        partial void Modify_DeleteApiCall(ref gaxgrpc::ApiCall<DeleteInstanceGroupManagerResizeRequestRequest, Operation> call);

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetInstanceGroupManagerResizeRequestRequest, InstanceGroupManagerResizeRequest> call);

        partial void Modify_InsertApiCall(ref gaxgrpc::ApiCall<InsertInstanceGroupManagerResizeRequestRequest, Operation> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListInstanceGroupManagerResizeRequestsRequest, InstanceGroupManagerResizeRequestsListResponse> call);

        partial void OnConstruction(InstanceGroupManagerResizeRequests.InstanceGroupManagerResizeRequestsClient grpcClient, InstanceGroupManagerResizeRequestsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC InstanceGroupManagerResizeRequests client</summary>
        public override InstanceGroupManagerResizeRequests.InstanceGroupManagerResizeRequestsClient GrpcClient { get; }

        partial void Modify_CancelInstanceGroupManagerResizeRequestRequest(ref CancelInstanceGroupManagerResizeRequestRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteInstanceGroupManagerResizeRequestRequest(ref DeleteInstanceGroupManagerResizeRequestRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetInstanceGroupManagerResizeRequestRequest(ref GetInstanceGroupManagerResizeRequestRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InsertInstanceGroupManagerResizeRequestRequest(ref InsertInstanceGroupManagerResizeRequestRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListInstanceGroupManagerResizeRequestsRequest(ref ListInstanceGroupManagerResizeRequestsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>Cancel</c>.</summary>
        public override lro::OperationsClient CancelOperationsClient { get; }

        /// <summary>
        /// Cancels the specified resize request and removes it from the queue. Cancelled resize request does no longer wait for the resources to be provisioned. Cancel is only possible for requests that are accepted in the queue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Cancel(CancelInstanceGroupManagerResizeRequestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelInstanceGroupManagerResizeRequestRequest(ref request, ref callSettings);
            Operation response = _callCancel.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), CancelOperationsClient);
        }

        /// <summary>
        /// Cancels the specified resize request and removes it from the queue. Cancelled resize request does no longer wait for the resources to be provisioned. Cancel is only possible for requests that are accepted in the queue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> CancelAsync(CancelInstanceGroupManagerResizeRequestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelInstanceGroupManagerResizeRequestRequest(ref request, ref callSettings);
            Operation response = await _callCancel.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), CancelOperationsClient);
        }

        /// <summary>The long-running operations client for <c>Delete</c>.</summary>
        public override lro::OperationsClient DeleteOperationsClient { get; }

        /// <summary>
        /// Deletes the specified, inactive resize request. Requests that are still active cannot be deleted. Deleting request does not delete instances that were provisioned previously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Delete(DeleteInstanceGroupManagerResizeRequestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInstanceGroupManagerResizeRequestRequest(ref request, ref callSettings);
            Operation response = _callDelete.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DeleteOperationsClient);
        }

        /// <summary>
        /// Deletes the specified, inactive resize request. Requests that are still active cannot be deleted. Deleting request does not delete instances that were provisioned previously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteInstanceGroupManagerResizeRequestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInstanceGroupManagerResizeRequestRequest(ref request, ref callSettings);
            Operation response = await _callDelete.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DeleteOperationsClient);
        }

        /// <summary>
        /// Returns all of the details about the specified resize request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override InstanceGroupManagerResizeRequest Get(GetInstanceGroupManagerResizeRequestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInstanceGroupManagerResizeRequestRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns all of the details about the specified resize request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<InstanceGroupManagerResizeRequest> GetAsync(GetInstanceGroupManagerResizeRequestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInstanceGroupManagerResizeRequestRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>Insert</c>.</summary>
        public override lro::OperationsClient InsertOperationsClient { get; }

        /// <summary>
        /// Creates a new resize request that starts provisioning VMs immediately or queues VM creation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Insert(InsertInstanceGroupManagerResizeRequestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertInstanceGroupManagerResizeRequestRequest(ref request, ref callSettings);
            Operation response = _callInsert.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), InsertOperationsClient);
        }

        /// <summary>
        /// Creates a new resize request that starts provisioning VMs immediately or queues VM creation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertInstanceGroupManagerResizeRequestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertInstanceGroupManagerResizeRequestRequest(ref request, ref callSettings);
            Operation response = await _callInsert.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), InsertOperationsClient);
        }

        /// <summary>
        /// Retrieves a list of resize requests that are contained in the managed instance group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="InstanceGroupManagerResizeRequest"/> resources.</returns>
        public override gax::PagedEnumerable<InstanceGroupManagerResizeRequestsListResponse, InstanceGroupManagerResizeRequest> List(ListInstanceGroupManagerResizeRequestsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstanceGroupManagerResizeRequestsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListInstanceGroupManagerResizeRequestsRequest, InstanceGroupManagerResizeRequestsListResponse, InstanceGroupManagerResizeRequest>(_callList, request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of resize requests that are contained in the managed instance group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="InstanceGroupManagerResizeRequest"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<InstanceGroupManagerResizeRequestsListResponse, InstanceGroupManagerResizeRequest> ListAsync(ListInstanceGroupManagerResizeRequestsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstanceGroupManagerResizeRequestsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListInstanceGroupManagerResizeRequestsRequest, InstanceGroupManagerResizeRequestsListResponse, InstanceGroupManagerResizeRequest>(_callList, request, callSettings);
        }
    }

    public partial class ListInstanceGroupManagerResizeRequestsRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class InstanceGroupManagerResizeRequestsListResponse : gaxgrpc::IPageResponse<InstanceGroupManagerResizeRequest>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<InstanceGroupManagerResizeRequest> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class InstanceGroupManagerResizeRequests
    {
        public partial class InstanceGroupManagerResizeRequestsClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client, delegating to ZoneOperations.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClientForZoneOperations() =>
                ZoneOperations.ZoneOperationsClient.CreateOperationsClient(CallInvoker);
        }
    }
}
