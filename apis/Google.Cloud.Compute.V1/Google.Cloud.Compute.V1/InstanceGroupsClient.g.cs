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
    /// <summary>Settings for <see cref="InstanceGroupsClient"/> instances.</summary>
    public sealed partial class InstanceGroupsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="InstanceGroupsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="InstanceGroupsSettings"/>.</returns>
        public static InstanceGroupsSettings GetDefault() => new InstanceGroupsSettings();

        /// <summary>Constructs a new <see cref="InstanceGroupsSettings"/> object with default settings.</summary>
        public InstanceGroupsSettings()
        {
        }

        private InstanceGroupsSettings(InstanceGroupsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            AddInstancesSettings = existing.AddInstancesSettings;
            AddInstancesOperationsSettings = existing.AddInstancesOperationsSettings.Clone();
            AggregatedListSettings = existing.AggregatedListSettings;
            DeleteSettings = existing.DeleteSettings;
            DeleteOperationsSettings = existing.DeleteOperationsSettings.Clone();
            GetSettings = existing.GetSettings;
            InsertSettings = existing.InsertSettings;
            InsertOperationsSettings = existing.InsertOperationsSettings.Clone();
            ListSettings = existing.ListSettings;
            ListInstancesSettings = existing.ListInstancesSettings;
            RemoveInstancesSettings = existing.RemoveInstancesSettings;
            RemoveInstancesOperationsSettings = existing.RemoveInstancesOperationsSettings.Clone();
            SetNamedPortsSettings = existing.SetNamedPortsSettings;
            SetNamedPortsOperationsSettings = existing.SetNamedPortsOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(InstanceGroupsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceGroupsClient.AddInstances</c> and <c>InstanceGroupsClient.AddInstancesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AddInstancesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstanceGroupsClient.AddInstances</c> and
        /// <c>InstanceGroupsClient.AddInstancesAsync</c>.
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
        public lro::OperationsSettings AddInstancesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceGroupsClient.AggregatedList</c> and <c>InstanceGroupsClient.AggregatedListAsync</c>.
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
        public gaxgrpc::CallSettings AggregatedListSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>InstanceGroupsClient.Delete</c>
        ///  and <c>InstanceGroupsClient.DeleteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstanceGroupsClient.Delete</c> and
        /// <c>InstanceGroupsClient.DeleteAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>InstanceGroupsClient.Get</c>
        ///  and <c>InstanceGroupsClient.GetAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>InstanceGroupsClient.Insert</c>
        ///  and <c>InstanceGroupsClient.InsertAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InsertSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstanceGroupsClient.Insert</c> and
        /// <c>InstanceGroupsClient.InsertAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>InstanceGroupsClient.List</c>
        ///  and <c>InstanceGroupsClient.ListAsync</c>.
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

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceGroupsClient.ListInstances</c> and <c>InstanceGroupsClient.ListInstancesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListInstancesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceGroupsClient.RemoveInstances</c> and <c>InstanceGroupsClient.RemoveInstancesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RemoveInstancesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstanceGroupsClient.RemoveInstances</c> and
        /// <c>InstanceGroupsClient.RemoveInstancesAsync</c>.
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
        public lro::OperationsSettings RemoveInstancesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceGroupsClient.SetNamedPorts</c> and <c>InstanceGroupsClient.SetNamedPortsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetNamedPortsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstanceGroupsClient.SetNamedPorts</c> and
        /// <c>InstanceGroupsClient.SetNamedPortsAsync</c>.
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
        public lro::OperationsSettings SetNamedPortsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="InstanceGroupsSettings"/> object.</returns>
        public InstanceGroupsSettings Clone() => new InstanceGroupsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="InstanceGroupsClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class InstanceGroupsClientBuilder : gaxgrpc::ClientBuilderBase<InstanceGroupsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public InstanceGroupsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public InstanceGroupsClientBuilder() : base(InstanceGroupsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref InstanceGroupsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<InstanceGroupsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override InstanceGroupsClient Build()
        {
            InstanceGroupsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<InstanceGroupsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<InstanceGroupsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private InstanceGroupsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return InstanceGroupsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<InstanceGroupsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return InstanceGroupsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => InstanceGroupsClient.ChannelPool;
    }

    /// <summary>InstanceGroups client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The InstanceGroups API.
    /// </remarks>
    public abstract partial class InstanceGroupsClient
    {
        /// <summary>
        /// The default endpoint for the InstanceGroups service, which is a host of "compute.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default InstanceGroups scopes.</summary>
        /// <remarks>
        /// The default InstanceGroups scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(InstanceGroups.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="InstanceGroupsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="InstanceGroupsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="InstanceGroupsClient"/>.</returns>
        public static stt::Task<InstanceGroupsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new InstanceGroupsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="InstanceGroupsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="InstanceGroupsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="InstanceGroupsClient"/>.</returns>
        public static InstanceGroupsClient Create() => new InstanceGroupsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="InstanceGroupsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="InstanceGroupsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="InstanceGroupsClient"/>.</returns>
        internal static InstanceGroupsClient Create(grpccore::CallInvoker callInvoker, InstanceGroupsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            InstanceGroups.InstanceGroupsClient grpcClient = new InstanceGroups.InstanceGroupsClient(callInvoker);
            return new InstanceGroupsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC InstanceGroups client</summary>
        public virtual InstanceGroups.InstanceGroupsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a list of instances to the specified instance group. All of the instances in the instance group must be in the same network/subnetwork. Read Adding instances for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> AddInstances(AddInstancesInstanceGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a list of instances to the specified instance group. All of the instances in the instance group must be in the same network/subnetwork. Read Adding instances for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddInstancesAsync(AddInstancesInstanceGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a list of instances to the specified instance group. All of the instances in the instance group must be in the same network/subnetwork. Read Adding instances for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddInstancesAsync(AddInstancesInstanceGroupRequest request, st::CancellationToken cancellationToken) =>
            AddInstancesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>AddInstances</c>.</summary>
        public virtual lro::OperationsClient AddInstancesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>AddInstances</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceAddInstances(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AddInstancesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>AddInstances</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceAddInstancesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AddInstancesOperationsClient, callSettings);

        /// <summary>
        /// Adds a list of instances to the specified instance group. All of the instances in the instance group must be in the same network/subnetwork. Read Adding instances for more information.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone where the instance group is located.
        /// </param>
        /// <param name="instanceGroup">
        /// The name of the instance group where you are adding instances.
        /// </param>
        /// <param name="instanceGroupsAddInstancesRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> AddInstances(string project, string zone, string instanceGroup, InstanceGroupsAddInstancesRequest instanceGroupsAddInstancesRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            AddInstances(new AddInstancesInstanceGroupRequest
            {
                InstanceGroup = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceGroup, nameof(instanceGroup)),
                InstanceGroupsAddInstancesRequestResource = gax::GaxPreconditions.CheckNotNull(instanceGroupsAddInstancesRequestResource, nameof(instanceGroupsAddInstancesRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Adds a list of instances to the specified instance group. All of the instances in the instance group must be in the same network/subnetwork. Read Adding instances for more information.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone where the instance group is located.
        /// </param>
        /// <param name="instanceGroup">
        /// The name of the instance group where you are adding instances.
        /// </param>
        /// <param name="instanceGroupsAddInstancesRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddInstancesAsync(string project, string zone, string instanceGroup, InstanceGroupsAddInstancesRequest instanceGroupsAddInstancesRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            AddInstancesAsync(new AddInstancesInstanceGroupRequest
            {
                InstanceGroup = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceGroup, nameof(instanceGroup)),
                InstanceGroupsAddInstancesRequestResource = gax::GaxPreconditions.CheckNotNull(instanceGroupsAddInstancesRequestResource, nameof(instanceGroupsAddInstancesRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Adds a list of instances to the specified instance group. All of the instances in the instance group must be in the same network/subnetwork. Read Adding instances for more information.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone where the instance group is located.
        /// </param>
        /// <param name="instanceGroup">
        /// The name of the instance group where you are adding instances.
        /// </param>
        /// <param name="instanceGroupsAddInstancesRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AddInstancesAsync(string project, string zone, string instanceGroup, InstanceGroupsAddInstancesRequest instanceGroupsAddInstancesRequestResource, st::CancellationToken cancellationToken) =>
            AddInstancesAsync(project, zone, instanceGroup, instanceGroupsAddInstancesRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the list of instance groups and sorts them by zone. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.</returns>
        public virtual gax::PagedEnumerable<InstanceGroupAggregatedList, scg::KeyValuePair<string, InstanceGroupsScopedList>> AggregatedList(AggregatedListInstanceGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of instance groups and sorts them by zone. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<InstanceGroupAggregatedList, scg::KeyValuePair<string, InstanceGroupsScopedList>> AggregatedListAsync(AggregatedListInstanceGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of instance groups and sorts them by zone. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
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
        /// <returns>A pageable sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.</returns>
        public virtual gax::PagedEnumerable<InstanceGroupAggregatedList, scg::KeyValuePair<string, InstanceGroupsScopedList>> AggregatedList(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            AggregatedListInstanceGroupsRequest request = new AggregatedListInstanceGroupsRequest
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
            return AggregatedList(request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of instance groups and sorts them by zone. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
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
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<InstanceGroupAggregatedList, scg::KeyValuePair<string, InstanceGroupsScopedList>> AggregatedListAsync(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            AggregatedListInstanceGroupsRequest request = new AggregatedListInstanceGroupsRequest
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
            return AggregatedListAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified instance group. The instances in the group are not deleted. Note that instance group must not belong to a backend service. Read Deleting an instance group for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Delete(DeleteInstanceGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified instance group. The instances in the group are not deleted. Note that instance group must not belong to a backend service. Read Deleting an instance group for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteInstanceGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified instance group. The instances in the group are not deleted. Note that instance group must not belong to a backend service. Read Deleting an instance group for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteInstanceGroupRequest request, st::CancellationToken cancellationToken) =>
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
        /// Deletes the specified instance group. The instances in the group are not deleted. Note that instance group must not belong to a backend service. Read Deleting an instance group for more information.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone where the instance group is located.
        /// </param>
        /// <param name="instanceGroup">
        /// The name of the instance group to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Delete(string project, string zone, string instanceGroup, gaxgrpc::CallSettings callSettings = null) =>
            Delete(new DeleteInstanceGroupRequest
            {
                InstanceGroup = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceGroup, nameof(instanceGroup)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified instance group. The instances in the group are not deleted. Note that instance group must not belong to a backend service. Read Deleting an instance group for more information.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone where the instance group is located.
        /// </param>
        /// <param name="instanceGroup">
        /// The name of the instance group to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(string project, string zone, string instanceGroup, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAsync(new DeleteInstanceGroupRequest
            {
                InstanceGroup = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceGroup, nameof(instanceGroup)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified instance group. The instances in the group are not deleted. Note that instance group must not belong to a backend service. Read Deleting an instance group for more information.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone where the instance group is located.
        /// </param>
        /// <param name="instanceGroup">
        /// The name of the instance group to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(string project, string zone, string instanceGroup, st::CancellationToken cancellationToken) =>
            DeleteAsync(project, zone, instanceGroup, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified zonal instance group. Get a list of available zonal instance groups by making a list() request. For managed instance groups, use the instanceGroupManagers or regionInstanceGroupManagers methods instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InstanceGroup Get(GetInstanceGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified zonal instance group. Get a list of available zonal instance groups by making a list() request. For managed instance groups, use the instanceGroupManagers or regionInstanceGroupManagers methods instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceGroup> GetAsync(GetInstanceGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified zonal instance group. Get a list of available zonal instance groups by making a list() request. For managed instance groups, use the instanceGroupManagers or regionInstanceGroupManagers methods instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceGroup> GetAsync(GetInstanceGroupRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified zonal instance group. Get a list of available zonal instance groups by making a list() request. For managed instance groups, use the instanceGroupManagers or regionInstanceGroupManagers methods instead.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone where the instance group is located.
        /// </param>
        /// <param name="instanceGroup">
        /// The name of the instance group.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InstanceGroup Get(string project, string zone, string instanceGroup, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetInstanceGroupRequest
            {
                InstanceGroup = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceGroup, nameof(instanceGroup)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Returns the specified zonal instance group. Get a list of available zonal instance groups by making a list() request. For managed instance groups, use the instanceGroupManagers or regionInstanceGroupManagers methods instead.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone where the instance group is located.
        /// </param>
        /// <param name="instanceGroup">
        /// The name of the instance group.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceGroup> GetAsync(string project, string zone, string instanceGroup, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetInstanceGroupRequest
            {
                InstanceGroup = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceGroup, nameof(instanceGroup)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Returns the specified zonal instance group. Get a list of available zonal instance groups by making a list() request. For managed instance groups, use the instanceGroupManagers or regionInstanceGroupManagers methods instead.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone where the instance group is located.
        /// </param>
        /// <param name="instanceGroup">
        /// The name of the instance group.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstanceGroup> GetAsync(string project, string zone, string instanceGroup, st::CancellationToken cancellationToken) =>
            GetAsync(project, zone, instanceGroup, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an instance group in the specified project using the parameters that are included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Insert(InsertInstanceGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an instance group in the specified project using the parameters that are included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertInstanceGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an instance group in the specified project using the parameters that are included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertInstanceGroupRequest request, st::CancellationToken cancellationToken) =>
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
        /// Creates an instance group in the specified project using the parameters that are included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone where you want to create the instance group.
        /// </param>
        /// <param name="instanceGroupResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Insert(string project, string zone, InstanceGroup instanceGroupResource, gaxgrpc::CallSettings callSettings = null) =>
            Insert(new InsertInstanceGroupRequest
            {
                InstanceGroupResource = gax::GaxPreconditions.CheckNotNull(instanceGroupResource, nameof(instanceGroupResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Creates an instance group in the specified project using the parameters that are included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone where you want to create the instance group.
        /// </param>
        /// <param name="instanceGroupResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(string project, string zone, InstanceGroup instanceGroupResource, gaxgrpc::CallSettings callSettings = null) =>
            InsertAsync(new InsertInstanceGroupRequest
            {
                InstanceGroupResource = gax::GaxPreconditions.CheckNotNull(instanceGroupResource, nameof(instanceGroupResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Creates an instance group in the specified project using the parameters that are included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone where you want to create the instance group.
        /// </param>
        /// <param name="instanceGroupResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(string project, string zone, InstanceGroup instanceGroupResource, st::CancellationToken cancellationToken) =>
            InsertAsync(project, zone, instanceGroupResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the list of zonal instance group resources contained within the specified zone. For managed instance groups, use the instanceGroupManagers or regionInstanceGroupManagers methods instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="InstanceGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<InstanceGroupList, InstanceGroup> List(ListInstanceGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of zonal instance group resources contained within the specified zone. For managed instance groups, use the instanceGroupManagers or regionInstanceGroupManagers methods instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="InstanceGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<InstanceGroupList, InstanceGroup> ListAsync(ListInstanceGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of zonal instance group resources contained within the specified zone. For managed instance groups, use the instanceGroupManagers or regionInstanceGroupManagers methods instead.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone where the instance group is located.
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
        /// <returns>A pageable sequence of <see cref="InstanceGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<InstanceGroupList, InstanceGroup> List(string project, string zone, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstanceGroupsRequest request = new ListInstanceGroupsRequest
            {
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
        /// Retrieves the list of zonal instance group resources contained within the specified zone. For managed instance groups, use the instanceGroupManagers or regionInstanceGroupManagers methods instead.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone where the instance group is located.
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
        /// <returns>A pageable asynchronous sequence of <see cref="InstanceGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<InstanceGroupList, InstanceGroup> ListAsync(string project, string zone, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstanceGroupsRequest request = new ListInstanceGroupsRequest
            {
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

        /// <summary>
        /// Lists the instances in the specified instance group. The orderBy query parameter is not supported. The filter query parameter is supported, but only for expressions that use `eq` (equal) or `ne` (not equal) operators.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="InstanceWithNamedPorts"/> resources.</returns>
        public virtual gax::PagedEnumerable<InstanceGroupsListInstances, InstanceWithNamedPorts> ListInstances(ListInstancesInstanceGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the instances in the specified instance group. The orderBy query parameter is not supported. The filter query parameter is supported, but only for expressions that use `eq` (equal) or `ne` (not equal) operators.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="InstanceWithNamedPorts"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<InstanceGroupsListInstances, InstanceWithNamedPorts> ListInstancesAsync(ListInstancesInstanceGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the instances in the specified instance group. The orderBy query parameter is not supported. The filter query parameter is supported, but only for expressions that use `eq` (equal) or `ne` (not equal) operators.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone where the instance group is located.
        /// </param>
        /// <param name="instanceGroup">
        /// The name of the instance group from which you want to generate a list of included instances.
        /// </param>
        /// <param name="instanceGroupsListInstancesRequestResource">
        /// The body resource for this request
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
        /// <returns>A pageable sequence of <see cref="InstanceWithNamedPorts"/> resources.</returns>
        public virtual gax::PagedEnumerable<InstanceGroupsListInstances, InstanceWithNamedPorts> ListInstances(string project, string zone, string instanceGroup, InstanceGroupsListInstancesRequest instanceGroupsListInstancesRequestResource, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstancesInstanceGroupsRequest request = new ListInstancesInstanceGroupsRequest
            {
                InstanceGroup = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceGroup, nameof(instanceGroup)),
                InstanceGroupsListInstancesRequestResource = gax::GaxPreconditions.CheckNotNull(instanceGroupsListInstancesRequestResource, nameof(instanceGroupsListInstancesRequestResource)),
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
            return ListInstances(request, callSettings);
        }

        /// <summary>
        /// Lists the instances in the specified instance group. The orderBy query parameter is not supported. The filter query parameter is supported, but only for expressions that use `eq` (equal) or `ne` (not equal) operators.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone where the instance group is located.
        /// </param>
        /// <param name="instanceGroup">
        /// The name of the instance group from which you want to generate a list of included instances.
        /// </param>
        /// <param name="instanceGroupsListInstancesRequestResource">
        /// The body resource for this request
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
        /// <returns>A pageable asynchronous sequence of <see cref="InstanceWithNamedPorts"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<InstanceGroupsListInstances, InstanceWithNamedPorts> ListInstancesAsync(string project, string zone, string instanceGroup, InstanceGroupsListInstancesRequest instanceGroupsListInstancesRequestResource, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstancesInstanceGroupsRequest request = new ListInstancesInstanceGroupsRequest
            {
                InstanceGroup = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceGroup, nameof(instanceGroup)),
                InstanceGroupsListInstancesRequestResource = gax::GaxPreconditions.CheckNotNull(instanceGroupsListInstancesRequestResource, nameof(instanceGroupsListInstancesRequestResource)),
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
            return ListInstancesAsync(request, callSettings);
        }

        /// <summary>
        /// Removes one or more instances from the specified instance group, but does not delete those instances. If the group is part of a backend service that has enabled connection draining, it can take up to 60 seconds after the connection draining duration before the VM instance is removed or deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> RemoveInstances(RemoveInstancesInstanceGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes one or more instances from the specified instance group, but does not delete those instances. If the group is part of a backend service that has enabled connection draining, it can take up to 60 seconds after the connection draining duration before the VM instance is removed or deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> RemoveInstancesAsync(RemoveInstancesInstanceGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes one or more instances from the specified instance group, but does not delete those instances. If the group is part of a backend service that has enabled connection draining, it can take up to 60 seconds after the connection draining duration before the VM instance is removed or deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> RemoveInstancesAsync(RemoveInstancesInstanceGroupRequest request, st::CancellationToken cancellationToken) =>
            RemoveInstancesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RemoveInstances</c>.</summary>
        public virtual lro::OperationsClient RemoveInstancesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RemoveInstances</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceRemoveInstances(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RemoveInstancesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RemoveInstances</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceRemoveInstancesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RemoveInstancesOperationsClient, callSettings);

        /// <summary>
        /// Removes one or more instances from the specified instance group, but does not delete those instances. If the group is part of a backend service that has enabled connection draining, it can take up to 60 seconds after the connection draining duration before the VM instance is removed or deleted.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone where the instance group is located.
        /// </param>
        /// <param name="instanceGroup">
        /// The name of the instance group where the specified instances will be removed.
        /// </param>
        /// <param name="instanceGroupsRemoveInstancesRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> RemoveInstances(string project, string zone, string instanceGroup, InstanceGroupsRemoveInstancesRequest instanceGroupsRemoveInstancesRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            RemoveInstances(new RemoveInstancesInstanceGroupRequest
            {
                InstanceGroup = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceGroup, nameof(instanceGroup)),
                InstanceGroupsRemoveInstancesRequestResource = gax::GaxPreconditions.CheckNotNull(instanceGroupsRemoveInstancesRequestResource, nameof(instanceGroupsRemoveInstancesRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Removes one or more instances from the specified instance group, but does not delete those instances. If the group is part of a backend service that has enabled connection draining, it can take up to 60 seconds after the connection draining duration before the VM instance is removed or deleted.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone where the instance group is located.
        /// </param>
        /// <param name="instanceGroup">
        /// The name of the instance group where the specified instances will be removed.
        /// </param>
        /// <param name="instanceGroupsRemoveInstancesRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> RemoveInstancesAsync(string project, string zone, string instanceGroup, InstanceGroupsRemoveInstancesRequest instanceGroupsRemoveInstancesRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            RemoveInstancesAsync(new RemoveInstancesInstanceGroupRequest
            {
                InstanceGroup = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceGroup, nameof(instanceGroup)),
                InstanceGroupsRemoveInstancesRequestResource = gax::GaxPreconditions.CheckNotNull(instanceGroupsRemoveInstancesRequestResource, nameof(instanceGroupsRemoveInstancesRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Removes one or more instances from the specified instance group, but does not delete those instances. If the group is part of a backend service that has enabled connection draining, it can take up to 60 seconds after the connection draining duration before the VM instance is removed or deleted.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone where the instance group is located.
        /// </param>
        /// <param name="instanceGroup">
        /// The name of the instance group where the specified instances will be removed.
        /// </param>
        /// <param name="instanceGroupsRemoveInstancesRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> RemoveInstancesAsync(string project, string zone, string instanceGroup, InstanceGroupsRemoveInstancesRequest instanceGroupsRemoveInstancesRequestResource, st::CancellationToken cancellationToken) =>
            RemoveInstancesAsync(project, zone, instanceGroup, instanceGroupsRemoveInstancesRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the named ports for the specified instance group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetNamedPorts(SetNamedPortsInstanceGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the named ports for the specified instance group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetNamedPortsAsync(SetNamedPortsInstanceGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the named ports for the specified instance group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetNamedPortsAsync(SetNamedPortsInstanceGroupRequest request, st::CancellationToken cancellationToken) =>
            SetNamedPortsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SetNamedPorts</c>.</summary>
        public virtual lro::OperationsClient SetNamedPortsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SetNamedPorts</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceSetNamedPorts(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetNamedPortsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetNamedPorts</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceSetNamedPortsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetNamedPortsOperationsClient, callSettings);

        /// <summary>
        /// Sets the named ports for the specified instance group.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone where the instance group is located.
        /// </param>
        /// <param name="instanceGroup">
        /// The name of the instance group where the named ports are updated.
        /// </param>
        /// <param name="instanceGroupsSetNamedPortsRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetNamedPorts(string project, string zone, string instanceGroup, InstanceGroupsSetNamedPortsRequest instanceGroupsSetNamedPortsRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetNamedPorts(new SetNamedPortsInstanceGroupRequest
            {
                InstanceGroup = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceGroup, nameof(instanceGroup)),
                InstanceGroupsSetNamedPortsRequestResource = gax::GaxPreconditions.CheckNotNull(instanceGroupsSetNamedPortsRequestResource, nameof(instanceGroupsSetNamedPortsRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Sets the named ports for the specified instance group.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone where the instance group is located.
        /// </param>
        /// <param name="instanceGroup">
        /// The name of the instance group where the named ports are updated.
        /// </param>
        /// <param name="instanceGroupsSetNamedPortsRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetNamedPortsAsync(string project, string zone, string instanceGroup, InstanceGroupsSetNamedPortsRequest instanceGroupsSetNamedPortsRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetNamedPortsAsync(new SetNamedPortsInstanceGroupRequest
            {
                InstanceGroup = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceGroup, nameof(instanceGroup)),
                InstanceGroupsSetNamedPortsRequestResource = gax::GaxPreconditions.CheckNotNull(instanceGroupsSetNamedPortsRequestResource, nameof(instanceGroupsSetNamedPortsRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Sets the named ports for the specified instance group.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone where the instance group is located.
        /// </param>
        /// <param name="instanceGroup">
        /// The name of the instance group where the named ports are updated.
        /// </param>
        /// <param name="instanceGroupsSetNamedPortsRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetNamedPortsAsync(string project, string zone, string instanceGroup, InstanceGroupsSetNamedPortsRequest instanceGroupsSetNamedPortsRequestResource, st::CancellationToken cancellationToken) =>
            SetNamedPortsAsync(project, zone, instanceGroup, instanceGroupsSetNamedPortsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>InstanceGroups client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The InstanceGroups API.
    /// </remarks>
    public sealed partial class InstanceGroupsClientImpl : InstanceGroupsClient
    {
        private readonly gaxgrpc::ApiCall<AddInstancesInstanceGroupRequest, Operation> _callAddInstances;

        private readonly gaxgrpc::ApiCall<AggregatedListInstanceGroupsRequest, InstanceGroupAggregatedList> _callAggregatedList;

        private readonly gaxgrpc::ApiCall<DeleteInstanceGroupRequest, Operation> _callDelete;

        private readonly gaxgrpc::ApiCall<GetInstanceGroupRequest, InstanceGroup> _callGet;

        private readonly gaxgrpc::ApiCall<InsertInstanceGroupRequest, Operation> _callInsert;

        private readonly gaxgrpc::ApiCall<ListInstanceGroupsRequest, InstanceGroupList> _callList;

        private readonly gaxgrpc::ApiCall<ListInstancesInstanceGroupsRequest, InstanceGroupsListInstances> _callListInstances;

        private readonly gaxgrpc::ApiCall<RemoveInstancesInstanceGroupRequest, Operation> _callRemoveInstances;

        private readonly gaxgrpc::ApiCall<SetNamedPortsInstanceGroupRequest, Operation> _callSetNamedPorts;

        /// <summary>
        /// Constructs a client wrapper for the InstanceGroups service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="InstanceGroupsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public InstanceGroupsClientImpl(InstanceGroups.InstanceGroupsClient grpcClient, InstanceGroupsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            InstanceGroupsSettings effectiveSettings = settings ?? InstanceGroupsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            AddInstancesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.AddInstancesOperationsSettings, logger);
            DeleteOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.DeleteOperationsSettings, logger);
            InsertOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.InsertOperationsSettings, logger);
            RemoveInstancesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.RemoveInstancesOperationsSettings, logger);
            SetNamedPortsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.SetNamedPortsOperationsSettings, logger);
            _callAddInstances = clientHelper.BuildApiCall<AddInstancesInstanceGroupRequest, Operation>("AddInstances", grpcClient.AddInstancesAsync, grpcClient.AddInstances, effectiveSettings.AddInstancesSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance_group", request => request.InstanceGroup);
            Modify_ApiCall(ref _callAddInstances);
            Modify_AddInstancesApiCall(ref _callAddInstances);
            _callAggregatedList = clientHelper.BuildApiCall<AggregatedListInstanceGroupsRequest, InstanceGroupAggregatedList>("AggregatedList", grpcClient.AggregatedListAsync, grpcClient.AggregatedList, effectiveSettings.AggregatedListSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callAggregatedList);
            Modify_AggregatedListApiCall(ref _callAggregatedList);
            _callDelete = clientHelper.BuildApiCall<DeleteInstanceGroupRequest, Operation>("Delete", grpcClient.DeleteAsync, grpcClient.Delete, effectiveSettings.DeleteSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance_group", request => request.InstanceGroup);
            Modify_ApiCall(ref _callDelete);
            Modify_DeleteApiCall(ref _callDelete);
            _callGet = clientHelper.BuildApiCall<GetInstanceGroupRequest, InstanceGroup>("Get", grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance_group", request => request.InstanceGroup);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callInsert = clientHelper.BuildApiCall<InsertInstanceGroupRequest, Operation>("Insert", grpcClient.InsertAsync, grpcClient.Insert, effectiveSettings.InsertSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone);
            Modify_ApiCall(ref _callInsert);
            Modify_InsertApiCall(ref _callInsert);
            _callList = clientHelper.BuildApiCall<ListInstanceGroupsRequest, InstanceGroupList>("List", grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            _callListInstances = clientHelper.BuildApiCall<ListInstancesInstanceGroupsRequest, InstanceGroupsListInstances>("ListInstances", grpcClient.ListInstancesAsync, grpcClient.ListInstances, effectiveSettings.ListInstancesSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance_group", request => request.InstanceGroup);
            Modify_ApiCall(ref _callListInstances);
            Modify_ListInstancesApiCall(ref _callListInstances);
            _callRemoveInstances = clientHelper.BuildApiCall<RemoveInstancesInstanceGroupRequest, Operation>("RemoveInstances", grpcClient.RemoveInstancesAsync, grpcClient.RemoveInstances, effectiveSettings.RemoveInstancesSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance_group", request => request.InstanceGroup);
            Modify_ApiCall(ref _callRemoveInstances);
            Modify_RemoveInstancesApiCall(ref _callRemoveInstances);
            _callSetNamedPorts = clientHelper.BuildApiCall<SetNamedPortsInstanceGroupRequest, Operation>("SetNamedPorts", grpcClient.SetNamedPortsAsync, grpcClient.SetNamedPorts, effectiveSettings.SetNamedPortsSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("instance_group", request => request.InstanceGroup);
            Modify_ApiCall(ref _callSetNamedPorts);
            Modify_SetNamedPortsApiCall(ref _callSetNamedPorts);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_AddInstancesApiCall(ref gaxgrpc::ApiCall<AddInstancesInstanceGroupRequest, Operation> call);

        partial void Modify_AggregatedListApiCall(ref gaxgrpc::ApiCall<AggregatedListInstanceGroupsRequest, InstanceGroupAggregatedList> call);

        partial void Modify_DeleteApiCall(ref gaxgrpc::ApiCall<DeleteInstanceGroupRequest, Operation> call);

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetInstanceGroupRequest, InstanceGroup> call);

        partial void Modify_InsertApiCall(ref gaxgrpc::ApiCall<InsertInstanceGroupRequest, Operation> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListInstanceGroupsRequest, InstanceGroupList> call);

        partial void Modify_ListInstancesApiCall(ref gaxgrpc::ApiCall<ListInstancesInstanceGroupsRequest, InstanceGroupsListInstances> call);

        partial void Modify_RemoveInstancesApiCall(ref gaxgrpc::ApiCall<RemoveInstancesInstanceGroupRequest, Operation> call);

        partial void Modify_SetNamedPortsApiCall(ref gaxgrpc::ApiCall<SetNamedPortsInstanceGroupRequest, Operation> call);

        partial void OnConstruction(InstanceGroups.InstanceGroupsClient grpcClient, InstanceGroupsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC InstanceGroups client</summary>
        public override InstanceGroups.InstanceGroupsClient GrpcClient { get; }

        partial void Modify_AddInstancesInstanceGroupRequest(ref AddInstancesInstanceGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AggregatedListInstanceGroupsRequest(ref AggregatedListInstanceGroupsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteInstanceGroupRequest(ref DeleteInstanceGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetInstanceGroupRequest(ref GetInstanceGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InsertInstanceGroupRequest(ref InsertInstanceGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListInstanceGroupsRequest(ref ListInstanceGroupsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListInstancesInstanceGroupsRequest(ref ListInstancesInstanceGroupsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RemoveInstancesInstanceGroupRequest(ref RemoveInstancesInstanceGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetNamedPortsInstanceGroupRequest(ref SetNamedPortsInstanceGroupRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>AddInstances</c>.</summary>
        public override lro::OperationsClient AddInstancesOperationsClient { get; }

        /// <summary>
        /// Adds a list of instances to the specified instance group. All of the instances in the instance group must be in the same network/subnetwork. Read Adding instances for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> AddInstances(AddInstancesInstanceGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddInstancesInstanceGroupRequest(ref request, ref callSettings);
            Operation response = _callAddInstances.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), AddInstancesOperationsClient);
        }

        /// <summary>
        /// Adds a list of instances to the specified instance group. All of the instances in the instance group must be in the same network/subnetwork. Read Adding instances for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> AddInstancesAsync(AddInstancesInstanceGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddInstancesInstanceGroupRequest(ref request, ref callSettings);
            Operation response = await _callAddInstances.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), AddInstancesOperationsClient);
        }

        /// <summary>
        /// Retrieves the list of instance groups and sorts them by zone. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.</returns>
        public override gax::PagedEnumerable<InstanceGroupAggregatedList, scg::KeyValuePair<string, InstanceGroupsScopedList>> AggregatedList(AggregatedListInstanceGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregatedListInstanceGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<AggregatedListInstanceGroupsRequest, InstanceGroupAggregatedList, scg::KeyValuePair<string, InstanceGroupsScopedList>>(_callAggregatedList, request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of instance groups and sorts them by zone. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<InstanceGroupAggregatedList, scg::KeyValuePair<string, InstanceGroupsScopedList>> AggregatedListAsync(AggregatedListInstanceGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregatedListInstanceGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<AggregatedListInstanceGroupsRequest, InstanceGroupAggregatedList, scg::KeyValuePair<string, InstanceGroupsScopedList>>(_callAggregatedList, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>Delete</c>.</summary>
        public override lro::OperationsClient DeleteOperationsClient { get; }

        /// <summary>
        /// Deletes the specified instance group. The instances in the group are not deleted. Note that instance group must not belong to a backend service. Read Deleting an instance group for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Delete(DeleteInstanceGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInstanceGroupRequest(ref request, ref callSettings);
            Operation response = _callDelete.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DeleteOperationsClient);
        }

        /// <summary>
        /// Deletes the specified instance group. The instances in the group are not deleted. Note that instance group must not belong to a backend service. Read Deleting an instance group for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteInstanceGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInstanceGroupRequest(ref request, ref callSettings);
            Operation response = await _callDelete.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DeleteOperationsClient);
        }

        /// <summary>
        /// Returns the specified zonal instance group. Get a list of available zonal instance groups by making a list() request. For managed instance groups, use the instanceGroupManagers or regionInstanceGroupManagers methods instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override InstanceGroup Get(GetInstanceGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInstanceGroupRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified zonal instance group. Get a list of available zonal instance groups by making a list() request. For managed instance groups, use the instanceGroupManagers or regionInstanceGroupManagers methods instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<InstanceGroup> GetAsync(GetInstanceGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInstanceGroupRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>Insert</c>.</summary>
        public override lro::OperationsClient InsertOperationsClient { get; }

        /// <summary>
        /// Creates an instance group in the specified project using the parameters that are included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Insert(InsertInstanceGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertInstanceGroupRequest(ref request, ref callSettings);
            Operation response = _callInsert.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), InsertOperationsClient);
        }

        /// <summary>
        /// Creates an instance group in the specified project using the parameters that are included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertInstanceGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertInstanceGroupRequest(ref request, ref callSettings);
            Operation response = await _callInsert.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), InsertOperationsClient);
        }

        /// <summary>
        /// Retrieves the list of zonal instance group resources contained within the specified zone. For managed instance groups, use the instanceGroupManagers or regionInstanceGroupManagers methods instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="InstanceGroup"/> resources.</returns>
        public override gax::PagedEnumerable<InstanceGroupList, InstanceGroup> List(ListInstanceGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstanceGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListInstanceGroupsRequest, InstanceGroupList, InstanceGroup>(_callList, request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of zonal instance group resources contained within the specified zone. For managed instance groups, use the instanceGroupManagers or regionInstanceGroupManagers methods instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="InstanceGroup"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<InstanceGroupList, InstanceGroup> ListAsync(ListInstanceGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstanceGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListInstanceGroupsRequest, InstanceGroupList, InstanceGroup>(_callList, request, callSettings);
        }

        /// <summary>
        /// Lists the instances in the specified instance group. The orderBy query parameter is not supported. The filter query parameter is supported, but only for expressions that use `eq` (equal) or `ne` (not equal) operators.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="InstanceWithNamedPorts"/> resources.</returns>
        public override gax::PagedEnumerable<InstanceGroupsListInstances, InstanceWithNamedPorts> ListInstances(ListInstancesInstanceGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstancesInstanceGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListInstancesInstanceGroupsRequest, InstanceGroupsListInstances, InstanceWithNamedPorts>(_callListInstances, request, callSettings);
        }

        /// <summary>
        /// Lists the instances in the specified instance group. The orderBy query parameter is not supported. The filter query parameter is supported, but only for expressions that use `eq` (equal) or `ne` (not equal) operators.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="InstanceWithNamedPorts"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<InstanceGroupsListInstances, InstanceWithNamedPorts> ListInstancesAsync(ListInstancesInstanceGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstancesInstanceGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListInstancesInstanceGroupsRequest, InstanceGroupsListInstances, InstanceWithNamedPorts>(_callListInstances, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>RemoveInstances</c>.</summary>
        public override lro::OperationsClient RemoveInstancesOperationsClient { get; }

        /// <summary>
        /// Removes one or more instances from the specified instance group, but does not delete those instances. If the group is part of a backend service that has enabled connection draining, it can take up to 60 seconds after the connection draining duration before the VM instance is removed or deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> RemoveInstances(RemoveInstancesInstanceGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveInstancesInstanceGroupRequest(ref request, ref callSettings);
            Operation response = _callRemoveInstances.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), RemoveInstancesOperationsClient);
        }

        /// <summary>
        /// Removes one or more instances from the specified instance group, but does not delete those instances. If the group is part of a backend service that has enabled connection draining, it can take up to 60 seconds after the connection draining duration before the VM instance is removed or deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> RemoveInstancesAsync(RemoveInstancesInstanceGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveInstancesInstanceGroupRequest(ref request, ref callSettings);
            Operation response = await _callRemoveInstances.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), RemoveInstancesOperationsClient);
        }

        /// <summary>The long-running operations client for <c>SetNamedPorts</c>.</summary>
        public override lro::OperationsClient SetNamedPortsOperationsClient { get; }

        /// <summary>
        /// Sets the named ports for the specified instance group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> SetNamedPorts(SetNamedPortsInstanceGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetNamedPortsInstanceGroupRequest(ref request, ref callSettings);
            Operation response = _callSetNamedPorts.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetNamedPortsOperationsClient);
        }

        /// <summary>
        /// Sets the named ports for the specified instance group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> SetNamedPortsAsync(SetNamedPortsInstanceGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetNamedPortsInstanceGroupRequest(ref request, ref callSettings);
            Operation response = await _callSetNamedPorts.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetNamedPortsOperationsClient);
        }
    }

    public partial class AggregatedListInstanceGroupsRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class ListInstanceGroupsRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class ListInstancesInstanceGroupsRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class InstanceGroupAggregatedList : gaxgrpc::IPageResponse<scg::KeyValuePair<string, InstanceGroupsScopedList>>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<scg::KeyValuePair<string, InstanceGroupsScopedList>> GetEnumerator() =>
            Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class InstanceGroupList : gaxgrpc::IPageResponse<InstanceGroup>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<InstanceGroup> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class InstanceGroupsListInstances : gaxgrpc::IPageResponse<InstanceWithNamedPorts>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<InstanceWithNamedPorts> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class InstanceGroups
    {
        public partial class InstanceGroupsClient
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
