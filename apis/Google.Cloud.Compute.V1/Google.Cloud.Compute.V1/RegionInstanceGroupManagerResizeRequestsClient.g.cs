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
    /// <summary>Settings for <see cref="RegionInstanceGroupManagerResizeRequestsClient"/> instances.</summary>
    public sealed partial class RegionInstanceGroupManagerResizeRequestsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="RegionInstanceGroupManagerResizeRequestsSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="RegionInstanceGroupManagerResizeRequestsSettings"/>.
        /// </returns>
        public static RegionInstanceGroupManagerResizeRequestsSettings GetDefault() =>
            new RegionInstanceGroupManagerResizeRequestsSettings();

        /// <summary>
        /// Constructs a new <see cref="RegionInstanceGroupManagerResizeRequestsSettings"/> object with default
        /// settings.
        /// </summary>
        public RegionInstanceGroupManagerResizeRequestsSettings()
        {
        }

        private RegionInstanceGroupManagerResizeRequestsSettings(RegionInstanceGroupManagerResizeRequestsSettings existing) : base(existing)
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

        partial void OnCopy(RegionInstanceGroupManagerResizeRequestsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionInstanceGroupManagerResizeRequestsClient.Cancel</c> and
        /// <c>RegionInstanceGroupManagerResizeRequestsClient.CancelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CancelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>RegionInstanceGroupManagerResizeRequestsClient.Cancel</c>
        /// and <c>RegionInstanceGroupManagerResizeRequestsClient.CancelAsync</c>.
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
        /// <c>RegionInstanceGroupManagerResizeRequestsClient.Delete</c> and
        /// <c>RegionInstanceGroupManagerResizeRequestsClient.DeleteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>RegionInstanceGroupManagerResizeRequestsClient.Delete</c>
        /// and <c>RegionInstanceGroupManagerResizeRequestsClient.DeleteAsync</c>.
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
        /// <c>RegionInstanceGroupManagerResizeRequestsClient.Get</c> and
        /// <c>RegionInstanceGroupManagerResizeRequestsClient.GetAsync</c>.
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
        /// <c>RegionInstanceGroupManagerResizeRequestsClient.Insert</c> and
        /// <c>RegionInstanceGroupManagerResizeRequestsClient.InsertAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InsertSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>RegionInstanceGroupManagerResizeRequestsClient.Insert</c>
        /// and <c>RegionInstanceGroupManagerResizeRequestsClient.InsertAsync</c>.
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
        /// <c>RegionInstanceGroupManagerResizeRequestsClient.List</c> and
        /// <c>RegionInstanceGroupManagerResizeRequestsClient.ListAsync</c>.
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
        /// <returns>
        /// A deep clone of this <see cref="RegionInstanceGroupManagerResizeRequestsSettings"/> object.
        /// </returns>
        public RegionInstanceGroupManagerResizeRequestsSettings Clone() =>
            new RegionInstanceGroupManagerResizeRequestsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="RegionInstanceGroupManagerResizeRequestsClient"/> to provide simple configuration
    /// of credentials, endpoint etc.
    /// </summary>
    public sealed partial class RegionInstanceGroupManagerResizeRequestsClientBuilder : gaxgrpc::ClientBuilderBase<RegionInstanceGroupManagerResizeRequestsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public RegionInstanceGroupManagerResizeRequestsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public RegionInstanceGroupManagerResizeRequestsClientBuilder() : base(RegionInstanceGroupManagerResizeRequestsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref RegionInstanceGroupManagerResizeRequestsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<RegionInstanceGroupManagerResizeRequestsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override RegionInstanceGroupManagerResizeRequestsClient Build()
        {
            RegionInstanceGroupManagerResizeRequestsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<RegionInstanceGroupManagerResizeRequestsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<RegionInstanceGroupManagerResizeRequestsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private RegionInstanceGroupManagerResizeRequestsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return RegionInstanceGroupManagerResizeRequestsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<RegionInstanceGroupManagerResizeRequestsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return RegionInstanceGroupManagerResizeRequestsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() =>
            RegionInstanceGroupManagerResizeRequestsClient.ChannelPool;
    }

    /// <summary>RegionInstanceGroupManagerResizeRequests client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The RegionInstanceGroupManagerResizeRequests API.
    /// </remarks>
    public abstract partial class RegionInstanceGroupManagerResizeRequestsClient
    {
        /// <summary>
        /// The default endpoint for the RegionInstanceGroupManagerResizeRequests service, which is a host of
        /// "compute.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default RegionInstanceGroupManagerResizeRequests scopes.</summary>
        /// <remarks>
        /// The default RegionInstanceGroupManagerResizeRequests scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(RegionInstanceGroupManagerResizeRequests.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="RegionInstanceGroupManagerResizeRequestsClient"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="RegionInstanceGroupManagerResizeRequestsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>
        /// The task representing the created <see cref="RegionInstanceGroupManagerResizeRequestsClient"/>.
        /// </returns>
        public static stt::Task<RegionInstanceGroupManagerResizeRequestsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new RegionInstanceGroupManagerResizeRequestsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="RegionInstanceGroupManagerResizeRequestsClient"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="RegionInstanceGroupManagerResizeRequestsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="RegionInstanceGroupManagerResizeRequestsClient"/>.</returns>
        public static RegionInstanceGroupManagerResizeRequestsClient Create() =>
            new RegionInstanceGroupManagerResizeRequestsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="RegionInstanceGroupManagerResizeRequestsClient"/> which uses the specified call invoker
        /// for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="RegionInstanceGroupManagerResizeRequestsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="RegionInstanceGroupManagerResizeRequestsClient"/>.</returns>
        internal static RegionInstanceGroupManagerResizeRequestsClient Create(grpccore::CallInvoker callInvoker, RegionInstanceGroupManagerResizeRequestsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            RegionInstanceGroupManagerResizeRequests.RegionInstanceGroupManagerResizeRequestsClient grpcClient = new RegionInstanceGroupManagerResizeRequests.RegionInstanceGroupManagerResizeRequestsClient(callInvoker);
            return new RegionInstanceGroupManagerResizeRequestsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC RegionInstanceGroupManagerResizeRequests client</summary>
        public virtual RegionInstanceGroupManagerResizeRequests.RegionInstanceGroupManagerResizeRequestsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels the specified resize request.
        /// Cancelled resize request no longer waits for the resources to be
        /// provisioned. Cancel is only possible for requests that are in accepted
        /// state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Cancel(CancelRegionInstanceGroupManagerResizeRequestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels the specified resize request.
        /// Cancelled resize request no longer waits for the resources to be
        /// provisioned. Cancel is only possible for requests that are in accepted
        /// state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> CancelAsync(CancelRegionInstanceGroupManagerResizeRequestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels the specified resize request.
        /// Cancelled resize request no longer waits for the resources to be
        /// provisioned. Cancel is only possible for requests that are in accepted
        /// state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> CancelAsync(CancelRegionInstanceGroupManagerResizeRequestRequest request, st::CancellationToken cancellationToken) =>
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
        /// Cancels the specified resize request.
        /// Cancelled resize request no longer waits for the resources to be
        /// provisioned. Cancel is only possible for requests that are in accepted
        /// state.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region
        /// scoping this request. Name should conform to RFC1035.
        /// </param>
        /// <param name="instanceGroupManager">
        /// The name of the managed instance group.
        /// Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="resizeRequest">
        /// The name of the resize request to cancel.
        /// Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Cancel(string project, string region, string instanceGroupManager, string resizeRequest, gaxgrpc::CallSettings callSettings = null) =>
            Cancel(new CancelRegionInstanceGroupManagerResizeRequestRequest
            {
                InstanceGroupManager = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceGroupManager, nameof(instanceGroupManager)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                ResizeRequest = gax::GaxPreconditions.CheckNotNullOrEmpty(resizeRequest, nameof(resizeRequest)),
            }, callSettings);

        /// <summary>
        /// Cancels the specified resize request.
        /// Cancelled resize request no longer waits for the resources to be
        /// provisioned. Cancel is only possible for requests that are in accepted
        /// state.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region
        /// scoping this request. Name should conform to RFC1035.
        /// </param>
        /// <param name="instanceGroupManager">
        /// The name of the managed instance group.
        /// Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="resizeRequest">
        /// The name of the resize request to cancel.
        /// Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> CancelAsync(string project, string region, string instanceGroupManager, string resizeRequest, gaxgrpc::CallSettings callSettings = null) =>
            CancelAsync(new CancelRegionInstanceGroupManagerResizeRequestRequest
            {
                InstanceGroupManager = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceGroupManager, nameof(instanceGroupManager)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                ResizeRequest = gax::GaxPreconditions.CheckNotNullOrEmpty(resizeRequest, nameof(resizeRequest)),
            }, callSettings);

        /// <summary>
        /// Cancels the specified resize request.
        /// Cancelled resize request no longer waits for the resources to be
        /// provisioned. Cancel is only possible for requests that are in accepted
        /// state.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region
        /// scoping this request. Name should conform to RFC1035.
        /// </param>
        /// <param name="instanceGroupManager">
        /// The name of the managed instance group.
        /// Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="resizeRequest">
        /// The name of the resize request to cancel.
        /// Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> CancelAsync(string project, string region, string instanceGroupManager, string resizeRequest, st::CancellationToken cancellationToken) =>
            CancelAsync(project, region, instanceGroupManager, resizeRequest, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified, inactive resize request. Requests that are still
        /// active cannot be deleted. Deleting request does not delete instances that
        /// were provisioned previously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Delete(DeleteRegionInstanceGroupManagerResizeRequestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified, inactive resize request. Requests that are still
        /// active cannot be deleted. Deleting request does not delete instances that
        /// were provisioned previously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteRegionInstanceGroupManagerResizeRequestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified, inactive resize request. Requests that are still
        /// active cannot be deleted. Deleting request does not delete instances that
        /// were provisioned previously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteRegionInstanceGroupManagerResizeRequestRequest request, st::CancellationToken cancellationToken) =>
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
        /// Deletes the specified, inactive resize request. Requests that are still
        /// active cannot be deleted. Deleting request does not delete instances that
        /// were provisioned previously.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region
        /// scoping this request. Name should conform to RFC1035.
        /// </param>
        /// <param name="instanceGroupManager">
        /// The name of the managed instance group.
        /// Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="resizeRequest">
        /// The name of the resize request to delete.
        /// Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Delete(string project, string region, string instanceGroupManager, string resizeRequest, gaxgrpc::CallSettings callSettings = null) =>
            Delete(new DeleteRegionInstanceGroupManagerResizeRequestRequest
            {
                InstanceGroupManager = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceGroupManager, nameof(instanceGroupManager)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                ResizeRequest = gax::GaxPreconditions.CheckNotNullOrEmpty(resizeRequest, nameof(resizeRequest)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified, inactive resize request. Requests that are still
        /// active cannot be deleted. Deleting request does not delete instances that
        /// were provisioned previously.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region
        /// scoping this request. Name should conform to RFC1035.
        /// </param>
        /// <param name="instanceGroupManager">
        /// The name of the managed instance group.
        /// Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="resizeRequest">
        /// The name of the resize request to delete.
        /// Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(string project, string region, string instanceGroupManager, string resizeRequest, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAsync(new DeleteRegionInstanceGroupManagerResizeRequestRequest
            {
                InstanceGroupManager = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceGroupManager, nameof(instanceGroupManager)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                ResizeRequest = gax::GaxPreconditions.CheckNotNullOrEmpty(resizeRequest, nameof(resizeRequest)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified, inactive resize request. Requests that are still
        /// active cannot be deleted. Deleting request does not delete instances that
        /// were provisioned previously.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region
        /// scoping this request. Name should conform to RFC1035.
        /// </param>
        /// <param name="instanceGroupManager">
        /// The name of the managed instance group.
        /// Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="resizeRequest">
        /// The name of the resize request to delete.
        /// Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(string project, string region, string instanceGroupManager, string resizeRequest, st::CancellationToken cancellationToken) =>
            DeleteAsync(project, region, instanceGroupManager, resizeRequest, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns all of the details about the specified resize request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InstanceGroupManagerResizeRequest Get(GetRegionInstanceGroupManagerResizeRequestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns all of the details about the specified resize request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceGroupManagerResizeRequest> GetAsync(GetRegionInstanceGroupManagerResizeRequestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns all of the details about the specified resize request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceGroupManagerResizeRequest> GetAsync(GetRegionInstanceGroupManagerResizeRequestRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns all of the details about the specified resize request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region
        /// scoping this request. Name should conform to RFC1035.
        /// </param>
        /// <param name="instanceGroupManager">
        /// The name of the managed instance group.
        /// Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="resizeRequest">
        /// The name of the resize request.
        /// Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InstanceGroupManagerResizeRequest Get(string project, string region, string instanceGroupManager, string resizeRequest, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetRegionInstanceGroupManagerResizeRequestRequest
            {
                InstanceGroupManager = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceGroupManager, nameof(instanceGroupManager)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                ResizeRequest = gax::GaxPreconditions.CheckNotNullOrEmpty(resizeRequest, nameof(resizeRequest)),
            }, callSettings);

        /// <summary>
        /// Returns all of the details about the specified resize request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region
        /// scoping this request. Name should conform to RFC1035.
        /// </param>
        /// <param name="instanceGroupManager">
        /// The name of the managed instance group.
        /// Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="resizeRequest">
        /// The name of the resize request.
        /// Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceGroupManagerResizeRequest> GetAsync(string project, string region, string instanceGroupManager, string resizeRequest, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetRegionInstanceGroupManagerResizeRequestRequest
            {
                InstanceGroupManager = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceGroupManager, nameof(instanceGroupManager)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                ResizeRequest = gax::GaxPreconditions.CheckNotNullOrEmpty(resizeRequest, nameof(resizeRequest)),
            }, callSettings);

        /// <summary>
        /// Returns all of the details about the specified resize request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region
        /// scoping this request. Name should conform to RFC1035.
        /// </param>
        /// <param name="instanceGroupManager">
        /// The name of the managed instance group.
        /// Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="resizeRequest">
        /// The name of the resize request.
        /// Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceGroupManagerResizeRequest> GetAsync(string project, string region, string instanceGroupManager, string resizeRequest, st::CancellationToken cancellationToken) =>
            GetAsync(project, region, instanceGroupManager, resizeRequest, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Resize Request that starts provisioning VMs immediately
        /// or queues VM creation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Insert(InsertRegionInstanceGroupManagerResizeRequestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Resize Request that starts provisioning VMs immediately
        /// or queues VM creation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertRegionInstanceGroupManagerResizeRequestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Resize Request that starts provisioning VMs immediately
        /// or queues VM creation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertRegionInstanceGroupManagerResizeRequestRequest request, st::CancellationToken cancellationToken) =>
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
        /// Creates a new Resize Request that starts provisioning VMs immediately
        /// or queues VM creation.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region
        /// scoping this request. Name should conform to RFC1035.
        /// </param>
        /// <param name="instanceGroupManager">
        /// Name of the managed instance group to which the resize request is scoped.
        /// Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="instanceGroupManagerResizeRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Insert(string project, string region, string instanceGroupManager, InstanceGroupManagerResizeRequest instanceGroupManagerResizeRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            Insert(new InsertRegionInstanceGroupManagerResizeRequestRequest
            {
                InstanceGroupManager = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceGroupManager, nameof(instanceGroupManager)),
                InstanceGroupManagerResizeRequestResource = gax::GaxPreconditions.CheckNotNull(instanceGroupManagerResizeRequestResource, nameof(instanceGroupManagerResizeRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Creates a new Resize Request that starts provisioning VMs immediately
        /// or queues VM creation.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region
        /// scoping this request. Name should conform to RFC1035.
        /// </param>
        /// <param name="instanceGroupManager">
        /// Name of the managed instance group to which the resize request is scoped.
        /// Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="instanceGroupManagerResizeRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(string project, string region, string instanceGroupManager, InstanceGroupManagerResizeRequest instanceGroupManagerResizeRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            InsertAsync(new InsertRegionInstanceGroupManagerResizeRequestRequest
            {
                InstanceGroupManager = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceGroupManager, nameof(instanceGroupManager)),
                InstanceGroupManagerResizeRequestResource = gax::GaxPreconditions.CheckNotNull(instanceGroupManagerResizeRequestResource, nameof(instanceGroupManagerResizeRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Creates a new Resize Request that starts provisioning VMs immediately
        /// or queues VM creation.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region
        /// scoping this request. Name should conform to RFC1035.
        /// </param>
        /// <param name="instanceGroupManager">
        /// Name of the managed instance group to which the resize request is scoped.
        /// Name should conform to RFC1035 or be a resource ID.
        /// </param>
        /// <param name="instanceGroupManagerResizeRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(string project, string region, string instanceGroupManager, InstanceGroupManagerResizeRequest instanceGroupManagerResizeRequestResource, st::CancellationToken cancellationToken) =>
            InsertAsync(project, region, instanceGroupManager, instanceGroupManagerResizeRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a list of Resize Requests that are contained in the
        /// managed instance group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="InstanceGroupManagerResizeRequest"/> resources.</returns>
        public virtual gax::PagedEnumerable<RegionInstanceGroupManagerResizeRequestsListResponse, InstanceGroupManagerResizeRequest> List(ListRegionInstanceGroupManagerResizeRequestsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of Resize Requests that are contained in the
        /// managed instance group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="InstanceGroupManagerResizeRequest"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<RegionInstanceGroupManagerResizeRequestsListResponse, InstanceGroupManagerResizeRequest> ListAsync(ListRegionInstanceGroupManagerResizeRequestsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of Resize Requests that are contained in the
        /// managed instance group.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region
        /// scoping this request. Name should conform to RFC1035.
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
        public virtual gax::PagedEnumerable<RegionInstanceGroupManagerResizeRequestsListResponse, InstanceGroupManagerResizeRequest> List(string project, string region, string instanceGroupManager, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRegionInstanceGroupManagerResizeRequestsRequest request = new ListRegionInstanceGroupManagerResizeRequestsRequest
            {
                InstanceGroupManager = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceGroupManager, nameof(instanceGroupManager)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
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
        /// Retrieves a list of Resize Requests that are contained in the
        /// managed instance group.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region
        /// scoping this request. Name should conform to RFC1035.
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
        public virtual gax::PagedAsyncEnumerable<RegionInstanceGroupManagerResizeRequestsListResponse, InstanceGroupManagerResizeRequest> ListAsync(string project, string region, string instanceGroupManager, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRegionInstanceGroupManagerResizeRequestsRequest request = new ListRegionInstanceGroupManagerResizeRequestsRequest
            {
                InstanceGroupManager = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceGroupManager, nameof(instanceGroupManager)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
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

    /// <summary>RegionInstanceGroupManagerResizeRequests client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The RegionInstanceGroupManagerResizeRequests API.
    /// </remarks>
    public sealed partial class RegionInstanceGroupManagerResizeRequestsClientImpl : RegionInstanceGroupManagerResizeRequestsClient
    {
        private readonly gaxgrpc::ApiCall<CancelRegionInstanceGroupManagerResizeRequestRequest, Operation> _callCancel;

        private readonly gaxgrpc::ApiCall<DeleteRegionInstanceGroupManagerResizeRequestRequest, Operation> _callDelete;

        private readonly gaxgrpc::ApiCall<GetRegionInstanceGroupManagerResizeRequestRequest, InstanceGroupManagerResizeRequest> _callGet;

        private readonly gaxgrpc::ApiCall<InsertRegionInstanceGroupManagerResizeRequestRequest, Operation> _callInsert;

        private readonly gaxgrpc::ApiCall<ListRegionInstanceGroupManagerResizeRequestsRequest, RegionInstanceGroupManagerResizeRequestsListResponse> _callList;

        /// <summary>
        /// Constructs a client wrapper for the RegionInstanceGroupManagerResizeRequests service, with the specified
        /// gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="RegionInstanceGroupManagerResizeRequestsSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public RegionInstanceGroupManagerResizeRequestsClientImpl(RegionInstanceGroupManagerResizeRequests.RegionInstanceGroupManagerResizeRequestsClient grpcClient, RegionInstanceGroupManagerResizeRequestsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            RegionInstanceGroupManagerResizeRequestsSettings effectiveSettings = settings ?? RegionInstanceGroupManagerResizeRequestsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CancelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForRegionOperations(), effectiveSettings.CancelOperationsSettings, logger);
            DeleteOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForRegionOperations(), effectiveSettings.DeleteOperationsSettings, logger);
            InsertOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForRegionOperations(), effectiveSettings.InsertOperationsSettings, logger);
            _callCancel = clientHelper.BuildApiCall<CancelRegionInstanceGroupManagerResizeRequestRequest, Operation>("Cancel", grpcClient.CancelAsync, grpcClient.Cancel, effectiveSettings.CancelSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("instance_group_manager", request => request.InstanceGroupManager).WithGoogleRequestParam("resize_request", request => request.ResizeRequest);
            Modify_ApiCall(ref _callCancel);
            Modify_CancelApiCall(ref _callCancel);
            _callDelete = clientHelper.BuildApiCall<DeleteRegionInstanceGroupManagerResizeRequestRequest, Operation>("Delete", grpcClient.DeleteAsync, grpcClient.Delete, effectiveSettings.DeleteSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("instance_group_manager", request => request.InstanceGroupManager).WithGoogleRequestParam("resize_request", request => request.ResizeRequest);
            Modify_ApiCall(ref _callDelete);
            Modify_DeleteApiCall(ref _callDelete);
            _callGet = clientHelper.BuildApiCall<GetRegionInstanceGroupManagerResizeRequestRequest, InstanceGroupManagerResizeRequest>("Get", grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("instance_group_manager", request => request.InstanceGroupManager).WithGoogleRequestParam("resize_request", request => request.ResizeRequest);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callInsert = clientHelper.BuildApiCall<InsertRegionInstanceGroupManagerResizeRequestRequest, Operation>("Insert", grpcClient.InsertAsync, grpcClient.Insert, effectiveSettings.InsertSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("instance_group_manager", request => request.InstanceGroupManager);
            Modify_ApiCall(ref _callInsert);
            Modify_InsertApiCall(ref _callInsert);
            _callList = clientHelper.BuildApiCall<ListRegionInstanceGroupManagerResizeRequestsRequest, RegionInstanceGroupManagerResizeRequestsListResponse>("List", grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("instance_group_manager", request => request.InstanceGroupManager);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CancelApiCall(ref gaxgrpc::ApiCall<CancelRegionInstanceGroupManagerResizeRequestRequest, Operation> call);

        partial void Modify_DeleteApiCall(ref gaxgrpc::ApiCall<DeleteRegionInstanceGroupManagerResizeRequestRequest, Operation> call);

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetRegionInstanceGroupManagerResizeRequestRequest, InstanceGroupManagerResizeRequest> call);

        partial void Modify_InsertApiCall(ref gaxgrpc::ApiCall<InsertRegionInstanceGroupManagerResizeRequestRequest, Operation> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListRegionInstanceGroupManagerResizeRequestsRequest, RegionInstanceGroupManagerResizeRequestsListResponse> call);

        partial void OnConstruction(RegionInstanceGroupManagerResizeRequests.RegionInstanceGroupManagerResizeRequestsClient grpcClient, RegionInstanceGroupManagerResizeRequestsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC RegionInstanceGroupManagerResizeRequests client</summary>
        public override RegionInstanceGroupManagerResizeRequests.RegionInstanceGroupManagerResizeRequestsClient GrpcClient { get; }

        partial void Modify_CancelRegionInstanceGroupManagerResizeRequestRequest(ref CancelRegionInstanceGroupManagerResizeRequestRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteRegionInstanceGroupManagerResizeRequestRequest(ref DeleteRegionInstanceGroupManagerResizeRequestRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRegionInstanceGroupManagerResizeRequestRequest(ref GetRegionInstanceGroupManagerResizeRequestRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InsertRegionInstanceGroupManagerResizeRequestRequest(ref InsertRegionInstanceGroupManagerResizeRequestRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRegionInstanceGroupManagerResizeRequestsRequest(ref ListRegionInstanceGroupManagerResizeRequestsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>Cancel</c>.</summary>
        public override lro::OperationsClient CancelOperationsClient { get; }

        /// <summary>
        /// Cancels the specified resize request.
        /// Cancelled resize request no longer waits for the resources to be
        /// provisioned. Cancel is only possible for requests that are in accepted
        /// state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Cancel(CancelRegionInstanceGroupManagerResizeRequestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelRegionInstanceGroupManagerResizeRequestRequest(ref request, ref callSettings);
            Operation response = _callCancel.Sync(request, callSettings);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), CancelOperationsClient);
        }

        /// <summary>
        /// Cancels the specified resize request.
        /// Cancelled resize request no longer waits for the resources to be
        /// provisioned. Cancel is only possible for requests that are in accepted
        /// state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> CancelAsync(CancelRegionInstanceGroupManagerResizeRequestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelRegionInstanceGroupManagerResizeRequestRequest(ref request, ref callSettings);
            Operation response = await _callCancel.Async(request, callSettings).ConfigureAwait(false);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), CancelOperationsClient);
        }

        /// <summary>The long-running operations client for <c>Delete</c>.</summary>
        public override lro::OperationsClient DeleteOperationsClient { get; }

        /// <summary>
        /// Deletes the specified, inactive resize request. Requests that are still
        /// active cannot be deleted. Deleting request does not delete instances that
        /// were provisioned previously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Delete(DeleteRegionInstanceGroupManagerResizeRequestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRegionInstanceGroupManagerResizeRequestRequest(ref request, ref callSettings);
            Operation response = _callDelete.Sync(request, callSettings);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DeleteOperationsClient);
        }

        /// <summary>
        /// Deletes the specified, inactive resize request. Requests that are still
        /// active cannot be deleted. Deleting request does not delete instances that
        /// were provisioned previously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteRegionInstanceGroupManagerResizeRequestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRegionInstanceGroupManagerResizeRequestRequest(ref request, ref callSettings);
            Operation response = await _callDelete.Async(request, callSettings).ConfigureAwait(false);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DeleteOperationsClient);
        }

        /// <summary>
        /// Returns all of the details about the specified resize request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override InstanceGroupManagerResizeRequest Get(GetRegionInstanceGroupManagerResizeRequestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRegionInstanceGroupManagerResizeRequestRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns all of the details about the specified resize request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<InstanceGroupManagerResizeRequest> GetAsync(GetRegionInstanceGroupManagerResizeRequestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRegionInstanceGroupManagerResizeRequestRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>Insert</c>.</summary>
        public override lro::OperationsClient InsertOperationsClient { get; }

        /// <summary>
        /// Creates a new Resize Request that starts provisioning VMs immediately
        /// or queues VM creation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Insert(InsertRegionInstanceGroupManagerResizeRequestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertRegionInstanceGroupManagerResizeRequestRequest(ref request, ref callSettings);
            Operation response = _callInsert.Sync(request, callSettings);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), InsertOperationsClient);
        }

        /// <summary>
        /// Creates a new Resize Request that starts provisioning VMs immediately
        /// or queues VM creation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertRegionInstanceGroupManagerResizeRequestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertRegionInstanceGroupManagerResizeRequestRequest(ref request, ref callSettings);
            Operation response = await _callInsert.Async(request, callSettings).ConfigureAwait(false);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), InsertOperationsClient);
        }

        /// <summary>
        /// Retrieves a list of Resize Requests that are contained in the
        /// managed instance group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="InstanceGroupManagerResizeRequest"/> resources.</returns>
        public override gax::PagedEnumerable<RegionInstanceGroupManagerResizeRequestsListResponse, InstanceGroupManagerResizeRequest> List(ListRegionInstanceGroupManagerResizeRequestsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRegionInstanceGroupManagerResizeRequestsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRegionInstanceGroupManagerResizeRequestsRequest, RegionInstanceGroupManagerResizeRequestsListResponse, InstanceGroupManagerResizeRequest>(_callList, request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of Resize Requests that are contained in the
        /// managed instance group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="InstanceGroupManagerResizeRequest"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<RegionInstanceGroupManagerResizeRequestsListResponse, InstanceGroupManagerResizeRequest> ListAsync(ListRegionInstanceGroupManagerResizeRequestsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRegionInstanceGroupManagerResizeRequestsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRegionInstanceGroupManagerResizeRequestsRequest, RegionInstanceGroupManagerResizeRequestsListResponse, InstanceGroupManagerResizeRequest>(_callList, request, callSettings);
        }
    }

    public partial class ListRegionInstanceGroupManagerResizeRequestsRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class RegionInstanceGroupManagerResizeRequestsListResponse : gaxgrpc::IPageResponse<InstanceGroupManagerResizeRequest>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<InstanceGroupManagerResizeRequest> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class RegionInstanceGroupManagerResizeRequests
    {
        public partial class RegionInstanceGroupManagerResizeRequestsClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client, delegating to RegionOperations.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClientForRegionOperations() =>
                RegionOperations.RegionOperationsClient.CreateOperationsClient(CallInvoker);
        }
    }
}
