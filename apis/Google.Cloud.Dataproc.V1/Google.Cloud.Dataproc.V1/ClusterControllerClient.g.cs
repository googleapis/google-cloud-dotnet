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
    /// <summary>Settings for <see cref="ClusterControllerClient"/> instances.</summary>
    public sealed partial class ClusterControllerSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ClusterControllerSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ClusterControllerSettings"/>.</returns>
        public static ClusterControllerSettings GetDefault() => new ClusterControllerSettings();

        /// <summary>Constructs a new <see cref="ClusterControllerSettings"/> object with default settings.</summary>
        public ClusterControllerSettings()
        {
        }

        private ClusterControllerSettings(ClusterControllerSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateClusterSettings = existing.CreateClusterSettings;
            CreateClusterOperationsSettings = existing.CreateClusterOperationsSettings.Clone();
            UpdateClusterSettings = existing.UpdateClusterSettings;
            UpdateClusterOperationsSettings = existing.UpdateClusterOperationsSettings.Clone();
            StopClusterSettings = existing.StopClusterSettings;
            StopClusterOperationsSettings = existing.StopClusterOperationsSettings.Clone();
            StartClusterSettings = existing.StartClusterSettings;
            StartClusterOperationsSettings = existing.StartClusterOperationsSettings.Clone();
            DeleteClusterSettings = existing.DeleteClusterSettings;
            DeleteClusterOperationsSettings = existing.DeleteClusterOperationsSettings.Clone();
            GetClusterSettings = existing.GetClusterSettings;
            ListClustersSettings = existing.ListClustersSettings;
            DiagnoseClusterSettings = existing.DiagnoseClusterSettings;
            DiagnoseClusterOperationsSettings = existing.DiagnoseClusterOperationsSettings.Clone();
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(ClusterControllerSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterControllerClient.CreateCluster</c> and <c>ClusterControllerClient.CreateClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateClusterSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ClusterControllerClient.CreateCluster</c> and
        /// <c>ClusterControllerClient.CreateClusterAsync</c>.
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
        public lro::OperationsSettings CreateClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterControllerClient.UpdateCluster</c> and <c>ClusterControllerClient.UpdateClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateClusterSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ClusterControllerClient.UpdateCluster</c> and
        /// <c>ClusterControllerClient.UpdateClusterAsync</c>.
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
        public lro::OperationsSettings UpdateClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterControllerClient.StopCluster</c> and <c>ClusterControllerClient.StopClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StopClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ClusterControllerClient.StopCluster</c> and
        /// <c>ClusterControllerClient.StopClusterAsync</c>.
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
        public lro::OperationsSettings StopClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterControllerClient.StartCluster</c> and <c>ClusterControllerClient.StartClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StartClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ClusterControllerClient.StartCluster</c> and
        /// <c>ClusterControllerClient.StartClusterAsync</c>.
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
        public lro::OperationsSettings StartClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterControllerClient.DeleteCluster</c> and <c>ClusterControllerClient.DeleteClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteClusterSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ClusterControllerClient.DeleteCluster</c> and
        /// <c>ClusterControllerClient.DeleteClusterAsync</c>.
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
        public lro::OperationsSettings DeleteClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterControllerClient.GetCluster</c> and <c>ClusterControllerClient.GetClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Internal"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>, <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetClusterSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Internal, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterControllerClient.ListClusters</c> and <c>ClusterControllerClient.ListClustersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Internal"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>, <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListClustersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Internal, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterControllerClient.DiagnoseCluster</c> and <c>ClusterControllerClient.DiagnoseClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DiagnoseClusterSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ClusterControllerClient.DiagnoseCluster</c> and
        /// <c>ClusterControllerClient.DiagnoseClusterAsync</c>.
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
        public lro::OperationsSettings DiagnoseClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ClusterControllerSettings"/> object.</returns>
        public ClusterControllerSettings Clone() => new ClusterControllerSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ClusterControllerClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class ClusterControllerClientBuilder : gaxgrpc::ClientBuilderBase<ClusterControllerClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ClusterControllerSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ClusterControllerClientBuilder() : base(ClusterControllerClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ClusterControllerClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ClusterControllerClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ClusterControllerClient Build()
        {
            ClusterControllerClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ClusterControllerClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ClusterControllerClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ClusterControllerClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ClusterControllerClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ClusterControllerClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ClusterControllerClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ClusterControllerClient.ChannelPool;
    }

    /// <summary>ClusterController client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The ClusterControllerService provides methods to manage clusters
    /// of Compute Engine instances.
    /// </remarks>
    public abstract partial class ClusterControllerClient
    {
        /// <summary>
        /// The default endpoint for the ClusterController service, which is a host of "dataproc.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dataproc.googleapis.com:443";

        /// <summary>The default ClusterController scopes.</summary>
        /// <remarks>
        /// The default ClusterController scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ClusterController.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ClusterControllerClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ClusterControllerClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ClusterControllerClient"/>.</returns>
        public static stt::Task<ClusterControllerClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ClusterControllerClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ClusterControllerClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ClusterControllerClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ClusterControllerClient"/>.</returns>
        public static ClusterControllerClient Create() => new ClusterControllerClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ClusterControllerClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ClusterControllerSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ClusterControllerClient"/>.</returns>
        internal static ClusterControllerClient Create(grpccore::CallInvoker callInvoker, ClusterControllerSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ClusterController.ClusterControllerClient grpcClient = new ClusterController.ClusterControllerClient(callInvoker);
            return new ClusterControllerClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ClusterController client</summary>
        public virtual ClusterController.ClusterControllerClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a cluster in a project. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [ClusterOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#clusteroperationmetadata).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Cluster, ClusterOperationMetadata> CreateCluster(CreateClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a cluster in a project. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [ClusterOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#clusteroperationmetadata).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, ClusterOperationMetadata>> CreateClusterAsync(CreateClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a cluster in a project. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [ClusterOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#clusteroperationmetadata).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, ClusterOperationMetadata>> CreateClusterAsync(CreateClusterRequest request, st::CancellationToken cancellationToken) =>
            CreateClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateCluster</c>.</summary>
        public virtual lro::OperationsClient CreateClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Cluster, ClusterOperationMetadata> PollOnceCreateCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Cluster, ClusterOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Cluster, ClusterOperationMetadata>> PollOnceCreateClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Cluster, ClusterOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateClusterOperationsClient, callSettings);

        /// <summary>
        /// Creates a cluster in a project. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [ClusterOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#clusteroperationmetadata).
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the cluster
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Dataproc region in which to handle the request.
        /// </param>
        /// <param name="cluster">
        /// Required. The cluster to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Cluster, ClusterOperationMetadata> CreateCluster(string projectId, string region, Cluster cluster, gaxgrpc::CallSettings callSettings = null) =>
            CreateCluster(new CreateClusterRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                Cluster = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
            }, callSettings);

        /// <summary>
        /// Creates a cluster in a project. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [ClusterOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#clusteroperationmetadata).
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the cluster
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Dataproc region in which to handle the request.
        /// </param>
        /// <param name="cluster">
        /// Required. The cluster to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, ClusterOperationMetadata>> CreateClusterAsync(string projectId, string region, Cluster cluster, gaxgrpc::CallSettings callSettings = null) =>
            CreateClusterAsync(new CreateClusterRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                Cluster = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
            }, callSettings);

        /// <summary>
        /// Creates a cluster in a project. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [ClusterOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#clusteroperationmetadata).
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the cluster
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Dataproc region in which to handle the request.
        /// </param>
        /// <param name="cluster">
        /// Required. The cluster to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, ClusterOperationMetadata>> CreateClusterAsync(string projectId, string region, Cluster cluster, st::CancellationToken cancellationToken) =>
            CreateClusterAsync(projectId, region, cluster, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a cluster in a project. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [ClusterOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#clusteroperationmetadata).
        /// The cluster must be in a
        /// [`RUNNING`][google.cloud.dataproc.v1.ClusterStatus.State] state or an error
        /// is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Cluster, ClusterOperationMetadata> UpdateCluster(UpdateClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a cluster in a project. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [ClusterOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#clusteroperationmetadata).
        /// The cluster must be in a
        /// [`RUNNING`][google.cloud.dataproc.v1.ClusterStatus.State] state or an error
        /// is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, ClusterOperationMetadata>> UpdateClusterAsync(UpdateClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a cluster in a project. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [ClusterOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#clusteroperationmetadata).
        /// The cluster must be in a
        /// [`RUNNING`][google.cloud.dataproc.v1.ClusterStatus.State] state or an error
        /// is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, ClusterOperationMetadata>> UpdateClusterAsync(UpdateClusterRequest request, st::CancellationToken cancellationToken) =>
            UpdateClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateCluster</c>.</summary>
        public virtual lro::OperationsClient UpdateClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Cluster, ClusterOperationMetadata> PollOnceUpdateCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Cluster, ClusterOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Cluster, ClusterOperationMetadata>> PollOnceUpdateClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Cluster, ClusterOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateClusterOperationsClient, callSettings);

        /// <summary>
        /// Updates a cluster in a project. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [ClusterOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#clusteroperationmetadata).
        /// The cluster must be in a
        /// [`RUNNING`][google.cloud.dataproc.v1.ClusterStatus.State] state or an error
        /// is returned.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project the
        /// cluster belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Dataproc region in which to handle the request.
        /// </param>
        /// <param name="clusterName">
        /// Required. The cluster name.
        /// </param>
        /// <param name="cluster">
        /// Required. The changes to the cluster.
        /// </param>
        /// <param name="updateMask">
        /// Required. Specifies the path, relative to `Cluster`, of
        /// the field to update. For example, to change the number of workers
        /// in a cluster to 5, the `update_mask` parameter would be
        /// specified as `config.worker_config.num_instances`,
        /// and the `PATCH` request body would specify the new value, as follows:
        /// 
        /// {
        /// "config":{
        /// "workerConfig":{
        /// "numInstances":"5"
        /// }
        /// }
        /// }
        /// Similarly, to change the number of preemptible workers in a cluster to 5,
        /// the `update_mask` parameter would be
        /// `config.secondary_worker_config.num_instances`, and the `PATCH` request
        /// body would be set as follows:
        /// 
        /// {
        /// "config":{
        /// "secondaryWorkerConfig":{
        /// "numInstances":"5"
        /// }
        /// }
        /// }
        /// &lt;strong&gt;Note:&lt;/strong&gt; Currently, only the following fields can be updated:
        /// 
        /// &lt;table&gt;
        /// &lt;tbody&gt;
        /// &lt;tr&gt;
        /// &lt;td&gt;&lt;strong&gt;Mask&lt;/strong&gt;&lt;/td&gt;
        /// &lt;td&gt;&lt;strong&gt;Purpose&lt;/strong&gt;&lt;/td&gt;
        /// &lt;/tr&gt;
        /// &lt;tr&gt;
        /// &lt;td&gt;&lt;strong&gt;&lt;em&gt;labels&lt;/em&gt;&lt;/strong&gt;&lt;/td&gt;
        /// &lt;td&gt;Update labels&lt;/td&gt;
        /// &lt;/tr&gt;
        /// &lt;tr&gt;
        /// &lt;td&gt;&lt;strong&gt;&lt;em&gt;config.worker_config.num_instances&lt;/em&gt;&lt;/strong&gt;&lt;/td&gt;
        /// &lt;td&gt;Resize primary worker group&lt;/td&gt;
        /// &lt;/tr&gt;
        /// &lt;tr&gt;
        /// &lt;td&gt;&lt;strong&gt;&lt;em&gt;config.secondary_worker_config.num_instances&lt;/em&gt;&lt;/strong&gt;&lt;/td&gt;
        /// &lt;td&gt;Resize secondary worker group&lt;/td&gt;
        /// &lt;/tr&gt;
        /// &lt;tr&gt;
        /// &lt;td&gt;config.autoscaling_config.policy_uri&lt;/td&gt;&lt;td&gt;Use, stop using, or
        /// change autoscaling policies&lt;/td&gt;
        /// &lt;/tr&gt;
        /// &lt;/tbody&gt;
        /// &lt;/table&gt;
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Cluster, ClusterOperationMetadata> UpdateCluster(string projectId, string region, string clusterName, Cluster cluster, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCluster(new UpdateClusterRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                ClusterName = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterName, nameof(clusterName)),
                Cluster = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a cluster in a project. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [ClusterOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#clusteroperationmetadata).
        /// The cluster must be in a
        /// [`RUNNING`][google.cloud.dataproc.v1.ClusterStatus.State] state or an error
        /// is returned.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project the
        /// cluster belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Dataproc region in which to handle the request.
        /// </param>
        /// <param name="clusterName">
        /// Required. The cluster name.
        /// </param>
        /// <param name="cluster">
        /// Required. The changes to the cluster.
        /// </param>
        /// <param name="updateMask">
        /// Required. Specifies the path, relative to `Cluster`, of
        /// the field to update. For example, to change the number of workers
        /// in a cluster to 5, the `update_mask` parameter would be
        /// specified as `config.worker_config.num_instances`,
        /// and the `PATCH` request body would specify the new value, as follows:
        /// 
        /// {
        /// "config":{
        /// "workerConfig":{
        /// "numInstances":"5"
        /// }
        /// }
        /// }
        /// Similarly, to change the number of preemptible workers in a cluster to 5,
        /// the `update_mask` parameter would be
        /// `config.secondary_worker_config.num_instances`, and the `PATCH` request
        /// body would be set as follows:
        /// 
        /// {
        /// "config":{
        /// "secondaryWorkerConfig":{
        /// "numInstances":"5"
        /// }
        /// }
        /// }
        /// &lt;strong&gt;Note:&lt;/strong&gt; Currently, only the following fields can be updated:
        /// 
        /// &lt;table&gt;
        /// &lt;tbody&gt;
        /// &lt;tr&gt;
        /// &lt;td&gt;&lt;strong&gt;Mask&lt;/strong&gt;&lt;/td&gt;
        /// &lt;td&gt;&lt;strong&gt;Purpose&lt;/strong&gt;&lt;/td&gt;
        /// &lt;/tr&gt;
        /// &lt;tr&gt;
        /// &lt;td&gt;&lt;strong&gt;&lt;em&gt;labels&lt;/em&gt;&lt;/strong&gt;&lt;/td&gt;
        /// &lt;td&gt;Update labels&lt;/td&gt;
        /// &lt;/tr&gt;
        /// &lt;tr&gt;
        /// &lt;td&gt;&lt;strong&gt;&lt;em&gt;config.worker_config.num_instances&lt;/em&gt;&lt;/strong&gt;&lt;/td&gt;
        /// &lt;td&gt;Resize primary worker group&lt;/td&gt;
        /// &lt;/tr&gt;
        /// &lt;tr&gt;
        /// &lt;td&gt;&lt;strong&gt;&lt;em&gt;config.secondary_worker_config.num_instances&lt;/em&gt;&lt;/strong&gt;&lt;/td&gt;
        /// &lt;td&gt;Resize secondary worker group&lt;/td&gt;
        /// &lt;/tr&gt;
        /// &lt;tr&gt;
        /// &lt;td&gt;config.autoscaling_config.policy_uri&lt;/td&gt;&lt;td&gt;Use, stop using, or
        /// change autoscaling policies&lt;/td&gt;
        /// &lt;/tr&gt;
        /// &lt;/tbody&gt;
        /// &lt;/table&gt;
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, ClusterOperationMetadata>> UpdateClusterAsync(string projectId, string region, string clusterName, Cluster cluster, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateClusterAsync(new UpdateClusterRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                ClusterName = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterName, nameof(clusterName)),
                Cluster = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a cluster in a project. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [ClusterOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#clusteroperationmetadata).
        /// The cluster must be in a
        /// [`RUNNING`][google.cloud.dataproc.v1.ClusterStatus.State] state or an error
        /// is returned.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project the
        /// cluster belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Dataproc region in which to handle the request.
        /// </param>
        /// <param name="clusterName">
        /// Required. The cluster name.
        /// </param>
        /// <param name="cluster">
        /// Required. The changes to the cluster.
        /// </param>
        /// <param name="updateMask">
        /// Required. Specifies the path, relative to `Cluster`, of
        /// the field to update. For example, to change the number of workers
        /// in a cluster to 5, the `update_mask` parameter would be
        /// specified as `config.worker_config.num_instances`,
        /// and the `PATCH` request body would specify the new value, as follows:
        /// 
        /// {
        /// "config":{
        /// "workerConfig":{
        /// "numInstances":"5"
        /// }
        /// }
        /// }
        /// Similarly, to change the number of preemptible workers in a cluster to 5,
        /// the `update_mask` parameter would be
        /// `config.secondary_worker_config.num_instances`, and the `PATCH` request
        /// body would be set as follows:
        /// 
        /// {
        /// "config":{
        /// "secondaryWorkerConfig":{
        /// "numInstances":"5"
        /// }
        /// }
        /// }
        /// &lt;strong&gt;Note:&lt;/strong&gt; Currently, only the following fields can be updated:
        /// 
        /// &lt;table&gt;
        /// &lt;tbody&gt;
        /// &lt;tr&gt;
        /// &lt;td&gt;&lt;strong&gt;Mask&lt;/strong&gt;&lt;/td&gt;
        /// &lt;td&gt;&lt;strong&gt;Purpose&lt;/strong&gt;&lt;/td&gt;
        /// &lt;/tr&gt;
        /// &lt;tr&gt;
        /// &lt;td&gt;&lt;strong&gt;&lt;em&gt;labels&lt;/em&gt;&lt;/strong&gt;&lt;/td&gt;
        /// &lt;td&gt;Update labels&lt;/td&gt;
        /// &lt;/tr&gt;
        /// &lt;tr&gt;
        /// &lt;td&gt;&lt;strong&gt;&lt;em&gt;config.worker_config.num_instances&lt;/em&gt;&lt;/strong&gt;&lt;/td&gt;
        /// &lt;td&gt;Resize primary worker group&lt;/td&gt;
        /// &lt;/tr&gt;
        /// &lt;tr&gt;
        /// &lt;td&gt;&lt;strong&gt;&lt;em&gt;config.secondary_worker_config.num_instances&lt;/em&gt;&lt;/strong&gt;&lt;/td&gt;
        /// &lt;td&gt;Resize secondary worker group&lt;/td&gt;
        /// &lt;/tr&gt;
        /// &lt;tr&gt;
        /// &lt;td&gt;config.autoscaling_config.policy_uri&lt;/td&gt;&lt;td&gt;Use, stop using, or
        /// change autoscaling policies&lt;/td&gt;
        /// &lt;/tr&gt;
        /// &lt;/tbody&gt;
        /// &lt;/table&gt;
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, ClusterOperationMetadata>> UpdateClusterAsync(string projectId, string region, string clusterName, Cluster cluster, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateClusterAsync(projectId, region, clusterName, cluster, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Stops a cluster in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Cluster, ClusterOperationMetadata> StopCluster(StopClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops a cluster in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, ClusterOperationMetadata>> StopClusterAsync(StopClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops a cluster in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, ClusterOperationMetadata>> StopClusterAsync(StopClusterRequest request, st::CancellationToken cancellationToken) =>
            StopClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>StopCluster</c>.</summary>
        public virtual lro::OperationsClient StopClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>StopCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Cluster, ClusterOperationMetadata> PollOnceStopCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Cluster, ClusterOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StopClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>StopCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Cluster, ClusterOperationMetadata>> PollOnceStopClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Cluster, ClusterOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StopClusterOperationsClient, callSettings);

        /// <summary>
        /// Starts a cluster in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Cluster, ClusterOperationMetadata> StartCluster(StartClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts a cluster in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, ClusterOperationMetadata>> StartClusterAsync(StartClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts a cluster in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, ClusterOperationMetadata>> StartClusterAsync(StartClusterRequest request, st::CancellationToken cancellationToken) =>
            StartClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>StartCluster</c>.</summary>
        public virtual lro::OperationsClient StartClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>StartCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Cluster, ClusterOperationMetadata> PollOnceStartCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Cluster, ClusterOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StartClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>StartCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Cluster, ClusterOperationMetadata>> PollOnceStartClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Cluster, ClusterOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StartClusterOperationsClient, callSettings);

        /// <summary>
        /// Deletes a cluster in a project. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [ClusterOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#clusteroperationmetadata).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, ClusterOperationMetadata> DeleteCluster(DeleteClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a cluster in a project. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [ClusterOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#clusteroperationmetadata).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, ClusterOperationMetadata>> DeleteClusterAsync(DeleteClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a cluster in a project. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [ClusterOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#clusteroperationmetadata).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, ClusterOperationMetadata>> DeleteClusterAsync(DeleteClusterRequest request, st::CancellationToken cancellationToken) =>
            DeleteClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteCluster</c>.</summary>
        public virtual lro::OperationsClient DeleteClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, ClusterOperationMetadata> PollOnceDeleteCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, ClusterOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, ClusterOperationMetadata>> PollOnceDeleteClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, ClusterOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteClusterOperationsClient, callSettings);

        /// <summary>
        /// Deletes a cluster in a project. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [ClusterOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#clusteroperationmetadata).
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the cluster
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Dataproc region in which to handle the request.
        /// </param>
        /// <param name="clusterName">
        /// Required. The cluster name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, ClusterOperationMetadata> DeleteCluster(string projectId, string region, string clusterName, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCluster(new DeleteClusterRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                ClusterName = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterName, nameof(clusterName)),
            }, callSettings);

        /// <summary>
        /// Deletes a cluster in a project. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [ClusterOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#clusteroperationmetadata).
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the cluster
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Dataproc region in which to handle the request.
        /// </param>
        /// <param name="clusterName">
        /// Required. The cluster name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, ClusterOperationMetadata>> DeleteClusterAsync(string projectId, string region, string clusterName, gaxgrpc::CallSettings callSettings = null) =>
            DeleteClusterAsync(new DeleteClusterRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                ClusterName = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterName, nameof(clusterName)),
            }, callSettings);

        /// <summary>
        /// Deletes a cluster in a project. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [ClusterOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#clusteroperationmetadata).
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the cluster
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Dataproc region in which to handle the request.
        /// </param>
        /// <param name="clusterName">
        /// Required. The cluster name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, ClusterOperationMetadata>> DeleteClusterAsync(string projectId, string region, string clusterName, st::CancellationToken cancellationToken) =>
            DeleteClusterAsync(projectId, region, clusterName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the resource representation for a cluster in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Cluster GetCluster(GetClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the resource representation for a cluster in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Cluster> GetClusterAsync(GetClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the resource representation for a cluster in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Cluster> GetClusterAsync(GetClusterRequest request, st::CancellationToken cancellationToken) =>
            GetClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the resource representation for a cluster in a project.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the cluster
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Dataproc region in which to handle the request.
        /// </param>
        /// <param name="clusterName">
        /// Required. The cluster name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Cluster GetCluster(string projectId, string region, string clusterName, gaxgrpc::CallSettings callSettings = null) =>
            GetCluster(new GetClusterRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                ClusterName = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterName, nameof(clusterName)),
            }, callSettings);

        /// <summary>
        /// Gets the resource representation for a cluster in a project.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the cluster
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Dataproc region in which to handle the request.
        /// </param>
        /// <param name="clusterName">
        /// Required. The cluster name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Cluster> GetClusterAsync(string projectId, string region, string clusterName, gaxgrpc::CallSettings callSettings = null) =>
            GetClusterAsync(new GetClusterRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                ClusterName = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterName, nameof(clusterName)),
            }, callSettings);

        /// <summary>
        /// Gets the resource representation for a cluster in a project.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the cluster
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Dataproc region in which to handle the request.
        /// </param>
        /// <param name="clusterName">
        /// Required. The cluster name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Cluster> GetClusterAsync(string projectId, string region, string clusterName, st::CancellationToken cancellationToken) =>
            GetClusterAsync(projectId, region, clusterName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all regions/{region}/clusters in a project alphabetically.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Cluster"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListClustersResponse, Cluster> ListClusters(ListClustersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all regions/{region}/clusters in a project alphabetically.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Cluster"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListClustersResponse, Cluster> ListClustersAsync(ListClustersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all regions/{region}/clusters in a project alphabetically.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the cluster
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Dataproc region in which to handle the request.
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
        /// <returns>A pageable sequence of <see cref="Cluster"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListClustersResponse, Cluster> ListClusters(string projectId, string region, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListClustersRequest request = new ListClustersRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
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
            return ListClusters(request, callSettings);
        }

        /// <summary>
        /// Lists all regions/{region}/clusters in a project alphabetically.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the cluster
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Dataproc region in which to handle the request.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Cluster"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListClustersResponse, Cluster> ListClustersAsync(string projectId, string region, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListClustersRequest request = new ListClustersRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
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
            return ListClustersAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all regions/{region}/clusters in a project alphabetically.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the cluster
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Dataproc region in which to handle the request.
        /// </param>
        /// <param name="filter">
        /// Optional. A filter constraining the clusters to list. Filters are
        /// case-sensitive and have the following syntax:
        /// 
        /// field = value [AND [field = value]] ...
        /// 
        /// where **field** is one of `status.state`, `clusterName`, or `labels.[KEY]`,
        /// and `[KEY]` is a label key. **value** can be `*` to match all values.
        /// `status.state` can be one of the following: `ACTIVE`, `INACTIVE`,
        /// `CREATING`, `RUNNING`, `ERROR`, `DELETING`, `UPDATING`, `STOPPING`, or
        /// `STOPPED`. `ACTIVE` contains the `CREATING`, `UPDATING`, and `RUNNING`
        /// states. `INACTIVE` contains the `DELETING`, `ERROR`, `STOPPING`, and
        /// `STOPPED` states. `clusterName` is the name of the cluster provided at
        /// creation time. Only the logical `AND` operator is supported;
        /// space-separated items are treated as having an implicit `AND` operator.
        /// 
        /// Example filter:
        /// 
        /// status.state = ACTIVE AND clusterName = mycluster
        /// AND labels.env = staging AND labels.starred = *
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
        /// <returns>A pageable sequence of <see cref="Cluster"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListClustersResponse, Cluster> ListClusters(string projectId, string region, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListClustersRequest request = new ListClustersRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                Filter = filter ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListClusters(request, callSettings);
        }

        /// <summary>
        /// Lists all regions/{region}/clusters in a project alphabetically.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the cluster
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Dataproc region in which to handle the request.
        /// </param>
        /// <param name="filter">
        /// Optional. A filter constraining the clusters to list. Filters are
        /// case-sensitive and have the following syntax:
        /// 
        /// field = value [AND [field = value]] ...
        /// 
        /// where **field** is one of `status.state`, `clusterName`, or `labels.[KEY]`,
        /// and `[KEY]` is a label key. **value** can be `*` to match all values.
        /// `status.state` can be one of the following: `ACTIVE`, `INACTIVE`,
        /// `CREATING`, `RUNNING`, `ERROR`, `DELETING`, `UPDATING`, `STOPPING`, or
        /// `STOPPED`. `ACTIVE` contains the `CREATING`, `UPDATING`, and `RUNNING`
        /// states. `INACTIVE` contains the `DELETING`, `ERROR`, `STOPPING`, and
        /// `STOPPED` states. `clusterName` is the name of the cluster provided at
        /// creation time. Only the logical `AND` operator is supported;
        /// space-separated items are treated as having an implicit `AND` operator.
        /// 
        /// Example filter:
        /// 
        /// status.state = ACTIVE AND clusterName = mycluster
        /// AND labels.env = staging AND labels.starred = *
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
        /// <returns>A pageable asynchronous sequence of <see cref="Cluster"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListClustersResponse, Cluster> ListClustersAsync(string projectId, string region, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListClustersRequest request = new ListClustersRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                Filter = filter ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListClustersAsync(request, callSettings);
        }

        /// <summary>
        /// Gets cluster diagnostic information. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [ClusterOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#clusteroperationmetadata).
        /// After the operation completes,
        /// [Operation.response][google.longrunning.Operation.response]
        /// contains
        /// [DiagnoseClusterResults](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#diagnoseclusterresults).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DiagnoseClusterResults, ClusterOperationMetadata> DiagnoseCluster(DiagnoseClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets cluster diagnostic information. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [ClusterOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#clusteroperationmetadata).
        /// After the operation completes,
        /// [Operation.response][google.longrunning.Operation.response]
        /// contains
        /// [DiagnoseClusterResults](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#diagnoseclusterresults).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DiagnoseClusterResults, ClusterOperationMetadata>> DiagnoseClusterAsync(DiagnoseClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets cluster diagnostic information. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [ClusterOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#clusteroperationmetadata).
        /// After the operation completes,
        /// [Operation.response][google.longrunning.Operation.response]
        /// contains
        /// [DiagnoseClusterResults](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#diagnoseclusterresults).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DiagnoseClusterResults, ClusterOperationMetadata>> DiagnoseClusterAsync(DiagnoseClusterRequest request, st::CancellationToken cancellationToken) =>
            DiagnoseClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DiagnoseCluster</c>.</summary>
        public virtual lro::OperationsClient DiagnoseClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DiagnoseCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DiagnoseClusterResults, ClusterOperationMetadata> PollOnceDiagnoseCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DiagnoseClusterResults, ClusterOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DiagnoseClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DiagnoseCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DiagnoseClusterResults, ClusterOperationMetadata>> PollOnceDiagnoseClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DiagnoseClusterResults, ClusterOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DiagnoseClusterOperationsClient, callSettings);

        /// <summary>
        /// Gets cluster diagnostic information. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [ClusterOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#clusteroperationmetadata).
        /// After the operation completes,
        /// [Operation.response][google.longrunning.Operation.response]
        /// contains
        /// [DiagnoseClusterResults](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#diagnoseclusterresults).
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the cluster
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Dataproc region in which to handle the request.
        /// </param>
        /// <param name="clusterName">
        /// Required. The cluster name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DiagnoseClusterResults, ClusterOperationMetadata> DiagnoseCluster(string projectId, string region, string clusterName, gaxgrpc::CallSettings callSettings = null) =>
            DiagnoseCluster(new DiagnoseClusterRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                ClusterName = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterName, nameof(clusterName)),
            }, callSettings);

        /// <summary>
        /// Gets cluster diagnostic information. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [ClusterOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#clusteroperationmetadata).
        /// After the operation completes,
        /// [Operation.response][google.longrunning.Operation.response]
        /// contains
        /// [DiagnoseClusterResults](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#diagnoseclusterresults).
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the cluster
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Dataproc region in which to handle the request.
        /// </param>
        /// <param name="clusterName">
        /// Required. The cluster name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DiagnoseClusterResults, ClusterOperationMetadata>> DiagnoseClusterAsync(string projectId, string region, string clusterName, gaxgrpc::CallSettings callSettings = null) =>
            DiagnoseClusterAsync(new DiagnoseClusterRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                ClusterName = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterName, nameof(clusterName)),
            }, callSettings);

        /// <summary>
        /// Gets cluster diagnostic information. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [ClusterOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#clusteroperationmetadata).
        /// After the operation completes,
        /// [Operation.response][google.longrunning.Operation.response]
        /// contains
        /// [DiagnoseClusterResults](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#diagnoseclusterresults).
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the Google Cloud Platform project that the cluster
        /// belongs to.
        /// </param>
        /// <param name="region">
        /// Required. The Dataproc region in which to handle the request.
        /// </param>
        /// <param name="clusterName">
        /// Required. The cluster name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DiagnoseClusterResults, ClusterOperationMetadata>> DiagnoseClusterAsync(string projectId, string region, string clusterName, st::CancellationToken cancellationToken) =>
            DiagnoseClusterAsync(projectId, region, clusterName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ClusterController client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The ClusterControllerService provides methods to manage clusters
    /// of Compute Engine instances.
    /// </remarks>
    public sealed partial class ClusterControllerClientImpl : ClusterControllerClient
    {
        private readonly gaxgrpc::ApiCall<CreateClusterRequest, lro::Operation> _callCreateCluster;

        private readonly gaxgrpc::ApiCall<UpdateClusterRequest, lro::Operation> _callUpdateCluster;

        private readonly gaxgrpc::ApiCall<StopClusterRequest, lro::Operation> _callStopCluster;

        private readonly gaxgrpc::ApiCall<StartClusterRequest, lro::Operation> _callStartCluster;

        private readonly gaxgrpc::ApiCall<DeleteClusterRequest, lro::Operation> _callDeleteCluster;

        private readonly gaxgrpc::ApiCall<GetClusterRequest, Cluster> _callGetCluster;

        private readonly gaxgrpc::ApiCall<ListClustersRequest, ListClustersResponse> _callListClusters;

        private readonly gaxgrpc::ApiCall<DiagnoseClusterRequest, lro::Operation> _callDiagnoseCluster;

        /// <summary>
        /// Constructs a client wrapper for the ClusterController service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ClusterControllerSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ClusterControllerClientImpl(ClusterController.ClusterControllerClient grpcClient, ClusterControllerSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ClusterControllerSettings effectiveSettings = settings ?? ClusterControllerSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateClusterOperationsSettings, logger);
            UpdateClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateClusterOperationsSettings, logger);
            StopClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.StopClusterOperationsSettings, logger);
            StartClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.StartClusterOperationsSettings, logger);
            DeleteClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteClusterOperationsSettings, logger);
            DiagnoseClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DiagnoseClusterOperationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreateCluster = clientHelper.BuildApiCall<CreateClusterRequest, lro::Operation>("CreateCluster", grpcClient.CreateClusterAsync, grpcClient.CreateCluster, effectiveSettings.CreateClusterSettings).WithGoogleRequestParam("project_id", request => request.ProjectId).WithGoogleRequestParam("region", request => request.Region);
            Modify_ApiCall(ref _callCreateCluster);
            Modify_CreateClusterApiCall(ref _callCreateCluster);
            _callUpdateCluster = clientHelper.BuildApiCall<UpdateClusterRequest, lro::Operation>("UpdateCluster", grpcClient.UpdateClusterAsync, grpcClient.UpdateCluster, effectiveSettings.UpdateClusterSettings).WithGoogleRequestParam("project_id", request => request.ProjectId).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("cluster_name", request => request.ClusterName);
            Modify_ApiCall(ref _callUpdateCluster);
            Modify_UpdateClusterApiCall(ref _callUpdateCluster);
            _callStopCluster = clientHelper.BuildApiCall<StopClusterRequest, lro::Operation>("StopCluster", grpcClient.StopClusterAsync, grpcClient.StopCluster, effectiveSettings.StopClusterSettings).WithGoogleRequestParam("project_id", request => request.ProjectId).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("cluster_name", request => request.ClusterName);
            Modify_ApiCall(ref _callStopCluster);
            Modify_StopClusterApiCall(ref _callStopCluster);
            _callStartCluster = clientHelper.BuildApiCall<StartClusterRequest, lro::Operation>("StartCluster", grpcClient.StartClusterAsync, grpcClient.StartCluster, effectiveSettings.StartClusterSettings).WithGoogleRequestParam("project_id", request => request.ProjectId).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("cluster_name", request => request.ClusterName);
            Modify_ApiCall(ref _callStartCluster);
            Modify_StartClusterApiCall(ref _callStartCluster);
            _callDeleteCluster = clientHelper.BuildApiCall<DeleteClusterRequest, lro::Operation>("DeleteCluster", grpcClient.DeleteClusterAsync, grpcClient.DeleteCluster, effectiveSettings.DeleteClusterSettings).WithGoogleRequestParam("project_id", request => request.ProjectId).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("cluster_name", request => request.ClusterName);
            Modify_ApiCall(ref _callDeleteCluster);
            Modify_DeleteClusterApiCall(ref _callDeleteCluster);
            _callGetCluster = clientHelper.BuildApiCall<GetClusterRequest, Cluster>("GetCluster", grpcClient.GetClusterAsync, grpcClient.GetCluster, effectiveSettings.GetClusterSettings).WithGoogleRequestParam("project_id", request => request.ProjectId).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("cluster_name", request => request.ClusterName);
            Modify_ApiCall(ref _callGetCluster);
            Modify_GetClusterApiCall(ref _callGetCluster);
            _callListClusters = clientHelper.BuildApiCall<ListClustersRequest, ListClustersResponse>("ListClusters", grpcClient.ListClustersAsync, grpcClient.ListClusters, effectiveSettings.ListClustersSettings).WithGoogleRequestParam("project_id", request => request.ProjectId).WithGoogleRequestParam("region", request => request.Region);
            Modify_ApiCall(ref _callListClusters);
            Modify_ListClustersApiCall(ref _callListClusters);
            _callDiagnoseCluster = clientHelper.BuildApiCall<DiagnoseClusterRequest, lro::Operation>("DiagnoseCluster", grpcClient.DiagnoseClusterAsync, grpcClient.DiagnoseCluster, effectiveSettings.DiagnoseClusterSettings).WithGoogleRequestParam("project_id", request => request.ProjectId).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("cluster_name", request => request.ClusterName);
            Modify_ApiCall(ref _callDiagnoseCluster);
            Modify_DiagnoseClusterApiCall(ref _callDiagnoseCluster);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateClusterApiCall(ref gaxgrpc::ApiCall<CreateClusterRequest, lro::Operation> call);

        partial void Modify_UpdateClusterApiCall(ref gaxgrpc::ApiCall<UpdateClusterRequest, lro::Operation> call);

        partial void Modify_StopClusterApiCall(ref gaxgrpc::ApiCall<StopClusterRequest, lro::Operation> call);

        partial void Modify_StartClusterApiCall(ref gaxgrpc::ApiCall<StartClusterRequest, lro::Operation> call);

        partial void Modify_DeleteClusterApiCall(ref gaxgrpc::ApiCall<DeleteClusterRequest, lro::Operation> call);

        partial void Modify_GetClusterApiCall(ref gaxgrpc::ApiCall<GetClusterRequest, Cluster> call);

        partial void Modify_ListClustersApiCall(ref gaxgrpc::ApiCall<ListClustersRequest, ListClustersResponse> call);

        partial void Modify_DiagnoseClusterApiCall(ref gaxgrpc::ApiCall<DiagnoseClusterRequest, lro::Operation> call);

        partial void OnConstruction(ClusterController.ClusterControllerClient grpcClient, ClusterControllerSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ClusterController client</summary>
        public override ClusterController.ClusterControllerClient GrpcClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateClusterRequest(ref CreateClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateClusterRequest(ref UpdateClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StopClusterRequest(ref StopClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StartClusterRequest(ref StartClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteClusterRequest(ref DeleteClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetClusterRequest(ref GetClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListClustersRequest(ref ListClustersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DiagnoseClusterRequest(ref DiagnoseClusterRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateCluster</c>.</summary>
        public override lro::OperationsClient CreateClusterOperationsClient { get; }

        /// <summary>
        /// Creates a cluster in a project. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [ClusterOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#clusteroperationmetadata).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Cluster, ClusterOperationMetadata> CreateCluster(CreateClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateClusterRequest(ref request, ref callSettings);
            return new lro::Operation<Cluster, ClusterOperationMetadata>(_callCreateCluster.Sync(request, callSettings), CreateClusterOperationsClient);
        }

        /// <summary>
        /// Creates a cluster in a project. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [ClusterOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#clusteroperationmetadata).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Cluster, ClusterOperationMetadata>> CreateClusterAsync(CreateClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateClusterRequest(ref request, ref callSettings);
            return new lro::Operation<Cluster, ClusterOperationMetadata>(await _callCreateCluster.Async(request, callSettings).ConfigureAwait(false), CreateClusterOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateCluster</c>.</summary>
        public override lro::OperationsClient UpdateClusterOperationsClient { get; }

        /// <summary>
        /// Updates a cluster in a project. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [ClusterOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#clusteroperationmetadata).
        /// The cluster must be in a
        /// [`RUNNING`][google.cloud.dataproc.v1.ClusterStatus.State] state or an error
        /// is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Cluster, ClusterOperationMetadata> UpdateCluster(UpdateClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateClusterRequest(ref request, ref callSettings);
            return new lro::Operation<Cluster, ClusterOperationMetadata>(_callUpdateCluster.Sync(request, callSettings), UpdateClusterOperationsClient);
        }

        /// <summary>
        /// Updates a cluster in a project. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [ClusterOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#clusteroperationmetadata).
        /// The cluster must be in a
        /// [`RUNNING`][google.cloud.dataproc.v1.ClusterStatus.State] state or an error
        /// is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Cluster, ClusterOperationMetadata>> UpdateClusterAsync(UpdateClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateClusterRequest(ref request, ref callSettings);
            return new lro::Operation<Cluster, ClusterOperationMetadata>(await _callUpdateCluster.Async(request, callSettings).ConfigureAwait(false), UpdateClusterOperationsClient);
        }

        /// <summary>The long-running operations client for <c>StopCluster</c>.</summary>
        public override lro::OperationsClient StopClusterOperationsClient { get; }

        /// <summary>
        /// Stops a cluster in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Cluster, ClusterOperationMetadata> StopCluster(StopClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopClusterRequest(ref request, ref callSettings);
            return new lro::Operation<Cluster, ClusterOperationMetadata>(_callStopCluster.Sync(request, callSettings), StopClusterOperationsClient);
        }

        /// <summary>
        /// Stops a cluster in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Cluster, ClusterOperationMetadata>> StopClusterAsync(StopClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopClusterRequest(ref request, ref callSettings);
            return new lro::Operation<Cluster, ClusterOperationMetadata>(await _callStopCluster.Async(request, callSettings).ConfigureAwait(false), StopClusterOperationsClient);
        }

        /// <summary>The long-running operations client for <c>StartCluster</c>.</summary>
        public override lro::OperationsClient StartClusterOperationsClient { get; }

        /// <summary>
        /// Starts a cluster in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Cluster, ClusterOperationMetadata> StartCluster(StartClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartClusterRequest(ref request, ref callSettings);
            return new lro::Operation<Cluster, ClusterOperationMetadata>(_callStartCluster.Sync(request, callSettings), StartClusterOperationsClient);
        }

        /// <summary>
        /// Starts a cluster in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Cluster, ClusterOperationMetadata>> StartClusterAsync(StartClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartClusterRequest(ref request, ref callSettings);
            return new lro::Operation<Cluster, ClusterOperationMetadata>(await _callStartCluster.Async(request, callSettings).ConfigureAwait(false), StartClusterOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteCluster</c>.</summary>
        public override lro::OperationsClient DeleteClusterOperationsClient { get; }

        /// <summary>
        /// Deletes a cluster in a project. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [ClusterOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#clusteroperationmetadata).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, ClusterOperationMetadata> DeleteCluster(DeleteClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteClusterRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, ClusterOperationMetadata>(_callDeleteCluster.Sync(request, callSettings), DeleteClusterOperationsClient);
        }

        /// <summary>
        /// Deletes a cluster in a project. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [ClusterOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#clusteroperationmetadata).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, ClusterOperationMetadata>> DeleteClusterAsync(DeleteClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteClusterRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, ClusterOperationMetadata>(await _callDeleteCluster.Async(request, callSettings).ConfigureAwait(false), DeleteClusterOperationsClient);
        }

        /// <summary>
        /// Gets the resource representation for a cluster in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Cluster GetCluster(GetClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetClusterRequest(ref request, ref callSettings);
            return _callGetCluster.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the resource representation for a cluster in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Cluster> GetClusterAsync(GetClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetClusterRequest(ref request, ref callSettings);
            return _callGetCluster.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all regions/{region}/clusters in a project alphabetically.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Cluster"/> resources.</returns>
        public override gax::PagedEnumerable<ListClustersResponse, Cluster> ListClusters(ListClustersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListClustersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListClustersRequest, ListClustersResponse, Cluster>(_callListClusters, request, callSettings);
        }

        /// <summary>
        /// Lists all regions/{region}/clusters in a project alphabetically.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Cluster"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListClustersResponse, Cluster> ListClustersAsync(ListClustersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListClustersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListClustersRequest, ListClustersResponse, Cluster>(_callListClusters, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DiagnoseCluster</c>.</summary>
        public override lro::OperationsClient DiagnoseClusterOperationsClient { get; }

        /// <summary>
        /// Gets cluster diagnostic information. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [ClusterOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#clusteroperationmetadata).
        /// After the operation completes,
        /// [Operation.response][google.longrunning.Operation.response]
        /// contains
        /// [DiagnoseClusterResults](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#diagnoseclusterresults).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DiagnoseClusterResults, ClusterOperationMetadata> DiagnoseCluster(DiagnoseClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DiagnoseClusterRequest(ref request, ref callSettings);
            return new lro::Operation<DiagnoseClusterResults, ClusterOperationMetadata>(_callDiagnoseCluster.Sync(request, callSettings), DiagnoseClusterOperationsClient);
        }

        /// <summary>
        /// Gets cluster diagnostic information. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [ClusterOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#clusteroperationmetadata).
        /// After the operation completes,
        /// [Operation.response][google.longrunning.Operation.response]
        /// contains
        /// [DiagnoseClusterResults](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#diagnoseclusterresults).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DiagnoseClusterResults, ClusterOperationMetadata>> DiagnoseClusterAsync(DiagnoseClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DiagnoseClusterRequest(ref request, ref callSettings);
            return new lro::Operation<DiagnoseClusterResults, ClusterOperationMetadata>(await _callDiagnoseCluster.Async(request, callSettings).ConfigureAwait(false), DiagnoseClusterOperationsClient);
        }
    }

    public partial class ListClustersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListClustersResponse : gaxgrpc::IPageResponse<Cluster>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Cluster> GetEnumerator() => Clusters.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ClusterController
    {
        public partial class ClusterControllerClient
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

    public static partial class ClusterController
    {
        public partial class ClusterControllerClient
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
